using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MeleeManager
	/// </summary>
    public partial class RMeleeManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,MeleeReward] m_RewardDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RMeleeReward> r_m_RewardDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RMeleeReward> Rm_RewardDict
		{
			get
			{
				if(r_m_RewardDict == null)
				{
					r_m_RewardDict = new(this, "m_RewardDict");
					r_m_RewardDict.SetBelong(this.instance);
				}
				return r_m_RewardDict;
			}
		}

		/// <summary>
		/// Message.SCNetMsgMeleeLastChampion m_MeleeChampionMsg
		/// </summary>
		protected RMessage.RSCNetMsgMeleeLastChampion r_m_MeleeChampionMsg;
		public virtual RMessage.RSCNetMsgMeleeLastChampion Rm_MeleeChampionMsg
		{
			get
			{
				if(r_m_MeleeChampionMsg == null)
				{
					r_m_MeleeChampionMsg = new(this, "m_MeleeChampionMsg");
					r_m_MeleeChampionMsg.SetBelong(this.instance);
				}
				return r_m_MeleeChampionMsg;
			}
		}

		/// <summary>
		/// GameDefineType.ID MELEE_MAP_ID
		/// </summary>
		protected RGameDefineType.RID r_MELEE_MAP_ID;
		public virtual RGameDefineType.RID RMELEE_MAP_ID
		{
			get
			{
				if(r_MELEE_MAP_ID == null)
				{
					r_MELEE_MAP_ID = new(this, "MELEE_MAP_ID");
					r_MELEE_MAP_ID.SetBelong(this.instance);
				}
				return r_MELEE_MAP_ID;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_UIEffectObj
		/// </summary>
		protected RUnityEngine.RGameObject r_m_UIEffectObj;
		public virtual RUnityEngine.RGameObject Rm_UIEffectObj
		{
			get
			{
				if(r_m_UIEffectObj == null)
				{
					r_m_UIEffectObj = new(this, "m_UIEffectObj");
					r_m_UIEffectObj.SetBelong(this.instance);
				}
				return r_m_UIEffectObj;
			}
		}

		/// <summary>
		/// MyGUIMeleeWnd+ChampionMsg m_ChampionMsg
		/// </summary>
		protected RMyGUIMeleeWnd.RChampionMsg r_m_ChampionMsg;
		public virtual RMyGUIMeleeWnd.RChampionMsg Rm_ChampionMsg
		{
			get
			{
				if(r_m_ChampionMsg == null)
				{
					r_m_ChampionMsg = new(this, "m_ChampionMsg");
					r_m_ChampionMsg.SetBelong(this.instance);
				}
				return r_m_ChampionMsg;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_ChampionModelObj
		/// </summary>
		protected RUnityEngine.RGameObject r_m_ChampionModelObj;
		public virtual RUnityEngine.RGameObject Rm_ChampionModelObj
		{
			get
			{
				if(r_m_ChampionModelObj == null)
				{
					r_m_ChampionModelObj = new(this, "m_ChampionModelObj");
					r_m_ChampionModelObj.SetBelong(this.instance);
				}
				return r_m_ChampionModelObj;
			}
		}

		/// <summary>
		/// AvatarController+weaponInfo wInfo
		/// </summary>
		protected RAvatarController.RweaponInfo r_wInfo;
		public virtual RAvatarController.RweaponInfo RwInfo
		{
			get
			{
				if(r_wInfo == null)
				{
					r_wInfo = new(this, "wInfo");
					r_wInfo.SetBelong(this.instance);
				}
				return r_wInfo;
			}
		}

		/// <summary>
		/// Void Initial()
		/// </summary>
		protected RMethod r_RInitial;
		public virtual RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(this, "Initial", 0);
					r_RInitial.SetBelong(this.instance);
				}
				return r_RInitial;
			}
		}

		/// <summary>
		/// Void OnMeleeSignupTime(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnMeleeSignupTime_Object___0__Isb;
		public virtual RMethod ROnMeleeSignupTime_Object___0__Isb
		{
			get
			{
				if(r_ROnMeleeSignupTime_Object___0__Isb == null)
				{
					r_ROnMeleeSignupTime_Object___0__Isb = new(this, "OnMeleeSignupTime", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnMeleeSignupTime_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnMeleeSignupTime_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnMeleeState(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnMeleeState_Object___0__Isb;
		public virtual RMethod ROnMeleeState_Object___0__Isb
		{
			get
			{
				if(r_ROnMeleeState_Object___0__Isb == null)
				{
					r_ROnMeleeState_Object___0__Isb = new(this, "OnMeleeState", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnMeleeState_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnMeleeState_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnLoadMeleeRewardConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadMeleeRewardConfig_Object;
		public virtual RMethod ROnLoadMeleeRewardConfig_Object
		{
			get
			{
				if(r_ROnLoadMeleeRewardConfig_Object == null)
				{
					r_ROnLoadMeleeRewardConfig_Object = new(this, "OnLoadMeleeRewardConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadMeleeRewardConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadMeleeRewardConfig_Object;
			}
		}

		/// <summary>
		/// MeleeReward GetReward(Int32)
		/// </summary>
		protected RMethod r_RGetReward_Int32;
		public virtual RMethod RGetReward_Int32
		{
			get
			{
				if(r_RGetReward_Int32 == null)
				{
					r_RGetReward_Int32 = new(this, "GetReward", 0, typeof(System.Int32));
					r_RGetReward_Int32.SetBelong(this.instance);
				}
				return r_RGetReward_Int32;
			}
		}

		/// <summary>
		/// Void OnMeleeWaitTime(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnMeleeWaitTime_Object___0__Isb;
		public virtual RMethod ROnMeleeWaitTime_Object___0__Isb
		{
			get
			{
				if(r_ROnMeleeWaitTime_Object___0__Isb == null)
				{
					r_ROnMeleeWaitTime_Object___0__Isb = new(this, "OnMeleeWaitTime", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnMeleeWaitTime_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnMeleeWaitTime_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnMeleeResult(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnMeleeResult_Object___0__Isb;
		public virtual RMethod ROnMeleeResult_Object___0__Isb
		{
			get
			{
				if(r_ROnMeleeResult_Object___0__Isb == null)
				{
					r_ROnMeleeResult_Object___0__Isb = new(this, "OnMeleeResult", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnMeleeResult_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnMeleeResult_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void _OnMeleeResult(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R_OnMeleeResult_Object___0__n6c;
		public virtual RMethod R_OnMeleeResult_Object___0__n6c
		{
			get
			{
				if(r_R_OnMeleeResult_Object___0__n6c == null)
				{
					r_R_OnMeleeResult_Object___0__n6c = new(this, "_OnMeleeResult", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R_OnMeleeResult_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R_OnMeleeResult_Object___0__n6c;
			}
		}

		/// <summary>
		/// Message.SCNetMsgMeleeLastChampion GetChampionMsg()
		/// </summary>
		protected RMethod r_RGetChampionMsg;
		public virtual RMethod RGetChampionMsg
		{
			get
			{
				if(r_RGetChampionMsg == null)
				{
					r_RGetChampionMsg = new(this, "GetChampionMsg", 0);
					r_RGetChampionMsg.SetBelong(this.instance);
				}
				return r_RGetChampionMsg;
			}
		}

		/// <summary>
		/// Void OnMeleeChampionInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnMeleeChampionInfo_Object___0__Isb;
		public virtual RMethod ROnMeleeChampionInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnMeleeChampionInfo_Object___0__Isb == null)
				{
					r_ROnMeleeChampionInfo_Object___0__Isb = new(this, "OnMeleeChampionInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnMeleeChampionInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnMeleeChampionInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnMeleeCurrentInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnMeleeCurrentInfo_Object___0__Isb;
		public virtual RMethod ROnMeleeCurrentInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnMeleeCurrentInfo_Object___0__Isb == null)
				{
					r_ROnMeleeCurrentInfo_Object___0__Isb = new(this, "OnMeleeCurrentInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnMeleeCurrentInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnMeleeCurrentInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Boolean IsInMeleeMap()
		/// </summary>
		protected RMethod r_RIsInMeleeMap;
		public virtual RMethod RIsInMeleeMap
		{
			get
			{
				if(r_RIsInMeleeMap == null)
				{
					r_RIsInMeleeMap = new(this, "IsInMeleeMap", 0);
					r_RIsInMeleeMap.SetBelong(this.instance);
				}
				return r_RIsInMeleeMap;
			}
		}

		/// <summary>
		/// Void LoadUIEffect()
		/// </summary>
		protected RMethod r_RLoadUIEffect;
		public virtual RMethod RLoadUIEffect
		{
			get
			{
				if(r_RLoadUIEffect == null)
				{
					r_RLoadUIEffect = new(this, "LoadUIEffect", 0);
					r_RLoadUIEffect.SetBelong(this.instance);
				}
				return r_RLoadUIEffect;
			}
		}

		/// <summary>
		/// Void OnLoadUIEffect(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadUIEffect_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadUIEffect_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadUIEffect_Object_ABLoadedArgs == null)
				{
					r_ROnLoadUIEffect_Object_ABLoadedArgs = new(this, "OnLoadUIEffect", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadUIEffect_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadUIEffect_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void LoadChampionModel()
		/// </summary>
		protected RMethod r_RLoadChampionModel;
		public virtual RMethod RLoadChampionModel
		{
			get
			{
				if(r_RLoadChampionModel == null)
				{
					r_RLoadChampionModel = new(this, "LoadChampionModel", 0);
					r_RLoadChampionModel.SetBelong(this.instance);
				}
				return r_RLoadChampionModel;
			}
		}

		/// <summary>
		/// Void OnLoadedCharacter(System.Object, CGLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadedCharacter_Object_CGLoadedArgs;
		public virtual RMethod ROnLoadedCharacter_Object_CGLoadedArgs
		{
			get
			{
				if(r_ROnLoadedCharacter_Object_CGLoadedArgs == null)
				{
					r_ROnLoadedCharacter_Object_CGLoadedArgs = new(this, "OnLoadedCharacter", 0, typeof(System.Object),  ReleactionUtils.GetType("CharacterDownloader+CGLoadedArgs"));
					r_ROnLoadedCharacter_Object_CGLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadedCharacter_Object_CGLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadStarEffect(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadStarEffect_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadStarEffect_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadStarEffect_Object_ABLoadedArgs == null)
				{
					r_ROnLoadStarEffect_Object_ABLoadedArgs = new(this, "OnLoadStarEffect", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadStarEffect_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadStarEffect_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnGetWeaponRes(System.Object, UnityEngine.GameObject, UnityEngine.GameObject, System.Object)
		/// </summary>
		protected RMethod r_ROnGetWeaponRes_Object_GameObject_GameObject_Object;
		public virtual RMethod ROnGetWeaponRes_Object_GameObject_GameObject_Object
		{
			get
			{
				if(r_ROnGetWeaponRes_Object_GameObject_GameObject_Object == null)
				{
					r_ROnGetWeaponRes_Object_GameObject_GameObject_Object = new(this, "OnGetWeaponRes", 0, typeof(System.Object), typeof(UnityEngine.GameObject), typeof(UnityEngine.GameObject), typeof(System.Object));
					r_ROnGetWeaponRes_Object_GameObject_GameObject_Object.SetBelong(this.instance);
				}
				return r_ROnGetWeaponRes_Object_GameObject_GameObject_Object;
			}
		}

		/// <summary>
		/// Void OnPutWeapon(UnityEngine.GameObject, UnityEngine.GameObject, System.String)
		/// </summary>
		protected RMethod r_ROnPutWeapon_GameObject_GameObject_String;
		public virtual RMethod ROnPutWeapon_GameObject_GameObject_String
		{
			get
			{
				if(r_ROnPutWeapon_GameObject_GameObject_String == null)
				{
					r_ROnPutWeapon_GameObject_GameObject_String = new(this, "OnPutWeapon", 0, typeof(UnityEngine.GameObject), typeof(UnityEngine.GameObject), typeof(System.String));
					r_ROnPutWeapon_GameObject_GameObject_String.SetBelong(this.instance);
				}
				return r_ROnPutWeapon_GameObject_GameObject_String;
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


        public RMeleeManager() : base("MeleeManager")
        {
        }

        public RMeleeManager(System.Object instance) : base("MeleeManager")
		{
            SetInstance(instance);
		}

        public RMeleeManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeleeManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void OnLoadMeleeRewardConfig(UnityEngine.Object  @textasset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textasset};
            var ___result = ROnLoadMeleeRewardConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual MeleeReward GetReward(System.Int32  @rank)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rank};
            var ___result = RGetReward_Int32.Invoke(___genericsType, ___parameters);

            return (MeleeReward)___result;
        }





        public virtual System.Object GetChampionMsg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetChampionMsg.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual System.Boolean IsInMeleeMap()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInMeleeMap.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void LoadUIEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadUIEffect.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void LoadChampionModel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadChampionModel.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void OnGetWeaponRes(System.Object  @sender, UnityEngine.GameObject  @weapon0, UnityEngine.GameObject  @weapon1, System.Object  @tmpObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @weapon0, @weapon1, @tmpObj};
            var ___result = ROnGetWeaponRes_Object_GameObject_GameObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPutWeapon(UnityEngine.GameObject  @character, UnityEngine.GameObject  @weapon, System.String  @placename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@character, @weapon, @placename};
            var ___result = ROnPutWeapon_GameObject_GameObject_String.Invoke(___genericsType, ___parameters);

            
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
