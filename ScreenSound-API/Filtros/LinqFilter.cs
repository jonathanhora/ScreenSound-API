using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosGeneros(List<Musica> musicas)
        {
            var todosGeneros = musicas.Select(g => g.Genero).Distinct().ToList();

            foreach (var genero in todosGeneros)
            {
                Console.WriteLine(genero);
            }
        }

        public static void FiltrarMusicasDoArtista(List<Musica> musicas, string artista)
        {
            var musicasArtista = musicas.Where(a => a.Artista!.Equals(artista)).Distinct().ToList();

            foreach (var musica in musicasArtista)
            {
                Console.WriteLine(musica.Nome);
            }
        }
    }
}
