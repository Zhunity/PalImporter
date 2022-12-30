using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CLIENT_TASK_INFO
	/// </summary>
    public partial class RCLIENT_TASK_INFO : RMember //
    {

		/// <summary>
		/// System.String taskId
		/// </summary>
		protected RField r_taskId;
		public virtual RField RtaskId
		{
			get
			{
				if(r_taskId == null)
				{
					r_taskId = new(this, "taskId");
					r_taskId.SetBelong(this.instance);
				}
				return r_taskId;
			}
		}

		/// <summary>
		/// System.Int32 category
		/// </summary>
		protected RField r_category;
		public virtual RField Rcategory
		{
			get
			{
				if(r_category == null)
				{
					r_category = new(this, "category");
					r_category.SetBelong(this.instance);
				}
				return r_category;
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
		/// System.String desc
		/// </summary>
		protected RField r_desc;
		public virtual RField Rdesc
		{
			get
			{
				if(r_desc == null)
				{
					r_desc = new(this, "desc");
					r_desc.SetBelong(this.instance);
				}
				return r_desc;
			}
		}

		/// <summary>
		/// System.String acceptneed
		/// </summary>
		protected RField r_acceptneed;
		public virtual RField Racceptneed
		{
			get
			{
				if(r_acceptneed == null)
				{
					r_acceptneed = new(this, "acceptneed");
					r_acceptneed.SetBelong(this.instance);
				}
				return r_acceptneed;
			}
		}

		/// <summary>
		/// System.String fromdesc
		/// </summary>
		protected RField r_fromdesc;
		public virtual RField Rfromdesc
		{
			get
			{
				if(r_fromdesc == null)
				{
					r_fromdesc = new(this, "fromdesc");
					r_fromdesc.SetBelong(this.instance);
				}
				return r_fromdesc;
			}
		}

		/// <summary>
		/// System.String summary
		/// </summary>
		protected RField r_summary;
		public virtual RField Rsummary
		{
			get
			{
				if(r_summary == null)
				{
					r_summary = new(this, "summary");
					r_summary.SetBelong(this.instance);
				}
				return r_summary;
			}
		}

		/// <summary>
		/// System.String submit
		/// </summary>
		protected RField r_submit;
		public virtual RField Rsubmit
		{
			get
			{
				if(r_submit == null)
				{
					r_submit = new(this, "submit");
					r_submit.SetBelong(this.instance);
				}
				return r_submit;
			}
		}

		/// <summary>
		/// System.String fail_desc
		/// </summary>
		protected RField r_fail_desc;
		public virtual RField Rfail_desc
		{
			get
			{
				if(r_fail_desc == null)
				{
					r_fail_desc = new(this, "fail_desc");
					r_fail_desc.SetBelong(this.instance);
				}
				return r_fail_desc;
			}
		}

		/// <summary>
		/// System.String fromNpcId
		/// </summary>
		protected RField r_fromNpcId;
		public virtual RField RfromNpcId
		{
			get
			{
				if(r_fromNpcId == null)
				{
					r_fromNpcId = new(this, "fromNpcId");
					r_fromNpcId.SetBelong(this.instance);
				}
				return r_fromNpcId;
			}
		}

		/// <summary>
		/// System.String toID
		/// </summary>
		protected RField r_toID;
		public virtual RField RtoID
		{
			get
			{
				if(r_toID == null)
				{
					r_toID = new(this, "toID");
					r_toID.SetBelong(this.instance);
				}
				return r_toID;
			}
		}

		/// <summary>
		/// System.String prevTaskId
		/// </summary>
		protected RField r_prevTaskId;
		public virtual RField RprevTaskId
		{
			get
			{
				if(r_prevTaskId == null)
				{
					r_prevTaskId = new(this, "prevTaskId");
					r_prevTaskId.SetBelong(this.instance);
				}
				return r_prevTaskId;
			}
		}

		/// <summary>
		/// System.String prevTaskId_noneed
		/// </summary>
		protected RField r_prevTaskId_noneed;
		public virtual RField RprevTaskId_noneed
		{
			get
			{
				if(r_prevTaskId_noneed == null)
				{
					r_prevTaskId_noneed = new(this, "prevTaskId_noneed");
					r_prevTaskId_noneed.SetBelong(this.instance);
				}
				return r_prevTaskId_noneed;
			}
		}

		/// <summary>
		/// System.Boolean bShowInAccept
		/// </summary>
		protected RField r_bShowInAccept;
		public virtual RField RbShowInAccept
		{
			get
			{
				if(r_bShowInAccept == null)
				{
					r_bShowInAccept = new(this, "bShowInAccept");
					r_bShowInAccept.SetBelong(this.instance);
				}
				return r_bShowInAccept;
			}
		}

		/// <summary>
		/// System.Boolean canDrop
		/// </summary>
		protected RField r_canDrop;
		public virtual RField RcanDrop
		{
			get
			{
				if(r_canDrop == null)
				{
					r_canDrop = new(this, "canDrop");
					r_canDrop.SetBelong(this.instance);
				}
				return r_canDrop;
			}
		}

		/// <summary>
		/// System.Boolean bShowEffect
		/// </summary>
		protected RField r_bShowEffect;
		public virtual RField RbShowEffect
		{
			get
			{
				if(r_bShowEffect == null)
				{
					r_bShowEffect = new(this, "bShowEffect");
					r_bShowEffect.SetBelong(this.instance);
				}
				return r_bShowEffect;
			}
		}

		/// <summary>
		/// System.Boolean hascondition
		/// </summary>
		protected RField r_hascondition;
		public virtual RField Rhascondition
		{
			get
			{
				if(r_hascondition == null)
				{
					r_hascondition = new(this, "hascondition");
					r_hascondition.SetBelong(this.instance);
				}
				return r_hascondition;
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
		/// System.Int32 tribe
		/// </summary>
		protected RField r_tribe;
		public virtual RField Rtribe
		{
			get
			{
				if(r_tribe == null)
				{
					r_tribe = new(this, "tribe");
					r_tribe.SetBelong(this.instance);
				}
				return r_tribe;
			}
		}

		/// <summary>
		/// System.Int32 reward_goldex
		/// </summary>
		protected RField r_reward_goldex;
		public virtual RField Rreward_goldex
		{
			get
			{
				if(r_reward_goldex == null)
				{
					r_reward_goldex = new(this, "reward_goldex");
					r_reward_goldex.SetBelong(this.instance);
				}
				return r_reward_goldex;
			}
		}

		/// <summary>
		/// System.Int32 reward_gold
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
		/// System.Int32 reward_exp
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
		/// System.Int32 reward_lingli
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
		/// System.String reward_item
		/// </summary>
		protected RField r_reward_item;
		public virtual RField Rreward_item
		{
			get
			{
				if(r_reward_item == null)
				{
					r_reward_item = new(this, "reward_item");
					r_reward_item.SetBelong(this.instance);
				}
				return r_reward_item;
			}
		}

		/// <summary>
		/// System.Int32 reward_shengwang
		/// </summary>
		protected RField r_reward_shengwang;
		public virtual RField Rreward_shengwang
		{
			get
			{
				if(r_reward_shengwang == null)
				{
					r_reward_shengwang = new(this, "reward_shengwang");
					r_reward_shengwang.SetBelong(this.instance);
				}
				return r_reward_shengwang;
			}
		}

		/// <summary>
		/// System.Int32 flyid
		/// </summary>
		protected RField r_flyid;
		public virtual RField Rflyid
		{
			get
			{
				if(r_flyid == null)
				{
					r_flyid = new(this, "flyid");
					r_flyid.SetBelong(this.instance);
				}
				return r_flyid;
			}
		}

		/// <summary>
		/// System.Boolean submit_effect
		/// </summary>
		protected RField r_submit_effect;
		public virtual RField Rsubmit_effect
		{
			get
			{
				if(r_submit_effect == null)
				{
					r_submit_effect = new(this, "submit_effect");
					r_submit_effect.SetBelong(this.instance);
				}
				return r_submit_effect;
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


        public RCLIENT_TASK_INFO() : base("CLIENT_TASK_INFO")
        {
        }

        public RCLIENT_TASK_INFO(System.Object instance) : base("CLIENT_TASK_INFO")
		{
            SetInstance(instance);
		}

        public RCLIENT_TASK_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCLIENT_TASK_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
