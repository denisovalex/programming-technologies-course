using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMLib
{
	public class FSM<S>
		where S : Enum
	{
		private State<S> currentState;
		private readonly Dictionary<S, State<S>> states = new();
		private readonly List<Transition<S>> transitions = new();

		public FSM(S startState, Dictionary<S, State<S>> states, List<Transition<S>> transitions)
		{
			this.states = states;
			this.transitions = transitions;
			this.currentState = GetState(startState);
		}

		public void Start()
		{
			while (currentState != null)
			{
				currentState.Evaulate();
				var trForCurState = transitions.Find(t => t.FromState.Equals(currentState.Name));
				if (trForCurState != null)
				{
					currentState = GetState(trForCurState.ToState);
				}
				else
				{
					throw new Exception("No transition for state.");
				}
			}
		}

		private State<S> GetState(S st)
		{
			if (!states.ContainsKey(st)) return null;
			return states[st];
		}
	}
}
