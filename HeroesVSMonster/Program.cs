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

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Bienvenido al juego!"); /*Mensaje Bienvenida*/
                    string[] heroNames = Metodos.GetHeroNamesInput(); /*Funcion nombres*/
                    /*Asignación nombres en cada espacio de la array*/
                    string archerName = heroNames[0];
                    string barbarianName = heroNames[1];
                    string magicianName = heroNames[2];
                    string druidName = heroNames[3];


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

                    Console.Clear();
                    if (personalization) /*Si es personalizado*/
                    {
                        /*Introducir valores personalizados*/
                        archerLife = Metodos.GetUserInputWithValidation($"Ingrese la vida de la arquera ({minArcherLife} - {maxArcherLife}):", minArcherLife, maxArcherLife);
                        archerAttack = Metodos.GetUserInputWithValidation($"Ingrese el ataque de la arquera ({minArcherAttack} - {maxArcherAttack}):", minArcherAttack, maxArcherAttack);
                        archerReduction = Metodos.GetUserInputWithValidation($"Ingrese la reducción de daño de la arquera ({minArcherReduction}-{maxArcherReduction}) (%):", minArcherReduction, maxArcherReduction);
                        Console.Clear();
                        barbarianLife = Metodos.GetUserInputWithValidation($"Ingrese la vida del bárbaro ({minBarbarianLife} - {maxBarbarianLife}):", minBarbarianLife, maxBarbarianLife);
                        barbarianAttack = Metodos.GetUserInputWithValidation($"Ingrese el ataque del bárbaro ({minBarbarianAttack} - {maxBarbarianAttack}):", minBarbarianAttack, maxBarbarianAttack);
                        barbarianReduction = Metodos.GetUserInputWithValidation($"Ingrese la reducción de daño del bárbaro ({minBarbarianReduction}-{maxBarbarianReduction}) (%):", minBarbarianReduction, maxBarbarianReduction);
                        Console.Clear();
                        magicianLife = Metodos.GetUserInputWithValidation($"Ingrese la vida de la maga ({minMagicianLife} - {maxMagicianLife}):", minMagicianLife, maxMagicianLife);
                        magicianAttack = Metodos.GetUserInputWithValidation($"Ingrese el ataque de la maga ({minMagicianAttack} - {maxMagicianAttack}):", minMagicianAttack, maxMagicianAttack);
                        magicianReduction = Metodos.GetUserInputWithValidation($"Ingrese la reducción de daño de la maga ({minMagicianReduction}-{maxMagicianReduction}) (%):", minMagicianReduction, maxMagicianReduction);
                        Console.Clear();
                        druidLife = Metodos.GetUserInputWithValidation($"Ingrese la vida del druida ({minDruidLife} - {maxDruidLife}):", minDruidLife, maxDruidLife);
                        druidAttack = Metodos.GetUserInputWithValidation($"Ingrese el ataque del druida ({minDruidAttack} - {maxDruidAttack}):", minDruidAttack, maxDruidAttack);
                        druidReduction = Metodos.GetUserInputWithValidation($"Ingrese la reducción de daño del druida ({minDruidReduction}-{maxDruidReduction}) (%):", minDruidReduction, maxDruidReduction);
                        Console.Clear();
                        monsterLife = Metodos.GetUserInputWithValidation($"Ingrese la vida del monstruo ({minMonsterLife} - {maxMonsterLife}):", minMonsterLife, maxMonsterLife);
                        monsterAttack = Metodos.GetUserInputWithValidation($"Ingrese el ataque del monstruo ({minMonsterAttack} - {maxMonsterAttack}):", minMonsterAttack, maxMonsterAttack);
                        monsterReduction = Metodos.GetUserInputWithValidation($"Ingrese la reducción de daño del monstruo ({minMonsterReduction}-{maxMonsterReduction}) (%):", minMonsterReduction, maxMonsterReduction);
                        Console.Clear();
                    }
                    if (random) /*Si es aleatorio*/
                    {
                        Random rnd = new Random(); /*Funcion random*/
                        /*Introducir valores aleatorios*/
                        archerLife = rnd.Next(minArcherLife, maxArcherLife + 1);
                        archerAttack = rnd.Next(minArcherAttack, maxArcherAttack + 1);
                        archerReduction = rnd.Next(minArcherReduction, maxArcherReduction + 1);

                        barbarianLife = rnd.Next(minBarbarianLife, maxBarbarianLife + 1);
                        barbarianAttack = rnd.Next(minBarbarianAttack, maxBarbarianAttack + 1);
                        barbarianReduction = rnd.Next(minBarbarianReduction, maxBarbarianReduction + 1);

                        magicianLife = rnd.Next(minMagicianLife, maxMagicianLife + 1);
                        magicianAttack = rnd.Next(minMagicianAttack, maxMagicianAttack + 1);
                        magicianReduction = rnd.Next(minMagicianReduction, maxMagicianReduction + 1);

                        druidLife = rnd.Next(minDruidLife, maxDruidLife + 1);
                        druidAttack = rnd.Next(minDruidAttack, maxDruidAttack + 1);
                        druidReduction = rnd.Next(minDruidReduction, maxDruidReduction + 1);

                        monsterLife = rnd.Next(minMonsterLife, maxMonsterLife + 1);
                        monsterAttack = rnd.Next(minMonsterAttack, maxMonsterAttack + 1);
                        monsterReduction = rnd.Next(minMonsterReduction, maxMonsterReduction + 1);
                    }
                }
                else
                {
                    playAgain = false;
                }
            } while (playAgain);
        }
    }
}