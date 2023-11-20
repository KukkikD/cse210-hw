// Derived class representing an eternal goal
public class EternalGoal : Goal
{
    private int basePoints;

    // Constructor to initialize attributes specific to EternalGoal
    public EternalGoal(string type, string description, int basePoints) : base(type, description, basePoints)
    {
        this.basePoints = basePoints;
    }

    // Method to calculate points for an eternal goal
    public override int CalculatePoints()
    {
        return completionStatus ? basePoints : 0;
    }

    // Method to get a string representation of the eternal goal for serialization
    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}:{basePoints}";
    }

    // Method to set the values of the eternal goal from a string representation during deserialization
    public override void SetValuesFromRepresentation(string representation)
    {
        base.SetValuesFromRepresentation(representation);
        basePoints = int.Parse(representation.Split(":")[3]);
    }
}