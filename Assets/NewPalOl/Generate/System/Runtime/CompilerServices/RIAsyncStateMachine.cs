using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
	/// System.Runtime.CompilerServices.IAsyncStateMachine
	/// </summary>
    public partial class RIAsyncStateMachine : RMember //
    {

		/// <summary>
		/// Void MoveNext()
		/// </summary>
		protected RMethod r_RMoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_RMoveNext == null)
				{
					r_RMoveNext = new(this, "MoveNext", 0);
					r_RMoveNext.SetBelong(this.instance);
				}
				return r_RMoveNext;
			}
		}

		/// <summary>
		/// Void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine)
		/// </summary>
		protected RMethod r_RSetStateMachine_IAsyncStateMachine;
		public virtual RMethod RSetStateMachine_IAsyncStateMachine
		{
			get
			{
				if(r_RSetStateMachine_IAsyncStateMachine == null)
				{
					r_RSetStateMachine_IAsyncStateMachine = new(this, "SetStateMachine", 0, typeof(System.Runtime.CompilerServices.IAsyncStateMachine));
					r_RSetStateMachine_IAsyncStateMachine.SetBelong(this.instance);
				}
				return r_RSetStateMachine_IAsyncStateMachine;
			}
		}


        public RIAsyncStateMachine() : base("System.Runtime.CompilerServices.IAsyncStateMachine")
        {
        }

        public RIAsyncStateMachine(System.Object instance) : base("System.Runtime.CompilerServices.IAsyncStateMachine")
		{
            SetInstance(instance);
		}

        public RIAsyncStateMachine(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIAsyncStateMachine(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine  @stateMachine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stateMachine};
            var ___result = RSetStateMachine_IAsyncStateMachine.Invoke(___genericsType, ___parameters);

            
        }


    }
}
