// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Rational.Math.cs" company="">
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
    /// The get reduced rational.
    /// </summary>
    /// <param name="numerator">
    /// The numerator.
    /// </param>
    /// <param name="denominator">
    /// The denominator.
    /// </param>
    /// <returns>
    /// The <see cref="Rational"/>.
    /// </returns>
    public static Rational GetReducedRational(BigInteger numerator, BigInteger denominator)
    {
        if (numerator.IsZero || denominator.IsZero) return Zero;

        if (denominator.Sign == -1)
        {
            numerator = BigInteger.Negate(numerator);
            denominator = BigInteger.Negate(denominator);
        }

        var gcd = BigInteger.GreatestCommonDivisor(numerator, denominator);
        if (!gcd.IsOne && !gcd.IsZero)
            return new Rational(BigInteger.Divide(numerator, gcd), BigInteger.Divide(denominator, gcd), false);

        return new Rational(numerator, denominator, false);
    }

    /// <summary>
    /// The add.
    /// </summary>
    /// <param name="summand">
    /// The summand.
    /// </param>
    /// <returns>
    /// The <see cref="Rational"/>.
    /// </returns>
    public Rational Add(Rational summand)
    {
        if (this._denominator == summand.Denominator)
            return new Rational(BigInteger.Add(this._numerator, summand.Numerator), this._denominator);

        if (this.IsZero) return summand;

        if (summand.IsZero) return this;

        var gcd = BigInteger.GreatestCommonDivisor(this._denominator, summand.Denominator);

        var thisMultiplier = BigInteger.Divide(this._denominator, gcd);
        var otherMultiplier = BigInteger.Divide(summand.Denominator, gcd);

        var leastCommonMultiple = BigInteger.Multiply(thisMultiplier, summand.Denominator);

        var calculatedNumerator = BigInteger.Add(
            BigInteger.Multiply(this._numerator, otherMultiplier),
            BigInteger.Multiply(summand.Numerator, thisMultiplier));
        return new Rational(calculatedNumerator, leastCommonMultiple, true);
    }

    /// <summary>
    /// The divide.
    /// </summary>
    /// <param name="divisor">
    /// The divisor.
    /// </param>
    /// <returns>
    /// The <see cref="Rational"/>.
    /// </returns>
    /// <exception cref="DivideByZeroException">
    /// </exception>
    public Rational Divide(Rational divisor)
    {
        if (divisor.IsZero) throw new DivideByZeroException();

        return new Rational(this._numerator * divisor._denominator, this._denominator * divisor._numerator);
    }

    /// <summary>
    /// The invert.
    /// </summary>
    /// <returns>
    /// The <see cref="Rational"/>.
    /// </returns>
    public Rational Invert()
    {
        return new Rational(BigInteger.Negate(this._numerator), this._denominator);
    }

    /// <summary>
    /// The multiply.
    /// </summary>
    /// <param name="factor">
    /// The factor.
    /// </param>
    /// <returns>
    /// The <see cref="Rational"/>.
    /// </returns>
    public Rational Multiply(Rational factor)
    {
        return new Rational(this._numerator * factor._numerator, this._denominator * factor._denominator);
    }

    /// <summary>
    /// The reduce.
    /// </summary>
    /// <returns>
    /// The <see cref="Rational"/>.
    /// </returns>
    public Rational Reduce()
    {
        return GetReducedRational(this._numerator, this._denominator);
    }

    /// <summary>
    /// The remainder.
    /// </summary>
    /// <param name="divisor">
    /// The divisor.
    /// </param>
    /// <returns>
    /// The <see cref="Rational"/>.
    /// </returns>
    /// <exception cref="DivideByZeroException">
    /// </exception>
    public Rational Remainder(Rational divisor)
    {
        if (divisor.IsZero) throw new DivideByZeroException();

        if (this.IsZero) return Zero;

        var gcd = BigInteger.GreatestCommonDivisor(this._denominator, divisor.Denominator);

        var thisMultiplier = BigInteger.Divide(this._denominator, gcd);
        var otherMultiplier = BigInteger.Divide(divisor.Denominator, gcd);

        var leastCommonMultiple = BigInteger.Multiply(thisMultiplier, divisor.Denominator);

        var a = BigInteger.Multiply(this._numerator, otherMultiplier);
        var b = BigInteger.Multiply(divisor.Numerator, thisMultiplier);

        var remainder = BigInteger.Remainder(a, b);

        return new Rational(remainder, leastCommonMultiple);
    }

    /// <summary>
    /// The subtract.
    /// </summary>
    /// <param name="subtrahend">
    /// The subtrahend.
    /// </param>
    /// <returns>
    /// The <see cref="Rational"/>.
    /// </returns>
    public Rational Subtract(Rational subtrahend)
    {
        return this.Add(subtrahend.Invert());
    }
}