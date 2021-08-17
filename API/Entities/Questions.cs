using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("infos")]
    public class Questions
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
    }
}