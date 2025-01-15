using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMLib
{
	public class State<S> where S : Enum
	{
		public S Name { get; private set; }
		private Action Work { get; set; }

		public State(S name, Action work) 
		{
			Name = name;
			Work = work;
		}

		public void Evaulate()
		{
			Work.Invoke();
		}
	}
}
