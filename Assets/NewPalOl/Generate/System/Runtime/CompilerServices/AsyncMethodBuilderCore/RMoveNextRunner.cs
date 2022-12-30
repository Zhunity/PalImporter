using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RRuntime.RCompilerServices
{public partial class RAsyncMethodBuilderCore
{
	
	/// <summary>
	/// System.Runtime.CompilerServices.AsyncMethodBuilderCore+MoveNextRunner
	/// </summary>
    public partial class RMoveNextRunner : RMember //
    {

		/// <summary>
		/// System.Threading.ExecutionContext m_context
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r_m_context;
		public virtual RSystem.RThreading.RExecutionContext Rm_context
		{
			get
			{
				if(r_m_context == null)
				{
					r_m_context = new(this, "m_context");
					r_m_context.SetBelong(this.instance);
				}
				return r_m_context;
			}
		}

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
		/// System.Threading.ContextCallback s_invokeMoveNext
		/// </summary>
		protected static RSystem.RThreading.RContextCallback r_s_invokeMoveNext;
		public static RSystem.RThreading.RContextCallback Rs_invokeMoveNext
		{
			get
			{
				if(r_s_invokeMoveNext == null)
				{
					r_s_invokeMoveNext = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore+MoveNextRunner"), "s_invokeMoveNext");
					r_s_invokeMoveNext.SetBelong(null);
				}
				return r_s_invokeMoveNext;
			}
		}

		/// <summary>
		/// Void Run()
		/// </summary>
		protected RMethod r_RRun;
		public virtual RMethod RRun
		{
			get
			{
				if(r_RRun == null)
				{
					r_RRun = new(this, "Run", 0);
					r_RRun.SetBelong(this.instance);
				}
				return r_RRun;
			}
		}

		/// <summary>
		/// Void InvokeMoveNext(System.Object)
		/// </summary>
		protected static RMethod r_RInvokeMoveNext_Object;
		public static RMethod RInvokeMoveNext_Object
		{
			get
			{
				if(r_RInvokeMoveNext_Object == null)
				{
					r_RInvokeMoveNext_Object = new( ReleactionUtils.GetType("System.Runtime.CompilerServices.AsyncMethodBuilderCore+MoveNextRunner"), "InvokeMoveNext", 0, typeof(System.Object));
					r_RInvokeMoveNext_Object.SetBelong(null);
				}
				return r_RInvokeMoveNext_Object;
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


        public RMoveNextRunner() : base("System.Runtime.CompilerServices.AsyncMethodBuilderCore+MoveNextRunner")
        {
        }

        public RMoveNextRunner(System.Object instance) : base("System.Runtime.CompilerServices.AsyncMethodBuilderCore+MoveNextRunner")
		{
            SetInstance(instance);
		}

        public RMoveNextRunner(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMoveNextRunner(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Run()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRun.Invoke(___genericsType, ___parameters);

            
        }


        public static void InvokeMoveNext(System.Object  @stateMachine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stateMachine};
            var ___result = RInvokeMoveNext_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
}