using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.IDtdDefaultAttributeInfo
	/// </summary>
    public partial class RIDtdDefaultAttributeInfo : RMember //
    {

		/// <summary>
		/// System.String DefaultValueExpanded
		/// </summary>
		protected RProperty r_DefaultValueExpanded;
		public virtual RProperty RDefaultValueExpanded
		{
			get
			{
				if(r_DefaultValueExpanded == null)
				{
					r_DefaultValueExpanded = new(this, "DefaultValueExpanded", -1);
					r_DefaultValueExpanded.SetBelong(this.instance);
				}
				return r_DefaultValueExpanded;
			}
		}

		/// <summary>
		/// System.Object DefaultValueTyped
		/// </summary>
		protected RSystem.RObject r_DefaultValueTyped;
		public virtual RSystem.RObject RDefaultValueTyped
		{
			get
			{
				if(r_DefaultValueTyped == null)
				{
					r_DefaultValueTyped = new(this, "DefaultValueTyped", -1);
					r_DefaultValueTyped.SetBelong(this.instance);
				}
				return r_DefaultValueTyped;
			}
		}

		/// <summary>
		/// Int32 ValueLineNumber
		/// </summary>
		protected RProperty r_ValueLineNumber;
		public virtual RProperty RValueLineNumber
		{
			get
			{
				if(r_ValueLineNumber == null)
				{
					r_ValueLineNumber = new(this, "ValueLineNumber", -1);
					r_ValueLineNumber.SetBelong(this.instance);
				}
				return r_ValueLineNumber;
			}
		}

		/// <summary>
		/// Int32 ValueLinePosition
		/// </summary>
		protected RProperty r_ValueLinePosition;
		public virtual RProperty RValueLinePosition
		{
			get
			{
				if(r_ValueLinePosition == null)
				{
					r_ValueLinePosition = new(this, "ValueLinePosition", -1);
					r_ValueLinePosition.SetBelong(this.instance);
				}
				return r_ValueLinePosition;
			}
		}


        public RIDtdDefaultAttributeInfo() : base("System.Xml.IDtdDefaultAttributeInfo")
        {
        }

        public RIDtdDefaultAttributeInfo(System.Object instance) : base("System.Xml.IDtdDefaultAttributeInfo")
		{
            SetInstance(instance);
		}

        public RIDtdDefaultAttributeInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIDtdDefaultAttributeInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

    }
}
