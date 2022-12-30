using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine.RNetworking
{
	/// <summary>
	/// UnityEngine.Networking.CertificateHandler
	/// </summary>
    public partial class RCertificateHandler : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
			}
		}

		/// <summary>
		/// IntPtr Create(UnityEngine.Networking.CertificateHandler)
		/// </summary>
		protected static RMethod r_RCreate_CertificateHandler;
		public static RMethod RCreate_CertificateHandler
		{
			get
			{
				if(r_RCreate_CertificateHandler == null)
				{
					r_RCreate_CertificateHandler = new(typeof(UnityEngine.Networking.CertificateHandler), "Create", 0, typeof(UnityEngine.Networking.CertificateHandler));
					r_RCreate_CertificateHandler.SetBelong(null);
				}
				return r_RCreate_CertificateHandler;
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
		/// Boolean ValidateCertificate(Byte[])
		/// </summary>
		protected RMethod r_RValidateCertificate_ByteArray;
		public virtual RMethod RValidateCertificate_ByteArray
		{
			get
			{
				if(r_RValidateCertificate_ByteArray == null)
				{
					r_RValidateCertificate_ByteArray = new(this, "ValidateCertificate", 0, typeof(System.Byte).MakeArrayType());
					r_RValidateCertificate_ByteArray.SetBelong(this.instance);
				}
				return r_RValidateCertificate_ByteArray;
			}
		}

		/// <summary>
		/// Boolean ValidateCertificateNative(Byte[])
		/// </summary>
		protected RMethod r_RValidateCertificateNative_ByteArray;
		public virtual RMethod RValidateCertificateNative_ByteArray
		{
			get
			{
				if(r_RValidateCertificateNative_ByteArray == null)
				{
					r_RValidateCertificateNative_ByteArray = new(this, "ValidateCertificateNative", 0, typeof(System.Byte).MakeArrayType());
					r_RValidateCertificateNative_ByteArray.SetBelong(this.instance);
				}
				return r_RValidateCertificateNative_ByteArray;
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


        public RCertificateHandler() : base("UnityEngine.Networking.CertificateHandler")
        {
        }

        public RCertificateHandler(System.Object instance) : base("UnityEngine.Networking.CertificateHandler")
		{
            SetInstance(instance);
		}

        public RCertificateHandler(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCertificateHandler(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.IntPtr Create(UnityEngine.Networking.CertificateHandler  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RCreate_CertificateHandler.Invoke(___genericsType, ___parameters);

            return (System.IntPtr)___result;
        }


        public virtual void Release()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRelease.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ValidateCertificate(System.Byte[]  @certificateData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@certificateData};
            var ___result = RValidateCertificate_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateCertificateNative(System.Byte[]  @certificateData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@certificateData};
            var ___result = RValidateCertificateNative_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
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
