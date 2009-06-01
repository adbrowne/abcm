using System.Collections.Generic;

namespace Decaf.Tree
{
    public class Class : ITreeNode
    {
        public string Name { get; private set; }
        private Dictionary<string, Method> methodList = new Dictionary<string, Method>();

        public Class(string name)
        {
            Name = name;
        }

        public void AddMethod(Method method)
        {
            methodList.Add(method.Name, method);
        }

        public Method this[string methodName]
        {
            get { return methodList[methodName]; }
        }

        public void Compile(ErrorSet errorSet)
        {
            foreach (var method in methodList)
            {
                method.Value.Compile(errorSet);
            }
        }
    }
}
