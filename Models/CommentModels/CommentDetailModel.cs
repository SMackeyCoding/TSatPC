using Data;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CommentModels
{
    public class CommentDetailModel
    {
        [ForeignKey("ApplicationUser")]
        public string Name { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAtUtc { get; set; }
    }
}
