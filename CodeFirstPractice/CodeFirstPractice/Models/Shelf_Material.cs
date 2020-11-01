using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstPractice.Models
{
    [Table( "shelf_material") ]
    public class Shelf_Material
    {
        public Shelf_Material()
        {
            ShelfList = new HashSet<Shelf>();
        }
        [Key]
        [Column(TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [InverseProperty(nameof(Models.Shelf.ShelfMaterialID))]
        public virtual ICollection<Shelf> ShelfList { get; set; }
        
        [Column(TypeName = "varchar(25)")]
        public string MaterialName { get; set; }

        
       
       
    }
}