using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[0].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosGeneros(musicas);
        //LinqOrder.ExibirArtistasOrdenados(musicas);
        //LinqOrder.FiltrarArtistaPorGenero(musicas, "hip hop");
        //LinqFilter.FiltrarMusicasDoArtista(musicas, "Travis Scott");

        //var musicaspreferidas = new MusicasPreferidas("Jonathan");
        //musicaspreferidas.AddMusicasFavoritas(musicas[1]);
        //musicaspreferidas.AddMusicasFavoritas(musicas[11]);
        //musicaspreferidas.AddMusicasFavoritas(musicas[21]);
        //musicaspreferidas.AddMusicasFavoritas(musicas[31]);
        //musicaspreferidas.AddMusicasFavoritas(musicas[41]);

        //musicaspreferidas.ExibirMusicasFavoritas();

        //musicaspreferidas.GerarArquivoJson();

        LinqFilter.FiltrarMusicasEmDOh(musicas);


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}