using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.XmlSchemaAnyAttribute
	/// </summary>
    public partial class RXmlSchemaAnyAttribute : RMember //
    {

		/// <summary>
		/// System.String ns
		/// </summary>
		protected RField r_ns;
		public virtual RField Rns
		{
			get
			{
				if(r_ns == null)
				{
					r_ns = new(this, "ns");
					r_ns.SetBelong(this.instance);
				}
				return r_ns;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentProcessing processContents
		/// </summary>
		protected RField r_processContents;
		public virtual RField RprocessContents
		{
			get
			{
				if(r_processContents == null)
				{
					r_processContents = new(this, "processContents");
					r_processContents.SetBelong(this.instance);
				}
				return r_processContents;
			}
		}

		/// <summary>
		/// System.Xml.Schema.NamespaceList namespaceList
		/// </summary>
		protected RSystem.RXml.RSchema.RNamespaceList r_namespaceList;
		public virtual RSystem.RXml.RSchema.RNamespaceList RnamespaceList
		{
			get
			{
				if(r_namespaceList == null)
				{
					r_namespaceList = new(this, "namespaceList");
					r_namespaceList.SetBelong(this.instance);
				}
				return r_namespaceList;
			}
		}

		/// <summary>
		/// System.String Namespace
		/// </summary>
		protected RProperty r_Namespace;
		public virtual RProperty RNamespace
		{
			get
			{
				if(r_Namespace == null)
				{
					r_Namespace = new(this, "Namespace", -1);
					r_Namespace.SetBelong(this.instance);
				}
				return r_Namespace;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentProcessing ProcessContents
		/// </summary>
		protected RProperty r_ProcessContents;
		public virtual RProperty RProcessContents
		{
			get
			{
				if(r_ProcessContents == null)
				{
					r_ProcessContents = new(this, "ProcessContents", -1);
					r_ProcessContents.SetBelong(this.instance);
				}
				return r_ProcessContents;
			}
		}

		/// <summary>
		/// System.Xml.Schema.NamespaceList NamespaceList
		/// </summary>
		protected RSystem.RXml.RSchema.RNamespaceList r_NamespaceList;
		public virtual RSystem.RXml.RSchema.RNamespaceList RNamespaceList
		{
			get
			{
				if(r_NamespaceList == null)
				{
					r_NamespaceList = new(this, "NamespaceList", -1);
					r_NamespaceList.SetBelong(this.instance);
				}
				return r_NamespaceList;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaContentProcessing ProcessContentsCorrect
		/// </summary>
		protected RProperty r_ProcessContentsCorrect;
		public virtual RProperty RProcessContentsCorrect
		{
			get
			{
				if(r_ProcessContentsCorrect == null)
				{
					r_ProcessContentsCorrect = new(this, "ProcessContentsCorrect", -1);
					r_ProcessContentsCorrect.SetBelong(this.instance);
				}
				return r_ProcessContentsCorrect;
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
		/// Void BuildNamespaceList(System.String)
		/// </summary>
		protected RMethod r_RBuildNamespaceList_String;
		public virtual RMethod RBuildNamespaceList_String
		{
			get
			{
				if(r_RBuildNamespaceList_String == null)
				{
					r_RBuildNamespaceList_String = new(this, "BuildNamespaceList", 0, typeof(System.String));
					r_RBuildNamespaceList_String.SetBelong(this.instance);
				}
				return r_RBuildNamespaceList_String;
			}
		}

		/// <summary>
		/// Void BuildNamespaceListV1Compat(System.String)
		/// </summary>
		protected RMethod r_RBuildNamespaceListV1Compat_String;
		public virtual RMethod RBuildNamespaceListV1Compat_String
		{
			get
			{
				if(r_RBuildNamespaceListV1Compat_String == null)
				{
					r_RBuildNamespaceListV1Compat_String = new(this, "BuildNamespaceListV1Compat", 0, typeof(System.String));
					r_RBuildNamespaceListV1Compat_String.SetBelong(this.instance);
				}
				return r_RBuildNamespaceListV1Compat_String;
			}
		}

		/// <summary>
		/// Boolean Allows(System.Xml.XmlQualifiedName)
		/// </summary>
		protected RMethod r_RAllows_XmlQualifiedName;
		public virtual RMethod RAllows_XmlQualifiedName
		{
			get
			{
				if(r_RAllows_XmlQualifiedName == null)
				{
					r_RAllows_XmlQualifiedName = new(this, "Allows", 0, typeof(System.Xml.XmlQualifiedName));
					r_RAllows_XmlQualifiedName.SetBelong(this.instance);
				}
				return r_RAllows_XmlQualifiedName;
			}
		}

		/// <summary>
		/// Boolean IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute, System.Xml.Schema.XmlSchemaAnyAttribute)
		/// </summary>
		protected static RMethod r_RIsSubset_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute;
		public static RMethod RIsSubset_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute
		{
			get
			{
				if(r_RIsSubset_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute == null)
				{
					r_RIsSubset_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute = new(typeof(System.Xml.Schema.XmlSchemaAnyAttribute), "IsSubset", 0, typeof(System.Xml.Schema.XmlSchemaAnyAttribute), typeof(System.Xml.Schema.XmlSchemaAnyAttribute));
					r_RIsSubset_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute.SetBelong(null);
				}
				return r_RIsSubset_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute, System.Xml.Schema.XmlSchemaAnyAttribute, Boolean)
		/// </summary>
		protected static RMethod r_RIntersection_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean;
		public static RMethod RIntersection_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean
		{
			get
			{
				if(r_RIntersection_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean == null)
				{
					r_RIntersection_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean = new(typeof(System.Xml.Schema.XmlSchemaAnyAttribute), "Intersection", 0, typeof(System.Xml.Schema.XmlSchemaAnyAttribute), typeof(System.Xml.Schema.XmlSchemaAnyAttribute), typeof(System.Boolean));
					r_RIntersection_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean.SetBelong(null);
				}
				return r_RIntersection_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute, System.Xml.Schema.XmlSchemaAnyAttribute, Boolean)
		/// </summary>
		protected static RMethod r_RUnion_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean;
		public static RMethod RUnion_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean
		{
			get
			{
				if(r_RUnion_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean == null)
				{
					r_RUnion_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean = new(typeof(System.Xml.Schema.XmlSchemaAnyAttribute), "Union", 0, typeof(System.Xml.Schema.XmlSchemaAnyAttribute), typeof(System.Xml.Schema.XmlSchemaAnyAttribute), typeof(System.Boolean));
					r_RUnion_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean.SetBelong(null);
				}
				return r_RUnion_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean;
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


        public RXmlSchemaAnyAttribute() : base("System.Xml.Schema.XmlSchemaAnyAttribute")
        {
        }

        public RXmlSchemaAnyAttribute(System.Object instance) : base("System.Xml.Schema.XmlSchemaAnyAttribute")
		{
            SetInstance(instance);
		}

        public RXmlSchemaAnyAttribute(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSchemaAnyAttribute(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void BuildNamespaceList(System.String  @targetNamespace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace};
            var ___result = RBuildNamespaceList_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildNamespaceListV1Compat(System.String  @targetNamespace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@targetNamespace};
            var ___result = RBuildNamespaceListV1Compat_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Allows(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RAllows_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSubset(System.Xml.Schema.XmlSchemaAnyAttribute  @sub, System.Xml.Schema.XmlSchemaAnyAttribute  @super)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sub, @super};
            var ___result = RIsSubset_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Xml.Schema.XmlSchemaAnyAttribute Intersection(System.Xml.Schema.XmlSchemaAnyAttribute  @o1, System.Xml.Schema.XmlSchemaAnyAttribute  @o2, System.Boolean  @v1Compat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o1, @o2, @v1Compat};
            var ___result = RIntersection_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaAnyAttribute)___result;
        }


        public static System.Xml.Schema.XmlSchemaAnyAttribute Union(System.Xml.Schema.XmlSchemaAnyAttribute  @o1, System.Xml.Schema.XmlSchemaAnyAttribute  @o2, System.Boolean  @v1Compat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o1, @o2, @v1Compat};
            var ___result = RUnion_XmlSchemaAnyAttribute_XmlSchemaAnyAttribute_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaAnyAttribute)___result;
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


        public virtual System.Xml.Schema.XmlSchemaObject Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.Schema.XmlSchemaObject)___result;
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
