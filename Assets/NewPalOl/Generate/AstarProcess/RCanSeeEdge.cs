using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarProcess
{
	/// <summary>
	/// AstarProcess.CanSeeEdge
	/// </summary>
    public partial class RCanSeeEdge : RMember //
    {

		/// <summary>
		/// AstarProcess.Edge edge
		/// </summary>
		protected RAstarProcess.REdge r_edge;
		public virtual RAstarProcess.REdge Redge
		{
			get
			{
				if(r_edge == null)
				{
					r_edge = new(this, "edge");
					r_edge.SetBelong(this.instance);
				}
				return r_edge;
			}
		}

		/// <summary>
		/// System.Boolean canSeeA
		/// </summary>
		protected RField r_canSeeA;
		public virtual RField RcanSeeA
		{
			get
			{
				if(r_canSeeA == null)
				{
					r_canSeeA = new(this, "canSeeA");
					r_canSeeA.SetBelong(this.instance);
				}
				return r_canSeeA;
			}
		}

		/// <summary>
		/// System.Boolean canSeeB
		/// </summary>
		protected RField r_canSeeB;
		public virtual RField RcanSeeB
		{
			get
			{
				if(r_canSeeB == null)
				{
					r_canSeeB = new(this, "canSeeB");
					r_canSeeB.SetBelong(this.instance);
				}
				return r_canSeeB;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 nearestPoint1
		/// </summary>
		protected RUnityEngine.RVector3 r_nearestPoint1;
		public virtual RUnityEngine.RVector3 RnearestPoint1
		{
			get
			{
				if(r_nearestPoint1 == null)
				{
					r_nearestPoint1 = new(this, "nearestPoint1");
					r_nearestPoint1.SetBelong(this.instance);
				}
				return r_nearestPoint1;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 nearestPoint2
		/// </summary>
		protected RUnityEngine.RVector3 r_nearestPoint2;
		public virtual RUnityEngine.RVector3 RnearestPoint2
		{
			get
			{
				if(r_nearestPoint2 == null)
				{
					r_nearestPoint2 = new(this, "nearestPoint2");
					r_nearestPoint2.SetBelong(this.instance);
				}
				return r_nearestPoint2;
			}
		}

		/// <summary>
		/// AstarProcess.Edge+OnLinePosition pos1
		/// </summary>
		protected RField r_pos1;
		public virtual RField Rpos1
		{
			get
			{
				if(r_pos1 == null)
				{
					r_pos1 = new(this, "pos1");
					r_pos1.SetBelong(this.instance);
				}
				return r_pos1;
			}
		}

		/// <summary>
		/// AstarProcess.Edge+OnLinePosition pos2
		/// </summary>
		protected RField r_pos2;
		public virtual RField Rpos2
		{
			get
			{
				if(r_pos2 == null)
				{
					r_pos2 = new(this, "pos2");
					r_pos2.SetBelong(this.instance);
				}
				return r_pos2;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// System.Single distA
		/// </summary>
		protected RField r_distA;
		public virtual RField RdistA
		{
			get
			{
				if(r_distA == null)
				{
					r_distA = new(this, "distA");
					r_distA.SetBelong(this.instance);
				}
				return r_distA;
			}
		}

		/// <summary>
		/// System.Single distB
		/// </summary>
		protected RField r_distB;
		public virtual RField RdistB
		{
			get
			{
				if(r_distB == null)
				{
					r_distB = new(this, "distB");
					r_distB.SetBelong(this.instance);
				}
				return r_distB;
			}
		}

		/// <summary>
		/// Boolean canSeeAny
		/// </summary>
		protected RProperty r_canSeeAny;
		public virtual RProperty RcanSeeAny
		{
			get
			{
				if(r_canSeeAny == null)
				{
					r_canSeeAny = new(this, "canSeeAny", -1);
					r_canSeeAny.SetBelong(this.instance);
				}
				return r_canSeeAny;
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


        public RCanSeeEdge() : base("AstarProcess.CanSeeEdge")
        {
        }

        public RCanSeeEdge(System.Object instance) : base("AstarProcess.CanSeeEdge")
		{
            SetInstance(instance);
		}

        public RCanSeeEdge(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCanSeeEdge(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
