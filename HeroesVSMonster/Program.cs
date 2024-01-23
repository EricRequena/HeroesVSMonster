using System;
using ClassLibraryHeroesVsMonster;
namespace HeroesVsMonster
{
    public class Program
    {
        const int MAX_ATTEMPTS = 3;
        public static void Main()
        {
            int selector = 0, archerLife = 0, archerAttack = 0, archerReduction = 0, barbarianLife = 0, barbarianAttack = 0, barbarianReduction = 0, magicianLife = 0, magicianAttack = 0, magicianReduction = 0, druidLife = 0, druidAttack = 0, druidReduction = 0, monsterLife = 0, monsterAttack = 0, monsterReduction = 0;

            bool personalization = false;
            bool random = false;
            bool easy = false;
            bool hard = false;
            bool playAgain;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================================");
            Console.WriteLine("      Heroes Vs Monster Game");
            Console.WriteLine("===================================");
            Console.ResetColor();


            Console.WriteLine();
            const string msgStart = "¿Qué deseas hacer?\n\n0. Salir\n1. Jugar!";
            Console.WriteLine();

            const string msgSlectDifficult = "¿Qué dificultad deseas?\n1. Fácil\n2. Difícil\n3. Personalizado\n4. Aleatorio";
            const string msgSlector = "Qué quieres hacer?\n1. Atacar\n2. Defender\n3. Habilidad especial";


            const int minArcherLife = 1500, maxArcherLife = 2000;
            const int minArcherAttack = 200, maxArcherAttack = 300;
            const int minArcherReduction = 25, maxArcherReduction = 35;

            const int minBarbarianLife = 3000, maxBarbarianLife = 3750;
            const int minBarbarianAttack = 150, maxBarbarianAttack = 250;
            const int minBarbarianReduction = 35, maxBarbarianReduction = 45;

            const int minMagicianLife = 1100, maxMagicianLife = 1500;
            const int minMagicianAttack = 300, maxMagicianAttack = 400;
            const int minMagicianReduction = 20, maxMagicianReduction = 35;

            const int minDruidLife = 2000, maxDruidLife = 2500;
            const int minDruidAttack = 70, maxDruidAttack = 120;
            const int minDruidReduction = 25, maxDruidReduction = 40;

            const int minMonsterLife = 7000, maxMonsterLife = 10000;
            const int minMonsterAttack = 300, maxMonsterAttack = 400;
            const int minMonsterReduction = 20, maxMonsterReduction = 30;

            int count = 0;
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¿Qué deseas hacer?\n\n0. Salir\n1. Jugar!");
                    Console.ForegroundColor = ConsoleColor.White;
                    selector = Convert.ToInt32(Console.ReadLine());
                    count++;

                    // Si el contador llega a 3, establece selector a 2 y sal del bucle.
                    if (count == MAX_ATTEMPTS)
                    {
                        selector = 2;
                        break;
                    }

                } while (!Metodos.RangSelectors(selector, 0, 1, count));

                count = 0; // Reinicio de contador
                Metodos.PulsaEspacioParaContinuar();
                Console.Clear();

                if (selector == 1)
                {
                    Console.WriteLine("¿Quieres volver a jugar? (Sí: 1 / No: 0)");
                    playAgain = Console.ReadLine().Trim().Equals("1");

                    Console.Clear(); // Limpiar la consola para la próxima partida

                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(msgSlectDifficult);/*Mensaje seleccionar dificultad*/
                        Console.ForegroundColor = ConsoleColor.White;
                        selector = Convert.ToInt32(Console.ReadLine());/*Introducir respuesta a pregunta*/
                        count++;/*contador intentos*/
                    } while (!Metodos.RangSelectors(selector, 1, 4, 3) || count == 3);
                    count = 0;/*Reinicio de contador*/
                    Metodos.PulsaEspacioParaContinuar();
                    Console.Clear();

                    switch (selector) /*Switch que identifica el nivel*/
                    {
                        case 1:
                            easy = true; /*Si es 1 es facil*/
                            break;
                        case 2:
                            hard = true; /*Si es 2 es dificil*/
                            break;
                        case 3:
                            personalization = true; /*Si es 3 es personalizado*/
                            break;
                        case 4:
                            random = true; /*Si es 4 es aleatorio*/
                            break;
                    }
                }
                else
                {
                    playAgain = false;
                }
            } while (playAgain);
        }
}