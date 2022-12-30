using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__Pfb
{
	/// <summary>
	/// #Pfb.#Bsb
	/// </summary>
    public partial class R__0__Bsb : RMember //
    {

		/// <summary>
		/// Void #Asb()
		/// </summary>
		protected RMethod r_R__0__Asb;
		public virtual RMethod R__0__Asb
		{
			get
			{
				if(r_R__0__Asb == null)
				{
					r_R__0__Asb = new(this, "#Asb", 0);
					r_R__0__Asb.SetBelong(this.instance);
				}
				return r_R__0__Asb;
			}
		}


        public R__0__Bsb() : base("#Pfb.#Bsb")
        {
        }

        public R__0__Bsb(System.Object instance) : base("#Pfb.#Bsb")
		{
            SetInstance(instance);
		}

        public R__0__Bsb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Bsb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__Asb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Asb.Invoke(___genericsType, ___parameters);

            
        }


    }
}
