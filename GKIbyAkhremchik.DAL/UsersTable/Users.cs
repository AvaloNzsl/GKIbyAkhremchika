﻿using GKIbyAkhremchik.DAL.RolesTable;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.UsersTable
{
    public partial class Users : IdentityUser
    {
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Secondname { get; set; }

        public int ProfileId { get; set; }
        public int RoleId { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual AdminRole AdminRole { get; set; }

        public Users()
        {
            this.gkiParents = new HashSet<gkiParent>();
            this.gkiStudents = new HashSet<gkiStudent>();
            this.gkiTeachers = new HashSet<gkiTeacher>();
            this.gkiWorkers = new HashSet<gkiWorker>();
        }

        public virtual ICollection<gkiParent> gkiParents { get; set; }
        public virtual ICollection<gkiStudent> gkiStudents { get; set; }
        public virtual ICollection<gkiTeacher> gkiTeachers { get; set; }
        public virtual ICollection<gkiWorker> gkiWorkers { get; set; }
    }
}
