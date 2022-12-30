using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FishingManager
	/// </summary>
    public partial class RFishingManager : RMember //
    {

		/// <summary>
		/// System.Int32 FISHING_ROD_ID
		/// </summary>
		protected static RField r_FISHING_ROD_ID;
		public static RField RFISHING_ROD_ID
		{
			get
			{
				if(r_FISHING_ROD_ID == null)
				{
					r_FISHING_ROD_ID = new( ReleactionUtils.GetType("FishingManager"), "FISHING_ROD_ID");
					r_FISHING_ROD_ID.SetBelong(null);
				}
				return r_FISHING_ROD_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,NPC] m_FishPointDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RNPC> r_m_FishPointDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RNPC> Rm_FishPointDict
		{
			get
			{
				if(r_m_FishPointDict == null)
				{
					r_m_FishPointDict = new(this, "m_FishPointDict");
					r_m_FishPointDict.SetBelong(this.instance);
				}
				return r_m_FishPointDict;
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
		/// Void OnFishingQueryItems(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnFishingQueryItems_Object___0__Isb;
		public virtual RMethod ROnFishingQueryItems_Object___0__Isb
		{
			get
			{
				if(r_ROnFishingQueryItems_Object___0__Isb == null)
				{
					r_ROnFishingQueryItems_Object___0__Isb = new(this, "OnFishingQueryItems", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnFishingQueryItems_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnFishingQueryItems_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnFishingItem(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_ROnFishingItem_Object___0__Isb;
		public virtual RMethod ROnFishingItem_Object___0__Isb
		{
			get
			{
				if(r_ROnFishingItem_Object___0__Isb == null)
				{
					r_ROnFishingItem_Object___0__Isb = new(this, "OnFishingItem", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_ROnFishingItem_Object___0__Isb.SetBelong(this.instance);
				}
				return r_ROnFishingItem_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void SendDoFish(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RSendDoFish_Int32_Int32_Int32;
		public virtual RMethod RSendDoFish_Int32_Int32_Int32
		{
			get
			{
				if(r_RSendDoFish_Int32_Int32_Int32 == null)
				{
					r_RSendDoFish_Int32_Int32_Int32 = new(this, "SendDoFish", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RSendDoFish_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSendDoFish_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SendPickItem(Int32, Int32)
		/// </summary>
		protected RMethod r_RSendPickItem_Int32_Int32;
		public virtual RMethod RSendPickItem_Int32_Int32
		{
			get
			{
				if(r_RSendPickItem_Int32_Int32 == null)
				{
					r_RSendPickItem_Int32_Int32 = new(this, "SendPickItem", 0, typeof(System.Int32), typeof(System.Int32));
					r_RSendPickItem_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSendPickItem_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SendQueryItems()
		/// </summary>
		protected RMethod r_RSendQueryItems;
		public virtual RMethod RSendQueryItems
		{
			get
			{
				if(r_RSendQueryItems == null)
				{
					r_RSendQueryItems = new(this, "SendQueryItems", 0);
					r_RSendQueryItems.SetBelong(this.instance);
				}
				return r_RSendQueryItems;
			}
		}

		/// <summary>
		/// Void ClearFishingPoints()
		/// </summary>
		protected RMethod r_RClearFishingPoints;
		public virtual RMethod RClearFishingPoints
		{
			get
			{
				if(r_RClearFishingPoints == null)
				{
					r_RClearFishingPoints = new(this, "ClearFishingPoints", 0);
					r_RClearFishingPoints.SetBelong(this.instance);
				}
				return r_RClearFishingPoints;
			}
		}

		/// <summary>
		/// Void AddFishingPoint(NPC)
		/// </summary>
		protected RMethod r_RAddFishingPoint_NPC;
		public virtual RMethod RAddFishingPoint_NPC
		{
			get
			{
				if(r_RAddFishingPoint_NPC == null)
				{
					r_RAddFishingPoint_NPC = new(this, "AddFishingPoint", 0,  ReleactionUtils.GetType("NPC"));
					r_RAddFishingPoint_NPC.SetBelong(this.instance);
				}
				return r_RAddFishingPoint_NPC;
			}
		}

		/// <summary>
		/// Boolean CheckFishingRodEquiping()
		/// </summary>
		protected RMethod r_RCheckFishingRodEquiping;
		public virtual RMethod RCheckFishingRodEquiping
		{
			get
			{
				if(r_RCheckFishingRodEquiping == null)
				{
					r_RCheckFishingRodEquiping = new(this, "CheckFishingRodEquiping", 0);
					r_RCheckFishingRodEquiping.SetBelong(this.instance);
				}
				return r_RCheckFishingRodEquiping;
			}
		}

		/// <summary>
		/// Void CheckFishingPoints()
		/// </summary>
		protected RMethod r_RCheckFishingPoints;
		public virtual RMethod RCheckFishingPoints
		{
			get
			{
				if(r_RCheckFishingPoints == null)
				{
					r_RCheckFishingPoints = new(this, "CheckFishingPoints", 0);
					r_RCheckFishingPoints.SetBelong(this.instance);
				}
				return r_RCheckFishingPoints;
			}
		}

		/// <summary>
		/// FISHING_STATE GetMyFishingState()
		/// </summary>
		protected RMethod r_RGetMyFishingState;
		public virtual RMethod RGetMyFishingState
		{
			get
			{
				if(r_RGetMyFishingState == null)
				{
					r_RGetMyFishingState = new(this, "GetMyFishingState", 0);
					r_RGetMyFishingState.SetBelong(this.instance);
				}
				return r_RGetMyFishingState;
			}
		}

		/// <summary>
		/// FISHING_STATE GetFishingState(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetFishingState_ID;
		public virtual RMethod RGetFishingState_ID
		{
			get
			{
				if(r_RGetFishingState_ID == null)
				{
					r_RGetFishingState_ID = new(this, "GetFishingState", 0, typeof(GameDefineType.ID));
					r_RGetFishingState_ID.SetBelong(this.instance);
				}
				return r_RGetFishingState_ID;
			}
		}

		/// <summary>
		/// Void ChangeFishingState(Int32, Int32)
		/// </summary>
		protected RMethod r_RChangeFishingState_Int32_Int32;
		public virtual RMethod RChangeFishingState_Int32_Int32
		{
			get
			{
				if(r_RChangeFishingState_Int32_Int32 == null)
				{
					r_RChangeFishingState_Int32_Int32 = new(this, "ChangeFishingState", 0, typeof(System.Int32), typeof(System.Int32));
					r_RChangeFishingState_Int32_Int32.SetBelong(this.instance);
				}
				return r_RChangeFishingState_Int32_Int32;
			}
		}

		/// <summary>
		/// Void GotoFishPoint()
		/// </summary>
		protected RMethod r_RGotoFishPoint;
		public virtual RMethod RGotoFishPoint
		{
			get
			{
				if(r_RGotoFishPoint == null)
				{
					r_RGotoFishPoint = new(this, "GotoFishPoint", 0);
					r_RGotoFishPoint.SetBelong(this.instance);
				}
				return r_RGotoFishPoint;
			}
		}

		/// <summary>
		/// Boolean CheckIsFarAwayFishingPoint()
		/// </summary>
		protected RMethod r_RCheckIsFarAwayFishingPoint;
		public virtual RMethod RCheckIsFarAwayFishingPoint
		{
			get
			{
				if(r_RCheckIsFarAwayFishingPoint == null)
				{
					r_RCheckIsFarAwayFishingPoint = new(this, "CheckIsFarAwayFishingPoint", 0);
					r_RCheckIsFarAwayFishingPoint.SetBelong(this.instance);
				}
				return r_RCheckIsFarAwayFishingPoint;
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


        public RFishingManager() : base("FishingManager")
        {
        }

        public RFishingManager(System.Object instance) : base("FishingManager")
		{
            SetInstance(instance);
		}

        public RFishingManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFishingManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void SendDoFish(System.Int32  @value, System.Int32  @baitType, System.Int32  @fishingType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @baitType, @fishingType};
            var ___result = RSendDoFish_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendPickItem(System.Int32  @value, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @type};
            var ___result = RSendPickItem_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendQueryItems()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSendQueryItems.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ClearFishingPoints()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClearFishingPoints.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean CheckFishingRodEquiping()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckFishingRodEquiping.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CheckFishingPoints()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckFishingPoints.Invoke(___genericsType, ___parameters);

            
        }


        public virtual FISHING_STATE GetMyFishingState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetMyFishingState.Invoke(___genericsType, ___parameters);

            return (FISHING_STATE)___result;
        }


        public virtual FISHING_STATE GetFishingState(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetFishingState_ID.Invoke(___genericsType, ___parameters);

            return (FISHING_STATE)___result;
        }


        public virtual void ChangeFishingState(System.Int32  @oldval, System.Int32  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = RChangeFishingState_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GotoFishPoint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGotoFishPoint.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean CheckIsFarAwayFishingPoint()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckIsFarAwayFishingPoint.Invoke(___genericsType, ___parameters);

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
