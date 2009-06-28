using System;
using System.Collections.Generic;

namespace CFlat
{
    public class CompileError
    {
        public CompileError(CompileErrorType type) : this(type, new object[]{})
        {
        }

        public CompileError(CompileErrorType type, IEnumerable<object> data)
        {
            Type = type;
            Data = data;
        }

        public CompileErrorType Type {get; private set;}

        public IEnumerable<Object> Data { get; private set; }
    }
}