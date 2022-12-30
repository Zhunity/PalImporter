using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#JOc
	/// </summary>
    public partial class R__0__JOc : RMember //
    {

		/// <summary>
		/// Void #ZR(MountPetConfig, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__ZR_MountPetConfig_GameObject;
		public virtual RMethod R__0__ZR_MountPetConfig_GameObject
		{
			get
			{
				if(r_R__0__ZR_MountPetConfig_GameObject == null)
				{
					r_R__0__ZR_MountPetConfig_GameObject = new(this, "#ZR", 0, typeof(MountPetConfig), typeof(UnityEngine.GameObject));
					r_R__0__ZR_MountPetConfig_GameObject.SetBelong(this.instance);
				}
				return r_R__0__ZR_MountPetConfig_GameObject;
			}
		}


        public R__0__JOc() : base("#u.#JOc")
        {
        }

        public R__0__JOc(System.Object instance) : base("#u.#JOc")
		{
            SetInstance(instance);
		}

        public R__0__JOc(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__JOc(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__ZR(MountPetConfig  @horse, UnityEngine.GameObject  @mod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@horse, @mod};
            var ___result = R__0__ZR_MountPetConfig_GameObject.Invoke(___genericsType, ___parameters);

            
        }


    }
}
