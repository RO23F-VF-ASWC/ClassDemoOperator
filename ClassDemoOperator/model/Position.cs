using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoOperator.model
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position():this(0,0)
        {
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   X == position.X &&
                   Y == position.Y;
        }

        /*
         * overload operators
         */
        public static bool operator ==(Position left, Position right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        public static Position operator +(Position left, Position right)
        {
            return new Position(left.X + right.X, left.Y + right.Y);
        }

        public static Position operator +(Position left, int val)
        {
            return new Position(left.X + val, left.Y + val);
        }

        public static Position operator +(int val, Position right)
        {
            return right + val;
        }
    }
}
