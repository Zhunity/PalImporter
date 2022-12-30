using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RNet
{
	/// <summary>
	/// System.Net.NetworkCredential
	/// </summary>
    public partial class RNetworkCredential : RMember //
    {

		/// <summary>
		/// System.String m_domain
		/// </summary>
		protected RField r_m_domain;
		public virtual RField Rm_domain
		{
			get
			{
				if(r_m_domain == null)
				{
					r_m_domain = new(this, "m_domain");
					r_m_domain.SetBelong(this.instance);
				}
				return r_m_domain;
			}
		}

		/// <summary>
		/// System.String m_userName
		/// </summary>
		protected RField r_m_userName;
		public virtual RField Rm_userName
		{
			get
			{
				if(r_m_userName == null)
				{
					r_m_userName = new(this, "m_userName");
					r_m_userName.SetBelong(this.instance);
				}
				return r_m_userName;
			}
		}

		/// <summary>
		/// System.Security.SecureString m_password
		/// </summary>
		protected RSystem.RSecurity.RSecureString r_m_password;
		public virtual RSystem.RSecurity.RSecureString Rm_password
		{
			get
			{
				if(r_m_password == null)
				{
					r_m_password = new(this, "m_password");
					r_m_password.SetBelong(this.instance);
				}
				return r_m_password;
			}
		}

		/// <summary>
		/// System.String UserName
		/// </summary>
		protected RProperty r_UserName;
		public virtual RProperty RUserName
		{
			get
			{
				if(r_UserName == null)
				{
					r_UserName = new(this, "UserName", -1);
					r_UserName.SetBelong(this.instance);
				}
				return r_UserName;
			}
		}

		/// <summary>
		/// System.String Password
		/// </summary>
		protected RProperty r_Password;
		public virtual RProperty RPassword
		{
			get
			{
				if(r_Password == null)
				{
					r_Password = new(this, "Password", -1);
					r_Password.SetBelong(this.instance);
				}
				return r_Password;
			}
		}

		/// <summary>
		/// System.Security.SecureString SecurePassword
		/// </summary>
		protected RSystem.RSecurity.RSecureString r_SecurePassword;
		public virtual RSystem.RSecurity.RSecureString RSecurePassword
		{
			get
			{
				if(r_SecurePassword == null)
				{
					r_SecurePassword = new(this, "SecurePassword", -1);
					r_SecurePassword.SetBelong(this.instance);
				}
				return r_SecurePassword;
			}
		}

		/// <summary>
		/// System.String Domain
		/// </summary>
		protected RProperty r_Domain;
		public virtual RProperty RDomain
		{
			get
			{
				if(r_Domain == null)
				{
					r_Domain = new(this, "Domain", -1);
					r_Domain.SetBelong(this.instance);
				}
				return r_Domain;
			}
		}

		/// <summary>
		/// System.String InternalGetUserName()
		/// </summary>
		protected RMethod r_RInternalGetUserName;
		public virtual RMethod RInternalGetUserName
		{
			get
			{
				if(r_RInternalGetUserName == null)
				{
					r_RInternalGetUserName = new(this, "InternalGetUserName", 0);
					r_RInternalGetUserName.SetBelong(this.instance);
				}
				return r_RInternalGetUserName;
			}
		}

		/// <summary>
		/// System.String InternalGetPassword()
		/// </summary>
		protected RMethod r_RInternalGetPassword;
		public virtual RMethod RInternalGetPassword
		{
			get
			{
				if(r_RInternalGetPassword == null)
				{
					r_RInternalGetPassword = new(this, "InternalGetPassword", 0);
					r_RInternalGetPassword.SetBelong(this.instance);
				}
				return r_RInternalGetPassword;
			}
		}

		/// <summary>
		/// System.Security.SecureString InternalGetSecurePassword()
		/// </summary>
		protected RMethod r_RInternalGetSecurePassword;
		public virtual RMethod RInternalGetSecurePassword
		{
			get
			{
				if(r_RInternalGetSecurePassword == null)
				{
					r_RInternalGetSecurePassword = new(this, "InternalGetSecurePassword", 0);
					r_RInternalGetSecurePassword.SetBelong(this.instance);
				}
				return r_RInternalGetSecurePassword;
			}
		}

		/// <summary>
		/// System.String InternalGetDomain()
		/// </summary>
		protected RMethod r_RInternalGetDomain;
		public virtual RMethod RInternalGetDomain
		{
			get
			{
				if(r_RInternalGetDomain == null)
				{
					r_RInternalGetDomain = new(this, "InternalGetDomain", 0);
					r_RInternalGetDomain.SetBelong(this.instance);
				}
				return r_RInternalGetDomain;
			}
		}

		/// <summary>
		/// System.String InternalGetDomainUserName()
		/// </summary>
		protected RMethod r_RInternalGetDomainUserName;
		public virtual RMethod RInternalGetDomainUserName
		{
			get
			{
				if(r_RInternalGetDomainUserName == null)
				{
					r_RInternalGetDomainUserName = new(this, "InternalGetDomainUserName", 0);
					r_RInternalGetDomainUserName.SetBelong(this.instance);
				}
				return r_RInternalGetDomainUserName;
			}
		}

		/// <summary>
		/// System.Net.NetworkCredential GetCredential(System.Uri, System.String)
		/// </summary>
		protected RMethod r_RGetCredential_Uri_String;
		public virtual RMethod RGetCredential_Uri_String
		{
			get
			{
				if(r_RGetCredential_Uri_String == null)
				{
					r_RGetCredential_Uri_String = new(this, "GetCredential", 0, typeof(System.Uri), typeof(System.String));
					r_RGetCredential_Uri_String.SetBelong(this.instance);
				}
				return r_RGetCredential_Uri_String;
			}
		}

		/// <summary>
		/// System.Net.NetworkCredential GetCredential(System.String, Int32, System.String)
		/// </summary>
		protected RMethod r_RGetCredential_String_Int32_String;
		public virtual RMethod RGetCredential_String_Int32_String
		{
			get
			{
				if(r_RGetCredential_String_Int32_String == null)
				{
					r_RGetCredential_String_Int32_String = new(this, "GetCredential", 0, typeof(System.String), typeof(System.Int32), typeof(System.String));
					r_RGetCredential_String_Int32_String.SetBelong(this.instance);
				}
				return r_RGetCredential_String_Int32_String;
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


        public RNetworkCredential() : base("System.Net.NetworkCredential")
        {
        }

        public RNetworkCredential(System.Object instance) : base("System.Net.NetworkCredential")
		{
            SetInstance(instance);
		}

        public RNetworkCredential(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNetworkCredential(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String InternalGetUserName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetUserName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String InternalGetPassword()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetPassword.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Security.SecureString InternalGetSecurePassword()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetSecurePassword.Invoke(___genericsType, ___parameters);

            return (System.Security.SecureString)___result;
        }


        public virtual System.String InternalGetDomain()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetDomain.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String InternalGetDomainUserName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalGetDomainUserName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Net.NetworkCredential GetCredential(System.Uri  @uri, System.String  @authType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri, @authType};
            var ___result = RGetCredential_Uri_String.Invoke(___genericsType, ___parameters);

            return (System.Net.NetworkCredential)___result;
        }


        public virtual System.Net.NetworkCredential GetCredential(System.String  @host, System.Int32  @port, System.String  @authenticationType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@host, @port, @authenticationType};
            var ___result = RGetCredential_String_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Net.NetworkCredential)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
