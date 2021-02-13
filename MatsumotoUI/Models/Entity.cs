using System;

namespace MatsumotoUI.Models
{
    public class Entity
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }

        public Entity()
        {
            Id = new Guid();
        }
    }
}
