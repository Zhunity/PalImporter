using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// HighlightableObject
	/// </summary>
    public partial class RHighlightableObject : RMember //
    {

		/// <summary>
		/// System.Single doublePI
		/// </summary>
		protected static RField r_doublePI;
		public static RField RdoublePI
		{
			get
			{
				if(r_doublePI == null)
				{
					r_doublePI = new(typeof(HighlightableObject), "doublePI");
					r_doublePI.SetBelong(null);
				}
				return r_doublePI;
			}
		}

		/// <summary>
		/// System.Int32 highlightingLayer
		/// </summary>
		protected static RField r_highlightingLayer;
		public static RField RhighlightingLayer
		{
			get
			{
				if(r_highlightingLayer == null)
				{
					r_highlightingLayer = new(typeof(HighlightableObject), "highlightingLayer");
					r_highlightingLayer.SetBelong(null);
				}
				return r_highlightingLayer;
			}
		}

		/// <summary>
		/// System.Single constantOnSpeed
		/// </summary>
		protected static RField r_constantOnSpeed;
		public static RField RconstantOnSpeed
		{
			get
			{
				if(r_constantOnSpeed == null)
				{
					r_constantOnSpeed = new(typeof(HighlightableObject), "constantOnSpeed");
					r_constantOnSpeed.SetBelong(null);
				}
				return r_constantOnSpeed;
			}
		}

		/// <summary>
		/// System.Single constantOffSpeed
		/// </summary>
		protected static RField r_constantOffSpeed;
		public static RField RconstantOffSpeed
		{
			get
			{
				if(r_constantOffSpeed == null)
				{
					r_constantOffSpeed = new(typeof(HighlightableObject), "constantOffSpeed");
					r_constantOffSpeed.SetBelong(null);
				}
				return r_constantOffSpeed;
			}
		}

		/// <summary>
		/// System.Single transparentCutoff
		/// </summary>
		protected static RField r_transparentCutoff;
		public static RField RtransparentCutoff
		{
			get
			{
				if(r_transparentCutoff == null)
				{
					r_transparentCutoff = new(typeof(HighlightableObject), "transparentCutoff");
					r_transparentCutoff.SetBelong(null);
				}
				return r_transparentCutoff;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[HighlightableObject+HighlightingRendererCache] highlightableRenderers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RHighlightableObject.RHighlightingRendererCache> r_highlightableRenderers;
		public virtual RSystem.RCollections.RGeneric.RList<RHighlightableObject.RHighlightingRendererCache> RhighlightableRenderers
		{
			get
			{
				if(r_highlightableRenderers == null)
				{
					r_highlightableRenderers = new(this, "highlightableRenderers");
					r_highlightableRenderers.SetBelong(this.instance);
				}
				return r_highlightableRenderers;
			}
		}

		/// <summary>
		/// System.Int32[] layersCache
		/// </summary>
		protected RFieldArray<RField> r_layersCache;
		public virtual RFieldArray<RField> RlayersCache
		{
			get
			{
				if(r_layersCache == null)
				{
					r_layersCache = new(this, "layersCache");
					r_layersCache.SetBelong(this.instance);
				}
				return r_layersCache;
			}
		}

		/// <summary>
		/// System.Boolean materialsIsDirty
		/// </summary>
		protected RField r_materialsIsDirty;
		public virtual RField RmaterialsIsDirty
		{
			get
			{
				if(r_materialsIsDirty == null)
				{
					r_materialsIsDirty = new(this, "materialsIsDirty");
					r_materialsIsDirty.SetBelong(this.instance);
				}
				return r_materialsIsDirty;
			}
		}

		/// <summary>
		/// System.Boolean currentState
		/// </summary>
		protected RField r_currentState;
		public virtual RField RcurrentState
		{
			get
			{
				if(r_currentState == null)
				{
					r_currentState = new(this, "currentState");
					r_currentState.SetBelong(this.instance);
				}
				return r_currentState;
			}
		}

		/// <summary>
		/// UnityEngine.Color currentColor
		/// </summary>
		protected RUnityEngine.RColor r_currentColor;
		public virtual RUnityEngine.RColor RcurrentColor
		{
			get
			{
				if(r_currentColor == null)
				{
					r_currentColor = new(this, "currentColor");
					r_currentColor.SetBelong(this.instance);
				}
				return r_currentColor;
			}
		}

		/// <summary>
		/// System.Boolean transitionActive
		/// </summary>
		protected RField r_transitionActive;
		public virtual RField RtransitionActive
		{
			get
			{
				if(r_transitionActive == null)
				{
					r_transitionActive = new(this, "transitionActive");
					r_transitionActive.SetBelong(this.instance);
				}
				return r_transitionActive;
			}
		}

		/// <summary>
		/// System.Single transitionValue
		/// </summary>
		protected RField r_transitionValue;
		public virtual RField RtransitionValue
		{
			get
			{
				if(r_transitionValue == null)
				{
					r_transitionValue = new(this, "transitionValue");
					r_transitionValue.SetBelong(this.instance);
				}
				return r_transitionValue;
			}
		}

		/// <summary>
		/// System.Single flashingFreq
		/// </summary>
		protected RField r_flashingFreq;
		public virtual RField RflashingFreq
		{
			get
			{
				if(r_flashingFreq == null)
				{
					r_flashingFreq = new(this, "flashingFreq");
					r_flashingFreq.SetBelong(this.instance);
				}
				return r_flashingFreq;
			}
		}

		/// <summary>
		/// System.Boolean once
		/// </summary>
		protected RField r_once;
		public virtual RField Ronce
		{
			get
			{
				if(r_once == null)
				{
					r_once = new(this, "once");
					r_once.SetBelong(this.instance);
				}
				return r_once;
			}
		}

		/// <summary>
		/// UnityEngine.Color onceColor
		/// </summary>
		protected RUnityEngine.RColor r_onceColor;
		public virtual RUnityEngine.RColor RonceColor
		{
			get
			{
				if(r_onceColor == null)
				{
					r_onceColor = new(this, "onceColor");
					r_onceColor.SetBelong(this.instance);
				}
				return r_onceColor;
			}
		}

		/// <summary>
		/// System.Boolean flashing
		/// </summary>
		protected RField r_flashing;
		public virtual RField Rflashing
		{
			get
			{
				if(r_flashing == null)
				{
					r_flashing = new(this, "flashing");
					r_flashing.SetBelong(this.instance);
				}
				return r_flashing;
			}
		}

		/// <summary>
		/// UnityEngine.Color flashingColorMin
		/// </summary>
		protected RUnityEngine.RColor r_flashingColorMin;
		public virtual RUnityEngine.RColor RflashingColorMin
		{
			get
			{
				if(r_flashingColorMin == null)
				{
					r_flashingColorMin = new(this, "flashingColorMin");
					r_flashingColorMin.SetBelong(this.instance);
				}
				return r_flashingColorMin;
			}
		}

		/// <summary>
		/// UnityEngine.Color flashingColorMax
		/// </summary>
		protected RUnityEngine.RColor r_flashingColorMax;
		public virtual RUnityEngine.RColor RflashingColorMax
		{
			get
			{
				if(r_flashingColorMax == null)
				{
					r_flashingColorMax = new(this, "flashingColorMax");
					r_flashingColorMax.SetBelong(this.instance);
				}
				return r_flashingColorMax;
			}
		}

		/// <summary>
		/// System.Boolean constantly
		/// </summary>
		protected RField r_constantly;
		public virtual RField Rconstantly
		{
			get
			{
				if(r_constantly == null)
				{
					r_constantly = new(this, "constantly");
					r_constantly.SetBelong(this.instance);
				}
				return r_constantly;
			}
		}

		/// <summary>
		/// UnityEngine.Color constantColor
		/// </summary>
		protected RUnityEngine.RColor r_constantColor;
		public virtual RUnityEngine.RColor RconstantColor
		{
			get
			{
				if(r_constantColor == null)
				{
					r_constantColor = new(this, "constantColor");
					r_constantColor.SetBelong(this.instance);
				}
				return r_constantColor;
			}
		}

		/// <summary>
		/// System.Boolean occluder
		/// </summary>
		protected RField r_occluder;
		public virtual RField Roccluder
		{
			get
			{
				if(r_occluder == null)
				{
					r_occluder = new(this, "occluder");
					r_occluder.SetBelong(this.instance);
				}
				return r_occluder;
			}
		}

		/// <summary>
		/// System.Boolean zWrite
		/// </summary>
		protected RField r_zWrite;
		public virtual RField RzWrite
		{
			get
			{
				if(r_zWrite == null)
				{
					r_zWrite = new(this, "zWrite");
					r_zWrite.SetBelong(this.instance);
				}
				return r_zWrite;
			}
		}

		/// <summary>
		/// UnityEngine.Color occluderColor
		/// </summary>
		protected RUnityEngine.RColor r_occluderColor;
		public virtual RUnityEngine.RColor RoccluderColor
		{
			get
			{
				if(r_occluderColor == null)
				{
					r_occluderColor = new(this, "occluderColor");
					r_occluderColor.SetBelong(this.instance);
				}
				return r_occluderColor;
			}
		}

		/// <summary>
		/// UnityEngine.Material _opaqueMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r__opaqueMaterial;
		public virtual RUnityEngine.RMaterial R_opaqueMaterial
		{
			get
			{
				if(r__opaqueMaterial == null)
				{
					r__opaqueMaterial = new(this, "_opaqueMaterial");
					r__opaqueMaterial.SetBelong(this.instance);
				}
				return r__opaqueMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material _opaqueZMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r__opaqueZMaterial;
		public virtual RUnityEngine.RMaterial R_opaqueZMaterial
		{
			get
			{
				if(r__opaqueZMaterial == null)
				{
					r__opaqueZMaterial = new(this, "_opaqueZMaterial");
					r__opaqueZMaterial.SetBelong(this.instance);
				}
				return r__opaqueZMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Shader _opaqueShader
		/// </summary>
		protected static RUnityEngine.RShader r__opaqueShader;
		public static RUnityEngine.RShader R_opaqueShader
		{
			get
			{
				if(r__opaqueShader == null)
				{
					r__opaqueShader = new(typeof(HighlightableObject), "_opaqueShader");
					r__opaqueShader.SetBelong(null);
				}
				return r__opaqueShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader _transparentShader
		/// </summary>
		protected static RUnityEngine.RShader r__transparentShader;
		public static RUnityEngine.RShader R_transparentShader
		{
			get
			{
				if(r__transparentShader == null)
				{
					r__transparentShader = new(typeof(HighlightableObject), "_transparentShader");
					r__transparentShader.SetBelong(null);
				}
				return r__transparentShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader _opaqueZShader
		/// </summary>
		protected static RUnityEngine.RShader r__opaqueZShader;
		public static RUnityEngine.RShader R_opaqueZShader
		{
			get
			{
				if(r__opaqueZShader == null)
				{
					r__opaqueZShader = new(typeof(HighlightableObject), "_opaqueZShader");
					r__opaqueZShader.SetBelong(null);
				}
				return r__opaqueZShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader _transparentZShader
		/// </summary>
		protected static RUnityEngine.RShader r__transparentZShader;
		public static RUnityEngine.RShader R_transparentZShader
		{
			get
			{
				if(r__transparentZShader == null)
				{
					r__transparentZShader = new(typeof(HighlightableObject), "_transparentZShader");
					r__transparentZShader.SetBelong(null);
				}
				return r__transparentZShader;
			}
		}

		/// <summary>
		/// UnityEngine.Material highlightingMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_highlightingMaterial;
		public virtual RUnityEngine.RMaterial RhighlightingMaterial
		{
			get
			{
				if(r_highlightingMaterial == null)
				{
					r_highlightingMaterial = new(this, "highlightingMaterial", -1);
					r_highlightingMaterial.SetBelong(this.instance);
				}
				return r_highlightingMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material opaqueMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_opaqueMaterial;
		public virtual RUnityEngine.RMaterial RopaqueMaterial
		{
			get
			{
				if(r_opaqueMaterial == null)
				{
					r_opaqueMaterial = new(this, "opaqueMaterial", -1);
					r_opaqueMaterial.SetBelong(this.instance);
				}
				return r_opaqueMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Material opaqueZMaterial
		/// </summary>
		protected RUnityEngine.RMaterial r_opaqueZMaterial;
		public virtual RUnityEngine.RMaterial RopaqueZMaterial
		{
			get
			{
				if(r_opaqueZMaterial == null)
				{
					r_opaqueZMaterial = new(this, "opaqueZMaterial", -1);
					r_opaqueZMaterial.SetBelong(this.instance);
				}
				return r_opaqueZMaterial;
			}
		}

		/// <summary>
		/// UnityEngine.Shader opaqueShader
		/// </summary>
		protected static RUnityEngine.RShader r_opaqueShader;
		public static RUnityEngine.RShader RopaqueShader
		{
			get
			{
				if(r_opaqueShader == null)
				{
					r_opaqueShader = new(typeof(HighlightableObject), "opaqueShader", -1);
					r_opaqueShader.SetBelong(null);
				}
				return r_opaqueShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader transparentShader
		/// </summary>
		protected static RUnityEngine.RShader r_transparentShader;
		public static RUnityEngine.RShader RtransparentShader
		{
			get
			{
				if(r_transparentShader == null)
				{
					r_transparentShader = new(typeof(HighlightableObject), "transparentShader", -1);
					r_transparentShader.SetBelong(null);
				}
				return r_transparentShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader opaqueZShader
		/// </summary>
		protected static RUnityEngine.RShader r_opaqueZShader;
		public static RUnityEngine.RShader RopaqueZShader
		{
			get
			{
				if(r_opaqueZShader == null)
				{
					r_opaqueZShader = new(typeof(HighlightableObject), "opaqueZShader", -1);
					r_opaqueZShader.SetBelong(null);
				}
				return r_opaqueZShader;
			}
		}

		/// <summary>
		/// UnityEngine.Shader transparentZShader
		/// </summary>
		protected static RUnityEngine.RShader r_transparentZShader;
		public static RUnityEngine.RShader RtransparentZShader
		{
			get
			{
				if(r_transparentZShader == null)
				{
					r_transparentZShader = new(typeof(HighlightableObject), "transparentZShader", -1);
					r_transparentZShader.SetBelong(null);
				}
				return r_transparentZShader;
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
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_ROnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_ROnEnable == null)
				{
					r_ROnEnable = new(this, "OnEnable", 0);
					r_ROnEnable.SetBelong(this.instance);
				}
				return r_ROnEnable;
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
		/// Void ReinitMaterials()
		/// </summary>
		protected RMethod r_RReinitMaterials;
		public virtual RMethod RReinitMaterials
		{
			get
			{
				if(r_RReinitMaterials == null)
				{
					r_RReinitMaterials = new(this, "ReinitMaterials", 0);
					r_RReinitMaterials.SetBelong(this.instance);
				}
				return r_RReinitMaterials;
			}
		}

		/// <summary>
		/// Void RestoreMaterials()
		/// </summary>
		protected RMethod r_RRestoreMaterials;
		public virtual RMethod RRestoreMaterials
		{
			get
			{
				if(r_RRestoreMaterials == null)
				{
					r_RRestoreMaterials = new(this, "RestoreMaterials", 0);
					r_RRestoreMaterials.SetBelong(this.instance);
				}
				return r_RRestoreMaterials;
			}
		}

		/// <summary>
		/// Void OnParams(UnityEngine.Color)
		/// </summary>
		protected RMethod r_ROnParams_Color;
		public virtual RMethod ROnParams_Color
		{
			get
			{
				if(r_ROnParams_Color == null)
				{
					r_ROnParams_Color = new(this, "OnParams", 0, typeof(UnityEngine.Color));
					r_ROnParams_Color.SetBelong(this.instance);
				}
				return r_ROnParams_Color;
			}
		}

		/// <summary>
		/// Void On()
		/// </summary>
		protected RMethod r_ROn;
		public virtual RMethod ROn
		{
			get
			{
				if(r_ROn == null)
				{
					r_ROn = new(this, "On", 0);
					r_ROn.SetBelong(this.instance);
				}
				return r_ROn;
			}
		}

		/// <summary>
		/// Void On(UnityEngine.Color)
		/// </summary>
		protected RMethod r_ROn_Color;
		public virtual RMethod ROn_Color
		{
			get
			{
				if(r_ROn_Color == null)
				{
					r_ROn_Color = new(this, "On", 0, typeof(UnityEngine.Color));
					r_ROn_Color.SetBelong(this.instance);
				}
				return r_ROn_Color;
			}
		}

		/// <summary>
		/// Void FlashingParams(UnityEngine.Color, UnityEngine.Color, Single)
		/// </summary>
		protected RMethod r_RFlashingParams_Color_Color_Single;
		public virtual RMethod RFlashingParams_Color_Color_Single
		{
			get
			{
				if(r_RFlashingParams_Color_Color_Single == null)
				{
					r_RFlashingParams_Color_Color_Single = new(this, "FlashingParams", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Single));
					r_RFlashingParams_Color_Color_Single.SetBelong(this.instance);
				}
				return r_RFlashingParams_Color_Color_Single;
			}
		}

		/// <summary>
		/// Void FlashingOn()
		/// </summary>
		protected RMethod r_RFlashingOn;
		public virtual RMethod RFlashingOn
		{
			get
			{
				if(r_RFlashingOn == null)
				{
					r_RFlashingOn = new(this, "FlashingOn", 0);
					r_RFlashingOn.SetBelong(this.instance);
				}
				return r_RFlashingOn;
			}
		}

		/// <summary>
		/// Void FlashingOn(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected RMethod r_RFlashingOn_Color_Color;
		public virtual RMethod RFlashingOn_Color_Color
		{
			get
			{
				if(r_RFlashingOn_Color_Color == null)
				{
					r_RFlashingOn_Color_Color = new(this, "FlashingOn", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_RFlashingOn_Color_Color.SetBelong(this.instance);
				}
				return r_RFlashingOn_Color_Color;
			}
		}

		/// <summary>
		/// Void FlashingOn(UnityEngine.Color, UnityEngine.Color, Single)
		/// </summary>
		protected RMethod r_RFlashingOn_Color_Color_Single;
		public virtual RMethod RFlashingOn_Color_Color_Single
		{
			get
			{
				if(r_RFlashingOn_Color_Color_Single == null)
				{
					r_RFlashingOn_Color_Color_Single = new(this, "FlashingOn", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color), typeof(System.Single));
					r_RFlashingOn_Color_Color_Single.SetBelong(this.instance);
				}
				return r_RFlashingOn_Color_Color_Single;
			}
		}

		/// <summary>
		/// Void FlashingOn(Single)
		/// </summary>
		protected RMethod r_RFlashingOn_Single;
		public virtual RMethod RFlashingOn_Single
		{
			get
			{
				if(r_RFlashingOn_Single == null)
				{
					r_RFlashingOn_Single = new(this, "FlashingOn", 0, typeof(System.Single));
					r_RFlashingOn_Single.SetBelong(this.instance);
				}
				return r_RFlashingOn_Single;
			}
		}

		/// <summary>
		/// Void FlashingOff()
		/// </summary>
		protected RMethod r_RFlashingOff;
		public virtual RMethod RFlashingOff
		{
			get
			{
				if(r_RFlashingOff == null)
				{
					r_RFlashingOff = new(this, "FlashingOff", 0);
					r_RFlashingOff.SetBelong(this.instance);
				}
				return r_RFlashingOff;
			}
		}

		/// <summary>
		/// Void FlashingSwitch()
		/// </summary>
		protected RMethod r_RFlashingSwitch;
		public virtual RMethod RFlashingSwitch
		{
			get
			{
				if(r_RFlashingSwitch == null)
				{
					r_RFlashingSwitch = new(this, "FlashingSwitch", 0);
					r_RFlashingSwitch.SetBelong(this.instance);
				}
				return r_RFlashingSwitch;
			}
		}

		/// <summary>
		/// Void ConstantParams(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RConstantParams_Color;
		public virtual RMethod RConstantParams_Color
		{
			get
			{
				if(r_RConstantParams_Color == null)
				{
					r_RConstantParams_Color = new(this, "ConstantParams", 0, typeof(UnityEngine.Color));
					r_RConstantParams_Color.SetBelong(this.instance);
				}
				return r_RConstantParams_Color;
			}
		}

		/// <summary>
		/// Void ConstantOn()
		/// </summary>
		protected RMethod r_RConstantOn;
		public virtual RMethod RConstantOn
		{
			get
			{
				if(r_RConstantOn == null)
				{
					r_RConstantOn = new(this, "ConstantOn", 0);
					r_RConstantOn.SetBelong(this.instance);
				}
				return r_RConstantOn;
			}
		}

		/// <summary>
		/// Void ConstantOn(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RConstantOn_Color;
		public virtual RMethod RConstantOn_Color
		{
			get
			{
				if(r_RConstantOn_Color == null)
				{
					r_RConstantOn_Color = new(this, "ConstantOn", 0, typeof(UnityEngine.Color));
					r_RConstantOn_Color.SetBelong(this.instance);
				}
				return r_RConstantOn_Color;
			}
		}

		/// <summary>
		/// Void ConstantOff()
		/// </summary>
		protected RMethod r_RConstantOff;
		public virtual RMethod RConstantOff
		{
			get
			{
				if(r_RConstantOff == null)
				{
					r_RConstantOff = new(this, "ConstantOff", 0);
					r_RConstantOff.SetBelong(this.instance);
				}
				return r_RConstantOff;
			}
		}

		/// <summary>
		/// Void ConstantSwitch()
		/// </summary>
		protected RMethod r_RConstantSwitch;
		public virtual RMethod RConstantSwitch
		{
			get
			{
				if(r_RConstantSwitch == null)
				{
					r_RConstantSwitch = new(this, "ConstantSwitch", 0);
					r_RConstantSwitch.SetBelong(this.instance);
				}
				return r_RConstantSwitch;
			}
		}

		/// <summary>
		/// Void ConstantOnImmediate()
		/// </summary>
		protected RMethod r_RConstantOnImmediate;
		public virtual RMethod RConstantOnImmediate
		{
			get
			{
				if(r_RConstantOnImmediate == null)
				{
					r_RConstantOnImmediate = new(this, "ConstantOnImmediate", 0);
					r_RConstantOnImmediate.SetBelong(this.instance);
				}
				return r_RConstantOnImmediate;
			}
		}

		/// <summary>
		/// Void ConstantOnImmediate(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RConstantOnImmediate_Color;
		public virtual RMethod RConstantOnImmediate_Color
		{
			get
			{
				if(r_RConstantOnImmediate_Color == null)
				{
					r_RConstantOnImmediate_Color = new(this, "ConstantOnImmediate", 0, typeof(UnityEngine.Color));
					r_RConstantOnImmediate_Color.SetBelong(this.instance);
				}
				return r_RConstantOnImmediate_Color;
			}
		}

		/// <summary>
		/// Void ConstantOffImmediate()
		/// </summary>
		protected RMethod r_RConstantOffImmediate;
		public virtual RMethod RConstantOffImmediate
		{
			get
			{
				if(r_RConstantOffImmediate == null)
				{
					r_RConstantOffImmediate = new(this, "ConstantOffImmediate", 0);
					r_RConstantOffImmediate.SetBelong(this.instance);
				}
				return r_RConstantOffImmediate;
			}
		}

		/// <summary>
		/// Void ConstantSwitchImmediate()
		/// </summary>
		protected RMethod r_RConstantSwitchImmediate;
		public virtual RMethod RConstantSwitchImmediate
		{
			get
			{
				if(r_RConstantSwitchImmediate == null)
				{
					r_RConstantSwitchImmediate = new(this, "ConstantSwitchImmediate", 0);
					r_RConstantSwitchImmediate.SetBelong(this.instance);
				}
				return r_RConstantSwitchImmediate;
			}
		}

		/// <summary>
		/// Void OccluderOn()
		/// </summary>
		protected RMethod r_ROccluderOn;
		public virtual RMethod ROccluderOn
		{
			get
			{
				if(r_ROccluderOn == null)
				{
					r_ROccluderOn = new(this, "OccluderOn", 0);
					r_ROccluderOn.SetBelong(this.instance);
				}
				return r_ROccluderOn;
			}
		}

		/// <summary>
		/// Void OccluderOff()
		/// </summary>
		protected RMethod r_ROccluderOff;
		public virtual RMethod ROccluderOff
		{
			get
			{
				if(r_ROccluderOff == null)
				{
					r_ROccluderOff = new(this, "OccluderOff", 0);
					r_ROccluderOff.SetBelong(this.instance);
				}
				return r_ROccluderOff;
			}
		}

		/// <summary>
		/// Void OccluderSwitch()
		/// </summary>
		protected RMethod r_ROccluderSwitch;
		public virtual RMethod ROccluderSwitch
		{
			get
			{
				if(r_ROccluderSwitch == null)
				{
					r_ROccluderSwitch = new(this, "OccluderSwitch", 0);
					r_ROccluderSwitch.SetBelong(this.instance);
				}
				return r_ROccluderSwitch;
			}
		}

		/// <summary>
		/// Void Off()
		/// </summary>
		protected RMethod r_ROff;
		public virtual RMethod ROff
		{
			get
			{
				if(r_ROff == null)
				{
					r_ROff = new(this, "Off", 0);
					r_ROff.SetBelong(this.instance);
				}
				return r_ROff;
			}
		}

		/// <summary>
		/// Void Die()
		/// </summary>
		protected RMethod r_RDie;
		public virtual RMethod RDie
		{
			get
			{
				if(r_RDie == null)
				{
					r_RDie = new(this, "Die", 0);
					r_RDie.SetBelong(this.instance);
				}
				return r_RDie;
			}
		}

		/// <summary>
		/// Void InitMaterials(Boolean)
		/// </summary>
		protected RMethod r_RInitMaterials_Boolean;
		public virtual RMethod RInitMaterials_Boolean
		{
			get
			{
				if(r_RInitMaterials_Boolean == null)
				{
					r_RInitMaterials_Boolean = new(this, "InitMaterials", 0, typeof(System.Boolean));
					r_RInitMaterials_Boolean.SetBelong(this.instance);
				}
				return r_RInitMaterials_Boolean;
			}
		}

		/// <summary>
		/// Void CacheRenderers(UnityEngine.Renderer[])
		/// </summary>
		protected RMethod r_RCacheRenderers_RendererArray;
		public virtual RMethod RCacheRenderers_RendererArray
		{
			get
			{
				if(r_RCacheRenderers_RendererArray == null)
				{
					r_RCacheRenderers_RendererArray = new(this, "CacheRenderers", 0, typeof(UnityEngine.Renderer).MakeArrayType());
					r_RCacheRenderers_RendererArray.SetBelong(this.instance);
				}
				return r_RCacheRenderers_RendererArray;
			}
		}

		/// <summary>
		/// Void SetColor(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetColor_Color;
		public virtual RMethod RSetColor_Color
		{
			get
			{
				if(r_RSetColor_Color == null)
				{
					r_RSetColor_Color = new(this, "SetColor", 0, typeof(UnityEngine.Color));
					r_RSetColor_Color.SetBelong(this.instance);
				}
				return r_RSetColor_Color;
			}
		}

		/// <summary>
		/// Void UpdateColors()
		/// </summary>
		protected RMethod r_RUpdateColors;
		public virtual RMethod RUpdateColors
		{
			get
			{
				if(r_RUpdateColors == null)
				{
					r_RUpdateColors = new(this, "UpdateColors", 0);
					r_RUpdateColors.SetBelong(this.instance);
				}
				return r_RUpdateColors;
			}
		}

		/// <summary>
		/// Void PerformTransition()
		/// </summary>
		protected RMethod r_RPerformTransition;
		public virtual RMethod RPerformTransition
		{
			get
			{
				if(r_RPerformTransition == null)
				{
					r_RPerformTransition = new(this, "PerformTransition", 0);
					r_RPerformTransition.SetBelong(this.instance);
				}
				return r_RPerformTransition;
			}
		}

		/// <summary>
		/// Void UpdateEventHandler(Boolean, Boolean)
		/// </summary>
		protected RMethod r_RUpdateEventHandler_Boolean_Boolean;
		public virtual RMethod RUpdateEventHandler_Boolean_Boolean
		{
			get
			{
				if(r_RUpdateEventHandler_Boolean_Boolean == null)
				{
					r_RUpdateEventHandler_Boolean_Boolean = new(this, "UpdateEventHandler", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_RUpdateEventHandler_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RUpdateEventHandler_Boolean_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator EndOfFrame()
		/// </summary>
		protected RMethod r_REndOfFrame;
		public virtual RMethod REndOfFrame
		{
			get
			{
				if(r_REndOfFrame == null)
				{
					r_REndOfFrame = new(this, "EndOfFrame", 0);
					r_REndOfFrame.SetBelong(this.instance);
				}
				return r_REndOfFrame;
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


        public RHighlightableObject() : base("HighlightableObject")
        {
        }

        public RHighlightableObject(System.Object instance) : base("HighlightableObject")
		{
            SetInstance(instance);
		}

        public RHighlightableObject(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHighlightableObject(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDisable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDisable.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReinitMaterials()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReinitMaterials.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestoreMaterials()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestoreMaterials.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnParams(UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = ROnParams_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void On()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROn.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void On(UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = ROn_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlashingParams(UnityEngine.Color  @color1, UnityEngine.Color  @color2, System.Single  @freq)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color1, @color2, @freq};
            var ___result = RFlashingParams_Color_Color_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlashingOn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlashingOn.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlashingOn(UnityEngine.Color  @color1, UnityEngine.Color  @color2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color1, @color2};
            var ___result = RFlashingOn_Color_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlashingOn(UnityEngine.Color  @color1, UnityEngine.Color  @color2, System.Single  @freq)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color1, @color2, @freq};
            var ___result = RFlashingOn_Color_Color_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlashingOn(System.Single  @freq)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@freq};
            var ___result = RFlashingOn_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlashingOff()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlashingOff.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FlashingSwitch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlashingSwitch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantParams(UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RConstantParams_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantOn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstantOn.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantOn(UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RConstantOn_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantOff()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstantOff.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantSwitch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstantSwitch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantOnImmediate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstantOnImmediate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantOnImmediate(UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RConstantOnImmediate_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantOffImmediate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstantOffImmediate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ConstantSwitchImmediate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RConstantSwitchImmediate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OccluderOn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROccluderOn.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OccluderOff()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROccluderOff.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OccluderSwitch()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROccluderSwitch.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Off()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROff.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Die()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDie.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitMaterials(System.Boolean  @writeDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writeDepth};
            var ___result = RInitMaterials_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CacheRenderers(UnityEngine.Renderer[]  @renderers)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderers};
            var ___result = RCacheRenderers_RendererArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColor(UnityEngine.Color  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RSetColor_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateColors()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateColors.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PerformTransition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPerformTransition.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateEventHandler(System.Boolean  @trigger, System.Boolean  @writeDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@trigger, @writeDepth};
            var ___result = RUpdateEventHandler_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator EndOfFrame()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndOfFrame.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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
