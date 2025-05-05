
namespace Doctor.Domain.Entities
{
    public class Procedures:BaseEntity
    {
        public string Name {  get; set; }
        public string About {  get; set; }
        public string Description {  get; set; }
        public string? İcon {  get; set; }
        public string Mainİmage {  get; set; }
        public string? AddImage {  get; set; }
        public string? Permanence {  get; set; }
        public bool? IsMain {  get; set; }

    }
}
