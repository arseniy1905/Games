using System;

namespace Games.DataModel.DataAttribute
{
    public class NoMappingFromAttribute : Attribute
    {
        private readonly string sourceModelName;
        public NoMappingFromAttribute(string sourceModelName)
        {
            this.sourceModelName = sourceModelName;
        }

        public virtual string SourceModelName
        {
            get { return sourceModelName; }
        }
    }
}
