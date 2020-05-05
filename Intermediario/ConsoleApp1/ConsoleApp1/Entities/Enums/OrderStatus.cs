
namespace ConsoleApp1.Entities.Enums
{
    //esta classe cria significado para os valores de status da class Order, melhora a semantica
    enum OrderStatus : int //: indica heranca
    {
        PendingPayment = 0, //por padrão se não indicar = 0 a contagem é por zero ou pode se determinar outro valor assim PendingPayment = 8
        Processing = 1,
        Shipped = 2,
        Delivered =3 
    }
}
