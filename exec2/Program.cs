class Program
{
static void Main()
{
  ContaBancaria conta = new ContaBancaria();
  conta.Limite = 1000; 
  bool sair = false;
  do
 {
  Console.WriteLine("\n======= Menu Principal =======");
  Console.WriteLine("1. Sacar");
  Console.WriteLine("2. Apresentar o saldo");
  Console.WriteLine("3. Depositar");
  Console.WriteLine("4. Sair");
  Console.Write("\nEscolha uma opção: ");
int opcao;
   if (int.TryParse(Console.ReadLine(), out opcao))
{
  switch (opcao)
{
  case 1:
Console.Write("Digite o valor para sacar: ");
 decimal valorSaque;
 if (decimal.TryParse(Console.ReadLine(), out valorSaque))
{
 try
{
 conta.Sacar(valorSaque);
Console.WriteLine($"Saque de {valorSaque:C} realizado com sucesso.");
}
 catch (Exception e)
{
 Console.WriteLine($"Erro ao sacar: {e.Message}");
}
 }
 else
{
 Console.WriteLine("Valor inválido para saque.");
}
break;
 case 2:
Console.WriteLine($"Saldo atual: {conta.Saldo:C}");
break;
 case 3:
Console.Write("Digite o valor para depositar: ");
decimal valorDeposito;
 if (decimal.TryParse(Console.ReadLine(), out valorDeposito))
{
 try
{
 conta.Depositar(valorDeposito);
Console.WriteLine($"Depósito de {valorDeposito:C} realizado com sucesso.");
}
 catch (Exception e)
{
Console.WriteLine($"Erro ao depositar: {e.Message}");
}
 }
 else
{
Console.WriteLine("Valor inválido para depósito.");
 }
break;
 case 4:
sair = true;
Console.WriteLine("Saindo...");
 break;
default:
Console.WriteLine("Opção inválida.");
 break;
}
 }
 else
{
Console.WriteLine("Opção inválida.");
  }
 } while (!sair);
}
}
