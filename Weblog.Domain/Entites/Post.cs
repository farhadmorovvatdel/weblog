using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weblog.Domain.Entites
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public string Author { get; set; }
        public string ?Image { get; set; }
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;

        public DateTime? UpdatedDate { get; set; }
        public Category Category { get; set; }
    }
}
