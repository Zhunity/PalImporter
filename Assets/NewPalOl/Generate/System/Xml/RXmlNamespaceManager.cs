using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlNamespaceManager
	/// </summary>
    public partial class RXmlNamespaceManager : RMember //
    {

		/// <summary>
		/// System.Xml.IXmlNamespaceResolver s_EmptyResolver
		/// </summary>
		protected static RSystem.RXml.RIXmlNamespaceResolver r_s_EmptyResolver;
		public static RSystem.RXml.RIXmlNamespaceResolver Rs_EmptyResolver
		{
			get
			{
				if(r_s_EmptyResolver == null)
				{
					r_s_EmptyResolver = new(typeof(System.Xml.XmlNamespaceManager), "s_EmptyResolver");
					r_s_EmptyResolver.SetBelong(null);
				}
				return r_s_EmptyResolver;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamespaceManager+NamespaceDeclaration[] nsdecls
		/// </summary>
		protected RFieldArray<RSystem.RXml.RXmlNamespaceManager.RNamespaceDeclaration> r_nsdecls;
		public virtual RFieldArray<RSystem.RXml.RXmlNamespaceManager.RNamespaceDeclaration> Rnsdecls
		{
			get
			{
				if(r_nsdecls == null)
				{
					r_nsdecls = new(this, "nsdecls");
					r_nsdecls.SetBelong(this.instance);
				}
				return r_nsdecls;
			}
		}

		/// <summary>
		/// System.Int32 lastDecl
		/// </summary>
		protected RField r_lastDecl;
		public virtual RField RlastDecl
		{
			get
			{
				if(r_lastDecl == null)
				{
					r_lastDecl = new(this, "lastDecl");
					r_lastDecl.SetBelong(this.instance);
				}
				return r_lastDecl;
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
		/// System.Int32 scopeId
		/// </summary>
		protected RField r_scopeId;
		public virtual RField RscopeId
		{
			get
			{
				if(r_scopeId == null)
				{
					r_scopeId = new(this, "scopeId");
					r_scopeId.SetBelong(this.instance);
				}
				return r_scopeId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] hashTable
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_hashTable;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> RhashTable
		{
			get
			{
				if(r_hashTable == null)
				{
					r_hashTable = new(this, "hashTable");
					r_hashTable.SetBelong(this.instance);
				}
				return r_hashTable;
			}
		}

		/// <summary>
		/// System.Boolean useHashtable
		/// </summary>
		protected RField r_useHashtable;
		public virtual RField RuseHashtable
		{
			get
			{
				if(r_useHashtable == null)
				{
					r_useHashtable = new(this, "useHashtable");
					r_useHashtable.SetBelong(this.instance);
				}
				return r_useHashtable;
			}
		}

		/// <summary>
		/// System.String xml
		/// </summary>
		protected RField r_xml;
		public virtual RField Rxml
		{
			get
			{
				if(r_xml == null)
				{
					r_xml = new(this, "xml");
					r_xml.SetBelong(this.instance);
				}
				return r_xml;
			}
		}

		/// <summary>
		/// System.String xmlNs
		/// </summary>
		protected RField r_xmlNs;
		public virtual RField RxmlNs
		{
			get
			{
				if(r_xmlNs == null)
				{
					r_xmlNs = new(this, "xmlNs");
					r_xmlNs.SetBelong(this.instance);
				}
				return r_xmlNs;
			}
		}

		/// <summary>
		/// System.Int32 MinDeclsCountForHashtable
		/// </summary>
		protected static RField r_MinDeclsCountForHashtable;
		public static RField RMinDeclsCountForHashtable
		{
			get
			{
				if(r_MinDeclsCountForHashtable == null)
				{
					r_MinDeclsCountForHashtable = new(typeof(System.Xml.XmlNamespaceManager), "MinDeclsCountForHashtable");
					r_MinDeclsCountForHashtable.SetBelong(null);
				}
				return r_MinDeclsCountForHashtable;
			}
		}

		/// <summary>
		/// System.Xml.IXmlNamespaceResolver EmptyResolver
		/// </summary>
		protected static RSystem.RXml.RIXmlNamespaceResolver r_EmptyResolver;
		public static RSystem.RXml.RIXmlNamespaceResolver REmptyResolver
		{
			get
			{
				if(r_EmptyResolver == null)
				{
					r_EmptyResolver = new(typeof(System.Xml.XmlNamespaceManager), "EmptyResolver", -1);
					r_EmptyResolver.SetBelong(null);
				}
				return r_EmptyResolver;
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
		/// System.String DefaultNamespace
		/// </summary>
		protected RProperty r_DefaultNamespace;
		public virtual RProperty RDefaultNamespace
		{
			get
			{
				if(r_DefaultNamespace == null)
				{
					r_DefaultNamespace = new(this, "DefaultNamespace", -1);
					r_DefaultNamespace.SetBelong(this.instance);
				}
				return r_DefaultNamespace;
			}
		}

		/// <summary>
		/// Void PushScope()
		/// </summary>
		protected RMethod r_RPushScope;
		public virtual RMethod RPushScope
		{
			get
			{
				if(r_RPushScope == null)
				{
					r_RPushScope = new(this, "PushScope", 0);
					r_RPushScope.SetBelong(this.instance);
				}
				return r_RPushScope;
			}
		}

		/// <summary>
		/// Boolean PopScope()
		/// </summary>
		protected RMethod r_RPopScope;
		public virtual RMethod RPopScope
		{
			get
			{
				if(r_RPopScope == null)
				{
					r_RPopScope = new(this, "PopScope", 0);
					r_RPopScope.SetBelong(this.instance);
				}
				return r_RPopScope;
			}
		}

		/// <summary>
		/// Void AddNamespace(System.String, System.String)
		/// </summary>
		protected RMethod r_RAddNamespace_String_String;
		public virtual RMethod RAddNamespace_String_String
		{
			get
			{
				if(r_RAddNamespace_String_String == null)
				{
					r_RAddNamespace_String_String = new(this, "AddNamespace", 0, typeof(System.String), typeof(System.String));
					r_RAddNamespace_String_String.SetBelong(this.instance);
				}
				return r_RAddNamespace_String_String;
			}
		}

		/// <summary>
		/// Void RemoveNamespace(System.String, System.String)
		/// </summary>
		protected RMethod r_RRemoveNamespace_String_String;
		public virtual RMethod RRemoveNamespace_String_String
		{
			get
			{
				if(r_RRemoveNamespace_String_String == null)
				{
					r_RRemoveNamespace_String_String = new(this, "RemoveNamespace", 0, typeof(System.String), typeof(System.String));
					r_RRemoveNamespace_String_String.SetBelong(this.instance);
				}
				return r_RRemoveNamespace_String_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
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
		/// System.Collections.Generic.IDictionary`2[System.String,System.String] GetNamespacesInScope(System.Xml.XmlNamespaceScope)
		/// </summary>
		protected RMethod r_RGetNamespacesInScope_XmlNamespaceScope;
		public virtual RMethod RGetNamespacesInScope_XmlNamespaceScope
		{
			get
			{
				if(r_RGetNamespacesInScope_XmlNamespaceScope == null)
				{
					r_RGetNamespacesInScope_XmlNamespaceScope = new(this, "GetNamespacesInScope", 0, typeof(System.Xml.XmlNamespaceScope));
					r_RGetNamespacesInScope_XmlNamespaceScope.SetBelong(this.instance);
				}
				return r_RGetNamespacesInScope_XmlNamespaceScope;
			}
		}

		/// <summary>
		/// System.String LookupNamespace(System.String)
		/// </summary>
		protected RMethod r_RLookupNamespace_String;
		public virtual RMethod RLookupNamespace_String
		{
			get
			{
				if(r_RLookupNamespace_String == null)
				{
					r_RLookupNamespace_String = new(this, "LookupNamespace", 0, typeof(System.String));
					r_RLookupNamespace_String.SetBelong(this.instance);
				}
				return r_RLookupNamespace_String;
			}
		}

		/// <summary>
		/// Int32 LookupNamespaceDecl(System.String)
		/// </summary>
		protected RMethod r_RLookupNamespaceDecl_String;
		public virtual RMethod RLookupNamespaceDecl_String
		{
			get
			{
				if(r_RLookupNamespaceDecl_String == null)
				{
					r_RLookupNamespaceDecl_String = new(this, "LookupNamespaceDecl", 0, typeof(System.String));
					r_RLookupNamespaceDecl_String.SetBelong(this.instance);
				}
				return r_RLookupNamespaceDecl_String;
			}
		}

		/// <summary>
		/// System.String LookupPrefix(System.String)
		/// </summary>
		protected RMethod r_RLookupPrefix_String;
		public virtual RMethod RLookupPrefix_String
		{
			get
			{
				if(r_RLookupPrefix_String == null)
				{
					r_RLookupPrefix_String = new(this, "LookupPrefix", 0, typeof(System.String));
					r_RLookupPrefix_String.SetBelong(this.instance);
				}
				return r_RLookupPrefix_String;
			}
		}

		/// <summary>
		/// Boolean HasNamespace(System.String)
		/// </summary>
		protected RMethod r_RHasNamespace_String;
		public virtual RMethod RHasNamespace_String
		{
			get
			{
				if(r_RHasNamespace_String == null)
				{
					r_RHasNamespace_String = new(this, "HasNamespace", 0, typeof(System.String));
					r_RHasNamespace_String.SetBelong(this.instance);
				}
				return r_RHasNamespace_String;
			}
		}

		/// <summary>
		/// Boolean GetNamespaceDeclaration(Int32, System.String ByRef, System.String ByRef)
		/// </summary>
		protected RMethod r_RGetNamespaceDeclaration_Int32_Out_String_Out_String;
		public virtual RMethod RGetNamespaceDeclaration_Int32_Out_String_Out_String
		{
			get
			{
				if(r_RGetNamespaceDeclaration_Int32_Out_String_Out_String == null)
				{
					r_RGetNamespaceDeclaration_Int32_Out_String_Out_String = new(this, "GetNamespaceDeclaration", 0, typeof(System.Int32), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType());
					r_RGetNamespaceDeclaration_Int32_Out_String_Out_String.SetBelong(this.instance);
				}
				return r_RGetNamespaceDeclaration_Int32_Out_String_Out_String;
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


        public RXmlNamespaceManager() : base("System.Xml.XmlNamespaceManager")
        {
        }

        public RXmlNamespaceManager(System.Object instance) : base("System.Xml.XmlNamespaceManager")
		{
            SetInstance(instance);
		}

        public RXmlNamespaceManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlNamespaceManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void PushScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPushScope.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean PopScope()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopScope.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void AddNamespace(System.String  @prefix, System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @uri};
            var ___result = RAddNamespace_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveNamespace(System.String  @prefix, System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @uri};
            var ___result = RRemoveNamespace_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope  @scope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scope};
            var ___result = RGetNamespacesInScope_XmlNamespaceScope.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IDictionary<System.String, System.String>)___result;
        }


        public virtual System.String LookupNamespace(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RLookupNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 LookupNamespaceDecl(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RLookupNamespaceDecl_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String LookupPrefix(System.String  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = RLookupPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasNamespace(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RHasNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetNamespaceDeclaration(System.Int32  @idx, out System.String  @prefix, out System.String  @uri)
        {
			prefix = default;
			uri = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @prefix, @uri};
            var ___result = RGetNamespaceDeclaration_Int32_Out_String_Out_String.Invoke(___genericsType, ___parameters);
			prefix = (System.String)___parameters[1];
			uri = (System.String)___parameters[2];

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
