using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#cGc
	/// </summary>
    public partial class R__0__cGc : RMember //
    {

		/// <summary>
		/// Void #bGc(Int32)
		/// </summary>
		protected RMethod r_R__0__bGc_Int32;
		public virtual RMethod R__0__bGc_Int32
		{
			get
			{
				if(r_R__0__bGc_Int32 == null)
				{
					r_R__0__bGc_Int32 = new(this, "#bGc", 0, typeof(System.Int32));
					r_R__0__bGc_Int32.SetBelong(this.instance);
				}
				return r_R__0__bGc_Int32;
			}
		}


        public R__0__cGc() : base("#u.#cGc")
        {
        }

        public R__0__cGc(System.Object instance) : base("#u.#cGc")
		{
            SetInstance(instance);
		}

        public R__0__cGc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__cGc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__bGc(System.Int32  @faceId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@faceId};
            var ___result = R__0__bGc_Int32.Invoke(___genericsType, ___parameters);

            
        }


    }
}
