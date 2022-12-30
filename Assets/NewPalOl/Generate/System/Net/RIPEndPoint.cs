using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet
{
	/// <summary>
	/// System.Net.IPEndPoint
	/// </summary>
    public partial class RIPEndPoint : RMember //
    {

		/// <summary>
		/// System.Int32 MinPort
		/// </summary>
		protected static RField r_MinPort;
		public static RField RMinPort
		{
			get
			{
				if(r_MinPort == null)
				{
					r_MinPort = new(typeof(System.Net.IPEndPoint), "MinPort");
					r_MinPort.SetBelong(null);
				}
				return r_MinPort;
			}
		}

		/// <summary>
		/// System.Int32 MaxPort
		/// </summary>
		protected static RField r_MaxPort;
		public static RField RMaxPort
		{
			get
			{
				if(r_MaxPort == null)
				{
					r_MaxPort = new(typeof(System.Net.IPEndPoint), "MaxPort");
					r_MaxPort.SetBelong(null);
				}
				return r_MaxPort;
			}
		}

		/// <summary>
		/// System.Net.IPAddress _address
		/// </summary>
		protected RSystem.RNet.RIPAddress r__address;
		public virtual RSystem.RNet.RIPAddress R_address
		{
			get
			{
				if(r__address == null)
				{
					r__address = new(this, "_address");
					r__address.SetBelong(this.instance);
				}
				return r__address;
			}
		}

		/// <summary>
		/// System.Int32 _port
		/// </summary>
		protected RField r__port;
		public virtual RField R_port
		{
			get
			{
				if(r__port == null)
				{
					r__port = new(this, "_port");
					r__port.SetBelong(this.instance);
				}
				return r__port;
			}
		}

		/// <summary>
		/// System.Int32 AnyPort
		/// </summary>
		protected static RField r_AnyPort;
		public static RField RAnyPort
		{
			get
			{
				if(r_AnyPort == null)
				{
					r_AnyPort = new(typeof(System.Net.IPEndPoint), "AnyPort");
					r_AnyPort.SetBelong(null);
				}
				return r_AnyPort;
			}
		}

		/// <summary>
		/// System.Net.IPEndPoint Any
		/// </summary>
		protected static RSystem.RNet.RIPEndPoint r_Any;
		public static RSystem.RNet.RIPEndPoint RAny
		{
			get
			{
				if(r_Any == null)
				{
					r_Any = new(typeof(System.Net.IPEndPoint), "Any");
					r_Any.SetBelong(null);
				}
				return r_Any;
			}
		}

		/// <summary>
		/// System.Net.IPEndPoint IPv6Any
		/// </summary>
		protected static RSystem.RNet.RIPEndPoint r_IPv6Any;
		public static RSystem.RNet.RIPEndPoint RIPv6Any
		{
			get
			{
				if(r_IPv6Any == null)
				{
					r_IPv6Any = new(typeof(System.Net.IPEndPoint), "IPv6Any");
					r_IPv6Any.SetBelong(null);
				}
				return r_IPv6Any;
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
		/// System.Net.IPAddress Address
		/// </summary>
		protected RSystem.RNet.RIPAddress r_Address;
		public virtual RSystem.RNet.RIPAddress RAddress
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
		/// Int32 Port
		/// </summary>
		protected RProperty r_Port;
		public virtual RProperty RPort
		{
			get
			{
				if(r_Port == null)
				{
					r_Port = new(this, "Port", -1);
					r_Port.SetBelong(this.instance);
				}
				return r_Port;
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
		/// System.Net.SocketAddress Serialize()
		/// </summary>
		protected RMethod r_RSerialize;
		public virtual RMethod RSerialize
		{
			get
			{
				if(r_RSerialize == null)
				{
					r_RSerialize = new(this, "Serialize", 0);
					r_RSerialize.SetBelong(this.instance);
				}
				return r_RSerialize;
			}
		}

		/// <summary>
		/// System.Net.EndPoint Create(System.Net.SocketAddress)
		/// </summary>
		protected RMethod r_RCreate_SocketAddress;
		public virtual RMethod RCreate_SocketAddress
		{
			get
			{
				if(r_RCreate_SocketAddress == null)
				{
					r_RCreate_SocketAddress = new(this, "Create", 0, typeof(System.Net.SocketAddress));
					r_RCreate_SocketAddress.SetBelong(this.instance);
				}
				return r_RCreate_SocketAddress;
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


        public RIPEndPoint() : base("System.Net.IPEndPoint")
        {
        }

        public RIPEndPoint(System.Object instance) : base("System.Net.IPEndPoint")
		{
            SetInstance(instance);
		}

        public RIPEndPoint(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPEndPoint(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Net.SocketAddress Serialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSerialize.Invoke(___genericsType, ___parameters);

            return (System.Net.SocketAddress)___result;
        }


        public virtual System.Net.EndPoint Create(System.Net.SocketAddress  @socketAddress)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@socketAddress};
            var ___result = RCreate_SocketAddress.Invoke(___genericsType, ___parameters);

            return (System.Net.EndPoint)___result;
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
