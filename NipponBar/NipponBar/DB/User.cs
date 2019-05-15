using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NipponBar.DB
{
    public class User
    {
        
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

       public int RoleId { get; set; }
       [ForeignKey("RoleId")]
       public Role Role { get; set; }
    }
}
