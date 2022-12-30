using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ZhulingSkillConfig
	/// </summary>
    public partial class RZhulingSkillConfig : RMember //
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
		/// System.Int32 open_lv
		/// </summary>
		protected RField r_open_lv;
		public virtual RField Ropen_lv
		{
			get
			{
				if(r_open_lv == null)
				{
					r_open_lv = new(this, "open_lv");
					r_open_lv.SetBelong(this.instance);
				}
				return r_open_lv;
			}
		}

		/// <summary>
		/// System.Int32 probability
		/// </summary>
		protected RField r_probability;
		public virtual RField Rprobability
		{
			get
			{
				if(r_probability == null)
				{
					r_probability = new(this, "probability");
					r_probability.SetBelong(this.instance);
				}
				return r_probability;
			}
		}

		/// <summary>
		/// System.Int32 cost_item
		/// </summary>
		protected RField r_cost_item;
		public virtual RField Rcost_item
		{
			get
			{
				if(r_cost_item == null)
				{
					r_cost_item = new(this, "cost_item");
					r_cost_item.SetBelong(this.instance);
				}
				return r_cost_item;
			}
		}

		/// <summary>
		/// System.Int32 cost_num
		/// </summary>
		protected RField r_cost_num;
		public virtual RField Rcost_num
		{
			get
			{
				if(r_cost_num == null)
				{
					r_cost_num = new(this, "cost_num");
					r_cost_num.SetBelong(this.instance);
				}
				return r_cost_num;
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
		/// System.String propname
		/// </summary>
		protected RField r_propname;
		public virtual RField Rpropname
		{
			get
			{
				if(r_propname == null)
				{
					r_propname = new(this, "propname");
					r_propname.SetBelong(this.instance);
				}
				return r_propname;
			}
		}

		/// <summary>
		/// System.String propvalue
		/// </summary>
		protected RField r_propvalue;
		public virtual RField Rpropvalue
		{
			get
			{
				if(r_propvalue == null)
				{
					r_propvalue = new(this, "propvalue");
					r_propvalue.SetBelong(this.instance);
				}
				return r_propvalue;
			}
		}

		/// <summary>
		/// System.String return_item
		/// </summary>
		protected RField r_return_item;
		public virtual RField Rreturn_item
		{
			get
			{
				if(r_return_item == null)
				{
					r_return_item = new(this, "return_item");
					r_return_item.SetBelong(this.instance);
				}
				return r_return_item;
			}
		}

		/// <summary>
		/// System.Int32 quickbuyitem
		/// </summary>
		protected RField r_quickbuyitem;
		public virtual RField Rquickbuyitem
		{
			get
			{
				if(r_quickbuyitem == null)
				{
					r_quickbuyitem = new(this, "quickbuyitem");
					r_quickbuyitem.SetBelong(this.instance);
				}
				return r_quickbuyitem;
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


        public RZhulingSkillConfig() : base("ZhulingSkillConfig")
        {
        }

        public RZhulingSkillConfig(System.Object instance) : base("ZhulingSkillConfig")
		{
            SetInstance(instance);
		}

        public RZhulingSkillConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RZhulingSkillConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
