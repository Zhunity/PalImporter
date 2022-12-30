using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.DatatypeImplementation
	/// </summary>
    public partial class RDatatypeImplementation : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatypeVariety variety
		/// </summary>
		protected RField r_variety;
		public virtual RField Rvariety
		{
			get
			{
				if(r_variety == null)
				{
					r_variety = new(this, "variety");
					r_variety.SetBelong(this.instance);
				}
				return r_variety;
			}
		}

		/// <summary>
		/// System.Xml.Schema.RestrictionFacets restriction
		/// </summary>
		protected RSystem.RXml.RSchema.RRestrictionFacets r_restriction;
		public virtual RSystem.RXml.RSchema.RRestrictionFacets Rrestriction
		{
			get
			{
				if(r_restriction == null)
				{
					r_restriction = new(this, "restriction");
					r_restriction.SetBelong(this.instance);
				}
				return r_restriction;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation baseType
		/// </summary>
		protected RSystem.RXml.RSchema.RDatatypeImplementation r_baseType;
		public virtual RSystem.RXml.RSchema.RDatatypeImplementation RbaseType
		{
			get
			{
				if(r_baseType == null)
				{
					r_baseType = new(this, "baseType");
					r_baseType.SetBelong(this.instance);
				}
				return r_baseType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlValueConverter valueConverter
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlValueConverter r_valueConverter;
		public virtual RSystem.RXml.RSchema.RXmlValueConverter RvalueConverter
		{
			get
			{
				if(r_valueConverter == null)
				{
					r_valueConverter = new(this, "valueConverter");
					r_valueConverter.SetBelong(this.instance);
				}
				return r_valueConverter;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType parentSchemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_parentSchemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RparentSchemaType
		{
			get
			{
				if(r_parentSchemaType == null)
				{
					r_parentSchemaType = new(this, "parentSchemaType");
					r_parentSchemaType.SetBelong(this.instance);
				}
				return r_parentSchemaType;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable builtinTypes
		/// </summary>
		protected static RSystem.RCollections.RHashtable r_builtinTypes;
		public static RSystem.RCollections.RHashtable RbuiltinTypes
		{
			get
			{
				if(r_builtinTypes == null)
				{
					r_builtinTypes = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "builtinTypes");
					r_builtinTypes.SetBelong(null);
				}
				return r_builtinTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType[] enumToTypeCode
		/// </summary>
		protected static RFieldArray<RSystem.RXml.RSchema.RXmlSchemaSimpleType> r_enumToTypeCode;
		public static RFieldArray<RSystem.RXml.RSchema.RXmlSchemaSimpleType> RenumToTypeCode
		{
			get
			{
				if(r_enumToTypeCode == null)
				{
					r_enumToTypeCode = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "enumToTypeCode");
					r_enumToTypeCode.SetBelong(null);
				}
				return r_enumToTypeCode;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType anySimpleType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_anySimpleType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RanySimpleType
		{
			get
			{
				if(r_anySimpleType == null)
				{
					r_anySimpleType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "anySimpleType");
					r_anySimpleType.SetBelong(null);
				}
				return r_anySimpleType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType anyAtomicType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_anyAtomicType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RanyAtomicType
		{
			get
			{
				if(r_anyAtomicType == null)
				{
					r_anyAtomicType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "anyAtomicType");
					r_anyAtomicType.SetBelong(null);
				}
				return r_anyAtomicType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType untypedAtomicType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_untypedAtomicType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RuntypedAtomicType
		{
			get
			{
				if(r_untypedAtomicType == null)
				{
					r_untypedAtomicType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "untypedAtomicType");
					r_untypedAtomicType.SetBelong(null);
				}
				return r_untypedAtomicType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType yearMonthDurationType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_yearMonthDurationType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RyearMonthDurationType
		{
			get
			{
				if(r_yearMonthDurationType == null)
				{
					r_yearMonthDurationType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "yearMonthDurationType");
					r_yearMonthDurationType.SetBelong(null);
				}
				return r_yearMonthDurationType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType dayTimeDurationType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_dayTimeDurationType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RdayTimeDurationType
		{
			get
			{
				if(r_dayTimeDurationType == null)
				{
					r_dayTimeDurationType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "dayTimeDurationType");
					r_dayTimeDurationType.SetBelong(null);
				}
				return r_dayTimeDurationType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType normalizedStringTypeV1Compat
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_normalizedStringTypeV1Compat;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RnormalizedStringTypeV1Compat
		{
			get
			{
				if(r_normalizedStringTypeV1Compat == null)
				{
					r_normalizedStringTypeV1Compat = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "normalizedStringTypeV1Compat");
					r_normalizedStringTypeV1Compat.SetBelong(null);
				}
				return r_normalizedStringTypeV1Compat;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType tokenTypeV1Compat
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_tokenTypeV1Compat;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RtokenTypeV1Compat
		{
			get
			{
				if(r_tokenTypeV1Compat == null)
				{
					r_tokenTypeV1Compat = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "tokenTypeV1Compat");
					r_tokenTypeV1Compat.SetBelong(null);
				}
				return r_tokenTypeV1Compat;
			}
		}

		/// <summary>
		/// System.Int32 anySimpleTypeIndex
		/// </summary>
		protected static RField r_anySimpleTypeIndex;
		public static RField RanySimpleTypeIndex
		{
			get
			{
				if(r_anySimpleTypeIndex == null)
				{
					r_anySimpleTypeIndex = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "anySimpleTypeIndex");
					r_anySimpleTypeIndex.SetBelong(null);
				}
				return r_anySimpleTypeIndex;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnAnySimpleType
		/// </summary>
		protected static RSystem.RXml.RXmlQualifiedName r_QnAnySimpleType;
		public static RSystem.RXml.RXmlQualifiedName RQnAnySimpleType
		{
			get
			{
				if(r_QnAnySimpleType == null)
				{
					r_QnAnySimpleType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "QnAnySimpleType");
					r_QnAnySimpleType.SetBelong(null);
				}
				return r_QnAnySimpleType;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QnAnyType
		/// </summary>
		protected static RSystem.RXml.RXmlQualifiedName r_QnAnyType;
		public static RSystem.RXml.RXmlQualifiedName RQnAnyType
		{
			get
			{
				if(r_QnAnyType == null)
				{
					r_QnAnyType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "QnAnyType");
					r_QnAnyType.SetBelong(null);
				}
				return r_QnAnyType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker stringFacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_stringFacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker RstringFacetsChecker
		{
			get
			{
				if(r_stringFacetsChecker == null)
				{
					r_stringFacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "stringFacetsChecker");
					r_stringFacetsChecker.SetBelong(null);
				}
				return r_stringFacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker miscFacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_miscFacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker RmiscFacetsChecker
		{
			get
			{
				if(r_miscFacetsChecker == null)
				{
					r_miscFacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "miscFacetsChecker");
					r_miscFacetsChecker.SetBelong(null);
				}
				return r_miscFacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker numeric2FacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_numeric2FacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker Rnumeric2FacetsChecker
		{
			get
			{
				if(r_numeric2FacetsChecker == null)
				{
					r_numeric2FacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "numeric2FacetsChecker");
					r_numeric2FacetsChecker.SetBelong(null);
				}
				return r_numeric2FacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker binaryFacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_binaryFacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker RbinaryFacetsChecker
		{
			get
			{
				if(r_binaryFacetsChecker == null)
				{
					r_binaryFacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "binaryFacetsChecker");
					r_binaryFacetsChecker.SetBelong(null);
				}
				return r_binaryFacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker dateTimeFacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_dateTimeFacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker RdateTimeFacetsChecker
		{
			get
			{
				if(r_dateTimeFacetsChecker == null)
				{
					r_dateTimeFacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "dateTimeFacetsChecker");
					r_dateTimeFacetsChecker.SetBelong(null);
				}
				return r_dateTimeFacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker durationFacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_durationFacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker RdurationFacetsChecker
		{
			get
			{
				if(r_durationFacetsChecker == null)
				{
					r_durationFacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "durationFacetsChecker");
					r_durationFacetsChecker.SetBelong(null);
				}
				return r_durationFacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker listFacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_listFacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker RlistFacetsChecker
		{
			get
			{
				if(r_listFacetsChecker == null)
				{
					r_listFacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "listFacetsChecker");
					r_listFacetsChecker.SetBelong(null);
				}
				return r_listFacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker qnameFacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_qnameFacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker RqnameFacetsChecker
		{
			get
			{
				if(r_qnameFacetsChecker == null)
				{
					r_qnameFacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "qnameFacetsChecker");
					r_qnameFacetsChecker.SetBelong(null);
				}
				return r_qnameFacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.FacetsChecker unionFacetsChecker
		/// </summary>
		protected static RSystem.RXml.RSchema.RFacetsChecker r_unionFacetsChecker;
		public static RSystem.RXml.RSchema.RFacetsChecker RunionFacetsChecker
		{
			get
			{
				if(r_unionFacetsChecker == null)
				{
					r_unionFacetsChecker = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "unionFacetsChecker");
					r_unionFacetsChecker.SetBelong(null);
				}
				return r_unionFacetsChecker;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_anySimpleType
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_anySimpleType;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_anySimpleType
		{
			get
			{
				if(r_c_anySimpleType == null)
				{
					r_c_anySimpleType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_anySimpleType");
					r_c_anySimpleType.SetBelong(null);
				}
				return r_c_anySimpleType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_anyURI
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_anyURI;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_anyURI
		{
			get
			{
				if(r_c_anyURI == null)
				{
					r_c_anyURI = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_anyURI");
					r_c_anyURI.SetBelong(null);
				}
				return r_c_anyURI;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_base64Binary
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_base64Binary;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_base64Binary
		{
			get
			{
				if(r_c_base64Binary == null)
				{
					r_c_base64Binary = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_base64Binary");
					r_c_base64Binary.SetBelong(null);
				}
				return r_c_base64Binary;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_boolean
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_boolean;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_boolean
		{
			get
			{
				if(r_c_boolean == null)
				{
					r_c_boolean = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_boolean");
					r_c_boolean.SetBelong(null);
				}
				return r_c_boolean;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_byte
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_byte;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_byte
		{
			get
			{
				if(r_c_byte == null)
				{
					r_c_byte = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_byte");
					r_c_byte.SetBelong(null);
				}
				return r_c_byte;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_char
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_char;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_char
		{
			get
			{
				if(r_c_char == null)
				{
					r_c_char = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_char");
					r_c_char.SetBelong(null);
				}
				return r_c_char;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_date
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_date;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_date
		{
			get
			{
				if(r_c_date == null)
				{
					r_c_date = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_date");
					r_c_date.SetBelong(null);
				}
				return r_c_date;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_dateTime
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_dateTime;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_dateTime
		{
			get
			{
				if(r_c_dateTime == null)
				{
					r_c_dateTime = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_dateTime");
					r_c_dateTime.SetBelong(null);
				}
				return r_c_dateTime;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_dateTimeNoTz
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_dateTimeNoTz;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_dateTimeNoTz
		{
			get
			{
				if(r_c_dateTimeNoTz == null)
				{
					r_c_dateTimeNoTz = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_dateTimeNoTz");
					r_c_dateTimeNoTz.SetBelong(null);
				}
				return r_c_dateTimeNoTz;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_dateTimeTz
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_dateTimeTz;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_dateTimeTz
		{
			get
			{
				if(r_c_dateTimeTz == null)
				{
					r_c_dateTimeTz = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_dateTimeTz");
					r_c_dateTimeTz.SetBelong(null);
				}
				return r_c_dateTimeTz;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_day
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_day;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_day
		{
			get
			{
				if(r_c_day == null)
				{
					r_c_day = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_day");
					r_c_day.SetBelong(null);
				}
				return r_c_day;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_decimal
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_decimal;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_decimal
		{
			get
			{
				if(r_c_decimal == null)
				{
					r_c_decimal = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_decimal");
					r_c_decimal.SetBelong(null);
				}
				return r_c_decimal;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_double
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_double;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_double
		{
			get
			{
				if(r_c_double == null)
				{
					r_c_double = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_double");
					r_c_double.SetBelong(null);
				}
				return r_c_double;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_doubleXdr
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_doubleXdr;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_doubleXdr
		{
			get
			{
				if(r_c_doubleXdr == null)
				{
					r_c_doubleXdr = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_doubleXdr");
					r_c_doubleXdr.SetBelong(null);
				}
				return r_c_doubleXdr;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_duration
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_duration;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_duration
		{
			get
			{
				if(r_c_duration == null)
				{
					r_c_duration = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_duration");
					r_c_duration.SetBelong(null);
				}
				return r_c_duration;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_ENTITY
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_ENTITY;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_ENTITY
		{
			get
			{
				if(r_c_ENTITY == null)
				{
					r_c_ENTITY = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_ENTITY");
					r_c_ENTITY.SetBelong(null);
				}
				return r_c_ENTITY;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_ENTITIES
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_ENTITIES;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_ENTITIES
		{
			get
			{
				if(r_c_ENTITIES == null)
				{
					r_c_ENTITIES = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_ENTITIES");
					r_c_ENTITIES.SetBelong(null);
				}
				return r_c_ENTITIES;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_ENUMERATION
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_ENUMERATION;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_ENUMERATION
		{
			get
			{
				if(r_c_ENUMERATION == null)
				{
					r_c_ENUMERATION = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_ENUMERATION");
					r_c_ENUMERATION.SetBelong(null);
				}
				return r_c_ENUMERATION;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_fixed
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_fixed;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_fixed
		{
			get
			{
				if(r_c_fixed == null)
				{
					r_c_fixed = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_fixed");
					r_c_fixed.SetBelong(null);
				}
				return r_c_fixed;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_float
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_float;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_float
		{
			get
			{
				if(r_c_float == null)
				{
					r_c_float = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_float");
					r_c_float.SetBelong(null);
				}
				return r_c_float;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_floatXdr
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_floatXdr;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_floatXdr
		{
			get
			{
				if(r_c_floatXdr == null)
				{
					r_c_floatXdr = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_floatXdr");
					r_c_floatXdr.SetBelong(null);
				}
				return r_c_floatXdr;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_hexBinary
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_hexBinary;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_hexBinary
		{
			get
			{
				if(r_c_hexBinary == null)
				{
					r_c_hexBinary = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_hexBinary");
					r_c_hexBinary.SetBelong(null);
				}
				return r_c_hexBinary;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_ID
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_ID;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_ID
		{
			get
			{
				if(r_c_ID == null)
				{
					r_c_ID = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_ID");
					r_c_ID.SetBelong(null);
				}
				return r_c_ID;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_IDREF
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_IDREF;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_IDREF
		{
			get
			{
				if(r_c_IDREF == null)
				{
					r_c_IDREF = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_IDREF");
					r_c_IDREF.SetBelong(null);
				}
				return r_c_IDREF;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_IDREFS
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_IDREFS;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_IDREFS
		{
			get
			{
				if(r_c_IDREFS == null)
				{
					r_c_IDREFS = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_IDREFS");
					r_c_IDREFS.SetBelong(null);
				}
				return r_c_IDREFS;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_int
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_int;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_int
		{
			get
			{
				if(r_c_int == null)
				{
					r_c_int = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_int");
					r_c_int.SetBelong(null);
				}
				return r_c_int;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_integer
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_integer;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_integer
		{
			get
			{
				if(r_c_integer == null)
				{
					r_c_integer = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_integer");
					r_c_integer.SetBelong(null);
				}
				return r_c_integer;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_language
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_language;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_language
		{
			get
			{
				if(r_c_language == null)
				{
					r_c_language = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_language");
					r_c_language.SetBelong(null);
				}
				return r_c_language;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_long
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_long;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_long
		{
			get
			{
				if(r_c_long == null)
				{
					r_c_long = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_long");
					r_c_long.SetBelong(null);
				}
				return r_c_long;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_month
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_month;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_month
		{
			get
			{
				if(r_c_month == null)
				{
					r_c_month = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_month");
					r_c_month.SetBelong(null);
				}
				return r_c_month;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_monthDay
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_monthDay;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_monthDay
		{
			get
			{
				if(r_c_monthDay == null)
				{
					r_c_monthDay = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_monthDay");
					r_c_monthDay.SetBelong(null);
				}
				return r_c_monthDay;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_Name
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_Name;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_Name
		{
			get
			{
				if(r_c_Name == null)
				{
					r_c_Name = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_Name");
					r_c_Name.SetBelong(null);
				}
				return r_c_Name;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_NCName
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_NCName;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_NCName
		{
			get
			{
				if(r_c_NCName == null)
				{
					r_c_NCName = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_NCName");
					r_c_NCName.SetBelong(null);
				}
				return r_c_NCName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_negativeInteger
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_negativeInteger;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_negativeInteger
		{
			get
			{
				if(r_c_negativeInteger == null)
				{
					r_c_negativeInteger = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_negativeInteger");
					r_c_negativeInteger.SetBelong(null);
				}
				return r_c_negativeInteger;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_NMTOKEN
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_NMTOKEN;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_NMTOKEN
		{
			get
			{
				if(r_c_NMTOKEN == null)
				{
					r_c_NMTOKEN = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_NMTOKEN");
					r_c_NMTOKEN.SetBelong(null);
				}
				return r_c_NMTOKEN;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_NMTOKENS
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_NMTOKENS;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_NMTOKENS
		{
			get
			{
				if(r_c_NMTOKENS == null)
				{
					r_c_NMTOKENS = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_NMTOKENS");
					r_c_NMTOKENS.SetBelong(null);
				}
				return r_c_NMTOKENS;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_nonNegativeInteger
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_nonNegativeInteger;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_nonNegativeInteger
		{
			get
			{
				if(r_c_nonNegativeInteger == null)
				{
					r_c_nonNegativeInteger = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_nonNegativeInteger");
					r_c_nonNegativeInteger.SetBelong(null);
				}
				return r_c_nonNegativeInteger;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_nonPositiveInteger
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_nonPositiveInteger;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_nonPositiveInteger
		{
			get
			{
				if(r_c_nonPositiveInteger == null)
				{
					r_c_nonPositiveInteger = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_nonPositiveInteger");
					r_c_nonPositiveInteger.SetBelong(null);
				}
				return r_c_nonPositiveInteger;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_normalizedString
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_normalizedString;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_normalizedString
		{
			get
			{
				if(r_c_normalizedString == null)
				{
					r_c_normalizedString = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_normalizedString");
					r_c_normalizedString.SetBelong(null);
				}
				return r_c_normalizedString;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_NOTATION
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_NOTATION;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_NOTATION
		{
			get
			{
				if(r_c_NOTATION == null)
				{
					r_c_NOTATION = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_NOTATION");
					r_c_NOTATION.SetBelong(null);
				}
				return r_c_NOTATION;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_positiveInteger
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_positiveInteger;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_positiveInteger
		{
			get
			{
				if(r_c_positiveInteger == null)
				{
					r_c_positiveInteger = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_positiveInteger");
					r_c_positiveInteger.SetBelong(null);
				}
				return r_c_positiveInteger;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_QName
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_QName;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_QName
		{
			get
			{
				if(r_c_QName == null)
				{
					r_c_QName = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_QName");
					r_c_QName.SetBelong(null);
				}
				return r_c_QName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_QNameXdr
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_QNameXdr;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_QNameXdr
		{
			get
			{
				if(r_c_QNameXdr == null)
				{
					r_c_QNameXdr = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_QNameXdr");
					r_c_QNameXdr.SetBelong(null);
				}
				return r_c_QNameXdr;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_short
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_short;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_short
		{
			get
			{
				if(r_c_short == null)
				{
					r_c_short = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_short");
					r_c_short.SetBelong(null);
				}
				return r_c_short;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_string
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_string;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_string
		{
			get
			{
				if(r_c_string == null)
				{
					r_c_string = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_string");
					r_c_string.SetBelong(null);
				}
				return r_c_string;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_time
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_time;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_time
		{
			get
			{
				if(r_c_time == null)
				{
					r_c_time = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_time");
					r_c_time.SetBelong(null);
				}
				return r_c_time;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_timeNoTz
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_timeNoTz;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_timeNoTz
		{
			get
			{
				if(r_c_timeNoTz == null)
				{
					r_c_timeNoTz = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_timeNoTz");
					r_c_timeNoTz.SetBelong(null);
				}
				return r_c_timeNoTz;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_timeTz
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_timeTz;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_timeTz
		{
			get
			{
				if(r_c_timeTz == null)
				{
					r_c_timeTz = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_timeTz");
					r_c_timeTz.SetBelong(null);
				}
				return r_c_timeTz;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_token
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_token;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_token
		{
			get
			{
				if(r_c_token == null)
				{
					r_c_token = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_token");
					r_c_token.SetBelong(null);
				}
				return r_c_token;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_unsignedByte
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_unsignedByte;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_unsignedByte
		{
			get
			{
				if(r_c_unsignedByte == null)
				{
					r_c_unsignedByte = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_unsignedByte");
					r_c_unsignedByte.SetBelong(null);
				}
				return r_c_unsignedByte;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_unsignedInt
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_unsignedInt;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_unsignedInt
		{
			get
			{
				if(r_c_unsignedInt == null)
				{
					r_c_unsignedInt = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_unsignedInt");
					r_c_unsignedInt.SetBelong(null);
				}
				return r_c_unsignedInt;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_unsignedLong
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_unsignedLong;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_unsignedLong
		{
			get
			{
				if(r_c_unsignedLong == null)
				{
					r_c_unsignedLong = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_unsignedLong");
					r_c_unsignedLong.SetBelong(null);
				}
				return r_c_unsignedLong;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_unsignedShort
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_unsignedShort;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_unsignedShort
		{
			get
			{
				if(r_c_unsignedShort == null)
				{
					r_c_unsignedShort = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_unsignedShort");
					r_c_unsignedShort.SetBelong(null);
				}
				return r_c_unsignedShort;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_uuid
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_uuid;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_uuid
		{
			get
			{
				if(r_c_uuid == null)
				{
					r_c_uuid = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_uuid");
					r_c_uuid.SetBelong(null);
				}
				return r_c_uuid;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_year
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_year;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_year
		{
			get
			{
				if(r_c_year == null)
				{
					r_c_year = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_year");
					r_c_year.SetBelong(null);
				}
				return r_c_year;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_yearMonth
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_yearMonth;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_yearMonth
		{
			get
			{
				if(r_c_yearMonth == null)
				{
					r_c_yearMonth = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_yearMonth");
					r_c_yearMonth.SetBelong(null);
				}
				return r_c_yearMonth;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_normalizedStringV1Compat
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_normalizedStringV1Compat;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_normalizedStringV1Compat
		{
			get
			{
				if(r_c_normalizedStringV1Compat == null)
				{
					r_c_normalizedStringV1Compat = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_normalizedStringV1Compat");
					r_c_normalizedStringV1Compat.SetBelong(null);
				}
				return r_c_normalizedStringV1Compat;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_tokenV1Compat
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_tokenV1Compat;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_tokenV1Compat
		{
			get
			{
				if(r_c_tokenV1Compat == null)
				{
					r_c_tokenV1Compat = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_tokenV1Compat");
					r_c_tokenV1Compat.SetBelong(null);
				}
				return r_c_tokenV1Compat;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_anyAtomicType
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_anyAtomicType;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_anyAtomicType
		{
			get
			{
				if(r_c_anyAtomicType == null)
				{
					r_c_anyAtomicType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_anyAtomicType");
					r_c_anyAtomicType.SetBelong(null);
				}
				return r_c_anyAtomicType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_dayTimeDuration
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_dayTimeDuration;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_dayTimeDuration
		{
			get
			{
				if(r_c_dayTimeDuration == null)
				{
					r_c_dayTimeDuration = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_dayTimeDuration");
					r_c_dayTimeDuration.SetBelong(null);
				}
				return r_c_dayTimeDuration;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_untypedAtomicType
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_untypedAtomicType;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_untypedAtomicType
		{
			get
			{
				if(r_c_untypedAtomicType == null)
				{
					r_c_untypedAtomicType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_untypedAtomicType");
					r_c_untypedAtomicType.SetBelong(null);
				}
				return r_c_untypedAtomicType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation c_yearMonthDuration
		/// </summary>
		protected static RSystem.RXml.RSchema.RDatatypeImplementation r_c_yearMonthDuration;
		public static RSystem.RXml.RSchema.RDatatypeImplementation Rc_yearMonthDuration
		{
			get
			{
				if(r_c_yearMonthDuration == null)
				{
					r_c_yearMonthDuration = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_yearMonthDuration");
					r_c_yearMonthDuration.SetBelong(null);
				}
				return r_c_yearMonthDuration;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypes
		/// </summary>
		protected static RFieldArray<RSystem.RXml.RSchema.RDatatypeImplementation> r_c_tokenizedTypes;
		public static RFieldArray<RSystem.RXml.RSchema.RDatatypeImplementation> Rc_tokenizedTypes
		{
			get
			{
				if(r_c_tokenizedTypes == null)
				{
					r_c_tokenizedTypes = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_tokenizedTypes");
					r_c_tokenizedTypes.SetBelong(null);
				}
				return r_c_tokenizedTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation[] c_tokenizedTypesXsd
		/// </summary>
		protected static RFieldArray<RSystem.RXml.RSchema.RDatatypeImplementation> r_c_tokenizedTypesXsd;
		public static RFieldArray<RSystem.RXml.RSchema.RDatatypeImplementation> Rc_tokenizedTypesXsd
		{
			get
			{
				if(r_c_tokenizedTypesXsd == null)
				{
					r_c_tokenizedTypesXsd = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_tokenizedTypesXsd");
					r_c_tokenizedTypesXsd.SetBelong(null);
				}
				return r_c_tokenizedTypesXsd;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation+SchemaDatatypeMap[] c_XdrTypes
		/// </summary>
		protected static RFieldArray<RSystem.RXml.RSchema.RDatatypeImplementation.RSchemaDatatypeMap> r_c_XdrTypes;
		public static RFieldArray<RSystem.RXml.RSchema.RDatatypeImplementation.RSchemaDatatypeMap> Rc_XdrTypes
		{
			get
			{
				if(r_c_XdrTypes == null)
				{
					r_c_XdrTypes = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_XdrTypes");
					r_c_XdrTypes.SetBelong(null);
				}
				return r_c_XdrTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation+SchemaDatatypeMap[] c_XsdTypes
		/// </summary>
		protected static RFieldArray<RSystem.RXml.RSchema.RDatatypeImplementation.RSchemaDatatypeMap> r_c_XsdTypes;
		public static RFieldArray<RSystem.RXml.RSchema.RDatatypeImplementation.RSchemaDatatypeMap> Rc_XsdTypes
		{
			get
			{
				if(r_c_XsdTypes == null)
				{
					r_c_XsdTypes = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "c_XsdTypes");
					r_c_XsdTypes.SetBelong(null);
				}
				return r_c_XsdTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType AnySimpleType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_AnySimpleType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RAnySimpleType
		{
			get
			{
				if(r_AnySimpleType == null)
				{
					r_AnySimpleType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "AnySimpleType", -1);
					r_AnySimpleType.SetBelong(null);
				}
				return r_AnySimpleType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType AnyAtomicType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_AnyAtomicType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RAnyAtomicType
		{
			get
			{
				if(r_AnyAtomicType == null)
				{
					r_AnyAtomicType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "AnyAtomicType", -1);
					r_AnyAtomicType.SetBelong(null);
				}
				return r_AnyAtomicType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType UntypedAtomicType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_UntypedAtomicType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RUntypedAtomicType
		{
			get
			{
				if(r_UntypedAtomicType == null)
				{
					r_UntypedAtomicType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "UntypedAtomicType", -1);
					r_UntypedAtomicType.SetBelong(null);
				}
				return r_UntypedAtomicType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType YearMonthDurationType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_YearMonthDurationType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RYearMonthDurationType
		{
			get
			{
				if(r_YearMonthDurationType == null)
				{
					r_YearMonthDurationType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "YearMonthDurationType", -1);
					r_YearMonthDurationType.SetBelong(null);
				}
				return r_YearMonthDurationType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType DayTimeDurationType
		/// </summary>
		protected static RSystem.RXml.RSchema.RXmlSchemaSimpleType r_DayTimeDurationType;
		public static RSystem.RXml.RSchema.RXmlSchemaSimpleType RDayTimeDurationType
		{
			get
			{
				if(r_DayTimeDurationType == null)
				{
					r_DayTimeDurationType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "DayTimeDurationType", -1);
					r_DayTimeDurationType.SetBelong(null);
				}
				return r_DayTimeDurationType;
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
		/// System.Xml.Schema.DatatypeImplementation Base
		/// </summary>
		protected RSystem.RXml.RSchema.RDatatypeImplementation r_Base;
		public virtual RSystem.RXml.RSchema.RDatatypeImplementation RBase
		{
			get
			{
				if(r_Base == null)
				{
					r_Base = new(this, "Base", -1);
					r_Base.SetBelong(this.instance);
				}
				return r_Base;
			}
		}

		/// <summary>
		/// System.Type ListValueType
		/// </summary>
		protected RSystem.RType r_ListValueType;
		public virtual RSystem.RType RListValueType
		{
			get
			{
				if(r_ListValueType == null)
				{
					r_ListValueType = new(this, "ListValueType", -1);
					r_ListValueType.SetBelong(this.instance);
				}
				return r_ListValueType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.RestrictionFlags ValidRestrictionFlags
		/// </summary>
		protected RProperty r_ValidRestrictionFlags;
		public virtual RProperty RValidRestrictionFlags
		{
			get
			{
				if(r_ValidRestrictionFlags == null)
				{
					r_ValidRestrictionFlags = new(this, "ValidRestrictionFlags", -1);
					r_ValidRestrictionFlags.SetBelong(this.instance);
				}
				return r_ValidRestrictionFlags;
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
		/// System.Xml.Schema.DatatypeImplementation FromXmlTokenizedType(System.Xml.XmlTokenizedType)
		/// </summary>
		protected static RMethod r_RFromXmlTokenizedType_XmlTokenizedType;
		public static RMethod RFromXmlTokenizedType_XmlTokenizedType
		{
			get
			{
				if(r_RFromXmlTokenizedType_XmlTokenizedType == null)
				{
					r_RFromXmlTokenizedType_XmlTokenizedType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "FromXmlTokenizedType", 0, typeof(System.Xml.XmlTokenizedType));
					r_RFromXmlTokenizedType_XmlTokenizedType.SetBelong(null);
				}
				return r_RFromXmlTokenizedType_XmlTokenizedType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType)
		/// </summary>
		protected static RMethod r_RFromXmlTokenizedTypeXsd_XmlTokenizedType;
		public static RMethod RFromXmlTokenizedTypeXsd_XmlTokenizedType
		{
			get
			{
				if(r_RFromXmlTokenizedTypeXsd_XmlTokenizedType == null)
				{
					r_RFromXmlTokenizedTypeXsd_XmlTokenizedType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "FromXmlTokenizedTypeXsd", 0, typeof(System.Xml.XmlTokenizedType));
					r_RFromXmlTokenizedTypeXsd_XmlTokenizedType.SetBelong(null);
				}
				return r_RFromXmlTokenizedTypeXsd_XmlTokenizedType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation FromXdrName(System.String)
		/// </summary>
		protected static RMethod r_RFromXdrName_String;
		public static RMethod RFromXdrName_String
		{
			get
			{
				if(r_RFromXdrName_String == null)
				{
					r_RFromXdrName_String = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "FromXdrName", 0, typeof(System.String));
					r_RFromXdrName_String.SetBelong(null);
				}
				return r_RFromXdrName_String;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation FromTypeName(System.String)
		/// </summary>
		protected static RMethod r_RFromTypeName_String;
		public static RMethod RFromTypeName_String
		{
			get
			{
				if(r_RFromTypeName_String == null)
				{
					r_RFromTypeName_String = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "FromTypeName", 0, typeof(System.String));
					r_RFromTypeName_String.SetBelong(null);
				}
				return r_RFromTypeName_String;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaDatatype)
		/// </summary>
		protected static RMethod r_RStartBuiltinType_XmlQualifiedName_XmlSchemaDatatype;
		public static RMethod RStartBuiltinType_XmlQualifiedName_XmlSchemaDatatype
		{
			get
			{
				if(r_RStartBuiltinType_XmlQualifiedName_XmlSchemaDatatype == null)
				{
					r_RStartBuiltinType_XmlQualifiedName_XmlSchemaDatatype = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "StartBuiltinType", 0, typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.Schema.XmlSchemaDatatype));
					r_RStartBuiltinType_XmlQualifiedName_XmlSchemaDatatype.SetBelong(null);
				}
				return r_RStartBuiltinType_XmlQualifiedName_XmlSchemaDatatype;
			}
		}

		/// <summary>
		/// Void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType, System.Xml.Schema.XmlSchemaSimpleType)
		/// </summary>
		protected static RMethod r_RFinishBuiltinType_XmlSchemaSimpleType_XmlSchemaSimpleType;
		public static RMethod RFinishBuiltinType_XmlSchemaSimpleType_XmlSchemaSimpleType
		{
			get
			{
				if(r_RFinishBuiltinType_XmlSchemaSimpleType_XmlSchemaSimpleType == null)
				{
					r_RFinishBuiltinType_XmlSchemaSimpleType_XmlSchemaSimpleType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "FinishBuiltinType", 0, typeof(System.Xml.Schema.XmlSchemaSimpleType), typeof(System.Xml.Schema.XmlSchemaSimpleType));
					r_RFinishBuiltinType_XmlSchemaSimpleType_XmlSchemaSimpleType.SetBelong(null);
				}
				return r_RFinishBuiltinType_XmlSchemaSimpleType_XmlSchemaSimpleType;
			}
		}

		/// <summary>
		/// Void CreateBuiltinTypes()
		/// </summary>
		protected static RMethod r_RCreateBuiltinTypes;
		public static RMethod RCreateBuiltinTypes
		{
			get
			{
				if(r_RCreateBuiltinTypes == null)
				{
					r_RCreateBuiltinTypes = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "CreateBuiltinTypes", 0);
					r_RCreateBuiltinTypes.SetBelong(null);
				}
				return r_RCreateBuiltinTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode)
		/// </summary>
		protected static RMethod r_RGetSimpleTypeFromTypeCode_XmlTypeCode;
		public static RMethod RGetSimpleTypeFromTypeCode_XmlTypeCode
		{
			get
			{
				if(r_RGetSimpleTypeFromTypeCode_XmlTypeCode == null)
				{
					r_RGetSimpleTypeFromTypeCode_XmlTypeCode = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "GetSimpleTypeFromTypeCode", 0, typeof(System.Xml.Schema.XmlTypeCode));
					r_RGetSimpleTypeFromTypeCode_XmlTypeCode.SetBelong(null);
				}
				return r_RGetSimpleTypeFromTypeCode_XmlTypeCode;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName)
		/// </summary>
		protected static RMethod r_RGetSimpleTypeFromXsdType_XmlQualifiedName;
		public static RMethod RGetSimpleTypeFromXsdType_XmlQualifiedName
		{
			get
			{
				if(r_RGetSimpleTypeFromXsdType_XmlQualifiedName == null)
				{
					r_RGetSimpleTypeFromXsdType_XmlQualifiedName = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "GetSimpleTypeFromXsdType", 0, typeof(System.Xml.XmlQualifiedName));
					r_RGetSimpleTypeFromXsdType_XmlQualifiedName.SetBelong(null);
				}
				return r_RGetSimpleTypeFromXsdType_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat()
		/// </summary>
		protected static RMethod r_RGetNormalizedStringTypeV1Compat;
		public static RMethod RGetNormalizedStringTypeV1Compat
		{
			get
			{
				if(r_RGetNormalizedStringTypeV1Compat == null)
				{
					r_RGetNormalizedStringTypeV1Compat = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "GetNormalizedStringTypeV1Compat", 0);
					r_RGetNormalizedStringTypeV1Compat.SetBelong(null);
				}
				return r_RGetNormalizedStringTypeV1Compat;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat()
		/// </summary>
		protected static RMethod r_RGetTokenTypeV1Compat;
		public static RMethod RGetTokenTypeV1Compat
		{
			get
			{
				if(r_RGetTokenTypeV1Compat == null)
				{
					r_RGetTokenTypeV1Compat = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "GetTokenTypeV1Compat", 0);
					r_RGetTokenTypeV1Compat.SetBelong(null);
				}
				return r_RGetTokenTypeV1Compat;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes()
		/// </summary>
		protected static RMethod r_RGetBuiltInTypes;
		public static RMethod RGetBuiltInTypes
		{
			get
			{
				if(r_RGetBuiltInTypes == null)
				{
					r_RGetBuiltInTypes = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "GetBuiltInTypes", 0);
					r_RGetBuiltInTypes.SetBelong(null);
				}
				return r_RGetBuiltInTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode)
		/// </summary>
		protected static RMethod r_RGetPrimitiveTypeCode_XmlTypeCode;
		public static RMethod RGetPrimitiveTypeCode_XmlTypeCode
		{
			get
			{
				if(r_RGetPrimitiveTypeCode_XmlTypeCode == null)
				{
					r_RGetPrimitiveTypeCode_XmlTypeCode = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "GetPrimitiveTypeCode", 0, typeof(System.Xml.Schema.XmlTypeCode));
					r_RGetPrimitiveTypeCode_XmlTypeCode.SetBelong(null);
				}
				return r_RGetPrimitiveTypeCode_XmlTypeCode;
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
		/// System.Xml.Schema.XmlSchemaDatatype DeriveByList(Int32, System.Xml.Schema.XmlSchemaType)
		/// </summary>
		protected RMethod r_RDeriveByList_Int32_XmlSchemaType;
		public virtual RMethod RDeriveByList_Int32_XmlSchemaType
		{
			get
			{
				if(r_RDeriveByList_Int32_XmlSchemaType == null)
				{
					r_RDeriveByList_Int32_XmlSchemaType = new(this, "DeriveByList", 0, typeof(System.Int32), typeof(System.Xml.Schema.XmlSchemaType));
					r_RDeriveByList_Int32_XmlSchemaType.SetBelong(this.instance);
				}
				return r_RDeriveByList_Int32_XmlSchemaType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[], System.Xml.Schema.XmlSchemaType)
		/// </summary>
		protected static RMethod r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType;
		public static RMethod RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType
		{
			get
			{
				if(r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType == null)
				{
					r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation"), "DeriveByUnion", 0, typeof(System.Xml.Schema.XmlSchemaSimpleType).MakeArrayType(), typeof(System.Xml.Schema.XmlSchemaType));
					r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType.SetBelong(null);
				}
				return r_RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType;
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
		/// System.Xml.Schema.XmlValueConverter CreateValueConverter(System.Xml.Schema.XmlSchemaType)
		/// </summary>
		protected RMethod r_RCreateValueConverter_XmlSchemaType;
		public virtual RMethod RCreateValueConverter_XmlSchemaType
		{
			get
			{
				if(r_RCreateValueConverter_XmlSchemaType == null)
				{
					r_RCreateValueConverter_XmlSchemaType = new(this, "CreateValueConverter", 0, typeof(System.Xml.Schema.XmlSchemaType));
					r_RCreateValueConverter_XmlSchemaType.SetBelong(this.instance);
				}
				return r_RCreateValueConverter_XmlSchemaType;
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
		/// System.String GetTypeName()
		/// </summary>
		protected RMethod r_RGetTypeName;
		public virtual RMethod RGetTypeName
		{
			get
			{
				if(r_RGetTypeName == null)
				{
					r_RGetTypeName = new(this, "GetTypeName", 0);
					r_RGetTypeName.SetBelong(this.instance);
				}
				return r_RGetTypeName;
			}
		}

		/// <summary>
		/// Int32 Compare(Byte[], Byte[])
		/// </summary>
		protected RMethod r_RCompare_ByteArray_ByteArray;
		public virtual RMethod RCompare_ByteArray_ByteArray
		{
			get
			{
				if(r_RCompare_ByteArray_ByteArray == null)
				{
					r_RCompare_ByteArray_ByteArray = new(this, "Compare", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Byte).MakeArrayType());
					r_RCompare_ByteArray_ByteArray.SetBelong(this.instance);
				}
				return r_RCompare_ByteArray_ByteArray;
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


        public RDatatypeImplementation() : base("System.Xml.Schema.DatatypeImplementation")
        {
        }

        public RDatatypeImplementation(System.Object instance) : base("System.Xml.Schema.DatatypeImplementation")
		{
            SetInstance(instance);
		}

        public RDatatypeImplementation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDatatypeImplementation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Object FromXmlTokenizedType(System.Xml.XmlTokenizedType  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RFromXmlTokenizedType_XmlTokenizedType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object FromXmlTokenizedTypeXsd(System.Xml.XmlTokenizedType  @token)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@token};
            var ___result = RFromXmlTokenizedTypeXsd_XmlTokenizedType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object FromXdrName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFromXdrName_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object FromTypeName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFromTypeName_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Xml.Schema.XmlSchemaSimpleType StartBuiltinType(System.Xml.XmlQualifiedName  @qname, System.Xml.Schema.XmlSchemaDatatype  @dataType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname, @dataType};
            var ___result = RStartBuiltinType_XmlQualifiedName_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaSimpleType)___result;
        }


        public static void FinishBuiltinType(System.Xml.Schema.XmlSchemaSimpleType  @derivedType, System.Xml.Schema.XmlSchemaSimpleType  @baseType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@derivedType, @baseType};
            var ___result = RFinishBuiltinType_XmlSchemaSimpleType_XmlSchemaSimpleType.Invoke(___genericsType, ___parameters);

            
        }


        public static void CreateBuiltinTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateBuiltinTypes.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromTypeCode(System.Xml.Schema.XmlTypeCode  @typeCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeCode};
            var ___result = RGetSimpleTypeFromTypeCode_XmlTypeCode.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaSimpleType)___result;
        }


        public static System.Xml.Schema.XmlSchemaSimpleType GetSimpleTypeFromXsdType(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RGetSimpleTypeFromXsdType_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaSimpleType)___result;
        }


        public static System.Xml.Schema.XmlSchemaSimpleType GetNormalizedStringTypeV1Compat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetNormalizedStringTypeV1Compat.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaSimpleType)___result;
        }


        public static System.Xml.Schema.XmlSchemaSimpleType GetTokenTypeV1Compat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTokenTypeV1Compat.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaSimpleType)___result;
        }


        public static System.Xml.Schema.XmlSchemaSimpleType[] GetBuiltInTypes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBuiltInTypes.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaSimpleType[])___result;
        }


        public static System.Xml.Schema.XmlTypeCode GetPrimitiveTypeCode(System.Xml.Schema.XmlTypeCode  @typeCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeCode};
            var ___result = RGetPrimitiveTypeCode_XmlTypeCode.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlTypeCode)___result;
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


        public virtual System.Xml.Schema.XmlSchemaDatatype DeriveByList(System.Int32  @minSize, System.Xml.Schema.XmlSchemaType  @schemaType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@minSize, @schemaType};
            var ___result = RDeriveByList_Int32_XmlSchemaType.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaDatatype)___result;
        }


        public static System.Object DeriveByUnion(System.Xml.Schema.XmlSchemaSimpleType[]  @types, System.Xml.Schema.XmlSchemaType  @schemaType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@types, @schemaType};
            var ___result = RDeriveByUnion_XmlSchemaSimpleTypeArray_XmlSchemaType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void VerifySchemaValid(System.Xml.Schema.XmlSchemaObjectTable  @notations, System.Xml.Schema.XmlSchemaObject  @caller)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notations, @caller};
            var ___result = RVerifySchemaValid_XmlSchemaObjectTable_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype  @datatype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@datatype};
            var ___result = RIsDerivedFrom_XmlSchemaDatatype.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual System.Object CreateValueConverter(System.Xml.Schema.XmlSchemaType  @schemaType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemaType};
            var ___result = RCreateValueConverter_XmlSchemaType.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ParseValue(System.String  @s, System.Type  @typDest, System.Xml.XmlNameTable  @nameTable, System.Xml.IXmlNamespaceResolver  @nsmgr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @typDest, @nameTable, @nsmgr};
            var ___result = RParseValue_String_Type_XmlNameTable_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ParseValue(System.String  @s, System.Xml.XmlNameTable  @nameTable, System.Xml.IXmlNamespaceResolver  @nsmgr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @nameTable, @nsmgr};
            var ___result = RParseValue_String_XmlNameTable_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ParseValue(System.String  @s, System.Xml.XmlNameTable  @nameTable, System.Xml.IXmlNamespaceResolver  @nsmgr, System.Boolean  @createAtomicValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @nameTable, @nsmgr, @createAtomicValue};
            var ___result = RParseValue_String_XmlNameTable_IXmlNamespaceResolver_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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


        public virtual System.String GetTypeName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTypeName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 Compare(System.Byte[]  @value1, System.Byte[]  @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = RCompare_ByteArray_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.Int32 Compare(System.Object  @value1, System.Object  @value2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value1, @value2};
            var ___result = RCompare_Object_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String TypeCodeToString(System.Xml.Schema.XmlTypeCode  @typeCode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@typeCode};
            var ___result = RTypeCodeToString_XmlTypeCode.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
