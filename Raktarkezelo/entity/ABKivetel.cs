using System;
using System.Runtime.Serialization;

namespace Raktarkezelo.control
{
    [Serializable]
    internal class ABKivetel : Exception
    {
        public ABKivetel(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}