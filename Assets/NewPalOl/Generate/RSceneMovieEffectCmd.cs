using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieEffectCmd
	/// </summary>
    public partial class RSceneMovieEffectCmd : RMember //
    {

		/// <summary>
		/// System.String m_sCmdType
		/// </summary>
		protected RField r_m_sCmdType;
		public virtual RField Rm_sCmdType
		{
			get
			{
				if(r_m_sCmdType == null)
				{
					r_m_sCmdType = new(this, "m_sCmdType");
					r_m_sCmdType.SetBelong(this.instance);
				}
				return r_m_sCmdType;
			}
		}

		/// <summary>
		/// System.String m_AssetName
		/// </summary>
		protected RField r_m_AssetName;
		public virtual RField Rm_AssetName
		{
			get
			{
				if(r_m_AssetName == null)
				{
					r_m_AssetName = new(this, "m_AssetName");
					r_m_AssetName.SetBelong(this.instance);
				}
				return r_m_AssetName;
			}
		}

		/// <summary>
		/// System.String m_EffectName
		/// </summary>
		protected RField r_m_EffectName;
		public virtual RField Rm_EffectName
		{
			get
			{
				if(r_m_EffectName == null)
				{
					r_m_EffectName = new(this, "m_EffectName");
					r_m_EffectName.SetBelong(this.instance);
				}
				return r_m_EffectName;
			}
		}

		/// <summary>
		/// System.String m_NodeName
		/// </summary>
		protected RField r_m_NodeName;
		public virtual RField Rm_NodeName
		{
			get
			{
				if(r_m_NodeName == null)
				{
					r_m_NodeName = new(this, "m_NodeName");
					r_m_NodeName.SetBelong(this.instance);
				}
				return r_m_NodeName;
			}
		}

		/// <summary>
		/// System.Single m_fTime
		/// </summary>
		protected RField r_m_fTime;
		public virtual RField Rm_fTime
		{
			get
			{
				if(r_m_fTime == null)
				{
					r_m_fTime = new(this, "m_fTime");
					r_m_fTime.SetBelong(this.instance);
				}
				return r_m_fTime;
			}
		}

		/// <summary>
		/// System.Single m_fStartTime
		/// </summary>
		protected RField r_m_fStartTime;
		public virtual RField Rm_fStartTime
		{
			get
			{
				if(r_m_fStartTime == null)
				{
					r_m_fStartTime = new(this, "m_fStartTime");
					r_m_fStartTime.SetBelong(this.instance);
				}
				return r_m_fStartTime;
			}
		}

		/// <summary>
		/// System.Single m_fSpeed
		/// </summary>
		protected RField r_m_fSpeed;
		public virtual RField Rm_fSpeed
		{
			get
			{
				if(r_m_fSpeed == null)
				{
					r_m_fSpeed = new(this, "m_fSpeed");
					r_m_fSpeed.SetBelong(this.instance);
				}
				return r_m_fSpeed;
			}
		}

		/// <summary>
		/// System.String m_BoneName
		/// </summary>
		protected RField r_m_BoneName;
		public virtual RField Rm_BoneName
		{
			get
			{
				if(r_m_BoneName == null)
				{
					r_m_BoneName = new(this, "m_BoneName");
					r_m_BoneName.SetBelong(this.instance);
				}
				return r_m_BoneName;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vPos;
		public virtual RUnityEngine.RVector3 Rm_vPos
		{
			get
			{
				if(r_m_vPos == null)
				{
					r_m_vPos = new(this, "m_vPos");
					r_m_vPos.SetBelong(this.instance);
				}
				return r_m_vPos;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vRot
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vRot;
		public virtual RUnityEngine.RVector3 Rm_vRot
		{
			get
			{
				if(r_m_vRot == null)
				{
					r_m_vRot = new(this, "m_vRot");
					r_m_vRot.SetBelong(this.instance);
				}
				return r_m_vRot;
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


        public RSceneMovieEffectCmd() : base("SceneMovieEffectCmd")
        {
        }

        public RSceneMovieEffectCmd(System.Object instance) : base("SceneMovieEffectCmd")
		{
            SetInstance(instance);
		}

        public RSceneMovieEffectCmd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieEffectCmd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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