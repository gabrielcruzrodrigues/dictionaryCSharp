//Stream/sequência de dados sincrona
foreach (var mes in GeraMeses())
{
    Console.WriteLine(mes);
}
static IEnumerable<string> GeraMeses()
{
    yield return "Janeiro";
    yield return "Fevereiro";
    yield return "Março";
}

//Stream/sequência de dados assíncrona
await foreach (var mes in GeraMesesAsync())
{
    Console.WriteLine(mes);
}
Console.ReadKey();
static async IAsyncEnumerable<string> GeraMesesAsync()
{
    yield return "Janeiro";
    yield return "Fevereiro";
    await Task.Delay(2000);
    yield return "Março";
}
