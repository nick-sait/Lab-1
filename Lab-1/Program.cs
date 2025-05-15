using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person obj2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person obj3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person obj4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);


            obj2.DisplayPersonInfo();

            Console.WriteLine(obj3.ToString());
            

            obj1.ChangeFavoriteColour("White");
            obj1.DisplayPersonInfo();

            int ageInTenYears = obj4.GetAgeInTenYears();
            Console.WriteLine($"{ obj4.firstName} {obj4.lastName}' age in 10 years is: {ageInTenYears}");

            // Relation class object
            Relation rel_obj1 = new Relation();
            Relation rel_obj2 = new Relation();

            rel_obj1.ShowRelationship(obj2, obj4);
            Console.WriteLine($"Relationship between {obj2.firstName} and {obj4.firstName} is: {rel_obj1.RelationshipType}");

            rel_obj2.ShowRelationship(obj1, obj3);
            Console.WriteLine($"Relationship between {obj1.firstName} and {obj3.firstName} is: {rel_obj2.RelationshipType}");

            // List of person in class object
            List<Person> listperson = new List<Person>() { obj1, obj2, obj3, obj4 };

            //Showing average age of person in the list
            double averageAge(List<Person> Persons)
            {
                double total = 0;
                foreach (Person person in Persons)
                {
                    total = total + Convert.ToDouble(person.age);
                }
                return total / Persons.Count;
            }

            Console.WriteLine("Average age is : " + averageAge(listperson));

            // Finding youngest person in list 
            string youngestPerson(List<Person> persons)
            {
                string youngest = string.Empty;
                int age = 100000;

                foreach (Person person in persons)
                {
                    if (person.age < age){
                        age = person.age;
                        youngest = person.firstName;
                    }
                }

                return youngest;
            }

            Console.WriteLine("The youngest person is: " + youngestPerson(listperson));

            // Finding youngest person in list 
            string oldestPerson(List<Person> persons)
            {
                string oldest = string.Empty;
                int age = 0;

                foreach (Person person in persons)
                {
                    if (person.age > age)
                    {
                        age = person.age;
                        oldest = person.firstName;
                    }
                }

                return oldest;
            }

            Console.WriteLine("The oldest person is: " + oldestPerson(listperson));


            Console.WriteLine(obj3.ToString());
            Console.WriteLine(obj4.ToString());
            Console.WriteLine(obj3.ToString());



            Console.ReadLine();
        }
    }
}
