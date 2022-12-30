using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AnimationClip
	/// </summary>
    public partial class RAnimationClip : RMember //
    {

		/// <summary>
		/// Single length
		/// </summary>
		protected RProperty r_length;
		public virtual RProperty Rlength
		{
			get
			{
				if(r_length == null)
				{
					r_length = new(this, "length", -1);
					r_length.SetBelong(this.instance);
				}
				return r_length;
			}
		}

		/// <summary>
		/// Single startTime
		/// </summary>
		protected RProperty r_startTime;
		public virtual RProperty RstartTime
		{
			get
			{
				if(r_startTime == null)
				{
					r_startTime = new(this, "startTime", -1);
					r_startTime.SetBelong(this.instance);
				}
				return r_startTime;
			}
		}

		/// <summary>
		/// Single stopTime
		/// </summary>
		protected RProperty r_stopTime;
		public virtual RProperty RstopTime
		{
			get
			{
				if(r_stopTime == null)
				{
					r_stopTime = new(this, "stopTime", -1);
					r_stopTime.SetBelong(this.instance);
				}
				return r_stopTime;
			}
		}

		/// <summary>
		/// Single frameRate
		/// </summary>
		protected RProperty r_frameRate;
		public virtual RProperty RframeRate
		{
			get
			{
				if(r_frameRate == null)
				{
					r_frameRate = new(this, "frameRate", -1);
					r_frameRate.SetBelong(this.instance);
				}
				return r_frameRate;
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
		/// Boolean legacy
		/// </summary>
		protected RProperty r_legacy;
		public virtual RProperty Rlegacy
		{
			get
			{
				if(r_legacy == null)
				{
					r_legacy = new(this, "legacy", -1);
					r_legacy.SetBelong(this.instance);
				}
				return r_legacy;
			}
		}

		/// <summary>
		/// Boolean humanMotion
		/// </summary>
		protected RProperty r_humanMotion;
		public virtual RProperty RhumanMotion
		{
			get
			{
				if(r_humanMotion == null)
				{
					r_humanMotion = new(this, "humanMotion", -1);
					r_humanMotion.SetBelong(this.instance);
				}
				return r_humanMotion;
			}
		}

		/// <summary>
		/// Boolean empty
		/// </summary>
		protected RProperty r_empty;
		public virtual RProperty Rempty
		{
			get
			{
				if(r_empty == null)
				{
					r_empty = new(this, "empty", -1);
					r_empty.SetBelong(this.instance);
				}
				return r_empty;
			}
		}

		/// <summary>
		/// Boolean hasGenericRootTransform
		/// </summary>
		protected RProperty r_hasGenericRootTransform;
		public virtual RProperty RhasGenericRootTransform
		{
			get
			{
				if(r_hasGenericRootTransform == null)
				{
					r_hasGenericRootTransform = new(this, "hasGenericRootTransform", -1);
					r_hasGenericRootTransform.SetBelong(this.instance);
				}
				return r_hasGenericRootTransform;
			}
		}

		/// <summary>
		/// Boolean hasMotionFloatCurves
		/// </summary>
		protected RProperty r_hasMotionFloatCurves;
		public virtual RProperty RhasMotionFloatCurves
		{
			get
			{
				if(r_hasMotionFloatCurves == null)
				{
					r_hasMotionFloatCurves = new(this, "hasMotionFloatCurves", -1);
					r_hasMotionFloatCurves.SetBelong(this.instance);
				}
				return r_hasMotionFloatCurves;
			}
		}

		/// <summary>
		/// Boolean hasMotionCurves
		/// </summary>
		protected RProperty r_hasMotionCurves;
		public virtual RProperty RhasMotionCurves
		{
			get
			{
				if(r_hasMotionCurves == null)
				{
					r_hasMotionCurves = new(this, "hasMotionCurves", -1);
					r_hasMotionCurves.SetBelong(this.instance);
				}
				return r_hasMotionCurves;
			}
		}

		/// <summary>
		/// Boolean hasRootCurves
		/// </summary>
		protected RProperty r_hasRootCurves;
		public virtual RProperty RhasRootCurves
		{
			get
			{
				if(r_hasRootCurves == null)
				{
					r_hasRootCurves = new(this, "hasRootCurves", -1);
					r_hasRootCurves.SetBelong(this.instance);
				}
				return r_hasRootCurves;
			}
		}

		/// <summary>
		/// Boolean hasRootMotion
		/// </summary>
		protected RProperty r_hasRootMotion;
		public virtual RProperty RhasRootMotion
		{
			get
			{
				if(r_hasRootMotion == null)
				{
					r_hasRootMotion = new(this, "hasRootMotion", -1);
					r_hasRootMotion.SetBelong(this.instance);
				}
				return r_hasRootMotion;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationEvent[] events
		/// </summary>
		protected RPropertyArray<RUnityEngine.RAnimationEvent> r_events;
		public virtual RPropertyArray<RUnityEngine.RAnimationEvent> Revents
		{
			get
			{
				if(r_events == null)
				{
					r_events = new(this, "events", -1);
					r_events.SetBelong(this.instance);
				}
				return r_events;
			}
		}

		/// <summary>
		/// Single averageDuration
		/// </summary>
		protected RProperty r_averageDuration;
		public virtual RProperty RaverageDuration
		{
			get
			{
				if(r_averageDuration == null)
				{
					r_averageDuration = new(this, "averageDuration", -1);
					r_averageDuration.SetBelong(this.instance);
				}
				return r_averageDuration;
			}
		}

		/// <summary>
		/// Single averageAngularSpeed
		/// </summary>
		protected RProperty r_averageAngularSpeed;
		public virtual RProperty RaverageAngularSpeed
		{
			get
			{
				if(r_averageAngularSpeed == null)
				{
					r_averageAngularSpeed = new(this, "averageAngularSpeed", -1);
					r_averageAngularSpeed.SetBelong(this.instance);
				}
				return r_averageAngularSpeed;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 averageSpeed
		/// </summary>
		protected RUnityEngine.RVector3 r_averageSpeed;
		public virtual RUnityEngine.RVector3 RaverageSpeed
		{
			get
			{
				if(r_averageSpeed == null)
				{
					r_averageSpeed = new(this, "averageSpeed", -1);
					r_averageSpeed.SetBelong(this.instance);
				}
				return r_averageSpeed;
			}
		}

		/// <summary>
		/// Single apparentSpeed
		/// </summary>
		protected RProperty r_apparentSpeed;
		public virtual RProperty RapparentSpeed
		{
			get
			{
				if(r_apparentSpeed == null)
				{
					r_apparentSpeed = new(this, "apparentSpeed", -1);
					r_apparentSpeed.SetBelong(this.instance);
				}
				return r_apparentSpeed;
			}
		}

		/// <summary>
		/// Boolean isLooping
		/// </summary>
		protected RProperty r_isLooping;
		public virtual RProperty RisLooping
		{
			get
			{
				if(r_isLooping == null)
				{
					r_isLooping = new(this, "isLooping", -1);
					r_isLooping.SetBelong(this.instance);
				}
				return r_isLooping;
			}
		}

		/// <summary>
		/// Boolean isHumanMotion
		/// </summary>
		protected RProperty r_isHumanMotion;
		public virtual RProperty RisHumanMotion
		{
			get
			{
				if(r_isHumanMotion == null)
				{
					r_isHumanMotion = new(this, "isHumanMotion", -1);
					r_isHumanMotion.SetBelong(this.instance);
				}
				return r_isHumanMotion;
			}
		}

		/// <summary>
		/// Boolean isAnimatorMotion
		/// </summary>
		protected RProperty r_isAnimatorMotion;
		public virtual RProperty RisAnimatorMotion
		{
			get
			{
				if(r_isAnimatorMotion == null)
				{
					r_isAnimatorMotion = new(this, "isAnimatorMotion", -1);
					r_isAnimatorMotion.SetBelong(this.instance);
				}
				return r_isAnimatorMotion;
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
		/// Void Internal_CreateAnimationClip(UnityEngine.AnimationClip)
		/// </summary>
		protected static RMethod r_RInternal_CreateAnimationClip_AnimationClip;
		public static RMethod RInternal_CreateAnimationClip_AnimationClip
		{
			get
			{
				if(r_RInternal_CreateAnimationClip_AnimationClip == null)
				{
					r_RInternal_CreateAnimationClip_AnimationClip = new(typeof(UnityEngine.AnimationClip), "Internal_CreateAnimationClip", 0, typeof(UnityEngine.AnimationClip));
					r_RInternal_CreateAnimationClip_AnimationClip.SetBelong(null);
				}
				return r_RInternal_CreateAnimationClip_AnimationClip;
			}
		}

		/// <summary>
		/// Void SampleAnimation(UnityEngine.GameObject, Single)
		/// </summary>
		protected RMethod r_RSampleAnimation_GameObject_Single;
		public virtual RMethod RSampleAnimation_GameObject_Single
		{
			get
			{
				if(r_RSampleAnimation_GameObject_Single == null)
				{
					r_RSampleAnimation_GameObject_Single = new(this, "SampleAnimation", 0, typeof(UnityEngine.GameObject), typeof(System.Single));
					r_RSampleAnimation_GameObject_Single.SetBelong(this.instance);
				}
				return r_RSampleAnimation_GameObject_Single;
			}
		}

		/// <summary>
		/// Void SampleAnimation(UnityEngine.GameObject, UnityEngine.AnimationClip, Single, UnityEngine.WrapMode)
		/// </summary>
		protected static RMethod r_RSampleAnimation_GameObject_AnimationClip_Single_WrapMode;
		public static RMethod RSampleAnimation_GameObject_AnimationClip_Single_WrapMode
		{
			get
			{
				if(r_RSampleAnimation_GameObject_AnimationClip_Single_WrapMode == null)
				{
					r_RSampleAnimation_GameObject_AnimationClip_Single_WrapMode = new(typeof(UnityEngine.AnimationClip), "SampleAnimation", 0, typeof(UnityEngine.GameObject), typeof(UnityEngine.AnimationClip), typeof(System.Single), typeof(UnityEngine.WrapMode));
					r_RSampleAnimation_GameObject_AnimationClip_Single_WrapMode.SetBelong(null);
				}
				return r_RSampleAnimation_GameObject_AnimationClip_Single_WrapMode;
			}
		}

		/// <summary>
		/// Void SetCurve(System.String, System.Type, System.String, UnityEngine.AnimationCurve)
		/// </summary>
		protected RMethod r_RSetCurve_String_Type_String_AnimationCurve;
		public virtual RMethod RSetCurve_String_Type_String_AnimationCurve
		{
			get
			{
				if(r_RSetCurve_String_Type_String_AnimationCurve == null)
				{
					r_RSetCurve_String_Type_String_AnimationCurve = new(this, "SetCurve", 0, typeof(System.String), typeof(System.Type), typeof(System.String), typeof(UnityEngine.AnimationCurve));
					r_RSetCurve_String_Type_String_AnimationCurve.SetBelong(this.instance);
				}
				return r_RSetCurve_String_Type_String_AnimationCurve;
			}
		}

		/// <summary>
		/// Void EnsureQuaternionContinuity()
		/// </summary>
		protected RMethod r_REnsureQuaternionContinuity;
		public virtual RMethod REnsureQuaternionContinuity
		{
			get
			{
				if(r_REnsureQuaternionContinuity == null)
				{
					r_REnsureQuaternionContinuity = new(this, "EnsureQuaternionContinuity", 0);
					r_REnsureQuaternionContinuity.SetBelong(this.instance);
				}
				return r_REnsureQuaternionContinuity;
			}
		}

		/// <summary>
		/// Void ClearCurves()
		/// </summary>
		protected RMethod r_RClearCurves;
		public virtual RMethod RClearCurves
		{
			get
			{
				if(r_RClearCurves == null)
				{
					r_RClearCurves = new(this, "ClearCurves", 0);
					r_RClearCurves.SetBelong(this.instance);
				}
				return r_RClearCurves;
			}
		}

		/// <summary>
		/// Void AddEvent(UnityEngine.AnimationEvent)
		/// </summary>
		protected RMethod r_RAddEvent_AnimationEvent;
		public virtual RMethod RAddEvent_AnimationEvent
		{
			get
			{
				if(r_RAddEvent_AnimationEvent == null)
				{
					r_RAddEvent_AnimationEvent = new(this, "AddEvent", 0, typeof(UnityEngine.AnimationEvent));
					r_RAddEvent_AnimationEvent.SetBelong(this.instance);
				}
				return r_RAddEvent_AnimationEvent;
			}
		}

		/// <summary>
		/// Void AddEventInternal(System.Object)
		/// </summary>
		protected RMethod r_RAddEventInternal_Object;
		public virtual RMethod RAddEventInternal_Object
		{
			get
			{
				if(r_RAddEventInternal_Object == null)
				{
					r_RAddEventInternal_Object = new(this, "AddEventInternal", 0, typeof(System.Object));
					r_RAddEventInternal_Object.SetBelong(this.instance);
				}
				return r_RAddEventInternal_Object;
			}
		}

		/// <summary>
		/// Void SetEventsInternal(System.Array)
		/// </summary>
		protected RMethod r_RSetEventsInternal_Array;
		public virtual RMethod RSetEventsInternal_Array
		{
			get
			{
				if(r_RSetEventsInternal_Array == null)
				{
					r_RSetEventsInternal_Array = new(this, "SetEventsInternal", 0, typeof(System.Array));
					r_RSetEventsInternal_Array.SetBelong(this.instance);
				}
				return r_RSetEventsInternal_Array;
			}
		}

		/// <summary>
		/// System.Array GetEventsInternal()
		/// </summary>
		protected RMethod r_RGetEventsInternal;
		public virtual RMethod RGetEventsInternal
		{
			get
			{
				if(r_RGetEventsInternal == null)
				{
					r_RGetEventsInternal = new(this, "GetEventsInternal", 0);
					r_RGetEventsInternal.SetBelong(this.instance);
				}
				return r_RGetEventsInternal;
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
		/// Boolean get_legacy()
		/// </summary>
		protected RMethod r_Rget_legacy;
		public virtual RMethod Rget_legacy
		{
			get
			{
				if(r_Rget_legacy == null)
				{
					r_Rget_legacy = new(this, "get_legacy", 0);
					r_Rget_legacy.SetBelong(this.instance);
				}
				return r_Rget_legacy;
			}
		}

		/// <summary>
		/// Boolean ValidateIfRetargetable(Boolean)
		/// </summary>
		protected RMethod r_RValidateIfRetargetable_Boolean;
		public virtual RMethod RValidateIfRetargetable_Boolean
		{
			get
			{
				if(r_RValidateIfRetargetable_Boolean == null)
				{
					r_RValidateIfRetargetable_Boolean = new(this, "ValidateIfRetargetable", 0, typeof(System.Boolean));
					r_RValidateIfRetargetable_Boolean.SetBelong(this.instance);
				}
				return r_RValidateIfRetargetable_Boolean;
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


        public RAnimationClip() : base("UnityEngine.AnimationClip")
        {
        }

        public RAnimationClip(System.Object instance) : base("UnityEngine.AnimationClip")
		{
            SetInstance(instance);
		}

        public RAnimationClip(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAnimationClip(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Internal_CreateAnimationClip(UnityEngine.AnimationClip  @self)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@self};
            var ___result = RInternal_CreateAnimationClip_AnimationClip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SampleAnimation(UnityEngine.GameObject  @go, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@go, @time};
            var ___result = RSampleAnimation_GameObject_Single.Invoke(___genericsType, ___parameters);

            
        }


        public static void SampleAnimation(UnityEngine.GameObject  @go, UnityEngine.AnimationClip  @clip, System.Single  @inTime, UnityEngine.WrapMode  @wrapMode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@go, @clip, @inTime, @wrapMode};
            var ___result = RSampleAnimation_GameObject_AnimationClip_Single_WrapMode.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetCurve(System.String  @relativePath, System.Type  @type, System.String  @propertyName, UnityEngine.AnimationCurve  @curve)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@relativePath, @type, @propertyName, @curve};
            var ___result = RSetCurve_String_Type_String_AnimationCurve.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnsureQuaternionContinuity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnsureQuaternionContinuity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearCurves()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearCurves.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddEvent(UnityEngine.AnimationEvent  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RAddEvent_AnimationEvent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddEventInternal(System.Object  @evt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@evt};
            var ___result = RAddEventInternal_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetEventsInternal(System.Array  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RSetEventsInternal_Array.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Array GetEventsInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEventsInternal.Invoke(___genericsType, ___parameters);

            return (System.Array)___result;
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


        public virtual System.Boolean get_legacy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = Rget_legacy.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ValidateIfRetargetable(System.Boolean  @val)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@val};
            var ___result = RValidateIfRetargetable_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
