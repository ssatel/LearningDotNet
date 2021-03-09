namespace Begin5.Application
{
    public interface IConta
    {
        public void CriarConta(int titular, int numeroConta, double saldoInicial);
        public void Sacar(double valor);
        public void Depositar(double valor);
        public double GetSaldo();

    }
}