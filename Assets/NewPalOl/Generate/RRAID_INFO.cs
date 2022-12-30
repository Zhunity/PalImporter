using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RAID_INFO
	/// </summary>
    public partial class RRAID_INFO : RMember //
    {

		/// <summary>
		/// System.String id
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
		/// System.String idArea
		/// </summary>
		protected RField r_idArea;
		public virtual RField RidArea
		{
			get
			{
				if(r_idArea == null)
				{
					r_idArea = new(this, "idArea");
					r_idArea.SetBelong(this.instance);
				}
				return r_idArea;
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
		/// System.String belong_to_map
		/// </summary>
		protected RField r_belong_to_map;
		public virtual RField Rbelong_to_map
		{
			get
			{
				if(r_belong_to_map == null)
				{
					r_belong_to_map = new(this, "belong_to_map");
					r_belong_to_map.SetBelong(this.instance);
				}
				return r_belong_to_map;
			}
		}

		/// <summary>
		/// System.String reward_gold
		/// </summary>
		protected RField r_reward_gold;
		public virtual RField Rreward_gold
		{
			get
			{
				if(r_reward_gold == null)
				{
					r_reward_gold = new(this, "reward_gold");
					r_reward_gold.SetBelong(this.instance);
				}
				return r_reward_gold;
			}
		}

		/// <summary>
		/// System.String reward_exp
		/// </summary>
		protected RField r_reward_exp;
		public virtual RField Rreward_exp
		{
			get
			{
				if(r_reward_exp == null)
				{
					r_reward_exp = new(this, "reward_exp");
					r_reward_exp.SetBelong(this.instance);
				}
				return r_reward_exp;
			}
		}

		/// <summary>
		/// System.String reward_lingli
		/// </summary>
		protected RField r_reward_lingli;
		public virtual RField Rreward_lingli
		{
			get
			{
				if(r_reward_lingli == null)
				{
					r_reward_lingli = new(this, "reward_lingli");
					r_reward_lingli.SetBelong(this.instance);
				}
				return r_reward_lingli;
			}
		}

		/// <summary>
		/// System.Int32 type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Int32 energy
		/// </summary>
		protected RField r_energy;
		public virtual RField Renergy
		{
			get
			{
				if(r_energy == null)
				{
					r_energy = new(this, "energy");
					r_energy.SetBelong(this.instance);
				}
				return r_energy;
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
		/// UnityEngine.Vector2 namepos
		/// </summary>
		protected RUnityEngine.RVector2 r_namepos;
		public virtual RUnityEngine.RVector2 Rnamepos
		{
			get
			{
				if(r_namepos == null)
				{
					r_namepos = new(this, "namepos");
					r_namepos.SetBelong(this.instance);
				}
				return r_namepos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 iconpos
		/// </summary>
		protected RUnityEngine.RVector3 r_iconpos;
		public virtual RUnityEngine.RVector3 Riconpos
		{
			get
			{
				if(r_iconpos == null)
				{
					r_iconpos = new(this, "iconpos");
					r_iconpos.SetBelong(this.instance);
				}
				return r_iconpos;
			}
		}

		/// <summary>
		/// System.Int32 raid_time
		/// </summary>
		protected RField r_raid_time;
		public virtual RField Rraid_time
		{
			get
			{
				if(r_raid_time == null)
				{
					r_raid_time = new(this, "raid_time");
					r_raid_time.SetBelong(this.instance);
				}
				return r_raid_time;
			}
		}

		/// <summary>
		/// System.String itemids
		/// </summary>
		protected RField r_itemids;
		public virtual RField Ritemids
		{
			get
			{
				if(r_itemids == null)
				{
					r_itemids = new(this, "itemids");
					r_itemids.SetBelong(this.instance);
				}
				return r_itemids;
			}
		}

		/// <summary>
		/// System.Int32 life_time
		/// </summary>
		protected RField r_life_time;
		public virtual RField Rlife_time
		{
			get
			{
				if(r_life_time == null)
				{
					r_life_time = new(this, "life_time");
					r_life_time.SetBelong(this.instance);
				}
				return r_life_time;
			}
		}

		/// <summary>
		/// System.Int32 floor
		/// </summary>
		protected RField r_floor;
		public virtual RField Rfloor
		{
			get
			{
				if(r_floor == null)
				{
					r_floor = new(this, "floor");
					r_floor.SetBelong(this.instance);
				}
				return r_floor;
			}
		}

		/// <summary>
		/// System.Boolean bValid
		/// </summary>
		protected RField r_bValid;
		public virtual RField RbValid
		{
			get
			{
				if(r_bValid == null)
				{
					r_bValid = new(this, "bValid");
					r_bValid.SetBelong(this.instance);
				}
				return r_bValid;
			}
		}

		/// <summary>
		/// System.Int32 effectval
		/// </summary>
		protected RField r_effectval;
		public virtual RField Reffectval
		{
			get
			{
				if(r_effectval == null)
				{
					r_effectval = new(this, "effectval");
					r_effectval.SetBelong(this.instance);
				}
				return r_effectval;
			}
		}

		/// <summary>
		/// System.Int32 star
		/// </summary>
		protected RField r_star;
		public virtual RField Rstar
		{
			get
			{
				if(r_star == null)
				{
					r_star = new(this, "star");
					r_star.SetBelong(this.instance);
				}
				return r_star;
			}
		}

		/// <summary>
		/// System.Boolean bSweep
		/// </summary>
		protected RField r_bSweep;
		public virtual RField RbSweep
		{
			get
			{
				if(r_bSweep == null)
				{
					r_bSweep = new(this, "bSweep");
					r_bSweep.SetBelong(this.instance);
				}
				return r_bSweep;
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


        public RRAID_INFO() : base("RAID_INFO")
        {
        }

        public RRAID_INFO(System.Object instance) : base("RAID_INFO")
		{
            SetInstance(instance);
		}

        public RRAID_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRAID_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
