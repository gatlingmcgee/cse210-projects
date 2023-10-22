using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction funct1 = new Fraction(1);
        Console.WriteLine(funct1.GetFraction());
        Console.WriteLine(funct1.GetDecimal());

        Fraction funct2 = new Fraction(5);
        Console.WriteLine(funct2.GetFraction());
        Console.WriteLine(funct2.GetDecimal());

        Fraction funct3 = new Fraction(3, 4);
        Console.WriteLine(funct3.GetFraction());
        Console.WriteLine(funct3.GetDecimal());

        Fraction funct4 = new Fraction(1, 3);
        Console.WriteLine(funct4.GetFraction());
        Console.WriteLine(funct4.GetDecimal());
    }
}