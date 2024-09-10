public class Cardamom : Ingredient
{
    public override int ID { get; } = 6;
    public override string Name { get; } = "Cardamom";
    public override string InstructionOnPreparing => $"Take half a teaspoon. {base.InstructionOnPreparing}";
}


