using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Oberon_0
{
    class Generator
    {
        public void Open()
        {
            Debug.WriteLine("Generator: Opening");
        }

        public void Header(int size)
        {
            Debug.WriteLine(String.Format("Generator: Header({0})",size));
        }
    }
}
