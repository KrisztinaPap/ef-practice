using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstPractice.Models
{
    [Table("shelf_material")]
    public class Shelf_Material
    {
     
        [Key]
        [Column(TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Column(TypeName = "varchar(25)")]
        public string MaterialName { get; set; }
        
        [InverseProperty(nameof(Models.Shelf.ID))]
        public virtual Shelf Shelf { get; set; }
        
    }
}