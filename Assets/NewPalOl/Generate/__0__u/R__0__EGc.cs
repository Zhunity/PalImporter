using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#EGc
	/// </summary>
    public partial class R__0__EGc : RMember //
    {

		/// <summary>
		/// Void #2uc()
		/// </summary>
		protected RMethod r_R__0__2uc;
		public virtual RMethod R__0__2uc
		{
			get
			{
				if(r_R__0__2uc == null)
				{
					r_R__0__2uc = new(this, "#2uc", 0);
					r_R__0__2uc.SetBelong(this.instance);
				}
				return r_R__0__2uc;
			}
		}

		/// <summary>
		/// Void #3uc(System.String)
		/// </summary>
		protected RMethod r_R__0__3uc_String;
		public virtual RMethod R__0__3uc_String
		{
			get
			{
				if(r_R__0__3uc_String == null)
				{
					r_R__0__3uc_String = new(this, "#3uc", 0, typeof(System.String));
					r_R__0__3uc_String.SetBelong(this.instance);
				}
				return r_R__0__3uc_String;
			}
		}


        public R__0__EGc() : base("#u.#EGc")
        {
        }

        public R__0__EGc(System.Object instance) : base("#u.#EGc")
		{
            SetInstance(instance);
		}

        public R__0__EGc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__EGc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__2uc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__2uc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__3uc(System.String  @title)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@title};
            var ___result = R__0__3uc_String.Invoke(___genericsType, ___parameters);

            
        }


    }
}
