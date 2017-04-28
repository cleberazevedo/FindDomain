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

            //Como somente preciso da constante igual faço um Linq com uma expressão 
            //depois faço um Count pra saber se existe valor igual

            var returnCount = _findnotmail.Where(c => c.Mail.Equals(constante));
            if (returnCount.Count() > decimal.Zero)
                return returnCount.FirstOrDefault();

            return null;
        }

        //PS
        //Teria outra sugestão usando override
        //Reescrevo o Count para utiliza-lô

        public Domain result = new Domain();
        List<Domain> _listDomains = new List<Domain>();

        public int Count
        {
            get
            {
                foreach (var d in _listDomains)
                {
                    var split = d.Mail.Split('@');

                    //Se não tem arroba não é email, logo não há motivos para maiores validações
                    if (split == null)
                    {
                        //Ainda usando o Count
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