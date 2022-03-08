using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsTalk.Domain.Entities
{
    public class Entity
    {
        public string Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public bool IsDeleted { get; set; } = false;

        public Entity()
        {
            Id = Guid.NewGuid().ToString("N");
            CreateTime = DateTime.Now;
        }
    }
}
