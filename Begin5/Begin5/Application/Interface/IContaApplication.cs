using System.Threading.Tasks;

namespace Begin5.Application.Interface
{
    public interface IContaApplication
    {
        Task CriarConta(string titular, int numeroConta, double saldoInicial);
        Task Sacar(double valor);
        Task Depositar(double valor);
        Task<double> GetSaldo();

    }
}