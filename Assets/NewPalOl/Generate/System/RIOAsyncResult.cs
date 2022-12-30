using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IOAsyncResult
	/// </summary>
    public partial class RIOAsyncResult : RMember //
    {

		/// <summary>
		/// System.AsyncCallback async_callback
		/// </summary>
		protected RSystem.RAsyncCallback r_async_callback;
		public virtual RSystem.RAsyncCallback Rasync_callback
		{
			get
			{
				if(r_async_callback == null)
				{
					r_async_callback = new(this, "async_callback");
					r_async_callback.SetBelong(this.instance);
				}
				return r_async_callback;
			}
		}

		/// <summary>
		/// System.Object async_state
		/// </summary>
		protected RSystem.RObject r_async_state;
		public virtual RSystem.RObject Rasync_state
		{
			get
			{
				if(r_async_state == null)
				{
					r_async_state = new(this, "async_state");
					r_async_state.SetBelong(this.instance);
				}
				return r_async_state;
			}
		}

		/// <summary>
		/// System.Threading.ManualResetEvent wait_handle
		/// </summary>
		protected RSystem.RThreading.RManualResetEvent r_wait_handle;
		public virtual RSystem.RThreading.RManualResetEvent Rwait_handle
		{
			get
			{
				if(r_wait_handle == null)
				{
					r_wait_handle = new(this, "wait_handle");
					r_wait_handle.SetBelong(this.instance);
				}
				return r_wait_handle;
			}
		}

		/// <summary>
		/// System.Boolean completed_synchronously
		/// </summary>
		protected RField r_completed_synchronously;
		public virtual RField Rcompleted_synchronously
		{
			get
			{
				if(r_completed_synchronously == null)
				{
					r_completed_synchronously = new(this, "completed_synchronously");
					r_completed_synchronously.SetBelong(this.instance);
				}
				return r_completed_synchronously;
			}
		}

		/// <summary>
		/// System.Boolean completed
		/// </summary>
		protected RField r_completed;
		public virtual RField Rcompleted
		{
			get
			{
				if(r_completed == null)
				{
					r_completed = new(this, "completed");
					r_completed.SetBelong(this.instance);
				}
				return r_completed;
			}
		}

		/// <summary>
		/// System.AsyncCallback AsyncCallback
		/// </summary>
		protected RSystem.RAsyncCallback r_AsyncCallback;
		public virtual RSystem.RAsyncCallback RAsyncCallback
		{
			get
			{
				if(r_AsyncCallback == null)
				{
					r_AsyncCallback = new(this, "AsyncCallback", -1);
					r_AsyncCallback.SetBelong(this.instance);
				}
				return r_AsyncCallback;
			}
		}

		/// <summary>
		/// System.Object AsyncState
		/// </summary>
		protected RSystem.RObject r_AsyncState;
		public virtual RSystem.RObject RAsyncState
		{
			get
			{
				if(r_AsyncState == null)
				{
					r_AsyncState = new(this, "AsyncState", -1);
					r_AsyncState.SetBelong(this.instance);
				}
				return r_AsyncState;
			}
		}

		/// <summary>
		/// System.Threading.WaitHandle AsyncWaitHandle
		/// </summary>
		protected RSystem.RThreading.RWaitHandle r_AsyncWaitHandle;
		public virtual RSystem.RThreading.RWaitHandle RAsyncWaitHandle
		{
			get
			{
				if(r_AsyncWaitHandle == null)
				{
					r_AsyncWaitHandle = new(this, "AsyncWaitHandle", -1);
					r_AsyncWaitHandle.SetBelong(this.instance);
				}
				return r_AsyncWaitHandle;
			}
		}

		/// <summary>
		/// Boolean CompletedSynchronously
		/// </summary>
		protected RProperty r_CompletedSynchronously;
		public virtual RProperty RCompletedSynchronously
		{
			get
			{
				if(r_CompletedSynchronously == null)
				{
					r_CompletedSynchronously = new(this, "CompletedSynchronously", -1);
					r_CompletedSynchronously.SetBelong(this.instance);
				}
				return r_CompletedSynchronously;
			}
		}

		/// <summary>
		/// Boolean IsCompleted
		/// </summary>
		protected RProperty r_IsCompleted;
		public virtual RProperty RIsCompleted
		{
			get
			{
				if(r_IsCompleted == null)
				{
					r_IsCompleted = new(this, "IsCompleted", -1);
					r_IsCompleted.SetBelong(this.instance);
				}
				return r_IsCompleted;
			}
		}

		/// <summary>
		/// Void Init(System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RInit_AsyncCallback_Object;
		public virtual RMethod RInit_AsyncCallback_Object
		{
			get
			{
				if(r_RInit_AsyncCallback_Object == null)
				{
					r_RInit_AsyncCallback_Object = new(this, "Init", 0, typeof(System.AsyncCallback), typeof(System.Object));
					r_RInit_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RInit_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void CompleteDisposed()
		/// </summary>
		protected RMethod r_RCompleteDisposed;
		public virtual RMethod RCompleteDisposed
		{
			get
			{
				if(r_RCompleteDisposed == null)
				{
					r_RCompleteDisposed = new(this, "CompleteDisposed", 0);
					r_RCompleteDisposed.SetBelong(this.instance);
				}
				return r_RCompleteDisposed;
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


        public RIOAsyncResult() : base("System.IOAsyncResult")
        {
        }

        public RIOAsyncResult(System.Object instance) : base("System.IOAsyncResult")
		{
            SetInstance(instance);
		}

        public RIOAsyncResult(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIOAsyncResult(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init(System.AsyncCallback  @async_callback, System.Object  @async_state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@async_callback, @async_state};
            var ___result = RInit_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteDisposed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteDisposed.Invoke(___genericsType, ___parameters);

            
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
