using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class User : Entity
    {
        public User(Guid newID) : base(newID)
        {
            EmailAddress = "";
        }
        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
