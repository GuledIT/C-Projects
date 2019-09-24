

namespace AgeChecker
{    


    class ageGape
    {



        static void Main(string[] args)
        {


             

            Console.WriteLine("Welcome...Insert your age.");
            double yourAge = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now...insert your dates age.");
            double dateAge = Convert.ToDouble(Console.ReadLine());

            double checkAge = (yourAge - dateAge);

            if(checkAge < 1 || dateAge < 18)
            {
                Console.WriteLine("You may need too check up som ID.");

            }
            else
            {
                Console.WriteLine("Good too go mate.");
            }




        }
    }
}
