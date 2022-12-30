using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.CompiledIdentityConstraint
	/// </summary>
    public partial class RCompiledIdentityConstraint : RMember //
    {

		/// <summary>
		/// System.Xml.XmlQualifiedName name
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_name;
		public virtual RSystem.RXml.RXmlQualifiedName Rname
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
		/// System.Xml.Schema.CompiledIdentityConstraint+ConstraintRole role
		/// </summary>
		protected RField r_role;
		public virtual RField Rrole
		{
			get
			{
				if(r_role == null)
				{
					r_role = new(this, "role");
					r_role.SetBelong(this.instance);
				}
				return r_role;
			}
		}

		/// <summary>
		/// System.Xml.Schema.Asttree selector
		/// </summary>
		protected RSystem.RXml.RSchema.RAsttree r_selector;
		public virtual RSystem.RXml.RSchema.RAsttree Rselector
		{
			get
			{
				if(r_selector == null)
				{
					r_selector = new(this, "selector");
					r_selector.SetBelong(this.instance);
				}
				return r_selector;
			}
		}

		/// <summary>
		/// System.Xml.Schema.Asttree[] fields
		/// </summary>
		protected RFieldArray<RSystem.RXml.RSchema.RAsttree> r_fields;
		public virtual RFieldArray<RSystem.RXml.RSchema.RAsttree> Rfields
		{
			get
			{
				if(r_fields == null)
				{
					r_fields = new(this, "fields");
					r_fields.SetBelong(this.instance);
				}
				return r_fields;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName refer
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_refer;
		public virtual RSystem.RXml.RXmlQualifiedName Rrefer
		{
			get
			{
				if(r_refer == null)
				{
					r_refer = new(this, "refer");
					r_refer.SetBelong(this.instance);
				}
				return r_refer;
			}
		}

		/// <summary>
		/// System.Xml.Schema.CompiledIdentityConstraint Empty
		/// </summary>
		protected static RSystem.RXml.RSchema.RCompiledIdentityConstraint r_Empty;
		public static RSystem.RXml.RSchema.RCompiledIdentityConstraint REmpty
		{
			get
			{
				if(r_Empty == null)
				{
					r_Empty = new( ReleactionUtils.GetType("System.Xml.Schema.CompiledIdentityConstraint"), "Empty");
					r_Empty.SetBelong(null);
				}
				return r_Empty;
			}
		}

		/// <summary>
		/// ConstraintRole Role
		/// </summary>
		protected RProperty r_Role;
		public virtual RProperty Role
		{
			get
			{
				if(r_Role == null)
				{
					r_Role = new(this, "Role", -1);
					r_Role.SetBelong(this.instance);
				}
				return r_Role;
			}
		}

		/// <summary>
		/// System.Xml.Schema.Asttree Selector
		/// </summary>
		protected RSystem.RXml.RSchema.RAsttree r_Selector;
		public virtual RSystem.RXml.RSchema.RAsttree RSelector
		{
			get
			{
				if(r_Selector == null)
				{
					r_Selector = new(this, "Selector", -1);
					r_Selector.SetBelong(this.instance);
				}
				return r_Selector;
			}
		}

		/// <summary>
		/// System.Xml.Schema.Asttree[] Fields
		/// </summary>
		protected RPropertyArray<RSystem.RXml.RSchema.RAsttree> r_Fields;
		public virtual RPropertyArray<RSystem.RXml.RSchema.RAsttree> RFields
		{
			get
			{
				if(r_Fields == null)
				{
					r_Fields = new(this, "Fields", -1);
					r_Fields.SetBelong(this.instance);
				}
				return r_Fields;
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


        public RCompiledIdentityConstraint() : base("System.Xml.Schema.CompiledIdentityConstraint")
        {
        }

        public RCompiledIdentityConstraint(System.Object instance) : base("System.Xml.Schema.CompiledIdentityConstraint")
		{
            SetInstance(instance);
		}

        public RCompiledIdentityConstraint(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCompiledIdentityConstraint(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
