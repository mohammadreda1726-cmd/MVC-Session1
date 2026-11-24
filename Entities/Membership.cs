using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC___Session_1.Entities
{
    public class Membership : BaseEntity
    {
        public int MemberId { get; set; }  // FK
        public Member Member { get; set; } = default!;
        public int PlanId { get; set; }  // FK
        public Plan Plan { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // colum status [ Not colum in database ]

        [NotMapped]

        public string status => StartDate > DateTime.Now ? "Upcoming"
                                : EndDate < DateTime.Now ?   "Active"
                                : "Expired";
    }
    
}
