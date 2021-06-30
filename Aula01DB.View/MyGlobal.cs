using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01DB.View
{
    class MyGlobal
    {
        public static string MontaMensagemErro(Exception ex)
        {
            string retorno = ex.Message;
            if(ex.InnerException== null)
            {
                return retorno;
            }
            else
            {
                string Erro1 = MontaMensagemErro(ex.InnerException);
                return retorno + "-" + Erro1;
            }
        }
    }
}
