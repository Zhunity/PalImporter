using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Animation
	/// </summary>
    public partial class RAnimation : RMember //
    {

		/// <summary>
		/// UnityEngine.AnimationClip clip
		/// </summary>
		protected RUnityEngine.RAnimationClip r_clip;
		public virtual RUnityEngine.RAnimationClip Rclip
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
		/// Boolean playAutomatically
		/// </summary>
		protected RProperty r_playAutomatically;
		public virtual RProperty RplayAutomatically
		{
			get
			{
				if(r_playAutomatically == null)
				{
					r_playAutomatically = new(this, "playAutomatically", -1);
					r_playAutomatically.SetBelong(this.instance);
				}
				return r_playAutomatically;
			}
		}

		/// <summary>
		/// UnityEngine.WrapMode wrapMode
		/// </summary>
		protected RProperty r_wrapMode;
		public virtual RProperty RwrapMode
		{
			get
			{
				if(r_wrapMode == null)
				{
					r_wrapMode = new(this, "wrapMode", -1);
					r_wrapMode.SetBelong(this.instance);
				}
				return r_wrapMode;
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
		/// UnityEngine.AnimationState Item [System.String]
		/// </summary>
		protected RUnityEngine.RAnimationState r_Item_String;
		public virtual RUnityEngine.RAnimationState RItem_String
		{
			get
			{
				if(r_Item_String == null)
				{
					r_Item_String = new(this, "Item", -1, typeof(System.String));
					r_Item_String.SetBelong(this.instance);
				}
				return r_Item_String;
			}
		}

		/// <summary>
		/// Boolean animatePhysics
		/// </summary>
		protected RProperty r_animatePhysics;
		public virtual RProperty RanimatePhysics
		{
			get
			{
				if(r_animatePhysics == null)
				{
					r_animatePhysics = new(this, "animatePhysics", -1);
					r_animatePhysics.SetBelong(this.instance);
				}
				return r_animatePhysics;
			}
		}

		/// <summary>
		/// Boolean animateOnlyIfVisible
		/// </summary>
		protected RProperty r_animateOnlyIfVisible;
		public virtual RProperty RanimateOnlyIfVisible
		{
			get
			{
				if(r_animateOnlyIfVisible == null)
				{
					r_animateOnlyIfVisible = new(this, "animateOnlyIfVisible", -1);
					r_animateOnlyIfVisible.SetBelong(this.instance);
				}
				return r_animateOnlyIfVisible;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationCullingType cullingType
		/// </summary>
		protected RProperty r_cullingType;
		public virtual RProperty RcullingType
		{
			get
			{
				if(r_cullingType == null)
				{
					r_cullingType = new(this, "cullingType", -1);
					r_cullingType.SetBelong(this.instance);
				}
				return r_cullingType;
			}
		}

		/// <summary>
		/// UnityEngine.Bounds localBounds
		/// </summary>
		protected RUnityEngine.RBounds r_localBounds;
		public virtual RUnityEngine.RBounds RlocalBounds
		{
			get
			{
				if(r_localBounds == null)
				{
					r_localBounds = new(this, "localBounds", -1);
					r_localBounds.SetBelong(this.instance);
				}
				return r_localBounds;
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
		/// Void Stop(System.String)
		/// </summary>
		protected RMethod r_RStop_String;
		public virtual RMethod RStop_String
		{
			get
			{
				if(r_RStop_String == null)
				{
					r_RStop_String = new(this, "Stop", 0, typeof(System.String));
					r_RStop_String.SetBelong(this.instance);
				}
				return r_RStop_String;
			}
		}

		/// <summary>
		/// Void StopNamed(System.String)
		/// </summary>
		protected RMethod r_RStopNamed_String;
		public virtual RMethod RStopNamed_String
		{
			get
			{
				if(r_RStopNamed_String == null)
				{
					r_RStopNamed_String = new(this, "StopNamed", 0, typeof(System.String));
					r_RStopNamed_String.SetBelong(this.instance);
				}
				return r_RStopNamed_String;
			}
		}

		/// <summary>
		/// Void Rewind()
		/// </summary>
		protected RMethod r_RRewind;
		public virtual RMethod RRewind
		{
			get
			{
				if(r_RRewind == null)
				{
					r_RRewind = new(this, "Rewind", 0);
					r_RRewind.SetBelong(this.instance);
				}
				return r_RRewind;
			}
		}

		/// <summary>
		/// Void Rewind(System.String)
		/// </summary>
		protected RMethod r_RRewind_String;
		public virtual RMethod RRewind_String
		{
			get
			{
				if(r_RRewind_String == null)
				{
					r_RRewind_String = new(this, "Rewind", 0, typeof(System.String));
					r_RRewind_String.SetBelong(this.instance);
				}
				return r_RRewind_String;
			}
		}

		/// <summary>
		/// Void RewindNamed(System.String)
		/// </summary>
		protected RMethod r_RRewindNamed_String;
		public virtual RMethod RRewindNamed_String
		{
			get
			{
				if(r_RRewindNamed_String == null)
				{
					r_RRewindNamed_String = new(this, "RewindNamed", 0, typeof(System.String));
					r_RRewindNamed_String.SetBelong(this.instance);
				}
				return r_RRewindNamed_String;
			}
		}

		/// <summary>
		/// Void Sample()
		/// </summary>
		protected RMethod r_RSample;
		public virtual RMethod RSample
		{
			get
			{
				if(r_RSample == null)
				{
					r_RSample = new(this, "Sample", 0);
					r_RSample.SetBelong(this.instance);
				}
				return r_RSample;
			}
		}

		/// <summary>
		/// Boolean IsPlaying(System.String)
		/// </summary>
		protected RMethod r_RIsPlaying_String;
		public virtual RMethod RIsPlaying_String
		{
			get
			{
				if(r_RIsPlaying_String == null)
				{
					r_RIsPlaying_String = new(this, "IsPlaying", 0, typeof(System.String));
					r_RIsPlaying_String.SetBelong(this.instance);
				}
				return r_RIsPlaying_String;
			}
		}

		/// <summary>
		/// Boolean Play()
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
		/// Boolean Play(UnityEngine.PlayMode)
		/// </summary>
		protected RMethod r_RPlay_PlayMode;
		public virtual RMethod RPlay_PlayMode
		{
			get
			{
				if(r_RPlay_PlayMode == null)
				{
					r_RPlay_PlayMode = new(this, "Play", 0, typeof(UnityEngine.PlayMode));
					r_RPlay_PlayMode.SetBelong(this.instance);
				}
				return r_RPlay_PlayMode;
			}
		}

		/// <summary>
		/// Boolean PlayDefaultAnimation(UnityEngine.PlayMode)
		/// </summary>
		protected RMethod r_RPlayDefaultAnimation_PlayMode;
		public virtual RMethod RPlayDefaultAnimation_PlayMode
		{
			get
			{
				if(r_RPlayDefaultAnimation_PlayMode == null)
				{
					r_RPlayDefaultAnimation_PlayMode = new(this, "PlayDefaultAnimation", 0, typeof(UnityEngine.PlayMode));
					r_RPlayDefaultAnimation_PlayMode.SetBelong(this.instance);
				}
				return r_RPlayDefaultAnimation_PlayMode;
			}
		}

		/// <summary>
		/// Boolean Play(System.String)
		/// </summary>
		protected RMethod r_RPlay_String;
		public virtual RMethod RPlay_String
		{
			get
			{
				if(r_RPlay_String == null)
				{
					r_RPlay_String = new(this, "Play", 0, typeof(System.String));
					r_RPlay_String.SetBelong(this.instance);
				}
				return r_RPlay_String;
			}
		}

		/// <summary>
		/// Boolean Play(System.String, UnityEngine.PlayMode)
		/// </summary>
		protected RMethod r_RPlay_String_PlayMode;
		public virtual RMethod RPlay_String_PlayMode
		{
			get
			{
				if(r_RPlay_String_PlayMode == null)
				{
					r_RPlay_String_PlayMode = new(this, "Play", 0, typeof(System.String), typeof(UnityEngine.PlayMode));
					r_RPlay_String_PlayMode.SetBelong(this.instance);
				}
				return r_RPlay_String_PlayMode;
			}
		}

		/// <summary>
		/// Void CrossFade(System.String)
		/// </summary>
		protected RMethod r_RCrossFade_String;
		public virtual RMethod RCrossFade_String
		{
			get
			{
				if(r_RCrossFade_String == null)
				{
					r_RCrossFade_String = new(this, "CrossFade", 0, typeof(System.String));
					r_RCrossFade_String.SetBelong(this.instance);
				}
				return r_RCrossFade_String;
			}
		}

		/// <summary>
		/// Void CrossFade(System.String, Single)
		/// </summary>
		protected RMethod r_RCrossFade_String_Single;
		public virtual RMethod RCrossFade_String_Single
		{
			get
			{
				if(r_RCrossFade_String_Single == null)
				{
					r_RCrossFade_String_Single = new(this, "CrossFade", 0, typeof(System.String), typeof(System.Single));
					r_RCrossFade_String_Single.SetBelong(this.instance);
				}
				return r_RCrossFade_String_Single;
			}
		}

		/// <summary>
		/// Void CrossFade(System.String, Single, UnityEngine.PlayMode)
		/// </summary>
		protected RMethod r_RCrossFade_String_Single_PlayMode;
		public virtual RMethod RCrossFade_String_Single_PlayMode
		{
			get
			{
				if(r_RCrossFade_String_Single_PlayMode == null)
				{
					r_RCrossFade_String_Single_PlayMode = new(this, "CrossFade", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.PlayMode));
					r_RCrossFade_String_Single_PlayMode.SetBelong(this.instance);
				}
				return r_RCrossFade_String_Single_PlayMode;
			}
		}

		/// <summary>
		/// Void Blend(System.String)
		/// </summary>
		protected RMethod r_RBlend_String;
		public virtual RMethod RBlend_String
		{
			get
			{
				if(r_RBlend_String == null)
				{
					r_RBlend_String = new(this, "Blend", 0, typeof(System.String));
					r_RBlend_String.SetBelong(this.instance);
				}
				return r_RBlend_String;
			}
		}

		/// <summary>
		/// Void Blend(System.String, Single)
		/// </summary>
		protected RMethod r_RBlend_String_Single;
		public virtual RMethod RBlend_String_Single
		{
			get
			{
				if(r_RBlend_String_Single == null)
				{
					r_RBlend_String_Single = new(this, "Blend", 0, typeof(System.String), typeof(System.Single));
					r_RBlend_String_Single.SetBelong(this.instance);
				}
				return r_RBlend_String_Single;
			}
		}

		/// <summary>
		/// Void Blend(System.String, Single, Single)
		/// </summary>
		protected RMethod r_RBlend_String_Single_Single;
		public virtual RMethod RBlend_String_Single_Single
		{
			get
			{
				if(r_RBlend_String_Single_Single == null)
				{
					r_RBlend_String_Single_Single = new(this, "Blend", 0, typeof(System.String), typeof(System.Single), typeof(System.Single));
					r_RBlend_String_Single_Single.SetBelong(this.instance);
				}
				return r_RBlend_String_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState CrossFadeQueued(System.String)
		/// </summary>
		protected RMethod r_RCrossFadeQueued_String;
		public virtual RMethod RCrossFadeQueued_String
		{
			get
			{
				if(r_RCrossFadeQueued_String == null)
				{
					r_RCrossFadeQueued_String = new(this, "CrossFadeQueued", 0, typeof(System.String));
					r_RCrossFadeQueued_String.SetBelong(this.instance);
				}
				return r_RCrossFadeQueued_String;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState CrossFadeQueued(System.String, Single)
		/// </summary>
		protected RMethod r_RCrossFadeQueued_String_Single;
		public virtual RMethod RCrossFadeQueued_String_Single
		{
			get
			{
				if(r_RCrossFadeQueued_String_Single == null)
				{
					r_RCrossFadeQueued_String_Single = new(this, "CrossFadeQueued", 0, typeof(System.String), typeof(System.Single));
					r_RCrossFadeQueued_String_Single.SetBelong(this.instance);
				}
				return r_RCrossFadeQueued_String_Single;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState CrossFadeQueued(System.String, Single, UnityEngine.QueueMode)
		/// </summary>
		protected RMethod r_RCrossFadeQueued_String_Single_QueueMode;
		public virtual RMethod RCrossFadeQueued_String_Single_QueueMode
		{
			get
			{
				if(r_RCrossFadeQueued_String_Single_QueueMode == null)
				{
					r_RCrossFadeQueued_String_Single_QueueMode = new(this, "CrossFadeQueued", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.QueueMode));
					r_RCrossFadeQueued_String_Single_QueueMode.SetBelong(this.instance);
				}
				return r_RCrossFadeQueued_String_Single_QueueMode;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState CrossFadeQueued(System.String, Single, UnityEngine.QueueMode, UnityEngine.PlayMode)
		/// </summary>
		protected RMethod r_RCrossFadeQueued_String_Single_QueueMode_PlayMode;
		public virtual RMethod RCrossFadeQueued_String_Single_QueueMode_PlayMode
		{
			get
			{
				if(r_RCrossFadeQueued_String_Single_QueueMode_PlayMode == null)
				{
					r_RCrossFadeQueued_String_Single_QueueMode_PlayMode = new(this, "CrossFadeQueued", 0, typeof(System.String), typeof(System.Single), typeof(UnityEngine.QueueMode), typeof(UnityEngine.PlayMode));
					r_RCrossFadeQueued_String_Single_QueueMode_PlayMode.SetBelong(this.instance);
				}
				return r_RCrossFadeQueued_String_Single_QueueMode_PlayMode;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState PlayQueued(System.String)
		/// </summary>
		protected RMethod r_RPlayQueued_String;
		public virtual RMethod RPlayQueued_String
		{
			get
			{
				if(r_RPlayQueued_String == null)
				{
					r_RPlayQueued_String = new(this, "PlayQueued", 0, typeof(System.String));
					r_RPlayQueued_String.SetBelong(this.instance);
				}
				return r_RPlayQueued_String;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState PlayQueued(System.String, UnityEngine.QueueMode)
		/// </summary>
		protected RMethod r_RPlayQueued_String_QueueMode;
		public virtual RMethod RPlayQueued_String_QueueMode
		{
			get
			{
				if(r_RPlayQueued_String_QueueMode == null)
				{
					r_RPlayQueued_String_QueueMode = new(this, "PlayQueued", 0, typeof(System.String), typeof(UnityEngine.QueueMode));
					r_RPlayQueued_String_QueueMode.SetBelong(this.instance);
				}
				return r_RPlayQueued_String_QueueMode;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState PlayQueued(System.String, UnityEngine.QueueMode, UnityEngine.PlayMode)
		/// </summary>
		protected RMethod r_RPlayQueued_String_QueueMode_PlayMode;
		public virtual RMethod RPlayQueued_String_QueueMode_PlayMode
		{
			get
			{
				if(r_RPlayQueued_String_QueueMode_PlayMode == null)
				{
					r_RPlayQueued_String_QueueMode_PlayMode = new(this, "PlayQueued", 0, typeof(System.String), typeof(UnityEngine.QueueMode), typeof(UnityEngine.PlayMode));
					r_RPlayQueued_String_QueueMode_PlayMode.SetBelong(this.instance);
				}
				return r_RPlayQueued_String_QueueMode_PlayMode;
			}
		}

		/// <summary>
		/// Void AddClip(UnityEngine.AnimationClip, System.String)
		/// </summary>
		protected RMethod r_RAddClip_AnimationClip_String;
		public virtual RMethod RAddClip_AnimationClip_String
		{
			get
			{
				if(r_RAddClip_AnimationClip_String == null)
				{
					r_RAddClip_AnimationClip_String = new(this, "AddClip", 0, typeof(UnityEngine.AnimationClip), typeof(System.String));
					r_RAddClip_AnimationClip_String.SetBelong(this.instance);
				}
				return r_RAddClip_AnimationClip_String;
			}
		}

		/// <summary>
		/// Void AddClip(UnityEngine.AnimationClip, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RAddClip_AnimationClip_String_Int32_Int32;
		public virtual RMethod RAddClip_AnimationClip_String_Int32_Int32
		{
			get
			{
				if(r_RAddClip_AnimationClip_String_Int32_Int32 == null)
				{
					r_RAddClip_AnimationClip_String_Int32_Int32 = new(this, "AddClip", 0, typeof(UnityEngine.AnimationClip), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RAddClip_AnimationClip_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAddClip_AnimationClip_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void AddClip(UnityEngine.AnimationClip, System.String, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RAddClip_AnimationClip_String_Int32_Int32_Boolean;
		public virtual RMethod RAddClip_AnimationClip_String_Int32_Int32_Boolean
		{
			get
			{
				if(r_RAddClip_AnimationClip_String_Int32_Int32_Boolean == null)
				{
					r_RAddClip_AnimationClip_String_Int32_Int32_Boolean = new(this, "AddClip", 0, typeof(UnityEngine.AnimationClip), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RAddClip_AnimationClip_String_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RAddClip_AnimationClip_String_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveClip(UnityEngine.AnimationClip)
		/// </summary>
		protected RMethod r_RRemoveClip_AnimationClip;
		public virtual RMethod RRemoveClip_AnimationClip
		{
			get
			{
				if(r_RRemoveClip_AnimationClip == null)
				{
					r_RRemoveClip_AnimationClip = new(this, "RemoveClip", 0, typeof(UnityEngine.AnimationClip));
					r_RRemoveClip_AnimationClip.SetBelong(this.instance);
				}
				return r_RRemoveClip_AnimationClip;
			}
		}

		/// <summary>
		/// Void RemoveClip(System.String)
		/// </summary>
		protected RMethod r_RRemoveClip_String;
		public virtual RMethod RRemoveClip_String
		{
			get
			{
				if(r_RRemoveClip_String == null)
				{
					r_RRemoveClip_String = new(this, "RemoveClip", 0, typeof(System.String));
					r_RRemoveClip_String.SetBelong(this.instance);
				}
				return r_RRemoveClip_String;
			}
		}

		/// <summary>
		/// Void RemoveClipNamed(System.String)
		/// </summary>
		protected RMethod r_RRemoveClipNamed_String;
		public virtual RMethod RRemoveClipNamed_String
		{
			get
			{
				if(r_RRemoveClipNamed_String == null)
				{
					r_RRemoveClipNamed_String = new(this, "RemoveClipNamed", 0, typeof(System.String));
					r_RRemoveClipNamed_String.SetBelong(this.instance);
				}
				return r_RRemoveClipNamed_String;
			}
		}

		/// <summary>
		/// Int32 GetClipCount()
		/// </summary>
		protected RMethod r_RGetClipCount;
		public virtual RMethod RGetClipCount
		{
			get
			{
				if(r_RGetClipCount == null)
				{
					r_RGetClipCount = new(this, "GetClipCount", 0);
					r_RGetClipCount.SetBelong(this.instance);
				}
				return r_RGetClipCount;
			}
		}

		/// <summary>
		/// Boolean Play(UnityEngine.AnimationPlayMode)
		/// </summary>
		protected RMethod r_RPlay_AnimationPlayMode;
		public virtual RMethod RPlay_AnimationPlayMode
		{
			get
			{
				if(r_RPlay_AnimationPlayMode == null)
				{
					r_RPlay_AnimationPlayMode = new(this, "Play", 0, typeof(UnityEngine.AnimationPlayMode));
					r_RPlay_AnimationPlayMode.SetBelong(this.instance);
				}
				return r_RPlay_AnimationPlayMode;
			}
		}

		/// <summary>
		/// Boolean Play(System.String, UnityEngine.AnimationPlayMode)
		/// </summary>
		protected RMethod r_RPlay_String_AnimationPlayMode;
		public virtual RMethod RPlay_String_AnimationPlayMode
		{
			get
			{
				if(r_RPlay_String_AnimationPlayMode == null)
				{
					r_RPlay_String_AnimationPlayMode = new(this, "Play", 0, typeof(System.String), typeof(UnityEngine.AnimationPlayMode));
					r_RPlay_String_AnimationPlayMode.SetBelong(this.instance);
				}
				return r_RPlay_String_AnimationPlayMode;
			}
		}

		/// <summary>
		/// Void SyncLayer(Int32)
		/// </summary>
		protected RMethod r_RSyncLayer_Int32;
		public virtual RMethod RSyncLayer_Int32
		{
			get
			{
				if(r_RSyncLayer_Int32 == null)
				{
					r_RSyncLayer_Int32 = new(this, "SyncLayer", 0, typeof(System.Int32));
					r_RSyncLayer_Int32.SetBelong(this.instance);
				}
				return r_RSyncLayer_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState GetState(System.String)
		/// </summary>
		protected RMethod r_RGetState_String;
		public virtual RMethod RGetState_String
		{
			get
			{
				if(r_RGetState_String == null)
				{
					r_RGetState_String = new(this, "GetState", 0, typeof(System.String));
					r_RGetState_String.SetBelong(this.instance);
				}
				return r_RGetState_String;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState GetStateAtIndex(Int32)
		/// </summary>
		protected RMethod r_RGetStateAtIndex_Int32;
		public virtual RMethod RGetStateAtIndex_Int32
		{
			get
			{
				if(r_RGetStateAtIndex_Int32 == null)
				{
					r_RGetStateAtIndex_Int32 = new(this, "GetStateAtIndex", 0, typeof(System.Int32));
					r_RGetStateAtIndex_Int32.SetBelong(this.instance);
				}
				return r_RGetStateAtIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 GetStateCount()
		/// </summary>
		protected RMethod r_RGetStateCount;
		public virtual RMethod RGetStateCount
		{
			get
			{
				if(r_RGetStateCount == null)
				{
					r_RGetStateCount = new(this, "GetStateCount", 0);
					r_RGetStateCount.SetBelong(this.instance);
				}
				return r_RGetStateCount;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationClip GetClip(System.String)
		/// </summary>
		protected RMethod r_RGetClip_String;
		public virtual RMethod RGetClip_String
		{
			get
			{
				if(r_RGetClip_String == null)
				{
					r_RGetClip_String = new(this, "GetClip", 0, typeof(System.String));
					r_RGetClip_String.SetBelong(this.instance);
				}
				return r_RGetClip_String;
			}
		}

		/// <summary>
		/// Void get_localBounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Rget_localBounds_Injected_Out_Bounds;
		public virtual RMethod Rget_localBounds_Injected_Out_Bounds
		{
			get
			{
				if(r_Rget_localBounds_Injected_Out_Bounds == null)
				{
					r_Rget_localBounds_Injected_Out_Bounds = new(this, "get_localBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Rget_localBounds_Injected_Out_Bounds.SetBelong(this.instance);
				}
				return r_Rget_localBounds_Injected_Out_Bounds;
			}
		}

		/// <summary>
		/// Void set_localBounds_Injected(UnityEngine.Bounds ByRef)
		/// </summary>
		protected RMethod r_Rset_localBounds_Injected_Ref_Bounds;
		public virtual RMethod Rset_localBounds_Injected_Ref_Bounds
		{
			get
			{
				if(r_Rset_localBounds_Injected_Ref_Bounds == null)
				{
					r_Rset_localBounds_Injected_Ref_Bounds = new(this, "set_localBounds_Injected", 0, typeof(UnityEngine.Bounds).MakeByRefType());
					r_Rset_localBounds_Injected_Ref_Bounds.SetBelong(this.instance);
				}
				return r_Rset_localBounds_Injected_Ref_Bounds;
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


        public RAnimation() : base("UnityEngine.Animation")
        {
        }

        public RAnimation(System.Object instance) : base("UnityEngine.Animation")
		{
            SetInstance(instance);
		}

        public RAnimation(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAnimation(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Stop()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStop.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Stop(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RStop_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopNamed(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RStopNamed_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rewind()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRewind.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Rewind(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RRewind_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RewindNamed(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RRewindNamed_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sample()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSample.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPlaying(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsPlaying_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Play()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPlay.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Play(UnityEngine.PlayMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RPlay_PlayMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean PlayDefaultAnimation(UnityEngine.PlayMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RPlayDefaultAnimation_PlayMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Play(System.String  @animation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation};
            var ___result = RPlay_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Play(System.String  @animation, UnityEngine.PlayMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @mode};
            var ___result = RPlay_String_PlayMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CrossFade(System.String  @animation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation};
            var ___result = RCrossFade_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CrossFade(System.String  @animation, System.Single  @fadeLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @fadeLength};
            var ___result = RCrossFade_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CrossFade(System.String  @animation, System.Single  @fadeLength, UnityEngine.PlayMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @fadeLength, @mode};
            var ___result = RCrossFade_String_Single_PlayMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blend(System.String  @animation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation};
            var ___result = RBlend_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blend(System.String  @animation, System.Single  @targetWeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @targetWeight};
            var ___result = RBlend_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Blend(System.String  @animation, System.Single  @targetWeight, System.Single  @fadeLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @targetWeight, @fadeLength};
            var ___result = RBlend_String_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.AnimationState CrossFadeQueued(System.String  @animation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation};
            var ___result = RCrossFadeQueued_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual UnityEngine.AnimationState CrossFadeQueued(System.String  @animation, System.Single  @fadeLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @fadeLength};
            var ___result = RCrossFadeQueued_String_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual UnityEngine.AnimationState CrossFadeQueued(System.String  @animation, System.Single  @fadeLength, UnityEngine.QueueMode  @queue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @fadeLength, @queue};
            var ___result = RCrossFadeQueued_String_Single_QueueMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual UnityEngine.AnimationState CrossFadeQueued(System.String  @animation, System.Single  @fadeLength, UnityEngine.QueueMode  @queue, UnityEngine.PlayMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @fadeLength, @queue, @mode};
            var ___result = RCrossFadeQueued_String_Single_QueueMode_PlayMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual UnityEngine.AnimationState PlayQueued(System.String  @animation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation};
            var ___result = RPlayQueued_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual UnityEngine.AnimationState PlayQueued(System.String  @animation, UnityEngine.QueueMode  @queue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @queue};
            var ___result = RPlayQueued_String_QueueMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual UnityEngine.AnimationState PlayQueued(System.String  @animation, UnityEngine.QueueMode  @queue, UnityEngine.PlayMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @queue, @mode};
            var ___result = RPlayQueued_String_QueueMode_PlayMode.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual void AddClip(UnityEngine.AnimationClip  @clip, System.String  @newName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @newName};
            var ___result = RAddClip_AnimationClip_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddClip(UnityEngine.AnimationClip  @clip, System.String  @newName, System.Int32  @firstFrame, System.Int32  @lastFrame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @newName, @firstFrame, @lastFrame};
            var ___result = RAddClip_AnimationClip_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddClip(UnityEngine.AnimationClip  @clip, System.String  @newName, System.Int32  @firstFrame, System.Int32  @lastFrame, System.Boolean  @addLoopFrame)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip, @newName, @firstFrame, @lastFrame, @addLoopFrame};
            var ___result = RAddClip_AnimationClip_String_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveClip(UnityEngine.AnimationClip  @clip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clip};
            var ___result = RRemoveClip_AnimationClip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveClip(System.String  @clipName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clipName};
            var ___result = RRemoveClip_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveClipNamed(System.String  @clipName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clipName};
            var ___result = RRemoveClipNamed_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetClipCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetClipCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Play(UnityEngine.AnimationPlayMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode};
            var ___result = RPlay_AnimationPlayMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Play(System.String  @animation, UnityEngine.AnimationPlayMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@animation, @mode};
            var ___result = RPlay_String_AnimationPlayMode.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SyncLayer(System.Int32  @layer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layer};
            var ___result = RSyncLayer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual UnityEngine.AnimationState GetState(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetState_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual UnityEngine.AnimationState GetStateAtIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetStateAtIndex_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationState)___result;
        }


        public virtual System.Int32 GetStateCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetStateCount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual UnityEngine.AnimationClip GetClip(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetClip_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.AnimationClip)___result;
        }


        public virtual void get_localBounds_Injected(out UnityEngine.Bounds  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_localBounds_Injected_Out_Bounds.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Bounds)___parameters[0];

            
        }


        public virtual void set_localBounds_Injected(ref UnityEngine.Bounds  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_localBounds_Injected_Ref_Bounds.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Bounds)___parameters[0];

            
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
