using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.DomNameTable
	/// </summary>
    public partial class RDomNameTable : RMember //
    {

		/// <summary>
		/// System.Xml.XmlName[] entries
		/// </summary>
		protected RFieldArray<RSystem.RXml.RXmlName> r_entries;
		public virtual RFieldArray<RSystem.RXml.RXmlName> Rentries
		{
			get
			{
				if(r_entries == null)
				{
					r_entries = new(this, "entries");
					r_entries.SetBelong(this.instance);
				}
				return r_entries;
			}
		}

		/// <summary>
		/// System.Int32 count
		/// </summary>
		protected RField r_count;
		public virtual RField Rcount
		{
			get
			{
				if(r_count == null)
				{
					r_count = new(this, "count");
					r_count.SetBelong(this.instance);
				}
				return r_count;
			}
		}

		/// <summary>
		/// System.Int32 mask
		/// </summary>
		protected RField r_mask;
		public virtual RField Rmask
		{
			get
			{
				if(r_mask == null)
				{
					r_mask = new(this, "mask");
					r_mask.SetBelong(this.instance);
				}
				return r_mask;
			}
		}

		/// <summary>
		/// System.Xml.XmlDocument ownerDocument
		/// </summary>
		protected RSystem.RXml.RXmlDocument r_ownerDocument;
		public virtual RSystem.RXml.RXmlDocument RownerDocument
		{
			get
			{
				if(r_ownerDocument == null)
				{
					r_ownerDocument = new(this, "ownerDocument");
					r_ownerDocument.SetBelong(this.instance);
				}
				return r_ownerDocument;
			}
		}

		/// <summary>
		/// System.Xml.XmlNameTable nameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_nameTable;
		public virtual RSystem.RXml.RXmlNameTable RnameTable
		{
			get
			{
				if(r_nameTable == null)
				{
					r_nameTable = new(this, "nameTable");
					r_nameTable.SetBelong(this.instance);
				}
				return r_nameTable;
			}
		}

		/// <summary>
		/// System.Int32 InitialSize
		/// </summary>
		protected static RField r_InitialSize;
		public static RField RInitialSize
		{
			get
			{
				if(r_InitialSize == null)
				{
					r_InitialSize = new( ReleactionUtils.GetType("System.Xml.DomNameTable"), "InitialSize");
					r_InitialSize.SetBelong(null);
				}
				return r_InitialSize;
			}
		}

		/// <summary>
		/// System.Xml.XmlName GetName(System.String, System.String, System.String, System.Xml.Schema.IXmlSchemaInfo)
		/// </summary>
		protected RMethod r_RGetName_String_String_String_IXmlSchemaInfo;
		public virtual RMethod RGetName_String_String_String_IXmlSchemaInfo
		{
			get
			{
				if(r_RGetName_String_String_String_IXmlSchemaInfo == null)
				{
					r_RGetName_String_String_String_IXmlSchemaInfo = new(this, "GetName", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Xml.Schema.IXmlSchemaInfo));
					r_RGetName_String_String_String_IXmlSchemaInfo.SetBelong(this.instance);
				}
				return r_RGetName_String_String_String_IXmlSchemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlName AddName(System.String, System.String, System.String, System.Xml.Schema.IXmlSchemaInfo)
		/// </summary>
		protected RMethod r_RAddName_String_String_String_IXmlSchemaInfo;
		public virtual RMethod RAddName_String_String_String_IXmlSchemaInfo
		{
			get
			{
				if(r_RAddName_String_String_String_IXmlSchemaInfo == null)
				{
					r_RAddName_String_String_String_IXmlSchemaInfo = new(this, "AddName", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Xml.Schema.IXmlSchemaInfo));
					r_RAddName_String_String_String_IXmlSchemaInfo.SetBelong(this.instance);
				}
				return r_RAddName_String_String_String_IXmlSchemaInfo;
			}
		}

		/// <summary>
		/// Void Grow()
		/// </summary>
		protected RMethod r_RGrow;
		public virtual RMethod RGrow
		{
			get
			{
				if(r_RGrow == null)
				{
					r_RGrow = new(this, "Grow", 0);
					r_RGrow.SetBelong(this.instance);
				}
				return r_RGrow;
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


        public RDomNameTable() : base("System.Xml.DomNameTable")
        {
        }

        public RDomNameTable(System.Object instance) : base("System.Xml.DomNameTable")
		{
            SetInstance(instance);
		}

        public RDomNameTable(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDomNameTable(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object GetName(System.String  @prefix, System.String  @localName, System.String  @ns, System.Xml.Schema.IXmlSchemaInfo  @schemaInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns, @schemaInfo};
            var ___result = RGetName_String_String_String_IXmlSchemaInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AddName(System.String  @prefix, System.String  @localName, System.String  @ns, System.Xml.Schema.IXmlSchemaInfo  @schemaInfo)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @localName, @ns, @schemaInfo};
            var ___result = RAddName_String_String_String_IXmlSchemaInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Grow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGrow.Invoke(___genericsType, ___parameters);

            
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
