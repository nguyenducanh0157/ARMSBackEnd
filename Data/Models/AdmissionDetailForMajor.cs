using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.Models
{
    public class AdmissionDetailForMajor
    {
        public Guid ADMId { get; set; }
        public int Year { get; set; }
        public decimal TotalScore { get; set; }
        public decimal TotalScoreAcademic { get; set; }
        public bool StatusScore { get; set; }
        public bool StatusScoreAcademic { get; set; }
        public string? SubjectGroupsJson { get; set; }
        [NotMapped]
        public List<SubjectGroup>? SubjectGroups
        {
            get => string.IsNullOrEmpty(SubjectGroupsJson)
                   ? new List<SubjectGroup>()
                   : JsonSerializer.Deserialize<List<SubjectGroup>>(SubjectGroupsJson);
            set => SubjectGroupsJson = JsonSerializer.Serialize(value);
        }
        public string MajorID { get; set; }
        public virtual Major? Major { get; set; }

    }
}
