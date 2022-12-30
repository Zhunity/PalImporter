using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PetStrategyConfig
	/// </summary>
    public partial class RPetStrategyConfig : RMember //
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
		/// System.String career
		/// </summary>
		protected RField r_career;
		public virtual RField Rcareer
		{
			get
			{
				if(r_career == null)
				{
					r_career = new(this, "career");
					r_career.SetBelong(this.instance);
				}
				return r_career;
			}
		}

		/// <summary>
		/// System.String combine
		/// </summary>
		protected RField r_combine;
		public virtual RField Rcombine
		{
			get
			{
				if(r_combine == null)
				{
					r_combine = new(this, "combine");
					r_combine.SetBelong(this.instance);
				}
				return r_combine;
			}
		}

		/// <summary>
		/// System.Int32 damage
		/// </summary>
		protected RField r_damage;
		public virtual RField Rdamage
		{
			get
			{
				if(r_damage == null)
				{
					r_damage = new(this, "damage");
					r_damage.SetBelong(this.instance);
				}
				return r_damage;
			}
		}

		/// <summary>
		/// System.Int32 minus
		/// </summary>
		protected RField r_minus;
		public virtual RField Rminus
		{
			get
			{
				if(r_minus == null)
				{
					r_minus = new(this, "minus");
					r_minus.SetBelong(this.instance);
				}
				return r_minus;
			}
		}

		/// <summary>
		/// System.Int32 cure
		/// </summary>
		protected RField r_cure;
		public virtual RField Rcure
		{
			get
			{
				if(r_cure == null)
				{
					r_cure = new(this, "cure");
					r_cure.SetBelong(this.instance);
				}
				return r_cure;
			}
		}

		/// <summary>
		/// System.Int32 defend
		/// </summary>
		protected RField r_defend;
		public virtual RField Rdefend
		{
			get
			{
				if(r_defend == null)
				{
					r_defend = new(this, "defend");
					r_defend.SetBelong(this.instance);
				}
				return r_defend;
			}
		}

		/// <summary>
		/// System.String juniorcombine
		/// </summary>
		protected RField r_juniorcombine;
		public virtual RField Rjuniorcombine
		{
			get
			{
				if(r_juniorcombine == null)
				{
					r_juniorcombine = new(this, "juniorcombine");
					r_juniorcombine.SetBelong(this.instance);
				}
				return r_juniorcombine;
			}
		}

		/// <summary>
		/// System.String seniorcombine
		/// </summary>
		protected RField r_seniorcombine;
		public virtual RField Rseniorcombine
		{
			get
			{
				if(r_seniorcombine == null)
				{
					r_seniorcombine = new(this, "seniorcombine");
					r_seniorcombine.SetBelong(this.instance);
				}
				return r_seniorcombine;
			}
		}

		/// <summary>
		/// System.String topcombine
		/// </summary>
		protected RField r_topcombine;
		public virtual RField Rtopcombine
		{
			get
			{
				if(r_topcombine == null)
				{
					r_topcombine = new(this, "topcombine");
					r_topcombine.SetBelong(this.instance);
				}
				return r_topcombine;
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


        public RPetStrategyConfig() : base("PetStrategyConfig")
        {
        }

        public RPetStrategyConfig(System.Object instance) : base("PetStrategyConfig")
		{
            SetInstance(instance);
		}

        public RPetStrategyConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPetStrategyConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
