namespace Pixel.WebUI.Models.Entities.Commons
{
    public abstract class AuditableEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? LastModifiyBy { get; set; }
        public DateTime? LastModifiyAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
