using System;

namespace Dog
{
    public enum Gender
    {
        MALE,FEMALE
    }
    public class Dog
    {
        public string name;
        public string owner;
        public int age;
        public Gender gender;
        public Dog(string name, string owner, int age, Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }
        public Dog()
        {
            this.name = "";
            this.owner = "";
            this.age = 0;
            this.gender = Gender.MALE;
        }

        public void Bark(int numBarks)
        {
            for(int i = 0;i<= numBarks;i++)
            {
                Console.WriteLine("Woof!\n");
            }
        }
        public string getTag()
        {
            string newLine;
            if(this.gender == Gender.MALE)
            {
                if(this.age == 1)
                {
                    newLine = ("If lost, call " + this.owner + ". His name is " + this.name + "and he is " + this.age + " year old.");
                    return(newLine);
                }
                else
                {
                    newLine = ("If lost, call " + this.owner + ". His name is " + this.name + " and he is " + this.age +  " years old.");
                    return(newLine);
                }
            }
            else
            {
                if(this.age == 1)
                {
                    newLine = ("If lost, call " + this.owner + ". Her name is " + this.name + "and she is " + this.age + " year old.");
                    return(newLine);
                }
                else
                {
                    newLine = ("If lost, call " + this.owner + ". Her name is " + this.name + " and she is " + this.age +  " years old.");
                    return(newLine);
                }               
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog alex = new Dog();
            Dog beb = new Dog("beb", "alex", 21, Gender.FEMALE);
            beb.Bark(4);
            Console.WriteLine(beb.getTag());
        }
    }
}
