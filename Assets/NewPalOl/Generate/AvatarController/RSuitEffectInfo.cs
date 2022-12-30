using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RAvatarController
{
	
	/// <summary>
	/// AvatarController+SuitEffectInfo
	/// </summary>
    public partial class RSuitEffectInfo : RMember //
    {

		/// <summary>
		/// System.String s_EmbedSuitEffect
		/// </summary>
		protected RField r_s_EmbedSuitEffect;
		public virtual RField Rs_EmbedSuitEffect
		{
			get
			{
				if(r_s_EmbedSuitEffect == null)
				{
					r_s_EmbedSuitEffect = new(this, "s_EmbedSuitEffect");
					r_s_EmbedSuitEffect.SetBelong(this.instance);
				}
				return r_s_EmbedSuitEffect;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject g_EmbedSuitEffect
		/// </summary>
		protected RUnityEngine.RGameObject r_g_EmbedSuitEffect;
		public virtual RUnityEngine.RGameObject Rg_EmbedSuitEffect
		{
			get
			{
				if(r_g_EmbedSuitEffect == null)
				{
					r_g_EmbedSuitEffect = new(this, "g_EmbedSuitEffect");
					r_g_EmbedSuitEffect.SetBelong(this.instance);
				}
				return r_g_EmbedSuitEffect;
			}
		}

		/// <summary>
		/// System.String s_StarSuitEffect
		/// </summary>
		protected RField r_s_StarSuitEffect;
		public virtual RField Rs_StarSuitEffect
		{
			get
			{
				if(r_s_StarSuitEffect == null)
				{
					r_s_StarSuitEffect = new(this, "s_StarSuitEffect");
					r_s_StarSuitEffect.SetBelong(this.instance);
				}
				return r_s_StarSuitEffect;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject g_StarSuiEffect
		/// </summary>
		protected RUnityEngine.RGameObject r_g_StarSuiEffect;
		public virtual RUnityEngine.RGameObject Rg_StarSuiEffect
		{
			get
			{
				if(r_g_StarSuiEffect == null)
				{
					r_g_StarSuiEffect = new(this, "g_StarSuiEffect");
					r_g_StarSuiEffect.SetBelong(this.instance);
				}
				return r_g_StarSuiEffect;
			}
		}

		/// <summary>
		/// System.String s_GodSuitEffect
		/// </summary>
		protected RField r_s_GodSuitEffect;
		public virtual RField Rs_GodSuitEffect
		{
			get
			{
				if(r_s_GodSuitEffect == null)
				{
					r_s_GodSuitEffect = new(this, "s_GodSuitEffect");
					r_s_GodSuitEffect.SetBelong(this.instance);
				}
				return r_s_GodSuitEffect;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject g_GodSuiEffect
		/// </summary>
		protected RUnityEngine.RGameObject r_g_GodSuiEffect;
		public virtual RUnityEngine.RGameObject Rg_GodSuiEffect
		{
			get
			{
				if(r_g_GodSuiEffect == null)
				{
					r_g_GodSuiEffect = new(this, "g_GodSuiEffect");
					r_g_GodSuiEffect.SetBelong(this.instance);
				}
				return r_g_GodSuiEffect;
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


        public RSuitEffectInfo() : base("AvatarController+SuitEffectInfo")
        {
        }

        public RSuitEffectInfo(System.Object instance) : base("AvatarController+SuitEffectInfo")
		{
            SetInstance(instance);
		}

        public RSuitEffectInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSuitEffectInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}