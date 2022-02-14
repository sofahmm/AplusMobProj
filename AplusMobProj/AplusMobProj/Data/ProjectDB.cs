using System;
using System.Collections.Generic;
using SQLite;
using AplusMobProj.Models;

namespace AplusMobProj.Data
{
    public class ProjectDB
    {
        readonly SQLiteConnection db;
        public ProjectDB(string connectionString)
        {
            db = new SQLiteConnection(connectionString);
            db.CreateTable<Project>();
        }
        public IEnumerable<Project> GetProject()
        {
            return db.Table<Project>().ToList();
        }
        public Project GetProject(int id)
        {
            return db.Table<Project>()
                                .Where(i => i.ID == id)
                                .FirstOrDefault();
        }
        public int SaveProject(Project project)
        {
            if(project.ID != 0)
            {
                return db.Update(project);
            }
            else
            {
                return db.Insert(project);
            }
        }
        public int DeleteProject(int id)
        {
            return db.Delete<Project>(id);
        }
    }
}
