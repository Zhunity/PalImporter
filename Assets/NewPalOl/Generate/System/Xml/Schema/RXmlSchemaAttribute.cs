using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaAttribute
	/// </summary>
    public partial class RXmlSchemaAttribute : RMember //
    {

		/// <summary>
		/// System.String defaultValue
		/// </summary>
		protected RField r_defaultValue;
		public virtual RField RdefaultValue
		{
			get
			{
				if(r_defaultValue == null)
				{
					r_defaultValue = new(this, "defaultValue");
					r_defaultValue.SetBelong(this.instance);
				}
				return r_defaultValue;
			}
		}

		/// <summary>
		/// System.String fixedValue
		/// </summary>
		protected RField r_fixedValue;
		public virtual RField RfixedValue
		{
			get
			{
				if(r_fixedValue == null)
				{
					r_fixedValue = new(this, "fixedValue");
					r_fixedValue.SetBelong(this.instance);
				}
				return r_fixedValue;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
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
		/// System.Xml.Schema.XmlSchemaForm form
		/// </summary>
		protected RField r_form;
		public virtual RField Rform
		{
			get
			{
				if(r_form == null)
				{
					r_form = new(this, "form");
					r_form.SetBelong(this.instance);
				}
				return r_form;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaUse use
		/// </summary>
		protected RField r_use;
		public virtual RField Ruse
		{
			get
			{
				if(r_use == null)
				{
					r_use = new(this, "use");
					r_use.SetBelong(this.instance);
				}
				return r_use;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName refName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_refName;
		public virtual RSystem.RXml.RXmlQualifiedName RrefName
		{
			get
			{
				if(r_refName == null)
				{
					r_refName = new(this, "refName");
					r_refName.SetBelong(this.instance);
				}
				return r_refName;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName typeName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_typeName;
		public virtual RSystem.RXml.RXmlQualifiedName RtypeName
		{
			get
			{
				if(r_typeName == null)
				{
					r_typeName = new(this, "typeName");
					r_typeName.SetBelong(this.instance);
				}
				return r_typeName;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName qualifiedName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_qualifiedName;
		public virtual RSystem.RXml.RXmlQualifiedName RqualifiedName
		{
			get
			{
				if(r_qualifiedName == null)
				{
					r_qualifiedName = new(this, "qualifiedName");
					r_qualifiedName.SetBelong(this.instance);
				}
				return r_qualifiedName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType type
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSimpleType r_type;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSimpleType Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType attributeType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSimpleType r_attributeType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSimpleType RattributeType
		{
			get
			{
				if(r_attributeType == null)
				{
					r_attributeType = new(this, "attributeType");
					r_attributeType.SetBelong(this.instance);
				}
				return r_attributeType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SchemaAttDef attDef
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaAttDef r_attDef;
		public virtual RSystem.RXml.RSchema.RSchemaAttDef RattDef
		{
			get
			{
				if(r_attDef == null)
				{
					r_attDef = new(this, "attDef");
					r_attDef.SetBelong(this.instance);
				}
				return r_attDef;
			}
		}

		/// <summary>
		/// System.String DefaultValue
		/// </summary>
		protected RProperty r_DefaultValue;
		public virtual RProperty RDefaultValue
		{
			get
			{
				if(r_DefaultValue == null)
				{
					r_DefaultValue = new(this, "DefaultValue", -1);
					r_DefaultValue.SetBelong(this.instance);
				}
				return r_DefaultValue;
			}
		}

		/// <summary>
		/// System.String FixedValue
		/// </summary>
		protected RProperty r_FixedValue;
		public virtual RProperty RFixedValue
		{
			get
			{
				if(r_FixedValue == null)
				{
					r_FixedValue = new(this, "FixedValue", -1);
					r_FixedValue.SetBelong(this.instance);
				}
				return r_FixedValue;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaForm Form
		/// </summary>
		protected RProperty r_Form;
		public virtual RProperty RForm
		{
			get
			{
				if(r_Form == null)
				{
					r_Form = new(this, "Form", -1);
					r_Form.SetBelong(this.instance);
				}
				return r_Form;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
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
		/// System.Xml.XmlQualifiedName RefName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_RefName;
		public virtual RSystem.RXml.RXmlQualifiedName RefName
		{
			get
			{
				if(r_RefName == null)
				{
					r_RefName = new(this, "RefName", -1);
					r_RefName.SetBelong(this.instance);
				}
				return r_RefName;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName SchemaTypeName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_SchemaTypeName;
		public virtual RSystem.RXml.RXmlQualifiedName RSchemaTypeName
		{
			get
			{
				if(r_SchemaTypeName == null)
				{
					r_SchemaTypeName = new(this, "SchemaTypeName", -1);
					r_SchemaTypeName.SetBelong(this.instance);
				}
				return r_SchemaTypeName;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType SchemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSimpleType r_SchemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSimpleType RSchemaType
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
		/// System.Xml.Schema.XmlSchemaUse Use
		/// </summary>
		protected RProperty r_Use;
		public virtual RProperty RUse
		{
			get
			{
				if(r_Use == null)
				{
					r_Use = new(this, "Use", -1);
					r_Use.SetBelong(this.instance);
				}
				return r_Use;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName QualifiedName
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_QualifiedName;
		public virtual RSystem.RXml.RXmlQualifiedName RQualifiedName
		{
			get
			{
				if(r_QualifiedName == null)
				{
					r_QualifiedName = new(this, "QualifiedName", -1);
					r_QualifiedName.SetBelong(this.instance);
				}
				return r_QualifiedName;
			}
		}

		/// <summary>
		/// System.Object AttributeType
		/// </summary>
		protected RSystem.RObject r_AttributeType;
		public virtual RSystem.RObject RAttributeType
		{
			get
			{
				if(r_AttributeType == null)
				{
					r_AttributeType = new(this, "AttributeType", -1);
					r_AttributeType.SetBelong(this.instance);
				}
				return r_AttributeType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaSimpleType AttributeSchemaType
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaSimpleType r_AttributeSchemaType;
		public virtual RSystem.RXml.RSchema.RXmlSchemaSimpleType RAttributeSchemaType
		{
			get
			{
				if(r_AttributeSchemaType == null)
				{
					r_AttributeSchemaType = new(this, "AttributeSchemaType", -1);
					r_AttributeSchemaType.SetBelong(this.instance);
				}
				return r_AttributeSchemaType;
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
		/// System.Xml.Schema.SchemaAttDef AttDef
		/// </summary>
		protected RSystem.RXml.RSchema.RSchemaAttDef r_AttDef;
		public virtual RSystem.RXml.RSchema.RSchemaAttDef RAttDef
		{
			get
			{
				if(r_AttDef == null)
				{
					r_AttDef = new(this, "AttDef", -1);
					r_AttDef.SetBelong(this.instance);
				}
				return r_AttDef;
			}
		}

		/// <summary>
		/// Boolean HasDefault
		/// </summary>
		protected RProperty r_HasDefault;
		public virtual RProperty RHasDefault
		{
			get
			{
				if(r_HasDefault == null)
				{
					r_HasDefault = new(this, "HasDefault", -1);
					r_HasDefault.SetBelong(this.instance);
				}
				return r_HasDefault;
			}
		}

		/// <summary>
		/// System.String NameAttribute
		/// </summary>
		protected RProperty r_NameAttribute;
		public virtual RProperty RNameAttribute
		{
			get
			{
				if(r_NameAttribute == null)
				{
					r_NameAttribute = new(this, "NameAttribute", -1);
					r_NameAttribute.SetBelong(this.instance);
				}
				return r_NameAttribute;
			}
		}

		/// <summary>
		/// System.String Id
		/// </summary>
		protected RProperty r_Id;
		public virtual RProperty RId
		{
			get
			{
				if(r_Id == null)
				{
					r_Id = new(this, "Id", -1);
					r_Id.SetBelong(this.instance);
				}
				return r_Id;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAnnotation Annotation
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaAnnotation r_Annotation;
		public virtual RSystem.RXml.RSchema.RXmlSchemaAnnotation RAnnotation
		{
			get
			{
				if(r_Annotation == null)
				{
					r_Annotation = new(this, "Annotation", -1);
					r_Annotation.SetBelong(this.instance);
				}
				return r_Annotation;
			}
		}

		/// <summary>
		/// System.Xml.XmlAttribute[] UnhandledAttributes
		/// </summary>
		protected RPropertyArray<RSystem.RXml.RXmlAttribute> r_UnhandledAttributes;
		public virtual RPropertyArray<RSystem.RXml.RXmlAttribute> RUnhandledAttributes
		{
			get
			{
				if(r_UnhandledAttributes == null)
				{
					r_UnhandledAttributes = new(this, "UnhandledAttributes", -1);
					r_UnhandledAttributes.SetBelong(this.instance);
				}
				return r_UnhandledAttributes;
			}
		}

		/// <summary>
		/// System.String IdAttribute
		/// </summary>
		protected RProperty r_IdAttribute;
		public virtual RProperty RIdAttribute
		{
			get
			{
				if(r_IdAttribute == null)
				{
					r_IdAttribute = new(this, "IdAttribute", -1);
					r_IdAttribute.SetBelong(this.instance);
				}
				return r_IdAttribute;
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
		/// System.String SourceUri
		/// </summary>
		protected RProperty r_SourceUri;
		public virtual RProperty RSourceUri
		{
			get
			{
				if(r_SourceUri == null)
				{
					r_SourceUri = new(this, "SourceUri", -1);
					r_SourceUri.SetBelong(this.instance);
				}
				return r_SourceUri;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObject Parent
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaObject r_Parent;
		public virtual RSystem.RXml.RSchema.RXmlSchemaObject RParent
		{
			get
			{
				if(r_Parent == null)
				{
					r_Parent = new(this, "Parent", -1);
					r_Parent.SetBelong(this.instance);
				}
				return r_Parent;
			}
		}

		/// <summary>
		/// System.Xml.Serialization.XmlSerializerNamespaces Namespaces
		/// </summary>
		protected RSystem.RXml.RSerialization.RXmlSerializerNamespaces r_Namespaces;
		public virtual RSystem.RXml.RSerialization.RXmlSerializerNamespaces RNamespaces
		{
			get
			{
				if(r_Namespaces == null)
				{
					r_Namespaces = new(this, "Namespaces", -1);
					r_Namespaces.SetBelong(this.instance);
				}
				return r_Namespaces;
			}
		}

		/// <summary>
		/// Boolean IsProcessing
		/// </summary>
		protected RProperty r_IsProcessing;
		public virtual RProperty RIsProcessing
		{
			get
			{
				if(r_IsProcessing == null)
				{
					r_IsProcessing = new(this, "IsProcessing", -1);
					r_IsProcessing.SetBelong(this.instance);
				}
				return r_IsProcessing;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader Validate(System.Xml.XmlReader, System.Xml.XmlResolver, System.Xml.Schema.XmlSchemaSet, System.Xml.Schema.ValidationEventHandler)
		/// </summary>
		protected RMethod r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler;
		public virtual RMethod RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler
		{
			get
			{
				if(r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler == null)
				{
					r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler = new(this, "Validate", 0, typeof(System.Xml.XmlReader), typeof(System.Xml.XmlResolver), typeof(System.Xml.Schema.XmlSchemaSet), typeof(System.Xml.Schema.ValidationEventHandler));
					r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler.SetBelong(this.instance);
				}
				return r_RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler;
			}
		}

		/// <summary>
		/// Void SetQualifiedName(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RSetQualifiedName_XmlQualifiedName;
		public virtual RMethod RSetQualifiedName_XmlQualifiedName
		{
			get
			{
				if(r_RSetQualifiedName_XmlQualifiedName == null)
				{
					r_RSetQualifiedName_XmlQualifiedName = new(this, "SetQualifiedName", 0, typeof(System.Xml.XmlQualifiedName));
					r_RSetQualifiedName_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RSetQualifiedName_XmlQualifiedName;
			}
		}

		/// <summary>
		/// Void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType)
		/// </summary>
		protected RMethod r_RSetAttributeType_XmlSchemaSimpleType;
		public virtual RMethod RSetAttributeType_XmlSchemaSimpleType
		{
			get
			{
				if(r_RSetAttributeType_XmlSchemaSimpleType == null)
				{
					r_RSetAttributeType_XmlSchemaSimpleType = new(this, "SetAttributeType", 0, typeof(System.Xml.Schema.XmlSchemaSimpleType));
					r_RSetAttributeType_XmlSchemaSimpleType.SetBelong(this.instance);
				}
				return r_RSetAttributeType_XmlSchemaSimpleType;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaObject Clone()
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
		/// Void SetUnhandledAttributes(System.Xml.XmlAttribute[])
		/// </summary>
		protected RMethod r_RSetUnhandledAttributes_XmlAttributeArray;
		public virtual RMethod RSetUnhandledAttributes_XmlAttributeArray
		{
			get
			{
				if(r_RSetUnhandledAttributes_XmlAttributeArray == null)
				{
					r_RSetUnhandledAttributes_XmlAttributeArray = new(this, "SetUnhandledAttributes", 0, typeof(System.Xml.XmlAttribute).MakeArrayType());
					r_RSetUnhandledAttributes_XmlAttributeArray.SetBelong(this.instance);
				}
				return r_RSetUnhandledAttributes_XmlAttributeArray;
			}
		}

		/// <summary>
		/// Void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation)
		/// </summary>
		protected RMethod r_RAddAnnotation_XmlSchemaAnnotation;
		public virtual RMethod RAddAnnotation_XmlSchemaAnnotation
		{
			get
			{
				if(r_RAddAnnotation_XmlSchemaAnnotation == null)
				{
					r_RAddAnnotation_XmlSchemaAnnotation = new(this, "AddAnnotation", 0, typeof(System.Xml.Schema.XmlSchemaAnnotation));
					r_RAddAnnotation_XmlSchemaAnnotation.SetBelong(this.instance);
				}
				return r_RAddAnnotation_XmlSchemaAnnotation;
			}
		}

		/// <summary>
		/// Void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection, System.Object)
		/// </summary>
		protected RMethod r_ROnAdd_XmlSchemaObjectCollection_Object;
		public virtual RMethod ROnAdd_XmlSchemaObjectCollection_Object
		{
			get
			{
				if(r_ROnAdd_XmlSchemaObjectCollection_Object == null)
				{
					r_ROnAdd_XmlSchemaObjectCollection_Object = new(this, "OnAdd", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection), typeof(System.Object));
					r_ROnAdd_XmlSchemaObjectCollection_Object.SetBelong(this.instance);
				}
				return r_ROnAdd_XmlSchemaObjectCollection_Object;
			}
		}

		/// <summary>
		/// Void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection, System.Object)
		/// </summary>
		protected RMethod r_ROnRemove_XmlSchemaObjectCollection_Object;
		public virtual RMethod ROnRemove_XmlSchemaObjectCollection_Object
		{
			get
			{
				if(r_ROnRemove_XmlSchemaObjectCollection_Object == null)
				{
					r_ROnRemove_XmlSchemaObjectCollection_Object = new(this, "OnRemove", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection), typeof(System.Object));
					r_ROnRemove_XmlSchemaObjectCollection_Object.SetBelong(this.instance);
				}
				return r_ROnRemove_XmlSchemaObjectCollection_Object;
			}
		}

		/// <summary>
		/// Void OnClear(System.Xml.Schema.XmlSchemaObjectCollection)
		/// </summary>
		protected RMethod r_ROnClear_XmlSchemaObjectCollection;
		public virtual RMethod ROnClear_XmlSchemaObjectCollection
		{
			get
			{
				if(r_ROnClear_XmlSchemaObjectCollection == null)
				{
					r_ROnClear_XmlSchemaObjectCollection = new(this, "OnClear", 0, typeof(System.Xml.Schema.XmlSchemaObjectCollection));
					r_ROnClear_XmlSchemaObjectCollection.SetBelong(this.instance);
				}
				return r_ROnClear_XmlSchemaObjectCollection;
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


        public RXmlSchemaAttribute() : base("System.Xml.Schema.XmlSchemaAttribute")
        {
        }

        public RXmlSchemaAttribute(System.Object instance) : base("System.Xml.Schema.XmlSchemaAttribute")
		{
            SetInstance(instance);
		}

        public RXmlSchemaAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Xml.XmlReader Validate(System.Xml.XmlReader  @reader, System.Xml.XmlResolver  @resolver, System.Xml.Schema.XmlSchemaSet  @schemaSet, System.Xml.Schema.ValidationEventHandler  @valEventHandler)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@reader, @resolver, @schemaSet, @valEventHandler};
            var ___result = RValidate_XmlReader_XmlResolver_XmlSchemaSet_ValidationEventHandler.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual void SetQualifiedName(System.Xml.XmlQualifiedName  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetQualifiedName_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAttributeType(System.Xml.Schema.XmlSchemaSimpleType  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetAttributeType_XmlSchemaSimpleType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.Schema.XmlSchemaObject Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObject)___result;
        }


        public virtual void SetUnhandledAttributes(System.Xml.XmlAttribute[]  @moreAttributes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moreAttributes};
            var ___result = RSetUnhandledAttributes_XmlAttributeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddAnnotation(System.Xml.Schema.XmlSchemaAnnotation  @annotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@annotation};
            var ___result = RAddAnnotation_XmlSchemaAnnotation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAdd(System.Xml.Schema.XmlSchemaObjectCollection  @container, System.Object  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container, @item};
            var ___result = ROnAdd_XmlSchemaObjectCollection_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRemove(System.Xml.Schema.XmlSchemaObjectCollection  @container, System.Object  @item)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container, @item};
            var ___result = ROnRemove_XmlSchemaObjectCollection_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnClear(System.Xml.Schema.XmlSchemaObjectCollection  @container)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@container};
            var ___result = ROnClear_XmlSchemaObjectCollection.Invoke(___genericsType, ___parameters);

            
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
