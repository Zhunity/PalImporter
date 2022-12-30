using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PreviewConfig
	/// </summary>
    public partial class RPreviewConfig : RMember //
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
		/// System.Int32 starLevel
		/// </summary>
		protected RField r_starLevel;
		public virtual RField RstarLevel
		{
			get
			{
				if(r_starLevel == null)
				{
					r_starLevel = new(this, "starLevel");
					r_starLevel.SetBelong(this.instance);
				}
				return r_starLevel;
			}
		}

		/// <summary>
		/// System.Int32 endLevel
		/// </summary>
		protected RField r_endLevel;
		public virtual RField RendLevel
		{
			get
			{
				if(r_endLevel == null)
				{
					r_endLevel = new(this, "endLevel");
					r_endLevel.SetBelong(this.instance);
				}
				return r_endLevel;
			}
		}

		/// <summary>
		/// System.Int32 showLevel
		/// </summary>
		protected RField r_showLevel;
		public virtual RField RshowLevel
		{
			get
			{
				if(r_showLevel == null)
				{
					r_showLevel = new(this, "showLevel");
					r_showLevel.SetBelong(this.instance);
				}
				return r_showLevel;
			}
		}

		/// <summary>
		/// System.String description
		/// </summary>
		protected RField r_description;
		public virtual RField Rdescription
		{
			get
			{
				if(r_description == null)
				{
					r_description = new(this, "description");
					r_description.SetBelong(this.instance);
				}
				return r_description;
			}
		}

		/// <summary>
		/// System.String picUrl
		/// </summary>
		protected RField r_picUrl;
		public virtual RField RpicUrl
		{
			get
			{
				if(r_picUrl == null)
				{
					r_picUrl = new(this, "picUrl");
					r_picUrl.SetBelong(this.instance);
				}
				return r_picUrl;
			}
		}

		/// <summary>
		/// System.String iconUrl
		/// </summary>
		protected RField r_iconUrl;
		public virtual RField RiconUrl
		{
			get
			{
				if(r_iconUrl == null)
				{
					r_iconUrl = new(this, "iconUrl");
					r_iconUrl.SetBelong(this.instance);
				}
				return r_iconUrl;
			}
		}

		/// <summary>
		/// System.String textContent
		/// </summary>
		protected RField r_textContent;
		public virtual RField RtextContent
		{
			get
			{
				if(r_textContent == null)
				{
					r_textContent = new(this, "textContent");
					r_textContent.SetBelong(this.instance);
				}
				return r_textContent;
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


        public RPreviewConfig() : base("PreviewConfig")
        {
        }

        public RPreviewConfig(System.Object instance) : base("PreviewConfig")
		{
            SetInstance(instance);
		}

        public RPreviewConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPreviewConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
