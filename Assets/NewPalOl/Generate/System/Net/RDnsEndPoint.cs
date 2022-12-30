using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet
{
	/// <summary>
	/// System.Net.DnsEndPoint
	/// </summary>
    public partial class RDnsEndPoint : RMember //
    {

		/// <summary>
		/// System.String m_Host
		/// </summary>
		protected RField r_m_Host;
		public virtual RField Rm_Host
		{
			get
			{
				if(r_m_Host == null)
				{
					r_m_Host = new(this, "m_Host");
					r_m_Host.SetBelong(this.instance);
				}
				return r_m_Host;
			}
		}

		/// <summary>
		/// System.Int32 m_Port
		/// </summary>
		protected RField r_m_Port;
		public virtual RField Rm_Port
		{
			get
			{
				if(r_m_Port == null)
				{
					r_m_Port = new(this, "m_Port");
					r_m_Port.SetBelong(this.instance);
				}
				return r_m_Port;
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
		/// System.String Host
		/// </summary>
		protected RProperty r_Host;
		public virtual RProperty RHost
		{
			get
			{
				if(r_Host == null)
				{
					r_Host = new(this, "Host", -1);
					r_Host.SetBelong(this.instance);
				}
				return r_Host;
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


        public RDnsEndPoint() : base("System.Net.DnsEndPoint")
        {
        }

        public RDnsEndPoint(System.Object instance) : base("System.Net.DnsEndPoint")
		{
            SetInstance(instance);
		}

        public RDnsEndPoint(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDnsEndPoint(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
