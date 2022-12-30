using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RHighlightableObject
{
	
	/// <summary>
	/// HighlightableObject+HighlightingRendererCache
	/// </summary>
    public partial class RHighlightingRendererCache : RMember //
    {

		/// <summary>
		/// UnityEngine.Renderer rendererCached
		/// </summary>
		protected RUnityEngine.RRenderer r_rendererCached;
		public virtual RUnityEngine.RRenderer RrendererCached
		{
			get
			{
				if(r_rendererCached == null)
				{
					r_rendererCached = new(this, "rendererCached");
					r_rendererCached.SetBelong(this.instance);
				}
				return r_rendererCached;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject goCached
		/// </summary>
		protected RUnityEngine.RGameObject r_goCached;
		public virtual RUnityEngine.RGameObject RgoCached
		{
			get
			{
				if(r_goCached == null)
				{
					r_goCached = new(this, "goCached");
					r_goCached.SetBelong(this.instance);
				}
				return r_goCached;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] sourceMaterials
		/// </summary>
		protected RFieldArray<RUnityEngine.RMaterial> r_sourceMaterials;
		public virtual RFieldArray<RUnityEngine.RMaterial> RsourceMaterials
		{
			get
			{
				if(r_sourceMaterials == null)
				{
					r_sourceMaterials = new(this, "sourceMaterials");
					r_sourceMaterials.SetBelong(this.instance);
				}
				return r_sourceMaterials;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] replacementMaterials
		/// </summary>
		protected RFieldArray<RUnityEngine.RMaterial> r_replacementMaterials;
		public virtual RFieldArray<RUnityEngine.RMaterial> RreplacementMaterials
		{
			get
			{
				if(r_replacementMaterials == null)
				{
					r_replacementMaterials = new(this, "replacementMaterials");
					r_replacementMaterials.SetBelong(this.instance);
				}
				return r_replacementMaterials;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.Int32] transparentMaterialIndexes
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r_transparentMaterialIndexes;
		public virtual RSystem.RCollections.RGeneric.RList<RField> RtransparentMaterialIndexes
		{
			get
			{
				if(r_transparentMaterialIndexes == null)
				{
					r_transparentMaterialIndexes = new(this, "transparentMaterialIndexes");
					r_transparentMaterialIndexes.SetBelong(this.instance);
				}
				return r_transparentMaterialIndexes;
			}
		}

		/// <summary>
		/// Void SetState(Boolean)
		/// </summary>
		protected RMethod r_RSetState_Boolean;
		public virtual RMethod RSetState_Boolean
		{
			get
			{
				if(r_RSetState_Boolean == null)
				{
					r_RSetState_Boolean = new(this, "SetState", 0, typeof(System.Boolean));
					r_RSetState_Boolean.SetBelong(this.instance);
				}
				return r_RSetState_Boolean;
			}
		}

		/// <summary>
		/// Void SetColorForTransparent(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RSetColorForTransparent_Color;
		public virtual RMethod RSetColorForTransparent_Color
		{
			get
			{
				if(r_RSetColorForTransparent_Color == null)
				{
					r_RSetColorForTransparent_Color = new(this, "SetColorForTransparent", 0, typeof(UnityEngine.Color));
					r_RSetColorForTransparent_Color.SetBelong(this.instance);
				}
				return r_RSetColorForTransparent_Color;
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


        public RHighlightingRendererCache() : base("HighlightableObject+HighlightingRendererCache")
        {
        }

        public RHighlightingRendererCache(System.Object instance) : base("HighlightableObject+HighlightingRendererCache")
		{
            SetInstance(instance);
		}

        public RHighlightingRendererCache(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RHighlightingRendererCache(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetState(System.Boolean  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetState_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetColorForTransparent(UnityEngine.Color  @clr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@clr};
            var ___result = RSetColorForTransparent_Color.Invoke(___genericsType, ___parameters);

            
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
}