
namespace Dio.Async.Programming;

internal class Cozinha
{
    public void FazerComida()
    {
        FritarOvo();
        CozinharArroz();
        
    }
  
    public async Task FazerComidaAsync()
    {
        //await FritarOvoAsync();
        //await CozinharArrozAsync();
        await Task.WhenAll(FritarOvoAsync(), CozinharArrozAsync());
    }

    private void FritarOvo() {
        Console.WriteLine("Fritando ovo");
        Thread.Sleep(5000);
        Console.WriteLine("Ovo Frito");
    }
    private void CozinharArroz() {
        Console.WriteLine("Cozinhando arroz");
        Thread.Sleep(10000);
        Console.WriteLine("Fritando ovo");

    }


    private async Task CozinharArrozAsync()
    {
        await Console.Out.WriteLineAsync("Cozinhando o arroz");
        await Task.Delay(10000);
        await Console.Out.WriteLineAsync("Arroz cozido");
    }

    private async Task FritarOvoAsync()
    {
        await Console.Out.WriteLineAsync("Fritando o ovo");
        await Task.Delay(5000);
        await Console.Out.WriteLineAsync("Ovo Frito");
    }
}
