using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCVFirstComment
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private ListSortDirection _Direction;
        private PropertyDescriptor _PropertyDescriptor;
        private bool _IsSorted = false;


        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _IsSorted;
        protected override ListSortDirection SortDirectionCore => _Direction;
        protected override PropertyDescriptor SortPropertyCore => _PropertyDescriptor;


        public SortableBindingList() : base() { }
        public SortableBindingList(List<T> list) : base(list) { }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            List<T> items = Items as List<T>;

            if (items != null)
            {
                CustomComparer<T> customComparer = new CustomComparer<T>(prop, direction);
                items.Sort(customComparer);
                _IsSorted = true;
            }
            else
            {
                _IsSorted = false;
            }

            _Direction = direction;
            _PropertyDescriptor = prop;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }
    }
}