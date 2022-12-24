using System;
using System.Threading;

namespace Utils
{
    public static class TypeIndex<T>
    {
        public static Type Type  { get; }
        public static int  Index { get; }

        static TypeIndex()
        {
            Type  = typeof(T);
            Index = Interlocked.Increment(ref IndexIncrement.Index);
        }
    }

    public static class IndexIncrement
    {
        public static int Index;
    }
}