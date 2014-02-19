using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMStags.Business
{
    [Serializable]
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() { }
        public SaldoInsuficienteException(string message) : base(message) { }
        public SaldoInsuficienteException(string message, Exception inner) : base(message, inner) { }
        protected SaldoInsuficienteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}