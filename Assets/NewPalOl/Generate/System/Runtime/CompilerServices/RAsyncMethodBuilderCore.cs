using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
	/// System.Runtime.CompilerServices.AsyncMethodBuilderCore
	/// </summary>
    public partial class RAsyncMethodBuilderCore : RMember //
    {

		/// <summary>
		/// System.Runtime.CompilerServices.IAsyncStateMachine m_stateMachine
		/// </summary>
		protected RSystem.RRuntime.RCompilerServices.RIAsyncStateMachine r_m_stateMachine;
		public virtual RSystem.RRuntime.RCompilerServices.RIAsyncStateMachine Rm_stateMachine
		{
			get
			{
				if(r_m_stateMachine == null)
				{
					r_m_stateMachine = new(this, "m_stateMachine");
					r_m_stateMachine.SetBelong(this.instance);
				}
				return r_m_stateMachine;
			}
		}

		/// <summary>
		/// System.Action m_defaultContextAction
		/// </summary>
		protected RSystem.RAction r_m_defaultContextAction;
		public virtual RSystem.RAction Rm_defaultContextAction
		{
			get
			{
				if(r_m_defaultContextAction == null)
				{
					r_m_defaultContextAction = new(this, "m_defaultContextAction");
					r_m_defaultContextAction.SetBelong(this.instance);
				}
				return r_m_defaultContextAction;
			}
		}

		/// <summary>
		/// Void Start[TStateMachine](TStateMachine ByRef)
		/// </summary>
		protected static RMethod r_RStart_GTStateMachine_Ref_TStateMachine;
		public static RMethod RStart_GTStateMachine_Ref_TStateMachine
		{
			get
			{
				if(r_RStart_GTStateMachine_Ref_TStateMachine == null)
				{
					r_RStart_GTStateMachine_Ref_TStateMachine = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore"), "Start", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RStart_GTStateMachine_Ref_TStateMachine.SetBelong(null);
				}
				return r_RStart_GTStateMachine_Ref_TStateMachine;
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

		/// <summary>
		/// System.Action GetCompletionAction(System.Threading.Tasks.Task, MoveNextRunner ByRef)
		/// </summary>
		protected RMethod r_RGetCompletionAction_Task_Ref_MoveNextRunner;
		public virtual RMethod RGetCompletionAction_Task_Ref_MoveNextRunner
		{
			get
			{
				if(r_RGetCompletionAction_Task_Ref_MoveNextRunner == null)
				{
					r_RGetCompletionAction_Task_Ref_MoveNextRunner = new(this, "GetCompletionAction", 0, typeof(System.Threading.Tasks.Task),  ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore+MoveNextRunner").MakeByRefType());
					r_RGetCompletionAction_Task_Ref_MoveNextRunner.SetBelong(this.instance);
				}
				return r_RGetCompletionAction_Task_Ref_MoveNextRunner;
			}
		}

		/// <summary>
		/// System.Action OutputAsyncCausalityEvents(System.Threading.Tasks.Task, System.Action)
		/// </summary>
		protected RMethod r_ROutputAsyncCausalityEvents_Task_Action;
		public virtual RMethod ROutputAsyncCausalityEvents_Task_Action
		{
			get
			{
				if(r_ROutputAsyncCausalityEvents_Task_Action == null)
				{
					r_ROutputAsyncCausalityEvents_Task_Action = new(this, "OutputAsyncCausalityEvents", 0, typeof(System.Threading.Tasks.Task), typeof(System.Action));
					r_ROutputAsyncCausalityEvents_Task_Action.SetBelong(this.instance);
				}
				return r_ROutputAsyncCausalityEvents_Task_Action;
			}
		}

		/// <summary>
		/// Void PostBoxInitialization(System.Runtime.CompilerServices.IAsyncStateMachine, MoveNextRunner, System.Threading.Tasks.Task)
		/// </summary>
		protected RMethod r_RPostBoxInitialization_IAsyncStateMachine_MoveNextRunner_Task;
		public virtual RMethod RPostBoxInitialization_IAsyncStateMachine_MoveNextRunner_Task
		{
			get
			{
				if(r_RPostBoxInitialization_IAsyncStateMachine_MoveNextRunner_Task == null)
				{
					r_RPostBoxInitialization_IAsyncStateMachine_MoveNextRunner_Task = new(this, "PostBoxInitialization", 0, typeof(System.Runtime.CompilerServices.IAsyncStateMachine),  ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore+MoveNextRunner"), typeof(System.Threading.Tasks.Task));
					r_RPostBoxInitialization_IAsyncStateMachine_MoveNextRunner_Task.SetBelong(this.instance);
				}
				return r_RPostBoxInitialization_IAsyncStateMachine_MoveNextRunner_Task;
			}
		}

		/// <summary>
		/// Void ThrowAsync(System.Exception, System.Threading.SynchronizationContext)
		/// </summary>
		protected static RMethod r_RThrowAsync_Exception_SynchronizationContext;
		public static RMethod RThrowAsync_Exception_SynchronizationContext
		{
			get
			{
				if(r_RThrowAsync_Exception_SynchronizationContext == null)
				{
					r_RThrowAsync_Exception_SynchronizationContext = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore"), "ThrowAsync", 0, typeof(System.Exception), typeof(System.Threading.SynchronizationContext));
					r_RThrowAsync_Exception_SynchronizationContext.SetBelong(null);
				}
				return r_RThrowAsync_Exception_SynchronizationContext;
			}
		}

		/// <summary>
		/// System.Action CreateContinuationWrapper(System.Action, System.Action, System.Threading.Tasks.Task)
		/// </summary>
		protected static RMethod r_RCreateContinuationWrapper_Action_Action_Task;
		public static RMethod RCreateContinuationWrapper_Action_Action_Task
		{
			get
			{
				if(r_RCreateContinuationWrapper_Action_Action_Task == null)
				{
					r_RCreateContinuationWrapper_Action_Action_Task = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore"), "CreateContinuationWrapper", 0, typeof(System.Action), typeof(System.Action), typeof(System.Threading.Tasks.Task));
					r_RCreateContinuationWrapper_Action_Action_Task.SetBelong(null);
				}
				return r_RCreateContinuationWrapper_Action_Action_Task;
			}
		}

		/// <summary>
		/// System.Action TryGetStateMachineForDebugger(System.Action)
		/// </summary>
		protected static RMethod r_RTryGetStateMachineForDebugger_Action;
		public static RMethod RTryGetStateMachineForDebugger_Action
		{
			get
			{
				if(r_RTryGetStateMachineForDebugger_Action == null)
				{
					r_RTryGetStateMachineForDebugger_Action = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore"), "TryGetStateMachineForDebugger", 0, typeof(System.Action));
					r_RTryGetStateMachineForDebugger_Action.SetBelong(null);
				}
				return r_RTryGetStateMachineForDebugger_Action;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task TryGetContinuationTask(System.Action)
		/// </summary>
		protected static RMethod r_RTryGetContinuationTask_Action;
		public static RMethod RTryGetContinuationTask_Action
		{
			get
			{
				if(r_RTryGetContinuationTask_Action == null)
				{
					r_RTryGetContinuationTask_Action = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore"), "TryGetContinuationTask", 0, typeof(System.Action));
					r_RTryGetContinuationTask_Action.SetBelong(null);
				}
				return r_RTryGetContinuationTask_Action;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object)
		/// </summary>
		protected RMethod r_REquals_Object;
		public virtual RMethod REquals_Object
		{
			get
			{
				if(r_REquals_Object == null)
				{
					r_REquals_Object = new(this, "Equals", 0, typeof(System.Object));
					r_REquals_Object.SetBelong(this.instance);
				}
				return r_REquals_Object;
			}
		}

		/// <summary>
		/// Int32 GetHashCode()
		/// </summary>
		protected RMethod r_RGetHashCode;
		public virtual RMethod RGetHashCode
		{
			get
			{
				if(r_RGetHashCode == null)
				{
					r_RGetHashCode = new(this, "GetHashCode", 0);
					r_RGetHashCode.SetBelong(this.instance);
				}
				return r_RGetHashCode;
			}
		}

		/// <summary>
		/// System.String ToString()
		/// </summary>
		protected RMethod r_RToString;
		public virtual RMethod RToString
		{
			get
			{
				if(r_RToString == null)
				{
					r_RToString = new(this, "ToString", 0);
					r_RToString.SetBelong(this.instance);
				}
				return r_RToString;
			}
		}

		/// <summary>
		/// Void Finalize()
		/// </summary>
		protected RMethod r_RFinalize;
		public virtual RMethod RFinalize
		{
			get
			{
				if(r_RFinalize == null)
				{
					r_RFinalize = new(this, "Finalize", 0);
					r_RFinalize.SetBelong(this.instance);
				}
				return r_RFinalize;
			}
		}

		/// <summary>
		/// System.Type GetType()
		/// </summary>
		protected RMethod r_RGetType;
		public virtual RMethod RGetType
		{
			get
			{
				if(r_RGetType == null)
				{
					r_RGetType = new(this, "GetType", 0);
					r_RGetType.SetBelong(this.instance);
				}
				return r_RGetType;
			}
		}

		/// <summary>
		/// System.Object MemberwiseClone()
		/// </summary>
		protected RMethod r_RMemberwiseClone;
		public virtual RMethod RMemberwiseClone
		{
			get
			{
				if(r_RMemberwiseClone == null)
				{
					r_RMemberwiseClone = new(this, "MemberwiseClone", 0);
					r_RMemberwiseClone.SetBelong(this.instance);
				}
				return r_RMemberwiseClone;
			}
		}


        public RAsyncMethodBuilderCore() : base("System.Runtime.CompilerServices.AsyncMethodBuilderCore")
        {
        }

        public RAsyncMethodBuilderCore(System.Object instance) : base("System.Runtime.CompilerServices.AsyncMethodBuilderCore")
		{
            SetInstance(instance);
		}

        public RAsyncMethodBuilderCore(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncMethodBuilderCore(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Start<TStateMachine>(ref TStateMachine  @stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
        {

            var ___genericsType = new Type[] {typeof(TStateMachine)};
            var ___parameters = new object[]{@stateMachine};
            var ___result = RStart_GTStateMachine_Ref_TStateMachine.Invoke(___genericsType, ___parameters);
			stateMachine = (TStateMachine)___parameters[0];

            
        }


        public virtual void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine  @stateMachine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stateMachine};
            var ___result = RSetStateMachine_IAsyncStateMachine.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Action OutputAsyncCausalityEvents(System.Threading.Tasks.Task  @innerTask, System.Action  @continuation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@innerTask, @continuation};
            var ___result = ROutputAsyncCausalityEvents_Task_Action.Invoke(___genericsType, ___parameters);

            return (System.Action)___result;
        }



        public static void ThrowAsync(System.Exception  @exception, System.Threading.SynchronizationContext  @targetContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception, @targetContext};
            var ___result = RThrowAsync_Exception_SynchronizationContext.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Action CreateContinuationWrapper(System.Action  @continuation, System.Action  @invokeAction, System.Threading.Tasks.Task  @innerTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation, @invokeAction, @innerTask};
            var ___result = RCreateContinuationWrapper_Action_Action_Task.Invoke(___genericsType, ___parameters);

            return (System.Action)___result;
        }


        public static System.Action TryGetStateMachineForDebugger(System.Action  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RTryGetStateMachineForDebugger_Action.Invoke(___genericsType, ___parameters);

            return (System.Action)___result;
        }


        public static System.Threading.Tasks.Task TryGetContinuationTask(System.Action  @action)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@action};
            var ___result = RTryGetContinuationTask_Action.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Type GetType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetType.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
        }


        public virtual System.Object MemberwiseClone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMemberwiseClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
