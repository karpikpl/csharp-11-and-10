using System.Numerics;

public class Total<T> : IIncrementOperators<Total<T>>
    where T: INumber<T>
{
    public T Value { get; private set; } = T.Zero;

    public static Total<T> operator ++(Total<T> value)
    {
        return new Total<T> { Value = value.Value + T.One };
    }
}