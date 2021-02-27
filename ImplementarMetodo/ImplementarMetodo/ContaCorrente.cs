public class ContaCorrente
{
    public int agencia;
    public int conta;
    public string titular;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {

        if (this.Sacar(valor))
        {
            contaDestino.Depositar(valor);
            return true;
        }
        return false;
    }
}