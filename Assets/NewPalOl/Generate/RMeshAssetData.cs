using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MeshAssetData
	/// </summary>
    public partial class RMeshAssetData : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] vertices
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector3> r_vertices;
		public virtual RFieldArray<RUnityEngine.RVector3> Rvertices
		{
			get
			{
				if(r_vertices == null)
				{
					r_vertices = new(this, "vertices");
					r_vertices.SetBelong(this.instance);
				}
				return r_vertices;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] normals
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector3> r_normals;
		public virtual RFieldArray<RUnityEngine.RVector3> Rnormals
		{
			get
			{
				if(r_normals == null)
				{
					r_normals = new(this, "normals");
					r_normals.SetBelong(this.instance);
				}
				return r_normals;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4[] tangents
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector4> r_tangents;
		public virtual RFieldArray<RUnityEngine.RVector4> Rtangents
		{
			get
			{
				if(r_tangents == null)
				{
					r_tangents = new(this, "tangents");
					r_tangents.SetBelong(this.instance);
				}
				return r_tangents;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector2> r_uv;
		public virtual RFieldArray<RUnityEngine.RVector2> Ruv
		{
			get
			{
				if(r_uv == null)
				{
					r_uv = new(this, "uv");
					r_uv.SetBelong(this.instance);
				}
				return r_uv;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2[] uv2
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector2> r_uv2;
		public virtual RFieldArray<RUnityEngine.RVector2> Ruv2
		{
			get
			{
				if(r_uv2 == null)
				{
					r_uv2 = new(this, "uv2");
					r_uv2.SetBelong(this.instance);
				}
				return r_uv2;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] colors
		/// </summary>
		protected RFieldArray<RUnityEngine.RColor> r_colors;
		public virtual RFieldArray<RUnityEngine.RColor> Rcolors
		{
			get
			{
				if(r_colors == null)
				{
					r_colors = new(this, "colors");
					r_colors.SetBelong(this.instance);
				}
				return r_colors;
			}
		}

		/// <summary>
		/// System.Int32[] triangles
		/// </summary>
		protected RFieldArray<RField> r_triangles;
		public virtual RFieldArray<RField> Rtriangles
		{
			get
			{
				if(r_triangles == null)
				{
					r_triangles = new(this, "triangles");
					r_triangles.SetBelong(this.instance);
				}
				return r_triangles;
			}
		}

		/// <summary>
		/// System.Int32 vertexCount
		/// </summary>
		protected RField r_vertexCount;
		public virtual RField RvertexCount
		{
			get
			{
				if(r_vertexCount == null)
				{
					r_vertexCount = new(this, "vertexCount");
					r_vertexCount.SetBelong(this.instance);
				}
				return r_vertexCount;
			}
		}

		/// <summary>
		/// System.Int32 subMeshCount
		/// </summary>
		protected RField r_subMeshCount;
		public virtual RField RsubMeshCount
		{
			get
			{
				if(r_subMeshCount == null)
				{
					r_subMeshCount = new(this, "subMeshCount");
					r_subMeshCount.SetBelong(this.instance);
				}
				return r_subMeshCount;
			}
		}

		/// <summary>
		/// UnityEngine.BoneWeight[] boneWeights
		/// </summary>
		protected RFieldArray<RUnityEngine.RBoneWeight> r_boneWeights;
		public virtual RFieldArray<RUnityEngine.RBoneWeight> RboneWeights
		{
			get
			{
				if(r_boneWeights == null)
				{
					r_boneWeights = new(this, "boneWeights");
					r_boneWeights.SetBelong(this.instance);
				}
				return r_boneWeights;
			}
		}

		/// <summary>
		/// UnityEngine.Matrix4x4[] bindposes
		/// </summary>
		protected RFieldArray<RUnityEngine.RMatrix4x4> r_bindposes;
		public virtual RFieldArray<RUnityEngine.RMatrix4x4> Rbindposes
		{
			get
			{
				if(r_bindposes == null)
				{
					r_bindposes = new(this, "bindposes");
					r_bindposes.SetBelong(this.instance);
				}
				return r_bindposes;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[SubMeshTriangles] mSubMesh
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSubMeshTriangles> r_mSubMesh;
		public virtual RSystem.RCollections.RGeneric.RList<RSubMeshTriangles> RmSubMesh
		{
			get
			{
				if(r_mSubMesh == null)
				{
					r_mSubMesh = new(this, "mSubMesh");
					r_mSubMesh.SetBelong(this.instance);
				}
				return r_mSubMesh;
			}
		}

		/// <summary>
		/// Void SetMesh(UnityEngine.Mesh)
		/// </summary>
		protected RMethod r_RSetMesh_Mesh;
		public virtual RMethod RSetMesh_Mesh
		{
			get
			{
				if(r_RSetMesh_Mesh == null)
				{
					r_RSetMesh_Mesh = new(this, "SetMesh", 0, typeof(UnityEngine.Mesh));
					r_RSetMesh_Mesh.SetBelong(this.instance);
				}
				return r_RSetMesh_Mesh;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh GetMesh()
		/// </summary>
		protected RMethod r_RGetMesh;
		public virtual RMethod RGetMesh
		{
			get
			{
				if(r_RGetMesh == null)
				{
					r_RGetMesh = new(this, "GetMesh", 0);
					r_RGetMesh.SetBelong(this.instance);
				}
				return r_RGetMesh;
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


        public RMeshAssetData() : base("MeshAssetData")
        {
        }

        public RMeshAssetData(System.Object instance) : base("MeshAssetData")
		{
            SetInstance(instance);
		}

        public RMeshAssetData(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshAssetData(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetMesh(UnityEngine.Mesh  @m)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m};
            var ___result = RSetMesh_Mesh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Mesh GetMesh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMesh.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Mesh)___result;
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
