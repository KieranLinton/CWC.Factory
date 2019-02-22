using CWC.Domain.Objects.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace CWC.Domain.Objects.Person
{
    public class PersonClaim : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public bool IsActive { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
