using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// AstarUser
	/// </summary>
    public partial class RAstarUser : RMember //
    {

		/// <summary>
		/// AstarClasses.Node GetNearestNode(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RGetNearestNode_Vector3;
		public static RMethod RGetNearestNode_Vector3
		{
			get
			{
				if(r_RGetNearestNode_Vector3 == null)
				{
					r_RGetNearestNode_Vector3 = new(typeof(AstarUser), "GetNearestNode", 0, typeof(UnityEngine.Vector3));
					r_RGetNearestNode_Vector3.SetBelong(null);
				}
				return r_RGetNearestNode_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetNearestNodePosition(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RGetNearestNodePosition_Vector3;
		public virtual RMethod RGetNearestNodePosition_Vector3
		{
			get
			{
				if(r_RGetNearestNodePosition_Vector3 == null)
				{
					r_RGetNearestNodePosition_Vector3 = new(this, "GetNearestNodePosition", 0, typeof(UnityEngine.Vector3));
					r_RGetNearestNodePosition_Vector3.SetBelong(this.instance);
				}
				return r_RGetNearestNodePosition_Vector3;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetNearestNodePositionUnclamped(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RGetNearestNodePositionUnclamped_Vector3;
		public virtual RMethod RGetNearestNodePositionUnclamped_Vector3
		{
			get
			{
				if(r_RGetNearestNodePositionUnclamped_Vector3 == null)
				{
					r_RGetNearestNodePositionUnclamped_Vector3 = new(this, "GetNearestNodePositionUnclamped", 0, typeof(UnityEngine.Vector3));
					r_RGetNearestNodePositionUnclamped_Vector3.SetBelong(this.instance);
				}
				return r_RGetNearestNodePositionUnclamped_Vector3;
			}
		}

		/// <summary>
		/// Boolean IsPositionInsideAnyGrids(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RIsPositionInsideAnyGrids_Vector3;
		public static RMethod RIsPositionInsideAnyGrids_Vector3
		{
			get
			{
				if(r_RIsPositionInsideAnyGrids_Vector3 == null)
				{
					r_RIsPositionInsideAnyGrids_Vector3 = new(typeof(AstarUser), "IsPositionInsideAnyGrids", 0, typeof(UnityEngine.Vector3));
					r_RIsPositionInsideAnyGrids_Vector3.SetBelong(null);
				}
				return r_RIsPositionInsideAnyGrids_Vector3;
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


        public RAstarUser() : base("AstarUser")
        {
        }

        public RAstarUser(System.Object instance) : base("AstarUser")
		{
            SetInstance(instance);
		}

        public RAstarUser(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAstarUser(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static AstarClasses.Node GetNearestNode(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RGetNearestNode_Vector3.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node)___result;
        }


        public virtual UnityEngine.Vector3 GetNearestNodePosition(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RGetNearestNodePosition_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual UnityEngine.Vector3 GetNearestNodePositionUnclamped(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RGetNearestNodePositionUnclamped_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static System.Boolean IsPositionInsideAnyGrids(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RIsPositionInsideAnyGrids_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
