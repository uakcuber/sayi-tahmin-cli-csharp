namespace guessNumber
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            var guesser = new Guesser();
            int hak = 3;
            bool game_status;
            Console.WriteLine("SAYI TAHMİN OYUNU");
            var number = new Generator();
            number.generate_number();
            int sayi = number.generated_number;

            while (hak > 0)
            {

                int input_number = 0;
                Console.Write("Tahmininizi giriniz-->");
                try
                {
                    input_number = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Write("Bu sefer gerçekten giriniz-->");
                    input_number = Convert.ToInt32(Console.ReadLine());
                }

                game_status = guesser.guess_number(input_number, sayi);

                if (game_status == true) { Console.WriteLine($"DOĞRU SAYI {input_number}"); break; }

                else
                {
                    if (sayi < input_number)
                    {
                        hak--;
                        Console.WriteLine($"SOĞUK! HAK:{hak}");
                    }

                    else
                    {
                        hak--;
                        Console.WriteLine($"SICAK! HAK:{hak}");
                    }
                }
            }

            if (hak == 0) { Console.WriteLine($"bulamadınız... Cevap {sayi} idi."); }
        }
    }
}
