using GradeBookConsoleApp.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.Data
{
    public class DMSRepository : IDMSRepository
    {
        private readonly DMSContext ctx;
        private readonly ILogger<DMSRepository> logger;

        public DMSRepository(DMSContext ctx, ILogger<DMSRepository> logger)
        {
            this.ctx = ctx;
            this.logger = logger;
        }


        public IEnumerable<Faculty> GetFaculties()
        {

            try
            {
                logger.LogInformation("all faculties loaded");

                return ctx.Faculty.ToList();
            }
            catch (Exception ex)
            {

                logger.LogError($"error {ex}");
                throw ex;

            }


        }

        public IEnumerable<Faculty> GetFacultyById(int id)
        {

            try
            {
                logger.LogInformation("all faculties loaded");

                var results = ctx.Faculty
                               .Where(f => f.ID == id)
                               .ToList();

                return results;
            }
            catch (Exception ex)
            {

                logger.LogError($"error {ex}");
                throw ex;

            }

        }

        public bool saveAllChanges()
        {
            return ctx.SaveChanges() > 0;
        }
    }
}
