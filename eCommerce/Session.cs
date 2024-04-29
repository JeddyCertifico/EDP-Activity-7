using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    public class Session
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Session(int id, string username, string email, string address)
        {
            Id = id;
            Username = username;
            Email = email;
            Address = address;
        }
    }
}
