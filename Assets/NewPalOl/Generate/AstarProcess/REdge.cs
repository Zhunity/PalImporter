using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarProcess
{
	/// <summary>
	/// AstarProcess.Edge
	/// </summary>
    public partial class REdge : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 endPointA
		/// </summary>
		protected RUnityEngine.RVector3 r_endPointA;
		public virtual RUnityEngine.RVector3 RendPointA
		{
			get
			{
				if(r_endPointA == null)
				{
					r_endPointA = new(this, "endPointA");
					r_endPointA.SetBelong(this.instance);
				}
				return r_endPointA;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 endPointB
		/// </summary>
		protected RUnityEngine.RVector3 r_endPointB;
		public virtual RUnityEngine.RVector3 RendPointB
		{
			get
			{
				if(r_endPointB == null)
				{
					r_endPointB = new(this, "endPointB");
					r_endPointB.SetBelong(this.instance);
				}
				return r_endPointB;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 edgeVector3D
		/// </summary>
		protected RUnityEngine.RVector3 r_edgeVector3D;
		public virtual RUnityEngine.RVector3 RedgeVector3D
		{
			get
			{
				if(r_edgeVector3D == null)
				{
					r_edgeVector3D = new(this, "edgeVector3D");
					r_edgeVector3D.SetBelong(this.instance);
				}
				return r_edgeVector3D;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 edgeVector
		/// </summary>
		protected RUnityEngine.RVector2 r_edgeVector;
		public virtual RUnityEngine.RVector2 RedgeVector
		{
			get
			{
				if(r_edgeVector == null)
				{
					r_edgeVector = new(this, "edgeVector");
					r_edgeVector.SetBelong(this.instance);
				}
				return r_edgeVector;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 _node
		/// </summary>
		protected RAstarClasses.RInt3 r__node;
		public virtual RAstarClasses.RInt3 R_node
		{
			get
			{
				if(r__node == null)
				{
					r__node = new(this, "_node");
					r__node.SetBelong(this.instance);
				}
				return r__node;
			}
		}

		/// <summary>
		/// System.Int32 triIndex1
		/// </summary>
		protected RField r_triIndex1;
		public virtual RField RtriIndex1
		{
			get
			{
				if(r_triIndex1 == null)
				{
					r_triIndex1 = new(this, "triIndex1");
					r_triIndex1.SetBelong(this.instance);
				}
				return r_triIndex1;
			}
		}

		/// <summary>
		/// System.Int32 triIndex2
		/// </summary>
		protected RField r_triIndex2;
		public virtual RField RtriIndex2
		{
			get
			{
				if(r_triIndex2 == null)
				{
					r_triIndex2 = new(this, "triIndex2");
					r_triIndex2.SetBelong(this.instance);
				}
				return r_triIndex2;
			}
		}

		/// <summary>
		/// System.Int32 offset
		/// </summary>
		protected RField r_offset;
		public virtual RField Roffset
		{
			get
			{
				if(r_offset == null)
				{
					r_offset = new(this, "offset");
					r_offset.SetBelong(this.instance);
				}
				return r_offset;
			}
		}

		/// <summary>
		/// System.Boolean borderA1
		/// </summary>
		protected RField r_borderA1;
		public virtual RField RborderA1
		{
			get
			{
				if(r_borderA1 == null)
				{
					r_borderA1 = new(this, "borderA1");
					r_borderA1.SetBelong(this.instance);
				}
				return r_borderA1;
			}
		}

		/// <summary>
		/// System.Boolean borderA2
		/// </summary>
		protected RField r_borderA2;
		public virtual RField RborderA2
		{
			get
			{
				if(r_borderA2 == null)
				{
					r_borderA2 = new(this, "borderA2");
					r_borderA2.SetBelong(this.instance);
				}
				return r_borderA2;
			}
		}

		/// <summary>
		/// System.Boolean borderB1
		/// </summary>
		protected RField r_borderB1;
		public virtual RField RborderB1
		{
			get
			{
				if(r_borderB1 == null)
				{
					r_borderB1 = new(this, "borderB1");
					r_borderB1.SetBelong(this.instance);
				}
				return r_borderB1;
			}
		}

		/// <summary>
		/// System.Boolean borderB2
		/// </summary>
		protected RField r_borderB2;
		public virtual RField RborderB2
		{
			get
			{
				if(r_borderB2 == null)
				{
					r_borderB2 = new(this, "borderB2");
					r_borderB2.SetBelong(this.instance);
				}
				return r_borderB2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 borderA1E
		/// </summary>
		protected RUnityEngine.RVector3 r_borderA1E;
		public virtual RUnityEngine.RVector3 RborderA1E
		{
			get
			{
				if(r_borderA1E == null)
				{
					r_borderA1E = new(this, "borderA1E");
					r_borderA1E.SetBelong(this.instance);
				}
				return r_borderA1E;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 borderA2E
		/// </summary>
		protected RUnityEngine.RVector3 r_borderA2E;
		public virtual RUnityEngine.RVector3 RborderA2E
		{
			get
			{
				if(r_borderA2E == null)
				{
					r_borderA2E = new(this, "borderA2E");
					r_borderA2E.SetBelong(this.instance);
				}
				return r_borderA2E;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 borderB1E
		/// </summary>
		protected RUnityEngine.RVector3 r_borderB1E;
		public virtual RUnityEngine.RVector3 RborderB1E
		{
			get
			{
				if(r_borderB1E == null)
				{
					r_borderB1E = new(this, "borderB1E");
					r_borderB1E.SetBelong(this.instance);
				}
				return r_borderB1E;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 borderB2E
		/// </summary>
		protected RUnityEngine.RVector3 r_borderB2E;
		public virtual RUnityEngine.RVector3 RborderB2E
		{
			get
			{
				if(r_borderB2E == null)
				{
					r_borderB2E = new(this, "borderB2E");
					r_borderB2E.SetBelong(this.instance);
				}
				return r_borderB2E;
			}
		}

		/// <summary>
		/// System.Int32 triA
		/// </summary>
		protected RField r_triA;
		public virtual RField RtriA
		{
			get
			{
				if(r_triA == null)
				{
					r_triA = new(this, "triA");
					r_triA.SetBelong(this.instance);
				}
				return r_triA;
			}
		}

		/// <summary>
		/// System.Int32 triB
		/// </summary>
		protected RField r_triB;
		public virtual RField RtriB
		{
			get
			{
				if(r_triB == null)
				{
					r_triB = new(this, "triB");
					r_triB.SetBelong(this.instance);
				}
				return r_triB;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 _center
		/// </summary>
		protected RUnityEngine.RVector3 r__center;
		public virtual RUnityEngine.RVector3 R_center
		{
			get
			{
				if(r__center == null)
				{
					r__center = new(this, "_center");
					r__center.SetBelong(this.instance);
				}
				return r__center;
			}
		}

		/// <summary>
		/// AstarClasses.Node node
		/// </summary>
		protected RAstarClasses.RNode r_node;
		public virtual RAstarClasses.RNode Rnode
		{
			get
			{
				if(r_node == null)
				{
					r_node = new(this, "node", -1);
					r_node.SetBelong(this.instance);
				}
				return r_node;
			}
		}

		/// <summary>
		/// Boolean borderA
		/// </summary>
		protected RProperty r_borderA;
		public virtual RProperty RborderA
		{
			get
			{
				if(r_borderA == null)
				{
					r_borderA = new(this, "borderA", -1);
					r_borderA.SetBelong(this.instance);
				}
				return r_borderA;
			}
		}

		/// <summary>
		/// Boolean borderB
		/// </summary>
		protected RProperty r_borderB;
		public virtual RProperty RborderB
		{
			get
			{
				if(r_borderB == null)
				{
					r_borderB = new(this, "borderB", -1);
					r_borderB.SetBelong(this.instance);
				}
				return r_borderB;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 center
		/// </summary>
		protected RUnityEngine.RVector3 r_center;
		public virtual RUnityEngine.RVector3 Rcenter
		{
			get
			{
				if(r_center == null)
				{
					r_center = new(this, "center", -1);
					r_center.SetBelong(this.instance);
				}
				return r_center;
			}
		}

		/// <summary>
		/// Void SetBorderA(Boolean, Int32, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSetBorderA_Boolean_Int32_Vector3;
		public virtual RMethod RSetBorderA_Boolean_Int32_Vector3
		{
			get
			{
				if(r_RSetBorderA_Boolean_Int32_Vector3 == null)
				{
					r_RSetBorderA_Boolean_Int32_Vector3 = new(this, "SetBorderA", 0, typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Vector3));
					r_RSetBorderA_Boolean_Int32_Vector3.SetBelong(this.instance);
				}
				return r_RSetBorderA_Boolean_Int32_Vector3;
			}
		}

		/// <summary>
		/// Void SetBorderB(Boolean, Int32, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSetBorderB_Boolean_Int32_Vector3;
		public virtual RMethod RSetBorderB_Boolean_Int32_Vector3
		{
			get
			{
				if(r_RSetBorderB_Boolean_Int32_Vector3 == null)
				{
					r_RSetBorderB_Boolean_Int32_Vector3 = new(this, "SetBorderB", 0, typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Vector3));
					r_RSetBorderB_Boolean_Int32_Vector3.SetBelong(this.instance);
				}
				return r_RSetBorderB_Boolean_Int32_Vector3;
			}
		}

		/// <summary>
		/// AstarProcess.Edge Merge(AstarProcess.Edge)
		/// </summary>
		protected RMethod r_RMerge_Edge;
		public virtual RMethod RMerge_Edge
		{
			get
			{
				if(r_RMerge_Edge == null)
				{
					r_RMerge_Edge = new(this, "Merge", 0, typeof(AstarProcess.Edge));
					r_RMerge_Edge.SetBelong(this.instance);
				}
				return r_RMerge_Edge;
			}
		}

		/// <summary>
		/// Void Debug(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RDebug_Color;
		public virtual RMethod RDebug_Color
		{
			get
			{
				if(r_RDebug_Color == null)
				{
					r_RDebug_Color = new(this, "Debug", 0, typeof(UnityEngine.Color));
					r_RDebug_Color.SetBelong(this.instance);
				}
				return r_RDebug_Color;
			}
		}

		/// <summary>
		/// Void DebugWarning()
		/// </summary>
		protected RMethod r_RDebugWarning;
		public virtual RMethod RDebugWarning
		{
			get
			{
				if(r_RDebugWarning == null)
				{
					r_RDebugWarning = new(this, "DebugWarning", 0);
					r_RDebugWarning.SetBelong(this.instance);
				}
				return r_RDebugWarning;
			}
		}

		/// <summary>
		/// Void DebugError()
		/// </summary>
		protected RMethod r_RDebugError;
		public virtual RMethod RDebugError
		{
			get
			{
				if(r_RDebugError == null)
				{
					r_RDebugError = new(this, "DebugError", 0);
					r_RDebugError.SetBelong(this.instance);
				}
				return r_RDebugError;
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
		/// AstarProcess.Edge TurningRadius(Single)
		/// </summary>
		protected RMethod r_RTurningRadius_Single;
		public virtual RMethod RTurningRadius_Single
		{
			get
			{
				if(r_RTurningRadius_Single == null)
				{
					r_RTurningRadius_Single = new(this, "TurningRadius", 0, typeof(System.Single));
					r_RTurningRadius_Single.SetBelong(this.instance);
				}
				return r_RTurningRadius_Single;
			}
		}

		/// <summary>
		/// EdgeIntersection IntersectionTest(AstarProcess.Edge, AstarProcess.Edge)
		/// </summary>
		protected static RMethod r_RIntersectionTest_Edge_Edge;
		public static RMethod RIntersectionTest_Edge_Edge
		{
			get
			{
				if(r_RIntersectionTest_Edge_Edge == null)
				{
					r_RIntersectionTest_Edge_Edge = new(typeof(AstarProcess.Edge), "IntersectionTest", 0, typeof(AstarProcess.Edge), typeof(AstarProcess.Edge));
					r_RIntersectionTest_Edge_Edge.SetBelong(null);
				}
				return r_RIntersectionTest_Edge_Edge;
			}
		}

		/// <summary>
		/// OnLinePosition DoesLinesIntersectFast(AstarProcess.Edge, AstarProcess.Edge)
		/// </summary>
		protected static RMethod r_RDoesLinesIntersectFast_Edge_Edge;
		public static RMethod RDoesLinesIntersectFast_Edge_Edge
		{
			get
			{
				if(r_RDoesLinesIntersectFast_Edge_Edge == null)
				{
					r_RDoesLinesIntersectFast_Edge_Edge = new(typeof(AstarProcess.Edge), "DoesLinesIntersectFast", 0, typeof(AstarProcess.Edge), typeof(AstarProcess.Edge));
					r_RDoesLinesIntersectFast_Edge_Edge.SetBelong(null);
				}
				return r_RDoesLinesIntersectFast_Edge_Edge;
			}
		}

		/// <summary>
		/// EdgeIntersection DoesLinesIntersect(AstarProcess.Edge, AstarProcess.Edge)
		/// </summary>
		protected static RMethod r_RDoesLinesIntersect_Edge_Edge;
		public static RMethod RDoesLinesIntersect_Edge_Edge
		{
			get
			{
				if(r_RDoesLinesIntersect_Edge_Edge == null)
				{
					r_RDoesLinesIntersect_Edge_Edge = new(typeof(AstarProcess.Edge), "DoesLinesIntersect", 0, typeof(AstarProcess.Edge), typeof(AstarProcess.Edge));
					r_RDoesLinesIntersect_Edge_Edge.SetBelong(null);
				}
				return r_RDoesLinesIntersect_Edge_Edge;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 IntersectionFactorFast(AstarProcess.Edge, AstarProcess.Edge)
		/// </summary>
		protected static RMethod r_RIntersectionFactorFast_Edge_Edge;
		public static RMethod RIntersectionFactorFast_Edge_Edge
		{
			get
			{
				if(r_RIntersectionFactorFast_Edge_Edge == null)
				{
					r_RIntersectionFactorFast_Edge_Edge = new(typeof(AstarProcess.Edge), "IntersectionFactorFast", 0, typeof(AstarProcess.Edge), typeof(AstarProcess.Edge));
					r_RIntersectionFactorFast_Edge_Edge.SetBelong(null);
				}
				return r_RIntersectionFactorFast_Edge_Edge;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetNormal(UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_RGetNormal_Vector2;
		public static RMethod RGetNormal_Vector2
		{
			get
			{
				if(r_RGetNormal_Vector2 == null)
				{
					r_RGetNormal_Vector2 = new(typeof(AstarProcess.Edge), "GetNormal", 0, typeof(UnityEngine.Vector2));
					r_RGetNormal_Vector2.SetBelong(null);
				}
				return r_RGetNormal_Vector2;
			}
		}

		/// <summary>
		/// Single NearestPointOnEdges(AstarProcess.Edge)
		/// </summary>
		protected RMethod r_RNearestPointOnEdges_Edge;
		public virtual RMethod RNearestPointOnEdges_Edge
		{
			get
			{
				if(r_RNearestPointOnEdges_Edge == null)
				{
					r_RNearestPointOnEdges_Edge = new(this, "NearestPointOnEdges", 0, typeof(AstarProcess.Edge));
					r_RNearestPointOnEdges_Edge.SetBelong(this.instance);
				}
				return r_RNearestPointOnEdges_Edge;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 NearestPointsOnEdges(AstarProcess.Edge, AstarProcess.Edge)
		/// </summary>
		protected static RMethod r_RNearestPointsOnEdges_Edge_Edge;
		public static RMethod RNearestPointsOnEdges_Edge_Edge
		{
			get
			{
				if(r_RNearestPointsOnEdges_Edge_Edge == null)
				{
					r_RNearestPointsOnEdges_Edge_Edge = new(typeof(AstarProcess.Edge), "NearestPointsOnEdges", 0, typeof(AstarProcess.Edge), typeof(AstarProcess.Edge));
					r_RNearestPointsOnEdges_Edge_Edge.SetBelong(null);
				}
				return r_RNearestPointsOnEdges_Edge_Edge;
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


        public REdge() : base("AstarProcess.Edge")
        {
        }

        public REdge(System.Object instance) : base("AstarProcess.Edge")
		{
            SetInstance(instance);
		}

        public REdge(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REdge(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetBorderA(System.Boolean  @border, System.Int32  @tris, UnityEngine.Vector3  @edge)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@border, @tris, @edge};
            var ___result = RSetBorderA_Boolean_Int32_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetBorderB(System.Boolean  @border, System.Int32  @tris, UnityEngine.Vector3  @edge)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@border, @tris, @edge};
            var ___result = RSetBorderB_Boolean_Int32_Vector3.Invoke(___genericsType, ___parameters);

            
        }


        public virtual AstarProcess.Edge Merge(AstarProcess.Edge  @rhs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rhs};
            var ___result = RMerge_Edge.Invoke(___genericsType, ___parameters);

            return (AstarProcess.Edge)___result;
        }


        public virtual void Debug(UnityEngine.Color  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@c};
            var ___result = RDebug_Color.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DebugWarning()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDebugWarning.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DebugError()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDebugError.Invoke(___genericsType, ___parameters);

            
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


        public virtual AstarProcess.Edge TurningRadius(System.Single  @rad)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rad};
            var ___result = RTurningRadius_Single.Invoke(___genericsType, ___parameters);

            return (AstarProcess.Edge)___result;
        }


        public static System.Object IntersectionTest(AstarProcess.Edge  @memberEdge, AstarProcess.Edge  @testEdge)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberEdge, @testEdge};
            var ___result = RIntersectionTest_Edge_Edge.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object DoesLinesIntersectFast(AstarProcess.Edge  @memberEdge, AstarProcess.Edge  @testEdge)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberEdge, @testEdge};
            var ___result = RDoesLinesIntersectFast_Edge_Edge.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object DoesLinesIntersect(AstarProcess.Edge  @memberEdge, AstarProcess.Edge  @testEdge)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberEdge, @testEdge};
            var ___result = RDoesLinesIntersect_Edge_Edge.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static UnityEngine.Vector2 IntersectionFactorFast(AstarProcess.Edge  @memberEdge, AstarProcess.Edge  @testEdge)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@memberEdge, @testEdge};
            var ___result = RIntersectionFactorFast_Edge_Edge.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static UnityEngine.Vector2 GetNormal(UnityEngine.Vector2  @dir2D)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dir2D};
            var ___result = RGetNormal_Vector2.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual System.Single NearestPointOnEdges(AstarProcess.Edge  @e2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e2};
            var ___result = RNearestPointOnEdges_Edge.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static UnityEngine.Vector2 NearestPointsOnEdges(AstarProcess.Edge  @e1, AstarProcess.Edge  @e2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e1, @e2};
            var ___result = RNearestPointsOnEdges_Edge_Edge.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
