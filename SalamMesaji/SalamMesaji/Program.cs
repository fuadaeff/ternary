namespace SalamMesaji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saati daxil edin (0-23): ");
            int time = int.Parse(Console.ReadLine());
            string message = (time >= 6 && time < 12) ? "Sabahiniz xeyir!" :
                           (time >= 12 && time < 18) ? "Gunortaniz xeyir!" :
                           (time >= 18 && time <= 23 || time >= 0 && time < 6) ? "Axsaminiz xeyir!" :
                           "Duzgun saat daxil edin!";
            Console.WriteLine(message);
        }
    }
}
