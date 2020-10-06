using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace WpfAppCloudService.Controllers
{
    public class TimerController : ApiController
    {
        // GET: api/Timer     

        public IHttpActionResult Get()
        {
            string str = "";
            DayOfWeek ThisDay = DateTime.Today.DayOfWeek;
            str = ThisDay.ToString();
            string s = System.Web.HttpContext.Current.Request.HttpMethod;

            return Ok(str + s);

        }

        
    }
}
