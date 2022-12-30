using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlReaderSettings
	/// </summary>
    public partial class RXmlReaderSettings : RMember //
    {

		/// <summary>
		/// System.Boolean useAsync
		/// </summary>
		protected RField r_useAsync;
		public virtual RField RuseAsync
		{
			get
			{
				if(r_useAsync == null)
				{
					r_useAsync = new(this, "useAsync");
					r_useAsync.SetBelong(this.instance);
				}
				return r_useAsync;
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
		/// System.Int32 lineNumberOffset
		/// </summary>
		protected RField r_lineNumberOffset;
		public virtual RField RlineNumberOffset
		{
			get
			{
				if(r_lineNumberOffset == null)
				{
					r_lineNumberOffset = new(this, "lineNumberOffset");
					r_lineNumberOffset.SetBelong(this.instance);
				}
				return r_lineNumberOffset;
			}
		}

		/// <summary>
		/// System.Int32 linePositionOffset
		/// </summary>
		protected RField r_linePositionOffset;
		public virtual RField RlinePositionOffset
		{
			get
			{
				if(r_linePositionOffset == null)
				{
					r_linePositionOffset = new(this, "linePositionOffset");
					r_linePositionOffset.SetBelong(this.instance);
				}
				return r_linePositionOffset;
			}
		}

		/// <summary>
		/// System.Xml.ConformanceLevel conformanceLevel
		/// </summary>
		protected RField r_conformanceLevel;
		public virtual RField RconformanceLevel
		{
			get
			{
				if(r_conformanceLevel == null)
				{
					r_conformanceLevel = new(this, "conformanceLevel");
					r_conformanceLevel.SetBelong(this.instance);
				}
				return r_conformanceLevel;
			}
		}

		/// <summary>
		/// System.Boolean checkCharacters
		/// </summary>
		protected RField r_checkCharacters;
		public virtual RField RcheckCharacters
		{
			get
			{
				if(r_checkCharacters == null)
				{
					r_checkCharacters = new(this, "checkCharacters");
					r_checkCharacters.SetBelong(this.instance);
				}
				return r_checkCharacters;
			}
		}

		/// <summary>
		/// System.Int64 maxCharactersInDocument
		/// </summary>
		protected RField r_maxCharactersInDocument;
		public virtual RField RmaxCharactersInDocument
		{
			get
			{
				if(r_maxCharactersInDocument == null)
				{
					r_maxCharactersInDocument = new(this, "maxCharactersInDocument");
					r_maxCharactersInDocument.SetBelong(this.instance);
				}
				return r_maxCharactersInDocument;
			}
		}

		/// <summary>
		/// System.Int64 maxCharactersFromEntities
		/// </summary>
		protected RField r_maxCharactersFromEntities;
		public virtual RField RmaxCharactersFromEntities
		{
			get
			{
				if(r_maxCharactersFromEntities == null)
				{
					r_maxCharactersFromEntities = new(this, "maxCharactersFromEntities");
					r_maxCharactersFromEntities.SetBelong(this.instance);
				}
				return r_maxCharactersFromEntities;
			}
		}

		/// <summary>
		/// System.Boolean ignoreWhitespace
		/// </summary>
		protected RField r_ignoreWhitespace;
		public virtual RField RignoreWhitespace
		{
			get
			{
				if(r_ignoreWhitespace == null)
				{
					r_ignoreWhitespace = new(this, "ignoreWhitespace");
					r_ignoreWhitespace.SetBelong(this.instance);
				}
				return r_ignoreWhitespace;
			}
		}

		/// <summary>
		/// System.Boolean ignorePIs
		/// </summary>
		protected RField r_ignorePIs;
		public virtual RField RignorePIs
		{
			get
			{
				if(r_ignorePIs == null)
				{
					r_ignorePIs = new(this, "ignorePIs");
					r_ignorePIs.SetBelong(this.instance);
				}
				return r_ignorePIs;
			}
		}

		/// <summary>
		/// System.Boolean ignoreComments
		/// </summary>
		protected RField r_ignoreComments;
		public virtual RField RignoreComments
		{
			get
			{
				if(r_ignoreComments == null)
				{
					r_ignoreComments = new(this, "ignoreComments");
					r_ignoreComments.SetBelong(this.instance);
				}
				return r_ignoreComments;
			}
		}

		/// <summary>
		/// System.Xml.DtdProcessing dtdProcessing
		/// </summary>
		protected RField r_dtdProcessing;
		public virtual RField RdtdProcessing
		{
			get
			{
				if(r_dtdProcessing == null)
				{
					r_dtdProcessing = new(this, "dtdProcessing");
					r_dtdProcessing.SetBelong(this.instance);
				}
				return r_dtdProcessing;
			}
		}

		/// <summary>
		/// System.Xml.ValidationType validationType
		/// </summary>
		protected RField r_validationType;
		public virtual RField RvalidationType
		{
			get
			{
				if(r_validationType == null)
				{
					r_validationType = new(this, "validationType");
					r_validationType.SetBelong(this.instance);
				}
				return r_validationType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaValidationFlags validationFlags
		/// </summary>
		protected RField r_validationFlags;
		public virtual RField RvalidationFlags
		{
			get
			{
				if(r_validationFlags == null)
				{
					r_validationFlags = new(this, "validationFlags");
					r_validationFlags.SetBelong(this.instance);
				}
				return r_validationFlags;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSet schemas
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSet r_schemas;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSet Rschemas
		{
			get
			{
				if(r_schemas == null)
				{
					r_schemas = new(this, "schemas");
					r_schemas.SetBelong(this.instance);
				}
				return r_schemas;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ValidationEventHandler valEventHandler
		/// </summary>
		protected RSystem.RXml.RSchema.RValidationEventHandler r_valEventHandler;
		public virtual RSystem.RXml.RSchema.RValidationEventHandler RvalEventHandler
		{
			get
			{
				if(r_valEventHandler == null)
				{
					r_valEventHandler = new(this, "valEventHandler");
					r_valEventHandler.SetBelong(this.instance);
				}
				return r_valEventHandler;
			}
		}

		/// <summary>
		/// System.Boolean closeInput
		/// </summary>
		protected RField r_closeInput;
		public virtual RField RcloseInput
		{
			get
			{
				if(r_closeInput == null)
				{
					r_closeInput = new(this, "closeInput");
					r_closeInput.SetBelong(this.instance);
				}
				return r_closeInput;
			}
		}

		/// <summary>
		/// System.Boolean isReadOnly
		/// </summary>
		protected RField r_isReadOnly;
		public virtual RField RisReadOnly
		{
			get
			{
				if(r_isReadOnly == null)
				{
					r_isReadOnly = new(this, "isReadOnly");
					r_isReadOnly.SetBelong(this.instance);
				}
				return r_isReadOnly;
			}
		}

		/// <summary>
		/// System.Boolean <IsXmlResolverSet>k__BackingField
		/// </summary>
		protected RField r___2__IsXmlResolverSet__4__k__BackingField;
		public virtual RField R__2__IsXmlResolverSet__4__k__BackingField
		{
			get
			{
				if(r___2__IsXmlResolverSet__4__k__BackingField == null)
				{
					r___2__IsXmlResolverSet__4__k__BackingField = new(this, "<IsXmlResolverSet>k__BackingField");
					r___2__IsXmlResolverSet__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__IsXmlResolverSet__4__k__BackingField;
			}
		}

		/// <summary>
		/// System.Nullable`1[System.Boolean] s_enableLegacyXmlSettings
		/// </summary>
		protected static RField r_s_enableLegacyXmlSettings;
		public static RField Rs_enableLegacyXmlSettings
		{
			get
			{
				if(r_s_enableLegacyXmlSettings == null)
				{
					r_s_enableLegacyXmlSettings = new(typeof(System.Xml.XmlReaderSettings), "s_enableLegacyXmlSettings");
					r_s_enableLegacyXmlSettings.SetBelong(null);
				}
				return r_s_enableLegacyXmlSettings;
			}
		}

		/// <summary>
		/// Boolean Async
		/// </summary>
		protected RProperty r_Async;
		public virtual RProperty RAsync
		{
			get
			{
				if(r_Async == null)
				{
					r_Async = new(this, "Async", -1);
					r_Async.SetBelong(this.instance);
				}
				return r_Async;
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
		/// Boolean IsXmlResolverSet
		/// </summary>
		protected RProperty r_IsXmlResolverSet;
		public virtual RProperty RIsXmlResolverSet
		{
			get
			{
				if(r_IsXmlResolverSet == null)
				{
					r_IsXmlResolverSet = new(this, "IsXmlResolverSet", -1);
					r_IsXmlResolverSet.SetBelong(this.instance);
				}
				return r_IsXmlResolverSet;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver XmlResolver
		/// </summary>
		protected RSystem.RXml.RXmlResolver r_XmlResolver_XmlResolver;
		public virtual RSystem.RXml.RXmlResolver RXmlResolver_XmlResolver
		{
			get
			{
				if(r_XmlResolver_XmlResolver == null)
				{
					r_XmlResolver_XmlResolver = new(this, "XmlResolver", -1, typeof(System.Xml.XmlResolver));
					r_XmlResolver_XmlResolver.SetBelong(this.instance);
				}
				return r_XmlResolver_XmlResolver;
			}
		}

		/// <summary>
		/// Int32 LineNumberOffset
		/// </summary>
		protected RProperty r_LineNumberOffset;
		public virtual RProperty RLineNumberOffset
		{
			get
			{
				if(r_LineNumberOffset == null)
				{
					r_LineNumberOffset = new(this, "LineNumberOffset", -1);
					r_LineNumberOffset.SetBelong(this.instance);
				}
				return r_LineNumberOffset;
			}
		}

		/// <summary>
		/// Int32 LinePositionOffset
		/// </summary>
		protected RProperty r_LinePositionOffset;
		public virtual RProperty RLinePositionOffset
		{
			get
			{
				if(r_LinePositionOffset == null)
				{
					r_LinePositionOffset = new(this, "LinePositionOffset", -1);
					r_LinePositionOffset.SetBelong(this.instance);
				}
				return r_LinePositionOffset;
			}
		}

		/// <summary>
		/// System.Xml.ConformanceLevel ConformanceLevel
		/// </summary>
		protected RProperty r_ConformanceLevel;
		public virtual RProperty RConformanceLevel
		{
			get
			{
				if(r_ConformanceLevel == null)
				{
					r_ConformanceLevel = new(this, "ConformanceLevel", -1);
					r_ConformanceLevel.SetBelong(this.instance);
				}
				return r_ConformanceLevel;
			}
		}

		/// <summary>
		/// Boolean CheckCharacters
		/// </summary>
		protected RProperty r_CheckCharacters;
		public virtual RProperty RCheckCharacters
		{
			get
			{
				if(r_CheckCharacters == null)
				{
					r_CheckCharacters = new(this, "CheckCharacters", -1);
					r_CheckCharacters.SetBelong(this.instance);
				}
				return r_CheckCharacters;
			}
		}

		/// <summary>
		/// Int64 MaxCharactersInDocument
		/// </summary>
		protected RProperty r_MaxCharactersInDocument;
		public virtual RProperty RMaxCharactersInDocument
		{
			get
			{
				if(r_MaxCharactersInDocument == null)
				{
					r_MaxCharactersInDocument = new(this, "MaxCharactersInDocument", -1);
					r_MaxCharactersInDocument.SetBelong(this.instance);
				}
				return r_MaxCharactersInDocument;
			}
		}

		/// <summary>
		/// Int64 MaxCharactersFromEntities
		/// </summary>
		protected RProperty r_MaxCharactersFromEntities;
		public virtual RProperty RMaxCharactersFromEntities
		{
			get
			{
				if(r_MaxCharactersFromEntities == null)
				{
					r_MaxCharactersFromEntities = new(this, "MaxCharactersFromEntities", -1);
					r_MaxCharactersFromEntities.SetBelong(this.instance);
				}
				return r_MaxCharactersFromEntities;
			}
		}

		/// <summary>
		/// Boolean IgnoreWhitespace
		/// </summary>
		protected RProperty r_IgnoreWhitespace;
		public virtual RProperty RIgnoreWhitespace
		{
			get
			{
				if(r_IgnoreWhitespace == null)
				{
					r_IgnoreWhitespace = new(this, "IgnoreWhitespace", -1);
					r_IgnoreWhitespace.SetBelong(this.instance);
				}
				return r_IgnoreWhitespace;
			}
		}

		/// <summary>
		/// Boolean IgnoreProcessingInstructions
		/// </summary>
		protected RProperty r_IgnoreProcessingInstructions;
		public virtual RProperty RIgnoreProcessingInstructions
		{
			get
			{
				if(r_IgnoreProcessingInstructions == null)
				{
					r_IgnoreProcessingInstructions = new(this, "IgnoreProcessingInstructions", -1);
					r_IgnoreProcessingInstructions.SetBelong(this.instance);
				}
				return r_IgnoreProcessingInstructions;
			}
		}

		/// <summary>
		/// Boolean IgnoreComments
		/// </summary>
		protected RProperty r_IgnoreComments;
		public virtual RProperty RIgnoreComments
		{
			get
			{
				if(r_IgnoreComments == null)
				{
					r_IgnoreComments = new(this, "IgnoreComments", -1);
					r_IgnoreComments.SetBelong(this.instance);
				}
				return r_IgnoreComments;
			}
		}

		/// <summary>
		/// Boolean ProhibitDtd
		/// </summary>
		protected RProperty r_ProhibitDtd;
		public virtual RProperty RProhibitDtd
		{
			get
			{
				if(r_ProhibitDtd == null)
				{
					r_ProhibitDtd = new(this, "ProhibitDtd", -1);
					r_ProhibitDtd.SetBelong(this.instance);
				}
				return r_ProhibitDtd;
			}
		}

		/// <summary>
		/// System.Xml.DtdProcessing DtdProcessing
		/// </summary>
		protected RProperty r_DtdProcessing;
		public virtual RProperty RDtdProcessing
		{
			get
			{
				if(r_DtdProcessing == null)
				{
					r_DtdProcessing = new(this, "DtdProcessing", -1);
					r_DtdProcessing.SetBelong(this.instance);
				}
				return r_DtdProcessing;
			}
		}

		/// <summary>
		/// Boolean CloseInput
		/// </summary>
		protected RProperty r_CloseInput;
		public virtual RProperty RCloseInput
		{
			get
			{
				if(r_CloseInput == null)
				{
					r_CloseInput = new(this, "CloseInput", -1);
					r_CloseInput.SetBelong(this.instance);
				}
				return r_CloseInput;
			}
		}

		/// <summary>
		/// System.Xml.ValidationType ValidationType
		/// </summary>
		protected RProperty r_ValidationType;
		public virtual RProperty RValidationType
		{
			get
			{
				if(r_ValidationType == null)
				{
					r_ValidationType = new(this, "ValidationType", -1);
					r_ValidationType.SetBelong(this.instance);
				}
				return r_ValidationType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaValidationFlags ValidationFlags
		/// </summary>
		protected RProperty r_ValidationFlags;
		public virtual RProperty RValidationFlags
		{
			get
			{
				if(r_ValidationFlags == null)
				{
					r_ValidationFlags = new(this, "ValidationFlags", -1);
					r_ValidationFlags.SetBelong(this.instance);
				}
				return r_ValidationFlags;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSet Schemas
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSet r_Schemas;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSet RSchemas
		{
			get
			{
				if(r_Schemas == null)
				{
					r_Schemas = new(this, "Schemas", -1);
					r_Schemas.SetBelong(this.instance);
				}
				return r_Schemas;
			}
		}

		/// <summary>
		/// Boolean ReadOnly
		/// </summary>
		protected RProperty r_ReadOnly;
		public virtual RProperty ReadOnly
		{
			get
			{
				if(r_ReadOnly == null)
				{
					r_ReadOnly = new(this, "ReadOnly", -1);
					r_ReadOnly.SetBelong(this.instance);
				}
				return r_ReadOnly;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ValidationEventHandler ValidationEventHandler
		/// </summary>
		protected REvent r_ValidationEventHandler;
		public virtual REvent RValidationEventHandler
		{
			get
			{
				if(r_ValidationEventHandler == null)
				{
					r_ValidationEventHandler = new(this, "ValidationEventHandler");
					r_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_ValidationEventHandler;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver GetXmlResolver()
		/// </summary>
		protected RMethod r_RGetXmlResolver;
		public virtual RMethod RGetXmlResolver
		{
			get
			{
				if(r_RGetXmlResolver == null)
				{
					r_RGetXmlResolver = new(this, "GetXmlResolver", 0);
					r_RGetXmlResolver.SetBelong(this.instance);
				}
				return r_RGetXmlResolver;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver GetXmlResolver_CheckConfig()
		/// </summary>
		protected RMethod r_RGetXmlResolver_CheckConfig;
		public virtual RMethod RGetXmlResolver_CheckConfig
		{
			get
			{
				if(r_RGetXmlResolver_CheckConfig == null)
				{
					r_RGetXmlResolver_CheckConfig = new(this, "GetXmlResolver_CheckConfig", 0);
					r_RGetXmlResolver_CheckConfig.SetBelong(this.instance);
				}
				return r_RGetXmlResolver_CheckConfig;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// System.Xml.XmlReaderSettings Clone()
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
		/// System.Xml.Schema.ValidationEventHandler GetEventHandler()
		/// </summary>
		protected RMethod r_RGetEventHandler;
		public virtual RMethod RGetEventHandler
		{
			get
			{
				if(r_RGetEventHandler == null)
				{
					r_RGetEventHandler = new(this, "GetEventHandler", 0);
					r_RGetEventHandler.SetBelong(this.instance);
				}
				return r_RGetEventHandler;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader CreateReader(System.String, System.Xml.XmlParserContext)
		/// </summary>
		protected RMethod r_RCreateReader_String_XmlParserContext;
		public virtual RMethod RCreateReader_String_XmlParserContext
		{
			get
			{
				if(r_RCreateReader_String_XmlParserContext == null)
				{
					r_RCreateReader_String_XmlParserContext = new(this, "CreateReader", 0, typeof(System.String), typeof(System.Xml.XmlParserContext));
					r_RCreateReader_String_XmlParserContext.SetBelong(this.instance);
				}
				return r_RCreateReader_String_XmlParserContext;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader CreateReader(System.IO.Stream, System.Uri, System.String, System.Xml.XmlParserContext)
		/// </summary>
		protected RMethod r_RCreateReader_Stream_Uri_String_XmlParserContext;
		public virtual RMethod RCreateReader_Stream_Uri_String_XmlParserContext
		{
			get
			{
				if(r_RCreateReader_Stream_Uri_String_XmlParserContext == null)
				{
					r_RCreateReader_Stream_Uri_String_XmlParserContext = new(this, "CreateReader", 0, typeof(System.IO.Stream), typeof(System.Uri), typeof(System.String), typeof(System.Xml.XmlParserContext));
					r_RCreateReader_Stream_Uri_String_XmlParserContext.SetBelong(this.instance);
				}
				return r_RCreateReader_Stream_Uri_String_XmlParserContext;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
		/// </summary>
		protected RMethod r_RCreateReader_TextReader_String_XmlParserContext;
		public virtual RMethod RCreateReader_TextReader_String_XmlParserContext
		{
			get
			{
				if(r_RCreateReader_TextReader_String_XmlParserContext == null)
				{
					r_RCreateReader_TextReader_String_XmlParserContext = new(this, "CreateReader", 0, typeof(System.IO.TextReader), typeof(System.String), typeof(System.Xml.XmlParserContext));
					r_RCreateReader_TextReader_String_XmlParserContext.SetBelong(this.instance);
				}
				return r_RCreateReader_TextReader_String_XmlParserContext;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader CreateReader(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RCreateReader_XmlReader;
		public virtual RMethod RCreateReader_XmlReader
		{
			get
			{
				if(r_RCreateReader_XmlReader == null)
				{
					r_RCreateReader_XmlReader = new(this, "CreateReader", 0, typeof(System.Xml.XmlReader));
					r_RCreateReader_XmlReader.SetBelong(this.instance);
				}
				return r_RCreateReader_XmlReader;
			}
		}

		/// <summary>
		/// Void CheckReadOnly(System.String)
		/// </summary>
		protected RMethod r_RCheckReadOnly_String;
		public virtual RMethod RCheckReadOnly_String
		{
			get
			{
				if(r_RCheckReadOnly_String == null)
				{
					r_RCheckReadOnly_String = new(this, "CheckReadOnly", 0, typeof(System.String));
					r_RCheckReadOnly_String.SetBelong(this.instance);
				}
				return r_RCheckReadOnly_String;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_RInitialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_RInitialize == null)
				{
					r_RInitialize = new(this, "Initialize", 0);
					r_RInitialize.SetBelong(this.instance);
				}
				return r_RInitialize;
			}
		}

		/// <summary>
		/// Void Initialize(System.Xml.XmlResolver)
		/// </summary>
		protected RMethod r_RInitialize_XmlResolver;
		public virtual RMethod RInitialize_XmlResolver
		{
			get
			{
				if(r_RInitialize_XmlResolver == null)
				{
					r_RInitialize_XmlResolver = new(this, "Initialize", 0, typeof(System.Xml.XmlResolver));
					r_RInitialize_XmlResolver.SetBelong(this.instance);
				}
				return r_RInitialize_XmlResolver;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver CreateDefaultResolver()
		/// </summary>
		protected static RMethod r_RCreateDefaultResolver;
		public static RMethod RCreateDefaultResolver
		{
			get
			{
				if(r_RCreateDefaultResolver == null)
				{
					r_RCreateDefaultResolver = new(typeof(System.Xml.XmlReaderSettings), "CreateDefaultResolver", 0);
					r_RCreateDefaultResolver.SetBelong(null);
				}
				return r_RCreateDefaultResolver;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader AddValidation(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RAddValidation_XmlReader;
		public virtual RMethod RAddValidation_XmlReader
		{
			get
			{
				if(r_RAddValidation_XmlReader == null)
				{
					r_RAddValidation_XmlReader = new(this, "AddValidation", 0, typeof(System.Xml.XmlReader));
					r_RAddValidation_XmlReader.SetBelong(this.instance);
				}
				return r_RAddValidation_XmlReader;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader AddValidationAndConformanceWrapper(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RAddValidationAndConformanceWrapper_XmlReader;
		public virtual RMethod RAddValidationAndConformanceWrapper_XmlReader
		{
			get
			{
				if(r_RAddValidationAndConformanceWrapper_XmlReader == null)
				{
					r_RAddValidationAndConformanceWrapper_XmlReader = new(this, "AddValidationAndConformanceWrapper", 0, typeof(System.Xml.XmlReader));
					r_RAddValidationAndConformanceWrapper_XmlReader.SetBelong(this.instance);
				}
				return r_RAddValidationAndConformanceWrapper_XmlReader;
			}
		}

		/// <summary>
		/// System.Xml.XmlValidatingReaderImpl CreateDtdValidatingReader(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RCreateDtdValidatingReader_XmlReader;
		public virtual RMethod RCreateDtdValidatingReader_XmlReader
		{
			get
			{
				if(r_RCreateDtdValidatingReader_XmlReader == null)
				{
					r_RCreateDtdValidatingReader_XmlReader = new(this, "CreateDtdValidatingReader", 0, typeof(System.Xml.XmlReader));
					r_RCreateDtdValidatingReader_XmlReader.SetBelong(this.instance);
				}
				return r_RCreateDtdValidatingReader_XmlReader;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader AddConformanceWrapper(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RAddConformanceWrapper_XmlReader;
		public virtual RMethod RAddConformanceWrapper_XmlReader
		{
			get
			{
				if(r_RAddConformanceWrapper_XmlReader == null)
				{
					r_RAddConformanceWrapper_XmlReader = new(this, "AddConformanceWrapper", 0, typeof(System.Xml.XmlReader));
					r_RAddConformanceWrapper_XmlReader.SetBelong(this.instance);
				}
				return r_RAddConformanceWrapper_XmlReader;
			}
		}

		/// <summary>
		/// Boolean EnableLegacyXmlSettings()
		/// </summary>
		protected static RMethod r_REnableLegacyXmlSettings;
		public static RMethod REnableLegacyXmlSettings
		{
			get
			{
				if(r_REnableLegacyXmlSettings == null)
				{
					r_REnableLegacyXmlSettings = new(typeof(System.Xml.XmlReaderSettings), "EnableLegacyXmlSettings", 0);
					r_REnableLegacyXmlSettings.SetBelong(null);
				}
				return r_REnableLegacyXmlSettings;
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


        public RXmlReaderSettings() : base("System.Xml.XmlReaderSettings")
        {
        }

        public RXmlReaderSettings(System.Object instance) : base("System.Xml.XmlReaderSettings")
		{
            SetInstance(instance);
		}

        public RXmlReaderSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlReaderSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Xml.XmlResolver GetXmlResolver()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetXmlResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlResolver)___result;
        }


        public virtual System.Xml.XmlResolver GetXmlResolver_CheckConfig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetXmlResolver_CheckConfig.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlResolver)___result;
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlReaderSettings Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReaderSettings)___result;
        }


        public virtual System.Xml.Schema.ValidationEventHandler GetEventHandler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.ValidationEventHandler)___result;
        }


        public virtual System.Xml.XmlReader CreateReader(System.String  @inputUri, System.Xml.XmlParserContext  @inputContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@inputUri, @inputContext};
            var ___result = RCreateReader_String_XmlParserContext.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual System.Xml.XmlReader CreateReader(System.IO.Stream  @input, System.Uri  @baseUri, System.String  @baseUriString, System.Xml.XmlParserContext  @inputContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @baseUri, @baseUriString, @inputContext};
            var ___result = RCreateReader_Stream_Uri_String_XmlParserContext.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual System.Xml.XmlReader CreateReader(System.IO.TextReader  @input, System.String  @baseUriString, System.Xml.XmlParserContext  @inputContext)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@input, @baseUriString, @inputContext};
            var ___result = RCreateReader_TextReader_String_XmlParserContext.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual System.Xml.XmlReader CreateReader(System.Xml.XmlReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader};
            var ___result = RCreateReader_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual void CheckReadOnly(System.String  @propertyName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propertyName};
            var ___result = RCheckReadOnly_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize(System.Xml.XmlResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resolver};
            var ___result = RInitialize_XmlResolver.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Xml.XmlResolver CreateDefaultResolver()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreateDefaultResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlResolver)___result;
        }


        public virtual System.Xml.XmlReader AddValidation(System.Xml.XmlReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader};
            var ___result = RAddValidation_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual System.Xml.XmlReader AddValidationAndConformanceWrapper(System.Xml.XmlReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader};
            var ___result = RAddValidationAndConformanceWrapper_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual System.Object CreateDtdValidatingReader(System.Xml.XmlReader  @baseReader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseReader};
            var ___result = RCreateDtdValidatingReader_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Xml.XmlReader AddConformanceWrapper(System.Xml.XmlReader  @baseReader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseReader};
            var ___result = RAddConformanceWrapper_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public static System.Boolean EnableLegacyXmlSettings()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnableLegacyXmlSettings.Invoke(___genericsType, ___parameters);

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
