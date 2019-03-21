using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bundles.Models;
using Bundles.Code;

namespace BundleAPI.Controllers
{
    public class BundleController : ApiController
    {
        private Bundle bundle = new Bundle();

        public IHttpActionResult GetProduct(int age, bool isStudent, int income)
        {
            BussinesRules logic = new BussinesRules();

            bundle.Bundles = logic.GetBundle(age, isStudent, income);

            if (bundle.Bundles == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
                
            }

            return Ok(bundle);
        }

        public IHttpActionResult GetProduct(int age, bool isStudent)
        {
            BussinesRules logic = new BussinesRules();

            bundle.Bundles = logic.GetBundle(age, isStudent, 0);

            if (bundle.Bundles == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Ok(bundle);
        }
    }
}
