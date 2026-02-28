// RESPOSTA
//1- dotnet new webapi, dotnet new xunit
//2- Criado 
//3- net10.0

Console.WriteLine("Calculadora");

Console.WriteLine("Digite o primeiro numero");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
double num2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Escolha a operacao");

Console.WriteLine("1 - adicao");
Console.WriteLine("2 - subtracao");
Console.WriteLine("3 - mutiplicacao");
Console.WriteLine("4 - divisao");

int op = Convert.ToInt32(Console.ReadLine());
double result = 0.0;

switch (op){
    case 1:
        result =  num1 + num2;   
    break;

    case 2:
        result = num1 - num2;
    break;

    case 3:
        result = num1 * num2;
    break;

    case 4:
        if( num2 == 0){   
            Console.WriteLine("Não existe divisao por 0");
            return;
        }
        result = num1 / num2;    
    break;
    default:
        Console.WriteLine("Opcao invalida");

        break;

    }


Console.WriteLine("Result: " + result);



