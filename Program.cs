menu();
Console.ReadKey();

static void menu()
{
    Console.Clear();
    Console.WriteLine("Escolha a operação desejada.");
    Console.WriteLine("1 Soma");
    Console.WriteLine("2 subtração");
    Console.WriteLine("3 divisão");
    Console.WriteLine("4 multiplicação");
    Console.WriteLine("5 Sair");
    Console.WriteLine("--------------");
    Console.WriteLine("Selecione a opção desejada");
    int operationSelected = int.Parse(Console.ReadLine());

    switch (operationSelected)
    {
        case 1: soma(); break;
        case 2: subtracao(); break;
        case 3: divisao(); break;
        case 4: multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;

        default: menu(); break;
    }

    /*
        if (operationSelected == 1) soma();
        if (operationSelected == 2) subtracao();
        if (operationSelected == 3) divisao();
        if (operationSelected == 4) multiplicacao();
    */
}



static void soma()

{
    Console.Clear();
    Console.WriteLine("Escreva o primeiro valor");
    float val1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o primeiro valor");
    float val2 = float.Parse(Console.ReadLine());


    float result = (val1 + val2);

    Console.WriteLine($"O resultado da soma é:{result}");
    Console.ReadKey();
    menu();

}
static void subtracao()

{
    Console.Clear();
    Console.WriteLine("Escreva o primeiro valor");
    float val1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o segundo valor");
    float val2 = float.Parse(Console.ReadLine());


    float result = (val1 - val2);

    Console.WriteLine($"O resultado da soma é:{result}");
    Console.ReadKey();
    menu();

}
static void divisao()
{
    Console.Clear();
    Console.WriteLine("Escreva o primeiro valor");
    float val1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o primeiro valor");
    float val2 = float.Parse(Console.ReadLine());


    float result = (val1 / val2);

    Console.WriteLine($"O resultado da soma é:{result}");
    Console.ReadKey();
    menu();

}
static void multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Escreva o primeiro valor");
    float val1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Escreva o primeiro valor");
    float val2 = float.Parse(Console.ReadLine());


    float result = (val1 * val2);

    Console.WriteLine($"O resultado da soma é:{result}");
    Console.ReadKey();
    menu();

}