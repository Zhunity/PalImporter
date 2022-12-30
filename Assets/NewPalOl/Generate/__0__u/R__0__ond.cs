using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#ond
	/// </summary>
    public partial class R__0__ond : RMember //
    {

		/// <summary>
		/// Void RenderTrail(UnityEngine.Material, UnityEngine.Mesh)
		/// </summary>
		protected static RMethod r_RRenderTrail_Material_Mesh;
		public static RMethod RRenderTrail_Material_Mesh
		{
			get
			{
				if(r_RRenderTrail_Material_Mesh == null)
				{
					r_RRenderTrail_Material_Mesh = new( ReleactionUtils.GetType("#u.#ond"), "RenderTrail", 0, typeof(UnityEngine.Material), typeof(UnityEngine.Mesh));
					r_RRenderTrail_Material_Mesh.SetBelong(null);
				}
				return r_RRenderTrail_Material_Mesh;
			}
		}

		/// <summary>
		/// Boolean SlerpVector(UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Vector3, System.Collections.Generic.List`1[Vertex], Single, Int32, Int32)
		/// </summary>
		protected static RMethod r_RSlerpVector_Vector3_Vector3_Vector3_Vector3_List_d_Vertex_p__Single_Int32_Int32;
		public static RMethod RSlerpVector_Vector3_Vector3_Vector3_Vector3_List_d_Vertex_p__Single_Int32_Int32
		{
			get
			{
				if(r_RSlerpVector_Vector3_Vector3_Vector3_Vector3_List_d_Vertex_p__Single_Int32_Int32 == null)
				{
					r_RSlerpVector_Vector3_Vector3_Vector3_Vector3_List_d_Vertex_p__Single_Int32_Int32 = new( ReleactionUtils.GetType("#u.#ond"), "SlerpVector", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("Vertex")), typeof(System.Single), typeof(System.Int32), typeof(System.Int32));
					r_RSlerpVector_Vector3_Vector3_Vector3_Vector3_List_d_Vertex_p__Single_Int32_Int32.SetBelong(null);
				}
				return r_RSlerpVector_Vector3_Vector3_Vector3_Vector3_List_d_Vertex_p__Single_Int32_Int32;
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


        public R__0__ond() : base("#u.#ond")
        {
        }

        public R__0__ond(System.Object instance) : base("#u.#ond")
		{
            SetInstance(instance);
		}

        public R__0__ond(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__ond(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void RenderTrail(UnityEngine.Material  @_material, UnityEngine.Mesh  @mesh)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_material, @mesh};
            var ___result = RRenderTrail_Material_Mesh.Invoke(___genericsType, ___parameters);

            
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
