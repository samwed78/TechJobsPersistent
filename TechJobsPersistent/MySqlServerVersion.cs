using System;

namespace TechJobsPersistent
{
    internal class MySqlServerVersion
    {
        private Version version;

        public MySqlServerVersion(Version version)
        {
            this.version = version;
        }

        public MySqlServerVersion(int v, Version version)
        {
            this.version = version;
        }
    }
}