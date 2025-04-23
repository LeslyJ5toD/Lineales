using System;

/*Este programa en C# calcula el total a pagar por una compra,
solicitando al usuario la cantidad y el precio de un artículo.
Luego calcula el importe, el ITBIS (18%), un descuento (10%)
y muestra el total general.*/


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
