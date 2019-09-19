
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BelediyeUlasimProjesi.Data
{
    public class Bus : Entity<int>
    {
        [Display(Name = "Otobüs Adı")]
        public string BusName { get; set; }
        [Display(Name = "Güzergah Adı")]
        public virtual string StationName { get; set; }
        public virtual int? StationId { get; set; }
        [Display(Name = "Güzergah Adı")]
        public virtual Station Station { get; set; }
        [Display(Name = "İlk Hareket Saati")]
        public TimeSpan FirstDepartureTime { get; set; }
        
        [Display(Name = "Son Hareket Saati")]
        public TimeSpan LastDepartureTime { get; set; }

    }
}


