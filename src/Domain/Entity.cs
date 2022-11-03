using Flunt.Notifications;
// o NuGet Flunt foi usado para a entidade possa validar de uma vez so as exceptions, atravez de notificações encapsuladas
namespace IWantApp.Domain;
// Classe abstract não pode ser estanciada apenas herdada
public abstract class Entity : Notifiable<Notification>
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    // Para facilitar  o monitoramento, devemos criar esses campos básicos para saber quem/quando criou e editou
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string EditedBy { get; set; }
    public DateTime EditedOn { get; set; }
}
