using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FamilyConfig
	/// </summary>
    public partial class RFamilyConfig : RMember //
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
		/// System.Int32 alarmNum
		/// </summary>
		protected RField r_alarmNum;
		public virtual RField RalarmNum
		{
			get
			{
				if(r_alarmNum == null)
				{
					r_alarmNum = new(this, "alarmNum");
					r_alarmNum.SetBelong(this.instance);
				}
				return r_alarmNum;
			}
		}

		/// <summary>
		/// System.Int32 breakMoney
		/// </summary>
		protected RField r_breakMoney;
		public virtual RField RbreakMoney
		{
			get
			{
				if(r_breakMoney == null)
				{
					r_breakMoney = new(this, "breakMoney");
					r_breakMoney.SetBelong(this.instance);
				}
				return r_breakMoney;
			}
		}

		/// <summary>
		/// System.Int32 persent
		/// </summary>
		protected RField r_persent;
		public virtual RField Rpersent
		{
			get
			{
				if(r_persent == null)
				{
					r_persent = new(this, "persent");
					r_persent.SetBelong(this.instance);
				}
				return r_persent;
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
		/// System.Int32 lvUpMoney
		/// </summary>
		protected RField r_lvUpMoney;
		public virtual RField RlvUpMoney
		{
			get
			{
				if(r_lvUpMoney == null)
				{
					r_lvUpMoney = new(this, "lvUpMoney");
					r_lvUpMoney.SetBelong(this.instance);
				}
				return r_lvUpMoney;
			}
		}

		/// <summary>
		/// System.Int32 maxCount
		/// </summary>
		protected RField r_maxCount;
		public virtual RField RmaxCount
		{
			get
			{
				if(r_maxCount == null)
				{
					r_maxCount = new(this, "maxCount");
					r_maxCount.SetBelong(this.instance);
				}
				return r_maxCount;
			}
		}

		/// <summary>
		/// System.Int32 rebackMoney
		/// </summary>
		protected RField r_rebackMoney;
		public virtual RField RrebackMoney
		{
			get
			{
				if(r_rebackMoney == null)
				{
					r_rebackMoney = new(this, "rebackMoney");
					r_rebackMoney.SetBelong(this.instance);
				}
				return r_rebackMoney;
			}
		}

		/// <summary>
		/// System.Int32 awardPercent
		/// </summary>
		protected RField r_awardPercent;
		public virtual RField RawardPercent
		{
			get
			{
				if(r_awardPercent == null)
				{
					r_awardPercent = new(this, "awardPercent");
					r_awardPercent.SetBelong(this.instance);
				}
				return r_awardPercent;
			}
		}

		/// <summary>
		/// System.Int32 skill_max
		/// </summary>
		protected RField r_skill_max;
		public virtual RField Rskill_max
		{
			get
			{
				if(r_skill_max == null)
				{
					r_skill_max = new(this, "skill_max");
					r_skill_max.SetBelong(this.instance);
				}
				return r_skill_max;
			}
		}

		/// <summary>
		/// System.Int32 open_fire
		/// </summary>
		protected RField r_open_fire;
		public virtual RField Ropen_fire
		{
			get
			{
				if(r_open_fire == null)
				{
					r_open_fire = new(this, "open_fire");
					r_open_fire.SetBelong(this.instance);
				}
				return r_open_fire;
			}
		}

		/// <summary>
		/// System.Int32 book_fire
		/// </summary>
		protected RField r_book_fire;
		public virtual RField Rbook_fire
		{
			get
			{
				if(r_book_fire == null)
				{
					r_book_fire = new(this, "book_fire");
					r_book_fire.SetBelong(this.instance);
				}
				return r_book_fire;
			}
		}

		/// <summary>
		/// System.Int32 open_boss
		/// </summary>
		protected RField r_open_boss;
		public virtual RField Ropen_boss
		{
			get
			{
				if(r_open_boss == null)
				{
					r_open_boss = new(this, "open_boss");
					r_open_boss.SetBelong(this.instance);
				}
				return r_open_boss;
			}
		}

		/// <summary>
		/// System.Int32 book_boss
		/// </summary>
		protected RField r_book_boss;
		public virtual RField Rbook_boss
		{
			get
			{
				if(r_book_boss == null)
				{
					r_book_boss = new(this, "book_boss");
					r_book_boss.SetBelong(this.instance);
				}
				return r_book_boss;
			}
		}

		/// <summary>
		/// System.Int32 lottery_cost
		/// </summary>
		protected RField r_lottery_cost;
		public virtual RField Rlottery_cost
		{
			get
			{
				if(r_lottery_cost == null)
				{
					r_lottery_cost = new(this, "lottery_cost");
					r_lottery_cost.SetBelong(this.instance);
				}
				return r_lottery_cost;
			}
		}

		/// <summary>
		/// System.Int32 lottery_count
		/// </summary>
		protected RField r_lottery_count;
		public virtual RField Rlottery_count
		{
			get
			{
				if(r_lottery_count == null)
				{
					r_lottery_count = new(this, "lottery_count");
					r_lottery_count.SetBelong(this.instance);
				}
				return r_lottery_count;
			}
		}

		/// <summary>
		/// System.Int32 lottery_item1
		/// </summary>
		protected RField r_lottery_item1;
		public virtual RField Rlottery_item1
		{
			get
			{
				if(r_lottery_item1 == null)
				{
					r_lottery_item1 = new(this, "lottery_item1");
					r_lottery_item1.SetBelong(this.instance);
				}
				return r_lottery_item1;
			}
		}

		/// <summary>
		/// System.Int32 lottery_item2
		/// </summary>
		protected RField r_lottery_item2;
		public virtual RField Rlottery_item2
		{
			get
			{
				if(r_lottery_item2 == null)
				{
					r_lottery_item2 = new(this, "lottery_item2");
					r_lottery_item2.SetBelong(this.instance);
				}
				return r_lottery_item2;
			}
		}

		/// <summary>
		/// System.Int32 lottery_item3
		/// </summary>
		protected RField r_lottery_item3;
		public virtual RField Rlottery_item3
		{
			get
			{
				if(r_lottery_item3 == null)
				{
					r_lottery_item3 = new(this, "lottery_item3");
					r_lottery_item3.SetBelong(this.instance);
				}
				return r_lottery_item3;
			}
		}

		/// <summary>
		/// System.Int32 lottery_item4
		/// </summary>
		protected RField r_lottery_item4;
		public virtual RField Rlottery_item4
		{
			get
			{
				if(r_lottery_item4 == null)
				{
					r_lottery_item4 = new(this, "lottery_item4");
					r_lottery_item4.SetBelong(this.instance);
				}
				return r_lottery_item4;
			}
		}

		/// <summary>
		/// System.Int32 lottery_item5
		/// </summary>
		protected RField r_lottery_item5;
		public virtual RField Rlottery_item5
		{
			get
			{
				if(r_lottery_item5 == null)
				{
					r_lottery_item5 = new(this, "lottery_item5");
					r_lottery_item5.SetBelong(this.instance);
				}
				return r_lottery_item5;
			}
		}

		/// <summary>
		/// System.Int32 guildwarnum
		/// </summary>
		protected RField r_guildwarnum;
		public virtual RField Rguildwarnum
		{
			get
			{
				if(r_guildwarnum == null)
				{
					r_guildwarnum = new(this, "guildwarnum");
					r_guildwarnum.SetBelong(this.instance);
				}
				return r_guildwarnum;
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


        public RFamilyConfig() : base("FamilyConfig")
        {
        }

        public RFamilyConfig(System.Object instance) : base("FamilyConfig")
		{
            SetInstance(instance);
		}

        public RFamilyConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFamilyConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
