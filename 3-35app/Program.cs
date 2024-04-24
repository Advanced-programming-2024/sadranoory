class Program
{
    static void Main()
    {
        int z = 1;
        for(int i = 8 ; i>= 1 ; i--){
        for (int j = i; j >= 1; j--)
        {
            Console.Write(z + " ");
        }
        z++;
        Console.WriteLine("");
        }

    }
}