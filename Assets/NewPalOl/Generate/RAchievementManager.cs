using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// AchievementManager
	/// </summary>
    public partial class RAchievementManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,AchievementRewardConfig] m_RewardDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RAchievementRewardConfig> r_m_RewardDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RAchievementRewardConfig> Rm_RewardDict
		{
			get
			{
				if(r_m_RewardDict == null)
				{
					r_m_RewardDict = new(this, "m_RewardDict");
					r_m_RewardDict.SetBelong(this.instance);
				}
				return r_m_RewardDict;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[AchievementConfig]] m_AchieveDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RAchievementConfig>> r_m_AchieveDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RAchievementConfig>> Rm_AchieveDict
		{
			get
			{
				if(r_m_AchieveDict == null)
				{
					r_m_AchieveDict = new(this, "m_AchieveDict");
					r_m_AchieveDict.SetBelong(this.instance);
				}
				return r_m_AchieveDict;
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
		/// Void OnLoadAchievementRewardConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadAchievementRewardConfig_Object;
		public virtual RMethod ROnLoadAchievementRewardConfig_Object
		{
			get
			{
				if(r_ROnLoadAchievementRewardConfig_Object == null)
				{
					r_ROnLoadAchievementRewardConfig_Object = new(this, "OnLoadAchievementRewardConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadAchievementRewardConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadAchievementRewardConfig_Object;
			}
		}

		/// <summary>
		/// AchievementRewardConfig GetReward(Int32)
		/// </summary>
		protected RMethod r_RGetReward_Int32;
		public virtual RMethod RGetReward_Int32
		{
			get
			{
				if(r_RGetReward_Int32 == null)
				{
					r_RGetReward_Int32 = new(this, "GetReward", 0, typeof(System.Int32));
					r_RGetReward_Int32.SetBelong(this.instance);
				}
				return r_RGetReward_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,AchievementRewardConfig] GetRewardDict()
		/// </summary>
		protected RMethod r_RGetRewardDict;
		public virtual RMethod RGetRewardDict
		{
			get
			{
				if(r_RGetRewardDict == null)
				{
					r_RGetRewardDict = new(this, "GetRewardDict", 0);
					r_RGetRewardDict.SetBelong(this.instance);
				}
				return r_RGetRewardDict;
			}
		}

		/// <summary>
		/// Void OnLoadAchievementConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadAchievementConfig_Object;
		public virtual RMethod ROnLoadAchievementConfig_Object
		{
			get
			{
				if(r_ROnLoadAchievementConfig_Object == null)
				{
					r_ROnLoadAchievementConfig_Object = new(this, "OnLoadAchievementConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadAchievementConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadAchievementConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[AchievementConfig]] GetAchievementDict()
		/// </summary>
		protected RMethod r_RGetAchievementDict;
		public virtual RMethod RGetAchievementDict
		{
			get
			{
				if(r_RGetAchievementDict == null)
				{
					r_RGetAchievementDict = new(this, "GetAchievementDict", 0);
					r_RGetAchievementDict.SetBelong(this.instance);
				}
				return r_RGetAchievementDict;
			}
		}

		/// <summary>
		/// AchievementConfig GetAchievenemtCfg(Int32)
		/// </summary>
		protected RMethod r_RGetAchievenemtCfg_Int32;
		public virtual RMethod RGetAchievenemtCfg_Int32
		{
			get
			{
				if(r_RGetAchievenemtCfg_Int32 == null)
				{
					r_RGetAchievenemtCfg_Int32 = new(this, "GetAchievenemtCfg", 0, typeof(System.Int32));
					r_RGetAchievenemtCfg_Int32.SetBelong(this.instance);
				}
				return r_RGetAchievenemtCfg_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[AchievementConfig] GetAchievement(System.String)
		/// </summary>
		protected RMethod r_RGetAchievement_String;
		public virtual RMethod RGetAchievement_String
		{
			get
			{
				if(r_RGetAchievement_String == null)
				{
					r_RGetAchievement_String = new(this, "GetAchievement", 0, typeof(System.String));
					r_RGetAchievement_String.SetBelong(this.instance);
				}
				return r_RGetAchievement_String;
			}
		}

		/// <summary>
		/// Void OnAchieveQuery(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnAchieveQuery_Object___0__Isb;
		public virtual RMethod ROnAchieveQuery_Object___0__Isb
		{
			get
			{
				if(r_ROnAchieveQuery_Object___0__Isb == null)
				{
					r_ROnAchieveQuery_Object___0__Isb = new(this, "OnAchieveQuery", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnAchieveQuery_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnAchieveQuery_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnAchieveInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnAchieveInfo_Object___0__Isb;
		public virtual RMethod ROnAchieveInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnAchieveInfo_Object___0__Isb == null)
				{
					r_ROnAchieveInfo_Object___0__Isb = new(this, "OnAchieveInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnAchieveInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnAchieveInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnAchieveServerInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnAchieveServerInfo_Object___0__Isb;
		public virtual RMethod ROnAchieveServerInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnAchieveServerInfo_Object___0__Isb == null)
				{
					r_ROnAchieveServerInfo_Object___0__Isb = new(this, "OnAchieveServerInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnAchieveServerInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnAchieveServerInfo_Object___0__Isb;
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


        public RAchievementManager() : base("AchievementManager")
        {
        }

        public RAchievementManager(System.Object instance) : base("AchievementManager")
		{
            SetInstance(instance);
		}

        public RAchievementManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAchievementManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadAchievementRewardConfig(UnityEngine.Object  @textasset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textasset};
            var ___result = ROnLoadAchievementRewardConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual AchievementRewardConfig GetReward(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetReward_Int32.Invoke(___genericsType, ___parameters);

            return (AchievementRewardConfig)___result;
        }


        public virtual System.Collections.Generic.Dictionary<System.Int32, AchievementRewardConfig> GetRewardDict()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRewardDict.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.Int32, AchievementRewardConfig>)___result;
        }


        public virtual void OnLoadAchievementConfig(UnityEngine.Object  @textasset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textasset};
            var ___result = ROnLoadAchievementConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<AchievementConfig>> GetAchievementDict()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetAchievementDict.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<AchievementConfig>>)___result;
        }


        public virtual AchievementConfig GetAchievenemtCfg(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetAchievenemtCfg_Int32.Invoke(___genericsType, ___parameters);

            return (AchievementConfig)___result;
        }


        public virtual System.Collections.Generic.List<AchievementConfig> GetAchievement(System.String  @category)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@category};
            var ___result = RGetAchievement_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<AchievementConfig>)___result;
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
