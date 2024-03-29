﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Jcf.CursoApiRestFul.Api.Entities
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }  
    }
}
