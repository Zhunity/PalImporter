using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{
	/// <summary>
	/// System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1
	/// </summary>
    public partial class RAsyncTaskMethodBuilder<TResult> : RMember //
    {

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] s_defaultResultTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask<RField> r_s_defaultResultTask;
		public static RSystem.RThreading.RTasks.RTask<RField> Rs_defaultResultTask
		{
			get
			{
				if(r_s_defaultResultTask == null)
				{
					r_s_defaultResultTask = new(typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), "s_defaultResultTask");
					r_s_defaultResultTask.SetBelong(null);
				}
				return r_s_defaultResultTask;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.AsyncMethodBuilderCore m_coreState
		/// </summary>
		protected RSystem.RRuntime.RCompilerServices.RAsyncMethodBuilderCore r_m_coreState;
		public virtual RSystem.RRuntime.RCompilerServices.RAsyncMethodBuilderCore Rm_coreState
		{
			get
			{
				if(r_m_coreState == null)
				{
					r_m_coreState = new(this, "m_coreState");
					r_m_coreState.SetBelong(this.instance);
				}
				return r_m_coreState;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] m_task
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask<RField> r_m_task;
		public virtual RSystem.RThreading.RTasks.RTask<RField> Rm_task
		{
			get
			{
				if(r_m_task == null)
				{
					r_m_task = new(this, "m_task");
					r_m_task.SetBelong(this.instance);
				}
				return r_m_task;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] Task
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask<RProperty> r_Task;
		public virtual RSystem.RThreading.RTasks.RTask<RProperty> RTask
		{
			get
			{
				if(r_Task == null)
				{
					r_Task = new(this, "Task", -1);
					r_Task.SetBelong(this.instance);
				}
				return r_Task;
			}
		}

		/// <summary>
		/// System.Object ObjectIdForDebugger
		/// </summary>
		protected RSystem.RObject r_ObjectIdForDebugger;
		public virtual RSystem.RObject RObjectIdForDebugger
		{
			get
			{
				if(r_ObjectIdForDebugger == null)
				{
					r_ObjectIdForDebugger = new(this, "ObjectIdForDebugger", -1);
					r_ObjectIdForDebugger.SetBelong(this.instance);
				}
				return r_ObjectIdForDebugger;
			}
		}

		/// <summary>
		/// System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[TResult] Create()
		/// </summary>
		protected static RMethod r_RCreate;
		public static RMethod RCreate
		{
			get
			{
				if(r_RCreate == null)
				{
					r_RCreate = new(typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), "Create", 0);
					r_RCreate.SetBelong(null);
				}
				return r_RCreate;
			}
		}

		/// <summary>
		/// Void Start[TStateMachine](TStateMachine ByRef)
		/// </summary>
		protected RMethod r_RStart_GTStateMachine_Ref_TStateMachine;
		public virtual RMethod RStart_GTStateMachine_Ref_TStateMachine
		{
			get
			{
				if(r_RStart_GTStateMachine_Ref_TStateMachine == null)
				{
					r_RStart_GTStateMachine_Ref_TStateMachine = new(this, "Start", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RStart_GTStateMachine_Ref_TStateMachine.SetBelong(this.instance);
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
		/// Void AwaitOnCompleted[TAwaiter,TStateMachine](TAwaiter ByRef, TStateMachine ByRef)
		/// </summary>
		protected RMethod r_RAwaitOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine;
		public virtual RMethod RAwaitOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine
		{
			get
			{
				if(r_RAwaitOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine == null)
				{
					r_RAwaitOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine = new(this, "AwaitOnCompleted", 2, Type.MakeGenericMethodParameter(0).MakeByRefType(), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_RAwaitOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine.SetBelong(this.instance);
				}
				return r_RAwaitOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine;
			}
		}

		/// <summary>
		/// Void AwaitUnsafeOnCompleted[TAwaiter,TStateMachine](TAwaiter ByRef, TStateMachine ByRef)
		/// </summary>
		protected RMethod r_RAwaitUnsafeOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine;
		public virtual RMethod RAwaitUnsafeOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine
		{
			get
			{
				if(r_RAwaitUnsafeOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine == null)
				{
					r_RAwaitUnsafeOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine = new(this, "AwaitUnsafeOnCompleted", 2, Type.MakeGenericMethodParameter(0).MakeByRefType(), Type.MakeGenericMethodParameter(1).MakeByRefType());
					r_RAwaitUnsafeOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine.SetBelong(this.instance);
				}
				return r_RAwaitUnsafeOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine;
			}
		}

		/// <summary>
		/// Void SetResult(TResult)
		/// </summary>
		protected RMethod r_RSetResult_TResult;
		public virtual RMethod RSetResult_TResult
		{
			get
			{
				if(r_RSetResult_TResult == null)
				{
					r_RSetResult_TResult = new(this, "SetResult", 0, Type.MakeGenericMethodParameter(0));
					r_RSetResult_TResult.SetBelong(this.instance);
				}
				return r_RSetResult_TResult;
			}
		}

		/// <summary>
		/// Void SetResult(System.Threading.Tasks.Task`1[TResult])
		/// </summary>
		protected RMethod r_RSetResult_Task_d_TResult_p_;
		public virtual RMethod RSetResult_Task_d_TResult_p_
		{
			get
			{
				if(r_RSetResult_Task_d_TResult_p_ == null)
				{
					r_RSetResult_Task_d_TResult_p_ = new(this, "SetResult", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RSetResult_Task_d_TResult_p_.SetBelong(this.instance);
				}
				return r_RSetResult_Task_d_TResult_p_;
			}
		}

		/// <summary>
		/// Void SetException(System.Exception)
		/// </summary>
		protected RMethod r_RSetException_Exception;
		public virtual RMethod RSetException_Exception
		{
			get
			{
				if(r_RSetException_Exception == null)
				{
					r_RSetException_Exception = new(this, "SetException", 0, typeof(System.Exception));
					r_RSetException_Exception.SetBelong(this.instance);
				}
				return r_RSetException_Exception;
			}
		}

		/// <summary>
		/// Void SetNotificationForWaitCompletion(Boolean)
		/// </summary>
		protected RMethod r_RSetNotificationForWaitCompletion_Boolean;
		public virtual RMethod RSetNotificationForWaitCompletion_Boolean
		{
			get
			{
				if(r_RSetNotificationForWaitCompletion_Boolean == null)
				{
					r_RSetNotificationForWaitCompletion_Boolean = new(this, "SetNotificationForWaitCompletion", 0, typeof(System.Boolean));
					r_RSetNotificationForWaitCompletion_Boolean.SetBelong(this.instance);
				}
				return r_RSetNotificationForWaitCompletion_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[TResult] GetTaskForResult(TResult)
		/// </summary>
		protected static RMethod r_RGetTaskForResult_TResult;
		public static RMethod RGetTaskForResult_TResult
		{
			get
			{
				if(r_RGetTaskForResult_TResult == null)
				{
					r_RGetTaskForResult_TResult = new(typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>), "GetTaskForResult", 0, Type.MakeGenericMethodParameter(0));
					r_RGetTaskForResult_TResult.SetBelong(null);
				}
				return r_RGetTaskForResult_TResult;
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


        public RAsyncTaskMethodBuilder() : base("System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1")
        {
        }

        public RAsyncTaskMethodBuilder(System.Object instance) : base("System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1")
		{
            SetInstance(instance);
		}

        public RAsyncTaskMethodBuilder(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAsyncTaskMethodBuilder(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> Create()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreate.Invoke(___genericsType, ___parameters);

            return (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult>)___result;
        }


        public virtual void Start<TStateMachine>(ref TStateMachine  @stateMachine) where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
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


        public virtual void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter  @awaiter, ref TStateMachine  @stateMachine) where TAwaiter : System.Runtime.CompilerServices.INotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
        {

            var ___genericsType = new Type[] {typeof(TAwaiter), typeof(TStateMachine)};
            var ___parameters = new object[]{@awaiter, @stateMachine};
            var ___result = RAwaitOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine.Invoke(___genericsType, ___parameters);
			awaiter = (TAwaiter)___parameters[0];
			stateMachine = (TStateMachine)___parameters[1];

            
        }


        public virtual void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter  @awaiter, ref TStateMachine  @stateMachine) where TAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion where TStateMachine : System.Runtime.CompilerServices.IAsyncStateMachine
        {

            var ___genericsType = new Type[] {typeof(TAwaiter), typeof(TStateMachine)};
            var ___parameters = new object[]{@awaiter, @stateMachine};
            var ___result = RAwaitUnsafeOnCompleted_GTAwaiter_GTStateMachine_Ref_TAwaiter_Ref_TStateMachine.Invoke(___genericsType, ___parameters);
			awaiter = (TAwaiter)___parameters[0];
			stateMachine = (TStateMachine)___parameters[1];

            
        }


        public virtual void SetResult(TResult  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RSetResult_TResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetResult(System.Threading.Tasks.Task<TResult>  @completedTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@completedTask};
            var ___result = RSetResult_Task_d_TResult_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetException(System.Exception  @exception)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception};
            var ___result = RSetException_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNotificationForWaitCompletion(System.Boolean  @enabled)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@enabled};
            var ___result = RSetNotificationForWaitCompletion_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Threading.Tasks.Task<TResult> GetTaskForResult(TResult  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RGetTaskForResult_TResult.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<TResult>)___result;
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
