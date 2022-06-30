using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Results.Fluent
{
    public abstract class Enumeration : IEquatable<Enumeration?>
    {
        public string Name { get; private set; }

        public int Id { get; private set; }

        protected Enumeration(int id, string name) => (Id, Name) = (id, name);

        public override string ToString() => Name;

        public override bool Equals(object? obj)
        {
            return Equals(obj as Enumeration);
        }

        public bool Equals(Enumeration? other)
        {
            return other != null &&
                   Name == other.Name &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            var hashCode = 1460282102;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }
    }
}
