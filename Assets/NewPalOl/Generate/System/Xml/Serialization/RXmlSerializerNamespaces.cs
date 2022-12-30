using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSerialization
{
	/// <summary>
	/// System.Xml.Serialization.XmlSerializerNamespaces
	/// </summary>
    public partial class RXmlSerializerNamespaces : RMember //
    {

		/// <summary>
		/// System.Collections.Hashtable namespaces
		/// </summary>
		protected RSystem.RCollections.RHashtable r_namespaces;
		public virtual RSystem.RCollections.RHashtable Rnamespaces
		{
			get
			{
				if(r_namespaces == null)
				{
					r_namespaces = new(this, "namespaces");
					r_namespaces.SetBelong(this.instance);
				}
				return r_namespaces;
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
		/// System.Collections.ArrayList NamespaceList
		/// </summary>
		protected RSystem.RCollections.RArrayList r_NamespaceList;
		public virtual RSystem.RCollections.RArrayList RNamespaceList
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
		/// System.Collections.Hashtable Namespaces
		/// </summary>
		protected RSystem.RCollections.RHashtable r_Namespaces;
		public virtual RSystem.RCollections.RHashtable RNamespaces
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
		/// Void Add(System.String, System.String)
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
		/// Void AddInternal(System.String, System.String)
		/// </summary>
		protected RMethod r_RAddInternal_String_String;
		public virtual RMethod RAddInternal_String_String
		{
			get
			{
				if(r_RAddInternal_String_String == null)
				{
					r_RAddInternal_String_String = new(this, "AddInternal", 0, typeof(System.String), typeof(System.String));
					r_RAddInternal_String_String.SetBelong(this.instance);
				}
				return r_RAddInternal_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName[] ToArray()
		/// </summary>
		protected RMethod r_RToArray;
		public virtual RMethod RToArray
		{
			get
			{
				if(r_RToArray == null)
				{
					r_RToArray = new(this, "ToArray", 0);
					r_RToArray.SetBelong(this.instance);
				}
				return r_RToArray;
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


        public RXmlSerializerNamespaces() : base("System.Xml.Serialization.XmlSerializerNamespaces")
        {
        }

        public RXmlSerializerNamespaces(System.Object instance) : base("System.Xml.Serialization.XmlSerializerNamespaces")
		{
            SetInstance(instance);
		}

        public RXmlSerializerNamespaces(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlSerializerNamespaces(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Add(System.String  @prefix, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @ns};
            var ___result = RAdd_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddInternal(System.String  @prefix, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix, @ns};
            var ___result = RAddInternal_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlQualifiedName[] ToArray()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToArray.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlQualifiedName[])___result;
        }


        public virtual System.String LookupPrefix(System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns};
            var ___result = RLookupPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
