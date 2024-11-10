using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el sueldo del empleado: ");
        double sueldoAnterior = Convert.ToDouble(Console.ReadLine());

        double aumento = sueldoAnterior * 0.15;
        double nuevoSueldo = sueldoAnterior + aumento;

        Console.WriteLine("\nSueldo anterior: " + sueldoAnterior);
        Console.WriteLine("Nuevo sueldo: " + nuevoSueldo);
    }
}
