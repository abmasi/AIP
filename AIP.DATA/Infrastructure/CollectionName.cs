using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIP.DATA.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class, Inherited =true)]
    public class CollectionName : Attribute
    {
        public CollectionName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Empty collectionname is not allowed", "value");

            this.Name = value;
        }

        public virtual string Name { get; private set; }
    }
}
