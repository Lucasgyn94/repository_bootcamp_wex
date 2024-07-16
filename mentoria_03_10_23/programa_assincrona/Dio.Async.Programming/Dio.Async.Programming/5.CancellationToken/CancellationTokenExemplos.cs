﻿
namespace Dio.Async.Programming;
public class CancellationTokenExemplos
{
    public static async Task ExecutarCancellationToken()
    {
        // cancellation token = cancela uma requisição assincrona em andamento
        var cancellationTokenSource = new CancellationTokenSource();
        cancellationTokenSource.CancelAfter(2000); // cancelar apos 2 segundos

        await OperacaoDemorada(cancellationTokenSource.Token);
    }

    private static async Task OperacaoDemorada(CancellationToken token)
    {
        await Console.Out.WriteLineAsync("Iniciando a operação demorada.");

        try {

            for (int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested();

                await Console.Out.WriteLineAsync($"Iteração {i}");
                await Task.Delay(1000, token);
                
            }

        } catch (OperationCanceledException) {
            await Console.Out.WriteLineAsync("Operação cancelada devido a demora.");
        }
    }
}