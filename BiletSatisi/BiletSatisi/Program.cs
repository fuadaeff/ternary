using System.Reflection.Emit;

namespace BiletSatisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salam,bilet qiymetini daxil edin:");
        Label1:
            bool is_integer_price = int.TryParse(Console.ReadLine(), out int price);
            if (is_integer_price == false)
            {
                Console.WriteLine("Duzgun qiymet daxil edin!");
                goto Label1;
            }
            //string result = (!is_integer_price) ? "Duzgun qiymet daxil edin!"; goto Label1: "";
            Console.WriteLine("Yasinizi daxil edin:");
            Label2:
            bool is_integer_age = int.TryParse(Console.ReadLine(), out int age);
            if (is_integer_age == false) {
                Console.WriteLine("Yasinizi duzgun daxil edin!");
                goto Label2;
            }
            Console.WriteLine("Mektebli ve ya telebesiniz?(he/yox)");
            string answer = Console.ReadLine().ToLower();
            double new_price = price * 0.6;
            string result = (age > 65 || (answer == "he" && age < 24)) ? $"Siz bileti {new_price} manata ala bilersiniz." : 
                $"Siz bileti {price} manata ala bilersiniz.";
            Console.WriteLine(result);
                
        }
    }
}
