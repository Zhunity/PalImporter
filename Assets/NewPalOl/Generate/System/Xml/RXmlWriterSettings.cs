using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlWriterSettings
	/// </summary>
    public partial class RXmlWriterSettings : RMember //
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
		/// System.Text.Encoding encoding
		/// </summary>
		protected RSystem.RText.REncoding r_encoding;
		public virtual RSystem.RText.REncoding Rencoding
		{
			get
			{
				if(r_encoding == null)
				{
					r_encoding = new(this, "encoding");
					r_encoding.SetBelong(this.instance);
				}
				return r_encoding;
			}
		}

		/// <summary>
		/// System.Boolean omitXmlDecl
		/// </summary>
		protected RField r_omitXmlDecl;
		public virtual RField RomitXmlDecl
		{
			get
			{
				if(r_omitXmlDecl == null)
				{
					r_omitXmlDecl = new(this, "omitXmlDecl");
					r_omitXmlDecl.SetBelong(this.instance);
				}
				return r_omitXmlDecl;
			}
		}

		/// <summary>
		/// System.Xml.NewLineHandling newLineHandling
		/// </summary>
		protected RField r_newLineHandling;
		public virtual RField RnewLineHandling
		{
			get
			{
				if(r_newLineHandling == null)
				{
					r_newLineHandling = new(this, "newLineHandling");
					r_newLineHandling.SetBelong(this.instance);
				}
				return r_newLineHandling;
			}
		}

		/// <summary>
		/// System.String newLineChars
		/// </summary>
		protected RField r_newLineChars;
		public virtual RField RnewLineChars
		{
			get
			{
				if(r_newLineChars == null)
				{
					r_newLineChars = new(this, "newLineChars");
					r_newLineChars.SetBelong(this.instance);
				}
				return r_newLineChars;
			}
		}

		/// <summary>
		/// System.Xml.TriState indent
		/// </summary>
		protected RField r_indent;
		public virtual RField Rindent
		{
			get
			{
				if(r_indent == null)
				{
					r_indent = new(this, "indent");
					r_indent.SetBelong(this.instance);
				}
				return r_indent;
			}
		}

		/// <summary>
		/// System.String indentChars
		/// </summary>
		protected RField r_indentChars;
		public virtual RField RindentChars
		{
			get
			{
				if(r_indentChars == null)
				{
					r_indentChars = new(this, "indentChars");
					r_indentChars.SetBelong(this.instance);
				}
				return r_indentChars;
			}
		}

		/// <summary>
		/// System.Boolean newLineOnAttributes
		/// </summary>
		protected RField r_newLineOnAttributes;
		public virtual RField RnewLineOnAttributes
		{
			get
			{
				if(r_newLineOnAttributes == null)
				{
					r_newLineOnAttributes = new(this, "newLineOnAttributes");
					r_newLineOnAttributes.SetBelong(this.instance);
				}
				return r_newLineOnAttributes;
			}
		}

		/// <summary>
		/// System.Boolean closeOutput
		/// </summary>
		protected RField r_closeOutput;
		public virtual RField RcloseOutput
		{
			get
			{
				if(r_closeOutput == null)
				{
					r_closeOutput = new(this, "closeOutput");
					r_closeOutput.SetBelong(this.instance);
				}
				return r_closeOutput;
			}
		}

		/// <summary>
		/// System.Xml.NamespaceHandling namespaceHandling
		/// </summary>
		protected RField r_namespaceHandling;
		public virtual RField RnamespaceHandling
		{
			get
			{
				if(r_namespaceHandling == null)
				{
					r_namespaceHandling = new(this, "namespaceHandling");
					r_namespaceHandling.SetBelong(this.instance);
				}
				return r_namespaceHandling;
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
		/// System.Boolean writeEndDocumentOnClose
		/// </summary>
		protected RField r_writeEndDocumentOnClose;
		public virtual RField RwriteEndDocumentOnClose
		{
			get
			{
				if(r_writeEndDocumentOnClose == null)
				{
					r_writeEndDocumentOnClose = new(this, "writeEndDocumentOnClose");
					r_writeEndDocumentOnClose.SetBelong(this.instance);
				}
				return r_writeEndDocumentOnClose;
			}
		}

		/// <summary>
		/// System.Xml.XmlOutputMethod outputMethod
		/// </summary>
		protected RField r_outputMethod;
		public virtual RField RoutputMethod
		{
			get
			{
				if(r_outputMethod == null)
				{
					r_outputMethod = new(this, "outputMethod");
					r_outputMethod.SetBelong(this.instance);
				}
				return r_outputMethod;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Xml.XmlQualifiedName] cdataSections
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RXml.RXmlQualifiedName> r_cdataSections;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RXml.RXmlQualifiedName> RcdataSections
		{
			get
			{
				if(r_cdataSections == null)
				{
					r_cdataSections = new(this, "cdataSections");
					r_cdataSections.SetBelong(this.instance);
				}
				return r_cdataSections;
			}
		}

		/// <summary>
		/// System.Boolean doNotEscapeUriAttributes
		/// </summary>
		protected RField r_doNotEscapeUriAttributes;
		public virtual RField RdoNotEscapeUriAttributes
		{
			get
			{
				if(r_doNotEscapeUriAttributes == null)
				{
					r_doNotEscapeUriAttributes = new(this, "doNotEscapeUriAttributes");
					r_doNotEscapeUriAttributes.SetBelong(this.instance);
				}
				return r_doNotEscapeUriAttributes;
			}
		}

		/// <summary>
		/// System.Boolean mergeCDataSections
		/// </summary>
		protected RField r_mergeCDataSections;
		public virtual RField RmergeCDataSections
		{
			get
			{
				if(r_mergeCDataSections == null)
				{
					r_mergeCDataSections = new(this, "mergeCDataSections");
					r_mergeCDataSections.SetBelong(this.instance);
				}
				return r_mergeCDataSections;
			}
		}

		/// <summary>
		/// System.String mediaType
		/// </summary>
		protected RField r_mediaType;
		public virtual RField RmediaType
		{
			get
			{
				if(r_mediaType == null)
				{
					r_mediaType = new(this, "mediaType");
					r_mediaType.SetBelong(this.instance);
				}
				return r_mediaType;
			}
		}

		/// <summary>
		/// System.String docTypeSystem
		/// </summary>
		protected RField r_docTypeSystem;
		public virtual RField RdocTypeSystem
		{
			get
			{
				if(r_docTypeSystem == null)
				{
					r_docTypeSystem = new(this, "docTypeSystem");
					r_docTypeSystem.SetBelong(this.instance);
				}
				return r_docTypeSystem;
			}
		}

		/// <summary>
		/// System.String docTypePublic
		/// </summary>
		protected RField r_docTypePublic;
		public virtual RField RdocTypePublic
		{
			get
			{
				if(r_docTypePublic == null)
				{
					r_docTypePublic = new(this, "docTypePublic");
					r_docTypePublic.SetBelong(this.instance);
				}
				return r_docTypePublic;
			}
		}

		/// <summary>
		/// System.Xml.XmlStandalone standalone
		/// </summary>
		protected RField r_standalone;
		public virtual RField Rstandalone
		{
			get
			{
				if(r_standalone == null)
				{
					r_standalone = new(this, "standalone");
					r_standalone.SetBelong(this.instance);
				}
				return r_standalone;
			}
		}

		/// <summary>
		/// System.Boolean autoXmlDecl
		/// </summary>
		protected RField r_autoXmlDecl;
		public virtual RField RautoXmlDecl
		{
			get
			{
				if(r_autoXmlDecl == null)
				{
					r_autoXmlDecl = new(this, "autoXmlDecl");
					r_autoXmlDecl.SetBelong(this.instance);
				}
				return r_autoXmlDecl;
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
		/// Boolean OmitXmlDeclaration
		/// </summary>
		protected RProperty r_OmitXmlDeclaration;
		public virtual RProperty ROmitXmlDeclaration
		{
			get
			{
				if(r_OmitXmlDeclaration == null)
				{
					r_OmitXmlDeclaration = new(this, "OmitXmlDeclaration", -1);
					r_OmitXmlDeclaration.SetBelong(this.instance);
				}
				return r_OmitXmlDeclaration;
			}
		}

		/// <summary>
		/// System.Xml.NewLineHandling NewLineHandling
		/// </summary>
		protected RProperty r_NewLineHandling;
		public virtual RProperty RNewLineHandling
		{
			get
			{
				if(r_NewLineHandling == null)
				{
					r_NewLineHandling = new(this, "NewLineHandling", -1);
					r_NewLineHandling.SetBelong(this.instance);
				}
				return r_NewLineHandling;
			}
		}

		/// <summary>
		/// System.String NewLineChars
		/// </summary>
		protected RProperty r_NewLineChars;
		public virtual RProperty RNewLineChars
		{
			get
			{
				if(r_NewLineChars == null)
				{
					r_NewLineChars = new(this, "NewLineChars", -1);
					r_NewLineChars.SetBelong(this.instance);
				}
				return r_NewLineChars;
			}
		}

		/// <summary>
		/// Boolean Indent
		/// </summary>
		protected RProperty r_Indent;
		public virtual RProperty RIndent
		{
			get
			{
				if(r_Indent == null)
				{
					r_Indent = new(this, "Indent", -1);
					r_Indent.SetBelong(this.instance);
				}
				return r_Indent;
			}
		}

		/// <summary>
		/// System.String IndentChars
		/// </summary>
		protected RProperty r_IndentChars;
		public virtual RProperty RIndentChars
		{
			get
			{
				if(r_IndentChars == null)
				{
					r_IndentChars = new(this, "IndentChars", -1);
					r_IndentChars.SetBelong(this.instance);
				}
				return r_IndentChars;
			}
		}

		/// <summary>
		/// Boolean NewLineOnAttributes
		/// </summary>
		protected RProperty r_NewLineOnAttributes;
		public virtual RProperty RNewLineOnAttributes
		{
			get
			{
				if(r_NewLineOnAttributes == null)
				{
					r_NewLineOnAttributes = new(this, "NewLineOnAttributes", -1);
					r_NewLineOnAttributes.SetBelong(this.instance);
				}
				return r_NewLineOnAttributes;
			}
		}

		/// <summary>
		/// Boolean CloseOutput
		/// </summary>
		protected RProperty r_CloseOutput;
		public virtual RProperty RCloseOutput
		{
			get
			{
				if(r_CloseOutput == null)
				{
					r_CloseOutput = new(this, "CloseOutput", -1);
					r_CloseOutput.SetBelong(this.instance);
				}
				return r_CloseOutput;
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
		/// System.Xml.NamespaceHandling NamespaceHandling
		/// </summary>
		protected RProperty r_NamespaceHandling;
		public virtual RProperty RNamespaceHandling
		{
			get
			{
				if(r_NamespaceHandling == null)
				{
					r_NamespaceHandling = new(this, "NamespaceHandling", -1);
					r_NamespaceHandling.SetBelong(this.instance);
				}
				return r_NamespaceHandling;
			}
		}

		/// <summary>
		/// Boolean WriteEndDocumentOnClose
		/// </summary>
		protected RProperty r_WriteEndDocumentOnClose;
		public virtual RProperty RWriteEndDocumentOnClose
		{
			get
			{
				if(r_WriteEndDocumentOnClose == null)
				{
					r_WriteEndDocumentOnClose = new(this, "WriteEndDocumentOnClose", -1);
					r_WriteEndDocumentOnClose.SetBelong(this.instance);
				}
				return r_WriteEndDocumentOnClose;
			}
		}

		/// <summary>
		/// System.Xml.XmlOutputMethod OutputMethod
		/// </summary>
		protected RProperty r_OutputMethod;
		public virtual RProperty ROutputMethod
		{
			get
			{
				if(r_OutputMethod == null)
				{
					r_OutputMethod = new(this, "OutputMethod", -1);
					r_OutputMethod.SetBelong(this.instance);
				}
				return r_OutputMethod;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Xml.XmlQualifiedName] CDataSectionElements
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSystem.RXml.RXmlQualifiedName> r_CDataSectionElements;
		public virtual RSystem.RCollections.RGeneric.RList<RSystem.RXml.RXmlQualifiedName> RCDataSectionElements
		{
			get
			{
				if(r_CDataSectionElements == null)
				{
					r_CDataSectionElements = new(this, "CDataSectionElements", -1);
					r_CDataSectionElements.SetBelong(this.instance);
				}
				return r_CDataSectionElements;
			}
		}

		/// <summary>
		/// Boolean DoNotEscapeUriAttributes
		/// </summary>
		protected RProperty r_DoNotEscapeUriAttributes;
		public virtual RProperty RDoNotEscapeUriAttributes
		{
			get
			{
				if(r_DoNotEscapeUriAttributes == null)
				{
					r_DoNotEscapeUriAttributes = new(this, "DoNotEscapeUriAttributes", -1);
					r_DoNotEscapeUriAttributes.SetBelong(this.instance);
				}
				return r_DoNotEscapeUriAttributes;
			}
		}

		/// <summary>
		/// Boolean MergeCDataSections
		/// </summary>
		protected RProperty r_MergeCDataSections;
		public virtual RProperty RMergeCDataSections
		{
			get
			{
				if(r_MergeCDataSections == null)
				{
					r_MergeCDataSections = new(this, "MergeCDataSections", -1);
					r_MergeCDataSections.SetBelong(this.instance);
				}
				return r_MergeCDataSections;
			}
		}

		/// <summary>
		/// System.String MediaType
		/// </summary>
		protected RProperty r_MediaType;
		public virtual RProperty RMediaType
		{
			get
			{
				if(r_MediaType == null)
				{
					r_MediaType = new(this, "MediaType", -1);
					r_MediaType.SetBelong(this.instance);
				}
				return r_MediaType;
			}
		}

		/// <summary>
		/// System.String DocTypeSystem
		/// </summary>
		protected RProperty r_DocTypeSystem;
		public virtual RProperty RDocTypeSystem
		{
			get
			{
				if(r_DocTypeSystem == null)
				{
					r_DocTypeSystem = new(this, "DocTypeSystem", -1);
					r_DocTypeSystem.SetBelong(this.instance);
				}
				return r_DocTypeSystem;
			}
		}

		/// <summary>
		/// System.String DocTypePublic
		/// </summary>
		protected RProperty r_DocTypePublic;
		public virtual RProperty RDocTypePublic
		{
			get
			{
				if(r_DocTypePublic == null)
				{
					r_DocTypePublic = new(this, "DocTypePublic", -1);
					r_DocTypePublic.SetBelong(this.instance);
				}
				return r_DocTypePublic;
			}
		}

		/// <summary>
		/// System.Xml.XmlStandalone Standalone
		/// </summary>
		protected RProperty r_Standalone;
		public virtual RProperty RStandalone
		{
			get
			{
				if(r_Standalone == null)
				{
					r_Standalone = new(this, "Standalone", -1);
					r_Standalone.SetBelong(this.instance);
				}
				return r_Standalone;
			}
		}

		/// <summary>
		/// Boolean AutoXmlDeclaration
		/// </summary>
		protected RProperty r_AutoXmlDeclaration;
		public virtual RProperty RAutoXmlDeclaration
		{
			get
			{
				if(r_AutoXmlDeclaration == null)
				{
					r_AutoXmlDeclaration = new(this, "AutoXmlDeclaration", -1);
					r_AutoXmlDeclaration.SetBelong(this.instance);
				}
				return r_AutoXmlDeclaration;
			}
		}

		/// <summary>
		/// System.Xml.TriState IndentInternal
		/// </summary>
		protected RProperty r_IndentInternal;
		public virtual RProperty RIndentInternal
		{
			get
			{
				if(r_IndentInternal == null)
				{
					r_IndentInternal = new(this, "IndentInternal", -1);
					r_IndentInternal.SetBelong(this.instance);
				}
				return r_IndentInternal;
			}
		}

		/// <summary>
		/// Boolean IsQuerySpecific
		/// </summary>
		protected RProperty r_IsQuerySpecific;
		public virtual RProperty RIsQuerySpecific
		{
			get
			{
				if(r_IsQuerySpecific == null)
				{
					r_IsQuerySpecific = new(this, "IsQuerySpecific", -1);
					r_IsQuerySpecific.SetBelong(this.instance);
				}
				return r_IsQuerySpecific;
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
		/// System.Xml.XmlWriterSettings Clone()
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
		/// System.Xml.XmlWriter CreateWriter(System.String)
		/// </summary>
		protected RMethod r_RCreateWriter_String;
		public virtual RMethod RCreateWriter_String
		{
			get
			{
				if(r_RCreateWriter_String == null)
				{
					r_RCreateWriter_String = new(this, "CreateWriter", 0, typeof(System.String));
					r_RCreateWriter_String.SetBelong(this.instance);
				}
				return r_RCreateWriter_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter CreateWriter(System.IO.Stream)
		/// </summary>
		protected RMethod r_RCreateWriter_Stream;
		public virtual RMethod RCreateWriter_Stream
		{
			get
			{
				if(r_RCreateWriter_Stream == null)
				{
					r_RCreateWriter_Stream = new(this, "CreateWriter", 0, typeof(System.IO.Stream));
					r_RCreateWriter_Stream.SetBelong(this.instance);
				}
				return r_RCreateWriter_Stream;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter CreateWriter(System.IO.TextWriter)
		/// </summary>
		protected RMethod r_RCreateWriter_TextWriter;
		public virtual RMethod RCreateWriter_TextWriter
		{
			get
			{
				if(r_RCreateWriter_TextWriter == null)
				{
					r_RCreateWriter_TextWriter = new(this, "CreateWriter", 0, typeof(System.IO.TextWriter));
					r_RCreateWriter_TextWriter.SetBelong(this.instance);
				}
				return r_RCreateWriter_TextWriter;
			}
		}

		/// <summary>
		/// System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RCreateWriter_XmlWriter;
		public virtual RMethod RCreateWriter_XmlWriter
		{
			get
			{
				if(r_RCreateWriter_XmlWriter == null)
				{
					r_RCreateWriter_XmlWriter = new(this, "CreateWriter", 0, typeof(System.Xml.XmlWriter));
					r_RCreateWriter_XmlWriter.SetBelong(this.instance);
				}
				return r_RCreateWriter_XmlWriter;
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
		/// System.Xml.XmlWriter AddConformanceWrapper(System.Xml.XmlWriter)
		/// </summary>
		protected RMethod r_RAddConformanceWrapper_XmlWriter;
		public virtual RMethod RAddConformanceWrapper_XmlWriter
		{
			get
			{
				if(r_RAddConformanceWrapper_XmlWriter == null)
				{
					r_RAddConformanceWrapper_XmlWriter = new(this, "AddConformanceWrapper", 0, typeof(System.Xml.XmlWriter));
					r_RAddConformanceWrapper_XmlWriter.SetBelong(this.instance);
				}
				return r_RAddConformanceWrapper_XmlWriter;
			}
		}

		/// <summary>
		/// Void GetObjectData(System.Xml.Xsl.Runtime.XmlQueryDataWriter)
		/// </summary>
		protected RMethod r_RGetObjectData_XmlQueryDataWriter;
		public virtual RMethod RGetObjectData_XmlQueryDataWriter
		{
			get
			{
				if(r_RGetObjectData_XmlQueryDataWriter == null)
				{
					r_RGetObjectData_XmlQueryDataWriter = new(this, "GetObjectData", 0,  ReleactionUtils.GetType("System.Xml.Xsl.Runtime.XmlQueryDataWriter"));
					r_RGetObjectData_XmlQueryDataWriter.SetBelong(this.instance);
				}
				return r_RGetObjectData_XmlQueryDataWriter;
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


        public RXmlWriterSettings() : base("System.Xml.XmlWriterSettings")
        {
        }

        public RXmlWriterSettings(System.Object instance) : base("System.Xml.XmlWriterSettings")
		{
            SetInstance(instance);
		}

        public RXmlWriterSettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlWriterSettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlWriterSettings Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriterSettings)___result;
        }


        public virtual System.Xml.XmlWriter CreateWriter(System.String  @outputFileName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outputFileName};
            var ___result = RCreateWriter_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Xml.XmlWriter CreateWriter(System.IO.Stream  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output};
            var ___result = RCreateWriter_Stream.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Xml.XmlWriter CreateWriter(System.IO.TextWriter  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output};
            var ___result = RCreateWriter_TextWriter.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
        }


        public virtual System.Xml.XmlWriter CreateWriter(System.Xml.XmlWriter  @output)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@output};
            var ___result = RCreateWriter_XmlWriter.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
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


        public virtual System.Xml.XmlWriter AddConformanceWrapper(System.Xml.XmlWriter  @baseWriter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseWriter};
            var ___result = RAddConformanceWrapper_XmlWriter.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlWriter)___result;
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
