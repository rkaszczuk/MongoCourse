using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCSSample.Models
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
