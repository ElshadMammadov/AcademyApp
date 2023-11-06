using Academy.Core.Enums;
using System;
namespace Academy.Service.Services.Interfaces
{
    public interface IStudentService
    {
        public Task<string> CreateAsync(string FullName, int Group, double average, Education Education);
        public Task<string> UpdateAsync(string id,string FullName, int Group, double average, Education Education);
        public Task<string> RemoveAsync(string id);
        public Task<string> GetAsync(string id);
        public Task GetAllAsync();

    }
}
