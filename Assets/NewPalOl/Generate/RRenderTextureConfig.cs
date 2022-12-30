using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RenderTextureConfig
	/// </summary>
    public partial class RRenderTextureConfig : RMember //
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
		/// UnityEngine.Vector3 offsetPos
		/// </summary>
		protected RUnityEngine.RVector3 r_offsetPos;
		public virtual RUnityEngine.RVector3 RoffsetPos
		{
			get
			{
				if(r_offsetPos == null)
				{
					r_offsetPos = new(this, "offsetPos");
					r_offsetPos.SetBelong(this.instance);
				}
				return r_offsetPos;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion objectRot
		/// </summary>
		protected RUnityEngine.RQuaternion r_objectRot;
		public virtual RUnityEngine.RQuaternion RobjectRot
		{
			get
			{
				if(r_objectRot == null)
				{
					r_objectRot = new(this, "objectRot");
					r_objectRot.SetBelong(this.instance);
				}
				return r_objectRot;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 objectScale
		/// </summary>
		protected RUnityEngine.RVector3 r_objectScale;
		public virtual RUnityEngine.RVector3 RobjectScale
		{
			get
			{
				if(r_objectScale == null)
				{
					r_objectScale = new(this, "objectScale");
					r_objectScale.SetBelong(this.instance);
				}
				return r_objectScale;
			}
		}

		/// <summary>
		/// System.Single fov
		/// </summary>
		protected RField r_fov;
		public virtual RField Rfov
		{
			get
			{
				if(r_fov == null)
				{
					r_fov = new(this, "fov");
					r_fov.SetBelong(this.instance);
				}
				return r_fov;
			}
		}

		/// <summary>
		/// System.String animaName
		/// </summary>
		protected RField r_animaName;
		public virtual RField RanimaName
		{
			get
			{
				if(r_animaName == null)
				{
					r_animaName = new(this, "animaName");
					r_animaName.SetBelong(this.instance);
				}
				return r_animaName;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 rotationPos
		/// </summary>
		protected RUnityEngine.RVector3 r_rotationPos;
		public virtual RUnityEngine.RVector3 RrotationPos
		{
			get
			{
				if(r_rotationPos == null)
				{
					r_rotationPos = new(this, "rotationPos");
					r_rotationPos.SetBelong(this.instance);
				}
				return r_rotationPos;
			}
		}

		/// <summary>
		/// System.Single glowIntensity
		/// </summary>
		protected RField r_glowIntensity;
		public virtual RField RglowIntensity
		{
			get
			{
				if(r_glowIntensity == null)
				{
					r_glowIntensity = new(this, "glowIntensity");
					r_glowIntensity.SetBelong(this.instance);
				}
				return r_glowIntensity;
			}
		}

		/// <summary>
		/// System.Int32 blurIterations
		/// </summary>
		protected RField r_blurIterations;
		public virtual RField RblurIterations
		{
			get
			{
				if(r_blurIterations == null)
				{
					r_blurIterations = new(this, "blurIterations");
					r_blurIterations.SetBelong(this.instance);
				}
				return r_blurIterations;
			}
		}

		/// <summary>
		/// System.Single blurSpread
		/// </summary>
		protected RField r_blurSpread;
		public virtual RField RblurSpread
		{
			get
			{
				if(r_blurSpread == null)
				{
					r_blurSpread = new(this, "blurSpread");
					r_blurSpread.SetBelong(this.instance);
				}
				return r_blurSpread;
			}
		}

		/// <summary>
		/// UnityEngine.Color glowTint
		/// </summary>
		protected RUnityEngine.RColor r_glowTint;
		public virtual RUnityEngine.RColor RglowTint
		{
			get
			{
				if(r_glowTint == null)
				{
					r_glowTint = new(this, "glowTint");
					r_glowTint.SetBelong(this.instance);
				}
				return r_glowTint;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[RenderTextLightConfig] lights
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RRenderTextLightConfig> r_lights;
		public virtual RSystem.RCollections.RGeneric.RList<RRenderTextLightConfig> Rlights
		{
			get
			{
				if(r_lights == null)
				{
					r_lights = new(this, "lights");
					r_lights.SetBelong(this.instance);
				}
				return r_lights;
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


        public RRenderTextureConfig() : base("RenderTextureConfig")
        {
        }

        public RRenderTextureConfig(System.Object instance) : base("RenderTextureConfig")
		{
            SetInstance(instance);
		}

        public RRenderTextureConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRenderTextureConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
