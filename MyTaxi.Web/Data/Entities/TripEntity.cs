using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Taxi.Web.Data.Entities;

namespace MyTaxi.Web.Data.Entities
{
    public class TripEntity
    {
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name ="Star Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode =false)]
        public DateTime StarDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Star Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime StarDataLocal => StarDate.ToLocalTime();
        
        [DataType(DataType.DateTime)]
        [Display(Name ="End Date")]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode =false)]
        public DateTime? EndDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Star Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime? EndDateLocal => EndDate?.ToLocalTime();

        [MaxLength(100,ErrorMessage ="The {0} field must have {1} characters.")]
        public string Source { get; set; }

        [MaxLength(100,ErrorMessage ="The {0} field must have {1} characters.")]
        public string Target { get; set; }
        public float Qualification { get; set; }
        public double SourceLatitude { get; set; }
        public double SourceLongitude { get; set; }
        public double TargetLatitude { get; set; }
        public double TargetLongitude { get; set; }
        public string Remarks { get; set; }
        public TaxiEntity Taxi { get; set; }
        public ICollection<TripDetailEntity> TripDetails { get; set; }

    }
}

