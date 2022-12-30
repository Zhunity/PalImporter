using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.SocketAsyncEventArgs
	/// </summary>
    public partial class RSocketAsyncEventArgs : RMember //
    {

		/// <summary>
		/// System.Boolean disposed
		/// </summary>
		protected RField r_disposed;
		public virtual RField Rdisposed
		{
			get
			{
				if(r_disposed == null)
				{
					r_disposed = new(this, "disposed");
					r_disposed.SetBelong(this.instance);
				}
				return r_disposed;
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
		/// System.Net.EndPoint remote_ep
		/// </summary>
		protected RSystem.RNet.REndPoint r_remote_ep;
		public virtual RSystem.RNet.REndPoint Rremote_ep
		{
			get
			{
				if(r_remote_ep == null)
				{
					r_remote_ep = new(this, "remote_ep");
					r_remote_ep.SetBelong(this.instance);
				}
				return r_remote_ep;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket current_socket
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r_current_socket;
		public virtual RSystem.RNet.RSockets.RSocket Rcurrent_socket
		{
			get
			{
				if(r_current_socket == null)
				{
					r_current_socket = new(this, "current_socket");
					r_current_socket.SetBelong(this.instance);
				}
				return r_current_socket;
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
		/// System.Exception <ConnectByNameError>k__BackingField
		/// </summary>
		protected RSystem.RException r___2__ConnectByNameError__4__k__BackingField;
		public virtual RSystem.RException R__2__ConnectByNameError__4__k__BackingField
		{
			get
			{
				if(r___2__ConnectByNameError__4__k__BackingField == null)
				{
					r___2__ConnectByNameError__4__k__BackingField = new(this, "<ConnectByNameError>k__BackingField");
					r___2__ConnectByNameError__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__ConnectByNameError__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Net.Sockets.Socket <AcceptSocket>k__BackingField
		/// </summary>
		protected RSystem.RNet.RSockets.RSocket r___2__AcceptSocket__4__k__BackingField;
		public virtual RSystem.RNet.RSockets.RSocket R__2__AcceptSocket__4__k__BackingField
		{
			get
			{
				if(r___2__AcceptSocket__4__k__BackingField == null)
				{
					r___2__AcceptSocket__4__k__BackingField = new(this, "<AcceptSocket>k__BackingField");
					r___2__AcceptSocket__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__AcceptSocket__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <BytesTransferred>k__BackingField
		/// </summary>
		protected RField r___2__BytesTransferred__4__k__BackingField;
		public virtual RField R__2__BytesTransferred__4__k__BackingField
		{
			get
			{
				if(r___2__BytesTransferred__4__k__BackingField == null)
				{
					r___2__BytesTransferred__4__k__BackingField = new(this, "<BytesTransferred>k__BackingField");
					r___2__BytesTransferred__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__BytesTransferred__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Boolean <DisconnectReuseSocket>k__BackingField
		/// </summary>
		protected RField r___2__DisconnectReuseSocket__4__k__BackingField;
		public virtual RField R__2__DisconnectReuseSocket__4__k__BackingField
		{
			get
			{
				if(r___2__DisconnectReuseSocket__4__k__BackingField == null)
				{
					r___2__DisconnectReuseSocket__4__k__BackingField = new(this, "<DisconnectReuseSocket>k__BackingField");
					r___2__DisconnectReuseSocket__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__DisconnectReuseSocket__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketAsyncOperation <LastOperation>k__BackingField
		/// </summary>
		protected RField r___2__LastOperation__4__k__BackingField;
		public virtual RField R__2__LastOperation__4__k__BackingField
		{
			get
			{
				if(r___2__LastOperation__4__k__BackingField == null)
				{
					r___2__LastOperation__4__k__BackingField = new(this, "<LastOperation>k__BackingField");
					r___2__LastOperation__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__LastOperation__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Net.Sockets.IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField
		/// </summary>
		protected RSystem.RNet.RSockets.RIPPacketInformation r___2__ReceiveMessageFromPacketInfo__4__k__BackingField;
		public virtual RSystem.RNet.RSockets.RIPPacketInformation R__2__ReceiveMessageFromPacketInfo__4__k__BackingField
		{
			get
			{
				if(r___2__ReceiveMessageFromPacketInfo__4__k__BackingField == null)
				{
					r___2__ReceiveMessageFromPacketInfo__4__k__BackingField = new(this, "<ReceiveMessageFromPacketInfo>k__BackingField");
					r___2__ReceiveMessageFromPacketInfo__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__ReceiveMessageFromPacketInfo__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SendPacketsElement[] <SendPacketsElements>k__BackingField
		/// </summary>
		protected RFieldArray<RSystem.RNet.RSockets.RSendPacketsElement> r___2__SendPacketsElements__4__k__BackingField;
		public virtual RFieldArray<RSystem.RNet.RSockets.RSendPacketsElement> R__2__SendPacketsElements__4__k__BackingField
		{
			get
			{
				if(r___2__SendPacketsElements__4__k__BackingField == null)
				{
					r___2__SendPacketsElements__4__k__BackingField = new(this, "<SendPacketsElements>k__BackingField");
					r___2__SendPacketsElements__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__SendPacketsElements__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Net.Sockets.TransmitFileOptions <SendPacketsFlags>k__BackingField
		/// </summary>
		protected RField r___2__SendPacketsFlags__4__k__BackingField;
		public virtual RField R__2__SendPacketsFlags__4__k__BackingField
		{
			get
			{
				if(r___2__SendPacketsFlags__4__k__BackingField == null)
				{
					r___2__SendPacketsFlags__4__k__BackingField = new(this, "<SendPacketsFlags>k__BackingField");
					r___2__SendPacketsFlags__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__SendPacketsFlags__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Int32 <SendPacketsSendSize>k__BackingField
		/// </summary>
		protected RField r___2__SendPacketsSendSize__4__k__BackingField;
		public virtual RField R__2__SendPacketsSendSize__4__k__BackingField
		{
			get
			{
				if(r___2__SendPacketsSendSize__4__k__BackingField == null)
				{
					r___2__SendPacketsSendSize__4__k__BackingField = new(this, "<SendPacketsSendSize>k__BackingField");
					r___2__SendPacketsSendSize__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__SendPacketsSendSize__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketError <SocketError>k__BackingField
		/// </summary>
		protected RField r___2__SocketError__4__k__BackingField;
		public virtual RField R__2__SocketError__4__k__BackingField
		{
			get
			{
				if(r___2__SocketError__4__k__BackingField == null)
				{
					r___2__SocketError__4__k__BackingField = new(this, "<SocketError>k__BackingField");
					r___2__SocketError__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__SocketError__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketFlags <SocketFlags>k__BackingField
		/// </summary>
		protected RField r___2__SocketFlags__4__k__BackingField;
		public virtual RField R__2__SocketFlags__4__k__BackingField
		{
			get
			{
				if(r___2__SocketFlags__4__k__BackingField == null)
				{
					r___2__SocketFlags__4__k__BackingField = new(this, "<SocketFlags>k__BackingField");
					r___2__SocketFlags__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__SocketFlags__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Object <UserToken>k__BackingField
		/// </summary>
		protected RSystem.RObject r___2__UserToken__4__k__BackingField;
		public virtual RSystem.RObject R__2__UserToken__4__k__BackingField
		{
			get
			{
				if(r___2__UserToken__4__k__BackingField == null)
				{
					r___2__UserToken__4__k__BackingField = new(this, "<UserToken>k__BackingField");
					r___2__UserToken__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__UserToken__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.EventHandler`1[System.Net.Sockets.SocketAsyncEventArgs] Completed
		/// </summary>
		protected RSystem.REventHandler<RSystem.RNet.RSockets.RSocketAsyncEventArgs> r_Completed;
		public virtual RSystem.REventHandler<RSystem.RNet.RSockets.RSocketAsyncEventArgs> RCompleted
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
		/// System.Memory`1[System.Byte] _buffer
		/// </summary>
		protected RSystem.RMemory<RField> r__buffer;
		public virtual RSystem.RMemory<RField> R_buffer
		{
			get
			{
				if(r__buffer == null)
				{
					r__buffer = new(this, "_buffer");
					r__buffer.SetBelong(this.instance);
				}
				return r__buffer;
			}
		}

		/// <summary>
		/// System.Int32 _offset
		/// </summary>
		protected RField r__offset;
		public virtual RField R_offset
		{
			get
			{
				if(r__offset == null)
				{
					r__offset = new(this, "_offset");
					r__offset.SetBelong(this.instance);
				}
				return r__offset;
			}
		}

		/// <summary>
		/// System.Int32 _count
		/// </summary>
		protected RField r__count;
		public virtual RField R_count
		{
			get
			{
				if(r__count == null)
				{
					r__count = new(this, "_count");
					r__count.SetBelong(this.instance);
				}
				return r__count;
			}
		}

		/// <summary>
		/// System.Boolean _bufferIsExplicitArray
		/// </summary>
		protected RField r__bufferIsExplicitArray;
		public virtual RField R_bufferIsExplicitArray
		{
			get
			{
				if(r__bufferIsExplicitArray == null)
				{
					r__bufferIsExplicitArray = new(this, "_bufferIsExplicitArray");
					r__bufferIsExplicitArray.SetBelong(this.instance);
				}
				return r__bufferIsExplicitArray;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IList`1[System.ArraySegment`1[System.Byte]] _bufferList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RIList<RSystem.RArraySegment<RField>> r__bufferList;
		public virtual RSystem.RCollections.RGeneric.RIList<RSystem.RArraySegment<RField>> R_bufferList
		{
			get
			{
				if(r__bufferList == null)
				{
					r__bufferList = new(this, "_bufferList");
					r__bufferList.SetBelong(this.instance);
				}
				return r__bufferList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.ArraySegment`1[System.Byte]] _bufferListInternal
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RArraySegment<RField>> r__bufferListInternal;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RArraySegment<RField>> R_bufferListInternal
		{
			get
			{
				if(r__bufferListInternal == null)
				{
					r__bufferListInternal = new(this, "_bufferListInternal");
					r__bufferListInternal.SetBelong(this.instance);
				}
				return r__bufferListInternal;
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


        public RSocketAsyncEventArgs() : base("System.Net.Sockets.SocketAsyncEventArgs")
        {
        }

        public RSocketAsyncEventArgs(System.Object instance) : base("System.Net.Sockets.SocketAsyncEventArgs")
		{
            SetInstance(instance);
		}

        public RSocketAsyncEventArgs(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSocketAsyncEventArgs(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


        public virtual void OnCompleted(System.Net.Sockets.SocketAsyncEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = ROnCompleted_SocketAsyncEventArgs.Invoke(___genericsType, ___parameters);

            
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
