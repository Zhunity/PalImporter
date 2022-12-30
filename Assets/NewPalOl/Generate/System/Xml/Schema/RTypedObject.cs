using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml.RSchema
{
	/// <summary>
	/// System.Xml.Schema.TypedObject
	/// </summary>
    public partial class RTypedObject : RMember //
    {

		/// <summary>
		/// System.Xml.Schema.TypedObject+DecimalStruct dstruct
		/// </summary>
		protected RSystem.RXml.RSchema.RTypedObject.RDecimalStruct r_dstruct;
		public virtual RSystem.RXml.RSchema.RTypedObject.RDecimalStruct Rdstruct
		{
			get
			{
				if(r_dstruct == null)
				{
					r_dstruct = new(this, "dstruct");
					r_dstruct.SetBelong(this.instance);
				}
				return r_dstruct;
			}
		}

		/// <summary>
		/// System.Object ovalue
		/// </summary>
		protected RSystem.RObject r_ovalue;
		public virtual RSystem.RObject Rovalue
		{
			get
			{
				if(r_ovalue == null)
				{
					r_ovalue = new(this, "ovalue");
					r_ovalue.SetBelong(this.instance);
				}
				return r_ovalue;
			}
		}

		/// <summary>
		/// System.String svalue
		/// </summary>
		protected RField r_svalue;
		public virtual RField Rsvalue
		{
			get
			{
				if(r_svalue == null)
				{
					r_svalue = new(this, "svalue");
					r_svalue.SetBelong(this.instance);
				}
				return r_svalue;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype xsdtype
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaDatatype r_xsdtype;
		public virtual RSystem.RXml.RSchema.RXmlSchemaDatatype Rxsdtype
		{
			get
			{
				if(r_xsdtype == null)
				{
					r_xsdtype = new(this, "xsdtype");
					r_xsdtype.SetBelong(this.instance);
				}
				return r_xsdtype;
			}
		}

		/// <summary>
		/// System.Int32 dim
		/// </summary>
		protected RField r_dim;
		public virtual RField Rdim
		{
			get
			{
				if(r_dim == null)
				{
					r_dim = new(this, "dim");
					r_dim.SetBelong(this.instance);
				}
				return r_dim;
			}
		}

		/// <summary>
		/// System.Boolean isList
		/// </summary>
		protected RField r_isList;
		public virtual RField RisList
		{
			get
			{
				if(r_isList == null)
				{
					r_isList = new(this, "isList");
					r_isList.SetBelong(this.instance);
				}
				return r_isList;
			}
		}

		/// <summary>
		/// Int32 Dim
		/// </summary>
		protected RProperty r_Dim;
		public virtual RProperty RDim
		{
			get
			{
				if(r_Dim == null)
				{
					r_Dim = new(this, "Dim", -1);
					r_Dim.SetBelong(this.instance);
				}
				return r_Dim;
			}
		}

		/// <summary>
		/// Boolean IsList
		/// </summary>
		protected RProperty r_IsList;
		public virtual RProperty RIsList
		{
			get
			{
				if(r_IsList == null)
				{
					r_IsList = new(this, "IsList", -1);
					r_IsList.SetBelong(this.instance);
				}
				return r_IsList;
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
		/// System.Object Value
		/// </summary>
		protected RSystem.RObject r_Value;
		public virtual RSystem.RObject RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// System.Xml.Schema.XmlSchemaDatatype Type
		/// </summary>
		protected RSystem.RXml.RSchema.RXmlSchemaDatatype r_Type;
		public virtual RSystem.RXml.RSchema.RXmlSchemaDatatype RType
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
		/// Void SetDecimal()
		/// </summary>
		protected RMethod r_RSetDecimal;
		public virtual RMethod RSetDecimal
		{
			get
			{
				if(r_RSetDecimal == null)
				{
					r_RSetDecimal = new(this, "SetDecimal", 0);
					r_RSetDecimal.SetBelong(this.instance);
				}
				return r_RSetDecimal;
			}
		}

		/// <summary>
		/// Boolean ListDValueEquals(System.Xml.Schema.TypedObject)
		/// </summary>
		protected RMethod r_RListDValueEquals_TypedObject;
		public virtual RMethod RListDValueEquals_TypedObject
		{
			get
			{
				if(r_RListDValueEquals_TypedObject == null)
				{
					r_RListDValueEquals_TypedObject = new(this, "ListDValueEquals", 0,  ReleactionUtils.GetType("System.Xml.Schema.TypedObject"));
					r_RListDValueEquals_TypedObject.SetBelong(this.instance);
				}
				return r_RListDValueEquals_TypedObject;
			}
		}

		/// <summary>
		/// Boolean Equals(System.Xml.Schema.TypedObject)
		/// </summary>
		protected RMethod r_REquals_TypedObject;
		public virtual RMethod REquals_TypedObject
		{
			get
			{
				if(r_REquals_TypedObject == null)
				{
					r_REquals_TypedObject = new(this, "Equals", 0,  ReleactionUtils.GetType("System.Xml.Schema.TypedObject"));
					r_REquals_TypedObject.SetBelong(this.instance);
				}
				return r_REquals_TypedObject;
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


        public RTypedObject() : base("System.Xml.Schema.TypedObject")
        {
        }

        public RTypedObject(System.Object instance) : base("System.Xml.Schema.TypedObject")
		{
            SetInstance(instance);
		}

        public RTypedObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTypedObject(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void SetDecimal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDecimal.Invoke(___genericsType, ___parameters);

            
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
