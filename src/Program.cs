using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int playerCoins = 6000;
        
        int shirtPrice = 2500;
        int helmetPrice = 3000;
        int foodPrice = 500;
        int presentPrice = 1000;

        Console.WriteLine($"Your current balance is {playerCoins}");
        Console.WriteLine("");

        Console.WriteLine("What would you like to purchase?");

        Console.WriteLine("A: A nice shirt.");
        Console.WriteLine("B: A protective helmet.");
        Console.WriteLine("C: Some food.");
        Console.WriteLine("D: A present.");

        Console.WriteLine("");

        Console.WriteLine("Enter the letter for your choice of purchase: ");
        string purchaseLetter = Console.ReadLine();

        Console.WriteLine("");

        while (playerCoins > 0) {
        switch (purchaseLetter) {
            case "A":
                playerCoins = playerCoins - shirtPrice;
                Console.WriteLine($"You have chosen A nice shirt and you have now {playerCoins} coins remaining.");
                break;
            case "B":
                playerCoins = playerCoins - helmetPrice;
                Console.WriteLine($"You have chosen A protective helmet and you have now {playerCoins} coins remaining.");
                break;
            case "C":
                playerCoins = playerCoins - foodPrice;
                Console.WriteLine($"You have chosen A Some food and you have now {playerCoins} coins remaining.");
                break;
            case "D":
                playerCoins = playerCoins - presentPrice;
                Console.WriteLine($"You have chosen A present and you have now {playerCoins} coins remaining.");
                break;
            default: 
                Console.WriteLine($"Letter {purchaseLetter} you emtered is invalid, please try again.");
                break;
        }
        }
        
    }
}

