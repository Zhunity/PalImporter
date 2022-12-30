using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TaskBuffConfig
	/// </summary>
    public partial class RTaskBuffConfig : RMember //
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
		/// System.Int32 task_lv
		/// </summary>
		protected RField r_task_lv;
		public virtual RField Rtask_lv
		{
			get
			{
				if(r_task_lv == null)
				{
					r_task_lv = new(this, "task_lv");
					r_task_lv.SetBelong(this.instance);
				}
				return r_task_lv;
			}
		}

		/// <summary>
		/// System.Int32 task_lv_score
		/// </summary>
		protected RField r_task_lv_score;
		public virtual RField Rtask_lv_score
		{
			get
			{
				if(r_task_lv_score == null)
				{
					r_task_lv_score = new(this, "task_lv_score");
					r_task_lv_score.SetBelong(this.instance);
				}
				return r_task_lv_score;
			}
		}

		/// <summary>
		/// System.Int32 tasktype
		/// </summary>
		protected RField r_tasktype;
		public virtual RField Rtasktype
		{
			get
			{
				if(r_tasktype == null)
				{
					r_tasktype = new(this, "tasktype");
					r_tasktype.SetBelong(this.instance);
				}
				return r_tasktype;
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
		/// System.Int32 block_add
		/// </summary>
		protected RField r_block_add;
		public virtual RField Rblock_add
		{
			get
			{
				if(r_block_add == null)
				{
					r_block_add = new(this, "block_add");
					r_block_add.SetBelong(this.instance);
				}
				return r_block_add;
			}
		}

		/// <summary>
		/// System.Int32 critical_add
		/// </summary>
		protected RField r_critical_add;
		public virtual RField Rcritical_add
		{
			get
			{
				if(r_critical_add == null)
				{
					r_critical_add = new(this, "critical_add");
					r_critical_add.SetBelong(this.instance);
				}
				return r_critical_add;
			}
		}

		/// <summary>
		/// System.Int32 dodge_add
		/// </summary>
		protected RField r_dodge_add;
		public virtual RField Rdodge_add
		{
			get
			{
				if(r_dodge_add == null)
				{
					r_dodge_add = new(this, "dodge_add");
					r_dodge_add.SetBelong(this.instance);
				}
				return r_dodge_add;
			}
		}

		/// <summary>
		/// System.Int32 hit_add
		/// </summary>
		protected RField r_hit_add;
		public virtual RField Rhit_add
		{
			get
			{
				if(r_hit_add == null)
				{
					r_hit_add = new(this, "hit_add");
					r_hit_add.SetBelong(this.instance);
				}
				return r_hit_add;
			}
		}

		/// <summary>
		/// System.Int32 toughness_add
		/// </summary>
		protected RField r_toughness_add;
		public virtual RField Rtoughness_add
		{
			get
			{
				if(r_toughness_add == null)
				{
					r_toughness_add = new(this, "toughness_add");
					r_toughness_add.SetBelong(this.instance);
				}
				return r_toughness_add;
			}
		}

		/// <summary>
		/// System.Int32 wreck_add
		/// </summary>
		protected RField r_wreck_add;
		public virtual RField Rwreck_add
		{
			get
			{
				if(r_wreck_add == null)
				{
					r_wreck_add = new(this, "wreck_add");
					r_wreck_add.SetBelong(this.instance);
				}
				return r_wreck_add;
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


        public RTaskBuffConfig() : base("TaskBuffConfig")
        {
        }

        public RTaskBuffConfig(System.Object instance) : base("TaskBuffConfig")
		{
            SetInstance(instance);
		}

        public RTaskBuffConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTaskBuffConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
