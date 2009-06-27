using System;
using System.Collections.Generic;
using System.Linq;
using CFlat;

namespace CFlat.Tree
{
    public class Method
    {
        public string Name { get; private set; }

        public Method(string name, Types returnType)
        {
            Name = name;
            ReturnType = returnType;
            Statements = new List<Statement>();
            Arguments = new List<Argument>();
            Variables = new List<DeclarationStatement>();
        }

        public List<Statement> Statements { get; private set; }

        public Types ReturnType
        {
            get; private set;
        }

        public List<Argument> Arguments { get; private set; }

        public List<DeclarationStatement> Variables { get; private set; }


        public void Compile(CompilerContext context)
        {
            context.CodeGenerator.BeginMethod(Name);

            foreach (var statement in Statements)
            {
                statement.Compile(context);
            }

            context.CodeGenerator.EndMethod();
        }

        public void Register(CompilerContext context)
        {
            var parameters = (from p in Arguments
                              select new Parameter(p.Type, p.Name)).ToArray();

            context.CodeGenerator.RegisterMethod(Name, ReturnType, parameters);
        }

        public Types GetVariableType(string name)
        {
            var argument = Arguments.Where(p => p.Name == name).SingleOrDefault();

            if(argument != null)
                return argument.Type;

            return Variables.Where(p => p.VariableName == name).Single().Type;
        }
    }
}