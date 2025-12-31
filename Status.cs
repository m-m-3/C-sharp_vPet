public class Status
{
    public int Hunger { get; set; } = 50;
    public int Happiness { get; set; } = 50;
    public int Energy { get; set; } = 80;

    public override string ToString()
    {
        return $"Głód: {Hunger}/100\nSzczęście: {Happiness}/100\nEnergia: {Energy}/100\n";
    }
}