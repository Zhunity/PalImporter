using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// BattleAniEffectConfig
	/// </summary>
    public partial class RBattleAniEffectConfig : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,EffectHold] mEffectLib
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, REffectHold> r_mEffectLib;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, REffectHold> RmEffectLib
		{
			get
			{
				if(r_mEffectLib == null)
				{
					r_mEffectLib = new(this, "mEffectLib");
					r_mEffectLib.SetBelong(this.instance);
				}
				return r_mEffectLib;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.Dictionary`2[GameDefineType.ID,CareerSkillConfigItem]] mSkillConfig
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCareerSkillConfigItem>> r_mSkillConfig;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCareerSkillConfigItem>> RmSkillConfig
		{
			get
			{
				if(r_mSkillConfig == null)
				{
					r_mSkillConfig = new(this, "mSkillConfig");
					r_mSkillConfig.SetBelong(this.instance);
				}
				return r_mSkillConfig;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,CareerBattleAttribute] mCareerBattleAttribute
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCareerBattleAttribute> r_mCareerBattleAttribute;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCareerBattleAttribute> RmCareerBattleAttribute
		{
			get
			{
				if(r_mCareerBattleAttribute == null)
				{
					r_mCareerBattleAttribute = new(this, "mCareerBattleAttribute");
					r_mCareerBattleAttribute.SetBelong(this.instance);
				}
				return r_mCareerBattleAttribute;
			}
		}

		/// <summary>
		/// System.String BattleAniEffectConfigTextAsset
		/// </summary>
		protected RField r_BattleAniEffectConfigTextAsset;
		public virtual RField RBattleAniEffectConfigTextAsset
		{
			get
			{
				if(r_BattleAniEffectConfigTextAsset == null)
				{
					r_BattleAniEffectConfigTextAsset = new(this, "BattleAniEffectConfigTextAsset");
					r_BattleAniEffectConfigTextAsset.SetBelong(this.instance);
				}
				return r_BattleAniEffectConfigTextAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Type] mEffectMap
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RType> r_mEffectMap;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RType> RmEffectMap
		{
			get
			{
				if(r_mEffectMap == null)
				{
					r_mEffectMap = new(this, "mEffectMap");
					r_mEffectMap.SetBelong(this.instance);
				}
				return r_mEffectMap;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,BuffEffectHold] mBuffEffectLib
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RBuffEffectHold> r_mBuffEffectLib;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RBuffEffectHold> RmBuffEffectLib
		{
			get
			{
				if(r_mBuffEffectLib == null)
				{
					r_mBuffEffectLib = new(this, "mBuffEffectLib");
					r_mBuffEffectLib.SetBelong(this.instance);
				}
				return r_mBuffEffectLib;
			}
		}

		/// <summary>
		/// Void OnLoadEffect(System.String, System.String, UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadEffect_String_String_Object;
		public virtual RMethod ROnLoadEffect_String_String_Object
		{
			get
			{
				if(r_ROnLoadEffect_String_String_Object == null)
				{
					r_ROnLoadEffect_String_String_Object = new(this, "OnLoadEffect", 0, typeof(System.String), typeof(System.String), typeof(UnityEngine.Object));
					r_ROnLoadEffect_String_String_Object.SetBelong(this.instance);
				}
				return r_ROnLoadEffect_String_String_Object;
			}
		}

		/// <summary>
		/// Void DebugEffect()
		/// </summary>
		protected RMethod r_RDebugEffect;
		public virtual RMethod RDebugEffect
		{
			get
			{
				if(r_RDebugEffect == null)
				{
					r_RDebugEffect = new(this, "DebugEffect", 0);
					r_RDebugEffect.SetBelong(this.instance);
				}
				return r_RDebugEffect;
			}
		}

		/// <summary>
		/// Boolean isEffectContainInLib(System.String)
		/// </summary>
		protected RMethod r_RisEffectContainInLib_String;
		public virtual RMethod RisEffectContainInLib_String
		{
			get
			{
				if(r_RisEffectContainInLib_String == null)
				{
					r_RisEffectContainInLib_String = new(this, "isEffectContainInLib", 0, typeof(System.String));
					r_RisEffectContainInLib_String.SetBelong(this.instance);
				}
				return r_RisEffectContainInLib_String;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetEffect(System.String)
		/// </summary>
		protected RMethod r_RGetEffect_String;
		public virtual RMethod RGetEffect_String
		{
			get
			{
				if(r_RGetEffect_String == null)
				{
					r_RGetEffect_String = new(this, "GetEffect", 0, typeof(System.String));
					r_RGetEffect_String.SetBelong(this.instance);
				}
				return r_RGetEffect_String;
			}
		}

		/// <summary>
		/// Void Add2EffectLib(System.String, System.String)
		/// </summary>
		protected RMethod r_RAdd2EffectLib_String_String;
		public virtual RMethod RAdd2EffectLib_String_String
		{
			get
			{
				if(r_RAdd2EffectLib_String_String == null)
				{
					r_RAdd2EffectLib_String_String = new(this, "Add2EffectLib", 0, typeof(System.String), typeof(System.String));
					r_RAdd2EffectLib_String_String.SetBelong(this.instance);
				}
				return r_RAdd2EffectLib_String_String;
			}
		}

		/// <summary>
		/// System.String[] Add2EffectLib(System.String, System.String, GameDefineType.ID, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected RMethod r_RAdd2EffectLib_String_String_ID_ABLoadingHandler_ABLoadedHandler;
		public virtual RMethod RAdd2EffectLib_String_String_ID_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_RAdd2EffectLib_String_String_ID_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_RAdd2EffectLib_String_String_ID_ABLoadingHandler_ABLoadedHandler = new(this, "Add2EffectLib", 0, typeof(System.String), typeof(System.String), typeof(GameDefineType.ID),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_RAdd2EffectLib_String_String_ID_ABLoadingHandler_ABLoadedHandler.SetBelong(this.instance);
				}
				return r_RAdd2EffectLib_String_String_ID_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// System.String[] Add2EffectLib(System.String, System.String, ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected RMethod r_RAdd2EffectLib_String_String_ABLoadingHandler_ABLoadedHandler;
		public virtual RMethod RAdd2EffectLib_String_String_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_RAdd2EffectLib_String_String_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_RAdd2EffectLib_String_String_ABLoadingHandler_ABLoadedHandler = new(this, "Add2EffectLib", 0, typeof(System.String), typeof(System.String),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_RAdd2EffectLib_String_String_ABLoadingHandler_ABLoadedHandler.SetBelong(this.instance);
				}
				return r_RAdd2EffectLib_String_String_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// Void _OnLoadEffectAB(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R_OnLoadEffectAB_Object_ABLoadedArgs;
		public virtual RMethod R_OnLoadEffectAB_Object_ABLoadedArgs
		{
			get
			{
				if(r_R_OnLoadEffectAB_Object_ABLoadedArgs == null)
				{
					r_R_OnLoadEffectAB_Object_ABLoadedArgs = new(this, "_OnLoadEffectAB", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R_OnLoadEffectAB_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R_OnLoadEffectAB_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnUnLoadEffectAsset(System.String)
		/// </summary>
		protected RMethod r_ROnUnLoadEffectAsset_String;
		public virtual RMethod ROnUnLoadEffectAsset_String
		{
			get
			{
				if(r_ROnUnLoadEffectAsset_String == null)
				{
					r_ROnUnLoadEffectAsset_String = new(this, "OnUnLoadEffectAsset", 0, typeof(System.String));
					r_ROnUnLoadEffectAsset_String.SetBelong(this.instance);
				}
				return r_ROnUnLoadEffectAsset_String;
			}
		}

		/// <summary>
		/// Void UnloadAssets()
		/// </summary>
		protected RMethod r_RUnloadAssets;
		public virtual RMethod RUnloadAssets
		{
			get
			{
				if(r_RUnloadAssets == null)
				{
					r_RUnloadAssets = new(this, "UnloadAssets", 0);
					r_RUnloadAssets.SetBelong(this.instance);
				}
				return r_RUnloadAssets;
			}
		}

		/// <summary>
		/// Void RequestEffectAsset(UInt32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RRequestEffectAsset_UInt32_ID;
		public virtual RMethod RRequestEffectAsset_UInt32_ID
		{
			get
			{
				if(r_RRequestEffectAsset_UInt32_ID == null)
				{
					r_RRequestEffectAsset_UInt32_ID = new(this, "RequestEffectAsset", 0, typeof(System.UInt32), typeof(GameDefineType.ID));
					r_RRequestEffectAsset_UInt32_ID.SetBelong(this.instance);
				}
				return r_RRequestEffectAsset_UInt32_ID;
			}
		}

		/// <summary>
		/// Void RequestEffectAsset(System.String)
		/// </summary>
		protected RMethod r_RRequestEffectAsset_String;
		public virtual RMethod RRequestEffectAsset_String
		{
			get
			{
				if(r_RRequestEffectAsset_String == null)
				{
					r_RRequestEffectAsset_String = new(this, "RequestEffectAsset", 0, typeof(System.String));
					r_RRequestEffectAsset_String.SetBelong(this.instance);
				}
				return r_RRequestEffectAsset_String;
			}
		}

		/// <summary>
		/// Void RequestEffectAsset(UInt32)
		/// </summary>
		protected RMethod r_RRequestEffectAsset_UInt32;
		public virtual RMethod RRequestEffectAsset_UInt32
		{
			get
			{
				if(r_RRequestEffectAsset_UInt32 == null)
				{
					r_RRequestEffectAsset_UInt32 = new(this, "RequestEffectAsset", 0, typeof(System.UInt32));
					r_RRequestEffectAsset_UInt32.SetBelong(this.instance);
				}
				return r_RRequestEffectAsset_UInt32;
			}
		}

		/// <summary>
		/// Void RequestEffectAsset(System.Collections.Generic.List`1[GameDefineType.ID])
		/// </summary>
		protected RMethod r_RRequestEffectAsset_List_d_ID_p_;
		public virtual RMethod RRequestEffectAsset_List_d_ID_p_
		{
			get
			{
				if(r_RRequestEffectAsset_List_d_ID_p_ == null)
				{
					r_RRequestEffectAsset_List_d_ID_p_ = new(this, "RequestEffectAsset", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(GameDefineType.ID)));
					r_RRequestEffectAsset_List_d_ID_p_.SetBelong(this.instance);
				}
				return r_RRequestEffectAsset_List_d_ID_p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetEffectUrls(System.Collections.Generic.Dictionary`2[System.UInt32,System.Collections.Generic.List`1[GameDefineType.ID]])
		/// </summary>
		protected RMethod r_RGetEffectUrls_Dictionary_d_UInt32_List_d_ID_p__p_;
		public virtual RMethod RGetEffectUrls_Dictionary_d_UInt32_List_d_ID_p__p_
		{
			get
			{
				if(r_RGetEffectUrls_Dictionary_d_UInt32_List_d_ID_p__p_ == null)
				{
					r_RGetEffectUrls_Dictionary_d_UInt32_List_d_ID_p__p_ = new(this, "GetEffectUrls", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.UInt32), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(GameDefineType.ID))));
					r_RGetEffectUrls_Dictionary_d_UInt32_List_d_ID_p__p_.SetBelong(this.instance);
				}
				return r_RGetEffectUrls_Dictionary_d_UInt32_List_d_ID_p__p_;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetAnimationNameList(UInt32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetAnimationNameList_UInt32_ID;
		public virtual RMethod RGetAnimationNameList_UInt32_ID
		{
			get
			{
				if(r_RGetAnimationNameList_UInt32_ID == null)
				{
					r_RGetAnimationNameList_UInt32_ID = new(this, "GetAnimationNameList", 0, typeof(System.UInt32), typeof(GameDefineType.ID));
					r_RGetAnimationNameList_UInt32_ID.SetBelong(this.instance);
				}
				return r_RGetAnimationNameList_UInt32_ID;
			}
		}

		/// <summary>
		/// Void RequestEffectAsset(System.Collections.Generic.Dictionary`2[System.String,EffectAssetElement])
		/// </summary>
		protected RMethod r_RRequestEffectAsset_Dictionary_d_String_EffectAssetElement_p_;
		public virtual RMethod RRequestEffectAsset_Dictionary_d_String_EffectAssetElement_p_
		{
			get
			{
				if(r_RRequestEffectAsset_Dictionary_d_String_EffectAssetElement_p_ == null)
				{
					r_RRequestEffectAsset_Dictionary_d_String_EffectAssetElement_p_ = new(this, "RequestEffectAsset", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReleactionUtils.GetType("EffectAssetElement")));
					r_RRequestEffectAsset_Dictionary_d_String_EffectAssetElement_p_.SetBelong(this.instance);
				}
				return r_RRequestEffectAsset_Dictionary_d_String_EffectAssetElement_p_;
			}
		}

		/// <summary>
		/// Void OnLoadEffectAB(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadEffectAB_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadEffectAB_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadEffectAB_Object_ABLoadedArgs == null)
				{
					r_ROnLoadEffectAB_Object_ABLoadedArgs = new(this, "OnLoadEffectAB", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadEffectAB_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadEffectAB_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetEffectAssetUrls(System.Collections.Generic.Dictionary`2[System.String,EffectAssetElement])
		/// </summary>
		protected RMethod r_RGetEffectAssetUrls_Dictionary_d_String_EffectAssetElement_p_;
		public virtual RMethod RGetEffectAssetUrls_Dictionary_d_String_EffectAssetElement_p_
		{
			get
			{
				if(r_RGetEffectAssetUrls_Dictionary_d_String_EffectAssetElement_p_ == null)
				{
					r_RGetEffectAssetUrls_Dictionary_d_String_EffectAssetElement_p_ = new(this, "GetEffectAssetUrls", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReleactionUtils.GetType("EffectAssetElement")));
					r_RGetEffectAssetUrls_Dictionary_d_String_EffectAssetElement_p_.SetBelong(this.instance);
				}
				return r_RGetEffectAssetUrls_Dictionary_d_String_EffectAssetElement_p_;
			}
		}

		/// <summary>
		/// GameDefineType.ID CareertoResourceID(UInt32)
		/// </summary>
		protected RMethod r_RCareertoResourceID_UInt32;
		public virtual RMethod RCareertoResourceID_UInt32
		{
			get
			{
				if(r_RCareertoResourceID_UInt32 == null)
				{
					r_RCareertoResourceID_UInt32 = new(this, "CareertoResourceID", 0, typeof(System.UInt32));
					r_RCareertoResourceID_UInt32.SetBelong(this.instance);
				}
				return r_RCareertoResourceID_UInt32;
			}
		}

		/// <summary>
		/// Boolean HasCareerSkillConfigItem(UInt32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RHasCareerSkillConfigItem_UInt32_ID;
		public virtual RMethod RHasCareerSkillConfigItem_UInt32_ID
		{
			get
			{
				if(r_RHasCareerSkillConfigItem_UInt32_ID == null)
				{
					r_RHasCareerSkillConfigItem_UInt32_ID = new(this, "HasCareerSkillConfigItem", 0, typeof(System.UInt32), typeof(GameDefineType.ID));
					r_RHasCareerSkillConfigItem_UInt32_ID.SetBelong(this.instance);
				}
				return r_RHasCareerSkillConfigItem_UInt32_ID;
			}
		}

		/// <summary>
		/// CareerSkillConfigItem GetCareerSkillConfigItem(UInt32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCareerSkillConfigItem_UInt32_ID;
		public virtual RMethod RGetCareerSkillConfigItem_UInt32_ID
		{
			get
			{
				if(r_RGetCareerSkillConfigItem_UInt32_ID == null)
				{
					r_RGetCareerSkillConfigItem_UInt32_ID = new(this, "GetCareerSkillConfigItem", 0, typeof(System.UInt32), typeof(GameDefineType.ID));
					r_RGetCareerSkillConfigItem_UInt32_ID.SetBelong(this.instance);
				}
				return r_RGetCareerSkillConfigItem_UInt32_ID;
			}
		}

		/// <summary>
		/// CareerBattleAttribute GetCareerBattleAttribute(UInt32)
		/// </summary>
		protected RMethod r_RGetCareerBattleAttribute_UInt32;
		public virtual RMethod RGetCareerBattleAttribute_UInt32
		{
			get
			{
				if(r_RGetCareerBattleAttribute_UInt32 == null)
				{
					r_RGetCareerBattleAttribute_UInt32 = new(this, "GetCareerBattleAttribute", 0, typeof(System.UInt32));
					r_RGetCareerBattleAttribute_UInt32.SetBelong(this.instance);
				}
				return r_RGetCareerBattleAttribute_UInt32;
			}
		}

		/// <summary>
		/// Void OnLoadBattleAniEffectConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadBattleAniEffectConfig_Object;
		public virtual RMethod ROnLoadBattleAniEffectConfig_Object
		{
			get
			{
				if(r_ROnLoadBattleAniEffectConfig_Object == null)
				{
					r_ROnLoadBattleAniEffectConfig_Object = new(this, "OnLoadBattleAniEffectConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadBattleAniEffectConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadBattleAniEffectConfig_Object;
			}
		}

		/// <summary>
		/// Void NewThreadLoadBattleAniEffectConfig()
		/// </summary>
		protected RMethod r_RNewThreadLoadBattleAniEffectConfig;
		public virtual RMethod RNewThreadLoadBattleAniEffectConfig
		{
			get
			{
				if(r_RNewThreadLoadBattleAniEffectConfig == null)
				{
					r_RNewThreadLoadBattleAniEffectConfig = new(this, "NewThreadLoadBattleAniEffectConfig", 0);
					r_RNewThreadLoadBattleAniEffectConfig.SetBelong(this.instance);
				}
				return r_RNewThreadLoadBattleAniEffectConfig;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.Dictionary`2[GameDefineType.ID,CareerSkillConfigItem]] LoadBattleAniEffectConfig(System.String)
		/// </summary>
		protected RMethod r_RLoadBattleAniEffectConfig_String;
		public virtual RMethod RLoadBattleAniEffectConfig_String
		{
			get
			{
				if(r_RLoadBattleAniEffectConfig_String == null)
				{
					r_RLoadBattleAniEffectConfig_String = new(this, "LoadBattleAniEffectConfig", 0, typeof(System.String));
					r_RLoadBattleAniEffectConfig_String.SetBelong(this.instance);
				}
				return r_RLoadBattleAniEffectConfig_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.Dictionary`2[GameDefineType.ID,CareerSkillConfigItem]] LoadBattleAniEffectWeaponCategory(System.Xml.XmlNode, UInt32)
		/// </summary>
		protected RMethod r_RLoadBattleAniEffectWeaponCategory_XmlNode_UInt32;
		public virtual RMethod RLoadBattleAniEffectWeaponCategory_XmlNode_UInt32
		{
			get
			{
				if(r_RLoadBattleAniEffectWeaponCategory_XmlNode_UInt32 == null)
				{
					r_RLoadBattleAniEffectWeaponCategory_XmlNode_UInt32 = new(this, "LoadBattleAniEffectWeaponCategory", 0, typeof(System.Xml.XmlNode), typeof(System.UInt32));
					r_RLoadBattleAniEffectWeaponCategory_XmlNode_UInt32.SetBelong(this.instance);
				}
				return r_RLoadBattleAniEffectWeaponCategory_XmlNode_UInt32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,CareerSkillConfigItem] LoadBattleAniEffectOfCareer(System.Xml.XmlNode, UInt32)
		/// </summary>
		protected RMethod r_RLoadBattleAniEffectOfCareer_XmlNode_UInt32;
		public virtual RMethod RLoadBattleAniEffectOfCareer_XmlNode_UInt32
		{
			get
			{
				if(r_RLoadBattleAniEffectOfCareer_XmlNode_UInt32 == null)
				{
					r_RLoadBattleAniEffectOfCareer_XmlNode_UInt32 = new(this, "LoadBattleAniEffectOfCareer", 0, typeof(System.Xml.XmlNode), typeof(System.UInt32));
					r_RLoadBattleAniEffectOfCareer_XmlNode_UInt32.SetBelong(this.instance);
				}
				return r_RLoadBattleAniEffectOfCareer_XmlNode_UInt32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleAction] LoadWeaponChangConfig(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RLoadWeaponChangConfig_XmlNode;
		public virtual RMethod RLoadWeaponChangConfig_XmlNode
		{
			get
			{
				if(r_RLoadWeaponChangConfig_XmlNode == null)
				{
					r_RLoadWeaponChangConfig_XmlNode = new(this, "LoadWeaponChangConfig", 0, typeof(System.Xml.XmlNode));
					r_RLoadWeaponChangConfig_XmlNode.SetBelong(this.instance);
				}
				return r_RLoadWeaponChangConfig_XmlNode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleAction] LoadBattleAniEffectOfSkill(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RLoadBattleAniEffectOfSkill_XmlNode;
		public virtual RMethod RLoadBattleAniEffectOfSkill_XmlNode
		{
			get
			{
				if(r_RLoadBattleAniEffectOfSkill_XmlNode == null)
				{
					r_RLoadBattleAniEffectOfSkill_XmlNode = new(this, "LoadBattleAniEffectOfSkill", 0, typeof(System.Xml.XmlNode));
					r_RLoadBattleAniEffectOfSkill_XmlNode.SetBelong(this.instance);
				}
				return r_RLoadBattleAniEffectOfSkill_XmlNode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleEffectBase] LoadBattleEffectList(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RLoadBattleEffectList_XmlNode;
		public virtual RMethod RLoadBattleEffectList_XmlNode
		{
			get
			{
				if(r_RLoadBattleEffectList_XmlNode == null)
				{
					r_RLoadBattleEffectList_XmlNode = new(this, "LoadBattleEffectList", 0, typeof(System.Xml.XmlNode));
					r_RLoadBattleEffectList_XmlNode.SetBelong(this.instance);
				}
				return r_RLoadBattleEffectList_XmlNode;
			}
		}

		/// <summary>
		/// Void RegisterEffects()
		/// </summary>
		protected RMethod r_RRegisterEffects;
		public virtual RMethod RRegisterEffects
		{
			get
			{
				if(r_RRegisterEffects == null)
				{
					r_RRegisterEffects = new(this, "RegisterEffects", 0);
					r_RRegisterEffects.SetBelong(this.instance);
				}
				return r_RRegisterEffects;
			}
		}

		/// <summary>
		/// BattleEffectBase LoadBattleEffect(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RLoadBattleEffect_XmlNode;
		public virtual RMethod RLoadBattleEffect_XmlNode
		{
			get
			{
				if(r_RLoadBattleEffect_XmlNode == null)
				{
					r_RLoadBattleEffect_XmlNode = new(this, "LoadBattleEffect", 0, typeof(System.Xml.XmlNode));
					r_RLoadBattleEffect_XmlNode.SetBelong(this.instance);
				}
				return r_RLoadBattleEffect_XmlNode;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,EffectAssetElement] LoadEffectAssetListConfig(System.Xml.XmlNode)
		/// </summary>
		protected RMethod r_RLoadEffectAssetListConfig_XmlNode;
		public virtual RMethod RLoadEffectAssetListConfig_XmlNode
		{
			get
			{
				if(r_RLoadEffectAssetListConfig_XmlNode == null)
				{
					r_RLoadEffectAssetListConfig_XmlNode = new(this, "LoadEffectAssetListConfig", 0, typeof(System.Xml.XmlNode));
					r_RLoadEffectAssetListConfig_XmlNode.SetBelong(this.instance);
				}
				return r_RLoadEffectAssetListConfig_XmlNode;
			}
		}

		/// <summary>
		/// Void DebugConfig()
		/// </summary>
		protected RMethod r_RDebugConfig;
		public virtual RMethod RDebugConfig
		{
			get
			{
				if(r_RDebugConfig == null)
				{
					r_RDebugConfig = new(this, "DebugConfig", 0);
					r_RDebugConfig.SetBelong(this.instance);
				}
				return r_RDebugConfig;
			}
		}

		/// <summary>
		/// Void OnLoadBuffEffectConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadBuffEffectConfig_Object;
		public virtual RMethod ROnLoadBuffEffectConfig_Object
		{
			get
			{
				if(r_ROnLoadBuffEffectConfig_Object == null)
				{
					r_ROnLoadBuffEffectConfig_Object = new(this, "OnLoadBuffEffectConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadBuffEffectConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadBuffEffectConfig_Object;
			}
		}

		/// <summary>
		/// Void LoadBuffEffect(UnityEngine.TextAsset)
		/// </summary>
		protected RMethod r_RLoadBuffEffect_TextAsset;
		public virtual RMethod RLoadBuffEffect_TextAsset
		{
			get
			{
				if(r_RLoadBuffEffect_TextAsset == null)
				{
					r_RLoadBuffEffect_TextAsset = new(this, "LoadBuffEffect", 0, typeof(UnityEngine.TextAsset));
					r_RLoadBuffEffect_TextAsset.SetBelong(this.instance);
				}
				return r_RLoadBuffEffect_TextAsset;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetBuffEffectUrls(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetBuffEffectUrls_ID;
		public virtual RMethod RGetBuffEffectUrls_ID
		{
			get
			{
				if(r_RGetBuffEffectUrls_ID == null)
				{
					r_RGetBuffEffectUrls_ID = new(this, "GetBuffEffectUrls", 0, typeof(GameDefineType.ID));
					r_RGetBuffEffectUrls_ID.SetBelong(this.instance);
				}
				return r_RGetBuffEffectUrls_ID;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetBuffEffect(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetBuffEffect_ID;
		public virtual RMethod RGetBuffEffect_ID
		{
			get
			{
				if(r_RGetBuffEffect_ID == null)
				{
					r_RGetBuffEffect_ID = new(this, "GetBuffEffect", 0, typeof(GameDefineType.ID));
					r_RGetBuffEffect_ID.SetBelong(this.instance);
				}
				return r_RGetBuffEffect_ID;
			}
		}

		/// <summary>
		/// UnityEngine.Object GetBuffEffect(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RGetBuffEffect_ID_String;
		public virtual RMethod RGetBuffEffect_ID_String
		{
			get
			{
				if(r_RGetBuffEffect_ID_String == null)
				{
					r_RGetBuffEffect_ID_String = new(this, "GetBuffEffect", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_RGetBuffEffect_ID_String.SetBelong(this.instance);
				}
				return r_RGetBuffEffect_ID_String;
			}
		}

		/// <summary>
		/// BuffEffectHold GetBuffHold(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetBuffHold_ID;
		public virtual RMethod RGetBuffHold_ID
		{
			get
			{
				if(r_RGetBuffHold_ID == null)
				{
					r_RGetBuffHold_ID = new(this, "GetBuffHold", 0, typeof(GameDefineType.ID));
					r_RGetBuffHold_ID.SetBelong(this.instance);
				}
				return r_RGetBuffHold_ID;
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


        public RBattleAniEffectConfig() : base("BattleAniEffectConfig")
        {
        }

        public RBattleAniEffectConfig(System.Object instance) : base("BattleAniEffectConfig")
		{
            SetInstance(instance);
		}

        public RBattleAniEffectConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBattleAniEffectConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadEffect(System.String  @name, System.String  @url, UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @url, @obj};
            var ___result = ROnLoadEffect_String_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DebugEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDebugEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean isEffectContainInLib(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RisEffectContainInLib_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Object GetEffect(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetEffect_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual void Add2EffectLib(System.String  @name, System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @url};
            var ___result = RAdd2EffectLib_String_String.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void OnUnLoadEffectAsset(System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = ROnUnLoadEffectAsset_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnloadAssets()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnloadAssets.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestEffectAsset(System.UInt32  @idCareer, GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idCareer, @idSkill};
            var ___result = RRequestEffectAsset_UInt32_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestEffectAsset(System.String  @effectName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@effectName};
            var ___result = RRequestEffectAsset_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestEffectAsset(System.UInt32  @idCareer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idCareer};
            var ___result = RRequestEffectAsset_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestEffectAsset(System.Collections.Generic.List<GameDefineType.ID>  @skillIDs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skillIDs};
            var ___result = RRequestEffectAsset_List_d_ID_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.String> GetEffectUrls(System.Collections.Generic.Dictionary<System.UInt32, System.Collections.Generic.List<GameDefineType.ID>>  @SkillsOfcarrers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@SkillsOfcarrers};
            var ___result = RGetEffectUrls_Dictionary_d_UInt32_List_d_ID_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual System.Collections.Generic.List<System.String> GetAnimationNameList(System.UInt32  @idCarrer, GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idCarrer, @idSkill};
            var ___result = RGetAnimationNameList_UInt32_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }





        public virtual GameDefineType.ID CareertoResourceID(System.UInt32  @mCarrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mCarrer};
            var ___result = RCareertoResourceID_UInt32.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.Boolean HasCareerSkillConfigItem(System.UInt32  @mCareer, GameDefineType.ID  @skillid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mCareer, @skillid};
            var ___result = RHasCareerSkillConfigItem_UInt32_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object GetCareerSkillConfigItem(System.UInt32  @mCareer, GameDefineType.ID  @skillid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mCareer, @skillid};
            var ___result = RGetCareerSkillConfigItem_UInt32_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetCareerBattleAttribute(System.UInt32  @mCareer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mCareer};
            var ___result = RGetCareerBattleAttribute_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void OnLoadBattleAniEffectConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadBattleAniEffectConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void NewThreadLoadBattleAniEffectConfig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNewThreadLoadBattleAniEffectConfig.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object LoadBattleAniEffectConfig(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadBattleAniEffectConfig_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadBattleAniEffectWeaponCategory(System.Xml.XmlNode  @theCareer, System.UInt32  @careerParam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@theCareer, @careerParam};
            var ___result = RLoadBattleAniEffectWeaponCategory_XmlNode_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadBattleAniEffectOfCareer(System.Xml.XmlNode  @theCareer, System.UInt32  @careerParam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@theCareer, @careerParam};
            var ___result = RLoadBattleAniEffectOfCareer_XmlNode_UInt32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadWeaponChangConfig(System.Xml.XmlNode  @WeaponChange)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@WeaponChange};
            var ___result = RLoadWeaponChangConfig_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadBattleAniEffectOfSkill(System.Xml.XmlNode  @theSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@theSkill};
            var ___result = RLoadBattleAniEffectOfSkill_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadBattleEffectList(System.Xml.XmlNode  @theAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@theAction};
            var ___result = RLoadBattleEffectList_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void RegisterEffects()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRegisterEffects.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object LoadBattleEffect(System.Xml.XmlNode  @effectNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@effectNode};
            var ___result = RLoadBattleEffect_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object LoadEffectAssetListConfig(System.Xml.XmlNode  @theSkillAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@theSkillAsset};
            var ___result = RLoadEffectAssetListConfig_XmlNode.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void DebugConfig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDebugConfig.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadBuffEffectConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadBuffEffectConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadBuffEffect(UnityEngine.TextAsset  @buffConfig)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffConfig};
            var ___result = RLoadBuffEffect_TextAsset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.String> GetBuffEffectUrls(GameDefineType.ID  @buffID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffID};
            var ___result = RGetBuffEffectUrls_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual UnityEngine.Object GetBuffEffect(GameDefineType.ID  @buffID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffID};
            var ___result = RGetBuffEffect_ID.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual UnityEngine.Object GetBuffEffect(GameDefineType.ID  @buffID, System.String  @buffEffectTyp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffID, @buffEffectTyp};
            var ___result = RGetBuffEffect_ID_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Object)___result;
        }


        public virtual System.Object GetBuffHold(GameDefineType.ID  @idBuff)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idBuff};
            var ___result = RGetBuffHold_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
