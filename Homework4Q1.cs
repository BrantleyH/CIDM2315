namespace Homework4;
class Program
{
    static int largest(int a, int b)
    {
        if(a > b)
        {
            return a;
        }

        else if(b > a)
        {
            return b;
        }

        else
        {
            return -1;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Brantley Hudson");
        Console.Writeline("CDIM Homework4Q1");

        int a = 3, b = 5;

        int lar= largest(a, b);

        Console.WriteLine("\nLargest Number is: "+lar);

    }
}
