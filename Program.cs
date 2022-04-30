string opcaoDesejada;
double a, b, resultado;
Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
         
    Console.WriteLine("Você selecionou soma");
    Console.WriteLine("---soma a + b--- \n");
    Console.WriteLine("digite os valores: ");

    Console.Write("a = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a + b;

    Console.WriteLine($"{a} somado por {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
            
        break;
    case "-":
    Console.WriteLine("Você selecionou subtração");
    Console.WriteLine("--- subtração a-b ---\n");
    Console.WriteLine("digite os valores: ");

    Console.Write("a = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a - b;

    Console.WriteLine($"{a} subitraido por {b} é {resultado}");
    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
       break;
    case "*":

    Console.WriteLine("--- Multiplicação A*B ---\n");
    Console.WriteLine("Digite os valores: ");

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = a * b;

    Console.WriteLine($"{a} multiplicado por {b} é {resultado}");
    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
        break;
    case "/": 
    
    Console.WriteLine("Você selecionou divisão");
    Console.WriteLine("--- divisao a/b ---\n");
    Console.WriteLine("digite os valores: ");

    Console.Write("a = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    b = Convert.ToDouble(Console.ReadLine());
    if(b==0)
    {   
        Console.WriteLine("Nao é possivel dividir por zero");
    }
    else
    {   
    resultado = a / b;

    Console.WriteLine($"{a} dividido por {b} é {resultado}");
    }

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
    break;
    default:
    Console.WriteLine("Opção inválida.");
        break;

}

Console.WriteLine("\nObrigado por utilizar nosso programa.");