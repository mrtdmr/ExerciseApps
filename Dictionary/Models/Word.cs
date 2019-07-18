using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dictionary.Models
{
    [Table(name: "Word")]
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Meaning> Meanings { get; set; }
    }
}
