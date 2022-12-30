using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MountSkillConfig
	/// </summary>
    public partial class RMountSkillConfig : RMember //
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
		/// System.Int32 group
		/// </summary>
		protected RField r_group;
		public virtual RField Rgroup
		{
			get
			{
				if(r_group == null)
				{
					r_group = new(this, "group");
					r_group.SetBelong(this.instance);
				}
				return r_group;
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
		/// System.String effectDes
		/// </summary>
		protected RField r_effectDes;
		public virtual RField ReffectDes
		{
			get
			{
				if(r_effectDes == null)
				{
					r_effectDes = new(this, "effectDes");
					r_effectDes.SetBelong(this.instance);
				}
				return r_effectDes;
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
		/// System.String typeDes
		/// </summary>
		protected RField r_typeDes;
		public virtual RField RtypeDes
		{
			get
			{
				if(r_typeDes == null)
				{
					r_typeDes = new(this, "typeDes");
					r_typeDes.SetBelong(this.instance);
				}
				return r_typeDes;
			}
		}

		/// <summary>
		/// System.Int32 upItem
		/// </summary>
		protected RField r_upItem;
		public virtual RField RupItem
		{
			get
			{
				if(r_upItem == null)
				{
					r_upItem = new(this, "upItem");
					r_upItem.SetBelong(this.instance);
				}
				return r_upItem;
			}
		}

		/// <summary>
		/// System.String lvInfo_0
		/// </summary>
		protected RField r_lvInfo_0;
		public virtual RField RlvInfo_0
		{
			get
			{
				if(r_lvInfo_0 == null)
				{
					r_lvInfo_0 = new(this, "lvInfo_0");
					r_lvInfo_0.SetBelong(this.instance);
				}
				return r_lvInfo_0;
			}
		}

		/// <summary>
		/// System.String lvInfo_5
		/// </summary>
		protected RField r_lvInfo_5;
		public virtual RField RlvInfo_5
		{
			get
			{
				if(r_lvInfo_5 == null)
				{
					r_lvInfo_5 = new(this, "lvInfo_5");
					r_lvInfo_5.SetBelong(this.instance);
				}
				return r_lvInfo_5;
			}
		}

		/// <summary>
		/// System.String lvInfo_10
		/// </summary>
		protected RField r_lvInfo_10;
		public virtual RField RlvInfo_10
		{
			get
			{
				if(r_lvInfo_10 == null)
				{
					r_lvInfo_10 = new(this, "lvInfo_10");
					r_lvInfo_10.SetBelong(this.instance);
				}
				return r_lvInfo_10;
			}
		}

		/// <summary>
		/// System.String lvInfo_15
		/// </summary>
		protected RField r_lvInfo_15;
		public virtual RField RlvInfo_15
		{
			get
			{
				if(r_lvInfo_15 == null)
				{
					r_lvInfo_15 = new(this, "lvInfo_15");
					r_lvInfo_15.SetBelong(this.instance);
				}
				return r_lvInfo_15;
			}
		}

		/// <summary>
		/// System.String lvInfo_20
		/// </summary>
		protected RField r_lvInfo_20;
		public virtual RField RlvInfo_20
		{
			get
			{
				if(r_lvInfo_20 == null)
				{
					r_lvInfo_20 = new(this, "lvInfo_20");
					r_lvInfo_20.SetBelong(this.instance);
				}
				return r_lvInfo_20;
			}
		}

		/// <summary>
		/// System.String lvInfo_25
		/// </summary>
		protected RField r_lvInfo_25;
		public virtual RField RlvInfo_25
		{
			get
			{
				if(r_lvInfo_25 == null)
				{
					r_lvInfo_25 = new(this, "lvInfo_25");
					r_lvInfo_25.SetBelong(this.instance);
				}
				return r_lvInfo_25;
			}
		}

		/// <summary>
		/// System.String lvInfo_30
		/// </summary>
		protected RField r_lvInfo_30;
		public virtual RField RlvInfo_30
		{
			get
			{
				if(r_lvInfo_30 == null)
				{
					r_lvInfo_30 = new(this, "lvInfo_30");
					r_lvInfo_30.SetBelong(this.instance);
				}
				return r_lvInfo_30;
			}
		}

		/// <summary>
		/// System.String lvInfo_35
		/// </summary>
		protected RField r_lvInfo_35;
		public virtual RField RlvInfo_35
		{
			get
			{
				if(r_lvInfo_35 == null)
				{
					r_lvInfo_35 = new(this, "lvInfo_35");
					r_lvInfo_35.SetBelong(this.instance);
				}
				return r_lvInfo_35;
			}
		}

		/// <summary>
		/// System.String lvInfo_40
		/// </summary>
		protected RField r_lvInfo_40;
		public virtual RField RlvInfo_40
		{
			get
			{
				if(r_lvInfo_40 == null)
				{
					r_lvInfo_40 = new(this, "lvInfo_40");
					r_lvInfo_40.SetBelong(this.instance);
				}
				return r_lvInfo_40;
			}
		}

		/// <summary>
		/// System.String lvInfo_45
		/// </summary>
		protected RField r_lvInfo_45;
		public virtual RField RlvInfo_45
		{
			get
			{
				if(r_lvInfo_45 == null)
				{
					r_lvInfo_45 = new(this, "lvInfo_45");
					r_lvInfo_45.SetBelong(this.instance);
				}
				return r_lvInfo_45;
			}
		}

		/// <summary>
		/// System.String lvInfo_50
		/// </summary>
		protected RField r_lvInfo_50;
		public virtual RField RlvInfo_50
		{
			get
			{
				if(r_lvInfo_50 == null)
				{
					r_lvInfo_50 = new(this, "lvInfo_50");
					r_lvInfo_50.SetBelong(this.instance);
				}
				return r_lvInfo_50;
			}
		}

		/// <summary>
		/// System.String lvInfo_55
		/// </summary>
		protected RField r_lvInfo_55;
		public virtual RField RlvInfo_55
		{
			get
			{
				if(r_lvInfo_55 == null)
				{
					r_lvInfo_55 = new(this, "lvInfo_55");
					r_lvInfo_55.SetBelong(this.instance);
				}
				return r_lvInfo_55;
			}
		}

		/// <summary>
		/// System.String lvInfo_60
		/// </summary>
		protected RField r_lvInfo_60;
		public virtual RField RlvInfo_60
		{
			get
			{
				if(r_lvInfo_60 == null)
				{
					r_lvInfo_60 = new(this, "lvInfo_60");
					r_lvInfo_60.SetBelong(this.instance);
				}
				return r_lvInfo_60;
			}
		}

		/// <summary>
		/// System.Int32 maxLv
		/// </summary>
		protected RField r_maxLv;
		public virtual RField RmaxLv
		{
			get
			{
				if(r_maxLv == null)
				{
					r_maxLv = new(this, "maxLv");
					r_maxLv.SetBelong(this.instance);
				}
				return r_maxLv;
			}
		}

		/// <summary>
		/// Int32 GetLvInfo(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetLvInfo_Int32_Int32;
		public virtual RMethod RGetLvInfo_Int32_Int32
		{
			get
			{
				if(r_RGetLvInfo_Int32_Int32 == null)
				{
					r_RGetLvInfo_Int32_Int32 = new(this, "GetLvInfo", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetLvInfo_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetLvInfo_Int32_Int32;
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


        public RMountSkillConfig() : base("MountSkillConfig")
        {
        }

        public RMountSkillConfig(System.Object instance) : base("MountSkillConfig")
		{
            SetInstance(instance);
		}

        public RMountSkillConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMountSkillConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetLvInfo(System.Int32  @lv, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lv, @type};
            var ___result = RGetLvInfo_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
