using System;

/* Crear un programa que permita calcular 
el sueldo neto de un empleado, 
partiendo del pago por hora y las horas 
trabajadas, aplicar un descuento de AFP 
que es 2.87% y SFS que es el 
3.04%,sumar los descuentos y luego 
debe restarlos del sueldo bruto*/


class Ejercicio2
{
    static void Main()
    {

        Console.Write("Introduce el pago por hora: ");
        double pagoPorHora = Convert.ToDouble(Console.ReadLine());


        Console.Write("Introduce las horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());


        double sueldoBruto = pagoPorHora * horasTrabajadas;

        // porcentajes de descuento 
        double porcentajeAFP = 2.87 / 100; // 2.87%
        double porcentajeSFS = 3.04 / 100; // 3.04%


        double descuentoAFP = sueldoBruto * porcentajeAFP;
        double descuentoSFS = sueldoBruto * porcentajeSFS;


        double totalDescuentos = descuentoAFP + descuentoSFS;


        double sueldoNeto = sueldoBruto - totalDescuentos;

        // Mostrar resultados
        Console.WriteLine("Sueldo Bruto: " + sueldoBruto);
        Console.WriteLine("Descuento AFP: " + descuentoAFP);
        Console.WriteLine("Descuento SFS: " + descuentoSFS);
        Console.WriteLine("Total Descuentos: " + totalDescuentos);
        Console.WriteLine("Sueldo Neto: " + sueldoNeto);
    }
}