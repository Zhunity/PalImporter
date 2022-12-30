using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMapResource
	/// </summary>
    public partial class RSceneMapResource : RMember //
    {

		/// <summary>
		/// System.String mName
		/// </summary>
		protected RField r_mName;
		public virtual RField RmName
		{
			get
			{
				if(r_mName == null)
				{
					r_mName = new(this, "mName");
					r_mName.SetBelong(this.instance);
				}
				return r_mName;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected RField r_url;
		public virtual RField Rurl
		{
			get
			{
				if(r_url == null)
				{
					r_url = new(this, "url");
					r_url.SetBelong(this.instance);
				}
				return r_url;
			}
		}

		/// <summary>
		/// System.Boolean ShowFog
		/// </summary>
		protected RField r_ShowFog;
		public virtual RField RShowFog
		{
			get
			{
				if(r_ShowFog == null)
				{
					r_ShowFog = new(this, "ShowFog");
					r_ShowFog.SetBelong(this.instance);
				}
				return r_ShowFog;
			}
		}

		/// <summary>
		/// System.Boolean bShowDetail
		/// </summary>
		protected RField r_bShowDetail;
		public virtual RField RbShowDetail
		{
			get
			{
				if(r_bShowDetail == null)
				{
					r_bShowDetail = new(this, "bShowDetail");
					r_bShowDetail.SetBelong(this.instance);
				}
				return r_bShowDetail;
			}
		}

		/// <summary>
		/// System.Boolean bShowInList
		/// </summary>
		protected RField r_bShowInList;
		public virtual RField RbShowInList
		{
			get
			{
				if(r_bShowInList == null)
				{
					r_bShowInList = new(this, "bShowInList");
					r_bShowInList.SetBelong(this.instance);
				}
				return r_bShowInList;
			}
		}

		/// <summary>
		/// System.Single angle
		/// </summary>
		protected RField r_angle;
		public virtual RField Rangle
		{
			get
			{
				if(r_angle == null)
				{
					r_angle = new(this, "angle");
					r_angle.SetBelong(this.instance);
				}
				return r_angle;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_OriSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_OriSize;
		public virtual RUnityEngine.RVector2 Rm_OriSize
		{
			get
			{
				if(r_m_OriSize == null)
				{
					r_m_OriSize = new(this, "m_OriSize");
					r_m_OriSize.SetBelong(this.instance);
				}
				return r_m_OriSize;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 m_RealSize
		/// </summary>
		protected RUnityEngine.RVector2 r_m_RealSize;
		public virtual RUnityEngine.RVector2 Rm_RealSize
		{
			get
			{
				if(r_m_RealSize == null)
				{
					r_m_RealSize = new(this, "m_RealSize");
					r_m_RealSize.SetBelong(this.instance);
				}
				return r_m_RealSize;
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


        public RSceneMapResource() : base("SceneMapResource")
        {
        }

        public RSceneMapResource(System.Object instance) : base("SceneMapResource")
		{
            SetInstance(instance);
		}

        public RSceneMapResource(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMapResource(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
