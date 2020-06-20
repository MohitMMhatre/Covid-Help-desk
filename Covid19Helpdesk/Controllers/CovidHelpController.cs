using Covid19Helpdesk.Common;
using Covid19Helpdesk.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Covid19Helpdesk.Controllers
{
    public class CovidHelpController : Controller
    {
        // GET: CovidHelp
        public async Task<ActionResult> GetSummary()
        {
            Summary summary = new Summary();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(APIS.Summary);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("/summary");
                if (Res.IsSuccessStatusCode)
                {
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;
                    summary = JsonConvert.DeserializeObject<Summary>(EmpResponse);
                }
            }
            return View(summary);
        }
    }
}