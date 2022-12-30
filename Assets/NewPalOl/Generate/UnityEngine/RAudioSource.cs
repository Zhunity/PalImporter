using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AudioSource
	/// </summary>
    public partial class RAudioSource : RMember //
    {

		/// <summary>
		/// Single panLevel
		/// </summary>
		protected RProperty r_panLevel;
		public virtual RProperty RpanLevel
		{
			get
			{
				if(r_panLevel == null)
				{
					r_panLevel = new(this, "panLevel", -1);
					r_panLevel.SetBelong(this.instance);
				}
				return r_panLevel;
			}
		}

		/// <summary>
		/// Single pan
		/// </summary>
		protected RProperty r_pan;
		public virtual RProperty Rpan
		{
			get
			{
				if(r_pan == null)
				{
					r_pan = new(this, "pan", -1);
					r_pan.SetBelong(this.instance);
				}
				return r_pan;
			}
		}

		/// <summary>
		/// Single volume
		/// </summary>
		protected RProperty r_volume;
		public virtual RProperty Rvolume
		{
			get
			{
				if(r_volume == null)
				{
					r_volume = new(this, "volume", -1);
					r_volume.SetBelong(this.instance);
				}
				return r_volume;
			}
		}

		/// <summary>
		/// Single pitch
		/// </summary>
		protected RProperty r_pitch;
		public virtual RProperty Rpitch
		{
			get
			{
				if(r_pitch == null)
				{
					r_pitch = new(this, "pitch", -1);
					r_pitch.SetBelong(this.instance);
				}
				return r_pitch;
			}
		}

		/// <summary>
		/// Single time
		/// </summary>
		protected RProperty r_time;
		public virtual RProperty Rtime
		{
			get
			{
				if(r_time == null)
				{
					r_time = new(this, "time", -1);
					r_time.SetBelong(this.instance);
				}
				return r_time;
			}
		}

		/// <summary>
		/// Int32 timeSamples
		/// </summary>
		protected RProperty r_timeSamples;
		public virtual RProperty RtimeSamples
		{
			get
			{
				if(r_timeSamples == null)
				{
					r_timeSamples = new(this, "timeSamples", -1);
					r_timeSamples.SetBelong(this.instance);
				}
				return r_timeSamples;
			}
		}

		/// <summary>
		/// UnityEngine.AudioClip clip
		/// </summary>
		protected RUnityEngine.RAudioClip r_clip;
		public virtual RUnityEngine.RAudioClip Rclip
		{
			get
			{
				if(r_clip == null)
				{
					r_clip = new(this, "clip", -1);
					r_clip.SetBelong(this.instance);
				}
				return r_clip;
			}
		}

		/// <summary>
		/// UnityEngine.Audio.AudioMixerGroup outputAudioMixerGroup
		/// </summary>
		protected RUnityEngine.RAudio.RAudioMixerGroup r_outputAudioMixerGroup;
		public virtual RUnityEngine.RAudio.RAudioMixerGroup RoutputAudioMixerGroup
		{
			get
			{
				if(r_outputAudioMixerGroup == null)
				{
					r_outputAudioMixerGroup = new(this, "outputAudioMixerGroup", -1);
					r_outputAudioMixerGroup.SetBelong(this.instance);
				}
				return r_outputAudioMixerGroup;
			}
		}

		/// <summary>
		/// UnityEngine.GamepadSpeakerOutputType gamepadSpeakerOutputType
		/// </summary>
		protected RProperty r_gamepadSpeakerOutputType;
		public virtual RProperty RgamepadSpeakerOutputType
		{
			get
			{
				if(r_gamepadSpeakerOutputType == null)
				{
					r_gamepadSpeakerOutputType = new(this, "gamepadSpeakerOutputType", -1);
					r_gamepadSpeakerOutputType.SetBelong(this.instance);
				}
				return r_gamepadSpeakerOutputType;
			}
		}

		/// <summary>
		/// Boolean isPlaying
		/// </summary>
		protected RProperty r_isPlaying;
		public virtual RProperty RisPlaying
		{
			get
			{
				if(r_isPlaying == null)
				{
					r_isPlaying = new(this, "isPlaying", -1);
					r_isPlaying.SetBelong(this.instance);
				}
				return r_isPlaying;
			}
		}

		/// <summary>
		/// Boolean isVirtual
		/// </summary>
		protected RProperty r_isVirtual;
		public virtual RProperty RisVirtual
		{
			get
			{
				if(r_isVirtual == null)
				{
					r_isVirtual = new(this, "isVirtual", -1);
					r_isVirtual.SetBelong(this.instance);
				}
				return r_isVirtual;
			}
		}

		/// <summary>
		/// Boolean loop
		/// </summary>
		protected RProperty r_loop;
		public virtual RProperty Rloop
		{
			get
			{
				if(r_loop == null)
				{
					r_loop = new(this, "loop", -1);
					r_loop.SetBelong(this.instance);
				}
				return r_loop;
			}
		}

		/// <summary>
		/// Boolean ignoreListenerVolume
		/// </summary>
		protected RProperty r_ignoreListenerVolume;
		public virtual RProperty RignoreListenerVolume
		{
			get
			{
				if(r_ignoreListenerVolume == null)
				{
					r_ignoreListenerVolume = new(this, "ignoreListenerVolume", -1);
					r_ignoreListenerVolume.SetBelong(this.instance);
				}
				return r_ignoreListenerVolume;
			}
		}

		/// <summary>
		/// Boolean playOnAwake
		/// </summary>
		protected RProperty r_playOnAwake;
		public virtual RProperty RplayOnAwake
		{
			get
			{
				if(r_playOnAwake == null)
				{
					r_playOnAwake = new(this, "playOnAwake", -1);
					r_playOnAwake.SetBelong(this.instance);
				}
				return r_playOnAwake;
			}
		}

		/// <summary>
		/// Boolean ignoreListenerPause
		/// </summary>
		protected RProperty r_ignoreListenerPause;
		public virtual RProperty RignoreListenerPause
		{
			get
			{
				if(r_ignoreListenerPause == null)
				{
					r_ignoreListenerPause = new(this, "ignoreListenerPause", -1);
					r_ignoreListenerPause.SetBelong(this.instance);
				}
				return r_ignoreListenerPause;
			}
		}

		/// <summary>
		/// UnityEngine.AudioVelocityUpdateMode velocityUpdateMode
		/// </summary>
		protected RProperty r_velocityUpdateMode;
		public virtual RProperty RvelocityUpdateMode
		{
			get
			{
				if(r_velocityUpdateMode == null)
				{
					r_velocityUpdateMode = new(this, "velocityUpdateMode", -1);
					r_velocityUpdateMode.SetBelong(this.instance);
				}
				return r_velocityUpdateMode;
			}
		}

		/// <summary>
		/// Single panStereo
		/// </summary>
		protected RProperty r_panStereo;
		public virtual RProperty RpanStereo
		{
			get
			{
				if(r_panStereo == null)
				{
					r_panStereo = new(this, "panStereo", -1);
					r_panStereo.SetBelong(this.instance);
				}
				return r_panStereo;
			}
		}

		/// <summary>
		/// Single spatialBlend
		/// </summary>
		protected RProperty r_spatialBlend;
		public virtual RProperty RspatialBlend
		{
			get
			{
				if(r_spatialBlend == null)
				{
					r_spatialBlend = new(this, "spatialBlend", -1);
					r_spatialBlend.SetBelong(this.instance);
				}
				return r_spatialBlend;
			}
		}

		/// <summary>
		/// Boolean spatialize
		/// </summary>
		protected RProperty r_spatialize;
		public virtual RProperty Rspatialize
		{
			get
			{
				if(r_spatialize == null)
				{
					r_spatialize = new(this, "spatialize", -1);
					r_spatialize.SetBelong(this.instance);
				}
				return r_spatialize;
			}
		}

		/// <summary>
		/// Boolean spatializePostEffects
		/// </summary>
		protected RProperty r_spatializePostEffects;
		public virtual RProperty RspatializePostEffects
		{
			get
			{
				if(r_spatializePostEffects == null)
				{
					r_spatializePostEffects = new(this, "spatializePostEffects", -1);
					r_spatializePostEffects.SetBelong(this.instance);
				}
				return r_spatializePostEffects;
			}
		}

		/// <summary>
		/// Single reverbZoneMix
		/// </summary>
		protected RProperty r_reverbZoneMix;
		public virtual RProperty RreverbZoneMix
		{
			get
			{
				if(r_reverbZoneMix == null)
				{
					r_reverbZoneMix = new(this, "reverbZoneMix", -1);
					r_reverbZoneMix.SetBelong(this.instance);
				}
				return r_reverbZoneMix;
			}
		}

		/// <summary>
		/// Boolean bypassEffects
		/// </summary>
		protected RProperty r_bypassEffects;
		public virtual RProperty RbypassEffects
		{
			get
			{
				if(r_bypassEffects == null)
				{
					r_bypassEffects = new(this, "bypassEffects", -1);
					r_bypassEffects.SetBelong(this.instance);
				}
				return r_bypassEffects;
			}
		}

		/// <summary>
		/// Boolean bypassListenerEffects
		/// </summary>
		protected RProperty r_bypassListenerEffects;
		public virtual RProperty RbypassListenerEffects
		{
			get
			{
				if(r_bypassListenerEffects == null)
				{
					r_bypassListenerEffects = new(this, "bypassListenerEffects", -1);
					r_bypassListenerEffects.SetBelong(this.instance);
				}
				return r_bypassListenerEffects;
			}
		}

		/// <summary>
		/// Boolean bypassReverbZones
		/// </summary>
		protected RProperty r_bypassReverbZones;
		public virtual RProperty RbypassReverbZones
		{
			get
			{
				if(r_bypassReverbZones == null)
				{
					r_bypassReverbZones = new(this, "bypassReverbZones", -1);
					r_bypassReverbZones.SetBelong(this.instance);
				}
				return r_bypassReverbZones;
			}
		}

		/// <summary>
		/// Single dopplerLevel
		/// </summary>
		protected RProperty r_dopplerLevel;
		public virtual RProperty RdopplerLevel
		{
			get
			{
				if(r_dopplerLevel == null)
				{
					r_dopplerLevel = new(this, "dopplerLevel", -1);
					r_dopplerLevel.SetBelong(this.instance);
				}
				return r_dopplerLevel;
			}
		}

		/// <summary>
		/// Single spread
		/// </summary>
		protected RProperty r_spread;
		public virtual RProperty Rspread
		{
			get
			{
				if(r_spread == null)
				{
					r_spread = new(this, "spread", -1);
					r_spread.SetBelong(this.instance);
				}
				return r_spread;
			}
		}

		/// <summary>
		/// Int32 priority
		/// </summary>
		protected RProperty r_priority;
		public virtual RProperty Rpriority
		{
			get
			{
				if(r_priority == null)
				{
					r_priority = new(this, "priority", -1);
					r_priority.SetBelong(this.instance);
				}
				return r_priority;
			}
		}

		/// <summary>
		/// Boolean mute
		/// </summary>
		protected RProperty r_mute;
		public virtual RProperty Rmute
		{
			get
			{
				if(r_mute == null)
				{
					r_mute = new(this, "mute", -1);
					r_mute.SetBelong(this.instance);
				}
				return r_mute;
			}
		}

		/// <summary>
		/// Single minDistance
		/// </summary>
		protected RProperty r_minDistance;
		public virtual RProperty RminDistance
		{
			get
			{
				if(r_minDistance == null)
				{
					r_minDistance = new(this, "minDistance", -1);
					r_minDistance.SetBelong(this.instance);
				}
				return r_minDistance;
			}
		}

		/// <summary>
		/// Single maxDistance
		/// </summary>
		protected RProperty r_maxDistance;
		public virtual RProperty RmaxDistance
		{
			get
			{
				if(r_maxDistance == null)
				{
					r_maxDistance = new(this, "maxDistance", -1);
					r_maxDistance.SetBelong(this.instance);
				}
				return r_maxDistance;
			}
		}

		/// <summary>
		/// UnityEngine.AudioRolloffMode rolloffMode
		/// </summary>
		protected RProperty r_rolloffMode;
		public virtual RProperty RrolloffMode
		{
			get
			{
				if(r_rolloffMode == null)
				{
					r_rolloffMode = new(this, "rolloffMode", -1);
					r_rolloffMode.SetBelong(this.instance);
				}
				return r_rolloffMode;
			}
		}

		/// <summary>
		/// Single minVolume
		/// </summary>
		protected RProperty r_minVolume;
		public virtual RProperty RminVolume
		{
			get
			{
				if(r_minVolume == null)
				{
					r_minVolume = new(this, "minVolume", -1);
					r_minVolume.SetBelong(this.instance);
				}
				return r_minVolume;
			}
		}

		/// <summary>
		/// Single maxVolume
		/// </summary>
		protected RProperty r_maxVolume;
		public virtual RProperty RmaxVolume
		{
			get
			{
				if(r_maxVolume == null)
				{
					r_maxVolume = new(this, "maxVolume", -1);
					r_maxVolume.SetBelong(this.instance);
				}
				return r_maxVolume;
			}
		}

		/// <summary>
		/// Single rolloffFactor
		/// </summary>
		protected RProperty r_rolloffFactor;
		public virtual RProperty RrolloffFactor
		{
			get
			{
				if(r_rolloffFactor == null)
				{
					r_rolloffFactor = new(this, "rolloffFactor", -1);
					r_rolloffFactor.SetBelong(this.instance);
				}
				return r_rolloffFactor;
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
		/// Single GetPitch(UnityEngine.AudioSource)
		/// </summary>
		protected static RMethod r_RGetPitch_AudioSource;
		public static RMethod RGetPitch_AudioSource
		{
			get
			{
				if(r_RGetPitch_AudioSource == null)
				{
					r_RGetPitch_AudioSource = new(typeof(UnityEngine.AudioSource), "GetPitch", 0, typeof(UnityEngine.AudioSource));
					r_RGetPitch_AudioSource.SetBelong(null);
				}
				return r_RGetPitch_AudioSource;
			}
		}

		/// <summary>
		/// Void SetPitch(UnityEngine.AudioSource, Single)
		/// </summary>
		protected static RMethod r_RSetPitch_AudioSource_Single;
		public static RMethod RSetPitch_AudioSource_Single
		{
			get
			{
				if(r_RSetPitch_AudioSource_Single == null)
				{
					r_RSetPitch_AudioSource_Single = new(typeof(UnityEngine.AudioSource), "SetPitch", 0, typeof(UnityEngine.AudioSource), typeof(System.Single));
					r_RSetPitch_AudioSource_Single.SetBelong(null);
				}
				return r_RSetPitch_AudioSource_Single;
			}
		}

		/// <summary>
		/// Void PlayHelper(UnityEngine.AudioSource, UInt64)
		/// </summary>
		protected static RMethod r_RPlayHelper_AudioSource_UInt64;
		public static RMethod RPlayHelper_AudioSource_UInt64
		{
			get
			{
				if(r_RPlayHelper_AudioSource_UInt64 == null)
				{
					r_RPlayHelper_AudioSource_UInt64 = new(typeof(UnityEngine.AudioSource), "PlayHelper", 0, typeof(UnityEngine.AudioSource), typeof(System.UInt64));
					r_RPlayHelper_AudioSource_UInt64.SetBelong(null);
				}
				return r_RPlayHelper_AudioSource_UInt64;
			}
		}

		/// <summary>
		/// Void Play(Double)
		/// </summary>
		protected RMethod r_RPlay_Double;
		public virtual RMethod RPlay_Double
		{
			get
			{
				if(r_RPlay_Double == null)
				{
					r_RPlay_Double = new(this, "Play", 0, typeof(System.Double));
					r_RPlay_Double.SetBelong(this.instance);
				}
				return r_RPlay_Double;
			}
		}

		/// <summary>
		/// Void PlayOneShotHelper(UnityEngine.AudioSource, UnityEngine.AudioClip, Single)
		/// </summary>
		protected static RMethod r_RPlayOneShotHelper_AudioSource_AudioClip_Single;
		public static RMethod RPlayOneShotHelper_AudioSource_AudioClip_Single
		{
			get
			{
				if(r_RPlayOneShotHelper_AudioSource_AudioClip_Single == null)
				{
					r_RPlayOneShotHelper_AudioSource_AudioClip_Single = new(typeof(UnityEngine.AudioSource), "PlayOneShotHelper", 0, typeof(UnityEngine.AudioSource), typeof(UnityEngine.AudioClip), typeof(System.Single));
					r_RPlayOneShotHelper_AudioSource_AudioClip_Single.SetBelong(null);
				}
				return r_RPlayOneShotHelper_AudioSource_AudioClip_Single;
			}
		}

		/// <summary>
		/// Void Stop(Boolean)
		/// </summary>
		protected RMethod r_RStop_Boolean;
		public virtual RMethod RStop_Boolean
		{
			get
			{
				if(r_RStop_Boolean == null)
				{
					r_RStop_Boolean = new(this, "Stop", 0, typeof(System.Boolean));
					r_RStop_Boolean.SetBelong(this.instance);
				}
				return r_RStop_Boolean;
			}
		}

		/// <summary>
		/// Void SetCustomCurveHelper(UnityEngine.AudioSource, UnityEngine.AudioSourceCurveType, UnityEngine.AnimationCurve)
		/// </summary>
		protected static RMethod r_RSetCustomCurveHelper_AudioSource_AudioSourceCurveType_AnimationCurve;
		public static RMethod RSetCustomCurveHelper_AudioSource_AudioSourceCurveType_AnimationCurve
		{
			get
			{
				if(r_RSetCustomCurveHelper_AudioSource_AudioSourceCurveType_AnimationCurve == null)
				{
					r_RSetCustomCurveHelper_AudioSource_AudioSourceCurveType_AnimationCurve = new(typeof(UnityEngine.AudioSource), "SetCustomCurveHelper", 0, typeof(UnityEngine.AudioSource), typeof(UnityEngine.AudioSourceCurveType), typeof(UnityEngine.AnimationCurve));
					r_RSetCustomCurveHelper_AudioSource_AudioSourceCurveType_AnimationCurve.SetBelong(null);
				}
				return r_RSetCustomCurveHelper_AudioSource_AudioSourceCurveType_AnimationCurve;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve GetCustomCurveHelper(UnityEngine.AudioSource, UnityEngine.AudioSourceCurveType)
		/// </summary>
		protected static RMethod r_RGetCustomCurveHelper_AudioSource_AudioSourceCurveType;
		public static RMethod RGetCustomCurveHelper_AudioSource_AudioSourceCurveType
		{
			get
			{
				if(r_RGetCustomCurveHelper_AudioSource_AudioSourceCurveType == null)
				{
					r_RGetCustomCurveHelper_AudioSource_AudioSourceCurveType = new(typeof(UnityEngine.AudioSource), "GetCustomCurveHelper", 0, typeof(UnityEngine.AudioSource), typeof(UnityEngine.AudioSourceCurveType));
					r_RGetCustomCurveHelper_AudioSource_AudioSourceCurveType.SetBelong(null);
				}
				return r_RGetCustomCurveHelper_AudioSource_AudioSourceCurveType;
			}
		}

		/// <summary>
		/// Void GetOutputDataHelper(UnityEngine.AudioSource, Single[], Int32)
		/// </summary>
		protected static RMethod r_RGetOutputDataHelper_AudioSource_SingleArray_Int32;
		public static RMethod RGetOutputDataHelper_AudioSource_SingleArray_Int32
		{
			get
			{
				if(r_RGetOutputDataHelper_AudioSource_SingleArray_Int32 == null)
				{
					r_RGetOutputDataHelper_AudioSource_SingleArray_Int32 = new(typeof(UnityEngine.AudioSource), "GetOutputDataHelper", 0, typeof(UnityEngine.AudioSource), typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_RGetOutputDataHelper_AudioSource_SingleArray_Int32.SetBelong(null);
				}
				return r_RGetOutputDataHelper_AudioSource_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Void GetSpectrumDataHelper(UnityEngine.AudioSource, Single[], Int32, UnityEngine.FFTWindow)
		/// </summary>
		protected static RMethod r_RGetSpectrumDataHelper_AudioSource_SingleArray_Int32_FFTWindow;
		public static RMethod RGetSpectrumDataHelper_AudioSource_SingleArray_Int32_FFTWindow
		{
			get
			{
				if(r_RGetSpectrumDataHelper_AudioSource_SingleArray_Int32_FFTWindow == null)
				{
					r_RGetSpectrumDataHelper_AudioSource_SingleArray_Int32_FFTWindow = new(typeof(UnityEngine.AudioSource), "GetSpectrumDataHelper", 0, typeof(UnityEngine.AudioSource), typeof(System.Single).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.FFTWindow));
					r_RGetSpectrumDataHelper_AudioSource_SingleArray_Int32_FFTWindow.SetBelong(null);
				}
				return r_RGetSpectrumDataHelper_AudioSource_SingleArray_Int32_FFTWindow;
			}
		}

		/// <summary>
		/// Boolean PlayOnGamepad(Int32)
		/// </summary>
		protected RMethod r_RPlayOnGamepad_Int32;
		public virtual RMethod RPlayOnGamepad_Int32
		{
			get
			{
				if(r_RPlayOnGamepad_Int32 == null)
				{
					r_RPlayOnGamepad_Int32 = new(this, "PlayOnGamepad", 0, typeof(System.Int32));
					r_RPlayOnGamepad_Int32.SetBelong(this.instance);
				}
				return r_RPlayOnGamepad_Int32;
			}
		}

		/// <summary>
		/// Boolean DisableGamepadOutput()
		/// </summary>
		protected RMethod r_RDisableGamepadOutput;
		public virtual RMethod RDisableGamepadOutput
		{
			get
			{
				if(r_RDisableGamepadOutput == null)
				{
					r_RDisableGamepadOutput = new(this, "DisableGamepadOutput", 0);
					r_RDisableGamepadOutput.SetBelong(this.instance);
				}
				return r_RDisableGamepadOutput;
			}
		}

		/// <summary>
		/// Boolean SetGamepadSpeakerMixLevel(Int32, Int32)
		/// </summary>
		protected RMethod r_RSetGamepadSpeakerMixLevel_Int32_Int32;
		public virtual RMethod RSetGamepadSpeakerMixLevel_Int32_Int32
		{
			get
			{
				if(r_RSetGamepadSpeakerMixLevel_Int32_Int32 == null)
				{
					r_RSetGamepadSpeakerMixLevel_Int32_Int32 = new(this, "SetGamepadSpeakerMixLevel", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSetGamepadSpeakerMixLevel_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSetGamepadSpeakerMixLevel_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean SetGamepadSpeakerMixLevelDefault(Int32)
		/// </summary>
		protected RMethod r_RSetGamepadSpeakerMixLevelDefault_Int32;
		public virtual RMethod RSetGamepadSpeakerMixLevelDefault_Int32
		{
			get
			{
				if(r_RSetGamepadSpeakerMixLevelDefault_Int32 == null)
				{
					r_RSetGamepadSpeakerMixLevelDefault_Int32 = new(this, "SetGamepadSpeakerMixLevelDefault", 0, typeof(System.Int32));
					r_RSetGamepadSpeakerMixLevelDefault_Int32.SetBelong(this.instance);
				}
				return r_RSetGamepadSpeakerMixLevelDefault_Int32;
			}
		}

		/// <summary>
		/// Boolean SetGamepadSpeakerRestrictedAudio(Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetGamepadSpeakerRestrictedAudio_Int32_Boolean;
		public virtual RMethod RSetGamepadSpeakerRestrictedAudio_Int32_Boolean
		{
			get
			{
				if(r_RSetGamepadSpeakerRestrictedAudio_Int32_Boolean == null)
				{
					r_RSetGamepadSpeakerRestrictedAudio_Int32_Boolean = new(this, "SetGamepadSpeakerRestrictedAudio", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RSetGamepadSpeakerRestrictedAudio_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetGamepadSpeakerRestrictedAudio_Int32_Boolean;
			}
		}

		/// <summary>
		/// Boolean GamepadSpeakerSupportsOutputType(UnityEngine.GamepadSpeakerOutputType)
		/// </summary>
		protected static RMethod r_RGamepadSpeakerSupportsOutputType_GamepadSpeakerOutputType;
		public static RMethod RGamepadSpeakerSupportsOutputType_GamepadSpeakerOutputType
		{
			get
			{
				if(r_RGamepadSpeakerSupportsOutputType_GamepadSpeakerOutputType == null)
				{
					r_RGamepadSpeakerSupportsOutputType_GamepadSpeakerOutputType = new(typeof(UnityEngine.AudioSource), "GamepadSpeakerSupportsOutputType", 0, typeof(UnityEngine.GamepadSpeakerOutputType));
					r_RGamepadSpeakerSupportsOutputType_GamepadSpeakerOutputType.SetBelong(null);
				}
				return r_RGamepadSpeakerSupportsOutputType_GamepadSpeakerOutputType;
			}
		}

		/// <summary>
		/// Void Play()
		/// </summary>
		protected RMethod r_RPlay;
		public virtual RMethod RPlay
		{
			get
			{
				if(r_RPlay == null)
				{
					r_RPlay = new(this, "Play", 0);
					r_RPlay.SetBelong(this.instance);
				}
				return r_RPlay;
			}
		}

		/// <summary>
		/// Void Play(UInt64)
		/// </summary>
		protected RMethod r_RPlay_UInt64;
		public virtual RMethod RPlay_UInt64
		{
			get
			{
				if(r_RPlay_UInt64 == null)
				{
					r_RPlay_UInt64 = new(this, "Play", 0, typeof(System.UInt64));
					r_RPlay_UInt64.SetBelong(this.instance);
				}
				return r_RPlay_UInt64;
			}
		}

		/// <summary>
		/// Void PlayDelayed(Single)
		/// </summary>
		protected RMethod r_RPlayDelayed_Single;
		public virtual RMethod RPlayDelayed_Single
		{
			get
			{
				if(r_RPlayDelayed_Single == null)
				{
					r_RPlayDelayed_Single = new(this, "PlayDelayed", 0, typeof(System.Single));
					r_RPlayDelayed_Single.SetBelong(this.instance);
				}
				return r_RPlayDelayed_Single;
			}
		}

		/// <summary>
		/// Void PlayScheduled(Double)
		/// </summary>
		protected RMethod r_RPlayScheduled_Double;
		public virtual RMethod RPlayScheduled_Double
		{
			get
			{
				if(r_RPlayScheduled_Double == null)
				{
					r_RPlayScheduled_Double = new(this, "PlayScheduled", 0, typeof(System.Double));
					r_RPlayScheduled_Double.SetBelong(this.instance);
				}
				return r_RPlayScheduled_Double;
			}
		}

		/// <summary>
		/// Void PlayOneShot(UnityEngine.AudioClip)
		/// </summary>
		protected RMethod r_RPlayOneShot_AudioClip;
		public virtual RMethod RPlayOneShot_AudioClip
		{
			get
			{
				if(r_RPlayOneShot_AudioClip == null)
				{
					r_RPlayOneShot_AudioClip = new(this, "PlayOneShot", 0, typeof(UnityEngine.AudioClip));
					r_RPlayOneShot_AudioClip.SetBelong(this.instance);
				}
				return r_RPlayOneShot_AudioClip;
			}
		}

		/// <summary>
		/// Void PlayOneShot(UnityEngine.AudioClip, Single)
		/// </summary>
		protected RMethod r_RPlayOneShot_AudioClip_Single;
		public virtual RMethod RPlayOneShot_AudioClip_Single
		{
			get
			{
				if(r_RPlayOneShot_AudioClip_Single == null)
				{
					r_RPlayOneShot_AudioClip_Single = new(this, "PlayOneShot", 0, typeof(UnityEngine.AudioClip), typeof(System.Single));
					r_RPlayOneShot_AudioClip_Single.SetBelong(this.instance);
				}
				return r_RPlayOneShot_AudioClip_Single;
			}
		}

		/// <summary>
		/// Void SetScheduledStartTime(Double)
		/// </summary>
		protected RMethod r_RSetScheduledStartTime_Double;
		public virtual RMethod RSetScheduledStartTime_Double
		{
			get
			{
				if(r_RSetScheduledStartTime_Double == null)
				{
					r_RSetScheduledStartTime_Double = new(this, "SetScheduledStartTime", 0, typeof(System.Double));
					r_RSetScheduledStartTime_Double.SetBelong(this.instance);
				}
				return r_RSetScheduledStartTime_Double;
			}
		}

		/// <summary>
		/// Void SetScheduledEndTime(Double)
		/// </summary>
		protected RMethod r_RSetScheduledEndTime_Double;
		public virtual RMethod RSetScheduledEndTime_Double
		{
			get
			{
				if(r_RSetScheduledEndTime_Double == null)
				{
					r_RSetScheduledEndTime_Double = new(this, "SetScheduledEndTime", 0, typeof(System.Double));
					r_RSetScheduledEndTime_Double.SetBelong(this.instance);
				}
				return r_RSetScheduledEndTime_Double;
			}
		}

		/// <summary>
		/// Void Stop()
		/// </summary>
		protected RMethod r_RStop;
		public virtual RMethod RStop
		{
			get
			{
				if(r_RStop == null)
				{
					r_RStop = new(this, "Stop", 0);
					r_RStop.SetBelong(this.instance);
				}
				return r_RStop;
			}
		}

		/// <summary>
		/// Void Pause()
		/// </summary>
		protected RMethod r_RPause;
		public virtual RMethod RPause
		{
			get
			{
				if(r_RPause == null)
				{
					r_RPause = new(this, "Pause", 0);
					r_RPause.SetBelong(this.instance);
				}
				return r_RPause;
			}
		}

		/// <summary>
		/// Void UnPause()
		/// </summary>
		protected RMethod r_RUnPause;
		public virtual RMethod RUnPause
		{
			get
			{
				if(r_RUnPause == null)
				{
					r_RUnPause = new(this, "UnPause", 0);
					r_RUnPause.SetBelong(this.instance);
				}
				return r_RUnPause;
			}
		}

		/// <summary>
		/// Void PlayClipAtPoint(UnityEngine.AudioClip, UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RPlayClipAtPoint_AudioClip_Vector3;
		public static RMethod RPlayClipAtPoint_AudioClip_Vector3
		{
			get
			{
				if(r_RPlayClipAtPoint_AudioClip_Vector3 == null)
				{
					r_RPlayClipAtPoint_AudioClip_Vector3 = new(typeof(UnityEngine.AudioSource), "PlayClipAtPoint", 0, typeof(UnityEngine.AudioClip), typeof(UnityEngine.Vector3));
					r_RPlayClipAtPoint_AudioClip_Vector3.SetBelong(null);
				}
				return r_RPlayClipAtPoint_AudioClip_Vector3;
			}
		}

		/// <summary>
		/// Void PlayClipAtPoint(UnityEngine.AudioClip, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RPlayClipAtPoint_AudioClip_Vector3_Single;
		public static RMethod RPlayClipAtPoint_AudioClip_Vector3_Single
		{
			get
			{
				if(r_RPlayClipAtPoint_AudioClip_Vector3_Single == null)
				{
					r_RPlayClipAtPoint_AudioClip_Vector3_Single = new(typeof(UnityEngine.AudioSource), "PlayClipAtPoint", 0, typeof(UnityEngine.AudioClip), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RPlayClipAtPoint_AudioClip_Vector3_Single.SetBelong(null);
				}
				return r_RPlayClipAtPoint_AudioClip_Vector3_Single;
			}
		}

		/// <summary>
		/// Void SetCustomCurve(UnityEngine.AudioSourceCurveType, UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_RSetCustomCurve_AudioSourceCurveType_AnimationCurve;
		public virtual RMethod RSetCustomCurve_AudioSourceCurveType_AnimationCurve
		{
			get
			{
				if(r_RSetCustomCurve_AudioSourceCurveType_AnimationCurve == null)
				{
					r_RSetCustomCurve_AudioSourceCurveType_AnimationCurve = new(this, "SetCustomCurve", 0, typeof(UnityEngine.AudioSourceCurveType), typeof(UnityEngine.AnimationCurve));
					r_RSetCustomCurve_AudioSourceCurveType_AnimationCurve.SetBelong(this.instance);
				}
				return r_RSetCustomCurve_AudioSourceCurveType_AnimationCurve;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCurve GetCustomCurve(UnityEngine.AudioSourceCurveType)
		/// </summary>
		protected RMethod r_RGetCustomCurve_AudioSourceCurveType;
		public virtual RMethod RGetCustomCurve_AudioSourceCurveType
		{
			get
			{
				if(r_RGetCustomCurve_AudioSourceCurveType == null)
				{
					r_RGetCustomCurve_AudioSourceCurveType = new(this, "GetCustomCurve", 0, typeof(UnityEngine.AudioSourceCurveType));
					r_RGetCustomCurve_AudioSourceCurveType.SetBelong(this.instance);
				}
				return r_RGetCustomCurve_AudioSourceCurveType;
			}
		}

		/// <summary>
		/// Single[] GetOutputData(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetOutputData_Int32_Int32;
		public virtual RMethod RGetOutputData_Int32_Int32
		{
			get
			{
				if(r_RGetOutputData_Int32_Int32 == null)
				{
					r_RGetOutputData_Int32_Int32 = new(this, "GetOutputData", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetOutputData_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetOutputData_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GetOutputData(Single[], Int32)
		/// </summary>
		protected RMethod r_RGetOutputData_SingleArray_Int32;
		public virtual RMethod RGetOutputData_SingleArray_Int32
		{
			get
			{
				if(r_RGetOutputData_SingleArray_Int32 == null)
				{
					r_RGetOutputData_SingleArray_Int32 = new(this, "GetOutputData", 0, typeof(System.Single).MakeArrayType(), typeof(System.Int32));
					r_RGetOutputData_SingleArray_Int32.SetBelong(this.instance);
				}
				return r_RGetOutputData_SingleArray_Int32;
			}
		}

		/// <summary>
		/// Single[] GetSpectrumData(Int32, Int32, UnityEngine.FFTWindow)
		/// </summary>
		protected RMethod r_RGetSpectrumData_Int32_Int32_FFTWindow;
		public virtual RMethod RGetSpectrumData_Int32_Int32_FFTWindow
		{
			get
			{
				if(r_RGetSpectrumData_Int32_Int32_FFTWindow == null)
				{
					r_RGetSpectrumData_Int32_Int32_FFTWindow = new(this, "GetSpectrumData", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.FFTWindow));
					r_RGetSpectrumData_Int32_Int32_FFTWindow.SetBelong(this.instance);
				}
				return r_RGetSpectrumData_Int32_Int32_FFTWindow;
			}
		}

		/// <summary>
		/// Void GetSpectrumData(Single[], Int32, UnityEngine.FFTWindow)
		/// </summary>
		protected RMethod r_RGetSpectrumData_SingleArray_Int32_FFTWindow;
		public virtual RMethod RGetSpectrumData_SingleArray_Int32_FFTWindow
		{
			get
			{
				if(r_RGetSpectrumData_SingleArray_Int32_FFTWindow == null)
				{
					r_RGetSpectrumData_SingleArray_Int32_FFTWindow = new(this, "GetSpectrumData", 0, typeof(System.Single).MakeArrayType(), typeof(System.Int32), typeof(UnityEngine.FFTWindow));
					r_RGetSpectrumData_SingleArray_Int32_FFTWindow.SetBelong(this.instance);
				}
				return r_RGetSpectrumData_SingleArray_Int32_FFTWindow;
			}
		}

		/// <summary>
		/// Boolean SetSpatializerFloat(Int32, Single)
		/// </summary>
		protected RMethod r_RSetSpatializerFloat_Int32_Single;
		public virtual RMethod RSetSpatializerFloat_Int32_Single
		{
			get
			{
				if(r_RSetSpatializerFloat_Int32_Single == null)
				{
					r_RSetSpatializerFloat_Int32_Single = new(this, "SetSpatializerFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_RSetSpatializerFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetSpatializerFloat_Int32_Single;
			}
		}

		/// <summary>
		/// Boolean GetSpatializerFloat(Int32, Single ByRef)
		/// </summary>
		protected RMethod r_RGetSpatializerFloat_Int32_Out_Single;
		public virtual RMethod RGetSpatializerFloat_Int32_Out_Single
		{
			get
			{
				if(r_RGetSpatializerFloat_Int32_Out_Single == null)
				{
					r_RGetSpatializerFloat_Int32_Out_Single = new(this, "GetSpatializerFloat", 0, typeof(System.Int32), typeof(System.Single).MakeByRefType());
					r_RGetSpatializerFloat_Int32_Out_Single.SetBelong(this.instance);
				}
				return r_RGetSpatializerFloat_Int32_Out_Single;
			}
		}

		/// <summary>
		/// Boolean GetAmbisonicDecoderFloat(Int32, Single ByRef)
		/// </summary>
		protected RMethod r_RGetAmbisonicDecoderFloat_Int32_Out_Single;
		public virtual RMethod RGetAmbisonicDecoderFloat_Int32_Out_Single
		{
			get
			{
				if(r_RGetAmbisonicDecoderFloat_Int32_Out_Single == null)
				{
					r_RGetAmbisonicDecoderFloat_Int32_Out_Single = new(this, "GetAmbisonicDecoderFloat", 0, typeof(System.Int32), typeof(System.Single).MakeByRefType());
					r_RGetAmbisonicDecoderFloat_Int32_Out_Single.SetBelong(this.instance);
				}
				return r_RGetAmbisonicDecoderFloat_Int32_Out_Single;
			}
		}

		/// <summary>
		/// Boolean SetAmbisonicDecoderFloat(Int32, Single)
		/// </summary>
		protected RMethod r_RSetAmbisonicDecoderFloat_Int32_Single;
		public virtual RMethod RSetAmbisonicDecoderFloat_Int32_Single
		{
			get
			{
				if(r_RSetAmbisonicDecoderFloat_Int32_Single == null)
				{
					r_RSetAmbisonicDecoderFloat_Int32_Single = new(this, "SetAmbisonicDecoderFloat", 0, typeof(System.Int32), typeof(System.Single));
					r_RSetAmbisonicDecoderFloat_Int32_Single.SetBelong(this.instance);
				}
				return r_RSetAmbisonicDecoderFloat_Int32_Single;
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


        public RAudioSource() : base("UnityEngine.AudioSource")
        {
        }

        public RAudioSource(System.Object instance) : base("UnityEngine.AudioSource")
		{
            SetInstance(instance);
		}

        public RAudioSource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAudioSource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Single GetPitch(UnityEngine.AudioSource  @source)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source};
            var ___result = RGetPitch_AudioSource.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static void SetPitch(UnityEngine.AudioSource  @source, System.Single  @pitch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @pitch};
            var ___result = RSetPitch_AudioSource_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void PlayHelper(UnityEngine.AudioSource  @source, System.UInt64  @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @delay};
            var ___result = RPlayHelper_AudioSource_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Play(System.Double  @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RPlay_Double.Invoke(___genericsType, ___parameters);

            
        }


        public static void PlayOneShotHelper(UnityEngine.AudioSource  @source, UnityEngine.AudioClip  @clip, System.Single  @volumeScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @clip, @volumeScale};
            var ___result = RPlayOneShotHelper_AudioSource_AudioClip_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop(System.Boolean  @stopOneShots)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stopOneShots};
            var ___result = RStop_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetCustomCurveHelper(UnityEngine.AudioSource  @source, UnityEngine.AudioSourceCurveType  @type, UnityEngine.AnimationCurve  @curve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @type, @curve};
            var ___result = RSetCustomCurveHelper_AudioSource_AudioSourceCurveType_AnimationCurve.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.AnimationCurve GetCustomCurveHelper(UnityEngine.AudioSource  @source, UnityEngine.AudioSourceCurveType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @type};
            var ___result = RGetCustomCurveHelper_AudioSource_AudioSourceCurveType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public static void GetOutputDataHelper(UnityEngine.AudioSource  @source, System.Single[]  @samples, System.Int32  @channel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @samples, @channel};
            var ___result = RGetOutputDataHelper_AudioSource_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetSpectrumDataHelper(UnityEngine.AudioSource  @source, System.Single[]  @samples, System.Int32  @channel, UnityEngine.FFTWindow  @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @samples, @channel, @window};
            var ___result = RGetSpectrumDataHelper_AudioSource_SingleArray_Int32_FFTWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean PlayOnGamepad(System.Int32  @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RPlayOnGamepad_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean DisableGamepadOutput()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisableGamepadOutput.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetGamepadSpeakerMixLevel(System.Int32  @slot, System.Int32  @mixLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @mixLevel};
            var ___result = RSetGamepadSpeakerMixLevel_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetGamepadSpeakerMixLevelDefault(System.Int32  @slot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot};
            var ___result = RSetGamepadSpeakerMixLevelDefault_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetGamepadSpeakerRestrictedAudio(System.Int32  @slot, System.Boolean  @restricted)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@slot, @restricted};
            var ___result = RSetGamepadSpeakerRestrictedAudio_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean GamepadSpeakerSupportsOutputType(UnityEngine.GamepadSpeakerOutputType  @outputType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outputType};
            var ___result = RGamepadSpeakerSupportsOutputType_GamepadSpeakerOutputType.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Play()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPlay.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Play(System.UInt64  @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RPlay_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayDelayed(System.Single  @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RPlayDelayed_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayScheduled(System.Double  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RPlayScheduled_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayOneShot(UnityEngine.AudioClip  @clip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip};
            var ___result = RPlayOneShot_AudioClip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PlayOneShot(UnityEngine.AudioClip  @clip, System.Single  @volumeScale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @volumeScale};
            var ___result = RPlayOneShot_AudioClip_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetScheduledStartTime(System.Double  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RSetScheduledStartTime_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetScheduledEndTime(System.Double  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = RSetScheduledEndTime_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStop.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Pause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPause.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnPause()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnPause.Invoke(___genericsType, ___parameters);

            
        }


        public static void PlayClipAtPoint(UnityEngine.AudioClip  @clip, UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @position};
            var ___result = RPlayClipAtPoint_AudioClip_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public static void PlayClipAtPoint(UnityEngine.AudioClip  @clip, UnityEngine.Vector3  @position, System.Single  @volume)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @position, @volume};
            var ___result = RPlayClipAtPoint_AudioClip_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCustomCurve(UnityEngine.AudioSourceCurveType  @type, UnityEngine.AnimationCurve  @curve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @curve};
            var ___result = RSetCustomCurve_AudioSourceCurveType_AnimationCurve.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.AnimationCurve GetCustomCurve(UnityEngine.AudioSourceCurveType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetCustomCurve_AudioSourceCurveType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationCurve)___result;
        }


        public virtual System.Single[] GetOutputData(System.Int32  @numSamples, System.Int32  @channel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numSamples, @channel};
            var ___result = RGetOutputData_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual void GetOutputData(System.Single[]  @samples, System.Int32  @channel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@samples, @channel};
            var ___result = RGetOutputData_SingleArray_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single[] GetSpectrumData(System.Int32  @numSamples, System.Int32  @channel, UnityEngine.FFTWindow  @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@numSamples, @channel, @window};
            var ___result = RGetSpectrumData_Int32_Int32_FFTWindow.Invoke(___genericsType, ___parameters);

            return (System.Single[])___result;
        }


        public virtual void GetSpectrumData(System.Single[]  @samples, System.Int32  @channel, UnityEngine.FFTWindow  @window)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@samples, @channel, @window};
            var ___result = RGetSpectrumData_SingleArray_Int32_FFTWindow.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean SetSpatializerFloat(System.Int32  @index, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSetSpatializerFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetSpatializerFloat(System.Int32  @index, out System.Single  @value)
        {
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RGetSpatializerFloat_Int32_Out_Single.Invoke(___genericsType, ___parameters);
			value = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean GetAmbisonicDecoderFloat(System.Int32  @index, out System.Single  @value)
        {
			value = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RGetAmbisonicDecoderFloat_Int32_Out_Single.Invoke(___genericsType, ___parameters);
			value = (System.Single)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SetAmbisonicDecoderFloat(System.Int32  @index, System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @value};
            var ___result = RSetAmbisonicDecoderFloat_Int32_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
