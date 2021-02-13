using System;
using System.Collections.Generic;

namespace MatsumotoUI.Models
{
    public class StudyBook : Entity 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditDate { get; set; }
        public List<Author> Authors { get; set; }
        public List<Question> Questions { get; set; }
    }
}
