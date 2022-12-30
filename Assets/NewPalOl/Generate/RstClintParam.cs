using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// stClintParam
	/// </summary>
    public partial class RstClintParam : RMember //
    {

		/// <summary>
		/// System.Int32 lingzhucount
		/// </summary>
		protected RField r_lingzhucount;
		public virtual RField Rlingzhucount
		{
			get
			{
				if(r_lingzhucount == null)
				{
					r_lingzhucount = new(this, "lingzhucount");
					r_lingzhucount.SetBelong(this.instance);
				}
				return r_lingzhucount;
			}
		}

		/// <summary>
		/// GameDefineType.ID flower0
		/// </summary>
		protected RGameDefineType.RID r_flower0;
		public virtual RGameDefineType.RID Rflower0
		{
			get
			{
				if(r_flower0 == null)
				{
					r_flower0 = new(this, "flower0");
					r_flower0.SetBelong(this.instance);
				}
				return r_flower0;
			}
		}

		/// <summary>
		/// GameDefineType.ID flower1
		/// </summary>
		protected RGameDefineType.RID r_flower1;
		public virtual RGameDefineType.RID Rflower1
		{
			get
			{
				if(r_flower1 == null)
				{
					r_flower1 = new(this, "flower1");
					r_flower1.SetBelong(this.instance);
				}
				return r_flower1;
			}
		}

		/// <summary>
		/// System.Int32 questionnum
		/// </summary>
		protected RField r_questionnum;
		public virtual RField Rquestionnum
		{
			get
			{
				if(r_questionnum == null)
				{
					r_questionnum = new(this, "questionnum");
					r_questionnum.SetBelong(this.instance);
				}
				return r_questionnum;
			}
		}

		/// <summary>
		/// System.String flower1type
		/// </summary>
		protected RField r_flower1type;
		public virtual RField Rflower1type
		{
			get
			{
				if(r_flower1type == null)
				{
					r_flower1type = new(this, "flower1type");
					r_flower1type.SetBelong(this.instance);
				}
				return r_flower1type;
			}
		}

		/// <summary>
		/// System.String flower2type
		/// </summary>
		protected RField r_flower2type;
		public virtual RField Rflower2type
		{
			get
			{
				if(r_flower2type == null)
				{
					r_flower2type = new(this, "flower2type");
					r_flower2type.SetBelong(this.instance);
				}
				return r_flower2type;
			}
		}

		/// <summary>
		/// System.String flower1time
		/// </summary>
		protected RField r_flower1time;
		public virtual RField Rflower1time
		{
			get
			{
				if(r_flower1time == null)
				{
					r_flower1time = new(this, "flower1time");
					r_flower1time.SetBelong(this.instance);
				}
				return r_flower1time;
			}
		}

		/// <summary>
		/// System.String flower2time
		/// </summary>
		protected RField r_flower2time;
		public virtual RField Rflower2time
		{
			get
			{
				if(r_flower2time == null)
				{
					r_flower2time = new(this, "flower2time");
					r_flower2time.SetBelong(this.instance);
				}
				return r_flower2time;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] doublecards
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_doublecards;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rdoublecards
		{
			get
			{
				if(r_doublecards == null)
				{
					r_doublecards = new(this, "doublecards");
					r_doublecards.SetBelong(this.instance);
				}
				return r_doublecards;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] fullstatecards
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_fullstatecards;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rfullstatecards
		{
			get
			{
				if(r_fullstatecards == null)
				{
					r_fullstatecards = new(this, "fullstatecards");
					r_fullstatecards.SetBelong(this.instance);
				}
				return r_fullstatecards;
			}
		}

		/// <summary>
		/// System.Int32 lgcardcount
		/// </summary>
		protected RField r_lgcardcount;
		public virtual RField Rlgcardcount
		{
			get
			{
				if(r_lgcardcount == null)
				{
					r_lgcardcount = new(this, "lgcardcount");
					r_lgcardcount.SetBelong(this.instance);
				}
				return r_lgcardcount;
			}
		}

		/// <summary>
		/// System.Int32[] Pwndopenlv
		/// </summary>
		protected RFieldArray<RField> r_Pwndopenlv;
		public virtual RFieldArray<RField> RPwndopenlv
		{
			get
			{
				if(r_Pwndopenlv == null)
				{
					r_Pwndopenlv = new(this, "Pwndopenlv");
					r_Pwndopenlv.SetBelong(this.instance);
				}
				return r_Pwndopenlv;
			}
		}

		/// <summary>
		/// System.Single aotostartime
		/// </summary>
		protected RField r_aotostartime;
		public virtual RField Raotostartime
		{
			get
			{
				if(r_aotostartime == null)
				{
					r_aotostartime = new(this, "aotostartime");
					r_aotostartime.SetBelong(this.instance);
				}
				return r_aotostartime;
			}
		}

		/// <summary>
		/// System.String aotocard
		/// </summary>
		protected RField r_aotocard;
		public virtual RField Raotocard
		{
			get
			{
				if(r_aotocard == null)
				{
					r_aotocard = new(this, "aotocard");
					r_aotocard.SetBelong(this.instance);
				}
				return r_aotocard;
			}
		}

		/// <summary>
		/// System.Int32 ReelTimerMax
		/// </summary>
		protected RField r_ReelTimerMax;
		public virtual RField ReelTimerMax
		{
			get
			{
				if(r_ReelTimerMax == null)
				{
					r_ReelTimerMax = new(this, "ReelTimerMax");
					r_ReelTimerMax.SetBelong(this.instance);
				}
				return r_ReelTimerMax;
			}
		}

		/// <summary>
		/// System.Int32 ReelQuestionVIPCost
		/// </summary>
		protected RField r_ReelQuestionVIPCost;
		public virtual RField ReelQuestionVIPCost
		{
			get
			{
				if(r_ReelQuestionVIPCost == null)
				{
					r_ReelQuestionVIPCost = new(this, "ReelQuestionVIPCost");
					r_ReelQuestionVIPCost.SetBelong(this.instance);
				}
				return r_ReelQuestionVIPCost;
			}
		}

		/// <summary>
		/// System.Int32 ReelTreasureVIPCost
		/// </summary>
		protected RField r_ReelTreasureVIPCost;
		public virtual RField ReelTreasureVIPCost
		{
			get
			{
				if(r_ReelTreasureVIPCost == null)
				{
					r_ReelTreasureVIPCost = new(this, "ReelTreasureVIPCost");
					r_ReelTreasureVIPCost.SetBelong(this.instance);
				}
				return r_ReelTreasureVIPCost;
			}
		}

		/// <summary>
		/// System.Int32 ReelTaskVIPCost
		/// </summary>
		protected RField r_ReelTaskVIPCost;
		public virtual RField ReelTaskVIPCost
		{
			get
			{
				if(r_ReelTaskVIPCost == null)
				{
					r_ReelTaskVIPCost = new(this, "ReelTaskVIPCost");
					r_ReelTaskVIPCost.SetBelong(this.instance);
				}
				return r_ReelTaskVIPCost;
			}
		}

		/// <summary>
		/// System.Int32 ConveyEscortTimes
		/// </summary>
		protected RField r_ConveyEscortTimes;
		public virtual RField RConveyEscortTimes
		{
			get
			{
				if(r_ConveyEscortTimes == null)
				{
					r_ConveyEscortTimes = new(this, "ConveyEscortTimes");
					r_ConveyEscortTimes.SetBelong(this.instance);
				}
				return r_ConveyEscortTimes;
			}
		}

		/// <summary>
		/// System.Int32 RobEscortTimes
		/// </summary>
		protected RField r_RobEscortTimes;
		public virtual RField RobEscortTimes
		{
			get
			{
				if(r_RobEscortTimes == null)
				{
					r_RobEscortTimes = new(this, "RobEscortTimes");
					r_RobEscortTimes.SetBelong(this.instance);
				}
				return r_RobEscortTimes;
			}
		}

		/// <summary>
		/// System.Int32 MaxResFightPoint
		/// </summary>
		protected RField r_MaxResFightPoint;
		public virtual RField RMaxResFightPoint
		{
			get
			{
				if(r_MaxResFightPoint == null)
				{
					r_MaxResFightPoint = new(this, "MaxResFightPoint");
					r_MaxResFightPoint.SetBelong(this.instance);
				}
				return r_MaxResFightPoint;
			}
		}

		/// <summary>
		/// System.Single HpApptide
		/// </summary>
		protected RField r_HpApptide;
		public virtual RField RHpApptide
		{
			get
			{
				if(r_HpApptide == null)
				{
					r_HpApptide = new(this, "HpApptide");
					r_HpApptide.SetBelong(this.instance);
				}
				return r_HpApptide;
			}
		}

		/// <summary>
		/// System.Single AtkApptide
		/// </summary>
		protected RField r_AtkApptide;
		public virtual RField RAtkApptide
		{
			get
			{
				if(r_AtkApptide == null)
				{
					r_AtkApptide = new(this, "AtkApptide");
					r_AtkApptide.SetBelong(this.instance);
				}
				return r_AtkApptide;
			}
		}

		/// <summary>
		/// System.Single ArmorApptide
		/// </summary>
		protected RField r_ArmorApptide;
		public virtual RField RArmorApptide
		{
			get
			{
				if(r_ArmorApptide == null)
				{
					r_ArmorApptide = new(this, "ArmorApptide");
					r_ArmorApptide.SetBelong(this.instance);
				}
				return r_ArmorApptide;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] flowerexp1
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_flowerexp1;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rflowerexp1
		{
			get
			{
				if(r_flowerexp1 == null)
				{
					r_flowerexp1 = new(this, "flowerexp1");
					r_flowerexp1.SetBelong(this.instance);
				}
				return r_flowerexp1;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] flowerexp2
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_flowerexp2;
		public virtual RSystem.RCollections.RGeneric.RList<RField> Rflowerexp2
		{
			get
			{
				if(r_flowerexp2 == null)
				{
					r_flowerexp2 = new(this, "flowerexp2");
					r_flowerexp2.SetBelong(this.instance);
				}
				return r_flowerexp2;
			}
		}

		/// <summary>
		/// System.Int32 Extracardpoint
		/// </summary>
		protected RField r_Extracardpoint;
		public virtual RField RExtracardpoint
		{
			get
			{
				if(r_Extracardpoint == null)
				{
					r_Extracardpoint = new(this, "Extracardpoint");
					r_Extracardpoint.SetBelong(this.instance);
				}
				return r_Extracardpoint;
			}
		}

		/// <summary>
		/// System.String ChargeUrl
		/// </summary>
		protected RField r_ChargeUrl;
		public virtual RField RChargeUrl
		{
			get
			{
				if(r_ChargeUrl == null)
				{
					r_ChargeUrl = new(this, "ChargeUrl");
					r_ChargeUrl.SetBelong(this.instance);
				}
				return r_ChargeUrl;
			}
		}

		/// <summary>
		/// System.String SurveyUrl
		/// </summary>
		protected RField r_SurveyUrl;
		public virtual RField RSurveyUrl
		{
			get
			{
				if(r_SurveyUrl == null)
				{
					r_SurveyUrl = new(this, "SurveyUrl");
					r_SurveyUrl.SetBelong(this.instance);
				}
				return r_SurveyUrl;
			}
		}

		/// <summary>
		/// System.String Gift360Url
		/// </summary>
		protected RField r_Gift360Url;
		public virtual RField RGift360Url
		{
			get
			{
				if(r_Gift360Url == null)
				{
					r_Gift360Url = new(this, "Gift360Url");
					r_Gift360Url.SetBelong(this.instance);
				}
				return r_Gift360Url;
			}
		}

		/// <summary>
		/// System.String loginFailUrl
		/// </summary>
		protected RField r_loginFailUrl;
		public virtual RField RloginFailUrl
		{
			get
			{
				if(r_loginFailUrl == null)
				{
					r_loginFailUrl = new(this, "loginFailUrl");
					r_loginFailUrl.SetBelong(this.instance);
				}
				return r_loginFailUrl;
			}
		}

		/// <summary>
		/// System.String GoldLockUrl
		/// </summary>
		protected RField r_GoldLockUrl;
		public virtual RField RGoldLockUrl
		{
			get
			{
				if(r_GoldLockUrl == null)
				{
					r_GoldLockUrl = new(this, "GoldLockUrl");
					r_GoldLockUrl.SetBelong(this.instance);
				}
				return r_GoldLockUrl;
			}
		}

		/// <summary>
		/// System.String DiamondServiceUrl
		/// </summary>
		protected RField r_DiamondServiceUrl;
		public virtual RField RDiamondServiceUrl
		{
			get
			{
				if(r_DiamondServiceUrl == null)
				{
					r_DiamondServiceUrl = new(this, "DiamondServiceUrl");
					r_DiamondServiceUrl.SetBelong(this.instance);
				}
				return r_DiamondServiceUrl;
			}
		}

		/// <summary>
		/// System.String DiamondDetailUrl
		/// </summary>
		protected RField r_DiamondDetailUrl;
		public virtual RField RDiamondDetailUrl
		{
			get
			{
				if(r_DiamondDetailUrl == null)
				{
					r_DiamondDetailUrl = new(this, "DiamondDetailUrl");
					r_DiamondDetailUrl.SetBelong(this.instance);
				}
				return r_DiamondDetailUrl;
			}
		}

		/// <summary>
		/// System.String EnterQTUrl
		/// </summary>
		protected RField r_EnterQTUrl;
		public virtual RField REnterQTUrl
		{
			get
			{
				if(r_EnterQTUrl == null)
				{
					r_EnterQTUrl = new(this, "EnterQTUrl");
					r_EnterQTUrl.SetBelong(this.instance);
				}
				return r_EnterQTUrl;
			}
		}

		/// <summary>
		/// System.String JoinQTUrl
		/// </summary>
		protected RField r_JoinQTUrl;
		public virtual RField RJoinQTUrl
		{
			get
			{
				if(r_JoinQTUrl == null)
				{
					r_JoinQTUrl = new(this, "JoinQTUrl");
					r_JoinQTUrl.SetBelong(this.instance);
				}
				return r_JoinQTUrl;
			}
		}

		/// <summary>
		/// System.String DownloadQTUrl
		/// </summary>
		protected RField r_DownloadQTUrl;
		public virtual RField RDownloadQTUrl
		{
			get
			{
				if(r_DownloadQTUrl == null)
				{
					r_DownloadQTUrl = new(this, "DownloadQTUrl");
					r_DownloadQTUrl.SetBelong(this.instance);
				}
				return r_DownloadQTUrl;
			}
		}

		/// <summary>
		/// System.String QTGetUrl
		/// </summary>
		protected RField r_QTGetUrl;
		public virtual RField RQTGetUrl
		{
			get
			{
				if(r_QTGetUrl == null)
				{
					r_QTGetUrl = new(this, "QTGetUrl");
					r_QTGetUrl.SetBelong(this.instance);
				}
				return r_QTGetUrl;
			}
		}

		/// <summary>
		/// System.String QTStateUrl
		/// </summary>
		protected RField r_QTStateUrl;
		public virtual RField RQTStateUrl
		{
			get
			{
				if(r_QTStateUrl == null)
				{
					r_QTStateUrl = new(this, "QTStateUrl");
					r_QTStateUrl.SetBelong(this.instance);
				}
				return r_QTStateUrl;
			}
		}

		/// <summary>
		/// System.String GoldFeatherUrl
		/// </summary>
		protected RField r_GoldFeatherUrl;
		public virtual RField RGoldFeatherUrl
		{
			get
			{
				if(r_GoldFeatherUrl == null)
				{
					r_GoldFeatherUrl = new(this, "GoldFeatherUrl");
					r_GoldFeatherUrl.SetBelong(this.instance);
				}
				return r_GoldFeatherUrl;
			}
		}

		/// <summary>
		/// System.String Cell37WanUrl
		/// </summary>
		protected RField r_Cell37WanUrl;
		public virtual RField RCell37WanUrl
		{
			get
			{
				if(r_Cell37WanUrl == null)
				{
					r_Cell37WanUrl = new(this, "Cell37WanUrl");
					r_Cell37WanUrl.SetBelong(this.instance);
				}
				return r_Cell37WanUrl;
			}
		}

		/// <summary>
		/// System.String RedDiamondRebate
		/// </summary>
		protected RField r_RedDiamondRebate;
		public virtual RField RedDiamondRebate
		{
			get
			{
				if(r_RedDiamondRebate == null)
				{
					r_RedDiamondRebate = new(this, "RedDiamondRebate");
					r_RedDiamondRebate.SetBelong(this.instance);
				}
				return r_RedDiamondRebate;
			}
		}

		/// <summary>
		/// System.String RedDiamondGift
		/// </summary>
		protected RField r_RedDiamondGift;
		public virtual RField RedDiamondGift
		{
			get
			{
				if(r_RedDiamondGift == null)
				{
					r_RedDiamondGift = new(this, "RedDiamondGift");
					r_RedDiamondGift.SetBelong(this.instance);
				}
				return r_RedDiamondGift;
			}
		}

		/// <summary>
		/// System.String MircoClient
		/// </summary>
		protected RField r_MircoClient;
		public virtual RField RMircoClient
		{
			get
			{
				if(r_MircoClient == null)
				{
					r_MircoClient = new(this, "MircoClient");
					r_MircoClient.SetBelong(this.instance);
				}
				return r_MircoClient;
			}
		}

		/// <summary>
		/// System.String ThunderVIP
		/// </summary>
		protected RField r_ThunderVIP;
		public virtual RField RThunderVIP
		{
			get
			{
				if(r_ThunderVIP == null)
				{
					r_ThunderVIP = new(this, "ThunderVIP");
					r_ThunderVIP.SetBelong(this.instance);
				}
				return r_ThunderVIP;
			}
		}

		/// <summary>
		/// System.String ThunderClub
		/// </summary>
		protected RField r_ThunderClub;
		public virtual RField RThunderClub
		{
			get
			{
				if(r_ThunderClub == null)
				{
					r_ThunderClub = new(this, "ThunderClub");
					r_ThunderClub.SetBelong(this.instance);
				}
				return r_ThunderClub;
			}
		}

		/// <summary>
		/// System.String ThunderActivity
		/// </summary>
		protected RField r_ThunderActivity;
		public virtual RField RThunderActivity
		{
			get
			{
				if(r_ThunderActivity == null)
				{
					r_ThunderActivity = new(this, "ThunderActivity");
					r_ThunderActivity.SetBelong(this.instance);
				}
				return r_ThunderActivity;
			}
		}

		/// <summary>
		/// System.String ThunderBox
		/// </summary>
		protected RField r_ThunderBox;
		public virtual RField RThunderBox
		{
			get
			{
				if(r_ThunderBox == null)
				{
					r_ThunderBox = new(this, "ThunderBox");
					r_ThunderBox.SetBelong(this.instance);
				}
				return r_ThunderBox;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] searchTreasurePrice
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_searchTreasurePrice;
		public virtual RSystem.RCollections.RGeneric.RList<RField> RsearchTreasurePrice
		{
			get
			{
				if(r_searchTreasurePrice == null)
				{
					r_searchTreasurePrice = new(this, "searchTreasurePrice");
					r_searchTreasurePrice.SetBelong(this.instance);
				}
				return r_searchTreasurePrice;
			}
		}

		/// <summary>
		/// System.String searchTreasureAnimPara
		/// </summary>
		protected RField r_searchTreasureAnimPara;
		public virtual RField RsearchTreasureAnimPara
		{
			get
			{
				if(r_searchTreasureAnimPara == null)
				{
					r_searchTreasureAnimPara = new(this, "searchTreasureAnimPara");
					r_searchTreasureAnimPara.SetBelong(this.instance);
				}
				return r_searchTreasureAnimPara;
			}
		}

		/// <summary>
		/// System.Int32 shootPumpkinItem
		/// </summary>
		protected RField r_shootPumpkinItem;
		public virtual RField RshootPumpkinItem
		{
			get
			{
				if(r_shootPumpkinItem == null)
				{
					r_shootPumpkinItem = new(this, "shootPumpkinItem");
					r_shootPumpkinItem.SetBelong(this.instance);
				}
				return r_shootPumpkinItem;
			}
		}

		/// <summary>
		/// GameDefineType.ID nobattel
		/// </summary>
		protected RGameDefineType.RID r_nobattel;
		public virtual RGameDefineType.RID Rnobattel
		{
			get
			{
				if(r_nobattel == null)
				{
					r_nobattel = new(this, "nobattel");
					r_nobattel.SetBelong(this.instance);
				}
				return r_nobattel;
			}
		}

		/// <summary>
		/// GameDefineType.ID grabitem
		/// </summary>
		protected RGameDefineType.RID r_grabitem;
		public virtual RGameDefineType.RID Rgrabitem
		{
			get
			{
				if(r_grabitem == null)
				{
					r_grabitem = new(this, "grabitem");
					r_grabitem.SetBelong(this.instance);
				}
				return r_grabitem;
			}
		}

		/// <summary>
		/// System.Int32 grablimit
		/// </summary>
		protected RField r_grablimit;
		public virtual RField Rgrablimit
		{
			get
			{
				if(r_grablimit == null)
				{
					r_grablimit = new(this, "grablimit");
					r_grablimit.SetBelong(this.instance);
				}
				return r_grablimit;
			}
		}

		/// <summary>
		/// System.Int32 resetRebornPer1
		/// </summary>
		protected RField r_resetRebornPer1;
		public virtual RField RresetRebornPer1
		{
			get
			{
				if(r_resetRebornPer1 == null)
				{
					r_resetRebornPer1 = new(this, "resetRebornPer1");
					r_resetRebornPer1.SetBelong(this.instance);
				}
				return r_resetRebornPer1;
			}
		}

		/// <summary>
		/// System.Int32 resetRebornPer2
		/// </summary>
		protected RField r_resetRebornPer2;
		public virtual RField RresetRebornPer2
		{
			get
			{
				if(r_resetRebornPer2 == null)
				{
					r_resetRebornPer2 = new(this, "resetRebornPer2");
					r_resetRebornPer2.SetBelong(this.instance);
				}
				return r_resetRebornPer2;
			}
		}

		/// <summary>
		/// System.Int32 resetRebornPer3
		/// </summary>
		protected RField r_resetRebornPer3;
		public virtual RField RresetRebornPer3
		{
			get
			{
				if(r_resetRebornPer3 == null)
				{
					r_resetRebornPer3 = new(this, "resetRebornPer3");
					r_resetRebornPer3.SetBelong(this.instance);
				}
				return r_resetRebornPer3;
			}
		}

		/// <summary>
		/// System.Int32 resetRebornPer4
		/// </summary>
		protected RField r_resetRebornPer4;
		public virtual RField RresetRebornPer4
		{
			get
			{
				if(r_resetRebornPer4 == null)
				{
					r_resetRebornPer4 = new(this, "resetRebornPer4");
					r_resetRebornPer4.SetBelong(this.instance);
				}
				return r_resetRebornPer4;
			}
		}

		/// <summary>
		/// System.Int32 nMaxGoldGambleCount
		/// </summary>
		protected RField r_nMaxGoldGambleCount;
		public virtual RField RnMaxGoldGambleCount
		{
			get
			{
				if(r_nMaxGoldGambleCount == null)
				{
					r_nMaxGoldGambleCount = new(this, "nMaxGoldGambleCount");
					r_nMaxGoldGambleCount.SetBelong(this.instance);
				}
				return r_nMaxGoldGambleCount;
			}
		}

		/// <summary>
		/// System.String mini_client_gift
		/// </summary>
		protected RField r_mini_client_gift;
		public virtual RField Rmini_client_gift
		{
			get
			{
				if(r_mini_client_gift == null)
				{
					r_mini_client_gift = new(this, "mini_client_gift");
					r_mini_client_gift.SetBelong(this.instance);
				}
				return r_mini_client_gift;
			}
		}

		/// <summary>
		/// System.String egg_big_prize
		/// </summary>
		protected RField r_egg_big_prize;
		public virtual RField Regg_big_prize
		{
			get
			{
				if(r_egg_big_prize == null)
				{
					r_egg_big_prize = new(this, "egg_big_prize");
					r_egg_big_prize.SetBelong(this.instance);
				}
				return r_egg_big_prize;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] mUrDic
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_mUrDic;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> RmUrDic
		{
			get
			{
				if(r_mUrDic == null)
				{
					r_mUrDic = new(this, "mUrDic");
					r_mUrDic.SetBelong(this.instance);
				}
				return r_mUrDic;
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


        public RstClintParam() : base("stClintParam")
        {
        }

        public RstClintParam(System.Object instance) : base("stClintParam")
		{
            SetInstance(instance);
		}

        public RstClintParam(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RstClintParam(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
