using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.SocketAsyncResult
	/// </summary>
    public partial class RSocketAsyncResult : RMember //
    {

		/// <summary>
		/// System.Net.Sockets.Socket socket
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r_socket;
		public virtual RSystem.RNet.RSockets.RSocket Rsocket
		{
			get
			{
				if(r_socket == null)
				{
					r_socket = new(this, "socket");
					r_socket.SetBelong(this.instance);
				}
				return r_socket;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketOperation operation
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
		/// System.Exception DelayedException
		/// </summary>
		protected RSystem.RException r_DelayedException;
		public virtual RSystem.RException RDelayedException
		{
			get
			{
				if(r_DelayedException == null)
				{
					r_DelayedException = new(this, "DelayedException");
					r_DelayedException.SetBelong(this.instance);
				}
				return r_DelayedException;
			}
		}

		/// <summary>
		/// System.Net.EndPoint EndPoint
		/// </summary>
		protected RSystem.RNet.REndPoint r_EndPoint;
		public virtual RSystem.RNet.REndPoint REndPoint
		{
			get
			{
				if(r_EndPoint == null)
				{
					r_EndPoint = new(this, "EndPoint");
					r_EndPoint.SetBelong(this.instance);
				}
				return r_EndPoint;
			}
		}

		/// <summary>
		/// System.Memory`1[System.Byte] Buffer
		/// </summary>
		protected RSystem.RMemory<RField> r_Buffer;
		public virtual RSystem.RMemory<RField> RBuffer
		{
			get
			{
				if(r_Buffer == null)
				{
					r_Buffer = new(this, "Buffer");
					r_Buffer.SetBelong(this.instance);
				}
				return r_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 Offset
		/// </summary>
		protected RField r_Offset;
		public virtual RField ROffset
		{
			get
			{
				if(r_Offset == null)
				{
					r_Offset = new(this, "Offset");
					r_Offset.SetBelong(this.instance);
				}
				return r_Offset;
			}
		}

		/// <summary>
		/// System.Int32 Size
		/// </summary>
		protected RField r_Size;
		public virtual RField RSize
		{
			get
			{
				if(r_Size == null)
				{
					r_Size = new(this, "Size");
					r_Size.SetBelong(this.instance);
				}
				return r_Size;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketFlags SockFlags
		/// </summary>
		protected RField r_SockFlags;
		public virtual RField RSockFlags
		{
			get
			{
				if(r_SockFlags == null)
				{
					r_SockFlags = new(this, "SockFlags");
					r_SockFlags.SetBelong(this.instance);
				}
				return r_SockFlags;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket AcceptSocket
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r_AcceptSocket;
		public virtual RSystem.RNet.RSockets.RSocket RAcceptSocket
		{
			get
			{
				if(r_AcceptSocket == null)
				{
					r_AcceptSocket = new(this, "AcceptSocket");
					r_AcceptSocket.SetBelong(this.instance);
				}
				return r_AcceptSocket;
			}
		}

		/// <summary>
		/// System.Net.IPAddress[] Addresses
		/// </summary>
		protected RFieldArray<RSystem.RNet.RIPAddress> r_Addresses;
		public virtual RFieldArray<RSystem.RNet.RIPAddress> RAddresses
		{
			get
			{
				if(r_Addresses == null)
				{
					r_Addresses = new(this, "Addresses");
					r_Addresses.SetBelong(this.instance);
				}
				return r_Addresses;
			}
		}

		/// <summary>
		/// System.Int32 Port
		/// </summary>
		protected RField r_Port;
		public virtual RField RPort
		{
			get
			{
				if(r_Port == null)
				{
					r_Port = new(this, "Port");
					r_Port.SetBelong(this.instance);
				}
				return r_Port;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]] Buffers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RArraySegment<RField>> r_Buffers;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RArraySegment<RField>> RBuffers
		{
			get
			{
				if(r_Buffers == null)
				{
					r_Buffers = new(this, "Buffers");
					r_Buffers.SetBelong(this.instance);
				}
				return r_Buffers;
			}
		}

		/// <summary>
		/// System.Boolean ReuseSocket
		/// </summary>
		protected RField r_ReuseSocket;
		public virtual RField ReuseSocket
		{
			get
			{
				if(r_ReuseSocket == null)
				{
					r_ReuseSocket = new(this, "ReuseSocket");
					r_ReuseSocket.SetBelong(this.instance);
				}
				return r_ReuseSocket;
			}
		}

		/// <summary>
		/// System.Int32 CurrentAddress
		/// </summary>
		protected RField r_CurrentAddress;
		public virtual RField RCurrentAddress
		{
			get
			{
				if(r_CurrentAddress == null)
				{
					r_CurrentAddress = new(this, "CurrentAddress");
					r_CurrentAddress.SetBelong(this.instance);
				}
				return r_CurrentAddress;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket AcceptedSocket
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r_AcceptedSocket;
		public virtual RSystem.RNet.RSockets.RSocket RAcceptedSocket
		{
			get
			{
				if(r_AcceptedSocket == null)
				{
					r_AcceptedSocket = new(this, "AcceptedSocket");
					r_AcceptedSocket.SetBelong(this.instance);
				}
				return r_AcceptedSocket;
			}
		}

		/// <summary>
		/// System.Int32 Total
		/// </summary>
		protected RField r_Total;
		public virtual RField RTotal
		{
			get
			{
				if(r_Total == null)
				{
					r_Total = new(this, "Total");
					r_Total.SetBelong(this.instance);
				}
				return r_Total;
			}
		}

		/// <summary>
		/// System.Int32 error
		/// </summary>
		protected RField r_error;
		public virtual RField Rerror
		{
			get
			{
				if(r_error == null)
				{
					r_error = new(this, "error");
					r_error.SetBelong(this.instance);
				}
				return r_error;
			}
		}

		/// <summary>
		/// System.Int32 EndCalled
		/// </summary>
		protected RField r_EndCalled;
		public virtual RField REndCalled
		{
			get
			{
				if(r_EndCalled == null)
				{
					r_EndCalled = new(this, "EndCalled");
					r_EndCalled.SetBelong(this.instance);
				}
				return r_EndCalled;
			}
		}

		/// <summary>
		/// IntPtr Handle
		/// </summary>
		protected RProperty r_Handle;
		public virtual RProperty RHandle
		{
			get
			{
				if(r_Handle == null)
				{
					r_Handle = new(this, "Handle", -1);
					r_Handle.SetBelong(this.instance);
				}
				return r_Handle;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketError ErrorCode
		/// </summary>
		protected RProperty r_ErrorCode;
		public virtual RProperty RErrorCode
		{
			get
			{
				if(r_ErrorCode == null)
				{
					r_ErrorCode = new(this, "ErrorCode", -1);
					r_ErrorCode.SetBelong(this.instance);
				}
				return r_ErrorCode;
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
		/// Void Init(System.Net.Sockets.Socket, System.AsyncCallback, System.Object, System.Net.Sockets.SocketOperation)
		/// </summary>
		protected RMethod r_RInit_Socket_AsyncCallback_Object_SocketOperation;
		public virtual RMethod RInit_Socket_AsyncCallback_Object_SocketOperation
		{
			get
			{
				if(r_RInit_Socket_AsyncCallback_Object_SocketOperation == null)
				{
					r_RInit_Socket_AsyncCallback_Object_SocketOperation = new(this, "Init", 0, typeof(System.Net.Sockets.Socket), typeof(System.AsyncCallback), typeof(System.Object),  ReleactionUtils.GetType("System.Net.Sockets.SocketOperation"));
					r_RInit_Socket_AsyncCallback_Object_SocketOperation.SetBelong(this.instance);
				}
				return r_RInit_Socket_AsyncCallback_Object_SocketOperation;
			}
		}

		/// <summary>
		/// Void CheckIfThrowDelayedException()
		/// </summary>
		protected RMethod r_RCheckIfThrowDelayedException;
		public virtual RMethod RCheckIfThrowDelayedException
		{
			get
			{
				if(r_RCheckIfThrowDelayedException == null)
				{
					r_RCheckIfThrowDelayedException = new(this, "CheckIfThrowDelayedException", 0);
					r_RCheckIfThrowDelayedException.SetBelong(this.instance);
				}
				return r_RCheckIfThrowDelayedException;
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
		/// Void Complete()
		/// </summary>
		protected RMethod r_RComplete;
		public virtual RMethod RComplete
		{
			get
			{
				if(r_RComplete == null)
				{
					r_RComplete = new(this, "Complete", 0);
					r_RComplete.SetBelong(this.instance);
				}
				return r_RComplete;
			}
		}

		/// <summary>
		/// Void Complete(Boolean)
		/// </summary>
		protected RMethod r_RComplete_Boolean;
		public virtual RMethod RComplete_Boolean
		{
			get
			{
				if(r_RComplete_Boolean == null)
				{
					r_RComplete_Boolean = new(this, "Complete", 0, typeof(System.Boolean));
					r_RComplete_Boolean.SetBelong(this.instance);
				}
				return r_RComplete_Boolean;
			}
		}

		/// <summary>
		/// Void Complete(Int32)
		/// </summary>
		protected RMethod r_RComplete_Int32;
		public virtual RMethod RComplete_Int32
		{
			get
			{
				if(r_RComplete_Int32 == null)
				{
					r_RComplete_Int32 = new(this, "Complete", 0, typeof(System.Int32));
					r_RComplete_Int32.SetBelong(this.instance);
				}
				return r_RComplete_Int32;
			}
		}

		/// <summary>
		/// Void Complete(System.Exception, Boolean)
		/// </summary>
		protected RMethod r_RComplete_Exception_Boolean;
		public virtual RMethod RComplete_Exception_Boolean
		{
			get
			{
				if(r_RComplete_Exception_Boolean == null)
				{
					r_RComplete_Exception_Boolean = new(this, "Complete", 0, typeof(System.Exception), typeof(System.Boolean));
					r_RComplete_Exception_Boolean.SetBelong(this.instance);
				}
				return r_RComplete_Exception_Boolean;
			}
		}

		/// <summary>
		/// Void Complete(System.Exception)
		/// </summary>
		protected RMethod r_RComplete_Exception;
		public virtual RMethod RComplete_Exception
		{
			get
			{
				if(r_RComplete_Exception == null)
				{
					r_RComplete_Exception = new(this, "Complete", 0, typeof(System.Exception));
					r_RComplete_Exception.SetBelong(this.instance);
				}
				return r_RComplete_Exception;
			}
		}

		/// <summary>
		/// Void Complete(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RComplete_Socket;
		public virtual RMethod RComplete_Socket
		{
			get
			{
				if(r_RComplete_Socket == null)
				{
					r_RComplete_Socket = new(this, "Complete", 0, typeof(System.Net.Sockets.Socket));
					r_RComplete_Socket.SetBelong(this.instance);
				}
				return r_RComplete_Socket;
			}
		}

		/// <summary>
		/// Void Complete(System.Net.Sockets.Socket, Int32)
		/// </summary>
		protected RMethod r_RComplete_Socket_Int32;
		public virtual RMethod RComplete_Socket_Int32
		{
			get
			{
				if(r_RComplete_Socket_Int32 == null)
				{
					r_RComplete_Socket_Int32 = new(this, "Complete", 0, typeof(System.Net.Sockets.Socket), typeof(System.Int32));
					r_RComplete_Socket_Int32.SetBelong(this.instance);
				}
				return r_RComplete_Socket_Int32;
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


        public RSocketAsyncResult() : base("System.Net.Sockets.SocketAsyncResult")
        {
        }

        public RSocketAsyncResult(System.Object instance) : base("System.Net.Sockets.SocketAsyncResult")
		{
            SetInstance(instance);
		}

        public RSocketAsyncResult(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSocketAsyncResult(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual void CheckIfThrowDelayedException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckIfThrowDelayedException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteDisposed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteDisposed.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Complete()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RComplete.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Complete(System.Boolean  @synch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@synch};
            var ___result = RComplete_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Complete(System.Int32  @total)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@total};
            var ___result = RComplete_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Complete(System.Exception  @e, System.Boolean  @synch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @synch};
            var ___result = RComplete_Exception_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Complete(System.Exception  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RComplete_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Complete(System.Net.Sockets.Socket  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RComplete_Socket.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Complete(System.Net.Sockets.Socket  @s, System.Int32  @total)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @total};
            var ___result = RComplete_Socket_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(System.AsyncCallback  @async_callback, System.Object  @async_state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@async_callback, @async_state};
            var ___result = RInit_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            
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
