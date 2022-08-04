using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiaryWeb.Models
{
    public class Topic
    {
        public int Id { get; set; }


        [DisplayName("Title")] public string Title { get; set; }
        [DisplayName("Desc.")] public string Description { get; set; }
        [DisplayName("Required h")] public double? TimeToMaster { get; set; }
        [DisplayName("Used h")] public double? TimeSpent { get; set; }
        [DisplayName("Source")] public string Source { get; set; }
        [DisplayName("Start")] public DateTime? StartLearningDate { get; set; }
        [DisplayName("Finnish")] public DateTime? CompletionDate { get; set; }
        [DisplayName("Done")] public bool? InProgress { get; set; }
    }
}
