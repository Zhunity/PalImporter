using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TerrainLayer
	/// </summary>
    public partial class RTerrainLayer : RMember //
    {

		/// <summary>
		/// UnityEngine.Texture2D diffuseTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_diffuseTexture;
		public virtual RUnityEngine.RTexture2D RdiffuseTexture
		{
			get
			{
				if(r_diffuseTexture == null)
				{
					r_diffuseTexture = new(this, "diffuseTexture", -1);
					r_diffuseTexture.SetBelong(this.instance);
				}
				return r_diffuseTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D normalMapTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_normalMapTexture;
		public virtual RUnityEngine.RTexture2D RnormalMapTexture
		{
			get
			{
				if(r_normalMapTexture == null)
				{
					r_normalMapTexture = new(this, "normalMapTexture", -1);
					r_normalMapTexture.SetBelong(this.instance);
				}
				return r_normalMapTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D maskMapTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_maskMapTexture;
		public virtual RUnityEngine.RTexture2D RmaskMapTexture
		{
			get
			{
				if(r_maskMapTexture == null)
				{
					r_maskMapTexture = new(this, "maskMapTexture", -1);
					r_maskMapTexture.SetBelong(this.instance);
				}
				return r_maskMapTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tileSize
		/// </summary>
		protected RUnityEngine.RVector2 r_tileSize;
		public virtual RUnityEngine.RVector2 RtileSize
		{
			get
			{
				if(r_tileSize == null)
				{
					r_tileSize = new(this, "tileSize", -1);
					r_tileSize.SetBelong(this.instance);
				}
				return r_tileSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 tileOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_tileOffset;
		public virtual RUnityEngine.RVector2 RtileOffset
		{
			get
			{
				if(r_tileOffset == null)
				{
					r_tileOffset = new(this, "tileOffset", -1);
					r_tileOffset.SetBelong(this.instance);
				}
				return r_tileOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Color specular
		/// </summary>
		protected RUnityEngine.RColor r_specular;
		public virtual RUnityEngine.RColor Rspecular
		{
			get
			{
				if(r_specular == null)
				{
					r_specular = new(this, "specular", -1);
					r_specular.SetBelong(this.instance);
				}
				return r_specular;
			}
		}

		/// <summary>
		/// Single metallic
		/// </summary>
		protected RProperty r_metallic;
		public virtual RProperty Rmetallic
		{
			get
			{
				if(r_metallic == null)
				{
					r_metallic = new(this, "metallic", -1);
					r_metallic.SetBelong(this.instance);
				}
				return r_metallic;
			}
		}

		/// <summary>
		/// Single smoothness
		/// </summary>
		protected RProperty r_smoothness;
		public virtual RProperty Rsmoothness
		{
			get
			{
				if(r_smoothness == null)
				{
					r_smoothness = new(this, "smoothness", -1);
					r_smoothness.SetBelong(this.instance);
				}
				return r_smoothness;
			}
		}

		/// <summary>
		/// Single normalScale
		/// </summary>
		protected RProperty r_normalScale;
		public virtual RProperty RnormalScale
		{
			get
			{
				if(r_normalScale == null)
				{
					r_normalScale = new(this, "normalScale", -1);
					r_normalScale.SetBelong(this.instance);
				}
				return r_normalScale;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 diffuseRemapMin
		/// </summary>
		protected RUnityEngine.RVector4 r_diffuseRemapMin;
		public virtual RUnityEngine.RVector4 RdiffuseRemapMin
		{
			get
			{
				if(r_diffuseRemapMin == null)
				{
					r_diffuseRemapMin = new(this, "diffuseRemapMin", -1);
					r_diffuseRemapMin.SetBelong(this.instance);
				}
				return r_diffuseRemapMin;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 diffuseRemapMax
		/// </summary>
		protected RUnityEngine.RVector4 r_diffuseRemapMax;
		public virtual RUnityEngine.RVector4 RdiffuseRemapMax
		{
			get
			{
				if(r_diffuseRemapMax == null)
				{
					r_diffuseRemapMax = new(this, "diffuseRemapMax", -1);
					r_diffuseRemapMax.SetBelong(this.instance);
				}
				return r_diffuseRemapMax;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 maskMapRemapMin
		/// </summary>
		protected RUnityEngine.RVector4 r_maskMapRemapMin;
		public virtual RUnityEngine.RVector4 RmaskMapRemapMin
		{
			get
			{
				if(r_maskMapRemapMin == null)
				{
					r_maskMapRemapMin = new(this, "maskMapRemapMin", -1);
					r_maskMapRemapMin.SetBelong(this.instance);
				}
				return r_maskMapRemapMin;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 maskMapRemapMax
		/// </summary>
		protected RUnityEngine.RVector4 r_maskMapRemapMax;
		public virtual RUnityEngine.RVector4 RmaskMapRemapMax
		{
			get
			{
				if(r_maskMapRemapMax == null)
				{
					r_maskMapRemapMax = new(this, "maskMapRemapMax", -1);
					r_maskMapRemapMax.SetBelong(this.instance);
				}
				return r_maskMapRemapMax;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void Internal_Create(UnityEngine.TerrainLayer)
		/// </summary>
		protected static RMethod r_RInternal_Create_TerrainLayer;
		public static RMethod RInternal_Create_TerrainLayer
		{
			get
			{
				if(r_RInternal_Create_TerrainLayer == null)
				{
					r_RInternal_Create_TerrainLayer = new(typeof(UnityEngine.TerrainLayer), "Internal_Create", 0, typeof(UnityEngine.TerrainLayer));
					r_RInternal_Create_TerrainLayer.SetBelong(null);
				}
				return r_RInternal_Create_TerrainLayer;
			}
		}

		/// <summary>
		/// Void get_tileSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_tileSize_Injected_Out_Vector2;
		public virtual RMethod Rget_tileSize_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_tileSize_Injected_Out_Vector2 == null)
				{
					r_Rget_tileSize_Injected_Out_Vector2 = new(this, "get_tileSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_tileSize_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_tileSize_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_tileSize_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_tileSize_Injected_Ref_Vector2;
		public virtual RMethod Rset_tileSize_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_tileSize_Injected_Ref_Vector2 == null)
				{
					r_Rset_tileSize_Injected_Ref_Vector2 = new(this, "set_tileSize_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_tileSize_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_tileSize_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_tileOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rget_tileOffset_Injected_Out_Vector2;
		public virtual RMethod Rget_tileOffset_Injected_Out_Vector2
		{
			get
			{
				if(r_Rget_tileOffset_Injected_Out_Vector2 == null)
				{
					r_Rget_tileOffset_Injected_Out_Vector2 = new(this, "get_tileOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rget_tileOffset_Injected_Out_Vector2.SetBelong(this.instance);
				}
				return r_Rget_tileOffset_Injected_Out_Vector2;
			}
		}

		/// <summary>
		/// Void set_tileOffset_Injected(UnityEngine.Vector2 ByRef)
		/// </summary>
		protected RMethod r_Rset_tileOffset_Injected_Ref_Vector2;
		public virtual RMethod Rset_tileOffset_Injected_Ref_Vector2
		{
			get
			{
				if(r_Rset_tileOffset_Injected_Ref_Vector2 == null)
				{
					r_Rset_tileOffset_Injected_Ref_Vector2 = new(this, "set_tileOffset_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType());
					r_Rset_tileOffset_Injected_Ref_Vector2.SetBelong(this.instance);
				}
				return r_Rset_tileOffset_Injected_Ref_Vector2;
			}
		}

		/// <summary>
		/// Void get_specular_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Rget_specular_Injected_Out_Color;
		public virtual RMethod Rget_specular_Injected_Out_Color
		{
			get
			{
				if(r_Rget_specular_Injected_Out_Color == null)
				{
					r_Rget_specular_Injected_Out_Color = new(this, "get_specular_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Rget_specular_Injected_Out_Color.SetBelong(this.instance);
				}
				return r_Rget_specular_Injected_Out_Color;
			}
		}

		/// <summary>
		/// Void set_specular_Injected(UnityEngine.Color ByRef)
		/// </summary>
		protected RMethod r_Rset_specular_Injected_Ref_Color;
		public virtual RMethod Rset_specular_Injected_Ref_Color
		{
			get
			{
				if(r_Rset_specular_Injected_Ref_Color == null)
				{
					r_Rset_specular_Injected_Ref_Color = new(this, "set_specular_Injected", 0, typeof(UnityEngine.Color).MakeByRefType());
					r_Rset_specular_Injected_Ref_Color.SetBelong(this.instance);
				}
				return r_Rset_specular_Injected_Ref_Color;
			}
		}

		/// <summary>
		/// Void get_diffuseRemapMin_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_diffuseRemapMin_Injected_Out_Vector4;
		public virtual RMethod Rget_diffuseRemapMin_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_diffuseRemapMin_Injected_Out_Vector4 == null)
				{
					r_Rget_diffuseRemapMin_Injected_Out_Vector4 = new(this, "get_diffuseRemapMin_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_diffuseRemapMin_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_diffuseRemapMin_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void set_diffuseRemapMin_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rset_diffuseRemapMin_Injected_Ref_Vector4;
		public virtual RMethod Rset_diffuseRemapMin_Injected_Ref_Vector4
		{
			get
			{
				if(r_Rset_diffuseRemapMin_Injected_Ref_Vector4 == null)
				{
					r_Rset_diffuseRemapMin_Injected_Ref_Vector4 = new(this, "set_diffuseRemapMin_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rset_diffuseRemapMin_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_Rset_diffuseRemapMin_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void get_diffuseRemapMax_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_diffuseRemapMax_Injected_Out_Vector4;
		public virtual RMethod Rget_diffuseRemapMax_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_diffuseRemapMax_Injected_Out_Vector4 == null)
				{
					r_Rget_diffuseRemapMax_Injected_Out_Vector4 = new(this, "get_diffuseRemapMax_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_diffuseRemapMax_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_diffuseRemapMax_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void set_diffuseRemapMax_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rset_diffuseRemapMax_Injected_Ref_Vector4;
		public virtual RMethod Rset_diffuseRemapMax_Injected_Ref_Vector4
		{
			get
			{
				if(r_Rset_diffuseRemapMax_Injected_Ref_Vector4 == null)
				{
					r_Rset_diffuseRemapMax_Injected_Ref_Vector4 = new(this, "set_diffuseRemapMax_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rset_diffuseRemapMax_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_Rset_diffuseRemapMax_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void get_maskMapRemapMin_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_maskMapRemapMin_Injected_Out_Vector4;
		public virtual RMethod Rget_maskMapRemapMin_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_maskMapRemapMin_Injected_Out_Vector4 == null)
				{
					r_Rget_maskMapRemapMin_Injected_Out_Vector4 = new(this, "get_maskMapRemapMin_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_maskMapRemapMin_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_maskMapRemapMin_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void set_maskMapRemapMin_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rset_maskMapRemapMin_Injected_Ref_Vector4;
		public virtual RMethod Rset_maskMapRemapMin_Injected_Ref_Vector4
		{
			get
			{
				if(r_Rset_maskMapRemapMin_Injected_Ref_Vector4 == null)
				{
					r_Rset_maskMapRemapMin_Injected_Ref_Vector4 = new(this, "set_maskMapRemapMin_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rset_maskMapRemapMin_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_Rset_maskMapRemapMin_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void get_maskMapRemapMax_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_maskMapRemapMax_Injected_Out_Vector4;
		public virtual RMethod Rget_maskMapRemapMax_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_maskMapRemapMax_Injected_Out_Vector4 == null)
				{
					r_Rget_maskMapRemapMax_Injected_Out_Vector4 = new(this, "get_maskMapRemapMax_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_maskMapRemapMax_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_maskMapRemapMax_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void set_maskMapRemapMax_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rset_maskMapRemapMax_Injected_Ref_Vector4;
		public virtual RMethod Rset_maskMapRemapMax_Injected_Ref_Vector4
		{
			get
			{
				if(r_Rset_maskMapRemapMax_Injected_Ref_Vector4 == null)
				{
					r_Rset_maskMapRemapMax_Injected_Ref_Vector4 = new(this, "set_maskMapRemapMax_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rset_maskMapRemapMax_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_Rset_maskMapRemapMax_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RTerrainLayer() : base("UnityEngine.TerrainLayer")
        {
        }

        public RTerrainLayer(System.Object instance) : base("UnityEngine.TerrainLayer")
		{
            SetInstance(instance);
		}

        public RTerrainLayer(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTerrainLayer(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void Internal_Create(UnityEngine.TerrainLayer  @layer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@layer};
            var ___result = RInternal_Create_TerrainLayer.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_tileSize_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_tileSize_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_tileSize_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_tileSize_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_tileOffset_Injected(out UnityEngine.Vector2  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_tileOffset_Injected_Out_Vector2.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void set_tileOffset_Injected(ref UnityEngine.Vector2  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_tileOffset_Injected_Ref_Vector2.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual void get_specular_Injected(out UnityEngine.Color  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_specular_Injected_Out_Color.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void set_specular_Injected(ref UnityEngine.Color  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_specular_Injected_Ref_Color.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Color)___parameters[0];

            
        }


        public virtual void get_diffuseRemapMin_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_diffuseRemapMin_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void set_diffuseRemapMin_Injected(ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_diffuseRemapMin_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_diffuseRemapMax_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_diffuseRemapMax_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void set_diffuseRemapMax_Injected(ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_diffuseRemapMax_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_maskMapRemapMin_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_maskMapRemapMin_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void set_maskMapRemapMin_Injected(ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_maskMapRemapMin_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_maskMapRemapMax_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_maskMapRemapMax_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void set_maskMapRemapMax_Injected(ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_maskMapRemapMax_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
