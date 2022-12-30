using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// BFGSkillPropTemplate
	/// </summary>
    public partial class RBFGSkillPropTemplate : RMember //
    {

		/// <summary>
		/// System.Int32 minFSkillPriority
		/// </summary>
		protected RField r_minFSkillPriority;
		public virtual RField RminFSkillPriority
		{
			get
			{
				if(r_minFSkillPriority == null)
				{
					r_minFSkillPriority = new(this, "minFSkillPriority");
					r_minFSkillPriority.SetBelong(this.instance);
				}
				return r_minFSkillPriority;
			}
		}

		/// <summary>
		/// System.Int32 maxFSkillPriority
		/// </summary>
		protected RField r_maxFSkillPriority;
		public virtual RField RmaxFSkillPriority
		{
			get
			{
				if(r_maxFSkillPriority == null)
				{
					r_maxFSkillPriority = new(this, "maxFSkillPriority");
					r_maxFSkillPriority.SetBelong(this.instance);
				}
				return r_maxFSkillPriority;
			}
		}

		/// <summary>
		/// System.Int32 minBSkillPriority
		/// </summary>
		protected RField r_minBSkillPriority;
		public virtual RField RminBSkillPriority
		{
			get
			{
				if(r_minBSkillPriority == null)
				{
					r_minBSkillPriority = new(this, "minBSkillPriority");
					r_minBSkillPriority.SetBelong(this.instance);
				}
				return r_minBSkillPriority;
			}
		}

		/// <summary>
		/// System.Int32 maxBSkillPriority
		/// </summary>
		protected RField r_maxBSkillPriority;
		public virtual RField RmaxBSkillPriority
		{
			get
			{
				if(r_maxBSkillPriority == null)
				{
					r_maxBSkillPriority = new(this, "maxBSkillPriority");
					r_maxBSkillPriority.SetBelong(this.instance);
				}
				return r_maxBSkillPriority;
			}
		}

		/// <summary>
		/// System.Int32 minHolePriority
		/// </summary>
		protected RField r_minHolePriority;
		public virtual RField RminHolePriority
		{
			get
			{
				if(r_minHolePriority == null)
				{
					r_minHolePriority = new(this, "minHolePriority");
					r_minHolePriority.SetBelong(this.instance);
				}
				return r_minHolePriority;
			}
		}

		/// <summary>
		/// System.Int32 maxHolePriority
		/// </summary>
		protected RField r_maxHolePriority;
		public virtual RField RmaxHolePriority
		{
			get
			{
				if(r_maxHolePriority == null)
				{
					r_maxHolePriority = new(this, "maxHolePriority");
					r_maxHolePriority.SetBelong(this.instance);
				}
				return r_maxHolePriority;
			}
		}

		/// <summary>
		/// System.Int32 runeWordPriority
		/// </summary>
		protected RField r_runeWordPriority;
		public virtual RField RruneWordPriority
		{
			get
			{
				if(r_runeWordPriority == null)
				{
					r_runeWordPriority = new(this, "runeWordPriority");
					r_runeWordPriority.SetBelong(this.instance);
				}
				return r_runeWordPriority;
			}
		}

		/// <summary>
		/// System.Int32 minGSkillPriority
		/// </summary>
		protected RField r_minGSkillPriority;
		public virtual RField RminGSkillPriority
		{
			get
			{
				if(r_minGSkillPriority == null)
				{
					r_minGSkillPriority = new(this, "minGSkillPriority");
					r_minGSkillPriority.SetBelong(this.instance);
				}
				return r_minGSkillPriority;
			}
		}

		/// <summary>
		/// System.Int32 maxGSkillPriority
		/// </summary>
		protected RField r_maxGSkillPriority;
		public virtual RField RmaxGSkillPriority
		{
			get
			{
				if(r_maxGSkillPriority == null)
				{
					r_maxGSkillPriority = new(this, "maxGSkillPriority");
					r_maxGSkillPriority.SetBelong(this.instance);
				}
				return r_maxGSkillPriority;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[BFGSkillPropTemplate+SKILL_FILE_TYPE,System.String] SkillPrefix
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r_SkillPrefix;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> RSkillPrefix
		{
			get
			{
				if(r_SkillPrefix == null)
				{
					r_SkillPrefix = new(this, "SkillPrefix");
					r_SkillPrefix.SetBelong(this.instance);
				}
				return r_SkillPrefix;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[BFGSkillPropTemplate+SKILL_FILE_TYPE,KeyValueContent] SkillDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RKeyValueContent> r_SkillDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RKeyValueContent> RSkillDict
		{
			get
			{
				if(r_SkillDict == null)
				{
					r_SkillDict = new(this, "SkillDict");
					r_SkillDict.SetBelong(this.instance);
				}
				return r_SkillDict;
			}
		}

		/// <summary>
		/// System.Int32 fskillPropCount
		/// </summary>
		protected RField r_fskillPropCount;
		public virtual RField RfskillPropCount
		{
			get
			{
				if(r_fskillPropCount == null)
				{
					r_fskillPropCount = new(this, "fskillPropCount");
					r_fskillPropCount.SetBelong(this.instance);
				}
				return r_fskillPropCount;
			}
		}

		/// <summary>
		/// System.Int32 bskillPropCount
		/// </summary>
		protected RField r_bskillPropCount;
		public virtual RField RbskillPropCount
		{
			get
			{
				if(r_bskillPropCount == null)
				{
					r_bskillPropCount = new(this, "bskillPropCount");
					r_bskillPropCount.SetBelong(this.instance);
				}
				return r_bskillPropCount;
			}
		}

		/// <summary>
		/// System.Int32 gskillPropCount
		/// </summary>
		protected RField r_gskillPropCount;
		public virtual RField RgskillPropCount
		{
			get
			{
				if(r_gskillPropCount == null)
				{
					r_gskillPropCount = new(this, "gskillPropCount");
					r_gskillPropCount.SetBelong(this.instance);
				}
				return r_gskillPropCount;
			}
		}

		/// <summary>
		/// System.Int32 holePropCount
		/// </summary>
		protected RField r_holePropCount;
		public virtual RField RholePropCount
		{
			get
			{
				if(r_holePropCount == null)
				{
					r_holePropCount = new(this, "holePropCount");
					r_holePropCount.SetBelong(this.instance);
				}
				return r_holePropCount;
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
		/// Void OnLoadSkillConfig(UnityEngine.Object[])
		/// </summary>
		protected RMethod r_ROnLoadSkillConfig_ObjectArray;
		public virtual RMethod ROnLoadSkillConfig_ObjectArray
		{
			get
			{
				if(r_ROnLoadSkillConfig_ObjectArray == null)
				{
					r_ROnLoadSkillConfig_ObjectArray = new(this, "OnLoadSkillConfig", 0, typeof(UnityEngine.Object).MakeArrayType());
					r_ROnLoadSkillConfig_ObjectArray.SetBelong(this.instance);
				}
				return r_ROnLoadSkillConfig_ObjectArray;
			}
		}

		/// <summary>
		/// System.String ParseNamePropTip(#u.#Dkb, System.String)
		/// </summary>
		protected RMethod r_RParseNamePropTip___0__Dkb_String;
		public virtual RMethod RParseNamePropTip___0__Dkb_String
		{
			get
			{
				if(r_RParseNamePropTip___0__Dkb_String == null)
				{
					r_RParseNamePropTip___0__Dkb_String = new(this, "ParseNamePropTip", 0,  ReleactionUtils.GetType("#u.#Dkb"), typeof(System.String));
					r_RParseNamePropTip___0__Dkb_String.SetBelong(this.instance);
				}
				return r_RParseNamePropTip___0__Dkb_String;
			}
		}

		/// <summary>
		/// System.String GetFullName(#u.#Dkb)
		/// </summary>
		protected RMethod r_RGetFullName___0__Dkb;
		public virtual RMethod RGetFullName___0__Dkb
		{
			get
			{
				if(r_RGetFullName___0__Dkb == null)
				{
					r_RGetFullName___0__Dkb = new(this, "GetFullName", 0,  ReleactionUtils.GetType("#u.#Dkb"));
					r_RGetFullName___0__Dkb.SetBelong(this.instance);
				}
				return r_RGetFullName___0__Dkb;
			}
		}

		/// <summary>
		/// System.String ParsePromotionPropTip(#u.#Dkb, System.String ByRef, System.String)
		/// </summary>
		protected RMethod r_RParsePromotionPropTip___0__Dkb_Ref_String_String;
		public virtual RMethod RParsePromotionPropTip___0__Dkb_Ref_String_String
		{
			get
			{
				if(r_RParsePromotionPropTip___0__Dkb_Ref_String_String == null)
				{
					r_RParsePromotionPropTip___0__Dkb_Ref_String_String = new(this, "ParsePromotionPropTip", 0,  ReleactionUtils.GetType("#u.#Dkb"), typeof(System.String).MakeByRefType(), typeof(System.String));
					r_RParsePromotionPropTip___0__Dkb_Ref_String_String.SetBelong(this.instance);
				}
				return r_RParsePromotionPropTip___0__Dkb_Ref_String_String;
			}
		}

		/// <summary>
		/// System.String GetSkillName(#u.#Dkb)
		/// </summary>
		protected RMethod r_RGetSkillName___0__Dkb;
		public virtual RMethod RGetSkillName___0__Dkb
		{
			get
			{
				if(r_RGetSkillName___0__Dkb == null)
				{
					r_RGetSkillName___0__Dkb = new(this, "GetSkillName", 0,  ReleactionUtils.GetType("#u.#Dkb"));
					r_RGetSkillName___0__Dkb.SetBelong(this.instance);
				}
				return r_RGetSkillName___0__Dkb;
			}
		}

		/// <summary>
		/// System.String GetSkillName(SKILL_FILE_TYPE, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetSkillName_SKILL_FILE_TYPE_ID;
		public virtual RMethod RGetSkillName_SKILL_FILE_TYPE_ID
		{
			get
			{
				if(r_RGetSkillName_SKILL_FILE_TYPE_ID == null)
				{
					r_RGetSkillName_SKILL_FILE_TYPE_ID = new(this, "GetSkillName", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(GameDefineType.ID));
					r_RGetSkillName_SKILL_FILE_TYPE_ID.SetBelong(this.instance);
				}
				return r_RGetSkillName_SKILL_FILE_TYPE_ID;
			}
		}

		/// <summary>
		/// Int32 GetSkillFactor(SKILL_FILE_TYPE, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetSkillFactor_SKILL_FILE_TYPE_ID;
		public virtual RMethod RGetSkillFactor_SKILL_FILE_TYPE_ID
		{
			get
			{
				if(r_RGetSkillFactor_SKILL_FILE_TYPE_ID == null)
				{
					r_RGetSkillFactor_SKILL_FILE_TYPE_ID = new(this, "GetSkillFactor", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(GameDefineType.ID));
					r_RGetSkillFactor_SKILL_FILE_TYPE_ID.SetBelong(this.instance);
				}
				return r_RGetSkillFactor_SKILL_FILE_TYPE_ID;
			}
		}

		/// <summary>
		/// System.String GetSkillDesc(SKILL_FILE_TYPE, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetSkillDesc_SKILL_FILE_TYPE_ID;
		public virtual RMethod RGetSkillDesc_SKILL_FILE_TYPE_ID
		{
			get
			{
				if(r_RGetSkillDesc_SKILL_FILE_TYPE_ID == null)
				{
					r_RGetSkillDesc_SKILL_FILE_TYPE_ID = new(this, "GetSkillDesc", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(GameDefineType.ID));
					r_RGetSkillDesc_SKILL_FILE_TYPE_ID.SetBelong(this.instance);
				}
				return r_RGetSkillDesc_SKILL_FILE_TYPE_ID;
			}
		}

		/// <summary>
		/// System.String GetSkillDesc(SKILL_FILE_TYPE, Int32, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32;
		public virtual RMethod RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32
		{
			get
			{
				if(r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32 == null)
				{
					r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32 = new(this, "GetSkillDesc", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.Int32));
					r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32.SetBelong(this.instance);
				}
				return r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32;
			}
		}

		/// <summary>
		/// System.String GetSkillDesc(SKILL_FILE_TYPE, Int32, GameDefineType.ID, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32;
		public virtual RMethod RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32
		{
			get
			{
				if(r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32 == null)
				{
					r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32 = new(this, "GetSkillDesc", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Int32));
					r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetSkillDescAndNextLvl(SKILL_FILE_TYPE, Int32, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_RGetSkillDescAndNextLvl_SKILL_FILE_TYPE_Int32_ID_Int32;
		public virtual RMethod RGetSkillDescAndNextLvl_SKILL_FILE_TYPE_Int32_ID_Int32
		{
			get
			{
				if(r_RGetSkillDescAndNextLvl_SKILL_FILE_TYPE_Int32_ID_Int32 == null)
				{
					r_RGetSkillDescAndNextLvl_SKILL_FILE_TYPE_Int32_ID_Int32 = new(this, "GetSkillDescAndNextLvl", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.Int32));
					r_RGetSkillDescAndNextLvl_SKILL_FILE_TYPE_Int32_ID_Int32.SetBelong(this.instance);
				}
				return r_RGetSkillDescAndNextLvl_SKILL_FILE_TYPE_Int32_ID_Int32;
			}
		}

		/// <summary>
		/// System.String GetSkillDesc(SKILL_FILE_TYPE, Int32, GameDefineType.ID, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32_Boolean;
		public virtual RMethod RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32_Boolean
		{
			get
			{
				if(r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32_Boolean == null)
				{
					r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32_Boolean = new(this, "GetSkillDesc", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetSkillDesc_SKILL_FILE_TYPE_Int32_ID_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// System.String GetSkillPlusInfo(SKILL_FILE_TYPE, Int32, GameDefineType.ID, Int32, #u.#Ckb)
		/// </summary>
		protected RMethod r_RGetSkillPlusInfo_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb;
		public virtual RMethod RGetSkillPlusInfo_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb
		{
			get
			{
				if(r_RGetSkillPlusInfo_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb == null)
				{
					r_RGetSkillPlusInfo_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb = new(this, "GetSkillPlusInfo", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.Int32),  ReleactionUtils.GetType("#u.#Ckb"));
					r_RGetSkillPlusInfo_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb.SetBelong(this.instance);
				}
				return r_RGetSkillPlusInfo_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb;
			}
		}

		/// <summary>
		/// System.String GetSkillPlusInfoByLevel(SKILL_FILE_TYPE, Int32, GameDefineType.ID, Int32, #u.#Ckb, Int32)
		/// </summary>
		protected RMethod r_RGetSkillPlusInfoByLevel_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb_Int32;
		public virtual RMethod RGetSkillPlusInfoByLevel_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb_Int32
		{
			get
			{
				if(r_RGetSkillPlusInfoByLevel_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb_Int32 == null)
				{
					r_RGetSkillPlusInfoByLevel_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb_Int32 = new(this, "GetSkillPlusInfoByLevel", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.Int32),  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.Int32));
					r_RGetSkillPlusInfoByLevel_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb_Int32.SetBelong(this.instance);
				}
				return r_RGetSkillPlusInfoByLevel_SKILL_FILE_TYPE_Int32_ID_Int32___0__Ckb_Int32;
			}
		}

		/// <summary>
		/// Int32 GetSkillPrice_f(SKILL_FILE_TYPE, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetSkillPrice_f_SKILL_FILE_TYPE_ID;
		public virtual RMethod RGetSkillPrice_f_SKILL_FILE_TYPE_ID
		{
			get
			{
				if(r_RGetSkillPrice_f_SKILL_FILE_TYPE_ID == null)
				{
					r_RGetSkillPrice_f_SKILL_FILE_TYPE_ID = new(this, "GetSkillPrice_f", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(GameDefineType.ID));
					r_RGetSkillPrice_f_SKILL_FILE_TYPE_ID.SetBelong(this.instance);
				}
				return r_RGetSkillPrice_f_SKILL_FILE_TYPE_ID;
			}
		}

		/// <summary>
		/// System.String GetSkillPropertyValue(SKILL_FILE_TYPE, GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_RGetSkillPropertyValue_SKILL_FILE_TYPE_ID_String;
		public virtual RMethod RGetSkillPropertyValue_SKILL_FILE_TYPE_ID_String
		{
			get
			{
				if(r_RGetSkillPropertyValue_SKILL_FILE_TYPE_ID_String == null)
				{
					r_RGetSkillPropertyValue_SKILL_FILE_TYPE_ID_String = new(this, "GetSkillPropertyValue", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(GameDefineType.ID), typeof(System.String));
					r_RGetSkillPropertyValue_SKILL_FILE_TYPE_ID_String.SetBelong(this.instance);
				}
				return r_RGetSkillPropertyValue_SKILL_FILE_TYPE_ID_String;
			}
		}

		/// <summary>
		/// Void ResetPropCount()
		/// </summary>
		protected RMethod r_RResetPropCount;
		public virtual RMethod RResetPropCount
		{
			get
			{
				if(r_RResetPropCount == null)
				{
					r_RResetPropCount = new(this, "ResetPropCount", 0);
					r_RResetPropCount.SetBelong(this.instance);
				}
				return r_RResetPropCount;
			}
		}

		/// <summary>
		/// Void ParseSkillPropTip(#u.#Dkb, System.Collections.Generic.List`1[#u.#5ib] ByRef)
		/// </summary>
		protected RMethod r_RParseSkillPropTip___0__Dkb_Ref_List_d___0__5ib_p_;
		public virtual RMethod RParseSkillPropTip___0__Dkb_Ref_List_d___0__5ib_p_
		{
			get
			{
				if(r_RParseSkillPropTip___0__Dkb_Ref_List_d___0__5ib_p_ == null)
				{
					r_RParseSkillPropTip___0__Dkb_Ref_List_d___0__5ib_p_ = new(this, "ParseSkillPropTip", 0,  ReleactionUtils.GetType("#u.#Dkb"), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#u.#5ib")).MakeByRefType());
					r_RParseSkillPropTip___0__Dkb_Ref_List_d___0__5ib_p_.SetBelong(this.instance);
				}
				return r_RParseSkillPropTip___0__Dkb_Ref_List_d___0__5ib_p_;
			}
		}

		/// <summary>
		/// Void AddSkillContent(SKILL_FILE_TYPE, System.String, Int32, System.String, #u.#Dkb, System.Collections.Generic.List`1[#u.#5ib] ByRef)
		/// </summary>
		protected RMethod r_RAddSkillContent_SKILL_FILE_TYPE_String_Int32_String___0__Dkb_Ref_List_d___0__5ib_p_;
		public virtual RMethod RAddSkillContent_SKILL_FILE_TYPE_String_Int32_String___0__Dkb_Ref_List_d___0__5ib_p_
		{
			get
			{
				if(r_RAddSkillContent_SKILL_FILE_TYPE_String_Int32_String___0__Dkb_Ref_List_d___0__5ib_p_ == null)
				{
					r_RAddSkillContent_SKILL_FILE_TYPE_String_Int32_String___0__Dkb_Ref_List_d___0__5ib_p_ = new(this, "AddSkillContent", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"), typeof(System.String), typeof(System.Int32), typeof(System.String),  ReleactionUtils.GetType("#u.#Dkb"), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#u.#5ib")).MakeByRefType());
					r_RAddSkillContent_SKILL_FILE_TYPE_String_Int32_String___0__Dkb_Ref_List_d___0__5ib_p_.SetBelong(this.instance);
				}
				return r_RAddSkillContent_SKILL_FILE_TYPE_String_Int32_String___0__Dkb_Ref_List_d___0__5ib_p_;
			}
		}

		/// <summary>
		/// Int32 GetSkillNextPriority(SKILL_FILE_TYPE)
		/// </summary>
		protected RMethod r_RGetSkillNextPriority_SKILL_FILE_TYPE;
		public virtual RMethod RGetSkillNextPriority_SKILL_FILE_TYPE
		{
			get
			{
				if(r_RGetSkillNextPriority_SKILL_FILE_TYPE == null)
				{
					r_RGetSkillNextPriority_SKILL_FILE_TYPE = new(this, "GetSkillNextPriority", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"));
					r_RGetSkillNextPriority_SKILL_FILE_TYPE.SetBelong(this.instance);
				}
				return r_RGetSkillNextPriority_SKILL_FILE_TYPE;
			}
		}

		/// <summary>
		/// Int32 GetSkillBegPriority(SKILL_FILE_TYPE)
		/// </summary>
		protected RMethod r_RGetSkillBegPriority_SKILL_FILE_TYPE;
		public virtual RMethod RGetSkillBegPriority_SKILL_FILE_TYPE
		{
			get
			{
				if(r_RGetSkillBegPriority_SKILL_FILE_TYPE == null)
				{
					r_RGetSkillBegPriority_SKILL_FILE_TYPE = new(this, "GetSkillBegPriority", 0,  ReleactionUtils.GetType("BFGSkillPropTemplate+SKILL_FILE_TYPE"));
					r_RGetSkillBegPriority_SKILL_FILE_TYPE.SetBelong(this.instance);
				}
				return r_RGetSkillBegPriority_SKILL_FILE_TYPE;
			}
		}

		/// <summary>
		/// Void AddHoleContent(System.String, Int32, #u.#Dkb, System.Collections.Generic.List`1[#u.#5ib] ByRef)
		/// </summary>
		protected RMethod r_RAddHoleContent_String_Int32___0__Dkb_Ref_List_d___0__5ib_p_;
		public virtual RMethod RAddHoleContent_String_Int32___0__Dkb_Ref_List_d___0__5ib_p_
		{
			get
			{
				if(r_RAddHoleContent_String_Int32___0__Dkb_Ref_List_d___0__5ib_p_ == null)
				{
					r_RAddHoleContent_String_Int32___0__Dkb_Ref_List_d___0__5ib_p_ = new(this, "AddHoleContent", 0, typeof(System.String), typeof(System.Int32),  ReleactionUtils.GetType("#u.#Dkb"), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#u.#5ib")).MakeByRefType());
					r_RAddHoleContent_String_Int32___0__Dkb_Ref_List_d___0__5ib_p_.SetBelong(this.instance);
				}
				return r_RAddHoleContent_String_Int32___0__Dkb_Ref_List_d___0__5ib_p_;
			}
		}

		/// <summary>
		/// System.String ParseHoldTip(#u.#Dkb, GameDefineType.ID, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_RParseHoldTip___0__Dkb_ID_ID_Int32;
		public virtual RMethod RParseHoldTip___0__Dkb_ID_ID_Int32
		{
			get
			{
				if(r_RParseHoldTip___0__Dkb_ID_ID_Int32 == null)
				{
					r_RParseHoldTip___0__Dkb_ID_ID_Int32 = new(this, "ParseHoldTip", 0,  ReleactionUtils.GetType("#u.#Dkb"), typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32));
					r_RParseHoldTip___0__Dkb_ID_ID_Int32.SetBelong(this.instance);
				}
				return r_RParseHoldTip___0__Dkb_ID_ID_Int32;
			}
		}

		/// <summary>
		/// Int32 CalEquipmentPrice(#u.#Dkb)
		/// </summary>
		protected RMethod r_RCalEquipmentPrice___0__Dkb;
		public virtual RMethod RCalEquipmentPrice___0__Dkb
		{
			get
			{
				if(r_RCalEquipmentPrice___0__Dkb == null)
				{
					r_RCalEquipmentPrice___0__Dkb = new(this, "CalEquipmentPrice", 0,  ReleactionUtils.GetType("#u.#Dkb"));
					r_RCalEquipmentPrice___0__Dkb.SetBelong(this.instance);
				}
				return r_RCalEquipmentPrice___0__Dkb;
			}
		}

		/// <summary>
		/// System.String GetFSkillInfo(#u.#Ckb, Int32)
		/// </summary>
		protected RMethod r_RGetFSkillInfo___0__Ckb_Int32;
		public virtual RMethod RGetFSkillInfo___0__Ckb_Int32
		{
			get
			{
				if(r_RGetFSkillInfo___0__Ckb_Int32 == null)
				{
					r_RGetFSkillInfo___0__Ckb_Int32 = new(this, "GetFSkillInfo", 0,  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.Int32));
					r_RGetFSkillInfo___0__Ckb_Int32.SetBelong(this.instance);
				}
				return r_RGetFSkillInfo___0__Ckb_Int32;
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


        public RBFGSkillPropTemplate() : base("BFGSkillPropTemplate")
        {
        }

        public RBFGSkillPropTemplate(System.Object instance) : base("BFGSkillPropTemplate")
		{
            SetInstance(instance);
		}

        public RBFGSkillPropTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RBFGSkillPropTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadSkillConfig(UnityEngine.Object[]  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadSkillConfig_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }

















        public virtual void ResetPropCount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetPropCount.Invoke(___genericsType, ___parameters);

            
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
