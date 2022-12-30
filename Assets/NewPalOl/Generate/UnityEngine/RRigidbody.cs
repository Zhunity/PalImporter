using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Rigidbody
	/// </summary>
    public partial class RRigidbody : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 velocity
		/// </summary>
		protected RUnityEngine.RVector3 r_velocity;
		public virtual RUnityEngine.RVector3 Rvelocity
		{
			get
			{
				if(r_velocity == null)
				{
					r_velocity = new(this, "velocity", -1);
					r_velocity.SetBelong(this.instance);
				}
				return r_velocity;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 angularVelocity
		/// </summary>
		protected RUnityEngine.RVector3 r_angularVelocity;
		public virtual RUnityEngine.RVector3 RangularVelocity
		{
			get
			{
				if(r_angularVelocity == null)
				{
					r_angularVelocity = new(this, "angularVelocity", -1);
					r_angularVelocity.SetBelong(this.instance);
				}
				return r_angularVelocity;
			}
		}

		/// <summary>
		/// Single drag
		/// </summary>
		protected RProperty r_drag;
		public virtual RProperty Rdrag
		{
			get
			{
				if(r_drag == null)
				{
					r_drag = new(this, "drag", -1);
					r_drag.SetBelong(this.instance);
				}
				return r_drag;
			}
		}

		/// <summary>
		/// Single angularDrag
		/// </summary>
		protected RProperty r_angularDrag;
		public virtual RProperty RangularDrag
		{
			get
			{
				if(r_angularDrag == null)
				{
					r_angularDrag = new(this, "angularDrag", -1);
					r_angularDrag.SetBelong(this.instance);
				}
				return r_angularDrag;
			}
		}

		/// <summary>
		/// Single mass
		/// </summary>
		protected RProperty r_mass;
		public virtual RProperty Rmass
		{
			get
			{
				if(r_mass == null)
				{
					r_mass = new(this, "mass", -1);
					r_mass.SetBelong(this.instance);
				}
				return r_mass;
			}
		}

		/// <summary>
		/// Boolean useGravity
		/// </summary>
		protected RProperty r_useGravity;
		public virtual RProperty RuseGravity
		{
			get
			{
				if(r_useGravity == null)
				{
					r_useGravity = new(this, "useGravity", -1);
					r_useGravity.SetBelong(this.instance);
				}
				return r_useGravity;
			}
		}

		/// <summary>
		/// Single maxDepenetrationVelocity
		/// </summary>
		protected RProperty r_maxDepenetrationVelocity;
		public virtual RProperty RmaxDepenetrationVelocity
		{
			get
			{
				if(r_maxDepenetrationVelocity == null)
				{
					r_maxDepenetrationVelocity = new(this, "maxDepenetrationVelocity", -1);
					r_maxDepenetrationVelocity.SetBelong(this.instance);
				}
				return r_maxDepenetrationVelocity;
			}
		}

		/// <summary>
		/// Boolean isKinematic
		/// </summary>
		protected RProperty r_isKinematic;
		public virtual RProperty RisKinematic
		{
			get
			{
				if(r_isKinematic == null)
				{
					r_isKinematic = new(this, "isKinematic", -1);
					r_isKinematic.SetBelong(this.instance);
				}
				return r_isKinematic;
			}
		}

		/// <summary>
		/// Boolean freezeRotation
		/// </summary>
		protected RProperty r_freezeRotation;
		public virtual RProperty RfreezeRotation
		{
			get
			{
				if(r_freezeRotation == null)
				{
					r_freezeRotation = new(this, "freezeRotation", -1);
					r_freezeRotation.SetBelong(this.instance);
				}
				return r_freezeRotation;
			}
		}

		/// <summary>
		/// UnityEngine.RigidbodyConstraints constraints
		/// </summary>
		protected RProperty r_constraints;
		public virtual RProperty Rconstraints
		{
			get
			{
				if(r_constraints == null)
				{
					r_constraints = new(this, "constraints", -1);
					r_constraints.SetBelong(this.instance);
				}
				return r_constraints;
			}
		}

		/// <summary>
		/// UnityEngine.CollisionDetectionMode collisionDetectionMode
		/// </summary>
		protected RProperty r_collisionDetectionMode;
		public virtual RProperty RcollisionDetectionMode
		{
			get
			{
				if(r_collisionDetectionMode == null)
				{
					r_collisionDetectionMode = new(this, "collisionDetectionMode", -1);
					r_collisionDetectionMode.SetBelong(this.instance);
				}
				return r_collisionDetectionMode;
			}
		}

		/// <summary>
		/// Boolean automaticCenterOfMass
		/// </summary>
		protected RProperty r_automaticCenterOfMass;
		public virtual RProperty RautomaticCenterOfMass
		{
			get
			{
				if(r_automaticCenterOfMass == null)
				{
					r_automaticCenterOfMass = new(this, "automaticCenterOfMass", -1);
					r_automaticCenterOfMass.SetBelong(this.instance);
				}
				return r_automaticCenterOfMass;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 centerOfMass
		/// </summary>
		protected RUnityEngine.RVector3 r_centerOfMass;
		public virtual RUnityEngine.RVector3 RcenterOfMass
		{
			get
			{
				if(r_centerOfMass == null)
				{
					r_centerOfMass = new(this, "centerOfMass", -1);
					r_centerOfMass.SetBelong(this.instance);
				}
				return r_centerOfMass;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 worldCenterOfMass
		/// </summary>
		protected RUnityEngine.RVector3 r_worldCenterOfMass;
		public virtual RUnityEngine.RVector3 RworldCenterOfMass
		{
			get
			{
				if(r_worldCenterOfMass == null)
				{
					r_worldCenterOfMass = new(this, "worldCenterOfMass", -1);
					r_worldCenterOfMass.SetBelong(this.instance);
				}
				return r_worldCenterOfMass;
			}
		}

		/// <summary>
		/// Boolean automaticInertiaTensor
		/// </summary>
		protected RProperty r_automaticInertiaTensor;
		public virtual RProperty RautomaticInertiaTensor
		{
			get
			{
				if(r_automaticInertiaTensor == null)
				{
					r_automaticInertiaTensor = new(this, "automaticInertiaTensor", -1);
					r_automaticInertiaTensor.SetBelong(this.instance);
				}
				return r_automaticInertiaTensor;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion inertiaTensorRotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_inertiaTensorRotation;
		public virtual RUnityEngine.RQuaternion RinertiaTensorRotation
		{
			get
			{
				if(r_inertiaTensorRotation == null)
				{
					r_inertiaTensorRotation = new(this, "inertiaTensorRotation", -1);
					r_inertiaTensorRotation.SetBelong(this.instance);
				}
				return r_inertiaTensorRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 inertiaTensor
		/// </summary>
		protected RUnityEngine.RVector3 r_inertiaTensor;
		public virtual RUnityEngine.RVector3 RinertiaTensor
		{
			get
			{
				if(r_inertiaTensor == null)
				{
					r_inertiaTensor = new(this, "inertiaTensor", -1);
					r_inertiaTensor.SetBelong(this.instance);
				}
				return r_inertiaTensor;
			}
		}

		/// <summary>
		/// Boolean detectCollisions
		/// </summary>
		protected RProperty r_detectCollisions;
		public virtual RProperty RdetectCollisions
		{
			get
			{
				if(r_detectCollisions == null)
				{
					r_detectCollisions = new(this, "detectCollisions", -1);
					r_detectCollisions.SetBelong(this.instance);
				}
				return r_detectCollisions;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected RUnityEngine.RVector3 r_position;
		public virtual RUnityEngine.RVector3 Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position", -1);
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion rotation
		/// </summary>
		protected RUnityEngine.RQuaternion r_rotation;
		public virtual RUnityEngine.RQuaternion Rrotation
		{
			get
			{
				if(r_rotation == null)
				{
					r_rotation = new(this, "rotation", -1);
					r_rotation.SetBelong(this.instance);
				}
				return r_rotation;
			}
		}

		/// <summary>
		/// UnityEngine.RigidbodyInterpolation interpolation
		/// </summary>
		protected RProperty r_interpolation;
		public virtual RProperty Rinterpolation
		{
			get
			{
				if(r_interpolation == null)
				{
					r_interpolation = new(this, "interpolation", -1);
					r_interpolation.SetBelong(this.instance);
				}
				return r_interpolation;
			}
		}

		/// <summary>
		/// Int32 solverIterations
		/// </summary>
		protected RProperty r_solverIterations;
		public virtual RProperty RsolverIterations
		{
			get
			{
				if(r_solverIterations == null)
				{
					r_solverIterations = new(this, "solverIterations", -1);
					r_solverIterations.SetBelong(this.instance);
				}
				return r_solverIterations;
			}
		}

		/// <summary>
		/// Single sleepThreshold
		/// </summary>
		protected RProperty r_sleepThreshold;
		public virtual RProperty RsleepThreshold
		{
			get
			{
				if(r_sleepThreshold == null)
				{
					r_sleepThreshold = new(this, "sleepThreshold", -1);
					r_sleepThreshold.SetBelong(this.instance);
				}
				return r_sleepThreshold;
			}
		}

		/// <summary>
		/// Single maxAngularVelocity
		/// </summary>
		protected RProperty r_maxAngularVelocity;
		public virtual RProperty RmaxAngularVelocity
		{
			get
			{
				if(r_maxAngularVelocity == null)
				{
					r_maxAngularVelocity = new(this, "maxAngularVelocity", -1);
					r_maxAngularVelocity.SetBelong(this.instance);
				}
				return r_maxAngularVelocity;
			}
		}

		/// <summary>
		/// Single maxLinearVelocity
		/// </summary>
		protected RProperty r_maxLinearVelocity;
		public virtual RProperty RmaxLinearVelocity
		{
			get
			{
				if(r_maxLinearVelocity == null)
				{
					r_maxLinearVelocity = new(this, "maxLinearVelocity", -1);
					r_maxLinearVelocity.SetBelong(this.instance);
				}
				return r_maxLinearVelocity;
			}
		}

		/// <summary>
		/// Int32 solverVelocityIterations
		/// </summary>
		protected RProperty r_solverVelocityIterations;
		public virtual RProperty RsolverVelocityIterations
		{
			get
			{
				if(r_solverVelocityIterations == null)
				{
					r_solverVelocityIterations = new(this, "solverVelocityIterations", -1);
					r_solverVelocityIterations.SetBelong(this.instance);
				}
				return r_solverVelocityIterations;
			}
		}

		/// <summary>
		/// UnityEngine.LayerMask excludeLayers
		/// </summary>
		protected RUnityEngine.RLayerMask r_excludeLayers;
		public virtual RUnityEngine.RLayerMask RexcludeLayers
		{
			get
			{
				if(r_excludeLayers == null)
				{
					r_excludeLayers = new(this, "excludeLayers", -1);
					r_excludeLayers.SetBelong(this.instance);
				}
				return r_excludeLayers;
			}
		}

		/// <summary>
		/// UnityEngine.LayerMask includeLayers
		/// </summary>
		protected RUnityEngine.RLayerMask r_includeLayers;
		public virtual RUnityEngine.RLayerMask RincludeLayers
		{
			get
			{
				if(r_includeLayers == null)
				{
					r_includeLayers = new(this, "includeLayers", -1);
					r_includeLayers.SetBelong(this.instance);
				}
				return r_includeLayers;
			}
		}

		/// <summary>
		/// Single sleepVelocity
		/// </summary>
		protected RProperty r_sleepVelocity;
		public virtual RProperty RsleepVelocity
		{
			get
			{
				if(r_sleepVelocity == null)
				{
					r_sleepVelocity = new(this, "sleepVelocity", -1);
					r_sleepVelocity.SetBelong(this.instance);
				}
				return r_sleepVelocity;
			}
		}

		/// <summary>
		/// Single sleepAngularVelocity
		/// </summary>
		protected RProperty r_sleepAngularVelocity;
		public virtual RProperty RsleepAngularVelocity
		{
			get
			{
				if(r_sleepAngularVelocity == null)
				{
					r_sleepAngularVelocity = new(this, "sleepAngularVelocity", -1);
					r_sleepAngularVelocity.SetBelong(this.instance);
				}
				return r_sleepAngularVelocity;
			}
		}

		/// <summary>
		/// Boolean useConeFriction
		/// </summary>
		protected RProperty r_useConeFriction;
		public virtual RProperty RuseConeFriction
		{
			get
			{
				if(r_useConeFriction == null)
				{
					r_useConeFriction = new(this, "useConeFriction", -1);
					r_useConeFriction.SetBelong(this.instance);
				}
				return r_useConeFriction;
			}
		}

		/// <summary>
		/// Int32 solverIterationCount
		/// </summary>
		protected RProperty r_solverIterationCount;
		public virtual RProperty RsolverIterationCount
		{
			get
			{
				if(r_solverIterationCount == null)
				{
					r_solverIterationCount = new(this, "solverIterationCount", -1);
					r_solverIterationCount.SetBelong(this.instance);
				}
				return r_solverIterationCount;
			}
		}

		/// <summary>
		/// Int32 solverVelocityIterationCount
		/// </summary>
		protected RProperty r_solverVelocityIterationCount;
		public virtual RProperty RsolverVelocityIterationCount
		{
			get
			{
				if(r_solverVelocityIterationCount == null)
				{
					r_solverVelocityIterationCount = new(this, "solverVelocityIterationCount", -1);
					r_solverVelocityIterationCount.SetBelong(this.instance);
				}
				return r_solverVelocityIterationCount;
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
		/// Void SetDensity(Single)
		/// </summary>
		protected RMethod r_RSetDensity_Single;
		public virtual RMethod RSetDensity_Single
		{
			get
			{
				if(r_RSetDensity_Single == null)
				{
					r_RSetDensity_Single = new(this, "SetDensity", 0, typeof(System.Single));
					r_RSetDensity_Single.SetBelong(this.instance);
				}
				return r_RSetDensity_Single;
			}
		}

		/// <summary>
		/// Void MovePosition(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RMovePosition_Vector3;
		public virtual RMethod RMovePosition_Vector3
		{
			get
			{
				if(r_RMovePosition_Vector3 == null)
				{
					r_RMovePosition_Vector3 = new(this, "MovePosition", 0, typeof(UnityEngine.Vector3));
					r_RMovePosition_Vector3.SetBelong(this.instance);
				}
				return r_RMovePosition_Vector3;
			}
		}

		/// <summary>
		/// Void MoveRotation(UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_RMoveRotation_Quaternion;
		public virtual RMethod RMoveRotation_Quaternion
		{
			get
			{
				if(r_RMoveRotation_Quaternion == null)
				{
					r_RMoveRotation_Quaternion = new(this, "MoveRotation", 0, typeof(UnityEngine.Quaternion));
					r_RMoveRotation_Quaternion.SetBelong(this.instance);
				}
				return r_RMoveRotation_Quaternion;
			}
		}

		/// <summary>
		/// Void Move(UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_RMove_Vector3_Quaternion;
		public virtual RMethod RMove_Vector3_Quaternion
		{
			get
			{
				if(r_RMove_Vector3_Quaternion == null)
				{
					r_RMove_Vector3_Quaternion = new(this, "Move", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_RMove_Vector3_Quaternion.SetBelong(this.instance);
				}
				return r_RMove_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// Void Sleep()
		/// </summary>
		protected RMethod r_RSleep;
		public virtual RMethod RSleep
		{
			get
			{
				if(r_RSleep == null)
				{
					r_RSleep = new(this, "Sleep", 0);
					r_RSleep.SetBelong(this.instance);
				}
				return r_RSleep;
			}
		}

		/// <summary>
		/// Boolean IsSleeping()
		/// </summary>
		protected RMethod r_RIsSleeping;
		public virtual RMethod RIsSleeping
		{
			get
			{
				if(r_RIsSleeping == null)
				{
					r_RIsSleeping = new(this, "IsSleeping", 0);
					r_RIsSleeping.SetBelong(this.instance);
				}
				return r_RIsSleeping;
			}
		}

		/// <summary>
		/// Void WakeUp()
		/// </summary>
		protected RMethod r_RWakeUp;
		public virtual RMethod RWakeUp
		{
			get
			{
				if(r_RWakeUp == null)
				{
					r_RWakeUp = new(this, "WakeUp", 0);
					r_RWakeUp.SetBelong(this.instance);
				}
				return r_RWakeUp;
			}
		}

		/// <summary>
		/// Void ResetCenterOfMass()
		/// </summary>
		protected RMethod r_RResetCenterOfMass;
		public virtual RMethod RResetCenterOfMass
		{
			get
			{
				if(r_RResetCenterOfMass == null)
				{
					r_RResetCenterOfMass = new(this, "ResetCenterOfMass", 0);
					r_RResetCenterOfMass.SetBelong(this.instance);
				}
				return r_RResetCenterOfMass;
			}
		}

		/// <summary>
		/// Void ResetInertiaTensor()
		/// </summary>
		protected RMethod r_RResetInertiaTensor;
		public virtual RMethod RResetInertiaTensor
		{
			get
			{
				if(r_RResetInertiaTensor == null)
				{
					r_RResetInertiaTensor = new(this, "ResetInertiaTensor", 0);
					r_RResetInertiaTensor.SetBelong(this.instance);
				}
				return r_RResetInertiaTensor;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RGetRelativePointVelocity_Vector3;
		public virtual RMethod RGetRelativePointVelocity_Vector3
		{
			get
			{
				if(r_RGetRelativePointVelocity_Vector3 == null)
				{
					r_RGetRelativePointVelocity_Vector3 = new(this, "GetRelativePointVelocity", 0, typeof(UnityEngine.Vector3));
					r_RGetRelativePointVelocity_Vector3.SetBelong(this.instance);
				}
				return r_RGetRelativePointVelocity_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RGetPointVelocity_Vector3;
		public virtual RMethod RGetPointVelocity_Vector3
		{
			get
			{
				if(r_RGetPointVelocity_Vector3 == null)
				{
					r_RGetPointVelocity_Vector3 = new(this, "GetPointVelocity", 0, typeof(UnityEngine.Vector3));
					r_RGetPointVelocity_Vector3.SetBelong(this.instance);
				}
				return r_RGetPointVelocity_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetAccumulatedForce(Single)
		/// </summary>
		protected RMethod r_RGetAccumulatedForce_Single;
		public virtual RMethod RGetAccumulatedForce_Single
		{
			get
			{
				if(r_RGetAccumulatedForce_Single == null)
				{
					r_RGetAccumulatedForce_Single = new(this, "GetAccumulatedForce", 0, typeof(System.Single));
					r_RGetAccumulatedForce_Single.SetBelong(this.instance);
				}
				return r_RGetAccumulatedForce_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetAccumulatedForce()
		/// </summary>
		protected RMethod r_RGetAccumulatedForce;
		public virtual RMethod RGetAccumulatedForce
		{
			get
			{
				if(r_RGetAccumulatedForce == null)
				{
					r_RGetAccumulatedForce = new(this, "GetAccumulatedForce", 0);
					r_RGetAccumulatedForce.SetBelong(this.instance);
				}
				return r_RGetAccumulatedForce;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetAccumulatedTorque(Single)
		/// </summary>
		protected RMethod r_RGetAccumulatedTorque_Single;
		public virtual RMethod RGetAccumulatedTorque_Single
		{
			get
			{
				if(r_RGetAccumulatedTorque_Single == null)
				{
					r_RGetAccumulatedTorque_Single = new(this, "GetAccumulatedTorque", 0, typeof(System.Single));
					r_RGetAccumulatedTorque_Single.SetBelong(this.instance);
				}
				return r_RGetAccumulatedTorque_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetAccumulatedTorque()
		/// </summary>
		protected RMethod r_RGetAccumulatedTorque;
		public virtual RMethod RGetAccumulatedTorque
		{
			get
			{
				if(r_RGetAccumulatedTorque == null)
				{
					r_RGetAccumulatedTorque = new(this, "GetAccumulatedTorque", 0);
					r_RGetAccumulatedTorque.SetBelong(this.instance);
				}
				return r_RGetAccumulatedTorque;
			}
		}

		/// <summary>
		/// Void AddForce(UnityEngine.Vector3, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddForce_Vector3_ForceMode;
		public virtual RMethod RAddForce_Vector3_ForceMode
		{
			get
			{
				if(r_RAddForce_Vector3_ForceMode == null)
				{
					r_RAddForce_Vector3_ForceMode = new(this, "AddForce", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode));
					r_RAddForce_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddForce_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddForce(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RAddForce_Vector3;
		public virtual RMethod RAddForce_Vector3
		{
			get
			{
				if(r_RAddForce_Vector3 == null)
				{
					r_RAddForce_Vector3 = new(this, "AddForce", 0, typeof(UnityEngine.Vector3));
					r_RAddForce_Vector3.SetBelong(this.instance);
				}
				return r_RAddForce_Vector3;
			}
		}

		/// <summary>
		/// Void AddForce(Single, Single, Single, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddForce_Single_Single_Single_ForceMode;
		public virtual RMethod RAddForce_Single_Single_Single_ForceMode
		{
			get
			{
				if(r_RAddForce_Single_Single_Single_ForceMode == null)
				{
					r_RAddForce_Single_Single_Single_ForceMode = new(this, "AddForce", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.ForceMode));
					r_RAddForce_Single_Single_Single_ForceMode.SetBelong(this.instance);
				}
				return r_RAddForce_Single_Single_Single_ForceMode;
			}
		}

		/// <summary>
		/// Void AddForce(Single, Single, Single)
		/// </summary>
		protected RMethod r_RAddForce_Single_Single_Single;
		public virtual RMethod RAddForce_Single_Single_Single
		{
			get
			{
				if(r_RAddForce_Single_Single_Single == null)
				{
					r_RAddForce_Single_Single_Single = new(this, "AddForce", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RAddForce_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RAddForce_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void AddRelativeForce(UnityEngine.Vector3, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddRelativeForce_Vector3_ForceMode;
		public virtual RMethod RAddRelativeForce_Vector3_ForceMode
		{
			get
			{
				if(r_RAddRelativeForce_Vector3_ForceMode == null)
				{
					r_RAddRelativeForce_Vector3_ForceMode = new(this, "AddRelativeForce", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode));
					r_RAddRelativeForce_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddRelativeForce_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddRelativeForce(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RAddRelativeForce_Vector3;
		public virtual RMethod RAddRelativeForce_Vector3
		{
			get
			{
				if(r_RAddRelativeForce_Vector3 == null)
				{
					r_RAddRelativeForce_Vector3 = new(this, "AddRelativeForce", 0, typeof(UnityEngine.Vector3));
					r_RAddRelativeForce_Vector3.SetBelong(this.instance);
				}
				return r_RAddRelativeForce_Vector3;
			}
		}

		/// <summary>
		/// Void AddRelativeForce(Single, Single, Single, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddRelativeForce_Single_Single_Single_ForceMode;
		public virtual RMethod RAddRelativeForce_Single_Single_Single_ForceMode
		{
			get
			{
				if(r_RAddRelativeForce_Single_Single_Single_ForceMode == null)
				{
					r_RAddRelativeForce_Single_Single_Single_ForceMode = new(this, "AddRelativeForce", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.ForceMode));
					r_RAddRelativeForce_Single_Single_Single_ForceMode.SetBelong(this.instance);
				}
				return r_RAddRelativeForce_Single_Single_Single_ForceMode;
			}
		}

		/// <summary>
		/// Void AddRelativeForce(Single, Single, Single)
		/// </summary>
		protected RMethod r_RAddRelativeForce_Single_Single_Single;
		public virtual RMethod RAddRelativeForce_Single_Single_Single
		{
			get
			{
				if(r_RAddRelativeForce_Single_Single_Single == null)
				{
					r_RAddRelativeForce_Single_Single_Single = new(this, "AddRelativeForce", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RAddRelativeForce_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RAddRelativeForce_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void AddTorque(UnityEngine.Vector3, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddTorque_Vector3_ForceMode;
		public virtual RMethod RAddTorque_Vector3_ForceMode
		{
			get
			{
				if(r_RAddTorque_Vector3_ForceMode == null)
				{
					r_RAddTorque_Vector3_ForceMode = new(this, "AddTorque", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode));
					r_RAddTorque_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddTorque_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddTorque(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RAddTorque_Vector3;
		public virtual RMethod RAddTorque_Vector3
		{
			get
			{
				if(r_RAddTorque_Vector3 == null)
				{
					r_RAddTorque_Vector3 = new(this, "AddTorque", 0, typeof(UnityEngine.Vector3));
					r_RAddTorque_Vector3.SetBelong(this.instance);
				}
				return r_RAddTorque_Vector3;
			}
		}

		/// <summary>
		/// Void AddTorque(Single, Single, Single, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddTorque_Single_Single_Single_ForceMode;
		public virtual RMethod RAddTorque_Single_Single_Single_ForceMode
		{
			get
			{
				if(r_RAddTorque_Single_Single_Single_ForceMode == null)
				{
					r_RAddTorque_Single_Single_Single_ForceMode = new(this, "AddTorque", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.ForceMode));
					r_RAddTorque_Single_Single_Single_ForceMode.SetBelong(this.instance);
				}
				return r_RAddTorque_Single_Single_Single_ForceMode;
			}
		}

		/// <summary>
		/// Void AddTorque(Single, Single, Single)
		/// </summary>
		protected RMethod r_RAddTorque_Single_Single_Single;
		public virtual RMethod RAddTorque_Single_Single_Single
		{
			get
			{
				if(r_RAddTorque_Single_Single_Single == null)
				{
					r_RAddTorque_Single_Single_Single = new(this, "AddTorque", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RAddTorque_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RAddTorque_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void AddRelativeTorque(UnityEngine.Vector3, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddRelativeTorque_Vector3_ForceMode;
		public virtual RMethod RAddRelativeTorque_Vector3_ForceMode
		{
			get
			{
				if(r_RAddRelativeTorque_Vector3_ForceMode == null)
				{
					r_RAddRelativeTorque_Vector3_ForceMode = new(this, "AddRelativeTorque", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode));
					r_RAddRelativeTorque_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddRelativeTorque_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddRelativeTorque(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RAddRelativeTorque_Vector3;
		public virtual RMethod RAddRelativeTorque_Vector3
		{
			get
			{
				if(r_RAddRelativeTorque_Vector3 == null)
				{
					r_RAddRelativeTorque_Vector3 = new(this, "AddRelativeTorque", 0, typeof(UnityEngine.Vector3));
					r_RAddRelativeTorque_Vector3.SetBelong(this.instance);
				}
				return r_RAddRelativeTorque_Vector3;
			}
		}

		/// <summary>
		/// Void AddRelativeTorque(Single, Single, Single, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddRelativeTorque_Single_Single_Single_ForceMode;
		public virtual RMethod RAddRelativeTorque_Single_Single_Single_ForceMode
		{
			get
			{
				if(r_RAddRelativeTorque_Single_Single_Single_ForceMode == null)
				{
					r_RAddRelativeTorque_Single_Single_Single_ForceMode = new(this, "AddRelativeTorque", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.ForceMode));
					r_RAddRelativeTorque_Single_Single_Single_ForceMode.SetBelong(this.instance);
				}
				return r_RAddRelativeTorque_Single_Single_Single_ForceMode;
			}
		}

		/// <summary>
		/// Void AddRelativeTorque(Single, Single, Single)
		/// </summary>
		protected RMethod r_RAddRelativeTorque_Single_Single_Single;
		public virtual RMethod RAddRelativeTorque_Single_Single_Single
		{
			get
			{
				if(r_RAddRelativeTorque_Single_Single_Single == null)
				{
					r_RAddRelativeTorque_Single_Single_Single = new(this, "AddRelativeTorque", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_RAddRelativeTorque_Single_Single_Single.SetBelong(this.instance);
				}
				return r_RAddRelativeTorque_Single_Single_Single;
			}
		}

		/// <summary>
		/// Void AddForceAtPosition(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddForceAtPosition_Vector3_Vector3_ForceMode;
		public virtual RMethod RAddForceAtPosition_Vector3_Vector3_ForceMode
		{
			get
			{
				if(r_RAddForceAtPosition_Vector3_Vector3_ForceMode == null)
				{
					r_RAddForceAtPosition_Vector3_Vector3_ForceMode = new(this, "AddForceAtPosition", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.ForceMode));
					r_RAddForceAtPosition_Vector3_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddForceAtPosition_Vector3_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddForceAtPosition(UnityEngine.Vector3, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RAddForceAtPosition_Vector3_Vector3;
		public virtual RMethod RAddForceAtPosition_Vector3_Vector3
		{
			get
			{
				if(r_RAddForceAtPosition_Vector3_Vector3 == null)
				{
					r_RAddForceAtPosition_Vector3_Vector3 = new(this, "AddForceAtPosition", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3));
					r_RAddForceAtPosition_Vector3_Vector3.SetBelong(this.instance);
				}
				return r_RAddForceAtPosition_Vector3_Vector3;
			}
		}

		/// <summary>
		/// Void AddExplosionForce(Single, UnityEngine.Vector3, Single, Single, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddExplosionForce_Single_Vector3_Single_Single_ForceMode;
		public virtual RMethod RAddExplosionForce_Single_Vector3_Single_Single_ForceMode
		{
			get
			{
				if(r_RAddExplosionForce_Single_Vector3_Single_Single_ForceMode == null)
				{
					r_RAddExplosionForce_Single_Vector3_Single_Single_ForceMode = new(this, "AddExplosionForce", 0, typeof(System.Single), typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.ForceMode));
					r_RAddExplosionForce_Single_Vector3_Single_Single_ForceMode.SetBelong(this.instance);
				}
				return r_RAddExplosionForce_Single_Vector3_Single_Single_ForceMode;
			}
		}

		/// <summary>
		/// Void AddExplosionForce(Single, UnityEngine.Vector3, Single, Single)
		/// </summary>
		protected RMethod r_RAddExplosionForce_Single_Vector3_Single_Single;
		public virtual RMethod RAddExplosionForce_Single_Vector3_Single_Single
		{
			get
			{
				if(r_RAddExplosionForce_Single_Vector3_Single_Single == null)
				{
					r_RAddExplosionForce_Single_Vector3_Single_Single = new(this, "AddExplosionForce", 0, typeof(System.Single), typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Single));
					r_RAddExplosionForce_Single_Vector3_Single_Single.SetBelong(this.instance);
				}
				return r_RAddExplosionForce_Single_Vector3_Single_Single;
			}
		}

		/// <summary>
		/// Void AddExplosionForce(Single, UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RAddExplosionForce_Single_Vector3_Single;
		public virtual RMethod RAddExplosionForce_Single_Vector3_Single
		{
			get
			{
				if(r_RAddExplosionForce_Single_Vector3_Single == null)
				{
					r_RAddExplosionForce_Single_Vector3_Single = new(this, "AddExplosionForce", 0, typeof(System.Single), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RAddExplosionForce_Single_Vector3_Single.SetBelong(this.instance);
				}
				return r_RAddExplosionForce_Single_Vector3_Single;
			}
		}

		/// <summary>
		/// Void Internal_ClosestPointOnBounds(UnityEngine.Vector3, UnityEngine.Vector3 ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_RInternal_ClosestPointOnBounds_Vector3_Ref_Vector3_Ref_Single;
		public virtual RMethod RInternal_ClosestPointOnBounds_Vector3_Ref_Vector3_Ref_Single
		{
			get
			{
				if(r_RInternal_ClosestPointOnBounds_Vector3_Ref_Vector3_Ref_Single == null)
				{
					r_RInternal_ClosestPointOnBounds_Vector3_Ref_Vector3_Ref_Single = new(this, "Internal_ClosestPointOnBounds", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_RInternal_ClosestPointOnBounds_Vector3_Ref_Vector3_Ref_Single.SetBelong(this.instance);
				}
				return r_RInternal_ClosestPointOnBounds_Vector3_Ref_Vector3_Ref_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RClosestPointOnBounds_Vector3;
		public virtual RMethod RClosestPointOnBounds_Vector3
		{
			get
			{
				if(r_RClosestPointOnBounds_Vector3 == null)
				{
					r_RClosestPointOnBounds_Vector3 = new(this, "ClosestPointOnBounds", 0, typeof(UnityEngine.Vector3));
					r_RClosestPointOnBounds_Vector3.SetBelong(this.instance);
				}
				return r_RClosestPointOnBounds_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.RaycastHit SweepTest(UnityEngine.Vector3, Single, UnityEngine.QueryTriggerInteraction, Boolean ByRef)
		/// </summary>
		protected RMethod r_RSweepTest_Vector3_Single_QueryTriggerInteraction_Ref_Boolean;
		public virtual RMethod RSweepTest_Vector3_Single_QueryTriggerInteraction_Ref_Boolean
		{
			get
			{
				if(r_RSweepTest_Vector3_Single_QueryTriggerInteraction_Ref_Boolean == null)
				{
					r_RSweepTest_Vector3_Single_QueryTriggerInteraction_Ref_Boolean = new(this, "SweepTest", 0, typeof(UnityEngine.Vector3), typeof(System.Single), typeof(UnityEngine.QueryTriggerInteraction), typeof(System.Boolean).MakeByRefType());
					r_RSweepTest_Vector3_Single_QueryTriggerInteraction_Ref_Boolean.SetBelong(this.instance);
				}
				return r_RSweepTest_Vector3_Single_QueryTriggerInteraction_Ref_Boolean;
			}
		}

		/// <summary>
		/// Boolean SweepTest(UnityEngine.Vector3, UnityEngine.RaycastHit ByRef, Single, UnityEngine.QueryTriggerInteraction)
		/// </summary>
		protected RMethod r_RSweepTest_Vector3_Out_RaycastHit_Single_QueryTriggerInteraction;
		public virtual RMethod RSweepTest_Vector3_Out_RaycastHit_Single_QueryTriggerInteraction
		{
			get
			{
				if(r_RSweepTest_Vector3_Out_RaycastHit_Single_QueryTriggerInteraction == null)
				{
					r_RSweepTest_Vector3_Out_RaycastHit_Single_QueryTriggerInteraction = new(this, "SweepTest", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.RaycastHit).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.QueryTriggerInteraction));
					r_RSweepTest_Vector3_Out_RaycastHit_Single_QueryTriggerInteraction.SetBelong(this.instance);
				}
				return r_RSweepTest_Vector3_Out_RaycastHit_Single_QueryTriggerInteraction;
			}
		}

		/// <summary>
		/// Boolean SweepTest(UnityEngine.Vector3, UnityEngine.RaycastHit ByRef, Single)
		/// </summary>
		protected RMethod r_RSweepTest_Vector3_Out_RaycastHit_Single;
		public virtual RMethod RSweepTest_Vector3_Out_RaycastHit_Single
		{
			get
			{
				if(r_RSweepTest_Vector3_Out_RaycastHit_Single == null)
				{
					r_RSweepTest_Vector3_Out_RaycastHit_Single = new(this, "SweepTest", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.RaycastHit).MakeByRefType(), typeof(System.Single));
					r_RSweepTest_Vector3_Out_RaycastHit_Single.SetBelong(this.instance);
				}
				return r_RSweepTest_Vector3_Out_RaycastHit_Single;
			}
		}

		/// <summary>
		/// Boolean SweepTest(UnityEngine.Vector3, UnityEngine.RaycastHit ByRef)
		/// </summary>
		protected RMethod r_RSweepTest_Vector3_Out_RaycastHit;
		public virtual RMethod RSweepTest_Vector3_Out_RaycastHit
		{
			get
			{
				if(r_RSweepTest_Vector3_Out_RaycastHit == null)
				{
					r_RSweepTest_Vector3_Out_RaycastHit = new(this, "SweepTest", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.RaycastHit).MakeByRefType());
					r_RSweepTest_Vector3_Out_RaycastHit.SetBelong(this.instance);
				}
				return r_RSweepTest_Vector3_Out_RaycastHit;
			}
		}

		/// <summary>
		/// UnityEngine.RaycastHit[] Internal_SweepTestAll(UnityEngine.Vector3, Single, UnityEngine.QueryTriggerInteraction)
		/// </summary>
		protected RMethod r_RInternal_SweepTestAll_Vector3_Single_QueryTriggerInteraction;
		public virtual RMethod RInternal_SweepTestAll_Vector3_Single_QueryTriggerInteraction
		{
			get
			{
				if(r_RInternal_SweepTestAll_Vector3_Single_QueryTriggerInteraction == null)
				{
					r_RInternal_SweepTestAll_Vector3_Single_QueryTriggerInteraction = new(this, "Internal_SweepTestAll", 0, typeof(UnityEngine.Vector3), typeof(System.Single), typeof(UnityEngine.QueryTriggerInteraction));
					r_RInternal_SweepTestAll_Vector3_Single_QueryTriggerInteraction.SetBelong(this.instance);
				}
				return r_RInternal_SweepTestAll_Vector3_Single_QueryTriggerInteraction;
			}
		}

		/// <summary>
		/// UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3, Single, UnityEngine.QueryTriggerInteraction)
		/// </summary>
		protected RMethod r_RSweepTestAll_Vector3_Single_QueryTriggerInteraction;
		public virtual RMethod RSweepTestAll_Vector3_Single_QueryTriggerInteraction
		{
			get
			{
				if(r_RSweepTestAll_Vector3_Single_QueryTriggerInteraction == null)
				{
					r_RSweepTestAll_Vector3_Single_QueryTriggerInteraction = new(this, "SweepTestAll", 0, typeof(UnityEngine.Vector3), typeof(System.Single), typeof(UnityEngine.QueryTriggerInteraction));
					r_RSweepTestAll_Vector3_Single_QueryTriggerInteraction.SetBelong(this.instance);
				}
				return r_RSweepTestAll_Vector3_Single_QueryTriggerInteraction;
			}
		}

		/// <summary>
		/// UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3, Single)
		/// </summary>
		protected RMethod r_RSweepTestAll_Vector3_Single;
		public virtual RMethod RSweepTestAll_Vector3_Single
		{
			get
			{
				if(r_RSweepTestAll_Vector3_Single == null)
				{
					r_RSweepTestAll_Vector3_Single = new(this, "SweepTestAll", 0, typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RSweepTestAll_Vector3_Single.SetBelong(this.instance);
				}
				return r_RSweepTestAll_Vector3_Single;
			}
		}

		/// <summary>
		/// UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSweepTestAll_Vector3;
		public virtual RMethod RSweepTestAll_Vector3
		{
			get
			{
				if(r_RSweepTestAll_Vector3 == null)
				{
					r_RSweepTestAll_Vector3 = new(this, "SweepTestAll", 0, typeof(UnityEngine.Vector3));
					r_RSweepTestAll_Vector3.SetBelong(this.instance);
				}
				return r_RSweepTestAll_Vector3;
			}
		}

		/// <summary>
		/// Void SetMaxAngularVelocity(Single)
		/// </summary>
		protected RMethod r_RSetMaxAngularVelocity_Single;
		public virtual RMethod RSetMaxAngularVelocity_Single
		{
			get
			{
				if(r_RSetMaxAngularVelocity_Single == null)
				{
					r_RSetMaxAngularVelocity_Single = new(this, "SetMaxAngularVelocity", 0, typeof(System.Single));
					r_RSetMaxAngularVelocity_Single.SetBelong(this.instance);
				}
				return r_RSetMaxAngularVelocity_Single;
			}
		}

		/// <summary>
		/// Void get_velocity_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_velocity_Injected_Out_Vector3;
		public virtual RMethod Rget_velocity_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_velocity_Injected_Out_Vector3 == null)
				{
					r_Rget_velocity_Injected_Out_Vector3 = new(this, "get_velocity_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_velocity_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_velocity_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_velocity_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_velocity_Injected_Ref_Vector3;
		public virtual RMethod Rset_velocity_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_velocity_Injected_Ref_Vector3 == null)
				{
					r_Rset_velocity_Injected_Ref_Vector3 = new(this, "set_velocity_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_velocity_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_velocity_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_angularVelocity_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_angularVelocity_Injected_Out_Vector3;
		public virtual RMethod Rget_angularVelocity_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_angularVelocity_Injected_Out_Vector3 == null)
				{
					r_Rget_angularVelocity_Injected_Out_Vector3 = new(this, "get_angularVelocity_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_angularVelocity_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_angularVelocity_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_angularVelocity_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_angularVelocity_Injected_Ref_Vector3;
		public virtual RMethod Rset_angularVelocity_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_angularVelocity_Injected_Ref_Vector3 == null)
				{
					r_Rset_angularVelocity_Injected_Ref_Vector3 = new(this, "set_angularVelocity_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_angularVelocity_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_angularVelocity_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_centerOfMass_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_centerOfMass_Injected_Out_Vector3;
		public virtual RMethod Rget_centerOfMass_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_centerOfMass_Injected_Out_Vector3 == null)
				{
					r_Rget_centerOfMass_Injected_Out_Vector3 = new(this, "get_centerOfMass_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_centerOfMass_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_centerOfMass_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_centerOfMass_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_centerOfMass_Injected_Ref_Vector3;
		public virtual RMethod Rset_centerOfMass_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_centerOfMass_Injected_Ref_Vector3 == null)
				{
					r_Rset_centerOfMass_Injected_Ref_Vector3 = new(this, "set_centerOfMass_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_centerOfMass_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_centerOfMass_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_worldCenterOfMass_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_worldCenterOfMass_Injected_Out_Vector3;
		public virtual RMethod Rget_worldCenterOfMass_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_worldCenterOfMass_Injected_Out_Vector3 == null)
				{
					r_Rget_worldCenterOfMass_Injected_Out_Vector3 = new(this, "get_worldCenterOfMass_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_worldCenterOfMass_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_worldCenterOfMass_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void get_inertiaTensorRotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Rget_inertiaTensorRotation_Injected_Out_Quaternion;
		public virtual RMethod Rget_inertiaTensorRotation_Injected_Out_Quaternion
		{
			get
			{
				if(r_Rget_inertiaTensorRotation_Injected_Out_Quaternion == null)
				{
					r_Rget_inertiaTensorRotation_Injected_Out_Quaternion = new(this, "get_inertiaTensorRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Rget_inertiaTensorRotation_Injected_Out_Quaternion.SetBelong(this.instance);
				}
				return r_Rget_inertiaTensorRotation_Injected_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void set_inertiaTensorRotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Rset_inertiaTensorRotation_Injected_Ref_Quaternion;
		public virtual RMethod Rset_inertiaTensorRotation_Injected_Ref_Quaternion
		{
			get
			{
				if(r_Rset_inertiaTensorRotation_Injected_Ref_Quaternion == null)
				{
					r_Rset_inertiaTensorRotation_Injected_Ref_Quaternion = new(this, "set_inertiaTensorRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Rset_inertiaTensorRotation_Injected_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_Rset_inertiaTensorRotation_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void get_inertiaTensor_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_inertiaTensor_Injected_Out_Vector3;
		public virtual RMethod Rget_inertiaTensor_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_inertiaTensor_Injected_Out_Vector3 == null)
				{
					r_Rget_inertiaTensor_Injected_Out_Vector3 = new(this, "get_inertiaTensor_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_inertiaTensor_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_inertiaTensor_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_inertiaTensor_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_inertiaTensor_Injected_Ref_Vector3;
		public virtual RMethod Rset_inertiaTensor_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_inertiaTensor_Injected_Ref_Vector3 == null)
				{
					r_Rset_inertiaTensor_Injected_Ref_Vector3 = new(this, "set_inertiaTensor_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_inertiaTensor_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_inertiaTensor_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_position_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_position_Injected_Out_Vector3;
		public virtual RMethod Rget_position_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_position_Injected_Out_Vector3 == null)
				{
					r_Rget_position_Injected_Out_Vector3 = new(this, "get_position_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_position_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_position_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_position_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_position_Injected_Ref_Vector3;
		public virtual RMethod Rset_position_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_position_Injected_Ref_Vector3 == null)
				{
					r_Rset_position_Injected_Ref_Vector3 = new(this, "set_position_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_position_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_position_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void get_rotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Rget_rotation_Injected_Out_Quaternion;
		public virtual RMethod Rget_rotation_Injected_Out_Quaternion
		{
			get
			{
				if(r_Rget_rotation_Injected_Out_Quaternion == null)
				{
					r_Rget_rotation_Injected_Out_Quaternion = new(this, "get_rotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Rget_rotation_Injected_Out_Quaternion.SetBelong(this.instance);
				}
				return r_Rget_rotation_Injected_Out_Quaternion;
			}
		}

		/// <summary>
		/// Void set_rotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_Rset_rotation_Injected_Ref_Quaternion;
		public virtual RMethod Rset_rotation_Injected_Ref_Quaternion
		{
			get
			{
				if(r_Rset_rotation_Injected_Ref_Quaternion == null)
				{
					r_Rset_rotation_Injected_Ref_Quaternion = new(this, "set_rotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_Rset_rotation_Injected_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_Rset_rotation_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void MovePosition_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RMovePosition_Injected_Ref_Vector3;
		public virtual RMethod RMovePosition_Injected_Ref_Vector3
		{
			get
			{
				if(r_RMovePosition_Injected_Ref_Vector3 == null)
				{
					r_RMovePosition_Injected_Ref_Vector3 = new(this, "MovePosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_RMovePosition_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_RMovePosition_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void MoveRotation_Injected(UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_RMoveRotation_Injected_Ref_Quaternion;
		public virtual RMethod RMoveRotation_Injected_Ref_Quaternion
		{
			get
			{
				if(r_RMoveRotation_Injected_Ref_Quaternion == null)
				{
					r_RMoveRotation_Injected_Ref_Quaternion = new(this, "MoveRotation_Injected", 0, typeof(UnityEngine.Quaternion).MakeByRefType());
					r_RMoveRotation_Injected_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_RMoveRotation_Injected_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void Move_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Quaternion ByRef)
		/// </summary>
		protected RMethod r_RMove_Injected_Ref_Vector3_Ref_Quaternion;
		public virtual RMethod RMove_Injected_Ref_Vector3_Ref_Quaternion
		{
			get
			{
				if(r_RMove_Injected_Ref_Vector3_Ref_Quaternion == null)
				{
					r_RMove_Injected_Ref_Vector3_Ref_Quaternion = new(this, "Move_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType());
					r_RMove_Injected_Ref_Vector3_Ref_Quaternion.SetBelong(this.instance);
				}
				return r_RMove_Injected_Ref_Vector3_Ref_Quaternion;
			}
		}

		/// <summary>
		/// Void GetRelativePointVelocity_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RGetRelativePointVelocity_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RGetRelativePointVelocity_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RGetRelativePointVelocity_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_RGetRelativePointVelocity_Injected_Ref_Vector3_Out_Vector3 = new(this, "GetRelativePointVelocity_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RGetRelativePointVelocity_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_RGetRelativePointVelocity_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void GetPointVelocity_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RGetPointVelocity_Injected_Ref_Vector3_Out_Vector3;
		public virtual RMethod RGetPointVelocity_Injected_Ref_Vector3_Out_Vector3
		{
			get
			{
				if(r_RGetPointVelocity_Injected_Ref_Vector3_Out_Vector3 == null)
				{
					r_RGetPointVelocity_Injected_Ref_Vector3_Out_Vector3 = new(this, "GetPointVelocity_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RGetPointVelocity_Injected_Ref_Vector3_Out_Vector3.SetBelong(this.instance);
				}
				return r_RGetPointVelocity_Injected_Ref_Vector3_Out_Vector3;
			}
		}

		/// <summary>
		/// Void get_excludeLayers_Injected(UnityEngine.LayerMask ByRef)
		/// </summary>
		protected RMethod r_Rget_excludeLayers_Injected_Out_LayerMask;
		public virtual RMethod Rget_excludeLayers_Injected_Out_LayerMask
		{
			get
			{
				if(r_Rget_excludeLayers_Injected_Out_LayerMask == null)
				{
					r_Rget_excludeLayers_Injected_Out_LayerMask = new(this, "get_excludeLayers_Injected", 0, typeof(UnityEngine.LayerMask).MakeByRefType());
					r_Rget_excludeLayers_Injected_Out_LayerMask.SetBelong(this.instance);
				}
				return r_Rget_excludeLayers_Injected_Out_LayerMask;
			}
		}

		/// <summary>
		/// Void set_excludeLayers_Injected(UnityEngine.LayerMask ByRef)
		/// </summary>
		protected RMethod r_Rset_excludeLayers_Injected_Ref_LayerMask;
		public virtual RMethod Rset_excludeLayers_Injected_Ref_LayerMask
		{
			get
			{
				if(r_Rset_excludeLayers_Injected_Ref_LayerMask == null)
				{
					r_Rset_excludeLayers_Injected_Ref_LayerMask = new(this, "set_excludeLayers_Injected", 0, typeof(UnityEngine.LayerMask).MakeByRefType());
					r_Rset_excludeLayers_Injected_Ref_LayerMask.SetBelong(this.instance);
				}
				return r_Rset_excludeLayers_Injected_Ref_LayerMask;
			}
		}

		/// <summary>
		/// Void get_includeLayers_Injected(UnityEngine.LayerMask ByRef)
		/// </summary>
		protected RMethod r_Rget_includeLayers_Injected_Out_LayerMask;
		public virtual RMethod Rget_includeLayers_Injected_Out_LayerMask
		{
			get
			{
				if(r_Rget_includeLayers_Injected_Out_LayerMask == null)
				{
					r_Rget_includeLayers_Injected_Out_LayerMask = new(this, "get_includeLayers_Injected", 0, typeof(UnityEngine.LayerMask).MakeByRefType());
					r_Rget_includeLayers_Injected_Out_LayerMask.SetBelong(this.instance);
				}
				return r_Rget_includeLayers_Injected_Out_LayerMask;
			}
		}

		/// <summary>
		/// Void set_includeLayers_Injected(UnityEngine.LayerMask ByRef)
		/// </summary>
		protected RMethod r_Rset_includeLayers_Injected_Ref_LayerMask;
		public virtual RMethod Rset_includeLayers_Injected_Ref_LayerMask
		{
			get
			{
				if(r_Rset_includeLayers_Injected_Ref_LayerMask == null)
				{
					r_Rset_includeLayers_Injected_Ref_LayerMask = new(this, "set_includeLayers_Injected", 0, typeof(UnityEngine.LayerMask).MakeByRefType());
					r_Rset_includeLayers_Injected_Ref_LayerMask.SetBelong(this.instance);
				}
				return r_Rset_includeLayers_Injected_Ref_LayerMask;
			}
		}

		/// <summary>
		/// Void GetAccumulatedForce_Injected(Single, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RGetAccumulatedForce_Injected_Single_Out_Vector3;
		public virtual RMethod RGetAccumulatedForce_Injected_Single_Out_Vector3
		{
			get
			{
				if(r_RGetAccumulatedForce_Injected_Single_Out_Vector3 == null)
				{
					r_RGetAccumulatedForce_Injected_Single_Out_Vector3 = new(this, "GetAccumulatedForce_Injected", 0, typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RGetAccumulatedForce_Injected_Single_Out_Vector3.SetBelong(this.instance);
				}
				return r_RGetAccumulatedForce_Injected_Single_Out_Vector3;
			}
		}

		/// <summary>
		/// Void GetAccumulatedTorque_Injected(Single, UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RGetAccumulatedTorque_Injected_Single_Out_Vector3;
		public virtual RMethod RGetAccumulatedTorque_Injected_Single_Out_Vector3
		{
			get
			{
				if(r_RGetAccumulatedTorque_Injected_Single_Out_Vector3 == null)
				{
					r_RGetAccumulatedTorque_Injected_Single_Out_Vector3 = new(this, "GetAccumulatedTorque_Injected", 0, typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType());
					r_RGetAccumulatedTorque_Injected_Single_Out_Vector3.SetBelong(this.instance);
				}
				return r_RGetAccumulatedTorque_Injected_Single_Out_Vector3;
			}
		}

		/// <summary>
		/// Void AddForce_Injected(UnityEngine.Vector3 ByRef, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddForce_Injected_Ref_Vector3_ForceMode;
		public virtual RMethod RAddForce_Injected_Ref_Vector3_ForceMode
		{
			get
			{
				if(r_RAddForce_Injected_Ref_Vector3_ForceMode == null)
				{
					r_RAddForce_Injected_Ref_Vector3_ForceMode = new(this, "AddForce_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.ForceMode));
					r_RAddForce_Injected_Ref_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddForce_Injected_Ref_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddRelativeForce_Injected(UnityEngine.Vector3 ByRef, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddRelativeForce_Injected_Ref_Vector3_ForceMode;
		public virtual RMethod RAddRelativeForce_Injected_Ref_Vector3_ForceMode
		{
			get
			{
				if(r_RAddRelativeForce_Injected_Ref_Vector3_ForceMode == null)
				{
					r_RAddRelativeForce_Injected_Ref_Vector3_ForceMode = new(this, "AddRelativeForce_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.ForceMode));
					r_RAddRelativeForce_Injected_Ref_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddRelativeForce_Injected_Ref_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddTorque_Injected(UnityEngine.Vector3 ByRef, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddTorque_Injected_Ref_Vector3_ForceMode;
		public virtual RMethod RAddTorque_Injected_Ref_Vector3_ForceMode
		{
			get
			{
				if(r_RAddTorque_Injected_Ref_Vector3_ForceMode == null)
				{
					r_RAddTorque_Injected_Ref_Vector3_ForceMode = new(this, "AddTorque_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.ForceMode));
					r_RAddTorque_Injected_Ref_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddTorque_Injected_Ref_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddRelativeTorque_Injected(UnityEngine.Vector3 ByRef, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddRelativeTorque_Injected_Ref_Vector3_ForceMode;
		public virtual RMethod RAddRelativeTorque_Injected_Ref_Vector3_ForceMode
		{
			get
			{
				if(r_RAddRelativeTorque_Injected_Ref_Vector3_ForceMode == null)
				{
					r_RAddRelativeTorque_Injected_Ref_Vector3_ForceMode = new(this, "AddRelativeTorque_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.ForceMode));
					r_RAddRelativeTorque_Injected_Ref_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddRelativeTorque_Injected_Ref_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddForceAtPosition_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddForceAtPosition_Injected_Ref_Vector3_Ref_Vector3_ForceMode;
		public virtual RMethod RAddForceAtPosition_Injected_Ref_Vector3_Ref_Vector3_ForceMode
		{
			get
			{
				if(r_RAddForceAtPosition_Injected_Ref_Vector3_Ref_Vector3_ForceMode == null)
				{
					r_RAddForceAtPosition_Injected_Ref_Vector3_Ref_Vector3_ForceMode = new(this, "AddForceAtPosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.ForceMode));
					r_RAddForceAtPosition_Injected_Ref_Vector3_Ref_Vector3_ForceMode.SetBelong(this.instance);
				}
				return r_RAddForceAtPosition_Injected_Ref_Vector3_Ref_Vector3_ForceMode;
			}
		}

		/// <summary>
		/// Void AddExplosionForce_Injected(Single, UnityEngine.Vector3 ByRef, Single, Single, UnityEngine.ForceMode)
		/// </summary>
		protected RMethod r_RAddExplosionForce_Injected_Single_Ref_Vector3_Single_Single_ForceMode;
		public virtual RMethod RAddExplosionForce_Injected_Single_Ref_Vector3_Single_Single_ForceMode
		{
			get
			{
				if(r_RAddExplosionForce_Injected_Single_Ref_Vector3_Single_Single_ForceMode == null)
				{
					r_RAddExplosionForce_Injected_Single_Ref_Vector3_Single_Single_ForceMode = new(this, "AddExplosionForce_Injected", 0, typeof(System.Single), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(System.Single), typeof(UnityEngine.ForceMode));
					r_RAddExplosionForce_Injected_Single_Ref_Vector3_Single_Single_ForceMode.SetBelong(this.instance);
				}
				return r_RAddExplosionForce_Injected_Single_Ref_Vector3_Single_Single_ForceMode;
			}
		}

		/// <summary>
		/// Void Internal_ClosestPointOnBounds_Injected(UnityEngine.Vector3 ByRef, UnityEngine.Vector3 ByRef, Single ByRef)
		/// </summary>
		protected RMethod r_RInternal_ClosestPointOnBounds_Injected_Ref_Vector3_Ref_Vector3_Ref_Single;
		public virtual RMethod RInternal_ClosestPointOnBounds_Injected_Ref_Vector3_Ref_Vector3_Ref_Single
		{
			get
			{
				if(r_RInternal_ClosestPointOnBounds_Injected_Ref_Vector3_Ref_Vector3_Ref_Single == null)
				{
					r_RInternal_ClosestPointOnBounds_Injected_Ref_Vector3_Ref_Vector3_Ref_Single = new(this, "Internal_ClosestPointOnBounds_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single).MakeByRefType());
					r_RInternal_ClosestPointOnBounds_Injected_Ref_Vector3_Ref_Vector3_Ref_Single.SetBelong(this.instance);
				}
				return r_RInternal_ClosestPointOnBounds_Injected_Ref_Vector3_Ref_Vector3_Ref_Single;
			}
		}

		/// <summary>
		/// Void SweepTest_Injected(UnityEngine.Vector3 ByRef, Single, UnityEngine.QueryTriggerInteraction, Boolean ByRef, UnityEngine.RaycastHit ByRef)
		/// </summary>
		protected RMethod r_RSweepTest_Injected_Ref_Vector3_Single_QueryTriggerInteraction_Ref_Boolean_Out_RaycastHit;
		public virtual RMethod RSweepTest_Injected_Ref_Vector3_Single_QueryTriggerInteraction_Ref_Boolean_Out_RaycastHit
		{
			get
			{
				if(r_RSweepTest_Injected_Ref_Vector3_Single_QueryTriggerInteraction_Ref_Boolean_Out_RaycastHit == null)
				{
					r_RSweepTest_Injected_Ref_Vector3_Single_QueryTriggerInteraction_Ref_Boolean_Out_RaycastHit = new(this, "SweepTest_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.QueryTriggerInteraction), typeof(System.Boolean).MakeByRefType(), typeof(UnityEngine.RaycastHit).MakeByRefType());
					r_RSweepTest_Injected_Ref_Vector3_Single_QueryTriggerInteraction_Ref_Boolean_Out_RaycastHit.SetBelong(this.instance);
				}
				return r_RSweepTest_Injected_Ref_Vector3_Single_QueryTriggerInteraction_Ref_Boolean_Out_RaycastHit;
			}
		}

		/// <summary>
		/// UnityEngine.RaycastHit[] Internal_SweepTestAll_Injected(UnityEngine.Vector3 ByRef, Single, UnityEngine.QueryTriggerInteraction)
		/// </summary>
		protected RMethod r_RInternal_SweepTestAll_Injected_Ref_Vector3_Single_QueryTriggerInteraction;
		public virtual RMethod RInternal_SweepTestAll_Injected_Ref_Vector3_Single_QueryTriggerInteraction
		{
			get
			{
				if(r_RInternal_SweepTestAll_Injected_Ref_Vector3_Single_QueryTriggerInteraction == null)
				{
					r_RInternal_SweepTestAll_Injected_Ref_Vector3_Single_QueryTriggerInteraction = new(this, "Internal_SweepTestAll_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.Single), typeof(UnityEngine.QueryTriggerInteraction));
					r_RInternal_SweepTestAll_Injected_Ref_Vector3_Single_QueryTriggerInteraction.SetBelong(this.instance);
				}
				return r_RInternal_SweepTestAll_Injected_Ref_Vector3_Single_QueryTriggerInteraction;
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


        public RRigidbody() : base("UnityEngine.Rigidbody")
        {
        }

        public RRigidbody(System.Object instance) : base("UnityEngine.Rigidbody")
		{
            SetInstance(instance);
		}

        public RRigidbody(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRigidbody(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetDensity(System.Single  @density)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@density};
            var ___result = RSetDensity_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MovePosition(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMovePosition_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveRotation(UnityEngine.Quaternion  @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rot};
            var ___result = RMoveRotation_Quaternion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Move(UnityEngine.Vector3  @position, UnityEngine.Quaternion  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @rotation};
            var ___result = RMove_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Sleep()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSleep.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsSleeping()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsSleeping.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void WakeUp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWakeUp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetCenterOfMass()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetCenterOfMass.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ResetInertiaTensor()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetInertiaTensor.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 GetRelativePointVelocity(UnityEngine.Vector3  @relativePoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativePoint};
            var ___result = RGetRelativePointVelocity_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 GetPointVelocity(UnityEngine.Vector3  @worldPoint)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPoint};
            var ___result = RGetPointVelocity_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 GetAccumulatedForce(System.Single  @step)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@step};
            var ___result = RGetAccumulatedForce_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 GetAccumulatedForce()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAccumulatedForce.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 GetAccumulatedTorque(System.Single  @step)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@step};
            var ___result = RGetAccumulatedTorque_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 GetAccumulatedTorque()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAccumulatedTorque.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void AddForce(UnityEngine.Vector3  @force, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force, @mode};
            var ___result = RAddForce_Vector3_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddForce(UnityEngine.Vector3  @force)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force};
            var ___result = RAddForce_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddForce(System.Single  @x, System.Single  @y, System.Single  @z, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z, @mode};
            var ___result = RAddForce_Single_Single_Single_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddForce(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RAddForce_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRelativeForce(UnityEngine.Vector3  @force, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force, @mode};
            var ___result = RAddRelativeForce_Vector3_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRelativeForce(UnityEngine.Vector3  @force)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force};
            var ___result = RAddRelativeForce_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRelativeForce(System.Single  @x, System.Single  @y, System.Single  @z, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z, @mode};
            var ___result = RAddRelativeForce_Single_Single_Single_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRelativeForce(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RAddRelativeForce_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddTorque(UnityEngine.Vector3  @torque, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@torque, @mode};
            var ___result = RAddTorque_Vector3_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddTorque(UnityEngine.Vector3  @torque)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@torque};
            var ___result = RAddTorque_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddTorque(System.Single  @x, System.Single  @y, System.Single  @z, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z, @mode};
            var ___result = RAddTorque_Single_Single_Single_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddTorque(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RAddTorque_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRelativeTorque(UnityEngine.Vector3  @torque, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@torque, @mode};
            var ___result = RAddRelativeTorque_Vector3_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRelativeTorque(UnityEngine.Vector3  @torque)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@torque};
            var ___result = RAddRelativeTorque_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRelativeTorque(System.Single  @x, System.Single  @y, System.Single  @z, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z, @mode};
            var ___result = RAddRelativeTorque_Single_Single_Single_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddRelativeTorque(System.Single  @x, System.Single  @y, System.Single  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RAddRelativeTorque_Single_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddForceAtPosition(UnityEngine.Vector3  @force, UnityEngine.Vector3  @position, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force, @position, @mode};
            var ___result = RAddForceAtPosition_Vector3_Vector3_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddForceAtPosition(UnityEngine.Vector3  @force, UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force, @position};
            var ___result = RAddForceAtPosition_Vector3_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddExplosionForce(System.Single  @explosionForce, UnityEngine.Vector3  @explosionPosition, System.Single  @explosionRadius, System.Single  @upwardsModifier, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@explosionForce, @explosionPosition, @explosionRadius, @upwardsModifier, @mode};
            var ___result = RAddExplosionForce_Single_Vector3_Single_Single_ForceMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddExplosionForce(System.Single  @explosionForce, UnityEngine.Vector3  @explosionPosition, System.Single  @explosionRadius, System.Single  @upwardsModifier)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@explosionForce, @explosionPosition, @explosionRadius, @upwardsModifier};
            var ___result = RAddExplosionForce_Single_Vector3_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddExplosionForce(System.Single  @explosionForce, UnityEngine.Vector3  @explosionPosition, System.Single  @explosionRadius)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@explosionForce, @explosionPosition, @explosionRadius};
            var ___result = RAddExplosionForce_Single_Vector3_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_ClosestPointOnBounds(UnityEngine.Vector3  @point, ref UnityEngine.Vector3  @outPos, ref System.Single  @distance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @outPos, @distance};
            var ___result = RInternal_ClosestPointOnBounds_Vector3_Ref_Vector3_Ref_Single.Invoke(___genericsType, ___parameters);
			outPos = (UnityEngine.Vector3)___parameters[1];
			distance = (System.Single)___parameters[2];

            
        }


        public virtual UnityEngine.Vector3 ClosestPointOnBounds(UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RClosestPointOnBounds_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.RaycastHit SweepTest(UnityEngine.Vector3  @direction, System.Single  @maxDistance, UnityEngine.QueryTriggerInteraction  @queryTriggerInteraction, ref System.Boolean  @hasHit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @maxDistance, @queryTriggerInteraction, @hasHit};
            var ___result = RSweepTest_Vector3_Single_QueryTriggerInteraction_Ref_Boolean.Invoke(___genericsType, ___parameters);
			hasHit = (System.Boolean)___parameters[3];

            return (UnityEngine.RaycastHit)___result;
        }


        public virtual System.Boolean SweepTest(UnityEngine.Vector3  @direction, out UnityEngine.RaycastHit  @hitInfo, System.Single  @maxDistance, UnityEngine.QueryTriggerInteraction  @queryTriggerInteraction)
        {
			hitInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @hitInfo, @maxDistance, @queryTriggerInteraction};
            var ___result = RSweepTest_Vector3_Out_RaycastHit_Single_QueryTriggerInteraction.Invoke(___genericsType, ___parameters);
			hitInfo = (UnityEngine.RaycastHit)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SweepTest(UnityEngine.Vector3  @direction, out UnityEngine.RaycastHit  @hitInfo, System.Single  @maxDistance)
        {
			hitInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @hitInfo, @maxDistance};
            var ___result = RSweepTest_Vector3_Out_RaycastHit_Single.Invoke(___genericsType, ___parameters);
			hitInfo = (UnityEngine.RaycastHit)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean SweepTest(UnityEngine.Vector3  @direction, out UnityEngine.RaycastHit  @hitInfo)
        {
			hitInfo = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @hitInfo};
            var ___result = RSweepTest_Vector3_Out_RaycastHit.Invoke(___genericsType, ___parameters);
			hitInfo = (UnityEngine.RaycastHit)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.RaycastHit[] Internal_SweepTestAll(UnityEngine.Vector3  @direction, System.Single  @maxDistance, UnityEngine.QueryTriggerInteraction  @queryTriggerInteraction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @maxDistance, @queryTriggerInteraction};
            var ___result = RInternal_SweepTestAll_Vector3_Single_QueryTriggerInteraction.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RaycastHit[])___result;
        }


        public virtual UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3  @direction, System.Single  @maxDistance, UnityEngine.QueryTriggerInteraction  @queryTriggerInteraction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @maxDistance, @queryTriggerInteraction};
            var ___result = RSweepTestAll_Vector3_Single_QueryTriggerInteraction.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RaycastHit[])___result;
        }


        public virtual UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3  @direction, System.Single  @maxDistance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @maxDistance};
            var ___result = RSweepTestAll_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RaycastHit[])___result;
        }


        public virtual UnityEngine.RaycastHit[] SweepTestAll(UnityEngine.Vector3  @direction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction};
            var ___result = RSweepTestAll_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RaycastHit[])___result;
        }


        public virtual void SetMaxAngularVelocity(System.Single  @a)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a};
            var ___result = RSetMaxAngularVelocity_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_velocity_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_velocity_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_velocity_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_velocity_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_angularVelocity_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_angularVelocity_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_angularVelocity_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_angularVelocity_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_centerOfMass_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_centerOfMass_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_centerOfMass_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_centerOfMass_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_worldCenterOfMass_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_worldCenterOfMass_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_inertiaTensorRotation_Injected(out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_inertiaTensorRotation_Injected_Out_Quaternion.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void set_inertiaTensorRotation_Injected(ref UnityEngine.Quaternion  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_inertiaTensorRotation_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void get_inertiaTensor_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_inertiaTensor_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_inertiaTensor_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_inertiaTensor_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_position_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_position_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_position_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_position_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void get_rotation_Injected(out UnityEngine.Quaternion  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_rotation_Injected_Out_Quaternion.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void set_rotation_Injected(ref UnityEngine.Quaternion  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_rotation_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void MovePosition_Injected(ref UnityEngine.Vector3  @position)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position};
            var ___result = RMovePosition_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void MoveRotation_Injected(ref UnityEngine.Quaternion  @rot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rot};
            var ___result = RMoveRotation_Injected_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			rot = (UnityEngine.Quaternion)___parameters[0];

            
        }


        public virtual void Move_Injected(ref UnityEngine.Vector3  @position, ref UnityEngine.Quaternion  @rotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @rotation};
            var ___result = RMove_Injected_Ref_Vector3_Ref_Quaternion.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Vector3)___parameters[0];
			rotation = (UnityEngine.Quaternion)___parameters[1];

            
        }


        public virtual void GetRelativePointVelocity_Injected(ref UnityEngine.Vector3  @relativePoint, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativePoint, @ret};
            var ___result = RGetRelativePointVelocity_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			relativePoint = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void GetPointVelocity_Injected(ref UnityEngine.Vector3  @worldPoint, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPoint, @ret};
            var ___result = RGetPointVelocity_Injected_Ref_Vector3_Out_Vector3.Invoke(___genericsType, ___parameters);
			worldPoint = (UnityEngine.Vector3)___parameters[0];
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void get_excludeLayers_Injected(out UnityEngine.LayerMask  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_excludeLayers_Injected_Out_LayerMask.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.LayerMask)___parameters[0];

            
        }


        public virtual void set_excludeLayers_Injected(ref UnityEngine.LayerMask  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_excludeLayers_Injected_Ref_LayerMask.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.LayerMask)___parameters[0];

            
        }


        public virtual void get_includeLayers_Injected(out UnityEngine.LayerMask  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_includeLayers_Injected_Out_LayerMask.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.LayerMask)___parameters[0];

            
        }


        public virtual void set_includeLayers_Injected(ref UnityEngine.LayerMask  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_includeLayers_Injected_Ref_LayerMask.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.LayerMask)___parameters[0];

            
        }


        public virtual void GetAccumulatedForce_Injected(System.Single  @step, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@step, @ret};
            var ___result = RGetAccumulatedForce_Injected_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void GetAccumulatedTorque_Injected(System.Single  @step, out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@step, @ret};
            var ___result = RGetAccumulatedTorque_Injected_Single_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void AddForce_Injected(ref UnityEngine.Vector3  @force, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force, @mode};
            var ___result = RAddForce_Injected_Ref_Vector3_ForceMode.Invoke(___genericsType, ___parameters);
			force = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void AddRelativeForce_Injected(ref UnityEngine.Vector3  @force, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force, @mode};
            var ___result = RAddRelativeForce_Injected_Ref_Vector3_ForceMode.Invoke(___genericsType, ___parameters);
			force = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void AddTorque_Injected(ref UnityEngine.Vector3  @torque, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@torque, @mode};
            var ___result = RAddTorque_Injected_Ref_Vector3_ForceMode.Invoke(___genericsType, ___parameters);
			torque = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void AddRelativeTorque_Injected(ref UnityEngine.Vector3  @torque, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@torque, @mode};
            var ___result = RAddRelativeTorque_Injected_Ref_Vector3_ForceMode.Invoke(___genericsType, ___parameters);
			torque = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void AddForceAtPosition_Injected(ref UnityEngine.Vector3  @force, ref UnityEngine.Vector3  @position, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@force, @position, @mode};
            var ___result = RAddForceAtPosition_Injected_Ref_Vector3_Ref_Vector3_ForceMode.Invoke(___genericsType, ___parameters);
			force = (UnityEngine.Vector3)___parameters[0];
			position = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void AddExplosionForce_Injected(System.Single  @explosionForce, ref UnityEngine.Vector3  @explosionPosition, System.Single  @explosionRadius, System.Single  @upwardsModifier, UnityEngine.ForceMode  @mode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@explosionForce, @explosionPosition, @explosionRadius, @upwardsModifier, @mode};
            var ___result = RAddExplosionForce_Injected_Single_Ref_Vector3_Single_Single_ForceMode.Invoke(___genericsType, ___parameters);
			explosionPosition = (UnityEngine.Vector3)___parameters[1];

            
        }


        public virtual void Internal_ClosestPointOnBounds_Injected(ref UnityEngine.Vector3  @point, ref UnityEngine.Vector3  @outPos, ref System.Single  @distance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point, @outPos, @distance};
            var ___result = RInternal_ClosestPointOnBounds_Injected_Ref_Vector3_Ref_Vector3_Ref_Single.Invoke(___genericsType, ___parameters);
			point = (UnityEngine.Vector3)___parameters[0];
			outPos = (UnityEngine.Vector3)___parameters[1];
			distance = (System.Single)___parameters[2];

            
        }


        public virtual void SweepTest_Injected(ref UnityEngine.Vector3  @direction, System.Single  @maxDistance, UnityEngine.QueryTriggerInteraction  @queryTriggerInteraction, ref System.Boolean  @hasHit, out UnityEngine.RaycastHit  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @maxDistance, @queryTriggerInteraction, @hasHit, @ret};
            var ___result = RSweepTest_Injected_Ref_Vector3_Single_QueryTriggerInteraction_Ref_Boolean_Out_RaycastHit.Invoke(___genericsType, ___parameters);
			direction = (UnityEngine.Vector3)___parameters[0];
			hasHit = (System.Boolean)___parameters[3];
			ret = (UnityEngine.RaycastHit)___parameters[4];

            
        }


        public virtual UnityEngine.RaycastHit[] Internal_SweepTestAll_Injected(ref UnityEngine.Vector3  @direction, System.Single  @maxDistance, UnityEngine.QueryTriggerInteraction  @queryTriggerInteraction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@direction, @maxDistance, @queryTriggerInteraction};
            var ___result = RInternal_SweepTestAll_Injected_Ref_Vector3_Single_QueryTriggerInteraction.Invoke(___genericsType, ___parameters);
			direction = (UnityEngine.Vector3)___parameters[0];

            return (UnityEngine.RaycastHit[])___result;
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
