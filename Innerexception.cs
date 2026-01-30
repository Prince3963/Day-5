using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_50
{
    public class Innerexception
    {
        public static void Division()
        {
            int a = 10;
            int b = 0;
            int result = a / b;
        }

        public static void Calculate()
        {
            try
            {
                Division();
            }catch(Exception ex){
                throw new Exception("Error in Calculate method", ex);
            }
        }
        public static void checkException()
        {
            try
            {

                Console.Write("Enter your first number : ");
                int number_1 = int.Parse(Console.ReadLine());

                Console.Write("Enter your second number : ");
                int number_2 = int.Parse(Console.ReadLine());

                int result = number_1 / number_2;
                Console.WriteLine("The result is : " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occur: " + ex);
            }
        }
    }
}
