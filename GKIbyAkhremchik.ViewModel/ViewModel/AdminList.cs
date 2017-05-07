﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.ViewModel
{
    public class AdminList
    {
        [Display(Name = "UserID")]
        public int UserID { get; set; }//

        [Display(Name = "Login")]
        public string Login { get; set; }//
        [Display(Name = "Password")]
        public string Password { get; set; }//
        [Display(Name = "Name")]
        public string Name { get; set; }//
        [Display(Name = "Surname")]
        public string Surname { get; set; }//
        [Display(Name = "Secondname")]
        public string Secondname { get; set; }//

        [Display(Name = "e-mail")]
        public string Email { get; set; }//
        [Display(Name = "Mobile")]
        public Nullable<decimal> Mobile { get; set; }//

        [Display(Name = "Photo")]
        public string Avatar { get; set; }//
        [Display(Name = "Date Age")]//
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }

        [Display(Name = "Description")]
        public string Thumb { get; set; }
        [Display(Name = "About")]
        public string About { get; set; }
        [Display(Name = "Activity description")]
        public string Activity { get; set; }

        [Display(Name = "My language")]
        public string Language { get; set; }
        [Display(Name = "My city")]
        public string City { get; set; }
        [Display(Name = "My sex")]
        public string Sex { get; set; }

        [Display(Name = "Role")]
        public string Role { get; set; }//
    }
}
