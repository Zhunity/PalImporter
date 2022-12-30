using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ValleyRaidManager
	/// </summary>
    public partial class RValleyRaidManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,ValleyRaidConfig] m_ValleyRaidDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RValleyRaidConfig> r_m_ValleyRaidDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RValleyRaidConfig> Rm_ValleyRaidDict
		{
			get
			{
				if(r_m_ValleyRaidDict == null)
				{
					r_m_ValleyRaidDict = new(this, "m_ValleyRaidDict");
					r_m_ValleyRaidDict.SetBelong(this.instance);
				}
				return r_m_ValleyRaidDict;
			}
		}

		/// <summary>
		/// System.Int32 m_nMaxPage
		/// </summary>
		protected RField r_m_nMaxPage;
		public virtual RField Rm_nMaxPage
		{
			get
			{
				if(r_m_nMaxPage == null)
				{
					r_m_nMaxPage = new(this, "m_nMaxPage");
					r_m_nMaxPage.SetBelong(this.instance);
				}
				return r_m_nMaxPage;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[ValleyReliveConfig] m_ReliveList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RValleyReliveConfig> r_m_ReliveList;
		public virtual RSystem.RCollections.RGeneric.RList<RValleyReliveConfig> Rm_ReliveList
		{
			get
			{
				if(r_m_ReliveList == null)
				{
					r_m_ReliveList = new(this, "m_ReliveList");
					r_m_ReliveList.SetBelong(this.instance);
				}
				return r_m_ReliveList;
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
		/// Int32 GetValleyRaidMaxpage()
		/// </summary>
		protected RMethod r_RGetValleyRaidMaxpage;
		public virtual RMethod RGetValleyRaidMaxpage
		{
			get
			{
				if(r_RGetValleyRaidMaxpage == null)
				{
					r_RGetValleyRaidMaxpage = new(this, "GetValleyRaidMaxpage", 0);
					r_RGetValleyRaidMaxpage.SetBelong(this.instance);
				}
				return r_RGetValleyRaidMaxpage;
			}
		}

		/// <summary>
		/// Void OnLoadValleyRaidConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadValleyRaidConfig_Object;
		public virtual RMethod ROnLoadValleyRaidConfig_Object
		{
			get
			{
				if(r_ROnLoadValleyRaidConfig_Object == null)
				{
					r_ROnLoadValleyRaidConfig_Object = new(this, "OnLoadValleyRaidConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadValleyRaidConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadValleyRaidConfig_Object;
			}
		}

		/// <summary>
		/// ValleyRaidConfig GetValleyRaidCfg(Int32)
		/// </summary>
		protected RMethod r_RGetValleyRaidCfg_Int32;
		public virtual RMethod RGetValleyRaidCfg_Int32
		{
			get
			{
				if(r_RGetValleyRaidCfg_Int32 == null)
				{
					r_RGetValleyRaidCfg_Int32 = new(this, "GetValleyRaidCfg", 0, typeof(System.Int32));
					r_RGetValleyRaidCfg_Int32.SetBelong(this.instance);
				}
				return r_RGetValleyRaidCfg_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,ValleyRaidConfig] GetRaidDict()
		/// </summary>
		protected RMethod r_RGetRaidDict;
		public virtual RMethod RGetRaidDict
		{
			get
			{
				if(r_RGetRaidDict == null)
				{
					r_RGetRaidDict = new(this, "GetRaidDict", 0);
					r_RGetRaidDict.SetBelong(this.instance);
				}
				return r_RGetRaidDict;
			}
		}

		/// <summary>
		/// Void OnLoadValleyReliveConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadValleyReliveConfig_Object;
		public virtual RMethod ROnLoadValleyReliveConfig_Object
		{
			get
			{
				if(r_ROnLoadValleyReliveConfig_Object == null)
				{
					r_ROnLoadValleyReliveConfig_Object = new(this, "OnLoadValleyReliveConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadValleyReliveConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadValleyReliveConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[ValleyReliveConfig] GetReliveList()
		/// </summary>
		protected RMethod r_RGetReliveList;
		public virtual RMethod RGetReliveList
		{
			get
			{
				if(r_RGetReliveList == null)
				{
					r_RGetReliveList = new(this, "GetReliveList", 0);
					r_RGetReliveList.SetBelong(this.instance);
				}
				return r_RGetReliveList;
			}
		}

		/// <summary>
		/// Void OnTeamSelect(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnTeamSelect_Object___0__Isb;
		public virtual RMethod ROnTeamSelect_Object___0__Isb
		{
			get
			{
				if(r_ROnTeamSelect_Object___0__Isb == null)
				{
					r_ROnTeamSelect_Object___0__Isb = new(this, "OnTeamSelect", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnTeamSelect_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnTeamSelect_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnValleyShow(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnValleyShow_Object___0__Isb;
		public virtual RMethod ROnValleyShow_Object___0__Isb
		{
			get
			{
				if(r_ROnValleyShow_Object___0__Isb == null)
				{
					r_ROnValleyShow_Object___0__Isb = new(this, "OnValleyShow", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnValleyShow_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnValleyShow_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnValleyInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnValleyInfo_Object___0__Isb;
		public virtual RMethod ROnValleyInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnValleyInfo_Object___0__Isb == null)
				{
					r_ROnValleyInfo_Object___0__Isb = new(this, "OnValleyInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnValleyInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnValleyInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnValleyCurrentInfo(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnValleyCurrentInfo_Object___0__Isb;
		public virtual RMethod ROnValleyCurrentInfo_Object___0__Isb
		{
			get
			{
				if(r_ROnValleyCurrentInfo_Object___0__Isb == null)
				{
					r_ROnValleyCurrentInfo_Object___0__Isb = new(this, "OnValleyCurrentInfo", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnValleyCurrentInfo_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnValleyCurrentInfo_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnValleyMyFormation(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnValleyMyFormation_Object___0__Isb;
		public virtual RMethod ROnValleyMyFormation_Object___0__Isb
		{
			get
			{
				if(r_ROnValleyMyFormation_Object___0__Isb == null)
				{
					r_ROnValleyMyFormation_Object___0__Isb = new(this, "OnValleyMyFormation", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnValleyMyFormation_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnValleyMyFormation_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnValleyRewardState(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnValleyRewardState_Object___0__Isb;
		public virtual RMethod ROnValleyRewardState_Object___0__Isb
		{
			get
			{
				if(r_ROnValleyRewardState_Object___0__Isb == null)
				{
					r_ROnValleyRewardState_Object___0__Isb = new(this, "OnValleyRewardState", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnValleyRewardState_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnValleyRewardState_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnValleyReliveHp(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnValleyReliveHp_Object___0__Isb;
		public virtual RMethod ROnValleyReliveHp_Object___0__Isb
		{
			get
			{
				if(r_ROnValleyReliveHp_Object___0__Isb == null)
				{
					r_ROnValleyReliveHp_Object___0__Isb = new(this, "OnValleyReliveHp", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnValleyReliveHp_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnValleyReliveHp_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendEnter()
		/// </summary>
		protected RMethod r_RSendEnter;
		public virtual RMethod RSendEnter
		{
			get
			{
				if(r_RSendEnter == null)
				{
					r_RSendEnter = new(this, "SendEnter", 0);
					r_RSendEnter.SetBelong(this.instance);
				}
				return r_RSendEnter;
			}
		}

		/// <summary>
		/// System.String GetEnemyIconUrl(Int32)
		/// </summary>
		protected RMethod r_RGetEnemyIconUrl_Int32;
		public virtual RMethod RGetEnemyIconUrl_Int32
		{
			get
			{
				if(r_RGetEnemyIconUrl_Int32 == null)
				{
					r_RGetEnemyIconUrl_Int32 = new(this, "GetEnemyIconUrl", 0, typeof(System.Int32));
					r_RGetEnemyIconUrl_Int32.SetBelong(this.instance);
				}
				return r_RGetEnemyIconUrl_Int32;
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


        public RValleyRaidManager() : base("ValleyRaidManager")
        {
        }

        public RValleyRaidManager(System.Object instance) : base("ValleyRaidManager")
		{
            SetInstance(instance);
		}

        public RValleyRaidManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RValleyRaidManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetValleyRaidMaxpage()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValleyRaidMaxpage.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void OnLoadValleyRaidConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadValleyRaidConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual ValleyRaidConfig GetValleyRaidCfg(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetValleyRaidCfg_Int32.Invoke(___genericsType, ___parameters);

            return (ValleyRaidConfig)___result;
        }


        public virtual System.Collections.Generic.Dictionary<System.Int32, ValleyRaidConfig> GetRaidDict()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRaidDict.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.Int32, ValleyRaidConfig>)___result;
        }


        public virtual void OnLoadValleyReliveConfig(UnityEngine.Object  @textasset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textasset};
            var ___result = ROnLoadValleyReliveConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<ValleyReliveConfig> GetReliveList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetReliveList.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<ValleyReliveConfig>)___result;
        }









        public virtual void SendEnter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendEnter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetEnemyIconUrl(System.Int32  @career)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@career};
            var ___result = RGetEnemyIconUrl_Int32.Invoke(___genericsType, ___parameters);

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
