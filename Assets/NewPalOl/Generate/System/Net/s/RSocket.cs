using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.Socket
	/// </summary>
    public partial class RSocket : RMember //
    {

		/// <summary>
		/// System.EventHandler`1[System.Net.Sockets.SocketAsyncEventArgs] AcceptCompletedHandler
		/// </summary>
		protected static RSystem.REventHandler<RSystem.RNet.RSockets.RSocketAsyncEventArgs> r_AcceptCompletedHandler;
		public static RSystem.REventHandler<RSystem.RNet.RSockets.RSocketAsyncEventArgs> RAcceptCompletedHandler
		{
			get
			{
				if(r_AcceptCompletedHandler == null)
				{
					r_AcceptCompletedHandler = new(typeof(System.Net.Sockets.Socket), "AcceptCompletedHandler");
					r_AcceptCompletedHandler.SetBelong(null);
				}
				return r_AcceptCompletedHandler;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Net.Sockets.SocketAsyncEventArgs] ReceiveCompletedHandler
		/// </summary>
		protected static RSystem.REventHandler<RSystem.RNet.RSockets.RSocketAsyncEventArgs> r_ReceiveCompletedHandler;
		public static RSystem.REventHandler<RSystem.RNet.RSockets.RSocketAsyncEventArgs> ReceiveCompletedHandler
		{
			get
			{
				if(r_ReceiveCompletedHandler == null)
				{
					r_ReceiveCompletedHandler = new(typeof(System.Net.Sockets.Socket), "ReceiveCompletedHandler");
					r_ReceiveCompletedHandler.SetBelong(null);
				}
				return r_ReceiveCompletedHandler;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Net.Sockets.SocketAsyncEventArgs] SendCompletedHandler
		/// </summary>
		protected static RSystem.REventHandler<RSystem.RNet.RSockets.RSocketAsyncEventArgs> r_SendCompletedHandler;
		public static RSystem.REventHandler<RSystem.RNet.RSockets.RSocketAsyncEventArgs> RSendCompletedHandler
		{
			get
			{
				if(r_SendCompletedHandler == null)
				{
					r_SendCompletedHandler = new(typeof(System.Net.Sockets.Socket), "SendCompletedHandler");
					r_SendCompletedHandler.SetBelong(null);
				}
				return r_SendCompletedHandler;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1[System.Net.Sockets.Socket] s_rentedSocketSentinel
		/// </summary>
		protected static RSystem.RNet.RSockets.RSocket.RTaskSocketAsyncEventArgs<RSystem.RNet.RSockets.RSocket> r_s_rentedSocketSentinel;
		public static RSystem.RNet.RSockets.RSocket.RTaskSocketAsyncEventArgs<RSystem.RNet.RSockets.RSocket> Rs_rentedSocketSentinel
		{
			get
			{
				if(r_s_rentedSocketSentinel == null)
				{
					r_s_rentedSocketSentinel = new(typeof(System.Net.Sockets.Socket), "s_rentedSocketSentinel");
					r_s_rentedSocketSentinel.SetBelong(null);
				}
				return r_s_rentedSocketSentinel;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel
		/// </summary>
		protected static RSystem.RNet.RSockets.RSocket.RInt32TaskSocketAsyncEventArgs r_s_rentedInt32Sentinel;
		public static RSystem.RNet.RSockets.RSocket.RInt32TaskSocketAsyncEventArgs Rs_rentedInt32Sentinel
		{
			get
			{
				if(r_s_rentedInt32Sentinel == null)
				{
					r_s_rentedInt32Sentinel = new(typeof(System.Net.Sockets.Socket), "s_rentedInt32Sentinel");
					r_s_rentedInt32Sentinel.SetBelong(null);
				}
				return r_s_rentedInt32Sentinel;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] s_zeroTask
		/// </summary>
		protected static RSystem.RThreading.RTasks.RTask<RField> r_s_zeroTask;
		public static RSystem.RThreading.RTasks.RTask<RField> Rs_zeroTask
		{
			get
			{
				if(r_s_zeroTask == null)
				{
					r_s_zeroTask = new(typeof(System.Net.Sockets.Socket), "s_zeroTask");
					r_s_zeroTask.SetBelong(null);
				}
				return r_s_zeroTask;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket+CachedEventArgs _cachedTaskEventArgs
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket.RCachedEventArgs r__cachedTaskEventArgs;
		public virtual RSystem.RNet.RSockets.RSocket.RCachedEventArgs R_cachedTaskEventArgs
		{
			get
			{
				if(r__cachedTaskEventArgs == null)
				{
					r__cachedTaskEventArgs = new(this, "_cachedTaskEventArgs");
					r__cachedTaskEventArgs.SetBelong(this.instance);
				}
				return r__cachedTaskEventArgs;
			}
		}

		/// <summary>
		/// System.Object s_InternalSyncObject
		/// </summary>
		protected static RSystem.RObject r_s_InternalSyncObject;
		public static RSystem.RObject Rs_InternalSyncObject
		{
			get
			{
				if(r_s_InternalSyncObject == null)
				{
					r_s_InternalSyncObject = new(typeof(System.Net.Sockets.Socket), "s_InternalSyncObject");
					r_s_InternalSyncObject.SetBelong(null);
				}
				return r_s_InternalSyncObject;
			}
		}

		/// <summary>
		/// System.Boolean s_SupportsIPv4
		/// </summary>
		protected static RField r_s_SupportsIPv4;
		public static RField Rs_SupportsIPv4
		{
			get
			{
				if(r_s_SupportsIPv4 == null)
				{
					r_s_SupportsIPv4 = new(typeof(System.Net.Sockets.Socket), "s_SupportsIPv4");
					r_s_SupportsIPv4.SetBelong(null);
				}
				return r_s_SupportsIPv4;
			}
		}

		/// <summary>
		/// System.Boolean s_SupportsIPv6
		/// </summary>
		protected static RField r_s_SupportsIPv6;
		public static RField Rs_SupportsIPv6
		{
			get
			{
				if(r_s_SupportsIPv6 == null)
				{
					r_s_SupportsIPv6 = new(typeof(System.Net.Sockets.Socket), "s_SupportsIPv6");
					r_s_SupportsIPv6.SetBelong(null);
				}
				return r_s_SupportsIPv6;
			}
		}

		/// <summary>
		/// System.Boolean s_OSSupportsIPv6
		/// </summary>
		protected static RField r_s_OSSupportsIPv6;
		public static RField Rs_OSSupportsIPv6
		{
			get
			{
				if(r_s_OSSupportsIPv6 == null)
				{
					r_s_OSSupportsIPv6 = new(typeof(System.Net.Sockets.Socket), "s_OSSupportsIPv6");
					r_s_OSSupportsIPv6.SetBelong(null);
				}
				return r_s_OSSupportsIPv6;
			}
		}

		/// <summary>
		/// System.Boolean s_Initialized
		/// </summary>
		protected static RField r_s_Initialized;
		public static RField Rs_Initialized
		{
			get
			{
				if(r_s_Initialized == null)
				{
					r_s_Initialized = new(typeof(System.Net.Sockets.Socket), "s_Initialized");
					r_s_Initialized.SetBelong(null);
				}
				return r_s_Initialized;
			}
		}

		/// <summary>
		/// System.Boolean s_LoggingEnabled
		/// </summary>
		protected static RField r_s_LoggingEnabled;
		public static RField Rs_LoggingEnabled
		{
			get
			{
				if(r_s_LoggingEnabled == null)
				{
					r_s_LoggingEnabled = new(typeof(System.Net.Sockets.Socket), "s_LoggingEnabled");
					r_s_LoggingEnabled.SetBelong(null);
				}
				return r_s_LoggingEnabled;
			}
		}

		/// <summary>
		/// System.Boolean s_PerfCountersEnabled
		/// </summary>
		protected static RField r_s_PerfCountersEnabled;
		public static RField Rs_PerfCountersEnabled
		{
			get
			{
				if(r_s_PerfCountersEnabled == null)
				{
					r_s_PerfCountersEnabled = new(typeof(System.Net.Sockets.Socket), "s_PerfCountersEnabled");
					r_s_PerfCountersEnabled.SetBelong(null);
				}
				return r_s_PerfCountersEnabled;
			}
		}

		/// <summary>
		/// System.Int32 DefaultCloseTimeout
		/// </summary>
		protected static RField r_DefaultCloseTimeout;
		public static RField RDefaultCloseTimeout
		{
			get
			{
				if(r_DefaultCloseTimeout == null)
				{
					r_DefaultCloseTimeout = new(typeof(System.Net.Sockets.Socket), "DefaultCloseTimeout");
					r_DefaultCloseTimeout.SetBelong(null);
				}
				return r_DefaultCloseTimeout;
			}
		}

		/// <summary>
		/// System.Int32 SOCKET_CLOSED_CODE
		/// </summary>
		protected static RField r_SOCKET_CLOSED_CODE;
		public static RField RSOCKET_CLOSED_CODE
		{
			get
			{
				if(r_SOCKET_CLOSED_CODE == null)
				{
					r_SOCKET_CLOSED_CODE = new(typeof(System.Net.Sockets.Socket), "SOCKET_CLOSED_CODE");
					r_SOCKET_CLOSED_CODE.SetBelong(null);
				}
				return r_SOCKET_CLOSED_CODE;
			}
		}

		/// <summary>
		/// System.String TIMEOUT_EXCEPTION_MSG
		/// </summary>
		protected static RField r_TIMEOUT_EXCEPTION_MSG;
		public static RField RTIMEOUT_EXCEPTION_MSG
		{
			get
			{
				if(r_TIMEOUT_EXCEPTION_MSG == null)
				{
					r_TIMEOUT_EXCEPTION_MSG = new(typeof(System.Net.Sockets.Socket), "TIMEOUT_EXCEPTION_MSG");
					r_TIMEOUT_EXCEPTION_MSG.SetBelong(null);
				}
				return r_TIMEOUT_EXCEPTION_MSG;
			}
		}

		/// <summary>
		/// System.Boolean is_closed
		/// </summary>
		protected RField r_is_closed;
		public virtual RField Ris_closed
		{
			get
			{
				if(r_is_closed == null)
				{
					r_is_closed = new(this, "is_closed");
					r_is_closed.SetBelong(this.instance);
				}
				return r_is_closed;
			}
		}

		/// <summary>
		/// System.Boolean is_listening
		/// </summary>
		protected RField r_is_listening;
		public virtual RField Ris_listening
		{
			get
			{
				if(r_is_listening == null)
				{
					r_is_listening = new(this, "is_listening");
					r_is_listening.SetBelong(this.instance);
				}
				return r_is_listening;
			}
		}

		/// <summary>
		/// System.Boolean useOverlappedIO
		/// </summary>
		protected RField r_useOverlappedIO;
		public virtual RField RuseOverlappedIO
		{
			get
			{
				if(r_useOverlappedIO == null)
				{
					r_useOverlappedIO = new(this, "useOverlappedIO");
					r_useOverlappedIO.SetBelong(this.instance);
				}
				return r_useOverlappedIO;
			}
		}

		/// <summary>
		/// System.Int32 linger_timeout
		/// </summary>
		protected RField r_linger_timeout;
		public virtual RField Rlinger_timeout
		{
			get
			{
				if(r_linger_timeout == null)
				{
					r_linger_timeout = new(this, "linger_timeout");
					r_linger_timeout.SetBelong(this.instance);
				}
				return r_linger_timeout;
			}
		}

		/// <summary>
		/// System.Net.Sockets.AddressFamily addressFamily
		/// </summary>
		protected RField r_addressFamily;
		public virtual RField RaddressFamily
		{
			get
			{
				if(r_addressFamily == null)
				{
					r_addressFamily = new(this, "addressFamily");
					r_addressFamily.SetBelong(this.instance);
				}
				return r_addressFamily;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketType socketType
		/// </summary>
		protected RField r_socketType;
		public virtual RField RsocketType
		{
			get
			{
				if(r_socketType == null)
				{
					r_socketType = new(this, "socketType");
					r_socketType.SetBelong(this.instance);
				}
				return r_socketType;
			}
		}

		/// <summary>
		/// System.Net.Sockets.ProtocolType protocolType
		/// </summary>
		protected RField r_protocolType;
		public virtual RField RprotocolType
		{
			get
			{
				if(r_protocolType == null)
				{
					r_protocolType = new(this, "protocolType");
					r_protocolType.SetBelong(this.instance);
				}
				return r_protocolType;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SafeSocketHandle m_Handle
		/// </summary>
		protected RSystem.RNet.RSockets.RSafeSocketHandle r_m_Handle;
		public virtual RSystem.RNet.RSockets.RSafeSocketHandle Rm_Handle
		{
			get
			{
				if(r_m_Handle == null)
				{
					r_m_Handle = new(this, "m_Handle");
					r_m_Handle.SetBelong(this.instance);
				}
				return r_m_Handle;
			}
		}

		/// <summary>
		/// System.Net.EndPoint seed_endpoint
		/// </summary>
		protected RSystem.RNet.REndPoint r_seed_endpoint;
		public virtual RSystem.RNet.REndPoint Rseed_endpoint
		{
			get
			{
				if(r_seed_endpoint == null)
				{
					r_seed_endpoint = new(this, "seed_endpoint");
					r_seed_endpoint.SetBelong(this.instance);
				}
				return r_seed_endpoint;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim ReadSem
		/// </summary>
		protected RSystem.RThreading.RSemaphoreSlim r_ReadSem;
		public virtual RSystem.RThreading.RSemaphoreSlim ReadSem
		{
			get
			{
				if(r_ReadSem == null)
				{
					r_ReadSem = new(this, "ReadSem");
					r_ReadSem.SetBelong(this.instance);
				}
				return r_ReadSem;
			}
		}

		/// <summary>
		/// System.Threading.SemaphoreSlim WriteSem
		/// </summary>
		protected RSystem.RThreading.RSemaphoreSlim r_WriteSem;
		public virtual RSystem.RThreading.RSemaphoreSlim RWriteSem
		{
			get
			{
				if(r_WriteSem == null)
				{
					r_WriteSem = new(this, "WriteSem");
					r_WriteSem.SetBelong(this.instance);
				}
				return r_WriteSem;
			}
		}

		/// <summary>
		/// System.Boolean is_blocking
		/// </summary>
		protected RField r_is_blocking;
		public virtual RField Ris_blocking
		{
			get
			{
				if(r_is_blocking == null)
				{
					r_is_blocking = new(this, "is_blocking");
					r_is_blocking.SetBelong(this.instance);
				}
				return r_is_blocking;
			}
		}

		/// <summary>
		/// System.Boolean is_bound
		/// </summary>
		protected RField r_is_bound;
		public virtual RField Ris_bound
		{
			get
			{
				if(r_is_bound == null)
				{
					r_is_bound = new(this, "is_bound");
					r_is_bound.SetBelong(this.instance);
				}
				return r_is_bound;
			}
		}

		/// <summary>
		/// System.Boolean is_connected
		/// </summary>
		protected RField r_is_connected;
		public virtual RField Ris_connected
		{
			get
			{
				if(r_is_connected == null)
				{
					r_is_connected = new(this, "is_connected");
					r_is_connected.SetBelong(this.instance);
				}
				return r_is_connected;
			}
		}

		/// <summary>
		/// System.Int32 m_IntCleanedUp
		/// </summary>
		protected RField r_m_IntCleanedUp;
		public virtual RField Rm_IntCleanedUp
		{
			get
			{
				if(r_m_IntCleanedUp == null)
				{
					r_m_IntCleanedUp = new(this, "m_IntCleanedUp");
					r_m_IntCleanedUp.SetBelong(this.instance);
				}
				return r_m_IntCleanedUp;
			}
		}

		/// <summary>
		/// System.Boolean connect_in_progress
		/// </summary>
		protected RField r_connect_in_progress;
		public virtual RField Rconnect_in_progress
		{
			get
			{
				if(r_connect_in_progress == null)
				{
					r_connect_in_progress = new(this, "connect_in_progress");
					r_connect_in_progress.SetBelong(this.instance);
				}
				return r_connect_in_progress;
			}
		}

		/// <summary>
		/// System.Int32 ID
		/// </summary>
		protected RField r_ID;
		public virtual RField RID
		{
			get
			{
				if(r_ID == null)
				{
					r_ID = new(this, "ID");
					r_ID.SetBelong(this.instance);
				}
				return r_ID;
			}
		}

		/// <summary>
		/// System.AsyncCallback AcceptAsyncCallback
		/// </summary>
		protected static RSystem.RAsyncCallback r_AcceptAsyncCallback;
		public static RSystem.RAsyncCallback RAcceptAsyncCallback
		{
			get
			{
				if(r_AcceptAsyncCallback == null)
				{
					r_AcceptAsyncCallback = new(typeof(System.Net.Sockets.Socket), "AcceptAsyncCallback");
					r_AcceptAsyncCallback.SetBelong(null);
				}
				return r_AcceptAsyncCallback;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback BeginAcceptCallback
		/// </summary>
		protected static RSystem.RIOAsyncCallback r_BeginAcceptCallback;
		public static RSystem.RIOAsyncCallback RBeginAcceptCallback
		{
			get
			{
				if(r_BeginAcceptCallback == null)
				{
					r_BeginAcceptCallback = new(typeof(System.Net.Sockets.Socket), "BeginAcceptCallback");
					r_BeginAcceptCallback.SetBelong(null);
				}
				return r_BeginAcceptCallback;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback BeginAcceptReceiveCallback
		/// </summary>
		protected static RSystem.RIOAsyncCallback r_BeginAcceptReceiveCallback;
		public static RSystem.RIOAsyncCallback RBeginAcceptReceiveCallback
		{
			get
			{
				if(r_BeginAcceptReceiveCallback == null)
				{
					r_BeginAcceptReceiveCallback = new(typeof(System.Net.Sockets.Socket), "BeginAcceptReceiveCallback");
					r_BeginAcceptReceiveCallback.SetBelong(null);
				}
				return r_BeginAcceptReceiveCallback;
			}
		}

		/// <summary>
		/// System.AsyncCallback ConnectAsyncCallback
		/// </summary>
		protected static RSystem.RAsyncCallback r_ConnectAsyncCallback;
		public static RSystem.RAsyncCallback RConnectAsyncCallback
		{
			get
			{
				if(r_ConnectAsyncCallback == null)
				{
					r_ConnectAsyncCallback = new(typeof(System.Net.Sockets.Socket), "ConnectAsyncCallback");
					r_ConnectAsyncCallback.SetBelong(null);
				}
				return r_ConnectAsyncCallback;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback BeginConnectCallback
		/// </summary>
		protected static RSystem.RIOAsyncCallback r_BeginConnectCallback;
		public static RSystem.RIOAsyncCallback RBeginConnectCallback
		{
			get
			{
				if(r_BeginConnectCallback == null)
				{
					r_BeginConnectCallback = new(typeof(System.Net.Sockets.Socket), "BeginConnectCallback");
					r_BeginConnectCallback.SetBelong(null);
				}
				return r_BeginConnectCallback;
			}
		}

		/// <summary>
		/// System.AsyncCallback DisconnectAsyncCallback
		/// </summary>
		protected static RSystem.RAsyncCallback r_DisconnectAsyncCallback;
		public static RSystem.RAsyncCallback RDisconnectAsyncCallback
		{
			get
			{
				if(r_DisconnectAsyncCallback == null)
				{
					r_DisconnectAsyncCallback = new(typeof(System.Net.Sockets.Socket), "DisconnectAsyncCallback");
					r_DisconnectAsyncCallback.SetBelong(null);
				}
				return r_DisconnectAsyncCallback;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback BeginDisconnectCallback
		/// </summary>
		protected static RSystem.RIOAsyncCallback r_BeginDisconnectCallback;
		public static RSystem.RIOAsyncCallback RBeginDisconnectCallback
		{
			get
			{
				if(r_BeginDisconnectCallback == null)
				{
					r_BeginDisconnectCallback = new(typeof(System.Net.Sockets.Socket), "BeginDisconnectCallback");
					r_BeginDisconnectCallback.SetBelong(null);
				}
				return r_BeginDisconnectCallback;
			}
		}

		/// <summary>
		/// System.AsyncCallback ReceiveAsyncCallback
		/// </summary>
		protected static RSystem.RAsyncCallback r_ReceiveAsyncCallback;
		public static RSystem.RAsyncCallback ReceiveAsyncCallback
		{
			get
			{
				if(r_ReceiveAsyncCallback == null)
				{
					r_ReceiveAsyncCallback = new(typeof(System.Net.Sockets.Socket), "ReceiveAsyncCallback");
					r_ReceiveAsyncCallback.SetBelong(null);
				}
				return r_ReceiveAsyncCallback;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback BeginReceiveCallback
		/// </summary>
		protected static RSystem.RIOAsyncCallback r_BeginReceiveCallback;
		public static RSystem.RIOAsyncCallback RBeginReceiveCallback
		{
			get
			{
				if(r_BeginReceiveCallback == null)
				{
					r_BeginReceiveCallback = new(typeof(System.Net.Sockets.Socket), "BeginReceiveCallback");
					r_BeginReceiveCallback.SetBelong(null);
				}
				return r_BeginReceiveCallback;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback BeginReceiveGenericCallback
		/// </summary>
		protected static RSystem.RIOAsyncCallback r_BeginReceiveGenericCallback;
		public static RSystem.RIOAsyncCallback RBeginReceiveGenericCallback
		{
			get
			{
				if(r_BeginReceiveGenericCallback == null)
				{
					r_BeginReceiveGenericCallback = new(typeof(System.Net.Sockets.Socket), "BeginReceiveGenericCallback");
					r_BeginReceiveGenericCallback.SetBelong(null);
				}
				return r_BeginReceiveGenericCallback;
			}
		}

		/// <summary>
		/// System.AsyncCallback ReceiveFromAsyncCallback
		/// </summary>
		protected static RSystem.RAsyncCallback r_ReceiveFromAsyncCallback;
		public static RSystem.RAsyncCallback ReceiveFromAsyncCallback
		{
			get
			{
				if(r_ReceiveFromAsyncCallback == null)
				{
					r_ReceiveFromAsyncCallback = new(typeof(System.Net.Sockets.Socket), "ReceiveFromAsyncCallback");
					r_ReceiveFromAsyncCallback.SetBelong(null);
				}
				return r_ReceiveFromAsyncCallback;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback BeginReceiveFromCallback
		/// </summary>
		protected static RSystem.RIOAsyncCallback r_BeginReceiveFromCallback;
		public static RSystem.RIOAsyncCallback RBeginReceiveFromCallback
		{
			get
			{
				if(r_BeginReceiveFromCallback == null)
				{
					r_BeginReceiveFromCallback = new(typeof(System.Net.Sockets.Socket), "BeginReceiveFromCallback");
					r_BeginReceiveFromCallback.SetBelong(null);
				}
				return r_BeginReceiveFromCallback;
			}
		}

		/// <summary>
		/// System.AsyncCallback SendAsyncCallback
		/// </summary>
		protected static RSystem.RAsyncCallback r_SendAsyncCallback;
		public static RSystem.RAsyncCallback RSendAsyncCallback
		{
			get
			{
				if(r_SendAsyncCallback == null)
				{
					r_SendAsyncCallback = new(typeof(System.Net.Sockets.Socket), "SendAsyncCallback");
					r_SendAsyncCallback.SetBelong(null);
				}
				return r_SendAsyncCallback;
			}
		}

		/// <summary>
		/// System.IOAsyncCallback BeginSendGenericCallback
		/// </summary>
		protected static RSystem.RIOAsyncCallback r_BeginSendGenericCallback;
		public static RSystem.RIOAsyncCallback RBeginSendGenericCallback
		{
			get
			{
				if(r_BeginSendGenericCallback == null)
				{
					r_BeginSendGenericCallback = new(typeof(System.Net.Sockets.Socket), "BeginSendGenericCallback");
					r_BeginSendGenericCallback.SetBelong(null);
				}
				return r_BeginSendGenericCallback;
			}
		}

		/// <summary>
		/// System.AsyncCallback SendToAsyncCallback
		/// </summary>
		protected static RSystem.RAsyncCallback r_SendToAsyncCallback;
		public static RSystem.RAsyncCallback RSendToAsyncCallback
		{
			get
			{
				if(r_SendToAsyncCallback == null)
				{
					r_SendToAsyncCallback = new(typeof(System.Net.Sockets.Socket), "SendToAsyncCallback");
					r_SendToAsyncCallback.SetBelong(null);
				}
				return r_SendToAsyncCallback;
			}
		}

		/// <summary>
		/// Boolean SupportsIPv4
		/// </summary>
		protected static RProperty r_SupportsIPv4;
		public static RProperty RSupportsIPv4
		{
			get
			{
				if(r_SupportsIPv4 == null)
				{
					r_SupportsIPv4 = new(typeof(System.Net.Sockets.Socket), "SupportsIPv4", -1);
					r_SupportsIPv4.SetBelong(null);
				}
				return r_SupportsIPv4;
			}
		}

		/// <summary>
		/// Boolean OSSupportsIPv4
		/// </summary>
		protected static RProperty r_OSSupportsIPv4;
		public static RProperty ROSSupportsIPv4
		{
			get
			{
				if(r_OSSupportsIPv4 == null)
				{
					r_OSSupportsIPv4 = new(typeof(System.Net.Sockets.Socket), "OSSupportsIPv4", -1);
					r_OSSupportsIPv4.SetBelong(null);
				}
				return r_OSSupportsIPv4;
			}
		}

		/// <summary>
		/// Boolean SupportsIPv6
		/// </summary>
		protected static RProperty r_SupportsIPv6;
		public static RProperty RSupportsIPv6
		{
			get
			{
				if(r_SupportsIPv6 == null)
				{
					r_SupportsIPv6 = new(typeof(System.Net.Sockets.Socket), "SupportsIPv6", -1);
					r_SupportsIPv6.SetBelong(null);
				}
				return r_SupportsIPv6;
			}
		}

		/// <summary>
		/// Boolean LegacySupportsIPv6
		/// </summary>
		protected static RProperty r_LegacySupportsIPv6;
		public static RProperty RLegacySupportsIPv6
		{
			get
			{
				if(r_LegacySupportsIPv6 == null)
				{
					r_LegacySupportsIPv6 = new(typeof(System.Net.Sockets.Socket), "LegacySupportsIPv6", -1);
					r_LegacySupportsIPv6.SetBelong(null);
				}
				return r_LegacySupportsIPv6;
			}
		}

		/// <summary>
		/// Boolean OSSupportsIPv6
		/// </summary>
		protected static RProperty r_OSSupportsIPv6;
		public static RProperty ROSSupportsIPv6
		{
			get
			{
				if(r_OSSupportsIPv6 == null)
				{
					r_OSSupportsIPv6 = new(typeof(System.Net.Sockets.Socket), "OSSupportsIPv6", -1);
					r_OSSupportsIPv6.SetBelong(null);
				}
				return r_OSSupportsIPv6;
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
		/// Boolean UseOnlyOverlappedIO
		/// </summary>
		protected RProperty r_UseOnlyOverlappedIO;
		public virtual RProperty RUseOnlyOverlappedIO
		{
			get
			{
				if(r_UseOnlyOverlappedIO == null)
				{
					r_UseOnlyOverlappedIO = new(this, "UseOnlyOverlappedIO", -1);
					r_UseOnlyOverlappedIO.SetBelong(this.instance);
				}
				return r_UseOnlyOverlappedIO;
			}
		}

		/// <summary>
		/// System.Net.Sockets.AddressFamily AddressFamily
		/// </summary>
		protected RProperty r_AddressFamily;
		public virtual RProperty RAddressFamily
		{
			get
			{
				if(r_AddressFamily == null)
				{
					r_AddressFamily = new(this, "AddressFamily", -1);
					r_AddressFamily.SetBelong(this.instance);
				}
				return r_AddressFamily;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketType SocketType
		/// </summary>
		protected RProperty r_SocketType;
		public virtual RProperty RSocketType
		{
			get
			{
				if(r_SocketType == null)
				{
					r_SocketType = new(this, "SocketType", -1);
					r_SocketType.SetBelong(this.instance);
				}
				return r_SocketType;
			}
		}

		/// <summary>
		/// System.Net.Sockets.ProtocolType ProtocolType
		/// </summary>
		protected RProperty r_ProtocolType;
		public virtual RProperty RProtocolType
		{
			get
			{
				if(r_ProtocolType == null)
				{
					r_ProtocolType = new(this, "ProtocolType", -1);
					r_ProtocolType.SetBelong(this.instance);
				}
				return r_ProtocolType;
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
		/// Int16 Ttl
		/// </summary>
		protected RProperty r_Ttl;
		public virtual RProperty RTtl
		{
			get
			{
				if(r_Ttl == null)
				{
					r_Ttl = new(this, "Ttl", -1);
					r_Ttl.SetBelong(this.instance);
				}
				return r_Ttl;
			}
		}

		/// <summary>
		/// Boolean DontFragment
		/// </summary>
		protected RProperty r_DontFragment;
		public virtual RProperty RDontFragment
		{
			get
			{
				if(r_DontFragment == null)
				{
					r_DontFragment = new(this, "DontFragment", -1);
					r_DontFragment.SetBelong(this.instance);
				}
				return r_DontFragment;
			}
		}

		/// <summary>
		/// Boolean DualMode
		/// </summary>
		protected RProperty r_DualMode;
		public virtual RProperty RDualMode
		{
			get
			{
				if(r_DualMode == null)
				{
					r_DualMode = new(this, "DualMode", -1);
					r_DualMode.SetBelong(this.instance);
				}
				return r_DualMode;
			}
		}

		/// <summary>
		/// Boolean IsDualMode
		/// </summary>
		protected RProperty r_IsDualMode;
		public virtual RProperty RIsDualMode
		{
			get
			{
				if(r_IsDualMode == null)
				{
					r_IsDualMode = new(this, "IsDualMode", -1);
					r_IsDualMode.SetBelong(this.instance);
				}
				return r_IsDualMode;
			}
		}

		/// <summary>
		/// System.Object InternalSyncObject
		/// </summary>
		protected static RSystem.RObject r_InternalSyncObject;
		public static RSystem.RObject RInternalSyncObject
		{
			get
			{
				if(r_InternalSyncObject == null)
				{
					r_InternalSyncObject = new(typeof(System.Net.Sockets.Socket), "InternalSyncObject", -1);
					r_InternalSyncObject.SetBelong(null);
				}
				return r_InternalSyncObject;
			}
		}

		/// <summary>
		/// Boolean CleanedUp
		/// </summary>
		protected RProperty r_CleanedUp;
		public virtual RProperty RCleanedUp
		{
			get
			{
				if(r_CleanedUp == null)
				{
					r_CleanedUp = new(this, "CleanedUp", -1);
					r_CleanedUp.SetBelong(this.instance);
				}
				return r_CleanedUp;
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
		/// Boolean EnableBroadcast
		/// </summary>
		protected RProperty r_EnableBroadcast;
		public virtual RProperty REnableBroadcast
		{
			get
			{
				if(r_EnableBroadcast == null)
				{
					r_EnableBroadcast = new(this, "EnableBroadcast", -1);
					r_EnableBroadcast.SetBelong(this.instance);
				}
				return r_EnableBroadcast;
			}
		}

		/// <summary>
		/// Boolean IsBound
		/// </summary>
		protected RProperty r_IsBound;
		public virtual RProperty RIsBound
		{
			get
			{
				if(r_IsBound == null)
				{
					r_IsBound = new(this, "IsBound", -1);
					r_IsBound.SetBelong(this.instance);
				}
				return r_IsBound;
			}
		}

		/// <summary>
		/// Boolean MulticastLoopback
		/// </summary>
		protected RProperty r_MulticastLoopback;
		public virtual RProperty RMulticastLoopback
		{
			get
			{
				if(r_MulticastLoopback == null)
				{
					r_MulticastLoopback = new(this, "MulticastLoopback", -1);
					r_MulticastLoopback.SetBelong(this.instance);
				}
				return r_MulticastLoopback;
			}
		}

		/// <summary>
		/// System.Net.EndPoint LocalEndPoint
		/// </summary>
		protected RSystem.RNet.REndPoint r_LocalEndPoint;
		public virtual RSystem.RNet.REndPoint RLocalEndPoint
		{
			get
			{
				if(r_LocalEndPoint == null)
				{
					r_LocalEndPoint = new(this, "LocalEndPoint", -1);
					r_LocalEndPoint.SetBelong(this.instance);
				}
				return r_LocalEndPoint;
			}
		}

		/// <summary>
		/// Boolean Blocking
		/// </summary>
		protected RProperty r_Blocking;
		public virtual RProperty RBlocking
		{
			get
			{
				if(r_Blocking == null)
				{
					r_Blocking = new(this, "Blocking", -1);
					r_Blocking.SetBelong(this.instance);
				}
				return r_Blocking;
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
		/// System.Net.EndPoint RemoteEndPoint
		/// </summary>
		protected RSystem.RNet.REndPoint r_RemoteEndPoint;
		public virtual RSystem.RNet.REndPoint RemoteEndPoint
		{
			get
			{
				if(r_RemoteEndPoint == null)
				{
					r_RemoteEndPoint = new(this, "RemoteEndPoint", -1);
					r_RemoteEndPoint.SetBelong(this.instance);
				}
				return r_RemoteEndPoint;
			}
		}

		/// <summary>
		/// System.Runtime.InteropServices.SafeHandle SafeHandle
		/// </summary>
		protected RSystem.RRuntime.RInteropServices.RSafeHandle r_SafeHandle;
		public virtual RSystem.RRuntime.RInteropServices.RSafeHandle RSafeHandle
		{
			get
			{
				if(r_SafeHandle == null)
				{
					r_SafeHandle = new(this, "SafeHandle", -1);
					r_SafeHandle.SetBelong(this.instance);
				}
				return r_SafeHandle;
			}
		}

		/// <summary>
		/// Int32 FamilyHint
		/// </summary>
		protected static RProperty r_FamilyHint;
		public static RProperty RFamilyHint
		{
			get
			{
				if(r_FamilyHint == null)
				{
					r_FamilyHint = new(typeof(System.Net.Sockets.Socket), "FamilyHint", -1);
					r_FamilyHint.SetBelong(null);
				}
				return r_FamilyHint;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Net.Sockets.Socket] AcceptAsync(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RAcceptAsync_Socket;
		public virtual RMethod RAcceptAsync_Socket
		{
			get
			{
				if(r_RAcceptAsync_Socket == null)
				{
					r_RAcceptAsync_Socket = new(this, "AcceptAsync", 0, typeof(System.Net.Sockets.Socket));
					r_RAcceptAsync_Socket.SetBelong(this.instance);
				}
				return r_RAcceptAsync_Socket;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Net.Sockets.Socket] AcceptAsyncApm(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RAcceptAsyncApm_Socket;
		public virtual RMethod RAcceptAsyncApm_Socket
		{
			get
			{
				if(r_RAcceptAsyncApm_Socket == null)
				{
					r_RAcceptAsyncApm_Socket = new(this, "AcceptAsyncApm", 0, typeof(System.Net.Sockets.Socket));
					r_RAcceptAsyncApm_Socket.SetBelong(this.instance);
				}
				return r_RAcceptAsyncApm_Socket;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ConnectAsync(System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RConnectAsync_EndPoint;
		public virtual RMethod RConnectAsync_EndPoint
		{
			get
			{
				if(r_RConnectAsync_EndPoint == null)
				{
					r_RConnectAsync_EndPoint = new(this, "ConnectAsync", 0, typeof(System.Net.EndPoint));
					r_RConnectAsync_EndPoint.SetBelong(this.instance);
				}
				return r_RConnectAsync_EndPoint;
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
		/// System.Threading.Tasks.Task`1[System.Int32] ReceiveAsync(System.ArraySegment`1[System.Byte], System.Net.Sockets.SocketFlags, Boolean)
		/// </summary>
		protected RMethod r_RReceiveAsync_ArraySegment_d_Byte_p__SocketFlags_Boolean;
		public virtual RMethod RReceiveAsync_ArraySegment_d_Byte_p__SocketFlags_Boolean
		{
			get
			{
				if(r_RReceiveAsync_ArraySegment_d_Byte_p__SocketFlags_Boolean == null)
				{
					r_RReceiveAsync_ArraySegment_d_Byte_p__SocketFlags_Boolean = new(this, "ReceiveAsync", 0, typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Boolean));
					r_RReceiveAsync_ArraySegment_d_Byte_p__SocketFlags_Boolean.SetBelong(this.instance);
				}
				return r_RReceiveAsync_ArraySegment_d_Byte_p__SocketFlags_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReceiveAsync(System.Memory`1[System.Byte], System.Net.Sockets.SocketFlags, Boolean, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReceiveAsync_Memory_d_Byte_p__SocketFlags_Boolean_CancellationToken;
		public virtual RMethod RReceiveAsync_Memory_d_Byte_p__SocketFlags_Boolean_CancellationToken
		{
			get
			{
				if(r_RReceiveAsync_Memory_d_Byte_p__SocketFlags_Boolean_CancellationToken == null)
				{
					r_RReceiveAsync_Memory_d_Byte_p__SocketFlags_Boolean_CancellationToken = new(this, "ReceiveAsync", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Boolean), typeof(System.Threading.CancellationToken));
					r_RReceiveAsync_Memory_d_Byte_p__SocketFlags_Boolean_CancellationToken.SetBelong(this.instance);
				}
				return r_RReceiveAsync_Memory_d_Byte_p__SocketFlags_Boolean_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReceiveAsyncApm(System.Memory`1[System.Byte], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RReceiveAsyncApm_Memory_d_Byte_p__SocketFlags;
		public virtual RMethod RReceiveAsyncApm_Memory_d_Byte_p__SocketFlags
		{
			get
			{
				if(r_RReceiveAsyncApm_Memory_d_Byte_p__SocketFlags == null)
				{
					r_RReceiveAsyncApm_Memory_d_Byte_p__SocketFlags = new(this, "ReceiveAsyncApm", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags));
					r_RReceiveAsyncApm_Memory_d_Byte_p__SocketFlags.SetBelong(this.instance);
				}
				return r_RReceiveAsyncApm_Memory_d_Byte_p__SocketFlags;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReceiveAsync(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RReceiveAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
		public virtual RMethod RReceiveAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags
		{
			get
			{
				if(r_RReceiveAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags == null)
				{
					r_RReceiveAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags = new(this, "ReceiveAsync", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags));
					r_RReceiveAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.SetBelong(this.instance);
				}
				return r_RReceiveAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReceiveAsyncApm(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RReceiveAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
		public virtual RMethod RReceiveAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags
		{
			get
			{
				if(r_RReceiveAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags == null)
				{
					r_RReceiveAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags = new(this, "ReceiveAsyncApm", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags));
					r_RReceiveAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.SetBelong(this.instance);
				}
				return r_RReceiveAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Net.Sockets.SocketReceiveFromResult] ReceiveFromAsync(System.ArraySegment`1[System.Byte], System.Net.Sockets.SocketFlags, System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RReceiveFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint;
		public virtual RMethod RReceiveFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint
		{
			get
			{
				if(r_RReceiveFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint == null)
				{
					r_RReceiveFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint = new(this, "ReceiveFromAsync", 0, typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint));
					r_RReceiveFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint.SetBelong(this.instance);
				}
				return r_RReceiveFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Net.Sockets.SocketReceiveMessageFromResult] ReceiveMessageFromAsync(System.ArraySegment`1[System.Byte], System.Net.Sockets.SocketFlags, System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RReceiveMessageFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint;
		public virtual RMethod RReceiveMessageFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint
		{
			get
			{
				if(r_RReceiveMessageFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint == null)
				{
					r_RReceiveMessageFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint = new(this, "ReceiveMessageFromAsync", 0, typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint));
					r_RReceiveMessageFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint.SetBelong(this.instance);
				}
				return r_RReceiveMessageFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] SendAsync(System.ArraySegment`1[System.Byte], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSendAsync_ArraySegment_d_Byte_p__SocketFlags;
		public virtual RMethod RSendAsync_ArraySegment_d_Byte_p__SocketFlags
		{
			get
			{
				if(r_RSendAsync_ArraySegment_d_Byte_p__SocketFlags == null)
				{
					r_RSendAsync_ArraySegment_d_Byte_p__SocketFlags = new(this, "SendAsync", 0, typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags));
					r_RSendAsync_ArraySegment_d_Byte_p__SocketFlags.SetBelong(this.instance);
				}
				return r_RSendAsync_ArraySegment_d_Byte_p__SocketFlags;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] SendAsync(System.ReadOnlyMemory`1[System.Byte], System.Net.Sockets.SocketFlags, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RSendAsync_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken;
		public virtual RMethod RSendAsync_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken
		{
			get
			{
				if(r_RSendAsync_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken == null)
				{
					r_RSendAsync_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken = new(this, "SendAsync", 0, typeof(System.ReadOnlyMemory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Threading.CancellationToken));
					r_RSendAsync_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken.SetBelong(this.instance);
				}
				return r_RSendAsync_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory`1[System.Byte], System.Net.Sockets.SocketFlags, System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RSendAsyncForNetworkStream_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken;
		public virtual RMethod RSendAsyncForNetworkStream_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken
		{
			get
			{
				if(r_RSendAsyncForNetworkStream_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken == null)
				{
					r_RSendAsyncForNetworkStream_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken = new(this, "SendAsyncForNetworkStream", 0, typeof(System.ReadOnlyMemory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Threading.CancellationToken));
					r_RSendAsyncForNetworkStream_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken.SetBelong(this.instance);
				}
				return r_RSendAsyncForNetworkStream_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] SendAsyncApm(System.ReadOnlyMemory`1[System.Byte], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSendAsyncApm_ReadOnlyMemory_d_Byte_p__SocketFlags;
		public virtual RMethod RSendAsyncApm_ReadOnlyMemory_d_Byte_p__SocketFlags
		{
			get
			{
				if(r_RSendAsyncApm_ReadOnlyMemory_d_Byte_p__SocketFlags == null)
				{
					r_RSendAsyncApm_ReadOnlyMemory_d_Byte_p__SocketFlags = new(this, "SendAsyncApm", 0, typeof(System.ReadOnlyMemory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags));
					r_RSendAsyncApm_ReadOnlyMemory_d_Byte_p__SocketFlags.SetBelong(this.instance);
				}
				return r_RSendAsyncApm_ReadOnlyMemory_d_Byte_p__SocketFlags;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] SendAsync(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSendAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
		public virtual RMethod RSendAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags
		{
			get
			{
				if(r_RSendAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags == null)
				{
					r_RSendAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags = new(this, "SendAsync", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags));
					r_RSendAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.SetBelong(this.instance);
				}
				return r_RSendAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] SendAsyncApm(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSendAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
		public virtual RMethod RSendAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags
		{
			get
			{
				if(r_RSendAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags == null)
				{
					r_RSendAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags = new(this, "SendAsyncApm", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags));
					r_RSendAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.SetBelong(this.instance);
				}
				return r_RSendAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] SendToAsync(System.ArraySegment`1[System.Byte], System.Net.Sockets.SocketFlags, System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RSendToAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint;
		public virtual RMethod RSendToAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint
		{
			get
			{
				if(r_RSendToAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint == null)
				{
					r_RSendToAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint = new(this, "SendToAsync", 0, typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint));
					r_RSendToAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint.SetBelong(this.instance);
				}
				return r_RSendToAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint;
			}
		}

		/// <summary>
		/// Void ValidateBuffer(System.ArraySegment`1[System.Byte])
		/// </summary>
		protected static RMethod r_RValidateBuffer_ArraySegment_d_Byte_p_;
		public static RMethod RValidateBuffer_ArraySegment_d_Byte_p_
		{
			get
			{
				if(r_RValidateBuffer_ArraySegment_d_Byte_p_ == null)
				{
					r_RValidateBuffer_ArraySegment_d_Byte_p_ = new(typeof(System.Net.Sockets.Socket), "ValidateBuffer", 0, typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte)));
					r_RValidateBuffer_ArraySegment_d_Byte_p_.SetBelong(null);
				}
				return r_RValidateBuffer_ArraySegment_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void ValidateBuffersList(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]])
		/// </summary>
		protected static RMethod r_RValidateBuffersList_IList_d_ArraySegment_d_Byte_p__p_;
		public static RMethod RValidateBuffersList_IList_d_ArraySegment_d_Byte_p__p_
		{
			get
			{
				if(r_RValidateBuffersList_IList_d_ArraySegment_d_Byte_p__p_ == null)
				{
					r_RValidateBuffersList_IList_d_ArraySegment_d_Byte_p__p_ = new(typeof(System.Net.Sockets.Socket), "ValidateBuffersList", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))));
					r_RValidateBuffersList_IList_d_ArraySegment_d_Byte_p__p_.SetBelong(null);
				}
				return r_RValidateBuffersList_IList_d_ArraySegment_d_Byte_p__p_;
			}
		}

		/// <summary>
		/// Void ConfigureBufferList(Int32TaskSocketAsyncEventArgs, System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected static RMethod r_RConfigureBufferList_Int32TaskSocketAsyncEventArgs_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
		public static RMethod RConfigureBufferList_Int32TaskSocketAsyncEventArgs_IList_d_ArraySegment_d_Byte_p__p__SocketFlags
		{
			get
			{
				if(r_RConfigureBufferList_Int32TaskSocketAsyncEventArgs_IList_d_ArraySegment_d_Byte_p__p__SocketFlags == null)
				{
					r_RConfigureBufferList_Int32TaskSocketAsyncEventArgs_IList_d_ArraySegment_d_Byte_p__p__SocketFlags = new(typeof(System.Net.Sockets.Socket), "ConfigureBufferList", 0,  ReleactionUtils.GetType("System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs"), typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags));
					r_RConfigureBufferList_Int32TaskSocketAsyncEventArgs_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.SetBelong(null);
				}
				return r_RConfigureBufferList_Int32TaskSocketAsyncEventArgs_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] GetTaskForSendReceive(Boolean, Int32TaskSocketAsyncEventArgs, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RGetTaskForSendReceive_Boolean_Int32TaskSocketAsyncEventArgs_Boolean_Boolean;
		public virtual RMethod RGetTaskForSendReceive_Boolean_Int32TaskSocketAsyncEventArgs_Boolean_Boolean
		{
			get
			{
				if(r_RGetTaskForSendReceive_Boolean_Int32TaskSocketAsyncEventArgs_Boolean_Boolean == null)
				{
					r_RGetTaskForSendReceive_Boolean_Int32TaskSocketAsyncEventArgs_Boolean_Boolean = new(this, "GetTaskForSendReceive", 0, typeof(System.Boolean),  ReleactionUtils.GetType("System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs"), typeof(System.Boolean), typeof(System.Boolean));
					r_RGetTaskForSendReceive_Boolean_Int32TaskSocketAsyncEventArgs_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RGetTaskForSendReceive_Boolean_Int32TaskSocketAsyncEventArgs_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void CompleteAccept(System.Net.Sockets.Socket, TaskSocketAsyncEventArgs`1)
		/// </summary>
		protected static RMethod r_RCompleteAccept_Socket_TaskSocketAsyncEventArgs_d_Socket_p_;
		public static RMethod RCompleteAccept_Socket_TaskSocketAsyncEventArgs_d_Socket_p_
		{
			get
			{
				if(r_RCompleteAccept_Socket_TaskSocketAsyncEventArgs_d_Socket_p_ == null)
				{
					r_RCompleteAccept_Socket_TaskSocketAsyncEventArgs_d_Socket_p_ = new(typeof(System.Net.Sockets.Socket), "CompleteAccept", 0, typeof(System.Net.Sockets.Socket),  ReleactionUtils.GetType("System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1").MakeGenericType(typeof(System.Net.Sockets.Socket)));
					r_RCompleteAccept_Socket_TaskSocketAsyncEventArgs_d_Socket_p_.SetBelong(null);
				}
				return r_RCompleteAccept_Socket_TaskSocketAsyncEventArgs_d_Socket_p_;
			}
		}

		/// <summary>
		/// Void CompleteSendReceive(System.Net.Sockets.Socket, Int32TaskSocketAsyncEventArgs, Boolean)
		/// </summary>
		protected static RMethod r_RCompleteSendReceive_Socket_Int32TaskSocketAsyncEventArgs_Boolean;
		public static RMethod RCompleteSendReceive_Socket_Int32TaskSocketAsyncEventArgs_Boolean
		{
			get
			{
				if(r_RCompleteSendReceive_Socket_Int32TaskSocketAsyncEventArgs_Boolean == null)
				{
					r_RCompleteSendReceive_Socket_Int32TaskSocketAsyncEventArgs_Boolean = new(typeof(System.Net.Sockets.Socket), "CompleteSendReceive", 0, typeof(System.Net.Sockets.Socket),  ReleactionUtils.GetType("System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs"), typeof(System.Boolean));
					r_RCompleteSendReceive_Socket_Int32TaskSocketAsyncEventArgs_Boolean.SetBelong(null);
				}
				return r_RCompleteSendReceive_Socket_Int32TaskSocketAsyncEventArgs_Boolean;
			}
		}

		/// <summary>
		/// System.Exception GetException(System.Net.Sockets.SocketError, Boolean)
		/// </summary>
		protected static RMethod r_RGetException_SocketError_Boolean;
		public static RMethod RGetException_SocketError_Boolean
		{
			get
			{
				if(r_RGetException_SocketError_Boolean == null)
				{
					r_RGetException_SocketError_Boolean = new(typeof(System.Net.Sockets.Socket), "GetException", 0, typeof(System.Net.Sockets.SocketError), typeof(System.Boolean));
					r_RGetException_SocketError_Boolean.SetBelong(null);
				}
				return r_RGetException_SocketError_Boolean;
			}
		}

		/// <summary>
		/// Int32TaskSocketAsyncEventArgs RentSocketAsyncEventArgs(Boolean)
		/// </summary>
		protected RMethod r_RRentSocketAsyncEventArgs_Boolean;
		public virtual RMethod RRentSocketAsyncEventArgs_Boolean
		{
			get
			{
				if(r_RRentSocketAsyncEventArgs_Boolean == null)
				{
					r_RRentSocketAsyncEventArgs_Boolean = new(this, "RentSocketAsyncEventArgs", 0, typeof(System.Boolean));
					r_RRentSocketAsyncEventArgs_Boolean.SetBelong(this.instance);
				}
				return r_RRentSocketAsyncEventArgs_Boolean;
			}
		}

		/// <summary>
		/// Void ReturnSocketAsyncEventArgs(Int32TaskSocketAsyncEventArgs, Boolean)
		/// </summary>
		protected RMethod r_RReturnSocketAsyncEventArgs_Int32TaskSocketAsyncEventArgs_Boolean;
		public virtual RMethod RReturnSocketAsyncEventArgs_Int32TaskSocketAsyncEventArgs_Boolean
		{
			get
			{
				if(r_RReturnSocketAsyncEventArgs_Int32TaskSocketAsyncEventArgs_Boolean == null)
				{
					r_RReturnSocketAsyncEventArgs_Int32TaskSocketAsyncEventArgs_Boolean = new(this, "ReturnSocketAsyncEventArgs", 0,  ReleactionUtils.GetType("System.Net.Sockets.Socket+Int32TaskSocketAsyncEventArgs"), typeof(System.Boolean));
					r_RReturnSocketAsyncEventArgs_Int32TaskSocketAsyncEventArgs_Boolean.SetBelong(this.instance);
				}
				return r_RReturnSocketAsyncEventArgs_Int32TaskSocketAsyncEventArgs_Boolean;
			}
		}

		/// <summary>
		/// Void ReturnSocketAsyncEventArgs(TaskSocketAsyncEventArgs`1)
		/// </summary>
		protected RMethod r_RReturnSocketAsyncEventArgs_TaskSocketAsyncEventArgs_d_Socket_p_;
		public virtual RMethod RReturnSocketAsyncEventArgs_TaskSocketAsyncEventArgs_d_Socket_p_
		{
			get
			{
				if(r_RReturnSocketAsyncEventArgs_TaskSocketAsyncEventArgs_d_Socket_p_ == null)
				{
					r_RReturnSocketAsyncEventArgs_TaskSocketAsyncEventArgs_d_Socket_p_ = new(this, "ReturnSocketAsyncEventArgs", 0,  ReleactionUtils.GetType("System.Net.Sockets.Socket+TaskSocketAsyncEventArgs`1").MakeGenericType(typeof(System.Net.Sockets.Socket)));
					r_RReturnSocketAsyncEventArgs_TaskSocketAsyncEventArgs_d_Socket_p_.SetBelong(this.instance);
				}
				return r_RReturnSocketAsyncEventArgs_TaskSocketAsyncEventArgs_d_Socket_p_;
			}
		}

		/// <summary>
		/// Void DisposeCachedTaskSocketAsyncEventArgs()
		/// </summary>
		protected RMethod r_RDisposeCachedTaskSocketAsyncEventArgs;
		public virtual RMethod RDisposeCachedTaskSocketAsyncEventArgs
		{
			get
			{
				if(r_RDisposeCachedTaskSocketAsyncEventArgs == null)
				{
					r_RDisposeCachedTaskSocketAsyncEventArgs = new(this, "DisposeCachedTaskSocketAsyncEventArgs", 0);
					r_RDisposeCachedTaskSocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RDisposeCachedTaskSocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// Boolean CanTryAddressFamily(System.Net.Sockets.AddressFamily)
		/// </summary>
		protected RMethod r_RCanTryAddressFamily_AddressFamily;
		public virtual RMethod RCanTryAddressFamily_AddressFamily
		{
			get
			{
				if(r_RCanTryAddressFamily_AddressFamily == null)
				{
					r_RCanTryAddressFamily_AddressFamily = new(this, "CanTryAddressFamily", 0, typeof(System.Net.Sockets.AddressFamily));
					r_RCanTryAddressFamily_AddressFamily.SetBelong(this.instance);
				}
				return r_RCanTryAddressFamily_AddressFamily;
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
		/// Int32 Send(Byte[], Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSend_ByteArray_Int32_SocketFlags;
		public virtual RMethod RSend_ByteArray_Int32_SocketFlags
		{
			get
			{
				if(r_RSend_ByteArray_Int32_SocketFlags == null)
				{
					r_RSend_ByteArray_Int32_SocketFlags = new(this, "Send", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RSend_ByteArray_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RSend_ByteArray_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Int32 Send(Byte[], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSend_ByteArray_SocketFlags;
		public virtual RMethod RSend_ByteArray_SocketFlags
		{
			get
			{
				if(r_RSend_ByteArray_SocketFlags == null)
				{
					r_RSend_ByteArray_SocketFlags = new(this, "Send", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Net.Sockets.SocketFlags));
					r_RSend_ByteArray_SocketFlags.SetBelong(this.instance);
				}
				return r_RSend_ByteArray_SocketFlags;
			}
		}

		/// <summary>
		/// Int32 Send(Byte[])
		/// </summary>
		protected RMethod r_RSend_ByteArray;
		public virtual RMethod RSend_ByteArray
		{
			get
			{
				if(r_RSend_ByteArray == null)
				{
					r_RSend_ByteArray = new(this, "Send", 0, typeof(System.Byte).MakeArrayType());
					r_RSend_ByteArray.SetBelong(this.instance);
				}
				return r_RSend_ByteArray;
			}
		}

		/// <summary>
		/// Int32 Send(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]])
		/// </summary>
		protected RMethod r_RSend_IList_d_ArraySegment_d_Byte_p__p_;
		public virtual RMethod RSend_IList_d_ArraySegment_d_Byte_p__p_
		{
			get
			{
				if(r_RSend_IList_d_ArraySegment_d_Byte_p__p_ == null)
				{
					r_RSend_IList_d_ArraySegment_d_Byte_p__p_ = new(this, "Send", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))));
					r_RSend_IList_d_ArraySegment_d_Byte_p__p_.SetBelong(this.instance);
				}
				return r_RSend_IList_d_ArraySegment_d_Byte_p__p_;
			}
		}

		/// <summary>
		/// Int32 Send(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
		public virtual RMethod RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags
		{
			get
			{
				if(r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags == null)
				{
					r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags = new(this, "Send", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags));
					r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.SetBelong(this.instance);
				}
				return r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
			}
		}

		/// <summary>
		/// Void SendFile(System.String)
		/// </summary>
		protected RMethod r_RSendFile_String;
		public virtual RMethod RSendFile_String
		{
			get
			{
				if(r_RSendFile_String == null)
				{
					r_RSendFile_String = new(this, "SendFile", 0, typeof(System.String));
					r_RSendFile_String.SetBelong(this.instance);
				}
				return r_RSendFile_String;
			}
		}

		/// <summary>
		/// Int32 Send(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSend_ByteArray_Int32_Int32_SocketFlags;
		public virtual RMethod RSend_ByteArray_Int32_Int32_SocketFlags
		{
			get
			{
				if(r_RSend_ByteArray_Int32_Int32_SocketFlags == null)
				{
					r_RSend_ByteArray_Int32_Int32_SocketFlags = new(this, "Send", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RSend_ByteArray_Int32_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RSend_ByteArray_Int32_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Int32 SendTo(Byte[], Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RSendTo_ByteArray_Int32_SocketFlags_EndPoint;
		public virtual RMethod RSendTo_ByteArray_Int32_SocketFlags_EndPoint
		{
			get
			{
				if(r_RSendTo_ByteArray_Int32_SocketFlags_EndPoint == null)
				{
					r_RSendTo_ByteArray_Int32_SocketFlags_EndPoint = new(this, "SendTo", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint));
					r_RSendTo_ByteArray_Int32_SocketFlags_EndPoint.SetBelong(this.instance);
				}
				return r_RSendTo_ByteArray_Int32_SocketFlags_EndPoint;
			}
		}

		/// <summary>
		/// Int32 SendTo(Byte[], System.Net.Sockets.SocketFlags, System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RSendTo_ByteArray_SocketFlags_EndPoint;
		public virtual RMethod RSendTo_ByteArray_SocketFlags_EndPoint
		{
			get
			{
				if(r_RSendTo_ByteArray_SocketFlags_EndPoint == null)
				{
					r_RSendTo_ByteArray_SocketFlags_EndPoint = new(this, "SendTo", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint));
					r_RSendTo_ByteArray_SocketFlags_EndPoint.SetBelong(this.instance);
				}
				return r_RSendTo_ByteArray_SocketFlags_EndPoint;
			}
		}

		/// <summary>
		/// Int32 SendTo(Byte[], System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RSendTo_ByteArray_EndPoint;
		public virtual RMethod RSendTo_ByteArray_EndPoint
		{
			get
			{
				if(r_RSendTo_ByteArray_EndPoint == null)
				{
					r_RSendTo_ByteArray_EndPoint = new(this, "SendTo", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Net.EndPoint));
					r_RSendTo_ByteArray_EndPoint.SetBelong(this.instance);
				}
				return r_RSendTo_ByteArray_EndPoint;
			}
		}

		/// <summary>
		/// Int32 Receive(Byte[], Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RReceive_ByteArray_Int32_SocketFlags;
		public virtual RMethod RReceive_ByteArray_Int32_SocketFlags
		{
			get
			{
				if(r_RReceive_ByteArray_Int32_SocketFlags == null)
				{
					r_RReceive_ByteArray_Int32_SocketFlags = new(this, "Receive", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RReceive_ByteArray_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RReceive_ByteArray_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Int32 Receive(Byte[], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RReceive_ByteArray_SocketFlags;
		public virtual RMethod RReceive_ByteArray_SocketFlags
		{
			get
			{
				if(r_RReceive_ByteArray_SocketFlags == null)
				{
					r_RReceive_ByteArray_SocketFlags = new(this, "Receive", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Net.Sockets.SocketFlags));
					r_RReceive_ByteArray_SocketFlags.SetBelong(this.instance);
				}
				return r_RReceive_ByteArray_SocketFlags;
			}
		}

		/// <summary>
		/// Int32 Receive(Byte[])
		/// </summary>
		protected RMethod r_RReceive_ByteArray;
		public virtual RMethod RReceive_ByteArray
		{
			get
			{
				if(r_RReceive_ByteArray == null)
				{
					r_RReceive_ByteArray = new(this, "Receive", 0, typeof(System.Byte).MakeArrayType());
					r_RReceive_ByteArray.SetBelong(this.instance);
				}
				return r_RReceive_ByteArray;
			}
		}

		/// <summary>
		/// Int32 Receive(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RReceive_ByteArray_Int32_Int32_SocketFlags;
		public virtual RMethod RReceive_ByteArray_Int32_Int32_SocketFlags
		{
			get
			{
				if(r_RReceive_ByteArray_Int32_Int32_SocketFlags == null)
				{
					r_RReceive_ByteArray_Int32_Int32_SocketFlags = new(this, "Receive", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RReceive_ByteArray_Int32_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RReceive_ByteArray_Int32_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Int32 Receive(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]])
		/// </summary>
		protected RMethod r_RReceive_IList_d_ArraySegment_d_Byte_p__p_;
		public virtual RMethod RReceive_IList_d_ArraySegment_d_Byte_p__p_
		{
			get
			{
				if(r_RReceive_IList_d_ArraySegment_d_Byte_p__p_ == null)
				{
					r_RReceive_IList_d_ArraySegment_d_Byte_p__p_ = new(this, "Receive", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))));
					r_RReceive_IList_d_ArraySegment_d_Byte_p__p_.SetBelong(this.instance);
				}
				return r_RReceive_IList_d_ArraySegment_d_Byte_p__p_;
			}
		}

		/// <summary>
		/// Int32 Receive(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
		public virtual RMethod RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags
		{
			get
			{
				if(r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags == null)
				{
					r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags = new(this, "Receive", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags));
					r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.SetBelong(this.instance);
				}
				return r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags;
			}
		}

		/// <summary>
		/// Int32 ReceiveFrom(Byte[], Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint ByRef)
		/// </summary>
		protected RMethod r_RReceiveFrom_ByteArray_Int32_SocketFlags_Ref_EndPoint;
		public virtual RMethod RReceiveFrom_ByteArray_Int32_SocketFlags_Ref_EndPoint
		{
			get
			{
				if(r_RReceiveFrom_ByteArray_Int32_SocketFlags_Ref_EndPoint == null)
				{
					r_RReceiveFrom_ByteArray_Int32_SocketFlags_Ref_EndPoint = new(this, "ReceiveFrom", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint).MakeByRefType());
					r_RReceiveFrom_ByteArray_Int32_SocketFlags_Ref_EndPoint.SetBelong(this.instance);
				}
				return r_RReceiveFrom_ByteArray_Int32_SocketFlags_Ref_EndPoint;
			}
		}

		/// <summary>
		/// Int32 ReceiveFrom(Byte[], System.Net.Sockets.SocketFlags, System.Net.EndPoint ByRef)
		/// </summary>
		protected RMethod r_RReceiveFrom_ByteArray_SocketFlags_Ref_EndPoint;
		public virtual RMethod RReceiveFrom_ByteArray_SocketFlags_Ref_EndPoint
		{
			get
			{
				if(r_RReceiveFrom_ByteArray_SocketFlags_Ref_EndPoint == null)
				{
					r_RReceiveFrom_ByteArray_SocketFlags_Ref_EndPoint = new(this, "ReceiveFrom", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint).MakeByRefType());
					r_RReceiveFrom_ByteArray_SocketFlags_Ref_EndPoint.SetBelong(this.instance);
				}
				return r_RReceiveFrom_ByteArray_SocketFlags_Ref_EndPoint;
			}
		}

		/// <summary>
		/// Int32 ReceiveFrom(Byte[], System.Net.EndPoint ByRef)
		/// </summary>
		protected RMethod r_RReceiveFrom_ByteArray_Ref_EndPoint;
		public virtual RMethod RReceiveFrom_ByteArray_Ref_EndPoint
		{
			get
			{
				if(r_RReceiveFrom_ByteArray_Ref_EndPoint == null)
				{
					r_RReceiveFrom_ByteArray_Ref_EndPoint = new(this, "ReceiveFrom", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Net.EndPoint).MakeByRefType());
					r_RReceiveFrom_ByteArray_Ref_EndPoint.SetBelong(this.instance);
				}
				return r_RReceiveFrom_ByteArray_Ref_EndPoint;
			}
		}

		/// <summary>
		/// Int32 IOControl(System.Net.Sockets.IOControlCode, Byte[], Byte[])
		/// </summary>
		protected RMethod r_RIOControl_IOControlCode_ByteArray_ByteArray;
		public virtual RMethod RIOControl_IOControlCode_ByteArray_ByteArray
		{
			get
			{
				if(r_RIOControl_IOControlCode_ByteArray_ByteArray == null)
				{
					r_RIOControl_IOControlCode_ByteArray_ByteArray = new(this, "IOControl", 0, typeof(System.Net.Sockets.IOControlCode), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_RIOControl_IOControlCode_ByteArray_ByteArray.SetBelong(this.instance);
				}
				return r_RIOControl_IOControlCode_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// Void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel)
		/// </summary>
		protected RMethod r_RSetIPProtectionLevel_IPProtectionLevel;
		public virtual RMethod RSetIPProtectionLevel_IPProtectionLevel
		{
			get
			{
				if(r_RSetIPProtectionLevel_IPProtectionLevel == null)
				{
					r_RSetIPProtectionLevel_IPProtectionLevel = new(this, "SetIPProtectionLevel", 0, typeof(System.Net.Sockets.IPProtectionLevel));
					r_RSetIPProtectionLevel_IPProtectionLevel.SetBelong(this.instance);
				}
				return r_RSetIPProtectionLevel_IPProtectionLevel;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginSendFile(System.String, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginSendFile_String_AsyncCallback_Object;
		public virtual RMethod RBeginSendFile_String_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginSendFile_String_AsyncCallback_Object == null)
				{
					r_RBeginSendFile_String_AsyncCallback_Object = new(this, "BeginSendFile", 0, typeof(System.String), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginSendFile_String_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginSendFile_String_AsyncCallback_Object;
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
		/// System.IAsyncResult BeginSend(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object;
		public virtual RMethod RBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object == null)
				{
					r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object = new(this, "BeginSend", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginSend(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object;
		public virtual RMethod RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object == null)
				{
					r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object = new(this, "BeginSend", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndSend(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndSend_IAsyncResult;
		public virtual RMethod REndSend_IAsyncResult
		{
			get
			{
				if(r_REndSend_IAsyncResult == null)
				{
					r_REndSend_IAsyncResult = new(this, "EndSend", 0, typeof(System.IAsyncResult));
					r_REndSend_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndSend_IAsyncResult;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReceive(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object;
		public virtual RMethod RBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object == null)
				{
					r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object = new(this, "BeginReceive", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReceive(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object;
		public virtual RMethod RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object == null)
				{
					r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object = new(this, "BeginReceive", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndReceive(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndReceive_IAsyncResult;
		public virtual RMethod REndReceive_IAsyncResult
		{
			get
			{
				if(r_REndReceive_IAsyncResult == null)
				{
					r_REndReceive_IAsyncResult = new(this, "EndReceive", 0, typeof(System.IAsyncResult));
					r_REndReceive_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndReceive_IAsyncResult;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginAccept(Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginAccept_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginAccept_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginAccept_Int32_AsyncCallback_Object == null)
				{
					r_RBeginAccept_Int32_AsyncCallback_Object = new(this, "BeginAccept", 0, typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginAccept_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginAccept_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket EndAccept(Byte[] ByRef, System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndAccept_Out_ByteArray_IAsyncResult;
		public virtual RMethod REndAccept_Out_ByteArray_IAsyncResult
		{
			get
			{
				if(r_REndAccept_Out_ByteArray_IAsyncResult == null)
				{
					r_REndAccept_Out_ByteArray_IAsyncResult = new(this, "EndAccept", 0, typeof(System.Byte).MakeArrayType().MakeByRefType(), typeof(System.IAsyncResult));
					r_REndAccept_Out_ByteArray_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndAccept_Out_ByteArray_IAsyncResult;
			}
		}

		/// <summary>
		/// Void InitializeSockets()
		/// </summary>
		protected static RMethod r_RInitializeSockets;
		public static RMethod RInitializeSockets
		{
			get
			{
				if(r_RInitializeSockets == null)
				{
					r_RInitializeSockets = new(typeof(System.Net.Sockets.Socket), "InitializeSockets", 0);
					r_RInitializeSockets.SetBelong(null);
				}
				return r_RInitializeSockets;
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
		/// Boolean ConnectAsync(System.Net.Sockets.SocketType, System.Net.Sockets.ProtocolType, System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected static RMethod r_RConnectAsync_SocketType_ProtocolType_SocketAsyncEventArgs;
		public static RMethod RConnectAsync_SocketType_ProtocolType_SocketAsyncEventArgs
		{
			get
			{
				if(r_RConnectAsync_SocketType_ProtocolType_SocketAsyncEventArgs == null)
				{
					r_RConnectAsync_SocketType_ProtocolType_SocketAsyncEventArgs = new(typeof(System.Net.Sockets.Socket), "ConnectAsync", 0, typeof(System.Net.Sockets.SocketType), typeof(System.Net.Sockets.ProtocolType), typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RConnectAsync_SocketType_ProtocolType_SocketAsyncEventArgs.SetBelong(null);
				}
				return r_RConnectAsync_SocketType_ProtocolType_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// Void InternalShutdown(System.Net.Sockets.SocketShutdown)
		/// </summary>
		protected RMethod r_RInternalShutdown_SocketShutdown;
		public virtual RMethod RInternalShutdown_SocketShutdown
		{
			get
			{
				if(r_RInternalShutdown_SocketShutdown == null)
				{
					r_RInternalShutdown_SocketShutdown = new(this, "InternalShutdown", 0, typeof(System.Net.Sockets.SocketShutdown));
					r_RInternalShutdown_SocketShutdown.SetBelong(this.instance);
				}
				return r_RInternalShutdown_SocketShutdown;
			}
		}

		/// <summary>
		/// System.IAsyncResult UnsafeBeginConnect(System.Net.EndPoint, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RUnsafeBeginConnect_EndPoint_AsyncCallback_Object;
		public virtual RMethod RUnsafeBeginConnect_EndPoint_AsyncCallback_Object
		{
			get
			{
				if(r_RUnsafeBeginConnect_EndPoint_AsyncCallback_Object == null)
				{
					r_RUnsafeBeginConnect_EndPoint_AsyncCallback_Object = new(this, "UnsafeBeginConnect", 0, typeof(System.Net.EndPoint), typeof(System.AsyncCallback), typeof(System.Object));
					r_RUnsafeBeginConnect_EndPoint_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RUnsafeBeginConnect_EndPoint_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult UnsafeBeginSend(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RUnsafeBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object;
		public virtual RMethod RUnsafeBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object
		{
			get
			{
				if(r_RUnsafeBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object == null)
				{
					r_RUnsafeBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object = new(this, "UnsafeBeginSend", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.AsyncCallback), typeof(System.Object));
					r_RUnsafeBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RUnsafeBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult UnsafeBeginReceive(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RUnsafeBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object;
		public virtual RMethod RUnsafeBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object
		{
			get
			{
				if(r_RUnsafeBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object == null)
				{
					r_RUnsafeBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object = new(this, "UnsafeBeginReceive", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.AsyncCallback), typeof(System.Object));
					r_RUnsafeBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RUnsafeBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginMultipleSend(System.Net.BufferOffsetSize[], System.Net.Sockets.SocketFlags, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object;
		public virtual RMethod RBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object == null)
				{
					r_RBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object = new(this, "BeginMultipleSend", 0,  ReleactionUtils.GetType("System.Net.BufferOffsetSize").MakeArrayType(), typeof(System.Net.Sockets.SocketFlags), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult UnsafeBeginMultipleSend(System.Net.BufferOffsetSize[], System.Net.Sockets.SocketFlags, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RUnsafeBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object;
		public virtual RMethod RUnsafeBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object
		{
			get
			{
				if(r_RUnsafeBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object == null)
				{
					r_RUnsafeBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object = new(this, "UnsafeBeginMultipleSend", 0,  ReleactionUtils.GetType("System.Net.BufferOffsetSize").MakeArrayType(), typeof(System.Net.Sockets.SocketFlags), typeof(System.AsyncCallback), typeof(System.Object));
					r_RUnsafeBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RUnsafeBeginMultipleSend_BufferOffsetSizeArray_SocketFlags_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndMultipleSend(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndMultipleSend_IAsyncResult;
		public virtual RMethod REndMultipleSend_IAsyncResult
		{
			get
			{
				if(r_REndMultipleSend_IAsyncResult == null)
				{
					r_REndMultipleSend_IAsyncResult = new(this, "EndMultipleSend", 0, typeof(System.IAsyncResult));
					r_REndMultipleSend_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndMultipleSend_IAsyncResult;
			}
		}

		/// <summary>
		/// Void MultipleSend(System.Net.BufferOffsetSize[], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RMultipleSend_BufferOffsetSizeArray_SocketFlags;
		public virtual RMethod RMultipleSend_BufferOffsetSizeArray_SocketFlags
		{
			get
			{
				if(r_RMultipleSend_BufferOffsetSizeArray_SocketFlags == null)
				{
					r_RMultipleSend_BufferOffsetSizeArray_SocketFlags = new(this, "MultipleSend", 0,  ReleactionUtils.GetType("System.Net.BufferOffsetSize").MakeArrayType(), typeof(System.Net.Sockets.SocketFlags));
					r_RMultipleSend_BufferOffsetSizeArray_SocketFlags.SetBelong(this.instance);
				}
				return r_RMultipleSend_BufferOffsetSizeArray_SocketFlags;
			}
		}

		/// <summary>
		/// Void SetSocketOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32_Boolean;
		public virtual RMethod RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32_Boolean
		{
			get
			{
				if(r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32_Boolean == null)
				{
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32_Boolean = new(this, "SetSocketOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Int32), typeof(System.Boolean));
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SocketDefaults()
		/// </summary>
		protected RMethod r_RSocketDefaults;
		public virtual RMethod RSocketDefaults
		{
			get
			{
				if(r_RSocketDefaults == null)
				{
					r_RSocketDefaults = new(this, "SocketDefaults", 0);
					r_RSocketDefaults.SetBelong(this.instance);
				}
				return r_RSocketDefaults;
			}
		}

		/// <summary>
		/// IntPtr Socket_icall(System.Net.Sockets.AddressFamily, System.Net.Sockets.SocketType, System.Net.Sockets.ProtocolType, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RSocket_icall_AddressFamily_SocketType_ProtocolType_Out_Int32;
		public static RMethod RSocket_icall_AddressFamily_SocketType_ProtocolType_Out_Int32
		{
			get
			{
				if(r_RSocket_icall_AddressFamily_SocketType_ProtocolType_Out_Int32 == null)
				{
					r_RSocket_icall_AddressFamily_SocketType_ProtocolType_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Socket_icall", 0, typeof(System.Net.Sockets.AddressFamily), typeof(System.Net.Sockets.SocketType), typeof(System.Net.Sockets.ProtocolType), typeof(System.Int32).MakeByRefType());
					r_RSocket_icall_AddressFamily_SocketType_ProtocolType_Out_Int32.SetBelong(null);
				}
				return r_RSocket_icall_AddressFamily_SocketType_ProtocolType_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 Available_internal(System.Net.Sockets.SafeSocketHandle, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RAvailable_internal_SafeSocketHandle_Out_Int32;
		public static RMethod RAvailable_internal_SafeSocketHandle_Out_Int32
		{
			get
			{
				if(r_RAvailable_internal_SafeSocketHandle_Out_Int32 == null)
				{
					r_RAvailable_internal_SafeSocketHandle_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Available_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Int32).MakeByRefType());
					r_RAvailable_internal_SafeSocketHandle_Out_Int32.SetBelong(null);
				}
				return r_RAvailable_internal_SafeSocketHandle_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 Available_icall(IntPtr, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RAvailable_icall_IntPtr_Out_Int32;
		public static RMethod RAvailable_icall_IntPtr_Out_Int32
		{
			get
			{
				if(r_RAvailable_icall_IntPtr_Out_Int32 == null)
				{
					r_RAvailable_icall_IntPtr_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Available_icall", 0, typeof(System.IntPtr), typeof(System.Int32).MakeByRefType());
					r_RAvailable_icall_IntPtr_Out_Int32.SetBelong(null);
				}
				return r_RAvailable_icall_IntPtr_Out_Int32;
			}
		}

		/// <summary>
		/// System.Net.SocketAddress LocalEndPoint_internal(System.Net.Sockets.SafeSocketHandle, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RLocalEndPoint_internal_SafeSocketHandle_Int32_Out_Int32;
		public static RMethod RLocalEndPoint_internal_SafeSocketHandle_Int32_Out_Int32
		{
			get
			{
				if(r_RLocalEndPoint_internal_SafeSocketHandle_Int32_Out_Int32 == null)
				{
					r_RLocalEndPoint_internal_SafeSocketHandle_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "LocalEndPoint_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RLocalEndPoint_internal_SafeSocketHandle_Int32_Out_Int32.SetBelong(null);
				}
				return r_RLocalEndPoint_internal_SafeSocketHandle_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// System.Net.SocketAddress LocalEndPoint_icall(IntPtr, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RLocalEndPoint_icall_IntPtr_Int32_Out_Int32;
		public static RMethod RLocalEndPoint_icall_IntPtr_Int32_Out_Int32
		{
			get
			{
				if(r_RLocalEndPoint_icall_IntPtr_Int32_Out_Int32 == null)
				{
					r_RLocalEndPoint_icall_IntPtr_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "LocalEndPoint_icall", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RLocalEndPoint_icall_IntPtr_Int32_Out_Int32.SetBelong(null);
				}
				return r_RLocalEndPoint_icall_IntPtr_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void Blocking_internal(System.Net.Sockets.SafeSocketHandle, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RBlocking_internal_SafeSocketHandle_Boolean_Out_Int32;
		public static RMethod RBlocking_internal_SafeSocketHandle_Boolean_Out_Int32
		{
			get
			{
				if(r_RBlocking_internal_SafeSocketHandle_Boolean_Out_Int32 == null)
				{
					r_RBlocking_internal_SafeSocketHandle_Boolean_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Blocking_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_RBlocking_internal_SafeSocketHandle_Boolean_Out_Int32.SetBelong(null);
				}
				return r_RBlocking_internal_SafeSocketHandle_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Void Blocking_icall(IntPtr, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RBlocking_icall_IntPtr_Boolean_Out_Int32;
		public static RMethod RBlocking_icall_IntPtr_Boolean_Out_Int32
		{
			get
			{
				if(r_RBlocking_icall_IntPtr_Boolean_Out_Int32 == null)
				{
					r_RBlocking_icall_IntPtr_Boolean_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Blocking_icall", 0, typeof(System.IntPtr), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_RBlocking_icall_IntPtr_Boolean_Out_Int32.SetBelong(null);
				}
				return r_RBlocking_icall_IntPtr_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// System.Net.SocketAddress RemoteEndPoint_internal(System.Net.Sockets.SafeSocketHandle, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RRemoteEndPoint_internal_SafeSocketHandle_Int32_Out_Int32;
		public static RMethod RRemoteEndPoint_internal_SafeSocketHandle_Int32_Out_Int32
		{
			get
			{
				if(r_RRemoteEndPoint_internal_SafeSocketHandle_Int32_Out_Int32 == null)
				{
					r_RRemoteEndPoint_internal_SafeSocketHandle_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "RemoteEndPoint_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RRemoteEndPoint_internal_SafeSocketHandle_Int32_Out_Int32.SetBelong(null);
				}
				return r_RRemoteEndPoint_internal_SafeSocketHandle_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// System.Net.SocketAddress RemoteEndPoint_icall(IntPtr, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RRemoteEndPoint_icall_IntPtr_Int32_Out_Int32;
		public static RMethod RRemoteEndPoint_icall_IntPtr_Int32_Out_Int32
		{
			get
			{
				if(r_RRemoteEndPoint_icall_IntPtr_Int32_Out_Int32 == null)
				{
					r_RRemoteEndPoint_icall_IntPtr_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "RemoteEndPoint_icall", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RRemoteEndPoint_icall_IntPtr_Int32_Out_Int32.SetBelong(null);
				}
				return r_RRemoteEndPoint_icall_IntPtr_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void Select(System.Collections.IList, System.Collections.IList, System.Collections.IList, Int32)
		/// </summary>
		protected static RMethod r_RSelect_IList_IList_IList_Int32;
		public static RMethod RSelect_IList_IList_IList_Int32
		{
			get
			{
				if(r_RSelect_IList_IList_IList_Int32 == null)
				{
					r_RSelect_IList_IList_IList_Int32 = new(typeof(System.Net.Sockets.Socket), "Select", 0, typeof(System.Collections.IList), typeof(System.Collections.IList), typeof(System.Collections.IList), typeof(System.Int32));
					r_RSelect_IList_IList_IList_Int32.SetBelong(null);
				}
				return r_RSelect_IList_IList_IList_Int32;
			}
		}

		/// <summary>
		/// Void AddSockets(System.Collections.Generic.List`1[System.Net.Sockets.Socket], System.Collections.IList, System.String)
		/// </summary>
		protected static RMethod r_RAddSockets_List_d_Socket_p__IList_String;
		public static RMethod RAddSockets_List_d_Socket_p__IList_String
		{
			get
			{
				if(r_RAddSockets_List_d_Socket_p__IList_String == null)
				{
					r_RAddSockets_List_d_Socket_p__IList_String = new(typeof(System.Net.Sockets.Socket), "AddSockets", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.Net.Sockets.Socket)), typeof(System.Collections.IList), typeof(System.String));
					r_RAddSockets_List_d_Socket_p__IList_String.SetBelong(null);
				}
				return r_RAddSockets_List_d_Socket_p__IList_String;
			}
		}

		/// <summary>
		/// Void Select_icall(System.Net.Sockets.Socket[] ByRef, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RSelect_icall_Ref_SocketArray_Int32_Out_Int32;
		public static RMethod RSelect_icall_Ref_SocketArray_Int32_Out_Int32
		{
			get
			{
				if(r_RSelect_icall_Ref_SocketArray_Int32_Out_Int32 == null)
				{
					r_RSelect_icall_Ref_SocketArray_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Select_icall", 0, typeof(System.Net.Sockets.Socket).MakeArrayType().MakeByRefType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RSelect_icall_Ref_SocketArray_Int32_Out_Int32.SetBelong(null);
				}
				return r_RSelect_icall_Ref_SocketArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean Poll(Int32, System.Net.Sockets.SelectMode)
		/// </summary>
		protected RMethod r_RPoll_Int32_SelectMode;
		public virtual RMethod RPoll_Int32_SelectMode
		{
			get
			{
				if(r_RPoll_Int32_SelectMode == null)
				{
					r_RPoll_Int32_SelectMode = new(this, "Poll", 0, typeof(System.Int32), typeof(System.Net.Sockets.SelectMode));
					r_RPoll_Int32_SelectMode.SetBelong(this.instance);
				}
				return r_RPoll_Int32_SelectMode;
			}
		}

		/// <summary>
		/// Boolean Poll_internal(System.Net.Sockets.SafeSocketHandle, System.Net.Sockets.SelectMode, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RPoll_internal_SafeSocketHandle_SelectMode_Int32_Out_Int32;
		public static RMethod RPoll_internal_SafeSocketHandle_SelectMode_Int32_Out_Int32
		{
			get
			{
				if(r_RPoll_internal_SafeSocketHandle_SelectMode_Int32_Out_Int32 == null)
				{
					r_RPoll_internal_SafeSocketHandle_SelectMode_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Poll_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Net.Sockets.SelectMode), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RPoll_internal_SafeSocketHandle_SelectMode_Int32_Out_Int32.SetBelong(null);
				}
				return r_RPoll_internal_SafeSocketHandle_SelectMode_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean Poll_icall(IntPtr, System.Net.Sockets.SelectMode, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RPoll_icall_IntPtr_SelectMode_Int32_Out_Int32;
		public static RMethod RPoll_icall_IntPtr_SelectMode_Int32_Out_Int32
		{
			get
			{
				if(r_RPoll_icall_IntPtr_SelectMode_Int32_Out_Int32 == null)
				{
					r_RPoll_icall_IntPtr_SelectMode_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Poll_icall", 0, typeof(System.IntPtr), typeof(System.Net.Sockets.SelectMode), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RPoll_icall_IntPtr_SelectMode_Int32_Out_Int32.SetBelong(null);
				}
				return r_RPoll_icall_IntPtr_SelectMode_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket Accept()
		/// </summary>
		protected RMethod r_RAccept;
		public virtual RMethod RAccept
		{
			get
			{
				if(r_RAccept == null)
				{
					r_RAccept = new(this, "Accept", 0);
					r_RAccept.SetBelong(this.instance);
				}
				return r_RAccept;
			}
		}

		/// <summary>
		/// Void Accept(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RAccept_Socket;
		public virtual RMethod RAccept_Socket
		{
			get
			{
				if(r_RAccept_Socket == null)
				{
					r_RAccept_Socket = new(this, "Accept", 0, typeof(System.Net.Sockets.Socket));
					r_RAccept_Socket.SetBelong(this.instance);
				}
				return r_RAccept_Socket;
			}
		}

		/// <summary>
		/// Boolean AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RAcceptAsync_SocketAsyncEventArgs;
		public virtual RMethod RAcceptAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RAcceptAsync_SocketAsyncEventArgs == null)
				{
					r_RAcceptAsync_SocketAsyncEventArgs = new(this, "AcceptAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RAcceptAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RAcceptAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginAccept(System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginAccept_AsyncCallback_Object;
		public virtual RMethod RBeginAccept_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginAccept_AsyncCallback_Object == null)
				{
					r_RBeginAccept_AsyncCallback_Object = new(this, "BeginAccept", 0, typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginAccept_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginAccept_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginAccept(System.Net.Sockets.Socket, Int32, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginAccept_Socket_Int32_AsyncCallback_Object;
		public virtual RMethod RBeginAccept_Socket_Int32_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginAccept_Socket_Int32_AsyncCallback_Object == null)
				{
					r_RBeginAccept_Socket_Int32_AsyncCallback_Object = new(this, "BeginAccept", 0, typeof(System.Net.Sockets.Socket), typeof(System.Int32), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginAccept_Socket_Int32_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginAccept_Socket_Int32_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket EndAccept(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndAccept_IAsyncResult;
		public virtual RMethod REndAccept_IAsyncResult
		{
			get
			{
				if(r_REndAccept_IAsyncResult == null)
				{
					r_REndAccept_IAsyncResult = new(this, "EndAccept", 0, typeof(System.IAsyncResult));
					r_REndAccept_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndAccept_IAsyncResult;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket EndAccept(Byte[] ByRef, Int32 ByRef, System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndAccept_Out_ByteArray_Out_Int32_IAsyncResult;
		public virtual RMethod REndAccept_Out_ByteArray_Out_Int32_IAsyncResult
		{
			get
			{
				if(r_REndAccept_Out_ByteArray_Out_Int32_IAsyncResult == null)
				{
					r_REndAccept_Out_ByteArray_Out_Int32_IAsyncResult = new(this, "EndAccept", 0, typeof(System.Byte).MakeArrayType().MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.IAsyncResult));
					r_REndAccept_Out_ByteArray_Out_Int32_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndAccept_Out_ByteArray_Out_Int32_IAsyncResult;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SafeSocketHandle Accept_internal(System.Net.Sockets.SafeSocketHandle, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RAccept_internal_SafeSocketHandle_Out_Int32_Boolean;
		public static RMethod RAccept_internal_SafeSocketHandle_Out_Int32_Boolean
		{
			get
			{
				if(r_RAccept_internal_SafeSocketHandle_Out_Int32_Boolean == null)
				{
					r_RAccept_internal_SafeSocketHandle_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Accept_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RAccept_internal_SafeSocketHandle_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RAccept_internal_SafeSocketHandle_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// IntPtr Accept_icall(IntPtr, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RAccept_icall_IntPtr_Out_Int32_Boolean;
		public static RMethod RAccept_icall_IntPtr_Out_Int32_Boolean
		{
			get
			{
				if(r_RAccept_icall_IntPtr_Out_Int32_Boolean == null)
				{
					r_RAccept_icall_IntPtr_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Accept_icall", 0, typeof(System.IntPtr), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RAccept_icall_IntPtr_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RAccept_icall_IntPtr_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Bind(System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RBind_EndPoint;
		public virtual RMethod RBind_EndPoint
		{
			get
			{
				if(r_RBind_EndPoint == null)
				{
					r_RBind_EndPoint = new(this, "Bind", 0, typeof(System.Net.EndPoint));
					r_RBind_EndPoint.SetBelong(this.instance);
				}
				return r_RBind_EndPoint;
			}
		}

		/// <summary>
		/// Void Bind_internal(System.Net.Sockets.SafeSocketHandle, System.Net.SocketAddress, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RBind_internal_SafeSocketHandle_SocketAddress_Out_Int32;
		public static RMethod RBind_internal_SafeSocketHandle_SocketAddress_Out_Int32
		{
			get
			{
				if(r_RBind_internal_SafeSocketHandle_SocketAddress_Out_Int32 == null)
				{
					r_RBind_internal_SafeSocketHandle_SocketAddress_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Bind_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Net.SocketAddress), typeof(System.Int32).MakeByRefType());
					r_RBind_internal_SafeSocketHandle_SocketAddress_Out_Int32.SetBelong(null);
				}
				return r_RBind_internal_SafeSocketHandle_SocketAddress_Out_Int32;
			}
		}

		/// <summary>
		/// Void Bind_icall(IntPtr, System.Net.SocketAddress, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RBind_icall_IntPtr_SocketAddress_Out_Int32;
		public static RMethod RBind_icall_IntPtr_SocketAddress_Out_Int32
		{
			get
			{
				if(r_RBind_icall_IntPtr_SocketAddress_Out_Int32 == null)
				{
					r_RBind_icall_IntPtr_SocketAddress_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Bind_icall", 0, typeof(System.IntPtr), typeof(System.Net.SocketAddress), typeof(System.Int32).MakeByRefType());
					r_RBind_icall_IntPtr_SocketAddress_Out_Int32.SetBelong(null);
				}
				return r_RBind_icall_IntPtr_SocketAddress_Out_Int32;
			}
		}

		/// <summary>
		/// Void Listen(Int32)
		/// </summary>
		protected RMethod r_RListen_Int32;
		public virtual RMethod RListen_Int32
		{
			get
			{
				if(r_RListen_Int32 == null)
				{
					r_RListen_Int32 = new(this, "Listen", 0, typeof(System.Int32));
					r_RListen_Int32.SetBelong(this.instance);
				}
				return r_RListen_Int32;
			}
		}

		/// <summary>
		/// Void Listen_internal(System.Net.Sockets.SafeSocketHandle, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RListen_internal_SafeSocketHandle_Int32_Out_Int32;
		public static RMethod RListen_internal_SafeSocketHandle_Int32_Out_Int32
		{
			get
			{
				if(r_RListen_internal_SafeSocketHandle_Int32_Out_Int32 == null)
				{
					r_RListen_internal_SafeSocketHandle_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Listen_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RListen_internal_SafeSocketHandle_Int32_Out_Int32.SetBelong(null);
				}
				return r_RListen_internal_SafeSocketHandle_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void Listen_icall(IntPtr, Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RListen_icall_IntPtr_Int32_Out_Int32;
		public static RMethod RListen_icall_IntPtr_Int32_Out_Int32
		{
			get
			{
				if(r_RListen_icall_IntPtr_Int32_Out_Int32 == null)
				{
					r_RListen_icall_IntPtr_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Listen_icall", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RListen_icall_IntPtr_Int32_Out_Int32.SetBelong(null);
				}
				return r_RListen_icall_IntPtr_Int32_Out_Int32;
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
		/// Void Connect(System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RConnect_EndPoint;
		public virtual RMethod RConnect_EndPoint
		{
			get
			{
				if(r_RConnect_EndPoint == null)
				{
					r_RConnect_EndPoint = new(this, "Connect", 0, typeof(System.Net.EndPoint));
					r_RConnect_EndPoint.SetBelong(this.instance);
				}
				return r_RConnect_EndPoint;
			}
		}

		/// <summary>
		/// Boolean ConnectAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RConnectAsync_SocketAsyncEventArgs;
		public virtual RMethod RConnectAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RConnectAsync_SocketAsyncEventArgs == null)
				{
					r_RConnectAsync_SocketAsyncEventArgs = new(this, "ConnectAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RConnectAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RConnectAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// Void CancelConnectAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected static RMethod r_RCancelConnectAsync_SocketAsyncEventArgs;
		public static RMethod RCancelConnectAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RCancelConnectAsync_SocketAsyncEventArgs == null)
				{
					r_RCancelConnectAsync_SocketAsyncEventArgs = new(typeof(System.Net.Sockets.Socket), "CancelConnectAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RCancelConnectAsync_SocketAsyncEventArgs.SetBelong(null);
				}
				return r_RCancelConnectAsync_SocketAsyncEventArgs;
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
		/// System.IAsyncResult BeginConnect(System.Net.EndPoint, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginConnect_EndPoint_AsyncCallback_Object;
		public virtual RMethod RBeginConnect_EndPoint_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginConnect_EndPoint_AsyncCallback_Object == null)
				{
					r_RBeginConnect_EndPoint_AsyncCallback_Object = new(this, "BeginConnect", 0, typeof(System.Net.EndPoint), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginConnect_EndPoint_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginConnect_EndPoint_AsyncCallback_Object;
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
		/// Boolean BeginMConnect(System.Net.Sockets.SocketAsyncResult)
		/// </summary>
		protected static RMethod r_RBeginMConnect_SocketAsyncResult;
		public static RMethod RBeginMConnect_SocketAsyncResult
		{
			get
			{
				if(r_RBeginMConnect_SocketAsyncResult == null)
				{
					r_RBeginMConnect_SocketAsyncResult = new(typeof(System.Net.Sockets.Socket), "BeginMConnect", 0,  ReleactionUtils.GetType("System.Net.Sockets.SocketAsyncResult"));
					r_RBeginMConnect_SocketAsyncResult.SetBelong(null);
				}
				return r_RBeginMConnect_SocketAsyncResult;
			}
		}

		/// <summary>
		/// Boolean BeginSConnect(System.Net.Sockets.SocketAsyncResult)
		/// </summary>
		protected static RMethod r_RBeginSConnect_SocketAsyncResult;
		public static RMethod RBeginSConnect_SocketAsyncResult
		{
			get
			{
				if(r_RBeginSConnect_SocketAsyncResult == null)
				{
					r_RBeginSConnect_SocketAsyncResult = new(typeof(System.Net.Sockets.Socket), "BeginSConnect", 0,  ReleactionUtils.GetType("System.Net.Sockets.SocketAsyncResult"));
					r_RBeginSConnect_SocketAsyncResult.SetBelong(null);
				}
				return r_RBeginSConnect_SocketAsyncResult;
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
		/// Void Connect_internal(System.Net.Sockets.SafeSocketHandle, System.Net.SocketAddress, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RConnect_internal_SafeSocketHandle_SocketAddress_Out_Int32_Boolean;
		public static RMethod RConnect_internal_SafeSocketHandle_SocketAddress_Out_Int32_Boolean
		{
			get
			{
				if(r_RConnect_internal_SafeSocketHandle_SocketAddress_Out_Int32_Boolean == null)
				{
					r_RConnect_internal_SafeSocketHandle_SocketAddress_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Connect_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Net.SocketAddress), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RConnect_internal_SafeSocketHandle_SocketAddress_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RConnect_internal_SafeSocketHandle_SocketAddress_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Connect_icall(IntPtr, System.Net.SocketAddress, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RConnect_icall_IntPtr_SocketAddress_Out_Int32_Boolean;
		public static RMethod RConnect_icall_IntPtr_SocketAddress_Out_Int32_Boolean
		{
			get
			{
				if(r_RConnect_icall_IntPtr_SocketAddress_Out_Int32_Boolean == null)
				{
					r_RConnect_icall_IntPtr_SocketAddress_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Connect_icall", 0, typeof(System.IntPtr), typeof(System.Net.SocketAddress), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RConnect_icall_IntPtr_SocketAddress_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RConnect_icall_IntPtr_SocketAddress_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean GetCheckedIPs(System.Net.Sockets.SocketAsyncEventArgs, System.Net.IPAddress[] ByRef)
		/// </summary>
		protected RMethod r_RGetCheckedIPs_SocketAsyncEventArgs_Out_IPAddressArray;
		public virtual RMethod RGetCheckedIPs_SocketAsyncEventArgs_Out_IPAddressArray
		{
			get
			{
				if(r_RGetCheckedIPs_SocketAsyncEventArgs_Out_IPAddressArray == null)
				{
					r_RGetCheckedIPs_SocketAsyncEventArgs_Out_IPAddressArray = new(this, "GetCheckedIPs", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs), typeof(System.Net.IPAddress).MakeArrayType().MakeByRefType());
					r_RGetCheckedIPs_SocketAsyncEventArgs_Out_IPAddressArray.SetBelong(this.instance);
				}
				return r_RGetCheckedIPs_SocketAsyncEventArgs_Out_IPAddressArray;
			}
		}

		/// <summary>
		/// Void Disconnect(Boolean)
		/// </summary>
		protected RMethod r_RDisconnect_Boolean;
		public virtual RMethod RDisconnect_Boolean
		{
			get
			{
				if(r_RDisconnect_Boolean == null)
				{
					r_RDisconnect_Boolean = new(this, "Disconnect", 0, typeof(System.Boolean));
					r_RDisconnect_Boolean.SetBelong(this.instance);
				}
				return r_RDisconnect_Boolean;
			}
		}

		/// <summary>
		/// Boolean DisconnectAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RDisconnectAsync_SocketAsyncEventArgs;
		public virtual RMethod RDisconnectAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RDisconnectAsync_SocketAsyncEventArgs == null)
				{
					r_RDisconnectAsync_SocketAsyncEventArgs = new(this, "DisconnectAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RDisconnectAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RDisconnectAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginDisconnect(Boolean, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginDisconnect_Boolean_AsyncCallback_Object;
		public virtual RMethod RBeginDisconnect_Boolean_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginDisconnect_Boolean_AsyncCallback_Object == null)
				{
					r_RBeginDisconnect_Boolean_AsyncCallback_Object = new(this, "BeginDisconnect", 0, typeof(System.Boolean), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginDisconnect_Boolean_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginDisconnect_Boolean_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void EndDisconnect(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndDisconnect_IAsyncResult;
		public virtual RMethod REndDisconnect_IAsyncResult
		{
			get
			{
				if(r_REndDisconnect_IAsyncResult == null)
				{
					r_REndDisconnect_IAsyncResult = new(this, "EndDisconnect", 0, typeof(System.IAsyncResult));
					r_REndDisconnect_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndDisconnect_IAsyncResult;
			}
		}

		/// <summary>
		/// Void Disconnect_internal(System.Net.Sockets.SafeSocketHandle, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RDisconnect_internal_SafeSocketHandle_Boolean_Out_Int32;
		public static RMethod RDisconnect_internal_SafeSocketHandle_Boolean_Out_Int32
		{
			get
			{
				if(r_RDisconnect_internal_SafeSocketHandle_Boolean_Out_Int32 == null)
				{
					r_RDisconnect_internal_SafeSocketHandle_Boolean_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Disconnect_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_RDisconnect_internal_SafeSocketHandle_Boolean_Out_Int32.SetBelong(null);
				}
				return r_RDisconnect_internal_SafeSocketHandle_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Void Disconnect_icall(IntPtr, Boolean, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RDisconnect_icall_IntPtr_Boolean_Out_Int32;
		public static RMethod RDisconnect_icall_IntPtr_Boolean_Out_Int32
		{
			get
			{
				if(r_RDisconnect_icall_IntPtr_Boolean_Out_Int32 == null)
				{
					r_RDisconnect_icall_IntPtr_Boolean_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Disconnect_icall", 0, typeof(System.IntPtr), typeof(System.Boolean), typeof(System.Int32).MakeByRefType());
					r_RDisconnect_icall_IntPtr_Boolean_Out_Int32.SetBelong(null);
				}
				return r_RDisconnect_icall_IntPtr_Boolean_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 Receive(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError;
		public virtual RMethod RReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError
		{
			get
			{
				if(r_RReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError == null)
				{
					r_RReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError = new(this, "Receive", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError.SetBelong(this.instance);
				}
				return r_RReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Receive(System.Memory`1[System.Byte], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RReceive_Memory_d_Byte_p__Int32_Int32_SocketFlags_Out_SocketError;
		public virtual RMethod RReceive_Memory_d_Byte_p__Int32_Int32_SocketFlags_Out_SocketError
		{
			get
			{
				if(r_RReceive_Memory_d_Byte_p__Int32_Int32_SocketFlags_Out_SocketError == null)
				{
					r_RReceive_Memory_d_Byte_p__Int32_Int32_SocketFlags_Out_SocketError = new(this, "Receive", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RReceive_Memory_d_Byte_p__Int32_Int32_SocketFlags_Out_SocketError.SetBelong(this.instance);
				}
				return r_RReceive_Memory_d_Byte_p__Int32_Int32_SocketFlags_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Receive(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError;
		public virtual RMethod RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError
		{
			get
			{
				if(r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError == null)
				{
					r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError = new(this, "Receive", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError.SetBelong(this.instance);
				}
				return r_RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Receive(System.Span`1[System.Byte], System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RReceive_Span_d_Byte_p__SocketFlags_Out_SocketError;
		public virtual RMethod RReceive_Span_d_Byte_p__SocketFlags_Out_SocketError
		{
			get
			{
				if(r_RReceive_Span_d_Byte_p__SocketFlags_Out_SocketError == null)
				{
					r_RReceive_Span_d_Byte_p__SocketFlags_Out_SocketError = new(this, "Receive", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RReceive_Span_d_Byte_p__SocketFlags_Out_SocketError.SetBelong(this.instance);
				}
				return r_RReceive_Span_d_Byte_p__SocketFlags_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Send(System.ReadOnlySpan`1[System.Byte], System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags_Out_SocketError;
		public virtual RMethod RSend_ReadOnlySpan_d_Byte_p__SocketFlags_Out_SocketError
		{
			get
			{
				if(r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags_Out_SocketError == null)
				{
					r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags_Out_SocketError = new(this, "Send", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags_Out_SocketError.SetBelong(this.instance);
				}
				return r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Receive(System.Span`1[System.Byte], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RReceive_Span_d_Byte_p__SocketFlags;
		public virtual RMethod RReceive_Span_d_Byte_p__SocketFlags
		{
			get
			{
				if(r_RReceive_Span_d_Byte_p__SocketFlags == null)
				{
					r_RReceive_Span_d_Byte_p__SocketFlags = new(this, "Receive", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags));
					r_RReceive_Span_d_Byte_p__SocketFlags.SetBelong(this.instance);
				}
				return r_RReceive_Span_d_Byte_p__SocketFlags;
			}
		}

		/// <summary>
		/// Int32 Receive(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_RReceive_Span_d_Byte_p_;
		public virtual RMethod RReceive_Span_d_Byte_p_
		{
			get
			{
				if(r_RReceive_Span_d_Byte_p_ == null)
				{
					r_RReceive_Span_d_Byte_p_ = new(this, "Receive", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_RReceive_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RReceive_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Boolean ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RReceiveAsync_SocketAsyncEventArgs;
		public virtual RMethod RReceiveAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RReceiveAsync_SocketAsyncEventArgs == null)
				{
					r_RReceiveAsync_SocketAsyncEventArgs = new(this, "ReceiveAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RReceiveAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RReceiveAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReceive(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object;
		public virtual RMethod RBeginReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object == null)
				{
					r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object = new(this, "BeginReceive", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType(), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReceive(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object;
		public virtual RMethod RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object == null)
				{
					r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object = new(this, "BeginReceive", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType(), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndReceive(System.IAsyncResult, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_REndReceive_IAsyncResult_Out_SocketError;
		public virtual RMethod REndReceive_IAsyncResult_Out_SocketError
		{
			get
			{
				if(r_REndReceive_IAsyncResult_Out_SocketError == null)
				{
					r_REndReceive_IAsyncResult_Out_SocketError = new(this, "EndReceive", 0, typeof(System.IAsyncResult), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_REndReceive_IAsyncResult_Out_SocketError.SetBelong(this.instance);
				}
				return r_REndReceive_IAsyncResult_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Receive_internal(System.Net.Sockets.SafeSocketHandle, WSABUF*, Int32, System.Net.Sockets.SocketFlags, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RReceive_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean;
		public static RMethod RReceive_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean
		{
			get
			{
				if(r_RReceive_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean == null)
				{
					r_RReceive_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Receive_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"),  ReleactionUtils.GetType("System.Net.Sockets.Socket+WSABUF").MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RReceive_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RReceive_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 Receive_array_icall(IntPtr, WSABUF*, Int32, System.Net.Sockets.SocketFlags, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RReceive_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean;
		public static RMethod RReceive_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean
		{
			get
			{
				if(r_RReceive_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean == null)
				{
					r_RReceive_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Receive_array_icall", 0, typeof(System.IntPtr),  ReleactionUtils.GetType("System.Net.Sockets.Socket+WSABUF").MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RReceive_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RReceive_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 Receive_internal(System.Net.Sockets.SafeSocketHandle, Byte*, Int32, System.Net.Sockets.SocketFlags, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RReceive_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean;
		public static RMethod RReceive_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean
		{
			get
			{
				if(r_RReceive_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean == null)
				{
					r_RReceive_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Receive_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RReceive_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RReceive_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 Receive_icall(IntPtr, Byte*, Int32, System.Net.Sockets.SocketFlags, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RReceive_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean;
		public static RMethod RReceive_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean
		{
			get
			{
				if(r_RReceive_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean == null)
				{
					r_RReceive_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Receive_icall", 0, typeof(System.IntPtr), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RReceive_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RReceive_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 ReceiveFrom(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint ByRef)
		/// </summary>
		protected RMethod r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint;
		public virtual RMethod RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint
		{
			get
			{
				if(r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint == null)
				{
					r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint = new(this, "ReceiveFrom", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint).MakeByRefType());
					r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint.SetBelong(this.instance);
				}
				return r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint;
			}
		}

		/// <summary>
		/// Int32 ReceiveFrom(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint ByRef, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError;
		public virtual RMethod RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError
		{
			get
			{
				if(r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError == null)
				{
					r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError = new(this, "ReceiveFrom", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint).MakeByRefType(), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError.SetBelong(this.instance);
				}
				return r_RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 ReceiveFrom(System.Memory`1[System.Byte], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint ByRef, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RReceiveFrom_Memory_d_Byte_p__Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError;
		public virtual RMethod RReceiveFrom_Memory_d_Byte_p__Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError
		{
			get
			{
				if(r_RReceiveFrom_Memory_d_Byte_p__Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError == null)
				{
					r_RReceiveFrom_Memory_d_Byte_p__Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError = new(this, "ReceiveFrom", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint).MakeByRefType(), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RReceiveFrom_Memory_d_Byte_p__Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError.SetBelong(this.instance);
				}
				return r_RReceiveFrom_Memory_d_Byte_p__Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError;
			}
		}

		/// <summary>
		/// Boolean ReceiveFromAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RReceiveFromAsync_SocketAsyncEventArgs;
		public virtual RMethod RReceiveFromAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RReceiveFromAsync_SocketAsyncEventArgs == null)
				{
					r_RReceiveFromAsync_SocketAsyncEventArgs = new(this, "ReceiveFromAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RReceiveFromAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RReceiveFromAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReceiveFrom(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint ByRef, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object;
		public virtual RMethod RBeginReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object == null)
				{
					r_RBeginReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object = new(this, "BeginReceiveFrom", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint).MakeByRefType(), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndReceiveFrom(System.IAsyncResult, System.Net.EndPoint ByRef)
		/// </summary>
		protected RMethod r_REndReceiveFrom_IAsyncResult_Ref_EndPoint;
		public virtual RMethod REndReceiveFrom_IAsyncResult_Ref_EndPoint
		{
			get
			{
				if(r_REndReceiveFrom_IAsyncResult_Ref_EndPoint == null)
				{
					r_REndReceiveFrom_IAsyncResult_Ref_EndPoint = new(this, "EndReceiveFrom", 0, typeof(System.IAsyncResult), typeof(System.Net.EndPoint).MakeByRefType());
					r_REndReceiveFrom_IAsyncResult_Ref_EndPoint.SetBelong(this.instance);
				}
				return r_REndReceiveFrom_IAsyncResult_Ref_EndPoint;
			}
		}

		/// <summary>
		/// Int32 EndReceiveFrom_internal(System.Net.Sockets.SocketAsyncResult, System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_REndReceiveFrom_internal_SocketAsyncResult_SocketAsyncEventArgs;
		public virtual RMethod REndReceiveFrom_internal_SocketAsyncResult_SocketAsyncEventArgs
		{
			get
			{
				if(r_REndReceiveFrom_internal_SocketAsyncResult_SocketAsyncEventArgs == null)
				{
					r_REndReceiveFrom_internal_SocketAsyncResult_SocketAsyncEventArgs = new(this, "EndReceiveFrom_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SocketAsyncResult"), typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_REndReceiveFrom_internal_SocketAsyncResult_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_REndReceiveFrom_internal_SocketAsyncResult_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// Int32 ReceiveFrom_internal(System.Net.Sockets.SafeSocketHandle, Byte*, Int32, System.Net.Sockets.SocketFlags, System.Net.SocketAddress ByRef, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RReceiveFrom_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean;
		public static RMethod RReceiveFrom_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean
		{
			get
			{
				if(r_RReceiveFrom_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean == null)
				{
					r_RReceiveFrom_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "ReceiveFrom_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.SocketAddress).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RReceiveFrom_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RReceiveFrom_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 ReceiveFrom_icall(IntPtr, Byte*, Int32, System.Net.Sockets.SocketFlags, System.Net.SocketAddress ByRef, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RReceiveFrom_icall_IntPtr_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean;
		public static RMethod RReceiveFrom_icall_IntPtr_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean
		{
			get
			{
				if(r_RReceiveFrom_icall_IntPtr_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean == null)
				{
					r_RReceiveFrom_icall_IntPtr_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "ReceiveFrom_icall", 0, typeof(System.IntPtr), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.SocketAddress).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RReceiveFrom_icall_IntPtr_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RReceiveFrom_icall_IntPtr_BytePointer_Int32_SocketFlags_Ref_SocketAddress_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 ReceiveMessageFrom(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags ByRef, System.Net.EndPoint ByRef, System.Net.Sockets.IPPacketInformation ByRef)
		/// </summary>
		protected RMethod r_RReceiveMessageFrom_ByteArray_Int32_Int32_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation;
		public virtual RMethod RReceiveMessageFrom_ByteArray_Int32_Int32_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation
		{
			get
			{
				if(r_RReceiveMessageFrom_ByteArray_Int32_Int32_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation == null)
				{
					r_RReceiveMessageFrom_ByteArray_Int32_Int32_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation = new(this, "ReceiveMessageFrom", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags).MakeByRefType(), typeof(System.Net.EndPoint).MakeByRefType(), typeof(System.Net.Sockets.IPPacketInformation).MakeByRefType());
					r_RReceiveMessageFrom_ByteArray_Int32_Int32_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation.SetBelong(this.instance);
				}
				return r_RReceiveMessageFrom_ByteArray_Int32_Int32_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation;
			}
		}

		/// <summary>
		/// Boolean ReceiveMessageFromAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RReceiveMessageFromAsync_SocketAsyncEventArgs;
		public virtual RMethod RReceiveMessageFromAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RReceiveMessageFromAsync_SocketAsyncEventArgs == null)
				{
					r_RReceiveMessageFromAsync_SocketAsyncEventArgs = new(this, "ReceiveMessageFromAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RReceiveMessageFromAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RReceiveMessageFromAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginReceiveMessageFrom(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint ByRef, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginReceiveMessageFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object;
		public virtual RMethod RBeginReceiveMessageFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginReceiveMessageFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object == null)
				{
					r_RBeginReceiveMessageFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object = new(this, "BeginReceiveMessageFrom", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint).MakeByRefType(), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginReceiveMessageFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginReceiveMessageFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndReceiveMessageFrom(System.IAsyncResult, System.Net.Sockets.SocketFlags ByRef, System.Net.EndPoint ByRef, System.Net.Sockets.IPPacketInformation ByRef)
		/// </summary>
		protected RMethod r_REndReceiveMessageFrom_IAsyncResult_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation;
		public virtual RMethod REndReceiveMessageFrom_IAsyncResult_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation
		{
			get
			{
				if(r_REndReceiveMessageFrom_IAsyncResult_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation == null)
				{
					r_REndReceiveMessageFrom_IAsyncResult_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation = new(this, "EndReceiveMessageFrom", 0, typeof(System.IAsyncResult), typeof(System.Net.Sockets.SocketFlags).MakeByRefType(), typeof(System.Net.EndPoint).MakeByRefType(), typeof(System.Net.Sockets.IPPacketInformation).MakeByRefType());
					r_REndReceiveMessageFrom_IAsyncResult_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation.SetBelong(this.instance);
				}
				return r_REndReceiveMessageFrom_IAsyncResult_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation;
			}
		}

		/// <summary>
		/// Int32 Send(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError;
		public virtual RMethod RSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError
		{
			get
			{
				if(r_RSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError == null)
				{
					r_RSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError = new(this, "Send", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError.SetBelong(this.instance);
				}
				return r_RSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Send(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError;
		public virtual RMethod RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError
		{
			get
			{
				if(r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError == null)
				{
					r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError = new(this, "Send", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError.SetBelong(this.instance);
				}
				return r_RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Send(System.ReadOnlySpan`1[System.Byte], System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags;
		public virtual RMethod RSend_ReadOnlySpan_d_Byte_p__SocketFlags
		{
			get
			{
				if(r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags == null)
				{
					r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags = new(this, "Send", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Net.Sockets.SocketFlags));
					r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags.SetBelong(this.instance);
				}
				return r_RSend_ReadOnlySpan_d_Byte_p__SocketFlags;
			}
		}

		/// <summary>
		/// Int32 Send(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_RSend_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RSend_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_RSend_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_RSend_ReadOnlySpan_d_Byte_p_ = new(this, "Send", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_RSend_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RSend_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Boolean SendAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RSendAsync_SocketAsyncEventArgs;
		public virtual RMethod RSendAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RSendAsync_SocketAsyncEventArgs == null)
				{
					r_RSendAsync_SocketAsyncEventArgs = new(this, "SendAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RSendAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RSendAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginSend(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object;
		public virtual RMethod RBeginSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object == null)
				{
					r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object = new(this, "BeginSend", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType(), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void BeginSendCallback(System.Net.Sockets.SocketAsyncResult, Int32)
		/// </summary>
		protected static RMethod r_RBeginSendCallback_SocketAsyncResult_Int32;
		public static RMethod RBeginSendCallback_SocketAsyncResult_Int32
		{
			get
			{
				if(r_RBeginSendCallback_SocketAsyncResult_Int32 == null)
				{
					r_RBeginSendCallback_SocketAsyncResult_Int32 = new(typeof(System.Net.Sockets.Socket), "BeginSendCallback", 0,  ReleactionUtils.GetType("System.Net.Sockets.SocketAsyncResult"), typeof(System.Int32));
					r_RBeginSendCallback_SocketAsyncResult_Int32.SetBelong(null);
				}
				return r_RBeginSendCallback_SocketAsyncResult_Int32;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginSend(System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]], System.Net.Sockets.SocketFlags, System.Net.Sockets.SocketError ByRef, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object;
		public virtual RMethod RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object == null)
				{
					r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object = new(this, "BeginSend", 0, typeof(System.Collections.Generic.IList<>).MakeGenericType(typeof(System.ArraySegment<>).MakeGenericType(typeof(System.Byte))), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.Sockets.SocketError).MakeByRefType(), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Int32 EndSend(System.IAsyncResult, System.Net.Sockets.SocketError ByRef)
		/// </summary>
		protected RMethod r_REndSend_IAsyncResult_Out_SocketError;
		public virtual RMethod REndSend_IAsyncResult_Out_SocketError
		{
			get
			{
				if(r_REndSend_IAsyncResult_Out_SocketError == null)
				{
					r_REndSend_IAsyncResult_Out_SocketError = new(this, "EndSend", 0, typeof(System.IAsyncResult), typeof(System.Net.Sockets.SocketError).MakeByRefType());
					r_REndSend_IAsyncResult_Out_SocketError.SetBelong(this.instance);
				}
				return r_REndSend_IAsyncResult_Out_SocketError;
			}
		}

		/// <summary>
		/// Int32 Send_internal(System.Net.Sockets.SafeSocketHandle, WSABUF*, Int32, System.Net.Sockets.SocketFlags, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSend_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean;
		public static RMethod RSend_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean
		{
			get
			{
				if(r_RSend_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean == null)
				{
					r_RSend_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Send_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"),  ReleactionUtils.GetType("System.Net.Sockets.Socket+WSABUF").MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RSend_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RSend_internal_SafeSocketHandle_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 Send_array_icall(IntPtr, WSABUF*, Int32, System.Net.Sockets.SocketFlags, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSend_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean;
		public static RMethod RSend_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean
		{
			get
			{
				if(r_RSend_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean == null)
				{
					r_RSend_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Send_array_icall", 0, typeof(System.IntPtr),  ReleactionUtils.GetType("System.Net.Sockets.Socket+WSABUF").MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RSend_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RSend_array_icall_IntPtr_WSABUFPointer_Int32_SocketFlags_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 Send_internal(System.Net.Sockets.SafeSocketHandle, Byte*, Int32, System.Net.Sockets.SocketFlags, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSend_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean;
		public static RMethod RSend_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean
		{
			get
			{
				if(r_RSend_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean == null)
				{
					r_RSend_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Send_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RSend_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RSend_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 Send_icall(IntPtr, Byte*, Int32, System.Net.Sockets.SocketFlags, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSend_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean;
		public static RMethod RSend_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean
		{
			get
			{
				if(r_RSend_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean == null)
				{
					r_RSend_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "Send_icall", 0, typeof(System.IntPtr), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RSend_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RSend_icall_IntPtr_BytePointer_Int32_SocketFlags_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 SendTo(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint;
		public virtual RMethod RSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint
		{
			get
			{
				if(r_RSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint == null)
				{
					r_RSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint = new(this, "SendTo", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint));
					r_RSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint.SetBelong(this.instance);
				}
				return r_RSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint;
			}
		}

		/// <summary>
		/// Int32 SendTo(System.Memory`1[System.Byte], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint)
		/// </summary>
		protected RMethod r_RSendTo_Memory_d_Byte_p__Int32_Int32_SocketFlags_EndPoint;
		public virtual RMethod RSendTo_Memory_d_Byte_p__Int32_Int32_SocketFlags_EndPoint
		{
			get
			{
				if(r_RSendTo_Memory_d_Byte_p__Int32_Int32_SocketFlags_EndPoint == null)
				{
					r_RSendTo_Memory_d_Byte_p__Int32_Int32_SocketFlags_EndPoint = new(this, "SendTo", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint));
					r_RSendTo_Memory_d_Byte_p__Int32_Int32_SocketFlags_EndPoint.SetBelong(this.instance);
				}
				return r_RSendTo_Memory_d_Byte_p__Int32_Int32_SocketFlags_EndPoint;
			}
		}

		/// <summary>
		/// Boolean SendToAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RSendToAsync_SocketAsyncEventArgs;
		public virtual RMethod RSendToAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RSendToAsync_SocketAsyncEventArgs == null)
				{
					r_RSendToAsync_SocketAsyncEventArgs = new(this, "SendToAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RSendToAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RSendToAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginSendTo(Byte[], Int32, Int32, System.Net.Sockets.SocketFlags, System.Net.EndPoint, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object;
		public virtual RMethod RBeginSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object == null)
				{
					r_RBeginSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object = new(this, "BeginSendTo", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.EndPoint), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void BeginSendToCallback(System.Net.Sockets.SocketAsyncResult, Int32)
		/// </summary>
		protected static RMethod r_RBeginSendToCallback_SocketAsyncResult_Int32;
		public static RMethod RBeginSendToCallback_SocketAsyncResult_Int32
		{
			get
			{
				if(r_RBeginSendToCallback_SocketAsyncResult_Int32 == null)
				{
					r_RBeginSendToCallback_SocketAsyncResult_Int32 = new(typeof(System.Net.Sockets.Socket), "BeginSendToCallback", 0,  ReleactionUtils.GetType("System.Net.Sockets.SocketAsyncResult"), typeof(System.Int32));
					r_RBeginSendToCallback_SocketAsyncResult_Int32.SetBelong(null);
				}
				return r_RBeginSendToCallback_SocketAsyncResult_Int32;
			}
		}

		/// <summary>
		/// Int32 EndSendTo(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndSendTo_IAsyncResult;
		public virtual RMethod REndSendTo_IAsyncResult
		{
			get
			{
				if(r_REndSendTo_IAsyncResult == null)
				{
					r_REndSendTo_IAsyncResult = new(this, "EndSendTo", 0, typeof(System.IAsyncResult));
					r_REndSendTo_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndSendTo_IAsyncResult;
			}
		}

		/// <summary>
		/// Int32 SendTo_internal(System.Net.Sockets.SafeSocketHandle, Byte*, Int32, System.Net.Sockets.SocketFlags, System.Net.SocketAddress, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSendTo_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean;
		public static RMethod RSendTo_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean
		{
			get
			{
				if(r_RSendTo_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean == null)
				{
					r_RSendTo_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "SendTo_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.SocketAddress), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RSendTo_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RSendTo_internal_SafeSocketHandle_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 SendTo_icall(IntPtr, Byte*, Int32, System.Net.Sockets.SocketFlags, System.Net.SocketAddress, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSendTo_icall_IntPtr_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean;
		public static RMethod RSendTo_icall_IntPtr_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean
		{
			get
			{
				if(r_RSendTo_icall_IntPtr_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean == null)
				{
					r_RSendTo_icall_IntPtr_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "SendTo_icall", 0, typeof(System.IntPtr), typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags), typeof(System.Net.SocketAddress), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RSendTo_icall_IntPtr_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RSendTo_icall_IntPtr_BytePointer_Int32_SocketFlags_SocketAddress_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SendFile(System.String, Byte[], Byte[], System.Net.Sockets.TransmitFileOptions)
		/// </summary>
		protected RMethod r_RSendFile_String_ByteArray_ByteArray_TransmitFileOptions;
		public virtual RMethod RSendFile_String_ByteArray_ByteArray_TransmitFileOptions
		{
			get
			{
				if(r_RSendFile_String_ByteArray_ByteArray_TransmitFileOptions == null)
				{
					r_RSendFile_String_ByteArray_ByteArray_TransmitFileOptions = new(this, "SendFile", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Net.Sockets.TransmitFileOptions));
					r_RSendFile_String_ByteArray_ByteArray_TransmitFileOptions.SetBelong(this.instance);
				}
				return r_RSendFile_String_ByteArray_ByteArray_TransmitFileOptions;
			}
		}

		/// <summary>
		/// System.IAsyncResult BeginSendFile(System.String, Byte[], Byte[], System.Net.Sockets.TransmitFileOptions, System.AsyncCallback, System.Object)
		/// </summary>
		protected RMethod r_RBeginSendFile_String_ByteArray_ByteArray_TransmitFileOptions_AsyncCallback_Object;
		public virtual RMethod RBeginSendFile_String_ByteArray_ByteArray_TransmitFileOptions_AsyncCallback_Object
		{
			get
			{
				if(r_RBeginSendFile_String_ByteArray_ByteArray_TransmitFileOptions_AsyncCallback_Object == null)
				{
					r_RBeginSendFile_String_ByteArray_ByteArray_TransmitFileOptions_AsyncCallback_Object = new(this, "BeginSendFile", 0, typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Net.Sockets.TransmitFileOptions), typeof(System.AsyncCallback), typeof(System.Object));
					r_RBeginSendFile_String_ByteArray_ByteArray_TransmitFileOptions_AsyncCallback_Object.SetBelong(this.instance);
				}
				return r_RBeginSendFile_String_ByteArray_ByteArray_TransmitFileOptions_AsyncCallback_Object;
			}
		}

		/// <summary>
		/// Void EndSendFile(System.IAsyncResult)
		/// </summary>
		protected RMethod r_REndSendFile_IAsyncResult;
		public virtual RMethod REndSendFile_IAsyncResult
		{
			get
			{
				if(r_REndSendFile_IAsyncResult == null)
				{
					r_REndSendFile_IAsyncResult = new(this, "EndSendFile", 0, typeof(System.IAsyncResult));
					r_REndSendFile_IAsyncResult.SetBelong(this.instance);
				}
				return r_REndSendFile_IAsyncResult;
			}
		}

		/// <summary>
		/// Boolean SendFile_internal(System.Net.Sockets.SafeSocketHandle, System.String, Byte[], Byte[], System.Net.Sockets.TransmitFileOptions, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSendFile_internal_SafeSocketHandle_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean;
		public static RMethod RSendFile_internal_SafeSocketHandle_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean
		{
			get
			{
				if(r_RSendFile_internal_SafeSocketHandle_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean == null)
				{
					r_RSendFile_internal_SafeSocketHandle_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "SendFile_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Net.Sockets.TransmitFileOptions), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RSendFile_internal_SafeSocketHandle_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RSendFile_internal_SafeSocketHandle_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendFile_icall(IntPtr, System.String, Byte[], Byte[], System.Net.Sockets.TransmitFileOptions, Int32 ByRef, Boolean)
		/// </summary>
		protected static RMethod r_RSendFile_icall_IntPtr_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean;
		public static RMethod RSendFile_icall_IntPtr_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean
		{
			get
			{
				if(r_RSendFile_icall_IntPtr_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean == null)
				{
					r_RSendFile_icall_IntPtr_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean = new(typeof(System.Net.Sockets.Socket), "SendFile_icall", 0, typeof(System.IntPtr), typeof(System.String), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Net.Sockets.TransmitFileOptions), typeof(System.Int32).MakeByRefType(), typeof(System.Boolean));
					r_RSendFile_icall_IntPtr_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean.SetBelong(null);
				}
				return r_RSendFile_icall_IntPtr_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RSendPacketsAsync_SocketAsyncEventArgs;
		public virtual RMethod RSendPacketsAsync_SocketAsyncEventArgs
		{
			get
			{
				if(r_RSendPacketsAsync_SocketAsyncEventArgs == null)
				{
					r_RSendPacketsAsync_SocketAsyncEventArgs = new(this, "SendPacketsAsync", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RSendPacketsAsync_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RSendPacketsAsync_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// Boolean Duplicate_icall(IntPtr, Int32, IntPtr ByRef, System.IO.MonoIOError ByRef)
		/// </summary>
		protected static RMethod r_RDuplicate_icall_IntPtr_Int32_Out_IntPtr_Out_MonoIOError;
		public static RMethod RDuplicate_icall_IntPtr_Int32_Out_IntPtr_Out_MonoIOError
		{
			get
			{
				if(r_RDuplicate_icall_IntPtr_Int32_Out_IntPtr_Out_MonoIOError == null)
				{
					r_RDuplicate_icall_IntPtr_Int32_Out_IntPtr_Out_MonoIOError = new(typeof(System.Net.Sockets.Socket), "Duplicate_icall", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.IntPtr).MakeByRefType(),  ReleactionUtils.GetType("System.IO.MonoIOError").MakeByRefType());
					r_RDuplicate_icall_IntPtr_Int32_Out_IntPtr_Out_MonoIOError.SetBelong(null);
				}
				return r_RDuplicate_icall_IntPtr_Int32_Out_IntPtr_Out_MonoIOError;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketInformation DuplicateAndClose(Int32)
		/// </summary>
		protected RMethod r_RDuplicateAndClose_Int32;
		public virtual RMethod RDuplicateAndClose_Int32
		{
			get
			{
				if(r_RDuplicateAndClose_Int32 == null)
				{
					r_RDuplicateAndClose_Int32 = new(this, "DuplicateAndClose", 0, typeof(System.Int32));
					r_RDuplicateAndClose_Int32.SetBelong(this.instance);
				}
				return r_RDuplicateAndClose_Int32;
			}
		}

		/// <summary>
		/// Void GetSocketOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, Byte[])
		/// </summary>
		protected RMethod r_RGetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray;
		public virtual RMethod RGetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray
		{
			get
			{
				if(r_RGetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray == null)
				{
					r_RGetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray = new(this, "GetSocketOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Byte).MakeArrayType());
					r_RGetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray.SetBelong(this.instance);
				}
				return r_RGetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray;
			}
		}

		/// <summary>
		/// Byte[] GetSocketOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, Int32)
		/// </summary>
		protected RMethod r_RGetSocketOption_SocketOptionLevel_SocketOptionName_Int32;
		public virtual RMethod RGetSocketOption_SocketOptionLevel_SocketOptionName_Int32
		{
			get
			{
				if(r_RGetSocketOption_SocketOptionLevel_SocketOptionName_Int32 == null)
				{
					r_RGetSocketOption_SocketOptionLevel_SocketOptionName_Int32 = new(this, "GetSocketOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Int32));
					r_RGetSocketOption_SocketOptionLevel_SocketOptionName_Int32.SetBelong(this.instance);
				}
				return r_RGetSocketOption_SocketOptionLevel_SocketOptionName_Int32;
			}
		}

		/// <summary>
		/// System.Object GetSocketOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName)
		/// </summary>
		protected RMethod r_RGetSocketOption_SocketOptionLevel_SocketOptionName;
		public virtual RMethod RGetSocketOption_SocketOptionLevel_SocketOptionName
		{
			get
			{
				if(r_RGetSocketOption_SocketOptionLevel_SocketOptionName == null)
				{
					r_RGetSocketOption_SocketOptionLevel_SocketOptionName = new(this, "GetSocketOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName));
					r_RGetSocketOption_SocketOptionLevel_SocketOptionName.SetBelong(this.instance);
				}
				return r_RGetSocketOption_SocketOptionLevel_SocketOptionName;
			}
		}

		/// <summary>
		/// Void GetSocketOption_arr_internal(System.Net.Sockets.SafeSocketHandle, System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, Byte[] ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RGetSocketOption_arr_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32;
		public static RMethod RGetSocketOption_arr_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32
		{
			get
			{
				if(r_RGetSocketOption_arr_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32 == null)
				{
					r_RGetSocketOption_arr_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "GetSocketOption_arr_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Byte).MakeArrayType().MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RGetSocketOption_arr_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32.SetBelong(null);
				}
				return r_RGetSocketOption_arr_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32;
			}
		}

		/// <summary>
		/// Void GetSocketOption_arr_icall(IntPtr, System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, Byte[] ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RGetSocketOption_arr_icall_IntPtr_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32;
		public static RMethod RGetSocketOption_arr_icall_IntPtr_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32
		{
			get
			{
				if(r_RGetSocketOption_arr_icall_IntPtr_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32 == null)
				{
					r_RGetSocketOption_arr_icall_IntPtr_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "GetSocketOption_arr_icall", 0, typeof(System.IntPtr), typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Byte).MakeArrayType().MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RGetSocketOption_arr_icall_IntPtr_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32.SetBelong(null);
				}
				return r_RGetSocketOption_arr_icall_IntPtr_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32;
			}
		}

		/// <summary>
		/// Void GetSocketOption_obj_internal(System.Net.Sockets.SafeSocketHandle, System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Object ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RGetSocketOption_obj_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32;
		public static RMethod RGetSocketOption_obj_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32
		{
			get
			{
				if(r_RGetSocketOption_obj_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32 == null)
				{
					r_RGetSocketOption_obj_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "GetSocketOption_obj_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Object).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RGetSocketOption_obj_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32.SetBelong(null);
				}
				return r_RGetSocketOption_obj_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32;
			}
		}

		/// <summary>
		/// Void GetSocketOption_obj_icall(IntPtr, System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Object ByRef, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RGetSocketOption_obj_icall_IntPtr_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32;
		public static RMethod RGetSocketOption_obj_icall_IntPtr_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32
		{
			get
			{
				if(r_RGetSocketOption_obj_icall_IntPtr_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32 == null)
				{
					r_RGetSocketOption_obj_icall_IntPtr_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "GetSocketOption_obj_icall", 0, typeof(System.IntPtr), typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Object).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RGetSocketOption_obj_icall_IntPtr_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32.SetBelong(null);
				}
				return r_RGetSocketOption_obj_icall_IntPtr_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32;
			}
		}

		/// <summary>
		/// Void SetSocketOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, Byte[])
		/// </summary>
		protected RMethod r_RSetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray;
		public virtual RMethod RSetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray
		{
			get
			{
				if(r_RSetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray == null)
				{
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray = new(this, "SetSocketOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Byte).MakeArrayType());
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray.SetBelong(this.instance);
				}
				return r_RSetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray;
			}
		}

		/// <summary>
		/// Void SetSocketOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Object)
		/// </summary>
		protected RMethod r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Object;
		public virtual RMethod RSetSocketOption_SocketOptionLevel_SocketOptionName_Object
		{
			get
			{
				if(r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Object == null)
				{
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Object = new(this, "SetSocketOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Object));
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Object.SetBelong(this.instance);
				}
				return r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Object;
			}
		}

		/// <summary>
		/// Void SetSocketOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, Boolean)
		/// </summary>
		protected RMethod r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Boolean;
		public virtual RMethod RSetSocketOption_SocketOptionLevel_SocketOptionName_Boolean
		{
			get
			{
				if(r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Boolean == null)
				{
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Boolean = new(this, "SetSocketOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Boolean));
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Boolean.SetBelong(this.instance);
				}
				return r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Boolean;
			}
		}

		/// <summary>
		/// Void SetSocketOption(System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, Int32)
		/// </summary>
		protected RMethod r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32;
		public virtual RMethod RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32
		{
			get
			{
				if(r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32 == null)
				{
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32 = new(this, "SetSocketOption", 0, typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Int32));
					r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32.SetBelong(this.instance);
				}
				return r_RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32;
			}
		}

		/// <summary>
		/// Void SetSocketOption_internal(System.Net.Sockets.SafeSocketHandle, System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Object, Byte[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RSetSocketOption_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32;
		public static RMethod RSetSocketOption_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32
		{
			get
			{
				if(r_RSetSocketOption_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32 == null)
				{
					r_RSetSocketOption_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "SetSocketOption_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Object), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RSetSocketOption_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32.SetBelong(null);
				}
				return r_RSetSocketOption_internal_SafeSocketHandle_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void SetSocketOption_icall(IntPtr, System.Net.Sockets.SocketOptionLevel, System.Net.Sockets.SocketOptionName, System.Object, Byte[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RSetSocketOption_icall_IntPtr_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32;
		public static RMethod RSetSocketOption_icall_IntPtr_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32
		{
			get
			{
				if(r_RSetSocketOption_icall_IntPtr_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32 == null)
				{
					r_RSetSocketOption_icall_IntPtr_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "SetSocketOption_icall", 0, typeof(System.IntPtr), typeof(System.Net.Sockets.SocketOptionLevel), typeof(System.Net.Sockets.SocketOptionName), typeof(System.Object), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RSetSocketOption_icall_IntPtr_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32.SetBelong(null);
				}
				return r_RSetSocketOption_icall_IntPtr_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 IOControl(Int32, Byte[], Byte[])
		/// </summary>
		protected RMethod r_RIOControl_Int32_ByteArray_ByteArray;
		public virtual RMethod RIOControl_Int32_ByteArray_ByteArray
		{
			get
			{
				if(r_RIOControl_Int32_ByteArray_ByteArray == null)
				{
					r_RIOControl_Int32_ByteArray_ByteArray = new(this, "IOControl", 0, typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_RIOControl_Int32_ByteArray_ByteArray.SetBelong(this.instance);
				}
				return r_RIOControl_Int32_ByteArray_ByteArray;
			}
		}

		/// <summary>
		/// Int32 IOControl_internal(System.Net.Sockets.SafeSocketHandle, Int32, Byte[], Byte[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_RIOControl_internal_SafeSocketHandle_Int32_ByteArray_ByteArray_Out_Int32;
		public static RMethod RIOControl_internal_SafeSocketHandle_Int32_ByteArray_ByteArray_Out_Int32
		{
			get
			{
				if(r_RIOControl_internal_SafeSocketHandle_Int32_ByteArray_ByteArray_Out_Int32 == null)
				{
					r_RIOControl_internal_SafeSocketHandle_Int32_ByteArray_ByteArray_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "IOControl_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_RIOControl_internal_SafeSocketHandle_Int32_ByteArray_ByteArray_Out_Int32.SetBelong(null);
				}
				return r_RIOControl_internal_SafeSocketHandle_Int32_ByteArray_ByteArray_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 IOControl_icall(IntPtr, Int32, Byte[], Byte[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_RIOControl_icall_IntPtr_Int32_ByteArray_ByteArray_Out_Int32;
		public static RMethod RIOControl_icall_IntPtr_Int32_ByteArray_ByteArray_Out_Int32
		{
			get
			{
				if(r_RIOControl_icall_IntPtr_Int32_ByteArray_ByteArray_Out_Int32 == null)
				{
					r_RIOControl_icall_IntPtr_Int32_ByteArray_ByteArray_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "IOControl_icall", 0, typeof(System.IntPtr), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_RIOControl_icall_IntPtr_Int32_ByteArray_ByteArray_Out_Int32.SetBelong(null);
				}
				return r_RIOControl_icall_IntPtr_Int32_ByteArray_ByteArray_Out_Int32;
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
		/// Void Close(Int32)
		/// </summary>
		protected RMethod r_RClose_Int32;
		public virtual RMethod RClose_Int32
		{
			get
			{
				if(r_RClose_Int32 == null)
				{
					r_RClose_Int32 = new(this, "Close", 0, typeof(System.Int32));
					r_RClose_Int32.SetBelong(this.instance);
				}
				return r_RClose_Int32;
			}
		}

		/// <summary>
		/// Void Close_icall(IntPtr, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RClose_icall_IntPtr_Out_Int32;
		public static RMethod RClose_icall_IntPtr_Out_Int32
		{
			get
			{
				if(r_RClose_icall_IntPtr_Out_Int32 == null)
				{
					r_RClose_icall_IntPtr_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Close_icall", 0, typeof(System.IntPtr), typeof(System.Int32).MakeByRefType());
					r_RClose_icall_IntPtr_Out_Int32.SetBelong(null);
				}
				return r_RClose_icall_IntPtr_Out_Int32;
			}
		}

		/// <summary>
		/// Void Shutdown(System.Net.Sockets.SocketShutdown)
		/// </summary>
		protected RMethod r_RShutdown_SocketShutdown;
		public virtual RMethod RShutdown_SocketShutdown
		{
			get
			{
				if(r_RShutdown_SocketShutdown == null)
				{
					r_RShutdown_SocketShutdown = new(this, "Shutdown", 0, typeof(System.Net.Sockets.SocketShutdown));
					r_RShutdown_SocketShutdown.SetBelong(this.instance);
				}
				return r_RShutdown_SocketShutdown;
			}
		}

		/// <summary>
		/// Void Shutdown_internal(System.Net.Sockets.SafeSocketHandle, System.Net.Sockets.SocketShutdown, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RShutdown_internal_SafeSocketHandle_SocketShutdown_Out_Int32;
		public static RMethod RShutdown_internal_SafeSocketHandle_SocketShutdown_Out_Int32
		{
			get
			{
				if(r_RShutdown_internal_SafeSocketHandle_SocketShutdown_Out_Int32 == null)
				{
					r_RShutdown_internal_SafeSocketHandle_SocketShutdown_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Shutdown_internal", 0,  ReleactionUtils.GetType("System.Net.Sockets.SafeSocketHandle"), typeof(System.Net.Sockets.SocketShutdown), typeof(System.Int32).MakeByRefType());
					r_RShutdown_internal_SafeSocketHandle_SocketShutdown_Out_Int32.SetBelong(null);
				}
				return r_RShutdown_internal_SafeSocketHandle_SocketShutdown_Out_Int32;
			}
		}

		/// <summary>
		/// Void Shutdown_icall(IntPtr, System.Net.Sockets.SocketShutdown, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RShutdown_icall_IntPtr_SocketShutdown_Out_Int32;
		public static RMethod RShutdown_icall_IntPtr_SocketShutdown_Out_Int32
		{
			get
			{
				if(r_RShutdown_icall_IntPtr_SocketShutdown_Out_Int32 == null)
				{
					r_RShutdown_icall_IntPtr_SocketShutdown_Out_Int32 = new(typeof(System.Net.Sockets.Socket), "Shutdown_icall", 0, typeof(System.IntPtr), typeof(System.Net.Sockets.SocketShutdown), typeof(System.Int32).MakeByRefType());
					r_RShutdown_icall_IntPtr_SocketShutdown_Out_Int32.SetBelong(null);
				}
				return r_RShutdown_icall_IntPtr_SocketShutdown_Out_Int32;
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
		/// Void Linger(IntPtr)
		/// </summary>
		protected RMethod r_RLinger_IntPtr;
		public virtual RMethod RLinger_IntPtr
		{
			get
			{
				if(r_RLinger_IntPtr == null)
				{
					r_RLinger_IntPtr = new(this, "Linger", 0, typeof(System.IntPtr));
					r_RLinger_IntPtr.SetBelong(this.instance);
				}
				return r_RLinger_IntPtr;
			}
		}

		/// <summary>
		/// Void ThrowIfDisposedAndClosed(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RThrowIfDisposedAndClosed_Socket;
		public virtual RMethod RThrowIfDisposedAndClosed_Socket
		{
			get
			{
				if(r_RThrowIfDisposedAndClosed_Socket == null)
				{
					r_RThrowIfDisposedAndClosed_Socket = new(this, "ThrowIfDisposedAndClosed", 0, typeof(System.Net.Sockets.Socket));
					r_RThrowIfDisposedAndClosed_Socket.SetBelong(this.instance);
				}
				return r_RThrowIfDisposedAndClosed_Socket;
			}
		}

		/// <summary>
		/// Void ThrowIfDisposedAndClosed()
		/// </summary>
		protected RMethod r_RThrowIfDisposedAndClosed;
		public virtual RMethod RThrowIfDisposedAndClosed
		{
			get
			{
				if(r_RThrowIfDisposedAndClosed == null)
				{
					r_RThrowIfDisposedAndClosed = new(this, "ThrowIfDisposedAndClosed", 0);
					r_RThrowIfDisposedAndClosed.SetBelong(this.instance);
				}
				return r_RThrowIfDisposedAndClosed;
			}
		}

		/// <summary>
		/// Void ThrowIfBufferNull(Byte[])
		/// </summary>
		protected RMethod r_RThrowIfBufferNull_ByteArray;
		public virtual RMethod RThrowIfBufferNull_ByteArray
		{
			get
			{
				if(r_RThrowIfBufferNull_ByteArray == null)
				{
					r_RThrowIfBufferNull_ByteArray = new(this, "ThrowIfBufferNull", 0, typeof(System.Byte).MakeArrayType());
					r_RThrowIfBufferNull_ByteArray.SetBelong(this.instance);
				}
				return r_RThrowIfBufferNull_ByteArray;
			}
		}

		/// <summary>
		/// Void ThrowIfBufferOutOfRange(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RThrowIfBufferOutOfRange_ByteArray_Int32_Int32;
		public virtual RMethod RThrowIfBufferOutOfRange_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RThrowIfBufferOutOfRange_ByteArray_Int32_Int32 == null)
				{
					r_RThrowIfBufferOutOfRange_ByteArray_Int32_Int32 = new(this, "ThrowIfBufferOutOfRange", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RThrowIfBufferOutOfRange_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RThrowIfBufferOutOfRange_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ThrowIfUdp()
		/// </summary>
		protected RMethod r_RThrowIfUdp;
		public virtual RMethod RThrowIfUdp
		{
			get
			{
				if(r_RThrowIfUdp == null)
				{
					r_RThrowIfUdp = new(this, "ThrowIfUdp", 0);
					r_RThrowIfUdp.SetBelong(this.instance);
				}
				return r_RThrowIfUdp;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketAsyncResult ValidateEndIAsyncResult(System.IAsyncResult, System.String, System.String)
		/// </summary>
		protected RMethod r_RValidateEndIAsyncResult_IAsyncResult_String_String;
		public virtual RMethod RValidateEndIAsyncResult_IAsyncResult_String_String
		{
			get
			{
				if(r_RValidateEndIAsyncResult_IAsyncResult_String_String == null)
				{
					r_RValidateEndIAsyncResult_IAsyncResult_String_String = new(this, "ValidateEndIAsyncResult", 0, typeof(System.IAsyncResult), typeof(System.String), typeof(System.String));
					r_RValidateEndIAsyncResult_IAsyncResult_String_String.SetBelong(this.instance);
				}
				return r_RValidateEndIAsyncResult_IAsyncResult_String_String;
			}
		}

		/// <summary>
		/// Void QueueIOSelectorJob(System.Threading.SemaphoreSlim, IntPtr, System.IOSelectorJob)
		/// </summary>
		protected RMethod r_RQueueIOSelectorJob_SemaphoreSlim_IntPtr_IOSelectorJob;
		public virtual RMethod RQueueIOSelectorJob_SemaphoreSlim_IntPtr_IOSelectorJob
		{
			get
			{
				if(r_RQueueIOSelectorJob_SemaphoreSlim_IntPtr_IOSelectorJob == null)
				{
					r_RQueueIOSelectorJob_SemaphoreSlim_IntPtr_IOSelectorJob = new(this, "QueueIOSelectorJob", 0, typeof(System.Threading.SemaphoreSlim), typeof(System.IntPtr),  ReleactionUtils.GetType("System.IOSelectorJob"));
					r_RQueueIOSelectorJob_SemaphoreSlim_IntPtr_IOSelectorJob.SetBelong(this.instance);
				}
				return r_RQueueIOSelectorJob_SemaphoreSlim_IntPtr_IOSelectorJob;
			}
		}

		/// <summary>
		/// Void InitSocketAsyncEventArgs(System.Net.Sockets.SocketAsyncEventArgs, System.AsyncCallback, System.Object, System.Net.Sockets.SocketOperation)
		/// </summary>
		protected RMethod r_RInitSocketAsyncEventArgs_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation;
		public virtual RMethod RInitSocketAsyncEventArgs_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation
		{
			get
			{
				if(r_RInitSocketAsyncEventArgs_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation == null)
				{
					r_RInitSocketAsyncEventArgs_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation = new(this, "InitSocketAsyncEventArgs", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs), typeof(System.AsyncCallback), typeof(System.Object),  ReleactionUtils.GetType("System.Net.Sockets.SocketOperation"));
					r_RInitSocketAsyncEventArgs_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation.SetBelong(this.instance);
				}
				return r_RInitSocketAsyncEventArgs_SocketAsyncEventArgs_AsyncCallback_Object_SocketOperation;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketAsyncOperation SocketOperationToSocketAsyncOperation(System.Net.Sockets.SocketOperation)
		/// </summary>
		protected RMethod r_RSocketOperationToSocketAsyncOperation_SocketOperation;
		public virtual RMethod RSocketOperationToSocketAsyncOperation_SocketOperation
		{
			get
			{
				if(r_RSocketOperationToSocketAsyncOperation_SocketOperation == null)
				{
					r_RSocketOperationToSocketAsyncOperation_SocketOperation = new(this, "SocketOperationToSocketAsyncOperation", 0,  ReleactionUtils.GetType("System.Net.Sockets.SocketOperation"));
					r_RSocketOperationToSocketAsyncOperation_SocketOperation.SetBelong(this.instance);
				}
				return r_RSocketOperationToSocketAsyncOperation_SocketOperation;
			}
		}

		/// <summary>
		/// System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint)
		/// </summary>
		protected RMethod r_RRemapIPEndPoint_IPEndPoint;
		public virtual RMethod RRemapIPEndPoint_IPEndPoint
		{
			get
			{
				if(r_RRemapIPEndPoint_IPEndPoint == null)
				{
					r_RRemapIPEndPoint_IPEndPoint = new(this, "RemapIPEndPoint", 0, typeof(System.Net.IPEndPoint));
					r_RRemapIPEndPoint_IPEndPoint.SetBelong(this.instance);
				}
				return r_RRemapIPEndPoint_IPEndPoint;
			}
		}

		/// <summary>
		/// Void cancel_blocking_socket_operation(System.Threading.Thread)
		/// </summary>
		protected static RMethod r_Rcancel_blocking_socket_operation_Thread;
		public static RMethod Rcancel_blocking_socket_operation_Thread
		{
			get
			{
				if(r_Rcancel_blocking_socket_operation_Thread == null)
				{
					r_Rcancel_blocking_socket_operation_Thread = new(typeof(System.Net.Sockets.Socket), "cancel_blocking_socket_operation", 0, typeof(System.Threading.Thread));
					r_Rcancel_blocking_socket_operation_Thread.SetBelong(null);
				}
				return r_Rcancel_blocking_socket_operation_Thread;
			}
		}

		/// <summary>
		/// Boolean SupportsPortReuse(System.Net.Sockets.ProtocolType)
		/// </summary>
		protected static RMethod r_RSupportsPortReuse_ProtocolType;
		public static RMethod RSupportsPortReuse_ProtocolType
		{
			get
			{
				if(r_RSupportsPortReuse_ProtocolType == null)
				{
					r_RSupportsPortReuse_ProtocolType = new(typeof(System.Net.Sockets.Socket), "SupportsPortReuse", 0, typeof(System.Net.Sockets.ProtocolType));
					r_RSupportsPortReuse_ProtocolType.SetBelong(null);
				}
				return r_RSupportsPortReuse_ProtocolType;
			}
		}

		/// <summary>
		/// Boolean IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent)
		/// </summary>
		protected static RMethod r_RIsProtocolSupported_internal_NetworkInterfaceComponent;
		public static RMethod RIsProtocolSupported_internal_NetworkInterfaceComponent
		{
			get
			{
				if(r_RIsProtocolSupported_internal_NetworkInterfaceComponent == null)
				{
					r_RIsProtocolSupported_internal_NetworkInterfaceComponent = new(typeof(System.Net.Sockets.Socket), "IsProtocolSupported_internal", 0, typeof(System.Net.NetworkInformation.NetworkInterfaceComponent));
					r_RIsProtocolSupported_internal_NetworkInterfaceComponent.SetBelong(null);
				}
				return r_RIsProtocolSupported_internal_NetworkInterfaceComponent;
			}
		}

		/// <summary>
		/// Boolean IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent)
		/// </summary>
		protected static RMethod r_RIsProtocolSupported_NetworkInterfaceComponent;
		public static RMethod RIsProtocolSupported_NetworkInterfaceComponent
		{
			get
			{
				if(r_RIsProtocolSupported_NetworkInterfaceComponent == null)
				{
					r_RIsProtocolSupported_NetworkInterfaceComponent = new(typeof(System.Net.Sockets.Socket), "IsProtocolSupported", 0, typeof(System.Net.NetworkInformation.NetworkInterfaceComponent));
					r_RIsProtocolSupported_NetworkInterfaceComponent.SetBelong(null);
				}
				return r_RIsProtocolSupported_NetworkInterfaceComponent;
			}
		}

		/// <summary>
		/// Void ReplaceHandleIfNecessaryAfterFailedConnect()
		/// </summary>
		protected RMethod r_RReplaceHandleIfNecessaryAfterFailedConnect;
		public virtual RMethod RReplaceHandleIfNecessaryAfterFailedConnect
		{
			get
			{
				if(r_RReplaceHandleIfNecessaryAfterFailedConnect == null)
				{
					r_RReplaceHandleIfNecessaryAfterFailedConnect = new(this, "ReplaceHandleIfNecessaryAfterFailedConnect", 0);
					r_RReplaceHandleIfNecessaryAfterFailedConnect.SetBelong(this.instance);
				}
				return r_RReplaceHandleIfNecessaryAfterFailedConnect;
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


        public RSocket() : base("System.Net.Sockets.Socket")
        {
        }

        public RSocket(System.Object instance) : base("System.Net.Sockets.Socket")
		{
            SetInstance(instance);
		}

        public RSocket(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSocket(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptAsync(System.Net.Sockets.Socket  @acceptSocket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@acceptSocket};
            var ___result = RAcceptAsync_Socket.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Net.Sockets.Socket>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Net.Sockets.Socket> AcceptAsyncApm(System.Net.Sockets.Socket  @acceptSocket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@acceptSocket};
            var ___result = RAcceptAsyncApm_Socket.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Net.Sockets.Socket>)___result;
        }


        public virtual System.Threading.Tasks.Task ConnectAsync(System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@remoteEP};
            var ___result = RConnectAsync_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress  @address, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @port};
            var ___result = RConnectAsync_IPAddress_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ConnectAsync(System.Net.IPAddress[]  @addresses, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@addresses, @port};
            var ___result = RConnectAsync_IPAddressArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ConnectAsync(System.String  @host, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host, @port};
            var ___result = RConnectAsync_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReceiveAsync(System.ArraySegment<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, System.Boolean  @fromNetworkStream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @fromNetworkStream};
            var ___result = RReceiveAsync_ArraySegment_d_Byte_p__SocketFlags_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Memory<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, System.Boolean  @fromNetworkStream, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @fromNetworkStream, @cancellationToken};
            var ___result = RReceiveAsync_Memory_d_Byte_p__SocketFlags_Boolean_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Memory<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags};
            var ___result = RReceiveAsyncApm_Memory_d_Byte_p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReceiveAsync(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags};
            var ___result = RReceiveAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReceiveAsyncApm(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags};
            var ___result = RReceiveAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveFromResult> ReceiveFromAsync(System.ArraySegment<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, System.Net.EndPoint  @remoteEndPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @remoteEndPoint};
            var ___result = RReceiveFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveFromResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveMessageFromResult> ReceiveMessageFromAsync(System.ArraySegment<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, System.Net.EndPoint  @remoteEndPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @remoteEndPoint};
            var ___result = RReceiveMessageFromAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Net.Sockets.SocketReceiveMessageFromResult>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> SendAsync(System.ArraySegment<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags};
            var ___result = RSendAsync_ArraySegment_d_Byte_p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> SendAsync(System.ReadOnlyMemory<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @cancellationToken};
            var ___result = RSendAsync_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.ReadOnlyMemory<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @cancellationToken};
            var ___result = RSendAsyncForNetworkStream_ReadOnlyMemory_d_Byte_p__SocketFlags_CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.ReadOnlyMemory<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags};
            var ___result = RSendAsyncApm_ReadOnlyMemory_d_Byte_p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> SendAsync(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags};
            var ___result = RSendAsync_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> SendAsyncApm(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags};
            var ___result = RSendAsyncApm_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> SendToAsync(System.ArraySegment<System.Byte>  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @remoteEP};
            var ___result = RSendToAsync_ArraySegment_d_Byte_p__SocketFlags_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public static void ValidateBuffer(System.ArraySegment<System.Byte>  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RValidateBuffer_ArraySegment_d_Byte_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void ValidateBuffersList(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers};
            var ___result = RValidateBuffersList_IList_d_ArraySegment_d_Byte_p__p_.Invoke(___genericsType, ___parameters);

            
        }






        public static System.Exception GetException(System.Net.Sockets.SocketError  @error, System.Boolean  @wrapExceptionsInIOExceptions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@error, @wrapExceptionsInIOExceptions};
            var ___result = RGetException_SocketError_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Object RentSocketAsyncEventArgs(System.Boolean  @isReceive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isReceive};
            var ___result = RRentSocketAsyncEventArgs_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual void DisposeCachedTaskSocketAsyncEventArgs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeCachedTaskSocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CanTryAddressFamily(System.Net.Sockets.AddressFamily  @family)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@family};
            var ___result = RCanTryAddressFamily_AddressFamily.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Connect(System.Net.IPAddress[]  @addresses, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@addresses, @port};
            var ___result = RConnect_IPAddressArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Send(System.Byte[]  @buffer, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @size, @socketFlags};
            var ___result = RSend_ByteArray_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Send(System.Byte[]  @buffer, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags};
            var ___result = RSend_ByteArray_SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Send(System.Byte[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RSend_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers};
            var ___result = RSend_IList_d_ArraySegment_d_Byte_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags};
            var ___result = RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SendFile(System.String  @fileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName};
            var ___result = RSendFile_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Send(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags};
            var ___result = RSend_ByteArray_Int32_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 SendTo(System.Byte[]  @buffer, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @size, @socketFlags, @remoteEP};
            var ___result = RSendTo_ByteArray_Int32_SocketFlags_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 SendTo(System.Byte[]  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @remoteEP};
            var ___result = RSendTo_ByteArray_SocketFlags_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 SendTo(System.Byte[]  @buffer, System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @remoteEP};
            var ___result = RSendTo_ByteArray_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Receive(System.Byte[]  @buffer, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @size, @socketFlags};
            var ___result = RReceive_ByteArray_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Receive(System.Byte[]  @buffer, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags};
            var ___result = RReceive_ByteArray_SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Receive(System.Byte[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RReceive_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Receive(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags};
            var ___result = RReceive_ByteArray_Int32_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers};
            var ___result = RReceive_IList_d_ArraySegment_d_Byte_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags};
            var ___result = RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReceiveFrom(System.Byte[]  @buffer, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @size, @socketFlags, @remoteEP};
            var ___result = RReceiveFrom_ByteArray_Int32_SocketFlags_Ref_EndPoint.Invoke(___genericsType, ___parameters);
			remoteEP = (System.Net.EndPoint)___parameters[3];

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReceiveFrom(System.Byte[]  @buffer, System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @socketFlags, @remoteEP};
            var ___result = RReceiveFrom_ByteArray_SocketFlags_Ref_EndPoint.Invoke(___genericsType, ___parameters);
			remoteEP = (System.Net.EndPoint)___parameters[2];

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReceiveFrom(System.Byte[]  @buffer, ref System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @remoteEP};
            var ___result = RReceiveFrom_ByteArray_Ref_EndPoint.Invoke(___genericsType, ___parameters);
			remoteEP = (System.Net.EndPoint)___parameters[1];

            return (System.Int32)___result;
        }


        public virtual System.Int32 IOControl(System.Net.Sockets.IOControlCode  @ioControlCode, System.Byte[]  @optionInValue, System.Byte[]  @optionOutValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ioControlCode, @optionInValue, @optionOutValue};
            var ___result = RIOControl_IOControlCode_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetIPProtectionLevel(System.Net.Sockets.IPProtectionLevel  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RSetIPProtectionLevel_IPProtectionLevel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginSendFile(System.String  @fileName, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName, @callback, @state};
            var ___result = RBeginSendFile_String_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginConnect(System.Net.IPAddress  @address, System.Int32  @port, System.AsyncCallback  @requestCallback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @port, @requestCallback, @state};
            var ___result = RBeginConnect_IPAddress_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginSend(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @callback, @state};
            var ___result = RBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginSend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags, @callback, @state};
            var ___result = RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndSend(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndSend_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IAsyncResult BeginReceive(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @callback, @state};
            var ___result = RBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginReceive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags, @callback, @state};
            var ___result = RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndReceive(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndReceive_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.IAsyncResult BeginAccept(System.Int32  @receiveSize, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@receiveSize, @callback, @state};
            var ___result = RBeginAccept_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Net.Sockets.Socket EndAccept(out System.Byte[]  @buffer, System.IAsyncResult  @asyncResult)
        {
			buffer = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @asyncResult};
            var ___result = REndAccept_Out_ByteArray_IAsyncResult.Invoke(___genericsType, ___parameters);
			buffer = (System.Byte[])___parameters[0];

            return (System.Net.Sockets.Socket)___result;
        }


        public static void InitializeSockets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeSockets.Invoke(___genericsType, ___parameters);

            
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


        public static System.Boolean ConnectAsync(System.Net.Sockets.SocketType  @socketType, System.Net.Sockets.ProtocolType  @protocolType, System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socketType, @protocolType, @e};
            var ___result = RConnectAsync_SocketType_ProtocolType_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void InternalShutdown(System.Net.Sockets.SocketShutdown  @how)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@how};
            var ___result = RInternalShutdown_SocketShutdown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult UnsafeBeginConnect(System.Net.EndPoint  @remoteEP, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@remoteEP, @callback, @state};
            var ___result = RUnsafeBeginConnect_EndPoint_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult UnsafeBeginSend(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @callback, @state};
            var ___result = RUnsafeBeginSend_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult UnsafeBeginReceive(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @callback, @state};
            var ___result = RUnsafeBeginReceive_ByteArray_Int32_Int32_SocketFlags_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }




        public virtual System.Int32 EndMultipleSend(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndMultipleSend_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual void SetSocketOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName, System.Int32  @optionValue, System.Boolean  @silent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName, @optionValue, @silent};
            var ___result = RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SocketDefaults()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSocketDefaults.Invoke(___genericsType, ___parameters);

            
        }


        public static System.IntPtr Socket_icall(System.Net.Sockets.AddressFamily  @family, System.Net.Sockets.SocketType  @type, System.Net.Sockets.ProtocolType  @proto, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@family, @type, @proto, @error};
            var ___result = RSocket_icall_AddressFamily_SocketType_ProtocolType_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[3];

            return (System.IntPtr)___result;
        }



        public static System.Int32 Available_icall(System.IntPtr  @socket, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @error};
            var ___result = RAvailable_icall_IntPtr_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[1];

            return (System.Int32)___result;
        }



        public static System.Net.SocketAddress LocalEndPoint_icall(System.IntPtr  @socket, System.Int32  @family, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @family, @error};
            var ___result = RLocalEndPoint_icall_IntPtr_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[2];

            return (System.Net.SocketAddress)___result;
        }



        public static void Blocking_icall(System.IntPtr  @socket, System.Boolean  @block, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @block, @error};
            var ___result = RBlocking_icall_IntPtr_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[2];

            
        }



        public static System.Net.SocketAddress RemoteEndPoint_icall(System.IntPtr  @socket, System.Int32  @family, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @family, @error};
            var ___result = RRemoteEndPoint_icall_IntPtr_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[2];

            return (System.Net.SocketAddress)___result;
        }


        public static void Select(System.Collections.IList  @checkRead, System.Collections.IList  @checkWrite, System.Collections.IList  @checkError, System.Int32  @microSeconds)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@checkRead, @checkWrite, @checkError, @microSeconds};
            var ___result = RSelect_IList_IList_IList_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void AddSockets(System.Collections.Generic.List<System.Net.Sockets.Socket>  @sockets, System.Collections.IList  @list, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sockets, @list, @name};
            var ___result = RAddSockets_List_d_Socket_p__IList_String.Invoke(___genericsType, ___parameters);

            
        }


        public static void Select_icall(ref System.Net.Sockets.Socket[]  @sockets, System.Int32  @microSeconds, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sockets, @microSeconds, @error};
            var ___result = RSelect_icall_Ref_SocketArray_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			sockets = (System.Net.Sockets.Socket[])___parameters[0];
			error = (System.Int32)___parameters[2];

            
        }


        public virtual System.Boolean Poll(System.Int32  @microSeconds, System.Net.Sockets.SelectMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@microSeconds, @mode};
            var ___result = RPoll_Int32_SelectMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public static System.Boolean Poll_icall(System.IntPtr  @socket, System.Net.Sockets.SelectMode  @mode, System.Int32  @timeout, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @mode, @timeout, @error};
            var ___result = RPoll_icall_IntPtr_SelectMode_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[3];

            return (System.Boolean)___result;
        }


        public virtual System.Net.Sockets.Socket Accept()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAccept.Invoke(___genericsType, ___parameters);

            return (System.Net.Sockets.Socket)___result;
        }


        public virtual void Accept(System.Net.Sockets.Socket  @acceptSocket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@acceptSocket};
            var ___result = RAccept_Socket.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AcceptAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RAcceptAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IAsyncResult BeginAccept(System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@callback, @state};
            var ___result = RBeginAccept_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginAccept(System.Net.Sockets.Socket  @acceptSocket, System.Int32  @receiveSize, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@acceptSocket, @receiveSize, @callback, @state};
            var ___result = RBeginAccept_Socket_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.Net.Sockets.Socket EndAccept(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndAccept_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Net.Sockets.Socket)___result;
        }


        public virtual System.Net.Sockets.Socket EndAccept(out System.Byte[]  @buffer, out System.Int32  @bytesTransferred, System.IAsyncResult  @asyncResult)
        {
			buffer = default;
			bytesTransferred = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @bytesTransferred, @asyncResult};
            var ___result = REndAccept_Out_ByteArray_Out_Int32_IAsyncResult.Invoke(___genericsType, ___parameters);
			buffer = (System.Byte[])___parameters[0];
			bytesTransferred = (System.Int32)___parameters[1];

            return (System.Net.Sockets.Socket)___result;
        }



        public static System.IntPtr Accept_icall(System.IntPtr  @sock, out System.Int32  @error, System.Boolean  @blocking)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sock, @error, @blocking};
            var ___result = RAccept_icall_IntPtr_Out_Int32_Boolean.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[1];

            return (System.IntPtr)___result;
        }


        public virtual void Bind(System.Net.EndPoint  @localEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localEP};
            var ___result = RBind_EndPoint.Invoke(___genericsType, ___parameters);

            
        }



        public static void Bind_icall(System.IntPtr  @sock, System.Net.SocketAddress  @sa, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sock, @sa, @error};
            var ___result = RBind_icall_IntPtr_SocketAddress_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[2];

            
        }


        public virtual void Listen(System.Int32  @backlog)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@backlog};
            var ___result = RListen_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public static void Listen_icall(System.IntPtr  @sock, System.Int32  @backlog, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sock, @backlog, @error};
            var ___result = RListen_icall_IntPtr_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[2];

            
        }


        public virtual void Connect(System.Net.IPAddress  @address, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address, @port};
            var ___result = RConnect_IPAddress_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Connect(System.String  @host, System.Int32  @port)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host, @port};
            var ___result = RConnect_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Connect(System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@remoteEP};
            var ___result = RConnect_EndPoint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ConnectAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RConnectAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static void CancelConnectAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RCancelConnectAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginConnect(System.String  @host, System.Int32  @port, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host, @port, @callback, @state};
            var ___result = RBeginConnect_String_Int32_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginConnect(System.Net.EndPoint  @remoteEP, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@remoteEP, @callback, @state};
            var ___result = RBeginConnect_EndPoint_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

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



        public static void Connect_icall(System.IntPtr  @sock, System.Net.SocketAddress  @sa, out System.Int32  @error, System.Boolean  @blocking)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sock, @sa, @error, @blocking};
            var ___result = RConnect_icall_IntPtr_SocketAddress_Out_Int32_Boolean.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[2];

            
        }


        public virtual System.Boolean GetCheckedIPs(System.Net.Sockets.SocketAsyncEventArgs  @e, out System.Net.IPAddress[]  @addresses)
        {
			addresses = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @addresses};
            var ___result = RGetCheckedIPs_SocketAsyncEventArgs_Out_IPAddressArray.Invoke(___genericsType, ___parameters);
			addresses = (System.Net.IPAddress[])___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual void Disconnect(System.Boolean  @reuseSocket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reuseSocket};
            var ___result = RDisconnect_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean DisconnectAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RDisconnectAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IAsyncResult BeginDisconnect(System.Boolean  @reuseSocket, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reuseSocket, @callback, @state};
            var ___result = RBeginDisconnect_Boolean_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual void EndDisconnect(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndDisconnect_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }



        public static void Disconnect_icall(System.IntPtr  @sock, System.Boolean  @reuse, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sock, @reuse, @error};
            var ___result = RDisconnect_icall_IntPtr_Boolean_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[2];

            
        }


        public virtual System.Int32 Receive(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @errorCode};
            var ___result = RReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[4];

            return (System.Int32)___result;
        }


        public virtual System.Int32 Receive(System.Memory<System.Byte>  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @errorCode};
            var ___result = RReceive_Memory_d_Byte_p__Int32_Int32_SocketFlags_Out_SocketError.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[4];

            return (System.Int32)___result;
        }


        public virtual System.Int32 Receive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags, @errorCode};
            var ___result = RReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[2];

            return (System.Int32)___result;
        }






        public virtual System.Boolean ReceiveAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RReceiveAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IAsyncResult BeginReceive(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode, System.AsyncCallback  @callback, System.Object  @state)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @errorCode, @callback, @state};
            var ___result = RBeginReceive_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[4];

            return (System.IAsyncResult)___result;
        }


        public virtual System.IAsyncResult BeginReceive(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode, System.AsyncCallback  @callback, System.Object  @state)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags, @errorCode, @callback, @state};
            var ___result = RBeginReceive_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[2];

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndReceive(System.IAsyncResult  @asyncResult, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @errorCode};
            var ___result = REndReceive_IAsyncResult_Out_SocketError.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[1];

            return (System.Int32)___result;
        }






        public virtual System.Int32 ReceiveFrom(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP};
            var ___result = RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint.Invoke(___genericsType, ___parameters);
			remoteEP = (System.Net.EndPoint)___parameters[4];

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReceiveFrom(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @remoteEP, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP, @errorCode};
            var ___result = RReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError.Invoke(___genericsType, ___parameters);
			remoteEP = (System.Net.EndPoint)___parameters[4];
			errorCode = (System.Net.Sockets.SocketError)___parameters[5];

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReceiveFrom(System.Memory<System.Byte>  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @remoteEP, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP, @errorCode};
            var ___result = RReceiveFrom_Memory_d_Byte_p__Int32_Int32_SocketFlags_Ref_EndPoint_Out_SocketError.Invoke(___genericsType, ___parameters);
			remoteEP = (System.Net.EndPoint)___parameters[4];
			errorCode = (System.Net.Sockets.SocketError)___parameters[5];

            return (System.Int32)___result;
        }


        public virtual System.Boolean ReceiveFromAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RReceiveFromAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IAsyncResult BeginReceiveFrom(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @remoteEP, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP, @callback, @state};
            var ___result = RBeginReceiveFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object.Invoke(___genericsType, ___parameters);
			remoteEP = (System.Net.EndPoint)___parameters[4];

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndReceiveFrom(System.IAsyncResult  @asyncResult, ref System.Net.EndPoint  @endPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @endPoint};
            var ___result = REndReceiveFrom_IAsyncResult_Ref_EndPoint.Invoke(___genericsType, ___parameters);
			endPoint = (System.Net.EndPoint)___parameters[1];

            return (System.Int32)___result;
        }





        public virtual System.Int32 ReceiveMessageFrom(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, ref System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @remoteEP, out System.Net.Sockets.IPPacketInformation  @ipPacketInformation)
        {
			ipPacketInformation = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP, @ipPacketInformation};
            var ___result = RReceiveMessageFrom_ByteArray_Int32_Int32_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation.Invoke(___genericsType, ___parameters);
			socketFlags = (System.Net.Sockets.SocketFlags)___parameters[3];
			remoteEP = (System.Net.EndPoint)___parameters[4];
			ipPacketInformation = (System.Net.Sockets.IPPacketInformation)___parameters[5];

            return (System.Int32)___result;
        }


        public virtual System.Boolean ReceiveMessageFromAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RReceiveMessageFromAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IAsyncResult BeginReceiveMessageFrom(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @remoteEP, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP, @callback, @state};
            var ___result = RBeginReceiveMessageFrom_ByteArray_Int32_Int32_SocketFlags_Ref_EndPoint_AsyncCallback_Object.Invoke(___genericsType, ___parameters);
			remoteEP = (System.Net.EndPoint)___parameters[4];

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndReceiveMessageFrom(System.IAsyncResult  @asyncResult, ref System.Net.Sockets.SocketFlags  @socketFlags, ref System.Net.EndPoint  @endPoint, out System.Net.Sockets.IPPacketInformation  @ipPacketInformation)
        {
			ipPacketInformation = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @socketFlags, @endPoint, @ipPacketInformation};
            var ___result = REndReceiveMessageFrom_IAsyncResult_Ref_SocketFlags_Ref_EndPoint_Out_IPPacketInformation.Invoke(___genericsType, ___parameters);
			socketFlags = (System.Net.Sockets.SocketFlags)___parameters[1];
			endPoint = (System.Net.EndPoint)___parameters[2];
			ipPacketInformation = (System.Net.Sockets.IPPacketInformation)___parameters[3];

            return (System.Int32)___result;
        }


        public virtual System.Int32 Send(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @errorCode};
            var ___result = RSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[4];

            return (System.Int32)___result;
        }


        public virtual System.Int32 Send(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags, @errorCode};
            var ___result = RSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[2];

            return (System.Int32)___result;
        }




        public virtual System.Boolean SendAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IAsyncResult BeginSend(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode, System.AsyncCallback  @callback, System.Object  @state)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @errorCode, @callback, @state};
            var ___result = RBeginSend_ByteArray_Int32_Int32_SocketFlags_Out_SocketError_AsyncCallback_Object.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[4];

            return (System.IAsyncResult)___result;
        }



        public virtual System.IAsyncResult BeginSend(System.Collections.Generic.IList<System.ArraySegment<System.Byte>>  @buffers, System.Net.Sockets.SocketFlags  @socketFlags, out System.Net.Sockets.SocketError  @errorCode, System.AsyncCallback  @callback, System.Object  @state)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffers, @socketFlags, @errorCode, @callback, @state};
            var ___result = RBeginSend_IList_d_ArraySegment_d_Byte_p__p__SocketFlags_Out_SocketError_AsyncCallback_Object.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[2];

            return (System.IAsyncResult)___result;
        }


        public virtual System.Int32 EndSend(System.IAsyncResult  @asyncResult, out System.Net.Sockets.SocketError  @errorCode)
        {
			errorCode = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult, @errorCode};
            var ___result = REndSend_IAsyncResult_Out_SocketError.Invoke(___genericsType, ___parameters);
			errorCode = (System.Net.Sockets.SocketError)___parameters[1];

            return (System.Int32)___result;
        }






        public virtual System.Int32 SendTo(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP};
            var ___result = RSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 SendTo(System.Memory<System.Byte>  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, System.Net.EndPoint  @remoteEP)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP};
            var ___result = RSendTo_Memory_d_Byte_p__Int32_Int32_SocketFlags_EndPoint.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean SendToAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendToAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.IAsyncResult BeginSendTo(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size, System.Net.Sockets.SocketFlags  @socketFlags, System.Net.EndPoint  @remoteEP, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size, @socketFlags, @remoteEP, @callback, @state};
            var ___result = RBeginSendTo_ByteArray_Int32_Int32_SocketFlags_EndPoint_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }



        public virtual System.Int32 EndSendTo(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndSendTo_IAsyncResult.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual void SendFile(System.String  @fileName, System.Byte[]  @preBuffer, System.Byte[]  @postBuffer, System.Net.Sockets.TransmitFileOptions  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName, @preBuffer, @postBuffer, @flags};
            var ___result = RSendFile_String_ByteArray_ByteArray_TransmitFileOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IAsyncResult BeginSendFile(System.String  @fileName, System.Byte[]  @preBuffer, System.Byte[]  @postBuffer, System.Net.Sockets.TransmitFileOptions  @flags, System.AsyncCallback  @callback, System.Object  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileName, @preBuffer, @postBuffer, @flags, @callback, @state};
            var ___result = RBeginSendFile_String_ByteArray_ByteArray_TransmitFileOptions_AsyncCallback_Object.Invoke(___genericsType, ___parameters);

            return (System.IAsyncResult)___result;
        }


        public virtual void EndSendFile(System.IAsyncResult  @asyncResult)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@asyncResult};
            var ___result = REndSendFile_IAsyncResult.Invoke(___genericsType, ___parameters);

            
        }



        public static System.Boolean SendFile_icall(System.IntPtr  @sock, System.String  @filename, System.Byte[]  @pre_buffer, System.Byte[]  @post_buffer, System.Net.Sockets.TransmitFileOptions  @flags, out System.Int32  @error, System.Boolean  @blocking)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sock, @filename, @pre_buffer, @post_buffer, @flags, @error, @blocking};
            var ___result = RSendFile_icall_IntPtr_String_ByteArray_ByteArray_TransmitFileOptions_Out_Int32_Boolean.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[5];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SendPacketsAsync(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendPacketsAsync_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Net.Sockets.SocketInformation DuplicateAndClose(System.Int32  @targetProcessId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetProcessId};
            var ___result = RDuplicateAndClose_Int32.Invoke(___genericsType, ___parameters);

            return (System.Net.Sockets.SocketInformation)___result;
        }


        public virtual void GetSocketOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName, System.Byte[]  @optionValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName, @optionValue};
            var ___result = RGetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Byte[] GetSocketOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName, System.Int32  @optionLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName, @optionLength};
            var ___result = RGetSocketOption_SocketOptionLevel_SocketOptionName_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Object GetSocketOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName};
            var ___result = RGetSocketOption_SocketOptionLevel_SocketOptionName.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public static void GetSocketOption_arr_icall(System.IntPtr  @socket, System.Net.Sockets.SocketOptionLevel  @level, System.Net.Sockets.SocketOptionName  @name, ref System.Byte[]  @byte_val, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @level, @name, @byte_val, @error};
            var ___result = RGetSocketOption_arr_icall_IntPtr_SocketOptionLevel_SocketOptionName_Ref_ByteArray_Out_Int32.Invoke(___genericsType, ___parameters);
			byte_val = (System.Byte[])___parameters[3];
			error = (System.Int32)___parameters[4];

            
        }



        public static void GetSocketOption_obj_icall(System.IntPtr  @socket, System.Net.Sockets.SocketOptionLevel  @level, System.Net.Sockets.SocketOptionName  @name, out System.Object  @obj_val, out System.Int32  @error)
        {
			obj_val = default;
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @level, @name, @obj_val, @error};
            var ___result = RGetSocketOption_obj_icall_IntPtr_SocketOptionLevel_SocketOptionName_Out_Object_Out_Int32.Invoke(___genericsType, ___parameters);
			obj_val = (System.Object)___parameters[3];
			error = (System.Int32)___parameters[4];

            
        }


        public virtual void SetSocketOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName, System.Byte[]  @optionValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName, @optionValue};
            var ___result = RSetSocketOption_SocketOptionLevel_SocketOptionName_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSocketOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName, System.Object  @optionValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName, @optionValue};
            var ___result = RSetSocketOption_SocketOptionLevel_SocketOptionName_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSocketOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName, System.Boolean  @optionValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName, @optionValue};
            var ___result = RSetSocketOption_SocketOptionLevel_SocketOptionName_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSocketOption(System.Net.Sockets.SocketOptionLevel  @optionLevel, System.Net.Sockets.SocketOptionName  @optionName, System.Int32  @optionValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@optionLevel, @optionName, @optionValue};
            var ___result = RSetSocketOption_SocketOptionLevel_SocketOptionName_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public static void SetSocketOption_icall(System.IntPtr  @socket, System.Net.Sockets.SocketOptionLevel  @level, System.Net.Sockets.SocketOptionName  @name, System.Object  @obj_val, System.Byte[]  @byte_val, System.Int32  @int_val, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @level, @name, @obj_val, @byte_val, @int_val, @error};
            var ___result = RSetSocketOption_icall_IntPtr_SocketOptionLevel_SocketOptionName_Object_ByteArray_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[6];

            
        }


        public virtual System.Int32 IOControl(System.Int32  @ioControlCode, System.Byte[]  @optionInValue, System.Byte[]  @optionOutValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ioControlCode, @optionInValue, @optionOutValue};
            var ___result = RIOControl_Int32_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public static System.Int32 IOControl_icall(System.IntPtr  @sock, System.Int32  @ioctl_code, System.Byte[]  @input, System.Byte[]  @output, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sock, @ioctl_code, @input, @output, @error};
            var ___result = RIOControl_icall_IntPtr_Int32_ByteArray_ByteArray_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[4];

            return (System.Int32)___result;
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Close(System.Int32  @timeout)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@timeout};
            var ___result = RClose_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void Close_icall(System.IntPtr  @socket, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @error};
            var ___result = RClose_icall_IntPtr_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[1];

            
        }


        public virtual void Shutdown(System.Net.Sockets.SocketShutdown  @how)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@how};
            var ___result = RShutdown_SocketShutdown.Invoke(___genericsType, ___parameters);

            
        }



        public static void Shutdown_icall(System.IntPtr  @socket, System.Net.Sockets.SocketShutdown  @how, out System.Int32  @error)
        {
			error = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket, @how, @error};
            var ___result = RShutdown_icall_IntPtr_SocketShutdown_Out_Int32.Invoke(___genericsType, ___parameters);
			error = (System.Int32)___parameters[2];

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Linger(System.IntPtr  @handle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@handle};
            var ___result = RLinger_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowIfDisposedAndClosed(System.Net.Sockets.Socket  @socket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket};
            var ___result = RThrowIfDisposedAndClosed_Socket.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowIfDisposedAndClosed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowIfDisposedAndClosed.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowIfBufferNull(System.Byte[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RThrowIfBufferNull_ByteArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowIfBufferOutOfRange(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @size};
            var ___result = RThrowIfBufferOutOfRange_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowIfUdp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowIfUdp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object ValidateEndIAsyncResult(System.IAsyncResult  @ares, System.String  @methodName, System.String  @argName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ares, @methodName, @argName};
            var ___result = RValidateEndIAsyncResult_IAsyncResult_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }





        public virtual System.Net.IPEndPoint RemapIPEndPoint(System.Net.IPEndPoint  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input};
            var ___result = RRemapIPEndPoint_IPEndPoint.Invoke(___genericsType, ___parameters);

            return (System.Net.IPEndPoint)___result;
        }


        public static void cancel_blocking_socket_operation(System.Threading.Thread  @thread)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@thread};
            var ___result = Rcancel_blocking_socket_operation_Thread.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean SupportsPortReuse(System.Net.Sockets.ProtocolType  @proto)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@proto};
            var ___result = RSupportsPortReuse_ProtocolType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsProtocolSupported_internal(System.Net.NetworkInformation.NetworkInterfaceComponent  @networkInterface)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@networkInterface};
            var ___result = RIsProtocolSupported_internal_NetworkInterfaceComponent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsProtocolSupported(System.Net.NetworkInformation.NetworkInterfaceComponent  @networkInterface)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@networkInterface};
            var ___result = RIsProtocolSupported_NetworkInterfaceComponent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ReplaceHandleIfNecessaryAfterFailedConnect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReplaceHandleIfNecessaryAfterFailedConnect.Invoke(___genericsType, ___parameters);

            
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
