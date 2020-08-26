using System;
using System.Collections.Generic;
using System.Text;

namespace MongoNetCoreSample.Models
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
