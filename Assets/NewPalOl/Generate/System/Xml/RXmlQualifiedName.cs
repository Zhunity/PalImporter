using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlQualifiedName
	/// </summary>
    public partial class RXmlQualifiedName : RMember //
    {

		/// <summary>
		/// System.Xml.XmlQualifiedName+HashCodeOfStringDelegate hashCodeDelegate
		/// </summary>
		protected static RSystem.RXml.RXmlQualifiedName.RHashCodeOfStringDelegate r_hashCodeDelegate;
		public static RSystem.RXml.RXmlQualifiedName.RHashCodeOfStringDelegate RhashCodeDelegate
		{
			get
			{
				if(r_hashCodeDelegate == null)
				{
					r_hashCodeDelegate = new(typeof(System.Xml.XmlQualifiedName), "hashCodeDelegate");
					r_hashCodeDelegate.SetBelong(null);
				}
				return r_hashCodeDelegate;
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
		/// System.Int32 hash
		/// </summary>
		protected RField r_hash;
		public virtual RField Rhash
		{
			get
			{
				if(r_hash == null)
				{
					r_hash = new(this, "hash");
					r_hash.SetBelong(this.instance);
				}
				return r_hash;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName Empty
		/// </summary>
		protected static RSystem.RXml.RXmlQualifiedName r_Empty;
		public static RSystem.RXml.RXmlQualifiedName REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new(typeof(System.Xml.XmlQualifiedName), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
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
		/// Boolean IsEmpty
		/// </summary>
		protected RProperty r_IsEmpty;
		public virtual RProperty RIsEmpty
		{
			get
			{
				if(r_IsEmpty == null)
				{
					r_IsEmpty = new(this, "IsEmpty", -1);
					r_IsEmpty.SetBelong(this.instance);
				}
				return r_IsEmpty;
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
		/// Boolean op_Equality(System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName)
		/// </summary>
		protected static RMethod r_Rop_Equality_XmlQualifiedName_XmlQualifiedName;
		public static RMethod Rop_Equality_XmlQualifiedName_XmlQualifiedName
		{
			get
			{
				if(r_Rop_Equality_XmlQualifiedName_XmlQualifiedName == null)
				{
					r_Rop_Equality_XmlQualifiedName_XmlQualifiedName = new(typeof(System.Xml.XmlQualifiedName), "op_Equality", 0, typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.XmlQualifiedName));
					r_Rop_Equality_XmlQualifiedName_XmlQualifiedName.SetBelong(null);
				}
				return r_Rop_Equality_XmlQualifiedName_XmlQualifiedName;
			}
		}

		/// <summary>
		/// Boolean op_Inequality(System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName)
		/// </summary>
		protected static RMethod r_Rop_Inequality_XmlQualifiedName_XmlQualifiedName;
		public static RMethod Rop_Inequality_XmlQualifiedName_XmlQualifiedName
		{
			get
			{
				if(r_Rop_Inequality_XmlQualifiedName_XmlQualifiedName == null)
				{
					r_Rop_Inequality_XmlQualifiedName_XmlQualifiedName = new(typeof(System.Xml.XmlQualifiedName), "op_Inequality", 0, typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.XmlQualifiedName));
					r_Rop_Inequality_XmlQualifiedName_XmlQualifiedName.SetBelong(null);
				}
				return r_Rop_Inequality_XmlQualifiedName_XmlQualifiedName;
			}
		}

		/// <summary>
		/// System.String ToString(System.String, System.String)
		/// </summary>
		protected static RMethod r_RToString_String_String;
		public static RMethod RToString_String_String
		{
			get
			{
				if(r_RToString_String_String == null)
				{
					r_RToString_String_String = new(typeof(System.Xml.XmlQualifiedName), "ToString", 0, typeof(System.String), typeof(System.String));
					r_RToString_String_String.SetBelong(null);
				}
				return r_RToString_String_String;
			}
		}

		/// <summary>
		/// HashCodeOfStringDelegate GetHashCodeDelegate()
		/// </summary>
		protected static RMethod r_RGetHashCodeDelegate;
		public static RMethod RGetHashCodeDelegate
		{
			get
			{
				if(r_RGetHashCodeDelegate == null)
				{
					r_RGetHashCodeDelegate = new(typeof(System.Xml.XmlQualifiedName), "GetHashCodeDelegate", 0);
					r_RGetHashCodeDelegate.SetBelong(null);
				}
				return r_RGetHashCodeDelegate;
			}
		}

		/// <summary>
		/// Boolean IsRandomizedHashingDisabled()
		/// </summary>
		protected static RMethod r_RIsRandomizedHashingDisabled;
		public static RMethod RIsRandomizedHashingDisabled
		{
			get
			{
				if(r_RIsRandomizedHashingDisabled == null)
				{
					r_RIsRandomizedHashingDisabled = new(typeof(System.Xml.XmlQualifiedName), "IsRandomizedHashingDisabled", 0);
					r_RIsRandomizedHashingDisabled.SetBelong(null);
				}
				return r_RIsRandomizedHashingDisabled;
			}
		}

		/// <summary>
		/// Int32 GetHashCodeOfString(System.String, Int32, Int64)
		/// </summary>
		protected static RMethod r_RGetHashCodeOfString_String_Int32_Int64;
		public static RMethod RGetHashCodeOfString_String_Int32_Int64
		{
			get
			{
				if(r_RGetHashCodeOfString_String_Int32_Int64 == null)
				{
					r_RGetHashCodeOfString_String_Int32_Int64 = new(typeof(System.Xml.XmlQualifiedName), "GetHashCodeOfString", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int64));
					r_RGetHashCodeOfString_String_Int32_Int64.SetBelong(null);
				}
				return r_RGetHashCodeOfString_String_Int32_Int64;
			}
		}

		/// <summary>
		/// Void Init(System.String, System.String)
		/// </summary>
		protected RMethod r_RInit_String_String;
		public virtual RMethod RInit_String_String
		{
			get
			{
				if(r_RInit_String_String == null)
				{
					r_RInit_String_String = new(this, "Init", 0, typeof(System.String), typeof(System.String));
					r_RInit_String_String.SetBelong(this.instance);
				}
				return r_RInit_String_String;
			}
		}

		/// <summary>
		/// Void SetNamespace(System.String)
		/// </summary>
		protected RMethod r_RSetNamespace_String;
		public virtual RMethod RSetNamespace_String
		{
			get
			{
				if(r_RSetNamespace_String == null)
				{
					r_RSetNamespace_String = new(this, "SetNamespace", 0, typeof(System.String));
					r_RSetNamespace_String.SetBelong(this.instance);
				}
				return r_RSetNamespace_String;
			}
		}

		/// <summary>
		/// Void Verify()
		/// </summary>
		protected RMethod r_RVerify;
		public virtual RMethod RVerify
		{
			get
			{
				if(r_RVerify == null)
				{
					r_RVerify = new(this, "Verify", 0);
					r_RVerify.SetBelong(this.instance);
				}
				return r_RVerify;
			}
		}

		/// <summary>
		/// Void Atomize(System.Xml.XmlNameTable)
		/// </summary>
		protected RMethod r_RAtomize_XmlNameTable;
		public virtual RMethod RAtomize_XmlNameTable
		{
			get
			{
				if(r_RAtomize_XmlNameTable == null)
				{
					r_RAtomize_XmlNameTable = new(this, "Atomize", 0, typeof(System.Xml.XmlNameTable));
					r_RAtomize_XmlNameTable.SetBelong(this.instance);
				}
				return r_RAtomize_XmlNameTable;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName Parse(System.String, System.Xml.IXmlNamespaceResolver, System.String ByRef)
		/// </summary>
		protected static RMethod r_RParse_String_IXmlNamespaceResolver_Out_String;
		public static RMethod RParse_String_IXmlNamespaceResolver_Out_String
		{
			get
			{
				if(r_RParse_String_IXmlNamespaceResolver_Out_String == null)
				{
					r_RParse_String_IXmlNamespaceResolver_Out_String = new(typeof(System.Xml.XmlQualifiedName), "Parse", 0, typeof(System.String), typeof(System.Xml.IXmlNamespaceResolver), typeof(System.String).MakeByRefType());
					r_RParse_String_IXmlNamespaceResolver_Out_String.SetBelong(null);
				}
				return r_RParse_String_IXmlNamespaceResolver_Out_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName Clone()
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
		/// Int32 Compare(System.Xml.XmlQualifiedName, System.Xml.XmlQualifiedName)
		/// </summary>
		protected static RMethod r_RCompare_XmlQualifiedName_XmlQualifiedName;
		public static RMethod RCompare_XmlQualifiedName_XmlQualifiedName
		{
			get
			{
				if(r_RCompare_XmlQualifiedName_XmlQualifiedName == null)
				{
					r_RCompare_XmlQualifiedName_XmlQualifiedName = new(typeof(System.Xml.XmlQualifiedName), "Compare", 0, typeof(System.Xml.XmlQualifiedName), typeof(System.Xml.XmlQualifiedName));
					r_RCompare_XmlQualifiedName_XmlQualifiedName.SetBelong(null);
				}
				return r_RCompare_XmlQualifiedName_XmlQualifiedName;
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


        public RXmlQualifiedName() : base("System.Xml.XmlQualifiedName")
        {
        }

        public RXmlQualifiedName(System.Object instance) : base("System.Xml.XmlQualifiedName")
		{
            SetInstance(instance);
		}

        public RXmlQualifiedName(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlQualifiedName(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Equality(System.Xml.XmlQualifiedName  @a, System.Xml.XmlQualifiedName  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Equality_XmlQualifiedName_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean op_Inequality(System.Xml.XmlQualifiedName  @a, System.Xml.XmlQualifiedName  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = Rop_Inequality_XmlQualifiedName_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.String ToString(System.String  @name, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ns};
            var ___result = RToString_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Object GetHashCodeDelegate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCodeDelegate.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Boolean IsRandomizedHashingDisabled()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsRandomizedHashingDisabled.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 GetHashCodeOfString(System.String  @s, System.Int32  @length, System.Int64  @additionalEntropy)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @length, @additionalEntropy};
            var ___result = RGetHashCodeOfString_String_Int32_Int64.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Init(System.String  @name, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @ns};
            var ___result = RInit_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNamespace(System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ns};
            var ___result = RSetNamespace_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Verify()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RVerify.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Atomize(System.Xml.XmlNameTable  @nameTable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nameTable};
            var ___result = RAtomize_XmlNameTable.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Xml.XmlQualifiedName Parse(System.String  @s, System.Xml.IXmlNamespaceResolver  @nsmgr, out System.String  @prefix)
        {
			prefix = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @nsmgr, @prefix};
            var ___result = RParse_String_IXmlNamespaceResolver_Out_String.Invoke(___genericsType, ___parameters);
			prefix = (System.String)___parameters[2];

            return (System.Xml.XmlQualifiedName)___result;
        }


        public virtual System.Xml.XmlQualifiedName Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlQualifiedName)___result;
        }


        public static System.Int32 Compare(System.Xml.XmlQualifiedName  @a, System.Xml.XmlQualifiedName  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RCompare_XmlQualifiedName_XmlQualifiedName.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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
