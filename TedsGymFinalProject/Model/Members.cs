using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
            var c = members.Where(o => (o.Username == username) && (o.Password == password));

            if (c.Count() > 0)
            {
                return c.First();
            }
            else
            {
                return null;
            }
        }
    }
    }
