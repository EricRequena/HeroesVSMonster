namespace ClassLibraryHeroesVsMonster
{
    public class Metodos
    {
        public static bool RangSelectors(int num, int lessValue, int MaxValue, int count) /*Introduccir decisiones*/
        {
            return num >= lessValue && num <= MaxValue; /*Devolver valores*/
        }

        public static void PulsaEspacioParaContinuar()
        {
            Console.WriteLine("Pulsa la tecla ESPACIO para continuar...");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar)
            {
                Console.WriteLine("\nTecla incorrecta. Pulsa la tecla ESPACIO para continuar...");
            }
            Console.Clear(); // O cualquier otra acción que desees después de presionar espacio
        }

        public static string[] GetHeroNamesInput() /*Introducir nombres de heroes*/
        {
            const int expectedHeroCount = 4; /*Numero de heroes*/
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Introduce los nombres de los 4 héroes separados por un espacio:"); /*Mensaje de introducir nombres*/
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine(); /*Introducir nombres*/
            string[] heroNames = input.Split(' '); /*Separar nombres*/

            while (heroNames.Length != expectedHeroCount) /*Si no se introducen 4 nombres*/
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Debes introducir exactamente {expectedHeroCount} nombres. Vuelve a intentarlo:");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();
                heroNames = input.Split(' ');
            }

            return heroNames; /*Devolver nombres*/
        }
        public static int GetUserInputWithValidation(string prompt, int minValue, int maxValue) /*Introducir valores personalizados*/
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int userInput; /*Introducir valores*/
            int attempts = 0; /*Contador de intentos*/
            int MAX_ATTEMPTS = 3; /*Numero maximo de intentos*/
            do
            {
                Console.WriteLine(prompt); /*Mensaje de introducir valores*/
                Console.ForegroundColor = ConsoleColor.White;
                if (int.TryParse(Console.ReadLine(), out userInput) && RangSelectors(userInput, minValue, maxValue, MAX_ATTEMPTS)) /*Funcion que muestra si esta dentro del rango*/
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    return userInput; /*Devolver valores*/
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Entrada no válida. Debe ser un número entre {minValue} y {maxValue}.");
                attempts++;
            } while (attempts < MAX_ATTEMPTS); /*Si se exceden los intentos*/
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Se excedieron los intentos. Estableciendo el valor predeterminado: {minValue}");
            Console.ForegroundColor = ConsoleColor.Green;
            return minValue; /*Devolver valores*/
        }
    }
}