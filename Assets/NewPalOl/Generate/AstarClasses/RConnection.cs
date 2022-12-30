using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarClasses
{
	/// <summary>
	/// AstarClasses.Connection
	/// </summary>
    public partial class RConnection : RMember //
    {

		/// <summary>
		/// AstarClasses.Int3 _startNode
		/// </summary>
		protected RAstarClasses.RInt3 r__startNode;
		public virtual RAstarClasses.RInt3 R_startNode
		{
			get
			{
				if(r__startNode == null)
				{
					r__startNode = new(this, "_startNode");
					r__startNode.SetBelong(this.instance);
				}
				return r__startNode;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 _endNode
		/// </summary>
		protected RAstarClasses.RInt3 r__endNode;
		public virtual RAstarClasses.RInt3 R_endNode
		{
			get
			{
				if(r__endNode == null)
				{
					r__endNode = new(this, "_endNode");
					r__endNode.SetBelong(this.instance);
				}
				return r__endNode;
			}
		}

		/// <summary>
		/// System.Single angle
		/// </summary>
		protected RField r_angle;
		public virtual RField Rangle
		{
			get
			{
				if(r_angle == null)
				{
					r_angle = new(this, "angle");
					r_angle.SetBelong(this.instance);
				}
				return r_angle;
			}
		}

		/// <summary>
		/// System.Int32 cost
		/// </summary>
		protected RField r_cost;
		public virtual RField Rcost
		{
			get
			{
				if(r_cost == null)
				{
					r_cost = new(this, "cost");
					r_cost.SetBelong(this.instance);
				}
				return r_cost;
			}
		}

		/// <summary>
		/// System.Boolean enabled
		/// </summary>
		protected RField r_enabled;
		public virtual RField Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled");
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// AstarClasses.Node startNode
		/// </summary>
		protected RAstarClasses.RNode r_startNode;
		public virtual RAstarClasses.RNode RstartNode
		{
			get
			{
				if(r_startNode == null)
				{
					r_startNode = new(this, "startNode", -1);
					r_startNode.SetBelong(this.instance);
				}
				return r_startNode;
			}
		}

		/// <summary>
		/// AstarClasses.Node endNode
		/// </summary>
		protected RAstarClasses.RNode r_endNode;
		public virtual RAstarClasses.RNode RendNode
		{
			get
			{
				if(r_endNode == null)
				{
					r_endNode = new(this, "endNode", -1);
					r_endNode.SetBelong(this.instance);
				}
				return r_endNode;
			}
		}

		/// <summary>
		/// AstarClasses.Node op_Implicit(AstarClasses.Connection)
		/// </summary>
		protected static RMethod r_Rop_Implicit_Connection;
		public static RMethod Rop_Implicit_Connection
		{
			get
			{
				if(r_Rop_Implicit_Connection == null)
				{
					r_Rop_Implicit_Connection = new(typeof(AstarClasses.Connection), "op_Implicit", 0, typeof(AstarClasses.Connection));
					r_Rop_Implicit_Connection.SetBelong(null);
				}
				return r_Rop_Implicit_Connection;
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


        public RConnection() : base("AstarClasses.Connection")
        {
        }

        public RConnection(System.Object instance) : base("AstarClasses.Connection")
		{
            SetInstance(instance);
		}

        public RConnection(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RConnection(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static AstarClasses.Node op_Implicit(AstarClasses.Connection  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = Rop_Implicit_Connection.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node)___result;
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
