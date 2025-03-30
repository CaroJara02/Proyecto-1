Console.WriteLine("Piedra, Papel o Tiera");

while (true)
{
    Console.WriteLine("Están listos?");
    Console.WriteLine("Entonces vamos!!!");

    var selectedChoice = SelectChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine($"Tú selección fue: {yourChoice}");

    var opponentChoice = GetOpponentChoice();

    Console.WriteLine($"Mi selección fue: {opponentChoice}");

    DecideWinner(opponentChoice, yourChoice);
}

string SelectChoice()
{

    Console.WriteLine("Escoge R, P o T: [R]piedra, [P]papel o [S]tijera: ");
    var selectedChoice = Console.ReadLine();

    if (selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("Por favor, seleccione una de estas opciones R, P o S");
        selectedChoice = SelectChoice();
    }

    return selectedChoice;
}

char GetOpponentChoice()
{
    char[] options = new char[] { 'R', 'P', 'S' };

    Random random = new Random();
    int randomIndex = random.Next(0, options.Length);

    return options[randomIndex];
}

void DecideWinner(char opponentChoise, char yourChoice)
{
    if (opponentChoise == yourChoice)
    {
        Console.Write("Empate!");
        return;
    }

    switch (yourChoice)
    {
        case 'R':
        case 'r':
            if (opponentChoise == 'P')
                Console.WriteLine("Papel supera a Piedra, Yo gano!");
            else if (opponentChoise == 'S')
                Console.WriteLine("Piedra supera a Tijeras, Tú ganas!");
            break;

        case 'S':
        case 's':
            if (opponentChoise == 'P')
                Console.WriteLine("Tijeras supera a Papel, Tú ganas!");
            else if (opponentChoise == 'R')
                Console.WriteLine("Piedra supera a Tijeras, Yo gano!");
            break;

        case 'P':
        case 'p':
            if (opponentChoise == 'S')
                Console.WriteLine("Tijeras supera a Papel, Yo gano!");
            else if (opponentChoise == 'R')
                Console.WriteLine("Papel supera a Piedra, Tú ganas!");
            break;

        default:
            break;

    }
}