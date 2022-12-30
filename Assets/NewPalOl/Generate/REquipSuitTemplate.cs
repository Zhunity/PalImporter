using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// EquipSuitTemplate
	/// </summary>
    public partial class REquipSuitTemplate : RMember //
    {

		/// <summary>
		/// System.String DESCRIPTION_NAME
		/// </summary>
		protected static RField r_DESCRIPTION_NAME;
		public static RField RDESCRIPTION_NAME
		{
			get
			{
				if(r_DESCRIPTION_NAME == null)
				{
					r_DESCRIPTION_NAME = new( ReleactionUtils.GetType("EquipSuitTemplate"), "DESCRIPTION_NAME");
					r_DESCRIPTION_NAME.SetBelong(null);
				}
				return r_DESCRIPTION_NAME;
			}
		}

		/// <summary>
		/// System.String SUIT_ID_NAME
		/// </summary>
		protected static RField r_SUIT_ID_NAME;
		public static RField RSUIT_ID_NAME
		{
			get
			{
				if(r_SUIT_ID_NAME == null)
				{
					r_SUIT_ID_NAME = new( ReleactionUtils.GetType("EquipSuitTemplate"), "SUIT_ID_NAME");
					r_SUIT_ID_NAME.SetBelong(null);
				}
				return r_SUIT_ID_NAME;
			}
		}

		/// <summary>
		/// System.String MADESUIT_ID_NAME
		/// </summary>
		protected static RField r_MADESUIT_ID_NAME;
		public static RField RMADESUIT_ID_NAME
		{
			get
			{
				if(r_MADESUIT_ID_NAME == null)
				{
					r_MADESUIT_ID_NAME = new( ReleactionUtils.GetType("EquipSuitTemplate"), "MADESUIT_ID_NAME");
					r_MADESUIT_ID_NAME.SetBelong(null);
				}
				return r_MADESUIT_ID_NAME;
			}
		}

		/// <summary>
		/// System.String SET_NAME_NAME
		/// </summary>
		protected static RField r_SET_NAME_NAME;
		public static RField RSET_NAME_NAME
		{
			get
			{
				if(r_SET_NAME_NAME == null)
				{
					r_SET_NAME_NAME = new( ReleactionUtils.GetType("EquipSuitTemplate"), "SET_NAME_NAME");
					r_SET_NAME_NAME.SetBelong(null);
				}
				return r_SET_NAME_NAME;
			}
		}

		/// <summary>
		/// System.String SUIT_GROUP_NAME
		/// </summary>
		protected static RField r_SUIT_GROUP_NAME;
		public static RField RSUIT_GROUP_NAME
		{
			get
			{
				if(r_SUIT_GROUP_NAME == null)
				{
					r_SUIT_GROUP_NAME = new( ReleactionUtils.GetType("EquipSuitTemplate"), "SUIT_GROUP_NAME");
					r_SUIT_GROUP_NAME.SetBelong(null);
				}
				return r_SUIT_GROUP_NAME;
			}
		}

		/// <summary>
		/// System.String IS_PURPLE_NAME
		/// </summary>
		protected static RField r_IS_PURPLE_NAME;
		public static RField RIS_PURPLE_NAME
		{
			get
			{
				if(r_IS_PURPLE_NAME == null)
				{
					r_IS_PURPLE_NAME = new( ReleactionUtils.GetType("EquipSuitTemplate"), "IS_PURPLE_NAME");
					r_IS_PURPLE_NAME.SetBelong(null);
				}
				return r_IS_PURPLE_NAME;
			}
		}

		/// <summary>
		/// System.String SUIT_PART_NAME
		/// </summary>
		protected static RField r_SUIT_PART_NAME;
		public static RField RSUIT_PART_NAME
		{
			get
			{
				if(r_SUIT_PART_NAME == null)
				{
					r_SUIT_PART_NAME = new( ReleactionUtils.GetType("EquipSuitTemplate"), "SUIT_PART_NAME");
					r_SUIT_PART_NAME.SetBelong(null);
				}
				return r_SUIT_PART_NAME;
			}
		}

		/// <summary>
		/// System.Int32 minSuitPriority
		/// </summary>
		protected RField r_minSuitPriority;
		public virtual RField RminSuitPriority
		{
			get
			{
				if(r_minSuitPriority == null)
				{
					r_minSuitPriority = new(this, "minSuitPriority");
					r_minSuitPriority.SetBelong(this.instance);
				}
				return r_minSuitPriority;
			}
		}

		/// <summary>
		/// KeyValueContent equipSuitTemplate
		/// </summary>
		protected RKeyValueContent r_equipSuitTemplate;
		public virtual RKeyValueContent RequipSuitTemplate
		{
			get
			{
				if(r_equipSuitTemplate == null)
				{
					r_equipSuitTemplate = new(this, "equipSuitTemplate");
					r_equipSuitTemplate.SetBelong(this.instance);
				}
				return r_equipSuitTemplate;
			}
		}

		/// <summary>
		/// KeyValueContent mRareNameContent
		/// </summary>
		protected RKeyValueContent r_mRareNameContent;
		public virtual RKeyValueContent RmRareNameContent
		{
			get
			{
				if(r_mRareNameContent == null)
				{
					r_mRareNameContent = new(this, "mRareNameContent");
					r_mRareNameContent.SetBelong(this.instance);
				}
				return r_mRareNameContent;
			}
		}

		/// <summary>
		/// System.Int32[] m_SuitEffectNum
		/// </summary>
		protected static RFieldArray<RField> r_m_SuitEffectNum;
		public static RFieldArray<RField> Rm_SuitEffectNum
		{
			get
			{
				if(r_m_SuitEffectNum == null)
				{
					r_m_SuitEffectNum = new( ReleactionUtils.GetType("EquipSuitTemplate"), "m_SuitEffectNum");
					r_m_SuitEffectNum.SetBelong(null);
				}
				return r_m_SuitEffectNum;
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
		/// Void OnLoadEquipSuitTemplateConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadEquipSuitTemplateConfig_Object;
		public virtual RMethod ROnLoadEquipSuitTemplateConfig_Object
		{
			get
			{
				if(r_ROnLoadEquipSuitTemplateConfig_Object == null)
				{
					r_ROnLoadEquipSuitTemplateConfig_Object = new(this, "OnLoadEquipSuitTemplateConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadEquipSuitTemplateConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadEquipSuitTemplateConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadRareNameConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadRareNameConfig_Object;
		public virtual RMethod ROnLoadRareNameConfig_Object
		{
			get
			{
				if(r_ROnLoadRareNameConfig_Object == null)
				{
					r_ROnLoadRareNameConfig_Object = new(this, "OnLoadRareNameConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadRareNameConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRareNameConfig_Object;
			}
		}

		/// <summary>
		/// Void ParseEquipSuitPropTip(#u.#Dkb, System.Collections.Generic.List`1[#u.#5ib] ByRef)
		/// </summary>
		protected RMethod r_RParseEquipSuitPropTip___0__Dkb_Ref_List_d___0__5ib_p_;
		public virtual RMethod RParseEquipSuitPropTip___0__Dkb_Ref_List_d___0__5ib_p_
		{
			get
			{
				if(r_RParseEquipSuitPropTip___0__Dkb_Ref_List_d___0__5ib_p_ == null)
				{
					r_RParseEquipSuitPropTip___0__Dkb_Ref_List_d___0__5ib_p_ = new(this, "ParseEquipSuitPropTip", 0,  ReleactionUtils.GetType("#u.#Dkb"), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#u.#5ib")).MakeByRefType());
					r_RParseEquipSuitPropTip___0__Dkb_Ref_List_d___0__5ib_p_.SetBelong(this.instance);
				}
				return r_RParseEquipSuitPropTip___0__Dkb_Ref_List_d___0__5ib_p_;
			}
		}

		/// <summary>
		/// Boolean IsInEquipmentPlace(PLACE)
		/// </summary>
		protected RMethod r_RIsInEquipmentPlace_PLACE;
		public virtual RMethod RIsInEquipmentPlace_PLACE
		{
			get
			{
				if(r_RIsInEquipmentPlace_PLACE == null)
				{
					r_RIsInEquipmentPlace_PLACE = new(this, "IsInEquipmentPlace", 0,  ReleactionUtils.GetType("ItemType+PLACE"));
					r_RIsInEquipmentPlace_PLACE.SetBelong(this.instance);
				}
				return r_RIsInEquipmentPlace_PLACE;
			}
		}

		/// <summary>
		/// System.String GetSuitDescription(#u.#Dkb, System.Collections.Generic.Dictionary`2[System.String,#u.#Dkb], System.String, System.String)
		/// </summary>
		protected RMethod r_RGetSuitDescription___0__Dkb_Dictionary_d_String___0__Dkb_p__String_String;
		public virtual RMethod RGetSuitDescription___0__Dkb_Dictionary_d_String___0__Dkb_p__String_String
		{
			get
			{
				if(r_RGetSuitDescription___0__Dkb_Dictionary_d_String___0__Dkb_p__String_String == null)
				{
					r_RGetSuitDescription___0__Dkb_Dictionary_d_String___0__Dkb_p__String_String = new(this, "GetSuitDescription", 0,  ReleactionUtils.GetType("#u.#Dkb"), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReleactionUtils.GetType("#u.#Dkb")), typeof(System.String), typeof(System.String));
					r_RGetSuitDescription___0__Dkb_Dictionary_d_String___0__Dkb_p__String_String.SetBelong(this.instance);
				}
				return r_RGetSuitDescription___0__Dkb_Dictionary_d_String___0__Dkb_p__String_String;
			}
		}

		/// <summary>
		/// System.String GetEffectDescription(System.Collections.Generic.Dictionary`2[System.String,#u.#Dkb], System.String)
		/// </summary>
		protected RMethod r_RGetEffectDescription_Dictionary_d_String___0__Dkb_p__String;
		public virtual RMethod RGetEffectDescription_Dictionary_d_String___0__Dkb_p__String
		{
			get
			{
				if(r_RGetEffectDescription_Dictionary_d_String___0__Dkb_p__String == null)
				{
					r_RGetEffectDescription_Dictionary_d_String___0__Dkb_p__String = new(this, "GetEffectDescription", 0, typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.String),  ReleactionUtils.GetType("#u.#Dkb")), typeof(System.String));
					r_RGetEffectDescription_Dictionary_d_String___0__Dkb_p__String.SetBelong(this.instance);
				}
				return r_RGetEffectDescription_Dictionary_d_String___0__Dkb_p__String;
			}
		}

		/// <summary>
		/// System.String GetSuitPropertyValue(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RGetSuitPropertyValue_ID_String;
		public virtual RMethod RGetSuitPropertyValue_ID_String
		{
			get
			{
				if(r_RGetSuitPropertyValue_ID_String == null)
				{
					r_RGetSuitPropertyValue_ID_String = new(this, "GetSuitPropertyValue", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_RGetSuitPropertyValue_ID_String.SetBelong(this.instance);
				}
				return r_RGetSuitPropertyValue_ID_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Dkb] GetEquipmentList()
		/// </summary>
		protected RMethod r_RGetEquipmentList;
		public virtual RMethod RGetEquipmentList
		{
			get
			{
				if(r_RGetEquipmentList == null)
				{
					r_RGetEquipmentList = new(this, "GetEquipmentList", 0);
					r_RGetEquipmentList.SetBelong(this.instance);
				}
				return r_RGetEquipmentList;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,#u.#Dkb] GetEquipSuitList(System.String)
		/// </summary>
		protected RMethod r_RGetEquipSuitList_String;
		public virtual RMethod RGetEquipSuitList_String
		{
			get
			{
				if(r_RGetEquipSuitList_String == null)
				{
					r_RGetEquipSuitList_String = new(this, "GetEquipSuitList", 0, typeof(System.String));
					r_RGetEquipSuitList_String.SetBelong(this.instance);
				}
				return r_RGetEquipSuitList_String;
			}
		}

		/// <summary>
		/// Boolean IsPurpleSuit(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RIsPurpleSuit_ID;
		public virtual RMethod RIsPurpleSuit_ID
		{
			get
			{
				if(r_RIsPurpleSuit_ID == null)
				{
					r_RIsPurpleSuit_ID = new(this, "IsPurpleSuit", 0, typeof(GameDefineType.ID));
					r_RIsPurpleSuit_ID.SetBelong(this.instance);
				}
				return r_RIsPurpleSuit_ID;
			}
		}

		/// <summary>
		/// Boolean IsMadeSuit(#u.#Dkb)
		/// </summary>
		protected RMethod r_RIsMadeSuit___0__Dkb;
		public virtual RMethod RIsMadeSuit___0__Dkb
		{
			get
			{
				if(r_RIsMadeSuit___0__Dkb == null)
				{
					r_RIsMadeSuit___0__Dkb = new(this, "IsMadeSuit", 0,  ReleactionUtils.GetType("#u.#Dkb"));
					r_RIsMadeSuit___0__Dkb.SetBelong(this.instance);
				}
				return r_RIsMadeSuit___0__Dkb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetSuitGroupIDs(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetSuitGroupIDs_ID;
		public virtual RMethod RGetSuitGroupIDs_ID
		{
			get
			{
				if(r_RGetSuitGroupIDs_ID == null)
				{
					r_RGetSuitGroupIDs_ID = new(this, "GetSuitGroupIDs", 0, typeof(GameDefineType.ID));
					r_RGetSuitGroupIDs_ID.SetBelong(this.instance);
				}
				return r_RGetSuitGroupIDs_ID;
			}
		}

		/// <summary>
		/// System.String GetSuitPartName(#u.#Dkb, GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetSuitPartName___0__Dkb_ID_ID;
		public virtual RMethod RGetSuitPartName___0__Dkb_ID_ID
		{
			get
			{
				if(r_RGetSuitPartName___0__Dkb_ID_ID == null)
				{
					r_RGetSuitPartName___0__Dkb_ID_ID = new(this, "GetSuitPartName", 0,  ReleactionUtils.GetType("#u.#Dkb"), typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_RGetSuitPartName___0__Dkb_ID_ID.SetBelong(this.instance);
				}
				return r_RGetSuitPartName___0__Dkb_ID_ID;
			}
		}

		/// <summary>
		/// System.String GetEquipmentSuitPartID(#u.#Dkb)
		/// </summary>
		protected RMethod r_RGetEquipmentSuitPartID___0__Dkb;
		public virtual RMethod RGetEquipmentSuitPartID___0__Dkb
		{
			get
			{
				if(r_RGetEquipmentSuitPartID___0__Dkb == null)
				{
					r_RGetEquipmentSuitPartID___0__Dkb = new(this, "GetEquipmentSuitPartID", 0,  ReleactionUtils.GetType("#u.#Dkb"));
					r_RGetEquipmentSuitPartID___0__Dkb.SetBelong(this.instance);
				}
				return r_RGetEquipmentSuitPartID___0__Dkb;
			}
		}

		/// <summary>
		/// System.String GetRareName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetRareName_ID;
		public virtual RMethod RGetRareName_ID
		{
			get
			{
				if(r_RGetRareName_ID == null)
				{
					r_RGetRareName_ID = new(this, "GetRareName", 0, typeof(GameDefineType.ID));
					r_RGetRareName_ID.SetBelong(this.instance);
				}
				return r_RGetRareName_ID;
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


        public REquipSuitTemplate() : base("EquipSuitTemplate")
        {
        }

        public REquipSuitTemplate(System.Object instance) : base("EquipSuitTemplate")
		{
            SetInstance(instance);
		}

        public REquipSuitTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REquipSuitTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadEquipSuitTemplateConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadEquipSuitTemplateConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadRareNameConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadRareNameConfig_Object.Invoke(___genericsType, ___parameters);

            
        }






        public virtual System.String GetSuitPropertyValue(GameDefineType.ID  @suitID, System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@suitID, @propName};
            var ___result = RGetSuitPropertyValue_ID_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object GetEquipmentList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEquipmentList.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object GetEquipSuitList(System.String  @suitPrefixID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@suitPrefixID};
            var ___result = RGetEquipSuitList_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean IsPurpleSuit(GameDefineType.ID  @suitID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@suitID};
            var ___result = RIsPurpleSuit_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Collections.Generic.List<System.String> GetSuitGroupIDs(GameDefineType.ID  @suitID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@suitID};
            var ___result = RGetSuitGroupIDs_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }




        public virtual System.String GetRareName(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetRareName_ID.Invoke(___genericsType, ___parameters);

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
