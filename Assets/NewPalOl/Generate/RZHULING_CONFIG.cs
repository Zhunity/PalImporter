using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ZHULING_CONFIG
	/// </summary>
    public partial class RZHULING_CONFIG : RMember //
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
		/// System.Int32 itemid
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
		/// System.Int32 exp
		/// </summary>
		protected RField r_exp;
		public virtual RField Rexp
		{
			get
			{
				if(r_exp == null)
				{
					r_exp = new(this, "exp");
					r_exp.SetBelong(this.instance);
				}
				return r_exp;
			}
		}

		/// <summary>
		/// System.Int32 percent
		/// </summary>
		protected RField r_percent;
		public virtual RField Rpercent
		{
			get
			{
				if(r_percent == null)
				{
					r_percent = new(this, "percent");
					r_percent.SetBelong(this.instance);
				}
				return r_percent;
			}
		}

		/// <summary>
		/// System.Int32 skillpoint1
		/// </summary>
		protected RField r_skillpoint1;
		public virtual RField Rskillpoint1
		{
			get
			{
				if(r_skillpoint1 == null)
				{
					r_skillpoint1 = new(this, "skillpoint1");
					r_skillpoint1.SetBelong(this.instance);
				}
				return r_skillpoint1;
			}
		}

		/// <summary>
		/// System.Int32 skillpoint2
		/// </summary>
		protected RField r_skillpoint2;
		public virtual RField Rskillpoint2
		{
			get
			{
				if(r_skillpoint2 == null)
				{
					r_skillpoint2 = new(this, "skillpoint2");
					r_skillpoint2.SetBelong(this.instance);
				}
				return r_skillpoint2;
			}
		}

		/// <summary>
		/// System.Int32 skillpoint3
		/// </summary>
		protected RField r_skillpoint3;
		public virtual RField Rskillpoint3
		{
			get
			{
				if(r_skillpoint3 == null)
				{
					r_skillpoint3 = new(this, "skillpoint3");
					r_skillpoint3.SetBelong(this.instance);
				}
				return r_skillpoint3;
			}
		}

		/// <summary>
		/// System.Int32 skillpoint4
		/// </summary>
		protected RField r_skillpoint4;
		public virtual RField Rskillpoint4
		{
			get
			{
				if(r_skillpoint4 == null)
				{
					r_skillpoint4 = new(this, "skillpoint4");
					r_skillpoint4.SetBelong(this.instance);
				}
				return r_skillpoint4;
			}
		}

		/// <summary>
		/// System.Int32 skillpoint5
		/// </summary>
		protected RField r_skillpoint5;
		public virtual RField Rskillpoint5
		{
			get
			{
				if(r_skillpoint5 == null)
				{
					r_skillpoint5 = new(this, "skillpoint5");
					r_skillpoint5.SetBelong(this.instance);
				}
				return r_skillpoint5;
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


        public RZHULING_CONFIG() : base("ZHULING_CONFIG")
        {
        }

        public RZHULING_CONFIG(System.Object instance) : base("ZHULING_CONFIG")
		{
            SetInstance(instance);
		}

        public RZHULING_CONFIG(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RZHULING_CONFIG(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
