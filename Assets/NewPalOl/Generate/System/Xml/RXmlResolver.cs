using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlResolver
	/// </summary>
    public partial class RXmlResolver : RMember //
    {

		/// <summary>
		/// System.Net.ICredentials Credentials
		/// </summary>
		protected RSystem.RNet.RICredentials r_Credentials_ICredentials;
		public virtual RSystem.RNet.RICredentials RCredentials_ICredentials
		{
			get
			{
				if(r_Credentials_ICredentials == null)
				{
					r_Credentials_ICredentials = new(this, "Credentials", -1, typeof(System.Net.ICredentials));
					r_Credentials_ICredentials.SetBelong(this.instance);
				}
				return r_Credentials_ICredentials;
			}
		}

		/// <summary>
		/// System.Object GetEntity(System.Uri, System.String, System.Type)
		/// </summary>
		protected RMethod r_RGetEntity_Uri_String_Type;
		public virtual RMethod RGetEntity_Uri_String_Type
		{
			get
			{
				if(r_RGetEntity_Uri_String_Type == null)
				{
					r_RGetEntity_Uri_String_Type = new(this, "GetEntity", 0, typeof(System.Uri), typeof(System.String), typeof(System.Type));
					r_RGetEntity_Uri_String_Type.SetBelong(this.instance);
				}
				return r_RGetEntity_Uri_String_Type;
			}
		}

		/// <summary>
		/// System.Uri ResolveUri(System.Uri, System.String)
		/// </summary>
		protected RMethod r_RResolveUri_Uri_String;
		public virtual RMethod RResolveUri_Uri_String
		{
			get
			{
				if(r_RResolveUri_Uri_String == null)
				{
					r_RResolveUri_Uri_String = new(this, "ResolveUri", 0, typeof(System.Uri), typeof(System.String));
					r_RResolveUri_Uri_String.SetBelong(this.instance);
				}
				return r_RResolveUri_Uri_String;
			}
		}

		/// <summary>
		/// Boolean SupportsType(System.Uri, System.Type)
		/// </summary>
		protected RMethod r_RSupportsType_Uri_Type;
		public virtual RMethod RSupportsType_Uri_Type
		{
			get
			{
				if(r_RSupportsType_Uri_Type == null)
				{
					r_RSupportsType_Uri_Type = new(this, "SupportsType", 0, typeof(System.Uri), typeof(System.Type));
					r_RSupportsType_Uri_Type.SetBelong(this.instance);
				}
				return r_RSupportsType_Uri_Type;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] GetEntityAsync(System.Uri, System.String, System.Type)
		/// </summary>
		protected RMethod r_RGetEntityAsync_Uri_String_Type;
		public virtual RMethod RGetEntityAsync_Uri_String_Type
		{
			get
			{
				if(r_RGetEntityAsync_Uri_String_Type == null)
				{
					r_RGetEntityAsync_Uri_String_Type = new(this, "GetEntityAsync", 0, typeof(System.Uri), typeof(System.String), typeof(System.Type));
					r_RGetEntityAsync_Uri_String_Type.SetBelong(this.instance);
				}
				return r_RGetEntityAsync_Uri_String_Type;
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


        public RXmlResolver() : base("System.Xml.XmlResolver")
        {
        }

        public RXmlResolver(System.Object instance) : base("System.Xml.XmlResolver")
		{
            SetInstance(instance);
		}

        public RXmlResolver(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlResolver(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetEntity(System.Uri  @absoluteUri, System.String  @role, System.Type  @ofObjectToReturn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@absoluteUri, @role, @ofObjectToReturn};
            var ___result = RGetEntity_Uri_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Uri ResolveUri(System.Uri  @baseUri, System.String  @relativeUri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @relativeUri};
            var ___result = RResolveUri_Uri_String.Invoke(___genericsType, ___parameters);

            return (System.Uri)___result;
        }


        public virtual System.Boolean SupportsType(System.Uri  @absoluteUri, System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@absoluteUri, @type};
            var ___result = RSupportsType_Uri_Type.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> GetEntityAsync(System.Uri  @absoluteUri, System.String  @role, System.Type  @ofObjectToReturn)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@absoluteUri, @role, @ofObjectToReturn};
            var ___result = RGetEntityAsync_Uri_String_Type.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
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
