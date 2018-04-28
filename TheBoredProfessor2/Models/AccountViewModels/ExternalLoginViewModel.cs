using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheBoredProfessor2.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        
        [EmailAddress]
        public string Email { get; set; }
    }
}
