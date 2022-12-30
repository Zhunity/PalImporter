using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RAstarMath
{
	/// <summary>
	/// AstarMath.Matrix
	/// </summary>
    public partial class RMatrix : RMember //
    {

		/// <summary>
		/// System.Single[] #a
		/// </summary>
		protected RFieldArray<RField> r___0__a;
		public virtual RFieldArray<RField> R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// Void #GT()
		/// </summary>
		protected RMethod r_R__0__GT;
		public virtual RMethod R__0__GT
		{
			get
			{
				if(r_R__0__GT == null)
				{
					r_R__0__GT = new(this, "#GT", 0);
					r_R__0__GT.SetBelong(this.instance);
				}
				return r_R__0__GT;
			}
		}

		/// <summary>
		/// AstarMath.Matrix #HT(Single, Single, Single)
		/// </summary>
		protected static RMethod r_R__0__HT_Single_Single_Single;
		public static RMethod R__0__HT_Single_Single_Single
		{
			get
			{
				if(r_R__0__HT_Single_Single_Single == null)
				{
					r_R__0__HT_Single_Single_Single = new( ReleactionUtils.GetType("AstarMath.Matrix"), "#HT", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_R__0__HT_Single_Single_Single.SetBelong(null);
				}
				return r_R__0__HT_Single_Single_Single;
			}
		}

		/// <summary>
		/// AstarMath.Matrix #IT(Single)
		/// </summary>
		protected static RMethod r_R__0__IT_Single;
		public static RMethod R__0__IT_Single
		{
			get
			{
				if(r_R__0__IT_Single == null)
				{
					r_R__0__IT_Single = new( ReleactionUtils.GetType("AstarMath.Matrix"), "#IT", 0, typeof(System.Single));
					r_R__0__IT_Single.SetBelong(null);
				}
				return r_R__0__IT_Single;
			}
		}

		/// <summary>
		/// AstarMath.Matrix #JT(Single)
		/// </summary>
		protected static RMethod r_R__0__JT_Single;
		public static RMethod R__0__JT_Single
		{
			get
			{
				if(r_R__0__JT_Single == null)
				{
					r_R__0__JT_Single = new( ReleactionUtils.GetType("AstarMath.Matrix"), "#JT", 0, typeof(System.Single));
					r_R__0__JT_Single.SetBelong(null);
				}
				return r_R__0__JT_Single;
			}
		}

		/// <summary>
		/// AstarMath.Matrix #KT(Single)
		/// </summary>
		protected static RMethod r_R__0__KT_Single;
		public static RMethod R__0__KT_Single
		{
			get
			{
				if(r_R__0__KT_Single == null)
				{
					r_R__0__KT_Single = new( ReleactionUtils.GetType("AstarMath.Matrix"), "#KT", 0, typeof(System.Single));
					r_R__0__KT_Single.SetBelong(null);
				}
				return r_R__0__KT_Single;
			}
		}

		/// <summary>
		/// AstarMath.Matrix #LT(Single)
		/// </summary>
		protected static RMethod r_R__0__LT_Single;
		public static RMethod R__0__LT_Single
		{
			get
			{
				if(r_R__0__LT_Single == null)
				{
					r_R__0__LT_Single = new( ReleactionUtils.GetType("AstarMath.Matrix"), "#LT", 0, typeof(System.Single));
					r_R__0__LT_Single.SetBelong(null);
				}
				return r_R__0__LT_Single;
			}
		}

		/// <summary>
		/// AstarMath.Matrix #LT(Single, Single, Single)
		/// </summary>
		protected static RMethod r_R__0__LT_Single_Single_Single;
		public static RMethod R__0__LT_Single_Single_Single
		{
			get
			{
				if(r_R__0__LT_Single_Single_Single == null)
				{
					r_R__0__LT_Single_Single_Single = new( ReleactionUtils.GetType("AstarMath.Matrix"), "#LT", 0, typeof(System.Single), typeof(System.Single), typeof(System.Single));
					r_R__0__LT_Single_Single_Single.SetBelong(null);
				}
				return r_R__0__LT_Single_Single_Single;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 #MT(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_R__0__MT_Vector3;
		public virtual RMethod R__0__MT_Vector3
		{
			get
			{
				if(r_R__0__MT_Vector3 == null)
				{
					r_R__0__MT_Vector3 = new(this, "#MT", 0, typeof(UnityEngine.Vector3));
					r_R__0__MT_Vector3.SetBelong(this.instance);
				}
				return r_R__0__MT_Vector3;
			}
		}

		/// <summary>
		/// AstarMath.Matrix #NT(AstarMath.Matrix, AstarMath.Matrix)
		/// </summary>
		protected static RMethod r_R__0__NT_Matrix_Matrix;
		public static RMethod R__0__NT_Matrix_Matrix
		{
			get
			{
				if(r_R__0__NT_Matrix_Matrix == null)
				{
					r_R__0__NT_Matrix_Matrix = new( ReleactionUtils.GetType("AstarMath.Matrix"), "#NT", 0,  ReleactionUtils.GetType("AstarMath.Matrix"),  ReleactionUtils.GetType("AstarMath.Matrix"));
					r_R__0__NT_Matrix_Matrix.SetBelong(null);
				}
				return r_R__0__NT_Matrix_Matrix;
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


        public RMatrix() : base("AstarMath.Matrix")
        {
        }

        public RMatrix(System.Object instance) : base("AstarMath.Matrix")
		{
            SetInstance(instance);
		}

        public RMatrix(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMatrix(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__GT()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__GT.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Object __0__HT(System.Single  @_X, System.Single  @_Y, System.Single  @_Z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_X, @_Y, @_Z};
            var ___result = R__0__HT_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object __0__IT(System.Single  @_Degree)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_Degree};
            var ___result = R__0__IT_Single.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object __0__JT(System.Single  @_Degree)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_Degree};
            var ___result = R__0__JT_Single.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object __0__KT(System.Single  @_Degree)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_Degree};
            var ___result = R__0__KT_Single.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object __0__LT(System.Single  @_In)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_In};
            var ___result = R__0__LT_Single.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public static System.Object __0__LT(System.Single  @_X, System.Single  @_Y, System.Single  @_Z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_X, @_Y, @_Z};
            var ___result = R__0__LT_Single_Single_Single.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual UnityEngine.Vector3 __0__MT(UnityEngine.Vector3  @_V)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_V};
            var ___result = R__0__MT_Vector3.Invoke(___genericsType, ___parameters);

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
