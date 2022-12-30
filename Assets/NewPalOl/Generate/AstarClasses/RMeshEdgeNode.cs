using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarClasses
{
	/// <summary>
	/// AstarClasses.MeshEdgeNode
	/// </summary>
    public partial class RMeshEdgeNode : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector2[] area2D
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector2> r_area2D;
		public virtual RFieldArray<RUnityEngine.RVector2> Rarea2D
		{
			get
			{
				if(r_area2D == null)
				{
					r_area2D = new(this, "area2D");
					r_area2D.SetBelong(this.instance);
				}
				return r_area2D;
			}
		}

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
		/// System.Int32 basicCost
		/// </summary>
		protected RField r_basicCost;
		public virtual RField RbasicCost
		{
			get
			{
				if(r_basicCost == null)
				{
					r_basicCost = new(this, "basicCost");
					r_basicCost.SetBelong(this.instance);
				}
				return r_basicCost;
			}
		}

		/// <summary>
		/// System.Int32 extraCost
		/// </summary>
		protected RField r_extraCost;
		public virtual RField RextraCost
		{
			get
			{
				if(r_extraCost == null)
				{
					r_extraCost = new(this, "extraCost");
					r_extraCost.SetBelong(this.instance);
				}
				return r_extraCost;
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
		/// AstarProcess.Edge[] edges
		/// </summary>
		protected RFieldArray<RAstarProcess.REdge> r_edges;
		public virtual RFieldArray<RAstarProcess.REdge> Redges
		{
			get
			{
				if(r_edges == null)
				{
					r_edges = new(this, "edges");
					r_edges.SetBelong(this.instance);
				}
				return r_edges;
			}
		}

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
		/// AstarClasses.Connection[] connections
		/// </summary>
		protected RFieldArray<RAstarClasses.RConnection> r_connections;
		public virtual RFieldArray<RAstarClasses.RConnection> Rconnections
		{
			get
			{
				if(r_connections == null)
				{
					r_connections = new(this, "connections");
					r_connections.SetBelong(this.instance);
				}
				return r_connections;
			}
		}

		/// <summary>
		/// AstarClasses.Connection[] enabledConnections
		/// </summary>
		protected RFieldArray<RAstarClasses.RConnection> r_enabledConnections;
		public virtual RFieldArray<RAstarClasses.RConnection> RenabledConnections
		{
			get
			{
				if(r_enabledConnections == null)
				{
					r_enabledConnections = new(this, "enabledConnections");
					r_enabledConnections.SetBelong(this.instance);
				}
				return r_enabledConnections;
			}
		}

		/// <summary>
		/// System.Int32 areaTimeStamp
		/// </summary>
		protected RField r_areaTimeStamp;
		public virtual RField RareaTimeStamp
		{
			get
			{
				if(r_areaTimeStamp == null)
				{
					r_areaTimeStamp = new(this, "areaTimeStamp");
					r_areaTimeStamp.SetBelong(this.instance);
				}
				return r_areaTimeStamp;
			}
		}

		/// <summary>
		/// AstarPath+Path scripty
		/// </summary>
		protected RAstarPath.RPath r_scripty;
		public virtual RAstarPath.RPath Rscripty
		{
			get
			{
				if(r_scripty == null)
				{
					r_scripty = new(this, "scripty");
					r_scripty.SetBelong(this.instance);
				}
				return r_scripty;
			}
		}

		/// <summary>
		/// AstarPath+Path script
		/// </summary>
		protected RAstarPath.RPath r_script;
		public virtual RAstarPath.RPath Rscript
		{
			get
			{
				if(r_script == null)
				{
					r_script = new(this, "script");
					r_script.SetBelong(this.instance);
				}
				return r_script;
			}
		}

		/// <summary>
		/// System.Single dia
		/// </summary>
		protected RField r_dia;
		public virtual RField Rdia
		{
			get
			{
				if(r_dia == null)
				{
					r_dia = new(this, "dia");
					r_dia.SetBelong(this.instance);
				}
				return r_dia;
			}
		}

		/// <summary>
		/// System.Int32 depth
		/// </summary>
		protected RField r_depth;
		public virtual RField Rdepth
		{
			get
			{
				if(r_depth == null)
				{
					r_depth = new(this, "depth");
					r_depth.SetBelong(this.instance);
				}
				return r_depth;
			}
		}

		/// <summary>
		/// System.Int32 g
		/// </summary>
		protected RField r_g;
		public virtual RField Rg
		{
			get
			{
				if(r_g == null)
				{
					r_g = new(this, "g");
					r_g.SetBelong(this.instance);
				}
				return r_g;
			}
		}

		/// <summary>
		/// System.Int32 h
		/// </summary>
		protected RField r_h;
		public virtual RField Rh
		{
			get
			{
				if(r_h == null)
				{
					r_h = new(this, "h");
					r_h.SetBelong(this.instance);
				}
				return r_h;
			}
		}

		/// <summary>
		/// AstarClasses.Node parentx
		/// </summary>
		protected RAstarClasses.RNode r_parentx;
		public virtual RAstarClasses.RNode Rparentx
		{
			get
			{
				if(r_parentx == null)
				{
					r_parentx = new(this, "parentx", -1);
					r_parentx.SetBelong(this.instance);
				}
				return r_parentx;
			}
		}

		/// <summary>
		/// AstarClasses.Node parent
		/// </summary>
		protected RAstarClasses.RNode r_parent;
		public virtual RAstarClasses.RNode Rparent
		{
			get
			{
				if(r_parent == null)
				{
					r_parent = new(this, "parent", -1);
					r_parent.SetBelong(this.instance);
				}
				return r_parent;
			}
		}

		/// <summary>
		/// Int32 gScore
		/// </summary>
		protected RProperty r_gScore;
		public virtual RProperty RgScore
		{
			get
			{
				if(r_gScore == null)
				{
					r_gScore = new(this, "gScore", -1);
					r_gScore.SetBelong(this.instance);
				}
				return r_gScore;
			}
		}

		/// <summary>
		/// Int32 f
		/// </summary>
		protected RProperty r_f;
		public virtual RProperty Rf
		{
			get
			{
				if(r_f == null)
				{
					r_f = new(this, "f", -1);
					r_f.SetBelong(this.instance);
				}
				return r_f;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] GetArea()
		/// </summary>
		protected RMethod r_RGetArea;
		public virtual RMethod RGetArea
		{
			get
			{
				if(r_RGetArea == null)
				{
					r_RGetArea = new(this, "GetArea", 0);
					r_RGetArea.SetBelong(this.instance);
				}
				return r_RGetArea;
			}
		}

		/// <summary>
		/// Void GenerateEnabledConnections()
		/// </summary>
		protected RMethod r_RGenerateEnabledConnections;
		public virtual RMethod RGenerateEnabledConnections
		{
			get
			{
				if(r_RGenerateEnabledConnections == null)
				{
					r_RGenerateEnabledConnections = new(this, "GenerateEnabledConnections", 0);
					r_RGenerateEnabledConnections.SetBelong(this.instance);
				}
				return r_RGenerateEnabledConnections;
			}
		}

		/// <summary>
		/// Void AddConnection(AstarClasses.Connection)
		/// </summary>
		protected RMethod r_RAddConnection_Connection;
		public virtual RMethod RAddConnection_Connection
		{
			get
			{
				if(r_RAddConnection_Connection == null)
				{
					r_RAddConnection_Connection = new(this, "AddConnection", 0, typeof(AstarClasses.Connection));
					r_RAddConnection_Connection.SetBelong(this.instance);
				}
				return r_RAddConnection_Connection;
			}
		}

		/// <summary>
		/// Void UpdateG()
		/// </summary>
		protected RMethod r_RUpdateG;
		public virtual RMethod RUpdateG
		{
			get
			{
				if(r_RUpdateG == null)
				{
					r_RUpdateG = new(this, "UpdateG", 0);
					r_RUpdateG.SetBelong(this.instance);
				}
				return r_RUpdateG;
			}
		}

		/// <summary>
		/// Void UpdateAllG()
		/// </summary>
		protected RMethod r_RUpdateAllG;
		public virtual RMethod RUpdateAllG
		{
			get
			{
				if(r_RUpdateAllG == null)
				{
					r_RUpdateAllG = new(this, "UpdateAllG", 0);
					r_RUpdateAllG.SetBelong(this.instance);
				}
				return r_RUpdateAllG;
			}
		}

		/// <summary>
		/// Void UpdateH(AstarClasses.Node)
		/// </summary>
		protected RMethod r_RUpdateH_Node;
		public virtual RMethod RUpdateH_Node
		{
			get
			{
				if(r_RUpdateH_Node == null)
				{
					r_RUpdateH_Node = new(this, "UpdateH", 0, typeof(AstarClasses.Node));
					r_RUpdateH_Node.SetBelong(this.instance);
				}
				return r_RUpdateH_Node;
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


        public RMeshEdgeNode() : base("AstarClasses.MeshEdgeNode")
        {
        }

        public RMeshEdgeNode(System.Object instance) : base("AstarClasses.MeshEdgeNode")
		{
            SetInstance(instance);
		}

        public RMeshEdgeNode(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshEdgeNode(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.Vector2[] GetArea()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetArea.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2[])___result;
        }


        public virtual void GenerateEnabledConnections()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGenerateEnabledConnections.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddConnection(AstarClasses.Connection  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RAddConnection_Connection.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateG()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateG.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateAllG()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdateAllG.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UpdateH(AstarClasses.Node  @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@end};
            var ___result = RUpdateH_Node.Invoke(___genericsType, ___parameters);

            
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
