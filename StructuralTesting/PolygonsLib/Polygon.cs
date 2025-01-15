using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonsLib
{
	public class Polygon
	{
		private Segment[] sides;

		// Polygon constructor by vertex list in the order of clockwise
		// traversal
		public Polygon(List<Point> vertices) 
		{
			var n = vertices.Count;
			sides = new Segment[n];

			for (int i = 0; i < n - 1; i++)
			{
				sides[i] = new Segment(vertices[i], vertices[i + 1]);
			}
			sides[n - 1] = new Segment(vertices[n - 1], vertices[0]);
		}

		// The main method of the task that returns true if polygon is 
		// self-intersecting and false otherwise
		public bool IsSelfIntersecting()
		{
			for (int i = 0; i < sides.Length - 1; i++)
			{
				for (int j = i + 1; j < sides.Length; j++)
				{
					if (sides[i].Intersect(sides[j]))
						return true;
				}
			}

			return false;
		}
	}
}
