using System;
class Test
{
    public static void Main(string[] args)
    {
        //Type Casting
        double salary = 2547.89;
        Console.WriteLine(salary);
        int salary2 = (int)salary;
        Console.WriteLine(salary2);

        Console.WriteLine(Convert.ToString(salary));


        //Implicit / Auto converion
        //char -> int -> long -> float -> double

        // Explicit / manual conversion (have to tell compiler to convert)
        //double -> float -> long -> int -> char
    }
}