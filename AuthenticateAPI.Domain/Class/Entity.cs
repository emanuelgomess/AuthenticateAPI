using AuthenticateAPI.Domain.Helpers;
using System;

namespace AuthenticateAPI.Domain.Class
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTimeHelper.GetBrazilianDateTime();
        }

        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? BlockedDate { get; set; }

    }
}
