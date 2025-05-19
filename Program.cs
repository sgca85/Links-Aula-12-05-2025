Console.WriteLine(
@"
Menu de opções
--------------
N. Novo arquivo
A. Abrir arquivo
H. Ajuda
X. Sair
");

Console.Write("\nSelecione uma opção do menu: ");
string entrada = Console.ReadLine()!
                .Substring(0,1).ToUpper();

switch (entrada)
{
    case "N":
    case "n":
        Console.WriteLine("Novo arquivo");
        break;
    case "A":
    case "a":
        Console.WriteLine("Abrir arquivo");
        break;
    case "H":
    case "h":
        Console.WriteLine("Ajuda");
        break;
    case "X":
    case "x":
        Console.WriteLine("Sair");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}


// Menu_Subrotina_Program.cs

Console.Clear();

ExibeMenu();

Console.Write("\nSelecione uma opção do menu: ");
string entrada = Console.ReadLine()!
                .Substring(0,1).ToUpper();

//Opcao 1
string resultado = ProcessaEscolhaMenu(entrada);
Console.WriteLine(resultado);

//Opcao 2
//Console.WriteLine(ProcessaEscolhaMenu(entrada));

void ExibeMenu()
{
    TrocaCorConsole();
    Console.WriteLine(
    @"
    Menu de opções
    --------------
    N. Novo arquivo
    A. Abrir arquivo
    H. Ajuda
    X. Sair
    ");
    Console.ResetColor();
}

void TrocaCorConsole()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.BackgroundColor = ConsoleColor.White;
}

// string ProcessaEscolhaMenu(string escolha)
// {
//     string resultado = "";
//     switch (escolha)
//     {
//         case "N":
//             resultado = "Novo arquivo";
//             break;
//         case "A":
//             resultado = "Abrir arquivo";
//             break;
//         case "H":
//             resultado = "Ajuda";
//             break;
//         case "X":
//             resultado = "Sair";
//         break;
//     default:
//         resultado = "Opção inválida";
//         break;
//     }   

//     return resultado; 
// }

// string ProcessaEscolhaMenu(string escolha)
// {
//     string resultado = "";
//     resultado = escolha switch
//     {
//         "N" or "n" => "Novo arquivo",
//         "A" or "a" => "Abrir arquivo",
//         "H" or "h" => "Ajuda",
//         "X" or "x" => "Sair",
//         _ => "Opção inválida",
//     };
//     return resultado; 
// }

// string ProcessaEscolhaMenu(string escolha)
// {
//     return escolha switch
//     {
//         "N" or "n" => "Novo arquivo",
//         "A" or "a" => "Abrir arquivo",
//         "H" or "h" => "Ajuda",
//         "X" or "x" => "Sair",
//         _ => "Opção inválida",
//     };
// }

string ProcessaEscolhaMenu(string escolha) => escolha switch
{
    "N" or "n" => "Novo arquivo",
    "A" or "a" => "Abrir arquivo",
    "H" or "h" => "Ajuda",
    "X" or "x" => "Sair",
    _ => "Opção inválida",
};

// Naipes_Program.cs

using System.Security.Cryptography;

int naipe = RandomNumberGenerator
        .GetInt32(1, 5);
string nomeNaipe = "";

switch (naipe)
{
    case 1:
        nomeNaipe = "Paus";
        break;
    case 2: 
        nomeNaipe = "Espada";
        break;
    case 3:
        nomeNaipe = "Copas";
        break;
    case 4:
        nomeNaipe = "Ouros";
        break;  
}

Console.WriteLine(nomeNaipe);


// COMENTÁRIO DO PROFESSOR
string nomeNaipe = naipe switch
{
1 => "Paus",
2 => "Espada",
3 => "Copas",
4 => "Ouros",
_ => ""
};


