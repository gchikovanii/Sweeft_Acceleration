using Microsoft.EntityFrameworkCore;
using SeventhTask.Domain.Entities;
using SeventhTask.infrastucture.DataContext;
using System.Numerics;

namespace SeventhTask.API.SeventhTask.Application
{
    public class MainService : IMainService
    {
        private readonly ApplicationDbContext _dbContext;

        public MainService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  Teacher[] GetAllTeachersByStudent(string studentName)
        {
            var result = _dbContext.Set<Teacher>().Where(i => i.Pupils.Any(i => i.FirstName == studentName)).ToList();
            return result.ToArray();
        }
    }
}
