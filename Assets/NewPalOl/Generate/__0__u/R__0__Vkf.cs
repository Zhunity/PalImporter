using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Vkf
	/// </summary>
    public partial class R__0__Vkf : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,LevelUpConfig] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RLevelUpConfig> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RLevelUpConfig> R__0__a
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.List`1[LevelUpConfig]] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RLevelUpConfig>> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RLevelUpConfig>> R__0__b
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,LevelUpRewardConfig] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RLevelUpRewardConfig> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RLevelUpRewardConfig> R__0__c
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
		/// Void OnLoadLevelUpConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadLevelUpConfig_Object;
		public virtual RMethod ROnLoadLevelUpConfig_Object
		{
			get
			{
				if(r_ROnLoadLevelUpConfig_Object == null)
				{
					r_ROnLoadLevelUpConfig_Object = new(this, "OnLoadLevelUpConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadLevelUpConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadLevelUpConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadLevelUpRewardConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadLevelUpRewardConfig_Object;
		public virtual RMethod ROnLoadLevelUpRewardConfig_Object
		{
			get
			{
				if(r_ROnLoadLevelUpRewardConfig_Object == null)
				{
					r_ROnLoadLevelUpRewardConfig_Object = new(this, "OnLoadLevelUpRewardConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadLevelUpRewardConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadLevelUpRewardConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[LevelUpConfig] #Nof(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Nof_ID;
		public virtual RMethod R__0__Nof_ID
		{
			get
			{
				if(r_R__0__Nof_ID == null)
				{
					r_R__0__Nof_ID = new(this, "#Nof", 0, typeof(GameDefineType.ID));
					r_R__0__Nof_ID.SetBelong(this.instance);
				}
				return r_R__0__Nof_ID;
			}
		}

		/// <summary>
		/// LevelUpRewardConfig #Oof(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Oof_ID;
		public virtual RMethod R__0__Oof_ID
		{
			get
			{
				if(r_R__0__Oof_ID == null)
				{
					r_R__0__Oof_ID = new(this, "#Oof", 0, typeof(GameDefineType.ID));
					r_R__0__Oof_ID.SetBelong(this.instance);
				}
				return r_R__0__Oof_ID;
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


        public R__0__Vkf() : base("#u.#Vkf")
        {
        }

        public R__0__Vkf(System.Object instance) : base("#u.#Vkf")
		{
            SetInstance(instance);
		}

        public R__0__Vkf(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Vkf(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadLevelUpConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadLevelUpConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadLevelUpRewardConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadLevelUpRewardConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<LevelUpConfig> __0__Nof(GameDefineType.ID  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = R__0__Nof_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<LevelUpConfig>)___result;
        }


        public virtual LevelUpRewardConfig __0__Oof(GameDefineType.ID  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = R__0__Oof_ID.Invoke(___genericsType, ___parameters);

            return (LevelUpRewardConfig)___result;
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
