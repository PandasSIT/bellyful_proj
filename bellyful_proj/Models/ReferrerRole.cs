using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class ReferrerRole
    {
        public ReferrerRole()
        {
            Referrer = new HashSet<Referrer>();
        }

        public byte RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<Referrer> Referrer { get; set; }
    }
}
