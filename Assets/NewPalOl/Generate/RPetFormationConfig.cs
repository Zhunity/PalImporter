using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PetFormationConfig
	/// </summary>
    public partial class RPetFormationConfig : RMember //
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
		/// System.Int32 order0
		/// </summary>
		protected RField r_order0;
		public virtual RField Rorder0
		{
			get
			{
				if(r_order0 == null)
				{
					r_order0 = new(this, "order0");
					r_order0.SetBelong(this.instance);
				}
				return r_order0;
			}
		}

		/// <summary>
		/// System.Int32 order1
		/// </summary>
		protected RField r_order1;
		public virtual RField Rorder1
		{
			get
			{
				if(r_order1 == null)
				{
					r_order1 = new(this, "order1");
					r_order1.SetBelong(this.instance);
				}
				return r_order1;
			}
		}

		/// <summary>
		/// System.Int32 order2
		/// </summary>
		protected RField r_order2;
		public virtual RField Rorder2
		{
			get
			{
				if(r_order2 == null)
				{
					r_order2 = new(this, "order2");
					r_order2.SetBelong(this.instance);
				}
				return r_order2;
			}
		}

		/// <summary>
		/// System.Int32 order3
		/// </summary>
		protected RField r_order3;
		public virtual RField Rorder3
		{
			get
			{
				if(r_order3 == null)
				{
					r_order3 = new(this, "order3");
					r_order3.SetBelong(this.instance);
				}
				return r_order3;
			}
		}

		/// <summary>
		/// System.Int32 order4
		/// </summary>
		protected RField r_order4;
		public virtual RField Rorder4
		{
			get
			{
				if(r_order4 == null)
				{
					r_order4 = new(this, "order4");
					r_order4.SetBelong(this.instance);
				}
				return r_order4;
			}
		}

		/// <summary>
		/// System.Int32 order5
		/// </summary>
		protected RField r_order5;
		public virtual RField Rorder5
		{
			get
			{
				if(r_order5 == null)
				{
					r_order5 = new(this, "order5");
					r_order5.SetBelong(this.instance);
				}
				return r_order5;
			}
		}

		/// <summary>
		/// System.Int32 order6
		/// </summary>
		protected RField r_order6;
		public virtual RField Rorder6
		{
			get
			{
				if(r_order6 == null)
				{
					r_order6 = new(this, "order6");
					r_order6.SetBelong(this.instance);
				}
				return r_order6;
			}
		}

		/// <summary>
		/// System.Int32 order7
		/// </summary>
		protected RField r_order7;
		public virtual RField Rorder7
		{
			get
			{
				if(r_order7 == null)
				{
					r_order7 = new(this, "order7");
					r_order7.SetBelong(this.instance);
				}
				return r_order7;
			}
		}

		/// <summary>
		/// System.Int32 order8
		/// </summary>
		protected RField r_order8;
		public virtual RField Rorder8
		{
			get
			{
				if(r_order8 == null)
				{
					r_order8 = new(this, "order8");
					r_order8.SetBelong(this.instance);
				}
				return r_order8;
			}
		}

		/// <summary>
		/// System.String gonglvetitle
		/// </summary>
		protected RField r_gonglvetitle;
		public virtual RField Rgonglvetitle
		{
			get
			{
				if(r_gonglvetitle == null)
				{
					r_gonglvetitle = new(this, "gonglvetitle");
					r_gonglvetitle.SetBelong(this.instance);
				}
				return r_gonglvetitle;
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


        public RPetFormationConfig() : base("PetFormationConfig")
        {
        }

        public RPetFormationConfig(System.Object instance) : base("PetFormationConfig")
		{
            SetInstance(instance);
		}

        public RPetFormationConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPetFormationConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
