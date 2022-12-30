using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CombatController
	/// </summary>
    public partial class RCombatController : RMember //
    {

		/// <summary>
		/// System.Single escapinTime
		/// </summary>
		protected static RField r_escapinTime;
		public static RField RescapinTime
		{
			get
			{
				if(r_escapinTime == null)
				{
					r_escapinTime = new( ReleactionUtils.GetType("CombatController"), "escapinTime");
					r_escapinTime.SetBelong(null);
				}
				return r_escapinTime;
			}
		}

		/// <summary>
		/// System.Int32 Hide_Cull_Layer
		/// </summary>
		protected static RField r_Hide_Cull_Layer;
		public static RField RHide_Cull_Layer
		{
			get
			{
				if(r_Hide_Cull_Layer == null)
				{
					r_Hide_Cull_Layer = new( ReleactionUtils.GetType("CombatController"), "Hide_Cull_Layer");
					r_Hide_Cull_Layer.SetBelong(null);
				}
				return r_Hide_Cull_Layer;
			}
		}

		/// <summary>
		/// System.String[] SpecialMonster_NAME
		/// </summary>
		protected RFieldArray<RField> r_SpecialMonster_NAME;
		public virtual RFieldArray<RField> RSpecialMonster_NAME
		{
			get
			{
				if(r_SpecialMonster_NAME == null)
				{
					r_SpecialMonster_NAME = new(this, "SpecialMonster_NAME");
					r_SpecialMonster_NAME.SetBelong(this.instance);
				}
				return r_SpecialMonster_NAME;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] SpecialMonster_COLOR
		/// </summary>
		protected RFieldArray<RUnityEngine.RColor> r_SpecialMonster_COLOR;
		public virtual RFieldArray<RUnityEngine.RColor> RSpecialMonster_COLOR
		{
			get
			{
				if(r_SpecialMonster_COLOR == null)
				{
					r_SpecialMonster_COLOR = new(this, "SpecialMonster_COLOR");
					r_SpecialMonster_COLOR.SetBelong(this.instance);
				}
				return r_SpecialMonster_COLOR;
			}
		}

		/// <summary>
		/// System.String[] MouseterPrefix_NAME
		/// </summary>
		protected RFieldArray<RField> r_MouseterPrefix_NAME;
		public virtual RFieldArray<RField> RMouseterPrefix_NAME
		{
			get
			{
				if(r_MouseterPrefix_NAME == null)
				{
					r_MouseterPrefix_NAME = new(this, "MouseterPrefix_NAME");
					r_MouseterPrefix_NAME.SetBelong(this.instance);
				}
				return r_MouseterPrefix_NAME;
			}
		}

		/// <summary>
		/// CombatStatus mCurrentStatus
		/// </summary>
		protected RField r_mCurrentStatus;
		public virtual RField RmCurrentStatus
		{
			get
			{
				if(r_mCurrentStatus == null)
				{
					r_mCurrentStatus = new(this, "mCurrentStatus");
					r_mCurrentStatus.SetBelong(this.instance);
				}
				return r_mCurrentStatus;
			}
		}

		/// <summary>
		/// CombatAreaInfo _CombatArea
		/// </summary>
		protected RCombatAreaInfo r__CombatArea;
		public virtual RCombatAreaInfo R_CombatArea
		{
			get
			{
				if(r__CombatArea == null)
				{
					r__CombatArea = new(this, "_CombatArea");
					r__CombatArea.SetBelong(this.instance);
				}
				return r__CombatArea;
			}
		}

		/// <summary>
		/// MyGUICombatMenuWnd m_Menu
		/// </summary>
		protected RMyGUICombatMenuWnd r_m_Menu;
		public virtual RMyGUICombatMenuWnd Rm_Menu
		{
			get
			{
				if(r_m_Menu == null)
				{
					r_m_Menu = new(this, "m_Menu");
					r_m_Menu.SetBelong(this.instance);
				}
				return r_m_Menu;
			}
		}

		/// <summary>
		/// CombatEvent m_CombatEvt
		/// </summary>
		protected RCombatEvent r_m_CombatEvt;
		public virtual RCombatEvent Rm_CombatEvt
		{
			get
			{
				if(r_m_CombatEvt == null)
				{
					r_m_CombatEvt = new(this, "m_CombatEvt");
					r_m_CombatEvt.SetBelong(this.instance);
				}
				return r_m_CombatEvt;
			}
		}

		/// <summary>
		/// GameDefineType.ID idBattle
		/// </summary>
		protected RGameDefineType.RID r_idBattle;
		public virtual RGameDefineType.RID RidBattle
		{
			get
			{
				if(r_idBattle == null)
				{
					r_idBattle = new(this, "idBattle");
					r_idBattle.SetBelong(this.instance);
				}
				return r_idBattle;
			}
		}

		/// <summary>
		/// System.Int32 nRound
		/// </summary>
		protected RField r_nRound;
		public virtual RField RnRound
		{
			get
			{
				if(r_nRound == null)
				{
					r_nRound = new(this, "nRound");
					r_nRound.SetBelong(this.instance);
				}
				return r_nRound;
			}
		}

		/// <summary>
		/// Fighter m_Fighter
		/// </summary>
		protected RFighter r_m_Fighter;
		public virtual RFighter Rm_Fighter
		{
			get
			{
				if(r_m_Fighter == null)
				{
					r_m_Fighter = new(this, "m_Fighter");
					r_m_Fighter.SetBelong(this.instance);
				}
				return r_m_Fighter;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_CommandTargetPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_CommandTargetPos;
		public virtual RUnityEngine.RVector3 Rm_CommandTargetPos
		{
			get
			{
				if(r_m_CommandTargetPos == null)
				{
					r_m_CommandTargetPos = new(this, "m_CommandTargetPos");
					r_m_CommandTargetPos.SetBelong(this.instance);
				}
				return r_m_CommandTargetPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_myOriginPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_myOriginPos;
		public virtual RUnityEngine.RVector3 Rm_myOriginPos
		{
			get
			{
				if(r_m_myOriginPos == null)
				{
					r_m_myOriginPos = new(this, "m_myOriginPos");
					r_m_myOriginPos.SetBelong(this.instance);
				}
				return r_m_myOriginPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_myOriginPosInScene
		/// </summary>
		protected RUnityEngine.RVector3 r_m_myOriginPosInScene;
		public virtual RUnityEngine.RVector3 Rm_myOriginPosInScene
		{
			get
			{
				if(r_m_myOriginPosInScene == null)
				{
					r_m_myOriginPosInScene = new(this, "m_myOriginPosInScene");
					r_m_myOriginPosInScene.SetBelong(this.instance);
				}
				return r_m_myOriginPosInScene;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion m_myOriginRotInScene
		/// </summary>
		protected RUnityEngine.RQuaternion r_m_myOriginRotInScene;
		public virtual RUnityEngine.RQuaternion Rm_myOriginRotInScene
		{
			get
			{
				if(r_m_myOriginRotInScene == null)
				{
					r_m_myOriginRotInScene = new(this, "m_myOriginRotInScene");
					r_m_myOriginRotInScene.SetBelong(this.instance);
				}
				return r_m_myOriginRotInScene;
			}
		}

		/// <summary>
		/// AnimationController m_AnimCC
		/// </summary>
		protected RAnimationController r_m_AnimCC;
		public virtual RAnimationController Rm_AnimCC
		{
			get
			{
				if(r_m_AnimCC == null)
				{
					r_m_AnimCC = new(this, "m_AnimCC");
					r_m_AnimCC.SetBelong(this.instance);
				}
				return r_m_AnimCC;
			}
		}

		/// <summary>
		/// AvatarController m_avaterCC
		/// </summary>
		protected RAvatarController r_m_avaterCC;
		public virtual RAvatarController Rm_avaterCC
		{
			get
			{
				if(r_m_avaterCC == null)
				{
					r_m_avaterCC = new(this, "m_avaterCC");
					r_m_avaterCC.SetBelong(this.instance);
				}
				return r_m_avaterCC;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ShakeObjectOriginPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_ShakeObjectOriginPosition;
		public virtual RUnityEngine.RVector3 RShakeObjectOriginPosition
		{
			get
			{
				if(r_ShakeObjectOriginPosition == null)
				{
					r_ShakeObjectOriginPosition = new(this, "ShakeObjectOriginPosition");
					r_ShakeObjectOriginPosition.SetBelong(this.instance);
				}
				return r_ShakeObjectOriginPosition;
			}
		}

		/// <summary>
		/// System.Boolean bDoShakeEffect
		/// </summary>
		protected RField r_bDoShakeEffect;
		public virtual RField RbDoShakeEffect
		{
			get
			{
				if(r_bDoShakeEffect == null)
				{
					r_bDoShakeEffect = new(this, "bDoShakeEffect");
					r_bDoShakeEffect.SetBelong(this.instance);
				}
				return r_bDoShakeEffect;
			}
		}

		/// <summary>
		/// System.Single fShakeTime
		/// </summary>
		protected RField r_fShakeTime;
		public virtual RField RfShakeTime
		{
			get
			{
				if(r_fShakeTime == null)
				{
					r_fShakeTime = new(this, "fShakeTime");
					r_fShakeTime.SetBelong(this.instance);
				}
				return r_fShakeTime;
			}
		}

		/// <summary>
		/// System.Single ShakeEffDur
		/// </summary>
		protected RField r_ShakeEffDur;
		public virtual RField RShakeEffDur
		{
			get
			{
				if(r_ShakeEffDur == null)
				{
					r_ShakeEffDur = new(this, "ShakeEffDur");
					r_ShakeEffDur.SetBelong(this.instance);
				}
				return r_ShakeEffDur;
			}
		}

		/// <summary>
		/// System.Single ShakeLevel
		/// </summary>
		protected RField r_ShakeLevel;
		public virtual RField RShakeLevel
		{
			get
			{
				if(r_ShakeLevel == null)
				{
					r_ShakeLevel = new(this, "ShakeLevel");
					r_ShakeLevel.SetBelong(this.instance);
				}
				return r_ShakeLevel;
			}
		}

		/// <summary>
		/// System.Int32 mi_MemberID
		/// </summary>
		protected RField r_mi_MemberID;
		public virtual RField Rmi_MemberID
		{
			get
			{
				if(r_mi_MemberID == null)
				{
					r_mi_MemberID = new(this, "mi_MemberID");
					r_mi_MemberID.SetBelong(this.instance);
				}
				return r_mi_MemberID;
			}
		}

		/// <summary>
		/// System.Boolean mb_ActionFinished
		/// </summary>
		protected RField r_mb_ActionFinished;
		public virtual RField Rmb_ActionFinished
		{
			get
			{
				if(r_mb_ActionFinished == null)
				{
					r_mb_ActionFinished = new(this, "mb_ActionFinished");
					r_mb_ActionFinished.SetBelong(this.instance);
				}
				return r_mb_ActionFinished;
			}
		}

		/// <summary>
		/// UnityEngine.Transform _CommandTarget
		/// </summary>
		protected RUnityEngine.RTransform r__CommandTarget;
		public virtual RUnityEngine.RTransform R_CommandTarget
		{
			get
			{
				if(r__CommandTarget == null)
				{
					r__CommandTarget = new(this, "_CommandTarget");
					r__CommandTarget.SetBelong(this.instance);
				}
				return r__CommandTarget;
			}
		}

		/// <summary>
		/// CombatCommand m_CombatCommand
		/// </summary>
		protected RField r_m_CombatCommand;
		public virtual RField Rm_CombatCommand
		{
			get
			{
				if(r_m_CombatCommand == null)
				{
					r_m_CombatCommand = new(this, "m_CombatCommand");
					r_m_CombatCommand.SetBelong(this.instance);
				}
				return r_m_CombatCommand;
			}
		}

		/// <summary>
		/// GameDefineType.ID m_CombatCommandEx
		/// </summary>
		protected RGameDefineType.RID r_m_CombatCommandEx;
		public virtual RGameDefineType.RID Rm_CombatCommandEx
		{
			get
			{
				if(r_m_CombatCommandEx == null)
				{
					r_m_CombatCommandEx = new(this, "m_CombatCommandEx");
					r_m_CombatCommandEx.SetBelong(this.instance);
				}
				return r_m_CombatCommandEx;
			}
		}

		/// <summary>
		/// System.Boolean mb_CommandSelectEnd
		/// </summary>
		protected RField r_mb_CommandSelectEnd;
		public virtual RField Rmb_CommandSelectEnd
		{
			get
			{
				if(r_mb_CommandSelectEnd == null)
				{
					r_mb_CommandSelectEnd = new(this, "mb_CommandSelectEnd");
					r_mb_CommandSelectEnd.SetBelong(this.instance);
				}
				return r_mb_CommandSelectEnd;
			}
		}

		/// <summary>
		/// Pawn mPawn
		/// </summary>
		protected RPawn r_mPawn;
		public virtual RPawn RmPawn
		{
			get
			{
				if(r_mPawn == null)
				{
					r_mPawn = new(this, "mPawn");
					r_mPawn.SetBelong(this.instance);
				}
				return r_mPawn;
			}
		}

		/// <summary>
		/// System.Boolean mb_Selectable
		/// </summary>
		protected RField r_mb_Selectable;
		public virtual RField Rmb_Selectable
		{
			get
			{
				if(r_mb_Selectable == null)
				{
					r_mb_Selectable = new(this, "mb_Selectable");
					r_mb_Selectable.SetBelong(this.instance);
				}
				return r_mb_Selectable;
			}
		}

		/// <summary>
		/// System.Int32 CareerStage
		/// </summary>
		protected RField r_CareerStage;
		public virtual RField RCareerStage
		{
			get
			{
				if(r_CareerStage == null)
				{
					r_CareerStage = new(this, "CareerStage");
					r_CareerStage.SetBelong(this.instance);
				}
				return r_CareerStage;
			}
		}

		/// <summary>
		/// UnityEngine.SkinnedMeshRenderer mSKM
		/// </summary>
		protected RUnityEngine.RSkinnedMeshRenderer r_mSKM;
		public virtual RUnityEngine.RSkinnedMeshRenderer RmSKM
		{
			get
			{
				if(r_mSKM == null)
				{
					r_mSKM = new(this, "mSKM");
					r_mSKM.SetBelong(this.instance);
				}
				return r_mSKM;
			}
		}

		/// <summary>
		/// ECombatTeam mFighterType
		/// </summary>
		protected RField r_mFighterType;
		public virtual RField RmFighterType
		{
			get
			{
				if(r_mFighterType == null)
				{
					r_mFighterType = new(this, "mFighterType");
					r_mFighterType.SetBelong(this.instance);
				}
				return r_mFighterType;
			}
		}

		/// <summary>
		/// UnityEngine.CharacterController mCC
		/// </summary>
		protected RUnityEngine.RCharacterController r_mCC;
		public virtual RUnityEngine.RCharacterController RmCC
		{
			get
			{
				if(r_mCC == null)
				{
					r_mCC = new(this, "mCC");
					r_mCC.SetBelong(this.instance);
				}
				return r_mCC;
			}
		}

		/// <summary>
		/// CreatureBehav _Behav
		/// </summary>
		protected RCreatureBehav r__Behav;
		public virtual RCreatureBehav R_Behav
		{
			get
			{
				if(r__Behav == null)
				{
					r__Behav = new(this, "_Behav");
					r__Behav.SetBelong(this.instance);
				}
				return r__Behav;
			}
		}

		/// <summary>
		/// CareerSkillConfigItem mCurrentSkillConfigItem
		/// </summary>
		protected RCareerSkillConfigItem r_mCurrentSkillConfigItem;
		public virtual RCareerSkillConfigItem RmCurrentSkillConfigItem
		{
			get
			{
				if(r_mCurrentSkillConfigItem == null)
				{
					r_mCurrentSkillConfigItem = new(this, "mCurrentSkillConfigItem");
					r_mCurrentSkillConfigItem.SetBelong(this.instance);
				}
				return r_mCurrentSkillConfigItem;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleAction] mCurrentInjureList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBattleAction> r_mCurrentInjureList;
		public virtual RSystem.RCollections.RGeneric.RList<RBattleAction> RmCurrentInjureList
		{
			get
			{
				if(r_mCurrentInjureList == null)
				{
					r_mCurrentInjureList = new(this, "mCurrentInjureList");
					r_mCurrentInjureList.SetBelong(this.instance);
				}
				return r_mCurrentInjureList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Action] mCurrentActionResult
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RAction> r_mCurrentActionResult;
		public virtual RSystem.RCollections.RGeneric.RList<RAction> RmCurrentActionResult
		{
			get
			{
				if(r_mCurrentActionResult == null)
				{
					r_mCurrentActionResult = new(this, "mCurrentActionResult");
					r_mCurrentActionResult.SetBelong(this.instance);
				}
				return r_mCurrentActionResult;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleAction] mCurrentActionList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBattleAction> r_mCurrentActionList;
		public virtual RSystem.RCollections.RGeneric.RList<RBattleAction> RmCurrentActionList
		{
			get
			{
				if(r_mCurrentActionList == null)
				{
					r_mCurrentActionList = new(this, "mCurrentActionList");
					r_mCurrentActionList.SetBelong(this.instance);
				}
				return r_mCurrentActionList;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mBloodTexBG
		/// </summary>
		protected RUnityEngine.RTexture2D r_mBloodTexBG;
		public virtual RUnityEngine.RTexture2D RmBloodTexBG
		{
			get
			{
				if(r_mBloodTexBG == null)
				{
					r_mBloodTexBG = new(this, "mBloodTexBG");
					r_mBloodTexBG.SetBelong(this.instance);
				}
				return r_mBloodTexBG;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mBloodTex
		/// </summary>
		protected RUnityEngine.RTexture2D r_mBloodTex;
		public virtual RUnityEngine.RTexture2D RmBloodTex
		{
			get
			{
				if(r_mBloodTex == null)
				{
					r_mBloodTex = new(this, "mBloodTex");
					r_mBloodTex.SetBelong(this.instance);
				}
				return r_mBloodTex;
			}
		}

		/// <summary>
		/// UnityEngine.Color tmpMpColor
		/// </summary>
		protected static RUnityEngine.RColor r_tmpMpColor;
		public static RUnityEngine.RColor RtmpMpColor
		{
			get
			{
				if(r_tmpMpColor == null)
				{
					r_tmpMpColor = new( ReleactionUtils.GetType("CombatController"), "tmpMpColor");
					r_tmpMpColor.SetBelong(null);
				}
				return r_tmpMpColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color tmpHpColor
		/// </summary>
		protected static RUnityEngine.RColor r_tmpHpColor;
		public static RUnityEngine.RColor RtmpHpColor
		{
			get
			{
				if(r_tmpHpColor == null)
				{
					r_tmpHpColor = new( ReleactionUtils.GetType("CombatController"), "tmpHpColor");
					r_tmpHpColor.SetBelong(null);
				}
				return r_tmpHpColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color hpColor
		/// </summary>
		protected RUnityEngine.RColor r_hpColor;
		public virtual RUnityEngine.RColor RhpColor
		{
			get
			{
				if(r_hpColor == null)
				{
					r_hpColor = new(this, "hpColor");
					r_hpColor.SetBelong(this.instance);
				}
				return r_hpColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color hpFlashColor
		/// </summary>
		protected RUnityEngine.RColor r_hpFlashColor;
		public virtual RUnityEngine.RColor RhpFlashColor
		{
			get
			{
				if(r_hpFlashColor == null)
				{
					r_hpFlashColor = new(this, "hpFlashColor");
					r_hpFlashColor.SetBelong(this.instance);
				}
				return r_hpFlashColor;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_skillIcon
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_skillIcon;
		public virtual RUnityEngine.RTexture2D Rm_skillIcon
		{
			get
			{
				if(r_m_skillIcon == null)
				{
					r_m_skillIcon = new(this, "m_skillIcon");
					r_m_skillIcon.SetBelong(this.instance);
				}
				return r_m_skillIcon;
			}
		}

		/// <summary>
		/// GameDefineType.ID m_idSkill
		/// </summary>
		protected RGameDefineType.RID r_m_idSkill;
		public virtual RGameDefineType.RID Rm_idSkill
		{
			get
			{
				if(r_m_idSkill == null)
				{
					r_m_idSkill = new(this, "m_idSkill");
					r_m_idSkill.SetBelong(this.instance);
				}
				return r_m_idSkill;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_SuperSkillBuffEffect
		/// </summary>
		protected RUnityEngine.RGameObject r_m_SuperSkillBuffEffect;
		public virtual RUnityEngine.RGameObject Rm_SuperSkillBuffEffect
		{
			get
			{
				if(r_m_SuperSkillBuffEffect == null)
				{
					r_m_SuperSkillBuffEffect = new(this, "m_SuperSkillBuffEffect");
					r_m_SuperSkillBuffEffect.SetBelong(this.instance);
				}
				return r_m_SuperSkillBuffEffect;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_scoreEffect
		/// </summary>
		protected RUnityEngine.RGameObject r_m_scoreEffect;
		public virtual RUnityEngine.RGameObject Rm_scoreEffect
		{
			get
			{
				if(r_m_scoreEffect == null)
				{
					r_m_scoreEffect = new(this, "m_scoreEffect");
					r_m_scoreEffect.SetBelong(this.instance);
				}
				return r_m_scoreEffect;
			}
		}

		/// <summary>
		/// UIeffect m_scoreIconEffect
		/// </summary>
		protected RUIeffect r_m_scoreIconEffect;
		public virtual RUIeffect Rm_scoreIconEffect
		{
			get
			{
				if(r_m_scoreIconEffect == null)
				{
					r_m_scoreIconEffect = new(this, "m_scoreIconEffect");
					r_m_scoreIconEffect.SetBelong(this.instance);
				}
				return r_m_scoreIconEffect;
			}
		}

		/// <summary>
		/// UnityEngine.Rect skillIconStartRect
		/// </summary>
		protected RUnityEngine.RRect r_skillIconStartRect;
		public virtual RUnityEngine.RRect RskillIconStartRect
		{
			get
			{
				if(r_skillIconStartRect == null)
				{
					r_skillIconStartRect = new(this, "skillIconStartRect");
					r_skillIconStartRect.SetBelong(this.instance);
				}
				return r_skillIconStartRect;
			}
		}

		/// <summary>
		/// System.Single MaxTime
		/// </summary>
		protected RField r_MaxTime;
		public virtual RField RMaxTime
		{
			get
			{
				if(r_MaxTime == null)
				{
					r_MaxTime = new(this, "MaxTime");
					r_MaxTime.SetBelong(this.instance);
				}
				return r_MaxTime;
			}
		}

		/// <summary>
		/// System.Single LerpParam
		/// </summary>
		protected RField r_LerpParam;
		public virtual RField RLerpParam
		{
			get
			{
				if(r_LerpParam == null)
				{
					r_LerpParam = new(this, "LerpParam");
					r_LerpParam.SetBelong(this.instance);
				}
				return r_LerpParam;
			}
		}

		/// <summary>
		/// System.Int32 mScreenEffectTimeParm
		/// </summary>
		protected RField r_mScreenEffectTimeParm;
		public virtual RField RmScreenEffectTimeParm
		{
			get
			{
				if(r_mScreenEffectTimeParm == null)
				{
					r_mScreenEffectTimeParm = new(this, "mScreenEffectTimeParm");
					r_mScreenEffectTimeParm.SetBelong(this.instance);
				}
				return r_mScreenEffectTimeParm;
			}
		}

		/// <summary>
		/// System.Int32 mScreenEffectFrameDelta
		/// </summary>
		protected RField r_mScreenEffectFrameDelta;
		public virtual RField RmScreenEffectFrameDelta
		{
			get
			{
				if(r_mScreenEffectFrameDelta == null)
				{
					r_mScreenEffectFrameDelta = new(this, "mScreenEffectFrameDelta");
					r_mScreenEffectFrameDelta.SetBelong(this.instance);
				}
				return r_mScreenEffectFrameDelta;
			}
		}

		/// <summary>
		/// UnityEngine.Shader m_NormalShader
		/// </summary>
		protected RUnityEngine.RShader r_m_NormalShader;
		public virtual RUnityEngine.RShader Rm_NormalShader
		{
			get
			{
				if(r_m_NormalShader == null)
				{
					r_m_NormalShader = new(this, "m_NormalShader");
					r_m_NormalShader.SetBelong(this.instance);
				}
				return r_m_NormalShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader m_FlashShader
		/// </summary>
		protected RUnityEngine.RShader r_m_FlashShader;
		public virtual RUnityEngine.RShader Rm_FlashShader
		{
			get
			{
				if(r_m_FlashShader == null)
				{
					r_m_FlashShader = new(this, "m_FlashShader");
					r_m_FlashShader.SetBelong(this.instance);
				}
				return r_m_FlashShader;
			}
		}

		/// <summary>
		/// System.Int32 m_flashCount
		/// </summary>
		protected RField r_m_flashCount;
		public virtual RField Rm_flashCount
		{
			get
			{
				if(r_m_flashCount == null)
				{
					r_m_flashCount = new(this, "m_flashCount");
					r_m_flashCount.SetBelong(this.instance);
				}
				return r_m_flashCount;
			}
		}

		/// <summary>
		/// UnityEngine.Transform m_ProtectTarget
		/// </summary>
		protected RUnityEngine.RTransform r_m_ProtectTarget;
		public virtual RUnityEngine.RTransform Rm_ProtectTarget
		{
			get
			{
				if(r_m_ProtectTarget == null)
				{
					r_m_ProtectTarget = new(this, "m_ProtectTarget");
					r_m_ProtectTarget.SetBelong(this.instance);
				}
				return r_m_ProtectTarget;
			}
		}

		/// <summary>
		/// System.Boolean isDefending
		/// </summary>
		protected RField r_isDefending;
		public virtual RField RisDefending
		{
			get
			{
				if(r_isDefending == null)
				{
					r_isDefending = new(this, "isDefending");
					r_isDefending.SetBelong(this.instance);
				}
				return r_isDefending;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject HpFlashObject
		/// </summary>
		protected RUnityEngine.RGameObject r_HpFlashObject;
		public virtual RUnityEngine.RGameObject RHpFlashObject
		{
			get
			{
				if(r_HpFlashObject == null)
				{
					r_HpFlashObject = new(this, "HpFlashObject");
					r_HpFlashObject.SetBelong(this.instance);
				}
				return r_HpFlashObject;
			}
		}

		/// <summary>
		/// System.Boolean isHide
		/// </summary>
		protected RField r_isHide;
		public virtual RField RisHide
		{
			get
			{
				if(r_isHide == null)
				{
					r_isHide = new(this, "isHide");
					r_isHide.SetBelong(this.instance);
				}
				return r_isHide;
			}
		}

		/// <summary>
		/// System.Boolean isHideBloodUI
		/// </summary>
		protected RField r_isHideBloodUI;
		public virtual RField RisHideBloodUI
		{
			get
			{
				if(r_isHideBloodUI == null)
				{
					r_isHideBloodUI = new(this, "isHideBloodUI");
					r_isHideBloodUI.SetBelong(this.instance);
				}
				return r_isHideBloodUI;
			}
		}

		/// <summary>
		/// CombatController _followStuff
		/// </summary>
		protected RCombatController r__followStuff;
		public virtual RCombatController R_followStuff
		{
			get
			{
				if(r__followStuff == null)
				{
					r__followStuff = new(this, "_followStuff");
					r__followStuff.SetBelong(this.instance);
				}
				return r__followStuff;
			}
		}

		/// <summary>
		/// System.UInt32 idcarrerFollowStuff
		/// </summary>
		protected RField r_idcarrerFollowStuff;
		public virtual RField RidcarrerFollowStuff
		{
			get
			{
				if(r_idcarrerFollowStuff == null)
				{
					r_idcarrerFollowStuff = new(this, "idcarrerFollowStuff");
					r_idcarrerFollowStuff.SetBelong(this.instance);
				}
				return r_idcarrerFollowStuff;
			}
		}

		/// <summary>
		/// CombatController _masterCC
		/// </summary>
		protected RCombatController r__masterCC;
		public virtual RCombatController R_masterCC
		{
			get
			{
				if(r__masterCC == null)
				{
					r__masterCC = new(this, "_masterCC");
					r__masterCC.SetBelong(this.instance);
				}
				return r__masterCC;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject _followGameObjectRoot
		/// </summary>
		protected RUnityEngine.RGameObject r__followGameObjectRoot;
		public virtual RUnityEngine.RGameObject R_followGameObjectRoot
		{
			get
			{
				if(r__followGameObjectRoot == null)
				{
					r__followGameObjectRoot = new(this, "_followGameObjectRoot");
					r__followGameObjectRoot.SetBelong(this.instance);
				}
				return r__followGameObjectRoot;
			}
		}

		/// <summary>
		/// System.Boolean isFollowStuff
		/// </summary>
		protected RField r_isFollowStuff;
		public virtual RField RisFollowStuff
		{
			get
			{
				if(r_isFollowStuff == null)
				{
					r_isFollowStuff = new(this, "isFollowStuff");
					r_isFollowStuff.SetBelong(this.instance);
				}
				return r_isFollowStuff;
			}
		}

		/// <summary>
		/// System.UInt32 idCarrer
		/// </summary>
		protected RField r_idCarrer;
		public virtual RField RidCarrer
		{
			get
			{
				if(r_idCarrer == null)
				{
					r_idCarrer = new(this, "idCarrer");
					r_idCarrer.SetBelong(this.instance);
				}
				return r_idCarrer;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map25
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map25;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map25
		{
			get
			{
				if(r___2____4__f__switch__9__map25 == null)
				{
					r___2____4__f__switch__9__map25 = new( ReleactionUtils.GetType("CombatController"), "<>f__switch$map25");
					r___2____4__f__switch__9__map25.SetBelong(null);
				}
				return r___2____4__f__switch__9__map25;
			}
		}

		/// <summary>
		/// CombatAreaInfo m_CombatArea
		/// </summary>
		protected RCombatAreaInfo r_m_CombatArea;
		public virtual RCombatAreaInfo Rm_CombatArea
		{
			get
			{
				if(r_m_CombatArea == null)
				{
					r_m_CombatArea = new(this, "m_CombatArea", -1);
					r_m_CombatArea.SetBelong(this.instance);
				}
				return r_m_CombatArea;
			}
		}

		/// <summary>
		/// AnimationController m_AnimController
		/// </summary>
		protected RAnimationController r_m_AnimController;
		public virtual RAnimationController Rm_AnimController
		{
			get
			{
				if(r_m_AnimController == null)
				{
					r_m_AnimController = new(this, "m_AnimController", -1);
					r_m_AnimController.SetBelong(this.instance);
				}
				return r_m_AnimController;
			}
		}

		/// <summary>
		/// AvatarController m_avatarController
		/// </summary>
		protected RAvatarController r_m_avatarController;
		public virtual RAvatarController Rm_avatarController
		{
			get
			{
				if(r_m_avatarController == null)
				{
					r_m_avatarController = new(this, "m_avatarController", -1);
					r_m_avatarController.SetBelong(this.instance);
				}
				return r_m_avatarController;
			}
		}

		/// <summary>
		/// UnityEngine.Transform m_CommandTarget
		/// </summary>
		protected RUnityEngine.RTransform r_m_CommandTarget;
		public virtual RUnityEngine.RTransform Rm_CommandTarget
		{
			get
			{
				if(r_m_CommandTarget == null)
				{
					r_m_CommandTarget = new(this, "m_CommandTarget", -1);
					r_m_CommandTarget.SetBelong(this.instance);
				}
				return r_m_CommandTarget;
			}
		}

		/// <summary>
		/// Pawn pawn
		/// </summary>
		protected RPawn r_pawn;
		public virtual RPawn Rpawn
		{
			get
			{
				if(r_pawn == null)
				{
					r_pawn = new(this, "pawn", -1);
					r_pawn.SetBelong(this.instance);
				}
				return r_pawn;
			}
		}

		/// <summary>
		/// UnityEngine.SkinnedMeshRenderer m_smr
		/// </summary>
		protected RUnityEngine.RSkinnedMeshRenderer r_m_smr;
		public virtual RUnityEngine.RSkinnedMeshRenderer Rm_smr
		{
			get
			{
				if(r_m_smr == null)
				{
					r_m_smr = new(this, "m_smr", -1);
					r_m_smr.SetBelong(this.instance);
				}
				return r_m_smr;
			}
		}

		/// <summary>
		/// CreatureBehav myBehav
		/// </summary>
		protected RCreatureBehav r_myBehav;
		public virtual RCreatureBehav RmyBehav
		{
			get
			{
				if(r_myBehav == null)
				{
					r_myBehav = new(this, "myBehav", -1);
					r_myBehav.SetBelong(this.instance);
				}
				return r_myBehav;
			}
		}

		/// <summary>
		/// CombatController m_followStuff
		/// </summary>
		protected RCombatController r_m_followStuff;
		public virtual RCombatController Rm_followStuff
		{
			get
			{
				if(r_m_followStuff == null)
				{
					r_m_followStuff = new(this, "m_followStuff", -1);
					r_m_followStuff.SetBelong(this.instance);
				}
				return r_m_followStuff;
			}
		}

		/// <summary>
		/// CombatController m_masterCC
		/// </summary>
		protected RCombatController r_m_masterCC;
		public virtual RCombatController Rm_masterCC
		{
			get
			{
				if(r_m_masterCC == null)
				{
					r_m_masterCC = new(this, "m_masterCC", -1);
					r_m_masterCC.SetBelong(this.instance);
				}
				return r_m_masterCC;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken destroyCancellationToken
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_destroyCancellationToken;
		public virtual RSystem.RThreading.RCancellationToken RdestroyCancellationToken
		{
			get
			{
				if(r_destroyCancellationToken == null)
				{
					r_destroyCancellationToken = new(this, "destroyCancellationToken", -1);
					r_destroyCancellationToken.SetBelong(this.instance);
				}
				return r_destroyCancellationToken;
			}
		}

		/// <summary>
		/// Boolean useGUILayout
		/// </summary>
		protected RProperty r_useGUILayout;
		public virtual RProperty RuseGUILayout
		{
			get
			{
				if(r_useGUILayout == null)
				{
					r_useGUILayout = new(this, "useGUILayout", -1);
					r_useGUILayout.SetBelong(this.instance);
				}
				return r_useGUILayout;
			}
		}

		/// <summary>
		/// Boolean runInEditMode
		/// </summary>
		protected RProperty r_runInEditMode;
		public virtual RProperty RrunInEditMode
		{
			get
			{
				if(r_runInEditMode == null)
				{
					r_runInEditMode = new(this, "runInEditMode", -1);
					r_runInEditMode.SetBelong(this.instance);
				}
				return r_runInEditMode;
			}
		}

		/// <summary>
		/// Boolean allowPrefabModeInPlayMode
		/// </summary>
		protected RProperty r_allowPrefabModeInPlayMode;
		public virtual RProperty RallowPrefabModeInPlayMode
		{
			get
			{
				if(r_allowPrefabModeInPlayMode == null)
				{
					r_allowPrefabModeInPlayMode = new(this, "allowPrefabModeInPlayMode", -1);
					r_allowPrefabModeInPlayMode.SetBelong(this.instance);
				}
				return r_allowPrefabModeInPlayMode;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RProperty r_enabled;
		public virtual RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// Boolean isActiveAndEnabled
		/// </summary>
		protected RProperty r_isActiveAndEnabled;
		public virtual RProperty RisActiveAndEnabled
		{
			get
			{
				if(r_isActiveAndEnabled == null)
				{
					r_isActiveAndEnabled = new(this, "isActiveAndEnabled", -1);
					r_isActiveAndEnabled.SetBelong(this.instance);
				}
				return r_isActiveAndEnabled;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected RUnityEngine.RTransform r_transform;
		public virtual RUnityEngine.RTransform Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform", -1);
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject gameObject
		/// </summary>
		protected RUnityEngine.RGameObject r_gameObject;
		public virtual RUnityEngine.RGameObject RgameObject
		{
			get
			{
				if(r_gameObject == null)
				{
					r_gameObject = new(this, "gameObject", -1);
					r_gameObject.SetBelong(this.instance);
				}
				return r_gameObject;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected RProperty r_tag;
		public virtual RProperty Rtag
		{
			get
			{
				if(r_tag == null)
				{
					r_tag = new(this, "tag", -1);
					r_tag.SetBelong(this.instance);
				}
				return r_tag;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody
		/// </summary>
		protected RUnityEngine.RComponent r_rigidbody;
		public virtual RUnityEngine.RComponent Rrigidbody
		{
			get
			{
				if(r_rigidbody == null)
				{
					r_rigidbody = new(this, "rigidbody", -1);
					r_rigidbody.SetBelong(this.instance);
				}
				return r_rigidbody;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody2D
		/// </summary>
		protected RUnityEngine.RComponent r_rigidbody2D;
		public virtual RUnityEngine.RComponent Rrigidbody2D
		{
			get
			{
				if(r_rigidbody2D == null)
				{
					r_rigidbody2D = new(this, "rigidbody2D", -1);
					r_rigidbody2D.SetBelong(this.instance);
				}
				return r_rigidbody2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component camera
		/// </summary>
		protected RUnityEngine.RComponent r_camera;
		public virtual RUnityEngine.RComponent Rcamera
		{
			get
			{
				if(r_camera == null)
				{
					r_camera = new(this, "camera", -1);
					r_camera.SetBelong(this.instance);
				}
				return r_camera;
			}
		}

		/// <summary>
		/// UnityEngine.Component light
		/// </summary>
		protected RUnityEngine.RComponent r_light;
		public virtual RUnityEngine.RComponent Rlight
		{
			get
			{
				if(r_light == null)
				{
					r_light = new(this, "light", -1);
					r_light.SetBelong(this.instance);
				}
				return r_light;
			}
		}

		/// <summary>
		/// UnityEngine.Component animation
		/// </summary>
		protected RUnityEngine.RComponent r_animation;
		public virtual RUnityEngine.RComponent Ranimation
		{
			get
			{
				if(r_animation == null)
				{
					r_animation = new(this, "animation", -1);
					r_animation.SetBelong(this.instance);
				}
				return r_animation;
			}
		}

		/// <summary>
		/// UnityEngine.Component constantForce
		/// </summary>
		protected RUnityEngine.RComponent r_constantForce;
		public virtual RUnityEngine.RComponent RconstantForce
		{
			get
			{
				if(r_constantForce == null)
				{
					r_constantForce = new(this, "constantForce", -1);
					r_constantForce.SetBelong(this.instance);
				}
				return r_constantForce;
			}
		}

		/// <summary>
		/// UnityEngine.Component renderer
		/// </summary>
		protected RUnityEngine.RComponent r_renderer;
		public virtual RUnityEngine.RComponent Rrenderer
		{
			get
			{
				if(r_renderer == null)
				{
					r_renderer = new(this, "renderer", -1);
					r_renderer.SetBelong(this.instance);
				}
				return r_renderer;
			}
		}

		/// <summary>
		/// UnityEngine.Component audio
		/// </summary>
		protected RUnityEngine.RComponent r_audio;
		public virtual RUnityEngine.RComponent Raudio
		{
			get
			{
				if(r_audio == null)
				{
					r_audio = new(this, "audio", -1);
					r_audio.SetBelong(this.instance);
				}
				return r_audio;
			}
		}

		/// <summary>
		/// UnityEngine.Component networkView
		/// </summary>
		protected RUnityEngine.RComponent r_networkView;
		public virtual RUnityEngine.RComponent RnetworkView
		{
			get
			{
				if(r_networkView == null)
				{
					r_networkView = new(this, "networkView", -1);
					r_networkView.SetBelong(this.instance);
				}
				return r_networkView;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider
		/// </summary>
		protected RUnityEngine.RComponent r_collider;
		public virtual RUnityEngine.RComponent Rcollider
		{
			get
			{
				if(r_collider == null)
				{
					r_collider = new(this, "collider", -1);
					r_collider.SetBelong(this.instance);
				}
				return r_collider;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider2D
		/// </summary>
		protected RUnityEngine.RComponent r_collider2D;
		public virtual RUnityEngine.RComponent Rcollider2D
		{
			get
			{
				if(r_collider2D == null)
				{
					r_collider2D = new(this, "collider2D", -1);
					r_collider2D.SetBelong(this.instance);
				}
				return r_collider2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component hingeJoint
		/// </summary>
		protected RUnityEngine.RComponent r_hingeJoint;
		public virtual RUnityEngine.RComponent RhingeJoint
		{
			get
			{
				if(r_hingeJoint == null)
				{
					r_hingeJoint = new(this, "hingeJoint", -1);
					r_hingeJoint.SetBelong(this.instance);
				}
				return r_hingeJoint;
			}
		}

		/// <summary>
		/// UnityEngine.Component particleSystem
		/// </summary>
		protected RUnityEngine.RComponent r_particleSystem;
		public virtual RUnityEngine.RComponent RparticleSystem
		{
			get
			{
				if(r_particleSystem == null)
				{
					r_particleSystem = new(this, "particleSystem", -1);
					r_particleSystem.SetBelong(this.instance);
				}
				return r_particleSystem;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// System.String GetSpecialMonster_NAME(System.String, Int32)
		/// </summary>
		protected RMethod r_RGetSpecialMonster_NAME_String_Int32;
		public virtual RMethod RGetSpecialMonster_NAME_String_Int32
		{
			get
			{
				if(r_RGetSpecialMonster_NAME_String_Int32 == null)
				{
					r_RGetSpecialMonster_NAME_String_Int32 = new(this, "GetSpecialMonster_NAME", 0, typeof(System.String), typeof(System.Int32));
					r_RGetSpecialMonster_NAME_String_Int32.SetBelong(this.instance);
				}
				return r_RGetSpecialMonster_NAME_String_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetPetColor(Int32)
		/// </summary>
		protected static RMethod r_RGetPetColor_Int32;
		public static RMethod RGetPetColor_Int32
		{
			get
			{
				if(r_RGetPetColor_Int32 == null)
				{
					r_RGetPetColor_Int32 = new( ReleactionUtils.GetType("CombatController"), "GetPetColor", 0, typeof(System.Int32));
					r_RGetPetColor_Int32.SetBelong(null);
				}
				return r_RGetPetColor_Int32;
			}
		}

		/// <summary>
		/// Void TransMapUpdateInfo(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RTransMapUpdateInfo_GameObject;
		public virtual RMethod RTransMapUpdateInfo_GameObject
		{
			get
			{
				if(r_RTransMapUpdateInfo_GameObject == null)
				{
					r_RTransMapUpdateInfo_GameObject = new(this, "TransMapUpdateInfo", 0, typeof(UnityEngine.GameObject));
					r_RTransMapUpdateInfo_GameObject.SetBelong(this.instance);
				}
				return r_RTransMapUpdateInfo_GameObject;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_RInitialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_RInitialize == null)
				{
					r_RInitialize = new(this, "Initialize", 0);
					r_RInitialize.SetBelong(this.instance);
				}
				return r_RInitialize;
			}
		}

		/// <summary>
		/// Void OnRoundStart(Int32)
		/// </summary>
		protected RMethod r_ROnRoundStart_Int32;
		public virtual RMethod ROnRoundStart_Int32
		{
			get
			{
				if(r_ROnRoundStart_Int32 == null)
				{
					r_ROnRoundStart_Int32 = new(this, "OnRoundStart", 0, typeof(System.Int32));
					r_ROnRoundStart_Int32.SetBelong(this.instance);
				}
				return r_ROnRoundStart_Int32;
			}
		}

		/// <summary>
		/// Void OnRoundStartReconnect()
		/// </summary>
		protected RMethod r_ROnRoundStartReconnect;
		public virtual RMethod ROnRoundStartReconnect
		{
			get
			{
				if(r_ROnRoundStartReconnect == null)
				{
					r_ROnRoundStartReconnect = new(this, "OnRoundStartReconnect", 0);
					r_ROnRoundStartReconnect.SetBelong(this.instance);
				}
				return r_ROnRoundStartReconnect;
			}
		}

		/// <summary>
		/// Void Init(Fighter, ECombatTeam)
		/// </summary>
		protected RMethod r_RInit_Fighter_ECombatTeam;
		public virtual RMethod RInit_Fighter_ECombatTeam
		{
			get
			{
				if(r_RInit_Fighter_ECombatTeam == null)
				{
					r_RInit_Fighter_ECombatTeam = new(this, "Init", 0,  ReleactionUtils.GetType("Fighter"),  ReleactionUtils.GetType("ECombatTeam"));
					r_RInit_Fighter_ECombatTeam.SetBelong(this.instance);
				}
				return r_RInit_Fighter_ECombatTeam;
			}
		}

		/// <summary>
		/// Void CareerStageChange()
		/// </summary>
		protected RMethod r_RCareerStageChange;
		public virtual RMethod RCareerStageChange
		{
			get
			{
				if(r_RCareerStageChange == null)
				{
					r_RCareerStageChange = new(this, "CareerStageChange", 0);
					r_RCareerStageChange.SetBelong(this.instance);
				}
				return r_RCareerStageChange;
			}
		}

		/// <summary>
		/// Void CarrerChangeAction()
		/// </summary>
		protected RMethod r_RCarrerChangeAction;
		public virtual RMethod RCarrerChangeAction
		{
			get
			{
				if(r_RCarrerChangeAction == null)
				{
					r_RCarrerChangeAction = new(this, "CarrerChangeAction", 0);
					r_RCarrerChangeAction.SetBelong(this.instance);
				}
				return r_RCarrerChangeAction;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator PlayApperar()
		/// </summary>
		protected RMethod r_RPlayApperar;
		public virtual RMethod RPlayApperar
		{
			get
			{
				if(r_RPlayApperar == null)
				{
					r_RPlayApperar = new(this, "PlayApperar", 0);
					r_RPlayApperar.SetBelong(this.instance);
				}
				return r_RPlayApperar;
			}
		}

		/// <summary>
		/// Void CareerStageChangeFinish(System.Object, #u.#5ab)
		/// </summary>
		protected RMethod r_RCareerStageChangeFinish_Object___0__5ab;
		public virtual RMethod RCareerStageChangeFinish_Object___0__5ab
		{
			get
			{
				if(r_RCareerStageChangeFinish_Object___0__5ab == null)
				{
					r_RCareerStageChangeFinish_Object___0__5ab = new(this, "CareerStageChangeFinish", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#5ab"));
					r_RCareerStageChangeFinish_Object___0__5ab.SetBelong(this.instance);
				}
				return r_RCareerStageChangeFinish_Object___0__5ab;
			}
		}

		/// <summary>
		/// Void PlayIdle(System.Object, #u.#5ab)
		/// </summary>
		protected RMethod r_RPlayIdle_Object___0__5ab;
		public virtual RMethod RPlayIdle_Object___0__5ab
		{
			get
			{
				if(r_RPlayIdle_Object___0__5ab == null)
				{
					r_RPlayIdle_Object___0__5ab = new(this, "PlayIdle", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#5ab"));
					r_RPlayIdle_Object___0__5ab.SetBelong(this.instance);
				}
				return r_RPlayIdle_Object___0__5ab;
			}
		}

		/// <summary>
		/// System.String GetStateAnimationName(System.String)
		/// </summary>
		protected RMethod r_RGetStateAnimationName_String;
		public virtual RMethod RGetStateAnimationName_String
		{
			get
			{
				if(r_RGetStateAnimationName_String == null)
				{
					r_RGetStateAnimationName_String = new(this, "GetStateAnimationName", 0, typeof(System.String));
					r_RGetStateAnimationName_String.SetBelong(this.instance);
				}
				return r_RGetStateAnimationName_String;
			}
		}

		/// <summary>
		/// Boolean isHeavyInjured()
		/// </summary>
		protected RMethod r_RisHeavyInjured;
		public virtual RMethod RisHeavyInjured
		{
			get
			{
				if(r_RisHeavyInjured == null)
				{
					r_RisHeavyInjured = new(this, "isHeavyInjured", 0);
					r_RisHeavyInjured.SetBelong(this.instance);
				}
				return r_RisHeavyInjured;
			}
		}

		/// <summary>
		/// Void PlayIdle()
		/// </summary>
		protected RMethod r_RPlayIdle;
		public virtual RMethod RPlayIdle
		{
			get
			{
				if(r_RPlayIdle == null)
				{
					r_RPlayIdle = new(this, "PlayIdle", 0);
					r_RPlayIdle.SetBelong(this.instance);
				}
				return r_RPlayIdle;
			}
		}

		/// <summary>
		/// Void PlayIdle(Boolean)
		/// </summary>
		protected RMethod r_RPlayIdle_Boolean;
		public virtual RMethod RPlayIdle_Boolean
		{
			get
			{
				if(r_RPlayIdle_Boolean == null)
				{
					r_RPlayIdle_Boolean = new(this, "PlayIdle", 0, typeof(System.Boolean));
					r_RPlayIdle_Boolean.SetBelong(this.instance);
				}
				return r_RPlayIdle_Boolean;
			}
		}

		/// <summary>
		/// Void PlayVictory(AniEventHandler)
		/// </summary>
		protected RMethod r_RPlayVictory_AniEventHandler;
		public virtual RMethod RPlayVictory_AniEventHandler
		{
			get
			{
				if(r_RPlayVictory_AniEventHandler == null)
				{
					r_RPlayVictory_AniEventHandler = new(this, "PlayVictory", 0,  ReleactionUtils.GetType("AniEventHandler"));
					r_RPlayVictory_AniEventHandler.SetBelong(this.instance);
				}
				return r_RPlayVictory_AniEventHandler;
			}
		}

		/// <summary>
		/// Single VictoryAniTime()
		/// </summary>
		protected RMethod r_RVictoryAniTime;
		public virtual RMethod RVictoryAniTime
		{
			get
			{
				if(r_RVictoryAniTime == null)
				{
					r_RVictoryAniTime = new(this, "VictoryAniTime", 0);
					r_RVictoryAniTime.SetBelong(this.instance);
				}
				return r_RVictoryAniTime;
			}
		}

		/// <summary>
		/// Void TureAround()
		/// </summary>
		protected RMethod r_RTureAround;
		public virtual RMethod RTureAround
		{
			get
			{
				if(r_RTureAround == null)
				{
					r_RTureAround = new(this, "TureAround", 0);
					r_RTureAround.SetBelong(this.instance);
				}
				return r_RTureAround;
			}
		}

		/// <summary>
		/// Void LookAtFront()
		/// </summary>
		protected RMethod r_RLookAtFront;
		public virtual RMethod RLookAtFront
		{
			get
			{
				if(r_RLookAtFront == null)
				{
					r_RLookAtFront = new(this, "LookAtFront", 0);
					r_RLookAtFront.SetBelong(this.instance);
				}
				return r_RLookAtFront;
			}
		}

		/// <summary>
		/// Void LoakAtTarget()
		/// </summary>
		protected RMethod r_RLoakAtTarget;
		public virtual RMethod RLoakAtTarget
		{
			get
			{
				if(r_RLoakAtTarget == null)
				{
					r_RLoakAtTarget = new(this, "LoakAtTarget", 0);
					r_RLoakAtTarget.SetBelong(this.instance);
				}
				return r_RLoakAtTarget;
			}
		}

		/// <summary>
		/// Void SetActionList(System.Object)
		/// </summary>
		protected RMethod r_RSetActionList_Object;
		public virtual RMethod RSetActionList_Object
		{
			get
			{
				if(r_RSetActionList_Object == null)
				{
					r_RSetActionList_Object = new(this, "SetActionList", 0, typeof(System.Object));
					r_RSetActionList_Object.SetBelong(this.instance);
				}
				return r_RSetActionList_Object;
			}
		}

		/// <summary>
		/// Boolean isInjureFinish()
		/// </summary>
		protected RMethod r_RisInjureFinish;
		public virtual RMethod RisInjureFinish
		{
			get
			{
				if(r_RisInjureFinish == null)
				{
					r_RisInjureFinish = new(this, "isInjureFinish", 0);
					r_RisInjureFinish.SetBelong(this.instance);
				}
				return r_RisInjureFinish;
			}
		}

		/// <summary>
		/// Boolean isAttackFinish()
		/// </summary>
		protected RMethod r_RisAttackFinish;
		public virtual RMethod RisAttackFinish
		{
			get
			{
				if(r_RisAttackFinish == null)
				{
					r_RisAttackFinish = new(this, "isAttackFinish", 0);
					r_RisAttackFinish.SetBelong(this.instance);
				}
				return r_RisAttackFinish;
			}
		}

		/// <summary>
		/// Boolean isActionFinish()
		/// </summary>
		protected RMethod r_RisActionFinish;
		public virtual RMethod RisActionFinish
		{
			get
			{
				if(r_RisActionFinish == null)
				{
					r_RisActionFinish = new(this, "isActionFinish", 0);
					r_RisActionFinish.SetBelong(this.instance);
				}
				return r_RisActionFinish;
			}
		}

		/// <summary>
		/// Void ClearCurrentAction()
		/// </summary>
		protected RMethod r_RClearCurrentAction;
		public virtual RMethod RClearCurrentAction
		{
			get
			{
				if(r_RClearCurrentAction == null)
				{
					r_RClearCurrentAction = new(this, "ClearCurrentAction", 0);
					r_RClearCurrentAction.SetBelong(this.instance);
				}
				return r_RClearCurrentAction;
			}
		}

		/// <summary>
		/// Int32 GetCurrentActionCount()
		/// </summary>
		protected RMethod r_RGetCurrentActionCount;
		public virtual RMethod RGetCurrentActionCount
		{
			get
			{
				if(r_RGetCurrentActionCount == null)
				{
					r_RGetCurrentActionCount = new(this, "GetCurrentActionCount", 0);
					r_RGetCurrentActionCount.SetBelong(this.instance);
				}
				return r_RGetCurrentActionCount;
			}
		}

		/// <summary>
		/// Void SetConAtkActionList(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RSetConAtkActionList_Transform;
		public virtual RMethod RSetConAtkActionList_Transform
		{
			get
			{
				if(r_RSetConAtkActionList_Transform == null)
				{
					r_RSetConAtkActionList_Transform = new(this, "SetConAtkActionList", 0, typeof(UnityEngine.Transform));
					r_RSetConAtkActionList_Transform.SetBelong(this.instance);
				}
				return r_RSetConAtkActionList_Transform;
			}
		}

		/// <summary>
		/// Boolean isSeriAtkAction(System.Collections.Generic.List`1[Action])
		/// </summary>
		protected RMethod r_RisSeriAtkAction_List_d_Action_p_;
		public virtual RMethod RisSeriAtkAction_List_d_Action_p_
		{
			get
			{
				if(r_RisSeriAtkAction_List_d_Action_p_ == null)
				{
					r_RisSeriAtkAction_List_d_Action_p_ = new(this, "isSeriAtkAction", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("Action")));
					r_RisSeriAtkAction_List_d_Action_p_.SetBelong(this.instance);
				}
				return r_RisSeriAtkAction_List_d_Action_p_;
			}
		}

		/// <summary>
		/// Boolean IsConAtkAction(System.Collections.Generic.List`1[Action])
		/// </summary>
		protected RMethod r_RIsConAtkAction_List_d_Action_p_;
		public virtual RMethod RIsConAtkAction_List_d_Action_p_
		{
			get
			{
				if(r_RIsConAtkAction_List_d_Action_p_ == null)
				{
					r_RIsConAtkAction_List_d_Action_p_ = new(this, "IsConAtkAction", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("Action")));
					r_RIsConAtkAction_List_d_Action_p_.SetBelong(this.instance);
				}
				return r_RIsConAtkAction_List_d_Action_p_;
			}
		}

		/// <summary>
		/// Void AddActionInList(System.Collections.Generic.List`1[BattleAction], Boolean, Boolean)
		/// </summary>
		protected RMethod r_RAddActionInList_List_d_BattleAction_p__Boolean_Boolean;
		public virtual RMethod RAddActionInList_List_d_BattleAction_p__Boolean_Boolean
		{
			get
			{
				if(r_RAddActionInList_List_d_BattleAction_p__Boolean_Boolean == null)
				{
					r_RAddActionInList_List_d_BattleAction_p__Boolean_Boolean = new(this, "AddActionInList", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("BattleAction")), typeof(System.Boolean), typeof(System.Boolean));
					r_RAddActionInList_List_d_BattleAction_p__Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RAddActionInList_List_d_BattleAction_p__Boolean_Boolean;
			}
		}

		/// <summary>
		/// CareerSkillConfigItem ItemHpCheck(CareerSkillConfigItem)
		/// </summary>
		protected RMethod r_RItemHpCheck_CareerSkillConfigItem;
		public virtual RMethod RItemHpCheck_CareerSkillConfigItem
		{
			get
			{
				if(r_RItemHpCheck_CareerSkillConfigItem == null)
				{
					r_RItemHpCheck_CareerSkillConfigItem = new(this, "ItemHpCheck", 0,  ReleactionUtils.GetType("CareerSkillConfigItem"));
					r_RItemHpCheck_CareerSkillConfigItem.SetBelong(this.instance);
				}
				return r_RItemHpCheck_CareerSkillConfigItem;
			}
		}

		/// <summary>
		/// Void NewFrame_ActionInit(GameDefineType.ID, UInt32)
		/// </summary>
		protected RMethod r_RNewFrame_ActionInit_ID_UInt32;
		public virtual RMethod RNewFrame_ActionInit_ID_UInt32
		{
			get
			{
				if(r_RNewFrame_ActionInit_ID_UInt32 == null)
				{
					r_RNewFrame_ActionInit_ID_UInt32 = new(this, "NewFrame_ActionInit", 0, typeof(GameDefineType.ID), typeof(System.UInt32));
					r_RNewFrame_ActionInit_ID_UInt32.SetBelong(this.instance);
				}
				return r_RNewFrame_ActionInit_ID_UInt32;
			}
		}

		/// <summary>
		/// Void DebugActionList(System.Collections.Generic.List`1[BattleAction])
		/// </summary>
		protected RMethod r_RDebugActionList_List_d_BattleAction_p_;
		public virtual RMethod RDebugActionList_List_d_BattleAction_p_
		{
			get
			{
				if(r_RDebugActionList_List_d_BattleAction_p_ == null)
				{
					r_RDebugActionList_List_d_BattleAction_p_ = new(this, "DebugActionList", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("BattleAction")));
					r_RDebugActionList_List_d_BattleAction_p_.SetBelong(this.instance);
				}
				return r_RDebugActionList_List_d_BattleAction_p_;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator NewFrame_SetMemberFinish()
		/// </summary>
		protected RMethod r_RNewFrame_SetMemberFinish;
		public virtual RMethod RNewFrame_SetMemberFinish
		{
			get
			{
				if(r_RNewFrame_SetMemberFinish == null)
				{
					r_RNewFrame_SetMemberFinish = new(this, "NewFrame_SetMemberFinish", 0);
					r_RNewFrame_SetMemberFinish.SetBelong(this.instance);
				}
				return r_RNewFrame_SetMemberFinish;
			}
		}

		/// <summary>
		/// Void NewFrame_ExcActionListArg(System.Object, #u.#5ab)
		/// </summary>
		protected RMethod r_RNewFrame_ExcActionListArg_Object___0__5ab;
		public virtual RMethod RNewFrame_ExcActionListArg_Object___0__5ab
		{
			get
			{
				if(r_RNewFrame_ExcActionListArg_Object___0__5ab == null)
				{
					r_RNewFrame_ExcActionListArg_Object___0__5ab = new(this, "NewFrame_ExcActionListArg", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#5ab"));
					r_RNewFrame_ExcActionListArg_Object___0__5ab.SetBelong(this.instance);
				}
				return r_RNewFrame_ExcActionListArg_Object___0__5ab;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator NewFrame_ExcActionListDelay(Single)
		/// </summary>
		protected RMethod r_RNewFrame_ExcActionListDelay_Single;
		public virtual RMethod RNewFrame_ExcActionListDelay_Single
		{
			get
			{
				if(r_RNewFrame_ExcActionListDelay_Single == null)
				{
					r_RNewFrame_ExcActionListDelay_Single = new(this, "NewFrame_ExcActionListDelay", 0, typeof(System.Single));
					r_RNewFrame_ExcActionListDelay_Single.SetBelong(this.instance);
				}
				return r_RNewFrame_ExcActionListDelay_Single;
			}
		}

		/// <summary>
		/// Void NewFrame_ExcActionList()
		/// </summary>
		protected RMethod r_RNewFrame_ExcActionList;
		public virtual RMethod RNewFrame_ExcActionList
		{
			get
			{
				if(r_RNewFrame_ExcActionList == null)
				{
					r_RNewFrame_ExcActionList = new(this, "NewFrame_ExcActionList", 0);
					r_RNewFrame_ExcActionList.SetBelong(this.instance);
				}
				return r_RNewFrame_ExcActionList;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator CleaInjureActionList(Single)
		/// </summary>
		protected RMethod r_RCleaInjureActionList_Single;
		public virtual RMethod RCleaInjureActionList_Single
		{
			get
			{
				if(r_RCleaInjureActionList_Single == null)
				{
					r_RCleaInjureActionList_Single = new(this, "CleaInjureActionList", 0, typeof(System.Single));
					r_RCleaInjureActionList_Single.SetBelong(this.instance);
				}
				return r_RCleaInjureActionList_Single;
			}
		}

		/// <summary>
		/// Void CleaInjureActionList(System.Object, #u.#5ab)
		/// </summary>
		protected RMethod r_RCleaInjureActionList_Object___0__5ab;
		public virtual RMethod RCleaInjureActionList_Object___0__5ab
		{
			get
			{
				if(r_RCleaInjureActionList_Object___0__5ab == null)
				{
					r_RCleaInjureActionList_Object___0__5ab = new(this, "CleaInjureActionList", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#5ab"));
					r_RCleaInjureActionList_Object___0__5ab.SetBelong(this.instance);
				}
				return r_RCleaInjureActionList_Object___0__5ab;
			}
		}

		/// <summary>
		/// Void NewFrame_ExcAction(BattleAction, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RNewFrame_ExcAction_BattleAction_Boolean_Boolean;
		public virtual RMethod RNewFrame_ExcAction_BattleAction_Boolean_Boolean
		{
			get
			{
				if(r_RNewFrame_ExcAction_BattleAction_Boolean_Boolean == null)
				{
					r_RNewFrame_ExcAction_BattleAction_Boolean_Boolean = new(this, "NewFrame_ExcAction", 0,  ReleactionUtils.GetType("BattleAction"), typeof(System.Boolean), typeof(System.Boolean));
					r_RNewFrame_ExcAction_BattleAction_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RNewFrame_ExcAction_BattleAction_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void ExcActionAnimation(BattleAction, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RExcActionAnimation_BattleAction_Boolean_Boolean;
		public virtual RMethod RExcActionAnimation_BattleAction_Boolean_Boolean
		{
			get
			{
				if(r_RExcActionAnimation_BattleAction_Boolean_Boolean == null)
				{
					r_RExcActionAnimation_BattleAction_Boolean_Boolean = new(this, "ExcActionAnimation", 0,  ReleactionUtils.GetType("BattleAction"), typeof(System.Boolean), typeof(System.Boolean));
					r_RExcActionAnimation_BattleAction_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RExcActionAnimation_BattleAction_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void ExcActionMove(BattleAction, Boolean, UnityEngine.Vector3, UnityEngine.Vector3, Boolean)
		/// </summary>
		protected RMethod r_RExcActionMove_BattleAction_Boolean_Vector3_Vector3_Boolean;
		public virtual RMethod RExcActionMove_BattleAction_Boolean_Vector3_Vector3_Boolean
		{
			get
			{
				if(r_RExcActionMove_BattleAction_Boolean_Vector3_Vector3_Boolean == null)
				{
					r_RExcActionMove_BattleAction_Boolean_Vector3_Vector3_Boolean = new(this, "ExcActionMove", 0,  ReleactionUtils.GetType("BattleAction"), typeof(System.Boolean), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_RExcActionMove_BattleAction_Boolean_Vector3_Vector3_Boolean.SetBelong(this.instance);
				}
				return r_RExcActionMove_BattleAction_Boolean_Vector3_Vector3_Boolean;
			}
		}

		/// <summary>
		/// Void InvokeEffects(BattleAction)
		/// </summary>
		protected RMethod r_RInvokeEffects_BattleAction;
		public virtual RMethod RInvokeEffects_BattleAction
		{
			get
			{
				if(r_RInvokeEffects_BattleAction == null)
				{
					r_RInvokeEffects_BattleAction = new(this, "InvokeEffects", 0,  ReleactionUtils.GetType("BattleAction"));
					r_RInvokeEffects_BattleAction.SetBelong(this.instance);
				}
				return r_RInvokeEffects_BattleAction;
			}
		}

		/// <summary>
		/// Void NewFrame_End()
		/// </summary>
		protected RMethod r_RNewFrame_End;
		public virtual RMethod RNewFrame_End
		{
			get
			{
				if(r_RNewFrame_End == null)
				{
					r_RNewFrame_End = new(this, "NewFrame_End", 0);
					r_RNewFrame_End.SetBelong(this.instance);
				}
				return r_RNewFrame_End;
			}
		}

		/// <summary>
		/// Void StartAction()
		/// </summary>
		protected RMethod r_RStartAction;
		public virtual RMethod RStartAction
		{
			get
			{
				if(r_RStartAction == null)
				{
					r_RStartAction = new(this, "StartAction", 0);
					r_RStartAction.SetBelong(this.instance);
				}
				return r_RStartAction;
			}
		}

		/// <summary>
		/// Void UpdateCombat()
		/// </summary>
		protected RMethod r_RUpdateCombat;
		public virtual RMethod RUpdateCombat
		{
			get
			{
				if(r_RUpdateCombat == null)
				{
					r_RUpdateCombat = new(this, "UpdateCombat", 0);
					r_RUpdateCombat.SetBelong(this.instance);
				}
				return r_RUpdateCombat;
			}
		}

		/// <summary>
		/// Void OnAttacked(System.String, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_ROnAttacked_String_String_Boolean_Boolean;
		public virtual RMethod ROnAttacked_String_String_Boolean_Boolean
		{
			get
			{
				if(r_ROnAttacked_String_String_Boolean_Boolean == null)
				{
					r_ROnAttacked_String_String_Boolean_Boolean = new(this, "OnAttacked", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_ROnAttacked_String_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_ROnAttacked_String_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void ApplyDamage(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RApplyDamage_Transform;
		public virtual RMethod RApplyDamage_Transform
		{
			get
			{
				if(r_RApplyDamage_Transform == null)
				{
					r_RApplyDamage_Transform = new(this, "ApplyDamage", 0, typeof(UnityEngine.Transform));
					r_RApplyDamage_Transform.SetBelong(this.instance);
				}
				return r_RApplyDamage_Transform;
			}
		}

		/// <summary>
		/// Void SubTakeDamage(System.String, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RSubTakeDamage_String_String_Boolean_Boolean;
		public virtual RMethod RSubTakeDamage_String_String_Boolean_Boolean
		{
			get
			{
				if(r_RSubTakeDamage_String_String_Boolean_Boolean == null)
				{
					r_RSubTakeDamage_String_String_Boolean_Boolean = new(this, "SubTakeDamage", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_RSubTakeDamage_String_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RSubTakeDamage_String_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void TakeDamage(System.String, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RTakeDamage_String_String_Boolean_Boolean;
		public virtual RMethod RTakeDamage_String_String_Boolean_Boolean
		{
			get
			{
				if(r_RTakeDamage_String_String_Boolean_Boolean == null)
				{
					r_RTakeDamage_String_String_Boolean_Boolean = new(this, "TakeDamage", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_RTakeDamage_String_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RTakeDamage_String_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void AfterDie()
		/// </summary>
		protected RMethod r_RAfterDie;
		public virtual RMethod RAfterDie
		{
			get
			{
				if(r_RAfterDie == null)
				{
					r_RAfterDie = new(this, "AfterDie", 0);
					r_RAfterDie.SetBelong(this.instance);
				}
				return r_RAfterDie;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator OnModleLoadedReset()
		/// </summary>
		protected RMethod r_ROnModleLoadedReset;
		public virtual RMethod ROnModleLoadedReset
		{
			get
			{
				if(r_ROnModleLoadedReset == null)
				{
					r_ROnModleLoadedReset = new(this, "OnModleLoadedReset", 0);
					r_ROnModleLoadedReset.SetBelong(this.instance);
				}
				return r_ROnModleLoadedReset;
			}
		}

		/// <summary>
		/// Void CheckLife()
		/// </summary>
		protected RMethod r_RCheckLife;
		public virtual RMethod RCheckLife
		{
			get
			{
				if(r_RCheckLife == null)
				{
					r_RCheckLife = new(this, "CheckLife", 0);
					r_RCheckLife.SetBelong(this.instance);
				}
				return r_RCheckLife;
			}
		}

		/// <summary>
		/// Void FighterDie(System.Object, #u.#5ab)
		/// </summary>
		protected RMethod r_RFighterDie_Object___0__5ab;
		public virtual RMethod RFighterDie_Object___0__5ab
		{
			get
			{
				if(r_RFighterDie_Object___0__5ab == null)
				{
					r_RFighterDie_Object___0__5ab = new(this, "FighterDie", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#5ab"));
					r_RFighterDie_Object___0__5ab.SetBelong(this.instance);
				}
				return r_RFighterDie_Object___0__5ab;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator DieBodyClear(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RDieBodyClear_ID;
		public virtual RMethod RDieBodyClear_ID
		{
			get
			{
				if(r_RDieBodyClear_ID == null)
				{
					r_RDieBodyClear_ID = new(this, "DieBodyClear", 0, typeof(GameDefineType.ID));
					r_RDieBodyClear_ID.SetBelong(this.instance);
				}
				return r_RDieBodyClear_ID;
			}
		}

		/// <summary>
		/// Void OnDieChange2Soul()
		/// </summary>
		protected RMethod r_ROnDieChange2Soul;
		public virtual RMethod ROnDieChange2Soul
		{
			get
			{
				if(r_ROnDieChange2Soul == null)
				{
					r_ROnDieChange2Soul = new(this, "OnDieChange2Soul", 0);
					r_ROnDieChange2Soul.SetBelong(this.instance);
				}
				return r_ROnDieChange2Soul;
			}
		}

		/// <summary>
		/// Void StartShakeEffect()
		/// </summary>
		protected RMethod r_RStartShakeEffect;
		public virtual RMethod RStartShakeEffect
		{
			get
			{
				if(r_RStartShakeEffect == null)
				{
					r_RStartShakeEffect = new(this, "StartShakeEffect", 0);
					r_RStartShakeEffect.SetBelong(this.instance);
				}
				return r_RStartShakeEffect;
			}
		}

		/// <summary>
		/// Void StopShakeEffect()
		/// </summary>
		protected RMethod r_RStopShakeEffect;
		public virtual RMethod RStopShakeEffect
		{
			get
			{
				if(r_RStopShakeEffect == null)
				{
					r_RStopShakeEffect = new(this, "StopShakeEffect", 0);
					r_RStopShakeEffect.SetBelong(this.instance);
				}
				return r_RStopShakeEffect;
			}
		}

		/// <summary>
		/// Void UpdateShakeEffect()
		/// </summary>
		protected RMethod r_RUpdateShakeEffect;
		public virtual RMethod RUpdateShakeEffect
		{
			get
			{
				if(r_RUpdateShakeEffect == null)
				{
					r_RUpdateShakeEffect = new(this, "UpdateShakeEffect", 0);
					r_RUpdateShakeEffect.SetBelong(this.instance);
				}
				return r_RUpdateShakeEffect;
			}
		}

		/// <summary>
		/// Void OnGUI()
		/// </summary>
		protected RMethod r_ROnGUI;
		public virtual RMethod ROnGUI
		{
			get
			{
				if(r_ROnGUI == null)
				{
					r_ROnGUI = new(this, "OnGUI", 0);
					r_ROnGUI.SetBelong(this.instance);
				}
				return r_ROnGUI;
			}
		}

		/// <summary>
		/// Void UpdateStateInCombat()
		/// </summary>
		protected RMethod r_RUpdateStateInCombat;
		public virtual RMethod RUpdateStateInCombat
		{
			get
			{
				if(r_RUpdateStateInCombat == null)
				{
					r_RUpdateStateInCombat = new(this, "UpdateStateInCombat", 0);
					r_RUpdateStateInCombat.SetBelong(this.instance);
				}
				return r_RUpdateStateInCombat;
			}
		}

		/// <summary>
		/// Void BubbleInCombat(System.String, Single)
		/// </summary>
		protected RMethod r_RBubbleInCombat_String_Single;
		public virtual RMethod RBubbleInCombat_String_Single
		{
			get
			{
				if(r_RBubbleInCombat_String_Single == null)
				{
					r_RBubbleInCombat_String_Single = new(this, "BubbleInCombat", 0, typeof(System.String), typeof(System.Single));
					r_RBubbleInCombat_String_Single.SetBelong(this.instance);
				}
				return r_RBubbleInCombat_String_Single;
			}
		}

		/// <summary>
		/// Void SetFighterSkill(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSetFighterSkill_ID;
		public virtual RMethod RSetFighterSkill_ID
		{
			get
			{
				if(r_RSetFighterSkill_ID == null)
				{
					r_RSetFighterSkill_ID = new(this, "SetFighterSkill", 0, typeof(GameDefineType.ID));
					r_RSetFighterSkill_ID.SetBelong(this.instance);
				}
				return r_RSetFighterSkill_ID;
			}
		}

		/// <summary>
		/// Void SetFighterSkill(GameDefineType.ID, UnityEngine.Texture2D, UnityEngine.Rect)
		/// </summary>
		protected RMethod r_RSetFighterSkill_ID_Texture2D_Rect;
		public virtual RMethod RSetFighterSkill_ID_Texture2D_Rect
		{
			get
			{
				if(r_RSetFighterSkill_ID_Texture2D_Rect == null)
				{
					r_RSetFighterSkill_ID_Texture2D_Rect = new(this, "SetFighterSkill", 0, typeof(GameDefineType.ID), typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect));
					r_RSetFighterSkill_ID_Texture2D_Rect.SetBelong(this.instance);
				}
				return r_RSetFighterSkill_ID_Texture2D_Rect;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator IconFlyStartTimeCountDown(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RIconFlyStartTimeCountDown_GameObject;
		public virtual RMethod RIconFlyStartTimeCountDown_GameObject
		{
			get
			{
				if(r_RIconFlyStartTimeCountDown_GameObject == null)
				{
					r_RIconFlyStartTimeCountDown_GameObject = new(this, "IconFlyStartTimeCountDown", 0, typeof(UnityEngine.GameObject));
					r_RIconFlyStartTimeCountDown_GameObject.SetBelong(this.instance);
				}
				return r_RIconFlyStartTimeCountDown_GameObject;
			}
		}

		/// <summary>
		/// Void SetScoreEffect(Int32)
		/// </summary>
		protected RMethod r_RSetScoreEffect_Int32;
		public virtual RMethod RSetScoreEffect_Int32
		{
			get
			{
				if(r_RSetScoreEffect_Int32 == null)
				{
					r_RSetScoreEffect_Int32 = new(this, "SetScoreEffect", 0, typeof(System.Int32));
					r_RSetScoreEffect_Int32.SetBelong(this.instance);
				}
				return r_RSetScoreEffect_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadSuperSkillScoreEffect(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadSuperSkillScoreEffect_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadSuperSkillScoreEffect_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadSuperSkillScoreEffect_Object_ABLoadedArgs == null)
				{
					r_ROnLoadSuperSkillScoreEffect_Object_ABLoadedArgs = new(this, "OnLoadSuperSkillScoreEffect", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadSuperSkillScoreEffect_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadSuperSkillScoreEffect_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadScoreEffect(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadScoreEffect_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadScoreEffect_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadScoreEffect_Object_ABLoadedArgs == null)
				{
					r_ROnLoadScoreEffect_Object_ABLoadedArgs = new(this, "OnLoadScoreEffect", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadScoreEffect_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadScoreEffect_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadSkillIcon(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadSkillIcon_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadSkillIcon_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadSkillIcon_Object_ABLoadedArgs == null)
				{
					r_ROnLoadSkillIcon_Object_ABLoadedArgs = new(this, "OnLoadSkillIcon", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadSkillIcon_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadSkillIcon_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void SetSuperSkillBuffEffect()
		/// </summary>
		protected RMethod r_RSetSuperSkillBuffEffect;
		public virtual RMethod RSetSuperSkillBuffEffect
		{
			get
			{
				if(r_RSetSuperSkillBuffEffect == null)
				{
					r_RSetSuperSkillBuffEffect = new(this, "SetSuperSkillBuffEffect", 0);
					r_RSetSuperSkillBuffEffect.SetBelong(this.instance);
				}
				return r_RSetSuperSkillBuffEffect;
			}
		}

		/// <summary>
		/// Void OnLoadSuperSkillBuffEffect(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadSuperSkillBuffEffect_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadSuperSkillBuffEffect_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadSuperSkillBuffEffect_Object_ABLoadedArgs == null)
				{
					r_ROnLoadSuperSkillBuffEffect_Object_ABLoadedArgs = new(this, "OnLoadSuperSkillBuffEffect", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadSuperSkillBuffEffect_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadSuperSkillBuffEffect_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void ClearSkillIcon(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RClearSkillIcon_ID;
		public virtual RMethod RClearSkillIcon_ID
		{
			get
			{
				if(r_RClearSkillIcon_ID == null)
				{
					r_RClearSkillIcon_ID = new(this, "ClearSkillIcon", 0, typeof(GameDefineType.ID));
					r_RClearSkillIcon_ID.SetBelong(this.instance);
				}
				return r_RClearSkillIcon_ID;
			}
		}

		/// <summary>
		/// Void ClearSkillIconAndEffect()
		/// </summary>
		protected RMethod r_RClearSkillIconAndEffect;
		public virtual RMethod RClearSkillIconAndEffect
		{
			get
			{
				if(r_RClearSkillIconAndEffect == null)
				{
					r_RClearSkillIconAndEffect = new(this, "ClearSkillIconAndEffect", 0);
					r_RClearSkillIconAndEffect.SetBelong(this.instance);
				}
				return r_RClearSkillIconAndEffect;
			}
		}

		/// <summary>
		/// Void ScreenEffectUpdate()
		/// </summary>
		protected RMethod r_RScreenEffectUpdate;
		public virtual RMethod RScreenEffectUpdate
		{
			get
			{
				if(r_RScreenEffectUpdate == null)
				{
					r_RScreenEffectUpdate = new(this, "ScreenEffectUpdate", 0);
					r_RScreenEffectUpdate.SetBelong(this.instance);
				}
				return r_RScreenEffectUpdate;
			}
		}

		/// <summary>
		/// Void ScreenEffect()
		/// </summary>
		protected RMethod r_RScreenEffect;
		public virtual RMethod RScreenEffect
		{
			get
			{
				if(r_RScreenEffect == null)
				{
					r_RScreenEffect = new(this, "ScreenEffect", 0);
					r_RScreenEffect.SetBelong(this.instance);
				}
				return r_RScreenEffect;
			}
		}

		/// <summary>
		/// Void FlashMaterial()
		/// </summary>
		protected RMethod r_RFlashMaterial;
		public virtual RMethod RFlashMaterial
		{
			get
			{
				if(r_RFlashMaterial == null)
				{
					r_RFlashMaterial = new(this, "FlashMaterial", 0);
					r_RFlashMaterial.SetBelong(this.instance);
				}
				return r_RFlashMaterial;
			}
		}

		/// <summary>
		/// Void UpdateFlashMaterial()
		/// </summary>
		protected RMethod r_RUpdateFlashMaterial;
		public virtual RMethod RUpdateFlashMaterial
		{
			get
			{
				if(r_RUpdateFlashMaterial == null)
				{
					r_RUpdateFlashMaterial = new(this, "UpdateFlashMaterial", 0);
					r_RUpdateFlashMaterial.SetBelong(this.instance);
				}
				return r_RUpdateFlashMaterial;
			}
		}

		/// <summary>
		/// Void UpdateProtect()
		/// </summary>
		protected RMethod r_RUpdateProtect;
		public virtual RMethod RUpdateProtect
		{
			get
			{
				if(r_RUpdateProtect == null)
				{
					r_RUpdateProtect = new(this, "UpdateProtect", 0);
					r_RUpdateProtect.SetBelong(this.instance);
				}
				return r_RUpdateProtect;
			}
		}

		/// <summary>
		/// Void BeingProtect()
		/// </summary>
		protected RMethod r_RBeingProtect;
		public virtual RMethod RBeingProtect
		{
			get
			{
				if(r_RBeingProtect == null)
				{
					r_RBeingProtect = new(this, "BeingProtect", 0);
					r_RBeingProtect.SetBelong(this.instance);
				}
				return r_RBeingProtect;
			}
		}

		/// <summary>
		/// Void SetActionProtect(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RSetActionProtect_Transform;
		public virtual RMethod RSetActionProtect_Transform
		{
			get
			{
				if(r_RSetActionProtect_Transform == null)
				{
					r_RSetActionProtect_Transform = new(this, "SetActionProtect", 0, typeof(UnityEngine.Transform));
					r_RSetActionProtect_Transform.SetBelong(this.instance);
				}
				return r_RSetActionProtect_Transform;
			}
		}

		/// <summary>
		/// Void ProtectFinish()
		/// </summary>
		protected RMethod r_RProtectFinish;
		public virtual RMethod RProtectFinish
		{
			get
			{
				if(r_RProtectFinish == null)
				{
					r_RProtectFinish = new(this, "ProtectFinish", 0);
					r_RProtectFinish.SetBelong(this.instance);
				}
				return r_RProtectFinish;
			}
		}

		/// <summary>
		/// Void PositionRest()
		/// </summary>
		protected RMethod r_RPositionRest;
		public virtual RMethod RPositionRest
		{
			get
			{
				if(r_RPositionRest == null)
				{
					r_RPositionRest = new(this, "PositionRest", 0);
					r_RPositionRest.SetBelong(this.instance);
				}
				return r_RPositionRest;
			}
		}

		/// <summary>
		/// Void ResetProtectTarget()
		/// </summary>
		protected RMethod r_RResetProtectTarget;
		public virtual RMethod RResetProtectTarget
		{
			get
			{
				if(r_RResetProtectTarget == null)
				{
					r_RResetProtectTarget = new(this, "ResetProtectTarget", 0);
					r_RResetProtectTarget.SetBelong(this.instance);
				}
				return r_RResetProtectTarget;
			}
		}

		/// <summary>
		/// Void ResetProtectTargetOnDie()
		/// </summary>
		protected RMethod r_RResetProtectTargetOnDie;
		public virtual RMethod RResetProtectTargetOnDie
		{
			get
			{
				if(r_RResetProtectTargetOnDie == null)
				{
					r_RResetProtectTargetOnDie = new(this, "ResetProtectTargetOnDie", 0);
					r_RResetProtectTargetOnDie.SetBelong(this.instance);
				}
				return r_RResetProtectTargetOnDie;
			}
		}

		/// <summary>
		/// Void SetDefend(Boolean)
		/// </summary>
		protected RMethod r_RSetDefend_Boolean;
		public virtual RMethod RSetDefend_Boolean
		{
			get
			{
				if(r_RSetDefend_Boolean == null)
				{
					r_RSetDefend_Boolean = new(this, "SetDefend", 0, typeof(System.Boolean));
					r_RSetDefend_Boolean.SetBelong(this.instance);
				}
				return r_RSetDefend_Boolean;
			}
		}

		/// <summary>
		/// Void DelFighter()
		/// </summary>
		protected RMethod r_RDelFighter;
		public virtual RMethod RDelFighter
		{
			get
			{
				if(r_RDelFighter == null)
				{
					r_RDelFighter = new(this, "DelFighter", 0);
					r_RDelFighter.SetBelong(this.instance);
				}
				return r_RDelFighter;
			}
		}

		/// <summary>
		/// Void UnRegisterFighter()
		/// </summary>
		protected RMethod r_RUnRegisterFighter;
		public virtual RMethod RUnRegisterFighter
		{
			get
			{
				if(r_RUnRegisterFighter == null)
				{
					r_RUnRegisterFighter = new(this, "UnRegisterFighter", 0);
					r_RUnRegisterFighter.SetBelong(this.instance);
				}
				return r_RUnRegisterFighter;
			}
		}

		/// <summary>
		/// Void StartEscape(Boolean, CCommmandEscape)
		/// </summary>
		protected RMethod r_RStartEscape_Boolean_CCommmandEscape;
		public virtual RMethod RStartEscape_Boolean_CCommmandEscape
		{
			get
			{
				if(r_RStartEscape_Boolean_CCommmandEscape == null)
				{
					r_RStartEscape_Boolean_CCommmandEscape = new(this, "StartEscape", 0, typeof(System.Boolean),  ReleactionUtils.GetType("CCommmandEscape"));
					r_RStartEscape_Boolean_CCommmandEscape.SetBelong(this.instance);
				}
				return r_RStartEscape_Boolean_CCommmandEscape;
			}
		}

		/// <summary>
		/// Void EscapeSuccess()
		/// </summary>
		protected RMethod r_REscapeSuccess;
		public virtual RMethod REscapeSuccess
		{
			get
			{
				if(r_REscapeSuccess == null)
				{
					r_REscapeSuccess = new(this, "EscapeSuccess", 0);
					r_REscapeSuccess.SetBelong(this.instance);
				}
				return r_REscapeSuccess;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator EscapeFail()
		/// </summary>
		protected RMethod r_REscapeFail;
		public virtual RMethod REscapeFail
		{
			get
			{
				if(r_REscapeFail == null)
				{
					r_REscapeFail = new(this, "EscapeFail", 0);
					r_REscapeFail.SetBelong(this.instance);
				}
				return r_REscapeFail;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator EscapingFinish(CCommmandEscape)
		/// </summary>
		protected RMethod r_REscapingFinish_CCommmandEscape;
		public virtual RMethod REscapingFinish_CCommmandEscape
		{
			get
			{
				if(r_REscapingFinish_CCommmandEscape == null)
				{
					r_REscapingFinish_CCommmandEscape = new(this, "EscapingFinish", 0,  ReleactionUtils.GetType("CCommmandEscape"));
					r_REscapingFinish_CCommmandEscape.SetBelong(this.instance);
				}
				return r_REscapingFinish_CCommmandEscape;
			}
		}

		/// <summary>
		/// Void RoundFinish()
		/// </summary>
		protected RMethod r_RRoundFinish;
		public virtual RMethod RRoundFinish
		{
			get
			{
				if(r_RRoundFinish == null)
				{
					r_RRoundFinish = new(this, "RoundFinish", 0);
					r_RRoundFinish.SetBelong(this.instance);
				}
				return r_RRoundFinish;
			}
		}

		/// <summary>
		/// Void SetActionFinished(Boolean)
		/// </summary>
		protected RMethod r_RSetActionFinished_Boolean;
		public virtual RMethod RSetActionFinished_Boolean
		{
			get
			{
				if(r_RSetActionFinished_Boolean == null)
				{
					r_RSetActionFinished_Boolean = new(this, "SetActionFinished", 0, typeof(System.Boolean));
					r_RSetActionFinished_Boolean.SetBelong(this.instance);
				}
				return r_RSetActionFinished_Boolean;
			}
		}

		/// <summary>
		/// Boolean IsActionFinished()
		/// </summary>
		protected RMethod r_RIsActionFinished;
		public virtual RMethod RIsActionFinished
		{
			get
			{
				if(r_RIsActionFinished == null)
				{
					r_RIsActionFinished = new(this, "IsActionFinished", 0);
					r_RIsActionFinished.SetBelong(this.instance);
				}
				return r_RIsActionFinished;
			}
		}

		/// <summary>
		/// Void SetCurrentStatus(CombatStatus)
		/// </summary>
		protected RMethod r_RSetCurrentStatus_CombatStatus;
		public virtual RMethod RSetCurrentStatus_CombatStatus
		{
			get
			{
				if(r_RSetCurrentStatus_CombatStatus == null)
				{
					r_RSetCurrentStatus_CombatStatus = new(this, "SetCurrentStatus", 0,  ReleactionUtils.GetType("CombatStatus"));
					r_RSetCurrentStatus_CombatStatus.SetBelong(this.instance);
				}
				return r_RSetCurrentStatus_CombatStatus;
			}
		}

		/// <summary>
		/// Void SetMemberFinish()
		/// </summary>
		protected RMethod r_RSetMemberFinish;
		public virtual RMethod RSetMemberFinish
		{
			get
			{
				if(r_RSetMemberFinish == null)
				{
					r_RSetMemberFinish = new(this, "SetMemberFinish", 0);
					r_RSetMemberFinish.SetBelong(this.instance);
				}
				return r_RSetMemberFinish;
			}
		}

		/// <summary>
		/// Void SetCommandTarget(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RSetCommandTarget_Transform;
		public virtual RMethod RSetCommandTarget_Transform
		{
			get
			{
				if(r_RSetCommandTarget_Transform == null)
				{
					r_RSetCommandTarget_Transform = new(this, "SetCommandTarget", 0, typeof(UnityEngine.Transform));
					r_RSetCommandTarget_Transform.SetBelong(this.instance);
				}
				return r_RSetCommandTarget_Transform;
			}
		}

		/// <summary>
		/// Void SetCombatCommand(CombatCommand)
		/// </summary>
		protected RMethod r_RSetCombatCommand_CombatCommand;
		public virtual RMethod RSetCombatCommand_CombatCommand
		{
			get
			{
				if(r_RSetCombatCommand_CombatCommand == null)
				{
					r_RSetCombatCommand_CombatCommand = new(this, "SetCombatCommand", 0,  ReleactionUtils.GetType("CombatCommand"));
					r_RSetCombatCommand_CombatCommand.SetBelong(this.instance);
				}
				return r_RSetCombatCommand_CombatCommand;
			}
		}

		/// <summary>
		/// Void SetCombatCMDex(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSetCombatCMDex_ID;
		public virtual RMethod RSetCombatCMDex_ID
		{
			get
			{
				if(r_RSetCombatCMDex_ID == null)
				{
					r_RSetCombatCMDex_ID = new(this, "SetCombatCMDex", 0, typeof(GameDefineType.ID));
					r_RSetCombatCMDex_ID.SetBelong(this.instance);
				}
				return r_RSetCombatCMDex_ID;
			}
		}

		/// <summary>
		/// CombatCommand GetCurrentCommand()
		/// </summary>
		protected RMethod r_RGetCurrentCommand;
		public virtual RMethod RGetCurrentCommand
		{
			get
			{
				if(r_RGetCurrentCommand == null)
				{
					r_RGetCurrentCommand = new(this, "GetCurrentCommand", 0);
					r_RGetCurrentCommand.SetBelong(this.instance);
				}
				return r_RGetCurrentCommand;
			}
		}

		/// <summary>
		/// Void ClearPlayerCommand()
		/// </summary>
		protected RMethod r_RClearPlayerCommand;
		public virtual RMethod RClearPlayerCommand
		{
			get
			{
				if(r_RClearPlayerCommand == null)
				{
					r_RClearPlayerCommand = new(this, "ClearPlayerCommand", 0);
					r_RClearPlayerCommand.SetBelong(this.instance);
				}
				return r_RClearPlayerCommand;
			}
		}

		/// <summary>
		/// Void ChooseCombatCommand(CombatCommand)
		/// </summary>
		protected RMethod r_RChooseCombatCommand_CombatCommand;
		public virtual RMethod RChooseCombatCommand_CombatCommand
		{
			get
			{
				if(r_RChooseCombatCommand_CombatCommand == null)
				{
					r_RChooseCombatCommand_CombatCommand = new(this, "ChooseCombatCommand", 0,  ReleactionUtils.GetType("CombatCommand"));
					r_RChooseCombatCommand_CombatCommand.SetBelong(this.instance);
				}
				return r_RChooseCombatCommand_CombatCommand;
			}
		}

		/// <summary>
		/// Boolean IsCommandSelectEnd()
		/// </summary>
		protected RMethod r_RIsCommandSelectEnd;
		public virtual RMethod RIsCommandSelectEnd
		{
			get
			{
				if(r_RIsCommandSelectEnd == null)
				{
					r_RIsCommandSelectEnd = new(this, "IsCommandSelectEnd", 0);
					r_RIsCommandSelectEnd.SetBelong(this.instance);
				}
				return r_RIsCommandSelectEnd;
			}
		}

		/// <summary>
		/// Void SetCommandSelectEnd(Boolean)
		/// </summary>
		protected RMethod r_RSetCommandSelectEnd_Boolean;
		public virtual RMethod RSetCommandSelectEnd_Boolean
		{
			get
			{
				if(r_RSetCommandSelectEnd_Boolean == null)
				{
					r_RSetCommandSelectEnd_Boolean = new(this, "SetCommandSelectEnd", 0, typeof(System.Boolean));
					r_RSetCommandSelectEnd_Boolean.SetBelong(this.instance);
				}
				return r_RSetCommandSelectEnd_Boolean;
			}
		}

		/// <summary>
		/// Void SetSelectable(Boolean)
		/// </summary>
		protected RMethod r_RSetSelectable_Boolean;
		public virtual RMethod RSetSelectable_Boolean
		{
			get
			{
				if(r_RSetSelectable_Boolean == null)
				{
					r_RSetSelectable_Boolean = new(this, "SetSelectable", 0, typeof(System.Boolean));
					r_RSetSelectable_Boolean.SetBelong(this.instance);
				}
				return r_RSetSelectable_Boolean;
			}
		}

		/// <summary>
		/// Void _OnMouseOverSetection()
		/// </summary>
		protected RMethod r_R_OnMouseOverSetection;
		public virtual RMethod R_OnMouseOverSetection
		{
			get
			{
				if(r_R_OnMouseOverSetection == null)
				{
					r_R_OnMouseOverSetection = new(this, "_OnMouseOverSetection", 0);
					r_R_OnMouseOverSetection.SetBelong(this.instance);
				}
				return r_R_OnMouseOverSetection;
			}
		}

		/// <summary>
		/// Void HighLightName(Boolean)
		/// </summary>
		protected RMethod r_RHighLightName_Boolean;
		public virtual RMethod RHighLightName_Boolean
		{
			get
			{
				if(r_RHighLightName_Boolean == null)
				{
					r_RHighLightName_Boolean = new(this, "HighLightName", 0, typeof(System.Boolean));
					r_RHighLightName_Boolean.SetBelong(this.instance);
				}
				return r_RHighLightName_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject HpFlash()
		/// </summary>
		protected RMethod r_RHpFlash;
		public virtual RMethod RHpFlash
		{
			get
			{
				if(r_RHpFlash == null)
				{
					r_RHpFlash = new(this, "HpFlash", 0);
					r_RHpFlash.SetBelong(this.instance);
				}
				return r_RHpFlash;
			}
		}

		/// <summary>
		/// Void StopHpFlash()
		/// </summary>
		protected RMethod r_RStopHpFlash;
		public virtual RMethod RStopHpFlash
		{
			get
			{
				if(r_RStopHpFlash == null)
				{
					r_RStopHpFlash = new(this, "StopHpFlash", 0);
					r_RStopHpFlash.SetBelong(this.instance);
				}
				return r_RStopHpFlash;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator HpFlashUpdate()
		/// </summary>
		protected RMethod r_RHpFlashUpdate;
		public virtual RMethod RHpFlashUpdate
		{
			get
			{
				if(r_RHpFlashUpdate == null)
				{
					r_RHpFlashUpdate = new(this, "HpFlashUpdate", 0);
					r_RHpFlashUpdate.SetBelong(this.instance);
				}
				return r_RHpFlashUpdate;
			}
		}

		/// <summary>
		/// Boolean IsSelectable()
		/// </summary>
		protected RMethod r_RIsSelectable;
		public virtual RMethod RIsSelectable
		{
			get
			{
				if(r_RIsSelectable == null)
				{
					r_RIsSelectable = new(this, "IsSelectable", 0);
					r_RIsSelectable.SetBelong(this.instance);
				}
				return r_RIsSelectable;
			}
		}

		/// <summary>
		/// Boolean IsEnemy()
		/// </summary>
		protected RMethod r_RIsEnemy;
		public virtual RMethod RIsEnemy
		{
			get
			{
				if(r_RIsEnemy == null)
				{
					r_RIsEnemy = new(this, "IsEnemy", 0);
					r_RIsEnemy.SetBelong(this.instance);
				}
				return r_RIsEnemy;
			}
		}

		/// <summary>
		/// Void PlayCameraAnimation(System.String)
		/// </summary>
		protected RMethod r_RPlayCameraAnimation_String;
		public virtual RMethod RPlayCameraAnimation_String
		{
			get
			{
				if(r_RPlayCameraAnimation_String == null)
				{
					r_RPlayCameraAnimation_String = new(this, "PlayCameraAnimation", 0, typeof(System.String));
					r_RPlayCameraAnimation_String.SetBelong(this.instance);
				}
				return r_RPlayCameraAnimation_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator NormalEffect(BattleEffectBase)
		/// </summary>
		protected RMethod r_RNormalEffect_BattleEffectBase;
		public virtual RMethod RNormalEffect_BattleEffectBase
		{
			get
			{
				if(r_RNormalEffect_BattleEffectBase == null)
				{
					r_RNormalEffect_BattleEffectBase = new(this, "NormalEffect", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RNormalEffect_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RNormalEffect_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator SoundEffect(BattleEffectBase)
		/// </summary>
		protected RMethod r_RSoundEffect_BattleEffectBase;
		public virtual RMethod RSoundEffect_BattleEffectBase
		{
			get
			{
				if(r_RSoundEffect_BattleEffectBase == null)
				{
					r_RSoundEffect_BattleEffectBase = new(this, "SoundEffect", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RSoundEffect_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RSoundEffect_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.String GetBoneNameFromEffectName(System.String)
		/// </summary>
		protected static RMethod r_RGetBoneNameFromEffectName_String;
		public static RMethod RGetBoneNameFromEffectName_String
		{
			get
			{
				if(r_RGetBoneNameFromEffectName_String == null)
				{
					r_RGetBoneNameFromEffectName_String = new( ReleactionUtils.GetType("CombatController"), "GetBoneNameFromEffectName", 0, typeof(System.String));
					r_RGetBoneNameFromEffectName_String.SetBelong(null);
				}
				return r_RGetBoneNameFromEffectName_String;
			}
		}

		/// <summary>
		/// System.String GetBoneNameFromEffectName(Int32, System.String)
		/// </summary>
		protected static RMethod r_RGetBoneNameFromEffectName_Int32_String;
		public static RMethod RGetBoneNameFromEffectName_Int32_String
		{
			get
			{
				if(r_RGetBoneNameFromEffectName_Int32_String == null)
				{
					r_RGetBoneNameFromEffectName_Int32_String = new( ReleactionUtils.GetType("CombatController"), "GetBoneNameFromEffectName", 0, typeof(System.Int32), typeof(System.String));
					r_RGetBoneNameFromEffectName_Int32_String.SetBelong(null);
				}
				return r_RGetBoneNameFromEffectName_Int32_String;
			}
		}

		/// <summary>
		/// UnityEngine.Transform GetBone(UnityEngine.Transform, System.String)
		/// </summary>
		protected static RMethod r_RGetBone_Transform_String;
		public static RMethod RGetBone_Transform_String
		{
			get
			{
				if(r_RGetBone_Transform_String == null)
				{
					r_RGetBone_Transform_String = new( ReleactionUtils.GetType("CombatController"), "GetBone", 0, typeof(UnityEngine.Transform), typeof(System.String));
					r_RGetBone_Transform_String.SetBelong(null);
				}
				return r_RGetBone_Transform_String;
			}
		}

		/// <summary>
		/// UnityEngine.Transform TryGetBone(UnityEngine.Transform, System.String)
		/// </summary>
		protected static RMethod r_RTryGetBone_Transform_String;
		public static RMethod RTryGetBone_Transform_String
		{
			get
			{
				if(r_RTryGetBone_Transform_String == null)
				{
					r_RTryGetBone_Transform_String = new( ReleactionUtils.GetType("CombatController"), "TryGetBone", 0, typeof(UnityEngine.Transform), typeof(System.String));
					r_RTryGetBone_Transform_String.SetBelong(null);
				}
				return r_RTryGetBone_Transform_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator SendBullet(BattleEffectBase)
		/// </summary>
		protected RMethod r_RSendBullet_BattleEffectBase;
		public virtual RMethod RSendBullet_BattleEffectBase
		{
			get
			{
				if(r_RSendBullet_BattleEffectBase == null)
				{
					r_RSendBullet_BattleEffectBase = new(this, "SendBullet", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RSendBullet_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RSendBullet_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator CameraShake(BattleEffectBase)
		/// </summary>
		protected RMethod r_RCameraShake_BattleEffectBase;
		public virtual RMethod RCameraShake_BattleEffectBase
		{
			get
			{
				if(r_RCameraShake_BattleEffectBase == null)
				{
					r_RCameraShake_BattleEffectBase = new(this, "CameraShake", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RCameraShake_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RCameraShake_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator EnemyTakeDamage(BattleEffectBase)
		/// </summary>
		protected RMethod r_REnemyTakeDamage_BattleEffectBase;
		public virtual RMethod REnemyTakeDamage_BattleEffectBase
		{
			get
			{
				if(r_REnemyTakeDamage_BattleEffectBase == null)
				{
					r_REnemyTakeDamage_BattleEffectBase = new(this, "EnemyTakeDamage", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_REnemyTakeDamage_BattleEffectBase.SetBelong(this.instance);
				}
				return r_REnemyTakeDamage_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator AniPause(BattleEffectBase)
		/// </summary>
		protected RMethod r_RAniPause_BattleEffectBase;
		public virtual RMethod RAniPause_BattleEffectBase
		{
			get
			{
				if(r_RAniPause_BattleEffectBase == null)
				{
					r_RAniPause_BattleEffectBase = new(this, "AniPause", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RAniPause_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RAniPause_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator BodyShake(BattleEffectBase)
		/// </summary>
		protected RMethod r_RBodyShake_BattleEffectBase;
		public virtual RMethod RBodyShake_BattleEffectBase
		{
			get
			{
				if(r_RBodyShake_BattleEffectBase == null)
				{
					r_RBodyShake_BattleEffectBase = new(this, "BodyShake", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RBodyShake_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RBodyShake_BattleEffectBase;
			}
		}

		/// <summary>
		/// Void HideBodyExc(Boolean)
		/// </summary>
		protected RMethod r_RHideBodyExc_Boolean;
		public virtual RMethod RHideBodyExc_Boolean
		{
			get
			{
				if(r_RHideBodyExc_Boolean == null)
				{
					r_RHideBodyExc_Boolean = new(this, "HideBodyExc", 0, typeof(System.Boolean));
					r_RHideBodyExc_Boolean.SetBelong(this.instance);
				}
				return r_RHideBodyExc_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator HideBody(BattleEffectBase)
		/// </summary>
		protected RMethod r_RHideBody_BattleEffectBase;
		public virtual RMethod RHideBody_BattleEffectBase
		{
			get
			{
				if(r_RHideBody_BattleEffectBase == null)
				{
					r_RHideBody_BattleEffectBase = new(this, "HideBody", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RHideBody_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RHideBody_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator HideBloodUIEffect(BattleEffectBase)
		/// </summary>
		protected RMethod r_RHideBloodUIEffect_BattleEffectBase;
		public virtual RMethod RHideBloodUIEffect_BattleEffectBase
		{
			get
			{
				if(r_RHideBloodUIEffect_BattleEffectBase == null)
				{
					r_RHideBloodUIEffect_BattleEffectBase = new(this, "HideBloodUIEffect", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RHideBloodUIEffect_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RHideBloodUIEffect_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ShowInjured(BattleEffectBase)
		/// </summary>
		protected RMethod r_RShowInjured_BattleEffectBase;
		public virtual RMethod RShowInjured_BattleEffectBase
		{
			get
			{
				if(r_RShowInjured_BattleEffectBase == null)
				{
					r_RShowInjured_BattleEffectBase = new(this, "ShowInjured", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RShowInjured_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RShowInjured_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ScreenEffect(BattleEffectBase)
		/// </summary>
		protected RMethod r_RScreenEffect_BattleEffectBase;
		public virtual RMethod RScreenEffect_BattleEffectBase
		{
			get
			{
				if(r_RScreenEffect_BattleEffectBase == null)
				{
					r_RScreenEffect_BattleEffectBase = new(this, "ScreenEffect", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RScreenEffect_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RScreenEffect_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator TimeScale(BattleEffectBase)
		/// </summary>
		protected RMethod r_RTimeScale_BattleEffectBase;
		public virtual RMethod RTimeScale_BattleEffectBase
		{
			get
			{
				if(r_RTimeScale_BattleEffectBase == null)
				{
					r_RTimeScale_BattleEffectBase = new(this, "TimeScale", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RTimeScale_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RTimeScale_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator EffectInCamera(BattleEffectBase)
		/// </summary>
		protected RMethod r_REffectInCamera_BattleEffectBase;
		public virtual RMethod REffectInCamera_BattleEffectBase
		{
			get
			{
				if(r_REffectInCamera_BattleEffectBase == null)
				{
					r_REffectInCamera_BattleEffectBase = new(this, "EffectInCamera", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_REffectInCamera_BattleEffectBase.SetBelong(this.instance);
				}
				return r_REffectInCamera_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator SceneInBlack(BattleEffectBase)
		/// </summary>
		protected RMethod r_RSceneInBlack_BattleEffectBase;
		public virtual RMethod RSceneInBlack_BattleEffectBase
		{
			get
			{
				if(r_RSceneInBlack_BattleEffectBase == null)
				{
					r_RSceneInBlack_BattleEffectBase = new(this, "SceneInBlack", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RSceneInBlack_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RSceneInBlack_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator BodyMove(BattleEffectBase)
		/// </summary>
		protected RMethod r_RBodyMove_BattleEffectBase;
		public virtual RMethod RBodyMove_BattleEffectBase
		{
			get
			{
				if(r_RBodyMove_BattleEffectBase == null)
				{
					r_RBodyMove_BattleEffectBase = new(this, "BodyMove", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RBodyMove_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RBodyMove_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator LightOff(BattleEffectBase)
		/// </summary>
		protected RMethod r_RLightOff_BattleEffectBase;
		public virtual RMethod RLightOff_BattleEffectBase
		{
			get
			{
				if(r_RLightOff_BattleEffectBase == null)
				{
					r_RLightOff_BattleEffectBase = new(this, "LightOff", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RLightOff_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RLightOff_BattleEffectBase;
			}
		}

		/// <summary>
		/// Void DodgeEffect()
		/// </summary>
		protected RMethod r_RDodgeEffect;
		public virtual RMethod RDodgeEffect
		{
			get
			{
				if(r_RDodgeEffect == null)
				{
					r_RDodgeEffect = new(this, "DodgeEffect", 0);
					r_RDodgeEffect.SetBelong(this.instance);
				}
				return r_RDodgeEffect;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator _DodgeEffect()
		/// </summary>
		protected RMethod r_R_DodgeEffect;
		public virtual RMethod R_DodgeEffect
		{
			get
			{
				if(r_R_DodgeEffect == null)
				{
					r_R_DodgeEffect = new(this, "_DodgeEffect", 0);
					r_R_DodgeEffect.SetBelong(this.instance);
				}
				return r_R_DodgeEffect;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator DefendEffect()
		/// </summary>
		protected RMethod r_RDefendEffect;
		public virtual RMethod RDefendEffect
		{
			get
			{
				if(r_RDefendEffect == null)
				{
					r_RDefendEffect = new(this, "DefendEffect", 0);
					r_RDefendEffect.SetBelong(this.instance);
				}
				return r_RDefendEffect;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator SceneAnimation(BattleEffectBase)
		/// </summary>
		protected RMethod r_RSceneAnimation_BattleEffectBase;
		public virtual RMethod RSceneAnimation_BattleEffectBase
		{
			get
			{
				if(r_RSceneAnimation_BattleEffectBase == null)
				{
					r_RSceneAnimation_BattleEffectBase = new(this, "SceneAnimation", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RSceneAnimation_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RSceneAnimation_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator SceneEffect(BattleEffectBase)
		/// </summary>
		protected RMethod r_RSceneEffect_BattleEffectBase;
		public virtual RMethod RSceneEffect_BattleEffectBase
		{
			get
			{
				if(r_RSceneEffect_BattleEffectBase == null)
				{
					r_RSceneEffect_BattleEffectBase = new(this, "SceneEffect", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RSceneEffect_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RSceneEffect_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator CameraMove(BattleEffectBase)
		/// </summary>
		protected RMethod r_RCameraMove_BattleEffectBase;
		public virtual RMethod RCameraMove_BattleEffectBase
		{
			get
			{
				if(r_RCameraMove_BattleEffectBase == null)
				{
					r_RCameraMove_BattleEffectBase = new(this, "CameraMove", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RCameraMove_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RCameraMove_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator BodyMoveAni(BattleEffectBase)
		/// </summary>
		protected RMethod r_RBodyMoveAni_BattleEffectBase;
		public virtual RMethod RBodyMoveAni_BattleEffectBase
		{
			get
			{
				if(r_RBodyMoveAni_BattleEffectBase == null)
				{
					r_RBodyMoveAni_BattleEffectBase = new(this, "BodyMoveAni", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RBodyMoveAni_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RBodyMoveAni_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator PetAttack(BattleEffectBase)
		/// </summary>
		protected RMethod r_RPetAttack_BattleEffectBase;
		public virtual RMethod RPetAttack_BattleEffectBase
		{
			get
			{
				if(r_RPetAttack_BattleEffectBase == null)
				{
					r_RPetAttack_BattleEffectBase = new(this, "PetAttack", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RPetAttack_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RPetAttack_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator SwitchCombatMusic(BattleEffectBase)
		/// </summary>
		protected RMethod r_RSwitchCombatMusic_BattleEffectBase;
		public virtual RMethod RSwitchCombatMusic_BattleEffectBase
		{
			get
			{
				if(r_RSwitchCombatMusic_BattleEffectBase == null)
				{
					r_RSwitchCombatMusic_BattleEffectBase = new(this, "SwitchCombatMusic", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RSwitchCombatMusic_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RSwitchCombatMusic_BattleEffectBase;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ColorRevert(BattleEffectBase)
		/// </summary>
		protected RMethod r_RColorRevert_BattleEffectBase;
		public virtual RMethod RColorRevert_BattleEffectBase
		{
			get
			{
				if(r_RColorRevert_BattleEffectBase == null)
				{
					r_RColorRevert_BattleEffectBase = new(this, "ColorRevert", 0,  ReleactionUtils.GetType("BattleEffectBase"));
					r_RColorRevert_BattleEffectBase.SetBelong(this.instance);
				}
				return r_RColorRevert_BattleEffectBase;
			}
		}

		/// <summary>
		/// Void SetFollowStuff(CombatController, UnityEngine.GameObject, UInt32)
		/// </summary>
		protected RMethod r_RSetFollowStuff_CombatController_GameObject_UInt32;
		public virtual RMethod RSetFollowStuff_CombatController_GameObject_UInt32
		{
			get
			{
				if(r_RSetFollowStuff_CombatController_GameObject_UInt32 == null)
				{
					r_RSetFollowStuff_CombatController_GameObject_UInt32 = new(this, "SetFollowStuff", 0,  ReleactionUtils.GetType("CombatController"), typeof(UnityEngine.GameObject), typeof(System.UInt32));
					r_RSetFollowStuff_CombatController_GameObject_UInt32.SetBelong(this.instance);
				}
				return r_RSetFollowStuff_CombatController_GameObject_UInt32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator CheckModelDownload()
		/// </summary>
		protected RMethod r_RCheckModelDownload;
		public virtual RMethod RCheckModelDownload
		{
			get
			{
				if(r_RCheckModelDownload == null)
				{
					r_RCheckModelDownload = new(this, "CheckModelDownload", 0);
					r_RCheckModelDownload.SetBelong(this.instance);
				}
				return r_RCheckModelDownload;
			}
		}

		/// <summary>
		/// Void InitFollowingStuff()
		/// </summary>
		protected RMethod r_RInitFollowingStuff;
		public virtual RMethod RInitFollowingStuff
		{
			get
			{
				if(r_RInitFollowingStuff == null)
				{
					r_RInitFollowingStuff = new(this, "InitFollowingStuff", 0);
					r_RInitFollowingStuff.SetBelong(this.instance);
				}
				return r_RInitFollowingStuff;
			}
		}

		/// <summary>
		/// Void AddActionList2Pet(System.Collections.Generic.List`1[BattleAction])
		/// </summary>
		protected RMethod r_RAddActionList2Pet_List_d_BattleAction_p_;
		public virtual RMethod RAddActionList2Pet_List_d_BattleAction_p_
		{
			get
			{
				if(r_RAddActionList2Pet_List_d_BattleAction_p_ == null)
				{
					r_RAddActionList2Pet_List_d_BattleAction_p_ = new(this, "AddActionList2Pet", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("BattleAction")));
					r_RAddActionList2Pet_List_d_BattleAction_p_.SetBelong(this.instance);
				}
				return r_RAddActionList2Pet_List_d_BattleAction_p_;
			}
		}

		/// <summary>
		/// Void PetInjury()
		/// </summary>
		protected RMethod r_RPetInjury;
		public virtual RMethod RPetInjury
		{
			get
			{
				if(r_RPetInjury == null)
				{
					r_RPetInjury = new(this, "PetInjury", 0);
					r_RPetInjury.SetBelong(this.instance);
				}
				return r_RPetInjury;
			}
		}

		/// <summary>
		/// Void OnDestroy()
		/// </summary>
		protected RMethod r_ROnDestroy;
		public virtual RMethod ROnDestroy
		{
			get
			{
				if(r_ROnDestroy == null)
				{
					r_ROnDestroy = new(this, "OnDestroy", 0);
					r_ROnDestroy.SetBelong(this.instance);
				}
				return r_ROnDestroy;
			}
		}

		/// <summary>
		/// Boolean IsInvoking()
		/// </summary>
		protected RMethod r_RIsInvoking;
		public virtual RMethod RIsInvoking
		{
			get
			{
				if(r_RIsInvoking == null)
				{
					r_RIsInvoking = new(this, "IsInvoking", 0);
					r_RIsInvoking.SetBelong(this.instance);
				}
				return r_RIsInvoking;
			}
		}

		/// <summary>
		/// Void CancelInvoke()
		/// </summary>
		protected RMethod r_RCancelInvoke;
		public virtual RMethod RCancelInvoke
		{
			get
			{
				if(r_RCancelInvoke == null)
				{
					r_RCancelInvoke = new(this, "CancelInvoke", 0);
					r_RCancelInvoke.SetBelong(this.instance);
				}
				return r_RCancelInvoke;
			}
		}

		/// <summary>
		/// Void Invoke(System.String, Single)
		/// </summary>
		protected RMethod r_RInvoke_String_Single;
		public virtual RMethod RInvoke_String_Single
		{
			get
			{
				if(r_RInvoke_String_Single == null)
				{
					r_RInvoke_String_Single = new(this, "Invoke", 0, typeof(System.String), typeof(System.Single));
					r_RInvoke_String_Single.SetBelong(this.instance);
				}
				return r_RInvoke_String_Single;
			}
		}

		/// <summary>
		/// Void InvokeRepeating(System.String, Single, Single)
		/// </summary>
		protected RMethod r_RInvokeRepeating_String_Single_Single;
		public virtual RMethod RInvokeRepeating_String_Single_Single
		{
			get
			{
				if(r_RInvokeRepeating_String_Single_Single == null)
				{
					r_RInvokeRepeating_String_Single_Single = new(this, "InvokeRepeating", 0, typeof(System.String), typeof(System.Single), typeof(System.Single));
					r_RInvokeRepeating_String_Single_Single.SetBelong(this.instance);
				}
				return r_RInvokeRepeating_String_Single_Single;
			}
		}

		/// <summary>
		/// Void CancelInvoke(System.String)
		/// </summary>
		protected RMethod r_RCancelInvoke_String;
		public virtual RMethod RCancelInvoke_String
		{
			get
			{
				if(r_RCancelInvoke_String == null)
				{
					r_RCancelInvoke_String = new(this, "CancelInvoke", 0, typeof(System.String));
					r_RCancelInvoke_String.SetBelong(this.instance);
				}
				return r_RCancelInvoke_String;
			}
		}

		/// <summary>
		/// Boolean IsInvoking(System.String)
		/// </summary>
		protected RMethod r_RIsInvoking_String;
		public virtual RMethod RIsInvoking_String
		{
			get
			{
				if(r_RIsInvoking_String == null)
				{
					r_RIsInvoking_String = new(this, "IsInvoking", 0, typeof(System.String));
					r_RIsInvoking_String.SetBelong(this.instance);
				}
				return r_RIsInvoking_String;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.String)
		/// </summary>
		protected RMethod r_RStartCoroutine_String;
		public virtual RMethod RStartCoroutine_String
		{
			get
			{
				if(r_RStartCoroutine_String == null)
				{
					r_RStartCoroutine_String = new(this, "StartCoroutine", 0, typeof(System.String));
					r_RStartCoroutine_String.SetBelong(this.instance);
				}
				return r_RStartCoroutine_String;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.String, System.Object)
		/// </summary>
		protected RMethod r_RStartCoroutine_String_Object;
		public virtual RMethod RStartCoroutine_String_Object
		{
			get
			{
				if(r_RStartCoroutine_String_Object == null)
				{
					r_RStartCoroutine_String_Object = new(this, "StartCoroutine", 0, typeof(System.String), typeof(System.Object));
					r_RStartCoroutine_String_Object.SetBelong(this.instance);
				}
				return r_RStartCoroutine_String_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStartCoroutine_IEnumerator;
		public virtual RMethod RStartCoroutine_IEnumerator
		{
			get
			{
				if(r_RStartCoroutine_IEnumerator == null)
				{
					r_RStartCoroutine_IEnumerator = new(this, "StartCoroutine", 0, typeof(System.Collections.IEnumerator));
					r_RStartCoroutine_IEnumerator.SetBelong(this.instance);
				}
				return r_RStartCoroutine_IEnumerator;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStartCoroutine_Auto_IEnumerator;
		public virtual RMethod RStartCoroutine_Auto_IEnumerator
		{
			get
			{
				if(r_RStartCoroutine_Auto_IEnumerator == null)
				{
					r_RStartCoroutine_Auto_IEnumerator = new(this, "StartCoroutine_Auto", 0, typeof(System.Collections.IEnumerator));
					r_RStartCoroutine_Auto_IEnumerator.SetBelong(this.instance);
				}
				return r_RStartCoroutine_Auto_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutine(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStopCoroutine_IEnumerator;
		public virtual RMethod RStopCoroutine_IEnumerator
		{
			get
			{
				if(r_RStopCoroutine_IEnumerator == null)
				{
					r_RStopCoroutine_IEnumerator = new(this, "StopCoroutine", 0, typeof(System.Collections.IEnumerator));
					r_RStopCoroutine_IEnumerator.SetBelong(this.instance);
				}
				return r_RStopCoroutine_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutine(UnityEngine.Coroutine)
		/// </summary>
		protected RMethod r_RStopCoroutine_Coroutine;
		public virtual RMethod RStopCoroutine_Coroutine
		{
			get
			{
				if(r_RStopCoroutine_Coroutine == null)
				{
					r_RStopCoroutine_Coroutine = new(this, "StopCoroutine", 0, typeof(UnityEngine.Coroutine));
					r_RStopCoroutine_Coroutine.SetBelong(this.instance);
				}
				return r_RStopCoroutine_Coroutine;
			}
		}

		/// <summary>
		/// Void StopCoroutine(System.String)
		/// </summary>
		protected RMethod r_RStopCoroutine_String;
		public virtual RMethod RStopCoroutine_String
		{
			get
			{
				if(r_RStopCoroutine_String == null)
				{
					r_RStopCoroutine_String = new(this, "StopCoroutine", 0, typeof(System.String));
					r_RStopCoroutine_String.SetBelong(this.instance);
				}
				return r_RStopCoroutine_String;
			}
		}

		/// <summary>
		/// Void StopAllCoroutines()
		/// </summary>
		protected RMethod r_RStopAllCoroutines;
		public virtual RMethod RStopAllCoroutines
		{
			get
			{
				if(r_RStopAllCoroutines == null)
				{
					r_RStopAllCoroutines = new(this, "StopAllCoroutines", 0);
					r_RStopAllCoroutines.SetBelong(this.instance);
				}
				return r_RStopAllCoroutines;
			}
		}

		/// <summary>
		/// System.String GetScriptClassName()
		/// </summary>
		protected RMethod r_RGetScriptClassName;
		public virtual RMethod RGetScriptClassName
		{
			get
			{
				if(r_RGetScriptClassName == null)
				{
					r_RGetScriptClassName = new(this, "GetScriptClassName", 0);
					r_RGetScriptClassName.SetBelong(this.instance);
				}
				return r_RGetScriptClassName;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponent_Type;
		public virtual RMethod RGetComponent_Type
		{
			get
			{
				if(r_RGetComponent_Type == null)
				{
					r_RGetComponent_Type = new(this, "GetComponent", 0, typeof(System.Type));
					r_RGetComponent_Type.SetBelong(this.instance);
				}
				return r_RGetComponent_Type;
			}
		}

		/// <summary>
		/// Void GetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_RGetComponentFastPath_Type_IntPtr;
		public virtual RMethod RGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_RGetComponentFastPath_Type_IntPtr == null)
				{
					r_RGetComponentFastPath_Type_IntPtr = new(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
					r_RGetComponentFastPath_Type_IntPtr.SetBelong(this.instance);
				}
				return r_RGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// T GetComponent[T]()
		/// </summary>
		protected RMethod r_RGetComponent_GT;
		public virtual RMethod RGetComponent_GT
		{
			get
			{
				if(r_RGetComponent_GT == null)
				{
					r_RGetComponent_GT = new(this, "GetComponent", 1);
					r_RGetComponent_GT.SetBelong(this.instance);
				}
				return r_RGetComponent_GT;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		/// </summary>
		protected RMethod r_RTryGetComponent_Type_Out_Component;
		public virtual RMethod RTryGetComponent_Type_Out_Component
		{
			get
			{
				if(r_RTryGetComponent_Type_Out_Component == null)
				{
					r_RTryGetComponent_Type_Out_Component = new(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
					r_RTryGetComponent_Type_Out_Component.SetBelong(this.instance);
				}
				return r_RTryGetComponent_Type_Out_Component;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent[T](T ByRef)
		/// </summary>
		protected RMethod r_RTryGetComponent_GT_Out_T;
		public virtual RMethod RTryGetComponent_GT_Out_T
		{
			get
			{
				if(r_RTryGetComponent_GT_Out_T == null)
				{
					r_RTryGetComponent_GT_Out_T = new(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RTryGetComponent_GT_Out_T.SetBelong(this.instance);
				}
				return r_RTryGetComponent_GT_Out_T;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.String)
		/// </summary>
		protected RMethod r_RGetComponent_String;
		public virtual RMethod RGetComponent_String
		{
			get
			{
				if(r_RGetComponent_String == null)
				{
					r_RGetComponent_String = new(this, "GetComponent", 0, typeof(System.String));
					r_RGetComponent_String.SetBelong(this.instance);
				}
				return r_RGetComponent_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_Type_Boolean;
		public virtual RMethod RGetComponentInChildren_Type_Boolean
		{
			get
			{
				if(r_RGetComponentInChildren_Type_Boolean == null)
				{
					r_RGetComponentInChildren_Type_Boolean = new(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_Type;
		public virtual RMethod RGetComponentInChildren_Type
		{
			get
			{
				if(r_RGetComponentInChildren_Type == null)
				{
					r_RGetComponentInChildren_Type = new(this, "GetComponentInChildren", 0, typeof(System.Type));
					r_RGetComponentInChildren_Type.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_Type;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_GT_Boolean;
		public virtual RMethod RGetComponentInChildren_GT_Boolean
		{
			get
			{
				if(r_RGetComponentInChildren_GT_Boolean == null)
				{
					r_RGetComponentInChildren_GT_Boolean = new(this, "GetComponentInChildren", 1, typeof(System.Boolean));
					r_RGetComponentInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T]()
		/// </summary>
		protected RMethod r_RGetComponentInChildren_GT;
		public virtual RMethod RGetComponentInChildren_GT
		{
			get
			{
				if(r_RGetComponentInChildren_GT == null)
				{
					r_RGetComponentInChildren_GT = new(this, "GetComponentInChildren", 1);
					r_RGetComponentInChildren_GT.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_Type_Boolean;
		public virtual RMethod RGetComponentsInChildren_Type_Boolean
		{
			get
			{
				if(r_RGetComponentsInChildren_Type_Boolean == null)
				{
					r_RGetComponentsInChildren_Type_Boolean = new(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentsInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_Type;
		public virtual RMethod RGetComponentsInChildren_Type
		{
			get
			{
				if(r_RGetComponentsInChildren_Type == null)
				{
					r_RGetComponentsInChildren_Type = new(this, "GetComponentsInChildren", 0, typeof(System.Type));
					r_RGetComponentsInChildren_Type.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_Boolean;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_Boolean == null)
				{
					r_RGetComponentsInChildren_GT_Boolean = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
					r_RGetComponentsInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_ == null)
				{
					r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T]()
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT;
		public virtual RMethod RGetComponentsInChildren_GT
		{
			get
			{
				if(r_RGetComponentsInChildren_GT == null)
				{
					r_RGetComponentsInChildren_GT = new(this, "GetComponentsInChildren", 1);
					r_RGetComponentsInChildren_GT.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_List_d_T_p_ == null)
				{
					r_RGetComponentsInChildren_GT_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInChildren_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInParent_Type_Boolean;
		public virtual RMethod RGetComponentInParent_Type_Boolean
		{
			get
			{
				if(r_RGetComponentInParent_Type_Boolean == null)
				{
					r_RGetComponentInParent_Type_Boolean = new(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentInParent_Type;
		public virtual RMethod RGetComponentInParent_Type
		{
			get
			{
				if(r_RGetComponentInParent_Type == null)
				{
					r_RGetComponentInParent_Type = new(this, "GetComponentInParent", 0, typeof(System.Type));
					r_RGetComponentInParent_Type.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_Type;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInParent_GT_Boolean;
		public virtual RMethod RGetComponentInParent_GT_Boolean
		{
			get
			{
				if(r_RGetComponentInParent_GT_Boolean == null)
				{
					r_RGetComponentInParent_GT_Boolean = new(this, "GetComponentInParent", 1, typeof(System.Boolean));
					r_RGetComponentInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T]()
		/// </summary>
		protected RMethod r_RGetComponentInParent_GT;
		public virtual RMethod RGetComponentInParent_GT
		{
			get
			{
				if(r_RGetComponentInParent_GT == null)
				{
					r_RGetComponentInParent_GT = new(this, "GetComponentInParent", 1);
					r_RGetComponentInParent_GT.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_Type_Boolean;
		public virtual RMethod RGetComponentsInParent_Type_Boolean
		{
			get
			{
				if(r_RGetComponentsInParent_Type_Boolean == null)
				{
					r_RGetComponentsInParent_Type_Boolean = new(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentsInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_Type;
		public virtual RMethod RGetComponentsInParent_Type
		{
			get
			{
				if(r_RGetComponentsInParent_Type == null)
				{
					r_RGetComponentsInParent_Type = new(this, "GetComponentsInParent", 0, typeof(System.Type));
					r_RGetComponentsInParent_Type.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT_Boolean;
		public virtual RMethod RGetComponentsInParent_GT_Boolean
		{
			get
			{
				if(r_RGetComponentsInParent_GT_Boolean == null)
				{
					r_RGetComponentsInParent_GT_Boolean = new(this, "GetComponentsInParent", 1, typeof(System.Boolean));
					r_RGetComponentsInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInParent_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInParent_GT_Boolean_List_d_T_p_ == null)
				{
					r_RGetComponentsInParent_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInParent_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T]()
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT;
		public virtual RMethod RGetComponentsInParent_GT
		{
			get
			{
				if(r_RGetComponentsInParent_GT == null)
				{
					r_RGetComponentsInParent_GT = new(this, "GetComponentsInParent", 1);
					r_RGetComponentsInParent_GT.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponents(System.Type)
		/// </summary>
		protected RMethod r_RGetComponents_Type;
		public virtual RMethod RGetComponents_Type
		{
			get
			{
				if(r_RGetComponents_Type == null)
				{
					r_RGetComponents_Type = new(this, "GetComponents", 0, typeof(System.Type));
					r_RGetComponents_Type.SetBelong(this.instance);
				}
				return r_RGetComponents_Type;
			}
		}

		/// <summary>
		/// Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		/// </summary>
		protected RMethod r_RGetComponents_Type_List_d_Component_p_;
		public virtual RMethod RGetComponents_Type_List_d_Component_p_
		{
			get
			{
				if(r_RGetComponents_Type_List_d_Component_p_ == null)
				{
					r_RGetComponents_Type_List_d_Component_p_ = new(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
					r_RGetComponents_Type_List_d_Component_p_.SetBelong(this.instance);
				}
				return r_RGetComponents_Type_List_d_Component_p_;
			}
		}

		/// <summary>
		/// Void GetComponents[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponents_GT_List_d_T_p_;
		public virtual RMethod RGetComponents_GT_List_d_T_p_
		{
			get
			{
				if(r_RGetComponents_GT_List_d_T_p_ == null)
				{
					r_RGetComponents_GT_List_d_T_p_ = new(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponents_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponents_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponents[T]()
		/// </summary>
		protected RMethod r_RGetComponents_GT;
		public virtual RMethod RGetComponents_GT
		{
			get
			{
				if(r_RGetComponents_GT == null)
				{
					r_RGetComponents_GT = new(this, "GetComponents", 1);
					r_RGetComponents_GT.SetBelong(this.instance);
				}
				return r_RGetComponents_GT;
			}
		}

		/// <summary>
		/// Boolean CompareTag(System.String)
		/// </summary>
		protected RMethod r_RCompareTag_String;
		public virtual RMethod RCompareTag_String
		{
			get
			{
				if(r_RCompareTag_String == null)
				{
					r_RCompareTag_String = new(this, "CompareTag", 0, typeof(System.String));
					r_RCompareTag_String.SetBelong(this.instance);
				}
				return r_RCompareTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetCoupledComponent()
		/// </summary>
		protected RMethod r_RGetCoupledComponent;
		public virtual RMethod RGetCoupledComponent
		{
			get
			{
				if(r_RGetCoupledComponent == null)
				{
					r_RGetCoupledComponent = new(this, "GetCoupledComponent", 0);
					r_RGetCoupledComponent.SetBelong(this.instance);
				}
				return r_RGetCoupledComponent;
			}
		}

		/// <summary>
		/// Boolean IsCoupledComponent()
		/// </summary>
		protected RMethod r_RIsCoupledComponent;
		public virtual RMethod RIsCoupledComponent
		{
			get
			{
				if(r_RIsCoupledComponent == null)
				{
					r_RIsCoupledComponent = new(this, "IsCoupledComponent", 0);
					r_RIsCoupledComponent.SetBelong(this.instance);
				}
				return r_RIsCoupledComponent;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessageUpwards_String_Object_SendMessageOptions == null)
				{
					r_RSendMessageUpwards_String_Object_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessageUpwards_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_Object;
		public virtual RMethod RSendMessageUpwards_String_Object
		{
			get
			{
				if(r_RSendMessageUpwards_String_Object == null)
				{
					r_RSendMessageUpwards_String_Object = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
					r_RSendMessageUpwards_String_Object.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String;
		public virtual RMethod RSendMessageUpwards_String
		{
			get
			{
				if(r_RSendMessageUpwards_String == null)
				{
					r_RSendMessageUpwards_String = new(this, "SendMessageUpwards", 0, typeof(System.String));
					r_RSendMessageUpwards_String.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_SendMessageOptions
		{
			get
			{
				if(r_RSendMessageUpwards_String_SendMessageOptions == null)
				{
					r_RSendMessageUpwards_String_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessageUpwards_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object;
		public virtual RMethod RSendMessage_String_Object
		{
			get
			{
				if(r_RSendMessage_String_Object == null)
				{
					r_RSendMessage_String_Object = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
					r_RSendMessage_String_Object.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String)
		/// </summary>
		protected RMethod r_RSendMessage_String;
		public virtual RMethod RSendMessage_String
		{
			get
			{
				if(r_RSendMessage_String == null)
				{
					r_RSendMessage_String = new(this, "SendMessage", 0, typeof(System.String));
					r_RSendMessage_String.SetBelong(this.instance);
				}
				return r_RSendMessage_String;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_Object_SendMessageOptions == null)
				{
					r_RSendMessage_String_Object_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_SendMessageOptions;
		public virtual RMethod RSendMessage_String_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_SendMessageOptions == null)
				{
					r_RSendMessage_String_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_Object_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RBroadcastMessage_String_Object_SendMessageOptions == null)
				{
					r_RBroadcastMessage_String_Object_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RBroadcastMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_Object;
		public virtual RMethod RBroadcastMessage_String_Object
		{
			get
			{
				if(r_RBroadcastMessage_String_Object == null)
				{
					r_RBroadcastMessage_String_Object = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
					r_RBroadcastMessage_String_Object.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_Object;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String;
		public virtual RMethod RBroadcastMessage_String
		{
			get
			{
				if(r_RBroadcastMessage_String == null)
				{
					r_RBroadcastMessage_String = new(this, "BroadcastMessage", 0, typeof(System.String));
					r_RBroadcastMessage_String.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_SendMessageOptions
		{
			get
			{
				if(r_RBroadcastMessage_String_SendMessageOptions == null)
				{
					r_RBroadcastMessage_String_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RBroadcastMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RCombatController() : base("CombatController")
        {
        }

        public RCombatController(System.Object instance) : base("CombatController")
		{
            SetInstance(instance);
		}

        public RCombatController(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCombatController(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String GetSpecialMonster_NAME(System.String  @str, System.Int32  @nSpecialMonster)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @nSpecialMonster};
            var ___result = RGetSpecialMonster_NAME_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.Color GetPetColor(System.Int32  @mobStar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mobStar};
            var ___result = RGetPetColor_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual void TransMapUpdateInfo(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RTransMapUpdateInfo_GameObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRoundStart(System.Int32  @mRound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mRound};
            var ___result = ROnRoundStart_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnRoundStartReconnect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnRoundStartReconnect.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void CareerStageChange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCareerStageChange.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CarrerChangeAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCarrerChangeAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator PlayApperar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPlayApperar.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }




        public virtual System.String GetStateAnimationName(System.String  @animationNamePrefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animationNamePrefix};
            var ___result = RGetStateAnimationName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean isHeavyInjured()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RisHeavyInjured.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PlayIdle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPlayIdle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayIdle(System.Boolean  @isForce)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isForce};
            var ___result = RPlayIdle_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Single VictoryAniTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RVictoryAniTime.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void TureAround()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTureAround.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LookAtFront()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLookAtFront.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoakAtTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoakAtTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActionList(System.Object  @lstAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lstAction};
            var ___result = RSetActionList_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean isInjureFinish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RisInjureFinish.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean isAttackFinish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RisAttackFinish.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean isActionFinish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RisActionFinish.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ClearCurrentAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearCurrentAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetCurrentActionCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrentActionCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void SetConAtkActionList(UnityEngine.Transform  @mTarget)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mTarget};
            var ___result = RSetConAtkActionList_Transform.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void NewFrame_ActionInit(GameDefineType.ID  @skillid, System.UInt32  @carrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skillid, @carrer};
            var ___result = RNewFrame_ActionInit_ID_UInt32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Collections.IEnumerator NewFrame_SetMemberFinish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNewFrame_SetMemberFinish.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }



        public virtual System.Collections.IEnumerator NewFrame_ExcActionListDelay(System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RNewFrame_ExcActionListDelay_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void NewFrame_ExcActionList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNewFrame_ExcActionList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator CleaInjureActionList(System.Single  @mTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mTime};
            var ___result = RCleaInjureActionList_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }







        public virtual void NewFrame_End()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RNewFrame_End.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStartAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAttacked(System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, System.Boolean  @isInjureFinish)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aniName, @subDamegeEffectName, @isShowDamage, @isInjureFinish};
            var ___result = ROnAttacked_String_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyDamage(UnityEngine.Transform  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RApplyDamage_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SubTakeDamage(System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, System.Boolean  @isAnimationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aniName, @subDamegeEffectName, @isShowDamage, @isAnimationAction};
            var ___result = RSubTakeDamage_String_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TakeDamage(System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, System.Boolean  @isInjureFinish)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aniName, @subDamegeEffectName, @isShowDamage, @isInjureFinish};
            var ___result = RTakeDamage_String_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AfterDie()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAfterDie.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator OnModleLoadedReset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnModleLoadedReset.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void CheckLife()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckLife.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Collections.IEnumerator DieBodyClear(GameDefineType.ID  @idFighter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter};
            var ___result = RDieBodyClear_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void OnDieChange2Soul()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDieChange2Soul.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartShakeEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStartShakeEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopShakeEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopShakeEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateShakeEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateShakeEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateStateInCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateStateInCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BubbleInCombat(System.String  @talkinContent, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@talkinContent, @time};
            var ___result = RBubbleInCombat_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFighterSkill(GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = RSetFighterSkill_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFighterSkill(GameDefineType.ID  @idSkill, UnityEngine.Texture2D  @skillIcon, UnityEngine.Rect  @rt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill, @skillIcon, @rt};
            var ___result = RSetFighterSkill_ID_Texture2D_Rect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator IconFlyStartTimeCountDown(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RIconFlyStartTimeCountDown_GameObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void SetScoreEffect(System.Int32  @score)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@score};
            var ___result = RSetScoreEffect_Int32.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void SetSuperSkillBuffEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetSuperSkillBuffEffect.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ClearSkillIcon(GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = RClearSkillIcon_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearSkillIconAndEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearSkillIconAndEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScreenEffectUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScreenEffectUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScreenEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScreenEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlashMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlashMaterial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateFlashMaterial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateFlashMaterial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateProtect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateProtect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BeingProtect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBeingProtect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActionProtect(UnityEngine.Transform  @trans)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trans};
            var ___result = RSetActionProtect_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProtectFinish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RProtectFinish.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PositionRest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPositionRest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetProtectTarget()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetProtectTarget.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetProtectTargetOnDie()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetProtectTargetOnDie.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDefend(System.Boolean  @isFriendGroup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isFriendGroup};
            var ___result = RSetDefend_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DelFighter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDelFighter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnRegisterFighter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnRegisterFighter.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void EscapeSuccess()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REscapeSuccess.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator EscapeFail()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REscapeFail.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }



        public virtual void RoundFinish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRoundFinish.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetActionFinished(System.Boolean  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b};
            var ___result = RSetActionFinished_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsActionFinished()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsActionFinished.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void SetMemberFinish()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetMemberFinish.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCommandTarget(UnityEngine.Transform  @target)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@target};
            var ___result = RSetCommandTarget_Transform.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetCombatCMDex(GameDefineType.ID  @cmdEx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cmdEx};
            var ___result = RSetCombatCMDex_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetCurrentCommand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCurrentCommand.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void ClearPlayerCommand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearPlayerCommand.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean IsCommandSelectEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCommandSelectEnd.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetCommandSelectEnd(System.Boolean  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b};
            var ___result = RSetCommandSelectEnd_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSelectable(System.Boolean  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b};
            var ___result = RSetSelectable_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseOverSetection()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseOverSetection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HighLightName(System.Boolean  @bl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl};
            var ___result = RHighLightName_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GameObject HpFlash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHpFlash.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void StopHpFlash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopHpFlash.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator HpFlashUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHpFlashUpdate.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Boolean IsSelectable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsSelectable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsEnemy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsEnemy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PlayCameraAnimation(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RPlayCameraAnimation_String.Invoke(___genericsType, ___parameters);

            
        }




        public static System.String GetBoneNameFromEffectName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetBoneNameFromEffectName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.String GetBoneNameFromEffectName(System.Int32  @index, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @name};
            var ___result = RGetBoneNameFromEffectName_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static UnityEngine.Transform GetBone(UnityEngine.Transform  @trans, System.String  @boneName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trans, @boneName};
            var ___result = RGetBone_Transform_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }


        public static UnityEngine.Transform TryGetBone(UnityEngine.Transform  @trans, System.String  @boneName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trans, @boneName};
            var ___result = RTryGetBone_Transform_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform)___result;
        }







        public virtual void HideBodyExc(System.Boolean  @bl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl};
            var ___result = RHideBodyExc_Boolean.Invoke(___genericsType, ___parameters);

            
        }











        public virtual void DodgeEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDodgeEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator _DodgeEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_DodgeEffect.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator DefendEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDefendEffect.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }










        public virtual System.Collections.IEnumerator CheckModelDownload()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckModelDownload.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void InitFollowingStuff()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitFollowingStuff.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void PetInjury()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPetInjury.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsInvoking()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInvoking.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CancelInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCancelInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(System.String  @methodName, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @time};
            var ___result = RInvoke_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeRepeating(System.String  @methodName, System.Single  @time, System.Single  @repeatRate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @time, @repeatRate};
            var ___result = RInvokeRepeating_String_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelInvoke(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCancelInvoke_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsInvoking(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RIsInvoking_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RStartCoroutine_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RStartCoroutine_String_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStartCoroutine_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStartCoroutine_Auto_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual void StopCoroutine(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutine_IEnumerator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutine(UnityEngine.Coroutine  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutine_Coroutine.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutine(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RStopCoroutine_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopAllCoroutines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopAllCoroutines.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetScriptClassName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetScriptClassName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual UnityEngine.Component GetComponent(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void GetComponentFastPath(System.Type  @type, System.IntPtr  @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean TryGetComponent(System.Type  @type, out UnityEngine.Component  @component)
        {
			component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			component = (UnityEngine.Component)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetComponent<T>(out T  @component)
        {
			component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			component = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component GetComponent(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @result)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @result};
            var ___result = RGetComponentsInChildren_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponentsInChildren_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInParent<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInParent_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual UnityEngine.Component[] GetComponents(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponents_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual void GetComponents(System.Type  @type, System.Collections.Generic.List<UnityEngine.Component>  @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @results};
            var ___result = RGetComponents_Type_List_d_Component_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetComponents<T>(System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponents_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponents<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponents_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual System.Boolean CompareTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RCompareTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component GetCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCoupledComponent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual System.Boolean IsCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCoupledComponent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SendMessageUpwards(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessageUpwards_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessageUpwards_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessageUpwards_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, System.Object  @parameter, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter, @options};
            var ___result = RBroadcastMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, System.Object  @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter};
            var ___result = RBroadcastMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RBroadcastMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
