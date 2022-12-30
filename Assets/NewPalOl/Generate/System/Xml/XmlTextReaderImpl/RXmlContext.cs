using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlTextReaderImpl
{
	
	/// <summary>
	/// System.Xml.XmlTextReaderImpl+XmlContext
	/// </summary>
    public partial class RXmlContext : RMember //
    {

		/// <summary>
		/// System.Xml.XmlSpace xmlSpace
		/// </summary>
		protected RField r_xmlSpace;
		public virtual RField RxmlSpace
		{
			get
			{
				if(r_xmlSpace == null)
				{
					r_xmlSpace = new(this, "xmlSpace");
					r_xmlSpace.SetBelong(this.instance);
				}
				return r_xmlSpace;
			}
		}

		/// <summary>
		/// System.String xmlLang
		/// </summary>
		protected RField r_xmlLang;
		public virtual RField RxmlLang
		{
			get
			{
				if(r_xmlLang == null)
				{
					r_xmlLang = new(this, "xmlLang");
					r_xmlLang.SetBelong(this.instance);
				}
				return r_xmlLang;
			}
		}

		/// <summary>
		/// System.String defaultNamespace
		/// </summary>
		protected RField r_defaultNamespace;
		public virtual RField RdefaultNamespace
		{
			get
			{
				if(r_defaultNamespace == null)
				{
					r_defaultNamespace = new(this, "defaultNamespace");
					r_defaultNamespace.SetBelong(this.instance);
				}
				return r_defaultNamespace;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+XmlContext previousContext
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.RXmlContext r_previousContext;
		public virtual RSystem.RXml.RXmlTextReaderImpl.RXmlContext RpreviousContext
		{
			get
			{
				if(r_previousContext == null)
				{
					r_previousContext = new(this, "previousContext");
					r_previousContext.SetBelong(this.instance);
				}
				return r_previousContext;
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


        public RXmlContext() : base("System.Xml.XmlTextReaderImpl+XmlContext")
        {
        }

        public RXmlContext(System.Object instance) : base("System.Xml.XmlTextReaderImpl+XmlContext")
		{
            SetInstance(instance);
		}

        public RXmlContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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