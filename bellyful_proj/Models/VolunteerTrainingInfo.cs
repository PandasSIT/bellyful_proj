using System;
using System.Collections.Generic;

namespace bellyful_proj.Models
{
    public partial class VolunteerTrainingInfo
    {
        public int VolunteerId { get; set; }
        public byte DeliveryTraining { get; set; }
        public byte HSTraining { get; set; }
        public byte FirstAidRaining { get; set; }
        public string OtherTrainingSkill { get; set; }

        public Volunteer Volunteer { get; set; }
    }
}
