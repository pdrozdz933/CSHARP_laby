using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public class Person
        {
            public string FirstN { get; protected set; }
            public string FamilyN { get; protected set; }
            public int Age { get; protected set; }
            public Person(string firstName, string familyName, int age)
            {
                firstName = firstName.Replace(" ", "");
                familyName = familyName.Replace(" ", "");
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(familyName) || !CheckLetters(firstName) || !CheckLetters(familyName))
                {
                    throw new ArgumentException("Wrong name!");
                }
                if (age < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();
                familyName = familyName.Substring(0, 1).ToUpper() + familyName.Substring(1).ToLower();
                FirstN = firstName;
                FamilyN = familyName;
                Age = age;
            }
            public void modifyFirstName(string firstName)
            {
                firstName = firstName.Replace(" ", "");
                if (string.IsNullOrEmpty(firstName) || !CheckLetters(firstName))
                {
                    throw new ArgumentException("Wrong name!");
                }
                FirstN = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();
            }
            public void modifyFamilyName(string familyName)
            {
                familyName = familyName.Replace(" ", "");
                if (string.IsNullOrEmpty(familyName) || !CheckLetters(familyName))
                {
                    throw new ArgumentException("Wrong name!");
                }
                FamilyN = familyName.Substring(0, 1).ToUpper() + familyName.Substring(1).ToLower();
            }
            public virtual void modifyAge(int age)
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                Age = age;
            }
            public override string ToString()
            {
                return $"{FirstN} {FamilyN} ({Age})";
            }
            protected bool CheckLetters(string s)
            {
                foreach (char c in s)
                {
                    if (!Char.IsLetter(c))
                        return false;
                }
                return true;
            }
        }

        public class Child : Person
        {
            private readonly Person Mother;
            private readonly Person Father;

            public Child(string firstName, string familyName, int age, Person mother = null, Person father = null) : base(firstName, familyName, age)
            {
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(familyName) || !CheckLetters(firstName) || !CheckLetters(familyName))
                {
                    throw new ArgumentException("Wrong name!");
                }

                if (age < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                if (age > 15)
                {
                    throw new ArgumentException("Child’s age must be less than 15!");
                }

                firstName = firstName.Substring(0, 1).ToUpper() + firstName.Substring(1).ToLower();
                familyName = familyName.Substring(0, 1).ToUpper() + familyName.Substring(1).ToLower();

                FirstN = firstName;
                FamilyN = familyName;
                Age = age;

                Mother = mother;
                Father = father;
            }


            public override void modifyAge(int age)
            {
                if (age < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                if (age > 15)
                {
                    throw new ArgumentException("Child’s age must be less than 15!");
                }
                Age = age;
            }

            public override string ToString()
            {
                string childS = $"{FirstN} {FamilyN} ({ Age})";
                string motherS;
                string fatherS;

                if (Mother != null)
                {
                    motherS = $"mother: {Mother.FirstN} {Mother.FamilyN} ({Mother.Age})";
                }
                else
                {
                    motherS = "mother: No data";
                }

                if (Father != null)
                {
                    fatherS = $"father: {Father.FirstN} {Father.FamilyN} ({Father.Age})";
                }
                else
                {
                    fatherS = "father: No data";
                }

                return $"{childS}\n{motherS}\n{fatherS}";
            }
        }
    }
}
