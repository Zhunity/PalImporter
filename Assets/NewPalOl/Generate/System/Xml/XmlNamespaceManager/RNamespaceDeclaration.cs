using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlNamespaceManager
{
	
	/// <summary>
	/// System.Xml.XmlNamespaceManager+NamespaceDeclaration
	/// </summary>
    public partial class RNamespaceDeclaration : RMember //
    {

		/// <summary>
		/// System.String prefix
		/// </summary>
		protected RField r_prefix;
		public virtual RField Rprefix
		{
			get
			{
				if(r_prefix == null)
				{
					r_prefix = new(this, "prefix");
					r_prefix.SetBelong(this.instance);
				}
				return r_prefix;
			}
		}

		/// <summary>
		/// System.String uri
		/// </summary>
		protected RField r_uri;
		public virtual RField Ruri
		{
			get
			{
				if(r_uri == null)
				{
					r_uri = new(this, "uri");
					r_uri.SetBelong(this.instance);
				}
				return r_uri;
			}
		}

		/// <summary>
		/// System.Int32 scopeId
		/// </summary>
		protected RField r_scopeId;
		public virtual RField RscopeId
		{
			get
			{
				if(r_scopeId == null)
				{
					r_scopeId = new(this, "scopeId");
					r_scopeId.SetBelong(this.instance);
				}
				return r_scopeId;
			}
		}

		/// <summary>
		/// System.Int32 previousNsIndex
		/// </summary>
		protected RField r_previousNsIndex;
		public virtual RField RpreviousNsIndex
		{
			get
			{
				if(r_previousNsIndex == null)
				{
					r_previousNsIndex = new(this, "previousNsIndex");
					r_previousNsIndex.SetBelong(this.instance);
				}
				return r_previousNsIndex;
			}
		}

		/// <summary>
		/// Void Set(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RSet_String_String_Int32_Int32;
		public virtual RMethod RSet_String_String_Int32_Int32
		{
			get
			{
				if(r_RSet_String_String_Int32_Int32 == null)
				{
					r_RSet_String_String_Int32_Int32 = new(this, "Set", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RSet_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSet_String_String_Int32_Int32;
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


        public RNamespaceDeclaration() : base("System.Xml.XmlNamespaceManager+NamespaceDeclaration")
        {
        }

        public RNamespaceDeclaration(System.Object instance) : base("System.Xml.XmlNamespaceManager+NamespaceDeclaration")
		{
            SetInstance(instance);
		}

        public RNamespaceDeclaration(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNamespaceDeclaration(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Set(System.String  @prefix, System.String  @uri, System.Int32  @scopeId, System.Int32  @previousNsIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @uri, @scopeId, @previousNsIndex};
            var ___result = RSet_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
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
}