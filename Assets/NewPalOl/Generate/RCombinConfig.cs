using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CombinConfig
	/// </summary>
    public partial class RCombinConfig : RMember //
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
		/// System.Int32 needgoldex
		/// </summary>
		protected RField r_needgoldex;
		public virtual RField Rneedgoldex
		{
			get
			{
				if(r_needgoldex == null)
				{
					r_needgoldex = new(this, "needgoldex");
					r_needgoldex.SetBelong(this.instance);
				}
				return r_needgoldex;
			}
		}

		/// <summary>
		/// System.Int32 needcount
		/// </summary>
		protected RField r_needcount;
		public virtual RField Rneedcount
		{
			get
			{
				if(r_needcount == null)
				{
					r_needcount = new(this, "needcount");
					r_needcount.SetBelong(this.instance);
				}
				return r_needcount;
			}
		}

		/// <summary>
		/// System.Int32 pro1
		/// </summary>
		protected RField r_pro1;
		public virtual RField Rpro1
		{
			get
			{
				if(r_pro1 == null)
				{
					r_pro1 = new(this, "pro1");
					r_pro1.SetBelong(this.instance);
				}
				return r_pro1;
			}
		}

		/// <summary>
		/// System.String desc1
		/// </summary>
		protected RField r_desc1;
		public virtual RField Rdesc1
		{
			get
			{
				if(r_desc1 == null)
				{
					r_desc1 = new(this, "desc1");
					r_desc1.SetBelong(this.instance);
				}
				return r_desc1;
			}
		}

		/// <summary>
		/// System.Int32 result
		/// </summary>
		protected RField r_result;
		public virtual RField Rresult
		{
			get
			{
				if(r_result == null)
				{
					r_result = new(this, "result");
					r_result.SetBelong(this.instance);
				}
				return r_result;
			}
		}

		/// <summary>
		/// System.Int32 itemlv
		/// </summary>
		protected RField r_itemlv;
		public virtual RField Ritemlv
		{
			get
			{
				if(r_itemlv == null)
				{
					r_itemlv = new(this, "itemlv");
					r_itemlv.SetBelong(this.instance);
				}
				return r_itemlv;
			}
		}

		/// <summary>
		/// System.Int32 time
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
		/// System.String maintype
		/// </summary>
		protected RField r_maintype;
		public virtual RField Rmaintype
		{
			get
			{
				if(r_maintype == null)
				{
					r_maintype = new(this, "maintype");
					r_maintype.SetBelong(this.instance);
				}
				return r_maintype;
			}
		}

		/// <summary>
		/// System.String subtype
		/// </summary>
		protected RField r_subtype;
		public virtual RField Rsubtype
		{
			get
			{
				if(r_subtype == null)
				{
					r_subtype = new(this, "subtype");
					r_subtype.SetBelong(this.instance);
				}
				return r_subtype;
			}
		}

		/// <summary>
		/// System.Int32 bind_result_type
		/// </summary>
		protected RField r_bind_result_type;
		public virtual RField Rbind_result_type
		{
			get
			{
				if(r_bind_result_type == null)
				{
					r_bind_result_type = new(this, "bind_result_type");
					r_bind_result_type.SetBelong(this.instance);
				}
				return r_bind_result_type;
			}
		}

		/// <summary>
		/// System.Int32 unbind_result_type
		/// </summary>
		protected RField r_unbind_result_type;
		public virtual RField Runbind_result_type
		{
			get
			{
				if(r_unbind_result_type == null)
				{
					r_unbind_result_type = new(this, "unbind_result_type");
					r_unbind_result_type.SetBelong(this.instance);
				}
				return r_unbind_result_type;
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


        public RCombinConfig() : base("CombinConfig")
        {
        }

        public RCombinConfig(System.Object instance) : base("CombinConfig")
		{
            SetInstance(instance);
		}

        public RCombinConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCombinConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
