[System.Serializable]
public class Offset
{
    public enum OffsetType
    {
        Absolute,
        Relative
    }

    public OffsetType Type;
    public float Value;

    public Offset(OffsetType type, float value)
    {
        Type = type;
        Value = value;
    }

    public float CalculateOffset(float canvasSize)
    {
        return Type == OffsetType.Absolute ? Value : canvasSize * Value;
    }
}