namespace IFSatser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            //Console.Write("Write a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num > 10)
            //{
            //    Console.WriteLine($"The number {num} is larger than 10.");
            //}
            //else
            //{
            //    Console.WriteLine($"The number {num} is less than 10.");
            //}

            // 2.
            //Console.WriteLine("How many milk cartons are left?");
            //int milkCarton = Convert.ToInt32(Console.ReadLine());

            //if (milkCarton < 10)
            //{
            //    Console.WriteLine("Order 30 more milk cartons.");
            //}
            //else if (milkCarton < 20)
            //{
            //    Console.WriteLine("Order 20 more milk cartons.");
            //}
            //else
            //{
            //    Console.WriteLine("You dont need to order more.");
            //}

            // 3.
            //Console.Write("Could you tell me the temperature from the thermometer: ");
            //float temp = Convert.ToSingle(Console.ReadLine());

            //if (temp > 37.8)
            //{
            //    Console.WriteLine("You have a fever.");
            //}
            //else if (temp > 39.5) 
            //{ 
            //    Console.WriteLine("You need to see a doctor.");
            //}
            //else
            //{
            //    Console.WriteLine("You do not have a fever.");
            //}

            // 4.
            //Console.WriteLine("How old are you?");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age < 18)
            //{
            //    Console.WriteLine("You are not of legal age.");
            //}
            //else if (age > 65)
            //{
            //    Console.WriteLine("You are retired.");
            //}
            //else
            //{
            //    Console.WriteLine("You are of legal age but not retired");
            //}

            // 5.
            //Console.Write("Choose one of the following categories are you, Adult, Retired or Student: ");
            //string? category = Console.ReadLine().ToLower();

            //if (category == "adult")
            //{
            //    Console.WriteLine("Your trip will cost 30kr.");
            //}
            //else if (category == "retired" || category == "student")
            //{
            //    Console.WriteLine("Your trip will cost 20kr.");
            //}
            //else
            //{
            //    Console.WriteLine("Your answer didnt match any of the categories.");
            //}

            // 6. 
            //Console.Write("Tell me your birth year: ");
            //int birthYear = Convert.ToInt32(Console.ReadLine());

            //if (birthYear >= 1980 && birthYear < 1990)
            //{
            //    Console.WriteLine("Youre born in the 1980s");
            //}
            //else if (birthYear < 2000 && birthYear >= 1990)
            //{
            //    Console.WriteLine("Youre bron in the 1990s");
            //}
            //else
            //{ 
            //    Console.WriteLine("Youre not bron in the 1980s or 1990s."); 
            //}

            // 7. 
            //Console.WriteLine("Tell me which country do you live in? ");
            //string? country = Console.ReadLine();
            //if (country is not null)
            //{
            //    string answer = country.ToLower();
            //    if (answer == "sweden" || answer == "norway" || answer == "denmark")
            //    {
            //        Console.WriteLine("You live in the Scandinavia.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You do not live in the Scandinavia");
            //    }
            //}

            // 8. 
            //Console.WriteLine("Tell me how much money you have?");
            //decimal money = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine($"You have {money}kr, do you have a discount?");
            //string? discount = Console.ReadLine().ToLower();

            //if (discount == "yes")
            //{
            //    if (money > 15 && money < 25)
            //    {
            //        Console.WriteLine("Du kan köpa en liten hamburgare och en liten pommes.");
            //    }
            //    else if (money > 25 && money <= 50)
            //    {
            //        Console.WriteLine("Du kan köpa en stor hamburgare och en pommes.");
            //    }
            //    else if (money > 60)
            //    {
            //        Console.WriteLine("Du kan köpa en meal med drycka");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tyvärr du har för lite pengar för att handla här.");
            //    }
            //}
            //else
            //{
            //    if (money > 15 && money < 25)
            //    {
            //        Console.WriteLine("Du kan köpa en liten hamburgare.");
            //    }
            //    else if (money > 25 && money >= 50)
            //    {
            //        Console.WriteLine("Du kan köpa en stor hamburgare.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tyvärr du har för lite pengar för att handla här.");
            //    }
            //}

            // 9.
            Console.Write("Enter the amount you have: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            ExchangeToSEK(amount);

        }

        static void ExchangeToSEK(decimal amount)
        {
            int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.Write("Money Exchange: ");
            for (int i = 0; i < denominations.Length; i++)
            {
                int numNotes = (int)(amount / denominations[i]);
                if (numNotes > 0)
                {
                    amount -= numNotes * denominations[i];
                    Console.WriteLine($"{numNotes} x {denominations[i]} Kr");
                }
            }

        }
    }
}
