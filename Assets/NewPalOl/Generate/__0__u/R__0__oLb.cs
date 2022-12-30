using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#oLb
	/// </summary>
    public partial class R__0__oLb : RMember //
    {

		/// <summary>
		/// #oU.#uU #nLb(Int32)
		/// </summary>
		protected RMethod r_R__0__nLb_Int32;
		public virtual RMethod R__0__nLb_Int32
		{
			get
			{
				if(r_R__0__nLb_Int32 == null)
				{
					r_R__0__nLb_Int32 = new(this, "#nLb", 0, typeof(System.Int32));
					r_R__0__nLb_Int32.SetBelong(this.instance);
				}
				return r_R__0__nLb_Int32;
			}
		}


        public R__0__oLb() : base("#u.#oLb")
        {
        }

        public R__0__oLb(System.Object instance) : base("#u.#oLb")
		{
            SetInstance(instance);
		}

        public R__0__oLb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__oLb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object __0__nLb(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = R__0__nLb_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


    }
}
