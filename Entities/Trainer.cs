using MVC___Session_1.Entities.Enums;

namespace MVC___Session_1.Entities
{
    public class Trainer : GymUser
    {
        public Specialties Specialty { get; set; }
        public ICollection<Session> Sessions { get; set; } = default!;


    }
}
