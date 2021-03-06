﻿using System;
using System.Linq;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using CFlat.CodeGen.Clr;
using NUnit.Framework;

namespace CFlat.Tests.Integration
{
    [TestFixture]
    public class TypeTests
    {
        [Test]
        public void ExpectingBooleanExpression()
        {
            var input = "public class Test { public int TestMethod(){ bool a = 9; }}";
            var output = GetErrors(input);

            Assert.AreEqual(CompileErrorType.TypeMismatch, output[0].Type);
        }

        [Test]
        public void ExpectingBooleanInIfStatement()
        {
            var input = "public class Test { public int TestMethod(){ if(9){ return 1;} return 2; }}";
            var output = GetErrors(input);

            Assert.AreEqual(CompileErrorType.TypeMismatch, output[0].Type);    
        }

        [Test]
        public void CannotApplyOperatorToIncompatibleArgumentsWithAdditionOperator()
        {
            var input = @"
public class Test { 
    public int TestMethod(int a, bool b){ 
        return a + b;
    }
}";
            var error = GetErrors(input)[0];

            Assert.AreEqual(CompileErrorType.CannotApplyOperator, error.Type);

            var dataItems = error.Data.ToArray();

            Assert.AreEqual(Operator.Add, dataItems[0]);
            Assert.AreEqual(Types.Int, dataItems[1]);
            Assert.AreEqual(Types.Bool, dataItems[2]);
        }

        [Test]
        public void CannotApplyOperatorToIncompatibleArgumentsWithMutliplicationOperator()
        {
            var input = @"
public class Test { 
    public int TestMethod(int a){ 
        return a * ""b"";
    }
}";
            var error = GetErrors(input)[0];

            Assert.AreEqual(CompileErrorType.CannotApplyOperator, error.Type);

            var dataItems = error.Data.ToArray();

            Assert.AreEqual(Operator.Multiply, dataItems[0]);
            Assert.AreEqual(Types.Int, dataItems[1]);
            Assert.AreEqual(Types.String, dataItems[2]);
        }

        [Test]
        public void CannotApplyOperatorToIncompatibleArgumentsWithRemainderOperator()
        {
            var input = @"
public class Test { 
    public int TestMethod(int a){ 
        return a % 'b';
    }
}";
            var error = GetErrors(input)[0];

            Assert.AreEqual(CompileErrorType.CannotApplyOperator, error.Type);

            var dataItems = error.Data.ToArray();

            Assert.AreEqual(Operator.Mod, dataItems[0]);
            Assert.AreEqual(Types.Int, dataItems[1]);
            Assert.AreEqual(Types.Char, dataItems[2]);
        }

        [Test]
        public void CannotApplyOperatorToIncompatibleArgumentsWithDivisionOperator()
        {
            var input = @"
public class Test { 
    public int TestMethod(int a, bool b){ 
        return a / b;
    }
}";
            var error = GetErrors(input)[0];

            Assert.AreEqual(CompileErrorType.CannotApplyOperator, error.Type);

            var dataItems = error.Data.ToArray();

            Assert.AreEqual(Operator.Divide, dataItems[0]);
            Assert.AreEqual(Types.Int, dataItems[1]);
            Assert.AreEqual(Types.Bool, dataItems[2]);
        }

        private ErrorSet GetErrors(string input)
        {
            var errorSet = new ErrorSet();
            var parser = CreateParser(input, errorSet);
            var @class = parser.prog();
            @class.Compile(new CompilerContext(new ClrCodeGenerator("TestOut"), errorSet));
            return errorSet;
        }

        private CFlatTree CreateParser(string input, ErrorSet errorSet)
        {
            var antlrStringStream = new ANTLRStringStream(input);
            var lexter = new CFlatLexer(antlrStringStream);
            var tokens = new CommonTokenStream(lexter);
            var parser = new CFlatParser(tokens);

            var tree = parser.prog().Tree;

            var nodes = new CommonTreeNodeStream(tree);
            var walker = new CFlatTree(nodes, errorSet);
            
            return walker;
        }
    }
}