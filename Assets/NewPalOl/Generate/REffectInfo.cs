using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// EffectInfo
	/// </summary>
    public partial class REffectInfo : RMember //
    {

		/// <summary>
		/// GameDefineType.ID actorId
		/// </summary>
		protected RGameDefineType.RID r_actorId;
		public virtual RGameDefineType.RID RactorId
		{
			get
			{
				if(r_actorId == null)
				{
					r_actorId = new(this, "actorId");
					r_actorId.SetBelong(this.instance);
				}
				return r_actorId;
			}
		}

		/// <summary>
		/// System.String boneName
		/// </summary>
		protected RField r_boneName;
		public virtual RField RboneName
		{
			get
			{
				if(r_boneName == null)
				{
					r_boneName = new(this, "boneName");
					r_boneName.SetBelong(this.instance);
				}
				return r_boneName;
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
					r_pos = new(this, "pos");
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
					r_rot = new(this, "rot");
					r_rot.SetBelong(this.instance);
				}
				return r_rot;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject effectObj
		/// </summary>
		protected RUnityEngine.RGameObject r_effectObj;
		public virtual RUnityEngine.RGameObject ReffectObj
		{
			get
			{
				if(r_effectObj == null)
				{
					r_effectObj = new(this, "effectObj");
					r_effectObj.SetBelong(this.instance);
				}
				return r_effectObj;
			}
		}

		/// <summary>
		/// System.String ROOT_NAME
		/// </summary>
		protected static RField r_ROOT_NAME;
		public static RField ROOT_NAME
		{
			get
			{
				if(r_ROOT_NAME == null)
				{
					r_ROOT_NAME = new(typeof(EffectInfo), "ROOT_NAME");
					r_ROOT_NAME.SetBelong(null);
				}
				return r_ROOT_NAME;
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


        public REffectInfo() : base("EffectInfo")
        {
        }

        public REffectInfo(System.Object instance) : base("EffectInfo")
		{
            SetInstance(instance);
		}

        public REffectInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REffectInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
