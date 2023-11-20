
// Derived class representing a simple goal
public class SimpleGoal : Goal
{
    private int basePoints;

    public SimpleGoal(string type, string description, int basePoints) : base(type, description, basePoints)
    {
        this.basePoints = basePoints;
    }

    public override int CalculatePoints()
    {
        return completionStatus ? basePoints : 0;
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}:{basePoints}";
    }

    public override void SetValuesFromRepresentation(string representation)
    {
        base.SetValuesFromRepresentation(representation);
        basePoints = int.Parse(representation.Split(":")[3]);
    }
}