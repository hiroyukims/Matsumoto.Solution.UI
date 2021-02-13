using System.Collections.Generic;

namespace MatsumotoUI.Models
{
    public class Author : Entity
    {
          public List<StudyBook> StudyBooks { get; set; }
    }
}