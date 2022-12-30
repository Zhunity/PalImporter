using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.TreeInstance
	/// </summary>
    public partial class RTreeInstance : RMember //
    {

		/// <summary>
		/// UnityEngine.Vector3 position
		/// </summary>
		protected RUnityEngine.RVector3 r_position;
		public virtual RUnityEngine.RVector3 Rposition
		{
			get
			{
				if(r_position == null)
				{
					r_position = new(this, "position");
					r_position.SetBelong(this.instance);
				}
				return r_position;
			}
		}

		/// <summary>
		/// System.Single widthScale
		/// </summary>
		protected RField r_widthScale;
		public virtual RField RwidthScale
		{
			get
			{
				if(r_widthScale == null)
				{
					r_widthScale = new(this, "widthScale");
					r_widthScale.SetBelong(this.instance);
				}
				return r_widthScale;
			}
		}

		/// <summary>
		/// System.Single heightScale
		/// </summary>
		protected RField r_heightScale;
		public virtual RField RheightScale
		{
			get
			{
				if(r_heightScale == null)
				{
					r_heightScale = new(this, "heightScale");
					r_heightScale.SetBelong(this.instance);
				}
				return r_heightScale;
			}
		}

		/// <summary>
		/// System.Single rotation
		/// </summary>
		protected RField r_rotation;
		public virtual RField Rrotation
		{
			get
			{
				if(r_rotation == null)
				{
					r_rotation = new(this, "rotation");
					r_rotation.SetBelong(this.instance);
				}
				return r_rotation;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 color
		/// </summary>
		protected RUnityEngine.RColor32 r_color;
		public virtual RUnityEngine.RColor32 Rcolor
		{
			get
			{
				if(r_color == null)
				{
					r_color = new(this, "color");
					r_color.SetBelong(this.instance);
				}
				return r_color;
			}
		}

		/// <summary>
		/// UnityEngine.Color32 lightmapColor
		/// </summary>
		protected RUnityEngine.RColor32 r_lightmapColor;
		public virtual RUnityEngine.RColor32 RlightmapColor
		{
			get
			{
				if(r_lightmapColor == null)
				{
					r_lightmapColor = new(this, "lightmapColor");
					r_lightmapColor.SetBelong(this.instance);
				}
				return r_lightmapColor;
			}
		}

		/// <summary>
		/// System.Int32 prototypeIndex
		/// </summary>
		protected RField r_prototypeIndex;
		public virtual RField RprototypeIndex
		{
			get
			{
				if(r_prototypeIndex == null)
				{
					r_prototypeIndex = new(this, "prototypeIndex");
					r_prototypeIndex.SetBelong(this.instance);
				}
				return r_prototypeIndex;
			}
		}

		/// <summary>
		/// System.Single temporaryDistance
		/// </summary>
		protected RField r_temporaryDistance;
		public virtual RField RtemporaryDistance
		{
			get
			{
				if(r_temporaryDistance == null)
				{
					r_temporaryDistance = new(this, "temporaryDistance");
					r_temporaryDistance.SetBelong(this.instance);
				}
				return r_temporaryDistance;
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


        public RTreeInstance() : base("UnityEngine.TreeInstance")
        {
        }

        public RTreeInstance(System.Object instance) : base("UnityEngine.TreeInstance")
		{
            SetInstance(instance);
		}

        public RTreeInstance(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTreeInstance(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
