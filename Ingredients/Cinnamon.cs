public class Cinnamon : Ingredient
{
    public override int ID { get; } = 7;
    public override string Name { get; } = "Cinnamon";
    public override string InstructionOnPreparing => $"Take half a teaspoon. {base.InstructionOnPreparing}";
}


