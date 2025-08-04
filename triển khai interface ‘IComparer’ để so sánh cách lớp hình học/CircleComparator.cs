using System.Collections.Generic;

namespace Shape
{
    public class CircleComparator : IComparer<Circle>
    {
        public int Compare(Circle? c1, Circle? c2)
        {
            if (c1 == null && c2 == null) return 0;
            if (c1 == null) return -1;
            if (c2 == null) return 1;

            return c1.getRadius().CompareTo(c2.getRadius());
        }

    }
}
