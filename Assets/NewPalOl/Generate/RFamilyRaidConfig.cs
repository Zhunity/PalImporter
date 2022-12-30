using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FamilyRaidConfig
	/// </summary>
    public partial class RFamilyRaidConfig : RMember //
    {

		/// <summary>
		/// System.Int32 awardid_kill
		/// </summary>
		protected RField r_awardid_kill;
		public virtual RField Rawardid_kill
		{
			get
			{
				if(r_awardid_kill == null)
				{
					r_awardid_kill = new(this, "awardid_kill");
					r_awardid_kill.SetBelong(this.instance);
				}
				return r_awardid_kill;
			}
		}

		/// <summary>
		/// System.String awardid_rank
		/// </summary>
		protected RField r_awardid_rank;
		public virtual RField Rawardid_rank
		{
			get
			{
				if(r_awardid_rank == null)
				{
					r_awardid_rank = new(this, "awardid_rank");
					r_awardid_rank.SetBelong(this.instance);
				}
				return r_awardid_rank;
			}
		}

		/// <summary>
		/// System.Int32 coin
		/// </summary>
		protected RField r_coin;
		public virtual RField Rcoin
		{
			get
			{
				if(r_coin == null)
				{
					r_coin = new(this, "coin");
					r_coin.SetBelong(this.instance);
				}
				return r_coin;
			}
		}

		/// <summary>
		/// System.Int32 guildlevel
		/// </summary>
		protected RField r_guildlevel;
		public virtual RField Rguildlevel
		{
			get
			{
				if(r_guildlevel == null)
				{
					r_guildlevel = new(this, "guildlevel");
					r_guildlevel.SetBelong(this.instance);
				}
				return r_guildlevel;
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
		/// System.Int32 model_1
		/// </summary>
		protected RField r_model_1;
		public virtual RField Rmodel_1
		{
			get
			{
				if(r_model_1 == null)
				{
					r_model_1 = new(this, "model_1");
					r_model_1.SetBelong(this.instance);
				}
				return r_model_1;
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
		/// System.Int32 monsterteam
		/// </summary>
		protected RField r_monsterteam;
		public virtual RField Rmonsterteam
		{
			get
			{
				if(r_monsterteam == null)
				{
					r_monsterteam = new(this, "monsterteam");
					r_monsterteam.SetBelong(this.instance);
				}
				return r_monsterteam;
			}
		}

		/// <summary>
		/// System.String bossname
		/// </summary>
		protected RField r_bossname;
		public virtual RField Rbossname
		{
			get
			{
				if(r_bossname == null)
				{
					r_bossname = new(this, "bossname");
					r_bossname.SetBelong(this.instance);
				}
				return r_bossname;
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


        public RFamilyRaidConfig() : base("FamilyRaidConfig")
        {
        }

        public RFamilyRaidConfig(System.Object instance) : base("FamilyRaidConfig")
		{
            SetInstance(instance);
		}

        public RFamilyRaidConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFamilyRaidConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
