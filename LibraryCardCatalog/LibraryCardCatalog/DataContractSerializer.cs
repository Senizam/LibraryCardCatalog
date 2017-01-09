using System;
using System.IO;

namespace Library
{
    internal class DataContractSerializer
    {
        private Type type;

        public DataContractSerializer(Type type)
        {
            this.type = type;
        }

        internal void WriteObject(FileStream writer, object mainCatalog)
        {
            throw new NotImplementedException();
        }
    }
}