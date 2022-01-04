using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    public record Item // 'record' is special type of class with support for immutable objects
    {
        public Guid Id { get; init; } // 'init' allows setting the property only during initialization
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}
