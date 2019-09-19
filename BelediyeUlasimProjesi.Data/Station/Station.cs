using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BelediyeUlasimProjesi.Data
{
    public class Station : Entity<int>
    {
        [Display(Name = "Güzergah Adı")]
        public string StationName { get; set; }
        public virtual ICollection<Bus> Buses { get; set; }
        [Display(Name = "1.Durak")]
        public string Durak1 { get; set; }
        [Display(Name = "2.Durak")]
        public string Durak2 { get; set; }
        [Display(Name = "3.Durak")]
        public string Durak3 { get; set; }
        [Display(Name = "4.Durak")]
        public string Durak4 { get; set; }
        [Display(Name = "5.Durak")]
        public string Durak5 { get; set; }
        [Display(Name = "6.Durak")]
        public string Durak6 { get; set; }
        [Display(Name = "7.Durak")]
        public string Durak7 { get; set; }
        [Display(Name = "8.Durak")]
        public string Durak8 { get; set; }
        [Display(Name = "9.Durak")]
        public string Durak9 { get; set; }
        [Display(Name = "10.Durak")]
        public string Durak10 { get; set; }
        [Display(Name = "11.Durak")]
        public string Durak11 { get; set; }
        [Display(Name = "12.Durak")]
        public string Durak12 { get; set; }
        [Display(Name = "13.Durak")]
        public string Durak13 { get; set; }
        [Display(Name = "14.Durak")]
        public string Durak14 { get; set; }
        [Display(Name = "15.Durak")]
        public string Durak15 { get; set; }
    }
}
