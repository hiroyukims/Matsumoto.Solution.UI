using MatsumotoUI.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MatsumotoUI.Data
{
    public class StudyBookService : IStudyBookService
    {
        private readonly HttpClient _httpClient;
        public StudyBookService(HttpClient httpClient)
        {
             _httpClient = httpClient;
        }
        public async Task<IEnumerable<StudyBook>> GetStudyBooks() => await _httpClient.GetJsonAsync<StudyBook[]>("GetStudyBook");
    }
}
