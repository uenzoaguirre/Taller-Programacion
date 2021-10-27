using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication
{
    public class NotificadorMail : Inotificador
    {
        string mailRemitente;
        int password;
        int puerto;
        bool eneableSSL; 
        public NotificadorMail(string pMailRemitente, int pPassword, int pPuerto, bool pEneableSSL)
        {
            mailRemitente = pMailRemitente;
            password = pPassword;
            puerto = pPuerto;
            eneableSSL = pEneableSSL;
        }

       public string MailRemitente
       {
           get{ return this.mailRemitente;}
            
       }
       public string Password 
       {
           get{ return this.password;}
       }
       public bool EneableSSL
       {    get{ return this.eneableSSL;}

       }
       public void Enviar(string pMailDestino, string pSubject,string pTexto)
       {
           
       }
    }
}