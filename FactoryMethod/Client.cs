using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Client
    {
        public string Result { get; private set; }
        public void ClientCode(Creator creator)
        {
            Result = creator.SomeOperation();
        }
    }
}
