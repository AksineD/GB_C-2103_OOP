// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rational.Operator.cs" company="">
//   
// </copyright>
// <summary>
//   The rational.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RationalNumbers;

/// <summary>
/// The rational.
/// </summary>
internal partial class Rational
{
    /// <summary>
    /// The +.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static Rational operator +(Rational a, Rational b)
    {
        return a.Add(b);
    }

    /// <summary>
    /// The --.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <returns>
    /// </returns>
    public static Rational operator --(Rational a)
    {
        return a = a.Subtract(One);
    }

    /// <summary>
    /// The /.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static Rational operator /(Rational a, Rational b)
    {
        return a.Divide(b);
    }

    /// <summary>
    /// The ==.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static bool operator ==(Rational a, Rational b)
    {
        return a.Equals(b);
    }

    /// <summary>
    /// The op_ explicit.
    /// </summary>
    /// <param name="Rational">
    /// The rational.
    /// </param>
    /// <returns>
    /// </returns>
    public static explicit operator int(Rational Rational)
    {
        return Rational.ToInt();
    }

    /// <summary>
    /// The op_ explicit.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <returns>
    /// </returns>
    public static explicit operator float(Rational a)
    {
        return a.ToFloat();
    }

    /// <summary>
    /// The &gt;.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static bool operator >(Rational a, Rational b)
    {
        return a.CompareTo(b) > 0;
    }

    /// <summary>
    /// The &gt;=.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static bool operator >=(Rational a, Rational b)
    {
        return a.CompareTo(b) >= 0;
    }

    /// <summary>
    /// The op_ implicit.
    /// </summary>
    /// <param name="value">
    /// The value.
    /// </param>
    /// <returns>
    /// </returns>
    public static implicit operator Rational(int value)
    {
        return new Rational(value);
    }

    /// <summary>
    /// The op_ implicit.
    /// </summary>
    /// <param name="value">
    /// The value.
    /// </param>
    /// <returns>
    /// </returns>
    public static implicit operator Rational(float value)
    {
        return new Rational(value);
    }

    /// <summary>
    /// The ++.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <returns>
    /// </returns>
    public static Rational operator ++(Rational a)
    {
        return a.Add(One);
    }

    /// <summary>
    /// The !=.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static bool operator !=(Rational a, Rational b)
    {
        return !a.Equals(b);
    }

    /// <summary>
    /// The &lt;.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static bool operator <(Rational a, Rational b)
    {
        return a.CompareTo(b) < 0;
    }

    /// <summary>
    /// The &lt;=.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static bool operator <=(Rational a, Rational b)
    {
        return a.CompareTo(b) <= 0;
    }

    /// <summary>
    /// The %.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static Rational operator %(Rational a, Rational b)
    {
        return a.Remainder(b);
    }

    /// <summary>
    /// The *.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static Rational operator *(Rational a, Rational b)
    {
        return a.Multiply(b);
    }

    /// <summary>
    /// The -.
    /// </summary>
    /// <param name="a">
    /// The a.
    /// </param>
    /// <param name="b">
    /// The b.
    /// </param>
    /// <returns>
    /// </returns>
    public static Rational operator -(Rational a, Rational b)
    {
        return a.Subtract(b);
    }
}