using SeventhTask.Domain.Entities;

namespace SeventhTask.API.SeventhTask.Application
{
    public interface IMainService
    {
        Teacher[] GetAllTeachersByStudent(string studentName);
    }
}
