using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarClasses
{
	/// <summary>
	/// AstarClasses.SimpleNode
	/// </summary>
    public partial class RSimpleNode : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 vectorPos
		/// </summary>
		protected RUnityEngine.RVector3 r_vectorPos;
		public virtual RUnityEngine.RVector3 RvectorPos
		{
			get
			{
				if(r_vectorPos == null)
				{
					r_vectorPos = new(this, "vectorPos");
					r_vectorPos.SetBelong(this.instance);
				}
				return r_vectorPos;
			}
		}

		/// <summary>
		/// System.Single[] angles
		/// </summary>
		protected RFieldArray<RField> r_angles;
		public virtual RFieldArray<RField> Rangles
		{
			get
			{
				if(r_angles == null)
				{
					r_angles = new(this, "angles");
					r_angles.SetBelong(this.instance);
				}
				return r_angles;
			}
		}

		/// <summary>
		/// AstarClasses.SimpleNode[] neighbours
		/// </summary>
		protected RFieldArray<RAstarClasses.RSimpleNode> r_neighbours;
		public virtual RFieldArray<RAstarClasses.RSimpleNode> Rneighbours
		{
			get
			{
				if(r_neighbours == null)
				{
					r_neighbours = new(this, "neighbours");
					r_neighbours.SetBelong(this.instance);
				}
				return r_neighbours;
			}
		}

		/// <summary>
		/// System.Int32[] costs
		/// </summary>
		protected RFieldArray<RField> r_costs;
		public virtual RFieldArray<RField> Rcosts
		{
			get
			{
				if(r_costs == null)
				{
					r_costs = new(this, "costs");
					r_costs.SetBelong(this.instance);
				}
				return r_costs;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 pos
		/// </summary>
		protected RAstarClasses.RInt3 r_pos;
		public virtual RAstarClasses.RInt3 Rpos
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


        public RSimpleNode() : base("AstarClasses.SimpleNode")
        {
        }

        public RSimpleNode(System.Object instance) : base("AstarClasses.SimpleNode")
		{
            SetInstance(instance);
		}

        public RSimpleNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSimpleNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
