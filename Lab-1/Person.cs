using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Person
    {
        // Data Members
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        //Contstrutor
        public Person(int id, string fname, string lname, string favouriteColor, int age, bool isWorking)
        {
            this.personId = id;
            this.firstName = fname;
            this.lastName = lname;
            this.favoriteColour = favouriteColor; 
            this.age = age;
            this.isWorking = isWorking;
        }

        //Changes favourite colour
        public void ChangeFavoriteColour(string favouriteColour)
        {
            this.favoriteColour = favouriteColour;
        }

        //Gets age in ten years
        public int GetAgeInTenYears()
        {
            return age + 10; 
        }
        //Returns person info
        public void DisplayPersonInfo()
        {
            Console.WriteLine(personId + ": " + firstName + " " + lastName + "'s favourite colour is: " + favoriteColour);
        }

        //To String Method - displays all Person Object information as a list
        public override string ToString()
        {
            return $"PersonID: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavouriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}";
        }
    }
}
