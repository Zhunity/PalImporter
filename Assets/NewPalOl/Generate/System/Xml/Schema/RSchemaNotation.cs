using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.SchemaNotation
	/// </summary>
    public partial class RSchemaNotation : RMember //
    {

		/// <summary>
		/// System.Int32 SYSTEM
		/// </summary>
		protected static RField r_SYSTEM;
		public static RField RSYSTEM
		{
			get
			{
				if(r_SYSTEM == null)
				{
					r_SYSTEM = new( ReleactionUtils.GetType("System.Xml.Schema.SchemaNotation"), "SYSTEM");
					r_SYSTEM.SetBelong(null);
				}
				return r_SYSTEM;
			}
		}

		/// <summary>
		/// System.Int32 PUBLIC
		/// </summary>
		protected static RField r_PUBLIC;
		public static RField RPUBLIC
		{
			get
			{
				if(r_PUBLIC == null)
				{
					r_PUBLIC = new( ReleactionUtils.GetType("System.Xml.Schema.SchemaNotation"), "PUBLIC");
					r_PUBLIC.SetBelong(null);
				}
				return r_PUBLIC;
			}
		}

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
		/// System.String systemLiteral
		/// </summary>
		protected RField r_systemLiteral;
		public virtual RField RsystemLiteral
		{
			get
			{
				if(r_systemLiteral == null)
				{
					r_systemLiteral = new(this, "systemLiteral");
					r_systemLiteral.SetBelong(this.instance);
				}
				return r_systemLiteral;
			}
		}

		/// <summary>
		/// System.String pubid
		/// </summary>
		protected RField r_pubid;
		public virtual RField Rpubid
		{
			get
			{
				if(r_pubid == null)
				{
					r_pubid = new(this, "pubid");
					r_pubid.SetBelong(this.instance);
				}
				return r_pubid;
			}
		}

		/// <summary>
		/// System.Xml.XmlQualifiedName Name
		/// </summary>
		protected RSystem.RXml.RXmlQualifiedName r_Name;
		public virtual RSystem.RXml.RXmlQualifiedName RName
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
		/// System.String SystemLiteral
		/// </summary>
		protected RProperty r_SystemLiteral;
		public virtual RProperty RSystemLiteral
		{
			get
			{
				if(r_SystemLiteral == null)
				{
					r_SystemLiteral = new(this, "SystemLiteral", -1);
					r_SystemLiteral.SetBelong(this.instance);
				}
				return r_SystemLiteral;
			}
		}

		/// <summary>
		/// System.String Pubid
		/// </summary>
		protected RProperty r_Pubid;
		public virtual RProperty RPubid
		{
			get
			{
				if(r_Pubid == null)
				{
					r_Pubid = new(this, "Pubid", -1);
					r_Pubid.SetBelong(this.instance);
				}
				return r_Pubid;
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


        public RSchemaNotation() : base("System.Xml.Schema.SchemaNotation")
        {
        }

        public RSchemaNotation(System.Object instance) : base("System.Xml.Schema.SchemaNotation")
		{
            SetInstance(instance);
		}

        public RSchemaNotation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSchemaNotation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
