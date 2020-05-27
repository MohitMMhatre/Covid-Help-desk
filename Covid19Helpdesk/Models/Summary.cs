using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19Helpdesk.Models
{
    public class Summary
    {
        public Global Global { get; set; }
        public IList<Countries> Countries { get; set; }
    }
}