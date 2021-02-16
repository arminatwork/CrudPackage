using System;

namespace Crud.Entity
{
    public interface IEntity
    {

    }
    public interface IEntity<TKey> : IEntity
    {
        TKey Id { get; set; }
    }
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<int>
    {

    }
}