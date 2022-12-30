using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// NewYearConfig
	/// </summary>
    public partial class RNewYearConfig : RMember //
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
		/// System.Int32 freeitemid
		/// </summary>
		protected RField r_freeitemid;
		public virtual RField Rfreeitemid
		{
			get
			{
				if(r_freeitemid == null)
				{
					r_freeitemid = new(this, "freeitemid");
					r_freeitemid.SetBelong(this.instance);
				}
				return r_freeitemid;
			}
		}

		/// <summary>
		/// System.Int32 payitemid
		/// </summary>
		protected RField r_payitemid;
		public virtual RField Rpayitemid
		{
			get
			{
				if(r_payitemid == null)
				{
					r_payitemid = new(this, "payitemid");
					r_payitemid.SetBelong(this.instance);
				}
				return r_payitemid;
			}
		}

		/// <summary>
		/// System.String items
		/// </summary>
		protected RField r_items;
		public virtual RField Ritems
		{
			get
			{
				if(r_items == null)
				{
					r_items = new(this, "items");
					r_items.SetBelong(this.instance);
				}
				return r_items;
			}
		}

		/// <summary>
		/// System.Int32 day
		/// </summary>
		protected RField r_day;
		public virtual RField Rday
		{
			get
			{
				if(r_day == null)
				{
					r_day = new(this, "day");
					r_day.SetBelong(this.instance);
				}
				return r_day;
			}
		}

		/// <summary>
		/// System.Int32 currprice
		/// </summary>
		protected RField r_currprice;
		public virtual RField Rcurrprice
		{
			get
			{
				if(r_currprice == null)
				{
					r_currprice = new(this, "currprice");
					r_currprice.SetBelong(this.instance);
				}
				return r_currprice;
			}
		}

		/// <summary>
		/// System.Int32 oriprice
		/// </summary>
		protected RField r_oriprice;
		public virtual RField Roriprice
		{
			get
			{
				if(r_oriprice == null)
				{
					r_oriprice = new(this, "oriprice");
					r_oriprice.SetBelong(this.instance);
				}
				return r_oriprice;
			}
		}

		/// <summary>
		/// System.Int32 titleid
		/// </summary>
		protected RField r_titleid;
		public virtual RField Rtitleid
		{
			get
			{
				if(r_titleid == null)
				{
					r_titleid = new(this, "titleid");
					r_titleid.SetBelong(this.instance);
				}
				return r_titleid;
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


        public RNewYearConfig() : base("NewYearConfig")
        {
        }

        public RNewYearConfig(System.Object instance) : base("NewYearConfig")
		{
            SetInstance(instance);
		}

        public RNewYearConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNewYearConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
