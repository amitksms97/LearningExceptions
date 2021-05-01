using System;

namespace LearningExceptions
{
    class Person
    {
        private String name;

        public String Name
        {
            get { return name; }
            set 
            { if(value == null)
                throw new NullReferenceException("name must have a value");
                name = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var person = new Person();
                person.Name = null;
                //throw new Exception("custom message");
                //string s = null;
                //var l = s.Length;
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("disconnecting database");
            }
            
        }
    }
}
