namespace HW_2
{
    class Program
    {
        static void Main()
        {
            int[] Sits = new int[11];
            //for (int i = 0; i < Sits.Length; i++) { Sits[i] = 1; }
            //for (int i = 0; i < Sits.Length - 6; i++) { Sits[i] = 1; }
            //for (int i = 6; i < Sits.Length; i++) { Sits[i] = 1; }
            int Part;
            int Choose;
            bool Stop = false;
            bool First = true;
            do
            {
                //Console.Clear();
                Console.Write($"\tChoose\nSmoke - 1\nNo smoke - 2\n-> ");
                Part = Convert.ToInt32(Console.ReadLine());
                if (Part == 1)
                {
                    if (CheckExistFirst(Sits) == false) { Console.Write($"Sorry, we have no sits.\nWould you like to choose a sit in No Smoking area?\n(1 - Yes 2 - No)\n -> "); int ch = Convert.ToInt32(Console.ReadLine()); if (ch == 2) { Console.WriteLine($"Next plane is coming in 3 hours."); break; } else if (ch == 1) { continue; } }
                    do
                    {
                        Console.WriteLine($"\t\t\tChoose sit");
                        for (int i = 0; i < Sits.Length - 5; i++) { Console.Write("\t"); if (Sits[i] == 0 && i < 6 && i != 0) { Console.Write($"{i} "); } else if (Sits[i] == 1) { Console.Write($"x "); } }
                        Console.Write($"\n-> ");
                        Choose = Convert.ToInt32(Console.ReadLine());
                        if (Sits[Choose] == 1) { Console.WriteLine($"This sit is already served.\nChoose another one."); }
                        else
                        {
                            Sits[Choose] = 1;
                            PrintTicket(Part, Choose);
                            First = false;
                        }
                    }while (First == true);
                }
                else if (Part == 2) 
                {
                    if (CheckExistSecond(Sits) == false) { Console.Write($"Sorry, we have no sits.\nWould you like to choose a sit in Smoking area?\n(1 - Yes 2 - No)\n -> "); int ch = Convert.ToInt32(Console.ReadLine()); if (ch == 2) { Console.WriteLine($"Next plane is coming in 3 hours."); break; } else if (ch == 1) { continue; } }
                    do
                    {
                        Console.WriteLine($"\t\t\tChoose sit");
                        Console.Write("\t");
                        for (int i = 5; i < Sits.Length; i++) { if (Sits[i] == 0 && i > 5) { Console.Write($"{i} \t"); } else if (Sits[i] == 1) { Console.Write($"x \t"); } }
                        Console.Write($"\n-> ");
                        Choose = Convert.ToInt32(Console.ReadLine());
                        if (Sits[Choose] == 1) { Console.WriteLine($"This sit is already served.\nChoose another one."); }
                        else
                        {
                            Sits[Choose] = 1;
                            PrintTicket(Part, Choose);
                            First = false;
                        }
                    } while (First == true);
                }
                else { }
            } while (Stop == CheckExist(Sits));
        }

        static void PrintTicket(int Part, int Choose)
        {
            Console.WriteLine("Your tiket!!!");
            Console.WriteLine($"/================\\" +
                $"            \n|\t\t |" +
                $"            \n| Part: {Part} Sit: {Choose} |" +
                $"            \n|\t\t |" +
                $"            \n\\================/");
        }

        static bool CheckExistFirst(int[] Sits)
        {
            int n = 0;
            for (int i = 0; i < Sits.Length - 5; i++) { if (Sits[i] == 1) { n++; } }
            if (n < 6 && n != 5) { return true; }
            else if (n == 5) { return false; }
            //Console.WriteLine(n);
            return true;
        }

        static bool CheckExistSecond(int[] Sits)
        {
            int n = 0;
            for (int i = 5; i < Sits.Length; i++) { if (Sits[i] == 1) { n++; } }
            if (n < 6 && n != 5) { return true; }
            else if (n == 5) { return false; }
            //Console.WriteLine(n);
            return true;
        }

        static bool CheckExist(int[] Sits)
        {
            int n = 0;
            for (int i = 0; i < Sits.Length; i++) { if (Sits[i] == 1) { n++; } }
            if (n < 11 && n != 10) { return false; }
            else if (n == 11) { return true; }
            return true;
        }
    }
}
