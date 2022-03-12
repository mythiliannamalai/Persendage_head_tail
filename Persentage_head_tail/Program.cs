class Head_Tail
{
    public double HEAD;
    public double TAIL;
    public int HEAD_COUNT = 0;
    public int TAIL_COUNT = 0;
    public int FLIP_COIN;
    public int FLIP_COUNT;
    public double HEAD_VALUE;
    public double TAIL_VALUE;
    public void coin()
    {
        Console.WriteLine("How many time you want to flip the coin :");
        FLIP_COIN = int.Parse(Console.ReadLine());
        while (FLIP_COIN != FLIP_COUNT && FLIP_COIN != FLIP_COUNT)
        {
            Random rand = new Random();
            var RESULT = rand.NextDouble();
            Console.WriteLine("result : " + RESULT);
            if (RESULT < 0.5)
            {
                Console.WriteLine("Tail.. ");
                TAIL_COUNT++;
                TAIL_VALUE = (TAIL_VALUE + RESULT);
            }
            else
            {
                Console.WriteLine("Head.. ");
                HEAD_COUNT++;
                HEAD_VALUE = (HEAD_VALUE + RESULT);
            }
            FLIP_COUNT++;

        }
        HEAD = ((HEAD_VALUE / HEAD_COUNT) * 100);
        TAIL = ((TAIL_VALUE / TAIL_COUNT) * 100);
        Console.WriteLine("Persentage of head : " + HEAD);
        Console.WriteLine(HEAD_COUNT);
        Console.WriteLine("persentage of tail : " + TAIL);
        Console.WriteLine(TAIL_COUNT);
    }
}
class Display
{
    public static void Main(string[] args)
    {
        Head_Tail HT = new Head_Tail();
        HT.coin();
    }
}
