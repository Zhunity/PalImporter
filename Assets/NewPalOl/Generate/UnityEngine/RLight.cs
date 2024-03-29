using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Light
	/// </summary>
    public partial class RLight : RMember //
    {

		/// <summary>
		/// System.Int32 m_BakedIndex
		/// </summary>
		protected RField r_m_BakedIndex;
		public virtual RField Rm_BakedIndex
		{
			get
			{
				if(r_m_BakedIndex == null)
				{
					r_m_BakedIndex = new(this, "m_BakedIndex");
					r_m_BakedIndex.SetBelong(this.instance);
				}
				return r_m_BakedIndex;
			}
		}

		/// <summary>
		/// UnityEngine.LightType type
		/// </summary>
		protected RProperty r_type;
		public virtual RProperty Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type", -1);
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// UnityEngine.LightShape shape
		/// </summary>
		protected RProperty r_shape;
		public virtual RProperty Rshape
		{
			get
			{
				if(r_shape == null)
				{
					r_shape = new(this, "shape", -1);
					r_shape.SetBelong(this.instance);
				}
				return r_shape;
			}
		}

		/// <summary>
		/// Single spotAngle
		/// </summary>
		protected RProperty r_spotAngle;
		public virtual RProperty RspotAngle
		{
			get
			{
				if(r_spotAngle == null)
				{
					r_spotAngle = new(this, "spotAngle", -1);
					r_spotAngle.SetBelong(this.instance);
				}
				return r_spotAngle;
			}
		}

		/// <summary>
		/// Single innerSpotAngle
		/// </summary>
		protected RProperty r_innerSpotAngle;
		public virtual RProperty RinnerSpotAngle
		{
			get
			{
				if(r_innerSpotAngle == null)
				{
					r_innerSpotAngle = new(this, "innerSpotAngle", -1);
					r_innerSpotAngle.SetBelong(this.instance);
				}
				return r_innerSpotAngle;
			}
		}

		/// <summary>
		/// UnityEngine.Color color
		/// </summary>
		protected RUnityEngine.RColor r_color;
		public virtual RUnityEngine.RColor Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color", -1);
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// Single colorTemperature
		/// </summary>
		protected RProperty r_colorTemperature;
		public virtual RProperty RcolorTemperature
		{
			get
			{
				if(r_colorTemperature == null)
				{
					r_colorTemperature = new(this, "colorTemperature", -1);
					r_colorTemperature.SetBelong(this.instance);
				}
				return r_colorTemperature;
			}
		}

		/// <summary>
		/// Boolean useColorTemperature
		/// </summary>
		protected RProperty r_useColorTemperature;
		public virtual RProperty RuseColorTemperature
		{
			get
			{
				if(r_useColorTemperature == null)
				{
					r_useColorTemperature = new(this, "useColorTemperature", -1);
					r_useColorTemperature.SetBelong(this.instance);
				}
				return r_useColorTemperature;
			}
		}

		/// <summary>
		/// Single intensity
		/// </summary>
		protected RProperty r_intensity;
		public virtual RProperty Rintensity
		{
			get
			{
				if(r_intensity == null)
				{
					r_intensity = new(this, "intensity", -1);
					r_intensity.SetBelong(this.instance);
				}
				return r_intensity;
			}
		}

		/// <summary>
		/// Single bounceIntensity
		/// </summary>
		protected RProperty r_bounceIntensity;
		public virtual RProperty RbounceIntensity
		{
			get
			{
				if(r_bounceIntensity == null)
				{
					r_bounceIntensity = new(this, "bounceIntensity", -1);
					r_bounceIntensity.SetBelong(this.instance);
				}
				return r_bounceIntensity;
			}
		}

		/// <summary>
		/// Boolean useBoundingSphereOverride
		/// </summary>
		protected RProperty r_useBoundingSphereOverride;
		public virtual RProperty RuseBoundingSphereOverride
		{
			get
			{
				if(r_useBoundingSphereOverride == null)
				{
					r_useBoundingSphereOverride = new(this, "useBoundingSphereOverride", -1);
					r_useBoundingSphereOverride.SetBelong(this.instance);
				}
				return r_useBoundingSphereOverride;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 boundingSphereOverride
		/// </summary>
		protected RUnityEngine.RVector4 r_boundingSphereOverride;
		public virtual RUnityEngine.RVector4 RboundingSphereOverride
		{
			get
			{
				if(r_boundingSphereOverride == null)
				{
					r_boundingSphereOverride = new(this, "boundingSphereOverride", -1);
					r_boundingSphereOverride.SetBelong(this.instance);
				}
				return r_boundingSphereOverride;
			}
		}

		/// <summary>
		/// Boolean useViewFrustumForShadowCasterCull
		/// </summary>
		protected RProperty r_useViewFrustumForShadowCasterCull;
		public virtual RProperty RuseViewFrustumForShadowCasterCull
		{
			get
			{
				if(r_useViewFrustumForShadowCasterCull == null)
				{
					r_useViewFrustumForShadowCasterCull = new(this, "useViewFrustumForShadowCasterCull", -1);
					r_useViewFrustumForShadowCasterCull.SetBelong(this.instance);
				}
				return r_useViewFrustumForShadowCasterCull;
			}
		}

		/// <summary>
		/// Int32 shadowCustomResolution
		/// </summary>
		protected RProperty r_shadowCustomResolution;
		public virtual RProperty RshadowCustomResolution
		{
			get
			{
				if(r_shadowCustomResolution == null)
				{
					r_shadowCustomResolution = new(this, "shadowCustomResolution", -1);
					r_shadowCustomResolution.SetBelong(this.instance);
				}
				return r_shadowCustomResolution;
			}
		}

		/// <summary>
		/// Single shadowBias
		/// </summary>
		protected RProperty r_shadowBias;
		public virtual RProperty RshadowBias
		{
			get
			{
				if(r_shadowBias == null)
				{
					r_shadowBias = new(this, "shadowBias", -1);
					r_shadowBias.SetBelong(this.instance);
				}
				return r_shadowBias;
			}
		}

		/// <summary>
		/// Single shadowNormalBias
		/// </summary>
		protected RProperty r_shadowNormalBias;
		public virtual RProperty RshadowNormalBias
		{
			get
			{
				if(r_shadowNormalBias == null)
				{
					r_shadowNormalBias = new(this, "shadowNormalBias", -1);
					r_shadowNormalBias.SetBelong(this.instance);
				}
				return r_shadowNormalBias;
			}
		}

		/// <summary>
		/// Single shadowNearPlane
		/// </summary>
		protected RProperty r_shadowNearPlane;
		public virtual RProperty RshadowNearPlane
		{
			get
			{
				if(r_shadowNearPlane == null)
				{
					r_shadowNearPlane = new(this, "shadowNearPlane", -1);
					r_shadowNearPlane.SetBelong(this.instance);
				}
				return r_shadowNearPlane;
			}
		}

		/// <summary>
		/// Boolean useShadowMatrixOverride
		/// </summary>
		protected RProperty r_useShadowMatrixOverride;
		public virtual RProperty RuseShadowMatrixOverride
		{
			get
			{
				if(r_useShadowMatrixOverride == null)
				{
					r_useShadowMatrixOverride = new(this, "useShadowMatrixOverride", -1);
					r_useShadowMatrixOverride.SetBelong(this.instance);
				}
				return r_useShadowMatrixOverride;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4 shadowMatrixOverride
		/// </summary>
		protected RUnityEngine.RMatrix4x4 r_shadowMatrixOverride;
		public virtual RUnityEngine.RMatrix4x4 RshadowMatrixOverride
		{
			get
			{
				if(r_shadowMatrixOverride == null)
				{
					r_shadowMatrixOverride = new(this, "shadowMatrixOverride", -1);
					r_shadowMatrixOverride.SetBelong(this.instance);
				}
				return r_shadowMatrixOverride;
			}
		}

		/// <summary>
		/// Single range
		/// </summary>
		protected RProperty r_range;
		public virtual RProperty Rrange
		{
			get
			{
				if(r_range == null)
				{
					r_range = new(this, "range", -1);
					r_range.SetBelong(this.instance);
				}
				return r_range;
			}
		}

		/// <summary>
		/// UnityEngine.Flare flare
		/// </summary>
		protected RUnityEngine.RFlare r_flare;
		public virtual RUnityEngine.RFlare Rflare
		{
			get
			{
				if(r_flare == null)
				{
					r_flare = new(this, "flare", -1);
					r_flare.SetBelong(this.instance);
				}
				return r_flare;
			}
		}

		/// <summary>
		/// UnityEngine.LightBakingOutput bakingOutput
		/// </summary>
		protected RUnityEngine.RLightBakingOutput r_bakingOutput;
		public virtual RUnityEngine.RLightBakingOutput RbakingOutput
		{
			get
			{
				if(r_bakingOutput == null)
				{
					r_bakingOutput = new(this, "bakingOutput", -1);
					r_bakingOutput.SetBelong(this.instance);
				}
				return r_bakingOutput;
			}
		}

		/// <summary>
		/// Int32 cullingMask
		/// </summary>
		protected RProperty r_cullingMask;
		public virtual RProperty RcullingMask
		{
			get
			{
				if(r_cullingMask == null)
				{
					r_cullingMask = new(this, "cullingMask", -1);
					r_cullingMask.SetBelong(this.instance);
				}
				return r_cullingMask;
			}
		}

		/// <summary>
		/// Int32 renderingLayerMask
		/// </summary>
		protected RProperty r_renderingLayerMask;
		public virtual RProperty RrenderingLayerMask
		{
			get
			{
				if(r_renderingLayerMask == null)
				{
					r_renderingLayerMask = new(this, "renderingLayerMask", -1);
					r_renderingLayerMask.SetBelong(this.instance);
				}
				return r_renderingLayerMask;
			}
		}

		/// <summary>
		/// UnityEngine.LightShadowCasterMode lightShadowCasterMode
		/// </summary>
		protected RProperty r_lightShadowCasterMode;
		public virtual RProperty RlightShadowCasterMode
		{
			get
			{
				if(r_lightShadowCasterMode == null)
				{
					r_lightShadowCasterMode = new(this, "lightShadowCasterMode", -1);
					r_lightShadowCasterMode.SetBelong(this.instance);
				}
				return r_lightShadowCasterMode;
			}
		}

		/// <summary>
		/// Single shadowRadius
		/// </summary>
		protected RProperty r_shadowRadius;
		public virtual RProperty RshadowRadius
		{
			get
			{
				if(r_shadowRadius == null)
				{
					r_shadowRadius = new(this, "shadowRadius", -1);
					r_shadowRadius.SetBelong(this.instance);
				}
				return r_shadowRadius;
			}
		}

		/// <summary>
		/// Single shadowAngle
		/// </summary>
		protected RProperty r_shadowAngle;
		public virtual RProperty RshadowAngle
		{
			get
			{
				if(r_shadowAngle == null)
				{
					r_shadowAngle = new(this, "shadowAngle", -1);
					r_shadowAngle.SetBelong(this.instance);
				}
				return r_shadowAngle;
			}
		}

		/// <summary>
		/// UnityEngine.LightShadows shadows
		/// </summary>
		protected RProperty r_shadows;
		public virtual RProperty Rshadows
		{
			get
			{
				if(r_shadows == null)
				{
					r_shadows = new(this, "shadows", -1);
					r_shadows.SetBelong(this.instance);
				}
				return r_shadows;
			}
		}

		/// <summary>
		/// Single shadowStrength
		/// </summary>
		protected RProperty r_shadowStrength;
		public virtual RProperty RshadowStrength
		{
			get
			{
				if(r_shadowStrength == null)
				{
					r_shadowStrength = new(this, "shadowStrength", -1);
					r_shadowStrength.SetBelong(this.instance);
				}
				return r_shadowStrength;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.LightShadowResolution shadowResolution
		/// </summary>
		protected RProperty r_shadowResolution;
		public virtual RProperty RshadowResolution
		{
			get
			{
				if(r_shadowResolution == null)
				{
					r_shadowResolution = new(this, "shadowResolution", -1);
					r_shadowResolution.SetBelong(this.instance);
				}
				return r_shadowResolution;
			}
		}

		/// <summary>
		/// Single shadowSoftness
		/// </summary>
		protected RProperty r_shadowSoftness;
		public virtual RProperty RshadowSoftness
		{
			get
			{
				if(r_shadowSoftness == null)
				{
					r_shadowSoftness = new(this, "shadowSoftness", -1);
					r_shadowSoftness.SetBelong(this.instance);
				}
				return r_shadowSoftness;
			}
		}

		/// <summary>
		/// Single shadowSoftnessFade
		/// </summary>
		protected RProperty r_shadowSoftnessFade;
		public virtual RProperty RshadowSoftnessFade
		{
			get
			{
				if(r_shadowSoftnessFade == null)
				{
					r_shadowSoftnessFade = new(this, "shadowSoftnessFade", -1);
					r_shadowSoftnessFade.SetBelong(this.instance);
				}
				return r_shadowSoftnessFade;
			}
		}

		/// <summary>
		/// Single[] layerShadowCullDistances
		/// </summary>
		protected RPropertyArray<RProperty> r_layerShadowCullDistances;
		public virtual RPropertyArray<RProperty> RlayerShadowCullDistances
		{
			get
			{
				if(r_layerShadowCullDistances == null)
				{
					r_layerShadowCullDistances = new(this, "layerShadowCullDistances", -1);
					r_layerShadowCullDistances.SetBelong(this.instance);
				}
				return r_layerShadowCullDistances;
			}
		}

		/// <summary>
		/// Single cookieSize
		/// </summary>
		protected RProperty r_cookieSize;
		public virtual RProperty RcookieSize
		{
			get
			{
				if(r_cookieSize == null)
				{
					r_cookieSize = new(this, "cookieSize", -1);
					r_cookieSize.SetBelong(this.instance);
				}
				return r_cookieSize;
			}
		}

		/// <summary>
		/// UnityEngine.Texture cookie
		/// </summary>
		protected RUnityEngine.RTexture r_cookie;
		public virtual RUnityEngine.RTexture Rcookie
		{
			get
			{
				if(r_cookie == null)
				{
					r_cookie = new(this, "cookie", -1);
					r_cookie.SetBelong(this.instance);
				}
				return r_cookie;
			}
		}

		/// <summary>
		/// UnityEngine.LightRenderMode renderMode
		/// </summary>
		protected RProperty r_renderMode;
		public virtual RProperty RrenderMode
		{
			get
			{
				if(r_renderMode == null)
				{
					r_renderMode = new(this, "renderMode", -1);
					r_renderMode.SetBelong(this.instance);
				}
				return r_renderMode;
			}
		}

		/// <summary>
		/// Int32 bakedIndex
		/// </summary>
		protected RProperty r_bakedIndex;
		public virtual RProperty RbakedIndex
		{
			get
			{
				if(r_bakedIndex == null)
				{
					r_bakedIndex = new(this, "bakedIndex", -1);
					r_bakedIndex.SetBelong(this.instance);
				}
				return r_bakedIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 areaSize
		/// </summary>
		protected RUnityEngine.RVector2 r_areaSize;
		public virtual RUnityEngine.RVector2 RareaSize
		{
			get
			{
				if(r_areaSize == null)
				{
					r_areaSize = new(this, "areaSize", -1);
					r_areaSize.SetBelong(this.instance);
				}
				return r_areaSize;
			}
		}

		/// <summary>
		/// UnityEngine.LightmapBakeType lightmapBakeType
		/// </summary>
		protected RProperty r_lightmapBakeType;
		public virtual RProperty RlightmapBakeType
		{
			get
			{
				if(r_lightmapBakeType == null)
				{
					r_lightmapBakeType = new(this, "lightmapBakeType", -1);
					r_lightmapBakeType.SetBelong(this.instance);
				}
				return r_lightmapBakeType;
			}
		}

		/// <summary>
		/// Int32 commandBufferCount
		/// </summary>
		protected RProperty r_commandBufferCount;
		public virtual RProperty RcommandBufferCount
		{
			get
			{
				if(r_commandBufferCount == null)
				{
					r_commandBufferCount = new(this, "commandBufferCount", -1);
					r_commandBufferCount.SetBelong(this.instance);
				}
				return r_commandBufferCount;
			}
		}

		/// <summary>
		/// Int32 pixelLightCount
		/// </summary>
		protected static RProperty r_pixelLightCount;
		public static RProperty RpixelLightCount
		{
			get
			{
				if(r_pixelLightCount == null)
				{
					r_pixelLightCount = new(typeof(UnityEngine.Light), "pixelLightCount", -1);
					r_pixelLightCount.SetBelong(null);
				}
				return r_pixelLightCount;
			}
		}

		/// <summary>
		/// Single shadowConstantBias
		/// </summary>
		protected RProperty r_shadowConstantBias;
		public virtual RProperty RshadowConstantBias
		{
			get
			{
				if(r_shadowConstantBias == null)
				{
					r_shadowConstantBias = new(this, "shadowConstantBias", -1);
					r_shadowConstantBias.SetBelong(this.instance);
				}
				return r_shadowConstantBias;
			}
		}

		/// <summary>
		/// Single shadowObjectSizeBias
		/// </summary>
		protected RProperty r_shadowObjectSizeBias;
		public virtual RProperty RshadowObjectSizeBias
		{
			get
			{
				if(r_shadowObjectSizeBias == null)
				{
					r_shadowObjectSizeBias = new(this, "shadowObjectSizeBias", -1);
					r_shadowObjectSizeBias.SetBelong(this.instance);
				}
				return r_shadowObjectSizeBias;
			}
		}

		/// <summary>
		/// Boolean attenuate
		/// </summary>
		protected RProperty r_attenuate;
		public virtual RProperty Rattenuate
		{
			get
			{
				if(r_attenuate == null)
				{
					r_attenuate = new(this, "attenuate", -1);
					r_attenuate.SetBelong(this.instance);
				}
				return r_attenuate;
			}
		}

		/// <summary>
		/// UnityEngine.LightmappingMode lightmappingMode
		/// </summary>
		protected RProperty r_lightmappingMode;
		public virtual RProperty RlightmappingMode
		{
			get
			{
				if(r_lightmappingMode == null)
				{
					r_lightmappingMode = new(this, "lightmappingMode", -1);
					r_lightmappingMode.SetBelong(this.instance);
				}
				return r_lightmappingMode;
			}
		}

		/// <summary>
		/// Boolean isBaked
		/// </summary>
		protected RProperty r_isBaked;
		public virtual RProperty RisBaked
		{
			get
			{
				if(r_isBaked == null)
				{
					r_isBaked = new(this, "isBaked", -1);
					r_isBaked.SetBelong(this.instance);
				}
				return r_isBaked;
			}
		}

		/// <summary>
		/// Boolean alreadyLightmapped
		/// </summary>
		protected RProperty r_alreadyLightmapped;
		public virtual RProperty RalreadyLightmapped
		{
			get
			{
				if(r_alreadyLightmapped == null)
				{
					r_alreadyLightmapped = new(this, "alreadyLightmapped", -1);
					r_alreadyLightmapped.SetBelong(this.instance);
				}
				return r_alreadyLightmapped;
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
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
			}
		}

		/// <summary>
		/// Void SetLightDirty()
		/// </summary>
		protected RMethod r_RSetLightDirty;
		public virtual RMethod RSetLightDirty
		{
			get
			{
				if(r_RSetLightDirty == null)
				{
					r_RSetLightDirty = new(this, "SetLightDirty", 0);
					r_RSetLightDirty.SetBelong(this.instance);
				}
				return r_RSetLightDirty;
			}
		}

		/// <summary>
		/// Void AddCommandBuffer(UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_RAddCommandBuffer_LightEvent_CommandBuffer;
		public virtual RMethod RAddCommandBuffer_LightEvent_CommandBuffer
		{
			get
			{
				if(r_RAddCommandBuffer_LightEvent_CommandBuffer == null)
				{
					r_RAddCommandBuffer_LightEvent_CommandBuffer = new(this, "AddCommandBuffer", 0, typeof(UnityEngine.Rendering.LightEvent), typeof(UnityEngine.Rendering.CommandBuffer));
					r_RAddCommandBuffer_LightEvent_CommandBuffer.SetBelong(this.instance);
				}
				return r_RAddCommandBuffer_LightEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// Void AddCommandBuffer(UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ShadowMapPass)
		/// </summary>
		protected RMethod r_RAddCommandBuffer_LightEvent_CommandBuffer_ShadowMapPass;
		public virtual RMethod RAddCommandBuffer_LightEvent_CommandBuffer_ShadowMapPass
		{
			get
			{
				if(r_RAddCommandBuffer_LightEvent_CommandBuffer_ShadowMapPass == null)
				{
					r_RAddCommandBuffer_LightEvent_CommandBuffer_ShadowMapPass = new(this, "AddCommandBuffer", 0, typeof(UnityEngine.Rendering.LightEvent), typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.ShadowMapPass));
					r_RAddCommandBuffer_LightEvent_CommandBuffer_ShadowMapPass.SetBelong(this.instance);
				}
				return r_RAddCommandBuffer_LightEvent_CommandBuffer_ShadowMapPass;
			}
		}

		/// <summary>
		/// Void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ComputeQueueType)
		/// </summary>
		protected RMethod r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ComputeQueueType;
		public virtual RMethod RAddCommandBufferAsync_LightEvent_CommandBuffer_ComputeQueueType
		{
			get
			{
				if(r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ComputeQueueType == null)
				{
					r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ComputeQueueType = new(this, "AddCommandBufferAsync", 0, typeof(UnityEngine.Rendering.LightEvent), typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.ComputeQueueType));
					r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ComputeQueueType.SetBelong(this.instance);
				}
				return r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ComputeQueueType;
			}
		}

		/// <summary>
		/// Void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ShadowMapPass, UnityEngine.Rendering.ComputeQueueType)
		/// </summary>
		protected RMethod r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType;
		public virtual RMethod RAddCommandBufferAsync_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType
		{
			get
			{
				if(r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType == null)
				{
					r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType = new(this, "AddCommandBufferAsync", 0, typeof(UnityEngine.Rendering.LightEvent), typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.ShadowMapPass), typeof(UnityEngine.Rendering.ComputeQueueType));
					r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType.SetBelong(this.instance);
				}
				return r_RAddCommandBufferAsync_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType;
			}
		}

		/// <summary>
		/// Void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent, UnityEngine.Rendering.CommandBuffer)
		/// </summary>
		protected RMethod r_RRemoveCommandBuffer_LightEvent_CommandBuffer;
		public virtual RMethod RRemoveCommandBuffer_LightEvent_CommandBuffer
		{
			get
			{
				if(r_RRemoveCommandBuffer_LightEvent_CommandBuffer == null)
				{
					r_RRemoveCommandBuffer_LightEvent_CommandBuffer = new(this, "RemoveCommandBuffer", 0, typeof(UnityEngine.Rendering.LightEvent), typeof(UnityEngine.Rendering.CommandBuffer));
					r_RRemoveCommandBuffer_LightEvent_CommandBuffer.SetBelong(this.instance);
				}
				return r_RRemoveCommandBuffer_LightEvent_CommandBuffer;
			}
		}

		/// <summary>
		/// Void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent)
		/// </summary>
		protected RMethod r_RRemoveCommandBuffers_LightEvent;
		public virtual RMethod RRemoveCommandBuffers_LightEvent
		{
			get
			{
				if(r_RRemoveCommandBuffers_LightEvent == null)
				{
					r_RRemoveCommandBuffers_LightEvent = new(this, "RemoveCommandBuffers", 0, typeof(UnityEngine.Rendering.LightEvent));
					r_RRemoveCommandBuffers_LightEvent.SetBelong(this.instance);
				}
				return r_RRemoveCommandBuffers_LightEvent;
			}
		}

		/// <summary>
		/// Void RemoveAllCommandBuffers()
		/// </summary>
		protected RMethod r_RRemoveAllCommandBuffers;
		public virtual RMethod RRemoveAllCommandBuffers
		{
			get
			{
				if(r_RRemoveAllCommandBuffers == null)
				{
					r_RRemoveAllCommandBuffers = new(this, "RemoveAllCommandBuffers", 0);
					r_RRemoveAllCommandBuffers.SetBelong(this.instance);
				}
				return r_RRemoveAllCommandBuffers;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.LightEvent)
		/// </summary>
		protected RMethod r_RGetCommandBuffers_LightEvent;
		public virtual RMethod RGetCommandBuffers_LightEvent
		{
			get
			{
				if(r_RGetCommandBuffers_LightEvent == null)
				{
					r_RGetCommandBuffers_LightEvent = new(this, "GetCommandBuffers", 0, typeof(UnityEngine.Rendering.LightEvent));
					r_RGetCommandBuffers_LightEvent.SetBelong(this.instance);
				}
				return r_RGetCommandBuffers_LightEvent;
			}
		}

		/// <summary>
		/// UnityEngine.Light[] GetLights(UnityEngine.LightType, Int32)
		/// </summary>
		protected static RMethod r_RGetLights_LightType_Int32;
		public static RMethod RGetLights_LightType_Int32
		{
			get
			{
				if(r_RGetLights_LightType_Int32 == null)
				{
					r_RGetLights_LightType_Int32 = new(typeof(UnityEngine.Light), "GetLights", 0, typeof(UnityEngine.LightType), typeof(System.Int32));
					r_RGetLights_LightType_Int32.SetBelong(null);
				}
				return r_RGetLights_LightType_Int32;
			}
		}

		/// <summary>
		/// Void get_color_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Rget_color_Injected_Out_Color;
		public virtual RMethod Rget_color_Injected_Out_Color
		{
			get
			{
				if(r_Rget_color_Injected_Out_Color == null)
				{
					r_Rget_color_Injected_Out_Color = new(this, "get_color_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Rget_color_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_Rget_color_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_color_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Rset_color_Injected_Ref_Color;
		public virtual RMethod Rset_color_Injected_Ref_Color
		{
			get
			{
				if(r_Rset_color_Injected_Ref_Color == null)
				{
					r_Rset_color_Injected_Ref_Color = new(this, "set_color_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Rset_color_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_Rset_color_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void get_boundingSphereOverride_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_boundingSphereOverride_Injected_Out_Vector4;
		public virtual RMethod Rget_boundingSphereOverride_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_boundingSphereOverride_Injected_Out_Vector4 == null)
				{
					r_Rget_boundingSphereOverride_Injected_Out_Vector4 = new(this, "get_boundingSphereOverride_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_boundingSphereOverride_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_boundingSphereOverride_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void set_boundingSphereOverride_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rset_boundingSphereOverride_Injected_Ref_Vector4;
		public virtual RMethod Rset_boundingSphereOverride_Injected_Ref_Vector4
		{
			get
			{
				if(r_Rset_boundingSphereOverride_Injected_Ref_Vector4 == null)
				{
					r_Rset_boundingSphereOverride_Injected_Ref_Vector4 = new(this, "set_boundingSphereOverride_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rset_boundingSphereOverride_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_Rset_boundingSphereOverride_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void get_shadowMatrixOverride_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Rget_shadowMatrixOverride_Injected_Out_Matrix4x4;
		public virtual RMethod Rget_shadowMatrixOverride_Injected_Out_Matrix4x4
		{
			get
			{
				if(r_Rget_shadowMatrixOverride_Injected_Out_Matrix4x4 == null)
				{
					r_Rget_shadowMatrixOverride_Injected_Out_Matrix4x4 = new(this, "get_shadowMatrixOverride_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Rget_shadowMatrixOverride_Injected_Out_Matrix4x4.SetBelong(this.instance);
				}
				return r_Rget_shadowMatrixOverride_Injected_Out_Matrix4x4;
			}
		}

		/// <summary>
		/// Void set_shadowMatrixOverride_Injected(UnityEngine.Matrix4x4 ByRef)
		/// </summary>
		protected RMethod r_Rset_shadowMatrixOverride_Injected_Ref_Matrix4x4;
		public virtual RMethod Rset_shadowMatrixOverride_Injected_Ref_Matrix4x4
		{
			get
			{
				if(r_Rset_shadowMatrixOverride_Injected_Ref_Matrix4x4 == null)
				{
					r_Rset_shadowMatrixOverride_Injected_Ref_Matrix4x4 = new(this, "set_shadowMatrixOverride_Injected", 0, typeof(UnityEngine.Matrix4x4).MakeByRefType());
					r_Rset_shadowMatrixOverride_Injected_Ref_Matrix4x4.SetBelong(this.instance);
				}
				return r_Rset_shadowMatrixOverride_Injected_Ref_Matrix4x4;
			}
		}

		/// <summary>
		/// Void get_bakingOutput_Injected(UnityEngine.LightBakingOutput ByRef)
		/// </summary>
		protected RMethod r_Rget_bakingOutput_Injected_Out_LightBakingOutput;
		public virtual RMethod Rget_bakingOutput_Injected_Out_LightBakingOutput
		{
			get
			{
				if(r_Rget_bakingOutput_Injected_Out_LightBakingOutput == null)
				{
					r_Rget_bakingOutput_Injected_Out_LightBakingOutput = new(this, "get_bakingOutput_Injected", 0, typeof(UnityEngine.LightBakingOutput).MakeByRefType());
					r_Rget_bakingOutput_Injected_Out_LightBakingOutput.SetBelong(this.instance);
				}
				return r_Rget_bakingOutput_Injected_Out_LightBakingOutput;
			}
		}

		/// <summary>
		/// Void set_bakingOutput_Injected(UnityEngine.LightBakingOutput ByRef)
		/// </summary>
		protected RMethod r_Rset_bakingOutput_Injected_Ref_LightBakingOutput;
		public virtual RMethod Rset_bakingOutput_Injected_Ref_LightBakingOutput
		{
			get
			{
				if(r_Rset_bakingOutput_Injected_Ref_LightBakingOutput == null)
				{
					r_Rset_bakingOutput_Injected_Ref_LightBakingOutput = new(this, "set_bakingOutput_Injected", 0, typeof(UnityEngine.LightBakingOutput).MakeByRefType());
					r_Rset_bakingOutput_Injected_Ref_LightBakingOutput.SetBelong(this.instance);
				}
				return r_Rset_bakingOutput_Injected_Ref_LightBakingOutput;
			}
		}

		/// <summary>
		/// Void get_areaSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_areaSize_Injected_Out_Vector2;
		public virtual RMethod Rget_areaSize_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_areaSize_Injected_Out_Vector2 == null)
				{
					r_Rget_areaSize_Injected_Out_Vector2 = new(this, "get_areaSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_areaSize_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_areaSize_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_areaSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_areaSize_Injected_Ref_Vector2;
		public virtual RMethod Rset_areaSize_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_areaSize_Injected_Ref_Vector2 == null)
				{
					r_Rset_areaSize_Injected_Ref_Vector2 = new(this, "set_areaSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_areaSize_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_areaSize_Injected_Ref_Vector2;
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


        public RLight() : base("UnityEngine.Light")
        {
        }

        public RLight(System.Object instance) : base("UnityEngine.Light")
		{
            SetInstance(instance);
		}

        public RLight(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLight(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetLightDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetLightDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBuffer(UnityEngine.Rendering.LightEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RAddCommandBuffer_LightEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBuffer(UnityEngine.Rendering.LightEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer, UnityEngine.Rendering.ShadowMapPass  @shadowPassMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer, @shadowPassMask};
            var ___result = RAddCommandBuffer_LightEvent_CommandBuffer_ShadowMapPass.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer, UnityEngine.Rendering.ComputeQueueType  @queueType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer, @queueType};
            var ___result = RAddCommandBufferAsync_LightEvent_CommandBuffer_ComputeQueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer, UnityEngine.Rendering.ShadowMapPass  @shadowPassMask, UnityEngine.Rendering.ComputeQueueType  @queueType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer, @shadowPassMask, @queueType};
            var ___result = RAddCommandBufferAsync_LightEvent_CommandBuffer_ShadowMapPass_ComputeQueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent  @evt, UnityEngine.Rendering.CommandBuffer  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt, @buffer};
            var ___result = RRemoveCommandBuffer_LightEvent_CommandBuffer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RRemoveCommandBuffers_LightEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveAllCommandBuffers()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemoveAllCommandBuffers.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.LightEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RGetCommandBuffers_LightEvent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Rendering.CommandBuffer[])___result;
        }


        public static UnityEngine.Light[] GetLights(UnityEngine.LightType  @type, System.Int32  @layer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @layer};
            var ___result = RGetLights_LightType_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Light[])___result;
        }


        public virtual void get_color_Injected(out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_color_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_color_Injected(ref UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_color_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void get_boundingSphereOverride_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_boundingSphereOverride_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void set_boundingSphereOverride_Injected(ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_boundingSphereOverride_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_shadowMatrixOverride_Injected(out UnityEngine.Matrix4x4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_shadowMatrixOverride_Injected_Out_Matrix4x4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void set_shadowMatrixOverride_Injected(ref UnityEngine.Matrix4x4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_shadowMatrixOverride_Injected_Ref_Matrix4x4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Matrix4x4)___parameters[0];

            
        }


        public virtual void get_bakingOutput_Injected(out UnityEngine.LightBakingOutput  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_bakingOutput_Injected_Out_LightBakingOutput.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.LightBakingOutput)___parameters[0];

            
        }


        public virtual void set_bakingOutput_Injected(ref UnityEngine.LightBakingOutput  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_bakingOutput_Injected_Ref_LightBakingOutput.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.LightBakingOutput)___parameters[0];

            
        }


        public virtual void get_areaSize_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_areaSize_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_areaSize_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_areaSize_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
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
