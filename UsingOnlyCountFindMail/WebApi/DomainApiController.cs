using System.Collections;
using System.Collections.Generic;
using System.Web.Http;
using UsingOnlyCountFindMail.Classes;

namespace UsingOnlyCountFindMail.WebApi
{
    public class DomainApiController : ApiController
    {
        [HttpPost]
        public Domain SendDomains(List<Domain> _findnotmail)
        {
            var domains = new Controllers.DomainController();
            return domains.FindConst(_findnotmail);
        }
    }
}
