using System;
using System.Data.SqlTypes;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Teste_Requisicao_API_Rest.PrimeiraRequisicao;
using Teste_Requisicao_API_Rest.SegundaRequisicao;

class ExecutaOperacao
{
    static async Task Main()
    {
        await Task.WhenAll(
            ExecutorPrimeiraRequisicao(),
            ExecutorSegundaRequisicao()
        );
    }

    static async Task ExecutorPrimeiraRequisicao()
    {
        await Task.Run(() => Requisicao1.RequisicaoPrimaria());
    }

    static async Task ExecutorSegundaRequisicao()
    {
        await Task.Run(() => Requisicao2.RequisicaoSecundaria());
    }
}