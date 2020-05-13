using Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CommentModels
{
    public class CommentUpdateModel
    {
        public string Text { get; set; }
        public DateTime CreatedAtUtc { get; set; }
    }
}
