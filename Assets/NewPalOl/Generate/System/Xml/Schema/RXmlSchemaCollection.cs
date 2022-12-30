using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaCollection
	/// </summary>
    public partial class RXmlSchemaCollection : RMember //
    {

		/// <summary>
		/// System.Collections.Hashtable collection
		/// </summary>
		protected RSystem.RCollections.RHashtable r_collection;
		public virtual RSystem.RCollections.RHashtable Rcollection
		{
			get
			{
				if(r_collection == null)
				{
					r_collection = new(this, "collection");
					r_collection.SetBelong(this.instance);
				}
				return r_collection;
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
		/// System.Threading.ReaderWriterLock wLock
		/// </summary>
		protected RSystem.RThreading.RReaderWriterLock r_wLock;
		public virtual RSystem.RThreading.RReaderWriterLock RwLock
		{
			get
			{
				if(r_wLock == null)
				{
					r_wLock = new(this, "wLock");
					r_wLock.SetBelong(this.instance);
				}
				return r_wLock;
			}
		}

		/// <summary>
		/// System.Int32 timeout
		/// </summary>
		protected RField r_timeout;
		public virtual RField Rtimeout
		{
			get
			{
				if(r_timeout == null)
				{
					r_timeout = new(this, "timeout");
					r_timeout.SetBelong(this.instance);
				}
				return r_timeout;
			}
		}

		/// <summary>
		/// System.Boolean isThreadSafe
		/// </summary>
		protected RField r_isThreadSafe;
		public virtual RField RisThreadSafe
		{
			get
			{
				if(r_isThreadSafe == null)
				{
					r_isThreadSafe = new(this, "isThreadSafe");
					r_isThreadSafe.SetBelong(this.instance);
				}
				return r_isThreadSafe;
			}
		}

		/// <summary>
		/// System.Xml.Schema.ValidationEventHandler validationEventHandler
		/// </summary>
		protected RSystem.RXml.RSchema.RValidationEventHandler r_validationEventHandler;
		public virtual RSystem.RXml.RSchema.RValidationEventHandler RvalidationEventHandler
		{
			get
			{
				if(r_validationEventHandler == null)
				{
					r_validationEventHandler = new(this, "validationEventHandler");
					r_validationEventHandler.SetBelong(this.instance);
				}
				return r_validationEventHandler;
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
		/// System.Xml.Schema.XmlSchema Item [System.String]
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchema r_Item_String;
		public virtual RSystem.RXml.RSchema.RXmlSchema RItem_String
		{
			get
			{
				if(r_Item_String == null)
				{
					r_Item_String = new(this, "Item", -1, typeof(System.String));
					r_Item_String.SetBelong(this.instance);
				}
				return r_Item_String;
			}
		}

		/// <summary>
		/// Boolean System.Collections.ICollection.IsSynchronized
		/// </summary>
		protected RProperty r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized;
		public virtual RProperty RSystem__1__Collections__1__ICollection__1__get_IsSynchronized
		{
			get
			{
				if(r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized == null)
				{
					r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized = new(this, "System.Collections.ICollection.IsSynchronized", -1);
					r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__ICollection__1__get_IsSynchronized;
			}
		}

		/// <summary>
		/// System.Object System.Collections.ICollection.SyncRoot
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot;
		public virtual RSystem.RObject RSystem__1__Collections__1__ICollection__1__get_SyncRoot
		{
			get
			{
				if(r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot == null)
				{
					r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot = new(this, "System.Collections.ICollection.SyncRoot", -1);
					r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__ICollection__1__get_SyncRoot;
			}
		}

		/// <summary>
		/// Int32 System.Collections.ICollection.Count
		/// </summary>
		protected RProperty r_RSystem__1__Collections__1__ICollection__1__get_Count;
		public virtual RProperty RSystem__1__Collections__1__ICollection__1__get_Count
		{
			get
			{
				if(r_RSystem__1__Collections__1__ICollection__1__get_Count == null)
				{
					r_RSystem__1__Collections__1__ICollection__1__get_Count = new(this, "System.Collections.ICollection.Count", -1);
					r_RSystem__1__Collections__1__ICollection__1__get_Count.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__ICollection__1__get_Count;
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
		/// System.Xml.Schema.XmlSchema Add(System.String, System.Xml.XmlReader, System.Xml.XmlResolver)
		/// </summary>
		protected RMethod r_RAdd_String_XmlReader_XmlResolver;
		public virtual RMethod RAdd_String_XmlReader_XmlResolver
		{
			get
			{
				if(r_RAdd_String_XmlReader_XmlResolver == null)
				{
					r_RAdd_String_XmlReader_XmlResolver = new(this, "Add", 0, typeof(System.String), typeof(System.Xml.XmlReader), typeof(System.Xml.XmlResolver));
					r_RAdd_String_XmlReader_XmlResolver.SetBelong(this.instance);
				}
				return r_RAdd_String_XmlReader_XmlResolver;
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
		/// System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema, System.Xml.XmlResolver)
		/// </summary>
		protected RMethod r_RAdd_XmlSchema_XmlResolver;
		public virtual RMethod RAdd_XmlSchema_XmlResolver
		{
			get
			{
				if(r_RAdd_XmlSchema_XmlResolver == null)
				{
					r_RAdd_XmlSchema_XmlResolver = new(this, "Add", 0, typeof(System.Xml.Schema.XmlSchema), typeof(System.Xml.XmlResolver));
					r_RAdd_XmlSchema_XmlResolver.SetBelong(this.instance);
				}
				return r_RAdd_XmlSchema_XmlResolver;
			}
		}

		/// <summary>
		/// Void Add(System.Xml.Schema.XmlSchemaCollection)
		/// </summary>
		protected RMethod r_RAdd_XmlSchemaCollection;
		public virtual RMethod RAdd_XmlSchemaCollection
		{
			get
			{
				if(r_RAdd_XmlSchemaCollection == null)
				{
					r_RAdd_XmlSchemaCollection = new(this, "Add", 0, typeof(System.Xml.Schema.XmlSchemaCollection));
					r_RAdd_XmlSchemaCollection.SetBelong(this.instance);
				}
				return r_RAdd_XmlSchemaCollection;
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
		/// System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator;
		public virtual RMethod RSystem__1__Collections__1__IEnumerable__1__GetEnumerator
		{
			get
			{
				if(r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator == null)
				{
					r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator = new(this, "System.Collections.IEnumerable.GetEnumerator", 0);
					r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IEnumerable__1__GetEnumerator;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// Void System.Collections.ICollection.CopyTo(System.Array, Int32)
		/// </summary>
		protected RMethod r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32;
		public virtual RMethod RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32
		{
			get
			{
				if(r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32 == null)
				{
					r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32 = new(this, "System.Collections.ICollection.CopyTo", 0, typeof(System.Array), typeof(System.Int32));
					r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32;
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
		/// System.Xml.Schema.SchemaInfo GetSchemaInfo(System.String)
		/// </summary>
		protected RMethod r_RGetSchemaInfo_String;
		public virtual RMethod RGetSchemaInfo_String
		{
			get
			{
				if(r_RGetSchemaInfo_String == null)
				{
					r_RGetSchemaInfo_String = new(this, "GetSchemaInfo", 0, typeof(System.String));
					r_RGetSchemaInfo_String.SetBelong(this.instance);
				}
				return r_RGetSchemaInfo_String;
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
		/// System.Xml.Schema.XmlSchema Add(System.String, System.Xml.Schema.SchemaInfo, System.Xml.Schema.XmlSchema, Boolean)
		/// </summary>
		protected RMethod r_RAdd_String_SchemaInfo_XmlSchema_Boolean;
		public virtual RMethod RAdd_String_SchemaInfo_XmlSchema_Boolean
		{
			get
			{
				if(r_RAdd_String_SchemaInfo_XmlSchema_Boolean == null)
				{
					r_RAdd_String_SchemaInfo_XmlSchema_Boolean = new(this, "Add", 0, typeof(System.String),  ReleactionUtils.GetType("System.Xml.Schema.SchemaInfo"), typeof(System.Xml.Schema.XmlSchema), typeof(System.Boolean));
					r_RAdd_String_SchemaInfo_XmlSchema_Boolean.SetBelong(this.instance);
				}
				return r_RAdd_String_SchemaInfo_XmlSchema_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchema Add(System.String, System.Xml.Schema.SchemaInfo, System.Xml.Schema.XmlSchema, Boolean, System.Xml.XmlResolver)
		/// </summary>
		protected RMethod r_RAdd_String_SchemaInfo_XmlSchema_Boolean_XmlResolver;
		public virtual RMethod RAdd_String_SchemaInfo_XmlSchema_Boolean_XmlResolver
		{
			get
			{
				if(r_RAdd_String_SchemaInfo_XmlSchema_Boolean_XmlResolver == null)
				{
					r_RAdd_String_SchemaInfo_XmlSchema_Boolean_XmlResolver = new(this, "Add", 0, typeof(System.String),  ReleactionUtils.GetType("System.Xml.Schema.SchemaInfo"), typeof(System.Xml.Schema.XmlSchema), typeof(System.Boolean), typeof(System.Xml.XmlResolver));
					r_RAdd_String_SchemaInfo_XmlSchema_Boolean_XmlResolver.SetBelong(this.instance);
				}
				return r_RAdd_String_SchemaInfo_XmlSchema_Boolean_XmlResolver;
			}
		}

		/// <summary>
		/// Void Add(System.String, System.Xml.Schema.XmlSchemaCollectionNode)
		/// </summary>
		protected RMethod r_RAdd_String_XmlSchemaCollectionNode;
		public virtual RMethod RAdd_String_XmlSchemaCollectionNode
		{
			get
			{
				if(r_RAdd_String_XmlSchemaCollectionNode == null)
				{
					r_RAdd_String_XmlSchemaCollectionNode = new(this, "Add", 0, typeof(System.String),  ReleactionUtils.GetType("System.Xml.Schema.XmlSchemaCollectionNode"));
					r_RAdd_String_XmlSchemaCollectionNode.SetBelong(this.instance);
				}
				return r_RAdd_String_XmlSchemaCollectionNode;
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


        public RXmlSchemaCollection() : base("System.Xml.Schema.XmlSchemaCollection")
        {
        }

        public RXmlSchemaCollection(System.Object instance) : base("System.Xml.Schema.XmlSchemaCollection")
		{
            SetInstance(instance);
		}

        public RXmlSchemaCollection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaCollection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Xml.Schema.XmlSchema Add(System.String  @ns, System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns, @uri};
            var ___result = RAdd_String_String.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual System.Xml.Schema.XmlSchema Add(System.String  @ns, System.Xml.XmlReader  @reader)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns, @reader};
            var ___result = RAdd_String_XmlReader.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual System.Xml.Schema.XmlSchema Add(System.String  @ns, System.Xml.XmlReader  @reader, System.Xml.XmlResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns, @reader, @resolver};
            var ___result = RAdd_String_XmlReader_XmlResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RAdd_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual System.Xml.Schema.XmlSchema Add(System.Xml.Schema.XmlSchema  @schema, System.Xml.XmlResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema, @resolver};
            var ___result = RAdd_XmlSchema_XmlResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchema)___result;
        }


        public virtual void Add(System.Xml.Schema.XmlSchemaCollection  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RAdd_XmlSchemaCollection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Contains(System.Xml.Schema.XmlSchema  @schema)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@schema};
            var ___result = RContains_XmlSchema.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Contains(System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns};
            var ___result = RContains_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.IEnumerator System__1__Collections__1__IEnumerable__1__GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSystem__1__Collections__1__IEnumerable__1__GetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Xml.Schema.XmlSchemaCollectionEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaCollectionEnumerator)___result;
        }


        public virtual void System__1__Collections__1__ICollection__1__CopyTo(System.Array  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RSystem__1__Collections__1__ICollection__1__CopyTo_Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CopyTo(System.Xml.Schema.XmlSchema[]  @array, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index};
            var ___result = RCopyTo_XmlSchemaArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetSchemaInfo(System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns};
            var ___result = RGetSchemaInfo_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetSchemaNames(System.Xml.XmlNameTable  @nt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nt};
            var ___result = RGetSchemaNames_XmlNameTable.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }





        public virtual void SendValidationEvent(System.Xml.Schema.XmlSchemaException  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RSendValidationEvent_XmlSchemaException.Invoke(___genericsType, ___parameters);

            
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
