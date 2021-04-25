using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BezierVector;

namespace BezierFormula
{
    public class Bezier
    {
        public Vector p0;
        public Vector p1;
        public Vector p2;
        public Vector p3;
        public float x1;
        public float y1;

        public Vector BezierFormula(Vector p0, Vector p1, Vector p2, Vector p3, float t)
        {
            float tt = t * t;
            float ttt = t * tt;
            float u = 1.0f - t;
            float uu = u * u;
            float uuu = u * uu;

            x1 = uuu * p0.x;
            y1 = uuu * p0.y;
            x1 = x1 + (3.0f * uu * t * p1.x);
            y1 = y1 + (3.0f * uu * t * p1.y);
            x1 = x1 + (3.0f * u * tt * p2.x);
            y1 = y1 + (3.0f * u * tt * p2.y);
            x1 = x1 + (ttt * p3.x);
            y1 = y1 + (ttt * p3.y);
            Vector B = new Vector(x1, y1);
            return B;
        }
    }
}