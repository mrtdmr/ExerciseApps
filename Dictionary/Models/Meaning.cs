using System.ComponentModel.DataAnnotations.Schema;

namespace Dictionary.Models
{
    [Table(name:"Meaning")]
    public class Meaning
    {
        public int Id { get; set; }
        public string TurkishMeaning { get; set; }
        public string EnglishMeaning { get; set; }
        public int WordId { get; set; }
        public virtual Word WordName { get; set; }
    }
}
