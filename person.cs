using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab1
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName;set => firstName = value; }
        public string LastName { get => lastName;set => lastName = value; }
        public int Age { get => age; set => age = value;}
        public string FavoriteColor { get => favoriteColor; set => favoriteColor = value;}
        public bool IsWorking { get => isWorking; set => isWorking = value; }

        public Person(int id, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            Age = age;
            FavoriteColor = favoriteColor;
            IsWorking = isWorking;
            
        }
        public  override string ToString()
        {
            string formatted = "";

            formatted += " PersonID:" + id + "\n" ;
            formatted += " First name:" + firstName + "\n";
            formatted += " Last name:" + lastName + "\n";
            formatted += " favorite color :" + favoriteColor + "\n";
            formatted += " Age :" + age + "\n";
            formatted += " IsWorking :" + isWorking;

            return formatted;
        }
        public string DisplayPersonInfo()
        {
            string formatted = "";

            formatted += id + ":" + firstName + " "+  lastName + "'s" + "favorite color is" + " " + favoriteColor;
           

            return formatted;
        }
        public string ChangeFavoriteColour()
        {
            string formatted = "";

            favoriteColor = "White";

            formatted += DisplayPersonInfo();


            return formatted;

        }
        public string GetAgeInTenYears()
        {
            string formatted = "";

            age = age + 10;

            formatted += firstName + lastName + "'s" + "Age in 10 years is:" + age;

            age = age - 10;
            return formatted;
        }

    }
}
