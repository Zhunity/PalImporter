using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.SchemaAttDef
	/// </summary>
    public partial class RSchemaAttDef : RMember //
    {

		/// <summary>
		/// System.String defExpanded
		/// </summary>
		protected RField r_defExpanded;
		public virtual RField RdefExpanded
		{
			get
			{
				if(r_defExpanded == null)
				{
					r_defExpanded = new(this, "defExpanded");
					r_defExpanded.SetBelong(this.instance);
				}
				return r_defExpanded;
			}
		}

		/// <summary>
		/// System.Int32 lineNum
		/// </summary>
		protected RField r_lineNum;
		public virtual RField RlineNum
		{
			get
			{
				if(r_lineNum == null)
				{
					r_lineNum = new(this, "lineNum");
					r_lineNum.SetBelong(this.instance);
				}
				return r_lineNum;
			}
		}

		/// <summary>
		/// System.Int32 linePos
		/// </summary>
		protected RField r_linePos;
		public virtual RField RlinePos
		{
			get
			{
				if(r_linePos == null)
				{
					r_linePos = new(this, "linePos");
					r_linePos.SetBelong(this.instance);
				}
				return r_linePos;
			}
		}

		/// <summary>
		/// System.Int32 valueLineNum
		/// </summary>
		protected RField r_valueLineNum;
		public virtual RField RvalueLineNum
		{
			get
			{
				if(r_valueLineNum == null)
				{
					r_valueLineNum = new(this, "valueLineNum");
					r_valueLineNum.SetBelong(this.instance);
				}
				return r_valueLineNum;
			}
		}

		/// <summary>
		/// System.Int32 valueLinePos
		/// </summary>
		protected RField r_valueLinePos;
		public virtual RField RvalueLinePos
		{
			get
			{
				if(r_valueLinePos == null)
				{
					r_valueLinePos = new(this, "valueLinePos");
					r_valueLinePos.SetBelong(this.instance);
				}
				return r_valueLinePos;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaAttDef+Reserve reserved
		/// </summary>
		protected RField r_reserved;
		public virtual RField Rreserved
		{
			get
			{
				if(r_reserved == null)
				{
					r_reserved = new(this, "reserved");
					r_reserved.SetBelong(this.instance);
				}
				return r_reserved;
			}
		}

		/// <summary>
		/// System.Boolean defaultValueChecked
		/// </summary>
		protected RField r_defaultValueChecked;
		public virtual RField RdefaultValueChecked
		{
			get
			{
				if(r_defaultValueChecked == null)
				{
					r_defaultValueChecked = new(this, "defaultValueChecked");
					r_defaultValueChecked.SetBelong(this.instance);
				}
				return r_defaultValueChecked;
			}
		}

		/// <summary>
		/// System.Boolean hasEntityRef
		/// </summary>
		protected RField r_hasEntityRef;
		public virtual RField RhasEntityRef
		{
			get
			{
				if(r_hasEntityRef == null)
				{
					r_hasEntityRef = new(this, "hasEntityRef");
					r_hasEntityRef.SetBelong(this.instance);
				}
				return r_hasEntityRef;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAttribute schemaAttribute
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAttribute r_schemaAttribute;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAttribute RschemaAttribute
		{
			get
			{
				if(r_schemaAttribute == null)
				{
					r_schemaAttribute = new(this, "schemaAttribute");
					r_schemaAttribute.SetBelong(this.instance);
				}
				return r_schemaAttribute;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaAttDef Empty
		/// </summary>
		protected static RSystem.RXml.RSchema.RSchemaAttDef r_Empty;
		public static RSystem.RXml.RSchema.RSchemaAttDef REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new( ReleactionUtils.GetType("System.Xml.Schema.SchemaAttDef"), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName name
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_name;
		public virtual RSystem.RXml.RXmlQualifiedName Rname
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
		/// System.Xml.Schema.SchemaDeclBase+Use presence
		/// </summary>
		protected RField r_presence;
		public virtual RField Rpresence
		{
			get
			{
				if(r_presence == null)
				{
					r_presence = new(this, "presence");
					r_presence.SetBelong(this.instance);
				}
				return r_presence;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType schemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_schemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RschemaType
		{
			get
			{
				if(r_schemaType == null)
				{
					r_schemaType = new(this, "schemaType");
					r_schemaType.SetBelong(this.instance);
				}
				return r_schemaType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype datatype
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaDatatype r_datatype;
		public virtual RSystem.RXml.RSchema.RXmlSchemaDatatype Rdatatype
		{
			get
			{
				if(r_datatype == null)
				{
					r_datatype = new(this, "datatype");
					r_datatype.SetBelong(this.instance);
				}
				return r_datatype;
			}
		}

		/// <summary>
		/// System.String defaultValueRaw
		/// </summary>
		protected RField r_defaultValueRaw;
		public virtual RField RdefaultValueRaw
		{
			get
			{
				if(r_defaultValueRaw == null)
				{
					r_defaultValueRaw = new(this, "defaultValueRaw");
					r_defaultValueRaw.SetBelong(this.instance);
				}
				return r_defaultValueRaw;
			}
		}

		/// <summary>
		/// System.Object defaultValueTyped
		/// </summary>
		protected RSystem.RObject r_defaultValueTyped;
		public virtual RSystem.RObject RdefaultValueTyped
		{
			get
			{
				if(r_defaultValueTyped == null)
				{
					r_defaultValueTyped = new(this, "defaultValueTyped");
					r_defaultValueTyped.SetBelong(this.instance);
				}
				return r_defaultValueTyped;
			}
		}

		/// <summary>
		/// System.Int64 maxLength
		/// </summary>
		protected RField r_maxLength;
		public virtual RField RmaxLength
		{
			get
			{
				if(r_maxLength == null)
				{
					r_maxLength = new(this, "maxLength");
					r_maxLength.SetBelong(this.instance);
				}
				return r_maxLength;
			}
		}

		/// <summary>
		/// System.Int64 minLength
		/// </summary>
		protected RField r_minLength;
		public virtual RField RminLength
		{
			get
			{
				if(r_minLength == null)
				{
					r_minLength = new(this, "minLength");
					r_minLength.SetBelong(this.instance);
				}
				return r_minLength;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_values;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rvalues
		{
			get
			{
				if(r_values == null)
				{
					r_values = new(this, "values");
					r_values.SetBelong(this.instance);
				}
				return r_values;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdAttributeInfo.Prefix
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_Prefix;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeInfo__1__get_Prefix
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_Prefix == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_Prefix = new(this, "System.Xml.IDtdAttributeInfo.Prefix", -1);
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_Prefix.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_Prefix;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdAttributeInfo.LocalName
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LocalName;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LocalName
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LocalName == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LocalName = new(this, "System.Xml.IDtdAttributeInfo.LocalName", -1);
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LocalName.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LocalName;
			}
		}

		/// <summary>
		/// Int32 System.Xml.IDtdAttributeInfo.LineNumber
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LineNumber;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LineNumber
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LineNumber == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LineNumber = new(this, "System.Xml.IDtdAttributeInfo.LineNumber", -1);
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LineNumber.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LineNumber;
			}
		}

		/// <summary>
		/// Int32 System.Xml.IDtdAttributeInfo.LinePosition
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LinePosition;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LinePosition
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LinePosition == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LinePosition = new(this, "System.Xml.IDtdAttributeInfo.LinePosition", -1);
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LinePosition.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_LinePosition;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdAttributeInfo.IsNonCDataType
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsNonCDataType;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsNonCDataType
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsNonCDataType == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsNonCDataType = new(this, "System.Xml.IDtdAttributeInfo.IsNonCDataType", -1);
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsNonCDataType.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsNonCDataType;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdAttributeInfo.IsDeclaredInExternal
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsDeclaredInExternal;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsDeclaredInExternal
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsDeclaredInExternal == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsDeclaredInExternal = new(this, "System.Xml.IDtdAttributeInfo.IsDeclaredInExternal", -1);
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsDeclaredInExternal.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsDeclaredInExternal;
			}
		}

		/// <summary>
		/// Boolean System.Xml.IDtdAttributeInfo.IsXmlAttribute
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsXmlAttribute;
		public virtual RProperty RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsXmlAttribute
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsXmlAttribute == null)
				{
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsXmlAttribute = new(this, "System.Xml.IDtdAttributeInfo.IsXmlAttribute", -1);
					r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsXmlAttribute.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdAttributeInfo__1__get_IsXmlAttribute;
			}
		}

		/// <summary>
		/// System.String System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueExpanded;
		public virtual RProperty RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueExpanded
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueExpanded == null)
				{
					r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueExpanded = new(this, "System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded", -1);
					r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueExpanded.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueExpanded;
			}
		}

		/// <summary>
		/// System.Object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueTyped;
		public virtual RSystem.RObject RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueTyped
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueTyped == null)
				{
					r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueTyped = new(this, "System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped", -1);
					r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueTyped.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_DefaultValueTyped;
			}
		}

		/// <summary>
		/// Int32 System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLineNumber;
		public virtual RProperty RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLineNumber
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLineNumber == null)
				{
					r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLineNumber = new(this, "System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber", -1);
					r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLineNumber.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLineNumber;
			}
		}

		/// <summary>
		/// Int32 System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition
		/// </summary>
		protected RProperty r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLinePosition;
		public virtual RProperty RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLinePosition
		{
			get
			{
				if(r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLinePosition == null)
				{
					r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLinePosition = new(this, "System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition", -1);
					r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLinePosition.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IDtdDefaultAttributeInfo__1__get_ValueLinePosition;
			}
		}

		/// <summary>
		/// Int32 LinePosition
		/// </summary>
		protected RProperty r_LinePosition;
		public virtual RProperty RLinePosition
		{
			get
			{
				if(r_LinePosition == null)
				{
					r_LinePosition = new(this, "LinePosition", -1);
					r_LinePosition.SetBelong(this.instance);
				}
				return r_LinePosition;
			}
		}

		/// <summary>
		/// Int32 LineNumber
		/// </summary>
		protected RProperty r_LineNumber;
		public virtual RProperty RLineNumber
		{
			get
			{
				if(r_LineNumber == null)
				{
					r_LineNumber = new(this, "LineNumber", -1);
					r_LineNumber.SetBelong(this.instance);
				}
				return r_LineNumber;
			}
		}

		/// <summary>
		/// Int32 ValueLinePosition
		/// </summary>
		protected RProperty r_ValueLinePosition;
		public virtual RProperty RValueLinePosition
		{
			get
			{
				if(r_ValueLinePosition == null)
				{
					r_ValueLinePosition = new(this, "ValueLinePosition", -1);
					r_ValueLinePosition.SetBelong(this.instance);
				}
				return r_ValueLinePosition;
			}
		}

		/// <summary>
		/// Int32 ValueLineNumber
		/// </summary>
		protected RProperty r_ValueLineNumber;
		public virtual RProperty RValueLineNumber
		{
			get
			{
				if(r_ValueLineNumber == null)
				{
					r_ValueLineNumber = new(this, "ValueLineNumber", -1);
					r_ValueLineNumber.SetBelong(this.instance);
				}
				return r_ValueLineNumber;
			}
		}

		/// <summary>
		/// System.String DefaultValueExpanded
		/// </summary>
		protected RProperty r_DefaultValueExpanded;
		public virtual RProperty RDefaultValueExpanded
		{
			get
			{
				if(r_DefaultValueExpanded == null)
				{
					r_DefaultValueExpanded = new(this, "DefaultValueExpanded", -1);
					r_DefaultValueExpanded.SetBelong(this.instance);
				}
				return r_DefaultValueExpanded;
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
		/// Reserve Reserved
		/// </summary>
		protected RProperty r_Reserved;
		public virtual RProperty Reserved
		{
			get
			{
				if(r_Reserved == null)
				{
					r_Reserved = new(this, "Reserved", -1);
					r_Reserved.SetBelong(this.instance);
				}
				return r_Reserved;
			}
		}

		/// <summary>
		/// Boolean DefaultValueChecked
		/// </summary>
		protected RProperty r_DefaultValueChecked;
		public virtual RProperty RDefaultValueChecked
		{
			get
			{
				if(r_DefaultValueChecked == null)
				{
					r_DefaultValueChecked = new(this, "DefaultValueChecked", -1);
					r_DefaultValueChecked.SetBelong(this.instance);
				}
				return r_DefaultValueChecked;
			}
		}

		/// <summary>
		/// Boolean HasEntityRef
		/// </summary>
		protected RProperty r_HasEntityRef;
		public virtual RProperty RHasEntityRef
		{
			get
			{
				if(r_HasEntityRef == null)
				{
					r_HasEntityRef = new(this, "HasEntityRef", -1);
					r_HasEntityRef.SetBelong(this.instance);
				}
				return r_HasEntityRef;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAttribute SchemaAttribute
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAttribute r_SchemaAttribute;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAttribute RSchemaAttribute
		{
			get
			{
				if(r_SchemaAttribute == null)
				{
					r_SchemaAttribute = new(this, "SchemaAttribute", -1);
					r_SchemaAttribute.SetBelong(this.instance);
				}
				return r_SchemaAttribute;
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
		/// System.String Prefix
		/// </summary>
		protected RProperty r_Prefix;
		public virtual RProperty RPrefix
		{
			get
			{
				if(r_Prefix == null)
				{
					r_Prefix = new(this, "Prefix", -1);
					r_Prefix.SetBelong(this.instance);
				}
				return r_Prefix;
			}
		}

		/// <summary>
		/// Boolean IsDeclaredInExternal
		/// </summary>
		protected RProperty r_IsDeclaredInExternal;
		public virtual RProperty RIsDeclaredInExternal
		{
			get
			{
				if(r_IsDeclaredInExternal == null)
				{
					r_IsDeclaredInExternal = new(this, "IsDeclaredInExternal", -1);
					r_IsDeclaredInExternal.SetBelong(this.instance);
				}
				return r_IsDeclaredInExternal;
			}
		}

		/// <summary>
		/// Use Presence
		/// </summary>
		protected RProperty r_Presence;
		public virtual RProperty RPresence
		{
			get
			{
				if(r_Presence == null)
				{
					r_Presence = new(this, "Presence", -1);
					r_Presence.SetBelong(this.instance);
				}
				return r_Presence;
			}
		}

		/// <summary>
		/// Int64 MaxLength
		/// </summary>
		protected RProperty r_MaxLength;
		public virtual RProperty RMaxLength
		{
			get
			{
				if(r_MaxLength == null)
				{
					r_MaxLength = new(this, "MaxLength", -1);
					r_MaxLength.SetBelong(this.instance);
				}
				return r_MaxLength;
			}
		}

		/// <summary>
		/// Int64 MinLength
		/// </summary>
		protected RProperty r_MinLength;
		public virtual RProperty RMinLength
		{
			get
			{
				if(r_MinLength == null)
				{
					r_MinLength = new(this, "MinLength", -1);
					r_MinLength.SetBelong(this.instance);
				}
				return r_MinLength;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaType SchemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaType r_SchemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaType RSchemaType
		{
			get
			{
				if(r_SchemaType == null)
				{
					r_SchemaType = new(this, "SchemaType", -1);
					r_SchemaType.SetBelong(this.instance);
				}
				return r_SchemaType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype Datatype
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaDatatype r_Datatype;
		public virtual RSystem.RXml.RSchema.RXmlSchemaDatatype RDatatype
		{
			get
			{
				if(r_Datatype == null)
				{
					r_Datatype = new(this, "Datatype", -1);
					r_Datatype.SetBelong(this.instance);
				}
				return r_Datatype;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] Values
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RProperty> r_Values;
		public virtual RSystem.RCollections.RGeneric.RList<RProperty> RValues
		{
			get
			{
				if(r_Values == null)
				{
					r_Values = new(this, "Values", -1);
					r_Values.SetBelong(this.instance);
				}
				return r_Values;
			}
		}

		/// <summary>
		/// System.String DefaultValueRaw
		/// </summary>
		protected RProperty r_DefaultValueRaw;
		public virtual RProperty RDefaultValueRaw
		{
			get
			{
				if(r_DefaultValueRaw == null)
				{
					r_DefaultValueRaw = new(this, "DefaultValueRaw", -1);
					r_DefaultValueRaw.SetBelong(this.instance);
				}
				return r_DefaultValueRaw;
			}
		}

		/// <summary>
		/// System.Object DefaultValueTyped
		/// </summary>
		protected RSystem.RObject r_DefaultValueTyped;
		public virtual RSystem.RObject RDefaultValueTyped
		{
			get
			{
				if(r_DefaultValueTyped == null)
				{
					r_DefaultValueTyped = new(this, "DefaultValueTyped", -1);
					r_DefaultValueTyped.SetBelong(this.instance);
				}
				return r_DefaultValueTyped;
			}
		}

		/// <summary>
		/// Void CheckXmlSpace(System.Xml.IValidationEventHandling)
		/// </summary>
		protected RMethod r_RCheckXmlSpace_IValidationEventHandling;
		public virtual RMethod RCheckXmlSpace_IValidationEventHandling
		{
			get
			{
				if(r_RCheckXmlSpace_IValidationEventHandling == null)
				{
					r_RCheckXmlSpace_IValidationEventHandling = new(this, "CheckXmlSpace", 0,  ReleactionUtils.GetType("System.Xml.IValidationEventHandling"));
					r_RCheckXmlSpace_IValidationEventHandling.SetBelong(this.instance);
				}
				return r_RCheckXmlSpace_IValidationEventHandling;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaAttDef Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Void AddValue(System.String)
		/// </summary>
		protected RMethod r_RAddValue_String;
		public virtual RMethod RAddValue_String
		{
			get
			{
				if(r_RAddValue_String == null)
				{
					r_RAddValue_String = new(this, "AddValue", 0, typeof(System.String));
					r_RAddValue_String.SetBelong(this.instance);
				}
				return r_RAddValue_String;
			}
		}

		/// <summary>
		/// Boolean CheckEnumeration(System.Object)
		/// </summary>
		protected RMethod r_RCheckEnumeration_Object;
		public virtual RMethod RCheckEnumeration_Object
		{
			get
			{
				if(r_RCheckEnumeration_Object == null)
				{
					r_RCheckEnumeration_Object = new(this, "CheckEnumeration", 0, typeof(System.Object));
					r_RCheckEnumeration_Object.SetBelong(this.instance);
				}
				return r_RCheckEnumeration_Object;
			}
		}

		/// <summary>
		/// Boolean CheckValue(System.Object)
		/// </summary>
		protected RMethod r_RCheckValue_Object;
		public virtual RMethod RCheckValue_Object
		{
			get
			{
				if(r_RCheckValue_Object == null)
				{
					r_RCheckValue_Object = new(this, "CheckValue", 0, typeof(System.Object));
					r_RCheckValue_Object.SetBelong(this.instance);
				}
				return r_RCheckValue_Object;
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


        public RSchemaAttDef() : base("System.Xml.Schema.SchemaAttDef")
        {
        }

        public RSchemaAttDef(System.Object instance) : base("System.Xml.Schema.SchemaAttDef")
		{
            SetInstance(instance);
		}

        public RSchemaAttDef(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSchemaAttDef(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void AddValue(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RAddValue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckEnumeration(System.Object  @pVal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pVal};
            var ___result = RCheckEnumeration_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CheckValue(System.Object  @pVal)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pVal};
            var ___result = RCheckValue_Object.Invoke(___genericsType, ___parameters);

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
