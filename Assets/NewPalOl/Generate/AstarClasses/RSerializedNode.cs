using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarClasses
{
	/// <summary>
	/// AstarClasses.SerializedNode
	/// </summary>
    public partial class RSerializedNode : RMember //
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
		/// System.Boolean walkable
		/// </summary>
		protected RField r_walkable;
		public virtual RField Rwalkable
		{
			get
			{
				if(r_walkable == null)
				{
					r_walkable = new(this, "walkable");
					r_walkable.SetBelong(this.instance);
				}
				return r_walkable;
			}
		}

		/// <summary>
		/// System.Int32 penalty
		/// </summary>
		protected RField r_penalty;
		public virtual RField Rpenalty
		{
			get
			{
				if(r_penalty == null)
				{
					r_penalty = new(this, "penalty");
					r_penalty.SetBelong(this.instance);
				}
				return r_penalty;
			}
		}

		/// <summary>
		/// System.Int32 area
		/// </summary>
		protected RField r_area;
		public virtual RField Rarea
		{
			get
			{
				if(r_area == null)
				{
					r_area = new(this, "area");
					r_area.SetBelong(this.instance);
				}
				return r_area;
			}
		}

		/// <summary>
		/// AstarClasses.Int3[] serializedConnections
		/// </summary>
		protected RFieldArray<RAstarClasses.RInt3> r_serializedConnections;
		public virtual RFieldArray<RAstarClasses.RInt3> RserializedConnections
		{
			get
			{
				if(r_serializedConnections == null)
				{
					r_serializedConnections = new(this, "serializedConnections");
					r_serializedConnections.SetBelong(this.instance);
				}
				return r_serializedConnections;
			}
		}

		/// <summary>
		/// System.Boolean[] serilizedConnectionsEnabled
		/// </summary>
		protected RFieldArray<RField> r_serilizedConnectionsEnabled;
		public virtual RFieldArray<RField> RserilizedConnectionsEnabled
		{
			get
			{
				if(r_serilizedConnectionsEnabled == null)
				{
					r_serilizedConnectionsEnabled = new(this, "serilizedConnectionsEnabled");
					r_serilizedConnectionsEnabled.SetBelong(this.instance);
				}
				return r_serilizedConnectionsEnabled;
			}
		}

		/// <summary>
		/// AstarClasses.Node op_Implicit(AstarClasses.SerializedNode)
		/// </summary>
		protected static RMethod r_Rop_Implicit_SerializedNode;
		public static RMethod Rop_Implicit_SerializedNode
		{
			get
			{
				if(r_Rop_Implicit_SerializedNode == null)
				{
					r_Rop_Implicit_SerializedNode = new(typeof(AstarClasses.SerializedNode), "op_Implicit", 0, typeof(AstarClasses.SerializedNode));
					r_Rop_Implicit_SerializedNode.SetBelong(null);
				}
				return r_Rop_Implicit_SerializedNode;
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


        public RSerializedNode() : base("AstarClasses.SerializedNode")
        {
        }

        public RSerializedNode(System.Object instance) : base("AstarClasses.SerializedNode")
		{
            SetInstance(instance);
		}

        public RSerializedNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSerializedNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static AstarClasses.Node op_Implicit(AstarClasses.SerializedNode  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = Rop_Implicit_SerializedNode.Invoke(___genericsType, ___parameters);

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
