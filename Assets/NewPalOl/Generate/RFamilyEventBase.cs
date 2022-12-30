using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FamilyEventBase
	/// </summary>
    public partial class RFamilyEventBase : RMember //
    {

		/// <summary>
		/// GameDefineType.ID eventId
		/// </summary>
		protected RGameDefineType.RID r_eventId;
		public virtual RGameDefineType.RID ReventId
		{
			get
			{
				if(r_eventId == null)
				{
					r_eventId = new(this, "eventId");
					r_eventId.SetBelong(this.instance);
				}
				return r_eventId;
			}
		}

		/// <summary>
		/// System.Boolean isActive
		/// </summary>
		protected RField r_isActive;
		public virtual RField RisActive
		{
			get
			{
				if(r_isActive == null)
				{
					r_isActive = new(this, "isActive");
					r_isActive.SetBelong(this.instance);
				}
				return r_isActive;
			}
		}

		/// <summary>
		/// System.String eventName
		/// </summary>
		protected RField r_eventName;
		public virtual RField ReventName
		{
			get
			{
				if(r_eventName == null)
				{
					r_eventName = new(this, "eventName");
					r_eventName.SetBelong(this.instance);
				}
				return r_eventName;
			}
		}

		/// <summary>
		/// System.String eventReward
		/// </summary>
		protected RField r_eventReward;
		public virtual RField ReventReward
		{
			get
			{
				if(r_eventReward == null)
				{
					r_eventReward = new(this, "eventReward");
					r_eventReward.SetBelong(this.instance);
				}
				return r_eventReward;
			}
		}

		/// <summary>
		/// FamilyEventBase+STATE eventState
		/// </summary>
		protected RField r_eventState;
		public virtual RField ReventState
		{
			get
			{
				if(r_eventState == null)
				{
					r_eventState = new(this, "eventState");
					r_eventState.SetBelong(this.instance);
				}
				return r_eventState;
			}
		}

		/// <summary>
		/// System.String adminName
		/// </summary>
		protected RField r_adminName;
		public virtual RField RadminName
		{
			get
			{
				if(r_adminName == null)
				{
					r_adminName = new(this, "adminName");
					r_adminName.SetBelong(this.instance);
				}
				return r_adminName;
			}
		}

		/// <summary>
		/// System.Int32 beginTime
		/// </summary>
		protected RField r_beginTime;
		public virtual RField RbeginTime
		{
			get
			{
				if(r_beginTime == null)
				{
					r_beginTime = new(this, "beginTime");
					r_beginTime.SetBelong(this.instance);
				}
				return r_beginTime;
			}
		}

		/// <summary>
		/// System.Int32 countDown
		/// </summary>
		protected RField r_countDown;
		public virtual RField RcountDown
		{
			get
			{
				if(r_countDown == null)
				{
					r_countDown = new(this, "countDown");
					r_countDown.SetBelong(this.instance);
				}
				return r_countDown;
			}
		}

		/// <summary>
		/// System.Boolean bCanBuy
		/// </summary>
		protected RField r_bCanBuy;
		public virtual RField RbCanBuy
		{
			get
			{
				if(r_bCanBuy == null)
				{
					r_bCanBuy = new(this, "bCanBuy");
					r_bCanBuy.SetBelong(this.instance);
				}
				return r_bCanBuy;
			}
		}

		/// <summary>
		/// System.String iconPath1
		/// </summary>
		protected RField r_iconPath1;
		public virtual RField RiconPath1
		{
			get
			{
				if(r_iconPath1 == null)
				{
					r_iconPath1 = new(this, "iconPath1");
					r_iconPath1.SetBelong(this.instance);
				}
				return r_iconPath1;
			}
		}

		/// <summary>
		/// System.String iconPath0
		/// </summary>
		protected RField r_iconPath0;
		public virtual RField RiconPath0
		{
			get
			{
				if(r_iconPath0 == null)
				{
					r_iconPath0 = new(this, "iconPath0");
					r_iconPath0.SetBelong(this.instance);
				}
				return r_iconPath0;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#Pfb.#H6c] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__H6c> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__H6c> R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(this, "#c");
					r___0__c.SetBelong(this.instance);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.String step1Name
		/// </summary>
		protected RProperty r_step1Name;
		public virtual RProperty Rstep1Name
		{
			get
			{
				if(r_step1Name == null)
				{
					r_step1Name = new(this, "step1Name", -1);
					r_step1Name.SetBelong(this.instance);
				}
				return r_step1Name;
			}
		}

		/// <summary>
		/// System.String step2Name
		/// </summary>
		protected RProperty r_step2Name;
		public virtual RProperty Rstep2Name
		{
			get
			{
				if(r_step2Name == null)
				{
					r_step2Name = new(this, "step2Name", -1);
					r_step2Name.SetBelong(this.instance);
				}
				return r_step2Name;
			}
		}

		/// <summary>
		/// Void #Abb()
		/// </summary>
		protected RMethod r_R__0__Abb;
		public virtual RMethod R__0__Abb
		{
			get
			{
				if(r_R__0__Abb == null)
				{
					r_R__0__Abb = new(this, "#Abb", 0);
					r_R__0__Abb.SetBelong(this.instance);
				}
				return r_R__0__Abb;
			}
		}

		/// <summary>
		/// Void #Bbb()
		/// </summary>
		protected RMethod r_R__0__Bbb;
		public virtual RMethod R__0__Bbb
		{
			get
			{
				if(r_R__0__Bbb == null)
				{
					r_R__0__Bbb = new(this, "#Bbb", 0);
					r_R__0__Bbb.SetBelong(this.instance);
				}
				return r_R__0__Bbb;
			}
		}

		/// <summary>
		/// Void #Cbb()
		/// </summary>
		protected RMethod r_R__0__Cbb;
		public virtual RMethod R__0__Cbb
		{
			get
			{
				if(r_R__0__Cbb == null)
				{
					r_R__0__Cbb = new(this, "#Cbb", 0);
					r_R__0__Cbb.SetBelong(this.instance);
				}
				return r_R__0__Cbb;
			}
		}

		/// <summary>
		/// Void #Dbb()
		/// </summary>
		protected RMethod r_R__0__Dbb;
		public virtual RMethod R__0__Dbb
		{
			get
			{
				if(r_R__0__Dbb == null)
				{
					r_R__0__Dbb = new(this, "#Dbb", 0);
					r_R__0__Dbb.SetBelong(this.instance);
				}
				return r_R__0__Dbb;
			}
		}

		/// <summary>
		/// Boolean #Ebb()
		/// </summary>
		protected RMethod r_R__0__Ebb;
		public virtual RMethod R__0__Ebb
		{
			get
			{
				if(r_R__0__Ebb == null)
				{
					r_R__0__Ebb = new(this, "#Ebb", 0);
					r_R__0__Ebb.SetBelong(this.instance);
				}
				return r_R__0__Ebb;
			}
		}

		/// <summary>
		/// System.String #Hbb()
		/// </summary>
		protected RMethod r_R__0__Hbb;
		public virtual RMethod R__0__Hbb
		{
			get
			{
				if(r_R__0__Hbb == null)
				{
					r_R__0__Hbb = new(this, "#Hbb", 0);
					r_R__0__Hbb.SetBelong(this.instance);
				}
				return r_R__0__Hbb;
			}
		}

		/// <summary>
		/// Int32 ReallyToServerTime(Int32)
		/// </summary>
		protected static RMethod r_RReallyToServerTime_Int32;
		public static RMethod RReallyToServerTime_Int32
		{
			get
			{
				if(r_RReallyToServerTime_Int32 == null)
				{
					r_RReallyToServerTime_Int32 = new(typeof(FamilyEventBase), "ReallyToServerTime", 0, typeof(System.Int32));
					r_RReallyToServerTime_Int32.SetBelong(null);
				}
				return r_RReallyToServerTime_Int32;
			}
		}

		/// <summary>
		/// Int32 ServerToReallyTime(Int32)
		/// </summary>
		protected static RMethod r_RServerToReallyTime_Int32;
		public static RMethod RServerToReallyTime_Int32
		{
			get
			{
				if(r_RServerToReallyTime_Int32 == null)
				{
					r_RServerToReallyTime_Int32 = new(typeof(FamilyEventBase), "ServerToReallyTime", 0, typeof(System.Int32));
					r_RServerToReallyTime_Int32.SetBelong(null);
				}
				return r_RServerToReallyTime_Int32;
			}
		}

		/// <summary>
		/// FamilyEventBase Create(FamilyEventConfig)
		/// </summary>
		protected static RMethod r_RCreate_FamilyEventConfig;
		public static RMethod RCreate_FamilyEventConfig
		{
			get
			{
				if(r_RCreate_FamilyEventConfig == null)
				{
					r_RCreate_FamilyEventConfig = new(typeof(FamilyEventBase), "Create", 0, typeof(FamilyEventConfig));
					r_RCreate_FamilyEventConfig.SetBelong(null);
				}
				return r_RCreate_FamilyEventConfig;
			}
		}

		/// <summary>
		/// System.Type GetEventType(GameDefineType.ID)
		/// </summary>
		protected static RMethod r_RGetEventType_ID;
		public static RMethod RGetEventType_ID
		{
			get
			{
				if(r_RGetEventType_ID == null)
				{
					r_RGetEventType_ID = new(typeof(FamilyEventBase), "GetEventType", 0, typeof(GameDefineType.ID));
					r_RGetEventType_ID.SetBelong(null);
				}
				return r_RGetEventType_ID;
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


        public RFamilyEventBase() : base("FamilyEventBase")
        {
        }

        public RFamilyEventBase(System.Object instance) : base("FamilyEventBase")
		{
            SetInstance(instance);
		}

        public RFamilyEventBase(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFamilyEventBase(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__Abb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Abb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Bbb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Bbb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Cbb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Cbb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Dbb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Dbb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__Ebb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Ebb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String __0__Hbb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Hbb.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static System.Int32 ReallyToServerTime(System.Int32  @rTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rTime};
            var ___result = RReallyToServerTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Int32 ServerToReallyTime(System.Int32  @sTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sTime};
            var ___result = RServerToReallyTime_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static FamilyEventBase Create(FamilyEventConfig  @config)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@config};
            var ___result = RCreate_FamilyEventConfig.Invoke(___genericsType, ___parameters);

            return (FamilyEventBase)___result;
        }


        public static System.Type GetEventType(GameDefineType.ID  @eventId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eventId};
            var ___result = RGetEventType_ID.Invoke(___genericsType, ___parameters);

            return (System.Type)___result;
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
