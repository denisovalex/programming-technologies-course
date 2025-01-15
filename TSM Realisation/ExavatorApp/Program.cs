using FSMLib;

namespace ExavatorApp
{
	class Program
	{
		static void Main()
		{
			var states = CreateStates();
			var transitions = CreateTransitions();

			var fsm = new FSM<ExcavatorStates>(ExcavatorStates.LowerBoom, states, transitions);

			fsm.Start();
		}

		private static Dictionary<ExcavatorStates, State<ExcavatorStates>> CreateStates()
		{
			var states = new Dictionary<ExcavatorStates, State<ExcavatorStates>>();

			states.Add(ExcavatorStates.LowerBoom, new State<ExcavatorStates>(ExcavatorStates.LowerBoom, () => ImitateExavatorActions(ExcavatorStates.LowerBoom)));
			states.Add(ExcavatorStates.FillingBucket, new State<ExcavatorStates>(ExcavatorStates.FillingBucket, () => ImitateExavatorActions(ExcavatorStates.FillingBucket)));
			states.Add(ExcavatorStates.LiftBoom, new State<ExcavatorStates>(ExcavatorStates.LiftBoom, () => ImitateExavatorActions(ExcavatorStates.LiftBoom)));
			states.Add(ExcavatorStates.Rotation, new State<ExcavatorStates>(ExcavatorStates.Rotation, () => ImitateExavatorActions(ExcavatorStates.Rotation)));
			states.Add(ExcavatorStates.EmptyingBucket, new State<ExcavatorStates>(ExcavatorStates.EmptyingBucket, () => ImitateExavatorActions(ExcavatorStates.EmptyingBucket)));
			states.Add(ExcavatorStates.Moving, new State<ExcavatorStates>(ExcavatorStates.Moving, () => ImitateExavatorActions(ExcavatorStates.Moving)));
			states.Add(ExcavatorStates.EndState, new State<ExcavatorStates>(ExcavatorStates.EndState, () => ImitateExavatorActions(ExcavatorStates.EndState)));

			return states;
		}

		private static List<Transition<ExcavatorStates>> CreateTransitions()
		{
			var transitions = new List<Transition<ExcavatorStates>>();

			transitions.Add(new Transition<ExcavatorStates>(ExcavatorStates.LowerBoom, ExcavatorStates.FillingBucket));
			transitions.Add(new Transition<ExcavatorStates>(ExcavatorStates.FillingBucket, ExcavatorStates.LiftBoom));
			transitions.Add(new Transition<ExcavatorStates>(ExcavatorStates.LiftBoom, ExcavatorStates.Rotation));
			transitions.Add(new Transition<ExcavatorStates>(ExcavatorStates.Rotation, ExcavatorStates.EmptyingBucket));
			transitions.Add(new Transition<ExcavatorStates>(ExcavatorStates.EmptyingBucket, ExcavatorStates.EndState));

			return transitions;
		}

		private static void ImitateExavatorActions(ExcavatorStates action)
		{
			switch (action)
			{
				case ExcavatorStates.LowerBoom:
					Console.WriteLine("Boom lowering...");
					Thread.Sleep(2000);
					break;
				case ExcavatorStates.FillingBucket:
					Console.WriteLine("Filling bucket...");
					Thread.Sleep(2000);
					break;
				case ExcavatorStates.LiftBoom:
					Console.WriteLine("Boom lifting...");
					Thread.Sleep(2000);
					break;
				case ExcavatorStates.Rotation:
					Console.WriteLine("Rotation...");
					Thread.Sleep(2000);
					break;
				case ExcavatorStates.EmptyingBucket:
					Console.WriteLine("Emptying bucket...");
					Thread.Sleep(2000);
					break;
				case ExcavatorStates.EndState:
					Console.WriteLine("All is done!");
					break;
			}
		}
	}
}
