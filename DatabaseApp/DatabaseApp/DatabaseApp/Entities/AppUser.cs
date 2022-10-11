using DatabaseApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseApp.Entities
{
    public class AppUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Patient")]
        public int patientId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int AccountType { get; set; }
    }
}
