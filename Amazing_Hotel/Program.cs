using Amazing_Hotel.Entities;
using System.Runtime.CompilerServices;

List<Pessoa> hospedes = new List<Pessoa>();
Suite suite = new Suite("", 0, 0);
Reserva reseva = new Reserva(0);
decimal valorDiaria = 0;

Console.WriteLine("\n -- Bem vindo ao Amazing Hotel! --\n");
Console.Write(" Digite o nome do hóspede: ");
string primeiroNome = Console.ReadLine();
Console.Write(" Digite o sobrenome do hóspede: ");
string segundoNome = Console.ReadLine();
Pessoa p = new Pessoa(primeiroNome, segundoNome);

hospedes.Add(p);

Console.WriteLine("\n |------------------------| ");
Console.WriteLine(" | 1. Suíte Basic: R$10   |");
Console.WriteLine(" | 2. Suíte Medium: R$20  |");
Console.WriteLine(" | 3. Suíte Premium: R$30 |");
Console.WriteLine(" |------------------------| \n");

Console.Write(" Digite o tipo de suíte desejada: ");
int tipoSuite = int.Parse(Console.ReadLine());

switch (tipoSuite)
{
    case 1:
        suite = new Suite("Basic", 3, 10);
        valorDiaria = 10;
        break;
    case 2:
        suite = new Suite("Medium", 4, 20);
        valorDiaria = 20;
        break;
    case 3:
        suite = new Suite("Premium", 5, 30);
        valorDiaria = 30;
        break;
    default:
        Console.WriteLine("Opção Inválida.");
        break;
}

Console.Write(" Digite a quantidade de dias: ");
int diasReservados= int.Parse(Console.ReadLine());
Reserva reserva = new Reserva(diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine("\n --- Informações da Reserva --- \n");
Console.WriteLine($" Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($" Titular: {primeiroNome} {segundoNome}");
Console.WriteLine($" Quantidade de dias reservados: {diasReservados}");
Console.WriteLine($" Valor Total: R${reserva.CalcularValorTotal(valorDiaria)}");
