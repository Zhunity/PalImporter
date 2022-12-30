using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PRACTICE_TASK_INFO
	/// </summary>
    public partial class RPRACTICE_TASK_INFO : RMember //
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
		/// System.String itemid
		/// </summary>
		protected RField r_itemid;
		public virtual RField Ritemid
		{
			get
			{
				if(r_itemid == null)
				{
					r_itemid = new(this, "itemid");
					r_itemid.SetBelong(this.instance);
				}
				return r_itemid;
			}
		}

		/// <summary>
		/// System.String rewardid
		/// </summary>
		protected RField r_rewardid;
		public virtual RField Rrewardid
		{
			get
			{
				if(r_rewardid == null)
				{
					r_rewardid = new(this, "rewardid");
					r_rewardid.SetBelong(this.instance);
				}
				return r_rewardid;
			}
		}

		/// <summary>
		/// System.Int32 rewardnum
		/// </summary>
		protected RField r_rewardnum;
		public virtual RField Rrewardnum
		{
			get
			{
				if(r_rewardnum == null)
				{
					r_rewardnum = new(this, "rewardnum");
					r_rewardnum.SetBelong(this.instance);
				}
				return r_rewardnum;
			}
		}

		/// <summary>
		/// System.Int32 cost
		/// </summary>
		protected RField r_cost;
		public virtual RField Rcost
		{
			get
			{
				if(r_cost == null)
				{
					r_cost = new(this, "cost");
					r_cost.SetBelong(this.instance);
				}
				return r_cost;
			}
		}

		/// <summary>
		/// System.String taskid
		/// </summary>
		protected RField r_taskid;
		public virtual RField Rtaskid
		{
			get
			{
				if(r_taskid == null)
				{
					r_taskid = new(this, "taskid");
					r_taskid.SetBelong(this.instance);
				}
				return r_taskid;
			}
		}

		/// <summary>
		/// System.String taskdes
		/// </summary>
		protected RField r_taskdes;
		public virtual RField Rtaskdes
		{
			get
			{
				if(r_taskdes == null)
				{
					r_taskdes = new(this, "taskdes");
					r_taskdes.SetBelong(this.instance);
				}
				return r_taskdes;
			}
		}

		/// <summary>
		/// System.Int32 rewardtype
		/// </summary>
		protected RField r_rewardtype;
		public virtual RField Rrewardtype
		{
			get
			{
				if(r_rewardtype == null)
				{
					r_rewardtype = new(this, "rewardtype");
					r_rewardtype.SetBelong(this.instance);
				}
				return r_rewardtype;
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


        public RPRACTICE_TASK_INFO() : base("PRACTICE_TASK_INFO")
        {
        }

        public RPRACTICE_TASK_INFO(System.Object instance) : base("PRACTICE_TASK_INFO")
		{
            SetInstance(instance);
		}

        public RPRACTICE_TASK_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPRACTICE_TASK_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
