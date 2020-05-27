using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Covid19Helpdesk.Models
{
    public class Countries
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public string NewConfirmed { get; set; }
        public string TotalConfirmed { get; set; }
        public string NewDeaths { get; set; }
        public string TotalDeaths { get; set; }
        public string NewRecovered { get; set; }
        public string TotalRecovered { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Date { get; set; }
    }
}