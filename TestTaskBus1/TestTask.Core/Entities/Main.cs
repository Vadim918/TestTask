using System;

namespace TestTask.Core.Entities
{
    public sealed class Main : Entity<Guid>
    {
        public string LongUrl { get; set; }
        public string EditableUrl { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public string GetDateString()
        {
            return Date.ToShortDateString();
        }
    }
}