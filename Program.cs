using System;

class Program
{
    static void Main()
    {
        int numero = 10;

        // Bucle do-while para imprimir la secuencia de números de 10 a 0
        do
        {
            Console.WriteLine(numero);
            numero--;
        } while (numero >= 0);

        // Mantiene la consola abierta hasta que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
