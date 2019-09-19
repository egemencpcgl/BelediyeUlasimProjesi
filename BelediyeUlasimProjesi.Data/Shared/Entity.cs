using System;
using System.ComponentModel.DataAnnotations;

namespace BelediyeUlasimProjesi.Data
{
    public class Entity<T>:CommonEntity
    {
        public T Id { get; set; }
              
    }
    public class Entity : CommonEntity
    {
        public int Id { get; set; }
    }
    public class CommonEntity
    {
        [Display(Name="Eklenme Tarihi")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
