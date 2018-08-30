using System.Collections.Generic;
using UsingOnlyCountFindMail.Classes;
using System.Linq;

namespace UsingOnlyCountFindMail.Controllers
{
    public class DomainController
    {
        const string constante = "www.blinks.com.br";               
        
        public Domain FindConst(List<Domain> _findnotmail)
        {            
            _listDomains.AddRange(_findnotmail);
            var returnCount = _findnotmail.Where(c => c.Mail.Equals(constante));
            if (returnCount.Count() > decimal.Zero)
                return returnCount.FirstOrDefault();

            return null;
        }

        public Domain result = new Domain();
        List<Domain> _listDomains = new List<Domain>();

        public int Count
        {
            get
            {
                foreach (var d in _listDomains)
                {
                    var split = d.Mail.Split('@');
                    if (split == null)
                    {
                        if (d.Mail.Equals(constante))
                        {
                            result.Mail = d.Mail;
                            result.Name = d.Name;

                            return 1;
                        }
                    }
                }

                return 0;
            }
        }
    }
}
