using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.IXmlLineInfo
	/// </summary>
    public partial class RIXmlLineInfo : RMember //
    {

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
		/// Boolean HasLineInfo()
		/// </summary>
		protected RMethod r_RHasLineInfo;
		public virtual RMethod RHasLineInfo
		{
			get
			{
				if(r_RHasLineInfo == null)
				{
					r_RHasLineInfo = new(this, "HasLineInfo", 0);
					r_RHasLineInfo.SetBelong(this.instance);
				}
				return r_RHasLineInfo;
			}
		}


        public RIXmlLineInfo() : base("System.Xml.IXmlLineInfo")
        {
        }

        public RIXmlLineInfo(System.Object instance) : base("System.Xml.IXmlLineInfo")
		{
            SetInstance(instance);
		}

        public RIXmlLineInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RIXmlLineInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean HasLineInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasLineInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


    }
}
