using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AplusMobProj.Models;
using System.Threading.Tasks;

namespace AplusMobProj.Data
{
    public class ProjectDB
    {
        readonly SQLiteAsyncConnection db;
        public ProjectDB(string connectionString)
        {
            db = new SQLiteAsyncConnection(connectionString);
            db.CreateTableAsync<Project>().Wait();
        }
        public Task<List<Project>> GetProjectAsync()
        {
            return db.Table<Project>().ToListAsync();
        }
        public Task<Project> GetProjectAsync(int id)
        {
            return db.Table<Project>()
                                .Where(i => i.ID == id)
                                .FirstOrDefaultAsync();
        }
        public Task<int> SaveProjectAsync(Project project)
        {
            if(project.ID != 0)
            {
                return db.UpdateAsync(project);
            }
            else
            {
                return db.InsertAsync(project);
            }
        }
        public Task<int> DeleteProjectAsync(Project project)
        {
            return db.DeleteAsync(project);
        }
    }
}
