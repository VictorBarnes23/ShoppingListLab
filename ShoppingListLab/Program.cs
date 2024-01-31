using System;

bool runProgram = true;
while (runProgram)
{
    Dictionary<string, decimal> groceries = new Dictionary<string, decimal>();
    groceries.Add("apple", 0.99m);
    groceries.Add("banana", 0.59m);
    groceries.Add("cauliflower", 1.59m);
    groceries.Add("DragonFruit", 2.19m);
    groceries.Add("ElderBerry", 1.79m);
    groceries.Add("figa", 2.09m);
    groceries.Add("grapefruit", 1.99m);
    groceries.Add("honeydew", 3.49m);

    List<string> items = new List<string>();
    while (true)
    {
        //displaying the menu
        foreach (KeyValuePair<string, decimal> kvp in groceries)
        {
            Console.WriteLine($"{kvp.Key} ${kvp.Value}");          
        }
        Console.WriteLine($"Please enter an item name?");
        string item = Console.ReadLine().ToLower().Trim();
        if (groceries.ContainsKey(item))
        {
            items.Add(item);    
        }
        else
        {
            Console.WriteLine("This is an invalid item. Please try again");
        }



        foreach (string i in items)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Would you like to add another? Yes/No");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice != "yes" )
        {
            runProgram = false;
            break;
        }
        else
        {
            runProgram = true;
        }
        

    }
}
//receipt logic












static void Clear()
{
    Console.WriteLine("Press any key...");
    Console.ReadKey();
    Console.Clear();
}