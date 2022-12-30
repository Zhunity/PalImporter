using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaDatatype
	/// </summary>
    public partial class RXmlSchemaDatatype : RMember //
    {

		/// <summary>
		/// System.Type ValueType
		/// </summary>
		protected RSystem.RType r_ValueType;
		public virtual RSystem.RType RValueType
		{
			get
			{
				if(r_ValueType == null)
				{
					r_ValueType = new(this, "ValueType", -1);
					r_ValueType.SetBelong(this.instance);
				}
				return r_ValueType;
			}
		}

		/// <summary>
		/// System.Xml.XmlTokenizedType TokenizedType
		/// </summary>
		protected RProperty r_TokenizedType;
		public virtual RProperty RTokenizedType
		{
			get
			{
				if(r_TokenizedType == null)
				{
					r_TokenizedType = new(this, "TokenizedType", -1);
					r_TokenizedType.SetBelong(this.instance);
				}
				return r_TokenizedType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatypeVariety Variety
		/// </summary>
		protected RProperty r_Variety;
		public virtual RProperty RVariety
		{
			get
			{
				if(r_Variety == null)
				{
					r_Variety = new(this, "Variety", -1);
					r_Variety.SetBelong(this.instance);
				}
				return r_Variety;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlTypeCode TypeCode
		/// </summary>
		protected RProperty r_TypeCode;
		public virtual RProperty RTypeCode
		{
			get
			{
				if(r_TypeCode == null)
				{
					r_TypeCode = new(this, "TypeCode", -1);
					r_TypeCode.SetBelong(this.instance);
				}
				return r_TypeCode;
			}
		}

		/// <summary>
		/// Boolean HasLexicalFacets
		/// </summary>
		protected RProperty r_HasLexicalFacets;
		public virtual RProperty RHasLexicalFacets
		{
			get
			{
				if(r_HasLexicalFacets == null)
				{
					r_HasLexicalFacets = new(this, "HasLexicalFacets", -1);
					r_HasLexicalFacets.SetBelong(this.instance);
				}
				return r_HasLexicalFacets;
			}
		}

		/// <summary>
		/// Boolean HasValueFacets
		/// </summary>
		protected RProperty r_HasValueFacets;
		public virtual RProperty RHasValueFacets
		{
			get
			{
				if(r_HasValueFacets == null)
				{
					r_HasValueFacets = new(this, "HasValueFacets", -1);
					r_HasValueFacets.SetBelong(this.instance);
				}
				return r_HasValueFacets;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlValueConverter ValueConverter
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlValueConverter r_ValueConverter;
		public virtual RSystem.RXml.RSchema.RXmlValueConverter RValueConverter
		{
			get
			{
				if(r_ValueConverter == null)
				{
					r_ValueConverter = new(this, "ValueConverter", -1);
					r_ValueConverter.SetBelong(this.instance);
				}
				return r_ValueConverter;
			}
		}

		/// <summary>
		/// System.Xml.Schema.RestrictionFacets Restriction
		/// </summary>
		protected RSystem.RXml.RSchema.RRestrictionFacets r_Restriction;
		public virtual RSystem.RXml.RSchema.RRestrictionFacets Restriction
		{
			get
			{
				if(r_Restriction == null)
				{
					r_Restriction = new(this, "Restriction", -1);
					r_Restriction.SetBelong(this.instance);
				}
				return r_Restriction;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker FacetsChecker
		/// </summary>
		protected RSystem.RXml.RSchema.RFacetsChecker r_FacetsChecker;
		public virtual RSystem.RXml.RSchema.RFacetsChecker RFacetsChecker
		{
			get
			{
				if(r_FacetsChecker == null)
				{
					r_FacetsChecker = new(this, "FacetsChecker", -1);
					r_FacetsChecker.SetBelong(this.instance);
				}
				return r_FacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		/// </summary>
		protected RProperty r_BuiltInWhitespaceFacet;
		public virtual RProperty RBuiltInWhitespaceFacet
		{
			get
			{
				if(r_BuiltInWhitespaceFacet == null)
				{
					r_BuiltInWhitespaceFacet = new(this, "BuiltInWhitespaceFacet", -1);
					r_BuiltInWhitespaceFacet.SetBelong(this.instance);
				}
				return r_BuiltInWhitespaceFacet;
			}
		}

		/// <summary>
		/// System.String TypeCodeString
		/// </summary>
		protected RProperty r_TypeCodeString;
		public virtual RProperty RTypeCodeString
		{
			get
			{
				if(r_TypeCodeString == null)
				{
					r_TypeCodeString = new(this, "TypeCodeString", -1);
					r_TypeCodeString.SetBelong(this.instance);
				}
				return r_TypeCodeString;
			}
		}

		/// <summary>
		/// System.Object ParseValue(System.String, System.Xml.XmlNameTable, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver;
		public virtual RMethod RParseValue_String_XmlNameTable_IXmlNamespaceResolver
		{
			get
			{
				if(r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver == null)
				{
					r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver = new(this, "ParseValue", 0, typeof(System.String), typeof(System.Xml.XmlNameTable), typeof(System.Xml.IXmlNamespaceResolver));
					r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.Object, System.Type)
		/// </summary>
		protected RMethod r_RChangeType_Object_Type;
		public virtual RMethod RChangeType_Object_Type
		{
			get
			{
				if(r_RChangeType_Object_Type == null)
				{
					r_RChangeType_Object_Type = new(this, "ChangeType", 0, typeof(System.Object), typeof(System.Type));
					r_RChangeType_Object_Type.SetBelong(this.instance);
				}
				return r_RChangeType_Object_Type;
			}
		}

		/// <summary>
		/// System.Object ChangeType(System.Object, System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RChangeType_Object_Type_IXmlNamespaceResolver;
		public virtual RMethod RChangeType_Object_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RChangeType_Object_Type_IXmlNamespaceResolver == null)
				{
					r_RChangeType_Object_Type_IXmlNamespaceResolver = new(this, "ChangeType", 0, typeof(System.Object), typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RChangeType_Object_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RChangeType_Object_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RIsDerivedFrom_XmlSchemaDatatype;
		public virtual RMethod RIsDerivedFrom_XmlSchemaDatatype
		{
			get
			{
				if(r_RIsDerivedFrom_XmlSchemaDatatype == null)
				{
					r_RIsDerivedFrom_XmlSchemaDatatype = new(this, "IsDerivedFrom", 0, typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RIsDerivedFrom_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RIsDerivedFrom_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// Int32 Compare(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RCompare_Object_Object;
		public virtual RMethod RCompare_Object_Object
		{
			get
			{
				if(r_RCompare_Object_Object == null)
				{
					r_RCompare_Object_Object = new(this, "Compare", 0, typeof(System.Object), typeof(System.Object));
					r_RCompare_Object_Object.SetBelong(this.instance);
				}
				return r_RCompare_Object_Object;
			}
		}

		/// <summary>
		/// System.Object ParseValue(System.String, System.Type, System.Xml.XmlNameTable, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RParseValue_String_Type_XmlNameTable_IXmlNamespaceResolver;
		public virtual RMethod RParseValue_String_Type_XmlNameTable_IXmlNamespaceResolver
		{
			get
			{
				if(r_RParseValue_String_Type_XmlNameTable_IXmlNamespaceResolver == null)
				{
					r_RParseValue_String_Type_XmlNameTable_IXmlNamespaceResolver = new(this, "ParseValue", 0, typeof(System.String), typeof(System.Type), typeof(System.Xml.XmlNameTable), typeof(System.Xml.IXmlNamespaceResolver));
					r_RParseValue_String_Type_XmlNameTable_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RParseValue_String_Type_XmlNameTable_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object ParseValue(System.String, System.Xml.XmlNameTable, System.Xml.IXmlNamespaceResolver, Boolean)
		/// </summary>
		protected RMethod r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver_Boolean;
		public virtual RMethod RParseValue_String_XmlNameTable_IXmlNamespaceResolver_Boolean
		{
			get
			{
				if(r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver_Boolean == null)
				{
					r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver_Boolean = new(this, "ParseValue", 0, typeof(System.String), typeof(System.Xml.XmlNameTable), typeof(System.Xml.IXmlNamespaceResolver), typeof(System.Boolean));
					r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver_Boolean.SetBelong(this.instance);
				}
				return r_RParseValue_String_XmlNameTable_IXmlNamespaceResolver_Boolean;
			}
		}

		/// <summary>
		/// System.Exception TryParseValue(System.String, System.Xml.XmlNameTable, System.Xml.IXmlNamespaceResolver, System.Object ByRef)
		/// </summary>
		protected RMethod r_RTryParseValue_String_XmlNameTable_IXmlNamespaceResolver_Out_Object;
		public virtual RMethod RTryParseValue_String_XmlNameTable_IXmlNamespaceResolver_Out_Object
		{
			get
			{
				if(r_RTryParseValue_String_XmlNameTable_IXmlNamespaceResolver_Out_Object == null)
				{
					r_RTryParseValue_String_XmlNameTable_IXmlNamespaceResolver_Out_Object = new(this, "TryParseValue", 0, typeof(System.String), typeof(System.Xml.XmlNameTable), typeof(System.Xml.IXmlNamespaceResolver), typeof(System.Object).MakeByRefType());
					r_RTryParseValue_String_XmlNameTable_IXmlNamespaceResolver_Out_Object.SetBelong(this.instance);
				}
				return r_RTryParseValue_String_XmlNameTable_IXmlNamespaceResolver_Out_Object;
			}
		}

		/// <summary>
		/// System.Exception TryParseValue(System.Object, System.Xml.XmlNameTable, System.Xml.IXmlNamespaceResolver, System.Object ByRef)
		/// </summary>
		protected RMethod r_RTryParseValue_Object_XmlNameTable_IXmlNamespaceResolver_Out_Object;
		public virtual RMethod RTryParseValue_Object_XmlNameTable_IXmlNamespaceResolver_Out_Object
		{
			get
			{
				if(r_RTryParseValue_Object_XmlNameTable_IXmlNamespaceResolver_Out_Object == null)
				{
					r_RTryParseValue_Object_XmlNameTable_IXmlNamespaceResolver_Out_Object = new(this, "TryParseValue", 0, typeof(System.Object), typeof(System.Xml.XmlNameTable), typeof(System.Xml.IXmlNamespaceResolver), typeof(System.Object).MakeByRefType());
					r_RTryParseValue_Object_XmlNameTable_IXmlNamespaceResolver_Out_Object.SetBelong(this.instance);
				}
				return r_RTryParseValue_Object_XmlNameTable_IXmlNamespaceResolver_Out_Object;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection, System.Xml.XmlNameTable, System.Xml.Schema.XmlSchemaType)
		/// </summary>
		protected RMethod r_RDeriveByRestriction_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType;
		public virtual RMethod RDeriveByRestriction_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType
		{
			get
			{
				if(r_RDeriveByRestriction_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType == null)
				{
					r_RDeriveByRestriction_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType = new(this, "DeriveByRestriction", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection), typeof(System.Xml.XmlNameTable), typeof(System.Xml.Schema.XmlSchemaType));
					r_RDeriveByRestriction_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType.SetBelong(this.instance);
				}
				return r_RDeriveByRestriction_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType)
		/// </summary>
		protected RMethod r_RDeriveByList_XmlSchemaType;
		public virtual RMethod RDeriveByList_XmlSchemaType
		{
			get
			{
				if(r_RDeriveByList_XmlSchemaType == null)
				{
					r_RDeriveByList_XmlSchemaType = new(this, "DeriveByList", 0, typeof(System.Xml.Schema.XmlSchemaType));
					r_RDeriveByList_XmlSchemaType.SetBelong(this.instance);
				}
				return r_RDeriveByList_XmlSchemaType;
			}
		}

		/// <summary>
		/// Void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable, System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RVerifySchemaValid_XmlSchemaObjectTable_XmlSchemaObject;
		public virtual RMethod RVerifySchemaValid_XmlSchemaObjectTable_XmlSchemaObject
		{
			get
			{
				if(r_RVerifySchemaValid_XmlSchemaObjectTable_XmlSchemaObject == null)
				{
					r_RVerifySchemaValid_XmlSchemaObjectTable_XmlSchemaObject = new(this, "VerifySchemaValid", 0, typeof(System.Xml.Schema.XmlSchemaObjectTable), typeof(System.Xml.Schema.XmlSchemaObject));
					r_RVerifySchemaValid_XmlSchemaObjectTable_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RVerifySchemaValid_XmlSchemaObjectTable_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Boolean IsEqual(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RIsEqual_Object_Object;
		public virtual RMethod RIsEqual_Object_Object
		{
			get
			{
				if(r_RIsEqual_Object_Object == null)
				{
					r_RIsEqual_Object_Object = new(this, "IsEqual", 0, typeof(System.Object), typeof(System.Object));
					r_RIsEqual_Object_Object.SetBelong(this.instance);
				}
				return r_RIsEqual_Object_Object;
			}
		}

		/// <summary>
		/// Boolean IsComparable(System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected RMethod r_RIsComparable_XmlSchemaDatatype;
		public virtual RMethod RIsComparable_XmlSchemaDatatype
		{
			get
			{
				if(r_RIsComparable_XmlSchemaDatatype == null)
				{
					r_RIsComparable_XmlSchemaDatatype = new(this, "IsComparable", 0, typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RIsComparable_XmlSchemaDatatype.SetBelong(this.instance);
				}
				return r_RIsComparable_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// System.String TypeCodeToString(System.Xml.Schema.XmlTypeCode)
		/// </summary>
		protected RMethod r_RTypeCodeToString_XmlTypeCode;
		public virtual RMethod RTypeCodeToString_XmlTypeCode
		{
			get
			{
				if(r_RTypeCodeToString_XmlTypeCode == null)
				{
					r_RTypeCodeToString_XmlTypeCode = new(this, "TypeCodeToString", 0, typeof(System.Xml.Schema.XmlTypeCode));
					r_RTypeCodeToString_XmlTypeCode.SetBelong(this.instance);
				}
				return r_RTypeCodeToString_XmlTypeCode;
			}
		}

		/// <summary>
		/// System.String ConcatenatedToString(System.Object)
		/// </summary>
		protected static RMethod r_RConcatenatedToString_Object;
		public static RMethod RConcatenatedToString_Object
		{
			get
			{
				if(r_RConcatenatedToString_Object == null)
				{
					r_RConcatenatedToString_Object = new(typeof(System.Xml.Schema.XmlSchemaDatatype), "ConcatenatedToString", 0, typeof(System.Object));
					r_RConcatenatedToString_Object.SetBelong(null);
				}
				return r_RConcatenatedToString_Object;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType)
		/// </summary>
		protected static RMethod r_RFromXmlTokenizedType_XmlTokenizedType;
		public static RMethod RFromXmlTokenizedType_XmlTokenizedType
		{
			get
			{
				if(r_RFromXmlTokenizedType_XmlTokenizedType == null)
				{
					r_RFromXmlTokenizedType_XmlTokenizedType = new(typeof(System.Xml.Schema.XmlSchemaDatatype), "FromXmlTokenizedType", 0, typeof(System.Xml.XmlTokenizedType));
					r_RFromXmlTokenizedType_XmlTokenizedType.SetBelong(null);
				}
				return r_RFromXmlTokenizedType_XmlTokenizedType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType)
		/// </summary>
		protected static RMethod r_RFromXmlTokenizedTypeXsd_XmlTokenizedType;
		public static RMethod RFromXmlTokenizedTypeXsd_XmlTokenizedType
		{
			get
			{
				if(r_RFromXmlTokenizedTypeXsd_XmlTokenizedType == null)
				{
					r_RFromXmlTokenizedTypeXsd_XmlTokenizedType = new(typeof(System.Xml.Schema.XmlSchemaDatatype), "FromXmlTokenizedTypeXsd", 0, typeof(System.Xml.XmlTokenizedType));
					r_RFromXmlTokenizedTypeXsd_XmlTokenizedType.SetBelong(null);
				}
				return r_RFromXmlTokenizedTypeXsd_XmlTokenizedType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype FromXdrName(System.String)
		/// </summary>
		protected static RMethod r_RFromXdrName_String;
		public static RMethod RFromXdrName_String
		{
			get
			{
				if(r_RFromXdrName_String == null)
				{
					r_RFromXdrName_String = new(typeof(System.Xml.Schema.XmlSchemaDatatype), "FromXdrName", 0, typeof(System.String));
					r_RFromXdrName_String.SetBelong(null);
				}
				return r_RFromXdrName_String;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[], System.Xml.Schema.XmlSchemaType)
		/// </summary>
		protected static RMethod r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType;
		public static RMethod RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType
		{
			get
			{
				if(r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType == null)
				{
					r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType = new(typeof(System.Xml.Schema.XmlSchemaDatatype), "DeriveByUnion", 0, typeof(System.Xml.Schema.XmlSchemaSimpleType).MakeArrayType(), typeof(System.Xml.Schema.XmlSchemaType));
					r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType.SetBelong(null);
				}
				return r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType;
			}
		}

		/// <summary>
		/// System.String XdrCanonizeUri(System.String, System.Xml.XmlNameTable, System.Xml.Schema.SchemaNames)
		/// </summary>
		protected static RMethod r_RXdrCanonizeUri_String_XmlNameTable_SchemaNames;
		public static RMethod RXdrCanonizeUri_String_XmlNameTable_SchemaNames
		{
			get
			{
				if(r_RXdrCanonizeUri_String_XmlNameTable_SchemaNames == null)
				{
					r_RXdrCanonizeUri_String_XmlNameTable_SchemaNames = new(typeof(System.Xml.Schema.XmlSchemaDatatype), "XdrCanonizeUri", 0, typeof(System.String), typeof(System.Xml.XmlNameTable),  ReleactionUtils.GetType("System.Xml.Schema.SchemaNames"));
					r_RXdrCanonizeUri_String_XmlNameTable_SchemaNames.SetBelong(null);
				}
				return r_RXdrCanonizeUri_String_XmlNameTable_SchemaNames;
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


        public RXmlSchemaDatatype() : base("System.Xml.Schema.XmlSchemaDatatype")
        {
        }

        public RXmlSchemaDatatype(System.Object instance) : base("System.Xml.Schema.XmlSchemaDatatype")
		{
            SetInstance(instance);
		}

        public RXmlSchemaDatatype(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaDatatype(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object ParseValue(System.String  @s, System.Xml.XmlNameTable  @nameTable, System.Xml.IXmlNamespaceResolver  @nsmgr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @nameTable, @nsmgr};
            var ___result = RParseValue_String_XmlNameTable_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Object  @value, System.Type  @targetType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @targetType};
            var ___result = RChangeType_Object_Type.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ChangeType(System.Object  @value, System.Type  @targetType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @targetType, @namespaceResolver};
            var ___result = RChangeType_Object_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@datatype};
            var ___result = RIsDerivedFrom_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 Compare(System.Object  @value1, System.Object  @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = RCompare_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object ParseValue(System.String  @s, System.Type  @typDest, System.Xml.XmlNameTable  @nameTable, System.Xml.IXmlNamespaceResolver  @nsmgr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @typDest, @nameTable, @nsmgr};
            var ___result = RParseValue_String_Type_XmlNameTable_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ParseValue(System.String  @s, System.Xml.XmlNameTable  @nameTable, System.Xml.IXmlNamespaceResolver  @nsmgr, System.Boolean  @createAtomicValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @nameTable, @nsmgr, @createAtomicValue};
            var ___result = RParseValue_String_XmlNameTable_IXmlNamespaceResolver_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Exception TryParseValue(System.String  @s, System.Xml.XmlNameTable  @nameTable, System.Xml.IXmlNamespaceResolver  @nsmgr, out System.Object  @typedValue)
        {
			typedValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @nameTable, @nsmgr, @typedValue};
            var ___result = RTryParseValue_String_XmlNameTable_IXmlNamespaceResolver_Out_Object.Invoke(___genericsType, ___parameters);
			typedValue = (System.Object)___parameters[3];

            return (System.Exception)___result;
        }


        public virtual System.Exception TryParseValue(System.Object  @value, System.Xml.XmlNameTable  @nameTable, System.Xml.IXmlNamespaceResolver  @namespaceResolver, out System.Object  @typedValue)
        {
			typedValue = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @nameTable, @namespaceResolver, @typedValue};
            var ___result = RTryParseValue_Object_XmlNameTable_IXmlNamespaceResolver_Out_Object.Invoke(___genericsType, ___parameters);
			typedValue = (System.Object)___parameters[3];

            return (System.Exception)___result;
        }


        public virtual System.Xml.Schema.XmlSchemaDatatype DeriveByRestriction(System.Xml.Schema.XmlSchemaObjectCollection  @facets, System.Xml.XmlNameTable  @nameTable, System.Xml.Schema.XmlSchemaType  @schemaType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@facets, @nameTable, @schemaType};
            var ___result = RDeriveByRestriction_XmlSchemaObjectCollection_XmlNameTable_XmlSchemaType.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaDatatype)___result;
        }


        public virtual System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Xml.Schema.XmlSchemaType  @schemaType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemaType};
            var ___result = RDeriveByList_XmlSchemaType.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaDatatype)___result;
        }


        public virtual void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable  @notations, System.Xml.Schema.XmlSchemaObject  @caller)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notations, @caller};
            var ___result = RVerifySchemaValid_XmlSchemaObjectTable_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsEqual(System.Object  @o1, System.Object  @o2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o1, @o2};
            var ___result = RIsEqual_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsComparable(System.Xml.Schema.XmlSchemaDatatype  @dtype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dtype};
            var ___result = RIsComparable_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String TypeCodeToString(System.Xml.Schema.XmlTypeCode  @typeCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeCode};
            var ___result = RTypeCodeToString_XmlTypeCode.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String ConcatenatedToString(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RConcatenatedToString_Object.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedType(System.Xml.XmlTokenizedType  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RFromXmlTokenizedType_XmlTokenizedType.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaDatatype)___result;
        }


        public static System.Xml.Schema.XmlSchemaDatatype FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RFromXmlTokenizedTypeXsd_XmlTokenizedType.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaDatatype)___result;
        }


        public static System.Xml.Schema.XmlSchemaDatatype FromXdrName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFromXdrName_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaDatatype)___result;
        }


        public static System.Xml.Schema.XmlSchemaDatatype DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[]  @types, System.Xml.Schema.XmlSchemaType  @schemaType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types, @schemaType};
            var ___result = RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaDatatype)___result;
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
