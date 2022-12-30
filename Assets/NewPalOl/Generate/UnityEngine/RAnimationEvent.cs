using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AnimationEvent
	/// </summary>
    public partial class RAnimationEvent : RMember //
    {

		/// <summary>
		/// System.Single m_Time
		/// </summary>
		protected RField r_m_Time;
		public virtual RField Rm_Time
		{
			get
			{
				if(r_m_Time == null)
				{
					r_m_Time = new(this, "m_Time");
					r_m_Time.SetBelong(this.instance);
				}
				return r_m_Time;
			}
		}

		/// <summary>
		/// System.String m_FunctionName
		/// </summary>
		protected RField r_m_FunctionName;
		public virtual RField Rm_FunctionName
		{
			get
			{
				if(r_m_FunctionName == null)
				{
					r_m_FunctionName = new(this, "m_FunctionName");
					r_m_FunctionName.SetBelong(this.instance);
				}
				return r_m_FunctionName;
			}
		}

		/// <summary>
		/// System.String m_StringParameter
		/// </summary>
		protected RField r_m_StringParameter;
		public virtual RField Rm_StringParameter
		{
			get
			{
				if(r_m_StringParameter == null)
				{
					r_m_StringParameter = new(this, "m_StringParameter");
					r_m_StringParameter.SetBelong(this.instance);
				}
				return r_m_StringParameter;
			}
		}

		/// <summary>
		/// UnityEngine.Object m_ObjectReferenceParameter
		/// </summary>
		protected RUnityEngine.RObject r_m_ObjectReferenceParameter;
		public virtual RUnityEngine.RObject Rm_ObjectReferenceParameter
		{
			get
			{
				if(r_m_ObjectReferenceParameter == null)
				{
					r_m_ObjectReferenceParameter = new(this, "m_ObjectReferenceParameter");
					r_m_ObjectReferenceParameter.SetBelong(this.instance);
				}
				return r_m_ObjectReferenceParameter;
			}
		}

		/// <summary>
		/// System.Single m_FloatParameter
		/// </summary>
		protected RField r_m_FloatParameter;
		public virtual RField Rm_FloatParameter
		{
			get
			{
				if(r_m_FloatParameter == null)
				{
					r_m_FloatParameter = new(this, "m_FloatParameter");
					r_m_FloatParameter.SetBelong(this.instance);
				}
				return r_m_FloatParameter;
			}
		}

		/// <summary>
		/// System.Int32 m_IntParameter
		/// </summary>
		protected RField r_m_IntParameter;
		public virtual RField Rm_IntParameter
		{
			get
			{
				if(r_m_IntParameter == null)
				{
					r_m_IntParameter = new(this, "m_IntParameter");
					r_m_IntParameter.SetBelong(this.instance);
				}
				return r_m_IntParameter;
			}
		}

		/// <summary>
		/// System.Int32 m_MessageOptions
		/// </summary>
		protected RField r_m_MessageOptions;
		public virtual RField Rm_MessageOptions
		{
			get
			{
				if(r_m_MessageOptions == null)
				{
					r_m_MessageOptions = new(this, "m_MessageOptions");
					r_m_MessageOptions.SetBelong(this.instance);
				}
				return r_m_MessageOptions;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationEventSource m_Source
		/// </summary>
		protected RField r_m_Source;
		public virtual RField Rm_Source
		{
			get
			{
				if(r_m_Source == null)
				{
					r_m_Source = new(this, "m_Source");
					r_m_Source.SetBelong(this.instance);
				}
				return r_m_Source;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState m_StateSender
		/// </summary>
		protected RUnityEngine.RAnimationState r_m_StateSender;
		public virtual RUnityEngine.RAnimationState Rm_StateSender
		{
			get
			{
				if(r_m_StateSender == null)
				{
					r_m_StateSender = new(this, "m_StateSender");
					r_m_StateSender.SetBelong(this.instance);
				}
				return r_m_StateSender;
			}
		}

		/// <summary>
		/// UnityEngine.AnimatorStateInfo m_AnimatorStateInfo
		/// </summary>
		protected RUnityEngine.RAnimatorStateInfo r_m_AnimatorStateInfo;
		public virtual RUnityEngine.RAnimatorStateInfo Rm_AnimatorStateInfo
		{
			get
			{
				if(r_m_AnimatorStateInfo == null)
				{
					r_m_AnimatorStateInfo = new(this, "m_AnimatorStateInfo");
					r_m_AnimatorStateInfo.SetBelong(this.instance);
				}
				return r_m_AnimatorStateInfo;
			}
		}

		/// <summary>
		/// UnityEngine.AnimatorClipInfo m_AnimatorClipInfo
		/// </summary>
		protected RUnityEngine.RAnimatorClipInfo r_m_AnimatorClipInfo;
		public virtual RUnityEngine.RAnimatorClipInfo Rm_AnimatorClipInfo
		{
			get
			{
				if(r_m_AnimatorClipInfo == null)
				{
					r_m_AnimatorClipInfo = new(this, "m_AnimatorClipInfo");
					r_m_AnimatorClipInfo.SetBelong(this.instance);
				}
				return r_m_AnimatorClipInfo;
			}
		}

		/// <summary>
		/// System.String data
		/// </summary>
		protected RProperty r_data;
		public virtual RProperty Rdata
		{
			get
			{
				if(r_data == null)
				{
					r_data = new(this, "data", -1);
					r_data.SetBelong(this.instance);
				}
				return r_data;
			}
		}

		/// <summary>
		/// System.String stringParameter
		/// </summary>
		protected RProperty r_stringParameter;
		public virtual RProperty RstringParameter
		{
			get
			{
				if(r_stringParameter == null)
				{
					r_stringParameter = new(this, "stringParameter", -1);
					r_stringParameter.SetBelong(this.instance);
				}
				return r_stringParameter;
			}
		}

		/// <summary>
		/// Single floatParameter
		/// </summary>
		protected RProperty r_floatParameter;
		public virtual RProperty RfloatParameter
		{
			get
			{
				if(r_floatParameter == null)
				{
					r_floatParameter = new(this, "floatParameter", -1);
					r_floatParameter.SetBelong(this.instance);
				}
				return r_floatParameter;
			}
		}

		/// <summary>
		/// Int32 intParameter
		/// </summary>
		protected RProperty r_intParameter;
		public virtual RProperty RintParameter
		{
			get
			{
				if(r_intParameter == null)
				{
					r_intParameter = new(this, "intParameter", -1);
					r_intParameter.SetBelong(this.instance);
				}
				return r_intParameter;
			}
		}

		/// <summary>
		/// UnityEngine.Object objectReferenceParameter
		/// </summary>
		protected RUnityEngine.RObject r_objectReferenceParameter;
		public virtual RUnityEngine.RObject RobjectReferenceParameter
		{
			get
			{
				if(r_objectReferenceParameter == null)
				{
					r_objectReferenceParameter = new(this, "objectReferenceParameter", -1);
					r_objectReferenceParameter.SetBelong(this.instance);
				}
				return r_objectReferenceParameter;
			}
		}

		/// <summary>
		/// System.String functionName
		/// </summary>
		protected RProperty r_functionName;
		public virtual RProperty RfunctionName
		{
			get
			{
				if(r_functionName == null)
				{
					r_functionName = new(this, "functionName", -1);
					r_functionName.SetBelong(this.instance);
				}
				return r_functionName;
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
		/// UnityEngine.SendMessageOptions messageOptions
		/// </summary>
		protected RProperty r_messageOptions;
		public virtual RProperty RmessageOptions
		{
			get
			{
				if(r_messageOptions == null)
				{
					r_messageOptions = new(this, "messageOptions", -1);
					r_messageOptions.SetBelong(this.instance);
				}
				return r_messageOptions;
			}
		}

		/// <summary>
		/// Boolean isFiredByLegacy
		/// </summary>
		protected RProperty r_isFiredByLegacy;
		public virtual RProperty RisFiredByLegacy
		{
			get
			{
				if(r_isFiredByLegacy == null)
				{
					r_isFiredByLegacy = new(this, "isFiredByLegacy", -1);
					r_isFiredByLegacy.SetBelong(this.instance);
				}
				return r_isFiredByLegacy;
			}
		}

		/// <summary>
		/// Boolean isFiredByAnimator
		/// </summary>
		protected RProperty r_isFiredByAnimator;
		public virtual RProperty RisFiredByAnimator
		{
			get
			{
				if(r_isFiredByAnimator == null)
				{
					r_isFiredByAnimator = new(this, "isFiredByAnimator", -1);
					r_isFiredByAnimator.SetBelong(this.instance);
				}
				return r_isFiredByAnimator;
			}
		}

		/// <summary>
		/// UnityEngine.AnimationState animationState
		/// </summary>
		protected RUnityEngine.RAnimationState r_animationState;
		public virtual RUnityEngine.RAnimationState RanimationState
		{
			get
			{
				if(r_animationState == null)
				{
					r_animationState = new(this, "animationState", -1);
					r_animationState.SetBelong(this.instance);
				}
				return r_animationState;
			}
		}

		/// <summary>
		/// UnityEngine.AnimatorStateInfo animatorStateInfo
		/// </summary>
		protected RUnityEngine.RAnimatorStateInfo r_animatorStateInfo;
		public virtual RUnityEngine.RAnimatorStateInfo RanimatorStateInfo
		{
			get
			{
				if(r_animatorStateInfo == null)
				{
					r_animatorStateInfo = new(this, "animatorStateInfo", -1);
					r_animatorStateInfo.SetBelong(this.instance);
				}
				return r_animatorStateInfo;
			}
		}

		/// <summary>
		/// UnityEngine.AnimatorClipInfo animatorClipInfo
		/// </summary>
		protected RUnityEngine.RAnimatorClipInfo r_animatorClipInfo;
		public virtual RUnityEngine.RAnimatorClipInfo RanimatorClipInfo
		{
			get
			{
				if(r_animatorClipInfo == null)
				{
					r_animatorClipInfo = new(this, "animatorClipInfo", -1);
					r_animatorClipInfo.SetBelong(this.instance);
				}
				return r_animatorClipInfo;
			}
		}

		/// <summary>
		/// Int32 GetHash()
		/// </summary>
		protected RMethod r_RGetHash;
		public virtual RMethod RGetHash
		{
			get
			{
				if(r_RGetHash == null)
				{
					r_RGetHash = new(this, "GetHash", 0);
					r_RGetHash.SetBelong(this.instance);
				}
				return r_RGetHash;
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


        public RAnimationEvent() : base("UnityEngine.AnimationEvent")
        {
        }

        public RAnimationEvent(System.Object instance) : base("UnityEngine.AnimationEvent")
		{
            SetInstance(instance);
		}

        public RAnimationEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAnimationEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetHash()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHash.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
