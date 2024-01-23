using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using first_app.Models;

namespace StudentSevice
{
    public interface ISStudentService
    {
        void Save(StudentEntity entity);
        void Remove(StudentEntity entity);
        IQueryable <StudentEntity> ListAll();
        StudentEntity GetById(int id);
        // void Save();
    }
}