using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet.RSockets
{
	/// <summary>
	/// System.Net.Sockets.SocketInformation
	/// </summary>
    public partial class RSocketInformation : RMember //
    {

		/// <summary>
		/// System.Byte[] protocolInformation
		/// </summary>
		protected RFieldArray<RField> r_protocolInformation;
		public virtual RFieldArray<RField> RprotocolInformation
		{
			get
			{
				if(r_protocolInformation == null)
				{
					r_protocolInformation = new(this, "protocolInformation");
					r_protocolInformation.SetBelong(this.instance);
				}
				return r_protocolInformation;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketInformationOptions options
		/// </summary>
		protected RField r_options;
		public virtual RField Roptions
		{
			get
			{
				if(r_options == null)
				{
					r_options = new(this, "options");
					r_options.SetBelong(this.instance);
				}
				return r_options;
			}
		}

		/// <summary>
		/// System.Net.EndPoint remoteEndPoint
		/// </summary>
		protected RSystem.RNet.REndPoint r_remoteEndPoint;
		public virtual RSystem.RNet.REndPoint RremoteEndPoint
		{
			get
			{
				if(r_remoteEndPoint == null)
				{
					r_remoteEndPoint = new(this, "remoteEndPoint");
					r_remoteEndPoint.SetBelong(this.instance);
				}
				return r_remoteEndPoint;
			}
		}

		/// <summary>
		/// Byte[] ProtocolInformation
		/// </summary>
		protected RPropertyArray<RProperty> r_ProtocolInformation;
		public virtual RPropertyArray<RProperty> RProtocolInformation
		{
			get
			{
				if(r_ProtocolInformation == null)
				{
					r_ProtocolInformation = new(this, "ProtocolInformation", -1);
					r_ProtocolInformation.SetBelong(this.instance);
				}
				return r_ProtocolInformation;
			}
		}

		/// <summary>
		/// System.Net.Sockets.SocketInformationOptions Options
		/// </summary>
		protected RProperty r_Options;
		public virtual RProperty ROptions
		{
			get
			{
				if(r_Options == null)
				{
					r_Options = new(this, "Options", -1);
					r_Options.SetBelong(this.instance);
				}
				return r_Options;
			}
		}

		/// <summary>
		/// Boolean IsNonBlocking
		/// </summary>
		protected RProperty r_IsNonBlocking;
		public virtual RProperty RIsNonBlocking
		{
			get
			{
				if(r_IsNonBlocking == null)
				{
					r_IsNonBlocking = new(this, "IsNonBlocking", -1);
					r_IsNonBlocking.SetBelong(this.instance);
				}
				return r_IsNonBlocking;
			}
		}

		/// <summary>
		/// Boolean IsConnected
		/// </summary>
		protected RProperty r_IsConnected;
		public virtual RProperty RIsConnected
		{
			get
			{
				if(r_IsConnected == null)
				{
					r_IsConnected = new(this, "IsConnected", -1);
					r_IsConnected.SetBelong(this.instance);
				}
				return r_IsConnected;
			}
		}

		/// <summary>
		/// Boolean IsListening
		/// </summary>
		protected RProperty r_IsListening;
		public virtual RProperty RIsListening
		{
			get
			{
				if(r_IsListening == null)
				{
					r_IsListening = new(this, "IsListening", -1);
					r_IsListening.SetBelong(this.instance);
				}
				return r_IsListening;
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


        public RSocketInformation() : base("System.Net.Sockets.SocketInformation")
        {
        }

        public RSocketInformation(System.Object instance) : base("System.Net.Sockets.SocketInformation")
		{
            SetInstance(instance);
		}

        public RSocketInformation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSocketInformation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
