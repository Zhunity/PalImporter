using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.MultipleConnectAsync
	/// </summary>
    public partial class RMultipleConnectAsync : RMember //
    {

		/// <summary>
		/// System.Net.Sockets.SocketAsyncEventArgs _userArgs
		/// </summary>
		protected RSystem.RNet.RSockets.RSocketAsyncEventArgs r__userArgs;
		public virtual RSystem.RNet.RSockets.RSocketAsyncEventArgs R_userArgs
		{
			get
			{
				if(r__userArgs == null)
				{
					r__userArgs = new(this, "_userArgs");
					r__userArgs.SetBelong(this.instance);
				}
				return r__userArgs;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketAsyncEventArgs _internalArgs
		/// </summary>
		protected RSystem.RNet.RSockets.RSocketAsyncEventArgs r__internalArgs;
		public virtual RSystem.RNet.RSockets.RSocketAsyncEventArgs R_internalArgs
		{
			get
			{
				if(r__internalArgs == null)
				{
					r__internalArgs = new(this, "_internalArgs");
					r__internalArgs.SetBelong(this.instance);
				}
				return r__internalArgs;
			}
		}

		/// <summary>
		/// System.Net.DnsEndPoint _endPoint
		/// </summary>
		protected RSystem.RNet.RDnsEndPoint r__endPoint;
		public virtual RSystem.RNet.RDnsEndPoint R_endPoint
		{
			get
			{
				if(r__endPoint == null)
				{
					r__endPoint = new(this, "_endPoint");
					r__endPoint.SetBelong(this.instance);
				}
				return r__endPoint;
			}
		}

		/// <summary>
		/// System.Net.IPAddress[] _addressList
		/// </summary>
		protected RFieldArray<RSystem.RNet.RIPAddress> r__addressList;
		public virtual RFieldArray<RSystem.RNet.RIPAddress> R_addressList
		{
			get
			{
				if(r__addressList == null)
				{
					r__addressList = new(this, "_addressList");
					r__addressList.SetBelong(this.instance);
				}
				return r__addressList;
			}
		}

		/// <summary>
		/// System.Int32 _nextAddress
		/// </summary>
		protected RField r__nextAddress;
		public virtual RField R_nextAddress
		{
			get
			{
				if(r__nextAddress == null)
				{
					r__nextAddress = new(this, "_nextAddress");
					r__nextAddress.SetBelong(this.instance);
				}
				return r__nextAddress;
			}
		}

		/// <summary>
		/// System.Net.Sockets.MultipleConnectAsync+State _state
		/// </summary>
		protected RField r__state;
		public virtual RField R_state
		{
			get
			{
				if(r__state == null)
				{
					r__state = new(this, "_state");
					r__state.SetBelong(this.instance);
				}
				return r__state;
			}
		}

		/// <summary>
		/// System.Object _lockObject
		/// </summary>
		protected RSystem.RObject r__lockObject;
		public virtual RSystem.RObject R_lockObject
		{
			get
			{
				if(r__lockObject == null)
				{
					r__lockObject = new(this, "_lockObject");
					r__lockObject.SetBelong(this.instance);
				}
				return r__lockObject;
			}
		}

		/// <summary>
		/// Boolean StartConnectAsync(System.Net.Sockets.SocketAsyncEventArgs, System.Net.DnsEndPoint)
		/// </summary>
		protected RMethod r_RStartConnectAsync_SocketAsyncEventArgs_DnsEndPoint;
		public virtual RMethod RStartConnectAsync_SocketAsyncEventArgs_DnsEndPoint
		{
			get
			{
				if(r_RStartConnectAsync_SocketAsyncEventArgs_DnsEndPoint == null)
				{
					r_RStartConnectAsync_SocketAsyncEventArgs_DnsEndPoint = new(this, "StartConnectAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs), typeof(System.Net.DnsEndPoint));
					r_RStartConnectAsync_SocketAsyncEventArgs_DnsEndPoint.SetBelong(this.instance);
				}
				return r_RStartConnectAsync_SocketAsyncEventArgs_DnsEndPoint;
			}
		}

		/// <summary>
		/// Void DnsCallback(System.IAsyncResult)
		/// </summary>
		protected RMethod r_RDnsCallback_IAsyncResult;
		public virtual RMethod RDnsCallback_IAsyncResult
		{
			get
			{
				if(r_RDnsCallback_IAsyncResult == null)
				{
					r_RDnsCallback_IAsyncResult = new(this, "DnsCallback", 0, typeof(System.IAsyncResult));
					r_RDnsCallback_IAsyncResult.SetBelong(this.instance);
				}
				return r_RDnsCallback_IAsyncResult;
			}
		}

		/// <summary>
		/// Boolean DoDnsCallback(System.IAsyncResult, Boolean)
		/// </summary>
		protected RMethod r_RDoDnsCallback_IAsyncResult_Boolean;
		public virtual RMethod RDoDnsCallback_IAsyncResult_Boolean
		{
			get
			{
				if(r_RDoDnsCallback_IAsyncResult_Boolean == null)
				{
					r_RDoDnsCallback_IAsyncResult_Boolean = new(this, "DoDnsCallback", 0, typeof(System.IAsyncResult), typeof(System.Boolean));
					r_RDoDnsCallback_IAsyncResult_Boolean.SetBelong(this.instance);
				}
				return r_RDoDnsCallback_IAsyncResult_Boolean;
			}
		}

		/// <summary>
		/// Void InternalConnectCallback(System.Object, System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RInternalConnectCallback_Object_SocketAsyncEventArgs;
		public virtual RMethod RInternalConnectCallback_Object_SocketAsyncEventArgs
		{
			get
			{
				if(r_RInternalConnectCallback_Object_SocketAsyncEventArgs == null)
				{
					r_RInternalConnectCallback_Object_SocketAsyncEventArgs = new(this, "InternalConnectCallback", 0, typeof(System.Object), typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RInternalConnectCallback_Object_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RInternalConnectCallback_Object_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.Exception AttemptConnection()
		/// </summary>
		protected RMethod r_RAttemptConnection;
		public virtual RMethod RAttemptConnection
		{
			get
			{
				if(r_RAttemptConnection == null)
				{
					r_RAttemptConnection = new(this, "AttemptConnection", 0);
					r_RAttemptConnection.SetBelong(this.instance);
				}
				return r_RAttemptConnection;
			}
		}

		/// <summary>
		/// System.Exception AttemptConnection(System.Net.Sockets.Socket, System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RAttemptConnection_Socket_SocketAsyncEventArgs;
		public virtual RMethod RAttemptConnection_Socket_SocketAsyncEventArgs
		{
			get
			{
				if(r_RAttemptConnection_Socket_SocketAsyncEventArgs == null)
				{
					r_RAttemptConnection_Socket_SocketAsyncEventArgs = new(this, "AttemptConnection", 0, typeof(System.Net.Sockets.Socket), typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RAttemptConnection_Socket_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RAttemptConnection_Socket_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// Void OnSucceed()
		/// </summary>
		protected RMethod r_ROnSucceed;
		public virtual RMethod ROnSucceed
		{
			get
			{
				if(r_ROnSucceed == null)
				{
					r_ROnSucceed = new(this, "OnSucceed", 0);
					r_ROnSucceed.SetBelong(this.instance);
				}
				return r_ROnSucceed;
			}
		}

		/// <summary>
		/// Void Succeed()
		/// </summary>
		protected RMethod r_RSucceed;
		public virtual RMethod RSucceed
		{
			get
			{
				if(r_RSucceed == null)
				{
					r_RSucceed = new(this, "Succeed", 0);
					r_RSucceed.SetBelong(this.instance);
				}
				return r_RSucceed;
			}
		}

		/// <summary>
		/// Void OnFail(Boolean)
		/// </summary>
		protected RMethod r_ROnFail_Boolean;
		public virtual RMethod ROnFail_Boolean
		{
			get
			{
				if(r_ROnFail_Boolean == null)
				{
					r_ROnFail_Boolean = new(this, "OnFail", 0, typeof(System.Boolean));
					r_ROnFail_Boolean.SetBelong(this.instance);
				}
				return r_ROnFail_Boolean;
			}
		}

		/// <summary>
		/// Boolean Fail(Boolean, System.Exception)
		/// </summary>
		protected RMethod r_RFail_Boolean_Exception;
		public virtual RMethod RFail_Boolean_Exception
		{
			get
			{
				if(r_RFail_Boolean_Exception == null)
				{
					r_RFail_Boolean_Exception = new(this, "Fail", 0, typeof(System.Boolean), typeof(System.Exception));
					r_RFail_Boolean_Exception.SetBelong(this.instance);
				}
				return r_RFail_Boolean_Exception;
			}
		}

		/// <summary>
		/// Void SyncFail(System.Exception)
		/// </summary>
		protected RMethod r_RSyncFail_Exception;
		public virtual RMethod RSyncFail_Exception
		{
			get
			{
				if(r_RSyncFail_Exception == null)
				{
					r_RSyncFail_Exception = new(this, "SyncFail", 0, typeof(System.Exception));
					r_RSyncFail_Exception.SetBelong(this.instance);
				}
				return r_RSyncFail_Exception;
			}
		}

		/// <summary>
		/// Void AsyncFail(System.Exception)
		/// </summary>
		protected RMethod r_RAsyncFail_Exception;
		public virtual RMethod RAsyncFail_Exception
		{
			get
			{
				if(r_RAsyncFail_Exception == null)
				{
					r_RAsyncFail_Exception = new(this, "AsyncFail", 0, typeof(System.Exception));
					r_RAsyncFail_Exception.SetBelong(this.instance);
				}
				return r_RAsyncFail_Exception;
			}
		}

		/// <summary>
		/// Void Cancel()
		/// </summary>
		protected RMethod r_RCancel;
		public virtual RMethod RCancel
		{
			get
			{
				if(r_RCancel == null)
				{
					r_RCancel = new(this, "Cancel", 0);
					r_RCancel.SetBelong(this.instance);
				}
				return r_RCancel;
			}
		}

		/// <summary>
		/// Void CallAsyncFail(System.Object)
		/// </summary>
		protected RMethod r_RCallAsyncFail_Object;
		public virtual RMethod RCallAsyncFail_Object
		{
			get
			{
				if(r_RCallAsyncFail_Object == null)
				{
					r_RCallAsyncFail_Object = new(this, "CallAsyncFail", 0, typeof(System.Object));
					r_RCallAsyncFail_Object.SetBelong(this.instance);
				}
				return r_RCallAsyncFail_Object;
			}
		}

		/// <summary>
		/// System.Net.IPAddress GetNextAddress(System.Net.Sockets.Socket ByRef)
		/// </summary>
		protected RMethod r_RGetNextAddress_Out_Socket;
		public virtual RMethod RGetNextAddress_Out_Socket
		{
			get
			{
				if(r_RGetNextAddress_Out_Socket == null)
				{
					r_RGetNextAddress_Out_Socket = new(this, "GetNextAddress", 0, typeof(System.Net.Sockets.Socket).MakeByRefType());
					r_RGetNextAddress_Out_Socket.SetBelong(this.instance);
				}
				return r_RGetNextAddress_Out_Socket;
			}
		}

		/// <summary>
		/// Void <Cancel>b__20_0(System.Object)
		/// </summary>
		protected RMethod r_R__2__Cancel__4__b__20_0_Object;
		public virtual RMethod R__2__Cancel__4__b__20_0_Object
		{
			get
			{
				if(r_R__2__Cancel__4__b__20_0_Object == null)
				{
					r_R__2__Cancel__4__b__20_0_Object = new(this, "<Cancel>b__20_0", 0, typeof(System.Object));
					r_R__2__Cancel__4__b__20_0_Object.SetBelong(this.instance);
				}
				return r_R__2__Cancel__4__b__20_0_Object;
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


        public RMultipleConnectAsync() : base("System.Net.Sockets.MultipleConnectAsync")
        {
        }

        public RMultipleConnectAsync(System.Object instance) : base("System.Net.Sockets.MultipleConnectAsync")
		{
            SetInstance(instance);
		}

        public RMultipleConnectAsync(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMultipleConnectAsync(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean StartConnectAsync(System.Net.Sockets.SocketAsyncEventArgs  @args, System.Net.DnsEndPoint  @endPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@args, @endPoint};
            var ___result = RStartConnectAsync_SocketAsyncEventArgs_DnsEndPoint.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DnsCallback(System.IAsyncResult  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RDnsCallback_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DoDnsCallback(System.IAsyncResult  @result, System.Boolean  @sync)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result, @sync};
            var ___result = RDoDnsCallback_IAsyncResult_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InternalConnectCallback(System.Object  @sender, System.Net.Sockets.SocketAsyncEventArgs  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @args};
            var ___result = RInternalConnectCallback_Object_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception AttemptConnection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAttemptConnection.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception AttemptConnection(System.Net.Sockets.Socket  @attemptSocket, System.Net.Sockets.SocketAsyncEventArgs  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attemptSocket, @args};
            var ___result = RAttemptConnection_Socket_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void OnSucceed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnSucceed.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Succeed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSucceed.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnFail(System.Boolean  @abortive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@abortive};
            var ___result = ROnFail_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Fail(System.Boolean  @sync, System.Exception  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sync, @e};
            var ___result = RFail_Boolean_Exception.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SyncFail(System.Exception  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSyncFail_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AsyncFail(System.Exception  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RAsyncFail_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Cancel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCancel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CallAsyncFail(System.Object  @ignored)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ignored};
            var ___result = RCallAsyncFail_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Net.IPAddress GetNextAddress(out System.Net.Sockets.Socket  @attemptSocket)
        {
			attemptSocket = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@attemptSocket};
            var ___result = RGetNextAddress_Out_Socket.Invoke(___genericsType, ___parameters);
			attemptSocket = (System.Net.Sockets.Socket)___parameters[0];

            return (System.Net.IPAddress)___result;
        }


        public virtual void __2__Cancel__4__b__20_0(System.Object  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = R__2__Cancel__4__b__20_0_Object.Invoke(___genericsType, ___parameters);

            
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
