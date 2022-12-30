using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PrestigeConfig
	/// </summary>
    public partial class RPrestigeConfig : RMember //
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
		/// System.Int32 honour
		/// </summary>
		protected RField r_honour;
		public virtual RField Rhonour
		{
			get
			{
				if(r_honour == null)
				{
					r_honour = new(this, "honour");
					r_honour.SetBelong(this.instance);
				}
				return r_honour;
			}
		}

		/// <summary>
		/// System.Int32 hp
		/// </summary>
		protected RField r_hp;
		public virtual RField Rhp
		{
			get
			{
				if(r_hp == null)
				{
					r_hp = new(this, "hp");
					r_hp.SetBelong(this.instance);
				}
				return r_hp;
			}
		}

		/// <summary>
		/// System.Int32 atk
		/// </summary>
		protected RField r_atk;
		public virtual RField Ratk
		{
			get
			{
				if(r_atk == null)
				{
					r_atk = new(this, "atk");
					r_atk.SetBelong(this.instance);
				}
				return r_atk;
			}
		}

		/// <summary>
		/// System.Int32 arm
		/// </summary>
		protected RField r_arm;
		public virtual RField Rarm
		{
			get
			{
				if(r_arm == null)
				{
					r_arm = new(this, "arm");
					r_arm.SetBelong(this.instance);
				}
				return r_arm;
			}
		}

		/// <summary>
		/// System.Int32 every_lingli
		/// </summary>
		protected RField r_every_lingli;
		public virtual RField Revery_lingli
		{
			get
			{
				if(r_every_lingli == null)
				{
					r_every_lingli = new(this, "every_lingli");
					r_every_lingli.SetBelong(this.instance);
				}
				return r_every_lingli;
			}
		}

		/// <summary>
		/// System.Int32 every_money
		/// </summary>
		protected RField r_every_money;
		public virtual RField Revery_money
		{
			get
			{
				if(r_every_money == null)
				{
					r_every_money = new(this, "every_money");
					r_every_money.SetBelong(this.instance);
				}
				return r_every_money;
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


        public RPrestigeConfig() : base("PrestigeConfig")
        {
        }

        public RPrestigeConfig(System.Object instance) : base("PrestigeConfig")
		{
            SetInstance(instance);
		}

        public RPrestigeConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPrestigeConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
