using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewellaryShoppingMVC.Entity
{
    public enum City
    {
        Salem,
        Namakkal,
        Chennai,
        Trichy        
    }
    public class UserEntity
    {
        public string userID { get; set; }
        public string password { get; set; }
        public string conformPassword { get; set; }
        public string mailId { get; set; }
        public string role { get; set; }
        public string phoneNumber { get; set; }
        public City city { get; set; }
        public UserEntity(string userID, string password, string phoneNumber, string mailId)
        {
            this.userID = userID;
            this.password = password;
            this.mailId = mailId;
            this.phoneNumber = phoneNumber;

        }
    }
}
