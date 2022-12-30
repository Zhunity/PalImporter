using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieCameraEffManager
	/// </summary>
    public partial class RSceneMovieCameraEffManager : RMember //
    {

		/// <summary>
		/// System.Boolean m_bCameraBlock
		/// </summary>
		protected RField r_m_bCameraBlock;
		public virtual RField Rm_bCameraBlock
		{
			get
			{
				if(r_m_bCameraBlock == null)
				{
					r_m_bCameraBlock = new(this, "m_bCameraBlock");
					r_m_bCameraBlock.SetBelong(this.instance);
				}
				return r_m_bCameraBlock;
			}
		}

		/// <summary>
		/// System.Boolean m_bFadeAlwaysBlack
		/// </summary>
		protected RField r_m_bFadeAlwaysBlack;
		public virtual RField Rm_bFadeAlwaysBlack
		{
			get
			{
				if(r_m_bFadeAlwaysBlack == null)
				{
					r_m_bFadeAlwaysBlack = new(this, "m_bFadeAlwaysBlack");
					r_m_bFadeAlwaysBlack.SetBelong(this.instance);
				}
				return r_m_bFadeAlwaysBlack;
			}
		}

		/// <summary>
		/// System.Boolean m_bCameraFadeIn
		/// </summary>
		protected RField r_m_bCameraFadeIn;
		public virtual RField Rm_bCameraFadeIn
		{
			get
			{
				if(r_m_bCameraFadeIn == null)
				{
					r_m_bCameraFadeIn = new(this, "m_bCameraFadeIn");
					r_m_bCameraFadeIn.SetBelong(this.instance);
				}
				return r_m_bCameraFadeIn;
			}
		}

		/// <summary>
		/// System.Boolean m_bCameraFadeOut
		/// </summary>
		protected RField r_m_bCameraFadeOut;
		public virtual RField Rm_bCameraFadeOut
		{
			get
			{
				if(r_m_bCameraFadeOut == null)
				{
					r_m_bCameraFadeOut = new(this, "m_bCameraFadeOut");
					r_m_bCameraFadeOut.SetBelong(this.instance);
				}
				return r_m_bCameraFadeOut;
			}
		}

		/// <summary>
		/// System.Boolean m_bCameraMask
		/// </summary>
		protected RField r_m_bCameraMask;
		public virtual RField Rm_bCameraMask
		{
			get
			{
				if(r_m_bCameraMask == null)
				{
					r_m_bCameraMask = new(this, "m_bCameraMask");
					r_m_bCameraMask.SetBelong(this.instance);
				}
				return r_m_bCameraMask;
			}
		}

		/// <summary>
		/// System.Boolean m_bCameraShake
		/// </summary>
		protected RField r_m_bCameraShake;
		public virtual RField Rm_bCameraShake
		{
			get
			{
				if(r_m_bCameraShake == null)
				{
					r_m_bCameraShake = new(this, "m_bCameraShake");
					r_m_bCameraShake.SetBelong(this.instance);
				}
				return r_m_bCameraShake;
			}
		}

		/// <summary>
		/// System.Boolean m_bCameraFocus
		/// </summary>
		protected RField r_m_bCameraFocus;
		public virtual RField Rm_bCameraFocus
		{
			get
			{
				if(r_m_bCameraFocus == null)
				{
					r_m_bCameraFocus = new(this, "m_bCameraFocus");
					r_m_bCameraFocus.SetBelong(this.instance);
				}
				return r_m_bCameraFocus;
			}
		}

		/// <summary>
		/// System.Boolean m_bCameraFollow
		/// </summary>
		protected RField r_m_bCameraFollow;
		public virtual RField Rm_bCameraFollow
		{
			get
			{
				if(r_m_bCameraFollow == null)
				{
					r_m_bCameraFollow = new(this, "m_bCameraFollow");
					r_m_bCameraFollow.SetBelong(this.instance);
				}
				return r_m_bCameraFollow;
			}
		}

		/// <summary>
		/// System.Boolean m_bWait
		/// </summary>
		protected RField r_m_bWait;
		public virtual RField Rm_bWait
		{
			get
			{
				if(r_m_bWait == null)
				{
					r_m_bWait = new(this, "m_bWait");
					r_m_bWait.SetBelong(this.instance);
				}
				return r_m_bWait;
			}
		}

		/// <summary>
		/// System.Boolean m_bLerp
		/// </summary>
		protected RField r_m_bLerp;
		public virtual RField Rm_bLerp
		{
			get
			{
				if(r_m_bLerp == null)
				{
					r_m_bLerp = new(this, "m_bLerp");
					r_m_bLerp.SetBelong(this.instance);
				}
				return r_m_bLerp;
			}
		}

		/// <summary>
		/// System.Single m_fDistFollow
		/// </summary>
		protected RField r_m_fDistFollow;
		public virtual RField Rm_fDistFollow
		{
			get
			{
				if(r_m_fDistFollow == null)
				{
					r_m_fDistFollow = new(this, "m_fDistFollow");
					r_m_fDistFollow.SetBelong(this.instance);
				}
				return r_m_fDistFollow;
			}
		}

		/// <summary>
		/// System.Single m_fBlockPlayTime
		/// </summary>
		protected RField r_m_fBlockPlayTime;
		public virtual RField Rm_fBlockPlayTime
		{
			get
			{
				if(r_m_fBlockPlayTime == null)
				{
					r_m_fBlockPlayTime = new(this, "m_fBlockPlayTime");
					r_m_fBlockPlayTime.SetBelong(this.instance);
				}
				return r_m_fBlockPlayTime;
			}
		}

		/// <summary>
		/// System.Single m_fFadeInPlayTime
		/// </summary>
		protected RField r_m_fFadeInPlayTime;
		public virtual RField Rm_fFadeInPlayTime
		{
			get
			{
				if(r_m_fFadeInPlayTime == null)
				{
					r_m_fFadeInPlayTime = new(this, "m_fFadeInPlayTime");
					r_m_fFadeInPlayTime.SetBelong(this.instance);
				}
				return r_m_fFadeInPlayTime;
			}
		}

		/// <summary>
		/// System.Single m_fFadeOutPlayTime
		/// </summary>
		protected RField r_m_fFadeOutPlayTime;
		public virtual RField Rm_fFadeOutPlayTime
		{
			get
			{
				if(r_m_fFadeOutPlayTime == null)
				{
					r_m_fFadeOutPlayTime = new(this, "m_fFadeOutPlayTime");
					r_m_fFadeOutPlayTime.SetBelong(this.instance);
				}
				return r_m_fFadeOutPlayTime;
			}
		}

		/// <summary>
		/// System.Single m_fMaskPlayTime
		/// </summary>
		protected RField r_m_fMaskPlayTime;
		public virtual RField Rm_fMaskPlayTime
		{
			get
			{
				if(r_m_fMaskPlayTime == null)
				{
					r_m_fMaskPlayTime = new(this, "m_fMaskPlayTime");
					r_m_fMaskPlayTime.SetBelong(this.instance);
				}
				return r_m_fMaskPlayTime;
			}
		}

		/// <summary>
		/// System.Single m_fShakePlayTime
		/// </summary>
		protected RField r_m_fShakePlayTime;
		public virtual RField Rm_fShakePlayTime
		{
			get
			{
				if(r_m_fShakePlayTime == null)
				{
					r_m_fShakePlayTime = new(this, "m_fShakePlayTime");
					r_m_fShakePlayTime.SetBelong(this.instance);
				}
				return r_m_fShakePlayTime;
			}
		}

		/// <summary>
		/// System.Single m_fShakeMaxTime
		/// </summary>
		protected RField r_m_fShakeMaxTime;
		public virtual RField Rm_fShakeMaxTime
		{
			get
			{
				if(r_m_fShakeMaxTime == null)
				{
					r_m_fShakeMaxTime = new(this, "m_fShakeMaxTime");
					r_m_fShakeMaxTime.SetBelong(this.instance);
				}
				return r_m_fShakeMaxTime;
			}
		}

		/// <summary>
		/// System.Single m_fShakeH
		/// </summary>
		protected RField r_m_fShakeH;
		public virtual RField Rm_fShakeH
		{
			get
			{
				if(r_m_fShakeH == null)
				{
					r_m_fShakeH = new(this, "m_fShakeH");
					r_m_fShakeH.SetBelong(this.instance);
				}
				return r_m_fShakeH;
			}
		}

		/// <summary>
		/// System.Single m_fShakeV
		/// </summary>
		protected RField r_m_fShakeV;
		public virtual RField Rm_fShakeV
		{
			get
			{
				if(r_m_fShakeV == null)
				{
					r_m_fShakeV = new(this, "m_fShakeV");
					r_m_fShakeV.SetBelong(this.instance);
				}
				return r_m_fShakeV;
			}
		}

		/// <summary>
		/// System.Single m_fFocusSpeed
		/// </summary>
		protected RField r_m_fFocusSpeed;
		public virtual RField Rm_fFocusSpeed
		{
			get
			{
				if(r_m_fFocusSpeed == null)
				{
					r_m_fFocusSpeed = new(this, "m_fFocusSpeed");
					r_m_fFocusSpeed.SetBelong(this.instance);
				}
				return r_m_fFocusSpeed;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vFocusTargetPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vFocusTargetPos;
		public virtual RUnityEngine.RVector3 Rm_vFocusTargetPos
		{
			get
			{
				if(r_m_vFocusTargetPos == null)
				{
					r_m_vFocusTargetPos = new(this, "m_vFocusTargetPos");
					r_m_vFocusTargetPos.SetBelong(this.instance);
				}
				return r_m_vFocusTargetPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vFocusTargetRot
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vFocusTargetRot;
		public virtual RUnityEngine.RVector3 Rm_vFocusTargetRot
		{
			get
			{
				if(r_m_vFocusTargetRot == null)
				{
					r_m_vFocusTargetRot = new(this, "m_vFocusTargetRot");
					r_m_vFocusTargetRot.SetBelong(this.instance);
				}
				return r_m_vFocusTargetRot;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vGotoOriPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vGotoOriPos;
		public virtual RUnityEngine.RVector3 Rm_vGotoOriPos
		{
			get
			{
				if(r_m_vGotoOriPos == null)
				{
					r_m_vGotoOriPos = new(this, "m_vGotoOriPos");
					r_m_vGotoOriPos.SetBelong(this.instance);
				}
				return r_m_vGotoOriPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vGotoOriRot
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vGotoOriRot;
		public virtual RUnityEngine.RVector3 Rm_vGotoOriRot
		{
			get
			{
				if(r_m_vGotoOriRot == null)
				{
					r_m_vGotoOriRot = new(this, "m_vGotoOriRot");
					r_m_vGotoOriRot.SetBelong(this.instance);
				}
				return r_m_vGotoOriRot;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vGotoTgtPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vGotoTgtPos;
		public virtual RUnityEngine.RVector3 Rm_vGotoTgtPos
		{
			get
			{
				if(r_m_vGotoTgtPos == null)
				{
					r_m_vGotoTgtPos = new(this, "m_vGotoTgtPos");
					r_m_vGotoTgtPos.SetBelong(this.instance);
				}
				return r_m_vGotoTgtPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vGotoTgtRot
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vGotoTgtRot;
		public virtual RUnityEngine.RVector3 Rm_vGotoTgtRot
		{
			get
			{
				if(r_m_vGotoTgtRot == null)
				{
					r_m_vGotoTgtRot = new(this, "m_vGotoTgtRot");
					r_m_vGotoTgtRot.SetBelong(this.instance);
				}
				return r_m_vGotoTgtRot;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vecFocusDelta
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vecFocusDelta;
		public virtual RUnityEngine.RVector3 Rm_vecFocusDelta
		{
			get
			{
				if(r_m_vecFocusDelta == null)
				{
					r_m_vecFocusDelta = new(this, "m_vecFocusDelta");
					r_m_vecFocusDelta.SetBelong(this.instance);
				}
				return r_m_vecFocusDelta;
			}
		}

		/// <summary>
		/// System.Single CAMERA_BLOCK_RATIO_H
		/// </summary>
		protected RField r_CAMERA_BLOCK_RATIO_H;
		public virtual RField RCAMERA_BLOCK_RATIO_H
		{
			get
			{
				if(r_CAMERA_BLOCK_RATIO_H == null)
				{
					r_CAMERA_BLOCK_RATIO_H = new(this, "CAMERA_BLOCK_RATIO_H");
					r_CAMERA_BLOCK_RATIO_H.SetBelong(this.instance);
				}
				return r_CAMERA_BLOCK_RATIO_H;
			}
		}

		/// <summary>
		/// System.Single TIME_CAMERA_BLOCK_PLAY
		/// </summary>
		protected RField r_TIME_CAMERA_BLOCK_PLAY;
		public virtual RField RTIME_CAMERA_BLOCK_PLAY
		{
			get
			{
				if(r_TIME_CAMERA_BLOCK_PLAY == null)
				{
					r_TIME_CAMERA_BLOCK_PLAY = new(this, "TIME_CAMERA_BLOCK_PLAY");
					r_TIME_CAMERA_BLOCK_PLAY.SetBelong(this.instance);
				}
				return r_TIME_CAMERA_BLOCK_PLAY;
			}
		}

		/// <summary>
		/// System.Single TIME_CAMERA_FADE_PLAY
		/// </summary>
		protected RField r_TIME_CAMERA_FADE_PLAY;
		public virtual RField RTIME_CAMERA_FADE_PLAY
		{
			get
			{
				if(r_TIME_CAMERA_FADE_PLAY == null)
				{
					r_TIME_CAMERA_FADE_PLAY = new(this, "TIME_CAMERA_FADE_PLAY");
					r_TIME_CAMERA_FADE_PLAY.SetBelong(this.instance);
				}
				return r_TIME_CAMERA_FADE_PLAY;
			}
		}

		/// <summary>
		/// System.Single TIME_CAMERA_MASK_PLAY
		/// </summary>
		protected RField r_TIME_CAMERA_MASK_PLAY;
		public virtual RField RTIME_CAMERA_MASK_PLAY
		{
			get
			{
				if(r_TIME_CAMERA_MASK_PLAY == null)
				{
					r_TIME_CAMERA_MASK_PLAY = new(this, "TIME_CAMERA_MASK_PLAY");
					r_TIME_CAMERA_MASK_PLAY.SetBelong(this.instance);
				}
				return r_TIME_CAMERA_MASK_PLAY;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_blackTex
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_blackTex;
		public virtual RUnityEngine.RTexture2D Rm_blackTex
		{
			get
			{
				if(r_m_blackTex == null)
				{
					r_m_blackTex = new(this, "m_blackTex");
					r_m_blackTex.SetBelong(this.instance);
				}
				return r_m_blackTex;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_FadeTex
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_FadeTex;
		public virtual RUnityEngine.RTexture2D Rm_FadeTex
		{
			get
			{
				if(r_m_FadeTex == null)
				{
					r_m_FadeTex = new(this, "m_FadeTex");
					r_m_FadeTex.SetBelong(this.instance);
				}
				return r_m_FadeTex;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_MaskTex
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_MaskTex;
		public virtual RUnityEngine.RTexture2D Rm_MaskTex
		{
			get
			{
				if(r_m_MaskTex == null)
				{
					r_m_MaskTex = new(this, "m_MaskTex");
					r_m_MaskTex.SetBelong(this.instance);
				}
				return r_m_MaskTex;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_FadeColor
		/// </summary>
		protected RUnityEngine.RColor r_m_FadeColor;
		public virtual RUnityEngine.RColor Rm_FadeColor
		{
			get
			{
				if(r_m_FadeColor == null)
				{
					r_m_FadeColor = new(this, "m_FadeColor");
					r_m_FadeColor.SetBelong(this.instance);
				}
				return r_m_FadeColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_MaskColor
		/// </summary>
		protected RUnityEngine.RColor r_m_MaskColor;
		public virtual RUnityEngine.RColor Rm_MaskColor
		{
			get
			{
				if(r_m_MaskColor == null)
				{
					r_m_MaskColor = new(this, "m_MaskColor");
					r_m_MaskColor.SetBelong(this.instance);
				}
				return r_m_MaskColor;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_LastCamPosition
		/// </summary>
		protected RUnityEngine.RVector3 r_m_LastCamPosition;
		public virtual RUnityEngine.RVector3 Rm_LastCamPosition
		{
			get
			{
				if(r_m_LastCamPosition == null)
				{
					r_m_LastCamPosition = new(this, "m_LastCamPosition");
					r_m_LastCamPosition.SetBelong(this.instance);
				}
				return r_m_LastCamPosition;
			}
		}

		/// <summary>
		/// System.Boolean m_bCameraGoto
		/// </summary>
		protected RField r_m_bCameraGoto;
		public virtual RField Rm_bCameraGoto
		{
			get
			{
				if(r_m_bCameraGoto == null)
				{
					r_m_bCameraGoto = new(this, "m_bCameraGoto");
					r_m_bCameraGoto.SetBelong(this.instance);
				}
				return r_m_bCameraGoto;
			}
		}

		/// <summary>
		/// System.Single m_fMaxTime
		/// </summary>
		protected RField r_m_fMaxTime;
		public virtual RField Rm_fMaxTime
		{
			get
			{
				if(r_m_fMaxTime == null)
				{
					r_m_fMaxTime = new(this, "m_fMaxTime");
					r_m_fMaxTime.SetBelong(this.instance);
				}
				return r_m_fMaxTime;
			}
		}

		/// <summary>
		/// System.Single m_fTime
		/// </summary>
		protected RField r_m_fTime;
		public virtual RField Rm_fTime
		{
			get
			{
				if(r_m_fTime == null)
				{
					r_m_fTime = new(this, "m_fTime");
					r_m_fTime.SetBelong(this.instance);
				}
				return r_m_fTime;
			}
		}

		/// <summary>
		/// System.Single m_fOriFocusLength
		/// </summary>
		protected RField r_m_fOriFocusLength;
		public virtual RField Rm_fOriFocusLength
		{
			get
			{
				if(r_m_fOriFocusLength == null)
				{
					r_m_fOriFocusLength = new(this, "m_fOriFocusLength");
					r_m_fOriFocusLength.SetBelong(this.instance);
				}
				return r_m_fOriFocusLength;
			}
		}

		/// <summary>
		/// System.Single m_fTgtFocusLength
		/// </summary>
		protected RField r_m_fTgtFocusLength;
		public virtual RField Rm_fTgtFocusLength
		{
			get
			{
				if(r_m_fTgtFocusLength == null)
				{
					r_m_fTgtFocusLength = new(this, "m_fTgtFocusLength");
					r_m_fTgtFocusLength.SetBelong(this.instance);
				}
				return r_m_fTgtFocusLength;
			}
		}

		/// <summary>
		/// System.Single m_fFocusLength
		/// </summary>
		protected RField r_m_fFocusLength;
		public virtual RField Rm_fFocusLength
		{
			get
			{
				if(r_m_fFocusLength == null)
				{
					r_m_fFocusLength = new(this, "m_fFocusLength");
					r_m_fFocusLength.SetBelong(this.instance);
				}
				return r_m_fFocusLength;
			}
		}

		/// <summary>
		/// System.Int32 m_nMaxFocusCnt
		/// </summary>
		protected RField r_m_nMaxFocusCnt;
		public virtual RField Rm_nMaxFocusCnt
		{
			get
			{
				if(r_m_nMaxFocusCnt == null)
				{
					r_m_nMaxFocusCnt = new(this, "m_nMaxFocusCnt");
					r_m_nMaxFocusCnt.SetBelong(this.instance);
				}
				return r_m_nMaxFocusCnt;
			}
		}

		/// <summary>
		/// System.Int32 m_nCrossFadeCnt
		/// </summary>
		protected RField r_m_nCrossFadeCnt;
		public virtual RField Rm_nCrossFadeCnt
		{
			get
			{
				if(r_m_nCrossFadeCnt == null)
				{
					r_m_nCrossFadeCnt = new(this, "m_nCrossFadeCnt");
					r_m_nCrossFadeCnt.SetBelong(this.instance);
				}
				return r_m_nCrossFadeCnt;
			}
		}

		/// <summary>
		/// System.Boolean m_bCrossFade
		/// </summary>
		protected RField r_m_bCrossFade;
		public virtual RField Rm_bCrossFade
		{
			get
			{
				if(r_m_bCrossFade == null)
				{
					r_m_bCrossFade = new(this, "m_bCrossFade");
					r_m_bCrossFade.SetBelong(this.instance);
				}
				return r_m_bCrossFade;
			}
		}

		/// <summary>
		/// System.Single m_fCrossFadeTime
		/// </summary>
		protected RField r_m_fCrossFadeTime;
		public virtual RField Rm_fCrossFadeTime
		{
			get
			{
				if(r_m_fCrossFadeTime == null)
				{
					r_m_fCrossFadeTime = new(this, "m_fCrossFadeTime");
					r_m_fCrossFadeTime.SetBelong(this.instance);
				}
				return r_m_fCrossFadeTime;
			}
		}

		/// <summary>
		/// System.Single m_fCrossFadeMaxTime
		/// </summary>
		protected RField r_m_fCrossFadeMaxTime;
		public virtual RField Rm_fCrossFadeMaxTime
		{
			get
			{
				if(r_m_fCrossFadeMaxTime == null)
				{
					r_m_fCrossFadeMaxTime = new(this, "m_fCrossFadeMaxTime");
					r_m_fCrossFadeMaxTime.SetBelong(this.instance);
				}
				return r_m_fCrossFadeMaxTime;
			}
		}

		/// <summary>
		/// System.Single m_fCrossfadeAlpha
		/// </summary>
		protected RField r_m_fCrossfadeAlpha;
		public virtual RField Rm_fCrossfadeAlpha
		{
			get
			{
				if(r_m_fCrossfadeAlpha == null)
				{
					r_m_fCrossfadeAlpha = new(this, "m_fCrossfadeAlpha");
					r_m_fCrossfadeAlpha.SetBelong(this.instance);
				}
				return r_m_fCrossfadeAlpha;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture m_RenderTexture
		/// </summary>
		protected RUnityEngine.RRenderTexture r_m_RenderTexture;
		public virtual RUnityEngine.RRenderTexture Rm_RenderTexture
		{
			get
			{
				if(r_m_RenderTexture == null)
				{
					r_m_RenderTexture = new(this, "m_RenderTexture");
					r_m_RenderTexture.SetBelong(this.instance);
				}
				return r_m_RenderTexture;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_RenderCameraObj
		/// </summary>
		protected RUnityEngine.RGameObject r_m_RenderCameraObj;
		public virtual RUnityEngine.RGameObject Rm_RenderCameraObj
		{
			get
			{
				if(r_m_RenderCameraObj == null)
				{
					r_m_RenderCameraObj = new(this, "m_RenderCameraObj");
					r_m_RenderCameraObj.SetBelong(this.instance);
				}
				return r_m_RenderCameraObj;
			}
		}

		/// <summary>
		/// ScreenWipes m_ScreenWipeMgr
		/// </summary>
		protected RScreenWipes r_m_ScreenWipeMgr;
		public virtual RScreenWipes Rm_ScreenWipeMgr
		{
			get
			{
				if(r_m_ScreenWipeMgr == null)
				{
					r_m_ScreenWipeMgr = new(this, "m_ScreenWipeMgr");
					r_m_ScreenWipeMgr.SetBelong(this.instance);
				}
				return r_m_ScreenWipeMgr;
			}
		}

		/// <summary>
		/// System.Boolean m_bInitDreamWipe
		/// </summary>
		protected RField r_m_bInitDreamWipe;
		public virtual RField Rm_bInitDreamWipe
		{
			get
			{
				if(r_m_bInitDreamWipe == null)
				{
					r_m_bInitDreamWipe = new(this, "m_bInitDreamWipe");
					r_m_bInitDreamWipe.SetBelong(this.instance);
				}
				return r_m_bInitDreamWipe;
			}
		}

		/// <summary>
		/// UnityEngine.Camera m_RenderCamera
		/// </summary>
		protected RUnityEngine.RCamera r_m_RenderCamera;
		public virtual RUnityEngine.RCamera Rm_RenderCamera
		{
			get
			{
				if(r_m_RenderCamera == null)
				{
					r_m_RenderCamera = new(this, "m_RenderCamera");
					r_m_RenderCamera.SetBelong(this.instance);
				}
				return r_m_RenderCamera;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_CameraTarget
		/// </summary>
		protected RUnityEngine.RGameObject r_m_CameraTarget;
		public virtual RUnityEngine.RGameObject Rm_CameraTarget
		{
			get
			{
				if(r_m_CameraTarget == null)
				{
					r_m_CameraTarget = new(this, "m_CameraTarget");
					r_m_CameraTarget.SetBelong(this.instance);
				}
				return r_m_CameraTarget;
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
		/// UIeffect m_UIEffect
		/// </summary>
		protected RUIeffect r_m_UIEffect;
		public virtual RUIeffect Rm_UIEffect
		{
			get
			{
				if(r_m_UIEffect == null)
				{
					r_m_UIEffect = new(this, "m_UIEffect");
					r_m_UIEffect.SetBelong(this.instance);
				}
				return r_m_UIEffect;
			}
		}

		/// <summary>
		/// System.String m_sUIEffName
		/// </summary>
		protected RField r_m_sUIEffName;
		public virtual RField Rm_sUIEffName
		{
			get
			{
				if(r_m_sUIEffName == null)
				{
					r_m_sUIEffName = new(this, "m_sUIEffName");
					r_m_sUIEffName.SetBelong(this.instance);
				}
				return r_m_sUIEffName;
			}
		}

		/// <summary>
		/// System.Single m_fUIEffectSize
		/// </summary>
		protected RField r_m_fUIEffectSize;
		public virtual RField Rm_fUIEffectSize
		{
			get
			{
				if(r_m_fUIEffectSize == null)
				{
					r_m_fUIEffectSize = new(this, "m_fUIEffectSize");
					r_m_fUIEffectSize.SetBelong(this.instance);
				}
				return r_m_fUIEffectSize;
			}
		}

		/// <summary>
		/// System.Boolean m_bDrawUIEffect
		/// </summary>
		protected RField r_m_bDrawUIEffect;
		public virtual RField Rm_bDrawUIEffect
		{
			get
			{
				if(r_m_bDrawUIEffect == null)
				{
					r_m_bDrawUIEffect = new(this, "m_bDrawUIEffect");
					r_m_bDrawUIEffect.SetBelong(this.instance);
				}
				return r_m_bDrawUIEffect;
			}
		}

		/// <summary>
		/// UnityEngine.Texture m_texBloodEffect
		/// </summary>
		protected RUnityEngine.RTexture r_m_texBloodEffect;
		public virtual RUnityEngine.RTexture Rm_texBloodEffect
		{
			get
			{
				if(r_m_texBloodEffect == null)
				{
					r_m_texBloodEffect = new(this, "m_texBloodEffect");
					r_m_texBloodEffect.SetBelong(this.instance);
				}
				return r_m_texBloodEffect;
			}
		}

		/// <summary>
		/// System.Boolean m_bBlurEffect
		/// </summary>
		protected RField r_m_bBlurEffect;
		public virtual RField Rm_bBlurEffect
		{
			get
			{
				if(r_m_bBlurEffect == null)
				{
					r_m_bBlurEffect = new(this, "m_bBlurEffect");
					r_m_bBlurEffect.SetBelong(this.instance);
				}
				return r_m_bBlurEffect;
			}
		}

		/// <summary>
		/// System.Int32 m_nToBlurIterations
		/// </summary>
		protected RField r_m_nToBlurIterations;
		public virtual RField Rm_nToBlurIterations
		{
			get
			{
				if(r_m_nToBlurIterations == null)
				{
					r_m_nToBlurIterations = new(this, "m_nToBlurIterations");
					r_m_nToBlurIterations.SetBelong(this.instance);
				}
				return r_m_nToBlurIterations;
			}
		}

		/// <summary>
		/// System.Int32 m_nFromBlurIterations
		/// </summary>
		protected RField r_m_nFromBlurIterations;
		public virtual RField Rm_nFromBlurIterations
		{
			get
			{
				if(r_m_nFromBlurIterations == null)
				{
					r_m_nFromBlurIterations = new(this, "m_nFromBlurIterations");
					r_m_nFromBlurIterations.SetBelong(this.instance);
				}
				return r_m_nFromBlurIterations;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vecDeltaRotate
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vecDeltaRotate;
		public virtual RUnityEngine.RVector3 Rm_vecDeltaRotate
		{
			get
			{
				if(r_m_vecDeltaRotate == null)
				{
					r_m_vecDeltaRotate = new(this, "m_vecDeltaRotate");
					r_m_vecDeltaRotate.SetBelong(this.instance);
				}
				return r_m_vecDeltaRotate;
			}
		}

		/// <summary>
		/// System.Int32 m_RotateCnt
		/// </summary>
		protected RField r_m_RotateCnt;
		public virtual RField Rm_RotateCnt
		{
			get
			{
				if(r_m_RotateCnt == null)
				{
					r_m_RotateCnt = new(this, "m_RotateCnt");
					r_m_RotateCnt.SetBelong(this.instance);
				}
				return r_m_RotateCnt;
			}
		}

		/// <summary>
		/// System.Boolean m_bCameraRotateAt
		/// </summary>
		protected RField r_m_bCameraRotateAt;
		public virtual RField Rm_bCameraRotateAt
		{
			get
			{
				if(r_m_bCameraRotateAt == null)
				{
					r_m_bCameraRotateAt = new(this, "m_bCameraRotateAt");
					r_m_bCameraRotateAt.SetBelong(this.instance);
				}
				return r_m_bCameraRotateAt;
			}
		}

		/// <summary>
		/// System.Boolean m_bTwirlOn
		/// </summary>
		protected RField r_m_bTwirlOn;
		public virtual RField Rm_bTwirlOn
		{
			get
			{
				if(r_m_bTwirlOn == null)
				{
					r_m_bTwirlOn = new(this, "m_bTwirlOn");
					r_m_bTwirlOn.SetBelong(this.instance);
				}
				return r_m_bTwirlOn;
			}
		}

		/// <summary>
		/// System.Single m_fTwirltime
		/// </summary>
		protected RField r_m_fTwirltime;
		public virtual RField Rm_fTwirltime
		{
			get
			{
				if(r_m_fTwirltime == null)
				{
					r_m_fTwirltime = new(this, "m_fTwirltime");
					r_m_fTwirltime.SetBelong(this.instance);
				}
				return r_m_fTwirltime;
			}
		}

		/// <summary>
		/// System.Single m_fMaxTwirltime
		/// </summary>
		protected RField r_m_fMaxTwirltime;
		public virtual RField Rm_fMaxTwirltime
		{
			get
			{
				if(r_m_fMaxTwirltime == null)
				{
					r_m_fMaxTwirltime = new(this, "m_fMaxTwirltime");
					r_m_fMaxTwirltime.SetBelong(this.instance);
				}
				return r_m_fMaxTwirltime;
			}
		}

		/// <summary>
		/// System.Single m_fFromAngle
		/// </summary>
		protected RField r_m_fFromAngle;
		public virtual RField Rm_fFromAngle
		{
			get
			{
				if(r_m_fFromAngle == null)
				{
					r_m_fFromAngle = new(this, "m_fFromAngle");
					r_m_fFromAngle.SetBelong(this.instance);
				}
				return r_m_fFromAngle;
			}
		}

		/// <summary>
		/// System.Single m_fToAngle
		/// </summary>
		protected RField r_m_fToAngle;
		public virtual RField Rm_fToAngle
		{
			get
			{
				if(r_m_fToAngle == null)
				{
					r_m_fToAngle = new(this, "m_fToAngle");
					r_m_fToAngle.SetBelong(this.instance);
				}
				return r_m_fToAngle;
			}
		}

		/// <summary>
		/// TwirlEffect m_TwirlEffect
		/// </summary>
		protected RTwirlEffect r_m_TwirlEffect;
		public virtual RTwirlEffect Rm_TwirlEffect
		{
			get
			{
				if(r_m_TwirlEffect == null)
				{
					r_m_TwirlEffect = new(this, "m_TwirlEffect");
					r_m_TwirlEffect.SetBelong(this.instance);
				}
				return r_m_TwirlEffect;
			}
		}

		/// <summary>
		/// System.Boolean m_bScreenShot
		/// </summary>
		protected RField r_m_bScreenShot;
		public virtual RField Rm_bScreenShot
		{
			get
			{
				if(r_m_bScreenShot == null)
				{
					r_m_bScreenShot = new(this, "m_bScreenShot");
					r_m_bScreenShot.SetBelong(this.instance);
				}
				return r_m_bScreenShot;
			}
		}

		/// <summary>
		/// System.Single m_fScreenShotTime
		/// </summary>
		protected RField r_m_fScreenShotTime;
		public virtual RField Rm_fScreenShotTime
		{
			get
			{
				if(r_m_fScreenShotTime == null)
				{
					r_m_fScreenShotTime = new(this, "m_fScreenShotTime");
					r_m_fScreenShotTime.SetBelong(this.instance);
				}
				return r_m_fScreenShotTime;
			}
		}

		/// <summary>
		/// System.Single m_fMaxScreenShotTime
		/// </summary>
		protected RField r_m_fMaxScreenShotTime;
		public virtual RField Rm_fMaxScreenShotTime
		{
			get
			{
				if(r_m_fMaxScreenShotTime == null)
				{
					r_m_fMaxScreenShotTime = new(this, "m_fMaxScreenShotTime");
					r_m_fMaxScreenShotTime.SetBelong(this.instance);
				}
				return r_m_fMaxScreenShotTime;
			}
		}

		/// <summary>
		/// System.Single m_fGreyTime
		/// </summary>
		protected RField r_m_fGreyTime;
		public virtual RField Rm_fGreyTime
		{
			get
			{
				if(r_m_fGreyTime == null)
				{
					r_m_fGreyTime = new(this, "m_fGreyTime");
					r_m_fGreyTime.SetBelong(this.instance);
				}
				return r_m_fGreyTime;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map32
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map32;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map32
		{
			get
			{
				if(r___2____4__f__switch__9__map32 == null)
				{
					r___2____4__f__switch__9__map32 = new( ReleactionUtils.GetType("SceneMovieCameraEffManager"), "<>f__switch$map32");
					r___2____4__f__switch__9__map32.SetBelong(null);
				}
				return r___2____4__f__switch__9__map32;
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
		/// Void SetupRenderCamera()
		/// </summary>
		protected RMethod r_RSetupRenderCamera;
		public virtual RMethod RSetupRenderCamera
		{
			get
			{
				if(r_RSetupRenderCamera == null)
				{
					r_RSetupRenderCamera = new(this, "SetupRenderCamera", 0);
					r_RSetupRenderCamera.SetBelong(this.instance);
				}
				return r_RSetupRenderCamera;
			}
		}

		/// <summary>
		/// Void ResetCameraEff()
		/// </summary>
		protected RMethod r_RResetCameraEff;
		public virtual RMethod RResetCameraEff
		{
			get
			{
				if(r_RResetCameraEff == null)
				{
					r_RResetCameraEff = new(this, "ResetCameraEff", 0);
					r_RResetCameraEff.SetBelong(this.instance);
				}
				return r_RResetCameraEff;
			}
		}

		/// <summary>
		/// Void ResetCameraAction()
		/// </summary>
		protected RMethod r_RResetCameraAction;
		public virtual RMethod RResetCameraAction
		{
			get
			{
				if(r_RResetCameraAction == null)
				{
					r_RResetCameraAction = new(this, "ResetCameraAction", 0);
					r_RResetCameraAction.SetBelong(this.instance);
				}
				return r_RResetCameraAction;
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
		/// Void ShowBloodEffect(Boolean, System.String, Single)
		/// </summary>
		protected RMethod r_RShowBloodEffect_Boolean_String_Single;
		public virtual RMethod RShowBloodEffect_Boolean_String_Single
		{
			get
			{
				if(r_RShowBloodEffect_Boolean_String_Single == null)
				{
					r_RShowBloodEffect_Boolean_String_Single = new(this, "ShowBloodEffect", 0, typeof(System.Boolean), typeof(System.String), typeof(System.Single));
					r_RShowBloodEffect_Boolean_String_Single.SetBelong(this.instance);
				}
				return r_RShowBloodEffect_Boolean_String_Single;
			}
		}

		/// <summary>
		/// Void DrawBloodEffect()
		/// </summary>
		protected RMethod r_RDrawBloodEffect;
		public virtual RMethod RDrawBloodEffect
		{
			get
			{
				if(r_RDrawBloodEffect == null)
				{
					r_RDrawBloodEffect = new(this, "DrawBloodEffect", 0);
					r_RDrawBloodEffect.SetBelong(this.instance);
				}
				return r_RDrawBloodEffect;
			}
		}

		/// <summary>
		/// Void CameraShake(Single, Single, Single, Boolean)
		/// </summary>
		protected RMethod r_RCameraShake_Single_Single_Single_Boolean;
		public virtual RMethod RCameraShake_Single_Single_Single_Boolean
		{
			get
			{
				if(r_RCameraShake_Single_Single_Single_Boolean == null)
				{
					r_RCameraShake_Single_Single_Single_Boolean = new(this, "CameraShake", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Boolean));
					r_RCameraShake_Single_Single_Single_Boolean.SetBelong(this.instance);
				}
				return r_RCameraShake_Single_Single_Single_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateCameraShake()
		/// </summary>
		protected RMethod r_RUpdateCameraShake;
		public virtual RMethod RUpdateCameraShake
		{
			get
			{
				if(r_RUpdateCameraShake == null)
				{
					r_RUpdateCameraShake = new(this, "UpdateCameraShake", 0);
					r_RUpdateCameraShake.SetBelong(this.instance);
				}
				return r_RUpdateCameraShake;
			}
		}

		/// <summary>
		/// Void SetAlwaysBlack(Boolean)
		/// </summary>
		protected RMethod r_RSetAlwaysBlack_Boolean;
		public virtual RMethod RSetAlwaysBlack_Boolean
		{
			get
			{
				if(r_RSetAlwaysBlack_Boolean == null)
				{
					r_RSetAlwaysBlack_Boolean = new(this, "SetAlwaysBlack", 0, typeof(System.Boolean));
					r_RSetAlwaysBlack_Boolean.SetBelong(this.instance);
				}
				return r_RSetAlwaysBlack_Boolean;
			}
		}

		/// <summary>
		/// Void CameraFadeIn(Single, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RCameraFadeIn_Single_Color;
		public virtual RMethod RCameraFadeIn_Single_Color
		{
			get
			{
				if(r_RCameraFadeIn_Single_Color == null)
				{
					r_RCameraFadeIn_Single_Color = new(this, "CameraFadeIn", 0, typeof(System.Single), typeof(UnityEngine.Color));
					r_RCameraFadeIn_Single_Color.SetBelong(this.instance);
				}
				return r_RCameraFadeIn_Single_Color;
			}
		}

		/// <summary>
		/// Void CameraFadeOut(Single, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RCameraFadeOut_Single_Color;
		public virtual RMethod RCameraFadeOut_Single_Color
		{
			get
			{
				if(r_RCameraFadeOut_Single_Color == null)
				{
					r_RCameraFadeOut_Single_Color = new(this, "CameraFadeOut", 0, typeof(System.Single), typeof(UnityEngine.Color));
					r_RCameraFadeOut_Single_Color.SetBelong(this.instance);
				}
				return r_RCameraFadeOut_Single_Color;
			}
		}

		/// <summary>
		/// Void UpdateCameraFade()
		/// </summary>
		protected RMethod r_RUpdateCameraFade;
		public virtual RMethod RUpdateCameraFade
		{
			get
			{
				if(r_RUpdateCameraFade == null)
				{
					r_RUpdateCameraFade = new(this, "UpdateCameraFade", 0);
					r_RUpdateCameraFade.SetBelong(this.instance);
				}
				return r_RUpdateCameraFade;
			}
		}

		/// <summary>
		/// Void CameraBlock(Boolean)
		/// </summary>
		protected RMethod r_RCameraBlock_Boolean;
		public virtual RMethod RCameraBlock_Boolean
		{
			get
			{
				if(r_RCameraBlock_Boolean == null)
				{
					r_RCameraBlock_Boolean = new(this, "CameraBlock", 0, typeof(System.Boolean));
					r_RCameraBlock_Boolean.SetBelong(this.instance);
				}
				return r_RCameraBlock_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateCameraBlock()
		/// </summary>
		protected RMethod r_RUpdateCameraBlock;
		public virtual RMethod RUpdateCameraBlock
		{
			get
			{
				if(r_RUpdateCameraBlock == null)
				{
					r_RUpdateCameraBlock = new(this, "UpdateCameraBlock", 0);
					r_RUpdateCameraBlock.SetBelong(this.instance);
				}
				return r_RUpdateCameraBlock;
			}
		}

		/// <summary>
		/// Void UpdateCameraMask()
		/// </summary>
		protected RMethod r_RUpdateCameraMask;
		public virtual RMethod RUpdateCameraMask
		{
			get
			{
				if(r_RUpdateCameraMask == null)
				{
					r_RUpdateCameraMask = new(this, "UpdateCameraMask", 0);
					r_RUpdateCameraMask.SetBelong(this.instance);
				}
				return r_RUpdateCameraMask;
			}
		}

		/// <summary>
		/// Void CameraMask(Boolean, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RCameraMask_Boolean_Color;
		public virtual RMethod RCameraMask_Boolean_Color
		{
			get
			{
				if(r_RCameraMask_Boolean_Color == null)
				{
					r_RCameraMask_Boolean_Color = new(this, "CameraMask", 0, typeof(System.Boolean), typeof(UnityEngine.Color));
					r_RCameraMask_Boolean_Color.SetBelong(this.instance);
				}
				return r_RCameraMask_Boolean_Color;
			}
		}

		/// <summary>
		/// Void CameraFocus(System.String, Single, Boolean, Single, Boolean, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RCameraFocus_String_Single_Boolean_Single_Boolean_Vector3;
		public virtual RMethod RCameraFocus_String_Single_Boolean_Single_Boolean_Vector3
		{
			get
			{
				if(r_RCameraFocus_String_Single_Boolean_Single_Boolean_Vector3 == null)
				{
					r_RCameraFocus_String_Single_Boolean_Single_Boolean_Vector3 = new(this, "CameraFocus", 0, typeof(System.String), typeof(System.Single), typeof(System.Boolean), typeof(System.Single), typeof(System.Boolean), typeof(UnityEngine.Vector3));
					r_RCameraFocus_String_Single_Boolean_Single_Boolean_Vector3.SetBelong(this.instance);
				}
				return r_RCameraFocus_String_Single_Boolean_Single_Boolean_Vector3;
			}
		}

		/// <summary>
		/// Void UpdateCameraFocus()
		/// </summary>
		protected RMethod r_RUpdateCameraFocus;
		public virtual RMethod RUpdateCameraFocus
		{
			get
			{
				if(r_RUpdateCameraFocus == null)
				{
					r_RUpdateCameraFocus = new(this, "UpdateCameraFocus", 0);
					r_RUpdateCameraFocus.SetBelong(this.instance);
				}
				return r_RUpdateCameraFocus;
			}
		}

		/// <summary>
		/// Void CameraTransform(System.String, Single, UnityEngine.Vector3, Boolean, System.String, Single)
		/// </summary>
		protected RMethod r_RCameraTransform_String_Single_Vector3_Boolean_String_Single;
		public virtual RMethod RCameraTransform_String_Single_Vector3_Boolean_String_Single
		{
			get
			{
				if(r_RCameraTransform_String_Single_Vector3_Boolean_String_Single == null)
				{
					r_RCameraTransform_String_Single_Vector3_Boolean_String_Single = new(this, "CameraTransform", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.Vector3), typeof(System.Boolean), typeof(System.String), typeof(System.Single));
					r_RCameraTransform_String_Single_Vector3_Boolean_String_Single.SetBelong(this.instance);
				}
				return r_RCameraTransform_String_Single_Vector3_Boolean_String_Single;
			}
		}

		/// <summary>
		/// Void CameraRotate(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RCameraRotate_Vector3;
		public virtual RMethod RCameraRotate_Vector3
		{
			get
			{
				if(r_RCameraRotate_Vector3 == null)
				{
					r_RCameraRotate_Vector3 = new(this, "CameraRotate", 0, typeof(UnityEngine.Vector3));
					r_RCameraRotate_Vector3.SetBelong(this.instance);
				}
				return r_RCameraRotate_Vector3;
			}
		}

		/// <summary>
		/// Void CameraRotateAt(System.String, Single, UnityEngine.Vector3, Boolean)
		/// </summary>
		protected RMethod r_RCameraRotateAt_String_Single_Vector3_Boolean;
		public virtual RMethod RCameraRotateAt_String_Single_Vector3_Boolean
		{
			get
			{
				if(r_RCameraRotateAt_String_Single_Vector3_Boolean == null)
				{
					r_RCameraRotateAt_String_Single_Vector3_Boolean = new(this, "CameraRotateAt", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_RCameraRotateAt_String_Single_Vector3_Boolean.SetBelong(this.instance);
				}
				return r_RCameraRotateAt_String_Single_Vector3_Boolean;
			}
		}

		/// <summary>
		/// Void UpdateCameraRotateAt()
		/// </summary>
		protected RMethod r_RUpdateCameraRotateAt;
		public virtual RMethod RUpdateCameraRotateAt
		{
			get
			{
				if(r_RUpdateCameraRotateAt == null)
				{
					r_RUpdateCameraRotateAt = new(this, "UpdateCameraRotateAt", 0);
					r_RUpdateCameraRotateAt.SetBelong(this.instance);
				}
				return r_RUpdateCameraRotateAt;
			}
		}

		/// <summary>
		/// Void CameraFollow(System.String, Boolean, Single)
		/// </summary>
		protected RMethod r_RCameraFollow_String_Boolean_Single;
		public virtual RMethod RCameraFollow_String_Boolean_Single
		{
			get
			{
				if(r_RCameraFollow_String_Boolean_Single == null)
				{
					r_RCameraFollow_String_Boolean_Single = new(this, "CameraFollow", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Single));
					r_RCameraFollow_String_Boolean_Single.SetBelong(this.instance);
				}
				return r_RCameraFollow_String_Boolean_Single;
			}
		}

		/// <summary>
		/// Void CameraRestore()
		/// </summary>
		protected RMethod r_RCameraRestore;
		public virtual RMethod RCameraRestore
		{
			get
			{
				if(r_RCameraRestore == null)
				{
					r_RCameraRestore = new(this, "CameraRestore", 0);
					r_RCameraRestore.SetBelong(this.instance);
				}
				return r_RCameraRestore;
			}
		}

		/// <summary>
		/// Void UpdateCameraFollow()
		/// </summary>
		protected RMethod r_RUpdateCameraFollow;
		public virtual RMethod RUpdateCameraFollow
		{
			get
			{
				if(r_RUpdateCameraFollow == null)
				{
					r_RUpdateCameraFollow = new(this, "UpdateCameraFollow", 0);
					r_RUpdateCameraFollow.SetBelong(this.instance);
				}
				return r_RUpdateCameraFollow;
			}
		}

		/// <summary>
		/// Void SetCameraFocusLength(Single)
		/// </summary>
		protected RMethod r_RSetCameraFocusLength_Single;
		public virtual RMethod RSetCameraFocusLength_Single
		{
			get
			{
				if(r_RSetCameraFocusLength_Single == null)
				{
					r_RSetCameraFocusLength_Single = new(this, "SetCameraFocusLength", 0, typeof(System.Single));
					r_RSetCameraFocusLength_Single.SetBelong(this.instance);
				}
				return r_RSetCameraFocusLength_Single;
			}
		}

		/// <summary>
		/// Void ProcessCrossFade(System.String, Single, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RProcessCrossFade_String_Single_Texture;
		public virtual RMethod RProcessCrossFade_String_Single_Texture
		{
			get
			{
				if(r_RProcessCrossFade_String_Single_Texture == null)
				{
					r_RProcessCrossFade_String_Single_Texture = new(this, "ProcessCrossFade", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.Texture));
					r_RProcessCrossFade_String_Single_Texture.SetBelong(this.instance);
				}
				return r_RProcessCrossFade_String_Single_Texture;
			}
		}

		/// <summary>
		/// Void CameraGoto(UnityEngine.Vector3, UnityEngine.Vector3, Single, Single, Boolean, System.String, Single, UnityEngine.Texture)
		/// </summary>
		protected RMethod r_RCameraGoto_Vector3_Vector3_Single_Single_Boolean_String_Single_Texture;
		public virtual RMethod RCameraGoto_Vector3_Vector3_Single_Single_Boolean_String_Single_Texture
		{
			get
			{
				if(r_RCameraGoto_Vector3_Vector3_Single_Single_Boolean_String_Single_Texture == null)
				{
					r_RCameraGoto_Vector3_Vector3_Single_Single_Boolean_String_Single_Texture = new(this, "CameraGoto", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Single), typeof(System.Boolean), typeof(System.String), typeof(System.Single), typeof(UnityEngine.Texture));
					r_RCameraGoto_Vector3_Vector3_Single_Single_Boolean_String_Single_Texture.SetBelong(this.instance);
				}
				return r_RCameraGoto_Vector3_Vector3_Single_Single_Boolean_String_Single_Texture;
			}
		}

		/// <summary>
		/// Void UpdateCameraGoto()
		/// </summary>
		protected RMethod r_RUpdateCameraGoto;
		public virtual RMethod RUpdateCameraGoto
		{
			get
			{
				if(r_RUpdateCameraGoto == null)
				{
					r_RUpdateCameraGoto = new(this, "UpdateCameraGoto", 0);
					r_RUpdateCameraGoto.SetBelong(this.instance);
				}
				return r_RUpdateCameraGoto;
			}
		}

		/// <summary>
		/// Boolean IsFadingOut()
		/// </summary>
		protected RMethod r_RIsFadingOut;
		public virtual RMethod RIsFadingOut
		{
			get
			{
				if(r_RIsFadingOut == null)
				{
					r_RIsFadingOut = new(this, "IsFadingOut", 0);
					r_RIsFadingOut.SetBelong(this.instance);
				}
				return r_RIsFadingOut;
			}
		}

		/// <summary>
		/// Boolean IsFadingIn()
		/// </summary>
		protected RMethod r_RIsFadingIn;
		public virtual RMethod RIsFadingIn
		{
			get
			{
				if(r_RIsFadingIn == null)
				{
					r_RIsFadingIn = new(this, "IsFadingIn", 0);
					r_RIsFadingIn.SetBelong(this.instance);
				}
				return r_RIsFadingIn;
			}
		}

		/// <summary>
		/// Boolean IsCameraGoto()
		/// </summary>
		protected RMethod r_RIsCameraGoto;
		public virtual RMethod RIsCameraGoto
		{
			get
			{
				if(r_RIsCameraGoto == null)
				{
					r_RIsCameraGoto = new(this, "IsCameraGoto", 0);
					r_RIsCameraGoto.SetBelong(this.instance);
				}
				return r_RIsCameraGoto;
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
		/// Void BlurEffectOn(Int32)
		/// </summary>
		protected RMethod r_RBlurEffectOn_Int32;
		public virtual RMethod RBlurEffectOn_Int32
		{
			get
			{
				if(r_RBlurEffectOn_Int32 == null)
				{
					r_RBlurEffectOn_Int32 = new(this, "BlurEffectOn", 0, typeof(System.Int32));
					r_RBlurEffectOn_Int32.SetBelong(this.instance);
				}
				return r_RBlurEffectOn_Int32;
			}
		}

		/// <summary>
		/// Void BlurEffectOff()
		/// </summary>
		protected RMethod r_RBlurEffectOff;
		public virtual RMethod RBlurEffectOff
		{
			get
			{
				if(r_RBlurEffectOff == null)
				{
					r_RBlurEffectOff = new(this, "BlurEffectOff", 0);
					r_RBlurEffectOff.SetBelong(this.instance);
				}
				return r_RBlurEffectOff;
			}
		}

		/// <summary>
		/// Void BlurEffectTo(Int32, Int32, Single)
		/// </summary>
		protected RMethod r_RBlurEffectTo_Int32_Int32_Single;
		public virtual RMethod RBlurEffectTo_Int32_Int32_Single
		{
			get
			{
				if(r_RBlurEffectTo_Int32_Int32_Single == null)
				{
					r_RBlurEffectTo_Int32_Int32_Single = new(this, "BlurEffectTo", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Single));
					r_RBlurEffectTo_Int32_Int32_Single.SetBelong(this.instance);
				}
				return r_RBlurEffectTo_Int32_Int32_Single;
			}
		}

		/// <summary>
		/// Void UpdateBlurEffect()
		/// </summary>
		protected RMethod r_RUpdateBlurEffect;
		public virtual RMethod RUpdateBlurEffect
		{
			get
			{
				if(r_RUpdateBlurEffect == null)
				{
					r_RUpdateBlurEffect = new(this, "UpdateBlurEffect", 0);
					r_RUpdateBlurEffect.SetBelong(this.instance);
				}
				return r_RUpdateBlurEffect;
			}
		}

		/// <summary>
		/// Void TwirlOn(Single, Single, Int32, Int32, Single)
		/// </summary>
		protected RMethod r_RTwirlOn_Single_Single_Int32_Int32_Single;
		public virtual RMethod RTwirlOn_Single_Single_Int32_Int32_Single
		{
			get
			{
				if(r_RTwirlOn_Single_Single_Int32_Int32_Single == null)
				{
					r_RTwirlOn_Single_Single_Int32_Int32_Single = new(this, "TwirlOn", 0, typeof(System.Single), typeof(System.Single), typeof(System.Int32), typeof(System.Int32), typeof(System.Single));
					r_RTwirlOn_Single_Single_Int32_Int32_Single.SetBelong(this.instance);
				}
				return r_RTwirlOn_Single_Single_Int32_Int32_Single;
			}
		}

		/// <summary>
		/// Void UpdateTwirl()
		/// </summary>
		protected RMethod r_RUpdateTwirl;
		public virtual RMethod RUpdateTwirl
		{
			get
			{
				if(r_RUpdateTwirl == null)
				{
					r_RUpdateTwirl = new(this, "UpdateTwirl", 0);
					r_RUpdateTwirl.SetBelong(this.instance);
				}
				return r_RUpdateTwirl;
			}
		}

		/// <summary>
		/// Void TwirlOff()
		/// </summary>
		protected RMethod r_RTwirlOff;
		public virtual RMethod RTwirlOff
		{
			get
			{
				if(r_RTwirlOff == null)
				{
					r_RTwirlOff = new(this, "TwirlOff", 0);
					r_RTwirlOff.SetBelong(this.instance);
				}
				return r_RTwirlOff;
			}
		}

		/// <summary>
		/// Void ScreenShot(Single, Single)
		/// </summary>
		protected RMethod r_RScreenShot_Single_Single;
		public virtual RMethod RScreenShot_Single_Single
		{
			get
			{
				if(r_RScreenShot_Single_Single == null)
				{
					r_RScreenShot_Single_Single = new(this, "ScreenShot", 0, typeof(System.Single), typeof(System.Single));
					r_RScreenShot_Single_Single.SetBelong(this.instance);
				}
				return r_RScreenShot_Single_Single;
			}
		}

		/// <summary>
		/// Void DrawScreenShot()
		/// </summary>
		protected RMethod r_RDrawScreenShot;
		public virtual RMethod RDrawScreenShot
		{
			get
			{
				if(r_RDrawScreenShot == null)
				{
					r_RDrawScreenShot = new(this, "DrawScreenShot", 0);
					r_RDrawScreenShot.SetBelong(this.instance);
				}
				return r_RDrawScreenShot;
			}
		}

		/// <summary>
		/// Void UpdateScreenShot()
		/// </summary>
		protected RMethod r_RUpdateScreenShot;
		public virtual RMethod RUpdateScreenShot
		{
			get
			{
				if(r_RUpdateScreenShot == null)
				{
					r_RUpdateScreenShot = new(this, "UpdateScreenShot", 0);
					r_RUpdateScreenShot.SetBelong(this.instance);
				}
				return r_RUpdateScreenShot;
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


        public RSceneMovieCameraEffManager() : base("SceneMovieCameraEffManager")
        {
        }

        public RSceneMovieCameraEffManager(System.Object instance) : base("SceneMovieCameraEffManager")
		{
            SetInstance(instance);
		}

        public RSceneMovieCameraEffManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieCameraEffManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetupRenderCamera()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetupRenderCamera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCameraEff()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetCameraEff.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCameraAction()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetCameraAction.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowBloodEffect(System.Boolean  @bShow, System.String  @uiEffName, System.Single  @size)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bShow, @uiEffName, @size};
            var ___result = RShowBloodEffect_Boolean_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawBloodEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawBloodEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraShake(System.Single  @shakeH, System.Single  @shakeV, System.Single  @shakeTime, System.Boolean  @bWait)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shakeH, @shakeV, @shakeTime, @bWait};
            var ___result = RCameraShake_Single_Single_Single_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCameraShake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCameraShake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetAlwaysBlack(System.Boolean  @bEnable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bEnable};
            var ___result = RSetAlwaysBlack_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraFadeIn(System.Single  @time, UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @color};
            var ___result = RCameraFadeIn_Single_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraFadeOut(System.Single  @time, UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @color};
            var ___result = RCameraFadeOut_Single_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCameraFade()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCameraFade.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraBlock(System.Boolean  @bEnable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bEnable};
            var ___result = RCameraBlock_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCameraBlock()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCameraBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCameraMask()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCameraMask.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraMask(System.Boolean  @bEnable, UnityEngine.Color  @maskColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bEnable, @maskColor};
            var ___result = RCameraMask_Boolean_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraFocus(System.String  @objName, System.Single  @speed, System.Boolean  @bWait, System.Single  @distance, System.Boolean  @bLerp, UnityEngine.Vector3  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objName, @speed, @bWait, @distance, @bLerp, @rotation};
            var ___result = RCameraFocus_String_Single_Boolean_Single_Boolean_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCameraFocus()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCameraFocus.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraTransform(System.String  @objName, System.Single  @distance, UnityEngine.Vector3  @rotation, System.Boolean  @bWait, System.String  @crossMode, System.Single  @crosstime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@objName, @distance, @rotation, @bWait, @crossMode, @crosstime};
            var ___result = RCameraTransform_String_Single_Vector3_Boolean_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraRotate(UnityEngine.Vector3  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rotation};
            var ___result = RCameraRotate_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraRotateAt(System.String  @refName, System.Single  @speed, UnityEngine.Vector3  @rotation, System.Boolean  @bWait)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@refName, @speed, @rotation, @bWait};
            var ___result = RCameraRotateAt_String_Single_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCameraRotateAt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCameraRotateAt.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraFollow(System.String  @refName, System.Boolean  @bEnable, System.Single  @distance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@refName, @bEnable, @distance};
            var ___result = RCameraFollow_String_Boolean_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraRestore()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCameraRestore.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCameraFollow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCameraFollow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCameraFocusLength(System.Single  @focuslength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@focuslength};
            var ___result = RSetCameraFocusLength_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessCrossFade(System.String  @mode, System.Single  @time, UnityEngine.Texture  @crossTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode, @time, @crossTex};
            var ___result = RProcessCrossFade_String_Single_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CameraGoto(UnityEngine.Vector3  @pos, UnityEngine.Vector3  @rot, System.Single  @time, System.Single  @tgtLen, System.Boolean  @bWait, System.String  @crossMode, System.Single  @crosstime, UnityEngine.Texture  @crossTex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @rot, @time, @tgtLen, @bWait, @crossMode, @crosstime, @crossTex};
            var ___result = RCameraGoto_Vector3_Vector3_Single_Single_Boolean_String_Single_Texture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateCameraGoto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateCameraGoto.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsFadingOut()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFadingOut.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsFadingIn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsFadingIn.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsCameraGoto()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCameraGoto.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurEffectOn(System.Int32  @iterations)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iterations};
            var ___result = RBlurEffectOn_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurEffectOff()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBlurEffectOff.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BlurEffectTo(System.Int32  @from, System.Int32  @to, System.Single  @maxTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @maxTime};
            var ___result = RBlurEffectTo_Int32_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateBlurEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateBlurEffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TwirlOn(System.Single  @rX, System.Single  @rY, System.Int32  @fromangle, System.Int32  @toangle, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rX, @rY, @fromangle, @toangle, @time};
            var ___result = RTwirlOn_Single_Single_Int32_Int32_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateTwirl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateTwirl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void TwirlOff()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTwirlOff.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScreenShot(System.Single  @time, System.Single  @greyTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time, @greyTime};
            var ___result = RScreenShot_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawScreenShot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawScreenShot.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateScreenShot()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateScreenShot.Invoke(___genericsType, ___parameters);

            
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
