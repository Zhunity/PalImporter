using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// AreaManager
	/// </summary>
    public partial class RAreaManager : RMember //
    {

		/// <summary>
		/// KeyValueContent mAreaInfo
		/// </summary>
		protected RKeyValueContent r_mAreaInfo;
		public virtual RKeyValueContent RmAreaInfo
		{
			get
			{
				if(r_mAreaInfo == null)
				{
					r_mAreaInfo = new(this, "mAreaInfo");
					r_mAreaInfo.SetBelong(this.instance);
				}
				return r_mAreaInfo;
			}
		}

		/// <summary>
		/// System.String UNKONW_AREA
		/// </summary>
		protected RField r_UNKONW_AREA;
		public virtual RField RUNKONW_AREA
		{
			get
			{
				if(r_UNKONW_AREA == null)
				{
					r_UNKONW_AREA = new(this, "UNKONW_AREA");
					r_UNKONW_AREA.SetBelong(this.instance);
				}
				return r_UNKONW_AREA;
			}
		}

		/// <summary>
		/// System.String AREA_NAME
		/// </summary>
		protected RField r_AREA_NAME;
		public virtual RField RAREA_NAME
		{
			get
			{
				if(r_AREA_NAME == null)
				{
					r_AREA_NAME = new(this, "AREA_NAME");
					r_AREA_NAME.SetBelong(this.instance);
				}
				return r_AREA_NAME;
			}
		}

		/// <summary>
		/// System.String AREA_TYPE
		/// </summary>
		protected RField r_AREA_TYPE;
		public virtual RField RAREA_TYPE
		{
			get
			{
				if(r_AREA_TYPE == null)
				{
					r_AREA_TYPE = new(this, "AREA_TYPE");
					r_AREA_TYPE.SetBelong(this.instance);
				}
				return r_AREA_TYPE;
			}
		}

		/// <summary>
		/// GameDefineType.ID m_CurAreaId
		/// </summary>
		protected RGameDefineType.RID r_m_CurAreaId;
		public virtual RGameDefineType.RID Rm_CurAreaId
		{
			get
			{
				if(r_m_CurAreaId == null)
				{
					r_m_CurAreaId = new(this, "m_CurAreaId");
					r_m_CurAreaId.SetBelong(this.instance);
				}
				return r_m_CurAreaId;
			}
		}

		/// <summary>
		/// GameDefineType.ID CurrentAreaID
		/// </summary>
		protected RGameDefineType.RID r_CurrentAreaID;
		public virtual RGameDefineType.RID RCurrentAreaID
		{
			get
			{
				if(r_CurrentAreaID == null)
				{
					r_CurrentAreaID = new(this, "CurrentAreaID", -1);
					r_CurrentAreaID.SetBelong(this.instance);
				}
				return r_CurrentAreaID;
			}
		}

		/// <summary>
		/// Boolean IsReadyToUse
		/// </summary>
		protected RProperty r_IsReadyToUse;
		public virtual RProperty RIsReadyToUse
		{
			get
			{
				if(r_IsReadyToUse == null)
				{
					r_IsReadyToUse = new(this, "IsReadyToUse", -1);
					r_IsReadyToUse.SetBelong(this.instance);
				}
				return r_IsReadyToUse;
			}
		}

		/// <summary>
		/// Void OnLoadAreaConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadAreaConfig_Object;
		public virtual RMethod ROnLoadAreaConfig_Object
		{
			get
			{
				if(r_ROnLoadAreaConfig_Object == null)
				{
					r_ROnLoadAreaConfig_Object = new(this, "OnLoadAreaConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadAreaConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadAreaConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetAreaName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetAreaName_ID;
		public virtual RMethod RGetAreaName_ID
		{
			get
			{
				if(r_RGetAreaName_ID == null)
				{
					r_RGetAreaName_ID = new(this, "GetAreaName", 0, typeof(GameDefineType.ID));
					r_RGetAreaName_ID.SetBelong(this.instance);
				}
				return r_RGetAreaName_ID;
			}
		}

		/// <summary>
		/// System.String GetAreaType(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetAreaType_ID;
		public virtual RMethod RGetAreaType_ID
		{
			get
			{
				if(r_RGetAreaType_ID == null)
				{
					r_RGetAreaType_ID = new(this, "GetAreaType", 0, typeof(GameDefineType.ID));
					r_RGetAreaType_ID.SetBelong(this.instance);
				}
				return r_RGetAreaType_ID;
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


        public RAreaManager() : base("AreaManager")
        {
        }

        public RAreaManager(System.Object instance) : base("AreaManager")
		{
            SetInstance(instance);
		}

        public RAreaManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAreaManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadAreaConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadAreaConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetAreaName(GameDefineType.ID  @areaID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@areaID};
            var ___result = RGetAreaName_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetAreaType(GameDefineType.ID  @areaID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@areaID};
            var ___result = RGetAreaType_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
