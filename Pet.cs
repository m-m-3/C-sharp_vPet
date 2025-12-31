
public class Pet
{
    public string Name { get; set; } = "";
    public Status Status { get; set; } = new Status();

    internal void Feed(Food chosenFood)
    {
        Status.Hunger -= chosenFood.ReducesHungerBy;
        Status.Energy += chosenFood.AddsEnergy;

        LimitStatus();
    }

    internal void Play(Toy chosenToy)
    {
        Status.Happiness += chosenToy.AddsHappiness;
        Status.Energy -= chosenToy.CostsEnergy;

        LimitStatus();
    }

    internal void SpendTime(int choice)
    {
        switch (choice)
        {
            case 1: // krótka przerwa
                Status.Hunger += 5; Status.Happiness -= 5; Status.Energy += 5;
                break;

            case 2: // drzemka
                Status.Hunger += 10; Status.Happiness -= 5; Status.Energy += 15;
                break;

            case 3: // spanie
                Status.Hunger += 15; Status.Happiness -= 10; Status.Energy += 25;
                break;

            case 4: // spacer
                Status.Hunger += 10; Status.Happiness += 15; Status.Energy -= 10;
                break;

            default:
                return;
        }
        LimitStatus();
    }

    void LimitStatus()
    {
        if (Status.Hunger < 0) Status.Hunger = 0;
        if (Status.Hunger > 100) Status.Hunger = 100;

        if (Status.Happiness < 0) Status.Happiness = 0;
        if (Status.Happiness > 100) Status.Happiness = 100;

        if (Status.Energy < 0) Status.Energy = 0;
        if (Status.Energy > 100) Status.Energy = 100;
    }

    internal bool IsGameOver()
    {
        return Status.Hunger >= 100 || Status.Happiness <= 0 || Status.Energy <= 0;
    }
}