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
            db.CreateTableAsync<Project>();
        }
        public IEnumerable<Project> GetProjectAsync()
        {
            return db.Table<Project>().ToList();
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
        public Task<int> DeleteProjectAsync(int id)
        {
            return db.DeleteAsync<Project>(id);
        }
    }
}
