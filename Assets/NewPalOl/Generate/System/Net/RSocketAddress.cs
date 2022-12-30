using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet
{
	/// <summary>
	/// System.Net.SocketAddress
	/// </summary>
    public partial class RSocketAddress : RMember //
    {

		/// <summary>
		/// System.Int32 IPv6AddressSize
		/// </summary>
		protected static RField r_IPv6AddressSize;
		public static RField RIPv6AddressSize
		{
			get
			{
				if(r_IPv6AddressSize == null)
				{
					r_IPv6AddressSize = new(typeof(System.Net.SocketAddress), "IPv6AddressSize");
					r_IPv6AddressSize.SetBelong(null);
				}
				return r_IPv6AddressSize;
			}
		}

		/// <summary>
		/// System.Int32 IPv4AddressSize
		/// </summary>
		protected static RField r_IPv4AddressSize;
		public static RField RIPv4AddressSize
		{
			get
			{
				if(r_IPv4AddressSize == null)
				{
					r_IPv4AddressSize = new(typeof(System.Net.SocketAddress), "IPv4AddressSize");
					r_IPv4AddressSize.SetBelong(null);
				}
				return r_IPv4AddressSize;
			}
		}

		/// <summary>
		/// System.Int32 m_Size
		/// </summary>
		protected RField r_m_Size;
		public virtual RField Rm_Size
		{
			get
			{
				if(r_m_Size == null)
				{
					r_m_Size = new(this, "m_Size");
					r_m_Size.SetBelong(this.instance);
				}
				return r_m_Size;
			}
		}

		/// <summary>
		/// System.Byte[] m_Buffer
		/// </summary>
		protected RFieldArray<RField> r_m_Buffer;
		public virtual RFieldArray<RField> Rm_Buffer
		{
			get
			{
				if(r_m_Buffer == null)
				{
					r_m_Buffer = new(this, "m_Buffer");
					r_m_Buffer.SetBelong(this.instance);
				}
				return r_m_Buffer;
			}
		}

		/// <summary>
		/// System.Int32 WriteableOffset
		/// </summary>
		protected static RField r_WriteableOffset;
		public static RField RWriteableOffset
		{
			get
			{
				if(r_WriteableOffset == null)
				{
					r_WriteableOffset = new(typeof(System.Net.SocketAddress), "WriteableOffset");
					r_WriteableOffset.SetBelong(null);
				}
				return r_WriteableOffset;
			}
		}

		/// <summary>
		/// System.Int32 MaxSize
		/// </summary>
		protected static RField r_MaxSize;
		public static RField RMaxSize
		{
			get
			{
				if(r_MaxSize == null)
				{
					r_MaxSize = new(typeof(System.Net.SocketAddress), "MaxSize");
					r_MaxSize.SetBelong(null);
				}
				return r_MaxSize;
			}
		}

		/// <summary>
		/// System.Boolean m_changed
		/// </summary>
		protected RField r_m_changed;
		public virtual RField Rm_changed
		{
			get
			{
				if(r_m_changed == null)
				{
					r_m_changed = new(this, "m_changed");
					r_m_changed.SetBelong(this.instance);
				}
				return r_m_changed;
			}
		}

		/// <summary>
		/// System.Int32 m_hash
		/// </summary>
		protected RField r_m_hash;
		public virtual RField Rm_hash
		{
			get
			{
				if(r_m_hash == null)
				{
					r_m_hash = new(this, "m_hash");
					r_m_hash.SetBelong(this.instance);
				}
				return r_m_hash;
			}
		}

		/// <summary>
		/// System.Net.Sockets.AddressFamily Family
		/// </summary>
		protected RProperty r_Family;
		public virtual RProperty RFamily
		{
			get
			{
				if(r_Family == null)
				{
					r_Family = new(this, "Family", -1);
					r_Family.SetBelong(this.instance);
				}
				return r_Family;
			}
		}

		/// <summary>
		/// Int32 Size
		/// </summary>
		protected RProperty r_Size;
		public virtual RProperty RSize
		{
			get
			{
				if(r_Size == null)
				{
					r_Size = new(this, "Size", -1);
					r_Size.SetBelong(this.instance);
				}
				return r_Size;
			}
		}

		/// <summary>
		/// Byte Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// System.Net.IPAddress GetIPAddress()
		/// </summary>
		protected RMethod r_RGetIPAddress;
		public virtual RMethod RGetIPAddress
		{
			get
			{
				if(r_RGetIPAddress == null)
				{
					r_RGetIPAddress = new(this, "GetIPAddress", 0);
					r_RGetIPAddress.SetBelong(this.instance);
				}
				return r_RGetIPAddress;
			}
		}

		/// <summary>
		/// System.Net.IPEndPoint GetIPEndPoint()
		/// </summary>
		protected RMethod r_RGetIPEndPoint;
		public virtual RMethod RGetIPEndPoint
		{
			get
			{
				if(r_RGetIPEndPoint == null)
				{
					r_RGetIPEndPoint = new(this, "GetIPEndPoint", 0);
					r_RGetIPEndPoint.SetBelong(this.instance);
				}
				return r_RGetIPEndPoint;
			}
		}

		/// <summary>
		/// Void CopyAddressSizeIntoBuffer()
		/// </summary>
		protected RMethod r_RCopyAddressSizeIntoBuffer;
		public virtual RMethod RCopyAddressSizeIntoBuffer
		{
			get
			{
				if(r_RCopyAddressSizeIntoBuffer == null)
				{
					r_RCopyAddressSizeIntoBuffer = new(this, "CopyAddressSizeIntoBuffer", 0);
					r_RCopyAddressSizeIntoBuffer.SetBelong(this.instance);
				}
				return r_RCopyAddressSizeIntoBuffer;
			}
		}

		/// <summary>
		/// Int32 GetAddressSizeOffset()
		/// </summary>
		protected RMethod r_RGetAddressSizeOffset;
		public virtual RMethod RGetAddressSizeOffset
		{
			get
			{
				if(r_RGetAddressSizeOffset == null)
				{
					r_RGetAddressSizeOffset = new(this, "GetAddressSizeOffset", 0);
					r_RGetAddressSizeOffset.SetBelong(this.instance);
				}
				return r_RGetAddressSizeOffset;
			}
		}

		/// <summary>
		/// Void SetSize(IntPtr)
		/// </summary>
		protected RMethod r_RSetSize_IntPtr;
		public virtual RMethod RSetSize_IntPtr
		{
			get
			{
				if(r_RSetSize_IntPtr == null)
				{
					r_RSetSize_IntPtr = new(this, "SetSize", 0, typeof(System.IntPtr));
					r_RSetSize_IntPtr.SetBelong(this.instance);
				}
				return r_RSetSize_IntPtr;
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


        public RSocketAddress() : base("System.Net.SocketAddress")
        {
        }

        public RSocketAddress(System.Object instance) : base("System.Net.SocketAddress")
		{
            SetInstance(instance);
		}

        public RSocketAddress(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSocketAddress(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Net.IPAddress GetIPAddress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIPAddress.Invoke(___genericsType, ___parameters);

            return (System.Net.IPAddress)___result;
        }


        public virtual System.Net.IPEndPoint GetIPEndPoint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetIPEndPoint.Invoke(___genericsType, ___parameters);

            return (System.Net.IPEndPoint)___result;
        }


        public virtual void CopyAddressSizeIntoBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopyAddressSizeIntoBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetAddressSizeOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAddressSizeOffset.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetSize(System.IntPtr  @ptr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ptr};
            var ___result = RSetSize_IntPtr.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
