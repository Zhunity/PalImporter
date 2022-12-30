using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#BGd
	/// </summary>
    public partial class R__0__BGd : RMember //
    {

		/// <summary>
		/// Void #iT(System.Object)
		/// </summary>
		protected RMethod r_R__0__iT_Object;
		public virtual RMethod R__0__iT_Object
		{
			get
			{
				if(r_R__0__iT_Object == null)
				{
					r_R__0__iT_Object = new(this, "#iT", 0, typeof(System.Object));
					r_R__0__iT_Object.SetBelong(this.instance);
				}
				return r_R__0__iT_Object;
			}
		}


        public R__0__BGd() : base("#u.#BGd")
        {
        }

        public R__0__BGd(System.Object instance) : base("#u.#BGd")
		{
            SetInstance(instance);
		}

        public R__0__BGd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__BGd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__iT(System.Object  @showData)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@showData};
            var ___result = R__0__iT_Object.Invoke(___genericsType, ___parameters);

            
        }


    }
}
