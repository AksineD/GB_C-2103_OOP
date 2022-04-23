#region

using RationalNumbers;

#endregion

var frac1 = new Rational(1, 2);
var frac2 = new Rational(2, 6);
var frac3 = new Rational(3, 7);

var norm1 = Rational.GetReducedRational(frac1.Numerator, frac1.Denominator);
var norm2 = Rational.GetReducedRational(frac2.Numerator, frac2.Denominator);
var norm3 = Rational.GetReducedRational(frac3.Numerator, frac3.Denominator);

var sum = frac1 + frac2 + frac3;
var nsum = Rational.GetReducedRational(sum.Numerator, sum.Denominator);

Console.WriteLine($"frac 1 {frac1} norm {norm1}");
Console.WriteLine($"frac 2 {frac2} norm {norm2}");
Console.WriteLine($"frac 3 {frac3} norm {norm3}");

Console.WriteLine($"sum of frac1, frac2, frac3 {sum} norm sum {nsum} {nsum++}");
Console.WriteLine($"{nsum}");