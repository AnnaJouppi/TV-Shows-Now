using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.DirectoryServices;

namespace TV_Shows_Now
{
    public partial class Form1 : Form
    {   // asetetaan client ja show jo t�nne, jotta niit� voi k�ytt�� joka funktiossa
        private HttpClient client;
        private Show? show;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
        }
        // muutetaan tietyt osat n�kym�tt�miksi kun appi aukeaa
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            description.Visible = false;
            webBrowser1.Visible = false;
            castName1.Visible = false;
            castName2.Visible = false;
            castName3.Visible = false;
            castName4.Visible = false;
            labelStarring.Visible = false;
            pictureBoxShow.Enabled = false;
            officialWebsiteLink.Visible = false;
            languageText.Visible = false;
            labelLanguage.Visible = false;

            helpText.Visible = false;

        }
        
       

        // Funktio, joka hakee tiedot API:lta
        public async Task<List<SearchResult>> SearchShows(string query)
        {

            {   // Laitetaan kutsu apille, argumenttina teksti, jonka k�ytt�j� sy�tt�� hakukentt��n
                var response = await client.GetStringAsync($"https://api.tvmaze.com/search/shows?q={query}");

                // Deserialisoidaan eli muutetaan JSON-string objektiksi
                var searchResult = JsonConvert.DeserializeObject<List<SearchResult>>(response);
                // Jos searchResult on null, palautetaan tyhj� lista ettei tule erroreita
                if (searchResult == null)
                {
                    return new List<SearchResult>();
                }

                return searchResult;
            }
        }

        // Haetaan n�yttelij�iden tiedot
        public async Task<List<Cast>> GetShowCast(int? showId)
        {
            var response = await client.GetStringAsync($"https://api.tvmaze.com/shows/{showId}/cast");
            var cast = JsonConvert.DeserializeObject<List<Cast>>(response);

            if(cast == null)
            { 
                return new List<Cast>(); 
            }

            return cast;
        }
       
        

        // Napin klikkaus
        private async void button1_Click(object sender, EventArgs e)

        {   // Tallennetaan k�ytt�j�n antama teksti tekstilaatikosta kun nappia painetaan
            string query = textBox1.Text;
            dataGridView1.Visible = true;
            helpText.Visible = true;

            // jos query-string ei ole tyhj� eik� null
            if (!string.IsNullOrEmpty(query))
            {
                var searchResults = await SearchShows(query);

                

                // Luodaan lista show-objekteja
                var shows = searchResults.Select(sr => sr.Show).ToList();

                dataGridView1.DataSource = shows.Select(s => new {
                    s?.Name,
                    s?.Type,
                    s?.Premiered,
                    s?.Ended,
                    s?.Runtime,
                    Genres = string.Join(", ", s?.Genres ?? Enumerable.Empty<string>()),
                    Network = s?.Network?.Name,
                    Webchannel = s?.webChannel?.Name
                }).ToList();


                if (shows.Count == 0)
                {
                    MessageBox.Show("Your search returned no results. Please try again with a different search!", "No results found!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dataGridView1.Tag = shows;

                }

            }
        }

        public async void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Tarkistetaan onko klikkaus gridin headerissa, ei tehd� mit��n jos on
            if (e.RowIndex == -1 || e.ColumnIndex == -1) { return; }

            // Hae ekan ohjelman nimi ekasta kolumnista ja muuta se stringiksi
            object cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            string showName = (cellValue as string ?? "");

            if (dataGridView1.Tag is List<Show> showList && e.RowIndex >= 0 && e.RowIndex < showList.Count)
            {
                show = showList[e.RowIndex];
            }
            else
            {
                // Etsit��n yksi show, jotta saadaan sen n�yttelij�t
                var response = await client.GetStringAsync($"https://api.tvmaze.com/singlesearch/shows?q={showName}");
                show = JsonConvert.DeserializeObject<Show>(response);
            }

            if (show != null) {
                var noNullShow = show;

            if (noNullShow.Cast == null)
            {
                var castResults = await GetShowCast(show.Id);
                noNullShow.Cast = castResults;
            }
            }
            // Muuta UI:n kohteet n�kyviksi

            description.Visible = true;
            webBrowser1.Visible = true;
            if (show != null)

            { // K�ytet��n WebView2
                await webBrowser1.EnsureCoreWebView2Async(null);
                webBrowser1.NavigateToString(show.Summary);
            }
            labelStarring.Visible = true;
            pictureBoxShow.Enabled = true;
            labelLanguage.Visible = true;
            languageText.Visible = true;
            if (show != null)
            {
                languageText.Text = show.Language;
            }
            officialWebsiteLink.Visible = true;




            // N�yt� n�yttelij�iden nimet vain silloin kun ne ovat show.Castissa, muuten tyhj� string
            castName1.Text = "";
            castName2.Text = "";
            castName3.Text = "";
            castName4.Text = "";

            for (int i = 0; i < show?.Cast?.Count; i++)
            {
                var castMember = show.Cast[i]?.Person;
                if (castMember != null)
                {
                    switch (i)
                    {
                        case 0:
                            castName1.Visible = true;
                            castName1.Text = castMember.Name;
                            break;
                        case 1:
                            castName2.Visible = true;
                            castName2.Text = castMember.Name;
                            break;
                        case 2:
                            castName3.Visible = true;
                            castName3.Text = castMember.Name;
                            break;
                        case 3:
                            castName4.Visible = true;
                            castName4.Text = castMember.Name;
                            break;
                    }
                }
            }
            // Jos ohjelmalla ei ole nettisivua, linkki� ei n�ytet�
            if (show != null) { 
            if (show.OfficialSite == null)
            {
                officialWebsiteLink.Visible = false;
            }
}

            // N�yt� kuva pictureBoxissa
            if (show != null)
            {
                if (show.Image != null && !string.IsNullOrEmpty(show.Image.Medium))
                {
                    pictureBoxShow.ImageLocation = show.Image.Medium;
                }
                else
                {
                    pictureBoxShow.Image = Properties.Resources.cool_image;
                }
            }
        }
        // Linkki TV Mazen API-sivuille
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
               try
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        UseShellExecute = true,
                        FileName = "https://www.tvmaze.com/"
                    };
                    System.Diagnostics.Process.Start(psi);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception}");
                }
        }
        
        // Kuvan klikkaus
        public void pictureBoxShow_Click(object sender, EventArgs e)
        {

            if (show != null && !string.IsNullOrEmpty(show.OfficialSite))
            {
               try {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        UseShellExecute = true,
                        FileName = show.OfficialSite
                    };
                    System.Diagnostics.Process.Start(psi);
                }
                catch(Exception exception)
                {
                    MessageBox.Show($"{exception}");
                        }
            }

        }

        // Ohjelman nettisivun klikkaus
        private void officialWebsiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (show != null && !string.IsNullOrEmpty(show.OfficialSite))
            {
                try
                {
                    var psi = new System.Diagnostics.ProcessStartInfo
                    {
                        UseShellExecute = true,
                        FileName = show.OfficialSite
                    };
                    System.Diagnostics.Process.Start(psi);
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{exception}");
                }
            }
        }
    }
}
