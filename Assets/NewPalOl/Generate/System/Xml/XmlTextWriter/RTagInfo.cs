using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{public partial class RXmlTextWriter
{
	
	/// <summary>
	/// System.Xml.XmlTextWriter+TagInfo
	/// </summary>
    public partial class RTagInfo : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

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
		/// System.String defaultNs
		/// </summary>
		protected RField r_defaultNs;
		public virtual RField RdefaultNs
		{
			get
			{
				if(r_defaultNs == null)
				{
					r_defaultNs = new(this, "defaultNs");
					r_defaultNs.SetBelong(this.instance);
				}
				return r_defaultNs;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextWriter+NamespaceState defaultNsState
		/// </summary>
		protected RField r_defaultNsState;
		public virtual RField RdefaultNsState
		{
			get
			{
				if(r_defaultNsState == null)
				{
					r_defaultNsState = new(this, "defaultNsState");
					r_defaultNsState.SetBelong(this.instance);
				}
				return r_defaultNsState;
			}
		}

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
		/// System.Int32 prevNsTop
		/// </summary>
		protected RField r_prevNsTop;
		public virtual RField RprevNsTop
		{
			get
			{
				if(r_prevNsTop == null)
				{
					r_prevNsTop = new(this, "prevNsTop");
					r_prevNsTop.SetBelong(this.instance);
				}
				return r_prevNsTop;
			}
		}

		/// <summary>
		/// System.Int32 prefixCount
		/// </summary>
		protected RField r_prefixCount;
		public virtual RField RprefixCount
		{
			get
			{
				if(r_prefixCount == null)
				{
					r_prefixCount = new(this, "prefixCount");
					r_prefixCount.SetBelong(this.instance);
				}
				return r_prefixCount;
			}
		}

		/// <summary>
		/// System.Boolean mixed
		/// </summary>
		protected RField r_mixed;
		public virtual RField Rmixed
		{
			get
			{
				if(r_mixed == null)
				{
					r_mixed = new(this, "mixed");
					r_mixed.SetBelong(this.instance);
				}
				return r_mixed;
			}
		}

		/// <summary>
		/// Void Init(Int32)
		/// </summary>
		protected RMethod r_RInit_Int32;
		public virtual RMethod RInit_Int32
		{
			get
			{
				if(r_RInit_Int32 == null)
				{
					r_RInit_Int32 = new(this, "Init", 0, typeof(System.Int32));
					r_RInit_Int32.SetBelong(this.instance);
				}
				return r_RInit_Int32;
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


        public RTagInfo() : base("System.Xml.XmlTextWriter+TagInfo")
        {
        }

        public RTagInfo(System.Object instance) : base("System.Xml.XmlTextWriter+TagInfo")
		{
            SetInstance(instance);
		}

        public RTagInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTagInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init(System.Int32  @nsTop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nsTop};
            var ___result = RInit_Int32.Invoke(___genericsType, ___parameters);

            
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