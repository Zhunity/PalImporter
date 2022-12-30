using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.PhysicMaterial
	/// </summary>
    public partial class RPhysicMaterial : RMember //
    {

		/// <summary>
		/// Single bounciness
		/// </summary>
		protected RProperty r_bounciness;
		public virtual RProperty Rbounciness
		{
			get
			{
				if(r_bounciness == null)
				{
					r_bounciness = new(this, "bounciness", -1);
					r_bounciness.SetBelong(this.instance);
				}
				return r_bounciness;
			}
		}

		/// <summary>
		/// Single dynamicFriction
		/// </summary>
		protected RProperty r_dynamicFriction;
		public virtual RProperty RdynamicFriction
		{
			get
			{
				if(r_dynamicFriction == null)
				{
					r_dynamicFriction = new(this, "dynamicFriction", -1);
					r_dynamicFriction.SetBelong(this.instance);
				}
				return r_dynamicFriction;
			}
		}

		/// <summary>
		/// Single staticFriction
		/// </summary>
		protected RProperty r_staticFriction;
		public virtual RProperty RstaticFriction
		{
			get
			{
				if(r_staticFriction == null)
				{
					r_staticFriction = new(this, "staticFriction", -1);
					r_staticFriction.SetBelong(this.instance);
				}
				return r_staticFriction;
			}
		}

		/// <summary>
		/// UnityEngine.PhysicMaterialCombine frictionCombine
		/// </summary>
		protected RProperty r_frictionCombine;
		public virtual RProperty RfrictionCombine
		{
			get
			{
				if(r_frictionCombine == null)
				{
					r_frictionCombine = new(this, "frictionCombine", -1);
					r_frictionCombine.SetBelong(this.instance);
				}
				return r_frictionCombine;
			}
		}

		/// <summary>
		/// UnityEngine.PhysicMaterialCombine bounceCombine
		/// </summary>
		protected RProperty r_bounceCombine;
		public virtual RProperty RbounceCombine
		{
			get
			{
				if(r_bounceCombine == null)
				{
					r_bounceCombine = new(this, "bounceCombine", -1);
					r_bounceCombine.SetBelong(this.instance);
				}
				return r_bounceCombine;
			}
		}

		/// <summary>
		/// Single bouncyness
		/// </summary>
		protected RProperty r_bouncyness;
		public virtual RProperty Rbouncyness
		{
			get
			{
				if(r_bouncyness == null)
				{
					r_bouncyness = new(this, "bouncyness", -1);
					r_bouncyness.SetBelong(this.instance);
				}
				return r_bouncyness;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 frictionDirection2
		/// </summary>
		protected RUnityEngine.RVector3 r_frictionDirection2;
		public virtual RUnityEngine.RVector3 RfrictionDirection2
		{
			get
			{
				if(r_frictionDirection2 == null)
				{
					r_frictionDirection2 = new(this, "frictionDirection2", -1);
					r_frictionDirection2.SetBelong(this.instance);
				}
				return r_frictionDirection2;
			}
		}

		/// <summary>
		/// Single dynamicFriction2
		/// </summary>
		protected RProperty r_dynamicFriction2;
		public virtual RProperty RdynamicFriction2
		{
			get
			{
				if(r_dynamicFriction2 == null)
				{
					r_dynamicFriction2 = new(this, "dynamicFriction2", -1);
					r_dynamicFriction2.SetBelong(this.instance);
				}
				return r_dynamicFriction2;
			}
		}

		/// <summary>
		/// Single staticFriction2
		/// </summary>
		protected RProperty r_staticFriction2;
		public virtual RProperty RstaticFriction2
		{
			get
			{
				if(r_staticFriction2 == null)
				{
					r_staticFriction2 = new(this, "staticFriction2", -1);
					r_staticFriction2.SetBelong(this.instance);
				}
				return r_staticFriction2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 frictionDirection
		/// </summary>
		protected RUnityEngine.RVector3 r_frictionDirection;
		public virtual RUnityEngine.RVector3 RfrictionDirection
		{
			get
			{
				if(r_frictionDirection == null)
				{
					r_frictionDirection = new(this, "frictionDirection", -1);
					r_frictionDirection.SetBelong(this.instance);
				}
				return r_frictionDirection;
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
		/// Void Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial, System.String)
		/// </summary>
		protected static RMethod r_RInternal_CreateDynamicsMaterial_PhysicMaterial_String;
		public static RMethod RInternal_CreateDynamicsMaterial_PhysicMaterial_String
		{
			get
			{
				if(r_RInternal_CreateDynamicsMaterial_PhysicMaterial_String == null)
				{
					r_RInternal_CreateDynamicsMaterial_PhysicMaterial_String = new(typeof(UnityEngine.PhysicMaterial), "Internal_CreateDynamicsMaterial", 0, typeof(UnityEngine.PhysicMaterial), typeof(System.String));
					r_RInternal_CreateDynamicsMaterial_PhysicMaterial_String.SetBelong(null);
				}
				return r_RInternal_CreateDynamicsMaterial_PhysicMaterial_String;
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


        public RPhysicMaterial() : base("UnityEngine.PhysicMaterial")
        {
        }

        public RPhysicMaterial(System.Object instance) : base("UnityEngine.PhysicMaterial")
		{
            SetInstance(instance);
		}

        public RPhysicMaterial(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPhysicMaterial(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Internal_CreateDynamicsMaterial(UnityEngine.PhysicMaterial  @mat, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mat, @name};
            var ___result = RInternal_CreateDynamicsMaterial_PhysicMaterial_String.Invoke(___genericsType, ___parameters);

            
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
