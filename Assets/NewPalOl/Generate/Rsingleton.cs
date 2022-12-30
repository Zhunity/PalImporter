using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// singleton
	/// </summary>
    public partial class Rsingleton : RMember //
    {

		/// <summary>
		/// singleton Inst
		/// </summary>
		protected static Rsingleton r_Inst;
		public static Rsingleton RInst
		{
			get
			{
				if(r_Inst == null)
				{
					r_Inst = new( ReleactionUtils.GetType("singleton"), "Inst");
					r_Inst.SetBelong(null);
				}
				return r_Inst;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject _CombatAreaObj
		/// </summary>
		protected RUnityEngine.RGameObject r__CombatAreaObj;
		public virtual RUnityEngine.RGameObject R_CombatAreaObj
		{
			get
			{
				if(r__CombatAreaObj == null)
				{
					r__CombatAreaObj = new(this, "_CombatAreaObj");
					r__CombatAreaObj.SetBelong(this.instance);
				}
				return r__CombatAreaObj;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject CombatAreaObj
		/// </summary>
		protected RUnityEngine.RGameObject r_CombatAreaObj;
		public virtual RUnityEngine.RGameObject RCombatAreaObj
		{
			get
			{
				if(r_CombatAreaObj == null)
				{
					r_CombatAreaObj = new(this, "CombatAreaObj");
					r_CombatAreaObj.SetBelong(this.instance);
				}
				return r_CombatAreaObj;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject _MatrixAreaObj
		/// </summary>
		protected RUnityEngine.RGameObject r__MatrixAreaObj;
		public virtual RUnityEngine.RGameObject R_MatrixAreaObj
		{
			get
			{
				if(r__MatrixAreaObj == null)
				{
					r__MatrixAreaObj = new(this, "_MatrixAreaObj");
					r__MatrixAreaObj.SetBelong(this.instance);
				}
				return r__MatrixAreaObj;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mNPCMark
		/// </summary>
		protected RUnityEngine.RGameObject r_mNPCMark;
		public virtual RUnityEngine.RGameObject RmNPCMark
		{
			get
			{
				if(r_mNPCMark == null)
				{
					r_mNPCMark = new(this, "mNPCMark");
					r_mNPCMark.SetBelong(this.instance);
				}
				return r_mNPCMark;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mNumPrefab1
		/// </summary>
		protected RUnityEngine.RGameObject r_mNumPrefab1;
		public virtual RUnityEngine.RGameObject RmNumPrefab1
		{
			get
			{
				if(r_mNumPrefab1 == null)
				{
					r_mNumPrefab1 = new(this, "mNumPrefab1");
					r_mNumPrefab1.SetBelong(this.instance);
				}
				return r_mNumPrefab1;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mNumPrefab2
		/// </summary>
		protected RUnityEngine.RGameObject r_mNumPrefab2;
		public virtual RUnityEngine.RGameObject RmNumPrefab2
		{
			get
			{
				if(r_mNumPrefab2 == null)
				{
					r_mNumPrefab2 = new(this, "mNumPrefab2");
					r_mNumPrefab2.SetBelong(this.instance);
				}
				return r_mNumPrefab2;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mNumPrefab3
		/// </summary>
		protected RUnityEngine.RGameObject r_mNumPrefab3;
		public virtual RUnityEngine.RGameObject RmNumPrefab3
		{
			get
			{
				if(r_mNumPrefab3 == null)
				{
					r_mNumPrefab3 = new(this, "mNumPrefab3");
					r_mNumPrefab3.SetBelong(this.instance);
				}
				return r_mNumPrefab3;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mTransport
		/// </summary>
		protected RUnityEngine.RGameObject r_mTransport;
		public virtual RUnityEngine.RGameObject RmTransport
		{
			get
			{
				if(r_mTransport == null)
				{
					r_mTransport = new(this, "mTransport");
					r_mTransport.SetBelong(this.instance);
				}
				return r_mTransport;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mDirectionEff
		/// </summary>
		protected RUnityEngine.RGameObject r_mDirectionEff;
		public virtual RUnityEngine.RGameObject RmDirectionEff
		{
			get
			{
				if(r_mDirectionEff == null)
				{
					r_mDirectionEff = new(this, "mDirectionEff");
					r_mDirectionEff.SetBelong(this.instance);
				}
				return r_mDirectionEff;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mPathFindEF
		/// </summary>
		protected RUnityEngine.RGameObject r_mPathFindEF;
		public virtual RUnityEngine.RGameObject RmPathFindEF
		{
			get
			{
				if(r_mPathFindEF == null)
				{
					r_mPathFindEF = new(this, "mPathFindEF");
					r_mPathFindEF.SetBelong(this.instance);
				}
				return r_mPathFindEF;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mHighlightEF
		/// </summary>
		protected RUnityEngine.RGameObject r_mHighlightEF;
		public virtual RUnityEngine.RGameObject RmHighlightEF
		{
			get
			{
				if(r_mHighlightEF == null)
				{
					r_mHighlightEF = new(this, "mHighlightEF");
					r_mHighlightEF.SetBelong(this.instance);
				}
				return r_mHighlightEF;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject ui_douhun01
		/// </summary>
		protected RUnityEngine.RGameObject r_ui_douhun01;
		public virtual RUnityEngine.RGameObject Rui_douhun01
		{
			get
			{
				if(r_ui_douhun01 == null)
				{
					r_ui_douhun01 = new(this, "ui_douhun01");
					r_ui_douhun01.SetBelong(this.instance);
				}
				return r_ui_douhun01;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject ui_douhun
		/// </summary>
		protected RUnityEngine.RGameObject r_ui_douhun;
		public virtual RUnityEngine.RGameObject Rui_douhun
		{
			get
			{
				if(r_ui_douhun == null)
				{
					r_ui_douhun = new(this, "ui_douhun");
					r_ui_douhun.SetBelong(this.instance);
				}
				return r_ui_douhun;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mCursorTraction
		/// </summary>
		protected RUnityEngine.RGameObject r_mCursorTraction;
		public virtual RUnityEngine.RGameObject RmCursorTraction
		{
			get
			{
				if(r_mCursorTraction == null)
				{
					r_mCursorTraction = new(this, "mCursorTraction");
					r_mCursorTraction.SetBelong(this.instance);
				}
				return r_mCursorTraction;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mFishingRod
		/// </summary>
		protected RUnityEngine.RGameObject r_mFishingRod;
		public virtual RUnityEngine.RGameObject RmFishingRod
		{
			get
			{
				if(r_mFishingRod == null)
				{
					r_mFishingRod = new(this, "mFishingRod");
					r_mFishingRod.SetBelong(this.instance);
				}
				return r_mFishingRod;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mCaijiEffect
		/// </summary>
		protected RUnityEngine.RGameObject r_mCaijiEffect;
		public virtual RUnityEngine.RGameObject RmCaijiEffect
		{
			get
			{
				if(r_mCaijiEffect == null)
				{
					r_mCaijiEffect = new(this, "mCaijiEffect");
					r_mCaijiEffect.SetBelong(this.instance);
				}
				return r_mCaijiEffect;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mBottle
		/// </summary>
		protected RUnityEngine.RGameObject r_mBottle;
		public virtual RUnityEngine.RGameObject RmBottle
		{
			get
			{
				if(r_mBottle == null)
				{
					r_mBottle = new(this, "mBottle");
					r_mBottle.SetBelong(this.instance);
				}
				return r_mBottle;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mHammer
		/// </summary>
		protected RUnityEngine.RGameObject r_mHammer;
		public virtual RUnityEngine.RGameObject RmHammer
		{
			get
			{
				if(r_mHammer == null)
				{
					r_mHammer = new(this, "mHammer");
					r_mHammer.SetBelong(this.instance);
				}
				return r_mHammer;
			}
		}

		/// <summary>
		/// System.Boolean isNetPlayerMove
		/// </summary>
		protected RField r_isNetPlayerMove;
		public virtual RField RisNetPlayerMove
		{
			get
			{
				if(r_isNetPlayerMove == null)
				{
					r_isNetPlayerMove = new(this, "isNetPlayerMove");
					r_isNetPlayerMove.SetBelong(this.instance);
				}
				return r_isNetPlayerMove;
			}
		}

		/// <summary>
		/// SingletonConfigHold config
		/// </summary>
		protected RSingletonConfigHold r_config;
		public virtual RSingletonConfigHold Rconfig
		{
			get
			{
				if(r_config == null)
				{
					r_config = new(this, "config");
					r_config.SetBelong(this.instance);
				}
				return r_config;
			}
		}

		/// <summary>
		/// UnityEngine.LayerMask testLayer
		/// </summary>
		protected RUnityEngine.RLayerMask r_testLayer;
		public virtual RUnityEngine.RLayerMask RtestLayer
		{
			get
			{
				if(r_testLayer == null)
				{
					r_testLayer = new(this, "testLayer");
					r_testLayer.SetBelong(this.instance);
				}
				return r_testLayer;
			}
		}

		/// <summary>
		/// System.Boolean robotTest
		/// </summary>
		protected RField r_robotTest;
		public virtual RField RrobotTest
		{
			get
			{
				if(r_robotTest == null)
				{
					r_robotTest = new(this, "robotTest");
					r_robotTest.SetBelong(this.instance);
				}
				return r_robotTest;
			}
		}

		/// <summary>
		/// System.Boolean m_debug
		/// </summary>
		protected RField r_m_debug;
		public virtual RField Rm_debug
		{
			get
			{
				if(r_m_debug == null)
				{
					r_m_debug = new(this, "m_debug");
					r_m_debug.SetBelong(this.instance);
				}
				return r_m_debug;
			}
		}

		/// <summary>
		/// System.Boolean isDrawUI
		/// </summary>
		protected RField r_isDrawUI;
		public virtual RField RisDrawUI
		{
			get
			{
				if(r_isDrawUI == null)
				{
					r_isDrawUI = new(this, "isDrawUI");
					r_isDrawUI.SetBelong(this.instance);
				}
				return r_isDrawUI;
			}
		}

		/// <summary>
		/// System.Boolean isDoubleSideShder
		/// </summary>
		protected RField r_isDoubleSideShder;
		public virtual RField RisDoubleSideShder
		{
			get
			{
				if(r_isDoubleSideShder == null)
				{
					r_isDoubleSideShder = new(this, "isDoubleSideShder");
					r_isDoubleSideShder.SetBelong(this.instance);
				}
				return r_isDoubleSideShder;
			}
		}

		/// <summary>
		/// System.Boolean noUI
		/// </summary>
		protected RField r_noUI;
		public virtual RField RnoUI
		{
			get
			{
				if(r_noUI == null)
				{
					r_noUI = new(this, "noUI");
					r_noUI.SetBelong(this.instance);
				}
				return r_noUI;
			}
		}

		/// <summary>
		/// System.Boolean isDrawPlayerName
		/// </summary>
		protected RField r_isDrawPlayerName;
		public virtual RField RisDrawPlayerName
		{
			get
			{
				if(r_isDrawPlayerName == null)
				{
					r_isDrawPlayerName = new(this, "isDrawPlayerName");
					r_isDrawPlayerName.SetBelong(this.instance);
				}
				return r_isDrawPlayerName;
			}
		}

		/// <summary>
		/// System.Boolean isDrawPlayerNameShadow
		/// </summary>
		protected RField r_isDrawPlayerNameShadow;
		public virtual RField RisDrawPlayerNameShadow
		{
			get
			{
				if(r_isDrawPlayerNameShadow == null)
				{
					r_isDrawPlayerNameShadow = new(this, "isDrawPlayerNameShadow");
					r_isDrawPlayerNameShadow.SetBelong(this.instance);
				}
				return r_isDrawPlayerNameShadow;
			}
		}

		/// <summary>
		/// System.Boolean isTestinggggggggggggggggggggg
		/// </summary>
		protected RField r_isTestinggggggggggggggggggggg;
		public virtual RField RisTestinggggggggggggggggggggg
		{
			get
			{
				if(r_isTestinggggggggggggggggggggg == null)
				{
					r_isTestinggggggggggggggggggggg = new(this, "isTestinggggggggggggggggggggg");
					r_isTestinggggggggggggggggggggg.SetBelong(this.instance);
				}
				return r_isTestinggggggggggggggggggggg;
			}
		}

		/// <summary>
		/// System.Single mTimeClick
		/// </summary>
		protected RField r_mTimeClick;
		public virtual RField RmTimeClick
		{
			get
			{
				if(r_mTimeClick == null)
				{
					r_mTimeClick = new(this, "mTimeClick");
					r_mTimeClick.SetBelong(this.instance);
				}
				return r_mTimeClick;
			}
		}

		/// <summary>
		/// System.Single ReLoadMaxTime
		/// </summary>
		protected RField r_ReLoadMaxTime;
		public virtual RField ReLoadMaxTime
		{
			get
			{
				if(r_ReLoadMaxTime == null)
				{
					r_ReLoadMaxTime = new(this, "ReLoadMaxTime");
					r_ReLoadMaxTime.SetBelong(this.instance);
				}
				return r_ReLoadMaxTime;
			}
		}

		/// <summary>
		/// System.Boolean OutputGameMusicRecord
		/// </summary>
		protected RField r_OutputGameMusicRecord;
		public virtual RField ROutputGameMusicRecord
		{
			get
			{
				if(r_OutputGameMusicRecord == null)
				{
					r_OutputGameMusicRecord = new(this, "OutputGameMusicRecord");
					r_OutputGameMusicRecord.SetBelong(this.instance);
				}
				return r_OutputGameMusicRecord;
			}
		}

		/// <summary>
		/// System.Boolean OutputProperEvaluator
		/// </summary>
		protected RField r_OutputProperEvaluator;
		public virtual RField ROutputProperEvaluator
		{
			get
			{
				if(r_OutputProperEvaluator == null)
				{
					r_OutputProperEvaluator = new(this, "OutputProperEvaluator");
					r_OutputProperEvaluator.SetBelong(this.instance);
				}
				return r_OutputProperEvaluator;
			}
		}

		/// <summary>
		/// System.Boolean isCameraFollow
		/// </summary>
		protected RField r_isCameraFollow;
		public virtual RField RisCameraFollow
		{
			get
			{
				if(r_isCameraFollow == null)
				{
					r_isCameraFollow = new(this, "isCameraFollow");
					r_isCameraFollow.SetBelong(this.instance);
				}
				return r_isCameraFollow;
			}
		}

		/// <summary>
		/// UnityEngine.MovieTexture m_testMovie
		/// </summary>
		protected RUnityEngine.RMovieTexture r_m_testMovie;
		public virtual RUnityEngine.RMovieTexture Rm_testMovie
		{
			get
			{
				if(r_m_testMovie == null)
				{
					r_m_testMovie = new(this, "m_testMovie");
					r_m_testMovie.SetBelong(this.instance);
				}
				return r_m_testMovie;
			}
		}

		/// <summary>
		/// UnityEngine.Rect _rect
		/// </summary>
		protected RUnityEngine.RRect r__rect;
		public virtual RUnityEngine.RRect R_rect
		{
			get
			{
				if(r__rect == null)
				{
					r__rect = new(this, "_rect");
					r__rect.SetBelong(this.instance);
				}
				return r__rect;
			}
		}

		/// <summary>
		/// System.Boolean isNetWorkStop
		/// </summary>
		protected RField r_isNetWorkStop;
		public virtual RField RisNetWorkStop
		{
			get
			{
				if(r_isNetWorkStop == null)
				{
					r_isNetWorkStop = new(this, "isNetWorkStop");
					r_isNetWorkStop.SetBelong(this.instance);
				}
				return r_isNetWorkStop;
			}
		}

		/// <summary>
		/// System.Boolean isDrawCrossLine
		/// </summary>
		protected RField r_isDrawCrossLine;
		public virtual RField RisDrawCrossLine
		{
			get
			{
				if(r_isDrawCrossLine == null)
				{
					r_isDrawCrossLine = new(this, "isDrawCrossLine");
					r_isDrawCrossLine.SetBelong(this.instance);
				}
				return r_isDrawCrossLine;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_LineTex1
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_LineTex1;
		public virtual RUnityEngine.RTexture2D Rm_LineTex1
		{
			get
			{
				if(r_m_LineTex1 == null)
				{
					r_m_LineTex1 = new(this, "m_LineTex1");
					r_m_LineTex1.SetBelong(this.instance);
				}
				return r_m_LineTex1;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_LineTex2
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_LineTex2;
		public virtual RUnityEngine.RTexture2D Rm_LineTex2
		{
			get
			{
				if(r_m_LineTex2 == null)
				{
					r_m_LineTex2 = new(this, "m_LineTex2");
					r_m_LineTex2.SetBelong(this.instance);
				}
				return r_m_LineTex2;
			}
		}

		/// <summary>
		/// System.String allObjName
		/// </summary>
		protected RField r_allObjName;
		public virtual RField RallObjName
		{
			get
			{
				if(r_allObjName == null)
				{
					r_allObjName = new(this, "allObjName");
					r_allObjName.SetBelong(this.instance);
				}
				return r_allObjName;
			}
		}

		/// <summary>
		/// UnityEngine.Rect testRect
		/// </summary>
		protected RUnityEngine.RRect r_testRect;
		public virtual RUnityEngine.RRect RtestRect
		{
			get
			{
				if(r_testRect == null)
				{
					r_testRect = new(this, "testRect");
					r_testRect.SetBelong(this.instance);
				}
				return r_testRect;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Texture] allTex
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RTexture> r_allTex;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RTexture> RallTex
		{
			get
			{
				if(r_allTex == null)
				{
					r_allTex = new(this, "allTex");
					r_allTex.SetBelong(this.instance);
				}
				return r_allTex;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationClip[] tempAllAnimationClips
		/// </summary>
		protected RFieldArray<RUnityEngine.RAnimationClip> r_tempAllAnimationClips;
		public virtual RFieldArray<RUnityEngine.RAnimationClip> RtempAllAnimationClips
		{
			get
			{
				if(r_tempAllAnimationClips == null)
				{
					r_tempAllAnimationClips = new(this, "tempAllAnimationClips");
					r_tempAllAnimationClips.SetBelong(this.instance);
				}
				return r_tempAllAnimationClips;
			}
		}

		/// <summary>
		/// System.Single timeClick
		/// </summary>
		protected RField r_timeClick;
		public virtual RField RtimeClick
		{
			get
			{
				if(r_timeClick == null)
				{
					r_timeClick = new(this, "timeClick");
					r_timeClick.SetBelong(this.instance);
				}
				return r_timeClick;
			}
		}

		/// <summary>
		/// System.Boolean isSetGameTime
		/// </summary>
		protected RField r_isSetGameTime;
		public virtual RField RisSetGameTime
		{
			get
			{
				if(r_isSetGameTime == null)
				{
					r_isSetGameTime = new(this, "isSetGameTime");
					r_isSetGameTime.SetBelong(this.instance);
				}
				return r_isSetGameTime;
			}
		}

		/// <summary>
		/// System.String tmpStrSpd1
		/// </summary>
		protected RField r_tmpStrSpd1;
		public virtual RField RtmpStrSpd1
		{
			get
			{
				if(r_tmpStrSpd1 == null)
				{
					r_tmpStrSpd1 = new(this, "tmpStrSpd1");
					r_tmpStrSpd1.SetBelong(this.instance);
				}
				return r_tmpStrSpd1;
			}
		}

		/// <summary>
		/// System.String tmpStrSpd2
		/// </summary>
		protected RField r_tmpStrSpd2;
		public virtual RField RtmpStrSpd2
		{
			get
			{
				if(r_tmpStrSpd2 == null)
				{
					r_tmpStrSpd2 = new(this, "tmpStrSpd2");
					r_tmpStrSpd2.SetBelong(this.instance);
				}
				return r_tmpStrSpd2;
			}
		}

		/// <summary>
		/// System.String tmpStrSpdpet
		/// </summary>
		protected RField r_tmpStrSpdpet;
		public virtual RField RtmpStrSpdpet
		{
			get
			{
				if(r_tmpStrSpdpet == null)
				{
					r_tmpStrSpdpet = new(this, "tmpStrSpdpet");
					r_tmpStrSpdpet.SetBelong(this.instance);
				}
				return r_tmpStrSpdpet;
			}
		}

		/// <summary>
		/// System.String mouseDisttan1
		/// </summary>
		protected RField r_mouseDisttan1;
		public virtual RField RmouseDisttan1
		{
			get
			{
				if(r_mouseDisttan1 == null)
				{
					r_mouseDisttan1 = new(this, "mouseDisttan1");
					r_mouseDisttan1.SetBelong(this.instance);
				}
				return r_mouseDisttan1;
			}
		}

		/// <summary>
		/// System.String mouseDistan2
		/// </summary>
		protected RField r_mouseDistan2;
		public virtual RField RmouseDistan2
		{
			get
			{
				if(r_mouseDistan2 == null)
				{
					r_mouseDistan2 = new(this, "mouseDistan2");
					r_mouseDistan2.SetBelong(this.instance);
				}
				return r_mouseDistan2;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle tmpTestStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_tmpTestStyle;
		public virtual RUnityEngine.RGUIStyle RtmpTestStyle
		{
			get
			{
				if(r_tmpTestStyle == null)
				{
					r_tmpTestStyle = new(this, "tmpTestStyle");
					r_tmpTestStyle.SetBelong(this.instance);
				}
				return r_tmpTestStyle;
			}
		}

		/// <summary>
		/// System.Single test111
		/// </summary>
		protected RField r_test111;
		public virtual RField Rtest111
		{
			get
			{
				if(r_test111 == null)
				{
					r_test111 = new(this, "test111");
					r_test111.SetBelong(this.instance);
				}
				return r_test111;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.GameObject] testObj
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> r_testObj;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> RtestObj
		{
			get
			{
				if(r_testObj == null)
				{
					r_testObj = new(this, "testObj");
					r_testObj.SetBelong(this.instance);
				}
				return r_testObj;
			}
		}

		/// <summary>
		/// System.String errorLog
		/// </summary>
		protected static RField r_errorLog;
		public static RField RerrorLog
		{
			get
			{
				if(r_errorLog == null)
				{
					r_errorLog = new( ReleactionUtils.GetType("singleton"), "errorLog");
					r_errorLog.SetBelong(null);
				}
				return r_errorLog;
			}
		}

		/// <summary>
		/// System.String mDebugLogStr
		/// </summary>
		protected RField r_mDebugLogStr;
		public virtual RField RmDebugLogStr
		{
			get
			{
				if(r_mDebugLogStr == null)
				{
					r_mDebugLogStr = new(this, "mDebugLogStr");
					r_mDebugLogStr.SetBelong(this.instance);
				}
				return r_mDebugLogStr;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle _style
		/// </summary>
		protected RUnityEngine.RGUIStyle r__style;
		public virtual RUnityEngine.RGUIStyle R_style
		{
			get
			{
				if(r__style == null)
				{
					r__style = new(this, "_style");
					r__style.SetBelong(this.instance);
				}
				return r__style;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Queue`1[System.String] logMsg
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<RField> r_logMsg;
		public virtual RSystem.RCollections.RGeneric.RQueue<RField> RlogMsg
		{
			get
			{
				if(r_logMsg == null)
				{
					r_logMsg = new(this, "logMsg");
					r_logMsg.SetBelong(this.instance);
				}
				return r_logMsg;
			}
		}

		/// <summary>
		/// System.IO.TextWriter streamWriter
		/// </summary>
		protected RSystem.RIO.RTextWriter r_streamWriter;
		public virtual RSystem.RIO.RTextWriter RstreamWriter
		{
			get
			{
				if(r_streamWriter == null)
				{
					r_streamWriter = new(this, "streamWriter");
					r_streamWriter.SetBelong(this.instance);
				}
				return r_streamWriter;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mCombatAreaObj
		/// </summary>
		protected RUnityEngine.RGameObject r_mCombatAreaObj;
		public virtual RUnityEngine.RGameObject RmCombatAreaObj
		{
			get
			{
				if(r_mCombatAreaObj == null)
				{
					r_mCombatAreaObj = new(this, "mCombatAreaObj", -1);
					r_mCombatAreaObj.SetBelong(this.instance);
				}
				return r_mCombatAreaObj;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject MatrixAreaObj
		/// </summary>
		protected RUnityEngine.RGameObject r_MatrixAreaObj;
		public virtual RUnityEngine.RGameObject RMatrixAreaObj
		{
			get
			{
				if(r_MatrixAreaObj == null)
				{
					r_MatrixAreaObj = new(this, "MatrixAreaObj", -1);
					r_MatrixAreaObj.SetBelong(this.instance);
				}
				return r_MatrixAreaObj;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_Havy
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_Havy;
		public virtual RUnityEngine.RTexture2D Rm_Havy
		{
			get
			{
				if(r_m_Havy == null)
				{
					r_m_Havy = new(this, "m_Havy", -1);
					r_m_Havy.SetBelong(this.instance);
				}
				return r_m_Havy;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mAdd
		/// </summary>
		protected RUnityEngine.RTexture2D r_mAdd;
		public virtual RUnityEngine.RTexture2D RmAdd
		{
			get
			{
				if(r_mAdd == null)
				{
					r_mAdd = new(this, "mAdd", -1);
					r_mAdd.SetBelong(this.instance);
				}
				return r_mAdd;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mCritHurt
		/// </summary>
		protected RUnityEngine.RTexture2D r_mCritHurt;
		public virtual RUnityEngine.RTexture2D RmCritHurt
		{
			get
			{
				if(r_mCritHurt == null)
				{
					r_mCritHurt = new(this, "mCritHurt", -1);
					r_mCritHurt.SetBelong(this.instance);
				}
				return r_mCritHurt;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mCritRecover
		/// </summary>
		protected RUnityEngine.RTexture2D r_mCritRecover;
		public virtual RUnityEngine.RTexture2D RmCritRecover
		{
			get
			{
				if(r_mCritRecover == null)
				{
					r_mCritRecover = new(this, "mCritRecover", -1);
					r_mCritRecover.SetBelong(this.instance);
				}
				return r_mCritRecover;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mDodge
		/// </summary>
		protected RUnityEngine.RTexture2D r_mDodge;
		public virtual RUnityEngine.RTexture2D RmDodge
		{
			get
			{
				if(r_mDodge == null)
				{
					r_mDodge = new(this, "mDodge", -1);
					r_mDodge.SetBelong(this.instance);
				}
				return r_mDodge;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_Mianyi
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_Mianyi;
		public virtual RUnityEngine.RTexture2D Rm_Mianyi
		{
			get
			{
				if(r_m_Mianyi == null)
				{
					r_m_Mianyi = new(this, "m_Mianyi", -1);
					r_m_Mianyi.SetBelong(this.instance);
				}
				return r_m_Mianyi;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] mHPNum
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTexture2D> r_mHPNum;
		public virtual RPropertyArray<RUnityEngine.RTexture2D> RmHPNum
		{
			get
			{
				if(r_mHPNum == null)
				{
					r_mHPNum = new(this, "mHPNum", -1);
					r_mHPNum.SetBelong(this.instance);
				}
				return r_mHPNum;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] mHPNumRecover
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTexture2D> r_mHPNumRecover;
		public virtual RPropertyArray<RUnityEngine.RTexture2D> RmHPNumRecover
		{
			get
			{
				if(r_mHPNumRecover == null)
				{
					r_mHPNumRecover = new(this, "mHPNumRecover", -1);
					r_mHPNumRecover.SetBelong(this.instance);
				}
				return r_mHPNumRecover;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mMiss
		/// </summary>
		protected RUnityEngine.RTexture2D r_mMiss;
		public virtual RUnityEngine.RTexture2D RmMiss
		{
			get
			{
				if(r_mMiss == null)
				{
					r_mMiss = new(this, "mMiss", -1);
					r_mMiss.SetBelong(this.instance);
				}
				return r_mMiss;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mHurt
		/// </summary>
		protected RUnityEngine.RTexture2D r_mHurt;
		public virtual RUnityEngine.RTexture2D RmHurt
		{
			get
			{
				if(r_mHurt == null)
				{
					r_mHurt = new(this, "mHurt", -1);
					r_mHurt.SetBelong(this.instance);
				}
				return r_mHurt;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] countdown
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTexture2D> r_countdown;
		public virtual RPropertyArray<RUnityEngine.RTexture2D> Rcountdown
		{
			get
			{
				if(r_countdown == null)
				{
					r_countdown = new(this, "countdown", -1);
					r_countdown.SetBelong(this.instance);
				}
				return r_countdown;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mAddMp
		/// </summary>
		protected RUnityEngine.RTexture2D r_mAddMp;
		public virtual RUnityEngine.RTexture2D RmAddMp
		{
			get
			{
				if(r_mAddMp == null)
				{
					r_mAddMp = new(this, "mAddMp", -1);
					r_mAddMp.SetBelong(this.instance);
				}
				return r_mAddMp;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D mReduceMp
		/// </summary>
		protected RUnityEngine.RTexture2D r_mReduceMp;
		public virtual RUnityEngine.RTexture2D RmReduceMp
		{
			get
			{
				if(r_mReduceMp == null)
				{
					r_mReduceMp = new(this, "mReduceMp", -1);
					r_mReduceMp.SetBelong(this.instance);
				}
				return r_mReduceMp;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] mMPNum
		/// </summary>
		protected RPropertyArray<RUnityEngine.RTexture2D> r_mMPNum;
		public virtual RPropertyArray<RUnityEngine.RTexture2D> RmMPNum
		{
			get
			{
				if(r_mMPNum == null)
				{
					r_mMPNum = new(this, "mMPNum", -1);
					r_mMPNum.SetBelong(this.instance);
				}
				return r_mMPNum;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle mStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mStyle;
		public virtual RUnityEngine.RGUIStyle RmStyle
		{
			get
			{
				if(r_mStyle == null)
				{
					r_mStyle = new(this, "mStyle", -1);
					r_mStyle.SetBelong(this.instance);
				}
				return r_mStyle;
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
		/// UnityEngine.Texture2D GetmCombatUI(System.String)
		/// </summary>
		protected RMethod r_RGetmCombatUI_String;
		public virtual RMethod RGetmCombatUI_String
		{
			get
			{
				if(r_RGetmCombatUI_String == null)
				{
					r_RGetmCombatUI_String = new(this, "GetmCombatUI", 0, typeof(System.String));
					r_RGetmCombatUI_String.SetBelong(this.instance);
				}
				return r_RGetmCombatUI_String;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D[] GetNums(Int32)
		/// </summary>
		protected RMethod r_RGetNums_Int32;
		public virtual RMethod RGetNums_Int32
		{
			get
			{
				if(r_RGetNums_Int32 == null)
				{
					r_RGetNums_Int32 = new(this, "GetNums", 0, typeof(System.Int32));
					r_RGetNums_Int32.SetBelong(this.instance);
				}
				return r_RGetNums_Int32;
			}
		}

		/// <summary>
		/// singleton Get()
		/// </summary>
		protected static RMethod r_RGet;
		public static RMethod RGet
		{
			get
			{
				if(r_RGet == null)
				{
					r_RGet = new( ReleactionUtils.GetType("singleton"), "Get", 0);
					r_RGet.SetBelong(null);
				}
				return r_RGet;
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
		/// Boolean IsDebugVersion()
		/// </summary>
		protected RMethod r_RIsDebugVersion;
		public virtual RMethod RIsDebugVersion
		{
			get
			{
				if(r_RIsDebugVersion == null)
				{
					r_RIsDebugVersion = new(this, "IsDebugVersion", 0);
					r_RIsDebugVersion.SetBelong(this.instance);
				}
				return r_RIsDebugVersion;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator Start()
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
		/// Void DownLoadTestEffect()
		/// </summary>
		protected RMethod r_RDownLoadTestEffect;
		public virtual RMethod RDownLoadTestEffect
		{
			get
			{
				if(r_RDownLoadTestEffect == null)
				{
					r_RDownLoadTestEffect = new(this, "DownLoadTestEffect", 0);
					r_RDownLoadTestEffect.SetBelong(this.instance);
				}
				return r_RDownLoadTestEffect;
			}
		}

		/// <summary>
		/// Void OnLoadTestObj(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadTestObj_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadTestObj_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadTestObj_Object_ABLoadedArgs == null)
				{
					r_ROnLoadTestObj_Object_ABLoadedArgs = new(this, "OnLoadTestObj", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadTestObj_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadTestObj_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void testWebFun(System.String)
		/// </summary>
		protected RMethod r_RtestWebFun_String;
		public virtual RMethod RtestWebFun_String
		{
			get
			{
				if(r_RtestWebFun_String == null)
				{
					r_RtestWebFun_String = new(this, "testWebFun", 0, typeof(System.String));
					r_RtestWebFun_String.SetBelong(this.instance);
				}
				return r_RtestWebFun_String;
			}
		}

		/// <summary>
		/// Void OnLoadObjectConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadObjectConfig_Object;
		public virtual RMethod ROnLoadObjectConfig_Object
		{
			get
			{
				if(r_ROnLoadObjectConfig_Object == null)
				{
					r_ROnLoadObjectConfig_Object = new(this, "OnLoadObjectConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadObjectConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadObjectConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator DownLoadObject()
		/// </summary>
		protected RMethod r_RDownLoadObject;
		public virtual RMethod RDownLoadObject
		{
			get
			{
				if(r_RDownLoadObject == null)
				{
					r_RDownLoadObject = new(this, "DownLoadObject", 0);
					r_RDownLoadObject.SetBelong(this.instance);
				}
				return r_RDownLoadObject;
			}
		}

		/// <summary>
		/// Void OnLoadObj(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadObj_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadObj_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadObj_Object_ABLoadedArgs == null)
				{
					r_ROnLoadObj_Object_ABLoadedArgs = new(this, "OnLoadObj", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadObj_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadObj_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadMaskWordConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadMaskWordConfig_Object;
		public virtual RMethod ROnLoadMaskWordConfig_Object
		{
			get
			{
				if(r_ROnLoadMaskWordConfig_Object == null)
				{
					r_ROnLoadMaskWordConfig_Object = new(this, "OnLoadMaskWordConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadMaskWordConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadMaskWordConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator TestEffect()
		/// </summary>
		protected RMethod r_RTestEffect;
		public virtual RMethod RTestEffect
		{
			get
			{
				if(r_RTestEffect == null)
				{
					r_RTestEffect = new(this, "TestEffect", 0);
					r_RTestEffect.SetBelong(this.instance);
				}
				return r_RTestEffect;
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
		/// Void DebugMeshInfo()
		/// </summary>
		protected RMethod r_RDebugMeshInfo;
		public virtual RMethod RDebugMeshInfo
		{
			get
			{
				if(r_RDebugMeshInfo == null)
				{
					r_RDebugMeshInfo = new(this, "DebugMeshInfo", 0);
					r_RDebugMeshInfo.SetBelong(this.instance);
				}
				return r_RDebugMeshInfo;
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
		/// Void ReLoadBattleAniEffectConfig()
		/// </summary>
		protected RMethod r_RReLoadBattleAniEffectConfig;
		public virtual RMethod RReLoadBattleAniEffectConfig
		{
			get
			{
				if(r_RReLoadBattleAniEffectConfig == null)
				{
					r_RReLoadBattleAniEffectConfig = new(this, "ReLoadBattleAniEffectConfig", 0);
					r_RReLoadBattleAniEffectConfig.SetBelong(this.instance);
				}
				return r_RReLoadBattleAniEffectConfig;
			}
		}

		/// <summary>
		/// Void DrawCharacterController()
		/// </summary>
		protected RMethod r_RDrawCharacterController;
		public virtual RMethod RDrawCharacterController
		{
			get
			{
				if(r_RDrawCharacterController == null)
				{
					r_RDrawCharacterController = new(this, "DrawCharacterController", 0);
					r_RDrawCharacterController.SetBelong(this.instance);
				}
				return r_RDrawCharacterController;
			}
		}

		/// <summary>
		/// Void OpenXml()
		/// </summary>
		protected RMethod r_ROpenXml;
		public virtual RMethod ROpenXml
		{
			get
			{
				if(r_ROpenXml == null)
				{
					r_ROpenXml = new(this, "OpenXml", 0);
					r_ROpenXml.SetBelong(this.instance);
				}
				return r_ROpenXml;
			}
		}

		/// <summary>
		/// Void ShowMessage(System.String)
		/// </summary>
		protected RMethod r_RShowMessage_String;
		public virtual RMethod RShowMessage_String
		{
			get
			{
				if(r_RShowMessage_String == null)
				{
					r_RShowMessage_String = new(this, "ShowMessage", 0, typeof(System.String));
					r_RShowMessage_String.SetBelong(this.instance);
				}
				return r_RShowMessage_String;
			}
		}

		/// <summary>
		/// Void UpdateMesggeSend()
		/// </summary>
		protected RMethod r_RUpdateMesggeSend;
		public virtual RMethod RUpdateMesggeSend
		{
			get
			{
				if(r_RUpdateMesggeSend == null)
				{
					r_RUpdateMesggeSend = new(this, "UpdateMesggeSend", 0);
					r_RUpdateMesggeSend.SetBelong(this.instance);
				}
				return r_RUpdateMesggeSend;
			}
		}

		/// <summary>
		/// Void ShowMessage(#u.#B7, System.String)
		/// </summary>
		protected RMethod r_RShowMessage___0__B7_String;
		public virtual RMethod RShowMessage___0__B7_String
		{
			get
			{
				if(r_RShowMessage___0__B7_String == null)
				{
					r_RShowMessage___0__B7_String = new(this, "ShowMessage", 0,  ReleactionUtils.GetType("#u.#B7"), typeof(System.String));
					r_RShowMessage___0__B7_String.SetBelong(this.instance);
				}
				return r_RShowMessage___0__B7_String;
			}
		}

		/// <summary>
		/// Void WriteFileLog(System.String)
		/// </summary>
		protected RMethod r_RWriteFileLog_String;
		public virtual RMethod RWriteFileLog_String
		{
			get
			{
				if(r_RWriteFileLog_String == null)
				{
					r_RWriteFileLog_String = new(this, "WriteFileLog", 0, typeof(System.String));
					r_RWriteFileLog_String.SetBelong(this.instance);
				}
				return r_RWriteFileLog_String;
			}
		}

		/// <summary>
		/// Void AssetLog(System.String)
		/// </summary>
		protected RMethod r_RAssetLog_String;
		public virtual RMethod RAssetLog_String
		{
			get
			{
				if(r_RAssetLog_String == null)
				{
					r_RAssetLog_String = new(this, "AssetLog", 0, typeof(System.String));
					r_RAssetLog_String.SetBelong(this.instance);
				}
				return r_RAssetLog_String;
			}
		}

		/// <summary>
		/// Void DebugAsset(System.Type)
		/// </summary>
		protected RMethod r_RDebugAsset_Type;
		public virtual RMethod RDebugAsset_Type
		{
			get
			{
				if(r_RDebugAsset_Type == null)
				{
					r_RDebugAsset_Type = new(this, "DebugAsset", 0, typeof(System.Type));
					r_RDebugAsset_Type.SetBelong(this.instance);
				}
				return r_RDebugAsset_Type;
			}
		}

		/// <summary>
		/// Void FileLog(System.String, System.String)
		/// </summary>
		protected static RMethod r_RFileLog_String_String;
		public static RMethod RFileLog_String_String
		{
			get
			{
				if(r_RFileLog_String_String == null)
				{
					r_RFileLog_String_String = new( ReleactionUtils.GetType("singleton"), "FileLog", 0, typeof(System.String), typeof(System.String));
					r_RFileLog_String_String.SetBelong(null);
				}
				return r_RFileLog_String_String;
			}
		}

		/// <summary>
		/// Void RestSingleton()
		/// </summary>
		protected RMethod r_RRestSingleton;
		public virtual RMethod RRestSingleton
		{
			get
			{
				if(r_RRestSingleton == null)
				{
					r_RRestSingleton = new(this, "RestSingleton", 0);
					r_RRestSingleton.SetBelong(this.instance);
				}
				return r_RRestSingleton;
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


        public Rsingleton() : base("singleton")
        {
        }

        public Rsingleton(System.Object instance) : base("singleton")
		{
            SetInstance(instance);
		}

        public Rsingleton(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public Rsingleton(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.Texture2D GetmCombatUI(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetmCombatUI_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public virtual UnityEngine.Texture2D[] GetNums(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetNums_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D[])___result;
        }


        public static System.Object Get()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGet.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsDebugVersion()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsDebugVersion.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.IEnumerator Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void DownLoadTestEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDownLoadTestEffect.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void testWebFun(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RtestWebFun_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadObjectConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadObjectConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator DownLoadObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDownLoadObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }



        public virtual void OnLoadMaskWordConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadMaskWordConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator TestEffect()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RTestEffect.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DebugMeshInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDebugMeshInfo.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnGUI.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReLoadBattleAniEffectConfig()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReLoadBattleAniEffectConfig.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DrawCharacterController()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDrawCharacterController.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROpenXml.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShowMessage(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RShowMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateMesggeSend()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateMesggeSend.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void WriteFileLog(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RWriteFileLog_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetLog(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RAssetLog_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DebugAsset(System.Type  @mType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mType};
            var ___result = RDebugAsset_Type.Invoke(___genericsType, ___parameters);

            
        }


        public static void FileLog(System.String  @fileNameFull, System.String  @log)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileNameFull, @log};
            var ___result = RFileLog_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestSingleton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestSingleton.Invoke(___genericsType, ___parameters);

            
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
