using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.SimpleTaskSystem
{
    public class Employee : AuditedAggregateRoot<Guid>
    {

        [DisplayName("სახელი")]
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [Required]
        [DisplayName("გვარი")]
        [StringLength(30)]
        public string Surname { get; set; }
        [DisplayName("პირადი ნომერი")]
        [Required]
        [StringLength(10)]
        public string PersonalNumber { get; set; }
        [DisplayName("დაბადების თარიღი")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DisplayName("ეროვნება")]
        [Required]
        public NationalityType Nationality { get; set; }

        [DisplayName("ანაზღაურება")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(0, double.MaxValue, ErrorMessage = "გთხოვთ შემოიყვანოთ ვალიდური რიცხვი")]
        public System.Nullable<int> Salary { get; set; }

        [DisplayName("ვალუტა")]
        public CurrencyType Currency { get; set; }


        [DisplayName("მობილურის ნომერი")]
        public int? Mobile { get; set; }
        public enum NationalityType
        {
            ქართველი = 1, ინგლისელი = 2, იტალიელი = 3
        }
        public enum CurrencyType
        {
            GEO = 1, USA = 2, RUB = 3
        }

    }
}
