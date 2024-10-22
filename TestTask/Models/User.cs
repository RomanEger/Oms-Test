using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestTask.Models
{
    [Table("fio")]
    public class User
    {
        public int Id { get; set; }
        [Column("fam")]
        public string LastName { get; set; }
        [Column("im")]
        public string FirstName { get; set; }
        [Column("ot")]
        public string Patronymic { get; set; }
        [Column("dr")]
        public DateTime Birthday { get; set; }
    }
}