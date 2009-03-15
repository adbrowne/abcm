using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;

namespace Oberon_0
{
    class Generator
    {
        ILGen ilGen;
        TypeBuilder currentType;
        MethodBuilder currentMethodBuilder;
            
        public Generator(string outputFileName)
        {
            ilGen = new ILGen(outputFileName);
        }

        public OsgClassMode curlev;

        public void Open(string modId)
        {
            currentType = ilGen.StartModule(modId);
            Debug.WriteLine(string.Format("Generator: Open({0})", modId));
        }

        public void Header(int size)
        {
            Debug.WriteLine(String.Format("Generator: Header({0})",size));
        }

        public void IncLevel(int i, string procId)
        {
            Debug.WriteLine(String.Format("Generator: IncLevel({0},{1})", i, procId));
           
            if(i > 0)
                currentMethodBuilder = currentType.DefineMethod(procId, MethodAttributes.Static, typeof(void), System.Type.EmptyTypes);

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
            var methodIlGen = currentMethodBuilder.GetILGenerator();
            methodIlGen.Emit(OpCodes.Ret);
        }

        public OsgItem MakeItem(OsgObject y)
        {
            var x = new OsgItem();
            x.mode = y.@class;
            x.type = y.type;
            x.lev = y.lev;
            x.a = y.val;
            x.b = 0;
            x.osgObject = y;
            // TODO: Work out x.r

            if(y.@class == OsgClassMode.Par)
            {
                x.mode = OsgClassMode.Var;
                x.a = 0;
            }

            Debug.WriteLine(String.Format("Generator: MakeItem({0})", y.name));
            return x;
        }

        public void Call(OsgItem x)
        {
            if(x.mode == OsgClassMode.Proc)
            {
                var methodIlGen = currentMethodBuilder.GetILGenerator();
                x.osgObject.ILGen(methodIlGen);
                //methodIlGen.Emit(OpCodes.Call, x.osgObject.MethodBuilder);
            }
            Debug.WriteLine(String.Format("Call: Call({0})", x.type));
        }

        public void Complete()
        {
            Debug.WriteLine("Complete()");
            currentType.CreateType();
            ilGen.Save();
        }

        public void AddMethod(OsgObject proc)
        {
            var methodBuilder = currentType.DefineMethod(proc.name, MethodAttributes.Static, typeof(void), System.Type.EmptyTypes);
            var ilGenerator = methodBuilder.GetILGenerator();
            proc.ILGen(ilGenerator);
            ilGenerator.Emit(OpCodes.Ret);
            proc.MethodBuilder = methodBuilder;
        }

        public void Parameter(OsgItem x, TypeDesc type, OsgClassMode @class)
        {
            throw new NotImplementedException();
        }
    }
}
