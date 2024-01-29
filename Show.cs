using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_Shows_Now
{
    //  Käytetään sisäkkäistä classia, koska json:n mukana tulee kaksi objektia
    public class SearchResult
    {
        public double? Score { get; set; }
        public Show? Show { get; set; }
    }

    public class Show
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Summary { get; set; }
        public string? Premiered { get; set; }
        public string? Ended { get; set; }
        public string? Runtime { get; set; }
        public string? Language { get; set; }
        public List<string>? Genres { get; set; }
        public Network? Network { get; set; }
        public Webchannel? webChannel { get; set; }
        public Image? Image { get; set; }
        public List<Cast>? Cast { get; set; }
        public string? OfficialSite { get; set; }
    }

    public class Network
    {
        public string? Name { get; set; }
    }

    public class Webchannel
    {
        public string? Name { get; set; }
    }

    public class Image
    {
        public string? Medium { get; set; }
    }

    public class Cast

    {
        public int? Id { get; set; }
        public Person? Person { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
