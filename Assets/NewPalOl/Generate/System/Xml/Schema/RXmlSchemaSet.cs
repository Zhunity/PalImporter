using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaSet
	/// </summary>
    public partial class RXmlSchemaSet : RMember //
    {

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
		/// System.Collections.SortedList schemas
		/// </summary>
		protected RSystem.RCollections.RSortedList r_schemas;
		public virtual RSystem.RCollections.RSortedList Rschemas
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
		/// System.Xml.Schema.ValidationEventHandler internalEventHandler
		/// </summary>
		protected RSystem.RXml.RSchema.RValidationEventHandler r_internalEventHandler;
		public virtual RSystem.RXml.RSchema.RValidationEventHandler RinternalEventHandler
		{
			get
			{
				if(r_internalEventHandler == null)
				{
					r_internalEventHandler = new(this, "internalEventHandler");
					r_internalEventHandler.SetBelong(this.instance);
				}
				return r_internalEventHandler;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ValidationEventHandler eventHandler
		/// </summary>
		protected RSystem.RXml.RSchema.RValidationEventHandler r_eventHandler;
		public virtual RSystem.RXml.RSchema.RValidationEventHandler ReventHandler
		{
			get
			{
				if(r_eventHandler == null)
				{
					r_eventHandler = new(this, "eventHandler");
					r_eventHandler.SetBelong(this.instance);
				}
				return r_eventHandler;
			}
		}

		/// <summary>
		/// System.Boolean isCompiled
		/// </summary>
		protected RField r_isCompiled;
		public virtual RField RisCompiled
		{
			get
			{
				if(r_isCompiled == null)
				{
					r_isCompiled = new(this, "isCompiled");
					r_isCompiled.SetBelong(this.instance);
				}
				return r_isCompiled;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable schemaLocations
		/// </summary>
		protected RSystem.RCollections.RHashtable r_schemaLocations;
		public virtual RSystem.RCollections.RHashtable RschemaLocations
		{
			get
			{
				if(r_schemaLocations == null)
				{
					r_schemaLocations = new(this, "schemaLocations");
					r_schemaLocations.SetBelong(this.instance);
				}
				return r_schemaLocations;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable chameleonSchemas
		/// </summary>
		protected RSystem.RCollections.RHashtable r_chameleonSchemas;
		public virtual RSystem.RCollections.RHashtable RchameleonSchemas
		{
			get
			{
				if(r_chameleonSchemas == null)
				{
					r_chameleonSchemas = new(this, "chameleonSchemas");
					r_chameleonSchemas.SetBelong(this.instance);
				}
				return r_chameleonSchemas;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable targetNamespaces
		/// </summary>
		protected RSystem.RCollections.RHashtable r_targetNamespaces;
		public virtual RSystem.RCollections.RHashtable RtargetNamespaces
		{
			get
			{
				if(r_targetNamespaces == null)
				{
					r_targetNamespaces = new(this, "targetNamespaces");
					r_targetNamespaces.SetBelong(this.instance);
				}
				return r_targetNamespaces;
			}
		}

		/// <summary>
		/// System.Boolean compileAll
		/// </summary>
		protected RField r_compileAll;
		public virtual RField RcompileAll
		{
			get
			{
				if(r_compileAll == null)
				{
					r_compileAll = new(this, "compileAll");
					r_compileAll.SetBelong(this.instance);
				}
				return r_compileAll;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaInfo cachedCompiledInfo
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaInfo r_cachedCompiledInfo;
		public virtual RSystem.RXml.RSchema.RSchemaInfo RcachedCompiledInfo
		{
			get
			{
				if(r_cachedCompiledInfo == null)
				{
					r_cachedCompiledInfo = new(this, "cachedCompiledInfo");
					r_cachedCompiledInfo.SetBelong(this.instance);
				}
				return r_cachedCompiledInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlReaderSettings readerSettings
		/// </summary>
		protected RSystem.RXml.RXmlReaderSettings r_readerSettings;
		public virtual RSystem.RXml.RXmlReaderSettings RreaderSettings
		{
			get
			{
				if(r_readerSettings == null)
				{
					r_readerSettings = new(this, "readerSettings");
					r_readerSettings.SetBelong(this.instance);
				}
				return r_readerSettings;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema schemaForSchema
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchema r_schemaForSchema;
		public virtual RSystem.RXml.RSchema.RXmlSchema RschemaForSchema
		{
			get
			{
				if(r_schemaForSchema == null)
				{
					r_schemaForSchema = new(this, "schemaForSchema");
					r_schemaForSchema.SetBelong(this.instance);
				}
				return r_schemaForSchema;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaCompilationSettings compilationSettings
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaCompilationSettings r_compilationSettings;
		public virtual RSystem.RXml.RSchema.RXmlSchemaCompilationSettings RcompilationSettings
		{
			get
			{
				if(r_compilationSettings == null)
				{
					r_compilationSettings = new(this, "compilationSettings");
					r_compilationSettings.SetBelong(this.instance);
				}
				return r_compilationSettings;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable elements
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_elements;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable Relements
		{
			get
			{
				if(r_elements == null)
				{
					r_elements = new(this, "elements");
					r_elements.SetBelong(this.instance);
				}
				return r_elements;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable attributes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_attributes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable Rattributes
		{
			get
			{
				if(r_attributes == null)
				{
					r_attributes = new(this, "attributes");
					r_attributes.SetBelong(this.instance);
				}
				return r_attributes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable schemaTypes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_schemaTypes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RschemaTypes
		{
			get
			{
				if(r_schemaTypes == null)
				{
					r_schemaTypes = new(this, "schemaTypes");
					r_schemaTypes.SetBelong(this.instance);
				}
				return r_schemaTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable substitutionGroups
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_substitutionGroups;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RsubstitutionGroups
		{
			get
			{
				if(r_substitutionGroups == null)
				{
					r_substitutionGroups = new(this, "substitutionGroups");
					r_substitutionGroups.SetBelong(this.instance);
				}
				return r_substitutionGroups;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable typeExtensions
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_typeExtensions;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RtypeExtensions
		{
			get
			{
				if(r_typeExtensions == null)
				{
					r_typeExtensions = new(this, "typeExtensions");
					r_typeExtensions.SetBelong(this.instance);
				}
				return r_typeExtensions;
			}
		}

		/// <summary>
		/// System.Object internalSyncObject
		/// </summary>
		protected RSystem.RObject r_internalSyncObject;
		public virtual RSystem.RObject RinternalSyncObject
		{
			get
			{
				if(r_internalSyncObject == null)
				{
					r_internalSyncObject = new(this, "internalSyncObject");
					r_internalSyncObject.SetBelong(this.instance);
				}
				return r_internalSyncObject;
			}
		}

		/// <summary>
		/// System.Object InternalSyncObject
		/// </summary>
		protected RSystem.RObject r_InternalSyncObject;
		public virtual RSystem.RObject RInternalSyncObject
		{
			get
			{
				if(r_InternalSyncObject == null)
				{
					r_InternalSyncObject = new(this, "InternalSyncObject", -1);
					r_InternalSyncObject.SetBelong(this.instance);
				}
				return r_InternalSyncObject;
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
		/// Boolean IsCompiled
		/// </summary>
		protected RProperty r_IsCompiled;
		public virtual RProperty RIsCompiled
		{
			get
			{
				if(r_IsCompiled == null)
				{
					r_IsCompiled = new(this, "IsCompiled", -1);
					r_IsCompiled.SetBelong(this.instance);
				}
				return r_IsCompiled;
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
		/// System.Xml.Schema.XmlSchemaCompilationSettings CompilationSettings
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaCompilationSettings r_CompilationSettings;
		public virtual RSystem.RXml.RSchema.RXmlSchemaCompilationSettings RCompilationSettings
		{
			get
			{
				if(r_CompilationSettings == null)
				{
					r_CompilationSettings = new(this, "CompilationSettings", -1);
					r_CompilationSettings.SetBelong(this.instance);
				}
				return r_CompilationSettings;
			}
		}

		/// <summary>
		/// Int32 Count
		/// </summary>
		protected RProperty r_Count;
		public virtual RProperty RCount
		{
			get
			{
				if(r_Count == null)
				{
					r_Count = new(this, "Count", -1);
					r_Count.SetBelong(this.instance);
				}
				return r_Count;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable GlobalElements
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_GlobalElements;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RGlobalElements
		{
			get
			{
				if(r_GlobalElements == null)
				{
					r_GlobalElements = new(this, "GlobalElements", -1);
					r_GlobalElements.SetBelong(this.instance);
				}
				return r_GlobalElements;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable GlobalAttributes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_GlobalAttributes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RGlobalAttributes
		{
			get
			{
				if(r_GlobalAttributes == null)
				{
					r_GlobalAttributes = new(this, "GlobalAttributes", -1);
					r_GlobalAttributes.SetBelong(this.instance);
				}
				return r_GlobalAttributes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable GlobalTypes
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_GlobalTypes;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RGlobalTypes
		{
			get
			{
				if(r_GlobalTypes == null)
				{
					r_GlobalTypes = new(this, "GlobalTypes", -1);
					r_GlobalTypes.SetBelong(this.instance);
				}
				return r_GlobalTypes;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable SubstitutionGroups
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_SubstitutionGroups;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RSubstitutionGroups
		{
			get
			{
				if(r_SubstitutionGroups == null)
				{
					r_SubstitutionGroups = new(this, "SubstitutionGroups", -1);
					r_SubstitutionGroups.SetBelong(this.instance);
				}
				return r_SubstitutionGroups;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable SchemaLocations
		/// </summary>
		protected RSystem.RCollections.RHashtable r_SchemaLocations;
		public virtual RSystem.RCollections.RHashtable RSchemaLocations
		{
			get
			{
				if(r_SchemaLocations == null)
				{
					r_SchemaLocations = new(this, "SchemaLocations", -1);
					r_SchemaLocations.SetBelong(this.instance);
				}
				return r_SchemaLocations;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObjectTable TypeExtensions
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObjectTable r_TypeExtensions;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObjectTable RTypeExtensions
		{
			get
			{
				if(r_TypeExtensions == null)
				{
					r_TypeExtensions = new(this, "TypeExtensions", -1);
					r_TypeExtensions.SetBelong(this.instance);
				}
				return r_TypeExtensions;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaInfo CompiledInfo
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaInfo r_CompiledInfo;
		public virtual RSystem.RXml.RSchema.RSchemaInfo RCompiledInfo
		{
			get
			{
				if(r_CompiledInfo == null)
				{
					r_CompiledInfo = new(this, "CompiledInfo", -1);
					r_CompiledInfo.SetBelong(this.instance);
				}
				return r_CompiledInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlReaderSettings ReaderSettings
		/// </summary>
		protected RSystem.RXml.RXmlReaderSettings r_ReaderSettings;
		public virtual RSystem.RXml.RXmlReaderSettings ReaderSettings
		{
			get
			{
				if(r_ReaderSettings == null)
				{
					r_ReaderSettings = new(this, "ReaderSettings", -1);
					r_ReaderSettings.SetBelong(this.instance);
				}
				return r_ReaderSettings;
			}
		}

		/// <summary>
		/// System.Collections.SortedList SortedSchemas
		/// </summary>
		protected RSystem.RCollections.RSortedList r_SortedSchemas;
		public virtual RSystem.RCollections.RSortedList RSortedSchemas
		{
			get
			{
				if(r_SortedSchemas == null)
				{
					r_SortedSchemas = new(this, "SortedSchemas", -1);
					r_SortedSchemas.SetBelong(this.instance);
				}
				return r_SortedSchemas;
			}
		}

		/// <summary>
		/// Boolean CompileAll
		/// </summary>
		protected RProperty r_CompileAll;
		public virtual RProperty RCompileAll
		{
			get
			{
				if(r_CompileAll == null)
				{
					r_CompileAll = new(this, "CompileAll", -1);
					r_CompileAll.SetBelong(this.instance);
				}
				return r_CompileAll;
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
		/// System.Xml.Schema.XmlSchema Add(System.String, System.String)
		/// </summary>
		protected RMethod r_RAdd_String_String;
		public virtual RMethod RAdd_String_String
		{
			get
			{
				if(r_RAdd_String_String == null)
				{
					r_RAdd_String_String = new(this, "Add", 0, typeof(System.String), typeof(System.String));
					r_RAdd_String_String.SetBelong(this.instance);
				}
				return r_RAdd_String_String;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Add(System.String, System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RAdd_String_XmlReader;
		public virtual RMethod RAdd_String_XmlReader
		{
			get
			{
				if(r_RAdd_String_XmlReader == null)
				{
					r_RAdd_String_XmlReader = new(this, "Add", 0, typeof(System.String), typeof(System.Xml.XmlReader));
					r_RAdd_String_XmlReader.SetBelong(this.instance);
				}
				return r_RAdd_String_XmlReader;
			}
		}

		/// <summary>
		/// Void Add(System.Xml.Schema.XmlSchemaSet)
		/// </summary>
		protected RMethod r_RAdd_XmlSchemaSet;
		public virtual RMethod RAdd_XmlSchemaSet
		{
			get
			{
				if(r_RAdd_XmlSchemaSet == null)
				{
					r_RAdd_XmlSchemaSet = new(this, "Add", 0, typeof(System.Xml.Schema.XmlSchemaSet));
					r_RAdd_XmlSchemaSet.SetBelong(this.instance);
				}
				return r_RAdd_XmlSchemaSet;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RAdd_XmlSchema;
		public virtual RMethod RAdd_XmlSchema
		{
			get
			{
				if(r_RAdd_XmlSchema == null)
				{
					r_RAdd_XmlSchema = new(this, "Add", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RAdd_XmlSchema.SetBelong(this.instance);
				}
				return r_RAdd_XmlSchema;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RRemove_XmlSchema;
		public virtual RMethod RRemove_XmlSchema
		{
			get
			{
				if(r_RRemove_XmlSchema == null)
				{
					r_RRemove_XmlSchema = new(this, "Remove", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RRemove_XmlSchema.SetBelong(this.instance);
				}
				return r_RRemove_XmlSchema;
			}
		}

		/// <summary>
		/// Boolean RemoveRecursive(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RRemoveRecursive_XmlSchema;
		public virtual RMethod RRemoveRecursive_XmlSchema
		{
			get
			{
				if(r_RRemoveRecursive_XmlSchema == null)
				{
					r_RRemoveRecursive_XmlSchema = new(this, "RemoveRecursive", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RRemoveRecursive_XmlSchema.SetBelong(this.instance);
				}
				return r_RRemoveRecursive_XmlSchema;
			}
		}

		/// <summary>
		/// Boolean Contains(System.String)
		/// </summary>
		protected RMethod r_RContains_String;
		public virtual RMethod RContains_String
		{
			get
			{
				if(r_RContains_String == null)
				{
					r_RContains_String = new(this, "Contains", 0, typeof(System.String));
					r_RContains_String.SetBelong(this.instance);
				}
				return r_RContains_String;
			}
		}

		/// <summary>
		/// Boolean Contains(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RContains_XmlSchema;
		public virtual RMethod RContains_XmlSchema
		{
			get
			{
				if(r_RContains_XmlSchema == null)
				{
					r_RContains_XmlSchema = new(this, "Contains", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RContains_XmlSchema.SetBelong(this.instance);
				}
				return r_RContains_XmlSchema;
			}
		}

		/// <summary>
		/// Void Compile()
		/// </summary>
		protected RMethod r_RCompile;
		public virtual RMethod RCompile
		{
			get
			{
				if(r_RCompile == null)
				{
					r_RCompile = new(this, "Compile", 0);
					r_RCompile.SetBelong(this.instance);
				}
				return r_RCompile;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RReprocess_XmlSchema;
		public virtual RMethod RReprocess_XmlSchema
		{
			get
			{
				if(r_RReprocess_XmlSchema == null)
				{
					r_RReprocess_XmlSchema = new(this, "Reprocess", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RReprocess_XmlSchema.SetBelong(this.instance);
				}
				return r_RReprocess_XmlSchema;
			}
		}

		/// <summary>
		/// Void CopyTo(System.Xml.Schema.XmlSchema[], Int32)
		/// </summary>
		protected RMethod r_RCopyTo_XmlSchemaArray_Int32;
		public virtual RMethod RCopyTo_XmlSchemaArray_Int32
		{
			get
			{
				if(r_RCopyTo_XmlSchemaArray_Int32 == null)
				{
					r_RCopyTo_XmlSchemaArray_Int32 = new(this, "CopyTo", 0, typeof(System.Xml.Schema.XmlSchema).MakeArrayType(), typeof(System.Int32));
					r_RCopyTo_XmlSchemaArray_Int32.SetBelong(this.instance);
				}
				return r_RCopyTo_XmlSchemaArray_Int32;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Schemas()
		/// </summary>
		protected RMethod r_RSchemas;
		public virtual RMethod RSchemas
		{
			get
			{
				if(r_RSchemas == null)
				{
					r_RSchemas = new(this, "Schemas", 0);
					r_RSchemas.SetBelong(this.instance);
				}
				return r_RSchemas;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Schemas(System.String)
		/// </summary>
		protected RMethod r_RSchemas_String;
		public virtual RMethod RSchemas_String
		{
			get
			{
				if(r_RSchemas_String == null)
				{
					r_RSchemas_String = new(this, "Schemas", 0, typeof(System.String));
					r_RSchemas_String.SetBelong(this.instance);
				}
				return r_RSchemas_String;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Add(System.String, System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RAdd_String_XmlSchema;
		public virtual RMethod RAdd_String_XmlSchema
		{
			get
			{
				if(r_RAdd_String_XmlSchema == null)
				{
					r_RAdd_String_XmlSchema = new(this, "Add", 0, typeof(System.String), typeof(System.Xml.Schema.XmlSchema));
					r_RAdd_String_XmlSchema.SetBelong(this.instance);
				}
				return r_RAdd_String_XmlSchema;
			}
		}

		/// <summary>
		/// Void Add(System.String, System.Xml.XmlReader, System.Collections.Hashtable)
		/// </summary>
		protected RMethod r_RAdd_String_XmlReader_Hashtable;
		public virtual RMethod RAdd_String_XmlReader_Hashtable
		{
			get
			{
				if(r_RAdd_String_XmlReader_Hashtable == null)
				{
					r_RAdd_String_XmlReader_Hashtable = new(this, "Add", 0, typeof(System.String), typeof(System.Xml.XmlReader), typeof(System.Collections.Hashtable));
					r_RAdd_String_XmlReader_Hashtable.SetBelong(this.instance);
				}
				return r_RAdd_String_XmlReader_Hashtable;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri, System.String, System.Collections.DictionaryEntry[])
		/// </summary>
		protected RMethod r_RFindSchemaByNSAndUrl_Uri_String_DictionaryEntryArray;
		public virtual RMethod RFindSchemaByNSAndUrl_Uri_String_DictionaryEntryArray
		{
			get
			{
				if(r_RFindSchemaByNSAndUrl_Uri_String_DictionaryEntryArray == null)
				{
					r_RFindSchemaByNSAndUrl_Uri_String_DictionaryEntryArray = new(this, "FindSchemaByNSAndUrl", 0, typeof(System.Uri), typeof(System.String), typeof(System.Collections.DictionaryEntry).MakeArrayType());
					r_RFindSchemaByNSAndUrl_Uri_String_DictionaryEntryArray.SetBelong(this.instance);
				}
				return r_RFindSchemaByNSAndUrl_Uri_String_DictionaryEntryArray;
			}
		}

		/// <summary>
		/// Void SetDtdProcessing(System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RSetDtdProcessing_XmlReader;
		public virtual RMethod RSetDtdProcessing_XmlReader
		{
			get
			{
				if(r_RSetDtdProcessing_XmlReader == null)
				{
					r_RSetDtdProcessing_XmlReader = new(this, "SetDtdProcessing", 0, typeof(System.Xml.XmlReader));
					r_RSetDtdProcessing_XmlReader.SetBelong(this.instance);
				}
				return r_RSetDtdProcessing_XmlReader;
			}
		}

		/// <summary>
		/// Void AddSchemaToSet(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RAddSchemaToSet_XmlSchema;
		public virtual RMethod RAddSchemaToSet_XmlSchema
		{
			get
			{
				if(r_RAddSchemaToSet_XmlSchema == null)
				{
					r_RAddSchemaToSet_XmlSchema = new(this, "AddSchemaToSet", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RAddSchemaToSet_XmlSchema.SetBelong(this.instance);
				}
				return r_RAddSchemaToSet_XmlSchema;
			}
		}

		/// <summary>
		/// Void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable, Boolean)
		/// </summary>
		protected RMethod r_RProcessNewSubstitutionGroups_XmlSchemaObjectTable_Boolean;
		public virtual RMethod RProcessNewSubstitutionGroups_XmlSchemaObjectTable_Boolean
		{
			get
			{
				if(r_RProcessNewSubstitutionGroups_XmlSchemaObjectTable_Boolean == null)
				{
					r_RProcessNewSubstitutionGroups_XmlSchemaObjectTable_Boolean = new(this, "ProcessNewSubstitutionGroups", 0, typeof(System.Xml.Schema.XmlSchemaObjectTable), typeof(System.Boolean));
					r_RProcessNewSubstitutionGroups_XmlSchemaObjectTable_Boolean.SetBelong(this.instance);
				}
				return r_RProcessNewSubstitutionGroups_XmlSchemaObjectTable_Boolean;
			}
		}

		/// <summary>
		/// Void ResolveSubstitutionGroup(System.Xml.Schema.XmlSchemaSubstitutionGroup, System.Xml.Schema.XmlSchemaObjectTable)
		/// </summary>
		protected RMethod r_RResolveSubstitutionGroup_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable;
		public virtual RMethod RResolveSubstitutionGroup_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable
		{
			get
			{
				if(r_RResolveSubstitutionGroup_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable == null)
				{
					r_RResolveSubstitutionGroup_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable = new(this, "ResolveSubstitutionGroup", 0,  ReleactionUtils.GetType("System.Xml.Schema.XmlSchemaSubstitutionGroup"), typeof(System.Xml.Schema.XmlSchemaObjectTable));
					r_RResolveSubstitutionGroup_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable.SetBelong(this.instance);
				}
				return r_RResolveSubstitutionGroup_XmlSchemaSubstitutionGroup_XmlSchemaObjectTable;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema, Boolean)
		/// </summary>
		protected RMethod r_RRemove_XmlSchema_Boolean;
		public virtual RMethod RRemove_XmlSchema_Boolean
		{
			get
			{
				if(r_RRemove_XmlSchema_Boolean == null)
				{
					r_RRemove_XmlSchema_Boolean = new(this, "Remove", 0, typeof(System.Xml.Schema.XmlSchema), typeof(System.Boolean));
					r_RRemove_XmlSchema_Boolean.SetBelong(this.instance);
				}
				return r_RRemove_XmlSchema_Boolean;
			}
		}

		/// <summary>
		/// Void ClearTables()
		/// </summary>
		protected RMethod r_RClearTables;
		public virtual RMethod RClearTables
		{
			get
			{
				if(r_RClearTables == null)
				{
					r_RClearTables = new(this, "ClearTables", 0);
					r_RClearTables.SetBelong(this.instance);
				}
				return r_RClearTables;
			}
		}

		/// <summary>
		/// Boolean PreprocessSchema(System.Xml.Schema.XmlSchema ByRef, System.String)
		/// </summary>
		protected RMethod r_RPreprocessSchema_Ref_XmlSchema_String;
		public virtual RMethod RPreprocessSchema_Ref_XmlSchema_String
		{
			get
			{
				if(r_RPreprocessSchema_Ref_XmlSchema_String == null)
				{
					r_RPreprocessSchema_Ref_XmlSchema_String = new(this, "PreprocessSchema", 0, typeof(System.Xml.Schema.XmlSchema).MakeByRefType(), typeof(System.String));
					r_RPreprocessSchema_Ref_XmlSchema_String.SetBelong(this.instance);
				}
				return r_RPreprocessSchema_Ref_XmlSchema_String;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema ParseSchema(System.String, System.Xml.XmlReader)
		/// </summary>
		protected RMethod r_RParseSchema_String_XmlReader;
		public virtual RMethod RParseSchema_String_XmlReader
		{
			get
			{
				if(r_RParseSchema_String_XmlReader == null)
				{
					r_RParseSchema_String_XmlReader = new(this, "ParseSchema", 0, typeof(System.String), typeof(System.Xml.XmlReader));
					r_RParseSchema_String_XmlReader.SetBelong(this.instance);
				}
				return r_RParseSchema_String_XmlReader;
			}
		}

		/// <summary>
		/// Void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet)
		/// </summary>
		protected RMethod r_RCopyFromCompiledSet_XmlSchemaSet;
		public virtual RMethod RCopyFromCompiledSet_XmlSchemaSet
		{
			get
			{
				if(r_RCopyFromCompiledSet_XmlSchemaSet == null)
				{
					r_RCopyFromCompiledSet_XmlSchemaSet = new(this, "CopyFromCompiledSet", 0, typeof(System.Xml.Schema.XmlSchemaSet));
					r_RCopyFromCompiledSet_XmlSchemaSet.SetBelong(this.instance);
				}
				return r_RCopyFromCompiledSet_XmlSchemaSet;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver GetResolver()
		/// </summary>
		protected RMethod r_RGetResolver;
		public virtual RMethod RGetResolver
		{
			get
			{
				if(r_RGetResolver == null)
				{
					r_RGetResolver = new(this, "GetResolver", 0);
					r_RGetResolver.SetBelong(this.instance);
				}
				return r_RGetResolver;
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
		/// System.Xml.Schema.SchemaNames GetSchemaNames(System.Xml.XmlNameTable)
		/// </summary>
		protected RMethod r_RGetSchemaNames_XmlNameTable;
		public virtual RMethod RGetSchemaNames_XmlNameTable
		{
			get
			{
				if(r_RGetSchemaNames_XmlNameTable == null)
				{
					r_RGetSchemaNames_XmlNameTable = new(this, "GetSchemaNames", 0, typeof(System.Xml.XmlNameTable));
					r_RGetSchemaNames_XmlNameTable.SetBelong(this.instance);
				}
				return r_RGetSchemaNames_XmlNameTable;
			}
		}

		/// <summary>
		/// Boolean IsSchemaLoaded(System.Uri, System.String, System.Xml.Schema.XmlSchema ByRef)
		/// </summary>
		protected RMethod r_RIsSchemaLoaded_Uri_String_Out_XmlSchema;
		public virtual RMethod RIsSchemaLoaded_Uri_String_Out_XmlSchema
		{
			get
			{
				if(r_RIsSchemaLoaded_Uri_String_Out_XmlSchema == null)
				{
					r_RIsSchemaLoaded_Uri_String_Out_XmlSchema = new(this, "IsSchemaLoaded", 0, typeof(System.Uri), typeof(System.String), typeof(System.Xml.Schema.XmlSchema).MakeByRefType());
					r_RIsSchemaLoaded_Uri_String_Out_XmlSchema.SetBelong(this.instance);
				}
				return r_RIsSchemaLoaded_Uri_String_Out_XmlSchema;
			}
		}

		/// <summary>
		/// Boolean GetSchemaByUri(System.Uri, System.Xml.Schema.XmlSchema ByRef)
		/// </summary>
		protected RMethod r_RGetSchemaByUri_Uri_Out_XmlSchema;
		public virtual RMethod RGetSchemaByUri_Uri_Out_XmlSchema
		{
			get
			{
				if(r_RGetSchemaByUri_Uri_Out_XmlSchema == null)
				{
					r_RGetSchemaByUri_Uri_Out_XmlSchema = new(this, "GetSchemaByUri", 0, typeof(System.Uri), typeof(System.Xml.Schema.XmlSchema).MakeByRefType());
					r_RGetSchemaByUri_Uri_Out_XmlSchema.SetBelong(this.instance);
				}
				return r_RGetSchemaByUri_Uri_Out_XmlSchema;
			}
		}

		/// <summary>
		/// System.String GetTargetNamespace(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RGetTargetNamespace_XmlSchema;
		public virtual RMethod RGetTargetNamespace_XmlSchema
		{
			get
			{
				if(r_RGetTargetNamespace_XmlSchema == null)
				{
					r_RGetTargetNamespace_XmlSchema = new(this, "GetTargetNamespace", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RGetTargetNamespace_XmlSchema.SetBelong(this.instance);
				}
				return r_RGetTargetNamespace_XmlSchema;
			}
		}

		/// <summary>
		/// Void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RRemoveSchemaFromCaches_XmlSchema;
		public virtual RMethod RRemoveSchemaFromCaches_XmlSchema
		{
			get
			{
				if(r_RRemoveSchemaFromCaches_XmlSchema == null)
				{
					r_RRemoveSchemaFromCaches_XmlSchema = new(this, "RemoveSchemaFromCaches", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RRemoveSchemaFromCaches_XmlSchema.SetBelong(this.instance);
				}
				return r_RRemoveSchemaFromCaches_XmlSchema;
			}
		}

		/// <summary>
		/// Void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema)
		/// </summary>
		protected RMethod r_RRemoveSchemaFromGlobalTables_XmlSchema;
		public virtual RMethod RRemoveSchemaFromGlobalTables_XmlSchema
		{
			get
			{
				if(r_RRemoveSchemaFromGlobalTables_XmlSchema == null)
				{
					r_RRemoveSchemaFromGlobalTables_XmlSchema = new(this, "RemoveSchemaFromGlobalTables", 0, typeof(System.Xml.Schema.XmlSchema));
					r_RRemoveSchemaFromGlobalTables_XmlSchema.SetBelong(this.instance);
				}
				return r_RRemoveSchemaFromGlobalTables_XmlSchema;
			}
		}

		/// <summary>
		/// Boolean AddToTable(System.Xml.Schema.XmlSchemaObjectTable, System.Xml.XmlQualifiedName, System.Xml.Schema.XmlSchemaObject)
		/// </summary>
		protected RMethod r_RAddToTable_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject;
		public virtual RMethod RAddToTable_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject
		{
			get
			{
				if(r_RAddToTable_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject == null)
				{
					r_RAddToTable_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject = new(this, "AddToTable", 0, typeof(System.Xml.Schema.XmlSchemaObjectTable), typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.Schema.XmlSchemaObject));
					r_RAddToTable_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject.SetBelong(this.instance);
				}
				return r_RAddToTable_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject;
			}
		}

		/// <summary>
		/// Void VerifyTables()
		/// </summary>
		protected RMethod r_RVerifyTables;
		public virtual RMethod RVerifyTables
		{
			get
			{
				if(r_RVerifyTables == null)
				{
					r_RVerifyTables = new(this, "VerifyTables", 0);
					r_RVerifyTables.SetBelong(this.instance);
				}
				return r_RVerifyTables;
			}
		}

		/// <summary>
		/// Void InternalValidationCallback(System.Object, System.Xml.Schema.ValidationEventArgs)
		/// </summary>
		protected RMethod r_RInternalValidationCallback_Object_ValidationEventArgs;
		public virtual RMethod RInternalValidationCallback_Object_ValidationEventArgs
		{
			get
			{
				if(r_RInternalValidationCallback_Object_ValidationEventArgs == null)
				{
					r_RInternalValidationCallback_Object_ValidationEventArgs = new(this, "InternalValidationCallback", 0, typeof(System.Object), typeof(System.Xml.Schema.ValidationEventArgs));
					r_RInternalValidationCallback_Object_ValidationEventArgs.SetBelong(this.instance);
				}
				return r_RInternalValidationCallback_Object_ValidationEventArgs;
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


        public RXmlSchemaSet() : base("System.Xml.Schema.XmlSchemaSet")
        {
        }

        public RXmlSchemaSet(System.Object instance) : base("System.Xml.Schema.XmlSchemaSet")
		{
            SetInstance(instance);
		}

        public RXmlSchemaSet(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaSet(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Xml.Schema.XmlSchema Add(System.String  @targetNamespace, System.String  @schemaUri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace, @schemaUri};
            var ___result = RAdd_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual System.Xml.Schema.XmlSchema Add(System.String  @targetNamespace, System.Xml.XmlReader  @schemaDocument)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace, @schemaDocument};
            var ___result = RAdd_String_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void Add(System.Xml.Schema.XmlSchemaSet  @schemas)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemas};
            var ___result = RAdd_XmlSchemaSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RAdd_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RRemove_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual System.Boolean RemoveRecursive(System.Xml.Schema.XmlSchema  @schemaToRemove)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemaToRemove};
            var ___result = RRemoveRecursive_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.String  @targetNamespace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace};
            var ___result = RContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RContains_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Compile()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCompile.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.Schema.XmlSchema Reprocess(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RReprocess_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void CopyTo(System.Xml.Schema.XmlSchema[]  @schemas, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemas, @index};
            var ___result = RCopyTo_XmlSchemaArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.ICollection Schemas()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSchemas.Invoke(___genericsType, ___parameters);

            return (System.Collections.ICollection)___result;
        }


        public virtual System.Collections.ICollection Schemas(System.String  @targetNamespace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace};
            var ___result = RSchemas_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.ICollection)___result;
        }


        public virtual System.Xml.Schema.XmlSchema Add(System.String  @targetNamespace, System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace, @schema};
            var ___result = RAdd_String_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void Add(System.String  @targetNamespace, System.Xml.XmlReader  @reader, System.Collections.Hashtable  @validatedNamespaces)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace, @reader, @validatedNamespaces};
            var ___result = RAdd_String_XmlReader_Hashtable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.Schema.XmlSchema FindSchemaByNSAndUrl(System.Uri  @schemaUri, System.String  @ns, System.Collections.DictionaryEntry[]  @locationsTable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemaUri, @ns, @locationsTable};
            var ___result = RFindSchemaByNSAndUrl_Uri_String_DictionaryEntryArray.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void SetDtdProcessing(System.Xml.XmlReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader};
            var ___result = RSetDtdProcessing_XmlReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddSchemaToSet(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RAddSchemaToSet_XmlSchema.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessNewSubstitutionGroups(System.Xml.Schema.XmlSchemaObjectTable  @substitutionGroupsTable, System.Boolean  @resolve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@substitutionGroupsTable, @resolve};
            var ___result = RProcessNewSubstitutionGroups_XmlSchemaObjectTable_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Xml.Schema.XmlSchema Remove(System.Xml.Schema.XmlSchema  @schema, System.Boolean  @forceCompile)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema, @forceCompile};
            var ___result = RRemove_XmlSchema_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void ClearTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean PreprocessSchema(ref System.Xml.Schema.XmlSchema  @schema, System.String  @targetNamespace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema, @targetNamespace};
            var ___result = RPreprocessSchema_Ref_XmlSchema_String.Invoke(___genericsType, ___parameters);
			schema = (System.Xml.Schema.XmlSchema)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.Xml.Schema.XmlSchema ParseSchema(System.String  @targetNamespace, System.Xml.XmlReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace, @reader};
            var ___result = RParseSchema_String_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void CopyFromCompiledSet(System.Xml.Schema.XmlSchemaSet  @otherSet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@otherSet};
            var ___result = RCopyFromCompiledSet_XmlSchemaSet.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlResolver GetResolver()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlResolver)___result;
        }


        public virtual System.Xml.Schema.ValidationEventHandler GetEventHandler()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.ValidationEventHandler)___result;
        }


        public virtual System.Object GetSchemaNames(System.Xml.XmlNameTable  @nt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nt};
            var ___result = RGetSchemaNames_XmlNameTable.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsSchemaLoaded(System.Uri  @schemaUri, System.String  @targetNamespace, out System.Xml.Schema.XmlSchema  @schema)
        {
			schema = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemaUri, @targetNamespace, @schema};
            var ___result = RIsSchemaLoaded_Uri_String_Out_XmlSchema.Invoke(___genericsType, ___parameters);
			schema = (System.Xml.Schema.XmlSchema)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetSchemaByUri(System.Uri  @schemaUri, out System.Xml.Schema.XmlSchema  @schema)
        {
			schema = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schemaUri, @schema};
            var ___result = RGetSchemaByUri_Uri_Out_XmlSchema.Invoke(___genericsType, ___parameters);
			schema = (System.Xml.Schema.XmlSchema)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.String GetTargetNamespace(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RGetTargetNamespace_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void RemoveSchemaFromCaches(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RRemoveSchemaFromCaches_XmlSchema.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveSchemaFromGlobalTables(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RRemoveSchemaFromGlobalTables_XmlSchema.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean AddToTable(System.Xml.Schema.XmlSchemaObjectTable  @table, System.Xml.XmlQualifiedName  @qname, System.Xml.Schema.XmlSchemaObject  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@table, @qname, @item};
            var ___result = RAddToTable_XmlSchemaObjectTable_XmlQualifiedName_XmlSchemaObject.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void VerifyTables()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RVerifyTables.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InternalValidationCallback(System.Object  @sender, System.Xml.Schema.ValidationEventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = RInternalValidationCallback_Object_ValidationEventArgs.Invoke(___genericsType, ___parameters);

            
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
