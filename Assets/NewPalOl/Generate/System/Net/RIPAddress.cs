using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet
{
	/// <summary>
	/// System.Net.IPAddress
	/// </summary>
    public partial class RIPAddress : RMember //
    {

		/// <summary>
		/// System.Net.IPAddress Any
		/// </summary>
		protected static RSystem.RNet.RIPAddress r_Any;
		public static RSystem.RNet.RIPAddress RAny
		{
			get
			{
				if(r_Any == null)
				{
					r_Any = new(typeof(System.Net.IPAddress), "Any");
					r_Any.SetBelong(null);
				}
				return r_Any;
			}
		}

		/// <summary>
		/// System.Net.IPAddress Loopback
		/// </summary>
		protected static RSystem.RNet.RIPAddress r_Loopback;
		public static RSystem.RNet.RIPAddress RLoopback
		{
			get
			{
				if(r_Loopback == null)
				{
					r_Loopback = new(typeof(System.Net.IPAddress), "Loopback");
					r_Loopback.SetBelong(null);
				}
				return r_Loopback;
			}
		}

		/// <summary>
		/// System.Net.IPAddress Broadcast
		/// </summary>
		protected static RSystem.RNet.RIPAddress r_Broadcast;
		public static RSystem.RNet.RIPAddress RBroadcast
		{
			get
			{
				if(r_Broadcast == null)
				{
					r_Broadcast = new(typeof(System.Net.IPAddress), "Broadcast");
					r_Broadcast.SetBelong(null);
				}
				return r_Broadcast;
			}
		}

		/// <summary>
		/// System.Net.IPAddress None
		/// </summary>
		protected static RSystem.RNet.RIPAddress r_None;
		public static RSystem.RNet.RIPAddress RNone
		{
			get
			{
				if(r_None == null)
				{
					r_None = new(typeof(System.Net.IPAddress), "None");
					r_None.SetBelong(null);
				}
				return r_None;
			}
		}

		/// <summary>
		/// System.Int64 LoopbackMask
		/// </summary>
		protected static RField r_LoopbackMask;
		public static RField RLoopbackMask
		{
			get
			{
				if(r_LoopbackMask == null)
				{
					r_LoopbackMask = new(typeof(System.Net.IPAddress), "LoopbackMask");
					r_LoopbackMask.SetBelong(null);
				}
				return r_LoopbackMask;
			}
		}

		/// <summary>
		/// System.Net.IPAddress IPv6Any
		/// </summary>
		protected static RSystem.RNet.RIPAddress r_IPv6Any;
		public static RSystem.RNet.RIPAddress RIPv6Any
		{
			get
			{
				if(r_IPv6Any == null)
				{
					r_IPv6Any = new(typeof(System.Net.IPAddress), "IPv6Any");
					r_IPv6Any.SetBelong(null);
				}
				return r_IPv6Any;
			}
		}

		/// <summary>
		/// System.Net.IPAddress IPv6Loopback
		/// </summary>
		protected static RSystem.RNet.RIPAddress r_IPv6Loopback;
		public static RSystem.RNet.RIPAddress RIPv6Loopback
		{
			get
			{
				if(r_IPv6Loopback == null)
				{
					r_IPv6Loopback = new(typeof(System.Net.IPAddress), "IPv6Loopback");
					r_IPv6Loopback.SetBelong(null);
				}
				return r_IPv6Loopback;
			}
		}

		/// <summary>
		/// System.Net.IPAddress IPv6None
		/// </summary>
		protected static RSystem.RNet.RIPAddress r_IPv6None;
		public static RSystem.RNet.RIPAddress RIPv6None
		{
			get
			{
				if(r_IPv6None == null)
				{
					r_IPv6None = new(typeof(System.Net.IPAddress), "IPv6None");
					r_IPv6None.SetBelong(null);
				}
				return r_IPv6None;
			}
		}

		/// <summary>
		/// System.UInt32 _addressOrScopeId
		/// </summary>
		protected RField r__addressOrScopeId;
		public virtual RField R_addressOrScopeId
		{
			get
			{
				if(r__addressOrScopeId == null)
				{
					r__addressOrScopeId = new(this, "_addressOrScopeId");
					r__addressOrScopeId.SetBelong(this.instance);
				}
				return r__addressOrScopeId;
			}
		}

		/// <summary>
		/// System.UInt16[] _numbers
		/// </summary>
		protected RFieldArray<RField> r__numbers;
		public virtual RFieldArray<RField> R_numbers
		{
			get
			{
				if(r__numbers == null)
				{
					r__numbers = new(this, "_numbers");
					r__numbers.SetBelong(this.instance);
				}
				return r__numbers;
			}
		}

		/// <summary>
		/// System.String _toString
		/// </summary>
		protected RField r__toString;
		public virtual RField R_toString
		{
			get
			{
				if(r__toString == null)
				{
					r__toString = new(this, "_toString");
					r__toString.SetBelong(this.instance);
				}
				return r__toString;
			}
		}

		/// <summary>
		/// System.Int32 _hashCode
		/// </summary>
		protected RField r__hashCode;
		public virtual RField R_hashCode
		{
			get
			{
				if(r__hashCode == null)
				{
					r__hashCode = new(this, "_hashCode");
					r__hashCode.SetBelong(this.instance);
				}
				return r__hashCode;
			}
		}

		/// <summary>
		/// System.Int32 NumberOfLabels
		/// </summary>
		protected static RField r_NumberOfLabels;
		public static RField RNumberOfLabels
		{
			get
			{
				if(r_NumberOfLabels == null)
				{
					r_NumberOfLabels = new(typeof(System.Net.IPAddress), "NumberOfLabels");
					r_NumberOfLabels.SetBelong(null);
				}
				return r_NumberOfLabels;
			}
		}

		/// <summary>
		/// Boolean IsIPv4
		/// </summary>
		protected RProperty r_IsIPv4;
		public virtual RProperty RIsIPv4
		{
			get
			{
				if(r_IsIPv4 == null)
				{
					r_IsIPv4 = new(this, "IsIPv4", -1);
					r_IsIPv4.SetBelong(this.instance);
				}
				return r_IsIPv4;
			}
		}

		/// <summary>
		/// Boolean IsIPv6
		/// </summary>
		protected RProperty r_IsIPv6;
		public virtual RProperty RIsIPv6
		{
			get
			{
				if(r_IsIPv6 == null)
				{
					r_IsIPv6 = new(this, "IsIPv6", -1);
					r_IsIPv6.SetBelong(this.instance);
				}
				return r_IsIPv6;
			}
		}

		/// <summary>
		/// UInt32 PrivateAddress
		/// </summary>
		protected RProperty r_PrivateAddress;
		public virtual RProperty RPrivateAddress
		{
			get
			{
				if(r_PrivateAddress == null)
				{
					r_PrivateAddress = new(this, "PrivateAddress", -1);
					r_PrivateAddress.SetBelong(this.instance);
				}
				return r_PrivateAddress;
			}
		}

		/// <summary>
		/// UInt32 PrivateScopeId
		/// </summary>
		protected RProperty r_PrivateScopeId;
		public virtual RProperty RPrivateScopeId
		{
			get
			{
				if(r_PrivateScopeId == null)
				{
					r_PrivateScopeId = new(this, "PrivateScopeId", -1);
					r_PrivateScopeId.SetBelong(this.instance);
				}
				return r_PrivateScopeId;
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
		/// Int64 ScopeId
		/// </summary>
		protected RProperty r_ScopeId;
		public virtual RProperty RScopeId
		{
			get
			{
				if(r_ScopeId == null)
				{
					r_ScopeId = new(this, "ScopeId", -1);
					r_ScopeId.SetBelong(this.instance);
				}
				return r_ScopeId;
			}
		}

		/// <summary>
		/// Boolean IsIPv6Multicast
		/// </summary>
		protected RProperty r_IsIPv6Multicast;
		public virtual RProperty RIsIPv6Multicast
		{
			get
			{
				if(r_IsIPv6Multicast == null)
				{
					r_IsIPv6Multicast = new(this, "IsIPv6Multicast", -1);
					r_IsIPv6Multicast.SetBelong(this.instance);
				}
				return r_IsIPv6Multicast;
			}
		}

		/// <summary>
		/// Boolean IsIPv6LinkLocal
		/// </summary>
		protected RProperty r_IsIPv6LinkLocal;
		public virtual RProperty RIsIPv6LinkLocal
		{
			get
			{
				if(r_IsIPv6LinkLocal == null)
				{
					r_IsIPv6LinkLocal = new(this, "IsIPv6LinkLocal", -1);
					r_IsIPv6LinkLocal.SetBelong(this.instance);
				}
				return r_IsIPv6LinkLocal;
			}
		}

		/// <summary>
		/// Boolean IsIPv6SiteLocal
		/// </summary>
		protected RProperty r_IsIPv6SiteLocal;
		public virtual RProperty RIsIPv6SiteLocal
		{
			get
			{
				if(r_IsIPv6SiteLocal == null)
				{
					r_IsIPv6SiteLocal = new(this, "IsIPv6SiteLocal", -1);
					r_IsIPv6SiteLocal.SetBelong(this.instance);
				}
				return r_IsIPv6SiteLocal;
			}
		}

		/// <summary>
		/// Boolean IsIPv6Teredo
		/// </summary>
		protected RProperty r_IsIPv6Teredo;
		public virtual RProperty RIsIPv6Teredo
		{
			get
			{
				if(r_IsIPv6Teredo == null)
				{
					r_IsIPv6Teredo = new(this, "IsIPv6Teredo", -1);
					r_IsIPv6Teredo.SetBelong(this.instance);
				}
				return r_IsIPv6Teredo;
			}
		}

		/// <summary>
		/// Boolean IsIPv4MappedToIPv6
		/// </summary>
		protected RProperty r_IsIPv4MappedToIPv6;
		public virtual RProperty RIsIPv4MappedToIPv6
		{
			get
			{
				if(r_IsIPv4MappedToIPv6 == null)
				{
					r_IsIPv4MappedToIPv6 = new(this, "IsIPv4MappedToIPv6", -1);
					r_IsIPv4MappedToIPv6.SetBelong(this.instance);
				}
				return r_IsIPv4MappedToIPv6;
			}
		}

		/// <summary>
		/// Int64 Address
		/// </summary>
		protected RProperty r_Address;
		public virtual RProperty RAddress
		{
			get
			{
				if(r_Address == null)
				{
					r_Address = new(this, "Address", -1);
					r_Address.SetBelong(this.instance);
				}
				return r_Address;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.String, System.Net.IPAddress ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_String_Out_IPAddress;
		public static RMethod RTryParse_String_Out_IPAddress
		{
			get
			{
				if(r_RTryParse_String_Out_IPAddress == null)
				{
					r_RTryParse_String_Out_IPAddress = new(typeof(System.Net.IPAddress), "TryParse", 0, typeof(System.String), typeof(System.Net.IPAddress).MakeByRefType());
					r_RTryParse_String_Out_IPAddress.SetBelong(null);
				}
				return r_RTryParse_String_Out_IPAddress;
			}
		}

		/// <summary>
		/// Boolean TryParse(System.ReadOnlySpan`1[System.Char], System.Net.IPAddress ByRef)
		/// </summary>
		protected static RMethod r_RTryParse_ReadOnlySpan_d_Char_p__Out_IPAddress;
		public static RMethod RTryParse_ReadOnlySpan_d_Char_p__Out_IPAddress
		{
			get
			{
				if(r_RTryParse_ReadOnlySpan_d_Char_p__Out_IPAddress == null)
				{
					r_RTryParse_ReadOnlySpan_d_Char_p__Out_IPAddress = new(typeof(System.Net.IPAddress), "TryParse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Net.IPAddress).MakeByRefType());
					r_RTryParse_ReadOnlySpan_d_Char_p__Out_IPAddress.SetBelong(null);
				}
				return r_RTryParse_ReadOnlySpan_d_Char_p__Out_IPAddress;
			}
		}

		/// <summary>
		/// System.Net.IPAddress Parse(System.String)
		/// </summary>
		protected static RMethod r_RParse_String;
		public static RMethod RParse_String
		{
			get
			{
				if(r_RParse_String == null)
				{
					r_RParse_String = new(typeof(System.Net.IPAddress), "Parse", 0, typeof(System.String));
					r_RParse_String.SetBelong(null);
				}
				return r_RParse_String;
			}
		}

		/// <summary>
		/// System.Net.IPAddress Parse(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected static RMethod r_RParse_ReadOnlySpan_d_Char_p_;
		public static RMethod RParse_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RParse_ReadOnlySpan_d_Char_p_ == null)
				{
					r_RParse_ReadOnlySpan_d_Char_p_ = new(typeof(System.Net.IPAddress), "Parse", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RParse_ReadOnlySpan_d_Char_p_.SetBelong(null);
				}
				return r_RParse_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Boolean TryWriteBytes(System.Span`1[System.Byte], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryWriteBytes_Span_d_Byte_p__Out_Int32;
		public virtual RMethod RTryWriteBytes_Span_d_Byte_p__Out_Int32
		{
			get
			{
				if(r_RTryWriteBytes_Span_d_Byte_p__Out_Int32 == null)
				{
					r_RTryWriteBytes_Span_d_Byte_p__Out_Int32 = new(this, "TryWriteBytes", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)), typeof(System.Int32).MakeByRefType());
					r_RTryWriteBytes_Span_d_Byte_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryWriteBytes_Span_d_Byte_p__Out_Int32;
			}
		}

		/// <summary>
		/// Void WriteIPv6Bytes(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_RWriteIPv6Bytes_Span_d_Byte_p_;
		public virtual RMethod RWriteIPv6Bytes_Span_d_Byte_p_
		{
			get
			{
				if(r_RWriteIPv6Bytes_Span_d_Byte_p_ == null)
				{
					r_RWriteIPv6Bytes_Span_d_Byte_p_ = new(this, "WriteIPv6Bytes", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_RWriteIPv6Bytes_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RWriteIPv6Bytes_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Void WriteIPv4Bytes(System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_RWriteIPv4Bytes_Span_d_Byte_p_;
		public virtual RMethod RWriteIPv4Bytes_Span_d_Byte_p_
		{
			get
			{
				if(r_RWriteIPv4Bytes_Span_d_Byte_p_ == null)
				{
					r_RWriteIPv4Bytes_Span_d_Byte_p_ = new(this, "WriteIPv4Bytes", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_RWriteIPv4Bytes_Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RWriteIPv4Bytes_Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Byte[] GetAddressBytes()
		/// </summary>
		protected RMethod r_RGetAddressBytes;
		public virtual RMethod RGetAddressBytes
		{
			get
			{
				if(r_RGetAddressBytes == null)
				{
					r_RGetAddressBytes = new(this, "GetAddressBytes", 0);
					r_RGetAddressBytes.SetBelong(this.instance);
				}
				return r_RGetAddressBytes;
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

		/// <summary>
		/// Boolean TryFormat(System.Span`1[System.Char], Int32 ByRef)
		/// </summary>
		protected RMethod r_RTryFormat_Span_d_Char_p__Out_Int32;
		public virtual RMethod RTryFormat_Span_d_Char_p__Out_Int32
		{
			get
			{
				if(r_RTryFormat_Span_d_Char_p__Out_Int32 == null)
				{
					r_RTryFormat_Span_d_Char_p__Out_Int32 = new(this, "TryFormat", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Int32).MakeByRefType());
					r_RTryFormat_Span_d_Char_p__Out_Int32.SetBelong(this.instance);
				}
				return r_RTryFormat_Span_d_Char_p__Out_Int32;
			}
		}

		/// <summary>
		/// Int64 HostToNetworkOrder(Int64)
		/// </summary>
		protected static RMethod r_RHostToNetworkOrder_Int64;
		public static RMethod RHostToNetworkOrder_Int64
		{
			get
			{
				if(r_RHostToNetworkOrder_Int64 == null)
				{
					r_RHostToNetworkOrder_Int64 = new(typeof(System.Net.IPAddress), "HostToNetworkOrder", 0, typeof(System.Int64));
					r_RHostToNetworkOrder_Int64.SetBelong(null);
				}
				return r_RHostToNetworkOrder_Int64;
			}
		}

		/// <summary>
		/// Int32 HostToNetworkOrder(Int32)
		/// </summary>
		protected static RMethod r_RHostToNetworkOrder_Int32;
		public static RMethod RHostToNetworkOrder_Int32
		{
			get
			{
				if(r_RHostToNetworkOrder_Int32 == null)
				{
					r_RHostToNetworkOrder_Int32 = new(typeof(System.Net.IPAddress), "HostToNetworkOrder", 0, typeof(System.Int32));
					r_RHostToNetworkOrder_Int32.SetBelong(null);
				}
				return r_RHostToNetworkOrder_Int32;
			}
		}

		/// <summary>
		/// Int16 HostToNetworkOrder(Int16)
		/// </summary>
		protected static RMethod r_RHostToNetworkOrder_Int16;
		public static RMethod RHostToNetworkOrder_Int16
		{
			get
			{
				if(r_RHostToNetworkOrder_Int16 == null)
				{
					r_RHostToNetworkOrder_Int16 = new(typeof(System.Net.IPAddress), "HostToNetworkOrder", 0, typeof(System.Int16));
					r_RHostToNetworkOrder_Int16.SetBelong(null);
				}
				return r_RHostToNetworkOrder_Int16;
			}
		}

		/// <summary>
		/// Int64 NetworkToHostOrder(Int64)
		/// </summary>
		protected static RMethod r_RNetworkToHostOrder_Int64;
		public static RMethod RNetworkToHostOrder_Int64
		{
			get
			{
				if(r_RNetworkToHostOrder_Int64 == null)
				{
					r_RNetworkToHostOrder_Int64 = new(typeof(System.Net.IPAddress), "NetworkToHostOrder", 0, typeof(System.Int64));
					r_RNetworkToHostOrder_Int64.SetBelong(null);
				}
				return r_RNetworkToHostOrder_Int64;
			}
		}

		/// <summary>
		/// Int32 NetworkToHostOrder(Int32)
		/// </summary>
		protected static RMethod r_RNetworkToHostOrder_Int32;
		public static RMethod RNetworkToHostOrder_Int32
		{
			get
			{
				if(r_RNetworkToHostOrder_Int32 == null)
				{
					r_RNetworkToHostOrder_Int32 = new(typeof(System.Net.IPAddress), "NetworkToHostOrder", 0, typeof(System.Int32));
					r_RNetworkToHostOrder_Int32.SetBelong(null);
				}
				return r_RNetworkToHostOrder_Int32;
			}
		}

		/// <summary>
		/// Int16 NetworkToHostOrder(Int16)
		/// </summary>
		protected static RMethod r_RNetworkToHostOrder_Int16;
		public static RMethod RNetworkToHostOrder_Int16
		{
			get
			{
				if(r_RNetworkToHostOrder_Int16 == null)
				{
					r_RNetworkToHostOrder_Int16 = new(typeof(System.Net.IPAddress), "NetworkToHostOrder", 0, typeof(System.Int16));
					r_RNetworkToHostOrder_Int16.SetBelong(null);
				}
				return r_RNetworkToHostOrder_Int16;
			}
		}

		/// <summary>
		/// Boolean IsLoopback(System.Net.IPAddress)
		/// </summary>
		protected static RMethod r_RIsLoopback_IPAddress;
		public static RMethod RIsLoopback_IPAddress
		{
			get
			{
				if(r_RIsLoopback_IPAddress == null)
				{
					r_RIsLoopback_IPAddress = new(typeof(System.Net.IPAddress), "IsLoopback", 0, typeof(System.Net.IPAddress));
					r_RIsLoopback_IPAddress.SetBelong(null);
				}
				return r_RIsLoopback_IPAddress;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Object, Boolean)
		/// </summary>
		protected RMethod r_REquals_Object_Boolean;
		public virtual RMethod REquals_Object_Boolean
		{
			get
			{
				if(r_REquals_Object_Boolean == null)
				{
					r_REquals_Object_Boolean = new(this, "Equals", 0, typeof(System.Object), typeof(System.Boolean));
					r_REquals_Object_Boolean.SetBelong(this.instance);
				}
				return r_REquals_Object_Boolean;
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
		/// System.Net.IPAddress MapToIPv6()
		/// </summary>
		protected RMethod r_RMapToIPv6;
		public virtual RMethod RMapToIPv6
		{
			get
			{
				if(r_RMapToIPv6 == null)
				{
					r_RMapToIPv6 = new(this, "MapToIPv6", 0);
					r_RMapToIPv6.SetBelong(this.instance);
				}
				return r_RMapToIPv6;
			}
		}

		/// <summary>
		/// System.Net.IPAddress MapToIPv4()
		/// </summary>
		protected RMethod r_RMapToIPv4;
		public virtual RMethod RMapToIPv4
		{
			get
			{
				if(r_RMapToIPv4 == null)
				{
					r_RMapToIPv4 = new(this, "MapToIPv4", 0);
					r_RMapToIPv4.SetBelong(this.instance);
				}
				return r_RMapToIPv4;
			}
		}

		/// <summary>
		/// Byte[] ThrowAddressNullException()
		/// </summary>
		protected static RMethod r_RThrowAddressNullException;
		public static RMethod RThrowAddressNullException
		{
			get
			{
				if(r_RThrowAddressNullException == null)
				{
					r_RThrowAddressNullException = new(typeof(System.Net.IPAddress), "ThrowAddressNullException", 0);
					r_RThrowAddressNullException.SetBelong(null);
				}
				return r_RThrowAddressNullException;
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


        public RIPAddress() : base("System.Net.IPAddress")
        {
        }

        public RIPAddress(System.Object instance) : base("System.Net.IPAddress")
		{
            SetInstance(instance);
		}

        public RIPAddress(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPAddress(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean TryParse(System.String  @ipString, out System.Net.IPAddress  @address)
        {
			address = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ipString, @address};
            var ___result = RTryParse_String_Out_IPAddress.Invoke(___genericsType, ___parameters);
			address = (System.Net.IPAddress)___parameters[1];

            return (System.Boolean)___result;
        }



        public static System.Net.IPAddress Parse(System.String  @ipString)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ipString};
            var ___result = RParse_String.Invoke(___genericsType, ___parameters);

            return (System.Net.IPAddress)___result;
        }






        public virtual System.Byte[] GetAddressBytes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAddressBytes.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public static System.Int64 HostToNetworkOrder(System.Int64  @host)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host};
            var ___result = RHostToNetworkOrder_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Int32 HostToNetworkOrder(System.Int32  @host)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host};
            var ___result = RHostToNetworkOrder_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int16 HostToNetworkOrder(System.Int16  @host)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host};
            var ___result = RHostToNetworkOrder_Int16.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public static System.Int64 NetworkToHostOrder(System.Int64  @network)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@network};
            var ___result = RNetworkToHostOrder_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public static System.Int32 NetworkToHostOrder(System.Int32  @network)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@network};
            var ___result = RNetworkToHostOrder_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int16 NetworkToHostOrder(System.Int16  @network)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@network};
            var ___result = RNetworkToHostOrder_Int16.Invoke(___genericsType, ___parameters);

            return (System.Int16)___result;
        }


        public static System.Boolean IsLoopback(System.Net.IPAddress  @address)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@address};
            var ___result = RIsLoopback_IPAddress.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @comparandObj, System.Boolean  @compareScopeId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparandObj, @compareScopeId};
            var ___result = REquals_Object_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @comparand)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comparand};
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


        public virtual System.Net.IPAddress MapToIPv6()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMapToIPv6.Invoke(___genericsType, ___parameters);

            return (System.Net.IPAddress)___result;
        }


        public virtual System.Net.IPAddress MapToIPv4()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMapToIPv4.Invoke(___genericsType, ___parameters);

            return (System.Net.IPAddress)___result;
        }


        public static System.Byte[] ThrowAddressNullException()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowAddressNullException.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
