using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlTextWriter
{
	
	/// <summary>
	/// System.Xml.XmlTextWriter+Namespace
	/// </summary>
    public partial class RNamespace : RMember //
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
		/// System.String ns
		/// </summary>
		protected RField r_ns;
		public virtual RField Rns
		{
			get
			{
				if(r_ns == null)
				{
					r_ns = new(this, "ns");
					r_ns.SetBelong(this.instance);
				}
				return r_ns;
			}
		}

		/// <summary>
		/// System.Boolean declared
		/// </summary>
		protected RField r_declared;
		public virtual RField Rdeclared
		{
			get
			{
				if(r_declared == null)
				{
					r_declared = new(this, "declared");
					r_declared.SetBelong(this.instance);
				}
				return r_declared;
			}
		}

		/// <summary>
		/// System.Int32 prevNsIndex
		/// </summary>
		protected RField r_prevNsIndex;
		public virtual RField RprevNsIndex
		{
			get
			{
				if(r_prevNsIndex == null)
				{
					r_prevNsIndex = new(this, "prevNsIndex");
					r_prevNsIndex.SetBelong(this.instance);
				}
				return r_prevNsIndex;
			}
		}

		/// <summary>
		/// Void Set(System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_RSet_String_String_Boolean;
		public virtual RMethod RSet_String_String_Boolean
		{
			get
			{
				if(r_RSet_String_String_Boolean == null)
				{
					r_RSet_String_String_Boolean = new(this, "Set", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_RSet_String_String_Boolean.SetBelong(this.instance);
				}
				return r_RSet_String_String_Boolean;
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


        public RNamespace() : base("System.Xml.XmlTextWriter+Namespace")
        {
        }

        public RNamespace(System.Object instance) : base("System.Xml.XmlTextWriter+Namespace")
		{
            SetInstance(instance);
		}

        public RNamespace(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNamespace(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Set(System.String  @prefix, System.String  @ns, System.Boolean  @declared)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @ns, @declared};
            var ___result = RSet_String_String_Boolean.Invoke(___genericsType, ___parameters);

            
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