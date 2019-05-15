using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace NipponBar.DB
{
    public class Role
    {
        
        public int Id { get; set; }
        public string RoleName { get; set; }

        public List<User> Users { get; set; }
    }
}
