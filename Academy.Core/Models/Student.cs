using Academy.Core.Enums;
using Academy.Core.Models.BaseModels;
using System;
namespace Academy.Core.Models
{
    internal class Student : BaseModel
    {
        static int _id;
        public string FullName { get; set; }    
        public int Group {  get; set; }  
        public double Average {  get; set; }    
        public Education Education { get; set; }

        public Student (string FullName,int Group,double Average,Education Education)
        {
            _id++;

            //string EducationName = Education.ToString();
            Id = $"{Education.ToString()[0]-_id}";
            FullName = FullName;
            Group = Group;
            Average = Average;
            Education = Education;
        }
    }
}
