using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosGeneros(musicas);
        //LinqOrder.ExibirArtistasOrdenados(musicas);
        //LinqOrder.FiltrarArtistaPorGenero(musicas, "hip hop");
        LinqFilter.FiltrarMusicasDoArtista(musicas, "Travis Scott");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}