using System;
using AprenderIA.Domain.Entities;
namespace AprenderIA.Domain.IRepositorys;

public interface ITeacherStudenRepository
{
    //todos los estudiantes de un profesor
Task <ICollection<TeacherStudent>> GetStudentsByTeacherIdAsync(Guid teacherId, CancellationToken ct=default);
//todos los profesores de un estudiante
Task <ICollection<TeacherStudent>> GetTeacherByStudentsIdAsync(Guid studentId, CancellationToken ct=default);
//preguntamos si existe el vinculo o relacion del profesor con el estudiante, para evitar duplicados
Task<bool> ExistAsync(Guid teacherId, Guid studentId, CancellationToken ct=default);


//create,update,delete
Task CreateTeacherStudentAsync(TeacherStudent teacherStudent, CancellationToken ct=default);
Task UpdateTeacherStudentAsync(TeacherStudent teacherStudent, CancellationToken ct=default);
Task DeleteTeacherStudentAsync(TeacherStudent teacherStudent, CancellationToken ct=default);

}
