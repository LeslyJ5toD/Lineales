using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad del artículo: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el precio del artículo: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        double importe = cantidad * precio;

        double itbis = importe * 0.18;

        double descuento = importe * 0.10;

        double totalGeneral = importe - descuento + itbis;

        Console.WriteLine("\nImporte total: " + importe);
        Console.WriteLine("ITBIS (18%): " + itbis);
        Console.WriteLine("Descuento (10%): " + descuento);
        Console.WriteLine("Total general: " + totalGeneral);
    }
}
