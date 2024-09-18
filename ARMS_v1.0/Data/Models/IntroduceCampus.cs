using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class IntroduceCampus
    {
        public int IntroduceId { get; set; }
        public string? History { get; set; }
        public string? TrainingMotto { get; set; }
        public string? Achievements { get; set; }
        public string? WhyChooseUs { get; set; }
        public string CampusId { get; set; }
        public virtual Campus Campus { get; set; }
    }
}
