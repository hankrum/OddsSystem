using System;
using System.ComponentModel.DataAnnotations;

namespace OddsSystem.Data.Model
{
    public class SportEvent
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string EventName { get; set; }

        [Range(1.0, double.MaxValue)]
        public double OddsForFirstTeam { get; set; }

        [Range(1.0, double.MaxValue)]
        public double OddsForDraw { get; set; }

        [Range(1.0, double.MaxValue)]
        public double OddsForSecondTeam { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EventStartDate { get; set; }
    }
}
