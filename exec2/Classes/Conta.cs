public abstract class Conta
{
public decimal _saldo;
public decimal _limite;

public decimal Saldo => _saldo;
public decimal Limite
{
  get { return _limite; }
    set
{
   if (value >= 0)
     _limite = value;
   else
     throw new ArgumentOutOfRangeException("Limite não pode ser negativo.");
 }
}
public abstract void Depositar(decimal valor);
   public abstract void Sacar(decimal valor);
}
