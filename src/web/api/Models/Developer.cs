using Crud.Entity;

namespace api.Models
{
    public class Developer : BaseEntity
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Follower { get; set; }


    }
}