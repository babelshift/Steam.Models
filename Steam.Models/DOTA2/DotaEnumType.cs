using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam.Models.DOTA2
{
    public abstract class DotaEnumType
    {
        protected readonly string key;
        protected readonly string displayName;
        protected readonly string description;

        public DotaEnumType(string key, string displayName, string description)
        {
            this.key = key;
            this.displayName = displayName;
            this.description = description;
        }

        public string Key { get { return key; } }

        public override string ToString()
        {
            return displayName;
        }
    }
}
