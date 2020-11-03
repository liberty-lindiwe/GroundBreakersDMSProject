using GradeBookConsoleApp.Data;
using System.Collections.Generic;

namespace DBMS.Data
{
    public interface IDMSRepository
    {
        IEnumerable<Faculty> GetFaculties();
        IEnumerable<Faculty> GetFacultyById(int id);
        bool saveAllChanges();
    }
}