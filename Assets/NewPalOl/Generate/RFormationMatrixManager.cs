using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FormationMatrixManager
	/// </summary>
    public partial class RFormationMatrixManager : RMember //
    {

		/// <summary>
		/// MatrixConfigHold matrixConfig
		/// </summary>
		protected RMatrixConfigHold r_matrixConfig;
		public virtual RMatrixConfigHold RmatrixConfig
		{
			get
			{
				if(r_matrixConfig == null)
				{
					r_matrixConfig = new(this, "matrixConfig");
					r_matrixConfig.SetBelong(this.instance);
				}
				return r_matrixConfig;
			}
		}

		/// <summary>
		/// RuneConfigHold matrixRuneConfig
		/// </summary>
		protected RRuneConfigHold r_matrixRuneConfig;
		public virtual RRuneConfigHold RmatrixRuneConfig
		{
			get
			{
				if(r_matrixRuneConfig == null)
				{
					r_matrixRuneConfig = new(this, "matrixRuneConfig");
					r_matrixRuneConfig.SetBelong(this.instance);
				}
				return r_matrixRuneConfig;
			}
		}

		/// <summary>
		/// shenshouConfigHold m_shenshouConfig
		/// </summary>
		protected RshenshouConfigHold r_m_shenshouConfig;
		public virtual RshenshouConfigHold Rm_shenshouConfig
		{
			get
			{
				if(r_m_shenshouConfig == null)
				{
					r_m_shenshouConfig = new(this, "m_shenshouConfig");
					r_m_shenshouConfig.SetBelong(this.instance);
				}
				return r_m_shenshouConfig;
			}
		}

		/// <summary>
		/// shenshouJingMaiConfigHold m_shenshouJingMaiConfig
		/// </summary>
		protected RshenshouJingMaiConfigHold r_m_shenshouJingMaiConfig;
		public virtual RshenshouJingMaiConfigHold Rm_shenshouJingMaiConfig
		{
			get
			{
				if(r_m_shenshouJingMaiConfig == null)
				{
					r_m_shenshouJingMaiConfig = new(this, "m_shenshouJingMaiConfig");
					r_m_shenshouJingMaiConfig.SetBelong(this.instance);
				}
				return r_m_shenshouJingMaiConfig;
			}
		}

		/// <summary>
		/// Void OnLoadMatrixConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadMatrixConfig_Object;
		public virtual RMethod ROnLoadMatrixConfig_Object
		{
			get
			{
				if(r_ROnLoadMatrixConfig_Object == null)
				{
					r_ROnLoadMatrixConfig_Object = new(this, "OnLoadMatrixConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadMatrixConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadMatrixConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadMatrixRuneConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadMatrixRuneConfig_Object;
		public virtual RMethod ROnLoadMatrixRuneConfig_Object
		{
			get
			{
				if(r_ROnLoadMatrixRuneConfig_Object == null)
				{
					r_ROnLoadMatrixRuneConfig_Object = new(this, "OnLoadMatrixRuneConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadMatrixRuneConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadMatrixRuneConfig_Object;
			}
		}

		/// <summary>
		/// MatrixItem GetMatrixItem(Int32)
		/// </summary>
		protected RMethod r_RGetMatrixItem_Int32;
		public virtual RMethod RGetMatrixItem_Int32
		{
			get
			{
				if(r_RGetMatrixItem_Int32 == null)
				{
					r_RGetMatrixItem_Int32 = new(this, "GetMatrixItem", 0, typeof(System.Int32));
					r_RGetMatrixItem_Int32.SetBelong(this.instance);
				}
				return r_RGetMatrixItem_Int32;
			}
		}

		/// <summary>
		/// RuneItem GetRuneItem(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetRuneItem_ID;
		public virtual RMethod RGetRuneItem_ID
		{
			get
			{
				if(r_RGetRuneItem_ID == null)
				{
					r_RGetRuneItem_ID = new(this, "GetRuneItem", 0, typeof(GameDefineType.ID));
					r_RGetRuneItem_ID.SetBelong(this.instance);
				}
				return r_RGetRuneItem_ID;
			}
		}

		/// <summary>
		/// Int32 RuneNeedItemSum(Int32, Int32)
		/// </summary>
		protected RMethod r_RRuneNeedItemSum_Int32_Int32;
		public virtual RMethod RRuneNeedItemSum_Int32_Int32
		{
			get
			{
				if(r_RRuneNeedItemSum_Int32_Int32 == null)
				{
					r_RRuneNeedItemSum_Int32_Int32 = new(this, "RuneNeedItemSum", 0, typeof(System.Int32), typeof(System.Int32));
					r_RRuneNeedItemSum_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRuneNeedItemSum_Int32_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadShenshouConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadShenshouConfig_Object;
		public virtual RMethod ROnLoadShenshouConfig_Object
		{
			get
			{
				if(r_ROnLoadShenshouConfig_Object == null)
				{
					r_ROnLoadShenshouConfig_Object = new(this, "OnLoadShenshouConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadShenshouConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadShenshouConfig_Object;
			}
		}

		/// <summary>
		/// shenshouItem GetshenshouItemByRuneWords(Int32)
		/// </summary>
		protected RMethod r_RGetshenshouItemByRuneWords_Int32;
		public virtual RMethod RGetshenshouItemByRuneWords_Int32
		{
			get
			{
				if(r_RGetshenshouItemByRuneWords_Int32 == null)
				{
					r_RGetshenshouItemByRuneWords_Int32 = new(this, "GetshenshouItemByRuneWords", 0, typeof(System.Int32));
					r_RGetshenshouItemByRuneWords_Int32.SetBelong(this.instance);
				}
				return r_RGetshenshouItemByRuneWords_Int32;
			}
		}

		/// <summary>
		/// Boolean isShenshouSkill(Int32)
		/// </summary>
		protected RMethod r_RisShenshouSkill_Int32;
		public virtual RMethod RisShenshouSkill_Int32
		{
			get
			{
				if(r_RisShenshouSkill_Int32 == null)
				{
					r_RisShenshouSkill_Int32 = new(this, "isShenshouSkill", 0, typeof(System.Int32));
					r_RisShenshouSkill_Int32.SetBelong(this.instance);
				}
				return r_RisShenshouSkill_Int32;
			}
		}

		/// <summary>
		/// shenshouItem GetshenshouItem(Int32)
		/// </summary>
		protected RMethod r_RGetshenshouItem_Int32;
		public virtual RMethod RGetshenshouItem_Int32
		{
			get
			{
				if(r_RGetshenshouItem_Int32 == null)
				{
					r_RGetshenshouItem_Int32 = new(this, "GetshenshouItem", 0, typeof(System.Int32));
					r_RGetshenshouItem_Int32.SetBelong(this.instance);
				}
				return r_RGetshenshouItem_Int32;
			}
		}

		/// <summary>
		/// shenshouItem GetshenshouItemByIndex(Int32)
		/// </summary>
		protected RMethod r_RGetshenshouItemByIndex_Int32;
		public virtual RMethod RGetshenshouItemByIndex_Int32
		{
			get
			{
				if(r_RGetshenshouItemByIndex_Int32 == null)
				{
					r_RGetshenshouItemByIndex_Int32 = new(this, "GetshenshouItemByIndex", 0, typeof(System.Int32));
					r_RGetshenshouItemByIndex_Int32.SetBelong(this.instance);
				}
				return r_RGetshenshouItemByIndex_Int32;
			}
		}

		/// <summary>
		/// Int32 GetShenshouIndex(Int32)
		/// </summary>
		protected RMethod r_RGetShenshouIndex_Int32;
		public virtual RMethod RGetShenshouIndex_Int32
		{
			get
			{
				if(r_RGetShenshouIndex_Int32 == null)
				{
					r_RGetShenshouIndex_Int32 = new(this, "GetShenshouIndex", 0, typeof(System.Int32));
					r_RGetShenshouIndex_Int32.SetBelong(this.instance);
				}
				return r_RGetShenshouIndex_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadShenshouJingMaiConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadShenshouJingMaiConfig_Object;
		public virtual RMethod ROnLoadShenshouJingMaiConfig_Object
		{
			get
			{
				if(r_ROnLoadShenshouJingMaiConfig_Object == null)
				{
					r_ROnLoadShenshouJingMaiConfig_Object = new(this, "OnLoadShenshouJingMaiConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadShenshouJingMaiConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadShenshouJingMaiConfig_Object;
			}
		}

		/// <summary>
		/// shenshouJingMaiItem GetShenshouJingMaiItem(Int32)
		/// </summary>
		protected RMethod r_RGetShenshouJingMaiItem_Int32;
		public virtual RMethod RGetShenshouJingMaiItem_Int32
		{
			get
			{
				if(r_RGetShenshouJingMaiItem_Int32 == null)
				{
					r_RGetShenshouJingMaiItem_Int32 = new(this, "GetShenshouJingMaiItem", 0, typeof(System.Int32));
					r_RGetShenshouJingMaiItem_Int32.SetBelong(this.instance);
				}
				return r_RGetShenshouJingMaiItem_Int32;
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


        public RFormationMatrixManager() : base("FormationMatrixManager")
        {
        }

        public RFormationMatrixManager(System.Object instance) : base("FormationMatrixManager")
		{
            SetInstance(instance);
		}

        public RFormationMatrixManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFormationMatrixManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadMatrixConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadMatrixConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadMatrixRuneConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadMatrixRuneConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual MatrixItem GetMatrixItem(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetMatrixItem_Int32.Invoke(___genericsType, ___parameters);

            return (MatrixItem)___result;
        }


        public virtual RuneItem GetRuneItem(GameDefineType.ID  @mID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mID};
            var ___result = RGetRuneItem_ID.Invoke(___genericsType, ___parameters);

            return (RuneItem)___result;
        }


        public virtual System.Int32 RuneNeedItemSum(System.Int32  @runeTyp, System.Int32  @lv)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@runeTyp, @lv};
            var ___result = RRuneNeedItemSum_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void OnLoadShenshouConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadShenshouConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual shenshouItem GetshenshouItemByRuneWords(System.Int32  @runeWords)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@runeWords};
            var ___result = RGetshenshouItemByRuneWords_Int32.Invoke(___genericsType, ___parameters);

            return (shenshouItem)___result;
        }


        public virtual System.Boolean isShenshouSkill(System.Int32  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = RisShenshouSkill_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual shenshouItem GetshenshouItem(System.Int32  @shenshouTyp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shenshouTyp};
            var ___result = RGetshenshouItem_Int32.Invoke(___genericsType, ___parameters);

            return (shenshouItem)___result;
        }


        public virtual shenshouItem GetshenshouItemByIndex(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RGetshenshouItemByIndex_Int32.Invoke(___genericsType, ___parameters);

            return (shenshouItem)___result;
        }


        public virtual System.Int32 GetShenshouIndex(System.Int32  @shenshouTyp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@shenshouTyp};
            var ___result = RGetShenshouIndex_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void OnLoadShenshouJingMaiConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadShenshouJingMaiConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual shenshouJingMaiItem GetShenshouJingMaiItem(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetShenshouJingMaiItem_Int32.Invoke(___genericsType, ___parameters);

            return (shenshouJingMaiItem)___result;
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
