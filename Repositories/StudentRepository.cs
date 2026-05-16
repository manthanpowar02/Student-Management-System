using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;
        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context.Students
                .Where(s => s.IsActive)
                .Include(s => s.Enrollments)
                .ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _context.Students
                .Include(s => s.Enrollments)
                .FirstOrDefaultAsync(s => s.Id == id && s.IsActive);
        }

        public async Task<Student> CreateAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student?> UpdateAsync(int id, Student student)
        {
            var existing = await _context.Students.FindAsync(id);
            if (existing == null) return null;
            existing.FirstName = student.FirstName;
            existing.LastName = student.LastName;
            existing.Email = student.Email;
            existing.PhoneNumber = student.PhoneNumber;
            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return false;
            student.IsActive = false; // Soft delete
            await _context.SaveChangesAsync();
            return true;
        }
    }
}