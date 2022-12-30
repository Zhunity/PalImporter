using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarProcess
{public partial class REdge
{
	
	/// <summary>
	/// AstarProcess.Edge+EdgeIntersection
	/// </summary>
    public partial class REdgeIntersection : RMember //
    {

		/// <summary>
		/// AstarProcess.Edge+LineClassification type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// AstarProcess.Edge+OnLinePosition pos
		/// </summary>
		protected RField r_pos;
		public virtual RField Rpos
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
		/// UnityEngine.Vector3 intersectionA
		/// </summary>
		protected RUnityEngine.RVector3 r_intersectionA;
		public virtual RUnityEngine.RVector3 RintersectionA
		{
			get
			{
				if(r_intersectionA == null)
				{
					r_intersectionA = new(this, "intersectionA");
					r_intersectionA.SetBelong(this.instance);
				}
				return r_intersectionA;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 intersectionB
		/// </summary>
		protected RUnityEngine.RVector3 r_intersectionB;
		public virtual RUnityEngine.RVector3 RintersectionB
		{
			get
			{
				if(r_intersectionB == null)
				{
					r_intersectionB = new(this, "intersectionB");
					r_intersectionB.SetBelong(this.instance);
				}
				return r_intersectionB;
			}
		}

		/// <summary>
		/// Boolean intersects
		/// </summary>
		protected RProperty r_intersects;
		public virtual RProperty Rintersects
		{
			get
			{
				if(r_intersects == null)
				{
					r_intersects = new(this, "intersects", -1);
					r_intersects.SetBelong(this.instance);
				}
				return r_intersects;
			}
		}

		/// <summary>
		/// Boolean segementsIntersects
		/// </summary>
		protected RProperty r_segementsIntersects;
		public virtual RProperty RsegementsIntersects
		{
			get
			{
				if(r_segementsIntersects == null)
				{
					r_segementsIntersects = new(this, "segementsIntersects", -1);
					r_segementsIntersects.SetBelong(this.instance);
				}
				return r_segementsIntersects;
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


        public REdgeIntersection() : base("AstarProcess.Edge+EdgeIntersection")
        {
        }

        public REdgeIntersection(System.Object instance) : base("AstarProcess.Edge+EdgeIntersection")
		{
            SetInstance(instance);
		}

        public REdgeIntersection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REdgeIntersection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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