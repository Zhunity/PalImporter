using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// NetPlayCombatCtr
	/// </summary>
    public partial class RNetPlayCombatCtr : RMember //
    {

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
		/// Void TriggerPk()
		/// </summary>
		protected RMethod r_RTriggerPk;
		public virtual RMethod RTriggerPk
		{
			get
			{
				if(r_RTriggerPk == null)
				{
					r_RTriggerPk = new(this, "TriggerPk", 0);
					r_RTriggerPk.SetBelong(this.instance);
				}
				return r_RTriggerPk;
			}
		}

		/// <summary>
		/// Void TriggerFight()
		/// </summary>
		protected RMethod r_RTriggerFight;
		public virtual RMethod RTriggerFight
		{
			get
			{
				if(r_RTriggerFight == null)
				{
					r_RTriggerFight = new(this, "TriggerFight", 0);
					r_RTriggerFight.SetBelong(this.instance);
				}
				return r_RTriggerFight;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator EnterCombatWait()
		/// </summary>
		protected RMethod r_REnterCombatWait;
		public virtual RMethod REnterCombatWait
		{
			get
			{
				if(r_REnterCombatWait == null)
				{
					r_REnterCombatWait = new(this, "EnterCombatWait", 0);
					r_REnterCombatWait.SetBelong(this.instance);
				}
				return r_REnterCombatWait;
			}
		}

		/// <summary>
		/// Void EnterCombat()
		/// </summary>
		protected RMethod r_REnterCombat;
		public virtual RMethod REnterCombat
		{
			get
			{
				if(r_REnterCombat == null)
				{
					r_REnterCombat = new(this, "EnterCombat", 0);
					r_REnterCombat.SetBelong(this.instance);
				}
				return r_REnterCombat;
			}
		}

		/// <summary>
		/// Void LeaveCombat()
		/// </summary>
		protected RMethod r_RLeaveCombat;
		public virtual RMethod RLeaveCombat
		{
			get
			{
				if(r_RLeaveCombat == null)
				{
					r_RLeaveCombat = new(this, "LeaveCombat", 0);
					r_RLeaveCombat.SetBelong(this.instance);
				}
				return r_RLeaveCombat;
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


        public RNetPlayCombatCtr() : base("NetPlayCombatCtr")
        {
        }

        public RNetPlayCombatCtr(System.Object instance) : base("NetPlayCombatCtr")
		{
            SetInstance(instance);
		}

        public RNetPlayCombatCtr(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNetPlayCombatCtr(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual void OnRoundStart(System.Int32  @mRound)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mRound};
            var ___result = ROnRoundStart_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerPk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTriggerPk.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TriggerFight()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTriggerFight.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator EnterCombatWait()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnterCombatWait.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void EnterCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnterCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LeaveCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLeaveCombat.Invoke(___genericsType, ___parameters);

            
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


        public virtual void CheckLife()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckLife.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetScoreEffect(System.Int32  @score)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@score};
            var ___result = RSetScoreEffect_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearSkillIcon(GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = RClearSkillIcon_ID.Invoke(___genericsType, ___parameters);

            
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


        public virtual void PositionRest()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPositionRest.Invoke(___genericsType, ___parameters);

            
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


        public virtual void DodgeEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDodgeEffect.Invoke(___genericsType, ___parameters);

            
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
