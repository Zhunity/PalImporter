using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem
{public partial class RUri
{
	
	/// <summary>
	/// System.Uri+UriInfo
	/// </summary>
    public partial class RUriInfo : RMember //
    {

		/// <summary>
		/// System.String Host
		/// </summary>
		protected RField r_Host;
		public virtual RField RHost
		{
			get
			{
				if(r_Host == null)
				{
					r_Host = new(this, "Host");
					r_Host.SetBelong(this.instance);
				}
				return r_Host;
			}
		}

		/// <summary>
		/// System.String ScopeId
		/// </summary>
		protected RField r_ScopeId;
		public virtual RField RScopeId
		{
			get
			{
				if(r_ScopeId == null)
				{
					r_ScopeId = new(this, "ScopeId");
					r_ScopeId.SetBelong(this.instance);
				}
				return r_ScopeId;
			}
		}

		/// <summary>
		/// System.String String
		/// </summary>
		protected RField r_String;
		public virtual RField RString
		{
			get
			{
				if(r_String == null)
				{
					r_String = new(this, "String");
					r_String.SetBelong(this.instance);
				}
				return r_String;
			}
		}

		/// <summary>
		/// System.Uri+Offset Offset
		/// </summary>
		protected RSystem.RUri.ROffset r_Offset;
		public virtual RSystem.RUri.ROffset ROffset
		{
			get
			{
				if(r_Offset == null)
				{
					r_Offset = new(this, "Offset");
					r_Offset.SetBelong(this.instance);
				}
				return r_Offset;
			}
		}

		/// <summary>
		/// System.String DnsSafeHost
		/// </summary>
		protected RField r_DnsSafeHost;
		public virtual RField RDnsSafeHost
		{
			get
			{
				if(r_DnsSafeHost == null)
				{
					r_DnsSafeHost = new(this, "DnsSafeHost");
					r_DnsSafeHost.SetBelong(this.instance);
				}
				return r_DnsSafeHost;
			}
		}

		/// <summary>
		/// System.Uri+MoreInfo MoreInfo
		/// </summary>
		protected RSystem.RUri.RMoreInfo r_MoreInfo;
		public virtual RSystem.RUri.RMoreInfo RMoreInfo
		{
			get
			{
				if(r_MoreInfo == null)
				{
					r_MoreInfo = new(this, "MoreInfo");
					r_MoreInfo.SetBelong(this.instance);
				}
				return r_MoreInfo;
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


        public RUriInfo() : base("System.Uri+UriInfo")
        {
        }

        public RUriInfo(System.Object instance) : base("System.Uri+UriInfo")
		{
            SetInstance(instance);
		}

        public RUriInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUriInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
}