using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CreatureBehav
	/// </summary>
    public partial class RCreatureBehav : RMember //
    {

		/// <summary>
		/// System.Single MAX_POPTEXT_TIME
		/// </summary>
		protected static RField r_MAX_POPTEXT_TIME;
		public static RField RMAX_POPTEXT_TIME
		{
			get
			{
				if(r_MAX_POPTEXT_TIME == null)
				{
					r_MAX_POPTEXT_TIME = new( ReleactionUtils.GetType("CreatureBehav"), "MAX_POPTEXT_TIME");
					r_MAX_POPTEXT_TIME.SetBelong(null);
				}
				return r_MAX_POPTEXT_TIME;
			}
		}

		/// <summary>
		/// System.Single MAX_PROCESS_WIDTH
		/// </summary>
		protected static RField r_MAX_PROCESS_WIDTH;
		public static RField RMAX_PROCESS_WIDTH
		{
			get
			{
				if(r_MAX_PROCESS_WIDTH == null)
				{
					r_MAX_PROCESS_WIDTH = new( ReleactionUtils.GetType("CreatureBehav"), "MAX_PROCESS_WIDTH");
					r_MAX_PROCESS_WIDTH.SetBelong(null);
				}
				return r_MAX_PROCESS_WIDTH;
			}
		}

		/// <summary>
		/// System.Single MAX_PROCESS_HEIGHT
		/// </summary>
		protected static RField r_MAX_PROCESS_HEIGHT;
		public static RField RMAX_PROCESS_HEIGHT
		{
			get
			{
				if(r_MAX_PROCESS_HEIGHT == null)
				{
					r_MAX_PROCESS_HEIGHT = new( ReleactionUtils.GetType("CreatureBehav"), "MAX_PROCESS_HEIGHT");
					r_MAX_PROCESS_HEIGHT.SetBelong(null);
				}
				return r_MAX_PROCESS_HEIGHT;
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
		/// UnityEngine.Renderer creatureRenderer
		/// </summary>
		protected RUnityEngine.RRenderer r_creatureRenderer;
		public virtual RUnityEngine.RRenderer RcreatureRenderer
		{
			get
			{
				if(r_creatureRenderer == null)
				{
					r_creatureRenderer = new(this, "creatureRenderer");
					r_creatureRenderer.SetBelong(this.instance);
				}
				return r_creatureRenderer;
			}
		}

		/// <summary>
		/// UnityEngine.Transform _transform
		/// </summary>
		protected RUnityEngine.RTransform r__transform;
		public virtual RUnityEngine.RTransform R_transform
		{
			get
			{
				if(r__transform == null)
				{
					r__transform = new(this, "_transform");
					r__transform.SetBelong(this.instance);
				}
				return r__transform;
			}
		}

		/// <summary>
		/// UnityEngine.CharacterController _cc
		/// </summary>
		protected RUnityEngine.RCharacterController r__cc;
		public virtual RUnityEngine.RCharacterController R_cc
		{
			get
			{
				if(r__cc == null)
				{
					r__cc = new(this, "_cc");
					r__cc.SetBelong(this.instance);
				}
				return r__cc;
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
		/// CreatureBehav+IS_IN_VISION _state
		/// </summary>
		protected RField r__state;
		public virtual RField R_state
		{
			get
			{
				if(r__state == null)
				{
					r__state = new(this, "_state");
					r__state.SetBelong(this.instance);
				}
				return r__state;
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
		/// System.Boolean guiHideFlag
		/// </summary>
		protected static RField r_guiHideFlag;
		public static RField RguiHideFlag
		{
			get
			{
				if(r_guiHideFlag == null)
				{
					r_guiHideFlag = new( ReleactionUtils.GetType("CreatureBehav"), "guiHideFlag");
					r_guiHideFlag.SetBelong(null);
				}
				return r_guiHideFlag;
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
		/// UnityEngine.GUIStyle _mGMGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__mGMGUIStyle;
		public virtual RUnityEngine.RGUIStyle R_mGMGUIStyle
		{
			get
			{
				if(r__mGMGUIStyle == null)
				{
					r__mGMGUIStyle = new(this, "_mGMGUIStyle");
					r__mGMGUIStyle.SetBelong(this.instance);
				}
				return r__mGMGUIStyle;
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
		/// UnityEngine.Vector3 m_nameTextOffset3D
		/// </summary>
		protected RUnityEngine.RVector3 r_m_nameTextOffset3D;
		public virtual RUnityEngine.RVector3 Rm_nameTextOffset3D
		{
			get
			{
				if(r_m_nameTextOffset3D == null)
				{
					r_m_nameTextOffset3D = new(this, "m_nameTextOffset3D");
					r_m_nameTextOffset3D.SetBelong(this.instance);
				}
				return r_m_nameTextOffset3D;
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
		/// UnityEngine.GUIStyle _mLabelShadowStyle
		/// </summary>
		protected static RUnityEngine.RGUIStyle r__mLabelShadowStyle;
		public static RUnityEngine.RGUIStyle R_mLabelShadowStyle
		{
			get
			{
				if(r__mLabelShadowStyle == null)
				{
					r__mLabelShadowStyle = new( ReleactionUtils.GetType("CreatureBehav"), "_mLabelShadowStyle");
					r__mLabelShadowStyle.SetBelong(null);
				}
				return r__mLabelShadowStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _mLabelShadowStyle2
		/// </summary>
		protected static RUnityEngine.RGUIStyle r__mLabelShadowStyle2;
		public static RUnityEngine.RGUIStyle R_mLabelShadowStyle2
		{
			get
			{
				if(r__mLabelShadowStyle2 == null)
				{
					r__mLabelShadowStyle2 = new( ReleactionUtils.GetType("CreatureBehav"), "_mLabelShadowStyle2");
					r__mLabelShadowStyle2.SetBelong(null);
				}
				return r__mLabelShadowStyle2;
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
		/// UnityEngine.GUIStyle _PostIconStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__PostIconStyle;
		public virtual RUnityEngine.RGUIStyle R_PostIconStyle
		{
			get
			{
				if(r__PostIconStyle == null)
				{
					r__PostIconStyle = new(this, "_PostIconStyle");
					r__PostIconStyle.SetBelong(this.instance);
				}
				return r__PostIconStyle;
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
		/// UnityEngine.GUIStyle _VIPIconStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r__VIPIconStyle;
		public virtual RUnityEngine.RGUIStyle R_VIPIconStyle
		{
			get
			{
				if(r__VIPIconStyle == null)
				{
					r__VIPIconStyle = new(this, "_VIPIconStyle");
					r__VIPIconStyle.SetBelong(this.instance);
				}
				return r__VIPIconStyle;
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
		/// System.Int32 m_nMaxHealthPoint
		/// </summary>
		protected RField r_m_nMaxHealthPoint;
		public virtual RField Rm_nMaxHealthPoint
		{
			get
			{
				if(r_m_nMaxHealthPoint == null)
				{
					r_m_nMaxHealthPoint = new(this, "m_nMaxHealthPoint");
					r_m_nMaxHealthPoint.SetBelong(this.instance);
				}
				return r_m_nMaxHealthPoint;
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
		/// System.Int32 m_nHealthPoint
		/// </summary>
		protected RField r_m_nHealthPoint;
		public virtual RField Rm_nHealthPoint
		{
			get
			{
				if(r_m_nHealthPoint == null)
				{
					r_m_nHealthPoint = new(this, "m_nHealthPoint");
					r_m_nHealthPoint.SetBelong(this.instance);
				}
				return r_m_nHealthPoint;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _healthPointStyle
		/// </summary>
		protected static RUnityEngine.RGUIStyle r__healthPointStyle;
		public static RUnityEngine.RGUIStyle R_healthPointStyle
		{
			get
			{
				if(r__healthPointStyle == null)
				{
					r__healthPointStyle = new( ReleactionUtils.GetType("CreatureBehav"), "_healthPointStyle");
					r__healthPointStyle.SetBelong(null);
				}
				return r__healthPointStyle;
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
		/// System.Boolean m_MouseOver
		/// </summary>
		protected RField r_m_MouseOver;
		public virtual RField Rm_MouseOver
		{
			get
			{
				if(r_m_MouseOver == null)
				{
					r_m_MouseOver = new(this, "m_MouseOver");
					r_m_MouseOver.SetBelong(this.instance);
				}
				return r_m_MouseOver;
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
		/// UnityEngine.GameObject feedBackMark
		/// </summary>
		protected static RUnityEngine.RGameObject r_feedBackMark;
		public static RUnityEngine.RGameObject RfeedBackMark
		{
			get
			{
				if(r_feedBackMark == null)
				{
					r_feedBackMark = new( ReleactionUtils.GetType("CreatureBehav"), "feedBackMark");
					r_feedBackMark.SetBelong(null);
				}
				return r_feedBackMark;
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
		/// UnityEngine.GUIStyle _mPopTextShadowGUIStyle
		/// </summary>
		protected static RUnityEngine.RGUIStyle r__mPopTextShadowGUIStyle;
		public static RUnityEngine.RGUIStyle R_mPopTextShadowGUIStyle
		{
			get
			{
				if(r__mPopTextShadowGUIStyle == null)
				{
					r__mPopTextShadowGUIStyle = new( ReleactionUtils.GetType("CreatureBehav"), "_mPopTextShadowGUIStyle");
					r__mPopTextShadowGUIStyle.SetBelong(null);
				}
				return r__mPopTextShadowGUIStyle;
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
		/// UnityEngine.Vector2 _statusPos
		/// </summary>
		protected RUnityEngine.RVector2 r__statusPos;
		public virtual RUnityEngine.RVector2 R_statusPos
		{
			get
			{
				if(r__statusPos == null)
				{
					r__statusPos = new(this, "_statusPos");
					r__statusPos.SetBelong(this.instance);
				}
				return r__statusPos;
			}
		}

		/// <summary>
		/// System.Single m_fProcessBarVal
		/// </summary>
		protected RField r_m_fProcessBarVal;
		public virtual RField Rm_fProcessBarVal
		{
			get
			{
				if(r_m_fProcessBarVal == null)
				{
					r_m_fProcessBarVal = new(this, "m_fProcessBarVal");
					r_m_fProcessBarVal.SetBelong(this.instance);
				}
				return r_m_fProcessBarVal;
			}
		}

		/// <summary>
		/// System.Single m_fMaxProcessBarVal
		/// </summary>
		protected RField r_m_fMaxProcessBarVal;
		public virtual RField Rm_fMaxProcessBarVal
		{
			get
			{
				if(r_m_fMaxProcessBarVal == null)
				{
					r_m_fMaxProcessBarVal = new(this, "m_fMaxProcessBarVal");
					r_m_fMaxProcessBarVal.SetBelong(this.instance);
				}
				return r_m_fMaxProcessBarVal;
			}
		}

		/// <summary>
		/// System.String m_sProcessBarTip
		/// </summary>
		protected RField r_m_sProcessBarTip;
		public virtual RField Rm_sProcessBarTip
		{
			get
			{
				if(r_m_sProcessBarTip == null)
				{
					r_m_sProcessBarTip = new(this, "m_sProcessBarTip");
					r_m_sProcessBarTip.SetBelong(this.instance);
				}
				return r_m_sProcessBarTip;
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
		/// UnityEngine.GUIStyle _progressBarStyleBg
		/// </summary>
		protected static RUnityEngine.RGUIStyle r__progressBarStyleBg;
		public static RUnityEngine.RGUIStyle R_progressBarStyleBg
		{
			get
			{
				if(r__progressBarStyleBg == null)
				{
					r__progressBarStyleBg = new( ReleactionUtils.GetType("CreatureBehav"), "_progressBarStyleBg");
					r__progressBarStyleBg.SetBelong(null);
				}
				return r__progressBarStyleBg;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _teamProtectionStyle
		/// </summary>
		protected static RUnityEngine.RGUIStyle r__teamProtectionStyle;
		public static RUnityEngine.RGUIStyle R_teamProtectionStyle
		{
			get
			{
				if(r__teamProtectionStyle == null)
				{
					r__teamProtectionStyle = new( ReleactionUtils.GetType("CreatureBehav"), "_teamProtectionStyle");
					r__teamProtectionStyle.SetBelong(null);
				}
				return r__teamProtectionStyle;
			}
		}

		/// <summary>
		/// System.Boolean m_bUpdateProgressBar
		/// </summary>
		protected RField r_m_bUpdateProgressBar;
		public virtual RField Rm_bUpdateProgressBar
		{
			get
			{
				if(r_m_bUpdateProgressBar == null)
				{
					r_m_bUpdateProgressBar = new(this, "m_bUpdateProgressBar");
					r_m_bUpdateProgressBar.SetBelong(this.instance);
				}
				return r_m_bUpdateProgressBar;
			}
		}

		/// <summary>
		/// System.Single m_CDtimeMax
		/// </summary>
		protected RField r_m_CDtimeMax;
		public virtual RField Rm_CDtimeMax
		{
			get
			{
				if(r_m_CDtimeMax == null)
				{
					r_m_CDtimeMax = new(this, "m_CDtimeMax");
					r_m_CDtimeMax.SetBelong(this.instance);
				}
				return r_m_CDtimeMax;
			}
		}

		/// <summary>
		/// System.Single m_CDtimeLeft
		/// </summary>
		protected RField r_m_CDtimeLeft;
		public virtual RField Rm_CDtimeLeft
		{
			get
			{
				if(r_m_CDtimeLeft == null)
				{
					r_m_CDtimeLeft = new(this, "m_CDtimeLeft");
					r_m_CDtimeLeft.SetBelong(this.instance);
				}
				return r_m_CDtimeLeft;
			}
		}

		/// <summary>
		/// System.Int32 m_ProgressBarWidth
		/// </summary>
		protected RField r_m_ProgressBarWidth;
		public virtual RField Rm_ProgressBarWidth
		{
			get
			{
				if(r_m_ProgressBarWidth == null)
				{
					r_m_ProgressBarWidth = new(this, "m_ProgressBarWidth");
					r_m_ProgressBarWidth.SetBelong(this.instance);
				}
				return r_m_ProgressBarWidth;
			}
		}

		/// <summary>
		/// System.Int32 m_ProgressBarHeight
		/// </summary>
		protected RField r_m_ProgressBarHeight;
		public virtual RField Rm_ProgressBarHeight
		{
			get
			{
				if(r_m_ProgressBarHeight == null)
				{
					r_m_ProgressBarHeight = new(this, "m_ProgressBarHeight");
					r_m_ProgressBarHeight.SetBelong(this.instance);
				}
				return r_m_ProgressBarHeight;
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
		/// System.Int32 iFrameNum
		/// </summary>
		protected RField r_iFrameNum;
		public virtual RField RiFrameNum
		{
			get
			{
				if(r_iFrameNum == null)
				{
					r_iFrameNum = new(this, "iFrameNum");
					r_iFrameNum.SetBelong(this.instance);
				}
				return r_iFrameNum;
			}
		}

		/// <summary>
		/// System.Int32 iFrameCnt
		/// </summary>
		protected RField r_iFrameCnt;
		public virtual RField RiFrameCnt
		{
			get
			{
				if(r_iFrameCnt == null)
				{
					r_iFrameCnt = new(this, "iFrameCnt");
					r_iFrameCnt.SetBelong(this.instance);
				}
				return r_iFrameCnt;
			}
		}

		/// <summary>
		/// System.Single fSpeed
		/// </summary>
		protected RField r_fSpeed;
		public virtual RField RfSpeed
		{
			get
			{
				if(r_fSpeed == null)
				{
					r_fSpeed = new(this, "fSpeed");
					r_fSpeed.SetBelong(this.instance);
				}
				return r_fSpeed;
			}
		}

		/// <summary>
		/// System.Single fSpeedDelta
		/// </summary>
		protected RField r_fSpeedDelta;
		public virtual RField RfSpeedDelta
		{
			get
			{
				if(r_fSpeedDelta == null)
				{
					r_fSpeedDelta = new(this, "fSpeedDelta");
					r_fSpeedDelta.SetBelong(this.instance);
				}
				return r_fSpeedDelta;
			}
		}

		/// <summary>
		/// System.Int32 FaceIndexX
		/// </summary>
		protected RField r_FaceIndexX;
		public virtual RField RFaceIndexX
		{
			get
			{
				if(r_FaceIndexX == null)
				{
					r_FaceIndexX = new(this, "FaceIndexX");
					r_FaceIndexX.SetBelong(this.instance);
				}
				return r_FaceIndexX;
			}
		}

		/// <summary>
		/// System.Int32 FaceIndexY
		/// </summary>
		protected RField r_FaceIndexY;
		public virtual RField RFaceIndexY
		{
			get
			{
				if(r_FaceIndexY == null)
				{
					r_FaceIndexY = new(this, "FaceIndexY");
					r_FaceIndexY.SetBelong(this.instance);
				}
				return r_FaceIndexY;
			}
		}

		/// <summary>
		/// System.Int32 FaceStartIndex
		/// </summary>
		protected RField r_FaceStartIndex;
		public virtual RField RFaceStartIndex
		{
			get
			{
				if(r_FaceStartIndex == null)
				{
					r_FaceStartIndex = new(this, "FaceStartIndex");
					r_FaceStartIndex.SetBelong(this.instance);
				}
				return r_FaceStartIndex;
			}
		}

		/// <summary>
		/// System.Single BigFaceTimerDelta
		/// </summary>
		protected RField r_BigFaceTimerDelta;
		public virtual RField RBigFaceTimerDelta
		{
			get
			{
				if(r_BigFaceTimerDelta == null)
				{
					r_BigFaceTimerDelta = new(this, "BigFaceTimerDelta");
					r_BigFaceTimerDelta.SetBelong(this.instance);
				}
				return r_BigFaceTimerDelta;
			}
		}

		/// <summary>
		/// System.Single BigFaceSustainTime
		/// </summary>
		protected RField r_BigFaceSustainTime;
		public virtual RField RBigFaceSustainTime
		{
			get
			{
				if(r_BigFaceSustainTime == null)
				{
					r_BigFaceSustainTime = new(this, "BigFaceSustainTime");
					r_BigFaceSustainTime.SetBelong(this.instance);
				}
				return r_BigFaceSustainTime;
			}
		}

		/// <summary>
		/// System.Boolean m_bEscort
		/// </summary>
		protected RField r_m_bEscort;
		public virtual RField Rm_bEscort
		{
			get
			{
				if(r_m_bEscort == null)
				{
					r_m_bEscort = new(this, "m_bEscort");
					r_m_bEscort.SetBelong(this.instance);
				}
				return r_m_bEscort;
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
		/// System.Int32 m_transfigurationType
		/// </summary>
		protected RField r_m_transfigurationType;
		public virtual RField Rm_transfigurationType
		{
			get
			{
				if(r_m_transfigurationType == null)
				{
					r_m_transfigurationType = new(this, "m_transfigurationType");
					r_m_transfigurationType.SetBelong(this.instance);
				}
				return r_m_transfigurationType;
			}
		}

		/// <summary>
		/// System.Boolean <HasDiamond>k__BackingField
		/// </summary>
		protected RField r___2__HasDiamond__4__k__BackingField;
		public virtual RField R__2__HasDiamond__4__k__BackingField
		{
			get
			{
				if(r___2__HasDiamond__4__k__BackingField == null)
				{
					r___2__HasDiamond__4__k__BackingField = new(this, "<HasDiamond>k__BackingField");
					r___2__HasDiamond__4__k__BackingField.SetBelong(this.instance);
				}
				return r___2__HasDiamond__4__k__BackingField;
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
		/// UnityEngine.CharacterController Cctr
		/// </summary>
		protected RUnityEngine.RCharacterController r_Cctr;
		public virtual RUnityEngine.RCharacterController RCctr
		{
			get
			{
				if(r_Cctr == null)
				{
					r_Cctr = new(this, "Cctr", -1);
					r_Cctr.SetBelong(this.instance);
				}
				return r_Cctr;
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
		/// UnityEngine.GUIStyle mLabelShadowStyle
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_mLabelShadowStyle;
		public static RUnityEngine.RGUIStyle RmLabelShadowStyle
		{
			get
			{
				if(r_mLabelShadowStyle == null)
				{
					r_mLabelShadowStyle = new( ReleactionUtils.GetType("CreatureBehav"), "mLabelShadowStyle", -1);
					r_mLabelShadowStyle.SetBelong(null);
				}
				return r_mLabelShadowStyle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mLabelShadowStyle2
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_mLabelShadowStyle2;
		public static RUnityEngine.RGUIStyle RmLabelShadowStyle2
		{
			get
			{
				if(r_mLabelShadowStyle2 == null)
				{
					r_mLabelShadowStyle2 = new( ReleactionUtils.GetType("CreatureBehav"), "mLabelShadowStyle2", -1);
					r_mLabelShadowStyle2.SetBelong(null);
				}
				return r_mLabelShadowStyle2;
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
		/// UnityEngine.GUIStyle m_healthPointStyle
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_m_healthPointStyle;
		public static RUnityEngine.RGUIStyle Rm_healthPointStyle
		{
			get
			{
				if(r_m_healthPointStyle == null)
				{
					r_m_healthPointStyle = new( ReleactionUtils.GetType("CreatureBehav"), "m_healthPointStyle", -1);
					r_m_healthPointStyle.SetBelong(null);
				}
				return r_m_healthPointStyle;
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
		/// UnityEngine.GameObject FeedBackMark
		/// </summary>
		protected static RUnityEngine.RGameObject r_FeedBackMark;
		public static RUnityEngine.RGameObject RFeedBackMark
		{
			get
			{
				if(r_FeedBackMark == null)
				{
					r_FeedBackMark = new( ReleactionUtils.GetType("CreatureBehav"), "FeedBackMark", -1);
					r_FeedBackMark.SetBelong(null);
				}
				return r_FeedBackMark;
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
		/// UnityEngine.GUIStyle mPopTextShadowGUIStyle
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_mPopTextShadowGUIStyle;
		public static RUnityEngine.RGUIStyle RmPopTextShadowGUIStyle
		{
			get
			{
				if(r_mPopTextShadowGUIStyle == null)
				{
					r_mPopTextShadowGUIStyle = new( ReleactionUtils.GetType("CreatureBehav"), "mPopTextShadowGUIStyle", -1);
					r_mPopTextShadowGUIStyle.SetBelong(null);
				}
				return r_mPopTextShadowGUIStyle;
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
		/// UnityEngine.GUIStyle m_ProgressBarStyleBg
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_m_ProgressBarStyleBg;
		public static RUnityEngine.RGUIStyle Rm_ProgressBarStyleBg
		{
			get
			{
				if(r_m_ProgressBarStyleBg == null)
				{
					r_m_ProgressBarStyleBg = new( ReleactionUtils.GetType("CreatureBehav"), "m_ProgressBarStyleBg", -1);
					r_m_ProgressBarStyleBg.SetBelong(null);
				}
				return r_m_ProgressBarStyleBg;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_teamProtectionStyle
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_m_teamProtectionStyle;
		public static RUnityEngine.RGUIStyle Rm_teamProtectionStyle
		{
			get
			{
				if(r_m_teamProtectionStyle == null)
				{
					r_m_teamProtectionStyle = new( ReleactionUtils.GetType("CreatureBehav"), "m_teamProtectionStyle", -1);
					r_m_teamProtectionStyle.SetBelong(null);
				}
				return r_m_teamProtectionStyle;
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
		/// Void OnLoadPostIcon(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadPostIcon_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadPostIcon_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadPostIcon_Object_ABLoadedArgs == null)
				{
					r_ROnLoadPostIcon_Object_ABLoadedArgs = new(this, "OnLoadPostIcon", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadPostIcon_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadPostIcon_Object_ABLoadedArgs;
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
		/// Void IgnoreCollisionWithCharacterController()
		/// </summary>
		protected static RMethod r_RIgnoreCollisionWithCharacterController;
		public static RMethod RIgnoreCollisionWithCharacterController
		{
			get
			{
				if(r_RIgnoreCollisionWithCharacterController == null)
				{
					r_RIgnoreCollisionWithCharacterController = new( ReleactionUtils.GetType("CreatureBehav"), "IgnoreCollisionWithCharacterController", 0);
					r_RIgnoreCollisionWithCharacterController.SetBelong(null);
				}
				return r_RIgnoreCollisionWithCharacterController;
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
		/// Void CreatureFadeDefault(FadeType)
		/// </summary>
		protected RMethod r_RCreatureFadeDefault_FadeType;
		public virtual RMethod RCreatureFadeDefault_FadeType
		{
			get
			{
				if(r_RCreatureFadeDefault_FadeType == null)
				{
					r_RCreatureFadeDefault_FadeType = new(this, "CreatureFadeDefault", 0,  ReleactionUtils.GetType("CreatureBehav+FadeType"));
					r_RCreatureFadeDefault_FadeType.SetBelong(this.instance);
				}
				return r_RCreatureFadeDefault_FadeType;
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
		/// UnityEngine.GameObject[] FindAllChildNode()
		/// </summary>
		protected RMethod r_RFindAllChildNode;
		public virtual RMethod RFindAllChildNode
		{
			get
			{
				if(r_RFindAllChildNode == null)
				{
					r_RFindAllChildNode = new(this, "FindAllChildNode", 0);
					r_RFindAllChildNode.SetBelong(this.instance);
				}
				return r_RFindAllChildNode;
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
		/// System.Collections.IEnumerator ListenMouseCancel()
		/// </summary>
		protected RMethod r_RListenMouseCancel;
		public virtual RMethod RListenMouseCancel
		{
			get
			{
				if(r_RListenMouseCancel == null)
				{
					r_RListenMouseCancel = new(this, "ListenMouseCancel", 0);
					r_RListenMouseCancel.SetBelong(this.instance);
				}
				return r_RListenMouseCancel;
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
		/// System.Collections.IEnumerator UpdatePopText()
		/// </summary>
		protected RMethod r_RUpdatePopText;
		public virtual RMethod RUpdatePopText
		{
			get
			{
				if(r_RUpdatePopText == null)
				{
					r_RUpdatePopText = new(this, "UpdatePopText", 0);
					r_RUpdatePopText.SetBelong(this.instance);
				}
				return r_RUpdatePopText;
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
		/// System.Collections.IEnumerator UpdateProgressBar()
		/// </summary>
		protected RMethod r_RUpdateProgressBar;
		public virtual RMethod RUpdateProgressBar
		{
			get
			{
				if(r_RUpdateProgressBar == null)
				{
					r_RUpdateProgressBar = new(this, "UpdateProgressBar", 0);
					r_RUpdateProgressBar.SetBelong(this.instance);
				}
				return r_RUpdateProgressBar;
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
		/// System.Collections.IEnumerator UpdateCDtimeProgressBar(Single)
		/// </summary>
		protected RMethod r_RUpdateCDtimeProgressBar_Single;
		public virtual RMethod RUpdateCDtimeProgressBar_Single
		{
			get
			{
				if(r_RUpdateCDtimeProgressBar_Single == null)
				{
					r_RUpdateCDtimeProgressBar_Single = new(this, "UpdateCDtimeProgressBar", 0, typeof(System.Single));
					r_RUpdateCDtimeProgressBar_Single.SetBelong(this.instance);
				}
				return r_RUpdateCDtimeProgressBar_Single;
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
		/// Void DrawBigFace(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RDrawBigFace_Vector3;
		public virtual RMethod RDrawBigFace_Vector3
		{
			get
			{
				if(r_RDrawBigFace_Vector3 == null)
				{
					r_RDrawBigFace_Vector3 = new(this, "DrawBigFace", 0, typeof(UnityEngine.Vector3));
					r_RDrawBigFace_Vector3.SetBelong(this.instance);
				}
				return r_RDrawBigFace_Vector3;
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


        public RCreatureBehav() : base("CreatureBehav")
        {
        }

        public RCreatureBehav(System.Object instance) : base("CreatureBehav")
		{
            SetInstance(instance);
		}

        public RCreatureBehav(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCreatureBehav(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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



        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_Update.Invoke(___genericsType, ___parameters);

            
        }


        public static void IgnoreCollisionWithCharacterController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIgnoreCollisionWithCharacterController.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawText(System.String  @text, System.Boolean  @bNeedShadow, UnityEngine.Rect  @statusRect, System.Single  @labelWidth, UnityEngine.GUIStyle  @textStyle, UnityEngine.GUIStyle  @shadowStyle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @bNeedShadow, @statusRect, @labelWidth, @textStyle, @shadowStyle};
            var ___result = RDrawText_String_Boolean_Rect_Single_GUIStyle_GUIStyle.Invoke(___genericsType, ___parameters);

            
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


        public virtual void SetNameText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetNameText.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 GetDrawName3DPos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDrawName3DPos.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual System.Boolean ModelLimited()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RModelLimited.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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



        public virtual UnityEngine.GameObject[] FindAllChildNode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFindAllChildNode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject[])___result;
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


        public virtual void OnMouseUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnMouseUp.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Boolean IsInPlayerVision()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInPlayerVision.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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


        public virtual void _OnMouseRightDown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseRightDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseExit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseExit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseDown()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseDown.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _OnMouseUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_OnMouseUp.Invoke(___genericsType, ___parameters);

            
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


        public virtual System.Collections.IEnumerator ListenMouseCancel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RListenMouseCancel.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void EnterCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnterCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void HideBackMark()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHideBackMark.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator UpdatePopText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdatePopText.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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


        public virtual System.Collections.IEnumerator UpdateProgressBar()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateProgressBar.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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


        public virtual System.Collections.IEnumerator UpdateCDtimeProgressBar(System.Single  @_time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_time};
            var ___result = RUpdateCDtimeProgressBar_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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


        public virtual void DrawBigFace(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RDrawBigFace_Vector3.Invoke(___genericsType, ___parameters);

            
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
