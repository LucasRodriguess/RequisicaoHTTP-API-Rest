using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Requisicao_API_Rest.PrimeiraRequisicao
{
public class Requisicao1
{
    public static async Task RequisicaoPrimaria()
    {
        string apiUrl = ""; // Url para onde estará sendo feito a requisição aqui
        string authToken = ""; // token de autenticação

        // corpo da requisição aqui
        string jsonBody = @"
        {
            ""Exemplo"": ""teste"",
            ""Exemplo"": ""teste""
        }";

        var conteudo = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

        using (HttpClient client = new HttpClient())
        {
            try
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {authToken}");

                HttpResponseMessage response = await client.PostAsync(apiUrl, conteudo);

                if (response.IsSuccessStatusCode)
                {
                    string resposta = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Resposta para primeira requisição: {resposta}"); // resposta da requisição
                }
                else
                {
                    Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Erro na requisição: {e.Message}");
            }
        }
    }
}
}