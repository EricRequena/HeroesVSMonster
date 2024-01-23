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
    }
}