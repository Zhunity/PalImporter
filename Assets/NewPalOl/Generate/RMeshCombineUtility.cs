using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MeshCombineUtility
	/// </summary>
    public partial class RMeshCombineUtility : RMember //
    {

		/// <summary>
		/// UnityEngine.Mesh Combine(MeshInstance[], Boolean)
		/// </summary>
		protected static RMethod r_RCombine_MeshInstanceArray_Boolean;
		public static RMethod RCombine_MeshInstanceArray_Boolean
		{
			get
			{
				if(r_RCombine_MeshInstanceArray_Boolean == null)
				{
					r_RCombine_MeshInstanceArray_Boolean = new( ReleactionUtils.GetType("MeshCombineUtility"), "Combine", 0,  ReleactionUtils.GetType("MeshCombineUtility+MeshInstance").MakeArrayType(), typeof(System.Boolean));
					r_RCombine_MeshInstanceArray_Boolean.SetBelong(null);
				}
				return r_RCombine_MeshInstanceArray_Boolean;
			}
		}

		/// <summary>
		/// Void Copy(Int32, UnityEngine.Vector3[], UnityEngine.Vector3[], Int32 ByRef, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_RCopy_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4;
		public static RMethod RCopy_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4
		{
			get
			{
				if(r_RCopy_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4 == null)
				{
					r_RCopy_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4 = new( ReleactionUtils.GetType("MeshCombineUtility"), "Copy", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32).MakeByRefType(), typeof(UnityEngine.Matrix4x4));
					r_RCopy_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4.SetBelong(null);
				}
				return r_RCopy_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void #q8(Int32, UnityEngine.Vector3[], UnityEngine.Vector3[], Int32 ByRef, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_R__0__q8_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4;
		public static RMethod R__0__q8_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4
		{
			get
			{
				if(r_R__0__q8_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4 == null)
				{
					r_R__0__q8_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4 = new( ReleactionUtils.GetType("MeshCombineUtility"), "#q8", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32).MakeByRefType(), typeof(UnityEngine.Matrix4x4));
					r_R__0__q8_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4.SetBelong(null);
				}
				return r_R__0__q8_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4;
			}
		}

		/// <summary>
		/// Void Copy(Int32, UnityEngine.Vector2[], UnityEngine.Vector2[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_RCopy_Int32_Vector2Array_Vector2Array_Ref_Int32;
		public static RMethod RCopy_Int32_Vector2Array_Vector2Array_Ref_Int32
		{
			get
			{
				if(r_RCopy_Int32_Vector2Array_Vector2Array_Ref_Int32 == null)
				{
					r_RCopy_Int32_Vector2Array_Vector2Array_Ref_Int32 = new( ReleactionUtils.GetType("MeshCombineUtility"), "Copy", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_RCopy_Int32_Vector2Array_Vector2Array_Ref_Int32.SetBelong(null);
				}
				return r_RCopy_Int32_Vector2Array_Vector2Array_Ref_Int32;
			}
		}

		/// <summary>
		/// Void #HNb(Int32, UnityEngine.Vector2[], UnityEngine.Vector2[], Int32 ByRef, Single, Single)
		/// </summary>
		protected static RMethod r_R__0__HNb_Int32_Vector2Array_Vector2Array_Ref_Int32_Single_Single;
		public static RMethod R__0__HNb_Int32_Vector2Array_Vector2Array_Ref_Int32_Single_Single
		{
			get
			{
				if(r_R__0__HNb_Int32_Vector2Array_Vector2Array_Ref_Int32_Single_Single == null)
				{
					r_R__0__HNb_Int32_Vector2Array_Vector2Array_Ref_Int32_Single_Single = new( ReleactionUtils.GetType("MeshCombineUtility"), "#HNb", 0, typeof(System.Int32), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(UnityEngine.Vector2).MakeArrayType(), typeof(System.Int32).MakeByRefType(), typeof(System.Single), typeof(System.Single));
					r_R__0__HNb_Int32_Vector2Array_Vector2Array_Ref_Int32_Single_Single.SetBelong(null);
				}
				return r_R__0__HNb_Int32_Vector2Array_Vector2Array_Ref_Int32_Single_Single;
			}
		}

		/// <summary>
		/// Void #INb(Int32, UnityEngine.Color[], UnityEngine.Color[], Int32 ByRef)
		/// </summary>
		protected static RMethod r_R__0__INb_Int32_ColorArray_ColorArray_Ref_Int32;
		public static RMethod R__0__INb_Int32_ColorArray_ColorArray_Ref_Int32
		{
			get
			{
				if(r_R__0__INb_Int32_ColorArray_ColorArray_Ref_Int32 == null)
				{
					r_R__0__INb_Int32_ColorArray_ColorArray_Ref_Int32 = new( ReleactionUtils.GetType("MeshCombineUtility"), "#INb", 0, typeof(System.Int32), typeof(UnityEngine.Color).MakeArrayType(), typeof(UnityEngine.Color).MakeArrayType(), typeof(System.Int32).MakeByRefType());
					r_R__0__INb_Int32_ColorArray_ColorArray_Ref_Int32.SetBelong(null);
				}
				return r_R__0__INb_Int32_ColorArray_ColorArray_Ref_Int32;
			}
		}

		/// <summary>
		/// Void #r8(Int32, UnityEngine.Vector4[], UnityEngine.Vector4[], Int32 ByRef, UnityEngine.Matrix4x4)
		/// </summary>
		protected static RMethod r_R__0__r8_Int32_Vector4Array_Vector4Array_Ref_Int32_Matrix4x4;
		public static RMethod R__0__r8_Int32_Vector4Array_Vector4Array_Ref_Int32_Matrix4x4
		{
			get
			{
				if(r_R__0__r8_Int32_Vector4Array_Vector4Array_Ref_Int32_Matrix4x4 == null)
				{
					r_R__0__r8_Int32_Vector4Array_Vector4Array_Ref_Int32_Matrix4x4 = new( ReleactionUtils.GetType("MeshCombineUtility"), "#r8", 0, typeof(System.Int32), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(UnityEngine.Vector4).MakeArrayType(), typeof(System.Int32).MakeByRefType(), typeof(UnityEngine.Matrix4x4));
					r_R__0__r8_Int32_Vector4Array_Vector4Array_Ref_Int32_Matrix4x4.SetBelong(null);
				}
				return r_R__0__r8_Int32_Vector4Array_Vector4Array_Ref_Int32_Matrix4x4;
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


        public RMeshCombineUtility() : base("MeshCombineUtility")
        {
        }

        public RMeshCombineUtility(System.Object instance) : base("MeshCombineUtility")
		{
            SetInstance(instance);
		}

        public RMeshCombineUtility(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMeshCombineUtility(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public static void Copy(System.Int32  @vertexcount, UnityEngine.Vector3[]  @src, UnityEngine.Vector3[]  @dst, ref System.Int32  @offset, UnityEngine.Matrix4x4  @transform)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexcount, @src, @dst, @offset, @transform};
            var ___result = RCopy_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);
			offset = (System.Int32)___parameters[3];

            
        }


        public static void __0__q8(System.Int32  @vertexcount, UnityEngine.Vector3[]  @src, UnityEngine.Vector3[]  @dst, ref System.Int32  @offset, UnityEngine.Matrix4x4  @transform)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexcount, @src, @dst, @offset, @transform};
            var ___result = R__0__q8_Int32_Vector3Array_Vector3Array_Ref_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);
			offset = (System.Int32)___parameters[3];

            
        }


        public static void Copy(System.Int32  @vertexcount, UnityEngine.Vector2[]  @src, UnityEngine.Vector2[]  @dst, ref System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexcount, @src, @dst, @offset};
            var ___result = RCopy_Int32_Vector2Array_Vector2Array_Ref_Int32.Invoke(___genericsType, ___parameters);
			offset = (System.Int32)___parameters[3];

            
        }


        public static void __0__HNb(System.Int32  @vertexcount, UnityEngine.Vector2[]  @src, UnityEngine.Vector2[]  @dst, ref System.Int32  @offset, System.Single  @influence, System.Single  @x)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexcount, @src, @dst, @offset, @influence, @x};
            var ___result = R__0__HNb_Int32_Vector2Array_Vector2Array_Ref_Int32_Single_Single.Invoke(___genericsType, ___parameters);
			offset = (System.Int32)___parameters[3];

            
        }


        public static void __0__INb(System.Int32  @vertexcount, UnityEngine.Color[]  @src, UnityEngine.Color[]  @dst, ref System.Int32  @offset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexcount, @src, @dst, @offset};
            var ___result = R__0__INb_Int32_ColorArray_ColorArray_Ref_Int32.Invoke(___genericsType, ___parameters);
			offset = (System.Int32)___parameters[3];

            
        }


        public static void __0__r8(System.Int32  @vertexcount, UnityEngine.Vector4[]  @src, UnityEngine.Vector4[]  @dst, ref System.Int32  @offset, UnityEngine.Matrix4x4  @transform)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vertexcount, @src, @dst, @offset, @transform};
            var ___result = R__0__r8_Int32_Vector4Array_Vector4Array_Ref_Int32_Matrix4x4.Invoke(___genericsType, ___parameters);
			offset = (System.Int32)___parameters[3];

            
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
