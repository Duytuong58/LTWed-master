using System;

namespace BigShool1.Models
{
    internal class ApplicationDbContext
    {
        public object Categories { get; internal set; }
        public object Courses { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}