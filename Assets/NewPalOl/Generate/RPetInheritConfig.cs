using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PetInheritConfig
	/// </summary>
    public partial class RPetInheritConfig : RMember //
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
		/// System.Int32 goldex
		/// </summary>
		protected RField r_goldex;
		public virtual RField Rgoldex
		{
			get
			{
				if(r_goldex == null)
				{
					r_goldex = new(this, "goldex");
					r_goldex.SetBelong(this.instance);
				}
				return r_goldex;
			}
		}

		/// <summary>
		/// System.Int32 gold1
		/// </summary>
		protected RField r_gold1;
		public virtual RField Rgold1
		{
			get
			{
				if(r_gold1 == null)
				{
					r_gold1 = new(this, "gold1");
					r_gold1.SetBelong(this.instance);
				}
				return r_gold1;
			}
		}

		/// <summary>
		/// System.Int32 gold2
		/// </summary>
		protected RField r_gold2;
		public virtual RField Rgold2
		{
			get
			{
				if(r_gold2 == null)
				{
					r_gold2 = new(this, "gold2");
					r_gold2.SetBelong(this.instance);
				}
				return r_gold2;
			}
		}

		/// <summary>
		/// System.Int32 gold3
		/// </summary>
		protected RField r_gold3;
		public virtual RField Rgold3
		{
			get
			{
				if(r_gold3 == null)
				{
					r_gold3 = new(this, "gold3");
					r_gold3.SetBelong(this.instance);
				}
				return r_gold3;
			}
		}

		/// <summary>
		/// System.String _exp
		/// </summary>
		protected RField r__exp;
		public virtual RField R_exp
		{
			get
			{
				if(r__exp == null)
				{
					r__exp = new(this, "_exp");
					r__exp.SetBelong(this.instance);
				}
				return r__exp;
			}
		}

		/// <summary>
		/// System.Int32 ratio1
		/// </summary>
		protected RField r_ratio1;
		public virtual RField Rratio1
		{
			get
			{
				if(r_ratio1 == null)
				{
					r_ratio1 = new(this, "ratio1");
					r_ratio1.SetBelong(this.instance);
				}
				return r_ratio1;
			}
		}

		/// <summary>
		/// System.Int32 ratio2
		/// </summary>
		protected RField r_ratio2;
		public virtual RField Rratio2
		{
			get
			{
				if(r_ratio2 == null)
				{
					r_ratio2 = new(this, "ratio2");
					r_ratio2.SetBelong(this.instance);
				}
				return r_ratio2;
			}
		}

		/// <summary>
		/// System.Int32 ratio3
		/// </summary>
		protected RField r_ratio3;
		public virtual RField Rratio3
		{
			get
			{
				if(r_ratio3 == null)
				{
					r_ratio3 = new(this, "ratio3");
					r_ratio3.SetBelong(this.instance);
				}
				return r_ratio3;
			}
		}

		/// <summary>
		/// System.Int32 ratio4
		/// </summary>
		protected RField r_ratio4;
		public virtual RField Rratio4
		{
			get
			{
				if(r_ratio4 == null)
				{
					r_ratio4 = new(this, "ratio4");
					r_ratio4.SetBelong(this.instance);
				}
				return r_ratio4;
			}
		}

		/// <summary>
		/// Int64 exp
		/// </summary>
		protected RProperty r_exp;
		public virtual RProperty Rexp
		{
			get
			{
				if(r_exp == null)
				{
					r_exp = new(this, "exp", -1);
					r_exp.SetBelong(this.instance);
				}
				return r_exp;
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


        public RPetInheritConfig() : base("PetInheritConfig")
        {
        }

        public RPetInheritConfig(System.Object instance) : base("PetInheritConfig")
		{
            SetInstance(instance);
		}

        public RPetInheritConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPetInheritConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
