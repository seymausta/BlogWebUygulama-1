using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Models
{
    public class User
    {
        public User()
        {
            Posties = new List<Post>();
        }
       
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<Post> Posties { get; set; }
    }
}
