using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal abstract class Person
    {
        private string _name;
        private string _gender;
        private string _height;
        private string _weight;
        private int _age;
        public string Height
        {
            get { return _height; }
            set
            {
                if (value.Length < 0)
                {
                    Console.WriteLine("Can not be negotive");
                }

                else
                {
                    _height = value;
                }

            }

        }
        public string Weight
        {
            get { return _weight; }
            set
            {
                if (value.Length < 0)
                {
                    Console.WriteLine("Can not be negotive");
                }

                else
                {
                    _weight = value;
                }
            }

        }
        public string Gender
        {
            //here have three option=male=famale=I prefer not to say
            get { return _gender; }
            set
            {
                if (value.Length >= 3)
                    _gender = value;
                else
                    Console.WriteLine("Name have to have at least  three characther");
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3)
                    _name = value;
                else
                    Console.WriteLine("Name have to have at least  three characther");
            }

        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Can not be negotive");
                }
            }
        }
    }
}
