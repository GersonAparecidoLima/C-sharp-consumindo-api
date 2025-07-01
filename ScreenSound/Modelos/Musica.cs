
using System.Text.Json.Serialization;

namespace ScreenSound.Modelos
{
    internal class Musica
    {

        private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

        //esta propriedadde e chamado de [JsonPropertyName... atributo análogo à anotação em outras linguagens
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        //o ponto de interrogação indica que o compo pode ser nulo


        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int? Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        
        [JsonPropertyName("key")]
        public int Key { get; set; }


        public string Tonalidade
        {
            get
            {
                return tonalidades[Key];
            }
        }


        public void ExibirFichaTecnica() {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome} ");
            Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
            Console.WriteLine($"Gênero musical: {Genero}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }

    }
}
