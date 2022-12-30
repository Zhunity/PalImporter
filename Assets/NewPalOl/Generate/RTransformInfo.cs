using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TransformInfo
	/// </summary>
    public partial class RTransformInfo : RMember //
    {

		/// <summary>
		/// System.String id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.String sceneId
		/// </summary>
		protected RField r_sceneId;
		public virtual RField RsceneId
		{
			get
			{
				if(r_sceneId == null)
				{
					r_sceneId = new(this, "sceneId");
					r_sceneId.SetBelong(this.instance);
				}
				return r_sceneId;
			}
		}

		/// <summary>
		/// System.String targetId
		/// </summary>
		protected RField r_targetId;
		public virtual RField RtargetId
		{
			get
			{
				if(r_targetId == null)
				{
					r_targetId = new(this, "targetId");
					r_targetId.SetBelong(this.instance);
				}
				return r_targetId;
			}
		}

		/// <summary>
		/// System.Single radius
		/// </summary>
		protected RField r_radius;
		public virtual RField Rradius
		{
			get
			{
				if(r_radius == null)
				{
					r_radius = new(this, "radius");
					r_radius.SetBelong(this.instance);
				}
				return r_radius;
			}
		}

		/// <summary>
		/// System.Single _x
		/// </summary>
		protected RField r__x;
		public virtual RField R_x
		{
			get
			{
				if(r__x == null)
				{
					r__x = new(this, "_x");
					r__x.SetBelong(this.instance);
				}
				return r__x;
			}
		}

		/// <summary>
		/// System.Single _y
		/// </summary>
		protected RField r__y;
		public virtual RField R_y
		{
			get
			{
				if(r__y == null)
				{
					r__y = new(this, "_y");
					r__y.SetBelong(this.instance);
				}
				return r__y;
			}
		}

		/// <summary>
		/// System.Single _z
		/// </summary>
		protected RField r__z;
		public virtual RField R_z
		{
			get
			{
				if(r__z == null)
				{
					r__z = new(this, "_z");
					r__z.SetBelong(this.instance);
				}
				return r__z;
			}
		}

		/// <summary>
		/// System.String tp_effect
		/// </summary>
		protected RField r_tp_effect;
		public virtual RField Rtp_effect
		{
			get
			{
				if(r_tp_effect == null)
				{
					r_tp_effect = new(this, "tp_effect");
					r_tp_effect.SetBelong(this.instance);
				}
				return r_tp_effect;
			}
		}

		/// <summary>
		/// System.Single tp_direction
		/// </summary>
		protected RField r_tp_direction;
		public virtual RField Rtp_direction
		{
			get
			{
				if(r_tp_direction == null)
				{
					r_tp_direction = new(this, "tp_direction");
					r_tp_direction.SetBelong(this.instance);
				}
				return r_tp_direction;
			}
		}

		/// <summary>
		/// System.Single effect_size
		/// </summary>
		protected RField r_effect_size;
		public virtual RField Reffect_size
		{
			get
			{
				if(r_effect_size == null)
				{
					r_effect_size = new(this, "effect_size");
					r_effect_size.SetBelong(this.instance);
				}
				return r_effect_size;
			}
		}

		/// <summary>
		/// System.String npcid
		/// </summary>
		protected RField r_npcid;
		public virtual RField Rnpcid
		{
			get
			{
				if(r_npcid == null)
				{
					r_npcid = new(this, "npcid");
					r_npcid.SetBelong(this.instance);
				}
				return r_npcid;
			}
		}

		/// <summary>
		/// System.String choice
		/// </summary>
		protected RField r_choice;
		public virtual RField Rchoice
		{
			get
			{
				if(r_choice == null)
				{
					r_choice = new(this, "choice");
					r_choice.SetBelong(this.instance);
				}
				return r_choice;
			}
		}

		/// <summary>
		/// System.Int32 tribe
		/// </summary>
		protected RField r_tribe;
		public virtual RField Rtribe
		{
			get
			{
				if(r_tribe == null)
				{
					r_tribe = new(this, "tribe");
					r_tribe.SetBelong(this.instance);
				}
				return r_tribe;
			}
		}

		/// <summary>
		/// System.Int32 type
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
		/// UnityEngine.Vector3 pos
		/// </summary>
		protected RUnityEngine.RVector3 r_pos;
		public virtual RUnityEngine.RVector3 Rpos
		{
			get
			{
				if(r_pos == null)
				{
					r_pos = new(this, "pos", -1);
					r_pos.SetBelong(this.instance);
				}
				return r_pos;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion rot
		/// </summary>
		protected RUnityEngine.RQuaternion r_rot;
		public virtual RUnityEngine.RQuaternion Rrot
		{
			get
			{
				if(r_rot == null)
				{
					r_rot = new(this, "rot", -1);
					r_rot.SetBelong(this.instance);
				}
				return r_rot;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 Scale
		/// </summary>
		protected RUnityEngine.RVector3 r_Scale;
		public virtual RUnityEngine.RVector3 RScale
		{
			get
			{
				if(r_Scale == null)
				{
					r_Scale = new(this, "Scale", -1);
					r_Scale.SetBelong(this.instance);
				}
				return r_Scale;
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


        public RTransformInfo() : base("TransformInfo")
        {
        }

        public RTransformInfo(System.Object instance) : base("TransformInfo")
		{
            SetInstance(instance);
		}

        public RTransformInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTransformInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
