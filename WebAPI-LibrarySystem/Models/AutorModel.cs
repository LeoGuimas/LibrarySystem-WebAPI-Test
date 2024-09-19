using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace WebAPI_LibrarySystem.Models;

public class AutorModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    [JsonIgnore]
    public ICollection<LivroModel> Livros { get; set; }
}