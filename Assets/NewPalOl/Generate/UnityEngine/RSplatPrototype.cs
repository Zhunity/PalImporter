using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.SplatPrototype
	/// </summary>
    public partial class RSplatPrototype : RMember //
    {

		/// <summary>
		/// UnityEngine.Texture2D m_Texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_Texture;
		public virtual RUnityEngine.RTexture2D Rm_Texture
		{
			get
			{
				if(r_m_Texture == null)
				{
					r_m_Texture = new(this, "m_Texture");
					r_m_Texture.SetBelong(this.instance);
				}
				return r_m_Texture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_NormalMap
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_NormalMap;
		public virtual RUnityEngine.RTexture2D Rm_NormalMap
		{
			get
			{
				if(r_m_NormalMap == null)
				{
					r_m_NormalMap = new(this, "m_NormalMap");
					r_m_NormalMap.SetBelong(this.instance);
				}
				return r_m_NormalMap;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_TileSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_TileSize;
		public virtual RUnityEngine.RVector2 Rm_TileSize
		{
			get
			{
				if(r_m_TileSize == null)
				{
					r_m_TileSize = new(this, "m_TileSize");
					r_m_TileSize.SetBelong(this.instance);
				}
				return r_m_TileSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_TileOffset
		/// </summary>
		protected RUnityEngine.RVector2 r_m_TileOffset;
		public virtual RUnityEngine.RVector2 Rm_TileOffset
		{
			get
			{
				if(r_m_TileOffset == null)
				{
					r_m_TileOffset = new(this, "m_TileOffset");
					r_m_TileOffset.SetBelong(this.instance);
				}
				return r_m_TileOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 m_SpecularMetallic
		/// </summary>
		protected RUnityEngine.RVector4 r_m_SpecularMetallic;
		public virtual RUnityEngine.RVector4 Rm_SpecularMetallic
		{
			get
			{
				if(r_m_SpecularMetallic == null)
				{
					r_m_SpecularMetallic = new(this, "m_SpecularMetallic");
					r_m_SpecularMetallic.SetBelong(this.instance);
				}
				return r_m_SpecularMetallic;
			}
		}

		/// <summary>
		/// System.Single m_Smoothness
		/// </summary>
		protected RField r_m_Smoothness;
		public virtual RField Rm_Smoothness
		{
			get
			{
				if(r_m_Smoothness == null)
				{
					r_m_Smoothness = new(this, "m_Smoothness");
					r_m_Smoothness.SetBelong(this.instance);
				}
				return r_m_Smoothness;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D texture
		/// </summary>
		protected RUnityEngine.RTexture2D r_texture;
		public virtual RUnityEngine.RTexture2D Rtexture
		{
			get
			{
				if(r_texture == null)
				{
					r_texture = new(this, "texture", -1);
					r_texture.SetBelong(this.instance);
				}
				return r_texture;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D normalMap
		/// </summary>
		protected RUnityEngine.RTexture2D r_normalMap;
		public virtual RUnityEngine.RTexture2D RnormalMap
		{
			get
			{
				if(r_normalMap == null)
				{
					r_normalMap = new(this, "normalMap", -1);
					r_normalMap.SetBelong(this.instance);
				}
				return r_normalMap;
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


        public RSplatPrototype() : base("UnityEngine.SplatPrototype")
        {
        }

        public RSplatPrototype(System.Object instance) : base("UnityEngine.SplatPrototype")
		{
            SetInstance(instance);
		}

        public RSplatPrototype(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSplatPrototype(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
