using System;
using System.Text;
using Castle.Core.Interceptor;

namespace Decaf.Tests
{
    internal class ConsoleInterceptor : IInterceptor
    {
        private readonly StringBuilder output;

        public ConsoleInterceptor(StringBuilder output)
        {
            this.output = output;
        }

        public void Intercept(IInvocation invocation)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}(", invocation.Method.Name);

            var parameters = invocation.Method.GetParameters();
            
            for(int x =0; x< parameters.Length; x++)
            {
                if (x > 0) 
                    sb.Append(",");

                sb.AppendFormat("{0}={1}", parameters[x].Name, invocation.Arguments[x]);
            }
            
            sb.Append(")");

            var outputString = sb.ToString();
            output.AppendLine(outputString);
            Console.WriteLine(outputString);
        }
    }
}