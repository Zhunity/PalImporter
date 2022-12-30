using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlParserContext
	/// </summary>
    public partial class RXmlParserContext : RMember //
    {

		/// <summary>
		/// System.Xml.XmlNameTable _nt
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r__nt;
		public virtual RSystem.RXml.RXmlNameTable R_nt
		{
			get
			{
				if(r__nt == null)
				{
					r__nt = new(this, "_nt");
					r__nt.SetBelong(this.instance);
				}
				return r__nt;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamespaceManager _nsMgr
		/// </summary>
		protected RSystem.RXml.RXmlNamespaceManager r__nsMgr;
		public virtual RSystem.RXml.RXmlNamespaceManager R_nsMgr
		{
			get
			{
				if(r__nsMgr == null)
				{
					r__nsMgr = new(this, "_nsMgr");
					r__nsMgr.SetBelong(this.instance);
				}
				return r__nsMgr;
			}
		}

		/// <summary>
		/// System.String _docTypeName
		/// </summary>
		protected RField r__docTypeName;
		public virtual RField R_docTypeName
		{
			get
			{
				if(r__docTypeName == null)
				{
					r__docTypeName = new(this, "_docTypeName");
					r__docTypeName.SetBelong(this.instance);
				}
				return r__docTypeName;
			}
		}

		/// <summary>
		/// System.String _pubId
		/// </summary>
		protected RField r__pubId;
		public virtual RField R_pubId
		{
			get
			{
				if(r__pubId == null)
				{
					r__pubId = new(this, "_pubId");
					r__pubId.SetBelong(this.instance);
				}
				return r__pubId;
			}
		}

		/// <summary>
		/// System.String _sysId
		/// </summary>
		protected RField r__sysId;
		public virtual RField R_sysId
		{
			get
			{
				if(r__sysId == null)
				{
					r__sysId = new(this, "_sysId");
					r__sysId.SetBelong(this.instance);
				}
				return r__sysId;
			}
		}

		/// <summary>
		/// System.String _internalSubset
		/// </summary>
		protected RField r__internalSubset;
		public virtual RField R_internalSubset
		{
			get
			{
				if(r__internalSubset == null)
				{
					r__internalSubset = new(this, "_internalSubset");
					r__internalSubset.SetBelong(this.instance);
				}
				return r__internalSubset;
			}
		}

		/// <summary>
		/// System.String _xmlLang
		/// </summary>
		protected RField r__xmlLang;
		public virtual RField R_xmlLang
		{
			get
			{
				if(r__xmlLang == null)
				{
					r__xmlLang = new(this, "_xmlLang");
					r__xmlLang.SetBelong(this.instance);
				}
				return r__xmlLang;
			}
		}

		/// <summary>
		/// System.Xml.XmlSpace _xmlSpace
		/// </summary>
		protected RField r__xmlSpace;
		public virtual RField R_xmlSpace
		{
			get
			{
				if(r__xmlSpace == null)
				{
					r__xmlSpace = new(this, "_xmlSpace");
					r__xmlSpace.SetBelong(this.instance);
				}
				return r__xmlSpace;
			}
		}

		/// <summary>
		/// System.String _baseURI
		/// </summary>
		protected RField r__baseURI;
		public virtual RField R_baseURI
		{
			get
			{
				if(r__baseURI == null)
				{
					r__baseURI = new(this, "_baseURI");
					r__baseURI.SetBelong(this.instance);
				}
				return r__baseURI;
			}
		}

		/// <summary>
		/// System.Text.Encoding _encoding
		/// </summary>
		protected RSystem.RText.REncoding r__encoding;
		public virtual RSystem.RText.REncoding R_encoding
		{
			get
			{
				if(r__encoding == null)
				{
					r__encoding = new(this, "_encoding");
					r__encoding.SetBelong(this.instance);
				}
				return r__encoding;
			}
		}

		/// <summary>
		/// System.Xml.XmlNameTable NameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_NameTable;
		public virtual RSystem.RXml.RXmlNameTable RNameTable
		{
			get
			{
				if(r_NameTable == null)
				{
					r_NameTable = new(this, "NameTable", -1);
					r_NameTable.SetBelong(this.instance);
				}
				return r_NameTable;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamespaceManager NamespaceManager
		/// </summary>
		protected RSystem.RXml.RXmlNamespaceManager r_NamespaceManager;
		public virtual RSystem.RXml.RXmlNamespaceManager RNamespaceManager
		{
			get
			{
				if(r_NamespaceManager == null)
				{
					r_NamespaceManager = new(this, "NamespaceManager", -1);
					r_NamespaceManager.SetBelong(this.instance);
				}
				return r_NamespaceManager;
			}
		}

		/// <summary>
		/// System.String DocTypeName
		/// </summary>
		protected RProperty r_DocTypeName;
		public virtual RProperty RDocTypeName
		{
			get
			{
				if(r_DocTypeName == null)
				{
					r_DocTypeName = new(this, "DocTypeName", -1);
					r_DocTypeName.SetBelong(this.instance);
				}
				return r_DocTypeName;
			}
		}

		/// <summary>
		/// System.String PublicId
		/// </summary>
		protected RProperty r_PublicId;
		public virtual RProperty RPublicId
		{
			get
			{
				if(r_PublicId == null)
				{
					r_PublicId = new(this, "PublicId", -1);
					r_PublicId.SetBelong(this.instance);
				}
				return r_PublicId;
			}
		}

		/// <summary>
		/// System.String SystemId
		/// </summary>
		protected RProperty r_SystemId;
		public virtual RProperty RSystemId
		{
			get
			{
				if(r_SystemId == null)
				{
					r_SystemId = new(this, "SystemId", -1);
					r_SystemId.SetBelong(this.instance);
				}
				return r_SystemId;
			}
		}

		/// <summary>
		/// System.String BaseURI
		/// </summary>
		protected RProperty r_BaseURI;
		public virtual RProperty RBaseURI
		{
			get
			{
				if(r_BaseURI == null)
				{
					r_BaseURI = new(this, "BaseURI", -1);
					r_BaseURI.SetBelong(this.instance);
				}
				return r_BaseURI;
			}
		}

		/// <summary>
		/// System.String InternalSubset
		/// </summary>
		protected RProperty r_InternalSubset;
		public virtual RProperty RInternalSubset
		{
			get
			{
				if(r_InternalSubset == null)
				{
					r_InternalSubset = new(this, "InternalSubset", -1);
					r_InternalSubset.SetBelong(this.instance);
				}
				return r_InternalSubset;
			}
		}

		/// <summary>
		/// System.String XmlLang
		/// </summary>
		protected RProperty r_XmlLang;
		public virtual RProperty RXmlLang
		{
			get
			{
				if(r_XmlLang == null)
				{
					r_XmlLang = new(this, "XmlLang", -1);
					r_XmlLang.SetBelong(this.instance);
				}
				return r_XmlLang;
			}
		}

		/// <summary>
		/// System.Xml.XmlSpace XmlSpace
		/// </summary>
		protected RProperty r_XmlSpace;
		public virtual RProperty RXmlSpace
		{
			get
			{
				if(r_XmlSpace == null)
				{
					r_XmlSpace = new(this, "XmlSpace", -1);
					r_XmlSpace.SetBelong(this.instance);
				}
				return r_XmlSpace;
			}
		}

		/// <summary>
		/// System.Text.Encoding Encoding
		/// </summary>
		protected RSystem.RText.REncoding r_Encoding;
		public virtual RSystem.RText.REncoding REncoding
		{
			get
			{
				if(r_Encoding == null)
				{
					r_Encoding = new(this, "Encoding", -1);
					r_Encoding.SetBelong(this.instance);
				}
				return r_Encoding;
			}
		}

		/// <summary>
		/// Boolean HasDtdInfo
		/// </summary>
		protected RProperty r_HasDtdInfo;
		public virtual RProperty RHasDtdInfo
		{
			get
			{
				if(r_HasDtdInfo == null)
				{
					r_HasDtdInfo = new(this, "HasDtdInfo", -1);
					r_HasDtdInfo.SetBelong(this.instance);
				}
				return r_HasDtdInfo;
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


        public RXmlParserContext() : base("System.Xml.XmlParserContext")
        {
        }

        public RXmlParserContext(System.Object instance) : base("System.Xml.XmlParserContext")
		{
            SetInstance(instance);
		}

        public RXmlParserContext(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlParserContext(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
