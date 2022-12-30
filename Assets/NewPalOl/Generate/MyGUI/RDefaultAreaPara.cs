using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMyGUI
{
	/// <summary>
	/// MyGUI.DefaultAreaPara
	/// </summary>
    public partial class RDefaultAreaPara : RMember //
    {

		/// <summary>
		/// UnityEngine.Color DefaultColor
		/// </summary>
		protected RUnityEngine.RColor r_DefaultColor;
		public virtual RUnityEngine.RColor RDefaultColor
		{
			get
			{
				if(r_DefaultColor == null)
				{
					r_DefaultColor = new(this, "DefaultColor");
					r_DefaultColor.SetBelong(this.instance);
				}
				return r_DefaultColor;
			}
		}

		/// <summary>
		/// System.Single fDefaultAreaWidth
		/// </summary>
		protected RField r_fDefaultAreaWidth;
		public virtual RField RfDefaultAreaWidth
		{
			get
			{
				if(r_fDefaultAreaWidth == null)
				{
					r_fDefaultAreaWidth = new(this, "fDefaultAreaWidth");
					r_fDefaultAreaWidth.SetBelong(this.instance);
				}
				return r_fDefaultAreaWidth;
			}
		}

		/// <summary>
		/// System.Int32 iFontSize
		/// </summary>
		protected RField r_iFontSize;
		public virtual RField RiFontSize
		{
			get
			{
				if(r_iFontSize == null)
				{
					r_iFontSize = new(this, "iFontSize");
					r_iFontSize.SetBelong(this.instance);
				}
				return r_iFontSize;
			}
		}

		/// <summary>
		/// System.Single fTextLineSpace
		/// </summary>
		protected RField r_fTextLineSpace;
		public virtual RField RfTextLineSpace
		{
			get
			{
				if(r_fTextLineSpace == null)
				{
					r_fTextLineSpace = new(this, "fTextLineSpace");
					r_fTextLineSpace.SetBelong(this.instance);
				}
				return r_fTextLineSpace;
			}
		}

		/// <summary>
		/// System.Int32 iShadowType
		/// </summary>
		protected RField r_iShadowType;
		public virtual RField RiShadowType
		{
			get
			{
				if(r_iShadowType == null)
				{
					r_iShadowType = new(this, "iShadowType");
					r_iShadowType.SetBelong(this.instance);
				}
				return r_iShadowType;
			}
		}

		/// <summary>
		/// UnityEngine.FontStyle DefaultFont
		/// </summary>
		protected RField r_DefaultFont;
		public virtual RField RDefaultFont
		{
			get
			{
				if(r_DefaultFont == null)
				{
					r_DefaultFont = new(this, "DefaultFont");
					r_DefaultFont.SetBelong(this.instance);
				}
				return r_DefaultFont;
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


        public RDefaultAreaPara() : base("MyGUI.DefaultAreaPara")
        {
        }

        public RDefaultAreaPara(System.Object instance) : base("MyGUI.DefaultAreaPara")
		{
            SetInstance(instance);
		}

        public RDefaultAreaPara(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDefaultAreaPara(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
