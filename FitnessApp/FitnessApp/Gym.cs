using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace FitnessApp
{
    //What is it: the room itself, where all the users and trainers are located
    //Add/remove members

    //Statistics(e.g.how many coaches there are)
    public class Person
    {
        public string Name { get; set; }
        public bool IsCoach { get; set; }

        public Person(string name, bool isCoach)
        {
            Name = name;
            IsCoach = isCoach;
        }
    }

    public class Gym
    {
        private List<Person> people;

        public Gym()
        {
            people = new List<Person>();
        }

        public void AddMember(Person person)
        {
            people.Add(person);
        }

        public bool RemoveMember(string name)
        {
            var person = people.FirstOrDefault(p => p.Name == name);
            if (person != null)
            {
                people.Remove(person);
                return true;
            }
            return false;
        }

        public int CountCoaches()
        {
            return people.Count(p => p.IsCoach);
        }

        public int CountMembers()
        {
            return people.Count(p => !p.IsCoach);
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"Total people in gym: {people.Count}");
            Console.WriteLine($"Coaches: {CountCoaches()}");
            Console.WriteLine($"Members: {CountMembers()}");
        }
    }
}
