using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{public partial class R__0__dMb<__0__bk>
{
	
	/// <summary>
	/// #u.#dMb+#oMb
	/// </summary>
    public partial class R__0__oMb : RMember //
    {

		/// <summary>
		/// System.Int32 #a
		/// </summary>
		protected RField r___0__a;
		public virtual RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// #u.#mLb #b
		/// </summary>
		protected R__0__u.R__0__mLb r___0__b;
		public virtual R__0__u.R__0__mLb R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// #oU.#uU Icon
		/// </summary>
		protected R__0__oU.R__0__uU r_R__0__eMb;
		public virtual R__0__oU.R__0__uU R__0__eMb
		{
			get
			{
				if(r_R__0__eMb == null)
				{
					r_R__0__eMb = new(this, "Icon", -1);
					r_R__0__eMb.SetBelong(this.instance);
				}
				return r_R__0__eMb;
			}
		}

		/// <summary>
		/// #oU.#I1 Count
		/// </summary>
		protected R__0__oU.R__0__I1 r_R__0__gMb;
		public virtual R__0__oU.R__0__I1 R__0__gMb
		{
			get
			{
				if(r_R__0__gMb == null)
				{
					r_R__0__gMb = new(this, "Count", -1);
					r_R__0__gMb.SetBelong(this.instance);
				}
				return r_R__0__gMb;
			}
		}

		/// <summary>
		/// #oU.#I1 Border
		/// </summary>
		protected R__0__oU.R__0__I1 r_R__0__iMb;
		public virtual R__0__oU.R__0__I1 R__0__iMb
		{
			get
			{
				if(r_R__0__iMb == null)
				{
					r_R__0__iMb = new(this, "Border", -1);
					r_R__0__iMb.SetBelong(this.instance);
				}
				return r_R__0__iMb;
			}
		}

		/// <summary>
		/// #oU.#uU Operate
		/// </summary>
		protected R__0__oU.R__0__uU r_R__0__kMb;
		public virtual R__0__oU.R__0__uU R__0__kMb
		{
			get
			{
				if(r_R__0__kMb == null)
				{
					r_R__0__kMb = new(this, "Operate", -1);
					r_R__0__kMb.SetBelong(this.instance);
				}
				return r_R__0__kMb;
			}
		}

		/// <summary>
		/// UIeffect UIEffect
		/// </summary>
		protected RUIeffect r_R__0__mMb;
		public virtual RUIeffect R__0__mMb
		{
			get
			{
				if(r_R__0__mMb == null)
				{
					r_R__0__mMb = new(this, "UIEffect", -1);
					r_R__0__mMb.SetBelong(this.instance);
				}
				return r_R__0__mMb;
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


        public R__0__oMb() : base("#u.#dMb+#oMb")
        {
        }

        public R__0__oMb(System.Object instance) : base("#u.#dMb+#oMb")
		{
            SetInstance(instance);
		}

        public R__0__oMb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__oMb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}