namespace guessNumber;

public class Generator
{
    public int generated_number { get; set; }

    public void generate_number()
    {
        Random rand = new Random();
        generated_number = rand.Next(11); // 0 ile 10 arası bir sayı

    }

}
