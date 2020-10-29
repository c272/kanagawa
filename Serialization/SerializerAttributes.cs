using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kanagawa.Serialization
{
    // A file containing all attributes used for serializing/deserializing popfiles in Kanagawa.

    /// <summary>
    /// Allocates the property a custom name when the popfile is generated/being read from.
    /// </summary>
    public class PopName : Attribute
    {
        public PopName(string name)
        {
            Name = name;
        }

        public string Name;
    }

    /// <summary>
    /// Whether the property value should use quotes (in the popfile).
    /// </summary>
    public class PopUsesQuotes : Attribute { }

    /// <summary>
    /// Expands a List<string> to a list of properties with the same name.
    /// </summary>
    public class PopExpandList : Attribute { }

    /// <summary>
    /// Serializes the given property only given that the function passed returns true.
    /// </summary>
    public class PopSerializeOnCondition : Attribute
    {
        public PopSerializeOnCondition(Func<bool> condition)
        {
            Condition = condition;
        }

        public Func<bool> Condition;
    }
}
