using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneSoundConfig
	/// </summary>
    public partial class RSceneSoundConfig : RMember //
    {

		/// <summary>
		/// System.String mName
		/// </summary>
		protected RField r_mName;
		public virtual RField RmName
		{
			get
			{
				if(r_mName == null)
				{
					r_mName = new(this, "mName");
					r_mName.SetBelong(this.instance);
				}
				return r_mName;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 mPos
		/// </summary>
		protected RUnityEngine.RVector3 r_mPos;
		public virtual RUnityEngine.RVector3 RmPos
		{
			get
			{
				if(r_mPos == null)
				{
					r_mPos = new(this, "mPos");
					r_mPos.SetBelong(this.instance);
				}
				return r_mPos;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected RField r_url;
		public virtual RField Rurl
		{
			get
			{
				if(r_url == null)
				{
					r_url = new(this, "url");
					r_url.SetBelong(this.instance);
				}
				return r_url;
			}
		}

		/// <summary>
		/// System.Single LoopIntervalTime
		/// </summary>
		protected RField r_LoopIntervalTime;
		public virtual RField RLoopIntervalTime
		{
			get
			{
				if(r_LoopIntervalTime == null)
				{
					r_LoopIntervalTime = new(this, "LoopIntervalTime");
					r_LoopIntervalTime.SetBelong(this.instance);
				}
				return r_LoopIntervalTime;
			}
		}

		/// <summary>
		/// System.Single volume
		/// </summary>
		protected RField r_volume;
		public virtual RField Rvolume
		{
			get
			{
				if(r_volume == null)
				{
					r_volume = new(this, "volume");
					r_volume.SetBelong(this.instance);
				}
				return r_volume;
			}
		}

		/// <summary>
		/// System.Single rolloffFactor
		/// </summary>
		protected RField r_rolloffFactor;
		public virtual RField RrolloffFactor
		{
			get
			{
				if(r_rolloffFactor == null)
				{
					r_rolloffFactor = new(this, "rolloffFactor");
					r_rolloffFactor.SetBelong(this.instance);
				}
				return r_rolloffFactor;
			}
		}

		/// <summary>
		/// System.Boolean isCameraSound
		/// </summary>
		protected RField r_isCameraSound;
		public virtual RField RisCameraSound
		{
			get
			{
				if(r_isCameraSound == null)
				{
					r_isCameraSound = new(this, "isCameraSound");
					r_isCameraSound.SetBelong(this.instance);
				}
				return r_isCameraSound;
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


        public RSceneSoundConfig() : base("SceneSoundConfig")
        {
        }

        public RSceneSoundConfig(System.Object instance) : base("SceneSoundConfig")
		{
            SetInstance(instance);
		}

        public RSceneSoundConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneSoundConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
