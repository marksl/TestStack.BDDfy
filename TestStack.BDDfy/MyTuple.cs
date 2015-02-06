using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestStack.BDDfy
{
    public class Tuple<T1, T2, T3>
    {
        private readonly T1 m_Item1;
        private readonly T2 m_Item2;
        private readonly T3 m_Item3;

        public T1 Item1
        {

            get
            {
                return this.m_Item1;
            }
        }

        /// <summary>
        /// Gets the value of the current <see cref="T:System.Tuple`2"/> object's second component.
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current <see cref="T:System.Tuple`2"/> object's second component.
        /// </returns>

        public T2 Item2
        {
            get
            {
                return this.m_Item2;
            }
        }

        public T3 Item3
        {
            get
            {
                return this.m_Item3;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Tuple`2"/> class.
        /// </summary>
        /// <param name="item1">The value of the tuple's first component.</param><param name="item2">The value of the tuple's second component.</param>
        public Tuple(T1 item1, T2 item2, T3 item3)
        {
            this.m_Item1 = item1;
            this.m_Item2 = item2;
            this.m_Item3 = item3;
        }
    }

    public class Tuple<T1, T2>
    {
        private readonly T1 m_Item1;
        private readonly T2 m_Item2;

        public T1 Item1
        {

            get
            {
                return this.m_Item1;
            }
        }

        /// <summary>
        /// Gets the value of the current <see cref="T:System.Tuple`2"/> object's second component.
        /// </summary>
        /// 
        /// <returns>
        /// The value of the current <see cref="T:System.Tuple`2"/> object's second component.
        /// </returns>

        public T2 Item2
        {
            get
            {
                return this.m_Item2;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Tuple`2"/> class.
        /// </summary>
        /// <param name="item1">The value of the tuple's first component.</param><param name="item2">The value of the tuple's second component.</param>
        public Tuple(T1 item1, T2 item2)
        {
            this.m_Item1 = item1;
            this.m_Item2 = item2;
        }
    }
}
