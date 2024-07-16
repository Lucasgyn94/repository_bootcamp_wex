namespace Dio.Async.Programming;

internal class FazendoRequestHttp
{
    private const string _requestUri = "http://localhost:5223/api/controllersimples";

    public static async Task<string> GetRequest()
    {
        using var httpCliente = new HttpClient();
        var resposta = await httpCliente.GetAsync(_requestUri);
        
        return await resposta.Content.ReadAsStringAsync();
    }

    public static async Task GetRequestSequential()
    {
        using var httpCliente = new HttpClient();
        for (int i = 0; i < 5; i++) {
            var resposta = await httpCliente.GetAsync(_requestUri);
            var resultado = await resposta.Content.ReadAsStringAsync();
        }
    }

    public static async Task GetRequestParallel()
    {
        using var httpCliente = new HttpClient();
        var tasks = new List<Task>();
        for (int i = 0; i < 5; i++) {
            tasks.Add(httpCliente.GetAsync(_requestUri));
        }
        await Task.WhenAll(tasks);
    }
}
