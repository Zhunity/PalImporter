using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TeamBattleExpAdd
	/// </summary>
    public partial class RTeamBattleExpAdd : RMember //
    {

		/// <summary>
		/// System.Int32 exp_add
		/// </summary>
		protected RField r_exp_add;
		public virtual RField Rexp_add
		{
			get
			{
				if(r_exp_add == null)
				{
					r_exp_add = new(this, "exp_add");
					r_exp_add.SetBelong(this.instance);
				}
				return r_exp_add;
			}
		}

		/// <summary>
		/// System.Int32 intimacy_begin
		/// </summary>
		protected RField r_intimacy_begin;
		public virtual RField Rintimacy_begin
		{
			get
			{
				if(r_intimacy_begin == null)
				{
					r_intimacy_begin = new(this, "intimacy_begin");
					r_intimacy_begin.SetBelong(this.instance);
				}
				return r_intimacy_begin;
			}
		}

		/// <summary>
		/// System.Int32 intimacy_end
		/// </summary>
		protected RField r_intimacy_end;
		public virtual RField Rintimacy_end
		{
			get
			{
				if(r_intimacy_end == null)
				{
					r_intimacy_end = new(this, "intimacy_end");
					r_intimacy_end.SetBelong(this.instance);
				}
				return r_intimacy_end;
			}
		}

		/// <summary>
		/// System.String intimacy_tips
		/// </summary>
		protected RField r_intimacy_tips;
		public virtual RField Rintimacy_tips
		{
			get
			{
				if(r_intimacy_tips == null)
				{
					r_intimacy_tips = new(this, "intimacy_tips");
					r_intimacy_tips.SetBelong(this.instance);
				}
				return r_intimacy_tips;
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


        public RTeamBattleExpAdd() : base("TeamBattleExpAdd")
        {
        }

        public RTeamBattleExpAdd(System.Object instance) : base("TeamBattleExpAdd")
		{
            SetInstance(instance);
		}

        public RTeamBattleExpAdd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTeamBattleExpAdd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
