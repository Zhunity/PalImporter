using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#2ib
	/// </summary>
    public partial class R__0__2ib : RMember //
    {

		/// <summary>
		/// System.String #0ib(#u.#Ckb, Int32)
		/// </summary>
		protected RMethod r_R__0__0ib___0__Ckb_Int32;
		public virtual RMethod R__0__0ib___0__Ckb_Int32
		{
			get
			{
				if(r_R__0__0ib___0__Ckb_Int32 == null)
				{
					r_R__0__0ib___0__Ckb_Int32 = new(this, "#0ib", 0,  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.Int32));
					r_R__0__0ib___0__Ckb_Int32.SetBelong(this.instance);
				}
				return r_R__0__0ib___0__Ckb_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#5ib] #1ib(#u.#Ckb, Int32)
		/// </summary>
		protected RMethod r_R__0__1ib___0__Ckb_Int32;
		public virtual RMethod R__0__1ib___0__Ckb_Int32
		{
			get
			{
				if(r_R__0__1ib___0__Ckb_Int32 == null)
				{
					r_R__0__1ib___0__Ckb_Int32 = new(this, "#1ib", 0,  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.Int32));
					r_R__0__1ib___0__Ckb_Int32.SetBelong(this.instance);
				}
				return r_R__0__1ib___0__Ckb_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#5ib] #1ib(#u.#Ckb, #u.#Fnb, Int32)
		/// </summary>
		protected RMethod r_R__0__1ib___0__Ckb___0__Fnb_Int32;
		public virtual RMethod R__0__1ib___0__Ckb___0__Fnb_Int32
		{
			get
			{
				if(r_R__0__1ib___0__Ckb___0__Fnb_Int32 == null)
				{
					r_R__0__1ib___0__Ckb___0__Fnb_Int32 = new(this, "#1ib", 0,  ReleactionUtils.GetType("#u.#Ckb"),  ReleactionUtils.GetType("#u.#Fnb"), typeof(System.Int32));
					r_R__0__1ib___0__Ckb___0__Fnb_Int32.SetBelong(this.instance);
				}
				return r_R__0__1ib___0__Ckb___0__Fnb_Int32;
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


        public R__0__2ib() : base("#u.#2ib")
        {
        }

        public R__0__2ib(System.Object instance) : base("#u.#2ib")
		{
            SetInstance(instance);
		}

        public R__0__2ib(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__2ib(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
