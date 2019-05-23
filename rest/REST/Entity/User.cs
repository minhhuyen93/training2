using System.ComponentModel.DataAnnotations.Schema;

namespace REST.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public UserStatus Status { get; set; }
        [NotMapped()]
        public string URI
        {
            get
            {
                return string.Format("http://localhost:60105/api/users/{0}", this.Id);
            }
        }
    }
}