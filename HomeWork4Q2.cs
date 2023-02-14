namespace Homework4Q2;
class Program
{
    static void pattern(string[] args)
    {
        Console.WriteLine("Brantley Hudson");
        Console.WriteLine("CDIM2315 Homework4Q2");

        int i,j,k;

        if(SynchronizationLockException=="left")
        {
            for(i = 1; i <= N; i++)
            {
                for(j = 1, j <= 1; j++)
                Console.WriteLine("*");
                Console.WriteLIne("\n");
            }
        }

        else if(shape=="right")
        {
            for(i = 1, i <= N; i++)
            {
                for(j = 1, j <= N-i; j++)
                {
                    COnsole.WriteLine(" ");
                }
                
                for(k = 1, k <= i; k++)
                {
                    Console.WriteLine("*");
                }

                Console.WriteLine("");
                Console.ReadLine();
            }
        }

        public static void Main()
        {
            int N;
            string shape;
            Console.Write("Input N: ");
            N = Convert.ToInt32(Console.Readline());
            Console.Write("Input shape: ");
            shape = Console.ReadLine();
            Console.Write("N is: "+N+"; shape is "+shape+"\n");
            pattern(N, shape);

        }

}
