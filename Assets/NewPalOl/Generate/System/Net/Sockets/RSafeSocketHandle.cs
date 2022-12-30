using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.SafeSocketHandle
	/// </summary>
    public partial class RSafeSocketHandle : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[System.Threading.Thread] blocking_threads
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RThreading.RThread> r_blocking_threads;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RThreading.RThread> Rblocking_threads
		{
			get
			{
				if(r_blocking_threads == null)
				{
					r_blocking_threads = new(this, "blocking_threads");
					r_blocking_threads.SetBelong(this.instance);
				}
				return r_blocking_threads;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Threading.Thread,System.Diagnostics.StackTrace] threads_stacktraces
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RThreading.RThread, RSystem.RDiagnostics.RStackTrace> r_threads_stacktraces;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RThreading.RThread, RSystem.RDiagnostics.RStackTrace> Rthreads_stacktraces
		{
			get
			{
				if(r_threads_stacktraces == null)
				{
					r_threads_stacktraces = new(this, "threads_stacktraces");
					r_threads_stacktraces.SetBelong(this.instance);
				}
				return r_threads_stacktraces;
			}
		}

		/// <summary>
		/// System.Boolean in_cleanup
		/// </summary>
		protected RField r_in_cleanup;
		public virtual RField Rin_cleanup
		{
			get
			{
				if(r_in_cleanup == null)
				{
					r_in_cleanup = new(this, "in_cleanup");
					r_in_cleanup.SetBelong(this.instance);
				}
				return r_in_cleanup;
			}
		}

		/// <summary>
		/// System.Int32 SOCKET_CLOSED
		/// </summary>
		protected static RField r_SOCKET_CLOSED;
		public static RField RSOCKET_CLOSED
		{
			get
			{
				if(r_SOCKET_CLOSED == null)
				{
					r_SOCKET_CLOSED = new( ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), "SOCKET_CLOSED");
					r_SOCKET_CLOSED.SetBelong(null);
				}
				return r_SOCKET_CLOSED;
			}
		}

		/// <summary>
		/// System.Int32 ABORT_RETRIES
		/// </summary>
		protected static RField r_ABORT_RETRIES;
		public static RField RABORT_RETRIES
		{
			get
			{
				if(r_ABORT_RETRIES == null)
				{
					r_ABORT_RETRIES = new( ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), "ABORT_RETRIES");
					r_ABORT_RETRIES.SetBelong(null);
				}
				return r_ABORT_RETRIES;
			}
		}

		/// <summary>
		/// System.Boolean THROW_ON_ABORT_RETRIES
		/// </summary>
		protected static RField r_THROW_ON_ABORT_RETRIES;
		public static RField RTHROW_ON_ABORT_RETRIES
		{
			get
			{
				if(r_THROW_ON_ABORT_RETRIES == null)
				{
					r_THROW_ON_ABORT_RETRIES = new( ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), "THROW_ON_ABORT_RETRIES");
					r_THROW_ON_ABORT_RETRIES.SetBelong(null);
				}
				return r_THROW_ON_ABORT_RETRIES;
			}
		}

		/// <summary>
		/// System.IntPtr handle
		/// </summary>
		protected RField r_handle;
		public virtual RField Rhandle
		{
			get
			{
				if(r_handle == null)
				{
					r_handle = new(this, "handle");
					r_handle.SetBelong(this.instance);
				}
				return r_handle;
			}
		}

		/// <summary>
		/// Boolean IsInvalid
		/// </summary>
		protected RProperty r_IsInvalid;
		public virtual RProperty RIsInvalid
		{
			get
			{
				if(r_IsInvalid == null)
				{
					r_IsInvalid = new(this, "IsInvalid", -1);
					r_IsInvalid.SetBelong(this.instance);
				}
				return r_IsInvalid;
			}
		}

		/// <summary>
		/// Boolean IsClosed
		/// </summary>
		protected RProperty r_IsClosed;
		public virtual RProperty RIsClosed
		{
			get
			{
				if(r_IsClosed == null)
				{
					r_IsClosed = new(this, "IsClosed", -1);
					r_IsClosed.SetBelong(this.instance);
				}
				return r_IsClosed;
			}
		}

		/// <summary>
		/// Boolean ReleaseHandle()
		/// </summary>
		protected RMethod r_RReleaseHandle;
		public virtual RMethod RReleaseHandle
		{
			get
			{
				if(r_RReleaseHandle == null)
				{
					r_RReleaseHandle = new(this, "ReleaseHandle", 0);
					r_RReleaseHandle.SetBelong(this.instance);
				}
				return r_RReleaseHandle;
			}
		}

		/// <summary>
		/// Void RegisterForBlockingSyscall()
		/// </summary>
		protected RMethod r_RRegisterForBlockingSyscall;
		public virtual RMethod RRegisterForBlockingSyscall
		{
			get
			{
				if(r_RRegisterForBlockingSyscall == null)
				{
					r_RRegisterForBlockingSyscall = new(this, "RegisterForBlockingSyscall", 0);
					r_RRegisterForBlockingSyscall.SetBelong(this.instance);
				}
				return r_RRegisterForBlockingSyscall;
			}
		}

		/// <summary>
		/// Void UnRegisterForBlockingSyscall()
		/// </summary>
		protected RMethod r_RUnRegisterForBlockingSyscall;
		public virtual RMethod RUnRegisterForBlockingSyscall
		{
			get
			{
				if(r_RUnRegisterForBlockingSyscall == null)
				{
					r_RUnRegisterForBlockingSyscall = new(this, "UnRegisterForBlockingSyscall", 0);
					r_RUnRegisterForBlockingSyscall.SetBelong(this.instance);
				}
				return r_RUnRegisterForBlockingSyscall;
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
		/// Void SetHandle(IntPtr)
		/// </summary>
		protected RMethod r_RSetHandle_IntPtr;
		public virtual RMethod RSetHandle_IntPtr
		{
			get
			{
				if(r_RSetHandle_IntPtr == null)
				{
					r_RSetHandle_IntPtr = new(this, "SetHandle", 0, typeof(System.IntPtr));
					r_RSetHandle_IntPtr.SetBelong(this.instance);
				}
				return r_RSetHandle_IntPtr;
			}
		}

		/// <summary>
		/// IntPtr DangerousGetHandle()
		/// </summary>
		protected RMethod r_RDangerousGetHandle;
		public virtual RMethod RDangerousGetHandle
		{
			get
			{
				if(r_RDangerousGetHandle == null)
				{
					r_RDangerousGetHandle = new(this, "DangerousGetHandle", 0);
					r_RDangerousGetHandle.SetBelong(this.instance);
				}
				return r_RDangerousGetHandle;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
			}
		}

		/// <summary>
		/// Void SetHandleAsInvalid()
		/// </summary>
		protected RMethod r_RSetHandleAsInvalid;
		public virtual RMethod RSetHandleAsInvalid
		{
			get
			{
				if(r_RSetHandleAsInvalid == null)
				{
					r_RSetHandleAsInvalid = new(this, "SetHandleAsInvalid", 0);
					r_RSetHandleAsInvalid.SetBelong(this.instance);
				}
				return r_RSetHandleAsInvalid;
			}
		}

		/// <summary>
		/// Void DangerousAddRef(Boolean ByRef)
		/// </summary>
		protected RMethod r_RDangerousAddRef_Ref_Boolean;
		public virtual RMethod RDangerousAddRef_Ref_Boolean
		{
			get
			{
				if(r_RDangerousAddRef_Ref_Boolean == null)
				{
					r_RDangerousAddRef_Ref_Boolean = new(this, "DangerousAddRef", 0, typeof(System.Boolean).MakeByRefType());
					r_RDangerousAddRef_Ref_Boolean.SetBelong(this.instance);
				}
				return r_RDangerousAddRef_Ref_Boolean;
			}
		}

		/// <summary>
		/// Void DangerousRelease()
		/// </summary>
		protected RMethod r_RDangerousRelease;
		public virtual RMethod RDangerousRelease
		{
			get
			{
				if(r_RDangerousRelease == null)
				{
					r_RDangerousRelease = new(this, "DangerousRelease", 0);
					r_RDangerousRelease.SetBelong(this.instance);
				}
				return r_RDangerousRelease;
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


        public RSafeSocketHandle() : base("System.Net.Sockets.SafeSocketHandle")
        {
        }

        public RSafeSocketHandle(System.Object instance) : base("System.Net.Sockets.SafeSocketHandle")
		{
            SetInstance(instance);
		}

        public RSafeSocketHandle(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSafeSocketHandle(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean ReleaseHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReleaseHandle.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RegisterForBlockingSyscall()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRegisterForBlockingSyscall.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnRegisterForBlockingSyscall()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnRegisterForBlockingSyscall.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHandle(System.IntPtr  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RSetHandle_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IntPtr DangerousGetHandle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDangerousGetHandle.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetHandleAsInvalid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetHandleAsInvalid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DangerousAddRef(ref System.Boolean  @success)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@success};
            var ___result = RDangerousAddRef_Ref_Boolean.Invoke(___genericsType, ___parameters);
			success = (System.Boolean)___parameters[0];

            
        }


        public virtual void DangerousRelease()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDangerousRelease.Invoke(___genericsType, ___parameters);

            
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
