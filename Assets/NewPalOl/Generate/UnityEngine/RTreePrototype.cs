using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TreePrototype
	/// </summary>
    public partial class RTreePrototype : RMember //
    {

		/// <summary>
		/// UnityEngine.GameObject m_Prefab
		/// </summary>
		protected RUnityEngine.RGameObject r_m_Prefab;
		public virtual RUnityEngine.RGameObject Rm_Prefab
		{
			get
			{
				if(r_m_Prefab == null)
				{
					r_m_Prefab = new(this, "m_Prefab");
					r_m_Prefab.SetBelong(this.instance);
				}
				return r_m_Prefab;
			}
		}

		/// <summary>
		/// System.Single m_BendFactor
		/// </summary>
		protected RField r_m_BendFactor;
		public virtual RField Rm_BendFactor
		{
			get
			{
				if(r_m_BendFactor == null)
				{
					r_m_BendFactor = new(this, "m_BendFactor");
					r_m_BendFactor.SetBelong(this.instance);
				}
				return r_m_BendFactor;
			}
		}

		/// <summary>
		/// System.Int32 m_NavMeshLod
		/// </summary>
		protected RField r_m_NavMeshLod;
		public virtual RField Rm_NavMeshLod
		{
			get
			{
				if(r_m_NavMeshLod == null)
				{
					r_m_NavMeshLod = new(this, "m_NavMeshLod");
					r_m_NavMeshLod.SetBelong(this.instance);
				}
				return r_m_NavMeshLod;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject prefab
		/// </summary>
		protected RUnityEngine.RGameObject r_prefab;
		public virtual RUnityEngine.RGameObject Rprefab
		{
			get
			{
				if(r_prefab == null)
				{
					r_prefab = new(this, "prefab", -1);
					r_prefab.SetBelong(this.instance);
				}
				return r_prefab;
			}
		}

		/// <summary>
		/// Single bendFactor
		/// </summary>
		protected RProperty r_bendFactor;
		public virtual RProperty RbendFactor
		{
			get
			{
				if(r_bendFactor == null)
				{
					r_bendFactor = new(this, "bendFactor", -1);
					r_bendFactor.SetBelong(this.instance);
				}
				return r_bendFactor;
			}
		}

		/// <summary>
		/// Int32 navMeshLod
		/// </summary>
		protected RProperty r_navMeshLod;
		public virtual RProperty RnavMeshLod
		{
			get
			{
				if(r_navMeshLod == null)
				{
					r_navMeshLod = new(this, "navMeshLod", -1);
					r_navMeshLod.SetBelong(this.instance);
				}
				return r_navMeshLod;
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
		/// Boolean Equals(UnityEngine.TreePrototype)
		/// </summary>
		protected RMethod r_REquals_TreePrototype;
		public virtual RMethod REquals_TreePrototype
		{
			get
			{
				if(r_REquals_TreePrototype == null)
				{
					r_REquals_TreePrototype = new(this, "Equals", 0, typeof(UnityEngine.TreePrototype));
					r_REquals_TreePrototype.SetBelong(this.instance);
				}
				return r_REquals_TreePrototype;
			}
		}

		/// <summary>
		/// Boolean Validate(System.String ByRef)
		/// </summary>
		protected RMethod r_RValidate_Out_String;
		public virtual RMethod RValidate_Out_String
		{
			get
			{
				if(r_RValidate_Out_String == null)
				{
					r_RValidate_Out_String = new(this, "Validate", 0, typeof(System.String).MakeByRefType());
					r_RValidate_Out_String.SetBelong(this.instance);
				}
				return r_RValidate_Out_String;
			}
		}

		/// <summary>
		/// Boolean ValidateTreePrototype(UnityEngine.TreePrototype, System.String ByRef)
		/// </summary>
		protected static RMethod r_RValidateTreePrototype_TreePrototype_Out_String;
		public static RMethod RValidateTreePrototype_TreePrototype_Out_String
		{
			get
			{
				if(r_RValidateTreePrototype_TreePrototype_Out_String == null)
				{
					r_RValidateTreePrototype_TreePrototype_Out_String = new(typeof(UnityEngine.TreePrototype), "ValidateTreePrototype", 0, typeof(UnityEngine.TreePrototype), typeof(System.String).MakeByRefType());
					r_RValidateTreePrototype_TreePrototype_Out_String.SetBelong(null);
				}
				return r_RValidateTreePrototype_TreePrototype_Out_String;
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


        public RTreePrototype() : base("UnityEngine.TreePrototype")
        {
        }

        public RTreePrototype(System.Object instance) : base("UnityEngine.TreePrototype")
		{
            SetInstance(instance);
		}

        public RTreePrototype(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTreePrototype(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual System.Boolean Equals(UnityEngine.TreePrototype  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_TreePrototype.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Validate(out System.String  @errorMessage)
        {
			errorMessage = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@errorMessage};
            var ___result = RValidate_Out_String.Invoke(___genericsType, ___parameters);
			errorMessage = (System.String)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean ValidateTreePrototype(UnityEngine.TreePrototype  @prototype, out System.String  @errorMessage)
        {
			errorMessage = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prototype, @errorMessage};
            var ___result = RValidateTreePrototype_TreePrototype_Out_String.Invoke(___genericsType, ___parameters);
			errorMessage = (System.String)___parameters[1];

            return (System.Boolean)___result;
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
