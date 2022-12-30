using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TeamBattleBossConfig
	/// </summary>
    public partial class RTeamBattleBossConfig : RMember //
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
		/// System.Int32 careerID0
		/// </summary>
		protected RField r_careerID0;
		public virtual RField RcareerID0
		{
			get
			{
				if(r_careerID0 == null)
				{
					r_careerID0 = new(this, "careerID0");
					r_careerID0.SetBelong(this.instance);
				}
				return r_careerID0;
			}
		}

		/// <summary>
		/// System.Int32 careerID1
		/// </summary>
		protected RField r_careerID1;
		public virtual RField RcareerID1
		{
			get
			{
				if(r_careerID1 == null)
				{
					r_careerID1 = new(this, "careerID1");
					r_careerID1.SetBelong(this.instance);
				}
				return r_careerID1;
			}
		}

		/// <summary>
		/// System.Int32 careerID2
		/// </summary>
		protected RField r_careerID2;
		public virtual RField RcareerID2
		{
			get
			{
				if(r_careerID2 == null)
				{
					r_careerID2 = new(this, "careerID2");
					r_careerID2.SetBelong(this.instance);
				}
				return r_careerID2;
			}
		}

		/// <summary>
		/// System.Int32 careerID3
		/// </summary>
		protected RField r_careerID3;
		public virtual RField RcareerID3
		{
			get
			{
				if(r_careerID3 == null)
				{
					r_careerID3 = new(this, "careerID3");
					r_careerID3.SetBelong(this.instance);
				}
				return r_careerID3;
			}
		}

		/// <summary>
		/// System.Int32 careerID4
		/// </summary>
		protected RField r_careerID4;
		public virtual RField RcareerID4
		{
			get
			{
				if(r_careerID4 == null)
				{
					r_careerID4 = new(this, "careerID4");
					r_careerID4.SetBelong(this.instance);
				}
				return r_careerID4;
			}
		}

		/// <summary>
		/// System.Int32 careerID5
		/// </summary>
		protected RField r_careerID5;
		public virtual RField RcareerID5
		{
			get
			{
				if(r_careerID5 == null)
				{
					r_careerID5 = new(this, "careerID5");
					r_careerID5.SetBelong(this.instance);
				}
				return r_careerID5;
			}
		}

		/// <summary>
		/// System.Int32 careerID6
		/// </summary>
		protected RField r_careerID6;
		public virtual RField RcareerID6
		{
			get
			{
				if(r_careerID6 == null)
				{
					r_careerID6 = new(this, "careerID6");
					r_careerID6.SetBelong(this.instance);
				}
				return r_careerID6;
			}
		}

		/// <summary>
		/// System.Int32 careerID7
		/// </summary>
		protected RField r_careerID7;
		public virtual RField RcareerID7
		{
			get
			{
				if(r_careerID7 == null)
				{
					r_careerID7 = new(this, "careerID7");
					r_careerID7.SetBelong(this.instance);
				}
				return r_careerID7;
			}
		}

		/// <summary>
		/// System.Int32 careerID8
		/// </summary>
		protected RField r_careerID8;
		public virtual RField RcareerID8
		{
			get
			{
				if(r_careerID8 == null)
				{
					r_careerID8 = new(this, "careerID8");
					r_careerID8.SetBelong(this.instance);
				}
				return r_careerID8;
			}
		}

		/// <summary>
		/// System.String strReward
		/// </summary>
		protected RField r_strReward;
		public virtual RField RstrReward
		{
			get
			{
				if(r_strReward == null)
				{
					r_strReward = new(this, "strReward");
					r_strReward.SetBelong(this.instance);
				}
				return r_strReward;
			}
		}

		/// <summary>
		/// System.Int32 lv_0
		/// </summary>
		protected RField r_lv_0;
		public virtual RField Rlv_0
		{
			get
			{
				if(r_lv_0 == null)
				{
					r_lv_0 = new(this, "lv_0");
					r_lv_0.SetBelong(this.instance);
				}
				return r_lv_0;
			}
		}

		/// <summary>
		/// System.Int32 lv_1
		/// </summary>
		protected RField r_lv_1;
		public virtual RField Rlv_1
		{
			get
			{
				if(r_lv_1 == null)
				{
					r_lv_1 = new(this, "lv_1");
					r_lv_1.SetBelong(this.instance);
				}
				return r_lv_1;
			}
		}

		/// <summary>
		/// System.Int32 lv_2
		/// </summary>
		protected RField r_lv_2;
		public virtual RField Rlv_2
		{
			get
			{
				if(r_lv_2 == null)
				{
					r_lv_2 = new(this, "lv_2");
					r_lv_2.SetBelong(this.instance);
				}
				return r_lv_2;
			}
		}

		/// <summary>
		/// System.Int32 lv_3
		/// </summary>
		protected RField r_lv_3;
		public virtual RField Rlv_3
		{
			get
			{
				if(r_lv_3 == null)
				{
					r_lv_3 = new(this, "lv_3");
					r_lv_3.SetBelong(this.instance);
				}
				return r_lv_3;
			}
		}

		/// <summary>
		/// System.Int32 lv_4
		/// </summary>
		protected RField r_lv_4;
		public virtual RField Rlv_4
		{
			get
			{
				if(r_lv_4 == null)
				{
					r_lv_4 = new(this, "lv_4");
					r_lv_4.SetBelong(this.instance);
				}
				return r_lv_4;
			}
		}

		/// <summary>
		/// System.Int32 lv_5
		/// </summary>
		protected RField r_lv_5;
		public virtual RField Rlv_5
		{
			get
			{
				if(r_lv_5 == null)
				{
					r_lv_5 = new(this, "lv_5");
					r_lv_5.SetBelong(this.instance);
				}
				return r_lv_5;
			}
		}

		/// <summary>
		/// System.Int32 lv_6
		/// </summary>
		protected RField r_lv_6;
		public virtual RField Rlv_6
		{
			get
			{
				if(r_lv_6 == null)
				{
					r_lv_6 = new(this, "lv_6");
					r_lv_6.SetBelong(this.instance);
				}
				return r_lv_6;
			}
		}

		/// <summary>
		/// System.Int32 lv_7
		/// </summary>
		protected RField r_lv_7;
		public virtual RField Rlv_7
		{
			get
			{
				if(r_lv_7 == null)
				{
					r_lv_7 = new(this, "lv_7");
					r_lv_7.SetBelong(this.instance);
				}
				return r_lv_7;
			}
		}

		/// <summary>
		/// System.Int32 lv_8
		/// </summary>
		protected RField r_lv_8;
		public virtual RField Rlv_8
		{
			get
			{
				if(r_lv_8 == null)
				{
					r_lv_8 = new(this, "lv_8");
					r_lv_8.SetBelong(this.instance);
				}
				return r_lv_8;
			}
		}

		/// <summary>
		/// System.String skill1
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
		/// System.String tips_1
		/// </summary>
		protected RField r_tips_1;
		public virtual RField Rtips_1
		{
			get
			{
				if(r_tips_1 == null)
				{
					r_tips_1 = new(this, "tips_1");
					r_tips_1.SetBelong(this.instance);
				}
				return r_tips_1;
			}
		}

		/// <summary>
		/// System.String tips_2
		/// </summary>
		protected RField r_tips_2;
		public virtual RField Rtips_2
		{
			get
			{
				if(r_tips_2 == null)
				{
					r_tips_2 = new(this, "tips_2");
					r_tips_2.SetBelong(this.instance);
				}
				return r_tips_2;
			}
		}

		/// <summary>
		/// System.String tips_3
		/// </summary>
		protected RField r_tips_3;
		public virtual RField Rtips_3
		{
			get
			{
				if(r_tips_3 == null)
				{
					r_tips_3 = new(this, "tips_3");
					r_tips_3.SetBelong(this.instance);
				}
				return r_tips_3;
			}
		}

		/// <summary>
		/// System.String tips_4
		/// </summary>
		protected RField r_tips_4;
		public virtual RField Rtips_4
		{
			get
			{
				if(r_tips_4 == null)
				{
					r_tips_4 = new(this, "tips_4");
					r_tips_4.SetBelong(this.instance);
				}
				return r_tips_4;
			}
		}

		/// <summary>
		/// System.String tips_5
		/// </summary>
		protected RField r_tips_5;
		public virtual RField Rtips_5
		{
			get
			{
				if(r_tips_5 == null)
				{
					r_tips_5 = new(this, "tips_5");
					r_tips_5.SetBelong(this.instance);
				}
				return r_tips_5;
			}
		}

		/// <summary>
		/// System.String tips_6
		/// </summary>
		protected RField r_tips_6;
		public virtual RField Rtips_6
		{
			get
			{
				if(r_tips_6 == null)
				{
					r_tips_6 = new(this, "tips_6");
					r_tips_6.SetBelong(this.instance);
				}
				return r_tips_6;
			}
		}

		/// <summary>
		/// System.String tips_7
		/// </summary>
		protected RField r_tips_7;
		public virtual RField Rtips_7
		{
			get
			{
				if(r_tips_7 == null)
				{
					r_tips_7 = new(this, "tips_7");
					r_tips_7.SetBelong(this.instance);
				}
				return r_tips_7;
			}
		}

		/// <summary>
		/// System.String tips_8
		/// </summary>
		protected RField r_tips_8;
		public virtual RField Rtips_8
		{
			get
			{
				if(r_tips_8 == null)
				{
					r_tips_8 = new(this, "tips_8");
					r_tips_8.SetBelong(this.instance);
				}
				return r_tips_8;
			}
		}

		/// <summary>
		/// System.String tips_9
		/// </summary>
		protected RField r_tips_9;
		public virtual RField Rtips_9
		{
			get
			{
				if(r_tips_9 == null)
				{
					r_tips_9 = new(this, "tips_9");
					r_tips_9.SetBelong(this.instance);
				}
				return r_tips_9;
			}
		}

		/// <summary>
		/// System.String first_drop
		/// </summary>
		protected RField r_first_drop;
		public virtual RField Rfirst_drop
		{
			get
			{
				if(r_first_drop == null)
				{
					r_first_drop = new(this, "first_drop");
					r_first_drop.SetBelong(this.instance);
				}
				return r_first_drop;
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


        public RTeamBattleBossConfig() : base("TeamBattleBossConfig")
        {
        }

        public RTeamBattleBossConfig(System.Object instance) : base("TeamBattleBossConfig")
		{
            SetInstance(instance);
		}

        public RTeamBattleBossConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTeamBattleBossConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
