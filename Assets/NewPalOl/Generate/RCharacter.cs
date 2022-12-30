using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// Character
	/// </summary>
    public partial class RCharacter : RMember //
    {

		/// <summary>
		/// GameDefineType.ID #a
		/// </summary>
		protected RGameDefineType.RID r___0__a;
		public virtual RGameDefineType.RID R__0__a
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,Pet] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RPet> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RPet> R__0__d
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
		/// CreatureBehav #e
		/// </summary>
		protected RCreatureBehav r___0__e;
		public virtual RCreatureBehav R__0__e
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
		/// Void #Bdb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Bdb_Object_Object;
		public virtual RMethod R__0__Bdb_Object_Object
		{
			get
			{
				if(r_R__0__Bdb_Object_Object == null)
				{
					r_R__0__Bdb_Object_Object = new(this, "#Bdb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Bdb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Bdb_Object_Object;
			}
		}

		/// <summary>
		/// Void #Cdb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Cdb_Object_Object;
		public virtual RMethod R__0__Cdb_Object_Object
		{
			get
			{
				if(r_R__0__Cdb_Object_Object == null)
				{
					r_R__0__Cdb_Object_Object = new(this, "#Cdb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Cdb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Cdb_Object_Object;
			}
		}

		/// <summary>
		/// Void #Ddb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Ddb_Object_Object;
		public virtual RMethod R__0__Ddb_Object_Object
		{
			get
			{
				if(r_R__0__Ddb_Object_Object == null)
				{
					r_R__0__Ddb_Object_Object = new(this, "#Ddb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Ddb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Ddb_Object_Object;
			}
		}

		/// <summary>
		/// Void #Edb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Edb_Object_Object;
		public virtual RMethod R__0__Edb_Object_Object
		{
			get
			{
				if(r_R__0__Edb_Object_Object == null)
				{
					r_R__0__Edb_Object_Object = new(this, "#Edb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Edb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Edb_Object_Object;
			}
		}

		/// <summary>
		/// Void #RYb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__RYb_Object_Object;
		public virtual RMethod R__0__RYb_Object_Object
		{
			get
			{
				if(r_R__0__RYb_Object_Object == null)
				{
					r_R__0__RYb_Object_Object = new(this, "#RYb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__RYb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__RYb_Object_Object;
			}
		}

		/// <summary>
		/// Void #LMc(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__LMc_Object_Object;
		public virtual RMethod R__0__LMc_Object_Object
		{
			get
			{
				if(r_R__0__LMc_Object_Object == null)
				{
					r_R__0__LMc_Object_Object = new(this, "#LMc", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__LMc_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__LMc_Object_Object;
			}
		}

		/// <summary>
		/// Void #O8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__O8d_Object_Object;
		public virtual RMethod R__0__O8d_Object_Object
		{
			get
			{
				if(r_R__0__O8d_Object_Object == null)
				{
					r_R__0__O8d_Object_Object = new(this, "#O8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__O8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__O8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #P8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__P8d_Object_Object;
		public virtual RMethod R__0__P8d_Object_Object
		{
			get
			{
				if(r_R__0__P8d_Object_Object == null)
				{
					r_R__0__P8d_Object_Object = new(this, "#P8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__P8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__P8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #Tkf(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Tkf_Object_Object;
		public virtual RMethod R__0__Tkf_Object_Object
		{
			get
			{
				if(r_R__0__Tkf_Object_Object == null)
				{
					r_R__0__Tkf_Object_Object = new(this, "#Tkf", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Tkf_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Tkf_Object_Object;
			}
		}

		/// <summary>
		/// Void #jdh(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__jdh_Object_Object;
		public virtual RMethod R__0__jdh_Object_Object
		{
			get
			{
				if(r_R__0__jdh_Object_Object == null)
				{
					r_R__0__jdh_Object_Object = new(this, "#jdh", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__jdh_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__jdh_Object_Object;
			}
		}

		/// <summary>
		/// Void #Rei(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Rei_Object_Object;
		public virtual RMethod R__0__Rei_Object_Object
		{
			get
			{
				if(r_R__0__Rei_Object_Object == null)
				{
					r_R__0__Rei_Object_Object = new(this, "#Rei", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Rei_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Rei_Object_Object;
			}
		}

		/// <summary>
		/// Void #6Kh(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__6Kh_Object_Object;
		public virtual RMethod R__0__6Kh_Object_Object
		{
			get
			{
				if(r_R__0__6Kh_Object_Object == null)
				{
					r_R__0__6Kh_Object_Object = new(this, "#6Kh", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__6Kh_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__6Kh_Object_Object;
			}
		}

		/// <summary>
		/// Void #Q8d(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Q8d_Object_Object;
		public virtual RMethod R__0__Q8d_Object_Object
		{
			get
			{
				if(r_R__0__Q8d_Object_Object == null)
				{
					r_R__0__Q8d_Object_Object = new(this, "#Q8d", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Q8d_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Q8d_Object_Object;
			}
		}

		/// <summary>
		/// Void #Fdb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Fdb_Object_Object;
		public virtual RMethod R__0__Fdb_Object_Object
		{
			get
			{
				if(r_R__0__Fdb_Object_Object == null)
				{
					r_R__0__Fdb_Object_Object = new(this, "#Fdb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Fdb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Fdb_Object_Object;
			}
		}

		/// <summary>
		/// Void #Gdb(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Gdb_Object_Object;
		public virtual RMethod R__0__Gdb_Object_Object
		{
			get
			{
				if(r_R__0__Gdb_Object_Object == null)
				{
					r_R__0__Gdb_Object_Object = new(this, "#Gdb", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Gdb_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Gdb_Object_Object;
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
		/// Void #g4s(System.Object, #u.#egb)
		/// </summary>
		protected RMethod r_R__0__g4s_Object___0__egb;
		public virtual RMethod R__0__g4s_Object___0__egb
		{
			get
			{
				if(r_R__0__g4s_Object___0__egb == null)
				{
					r_R__0__g4s_Object___0__egb = new(this, "#g4s", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#egb"));
					r_R__0__g4s_Object___0__egb.SetBelong(this.instance);
				}
				return r_R__0__g4s_Object___0__egb;
			}
		}

		/// <summary>
		/// Void #Hni(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__Hni_Object_Object;
		public virtual RMethod R__0__Hni_Object_Object
		{
			get
			{
				if(r_R__0__Hni_Object_Object == null)
				{
					r_R__0__Hni_Object_Object = new(this, "#Hni", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__Hni_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__Hni_Object_Object;
			}
		}

		/// <summary>
		/// Void OnUpdateWuduBeast(System.Object, System.Object)
		/// </summary>
		protected RMethod r_ROnUpdateWuduBeast_Object_Object;
		public virtual RMethod ROnUpdateWuduBeast_Object_Object
		{
			get
			{
				if(r_ROnUpdateWuduBeast_Object_Object == null)
				{
					r_ROnUpdateWuduBeast_Object_Object = new(this, "OnUpdateWuduBeast", 0, typeof(System.Object), typeof(System.Object));
					r_ROnUpdateWuduBeast_Object_Object.SetBelong(this.instance);
				}
				return r_ROnUpdateWuduBeast_Object_Object;
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


        public RCharacter() : base("Character")
        {
        }

        public RCharacter(System.Object instance) : base("Character")
		{
            SetInstance(instance);
		}

        public RCharacter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCharacter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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


        public virtual System.Boolean IsInCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInCombat.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__Bdb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Bdb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Cdb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Cdb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ddb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Ddb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Edb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Edb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__RYb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__RYb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__LMc(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__LMc_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__O8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__O8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__P8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__P8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Tkf(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Tkf_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__jdh(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__jdh_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Rei(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Rei_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__6Kh(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__6Kh_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Q8d(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Q8d_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Fdb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Fdb_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Gdb(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Gdb_Object_Object.Invoke(___genericsType, ___parameters);

            
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



        public virtual void __0__Hni(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__Hni_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnUpdateWuduBeast(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = ROnUpdateWuduBeast_Object_Object.Invoke(___genericsType, ___parameters);

            
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





        public virtual System.Object GetProperty(System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propName};
            var ___result = RGetProperty_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
