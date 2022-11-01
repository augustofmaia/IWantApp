namespace IWantApp.Domain.Products;
// Foi criado um arquivo ".edtorconfig" para mudar o tipo de declaração de namespace para "Escopo de Arquivo". Assim a namespace fica acima do codigo, não envolvida na classe.
public class Product : Entity
{
    public string Name { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
    public string Description { get; set; }
    public bool HasStock { get; set; }
    public bool Active { get; set; } = true;
}
