using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.IDtdAttributeInfo
	/// </summary>
    public partial class RIDtdAttributeInfo : RMember //
    {

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
		/// System.String LocalName
		/// </summary>
		protected RProperty r_LocalName;
		public virtual RProperty RLocalName
		{
			get
			{
				if(r_LocalName == null)
				{
					r_LocalName = new(this, "LocalName", -1);
					r_LocalName.SetBelong(this.instance);
				}
				return r_LocalName;
			}
		}

		/// <summary>
		/// Int32 LineNumber
		/// </summary>
		protected RProperty r_LineNumber;
		public virtual RProperty RLineNumber
		{
			get
			{
				if(r_LineNumber == null)
				{
					r_LineNumber = new(this, "LineNumber", -1);
					r_LineNumber.SetBelong(this.instance);
				}
				return r_LineNumber;
			}
		}

		/// <summary>
		/// Int32 LinePosition
		/// </summary>
		protected RProperty r_LinePosition;
		public virtual RProperty RLinePosition
		{
			get
			{
				if(r_LinePosition == null)
				{
					r_LinePosition = new(this, "LinePosition", -1);
					r_LinePosition.SetBelong(this.instance);
				}
				return r_LinePosition;
			}
		}

		/// <summary>
		/// Boolean IsNonCDataType
		/// </summary>
		protected RProperty r_IsNonCDataType;
		public virtual RProperty RIsNonCDataType
		{
			get
			{
				if(r_IsNonCDataType == null)
				{
					r_IsNonCDataType = new(this, "IsNonCDataType", -1);
					r_IsNonCDataType.SetBelong(this.instance);
				}
				return r_IsNonCDataType;
			}
		}

		/// <summary>
		/// Boolean IsDeclaredInExternal
		/// </summary>
		protected RProperty r_IsDeclaredInExternal;
		public virtual RProperty RIsDeclaredInExternal
		{
			get
			{
				if(r_IsDeclaredInExternal == null)
				{
					r_IsDeclaredInExternal = new(this, "IsDeclaredInExternal", -1);
					r_IsDeclaredInExternal.SetBelong(this.instance);
				}
				return r_IsDeclaredInExternal;
			}
		}

		/// <summary>
		/// Boolean IsXmlAttribute
		/// </summary>
		protected RProperty r_IsXmlAttribute;
		public virtual RProperty RIsXmlAttribute
		{
			get
			{
				if(r_IsXmlAttribute == null)
				{
					r_IsXmlAttribute = new(this, "IsXmlAttribute", -1);
					r_IsXmlAttribute.SetBelong(this.instance);
				}
				return r_IsXmlAttribute;
			}
		}


        public RIDtdAttributeInfo() : base("System.Xml.IDtdAttributeInfo")
        {
        }

        public RIDtdAttributeInfo(System.Object instance) : base("System.Xml.IDtdAttributeInfo")
		{
            SetInstance(instance);
		}

        public RIDtdAttributeInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDtdAttributeInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
