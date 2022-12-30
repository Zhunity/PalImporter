using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// NPCBehav
	/// </summary>
    public partial class RNPCBehav : RMember //
    {

		/// <summary>
		/// System.Single npcInVisionDistan
		/// </summary>
		protected static RField r_npcInVisionDistan;
		public static RField RnpcInVisionDistan
		{
			get
			{
				if(r_npcInVisionDistan == null)
				{
					r_npcInVisionDistan = new( ReleactionUtils.GetType("NPCBehav"), "npcInVisionDistan");
					r_npcInVisionDistan.SetBelong(null);
				}
				return r_npcInVisionDistan;
			}
		}

		/// <summary>
		/// System.Boolean isNpcClickable
		/// </summary>
		protected static RField r_isNpcClickable;
		public static RField RisNpcClickable
		{
			get
			{
				if(r_isNpcClickable == null)
				{
					r_isNpcClickable = new( ReleactionUtils.GetType("NPCBehav"), "isNpcClickable");
					r_isNpcClickable.SetBelong(null);
				}
				return r_isNpcClickable;
			}
		}

		/// <summary>
		/// GameDefineType.ID g_IDOverName
		/// </summary>
		protected static RGameDefineType.RID r_g_IDOverName;
		public static RGameDefineType.RID Rg_IDOverName
		{
			get
			{
				if(r_g_IDOverName == null)
				{
					r_g_IDOverName = new( ReleactionUtils.GetType("NPCBehav"), "g_IDOverName");
					r_g_IDOverName.SetBelong(null);
				}
				return r_g_IDOverName;
			}
		}

		/// <summary>
		/// NPC_DEFINE_TYPE m_NpcType
		/// </summary>
		protected RField r_m_NpcType;
		public virtual RField Rm_NpcType
		{
			get
			{
				if(r_m_NpcType == null)
				{
					r_m_NpcType = new(this, "m_NpcType");
					r_m_NpcType.SetBelong(this.instance);
				}
				return r_m_NpcType;
			}
		}

		/// <summary>
		/// NPC m_refObj
		/// </summary>
		protected RNPC r_m_refObj;
		public virtual RNPC Rm_refObj
		{
			get
			{
				if(r_m_refObj == null)
				{
					r_m_refObj = new(this, "m_refObj");
					r_m_refObj.SetBelong(this.instance);
				}
				return r_m_refObj;
			}
		}

		/// <summary>
		/// System.Boolean m_bAICtrlEnable
		/// </summary>
		protected RField r_m_bAICtrlEnable;
		public virtual RField Rm_bAICtrlEnable
		{
			get
			{
				if(r_m_bAICtrlEnable == null)
				{
					r_m_bAICtrlEnable = new(this, "m_bAICtrlEnable");
					r_m_bAICtrlEnable.SetBelong(this.instance);
				}
				return r_m_bAICtrlEnable;
			}
		}

		/// <summary>
		/// System.Boolean m_bLocalAI
		/// </summary>
		protected RField r_m_bLocalAI;
		public virtual RField Rm_bLocalAI
		{
			get
			{
				if(r_m_bLocalAI == null)
				{
					r_m_bLocalAI = new(this, "m_bLocalAI");
					r_m_bLocalAI.SetBelong(this.instance);
				}
				return r_m_bLocalAI;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject NPCTaskIconInst
		/// </summary>
		protected RUnityEngine.RGameObject r_NPCTaskIconInst;
		public virtual RUnityEngine.RGameObject RNPCTaskIconInst
		{
			get
			{
				if(r_NPCTaskIconInst == null)
				{
					r_NPCTaskIconInst = new(this, "NPCTaskIconInst");
					r_NPCTaskIconInst.SetBelong(this.instance);
				}
				return r_NPCTaskIconInst;
			}
		}

		/// <summary>
		/// System.Single height
		/// </summary>
		protected RField r_height;
		public virtual RField Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height");
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// Message.TASK_NOTIFY_TYPE m_taskIconType
		/// </summary>
		protected RField r_m_taskIconType;
		public virtual RField Rm_taskIconType
		{
			get
			{
				if(r_m_taskIconType == null)
				{
					r_m_taskIconType = new(this, "m_taskIconType");
					r_m_taskIconType.SetBelong(this.instance);
				}
				return r_m_taskIconType;
			}
		}

		/// <summary>
		/// Message.TASK_NOTIFY_TYPE NPCTaskIconType
		/// </summary>
		protected RField r_NPCTaskIconType;
		public virtual RField RNPCTaskIconType
		{
			get
			{
				if(r_NPCTaskIconType == null)
				{
					r_NPCTaskIconType = new(this, "NPCTaskIconType");
					r_NPCTaskIconType.SetBelong(this.instance);
				}
				return r_NPCTaskIconType;
			}
		}

		/// <summary>
		/// System.Boolean IconVisible
		/// </summary>
		protected RField r_IconVisible;
		public virtual RField RIconVisible
		{
			get
			{
				if(r_IconVisible == null)
				{
					r_IconVisible = new(this, "IconVisible");
					r_IconVisible.SetBelong(this.instance);
				}
				return r_IconVisible;
			}
		}

		/// <summary>
		/// UnityEngine.CharacterController _ctrl
		/// </summary>
		protected RUnityEngine.RCharacterController r__ctrl;
		public virtual RUnityEngine.RCharacterController R_ctrl
		{
			get
			{
				if(r__ctrl == null)
				{
					r__ctrl = new(this, "_ctrl");
					r__ctrl.SetBelong(this.instance);
				}
				return r__ctrl;
			}
		}

		/// <summary>
		/// System.Single mInitPosY
		/// </summary>
		protected RField r_mInitPosY;
		public virtual RField RmInitPosY
		{
			get
			{
				if(r_mInitPosY == null)
				{
					r_mInitPosY = new(this, "mInitPosY");
					r_mInitPosY.SetBelong(this.instance);
				}
				return r_mInitPosY;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vTargetPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vTargetPos;
		public virtual RUnityEngine.RVector3 Rm_vTargetPos
		{
			get
			{
				if(r_m_vTargetPos == null)
				{
					r_m_vTargetPos = new(this, "m_vTargetPos");
					r_m_vTargetPos.SetBelong(this.instance);
				}
				return r_m_vTargetPos;
			}
		}

		/// <summary>
		/// Seeker _seeker
		/// </summary>
		protected RSeeker r__seeker;
		public virtual RSeeker R_seeker
		{
			get
			{
				if(r__seeker == null)
				{
					r__seeker = new(this, "_seeker");
					r__seeker.SetBelong(this.instance);
				}
				return r__seeker;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 destination
		/// </summary>
		protected RUnityEngine.RVector3 r_destination;
		public virtual RUnityEngine.RVector3 Rdestination
		{
			get
			{
				if(r_destination == null)
				{
					r_destination = new(this, "destination");
					r_destination.SetBelong(this.instance);
				}
				return r_destination;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 lineOfSight
		/// </summary>
		protected RUnityEngine.RVector3 r_lineOfSight;
		public virtual RUnityEngine.RVector3 RlineOfSight
		{
			get
			{
				if(r_lineOfSight == null)
				{
					r_lineOfSight = new(this, "lineOfSight");
					r_lineOfSight.SetBelong(this.instance);
				}
				return r_lineOfSight;
			}
		}

		/// <summary>
		/// System.Single turnSpeedFactor
		/// </summary>
		protected RField r_turnSpeedFactor;
		public virtual RField RturnSpeedFactor
		{
			get
			{
				if(r_turnSpeedFactor == null)
				{
					r_turnSpeedFactor = new(this, "turnSpeedFactor");
					r_turnSpeedFactor.SetBelong(this.instance);
				}
				return r_turnSpeedFactor;
			}
		}

		/// <summary>
		/// System.Single turnSpeed
		/// </summary>
		protected RField r_turnSpeed;
		public virtual RField RturnSpeed
		{
			get
			{
				if(r_turnSpeed == null)
				{
					r_turnSpeed = new(this, "turnSpeed");
					r_turnSpeed.SetBelong(this.instance);
				}
				return r_turnSpeed;
			}
		}

		/// <summary>
		/// System.Single turnEffect
		/// </summary>
		protected RField r_turnEffect;
		public virtual RField RturnEffect
		{
			get
			{
				if(r_turnEffect == null)
				{
					r_turnEffect = new(this, "turnEffect");
					r_turnEffect.SetBelong(this.instance);
				}
				return r_turnEffect;
			}
		}

		/// <summary>
		/// System.Single speed
		/// </summary>
		protected RField r_speed;
		public virtual RField Rspeed
		{
			get
			{
				if(r_speed == null)
				{
					r_speed = new(this, "speed");
					r_speed.SetBelong(this.instance);
				}
				return r_speed;
			}
		}

		/// <summary>
		/// System.Single radius
		/// </summary>
		protected RField r_radius;
		public virtual RField Rradius
		{
			get
			{
				if(r_radius == null)
				{
					r_radius = new(this, "radius");
					r_radius.SetBelong(this.instance);
				}
				return r_radius;
			}
		}

		/// <summary>
		/// System.Single arrivalRadius
		/// </summary>
		protected RField r_arrivalRadius;
		public virtual RField RarrivalRadius
		{
			get
			{
				if(r_arrivalRadius == null)
				{
					r_arrivalRadius = new(this, "arrivalRadius");
					r_arrivalRadius.SetBelong(this.instance);
				}
				return r_arrivalRadius;
			}
		}

		/// <summary>
		/// System.Single m_fVision
		/// </summary>
		protected RField r_m_fVision;
		public virtual RField Rm_fVision
		{
			get
			{
				if(r_m_fVision == null)
				{
					r_m_fVision = new(this, "m_fVision");
					r_m_fVision.SetBelong(this.instance);
				}
				return r_m_fVision;
			}
		}

		/// <summary>
		/// System.Single m_fChaseRadius
		/// </summary>
		protected RField r_m_fChaseRadius;
		public virtual RField Rm_fChaseRadius
		{
			get
			{
				if(r_m_fChaseRadius == null)
				{
					r_m_fChaseRadius = new(this, "m_fChaseRadius");
					r_m_fChaseRadius.SetBelong(this.instance);
				}
				return r_m_fChaseRadius;
			}
		}

		/// <summary>
		/// System.Single speedFactor
		/// </summary>
		protected RField r_speedFactor;
		public virtual RField RspeedFactor
		{
			get
			{
				if(r_speedFactor == null)
				{
					r_speedFactor = new(this, "speedFactor");
					r_speedFactor.SetBelong(this.instance);
				}
				return r_speedFactor;
			}
		}

		/// <summary>
		/// System.Int32 m_nAnimIdx
		/// </summary>
		protected RField r_m_nAnimIdx;
		public virtual RField Rm_nAnimIdx
		{
			get
			{
				if(r_m_nAnimIdx == null)
				{
					r_m_nAnimIdx = new(this, "m_nAnimIdx");
					r_m_nAnimIdx.SetBelong(this.instance);
				}
				return r_m_nAnimIdx;
			}
		}

		/// <summary>
		/// System.Single m_fDefAnimTime
		/// </summary>
		protected RField r_m_fDefAnimTime;
		public virtual RField Rm_fDefAnimTime
		{
			get
			{
				if(r_m_fDefAnimTime == null)
				{
					r_m_fDefAnimTime = new(this, "m_fDefAnimTime");
					r_m_fDefAnimTime.SetBelong(this.instance);
				}
				return r_m_fDefAnimTime;
			}
		}

		/// <summary>
		/// System.String m_sDefAction
		/// </summary>
		protected RField r_m_sDefAction;
		public virtual RField Rm_sDefAction
		{
			get
			{
				if(r_m_sDefAction == null)
				{
					r_m_sDefAction = new(this, "m_sDefAction");
					r_m_sDefAction.SetBelong(this.instance);
				}
				return r_m_sDefAction;
			}
		}

		/// <summary>
		/// System.String[] m_ActionPool
		/// </summary>
		protected RFieldArray<RField> r_m_ActionPool;
		public virtual RFieldArray<RField> Rm_ActionPool
		{
			get
			{
				if(r_m_ActionPool == null)
				{
					r_m_ActionPool = new(this, "m_ActionPool");
					r_m_ActionPool.SetBelong(this.instance);
				}
				return r_m_ActionPool;
			}
		}

		/// <summary>
		/// System.String[] m_ActionTimePool
		/// </summary>
		protected RFieldArray<RField> r_m_ActionTimePool;
		public virtual RFieldArray<RField> Rm_ActionTimePool
		{
			get
			{
				if(r_m_ActionTimePool == null)
				{
					r_m_ActionTimePool = new(this, "m_ActionTimePool");
					r_m_ActionTimePool.SetBelong(this.instance);
				}
				return r_m_ActionTimePool;
			}
		}

		/// <summary>
		/// System.Single maxFrameTime
		/// </summary>
		protected RField r_maxFrameTime;
		public virtual RField RmaxFrameTime
		{
			get
			{
				if(r_maxFrameTime == null)
				{
					r_maxFrameTime = new(this, "maxFrameTime");
					r_maxFrameTime.SetBelong(this.instance);
				}
				return r_maxFrameTime;
			}
		}

		/// <summary>
		/// System.String[] requiredTags
		/// </summary>
		protected RFieldArray<RField> r_requiredTags;
		public virtual RFieldArray<RField> RrequiredTags
		{
			get
			{
				if(r_requiredTags == null)
				{
					r_requiredTags = new(this, "requiredTags");
					r_requiredTags.SetBelong(this.instance);
				}
				return r_requiredTags;
			}
		}

		/// <summary>
		/// System.String[] excludedTags
		/// </summary>
		protected RFieldArray<RField> r_excludedTags;
		public virtual RFieldArray<RField> RexcludedTags
		{
			get
			{
				if(r_excludedTags == null)
				{
					r_excludedTags = new(this, "excludedTags");
					r_excludedTags.SetBelong(this.instance);
				}
				return r_excludedTags;
			}
		}

		/// <summary>
		/// NPCBehav+MobState m_nMobState
		/// </summary>
		protected RField r_m_nMobState;
		public virtual RField Rm_nMobState
		{
			get
			{
				if(r_m_nMobState == null)
				{
					r_m_nMobState = new(this, "m_nMobState");
					r_m_nMobState.SetBelong(this.instance);
				}
				return r_m_nMobState;
			}
		}

		/// <summary>
		/// System.Boolean bMove
		/// </summary>
		protected RField r_bMove;
		public virtual RField RbMove
		{
			get
			{
				if(r_bMove == null)
				{
					r_bMove = new(this, "bMove");
					r_bMove.SetBelong(this.instance);
				}
				return r_bMove;
			}
		}

		/// <summary>
		/// UnityEngine.LayerMask mask_create
		/// </summary>
		protected RUnityEngine.RLayerMask r_mask_create;
		public virtual RUnityEngine.RLayerMask Rmask_create
		{
			get
			{
				if(r_mask_create == null)
				{
					r_mask_create = new(this, "mask_create");
					r_mask_create.SetBelong(this.instance);
				}
				return r_mask_create;
			}
		}

		/// <summary>
		/// System.Single PURSUITSPEED
		/// </summary>
		protected RField r_PURSUITSPEED;
		public virtual RField RPURSUITSPEED
		{
			get
			{
				if(r_PURSUITSPEED == null)
				{
					r_PURSUITSPEED = new(this, "PURSUITSPEED");
					r_PURSUITSPEED.SetBelong(this.instance);
				}
				return r_PURSUITSPEED;
			}
		}

		/// <summary>
		/// System.Single FLEESPEED
		/// </summary>
		protected RField r_FLEESPEED;
		public virtual RField RFLEESPEED
		{
			get
			{
				if(r_FLEESPEED == null)
				{
					r_FLEESPEED = new(this, "FLEESPEED");
					r_FLEESPEED.SetBelong(this.instance);
				}
				return r_FLEESPEED;
			}
		}

		/// <summary>
		/// System.Single RETURNSPEED
		/// </summary>
		protected RField r_RETURNSPEED;
		public virtual RField RETURNSPEED
		{
			get
			{
				if(r_RETURNSPEED == null)
				{
					r_RETURNSPEED = new(this, "RETURNSPEED");
					r_RETURNSPEED.SetBelong(this.instance);
				}
				return r_RETURNSPEED;
			}
		}

		/// <summary>
		/// System.Single PATROLSPEED
		/// </summary>
		protected RField r_PATROLSPEED;
		public virtual RField RPATROLSPEED
		{
			get
			{
				if(r_PATROLSPEED == null)
				{
					r_PATROLSPEED = new(this, "PATROLSPEED");
					r_PATROLSPEED.SetBelong(this.instance);
				}
				return r_PATROLSPEED;
			}
		}

		/// <summary>
		/// System.Boolean IsDialogOpening
		/// </summary>
		protected RField r_IsDialogOpening;
		public virtual RField RIsDialogOpening
		{
			get
			{
				if(r_IsDialogOpening == null)
				{
					r_IsDialogOpening = new(this, "IsDialogOpening");
					r_IsDialogOpening.SetBelong(this.instance);
				}
				return r_IsDialogOpening;
			}
		}

		/// <summary>
		/// System.Single patrolRadius
		/// </summary>
		protected RField r_patrolRadius;
		public virtual RField RpatrolRadius
		{
			get
			{
				if(r_patrolRadius == null)
				{
					r_patrolRadius = new(this, "patrolRadius");
					r_patrolRadius.SetBelong(this.instance);
				}
				return r_patrolRadius;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 vecStartPos
		/// </summary>
		protected RUnityEngine.RVector3 r_vecStartPos;
		public virtual RUnityEngine.RVector3 RvecStartPos
		{
			get
			{
				if(r_vecStartPos == null)
				{
					r_vecStartPos = new(this, "vecStartPos");
					r_vecStartPos.SetBelong(this.instance);
				}
				return r_vecStartPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vLastPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vLastPos;
		public virtual RUnityEngine.RVector3 Rm_vLastPos
		{
			get
			{
				if(r_m_vLastPos == null)
				{
					r_m_vLastPos = new(this, "m_vLastPos");
					r_m_vLastPos.SetBelong(this.instance);
				}
				return r_m_vLastPos;
			}
		}

		/// <summary>
		/// System.Single m_fAITimer
		/// </summary>
		protected RField r_m_fAITimer;
		public virtual RField Rm_fAITimer
		{
			get
			{
				if(r_m_fAITimer == null)
				{
					r_m_fAITimer = new(this, "m_fAITimer");
					r_m_fAITimer.SetBelong(this.instance);
				}
				return r_m_fAITimer;
			}
		}

		/// <summary>
		/// System.Single m_fReturnTime
		/// </summary>
		protected RField r_m_fReturnTime;
		public virtual RField Rm_fReturnTime
		{
			get
			{
				if(r_m_fReturnTime == null)
				{
					r_m_fReturnTime = new(this, "m_fReturnTime");
					r_m_fReturnTime.SetBelong(this.instance);
				}
				return r_m_fReturnTime;
			}
		}

		/// <summary>
		/// System.Boolean m_bReturning
		/// </summary>
		protected RField r_m_bReturning;
		public virtual RField Rm_bReturning
		{
			get
			{
				if(r_m_bReturning == null)
				{
					r_m_bReturning = new(this, "m_bReturning");
					r_m_bReturning.SetBelong(this.instance);
				}
				return r_m_bReturning;
			}
		}

		/// <summary>
		/// System.Boolean m_bNoPlayerInRange
		/// </summary>
		protected RField r_m_bNoPlayerInRange;
		public virtual RField Rm_bNoPlayerInRange
		{
			get
			{
				if(r_m_bNoPlayerInRange == null)
				{
					r_m_bNoPlayerInRange = new(this, "m_bNoPlayerInRange");
					r_m_bNoPlayerInRange.SetBelong(this.instance);
				}
				return r_m_bNoPlayerInRange;
			}
		}

		/// <summary>
		/// Creature m_TargetPlayer
		/// </summary>
		protected RCreature r_m_TargetPlayer;
		public virtual RCreature Rm_TargetPlayer
		{
			get
			{
				if(r_m_TargetPlayer == null)
				{
					r_m_TargetPlayer = new(this, "m_TargetPlayer");
					r_m_TargetPlayer.SetBelong(this.instance);
				}
				return r_m_TargetPlayer;
			}
		}

		/// <summary>
		/// System.Single _modeScale
		/// </summary>
		protected RField r__modeScale;
		public virtual RField R_modeScale
		{
			get
			{
				if(r__modeScale == null)
				{
					r__modeScale = new(this, "_modeScale");
					r__modeScale.SetBelong(this.instance);
				}
				return r__modeScale;
			}
		}

		/// <summary>
		/// System.Boolean isBigBoss
		/// </summary>
		protected RField r_isBigBoss;
		public virtual RField RisBigBoss
		{
			get
			{
				if(r_isBigBoss == null)
				{
					r_isBigBoss = new(this, "isBigBoss");
					r_isBigBoss.SetBelong(this.instance);
				}
				return r_isBigBoss;
			}
		}

		/// <summary>
		/// System.Single NPCFeedBackTime
		/// </summary>
		protected static RField r_NPCFeedBackTime;
		public static RField RNPCFeedBackTime
		{
			get
			{
				if(r_NPCFeedBackTime == null)
				{
					r_NPCFeedBackTime = new( ReleactionUtils.GetType("NPCBehav"), "NPCFeedBackTime");
					r_NPCFeedBackTime.SetBelong(null);
				}
				return r_NPCFeedBackTime;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 rawDir
		/// </summary>
		protected RUnityEngine.RVector3 r_rawDir;
		public virtual RUnityEngine.RVector3 RrawDir
		{
			get
			{
				if(r_rawDir == null)
				{
					r_rawDir = new(this, "rawDir");
					r_rawDir.SetBelong(this.instance);
				}
				return r_rawDir;
			}
		}

		/// <summary>
		/// System.Boolean isRemoving
		/// </summary>
		protected RField r_isRemoving;
		public virtual RField RisRemoving
		{
			get
			{
				if(r_isRemoving == null)
				{
					r_isRemoving = new(this, "isRemoving");
					r_isRemoving.SetBelong(this.instance);
				}
				return r_isRemoving;
			}
		}

		/// <summary>
		/// System.String m_OwnerName
		/// </summary>
		protected RField r_m_OwnerName;
		public virtual RField Rm_OwnerName
		{
			get
			{
				if(r_m_OwnerName == null)
				{
					r_m_OwnerName = new(this, "m_OwnerName");
					r_m_OwnerName.SetBelong(this.instance);
				}
				return r_m_OwnerName;
			}
		}

		/// <summary>
		/// System.Boolean isLanded
		/// </summary>
		protected RField r_isLanded;
		public virtual RField RisLanded
		{
			get
			{
				if(r_isLanded == null)
				{
					r_isLanded = new(this, "isLanded");
					r_isLanded.SetBelong(this.instance);
				}
				return r_isLanded;
			}
		}

		/// <summary>
		/// System.Single m_fDistance
		/// </summary>
		protected RField r_m_fDistance;
		public virtual RField Rm_fDistance
		{
			get
			{
				if(r_m_fDistance == null)
				{
					r_m_fDistance = new(this, "m_fDistance");
					r_m_fDistance.SetBelong(this.instance);
				}
				return r_m_fDistance;
			}
		}

		/// <summary>
		/// System.Single m_fLastTime
		/// </summary>
		protected RField r_m_fLastTime;
		public virtual RField Rm_fLastTime
		{
			get
			{
				if(r_m_fLastTime == null)
				{
					r_m_fLastTime = new(this, "m_fLastTime");
					r_m_fLastTime.SetBelong(this.instance);
				}
				return r_m_fLastTime;
			}
		}

		/// <summary>
		/// System.Single m_timeFixUpdate
		/// </summary>
		protected RField r_m_timeFixUpdate;
		public virtual RField Rm_timeFixUpdate
		{
			get
			{
				if(r_m_timeFixUpdate == null)
				{
					r_m_timeFixUpdate = new(this, "m_timeFixUpdate");
					r_m_timeFixUpdate.SetBelong(this.instance);
				}
				return r_m_timeFixUpdate;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_DstPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_DstPos;
		public virtual RUnityEngine.RVector3 Rm_DstPos
		{
			get
			{
				if(r_m_DstPos == null)
				{
					r_m_DstPos = new(this, "m_DstPos");
					r_m_DstPos.SetBelong(this.instance);
				}
				return r_m_DstPos;
			}
		}

		/// <summary>
		/// UnityEngine.Animation mAnimation
		/// </summary>
		protected RUnityEngine.RAnimation r_mAnimation;
		public virtual RUnityEngine.RAnimation RmAnimation
		{
			get
			{
				if(r_mAnimation == null)
				{
					r_mAnimation = new(this, "mAnimation");
					r_mAnimation.SetBelong(this.instance);
				}
				return r_mAnimation;
			}
		}

		/// <summary>
		/// System.Boolean m_bOpeningChest
		/// </summary>
		protected RField r_m_bOpeningChest;
		public virtual RField Rm_bOpeningChest
		{
			get
			{
				if(r_m_bOpeningChest == null)
				{
					r_m_bOpeningChest = new(this, "m_bOpeningChest");
					r_m_bOpeningChest.SetBelong(this.instance);
				}
				return r_m_bOpeningChest;
			}
		}

		/// <summary>
		/// System.String m_SpecAnimName
		/// </summary>
		protected RField r_m_SpecAnimName;
		public virtual RField Rm_SpecAnimName
		{
			get
			{
				if(r_m_SpecAnimName == null)
				{
					r_m_SpecAnimName = new(this, "m_SpecAnimName");
					r_m_SpecAnimName.SetBelong(this.instance);
				}
				return r_m_SpecAnimName;
			}
		}

		/// <summary>
		/// System.Single m_fSpecAnimTime
		/// </summary>
		protected RField r_m_fSpecAnimTime;
		public virtual RField Rm_fSpecAnimTime
		{
			get
			{
				if(r_m_fSpecAnimTime == null)
				{
					r_m_fSpecAnimTime = new(this, "m_fSpecAnimTime");
					r_m_fSpecAnimTime.SetBelong(this.instance);
				}
				return r_m_fSpecAnimTime;
			}
		}

		/// <summary>
		/// System.Boolean m_bStartSpecAnim
		/// </summary>
		protected RField r_m_bStartSpecAnim;
		public virtual RField Rm_bStartSpecAnim
		{
			get
			{
				if(r_m_bStartSpecAnim == null)
				{
					r_m_bStartSpecAnim = new(this, "m_bStartSpecAnim");
					r_m_bStartSpecAnim.SetBelong(this.instance);
				}
				return r_m_bStartSpecAnim;
			}
		}

		/// <summary>
		/// System.String m_AnimPose
		/// </summary>
		protected RField r_m_AnimPose;
		public virtual RField Rm_AnimPose
		{
			get
			{
				if(r_m_AnimPose == null)
				{
					r_m_AnimPose = new(this, "m_AnimPose");
					r_m_AnimPose.SetBelong(this.instance);
				}
				return r_m_AnimPose;
			}
		}

		/// <summary>
		/// System.Boolean m_bStartIdleAnim
		/// </summary>
		protected RField r_m_bStartIdleAnim;
		public virtual RField Rm_bStartIdleAnim
		{
			get
			{
				if(r_m_bStartIdleAnim == null)
				{
					r_m_bStartIdleAnim = new(this, "m_bStartIdleAnim");
					r_m_bStartIdleAnim.SetBelong(this.instance);
				}
				return r_m_bStartIdleAnim;
			}
		}

		/// <summary>
		/// System.Single mBubbleTime
		/// </summary>
		protected RField r_mBubbleTime;
		public virtual RField RmBubbleTime
		{
			get
			{
				if(r_mBubbleTime == null)
				{
					r_mBubbleTime = new(this, "mBubbleTime");
					r_mBubbleTime.SetBelong(this.instance);
				}
				return r_mBubbleTime;
			}
		}

		/// <summary>
		/// System.Single mBubbleDeltaTime
		/// </summary>
		protected RField r_mBubbleDeltaTime;
		public virtual RField RmBubbleDeltaTime
		{
			get
			{
				if(r_mBubbleDeltaTime == null)
				{
					r_mBubbleDeltaTime = new(this, "mBubbleDeltaTime");
					r_mBubbleDeltaTime.SetBelong(this.instance);
				}
				return r_mBubbleDeltaTime;
			}
		}

		/// <summary>
		/// System.Single mBubbleInterval
		/// </summary>
		protected RField r_mBubbleInterval;
		public virtual RField RmBubbleInterval
		{
			get
			{
				if(r_mBubbleInterval == null)
				{
					r_mBubbleInterval = new(this, "mBubbleInterval");
					r_mBubbleInterval.SetBelong(this.instance);
				}
				return r_mBubbleInterval;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BubbleContent] bubbleLib
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBubbleContent> r_bubbleLib;
		public virtual RSystem.RCollections.RGeneric.RList<RBubbleContent> RbubbleLib
		{
			get
			{
				if(r_bubbleLib == null)
				{
					r_bubbleLib = new(this, "bubbleLib");
					r_bubbleLib.SetBelong(this.instance);
				}
				return r_bubbleLib;
			}
		}

		/// <summary>
		/// NpcBubbleData mBubbleData
		/// </summary>
		protected RNpcBubbleData r_mBubbleData;
		public virtual RNpcBubbleData RmBubbleData
		{
			get
			{
				if(r_mBubbleData == null)
				{
					r_mBubbleData = new(this, "mBubbleData");
					r_mBubbleData.SetBelong(this.instance);
				}
				return r_mBubbleData;
			}
		}

		/// <summary>
		/// System.Boolean m_bIsShowTips
		/// </summary>
		protected RField r_m_bIsShowTips;
		public virtual RField Rm_bIsShowTips
		{
			get
			{
				if(r_m_bIsShowTips == null)
				{
					r_m_bIsShowTips = new(this, "m_bIsShowTips");
					r_m_bIsShowTips.SetBelong(this.instance);
				}
				return r_m_bIsShowTips;
			}
		}

		/// <summary>
		/// System.Single m_fClickTime
		/// </summary>
		protected RField r_m_fClickTime;
		public virtual RField Rm_fClickTime
		{
			get
			{
				if(r_m_fClickTime == null)
				{
					r_m_fClickTime = new(this, "m_fClickTime");
					r_m_fClickTime.SetBelong(this.instance);
				}
				return r_m_fClickTime;
			}
		}

		/// <summary>
		/// System.String m_sSelection
		/// </summary>
		protected RField r_m_sSelection;
		public virtual RField Rm_sSelection
		{
			get
			{
				if(r_m_sSelection == null)
				{
					r_m_sSelection = new(this, "m_sSelection");
					r_m_sSelection.SetBelong(this.instance);
				}
				return r_m_sSelection;
			}
		}

		/// <summary>
		/// System.Boolean m_bUsingItem
		/// </summary>
		protected RField r_m_bUsingItem;
		public virtual RField Rm_bUsingItem
		{
			get
			{
				if(r_m_bUsingItem == null)
				{
					r_m_bUsingItem = new(this, "m_bUsingItem");
					r_m_bUsingItem.SetBelong(this.instance);
				}
				return r_m_bUsingItem;
			}
		}

		/// <summary>
		/// System.Boolean m_bMoveHide
		/// </summary>
		protected RField r_m_bMoveHide;
		public virtual RField Rm_bMoveHide
		{
			get
			{
				if(r_m_bMoveHide == null)
				{
					r_m_bMoveHide = new(this, "m_bMoveHide");
					r_m_bMoveHide.SetBelong(this.instance);
				}
				return r_m_bMoveHide;
			}
		}

		/// <summary>
		/// System.Single _timeInv
		/// </summary>
		protected RField r__timeInv;
		public virtual RField R_timeInv
		{
			get
			{
				if(r__timeInv == null)
				{
					r__timeInv = new(this, "_timeInv");
					r__timeInv.SetBelong(this.instance);
				}
				return r__timeInv;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_VecBornPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_VecBornPos;
		public virtual RUnityEngine.RVector3 Rm_VecBornPos
		{
			get
			{
				if(r_m_VecBornPos == null)
				{
					r_m_VecBornPos = new(this, "m_VecBornPos");
					r_m_VecBornPos.SetBelong(this.instance);
				}
				return r_m_VecBornPos;
			}
		}

		/// <summary>
		/// System.Single m_fLifeTime
		/// </summary>
		protected RField r_m_fLifeTime;
		public virtual RField Rm_fLifeTime
		{
			get
			{
				if(r_m_fLifeTime == null)
				{
					r_m_fLifeTime = new(this, "m_fLifeTime");
					r_m_fLifeTime.SetBelong(this.instance);
				}
				return r_m_fLifeTime;
			}
		}

		/// <summary>
		/// System.Boolean m_bNpcCameraOn
		/// </summary>
		protected RField r_m_bNpcCameraOn;
		public virtual RField Rm_bNpcCameraOn
		{
			get
			{
				if(r_m_bNpcCameraOn == null)
				{
					r_m_bNpcCameraOn = new(this, "m_bNpcCameraOn");
					r_m_bNpcCameraOn.SetBelong(this.instance);
				}
				return r_m_bNpcCameraOn;
			}
		}

		/// <summary>
		/// System.Boolean m_bIsGhostMove
		/// </summary>
		protected RField r_m_bIsGhostMove;
		public virtual RField Rm_bIsGhostMove
		{
			get
			{
				if(r_m_bIsGhostMove == null)
				{
					r_m_bIsGhostMove = new(this, "m_bIsGhostMove");
					r_m_bIsGhostMove.SetBelong(this.instance);
				}
				return r_m_bIsGhostMove;
			}
		}

		/// <summary>
		/// System.Boolean m_bIsInView
		/// </summary>
		protected RField r_m_bIsInView;
		public virtual RField Rm_bIsInView
		{
			get
			{
				if(r_m_bIsInView == null)
				{
					r_m_bIsInView = new(this, "m_bIsInView");
					r_m_bIsInView.SetBelong(this.instance);
				}
				return r_m_bIsInView;
			}
		}

		/// <summary>
		/// System.Single GhostRotSpeed
		/// </summary>
		protected RField r_GhostRotSpeed;
		public virtual RField RGhostRotSpeed
		{
			get
			{
				if(r_GhostRotSpeed == null)
				{
					r_GhostRotSpeed = new(this, "GhostRotSpeed");
					r_GhostRotSpeed.SetBelong(this.instance);
				}
				return r_GhostRotSpeed;
			}
		}

		/// <summary>
		/// System.Single GhostSpeed
		/// </summary>
		protected RField r_GhostSpeed;
		public virtual RField RGhostSpeed
		{
			get
			{
				if(r_GhostSpeed == null)
				{
					r_GhostSpeed = new(this, "GhostSpeed");
					r_GhostSpeed.SetBelong(this.instance);
				}
				return r_GhostSpeed;
			}
		}

		/// <summary>
		/// System.Single FixedTime
		/// </summary>
		protected RField r_FixedTime;
		public virtual RField RFixedTime
		{
			get
			{
				if(r_FixedTime == null)
				{
					r_FixedTime = new(this, "FixedTime");
					r_FixedTime.SetBelong(this.instance);
				}
				return r_FixedTime;
			}
		}

		/// <summary>
		/// System.Single DeltaTime
		/// </summary>
		protected RField r_DeltaTime;
		public virtual RField RDeltaTime
		{
			get
			{
				if(r_DeltaTime == null)
				{
					r_DeltaTime = new(this, "DeltaTime");
					r_DeltaTime.SetBelong(this.instance);
				}
				return r_DeltaTime;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 startPos
		/// </summary>
		protected RUnityEngine.RVector3 r_startPos;
		public virtual RUnityEngine.RVector3 RstartPos
		{
			get
			{
				if(r_startPos == null)
				{
					r_startPos = new(this, "startPos");
					r_startPos.SetBelong(this.instance);
				}
				return r_startPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 endPos
		/// </summary>
		protected RUnityEngine.RVector3 r_endPos;
		public virtual RUnityEngine.RVector3 RendPos
		{
			get
			{
				if(r_endPos == null)
				{
					r_endPos = new(this, "endPos");
					r_endPos.SetBelong(this.instance);
				}
				return r_endPos;
			}
		}

		/// <summary>
		/// System.Boolean bIsBreaken
		/// </summary>
		protected RField r_bIsBreaken;
		public virtual RField RbIsBreaken
		{
			get
			{
				if(r_bIsBreaken == null)
				{
					r_bIsBreaken = new(this, "bIsBreaken");
					r_bIsBreaken.SetBelong(this.instance);
				}
				return r_bIsBreaken;
			}
		}

		/// <summary>
		/// System.Int32 BREAK_TIME
		/// </summary>
		protected RField r_BREAK_TIME;
		public virtual RField RBREAK_TIME
		{
			get
			{
				if(r_BREAK_TIME == null)
				{
					r_BREAK_TIME = new(this, "BREAK_TIME");
					r_BREAK_TIME.SetBelong(this.instance);
				}
				return r_BREAK_TIME;
			}
		}

		/// <summary>
		/// System.Boolean m_bClientPatrol
		/// </summary>
		protected RField r_m_bClientPatrol;
		public virtual RField Rm_bClientPatrol
		{
			get
			{
				if(r_m_bClientPatrol == null)
				{
					r_m_bClientPatrol = new(this, "m_bClientPatrol");
					r_m_bClientPatrol.SetBelong(this.instance);
				}
				return r_m_bClientPatrol;
			}
		}

		/// <summary>
		/// System.Single m_fMaxPatrolTime
		/// </summary>
		protected RField r_m_fMaxPatrolTime;
		public virtual RField Rm_fMaxPatrolTime
		{
			get
			{
				if(r_m_fMaxPatrolTime == null)
				{
					r_m_fMaxPatrolTime = new(this, "m_fMaxPatrolTime");
					r_m_fMaxPatrolTime.SetBelong(this.instance);
				}
				return r_m_fMaxPatrolTime;
			}
		}

		/// <summary>
		/// System.Single m_fPatrolSpeed
		/// </summary>
		protected RField r_m_fPatrolSpeed;
		public virtual RField Rm_fPatrolSpeed
		{
			get
			{
				if(r_m_fPatrolSpeed == null)
				{
					r_m_fPatrolSpeed = new(this, "m_fPatrolSpeed");
					r_m_fPatrolSpeed.SetBelong(this.instance);
				}
				return r_m_fPatrolSpeed;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Vector3] m_VecPatrolPoints
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RVector3> r_m_VecPatrolPoints;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RVector3> Rm_VecPatrolPoints
		{
			get
			{
				if(r_m_VecPatrolPoints == null)
				{
					r_m_VecPatrolPoints = new(this, "m_VecPatrolPoints");
					r_m_VecPatrolPoints.SetBelong(this.instance);
				}
				return r_m_VecPatrolPoints;
			}
		}

		/// <summary>
		/// Pawn _pawn
		/// </summary>
		protected RPawn r__pawn;
		public virtual RPawn R_pawn
		{
			get
			{
				if(r__pawn == null)
				{
					r__pawn = new(this, "_pawn");
					r__pawn.SetBelong(this.instance);
				}
				return r__pawn;
			}
		}

		/// <summary>
		/// Creature m_CreatureInst
		/// </summary>
		protected RCreature r_m_CreatureInst;
		public virtual RCreature Rm_CreatureInst
		{
			get
			{
				if(r_m_CreatureInst == null)
				{
					r_m_CreatureInst = new(this, "m_CreatureInst");
					r_m_CreatureInst.SetBelong(this.instance);
				}
				return r_m_CreatureInst;
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
		/// System.Single _ViewCharacterDistan
		/// </summary>
		protected RField r__ViewCharacterDistan;
		public virtual RField R_ViewCharacterDistan
		{
			get
			{
				if(r__ViewCharacterDistan == null)
				{
					r__ViewCharacterDistan = new(this, "_ViewCharacterDistan");
					r__ViewCharacterDistan.SetBelong(this.instance);
				}
				return r__ViewCharacterDistan;
			}
		}

		/// <summary>
		/// System.Single _ViewDistanSqr
		/// </summary>
		protected RField r__ViewDistanSqr;
		public virtual RField R_ViewDistanSqr
		{
			get
			{
				if(r__ViewDistanSqr == null)
				{
					r__ViewDistanSqr = new(this, "_ViewDistanSqr");
					r__ViewDistanSqr.SetBelong(this.instance);
				}
				return r__ViewDistanSqr;
			}
		}

		/// <summary>
		/// CreatureBehav+IS_IN_VISION state
		/// </summary>
		protected RField r_state;
		public virtual RField Rstate
		{
			get
			{
				if(r_state == null)
				{
					r_state = new(this, "state");
					r_state.SetBelong(this.instance);
				}
				return r_state;
			}
		}

		/// <summary>
		/// System.Single FadeSpeed
		/// </summary>
		protected RField r_FadeSpeed;
		public virtual RField RFadeSpeed
		{
			get
			{
				if(r_FadeSpeed == null)
				{
					r_FadeSpeed = new(this, "FadeSpeed");
					r_FadeSpeed.SetBelong(this.instance);
				}
				return r_FadeSpeed;
			}
		}

		/// <summary>
		/// CreatureBehav+FadeType fadingType
		/// </summary>
		protected RField r_fadingType;
		public virtual RField RfadingType
		{
			get
			{
				if(r_fadingType == null)
				{
					r_fadingType = new(this, "fadingType");
					r_fadingType.SetBelong(this.instance);
				}
				return r_fadingType;
			}
		}

		/// <summary>
		/// System.Int32 DEFAULT_NAME_LABEL_HEIGHT
		/// </summary>
		protected RField r_DEFAULT_NAME_LABEL_HEIGHT;
		public virtual RField RDEFAULT_NAME_LABEL_HEIGHT
		{
			get
			{
				if(r_DEFAULT_NAME_LABEL_HEIGHT == null)
				{
					r_DEFAULT_NAME_LABEL_HEIGHT = new(this, "DEFAULT_NAME_LABEL_HEIGHT");
					r_DEFAULT_NAME_LABEL_HEIGHT.SetBelong(this.instance);
				}
				return r_DEFAULT_NAME_LABEL_HEIGHT;
			}
		}

		/// <summary>
		/// System.Boolean m_bMouseOver
		/// </summary>
		protected RField r_m_bMouseOver;
		public virtual RField Rm_bMouseOver
		{
			get
			{
				if(r_m_bMouseOver == null)
				{
					r_m_bMouseOver = new(this, "m_bMouseOver");
					r_m_bMouseOver.SetBelong(this.instance);
				}
				return r_m_bMouseOver;
			}
		}

		/// <summary>
		/// System.Boolean bShowName
		/// </summary>
		protected RField r_bShowName;
		public virtual RField RbShowName
		{
			get
			{
				if(r_bShowName == null)
				{
					r_bShowName = new(this, "bShowName");
					r_bShowName.SetBelong(this.instance);
				}
				return r_bShowName;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _mNameGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__mNameGUIStyle;
		public virtual RUnityEngine.RGUIStyle R_mNameGUIStyle
		{
			get
			{
				if(r__mNameGUIStyle == null)
				{
					r__mNameGUIStyle = new(this, "_mNameGUIStyle");
					r__mNameGUIStyle.SetBelong(this.instance);
				}
				return r__mNameGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _mNameGUIStyleInCombat
		/// </summary>
		protected RUnityEngine.RGUIStyle r__mNameGUIStyleInCombat;
		public virtual RUnityEngine.RGUIStyle R_mNameGUIStyleInCombat
		{
			get
			{
				if(r__mNameGUIStyleInCombat == null)
				{
					r__mNameGUIStyleInCombat = new(this, "_mNameGUIStyleInCombat");
					r__mNameGUIStyleInCombat.SetBelong(this.instance);
				}
				return r__mNameGUIStyleInCombat;
			}
		}

		/// <summary>
		/// System.String mName
		/// </summary>
		protected RField r_mName;
		public virtual RField RmName
		{
			get
			{
				if(r_mName == null)
				{
					r_mName = new(this, "mName");
					r_mName.SetBelong(this.instance);
				}
				return r_mName;
			}
		}

		/// <summary>
		/// System.Int32 m_NameStringLengthHalf
		/// </summary>
		protected RField r_m_NameStringLengthHalf;
		public virtual RField Rm_NameStringLengthHalf
		{
			get
			{
				if(r_m_NameStringLengthHalf == null)
				{
					r_m_NameStringLengthHalf = new(this, "m_NameStringLengthHalf");
					r_m_NameStringLengthHalf.SetBelong(this.instance);
				}
				return r_m_NameStringLengthHalf;
			}
		}

		/// <summary>
		/// System.Int32 m_NameStringHeight
		/// </summary>
		protected RField r_m_NameStringHeight;
		public virtual RField Rm_NameStringHeight
		{
			get
			{
				if(r_m_NameStringHeight == null)
				{
					r_m_NameStringHeight = new(this, "m_NameStringHeight");
					r_m_NameStringHeight.SetBelong(this.instance);
				}
				return r_m_NameStringHeight;
			}
		}

		/// <summary>
		/// System.String m_OriName
		/// </summary>
		protected RField r_m_OriName;
		public virtual RField Rm_OriName
		{
			get
			{
				if(r_m_OriName == null)
				{
					r_m_OriName = new(this, "m_OriName");
					r_m_OriName.SetBelong(this.instance);
				}
				return r_m_OriName;
			}
		}

		/// <summary>
		/// System.Boolean bShowFunc
		/// </summary>
		protected RField r_bShowFunc;
		public virtual RField RbShowFunc
		{
			get
			{
				if(r_bShowFunc == null)
				{
					r_bShowFunc = new(this, "bShowFunc");
					r_bShowFunc.SetBelong(this.instance);
				}
				return r_bShowFunc;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _mFunctionGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__mFunctionGUIStyle;
		public virtual RUnityEngine.RGUIStyle R_mFunctionGUIStyle
		{
			get
			{
				if(r__mFunctionGUIStyle == null)
				{
					r__mFunctionGUIStyle = new(this, "_mFunctionGUIStyle");
					r__mFunctionGUIStyle.SetBelong(this.instance);
				}
				return r__mFunctionGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Texture[] m_ExtraTitleIcons
		/// </summary>
		protected RFieldArray<RUnityEngine.RTexture> r_m_ExtraTitleIcons;
		public virtual RFieldArray<RUnityEngine.RTexture> Rm_ExtraTitleIcons
		{
			get
			{
				if(r_m_ExtraTitleIcons == null)
				{
					r_m_ExtraTitleIcons = new(this, "m_ExtraTitleIcons");
					r_m_ExtraTitleIcons.SetBelong(this.instance);
				}
				return r_m_ExtraTitleIcons;
			}
		}

		/// <summary>
		/// System.String[] m_ExtraTitleIconUrls
		/// </summary>
		protected RFieldArray<RField> r_m_ExtraTitleIconUrls;
		public virtual RFieldArray<RField> Rm_ExtraTitleIconUrls
		{
			get
			{
				if(r_m_ExtraTitleIconUrls == null)
				{
					r_m_ExtraTitleIconUrls = new(this, "m_ExtraTitleIconUrls");
					r_m_ExtraTitleIconUrls.SetBelong(this.instance);
				}
				return r_m_ExtraTitleIconUrls;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_FunctionIcon
		/// </summary>
		protected RUnityEngine.RTexture r_m_FunctionIcon;
		public virtual RUnityEngine.RTexture Rm_FunctionIcon
		{
			get
			{
				if(r_m_FunctionIcon == null)
				{
					r_m_FunctionIcon = new(this, "m_FunctionIcon");
					r_m_FunctionIcon.SetBelong(this.instance);
				}
				return r_m_FunctionIcon;
			}
		}

		/// <summary>
		/// System.String _FunctionIconUrl
		/// </summary>
		protected RField r__FunctionIconUrl;
		public virtual RField R_FunctionIconUrl
		{
			get
			{
				if(r__FunctionIconUrl == null)
				{
					r__FunctionIconUrl = new(this, "_FunctionIconUrl");
					r__FunctionIconUrl.SetBelong(this.instance);
				}
				return r__FunctionIconUrl;
			}
		}

		/// <summary>
		/// System.String mFunction
		/// </summary>
		protected RField r_mFunction;
		public virtual RField RmFunction
		{
			get
			{
				if(r_mFunction == null)
				{
					r_mFunction = new(this, "mFunction");
					r_mFunction.SetBelong(this.instance);
				}
				return r_mFunction;
			}
		}

		/// <summary>
		/// System.Int32 m_FunctionStringLengthHalf
		/// </summary>
		protected RField r_m_FunctionStringLengthHalf;
		public virtual RField Rm_FunctionStringLengthHalf
		{
			get
			{
				if(r_m_FunctionStringLengthHalf == null)
				{
					r_m_FunctionStringLengthHalf = new(this, "m_FunctionStringLengthHalf");
					r_m_FunctionStringLengthHalf.SetBelong(this.instance);
				}
				return r_m_FunctionStringLengthHalf;
			}
		}

		/// <summary>
		/// System.Int32 m_FunctionStringHeight
		/// </summary>
		protected RField r_m_FunctionStringHeight;
		public virtual RField Rm_FunctionStringHeight
		{
			get
			{
				if(r_m_FunctionStringHeight == null)
				{
					r_m_FunctionStringHeight = new(this, "m_FunctionStringHeight");
					r_m_FunctionStringHeight.SetBelong(this.instance);
				}
				return r_m_FunctionStringHeight;
			}
		}

		/// <summary>
		/// UnityEngine.Texture GMTitle
		/// </summary>
		protected RUnityEngine.RTexture r_GMTitle;
		public virtual RUnityEngine.RTexture RGMTitle
		{
			get
			{
				if(r_GMTitle == null)
				{
					r_GMTitle = new(this, "GMTitle");
					r_GMTitle.SetBelong(this.instance);
				}
				return r_GMTitle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 baseNameOffset3D
		/// </summary>
		protected RUnityEngine.RVector3 r_baseNameOffset3D;
		public virtual RUnityEngine.RVector3 RbaseNameOffset3D
		{
			get
			{
				if(r_baseNameOffset3D == null)
				{
					r_baseNameOffset3D = new(this, "baseNameOffset3D");
					r_baseNameOffset3D.SetBelong(this.instance);
				}
				return r_baseNameOffset3D;
			}
		}

		/// <summary>
		/// System.Single m_nameTextOffset2D
		/// </summary>
		protected RField r_m_nameTextOffset2D;
		public virtual RField Rm_nameTextOffset2D
		{
			get
			{
				if(r_m_nameTextOffset2D == null)
				{
					r_m_nameTextOffset2D = new(this, "m_nameTextOffset2D");
					r_m_nameTextOffset2D.SetBelong(this.instance);
				}
				return r_m_nameTextOffset2D;
			}
		}

		/// <summary>
		/// System.String _PostText
		/// </summary>
		protected RField r__PostText;
		public virtual RField R_PostText
		{
			get
			{
				if(r__PostText == null)
				{
					r__PostText = new(this, "_PostText");
					r__PostText.SetBelong(this.instance);
				}
				return r__PostText;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_PostColor
		/// </summary>
		protected RUnityEngine.RColor r_m_PostColor;
		public virtual RUnityEngine.RColor Rm_PostColor
		{
			get
			{
				if(r_m_PostColor == null)
				{
					r_m_PostColor = new(this, "m_PostColor");
					r_m_PostColor.SetBelong(this.instance);
				}
				return r_m_PostColor;
			}
		}

		/// <summary>
		/// System.Int32 mPostStringLengthHalf
		/// </summary>
		protected RField r_mPostStringLengthHalf;
		public virtual RField RmPostStringLengthHalf
		{
			get
			{
				if(r_mPostStringLengthHalf == null)
				{
					r_mPostStringLengthHalf = new(this, "mPostStringLengthHalf");
					r_mPostStringLengthHalf.SetBelong(this.instance);
				}
				return r_mPostStringLengthHalf;
			}
		}

		/// <summary>
		/// System.Int32 mPostStringHeight
		/// </summary>
		protected RField r_mPostStringHeight;
		public virtual RField RmPostStringHeight
		{
			get
			{
				if(r_mPostStringHeight == null)
				{
					r_mPostStringHeight = new(this, "mPostStringHeight");
					r_mPostStringHeight.SetBelong(this.instance);
				}
				return r_mPostStringHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _mPostGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__mPostGUIStyle;
		public virtual RUnityEngine.RGUIStyle R_mPostGUIStyle
		{
			get
			{
				if(r__mPostGUIStyle == null)
				{
					r__mPostGUIStyle = new(this, "_mPostGUIStyle");
					r__mPostGUIStyle.SetBelong(this.instance);
				}
				return r__mPostGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _mPostShadowStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__mPostShadowStyle;
		public virtual RUnityEngine.RGUIStyle R_mPostShadowStyle
		{
			get
			{
				if(r__mPostShadowStyle == null)
				{
					r__mPostShadowStyle = new(this, "_mPostShadowStyle");
					r__mPostShadowStyle.SetBelong(this.instance);
				}
				return r__mPostShadowStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_PostIcon
		/// </summary>
		protected RUnityEngine.RTexture r_m_PostIcon;
		public virtual RUnityEngine.RTexture Rm_PostIcon
		{
			get
			{
				if(r_m_PostIcon == null)
				{
					r_m_PostIcon = new(this, "m_PostIcon");
					r_m_PostIcon.SetBelong(this.instance);
				}
				return r_m_PostIcon;
			}
		}

		/// <summary>
		/// System.String _PostIconUrl
		/// </summary>
		protected RField r__PostIconUrl;
		public virtual RField R_PostIconUrl
		{
			get
			{
				if(r__PostIconUrl == null)
				{
					r__PostIconUrl = new(this, "_PostIconUrl");
					r__PostIconUrl.SetBelong(this.instance);
				}
				return r__PostIconUrl;
			}
		}

		/// <summary>
		/// System.Boolean _HasDiamond
		/// </summary>
		protected RField r__HasDiamond;
		public virtual RField R_HasDiamond
		{
			get
			{
				if(r__HasDiamond == null)
				{
					r__HasDiamond = new(this, "_HasDiamond");
					r__HasDiamond.SetBelong(this.instance);
				}
				return r__HasDiamond;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_VIPIcon
		/// </summary>
		protected RUnityEngine.RTexture r_m_VIPIcon;
		public virtual RUnityEngine.RTexture Rm_VIPIcon
		{
			get
			{
				if(r_m_VIPIcon == null)
				{
					r_m_VIPIcon = new(this, "m_VIPIcon");
					r_m_VIPIcon.SetBelong(this.instance);
				}
				return r_m_VIPIcon;
			}
		}

		/// <summary>
		/// CreatureBehav+LayoutMode layoutMode
		/// </summary>
		protected RField r_layoutMode;
		public virtual RField RlayoutMode
		{
			get
			{
				if(r_layoutMode == null)
				{
					r_layoutMode = new(this, "layoutMode");
					r_layoutMode.SetBelong(this.instance);
				}
				return r_layoutMode;
			}
		}

		/// <summary>
		/// CreatureBehav+BehaveMouseHandle MouseEnterEvent
		/// </summary>
		protected RCreatureBehav.RBehaveMouseHandle r_MouseEnterEvent;
		public virtual RCreatureBehav.RBehaveMouseHandle RMouseEnterEvent
		{
			get
			{
				if(r_MouseEnterEvent == null)
				{
					r_MouseEnterEvent = new(this, "MouseEnterEvent");
					r_MouseEnterEvent.SetBelong(this.instance);
				}
				return r_MouseEnterEvent;
			}
		}

		/// <summary>
		/// CreatureBehav+BehaveMouseHandle MouseOverEvent
		/// </summary>
		protected RCreatureBehav.RBehaveMouseHandle r_MouseOverEvent;
		public virtual RCreatureBehav.RBehaveMouseHandle RMouseOverEvent
		{
			get
			{
				if(r_MouseOverEvent == null)
				{
					r_MouseOverEvent = new(this, "MouseOverEvent");
					r_MouseOverEvent.SetBelong(this.instance);
				}
				return r_MouseOverEvent;
			}
		}

		/// <summary>
		/// CreatureBehav+BehaveMouseHandle MouseExitEvent
		/// </summary>
		protected RCreatureBehav.RBehaveMouseHandle r_MouseExitEvent;
		public virtual RCreatureBehav.RBehaveMouseHandle RMouseExitEvent
		{
			get
			{
				if(r_MouseExitEvent == null)
				{
					r_MouseExitEvent = new(this, "MouseExitEvent");
					r_MouseExitEvent.SetBelong(this.instance);
				}
				return r_MouseExitEvent;
			}
		}

		/// <summary>
		/// CreatureBehav+BehaveMouseHandle MouseDownEvent
		/// </summary>
		protected RCreatureBehav.RBehaveMouseHandle r_MouseDownEvent;
		public virtual RCreatureBehav.RBehaveMouseHandle RMouseDownEvent
		{
			get
			{
				if(r_MouseDownEvent == null)
				{
					r_MouseDownEvent = new(this, "MouseDownEvent");
					r_MouseDownEvent.SetBelong(this.instance);
				}
				return r_MouseDownEvent;
			}
		}

		/// <summary>
		/// System.Boolean isChangedCursor
		/// </summary>
		protected RField r_isChangedCursor;
		public virtual RField RisChangedCursor
		{
			get
			{
				if(r_isChangedCursor == null)
				{
					r_isChangedCursor = new(this, "isChangedCursor");
					r_isChangedCursor.SetBelong(this.instance);
				}
				return r_isChangedCursor;
			}
		}

		/// <summary>
		/// MouseState beforeChangeCursor
		/// </summary>
		protected RField r_beforeChangeCursor;
		public virtual RField RbeforeChangeCursor
		{
			get
			{
				if(r_beforeChangeCursor == null)
				{
					r_beforeChangeCursor = new(this, "beforeChangeCursor");
					r_beforeChangeCursor.SetBelong(this.instance);
				}
				return r_beforeChangeCursor;
			}
		}

		/// <summary>
		/// MouseState changeToCursor
		/// </summary>
		protected RField r_changeToCursor;
		public virtual RField RchangeToCursor
		{
			get
			{
				if(r_changeToCursor == null)
				{
					r_changeToCursor = new(this, "changeToCursor");
					r_changeToCursor.SetBelong(this.instance);
				}
				return r_changeToCursor;
			}
		}

		/// <summary>
		/// System.Boolean m_bCanClick
		/// </summary>
		protected RField r_m_bCanClick;
		public virtual RField Rm_bCanClick
		{
			get
			{
				if(r_m_bCanClick == null)
				{
					r_m_bCanClick = new(this, "m_bCanClick");
					r_m_bCanClick.SetBelong(this.instance);
				}
				return r_m_bCanClick;
			}
		}

		/// <summary>
		/// System.Single lastClickTime
		/// </summary>
		protected RField r_lastClickTime;
		public virtual RField RlastClickTime
		{
			get
			{
				if(r_lastClickTime == null)
				{
					r_lastClickTime = new(this, "lastClickTime");
					r_lastClickTime.SetBelong(this.instance);
				}
				return r_lastClickTime;
			}
		}

		/// <summary>
		/// System.Single CLICK_LIMIT_TIME
		/// </summary>
		protected RField r_CLICK_LIMIT_TIME;
		public virtual RField RCLICK_LIMIT_TIME
		{
			get
			{
				if(r_CLICK_LIMIT_TIME == null)
				{
					r_CLICK_LIMIT_TIME = new(this, "CLICK_LIMIT_TIME");
					r_CLICK_LIMIT_TIME.SetBelong(this.instance);
				}
				return r_CLICK_LIMIT_TIME;
			}
		}

		/// <summary>
		/// System.Boolean m_bShowMaxHp
		/// </summary>
		protected RField r_m_bShowMaxHp;
		public virtual RField Rm_bShowMaxHp
		{
			get
			{
				if(r_m_bShowMaxHp == null)
				{
					r_m_bShowMaxHp = new(this, "m_bShowMaxHp");
					r_m_bShowMaxHp.SetBelong(this.instance);
				}
				return r_m_bShowMaxHp;
			}
		}

		/// <summary>
		/// System.Single mHpBarDefineWidth
		/// </summary>
		protected RField r_mHpBarDefineWidth;
		public virtual RField RmHpBarDefineWidth
		{
			get
			{
				if(r_mHpBarDefineWidth == null)
				{
					r_mHpBarDefineWidth = new(this, "mHpBarDefineWidth");
					r_mHpBarDefineWidth.SetBelong(this.instance);
				}
				return r_mHpBarDefineWidth;
			}
		}

		/// <summary>
		/// System.Single mHpBarDefineHeight
		/// </summary>
		protected RField r_mHpBarDefineHeight;
		public virtual RField RmHpBarDefineHeight
		{
			get
			{
				if(r_mHpBarDefineHeight == null)
				{
					r_mHpBarDefineHeight = new(this, "mHpBarDefineHeight");
					r_mHpBarDefineHeight.SetBelong(this.instance);
				}
				return r_mHpBarDefineHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mBossHpRateGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mBossHpRateGUIStyle;
		public virtual RUnityEngine.RGUIStyle RmBossHpRateGUIStyle
		{
			get
			{
				if(r_mBossHpRateGUIStyle == null)
				{
					r_mBossHpRateGUIStyle = new(this, "mBossHpRateGUIStyle");
					r_mBossHpRateGUIStyle.SetBelong(this.instance);
				}
				return r_mBossHpRateGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mLoverNameGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mLoverNameGUIStyle;
		public virtual RUnityEngine.RGUIStyle RmLoverNameGUIStyle
		{
			get
			{
				if(r_mLoverNameGUIStyle == null)
				{
					r_mLoverNameGUIStyle = new(this, "mLoverNameGUIStyle");
					r_mLoverNameGUIStyle.SetBelong(this.instance);
				}
				return r_mLoverNameGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 mLoveNamePos
		/// </summary>
		protected RUnityEngine.RVector2 r_mLoveNamePos;
		public virtual RUnityEngine.RVector2 RmLoveNamePos
		{
			get
			{
				if(r_mLoveNamePos == null)
				{
					r_mLoveNamePos = new(this, "mLoveNamePos");
					r_mLoveNamePos.SetBelong(this.instance);
				}
				return r_mLoveNamePos;
			}
		}

		/// <summary>
		/// System.String m_LoveNameText
		/// </summary>
		protected RField r_m_LoveNameText;
		public virtual RField Rm_LoveNameText
		{
			get
			{
				if(r_m_LoveNameText == null)
				{
					r_m_LoveNameText = new(this, "m_LoveNameText");
					r_m_LoveNameText.SetBelong(this.instance);
				}
				return r_m_LoveNameText;
			}
		}

		/// <summary>
		/// System.Int32 m_nPopTextOffsetY
		/// </summary>
		protected RField r_m_nPopTextOffsetY;
		public virtual RField Rm_nPopTextOffsetY
		{
			get
			{
				if(r_m_nPopTextOffsetY == null)
				{
					r_m_nPopTextOffsetY = new(this, "m_nPopTextOffsetY");
					r_m_nPopTextOffsetY.SetBelong(this.instance);
				}
				return r_m_nPopTextOffsetY;
			}
		}

		/// <summary>
		/// System.Single m_fPopTextTime
		/// </summary>
		protected RField r_m_fPopTextTime;
		public virtual RField Rm_fPopTextTime
		{
			get
			{
				if(r_m_fPopTextTime == null)
				{
					r_m_fPopTextTime = new(this, "m_fPopTextTime");
					r_m_fPopTextTime.SetBelong(this.instance);
				}
				return r_m_fPopTextTime;
			}
		}

		/// <summary>
		/// System.String _sPopText
		/// </summary>
		protected RField r__sPopText;
		public virtual RField R_sPopText
		{
			get
			{
				if(r__sPopText == null)
				{
					r__sPopText = new(this, "_sPopText");
					r__sPopText.SetBelong(this.instance);
				}
				return r__sPopText;
			}
		}

		/// <summary>
		/// System.Int32 mPopTextLengthHalf
		/// </summary>
		protected RField r_mPopTextLengthHalf;
		public virtual RField RmPopTextLengthHalf
		{
			get
			{
				if(r_mPopTextLengthHalf == null)
				{
					r_mPopTextLengthHalf = new(this, "mPopTextLengthHalf");
					r_mPopTextLengthHalf.SetBelong(this.instance);
				}
				return r_mPopTextLengthHalf;
			}
		}

		/// <summary>
		/// System.Int32 mPopTextHeight
		/// </summary>
		protected RField r_mPopTextHeight;
		public virtual RField RmPopTextHeight
		{
			get
			{
				if(r_mPopTextHeight == null)
				{
					r_mPopTextHeight = new(this, "mPopTextHeight");
					r_mPopTextHeight.SetBelong(this.instance);
				}
				return r_mPopTextHeight;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _mPopTextGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__mPopTextGUIStyle;
		public virtual RUnityEngine.RGUIStyle R_mPopTextGUIStyle
		{
			get
			{
				if(r__mPopTextGUIStyle == null)
				{
					r__mPopTextGUIStyle = new(this, "_mPopTextGUIStyle");
					r__mPopTextGUIStyle.SetBelong(this.instance);
				}
				return r__mPopTextGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIContent _conten
		/// </summary>
		protected RUnityEngine.RGUIContent r__conten;
		public virtual RUnityEngine.RGUIContent R_conten
		{
			get
			{
				if(r__conten == null)
				{
					r__conten = new(this, "_conten");
					r__conten.SetBelong(this.instance);
				}
				return r__conten;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _progressBarStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__progressBarStyle;
		public virtual RUnityEngine.RGUIStyle R_progressBarStyle
		{
			get
			{
				if(r__progressBarStyle == null)
				{
					r__progressBarStyle = new(this, "_progressBarStyle");
					r__progressBarStyle.SetBelong(this.instance);
				}
				return r__progressBarStyle;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BubbleObject] mAllBubbl
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBubbleObject> r_mAllBubbl;
		public virtual RSystem.RCollections.RGeneric.RList<RBubbleObject> RmAllBubbl
		{
			get
			{
				if(r_mAllBubbl == null)
				{
					r_mAllBubbl = new(this, "mAllBubbl");
					r_mAllBubbl.SetBelong(this.instance);
				}
				return r_mAllBubbl;
			}
		}

		/// <summary>
		/// UnityEngine.Color mSelectColor
		/// </summary>
		protected RUnityEngine.RColor r_mSelectColor;
		public virtual RUnityEngine.RColor RmSelectColor
		{
			get
			{
				if(r_mSelectColor == null)
				{
					r_mSelectColor = new(this, "mSelectColor");
					r_mSelectColor.SetBelong(this.instance);
				}
				return r_mSelectColor;
			}
		}

		/// <summary>
		/// System.Boolean bPlayBigFace
		/// </summary>
		protected RField r_bPlayBigFace;
		public virtual RField RbPlayBigFace
		{
			get
			{
				if(r_bPlayBigFace == null)
				{
					r_bPlayBigFace = new(this, "bPlayBigFace");
					r_bPlayBigFace.SetBelong(this.instance);
				}
				return r_bPlayBigFace;
			}
		}

		/// <summary>
		/// System.Single m_EscortSpeed
		/// </summary>
		protected RField r_m_EscortSpeed;
		public virtual RField Rm_EscortSpeed
		{
			get
			{
				if(r_m_EscortSpeed == null)
				{
					r_m_EscortSpeed = new(this, "m_EscortSpeed");
					r_m_EscortSpeed.SetBelong(this.instance);
				}
				return r_m_EscortSpeed;
			}
		}

		/// <summary>
		/// NPC_DEFINE_TYPE NpcType
		/// </summary>
		protected RProperty r_NpcType;
		public virtual RProperty RNpcType
		{
			get
			{
				if(r_NpcType == null)
				{
					r_NpcType = new(this, "NpcType", -1);
					r_NpcType.SetBelong(this.instance);
				}
				return r_NpcType;
			}
		}

		/// <summary>
		/// NPC RefObj
		/// </summary>
		protected RNPC r_RefObj;
		public virtual RNPC RefObj
		{
			get
			{
				if(r_RefObj == null)
				{
					r_RefObj = new(this, "RefObj", -1);
					r_RefObj.SetBelong(this.instance);
				}
				return r_RefObj;
			}
		}

		/// <summary>
		/// Int32 RealTaskIconType
		/// </summary>
		protected RProperty r_RealTaskIconType;
		public virtual RProperty RealTaskIconType
		{
			get
			{
				if(r_RealTaskIconType == null)
				{
					r_RealTaskIconType = new(this, "RealTaskIconType", -1);
					r_RealTaskIconType.SetBelong(this.instance);
				}
				return r_RealTaskIconType;
			}
		}

		/// <summary>
		/// UnityEngine.CharacterController ctrl
		/// </summary>
		protected RUnityEngine.RCharacterController r_ctrl;
		public virtual RUnityEngine.RCharacterController Rctrl
		{
			get
			{
				if(r_ctrl == null)
				{
					r_ctrl = new(this, "ctrl", -1);
					r_ctrl.SetBelong(this.instance);
				}
				return r_ctrl;
			}
		}

		/// <summary>
		/// Seeker seeker
		/// </summary>
		protected RSeeker r_seeker;
		public virtual RSeeker Rseeker
		{
			get
			{
				if(r_seeker == null)
				{
					r_seeker = new(this, "seeker", -1);
					r_seeker.SetBelong(this.instance);
				}
				return r_seeker;
			}
		}

		/// <summary>
		/// Single m_modeScale
		/// </summary>
		protected RProperty r_m_modeScale;
		public virtual RProperty Rm_modeScale
		{
			get
			{
				if(r_m_modeScale == null)
				{
					r_m_modeScale = new(this, "m_modeScale", -1);
					r_m_modeScale.SetBelong(this.instance);
				}
				return r_m_modeScale;
			}
		}

		/// <summary>
		/// System.String m_Function
		/// </summary>
		protected RProperty r_m_Function;
		public virtual RProperty Rm_Function
		{
			get
			{
				if(r_m_Function == null)
				{
					r_m_Function = new(this, "m_Function", -1);
					r_m_Function.SetBelong(this.instance);
				}
				return r_m_Function;
			}
		}

		/// <summary>
		/// System.String OwnerName
		/// </summary>
		protected RProperty r_OwnerName;
		public virtual RProperty ROwnerName
		{
			get
			{
				if(r_OwnerName == null)
				{
					r_OwnerName = new(this, "OwnerName", -1);
					r_OwnerName.SetBelong(this.instance);
				}
				return r_OwnerName;
			}
		}

		/// <summary>
		/// UnityEngine.Animation animation
		/// </summary>
		protected RUnityEngine.RAnimation r_animation;
		public virtual RUnityEngine.RAnimation Ranimation
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
		/// System.String AutoSelection
		/// </summary>
		protected RProperty r_AutoSelection;
		public virtual RProperty RAutoSelection
		{
			get
			{
				if(r_AutoSelection == null)
				{
					r_AutoSelection = new(this, "AutoSelection", -1);
					r_AutoSelection.SetBelong(this.instance);
				}
				return r_AutoSelection;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 BornPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_BornPosition;
		public virtual RUnityEngine.RVector3 RBornPosition
		{
			get
			{
				if(r_BornPosition == null)
				{
					r_BornPosition = new(this, "BornPosition", -1);
					r_BornPosition.SetBelong(this.instance);
				}
				return r_BornPosition;
			}
		}

		/// <summary>
		/// Single LifeTime
		/// </summary>
		protected RProperty r_LifeTime;
		public virtual RProperty RLifeTime
		{
			get
			{
				if(r_LifeTime == null)
				{
					r_LifeTime = new(this, "LifeTime", -1);
					r_LifeTime.SetBelong(this.instance);
				}
				return r_LifeTime;
			}
		}

		/// <summary>
		/// Boolean IsNpcCameraOn
		/// </summary>
		protected RProperty r_IsNpcCameraOn;
		public virtual RProperty RIsNpcCameraOn
		{
			get
			{
				if(r_IsNpcCameraOn == null)
				{
					r_IsNpcCameraOn = new(this, "IsNpcCameraOn", -1);
					r_IsNpcCameraOn.SetBelong(this.instance);
				}
				return r_IsNpcCameraOn;
			}
		}

		/// <summary>
		/// Pawn m_Pawn
		/// </summary>
		protected RPawn r_m_Pawn;
		public virtual RPawn Rm_Pawn
		{
			get
			{
				if(r_m_Pawn == null)
				{
					r_m_Pawn = new(this, "m_Pawn", -1);
					r_m_Pawn.SetBelong(this.instance);
				}
				return r_m_Pawn;
			}
		}

		/// <summary>
		/// Creature CreatureInst
		/// </summary>
		protected RCreature r_CreatureInst;
		public virtual RCreature RCreatureInst
		{
			get
			{
				if(r_CreatureInst == null)
				{
					r_CreatureInst = new(this, "CreatureInst", -1);
					r_CreatureInst.SetBelong(this.instance);
				}
				return r_CreatureInst;
			}
		}

		/// <summary>
		/// UnityEngine.Renderer mCreatureRenderer
		/// </summary>
		protected RUnityEngine.RRenderer r_mCreatureRenderer;
		public virtual RUnityEngine.RRenderer RmCreatureRenderer
		{
			get
			{
				if(r_mCreatureRenderer == null)
				{
					r_mCreatureRenderer = new(this, "mCreatureRenderer", -1);
					r_mCreatureRenderer.SetBelong(this.instance);
				}
				return r_mCreatureRenderer;
			}
		}

		/// <summary>
		/// UnityEngine.Transform mTransform
		/// </summary>
		protected RUnityEngine.RTransform r_mTransform;
		public virtual RUnityEngine.RTransform RmTransform
		{
			get
			{
				if(r_mTransform == null)
				{
					r_mTransform = new(this, "mTransform", -1);
					r_mTransform.SetBelong(this.instance);
				}
				return r_mTransform;
			}
		}

		/// <summary>
		/// Single IconCreatureHeight
		/// </summary>
		protected RProperty r_IconCreatureHeight;
		public virtual RProperty RIconCreatureHeight
		{
			get
			{
				if(r_IconCreatureHeight == null)
				{
					r_IconCreatureHeight = new(this, "IconCreatureHeight", -1);
					r_IconCreatureHeight.SetBelong(this.instance);
				}
				return r_IconCreatureHeight;
			}
		}

		/// <summary>
		/// Single MaxSpeed
		/// </summary>
		protected RProperty r_MaxSpeed;
		public virtual RProperty RMaxSpeed
		{
			get
			{
				if(r_MaxSpeed == null)
				{
					r_MaxSpeed = new(this, "MaxSpeed", -1);
					r_MaxSpeed.SetBelong(this.instance);
				}
				return r_MaxSpeed;
			}
		}

		/// <summary>
		/// Single ViewCharacterDistan
		/// </summary>
		protected RProperty r_ViewCharacterDistan;
		public virtual RProperty RViewCharacterDistan
		{
			get
			{
				if(r_ViewCharacterDistan == null)
				{
					r_ViewCharacterDistan = new(this, "ViewCharacterDistan", -1);
					r_ViewCharacterDistan.SetBelong(this.instance);
				}
				return r_ViewCharacterDistan;
			}
		}

		/// <summary>
		/// Single ViewDistanSqr
		/// </summary>
		protected RProperty r_ViewDistanSqr;
		public virtual RProperty RViewDistanSqr
		{
			get
			{
				if(r_ViewDistanSqr == null)
				{
					r_ViewDistanSqr = new(this, "ViewDistanSqr", -1);
					r_ViewDistanSqr.SetBelong(this.instance);
				}
				return r_ViewDistanSqr;
			}
		}

		/// <summary>
		/// Boolean IsGuiNameDraw
		/// </summary>
		protected RProperty r_IsGuiNameDraw;
		public virtual RProperty RIsGuiNameDraw
		{
			get
			{
				if(r_IsGuiNameDraw == null)
				{
					r_IsGuiNameDraw = new(this, "IsGuiNameDraw", -1);
					r_IsGuiNameDraw.SetBelong(this.instance);
				}
				return r_IsGuiNameDraw;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mNameGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mNameGUIStyle;
		public virtual RUnityEngine.RGUIStyle RmNameGUIStyle
		{
			get
			{
				if(r_mNameGUIStyle == null)
				{
					r_mNameGUIStyle = new(this, "mNameGUIStyle", -1);
					r_mNameGUIStyle.SetBelong(this.instance);
				}
				return r_mNameGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mNameGUIStyleInCombat
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mNameGUIStyleInCombat;
		public virtual RUnityEngine.RGUIStyle RmNameGUIStyleInCombat
		{
			get
			{
				if(r_mNameGUIStyleInCombat == null)
				{
					r_mNameGUIStyleInCombat = new(this, "mNameGUIStyleInCombat", -1);
					r_mNameGUIStyleInCombat.SetBelong(this.instance);
				}
				return r_mNameGUIStyleInCombat;
			}
		}

		/// <summary>
		/// System.String m_Name
		/// </summary>
		protected RProperty r_m_Name;
		public virtual RProperty Rm_Name
		{
			get
			{
				if(r_m_Name == null)
				{
					r_m_Name = new(this, "m_Name", -1);
					r_m_Name.SetBelong(this.instance);
				}
				return r_m_Name;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mFunctionGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mFunctionGUIStyle;
		public virtual RUnityEngine.RGUIStyle RmFunctionGUIStyle
		{
			get
			{
				if(r_mFunctionGUIStyle == null)
				{
					r_mFunctionGUIStyle = new(this, "mFunctionGUIStyle", -1);
					r_mFunctionGUIStyle.SetBelong(this.instance);
				}
				return r_mFunctionGUIStyle;
			}
		}

		/// <summary>
		/// System.String m_FunctionIconUrl
		/// </summary>
		protected RProperty r_m_FunctionIconUrl_String;
		public virtual RProperty Rm_FunctionIconUrl_String
		{
			get
			{
				if(r_m_FunctionIconUrl_String == null)
				{
					r_m_FunctionIconUrl_String = new(this, "m_FunctionIconUrl", -1, typeof(System.String));
					r_m_FunctionIconUrl_String.SetBelong(this.instance);
				}
				return r_m_FunctionIconUrl_String;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_GMTitle
		/// </summary>
		protected RUnityEngine.RTexture r_m_GMTitle;
		public virtual RUnityEngine.RTexture Rm_GMTitle
		{
			get
			{
				if(r_m_GMTitle == null)
				{
					r_m_GMTitle = new(this, "m_GMTitle", -1);
					r_m_GMTitle.SetBelong(this.instance);
				}
				return r_m_GMTitle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 NameTextOffset3D
		/// </summary>
		protected RUnityEngine.RVector3 r_NameTextOffset3D;
		public virtual RUnityEngine.RVector3 RNameTextOffset3D
		{
			get
			{
				if(r_NameTextOffset3D == null)
				{
					r_NameTextOffset3D = new(this, "NameTextOffset3D", -1);
					r_NameTextOffset3D.SetBelong(this.instance);
				}
				return r_NameTextOffset3D;
			}
		}

		/// <summary>
		/// Single NameTextOffset2D
		/// </summary>
		protected RProperty r_NameTextOffset2D;
		public virtual RProperty RNameTextOffset2D
		{
			get
			{
				if(r_NameTextOffset2D == null)
				{
					r_NameTextOffset2D = new(this, "NameTextOffset2D", -1);
					r_NameTextOffset2D.SetBelong(this.instance);
				}
				return r_NameTextOffset2D;
			}
		}

		/// <summary>
		/// System.String m_PostText
		/// </summary>
		protected RProperty r_m_PostText;
		public virtual RProperty Rm_PostText
		{
			get
			{
				if(r_m_PostText == null)
				{
					r_m_PostText = new(this, "m_PostText", -1);
					r_m_PostText.SetBelong(this.instance);
				}
				return r_m_PostText;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mPostGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mPostGUIStyle;
		public virtual RUnityEngine.RGUIStyle RmPostGUIStyle
		{
			get
			{
				if(r_mPostGUIStyle == null)
				{
					r_mPostGUIStyle = new(this, "mPostGUIStyle", -1);
					r_mPostGUIStyle.SetBelong(this.instance);
				}
				return r_mPostGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mPostShadowStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mPostShadowStyle;
		public virtual RUnityEngine.RGUIStyle RmPostShadowStyle
		{
			get
			{
				if(r_mPostShadowStyle == null)
				{
					r_mPostShadowStyle = new(this, "mPostShadowStyle", -1);
					r_mPostShadowStyle.SetBelong(this.instance);
				}
				return r_mPostShadowStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Texture PostIcon
		/// </summary>
		protected RUnityEngine.RTexture r_PostIcon;
		public virtual RUnityEngine.RTexture RPostIcon
		{
			get
			{
				if(r_PostIcon == null)
				{
					r_PostIcon = new(this, "PostIcon", -1);
					r_PostIcon.SetBelong(this.instance);
				}
				return r_PostIcon;
			}
		}

		/// <summary>
		/// System.String m_PostIconUrl
		/// </summary>
		protected RProperty r_m_PostIconUrl_String;
		public virtual RProperty Rm_PostIconUrl_String
		{
			get
			{
				if(r_m_PostIconUrl_String == null)
				{
					r_m_PostIconUrl_String = new(this, "m_PostIconUrl", -1, typeof(System.String));
					r_m_PostIconUrl_String.SetBelong(this.instance);
				}
				return r_m_PostIconUrl_String;
			}
		}

		/// <summary>
		/// Boolean HasDiamond
		/// </summary>
		protected RProperty r_HasDiamond;
		public virtual RProperty RHasDiamond
		{
			get
			{
				if(r_HasDiamond == null)
				{
					r_HasDiamond = new(this, "HasDiamond", -1);
					r_HasDiamond.SetBelong(this.instance);
				}
				return r_HasDiamond;
			}
		}

		/// <summary>
		/// UnityEngine.Texture VIPIcon
		/// </summary>
		protected RUnityEngine.RTexture r_VIPIcon;
		public virtual RUnityEngine.RTexture RVIPIcon
		{
			get
			{
				if(r_VIPIcon == null)
				{
					r_VIPIcon = new(this, "VIPIcon", -1);
					r_VIPIcon.SetBelong(this.instance);
				}
				return r_VIPIcon;
			}
		}

		/// <summary>
		/// Int32 MaxHealthPoint
		/// </summary>
		protected RProperty r_MaxHealthPoint;
		public virtual RProperty RMaxHealthPoint
		{
			get
			{
				if(r_MaxHealthPoint == null)
				{
					r_MaxHealthPoint = new(this, "MaxHealthPoint", -1);
					r_MaxHealthPoint.SetBelong(this.instance);
				}
				return r_MaxHealthPoint;
			}
		}

		/// <summary>
		/// Boolean ShowMaxHp
		/// </summary>
		protected RProperty r_ShowMaxHp;
		public virtual RProperty RShowMaxHp
		{
			get
			{
				if(r_ShowMaxHp == null)
				{
					r_ShowMaxHp = new(this, "ShowMaxHp", -1);
					r_ShowMaxHp.SetBelong(this.instance);
				}
				return r_ShowMaxHp;
			}
		}

		/// <summary>
		/// Int32 HealthPoint
		/// </summary>
		protected RProperty r_HealthPoint;
		public virtual RProperty RHealthPoint
		{
			get
			{
				if(r_HealthPoint == null)
				{
					r_HealthPoint = new(this, "HealthPoint", -1);
					r_HealthPoint.SetBelong(this.instance);
				}
				return r_HealthPoint;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle BossHpRateGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_BossHpRateGUIStyle;
		public virtual RUnityEngine.RGUIStyle RBossHpRateGUIStyle
		{
			get
			{
				if(r_BossHpRateGUIStyle == null)
				{
					r_BossHpRateGUIStyle = new(this, "BossHpRateGUIStyle", -1);
					r_BossHpRateGUIStyle.SetBelong(this.instance);
				}
				return r_BossHpRateGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle LoverNameGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_LoverNameGUIStyle;
		public virtual RUnityEngine.RGUIStyle RLoverNameGUIStyle
		{
			get
			{
				if(r_LoverNameGUIStyle == null)
				{
					r_LoverNameGUIStyle = new(this, "LoverNameGUIStyle", -1);
					r_LoverNameGUIStyle.SetBelong(this.instance);
				}
				return r_LoverNameGUIStyle;
			}
		}

		/// <summary>
		/// System.String m_sPopText
		/// </summary>
		protected RProperty r_m_sPopText;
		public virtual RProperty Rm_sPopText
		{
			get
			{
				if(r_m_sPopText == null)
				{
					r_m_sPopText = new(this, "m_sPopText", -1);
					r_m_sPopText.SetBelong(this.instance);
				}
				return r_m_sPopText;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mPopTextGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mPopTextGUIStyle;
		public virtual RUnityEngine.RGUIStyle RmPopTextGUIStyle
		{
			get
			{
				if(r_mPopTextGUIStyle == null)
				{
					r_mPopTextGUIStyle = new(this, "mPopTextGUIStyle", -1);
					r_mPopTextGUIStyle.SetBelong(this.instance);
				}
				return r_mPopTextGUIStyle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 PopTextPos
		/// </summary>
		protected RUnityEngine.RVector2 r_PopTextPos;
		public virtual RUnityEngine.RVector2 RPopTextPos
		{
			get
			{
				if(r_PopTextPos == null)
				{
					r_PopTextPos = new(this, "PopTextPos", -1);
					r_PopTextPos.SetBelong(this.instance);
				}
				return r_PopTextPos;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_ProgressBarStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_ProgressBarStyle;
		public virtual RUnityEngine.RGUIStyle Rm_ProgressBarStyle
		{
			get
			{
				if(r_m_ProgressBarStyle == null)
				{
					r_m_ProgressBarStyle = new(this, "m_ProgressBarStyle", -1);
					r_m_ProgressBarStyle.SetBelong(this.instance);
				}
				return r_m_ProgressBarStyle;
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
		/// Void OnBecameVisible()
		/// </summary>
		protected RMethod r_ROnBecameVisible;
		public virtual RMethod ROnBecameVisible
		{
			get
			{
				if(r_ROnBecameVisible == null)
				{
					r_ROnBecameVisible = new(this, "OnBecameVisible", 0);
					r_ROnBecameVisible.SetBelong(this.instance);
				}
				return r_ROnBecameVisible;
			}
		}

		/// <summary>
		/// Void OnBecameInvisible()
		/// </summary>
		protected RMethod r_ROnBecameInvisible;
		public virtual RMethod ROnBecameInvisible
		{
			get
			{
				if(r_ROnBecameInvisible == null)
				{
					r_ROnBecameInvisible = new(this, "OnBecameInvisible", 0);
					r_ROnBecameInvisible.SetBelong(this.instance);
				}
				return r_ROnBecameInvisible;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_RInit;
		public virtual RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(this, "Init", 0);
					r_RInit.SetBelong(this.instance);
				}
				return r_RInit;
			}
		}

		/// <summary>
		/// Void StartDownLand()
		/// </summary>
		protected RMethod r_RStartDownLand;
		public virtual RMethod RStartDownLand
		{
			get
			{
				if(r_RStartDownLand == null)
				{
					r_RStartDownLand = new(this, "StartDownLand", 0);
					r_RStartDownLand.SetBelong(this.instance);
				}
				return r_RStartDownLand;
			}
		}

		/// <summary>
		/// Void OnDownLand()
		/// </summary>
		protected RMethod r_ROnDownLand;
		public virtual RMethod ROnDownLand
		{
			get
			{
				if(r_ROnDownLand == null)
				{
					r_ROnDownLand = new(this, "OnDownLand", 0);
					r_ROnDownLand.SetBelong(this.instance);
				}
				return r_ROnDownLand;
			}
		}

		/// <summary>
		/// Void SetVisible(Boolean, UnityEngine.Transform)
		/// </summary>
		protected static RMethod r_RSetVisible_Boolean_Transform;
		public static RMethod RSetVisible_Boolean_Transform
		{
			get
			{
				if(r_RSetVisible_Boolean_Transform == null)
				{
					r_RSetVisible_Boolean_Transform = new( ReleactionUtils.GetType("NPCBehav"), "SetVisible", 0, typeof(System.Boolean), typeof(UnityEngine.Transform));
					r_RSetVisible_Boolean_Transform.SetBelong(null);
				}
				return r_RSetVisible_Boolean_Transform;
			}
		}

		/// <summary>
		/// Creature SearchTargetInRange()
		/// </summary>
		protected RMethod r_RSearchTargetInRange;
		public virtual RMethod RSearchTargetInRange
		{
			get
			{
				if(r_RSearchTargetInRange == null)
				{
					r_RSearchTargetInRange = new(this, "SearchTargetInRange", 0);
					r_RSearchTargetInRange.SetBelong(this.instance);
				}
				return r_RSearchTargetInRange;
			}
		}

		/// <summary>
		/// Void NPCAIUpdate(Single)
		/// </summary>
		protected RMethod r_RNPCAIUpdate_Single;
		public virtual RMethod RNPCAIUpdate_Single
		{
			get
			{
				if(r_RNPCAIUpdate_Single == null)
				{
					r_RNPCAIUpdate_Single = new(this, "NPCAIUpdate", 0, typeof(System.Single));
					r_RNPCAIUpdate_Single.SetBelong(this.instance);
				}
				return r_RNPCAIUpdate_Single;
			}
		}

		/// <summary>
		/// Void SendMoveMsg(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSendMoveMsg_Vector3;
		public virtual RMethod RSendMoveMsg_Vector3
		{
			get
			{
				if(r_RSendMoveMsg_Vector3 == null)
				{
					r_RSendMoveMsg_Vector3 = new(this, "SendMoveMsg", 0, typeof(UnityEngine.Vector3));
					r_RSendMoveMsg_Vector3.SetBelong(this.instance);
				}
				return r_RSendMoveMsg_Vector3;
			}
		}

		/// <summary>
		/// Void GoTo(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RGoTo_Vector3_Single;
		public virtual RMethod RGoTo_Vector3_Single
		{
			get
			{
				if(r_RGoTo_Vector3_Single == null)
				{
					r_RGoTo_Vector3_Single = new(this, "GoTo", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RGoTo_Vector3_Single.SetBelong(this.instance);
				}
				return r_RGoTo_Vector3_Single;
			}
		}

		/// <summary>
		/// Void Pursuit()
		/// </summary>
		protected RMethod r_RPursuit;
		public virtual RMethod RPursuit
		{
			get
			{
				if(r_RPursuit == null)
				{
					r_RPursuit = new(this, "Pursuit", 0);
					r_RPursuit.SetBelong(this.instance);
				}
				return r_RPursuit;
			}
		}

		/// <summary>
		/// Void Flee()
		/// </summary>
		protected RMethod r_RFlee;
		public virtual RMethod RFlee
		{
			get
			{
				if(r_RFlee == null)
				{
					r_RFlee = new(this, "Flee", 0);
					r_RFlee.SetBelong(this.instance);
				}
				return r_RFlee;
			}
		}

		/// <summary>
		/// Void ReturnToBirthPoint(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RReturnToBirthPoint_Vector3;
		public virtual RMethod RReturnToBirthPoint_Vector3
		{
			get
			{
				if(r_RReturnToBirthPoint_Vector3 == null)
				{
					r_RReturnToBirthPoint_Vector3 = new(this, "ReturnToBirthPoint", 0, typeof(UnityEngine.Vector3));
					r_RReturnToBirthPoint_Vector3.SetBelong(this.instance);
				}
				return r_RReturnToBirthPoint_Vector3;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_RStart;
		public virtual RMethod RStart
		{
			get
			{
				if(r_RStart == null)
				{
					r_RStart = new(this, "Start", 0);
					r_RStart.SetBelong(this.instance);
				}
				return r_RStart;
			}
		}

		/// <summary>
		/// Void Awake()
		/// </summary>
		protected RMethod r_RAwake;
		public virtual RMethod RAwake
		{
			get
			{
				if(r_RAwake == null)
				{
					r_RAwake = new(this, "Awake", 0);
					r_RAwake.SetBelong(this.instance);
				}
				return r_RAwake;
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
		/// Void UpdateMovement()
		/// </summary>
		protected RMethod r_RUpdateMovement;
		public virtual RMethod RUpdateMovement
		{
			get
			{
				if(r_RUpdateMovement == null)
				{
					r_RUpdateMovement = new(this, "UpdateMovement", 0);
					r_RUpdateMovement.SetBelong(this.instance);
				}
				return r_RUpdateMovement;
			}
		}

		/// <summary>
		/// Void SetDialogOpen(Boolean)
		/// </summary>
		protected RMethod r_RSetDialogOpen_Boolean;
		public virtual RMethod RSetDialogOpen_Boolean
		{
			get
			{
				if(r_RSetDialogOpen_Boolean == null)
				{
					r_RSetDialogOpen_Boolean = new(this, "SetDialogOpen", 0, typeof(System.Boolean));
					r_RSetDialogOpen_Boolean.SetBelong(this.instance);
				}
				return r_RSetDialogOpen_Boolean;
			}
		}

		/// <summary>
		/// Void OnSearchCompleted()
		/// </summary>
		protected RMethod r_ROnSearchCompleted;
		public virtual RMethod ROnSearchCompleted
		{
			get
			{
				if(r_ROnSearchCompleted == null)
				{
					r_ROnSearchCompleted = new(this, "OnSearchCompleted", 0);
					r_ROnSearchCompleted.SetBelong(this.instance);
				}
				return r_ROnSearchCompleted;
			}
		}

		/// <summary>
		/// Void SetAnimationState()
		/// </summary>
		protected RMethod r_RSetAnimationState;
		public virtual RMethod RSetAnimationState
		{
			get
			{
				if(r_RSetAnimationState == null)
				{
					r_RSetAnimationState = new(this, "SetAnimationState", 0);
					r_RSetAnimationState.SetBelong(this.instance);
				}
				return r_RSetAnimationState;
			}
		}

		/// <summary>
		/// Void PlayAnim(System.String, Boolean, Int32)
		/// </summary>
		protected RMethod r_RPlayAnim_String_Boolean_Int32;
		public virtual RMethod RPlayAnim_String_Boolean_Int32
		{
			get
			{
				if(r_RPlayAnim_String_Boolean_Int32 == null)
				{
					r_RPlayAnim_String_Boolean_Int32 = new(this, "PlayAnim", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int32));
					r_RPlayAnim_String_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RPlayAnim_String_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void PlayAnim(System.String, Boolean, Int32, Single)
		/// </summary>
		protected RMethod r_RPlayAnim_String_Boolean_Int32_Single;
		public virtual RMethod RPlayAnim_String_Boolean_Int32_Single
		{
			get
			{
				if(r_RPlayAnim_String_Boolean_Int32_Single == null)
				{
					r_RPlayAnim_String_Boolean_Int32_Single = new(this, "PlayAnim", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int32), typeof(System.Single));
					r_RPlayAnim_String_Boolean_Int32_Single.SetBelong(this.instance);
				}
				return r_RPlayAnim_String_Boolean_Int32_Single;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator PlayAnimDelay(System.String, Boolean, Int32, Single)
		/// </summary>
		protected RMethod r_RPlayAnimDelay_String_Boolean_Int32_Single;
		public virtual RMethod RPlayAnimDelay_String_Boolean_Int32_Single
		{
			get
			{
				if(r_RPlayAnimDelay_String_Boolean_Int32_Single == null)
				{
					r_RPlayAnimDelay_String_Boolean_Int32_Single = new(this, "PlayAnimDelay", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Int32), typeof(System.Single));
					r_RPlayAnimDelay_String_Boolean_Int32_Single.SetBelong(this.instance);
				}
				return r_RPlayAnimDelay_String_Boolean_Int32_Single;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator AnimationCullTypeReset(UnityEngine.Animation, Single)
		/// </summary>
		protected RMethod r_RAnimationCullTypeReset_Animation_Single;
		public virtual RMethod RAnimationCullTypeReset_Animation_Single
		{
			get
			{
				if(r_RAnimationCullTypeReset_Animation_Single == null)
				{
					r_RAnimationCullTypeReset_Animation_Single = new(this, "AnimationCullTypeReset", 0, typeof(UnityEngine.Animation), typeof(System.Single));
					r_RAnimationCullTypeReset_Animation_Single.SetBelong(this.instance);
				}
				return r_RAnimationCullTypeReset_Animation_Single;
			}
		}

		/// <summary>
		/// Void UpdateSpecAnim()
		/// </summary>
		protected RMethod r_RUpdateSpecAnim;
		public virtual RMethod RUpdateSpecAnim
		{
			get
			{
				if(r_RUpdateSpecAnim == null)
				{
					r_RUpdateSpecAnim = new(this, "UpdateSpecAnim", 0);
					r_RUpdateSpecAnim.SetBelong(this.instance);
				}
				return r_RUpdateSpecAnim;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator WaitForSpecAnim()
		/// </summary>
		protected RMethod r_RWaitForSpecAnim;
		public virtual RMethod RWaitForSpecAnim
		{
			get
			{
				if(r_RWaitForSpecAnim == null)
				{
					r_RWaitForSpecAnim = new(this, "WaitForSpecAnim", 0);
					r_RWaitForSpecAnim.SetBelong(this.instance);
				}
				return r_RWaitForSpecAnim;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator WaitForIdleAnim(Single)
		/// </summary>
		protected RMethod r_RWaitForIdleAnim_Single;
		public virtual RMethod RWaitForIdleAnim_Single
		{
			get
			{
				if(r_RWaitForIdleAnim_Single == null)
				{
					r_RWaitForIdleAnim_Single = new(this, "WaitForIdleAnim", 0, typeof(System.Single));
					r_RWaitForIdleAnim_Single.SetBelong(this.instance);
				}
				return r_RWaitForIdleAnim_Single;
			}
		}

		/// <summary>
		/// Void UpdateAnim()
		/// </summary>
		protected RMethod r_RUpdateAnim;
		public virtual RMethod RUpdateAnim
		{
			get
			{
				if(r_RUpdateAnim == null)
				{
					r_RUpdateAnim = new(this, "UpdateAnim", 0);
					r_RUpdateAnim.SetBelong(this.instance);
				}
				return r_RUpdateAnim;
			}
		}

		/// <summary>
		/// Void CrossFadeAnim(System.String, Boolean)
		/// </summary>
		protected RMethod r_RCrossFadeAnim_String_Boolean;
		public virtual RMethod RCrossFadeAnim_String_Boolean
		{
			get
			{
				if(r_RCrossFadeAnim_String_Boolean == null)
				{
					r_RCrossFadeAnim_String_Boolean = new(this, "CrossFadeAnim", 0, typeof(System.String), typeof(System.Boolean));
					r_RCrossFadeAnim_String_Boolean.SetBelong(this.instance);
				}
				return r_RCrossFadeAnim_String_Boolean;
			}
		}

		/// <summary>
		/// Void InitBubble()
		/// </summary>
		protected RMethod r_RInitBubble;
		public virtual RMethod RInitBubble
		{
			get
			{
				if(r_RInitBubble == null)
				{
					r_RInitBubble = new(this, "InitBubble", 0);
					r_RInitBubble.SetBelong(this.instance);
				}
				return r_RInitBubble;
			}
		}

		/// <summary>
		/// Void OnNpcBubble(Int32)
		/// </summary>
		protected RMethod r_ROnNpcBubble_Int32;
		public virtual RMethod ROnNpcBubble_Int32
		{
			get
			{
				if(r_ROnNpcBubble_Int32 == null)
				{
					r_ROnNpcBubble_Int32 = new(this, "OnNpcBubble", 0, typeof(System.Int32));
					r_ROnNpcBubble_Int32.SetBelong(this.instance);
				}
				return r_ROnNpcBubble_Int32;
			}
		}

		/// <summary>
		/// Void OnNpcBubbleRandom()
		/// </summary>
		protected RMethod r_ROnNpcBubbleRandom;
		public virtual RMethod ROnNpcBubbleRandom
		{
			get
			{
				if(r_ROnNpcBubbleRandom == null)
				{
					r_ROnNpcBubbleRandom = new(this, "OnNpcBubbleRandom", 0);
					r_ROnNpcBubbleRandom.SetBelong(this.instance);
				}
				return r_ROnNpcBubbleRandom;
			}
		}

		/// <summary>
		/// Void ShowNpcBubbleList(System.Collections.Generic.List`1[BubbleContent])
		/// </summary>
		protected RMethod r_RShowNpcBubbleList_List_d_BubbleContent_p_;
		public virtual RMethod RShowNpcBubbleList_List_d_BubbleContent_p_
		{
			get
			{
				if(r_RShowNpcBubbleList_List_d_BubbleContent_p_ == null)
				{
					r_RShowNpcBubbleList_List_d_BubbleContent_p_ = new(this, "ShowNpcBubbleList", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(BubbleContent)));
					r_RShowNpcBubbleList_List_d_BubbleContent_p_.SetBelong(this.instance);
				}
				return r_RShowNpcBubbleList_List_d_BubbleContent_p_;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ShowNpcBubble(NpcBubbleArg)
		/// </summary>
		protected RMethod r_RShowNpcBubble_NpcBubbleArg;
		public virtual RMethod RShowNpcBubble_NpcBubbleArg
		{
			get
			{
				if(r_RShowNpcBubble_NpcBubbleArg == null)
				{
					r_RShowNpcBubble_NpcBubbleArg = new(this, "ShowNpcBubble", 0,  ReleactionUtils.GetType("NPCBehav+NpcBubbleArg"));
					r_RShowNpcBubble_NpcBubbleArg.SetBelong(this.instance);
				}
				return r_RShowNpcBubble_NpcBubbleArg;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ShowNpcBubble(BubbleContent, Single)
		/// </summary>
		protected RMethod r_RShowNpcBubble_BubbleContent_Single;
		public virtual RMethod RShowNpcBubble_BubbleContent_Single
		{
			get
			{
				if(r_RShowNpcBubble_BubbleContent_Single == null)
				{
					r_RShowNpcBubble_BubbleContent_Single = new(this, "ShowNpcBubble", 0, typeof(BubbleContent), typeof(System.Single));
					r_RShowNpcBubble_BubbleContent_Single.SetBelong(this.instance);
				}
				return r_RShowNpcBubble_BubbleContent_Single;
			}
		}

		/// <summary>
		/// Void _OnMouseEnter()
		/// </summary>
		protected RMethod r_R_OnMouseEnter;
		public virtual RMethod R_OnMouseEnter
		{
			get
			{
				if(r_R_OnMouseEnter == null)
				{
					r_R_OnMouseEnter = new(this, "_OnMouseEnter", 0);
					r_R_OnMouseEnter.SetBelong(this.instance);
				}
				return r_R_OnMouseEnter;
			}
		}

		/// <summary>
		/// Void _OnMouseOver()
		/// </summary>
		protected RMethod r_R_OnMouseOver;
		public virtual RMethod R_OnMouseOver
		{
			get
			{
				if(r_R_OnMouseOver == null)
				{
					r_R_OnMouseOver = new(this, "_OnMouseOver", 0);
					r_R_OnMouseOver.SetBelong(this.instance);
				}
				return r_R_OnMouseOver;
			}
		}

		/// <summary>
		/// Void _OnMouseExit()
		/// </summary>
		protected RMethod r_R_OnMouseExit;
		public virtual RMethod R_OnMouseExit
		{
			get
			{
				if(r_R_OnMouseExit == null)
				{
					r_R_OnMouseExit = new(this, "_OnMouseExit", 0);
					r_R_OnMouseExit.SetBelong(this.instance);
				}
				return r_R_OnMouseExit;
			}
		}

		/// <summary>
		/// Void OnMouseUp()
		/// </summary>
		protected RMethod r_ROnMouseUp;
		public virtual RMethod ROnMouseUp
		{
			get
			{
				if(r_ROnMouseUp == null)
				{
					r_ROnMouseUp = new(this, "OnMouseUp", 0);
					r_ROnMouseUp.SetBelong(this.instance);
				}
				return r_ROnMouseUp;
			}
		}

		/// <summary>
		/// Void OnMouseDownEx(Boolean)
		/// </summary>
		protected RMethod r_ROnMouseDownEx_Boolean;
		public virtual RMethod ROnMouseDownEx_Boolean
		{
			get
			{
				if(r_ROnMouseDownEx_Boolean == null)
				{
					r_ROnMouseDownEx_Boolean = new(this, "OnMouseDownEx", 0, typeof(System.Boolean));
					r_ROnMouseDownEx_Boolean.SetBelong(this.instance);
				}
				return r_ROnMouseDownEx_Boolean;
			}
		}

		/// <summary>
		/// Void OnMouseDownEx(Boolean, System.String)
		/// </summary>
		protected RMethod r_ROnMouseDownEx_Boolean_String;
		public virtual RMethod ROnMouseDownEx_Boolean_String
		{
			get
			{
				if(r_ROnMouseDownEx_Boolean_String == null)
				{
					r_ROnMouseDownEx_Boolean_String = new(this, "OnMouseDownEx", 0, typeof(System.Boolean), typeof(System.String));
					r_ROnMouseDownEx_Boolean_String.SetBelong(this.instance);
				}
				return r_ROnMouseDownEx_Boolean_String;
			}
		}

		/// <summary>
		/// Void SendNpcTrigger()
		/// </summary>
		protected RMethod r_RSendNpcTrigger;
		public virtual RMethod RSendNpcTrigger
		{
			get
			{
				if(r_RSendNpcTrigger == null)
				{
					r_RSendNpcTrigger = new(this, "SendNpcTrigger", 0);
					r_RSendNpcTrigger.SetBelong(this.instance);
				}
				return r_RSendNpcTrigger;
			}
		}

		/// <summary>
		/// Void _OnMouseUp()
		/// </summary>
		protected RMethod r_R_OnMouseUp;
		public virtual RMethod R_OnMouseUp
		{
			get
			{
				if(r_R_OnMouseUp == null)
				{
					r_R_OnMouseUp = new(this, "_OnMouseUp", 0);
					r_R_OnMouseUp.SetBelong(this.instance);
				}
				return r_R_OnMouseUp;
			}
		}

		/// <summary>
		/// Void _OnMouseRightDown()
		/// </summary>
		protected RMethod r_R_OnMouseRightDown;
		public virtual RMethod R_OnMouseRightDown
		{
			get
			{
				if(r_R_OnMouseRightDown == null)
				{
					r_R_OnMouseRightDown = new(this, "_OnMouseRightDown", 0);
					r_R_OnMouseRightDown.SetBelong(this.instance);
				}
				return r_R_OnMouseRightDown;
			}
		}

		/// <summary>
		/// Void ProcessInterrupt(#u.#Bu, System.Object)
		/// </summary>
		protected RMethod r_RProcessInterrupt___0__Bu_Object;
		public virtual RMethod RProcessInterrupt___0__Bu_Object
		{
			get
			{
				if(r_RProcessInterrupt___0__Bu_Object == null)
				{
					r_RProcessInterrupt___0__Bu_Object = new(this, "ProcessInterrupt", 0,  ReleactionUtils.GetType("#u.#Bu"), typeof(System.Object));
					r_RProcessInterrupt___0__Bu_Object.SetBelong(this.instance);
				}
				return r_RProcessInterrupt___0__Bu_Object;
			}
		}

		/// <summary>
		/// Void ProcessOpenChest(#u.#Bu, System.Object)
		/// </summary>
		protected RMethod r_RProcessOpenChest___0__Bu_Object;
		public virtual RMethod RProcessOpenChest___0__Bu_Object
		{
			get
			{
				if(r_RProcessOpenChest___0__Bu_Object == null)
				{
					r_RProcessOpenChest___0__Bu_Object = new(this, "ProcessOpenChest", 0,  ReleactionUtils.GetType("#u.#Bu"), typeof(System.Object));
					r_RProcessOpenChest___0__Bu_Object.SetBelong(this.instance);
				}
				return r_RProcessOpenChest___0__Bu_Object;
			}
		}

		/// <summary>
		/// Void FinishOpenChest()
		/// </summary>
		protected RMethod r_RFinishOpenChest;
		public virtual RMethod RFinishOpenChest
		{
			get
			{
				if(r_RFinishOpenChest == null)
				{
					r_RFinishOpenChest = new(this, "FinishOpenChest", 0);
					r_RFinishOpenChest.SetBelong(this.instance);
				}
				return r_RFinishOpenChest;
			}
		}

		/// <summary>
		/// Void OnDisable()
		/// </summary>
		protected RMethod r_ROnDisable;
		public virtual RMethod ROnDisable
		{
			get
			{
				if(r_ROnDisable == null)
				{
					r_ROnDisable = new(this, "OnDisable", 0);
					r_ROnDisable.SetBelong(this.instance);
				}
				return r_ROnDisable;
			}
		}

		/// <summary>
		/// Void SetupTrigger()
		/// </summary>
		protected RMethod r_RSetupTrigger;
		public virtual RMethod RSetupTrigger
		{
			get
			{
				if(r_RSetupTrigger == null)
				{
					r_RSetupTrigger = new(this, "SetupTrigger", 0);
					r_RSetupTrigger.SetBelong(this.instance);
				}
				return r_RSetupTrigger;
			}
		}

		/// <summary>
		/// System.String ParseTriggerName(System.String)
		/// </summary>
		protected RMethod r_RParseTriggerName_String;
		public virtual RMethod RParseTriggerName_String
		{
			get
			{
				if(r_RParseTriggerName_String == null)
				{
					r_RParseTriggerName_String = new(this, "ParseTriggerName", 0, typeof(System.String));
					r_RParseTriggerName_String.SetBelong(this.instance);
				}
				return r_RParseTriggerName_String;
			}
		}

		/// <summary>
		/// System.Object[] ParseTriggerParams(System.String)
		/// </summary>
		protected RMethod r_RParseTriggerParams_String;
		public virtual RMethod RParseTriggerParams_String
		{
			get
			{
				if(r_RParseTriggerParams_String == null)
				{
					r_RParseTriggerParams_String = new(this, "ParseTriggerParams", 0, typeof(System.String));
					r_RParseTriggerParams_String.SetBelong(this.instance);
				}
				return r_RParseTriggerParams_String;
			}
		}

		/// <summary>
		/// Void InvokeTriggerInit(UnityEngine.Component, System.Object[])
		/// </summary>
		protected RMethod r_RInvokeTriggerInit_Component_ObjectArray;
		public virtual RMethod RInvokeTriggerInit_Component_ObjectArray
		{
			get
			{
				if(r_RInvokeTriggerInit_Component_ObjectArray == null)
				{
					r_RInvokeTriggerInit_Component_ObjectArray = new(this, "InvokeTriggerInit", 0, typeof(UnityEngine.Component), typeof(System.Object).MakeArrayType());
					r_RInvokeTriggerInit_Component_ObjectArray.SetBelong(this.instance);
				}
				return r_RInvokeTriggerInit_Component_ObjectArray;
			}
		}

		/// <summary>
		/// Void ShowFuncIcon()
		/// </summary>
		protected RMethod r_RShowFuncIcon;
		public virtual RMethod RShowFuncIcon
		{
			get
			{
				if(r_RShowFuncIcon == null)
				{
					r_RShowFuncIcon = new(this, "ShowFuncIcon", 0);
					r_RShowFuncIcon.SetBelong(this.instance);
				}
				return r_RShowFuncIcon;
			}
		}

		/// <summary>
		/// Void OnLoadTitleIcon(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadTitleIcon_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadTitleIcon_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadTitleIcon_Object_ABLoadedArgs == null)
				{
					r_ROnLoadTitleIcon_Object_ABLoadedArgs = new(this, "OnLoadTitleIcon", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadTitleIcon_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadTitleIcon_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void SetIconGray(Boolean)
		/// </summary>
		protected RMethod r_RSetIconGray_Boolean;
		public virtual RMethod RSetIconGray_Boolean
		{
			get
			{
				if(r_RSetIconGray_Boolean == null)
				{
					r_RSetIconGray_Boolean = new(this, "SetIconGray", 0, typeof(System.Boolean));
					r_RSetIconGray_Boolean.SetBelong(this.instance);
				}
				return r_RSetIconGray_Boolean;
			}
		}

		/// <summary>
		/// Void ShowNotifyIcon(Boolean, Message.TASK_NOTIFY_TYPE)
		/// </summary>
		protected RMethod r_RShowNotifyIcon_Boolean_TASK_NOTIFY_TYPE;
		public virtual RMethod RShowNotifyIcon_Boolean_TASK_NOTIFY_TYPE
		{
			get
			{
				if(r_RShowNotifyIcon_Boolean_TASK_NOTIFY_TYPE == null)
				{
					r_RShowNotifyIcon_Boolean_TASK_NOTIFY_TYPE = new(this, "ShowNotifyIcon", 0, typeof(System.Boolean),  ReleactionUtils.GetType("Message.TASK_NOTIFY_TYPE"));
					r_RShowNotifyIcon_Boolean_TASK_NOTIFY_TYPE.SetBelong(this.instance);
				}
				return r_RShowNotifyIcon_Boolean_TASK_NOTIFY_TYPE;
			}
		}

		/// <summary>
		/// Boolean CheckPlayerViewRange()
		/// </summary>
		protected RMethod r_RCheckPlayerViewRange;
		public virtual RMethod RCheckPlayerViewRange
		{
			get
			{
				if(r_RCheckPlayerViewRange == null)
				{
					r_RCheckPlayerViewRange = new(this, "CheckPlayerViewRange", 0);
					r_RCheckPlayerViewRange.SetBelong(this.instance);
				}
				return r_RCheckPlayerViewRange;
			}
		}

		/// <summary>
		/// Boolean IsInPlayerVision()
		/// </summary>
		protected RMethod r_RIsInPlayerVision;
		public virtual RMethod RIsInPlayerVision
		{
			get
			{
				if(r_RIsInPlayerVision == null)
				{
					r_RIsInPlayerVision = new(this, "IsInPlayerVision", 0);
					r_RIsInPlayerVision.SetBelong(this.instance);
				}
				return r_RIsInPlayerVision;
			}
		}

		/// <summary>
		/// Void OnGotoMsg(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_ROnGotoMsg_Vector3_Single;
		public virtual RMethod ROnGotoMsg_Vector3_Single
		{
			get
			{
				if(r_ROnGotoMsg_Vector3_Single == null)
				{
					r_ROnGotoMsg_Vector3_Single = new(this, "OnGotoMsg", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_ROnGotoMsg_Vector3_Single.SetBelong(this.instance);
				}
				return r_ROnGotoMsg_Vector3_Single;
			}
		}

		/// <summary>
		/// Void OnPatrolMsg(UnityEngine.Vector3, Single, Boolean)
		/// </summary>
		protected RMethod r_ROnPatrolMsg_Vector3_Single_Boolean;
		public virtual RMethod ROnPatrolMsg_Vector3_Single_Boolean
		{
			get
			{
				if(r_ROnPatrolMsg_Vector3_Single_Boolean == null)
				{
					r_ROnPatrolMsg_Vector3_Single_Boolean = new(this, "OnPatrolMsg", 0, typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Boolean));
					r_ROnPatrolMsg_Vector3_Single_Boolean.SetBelong(this.instance);
				}
				return r_ROnPatrolMsg_Vector3_Single_Boolean;
			}
		}

		/// <summary>
		/// Void StopPatrol()
		/// </summary>
		protected RMethod r_RStopPatrol;
		public virtual RMethod RStopPatrol
		{
			get
			{
				if(r_RStopPatrol == null)
				{
					r_RStopPatrol = new(this, "StopPatrol", 0);
					r_RStopPatrol.SetBelong(this.instance);
				}
				return r_RStopPatrol;
			}
		}

		/// <summary>
		/// Void CommonUpdate()
		/// </summary>
		protected RMethod r_RCommonUpdate;
		public virtual RMethod RCommonUpdate
		{
			get
			{
				if(r_RCommonUpdate == null)
				{
					r_RCommonUpdate = new(this, "CommonUpdate", 0);
					r_RCommonUpdate.SetBelong(this.instance);
				}
				return r_RCommonUpdate;
			}
		}

		/// <summary>
		/// Void EnableAICtrl(Boolean)
		/// </summary>
		protected RMethod r_REnableAICtrl_Boolean;
		public virtual RMethod REnableAICtrl_Boolean
		{
			get
			{
				if(r_REnableAICtrl_Boolean == null)
				{
					r_REnableAICtrl_Boolean = new(this, "EnableAICtrl", 0, typeof(System.Boolean));
					r_REnableAICtrl_Boolean.SetBelong(this.instance);
				}
				return r_REnableAICtrl_Boolean;
			}
		}

		/// <summary>
		/// Void InitAICtrl()
		/// </summary>
		protected RMethod r_RInitAICtrl;
		public virtual RMethod RInitAICtrl
		{
			get
			{
				if(r_RInitAICtrl == null)
				{
					r_RInitAICtrl = new(this, "InitAICtrl", 0);
					r_RInitAICtrl.SetBelong(this.instance);
				}
				return r_RInitAICtrl;
			}
		}

		/// <summary>
		/// Boolean IsPlayerInVision()
		/// </summary>
		protected RMethod r_RIsPlayerInVision;
		public virtual RMethod RIsPlayerInVision
		{
			get
			{
				if(r_RIsPlayerInVision == null)
				{
					r_RIsPlayerInVision = new(this, "IsPlayerInVision", 0);
					r_RIsPlayerInVision.SetBelong(this.instance);
				}
				return r_RIsPlayerInVision;
			}
		}

		/// <summary>
		/// Void ChangeMouseCursor()
		/// </summary>
		protected RMethod r_RChangeMouseCursor;
		public virtual RMethod RChangeMouseCursor
		{
			get
			{
				if(r_RChangeMouseCursor == null)
				{
					r_RChangeMouseCursor = new(this, "ChangeMouseCursor", 0);
					r_RChangeMouseCursor.SetBelong(this.instance);
				}
				return r_RChangeMouseCursor;
			}
		}

		/// <summary>
		/// Void _OnGUI()
		/// </summary>
		protected RMethod r_R_OnGUI;
		public virtual RMethod R_OnGUI
		{
			get
			{
				if(r_R_OnGUI == null)
				{
					r_R_OnGUI = new(this, "_OnGUI", 0);
					r_R_OnGUI.SetBelong(this.instance);
				}
				return r_R_OnGUI;
			}
		}

		/// <summary>
		/// Void DrawNameGUI()
		/// </summary>
		protected RMethod r_RDrawNameGUI;
		public virtual RMethod RDrawNameGUI
		{
			get
			{
				if(r_RDrawNameGUI == null)
				{
					r_RDrawNameGUI = new(this, "DrawNameGUI", 0);
					r_RDrawNameGUI.SetBelong(this.instance);
				}
				return r_RDrawNameGUI;
			}
		}

		/// <summary>
		/// Void DrawHPBar(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RDrawHPBar_Vector2;
		public virtual RMethod RDrawHPBar_Vector2
		{
			get
			{
				if(r_RDrawHPBar_Vector2 == null)
				{
					r_RDrawHPBar_Vector2 = new(this, "DrawHPBar", 0, typeof(UnityEngine.Vector2));
					r_RDrawHPBar_Vector2.SetBelong(this.instance);
				}
				return r_RDrawHPBar_Vector2;
			}
		}

		/// <summary>
		/// Void SetNameText()
		/// </summary>
		protected RMethod r_RSetNameText;
		public virtual RMethod RSetNameText
		{
			get
			{
				if(r_RSetNameText == null)
				{
					r_RSetNameText = new(this, "SetNameText", 0);
					r_RSetNameText.SetBelong(this.instance);
				}
				return r_RSetNameText;
			}
		}

		/// <summary>
		/// Void FadeRemove()
		/// </summary>
		protected RMethod r_RFadeRemove;
		public virtual RMethod RFadeRemove
		{
			get
			{
				if(r_RFadeRemove == null)
				{
					r_RFadeRemove = new(this, "FadeRemove", 0);
					r_RFadeRemove.SetBelong(this.instance);
				}
				return r_RFadeRemove;
			}
		}

		/// <summary>
		/// Void OnFadeEnd(FadeType)
		/// </summary>
		protected RMethod r_ROnFadeEnd_FadeType;
		public virtual RMethod ROnFadeEnd_FadeType
		{
			get
			{
				if(r_ROnFadeEnd_FadeType == null)
				{
					r_ROnFadeEnd_FadeType = new(this, "OnFadeEnd", 0,  ReleactionUtils.GetType("CreatureBehav+FadeType"));
					r_ROnFadeEnd_FadeType.SetBelong(this.instance);
				}
				return r_ROnFadeEnd_FadeType;
			}
		}

		/// <summary>
		/// Void ResetNPCRotation()
		/// </summary>
		protected RMethod r_RResetNPCRotation;
		public virtual RMethod RResetNPCRotation
		{
			get
			{
				if(r_RResetNPCRotation == null)
				{
					r_RResetNPCRotation = new(this, "ResetNPCRotation", 0);
					r_RResetNPCRotation.SetBelong(this.instance);
				}
				return r_RResetNPCRotation;
			}
		}

		/// <summary>
		/// Boolean ModelLimited()
		/// </summary>
		protected RMethod r_RModelLimited;
		public virtual RMethod RModelLimited
		{
			get
			{
				if(r_RModelLimited == null)
				{
					r_RModelLimited = new(this, "ModelLimited", 0);
					r_RModelLimited.SetBelong(this.instance);
				}
				return r_RModelLimited;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator CheckModleDownLoad()
		/// </summary>
		protected RMethod r_RCheckModleDownLoad;
		public virtual RMethod RCheckModleDownLoad
		{
			get
			{
				if(r_RCheckModleDownLoad == null)
				{
					r_RCheckModleDownLoad = new(this, "CheckModleDownLoad", 0);
					r_RCheckModleDownLoad.SetBelong(this.instance);
				}
				return r_RCheckModleDownLoad;
			}
		}

		/// <summary>
		/// Void OnLoadedResetAnimation(UnityEngine.Animation)
		/// </summary>
		protected RMethod r_ROnLoadedResetAnimation_Animation;
		public virtual RMethod ROnLoadedResetAnimation_Animation
		{
			get
			{
				if(r_ROnLoadedResetAnimation_Animation == null)
				{
					r_ROnLoadedResetAnimation_Animation = new(this, "OnLoadedResetAnimation", 0, typeof(UnityEngine.Animation));
					r_ROnLoadedResetAnimation_Animation.SetBelong(this.instance);
				}
				return r_ROnLoadedResetAnimation_Animation;
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
		/// Void SpaceTrigger()
		/// </summary>
		protected RMethod r_RSpaceTrigger;
		public virtual RMethod RSpaceTrigger
		{
			get
			{
				if(r_RSpaceTrigger == null)
				{
					r_RSpaceTrigger = new(this, "SpaceTrigger", 0);
					r_RSpaceTrigger.SetBelong(this.instance);
				}
				return r_RSpaceTrigger;
			}
		}

		/// <summary>
		/// Void UpdateInGhost(Single)
		/// </summary>
		protected RMethod r_RUpdateInGhost_Single;
		public virtual RMethod RUpdateInGhost_Single
		{
			get
			{
				if(r_RUpdateInGhost_Single == null)
				{
					r_RUpdateInGhost_Single = new(this, "UpdateInGhost", 0, typeof(System.Single));
					r_RUpdateInGhost_Single.SetBelong(this.instance);
				}
				return r_RUpdateInGhost_Single;
			}
		}

		/// <summary>
		/// Void UpdateSusGhost(Single)
		/// </summary>
		protected RMethod r_RUpdateSusGhost_Single;
		public virtual RMethod RUpdateSusGhost_Single
		{
			get
			{
				if(r_RUpdateSusGhost_Single == null)
				{
					r_RUpdateSusGhost_Single = new(this, "UpdateSusGhost", 0, typeof(System.Single));
					r_RUpdateSusGhost_Single.SetBelong(this.instance);
				}
				return r_RUpdateSusGhost_Single;
			}
		}

		/// <summary>
		/// Void UpdateOutGhost()
		/// </summary>
		protected RMethod r_RUpdateOutGhost;
		public virtual RMethod RUpdateOutGhost
		{
			get
			{
				if(r_RUpdateOutGhost == null)
				{
					r_RUpdateOutGhost = new(this, "UpdateOutGhost", 0);
					r_RUpdateOutGhost.SetBelong(this.instance);
				}
				return r_RUpdateOutGhost;
			}
		}

		/// <summary>
		/// Void MoveTowards(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RMoveTowards_Vector3_Single;
		public virtual RMethod RMoveTowards_Vector3_Single
		{
			get
			{
				if(r_RMoveTowards_Vector3_Single == null)
				{
					r_RMoveTowards_Vector3_Single = new(this, "MoveTowards", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RMoveTowards_Vector3_Single.SetBelong(this.instance);
				}
				return r_RMoveTowards_Vector3_Single;
			}
		}

		/// <summary>
		/// Void MoveToNext()
		/// </summary>
		protected RMethod r_RMoveToNext;
		public virtual RMethod RMoveToNext
		{
			get
			{
				if(r_RMoveToNext == null)
				{
					r_RMoveToNext = new(this, "MoveToNext", 0);
					r_RMoveToNext.SetBelong(this.instance);
				}
				return r_RMoveToNext;
			}
		}

		/// <summary>
		/// Void FinishEscortMove()
		/// </summary>
		protected RMethod r_RFinishEscortMove;
		public virtual RMethod RFinishEscortMove
		{
			get
			{
				if(r_RFinishEscortMove == null)
				{
					r_RFinishEscortMove = new(this, "FinishEscortMove", 0);
					r_RFinishEscortMove.SetBelong(this.instance);
				}
				return r_RFinishEscortMove;
			}
		}

		/// <summary>
		/// Void StopMove()
		/// </summary>
		protected RMethod r_RStopMove;
		public virtual RMethod RStopMove
		{
			get
			{
				if(r_RStopMove == null)
				{
					r_RStopMove = new(this, "StopMove", 0);
					r_RStopMove.SetBelong(this.instance);
				}
				return r_RStopMove;
			}
		}

		/// <summary>
		/// Void RestartMove(Single)
		/// </summary>
		protected RMethod r_RRestartMove_Single;
		public virtual RMethod RRestartMove_Single
		{
			get
			{
				if(r_RRestartMove_Single == null)
				{
					r_RRestartMove_Single = new(this, "RestartMove", 0, typeof(System.Single));
					r_RRestartMove_Single.SetBelong(this.instance);
				}
				return r_RRestartMove_Single;
			}
		}

		/// <summary>
		/// Void SetCarrierColor()
		/// </summary>
		protected RMethod r_RSetCarrierColor;
		public virtual RMethod RSetCarrierColor
		{
			get
			{
				if(r_RSetCarrierColor == null)
				{
					r_RSetCarrierColor = new(this, "SetCarrierColor", 0);
					r_RSetCarrierColor.SetBelong(this.instance);
				}
				return r_RSetCarrierColor;
			}
		}

		/// <summary>
		/// Void ChangeCarrierState(Int32)
		/// </summary>
		protected RMethod r_RChangeCarrierState_Int32;
		public virtual RMethod RChangeCarrierState_Int32
		{
			get
			{
				if(r_RChangeCarrierState_Int32 == null)
				{
					r_RChangeCarrierState_Int32 = new(this, "ChangeCarrierState", 0, typeof(System.Int32));
					r_RChangeCarrierState_Int32.SetBelong(this.instance);
				}
				return r_RChangeCarrierState_Int32;
			}
		}

		/// <summary>
		/// Void BreakCarrier(Int32)
		/// </summary>
		protected RMethod r_RBreakCarrier_Int32;
		public virtual RMethod RBreakCarrier_Int32
		{
			get
			{
				if(r_RBreakCarrier_Int32 == null)
				{
					r_RBreakCarrier_Int32 = new(this, "BreakCarrier", 0, typeof(System.Int32));
					r_RBreakCarrier_Int32.SetBelong(this.instance);
				}
				return r_RBreakCarrier_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator ClientPatrol()
		/// </summary>
		protected RMethod r_RClientPatrol;
		public virtual RMethod RClientPatrol
		{
			get
			{
				if(r_RClientPatrol == null)
				{
					r_RClientPatrol = new(this, "ClientPatrol", 0);
					r_RClientPatrol.SetBelong(this.instance);
				}
				return r_RClientPatrol;
			}
		}

		/// <summary>
		/// Void SetPosition(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSetPosition_Vector3;
		public virtual RMethod RSetPosition_Vector3
		{
			get
			{
				if(r_RSetPosition_Vector3 == null)
				{
					r_RSetPosition_Vector3 = new(this, "SetPosition", 0, typeof(UnityEngine.Vector3));
					r_RSetPosition_Vector3.SetBelong(this.instance);
				}
				return r_RSetPosition_Vector3;
			}
		}

		/// <summary>
		/// Void SetExtraIconUrl(System.String[])
		/// </summary>
		protected RMethod r_RSetExtraIconUrl_StringArray;
		public virtual RMethod RSetExtraIconUrl_StringArray
		{
			get
			{
				if(r_RSetExtraIconUrl_StringArray == null)
				{
					r_RSetExtraIconUrl_StringArray = new(this, "SetExtraIconUrl", 0, typeof(System.String).MakeArrayType());
					r_RSetExtraIconUrl_StringArray.SetBelong(this.instance);
				}
				return r_RSetExtraIconUrl_StringArray;
			}
		}

		/// <summary>
		/// Void OnLoadExtraTitleIcon(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadExtraTitleIcon_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadExtraTitleIcon_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadExtraTitleIcon_Object_ABLoadedArgs == null)
				{
					r_ROnLoadExtraTitleIcon_Object_ABLoadedArgs = new(this, "OnLoadExtraTitleIcon", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadExtraTitleIcon_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadExtraTitleIcon_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetOverHeadHightOffset()
		/// </summary>
		protected RMethod r_RGetOverHeadHightOffset;
		public virtual RMethod RGetOverHeadHightOffset
		{
			get
			{
				if(r_RGetOverHeadHightOffset == null)
				{
					r_RGetOverHeadHightOffset = new(this, "GetOverHeadHightOffset", 0);
					r_RGetOverHeadHightOffset.SetBelong(this.instance);
				}
				return r_RGetOverHeadHightOffset;
			}
		}

		/// <summary>
		/// Void _Update()
		/// </summary>
		protected RMethod r_R_Update;
		public virtual RMethod R_Update
		{
			get
			{
				if(r_R_Update == null)
				{
					r_R_Update = new(this, "_Update", 0);
					r_R_Update.SetBelong(this.instance);
				}
				return r_R_Update;
			}
		}

		/// <summary>
		/// Void DrawText(System.String, Boolean, UnityEngine.Rect, Single, UnityEngine.GUIStyle, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_RDrawText_String_Boolean_Rect_Single_GUIStyle_GUIStyle;
		public virtual RMethod RDrawText_String_Boolean_Rect_Single_GUIStyle_GUIStyle
		{
			get
			{
				if(r_RDrawText_String_Boolean_Rect_Single_GUIStyle_GUIStyle == null)
				{
					r_RDrawText_String_Boolean_Rect_Single_GUIStyle_GUIStyle = new(this, "DrawText", 0, typeof(System.String), typeof(System.Boolean), typeof(UnityEngine.Rect), typeof(System.Single), typeof(UnityEngine.GUIStyle), typeof(UnityEngine.GUIStyle));
					r_RDrawText_String_Boolean_Rect_Single_GUIStyle_GUIStyle.SetBelong(this.instance);
				}
				return r_RDrawText_String_Boolean_Rect_Single_GUIStyle_GUIStyle;
			}
		}

		/// <summary>
		/// Void DrawPopText(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RDrawPopText_Vector2;
		public virtual RMethod RDrawPopText_Vector2
		{
			get
			{
				if(r_RDrawPopText_Vector2 == null)
				{
					r_RDrawPopText_Vector2 = new(this, "DrawPopText", 0, typeof(UnityEngine.Vector2));
					r_RDrawPopText_Vector2.SetBelong(this.instance);
				}
				return r_RDrawPopText_Vector2;
			}
		}

		/// <summary>
		/// Void DrawWildKillCount(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RDrawWildKillCount_Vector2;
		public virtual RMethod RDrawWildKillCount_Vector2
		{
			get
			{
				if(r_RDrawWildKillCount_Vector2 == null)
				{
					r_RDrawWildKillCount_Vector2 = new(this, "DrawWildKillCount", 0, typeof(UnityEngine.Vector2));
					r_RDrawWildKillCount_Vector2.SetBelong(this.instance);
				}
				return r_RDrawWildKillCount_Vector2;
			}
		}

		/// <summary>
		/// Void DrawCombatNameGUI()
		/// </summary>
		protected RMethod r_RDrawCombatNameGUI;
		public virtual RMethod RDrawCombatNameGUI
		{
			get
			{
				if(r_RDrawCombatNameGUI == null)
				{
					r_RDrawCombatNameGUI = new(this, "DrawCombatNameGUI", 0);
					r_RDrawCombatNameGUI.SetBelong(this.instance);
				}
				return r_RDrawCombatNameGUI;
			}
		}

		/// <summary>
		/// Void UpdateNameText()
		/// </summary>
		protected RMethod r_RUpdateNameText;
		public virtual RMethod RUpdateNameText
		{
			get
			{
				if(r_RUpdateNameText == null)
				{
					r_RUpdateNameText = new(this, "UpdateNameText", 0);
					r_RUpdateNameText.SetBelong(this.instance);
				}
				return r_RUpdateNameText;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetDrawName3DPos()
		/// </summary>
		protected RMethod r_RGetDrawName3DPos;
		public virtual RMethod RGetDrawName3DPos
		{
			get
			{
				if(r_RGetDrawName3DPos == null)
				{
					r_RGetDrawName3DPos = new(this, "GetDrawName3DPos", 0);
					r_RGetDrawName3DPos.SetBelong(this.instance);
				}
				return r_RGetDrawName3DPos;
			}
		}

		/// <summary>
		/// Boolean CreatureFadeBegin(FadeType)
		/// </summary>
		protected RMethod r_RCreatureFadeBegin_FadeType;
		public virtual RMethod RCreatureFadeBegin_FadeType
		{
			get
			{
				if(r_RCreatureFadeBegin_FadeType == null)
				{
					r_RCreatureFadeBegin_FadeType = new(this, "CreatureFadeBegin", 0,  ReleactionUtils.GetType("CreatureBehav+FadeType"));
					r_RCreatureFadeBegin_FadeType.SetBelong(this.instance);
				}
				return r_RCreatureFadeBegin_FadeType;
			}
		}

		/// <summary>
		/// Void CreatureFadeRest()
		/// </summary>
		protected RMethod r_RCreatureFadeRest;
		public virtual RMethod RCreatureFadeRest
		{
			get
			{
				if(r_RCreatureFadeRest == null)
				{
					r_RCreatureFadeRest = new(this, "CreatureFadeRest", 0);
					r_RCreatureFadeRest.SetBelong(this.instance);
				}
				return r_RCreatureFadeRest;
			}
		}

		/// <summary>
		/// Boolean CreatureFadeForce(FadeType)
		/// </summary>
		protected RMethod r_RCreatureFadeForce_FadeType;
		public virtual RMethod RCreatureFadeForce_FadeType
		{
			get
			{
				if(r_RCreatureFadeForce_FadeType == null)
				{
					r_RCreatureFadeForce_FadeType = new(this, "CreatureFadeForce", 0,  ReleactionUtils.GetType("CreatureBehav+FadeType"));
					r_RCreatureFadeForce_FadeType.SetBelong(this.instance);
				}
				return r_RCreatureFadeForce_FadeType;
			}
		}

		/// <summary>
		/// Void SetFadeSpeed(Single)
		/// </summary>
		protected RMethod r_RSetFadeSpeed_Single;
		public virtual RMethod RSetFadeSpeed_Single
		{
			get
			{
				if(r_RSetFadeSpeed_Single == null)
				{
					r_RSetFadeSpeed_Single = new(this, "SetFadeSpeed", 0, typeof(System.Single));
					r_RSetFadeSpeed_Single.SetBelong(this.instance);
				}
				return r_RSetFadeSpeed_Single;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator CreatureFade(FadeType)
		/// </summary>
		protected RMethod r_RCreatureFade_FadeType;
		public virtual RMethod RCreatureFade_FadeType
		{
			get
			{
				if(r_RCreatureFade_FadeType == null)
				{
					r_RCreatureFade_FadeType = new(this, "CreatureFade", 0,  ReleactionUtils.GetType("CreatureBehav+FadeType"));
					r_RCreatureFade_FadeType.SetBelong(this.instance);
				}
				return r_RCreatureFade_FadeType;
			}
		}

		/// <summary>
		/// Void SetTransparentModel(Boolean)
		/// </summary>
		protected RMethod r_RSetTransparentModel_Boolean;
		public virtual RMethod RSetTransparentModel_Boolean
		{
			get
			{
				if(r_RSetTransparentModel_Boolean == null)
				{
					r_RSetTransparentModel_Boolean = new(this, "SetTransparentModel", 0, typeof(System.Boolean));
					r_RSetTransparentModel_Boolean.SetBelong(this.instance);
				}
				return r_RSetTransparentModel_Boolean;
			}
		}

		/// <summary>
		/// Void TransparentModel()
		/// </summary>
		protected RMethod r_RTransparentModel;
		public virtual RMethod RTransparentModel
		{
			get
			{
				if(r_RTransparentModel == null)
				{
					r_RTransparentModel = new(this, "TransparentModel", 0);
					r_RTransparentModel.SetBelong(this.instance);
				}
				return r_RTransparentModel;
			}
		}

		/// <summary>
		/// Void HideCreature()
		/// </summary>
		protected RMethod r_RHideCreature;
		public virtual RMethod RHideCreature
		{
			get
			{
				if(r_RHideCreature == null)
				{
					r_RHideCreature = new(this, "HideCreature", 0);
					r_RHideCreature.SetBelong(this.instance);
				}
				return r_RHideCreature;
			}
		}

		/// <summary>
		/// Void HideCreature(Boolean)
		/// </summary>
		protected RMethod r_RHideCreature_Boolean;
		public virtual RMethod RHideCreature_Boolean
		{
			get
			{
				if(r_RHideCreature_Boolean == null)
				{
					r_RHideCreature_Boolean = new(this, "HideCreature", 0, typeof(System.Boolean));
					r_RHideCreature_Boolean.SetBelong(this.instance);
				}
				return r_RHideCreature_Boolean;
			}
		}

		/// <summary>
		/// Void UnHideCreature()
		/// </summary>
		protected RMethod r_RUnHideCreature;
		public virtual RMethod RUnHideCreature
		{
			get
			{
				if(r_RUnHideCreature == null)
				{
					r_RUnHideCreature = new(this, "UnHideCreature", 0);
					r_RUnHideCreature.SetBelong(this.instance);
				}
				return r_RUnHideCreature;
			}
		}

		/// <summary>
		/// Void UnHideCreatureInCombat()
		/// </summary>
		protected RMethod r_RUnHideCreatureInCombat;
		public virtual RMethod RUnHideCreatureInCombat
		{
			get
			{
				if(r_RUnHideCreatureInCombat == null)
				{
					r_RUnHideCreatureInCombat = new(this, "UnHideCreatureInCombat", 0);
					r_RUnHideCreatureInCombat.SetBelong(this.instance);
				}
				return r_RUnHideCreatureInCombat;
			}
		}

		/// <summary>
		/// Void SetDeadCreature()
		/// </summary>
		protected RMethod r_RSetDeadCreature;
		public virtual RMethod RSetDeadCreature
		{
			get
			{
				if(r_RSetDeadCreature == null)
				{
					r_RSetDeadCreature = new(this, "SetDeadCreature", 0);
					r_RSetDeadCreature.SetBelong(this.instance);
				}
				return r_RSetDeadCreature;
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
		/// Void DeadInCombat()
		/// </summary>
		protected RMethod r_RDeadInCombat;
		public virtual RMethod RDeadInCombat
		{
			get
			{
				if(r_RDeadInCombat == null)
				{
					r_RDeadInCombat = new(this, "DeadInCombat", 0);
					r_RDeadInCombat.SetBelong(this.instance);
				}
				return r_RDeadInCombat;
			}
		}

		/// <summary>
		/// Void ReliveCreature(Boolean)
		/// </summary>
		protected RMethod r_RReliveCreature_Boolean;
		public virtual RMethod RReliveCreature_Boolean
		{
			get
			{
				if(r_RReliveCreature_Boolean == null)
				{
					r_RReliveCreature_Boolean = new(this, "ReliveCreature", 0, typeof(System.Boolean));
					r_RReliveCreature_Boolean.SetBelong(this.instance);
				}
				return r_RReliveCreature_Boolean;
			}
		}

		/// <summary>
		/// IS_IN_VISION GetVisibleState()
		/// </summary>
		protected RMethod r_RGetVisibleState;
		public virtual RMethod RGetVisibleState
		{
			get
			{
				if(r_RGetVisibleState == null)
				{
					r_RGetVisibleState = new(this, "GetVisibleState", 0);
					r_RGetVisibleState.SetBelong(this.instance);
				}
				return r_RGetVisibleState;
			}
		}

		/// <summary>
		/// Boolean CheckCreatureVisible()
		/// </summary>
		protected RMethod r_RCheckCreatureVisible;
		public virtual RMethod RCheckCreatureVisible
		{
			get
			{
				if(r_RCheckCreatureVisible == null)
				{
					r_RCheckCreatureVisible = new(this, "CheckCreatureVisible", 0);
					r_RCheckCreatureVisible.SetBelong(this.instance);
				}
				return r_RCheckCreatureVisible;
			}
		}

		/// <summary>
		/// Void CreatureVisibleRest()
		/// </summary>
		protected RMethod r_RCreatureVisibleRest;
		public virtual RMethod RCreatureVisibleRest
		{
			get
			{
				if(r_RCreatureVisibleRest == null)
				{
					r_RCreatureVisibleRest = new(this, "CreatureVisibleRest", 0);
					r_RCreatureVisibleRest.SetBelong(this.instance);
				}
				return r_RCreatureVisibleRest;
			}
		}

		/// <summary>
		/// Void UpdateLoveName(System.String)
		/// </summary>
		protected RMethod r_RUpdateLoveName_String;
		public virtual RMethod RUpdateLoveName_String
		{
			get
			{
				if(r_RUpdateLoveName_String == null)
				{
					r_RUpdateLoveName_String = new(this, "UpdateLoveName", 0, typeof(System.String));
					r_RUpdateLoveName_String.SetBelong(this.instance);
				}
				return r_RUpdateLoveName_String;
			}
		}

		/// <summary>
		/// Void _OnMouseDown()
		/// </summary>
		protected RMethod r_R_OnMouseDown;
		public virtual RMethod R_OnMouseDown
		{
			get
			{
				if(r_R_OnMouseDown == null)
				{
					r_R_OnMouseDown = new(this, "_OnMouseDown", 0);
					r_R_OnMouseDown.SetBelong(this.instance);
				}
				return r_R_OnMouseDown;
			}
		}

		/// <summary>
		/// Void ChangeMouseCursorTo(MouseState)
		/// </summary>
		protected RMethod r_RChangeMouseCursorTo_MouseState;
		public virtual RMethod RChangeMouseCursorTo_MouseState
		{
			get
			{
				if(r_RChangeMouseCursorTo_MouseState == null)
				{
					r_RChangeMouseCursorTo_MouseState = new(this, "ChangeMouseCursorTo", 0,  ReleactionUtils.GetType("MouseState"));
					r_RChangeMouseCursorTo_MouseState.SetBelong(this.instance);
				}
				return r_RChangeMouseCursorTo_MouseState;
			}
		}

		/// <summary>
		/// Void ChangeMouseCursorEnd()
		/// </summary>
		protected RMethod r_RChangeMouseCursorEnd;
		public virtual RMethod RChangeMouseCursorEnd
		{
			get
			{
				if(r_RChangeMouseCursorEnd == null)
				{
					r_RChangeMouseCursorEnd = new(this, "ChangeMouseCursorEnd", 0);
					r_RChangeMouseCursorEnd.SetBelong(this.instance);
				}
				return r_RChangeMouseCursorEnd;
			}
		}

		/// <summary>
		/// Boolean CheckCanClick()
		/// </summary>
		protected RMethod r_RCheckCanClick;
		public virtual RMethod RCheckCanClick
		{
			get
			{
				if(r_RCheckCanClick == null)
				{
					r_RCheckCanClick = new(this, "CheckCanClick", 0);
					r_RCheckCanClick.SetBelong(this.instance);
				}
				return r_RCheckCanClick;
			}
		}

		/// <summary>
		/// Void ShowFeedBackMark()
		/// </summary>
		protected RMethod r_RShowFeedBackMark;
		public virtual RMethod RShowFeedBackMark
		{
			get
			{
				if(r_RShowFeedBackMark == null)
				{
					r_RShowFeedBackMark = new(this, "ShowFeedBackMark", 0);
					r_RShowFeedBackMark.SetBelong(this.instance);
				}
				return r_RShowFeedBackMark;
			}
		}

		/// <summary>
		/// Void HideFeedBackMark()
		/// </summary>
		protected RMethod r_RHideFeedBackMark;
		public virtual RMethod RHideFeedBackMark
		{
			get
			{
				if(r_RHideFeedBackMark == null)
				{
					r_RHideFeedBackMark = new(this, "HideFeedBackMark", 0);
					r_RHideFeedBackMark.SetBelong(this.instance);
				}
				return r_RHideFeedBackMark;
			}
		}

		/// <summary>
		/// Void HideBackMark()
		/// </summary>
		protected RMethod r_RHideBackMark;
		public virtual RMethod RHideBackMark
		{
			get
			{
				if(r_RHideBackMark == null)
				{
					r_RHideBackMark = new(this, "HideBackMark", 0);
					r_RHideBackMark.SetBelong(this.instance);
				}
				return r_RHideBackMark;
			}
		}

		/// <summary>
		/// Void SetPopText(Int32, UnityEngine.Color, UnityEngine.FontStyle)
		/// </summary>
		protected RMethod r_RSetPopText_Int32_Color_FontStyle;
		public virtual RMethod RSetPopText_Int32_Color_FontStyle
		{
			get
			{
				if(r_RSetPopText_Int32_Color_FontStyle == null)
				{
					r_RSetPopText_Int32_Color_FontStyle = new(this, "SetPopText", 0, typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.FontStyle));
					r_RSetPopText_Int32_Color_FontStyle.SetBelong(this.instance);
				}
				return r_RSetPopText_Int32_Color_FontStyle;
			}
		}

		/// <summary>
		/// Void SetPopText(System.String, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetPopText_String_Color;
		public virtual RMethod RSetPopText_String_Color
		{
			get
			{
				if(r_RSetPopText_String_Color == null)
				{
					r_RSetPopText_String_Color = new(this, "SetPopText", 0, typeof(System.String), typeof(UnityEngine.Color));
					r_RSetPopText_String_Color.SetBelong(this.instance);
				}
				return r_RSetPopText_String_Color;
			}
		}

		/// <summary>
		/// Void StartPopText(System.String[], Int32)
		/// </summary>
		protected RMethod r_RStartPopText_StringArray_Int32;
		public virtual RMethod RStartPopText_StringArray_Int32
		{
			get
			{
				if(r_RStartPopText_StringArray_Int32 == null)
				{
					r_RStartPopText_StringArray_Int32 = new(this, "StartPopText", 0, typeof(System.String).MakeArrayType(), typeof(System.Int32));
					r_RStartPopText_StringArray_Int32.SetBelong(this.instance);
				}
				return r_RStartPopText_StringArray_Int32;
			}
		}

		/// <summary>
		/// Void StopPopTextStartWith(System.String)
		/// </summary>
		protected RMethod r_RStopPopTextStartWith_String;
		public virtual RMethod RStopPopTextStartWith_String
		{
			get
			{
				if(r_RStopPopTextStartWith_String == null)
				{
					r_RStopPopTextStartWith_String = new(this, "StopPopTextStartWith", 0, typeof(System.String));
					r_RStopPopTextStartWith_String.SetBelong(this.instance);
				}
				return r_RStopPopTextStartWith_String;
			}
		}

		/// <summary>
		/// Void SetProgressBarTipOverHead(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetProgressBarTipOverHead_Object_Object;
		public virtual RMethod RSetProgressBarTipOverHead_Object_Object
		{
			get
			{
				if(r_RSetProgressBarTipOverHead_Object_Object == null)
				{
					r_RSetProgressBarTipOverHead_Object_Object = new(this, "SetProgressBarTipOverHead", 0, typeof(System.Object), typeof(System.Object));
					r_RSetProgressBarTipOverHead_Object_Object.SetBelong(this.instance);
				}
				return r_RSetProgressBarTipOverHead_Object_Object;
			}
		}

		/// <summary>
		/// Void SetProgressBarOverHead(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetProgressBarOverHead_Object_Object;
		public virtual RMethod RSetProgressBarOverHead_Object_Object
		{
			get
			{
				if(r_RSetProgressBarOverHead_Object_Object == null)
				{
					r_RSetProgressBarOverHead_Object_Object = new(this, "SetProgressBarOverHead", 0, typeof(System.Object), typeof(System.Object));
					r_RSetProgressBarOverHead_Object_Object.SetBelong(this.instance);
				}
				return r_RSetProgressBarOverHead_Object_Object;
			}
		}

		/// <summary>
		/// Void SetFamilyBossCDtime(Single)
		/// </summary>
		protected RMethod r_RSetFamilyBossCDtime_Single;
		public virtual RMethod RSetFamilyBossCDtime_Single
		{
			get
			{
				if(r_RSetFamilyBossCDtime_Single == null)
				{
					r_RSetFamilyBossCDtime_Single = new(this, "SetFamilyBossCDtime", 0, typeof(System.Single));
					r_RSetFamilyBossCDtime_Single.SetBelong(this.instance);
				}
				return r_RSetFamilyBossCDtime_Single;
			}
		}

		/// <summary>
		/// Void DrawBubble(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RDrawBubble_Vector3;
		public virtual RMethod RDrawBubble_Vector3
		{
			get
			{
				if(r_RDrawBubble_Vector3 == null)
				{
					r_RDrawBubble_Vector3 = new(this, "DrawBubble", 0, typeof(UnityEngine.Vector3));
					r_RDrawBubble_Vector3.SetBelong(this.instance);
				}
				return r_RDrawBubble_Vector3;
			}
		}

		/// <summary>
		/// Void AddBubble(System.String, Single, Boolean)
		/// </summary>
		protected RMethod r_RAddBubble_String_Single_Boolean;
		public virtual RMethod RAddBubble_String_Single_Boolean
		{
			get
			{
				if(r_RAddBubble_String_Single_Boolean == null)
				{
					r_RAddBubble_String_Single_Boolean = new(this, "AddBubble", 0, typeof(System.String), typeof(System.Single), typeof(System.Boolean));
					r_RAddBubble_String_Single_Boolean.SetBelong(this.instance);
				}
				return r_RAddBubble_String_Single_Boolean;
			}
		}

		/// <summary>
		/// Void AddChatBubble(System.String)
		/// </summary>
		protected RMethod r_RAddChatBubble_String;
		public virtual RMethod RAddChatBubble_String
		{
			get
			{
				if(r_RAddChatBubble_String == null)
				{
					r_RAddChatBubble_String = new(this, "AddChatBubble", 0, typeof(System.String));
					r_RAddChatBubble_String.SetBelong(this.instance);
				}
				return r_RAddChatBubble_String;
			}
		}

		/// <summary>
		/// Void ClearBubbles()
		/// </summary>
		protected RMethod r_RClearBubbles;
		public virtual RMethod RClearBubbles
		{
			get
			{
				if(r_RClearBubbles == null)
				{
					r_RClearBubbles = new(this, "ClearBubbles", 0);
					r_RClearBubbles.SetBelong(this.instance);
				}
				return r_RClearBubbles;
			}
		}

		/// <summary>
		/// Void PlayBigFace(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RPlayBigFace_ID;
		public virtual RMethod RPlayBigFace_ID
		{
			get
			{
				if(r_RPlayBigFace_ID == null)
				{
					r_RPlayBigFace_ID = new(this, "PlayBigFace", 0, typeof(GameDefineType.ID));
					r_RPlayBigFace_ID.SetBelong(this.instance);
				}
				return r_RPlayBigFace_ID;
			}
		}

		/// <summary>
		/// Void setEscort(Boolean)
		/// </summary>
		protected RMethod r_RsetEscort_Boolean;
		public virtual RMethod RsetEscort_Boolean
		{
			get
			{
				if(r_RsetEscort_Boolean == null)
				{
					r_RsetEscort_Boolean = new(this, "setEscort", 0, typeof(System.Boolean));
					r_RsetEscort_Boolean.SetBelong(this.instance);
				}
				return r_RsetEscort_Boolean;
			}
		}

		/// <summary>
		/// Boolean isEscort()
		/// </summary>
		protected RMethod r_RisEscort;
		public virtual RMethod RisEscort
		{
			get
			{
				if(r_RisEscort == null)
				{
					r_RisEscort = new(this, "isEscort", 0);
					r_RisEscort.SetBelong(this.instance);
				}
				return r_RisEscort;
			}
		}

		/// <summary>
		/// Void SetTransfigurationType(Int32)
		/// </summary>
		protected RMethod r_RSetTransfigurationType_Int32;
		public virtual RMethod RSetTransfigurationType_Int32
		{
			get
			{
				if(r_RSetTransfigurationType_Int32 == null)
				{
					r_RSetTransfigurationType_Int32 = new(this, "SetTransfigurationType", 0, typeof(System.Int32));
					r_RSetTransfigurationType_Int32.SetBelong(this.instance);
				}
				return r_RSetTransfigurationType_Int32;
			}
		}

		/// <summary>
		/// Int32 GetTransfigurationType()
		/// </summary>
		protected RMethod r_RGetTransfigurationType;
		public virtual RMethod RGetTransfigurationType
		{
			get
			{
				if(r_RGetTransfigurationType == null)
				{
					r_RGetTransfigurationType = new(this, "GetTransfigurationType", 0);
					r_RGetTransfigurationType.SetBelong(this.instance);
				}
				return r_RGetTransfigurationType;
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


        public RNPCBehav() : base("NPCBehav")
        {
        }

        public RNPCBehav(System.Object instance) : base("NPCBehav")
		{
            SetInstance(instance);
		}

        public RNPCBehav(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNPCBehav(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnBecameVisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBecameVisible.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnBecameInvisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnBecameInvisible.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartDownLand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStartDownLand.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDownLand()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDownLand.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetVisible(System.Boolean  @bl, UnityEngine.Transform  @trans)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl, @trans};
            var ___result = RSetVisible_Boolean_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object SearchTargetInRange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSearchTargetInRange.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void NPCAIUpdate(System.Single  @deltatime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@deltatime};
            var ___result = RNPCAIUpdate_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMoveMsg(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RSendMoveMsg_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GoTo(UnityEngine.Vector3  @destination, System.Single  @speed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @speed};
            var ___result = RGoTo_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Pursuit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPursuit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Flee()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlee.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReturnToBirthPoint(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RReturnToBirthPoint_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateMovement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateMovement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDialogOpen(System.Boolean  @bOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bOpen};
            var ___result = RSetDialogOpen_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnSearchCompleted()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnSearchCompleted.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAnimationState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetAnimationState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayAnim(System.String  @animname, System.Boolean  @bLoop, System.Int32  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animname, @bLoop, @time};
            var ___result = RPlayAnim_String_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayAnim(System.String  @animname, System.Boolean  @bLoop, System.Int32  @time, System.Single  @timeDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animname, @bLoop, @time, @timeDelay};
            var ___result = RPlayAnim_String_Boolean_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator PlayAnimDelay(System.String  @animname, System.Boolean  @bLoop, System.Int32  @time, System.Single  @timeDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animname, @bLoop, @time, @timeDelay};
            var ___result = RPlayAnimDelay_String_Boolean_Int32_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator AnimationCullTypeReset(UnityEngine.Animation  @ani, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ani, @time};
            var ___result = RAnimationCullTypeReset_Animation_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void UpdateSpecAnim()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateSpecAnim.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator WaitForSpecAnim()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWaitForSpecAnim.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator WaitForIdleAnim(System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RWaitForIdleAnim_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void UpdateAnim()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAnim.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CrossFadeAnim(System.String  @animname, System.Boolean  @bLoop)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animname, @bLoop};
            var ___result = RCrossFadeAnim_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitBubble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitBubble.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnNpcBubble(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = ROnNpcBubble_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnNpcBubbleRandom()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnNpcBubbleRandom.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowNpcBubbleList(System.Collections.Generic.List<BubbleContent>  @contentList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@contentList};
            var ___result = RShowNpcBubbleList_List_d_BubbleContent_p_.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Collections.IEnumerator ShowNpcBubble(BubbleContent  @content, System.Single  @timeDelay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@content, @timeDelay};
            var ___result = RShowNpcBubble_BubbleContent_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void _OnMouseEnter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseEnter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseOver()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseOver.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseExit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseExit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnMouseUp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseDownEx(System.Boolean  @isAutoFind)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isAutoFind};
            var ___result = ROnMouseDownEx_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnMouseDownEx(System.Boolean  @isAutoFind, System.String  @selection)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isAutoFind, @selection};
            var ___result = ROnMouseDownEx_Boolean_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendNpcTrigger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendNpcTrigger.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseUp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseRightDown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseRightDown.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void FinishOpenChest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishOpenChest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetupTrigger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetupTrigger.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ParseTriggerName(System.String  @script)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@script};
            var ___result = RParseTriggerName_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object[] ParseTriggerParams(System.String  @script)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@script};
            var ___result = RParseTriggerParams_String.Invoke(___genericsType, ___parameters);

            return (System.Object[])___result;
        }


        public virtual void InvokeTriggerInit(UnityEngine.Component  @comp, System.Object[]  @parameters)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@comp, @parameters};
            var ___result = RInvokeTriggerInit_Component_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowFuncIcon()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowFuncIcon.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetIconGray(System.Boolean  @bl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl};
            var ___result = RSetIconGray_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean CheckPlayerViewRange()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckPlayerViewRange.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsInPlayerVision()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInPlayerVision.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnGotoMsg(UnityEngine.Vector3  @destination, System.Single  @speed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @speed};
            var ___result = ROnGotoMsg_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPatrolMsg(UnityEngine.Vector3  @destination, System.Single  @speed, System.Boolean  @bHide)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@destination, @speed, @bHide};
            var ___result = ROnPatrolMsg_Vector3_Single_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopPatrol()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopPatrol.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CommonUpdate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCommonUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnableAICtrl(System.Boolean  @bEnable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bEnable};
            var ___result = REnableAICtrl_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitAICtrl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitAICtrl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPlayerInVision()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPlayerInVision.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ChangeMouseCursor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChangeMouseCursor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawNameGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawNameGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawHPBar(UnityEngine.Vector2  @vStatus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vStatus};
            var ___result = RDrawHPBar_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNameText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetNameText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FadeRemove()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFadeRemove.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ResetNPCRotation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetNPCRotation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ModelLimited()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RModelLimited.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.IEnumerator CheckModleDownLoad()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckModleDownLoad.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void OnLoadedResetAnimation(UnityEngine.Animation  @anim)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@anim};
            var ___result = ROnLoadedResetAnimation_Animation.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator OnModleLoadedReset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnModleLoadedReset.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void SpaceTrigger()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSpaceTrigger.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateInGhost(System.Single  @frameTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@frameTime};
            var ___result = RUpdateInGhost_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateSusGhost(System.Single  @frameTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@frameTime};
            var ___result = RUpdateSusGhost_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateOutGhost()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateOutGhost.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveTowards(UnityEngine.Vector3  @position, System.Single  @frameTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @frameTime};
            var ___result = RMoveTowards_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveToNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToNext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishEscortMove()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishEscortMove.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopMove()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopMove.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestartMove(System.Single  @speed)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@speed};
            var ___result = RRestartMove_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCarrierColor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetCarrierColor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ChangeCarrierState(System.Int32  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RChangeCarrierState_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BreakCarrier(System.Int32  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RBreakCarrier_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator ClientPatrol()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClientPatrol.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void SetPosition(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RSetPosition_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetExtraIconUrl(System.String[]  @iconnames)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconnames};
            var ___result = RSetExtraIconUrl_StringArray.Invoke(___genericsType, ___parameters);

            
        }



        public virtual UnityEngine.Vector3 GetOverHeadHightOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetOverHeadHightOffset.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void _Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_Update.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawText(System.String  @text, System.Boolean  @bNeedShadow, UnityEngine.Rect  @statusRect, System.Single  @labelWidth, UnityEngine.GUIStyle  @textStyle, UnityEngine.GUIStyle  @shadowStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @bNeedShadow, @statusRect, @labelWidth, @textStyle, @shadowStyle};
            var ___result = RDrawText_String_Boolean_Rect_Single_GUIStyle_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawPopText(UnityEngine.Vector2  @vStatus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vStatus};
            var ___result = RDrawPopText_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawWildKillCount(UnityEngine.Vector2  @vStatus)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vStatus};
            var ___result = RDrawWildKillCount_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawCombatNameGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawCombatNameGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateNameText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateNameText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 GetDrawName3DPos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDrawName3DPos.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }



        public virtual void CreatureFadeRest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreatureFadeRest.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetFadeSpeed(System.Single  @fadespd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fadespd};
            var ___result = RSetFadeSpeed_Single.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void SetTransparentModel(System.Boolean  @visible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@visible};
            var ___result = RSetTransparentModel_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TransparentModel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTransparentModel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HideCreature()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHideCreature.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HideCreature(System.Boolean  @isIncombat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isIncombat};
            var ___result = RHideCreature_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnHideCreature()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnHideCreature.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnHideCreatureInCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnHideCreatureInCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetDeadCreature()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDeadCreature.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDestroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeadInCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDeadInCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReliveCreature(System.Boolean  @bForceRelive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bForceRelive};
            var ___result = RReliveCreature_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetVisibleState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetVisibleState.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean CheckCreatureVisible()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckCreatureVisible.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CreatureVisibleRest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCreatureVisibleRest.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateLoveName(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RUpdateLoveName_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseDown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseDown.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ChangeMouseCursorEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RChangeMouseCursorEnd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckCanClick()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckCanClick.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ShowFeedBackMark()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowFeedBackMark.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HideFeedBackMark()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHideFeedBackMark.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HideBackMark()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHideBackMark.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPopText(System.Int32  @size, UnityEngine.Color  @color, UnityEngine.FontStyle  @_fontStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@size, @color, @_fontStyle};
            var ___result = RSetPopText_Int32_Color_FontStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPopText(System.String  @text, UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @color};
            var ___result = RSetPopText_String_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartPopText(System.String[]  @text, System.Int32  @showMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @showMode};
            var ___result = RStartPopText_StringArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopPopTextStartWith(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RStopPopTextStartWith_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProgressBarTipOverHead(System.Object  @olddata, System.Object  @newdata)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@olddata, @newdata};
            var ___result = RSetProgressBarTipOverHead_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProgressBarOverHead(System.Object  @olddata, System.Object  @newdata)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@olddata, @newdata};
            var ___result = RSetProgressBarOverHead_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetFamilyBossCDtime(System.Single  @_time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_time};
            var ___result = RSetFamilyBossCDtime_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawBubble(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RDrawBubble_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddBubble(System.String  @talkinContent, System.Single  @time, System.Boolean  @isInCombat)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@talkinContent, @time, @isInCombat};
            var ___result = RAddBubble_String_Single_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddChatBubble(System.String  @talkinContent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@talkinContent};
            var ___result = RAddChatBubble_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearBubbles()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearBubbles.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayBigFace(GameDefineType.ID  @faceId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@faceId};
            var ___result = RPlayBigFace_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void setEscort(System.Boolean  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b};
            var ___result = RsetEscort_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean isEscort()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RisEscort.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetTransfigurationType(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RSetTransfigurationType_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetTransfigurationType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTransfigurationType.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
