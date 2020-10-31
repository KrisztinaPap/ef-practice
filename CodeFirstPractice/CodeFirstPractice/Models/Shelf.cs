using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstPractice.Models
{
    [Table("shelf")]
    public class Shelf
    {
        [Key]
        [Column(TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        
        [Column(TypeName = "int(10)")]
        public int ShelfMaterialID { get; set; }
        
        [ForeignKey(nameof(ShelfMaterialID))]
        [InverseProperty(nameof(Models.Shelf_Material.ID))]
        public virtual Shelf_Material ShelfMaterial { get; set; }
    }
}