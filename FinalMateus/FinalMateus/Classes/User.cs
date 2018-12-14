﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMateus.Classes
{
    public class User
    {
        private int id;
        private string name;
        private string password;
        
        private string email;
        private UserProfile userProfile;
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

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public UserProfile UserProfile
        {
            get
            {
                return userProfile;
            }

            set
            {
                userProfile = value;
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

      
        public User()
        {

        }

        public User(string name, string password, string email, UserProfile userProfile, bool active)
        {
            this.Name = name;
            this.Password = password;
            
            this.Email = email;
            this.UserProfile = userProfile;
            this.Active = active;
        }

        public User(int id, string name, string password,  string email, UserProfile userProfile, bool active)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
            
            this.Email = email;
            this.UserProfile = userProfile;
            this.Active = active;
        }

      

        
    }
}
