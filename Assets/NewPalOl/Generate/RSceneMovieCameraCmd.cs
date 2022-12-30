using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieCameraCmd
	/// </summary>
    public partial class RSceneMovieCameraCmd : RMember //
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
		/// UnityEngine.Color m_MaskColor
		/// </summary>
		protected RUnityEngine.RColor r_m_MaskColor;
		public virtual RUnityEngine.RColor Rm_MaskColor
		{
			get
			{
				if(r_m_MaskColor == null)
				{
					r_m_MaskColor = new(this, "m_MaskColor");
					r_m_MaskColor.SetBelong(this.instance);
				}
				return r_m_MaskColor;
			}
		}

		/// <summary>
		/// System.Single m_ShakeV
		/// </summary>
		protected RField r_m_ShakeV;
		public virtual RField Rm_ShakeV
		{
			get
			{
				if(r_m_ShakeV == null)
				{
					r_m_ShakeV = new(this, "m_ShakeV");
					r_m_ShakeV.SetBelong(this.instance);
				}
				return r_m_ShakeV;
			}
		}

		/// <summary>
		/// System.Single m_ShakeH
		/// </summary>
		protected RField r_m_ShakeH;
		public virtual RField Rm_ShakeH
		{
			get
			{
				if(r_m_ShakeH == null)
				{
					r_m_ShakeH = new(this, "m_ShakeH");
					r_m_ShakeH.SetBelong(this.instance);
				}
				return r_m_ShakeH;
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
		/// System.String m_sName
		/// </summary>
		protected RField r_m_sName;
		public virtual RField Rm_sName
		{
			get
			{
				if(r_m_sName == null)
				{
					r_m_sName = new(this, "m_sName");
					r_m_sName.SetBelong(this.instance);
				}
				return r_m_sName;
			}
		}

		/// <summary>
		/// System.String m_RefName
		/// </summary>
		protected RField r_m_RefName;
		public virtual RField Rm_RefName
		{
			get
			{
				if(r_m_RefName == null)
				{
					r_m_RefName = new(this, "m_RefName");
					r_m_RefName.SetBelong(this.instance);
				}
				return r_m_RefName;
			}
		}

		/// <summary>
		/// System.Boolean m_bFollow
		/// </summary>
		protected RField r_m_bFollow;
		public virtual RField Rm_bFollow
		{
			get
			{
				if(r_m_bFollow == null)
				{
					r_m_bFollow = new(this, "m_bFollow");
					r_m_bFollow.SetBelong(this.instance);
				}
				return r_m_bFollow;
			}
		}

		/// <summary>
		/// System.Boolean m_bLerp
		/// </summary>
		protected RField r_m_bLerp;
		public virtual RField Rm_bLerp
		{
			get
			{
				if(r_m_bLerp == null)
				{
					r_m_bLerp = new(this, "m_bLerp");
					r_m_bLerp.SetBelong(this.instance);
				}
				return r_m_bLerp;
			}
		}

		/// <summary>
		/// System.Boolean m_bOn
		/// </summary>
		protected RField r_m_bOn;
		public virtual RField Rm_bOn
		{
			get
			{
				if(r_m_bOn == null)
				{
					r_m_bOn = new(this, "m_bOn");
					r_m_bOn.SetBelong(this.instance);
				}
				return r_m_bOn;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vRotation
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vRotation;
		public virtual RUnityEngine.RVector3 Rm_vRotation
		{
			get
			{
				if(r_m_vRotation == null)
				{
					r_m_vRotation = new(this, "m_vRotation");
					r_m_vRotation.SetBelong(this.instance);
				}
				return r_m_vRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_vCenterPos
		/// </summary>
		protected RUnityEngine.RVector3 r_m_vCenterPos;
		public virtual RUnityEngine.RVector3 Rm_vCenterPos
		{
			get
			{
				if(r_m_vCenterPos == null)
				{
					r_m_vCenterPos = new(this, "m_vCenterPos");
					r_m_vCenterPos.SetBelong(this.instance);
				}
				return r_m_vCenterPos;
			}
		}

		/// <summary>
		/// System.Single m_fDistance
		/// </summary>
		protected RField r_m_fDistance;
		public virtual RField Rm_fDistance
		{
			get
			{
				if(r_m_fDistance == null)
				{
					r_m_fDistance = new(this, "m_fDistance");
					r_m_fDistance.SetBelong(this.instance);
				}
				return r_m_fDistance;
			}
		}

		/// <summary>
		/// System.String m_CrossTex
		/// </summary>
		protected RField r_m_CrossTex;
		public virtual RField Rm_CrossTex
		{
			get
			{
				if(r_m_CrossTex == null)
				{
					r_m_CrossTex = new(this, "m_CrossTex");
					r_m_CrossTex.SetBelong(this.instance);
				}
				return r_m_CrossTex;
			}
		}

		/// <summary>
		/// System.String m_CrossMode
		/// </summary>
		protected RField r_m_CrossMode;
		public virtual RField Rm_CrossMode
		{
			get
			{
				if(r_m_CrossMode == null)
				{
					r_m_CrossMode = new(this, "m_CrossMode");
					r_m_CrossMode.SetBelong(this.instance);
				}
				return r_m_CrossMode;
			}
		}

		/// <summary>
		/// System.Single m_fCrossTime
		/// </summary>
		protected RField r_m_fCrossTime;
		public virtual RField Rm_fCrossTime
		{
			get
			{
				if(r_m_fCrossTime == null)
				{
					r_m_fCrossTime = new(this, "m_fCrossTime");
					r_m_fCrossTime.SetBelong(this.instance);
				}
				return r_m_fCrossTime;
			}
		}

		/// <summary>
		/// System.Single m_fSize
		/// </summary>
		protected RField r_m_fSize;
		public virtual RField Rm_fSize
		{
			get
			{
				if(r_m_fSize == null)
				{
					r_m_fSize = new(this, "m_fSize");
					r_m_fSize.SetBelong(this.instance);
				}
				return r_m_fSize;
			}
		}

		/// <summary>
		/// System.Int32 m_nFromInt
		/// </summary>
		protected RField r_m_nFromInt;
		public virtual RField Rm_nFromInt
		{
			get
			{
				if(r_m_nFromInt == null)
				{
					r_m_nFromInt = new(this, "m_nFromInt");
					r_m_nFromInt.SetBelong(this.instance);
				}
				return r_m_nFromInt;
			}
		}

		/// <summary>
		/// System.Int32 m_nToInt
		/// </summary>
		protected RField r_m_nToInt;
		public virtual RField Rm_nToInt
		{
			get
			{
				if(r_m_nToInt == null)
				{
					r_m_nToInt = new(this, "m_nToInt");
					r_m_nToInt.SetBelong(this.instance);
				}
				return r_m_nToInt;
			}
		}

		/// <summary>
		/// System.Single m_radiusX
		/// </summary>
		protected RField r_m_radiusX;
		public virtual RField Rm_radiusX
		{
			get
			{
				if(r_m_radiusX == null)
				{
					r_m_radiusX = new(this, "m_radiusX");
					r_m_radiusX.SetBelong(this.instance);
				}
				return r_m_radiusX;
			}
		}

		/// <summary>
		/// System.Single m_radiusY
		/// </summary>
		protected RField r_m_radiusY;
		public virtual RField Rm_radiusY
		{
			get
			{
				if(r_m_radiusY == null)
				{
					r_m_radiusY = new(this, "m_radiusY");
					r_m_radiusY.SetBelong(this.instance);
				}
				return r_m_radiusY;
			}
		}

		/// <summary>
		/// System.Int32 m_nFromVal
		/// </summary>
		protected RField r_m_nFromVal;
		public virtual RField Rm_nFromVal
		{
			get
			{
				if(r_m_nFromVal == null)
				{
					r_m_nFromVal = new(this, "m_nFromVal");
					r_m_nFromVal.SetBelong(this.instance);
				}
				return r_m_nFromVal;
			}
		}

		/// <summary>
		/// System.Int32 m_nToVal
		/// </summary>
		protected RField r_m_nToVal;
		public virtual RField Rm_nToVal
		{
			get
			{
				if(r_m_nToVal == null)
				{
					r_m_nToVal = new(this, "m_nToVal");
					r_m_nToVal.SetBelong(this.instance);
				}
				return r_m_nToVal;
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


        public RSceneMovieCameraCmd() : base("SceneMovieCameraCmd")
        {
        }

        public RSceneMovieCameraCmd(System.Object instance) : base("SceneMovieCameraCmd")
		{
            SetInstance(instance);
		}

        public RSceneMovieCameraCmd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieCameraCmd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
