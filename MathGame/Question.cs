namespace MathGame;

public record Question(int Left, int Right, Operation Operation)
{
    public int Answer => Operation switch
    {
        Operation.Suma => Left + Right,
        Operation.Resta => Left - Right,
        Operation.Division => Left / Right,
        Operation.Multiplicacion => Left * Right,
        _ => throw new ArgumentOutOfRangeException(nameof(Operation))
    };
    
};
