using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// YuanLingManager
	/// </summary>
    public partial class RYuanLingManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,YuanLing] YuanLingInfoDic
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RYuanLing> r_YuanLingInfoDic;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RYuanLing> RYuanLingInfoDic
		{
			get
			{
				if(r_YuanLingInfoDic == null)
				{
					r_YuanLingInfoDic = new(this, "YuanLingInfoDic");
					r_YuanLingInfoDic.SetBelong(this.instance);
				}
				return r_YuanLingInfoDic;
			}
		}

		/// <summary>
		/// System.Int32 active_id
		/// </summary>
		protected RField r_active_id;
		public virtual RField Ractive_id
		{
			get
			{
				if(r_active_id == null)
				{
					r_active_id = new(this, "active_id");
					r_active_id.SetBelong(this.instance);
				}
				return r_active_id;
			}
		}

		/// <summary>
		/// KeyValueContent YuanLingInfoContent
		/// </summary>
		protected RKeyValueContent r_YuanLingInfoContent;
		public virtual RKeyValueContent RYuanLingInfoContent
		{
			get
			{
				if(r_YuanLingInfoContent == null)
				{
					r_YuanLingInfoContent = new(this, "YuanLingInfoContent");
					r_YuanLingInfoContent.SetBelong(this.instance);
				}
				return r_YuanLingInfoContent;
			}
		}

		/// <summary>
		/// KeyValueContent YuanLingLevelInfoContent
		/// </summary>
		protected RKeyValueContent r_YuanLingLevelInfoContent;
		public virtual RKeyValueContent RYuanLingLevelInfoContent
		{
			get
			{
				if(r_YuanLingLevelInfoContent == null)
				{
					r_YuanLingLevelInfoContent = new(this, "YuanLingLevelInfoContent");
					r_YuanLingLevelInfoContent.SetBelong(this.instance);
				}
				return r_YuanLingLevelInfoContent;
			}
		}

		/// <summary>
		/// Void Initial()
		/// </summary>
		protected RMethod r_RInitial;
		public virtual RMethod RInitial
		{
			get
			{
				if(r_RInitial == null)
				{
					r_RInitial = new(this, "Initial", 0);
					r_RInitial.SetBelong(this.instance);
				}
				return r_RInitial;
			}
		}

		/// <summary>
		/// Void OnGetYuanLingInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnGetYuanLingInfo_Object___0__Isb;
		public virtual RMethod ROnGetYuanLingInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnGetYuanLingInfo_Object___0__Isb == null)
				{
					r_ROnGetYuanLingInfo_Object___0__Isb = new(this, "OnGetYuanLingInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnGetYuanLingInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnGetYuanLingInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void Count_All_Add()
		/// </summary>
		protected RMethod r_RCount_All_Add;
		public virtual RMethod RCount_All_Add
		{
			get
			{
				if(r_RCount_All_Add == null)
				{
					r_RCount_All_Add = new(this, "Count_All_Add", 0);
					r_RCount_All_Add.SetBelong(this.instance);
				}
				return r_RCount_All_Add;
			}
		}

		/// <summary>
		/// Int32 GetActiveID()
		/// </summary>
		protected RMethod r_RGetActiveID;
		public virtual RMethod RGetActiveID
		{
			get
			{
				if(r_RGetActiveID == null)
				{
					r_RGetActiveID = new(this, "GetActiveID", 0);
					r_RGetActiveID.SetBelong(this.instance);
				}
				return r_RGetActiveID;
			}
		}

		/// <summary>
		/// YuanLing GetNowYuanLingInfo(Int32)
		/// </summary>
		protected RMethod r_RGetNowYuanLingInfo_Int32;
		public virtual RMethod RGetNowYuanLingInfo_Int32
		{
			get
			{
				if(r_RGetNowYuanLingInfo_Int32 == null)
				{
					r_RGetNowYuanLingInfo_Int32 = new(this, "GetNowYuanLingInfo", 0, typeof(System.Int32));
					r_RGetNowYuanLingInfo_Int32.SetBelong(this.instance);
				}
				return r_RGetNowYuanLingInfo_Int32;
			}
		}

		/// <summary>
		/// Void SendYuanlingActive(Int32)
		/// </summary>
		protected RMethod r_RSendYuanlingActive_Int32;
		public virtual RMethod RSendYuanlingActive_Int32
		{
			get
			{
				if(r_RSendYuanlingActive_Int32 == null)
				{
					r_RSendYuanlingActive_Int32 = new(this, "SendYuanlingActive", 0, typeof(System.Int32));
					r_RSendYuanlingActive_Int32.SetBelong(this.instance);
				}
				return r_RSendYuanlingActive_Int32;
			}
		}

		/// <summary>
		/// Void SendYuanlingEatOne(Int32)
		/// </summary>
		protected RMethod r_RSendYuanlingEatOne_Int32;
		public virtual RMethod RSendYuanlingEatOne_Int32
		{
			get
			{
				if(r_RSendYuanlingEatOne_Int32 == null)
				{
					r_RSendYuanlingEatOne_Int32 = new(this, "SendYuanlingEatOne", 0, typeof(System.Int32));
					r_RSendYuanlingEatOne_Int32.SetBelong(this.instance);
				}
				return r_RSendYuanlingEatOne_Int32;
			}
		}

		/// <summary>
		/// Void SendYuanlingEatOneLevel(Int32)
		/// </summary>
		protected RMethod r_RSendYuanlingEatOneLevel_Int32;
		public virtual RMethod RSendYuanlingEatOneLevel_Int32
		{
			get
			{
				if(r_RSendYuanlingEatOneLevel_Int32 == null)
				{
					r_RSendYuanlingEatOneLevel_Int32 = new(this, "SendYuanlingEatOneLevel", 0, typeof(System.Int32));
					r_RSendYuanlingEatOneLevel_Int32.SetBelong(this.instance);
				}
				return r_RSendYuanlingEatOneLevel_Int32;
			}
		}

		/// <summary>
		/// Void SendYuanlingPutOn(Int32)
		/// </summary>
		protected RMethod r_RSendYuanlingPutOn_Int32;
		public virtual RMethod RSendYuanlingPutOn_Int32
		{
			get
			{
				if(r_RSendYuanlingPutOn_Int32 == null)
				{
					r_RSendYuanlingPutOn_Int32 = new(this, "SendYuanlingPutOn", 0, typeof(System.Int32));
					r_RSendYuanlingPutOn_Int32.SetBelong(this.instance);
				}
				return r_RSendYuanlingPutOn_Int32;
			}
		}

		/// <summary>
		/// Void SendYuanlingTakeOff(Int32)
		/// </summary>
		protected RMethod r_RSendYuanlingTakeOff_Int32;
		public virtual RMethod RSendYuanlingTakeOff_Int32
		{
			get
			{
				if(r_RSendYuanlingTakeOff_Int32 == null)
				{
					r_RSendYuanlingTakeOff_Int32 = new(this, "SendYuanlingTakeOff", 0, typeof(System.Int32));
					r_RSendYuanlingTakeOff_Int32.SetBelong(this.instance);
				}
				return r_RSendYuanlingTakeOff_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadYuanLingInfoConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadYuanLingInfoConfig_Object;
		public virtual RMethod ROnLoadYuanLingInfoConfig_Object
		{
			get
			{
				if(r_ROnLoadYuanLingInfoConfig_Object == null)
				{
					r_ROnLoadYuanLingInfoConfig_Object = new(this, "OnLoadYuanLingInfoConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadYuanLingInfoConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadYuanLingInfoConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetYuanLingInfoValue(Int32, System.String)
		/// </summary>
		protected RMethod r_RGetYuanLingInfoValue_Int32_String;
		public virtual RMethod RGetYuanLingInfoValue_Int32_String
		{
			get
			{
				if(r_RGetYuanLingInfoValue_Int32_String == null)
				{
					r_RGetYuanLingInfoValue_Int32_String = new(this, "GetYuanLingInfoValue", 0, typeof(System.Int32), typeof(System.String));
					r_RGetYuanLingInfoValue_Int32_String.SetBelong(this.instance);
				}
				return r_RGetYuanLingInfoValue_Int32_String;
			}
		}

		/// <summary>
		/// Int32 MaxYuanLingNum()
		/// </summary>
		protected RMethod r_RMaxYuanLingNum;
		public virtual RMethod RMaxYuanLingNum
		{
			get
			{
				if(r_RMaxYuanLingNum == null)
				{
					r_RMaxYuanLingNum = new(this, "MaxYuanLingNum", 0);
					r_RMaxYuanLingNum.SetBelong(this.instance);
				}
				return r_RMaxYuanLingNum;
			}
		}

		/// <summary>
		/// Void OnLoadYuanLingLevelInfoConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadYuanLingLevelInfoConfig_Object;
		public virtual RMethod ROnLoadYuanLingLevelInfoConfig_Object
		{
			get
			{
				if(r_ROnLoadYuanLingLevelInfoConfig_Object == null)
				{
					r_ROnLoadYuanLingLevelInfoConfig_Object = new(this, "OnLoadYuanLingLevelInfoConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadYuanLingLevelInfoConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadYuanLingLevelInfoConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetYuanLingLevelInfoValue(Int32, System.String)
		/// </summary>
		protected RMethod r_RGetYuanLingLevelInfoValue_Int32_String;
		public virtual RMethod RGetYuanLingLevelInfoValue_Int32_String
		{
			get
			{
				if(r_RGetYuanLingLevelInfoValue_Int32_String == null)
				{
					r_RGetYuanLingLevelInfoValue_Int32_String = new(this, "GetYuanLingLevelInfoValue", 0, typeof(System.Int32), typeof(System.String));
					r_RGetYuanLingLevelInfoValue_Int32_String.SetBelong(this.instance);
				}
				return r_RGetYuanLingLevelInfoValue_Int32_String;
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


        public RYuanLingManager() : base("YuanLingManager")
        {
        }

        public RYuanLingManager(System.Object instance) : base("YuanLingManager")
		{
            SetInstance(instance);
		}

        public RYuanLingManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RYuanLingManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Count_All_Add()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCount_All_Add.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetActiveID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetActiveID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual YuanLing GetNowYuanLingInfo(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetNowYuanLingInfo_Int32.Invoke(___genericsType, ___parameters);

            return (YuanLing)___result;
        }


        public virtual void SendYuanlingActive(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendYuanlingActive_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendYuanlingEatOne(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendYuanlingEatOne_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendYuanlingEatOneLevel(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendYuanlingEatOneLevel_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendYuanlingPutOn(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendYuanlingPutOn_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendYuanlingTakeOff(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RSendYuanlingTakeOff_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadYuanLingInfoConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadYuanLingInfoConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetYuanLingInfoValue(System.Int32  @id, System.String  @subKey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @subKey};
            var ___result = RGetYuanLingInfoValue_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 MaxYuanLingNum()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMaxYuanLingNum.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void OnLoadYuanLingLevelInfoConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadYuanLingLevelInfoConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetYuanLingLevelInfoValue(System.Int32  @id, System.String  @subKey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @subKey};
            var ___result = RGetYuanLingLevelInfoValue_Int32_String.Invoke(___genericsType, ___parameters);

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
