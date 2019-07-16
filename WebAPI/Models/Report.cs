using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Report
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Saz { get; set; }

        public string FileUrl { get; set; }

        public Report(string name, string family, string state, string city, string saz, string fileUrl)
        {
            Name = name;

            Family = family;

            State = state;

            City = city;

            Saz = saz;

            FileUrl = fileUrl;
        }
    }
}
