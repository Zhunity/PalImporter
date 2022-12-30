using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#yeb
	/// </summary>
    public partial class R__0__yeb : RMember //
    {

		/// <summary>
		/// Pet #a
		/// </summary>
		protected RPet r___0__a;
		public virtual RPet R__0__a
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
		/// GameDefineType.ID #b
		/// </summary>
		protected RGameDefineType.RID r___0__b;
		public virtual RGameDefineType.RID R__0__b
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
		/// System.Boolean #c
		/// </summary>
		protected RField r___0__c;
		public virtual RField R__0__c
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
		/// System.Int32 #d
		/// </summary>
		protected RField r___0__d;
		public virtual RField R__0__d
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
		/// System.Int32 #e
		/// </summary>
		protected RField r___0__e;
		public virtual RField R__0__e
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
		/// System.Int32 #f
		/// </summary>
		protected RField r___0__f;
		public virtual RField R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new(this, "#f");
					r___0__f.SetBelong(this.instance);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// System.Int32 #g
		/// </summary>
		protected RField r___0__g;
		public virtual RField R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new(this, "#g");
					r___0__g.SetBelong(this.instance);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #h
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__h;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new( ReleactionUtils.GetType("#u.#yeb"), "#h");
					r___0__h.SetBelong(null);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// PlayerBehav mPlayerBehav
		/// </summary>
		protected RPlayerBehav r_R__0__jeb;
		public virtual RPlayerBehav R__0__jeb
		{
			get
			{
				if(r_R__0__jeb == null)
				{
					r_R__0__jeb = new(this, "mPlayerBehav", -1);
					r_R__0__jeb.SetBelong(this.instance);
				}
				return r_R__0__jeb;
			}
		}

		/// <summary>
		/// GameDefineType.ID idPlayerPet
		/// </summary>
		protected RGameDefineType.RID r_R__0__keb;
		public virtual RGameDefineType.RID R__0__keb
		{
			get
			{
				if(r_R__0__keb == null)
				{
					r_R__0__keb = new(this, "idPlayerPet", -1);
					r_R__0__keb.SetBelong(this.instance);
				}
				return r_R__0__keb;
			}
		}

		/// <summary>
		/// Pet m_PlayerPet
		/// </summary>
		protected RPet r_R__0__leb;
		public virtual RPet R__0__leb
		{
			get
			{
				if(r_R__0__leb == null)
				{
					r_R__0__leb = new(this, "m_PlayerPet", -1);
					r_R__0__leb.SetBelong(this.instance);
				}
				return r_R__0__leb;
			}
		}

		/// <summary>
		/// Int64 SumGold
		/// </summary>
		protected RProperty r_R__0__bVf;
		public virtual RProperty R__0__bVf
		{
			get
			{
				if(r_R__0__bVf == null)
				{
					r_R__0__bVf = new(this, "SumGold", -1);
					r_R__0__bVf.SetBelong(this.instance);
				}
				return r_R__0__bVf;
			}
		}

		/// <summary>
		/// GameDefineType.ID BattleId
		/// </summary>
		protected RGameDefineType.RID r_R__0__ldb;
		public virtual RGameDefineType.RID R__0__ldb
		{
			get
			{
				if(r_R__0__ldb == null)
				{
					r_R__0__ldb = new(this, "BattleId", -1);
					r_R__0__ldb.SetBelong(this.instance);
				}
				return r_R__0__ldb;
			}
		}

		/// <summary>
		/// GameDefineType.ID TeamId
		/// </summary>
		protected RGameDefineType.RID r_R__0__ndb;
		public virtual RGameDefineType.RID R__0__ndb
		{
			get
			{
				if(r_R__0__ndb == null)
				{
					r_R__0__ndb = new(this, "TeamId", -1);
					r_R__0__ndb.SetBelong(this.instance);
				}
				return r_R__0__ndb;
			}
		}

		/// <summary>
		/// Boolean IsTeamLeader
		/// </summary>
		protected RProperty r_R__0__pdb;
		public virtual RProperty R__0__pdb
		{
			get
			{
				if(r_R__0__pdb == null)
				{
					r_R__0__pdb = new(this, "IsTeamLeader", -1);
					r_R__0__pdb.SetBelong(this.instance);
				}
				return r_R__0__pdb;
			}
		}

		/// <summary>
		/// UnityEngine.Transform m_ctrlTransform
		/// </summary>
		protected RUnityEngine.RTransform r_R__0__Hdb;
		public virtual RUnityEngine.RTransform R__0__Hdb
		{
			get
			{
				if(r_R__0__Hdb == null)
				{
					r_R__0__Hdb = new(this, "m_ctrlTransform", -1);
					r_R__0__Hdb.SetBelong(this.instance);
				}
				return r_R__0__Hdb;
			}
		}

		/// <summary>
		/// CreatureBehav m_behav
		/// </summary>
		protected RCreatureBehav r_R__0__Idb;
		public virtual RCreatureBehav R__0__Idb
		{
			get
			{
				if(r_R__0__Idb == null)
				{
					r_R__0__Idb = new(this, "m_behav", -1);
					r_R__0__Idb.SetBelong(this.instance);
				}
				return r_R__0__Idb;
			}
		}

		/// <summary>
		/// GameDefineType.ID ID
		/// </summary>
		protected RGameDefineType.RID r_R__0__Mdb;
		public virtual RGameDefineType.RID R__0__Mdb
		{
			get
			{
				if(r_R__0__Mdb == null)
				{
					r_R__0__Mdb = new(this, "ID", -1);
					r_R__0__Mdb.SetBelong(this.instance);
				}
				return r_R__0__Mdb;
			}
		}

		/// <summary>
		/// GameDefineType.ID CareerID
		/// </summary>
		protected RGameDefineType.RID r_R__0__Odb;
		public virtual RGameDefineType.RID R__0__Odb
		{
			get
			{
				if(r_R__0__Odb == null)
				{
					r_R__0__Odb = new(this, "CareerID", -1);
					r_R__0__Odb.SetBelong(this.instance);
				}
				return r_R__0__Odb;
			}
		}

		/// <summary>
		/// Void #7db(#Pfb.#Mxb)
		/// </summary>
		protected RMethod r_R__0__7db___0__Mxb;
		public virtual RMethod R__0__7db___0__Mxb
		{
			get
			{
				if(r_R__0__7db___0__Mxb == null)
				{
					r_R__0__7db___0__Mxb = new(this, "#7db", 0,  ReleactionUtils.GetType("#Pfb.#Mxb"));
					r_R__0__7db___0__Mxb.SetBelong(this.instance);
				}
				return r_R__0__7db___0__Mxb;
			}
		}

		/// <summary>
		/// Boolean IsInCombat()
		/// </summary>
		protected RMethod r_RIsInCombat;
		public virtual RMethod RIsInCombat
		{
			get
			{
				if(r_RIsInCombat == null)
				{
					r_RIsInCombat = new(this, "IsInCombat", 0);
					r_RIsInCombat.SetBelong(this.instance);
				}
				return r_RIsInCombat;
			}
		}

		/// <summary>
		/// Boolean #meb()
		/// </summary>
		protected RMethod r_R__0__meb;
		public virtual RMethod R__0__meb
		{
			get
			{
				if(r_R__0__meb == null)
				{
					r_R__0__meb = new(this, "#meb", 0);
					r_R__0__meb.SetBelong(this.instance);
				}
				return r_R__0__meb;
			}
		}

		/// <summary>
		/// Boolean #neb()
		/// </summary>
		protected RMethod r_R__0__neb;
		public virtual RMethod R__0__neb
		{
			get
			{
				if(r_R__0__neb == null)
				{
					r_R__0__neb = new(this, "#neb", 0);
					r_R__0__neb.SetBelong(this.instance);
				}
				return r_R__0__neb;
			}
		}

		/// <summary>
		/// Boolean #oeb()
		/// </summary>
		protected RMethod r_R__0__oeb;
		public virtual RMethod R__0__oeb
		{
			get
			{
				if(r_R__0__oeb == null)
				{
					r_R__0__oeb = new(this, "#oeb", 0);
					r_R__0__oeb.SetBelong(this.instance);
				}
				return r_R__0__oeb;
			}
		}

		/// <summary>
		/// Void #peb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__peb_Object_Object;
		public virtual RMethod R__0__peb_Object_Object
		{
			get
			{
				if(r_R__0__peb_Object_Object == null)
				{
					r_R__0__peb_Object_Object = new(this, "#peb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__peb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__peb_Object_Object;
			}
		}

		/// <summary>
		/// Void OnPostUpdate(System.Object, System.Object)
		/// </summary>
		protected RMethod r_ROnPostUpdate_Object_Object;
		public virtual RMethod ROnPostUpdate_Object_Object
		{
			get
			{
				if(r_ROnPostUpdate_Object_Object == null)
				{
					r_ROnPostUpdate_Object_Object = new(this, "OnPostUpdate", 0, typeof(System.Object), typeof(System.Object));
					r_ROnPostUpdate_Object_Object.SetBelong(this.instance);
				}
				return r_ROnPostUpdate_Object_Object;
			}
		}

		/// <summary>
		/// Void #mhs(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__mhs_Object_Object;
		public virtual RMethod R__0__mhs_Object_Object
		{
			get
			{
				if(r_R__0__mhs_Object_Object == null)
				{
					r_R__0__mhs_Object_Object = new(this, "#mhs", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__mhs_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__mhs_Object_Object;
			}
		}

		/// <summary>
		/// Void #nhs(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__nhs_Object_Object;
		public virtual RMethod R__0__nhs_Object_Object
		{
			get
			{
				if(r_R__0__nhs_Object_Object == null)
				{
					r_R__0__nhs_Object_Object = new(this, "#nhs", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__nhs_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__nhs_Object_Object;
			}
		}

		/// <summary>
		/// Void #3nc(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__3nc_Object_Object;
		public virtual RMethod R__0__3nc_Object_Object
		{
			get
			{
				if(r_R__0__3nc_Object_Object == null)
				{
					r_R__0__3nc_Object_Object = new(this, "#3nc", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__3nc_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__3nc_Object_Object;
			}
		}

		/// <summary>
		/// Void #sC(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__sC_Object_Object;
		public virtual RMethod R__0__sC_Object_Object
		{
			get
			{
				if(r_R__0__sC_Object_Object == null)
				{
					r_R__0__sC_Object_Object = new(this, "#sC", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__sC_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__sC_Object_Object;
			}
		}

		/// <summary>
		/// Void #aVf(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__aVf_Object_Object;
		public virtual RMethod R__0__aVf_Object_Object
		{
			get
			{
				if(r_R__0__aVf_Object_Object == null)
				{
					r_R__0__aVf_Object_Object = new(this, "#aVf", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__aVf_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__aVf_Object_Object;
			}
		}

		/// <summary>
		/// Void #tC(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__tC_Object_Object;
		public virtual RMethod R__0__tC_Object_Object
		{
			get
			{
				if(r_R__0__tC_Object_Object == null)
				{
					r_R__0__tC_Object_Object = new(this, "#tC", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__tC_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__tC_Object_Object;
			}
		}

		/// <summary>
		/// Void #sCi(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__sCi_Object_Object;
		public virtual RMethod R__0__sCi_Object_Object
		{
			get
			{
				if(r_R__0__sCi_Object_Object == null)
				{
					r_R__0__sCi_Object_Object = new(this, "#sCi", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__sCi_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__sCi_Object_Object;
			}
		}

		/// <summary>
		/// Void #z4f(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__z4f_Object_Object;
		public virtual RMethod R__0__z4f_Object_Object
		{
			get
			{
				if(r_R__0__z4f_Object_Object == null)
				{
					r_R__0__z4f_Object_Object = new(this, "#z4f", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__z4f_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__z4f_Object_Object;
			}
		}

		/// <summary>
		/// Void #PJ(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__PJ_Object_Object;
		public virtual RMethod R__0__PJ_Object_Object
		{
			get
			{
				if(r_R__0__PJ_Object_Object == null)
				{
					r_R__0__PJ_Object_Object = new(this, "#PJ", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__PJ_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__PJ_Object_Object;
			}
		}

		/// <summary>
		/// System.Object GetProperty(System.String)
		/// </summary>
		protected RMethod r_RGetProperty_String;
		public virtual RMethod RGetProperty_String
		{
			get
			{
				if(r_RGetProperty_String == null)
				{
					r_RGetProperty_String = new(this, "GetProperty", 0, typeof(System.String));
					r_RGetProperty_String.SetBelong(this.instance);
				}
				return r_RGetProperty_String;
			}
		}

		/// <summary>
		/// Int32 #qeb()
		/// </summary>
		protected RMethod r_R__0__qeb;
		public virtual RMethod R__0__qeb
		{
			get
			{
				if(r_R__0__qeb == null)
				{
					r_R__0__qeb = new(this, "#qeb", 0);
					r_R__0__qeb.SetBelong(this.instance);
				}
				return r_R__0__qeb;
			}
		}

		/// <summary>
		/// Void #reb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__reb_Object_Object;
		public virtual RMethod R__0__reb_Object_Object
		{
			get
			{
				if(r_R__0__reb_Object_Object == null)
				{
					r_R__0__reb_Object_Object = new(this, "#reb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__reb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__reb_Object_Object;
			}
		}

		/// <summary>
		/// Void #seb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__seb_Object_Object;
		public virtual RMethod R__0__seb_Object_Object
		{
			get
			{
				if(r_R__0__seb_Object_Object == null)
				{
					r_R__0__seb_Object_Object = new(this, "#seb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__seb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__seb_Object_Object;
			}
		}

		/// <summary>
		/// Void #aeb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__aeb_Object_Object;
		public virtual RMethod R__0__aeb_Object_Object
		{
			get
			{
				if(r_R__0__aeb_Object_Object == null)
				{
					r_R__0__aeb_Object_Object = new(this, "#aeb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__aeb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__aeb_Object_Object;
			}
		}

		/// <summary>
		/// Void #teb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__teb_Object_Object;
		public virtual RMethod R__0__teb_Object_Object
		{
			get
			{
				if(r_R__0__teb_Object_Object == null)
				{
					r_R__0__teb_Object_Object = new(this, "#teb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__teb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__teb_Object_Object;
			}
		}

		/// <summary>
		/// Void #ueb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__ueb_Object_Object;
		public virtual RMethod R__0__ueb_Object_Object
		{
			get
			{
				if(r_R__0__ueb_Object_Object == null)
				{
					r_R__0__ueb_Object_Object = new(this, "#ueb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__ueb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__ueb_Object_Object;
			}
		}

		/// <summary>
		/// Void #Xtd(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Xtd_Object_Object;
		public virtual RMethod R__0__Xtd_Object_Object
		{
			get
			{
				if(r_R__0__Xtd_Object_Object == null)
				{
					r_R__0__Xtd_Object_Object = new(this, "#Xtd", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Xtd_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Xtd_Object_Object;
			}
		}

		/// <summary>
		/// Void #Jhg(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Jhg_Object_Object;
		public virtual RMethod R__0__Jhg_Object_Object
		{
			get
			{
				if(r_R__0__Jhg_Object_Object == null)
				{
					r_R__0__Jhg_Object_Object = new(this, "#Jhg", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Jhg_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Jhg_Object_Object;
			}
		}

		/// <summary>
		/// Void #Khg(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Khg_Object_Object;
		public virtual RMethod R__0__Khg_Object_Object
		{
			get
			{
				if(r_R__0__Khg_Object_Object == null)
				{
					r_R__0__Khg_Object_Object = new(this, "#Khg", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Khg_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Khg_Object_Object;
			}
		}

		/// <summary>
		/// Void #Lhg(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Lhg_Object_Object;
		public virtual RMethod R__0__Lhg_Object_Object
		{
			get
			{
				if(r_R__0__Lhg_Object_Object == null)
				{
					r_R__0__Lhg_Object_Object = new(this, "#Lhg", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Lhg_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Lhg_Object_Object;
			}
		}

		/// <summary>
		/// Void #AGg(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__AGg_Object_Object;
		public virtual RMethod R__0__AGg_Object_Object
		{
			get
			{
				if(r_R__0__AGg_Object_Object == null)
				{
					r_R__0__AGg_Object_Object = new(this, "#AGg", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__AGg_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__AGg_Object_Object;
			}
		}

		/// <summary>
		/// Void #YLg(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__YLg_Object_Object;
		public virtual RMethod R__0__YLg_Object_Object
		{
			get
			{
				if(r_R__0__YLg_Object_Object == null)
				{
					r_R__0__YLg_Object_Object = new(this, "#YLg", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__YLg_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__YLg_Object_Object;
			}
		}

		/// <summary>
		/// Void #rVj(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__rVj_Object_Object;
		public virtual RMethod R__0__rVj_Object_Object
		{
			get
			{
				if(r_R__0__rVj_Object_Object == null)
				{
					r_R__0__rVj_Object_Object = new(this, "#rVj", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__rVj_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__rVj_Object_Object;
			}
		}

		/// <summary>
		/// Void #kdh(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__kdh_Object_Object;
		public virtual RMethod R__0__kdh_Object_Object
		{
			get
			{
				if(r_R__0__kdh_Object_Object == null)
				{
					r_R__0__kdh_Object_Object = new(this, "#kdh", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__kdh_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__kdh_Object_Object;
			}
		}

		/// <summary>
		/// Void #ldh(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__ldh_Object_Object;
		public virtual RMethod R__0__ldh_Object_Object
		{
			get
			{
				if(r_R__0__ldh_Object_Object == null)
				{
					r_R__0__ldh_Object_Object = new(this, "#ldh", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__ldh_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__ldh_Object_Object;
			}
		}

		/// <summary>
		/// Void #rth(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__rth_Object_Object;
		public virtual RMethod R__0__rth_Object_Object
		{
			get
			{
				if(r_R__0__rth_Object_Object == null)
				{
					r_R__0__rth_Object_Object = new(this, "#rth", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__rth_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__rth_Object_Object;
			}
		}

		/// <summary>
		/// Void #NYj(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__NYj_Object_Object;
		public virtual RMethod R__0__NYj_Object_Object
		{
			get
			{
				if(r_R__0__NYj_Object_Object == null)
				{
					r_R__0__NYj_Object_Object = new(this, "#NYj", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__NYj_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__NYj_Object_Object;
			}
		}

		/// <summary>
		/// Void #31k(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__31k_Object_Object;
		public virtual RMethod R__0__31k_Object_Object
		{
			get
			{
				if(r_R__0__31k_Object_Object == null)
				{
					r_R__0__31k_Object_Object = new(this, "#31k", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__31k_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__31k_Object_Object;
			}
		}

		/// <summary>
		/// Void #41k(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__41k_Object_Object;
		public virtual RMethod R__0__41k_Object_Object
		{
			get
			{
				if(r_R__0__41k_Object_Object == null)
				{
					r_R__0__41k_Object_Object = new(this, "#41k", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__41k_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__41k_Object_Object;
			}
		}

		/// <summary>
		/// Void #Mfl(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Mfl_Object_Object;
		public virtual RMethod R__0__Mfl_Object_Object
		{
			get
			{
				if(r_R__0__Mfl_Object_Object == null)
				{
					r_R__0__Mfl_Object_Object = new(this, "#Mfl", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Mfl_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Mfl_Object_Object;
			}
		}

		/// <summary>
		/// Void #sxk(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__sxk_Object_Object;
		public virtual RMethod R__0__sxk_Object_Object
		{
			get
			{
				if(r_R__0__sxk_Object_Object == null)
				{
					r_R__0__sxk_Object_Object = new(this, "#sxk", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__sxk_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__sxk_Object_Object;
			}
		}

		/// <summary>
		/// Void #txk(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__txk_Object_Object;
		public virtual RMethod R__0__txk_Object_Object
		{
			get
			{
				if(r_R__0__txk_Object_Object == null)
				{
					r_R__0__txk_Object_Object = new(this, "#txk", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__txk_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__txk_Object_Object;
			}
		}

		/// <summary>
		/// Void #sth(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__sth_Object_Object;
		public virtual RMethod R__0__sth_Object_Object
		{
			get
			{
				if(r_R__0__sth_Object_Object == null)
				{
					r_R__0__sth_Object_Object = new(this, "#sth", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__sth_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__sth_Object_Object;
			}
		}

		/// <summary>
		/// Void #7Kh(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__7Kh_Object_Object;
		public virtual RMethod R__0__7Kh_Object_Object
		{
			get
			{
				if(r_R__0__7Kh_Object_Object == null)
				{
					r_R__0__7Kh_Object_Object = new(this, "#7Kh", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__7Kh_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__7Kh_Object_Object;
			}
		}

		/// <summary>
		/// Void #Sei(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Sei_Object_Object;
		public virtual RMethod R__0__Sei_Object_Object
		{
			get
			{
				if(r_R__0__Sei_Object_Object == null)
				{
					r_R__0__Sei_Object_Object = new(this, "#Sei", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Sei_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Sei_Object_Object;
			}
		}

		/// <summary>
		/// Void #Ini(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Ini_Object_Object;
		public virtual RMethod R__0__Ini_Object_Object
		{
			get
			{
				if(r_R__0__Ini_Object_Object == null)
				{
					r_R__0__Ini_Object_Object = new(this, "#Ini", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Ini_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Ini_Object_Object;
			}
		}

		/// <summary>
		/// Void #Jzi(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Jzi_Object_Object;
		public virtual RMethod R__0__Jzi_Object_Object
		{
			get
			{
				if(r_R__0__Jzi_Object_Object == null)
				{
					r_R__0__Jzi_Object_Object = new(this, "#Jzi", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Jzi_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Jzi_Object_Object;
			}
		}

		/// <summary>
		/// Void #eBi(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__eBi_Object_Object;
		public virtual RMethod R__0__eBi_Object_Object
		{
			get
			{
				if(r_R__0__eBi_Object_Object == null)
				{
					r_R__0__eBi_Object_Object = new(this, "#eBi", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__eBi_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__eBi_Object_Object;
			}
		}

		/// <summary>
		/// Void #tCi(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__tCi_Object_Object;
		public virtual RMethod R__0__tCi_Object_Object
		{
			get
			{
				if(r_R__0__tCi_Object_Object == null)
				{
					r_R__0__tCi_Object_Object = new(this, "#tCi", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__tCi_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__tCi_Object_Object;
			}
		}

		/// <summary>
		/// Void #Tei(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Tei_Object_Object;
		public virtual RMethod R__0__Tei_Object_Object
		{
			get
			{
				if(r_R__0__Tei_Object_Object == null)
				{
					r_R__0__Tei_Object_Object = new(this, "#Tei", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Tei_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Tei_Object_Object;
			}
		}

		/// <summary>
		/// Void #geb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__geb_Object_Object;
		public virtual RMethod R__0__geb_Object_Object
		{
			get
			{
				if(r_R__0__geb_Object_Object == null)
				{
					r_R__0__geb_Object_Object = new(this, "#geb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__geb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__geb_Object_Object;
			}
		}

		/// <summary>
		/// Void #mdh(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__mdh_Object_Object;
		public virtual RMethod R__0__mdh_Object_Object
		{
			get
			{
				if(r_R__0__mdh_Object_Object == null)
				{
					r_R__0__mdh_Object_Object = new(this, "#mdh", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__mdh_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__mdh_Object_Object;
			}
		}

		/// <summary>
		/// Void #Anh(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Anh_Object_Object;
		public virtual RMethod R__0__Anh_Object_Object
		{
			get
			{
				if(r_R__0__Anh_Object_Object == null)
				{
					r_R__0__Anh_Object_Object = new(this, "#Anh", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Anh_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Anh_Object_Object;
			}
		}

		/// <summary>
		/// Void #xDm(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__xDm_Object_Object;
		public virtual RMethod R__0__xDm_Object_Object
		{
			get
			{
				if(r_R__0__xDm_Object_Object == null)
				{
					r_R__0__xDm_Object_Object = new(this, "#xDm", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__xDm_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__xDm_Object_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Pet] #veb()
		/// </summary>
		protected RMethod r_R__0__veb;
		public virtual RMethod R__0__veb
		{
			get
			{
				if(r_R__0__veb == null)
				{
					r_R__0__veb = new(this, "#veb", 0);
					r_R__0__veb.SetBelong(this.instance);
				}
				return r_R__0__veb;
			}
		}

		/// <summary>
		/// Boolean #web(Int32)
		/// </summary>
		protected RMethod r_R__0__web_Int32;
		public virtual RMethod R__0__web_Int32
		{
			get
			{
				if(r_R__0__web_Int32 == null)
				{
					r_R__0__web_Int32 = new(this, "#web", 0, typeof(System.Int32));
					r_R__0__web_Int32.SetBelong(this.instance);
				}
				return r_R__0__web_Int32;
			}
		}

		/// <summary>
		/// Boolean #pii(Character)
		/// </summary>
		protected RMethod r_R__0__pii_Character;
		public virtual RMethod R__0__pii_Character
		{
			get
			{
				if(r_R__0__pii_Character == null)
				{
					r_R__0__pii_Character = new(this, "#pii", 0,  ReleactionUtils.GetType("Character"));
					r_R__0__pii_Character.SetBelong(this.instance);
				}
				return r_R__0__pii_Character;
			}
		}

		/// <summary>
		/// Boolean #pii(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__pii_ID;
		public virtual RMethod R__0__pii_ID
		{
			get
			{
				if(r_R__0__pii_ID == null)
				{
					r_R__0__pii_ID = new(this, "#pii", 0, typeof(GameDefineType.ID));
					r_R__0__pii_ID.SetBelong(this.instance);
				}
				return r_R__0__pii_ID;
			}
		}

		/// <summary>
		/// Void #xeb()
		/// </summary>
		protected RMethod r_R__0__xeb;
		public virtual RMethod R__0__xeb
		{
			get
			{
				if(r_R__0__xeb == null)
				{
					r_R__0__xeb = new(this, "#xeb", 0);
					r_R__0__xeb.SetBelong(this.instance);
				}
				return r_R__0__xeb;
			}
		}

		/// <summary>
		/// Void SendMoveMsg(Single, UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RSendMoveMsg_Single_Transform;
		public virtual RMethod RSendMoveMsg_Single_Transform
		{
			get
			{
				if(r_RSendMoveMsg_Single_Transform == null)
				{
					r_RSendMoveMsg_Single_Transform = new(this, "SendMoveMsg", 0, typeof(System.Single), typeof(UnityEngine.Transform));
					r_RSendMoveMsg_Single_Transform.SetBelong(this.instance);
				}
				return r_RSendMoveMsg_Single_Transform;
			}
		}

		/// <summary>
		/// Void #EZp(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__EZp_Object_Object;
		public virtual RMethod R__0__EZp_Object_Object
		{
			get
			{
				if(r_R__0__EZp_Object_Object == null)
				{
					r_R__0__EZp_Object_Object = new(this, "#EZp", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__EZp_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__EZp_Object_Object;
			}
		}

		/// <summary>
		/// Void #e1p(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__e1p_Object_Object;
		public virtual RMethod R__0__e1p_Object_Object
		{
			get
			{
				if(r_R__0__e1p_Object_Object == null)
				{
					r_R__0__e1p_Object_Object = new(this, "#e1p", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__e1p_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__e1p_Object_Object;
			}
		}

		/// <summary>
		/// Void #U8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__U8d_Object_Object;
		public virtual RMethod R__0__U8d_Object_Object
		{
			get
			{
				if(r_R__0__U8d_Object_Object == null)
				{
					r_R__0__U8d_Object_Object = new(this, "#U8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__U8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__U8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #V8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__V8d_Object_Object;
		public virtual RMethod R__0__V8d_Object_Object
		{
			get
			{
				if(r_R__0__V8d_Object_Object == null)
				{
					r_R__0__V8d_Object_Object = new(this, "#V8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__V8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__V8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #W8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__W8d_Object_Object;
		public virtual RMethod R__0__W8d_Object_Object
		{
			get
			{
				if(r_R__0__W8d_Object_Object == null)
				{
					r_R__0__W8d_Object_Object = new(this, "#W8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__W8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__W8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #X8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__X8d_Object_Object;
		public virtual RMethod R__0__X8d_Object_Object
		{
			get
			{
				if(r_R__0__X8d_Object_Object == null)
				{
					r_R__0__X8d_Object_Object = new(this, "#X8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__X8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__X8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #oTn(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__oTn_Object_Object;
		public virtual RMethod R__0__oTn_Object_Object
		{
			get
			{
				if(r_R__0__oTn_Object_Object == null)
				{
					r_R__0__oTn_Object_Object = new(this, "#oTn", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__oTn_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__oTn_Object_Object;
			}
		}

		/// <summary>
		/// Void #R8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__R8d_Object_Object;
		public virtual RMethod R__0__R8d_Object_Object
		{
			get
			{
				if(r_R__0__R8d_Object_Object == null)
				{
					r_R__0__R8d_Object_Object = new(this, "#R8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__R8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__R8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #Cmj(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Cmj_Object_Object;
		public virtual RMethod R__0__Cmj_Object_Object
		{
			get
			{
				if(r_R__0__Cmj_Object_Object == null)
				{
					r_R__0__Cmj_Object_Object = new(this, "#Cmj", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Cmj_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Cmj_Object_Object;
			}
		}

		/// <summary>
		/// Void #Y8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Y8d_Object_Object;
		public virtual RMethod R__0__Y8d_Object_Object
		{
			get
			{
				if(r_R__0__Y8d_Object_Object == null)
				{
					r_R__0__Y8d_Object_Object = new(this, "#Y8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Y8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Y8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #Z8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Z8d_Object_Object;
		public virtual RMethod R__0__Z8d_Object_Object
		{
			get
			{
				if(r_R__0__Z8d_Object_Object == null)
				{
					r_R__0__Z8d_Object_Object = new(this, "#Z8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Z8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Z8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #qhf(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__qhf_Object_Object;
		public virtual RMethod R__0__qhf_Object_Object
		{
			get
			{
				if(r_R__0__qhf_Object_Object == null)
				{
					r_R__0__qhf_Object_Object = new(this, "#qhf", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__qhf_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__qhf_Object_Object;
			}
		}

		/// <summary>
		/// Void #SKf(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__SKf_Object_Object;
		public virtual RMethod R__0__SKf_Object_Object
		{
			get
			{
				if(r_R__0__SKf_Object_Object == null)
				{
					r_R__0__SKf_Object_Object = new(this, "#SKf", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__SKf_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__SKf_Object_Object;
			}
		}

		/// <summary>
		/// Void #Jni(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Jni_Object_Object;
		public virtual RMethod R__0__Jni_Object_Object
		{
			get
			{
				if(r_R__0__Jni_Object_Object == null)
				{
					r_R__0__Jni_Object_Object = new(this, "#Jni", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Jni_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Jni_Object_Object;
			}
		}

		/// <summary>
		/// Void #Kni(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Kni_Object_Object;
		public virtual RMethod R__0__Kni_Object_Object
		{
			get
			{
				if(r_R__0__Kni_Object_Object == null)
				{
					r_R__0__Kni_Object_Object = new(this, "#Kni", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Kni_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Kni_Object_Object;
			}
		}

		/// <summary>
		/// Void #ndh(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__ndh_Object_Object;
		public virtual RMethod R__0__ndh_Object_Object
		{
			get
			{
				if(r_R__0__ndh_Object_Object == null)
				{
					r_R__0__ndh_Object_Object = new(this, "#ndh", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__ndh_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__ndh_Object_Object;
			}
		}

		/// <summary>
		/// Void #KYi(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__KYi_Object_Object;
		public virtual RMethod R__0__KYi_Object_Object
		{
			get
			{
				if(r_R__0__KYi_Object_Object == null)
				{
					r_R__0__KYi_Object_Object = new(this, "#KYi", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__KYi_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__KYi_Object_Object;
			}
		}

		/// <summary>
		/// Void #LYi(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__LYi_Object_Object;
		public virtual RMethod R__0__LYi_Object_Object
		{
			get
			{
				if(r_R__0__LYi_Object_Object == null)
				{
					r_R__0__LYi_Object_Object = new(this, "#LYi", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__LYi_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__LYi_Object_Object;
			}
		}

		/// <summary>
		/// Void #NYi(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__NYi_Object_Object;
		public virtual RMethod R__0__NYi_Object_Object
		{
			get
			{
				if(r_R__0__NYi_Object_Object == null)
				{
					r_R__0__NYi_Object_Object = new(this, "#NYi", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__NYi_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__NYi_Object_Object;
			}
		}

		/// <summary>
		/// Void #Gxj(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Gxj_Object_Object;
		public virtual RMethod R__0__Gxj_Object_Object
		{
			get
			{
				if(r_R__0__Gxj_Object_Object == null)
				{
					r_R__0__Gxj_Object_Object = new(this, "#Gxj", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Gxj_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Gxj_Object_Object;
			}
		}

		/// <summary>
		/// Void #yDm(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__yDm_Object_Object;
		public virtual RMethod R__0__yDm_Object_Object
		{
			get
			{
				if(r_R__0__yDm_Object_Object == null)
				{
					r_R__0__yDm_Object_Object = new(this, "#yDm", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__yDm_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__yDm_Object_Object;
			}
		}

		/// <summary>
		/// Void #Dmj(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Dmj_Object_Object;
		public virtual RMethod R__0__Dmj_Object_Object
		{
			get
			{
				if(r_R__0__Dmj_Object_Object == null)
				{
					r_R__0__Dmj_Object_Object = new(this, "#Dmj", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Dmj_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Dmj_Object_Object;
			}
		}

		/// <summary>
		/// Void #Emj(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Emj_Object_Object;
		public virtual RMethod R__0__Emj_Object_Object
		{
			get
			{
				if(r_R__0__Emj_Object_Object == null)
				{
					r_R__0__Emj_Object_Object = new(this, "#Emj", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Emj_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Emj_Object_Object;
			}
		}

		/// <summary>
		/// Void #Fmj(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Fmj_Object_Object;
		public virtual RMethod R__0__Fmj_Object_Object
		{
			get
			{
				if(r_R__0__Fmj_Object_Object == null)
				{
					r_R__0__Fmj_Object_Object = new(this, "#Fmj", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Fmj_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Fmj_Object_Object;
			}
		}

		/// <summary>
		/// Void #sVj(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__sVj_Object_Object;
		public virtual RMethod R__0__sVj_Object_Object
		{
			get
			{
				if(r_R__0__sVj_Object_Object == null)
				{
					r_R__0__sVj_Object_Object = new(this, "#sVj", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__sVj_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__sVj_Object_Object;
			}
		}

		/// <summary>
		/// Void #uxk(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__uxk_Object_Object;
		public virtual RMethod R__0__uxk_Object_Object
		{
			get
			{
				if(r_R__0__uxk_Object_Object == null)
				{
					r_R__0__uxk_Object_Object = new(this, "#uxk", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__uxk_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__uxk_Object_Object;
			}
		}

		/// <summary>
		/// Void #vxk(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__vxk_Object_Object;
		public virtual RMethod R__0__vxk_Object_Object
		{
			get
			{
				if(r_R__0__vxk_Object_Object == null)
				{
					r_R__0__vxk_Object_Object = new(this, "#vxk", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__vxk_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__vxk_Object_Object;
			}
		}

		/// <summary>
		/// Void #wxk(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__wxk_Object_Object;
		public virtual RMethod R__0__wxk_Object_Object
		{
			get
			{
				if(r_R__0__wxk_Object_Object == null)
				{
					r_R__0__wxk_Object_Object = new(this, "#wxk", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__wxk_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__wxk_Object_Object;
			}
		}

		/// <summary>
		/// Void #XLk(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__XLk_Object_Object;
		public virtual RMethod R__0__XLk_Object_Object
		{
			get
			{
				if(r_R__0__XLk_Object_Object == null)
				{
					r_R__0__XLk_Object_Object = new(this, "#XLk", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__XLk_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__XLk_Object_Object;
			}
		}

		/// <summary>
		/// Void #Dsl(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Dsl_Object_Object;
		public virtual RMethod R__0__Dsl_Object_Object
		{
			get
			{
				if(r_R__0__Dsl_Object_Object == null)
				{
					r_R__0__Dsl_Object_Object = new(this, "#Dsl", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Dsl_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Dsl_Object_Object;
			}
		}

		/// <summary>
		/// Void #YLk(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__YLk_Object_Object;
		public virtual RMethod R__0__YLk_Object_Object
		{
			get
			{
				if(r_R__0__YLk_Object_Object == null)
				{
					r_R__0__YLk_Object_Object = new(this, "#YLk", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__YLk_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__YLk_Object_Object;
			}
		}

		/// <summary>
		/// Void #eIw(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__eIw_Object_Object;
		public virtual RMethod R__0__eIw_Object_Object
		{
			get
			{
				if(r_R__0__eIw_Object_Object == null)
				{
					r_R__0__eIw_Object_Object = new(this, "#eIw", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__eIw_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__eIw_Object_Object;
			}
		}

		/// <summary>
		/// Void #hvl(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__hvl_Object_Object;
		public virtual RMethod R__0__hvl_Object_Object
		{
			get
			{
				if(r_R__0__hvl_Object_Object == null)
				{
					r_R__0__hvl_Object_Object = new(this, "#hvl", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__hvl_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__hvl_Object_Object;
			}
		}

		/// <summary>
		/// Void #ivl(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__ivl_Object_Object;
		public virtual RMethod R__0__ivl_Object_Object
		{
			get
			{
				if(r_R__0__ivl_Object_Object == null)
				{
					r_R__0__ivl_Object_Object = new(this, "#ivl", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__ivl_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__ivl_Object_Object;
			}
		}

		/// <summary>
		/// Void #jvl(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__jvl_Object_Object;
		public virtual RMethod R__0__jvl_Object_Object
		{
			get
			{
				if(r_R__0__jvl_Object_Object == null)
				{
					r_R__0__jvl_Object_Object = new(this, "#jvl", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__jvl_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__jvl_Object_Object;
			}
		}

		/// <summary>
		/// Void #zXl(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__zXl_Object_Object;
		public virtual RMethod R__0__zXl_Object_Object
		{
			get
			{
				if(r_R__0__zXl_Object_Object == null)
				{
					r_R__0__zXl_Object_Object = new(this, "#zXl", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__zXl_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__zXl_Object_Object;
			}
		}

		/// <summary>
		/// Void #i4p()
		/// </summary>
		protected RMethod r_R__0__i4p;
		public virtual RMethod R__0__i4p
		{
			get
			{
				if(r_R__0__i4p == null)
				{
					r_R__0__i4p = new(this, "#i4p", 0);
					r_R__0__i4p.SetBelong(this.instance);
				}
				return r_R__0__i4p;
			}
		}

		/// <summary>
		/// Void #wTr()
		/// </summary>
		protected RMethod r_R__0__wTr;
		public virtual RMethod R__0__wTr
		{
			get
			{
				if(r_R__0__wTr == null)
				{
					r_R__0__wTr = new(this, "#wTr", 0);
					r_R__0__wTr.SetBelong(this.instance);
				}
				return r_R__0__wTr;
			}
		}

		/// <summary>
		/// Void #fIw(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__fIw_Object_Object;
		public virtual RMethod R__0__fIw_Object_Object
		{
			get
			{
				if(r_R__0__fIw_Object_Object == null)
				{
					r_R__0__fIw_Object_Object = new(this, "#fIw", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__fIw_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__fIw_Object_Object;
			}
		}

		/// <summary>
		/// Void #Clx(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Clx_Object_Object;
		public virtual RMethod R__0__Clx_Object_Object
		{
			get
			{
				if(r_R__0__Clx_Object_Object == null)
				{
					r_R__0__Clx_Object_Object = new(this, "#Clx", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Clx_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Clx_Object_Object;
			}
		}

		/// <summary>
		/// Void #5px()
		/// </summary>
		protected RMethod r_R__0__5px;
		public virtual RMethod R__0__5px
		{
			get
			{
				if(r_R__0__5px == null)
				{
					r_R__0__5px = new(this, "#5px", 0);
					r_R__0__5px.SetBelong(this.instance);
				}
				return r_R__0__5px;
			}
		}

		/// <summary>
		/// Void #rdb(Pet)
		/// </summary>
		protected RMethod r_R__0__rdb_Pet;
		public virtual RMethod R__0__rdb_Pet
		{
			get
			{
				if(r_R__0__rdb_Pet == null)
				{
					r_R__0__rdb_Pet = new(this, "#rdb", 0,  ReleactionUtils.GetType("Pet"));
					r_R__0__rdb_Pet.SetBelong(this.instance);
				}
				return r_R__0__rdb_Pet;
			}
		}

		/// <summary>
		/// Void #sdb(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__sdb_ID;
		public virtual RMethod R__0__sdb_ID
		{
			get
			{
				if(r_R__0__sdb_ID == null)
				{
					r_R__0__sdb_ID = new(this, "#sdb", 0, typeof(GameDefineType.ID));
					r_R__0__sdb_ID.SetBelong(this.instance);
				}
				return r_R__0__sdb_ID;
			}
		}

		/// <summary>
		/// Void #tdb()
		/// </summary>
		protected RMethod r_R__0__tdb;
		public virtual RMethod R__0__tdb
		{
			get
			{
				if(r_R__0__tdb == null)
				{
					r_R__0__tdb = new(this, "#tdb", 0);
					r_R__0__tdb.SetBelong(this.instance);
				}
				return r_R__0__tdb;
			}
		}

		/// <summary>
		/// Boolean #udb(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__udb_ID;
		public virtual RMethod R__0__udb_ID
		{
			get
			{
				if(r_R__0__udb_ID == null)
				{
					r_R__0__udb_ID = new(this, "#udb", 0, typeof(GameDefineType.ID));
					r_R__0__udb_ID.SetBelong(this.instance);
				}
				return r_R__0__udb_ID;
			}
		}

		/// <summary>
		/// Pet #vdb(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__vdb_ID;
		public virtual RMethod R__0__vdb_ID
		{
			get
			{
				if(r_R__0__vdb_ID == null)
				{
					r_R__0__vdb_ID = new(this, "#vdb", 0, typeof(GameDefineType.ID));
					r_R__0__vdb_ID.SetBelong(this.instance);
				}
				return r_R__0__vdb_ID;
			}
		}

		/// <summary>
		/// Pet #Kuw(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Kuw_ID;
		public virtual RMethod R__0__Kuw_ID
		{
			get
			{
				if(r_R__0__Kuw_ID == null)
				{
					r_R__0__Kuw_ID = new(this, "#Kuw", 0, typeof(GameDefineType.ID));
					r_R__0__Kuw_ID.SetBelong(this.instance);
				}
				return r_R__0__Kuw_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,Pet] #wdb()
		/// </summary>
		protected RMethod r_R__0__wdb;
		public virtual RMethod R__0__wdb
		{
			get
			{
				if(r_R__0__wdb == null)
				{
					r_R__0__wdb = new(this, "#wdb", 0);
					r_R__0__wdb.SetBelong(this.instance);
				}
				return r_R__0__wdb;
			}
		}

		/// <summary>
		/// Pet #xdb()
		/// </summary>
		protected RMethod r_R__0__xdb;
		public virtual RMethod R__0__xdb
		{
			get
			{
				if(r_R__0__xdb == null)
				{
					r_R__0__xdb = new(this, "#xdb", 0);
					r_R__0__xdb.SetBelong(this.instance);
				}
				return r_R__0__xdb;
			}
		}

		/// <summary>
		/// Pet #rcr()
		/// </summary>
		protected RMethod r_R__0__rcr;
		public virtual RMethod R__0__rcr
		{
			get
			{
				if(r_R__0__rcr == null)
				{
					r_R__0__rcr = new(this, "#rcr", 0);
					r_R__0__rcr.SetBelong(this.instance);
				}
				return r_R__0__rcr;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,Pet] #ydb()
		/// </summary>
		protected RMethod r_R__0__ydb;
		public virtual RMethod R__0__ydb
		{
			get
			{
				if(r_R__0__ydb == null)
				{
					r_R__0__ydb = new(this, "#ydb", 0);
					r_R__0__ydb.SetBelong(this.instance);
				}
				return r_R__0__ydb;
			}
		}

		/// <summary>
		/// Pet #zdb()
		/// </summary>
		protected RMethod r_R__0__zdb;
		public virtual RMethod R__0__zdb
		{
			get
			{
				if(r_R__0__zdb == null)
				{
					r_R__0__zdb = new(this, "#zdb", 0);
					r_R__0__zdb.SetBelong(this.instance);
				}
				return r_R__0__zdb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Pet] #Adb()
		/// </summary>
		protected RMethod r_R__0__Adb;
		public virtual RMethod R__0__Adb
		{
			get
			{
				if(r_R__0__Adb == null)
				{
					r_R__0__Adb = new(this, "#Adb", 0);
					r_R__0__Adb.SetBelong(this.instance);
				}
				return r_R__0__Adb;
			}
		}

		/// <summary>
		/// Void #f4s()
		/// </summary>
		protected RMethod r_R__0__f4s;
		public virtual RMethod R__0__f4s
		{
			get
			{
				if(r_R__0__f4s == null)
				{
					r_R__0__f4s = new(this, "#f4s", 0);
					r_R__0__f4s.SetBelong(this.instance);
				}
				return r_R__0__f4s;
			}
		}

		/// <summary>
		/// Void #rCi(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__rCi_Object_Object;
		public virtual RMethod R__0__rCi_Object_Object
		{
			get
			{
				if(r_R__0__rCi_Object_Object == null)
				{
					r_R__0__rCi_Object_Object = new(this, "#rCi", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__rCi_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__rCi_Object_Object;
			}
		}

		/// <summary>
		/// Void #OLg(Boolean, System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__OLg_Boolean_String_String;
		public virtual RMethod R__0__OLg_Boolean_String_String
		{
			get
			{
				if(r_R__0__OLg_Boolean_String_String == null)
				{
					r_R__0__OLg_Boolean_String_String = new(this, "#OLg", 0, typeof(System.Boolean), typeof(System.String), typeof(System.String));
					r_R__0__OLg_Boolean_String_String.SetBelong(this.instance);
				}
				return r_R__0__OLg_Boolean_String_String;
			}
		}

		/// <summary>
		/// Void #XNs(Boolean)
		/// </summary>
		protected RMethod r_R__0__XNs_Boolean;
		public virtual RMethod R__0__XNs_Boolean
		{
			get
			{
				if(r_R__0__XNs_Boolean == null)
				{
					r_R__0__XNs_Boolean = new(this, "#XNs", 0, typeof(System.Boolean));
					r_R__0__XNs_Boolean.SetBelong(this.instance);
				}
				return r_R__0__XNs_Boolean;
			}
		}

		/// <summary>
		/// Void #WBn(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__WBn_Object_Object;
		public virtual RMethod R__0__WBn_Object_Object
		{
			get
			{
				if(r_R__0__WBn_Object_Object == null)
				{
					r_R__0__WBn_Object_Object = new(this, "#WBn", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__WBn_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__WBn_Object_Object;
			}
		}

		/// <summary>
		/// Void #kUu(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__kUu_Object_Object;
		public virtual RMethod R__0__kUu_Object_Object
		{
			get
			{
				if(r_R__0__kUu_Object_Object == null)
				{
					r_R__0__kUu_Object_Object = new(this, "#kUu", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__kUu_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__kUu_Object_Object;
			}
		}

		/// <summary>
		/// Void #Msx(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Msx_Object_Object;
		public virtual RMethod R__0__Msx_Object_Object
		{
			get
			{
				if(r_R__0__Msx_Object_Object == null)
				{
					r_R__0__Msx_Object_Object = new(this, "#Msx", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Msx_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Msx_Object_Object;
			}
		}

		/// <summary>
		/// System.String #Nsx(System.String)
		/// </summary>
		protected RMethod r_R__0__Nsx_String;
		public virtual RMethod R__0__Nsx_String
		{
			get
			{
				if(r_R__0__Nsx_String == null)
				{
					r_R__0__Nsx_String = new(this, "#Nsx", 0, typeof(System.String));
					r_R__0__Nsx_String.SetBelong(this.instance);
				}
				return r_R__0__Nsx_String;
			}
		}

		/// <summary>
		/// #u.#Ueb #Jdb(#u.#Reb)
		/// </summary>
		protected RMethod r_R__0__Jdb___0__Reb;
		public virtual RMethod R__0__Jdb___0__Reb
		{
			get
			{
				if(r_R__0__Jdb___0__Reb == null)
				{
					r_R__0__Jdb___0__Reb = new(this, "#Jdb", 0,  ReleactionUtils.GetType("#u.#Reb"));
					r_R__0__Jdb___0__Reb.SetBelong(this.instance);
				}
				return r_R__0__Jdb___0__Reb;
			}
		}

		/// <summary>
		/// #bk #Jdb[#bk](#u.#Reb)
		/// </summary>
		protected RMethod r_R__0__Jdb_G__0__bk___0__Reb;
		public virtual RMethod R__0__Jdb_G__0__bk___0__Reb
		{
			get
			{
				if(r_R__0__Jdb_G__0__bk___0__Reb == null)
				{
					r_R__0__Jdb_G__0__bk___0__Reb = new(this, "#Jdb", 1,  ReleactionUtils.GetType("#u.#Reb"));
					r_R__0__Jdb_G__0__bk___0__Reb.SetBelong(this.instance);
				}
				return r_R__0__Jdb_G__0__bk___0__Reb;
			}
		}

		/// <summary>
		/// Void #Kdb(#u.#Reb, #u.#Ueb)
		/// </summary>
		protected RMethod r_R__0__Kdb___0__Reb___0__Ueb;
		public virtual RMethod R__0__Kdb___0__Reb___0__Ueb
		{
			get
			{
				if(r_R__0__Kdb___0__Reb___0__Ueb == null)
				{
					r_R__0__Kdb___0__Reb___0__Ueb = new(this, "#Kdb", 0,  ReleactionUtils.GetType("#u.#Reb"),  ReleactionUtils.GetType("#u.#Ueb"));
					r_R__0__Kdb___0__Reb___0__Ueb.SetBelong(this.instance);
				}
				return r_R__0__Kdb___0__Reb___0__Ueb;
			}
		}

		/// <summary>
		/// Void #yhd()
		/// </summary>
		protected RMethod r_R__0__yhd;
		public virtual RMethod R__0__yhd
		{
			get
			{
				if(r_R__0__yhd == null)
				{
					r_R__0__yhd = new(this, "#yhd", 0);
					r_R__0__yhd.SetBelong(this.instance);
				}
				return r_R__0__yhd;
			}
		}

		/// <summary>
		/// Void #Pdb(System.String, #u.#sOb)
		/// </summary>
		protected RMethod r_R__0__Pdb_String___0__sOb;
		public virtual RMethod R__0__Pdb_String___0__sOb
		{
			get
			{
				if(r_R__0__Pdb_String___0__sOb == null)
				{
					r_R__0__Pdb_String___0__sOb = new(this, "#Pdb", 0, typeof(System.String),  ReleactionUtils.GetType("#u.#sOb"));
					r_R__0__Pdb_String___0__sOb.SetBelong(this.instance);
				}
				return r_R__0__Pdb_String___0__sOb;
			}
		}

		/// <summary>
		/// Void #i4c(System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__i4c_String_Object_Object;
		public virtual RMethod R__0__i4c_String_Object_Object
		{
			get
			{
				if(r_R__0__i4c_String_Object_Object == null)
				{
					r_R__0__i4c_String_Object_Object = new(this, "#i4c", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_R__0__i4c_String_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__i4c_String_Object_Object;
			}
		}

		/// <summary>
		/// Void SetProgressBarOverHead(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetProgressBarOverHead_Object_Object;
		public virtual RMethod RSetProgressBarOverHead_Object_Object
		{
			get
			{
				if(r_RSetProgressBarOverHead_Object_Object == null)
				{
					r_RSetProgressBarOverHead_Object_Object = new(this, "SetProgressBarOverHead", 0, typeof(System.Object), typeof(System.Object));
					r_RSetProgressBarOverHead_Object_Object.SetBelong(this.instance);
				}
				return r_RSetProgressBarOverHead_Object_Object;
			}
		}

		/// <summary>
		/// Void SetProgressBarTipOverHead(System.Object, System.Object)
		/// </summary>
		protected RMethod r_RSetProgressBarTipOverHead_Object_Object;
		public virtual RMethod RSetProgressBarTipOverHead_Object_Object
		{
			get
			{
				if(r_RSetProgressBarTipOverHead_Object_Object == null)
				{
					r_RSetProgressBarTipOverHead_Object_Object = new(this, "SetProgressBarTipOverHead", 0, typeof(System.Object), typeof(System.Object));
					r_RSetProgressBarTipOverHead_Object_Object.SetBelong(this.instance);
				}
				return r_RSetProgressBarTipOverHead_Object_Object;
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


        public R__0__yeb() : base("#u.#yeb")
        {
        }

        public R__0__yeb(System.Object instance) : base("#u.#yeb")
		{
            SetInstance(instance);
		}

        public R__0__yeb(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__yeb(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.Boolean IsInCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInCombat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__meb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__meb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__neb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__neb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__oeb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__oeb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__peb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__peb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPostUpdate(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = ROnPostUpdate_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mhs(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__mhs_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__nhs(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__nhs_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__3nc(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__3nc_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sC(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__sC_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__aVf(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__aVf_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tC(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__tC_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sCi(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__sCi_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__z4f(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__z4f_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__PJ(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__PJ_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetProperty(System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName};
            var ___result = RGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 __0__qeb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__qeb.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void __0__reb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__reb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__seb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__seb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__aeb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__aeb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__teb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__teb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ueb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__ueb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Xtd(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Xtd_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Jhg(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Jhg_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Khg(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Khg_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Lhg(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Lhg_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__AGg(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__AGg_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__YLg(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__YLg_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rVj(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__rVj_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__kdh(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__kdh_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ldh(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__ldh_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rth(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__rth_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__NYj(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__NYj_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__31k(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__31k_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__41k(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__41k_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Mfl(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Mfl_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sxk(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__sxk_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__txk(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__txk_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sth(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__sth_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__7Kh(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__7Kh_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Sei(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Sei_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ini(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Ini_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Jzi(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Jzi_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__eBi(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__eBi_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tCi(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__tCi_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Tei(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Tei_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__geb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__geb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mdh(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__mdh_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Anh(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Anh_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__xDm(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__xDm_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__veb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__veb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean __0__web(System.Int32  @tribe)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tribe};
            var ___result = R__0__web_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Boolean __0__pii(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__pii_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__xeb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__xeb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMoveMsg(System.Single  @spd, UnityEngine.Transform  @trans)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@spd, @trans};
            var ___result = RSendMoveMsg_Single_Transform.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__EZp(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__EZp_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__e1p(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__e1p_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__U8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__U8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__V8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__V8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__W8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__W8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__X8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__X8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__oTn(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__oTn_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__R8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__R8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Cmj(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Cmj_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Y8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Y8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Z8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Z8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__qhf(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__qhf_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__SKf(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__SKf_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Jni(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Jni_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Kni(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Kni_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ndh(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__ndh_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__KYi(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__KYi_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__LYi(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__LYi_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__NYi(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__NYi_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Gxj(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Gxj_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__yDm(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__yDm_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Dmj(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Dmj_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Emj(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Emj_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Fmj(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Fmj_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sVj(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__sVj_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__uxk(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__uxk_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__vxk(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__vxk_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__wxk(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__wxk_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__XLk(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__XLk_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Dsl(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Dsl_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__YLk(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__YLk_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__eIw(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__eIw_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__hvl(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__hvl_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ivl(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__ivl_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__jvl(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__jvl_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__zXl(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__zXl_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__i4p()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__i4p.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__wTr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wTr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__fIw(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__fIw_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Clx(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__Clx_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__5px()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__5px.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__sdb(GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petID};
            var ___result = R__0__sdb_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tdb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__tdb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__udb(GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petID};
            var ___result = R__0__udb_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object __0__vdb(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__vdb_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Kuw(GameDefineType.ID  @careerid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerid};
            var ___result = R__0__Kuw_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__wdb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wdb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__xdb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__xdb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__rcr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__rcr.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__ydb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ydb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__zdb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__zdb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Adb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Adb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__f4s()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__f4s.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rCi(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__rCi_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__OLg(System.Boolean  @bEnable, System.String  @url, System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bEnable, @url, @name};
            var ___result = R__0__OLg_Boolean_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__XNs(System.Boolean  @bEnable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bEnable};
            var ___result = R__0__XNs_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__WBn(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__WBn_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__kUu(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__kUu_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Msx(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Msx_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__Nsx(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = R__0__Nsx_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }





        public virtual void __0__yhd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yhd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__i4c(System.String  @proptertyName, System.Object  @propertyOldValue, System.Object  @propertyNewValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@proptertyName, @propertyOldValue, @propertyNewValue};
            var ___result = R__0__i4c_String_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProgressBarOverHead(System.Object  @olddata, System.Object  @newdata)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@olddata, @newdata};
            var ___result = RSetProgressBarOverHead_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetProgressBarTipOverHead(System.Object  @olddata, System.Object  @newdata)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@olddata, @newdata};
            var ___result = RSetProgressBarTipOverHead_Object_Object.Invoke(___genericsType, ___parameters);

            
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
