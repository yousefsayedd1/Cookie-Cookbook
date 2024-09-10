public class Chocolate : Ingredient
{
    public override int ID { get; } = 4;
    public override string Name { get; } = "Chocolate";
    public override string InstructionOnPreparing => $"Melt in a water bath. {base.InstructionOnPreparing}";
}


