using System;
using CFlat.Tree;

namespace CFlat.Tree
{
    public class TreeBuilder : ITreeBuilder
    {
        public IntegerExpression IntegerExpression(string value)
        {
            return new IntegerExpression(value);
        }

        public AdditionExpression AdditionExpression(Expression expr1, Expression expr2)
        {
            return new AdditionExpression(expr1, expr2);
        }

        public Class Class(string name)
        {
            return new Class(name);
        }

        public Method Method(string name, string returnTypeName)
        {
            return new Method(name, GetTypeFromName(returnTypeName));
        }

        public Statement Statement(Expression e)
        {
            return new Statement(e);
        }

        public Expression SubtractionExpression(Expression expr1, Expression expr2)
        {
            return new SubtractionExpression(expr1, expr2);
        }

        public Expression MultiplicationExpression(Expression expr1, Expression expr2)
        {
            return new MultiplicationExpression(expr1, expr2);
        }

        public Expression DivisionExpression(Expression expr1, Expression expr2)
        {
            return new DivisionExpression(expr1, expr2);
        }

        public Expression RemainderExpression(Expression expr1, Expression expr2)
        {
            return new RemainderExpression(expr1, expr2);
        }

        public Expression CharExpression(string value)
        {
            return new CharExpression(value);
        }

        public Expression StringExpression(string value)
        {
            return new StringExpression(value);
        }

        public Expression IdExpression(string name)
        {
            return new IdExpression(name);
        }

        public Expression BooleanExpression(string value)
        {
            return new BooleanExpression(value);
        }

        public Statement DeclarationStatement(string typeName, string name, Expression expression)
        {
            return new DeclarationStatement(GetTypeFromName(typeName), name, expression);
        }

        public Statement ReturnStatement(Expression expression)
        {
            return new ReturnStatement(expression);
        }

        public Statement IfStatement(Expression expression)
        {
            return new IfStatement(expression);
        }

        public Types GetTypeFromName(string typeName)
        {
            switch (typeName)
            {
                case "int":
                    return Types.Int;
                case "string":
                    return Types.String;
                case "char":
                    return Types.Char;
                case "bool":
                    return Types.Bool;
                case "void":
                    return Types.Void;
                default:
                    throw new ArgumentException("Unknown type: " + typeName);
            }
        }
    }
}