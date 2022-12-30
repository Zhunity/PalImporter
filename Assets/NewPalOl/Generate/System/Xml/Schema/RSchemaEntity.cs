using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.SchemaEntity
	/// </summary>
    public partial class RSchemaEntity : RMember //
    {

		/// <summary>
		/// System.Xml.XmlQualifiedName qname
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_qname;
		public virtual RSystem.RXml.RXmlQualifiedName Rqname
		{
			get
			{
				if(r_qname == null)
				{
					r_qname = new(this, "qname");
					r_qname.SetBelong(this.instance);
				}
				return r_qname;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected RField r_url;
		public virtual RField Rurl
		{
			get
			{
				if(r_url == null)
				{
					r_url = new(this, "url");
					r_url.SetBelong(this.instance);
				}
				return r_url;
			}
		}

		/// <summary>
		/// System.String pubid
		/// </summary>
		protected RField r_pubid;
		public virtual RField Rpubid
		{
			get
			{
				if(r_pubid == null)
				{
					r_pubid = new(this, "pubid");
					r_pubid.SetBelong(this.instance);
				}
				return r_pubid;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected RField r_text;
		public virtual RField Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text");
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName ndata
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_ndata;
		public virtual RSystem.RXml.RXmlQualifiedName Rndata
		{
			get
			{
				if(r_ndata == null)
				{
					r_ndata = new(this, "ndata");
					r_ndata.SetBelong(this.instance);
				}
				return r_ndata;
			}
		}

		/// <summary>
		/// System.Int32 lineNumber
		/// </summary>
		protected RField r_lineNumber;
		public virtual RField RlineNumber
		{
			get
			{
				if(r_lineNumber == null)
				{
					r_lineNumber = new(this, "lineNumber");
					r_lineNumber.SetBelong(this.instance);
				}
				return r_lineNumber;
			}
		}

		/// <summary>
		/// System.Int32 linePosition
		/// </summary>
		protected RField r_linePosition;
		public virtual RField RlinePosition
		{
			get
			{
				if(r_linePosition == null)
				{
					r_linePosition = new(this, "linePosition");
					r_linePosition.SetBelong(this.instance);
				}
				return r_linePosition;
			}
		}

		/// <summary>
		/// System.Boolean isParameter
		/// </summary>
		protected RField r_isParameter;
		public virtual RField RisParameter
		{
			get
			{
				if(r_isParameter == null)
				{
					r_isParameter = new(this, "isParameter");
					r_isParameter.SetBelong(this.instance);
				}
				return r_isParameter;
			}
		}

		/// <summary>
		/// System.Boolean isExternal
		/// </summary>
		protected RField r_isExternal;
		public virtual RField RisExternal
		{
			get
			{
				if(r_isExternal == null)
				{
					r_isExternal = new(this, "isExternal");
					r_isExternal.SetBelong(this.instance);
				}
				return r_isExternal;
			}
		}

		/// <summary>
		/// System.Boolean parsingInProgress
		/// </summary>
		protected RField r_parsingInProgress;
		public virtual RField RparsingInProgress
		{
			get
			{
				if(r_parsingInProgress == null)
				{
					r_parsingInProgress = new(this, "parsingInProgress");
					r_parsingInProgress.SetBelong(this.instance);
				}
				return r_parsingInProgress;
			}
		}

		/// <summary>
		/// System.Boolean isDeclaredInExternal
		/// </summary>
		protected RField r_isDeclaredInExternal;
		public virtual RField RisDeclaredInExternal
		{
			get
			{
				if(r_isDeclaredInExternal == null)
				{
					r_isDeclaredInExternal = new(this, "isDeclaredInExternal");
					r_isDeclaredInExternal.SetBelong(this.instance);
				}
				return r_isDeclaredInExternal;
			}
		}

		/// <summary>
		/// System.String baseURI
		/// </summary>
		protected RField r_baseURI;
		public virtual RField RbaseURI
		{
			get
			{
				if(r_baseURI == null)
				{
					r_baseURI = new(this, "baseURI");
					r_baseURI.SetBelong(this.instance);
				}
				return r_baseURI;
			}
		}

		/// <summary>
		/// System.String declaredURI
		/// </summary>
		protected RField r_declaredURI;
		public virtual RField RdeclaredURI
		{
			get
			{
				if(r_declaredURI == null)
				{
					r_declaredURI = new(this, "declaredURI");
					r_declaredURI.SetBelong(this.instance);
				}
				return r_declaredURI;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdEntityInfo.Name
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Name;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_Name
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Name == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Name = new(this, "System.Xml.IDtdEntityInfo.Name", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Name.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Name;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdEntityInfo.IsExternal
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsExternal;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsExternal
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsExternal == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsExternal = new(this, "System.Xml.IDtdEntityInfo.IsExternal", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsExternal.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsExternal;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdEntityInfo.IsDeclaredInExternal
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsDeclaredInExternal;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsDeclaredInExternal
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsDeclaredInExternal == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsDeclaredInExternal = new(this, "System.Xml.IDtdEntityInfo.IsDeclaredInExternal", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsDeclaredInExternal.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsDeclaredInExternal;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdEntityInfo.IsUnparsedEntity
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsUnparsedEntity;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsUnparsedEntity
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsUnparsedEntity == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsUnparsedEntity = new(this, "System.Xml.IDtdEntityInfo.IsUnparsedEntity", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsUnparsedEntity.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsUnparsedEntity;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdEntityInfo.IsParameterEntity
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsParameterEntity;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsParameterEntity
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsParameterEntity == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsParameterEntity = new(this, "System.Xml.IDtdEntityInfo.IsParameterEntity", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsParameterEntity.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_IsParameterEntity;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdEntityInfo.BaseUriString
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_BaseUriString;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_BaseUriString
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_BaseUriString == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_BaseUriString = new(this, "System.Xml.IDtdEntityInfo.BaseUriString", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_BaseUriString.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_BaseUriString;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdEntityInfo.DeclaredUriString
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_DeclaredUriString;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_DeclaredUriString
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_DeclaredUriString == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_DeclaredUriString = new(this, "System.Xml.IDtdEntityInfo.DeclaredUriString", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_DeclaredUriString.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_DeclaredUriString;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdEntityInfo.SystemId
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_SystemId;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_SystemId
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_SystemId == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_SystemId = new(this, "System.Xml.IDtdEntityInfo.SystemId", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_SystemId.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_SystemId;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdEntityInfo.PublicId
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_PublicId;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_PublicId
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_PublicId == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_PublicId = new(this, "System.Xml.IDtdEntityInfo.PublicId", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_PublicId.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_PublicId;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdEntityInfo.Text
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Text;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_Text
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Text == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Text = new(this, "System.Xml.IDtdEntityInfo.Text", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Text.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_Text;
			}
		}

		/// <summary>
		/// Int32 System.Xml.IDtdEntityInfo.LineNumber
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LineNumber;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_LineNumber
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LineNumber == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LineNumber = new(this, "System.Xml.IDtdEntityInfo.LineNumber", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LineNumber.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LineNumber;
			}
		}

		/// <summary>
		/// Int32 System.Xml.IDtdEntityInfo.LinePosition
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LinePosition;
		public virtual RProperty RSystem__1__Xml__1__IDtdEntityInfo__1__get_LinePosition
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LinePosition == null)
				{
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LinePosition = new(this, "System.Xml.IDtdEntityInfo.LinePosition", -1);
					r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LinePosition.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdEntityInfo__1__get_LinePosition;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName Name
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_Name;
		public virtual RSystem.RXml.RXmlQualifiedName RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.String Url
		/// </summary>
		protected RProperty r_Url;
		public virtual RProperty RUrl
		{
			get
			{
				if(r_Url == null)
				{
					r_Url = new(this, "Url", -1);
					r_Url.SetBelong(this.instance);
				}
				return r_Url;
			}
		}

		/// <summary>
		/// System.String Pubid
		/// </summary>
		protected RProperty r_Pubid;
		public virtual RProperty RPubid
		{
			get
			{
				if(r_Pubid == null)
				{
					r_Pubid = new(this, "Pubid", -1);
					r_Pubid.SetBelong(this.instance);
				}
				return r_Pubid;
			}
		}

		/// <summary>
		/// Boolean IsExternal
		/// </summary>
		protected RProperty r_IsExternal;
		public virtual RProperty RIsExternal
		{
			get
			{
				if(r_IsExternal == null)
				{
					r_IsExternal = new(this, "IsExternal", -1);
					r_IsExternal.SetBelong(this.instance);
				}
				return r_IsExternal;
			}
		}

		/// <summary>
		/// Boolean DeclaredInExternal
		/// </summary>
		protected RProperty r_DeclaredInExternal;
		public virtual RProperty RDeclaredInExternal
		{
			get
			{
				if(r_DeclaredInExternal == null)
				{
					r_DeclaredInExternal = new(this, "DeclaredInExternal", -1);
					r_DeclaredInExternal.SetBelong(this.instance);
				}
				return r_DeclaredInExternal;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName NData
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_NData;
		public virtual RSystem.RXml.RXmlQualifiedName RNData
		{
			get
			{
				if(r_NData == null)
				{
					r_NData = new(this, "NData", -1);
					r_NData.SetBelong(this.instance);
				}
				return r_NData;
			}
		}

		/// <summary>
		/// System.String Text
		/// </summary>
		protected RProperty r_Text;
		public virtual RProperty RText
		{
			get
			{
				if(r_Text == null)
				{
					r_Text = new(this, "Text", -1);
					r_Text.SetBelong(this.instance);
				}
				return r_Text;
			}
		}

		/// <summary>
		/// Int32 Line
		/// </summary>
		protected RProperty r_Line;
		public virtual RProperty RLine
		{
			get
			{
				if(r_Line == null)
				{
					r_Line = new(this, "Line", -1);
					r_Line.SetBelong(this.instance);
				}
				return r_Line;
			}
		}

		/// <summary>
		/// Int32 Pos
		/// </summary>
		protected RProperty r_Pos;
		public virtual RProperty RPos
		{
			get
			{
				if(r_Pos == null)
				{
					r_Pos = new(this, "Pos", -1);
					r_Pos.SetBelong(this.instance);
				}
				return r_Pos;
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
		/// Boolean ParsingInProgress
		/// </summary>
		protected RProperty r_ParsingInProgress;
		public virtual RProperty RParsingInProgress
		{
			get
			{
				if(r_ParsingInProgress == null)
				{
					r_ParsingInProgress = new(this, "ParsingInProgress", -1);
					r_ParsingInProgress.SetBelong(this.instance);
				}
				return r_ParsingInProgress;
			}
		}

		/// <summary>
		/// System.String DeclaredURI
		/// </summary>
		protected RProperty r_DeclaredURI;
		public virtual RProperty RDeclaredURI
		{
			get
			{
				if(r_DeclaredURI == null)
				{
					r_DeclaredURI = new(this, "DeclaredURI", -1);
					r_DeclaredURI.SetBelong(this.instance);
				}
				return r_DeclaredURI;
			}
		}

		/// <summary>
		/// Boolean IsPredefinedEntity(System.String)
		/// </summary>
		protected static RMethod r_RIsPredefinedEntity_String;
		public static RMethod RIsPredefinedEntity_String
		{
			get
			{
				if(r_RIsPredefinedEntity_String == null)
				{
					r_RIsPredefinedEntity_String = new( ReleactionUtils.GetType("System.Xml.Schema.SchemaEntity"), "IsPredefinedEntity", 0, typeof(System.String));
					r_RIsPredefinedEntity_String.SetBelong(null);
				}
				return r_RIsPredefinedEntity_String;
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


        public RSchemaEntity() : base("System.Xml.Schema.SchemaEntity")
        {
        }

        public RSchemaEntity(System.Object instance) : base("System.Xml.Schema.SchemaEntity")
		{
            SetInstance(instance);
		}

        public RSchemaEntity(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSchemaEntity(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Boolean IsPredefinedEntity(System.String  @n)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n};
            var ___result = RIsPredefinedEntity_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
