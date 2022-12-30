using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// RankManager
	/// </summary>
    public partial class RRankManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,RANK_INFO] m_RankInfoDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RRANK_INFO> r_m_RankInfoDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RRANK_INFO> Rm_RankInfoDict
		{
			get
			{
				if(r_m_RankInfoDict == null)
				{
					r_m_RankInfoDict = new(this, "m_RankInfoDict");
					r_m_RankInfoDict.SetBelong(this.instance);
				}
				return r_m_RankInfoDict;
			}
		}

		/// <summary>
		/// KeyValueContent m_RankAwardConfig
		/// </summary>
		protected RKeyValueContent r_m_RankAwardConfig;
		public virtual RKeyValueContent Rm_RankAwardConfig
		{
			get
			{
				if(r_m_RankAwardConfig == null)
				{
					r_m_RankAwardConfig = new(this, "m_RankAwardConfig");
					r_m_RankAwardConfig.SetBelong(this.instance);
				}
				return r_m_RankAwardConfig;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] <>f__switch$map30
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___2____4__f__switch__9__map30;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__2____4__f__switch__9__map30
		{
			get
			{
				if(r___2____4__f__switch__9__map30 == null)
				{
					r___2____4__f__switch__9__map30 = new( ReleactionUtils.GetType("RankManager"), "<>f__switch$map30");
					r___2____4__f__switch__9__map30.SetBelong(null);
				}
				return r___2____4__f__switch__9__map30;
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
		/// Void OnLoadRankConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadRankConfig_Object;
		public virtual RMethod ROnLoadRankConfig_Object
		{
			get
			{
				if(r_ROnLoadRankConfig_Object == null)
				{
					r_ROnLoadRankConfig_Object = new(this, "OnLoadRankConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadRankConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRankConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadRankAwardConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadRankAwardConfig_Object;
		public virtual RMethod ROnLoadRankAwardConfig_Object
		{
			get
			{
				if(r_ROnLoadRankAwardConfig_Object == null)
				{
					r_ROnLoadRankAwardConfig_Object = new(this, "OnLoadRankAwardConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadRankAwardConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRankAwardConfig_Object;
			}
		}

		/// <summary>
		/// Int32 GetRankAwardValue(Int32, System.String)
		/// </summary>
		protected RMethod r_RGetRankAwardValue_Int32_String;
		public virtual RMethod RGetRankAwardValue_Int32_String
		{
			get
			{
				if(r_RGetRankAwardValue_Int32_String == null)
				{
					r_RGetRankAwardValue_Int32_String = new(this, "GetRankAwardValue", 0, typeof(System.Int32), typeof(System.String));
					r_RGetRankAwardValue_Int32_String.SetBelong(this.instance);
				}
				return r_RGetRankAwardValue_Int32_String;
			}
		}

		/// <summary>
		/// System.String GetRankAwardStr(Int32, System.String)
		/// </summary>
		protected RMethod r_RGetRankAwardStr_Int32_String;
		public virtual RMethod RGetRankAwardStr_Int32_String
		{
			get
			{
				if(r_RGetRankAwardStr_Int32_String == null)
				{
					r_RGetRankAwardStr_Int32_String = new(this, "GetRankAwardStr", 0, typeof(System.Int32), typeof(System.String));
					r_RGetRankAwardStr_Int32_String.SetBelong(this.instance);
				}
				return r_RGetRankAwardStr_Int32_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,RANK_INFO] GetRankDict()
		/// </summary>
		protected RMethod r_RGetRankDict;
		public virtual RMethod RGetRankDict
		{
			get
			{
				if(r_RGetRankDict == null)
				{
					r_RGetRankDict = new(this, "GetRankDict", 0);
					r_RGetRankDict.SetBelong(this.instance);
				}
				return r_RGetRankDict;
			}
		}

		/// <summary>
		/// Void OnRankInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnRankInfo_Object___0__Isb;
		public virtual RMethod ROnRankInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnRankInfo_Object___0__Isb == null)
				{
					r_ROnRankInfo_Object___0__Isb = new(this, "OnRankInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnRankInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnRankInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void RequestRankInfo(System.String)
		/// </summary>
		protected RMethod r_RRequestRankInfo_String;
		public virtual RMethod RRequestRankInfo_String
		{
			get
			{
				if(r_RRequestRankInfo_String == null)
				{
					r_RRequestRankInfo_String = new(this, "RequestRankInfo", 0, typeof(System.String));
					r_RRequestRankInfo_String.SetBelong(this.instance);
				}
				return r_RRequestRankInfo_String;
			}
		}

		/// <summary>
		/// Void RequestFlowerRank(Int32)
		/// </summary>
		protected RMethod r_RRequestFlowerRank_Int32;
		public virtual RMethod RRequestFlowerRank_Int32
		{
			get
			{
				if(r_RRequestFlowerRank_Int32 == null)
				{
					r_RRequestFlowerRank_Int32 = new(this, "RequestFlowerRank", 0, typeof(System.Int32));
					r_RRequestFlowerRank_Int32.SetBelong(this.instance);
				}
				return r_RRequestFlowerRank_Int32;
			}
		}

		/// <summary>
		/// Void RequestGetHeroAward()
		/// </summary>
		protected RMethod r_RRequestGetHeroAward;
		public virtual RMethod RRequestGetHeroAward
		{
			get
			{
				if(r_RRequestGetHeroAward == null)
				{
					r_RRequestGetHeroAward = new(this, "RequestGetHeroAward", 0);
					r_RRequestGetHeroAward.SetBelong(this.instance);
				}
				return r_RRequestGetHeroAward;
			}
		}

		/// <summary>
		/// Void RequestGetFlowerAward()
		/// </summary>
		protected RMethod r_RRequestGetFlowerAward;
		public virtual RMethod RRequestGetFlowerAward
		{
			get
			{
				if(r_RRequestGetFlowerAward == null)
				{
					r_RRequestGetFlowerAward = new(this, "RequestGetFlowerAward", 0);
					r_RRequestGetFlowerAward.SetBelong(this.instance);
				}
				return r_RRequestGetFlowerAward;
			}
		}

		/// <summary>
		/// Void RequestGetDanAward()
		/// </summary>
		protected RMethod r_RRequestGetDanAward;
		public virtual RMethod RRequestGetDanAward
		{
			get
			{
				if(r_RRequestGetDanAward == null)
				{
					r_RRequestGetDanAward = new(this, "RequestGetDanAward", 0);
					r_RRequestGetDanAward.SetBelong(this.instance);
				}
				return r_RRequestGetDanAward;
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


        public RRankManager() : base("RankManager")
        {
        }

        public RRankManager(System.Object instance) : base("RankManager")
		{
            SetInstance(instance);
		}

        public RRankManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RRankManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadRankConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadRankConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadRankAwardConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadRankAwardConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetRankAwardValue(System.Int32  @level, System.String  @propname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level, @propname};
            var ___result = RGetRankAwardValue_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetRankAwardStr(System.Int32  @level, System.String  @propname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level, @propname};
            var ___result = RGetRankAwardStr_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.Dictionary<System.String, RANK_INFO> GetRankDict()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRankDict.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.String, RANK_INFO>)___result;
        }



        public virtual void RequestRankInfo(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RRequestRankInfo_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestFlowerRank(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RRequestFlowerRank_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestGetHeroAward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRequestGetHeroAward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestGetFlowerAward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRequestGetFlowerAward.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RequestGetDanAward()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRequestGetDanAward.Invoke(___genericsType, ___parameters);

            
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
