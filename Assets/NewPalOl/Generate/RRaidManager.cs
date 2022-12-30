using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RaidManager
	/// </summary>
    public partial class RRaidManager : RMember //
    {

		/// <summary>
		/// System.String NONE_STR
		/// </summary>
		protected static RField r_NONE_STR;
		public static RField RNONE_STR
		{
			get
			{
				if(r_NONE_STR == null)
				{
					r_NONE_STR = new( ReleactionUtils.GetType("RaidManager"), "NONE_STR");
					r_NONE_STR.SetBelong(null);
				}
				return r_NONE_STR;
			}
		}

		/// <summary>
		/// System.String GOLD_STR
		/// </summary>
		protected static RField r_GOLD_STR;
		public static RField RGOLD_STR
		{
			get
			{
				if(r_GOLD_STR == null)
				{
					r_GOLD_STR = new( ReleactionUtils.GetType("RaidManager"), "GOLD_STR");
					r_GOLD_STR.SetBelong(null);
				}
				return r_GOLD_STR;
			}
		}

		/// <summary>
		/// System.String GOLDEX_STR
		/// </summary>
		protected static RField r_GOLDEX_STR;
		public static RField RGOLDEX_STR
		{
			get
			{
				if(r_GOLDEX_STR == null)
				{
					r_GOLDEX_STR = new( ReleactionUtils.GetType("RaidManager"), "GOLDEX_STR");
					r_GOLDEX_STR.SetBelong(null);
				}
				return r_GOLDEX_STR;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] m_RaidIDList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r_m_RaidIDList;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> Rm_RaidIDList
		{
			get
			{
				if(r_m_RaidIDList == null)
				{
					r_m_RaidIDList = new(this, "m_RaidIDList");
					r_m_RaidIDList.SetBelong(this.instance);
				}
				return r_m_RaidIDList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,RAID_INFO] m_RaidInfoDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RRAID_INFO> r_m_RaidInfoDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RRAID_INFO> Rm_RaidInfoDict
		{
			get
			{
				if(r_m_RaidInfoDict == null)
				{
					r_m_RaidInfoDict = new(this, "m_RaidInfoDict");
					r_m_RaidInfoDict.SetBelong(this.instance);
				}
				return r_m_RaidInfoDict;
			}
		}

		/// <summary>
		/// System.Boolean m_bInRaid
		/// </summary>
		protected RField r_m_bInRaid;
		public virtual RField Rm_bInRaid
		{
			get
			{
				if(r_m_bInRaid == null)
				{
					r_m_bInRaid = new(this, "m_bInRaid");
					r_m_bInRaid.SetBelong(this.instance);
				}
				return r_m_bInRaid;
			}
		}

		/// <summary>
		/// GameDefineType.ID m_RaidID
		/// </summary>
		protected RGameDefineType.RID r_m_RaidID;
		public virtual RGameDefineType.RID Rm_RaidID
		{
			get
			{
				if(r_m_RaidID == null)
				{
					r_m_RaidID = new(this, "m_RaidID");
					r_m_RaidID.SetBelong(this.instance);
				}
				return r_m_RaidID;
			}
		}

		/// <summary>
		/// KeyValueContent RaidElite2TimesContent
		/// </summary>
		protected RKeyValueContent r_RaidElite2TimesContent;
		public virtual RKeyValueContent RaidElite2TimesContent
		{
			get
			{
				if(r_RaidElite2TimesContent == null)
				{
					r_RaidElite2TimesContent = new(this, "RaidElite2TimesContent");
					r_RaidElite2TimesContent.SetBelong(this.instance);
				}
				return r_RaidElite2TimesContent;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] m_EliteRaidedList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_EliteRaidedList;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_EliteRaidedList
		{
			get
			{
				if(r_m_EliteRaidedList == null)
				{
					r_m_EliteRaidedList = new(this, "m_EliteRaidedList");
					r_m_EliteRaidedList.SetBelong(this.instance);
				}
				return r_m_EliteRaidedList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] m_EliteAreaList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_m_EliteAreaList;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> Rm_EliteAreaList
		{
			get
			{
				if(r_m_EliteAreaList == null)
				{
					r_m_EliteAreaList = new(this, "m_EliteAreaList");
					r_m_EliteAreaList.SetBelong(this.instance);
				}
				return r_m_EliteAreaList;
			}
		}

		/// <summary>
		/// System.Int32 m_nMaxEliteResetTimes
		/// </summary>
		protected RField r_m_nMaxEliteResetTimes;
		public virtual RField Rm_nMaxEliteResetTimes
		{
			get
			{
				if(r_m_nMaxEliteResetTimes == null)
				{
					r_m_nMaxEliteResetTimes = new(this, "m_nMaxEliteResetTimes");
					r_m_nMaxEliteResetTimes.SetBelong(this.instance);
				}
				return r_m_nMaxEliteResetTimes;
			}
		}

		/// <summary>
		/// System.Boolean m_bInDevilWell
		/// </summary>
		protected RField r_m_bInDevilWell;
		public virtual RField Rm_bInDevilWell
		{
			get
			{
				if(r_m_bInDevilWell == null)
				{
					r_m_bInDevilWell = new(this, "m_bInDevilWell");
					r_m_bInDevilWell.SetBelong(this.instance);
				}
				return r_m_bInDevilWell;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_BottleEff
		/// </summary>
		protected RUnityEngine.RGameObject r_m_BottleEff;
		public virtual RUnityEngine.RGameObject Rm_BottleEff
		{
			get
			{
				if(r_m_BottleEff == null)
				{
					r_m_BottleEff = new(this, "m_BottleEff");
					r_m_BottleEff.SetBelong(this.instance);
				}
				return r_m_BottleEff;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_HammerEff
		/// </summary>
		protected RUnityEngine.RGameObject r_m_HammerEff;
		public virtual RUnityEngine.RGameObject Rm_HammerEff
		{
			get
			{
				if(r_m_HammerEff == null)
				{
					r_m_HammerEff = new(this, "m_HammerEff");
					r_m_HammerEff.SetBelong(this.instance);
				}
				return r_m_HammerEff;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,RAID_STAR_INFO] m_RaidStarDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RRAID_STAR_INFO> r_m_RaidStarDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RRAID_STAR_INFO> Rm_RaidStarDict
		{
			get
			{
				if(r_m_RaidStarDict == null)
				{
					r_m_RaidStarDict = new(this, "m_RaidStarDict");
					r_m_RaidStarDict.SetBelong(this.instance);
				}
				return r_m_RaidStarDict;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] m_RaidRewardState
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_m_RaidRewardState;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rm_RaidRewardState
		{
			get
			{
				if(r_m_RaidRewardState == null)
				{
					r_m_RaidRewardState = new(this, "m_RaidRewardState");
					r_m_RaidRewardState.SetBelong(this.instance);
				}
				return r_m_RaidRewardState;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[DEVIL_SHOP_INFO]] m_DevilShopDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RDEVIL_SHOP_INFO>> r_m_DevilShopDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RDEVIL_SHOP_INFO>> Rm_DevilShopDict
		{
			get
			{
				if(r_m_DevilShopDict == null)
				{
					r_m_DevilShopDict = new(this, "m_DevilShopDict");
					r_m_DevilShopDict.SetBelong(this.instance);
				}
				return r_m_DevilShopDict;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[DEVIL_AUTO_INFO]] m_DevilAutoDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RDEVIL_AUTO_INFO>> r_m_DevilAutoDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RDEVIL_AUTO_INFO>> Rm_DevilAutoDict
		{
			get
			{
				if(r_m_DevilAutoDict == null)
				{
					r_m_DevilAutoDict = new(this, "m_DevilAutoDict");
					r_m_DevilAutoDict.SetBelong(this.instance);
				}
				return r_m_DevilAutoDict;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Int32] m_DevilWellLevelStage
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_m_DevilWellLevelStage;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> Rm_DevilWellLevelStage
		{
			get
			{
				if(r_m_DevilWellLevelStage == null)
				{
					r_m_DevilWellLevelStage = new(this, "m_DevilWellLevelStage");
					r_m_DevilWellLevelStage.SetBelong(this.instance);
				}
				return r_m_DevilWellLevelStage;
			}
		}

		/// <summary>
		/// System.String m_strWellTrampleInfo
		/// </summary>
		protected RField r_m_strWellTrampleInfo;
		public virtual RField Rm_strWellTrampleInfo
		{
			get
			{
				if(r_m_strWellTrampleInfo == null)
				{
					r_m_strWellTrampleInfo = new(this, "m_strWellTrampleInfo");
					r_m_strWellTrampleInfo.SetBelong(this.instance);
				}
				return r_m_strWellTrampleInfo;
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
		/// Void OnLoadRaidElite2TimesConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadRaidElite2TimesConfig_Object;
		public virtual RMethod ROnLoadRaidElite2TimesConfig_Object
		{
			get
			{
				if(r_ROnLoadRaidElite2TimesConfig_Object == null)
				{
					r_ROnLoadRaidElite2TimesConfig_Object = new(this, "OnLoadRaidElite2TimesConfig", 0, typeof(System.Object));
					r_ROnLoadRaidElite2TimesConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRaidElite2TimesConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetRaidElite2RefreshGold(Int32)
		/// </summary>
		protected RMethod r_RGetRaidElite2RefreshGold_Int32;
		public virtual RMethod RGetRaidElite2RefreshGold_Int32
		{
			get
			{
				if(r_RGetRaidElite2RefreshGold_Int32 == null)
				{
					r_RGetRaidElite2RefreshGold_Int32 = new(this, "GetRaidElite2RefreshGold", 0, typeof(System.Int32));
					r_RGetRaidElite2RefreshGold_Int32.SetBelong(this.instance);
				}
				return r_RGetRaidElite2RefreshGold_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadRaidInfoConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadRaidInfoConfig_Object;
		public virtual RMethod ROnLoadRaidInfoConfig_Object
		{
			get
			{
				if(r_ROnLoadRaidInfoConfig_Object == null)
				{
					r_ROnLoadRaidInfoConfig_Object = new(this, "OnLoadRaidInfoConfig", 0, typeof(System.Object));
					r_ROnLoadRaidInfoConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRaidInfoConfig_Object;
			}
		}

		/// <summary>
		/// RAID_INFO GetRaidInfo(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetRaidInfo_ID;
		public virtual RMethod RGetRaidInfo_ID
		{
			get
			{
				if(r_RGetRaidInfo_ID == null)
				{
					r_RGetRaidInfo_ID = new(this, "GetRaidInfo", 0, typeof(GameDefineType.ID));
					r_RGetRaidInfo_ID.SetBelong(this.instance);
				}
				return r_RGetRaidInfo_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] GetEliteRaidSceneIDs()
		/// </summary>
		protected RMethod r_RGetEliteRaidSceneIDs;
		public virtual RMethod RGetEliteRaidSceneIDs
		{
			get
			{
				if(r_RGetEliteRaidSceneIDs == null)
				{
					r_RGetEliteRaidSceneIDs = new(this, "GetEliteRaidSceneIDs", 0);
					r_RGetEliteRaidSceneIDs.SetBelong(this.instance);
				}
				return r_RGetEliteRaidSceneIDs;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_INFO] GetRaidInfosBySceneID(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetRaidInfosBySceneID_ID;
		public virtual RMethod RGetRaidInfosBySceneID_ID
		{
			get
			{
				if(r_RGetRaidInfosBySceneID_ID == null)
				{
					r_RGetRaidInfosBySceneID_ID = new(this, "GetRaidInfosBySceneID", 0, typeof(GameDefineType.ID));
					r_RGetRaidInfosBySceneID_ID.SetBelong(this.instance);
				}
				return r_RGetRaidInfosBySceneID_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] GetSceneIDList()
		/// </summary>
		protected RMethod r_RGetSceneIDList;
		public virtual RMethod RGetSceneIDList
		{
			get
			{
				if(r_RGetSceneIDList == null)
				{
					r_RGetSceneIDList = new(this, "GetSceneIDList", 0);
					r_RGetSceneIDList.SetBelong(this.instance);
				}
				return r_RGetSceneIDList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_INFO] GetRaidInfos(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetRaidInfos_ID_ID;
		public virtual RMethod RGetRaidInfos_ID_ID
		{
			get
			{
				if(r_RGetRaidInfos_ID_ID == null)
				{
					r_RGetRaidInfos_ID_ID = new(this, "GetRaidInfos", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_RGetRaidInfos_ID_ID.SetBelong(this.instance);
				}
				return r_RGetRaidInfos_ID_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_INFO] GetRaidInfosByType(Int32)
		/// </summary>
		protected RMethod r_RGetRaidInfosByType_Int32;
		public virtual RMethod RGetRaidInfosByType_Int32
		{
			get
			{
				if(r_RGetRaidInfosByType_Int32 == null)
				{
					r_RGetRaidInfosByType_Int32 = new(this, "GetRaidInfosByType", 0, typeof(System.Int32));
					r_RGetRaidInfosByType_Int32.SetBelong(this.instance);
				}
				return r_RGetRaidInfosByType_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_INFO] GetRaidInfosElite(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetRaidInfosElite_ID;
		public virtual RMethod RGetRaidInfosElite_ID
		{
			get
			{
				if(r_RGetRaidInfosElite_ID == null)
				{
					r_RGetRaidInfosElite_ID = new(this, "GetRaidInfosElite", 0, typeof(GameDefineType.ID));
					r_RGetRaidInfosElite_ID.SetBelong(this.instance);
				}
				return r_RGetRaidInfosElite_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_INFO] GetRaidInfos(Int32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetRaidInfos_Int32_ID;
		public virtual RMethod RGetRaidInfos_Int32_ID
		{
			get
			{
				if(r_RGetRaidInfos_Int32_ID == null)
				{
					r_RGetRaidInfos_Int32_ID = new(this, "GetRaidInfos", 0, typeof(System.Int32), typeof(GameDefineType.ID));
					r_RGetRaidInfos_Int32_ID.SetBelong(this.instance);
				}
				return r_RGetRaidInfos_Int32_ID;
			}
		}

		/// <summary>
		/// Boolean IsFromAndToValid(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RIsFromAndToValid_ID_ID;
		public virtual RMethod RIsFromAndToValid_ID_ID
		{
			get
			{
				if(r_RIsFromAndToValid_ID_ID == null)
				{
					r_RIsFromAndToValid_ID_ID = new(this, "IsFromAndToValid", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_RIsFromAndToValid_ID_ID.SetBelong(this.instance);
				}
				return r_RIsFromAndToValid_ID_ID;
			}
		}

		/// <summary>
		/// Void OnRaidEliteData(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidEliteData_Object___0__Isb;
		public virtual RMethod ROnRaidEliteData_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidEliteData_Object___0__Isb == null)
				{
					r_ROnRaidEliteData_Object___0__Isb = new(this, "OnRaidEliteData", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidEliteData_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidEliteData_Object___0__Isb;
			}
		}

		/// <summary>
		/// Int32 GetEliteAreaCnt(System.String)
		/// </summary>
		protected RMethod r_RGetEliteAreaCnt_String;
		public virtual RMethod RGetEliteAreaCnt_String
		{
			get
			{
				if(r_RGetEliteAreaCnt_String == null)
				{
					r_RGetEliteAreaCnt_String = new(this, "GetEliteAreaCnt", 0, typeof(System.String));
					r_RGetEliteAreaCnt_String.SetBelong(this.instance);
				}
				return r_RGetEliteAreaCnt_String;
			}
		}

		/// <summary>
		/// Boolean CanEliteAreaReset(Int32)
		/// </summary>
		protected RMethod r_RCanEliteAreaReset_Int32;
		public virtual RMethod RCanEliteAreaReset_Int32
		{
			get
			{
				if(r_RCanEliteAreaReset_Int32 == null)
				{
					r_RCanEliteAreaReset_Int32 = new(this, "CanEliteAreaReset", 0, typeof(System.Int32));
					r_RCanEliteAreaReset_Int32.SetBelong(this.instance);
				}
				return r_RCanEliteAreaReset_Int32;
			}
		}

		/// <summary>
		/// Boolean CanEliteRaid(System.String)
		/// </summary>
		protected RMethod r_RCanEliteRaid_String;
		public virtual RMethod RCanEliteRaid_String
		{
			get
			{
				if(r_RCanEliteRaid_String == null)
				{
					r_RCanEliteRaid_String = new(this, "CanEliteRaid", 0, typeof(System.String));
					r_RCanEliteRaid_String.SetBelong(this.instance);
				}
				return r_RCanEliteRaid_String;
			}
		}

		/// <summary>
		/// Void OnRaidRecord(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidRecord_Object___0__Isb;
		public virtual RMethod ROnRaidRecord_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidRecord_Object___0__Isb == null)
				{
					r_ROnRaidRecord_Object___0__Isb = new(this, "OnRaidRecord", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidRecord_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidRecord_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnRaidRecordAdd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidRecordAdd_Object___0__Isb;
		public virtual RMethod ROnRaidRecordAdd_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidRecordAdd_Object___0__Isb == null)
				{
					r_ROnRaidRecordAdd_Object___0__Isb = new(this, "OnRaidRecordAdd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidRecordAdd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidRecordAdd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnRaidPanel(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidPanel_Object___0__Isb;
		public virtual RMethod ROnRaidPanel_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidPanel_Object___0__Isb == null)
				{
					r_ROnRaidPanel_Object___0__Isb = new(this, "OnRaidPanel", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidPanel_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidPanel_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void _OnRaidPanel(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R_OnRaidPanel_Object___0__n6c;
		public virtual RMethod R_OnRaidPanel_Object___0__n6c
		{
			get
			{
				if(r_R_OnRaidPanel_Object___0__n6c == null)
				{
					r_R_OnRaidPanel_Object___0__n6c = new(this, "_OnRaidPanel", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R_OnRaidPanel_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R_OnRaidPanel_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void OnRaidResult(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidResult_Object___0__Isb;
		public virtual RMethod ROnRaidResult_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidResult_Object___0__Isb == null)
				{
					r_ROnRaidResult_Object___0__Isb = new(this, "OnRaidResult", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidResult_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidResult_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void _OnRaidResult(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R_OnRaidResult_Object___0__n6c;
		public virtual RMethod R_OnRaidResult_Object___0__n6c
		{
			get
			{
				if(r_R_OnRaidResult_Object___0__n6c == null)
				{
					r_R_OnRaidResult_Object___0__n6c = new(this, "_OnRaidResult", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R_OnRaidResult_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R_OnRaidResult_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void OnRaidReward(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidReward_Object___0__Isb;
		public virtual RMethod ROnRaidReward_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidReward_Object___0__Isb == null)
				{
					r_ROnRaidReward_Object___0__Isb = new(this, "OnRaidReward", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidReward_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidReward_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnBossMapEnter()
		/// </summary>
		protected RMethod r_ROnBossMapEnter;
		public virtual RMethod ROnBossMapEnter
		{
			get
			{
				if(r_ROnBossMapEnter == null)
				{
					r_ROnBossMapEnter = new(this, "OnBossMapEnter", 0);
					r_ROnBossMapEnter.SetBelong(this.instance);
				}
				return r_ROnBossMapEnter;
			}
		}

		/// <summary>
		/// Void OnTaskMapEnter(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTaskMapEnter_Object___0__Isb;
		public virtual RMethod ROnTaskMapEnter_Object___0__Isb
		{
			get
			{
				if(r_ROnTaskMapEnter_Object___0__Isb == null)
				{
					r_ROnTaskMapEnter_Object___0__Isb = new(this, "OnTaskMapEnter", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTaskMapEnter_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTaskMapEnter_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SetRaidStatus()
		/// </summary>
		protected RMethod r_RSetRaidStatus;
		public virtual RMethod RSetRaidStatus
		{
			get
			{
				if(r_RSetRaidStatus == null)
				{
					r_RSetRaidStatus = new(this, "SetRaidStatus", 0);
					r_RSetRaidStatus.SetBelong(this.instance);
				}
				return r_RSetRaidStatus;
			}
		}

		/// <summary>
		/// Void OnMapDestroy(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnMapDestroy_Object___0__Isb;
		public virtual RMethod ROnMapDestroy_Object___0__Isb
		{
			get
			{
				if(r_ROnMapDestroy_Object___0__Isb == null)
				{
					r_ROnMapDestroy_Object___0__Isb = new(this, "OnMapDestroy", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnMapDestroy_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnMapDestroy_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void _OnMapDestroy(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R_OnMapDestroy_Object___0__n6c;
		public virtual RMethod R_OnMapDestroy_Object___0__n6c
		{
			get
			{
				if(r_R_OnMapDestroy_Object___0__n6c == null)
				{
					r_R_OnMapDestroy_Object___0__n6c = new(this, "_OnMapDestroy", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R_OnMapDestroy_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R_OnMapDestroy_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void MapDestroyConfirm(System.Object)
		/// </summary>
		protected RMethod r_RMapDestroyConfirm_Object;
		public virtual RMethod RMapDestroyConfirm_Object
		{
			get
			{
				if(r_RMapDestroyConfirm_Object == null)
				{
					r_RMapDestroyConfirm_Object = new(this, "MapDestroyConfirm", 0, typeof(System.Object));
					r_RMapDestroyConfirm_Object.SetBelong(this.instance);
				}
				return r_RMapDestroyConfirm_Object;
			}
		}

		/// <summary>
		/// Void OnRaidStatus(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidStatus_Object___0__Isb;
		public virtual RMethod ROnRaidStatus_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidStatus_Object___0__Isb == null)
				{
					r_ROnRaidStatus_Object___0__Isb = new(this, "OnRaidStatus", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidStatus_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidStatus_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void _OnRaidStatus(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R_OnRaidStatus_Object___0__n6c;
		public virtual RMethod R_OnRaidStatus_Object___0__n6c
		{
			get
			{
				if(r_R_OnRaidStatus_Object___0__n6c == null)
				{
					r_R_OnRaidStatus_Object___0__n6c = new(this, "_OnRaidStatus", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R_OnRaidStatus_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R_OnRaidStatus_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void OnRaidRepeatResult(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidRepeatResult_Object___0__Isb;
		public virtual RMethod ROnRaidRepeatResult_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidRepeatResult_Object___0__Isb == null)
				{
					r_ROnRaidRepeatResult_Object___0__Isb = new(this, "OnRaidRepeatResult", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidRepeatResult_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidRepeatResult_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnRaidRepeatInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidRepeatInfo_Object___0__Isb;
		public virtual RMethod ROnRaidRepeatInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidRepeatInfo_Object___0__Isb == null)
				{
					r_ROnRaidRepeatInfo_Object___0__Isb = new(this, "OnRaidRepeatInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidRepeatInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidRepeatInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnRaidRepeatOver(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidRepeatOver_Object___0__Isb;
		public virtual RMethod ROnRaidRepeatOver_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidRepeatOver_Object___0__Isb == null)
				{
					r_ROnRaidRepeatOver_Object___0__Isb = new(this, "OnRaidRepeatOver", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidRepeatOver_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidRepeatOver_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnDevilWellTrampleOver(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDevilWellTrampleOver_Object___0__Isb;
		public virtual RMethod ROnDevilWellTrampleOver_Object___0__Isb
		{
			get
			{
				if(r_ROnDevilWellTrampleOver_Object___0__Isb == null)
				{
					r_ROnDevilWellTrampleOver_Object___0__Isb = new(this, "OnDevilWellTrampleOver", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDevilWellTrampleOver_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDevilWellTrampleOver_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnRaidRepeatReward(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidRepeatReward_Object___0__Isb;
		public virtual RMethod ROnRaidRepeatReward_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidRepeatReward_Object___0__Isb == null)
				{
					r_ROnRaidRepeatReward_Object___0__Isb = new(this, "OnRaidRepeatReward", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidRepeatReward_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidRepeatReward_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendCreateRaid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendCreateRaid_ID;
		public virtual RMethod RSendCreateRaid_ID
		{
			get
			{
				if(r_RSendCreateRaid_ID == null)
				{
					r_RSendCreateRaid_ID = new(this, "SendCreateRaid", 0, typeof(GameDefineType.ID));
					r_RSendCreateRaid_ID.SetBelong(this.instance);
				}
				return r_RSendCreateRaid_ID;
			}
		}

		/// <summary>
		/// Void SendLeaveRaid()
		/// </summary>
		protected RMethod r_RSendLeaveRaid;
		public virtual RMethod RSendLeaveRaid
		{
			get
			{
				if(r_RSendLeaveRaid == null)
				{
					r_RSendLeaveRaid = new(this, "SendLeaveRaid", 0);
					r_RSendLeaveRaid.SetBelong(this.instance);
				}
				return r_RSendLeaveRaid;
			}
		}

		/// <summary>
		/// Void SendPickupItem(Int32)
		/// </summary>
		protected RMethod r_RSendPickupItem_Int32;
		public virtual RMethod RSendPickupItem_Int32
		{
			get
			{
				if(r_RSendPickupItem_Int32 == null)
				{
					r_RSendPickupItem_Int32 = new(this, "SendPickupItem", 0, typeof(System.Int32));
					r_RSendPickupItem_Int32.SetBelong(this.instance);
				}
				return r_RSendPickupItem_Int32;
			}
		}

		/// <summary>
		/// Void SendPickupAll()
		/// </summary>
		protected RMethod r_RSendPickupAll;
		public virtual RMethod RSendPickupAll
		{
			get
			{
				if(r_RSendPickupAll == null)
				{
					r_RSendPickupAll = new(this, "SendPickupAll", 0);
					r_RSendPickupAll.SetBelong(this.instance);
				}
				return r_RSendPickupAll;
			}
		}

		/// <summary>
		/// Void SendReplayRaid()
		/// </summary>
		protected RMethod r_RSendReplayRaid;
		public virtual RMethod RSendReplayRaid
		{
			get
			{
				if(r_RSendReplayRaid == null)
				{
					r_RSendReplayRaid = new(this, "SendReplayRaid", 0);
					r_RSendReplayRaid.SetBelong(this.instance);
				}
				return r_RSendReplayRaid;
			}
		}

		/// <summary>
		/// Void SendStartRaidRepeat(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_RSendStartRaidRepeat_ID_Int32;
		public virtual RMethod RSendStartRaidRepeat_ID_Int32
		{
			get
			{
				if(r_RSendStartRaidRepeat_ID_Int32 == null)
				{
					r_RSendStartRaidRepeat_ID_Int32 = new(this, "SendStartRaidRepeat", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_RSendStartRaidRepeat_ID_Int32.SetBelong(this.instance);
				}
				return r_RSendStartRaidRepeat_ID_Int32;
			}
		}

		/// <summary>
		/// Void SendStartRaidRepeatElite(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendStartRaidRepeatElite_ID;
		public virtual RMethod RSendStartRaidRepeatElite_ID
		{
			get
			{
				if(r_RSendStartRaidRepeatElite_ID == null)
				{
					r_RSendStartRaidRepeatElite_ID = new(this, "SendStartRaidRepeatElite", 0, typeof(GameDefineType.ID));
					r_RSendStartRaidRepeatElite_ID.SetBelong(this.instance);
				}
				return r_RSendStartRaidRepeatElite_ID;
			}
		}

		/// <summary>
		/// Void SendCancelRaidRepeat()
		/// </summary>
		protected RMethod r_RSendCancelRaidRepeat;
		public virtual RMethod RSendCancelRaidRepeat
		{
			get
			{
				if(r_RSendCancelRaidRepeat == null)
				{
					r_RSendCancelRaidRepeat = new(this, "SendCancelRaidRepeat", 0);
					r_RSendCancelRaidRepeat.SetBelong(this.instance);
				}
				return r_RSendCancelRaidRepeat;
			}
		}

		/// <summary>
		/// Void SendCompImme()
		/// </summary>
		protected RMethod r_RSendCompImme;
		public virtual RMethod RSendCompImme
		{
			get
			{
				if(r_RSendCompImme == null)
				{
					r_RSendCompImme = new(this, "SendCompImme", 0);
					r_RSendCompImme.SetBelong(this.instance);
				}
				return r_RSendCompImme;
			}
		}

		/// <summary>
		/// Void RequestPickSeriesPerfectReward(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RRequestPickSeriesPerfectReward_ID;
		public virtual RMethod RRequestPickSeriesPerfectReward_ID
		{
			get
			{
				if(r_RRequestPickSeriesPerfectReward_ID == null)
				{
					r_RRequestPickSeriesPerfectReward_ID = new(this, "RequestPickSeriesPerfectReward", 0, typeof(GameDefineType.ID));
					r_RRequestPickSeriesPerfectReward_ID.SetBelong(this.instance);
				}
				return r_RRequestPickSeriesPerfectReward_ID;
			}
		}

		/// <summary>
		/// Void RequestPickSeriesNormalReward(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RRequestPickSeriesNormalReward_ID;
		public virtual RMethod RRequestPickSeriesNormalReward_ID
		{
			get
			{
				if(r_RRequestPickSeriesNormalReward_ID == null)
				{
					r_RRequestPickSeriesNormalReward_ID = new(this, "RequestPickSeriesNormalReward", 0, typeof(GameDefineType.ID));
					r_RRequestPickSeriesNormalReward_ID.SetBelong(this.instance);
				}
				return r_RRequestPickSeriesNormalReward_ID;
			}
		}

		/// <summary>
		/// Void RequestQueryRaidRepeatInfo()
		/// </summary>
		protected RMethod r_RRequestQueryRaidRepeatInfo;
		public virtual RMethod RRequestQueryRaidRepeatInfo
		{
			get
			{
				if(r_RRequestQueryRaidRepeatInfo == null)
				{
					r_RRequestQueryRaidRepeatInfo = new(this, "RequestQueryRaidRepeatInfo", 0);
					r_RRequestQueryRaidRepeatInfo.SetBelong(this.instance);
				}
				return r_RRequestQueryRaidRepeatInfo;
			}
		}

		/// <summary>
		/// Void RequestRaidRepeatReward()
		/// </summary>
		protected RMethod r_RRequestRaidRepeatReward;
		public virtual RMethod RRequestRaidRepeatReward
		{
			get
			{
				if(r_RRequestRaidRepeatReward == null)
				{
					r_RRequestRaidRepeatReward = new(this, "RequestRaidRepeatReward", 0);
					r_RRequestRaidRepeatReward.SetBelong(this.instance);
				}
				return r_RRequestRaidRepeatReward;
			}
		}

		/// <summary>
		/// Void SendContinueRaid()
		/// </summary>
		protected RMethod r_RSendContinueRaid;
		public virtual RMethod RSendContinueRaid
		{
			get
			{
				if(r_RSendContinueRaid == null)
				{
					r_RSendContinueRaid = new(this, "SendContinueRaid", 0);
					r_RSendContinueRaid.SetBelong(this.instance);
				}
				return r_RSendContinueRaid;
			}
		}

		/// <summary>
		/// Void RequestRaidResetElite(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RRequestRaidResetElite_ID;
		public virtual RMethod RRequestRaidResetElite_ID
		{
			get
			{
				if(r_RRequestRaidResetElite_ID == null)
				{
					r_RRequestRaidResetElite_ID = new(this, "RequestRaidResetElite", 0, typeof(GameDefineType.ID));
					r_RRequestRaidResetElite_ID.SetBelong(this.instance);
				}
				return r_RRequestRaidResetElite_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID GetCurrRaidID()
		/// </summary>
		protected RMethod r_RGetCurrRaidID;
		public virtual RMethod RGetCurrRaidID
		{
			get
			{
				if(r_RGetCurrRaidID == null)
				{
					r_RGetCurrRaidID = new(this, "GetCurrRaidID", 0);
					r_RGetCurrRaidID.SetBelong(this.instance);
				}
				return r_RGetCurrRaidID;
			}
		}

		/// <summary>
		/// RAID_INFO GetCurrRaidInfo()
		/// </summary>
		protected RMethod r_RGetCurrRaidInfo;
		public virtual RMethod RGetCurrRaidInfo
		{
			get
			{
				if(r_RGetCurrRaidInfo == null)
				{
					r_RGetCurrRaidInfo = new(this, "GetCurrRaidInfo", 0);
					r_RGetCurrRaidInfo.SetBelong(this.instance);
				}
				return r_RGetCurrRaidInfo;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
			}
		}

		/// <summary>
		/// Void ParseRewardStr(System.String, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef, System.String ByRef)
		/// </summary>
		protected static RMethod r_RParseRewardStr_String_Ref_String_Ref_String_Ref_String_Ref_String_Ref_String;
		public static RMethod RParseRewardStr_String_Ref_String_Ref_String_Ref_String_Ref_String_Ref_String
		{
			get
			{
				if(r_RParseRewardStr_String_Ref_String_Ref_String_Ref_String_Ref_String_Ref_String == null)
				{
					r_RParseRewardStr_String_Ref_String_Ref_String_Ref_String_Ref_String_Ref_String = new( ReleactionUtils.GetType("RaidManager"), "ParseRewardStr", 0, typeof(System.String), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType(), typeof(System.String).MakeByRefType());
					r_RParseRewardStr_String_Ref_String_Ref_String_Ref_String_Ref_String_Ref_String.SetBelong(null);
				}
				return r_RParseRewardStr_String_Ref_String_Ref_String_Ref_String_Ref_String_Ref_String;
			}
		}

		/// <summary>
		/// Boolean IsRaidScene(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RIsRaidScene_ID;
		public virtual RMethod RIsRaidScene_ID
		{
			get
			{
				if(r_RIsRaidScene_ID == null)
				{
					r_RIsRaidScene_ID = new(this, "IsRaidScene", 0, typeof(GameDefineType.ID));
					r_RIsRaidScene_ID.SetBelong(this.instance);
				}
				return r_RIsRaidScene_ID;
			}
		}

		/// <summary>
		/// System.String[] GetRaidRewardEffectUrls()
		/// </summary>
		protected RMethod r_RGetRaidRewardEffectUrls;
		public virtual RMethod RGetRaidRewardEffectUrls
		{
			get
			{
				if(r_RGetRaidRewardEffectUrls == null)
				{
					r_RGetRaidRewardEffectUrls = new(this, "GetRaidRewardEffectUrls", 0);
					r_RGetRaidRewardEffectUrls.SetBelong(this.instance);
				}
				return r_RGetRaidRewardEffectUrls;
			}
		}

		/// <summary>
		/// Void LoadRewardEffect(ABLoadingHandler, ABLoadedHandler)
		/// </summary>
		protected RMethod r_RLoadRewardEffect_ABLoadingHandler_ABLoadedHandler;
		public virtual RMethod RLoadRewardEffect_ABLoadingHandler_ABLoadedHandler
		{
			get
			{
				if(r_RLoadRewardEffect_ABLoadingHandler_ABLoadedHandler == null)
				{
					r_RLoadRewardEffect_ABLoadingHandler_ABLoadedHandler = new(this, "LoadRewardEffect", 0,  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingHandler"),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedHandler"));
					r_RLoadRewardEffect_ABLoadingHandler_ABLoadedHandler.SetBelong(this.instance);
				}
				return r_RLoadRewardEffect_ABLoadingHandler_ABLoadedHandler;
			}
		}

		/// <summary>
		/// Void OnLoadHammer(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadHammer_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadHammer_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadHammer_Object_ABLoadedArgs == null)
				{
					r_ROnLoadHammer_Object_ABLoadedArgs = new(this, "OnLoadHammer", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadHammer_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadHammer_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadBottle(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadBottle_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadBottle_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadBottle_Object_ABLoadedArgs == null)
				{
					r_ROnLoadBottle_Object_ABLoadedArgs = new(this, "OnLoadBottle", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadBottle_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadBottle_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadRaidStarConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadRaidStarConfig_Object;
		public virtual RMethod ROnLoadRaidStarConfig_Object
		{
			get
			{
				if(r_ROnLoadRaidStarConfig_Object == null)
				{
					r_ROnLoadRaidStarConfig_Object = new(this, "OnLoadRaidStarConfig", 0, typeof(System.Object));
					r_ROnLoadRaidStarConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRaidStarConfig_Object;
			}
		}

		/// <summary>
		/// RAID_STAR_INFO GetRaidStarInfo(Int32)
		/// </summary>
		protected RMethod r_RGetRaidStarInfo_Int32;
		public virtual RMethod RGetRaidStarInfo_Int32
		{
			get
			{
				if(r_RGetRaidStarInfo_Int32 == null)
				{
					r_RGetRaidStarInfo_Int32 = new(this, "GetRaidStarInfo", 0, typeof(System.Int32));
					r_RGetRaidStarInfo_Int32.SetBelong(this.instance);
				}
				return r_RGetRaidStarInfo_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_STAR_INFO] GetRaidStarList(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetRaidStarList_Int32_Int32;
		public virtual RMethod RGetRaidStarList_Int32_Int32
		{
			get
			{
				if(r_RGetRaidStarList_Int32_Int32 == null)
				{
					r_RGetRaidStarList_Int32_Int32 = new(this, "GetRaidStarList", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetRaidStarList_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetRaidStarList_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RAID_STAR_INFO] GetRaidStarList(Int32)
		/// </summary>
		protected RMethod r_RGetRaidStarList_Int32;
		public virtual RMethod RGetRaidStarList_Int32
		{
			get
			{
				if(r_RGetRaidStarList_Int32 == null)
				{
					r_RGetRaidStarList_Int32 = new(this, "GetRaidStarList", 0, typeof(System.Int32));
					r_RGetRaidStarList_Int32.SetBelong(this.instance);
				}
				return r_RGetRaidStarList_Int32;
			}
		}

		/// <summary>
		/// Void OnRaidStarRewardState(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRaidStarRewardState_Object___0__Isb;
		public virtual RMethod ROnRaidStarRewardState_Object___0__Isb
		{
			get
			{
				if(r_ROnRaidStarRewardState_Object___0__Isb == null)
				{
					r_ROnRaidStarRewardState_Object___0__Isb = new(this, "OnRaidStarRewardState", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRaidStarRewardState_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRaidStarRewardState_Object___0__Isb;
			}
		}

		/// <summary>
		/// Boolean IsRaidStarRewarded(Int32)
		/// </summary>
		protected RMethod r_RIsRaidStarRewarded_Int32;
		public virtual RMethod RIsRaidStarRewarded_Int32
		{
			get
			{
				if(r_RIsRaidStarRewarded_Int32 == null)
				{
					r_RIsRaidStarRewarded_Int32 = new(this, "IsRaidStarRewarded", 0, typeof(System.Int32));
					r_RIsRaidStarRewarded_Int32.SetBelong(this.instance);
				}
				return r_RIsRaidStarRewarded_Int32;
			}
		}

		/// <summary>
		/// Void SendGetStarReward(Int32)
		/// </summary>
		protected RMethod r_RSendGetStarReward_Int32;
		public virtual RMethod RSendGetStarReward_Int32
		{
			get
			{
				if(r_RSendGetStarReward_Int32 == null)
				{
					r_RSendGetStarReward_Int32 = new(this, "SendGetStarReward", 0, typeof(System.Int32));
					r_RSendGetStarReward_Int32.SetBelong(this.instance);
				}
				return r_RSendGetStarReward_Int32;
			}
		}

		/// <summary>
		/// Void SendQueryStarReward()
		/// </summary>
		protected RMethod r_RSendQueryStarReward;
		public virtual RMethod RSendQueryStarReward
		{
			get
			{
				if(r_RSendQueryStarReward == null)
				{
					r_RSendQueryStarReward = new(this, "SendQueryStarReward", 0);
					r_RSendQueryStarReward.SetBelong(this.instance);
				}
				return r_RSendQueryStarReward;
			}
		}

		/// <summary>
		/// Void GetRaidStarNum(GameDefineType.ID, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RGetRaidStarNum_ID_Ref_Int32_Ref_Int32;
		public virtual RMethod RGetRaidStarNum_ID_Ref_Int32_Ref_Int32
		{
			get
			{
				if(r_RGetRaidStarNum_ID_Ref_Int32_Ref_Int32 == null)
				{
					r_RGetRaidStarNum_ID_Ref_Int32_Ref_Int32 = new(this, "GetRaidStarNum", 0, typeof(GameDefineType.ID), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RGetRaidStarNum_ID_Ref_Int32_Ref_Int32.SetBelong(this.instance);
				}
				return r_RGetRaidStarNum_ID_Ref_Int32_Ref_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadDevilShopConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadDevilShopConfig_Object;
		public virtual RMethod ROnLoadDevilShopConfig_Object
		{
			get
			{
				if(r_ROnLoadDevilShopConfig_Object == null)
				{
					r_ROnLoadDevilShopConfig_Object = new(this, "OnLoadDevilShopConfig", 0, typeof(System.Object));
					r_ROnLoadDevilShopConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadDevilShopConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[DEVIL_SHOP_INFO] GetDevilShopInfoByType(Int32)
		/// </summary>
		protected RMethod r_RGetDevilShopInfoByType_Int32;
		public virtual RMethod RGetDevilShopInfoByType_Int32
		{
			get
			{
				if(r_RGetDevilShopInfoByType_Int32 == null)
				{
					r_RGetDevilShopInfoByType_Int32 = new(this, "GetDevilShopInfoByType", 0, typeof(System.Int32));
					r_RGetDevilShopInfoByType_Int32.SetBelong(this.instance);
				}
				return r_RGetDevilShopInfoByType_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadDevilAutoConfig(System.Object)
		/// </summary>
		protected RMethod r_ROnLoadDevilAutoConfig_Object;
		public virtual RMethod ROnLoadDevilAutoConfig_Object
		{
			get
			{
				if(r_ROnLoadDevilAutoConfig_Object == null)
				{
					r_ROnLoadDevilAutoConfig_Object = new(this, "OnLoadDevilAutoConfig", 0, typeof(System.Object));
					r_ROnLoadDevilAutoConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadDevilAutoConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[DEVIL_AUTO_INFO] GetDevilAutoInfos(Int32)
		/// </summary>
		protected RMethod r_RGetDevilAutoInfos_Int32;
		public virtual RMethod RGetDevilAutoInfos_Int32
		{
			get
			{
				if(r_RGetDevilAutoInfos_Int32 == null)
				{
					r_RGetDevilAutoInfos_Int32 = new(this, "GetDevilAutoInfos", 0, typeof(System.Int32));
					r_RGetDevilAutoInfos_Int32.SetBelong(this.instance);
				}
				return r_RGetDevilAutoInfos_Int32;
			}
		}

		/// <summary>
		/// Int32 GetStageOfLevel(Int32)
		/// </summary>
		protected RMethod r_RGetStageOfLevel_Int32;
		public virtual RMethod RGetStageOfLevel_Int32
		{
			get
			{
				if(r_RGetStageOfLevel_Int32 == null)
				{
					r_RGetStageOfLevel_Int32 = new(this, "GetStageOfLevel", 0, typeof(System.Int32));
					r_RGetStageOfLevel_Int32.SetBelong(this.instance);
				}
				return r_RGetStageOfLevel_Int32;
			}
		}

		/// <summary>
		/// Void OnDevilWellInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDevilWellInfo_Object___0__Isb;
		public virtual RMethod ROnDevilWellInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnDevilWellInfo_Object___0__Isb == null)
				{
					r_ROnDevilWellInfo_Object___0__Isb = new(this, "OnDevilWellInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDevilWellInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDevilWellInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnDevilWellTrampleInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDevilWellTrampleInfo_Object___0__Isb;
		public virtual RMethod ROnDevilWellTrampleInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnDevilWellTrampleInfo_Object___0__Isb == null)
				{
					r_ROnDevilWellTrampleInfo_Object___0__Isb = new(this, "OnDevilWellTrampleInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDevilWellTrampleInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDevilWellTrampleInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnDevilTrampleStart(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDevilTrampleStart_Object___0__Isb;
		public virtual RMethod ROnDevilTrampleStart_Object___0__Isb
		{
			get
			{
				if(r_ROnDevilTrampleStart_Object___0__Isb == null)
				{
					r_ROnDevilTrampleStart_Object___0__Isb = new(this, "OnDevilTrampleStart", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDevilTrampleStart_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDevilTrampleStart_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnDevilWellPower(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDevilWellPower_Object___0__Isb;
		public virtual RMethod ROnDevilWellPower_Object___0__Isb
		{
			get
			{
				if(r_ROnDevilWellPower_Object___0__Isb == null)
				{
					r_ROnDevilWellPower_Object___0__Isb = new(this, "OnDevilWellPower", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDevilWellPower_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDevilWellPower_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void UpdateLevelStage(System.String)
		/// </summary>
		protected RMethod r_RUpdateLevelStage_String;
		public virtual RMethod RUpdateLevelStage_String
		{
			get
			{
				if(r_RUpdateLevelStage_String == null)
				{
					r_RUpdateLevelStage_String = new(this, "UpdateLevelStage", 0, typeof(System.String));
					r_RUpdateLevelStage_String.SetBelong(this.instance);
				}
				return r_RUpdateLevelStage_String;
			}
		}

		/// <summary>
		/// Void OnDevilWellLevelStage(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDevilWellLevelStage_Object___0__Isb;
		public virtual RMethod ROnDevilWellLevelStage_Object___0__Isb
		{
			get
			{
				if(r_ROnDevilWellLevelStage_Object___0__Isb == null)
				{
					r_ROnDevilWellLevelStage_Object___0__Isb = new(this, "OnDevilWellLevelStage", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDevilWellLevelStage_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDevilWellLevelStage_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void ONDevilWellResetCost(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_RONDevilWellResetCost_Object___0__Isb;
		public virtual RMethod RONDevilWellResetCost_Object___0__Isb
		{
			get
			{
				if(r_RONDevilWellResetCost_Object___0__Isb == null)
				{
					r_RONDevilWellResetCost_Object___0__Isb = new(this, "ONDevilWellResetCost", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_RONDevilWellResetCost_Object___0__Isb.SetBelong(this.instance);
				}
				return r_RONDevilWellResetCost_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnDevilWellTimes(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDevilWellTimes_Object___0__Isb;
		public virtual RMethod ROnDevilWellTimes_Object___0__Isb
		{
			get
			{
				if(r_ROnDevilWellTimes_Object___0__Isb == null)
				{
					r_ROnDevilWellTimes_Object___0__Isb = new(this, "OnDevilWellTimes", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDevilWellTimes_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDevilWellTimes_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendDevilWellQuery()
		/// </summary>
		protected RMethod r_RSendDevilWellQuery;
		public virtual RMethod RSendDevilWellQuery
		{
			get
			{
				if(r_RSendDevilWellQuery == null)
				{
					r_RSendDevilWellQuery = new(this, "SendDevilWellQuery", 0);
					r_RSendDevilWellQuery.SetBelong(this.instance);
				}
				return r_RSendDevilWellQuery;
			}
		}

		/// <summary>
		/// Void SendDevilWellQueryTrample()
		/// </summary>
		protected RMethod r_RSendDevilWellQueryTrample;
		public virtual RMethod RSendDevilWellQueryTrample
		{
			get
			{
				if(r_RSendDevilWellQueryTrample == null)
				{
					r_RSendDevilWellQueryTrample = new(this, "SendDevilWellQueryTrample", 0);
					r_RSendDevilWellQueryTrample.SetBelong(this.instance);
				}
				return r_RSendDevilWellQueryTrample;
			}
		}

		/// <summary>
		/// Void SendDevilWellReset()
		/// </summary>
		protected RMethod r_RSendDevilWellReset;
		public virtual RMethod RSendDevilWellReset
		{
			get
			{
				if(r_RSendDevilWellReset == null)
				{
					r_RSendDevilWellReset = new(this, "SendDevilWellReset", 0);
					r_RSendDevilWellReset.SetBelong(this.instance);
				}
				return r_RSendDevilWellReset;
			}
		}

		/// <summary>
		/// Void SendDevilWellBuy(Int32, Int32)
		/// </summary>
		protected RMethod r_RSendDevilWellBuy_Int32_Int32;
		public virtual RMethod RSendDevilWellBuy_Int32_Int32
		{
			get
			{
				if(r_RSendDevilWellBuy_Int32_Int32 == null)
				{
					r_RSendDevilWellBuy_Int32_Int32 = new(this, "SendDevilWellBuy", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSendDevilWellBuy_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSendDevilWellBuy_Int32_Int32;
			}
		}

		/// <summary>
		/// Void UpdateDevilPoint(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RUpdateDevilPoint_Object_Object;
		public virtual RMethod RUpdateDevilPoint_Object_Object
		{
			get
			{
				if(r_RUpdateDevilPoint_Object_Object == null)
				{
					r_RUpdateDevilPoint_Object_Object = new(this, "UpdateDevilPoint", 0, typeof(System.Object), typeof(System.Object));
					r_RUpdateDevilPoint_Object_Object.SetBelong(this.instance);
				}
				return r_RUpdateDevilPoint_Object_Object;
			}
		}

		/// <summary>
		/// Void SendDevilWellUseItem(Int32)
		/// </summary>
		protected RMethod r_RSendDevilWellUseItem_Int32;
		public virtual RMethod RSendDevilWellUseItem_Int32
		{
			get
			{
				if(r_RSendDevilWellUseItem_Int32 == null)
				{
					r_RSendDevilWellUseItem_Int32 = new(this, "SendDevilWellUseItem", 0, typeof(System.Int32));
					r_RSendDevilWellUseItem_Int32.SetBelong(this.instance);
				}
				return r_RSendDevilWellUseItem_Int32;
			}
		}

		/// <summary>
		/// Void SendBuyChallenge()
		/// </summary>
		protected RMethod r_RSendBuyChallenge;
		public virtual RMethod RSendBuyChallenge
		{
			get
			{
				if(r_RSendBuyChallenge == null)
				{
					r_RSendBuyChallenge = new(this, "SendBuyChallenge", 0);
					r_RSendBuyChallenge.SetBelong(this.instance);
				}
				return r_RSendBuyChallenge;
			}
		}

		/// <summary>
		/// Void SendDevilTrample()
		/// </summary>
		protected RMethod r_RSendDevilTrample;
		public virtual RMethod RSendDevilTrample
		{
			get
			{
				if(r_RSendDevilTrample == null)
				{
					r_RSendDevilTrample = new(this, "SendDevilTrample", 0);
					r_RSendDevilTrample.SetBelong(this.instance);
				}
				return r_RSendDevilTrample;
			}
		}

		/// <summary>
		/// Void SendStopDevilTrample()
		/// </summary>
		protected RMethod r_RSendStopDevilTrample;
		public virtual RMethod RSendStopDevilTrample
		{
			get
			{
				if(r_RSendStopDevilTrample == null)
				{
					r_RSendStopDevilTrample = new(this, "SendStopDevilTrample", 0);
					r_RSendStopDevilTrample.SetBelong(this.instance);
				}
				return r_RSendStopDevilTrample;
			}
		}

		/// <summary>
		/// Void SendFinishDevilTrample()
		/// </summary>
		protected RMethod r_RSendFinishDevilTrample;
		public virtual RMethod RSendFinishDevilTrample
		{
			get
			{
				if(r_RSendFinishDevilTrample == null)
				{
					r_RSendFinishDevilTrample = new(this, "SendFinishDevilTrample", 0);
					r_RSendFinishDevilTrample.SetBelong(this.instance);
				}
				return r_RSendFinishDevilTrample;
			}
		}

		/// <summary>
		/// Void OnDevilWellExp(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnDevilWellExp_Object___0__Isb;
		public virtual RMethod ROnDevilWellExp_Object___0__Isb
		{
			get
			{
				if(r_ROnDevilWellExp_Object___0__Isb == null)
				{
					r_ROnDevilWellExp_Object___0__Isb = new(this, "OnDevilWellExp", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnDevilWellExp_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnDevilWellExp_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void _OnDevilWellFirstReward(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R_OnDevilWellFirstReward_Object___0__Isb;
		public virtual RMethod R_OnDevilWellFirstReward_Object___0__Isb
		{
			get
			{
				if(r_R_OnDevilWellFirstReward_Object___0__Isb == null)
				{
					r_R_OnDevilWellFirstReward_Object___0__Isb = new(this, "_OnDevilWellFirstReward", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R_OnDevilWellFirstReward_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R_OnDevilWellFirstReward_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnDevilWellFirstReward(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_ROnDevilWellFirstReward_Object___0__n6c;
		public virtual RMethod ROnDevilWellFirstReward_Object___0__n6c
		{
			get
			{
				if(r_ROnDevilWellFirstReward_Object___0__n6c == null)
				{
					r_ROnDevilWellFirstReward_Object___0__n6c = new(this, "OnDevilWellFirstReward", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_ROnDevilWellFirstReward_Object___0__n6c.SetBelong(this.instance);
				}
				return r_ROnDevilWellFirstReward_Object___0__n6c;
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


        public RRaidManager() : base("RaidManager")
        {
        }

        public RRaidManager(System.Object instance) : base("RaidManager")
		{
            SetInstance(instance);
		}

        public RRaidManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRaidManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadRaidElite2TimesConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadRaidElite2TimesConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetRaidElite2RefreshGold(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetRaidElite2RefreshGold_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void OnLoadRaidInfoConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadRaidInfoConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RAID_INFO GetRaidInfo(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetRaidInfo_ID.Invoke(___genericsType, ___parameters);

            return (RAID_INFO)___result;
        }


        public virtual System.Collections.Generic.List<GameDefineType.ID> GetEliteRaidSceneIDs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEliteRaidSceneIDs.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }


        public virtual System.Collections.Generic.List<RAID_INFO> GetRaidInfosBySceneID(GameDefineType.ID  @sceneId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneId};
            var ___result = RGetRaidInfosBySceneID_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<RAID_INFO>)___result;
        }


        public virtual System.Collections.Generic.List<GameDefineType.ID> GetSceneIDList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSceneIDList.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }


        public virtual System.Collections.Generic.List<RAID_INFO> GetRaidInfos(GameDefineType.ID  @sceneId, GameDefineType.ID  @areaId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneId, @areaId};
            var ___result = RGetRaidInfos_ID_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<RAID_INFO>)___result;
        }


        public virtual System.Collections.Generic.List<RAID_INFO> GetRaidInfosByType(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetRaidInfosByType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<RAID_INFO>)___result;
        }


        public virtual System.Collections.Generic.List<RAID_INFO> GetRaidInfosElite(GameDefineType.ID  @areaId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@areaId};
            var ___result = RGetRaidInfosElite_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<RAID_INFO>)___result;
        }


        public virtual System.Collections.Generic.List<RAID_INFO> GetRaidInfos(System.Int32  @type, GameDefineType.ID  @areaId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @areaId};
            var ___result = RGetRaidInfos_Int32_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<RAID_INFO>)___result;
        }


        public virtual System.Boolean IsFromAndToValid(GameDefineType.ID  @from, GameDefineType.ID  @to)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to};
            var ___result = RIsFromAndToValid_ID_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Int32 GetEliteAreaCnt(System.String  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetEliteAreaCnt_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean CanEliteAreaReset(System.Int32  @areaid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@areaid};
            var ___result = RCanEliteAreaReset_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean CanEliteRaid(System.String  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RCanEliteRaid_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }









        public virtual void OnBossMapEnter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBossMapEnter.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetRaidStatus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetRaidStatus.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void MapDestroyConfirm(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RMapDestroyConfirm_Object.Invoke(___genericsType, ___parameters);

            
        }









        public virtual void SendCreateRaid(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendCreateRaid_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendLeaveRaid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendLeaveRaid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendPickupItem(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RSendPickupItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendPickupAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendPickupAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendReplayRaid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendReplayRaid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendStartRaidRepeat(GameDefineType.ID  @raidID, System.Int32  @engery)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@raidID, @engery};
            var ___result = RSendStartRaidRepeat_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendStartRaidRepeatElite(GameDefineType.ID  @idArea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idArea};
            var ___result = RSendStartRaidRepeatElite_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendCancelRaidRepeat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendCancelRaidRepeat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendCompImme()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendCompImme.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestPickSeriesPerfectReward(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RRequestPickSeriesPerfectReward_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestPickSeriesNormalReward(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RRequestPickSeriesNormalReward_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestQueryRaidRepeatInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRequestQueryRaidRepeatInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestRaidRepeatReward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRequestRaidRepeatReward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendContinueRaid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendContinueRaid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestRaidResetElite(GameDefineType.ID  @idarea)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idarea};
            var ___result = RRequestRaidResetElite_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual GameDefineType.ID GetCurrRaidID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrRaidID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual RAID_INFO GetCurrRaidInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrRaidInfo.Invoke(___genericsType, ___parameters);

            return (RAID_INFO)___result;
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public static void ParseRewardStr(System.String  @str, ref System.String  @exp, ref System.String  @money, ref System.String  @lingli, ref System.String  @point, ref System.String  @reward)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @exp, @money, @lingli, @point, @reward};
            var ___result = RParseRewardStr_String_Ref_String_Ref_String_Ref_String_Ref_String_Ref_String.Invoke(___genericsType, ___parameters);
			exp = (System.String)___parameters[1];
			money = (System.String)___parameters[2];
			lingli = (System.String)___parameters[3];
			point = (System.String)___parameters[4];
			reward = (System.String)___parameters[5];

            
        }


        public virtual System.Boolean IsRaidScene(GameDefineType.ID  @sceneID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneID};
            var ___result = RIsRaidScene_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String[] GetRaidRewardEffectUrls()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRaidRewardEffectUrls.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
        }





        public virtual void OnLoadRaidStarConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadRaidStarConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual RAID_STAR_INFO GetRaidStarInfo(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetRaidStarInfo_Int32.Invoke(___genericsType, ___parameters);

            return (RAID_STAR_INFO)___result;
        }


        public virtual System.Collections.Generic.List<RAID_STAR_INFO> GetRaidStarList(System.Int32  @mapid, System.Int32  @areaid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mapid, @areaid};
            var ___result = RGetRaidStarList_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<RAID_STAR_INFO>)___result;
        }


        public virtual System.Collections.Generic.List<RAID_STAR_INFO> GetRaidStarList(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetRaidStarList_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<RAID_STAR_INFO>)___result;
        }



        public virtual System.Boolean IsRaidStarRewarded(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RIsRaidStarRewarded_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SendGetStarReward(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendGetStarReward_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendQueryStarReward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendQueryStarReward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetRaidStarNum(GameDefineType.ID  @sceneID, ref System.Int32  @num, ref System.Int32  @total)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneID, @num, @total};
            var ___result = RGetRaidStarNum_ID_Ref_Int32_Ref_Int32.Invoke(___genericsType, ___parameters);
			num = (System.Int32)___parameters[1];
			total = (System.Int32)___parameters[2];

            
        }


        public virtual void OnLoadDevilShopConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadDevilShopConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<DEVIL_SHOP_INFO> GetDevilShopInfoByType(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetDevilShopInfoByType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<DEVIL_SHOP_INFO>)___result;
        }


        public virtual void OnLoadDevilAutoConfig(System.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadDevilAutoConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<DEVIL_AUTO_INFO> GetDevilAutoInfos(System.Int32  @mapid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mapid};
            var ___result = RGetDevilAutoInfos_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<DEVIL_AUTO_INFO>)___result;
        }


        public virtual System.Int32 GetStageOfLevel(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetStageOfLevel_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }






        public virtual void UpdateLevelStage(System.String  @info)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info};
            var ___result = RUpdateLevelStage_String.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void SendDevilWellQuery()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendDevilWellQuery.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendDevilWellQueryTrample()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendDevilWellQueryTrample.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendDevilWellReset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendDevilWellReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendDevilWellBuy(System.Int32  @itemid, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@itemid, @count};
            var ___result = RSendDevilWellBuy_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateDevilPoint(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = RUpdateDevilPoint_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendDevilWellUseItem(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RSendDevilWellUseItem_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendBuyChallenge()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendBuyChallenge.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendDevilTrample()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendDevilTrample.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendStopDevilTrample()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendStopDevilTrample.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendFinishDevilTrample()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendFinishDevilTrample.Invoke(___genericsType, ___parameters);

            
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
