
namespace Doctor.Domain.Entities
{
    public class Slides:BaseEntity
    {
        public string Image {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public bool IsMain { get; set; }

    }
}
