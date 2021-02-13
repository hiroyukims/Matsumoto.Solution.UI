using System;

namespace MatsumotoUI.Models
{
    public class Question : Entity
    {
         public string Title { get; set; }
        public string Description { get; set; }
        public string Response { get; set; }

        //EF relation
        public Guid StudyBookId { get; set; }
        public StudyBook StudyBook { get; set; }
    }
}