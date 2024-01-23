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

            const int MinArcherLife = 2000, MinArcherAttack = 300, MinArcherReduction = 35;
            const int MinBarbarianLife = 3750, MinBarbarianAttack = 250, MinBarbarianReduction = 45;
            const int MinMagicianLife = 1500, MinMagicianAttack = 400, MinMagicianReduction = 35;
            const int MinDruidLife = 2500, MinDruidAttack = 120, MinDruidReduction = 40;
            const int MinMonsterLife = 7000, MinMonsterAttack = 300, MinMonsterReduction = 20;

            const int MaxArcherLife = 1500, MaxArcherAttack = 200, MaxArcherReduction = 25;
            const int MaxBarbarianLife = 3000, MaxBarbarianAttack = 150, MaxBarbarianReduction = 35;
            const int MaxMagicianLife = 1100, MaxMagicianAttack = 300, MaxMagicianReduction = 20;
            const int MaxDruidLife = 2000, MaxDruidAttack = 70, MaxDruidReduction = 25;
            const int MaxMonsterLife = 10000, MaxMonsterAttack = 400, MaxMonsterReduction = 30;


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

                    if (easy) /*Si es facil*/
                    {
                        /*Introducir valores faciles*/
                        archerLife = MinArcherLife;
                        archerAttack = MinArcherAttack;
                        archerReduction = MinArcherReduction;

                        barbarianLife = MinBarbarianLife;
                        barbarianAttack = MinBarbarianAttack;
                        barbarianReduction = MinBarbarianReduction;

                        magicianLife = MinMagicianLife;
                        magicianAttack = MinMagicianAttack;
                        magicianReduction = MinMagicianReduction;

                        druidLife = MinDruidLife;
                        druidAttack = MinDruidAttack;
                        druidReduction = MinDruidReduction;

                        monsterLife = MinMonsterLife;
                        monsterAttack = MinMonsterAttack;
                        monsterReduction = MinMonsterReduction;
                    }

                    if (hard) /*Si es dificil*/
                    {
                        /*Introducir valores dificiles*/
                        archerLife = MaxArcherLife;
                        archerAttack = MaxArcherAttack;
                        archerReduction = MaxArcherReduction;

                        barbarianLife = MaxBarbarianLife;
                        barbarianAttack = MaxBarbarianAttack;
                        barbarianReduction = MaxBarbarianReduction;

                        magicianLife = MaxMagicianLife;
                        magicianAttack = MaxMagicianAttack;
                        magicianReduction = MaxMagicianReduction;

                        druidLife = MaxDruidLife;
                        druidAttack = MaxDruidAttack;
                        druidReduction = MaxDruidReduction;

                        monsterLife = MaxMonsterLife;
                        monsterAttack = MaxMonsterAttack;
                        monsterReduction = MaxMonsterReduction;

                        int torn = 1; /*Contador de turnos*/
                        bool isDefendingArcher = false; /*Defensa de cada heroe*/
                        bool isDefendingBarbarian = false;
                        bool isDefendingMagician = false;
                        bool isDefendingDruid = false;
                        int SpecialHabilityBarbarian = 2; /*Habilidad especial*/
                        int SpecialHabilityArcher = 2;
                        int InteractiveTurnsArcher = 0; /*Turnos de habilidad especial*/
                        int InteractiveTurnsBarbarian = 0;
                        int InteractiveTurnsMagician = 0;
                        int InteractiveTurnsDruid = 0;


                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("¡Comienza la Batalla!"); /*Mensaje de inicio de batalla*/
                        while (monsterLife > 0 && (archerLife > 0 || barbarianLife > 0 || druidLife > 0 || magicianLife > 0)) /*Bucle de batalla*/
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            SpecialHabilityBarbarian--; /*Contador de habilidad especial*/
                            SpecialHabilityArcher--; /*Contador de habilidad especial*/
                            Console.WriteLine($"turno: {torn}"); /*Mostrar turno*/
                            Console.WriteLine();
                            int heroTurn; /*Turno de cada heroe*/
                            int[] numeros = { 1, 2, 3, 4 }; /*Array de numeros para el random*/
                            int DethCount = 4;
                            if (archerLife <= 0)
                            {
                                DethCount--;
                            }
                            if (barbarianLife <= 0)
                            {
                                DethCount--;
                            }
                            if (magicianLife <= 0)
                            {
                                DethCount--;
                            }
                            if (druidLife <= 0)
                            {
                                DethCount--;
                            }
                            for (int i = 0; i < DethCount; i++) /*Bucle de turnos*/
                            {
                                if (monsterLife > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    heroTurn = Metodos.GetRandomValueOrder(1, 4, numeros, archerLife, barbarianLife, magicianLife, druidLife);/*Funcion random de turnos*/

                                    switch (heroTurn)/*Switch de turnos*/
                                    {
                                        case 1:
                                            numeros[0] = 5; /*Asignar numero para que no se repita*/
                                            Console.WriteLine($"Turno de l'arqura {archerName}"); /*Mostrar nombre de heroe*/
                                            break;
                                        case 2:
                                            numeros[1] = 6;
                                            Console.WriteLine($"Turno del barbar {barbarianName}");
                                            break;
                                        case 3:
                                            numeros[2] = 7;
                                            Console.WriteLine($"Turno de la maga {magicianName}");
                                            break;
                                        case 4:
                                            numeros[3] = 8;
                                            Console.WriteLine($"Turno del druida {druidName}");
                                            break;
                                    }
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine(msgSlector); /*Mensaje de seleccionar accion*/
                                    Console.WriteLine();
                                    selector = Convert.ToInt32(Console.ReadLine());
                                    switch (selector) /*Switch de accion*/
                                    {
                                        case 1: /*Atacar*/
                                            Console.WriteLine("Atacar");
                                            monsterLife = Metodos.monsterLifeReducction(monsterLife, monsterReduction, heroTurn, archerAttack, barbarianAttack, magicianAttack, druidAttack);
                                            Console.WriteLine(monsterLife);
                                            break;

                                        case 2: /*Defender*/
                                            Console.WriteLine("Defender");
                                            if (heroTurn == 1)
                                            {
                                                isDefendingArcher = true;
                                            }
                                            else if (heroTurn == 2)
                                            {
                                                isDefendingBarbarian = true;
                                            }
                                            else if (heroTurn == 3)
                                            {
                                                isDefendingMagician = true;
                                            }
                                            else if (heroTurn == 4)
                                            {
                                                isDefendingDruid = true;
                                            }
                                            break;

                                        case 3: /*Habilidad especial*/
                                            Console.WriteLine("Habilidad Especial");
                                            switch (heroTurn)
                                            {
                                                case 1:
                                                    if (InteractiveTurnsArcher <= 0) /*Si la habilidad especial es 0*/
                                                    {
                                                        Console.WriteLine("¡La arquera noquea al Monstruo dos turnos!"); /*Mensaje de habilidad especial*/
                                                        SpecialHabilityArcher = 2; /*Contador de habilidad especial*/
                                                        InteractiveTurnsArcher = 5; /*Contador de habilidad especial*/
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("¡La arquera no puede usar su habilidad especial!"); /*Mensaje de habilidad especial*/
                                                    }

                                                    break;
                                                case 2:
                                                    if (InteractiveTurnsBarbarian <= 0) /*Si la habilidad especial es 0*/
                                                    {
                                                        Console.WriteLine("¡El bárbaro se enfada!"); /*Mensaje de habilidad especial*/
                                                        SpecialHabilityBarbarian = 2; /*Contador de habilidad especial*/
                                                        InteractiveTurnsBarbarian = 5; /*Contador de habilidad especial*/
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("¡El bárbaro no puede usar su habilidad especial!"); /*Mensaje de habilidad especial*/
                                                    }
                                                    break;

                                                case 3:
                                                    if (InteractiveTurnsMagician <= 0) /*Si la habilidad especial es 0*/
                                                    {
                                                        Console.WriteLine("¡La maga dispara una bola de fuego que hace 3 veces su ataque!"); /*Mensaje de habilidad especial*/
                                                        monsterLife = Metodos.monsterLifeReducction(monsterLife, monsterReduction, heroTurn, magicianAttack * 3, barbarianAttack, magicianAttack, druidAttack); /*Funcion de habilidad especial del mago*/
                                                        Console.WriteLine($"Nueva vida del monstruo: {monsterLife}"); /*Mostrar vida del monstruo*/
                                                        InteractiveTurnsMagician = 5; /*Contador de habilidad especial*/
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("¡La maga no puede usar su habilidad especial!"); /*Mensaje de habilidad especial*/
                                                    }
                                                    break;
                                                case 4:
                                                    if (InteractiveTurnsDruid <= 0) /*Si la habilidad especial es 0*/
                                                    {
                                                        Console.WriteLine("¡El druida cura 500 de vida a todos los héroes!"); /*Mensaje de habilidad especial*/
                                                        archerLife = Metodos.DruiSpecialHability(archerLife); /*Funcion de habilidad especial del druida*/
                                                        barbarianLife = Metodos.DruiSpecialHability(barbarianLife);
                                                        magicianLife = Metodos.DruiSpecialHability(magicianLife);
                                                        druidLife = Metodos.DruiSpecialHability(druidLife);
                                                        InteractiveTurnsDruid = 5; /*Contador de habilidad especial*/
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("¡El druida no puede usar su habilidad especial!"); /*Mensaje de habilidad especial*/
                                                    }
                                                    break;
                                            }
                                            break;
                                    }
                                    Metodos.PulsaEspacioParaContinuar();
                                }
                            }
                            if (monsterLife > 0)
                            {
                                Console.WriteLine("Monster's Turn (5)"); /*Turno del monstruo*/
                                if (SpecialHabilityBarbarian <= 0) /*Si la habilidad especial es 0*/
                                {
                                    isDefendingBarbarian = false; /*Dejar de defender*/
                                }
                                if (SpecialHabilityArcher <= 0)
                                {
                                    if (archerLife > 0)
                                        archerLife = Metodos.heroLifeReduction(archerLife, isDefendingArcher, monsterAttack, archerReduction, archerName); /*Funcion de reduccion de vida de cada heroe*/
                                    if (barbarianLife > 0)
                                        barbarianLife = Metodos.heroLifeReduction(barbarianLife, isDefendingBarbarian, monsterAttack, barbarianReduction, barbarianName);
                                    if (magicianLife > 0)
                                        magicianLife = Metodos.heroLifeReduction(magicianLife, isDefendingMagician, monsterAttack, magicianReduction, magicianName);
                                    if (druidLife > 0)
                                        druidLife = Metodos.heroLifeReduction(druidLife, isDefendingDruid, monsterAttack, druidReduction, druidName);
                                }

                                /*ordena la vida de los heroes sin usar array*/


                                Metodos.OrderLife(archerLife, barbarianLife, magicianLife, druidLife); /*Funcion de ordenar vida de los heroes*/

                            }



                            torn++; /*Aumentar turno*/
                            InteractiveTurnsArcher--; /*Contador de habilidad especial*/
                            InteractiveTurnsBarbarian--; /*Contador de habilidad especial*/
                            InteractiveTurnsMagician--; /*Contador de habilidad especial*/
                            InteractiveTurnsDruid--; /*Contador de habilidad especial*/
                            Metodos.PulsaEspacioParaContinuar();

                        }
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