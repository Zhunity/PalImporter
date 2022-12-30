using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieDialogCmd
	/// </summary>
    public partial class RSceneMovieDialogCmd : RMember //
    {

		/// <summary>
		/// System.String m_sCmdType
		/// </summary>
		protected RField r_m_sCmdType;
		public virtual RField Rm_sCmdType
		{
			get
			{
				if(r_m_sCmdType == null)
				{
					r_m_sCmdType = new(this, "m_sCmdType");
					r_m_sCmdType.SetBelong(this.instance);
				}
				return r_m_sCmdType;
			}
		}

		/// <summary>
		/// System.String texture
		/// </summary>
		protected RField r_texture;
		public virtual RField Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture");
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// System.String charName
		/// </summary>
		protected RField r_charName;
		public virtual RField RcharName
		{
			get
			{
				if(r_charName == null)
				{
					r_charName = new(this, "charName");
					r_charName.SetBelong(this.instance);
				}
				return r_charName;
			}
		}

		/// <summary>
		/// System.String head
		/// </summary>
		protected RField r_head;
		public virtual RField Rhead
		{
			get
			{
				if(r_head == null)
				{
					r_head = new(this, "head");
					r_head.SetBelong(this.instance);
				}
				return r_head;
			}
		}

		/// <summary>
		/// System.String otherhead
		/// </summary>
		protected RField r_otherhead;
		public virtual RField Rotherhead
		{
			get
			{
				if(r_otherhead == null)
				{
					r_otherhead = new(this, "otherhead");
					r_otherhead.SetBelong(this.instance);
				}
				return r_otherhead;
			}
		}

		/// <summary>
		/// System.String refName
		/// </summary>
		protected RField r_refName;
		public virtual RField RrefName
		{
			get
			{
				if(r_refName == null)
				{
					r_refName = new(this, "refName");
					r_refName.SetBelong(this.instance);
				}
				return r_refName;
			}
		}

		/// <summary>
		/// System.String text
		/// </summary>
		protected RField r_text;
		public virtual RField Rtext
		{
			get
			{
				if(r_text == null)
				{
					r_text = new(this, "text");
					r_text.SetBelong(this.instance);
				}
				return r_text;
			}
		}

		/// <summary>
		/// System.String anchor
		/// </summary>
		protected RField r_anchor;
		public virtual RField Ranchor
		{
			get
			{
				if(r_anchor == null)
				{
					r_anchor = new(this, "anchor");
					r_anchor.SetBelong(this.instance);
				}
				return r_anchor;
			}
		}

		/// <summary>
		/// System.Single speed
		/// </summary>
		protected RField r_speed;
		public virtual RField Rspeed
		{
			get
			{
				if(r_speed == null)
				{
					r_speed = new(this, "speed");
					r_speed.SetBelong(this.instance);
				}
				return r_speed;
			}
		}

		/// <summary>
		/// System.Single delay
		/// </summary>
		protected RField r_delay;
		public virtual RField Rdelay
		{
			get
			{
				if(r_delay == null)
				{
					r_delay = new(this, "delay");
					r_delay.SetBelong(this.instance);
				}
				return r_delay;
			}
		}

		/// <summary>
		/// System.Single popdelay
		/// </summary>
		protected RField r_popdelay;
		public virtual RField Rpopdelay
		{
			get
			{
				if(r_popdelay == null)
				{
					r_popdelay = new(this, "popdelay");
					r_popdelay.SetBelong(this.instance);
				}
				return r_popdelay;
			}
		}

		/// <summary>
		/// System.Single fadeintime
		/// </summary>
		protected RField r_fadeintime;
		public virtual RField Rfadeintime
		{
			get
			{
				if(r_fadeintime == null)
				{
					r_fadeintime = new(this, "fadeintime");
					r_fadeintime.SetBelong(this.instance);
				}
				return r_fadeintime;
			}
		}

		/// <summary>
		/// System.Single fadeouttime
		/// </summary>
		protected RField r_fadeouttime;
		public virtual RField Rfadeouttime
		{
			get
			{
				if(r_fadeouttime == null)
				{
					r_fadeouttime = new(this, "fadeouttime");
					r_fadeouttime.SetBelong(this.instance);
				}
				return r_fadeouttime;
			}
		}

		/// <summary>
		/// System.Byte fadetype
		/// </summary>
		protected RField r_fadetype;
		public virtual RField Rfadetype
		{
			get
			{
				if(r_fadetype == null)
				{
					r_fadetype = new(this, "fadetype");
					r_fadetype.SetBelong(this.instance);
				}
				return r_fadetype;
			}
		}

		/// <summary>
		/// System.Boolean click
		/// </summary>
		protected RField r_click;
		public virtual RField Rclick
		{
			get
			{
				if(r_click == null)
				{
					r_click = new(this, "click");
					r_click.SetBelong(this.instance);
				}
				return r_click;
			}
		}

		/// <summary>
		/// System.Boolean bShowPop
		/// </summary>
		protected RField r_bShowPop;
		public virtual RField RbShowPop
		{
			get
			{
				if(r_bShowPop == null)
				{
					r_bShowPop = new(this, "bShowPop");
					r_bShowPop.SetBelong(this.instance);
				}
				return r_bShowPop;
			}
		}

		/// <summary>
		/// System.Boolean bshowRight
		/// </summary>
		protected RField r_bshowRight;
		public virtual RField RbshowRight
		{
			get
			{
				if(r_bshowRight == null)
				{
					r_bshowRight = new(this, "bshowRight");
					r_bshowRight.SetBelong(this.instance);
				}
				return r_bshowRight;
			}
		}

		/// <summary>
		/// System.Int32 picposx
		/// </summary>
		protected RField r_picposx;
		public virtual RField Rpicposx
		{
			get
			{
				if(r_picposx == null)
				{
					r_picposx = new(this, "picposx");
					r_picposx.SetBelong(this.instance);
				}
				return r_picposx;
			}
		}

		/// <summary>
		/// System.Int32 picposy
		/// </summary>
		protected RField r_picposy;
		public virtual RField Rpicposy
		{
			get
			{
				if(r_picposy == null)
				{
					r_picposy = new(this, "picposy");
					r_picposy.SetBelong(this.instance);
				}
				return r_picposy;
			}
		}

		/// <summary>
		/// System.Boolean bShowBG
		/// </summary>
		protected RField r_bShowBG;
		public virtual RField RbShowBG
		{
			get
			{
				if(r_bShowBG == null)
				{
					r_bShowBG = new(this, "bShowBG");
					r_bShowBG.SetBelong(this.instance);
				}
				return r_bShowBG;
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


        public RSceneMovieDialogCmd() : base("SceneMovieDialogCmd")
        {
        }

        public RSceneMovieDialogCmd(System.Object instance) : base("SceneMovieDialogCmd")
		{
            SetInstance(instance);
		}

        public RSceneMovieDialogCmd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieDialogCmd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
