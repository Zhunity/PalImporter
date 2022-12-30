using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__Pfb
{
	/// <summary>
	/// #Pfb.#sUb
	/// </summary>
    public partial class R__0__sUb : RMember //
    {

		/// <summary>
		/// System.String #a
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
		/// System.String #wsb()
		/// </summary>
		protected RMethod r_R__0__wsb;
		public virtual RMethod R__0__wsb
		{
			get
			{
				if(r_R__0__wsb == null)
				{
					r_R__0__wsb = new(this, "#wsb", 0);
					r_R__0__wsb.SetBelong(this.instance);
				}
				return r_R__0__wsb;
			}
		}

		/// <summary>
		/// Void #xsb(System.String)
		/// </summary>
		protected RMethod r_R__0__xsb_String;
		public virtual RMethod R__0__xsb_String
		{
			get
			{
				if(r_R__0__xsb_String == null)
				{
					r_R__0__xsb_String = new(this, "#xsb", 0, typeof(System.String));
					r_R__0__xsb_String.SetBelong(this.instance);
				}
				return r_R__0__xsb_String;
			}
		}

		/// <summary>
		/// System.Reflection.BindingFlags #ysb()
		/// </summary>
		protected RMethod r_R__0__ysb;
		public virtual RMethod R__0__ysb
		{
			get
			{
				if(r_R__0__ysb == null)
				{
					r_R__0__ysb = new(this, "#ysb", 0);
					r_R__0__ysb.SetBelong(this.instance);
				}
				return r_R__0__ysb;
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


        public R__0__sUb() : base("#Pfb.#sUb")
        {
        }

        public R__0__sUb(System.Object instance) : base("#Pfb.#sUb")
		{
            SetInstance(instance);
		}

        public R__0__sUb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__sUb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String __0__wsb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wsb.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void __0__xsb(System.String  @msgTag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msgTag};
            var ___result = R__0__xsb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Reflection.BindingFlags __0__ysb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ysb.Invoke(___genericsType, ___parameters);

            return (System.Reflection.BindingFlags)___result;
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
