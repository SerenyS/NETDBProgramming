using System;

namespace YourName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // display a literal value
            Console.WriteLine("What is your name?");
            // input a value and assign it to a string variable
            string name = Console.ReadLine();
            // display the string variable
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Hello, {0}", name);


            Phone phone = new Phone();

            phone.Number = 9204715179;




        }


        public class Phone
        {
            public long Number { get; set; }

            public string Color { get; set; }

            public string Manufacturer { get; set; }

            //ctor tab tab

            public Phone()// constructor no return type
            {

            }

            public Phone (int number, string manu, string color) // passing and setting values
            {
                Number = number;
                Manufacturer = manu;
                Color = color;
            }

            //methods (functionality)

            public void ReadFile() { }

            public void WriteFile() { }

            public void CheckInput() { }


            //Properties = What a properties Needs to have to be a ticket
            //methods = functionality or "actions" needed such as verify information
            // interface = what the user gets to use and see and interact with
            //extends = ':'
            //override  = changes to make it default behavior
            //base = base class - object is a class

        }
    }

}
