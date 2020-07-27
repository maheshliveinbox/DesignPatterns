using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Client
    {
        public string Result { get; set; }
        public void ClientCode(Creator creator)
        {
            Result = creator.SomeOperation();
        }
    }
}
