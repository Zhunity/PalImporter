using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#ukb
	/// </summary>
    public partial class R__0__ukb : RMember //
    {

		/// <summary>
		/// Void #Xc(#u.#MSc)
		/// </summary>
		protected RMethod r_R__0__Xc___0__MSc;
		public virtual RMethod R__0__Xc___0__MSc
		{
			get
			{
				if(r_R__0__Xc___0__MSc == null)
				{
					r_R__0__Xc___0__MSc = new(this, "#Xc", 0,  ReleactionUtils.GetType("#u.#MSc"));
					r_R__0__Xc___0__MSc.SetBelong(this.instance);
				}
				return r_R__0__Xc___0__MSc;
			}
		}

		/// <summary>
		/// Void #sb(Boolean)
		/// </summary>
		protected RMethod r_R__0__sb_Boolean;
		public virtual RMethod R__0__sb_Boolean
		{
			get
			{
				if(r_R__0__sb_Boolean == null)
				{
					r_R__0__sb_Boolean = new(this, "#sb", 0, typeof(System.Boolean));
					r_R__0__sb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__sb_Boolean;
			}
		}


        public R__0__ukb() : base("#u.#ukb")
        {
        }

        public R__0__ukb(System.Object instance) : base("#u.#ukb")
		{
            SetInstance(instance);
		}

        public R__0__ukb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__ukb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual void __0__sb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__sb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


    }
}
