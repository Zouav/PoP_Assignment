using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoP_Assignment_BORDAS_Alexandre
{
    class Student : Person
    {
        string fullName;
        string number;
        int age;
        Address address;
        int[] scores = new int[0];
        double average = 0;
        string fullAddress;


        public Student(string fName, string lName, string number, int age, Address address) : base(fName, lName)
        {
            this.number = number;
            this.age = age;
            this.address = address;

            this.fullName = this.firstName + " " + this.lastName;
            AverageMark();
            AddressToString();
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public double Average
        {
            get { return this.average; }
            set { this.average = value; }
        }

        public void AverageMark()
        {
            double avg = 0;
            if(this.scores.Length > 0) avg = Queryable.Average(this.scores.AsQueryable());

            Console.WriteLine("AVG = " + avg);
            Console.ReadKey();

            this.average = avg;
            Console.WriteLine("Moyenne est " + avg + "; nbr de notes = " + this.scores.Length);
        }

        public string AddressToString()
        {
            string s = Convert.ToString(this.address.Number) + ", " + this.address.Street + ", " + this.address.City + ", " + this.address.Country;
            return s;
        }

        public void AddMark(int mark)
        {
            if(this.scores.Length == 0)
            {
                this.scores = new int[1];
                this.scores[0] = mark;
            }
            else
            {
                this.scores = this.scores.Concat(new int[] { mark }).ToArray();
            }            
            AverageMark();
        }
    }
}
