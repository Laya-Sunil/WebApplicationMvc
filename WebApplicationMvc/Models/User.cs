using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMvc.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name="Email Id")]
        public string EmailId { get; set; }
        
        public string Gender { get; set; }
        public string Subscription { get; set; }
    }
}