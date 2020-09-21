using System.ComponentModel.DataAnnotations;

namespace InternetVeikals.Models
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}