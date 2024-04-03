using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirArtistasOrdenados(List<Musica> musicas)
        {
            var listaOrdenada = musicas.OrderBy(a => a.Artista).Select(a => a.Artista).Distinct().ToList();
            
            foreach (var artista in listaOrdenada)
            {
                Console.WriteLine(artista);
            }
        }

        public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
        {
            var artistaPorGenero = musicas.Where(g => g.Genero!.Contains(genero)).Select(a => a.Artista).Distinct().ToList();

            foreach(var artista in artistaPorGenero)
            {
                Console.WriteLine(artista);
            }
        }
    }
}
