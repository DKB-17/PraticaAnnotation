using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PraticaAnnotation.Models
{
    [Table("Cursos")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto incremento do campo
        public int id { get; set; }
        [StringLength(50)]
        [Display(Name = "Nome do curso:")]
        public String descricao { get; set; }

    }
}
