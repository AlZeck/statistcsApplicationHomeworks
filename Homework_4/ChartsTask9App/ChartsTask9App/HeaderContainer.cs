using System;

namespace ChartsTask9App
{
    public class HeaderContainer
    {
        public string HeaderName;
        public Type Type;

        public HeaderContainer(string headerName, Type type)
        {
            HeaderName = headerName;
            Type = type; 
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("{0}[{1}]",HeaderName,Type.Name);
        }
    }
}
