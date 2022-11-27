namespace IWantApp.Endpoints.Categories;

public class CategoryResponse
{
    public CategoryResponse(Guid id, string name, bool active)
    {
        Id = id;
        Name = name;
        Active = active;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Active { get; set; }
}