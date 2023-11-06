using Academy.Core.Enums;
using Academy.Core.Models;
using Academy.Core.Repositories;
using Academy.Data.Repositores;
using Academy.Service.Services.Interfaces;

using System;

namespace Academy.Service.Services.Implementations
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository = new StudentRepository();

            public async Task<string> CreateAsync(string FullName, int Group, double average, Education Education)
        {
            if (string.IsNullOrWhiteSpace(FullName))
                return "FullName can not be empty";

            if (string.IsNullOrWhiteSpace(FullName))
                return "Group can not be empty";

            if (average <= 0) 
            return "average can not be lest than 0 ";

            //if (Education >= Education || Education < 0)
            //    return "Education can not be lest than 0 and equal Education";

            Student student = new Student(FullName, Group, average, Education);

            await _studentRepository.AddAsync(student);

            return "SuccessFully created";

        }

        public async Task GetAllAsync()
        {
            List<Student> students = await _studentRepository.GetAllAsync();

            foreach (Student student in students)
            {
                Console.WriteLine($"ID:{student.Id} FullName:{student.FullName} Group: {student.Group} Average: {student.Average} Education:{student.Education} CreatedAt:{student.CreatedAt} UpdatedAt:{student.UpdatedAt}");
            }
        }

        public async Task<string> GetAsync(string id)
        {
            Student student = await _studentRepository.GetAsync(x => x.Id == id);

            if (student == null)
                return "Student not found";

            Console.WriteLine($"ID:{student.Id} FullName:{student.FullName} Group: {student.Group} Average: {student.Average} Education:{student.Education} CreatedAt:{student.CreatedAt} UpdatedAt:{student.UpdatedAt}");
            return "success";
        }

      

        public async Task<string> RemoveAsync(string id)
        {
            Student student = await _studentRepository.GetAsync(x => x.Id == id);

            if (student == null)
                return "Student not found";

            await _studentRepository.RemoveAsync(student);

            return " Removed Successfully";
        }

        public async Task<string> UpdateAsync(string id, string FullName, int Group, double average, Education Education)
        {
            Student student = await _studentRepository.GetAsync(x => x.Id == id);

            if (student == null)
                return "Student not found";



            if (string.IsNullOrWhiteSpace(FullName))
                return "FullName can not be empty";

            if (string.IsNullOrWhiteSpace(FullName))
                return "Group can not be empty";

            if (average <= 0) 
            return "average can not be lest than 0 ";

            //if (Education >= Education || Education < 0)
            //    return "Education can not be lest than 0 and equal Education";

            student.FullName = FullName;
            student.Group = Group;  
            student.Average = average;  
            student.Education = Education;
            student.UpdatedAt = DateTime.UtcNow.AddHours(4);


            return "Updated successfully";
        }
    }

    }

