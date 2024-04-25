using System;

class calcladora
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=== Calculadora Básica ===");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                Console.Write("Seleccione una opción válida: ");
            }

            if (opcion == 5)
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }

            Console.Write("Ingrese el primer número: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Número inválido. Intente nuevamente.");
                Console.Write("Ingrese el primer número: ");
            }

            Console.Write("Ingrese el segundo número: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Número inválido. Intente nuevamente.");
                Console.Write("Ingrese el segundo número: ");
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Resultado de la suma: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado de la resta: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado de la multiplicación: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"Resultado de la división: {num1 / num2}");
                    else
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    break;
            }
        }
    }
}
