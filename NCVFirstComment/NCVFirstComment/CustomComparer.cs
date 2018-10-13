using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCVFirstComment
{
    public class CustomComparer<T> : IComparer<T>
    {
        private ListSortDirection _Direction;
        private PropertyDescriptor _PropertyDescriptor;


        public CustomComparer(PropertyDescriptor prop, ListSortDirection direction)
        {
            _PropertyDescriptor = prop;
            _Direction = direction;
        }

        public int Compare(T x, T y)
        {
            IComparable value1 = _PropertyDescriptor.GetValue(x) as IComparable;
            IComparable value2 = _PropertyDescriptor.GetValue(y) as IComparable;

            int result;
            if (value1 != null)
            {
                result = value1.CompareTo(value2);
            }
            else if (value2 == null)
            {
                result = 0;
            }
            else
            {
                result = -1;
            }

            return _Direction == ListSortDirection.Ascending ? result : result * -1;
        }
    }
}