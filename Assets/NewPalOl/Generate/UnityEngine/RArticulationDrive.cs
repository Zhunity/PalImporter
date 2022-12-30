using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.ArticulationDrive
	/// </summary>
    public partial class RArticulationDrive : RMember //
    {

		/// <summary>
		/// System.Single lowerLimit
		/// </summary>
		protected RField r_lowerLimit;
		public virtual RField RlowerLimit
		{
			get
			{
				if(r_lowerLimit == null)
				{
					r_lowerLimit = new(this, "lowerLimit");
					r_lowerLimit.SetBelong(this.instance);
				}
				return r_lowerLimit;
			}
		}

		/// <summary>
		/// System.Single upperLimit
		/// </summary>
		protected RField r_upperLimit;
		public virtual RField RupperLimit
		{
			get
			{
				if(r_upperLimit == null)
				{
					r_upperLimit = new(this, "upperLimit");
					r_upperLimit.SetBelong(this.instance);
				}
				return r_upperLimit;
			}
		}

		/// <summary>
		/// System.Single stiffness
		/// </summary>
		protected RField r_stiffness;
		public virtual RField Rstiffness
		{
			get
			{
				if(r_stiffness == null)
				{
					r_stiffness = new(this, "stiffness");
					r_stiffness.SetBelong(this.instance);
				}
				return r_stiffness;
			}
		}

		/// <summary>
		/// System.Single damping
		/// </summary>
		protected RField r_damping;
		public virtual RField Rdamping
		{
			get
			{
				if(r_damping == null)
				{
					r_damping = new(this, "damping");
					r_damping.SetBelong(this.instance);
				}
				return r_damping;
			}
		}

		/// <summary>
		/// System.Single forceLimit
		/// </summary>
		protected RField r_forceLimit;
		public virtual RField RforceLimit
		{
			get
			{
				if(r_forceLimit == null)
				{
					r_forceLimit = new(this, "forceLimit");
					r_forceLimit.SetBelong(this.instance);
				}
				return r_forceLimit;
			}
		}

		/// <summary>
		/// System.Single target
		/// </summary>
		protected RField r_target;
		public virtual RField Rtarget
		{
			get
			{
				if(r_target == null)
				{
					r_target = new(this, "target");
					r_target.SetBelong(this.instance);
				}
				return r_target;
			}
		}

		/// <summary>
		/// System.Single targetVelocity
		/// </summary>
		protected RField r_targetVelocity;
		public virtual RField RtargetVelocity
		{
			get
			{
				if(r_targetVelocity == null)
				{
					r_targetVelocity = new(this, "targetVelocity");
					r_targetVelocity.SetBelong(this.instance);
				}
				return r_targetVelocity;
			}
		}

		/// <summary>
		/// UnityEngine.ArticulationDriveType driveType
		/// </summary>
		protected RField r_driveType;
		public virtual RField RdriveType
		{
			get
			{
				if(r_driveType == null)
				{
					r_driveType = new(this, "driveType");
					r_driveType.SetBelong(this.instance);
				}
				return r_driveType;
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


        public RArticulationDrive() : base("UnityEngine.ArticulationDrive")
        {
        }

        public RArticulationDrive(System.Object instance) : base("UnityEngine.ArticulationDrive")
		{
            SetInstance(instance);
		}

        public RArticulationDrive(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RArticulationDrive(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
