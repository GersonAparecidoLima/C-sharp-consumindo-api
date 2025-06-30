using ScreenSound.Filtros;
using ScreenSound.Modelos;
using System.Text.Json;

//Criação do objeto: HttpClient client = new HttpClient()
using (HttpClient client = new HttpClient())
//Escopo do using: As chaves {} delimitam o escopo do using.
//O objeto client só estará disponível dentro desse bloco de código.
{
    //cria uma nova instância da classe HttpClient
    //Essa instância é atribuída à variável client
    try
    {
        //A url abaixo e chamado de endpoint
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);

        //Desserialização é o processo de converter dados serializados, como JSON, em objetos ou estruturas
        //de dados utilizáveis em uma linguagem de programação específica.        
        var musica = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //O ponto de exclamação indica que musica não poder ser nulo
        //Console.WriteLine(musica.Count);  
        //musica[0].ExibirFichaTecnica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musica);
        ///ExibirListaDeArtistasOrdenados
        //LinqOrder.ExibirListaDeArtistasOrdenados(musica);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musica, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musica, "U2");



    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}
