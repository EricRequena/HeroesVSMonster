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
    }
}