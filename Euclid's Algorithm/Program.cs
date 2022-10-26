namespace Euclid
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Pick num1");
            string num1S = Console.ReadLine();
            Console.WriteLine("Pick num2");
            string num2S = Console.ReadLine();

            float num1 = float.Parse(num1S);
            float num2 = float.Parse(num2S);

            while (num1 != num2)
            {
                if(num1 > num2)
                {
                    num1 = num1 - num2;
                    Console.WriteLine(num1);
                }
                else
                {
                    num2 = num2 - num1;
                    Console.WriteLine(num2);
                }
            }

            Console.WriteLine("The GCD of your numbers is: " + num1);
        }
    }
}