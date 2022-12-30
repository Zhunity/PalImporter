using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TITLE_INFO
	/// </summary>
    public partial class RTITLE_INFO : RMember //
    {

		/// <summary>
		/// System.Int32 id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
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
		/// System.Byte bold
		/// </summary>
		protected RField r_bold;
		public virtual RField Rbold
		{
			get
			{
				if(r_bold == null)
				{
					r_bold = new(this, "bold");
					r_bold.SetBelong(this.instance);
				}
				return r_bold;
			}
		}

		/// <summary>
		/// System.Int32 size
		/// </summary>
		protected RField r_size;
		public virtual RField Rsize
		{
			get
			{
				if(r_size == null)
				{
					r_size = new(this, "size");
					r_size.SetBelong(this.instance);
				}
				return r_size;
			}
		}

		/// <summary>
		/// System.Int32 colorIdx
		/// </summary>
		protected RField r_colorIdx;
		public virtual RField RcolorIdx
		{
			get
			{
				if(r_colorIdx == null)
				{
					r_colorIdx = new(this, "colorIdx");
					r_colorIdx.SetBelong(this.instance);
				}
				return r_colorIdx;
			}
		}

		/// <summary>
		/// System.String effect
		/// </summary>
		protected RField r_effect;
		public virtual RField Reffect
		{
			get
			{
				if(r_effect == null)
				{
					r_effect = new(this, "effect");
					r_effect.SetBelong(this.instance);
				}
				return r_effect;
			}
		}

		/// <summary>
		/// System.String icon
		/// </summary>
		protected RField r_icon;
		public virtual RField Ricon
		{
			get
			{
				if(r_icon == null)
				{
					r_icon = new(this, "icon");
					r_icon.SetBelong(this.instance);
				}
				return r_icon;
			}
		}

		/// <summary>
		/// System.String body
		/// </summary>
		protected RField r_body;
		public virtual RField Rbody
		{
			get
			{
				if(r_body == null)
				{
					r_body = new(this, "body");
					r_body.SetBelong(this.instance);
				}
				return r_body;
			}
		}

		/// <summary>
		/// System.String desc
		/// </summary>
		protected RField r_desc;
		public virtual RField Rdesc
		{
			get
			{
				if(r_desc == null)
				{
					r_desc = new(this, "desc");
					r_desc.SetBelong(this.instance);
				}
				return r_desc;
			}
		}

		/// <summary>
		/// System.String chaticon
		/// </summary>
		protected RField r_chaticon;
		public virtual RField Rchaticon
		{
			get
			{
				if(r_chaticon == null)
				{
					r_chaticon = new(this, "chaticon");
					r_chaticon.SetBelong(this.instance);
				}
				return r_chaticon;
			}
		}

		/// <summary>
		/// System.String iconsize
		/// </summary>
		protected RField r_iconsize;
		public virtual RField Riconsize
		{
			get
			{
				if(r_iconsize == null)
				{
					r_iconsize = new(this, "iconsize");
					r_iconsize.SetBelong(this.instance);
				}
				return r_iconsize;
			}
		}

		/// <summary>
		/// System.String attribute
		/// </summary>
		protected RField r_attribute;
		public virtual RField Rattribute
		{
			get
			{
				if(r_attribute == null)
				{
					r_attribute = new(this, "attribute");
					r_attribute.SetBelong(this.instance);
				}
				return r_attribute;
			}
		}

		/// <summary>
		/// System.Int32 rare
		/// </summary>
		protected RField r_rare;
		public virtual RField Rrare
		{
			get
			{
				if(r_rare == null)
				{
					r_rare = new(this, "rare");
					r_rare.SetBelong(this.instance);
				}
				return r_rare;
			}
		}

		/// <summary>
		/// System.Int32 platform
		/// </summary>
		protected RField r_platform;
		public virtual RField Rplatform
		{
			get
			{
				if(r_platform == null)
				{
					r_platform = new(this, "platform");
					r_platform.SetBelong(this.instance);
				}
				return r_platform;
			}
		}

		/// <summary>
		/// System.String ownername
		/// </summary>
		protected RField r_ownername;
		public virtual RField Rownername
		{
			get
			{
				if(r_ownername == null)
				{
					r_ownername = new(this, "ownername");
					r_ownername.SetBelong(this.instance);
				}
				return r_ownername;
			}
		}

		/// <summary>
		/// UnityEngine.Texture iconTex
		/// </summary>
		protected RUnityEngine.RTexture r_iconTex;
		public virtual RUnityEngine.RTexture RiconTex
		{
			get
			{
				if(r_iconTex == null)
				{
					r_iconTex = new(this, "iconTex");
					r_iconTex.SetBelong(this.instance);
				}
				return r_iconTex;
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


        public RTITLE_INFO() : base("TITLE_INFO")
        {
        }

        public RTITLE_INFO(System.Object instance) : base("TITLE_INFO")
		{
            SetInstance(instance);
		}

        public RTITLE_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTITLE_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
