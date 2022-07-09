using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesDAT
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        public string RoleName { get; set; }
        public virtual ICollection<User> Users { get; set; }

        public Role(int roleId, string roleName, ICollection<User> users)
        {
            RoleId = roleId;
            RoleName = roleName;
            Users = users;
        }
    }

}
