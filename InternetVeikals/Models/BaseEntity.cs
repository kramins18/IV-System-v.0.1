using System.ComponentModel.DataAnnotations;

namespace InternetVeikals.Models
{
    public class BaseEntity
    {
        #region IEntity

        [Key]
        public long Id { get; set; }
    }
}