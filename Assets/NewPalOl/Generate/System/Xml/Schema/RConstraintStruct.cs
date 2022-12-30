using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.ConstraintStruct
	/// </summary>
    public partial class RConstraintStruct : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.CompiledIdentityConstraint constraint
		/// </summary>
		protected RSystem.RXml.RSchema.RCompiledIdentityConstraint r_constraint;
		public virtual RSystem.RXml.RSchema.RCompiledIdentityConstraint Rconstraint
		{
			get
			{
				if(r_constraint == null)
				{
					r_constraint = new(this, "constraint");
					r_constraint.SetBelong(this.instance);
				}
				return r_constraint;
			}
		}

		/// <summary>
		/// System.Xml.Schema.SelectorActiveAxis axisSelector
		/// </summary>
		protected RSystem.RXml.RSchema.RSelectorActiveAxis r_axisSelector;
		public virtual RSystem.RXml.RSchema.RSelectorActiveAxis RaxisSelector
		{
			get
			{
				if(r_axisSelector == null)
				{
					r_axisSelector = new(this, "axisSelector");
					r_axisSelector.SetBelong(this.instance);
				}
				return r_axisSelector;
			}
		}

		/// <summary>
		/// System.Collections.ArrayList axisFields
		/// </summary>
		protected RSystem.RCollections.RArrayList r_axisFields;
		public virtual RSystem.RCollections.RArrayList RaxisFields
		{
			get
			{
				if(r_axisFields == null)
				{
					r_axisFields = new(this, "axisFields");
					r_axisFields.SetBelong(this.instance);
				}
				return r_axisFields;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable qualifiedTable
		/// </summary>
		protected RSystem.RCollections.RHashtable r_qualifiedTable;
		public virtual RSystem.RCollections.RHashtable RqualifiedTable
		{
			get
			{
				if(r_qualifiedTable == null)
				{
					r_qualifiedTable = new(this, "qualifiedTable");
					r_qualifiedTable.SetBelong(this.instance);
				}
				return r_qualifiedTable;
			}
		}

		/// <summary>
		/// System.Collections.Hashtable keyrefTable
		/// </summary>
		protected RSystem.RCollections.RHashtable r_keyrefTable;
		public virtual RSystem.RCollections.RHashtable RkeyrefTable
		{
			get
			{
				if(r_keyrefTable == null)
				{
					r_keyrefTable = new(this, "keyrefTable");
					r_keyrefTable.SetBelong(this.instance);
				}
				return r_keyrefTable;
			}
		}

		/// <summary>
		/// System.Int32 tableDim
		/// </summary>
		protected RField r_tableDim;
		public virtual RField RtableDim
		{
			get
			{
				if(r_tableDim == null)
				{
					r_tableDim = new(this, "tableDim");
					r_tableDim.SetBelong(this.instance);
				}
				return r_tableDim;
			}
		}

		/// <summary>
		/// Int32 TableDim
		/// </summary>
		protected RProperty r_TableDim;
		public virtual RProperty RTableDim
		{
			get
			{
				if(r_TableDim == null)
				{
					r_TableDim = new(this, "TableDim", -1);
					r_TableDim.SetBelong(this.instance);
				}
				return r_TableDim;
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


        public RConstraintStruct() : base("System.Xml.Schema.ConstraintStruct")
        {
        }

        public RConstraintStruct(System.Object instance) : base("System.Xml.Schema.ConstraintStruct")
		{
            SetInstance(instance);
		}

        public RConstraintStruct(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConstraintStruct(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
