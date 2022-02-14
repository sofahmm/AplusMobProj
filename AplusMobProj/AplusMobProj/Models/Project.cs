using SQLite;

namespace AplusMobProj.Models
{
    [Table("Projects")]
    public class Project
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }
        [Unique]
        public string NameProject { get; set; }
        public string Description { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
