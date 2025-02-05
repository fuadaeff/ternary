using System.Reflection.Emit;

namespace CalculatorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\"Sirincay\" kalkulyatora xos gelmisiniz))");
        LabelLoop:
            Console.WriteLine("Hansi emeliyyati heyata kecirmek isteyirsiniz?");
            Console.WriteLine("1.Toplama(+)");
            Console.WriteLine("2.Cixma(-)");
            Console.WriteLine("3.Vurma(*)");
            Console.WriteLine("4.Bolme(/)");
            Console.WriteLine("5.Kvadratkok(_/)");
            Console.WriteLine("6.Kvadratin tapilmasi");
            Console.WriteLine("7.Kubun tapilmasi");
        Label1:
            bool is_integer = int.TryParse(Console.ReadLine(), out int choice);
            if (!is_integer && (choice!=1 || choice != 2 || choice != 3 || choice != 4 || choice != 5 || choice != 6 || choice != 7) || (choice > 7 || choice <= 0)) {
                Console.WriteLine("Xais olunur menyudan duzgun secim edin!");
                goto Label1;
            }
            #region toplama
            if (choice == 1)
            {
                double sum = 0;
                Console.WriteLine("Toplamaq istediyiniz ededleri daxil edin:");
            Label2:
                bool is_double1 = double.TryParse(Console.ReadLine(), out double result1);
                if (!is_double1)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label2;
                }
            Label3:
                bool is_double2 = double.TryParse(Console.ReadLine(), out double result2);
                if (!is_double2)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label3;
                }
                sum = result1 + result2;
                Console.WriteLine($"Etdiyiniz emeliyyatin neticesi {sum}-dir.");
                Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz?(he/yox)");
            LabelExit1:
                string answer1 = Console.ReadLine().ToLower();
                if (answer1 == "he")
                {
                    goto LabelLoop;
                }
                else if (answer1 == "yox")
                {
                    Console.WriteLine("\"Sirincay\" kalkulyatordan istifade etdiyiniz ucun tesekkurler! <3");
                    return;
                }
                else 
                {
                    Console.WriteLine("Duzgun giris edin!");
                    goto LabelExit1;
                }
            }
            #endregion
            #region cixma
            if (choice == 2)
            {
                double sub = 0;
                Console.WriteLine("Azalan ededi daxil edin:");
            Label4:
                bool is_double3 = double.TryParse(Console.ReadLine(), out double result3);
                if (!is_double3)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label4;
                }
                Console.WriteLine("Cixilan ededi daxil edin:");
            Label5:
                bool is_double4 = double.TryParse(Console.ReadLine(), out double result4);
                if (!is_double4)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label5;
                }
                sub = result3 - result4;
                Console.WriteLine($"Etdiyiniz emeliyyatin neticesi {sub}-dir.");
                Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz?(he/yox)");
                LabelExit2:
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "he")
                {
                    goto LabelLoop;
                }
                else if (answer2 == "yox")
                {
                    Console.WriteLine("\"Sirincay\" kalkulyatordan istifade etdiyiniz ucun tesekkurler! <3");
                    return;
                }
                else 
                {
                    Console.WriteLine("Duzgun giris edin!");
                    goto LabelExit2;
                }
            }
            #endregion
            #region vurma
            if (choice == 3)
            {
                double multiple = 0;
                Console.WriteLine("Vurmaq istediyiniz ededleri daxil edin:");
            Label6:
                bool is_double5 = double.TryParse(Console.ReadLine(), out double result5);
                if (!is_double5)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label6;
                }
            Label7:
                bool is_double6 = double.TryParse(Console.ReadLine(), out double result6);
                if (!is_double6)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label7;
                }
                multiple = result5 * result6;
                Console.WriteLine($"Etdiyiniz emeliyyatin neticesi {multiple}-dir.");
                Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz?(he/yox)");
            LabelExit3:
                string answer3 = Console.ReadLine().ToLower();
                if (answer3 == "he")
                {
                    goto LabelLoop;
                }
                else if (answer3 == "yox")
                {
                    Console.WriteLine("\"Sirincay\" kalkulyatordan istifade etdiyiniz ucun tesekkurler! <3");
                    return;
                }
                else 
                {
                    Console.WriteLine("Duzgun daxil edin!");
                    goto LabelExit3;
                }
            }
            #endregion
            #region bolme
            if (choice == 4)
            {
                double division = 0;
                Console.WriteLine("Boluneni daxil edin:");
            Label8:
                bool is_double7 = double.TryParse(Console.ReadLine(), out double result7);
                if (!is_double7)
                {
                    Console.WriteLine("Duzgun eded daxil edin:");
                    goto Label8;
                }
            Label9:
                bool is_double8 = double.TryParse(Console.ReadLine(), out double result8);
                if (!is_double8)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label9;
                }
                if (result8 == 0)
                {
                    Console.WriteLine("0-a bolme emeliyyati mumkun deyil!");
                    goto Label9;
                }
                division = result7 / result8;
                Console.WriteLine($"Etdiyiniz emeliyyatin neticesi {division}-dir.");
                Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz?(he/yox)");
            LabelExit4:
                string answer4 = Console.ReadLine().ToLower();
                if (answer4 == "he")
                {
                    goto LabelLoop;
                }
                else if (answer4 == "yox")
                {
                    Console.WriteLine("\"Sirincay\" kalkulyatordan istifade etdiyiniz ucun tesekkurler! <3");
                    return;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil edin!");
                    goto LabelExit4;
                }
            }
            #endregion
            #region sqrt
            if (choice == 5)
            {
                double sqrt = 0;
                Console.WriteLine("Kvadrat kokunu tapmaq istediyiniz ededi daxil edin:");
            Label10:
                bool is_double9 = double.TryParse(Console.ReadLine(), out double result9);
                if (!is_double9)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label10;
                }
                if (result9 < 0)
                {
                    Console.WriteLine("Kvadratkok menfi ola bilmez!");
                    goto Label10;
                }
                sqrt = Math.Sqrt(result9);
                Console.WriteLine($"Etdiyiniz emeliyyatin neticesi {sqrt}-dir.");
                Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz?(he/yox)");
            LabelExit5:
                string answer5 = Console.ReadLine().ToLower();
                if (answer5 == "he")
                {
                    goto LabelLoop;
                }
                else if (answer5 == "yox")
                {
                    Console.WriteLine("\"Sirincay\" kalkulyatordan istifade etdiyiniz ucun tesekkurler! <3");
                    return;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil edin!");
                    goto LabelExit5;
                }
            }
            #endregion
            #region kvadrat
            if (choice == 6)
            {
                double kvadrat = 0;
                Console.WriteLine("Kvadratini tapmaq istediyiniz ededi daxil edin:");
            Label11:
                bool is_double10 = double.TryParse(Console.ReadLine(), out double result10);
                if (!is_double10)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label11;
                }
                kvadrat = result10 * result10;
                Console.WriteLine($"Etdiyiniz emeliyyatin neticesi {kvadrat}-dir.");
                Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz?(he/yox)");
            LabelExit6:
                string answer6 = Console.ReadLine().ToLower();
                if (answer6 == "he")
                {
                    goto LabelLoop;
                }
                else if (answer6 == "yox")
                {
                    Console.WriteLine("\"Sirincay\" kalkulyatordan istifade etdiyiniz ucun tesekkurler! <3");
                    return;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil edin!");
                    goto LabelExit6;
                }
            }
            #endregion
            #region kub
            if (choice == 7)
            {
                double kub = 0;
                Console.WriteLine("Kubunu tapmaq istediyiniz ededi daxil edin:");
            Label12:
                bool is_double11 = double.TryParse(Console.ReadLine(), out double result11);
                if (!is_double11)
                {
                    Console.WriteLine("Duzgun eded daxil edin!");
                    goto Label12;
                }
                kub = result11 * result11 * result11;
                Console.WriteLine($"Etdiyiniz emeliyyatin neticesi {kub}-dir");
                Console.WriteLine("Basqa emeliyyat etmek isteyirsiniz?(he/yox)");
            LabelExit7:
                string answer7 = Console.ReadLine().ToLower();
                if (answer7 == "he")
                {
                    goto LabelLoop;
                }
                else if (answer7 == "yox")
                {
                    Console.WriteLine("\"Sirincay\" kalkulyatordan istifade etdiyiniz ucun tesekkurler! <3");
                    return;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil edin!");
                    goto LabelExit7;
                }
            }
            #endregion
        }
    }
}
