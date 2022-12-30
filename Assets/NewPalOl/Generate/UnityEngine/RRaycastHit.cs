using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.RaycastHit
	/// </summary>
    public partial class RRaycastHit : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 m_Point
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Point;
		public virtual RUnityEngine.RVector3 Rm_Point
		{
			get
			{
				if(r_m_Point == null)
				{
					r_m_Point = new(this, "m_Point");
					r_m_Point.SetBelong(this.instance);
				}
				return r_m_Point;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_Normal
		/// </summary>
		protected RUnityEngine.RVector3 r_m_Normal;
		public virtual RUnityEngine.RVector3 Rm_Normal
		{
			get
			{
				if(r_m_Normal == null)
				{
					r_m_Normal = new(this, "m_Normal");
					r_m_Normal.SetBelong(this.instance);
				}
				return r_m_Normal;
			}
		}

		/// <summary>
		/// System.UInt32 m_FaceID
		/// </summary>
		protected RField r_m_FaceID;
		public virtual RField Rm_FaceID
		{
			get
			{
				if(r_m_FaceID == null)
				{
					r_m_FaceID = new(this, "m_FaceID");
					r_m_FaceID.SetBelong(this.instance);
				}
				return r_m_FaceID;
			}
		}

		/// <summary>
		/// System.Single m_Distance
		/// </summary>
		protected RField r_m_Distance;
		public virtual RField Rm_Distance
		{
			get
			{
				if(r_m_Distance == null)
				{
					r_m_Distance = new(this, "m_Distance");
					r_m_Distance.SetBelong(this.instance);
				}
				return r_m_Distance;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_UV
		/// </summary>
		protected RUnityEngine.RVector2 r_m_UV;
		public virtual RUnityEngine.RVector2 Rm_UV
		{
			get
			{
				if(r_m_UV == null)
				{
					r_m_UV = new(this, "m_UV");
					r_m_UV.SetBelong(this.instance);
				}
				return r_m_UV;
			}
		}

		/// <summary>
		/// System.Int32 m_Collider
		/// </summary>
		protected RField r_m_Collider;
		public virtual RField Rm_Collider
		{
			get
			{
				if(r_m_Collider == null)
				{
					r_m_Collider = new(this, "m_Collider");
					r_m_Collider.SetBelong(this.instance);
				}
				return r_m_Collider;
			}
		}

		/// <summary>
		/// UnityEngine.Collider collider
		/// </summary>
		protected RUnityEngine.RCollider r_collider;
		public virtual RUnityEngine.RCollider Rcollider
		{
			get
			{
				if(r_collider == null)
				{
					r_collider = new(this, "collider", -1);
					r_collider.SetBelong(this.instance);
				}
				return r_collider;
			}
		}

		/// <summary>
		/// Int32 colliderInstanceID
		/// </summary>
		protected RProperty r_colliderInstanceID;
		public virtual RProperty RcolliderInstanceID
		{
			get
			{
				if(r_colliderInstanceID == null)
				{
					r_colliderInstanceID = new(this, "colliderInstanceID", -1);
					r_colliderInstanceID.SetBelong(this.instance);
				}
				return r_colliderInstanceID;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 point
		/// </summary>
		protected RUnityEngine.RVector3 r_point;
		public virtual RUnityEngine.RVector3 Rpoint
		{
			get
			{
				if(r_point == null)
				{
					r_point = new(this, "point", -1);
					r_point.SetBelong(this.instance);
				}
				return r_point;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 normal
		/// </summary>
		protected RUnityEngine.RVector3 r_normal;
		public virtual RUnityEngine.RVector3 Rnormal
		{
			get
			{
				if(r_normal == null)
				{
					r_normal = new(this, "normal", -1);
					r_normal.SetBelong(this.instance);
				}
				return r_normal;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 barycentricCoordinate
		/// </summary>
		protected RUnityEngine.RVector3 r_barycentricCoordinate;
		public virtual RUnityEngine.RVector3 RbarycentricCoordinate
		{
			get
			{
				if(r_barycentricCoordinate == null)
				{
					r_barycentricCoordinate = new(this, "barycentricCoordinate", -1);
					r_barycentricCoordinate.SetBelong(this.instance);
				}
				return r_barycentricCoordinate;
			}
		}

		/// <summary>
		/// Single distance
		/// </summary>
		protected RProperty r_distance;
		public virtual RProperty Rdistance
		{
			get
			{
				if(r_distance == null)
				{
					r_distance = new(this, "distance", -1);
					r_distance.SetBelong(this.instance);
				}
				return r_distance;
			}
		}

		/// <summary>
		/// Int32 triangleIndex
		/// </summary>
		protected RProperty r_triangleIndex;
		public virtual RProperty RtriangleIndex
		{
			get
			{
				if(r_triangleIndex == null)
				{
					r_triangleIndex = new(this, "triangleIndex", -1);
					r_triangleIndex.SetBelong(this.instance);
				}
				return r_triangleIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 textureCoord
		/// </summary>
		protected RUnityEngine.RVector2 r_textureCoord;
		public virtual RUnityEngine.RVector2 RtextureCoord
		{
			get
			{
				if(r_textureCoord == null)
				{
					r_textureCoord = new(this, "textureCoord", -1);
					r_textureCoord.SetBelong(this.instance);
				}
				return r_textureCoord;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 textureCoord2
		/// </summary>
		protected RUnityEngine.RVector2 r_textureCoord2;
		public virtual RUnityEngine.RVector2 RtextureCoord2
		{
			get
			{
				if(r_textureCoord2 == null)
				{
					r_textureCoord2 = new(this, "textureCoord2", -1);
					r_textureCoord2.SetBelong(this.instance);
				}
				return r_textureCoord2;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected RUnityEngine.RTransform r_transform;
		public virtual RUnityEngine.RTransform Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform", -1);
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// UnityEngine.Rigidbody rigidbody
		/// </summary>
		protected RUnityEngine.RRigidbody r_rigidbody;
		public virtual RUnityEngine.RRigidbody Rrigidbody
		{
			get
			{
				if(r_rigidbody == null)
				{
					r_rigidbody = new(this, "rigidbody", -1);
					r_rigidbody.SetBelong(this.instance);
				}
				return r_rigidbody;
			}
		}

		/// <summary>
		/// UnityEngine.ArticulationBody articulationBody
		/// </summary>
		protected RUnityEngine.RArticulationBody r_articulationBody;
		public virtual RUnityEngine.RArticulationBody RarticulationBody
		{
			get
			{
				if(r_articulationBody == null)
				{
					r_articulationBody = new(this, "articulationBody", -1);
					r_articulationBody.SetBelong(this.instance);
				}
				return r_articulationBody;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 lightmapCoord
		/// </summary>
		protected RUnityEngine.RVector2 r_lightmapCoord;
		public virtual RUnityEngine.RVector2 RlightmapCoord
		{
			get
			{
				if(r_lightmapCoord == null)
				{
					r_lightmapCoord = new(this, "lightmapCoord", -1);
					r_lightmapCoord.SetBelong(this.instance);
				}
				return r_lightmapCoord;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 textureCoord1
		/// </summary>
		protected RUnityEngine.RVector2 r_textureCoord1;
		public virtual RUnityEngine.RVector2 RtextureCoord1
		{
			get
			{
				if(r_textureCoord1 == null)
				{
					r_textureCoord1 = new(this, "textureCoord1", -1);
					r_textureCoord1.SetBelong(this.instance);
				}
				return r_textureCoord1;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 CalculateRaycastTexCoord(Int32, UnityEngine.Vector2, UnityEngine.Vector3, UInt32, Int32)
		/// </summary>
		protected static RMethod r_RCalculateRaycastTexCoord_Int32_Vector2_Vector3_UInt32_Int32;
		public static RMethod RCalculateRaycastTexCoord_Int32_Vector2_Vector3_UInt32_Int32
		{
			get
			{
				if(r_RCalculateRaycastTexCoord_Int32_Vector2_Vector3_UInt32_Int32 == null)
				{
					r_RCalculateRaycastTexCoord_Int32_Vector2_Vector3_UInt32_Int32 = new(typeof(UnityEngine.RaycastHit), "CalculateRaycastTexCoord", 0, typeof(System.Int32), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector3), typeof(System.UInt32), typeof(System.Int32));
					r_RCalculateRaycastTexCoord_Int32_Vector2_Vector3_UInt32_Int32.SetBelong(null);
				}
				return r_RCalculateRaycastTexCoord_Int32_Vector2_Vector3_UInt32_Int32;
			}
		}

		/// <summary>
		/// Void CalculateRaycastTexCoord_Injected(Int32, UnityEngine.Vector2 ByRef, UnityEngine.Vector3 ByRef, UInt32, Int32, UnityEngine.Vector2 ByRef)
		/// </summary>
		protected static RMethod r_RCalculateRaycastTexCoord_Injected_Int32_Ref_Vector2_Ref_Vector3_UInt32_Int32_Out_Vector2;
		public static RMethod RCalculateRaycastTexCoord_Injected_Int32_Ref_Vector2_Ref_Vector3_UInt32_Int32_Out_Vector2
		{
			get
			{
				if(r_RCalculateRaycastTexCoord_Injected_Int32_Ref_Vector2_Ref_Vector3_UInt32_Int32_Out_Vector2 == null)
				{
					r_RCalculateRaycastTexCoord_Injected_Int32_Ref_Vector2_Ref_Vector3_UInt32_Int32_Out_Vector2 = new(typeof(UnityEngine.RaycastHit), "CalculateRaycastTexCoord_Injected", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType(), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(System.UInt32), typeof(System.Int32), typeof(UnityEngine.Vector2).MakeByRefType());
					r_RCalculateRaycastTexCoord_Injected_Int32_Ref_Vector2_Ref_Vector3_UInt32_Int32_Out_Vector2.SetBelong(null);
				}
				return r_RCalculateRaycastTexCoord_Injected_Int32_Ref_Vector2_Ref_Vector3_UInt32_Int32_Out_Vector2;
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


        public RRaycastHit() : base("UnityEngine.RaycastHit")
        {
        }

        public RRaycastHit(System.Object instance) : base("UnityEngine.RaycastHit")
		{
            SetInstance(instance);
		}

        public RRaycastHit(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRaycastHit(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Vector2 CalculateRaycastTexCoord(System.Int32  @colliderInstanceID, UnityEngine.Vector2  @uv, UnityEngine.Vector3  @pos, System.UInt32  @face, System.Int32  @textcoord)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colliderInstanceID, @uv, @pos, @face, @textcoord};
            var ___result = RCalculateRaycastTexCoord_Int32_Vector2_Vector3_UInt32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public static void CalculateRaycastTexCoord_Injected(System.Int32  @colliderInstanceID, ref UnityEngine.Vector2  @uv, ref UnityEngine.Vector3  @pos, System.UInt32  @face, System.Int32  @textcoord, out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colliderInstanceID, @uv, @pos, @face, @textcoord, @ret};
            var ___result = RCalculateRaycastTexCoord_Injected_Int32_Ref_Vector2_Ref_Vector3_UInt32_Int32_Out_Vector2.Invoke(___genericsType, ___parameters);
			uv = (UnityEngine.Vector2)___parameters[1];
			pos = (UnityEngine.Vector3)___parameters[2];
			ret = (UnityEngine.Vector2)___parameters[5];

            
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
