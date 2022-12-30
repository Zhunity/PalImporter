using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#9id
	/// </summary>
    public partial class R__0__9id : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.Dictionary`2[GameDefineType.ID,#u.#Bid]] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, R__0__u.R__0__Bid>> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, R__0__u.R__0__Bid>> R__0__a
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,GameDefineType.ID] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RGameDefineType.RID> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RGameDefineType.RID> R__0__b
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,GameDefineType.ID] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RGameDefineType.RID> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RGameDefineType.RID> R__0__d
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,CombineSkillInfo] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCombineSkillInfo> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCombineSkillInfo> R__0__e
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
		/// CombineSkillLevelInfo #f
		/// </summary>
		protected RCombineSkillLevelInfo r___0__f;
		public virtual RCombineSkillLevelInfo R__0__f
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
		protected static RField r___0__g;
		public static RField R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new( ReleactionUtils.GetType("#u.#9id"), "#g");
					r___0__g.SetBelong(null);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,SKILL_CFG] #h
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSKILL_CFG> r___0__h;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSKILL_CFG> R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new(this, "#h");
					r___0__h.SetBelong(this.instance);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.List`1[GameDefineType.ID]] #i
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RGameDefineType.RID>> r___0__i;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RGameDefineType.RID>> R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new(this, "#i");
					r___0__i.SetBelong(this.instance);
				}
				return r___0__i;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,SkillChange] #j
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSkillChange> r___0__j;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSkillChange> R__0__j
		{
			get
			{
				if(r___0__j == null)
				{
					r___0__j = new(this, "#j");
					r___0__j.SetBelong(this.instance);
				}
				return r___0__j;
			}
		}

		/// <summary>
		/// SkillConfigHold #k
		/// </summary>
		protected RSkillConfigHold r___0__k;
		public virtual RSkillConfigHold R__0__k
		{
			get
			{
				if(r___0__k == null)
				{
					r___0__k = new(this, "#k");
					r___0__k.SetBelong(this.instance);
				}
				return r___0__k;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,PET_PRACTICE_CONFIG] #l
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RPET_PRACTICE_CONFIG> r___0__l;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RPET_PRACTICE_CONFIG> R__0__l
		{
			get
			{
				if(r___0__l == null)
				{
					r___0__l = new(this, "#l");
					r___0__l.SetBelong(this.instance);
				}
				return r___0__l;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,ZHULING_CONFIG] #m
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RZHULING_CONFIG> r___0__m;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RZHULING_CONFIG> R__0__m
		{
			get
			{
				if(r___0__m == null)
				{
					r___0__m = new(this, "#m");
					r___0__m.SetBelong(this.instance);
				}
				return r___0__m;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,ZhulingSkillConfig] #n
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RZhulingSkillConfig> r___0__n;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RZhulingSkillConfig> R__0__n
		{
			get
			{
				if(r___0__n == null)
				{
					r___0__n = new(this, "#n");
					r___0__n.SetBelong(this.instance);
				}
				return r___0__n;
			}
		}

		/// <summary>
		/// KeyValueContent #o
		/// </summary>
		protected RKeyValueContent r___0__o;
		public virtual RKeyValueContent R__0__o
		{
			get
			{
				if(r___0__o == null)
				{
					r___0__o = new(this, "#o");
					r___0__o.SetBelong(this.instance);
				}
				return r___0__o;
			}
		}

		/// <summary>
		/// KeyValueContent #p
		/// </summary>
		protected RKeyValueContent r___0__p;
		public virtual RKeyValueContent R__0__p
		{
			get
			{
				if(r___0__p == null)
				{
					r___0__p = new(this, "#p");
					r___0__p.SetBelong(this.instance);
				}
				return r___0__p;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,#Pfb.#Ijg] #q
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, R__0__Pfb.R__0__Ijg> r___0__q;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, R__0__Pfb.R__0__Ijg> R__0__q
		{
			get
			{
				if(r___0__q == null)
				{
					r___0__q = new(this, "#q");
					r___0__q.SetBelong(this.instance);
				}
				return r___0__q;
			}
		}

		/// <summary>
		/// KeyValueContent #r
		/// </summary>
		protected RKeyValueContent r___0__r;
		public virtual RKeyValueContent R__0__r
		{
			get
			{
				if(r___0__r == null)
				{
					r___0__r = new(this, "#r");
					r___0__r.SetBelong(this.instance);
				}
				return r___0__r;
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
		/// Void OnLoadPetSkillsConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPetSkillsConfig_Object;
		public virtual RMethod ROnLoadPetSkillsConfig_Object
		{
			get
			{
				if(r_ROnLoadPetSkillsConfig_Object == null)
				{
					r_ROnLoadPetSkillsConfig_Object = new(this, "OnLoadPetSkillsConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPetSkillsConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPetSkillsConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadCombineSkillConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadCombineSkillConfig_Object;
		public virtual RMethod ROnLoadCombineSkillConfig_Object
		{
			get
			{
				if(r_ROnLoadCombineSkillConfig_Object == null)
				{
					r_ROnLoadCombineSkillConfig_Object = new(this, "OnLoadCombineSkillConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadCombineSkillConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadCombineSkillConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadCombineSkillLevelConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadCombineSkillLevelConfig_Object;
		public virtual RMethod ROnLoadCombineSkillLevelConfig_Object
		{
			get
			{
				if(r_ROnLoadCombineSkillLevelConfig_Object == null)
				{
					r_ROnLoadCombineSkillLevelConfig_Object = new(this, "OnLoadCombineSkillLevelConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadCombineSkillLevelConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadCombineSkillLevelConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadSkillChangeConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadSkillChangeConfig_Object;
		public virtual RMethod ROnLoadSkillChangeConfig_Object
		{
			get
			{
				if(r_ROnLoadSkillChangeConfig_Object == null)
				{
					r_ROnLoadSkillChangeConfig_Object = new(this, "OnLoadSkillChangeConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadSkillChangeConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadSkillChangeConfig_Object;
			}
		}

		/// <summary>
		/// SkillChange #Ous(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Ous_ID;
		public virtual RMethod R__0__Ous_ID
		{
			get
			{
				if(r_R__0__Ous_ID == null)
				{
					r_R__0__Ous_ID = new(this, "#Ous", 0, typeof(GameDefineType.ID));
					r_R__0__Ous_ID.SetBelong(this.instance);
				}
				return r_R__0__Ous_ID;
			}
		}

		/// <summary>
		/// Void OnLoadSkillConfigConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadSkillConfigConfig_Object;
		public virtual RMethod ROnLoadSkillConfigConfig_Object
		{
			get
			{
				if(r_ROnLoadSkillConfigConfig_Object == null)
				{
					r_ROnLoadSkillConfigConfig_Object = new(this, "OnLoadSkillConfigConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadSkillConfigConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadSkillConfigConfig_Object;
			}
		}

		/// <summary>
		/// Void #Cid()
		/// </summary>
		protected RMethod r_R__0__Cid;
		public virtual RMethod R__0__Cid
		{
			get
			{
				if(r_R__0__Cid == null)
				{
					r_R__0__Cid = new(this, "#Cid", 0);
					r_R__0__Cid.SetBelong(this.instance);
				}
				return r_R__0__Cid;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #Did(Int32)
		/// </summary>
		protected RMethod r_R__0__Did_Int32;
		public virtual RMethod R__0__Did_Int32
		{
			get
			{
				if(r_R__0__Did_Int32 == null)
				{
					r_R__0__Did_Int32 = new(this, "#Did", 0, typeof(System.Int32));
					r_R__0__Did_Int32.SetBelong(this.instance);
				}
				return r_R__0__Did_Int32;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #C6q(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__C6q_ID;
		public virtual RMethod R__0__C6q_ID
		{
			get
			{
				if(r_R__0__C6q_ID == null)
				{
					r_R__0__C6q_ID = new(this, "#C6q", 0, typeof(GameDefineType.ID));
					r_R__0__C6q_ID.SetBelong(this.instance);
				}
				return r_R__0__C6q_ID;
			}
		}

		/// <summary>
		/// SKILL_CFG #Fid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Fid_ID;
		public virtual RMethod R__0__Fid_ID
		{
			get
			{
				if(r_R__0__Fid_ID == null)
				{
					r_R__0__Fid_ID = new(this, "#Fid", 0, typeof(GameDefineType.ID));
					r_R__0__Fid_ID.SetBelong(this.instance);
				}
				return r_R__0__Fid_ID;
			}
		}

		/// <summary>
		/// Boolean #Gid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Gid_ID;
		public virtual RMethod R__0__Gid_ID
		{
			get
			{
				if(r_R__0__Gid_ID == null)
				{
					r_R__0__Gid_ID = new(this, "#Gid", 0, typeof(GameDefineType.ID));
					r_R__0__Gid_ID.SetBelong(this.instance);
				}
				return r_R__0__Gid_ID;
			}
		}

		/// <summary>
		/// Void #Iid(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Iid_Object___0__Isb;
		public virtual RMethod R__0__Iid_Object___0__Isb
		{
			get
			{
				if(r_R__0__Iid_Object___0__Isb == null)
				{
					r_R__0__Iid_Object___0__Isb = new(this, "#Iid", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Iid_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Iid_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Pkq(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Pkq_Object___0__Isb;
		public virtual RMethod R__0__Pkq_Object___0__Isb
		{
			get
			{
				if(r_R__0__Pkq_Object___0__Isb == null)
				{
					r_R__0__Pkq_Object___0__Isb = new(this, "#Pkq", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Pkq_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Pkq_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #ZWe()
		/// </summary>
		protected RMethod r_R__0__ZWe;
		public virtual RMethod R__0__ZWe
		{
			get
			{
				if(r_R__0__ZWe == null)
				{
					r_R__0__ZWe = new(this, "#ZWe", 0);
					r_R__0__ZWe.SetBelong(this.instance);
				}
				return r_R__0__ZWe;
			}
		}

		/// <summary>
		/// Boolean #S9d()
		/// </summary>
		protected RMethod r_R__0__S9d;
		public virtual RMethod R__0__S9d
		{
			get
			{
				if(r_R__0__S9d == null)
				{
					r_R__0__S9d = new(this, "#S9d", 0);
					r_R__0__S9d.SetBelong(this.instance);
				}
				return r_R__0__S9d;
			}
		}

		/// <summary>
		/// Void #FEd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__FEd_Object___0__Isb;
		public virtual RMethod R__0__FEd_Object___0__Isb
		{
			get
			{
				if(r_R__0__FEd_Object___0__Isb == null)
				{
					r_R__0__FEd_Object___0__Isb = new(this, "#FEd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__FEd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__FEd_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,GameDefineType.ID] #Jid()
		/// </summary>
		protected RMethod r_R__0__Jid;
		public virtual RMethod R__0__Jid
		{
			get
			{
				if(r_R__0__Jid == null)
				{
					r_R__0__Jid = new(this, "#Jid", 0);
					r_R__0__Jid.SetBelong(this.instance);
				}
				return r_R__0__Jid;
			}
		}

		/// <summary>
		/// #u.#Bid #Kid(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Kid_ID_ID;
		public virtual RMethod R__0__Kid_ID_ID
		{
			get
			{
				if(r_R__0__Kid_ID_ID == null)
				{
					r_R__0__Kid_ID_ID = new(this, "#Kid", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_R__0__Kid_ID_ID.SetBelong(this.instance);
				}
				return r_R__0__Kid_ID_ID;
			}
		}

		/// <summary>
		/// Int32 #gVf(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__gVf_ID;
		public virtual RMethod R__0__gVf_ID
		{
			get
			{
				if(r_R__0__gVf_ID == null)
				{
					r_R__0__gVf_ID = new(this, "#gVf", 0, typeof(GameDefineType.ID));
					r_R__0__gVf_ID.SetBelong(this.instance);
				}
				return r_R__0__gVf_ID;
			}
		}

		/// <summary>
		/// Int32 #hVf(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__hVf_ID;
		public virtual RMethod R__0__hVf_ID
		{
			get
			{
				if(r_R__0__hVf_ID == null)
				{
					r_R__0__hVf_ID = new(this, "#hVf", 0, typeof(GameDefineType.ID));
					r_R__0__hVf_ID.SetBelong(this.instance);
				}
				return r_R__0__hVf_ID;
			}
		}

		/// <summary>
		/// Int32 #Qkq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Qkq_ID;
		public virtual RMethod R__0__Qkq_ID
		{
			get
			{
				if(r_R__0__Qkq_ID == null)
				{
					r_R__0__Qkq_ID = new(this, "#Qkq", 0, typeof(GameDefineType.ID));
					r_R__0__Qkq_ID.SetBelong(this.instance);
				}
				return r_R__0__Qkq_ID;
			}
		}

		/// <summary>
		/// Int32 #Rkq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Rkq_ID;
		public virtual RMethod R__0__Rkq_ID
		{
			get
			{
				if(r_R__0__Rkq_ID == null)
				{
					r_R__0__Rkq_ID = new(this, "#Rkq", 0, typeof(GameDefineType.ID));
					r_R__0__Rkq_ID.SetBelong(this.instance);
				}
				return r_R__0__Rkq_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,#u.#Bid] #Lid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Lid_ID;
		public virtual RMethod R__0__Lid_ID
		{
			get
			{
				if(r_R__0__Lid_ID == null)
				{
					r_R__0__Lid_ID = new(this, "#Lid", 0, typeof(GameDefineType.ID));
					r_R__0__Lid_ID.SetBelong(this.instance);
				}
				return r_R__0__Lid_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,#u.#Bid] #Ytd(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Ytd_ID;
		public virtual RMethod R__0__Ytd_ID
		{
			get
			{
				if(r_R__0__Ytd_ID == null)
				{
					r_R__0__Ytd_ID = new(this, "#Ytd", 0, typeof(GameDefineType.ID));
					r_R__0__Ytd_ID.SetBelong(this.instance);
				}
				return r_R__0__Ytd_ID;
			}
		}

		/// <summary>
		/// Void #Mid()
		/// </summary>
		protected RMethod r_R__0__Mid;
		public virtual RMethod R__0__Mid
		{
			get
			{
				if(r_R__0__Mid == null)
				{
					r_R__0__Mid = new(this, "#Mid", 0);
					r_R__0__Mid.SetBelong(this.instance);
				}
				return r_R__0__Mid;
			}
		}

		/// <summary>
		/// System.String #Nid(System.String)
		/// </summary>
		protected RMethod r_R__0__Nid_String;
		public virtual RMethod R__0__Nid_String
		{
			get
			{
				if(r_R__0__Nid_String == null)
				{
					r_R__0__Nid_String = new(this, "#Nid", 0, typeof(System.String));
					r_R__0__Nid_String.SetBelong(this.instance);
				}
				return r_R__0__Nid_String;
			}
		}

		/// <summary>
		/// System.String #Nid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Nid_ID;
		public virtual RMethod R__0__Nid_ID
		{
			get
			{
				if(r_R__0__Nid_ID == null)
				{
					r_R__0__Nid_ID = new(this, "#Nid", 0, typeof(GameDefineType.ID));
					r_R__0__Nid_ID.SetBelong(this.instance);
				}
				return r_R__0__Nid_ID;
			}
		}

		/// <summary>
		/// Void #Pid(GameDefineType.ID, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__Pid_ID_ID_Int32;
		public virtual RMethod R__0__Pid_ID_ID_Int32
		{
			get
			{
				if(r_R__0__Pid_ID_ID_Int32 == null)
				{
					r_R__0__Pid_ID_ID_Int32 = new(this, "#Pid", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__Pid_ID_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__Pid_ID_ID_Int32;
			}
		}

		/// <summary>
		/// Void #Qid(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Qid_ID_ID;
		public virtual RMethod R__0__Qid_ID_ID
		{
			get
			{
				if(r_R__0__Qid_ID_ID == null)
				{
					r_R__0__Qid_ID_ID = new(this, "#Qid", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_R__0__Qid_ID_ID.SetBelong(this.instance);
				}
				return r_R__0__Qid_ID_ID;
			}
		}

		/// <summary>
		/// Void #Rid(GameDefineType.ID, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__Rid_ID_ID_Int32;
		public virtual RMethod R__0__Rid_ID_ID_Int32
		{
			get
			{
				if(r_R__0__Rid_ID_ID_Int32 == null)
				{
					r_R__0__Rid_ID_ID_Int32 = new(this, "#Rid", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__Rid_ID_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__Rid_ID_ID_Int32;
			}
		}

		/// <summary>
		/// Void #D6q(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__D6q_ID_ID;
		public virtual RMethod R__0__D6q_ID_ID
		{
			get
			{
				if(r_R__0__D6q_ID_ID == null)
				{
					r_R__0__D6q_ID_ID = new(this, "#D6q", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_R__0__D6q_ID_ID.SetBelong(this.instance);
				}
				return r_R__0__D6q_ID_ID;
			}
		}

		/// <summary>
		/// Void #Skq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Skq_ID;
		public virtual RMethod R__0__Skq_ID
		{
			get
			{
				if(r_R__0__Skq_ID == null)
				{
					r_R__0__Skq_ID = new(this, "#Skq", 0, typeof(GameDefineType.ID));
					r_R__0__Skq_ID.SetBelong(this.instance);
				}
				return r_R__0__Skq_ID;
			}
		}

		/// <summary>
		/// Void #Tkq(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__Tkq_ID_Int32;
		public virtual RMethod R__0__Tkq_ID_Int32
		{
			get
			{
				if(r_R__0__Tkq_ID_Int32 == null)
				{
					r_R__0__Tkq_ID_Int32 = new(this, "#Tkq", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__Tkq_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__Tkq_ID_Int32;
			}
		}

		/// <summary>
		/// Void #Tid(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Tid_ID;
		public virtual RMethod R__0__Tid_ID
		{
			get
			{
				if(r_R__0__Tid_ID == null)
				{
					r_R__0__Tid_ID = new(this, "#Tid", 0, typeof(GameDefineType.ID));
					r_R__0__Tid_ID.SetBelong(this.instance);
				}
				return r_R__0__Tid_ID;
			}
		}

		/// <summary>
		/// Void #Whg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Whg_Object___0__Isb;
		public virtual RMethod R__0__Whg_Object___0__Isb
		{
			get
			{
				if(r_R__0__Whg_Object___0__Isb == null)
				{
					r_R__0__Whg_Object___0__Isb = new(this, "#Whg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Whg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Whg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Xid(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Xid_Object___0__Isb;
		public virtual RMethod R__0__Xid_Object___0__Isb
		{
			get
			{
				if(r_R__0__Xid_Object___0__Isb == null)
				{
					r_R__0__Xid_Object___0__Isb = new(this, "#Xid", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Xid_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Xid_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnLoadPetPracticeConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPetPracticeConfig_Object;
		public virtual RMethod ROnLoadPetPracticeConfig_Object
		{
			get
			{
				if(r_ROnLoadPetPracticeConfig_Object == null)
				{
					r_ROnLoadPetPracticeConfig_Object = new(this, "OnLoadPetPracticeConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPetPracticeConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPetPracticeConfig_Object;
			}
		}

		/// <summary>
		/// PET_PRACTICE_CONFIG #wxd(Int32)
		/// </summary>
		protected RMethod r_R__0__wxd_Int32;
		public virtual RMethod R__0__wxd_Int32
		{
			get
			{
				if(r_R__0__wxd_Int32 == null)
				{
					r_R__0__wxd_Int32 = new(this, "#wxd", 0, typeof(System.Int32));
					r_R__0__wxd_Int32.SetBelong(this.instance);
				}
				return r_R__0__wxd_Int32;
			}
		}

		/// <summary>
		/// Void #xxd(Int32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__xxd_Int32_ID;
		public virtual RMethod R__0__xxd_Int32_ID
		{
			get
			{
				if(r_R__0__xxd_Int32_ID == null)
				{
					r_R__0__xxd_Int32_ID = new(this, "#xxd", 0, typeof(System.Int32), typeof(GameDefineType.ID));
					r_R__0__xxd_Int32_ID.SetBelong(this.instance);
				}
				return r_R__0__xxd_Int32_ID;
			}
		}

		/// <summary>
		/// Void #yxd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__yxd_Object___0__Isb;
		public virtual RMethod R__0__yxd_Object___0__Isb
		{
			get
			{
				if(r_R__0__yxd_Object___0__Isb == null)
				{
					r_R__0__yxd_Object___0__Isb = new(this, "#yxd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__yxd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__yxd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void OnLoadZhulingConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadZhulingConfig_Object;
		public virtual RMethod ROnLoadZhulingConfig_Object
		{
			get
			{
				if(r_ROnLoadZhulingConfig_Object == null)
				{
					r_ROnLoadZhulingConfig_Object = new(this, "OnLoadZhulingConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadZhulingConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadZhulingConfig_Object;
			}
		}

		/// <summary>
		/// ZHULING_CONFIG #6td(Int32)
		/// </summary>
		protected RMethod r_R__0__6td_Int32;
		public virtual RMethod R__0__6td_Int32
		{
			get
			{
				if(r_R__0__6td_Int32 == null)
				{
					r_R__0__6td_Int32 = new(this, "#6td", 0, typeof(System.Int32));
					r_R__0__6td_Int32.SetBelong(this.instance);
				}
				return r_R__0__6td_Int32;
			}
		}

		/// <summary>
		/// ZhulingSkillConfig #Udk(Int32)
		/// </summary>
		protected RMethod r_R__0__Udk_Int32;
		public virtual RMethod R__0__Udk_Int32
		{
			get
			{
				if(r_R__0__Udk_Int32 == null)
				{
					r_R__0__Udk_Int32 = new(this, "#Udk", 0, typeof(System.Int32));
					r_R__0__Udk_Int32.SetBelong(this.instance);
				}
				return r_R__0__Udk_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadZhulingSkillConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadZhulingSkillConfig_Object;
		public virtual RMethod ROnLoadZhulingSkillConfig_Object
		{
			get
			{
				if(r_ROnLoadZhulingSkillConfig_Object == null)
				{
					r_ROnLoadZhulingSkillConfig_Object = new(this, "OnLoadZhulingSkillConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadZhulingSkillConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadZhulingSkillConfig_Object;
			}
		}

		/// <summary>
		/// Void #Vdk(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Vdk_Object___0__Isb;
		public virtual RMethod R__0__Vdk_Object___0__Isb
		{
			get
			{
				if(r_R__0__Vdk_Object___0__Isb == null)
				{
					r_R__0__Vdk_Object___0__Isb = new(this, "#Vdk", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Vdk_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Vdk_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Wdk(System.String)
		/// </summary>
		protected RMethod r_R__0__Wdk_String;
		public virtual RMethod R__0__Wdk_String
		{
			get
			{
				if(r_R__0__Wdk_String == null)
				{
					r_R__0__Wdk_String = new(this, "#Wdk", 0, typeof(System.String));
					r_R__0__Wdk_String.SetBelong(this.instance);
				}
				return r_R__0__Wdk_String;
			}
		}

		/// <summary>
		/// Void #Xdk()
		/// </summary>
		protected RMethod r_R__0__Xdk;
		public virtual RMethod R__0__Xdk
		{
			get
			{
				if(r_R__0__Xdk == null)
				{
					r_R__0__Xdk = new(this, "#Xdk", 0);
					r_R__0__Xdk.SetBelong(this.instance);
				}
				return r_R__0__Xdk;
			}
		}

		/// <summary>
		/// Void OnLoadFiveBeadConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadFiveBeadConfig_Object;
		public virtual RMethod ROnLoadFiveBeadConfig_Object
		{
			get
			{
				if(r_ROnLoadFiveBeadConfig_Object == null)
				{
					r_ROnLoadFiveBeadConfig_Object = new(this, "OnLoadFiveBeadConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadFiveBeadConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadFiveBeadConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadFiveBeadCostConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadFiveBeadCostConfig_Object;
		public virtual RMethod ROnLoadFiveBeadCostConfig_Object
		{
			get
			{
				if(r_ROnLoadFiveBeadCostConfig_Object == null)
				{
					r_ROnLoadFiveBeadCostConfig_Object = new(this, "OnLoadFiveBeadCostConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadFiveBeadCostConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadFiveBeadCostConfig_Object;
			}
		}

		/// <summary>
		/// System.String #Xhg(Int32, System.String)
		/// </summary>
		protected RMethod r_R__0__Xhg_Int32_String;
		public virtual RMethod R__0__Xhg_Int32_String
		{
			get
			{
				if(r_R__0__Xhg_Int32_String == null)
				{
					r_R__0__Xhg_Int32_String = new(this, "#Xhg", 0, typeof(System.Int32), typeof(System.String));
					r_R__0__Xhg_Int32_String.SetBelong(this.instance);
				}
				return r_R__0__Xhg_Int32_String;
			}
		}

		/// <summary>
		/// System.String #Yhg(Int32)
		/// </summary>
		protected RMethod r_R__0__Yhg_Int32;
		public virtual RMethod R__0__Yhg_Int32
		{
			get
			{
				if(r_R__0__Yhg_Int32 == null)
				{
					r_R__0__Yhg_Int32 = new(this, "#Yhg", 0, typeof(System.Int32));
					r_R__0__Yhg_Int32.SetBelong(this.instance);
				}
				return r_R__0__Yhg_Int32;
			}
		}

		/// <summary>
		/// Void #reg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__reg_Object___0__Isb;
		public virtual RMethod R__0__reg_Object___0__Isb
		{
			get
			{
				if(r_R__0__reg_Object___0__Isb == null)
				{
					r_R__0__reg_Object___0__Isb = new(this, "#reg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__reg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__reg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #seg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__seg_Object___0__Isb;
		public virtual RMethod R__0__seg_Object___0__Isb
		{
			get
			{
				if(r_R__0__seg_Object___0__Isb == null)
				{
					r_R__0__seg_Object___0__Isb = new(this, "#seg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__seg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__seg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #ueg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__ueg_Object___0__Isb;
		public virtual RMethod R__0__ueg_Object___0__Isb
		{
			get
			{
				if(r_R__0__ueg_Object___0__Isb == null)
				{
					r_R__0__ueg_Object___0__Isb = new(this, "#ueg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__ueg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__ueg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Int32 #Zhg(Int32)
		/// </summary>
		protected RMethod r_R__0__Zhg_Int32;
		public virtual RMethod R__0__Zhg_Int32
		{
			get
			{
				if(r_R__0__Zhg_Int32 == null)
				{
					r_R__0__Zhg_Int32 = new(this, "#Zhg", 0, typeof(System.Int32));
					r_R__0__Zhg_Int32.SetBelong(this.instance);
				}
				return r_R__0__Zhg_Int32;
			}
		}

		/// <summary>
		/// Int32 #0hg(Int32)
		/// </summary>
		protected RMethod r_R__0__0hg_Int32;
		public virtual RMethod R__0__0hg_Int32
		{
			get
			{
				if(r_R__0__0hg_Int32 == null)
				{
					r_R__0__0hg_Int32 = new(this, "#0hg", 0, typeof(System.Int32));
					r_R__0__0hg_Int32.SetBelong(this.instance);
				}
				return r_R__0__0hg_Int32;
			}
		}

		/// <summary>
		/// Single #1hg(Int32)
		/// </summary>
		protected RMethod r_R__0__1hg_Int32;
		public virtual RMethod R__0__1hg_Int32
		{
			get
			{
				if(r_R__0__1hg_Int32 == null)
				{
					r_R__0__1hg_Int32 = new(this, "#1hg", 0, typeof(System.Int32));
					r_R__0__1hg_Int32.SetBelong(this.instance);
				}
				return r_R__0__1hg_Int32;
			}
		}

		/// <summary>
		/// Void #veg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__veg_Object___0__Isb;
		public virtual RMethod R__0__veg_Object___0__Isb
		{
			get
			{
				if(r_R__0__veg_Object___0__Isb == null)
				{
					r_R__0__veg_Object___0__Isb = new(this, "#veg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__veg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__veg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #teg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__teg_Object___0__Isb;
		public virtual RMethod R__0__teg_Object___0__Isb
		{
			get
			{
				if(r_R__0__teg_Object___0__Isb == null)
				{
					r_R__0__teg_Object___0__Isb = new(this, "#teg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__teg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__teg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #mvg(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__mvg_Object___0__Isb;
		public virtual RMethod R__0__mvg_Object___0__Isb
		{
			get
			{
				if(r_R__0__mvg_Object___0__Isb == null)
				{
					r_R__0__mvg_Object___0__Isb = new(this, "#mvg", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__mvg_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__mvg_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #aAi(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__aAi_Object___0__Isb;
		public virtual RMethod R__0__aAi_Object___0__Isb
		{
			get
			{
				if(r_R__0__aAi_Object___0__Isb == null)
				{
					r_R__0__aAi_Object___0__Isb = new(this, "#aAi", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__aAi_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__aAi_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Ukq(System.Collections.Generic.List`1[GameDefineType.ID], System.Collections.Generic.List`1[GameDefineType.ID], System.Collections.Generic.List`1[GameDefineType.ID] ByRef)
		/// </summary>
		protected RMethod r_R__0__Ukq_List_d_ID_p__List_d_ID_p__Out_List_d_ID_p_;
		public virtual RMethod R__0__Ukq_List_d_ID_p__List_d_ID_p__Out_List_d_ID_p_
		{
			get
			{
				if(r_R__0__Ukq_List_d_ID_p__List_d_ID_p__Out_List_d_ID_p_ == null)
				{
					r_R__0__Ukq_List_d_ID_p__List_d_ID_p__Out_List_d_ID_p_ = new(this, "#Ukq", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(GameDefineType.ID)), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(GameDefineType.ID)), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(GameDefineType.ID)).MakeByRefType());
					r_R__0__Ukq_List_d_ID_p__List_d_ID_p__Out_List_d_ID_p_.SetBelong(this.instance);
				}
				return r_R__0__Ukq_List_d_ID_p__List_d_ID_p__Out_List_d_ID_p_;
			}
		}

		/// <summary>
		/// Boolean #Vkq(CombineIds, System.Collections.Generic.List`1[GameDefineType.ID])
		/// </summary>
		protected static RMethod r_R__0__Vkq_CombineIds_List_d_ID_p_;
		public static RMethod R__0__Vkq_CombineIds_List_d_ID_p_
		{
			get
			{
				if(r_R__0__Vkq_CombineIds_List_d_ID_p_ == null)
				{
					r_R__0__Vkq_CombineIds_List_d_ID_p_ = new( ReleactionUtils.GetType("#u.#9id"), "#Vkq", 0, typeof(CombineIds), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(GameDefineType.ID)));
					r_R__0__Vkq_CombineIds_List_d_ID_p_.SetBelong(null);
				}
				return r_R__0__Vkq_CombineIds_List_d_ID_p_;
			}
		}

		/// <summary>
		/// GameDefineType.ID #Wkq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Wkq_ID;
		public virtual RMethod R__0__Wkq_ID
		{
			get
			{
				if(r_R__0__Wkq_ID == null)
				{
					r_R__0__Wkq_ID = new(this, "#Wkq", 0, typeof(GameDefineType.ID));
					r_R__0__Wkq_ID.SetBelong(this.instance);
				}
				return r_R__0__Wkq_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID #Xkq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Xkq_ID;
		public virtual RMethod R__0__Xkq_ID
		{
			get
			{
				if(r_R__0__Xkq_ID == null)
				{
					r_R__0__Xkq_ID = new(this, "#Xkq", 0, typeof(GameDefineType.ID));
					r_R__0__Xkq_ID.SetBelong(this.instance);
				}
				return r_R__0__Xkq_ID;
			}
		}

		/// <summary>
		/// Boolean #Ykq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Ykq_ID;
		public virtual RMethod R__0__Ykq_ID
		{
			get
			{
				if(r_R__0__Ykq_ID == null)
				{
					r_R__0__Ykq_ID = new(this, "#Ykq", 0, typeof(GameDefineType.ID));
					r_R__0__Ykq_ID.SetBelong(this.instance);
				}
				return r_R__0__Ykq_ID;
			}
		}

		/// <summary>
		/// CombineSkillInfo #Zkq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Zkq_ID;
		public virtual RMethod R__0__Zkq_ID
		{
			get
			{
				if(r_R__0__Zkq_ID == null)
				{
					r_R__0__Zkq_ID = new(this, "#Zkq", 0, typeof(GameDefineType.ID));
					r_R__0__Zkq_ID.SetBelong(this.instance);
				}
				return r_R__0__Zkq_ID;
			}
		}

		/// <summary>
		/// Int32 #0kq(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__0kq_ID_ID;
		public virtual RMethod R__0__0kq_ID_ID
		{
			get
			{
				if(r_R__0__0kq_ID_ID == null)
				{
					r_R__0__0kq_ID_ID = new(this, "#0kq", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_R__0__0kq_ID_ID.SetBelong(this.instance);
				}
				return r_R__0__0kq_ID_ID;
			}
		}

		/// <summary>
		/// Int32 #1kq()
		/// </summary>
		protected RMethod r_R__0__1kq;
		public virtual RMethod R__0__1kq
		{
			get
			{
				if(r_R__0__1kq == null)
				{
					r_R__0__1kq = new(this, "#1kq", 0);
					r_R__0__1kq.SetBelong(this.instance);
				}
				return r_R__0__1kq;
			}
		}

		/// <summary>
		/// Boolean #2kq(Int32)
		/// </summary>
		protected static RMethod r_R__0__2kq_Int32;
		public static RMethod R__0__2kq_Int32
		{
			get
			{
				if(r_R__0__2kq_Int32 == null)
				{
					r_R__0__2kq_Int32 = new( ReleactionUtils.GetType("#u.#9id"), "#2kq", 0, typeof(System.Int32));
					r_R__0__2kq_Int32.SetBelong(null);
				}
				return r_R__0__2kq_Int32;
			}
		}

		/// <summary>
		/// Boolean #3kq(Int32)
		/// </summary>
		protected static RMethod r_R__0__3kq_Int32;
		public static RMethod R__0__3kq_Int32
		{
			get
			{
				if(r_R__0__3kq_Int32 == null)
				{
					r_R__0__3kq_Int32 = new( ReleactionUtils.GetType("#u.#9id"), "#3kq", 0, typeof(System.Int32));
					r_R__0__3kq_Int32.SetBelong(null);
				}
				return r_R__0__3kq_Int32;
			}
		}

		/// <summary>
		/// Void #4kq(GameDefineType.ID, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__4kq_ID_ID_Int32;
		public virtual RMethod R__0__4kq_ID_ID_Int32
		{
			get
			{
				if(r_R__0__4kq_ID_ID_Int32 == null)
				{
					r_R__0__4kq_ID_ID_Int32 = new(this, "#4kq", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__4kq_ID_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__4kq_ID_ID_Int32;
			}
		}

		/// <summary>
		/// Int32 #5kq()
		/// </summary>
		protected RMethod r_R__0__5kq;
		public virtual RMethod R__0__5kq
		{
			get
			{
				if(r_R__0__5kq == null)
				{
					r_R__0__5kq = new(this, "#5kq", 0);
					r_R__0__5kq.SetBelong(this.instance);
				}
				return r_R__0__5kq;
			}
		}

		/// <summary>
		/// Int32 #6kq()
		/// </summary>
		protected RMethod r_R__0__6kq;
		public virtual RMethod R__0__6kq
		{
			get
			{
				if(r_R__0__6kq == null)
				{
					r_R__0__6kq = new(this, "#6kq", 0);
					r_R__0__6kq.SetBelong(this.instance);
				}
				return r_R__0__6kq;
			}
		}

		/// <summary>
		/// Int32 #7kq()
		/// </summary>
		protected RMethod r_R__0__7kq;
		public virtual RMethod R__0__7kq
		{
			get
			{
				if(r_R__0__7kq == null)
				{
					r_R__0__7kq = new(this, "#7kq", 0);
					r_R__0__7kq.SetBelong(this.instance);
				}
				return r_R__0__7kq;
			}
		}

		/// <summary>
		/// Int32 #6kq(Int32)
		/// </summary>
		protected RMethod r_R__0__6kq_Int32;
		public virtual RMethod R__0__6kq_Int32
		{
			get
			{
				if(r_R__0__6kq_Int32 == null)
				{
					r_R__0__6kq_Int32 = new(this, "#6kq", 0, typeof(System.Int32));
					r_R__0__6kq_Int32.SetBelong(this.instance);
				}
				return r_R__0__6kq_Int32;
			}
		}

		/// <summary>
		/// GameDefineType.ID #8kq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__8kq_ID;
		public virtual RMethod R__0__8kq_ID
		{
			get
			{
				if(r_R__0__8kq_ID == null)
				{
					r_R__0__8kq_ID = new(this, "#8kq", 0, typeof(GameDefineType.ID));
					r_R__0__8kq_ID.SetBelong(this.instance);
				}
				return r_R__0__8kq_ID;
			}
		}

		/// <summary>
		/// Void OnLoadBeGodConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadBeGodConfig_Object;
		public virtual RMethod ROnLoadBeGodConfig_Object
		{
			get
			{
				if(r_ROnLoadBeGodConfig_Object == null)
				{
					r_ROnLoadBeGodConfig_Object = new(this, "OnLoadBeGodConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadBeGodConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadBeGodConfig_Object;
			}
		}

		/// <summary>
		/// System.String #Plx(Int32, System.String)
		/// </summary>
		protected RMethod r_R__0__Plx_Int32_String;
		public virtual RMethod R__0__Plx_Int32_String
		{
			get
			{
				if(r_R__0__Plx_Int32_String == null)
				{
					r_R__0__Plx_Int32_String = new(this, "#Plx", 0, typeof(System.Int32), typeof(System.String));
					r_R__0__Plx_Int32_String.SetBelong(this.instance);
				}
				return r_R__0__Plx_Int32_String;
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


        public R__0__9id() : base("#u.#9id")
        {
        }

        public R__0__9id(System.Object instance) : base("#u.#9id")
		{
            SetInstance(instance);
		}

        public R__0__9id(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__9id(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__yhd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yhd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadPetSkillsConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadPetSkillsConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadCombineSkillConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadCombineSkillConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadCombineSkillLevelConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadCombineSkillLevelConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadSkillChangeConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadSkillChangeConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual SkillChange __0__Ous(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__Ous_ID.Invoke(___genericsType, ___parameters);

            return (SkillChange)___result;
        }


        public virtual void OnLoadSkillConfigConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadSkillConfigConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Cid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Cid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<GameDefineType.ID> __0__Did(System.Int32  @career)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@career};
            var ___result = R__0__Did_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }


        public virtual System.Collections.Generic.List<GameDefineType.ID> __0__C6q(GameDefineType.ID  @career)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@career};
            var ___result = R__0__C6q_ID.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }


        public virtual SKILL_CFG __0__Fid(GameDefineType.ID  @skillID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skillID};
            var ___result = R__0__Fid_ID.Invoke(___genericsType, ___parameters);

            return (SKILL_CFG)___result;
        }


        public virtual System.Boolean __0__Gid(GameDefineType.ID  @skillID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skillID};
            var ___result = R__0__Gid_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual void __0__ZWe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ZWe.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__S9d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__S9d.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Collections.Generic.Dictionary<System.Int32, GameDefineType.ID> __0__Jid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Jid.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.Int32, GameDefineType.ID>)___result;
        }


        public virtual System.Object __0__Kid(GameDefineType.ID  @owner, GameDefineType.ID  @skillID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@owner, @skillID};
            var ___result = R__0__Kid_ID_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 __0__gVf(GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petID};
            var ___result = R__0__gVf_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__hVf(GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petID};
            var ___result = R__0__hVf_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__Qkq(GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petID};
            var ___result = R__0__Qkq_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__Rkq(GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petID};
            var ___result = R__0__Rkq_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object __0__Lid(GameDefineType.ID  @owner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@owner};
            var ___result = R__0__Lid_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Ytd(GameDefineType.ID  @owner)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@owner};
            var ___result = R__0__Ytd_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__Mid()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Mid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__Nid(System.String  @iconName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@iconName};
            var ___result = R__0__Nid_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__Nid(GameDefineType.ID  @skillID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skillID};
            var ___result = R__0__Nid_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void __0__Pid(GameDefineType.ID  @petID, GameDefineType.ID  @skill, System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petID, @skill, @idx};
            var ___result = R__0__Pid_ID_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Qid(GameDefineType.ID  @skill, GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@skill, @petID};
            var ___result = R__0__Qid_ID_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Rid(GameDefineType.ID  @idSkill, GameDefineType.ID  @petID, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill, @petID, @type};
            var ___result = R__0__Rid_ID_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__D6q(GameDefineType.ID  @idSkill, GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill, @petID};
            var ___result = R__0__D6q_ID_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Skq(GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = R__0__Skq_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Tkq(GameDefineType.ID  @idPet, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idPet, @type};
            var ___result = R__0__Tkq_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Tid(GameDefineType.ID  @idPet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idPet};
            var ___result = R__0__Tid_ID.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void OnLoadPetPracticeConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadPetPracticeConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual PET_PRACTICE_CONFIG __0__wxd(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__wxd_Int32.Invoke(___genericsType, ___parameters);

            return (PET_PRACTICE_CONFIG)___result;
        }


        public virtual void __0__xxd(System.Int32  @mode, GameDefineType.ID  @petID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mode, @petID};
            var ___result = R__0__xxd_Int32_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void OnLoadZhulingConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadZhulingConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual ZHULING_CONFIG __0__6td(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__6td_Int32.Invoke(___genericsType, ___parameters);

            return (ZHULING_CONFIG)___result;
        }


        public virtual ZhulingSkillConfig __0__Udk(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__Udk_Int32.Invoke(___genericsType, ___parameters);

            return (ZhulingSkillConfig)___result;
        }


        public virtual void OnLoadZhulingSkillConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadZhulingSkillConfig_Object.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Wdk(System.String  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__Wdk_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Xdk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Xdk.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadFiveBeadConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadFiveBeadConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadFiveBeadCostConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadFiveBeadCostConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__Xhg(System.Int32  @type, System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @propName};
            var ___result = R__0__Xhg_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String __0__Yhg(System.Int32  @curTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@curTime};
            var ___result = R__0__Yhg_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }





        public virtual System.Int32 __0__Zhg(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = R__0__Zhg_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__0hg(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = R__0__0hg_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single __0__1hg(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = R__0__1hg_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }






        public virtual void __0__Ukq(System.Collections.Generic.List<GameDefineType.ID>  @listCareer, System.Collections.Generic.List<GameDefineType.ID>  @oblist, out System.Collections.Generic.List<GameDefineType.ID>  @listCombineSkill)
        {
			listCombineSkill = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listCareer, @oblist, @listCombineSkill};
            var ___result = R__0__Ukq_List_d_ID_p__List_d_ID_p__Out_List_d_ID_p_.Invoke(___genericsType, ___parameters);
			listCombineSkill = (System.Collections.Generic.List<GameDefineType.ID>)___parameters[2];

            
        }


        public static System.Boolean __0__Vkq(CombineIds  @combineIds, System.Collections.Generic.List<GameDefineType.ID>  @listCareer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combineIds, @listCareer};
            var ___result = R__0__Vkq_CombineIds_List_d_ID_p_.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual GameDefineType.ID __0__Wkq(GameDefineType.ID  @idCareer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idCareer};
            var ___result = R__0__Wkq_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual GameDefineType.ID __0__Xkq(GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = R__0__Xkq_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.Boolean __0__Ykq(GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = R__0__Ykq_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual CombineSkillInfo __0__Zkq(GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = R__0__Zkq_ID.Invoke(___genericsType, ___parameters);

            return (CombineSkillInfo)___result;
        }


        public virtual System.Int32 __0__0kq(GameDefineType.ID  @idPet, GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idPet, @idSkill};
            var ___result = R__0__0kq_ID_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__1kq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__1kq.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean __0__2kq(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = R__0__2kq_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean __0__3kq(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = R__0__3kq_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__4kq(GameDefineType.ID  @idPet, GameDefineType.ID  @idCareer, System.Int32  @newLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idPet, @idCareer, @newLevel};
            var ___result = R__0__4kq_ID_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__5kq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__5kq.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__6kq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__6kq.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__7kq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__7kq.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__6kq(System.Int32  @levelNow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@levelNow};
            var ___result = R__0__6kq_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual GameDefineType.ID __0__8kq(GameDefineType.ID  @idSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idSkill};
            var ___result = R__0__8kq_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual void OnLoadBeGodConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadBeGodConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String __0__Plx(System.Int32  @id, System.String  @subKey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @subKey};
            var ___result = R__0__Plx_Int32_String.Invoke(___genericsType, ___parameters);

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
