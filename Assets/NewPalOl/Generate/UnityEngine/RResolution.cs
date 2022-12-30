using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Resolution
	/// </summary>
    public partial class RResolution : RMember //
    {

		/// <summary>
		/// System.Int32 m_Width
		/// </summary>
		protected RField r_m_Width;
		public virtual RField Rm_Width
		{
			get
			{
				if(r_m_Width == null)
				{
					r_m_Width = new(this, "m_Width");
					r_m_Width.SetBelong(this.instance);
				}
				return r_m_Width;
			}
		}

		/// <summary>
		/// System.Int32 m_Height
		/// </summary>
		protected RField r_m_Height;
		public virtual RField Rm_Height
		{
			get
			{
				if(r_m_Height == null)
				{
					r_m_Height = new(this, "m_Height");
					r_m_Height.SetBelong(this.instance);
				}
				return r_m_Height;
			}
		}

		/// <summary>
		/// UnityEngine.RefreshRate m_RefreshRate
		/// </summary>
		protected RUnityEngine.RRefreshRate r_m_RefreshRate;
		public virtual RUnityEngine.RRefreshRate Rm_RefreshRate
		{
			get
			{
				if(r_m_RefreshRate == null)
				{
					r_m_RefreshRate = new(this, "m_RefreshRate");
					r_m_RefreshRate.SetBelong(this.instance);
				}
				return r_m_RefreshRate;
			}
		}

		/// <summary>
		/// Int32 width
		/// </summary>
		protected RProperty r_width;
		public virtual RProperty Rwidth
		{
			get
			{
				if(r_width == null)
				{
					r_width = new(this, "width", -1);
					r_width.SetBelong(this.instance);
				}
				return r_width;
			}
		}

		/// <summary>
		/// Int32 height
		/// </summary>
		protected RProperty r_height;
		public virtual RProperty Rheight
		{
			get
			{
				if(r_height == null)
				{
					r_height = new(this, "height", -1);
					r_height.SetBelong(this.instance);
				}
				return r_height;
			}
		}

		/// <summary>
		/// UnityEngine.RefreshRate refreshRateRatio
		/// </summary>
		protected RUnityEngine.RRefreshRate r_refreshRateRatio;
		public virtual RUnityEngine.RRefreshRate RrefreshRateRatio
		{
			get
			{
				if(r_refreshRateRatio == null)
				{
					r_refreshRateRatio = new(this, "refreshRateRatio", -1);
					r_refreshRateRatio.SetBelong(this.instance);
				}
				return r_refreshRateRatio;
			}
		}

		/// <summary>
		/// Int32 refreshRate
		/// </summary>
		protected RProperty r_refreshRate;
		public virtual RProperty RrefreshRate
		{
			get
			{
				if(r_refreshRate == null)
				{
					r_refreshRate = new(this, "refreshRate", -1);
					r_refreshRate.SetBelong(this.instance);
				}
				return r_refreshRate;
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


        public RResolution() : base("UnityEngine.Resolution")
        {
        }

        public RResolution(System.Object instance) : base("UnityEngine.Resolution")
		{
            SetInstance(instance);
		}

        public RResolution(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RResolution(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
