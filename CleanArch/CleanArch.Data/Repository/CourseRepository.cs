using CleanArch.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Data.Repository
{
    class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCousres()
        {
            return _context.Courses;
        }
    }
}
