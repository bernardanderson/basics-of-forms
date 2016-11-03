using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicsOfForms.Controllers
{
    public class AngularApiController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(dynamic sentFormData)
        {
            // Using Docs at https://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/action-results
            // To make a simple return reponse to the Angular Controller 
            HttpResponseMessage simpleReponse = Request.CreateResponse(HttpStatusCode.OK, 200);

            int i = 0;

            return simpleReponse;
        }
    }
}