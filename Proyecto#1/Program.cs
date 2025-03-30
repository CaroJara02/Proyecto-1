Console.WriteLine("Piedra, Papel o Tiera");

while (true)
{
    Console.WriteLine("Están listos?");
    Console.WriteLine("Entonces vamos!!!");
}

string SelectChoice()
{

    Console.WriteLine("Escoge P, PP o T: [P]iedra, [PP]apel o [T]ijera: ");
    var selectedChoice = Console.ReadLine();

    if (selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "pp" && selectedChoice?.ToLower() != "t")
    {
        Console.WriteLine("Por favor, seleccione una de estas opciones P, PP o T");
        selectedChoice = SelectChoice();
    }

    return selectedChoice;
}