using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// BGImageBilt
	/// </summary>
    public partial class RBGImageBilt : RMember //
    {

		/// <summary>
		/// UnityEngine.RenderTexture _ImageBG
		/// </summary>
		protected RUnityEngine.RRenderTexture r__ImageBG;
		public virtual RUnityEngine.RRenderTexture R_ImageBG
		{
			get
			{
				if(r__ImageBG == null)
				{
					r__ImageBG = new(this, "_ImageBG");
					r__ImageBG.SetBelong(this.instance);
				}
				return r__ImageBG;
			}
		}

		/// <summary>
		/// UnityEngine.Material _ImageBGmat
		/// </summary>
		protected RUnityEngine.RMaterial r__ImageBGmat;
		public virtual RUnityEngine.RMaterial R_ImageBGmat
		{
			get
			{
				if(r__ImageBGmat == null)
				{
					r__ImageBGmat = new(this, "_ImageBGmat");
					r__ImageBGmat.SetBelong(this.instance);
				}
				return r__ImageBGmat;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject _cameraGO
		/// </summary>
		protected RUnityEngine.RGameObject r__cameraGO;
		public virtual RUnityEngine.RGameObject R_cameraGO
		{
			get
			{
				if(r__cameraGO == null)
				{
					r__cameraGO = new(this, "_cameraGO");
					r__cameraGO.SetBelong(this.instance);
				}
				return r__cameraGO;
			}
		}

		/// <summary>
		/// UnityEngine.Projector _BGprojector
		/// </summary>
		protected RUnityEngine.RProjector r__BGprojector;
		public virtual RUnityEngine.RProjector R_BGprojector
		{
			get
			{
				if(r__BGprojector == null)
				{
					r__BGprojector = new(this, "_BGprojector");
					r__BGprojector.SetBelong(this.instance);
				}
				return r__BGprojector;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject _projectorGO
		/// </summary>
		protected RUnityEngine.RGameObject r__projectorGO;
		public virtual RUnityEngine.RGameObject R_projectorGO
		{
			get
			{
				if(r__projectorGO == null)
				{
					r__projectorGO = new(this, "_projectorGO");
					r__projectorGO.SetBelong(this.instance);
				}
				return r__projectorGO;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture ImageBG
		/// </summary>
		protected RUnityEngine.RRenderTexture r_ImageBG;
		public virtual RUnityEngine.RRenderTexture RImageBG
		{
			get
			{
				if(r_ImageBG == null)
				{
					r_ImageBG = new(this, "ImageBG", -1);
					r_ImageBG.SetBelong(this.instance);
				}
				return r_ImageBG;
			}
		}

		/// <summary>
		/// UnityEngine.Material ImageBGmat
		/// </summary>
		protected RUnityEngine.RMaterial r_ImageBGmat;
		public virtual RUnityEngine.RMaterial RImageBGmat
		{
			get
			{
				if(r_ImageBGmat == null)
				{
					r_ImageBGmat = new(this, "ImageBGmat", -1);
					r_ImageBGmat.SetBelong(this.instance);
				}
				return r_ImageBGmat;
			}
		}

		/// <summary>
		/// Void StartRend()
		/// </summary>
		protected RMethod r_RStartRend;
		public virtual RMethod RStartRend
		{
			get
			{
				if(r_RStartRend == null)
				{
					r_RStartRend = new(this, "StartRend", 0);
					r_RStartRend.SetBelong(this.instance);
				}
				return r_RStartRend;
			}
		}

		/// <summary>
		/// Void EndRend()
		/// </summary>
		protected RMethod r_REndRend;
		public virtual RMethod REndRend
		{
			get
			{
				if(r_REndRend == null)
				{
					r_REndRend = new(this, "EndRend", 0);
					r_REndRend.SetBelong(this.instance);
				}
				return r_REndRend;
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


        public RBGImageBilt() : base("BGImageBilt")
        {
        }

        public RBGImageBilt(System.Object instance) : base("BGImageBilt")
		{
            SetInstance(instance);
		}

        public RBGImageBilt(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBGImageBilt(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void StartRend()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStartRend.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EndRend()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REndRend.Invoke(___genericsType, ___parameters);

            
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
