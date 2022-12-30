using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__0Ib
{
	/// <summary>
	/// #0Ib.#4Ib
	/// </summary>
    public partial class R__0__4Ib : RMember //
    {

		/// <summary>
		/// #0Ib.#ZIb #a
		/// </summary>
		protected R__0__0Ib.R__0__ZIb r___0__a;
		public virtual R__0__0Ib.R__0__ZIb R__0__a
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
		/// #0Ib.#ZIb UIEventHandler
		/// </summary>
		protected R__0__0Ib.R__0__ZIb r_R__0__1Ib;
		public virtual R__0__0Ib.R__0__ZIb R__0__1Ib
		{
			get
			{
				if(r_R__0__1Ib == null)
				{
					r_R__0__1Ib = new(this, "UIEventHandler", -1);
					r_R__0__1Ib.SetBelong(this.instance);
				}
				return r_R__0__1Ib;
			}
		}

		/// <summary>
		/// Void #3Ib(#0Ib.#7Ib)
		/// </summary>
		protected RMethod r_R__0__3Ib___0__7Ib;
		public virtual RMethod R__0__3Ib___0__7Ib
		{
			get
			{
				if(r_R__0__3Ib___0__7Ib == null)
				{
					r_R__0__3Ib___0__7Ib = new(this, "#3Ib", 0,  ReleactionUtils.GetType("#0Ib.#7Ib"));
					r_R__0__3Ib___0__7Ib.SetBelong(this.instance);
				}
				return r_R__0__3Ib___0__7Ib;
			}
		}

		/// <summary>
		/// Boolean #Wbc(#0Ib.#7Ib)
		/// </summary>
		protected RMethod r_R__0__Wbc___0__7Ib;
		public virtual RMethod R__0__Wbc___0__7Ib
		{
			get
			{
				if(r_R__0__Wbc___0__7Ib == null)
				{
					r_R__0__Wbc___0__7Ib = new(this, "#Wbc", 0,  ReleactionUtils.GetType("#0Ib.#7Ib"));
					r_R__0__Wbc___0__7Ib.SetBelong(this.instance);
				}
				return r_R__0__Wbc___0__7Ib;
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


        public R__0__4Ib() : base("#0Ib.#4Ib")
        {
        }

        public R__0__4Ib(System.Object instance) : base("#0Ib.#4Ib")
		{
            SetInstance(instance);
		}

        public R__0__4Ib(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__4Ib(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
