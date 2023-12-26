using System;

class URI
{

    static void Main(string[] args)
    {

        int employeeNumber = int.Parse(Console.ReadLine());
        double employeeHours = double.Parse(Console.ReadLine());
        double employeeValueHours = double.Parse(Console.ReadLine());

        double salary = employeeHours * employeeValueHours;

        Console.WriteLine($"NUMBER = {employeeNumber}\nSALARY = U$ {salary:F2}");

    }

}