using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.IPPacketInformation
	/// </summary>
    public partial class RIPPacketInformation : RMember //
    {

		/// <summary>
		/// System.Net.IPAddress address
		/// </summary>
		protected RSystem.RNet.RIPAddress r_address;
		public virtual RSystem.RNet.RIPAddress Raddress
		{
			get
			{
				if(r_address == null)
				{
					r_address = new(this, "address");
					r_address.SetBelong(this.instance);
				}
				return r_address;
			}
		}

		/// <summary>
		/// System.Int32 networkInterface
		/// </summary>
		protected RField r_networkInterface;
		public virtual RField RnetworkInterface
		{
			get
			{
				if(r_networkInterface == null)
				{
					r_networkInterface = new(this, "networkInterface");
					r_networkInterface.SetBelong(this.instance);
				}
				return r_networkInterface;
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
		/// Int32 Interface
		/// </summary>
		protected RProperty r_Interface;
		public virtual RProperty RInterface
		{
			get
			{
				if(r_Interface == null)
				{
					r_Interface = new(this, "Interface", -1);
					r_Interface.SetBelong(this.instance);
				}
				return r_Interface;
			}
		}

		/// <summary>
		/// Boolean op_Equality(System.Net.Sockets.IPPacketInformation, System.Net.Sockets.IPPacketInformation)
		/// </summary>
		protected static RMethod r_Rop_Equality_IPPacketInformation_IPPacketInformation;
		public static RMethod Rop_Equality_IPPacketInformation_IPPacketInformation
		{
			get
			{
				if(r_Rop_Equality_IPPacketInformation_IPPacketInformation == null)
				{
					r_Rop_Equality_IPPacketInformation_IPPacketInformation = new(typeof(System.Net.Sockets.IPPacketInformation), "op_Equality", 0, typeof(System.Net.Sockets.IPPacketInformation), typeof(System.Net.Sockets.IPPacketInformation));
					r_Rop_Equality_IPPacketInformation_IPPacketInformation.SetBelong(null);
				}
				return r_Rop_Equality_IPPacketInformation_IPPacketInformation;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Net.Sockets.IPPacketInformation, System.Net.Sockets.IPPacketInformation)
		/// </summary>
		protected static RMethod r_Rop_Inequality_IPPacketInformation_IPPacketInformation;
		public static RMethod Rop_Inequality_IPPacketInformation_IPPacketInformation
		{
			get
			{
				if(r_Rop_Inequality_IPPacketInformation_IPPacketInformation == null)
				{
					r_Rop_Inequality_IPPacketInformation_IPPacketInformation = new(typeof(System.Net.Sockets.IPPacketInformation), "op_Inequality", 0, typeof(System.Net.Sockets.IPPacketInformation), typeof(System.Net.Sockets.IPPacketInformation));
					r_Rop_Inequality_IPPacketInformation_IPPacketInformation.SetBelong(null);
				}
				return r_Rop_Inequality_IPPacketInformation_IPPacketInformation;
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


        public RIPPacketInformation() : base("System.Net.Sockets.IPPacketInformation")
        {
        }

        public RIPPacketInformation(System.Object instance) : base("System.Net.Sockets.IPPacketInformation")
		{
            SetInstance(instance);
		}

        public RIPPacketInformation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIPPacketInformation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean op_Equality(System.Net.Sockets.IPPacketInformation  @packetInformation1, System.Net.Sockets.IPPacketInformation  @packetInformation2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packetInformation1, @packetInformation2};
            var ___result = Rop_Equality_IPPacketInformation_IPPacketInformation.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Net.Sockets.IPPacketInformation  @packetInformation1, System.Net.Sockets.IPPacketInformation  @packetInformation2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@packetInformation1, @packetInformation2};
            var ___result = Rop_Inequality_IPPacketInformation_IPPacketInformation.Invoke(___genericsType, ___parameters);

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
