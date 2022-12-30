using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.BaseValidator
	/// </summary>
    public partial class RBaseValidator : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.XmlSchemaCollection schemaCollection
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaCollection r_schemaCollection;
		public virtual RSystem.RXml.RSchema.RXmlSchemaCollection RschemaCollection
		{
			get
			{
				if(r_schemaCollection == null)
				{
					r_schemaCollection = new(this, "schemaCollection");
					r_schemaCollection.SetBelong(this.instance);
				}
				return r_schemaCollection;
			}
		}

		/// <summary>
		/// System.Xml.IValidationEventHandling eventHandling
		/// </summary>
		protected RSystem.RXml.RIValidationEventHandling r_eventHandling;
		public virtual RSystem.RXml.RIValidationEventHandling ReventHandling
		{
			get
			{
				if(r_eventHandling == null)
				{
					r_eventHandling = new(this, "eventHandling");
					r_eventHandling.SetBelong(this.instance);
				}
				return r_eventHandling;
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
		/// System.Xml.Schema.SchemaNames schemaNames
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaNames r_schemaNames;
		public virtual RSystem.RXml.RSchema.RSchemaNames RschemaNames
		{
			get
			{
				if(r_schemaNames == null)
				{
					r_schemaNames = new(this, "schemaNames");
					r_schemaNames.SetBelong(this.instance);
				}
				return r_schemaNames;
			}
		}

		/// <summary>
		/// System.Xml.PositionInfo positionInfo
		/// </summary>
		protected RSystem.RXml.RPositionInfo r_positionInfo;
		public virtual RSystem.RXml.RPositionInfo RpositionInfo
		{
			get
			{
				if(r_positionInfo == null)
				{
					r_positionInfo = new(this, "positionInfo");
					r_positionInfo.SetBelong(this.instance);
				}
				return r_positionInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver xmlResolver
		/// </summary>
		protected RSystem.RXml.RXmlResolver r_xmlResolver;
		public virtual RSystem.RXml.RXmlResolver RxmlResolver
		{
			get
			{
				if(r_xmlResolver == null)
				{
					r_xmlResolver = new(this, "xmlResolver");
					r_xmlResolver.SetBelong(this.instance);
				}
				return r_xmlResolver;
			}
		}

		/// <summary>
		/// System.Uri baseUri
		/// </summary>
		protected RSystem.RUri r_baseUri;
		public virtual RSystem.RUri RbaseUri
		{
			get
			{
				if(r_baseUri == null)
				{
					r_baseUri = new(this, "baseUri");
					r_baseUri.SetBelong(this.instance);
				}
				return r_baseUri;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaInfo schemaInfo
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaInfo r_schemaInfo;
		public virtual RSystem.RXml.RSchema.RSchemaInfo RschemaInfo
		{
			get
			{
				if(r_schemaInfo == null)
				{
					r_schemaInfo = new(this, "schemaInfo");
					r_schemaInfo.SetBelong(this.instance);
				}
				return r_schemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlValidatingReaderImpl reader
		/// </summary>
		protected RSystem.RXml.RXmlValidatingReaderImpl r_reader;
		public virtual RSystem.RXml.RXmlValidatingReaderImpl Rreader
		{
			get
			{
				if(r_reader == null)
				{
					r_reader = new(this, "reader");
					r_reader.SetBelong(this.instance);
				}
				return r_reader;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName elementName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_elementName;
		public virtual RSystem.RXml.RXmlQualifiedName RelementName
		{
			get
			{
				if(r_elementName == null)
				{
					r_elementName = new(this, "elementName");
					r_elementName.SetBelong(this.instance);
				}
				return r_elementName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ValidationState context
		/// </summary>
		protected RSystem.RXml.RSchema.RValidationState r_context;
		public virtual RSystem.RXml.RSchema.RValidationState Rcontext
		{
			get
			{
				if(r_context == null)
				{
					r_context = new(this, "context");
					r_context.SetBelong(this.instance);
				}
				return r_context;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder textValue
		/// </summary>
		protected RSystem.RText.RStringBuilder r_textValue;
		public virtual RSystem.RText.RStringBuilder RtextValue
		{
			get
			{
				if(r_textValue == null)
				{
					r_textValue = new(this, "textValue");
					r_textValue.SetBelong(this.instance);
				}
				return r_textValue;
			}
		}

		/// <summary>
		/// System.String textString
		/// </summary>
		protected RField r_textString;
		public virtual RField RtextString
		{
			get
			{
				if(r_textString == null)
				{
					r_textString = new(this, "textString");
					r_textString.SetBelong(this.instance);
				}
				return r_textString;
			}
		}

		/// <summary>
		/// System.Boolean hasSibling
		/// </summary>
		protected RField r_hasSibling;
		public virtual RField RhasSibling
		{
			get
			{
				if(r_hasSibling == null)
				{
					r_hasSibling = new(this, "hasSibling");
					r_hasSibling.SetBelong(this.instance);
				}
				return r_hasSibling;
			}
		}

		/// <summary>
		/// System.Boolean checkDatatype
		/// </summary>
		protected RField r_checkDatatype;
		public virtual RField RcheckDatatype
		{
			get
			{
				if(r_checkDatatype == null)
				{
					r_checkDatatype = new(this, "checkDatatype");
					r_checkDatatype.SetBelong(this.instance);
				}
				return r_checkDatatype;
			}
		}

		/// <summary>
		/// System.Xml.XmlValidatingReaderImpl Reader
		/// </summary>
		protected RSystem.RXml.RXmlValidatingReaderImpl r_Reader;
		public virtual RSystem.RXml.RXmlValidatingReaderImpl Reader
		{
			get
			{
				if(r_Reader == null)
				{
					r_Reader = new(this, "Reader", -1);
					r_Reader.SetBelong(this.instance);
				}
				return r_Reader;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaCollection SchemaCollection
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaCollection r_SchemaCollection;
		public virtual RSystem.RXml.RSchema.RXmlSchemaCollection RSchemaCollection
		{
			get
			{
				if(r_SchemaCollection == null)
				{
					r_SchemaCollection = new(this, "SchemaCollection", -1);
					r_SchemaCollection.SetBelong(this.instance);
				}
				return r_SchemaCollection;
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
		/// System.Xml.Schema.SchemaNames SchemaNames
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaNames r_SchemaNames;
		public virtual RSystem.RXml.RSchema.RSchemaNames RSchemaNames
		{
			get
			{
				if(r_SchemaNames == null)
				{
					r_SchemaNames = new(this, "SchemaNames", -1);
					r_SchemaNames.SetBelong(this.instance);
				}
				return r_SchemaNames;
			}
		}

		/// <summary>
		/// System.Xml.PositionInfo PositionInfo
		/// </summary>
		protected RSystem.RXml.RPositionInfo r_PositionInfo;
		public virtual RSystem.RXml.RPositionInfo RPositionInfo
		{
			get
			{
				if(r_PositionInfo == null)
				{
					r_PositionInfo = new(this, "PositionInfo", -1);
					r_PositionInfo.SetBelong(this.instance);
				}
				return r_PositionInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver XmlResolver
		/// </summary>
		protected RSystem.RXml.RXmlResolver r_XmlResolver;
		public virtual RSystem.RXml.RXmlResolver RXmlResolver
		{
			get
			{
				if(r_XmlResolver == null)
				{
					r_XmlResolver = new(this, "XmlResolver", -1);
					r_XmlResolver.SetBelong(this.instance);
				}
				return r_XmlResolver;
			}
		}

		/// <summary>
		/// System.Uri BaseUri
		/// </summary>
		protected RSystem.RUri r_BaseUri;
		public virtual RSystem.RUri RBaseUri
		{
			get
			{
				if(r_BaseUri == null)
				{
					r_BaseUri = new(this, "BaseUri", -1);
					r_BaseUri.SetBelong(this.instance);
				}
				return r_BaseUri;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ValidationEventHandler EventHandler
		/// </summary>
		protected RSystem.RXml.RSchema.RValidationEventHandler r_EventHandler;
		public virtual RSystem.RXml.RSchema.RValidationEventHandler REventHandler
		{
			get
			{
				if(r_EventHandler == null)
				{
					r_EventHandler = new(this, "EventHandler", -1);
					r_EventHandler.SetBelong(this.instance);
				}
				return r_EventHandler;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaInfo SchemaInfo
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaInfo r_SchemaInfo;
		public virtual RSystem.RXml.RSchema.RSchemaInfo RSchemaInfo
		{
			get
			{
				if(r_SchemaInfo == null)
				{
					r_SchemaInfo = new(this, "SchemaInfo", -1);
					r_SchemaInfo.SetBelong(this.instance);
				}
				return r_SchemaInfo;
			}
		}

		/// <summary>
		/// System.Xml.IDtdInfo DtdInfo
		/// </summary>
		protected RSystem.RXml.RIDtdInfo r_DtdInfo;
		public virtual RSystem.RXml.RIDtdInfo RDtdInfo
		{
			get
			{
				if(r_DtdInfo == null)
				{
					r_DtdInfo = new(this, "DtdInfo", -1);
					r_DtdInfo.SetBelong(this.instance);
				}
				return r_DtdInfo;
			}
		}

		/// <summary>
		/// Boolean PreserveWhitespace
		/// </summary>
		protected RProperty r_PreserveWhitespace;
		public virtual RProperty RPreserveWhitespace
		{
			get
			{
				if(r_PreserveWhitespace == null)
				{
					r_PreserveWhitespace = new(this, "PreserveWhitespace", -1);
					r_PreserveWhitespace.SetBelong(this.instance);
				}
				return r_PreserveWhitespace;
			}
		}

		/// <summary>
		/// Void Validate()
		/// </summary>
		protected RMethod r_RValidate;
		public virtual RMethod RValidate
		{
			get
			{
				if(r_RValidate == null)
				{
					r_RValidate = new(this, "Validate", 0);
					r_RValidate.SetBelong(this.instance);
				}
				return r_RValidate;
			}
		}

		/// <summary>
		/// Void CompleteValidation()
		/// </summary>
		protected RMethod r_RCompleteValidation;
		public virtual RMethod RCompleteValidation
		{
			get
			{
				if(r_RCompleteValidation == null)
				{
					r_RCompleteValidation = new(this, "CompleteValidation", 0);
					r_RCompleteValidation.SetBelong(this.instance);
				}
				return r_RCompleteValidation;
			}
		}

		/// <summary>
		/// System.Object FindId(System.String)
		/// </summary>
		protected RMethod r_RFindId_String;
		public virtual RMethod RFindId_String
		{
			get
			{
				if(r_RFindId_String == null)
				{
					r_RFindId_String = new(this, "FindId", 0, typeof(System.String));
					r_RFindId_String.SetBelong(this.instance);
				}
				return r_RFindId_String;
			}
		}

		/// <summary>
		/// Void ValidateText()
		/// </summary>
		protected RMethod r_RValidateText;
		public virtual RMethod RValidateText
		{
			get
			{
				if(r_RValidateText == null)
				{
					r_RValidateText = new(this, "ValidateText", 0);
					r_RValidateText.SetBelong(this.instance);
				}
				return r_RValidateText;
			}
		}

		/// <summary>
		/// Void ValidateWhitespace()
		/// </summary>
		protected RMethod r_RValidateWhitespace;
		public virtual RMethod RValidateWhitespace
		{
			get
			{
				if(r_RValidateWhitespace == null)
				{
					r_RValidateWhitespace = new(this, "ValidateWhitespace", 0);
					r_RValidateWhitespace.SetBelong(this.instance);
				}
				return r_RValidateWhitespace;
			}
		}

		/// <summary>
		/// Void SaveTextValue(System.String)
		/// </summary>
		protected RMethod r_RSaveTextValue_String;
		public virtual RMethod RSaveTextValue_String
		{
			get
			{
				if(r_RSaveTextValue_String == null)
				{
					r_RSaveTextValue_String = new(this, "SaveTextValue", 0, typeof(System.String));
					r_RSaveTextValue_String.SetBelong(this.instance);
				}
				return r_RSaveTextValue_String;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.String)
		/// </summary>
		protected RMethod r_RSendValidationEvent_String;
		public virtual RMethod RSendValidationEvent_String
		{
			get
			{
				if(r_RSendValidationEvent_String == null)
				{
					r_RSendValidationEvent_String = new(this, "SendValidationEvent", 0, typeof(System.String));
					r_RSendValidationEvent_String.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_String;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.String, System.String[])
		/// </summary>
		protected RMethod r_RSendValidationEvent_String_StringArray;
		public virtual RMethod RSendValidationEvent_String_StringArray
		{
			get
			{
				if(r_RSendValidationEvent_String_StringArray == null)
				{
					r_RSendValidationEvent_String_StringArray = new(this, "SendValidationEvent", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_RSendValidationEvent_String_StringArray.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_String_StringArray;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.String, System.String)
		/// </summary>
		protected RMethod r_RSendValidationEvent_String_String;
		public virtual RMethod RSendValidationEvent_String_String
		{
			get
			{
				if(r_RSendValidationEvent_String_String == null)
				{
					r_RSendValidationEvent_String_String = new(this, "SendValidationEvent", 0, typeof(System.String), typeof(System.String));
					r_RSendValidationEvent_String_String.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_String_String;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RSendValidationEvent_String_String_String;
		public virtual RMethod RSendValidationEvent_String_String_String
		{
			get
			{
				if(r_RSendValidationEvent_String_String_String == null)
				{
					r_RSendValidationEvent_String_String_String = new(this, "SendValidationEvent", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RSendValidationEvent_String_String_String.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_String_String_String;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.Xml.Schema.XmlSchemaException)
		/// </summary>
		protected RMethod r_RSendValidationEvent_XmlSchemaException;
		public virtual RMethod RSendValidationEvent_XmlSchemaException
		{
			get
			{
				if(r_RSendValidationEvent_XmlSchemaException == null)
				{
					r_RSendValidationEvent_XmlSchemaException = new(this, "SendValidationEvent", 0, typeof(System.Xml.Schema.XmlSchemaException));
					r_RSendValidationEvent_XmlSchemaException.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_XmlSchemaException;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.String, System.String, System.Xml.Schema.XmlSeverityType)
		/// </summary>
		protected RMethod r_RSendValidationEvent_String_String_XmlSeverityType;
		public virtual RMethod RSendValidationEvent_String_String_XmlSeverityType
		{
			get
			{
				if(r_RSendValidationEvent_String_String_XmlSeverityType == null)
				{
					r_RSendValidationEvent_String_String_XmlSeverityType = new(this, "SendValidationEvent", 0, typeof(System.String), typeof(System.String), typeof(System.Xml.Schema.XmlSeverityType));
					r_RSendValidationEvent_String_String_XmlSeverityType.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_String_String_XmlSeverityType;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.String, System.String[], System.Xml.Schema.XmlSeverityType)
		/// </summary>
		protected RMethod r_RSendValidationEvent_String_StringArray_XmlSeverityType;
		public virtual RMethod RSendValidationEvent_String_StringArray_XmlSeverityType
		{
			get
			{
				if(r_RSendValidationEvent_String_StringArray_XmlSeverityType == null)
				{
					r_RSendValidationEvent_String_StringArray_XmlSeverityType = new(this, "SendValidationEvent", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Xml.Schema.XmlSeverityType));
					r_RSendValidationEvent_String_StringArray_XmlSeverityType.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_String_StringArray_XmlSeverityType;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.Xml.Schema.XmlSchemaException, System.Xml.Schema.XmlSeverityType)
		/// </summary>
		protected RMethod r_RSendValidationEvent_XmlSchemaException_XmlSeverityType;
		public virtual RMethod RSendValidationEvent_XmlSchemaException_XmlSeverityType
		{
			get
			{
				if(r_RSendValidationEvent_XmlSchemaException_XmlSeverityType == null)
				{
					r_RSendValidationEvent_XmlSchemaException_XmlSeverityType = new(this, "SendValidationEvent", 0, typeof(System.Xml.Schema.XmlSchemaException), typeof(System.Xml.Schema.XmlSeverityType));
					r_RSendValidationEvent_XmlSchemaException_XmlSeverityType.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_XmlSchemaException_XmlSeverityType;
			}
		}

		/// <summary>
		/// Void ProcessEntity(System.Xml.Schema.SchemaInfo, System.String, System.Object, System.Xml.Schema.ValidationEventHandler, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_RProcessEntity_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32;
		public static RMethod RProcessEntity_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32
		{
			get
			{
				if(r_RProcessEntity_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32 == null)
				{
					r_RProcessEntity_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.Schema.BaseValidator"), "ProcessEntity", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaInfo"), typeof(System.String), typeof(System.Object), typeof(System.Xml.Schema.ValidationEventHandler), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RProcessEntity_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32.SetBelong(null);
				}
				return r_RProcessEntity_SchemaInfo_String_Object_ValidationEventHandler_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ProcessEntity(System.Xml.Schema.SchemaInfo, System.String, System.Xml.IValidationEventHandling, System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_RProcessEntity_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32;
		public static RMethod RProcessEntity_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32
		{
			get
			{
				if(r_RProcessEntity_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32 == null)
				{
					r_RProcessEntity_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.Schema.BaseValidator"), "ProcessEntity", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaInfo"), typeof(System.String),  ReleactionUtils.GetType("System.Xml.IValidationEventHandling"), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RProcessEntity_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32.SetBelong(null);
				}
				return r_RProcessEntity_SchemaInfo_String_IValidationEventHandling_String_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Xml.Schema.BaseValidator CreateInstance(System.Xml.ValidationType, System.Xml.XmlValidatingReaderImpl, System.Xml.Schema.XmlSchemaCollection, System.Xml.IValidationEventHandling, Boolean)
		/// </summary>
		protected static RMethod r_RCreateInstance_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean;
		public static RMethod RCreateInstance_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean
		{
			get
			{
				if(r_RCreateInstance_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean == null)
				{
					r_RCreateInstance_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean = new( ReleactionUtils.GetType("System.Xml.Schema.BaseValidator"), "CreateInstance", 0, typeof(System.Xml.ValidationType),  ReleactionUtils.GetType("System.Xml.XmlValidatingReaderImpl"), typeof(System.Xml.Schema.XmlSchemaCollection),  ReleactionUtils.GetType("System.Xml.IValidationEventHandling"), typeof(System.Boolean));
					r_RCreateInstance_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean.SetBelong(null);
				}
				return r_RCreateInstance_ValidationType_XmlValidatingReaderImpl_XmlSchemaCollection_IValidationEventHandling_Boolean;
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


        public RBaseValidator() : base("System.Xml.Schema.BaseValidator")
        {
        }

        public RBaseValidator(System.Object instance) : base("System.Xml.Schema.BaseValidator")
		{
            SetInstance(instance);
		}

        public RBaseValidator(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBaseValidator(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Validate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CompleteValidation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompleteValidation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object FindId(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RFindId_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ValidateText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ValidateWhitespace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidateWhitespace.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SaveTextValue(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSaveTextValue_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.String  @code)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code};
            var ___result = RSendValidationEvent_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.String  @code, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code, @args};
            var ___result = RSendValidationEvent_String_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.String  @code, System.String  @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code, @arg};
            var ___result = RSendValidationEvent_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.String  @code, System.String  @arg1, System.String  @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code, @arg1, @arg2};
            var ___result = RSendValidationEvent_String_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.Xml.Schema.XmlSchemaException  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendValidationEvent_XmlSchemaException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.String  @code, System.String  @msg, System.Xml.Schema.XmlSeverityType  @severity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code, @msg, @severity};
            var ___result = RSendValidationEvent_String_String_XmlSeverityType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.String  @code, System.String[]  @args, System.Xml.Schema.XmlSeverityType  @severity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@code, @args, @severity};
            var ___result = RSendValidationEvent_String_StringArray_XmlSeverityType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.Xml.Schema.XmlSchemaException  @e, System.Xml.Schema.XmlSeverityType  @severity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @severity};
            var ___result = RSendValidationEvent_XmlSchemaException_XmlSeverityType.Invoke(___genericsType, ___parameters);

            
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
