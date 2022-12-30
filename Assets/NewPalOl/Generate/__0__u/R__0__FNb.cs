using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#FNb
	/// </summary>
    public partial class R__0__FNb : RMember //
    {

		/// <summary>
		/// Void #DNb(UnityEngine.Material, UnityEngine.RenderTexture, UnityEngine.RenderTexture, Single, UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected static RMethod r_R__0__DNb_Material_RenderTexture_RenderTexture_Single_Vector2_Vector2;
		public static RMethod R__0__DNb_Material_RenderTexture_RenderTexture_Single_Vector2_Vector2
		{
			get
			{
				if(r_R__0__DNb_Material_RenderTexture_RenderTexture_Single_Vector2_Vector2 == null)
				{
					r_R__0__DNb_Material_RenderTexture_RenderTexture_Single_Vector2_Vector2 = new( ReleactionUtils.GetType("#u.#FNb"), "#DNb", 0, typeof(UnityEngine.Material), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.RenderTexture), typeof(System.Single), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_R__0__DNb_Material_RenderTexture_RenderTexture_Single_Vector2_Vector2.SetBelong(null);
				}
				return r_R__0__DNb_Material_RenderTexture_RenderTexture_Single_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.RenderTexture, UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_RBlit_RenderTexture_RenderTexture;
		public static RMethod RBlit_RenderTexture_RenderTexture
		{
			get
			{
				if(r_RBlit_RenderTexture_RenderTexture == null)
				{
					r_RBlit_RenderTexture_RenderTexture = new( ReleactionUtils.GetType("#u.#FNb"), "Blit", 0, typeof(UnityEngine.RenderTexture), typeof(UnityEngine.RenderTexture));
					r_RBlit_RenderTexture_RenderTexture.SetBelong(null);
				}
				return r_RBlit_RenderTexture_RenderTexture;
			}
		}

		/// <summary>
		/// Void #ENb(UnityEngine.Material, UnityEngine.RenderTexture, UnityEngine.RenderTexture)
		/// </summary>
		protected static RMethod r_R__0__ENb_Material_RenderTexture_RenderTexture;
		public static RMethod R__0__ENb_Material_RenderTexture_RenderTexture
		{
			get
			{
				if(r_R__0__ENb_Material_RenderTexture_RenderTexture == null)
				{
					r_R__0__ENb_Material_RenderTexture_RenderTexture = new( ReleactionUtils.GetType("#u.#FNb"), "#ENb", 0, typeof(UnityEngine.Material), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.RenderTexture));
					r_R__0__ENb_Material_RenderTexture_RenderTexture.SetBelong(null);
				}
				return r_R__0__ENb_Material_RenderTexture_RenderTexture;
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


        public R__0__FNb() : base("#u.#FNb")
        {
        }

        public R__0__FNb(System.Object instance) : base("#u.#FNb")
		{
            SetInstance(instance);
		}

        public R__0__FNb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__FNb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void __0__DNb(UnityEngine.Material  @material, UnityEngine.RenderTexture  @source, UnityEngine.RenderTexture  @destination, System.Single  @angle, UnityEngine.Vector2  @center, UnityEngine.Vector2  @radius)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @source, @destination, @angle, @center, @radius};
            var ___result = R__0__DNb_Material_RenderTexture_RenderTexture_Single_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public static void Blit(UnityEngine.RenderTexture  @source, UnityEngine.RenderTexture  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@source, @dest};
            var ___result = RBlit_RenderTexture_RenderTexture.Invoke(___genericsType, ___parameters);

            
        }


        public static void __0__ENb(UnityEngine.Material  @material, UnityEngine.RenderTexture  @source, UnityEngine.RenderTexture  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @source, @dest};
            var ___result = R__0__ENb_Material_RenderTexture_RenderTexture.Invoke(___genericsType, ___parameters);

            
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
