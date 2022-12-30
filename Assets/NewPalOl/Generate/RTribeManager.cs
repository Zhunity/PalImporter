using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TribeManager
	/// </summary>
    public partial class RTribeManager : RMember //
    {

		/// <summary>
		/// System.String[] TRIBE_NAMES
		/// </summary>
		protected RFieldArray<RField> r_TRIBE_NAMES;
		public virtual RFieldArray<RField> RTRIBE_NAMES
		{
			get
			{
				if(r_TRIBE_NAMES == null)
				{
					r_TRIBE_NAMES = new(this, "TRIBE_NAMES");
					r_TRIBE_NAMES.SetBelong(this.instance);
				}
				return r_TRIBE_NAMES;
			}
		}

		/// <summary>
		/// GameDefineType.ID m_TribeWarSceneID
		/// </summary>
		protected RGameDefineType.RID r_m_TribeWarSceneID;
		public virtual RGameDefineType.RID Rm_TribeWarSceneID
		{
			get
			{
				if(r_m_TribeWarSceneID == null)
				{
					r_m_TribeWarSceneID = new(this, "m_TribeWarSceneID");
					r_m_TribeWarSceneID.SetBelong(this.instance);
				}
				return r_m_TribeWarSceneID;
			}
		}

		/// <summary>
		/// Message.SCNetMsgTribe m_TribeInfo
		/// </summary>
		protected RMessage.RSCNetMsgTribe r_m_TribeInfo;
		public virtual RMessage.RSCNetMsgTribe Rm_TribeInfo
		{
			get
			{
				if(r_m_TribeInfo == null)
				{
					r_m_TribeInfo = new(this, "m_TribeInfo");
					r_m_TribeInfo.SetBelong(this.instance);
				}
				return r_m_TribeInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,WarExpConfig] tribeExpTab
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RWarExpConfig> r_tribeExpTab;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RWarExpConfig> RtribeExpTab
		{
			get
			{
				if(r_tribeExpTab == null)
				{
					r_tribeExpTab = new(this, "tribeExpTab");
					r_tribeExpTab.SetBelong(this.instance);
				}
				return r_tribeExpTab;
			}
		}

		/// <summary>
		/// System.Int32[] m_TribeChangeCost
		/// </summary>
		protected RFieldArray<RField> r_m_TribeChangeCost;
		public virtual RFieldArray<RField> Rm_TribeChangeCost
		{
			get
			{
				if(r_m_TribeChangeCost == null)
				{
					r_m_TribeChangeCost = new(this, "m_TribeChangeCost");
					r_m_TribeChangeCost.SetBelong(this.instance);
				}
				return r_m_TribeChangeCost;
			}
		}

		/// <summary>
		/// System.Int32 m_nWeakestTribe
		/// </summary>
		protected RField r_m_nWeakestTribe;
		public virtual RField Rm_nWeakestTribe
		{
			get
			{
				if(r_m_nWeakestTribe == null)
				{
					r_m_nWeakestTribe = new(this, "m_nWeakestTribe");
					r_m_nWeakestTribe.SetBelong(this.instance);
				}
				return r_m_nWeakestTribe;
			}
		}

		/// <summary>
		/// KeyValueContent m_TribemoraleContent
		/// </summary>
		protected RKeyValueContent r_m_TribemoraleContent;
		public virtual RKeyValueContent Rm_TribemoraleContent
		{
			get
			{
				if(r_m_TribemoraleContent == null)
				{
					r_m_TribemoraleContent = new(this, "m_TribemoraleContent");
					r_m_TribemoraleContent.SetBelong(this.instance);
				}
				return r_m_TribemoraleContent;
			}
		}

		/// <summary>
		/// GameDefineType.ID TribeWarSceneID
		/// </summary>
		protected RGameDefineType.RID r_TribeWarSceneID;
		public virtual RGameDefineType.RID RTribeWarSceneID
		{
			get
			{
				if(r_TribeWarSceneID == null)
				{
					r_TribeWarSceneID = new(this, "TribeWarSceneID", -1);
					r_TribeWarSceneID.SetBelong(this.instance);
				}
				return r_TribeWarSceneID;
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
		/// Void OnLoadTribeExpConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadTribeExpConfig_Object;
		public virtual RMethod ROnLoadTribeExpConfig_Object
		{
			get
			{
				if(r_ROnLoadTribeExpConfig_Object == null)
				{
					r_ROnLoadTribeExpConfig_Object = new(this, "OnLoadTribeExpConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadTribeExpConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTribeExpConfig_Object;
			}
		}

		/// <summary>
		/// Void OnTribeWarNtf(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWarNtf_Object___0__Isb;
		public virtual RMethod ROnTribeWarNtf_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWarNtf_Object___0__Isb == null)
				{
					r_ROnTribeWarNtf_Object___0__Isb = new(this, "OnTribeWarNtf", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWarNtf_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWarNtf_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnGetTribe(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnGetTribe_Object___0__Isb;
		public virtual RMethod ROnGetTribe_Object___0__Isb
		{
			get
			{
				if(r_ROnGetTribe_Object___0__Isb == null)
				{
					r_ROnGetTribe_Object___0__Isb = new(this, "OnGetTribe", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnGetTribe_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnGetTribe_Object___0__Isb;
			}
		}

		/// <summary>
		/// Message.SCNetMsgTribe GetTribeInfo()
		/// </summary>
		protected RMethod r_RGetTribeInfo;
		public virtual RMethod RGetTribeInfo
		{
			get
			{
				if(r_RGetTribeInfo == null)
				{
					r_RGetTribeInfo = new(this, "GetTribeInfo", 0);
					r_RGetTribeInfo.SetBelong(this.instance);
				}
				return r_RGetTribeInfo;
			}
		}

		/// <summary>
		/// System.String GetTribeName(Int32)
		/// </summary>
		protected RMethod r_RGetTribeName_Int32;
		public virtual RMethod RGetTribeName_Int32
		{
			get
			{
				if(r_RGetTribeName_Int32 == null)
				{
					r_RGetTribeName_Int32 = new(this, "GetTribeName", 0, typeof(System.Int32));
					r_RGetTribeName_Int32.SetBelong(this.instance);
				}
				return r_RGetTribeName_Int32;
			}
		}

		/// <summary>
		/// Void OnGetTribePearlRank(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnGetTribePearlRank_Object___0__Isb;
		public virtual RMethod ROnGetTribePearlRank_Object___0__Isb
		{
			get
			{
				if(r_ROnGetTribePearlRank_Object___0__Isb == null)
				{
					r_ROnGetTribePearlRank_Object___0__Isb = new(this, "OnGetTribePearlRank", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnGetTribePearlRank_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnGetTribePearlRank_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnGetPearlInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnGetPearlInfo_Object___0__Isb;
		public virtual RMethod ROnGetPearlInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnGetPearlInfo_Object___0__Isb == null)
				{
					r_ROnGetPearlInfo_Object___0__Isb = new(this, "OnGetPearlInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnGetPearlInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnGetPearlInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeContributeExchange(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeContributeExchange_Object___0__Isb;
		public virtual RMethod ROnTribeContributeExchange_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeContributeExchange_Object___0__Isb == null)
				{
					r_ROnTribeContributeExchange_Object___0__Isb = new(this, "OnTribeContributeExchange", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeContributeExchange_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeContributeExchange_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeAppointPost(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeAppointPost_Object___0__Isb;
		public virtual RMethod ROnTribeAppointPost_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeAppointPost_Object___0__Isb == null)
				{
					r_ROnTribeAppointPost_Object___0__Isb = new(this, "OnTribeAppointPost", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeAppointPost_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeAppointPost_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeRelievePost(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeRelievePost_Object___0__Isb;
		public virtual RMethod ROnTribeRelievePost_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeRelievePost_Object___0__Isb == null)
				{
					r_ROnTribeRelievePost_Object___0__Isb = new(this, "OnTribeRelievePost", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeRelievePost_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeRelievePost_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeTask(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeTask_Object___0__Isb;
		public virtual RMethod ROnTribeTask_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeTask_Object___0__Isb == null)
				{
					r_ROnTribeTask_Object___0__Isb = new(this, "OnTribeTask", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeTask_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeTask_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeTaskTrigger(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeTaskTrigger_Object___0__Isb;
		public virtual RMethod ROnTribeTaskTrigger_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeTaskTrigger_Object___0__Isb == null)
				{
					r_ROnTribeTaskTrigger_Object___0__Isb = new(this, "OnTribeTaskTrigger", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeTaskTrigger_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeTaskTrigger_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeTaskDelete(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeTaskDelete_Object___0__Isb;
		public virtual RMethod ROnTribeTaskDelete_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeTaskDelete_Object___0__Isb == null)
				{
					r_ROnTribeTaskDelete_Object___0__Isb = new(this, "OnTribeTaskDelete", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeTaskDelete_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeTaskDelete_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeTaskStop(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeTaskStop_Object___0__Isb;
		public virtual RMethod ROnTribeTaskStop_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeTaskStop_Object___0__Isb == null)
				{
					r_ROnTribeTaskStop_Object___0__Isb = new(this, "OnTribeTaskStop", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeTaskStop_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeTaskStop_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeTaskInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeTaskInfo_Object___0__Isb;
		public virtual RMethod ROnTribeTaskInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeTaskInfo_Object___0__Isb == null)
				{
					r_ROnTribeTaskInfo_Object___0__Isb = new(this, "OnTribeTaskInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeTaskInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeTaskInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeNotice(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeNotice_Object___0__Isb;
		public virtual RMethod ROnTribeNotice_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeNotice_Object___0__Isb == null)
				{
					r_ROnTribeNotice_Object___0__Isb = new(this, "OnTribeNotice", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeNotice_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeNotice_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeBanWin(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeBanWin_Object___0__Isb;
		public virtual RMethod ROnTribeBanWin_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeBanWin_Object___0__Isb == null)
				{
					r_ROnTribeBanWin_Object___0__Isb = new(this, "OnTribeBanWin", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeBanWin_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeBanWin_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeLeaderCombat(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeLeaderCombat_Object___0__Isb;
		public virtual RMethod ROnTribeLeaderCombat_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeLeaderCombat_Object___0__Isb == null)
				{
					r_ROnTribeLeaderCombat_Object___0__Isb = new(this, "OnTribeLeaderCombat", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeLeaderCombat_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeLeaderCombat_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeLeaderCombatTime(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeLeaderCombatTime_Object___0__Isb;
		public virtual RMethod ROnTribeLeaderCombatTime_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeLeaderCombatTime_Object___0__Isb == null)
				{
					r_ROnTribeLeaderCombatTime_Object___0__Isb = new(this, "OnTribeLeaderCombatTime", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeLeaderCombatTime_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeLeaderCombatTime_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeOpenKingStamp(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeOpenKingStamp_Object___0__Isb;
		public virtual RMethod ROnTribeOpenKingStamp_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeOpenKingStamp_Object___0__Isb == null)
				{
					r_ROnTribeOpenKingStamp_Object___0__Isb = new(this, "OnTribeOpenKingStamp", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeOpenKingStamp_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeOpenKingStamp_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeLeaderCombatJoin(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeLeaderCombatJoin_Object___0__Isb;
		public virtual RMethod ROnTribeLeaderCombatJoin_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeLeaderCombatJoin_Object___0__Isb == null)
				{
					r_ROnTribeLeaderCombatJoin_Object___0__Isb = new(this, "OnTribeLeaderCombatJoin", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeLeaderCombatJoin_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeLeaderCombatJoin_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void _OnTribeLeaderCombatJoin(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R_OnTribeLeaderCombatJoin_Object___0__n6c;
		public virtual RMethod R_OnTribeLeaderCombatJoin_Object___0__n6c
		{
			get
			{
				if(r_R_OnTribeLeaderCombatJoin_Object___0__n6c == null)
				{
					r_R_OnTribeLeaderCombatJoin_Object___0__n6c = new(this, "_OnTribeLeaderCombatJoin", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R_OnTribeLeaderCombatJoin_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R_OnTribeLeaderCombatJoin_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void ConfirmJoinLeaderCombat(System.Object)
		/// </summary>
		protected RMethod r_RConfirmJoinLeaderCombat_Object;
		public virtual RMethod RConfirmJoinLeaderCombat_Object
		{
			get
			{
				if(r_RConfirmJoinLeaderCombat_Object == null)
				{
					r_RConfirmJoinLeaderCombat_Object = new(this, "ConfirmJoinLeaderCombat", 0, typeof(System.Object));
					r_RConfirmJoinLeaderCombat_Object.SetBelong(this.instance);
				}
				return r_RConfirmJoinLeaderCombat_Object;
			}
		}

		/// <summary>
		/// Void OnTribeWarMembers(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWarMembers_Object___0__Isb;
		public virtual RMethod ROnTribeWarMembers_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWarMembers_Object___0__Isb == null)
				{
					r_ROnTribeWarMembers_Object___0__Isb = new(this, "OnTribeWarMembers", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWarMembers_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWarMembers_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendExchangeContribute(Int32)
		/// </summary>
		protected RMethod r_RSendExchangeContribute_Int32;
		public virtual RMethod RSendExchangeContribute_Int32
		{
			get
			{
				if(r_RSendExchangeContribute_Int32 == null)
				{
					r_RSendExchangeContribute_Int32 = new(this, "SendExchangeContribute", 0, typeof(System.Int32));
					r_RSendExchangeContribute_Int32.SetBelong(this.instance);
				}
				return r_RSendExchangeContribute_Int32;
			}
		}

		/// <summary>
		/// Void SendAppointPost(System.String, Int32)
		/// </summary>
		protected RMethod r_RSendAppointPost_String_Int32;
		public virtual RMethod RSendAppointPost_String_Int32
		{
			get
			{
				if(r_RSendAppointPost_String_Int32 == null)
				{
					r_RSendAppointPost_String_Int32 = new(this, "SendAppointPost", 0, typeof(System.String), typeof(System.Int32));
					r_RSendAppointPost_String_Int32.SetBelong(this.instance);
				}
				return r_RSendAppointPost_String_Int32;
			}
		}

		/// <summary>
		/// Void RequestTribeInfo()
		/// </summary>
		protected RMethod r_RRequestTribeInfo;
		public virtual RMethod RRequestTribeInfo
		{
			get
			{
				if(r_RRequestTribeInfo == null)
				{
					r_RRequestTribeInfo = new(this, "RequestTribeInfo", 0);
					r_RRequestTribeInfo.SetBelong(this.instance);
				}
				return r_RRequestTribeInfo;
			}
		}

		/// <summary>
		/// Void SendPostTribeTask(GameDefineType.ID, Int32, Int32)
		/// </summary>
		protected RMethod r_RSendPostTribeTask_ID_Int32_Int32;
		public virtual RMethod RSendPostTribeTask_ID_Int32_Int32
		{
			get
			{
				if(r_RSendPostTribeTask_ID_Int32_Int32 == null)
				{
					r_RSendPostTribeTask_ID_Int32_Int32 = new(this, "SendPostTribeTask", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Int32));
					r_RSendPostTribeTask_ID_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSendPostTribeTask_ID_Int32_Int32;
			}
		}

		/// <summary>
		/// Void RequestTribeTaskInfo(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RRequestTribeTaskInfo_ID;
		public virtual RMethod RRequestTribeTaskInfo_ID
		{
			get
			{
				if(r_RRequestTribeTaskInfo_ID == null)
				{
					r_RRequestTribeTaskInfo_ID = new(this, "RequestTribeTaskInfo", 0, typeof(GameDefineType.ID));
					r_RRequestTribeTaskInfo_ID.SetBelong(this.instance);
				}
				return r_RRequestTribeTaskInfo_ID;
			}
		}

		/// <summary>
		/// Void SendModifyTribeNotice(System.String)
		/// </summary>
		protected RMethod r_RSendModifyTribeNotice_String;
		public virtual RMethod RSendModifyTribeNotice_String
		{
			get
			{
				if(r_RSendModifyTribeNotice_String == null)
				{
					r_RSendModifyTribeNotice_String = new(this, "SendModifyTribeNotice", 0, typeof(System.String));
					r_RSendModifyTribeNotice_String.SetBelong(this.instance);
				}
				return r_RSendModifyTribeNotice_String;
			}
		}

		/// <summary>
		/// Void OnUpdateBossStatus(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnUpdateBossStatus_Object___0__Isb;
		public virtual RMethod ROnUpdateBossStatus_Object___0__Isb
		{
			get
			{
				if(r_ROnUpdateBossStatus_Object___0__Isb == null)
				{
					r_ROnUpdateBossStatus_Object___0__Isb = new(this, "OnUpdateBossStatus", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnUpdateBossStatus_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnUpdateBossStatus_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribePearlOpen(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribePearlOpen_Object___0__Isb;
		public virtual RMethod ROnTribePearlOpen_Object___0__Isb
		{
			get
			{
				if(r_ROnTribePearlOpen_Object___0__Isb == null)
				{
					r_ROnTribePearlOpen_Object___0__Isb = new(this, "OnTribePearlOpen", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribePearlOpen_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribePearlOpen_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribePearlClear(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribePearlClear_Object___0__Isb;
		public virtual RMethod ROnTribePearlClear_Object___0__Isb
		{
			get
			{
				if(r_ROnTribePearlClear_Object___0__Isb == null)
				{
					r_ROnTribePearlClear_Object___0__Isb = new(this, "OnTribePearlClear", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribePearlClear_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribePearlClear_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeWarStart(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWarStart_Object___0__Isb;
		public virtual RMethod ROnTribeWarStart_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWarStart_Object___0__Isb == null)
				{
					r_ROnTribeWarStart_Object___0__Isb = new(this, "OnTribeWarStart", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWarStart_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWarStart_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeWarChallengeLitter(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWarChallengeLitter_Object___0__Isb;
		public virtual RMethod ROnTribeWarChallengeLitter_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWarChallengeLitter_Object___0__Isb == null)
				{
					r_ROnTribeWarChallengeLitter_Object___0__Isb = new(this, "OnTribeWarChallengeLitter", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWarChallengeLitter_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWarChallengeLitter_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeWarLogUpdate(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWarLogUpdate_Object___0__Isb;
		public virtual RMethod ROnTribeWarLogUpdate_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWarLogUpdate_Object___0__Isb == null)
				{
					r_ROnTribeWarLogUpdate_Object___0__Isb = new(this, "OnTribeWarLogUpdate", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWarLogUpdate_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWarLogUpdate_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeWarLogOpen(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWarLogOpen_Object___0__Isb;
		public virtual RMethod ROnTribeWarLogOpen_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWarLogOpen_Object___0__Isb == null)
				{
					r_ROnTribeWarLogOpen_Object___0__Isb = new(this, "OnTribeWarLogOpen", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWarLogOpen_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWarLogOpen_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendTribeWarLogOpenMsg(Int32)
		/// </summary>
		protected RMethod r_RSendTribeWarLogOpenMsg_Int32;
		public virtual RMethod RSendTribeWarLogOpenMsg_Int32
		{
			get
			{
				if(r_RSendTribeWarLogOpenMsg_Int32 == null)
				{
					r_RSendTribeWarLogOpenMsg_Int32 = new(this, "SendTribeWarLogOpenMsg", 0, typeof(System.Int32));
					r_RSendTribeWarLogOpenMsg_Int32.SetBelong(this.instance);
				}
				return r_RSendTribeWarLogOpenMsg_Int32;
			}
		}

		/// <summary>
		/// Void OnTribeConvene(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeConvene_Object___0__Isb;
		public virtual RMethod ROnTribeConvene_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeConvene_Object___0__Isb == null)
				{
					r_ROnTribeConvene_Object___0__Isb = new(this, "OnTribeConvene", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeConvene_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeConvene_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void _OnTribeConvene(System.Object, #Pfb.#n6c)
		/// </summary>
		protected RMethod r_R_OnTribeConvene_Object___0__n6c;
		public virtual RMethod R_OnTribeConvene_Object___0__n6c
		{
			get
			{
				if(r_R_OnTribeConvene_Object___0__n6c == null)
				{
					r_R_OnTribeConvene_Object___0__n6c = new(this, "_OnTribeConvene", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#n6c"));
					r_R_OnTribeConvene_Object___0__n6c.SetBelong(this.instance);
				}
				return r_R_OnTribeConvene_Object___0__n6c;
			}
		}

		/// <summary>
		/// Void OnTribeWarOver(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWarOver_Object___0__Isb;
		public virtual RMethod ROnTribeWarOver_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWarOver_Object___0__Isb == null)
				{
					r_ROnTribeWarOver_Object___0__Isb = new(this, "OnTribeWarOver", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWarOver_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWarOver_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeWarJoin(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWarJoin_Object___0__Isb;
		public virtual RMethod ROnTribeWarJoin_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWarJoin_Object___0__Isb == null)
				{
					r_ROnTribeWarJoin_Object___0__Isb = new(this, "OnTribeWarJoin", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWarJoin_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWarJoin_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeElderHpLow(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeElderHpLow_Object___0__Isb;
		public virtual RMethod ROnTribeElderHpLow_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeElderHpLow_Object___0__Isb == null)
				{
					r_ROnTribeElderHpLow_Object___0__Isb = new(this, "OnTribeElderHpLow", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeElderHpLow_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeElderHpLow_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnTribeOpenJoinWin(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeOpenJoinWin_Object___0__Isb;
		public virtual RMethod ROnTribeOpenJoinWin_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeOpenJoinWin_Object___0__Isb == null)
				{
					r_ROnTribeOpenJoinWin_Object___0__Isb = new(this, "OnTribeOpenJoinWin", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeOpenJoinWin_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeOpenJoinWin_Object___0__Isb;
			}
		}

		/// <summary>
		/// Int32 GetChangeCost(Int32)
		/// </summary>
		protected RMethod r_RGetChangeCost_Int32;
		public virtual RMethod RGetChangeCost_Int32
		{
			get
			{
				if(r_RGetChangeCost_Int32 == null)
				{
					r_RGetChangeCost_Int32 = new(this, "GetChangeCost", 0, typeof(System.Int32));
					r_RGetChangeCost_Int32.SetBelong(this.instance);
				}
				return r_RGetChangeCost_Int32;
			}
		}

		/// <summary>
		/// Void OnTribeChangeCost(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeChangeCost_Object___0__Isb;
		public virtual RMethod ROnTribeChangeCost_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeChangeCost_Object___0__Isb == null)
				{
					r_ROnTribeChangeCost_Object___0__Isb = new(this, "OnTribeChangeCost", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeChangeCost_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeChangeCost_Object___0__Isb;
			}
		}

		/// <summary>
		/// Int32 GetWeakestTribeIdx()
		/// </summary>
		protected RMethod r_RGetWeakestTribeIdx;
		public virtual RMethod RGetWeakestTribeIdx
		{
			get
			{
				if(r_RGetWeakestTribeIdx == null)
				{
					r_RGetWeakestTribeIdx = new(this, "GetWeakestTribeIdx", 0);
					r_RGetWeakestTribeIdx.SetBelong(this.instance);
				}
				return r_RGetWeakestTribeIdx;
			}
		}

		/// <summary>
		/// Boolean IsInWeakestTribe()
		/// </summary>
		protected RMethod r_RIsInWeakestTribe;
		public virtual RMethod RIsInWeakestTribe
		{
			get
			{
				if(r_RIsInWeakestTribe == null)
				{
					r_RIsInWeakestTribe = new(this, "IsInWeakestTribe", 0);
					r_RIsInWeakestTribe.SetBelong(this.instance);
				}
				return r_RIsInWeakestTribe;
			}
		}

		/// <summary>
		/// Void OnTribeWeakest(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTribeWeakest_Object___0__Isb;
		public virtual RMethod ROnTribeWeakest_Object___0__Isb
		{
			get
			{
				if(r_ROnTribeWeakest_Object___0__Isb == null)
				{
					r_ROnTribeWeakest_Object___0__Isb = new(this, "OnTribeWeakest", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTribeWeakest_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTribeWeakest_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendTribeWarJoinComfirmMsg(Int32)
		/// </summary>
		protected RMethod r_RSendTribeWarJoinComfirmMsg_Int32;
		public virtual RMethod RSendTribeWarJoinComfirmMsg_Int32
		{
			get
			{
				if(r_RSendTribeWarJoinComfirmMsg_Int32 == null)
				{
					r_RSendTribeWarJoinComfirmMsg_Int32 = new(this, "SendTribeWarJoinComfirmMsg", 0, typeof(System.Int32));
					r_RSendTribeWarJoinComfirmMsg_Int32.SetBelong(this.instance);
				}
				return r_RSendTribeWarJoinComfirmMsg_Int32;
			}
		}

		/// <summary>
		/// Void SendDefendTribeElderComfirmMsg()
		/// </summary>
		protected RMethod r_RSendDefendTribeElderComfirmMsg;
		public virtual RMethod RSendDefendTribeElderComfirmMsg
		{
			get
			{
				if(r_RSendDefendTribeElderComfirmMsg == null)
				{
					r_RSendDefendTribeElderComfirmMsg = new(this, "SendDefendTribeElderComfirmMsg", 0);
					r_RSendDefendTribeElderComfirmMsg.SetBelong(this.instance);
				}
				return r_RSendDefendTribeElderComfirmMsg;
			}
		}

		/// <summary>
		/// Void SendDefendTribeComfirmMsg(Int32)
		/// </summary>
		protected RMethod r_RSendDefendTribeComfirmMsg_Int32;
		public virtual RMethod RSendDefendTribeComfirmMsg_Int32
		{
			get
			{
				if(r_RSendDefendTribeComfirmMsg_Int32 == null)
				{
					r_RSendDefendTribeComfirmMsg_Int32 = new(this, "SendDefendTribeComfirmMsg", 0, typeof(System.Int32));
					r_RSendDefendTribeComfirmMsg_Int32.SetBelong(this.instance);
				}
				return r_RSendDefendTribeComfirmMsg_Int32;
			}
		}

		/// <summary>
		/// Void SendRecallPost(Int32)
		/// </summary>
		protected RMethod r_RSendRecallPost_Int32;
		public virtual RMethod RSendRecallPost_Int32
		{
			get
			{
				if(r_RSendRecallPost_Int32 == null)
				{
					r_RSendRecallPost_Int32 = new(this, "SendRecallPost", 0, typeof(System.Int32));
					r_RSendRecallPost_Int32.SetBelong(this.instance);
				}
				return r_RSendRecallPost_Int32;
			}
		}

		/// <summary>
		/// Void SendResignPost(Int32)
		/// </summary>
		protected RMethod r_RSendResignPost_Int32;
		public virtual RMethod RSendResignPost_Int32
		{
			get
			{
				if(r_RSendResignPost_Int32 == null)
				{
					r_RSendResignPost_Int32 = new(this, "SendResignPost", 0, typeof(System.Int32));
					r_RSendResignPost_Int32.SetBelong(this.instance);
				}
				return r_RSendResignPost_Int32;
			}
		}

		/// <summary>
		/// Void SendTribeBan(System.String)
		/// </summary>
		protected RMethod r_RSendTribeBan_String;
		public virtual RMethod RSendTribeBan_String
		{
			get
			{
				if(r_RSendTribeBan_String == null)
				{
					r_RSendTribeBan_String = new(this, "SendTribeBan", 0, typeof(System.String));
					r_RSendTribeBan_String.SetBelong(this.instance);
				}
				return r_RSendTribeBan_String;
			}
		}

		/// <summary>
		/// Void SendLeaveLeaderCombat()
		/// </summary>
		protected RMethod r_RSendLeaveLeaderCombat;
		public virtual RMethod RSendLeaveLeaderCombat
		{
			get
			{
				if(r_RSendLeaveLeaderCombat == null)
				{
					r_RSendLeaveLeaderCombat = new(this, "SendLeaveLeaderCombat", 0);
					r_RSendLeaveLeaderCombat.SetBelong(this.instance);
				}
				return r_RSendLeaveLeaderCombat;
			}
		}

		/// <summary>
		/// Void SendChangeTribe(Int32)
		/// </summary>
		protected RMethod r_RSendChangeTribe_Int32;
		public virtual RMethod RSendChangeTribe_Int32
		{
			get
			{
				if(r_RSendChangeTribe_Int32 == null)
				{
					r_RSendChangeTribe_Int32 = new(this, "SendChangeTribe", 0, typeof(System.Int32));
					r_RSendChangeTribe_Int32.SetBelong(this.instance);
				}
				return r_RSendChangeTribe_Int32;
			}
		}

		/// <summary>
		/// Void SendJoinTribe(Int32)
		/// </summary>
		protected RMethod r_RSendJoinTribe_Int32;
		public virtual RMethod RSendJoinTribe_Int32
		{
			get
			{
				if(r_RSendJoinTribe_Int32 == null)
				{
					r_RSendJoinTribe_Int32 = new(this, "SendJoinTribe", 0, typeof(System.Int32));
					r_RSendJoinTribe_Int32.SetBelong(this.instance);
				}
				return r_RSendJoinTribe_Int32;
			}
		}

		/// <summary>
		/// Void SendViewTribeMovie(Int32)
		/// </summary>
		protected RMethod r_RSendViewTribeMovie_Int32;
		public virtual RMethod RSendViewTribeMovie_Int32
		{
			get
			{
				if(r_RSendViewTribeMovie_Int32 == null)
				{
					r_RSendViewTribeMovie_Int32 = new(this, "SendViewTribeMovie", 0, typeof(System.Int32));
					r_RSendViewTribeMovie_Int32.SetBelong(this.instance);
				}
				return r_RSendViewTribeMovie_Int32;
			}
		}

		/// <summary>
		/// Void SendRecordPos(Int32, System.String, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendRecordPos_Int32_String_ID;
		public virtual RMethod RSendRecordPos_Int32_String_ID
		{
			get
			{
				if(r_RSendRecordPos_Int32_String_ID == null)
				{
					r_RSendRecordPos_Int32_String_ID = new(this, "SendRecordPos", 0, typeof(System.Int32), typeof(System.String), typeof(GameDefineType.ID));
					r_RSendRecordPos_Int32_String_ID.SetBelong(this.instance);
				}
				return r_RSendRecordPos_Int32_String_ID;
			}
		}

		/// <summary>
		/// Void SendTransmitPos(Int32, Int32, UnityEngine.Vector3, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendTransmitPos_Int32_Int32_Vector3_ID;
		public virtual RMethod RSendTransmitPos_Int32_Int32_Vector3_ID
		{
			get
			{
				if(r_RSendTransmitPos_Int32_Int32_Vector3_ID == null)
				{
					r_RSendTransmitPos_Int32_Int32_Vector3_ID = new(this, "SendTransmitPos", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Vector3), typeof(GameDefineType.ID));
					r_RSendTransmitPos_Int32_Int32_Vector3_ID.SetBelong(this.instance);
				}
				return r_RSendTransmitPos_Int32_Int32_Vector3_ID;
			}
		}

		/// <summary>
		/// Void SendChangePosName(Int32, System.String, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendChangePosName_Int32_String_ID;
		public virtual RMethod RSendChangePosName_Int32_String_ID
		{
			get
			{
				if(r_RSendChangePosName_Int32_String_ID == null)
				{
					r_RSendChangePosName_Int32_String_ID = new(this, "SendChangePosName", 0, typeof(System.Int32), typeof(System.String), typeof(GameDefineType.ID));
					r_RSendChangePosName_Int32_String_ID.SetBelong(this.instance);
				}
				return r_RSendChangePosName_Int32_String_ID;
			}
		}

		/// <summary>
		/// Void SendGetSalary()
		/// </summary>
		protected RMethod r_RSendGetSalary;
		public virtual RMethod RSendGetSalary
		{
			get
			{
				if(r_RSendGetSalary == null)
				{
					r_RSendGetSalary = new(this, "SendGetSalary", 0);
					r_RSendGetSalary.SetBelong(this.instance);
				}
				return r_RSendGetSalary;
			}
		}

		/// <summary>
		/// Void SendQueryTribeWarMap()
		/// </summary>
		protected RMethod r_RSendQueryTribeWarMap;
		public virtual RMethod RSendQueryTribeWarMap
		{
			get
			{
				if(r_RSendQueryTribeWarMap == null)
				{
					r_RSendQueryTribeWarMap = new(this, "SendQueryTribeWarMap", 0);
					r_RSendQueryTribeWarMap.SetBelong(this.instance);
				}
				return r_RSendQueryTribeWarMap;
			}
		}

		/// <summary>
		/// Void SendClearTribeTaskTime(Int32)
		/// </summary>
		protected RMethod r_RSendClearTribeTaskTime_Int32;
		public virtual RMethod RSendClearTribeTaskTime_Int32
		{
			get
			{
				if(r_RSendClearTribeTaskTime_Int32 == null)
				{
					r_RSendClearTribeTaskTime_Int32 = new(this, "SendClearTribeTaskTime", 0, typeof(System.Int32));
					r_RSendClearTribeTaskTime_Int32.SetBelong(this.instance);
				}
				return r_RSendClearTribeTaskTime_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadTribeMoraleConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadTribeMoraleConfig_Object;
		public virtual RMethod ROnLoadTribeMoraleConfig_Object
		{
			get
			{
				if(r_ROnLoadTribeMoraleConfig_Object == null)
				{
					r_ROnLoadTribeMoraleConfig_Object = new(this, "OnLoadTribeMoraleConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadTribeMoraleConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTribeMoraleConfig_Object;
			}
		}

		/// <summary>
		/// Int32 GetMoraleLevel(Int32)
		/// </summary>
		protected RMethod r_RGetMoraleLevel_Int32;
		public virtual RMethod RGetMoraleLevel_Int32
		{
			get
			{
				if(r_RGetMoraleLevel_Int32 == null)
				{
					r_RGetMoraleLevel_Int32 = new(this, "GetMoraleLevel", 0, typeof(System.Int32));
					r_RGetMoraleLevel_Int32.SetBelong(this.instance);
				}
				return r_RGetMoraleLevel_Int32;
			}
		}

		/// <summary>
		/// System.String GetMoraleIconUrl(Int32)
		/// </summary>
		protected RMethod r_RGetMoraleIconUrl_Int32;
		public virtual RMethod RGetMoraleIconUrl_Int32
		{
			get
			{
				if(r_RGetMoraleIconUrl_Int32 == null)
				{
					r_RGetMoraleIconUrl_Int32 = new(this, "GetMoraleIconUrl", 0, typeof(System.Int32));
					r_RGetMoraleIconUrl_Int32.SetBelong(this.instance);
				}
				return r_RGetMoraleIconUrl_Int32;
			}
		}

		/// <summary>
		/// System.String GetMoraleTipsInfo(Int32)
		/// </summary>
		protected RMethod r_RGetMoraleTipsInfo_Int32;
		public virtual RMethod RGetMoraleTipsInfo_Int32
		{
			get
			{
				if(r_RGetMoraleTipsInfo_Int32 == null)
				{
					r_RGetMoraleTipsInfo_Int32 = new(this, "GetMoraleTipsInfo", 0, typeof(System.Int32));
					r_RGetMoraleTipsInfo_Int32.SetBelong(this.instance);
				}
				return r_RGetMoraleTipsInfo_Int32;
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


        public RTribeManager() : base("TribeManager")
        {
        }

        public RTribeManager(System.Object instance) : base("TribeManager")
		{
            SetInstance(instance);
		}

        public RTribeManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTribeManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadTribeExpConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadTribeExpConfig_Object.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Object GetTribeInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTribeInfo.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetTribeName(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RGetTribeName_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



















        public virtual void ConfirmJoinLeaderCombat(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = RConfirmJoinLeaderCombat_Object.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SendExchangeContribute(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSendExchangeContribute_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendAppointPost(System.String  @name, System.Int32  @post)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @post};
            var ___result = RSendAppointPost_String_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestTribeInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRequestTribeInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendPostTribeTask(GameDefineType.ID  @task, System.Int32  @hour, System.Int32  @minute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @hour, @minute};
            var ___result = RSendPostTribeTask_ID_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestTribeTaskInfo(GameDefineType.ID  @taskID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@taskID};
            var ___result = RRequestTribeTaskInfo_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendModifyTribeNotice(System.String  @notice)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@notice};
            var ___result = RSendModifyTribeNotice_String.Invoke(___genericsType, ___parameters);

            
        }









        public virtual void SendTribeWarLogOpenMsg(System.Int32  @bfirst)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bfirst};
            var ___result = RSendTribeWarLogOpenMsg_Int32.Invoke(___genericsType, ___parameters);

            
        }








        public virtual System.Int32 GetChangeCost(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RGetChangeCost_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 GetWeakestTribeIdx()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWeakestTribeIdx.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean IsInWeakestTribe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInWeakestTribe.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void SendTribeWarJoinComfirmMsg(System.Int32  @tribe)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tribe};
            var ___result = RSendTribeWarJoinComfirmMsg_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendDefendTribeElderComfirmMsg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendDefendTribeElderComfirmMsg.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendDefendTribeComfirmMsg(System.Int32  @idDefendTribe)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idDefendTribe};
            var ___result = RSendDefendTribeComfirmMsg_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendRecallPost(System.Int32  @post)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@post};
            var ___result = RSendRecallPost_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendResignPost(System.Int32  @post)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@post};
            var ___result = RSendResignPost_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendTribeBan(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RSendTribeBan_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendLeaveLeaderCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendLeaveLeaderCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendChangeTribe(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RSendChangeTribe_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendJoinTribe(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RSendJoinTribe_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendViewTribeMovie(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RSendViewTribeMovie_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendRecordPos(System.Int32  @idx, System.String  @name, GameDefineType.ID  @idItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @name, @idItem};
            var ___result = RSendRecordPos_Int32_String_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendTransmitPos(System.Int32  @type, System.Int32  @index, UnityEngine.Vector3  @pos, GameDefineType.ID  @idItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @index, @pos, @idItem};
            var ___result = RSendTransmitPos_Int32_Int32_Vector3_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendChangePosName(System.Int32  @idx, System.String  @name, GameDefineType.ID  @idItem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx, @name, @idItem};
            var ___result = RSendChangePosName_Int32_String_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendGetSalary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendGetSalary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendQueryTribeWarMap()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendQueryTribeWarMap.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendClearTribeTaskTime(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RSendClearTribeTaskTime_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadTribeMoraleConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadTribeMoraleConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetMoraleLevel(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RGetMoraleLevel_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetMoraleIconUrl(System.Int32  @lv)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lv};
            var ___result = RGetMoraleIconUrl_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetMoraleTipsInfo(System.Int32  @lv)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lv};
            var ___result = RGetMoraleTipsInfo_Int32.Invoke(___genericsType, ___parameters);

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
