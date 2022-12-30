using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.DetailInstanceTransform
	/// </summary>
    public partial class RDetailInstanceTransform : RMember //
    {

		/// <summary>
		/// System.Single posX
		/// </summary>
		protected RField r_posX;
		public virtual RField RposX
		{
			get
			{
				if(r_posX == null)
				{
					r_posX = new(this, "posX");
					r_posX.SetBelong(this.instance);
				}
				return r_posX;
			}
		}

		/// <summary>
		/// System.Single posY
		/// </summary>
		protected RField r_posY;
		public virtual RField RposY
		{
			get
			{
				if(r_posY == null)
				{
					r_posY = new(this, "posY");
					r_posY.SetBelong(this.instance);
				}
				return r_posY;
			}
		}

		/// <summary>
		/// System.Single posZ
		/// </summary>
		protected RField r_posZ;
		public virtual RField RposZ
		{
			get
			{
				if(r_posZ == null)
				{
					r_posZ = new(this, "posZ");
					r_posZ.SetBelong(this.instance);
				}
				return r_posZ;
			}
		}

		/// <summary>
		/// System.Single scaleXZ
		/// </summary>
		protected RField r_scaleXZ;
		public virtual RField RscaleXZ
		{
			get
			{
				if(r_scaleXZ == null)
				{
					r_scaleXZ = new(this, "scaleXZ");
					r_scaleXZ.SetBelong(this.instance);
				}
				return r_scaleXZ;
			}
		}

		/// <summary>
		/// System.Single scaleY
		/// </summary>
		protected RField r_scaleY;
		public virtual RField RscaleY
		{
			get
			{
				if(r_scaleY == null)
				{
					r_scaleY = new(this, "scaleY");
					r_scaleY.SetBelong(this.instance);
				}
				return r_scaleY;
			}
		}

		/// <summary>
		/// System.Single rotationY
		/// </summary>
		protected RField r_rotationY;
		public virtual RField RrotationY
		{
			get
			{
				if(r_rotationY == null)
				{
					r_rotationY = new(this, "rotationY");
					r_rotationY.SetBelong(this.instance);
				}
				return r_rotationY;
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


        public RDetailInstanceTransform() : base("UnityEngine.DetailInstanceTransform")
        {
        }

        public RDetailInstanceTransform(System.Object instance) : base("UnityEngine.DetailInstanceTransform")
		{
            SetInstance(instance);
		}

        public RDetailInstanceTransform(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDetailInstanceTransform(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
