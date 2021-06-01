using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestion.Models
{
    public enum Gender
    {
        Male = 'M',
        Female = 'F'
    }

    public interface IPet
    {
        int ID { get; set; }
        string Name { get; set; }
        DateTime DateOfBirth { get; set; }
        Gender Gender { get; set; }

        string Speak();
    }

    public abstract class PetBase : IPet
    {
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract DateTime DateOfBirth { get; set; }
        public abstract Gender Gender { get; set; }
        public abstract string Speak();

        public virtual bool IsNameAPalindrome
        {
            get
            {
                
                char[] charArray = Name.ToCharArray();
                string s = Convert.ToString(Array.Reverse(charArray));
                return  s.Equals( Name) ? true : false;

            }
        } 

        public virtual int Age
        {
            get
            {
                return DateTime.Now.Year – DateOfBirth.Year;
            }
        } 
    }

    public class Bird : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public float Wingspan { get; set; }

        public override string Speak()
        {
            return "Chirp!";
        }
    }

    public class Cat : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public override string Speak()
        {
            return "Meow!";
        }
    }

    public class Dog : PetBase
    {
        public override int ID { get; set; }
        public override string Name { get; set; }
        public override DateTime DateOfBirth { get; set; }
        public override Gender Gender { get; set; }

        public override string Speak()
        {
            return "Whoof!";
        }
    }

   
     
    }
