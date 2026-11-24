namespace MVC___Session_1.Entities
{
    public class Session: BaseEntity
    {
        public string Description { get; set; } = default!;
        public string Capacity { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TrainerId { get; set; }  // FK 
        public Trainer Trainer { get; set; } = default!; 

    }
}
