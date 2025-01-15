using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMLib
{
	public class Transition<S>
		where S : Enum
	{
		public S FromState { get; private set; }
		public S ToState { get; private set; }

		public Transition(S fromState, S toState)
		{
			FromState = fromState;
			ToState = toState;
		}
	}
}
