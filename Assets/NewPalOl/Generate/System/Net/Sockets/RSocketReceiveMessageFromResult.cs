using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.SocketReceiveMessageFromResult
	/// </summary>
    public partial class RSocketReceiveMessageFromResult : RMember //
    {

		/// <summary>
		/// System.Int32 ReceivedBytes
		/// </summary>
		protected RField r_ReceivedBytes;
		public virtual RField ReceivedBytes
		{
			get
			{
				if(r_ReceivedBytes == null)
				{
					r_ReceivedBytes = new(this, "ReceivedBytes");
					r_ReceivedBytes.SetBelong(this.instance);
				}
				return r_ReceivedBytes;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketFlags SocketFlags
		/// </summary>
		protected RField r_SocketFlags;
		public virtual RField RSocketFlags
		{
			get
			{
				if(r_SocketFlags == null)
				{
					r_SocketFlags = new(this, "SocketFlags");
					r_SocketFlags.SetBelong(this.instance);
				}
				return r_SocketFlags;
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
					r_RemoteEndPoint = new(this, "RemoteEndPoint");
					r_RemoteEndPoint.SetBelong(this.instance);
				}
				return r_RemoteEndPoint;
			}
		}

		/// <summary>
		/// System.Net.Sockets.IPPacketInformation PacketInformation
		/// </summary>
		protected RSystem.RNet.RSockets.RIPPacketInformation r_PacketInformation;
		public virtual RSystem.RNet.RSockets.RIPPacketInformation RPacketInformation
		{
			get
			{
				if(r_PacketInformation == null)
				{
					r_PacketInformation = new(this, "PacketInformation");
					r_PacketInformation.SetBelong(this.instance);
				}
				return r_PacketInformation;
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


        public RSocketReceiveMessageFromResult() : base("System.Net.Sockets.SocketReceiveMessageFromResult")
        {
        }

        public RSocketReceiveMessageFromResult(System.Object instance) : base("System.Net.Sockets.SocketReceiveMessageFromResult")
		{
            SetInstance(instance);
		}

        public RSocketReceiveMessageFromResult(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSocketReceiveMessageFromResult(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
