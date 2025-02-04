namespace Valyuta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meblegi daxil edin:");
        Label1:
            bool is_budget = double.TryParse(Console.ReadLine(), out double budget);
            if (is_budget == false)
            {
                Console.WriteLine("Xais olunur duzgun mebleg daxil edin!");
                goto Label1;
            }
            Console.WriteLine("Hansi valyutaya cevirmek isteyirsiniz?");
            Console.WriteLine("1.USD");
            Console.WriteLine("2.EUR");
            Console.WriteLine("3.TRY");
        Label2:
            bool is_integer = int.TryParse(Console.ReadLine(), out int choice);
            if (is_integer == false || (choice != 1 && choice != 2 && choice != 3))
            {
                Console.WriteLine("Menyudan secim edin!");
                goto Label2;
            }
            double budget_to_usd = budget / 1.7;
            double budget_to_eur = budget / 2;
            double budget_to_try = budget / 20;
            //string result = (choice == 1) ? $"Mebleg: {budget_to_usd} USD"; goto Label3:
            //Label3: daha sonra arasdirdim gordumki 2 emeliyyat varsa ternary ile yazmag olmaz
            if (choice == 1) {
                Console.WriteLine($"Mebleg {budget_to_usd} USD");
                return;
            }
            if (choice == 2)
            {
                Console.WriteLine($"Mebleg {budget_to_eur} EUR");
                return;
            }
            if (choice == 3)
            {
                Console.WriteLine($"Mebleg {budget_to_try} TRY");
                return;
            }
        }
    }
}
