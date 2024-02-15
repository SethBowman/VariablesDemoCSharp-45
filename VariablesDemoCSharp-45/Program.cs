namespace VariablesDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            //Number types
            //Declaring a variable (creation)
            //Camel Case - everyNextWordStartingWithCaptital
            int wholeNumber;

            //Initialize a variable (giving it a value)
            wholeNumber = 5;

            //Or do both
            //Declaring and initalizing a variable
            int otherNumber = 5;

            double avg;
            avg = 98.7;

            decimal myWallet = 500.00m;

            //Word types
            string myName = "Seth Bowman";

            char key = '1';

            //Fact type
            bool isCoding = false;


            Console.WriteLine($"Hello my name is {myName}. The whole number {wholeNumber}. My wallet has {myWallet} in it.");

            
        }
    }
}
