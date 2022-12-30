using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// ActivityManager
	/// </summary>
    public partial class RActivityManager : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,ACTIVITY_INFO] m_ActivityDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RACTIVITY_INFO> r_m_ActivityDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RACTIVITY_INFO> Rm_ActivityDict
		{
			get
			{
				if(r_m_ActivityDict == null)
				{
					r_m_ActivityDict = new(this, "m_ActivityDict");
					r_m_ActivityDict.SetBelong(this.instance);
				}
				return r_m_ActivityDict;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[ACTIVITY_AWARD_INFO] m_ActivityAwardList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RACTIVITY_AWARD_INFO> r_m_ActivityAwardList;
		public virtual RSystem.RCollections.RGeneric.RList<RACTIVITY_AWARD_INFO> Rm_ActivityAwardList
		{
			get
			{
				if(r_m_ActivityAwardList == null)
				{
					r_m_ActivityAwardList = new(this, "m_ActivityAwardList");
					r_m_ActivityAwardList.SetBelong(this.instance);
				}
				return r_m_ActivityAwardList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,LOGIN_AD_INFO] m_LoginAdDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RLOGIN_AD_INFO> r_m_LoginAdDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RLOGIN_AD_INFO> Rm_LoginAdDict
		{
			get
			{
				if(r_m_LoginAdDict == null)
				{
					r_m_LoginAdDict = new(this, "m_LoginAdDict");
					r_m_LoginAdDict.SetBelong(this.instance);
				}
				return r_m_LoginAdDict;
			}
		}

		/// <summary>
		/// KeyValueContent ContentCampBuyBuff
		/// </summary>
		protected RKeyValueContent r_ContentCampBuyBuff;
		public virtual RKeyValueContent RContentCampBuyBuff
		{
			get
			{
				if(r_ContentCampBuyBuff == null)
				{
					r_ContentCampBuyBuff = new(this, "ContentCampBuyBuff");
					r_ContentCampBuyBuff.SetBelong(this.instance);
				}
				return r_ContentCampBuyBuff;
			}
		}

		/// <summary>
		/// Void OnLoadActivityConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadActivityConfig_Object;
		public virtual RMethod ROnLoadActivityConfig_Object
		{
			get
			{
				if(r_ROnLoadActivityConfig_Object == null)
				{
					r_ROnLoadActivityConfig_Object = new(this, "OnLoadActivityConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadActivityConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadActivityConfig_Object;
			}
		}

		/// <summary>
		/// ACTIVITY_INFO GetActivityInfo(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetActivityInfo_ID;
		public virtual RMethod RGetActivityInfo_ID
		{
			get
			{
				if(r_RGetActivityInfo_ID == null)
				{
					r_RGetActivityInfo_ID = new(this, "GetActivityInfo", 0, typeof(GameDefineType.ID));
					r_RGetActivityInfo_ID.SetBelong(this.instance);
				}
				return r_RGetActivityInfo_ID;
			}
		}

		/// <summary>
		/// Void OnLoadActivityAwardConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadActivityAwardConfig_Object;
		public virtual RMethod ROnLoadActivityAwardConfig_Object
		{
			get
			{
				if(r_ROnLoadActivityAwardConfig_Object == null)
				{
					r_ROnLoadActivityAwardConfig_Object = new(this, "OnLoadActivityAwardConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadActivityAwardConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadActivityAwardConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[ACTIVITY_AWARD_INFO] GetActivityAwardList()
		/// </summary>
		protected RMethod r_RGetActivityAwardList;
		public virtual RMethod RGetActivityAwardList
		{
			get
			{
				if(r_RGetActivityAwardList == null)
				{
					r_RGetActivityAwardList = new(this, "GetActivityAwardList", 0);
					r_RGetActivityAwardList.SetBelong(this.instance);
				}
				return r_RGetActivityAwardList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,ACTIVITY_INFO] GetActivityDict()
		/// </summary>
		protected RMethod r_RGetActivityDict;
		public virtual RMethod RGetActivityDict
		{
			get
			{
				if(r_RGetActivityDict == null)
				{
					r_RGetActivityDict = new(this, "GetActivityDict", 0);
					r_RGetActivityDict.SetBelong(this.instance);
				}
				return r_RGetActivityDict;
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
		/// Void OnActivityQuery(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnActivityQuery_Object___0__Isb;
		public virtual RMethod ROnActivityQuery_Object___0__Isb
		{
			get
			{
				if(r_ROnActivityQuery_Object___0__Isb == null)
				{
					r_ROnActivityQuery_Object___0__Isb = new(this, "OnActivityQuery", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnActivityQuery_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnActivityQuery_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnActivityPickReward(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnActivityPickReward_Object___0__Isb;
		public virtual RMethod ROnActivityPickReward_Object___0__Isb
		{
			get
			{
				if(r_ROnActivityPickReward_Object___0__Isb == null)
				{
					r_ROnActivityPickReward_Object___0__Isb = new(this, "OnActivityPickReward", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnActivityPickReward_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnActivityPickReward_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendQueryActivity()
		/// </summary>
		protected RMethod r_RSendQueryActivity;
		public virtual RMethod RSendQueryActivity
		{
			get
			{
				if(r_RSendQueryActivity == null)
				{
					r_RSendQueryActivity = new(this, "SendQueryActivity", 0);
					r_RSendQueryActivity.SetBelong(this.instance);
				}
				return r_RSendQueryActivity;
			}
		}

		/// <summary>
		/// Void SendPickReward(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RSendPickReward_ID;
		public virtual RMethod RSendPickReward_ID
		{
			get
			{
				if(r_RSendPickReward_ID == null)
				{
					r_RSendPickReward_ID = new(this, "SendPickReward", 0, typeof(GameDefineType.ID));
					r_RSendPickReward_ID.SetBelong(this.instance);
				}
				return r_RSendPickReward_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,LOGIN_AD_INFO] GetLoginAdDict()
		/// </summary>
		protected RMethod r_RGetLoginAdDict;
		public virtual RMethod RGetLoginAdDict
		{
			get
			{
				if(r_RGetLoginAdDict == null)
				{
					r_RGetLoginAdDict = new(this, "GetLoginAdDict", 0);
					r_RGetLoginAdDict.SetBelong(this.instance);
				}
				return r_RGetLoginAdDict;
			}
		}

		/// <summary>
		/// Void OnLoadLoginAdConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadLoginAdConfig_Object;
		public virtual RMethod ROnLoadLoginAdConfig_Object
		{
			get
			{
				if(r_ROnLoadLoginAdConfig_Object == null)
				{
					r_ROnLoadLoginAdConfig_Object = new(this, "OnLoadLoginAdConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadLoginAdConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadLoginAdConfig_Object;
			}
		}

		/// <summary>
		/// Void OnShowActivityIcon(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnShowActivityIcon_Object___0__Isb;
		public virtual RMethod ROnShowActivityIcon_Object___0__Isb
		{
			get
			{
				if(r_ROnShowActivityIcon_Object___0__Isb == null)
				{
					r_ROnShowActivityIcon_Object___0__Isb = new(this, "OnShowActivityIcon", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnShowActivityIcon_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnShowActivityIcon_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnLoadCampBuyBuffConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadCampBuyBuffConfig_Object;
		public virtual RMethod ROnLoadCampBuyBuffConfig_Object
		{
			get
			{
				if(r_ROnLoadCampBuyBuffConfig_Object == null)
				{
					r_ROnLoadCampBuyBuffConfig_Object = new(this, "OnLoadCampBuyBuffConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadCampBuyBuffConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadCampBuyBuffConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetCampBuyBuffInfo(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RGetCampBuyBuffInfo_ID_String;
		public virtual RMethod RGetCampBuyBuffInfo_ID_String
		{
			get
			{
				if(r_RGetCampBuyBuffInfo_ID_String == null)
				{
					r_RGetCampBuyBuffInfo_ID_String = new(this, "GetCampBuyBuffInfo", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_RGetCampBuyBuffInfo_ID_String.SetBelong(this.instance);
				}
				return r_RGetCampBuyBuffInfo_ID_String;
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


        public RActivityManager() : base("ActivityManager")
        {
        }

        public RActivityManager(System.Object instance) : base("ActivityManager")
		{
            SetInstance(instance);
		}

        public RActivityManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RActivityManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadActivityConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadActivityConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual ACTIVITY_INFO GetActivityInfo(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetActivityInfo_ID.Invoke(___genericsType, ___parameters);

            return (ACTIVITY_INFO)___result;
        }


        public virtual void OnLoadActivityAwardConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadActivityAwardConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<ACTIVITY_AWARD_INFO> GetActivityAwardList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetActivityAwardList.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<ACTIVITY_AWARD_INFO>)___result;
        }


        public virtual System.Collections.Generic.Dictionary<GameDefineType.ID, ACTIVITY_INFO> GetActivityDict()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetActivityDict.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<GameDefineType.ID, ACTIVITY_INFO>)___result;
        }


        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void SendQueryActivity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendQueryActivity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendPickReward(GameDefineType.ID  @iditem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iditem};
            var ___result = RSendPickReward_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.Dictionary<GameDefineType.ID, LOGIN_AD_INFO> GetLoginAdDict()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLoginAdDict.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<GameDefineType.ID, LOGIN_AD_INFO>)___result;
        }


        public virtual void OnLoadLoginAdConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadLoginAdConfig_Object.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void OnLoadCampBuyBuffConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadCampBuyBuffConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetCampBuyBuffInfo(GameDefineType.ID  @id, System.String  @key)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @key};
            var ___result = RGetCampBuyBuffInfo_ID_String.Invoke(___genericsType, ___parameters);

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
