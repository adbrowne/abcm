using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Oberon_0
{
    class Generator
    {
        public GenType curlev;

        public void Open()
        {
            Debug.WriteLine("Generator: Opening");
        }

        public void Header(int size)
        {
            Debug.WriteLine(String.Format("Generator: Header({0})",size));
        }

        public void IncLevel(int i)
        {
            Debug.WriteLine(String.Format("Generator: IncLevel({0})", i));
        }

        public void EnterCmd(string procId)
        {
            Debug.WriteLine(String.Format("Generator: EnterCmd({0})", procId));
        }

        public void Enter(long locblksize)
        {
            Debug.WriteLine(String.Format("Generator: Enter({0})", locblksize));
        }

        public void Return(long l)
        {
            Debug.WriteLine(String.Format("Generator: Return({0})", l));
        }
    }
}
