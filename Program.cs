class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("===== WIRTUALNE ZWIERZĄTKO =====");
        Console.Write("Podaj imię zwierzątka: ");
        string petName = Console.ReadLine() ?? "";

        Pet pet = new Pet
        {
            Name = petName
        };

        List<Food> foods = new List<Food>
        {
            new Food { Name = "Karma sucha", ReducesHungerBy = 15, AddsEnergy = 10 },
            new Food { Name = "Karma mokra", ReducesHungerBy = 30, AddsEnergy = 20 }
        };

        List<Toy> toys = new List<Toy>
        {
            new Toy { Name = "Piłka", AddsHappiness = 20, CostsEnergy = 10 },
            new Toy { Name = "Gryzak", AddsHappiness = 10, CostsEnergy = 5 }
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"===== {pet.Name} =====");
            Console.WriteLine("1. Statystyki");
            Console.WriteLine("2. Nakarm");
            Console.WriteLine("3. Pobaw się");
            Console.WriteLine("4. Spędź czas");
            Console.WriteLine("0. Wyjście");
            Console.Write("Wybierz opcję: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(pet.Status);
                    Pause();
                    break;

                case "2":
                    Console.WriteLine("Do zrobienia: Karmienie");
                    Pause();
                    break;

                case "3":
                    Console.WriteLine("Do zrobienia: Zabawa");
                    Pause();
                    break;

                case "4":
                    Console.WriteLine("Do zrobienia: Upływ czasu");
                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    Pause();
                    break;
            }
        }
    }    
    static void Pause()
    {
        Console.WriteLine("Wciśnij Enter, aby wrócić do menu...");
        Console.ReadLine();
    }
}