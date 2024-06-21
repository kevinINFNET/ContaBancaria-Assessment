public class ContaBancaria : Conta
{
public override void Depositar(decimal valor)
{
if (valor > 0)
  _saldo += valor; 
 else
   throw new ArgumentOutOfRangeException("Valor do depósito deve ser maior que zero.");
}
 public override void Sacar(decimal valor)
{
 decimal saldoAposSaque = _saldo - valor;
  if (saldoAposSaque >= -Limite) 
   _saldo -= valor; 
  else
   throw new InvalidOperationException("Saldo insuficiente para saque.");
  }
}
