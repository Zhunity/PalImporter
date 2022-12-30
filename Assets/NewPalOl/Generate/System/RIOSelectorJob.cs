using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{
	/// <summary>
	/// System.IOSelectorJob
	/// </summary>
    public partial class RIOSelectorJob : RMember //
    {

		/// <summary>
		/// System.IOOperation operation
		/// </summary>
		protected RField r_operation;
		public virtual RField Roperation
		{
			get
			{
				if(r_operation == null)
				{
					r_operation = new(this, "operation");
					r_operation.SetBelong(this.instance);
				}
				return r_operation;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback callback
		/// </summary>
		protected RSystem.RIOAsyncCallback r_callback;
		public virtual RSystem.RIOAsyncCallback Rcallback
		{
			get
			{
				if(r_callback == null)
				{
					r_callback = new(this, "callback");
					r_callback.SetBelong(this.instance);
				}
				return r_callback;
			}
		}

		/// <summary>
		/// System.IOAsyncResult state
		/// </summary>
		protected RSystem.RIOAsyncResult r_state;
		public virtual RSystem.RIOAsyncResult Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// Void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem()
		/// </summary>
		protected RMethod r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__ExecuteWorkItem;
		public virtual RMethod RSystem__1__Threading__1__IThreadPoolWorkItem__1__ExecuteWorkItem
		{
			get
			{
				if(r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__ExecuteWorkItem == null)
				{
					r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__ExecuteWorkItem = new(this, "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", 0);
					r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__ExecuteWorkItem.SetBelong(this.instance);
				}
				return r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__ExecuteWorkItem;
			}
		}

		/// <summary>
		/// Void System.Threading.IThreadPoolWorkItem.MarkAborted(System.Threading.ThreadAbortException)
		/// </summary>
		protected RMethod r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__MarkAborted_ThreadAbortException;
		public virtual RMethod RSystem__1__Threading__1__IThreadPoolWorkItem__1__MarkAborted_ThreadAbortException
		{
			get
			{
				if(r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__MarkAborted_ThreadAbortException == null)
				{
					r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__MarkAborted_ThreadAbortException = new(this, "System.Threading.IThreadPoolWorkItem.MarkAborted", 0, typeof(System.Threading.ThreadAbortException));
					r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__MarkAborted_ThreadAbortException.SetBelong(this.instance);
				}
				return r_RSystem__1__Threading__1__IThreadPoolWorkItem__1__MarkAborted_ThreadAbortException;
			}
		}

		/// <summary>
		/// Void MarkDisposed()
		/// </summary>
		protected RMethod r_RMarkDisposed;
		public virtual RMethod RMarkDisposed
		{
			get
			{
				if(r_RMarkDisposed == null)
				{
					r_RMarkDisposed = new(this, "MarkDisposed", 0);
					r_RMarkDisposed.SetBelong(this.instance);
				}
				return r_RMarkDisposed;
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


        public RIOSelectorJob() : base("System.IOSelectorJob")
        {
        }

        public RIOSelectorJob(System.Object instance) : base("System.IOSelectorJob")
		{
            SetInstance(instance);
		}

        public RIOSelectorJob(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIOSelectorJob(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void System__1__Threading__1__IThreadPoolWorkItem__1__ExecuteWorkItem()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Threading__1__IThreadPoolWorkItem__1__ExecuteWorkItem.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void System__1__Threading__1__IThreadPoolWorkItem__1__MarkAborted(System.Threading.ThreadAbortException  @tae)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tae};
            var ___result = RSystem__1__Threading__1__IThreadPoolWorkItem__1__MarkAborted_ThreadAbortException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MarkDisposed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMarkDisposed.Invoke(___genericsType, ___parameters);

            
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
