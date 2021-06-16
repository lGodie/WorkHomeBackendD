using System;

namespace WorkHomeBackend.Data.Context
{
    public class Routine
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; }

        public int SerieNumber { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}