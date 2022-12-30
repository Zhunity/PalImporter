using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RSplineInterpolator
{
	
	/// <summary>
	/// SplineInterpolator+SplineNode
	/// </summary>
    public partial class RSplineNode : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 Point
		/// </summary>
		protected RUnityEngine.RVector3 r_Point;
		public virtual RUnityEngine.RVector3 RPoint
		{
			get
			{
				if(r_Point == null)
				{
					r_Point = new(this, "Point");
					r_Point.SetBelong(this.instance);
				}
				return r_Point;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion Rot
		/// </summary>
		protected RUnityEngine.RQuaternion r_Rot;
		public virtual RUnityEngine.RQuaternion Rot
		{
			get
			{
				if(r_Rot == null)
				{
					r_Rot = new(this, "Rot");
					r_Rot.SetBelong(this.instance);
				}
				return r_Rot;
			}
		}

		/// <summary>
		/// System.Single Time
		/// </summary>
		protected RField r_Time;
		public virtual RField RTime
		{
			get
			{
				if(r_Time == null)
				{
					r_Time = new(this, "Time");
					r_Time.SetBelong(this.instance);
				}
				return r_Time;
			}
		}

		/// <summary>
		/// System.Single DelateTime
		/// </summary>
		protected RField r_DelateTime;
		public virtual RField RDelateTime
		{
			get
			{
				if(r_DelateTime == null)
				{
					r_DelateTime = new(this, "DelateTime");
					r_DelateTime.SetBelong(this.instance);
				}
				return r_DelateTime;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 EaseIO
		/// </summary>
		protected RUnityEngine.RVector2 r_EaseIO;
		public virtual RUnityEngine.RVector2 REaseIO
		{
			get
			{
				if(r_EaseIO == null)
				{
					r_EaseIO = new(this, "EaseIO");
					r_EaseIO.SetBelong(this.instance);
				}
				return r_EaseIO;
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


        public RSplineNode() : base("SplineInterpolator+SplineNode")
        {
        }

        public RSplineNode(System.Object instance) : base("SplineInterpolator+SplineNode")
		{
            SetInstance(instance);
		}

        public RSplineNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSplineNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
}