using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMS.RInternal.RXml.RXPath
{
	/// <summary>
	/// MS.Internal.Xml.XPath.Axis
	/// </summary>
    public partial class RAxis : RMember //
    {

		/// <summary>
		/// MS.Internal.Xml.XPath.Axis+AxisType _axisType
		/// </summary>
		protected RField r__axisType;
		public virtual RField R_axisType
		{
			get
			{
				if(r__axisType == null)
				{
					r__axisType = new(this, "_axisType");
					r__axisType.SetBelong(this.instance);
				}
				return r__axisType;
			}
		}

		/// <summary>
		/// MS.Internal.Xml.XPath.AstNode _input
		/// </summary>
		protected RMS.RInternal.RXml.RXPath.RAstNode r__input;
		public virtual RMS.RInternal.RXml.RXPath.RAstNode R_input
		{
			get
			{
				if(r__input == null)
				{
					r__input = new(this, "_input");
					r__input.SetBelong(this.instance);
				}
				return r__input;
			}
		}

		/// <summary>
		/// System.String _prefix
		/// </summary>
		protected RField r__prefix;
		public virtual RField R_prefix
		{
			get
			{
				if(r__prefix == null)
				{
					r__prefix = new(this, "_prefix");
					r__prefix.SetBelong(this.instance);
				}
				return r__prefix;
			}
		}

		/// <summary>
		/// System.String _name
		/// </summary>
		protected RField r__name;
		public virtual RField R_name
		{
			get
			{
				if(r__name == null)
				{
					r__name = new(this, "_name");
					r__name.SetBelong(this.instance);
				}
				return r__name;
			}
		}

		/// <summary>
		/// System.Xml.XPath.XPathNodeType _nodeType
		/// </summary>
		protected RField r__nodeType;
		public virtual RField R_nodeType
		{
			get
			{
				if(r__nodeType == null)
				{
					r__nodeType = new(this, "_nodeType");
					r__nodeType.SetBelong(this.instance);
				}
				return r__nodeType;
			}
		}

		/// <summary>
		/// System.Boolean abbrAxis
		/// </summary>
		protected RField r_abbrAxis;
		public virtual RField RabbrAxis
		{
			get
			{
				if(r_abbrAxis == null)
				{
					r_abbrAxis = new(this, "abbrAxis");
					r_abbrAxis.SetBelong(this.instance);
				}
				return r_abbrAxis;
			}
		}

		/// <summary>
		/// System.String _urn
		/// </summary>
		protected RField r__urn;
		public virtual RField R_urn
		{
			get
			{
				if(r__urn == null)
				{
					r__urn = new(this, "_urn");
					r__urn.SetBelong(this.instance);
				}
				return r__urn;
			}
		}

		/// <summary>
		/// AstType Type
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
		/// System.Xml.XPath.XPathResultType ReturnType
		/// </summary>
		protected RProperty r_ReturnType;
		public virtual RProperty ReturnType
		{
			get
			{
				if(r_ReturnType == null)
				{
					r_ReturnType = new(this, "ReturnType", -1);
					r_ReturnType.SetBelong(this.instance);
				}
				return r_ReturnType;
			}
		}

		/// <summary>
		/// MS.Internal.Xml.XPath.AstNode Input
		/// </summary>
		protected RMS.RInternal.RXml.RXPath.RAstNode r_Input;
		public virtual RMS.RInternal.RXml.RXPath.RAstNode RInput
		{
			get
			{
				if(r_Input == null)
				{
					r_Input = new(this, "Input", -1);
					r_Input.SetBelong(this.instance);
				}
				return r_Input;
			}
		}

		/// <summary>
		/// System.String Prefix
		/// </summary>
		protected RProperty r_Prefix;
		public virtual RProperty RPrefix
		{
			get
			{
				if(r_Prefix == null)
				{
					r_Prefix = new(this, "Prefix", -1);
					r_Prefix.SetBelong(this.instance);
				}
				return r_Prefix;
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
		/// System.Xml.XPath.XPathNodeType NodeType
		/// </summary>
		protected RProperty r_NodeType;
		public virtual RProperty RNodeType
		{
			get
			{
				if(r_NodeType == null)
				{
					r_NodeType = new(this, "NodeType", -1);
					r_NodeType.SetBelong(this.instance);
				}
				return r_NodeType;
			}
		}

		/// <summary>
		/// AxisType TypeOfAxis
		/// </summary>
		protected RProperty r_TypeOfAxis;
		public virtual RProperty RTypeOfAxis
		{
			get
			{
				if(r_TypeOfAxis == null)
				{
					r_TypeOfAxis = new(this, "TypeOfAxis", -1);
					r_TypeOfAxis.SetBelong(this.instance);
				}
				return r_TypeOfAxis;
			}
		}

		/// <summary>
		/// Boolean AbbrAxis
		/// </summary>
		protected RProperty r_AbbrAxis;
		public virtual RProperty RAbbrAxis
		{
			get
			{
				if(r_AbbrAxis == null)
				{
					r_AbbrAxis = new(this, "AbbrAxis", -1);
					r_AbbrAxis.SetBelong(this.instance);
				}
				return r_AbbrAxis;
			}
		}

		/// <summary>
		/// System.String Urn
		/// </summary>
		protected RProperty r_Urn;
		public virtual RProperty RUrn
		{
			get
			{
				if(r_Urn == null)
				{
					r_Urn = new(this, "Urn", -1);
					r_Urn.SetBelong(this.instance);
				}
				return r_Urn;
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


        public RAxis() : base("MS.Internal.Xml.XPath.Axis")
        {
        }

        public RAxis(System.Object instance) : base("MS.Internal.Xml.XPath.Axis")
		{
            SetInstance(instance);
		}

        public RAxis(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAxis(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
