using System;

namespace WorkHomeBackend.Data.Context
{
    public class Training
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Description { get; set; }

        public Guid? IdRoutine { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}