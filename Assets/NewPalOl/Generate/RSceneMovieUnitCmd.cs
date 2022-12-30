using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieUnitCmd
	/// </summary>
    public partial class RSceneMovieUnitCmd : RMember //
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
		/// System.String m_ModName
		/// </summary>
		protected RField r_m_ModName;
		public virtual RField Rm_ModName
		{
			get
			{
				if(r_m_ModName == null)
				{
					r_m_ModName = new(this, "m_ModName");
					r_m_ModName.SetBelong(this.instance);
				}
				return r_m_ModName;
			}
		}

		/// <summary>
		/// System.String m_UnitName
		/// </summary>
		protected RField r_m_UnitName;
		public virtual RField Rm_UnitName
		{
			get
			{
				if(r_m_UnitName == null)
				{
					r_m_UnitName = new(this, "m_UnitName");
					r_m_UnitName.SetBelong(this.instance);
				}
				return r_m_UnitName;
			}
		}

		/// <summary>
		/// System.String m_AnimName
		/// </summary>
		protected RField r_m_AnimName;
		public virtual RField Rm_AnimName
		{
			get
			{
				if(r_m_AnimName == null)
				{
					r_m_AnimName = new(this, "m_AnimName");
					r_m_AnimName.SetBelong(this.instance);
				}
				return r_m_AnimName;
			}
		}

		/// <summary>
		/// System.String m_TargetName
		/// </summary>
		protected RField r_m_TargetName;
		public virtual RField Rm_TargetName
		{
			get
			{
				if(r_m_TargetName == null)
				{
					r_m_TargetName = new(this, "m_TargetName");
					r_m_TargetName.SetBelong(this.instance);
				}
				return r_m_TargetName;
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
		/// UnityEngine.Vector3 m_Position
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Position;
		public virtual RUnityEngine.RVector3 Rm_Position
		{
			get
			{
				if(r_m_Position == null)
				{
					r_m_Position = new(this, "m_Position");
					r_m_Position.SetBelong(this.instance);
				}
				return r_m_Position;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Rotation
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Rotation;
		public virtual RUnityEngine.RVector3 Rm_Rotation
		{
			get
			{
				if(r_m_Rotation == null)
				{
					r_m_Rotation = new(this, "m_Rotation");
					r_m_Rotation.SetBelong(this.instance);
				}
				return r_m_Rotation;
			}
		}

		/// <summary>
		/// System.Boolean m_bLoop
		/// </summary>
		protected RField r_m_bLoop;
		public virtual RField Rm_bLoop
		{
			get
			{
				if(r_m_bLoop == null)
				{
					r_m_bLoop = new(this, "m_bLoop");
					r_m_bLoop.SetBelong(this.instance);
				}
				return r_m_bLoop;
			}
		}

		/// <summary>
		/// System.Boolean m_bShow
		/// </summary>
		protected RField r_m_bShow;
		public virtual RField Rm_bShow
		{
			get
			{
				if(r_m_bShow == null)
				{
					r_m_bShow = new(this, "m_bShow");
					r_m_bShow.SetBelong(this.instance);
				}
				return r_m_bShow;
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
		/// System.Single m_fAnimSpeed
		/// </summary>
		protected RField r_m_fAnimSpeed;
		public virtual RField Rm_fAnimSpeed
		{
			get
			{
				if(r_m_fAnimSpeed == null)
				{
					r_m_fAnimSpeed = new(this, "m_fAnimSpeed");
					r_m_fAnimSpeed.SetBelong(this.instance);
				}
				return r_m_fAnimSpeed;
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
		/// System.Single m_fScale
		/// </summary>
		protected RField r_m_fScale;
		public virtual RField Rm_fScale
		{
			get
			{
				if(r_m_fScale == null)
				{
					r_m_fScale = new(this, "m_fScale");
					r_m_fScale.SetBelong(this.instance);
				}
				return r_m_fScale;
			}
		}

		/// <summary>
		/// System.Single m_fAlpha
		/// </summary>
		protected RField r_m_fAlpha;
		public virtual RField Rm_fAlpha
		{
			get
			{
				if(r_m_fAlpha == null)
				{
					r_m_fAlpha = new(this, "m_fAlpha");
					r_m_fAlpha.SetBelong(this.instance);
				}
				return r_m_fAlpha;
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


        public RSceneMovieUnitCmd() : base("SceneMovieUnitCmd")
        {
        }

        public RSceneMovieUnitCmd(System.Object instance) : base("SceneMovieUnitCmd")
		{
            SetInstance(instance);
		}

        public RSceneMovieUnitCmd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieUnitCmd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
