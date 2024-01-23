# HeroesVSMonster

## Methods

### RangSelectors

```
public static bool RangSelectors(int num, int lessValue, int MaxValue, int count) /*Introduccir decisiones*/
{
    return num >= lessValue && num <= MaxValue; /*Devolver valores*/
}

```

Serveix per saber si un valor introduit esta dins d'un rang

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 1,2,3,4
- Classes invàlides: cap

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### GetHeroNamesInput

```
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

```

Serveix per introduir nombres

####Varchar

##### Classes d'Equivalència

- Classes vàlides: Personaje1 Personaje2 Personaje3 Personaje4, A B C a b c
- Classes invàlides: Personaje1 Personaje2 Personaje3

##### Valors Límit

- Valor mínim: A
- Valor màxim: z

### GetUserInputWithValidation

```
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

```

Serveix per introduir els valors personalitzats

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 1, 2, 3
- Classes invàlides: -11, -50, 32

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### GetRandomValueOrder

```
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

```

Serveix per introduir els valors aleatoris

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 1, 2, 3
- Classes invàlides: -11, -50, 32

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### DruiSpecialHability

```
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

```

Serveix per utilitzar l'habilitat especial del druida

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 500, 100, 1
- Classes invàlides: -11, -50, 0

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### monsterLifeReducction

```
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

```

Serveix per utilitzar reduir la salud del monstre

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 500, 100, 1
- Classes invàlides: -11, -50, 0

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### OrderLife


```
public static void OrderLife(int archerLife, int barbarianLife, int magicianLife, int druidLife)
{
    int a = archerLife;
    int b = barbarianLife;
    int c = magicianLife;
    int d = druidLife;

    if (a > b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    if (b > c)
    {
        int temp = b;
        b = c;
        c = temp;
    }

    if (c > d)
    {
        int temp = c;
        c = d;
        d = temp;
    }

    if (a > b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    if (b > c)
    {
        int temp = b;
        b = c;
        c = temp;
    }

    if (a > b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    Console.WriteLine("La vida restante de los héroes ({0}, {1}, {2}, {3}) ordenada de forma ascendente es: {4}, {5}, {6}, {7}", "Arquera", "Bárbaro", "Maga", "Druida", a, b, c, d);
}

```
Serveix per ordenar la vida del herois


####Numeric

##### Classes d'Equivalència

- Classes vàlides: 500, 100, 1
- Classes invàlides: -20, -6, 0

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### GetRandomValue

```
public static int GetRandomValue(int minValue, int maxValue) /*Introducir valores aleatorios*/
{
    Random rnd = new Random(); /*Funcion random*/
    return rnd.Next(minValue, maxValue + 1); /*Devolver valores*/
}

```

Serveix per donar un valor aleatori

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 500, 100, -20
- Classes invàlides: cap

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### CalculateDamage

```
public static int CalculateDamage(int heroAttack, int monsterReduction)
{
    int damage = heroAttack - (monsterReduction * heroAttack / 100);
    return damage > 0 ? damage : 0;
}

```

Serveix per calcular el dany

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 500, 100, 1
- Classes invàlides: 0, -4, -5

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### CalcAtack

```
public static int CalcAtack(int heroTurn, int archerAttack, int barbarianAttack, int magicianAttack, int druidAttack)
{
    switch (heroTurn)
    {
        case 1:
            return archerAttack;
        case 2:
            return barbarianAttack;
        case 3:
            return magicianAttack;
        case 4:
            return druidAttack;
        default:
            return 0;
    }
}

```

Calcular el ataque

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 500, 100, 1
- Classes invàlides: 0, -4, -5

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

### heroLifeReduction

```
public static int heroLifeReduction(int heroLife, bool isDefending, int monsterAttack, int Reduction, string name)
{
    if (heroLife <= 0)
    {
        Console.WriteLine();
        return 0;
    }
    else
    {
        int especialAttack = GetRandomValue(1, 101);

        if (isDefending)
        {
            Console.WriteLine($"¡El héroe {name} está defendiendo y no recibe daño!");
            Console.WriteLine();
            return heroLife;
        }

        int damage = CalculateDamage(monsterAttack, Reduction);

        if (especialAttack <= 5)
        {
            Console.WriteLine("¡El monstruo falla su ataque especial!");
            damage = 0;
        }
        else if (especialAttack <= 15 && especialAttack > 5)
        {
            Console.WriteLine("¡El monstruo realiza un ataque especial!");
            damage *= 2;
        }

        Console.WriteLine($"Daño al héroe {name}: {damage}");
        int newHeroLife = heroLife - damage;

        if (newHeroLife < 0)
        {
            newHeroLife = 0;
            Console.WriteLine($"¡La vida del héroe {name} llegó a cero!");
        }

        Console.WriteLine($"Vida actual del héroe {name}: {newHeroLife}");
        Console.WriteLine();
        return newHeroLife;
    }
}
```

Reduccion vida de los heroes

####Numeric

##### Classes d'Equivalència

- Classes vàlides: 500, 100, 1
- Classes invàlides: 0, -4, -5

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

---