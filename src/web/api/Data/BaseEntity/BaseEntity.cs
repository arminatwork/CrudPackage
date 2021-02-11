using System;

namespace api.Data.BaseEntity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt{ get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
