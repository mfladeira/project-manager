using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMateus.Classes
{
    public class UserProfile
    {
        private int id;
        private string name;
        private bool active;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public bool Active
        {
            get
            {
                return active;
            }

            set
            {
                active = value;
            }
        }

        public UserProfile()
        {

        }
        public UserProfile(string name, bool active)
        {
            this.Name = name;
            this.Active = active;
        }

        public UserProfile(int id, string name, bool active)
        {
            this.Id = id;
            this.Name = name;
            this.Active = active;
        }

        
    }
}
