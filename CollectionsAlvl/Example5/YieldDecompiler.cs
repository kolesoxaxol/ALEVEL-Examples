﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    internal class Program1
    {
        private static void Main1()
        {
            IEnumerator<int> enumerator = null;
            try
            {
                enumerator = GetOddNumbers().GetEnumerator();
                while (enumerator.MoveNext())
                    Console.WriteLine(enumerator.Current);
            }
            finally
            {
                if (enumerator != null)
                    enumerator.Dispose();
            }
        }

        [IteratorStateMachine(typeof(CompilerGeneratedYield))]
        private static IEnumerable<int> GetOddNumbers()
        {
            return new CompilerGeneratedYield(-2);
        }

        [CompilerGenerated]
        private sealed class CompilerGeneratedYield : IEnumerable<int>,
            IEnumerable, IEnumerator<int>, IDisposable, IEnumerator
        {
            private readonly int _initialThreadId;
            private int _current;
            private int _previous;
            private int _state;

            [DebuggerHidden]
            public CompilerGeneratedYield(int state)
            {
                _state = state;
                _initialThreadId = Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
            {
                CompilerGeneratedYield getOddNumbers;
                if ((_state == -2) && (_initialThreadId == Environment.CurrentManagedThreadId))
                {
                    _state = 0;
                    getOddNumbers = this;
                }
                else
                {
                    getOddNumbers = new CompilerGeneratedYield(0);
                }

                return getOddNumbers;
            }

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<int>)this).GetEnumerator();
            }

            int IEnumerator<int>.Current
            {
                [DebuggerHidden]
                get { return _current; }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get { return _current; }
            }

            [DebuggerHidden]
            void IDisposable.Dispose() { }

            bool IEnumerator.MoveNext()
            {
                switch (_state)
                {
                    case 0:
                        _state = -1;
                        _previous = 0;
                        break;
                    case 1:
                        _state = -1;
                        break;
                    default:
                        return false;
                }

                int num;
                do
                {
                    num = _previous + 1;
                    _previous = num;
                } while (num % 2 == 0);

                _current = _previous;
                _state = 1;

                return true;
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }
        }
    }
}
