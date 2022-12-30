using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// EquipSynthesisTemplate
	/// </summary>
    public partial class REquipSynthesisTemplate : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.List`1[GameDefineType.ID]] _gaizaoDictInfo
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RGameDefineType.RID>> r__gaizaoDictInfo;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RList<RGameDefineType.RID>> R_gaizaoDictInfo
		{
			get
			{
				if(r__gaizaoDictInfo == null)
				{
					r__gaizaoDictInfo = new(this, "_gaizaoDictInfo");
					r__gaizaoDictInfo.SetBelong(this.instance);
				}
				return r__gaizaoDictInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] _commonDictInfo
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r__commonDictInfo;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R_commonDictInfo
		{
			get
			{
				if(r__commonDictInfo == null)
				{
					r__commonDictInfo = new(this, "_commonDictInfo");
					r__commonDictInfo.SetBelong(this.instance);
				}
				return r__commonDictInfo;
			}
		}

		/// <summary>
		/// EquipSynthesisType _currentType
		/// </summary>
		protected RField r__currentType;
		public virtual RField R_currentType
		{
			get
			{
				if(r__currentType == null)
				{
					r__currentType = new(this, "_currentType");
					r__currentType.SetBelong(this.instance);
				}
				return r__currentType;
			}
		}

		/// <summary>
		/// System.String ID_NAME
		/// </summary>
		protected static RField r_ID_NAME;
		public static RField RID_NAME
		{
			get
			{
				if(r_ID_NAME == null)
				{
					r_ID_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "ID_NAME");
					r_ID_NAME.SetBelong(null);
				}
				return r_ID_NAME;
			}
		}

		/// <summary>
		/// System.String RESULT_NAME
		/// </summary>
		protected static RField r_RESULT_NAME;
		public static RField RESULT_NAME
		{
			get
			{
				if(r_RESULT_NAME == null)
				{
					r_RESULT_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "RESULT_NAME");
					r_RESULT_NAME.SetBelong(null);
				}
				return r_RESULT_NAME;
			}
		}

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
					r_DESCRIPTION_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "DESCRIPTION_NAME");
					r_DESCRIPTION_NAME.SetBelong(null);
				}
				return r_DESCRIPTION_NAME;
			}
		}

		/// <summary>
		/// System.String NAME_NAME
		/// </summary>
		protected static RField r_NAME_NAME;
		public static RField RNAME_NAME
		{
			get
			{
				if(r_NAME_NAME == null)
				{
					r_NAME_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "NAME_NAME");
					r_NAME_NAME.SetBelong(null);
				}
				return r_NAME_NAME;
			}
		}

		/// <summary>
		/// System.String STUFF_PREFIX_NAME
		/// </summary>
		protected static RField r_STUFF_PREFIX_NAME;
		public static RField RSTUFF_PREFIX_NAME
		{
			get
			{
				if(r_STUFF_PREFIX_NAME == null)
				{
					r_STUFF_PREFIX_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "STUFF_PREFIX_NAME");
					r_STUFF_PREFIX_NAME.SetBelong(null);
				}
				return r_STUFF_PREFIX_NAME;
			}
		}

		/// <summary>
		/// System.String STUFF_QUANTITY_POSFIT_NAME
		/// </summary>
		protected static RField r_STUFF_QUANTITY_POSFIT_NAME;
		public static RField RSTUFF_QUANTITY_POSFIT_NAME
		{
			get
			{
				if(r_STUFF_QUANTITY_POSFIT_NAME == null)
				{
					r_STUFF_QUANTITY_POSFIT_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "STUFF_QUANTITY_POSFIT_NAME");
					r_STUFF_QUANTITY_POSFIT_NAME.SetBelong(null);
				}
				return r_STUFF_QUANTITY_POSFIT_NAME;
			}
		}

		/// <summary>
		/// System.String GAIZAO_TYPE_NAME
		/// </summary>
		protected static RField r_GAIZAO_TYPE_NAME;
		public static RField RGAIZAO_TYPE_NAME
		{
			get
			{
				if(r_GAIZAO_TYPE_NAME == null)
				{
					r_GAIZAO_TYPE_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "GAIZAO_TYPE_NAME");
					r_GAIZAO_TYPE_NAME.SetBelong(null);
				}
				return r_GAIZAO_TYPE_NAME;
			}
		}

		/// <summary>
		/// System.String GAIZAO_TRANSFORM_NAME
		/// </summary>
		protected static RField r_GAIZAO_TRANSFORM_NAME;
		public static RField RGAIZAO_TRANSFORM_NAME
		{
			get
			{
				if(r_GAIZAO_TRANSFORM_NAME == null)
				{
					r_GAIZAO_TRANSFORM_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "GAIZAO_TRANSFORM_NAME");
					r_GAIZAO_TRANSFORM_NAME.SetBelong(null);
				}
				return r_GAIZAO_TRANSFORM_NAME;
			}
		}

		/// <summary>
		/// System.String EQUIPMAKE_ICON_NAME
		/// </summary>
		protected static RField r_EQUIPMAKE_ICON_NAME;
		public static RField REQUIPMAKE_ICON_NAME
		{
			get
			{
				if(r_EQUIPMAKE_ICON_NAME == null)
				{
					r_EQUIPMAKE_ICON_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "EQUIPMAKE_ICON_NAME");
					r_EQUIPMAKE_ICON_NAME.SetBelong(null);
				}
				return r_EQUIPMAKE_ICON_NAME;
			}
		}

		/// <summary>
		/// System.String EQUIPMAKE_WORKSHOP_NAME
		/// </summary>
		protected static RField r_EQUIPMAKE_WORKSHOP_NAME;
		public static RField REQUIPMAKE_WORKSHOP_NAME
		{
			get
			{
				if(r_EQUIPMAKE_WORKSHOP_NAME == null)
				{
					r_EQUIPMAKE_WORKSHOP_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "EQUIPMAKE_WORKSHOP_NAME");
					r_EQUIPMAKE_WORKSHOP_NAME.SetBelong(null);
				}
				return r_EQUIPMAKE_WORKSHOP_NAME;
			}
		}

		/// <summary>
		/// System.String EQUIPMAKE_COURSETYPE_NAME
		/// </summary>
		protected static RField r_EQUIPMAKE_COURSETYPE_NAME;
		public static RField REQUIPMAKE_COURSETYPE_NAME
		{
			get
			{
				if(r_EQUIPMAKE_COURSETYPE_NAME == null)
				{
					r_EQUIPMAKE_COURSETYPE_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "EQUIPMAKE_COURSETYPE_NAME");
					r_EQUIPMAKE_COURSETYPE_NAME.SetBelong(null);
				}
				return r_EQUIPMAKE_COURSETYPE_NAME;
			}
		}

		/// <summary>
		/// System.String EQUIPMAKE_LEARN_NAME
		/// </summary>
		protected static RField r_EQUIPMAKE_LEARN_NAME;
		public static RField REQUIPMAKE_LEARN_NAME
		{
			get
			{
				if(r_EQUIPMAKE_LEARN_NAME == null)
				{
					r_EQUIPMAKE_LEARN_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "EQUIPMAKE_LEARN_NAME");
					r_EQUIPMAKE_LEARN_NAME.SetBelong(null);
				}
				return r_EQUIPMAKE_LEARN_NAME;
			}
		}

		/// <summary>
		/// System.String EQUIPMAKE_INSKILLUI_NAME
		/// </summary>
		protected static RField r_EQUIPMAKE_INSKILLUI_NAME;
		public static RField REQUIPMAKE_INSKILLUI_NAME
		{
			get
			{
				if(r_EQUIPMAKE_INSKILLUI_NAME == null)
				{
					r_EQUIPMAKE_INSKILLUI_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "EQUIPMAKE_INSKILLUI_NAME");
					r_EQUIPMAKE_INSKILLUI_NAME.SetBelong(null);
				}
				return r_EQUIPMAKE_INSKILLUI_NAME;
			}
		}

		/// <summary>
		/// System.String EQUIPMAKE_LV_NAME
		/// </summary>
		protected static RField r_EQUIPMAKE_LV_NAME;
		public static RField REQUIPMAKE_LV_NAME
		{
			get
			{
				if(r_EQUIPMAKE_LV_NAME == null)
				{
					r_EQUIPMAKE_LV_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "EQUIPMAKE_LV_NAME");
					r_EQUIPMAKE_LV_NAME.SetBelong(null);
				}
				return r_EQUIPMAKE_LV_NAME;
			}
		}

		/// <summary>
		/// System.String EQUIPMAKE_PAYGOLD_NAME
		/// </summary>
		protected static RField r_EQUIPMAKE_PAYGOLD_NAME;
		public static RField REQUIPMAKE_PAYGOLD_NAME
		{
			get
			{
				if(r_EQUIPMAKE_PAYGOLD_NAME == null)
				{
					r_EQUIPMAKE_PAYGOLD_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "EQUIPMAKE_PAYGOLD_NAME");
					r_EQUIPMAKE_PAYGOLD_NAME.SetBelong(null);
				}
				return r_EQUIPMAKE_PAYGOLD_NAME;
			}
		}

		/// <summary>
		/// System.String EQUIPMAKE_PAYSKILL_NAME
		/// </summary>
		protected static RField r_EQUIPMAKE_PAYSKILL_NAME;
		public static RField REQUIPMAKE_PAYSKILL_NAME
		{
			get
			{
				if(r_EQUIPMAKE_PAYSKILL_NAME == null)
				{
					r_EQUIPMAKE_PAYSKILL_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "EQUIPMAKE_PAYSKILL_NAME");
					r_EQUIPMAKE_PAYSKILL_NAME.SetBelong(null);
				}
				return r_EQUIPMAKE_PAYSKILL_NAME;
			}
		}

		/// <summary>
		/// System.String LEARN_DESC_NAME
		/// </summary>
		protected static RField r_LEARN_DESC_NAME;
		public static RField RLEARN_DESC_NAME
		{
			get
			{
				if(r_LEARN_DESC_NAME == null)
				{
					r_LEARN_DESC_NAME = new( ReleactionUtils.GetType("EquipSynthesisTemplate"), "LEARN_DESC_NAME");
					r_LEARN_DESC_NAME.SetBelong(null);
				}
				return r_LEARN_DESC_NAME;
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
		/// Void OnLoadWorkshopStudyXmlArg(System.Object, #u.#i8)
		/// </summary>
		protected RMethod r_ROnLoadWorkshopStudyXmlArg_Object___0__i8;
		public virtual RMethod ROnLoadWorkshopStudyXmlArg_Object___0__i8
		{
			get
			{
				if(r_ROnLoadWorkshopStudyXmlArg_Object___0__i8 == null)
				{
					r_ROnLoadWorkshopStudyXmlArg_Object___0__i8 = new(this, "OnLoadWorkshopStudyXmlArg", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#i8"));
					r_ROnLoadWorkshopStudyXmlArg_Object___0__i8.SetBelong(this.instance);
				}
				return r_ROnLoadWorkshopStudyXmlArg_Object___0__i8;
			}
		}

		/// <summary>
		/// Void OnLoadEquipMakeXmlArg(System.Object, #u.#i8)
		/// </summary>
		protected RMethod r_ROnLoadEquipMakeXmlArg_Object___0__i8;
		public virtual RMethod ROnLoadEquipMakeXmlArg_Object___0__i8
		{
			get
			{
				if(r_ROnLoadEquipMakeXmlArg_Object___0__i8 == null)
				{
					r_ROnLoadEquipMakeXmlArg_Object___0__i8 = new(this, "OnLoadEquipMakeXmlArg", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#i8"));
					r_ROnLoadEquipMakeXmlArg_Object___0__i8.SetBelong(this.instance);
				}
				return r_ROnLoadEquipMakeXmlArg_Object___0__i8;
			}
		}

		/// <summary>
		/// Void OnLoadEquipTransformXmlArg(System.Object, #u.#i8)
		/// </summary>
		protected RMethod r_ROnLoadEquipTransformXmlArg_Object___0__i8;
		public virtual RMethod ROnLoadEquipTransformXmlArg_Object___0__i8
		{
			get
			{
				if(r_ROnLoadEquipTransformXmlArg_Object___0__i8 == null)
				{
					r_ROnLoadEquipTransformXmlArg_Object___0__i8 = new(this, "OnLoadEquipTransformXmlArg", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#i8"));
					r_ROnLoadEquipTransformXmlArg_Object___0__i8.SetBelong(this.instance);
				}
				return r_ROnLoadEquipTransformXmlArg_Object___0__i8;
			}
		}

		/// <summary>
		/// Void OnLoadEquipShiftXmlArg(System.Object, #u.#i8)
		/// </summary>
		protected RMethod r_ROnLoadEquipShiftXmlArg_Object___0__i8;
		public virtual RMethod ROnLoadEquipShiftXmlArg_Object___0__i8
		{
			get
			{
				if(r_ROnLoadEquipShiftXmlArg_Object___0__i8 == null)
				{
					r_ROnLoadEquipShiftXmlArg_Object___0__i8 = new(this, "OnLoadEquipShiftXmlArg", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#i8"));
					r_ROnLoadEquipShiftXmlArg_Object___0__i8.SetBelong(this.instance);
				}
				return r_ROnLoadEquipShiftXmlArg_Object___0__i8;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] GetItemTransformFormula(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetItemTransformFormula_ID;
		public virtual RMethod RGetItemTransformFormula_ID
		{
			get
			{
				if(r_RGetItemTransformFormula_ID == null)
				{
					r_RGetItemTransformFormula_ID = new(this, "GetItemTransformFormula", 0, typeof(GameDefineType.ID));
					r_RGetItemTransformFormula_ID.SetBelong(this.instance);
				}
				return r_RGetItemTransformFormula_ID;
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


        public REquipSynthesisTemplate() : base("EquipSynthesisTemplate")
        {
        }

        public REquipSynthesisTemplate(System.Object instance) : base("EquipSynthesisTemplate")
		{
            SetInstance(instance);
		}

        public REquipSynthesisTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REquipSynthesisTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }





        public virtual System.Collections.Generic.List<GameDefineType.ID> GetItemTransformFormula(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetItemTransformFormula_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
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
