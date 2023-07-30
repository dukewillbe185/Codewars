// DESCRIPTION:
// You are provided with a skeleton of the class 'Fraction', which accepts two arguments (numerator, denominator).

// EXAMPLE:

// Fraction fraction1 = new Fraction(4, 5);
// Your task is to make this class string representable, and addable while keeping the result in the minimum representation possible.

// EXAMPLE:

// Console.Write(fraction1 + new Fraction(1, 8));
// // Outputs: 37/40
// NB: DON'T use the built_in class 'fractions.Fraction'

// Enjoy!
public class Fraction
{
  private long Top { get; set; }
  private long Bottom { get; set; }
    
  public Fraction(long numerator, long denominator)
  {
    Top = numerator;
    Bottom = denominator;
  }
  
  // Equality checking
  public override int GetHashCode() => this.GetHashCode(); // not actually used
  public override bool Equals(object o) => Compare(this, o as Fraction) == 0;
  public static bool operator ==(Fraction f1, Fraction f2) => Compare(f1, f2) == 0;
  public static bool operator !=(Fraction f1, Fraction f2) => Compare(f1, f2) != 0;
  private static long Compare(Fraction f1, Fraction f2) => f1.Top * f2.Bottom - f2.Top * f1.Bottom;
  
  // Your work here!
  public override string ToString()
    {
        return $"{Top}/{Bottom}";
    }
  
  public static Fraction operator +(Fraction a, Fraction b)
    {
        long num = a.Top * b.Bottom + b.Top * a.Bottom;
        long den = a.Bottom * b.Bottom;
        long gcd = GCD(num, den);

        // Simplify the fraction
        num /= gcd;
        den /= gcd;

        return new Fraction(num, den);
    }
  
  private static long GCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
  
}