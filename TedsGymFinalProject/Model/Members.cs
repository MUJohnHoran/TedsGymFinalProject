using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedsGymFinalProject.Model
{
    public class Members
    {
        public List<Member> members { get; set; }

        public Members()
        {
            members = new List<Member>();
        }
        public Member Authenticate(string username, string password)
        {
            var a = Members.Where(c => (c.Username == username) && (c.Password == password)
        } 
    }
}
