using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CombatEvent
	/// </summary>
    public partial class RCombatEvent : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,Fighter] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RFighter> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RFighter> R__0__a
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
		/// System.Collections.Generic.Queue`1[CCommmand] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RQueue<RCCommmand> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RQueue<RCCommmand> R__0__b
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
		/// System.Collections.Generic.List`1[UnityEngine.GameObject] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> R__0__c
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
		/// GameDefineType.ID #d
		/// </summary>
		protected RGameDefineType.RID r___0__d;
		public virtual RGameDefineType.RID R__0__d
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
		/// GameDefineType.ID #e
		/// </summary>
		protected RGameDefineType.RID r___0__e;
		public virtual RGameDefineType.RID R__0__e
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
		/// System.Int32 #h
		/// </summary>
		protected RField r___0__h;
		public virtual RField R__0__h
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
		/// System.Collections.Generic.List`1[GameDefineType.ID] #i
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r___0__i;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R__0__i
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
		/// System.Boolean #j
		/// </summary>
		protected RField r___0__j;
		public virtual RField R__0__j
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
		/// System.Boolean #k
		/// </summary>
		protected RField r___0__k;
		public virtual RField R__0__k
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
		/// System.Int32 #l
		/// </summary>
		protected RField r___0__l;
		public virtual RField R__0__l
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
		/// CombatAreaInfo #m
		/// </summary>
		protected RCombatAreaInfo r___0__m;
		public virtual RCombatAreaInfo R__0__m
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
		/// UnityEngine.GameObject #n
		/// </summary>
		protected RUnityEngine.RGameObject r___0__n;
		public virtual RUnityEngine.RGameObject R__0__n
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
		/// CombatStatus #o
		/// </summary>
		protected RField r___0__o;
		public virtual RField R__0__o
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
		/// GameDefineType.ID #p
		/// </summary>
		protected RGameDefineType.RID r___0__p;
		public virtual RGameDefineType.RID R__0__p
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
		/// Fighter #q
		/// </summary>
		protected RFighter r___0__q;
		public virtual RFighter R__0__q
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
		/// System.Boolean #r
		/// </summary>
		protected RField r___0__r;
		public virtual RField R__0__r
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
		/// UnityEngine.Vector3 #s
		/// </summary>
		protected RUnityEngine.RVector3 r___0__s;
		public virtual RUnityEngine.RVector3 R__0__s
		{
			get
			{
				if(r___0__s == null)
				{
					r___0__s = new(this, "#s");
					r___0__s.SetBelong(this.instance);
				}
				return r___0__s;
			}
		}

		/// <summary>
		/// UnityEngine.Quaternion #t
		/// </summary>
		protected RUnityEngine.RQuaternion r___0__t;
		public virtual RUnityEngine.RQuaternion R__0__t
		{
			get
			{
				if(r___0__t == null)
				{
					r___0__t = new(this, "#t");
					r___0__t.SetBelong(this.instance);
				}
				return r___0__t;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #u
		/// </summary>
		protected static RUnityEngine.RGameObject r___0__u;
		public static RUnityEngine.RGameObject R__0__u
		{
			get
			{
				if(r___0__u == null)
				{
					r___0__u = new( ReleactionUtils.GetType("CombatEvent"), "#u");
					r___0__u.SetBelong(null);
				}
				return r___0__u;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.GameObject] #v
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> r___0__v;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> R__0__v
		{
			get
			{
				if(r___0__v == null)
				{
					r___0__v = new(this, "#v");
					r___0__v.SetBelong(this.instance);
				}
				return r___0__v;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] #w
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__w;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__w
		{
			get
			{
				if(r___0__w == null)
				{
					r___0__w = new(this, "#w");
					r___0__w.SetBelong(this.instance);
				}
				return r___0__w;
			}
		}

		/// <summary>
		/// System.Single #x
		/// </summary>
		protected RField r___0__x;
		public virtual RField R__0__x
		{
			get
			{
				if(r___0__x == null)
				{
					r___0__x = new(this, "#x");
					r___0__x.SetBelong(this.instance);
				}
				return r___0__x;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] #y
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__y;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__y
		{
			get
			{
				if(r___0__y == null)
				{
					r___0__y = new(this, "#y");
					r___0__y.SetBelong(this.instance);
				}
				return r___0__y;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.UInt32,System.Collections.Generic.List`1[System.String]] #z
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RField>> r___0__z;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RField>> R__0__z
		{
			get
			{
				if(r___0__z == null)
				{
					r___0__z = new(this, "#z");
					r___0__z.SetBelong(this.instance);
				}
				return r___0__z;
			}
		}

		/// <summary>
		/// System.Boolean #A
		/// </summary>
		protected RField r___0__A;
		public virtual RField R__0__A
		{
			get
			{
				if(r___0__A == null)
				{
					r___0__A = new(this, "#A");
					r___0__A.SetBelong(this.instance);
				}
				return r___0__A;
			}
		}

		/// <summary>
		/// System.Single #B
		/// </summary>
		protected RField r___0__B;
		public virtual RField R__0__B
		{
			get
			{
				if(r___0__B == null)
				{
					r___0__B = new(this, "#B");
					r___0__B.SetBelong(this.instance);
				}
				return r___0__B;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #C
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__C;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__C
		{
			get
			{
				if(r___0__C == null)
				{
					r___0__C = new( ReleactionUtils.GetType("CombatEvent"), "#C");
					r___0__C.SetBelong(null);
				}
				return r___0__C;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Int32] #D
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__D;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__D
		{
			get
			{
				if(r___0__D == null)
				{
					r___0__D = new( ReleactionUtils.GetType("CombatEvent"), "#D");
					r___0__D.SetBelong(null);
				}
				return r___0__D;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 m_CombatAreaPosition
		/// </summary>
		protected static RUnityEngine.RVector3 r_R__0__5Vb;
		public static RUnityEngine.RVector3 R__0__5Vb
		{
			get
			{
				if(r_R__0__5Vb == null)
				{
					r_R__0__5Vb = new( ReleactionUtils.GetType("CombatEvent"), "m_CombatAreaPosition", -1);
					r_R__0__5Vb.SetBelong(null);
				}
				return r_R__0__5Vb;
			}
		}

		/// <summary>
		/// MyGUICombatMenuWnd m_CombatMenu
		/// </summary>
		protected RMyGUICombatMenuWnd r_R__0__u9;
		public virtual RMyGUICombatMenuWnd R__0__u9
		{
			get
			{
				if(r_R__0__u9 == null)
				{
					r_R__0__u9 = new(this, "m_CombatMenu", -1);
					r_R__0__u9.SetBelong(this.instance);
				}
				return r_R__0__u9;
			}
		}

		/// <summary>
		/// CombatStatus m_CurrentStatus
		/// </summary>
		protected RProperty r_R__0__kqd;
		public virtual RProperty R__0__kqd
		{
			get
			{
				if(r_R__0__kqd == null)
				{
					r_R__0__kqd = new(this, "m_CurrentStatus", -1);
					r_R__0__kqd.SetBelong(this.instance);
				}
				return r_R__0__kqd;
			}
		}

		/// <summary>
		/// Fighter m_MyFighter
		/// </summary>
		protected RFighter r_R__0__v9;
		public virtual RFighter R__0__v9
		{
			get
			{
				if(r_R__0__v9 == null)
				{
					r_R__0__v9 = new(this, "m_MyFighter", -1);
					r_R__0__v9.SetBelong(this.instance);
				}
				return r_R__0__v9;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,Fighter] AllFighters
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RFighter> r_R__0__Tab;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RFighter> R__0__Tab
		{
			get
			{
				if(r_R__0__Tab == null)
				{
					r_R__0__Tab = new(this, "AllFighters", -1);
					r_R__0__Tab.SetBelong(this.instance);
				}
				return r_R__0__Tab;
			}
		}

		/// <summary>
		/// Void #w9()
		/// </summary>
		protected RMethod r_R__0__w9;
		public virtual RMethod R__0__w9
		{
			get
			{
				if(r_R__0__w9 == null)
				{
					r_R__0__w9 = new(this, "#w9", 0);
					r_R__0__w9.SetBelong(this.instance);
				}
				return r_R__0__w9;
			}
		}

		/// <summary>
		/// CombatStatus #x9()
		/// </summary>
		protected RMethod r_R__0__x9;
		public virtual RMethod R__0__x9
		{
			get
			{
				if(r_R__0__x9 == null)
				{
					r_R__0__x9 = new(this, "#x9", 0);
					r_R__0__x9.SetBelong(this.instance);
				}
				return r_R__0__x9;
			}
		}

		/// <summary>
		/// Void #v7()
		/// </summary>
		protected RMethod r_R__0__v7;
		public virtual RMethod R__0__v7
		{
			get
			{
				if(r_R__0__v7 == null)
				{
					r_R__0__v7 = new(this, "#v7", 0);
					r_R__0__v7.SetBelong(this.instance);
				}
				return r_R__0__v7;
			}
		}

		/// <summary>
		/// Void #y9(Fighter)
		/// </summary>
		protected RMethod r_R__0__y9_Fighter;
		public virtual RMethod R__0__y9_Fighter
		{
			get
			{
				if(r_R__0__y9_Fighter == null)
				{
					r_R__0__y9_Fighter = new(this, "#y9", 0,  ReleactionUtils.GetType("Fighter"));
					r_R__0__y9_Fighter.SetBelong(this.instance);
				}
				return r_R__0__y9_Fighter;
			}
		}

		/// <summary>
		/// Void UnRegisterFighter(GameDefineType.ID, Boolean)
		/// </summary>
		protected RMethod r_RUnRegisterFighter_ID_Boolean;
		public virtual RMethod RUnRegisterFighter_ID_Boolean
		{
			get
			{
				if(r_RUnRegisterFighter_ID_Boolean == null)
				{
					r_RUnRegisterFighter_ID_Boolean = new(this, "UnRegisterFighter", 0, typeof(GameDefineType.ID), typeof(System.Boolean));
					r_RUnRegisterFighter_ID_Boolean.SetBelong(this.instance);
				}
				return r_RUnRegisterFighter_ID_Boolean;
			}
		}

		/// <summary>
		/// Void #z9()
		/// </summary>
		protected RMethod r_R__0__z9;
		public virtual RMethod R__0__z9
		{
			get
			{
				if(r_R__0__z9 == null)
				{
					r_R__0__z9 = new(this, "#z9", 0);
					r_R__0__z9.SetBelong(this.instance);
				}
				return r_R__0__z9;
			}
		}

		/// <summary>
		/// Void #A9()
		/// </summary>
		protected RMethod r_R__0__A9;
		public virtual RMethod R__0__A9
		{
			get
			{
				if(r_R__0__A9 == null)
				{
					r_R__0__A9 = new(this, "#A9", 0);
					r_R__0__A9.SetBelong(this.instance);
				}
				return r_R__0__A9;
			}
		}

		/// <summary>
		/// Void #B9(CCommmand)
		/// </summary>
		protected RMethod r_R__0__B9_CCommmand;
		public virtual RMethod R__0__B9_CCommmand
		{
			get
			{
				if(r_R__0__B9_CCommmand == null)
				{
					r_R__0__B9_CCommmand = new(this, "#B9", 0,  ReleactionUtils.GetType("CCommmand"));
					r_R__0__B9_CCommmand.SetBelong(this.instance);
				}
				return r_R__0__B9_CCommmand;
			}
		}

		/// <summary>
		/// Boolean #W8(System.String, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_R__0__W8_String_String_Boolean_Boolean;
		public virtual RMethod R__0__W8_String_String_Boolean_Boolean
		{
			get
			{
				if(r_R__0__W8_String_String_Boolean_Boolean == null)
				{
					r_R__0__W8_String_String_Boolean_Boolean = new(this, "#W8", 0, typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_R__0__W8_String_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_R__0__W8_String_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #C9(UnityEngine.GameObject, UnityEngine.Texture2D, UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_R__0__C9_GameObject_Texture2D_Vector3;
		public virtual RMethod R__0__C9_GameObject_Texture2D_Vector3
		{
			get
			{
				if(r_R__0__C9_GameObject_Texture2D_Vector3 == null)
				{
					r_R__0__C9_GameObject_Texture2D_Vector3 = new(this, "#C9", 0, typeof(UnityEngine.GameObject), typeof(UnityEngine.Texture2D), typeof(UnityEngine.Vector3));
					r_R__0__C9_GameObject_Texture2D_Vector3.SetBelong(this.instance);
				}
				return r_R__0__C9_GameObject_Texture2D_Vector3;
			}
		}

		/// <summary>
		/// Void #D9(GameDefineType.ID, Int32, EffectResult, Int32)
		/// </summary>
		protected RMethod r_R__0__D9_ID_Int32_EffectResult_Int32;
		public virtual RMethod R__0__D9_ID_Int32_EffectResult_Int32
		{
			get
			{
				if(r_R__0__D9_ID_Int32_EffectResult_Int32 == null)
				{
					r_R__0__D9_ID_Int32_EffectResult_Int32 = new(this, "#D9", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(EffectResult), typeof(System.Int32));
					r_R__0__D9_ID_Int32_EffectResult_Int32.SetBelong(this.instance);
				}
				return r_R__0__D9_ID_Int32_EffectResult_Int32;
			}
		}

		/// <summary>
		/// Void #E9(GameDefineType.ID, Boolean, System.String, Boolean)
		/// </summary>
		protected RMethod r_R__0__E9_ID_Boolean_String_Boolean;
		public virtual RMethod R__0__E9_ID_Boolean_String_Boolean
		{
			get
			{
				if(r_R__0__E9_ID_Boolean_String_Boolean == null)
				{
					r_R__0__E9_ID_Boolean_String_Boolean = new(this, "#E9", 0, typeof(GameDefineType.ID), typeof(System.Boolean), typeof(System.String), typeof(System.Boolean));
					r_R__0__E9_ID_Boolean_String_Boolean.SetBelong(this.instance);
				}
				return r_R__0__E9_ID_Boolean_String_Boolean;
			}
		}

		/// <summary>
		/// Void #F9(GameDefineType.ID, System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__F9_ID_String_String;
		public virtual RMethod R__0__F9_ID_String_String
		{
			get
			{
				if(r_R__0__F9_ID_String_String == null)
				{
					r_R__0__F9_ID_String_String = new(this, "#F9", 0, typeof(GameDefineType.ID), typeof(System.String), typeof(System.String));
					r_R__0__F9_ID_String_String.SetBelong(this.instance);
				}
				return r_R__0__F9_ID_String_String;
			}
		}

		/// <summary>
		/// Void #G9(GameDefineType.ID, GameDefineType.ID, BattleBuff ByRef)
		/// </summary>
		protected RMethod r_R__0__G9_ID_ID_Ref_BattleBuff;
		public virtual RMethod R__0__G9_ID_ID_Ref_BattleBuff
		{
			get
			{
				if(r_R__0__G9_ID_ID_Ref_BattleBuff == null)
				{
					r_R__0__G9_ID_ID_Ref_BattleBuff = new(this, "#G9", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID),  ReleactionUtils.GetType("BattleBuff").MakeByRefType());
					r_R__0__G9_ID_ID_Ref_BattleBuff.SetBelong(this.instance);
				}
				return r_R__0__G9_ID_ID_Ref_BattleBuff;
			}
		}

		/// <summary>
		/// Void #H9(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__H9_ID_ID;
		public virtual RMethod R__0__H9_ID_ID
		{
			get
			{
				if(r_R__0__H9_ID_ID == null)
				{
					r_R__0__H9_ID_ID = new(this, "#H9", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_R__0__H9_ID_ID.SetBelong(this.instance);
				}
				return r_R__0__H9_ID_ID;
			}
		}

		/// <summary>
		/// Void #VC(GameDefineType.ID, GameDefineType.ID, Int32, Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__VC_ID_ID_Int32_Int32_Int32_Int32;
		public virtual RMethod R__0__VC_ID_ID_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_R__0__VC_ID_ID_Int32_Int32_Int32_Int32 == null)
				{
					r_R__0__VC_ID_ID_Int32_Int32_Int32_Int32 = new(this, "#VC", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_R__0__VC_ID_ID_Int32_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__VC_ID_ID_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Void #I9(System.String)
		/// </summary>
		protected RMethod r_R__0__I9_String;
		public virtual RMethod R__0__I9_String
		{
			get
			{
				if(r_R__0__I9_String == null)
				{
					r_R__0__I9_String = new(this, "#I9", 0, typeof(System.String));
					r_R__0__I9_String.SetBelong(this.instance);
				}
				return r_R__0__I9_String;
			}
		}

		/// <summary>
		/// Void #I9(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__I9_ID_String;
		public virtual RMethod R__0__I9_ID_String
		{
			get
			{
				if(r_R__0__I9_ID_String == null)
				{
					r_R__0__I9_ID_String = new(this, "#I9", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__I9_ID_String.SetBelong(this.instance);
				}
				return r_R__0__I9_ID_String;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #J9(GameDefineType.ID, UnityEngine.Object, GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__J9_ID_Object_ID_String;
		public virtual RMethod R__0__J9_ID_Object_ID_String
		{
			get
			{
				if(r_R__0__J9_ID_Object_ID_String == null)
				{
					r_R__0__J9_ID_Object_ID_String = new(this, "#J9", 0, typeof(GameDefineType.ID), typeof(UnityEngine.Object), typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__J9_ID_Object_ID_String.SetBelong(this.instance);
				}
				return r_R__0__J9_ID_Object_ID_String;
			}
		}

		/// <summary>
		/// Void #K9(GameDefineType.ID, GameDefineType.ID, Int32, Int32, Int32, Int32, Boolean, System.String, System.String, Boolean, Boolean)
		/// </summary>
		protected RMethod r_R__0__K9_ID_ID_Int32_Int32_Int32_Int32_Boolean_String_String_Boolean_Boolean;
		public virtual RMethod R__0__K9_ID_ID_Int32_Int32_Int32_Int32_Boolean_String_String_Boolean_Boolean
		{
			get
			{
				if(r_R__0__K9_ID_ID_Int32_Int32_Int32_Int32_Boolean_String_String_Boolean_Boolean == null)
				{
					r_R__0__K9_ID_ID_Int32_Int32_Int32_Int32_Boolean_String_String_Boolean_Boolean = new(this, "#K9", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(System.Boolean));
					r_R__0__K9_ID_ID_Int32_Int32_Int32_Int32_Boolean_String_String_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_R__0__K9_ID_ID_Int32_Int32_Int32_Int32_Boolean_String_String_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void #L9(GameDefineType.ID, GameDefineType.ID, Boolean, System.String, System.String, Boolean)
		/// </summary>
		protected RMethod r_R__0__L9_ID_ID_Boolean_String_String_Boolean;
		public virtual RMethod R__0__L9_ID_ID_Boolean_String_String_Boolean
		{
			get
			{
				if(r_R__0__L9_ID_ID_Boolean_String_String_Boolean == null)
				{
					r_R__0__L9_ID_ID_Boolean_String_String_Boolean = new(this, "#L9", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean));
					r_R__0__L9_ID_ID_Boolean_String_String_Boolean.SetBelong(this.instance);
				}
				return r_R__0__L9_ID_ID_Boolean_String_String_Boolean;
			}
		}

		/// <summary>
		/// Void #M9(GameDefineType.ID, Int32, Boolean, System.String, System.String, Boolean, EffectResult)
		/// </summary>
		protected RMethod r_R__0__M9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
		public virtual RMethod R__0__M9_ID_Int32_Boolean_String_String_Boolean_EffectResult
		{
			get
			{
				if(r_R__0__M9_ID_Int32_Boolean_String_String_Boolean_EffectResult == null)
				{
					r_R__0__M9_ID_Int32_Boolean_String_String_Boolean_EffectResult = new(this, "#M9", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(EffectResult));
					r_R__0__M9_ID_Int32_Boolean_String_String_Boolean_EffectResult.SetBelong(this.instance);
				}
				return r_R__0__M9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
			}
		}

		/// <summary>
		/// Void #N9(GameDefineType.ID, Int32, Boolean, System.String, System.String, Boolean, EffectResult, Boolean)
		/// </summary>
		protected RMethod r_R__0__N9_ID_Int32_Boolean_String_String_Boolean_EffectResult_Boolean;
		public virtual RMethod R__0__N9_ID_Int32_Boolean_String_String_Boolean_EffectResult_Boolean
		{
			get
			{
				if(r_R__0__N9_ID_Int32_Boolean_String_String_Boolean_EffectResult_Boolean == null)
				{
					r_R__0__N9_ID_Int32_Boolean_String_String_Boolean_EffectResult_Boolean = new(this, "#N9", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(EffectResult), typeof(System.Boolean));
					r_R__0__N9_ID_Int32_Boolean_String_String_Boolean_EffectResult_Boolean.SetBelong(this.instance);
				}
				return r_R__0__N9_ID_Int32_Boolean_String_String_Boolean_EffectResult_Boolean;
			}
		}

		/// <summary>
		/// Void #O9(GameDefineType.ID, Int32, Boolean, System.String, System.String, Boolean, EffectResult)
		/// </summary>
		protected RMethod r_R__0__O9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
		public virtual RMethod R__0__O9_ID_Int32_Boolean_String_String_Boolean_EffectResult
		{
			get
			{
				if(r_R__0__O9_ID_Int32_Boolean_String_String_Boolean_EffectResult == null)
				{
					r_R__0__O9_ID_Int32_Boolean_String_String_Boolean_EffectResult = new(this, "#O9", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(EffectResult));
					r_R__0__O9_ID_Int32_Boolean_String_String_Boolean_EffectResult.SetBelong(this.instance);
				}
				return r_R__0__O9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
			}
		}

		/// <summary>
		/// Void #P9(GameDefineType.ID, Int32, Boolean, System.String, System.String, Boolean, EffectResult)
		/// </summary>
		protected RMethod r_R__0__P9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
		public virtual RMethod R__0__P9_ID_Int32_Boolean_String_String_Boolean_EffectResult
		{
			get
			{
				if(r_R__0__P9_ID_Int32_Boolean_String_String_Boolean_EffectResult == null)
				{
					r_R__0__P9_ID_Int32_Boolean_String_String_Boolean_EffectResult = new(this, "#P9", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(EffectResult));
					r_R__0__P9_ID_Int32_Boolean_String_String_Boolean_EffectResult.SetBelong(this.instance);
				}
				return r_R__0__P9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
			}
		}

		/// <summary>
		/// Void #Q9(GameDefineType.ID, Int32, Boolean, System.String, System.String, Boolean, EffectResult)
		/// </summary>
		protected RMethod r_R__0__Q9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
		public virtual RMethod R__0__Q9_ID_Int32_Boolean_String_String_Boolean_EffectResult
		{
			get
			{
				if(r_R__0__Q9_ID_Int32_Boolean_String_String_Boolean_EffectResult == null)
				{
					r_R__0__Q9_ID_Int32_Boolean_String_String_Boolean_EffectResult = new(this, "#Q9", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(EffectResult));
					r_R__0__Q9_ID_Int32_Boolean_String_String_Boolean_EffectResult.SetBelong(this.instance);
				}
				return r_R__0__Q9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
			}
		}

		/// <summary>
		/// Void #R9(GameDefineType.ID, Int32, Boolean, System.String, System.String, Boolean, EffectResult)
		/// </summary>
		protected RMethod r_R__0__R9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
		public virtual RMethod R__0__R9_ID_Int32_Boolean_String_String_Boolean_EffectResult
		{
			get
			{
				if(r_R__0__R9_ID_Int32_Boolean_String_String_Boolean_EffectResult == null)
				{
					r_R__0__R9_ID_Int32_Boolean_String_String_Boolean_EffectResult = new(this, "#R9", 0, typeof(GameDefineType.ID), typeof(System.Int32), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(EffectResult));
					r_R__0__R9_ID_Int32_Boolean_String_String_Boolean_EffectResult.SetBelong(this.instance);
				}
				return r_R__0__R9_ID_Int32_Boolean_String_String_Boolean_EffectResult;
			}
		}

		/// <summary>
		/// Void #S9(GameDefineType.ID, Boolean, System.String, System.String, Boolean, EffectResult)
		/// </summary>
		protected RMethod r_R__0__S9_ID_Boolean_String_String_Boolean_EffectResult;
		public virtual RMethod R__0__S9_ID_Boolean_String_String_Boolean_EffectResult
		{
			get
			{
				if(r_R__0__S9_ID_Boolean_String_String_Boolean_EffectResult == null)
				{
					r_R__0__S9_ID_Boolean_String_String_Boolean_EffectResult = new(this, "#S9", 0, typeof(GameDefineType.ID), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(EffectResult));
					r_R__0__S9_ID_Boolean_String_String_Boolean_EffectResult.SetBelong(this.instance);
				}
				return r_R__0__S9_ID_Boolean_String_String_Boolean_EffectResult;
			}
		}

		/// <summary>
		/// Void #T9(GameDefineType.ID, System.String)
		/// </summary>
		protected RMethod r_R__0__T9_ID_String;
		public virtual RMethod R__0__T9_ID_String
		{
			get
			{
				if(r_R__0__T9_ID_String == null)
				{
					r_R__0__T9_ID_String = new(this, "#T9", 0, typeof(GameDefineType.ID), typeof(System.String));
					r_R__0__T9_ID_String.SetBelong(this.instance);
				}
				return r_R__0__T9_ID_String;
			}
		}

		/// <summary>
		/// Void #U9(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__U9_ID_Int32;
		public virtual RMethod R__0__U9_ID_Int32
		{
			get
			{
				if(r_R__0__U9_ID_Int32 == null)
				{
					r_R__0__U9_ID_Int32 = new(this, "#U9", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__U9_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__U9_ID_Int32;
			}
		}

		/// <summary>
		/// Void #V9(System.Collections.Generic.List`1[#u.#S8], Boolean, System.String, System.String, Boolean, GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__V9_List_d___0__S8_p__Boolean_String_String_Boolean_ID_ID;
		public virtual RMethod R__0__V9_List_d___0__S8_p__Boolean_String_String_Boolean_ID_ID
		{
			get
			{
				if(r_R__0__V9_List_d___0__S8_p__Boolean_String_String_Boolean_ID_ID == null)
				{
					r_R__0__V9_List_d___0__S8_p__Boolean_String_String_Boolean_ID_ID = new(this, "#V9", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#u.#S8")), typeof(System.Boolean), typeof(System.String), typeof(System.String), typeof(System.Boolean), typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_R__0__V9_List_d___0__S8_p__Boolean_String_String_Boolean_ID_ID.SetBelong(this.instance);
				}
				return r_R__0__V9_List_d___0__S8_p__Boolean_String_String_Boolean_ID_ID;
			}
		}

		/// <summary>
		/// Void #W9(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__W9_ID;
		public virtual RMethod R__0__W9_ID
		{
			get
			{
				if(r_R__0__W9_ID == null)
				{
					r_R__0__W9_ID = new(this, "#W9", 0, typeof(GameDefineType.ID));
					r_R__0__W9_ID.SetBelong(this.instance);
				}
				return r_R__0__W9_ID;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #Nzf(GameDefineType.ID, UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__Nzf_ID_GameObject;
		public virtual RMethod R__0__Nzf_ID_GameObject
		{
			get
			{
				if(r_R__0__Nzf_ID_GameObject == null)
				{
					r_R__0__Nzf_ID_GameObject = new(this, "#Nzf", 0, typeof(GameDefineType.ID), typeof(UnityEngine.GameObject));
					r_R__0__Nzf_ID_GameObject.SetBelong(this.instance);
				}
				return r_R__0__Nzf_ID_GameObject;
			}
		}

		/// <summary>
		/// Void #X9()
		/// </summary>
		protected RMethod r_R__0__X9;
		public virtual RMethod R__0__X9
		{
			get
			{
				if(r_R__0__X9 == null)
				{
					r_R__0__X9 = new(this, "#X9", 0);
					r_R__0__X9.SetBelong(this.instance);
				}
				return r_R__0__X9;
			}
		}

		/// <summary>
		/// Void #W9()
		/// </summary>
		protected RMethod r_R__0__W9;
		public virtual RMethod R__0__W9
		{
			get
			{
				if(r_R__0__W9 == null)
				{
					r_R__0__W9 = new(this, "#W9", 0);
					r_R__0__W9.SetBelong(this.instance);
				}
				return r_R__0__W9;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #Nzf(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__Nzf_GameObject;
		public virtual RMethod R__0__Nzf_GameObject
		{
			get
			{
				if(r_R__0__Nzf_GameObject == null)
				{
					r_R__0__Nzf_GameObject = new(this, "#Nzf", 0, typeof(UnityEngine.GameObject));
					r_R__0__Nzf_GameObject.SetBelong(this.instance);
				}
				return r_R__0__Nzf_GameObject;
			}
		}

		/// <summary>
		/// Void #Y9(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__Y9_GameObject;
		public virtual RMethod R__0__Y9_GameObject
		{
			get
			{
				if(r_R__0__Y9_GameObject == null)
				{
					r_R__0__Y9_GameObject = new(this, "#Y9", 0, typeof(UnityEngine.GameObject));
					r_R__0__Y9_GameObject.SetBelong(this.instance);
				}
				return r_R__0__Y9_GameObject;
			}
		}

		/// <summary>
		/// Void #Z9()
		/// </summary>
		protected RMethod r_R__0__Z9;
		public virtual RMethod R__0__Z9
		{
			get
			{
				if(r_R__0__Z9 == null)
				{
					r_R__0__Z9 = new(this, "#Z9", 0);
					r_R__0__Z9.SetBelong(this.instance);
				}
				return r_R__0__Z9;
			}
		}

		/// <summary>
		/// Void LeaveCombat(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_RLeaveCombat_Object_EventArgs;
		public virtual RMethod RLeaveCombat_Object_EventArgs
		{
			get
			{
				if(r_RLeaveCombat_Object_EventArgs == null)
				{
					r_RLeaveCombat_Object_EventArgs = new(this, "LeaveCombat", 0, typeof(System.Object), typeof(System.EventArgs));
					r_RLeaveCombat_Object_EventArgs.SetBelong(this.instance);
				}
				return r_RLeaveCombat_Object_EventArgs;
			}
		}

		/// <summary>
		/// Void EnterCombat()
		/// </summary>
		protected RMethod r_REnterCombat;
		public virtual RMethod REnterCombat
		{
			get
			{
				if(r_REnterCombat == null)
				{
					r_REnterCombat = new(this, "EnterCombat", 0);
					r_REnterCombat.SetBelong(this.instance);
				}
				return r_REnterCombat;
			}
		}

		/// <summary>
		/// Void #09()
		/// </summary>
		protected RMethod r_R__0__09;
		public virtual RMethod R__0__09
		{
			get
			{
				if(r_R__0__09 == null)
				{
					r_R__0__09 = new(this, "#09", 0);
					r_R__0__09.SetBelong(this.instance);
				}
				return r_R__0__09;
			}
		}

		/// <summary>
		/// Void #19()
		/// </summary>
		protected RMethod r_R__0__19;
		public virtual RMethod R__0__19
		{
			get
			{
				if(r_R__0__19 == null)
				{
					r_R__0__19 = new(this, "#19", 0);
					r_R__0__19.SetBelong(this.instance);
				}
				return r_R__0__19;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #29()
		/// </summary>
		protected RMethod r_R__0__29;
		public virtual RMethod R__0__29
		{
			get
			{
				if(r_R__0__29 == null)
				{
					r_R__0__29 = new(this, "#29", 0);
					r_R__0__29.SetBelong(this.instance);
				}
				return r_R__0__29;
			}
		}

		/// <summary>
		/// UInt32 #39(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__39_ID;
		public virtual RMethod R__0__39_ID
		{
			get
			{
				if(r_R__0__39_ID == null)
				{
					r_R__0__39_ID = new(this, "#39", 0, typeof(GameDefineType.ID));
					r_R__0__39_ID.SetBelong(this.instance);
				}
				return r_R__0__39_ID;
			}
		}

		/// <summary>
		/// Void #37d(System.String)
		/// </summary>
		protected RMethod r_R__0__37d_String;
		public virtual RMethod R__0__37d_String
		{
			get
			{
				if(r_R__0__37d_String == null)
				{
					r_R__0__37d_String = new(this, "#37d", 0, typeof(System.String));
					r_R__0__37d_String.SetBelong(this.instance);
				}
				return r_R__0__37d_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetEffectUrls(Boolean)
		/// </summary>
		protected RMethod r_RGetEffectUrls_Boolean;
		public virtual RMethod RGetEffectUrls_Boolean
		{
			get
			{
				if(r_RGetEffectUrls_Boolean == null)
				{
					r_RGetEffectUrls_Boolean = new(this, "GetEffectUrls", 0, typeof(System.Boolean));
					r_RGetEffectUrls_Boolean.SetBelong(this.instance);
				}
				return r_RGetEffectUrls_Boolean;
			}
		}

		/// <summary>
		/// Void #49()
		/// </summary>
		protected RMethod r_R__0__49;
		public virtual RMethod R__0__49
		{
			get
			{
				if(r_R__0__49 == null)
				{
					r_R__0__49 = new(this, "#49", 0);
					r_R__0__49.SetBelong(this.instance);
				}
				return r_R__0__49;
			}
		}

		/// <summary>
		/// Void #59()
		/// </summary>
		protected RMethod r_R__0__59;
		public virtual RMethod R__0__59
		{
			get
			{
				if(r_R__0__59 == null)
				{
					r_R__0__59 = new(this, "#59", 0);
					r_R__0__59.SetBelong(this.instance);
				}
				return r_R__0__59;
			}
		}

		/// <summary>
		/// Void #69(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__69_Object___0__Isb;
		public virtual RMethod R__0__69_Object___0__Isb
		{
			get
			{
				if(r_R__0__69_Object___0__Isb == null)
				{
					r_R__0__69_Object___0__Isb = new(this, "#69", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__69_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__69_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #6fd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__6fd_Object___0__Isb;
		public virtual RMethod R__0__6fd_Object___0__Isb
		{
			get
			{
				if(r_R__0__6fd_Object___0__Isb == null)
				{
					r_R__0__6fd_Object___0__Isb = new(this, "#6fd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__6fd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__6fd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #79(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__79_Object___0__Isb;
		public virtual RMethod R__0__79_Object___0__Isb
		{
			get
			{
				if(r_R__0__79_Object___0__Isb == null)
				{
					r_R__0__79_Object___0__Isb = new(this, "#79", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__79_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__79_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #89(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__89_Object___0__Isb;
		public virtual RMethod R__0__89_Object___0__Isb
		{
			get
			{
				if(r_R__0__89_Object___0__Isb == null)
				{
					r_R__0__89_Object___0__Isb = new(this, "#89", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__89_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__89_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #79(#Pfb.#Vob)
		/// </summary>
		protected RMethod r_R__0__79___0__Vob;
		public virtual RMethod R__0__79___0__Vob
		{
			get
			{
				if(r_R__0__79___0__Vob == null)
				{
					r_R__0__79___0__Vob = new(this, "#79", 0,  ReleactionUtils.GetType("#Pfb.#Vob"));
					r_R__0__79___0__Vob.SetBelong(this.instance);
				}
				return r_R__0__79___0__Vob;
			}
		}

		/// <summary>
		/// Void #99(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__99_Object___0__Isb;
		public virtual RMethod R__0__99_Object___0__Isb
		{
			get
			{
				if(r_R__0__99_Object___0__Isb == null)
				{
					r_R__0__99_Object___0__Isb = new(this, "#99", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__99_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__99_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #cab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__cab_Object___0__Isb;
		public virtual RMethod R__0__cab_Object___0__Isb
		{
			get
			{
				if(r_R__0__cab_Object___0__Isb == null)
				{
					r_R__0__cab_Object___0__Isb = new(this, "#cab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__cab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__cab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #dab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__dab_Object___0__Isb;
		public virtual RMethod R__0__dab_Object___0__Isb
		{
			get
			{
				if(r_R__0__dab_Object___0__Isb == null)
				{
					r_R__0__dab_Object___0__Isb = new(this, "#dab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__dab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__dab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #eab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__eab_Object___0__Isb;
		public virtual RMethod R__0__eab_Object___0__Isb
		{
			get
			{
				if(r_R__0__eab_Object___0__Isb == null)
				{
					r_R__0__eab_Object___0__Isb = new(this, "#eab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__eab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__eab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #oCd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__oCd_Object___0__Isb;
		public virtual RMethod R__0__oCd_Object___0__Isb
		{
			get
			{
				if(r_R__0__oCd_Object___0__Isb == null)
				{
					r_R__0__oCd_Object___0__Isb = new(this, "#oCd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__oCd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__oCd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #3h(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__3h_Object___0__Isb;
		public virtual RMethod R__0__3h_Object___0__Isb
		{
			get
			{
				if(r_R__0__3h_Object___0__Isb == null)
				{
					r_R__0__3h_Object___0__Isb = new(this, "#3h", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__3h_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__3h_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #3h(#Pfb.#4ob)
		/// </summary>
		protected RMethod r_R__0__3h___0__4ob;
		public virtual RMethod R__0__3h___0__4ob
		{
			get
			{
				if(r_R__0__3h___0__4ob == null)
				{
					r_R__0__3h___0__4ob = new(this, "#3h", 0,  ReleactionUtils.GetType("#Pfb.#4ob"));
					r_R__0__3h___0__4ob.SetBelong(this.instance);
				}
				return r_R__0__3h___0__4ob;
			}
		}

		/// <summary>
		/// Void #fab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__fab_Object___0__Isb;
		public virtual RMethod R__0__fab_Object___0__Isb
		{
			get
			{
				if(r_R__0__fab_Object___0__Isb == null)
				{
					r_R__0__fab_Object___0__Isb = new(this, "#fab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__fab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__fab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #gab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__gab_Object___0__Isb;
		public virtual RMethod R__0__gab_Object___0__Isb
		{
			get
			{
				if(r_R__0__gab_Object___0__Isb == null)
				{
					r_R__0__gab_Object___0__Isb = new(this, "#gab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__gab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__gab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #hab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__hab_Object___0__Isb;
		public virtual RMethod R__0__hab_Object___0__Isb
		{
			get
			{
				if(r_R__0__hab_Object___0__Isb == null)
				{
					r_R__0__hab_Object___0__Isb = new(this, "#hab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__hab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__hab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #iab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__iab_Object___0__Isb;
		public virtual RMethod R__0__iab_Object___0__Isb
		{
			get
			{
				if(r_R__0__iab_Object___0__Isb == null)
				{
					r_R__0__iab_Object___0__Isb = new(this, "#iab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__iab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__iab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #jab(#Pfb.#apb)
		/// </summary>
		protected RMethod r_R__0__jab___0__apb;
		public virtual RMethod R__0__jab___0__apb
		{
			get
			{
				if(r_R__0__jab___0__apb == null)
				{
					r_R__0__jab___0__apb = new(this, "#jab", 0,  ReleactionUtils.GetType("#Pfb.#apb"));
					r_R__0__jab___0__apb.SetBelong(this.instance);
				}
				return r_R__0__jab___0__apb;
			}
		}

		/// <summary>
		/// Void #kab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__kab_Object___0__Isb;
		public virtual RMethod R__0__kab_Object___0__Isb
		{
			get
			{
				if(r_R__0__kab_Object___0__Isb == null)
				{
					r_R__0__kab_Object___0__Isb = new(this, "#kab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__kab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__kab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #lab(#Pfb.#8ob)
		/// </summary>
		protected RMethod r_R__0__lab___0__8ob;
		public virtual RMethod R__0__lab___0__8ob
		{
			get
			{
				if(r_R__0__lab___0__8ob == null)
				{
					r_R__0__lab___0__8ob = new(this, "#lab", 0,  ReleactionUtils.GetType("#Pfb.#8ob"));
					r_R__0__lab___0__8ob.SetBelong(this.instance);
				}
				return r_R__0__lab___0__8ob;
			}
		}

		/// <summary>
		/// Void #mab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__mab_Object___0__Isb;
		public virtual RMethod R__0__mab_Object___0__Isb
		{
			get
			{
				if(r_R__0__mab_Object___0__Isb == null)
				{
					r_R__0__mab_Object___0__Isb = new(this, "#mab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__mab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__mab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #mab(#Pfb.#ipb)
		/// </summary>
		protected RMethod r_R__0__mab___0__ipb;
		public virtual RMethod R__0__mab___0__ipb
		{
			get
			{
				if(r_R__0__mab___0__ipb == null)
				{
					r_R__0__mab___0__ipb = new(this, "#mab", 0,  ReleactionUtils.GetType("#Pfb.#ipb"));
					r_R__0__mab___0__ipb.SetBelong(this.instance);
				}
				return r_R__0__mab___0__ipb;
			}
		}

		/// <summary>
		/// Void #nab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__nab_Object___0__Isb;
		public virtual RMethod R__0__nab_Object___0__Isb
		{
			get
			{
				if(r_R__0__nab_Object___0__Isb == null)
				{
					r_R__0__nab_Object___0__Isb = new(this, "#nab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__nab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__nab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #oab(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_R__0__oab_Object_EventArgs;
		public virtual RMethod R__0__oab_Object_EventArgs
		{
			get
			{
				if(r_R__0__oab_Object_EventArgs == null)
				{
					r_R__0__oab_Object_EventArgs = new(this, "#oab", 0, typeof(System.Object), typeof(System.EventArgs));
					r_R__0__oab_Object_EventArgs.SetBelong(this.instance);
				}
				return r_R__0__oab_Object_EventArgs;
			}
		}

		/// <summary>
		/// Void #pab()
		/// </summary>
		protected RMethod r_R__0__pab;
		public virtual RMethod R__0__pab
		{
			get
			{
				if(r_R__0__pab == null)
				{
					r_R__0__pab = new(this, "#pab", 0);
					r_R__0__pab.SetBelong(this.instance);
				}
				return r_R__0__pab;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #qab(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__qab_GameObject;
		public virtual RMethod R__0__qab_GameObject
		{
			get
			{
				if(r_R__0__qab_GameObject == null)
				{
					r_R__0__qab_GameObject = new(this, "#qab", 0, typeof(UnityEngine.GameObject));
					r_R__0__qab_GameObject.SetBelong(this.instance);
				}
				return r_R__0__qab_GameObject;
			}
		}

		/// <summary>
		/// Void #4Dd()
		/// </summary>
		protected RMethod r_R__0__4Dd;
		public virtual RMethod R__0__4Dd
		{
			get
			{
				if(r_R__0__4Dd == null)
				{
					r_R__0__4Dd = new(this, "#4Dd", 0);
					r_R__0__4Dd.SetBelong(this.instance);
				}
				return r_R__0__4Dd;
			}
		}

		/// <summary>
		/// Void #rab()
		/// </summary>
		protected RMethod r_R__0__rab;
		public virtual RMethod R__0__rab
		{
			get
			{
				if(r_R__0__rab == null)
				{
					r_R__0__rab = new(this, "#rab", 0);
					r_R__0__rab.SetBelong(this.instance);
				}
				return r_R__0__rab;
			}
		}

		/// <summary>
		/// Void #nab(System.String)
		/// </summary>
		protected RMethod r_R__0__nab_String;
		public virtual RMethod R__0__nab_String
		{
			get
			{
				if(r_R__0__nab_String == null)
				{
					r_R__0__nab_String = new(this, "#nab", 0, typeof(System.String));
					r_R__0__nab_String.SetBelong(this.instance);
				}
				return r_R__0__nab_String;
			}
		}

		/// <summary>
		/// Void #sab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__sab_Object___0__Isb;
		public virtual RMethod R__0__sab_Object___0__Isb
		{
			get
			{
				if(r_R__0__sab_Object___0__Isb == null)
				{
					r_R__0__sab_Object___0__Isb = new(this, "#sab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__sab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__sab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #tab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__tab_Object___0__Isb;
		public virtual RMethod R__0__tab_Object___0__Isb
		{
			get
			{
				if(r_R__0__tab_Object___0__Isb == null)
				{
					r_R__0__tab_Object___0__Isb = new(this, "#tab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__tab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__tab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #uab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__uab_Object___0__Isb;
		public virtual RMethod R__0__uab_Object___0__Isb
		{
			get
			{
				if(r_R__0__uab_Object___0__Isb == null)
				{
					r_R__0__uab_Object___0__Isb = new(this, "#uab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__uab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__uab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #vab()
		/// </summary>
		protected RMethod r_R__0__vab;
		public virtual RMethod R__0__vab
		{
			get
			{
				if(r_R__0__vab == null)
				{
					r_R__0__vab = new(this, "#vab", 0);
					r_R__0__vab.SetBelong(this.instance);
				}
				return r_R__0__vab;
			}
		}

		/// <summary>
		/// Void #wab()
		/// </summary>
		protected RMethod r_R__0__wab;
		public virtual RMethod R__0__wab
		{
			get
			{
				if(r_R__0__wab == null)
				{
					r_R__0__wab = new(this, "#wab", 0);
					r_R__0__wab.SetBelong(this.instance);
				}
				return r_R__0__wab;
			}
		}

		/// <summary>
		/// Void #xab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__xab_Object___0__Isb;
		public virtual RMethod R__0__xab_Object___0__Isb
		{
			get
			{
				if(r_R__0__xab_Object___0__Isb == null)
				{
					r_R__0__xab_Object___0__Isb = new(this, "#xab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__xab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__xab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #47d(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__47d_Object___0__Isb;
		public virtual RMethod R__0__47d_Object___0__Isb
		{
			get
			{
				if(r_R__0__47d_Object___0__Isb == null)
				{
					r_R__0__47d_Object___0__Isb = new(this, "#47d", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__47d_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__47d_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #yab(#Pfb.#bpb, Boolean)
		/// </summary>
		protected RMethod r_R__0__yab___0__bpb_Boolean;
		public virtual RMethod R__0__yab___0__bpb_Boolean
		{
			get
			{
				if(r_R__0__yab___0__bpb_Boolean == null)
				{
					r_R__0__yab___0__bpb_Boolean = new(this, "#yab", 0,  ReleactionUtils.GetType("#Pfb.#bpb"), typeof(System.Boolean));
					r_R__0__yab___0__bpb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__yab___0__bpb_Boolean;
			}
		}

		/// <summary>
		/// Void #zab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__zab_Object___0__Isb;
		public virtual RMethod R__0__zab_Object___0__Isb
		{
			get
			{
				if(r_R__0__zab_Object___0__Isb == null)
				{
					r_R__0__zab_Object___0__Isb = new(this, "#zab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__zab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__zab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Aab(#Pfb.#lpb)
		/// </summary>
		protected RMethod r_R__0__Aab___0__lpb;
		public virtual RMethod R__0__Aab___0__lpb
		{
			get
			{
				if(r_R__0__Aab___0__lpb == null)
				{
					r_R__0__Aab___0__lpb = new(this, "#Aab", 0,  ReleactionUtils.GetType("#Pfb.#lpb"));
					r_R__0__Aab___0__lpb.SetBelong(this.instance);
				}
				return r_R__0__Aab___0__lpb;
			}
		}

		/// <summary>
		/// Void #Bab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Bab_Object___0__Isb;
		public virtual RMethod R__0__Bab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Bab_Object___0__Isb == null)
				{
					r_R__0__Bab_Object___0__Isb = new(this, "#Bab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Bab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Bab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Cab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Cab_Object___0__Isb;
		public virtual RMethod R__0__Cab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Cab_Object___0__Isb == null)
				{
					r_R__0__Cab_Object___0__Isb = new(this, "#Cab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Cab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Cab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Dab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Dab_Object___0__Isb;
		public virtual RMethod R__0__Dab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Dab_Object___0__Isb == null)
				{
					r_R__0__Dab_Object___0__Isb = new(this, "#Dab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Dab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Dab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Eab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Eab_Object___0__Isb;
		public virtual RMethod R__0__Eab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Eab_Object___0__Isb == null)
				{
					r_R__0__Eab_Object___0__Isb = new(this, "#Eab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Eab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Eab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Fab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Fab_Object___0__Isb;
		public virtual RMethod R__0__Fab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Fab_Object___0__Isb == null)
				{
					r_R__0__Fab_Object___0__Isb = new(this, "#Fab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Fab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Fab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Gab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Gab_Object___0__Isb;
		public virtual RMethod R__0__Gab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Gab_Object___0__Isb == null)
				{
					r_R__0__Gab_Object___0__Isb = new(this, "#Gab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Gab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Gab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Hab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Hab_Object___0__Isb;
		public virtual RMethod R__0__Hab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Hab_Object___0__Isb == null)
				{
					r_R__0__Hab_Object___0__Isb = new(this, "#Hab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Hab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Hab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Iab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Iab_Object___0__Isb;
		public virtual RMethod R__0__Iab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Iab_Object___0__Isb == null)
				{
					r_R__0__Iab_Object___0__Isb = new(this, "#Iab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Iab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Iab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Jab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Jab_Object___0__Isb;
		public virtual RMethod R__0__Jab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Jab_Object___0__Isb == null)
				{
					r_R__0__Jab_Object___0__Isb = new(this, "#Jab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Jab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Jab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #5Dd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__5Dd_Object___0__Isb;
		public virtual RMethod R__0__5Dd_Object___0__Isb
		{
			get
			{
				if(r_R__0__5Dd_Object___0__Isb == null)
				{
					r_R__0__5Dd_Object___0__Isb = new(this, "#5Dd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__5Dd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__5Dd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #6Dd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__6Dd_Object___0__Isb;
		public virtual RMethod R__0__6Dd_Object___0__Isb
		{
			get
			{
				if(r_R__0__6Dd_Object___0__Isb == null)
				{
					r_R__0__6Dd_Object___0__Isb = new(this, "#6Dd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__6Dd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__6Dd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Kab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Kab_Object___0__Isb;
		public virtual RMethod R__0__Kab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Kab_Object___0__Isb == null)
				{
					r_R__0__Kab_Object___0__Isb = new(this, "#Kab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Kab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Kab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Lab(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Lab_Object___0__Isb;
		public virtual RMethod R__0__Lab_Object___0__Isb
		{
			get
			{
				if(r_R__0__Lab_Object___0__Isb == null)
				{
					r_R__0__Lab_Object___0__Isb = new(this, "#Lab", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Lab_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Lab_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #tJc(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__tJc_Object___0__Isb;
		public virtual RMethod R__0__tJc_Object___0__Isb
		{
			get
			{
				if(r_R__0__tJc_Object___0__Isb == null)
				{
					r_R__0__tJc_Object___0__Isb = new(this, "#tJc", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__tJc_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__tJc_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #7Dd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__7Dd_Object___0__Isb;
		public virtual RMethod R__0__7Dd_Object___0__Isb
		{
			get
			{
				if(r_R__0__7Dd_Object___0__Isb == null)
				{
					r_R__0__7Dd_Object___0__Isb = new(this, "#7Dd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__7Dd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__7Dd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #8Dd(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__8Dd_Object___0__Isb;
		public virtual RMethod R__0__8Dd_Object___0__Isb
		{
			get
			{
				if(r_R__0__8Dd_Object___0__Isb == null)
				{
					r_R__0__8Dd_Object___0__Isb = new(this, "#8Dd", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__8Dd_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__8Dd_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Mab(#Pfb.#Vob)
		/// </summary>
		protected RMethod r_R__0__Mab___0__Vob;
		public virtual RMethod R__0__Mab___0__Vob
		{
			get
			{
				if(r_R__0__Mab___0__Vob == null)
				{
					r_R__0__Mab___0__Vob = new(this, "#Mab", 0,  ReleactionUtils.GetType("#Pfb.#Vob"));
					r_R__0__Mab___0__Vob.SetBelong(this.instance);
				}
				return r_R__0__Mab___0__Vob;
			}
		}

		/// <summary>
		/// Void #5hj(UnityEngine.GameObject, UInt32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__5hj_GameObject_UInt32_ID;
		public virtual RMethod R__0__5hj_GameObject_UInt32_ID
		{
			get
			{
				if(r_R__0__5hj_GameObject_UInt32_ID == null)
				{
					r_R__0__5hj_GameObject_UInt32_ID = new(this, "#5hj", 0, typeof(UnityEngine.GameObject), typeof(System.UInt32), typeof(GameDefineType.ID));
					r_R__0__5hj_GameObject_UInt32_ID.SetBelong(this.instance);
				}
				return r_R__0__5hj_GameObject_UInt32_ID;
			}
		}

		/// <summary>
		/// Void OnLoadPlayer(System.Object, CGLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadPlayer_Object_CGLoadedArgs;
		public virtual RMethod ROnLoadPlayer_Object_CGLoadedArgs
		{
			get
			{
				if(r_ROnLoadPlayer_Object_CGLoadedArgs == null)
				{
					r_ROnLoadPlayer_Object_CGLoadedArgs = new(this, "OnLoadPlayer", 0, typeof(System.Object),  ReleactionUtils.GetType("CharacterDownloader+CGLoadedArgs"));
					r_ROnLoadPlayer_Object_CGLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadPlayer_Object_CGLoadedArgs;
			}
		}

		/// <summary>
		/// Void #wSf(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_R__0__wSf_Object_EventArgs;
		public virtual RMethod R__0__wSf_Object_EventArgs
		{
			get
			{
				if(r_R__0__wSf_Object_EventArgs == null)
				{
					r_R__0__wSf_Object_EventArgs = new(this, "#wSf", 0, typeof(System.Object), typeof(System.EventArgs));
					r_R__0__wSf_Object_EventArgs.SetBelong(this.instance);
				}
				return r_R__0__wSf_Object_EventArgs;
			}
		}

		/// <summary>
		/// Void #Nab(#Pfb.#Vob)
		/// </summary>
		protected RMethod r_R__0__Nab___0__Vob;
		public virtual RMethod R__0__Nab___0__Vob
		{
			get
			{
				if(r_R__0__Nab___0__Vob == null)
				{
					r_R__0__Nab___0__Vob = new(this, "#Nab", 0,  ReleactionUtils.GetType("#Pfb.#Vob"));
					r_R__0__Nab___0__Vob.SetBelong(this.instance);
				}
				return r_R__0__Nab___0__Vob;
			}
		}

		/// <summary>
		/// Void #Nab(#Pfb.#Xob)
		/// </summary>
		protected RMethod r_R__0__Nab___0__Xob;
		public virtual RMethod R__0__Nab___0__Xob
		{
			get
			{
				if(r_R__0__Nab___0__Xob == null)
				{
					r_R__0__Nab___0__Xob = new(this, "#Nab", 0,  ReleactionUtils.GetType("#Pfb.#Xob"));
					r_R__0__Nab___0__Xob.SetBelong(this.instance);
				}
				return r_R__0__Nab___0__Xob;
			}
		}

		/// <summary>
		/// Void #Oab()
		/// </summary>
		protected RMethod r_R__0__Oab;
		public virtual RMethod R__0__Oab
		{
			get
			{
				if(r_R__0__Oab == null)
				{
					r_R__0__Oab = new(this, "#Oab", 0);
					r_R__0__Oab.SetBelong(this.instance);
				}
				return r_R__0__Oab;
			}
		}

		/// <summary>
		/// Fighter #Pab()
		/// </summary>
		protected RMethod r_R__0__Pab;
		public virtual RMethod R__0__Pab
		{
			get
			{
				if(r_R__0__Pab == null)
				{
					r_R__0__Pab = new(this, "#Pab", 0);
					r_R__0__Pab.SetBelong(this.instance);
				}
				return r_R__0__Pab;
			}
		}

		/// <summary>
		/// Fighter #Qab(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__Qab_Int32_Int32;
		public virtual RMethod R__0__Qab_Int32_Int32
		{
			get
			{
				if(r_R__0__Qab_Int32_Int32 == null)
				{
					r_R__0__Qab_Int32_Int32 = new(this, "#Qab", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__Qab_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__Qab_Int32_Int32;
			}
		}

		/// <summary>
		/// Fighter #Qab(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Qab_ID;
		public virtual RMethod R__0__Qab_ID
		{
			get
			{
				if(r_R__0__Qab_ID == null)
				{
					r_R__0__Qab_ID = new(this, "#Qab", 0, typeof(GameDefineType.ID));
					r_R__0__Qab_ID.SetBelong(this.instance);
				}
				return r_R__0__Qab_ID;
			}
		}

		/// <summary>
		/// Boolean #Rab(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Rab_ID;
		public virtual RMethod R__0__Rab_ID
		{
			get
			{
				if(r_R__0__Rab_ID == null)
				{
					r_R__0__Rab_ID = new(this, "#Rab", 0, typeof(GameDefineType.ID));
					r_R__0__Rab_ID.SetBelong(this.instance);
				}
				return r_R__0__Rab_ID;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[Fighter] #Sab(Boolean, Int32)
		/// </summary>
		protected RMethod r_R__0__Sab_Boolean_Int32;
		public virtual RMethod R__0__Sab_Boolean_Int32
		{
			get
			{
				if(r_R__0__Sab_Boolean_Int32 == null)
				{
					r_R__0__Sab_Boolean_Int32 = new(this, "#Sab", 0, typeof(System.Boolean), typeof(System.Int32));
					r_R__0__Sab_Boolean_Int32.SetBelong(this.instance);
				}
				return r_R__0__Sab_Boolean_Int32;
			}
		}

		/// <summary>
		/// Fighter #Uab()
		/// </summary>
		protected RMethod r_R__0__Uab;
		public virtual RMethod R__0__Uab
		{
			get
			{
				if(r_R__0__Uab == null)
				{
					r_R__0__Uab = new(this, "#Uab", 0);
					r_R__0__Uab.SetBelong(this.instance);
				}
				return r_R__0__Uab;
			}
		}

		/// <summary>
		/// Boolean #Vab(Fighter)
		/// </summary>
		protected RMethod r_R__0__Vab_Fighter;
		public virtual RMethod R__0__Vab_Fighter
		{
			get
			{
				if(r_R__0__Vab_Fighter == null)
				{
					r_R__0__Vab_Fighter = new(this, "#Vab", 0,  ReleactionUtils.GetType("Fighter"));
					r_R__0__Vab_Fighter.SetBelong(this.instance);
				}
				return r_R__0__Vab_Fighter;
			}
		}

		/// <summary>
		/// Boolean #Wab()
		/// </summary>
		protected RMethod r_R__0__Wab;
		public virtual RMethod R__0__Wab
		{
			get
			{
				if(r_R__0__Wab == null)
				{
					r_R__0__Wab = new(this, "#Wab", 0);
					r_R__0__Wab.SetBelong(this.instance);
				}
				return r_R__0__Wab;
			}
		}

		/// <summary>
		/// Void #Xab(Fighter)
		/// </summary>
		protected RMethod r_R__0__Xab_Fighter;
		public virtual RMethod R__0__Xab_Fighter
		{
			get
			{
				if(r_R__0__Xab_Fighter == null)
				{
					r_R__0__Xab_Fighter = new(this, "#Xab", 0,  ReleactionUtils.GetType("Fighter"));
					r_R__0__Xab_Fighter.SetBelong(this.instance);
				}
				return r_R__0__Xab_Fighter;
			}
		}

		/// <summary>
		/// Void #Yab()
		/// </summary>
		protected RMethod r_R__0__Yab;
		public virtual RMethod R__0__Yab
		{
			get
			{
				if(r_R__0__Yab == null)
				{
					r_R__0__Yab = new(this, "#Yab", 0);
					r_R__0__Yab.SetBelong(this.instance);
				}
				return r_R__0__Yab;
			}
		}

		/// <summary>
		/// Void #Zab(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_R__0__Zab_Object_EventArgs;
		public virtual RMethod R__0__Zab_Object_EventArgs
		{
			get
			{
				if(r_R__0__Zab_Object_EventArgs == null)
				{
					r_R__0__Zab_Object_EventArgs = new(this, "#Zab", 0, typeof(System.Object), typeof(System.EventArgs));
					r_R__0__Zab_Object_EventArgs.SetBelong(this.instance);
				}
				return r_R__0__Zab_Object_EventArgs;
			}
		}

		/// <summary>
		/// Int32 #0ab(Boolean)
		/// </summary>
		protected RMethod r_R__0__0ab_Boolean;
		public virtual RMethod R__0__0ab_Boolean
		{
			get
			{
				if(r_R__0__0ab_Boolean == null)
				{
					r_R__0__0ab_Boolean = new(this, "#0ab", 0, typeof(System.Boolean));
					r_R__0__0ab_Boolean.SetBelong(this.instance);
				}
				return r_R__0__0ab_Boolean;
			}
		}

		/// <summary>
		/// Void Init()
		/// </summary>
		protected RMethod r_RInit;
		public virtual RMethod RInit
		{
			get
			{
				if(r_RInit == null)
				{
					r_RInit = new(this, "Init", 0);
					r_RInit.SetBelong(this.instance);
				}
				return r_RInit;
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


        public RCombatEvent() : base("CombatEvent")
        {
        }

        public RCombatEvent(System.Object instance) : base("CombatEvent")
		{
            SetInstance(instance);
		}

        public RCombatEvent(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCombatEvent(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__w9()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__w9.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__x9()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__x9.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__v7()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__v7.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void UnRegisterFighter(GameDefineType.ID  @idFighter, System.Boolean  @isDel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @isDel};
            var ___result = RUnRegisterFighter_ID_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__z9()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__z9.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__A9()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__A9.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Boolean __0__W8(System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, System.Boolean  @isInjureFinish)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@aniName, @subDamegeEffectName, @isShowDamage, @isInjureFinish};
            var ___result = R__0__W8_String_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.GameObject __0__C9(UnityEngine.GameObject  @prefab, UnityEngine.Texture2D  @tex, UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefab, @tex, @pos};
            var ___result = R__0__C9_GameObject_Texture2D_Vector3.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void __0__D9(GameDefineType.ID  @idFighter, System.Int32  @num, EffectResult  @er, System.Int32  @hp_mp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @num, @er, @hp_mp};
            var ___result = R__0__D9_ID_Int32_EffectResult_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__E9(GameDefineType.ID  @idFighter, System.Boolean  @isSub, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @isSub, @subDamegeEffectName, @isShowDamage};
            var ___result = R__0__E9_ID_Boolean_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__F9(GameDefineType.ID  @idFighter, System.String  @strField, System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @strField, @value};
            var ___result = R__0__F9_ID_String_String.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__H9(GameDefineType.ID  @idFighter, GameDefineType.ID  @idBuff)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @idBuff};
            var ___result = R__0__H9_ID_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__VC(GameDefineType.ID  @idFighter, GameDefineType.ID  @idBuff, System.Int32  @level, System.Int32  @nRound, System.Int32  @power1, System.Int32  @power2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @idBuff, @level, @nRound, @power1, @power2};
            var ___result = R__0__VC_ID_ID_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__I9(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = R__0__I9_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__I9(GameDefineType.ID  @idFighter, System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @type};
            var ___result = R__0__I9_ID_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GameObject __0__J9(GameDefineType.ID  @idFighter, UnityEngine.Object  @orgObj, GameDefineType.ID  @idBuff, System.String  @buffTyp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @orgObj, @idBuff, @buffTyp};
            var ___result = R__0__J9_ID_Object_ID_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void __0__K9(GameDefineType.ID  @idFighter, GameDefineType.ID  @buffID, System.Int32  @level, System.Int32  @nRound, System.Int32  @power1, System.Int32  @power2, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, System.Boolean  @isAnimationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @buffID, @level, @nRound, @power1, @power2, @isSub, @aniName, @subDamegeEffectName, @isShowDamage, @isAnimationAction};
            var ___result = R__0__K9_ID_ID_Int32_Int32_Int32_Int32_Boolean_String_String_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__L9(GameDefineType.ID  @idFighter, GameDefineType.ID  @buffID, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter, @buffID, @isSub, @aniName, @subDamegeEffectName, @isShowDamage};
            var ___result = R__0__L9_ID_ID_Boolean_String_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__M9(GameDefineType.ID  @resultOwnerID, System.Int32  @mHP, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, EffectResult  @mRE)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @mHP, @isSub, @aniName, @subDamegeEffectName, @isShowDamage, @mRE};
            var ___result = R__0__M9_ID_Int32_Boolean_String_String_Boolean_EffectResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__N9(GameDefineType.ID  @resultOwnerID, System.Int32  @mHP, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, EffectResult  @mRE, System.Boolean  @isAnimationAction)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @mHP, @isSub, @aniName, @subDamegeEffectName, @isShowDamage, @mRE, @isAnimationAction};
            var ___result = R__0__N9_ID_Int32_Boolean_String_String_Boolean_EffectResult_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__O9(GameDefineType.ID  @resultOwnerID, System.Int32  @mMp, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, EffectResult  @mRE)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @mMp, @isSub, @aniName, @subDamegeEffectName, @isShowDamage, @mRE};
            var ___result = R__0__O9_ID_Int32_Boolean_String_String_Boolean_EffectResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__P9(GameDefineType.ID  @resultOwnerID, System.Int32  @mMp, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, EffectResult  @mResultEffect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @mMp, @isSub, @aniName, @subDamegeEffectName, @isShowDamage, @mResultEffect};
            var ___result = R__0__P9_ID_Int32_Boolean_String_String_Boolean_EffectResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Q9(GameDefineType.ID  @resultOwnerID, System.Int32  @mSL, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, EffectResult  @mRE)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @mSL, @isSub, @aniName, @subDamegeEffectName, @isShowDamage, @mRE};
            var ___result = R__0__Q9_ID_Int32_Boolean_String_String_Boolean_EffectResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__R9(GameDefineType.ID  @resultOwnerID, System.Int32  @mSt, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, EffectResult  @mRE)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @mSt, @isSub, @aniName, @subDamegeEffectName, @isShowDamage, @mRE};
            var ___result = R__0__R9_ID_Int32_Boolean_String_String_Boolean_EffectResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__S9(GameDefineType.ID  @resultOwnerID, System.Boolean  @isSub, System.String  @aniName, System.String  @subDamegeEffectName, System.Boolean  @isShowDamage, EffectResult  @mRE)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @isSub, @aniName, @subDamegeEffectName, @isShowDamage, @mRE};
            var ___result = R__0__S9_ID_Boolean_String_String_Boolean_EffectResult.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__T9(GameDefineType.ID  @resultOwnerID, System.String  @msg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @msg};
            var ___result = R__0__T9_ID_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__U9(GameDefineType.ID  @resultOwnerID, System.Int32  @mSl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resultOwnerID, @mSl};
            var ___result = R__0__U9_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__W9(GameDefineType.ID  @idActive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idActive};
            var ___result = R__0__W9_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__Nzf(GameDefineType.ID  @idActive, UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idActive, @obj};
            var ___result = R__0__Nzf_ID_GameObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__X9()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__X9.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__W9()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__W9.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__Nzf(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = R__0__Nzf_GameObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__Y9(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = R__0__Y9_GameObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Z9()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Z9.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LeaveCombat(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = RLeaveCombat_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void EnterCombat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = REnterCombat.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__09()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__09.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__19()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__19.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<GameDefineType.ID> __0__29()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__29.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }


        public virtual System.UInt32 __0__39(GameDefineType.ID  @idFighter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idFighter};
            var ___result = R__0__39_ID.Invoke(___genericsType, ___parameters);

            return (System.UInt32)___result;
        }


        public virtual void __0__37d(System.String  @msgUrl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@msgUrl};
            var ___result = R__0__37d_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.String> GetEffectUrls(System.Boolean  @isMounsterResource)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isMounsterResource};
            var ___result = RGetEffectUrls_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual void __0__49()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__49.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__59()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__59.Invoke(___genericsType, ___parameters);

            
        }
























        public virtual void __0__oab(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = R__0__oab_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__pab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__pab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__qab(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = R__0__qab_GameObject.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__4Dd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__4Dd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__rab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__nab(System.String  @screenFadeEffectParam)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@screenFadeEffectParam};
            var ___result = R__0__nab_String.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__vab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__vab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__wab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wab.Invoke(___genericsType, ___parameters);

            
        }
























        public virtual void __0__5hj(UnityEngine.GameObject  @mMobmod, System.UInt32  @career, GameDefineType.ID  @idCreature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mMobmod, @career, @idCreature};
            var ___result = R__0__5hj_GameObject_UInt32_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__wSf(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = R__0__wSf_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Oab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Oab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__Pab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Pab.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Qab(System.Int32  @x, System.Int32  @y)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y};
            var ___result = R__0__Qab_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Qab(GameDefineType.ID  @idCreature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idCreature};
            var ___result = R__0__Qab_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean __0__Rab(GameDefineType.ID  @idCreature)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idCreature};
            var ___result = R__0__Rab_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object __0__Sab(System.Boolean  @isFriendGroup, System.Int32  @fighterTyp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isFriendGroup, @fighterTyp};
            var ___result = R__0__Sab_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Uab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Uab.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Boolean __0__Wab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Wab.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void __0__Yab()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Yab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Zab(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = R__0__Zab_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__0ab(System.Boolean  @isMyGroup)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isMyGroup};
            var ___result = R__0__0ab_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
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
