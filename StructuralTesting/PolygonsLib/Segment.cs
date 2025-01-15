﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace PolygonsLib
{
	public class Segment
	{
		public Point A {  get; set; }
		public Point B { get; set; }

		public Segment(Point a, Point b) 
		{
			A = a;
			B = b;
		}

		// Method that returns true if line segment 'p1q1' (this)
		// and 'p2q2' (other) intersect.
		public bool Intersect(Segment other) 
		{
			var p1 = this.A;
			var q1 = this.B;
			var p2 = other.A;
			var q2 = other.B;
			
			// Find the four orientations needed for general and 
			// special cases 
			int o1 = GetOrientation(p1, q1, p2);
			int o2 = GetOrientation(p1, q1, q2);
			int o3 = GetOrientation(p2, q2, p1);
			int o4 = GetOrientation(p2, q2, q1);

			// General case 
			if (o1 != o2 && o3 != o4)
				return true;

			// Special Cases 
			// p1, q1 and p2 are collinear and p2 lies on segment p1q1 
			if (o1 == 0 && onSegment(p1, p2, q1)) return true;

			// p1, q1 and q2 are collinear and q2 lies on segment p1q1 
			if (o2 == 0 && onSegment(p1, q2, q1)) return true;

			// p2, q2 and p1 are collinear and p1 lies on segment p2q2 
			if (o3 == 0 && onSegment(p2, p1, q2)) return true;

			// p2, q2 and q1 are collinear and q1 lies on segment p2q2 
			if (o4 == 0 && onSegment(p2, q1, q2)) return true;

			return false; // Doesn't fall in any of the above cases 
		}

		// To find orientation of ordered triplet (p, q, r). 
		// The function returns following values 
		// 0 --> p, q and r are collinear 
		// 1 --> Clockwise 
		// 2 --> Counterclockwise 
		private static int GetOrientation(Point p, Point q, Point r)
		{
			var val = (q.Y - p.Y) * (r.X - q.X) -
			(q.X - p.X) * (r.Y - q.Y);

			if (val == 0) return 0; // collinear 

			return (val > 0) ? 1 : 2; // clock or counterclock wise 
		}

		// Given three collinear points p, q, r, the function checks if 
		// point q lies on line segment 'pr' 
		private static bool onSegment(Point p, Point q, Point r)
		{
			if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) && 
				q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
				return true;

			return false;
		}
	}
}
