using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// DAILYEVENT_INFO
	/// </summary>
    public partial class RDAILYEVENT_INFO : RMember //
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
		/// System.String item
		/// </summary>
		protected RField r_item;
		public virtual RField Ritem
		{
			get
			{
				if(r_item == null)
				{
					r_item = new(this, "item");
					r_item.SetBelong(this.instance);
				}
				return r_item;
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
		/// System.String btntext_leader
		/// </summary>
		protected RField r_btntext_leader;
		public virtual RField Rbtntext_leader
		{
			get
			{
				if(r_btntext_leader == null)
				{
					r_btntext_leader = new(this, "btntext_leader");
					r_btntext_leader.SetBelong(this.instance);
				}
				return r_btntext_leader;
			}
		}

		/// <summary>
		/// System.String btntext_member
		/// </summary>
		protected RField r_btntext_member;
		public virtual RField Rbtntext_member
		{
			get
			{
				if(r_btntext_member == null)
				{
					r_btntext_member = new(this, "btntext_member");
					r_btntext_member.SetBelong(this.instance);
				}
				return r_btntext_member;
			}
		}

		/// <summary>
		/// System.String btntext
		/// </summary>
		protected RField r_btntext;
		public virtual RField Rbtntext
		{
			get
			{
				if(r_btntext == null)
				{
					r_btntext = new(this, "btntext");
					r_btntext.SetBelong(this.instance);
				}
				return r_btntext;
			}
		}

		/// <summary>
		/// System.Int32 btntype
		/// </summary>
		protected RField r_btntype;
		public virtual RField Rbtntype
		{
			get
			{
				if(r_btntype == null)
				{
					r_btntype = new(this, "btntype");
					r_btntype.SetBelong(this.instance);
				}
				return r_btntype;
			}
		}

		/// <summary>
		/// System.String btnparam
		/// </summary>
		protected RField r_btnparam;
		public virtual RField Rbtnparam
		{
			get
			{
				if(r_btnparam == null)
				{
					r_btnparam = new(this, "btnparam");
					r_btnparam.SetBelong(this.instance);
				}
				return r_btnparam;
			}
		}

		/// <summary>
		/// System.String showdays
		/// </summary>
		protected RField r_showdays;
		public virtual RField Rshowdays
		{
			get
			{
				if(r_showdays == null)
				{
					r_showdays = new(this, "showdays");
					r_showdays.SetBelong(this.instance);
				}
				return r_showdays;
			}
		}

		/// <summary>
		/// System.String time
		/// </summary>
		protected RField r_time;
		public virtual RField Rtime
		{
			get
			{
				if(r_time == null)
				{
					r_time = new(this, "time");
					r_time.SetBelong(this.instance);
				}
				return r_time;
			}
		}

		/// <summary>
		/// System.String starttime
		/// </summary>
		protected RField r_starttime;
		public virtual RField Rstarttime
		{
			get
			{
				if(r_starttime == null)
				{
					r_starttime = new(this, "starttime");
					r_starttime.SetBelong(this.instance);
				}
				return r_starttime;
			}
		}

		/// <summary>
		/// System.String endtime
		/// </summary>
		protected RField r_endtime;
		public virtual RField Rendtime
		{
			get
			{
				if(r_endtime == null)
				{
					r_endtime = new(this, "endtime");
					r_endtime.SetBelong(this.instance);
				}
				return r_endtime;
			}
		}

		/// <summary>
		/// System.String count_propname
		/// </summary>
		protected RField r_count_propname;
		public virtual RField Rcount_propname
		{
			get
			{
				if(r_count_propname == null)
				{
					r_count_propname = new(this, "count_propname");
					r_count_propname.SetBelong(this.instance);
				}
				return r_count_propname;
			}
		}

		/// <summary>
		/// System.Int32 isFamily
		/// </summary>
		protected RField r_isFamily;
		public virtual RField RisFamily
		{
			get
			{
				if(r_isFamily == null)
				{
					r_isFamily = new(this, "isFamily");
					r_isFamily.SetBelong(this.instance);
				}
				return r_isFamily;
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


        public RDAILYEVENT_INFO() : base("DAILYEVENT_INFO")
        {
        }

        public RDAILYEVENT_INFO(System.Object instance) : base("DAILYEVENT_INFO")
		{
            SetInstance(instance);
		}

        public RDAILYEVENT_INFO(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDAILYEVENT_INFO(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
