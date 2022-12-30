using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{public partial class RTypedObject
{
	
	/// <summary>
	/// System.Xml.Schema.TypedObject+DecimalStruct
	/// </summary>
    public partial class RDecimalStruct : RMember //
    {

		/// <summary>
		/// System.Boolean isDecimal
		/// </summary>
		protected RField r_isDecimal;
		public virtual RField RisDecimal
		{
			get
			{
				if(r_isDecimal == null)
				{
					r_isDecimal = new(this, "isDecimal");
					r_isDecimal.SetBelong(this.instance);
				}
				return r_isDecimal;
			}
		}

		/// <summary>
		/// System.Decimal[] dvalue
		/// </summary>
		protected RFieldArray<RSystem.RDecimal> r_dvalue;
		public virtual RFieldArray<RSystem.RDecimal> Rdvalue
		{
			get
			{
				if(r_dvalue == null)
				{
					r_dvalue = new(this, "dvalue");
					r_dvalue.SetBelong(this.instance);
				}
				return r_dvalue;
			}
		}

		/// <summary>
		/// Boolean IsDecimal
		/// </summary>
		protected RProperty r_IsDecimal;
		public virtual RProperty RIsDecimal
		{
			get
			{
				if(r_IsDecimal == null)
				{
					r_IsDecimal = new(this, "IsDecimal", -1);
					r_IsDecimal.SetBelong(this.instance);
				}
				return r_IsDecimal;
			}
		}

		/// <summary>
		/// System.Decimal[] Dvalue
		/// </summary>
		protected RPropertyArray<RSystem.RDecimal> r_Dvalue;
		public virtual RPropertyArray<RSystem.RDecimal> RDvalue
		{
			get
			{
				if(r_Dvalue == null)
				{
					r_Dvalue = new(this, "Dvalue", -1);
					r_Dvalue.SetBelong(this.instance);
				}
				return r_Dvalue;
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


        public RDecimalStruct() : base("System.Xml.Schema.TypedObject+DecimalStruct")
        {
        }

        public RDecimalStruct(System.Object instance) : base("System.Xml.Schema.TypedObject+DecimalStruct")
		{
            SetInstance(instance);
		}

        public RDecimalStruct(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDecimalStruct(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}