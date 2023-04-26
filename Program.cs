namespace workshop_a
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input area:");
            int area = int.Parse(Console.ReadLine());
            int[] numarea = new int[area];

            bool check = true;

            while (check = true)
            {
                Console.WriteLine("input condition1:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("input condition2:");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 <= 0 && num2 <= 0)
                {
                    break;
                }

                if (num1 <= 0 || num2 <= 0)
                {
                    for (int i = 0; i < area; i++)
                    {
                        numarea[num1 - 1] = num1;
                        numarea[num2 - 1] = num2;
                        Console.Write(numarea[i]);


                    }
                    Console.WriteLine("");
                    Console.WriteLine("stall is reserved");
                }
                for (int i = 0; i < area; i++)
                {
                    numarea[num1 - 1] = num1;
                    numarea[num2 - 1] = num2;
                    Console.Write(numarea[i]);


                }
                Console.WriteLine("");
                Console.WriteLine("stall is reserved");




                break;

            }







        }




    }
}


