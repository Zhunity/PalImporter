using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#TNi
	/// </summary>
    public partial class R__0__TNi : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.Dictionary`2[System.String,System.Boolean]] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RField, RField>> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RField, RField>> R__0__a
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.Dictionary`2[System.String,UnityEngine.AnimationClip]] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RAnimationClip>> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RAnimationClip>> R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// Boolean isAnimationReource
		/// </summary>
		protected RProperty r_R__0__NNi;
		public virtual RProperty R__0__NNi
		{
			get
			{
				if(r_R__0__NNi == null)
				{
					r_R__0__NNi = new(this, "isAnimationReource", -1);
					r_R__0__NNi.SetBelong(this.instance);
				}
				return r_R__0__NNi;
			}
		}

		/// <summary>
		/// Boolean #Mhj(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__Mhj_ID_String;
		public virtual RMethod R__0__Mhj_ID_String
		{
			get
			{
				if(r_R__0__Mhj_ID_String == null)
				{
					r_R__0__Mhj_ID_String = new(this, "#Mhj", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__Mhj_ID_String.SetBelong(this.instance);
				}
				return r_R__0__Mhj_ID_String;
			}
		}

		/// <summary>
		/// Void #ONi(GameDefineType.ID, System.String, GameDefineType.ID, UnityEngine.Animation)
		/// </summary>
		protected RMethod r_R__0__ONi_ID_String_ID_Animation;
		public virtual RMethod R__0__ONi_ID_String_ID_Animation
		{
			get
			{
				if(r_R__0__ONi_ID_String_ID_Animation == null)
				{
					r_R__0__ONi_ID_String_ID_Animation = new(this, "#ONi", 0, typeof(GameDefineType.ID), typeof(System.String), typeof(GameDefineType.ID), typeof(UnityEngine.Animation));
					r_R__0__ONi_ID_String_ID_Animation.SetBelong(this.instance);
				}
				return r_R__0__ONi_ID_String_ID_Animation;
			}
		}

		/// <summary>
		/// Void OnAniClipDownLoad(#u.#MNi, UnityEngine.AnimationClip)
		/// </summary>
		protected RMethod r_ROnAniClipDownLoad___0__MNi_AnimationClip;
		public virtual RMethod ROnAniClipDownLoad___0__MNi_AnimationClip
		{
			get
			{
				if(r_ROnAniClipDownLoad___0__MNi_AnimationClip == null)
				{
					r_ROnAniClipDownLoad___0__MNi_AnimationClip = new(this, "OnAniClipDownLoad", 0,  ReleactionUtils.GetType("#u.#MNi"), typeof(UnityEngine.AnimationClip));
					r_ROnAniClipDownLoad___0__MNi_AnimationClip.SetBelong(this.instance);
				}
				return r_ROnAniClipDownLoad___0__MNi_AnimationClip;
			}
		}

		/// <summary>
		/// Boolean #QNi(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__QNi_ID_String;
		public virtual RMethod R__0__QNi_ID_String
		{
			get
			{
				if(r_R__0__QNi_ID_String == null)
				{
					r_R__0__QNi_ID_String = new(this, "#QNi", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__QNi_ID_String.SetBelong(this.instance);
				}
				return r_R__0__QNi_ID_String;
			}
		}

		/// <summary>
		/// Void #ONi(GameDefineType.ID, System.String, GameDefineType.ID, #u.#POi, UnityEngine.Object)
		/// </summary>
		protected RMethod r_R__0__ONi_ID_String_ID___0__POi_Object;
		public virtual RMethod R__0__ONi_ID_String_ID___0__POi_Object
		{
			get
			{
				if(r_R__0__ONi_ID_String_ID___0__POi_Object == null)
				{
					r_R__0__ONi_ID_String_ID___0__POi_Object = new(this, "#ONi", 0, typeof(GameDefineType.ID), typeof(System.String), typeof(GameDefineType.ID),  ReleactionUtils.GetType("#u.#POi"), typeof(UnityEngine.Object));
					r_R__0__ONi_ID_String_ID___0__POi_Object.SetBelong(this.instance);
				}
				return r_R__0__ONi_ID_String_ID___0__POi_Object;
			}
		}

		/// <summary>
		/// Void #RNi(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__RNi_Object_ABLoadedArgs;
		public virtual RMethod R__0__RNi_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__RNi_Object_ABLoadedArgs == null)
				{
					r_R__0__RNi_Object_ABLoadedArgs = new(this, "#RNi", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__RNi_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__RNi_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// System.String #SNi(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__SNi_ID_String;
		public virtual RMethod R__0__SNi_ID_String
		{
			get
			{
				if(r_R__0__SNi_ID_String == null)
				{
					r_R__0__SNi_ID_String = new(this, "#SNi", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__SNi_ID_String.SetBelong(this.instance);
				}
				return r_R__0__SNi_ID_String;
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


        public R__0__TNi() : base("#u.#TNi")
        {
        }

        public R__0__TNi(System.Object instance) : base("#u.#TNi")
		{
            SetInstance(instance);
		}

        public R__0__TNi(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__TNi(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean __0__Mhj(GameDefineType.ID  @resourceID, System.String  @aniName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceID, @aniName};
            var ___result = R__0__Mhj_ID_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__ONi(GameDefineType.ID  @resourceID, System.String  @aniName, GameDefineType.ID  @sceneID, UnityEngine.Animation  @ani)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceID, @aniName, @sceneID, @ani};
            var ___result = R__0__ONi_ID_String_ID_Animation.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean __0__QNi(GameDefineType.ID  @resourceID, System.String  @aniName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceID, @aniName};
            var ___result = R__0__QNi_ID_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual System.String __0__SNi(GameDefineType.ID  @resourceID, System.String  @aniName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resourceID, @aniName};
            var ___result = R__0__SNi_ID_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
