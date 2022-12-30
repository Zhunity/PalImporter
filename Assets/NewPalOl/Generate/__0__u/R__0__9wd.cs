using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#9wd
	/// </summary>
    public partial class R__0__9wd : RMember //
    {

		/// <summary>
		/// Boolean #Ywd(System.String)
		/// </summary>
		protected RMethod r_R__0__Ywd_String;
		public virtual RMethod R__0__Ywd_String
		{
			get
			{
				if(r_R__0__Ywd_String == null)
				{
					r_R__0__Ywd_String = new(this, "#Ywd", 0, typeof(System.String));
					r_R__0__Ywd_String.SetBelong(this.instance);
				}
				return r_R__0__Ywd_String;
			}
		}

		/// <summary>
		/// Void #Zwd(System.String)
		/// </summary>
		protected RMethod r_R__0__Zwd_String;
		public virtual RMethod R__0__Zwd_String
		{
			get
			{
				if(r_R__0__Zwd_String == null)
				{
					r_R__0__Zwd_String = new(this, "#Zwd", 0, typeof(System.String));
					r_R__0__Zwd_String.SetBelong(this.instance);
				}
				return r_R__0__Zwd_String;
			}
		}


        public R__0__9wd() : base("#u.#9wd")
        {
        }

        public R__0__9wd(System.Object instance) : base("#u.#9wd")
		{
            SetInstance(instance);
		}

        public R__0__9wd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__9wd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean __0__Ywd(System.String  @stateName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stateName};
            var ___result = R__0__Ywd_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__Zwd(System.String  @stateName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stateName};
            var ___result = R__0__Zwd_String.Invoke(___genericsType, ___parameters);

            
        }


    }
}
