using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RiTween
{
	
	/// <summary>
	/// iTween+Arguments
	/// </summary>
    public partial class RArguments : RMember //
    {

		/// <summary>
		/// System.Single time
		/// </summary>
		protected RField r_time;
		public virtual RField Rtime
		{
			get
			{
				if(r_time == null)
				{
					r_time = new(this, "time");
					r_time.SetBelong(this.instance);
				}
				return r_time;
			}
		}

		/// <summary>
		/// System.Single delay
		/// </summary>
		protected RField r_delay;
		public virtual RField Rdelay
		{
			get
			{
				if(r_delay == null)
				{
					r_delay = new(this, "delay");
					r_delay.SetBelong(this.instance);
				}
				return r_delay;
			}
		}

		/// <summary>
		/// iTween+EasingType transition
		/// </summary>
		protected RField r_transition;
		public virtual RField Rtransition
		{
			get
			{
				if(r_transition == null)
				{
					r_transition = new(this, "transition");
					r_transition.SetBelong(this.instance);
				}
				return r_transition;
			}
		}

		/// <summary>
		/// System.Boolean isXRSet
		/// </summary>
		protected RField r_isXRSet;
		public virtual RField RisXRSet
		{
			get
			{
				if(r_isXRSet == null)
				{
					r_isXRSet = new(this, "isXRSet");
					r_isXRSet.SetBelong(this.instance);
				}
				return r_isXRSet;
			}
		}

		/// <summary>
		/// System.Boolean isYGSet
		/// </summary>
		protected RField r_isYGSet;
		public virtual RField RisYGSet
		{
			get
			{
				if(r_isYGSet == null)
				{
					r_isYGSet = new(this, "isYGSet");
					r_isYGSet.SetBelong(this.instance);
				}
				return r_isYGSet;
			}
		}

		/// <summary>
		/// System.Boolean isZBSet
		/// </summary>
		protected RField r_isZBSet;
		public virtual RField RisZBSet
		{
			get
			{
				if(r_isZBSet == null)
				{
					r_isZBSet = new(this, "isZBSet");
					r_isZBSet.SetBelong(this.instance);
				}
				return r_isZBSet;
			}
		}

		/// <summary>
		/// System.Single xr
		/// </summary>
		protected RField r_xr;
		public virtual RField Rxr
		{
			get
			{
				if(r_xr == null)
				{
					r_xr = new(this, "xr");
					r_xr.SetBelong(this.instance);
				}
				return r_xr;
			}
		}

		/// <summary>
		/// System.Single yg
		/// </summary>
		protected RField r_yg;
		public virtual RField Ryg
		{
			get
			{
				if(r_yg == null)
				{
					r_yg = new(this, "yg");
					r_yg.SetBelong(this.instance);
				}
				return r_yg;
			}
		}

		/// <summary>
		/// System.Single zb
		/// </summary>
		protected RField r_zb;
		public virtual RField Rzb
		{
			get
			{
				if(r_zb == null)
				{
					r_zb = new(this, "zb");
					r_zb.SetBelong(this.instance);
				}
				return r_zb;
			}
		}

		/// <summary>
		/// System.Single alpha
		/// </summary>
		protected RField r_alpha;
		public virtual RField Ralpha
		{
			get
			{
				if(r_alpha == null)
				{
					r_alpha = new(this, "alpha");
					r_alpha.SetBelong(this.instance);
				}
				return r_alpha;
			}
		}

		/// <summary>
		/// System.Single volume
		/// </summary>
		protected RField r_volume;
		public virtual RField Rvolume
		{
			get
			{
				if(r_volume == null)
				{
					r_volume = new(this, "volume");
					r_volume.SetBelong(this.instance);
				}
				return r_volume;
			}
		}

		/// <summary>
		/// System.Single pitch
		/// </summary>
		protected RField r_pitch;
		public virtual RField Rpitch
		{
			get
			{
				if(r_pitch == null)
				{
					r_pitch = new(this, "pitch");
					r_pitch.SetBelong(this.instance);
				}
				return r_pitch;
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
					r_clip = new(this, "clip");
					r_clip.SetBelong(this.instance);
				}
				return r_clip;
			}
		}

		/// <summary>
		/// UnityEngine.AudioSource audioSource
		/// </summary>
		protected RUnityEngine.RAudioSource r_audioSource;
		public virtual RUnityEngine.RAudioSource RaudioSource
		{
			get
			{
				if(r_audioSource == null)
				{
					r_audioSource = new(this, "audioSource");
					r_audioSource.SetBelong(this.instance);
				}
				return r_audioSource;
			}
		}

		/// <summary>
		/// System.String onComplete
		/// </summary>
		protected RField r_onComplete;
		public virtual RField RonComplete
		{
			get
			{
				if(r_onComplete == null)
				{
					r_onComplete = new(this, "onComplete");
					r_onComplete.SetBelong(this.instance);
				}
				return r_onComplete;
			}
		}

		/// <summary>
		/// System.Object onComplete_params
		/// </summary>
		protected RSystem.RObject r_onComplete_params;
		public virtual RSystem.RObject RonComplete_params
		{
			get
			{
				if(r_onComplete_params == null)
				{
					r_onComplete_params = new(this, "onComplete_params");
					r_onComplete_params.SetBelong(this.instance);
				}
				return r_onComplete_params;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject onComplete_target
		/// </summary>
		protected RUnityEngine.RGameObject r_onComplete_target;
		public virtual RUnityEngine.RGameObject RonComplete_target
		{
			get
			{
				if(r_onComplete_target == null)
				{
					r_onComplete_target = new(this, "onComplete_target");
					r_onComplete_target.SetBelong(this.instance);
				}
				return r_onComplete_target;
			}
		}

		/// <summary>
		/// System.String onStart
		/// </summary>
		protected RField r_onStart;
		public virtual RField RonStart
		{
			get
			{
				if(r_onStart == null)
				{
					r_onStart = new(this, "onStart");
					r_onStart.SetBelong(this.instance);
				}
				return r_onStart;
			}
		}

		/// <summary>
		/// System.Object onStart_params
		/// </summary>
		protected RSystem.RObject r_onStart_params;
		public virtual RSystem.RObject RonStart_params
		{
			get
			{
				if(r_onStart_params == null)
				{
					r_onStart_params = new(this, "onStart_params");
					r_onStart_params.SetBelong(this.instance);
				}
				return r_onStart_params;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject onStart_target
		/// </summary>
		protected RUnityEngine.RGameObject r_onStart_target;
		public virtual RUnityEngine.RGameObject RonStart_target
		{
			get
			{
				if(r_onStart_target == null)
				{
					r_onStart_target = new(this, "onStart_target");
					r_onStart_target.SetBelong(this.instance);
				}
				return r_onStart_target;
			}
		}

		/// <summary>
		/// System.String onUpdate
		/// </summary>
		protected RField r_onUpdate;
		public virtual RField RonUpdate
		{
			get
			{
				if(r_onUpdate == null)
				{
					r_onUpdate = new(this, "onUpdate");
					r_onUpdate.SetBelong(this.instance);
				}
				return r_onUpdate;
			}
		}

		/// <summary>
		/// System.Object onUpdate_params
		/// </summary>
		protected RSystem.RObject r_onUpdate_params;
		public virtual RSystem.RObject RonUpdate_params
		{
			get
			{
				if(r_onUpdate_params == null)
				{
					r_onUpdate_params = new(this, "onUpdate_params");
					r_onUpdate_params.SetBelong(this.instance);
				}
				return r_onUpdate_params;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject onUpdate_target
		/// </summary>
		protected RUnityEngine.RGameObject r_onUpdate_target;
		public virtual RUnityEngine.RGameObject RonUpdate_target
		{
			get
			{
				if(r_onUpdate_target == null)
				{
					r_onUpdate_target = new(this, "onUpdate_target");
					r_onUpdate_target.SetBelong(this.instance);
				}
				return r_onUpdate_target;
			}
		}

		/// <summary>
		/// iTween+FunctionType type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// System.Boolean isReverse
		/// </summary>
		protected RField r_isReverse;
		public virtual RField RisReverse
		{
			get
			{
				if(r_isReverse == null)
				{
					r_isReverse = new(this, "isReverse");
					r_isReverse.SetBelong(this.instance);
				}
				return r_isReverse;
			}
		}

		/// <summary>
		/// System.Boolean isBy
		/// </summary>
		protected RField r_isBy;
		public virtual RField RisBy
		{
			get
			{
				if(r_isBy == null)
				{
					r_isBy = new(this, "isBy");
					r_isBy.SetBelong(this.instance);
				}
				return r_isBy;
			}
		}

		/// <summary>
		/// System.Boolean isWorld
		/// </summary>
		protected RField r_isWorld;
		public virtual RField RisWorld
		{
			get
			{
				if(r_isWorld == null)
				{
					r_isWorld = new(this, "isWorld");
					r_isWorld.SetBelong(this.instance);
				}
				return r_isWorld;
			}
		}

		/// <summary>
		/// System.Boolean isBezier
		/// </summary>
		protected RField r_isBezier;
		public virtual RField RisBezier
		{
			get
			{
				if(r_isBezier == null)
				{
					r_isBezier = new(this, "isBezier");
					r_isBezier.SetBelong(this.instance);
				}
				return r_isBezier;
			}
		}

		/// <summary>
		/// System.Boolean isMultiply
		/// </summary>
		protected RField r_isMultiply;
		public virtual RField RisMultiply
		{
			get
			{
				if(r_isMultiply == null)
				{
					r_isMultiply = new(this, "isMultiply");
					r_isMultiply.SetBelong(this.instance);
				}
				return r_isMultiply;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.Vector3] beziers
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RVector3> r_beziers;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RVector3> Rbeziers
		{
			get
			{
				if(r_beziers == null)
				{
					r_beziers = new(this, "beziers");
					r_beziers.SetBelong(this.instance);
				}
				return r_beziers;
			}
		}

		/// <summary>
		/// iTween+LoopType loopType
		/// </summary>
		protected RField r_loopType;
		public virtual RField RloopType
		{
			get
			{
				if(r_loopType == null)
				{
					r_loopType = new(this, "loopType");
					r_loopType.SetBelong(this.instance);
				}
				return r_loopType;
			}
		}

		/// <summary>
		/// System.Nullable`1[UnityEngine.Vector3] lookAt
		/// </summary>
		protected RField r_lookAt;
		public virtual RField RlookAt
		{
			get
			{
				if(r_lookAt == null)
				{
					r_lookAt = new(this, "lookAt");
					r_lookAt.SetBelong(this.instance);
				}
				return r_lookAt;
			}
		}

		/// <summary>
		/// System.Boolean orientToPath
		/// </summary>
		protected RField r_orientToPath;
		public virtual RField RorientToPath
		{
			get
			{
				if(r_orientToPath == null)
				{
					r_orientToPath = new(this, "orientToPath");
					r_orientToPath.SetBelong(this.instance);
				}
				return r_orientToPath;
			}
		}

		/// <summary>
		/// System.Boolean includeChildren
		/// </summary>
		protected RField r_includeChildren;
		public virtual RField RincludeChildren
		{
			get
			{
				if(r_includeChildren == null)
				{
					r_includeChildren = new(this, "includeChildren");
					r_includeChildren.SetBelong(this.instance);
				}
				return r_includeChildren;
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
					r_transform = new(this, "transform");
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// UnityEngine.Space space
		/// </summary>
		protected RField r_space;
		public virtual RField Rspace
		{
			get
			{
				if(r_space == null)
				{
					r_space = new(this, "space");
					r_space.SetBelong(this.instance);
				}
				return r_space;
			}
		}

		/// <summary>
		/// iTween+AxisType axis
		/// </summary>
		protected RField r_axis;
		public virtual RField Raxis
		{
			get
			{
				if(r_axis == null)
				{
					r_axis = new(this, "axis");
					r_axis.SetBelong(this.instance);
				}
				return r_axis;
			}
		}

		/// <summary>
		/// System.Single lookSpeed
		/// </summary>
		protected RField r_lookSpeed;
		public virtual RField RlookSpeed
		{
			get
			{
				if(r_lookSpeed == null)
				{
					r_lookSpeed = new(this, "lookSpeed");
					r_lookSpeed.SetBelong(this.instance);
				}
				return r_lookSpeed;
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


        public RArguments() : base("iTween+Arguments")
        {
        }

        public RArguments(System.Object instance) : base("iTween+Arguments")
		{
            SetInstance(instance);
		}

        public RArguments(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RArguments(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
}