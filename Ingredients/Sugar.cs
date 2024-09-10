public class Sugar : Ingredient
{
    public override int ID { get; } = 5;
    public override string Name { get; } = "Sugar";
    public override string InstructionOnPreparing => base.InstructionOnPreparing;
}


