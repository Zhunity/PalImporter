using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.NamespaceList
	/// </summary>
    public partial class RNamespaceList : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.NamespaceList+ListType type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
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
		/// System.Collections.Hashtable set
		/// </summary>
		protected RSystem.RCollections.RHashtable r_set;
		public virtual RSystem.RCollections.RHashtable Rset
		{
			get
			{
				if(r_set == null)
				{
					r_set = new(this, "set");
					r_set.SetBelong(this.instance);
				}
				return r_set;
			}
		}

		/// <summary>
		/// System.String targetNamespace
		/// </summary>
		protected RField r_targetNamespace;
		public virtual RField RtargetNamespace
		{
			get
			{
				if(r_targetNamespace == null)
				{
					r_targetNamespace = new(this, "targetNamespace");
					r_targetNamespace.SetBelong(this.instance);
				}
				return r_targetNamespace;
			}
		}

		/// <summary>
		/// ListType Type
		/// </summary>
		protected RProperty r_Type;
		public virtual RProperty RType
		{
			get
			{
				if(r_Type == null)
				{
					r_Type = new(this, "Type", -1);
					r_Type.SetBelong(this.instance);
				}
				return r_Type;
			}
		}

		/// <summary>
		/// System.String Excluded
		/// </summary>
		protected RProperty r_Excluded;
		public virtual RProperty RExcluded
		{
			get
			{
				if(r_Excluded == null)
				{
					r_Excluded = new(this, "Excluded", -1);
					r_Excluded.SetBelong(this.instance);
				}
				return r_Excluded;
			}
		}

		/// <summary>
		/// System.Collections.ICollection Enumerate
		/// </summary>
		protected RSystem.RCollections.RICollection r_Enumerate;
		public virtual RSystem.RCollections.RICollection REnumerate
		{
			get
			{
				if(r_Enumerate == null)
				{
					r_Enumerate = new(this, "Enumerate", -1);
					r_Enumerate.SetBelong(this.instance);
				}
				return r_Enumerate;
			}
		}

		/// <summary>
		/// System.Xml.Schema.NamespaceList Clone()
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
		/// Boolean Allows(System.String)
		/// </summary>
		protected RMethod r_RAllows_String;
		public virtual RMethod RAllows_String
		{
			get
			{
				if(r_RAllows_String == null)
				{
					r_RAllows_String = new(this, "Allows", 0, typeof(System.String));
					r_RAllows_String.SetBelong(this.instance);
				}
				return r_RAllows_String;
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

		/// <summary>
		/// Boolean IsSubset(System.Xml.Schema.NamespaceList, System.Xml.Schema.NamespaceList)
		/// </summary>
		protected static RMethod r_RIsSubset_NamespaceList_NamespaceList;
		public static RMethod RIsSubset_NamespaceList_NamespaceList
		{
			get
			{
				if(r_RIsSubset_NamespaceList_NamespaceList == null)
				{
					r_RIsSubset_NamespaceList_NamespaceList = new( ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"), "IsSubset", 0,  ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"),  ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"));
					r_RIsSubset_NamespaceList_NamespaceList.SetBelong(null);
				}
				return r_RIsSubset_NamespaceList_NamespaceList;
			}
		}

		/// <summary>
		/// System.Xml.Schema.NamespaceList Union(System.Xml.Schema.NamespaceList, System.Xml.Schema.NamespaceList, Boolean)
		/// </summary>
		protected static RMethod r_RUnion_NamespaceList_NamespaceList_Boolean;
		public static RMethod RUnion_NamespaceList_NamespaceList_Boolean
		{
			get
			{
				if(r_RUnion_NamespaceList_NamespaceList_Boolean == null)
				{
					r_RUnion_NamespaceList_NamespaceList_Boolean = new( ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"), "Union", 0,  ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"),  ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"), typeof(System.Boolean));
					r_RUnion_NamespaceList_NamespaceList_Boolean.SetBelong(null);
				}
				return r_RUnion_NamespaceList_NamespaceList_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.Schema.NamespaceList CompareSetToOther(System.Xml.Schema.NamespaceList)
		/// </summary>
		protected RMethod r_RCompareSetToOther_NamespaceList;
		public virtual RMethod RCompareSetToOther_NamespaceList
		{
			get
			{
				if(r_RCompareSetToOther_NamespaceList == null)
				{
					r_RCompareSetToOther_NamespaceList = new(this, "CompareSetToOther", 0,  ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"));
					r_RCompareSetToOther_NamespaceList.SetBelong(this.instance);
				}
				return r_RCompareSetToOther_NamespaceList;
			}
		}

		/// <summary>
		/// System.Xml.Schema.NamespaceList Intersection(System.Xml.Schema.NamespaceList, System.Xml.Schema.NamespaceList, Boolean)
		/// </summary>
		protected static RMethod r_RIntersection_NamespaceList_NamespaceList_Boolean;
		public static RMethod RIntersection_NamespaceList_NamespaceList_Boolean
		{
			get
			{
				if(r_RIntersection_NamespaceList_NamespaceList_Boolean == null)
				{
					r_RIntersection_NamespaceList_NamespaceList_Boolean = new( ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"), "Intersection", 0,  ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"),  ReleactionUtils.GetType("System.Xml.Schema.NamespaceList"), typeof(System.Boolean));
					r_RIntersection_NamespaceList_NamespaceList_Boolean.SetBelong(null);
				}
				return r_RIntersection_NamespaceList_NamespaceList_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveNamespace(System.String)
		/// </summary>
		protected RMethod r_RRemoveNamespace_String;
		public virtual RMethod RRemoveNamespace_String
		{
			get
			{
				if(r_RRemoveNamespace_String == null)
				{
					r_RRemoveNamespace_String = new(this, "RemoveNamespace", 0, typeof(System.String));
					r_RRemoveNamespace_String.SetBelong(this.instance);
				}
				return r_RRemoveNamespace_String;
			}
		}

		/// <summary>
		/// Boolean IsEmpty()
		/// </summary>
		protected RMethod r_RIsEmpty;
		public virtual RMethod RIsEmpty
		{
			get
			{
				if(r_RIsEmpty == null)
				{
					r_RIsEmpty = new(this, "IsEmpty", 0);
					r_RIsEmpty.SetBelong(this.instance);
				}
				return r_RIsEmpty;
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


        public RNamespaceList() : base("System.Xml.Schema.NamespaceList")
        {
        }

        public RNamespaceList(System.Object instance) : base("System.Xml.Schema.NamespaceList")
		{
            SetInstance(instance);
		}

        public RNamespaceList(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNamespaceList(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean Allows(System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns};
            var ___result = RAllows_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Allows(System.Xml.XmlQualifiedName  @qname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@qname};
            var ___result = RAllows_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }






        public virtual void RemoveNamespace(System.String  @tns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tns};
            var ___result = RRemoveNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsEmpty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsEmpty.Invoke(___genericsType, ___parameters);

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


    }
}
