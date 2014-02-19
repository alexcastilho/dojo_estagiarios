using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMStags.Business
{
    [Serializable]
    public class MaquinaSaldoInsuficienteException : Exception
    {
        public MaquinaSaldoInsuficienteException() { }
        public MaquinaSaldoInsuficienteException(string message) : base(message) { }
        public MaquinaSaldoInsuficienteException(string message, Exception inner) : base(message, inner) { }
        protected MaquinaSaldoInsuficienteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}