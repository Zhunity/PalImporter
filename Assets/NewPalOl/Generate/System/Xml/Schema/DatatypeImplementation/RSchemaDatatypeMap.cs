using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{public partial class RDatatypeImplementation
{
	
	/// <summary>
	/// System.Xml.Schema.DatatypeImplementation+SchemaDatatypeMap
	/// </summary>
    public partial class RSchemaDatatypeMap : RMember //
    {

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
		/// System.Xml.Schema.DatatypeImplementation type
		/// </summary>
		protected RSystem.RXml.RSchema.RDatatypeImplementation r_type;
		public virtual RSystem.RXml.RSchema.RDatatypeImplementation Rtype
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
		/// System.Int32 parentIndex
		/// </summary>
		protected RField r_parentIndex;
		public virtual RField RparentIndex
		{
			get
			{
				if(r_parentIndex == null)
				{
					r_parentIndex = new(this, "parentIndex");
					r_parentIndex.SetBelong(this.instance);
				}
				return r_parentIndex;
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
		/// Int32 ParentIndex
		/// </summary>
		protected RProperty r_ParentIndex;
		public virtual RProperty RParentIndex
		{
			get
			{
				if(r_ParentIndex == null)
				{
					r_ParentIndex = new(this, "ParentIndex", -1);
					r_ParentIndex.SetBelong(this.instance);
				}
				return r_ParentIndex;
			}
		}

		/// <summary>
		/// System.Xml.Schema.DatatypeImplementation op_Explicit(SchemaDatatypeMap)
		/// </summary>
		protected static RMethod r_Rop_Explicit_SchemaDatatypeMap;
		public static RMethod Rop_Explicit_SchemaDatatypeMap
		{
			get
			{
				if(r_Rop_Explicit_SchemaDatatypeMap == null)
				{
					r_Rop_Explicit_SchemaDatatypeMap = new( ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation+SchemaDatatypeMap"), "op_Explicit", 0,  ReleactionUtils.GetType("System.Xml.Schema.DatatypeImplementation+SchemaDatatypeMap"));
					r_Rop_Explicit_SchemaDatatypeMap.SetBelong(null);
				}
				return r_Rop_Explicit_SchemaDatatypeMap;
			}
		}

		/// <summary>
		/// Int32 CompareTo(System.Object)
		/// </summary>
		protected RMethod r_RCompareTo_Object;
		public virtual RMethod RCompareTo_Object
		{
			get
			{
				if(r_RCompareTo_Object == null)
				{
					r_RCompareTo_Object = new(this, "CompareTo", 0, typeof(System.Object));
					r_RCompareTo_Object.SetBelong(this.instance);
				}
				return r_RCompareTo_Object;
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


        public RSchemaDatatypeMap() : base("System.Xml.Schema.DatatypeImplementation+SchemaDatatypeMap")
        {
        }

        public RSchemaDatatypeMap(System.Object instance) : base("System.Xml.Schema.DatatypeImplementation+SchemaDatatypeMap")
		{
            SetInstance(instance);
		}

        public RSchemaDatatypeMap(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSchemaDatatypeMap(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.Int32 CompareTo(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RCompareTo_Object.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
}