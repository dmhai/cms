using System;
using SS.CMS.Data;

namespace SS.CMS.Models
{
    [Serializable]
    [Table("siteserver_Role")]
    public class RoleInfo : Entity
    {
        [TableColumn]
        public string RoleName { get; set; }

        [TableColumn]
        public string CreatorUserName { get; set; }

        [TableColumn]
        public string Description { get; set; }
    }
}
