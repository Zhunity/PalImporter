using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PriceTemplate
	/// </summary>
    public partial class RPriceTemplate : RMember //
    {

		/// <summary>
		/// System.Int32 PRE_IDX
		/// </summary>
		protected static RField r_PRE_IDX;
		public static RField RPRE_IDX
		{
			get
			{
				if(r_PRE_IDX == null)
				{
					r_PRE_IDX = new( ReleactionUtils.GetType("PriceTemplate"), "PRE_IDX");
					r_PRE_IDX.SetBelong(null);
				}
				return r_PRE_IDX;
			}
		}

		/// <summary>
		/// KeyValueContent m_ItemContent
		/// </summary>
		protected RKeyValueContent r_m_ItemContent;
		public virtual RKeyValueContent Rm_ItemContent
		{
			get
			{
				if(r_m_ItemContent == null)
				{
					r_m_ItemContent = new(this, "m_ItemContent");
					r_m_ItemContent.SetBelong(this.instance);
				}
				return r_m_ItemContent;
			}
		}

		/// <summary>
		/// Void OnLoadPriceConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPriceConfig_Object;
		public virtual RMethod ROnLoadPriceConfig_Object
		{
			get
			{
				if(r_ROnLoadPriceConfig_Object == null)
				{
					r_ROnLoadPriceConfig_Object = new(this, "OnLoadPriceConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPriceConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPriceConfig_Object;
			}
		}

		/// <summary>
		/// Int32 GetEnableBagPrice(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetEnableBagPrice_Int32_Int32;
		public virtual RMethod RGetEnableBagPrice_Int32_Int32
		{
			get
			{
				if(r_RGetEnableBagPrice_Int32_Int32 == null)
				{
					r_RGetEnableBagPrice_Int32_Int32 = new(this, "GetEnableBagPrice", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetEnableBagPrice_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetEnableBagPrice_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetEnableExBagPrice()
		/// </summary>
		protected RMethod r_RGetEnableExBagPrice;
		public virtual RMethod RGetEnableExBagPrice
		{
			get
			{
				if(r_RGetEnableExBagPrice == null)
				{
					r_RGetEnableExBagPrice = new(this, "GetEnableExBagPrice", 0);
					r_RGetEnableExBagPrice.SetBelong(this.instance);
				}
				return r_RGetEnableExBagPrice;
			}
		}

		/// <summary>
		/// Int32 GetExtendTimeRefillPrice(Int32)
		/// </summary>
		protected RMethod r_RGetExtendTimeRefillPrice_Int32;
		public virtual RMethod RGetExtendTimeRefillPrice_Int32
		{
			get
			{
				if(r_RGetExtendTimeRefillPrice_Int32 == null)
				{
					r_RGetExtendTimeRefillPrice_Int32 = new(this, "GetExtendTimeRefillPrice", 0, typeof(System.Int32));
					r_RGetExtendTimeRefillPrice_Int32.SetBelong(this.instance);
				}
				return r_RGetExtendTimeRefillPrice_Int32;
			}
		}

		/// <summary>
		/// Int32 GetPrice(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetPrice_ID;
		public virtual RMethod RGetPrice_ID
		{
			get
			{
				if(r_RGetPrice_ID == null)
				{
					r_RGetPrice_ID = new(this, "GetPrice", 0, typeof(GameDefineType.ID));
					r_RGetPrice_ID.SetBelong(this.instance);
				}
				return r_RGetPrice_ID;
			}
		}

		/// <summary>
		/// Boolean GetMaterialPathParam(GameDefineType.ID, GameDefineType.ID ByRef, GameDefineType.ID ByRef, GameDefineType.ID ByRef)
		/// </summary>
		protected RMethod r_RGetMaterialPathParam_ID_Out_ID_Out_ID_Out_ID;
		public virtual RMethod RGetMaterialPathParam_ID_Out_ID_Out_ID_Out_ID
		{
			get
			{
				if(r_RGetMaterialPathParam_ID_Out_ID_Out_ID_Out_ID == null)
				{
					r_RGetMaterialPathParam_ID_Out_ID_Out_ID_Out_ID = new(this, "GetMaterialPathParam", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID).MakeByRefType(), typeof(GameDefineType.ID).MakeByRefType(), typeof(GameDefineType.ID).MakeByRefType());
					r_RGetMaterialPathParam_ID_Out_ID_Out_ID_Out_ID.SetBelong(this.instance);
				}
				return r_RGetMaterialPathParam_ID_Out_ID_Out_ID_Out_ID;
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


        public RPriceTemplate() : base("PriceTemplate")
        {
        }

        public RPriceTemplate(System.Object instance) : base("PriceTemplate")
		{
            SetInstance(instance);
		}

        public RPriceTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPriceTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadPriceConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadPriceConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetEnableBagPrice(System.Int32  @startidx, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startidx, @count};
            var ___result = RGetEnableBagPrice_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetEnableExBagPrice()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnableExBagPrice.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetExtendTimeRefillPrice(System.Int32  @cap)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cap};
            var ___result = RGetExtendTimeRefillPrice_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetPrice(GameDefineType.ID  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = RGetPrice_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean GetMaterialPathParam(GameDefineType.ID  @material, out GameDefineType.ID  @mapid, out GameDefineType.ID  @npcid, out GameDefineType.ID  @raidid)
        {
			mapid = default;
			npcid = default;
			raidid = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@material, @mapid, @npcid, @raidid};
            var ___result = RGetMaterialPathParam_ID_Out_ID_Out_ID_Out_ID.Invoke(___genericsType, ___parameters);
			mapid = (GameDefineType.ID)___parameters[1];
			npcid = (GameDefineType.ID)___parameters[2];
			raidid = (GameDefineType.ID)___parameters[3];

            return (System.Boolean)___result;
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
