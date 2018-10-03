using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class Cert
    {
        public int Id { get; set; }//not used
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CertName { get; set; }
        public string ExpDate { get; set; }
        public string Email { get; set; }//not used yet
      
    }
}