// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rational.cs" company="">
//   
// </copyright>
// <summary>
//   The rational.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RationalNumbers;

#region

using System.Numerics;

#endregion

/// <summary>
/// The rational.
/// </summary>
internal partial class Rational
{
    /// <summary>
    /// The _denominator.
    /// </summary>
    private readonly BigInteger _denominator;

    /// <summary>
    /// The _numerator.
    /// </summary>
    private readonly BigInteger _numerator;

    /// <summary>
    /// Initializes a new instance of the <see cref="Rational"/> class.
    /// </summary>
    /// <param name="numerator">
    /// The numerator.
    /// </param>
    /// <param name="denominator">
    /// The denominator.
    /// </param>
    /// <param name="normalize">
    /// The normalize.
    /// </param>
    public Rational(BigInteger numerator, BigInteger denominator, bool normalize)
    {
        if (normalize)
        {
            var temp = GetReducedRational(numerator, denominator);
            _numerator = temp.Numerator;
            _denominator = temp.Denominator;
            return;
        }
        
        this._numerator = numerator;
        this._denominator = denominator;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Rational"/> class.
    /// </summary>
    /// <param name="numerator">
    /// The numerator.
    /// </param>
    /// <param name="denominator">
    /// The denominator.
    /// </param>
    public Rational(BigInteger numerator, BigInteger denominator)
        : this(numerator, denominator, false)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Rational"/> class.
    /// </summary>
    /// <param name="numerator">
    /// The numerator.
    /// </param>
    public Rational(BigInteger numerator)
    {
        this._numerator = numerator;
        this._denominator = 1;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Rational"/> class.
    /// </summary>
    /// <param name="numerator">
    /// The numerator.
    /// </param>
    public Rational(int numerator)
    {
        this._numerator = new BigInteger(numerator);
        this._denominator = 1;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Rational"/> class.
    /// </summary>
    /// <param name="numerator">
    /// The numerator.
    /// </param>
    public Rational(float numerator)
    {
        this._numerator = new BigInteger(numerator);
        this._denominator = 1;
    }

    /// <summary>
    /// Gets the one.
    /// </summary>
    public static Rational One { get; } = new(BigInteger.One, BigInteger.One);

    /// <summary>
    /// Gets the zero.
    /// </summary>
    public static Rational Zero { get; } = new(BigInteger.Zero, BigInteger.Zero);

    /// <summary>
    /// The denominator.
    /// </summary>
    public BigInteger Denominator => this._denominator;

    /// <summary>
    /// The is positive.
    /// </summary>
    public bool IsPositive =>
        (this._numerator.Sign == 1 && this._denominator.Sign == 1)
        || (this._numerator.Sign == -1 && this._denominator.Sign == -1);

    /// <summary>
    /// The is zero.
    /// </summary>
    public bool IsZero => this._numerator.IsZero; // || _denominator.IsZero;

    /// <summary>
    /// The numerator.
    /// </summary>
    public BigInteger Numerator => this._numerator;

    /// <summary>
    /// The compare to.
    /// </summary>
    /// <param name="other">
    /// The other.
    /// </param>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    public int CompareTo(Rational other)
    {
        if (this._denominator == other._denominator) return this._numerator.CompareTo(other._numerator);

        if (this.IsZero != other.IsZero)
        {
            if (this.IsZero) return other.IsPositive ? -1 : 1;
            return this.IsPositive ? 1 : -1;
        }

        var gcd = BigInteger.GreatestCommonDivisor(this._denominator, other._denominator);

        var thisMultiplier = BigInteger.Divide(this._denominator, gcd);
        var otherMultiplier = BigInteger.Divide(other._denominator, gcd);

        var a = BigInteger.Multiply(this._numerator, otherMultiplier);
        var b = BigInteger.Multiply(other._numerator, thisMultiplier);

        return a.CompareTo(b);
    }

    /// <summary>
    /// The equals.
    /// </summary>
    /// <param name="frac">
    /// The frac.
    /// </param>
    /// <returns>
    /// The <see cref="bool"/>.
    /// </returns>
    public bool Equals(Rational frac)
    {
        return frac._denominator.Equals(this._denominator) && frac._numerator.Equals(this._numerator);
    }

    /// <summary>
    /// The equals.
    /// </summary>
    /// <param name="frac">
    /// The frac.
    /// </param>
    /// <returns>
    /// The <see cref="bool"/>.
    /// </returns>
    public override bool Equals(object? frac)
    {
        if (ReferenceEquals(null, frac)) return false;

        return frac is Rational && this.Equals(frac as Rational);
    }

    /// <summary>
    /// The to float.
    /// </summary>
    /// <returns>
    /// The <see cref="float"/>.
    /// </returns>
    public float ToFloat()
    {
        if (this.IsZero) return 0;
        return (float)this.Numerator / (float)this.Denominator;
    }

    /// <summary>
    /// The to int.
    /// </summary>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    public int ToInt()
    {
        if (this.IsZero) return 0;
        return (int)(this.Numerator / this.Denominator);
    }

    /// <summary>
    /// The to string.
    /// </summary>
    /// <returns>
    /// The <see cref="string"/>.
    /// </returns>
    public override string ToString()
    {
        return $"{this._numerator} / {this._denominator}";
    }
}