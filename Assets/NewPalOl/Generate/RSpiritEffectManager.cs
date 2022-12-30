using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SpiritEffectManager
	/// </summary>
    public partial class RSpiritEffectManager : RMember //
    {

		/// <summary>
		/// System.Single #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(typeof(SpiritEffectManager), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// UnityEngine.Camera #b
		/// </summary>
		protected RUnityEngine.RCamera r___0__b;
		public virtual RUnityEngine.RCamera R__0__b
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
		/// UnityEngine.Vector2 #c
		/// </summary>
		protected RUnityEngine.RVector2 r___0__c;
		public virtual RUnityEngine.RVector2 R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(this, "#c");
					r___0__c.SetBelong(this.instance);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[MyGUI.ElementBase,UnityEngine.GameObject] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUnityEngine.RGameObject> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUnityEngine.RGameObject> R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(this, "#d");
					r___0__d.SetBelong(this.instance);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// Void #Pgb(MyGUI.ElementBase, System.String, EffectType)
		/// </summary>
		protected RMethod r_R__0__Pgb_ElementBase_String_EffectType;
		public virtual RMethod R__0__Pgb_ElementBase_String_EffectType
		{
			get
			{
				if(r_R__0__Pgb_ElementBase_String_EffectType == null)
				{
					r_R__0__Pgb_ElementBase_String_EffectType = new(this, "#Pgb", 0, typeof(MyGUI.ElementBase), typeof(System.String),  ReleactionUtils.GetType("SpiritEffectManager+EffectType"));
					r_R__0__Pgb_ElementBase_String_EffectType.SetBelong(this.instance);
				}
				return r_R__0__Pgb_ElementBase_String_EffectType;
			}
		}

		/// <summary>
		/// Void #Qgb(#oU.#5bb)
		/// </summary>
		protected RMethod r_R__0__Qgb___0__5bb;
		public virtual RMethod R__0__Qgb___0__5bb
		{
			get
			{
				if(r_R__0__Qgb___0__5bb == null)
				{
					r_R__0__Qgb___0__5bb = new(this, "#Qgb", 0,  ReleactionUtils.GetType("#oU.#5bb"));
					r_R__0__Qgb___0__5bb.SetBelong(this.instance);
				}
				return r_R__0__Qgb___0__5bb;
			}
		}

		/// <summary>
		/// Void #Qgb(#oU.#5bb, System.String)
		/// </summary>
		protected RMethod r_R__0__Qgb___0__5bb_String;
		public virtual RMethod R__0__Qgb___0__5bb_String
		{
			get
			{
				if(r_R__0__Qgb___0__5bb_String == null)
				{
					r_R__0__Qgb___0__5bb_String = new(this, "#Qgb", 0,  ReleactionUtils.GetType("#oU.#5bb"), typeof(System.String));
					r_R__0__Qgb___0__5bb_String.SetBelong(this.instance);
				}
				return r_R__0__Qgb___0__5bb_String;
			}
		}

		/// <summary>
		/// Void #Qgb(#oU.#5bb, EffectType)
		/// </summary>
		protected RMethod r_R__0__Qgb___0__5bb_EffectType;
		public virtual RMethod R__0__Qgb___0__5bb_EffectType
		{
			get
			{
				if(r_R__0__Qgb___0__5bb_EffectType == null)
				{
					r_R__0__Qgb___0__5bb_EffectType = new(this, "#Qgb", 0,  ReleactionUtils.GetType("#oU.#5bb"),  ReleactionUtils.GetType("SpiritEffectManager+EffectType"));
					r_R__0__Qgb___0__5bb_EffectType.SetBelong(this.instance);
				}
				return r_R__0__Qgb___0__5bb_EffectType;
			}
		}

		/// <summary>
		/// Void #Qgb(#oU.#5bb, System.String, EffectType)
		/// </summary>
		protected RMethod r_R__0__Qgb___0__5bb_String_EffectType;
		public virtual RMethod R__0__Qgb___0__5bb_String_EffectType
		{
			get
			{
				if(r_R__0__Qgb___0__5bb_String_EffectType == null)
				{
					r_R__0__Qgb___0__5bb_String_EffectType = new(this, "#Qgb", 0,  ReleactionUtils.GetType("#oU.#5bb"), typeof(System.String),  ReleactionUtils.GetType("SpiritEffectManager+EffectType"));
					r_R__0__Qgb___0__5bb_String_EffectType.SetBelong(this.instance);
				}
				return r_R__0__Qgb___0__5bb_String_EffectType;
			}
		}

		/// <summary>
		/// Void #Rgb(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__Rgb_Object_ABLoadedArgs;
		public virtual RMethod R__0__Rgb_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__Rgb_Object_ABLoadedArgs == null)
				{
					r_R__0__Rgb_Object_ABLoadedArgs = new(this, "#Rgb", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__Rgb_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__Rgb_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void #Sgb(MyGUI.ElementBase, UnityEngine.GameObject, EffectType)
		/// </summary>
		protected RMethod r_R__0__Sgb_ElementBase_GameObject_EffectType;
		public virtual RMethod R__0__Sgb_ElementBase_GameObject_EffectType
		{
			get
			{
				if(r_R__0__Sgb_ElementBase_GameObject_EffectType == null)
				{
					r_R__0__Sgb_ElementBase_GameObject_EffectType = new(this, "#Sgb", 0, typeof(MyGUI.ElementBase), typeof(UnityEngine.GameObject),  ReleactionUtils.GetType("SpiritEffectManager+EffectType"));
					r_R__0__Sgb_ElementBase_GameObject_EffectType.SetBelong(this.instance);
				}
				return r_R__0__Sgb_ElementBase_GameObject_EffectType;
			}
		}

		/// <summary>
		/// Void #Tgb(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__Tgb_ElementBase;
		public virtual RMethod R__0__Tgb_ElementBase
		{
			get
			{
				if(r_R__0__Tgb_ElementBase == null)
				{
					r_R__0__Tgb_ElementBase = new(this, "#Tgb", 0, typeof(MyGUI.ElementBase));
					r_R__0__Tgb_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__Tgb_ElementBase;
			}
		}

		/// <summary>
		/// Void #Ugb(#oU.#5bb)
		/// </summary>
		protected RMethod r_R__0__Ugb___0__5bb;
		public virtual RMethod R__0__Ugb___0__5bb
		{
			get
			{
				if(r_R__0__Ugb___0__5bb == null)
				{
					r_R__0__Ugb___0__5bb = new(this, "#Ugb", 0,  ReleactionUtils.GetType("#oU.#5bb"));
					r_R__0__Ugb___0__5bb.SetBelong(this.instance);
				}
				return r_R__0__Ugb___0__5bb;
			}
		}

		/// <summary>
		/// Void #Vgb(MyGUI.ElementBase, Single)
		/// </summary>
		protected RMethod r_R__0__Vgb_ElementBase_Single;
		public virtual RMethod R__0__Vgb_ElementBase_Single
		{
			get
			{
				if(r_R__0__Vgb_ElementBase_Single == null)
				{
					r_R__0__Vgb_ElementBase_Single = new(this, "#Vgb", 0, typeof(MyGUI.ElementBase), typeof(System.Single));
					r_R__0__Vgb_ElementBase_Single.SetBelong(this.instance);
				}
				return r_R__0__Vgb_ElementBase_Single;
			}
		}

		/// <summary>
		/// Void #Wgb(#oU.#5bb, Single)
		/// </summary>
		protected RMethod r_R__0__Wgb___0__5bb_Single;
		public virtual RMethod R__0__Wgb___0__5bb_Single
		{
			get
			{
				if(r_R__0__Wgb___0__5bb_Single == null)
				{
					r_R__0__Wgb___0__5bb_Single = new(this, "#Wgb", 0,  ReleactionUtils.GetType("#oU.#5bb"), typeof(System.Single));
					r_R__0__Wgb___0__5bb_Single.SetBelong(this.instance);
				}
				return r_R__0__Wgb___0__5bb_Single;
			}
		}

		/// <summary>
		/// Void #Xgb(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__Xgb_ElementBase;
		public virtual RMethod R__0__Xgb_ElementBase
		{
			get
			{
				if(r_R__0__Xgb_ElementBase == null)
				{
					r_R__0__Xgb_ElementBase = new(this, "#Xgb", 0, typeof(MyGUI.ElementBase));
					r_R__0__Xgb_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__Xgb_ElementBase;
			}
		}

		/// <summary>
		/// Void #Ygb(#oU.#5bb)
		/// </summary>
		protected RMethod r_R__0__Ygb___0__5bb;
		public virtual RMethod R__0__Ygb___0__5bb
		{
			get
			{
				if(r_R__0__Ygb___0__5bb == null)
				{
					r_R__0__Ygb___0__5bb = new(this, "#Ygb", 0,  ReleactionUtils.GetType("#oU.#5bb"));
					r_R__0__Ygb___0__5bb.SetBelong(this.instance);
				}
				return r_R__0__Ygb___0__5bb;
			}
		}

		/// <summary>
		/// Void Clear()
		/// </summary>
		protected RMethod r_RClear;
		public virtual RMethod RClear
		{
			get
			{
				if(r_RClear == null)
				{
					r_RClear = new(this, "Clear", 0);
					r_RClear.SetBelong(this.instance);
				}
				return r_RClear;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject GetElemEffect(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_RGetElemEffect_ElementBase;
		public virtual RMethod RGetElemEffect_ElementBase
		{
			get
			{
				if(r_RGetElemEffect_ElementBase == null)
				{
					r_RGetElemEffect_ElementBase = new(this, "GetElemEffect", 0, typeof(MyGUI.ElementBase));
					r_RGetElemEffect_ElementBase.SetBelong(this.instance);
				}
				return r_RGetElemEffect_ElementBase;
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


        public RSpiritEffectManager() : base("SpiritEffectManager")
        {
        }

        public RSpiritEffectManager(System.Object instance) : base("SpiritEffectManager")
		{
            SetInstance(instance);
		}

        public RSpiritEffectManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSpiritEffectManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }








        public virtual void __0__Tgb(MyGUI.ElementBase  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem};
            var ___result = R__0__Tgb_ElementBase.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Vgb(MyGUI.ElementBase  @elem, System.Single  @moveTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem, @moveTime};
            var ___result = R__0__Vgb_ElementBase_Single.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Xgb(MyGUI.ElementBase  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem};
            var ___result = R__0__Xgb_ElementBase.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Clear()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClear.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GameObject GetElemEffect(MyGUI.ElementBase  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem};
            var ___result = RGetElemEffect_ElementBase.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
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
