using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoP_Assignment_BORDAS_Alexandre
{
    class Address
    {
        int number;
        private string street;
        private string city;
        private string country;

        public Address(int n, string strt, string cty, string cntry)
        {
            this.number = n;
            this.street = strt;
            this.city = cty;
            this.country = cntry;
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        private bool OnlyChar(string s)
        {
            bool check = true;

            foreach (char c in s)
            {
                if (c >= '0' || c <= '9') check = false;
            }
            return check;
        }

        private bool OnlyDigits(string s)
        {
            bool check = true;

            foreach(char c in s)
            {
                if (c < '0' || c > '9') check = false;
            }
            return check;
        }
    }
}
