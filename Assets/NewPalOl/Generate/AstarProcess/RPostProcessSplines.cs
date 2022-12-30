using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarProcess
{
	/// <summary>
	/// AstarProcess.PostProcessSplines
	/// </summary>
    public partial class RPostProcessSplines : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3[] CatmullRom(UnityEngine.Vector3[], Int32)
		/// </summary>
		protected static RMethod r_RCatmullRom_Vector3Array_Int32;
		public static RMethod RCatmullRom_Vector3Array_Int32
		{
			get
			{
				if(r_RCatmullRom_Vector3Array_Int32 == null)
				{
					r_RCatmullRom_Vector3Array_Int32 = new(typeof(AstarProcess.PostProcessSplines), "CatmullRom", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32));
					r_RCatmullRom_Vector3Array_Int32.SetBelong(null);
				}
				return r_RCatmullRom_Vector3Array_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetPoint(Int32, UnityEngine.Vector3[])
		/// </summary>
		protected static RMethod r_RGetPoint_Int32_Vector3Array;
		public static RMethod RGetPoint_Int32_Vector3Array
		{
			get
			{
				if(r_RGetPoint_Int32_Vector3Array == null)
				{
					r_RGetPoint_Int32_Vector3Array = new(typeof(AstarProcess.PostProcessSplines), "GetPoint", 0, typeof(System.Int32), typeof(UnityEngine.Vector3).MakeArrayType());
					r_RGetPoint_Int32_Vector3Array.SetBelong(null);
				}
				return r_RGetPoint_Int32_Vector3Array;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] CubicSmooth(UnityEngine.Vector3[], Int32, Boolean, Single)
		/// </summary>
		protected static RMethod r_RCubicSmooth_Vector3Array_Int32_Boolean_Single;
		public static RMethod RCubicSmooth_Vector3Array_Int32_Boolean_Single
		{
			get
			{
				if(r_RCubicSmooth_Vector3Array_Int32_Boolean_Single == null)
				{
					r_RCubicSmooth_Vector3Array_Int32_Boolean_Single = new(typeof(AstarProcess.PostProcessSplines), "CubicSmooth", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Boolean), typeof(System.Single));
					r_RCubicSmooth_Vector3Array_Int32_Boolean_Single.SetBelong(null);
				}
				return r_RCubicSmooth_Vector3Array_Int32_Boolean_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] SimpleSmooth(UnityEngine.Vector3[], Int32, Single, Int32)
		/// </summary>
		protected static RMethod r_RSimpleSmooth_Vector3Array_Int32_Single_Int32;
		public static RMethod RSimpleSmooth_Vector3Array_Int32_Single_Int32
		{
			get
			{
				if(r_RSimpleSmooth_Vector3Array_Int32_Single_Int32 == null)
				{
					r_RSimpleSmooth_Vector3Array_Int32_Single_Int32 = new(typeof(AstarProcess.PostProcessSplines), "SimpleSmooth", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32), typeof(System.Single), typeof(System.Int32));
					r_RSimpleSmooth_Vector3Array_Int32_Single_Int32.SetBelong(null);
				}
				return r_RSimpleSmooth_Vector3Array_Int32_Single_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] Subdivide(UnityEngine.Vector3[], Int32)
		/// </summary>
		protected static RMethod r_RSubdivide_Vector3Array_Int32;
		public static RMethod RSubdivide_Vector3Array_Int32
		{
			get
			{
				if(r_RSubdivide_Vector3Array_Int32 == null)
				{
					r_RSubdivide_Vector3Array_Int32 = new(typeof(AstarProcess.PostProcessSplines), "Subdivide", 0, typeof(UnityEngine.Vector3).MakeArrayType(), typeof(System.Int32));
					r_RSubdivide_Vector3Array_Int32.SetBelong(null);
				}
				return r_RSubdivide_Vector3Array_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 CubicBezier(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RCubicBezier_Vector3_Vector3_Vector3_Vector3_Single;
		public static RMethod RCubicBezier_Vector3_Vector3_Vector3_Vector3_Single
		{
			get
			{
				if(r_RCubicBezier_Vector3_Vector3_Vector3_Vector3_Single == null)
				{
					r_RCubicBezier_Vector3_Vector3_Vector3_Vector3_Single = new(typeof(AstarProcess.PostProcessSplines), "CubicBezier", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RCubicBezier_Vector3_Vector3_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_RCubicBezier_Vector3_Vector3_Vector3_Vector3_Single;
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


        public RPostProcessSplines() : base("AstarProcess.PostProcessSplines")
        {
        }

        public RPostProcessSplines(System.Object instance) : base("AstarProcess.PostProcessSplines")
		{
            SetInstance(instance);
		}

        public RPostProcessSplines(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPostProcessSplines(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Vector3[] CatmullRom(UnityEngine.Vector3[]  @path, System.Int32  @subdivisions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @subdivisions};
            var ___result = RCatmullRom_Vector3Array_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3[])___result;
        }


        public static UnityEngine.Vector3 GetPoint(System.Int32  @i, UnityEngine.Vector3[]  @path)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @path};
            var ___result = RGetPoint_Int32_Vector3Array.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public static UnityEngine.Vector3[] CubicSmooth(UnityEngine.Vector3[]  @path, System.Int32  @subdivisions, System.Boolean  @normalizeTangents, System.Single  @tangentLength)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @subdivisions, @normalizeTangents, @tangentLength};
            var ___result = RCubicSmooth_Vector3Array_Int32_Boolean_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3[])___result;
        }


        public static UnityEngine.Vector3[] SimpleSmooth(UnityEngine.Vector3[]  @path, System.Int32  @iterations, System.Single  @strength, System.Int32  @subdivisions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @iterations, @strength, @subdivisions};
            var ___result = RSimpleSmooth_Vector3Array_Int32_Single_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3[])___result;
        }


        public static UnityEngine.Vector3[] Subdivide(UnityEngine.Vector3[]  @path, System.Int32  @subdivisions)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@path, @subdivisions};
            var ___result = RSubdivide_Vector3Array_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3[])___result;
        }


        public static UnityEngine.Vector3 CubicBezier(UnityEngine.Vector3  @p0, UnityEngine.Vector3  @p1, UnityEngine.Vector3  @p2, UnityEngine.Vector3  @p3, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@p0, @p1, @p2, @p3, @t};
            var ___result = RCubicBezier_Vector3_Vector3_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
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
