using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MountPetConfig
	/// </summary>
    public partial class RMountPetConfig : RMember //
    {

		/// <summary>
		/// System.Int32 typeId
		/// </summary>
		protected RField r_typeId;
		public virtual RField RtypeId
		{
			get
			{
				if(r_typeId == null)
				{
					r_typeId = new(this, "typeId");
					r_typeId.SetBelong(this.instance);
				}
				return r_typeId;
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
		/// System.Int32 base_speed
		/// </summary>
		protected RField r_base_speed;
		public virtual RField Rbase_speed
		{
			get
			{
				if(r_base_speed == null)
				{
					r_base_speed = new(this, "base_speed");
					r_base_speed.SetBelong(this.instance);
				}
				return r_base_speed;
			}
		}

		/// <summary>
		/// System.Int32 hp_add
		/// </summary>
		protected RField r_hp_add;
		public virtual RField Rhp_add
		{
			get
			{
				if(r_hp_add == null)
				{
					r_hp_add = new(this, "hp_add");
					r_hp_add.SetBelong(this.instance);
				}
				return r_hp_add;
			}
		}

		/// <summary>
		/// System.Int32 w_atk
		/// </summary>
		protected RField r_w_atk;
		public virtual RField Rw_atk
		{
			get
			{
				if(r_w_atk == null)
				{
					r_w_atk = new(this, "w_atk");
					r_w_atk.SetBelong(this.instance);
				}
				return r_w_atk;
			}
		}

		/// <summary>
		/// System.Int32 w_arm
		/// </summary>
		protected RField r_w_arm;
		public virtual RField Rw_arm
		{
			get
			{
				if(r_w_arm == null)
				{
					r_w_arm = new(this, "w_arm");
					r_w_arm.SetBelong(this.instance);
				}
				return r_w_arm;
			}
		}

		/// <summary>
		/// System.Int32 critical_per
		/// </summary>
		protected RField r_critical_per;
		public virtual RField Rcritical_per
		{
			get
			{
				if(r_critical_per == null)
				{
					r_critical_per = new(this, "critical_per");
					r_critical_per.SetBelong(this.instance);
				}
				return r_critical_per;
			}
		}

		/// <summary>
		/// System.Int32 toughness_per
		/// </summary>
		protected RField r_toughness_per;
		public virtual RField Rtoughness_per
		{
			get
			{
				if(r_toughness_per == null)
				{
					r_toughness_per = new(this, "toughness_per");
					r_toughness_per.SetBelong(this.instance);
				}
				return r_toughness_per;
			}
		}

		/// <summary>
		/// System.Int32 wreck_per
		/// </summary>
		protected RField r_wreck_per;
		public virtual RField Rwreck_per
		{
			get
			{
				if(r_wreck_per == null)
				{
					r_wreck_per = new(this, "wreck_per");
					r_wreck_per.SetBelong(this.instance);
				}
				return r_wreck_per;
			}
		}

		/// <summary>
		/// System.Int32 block_per
		/// </summary>
		protected RField r_block_per;
		public virtual RField Rblock_per
		{
			get
			{
				if(r_block_per == null)
				{
					r_block_per = new(this, "block_per");
					r_block_per.SetBelong(this.instance);
				}
				return r_block_per;
			}
		}

		/// <summary>
		/// System.Int32 resid
		/// </summary>
		protected RField r_resid;
		public virtual RField Rresid
		{
			get
			{
				if(r_resid == null)
				{
					r_resid = new(this, "resid");
					r_resid.SetBelong(this.instance);
				}
				return r_resid;
			}
		}

		/// <summary>
		/// System.Int32 speed_client
		/// </summary>
		protected RField r_speed_client;
		public virtual RField Rspeed_client
		{
			get
			{
				if(r_speed_client == null)
				{
					r_speed_client = new(this, "speed_client");
					r_speed_client.SetBelong(this.instance);
				}
				return r_speed_client;
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
		/// System.String effectBone
		/// </summary>
		protected RField r_effectBone;
		public virtual RField ReffectBone
		{
			get
			{
				if(r_effectBone == null)
				{
					r_effectBone = new(this, "effectBone");
					r_effectBone.SetBelong(this.instance);
				}
				return r_effectBone;
			}
		}

		/// <summary>
		/// System.String effectPath
		/// </summary>
		protected RField r_effectPath;
		public virtual RField ReffectPath
		{
			get
			{
				if(r_effectPath == null)
				{
					r_effectPath = new(this, "effectPath");
					r_effectPath.SetBelong(this.instance);
				}
				return r_effectPath;
			}
		}

		/// <summary>
		/// System.Int32 isduethorse
		/// </summary>
		protected RField r_isduethorse;
		public virtual RField Risduethorse
		{
			get
			{
				if(r_isduethorse == null)
				{
					r_isduethorse = new(this, "isduethorse");
					r_isduethorse.SetBelong(this.instance);
				}
				return r_isduethorse;
			}
		}

		/// <summary>
		/// System.Int32 description2
		/// </summary>
		protected RField r_description2;
		public virtual RField Rdescription2
		{
			get
			{
				if(r_description2 == null)
				{
					r_description2 = new(this, "description2");
					r_description2.SetBelong(this.instance);
				}
				return r_description2;
			}
		}

		/// <summary>
		/// System.Int32 appearanceattradd
		/// </summary>
		protected RField r_appearanceattradd;
		public virtual RField Rappearanceattradd
		{
			get
			{
				if(r_appearanceattradd == null)
				{
					r_appearanceattradd = new(this, "appearanceattradd");
					r_appearanceattradd.SetBelong(this.instance);
				}
				return r_appearanceattradd;
			}
		}

		/// <summary>
		/// System.Int32 subType1
		/// </summary>
		protected RField r_subType1;
		public virtual RField RsubType1
		{
			get
			{
				if(r_subType1 == null)
				{
					r_subType1 = new(this, "subType1");
					r_subType1.SetBelong(this.instance);
				}
				return r_subType1;
			}
		}

		/// <summary>
		/// System.Int32 subType2
		/// </summary>
		protected RField r_subType2;
		public virtual RField RsubType2
		{
			get
			{
				if(r_subType2 == null)
				{
					r_subType2 = new(this, "subType2");
					r_subType2.SetBelong(this.instance);
				}
				return r_subType2;
			}
		}

		/// <summary>
		/// System.Int32 level
		/// </summary>
		protected RField r_level;
		public virtual RField Rlevel
		{
			get
			{
				if(r_level == null)
				{
					r_level = new(this, "level");
					r_level.SetBelong(this.instance);
				}
				return r_level;
			}
		}

		/// <summary>
		/// System.Int32 groupType
		/// </summary>
		protected RField r_groupType;
		public virtual RField RgroupType
		{
			get
			{
				if(r_groupType == null)
				{
					r_groupType = new(this, "groupType");
					r_groupType.SetBelong(this.instance);
				}
				return r_groupType;
			}
		}

		/// <summary>
		/// System.String group
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
		/// System.Int32 dodge
		/// </summary>
		protected RField r_dodge;
		public virtual RField Rdodge
		{
			get
			{
				if(r_dodge == null)
				{
					r_dodge = new(this, "dodge");
					r_dodge.SetBelong(this.instance);
				}
				return r_dodge;
			}
		}

		/// <summary>
		/// System.Int32 hit_first
		/// </summary>
		protected RField r_hit_first;
		public virtual RField Rhit_first
		{
			get
			{
				if(r_hit_first == null)
				{
					r_hit_first = new(this, "hit_first");
					r_hit_first.SetBelong(this.instance);
				}
				return r_hit_first;
			}
		}

		/// <summary>
		/// System.Int32 hit_ratio
		/// </summary>
		protected RField r_hit_ratio;
		public virtual RField Rhit_ratio
		{
			get
			{
				if(r_hit_ratio == null)
				{
					r_hit_ratio = new(this, "hit_ratio");
					r_hit_ratio.SetBelong(this.instance);
				}
				return r_hit_ratio;
			}
		}

		/// <summary>
		/// System.Int32 itemnum
		/// </summary>
		protected RField r_itemnum;
		public virtual RField Ritemnum
		{
			get
			{
				if(r_itemnum == null)
				{
					r_itemnum = new(this, "itemnum");
					r_itemnum.SetBelong(this.instance);
				}
				return r_itemnum;
			}
		}

		/// <summary>
		/// System.Int32 up_item
		/// </summary>
		protected RField r_up_item;
		public virtual RField Rup_item
		{
			get
			{
				if(r_up_item == null)
				{
					r_up_item = new(this, "up_item");
					r_up_item.SetBelong(this.instance);
				}
				return r_up_item;
			}
		}

		/// <summary>
		/// System.Int32 up_item2
		/// </summary>
		protected RField r_up_item2;
		public virtual RField Rup_item2
		{
			get
			{
				if(r_up_item2 == null)
				{
					r_up_item2 = new(this, "up_item2");
					r_up_item2.SetBelong(this.instance);
				}
				return r_up_item2;
			}
		}

		/// <summary>
		/// System.Int32 up_item3
		/// </summary>
		protected RField r_up_item3;
		public virtual RField Rup_item3
		{
			get
			{
				if(r_up_item3 == null)
				{
					r_up_item3 = new(this, "up_item3");
					r_up_item3.SetBelong(this.instance);
				}
				return r_up_item3;
			}
		}

		/// <summary>
		/// System.Int32 up_cost
		/// </summary>
		protected RField r_up_cost;
		public virtual RField Rup_cost
		{
			get
			{
				if(r_up_cost == null)
				{
					r_up_cost = new(this, "up_cost");
					r_up_cost.SetBelong(this.instance);
				}
				return r_up_cost;
			}
		}

		/// <summary>
		/// System.Int32 max_blessing
		/// </summary>
		protected RField r_max_blessing;
		public virtual RField Rmax_blessing
		{
			get
			{
				if(r_max_blessing == null)
				{
					r_max_blessing = new(this, "max_blessing");
					r_max_blessing.SetBelong(this.instance);
				}
				return r_max_blessing;
			}
		}

		/// <summary>
		/// System.Int32 skill1
		/// </summary>
		protected RField r_skill1;
		public virtual RField Rskill1
		{
			get
			{
				if(r_skill1 == null)
				{
					r_skill1 = new(this, "skill1");
					r_skill1.SetBelong(this.instance);
				}
				return r_skill1;
			}
		}

		/// <summary>
		/// System.Int32 skill2
		/// </summary>
		protected RField r_skill2;
		public virtual RField Rskill2
		{
			get
			{
				if(r_skill2 == null)
				{
					r_skill2 = new(this, "skill2");
					r_skill2.SetBelong(this.instance);
				}
				return r_skill2;
			}
		}

		/// <summary>
		/// System.Int32 skill3
		/// </summary>
		protected RField r_skill3;
		public virtual RField Rskill3
		{
			get
			{
				if(r_skill3 == null)
				{
					r_skill3 = new(this, "skill3");
					r_skill3.SetBelong(this.instance);
				}
				return r_skill3;
			}
		}

		/// <summary>
		/// System.Int32 skill4
		/// </summary>
		protected RField r_skill4;
		public virtual RField Rskill4
		{
			get
			{
				if(r_skill4 == null)
				{
					r_skill4 = new(this, "skill4");
					r_skill4.SetBelong(this.instance);
				}
				return r_skill4;
			}
		}

		/// <summary>
		/// System.Int32 skill5
		/// </summary>
		protected RField r_skill5;
		public virtual RField Rskill5
		{
			get
			{
				if(r_skill5 == null)
				{
					r_skill5 = new(this, "skill5");
					r_skill5.SetBelong(this.instance);
				}
				return r_skill5;
			}
		}

		/// <summary>
		/// System.Int32 skill6
		/// </summary>
		protected RField r_skill6;
		public virtual RField Rskill6
		{
			get
			{
				if(r_skill6 == null)
				{
					r_skill6 = new(this, "skill6");
					r_skill6.SetBelong(this.instance);
				}
				return r_skill6;
			}
		}

		/// <summary>
		/// System.Int32 skill7
		/// </summary>
		protected RField r_skill7;
		public virtual RField Rskill7
		{
			get
			{
				if(r_skill7 == null)
				{
					r_skill7 = new(this, "skill7");
					r_skill7.SetBelong(this.instance);
				}
				return r_skill7;
			}
		}

		/// <summary>
		/// System.Int32 skill8
		/// </summary>
		protected RField r_skill8;
		public virtual RField Rskill8
		{
			get
			{
				if(r_skill8 == null)
				{
					r_skill8 = new(this, "skill8");
					r_skill8.SetBelong(this.instance);
				}
				return r_skill8;
			}
		}

		/// <summary>
		/// System.Int32 skill9
		/// </summary>
		protected RField r_skill9;
		public virtual RField Rskill9
		{
			get
			{
				if(r_skill9 == null)
				{
					r_skill9 = new(this, "skill9");
					r_skill9.SetBelong(this.instance);
				}
				return r_skill9;
			}
		}

		/// <summary>
		/// System.Int32 skill10
		/// </summary>
		protected RField r_skill10;
		public virtual RField Rskill10
		{
			get
			{
				if(r_skill10 == null)
				{
					r_skill10 = new(this, "skill10");
					r_skill10.SetBelong(this.instance);
				}
				return r_skill10;
			}
		}

		/// <summary>
		/// System.Int32 skill11
		/// </summary>
		protected RField r_skill11;
		public virtual RField Rskill11
		{
			get
			{
				if(r_skill11 == null)
				{
					r_skill11 = new(this, "skill11");
					r_skill11.SetBelong(this.instance);
				}
				return r_skill11;
			}
		}

		/// <summary>
		/// System.Int32 skill12
		/// </summary>
		protected RField r_skill12;
		public virtual RField Rskill12
		{
			get
			{
				if(r_skill12 == null)
				{
					r_skill12 = new(this, "skill12");
					r_skill12.SetBelong(this.instance);
				}
				return r_skill12;
			}
		}

		/// <summary>
		/// System.Int32 skill13
		/// </summary>
		protected RField r_skill13;
		public virtual RField Rskill13
		{
			get
			{
				if(r_skill13 == null)
				{
					r_skill13 = new(this, "skill13");
					r_skill13.SetBelong(this.instance);
				}
				return r_skill13;
			}
		}

		/// <summary>
		/// System.Int32 skill14
		/// </summary>
		protected RField r_skill14;
		public virtual RField Rskill14
		{
			get
			{
				if(r_skill14 == null)
				{
					r_skill14 = new(this, "skill14");
					r_skill14.SetBelong(this.instance);
				}
				return r_skill14;
			}
		}

		/// <summary>
		/// System.Int32 skill15
		/// </summary>
		protected RField r_skill15;
		public virtual RField Rskill15
		{
			get
			{
				if(r_skill15 == null)
				{
					r_skill15 = new(this, "skill15");
					r_skill15.SetBelong(this.instance);
				}
				return r_skill15;
			}
		}

		/// <summary>
		/// System.Int32 skill16
		/// </summary>
		protected RField r_skill16;
		public virtual RField Rskill16
		{
			get
			{
				if(r_skill16 == null)
				{
					r_skill16 = new(this, "skill16");
					r_skill16.SetBelong(this.instance);
				}
				return r_skill16;
			}
		}

		/// <summary>
		/// System.Int32 mountCount
		/// </summary>
		protected RField r_mountCount;
		public virtual RField RmountCount
		{
			get
			{
				if(r_mountCount == null)
				{
					r_mountCount = new(this, "mountCount");
					r_mountCount.SetBelong(this.instance);
				}
				return r_mountCount;
			}
		}

		/// <summary>
		/// MountSeatInfo[] allSeatAnima
		/// </summary>
		protected RFieldArray<RMountSeatInfo> r_allSeatAnima;
		public virtual RFieldArray<RMountSeatInfo> RallSeatAnima
		{
			get
			{
				if(r_allSeatAnima == null)
				{
					r_allSeatAnima = new(this, "allSeatAnima");
					r_allSeatAnima.SetBelong(this.instance);
				}
				return r_allSeatAnima;
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


        public RMountPetConfig() : base("MountPetConfig")
        {
        }

        public RMountPetConfig(System.Object instance) : base("MountPetConfig")
		{
            SetInstance(instance);
		}

        public RMountPetConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMountPetConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
