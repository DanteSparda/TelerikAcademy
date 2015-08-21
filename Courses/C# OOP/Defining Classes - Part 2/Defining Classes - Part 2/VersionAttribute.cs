namespace Defining_Classes___Part_2
{
    using System;
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]

    public class VersionAttribute : Attribute
    {
        private string version;

        public VersionAttribute(string version)
        {
            this.version = version;
        }
    }
}
