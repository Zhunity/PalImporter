using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RMyGUI
{
	/// <summary>
	/// MyGUI.WordSeg
	/// </summary>
    public partial class RWordSeg : RMember //
    {

		/// <summary>
		/// System.String _content
		/// </summary>
		protected RField r__content;
		public virtual RField R_content
		{
			get
			{
				if(r__content == null)
				{
					r__content = new(this, "_content");
					r__content.SetBelong(this.instance);
				}
				return r__content;
			}
		}

		/// <summary>
		/// System.Int32 _fontSize
		/// </summary>
		protected RField r__fontSize;
		public virtual RField R_fontSize
		{
			get
			{
				if(r__fontSize == null)
				{
					r__fontSize = new(this, "_fontSize");
					r__fontSize.SetBelong(this.instance);
				}
				return r__fontSize;
			}
		}

		/// <summary>
		/// System.String _ColorId
		/// </summary>
		protected RField r__ColorId;
		public virtual RField R_ColorId
		{
			get
			{
				if(r__ColorId == null)
				{
					r__ColorId = new(this, "_ColorId");
					r__ColorId.SetBelong(this.instance);
				}
				return r__ColorId;
			}
		}

		/// <summary>
		/// System.String _imageName
		/// </summary>
		protected RField r__imageName;
		public virtual RField R_imageName
		{
			get
			{
				if(r__imageName == null)
				{
					r__imageName = new(this, "_imageName");
					r__imageName.SetBelong(this.instance);
				}
				return r__imageName;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 _imageSize
		/// </summary>
		protected RUnityEngine.RVector2 r__imageSize;
		public virtual RUnityEngine.RVector2 R_imageSize
		{
			get
			{
				if(r__imageSize == null)
				{
					r__imageSize = new(this, "_imageSize");
					r__imageSize.SetBelong(this.instance);
				}
				return r__imageSize;
			}
		}

		/// <summary>
		/// System.Boolean _placeHolder
		/// </summary>
		protected RField r__placeHolder;
		public virtual RField R_placeHolder
		{
			get
			{
				if(r__placeHolder == null)
				{
					r__placeHolder = new(this, "_placeHolder");
					r__placeHolder.SetBelong(this.instance);
				}
				return r__placeHolder;
			}
		}

		/// <summary>
		/// UnityEngine.TextAnchor _anchor
		/// </summary>
		protected RField r__anchor;
		public virtual RField R_anchor
		{
			get
			{
				if(r__anchor == null)
				{
					r__anchor = new(this, "_anchor");
					r__anchor.SetBelong(this.instance);
				}
				return r__anchor;
			}
		}

		/// <summary>
		/// System.String _StyleName
		/// </summary>
		protected RField r__StyleName;
		public virtual RField R_StyleName
		{
			get
			{
				if(r__StyleName == null)
				{
					r__StyleName = new(this, "_StyleName");
					r__StyleName.SetBelong(this.instance);
				}
				return r__StyleName;
			}
		}

		/// <summary>
		/// System.Boolean _UnderLine
		/// </summary>
		protected RField r__UnderLine;
		public virtual RField R_UnderLine
		{
			get
			{
				if(r__UnderLine == null)
				{
					r__UnderLine = new(this, "_UnderLine");
					r__UnderLine.SetBelong(this.instance);
				}
				return r__UnderLine;
			}
		}

		/// <summary>
		/// GameDefineType.ID _clickId
		/// </summary>
		protected RGameDefineType.RID r__clickId;
		public virtual RGameDefineType.RID R_clickId
		{
			get
			{
				if(r__clickId == null)
				{
					r__clickId = new(this, "_clickId");
					r__clickId.SetBelong(this.instance);
				}
				return r__clickId;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] _clickParas
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r__clickParas;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R_clickParas
		{
			get
			{
				if(r__clickParas == null)
				{
					r__clickParas = new(this, "_clickParas");
					r__clickParas.SetBelong(this.instance);
				}
				return r__clickParas;
			}
		}

		/// <summary>
		/// System.Boolean _Bold
		/// </summary>
		protected RField r__Bold;
		public virtual RField R_Bold
		{
			get
			{
				if(r__Bold == null)
				{
					r__Bold = new(this, "_Bold");
					r__Bold.SetBelong(this.instance);
				}
				return r__Bold;
			}
		}

		/// <summary>
		/// System.Boolean _NewLine
		/// </summary>
		protected RField r__NewLine;
		public virtual RField R_NewLine
		{
			get
			{
				if(r__NewLine == null)
				{
					r__NewLine = new(this, "_NewLine");
					r__NewLine.SetBelong(this.instance);
				}
				return r__NewLine;
			}
		}

		/// <summary>
		/// System.Int32 _Shadow
		/// </summary>
		protected RField r__Shadow;
		public virtual RField R_Shadow
		{
			get
			{
				if(r__Shadow == null)
				{
					r__Shadow = new(this, "_Shadow");
					r__Shadow.SetBelong(this.instance);
				}
				return r__Shadow;
			}
		}

		/// <summary>
		/// System.Int32 _faceId
		/// </summary>
		protected RField r__faceId;
		public virtual RField R_faceId
		{
			get
			{
				if(r__faceId == null)
				{
					r__faceId = new(this, "_faceId");
					r__faceId.SetBelong(this.instance);
				}
				return r__faceId;
			}
		}

		/// <summary>
		/// System.String _url
		/// </summary>
		protected RField r__url;
		public virtual RField R_url
		{
			get
			{
				if(r__url == null)
				{
					r__url = new(this, "_url");
					r__url.SetBelong(this.instance);
				}
				return r__url;
			}
		}

		/// <summary>
		/// System.String _WndName
		/// </summary>
		protected RField r__WndName;
		public virtual RField R_WndName
		{
			get
			{
				if(r__WndName == null)
				{
					r__WndName = new(this, "_WndName");
					r__WndName.SetBelong(this.instance);
				}
				return r__WndName;
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


        public RWordSeg() : base("MyGUI.WordSeg")
        {
        }

        public RWordSeg(System.Object instance) : base("MyGUI.WordSeg")
		{
            SetInstance(instance);
		}

        public RWordSeg(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWordSeg(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
