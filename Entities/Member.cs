namespace MVC___Session_1.Entities
{
    public class Member:GymUser
    {
        public string? Photo { get; set; } // Modification
        public ICollection<Membership> Membersubscription { get; set; } = default!;
    }
}
