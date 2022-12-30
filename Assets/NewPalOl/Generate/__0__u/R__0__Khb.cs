using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#Khb
	/// </summary>
    public partial class R__0__Khb : RMember //
    {

		/// <summary>
		/// System.Int32 #a
		/// </summary>
		protected static RField r___0__a;
		public static RField R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new( ReleactionUtils.GetType("#u.#Khb"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Boolean[] #b
		/// </summary>
		protected RFieldArray<RField> r___0__b;
		public virtual RFieldArray<RField> R__0__b
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
		/// System.Collections.Generic.Dictionary`2[#u.#9gb,#u.#ahb] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__ahb> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__ahb> R__0__c
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,#u.#ahb] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__ahb> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__ahb> R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(this, "#d");
					r___0__d.SetBelong(this.instance);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,StrengthenQuene] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RStrengthenQuene> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RStrengthenQuene> R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(this, "#e");
					r___0__e.SetBelong(this.instance);
				}
				return r___0__e;
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
		/// Void #chb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__chb_Object___0__Isb;
		public virtual RMethod R__0__chb_Object___0__Isb
		{
			get
			{
				if(r_R__0__chb_Object___0__Isb == null)
				{
					r_R__0__chb_Object___0__Isb = new(this, "#chb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__chb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__chb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #dhb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__dhb_Object___0__Isb;
		public virtual RMethod R__0__dhb_Object___0__Isb
		{
			get
			{
				if(r_R__0__dhb_Object___0__Isb == null)
				{
					r_R__0__dhb_Object___0__Isb = new(this, "#dhb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__dhb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__dhb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #ghb(Int32, GameDefineType.ID, GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__ghb_Int32_ID_ID_ID;
		public virtual RMethod R__0__ghb_Int32_ID_ID_ID
		{
			get
			{
				if(r_R__0__ghb_Int32_ID_ID_ID == null)
				{
					r_R__0__ghb_Int32_ID_ID_ID = new(this, "#ghb", 0, typeof(System.Int32), typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_R__0__ghb_Int32_ID_ID_ID.SetBelong(this.instance);
				}
				return r_R__0__ghb_Int32_ID_ID_ID;
			}
		}

		/// <summary>
		/// #u.#ahb #hhb(#u.#9gb)
		/// </summary>
		protected RMethod r_R__0__hhb___0__9gb;
		public virtual RMethod R__0__hhb___0__9gb
		{
			get
			{
				if(r_R__0__hhb___0__9gb == null)
				{
					r_R__0__hhb___0__9gb = new(this, "#hhb", 0,  ReleactionUtils.GetType("#u.#9gb"));
					r_R__0__hhb___0__9gb.SetBelong(this.instance);
				}
				return r_R__0__hhb___0__9gb;
			}
		}

		/// <summary>
		/// Void #ihb(#u.#ahb)
		/// </summary>
		protected RMethod r_R__0__ihb___0__ahb;
		public virtual RMethod R__0__ihb___0__ahb
		{
			get
			{
				if(r_R__0__ihb___0__ahb == null)
				{
					r_R__0__ihb___0__ahb = new(this, "#ihb", 0,  ReleactionUtils.GetType("#u.#ahb"));
					r_R__0__ihb___0__ahb.SetBelong(this.instance);
				}
				return r_R__0__ihb___0__ahb;
			}
		}

		/// <summary>
		/// Void #jhb(Int32)
		/// </summary>
		protected RMethod r_R__0__jhb_Int32;
		public virtual RMethod R__0__jhb_Int32
		{
			get
			{
				if(r_R__0__jhb_Int32 == null)
				{
					r_R__0__jhb_Int32 = new(this, "#jhb", 0, typeof(System.Int32));
					r_R__0__jhb_Int32.SetBelong(this.instance);
				}
				return r_R__0__jhb_Int32;
			}
		}

		/// <summary>
		/// Int32 #khb()
		/// </summary>
		protected RMethod r_R__0__khb;
		public virtual RMethod R__0__khb
		{
			get
			{
				if(r_R__0__khb == null)
				{
					r_R__0__khb = new(this, "#khb", 0);
					r_R__0__khb.SetBelong(this.instance);
				}
				return r_R__0__khb;
			}
		}

		/// <summary>
		/// #u.#ahb #lhb(Int32)
		/// </summary>
		protected RMethod r_R__0__lhb_Int32;
		public virtual RMethod R__0__lhb_Int32
		{
			get
			{
				if(r_R__0__lhb_Int32 == null)
				{
					r_R__0__lhb_Int32 = new(this, "#lhb", 0, typeof(System.Int32));
					r_R__0__lhb_Int32.SetBelong(this.instance);
				}
				return r_R__0__lhb_Int32;
			}
		}

		/// <summary>
		/// Void #mhb()
		/// </summary>
		protected RMethod r_R__0__mhb;
		public virtual RMethod R__0__mhb
		{
			get
			{
				if(r_R__0__mhb == null)
				{
					r_R__0__mhb = new(this, "#mhb", 0);
					r_R__0__mhb.SetBelong(this.instance);
				}
				return r_R__0__mhb;
			}
		}

		/// <summary>
		/// Void #nhb(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__nhb___0__Ckb;
		public virtual RMethod R__0__nhb___0__Ckb
		{
			get
			{
				if(r_R__0__nhb___0__Ckb == null)
				{
					r_R__0__nhb___0__Ckb = new(this, "#nhb", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__nhb___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__nhb___0__Ckb;
			}
		}

		/// <summary>
		/// Void #ohb(Int32)
		/// </summary>
		protected RMethod r_R__0__ohb_Int32;
		public virtual RMethod R__0__ohb_Int32
		{
			get
			{
				if(r_R__0__ohb_Int32 == null)
				{
					r_R__0__ohb_Int32 = new(this, "#ohb", 0, typeof(System.Int32));
					r_R__0__ohb_Int32.SetBelong(this.instance);
				}
				return r_R__0__ohb_Int32;
			}
		}

		/// <summary>
		/// Boolean #phb(EquipTransformType)
		/// </summary>
		protected RMethod r_R__0__phb_EquipTransformType;
		public virtual RMethod R__0__phb_EquipTransformType
		{
			get
			{
				if(r_R__0__phb_EquipTransformType == null)
				{
					r_R__0__phb_EquipTransformType = new(this, "#phb", 0,  ReleactionUtils.GetType("EquipTransformType"));
					r_R__0__phb_EquipTransformType.SetBelong(this.instance);
				}
				return r_R__0__phb_EquipTransformType;
			}
		}

		/// <summary>
		/// Void #qhb(#Pfb.#Atb, #Pfb.#ytb, GameDefineType.ID, #u.#8gb, Boolean)
		/// </summary>
		protected RMethod r_R__0__qhb___0__Atb___0__ytb_ID___0__8gb_Boolean;
		public virtual RMethod R__0__qhb___0__Atb___0__ytb_ID___0__8gb_Boolean
		{
			get
			{
				if(r_R__0__qhb___0__Atb___0__ytb_ID___0__8gb_Boolean == null)
				{
					r_R__0__qhb___0__Atb___0__ytb_ID___0__8gb_Boolean = new(this, "#qhb", 0,  ReleactionUtils.GetType("#Pfb.#Atb"),  ReleactionUtils.GetType("#Pfb.#ytb"), typeof(GameDefineType.ID),  ReleactionUtils.GetType("#u.#8gb"), typeof(System.Boolean));
					r_R__0__qhb___0__Atb___0__ytb_ID___0__8gb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__qhb___0__Atb___0__ytb_ID___0__8gb_Boolean;
			}
		}

		/// <summary>
		/// #u.#Ckb #1Wc(PLACE, #cjb1, GameDefineType.ID)
		/// </summary>
		protected static RMethod r_R__0__1Wc_PLACE___0__cjb1_ID;
		public static RMethod R__0__1Wc_PLACE___0__cjb1_ID
		{
			get
			{
				if(r_R__0__1Wc_PLACE___0__cjb1_ID == null)
				{
					r_R__0__1Wc_PLACE___0__cjb1_ID = new( ReleactionUtils.GetType("#u.#Khb"), "#1Wc", 0,  ReleactionUtils.GetType("ItemType+PLACE"),  ReleactionUtils.GetType("ItemType+#cjb1"), typeof(GameDefineType.ID));
					r_R__0__1Wc_PLACE___0__cjb1_ID.SetBelong(null);
				}
				return r_R__0__1Wc_PLACE___0__cjb1_ID;
			}
		}

		/// <summary>
		/// Void #shb(GameDefineType.ID, GameDefineType.ID, Boolean, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__shb_ID_ID_Boolean_ID;
		public virtual RMethod R__0__shb_ID_ID_Boolean_ID
		{
			get
			{
				if(r_R__0__shb_ID_ID_Boolean_ID == null)
				{
					r_R__0__shb_ID_ID_Boolean_ID = new(this, "#shb", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Boolean), typeof(GameDefineType.ID));
					r_R__0__shb_ID_ID_Boolean_ID.SetBelong(this.instance);
				}
				return r_R__0__shb_ID_ID_Boolean_ID;
			}
		}

		/// <summary>
		/// Void #thb(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__thb_ID_ID;
		public virtual RMethod R__0__thb_ID_ID
		{
			get
			{
				if(r_R__0__thb_ID_ID == null)
				{
					r_R__0__thb_ID_ID = new(this, "#thb", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_R__0__thb_ID_ID.SetBelong(this.instance);
				}
				return r_R__0__thb_ID_ID;
			}
		}

		/// <summary>
		/// Void #uhb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__uhb_Object___0__Isb;
		public virtual RMethod R__0__uhb_Object___0__Isb
		{
			get
			{
				if(r_R__0__uhb_Object___0__Isb == null)
				{
					r_R__0__uhb_Object___0__Isb = new(this, "#uhb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__uhb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__uhb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #vhb(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__vhb___0__Ckb;
		public virtual RMethod R__0__vhb___0__Ckb
		{
			get
			{
				if(r_R__0__vhb___0__Ckb == null)
				{
					r_R__0__vhb___0__Ckb = new(this, "#vhb", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__vhb___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__vhb___0__Ckb;
			}
		}

		/// <summary>
		/// Void #whb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__whb_Object___0__Isb;
		public virtual RMethod R__0__whb_Object___0__Isb
		{
			get
			{
				if(r_R__0__whb_Object___0__Isb == null)
				{
					r_R__0__whb_Object___0__Isb = new(this, "#whb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__whb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__whb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #xhb(GameDefineType.ID, GameDefineType.ID, Int32, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__xhb_ID_ID_Int32_ID_Int32;
		public virtual RMethod R__0__xhb_ID_ID_Int32_ID_Int32
		{
			get
			{
				if(r_R__0__xhb_ID_ID_Int32_ID_Int32 == null)
				{
					r_R__0__xhb_ID_ID_Int32_ID_Int32 = new(this, "#xhb", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32), typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__xhb_ID_ID_Int32_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__xhb_ID_ID_Int32_ID_Int32;
			}
		}

		/// <summary>
		/// Void #tod(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__tod_ID;
		public virtual RMethod R__0__tod_ID
		{
			get
			{
				if(r_R__0__tod_ID == null)
				{
					r_R__0__tod_ID = new(this, "#tod", 0, typeof(GameDefineType.ID));
					r_R__0__tod_ID.SetBelong(this.instance);
				}
				return r_R__0__tod_ID;
			}
		}

		/// <summary>
		/// Void #wl(GameDefineType.ID, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__wl_ID_ID_Int32;
		public virtual RMethod R__0__wl_ID_ID_Int32
		{
			get
			{
				if(r_R__0__wl_ID_ID_Int32 == null)
				{
					r_R__0__wl_ID_ID_Int32 = new(this, "#wl", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__wl_ID_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__wl_ID_ID_Int32;
			}
		}

		/// <summary>
		/// Void #yhb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__yhb_Object___0__Isb;
		public virtual RMethod R__0__yhb_Object___0__Isb
		{
			get
			{
				if(r_R__0__yhb_Object___0__Isb == null)
				{
					r_R__0__yhb_Object___0__Isb = new(this, "#yhb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__yhb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__yhb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Cxk(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Cxk_ID;
		public virtual RMethod R__0__Cxk_ID
		{
			get
			{
				if(r_R__0__Cxk_ID == null)
				{
					r_R__0__Cxk_ID = new(this, "#Cxk", 0, typeof(GameDefineType.ID));
					r_R__0__Cxk_ID.SetBelong(this.instance);
				}
				return r_R__0__Cxk_ID;
			}
		}

		/// <summary>
		/// Void #HEd(GameDefineType.ID, GameDefineType.ID, PLACE)
		/// </summary>
		protected RMethod r_R__0__HEd_ID_ID_PLACE;
		public virtual RMethod R__0__HEd_ID_ID_PLACE
		{
			get
			{
				if(r_R__0__HEd_ID_ID_PLACE == null)
				{
					r_R__0__HEd_ID_ID_PLACE = new(this, "#HEd", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID),  ReleactionUtils.GetType("ItemType+PLACE"));
					r_R__0__HEd_ID_ID_PLACE.SetBelong(this.instance);
				}
				return r_R__0__HEd_ID_ID_PLACE;
			}
		}

		/// <summary>
		/// Void #Axd(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__Axd_ID_Int32;
		public virtual RMethod R__0__Axd_ID_Int32
		{
			get
			{
				if(r_R__0__Axd_ID_Int32 == null)
				{
					r_R__0__Axd_ID_Int32 = new(this, "#Axd", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__Axd_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__Axd_ID_Int32;
			}
		}

		/// <summary>
		/// Void #zhb(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__zhb_ID_Int32;
		public virtual RMethod R__0__zhb_ID_Int32
		{
			get
			{
				if(r_R__0__zhb_ID_Int32 == null)
				{
					r_R__0__zhb_ID_Int32 = new(this, "#zhb", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__zhb_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__zhb_ID_Int32;
			}
		}

		/// <summary>
		/// Void #Ahb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Ahb_Object___0__Isb;
		public virtual RMethod R__0__Ahb_Object___0__Isb
		{
			get
			{
				if(r_R__0__Ahb_Object___0__Isb == null)
				{
					r_R__0__Ahb_Object___0__Isb = new(this, "#Ahb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Ahb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Ahb_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Bhb(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Bhb_Object___0__Isb;
		public virtual RMethod R__0__Bhb_Object___0__Isb
		{
			get
			{
				if(r_R__0__Bhb_Object___0__Isb == null)
				{
					r_R__0__Bhb_Object___0__Isb = new(this, "#Bhb", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Bhb_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Bhb_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,StrengthenQuene] #Chb()
		/// </summary>
		protected RMethod r_R__0__Chb;
		public virtual RMethod R__0__Chb
		{
			get
			{
				if(r_R__0__Chb == null)
				{
					r_R__0__Chb = new(this, "#Chb", 0);
					r_R__0__Chb.SetBelong(this.instance);
				}
				return r_R__0__Chb;
			}
		}

		/// <summary>
		/// StrengthenQuene #Dhb(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Dhb_ID;
		public virtual RMethod R__0__Dhb_ID
		{
			get
			{
				if(r_R__0__Dhb_ID == null)
				{
					r_R__0__Dhb_ID = new(this, "#Dhb", 0, typeof(GameDefineType.ID));
					r_R__0__Dhb_ID.SetBelong(this.instance);
				}
				return r_R__0__Dhb_ID;
			}
		}

		/// <summary>
		/// Void #Ehb(GameDefineType.ID, Single, QueueStateType, QueueType)
		/// </summary>
		protected RMethod r_R__0__Ehb_ID_Single_QueueStateType_QueueType;
		public virtual RMethod R__0__Ehb_ID_Single_QueueStateType_QueueType
		{
			get
			{
				if(r_R__0__Ehb_ID_Single_QueueStateType_QueueType == null)
				{
					r_R__0__Ehb_ID_Single_QueueStateType_QueueType = new(this, "#Ehb", 0, typeof(GameDefineType.ID), typeof(System.Single), typeof(QueueStateType), typeof(QueueType));
					r_R__0__Ehb_ID_Single_QueueStateType_QueueType.SetBelong(this.instance);
				}
				return r_R__0__Ehb_ID_Single_QueueStateType_QueueType;
			}
		}

		/// <summary>
		/// Void #Ehb(GameDefineType.ID, Single, Boolean, QueueType)
		/// </summary>
		protected RMethod r_R__0__Ehb_ID_Single_Boolean_QueueType;
		public virtual RMethod R__0__Ehb_ID_Single_Boolean_QueueType
		{
			get
			{
				if(r_R__0__Ehb_ID_Single_Boolean_QueueType == null)
				{
					r_R__0__Ehb_ID_Single_Boolean_QueueType = new(this, "#Ehb", 0, typeof(GameDefineType.ID), typeof(System.Single), typeof(System.Boolean), typeof(QueueType));
					r_R__0__Ehb_ID_Single_Boolean_QueueType.SetBelong(this.instance);
				}
				return r_R__0__Ehb_ID_Single_Boolean_QueueType;
			}
		}

		/// <summary>
		/// Void #Fhb(GameDefineType.ID, Single, QueueStateType, QueueType)
		/// </summary>
		protected RMethod r_R__0__Fhb_ID_Single_QueueStateType_QueueType;
		public virtual RMethod R__0__Fhb_ID_Single_QueueStateType_QueueType
		{
			get
			{
				if(r_R__0__Fhb_ID_Single_QueueStateType_QueueType == null)
				{
					r_R__0__Fhb_ID_Single_QueueStateType_QueueType = new(this, "#Fhb", 0, typeof(GameDefineType.ID), typeof(System.Single), typeof(QueueStateType), typeof(QueueType));
					r_R__0__Fhb_ID_Single_QueueStateType_QueueType.SetBelong(this.instance);
				}
				return r_R__0__Fhb_ID_Single_QueueStateType_QueueType;
			}
		}

		/// <summary>
		/// Void #Ghb(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Ghb_ID;
		public virtual RMethod R__0__Ghb_ID
		{
			get
			{
				if(r_R__0__Ghb_ID == null)
				{
					r_R__0__Ghb_ID = new(this, "#Ghb", 0, typeof(GameDefineType.ID));
					r_R__0__Ghb_ID.SetBelong(this.instance);
				}
				return r_R__0__Ghb_ID;
			}
		}

		/// <summary>
		/// QueueStateType GetQueneState(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetQueneState_ID;
		public virtual RMethod RGetQueneState_ID
		{
			get
			{
				if(r_RGetQueneState_ID == null)
				{
					r_RGetQueneState_ID = new(this, "GetQueneState", 0, typeof(GameDefineType.ID));
					r_RGetQueneState_ID.SetBelong(this.instance);
				}
				return r_RGetQueneState_ID;
			}
		}

		/// <summary>
		/// Single GetQueneCD(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetQueneCD_ID;
		public virtual RMethod RGetQueneCD_ID
		{
			get
			{
				if(r_RGetQueneCD_ID == null)
				{
					r_RGetQueneCD_ID = new(this, "GetQueneCD", 0, typeof(GameDefineType.ID));
					r_RGetQueneCD_ID.SetBelong(this.instance);
				}
				return r_RGetQueneCD_ID;
			}
		}

		/// <summary>
		/// Void SetQueneState(GameDefineType.ID, QueueStateType, Int32)
		/// </summary>
		protected RMethod r_RSetQueneState_ID_QueueStateType_Int32;
		public virtual RMethod RSetQueneState_ID_QueueStateType_Int32
		{
			get
			{
				if(r_RSetQueneState_ID_QueueStateType_Int32 == null)
				{
					r_RSetQueneState_ID_QueueStateType_Int32 = new(this, "SetQueneState", 0, typeof(GameDefineType.ID), typeof(QueueStateType), typeof(System.Int32));
					r_RSetQueneState_ID_QueueStateType_Int32.SetBelong(this.instance);
				}
				return r_RSetQueneState_ID_QueueStateType_Int32;
			}
		}

		/// <summary>
		/// Void SetQueneState(GameDefineType.ID, Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetQueneState_ID_Int32_Boolean;
		public virtual RMethod RSetQueneState_ID_Int32_Boolean
		{
			get
			{
				if(r_RSetQueneState_ID_Int32_Boolean == null)
				{
					r_RSetQueneState_ID_Int32_Boolean = new(this, "SetQueneState", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Boolean));
					r_RSetQueneState_ID_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetQueneState_ID_Int32_Boolean;
			}
		}

		/// <summary>
		/// GameDefineType.ID #Hhb()
		/// </summary>
		protected RMethod r_R__0__Hhb;
		public virtual RMethod R__0__Hhb
		{
			get
			{
				if(r_R__0__Hhb == null)
				{
					r_R__0__Hhb = new(this, "#Hhb", 0);
					r_R__0__Hhb.SetBelong(this.instance);
				}
				return r_R__0__Hhb;
			}
		}

		/// <summary>
		/// Int32 #tec()
		/// </summary>
		protected RMethod r_R__0__tec;
		public virtual RMethod R__0__tec
		{
			get
			{
				if(r_R__0__tec == null)
				{
					r_R__0__tec = new(this, "#tec", 0);
					r_R__0__tec.SetBelong(this.instance);
				}
				return r_R__0__tec;
			}
		}

		/// <summary>
		/// Void Update()
		/// </summary>
		protected RMethod r_RUpdate;
		public virtual RMethod RUpdate
		{
			get
			{
				if(r_RUpdate == null)
				{
					r_RUpdate = new(this, "Update", 0);
					r_RUpdate.SetBelong(this.instance);
				}
				return r_RUpdate;
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


        public R__0__Khb() : base("#u.#Khb")
        {
        }

        public R__0__Khb(System.Object instance) : base("#u.#Khb")
		{
            SetInstance(instance);
		}

        public R__0__Khb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__Khb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__ghb(System.Int32  @zftype, GameDefineType.ID  @idEquip, GameDefineType.ID  @idItem1, GameDefineType.ID  @idItem2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@zftype, @idEquip, @idItem1, @idItem2};
            var ___result = R__0__ghb_Int32_ID_ID_ID.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__jhb(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = R__0__jhb_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__khb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__khb.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object __0__lhb(System.Int32  @hashval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hashval};
            var ___result = R__0__lhb_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__mhb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__mhb.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__ohb(System.Int32  @zfid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@zfid};
            var ___result = R__0__ohb_Int32.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__shb(GameDefineType.ID  @idFormula, GameDefineType.ID  @idEquip, System.Boolean  @bUseGold, GameDefineType.ID  @idLuckyCfg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFormula, @idEquip, @bUseGold, @idLuckyCfg};
            var ___result = R__0__shb_ID_ID_Boolean_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__thb(GameDefineType.ID  @idEquip, GameDefineType.ID  @idFormula)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idEquip, @idFormula};
            var ___result = R__0__thb_ID_ID.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__xhb(GameDefineType.ID  @EquipID, GameDefineType.ID  @QueneID, System.Int32  @IgnoreCD, GameDefineType.ID  @luckyId, System.Int32  @times)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@EquipID, @QueneID, @IgnoreCD, @luckyId, @times};
            var ___result = R__0__xhb_ID_ID_Int32_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tod(GameDefineType.ID  @QueueID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@QueueID};
            var ___result = R__0__tod_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__wl(GameDefineType.ID  @idEquip, GameDefineType.ID  @idSymbol, System.Int32  @ncostgold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idEquip, @idSymbol, @ncostgold};
            var ___result = R__0__wl_ID_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Cxk(GameDefineType.ID  @idEquip)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idEquip};
            var ___result = R__0__Cxk_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Axd(GameDefineType.ID  @petid, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petid, @type};
            var ___result = R__0__Axd_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__zhb(GameDefineType.ID  @idEquip, System.Int32  @starlv)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idEquip, @starlv};
            var ___result = R__0__zhb_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Collections.Generic.Dictionary<GameDefineType.ID, StrengthenQuene> __0__Chb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Chb.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<GameDefineType.ID, StrengthenQuene>)___result;
        }


        public virtual StrengthenQuene __0__Dhb(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__Dhb_ID.Invoke(___genericsType, ___parameters);

            return (StrengthenQuene)___result;
        }


        public virtual void __0__Ehb(GameDefineType.ID  @id, System.Single  @cd, QueueStateType  @state, QueueType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @cd, @state, @type};
            var ___result = R__0__Ehb_ID_Single_QueueStateType_QueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ehb(GameDefineType.ID  @id, System.Single  @cd, System.Boolean  @bLock, QueueType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @cd, @bLock, @type};
            var ___result = R__0__Ehb_ID_Single_Boolean_QueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Fhb(GameDefineType.ID  @id, System.Single  @cd, QueueStateType  @state, QueueType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @cd, @state, @type};
            var ___result = R__0__Fhb_ID_Single_QueueStateType_QueueType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ghb(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__Ghb_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual QueueStateType GetQueneState(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetQueneState_ID.Invoke(___genericsType, ___parameters);

            return (QueueStateType)___result;
        }


        public virtual System.Single GetQueneCD(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = RGetQueneCD_ID.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void SetQueneState(GameDefineType.ID  @id, QueueStateType  @state, System.Int32  @cd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @state, @cd};
            var ___result = RSetQueneState_ID_QueueStateType_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetQueneState(GameDefineType.ID  @id, System.Int32  @cd, System.Boolean  @bLock)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @cd, @bLock};
            var ___result = RSetQueneState_ID_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual GameDefineType.ID __0__Hhb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Hhb.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.Int32 __0__tec()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__tec.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
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
