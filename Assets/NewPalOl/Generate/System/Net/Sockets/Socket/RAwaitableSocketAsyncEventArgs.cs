using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{public partial class RSocket
{
	
	/// <summary>
	/// System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs
	/// </summary>
    public partial class RAwaitableSocketAsyncEventArgs : RMember //
    {

		/// <summary>
		/// System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs Reserved
		/// </summary>
		protected static RSystem.RNet.RSockets.RSocket.RAwaitableSocketAsyncEventArgs r_Reserved;
		public static RSystem.RNet.RSockets.RSocket.RAwaitableSocketAsyncEventArgs Reserved
		{
			get
			{
				if(r_Reserved == null)
				{
					r_Reserved = new( ReleactionUtils.GetType("System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs"), "Reserved");
					r_Reserved.SetBelong(null);
				}
				return r_Reserved;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_completedSentinel
		/// </summary>
		protected static RSystem.RAction<RSystem.RObject> r_s_completedSentinel;
		public static RSystem.RAction<RSystem.RObject> Rs_completedSentinel
		{
			get
			{
				if(r_s_completedSentinel == null)
				{
					r_s_completedSentinel = new( ReleactionUtils.GetType("System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs"), "s_completedSentinel");
					r_s_completedSentinel.SetBelong(null);
				}
				return r_s_completedSentinel;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] s_availableSentinel
		/// </summary>
		protected static RSystem.RAction<RSystem.RObject> r_s_availableSentinel;
		public static RSystem.RAction<RSystem.RObject> Rs_availableSentinel
		{
			get
			{
				if(r_s_availableSentinel == null)
				{
					r_s_availableSentinel = new( ReleactionUtils.GetType("System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs"), "s_availableSentinel");
					r_s_availableSentinel.SetBelong(null);
				}
				return r_s_availableSentinel;
			}
		}

		/// <summary>
		/// System.Action`1[System.Object] _continuation
		/// </summary>
		protected RSystem.RAction<RSystem.RObject> r__continuation;
		public virtual RSystem.RAction<RSystem.RObject> R_continuation
		{
			get
			{
				if(r__continuation == null)
				{
					r__continuation = new(this, "_continuation");
					r__continuation.SetBelong(this.instance);
				}
				return r__continuation;
			}
		}

		/// <summary>
		/// System.Threading.ExecutionContext _executionContext
		/// </summary>
		protected RSystem.RThreading.RExecutionContext r__executionContext;
		public virtual RSystem.RThreading.RExecutionContext R_executionContext
		{
			get
			{
				if(r__executionContext == null)
				{
					r__executionContext = new(this, "_executionContext");
					r__executionContext.SetBelong(this.instance);
				}
				return r__executionContext;
			}
		}

		/// <summary>
		/// System.Object _scheduler
		/// </summary>
		protected RSystem.RObject r__scheduler;
		public virtual RSystem.RObject R_scheduler
		{
			get
			{
				if(r__scheduler == null)
				{
					r__scheduler = new(this, "_scheduler");
					r__scheduler.SetBelong(this.instance);
				}
				return r__scheduler;
			}
		}

		/// <summary>
		/// System.Int16 _token
		/// </summary>
		protected RField r__token;
		public virtual RField R_token
		{
			get
			{
				if(r__token == null)
				{
					r__token = new(this, "_token");
					r__token.SetBelong(this.instance);
				}
				return r__token;
			}
		}

		/// <summary>
		/// System.Boolean <WrapExceptionsInIOExceptions>k__BackingField
		/// </summary>
		protected RField r___2__WrapExceptionsInIOExceptions__4__k__BackingField;
		public virtual RField R__2__WrapExceptionsInIOExceptions__4__k__BackingField
		{
			get
			{
				if(r___2__WrapExceptionsInIOExceptions__4__k__BackingField == null)
				{
					r___2__WrapExceptionsInIOExceptions__4__k__BackingField = new(this, "<WrapExceptionsInIOExceptions>k__BackingField");
					r___2__WrapExceptionsInIOExceptions__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__WrapExceptionsInIOExceptions__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 in_progress
		/// </summary>
		protected RField r_in_progress;
		public virtual RField Rin_progress
		{
			get
			{
				if(r_in_progress == null)
				{
					r_in_progress = new(this, "in_progress");
					r_in_progress.SetBelong(this.instance);
				}
				return r_in_progress;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketAsyncResult socket_async_result
		/// </summary>
		protected RSystem.RNet.RSockets.RSocketAsyncResult r_socket_async_result;
		public virtual RSystem.RNet.RSockets.RSocketAsyncResult Rsocket_async_result
		{
			get
			{
				if(r_socket_async_result == null)
				{
					r_socket_async_result = new(this, "socket_async_result");
					r_socket_async_result.SetBelong(this.instance);
				}
				return r_socket_async_result;
			}
		}

		/// <summary>
		/// Boolean WrapExceptionsInIOExceptions
		/// </summary>
		protected RProperty r_WrapExceptionsInIOExceptions;
		public virtual RProperty RWrapExceptionsInIOExceptions
		{
			get
			{
				if(r_WrapExceptionsInIOExceptions == null)
				{
					r_WrapExceptionsInIOExceptions = new(this, "WrapExceptionsInIOExceptions", -1);
					r_WrapExceptionsInIOExceptions.SetBelong(this.instance);
				}
				return r_WrapExceptionsInIOExceptions;
			}
		}

		/// <summary>
		/// System.Exception ConnectByNameError
		/// </summary>
		protected RSystem.RException r_ConnectByNameError;
		public virtual RSystem.RException RConnectByNameError
		{
			get
			{
				if(r_ConnectByNameError == null)
				{
					r_ConnectByNameError = new(this, "ConnectByNameError", -1);
					r_ConnectByNameError.SetBelong(this.instance);
				}
				return r_ConnectByNameError;
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
					r_AcceptSocket = new(this, "AcceptSocket", -1);
					r_AcceptSocket.SetBelong(this.instance);
				}
				return r_AcceptSocket;
			}
		}

		/// <summary>
		/// Int32 BytesTransferred
		/// </summary>
		protected RProperty r_BytesTransferred;
		public virtual RProperty RBytesTransferred
		{
			get
			{
				if(r_BytesTransferred == null)
				{
					r_BytesTransferred = new(this, "BytesTransferred", -1);
					r_BytesTransferred.SetBelong(this.instance);
				}
				return r_BytesTransferred;
			}
		}

		/// <summary>
		/// Boolean DisconnectReuseSocket
		/// </summary>
		protected RProperty r_DisconnectReuseSocket;
		public virtual RProperty RDisconnectReuseSocket
		{
			get
			{
				if(r_DisconnectReuseSocket == null)
				{
					r_DisconnectReuseSocket = new(this, "DisconnectReuseSocket", -1);
					r_DisconnectReuseSocket.SetBelong(this.instance);
				}
				return r_DisconnectReuseSocket;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketAsyncOperation LastOperation
		/// </summary>
		protected RProperty r_LastOperation;
		public virtual RProperty RLastOperation
		{
			get
			{
				if(r_LastOperation == null)
				{
					r_LastOperation = new(this, "LastOperation", -1);
					r_LastOperation.SetBelong(this.instance);
				}
				return r_LastOperation;
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
		/// System.Net.Sockets.IPPacketInformation ReceiveMessageFromPacketInfo
		/// </summary>
		protected RSystem.RNet.RSockets.RIPPacketInformation r_ReceiveMessageFromPacketInfo;
		public virtual RSystem.RNet.RSockets.RIPPacketInformation ReceiveMessageFromPacketInfo
		{
			get
			{
				if(r_ReceiveMessageFromPacketInfo == null)
				{
					r_ReceiveMessageFromPacketInfo = new(this, "ReceiveMessageFromPacketInfo", -1);
					r_ReceiveMessageFromPacketInfo.SetBelong(this.instance);
				}
				return r_ReceiveMessageFromPacketInfo;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SendPacketsElement[] SendPacketsElements
		/// </summary>
		protected RPropertyArray<RSystem.RNet.RSockets.RSendPacketsElement> r_SendPacketsElements;
		public virtual RPropertyArray<RSystem.RNet.RSockets.RSendPacketsElement> RSendPacketsElements
		{
			get
			{
				if(r_SendPacketsElements == null)
				{
					r_SendPacketsElements = new(this, "SendPacketsElements", -1);
					r_SendPacketsElements.SetBelong(this.instance);
				}
				return r_SendPacketsElements;
			}
		}

		/// <summary>
		/// System.Net.Sockets.TransmitFileOptions SendPacketsFlags
		/// </summary>
		protected RProperty r_SendPacketsFlags;
		public virtual RProperty RSendPacketsFlags
		{
			get
			{
				if(r_SendPacketsFlags == null)
				{
					r_SendPacketsFlags = new(this, "SendPacketsFlags", -1);
					r_SendPacketsFlags.SetBelong(this.instance);
				}
				return r_SendPacketsFlags;
			}
		}

		/// <summary>
		/// Int32 SendPacketsSendSize
		/// </summary>
		protected RProperty r_SendPacketsSendSize;
		public virtual RProperty RSendPacketsSendSize
		{
			get
			{
				if(r_SendPacketsSendSize == null)
				{
					r_SendPacketsSendSize = new(this, "SendPacketsSendSize", -1);
					r_SendPacketsSendSize.SetBelong(this.instance);
				}
				return r_SendPacketsSendSize;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketError SocketError
		/// </summary>
		protected RProperty r_SocketError;
		public virtual RProperty RSocketError
		{
			get
			{
				if(r_SocketError == null)
				{
					r_SocketError = new(this, "SocketError", -1);
					r_SocketError.SetBelong(this.instance);
				}
				return r_SocketError;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketFlags SocketFlags
		/// </summary>
		protected RProperty r_SocketFlags;
		public virtual RProperty RSocketFlags
		{
			get
			{
				if(r_SocketFlags == null)
				{
					r_SocketFlags = new(this, "SocketFlags", -1);
					r_SocketFlags.SetBelong(this.instance);
				}
				return r_SocketFlags;
			}
		}

		/// <summary>
		/// System.Object UserToken
		/// </summary>
		protected RSystem.RObject r_UserToken;
		public virtual RSystem.RObject RUserToken
		{
			get
			{
				if(r_UserToken == null)
				{
					r_UserToken = new(this, "UserToken", -1);
					r_UserToken.SetBelong(this.instance);
				}
				return r_UserToken;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket ConnectSocket
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r_ConnectSocket;
		public virtual RSystem.RNet.RSockets.RSocket RConnectSocket
		{
			get
			{
				if(r_ConnectSocket == null)
				{
					r_ConnectSocket = new(this, "ConnectSocket", -1);
					r_ConnectSocket.SetBelong(this.instance);
				}
				return r_ConnectSocket;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket CurrentSocket
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r_CurrentSocket;
		public virtual RSystem.RNet.RSockets.RSocket RCurrentSocket
		{
			get
			{
				if(r_CurrentSocket == null)
				{
					r_CurrentSocket = new(this, "CurrentSocket", -1);
					r_CurrentSocket.SetBelong(this.instance);
				}
				return r_CurrentSocket;
			}
		}

		/// <summary>
		/// Byte[] Buffer
		/// </summary>
		protected RPropertyArray<RProperty> r_Buffer;
		public virtual RPropertyArray<RProperty> RBuffer
		{
			get
			{
				if(r_Buffer == null)
				{
					r_Buffer = new(this, "Buffer", -1);
					r_Buffer.SetBelong(this.instance);
				}
				return r_Buffer;
			}
		}

		/// <summary>
		/// System.Memory`1[System.Byte] MemoryBuffer
		/// </summary>
		protected RSystem.RMemory<RProperty> r_MemoryBuffer;
		public virtual RSystem.RMemory<RProperty> RMemoryBuffer
		{
			get
			{
				if(r_MemoryBuffer == null)
				{
					r_MemoryBuffer = new(this, "MemoryBuffer", -1);
					r_MemoryBuffer.SetBelong(this.instance);
				}
				return r_MemoryBuffer;
			}
		}

		/// <summary>
		/// Int32 Offset
		/// </summary>
		protected RProperty r_Offset;
		public virtual RProperty ROffset
		{
			get
			{
				if(r_Offset == null)
				{
					r_Offset = new(this, "Offset", -1);
					r_Offset.SetBelong(this.instance);
				}
				return r_Offset;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]] BufferList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RArraySegment<RProperty>> r_BufferList;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RArraySegment<RProperty>> RBufferList
		{
			get
			{
				if(r_BufferList == null)
				{
					r_BufferList = new(this, "BufferList", -1);
					r_BufferList.SetBelong(this.instance);
				}
				return r_BufferList;
			}
		}

		/// <summary>
		/// Boolean HasMultipleBuffers
		/// </summary>
		protected RProperty r_HasMultipleBuffers;
		public virtual RProperty RHasMultipleBuffers
		{
			get
			{
				if(r_HasMultipleBuffers == null)
				{
					r_HasMultipleBuffers = new(this, "HasMultipleBuffers", -1);
					r_HasMultipleBuffers.SetBelong(this.instance);
				}
				return r_HasMultipleBuffers;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketClientAccessPolicyProtocol SocketClientAccessPolicyProtocol
		/// </summary>
		protected RProperty r_SocketClientAccessPolicyProtocol;
		public virtual RProperty RSocketClientAccessPolicyProtocol
		{
			get
			{
				if(r_SocketClientAccessPolicyProtocol == null)
				{
					r_SocketClientAccessPolicyProtocol = new(this, "SocketClientAccessPolicyProtocol", -1);
					r_SocketClientAccessPolicyProtocol.SetBelong(this.instance);
				}
				return r_SocketClientAccessPolicyProtocol;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Net.Sockets.SocketAsyncEventArgs] Completed
		/// </summary>
		protected REvent r_Completed;
		public virtual REvent RCompleted
		{
			get
			{
				if(r_Completed == null)
				{
					r_Completed = new(this, "Completed");
					r_Completed.SetBelong(this.instance);
				}
				return r_Completed;
			}
		}

		/// <summary>
		/// Boolean Reserve()
		/// </summary>
		protected RMethod r_RReserve;
		public virtual RMethod RReserve
		{
			get
			{
				if(r_RReserve == null)
				{
					r_RReserve = new(this, "Reserve", 0);
					r_RReserve.SetBelong(this.instance);
				}
				return r_RReserve;
			}
		}

		/// <summary>
		/// Void Release()
		/// </summary>
		protected RMethod r_RRelease;
		public virtual RMethod RRelease
		{
			get
			{
				if(r_RRelease == null)
				{
					r_RRelease = new(this, "Release", 0);
					r_RRelease.SetBelong(this.instance);
				}
				return r_RRelease;
			}
		}

		/// <summary>
		/// Void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_ROnCompleted_SocketAsyncEventArgs;
		public virtual RMethod ROnCompleted_SocketAsyncEventArgs
		{
			get
			{
				if(r_ROnCompleted_SocketAsyncEventArgs == null)
				{
					r_ROnCompleted_SocketAsyncEventArgs = new(this, "OnCompleted", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_ROnCompleted_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_ROnCompleted_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReceiveAsync(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RReceiveAsync_Socket;
		public virtual RMethod RReceiveAsync_Socket
		{
			get
			{
				if(r_RReceiveAsync_Socket == null)
				{
					r_RReceiveAsync_Socket = new(this, "ReceiveAsync", 0, typeof(System.Net.Sockets.Socket));
					r_RReceiveAsync_Socket.SetBelong(this.instance);
				}
				return r_RReceiveAsync_Socket;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] SendAsync(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RSendAsync_Socket;
		public virtual RMethod RSendAsync_Socket
		{
			get
			{
				if(r_RSendAsync_Socket == null)
				{
					r_RSendAsync_Socket = new(this, "SendAsync", 0, typeof(System.Net.Sockets.Socket));
					r_RSendAsync_Socket.SetBelong(this.instance);
				}
				return r_RSendAsync_Socket;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RSendAsyncForNetworkStream_Socket;
		public virtual RMethod RSendAsyncForNetworkStream_Socket
		{
			get
			{
				if(r_RSendAsyncForNetworkStream_Socket == null)
				{
					r_RSendAsyncForNetworkStream_Socket = new(this, "SendAsyncForNetworkStream", 0, typeof(System.Net.Sockets.Socket));
					r_RSendAsyncForNetworkStream_Socket.SetBelong(this.instance);
				}
				return r_RSendAsyncForNetworkStream_Socket;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(Int16)
		/// </summary>
		protected RMethod r_RGetStatus_Int16;
		public virtual RMethod RGetStatus_Int16
		{
			get
			{
				if(r_RGetStatus_Int16 == null)
				{
					r_RGetStatus_Int16 = new(this, "GetStatus", 0, typeof(System.Int16));
					r_RGetStatus_Int16.SetBelong(this.instance);
				}
				return r_RGetStatus_Int16;
			}
		}

		/// <summary>
		/// Void OnCompleted(System.Action`1[System.Object], System.Object, Int16, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags)
		/// </summary>
		protected RMethod r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags;
		public virtual RMethod ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags
		{
			get
			{
				if(r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags == null)
				{
					r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags = new(this, "OnCompleted", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Int16), typeof(System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags));
					r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags.SetBelong(this.instance);
				}
				return r_ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags;
			}
		}

		/// <summary>
		/// Void InvokeContinuation(System.Action`1[System.Object], System.Object, Boolean)
		/// </summary>
		protected RMethod r_RInvokeContinuation_Action_d_Object_p__Object_Boolean;
		public virtual RMethod RInvokeContinuation_Action_d_Object_p__Object_Boolean
		{
			get
			{
				if(r_RInvokeContinuation_Action_d_Object_p__Object_Boolean == null)
				{
					r_RInvokeContinuation_Action_d_Object_p__Object_Boolean = new(this, "InvokeContinuation", 0, typeof(System.Action<>).MakeGenericType(typeof(System.Object)), typeof(System.Object), typeof(System.Boolean));
					r_RInvokeContinuation_Action_d_Object_p__Object_Boolean.SetBelong(this.instance);
				}
				return r_RInvokeContinuation_Action_d_Object_p__Object_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetResult(Int16)
		/// </summary>
		protected RMethod r_RGetResult_Int16;
		public virtual RMethod RGetResult_Int16
		{
			get
			{
				if(r_RGetResult_Int16 == null)
				{
					r_RGetResult_Int16 = new(this, "GetResult", 0, typeof(System.Int16));
					r_RGetResult_Int16.SetBelong(this.instance);
				}
				return r_RGetResult_Int16;
			}
		}

		/// <summary>
		/// Void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(Int16)
		/// </summary>
		protected RMethod r_RSystem__1__Threading__1__Tasks__1__Sources__1__IValueTaskSource__1__GetResult_Int16;
		public virtual RMethod RSystem__1__Threading__1__Tasks__1__Sources__1__IValueTaskSource__1__GetResult_Int16
		{
			get
			{
				if(r_RSystem__1__Threading__1__Tasks__1__Sources__1__IValueTaskSource__1__GetResult_Int16 == null)
				{
					r_RSystem__1__Threading__1__Tasks__1__Sources__1__IValueTaskSource__1__GetResult_Int16 = new(this, "System.Threading.Tasks.Sources.IValueTaskSource.GetResult", 0, typeof(System.Int16));
					r_RSystem__1__Threading__1__Tasks__1__Sources__1__IValueTaskSource__1__GetResult_Int16.SetBelong(this.instance);
				}
				return r_RSystem__1__Threading__1__Tasks__1__Sources__1__IValueTaskSource__1__GetResult_Int16;
			}
		}

		/// <summary>
		/// Void ThrowIncorrectTokenException()
		/// </summary>
		protected RMethod r_RThrowIncorrectTokenException;
		public virtual RMethod RThrowIncorrectTokenException
		{
			get
			{
				if(r_RThrowIncorrectTokenException == null)
				{
					r_RThrowIncorrectTokenException = new(this, "ThrowIncorrectTokenException", 0);
					r_RThrowIncorrectTokenException.SetBelong(this.instance);
				}
				return r_RThrowIncorrectTokenException;
			}
		}

		/// <summary>
		/// Void ThrowMultipleContinuationsException()
		/// </summary>
		protected RMethod r_RThrowMultipleContinuationsException;
		public virtual RMethod RThrowMultipleContinuationsException
		{
			get
			{
				if(r_RThrowMultipleContinuationsException == null)
				{
					r_RThrowMultipleContinuationsException = new(this, "ThrowMultipleContinuationsException", 0);
					r_RThrowMultipleContinuationsException.SetBelong(this.instance);
				}
				return r_RThrowMultipleContinuationsException;
			}
		}

		/// <summary>
		/// Void ThrowException(System.Net.Sockets.SocketError)
		/// </summary>
		protected RMethod r_RThrowException_SocketError;
		public virtual RMethod RThrowException_SocketError
		{
			get
			{
				if(r_RThrowException_SocketError == null)
				{
					r_RThrowException_SocketError = new(this, "ThrowException", 0, typeof(System.Net.Sockets.SocketError));
					r_RThrowException_SocketError.SetBelong(this.instance);
				}
				return r_RThrowException_SocketError;
			}
		}

		/// <summary>
		/// System.Exception CreateException(System.Net.Sockets.SocketError)
		/// </summary>
		protected RMethod r_RCreateException_SocketError;
		public virtual RMethod RCreateException_SocketError
		{
			get
			{
				if(r_RCreateException_SocketError == null)
				{
					r_RCreateException_SocketError = new(this, "CreateException", 0, typeof(System.Net.Sockets.SocketError));
					r_RCreateException_SocketError.SetBelong(this.instance);
				}
				return r_RCreateException_SocketError;
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
		/// Void SetConnectByNameError(System.Exception)
		/// </summary>
		protected RMethod r_RSetConnectByNameError_Exception;
		public virtual RMethod RSetConnectByNameError_Exception
		{
			get
			{
				if(r_RSetConnectByNameError_Exception == null)
				{
					r_RSetConnectByNameError_Exception = new(this, "SetConnectByNameError", 0, typeof(System.Exception));
					r_RSetConnectByNameError_Exception.SetBelong(this.instance);
				}
				return r_RSetConnectByNameError_Exception;
			}
		}

		/// <summary>
		/// Void SetBytesTransferred(Int32)
		/// </summary>
		protected RMethod r_RSetBytesTransferred_Int32;
		public virtual RMethod RSetBytesTransferred_Int32
		{
			get
			{
				if(r_RSetBytesTransferred_Int32 == null)
				{
					r_RSetBytesTransferred_Int32 = new(this, "SetBytesTransferred", 0, typeof(System.Int32));
					r_RSetBytesTransferred_Int32.SetBelong(this.instance);
				}
				return r_RSetBytesTransferred_Int32;
			}
		}

		/// <summary>
		/// Void SetCurrentSocket(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RSetCurrentSocket_Socket;
		public virtual RMethod RSetCurrentSocket_Socket
		{
			get
			{
				if(r_RSetCurrentSocket_Socket == null)
				{
					r_RSetCurrentSocket_Socket = new(this, "SetCurrentSocket", 0, typeof(System.Net.Sockets.Socket));
					r_RSetCurrentSocket_Socket.SetBelong(this.instance);
				}
				return r_RSetCurrentSocket_Socket;
			}
		}

		/// <summary>
		/// Void SetLastOperation(System.Net.Sockets.SocketAsyncOperation)
		/// </summary>
		protected RMethod r_RSetLastOperation_SocketAsyncOperation;
		public virtual RMethod RSetLastOperation_SocketAsyncOperation
		{
			get
			{
				if(r_RSetLastOperation_SocketAsyncOperation == null)
				{
					r_RSetLastOperation_SocketAsyncOperation = new(this, "SetLastOperation", 0, typeof(System.Net.Sockets.SocketAsyncOperation));
					r_RSetLastOperation_SocketAsyncOperation.SetBelong(this.instance);
				}
				return r_RSetLastOperation_SocketAsyncOperation;
			}
		}

		/// <summary>
		/// Void Complete_internal()
		/// </summary>
		protected RMethod r_RComplete_internal;
		public virtual RMethod RComplete_internal
		{
			get
			{
				if(r_RComplete_internal == null)
				{
					r_RComplete_internal = new(this, "Complete_internal", 0);
					r_RComplete_internal.SetBelong(this.instance);
				}
				return r_RComplete_internal;
			}
		}

		/// <summary>
		/// Void StartOperationCommon(System.Net.Sockets.Socket)
		/// </summary>
		protected RMethod r_RStartOperationCommon_Socket;
		public virtual RMethod RStartOperationCommon_Socket
		{
			get
			{
				if(r_RStartOperationCommon_Socket == null)
				{
					r_RStartOperationCommon_Socket = new(this, "StartOperationCommon", 0, typeof(System.Net.Sockets.Socket));
					r_RStartOperationCommon_Socket.SetBelong(this.instance);
				}
				return r_RStartOperationCommon_Socket;
			}
		}

		/// <summary>
		/// Void StartOperationWrapperConnect(System.Net.Sockets.MultipleConnectAsync)
		/// </summary>
		protected RMethod r_RStartOperationWrapperConnect_MultipleConnectAsync;
		public virtual RMethod RStartOperationWrapperConnect_MultipleConnectAsync
		{
			get
			{
				if(r_RStartOperationWrapperConnect_MultipleConnectAsync == null)
				{
					r_RStartOperationWrapperConnect_MultipleConnectAsync = new(this, "StartOperationWrapperConnect", 0,  ReleactionUtils.GetType("System.Net.Sockets.MultipleConnectAsync"));
					r_RStartOperationWrapperConnect_MultipleConnectAsync.SetBelong(this.instance);
				}
				return r_RStartOperationWrapperConnect_MultipleConnectAsync;
			}
		}

		/// <summary>
		/// Void FinishConnectByNameSyncFailure(System.Exception, Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RFinishConnectByNameSyncFailure_Exception_Int32_SocketFlags;
		public virtual RMethod RFinishConnectByNameSyncFailure_Exception_Int32_SocketFlags
		{
			get
			{
				if(r_RFinishConnectByNameSyncFailure_Exception_Int32_SocketFlags == null)
				{
					r_RFinishConnectByNameSyncFailure_Exception_Int32_SocketFlags = new(this, "FinishConnectByNameSyncFailure", 0, typeof(System.Exception), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RFinishConnectByNameSyncFailure_Exception_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RFinishConnectByNameSyncFailure_Exception_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Void FinishOperationAsyncFailure(System.Exception, Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RFinishOperationAsyncFailure_Exception_Int32_SocketFlags;
		public virtual RMethod RFinishOperationAsyncFailure_Exception_Int32_SocketFlags
		{
			get
			{
				if(r_RFinishOperationAsyncFailure_Exception_Int32_SocketFlags == null)
				{
					r_RFinishOperationAsyncFailure_Exception_Int32_SocketFlags = new(this, "FinishOperationAsyncFailure", 0, typeof(System.Exception), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RFinishOperationAsyncFailure_Exception_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RFinishOperationAsyncFailure_Exception_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Void FinishWrapperConnectSuccess(System.Net.Sockets.Socket, Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RFinishWrapperConnectSuccess_Socket_Int32_SocketFlags;
		public virtual RMethod RFinishWrapperConnectSuccess_Socket_Int32_SocketFlags
		{
			get
			{
				if(r_RFinishWrapperConnectSuccess_Socket_Int32_SocketFlags == null)
				{
					r_RFinishWrapperConnectSuccess_Socket_Int32_SocketFlags = new(this, "FinishWrapperConnectSuccess", 0, typeof(System.Net.Sockets.Socket), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RFinishWrapperConnectSuccess_Socket_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RFinishWrapperConnectSuccess_Socket_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Void SetResults(System.Net.Sockets.SocketError, Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSetResults_SocketError_Int32_SocketFlags;
		public virtual RMethod RSetResults_SocketError_Int32_SocketFlags
		{
			get
			{
				if(r_RSetResults_SocketError_Int32_SocketFlags == null)
				{
					r_RSetResults_SocketError_Int32_SocketFlags = new(this, "SetResults", 0, typeof(System.Net.Sockets.SocketError), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RSetResults_SocketError_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RSetResults_SocketError_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Void SetResults(System.Exception, Int32, System.Net.Sockets.SocketFlags)
		/// </summary>
		protected RMethod r_RSetResults_Exception_Int32_SocketFlags;
		public virtual RMethod RSetResults_Exception_Int32_SocketFlags
		{
			get
			{
				if(r_RSetResults_Exception_Int32_SocketFlags == null)
				{
					r_RSetResults_Exception_Int32_SocketFlags = new(this, "SetResults", 0, typeof(System.Exception), typeof(System.Int32), typeof(System.Net.Sockets.SocketFlags));
					r_RSetResults_Exception_Int32_SocketFlags.SetBelong(this.instance);
				}
				return r_RSetResults_Exception_Int32_SocketFlags;
			}
		}

		/// <summary>
		/// Void SetBuffer(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetBuffer_Int32_Int32;
		public virtual RMethod RSetBuffer_Int32_Int32
		{
			get
			{
				if(r_RSetBuffer_Int32_Int32 == null)
				{
					r_RSetBuffer_Int32_Int32 = new(this, "SetBuffer", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetBuffer_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetBuffer_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CopyBufferFrom(System.Net.Sockets.SocketAsyncEventArgs)
		/// </summary>
		protected RMethod r_RCopyBufferFrom_SocketAsyncEventArgs;
		public virtual RMethod RCopyBufferFrom_SocketAsyncEventArgs
		{
			get
			{
				if(r_RCopyBufferFrom_SocketAsyncEventArgs == null)
				{
					r_RCopyBufferFrom_SocketAsyncEventArgs = new(this, "CopyBufferFrom", 0, typeof(System.Net.Sockets.SocketAsyncEventArgs));
					r_RCopyBufferFrom_SocketAsyncEventArgs.SetBelong(this.instance);
				}
				return r_RCopyBufferFrom_SocketAsyncEventArgs;
			}
		}

		/// <summary>
		/// Void SetBuffer(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RSetBuffer_ByteArray_Int32_Int32;
		public virtual RMethod RSetBuffer_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RSetBuffer_ByteArray_Int32_Int32 == null)
				{
					r_RSetBuffer_ByteArray_Int32_Int32 = new(this, "SetBuffer", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RSetBuffer_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetBuffer_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetBuffer(System.Memory`1[System.Byte])
		/// </summary>
		protected RMethod r_RSetBuffer_Memory_d_Byte_p_;
		public virtual RMethod RSetBuffer_Memory_d_Byte_p_
		{
			get
			{
				if(r_RSetBuffer_Memory_d_Byte_p_ == null)
				{
					r_RSetBuffer_Memory_d_Byte_p_ = new(this, "SetBuffer", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Byte)));
					r_RSetBuffer_Memory_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RSetBuffer_Memory_d_Byte_p_;
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


        public RAwaitableSocketAsyncEventArgs() : base("System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs")
        {
        }

        public RAwaitableSocketAsyncEventArgs(System.Object instance) : base("System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs")
		{
            SetInstance(instance);
		}

        public RAwaitableSocketAsyncEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAwaitableSocketAsyncEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Reserve()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReserve.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs  @_)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_};
            var ___result = ROnCompleted_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReceiveAsync(System.Net.Sockets.Socket  @socket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket};
            var ___result = RReceiveAsync_Socket.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> SendAsync(System.Net.Sockets.Socket  @socket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket};
            var ___result = RSendAsync_Socket.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask SendAsyncForNetworkStream(System.Net.Sockets.Socket  @socket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket};
            var ___result = RSendAsyncForNetworkStream_Socket.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(System.Int16  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RGetStatus_Int16.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Sources.ValueTaskSourceStatus)___result;
        }


        public virtual void OnCompleted(System.Action<System.Object>  @continuation, System.Object  @state, System.Int16  @token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation, @state, @token, @flags};
            var ___result = ROnCompleted_Action_d_Object_p__Object_Int16_ValueTaskSourceOnCompletedFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeContinuation(System.Action<System.Object>  @continuation, System.Object  @state, System.Boolean  @forceAsync)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@continuation, @state, @forceAsync};
            var ___result = RInvokeContinuation_Action_d_Object_p__Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetResult(System.Int16  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RGetResult_Int16.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void System__1__Threading__1__Tasks__1__Sources__1__IValueTaskSource__1__GetResult(System.Int16  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RSystem__1__Threading__1__Tasks__1__Sources__1__IValueTaskSource__1__GetResult_Int16.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowIncorrectTokenException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowIncorrectTokenException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowMultipleContinuationsException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowMultipleContinuationsException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowException(System.Net.Sockets.SocketError  @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@error};
            var ___result = RThrowException_SocketError.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception CreateException(System.Net.Sockets.SocketError  @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@error};
            var ___result = RCreateException_SocketError.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetConnectByNameError(System.Exception  @error)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@error};
            var ___result = RSetConnectByNameError_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBytesTransferred(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetBytesTransferred_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCurrentSocket(System.Net.Sockets.Socket  @socket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket};
            var ___result = RSetCurrentSocket_Socket.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLastOperation(System.Net.Sockets.SocketAsyncOperation  @op)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@op};
            var ___result = RSetLastOperation_SocketAsyncOperation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Complete_internal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RComplete_internal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartOperationCommon(System.Net.Sockets.Socket  @socket)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socket};
            var ___result = RStartOperationCommon_Socket.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void FinishConnectByNameSyncFailure(System.Exception  @exception, System.Int32  @bytesTransferred, System.Net.Sockets.SocketFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception, @bytesTransferred, @flags};
            var ___result = RFinishConnectByNameSyncFailure_Exception_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishOperationAsyncFailure(System.Exception  @exception, System.Int32  @bytesTransferred, System.Net.Sockets.SocketFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception, @bytesTransferred, @flags};
            var ___result = RFinishOperationAsyncFailure_Exception_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishWrapperConnectSuccess(System.Net.Sockets.Socket  @connectSocket, System.Int32  @bytesTransferred, System.Net.Sockets.SocketFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@connectSocket, @bytesTransferred, @flags};
            var ___result = RFinishWrapperConnectSuccess_Socket_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetResults(System.Net.Sockets.SocketError  @socketError, System.Int32  @bytesTransferred, System.Net.Sockets.SocketFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socketError, @bytesTransferred, @flags};
            var ___result = RSetResults_SocketError_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetResults(System.Exception  @exception, System.Int32  @bytesTransferred, System.Net.Sockets.SocketFlags  @flags)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@exception, @bytesTransferred, @flags};
            var ___result = RSetResults_Exception_Int32_SocketFlags.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@offset, @count};
            var ___result = RSetBuffer_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyBufferFrom(System.Net.Sockets.SocketAsyncEventArgs  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RCopyBufferFrom_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Byte[]  @buffer, System.Int32  @offset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @offset, @count};
            var ___result = RSetBuffer_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBuffer(System.Memory<System.Byte>  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RSetBuffer_Memory_d_Byte_p_.Invoke(___genericsType, ___parameters);

            
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
}