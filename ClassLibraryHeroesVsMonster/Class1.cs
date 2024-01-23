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

        public static int GetRandomValueOrder(int minValue, int maxValue, int[] numeros, int life1, int life2, int life3, int life4) /*Introducir valores aleatorios*/
        {
            bool condition = false; /*Condicion de bucle*/
            Random rnd = new Random();  /*Funcion random*/
            int randomValue;
            do
            {
                randomValue = rnd.Next(minValue, maxValue + 1); /*Introducir valores aleatorios*/

                if (randomValue == 1 && life1 <= 0)
                {
                    randomValue++;
                }
                if (randomValue == 2 && life2 <= 0)
                {
                    randomValue++;
                }
                if (randomValue == 3 && life3 <= 0)
                {
                    randomValue++;
                }
                if (randomValue == 4 && life4 <= 0)
                {
                    randomValue--;
                }
                for (int i = 0; i < numeros.Length; i++) /*Bucle de numeros*/
                {
                    if (numeros[i] == randomValue)
                    {
                        condition = true;
                    }
                }
            } while (!condition);
            return randomValue; /*Devolver valores*/
        }
        public static int DruiSpecialHability(int life) /*Habilidad especial del druida*/
        {
            if (life <= 0) /*Si la vida es menor o igual a 0*/
            {
                return 0; /*Devolver 0*/
            }
            else /*Si la vida es mayor a 0*/
            {
                return life + 500; /*Sumar 500 de vida*/
            }
        }
        public static int monsterLifeReducction(int monsterLife, int monterReduction, int heroTurn, int ArcherAttack, int BarbarianAttack, int MagicianAttack, int DruidAttack)
        {
            int especialAttack = GetRandomValue(1, 101);

            int heroAttack = CalcAtack(heroTurn, ArcherAttack, BarbarianAttack, MagicianAttack, DruidAttack);
            int damage = CalculateDamage(heroAttack, monterReduction);

            if (especialAttack <= 5)
            {
                damage = 0;
            }
            else if (especialAttack <= 15 && especialAttack > 5)
            {
                damage *= 2;
            }

            // Asegurarse de que la vida del monstruo no sea negativa
            int newMonsterLife = Math.Max(0, monsterLife - damage);

            return newMonsterLife;
        }
    }
}