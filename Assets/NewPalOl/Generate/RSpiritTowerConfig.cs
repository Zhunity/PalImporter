using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SpiritTowerConfig
	/// </summary>
    public partial class RSpiritTowerConfig : RMember //
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
		/// System.String light_pro
		/// </summary>
		protected RField r_light_pro;
		public virtual RField Rlight_pro
		{
			get
			{
				if(r_light_pro == null)
				{
					r_light_pro = new(this, "light_pro");
					r_light_pro.SetBelong(this.instance);
				}
				return r_light_pro;
			}
		}

		/// <summary>
		/// System.Int32 down_to
		/// </summary>
		protected RField r_down_to;
		public virtual RField Rdown_to
		{
			get
			{
				if(r_down_to == null)
				{
					r_down_to = new(this, "down_to");
					r_down_to.SetBelong(this.instance);
				}
				return r_down_to;
			}
		}

		/// <summary>
		/// System.Int32 goldex
		/// </summary>
		protected RField r_goldex;
		public virtual RField Rgoldex
		{
			get
			{
				if(r_goldex == null)
				{
					r_goldex = new(this, "goldex");
					r_goldex.SetBelong(this.instance);
				}
				return r_goldex;
			}
		}

		/// <summary>
		/// System.Int32 point
		/// </summary>
		protected RField r_point;
		public virtual RField Rpoint
		{
			get
			{
				if(r_point == null)
				{
					r_point = new(this, "point");
					r_point.SetBelong(this.instance);
				}
				return r_point;
			}
		}

		/// <summary>
		/// System.Int32 white_pro
		/// </summary>
		protected RField r_white_pro;
		public virtual RField Rwhite_pro
		{
			get
			{
				if(r_white_pro == null)
				{
					r_white_pro = new(this, "white_pro");
					r_white_pro.SetBelong(this.instance);
				}
				return r_white_pro;
			}
		}

		/// <summary>
		/// System.Int32 green_pro
		/// </summary>
		protected RField r_green_pro;
		public virtual RField Rgreen_pro
		{
			get
			{
				if(r_green_pro == null)
				{
					r_green_pro = new(this, "green_pro");
					r_green_pro.SetBelong(this.instance);
				}
				return r_green_pro;
			}
		}

		/// <summary>
		/// System.Int32 blue_pro
		/// </summary>
		protected RField r_blue_pro;
		public virtual RField Rblue_pro
		{
			get
			{
				if(r_blue_pro == null)
				{
					r_blue_pro = new(this, "blue_pro");
					r_blue_pro.SetBelong(this.instance);
				}
				return r_blue_pro;
			}
		}

		/// <summary>
		/// System.Int32 violet_pro
		/// </summary>
		protected RField r_violet_pro;
		public virtual RField Rviolet_pro
		{
			get
			{
				if(r_violet_pro == null)
				{
					r_violet_pro = new(this, "violet_pro");
					r_violet_pro.SetBelong(this.instance);
				}
				return r_violet_pro;
			}
		}

		/// <summary>
		/// System.Int32 red_pro
		/// </summary>
		protected RField r_red_pro;
		public virtual RField Rred_pro
		{
			get
			{
				if(r_red_pro == null)
				{
					r_red_pro = new(this, "red_pro");
					r_red_pro.SetBelong(this.instance);
				}
				return r_red_pro;
			}
		}

		/// <summary>
		/// System.Int32 gold_pro
		/// </summary>
		protected RField r_gold_pro;
		public virtual RField Rgold_pro
		{
			get
			{
				if(r_gold_pro == null)
				{
					r_gold_pro = new(this, "gold_pro");
					r_gold_pro.SetBelong(this.instance);
				}
				return r_gold_pro;
			}
		}

		/// <summary>
		/// System.Int32 dark_pro
		/// </summary>
		protected RField r_dark_pro;
		public virtual RField Rdark_pro
		{
			get
			{
				if(r_dark_pro == null)
				{
					r_dark_pro = new(this, "dark_pro");
					r_dark_pro.SetBelong(this.instance);
				}
				return r_dark_pro;
			}
		}

		/// <summary>
		/// System.Int32 light_gold
		/// </summary>
		protected RField r_light_gold;
		public virtual RField Rlight_gold
		{
			get
			{
				if(r_light_gold == null)
				{
					r_light_gold = new(this, "light_gold");
					r_light_gold.SetBelong(this.instance);
				}
				return r_light_gold;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// System.Int32 need_level
		/// </summary>
		protected RField r_need_level;
		public virtual RField Rneed_level
		{
			get
			{
				if(r_need_level == null)
				{
					r_need_level = new(this, "need_level");
					r_need_level.SetBelong(this.instance);
				}
				return r_need_level;
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


        public RSpiritTowerConfig() : base("SpiritTowerConfig")
        {
        }

        public RSpiritTowerConfig(System.Object instance) : base("SpiritTowerConfig")
		{
            SetInstance(instance);
		}

        public RSpiritTowerConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSpiritTowerConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
