using System;

namespace API.Entities
{
    public class Infos
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
    }
}