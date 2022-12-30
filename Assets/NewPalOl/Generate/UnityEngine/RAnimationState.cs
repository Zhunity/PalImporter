using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.AnimationState
	/// </summary>
    public partial class RAnimationState : RMember //
    {

		/// <summary>
		/// System.IntPtr m_Ptr
		/// </summary>
		protected RField r_m_Ptr;
		public virtual RField Rm_Ptr
		{
			get
			{
				if(r_m_Ptr == null)
				{
					r_m_Ptr = new(this, "m_Ptr");
					r_m_Ptr.SetBelong(this.instance);
				}
				return r_m_Ptr;
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
		/// Single weight
		/// </summary>
		protected RProperty r_weight;
		public virtual RProperty Rweight
		{
			get
			{
				if(r_weight == null)
				{
					r_weight = new(this, "weight", -1);
					r_weight.SetBelong(this.instance);
				}
				return r_weight;
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
		/// Single normalizedTime
		/// </summary>
		protected RProperty r_normalizedTime;
		public virtual RProperty RnormalizedTime
		{
			get
			{
				if(r_normalizedTime == null)
				{
					r_normalizedTime = new(this, "normalizedTime", -1);
					r_normalizedTime.SetBelong(this.instance);
				}
				return r_normalizedTime;
			}
		}

		/// <summary>
		/// Single speed
		/// </summary>
		protected RProperty r_speed;
		public virtual RProperty Rspeed
		{
			get
			{
				if(r_speed == null)
				{
					r_speed = new(this, "speed", -1);
					r_speed.SetBelong(this.instance);
				}
				return r_speed;
			}
		}

		/// <summary>
		/// Single normalizedSpeed
		/// </summary>
		protected RProperty r_normalizedSpeed;
		public virtual RProperty RnormalizedSpeed
		{
			get
			{
				if(r_normalizedSpeed == null)
				{
					r_normalizedSpeed = new(this, "normalizedSpeed", -1);
					r_normalizedSpeed.SetBelong(this.instance);
				}
				return r_normalizedSpeed;
			}
		}

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
		/// Int32 layer
		/// </summary>
		protected RProperty r_layer;
		public virtual RProperty Rlayer
		{
			get
			{
				if(r_layer == null)
				{
					r_layer = new(this, "layer", -1);
					r_layer.SetBelong(this.instance);
				}
				return r_layer;
			}
		}

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
		/// UnityEngine.AnimationBlendMode blendMode
		/// </summary>
		protected RProperty r_blendMode;
		public virtual RProperty RblendMode
		{
			get
			{
				if(r_blendMode == null)
				{
					r_blendMode = new(this, "blendMode", -1);
					r_blendMode.SetBelong(this.instance);
				}
				return r_blendMode;
			}
		}

		/// <summary>
		/// Void AddMixingTransform(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RAddMixingTransform_Transform;
		public virtual RMethod RAddMixingTransform_Transform
		{
			get
			{
				if(r_RAddMixingTransform_Transform == null)
				{
					r_RAddMixingTransform_Transform = new(this, "AddMixingTransform", 0, typeof(UnityEngine.Transform));
					r_RAddMixingTransform_Transform.SetBelong(this.instance);
				}
				return r_RAddMixingTransform_Transform;
			}
		}

		/// <summary>
		/// Void AddMixingTransform(UnityEngine.Transform, Boolean)
		/// </summary>
		protected RMethod r_RAddMixingTransform_Transform_Boolean;
		public virtual RMethod RAddMixingTransform_Transform_Boolean
		{
			get
			{
				if(r_RAddMixingTransform_Transform_Boolean == null)
				{
					r_RAddMixingTransform_Transform_Boolean = new(this, "AddMixingTransform", 0, typeof(UnityEngine.Transform), typeof(System.Boolean));
					r_RAddMixingTransform_Transform_Boolean.SetBelong(this.instance);
				}
				return r_RAddMixingTransform_Transform_Boolean;
			}
		}

		/// <summary>
		/// Void RemoveMixingTransform(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RRemoveMixingTransform_Transform;
		public virtual RMethod RRemoveMixingTransform_Transform
		{
			get
			{
				if(r_RRemoveMixingTransform_Transform == null)
				{
					r_RRemoveMixingTransform_Transform = new(this, "RemoveMixingTransform", 0, typeof(UnityEngine.Transform));
					r_RRemoveMixingTransform_Transform.SetBelong(this.instance);
				}
				return r_RRemoveMixingTransform_Transform;
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


        public RAnimationState() : base("UnityEngine.AnimationState")
        {
        }

        public RAnimationState(System.Object instance) : base("UnityEngine.AnimationState")
		{
            SetInstance(instance);
		}

        public RAnimationState(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAnimationState(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void AddMixingTransform(UnityEngine.Transform  @mix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mix};
            var ___result = RAddMixingTransform_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddMixingTransform(UnityEngine.Transform  @mix, System.Boolean  @recursive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mix, @recursive};
            var ___result = RAddMixingTransform_Transform_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveMixingTransform(UnityEngine.Transform  @mix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mix};
            var ___result = RRemoveMixingTransform_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Equals(System.Object  @o)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@o};
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
