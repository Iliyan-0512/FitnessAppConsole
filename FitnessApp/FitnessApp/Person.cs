using System;

namespace FitnessApp
{
   

    internal abstract class Person
    {
        private string _name;
        private Gender _gender;
        private double _height;
        private double _weight;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3)
                    _name = value;
                else
                    throw new ArgumentException("Name must have at least 3 characters.");
            }
        }

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Height must be positive.");
                _height = value;
            }
        }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Weight must be positive.");
                _weight = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative.");
                _age = value;
            }
        }

        public abstract void ShowInfo();
    }
}
