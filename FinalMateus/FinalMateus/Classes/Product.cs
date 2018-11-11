using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMateus.Classes
{
    public class Product
    {
        private int id;
        private string name;
        private float price;
        private Category category;
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

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public Category Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
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

        public Product()
        {

        }

        public Product(string name, float price, Category category, bool active)
        {
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.Active = active;
        }

        public Product(int id, string name, float price, Category category, bool active)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.Active = active;
        }

        //public int Id { get => id; set => id = value; }
        //public string Name { get => name; set => name = value; }
        //public float Price { get => price; set => price = value; }
        //public Category Category { get => category; set => category = value; }
        //public bool Active { get => active; set => active = value; }
    }
}
