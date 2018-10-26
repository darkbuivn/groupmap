using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Models.ViewModels
{
    public class ProfileViewModel
    {
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNum { get; set; }

        [DisplayName("Register Date")]
        public DateTime RegisterDate { get; set; }
    }
}
