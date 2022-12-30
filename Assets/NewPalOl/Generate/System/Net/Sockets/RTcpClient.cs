using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.TcpClient
	/// </summary>
    public partial class RTcpClient : RMember //
    {

		/// <summary>
		/// System.Net.Sockets.Socket m_ClientSocket
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r_m_ClientSocket;
		public virtual RSystem.RNet.RSockets.RSocket Rm_ClientSocket
		{
			get
			{
				if(r_m_ClientSocket == null)
				{
					r_m_ClientSocket = new(this, "m_ClientSocket");
					r_m_ClientSocket.SetBelong(this.instance);
				}
				return r_m_ClientSocket;
			}
		}

		/// <summary>
		/// System.Boolean m_Active
		/// </summary>
		protected RField r_m_Active;
		public virtual RField Rm_Active
		{
			get
			{
				if(r_m_Active == null)
				{
					r_m_Active = new(this, "m_Active");
					r_m_Active.SetBelong(this.instance);
				}
				return r_m_Active;
			}
		}

		/// <summary>
		/// System.Net.Sockets.NetworkStream m_DataStream
		/// </summary>
		protected RSystem.RNet.RSockets.RNetworkStream r_m_DataStream;
		public virtual RSystem.RNet.RSockets.RNetworkStream Rm_DataStream
		{
			get
			{
				if(r_m_DataStream == null)
				{
					r_m_DataStream = new(this, "m_DataStream");
					r_m_DataStream.SetBelong(this.instance);
				}
				return r_m_DataStream;
			}
		}

		/// <summary>
		/// System.Net.Sockets.AddressFamily m_Family
		/// </summary>
		protected RField r_m_Family;
		public virtual RField Rm_Family
		{
			get
			{
				if(r_m_Family == null)
				{
					r_m_Family = new(this, "m_Family");
					r_m_Family.SetBelong(this.instance);
				}
				return r_m_Family;
			}
		}

		/// <summary>
		/// System.Boolean m_CleanedUp
		/// </summary>
		protected RField r_m_CleanedUp;
		public virtual RField Rm_CleanedUp
		{
			get
			{
				if(r_m_CleanedUp == null)
				{
					r_m_CleanedUp = new(this, "m_CleanedUp");
					r_m_CleanedUp.SetBelong(this.instance);
				}
				return r_m_CleanedUp;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket Client
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r_Client;
		public virtual RSystem.RNet.RSockets.RSocket RClient
		{
			get
			{
				if(r_Client == null)
				{
					r_Client = new(this, "Client", -1);
					r_Client.SetBelong(this.instance);
				}
				return r_Client;
			}
		}

		/// <summary>
		/// Boolean Active
		/// </summary>
		protected RProperty r_Active;
		public virtual RProperty RActive
		{
			get
			{
				if(r_Active == null)
				{
					r_Active = new(this, "Active", -1);
					r_Active.SetBelong(this.instance);
				}
				return r_Active;
			}
		}

		/// <summary>
		/// Int32 Available
		/// </summary>
		protected RProperty r_Available;
		public virtual RProperty RAvailable
		{
			get
			{
				if(r_Available == null)
				{
					r_Available = new(this, "Available", -1);
					r_Available.SetBelong(this.instance);
				}
				return r_Available;
			}
		}

		/// <summary>
		/// Boolean Connected
		/// </summary>
		protected RProperty r_Connected;
		public virtual RProperty RConnected
		{
			get
			{
				if(r_Connected == null)
				{
					r_Connected = new(this, "Connected", -1);
					r_Connected.SetBelong(this.instance);
				}
				return r_Connected;
			}
		}

		/// <summary>
		/// Boolean ExclusiveAddressUse
		/// </summary>
		protected RProperty r_ExclusiveAddressUse;
		public virtual RProperty RExclusiveAddressUse
		{
			get
			{
				if(r_ExclusiveAddressUse == null)
				{
					r_ExclusiveAddressUse = new(this, "ExclusiveAddressUse", -1);
					r_ExclusiveAddressUse.SetBelong(this.instance);
				}
				return r_ExclusiveAddressUse;
			}
		}

		/// <summary>
		/// Int32 ReceiveBufferSize
		/// </summary>
		protected RProperty r_ReceiveBufferSize;
		public virtual RProperty ReceiveBufferSize
		{
			get
			{
				if(r_ReceiveBufferSize == null)
				{
					r_ReceiveBufferSize = new(this, "ReceiveBufferSize", -1);
					r_ReceiveBufferSize.SetBelong(this.instance);
				}
				return r_ReceiveBufferSize;
			}
		}

		/// <summary>
		/// Int32 SendBufferSize
		/// </summary>
		protected RProperty r_SendBufferSize;
		public virtual RProperty RSendBufferSize
		{
			get
			{
				if(r_SendBufferSize == null)
				{
					r_SendBufferSize = new(this, "SendBufferSize", -1);
					r_SendBufferSize.SetBelong(this.instance);
				}
				return r_SendBufferSize;
			}
		}

		/// <summary>
		/// Int32 ReceiveTimeout
		/// </summary>
		protected RProperty r_ReceiveTimeout;
		public virtual RProperty ReceiveTimeout
		{
			get
			{
				if(r_ReceiveTimeout == null)
				{
					r_ReceiveTimeout = new(this, "ReceiveTimeout", -1);
					r_ReceiveTimeout.SetBelong(this.instance);
				}
				return r_ReceiveTimeout;
			}
		}

		/// <summary>
		/// Int32 SendTimeout
		/// </summary>
		protected RProperty r_SendTimeout;
		public virtual RProperty RSendTimeout
		{
			get
			{
				if(r_SendTimeout == null)
				{
					r_SendTimeout = new(this, "SendTimeout", -1);
					r_SendTimeout.SetBelong(this.instance);
				}
				return r_SendTimeout;
			}
		}

		/// <summary>
		/// System.Net.Sockets.LingerOption LingerState
		/// </summary>
		protected RSystem.RNet.RSockets.RLingerOption r_LingerState;
		public virtual RSystem.RNet.RSockets.RLingerOption RLingerState
		{
			get
			{
				if(r_LingerState == null)
				{
					r_LingerState = new(this, "LingerState", -1);
					r_LingerState.SetBelong(this.instance);
				}
				return r_LingerState;
			}
		}

		/// <summary>
		/// Boolean NoDelay
		/// </summary>
		protected RProperty r_NoDelay;
		public virtual RProperty RNoDelay
		{
			get
			{
				if(r_NoDelay == null)
				{
					r_NoDelay = new(this, "NoDelay", -1);
					r_NoDelay.SetBelong(this.instance);
				}
				return r_NoDelay;
			}
		}

		/// <summary>
		/// Void Connect(System.String, Int32)
		/// </summary>
		protected RMethod r_RConnect_String_Int32;
		public virtual RMethod RConnect_String_Int32
		{
			get
			{
				if(r_RConnect_String_Int32 == null)
				{
					r_RConnect_String_Int32 = new(this, "Connect", 0, typeof(System.String), typeof(System.Int32));
					r_RConnect_String_Int32.SetBelong(this.instance);
				}
				return r_RConnect_String_Int32;
			}
		}

		/// <summary>
		/// Void Connect(System.Net.IPAddress, Int32)
		/// </summary>
		protected RMethod r_RConnect_IPAddress_Int32;
		public virtual RMethod RConnect_IPAddress_Int32
		{
			get
			{
				if(r_RConnect_IPAddress_Int32 == null)
				{
					r_RConnect_IPAddress_Int32 = new(this, "Connect", 0, typeof(System.Net.IPAddress), typeof(System.Int32));
					r_RConnect_IPAddress_Int32.SetBelong(this.instance);
				}
				return r_RConnect_IPAddress_Int32;
			}
		}

		/// <summary>
		/// Void Connect(System.Net.IPEndPoint)
		/// </summary>
		protected RMethod r_RConnect_IPEndPoint;
		public virtual RMethod RConnect_IPEndPoint
		{
			get
			{
				if(r_RConnect_IPEndPoint == null)
				{
					r_RConnect_IPEndPoint = new(this, "Connect", 0, typeof(System.Net.IPEndPoint));
					r_RConnect_IPEndPoint.SetBelong(this.instance);
				}
				return r_RConnect_IPEndPoint;
			}
		}

		/// <summary>
		/// Void Connect(System.Net.IPAddress[], Int32)
		/// </summary>
		protected RMethod r_RConnect_IPAddressArray_Int32;
		public virtual RMethod RConnect_IPAddressArray_Int32
		{
			get
			{
				if(r_RConnect_IPAddressArray_Int32 == null)
				{
					r_RConnect_IPAddressArray_Int32 = new(this, "Connect", 0, typeof(System.Net.IPAddress).MakeArrayType(), typeof(System.Int32));
					r_RConnect_IPAddressArray_Int32.SetBelong(this.instance);
				}
				return r_RConnect_IPAddressArray_Int32;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginConnect(System.String, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginConnect_String_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginConnect_String_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginConnect_String_Int32_AsyncCallback_Object == null)
				{
					r_RBeginConnect_String_Int32_AsyncCallback_Object = new(this, "BeginConnect", 0, typeof(System.String), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginConnect_String_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginConnect_String_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginConnect(System.Net.IPAddress, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginConnect_IPAddress_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginConnect_IPAddress_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginConnect_IPAddress_Int32_AsyncCallback_Object == null)
				{
					r_RBeginConnect_IPAddress_Int32_AsyncCallback_Object = new(this, "BeginConnect", 0, typeof(System.Net.IPAddress), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginConnect_IPAddress_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginConnect_IPAddress_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginConnect(System.Net.IPAddress[], Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginConnect_IPAddressArray_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginConnect_IPAddressArray_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginConnect_IPAddressArray_Int32_AsyncCallback_Object == null)
				{
					r_RBeginConnect_IPAddressArray_Int32_AsyncCallback_Object = new(this, "BeginConnect", 0, typeof(System.Net.IPAddress).MakeArrayType(), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginConnect_IPAddressArray_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginConnect_IPAddressArray_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void EndConnect(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndConnect_IAsyncResult;
		public virtual RMethod REndConnect_IAsyncResult
		{
			get
			{
				if(r_REndConnect_IAsyncResult == null)
				{
					r_REndConnect_IAsyncResult = new(this, "EndConnect", 0, typeof(System.IAsyncResult));
					r_REndConnect_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndConnect_IAsyncResult;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress, Int32)
		/// </summary>
		protected RMethod r_RConnectAsync_IPAddress_Int32;
		public virtual RMethod RConnectAsync_IPAddress_Int32
		{
			get
			{
				if(r_RConnectAsync_IPAddress_Int32 == null)
				{
					r_RConnectAsync_IPAddress_Int32 = new(this, "ConnectAsync", 0, typeof(System.Net.IPAddress), typeof(System.Int32));
					r_RConnectAsync_IPAddress_Int32.SetBelong(this.instance);
				}
				return r_RConnectAsync_IPAddress_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ConnectAsync(System.String, Int32)
		/// </summary>
		protected RMethod r_RConnectAsync_String_Int32;
		public virtual RMethod RConnectAsync_String_Int32
		{
			get
			{
				if(r_RConnectAsync_String_Int32 == null)
				{
					r_RConnectAsync_String_Int32 = new(this, "ConnectAsync", 0, typeof(System.String), typeof(System.Int32));
					r_RConnectAsync_String_Int32.SetBelong(this.instance);
				}
				return r_RConnectAsync_String_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[], Int32)
		/// </summary>
		protected RMethod r_RConnectAsync_IPAddressArray_Int32;
		public virtual RMethod RConnectAsync_IPAddressArray_Int32
		{
			get
			{
				if(r_RConnectAsync_IPAddressArray_Int32 == null)
				{
					r_RConnectAsync_IPAddressArray_Int32 = new(this, "ConnectAsync", 0, typeof(System.Net.IPAddress).MakeArrayType(), typeof(System.Int32));
					r_RConnectAsync_IPAddressArray_Int32.SetBelong(this.instance);
				}
				return r_RConnectAsync_IPAddressArray_Int32;
			}
		}

		/// <summary>
		/// System.Net.Sockets.NetworkStream GetStream()
		/// </summary>
		protected RMethod r_RGetStream;
		public virtual RMethod RGetStream
		{
			get
			{
				if(r_RGetStream == null)
				{
					r_RGetStream = new(this, "GetStream", 0);
					r_RGetStream.SetBelong(this.instance);
				}
				return r_RGetStream;
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
		/// Void initialize()
		/// </summary>
		protected RMethod r_Rinitialize;
		public virtual RMethod Rinitialize
		{
			get
			{
				if(r_Rinitialize == null)
				{
					r_Rinitialize = new(this, "initialize", 0);
					r_Rinitialize.SetBelong(this.instance);
				}
				return r_Rinitialize;
			}
		}

		/// <summary>
		/// Int32 numericOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName)
		/// </summary>
		protected RMethod r_RnumericOption_SocketOptionLevel_SocketOptionName;
		public virtual RMethod RnumericOption_SocketOptionLevel_SocketOptionName
		{
			get
			{
				if(r_RnumericOption_SocketOptionLevel_SocketOptionName == null)
				{
					r_RnumericOption_SocketOptionLevel_SocketOptionName = new(this, "numericOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName));
					r_RnumericOption_SocketOptionLevel_SocketOptionName.SetBelong(this.instance);
				}
				return r_RnumericOption_SocketOptionLevel_SocketOptionName;
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


        public RTcpClient() : base("System.Net.Sockets.TcpClient")
        {
        }

        public RTcpClient(System.Object instance) : base("System.Net.Sockets.TcpClient")
		{
            SetInstance(instance);
		}

        public RTcpClient(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTcpClient(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Connect(System.String  @hostname, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hostname, @port};
            var ___result = RConnect_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Connect(System.Net.IPAddress  @address, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @port};
            var ___result = RConnect_IPAddress_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Connect(System.Net.IPEndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@remoteEP};
            var ___result = RConnect_IPEndPoint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Connect(System.Net.IPAddress[]  @ipAddresses, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ipAddresses, @port};
            var ___result = RConnect_IPAddressArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginConnect(System.String  @host, System.Int32  @port, System.AsyncCallback  @requestCallback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host, @port, @requestCallback, @state};
            var ___result = RBeginConnect_String_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginConnect(System.Net.IPAddress  @address, System.Int32  @port, System.AsyncCallback  @requestCallback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @port, @requestCallback, @state};
            var ___result = RBeginConnect_IPAddress_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginConnect(System.Net.IPAddress[]  @addresses, System.Int32  @port, System.AsyncCallback  @requestCallback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@addresses, @port, @requestCallback, @state};
            var ___result = RBeginConnect_IPAddressArray_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual void EndConnect(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndConnect_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress  @address, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @port};
            var ___result = RConnectAsync_IPAddress_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ConnectAsync(System.String  @host, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host, @port};
            var ___result = RConnectAsync_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[]  @addresses, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@addresses, @port};
            var ___result = RConnectAsync_IPAddressArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Net.Sockets.NetworkStream GetStream()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStream.Invoke(___genericsType, ___parameters);

            return (System.Net.Sockets.NetworkStream)___result;
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rinitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 numericOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName};
            var ___result = RnumericOption_SocketOptionLevel_SocketOptionName.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
