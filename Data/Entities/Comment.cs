using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAtUtc { get; set; }
    }
}
