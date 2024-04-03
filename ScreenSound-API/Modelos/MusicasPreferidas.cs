using System.Text.Json;

namespace ScreenSound_API.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicas { get; }

        public MusicasPreferidas(string nome) 
        {
            Nome = nome;
            ListaDeMusicas = new List<Musica>();
        }

        public void AddMusicasFavoritas(Musica musica)
        {
            ListaDeMusicas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            foreach(var musica in ListaDeMusicas)
            {
                Console.WriteLine($"{musica.Nome} : {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaDeMusicas
            });

            string nomeArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"Arquivo criado com sucesso : {Path.GetFullPath(nomeArquivo)}");
        }
    }
}
