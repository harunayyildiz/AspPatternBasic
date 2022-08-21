using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EntityLayer.Conctete
{
    public class TodoItem : IEntity
    {
        [Required]
        [NotNull]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }


    }
}
