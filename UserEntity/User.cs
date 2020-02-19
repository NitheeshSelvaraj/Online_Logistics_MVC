using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEntity
{
    public enum Gender
    {
        Male,
        Female
    }
    public enum LorryType
    {
        three_axeles_rigid,
        four_axeles_artic
    }
    public class User
    {
        public string name;
        public string mobileNumber;
        public Gender gender;
        public LorryType lorryType; 
        public string userName;
        public string password;
    }
}
