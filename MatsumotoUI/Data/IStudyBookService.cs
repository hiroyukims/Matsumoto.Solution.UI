using System.Collections.Generic;
using System.Threading.Tasks;
using MatsumotoUI.Models;

namespace MatsumotoUI.Data
{
    public interface IStudyBookService
    {
         Task<IEnumerable<StudyBook>> GetStudyBooks();
    }
}