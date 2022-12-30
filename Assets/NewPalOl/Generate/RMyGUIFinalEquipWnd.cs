using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MyGUIFinalEquipWnd
	/// </summary>
    public partial class RMyGUIFinalEquipWnd : RMember //
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
					r___0__a = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// #oU.#5bb #b
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__b;
		public virtual R__0__oU.R__0__5bb R__0__b
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
		/// System.Collections.Generic.Dictionary`2[EquipTab,#oU.#5bb] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__5bb> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__5bb> R__0__c
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
		/// System.Collections.Generic.Dictionary`2[EquipTab,#oU.#uU] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__uU> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__uU> R__0__d
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
		/// #oU.#5bb #e
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__e;
		public virtual R__0__oU.R__0__5bb R__0__e
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
		/// #oU.#5bb #f
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__f;
		public virtual R__0__oU.R__0__5bb R__0__f
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
		/// UnityEngine.Rect #g
		/// </summary>
		protected RUnityEngine.RRect r___0__g;
		public virtual RUnityEngine.RRect R__0__g
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
		/// EquipTab #h
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
		/// System.Int32[] #i
		/// </summary>
		protected static RFieldArray<RField> r___0__i;
		public static RFieldArray<RField> R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#i");
					r___0__i.SetBelong(null);
				}
				return r___0__i;
			}
		}

		/// <summary>
		/// EquipTab #j
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
		/// System.Collections.Generic.Dictionary`2[MyGUI.ElementBase,UIeffect] #k
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUIeffect> r___0__k;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RMyGUI.RElementBase, RUIeffect> R__0__k
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
		/// #oU.#5bb #l
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__l;
		public virtual R__0__oU.R__0__5bb R__0__l
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
		/// System.String #m
		/// </summary>
		protected RField r___0__m;
		public virtual RField R__0__m
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
		/// System.String #n
		/// </summary>
		protected RField r___0__n;
		public virtual RField R__0__n
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
		/// System.String #o
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
		/// MyGUI.ElementBase #p
		/// </summary>
		protected RMyGUI.RElementBase r___0__p;
		public virtual RMyGUI.RElementBase R__0__p
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
		/// #oU.#x3 #q
		/// </summary>
		protected R__0__oU.R__0__x3 r___0__q;
		public virtual R__0__oU.R__0__x3 R__0__q
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
		/// System.Collections.Generic.List`1[GameDefineType.ID] #r
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r___0__r;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R__0__r
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
		/// Pet #s
		/// </summary>
		protected RPet r___0__s;
		public virtual RPet R__0__s
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
		/// System.Int32 #t
		/// </summary>
		protected RField r___0__t;
		public virtual RField R__0__t
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
		/// System.Int32 #u
		/// </summary>
		protected RField r___0__u;
		public virtual RField R__0__u
		{
			get
			{
				if(r___0__u == null)
				{
					r___0__u = new(this, "#u");
					r___0__u.SetBelong(this.instance);
				}
				return r___0__u;
			}
		}

		/// <summary>
		/// MyGUIFinalEquipWnd+EquipPlaceType #v
		/// </summary>
		protected RField r___0__v;
		public virtual RField R__0__v
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
		/// System.Collections.Generic.Dictionary`2[EquipTab,System.Int32] #w
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__w;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__w
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
		/// #oU.#5bb #x
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__x;
		public virtual R__0__oU.R__0__5bb R__0__x
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
		/// #oU.#5bb #y
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__y;
		public virtual R__0__oU.R__0__5bb R__0__y
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
		/// System.Int32 #z
		/// </summary>
		protected static RField r___0__z;
		public static RField R__0__z
		{
			get
			{
				if(r___0__z == null)
				{
					r___0__z = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#z");
					r___0__z.SetBelong(null);
				}
				return r___0__z;
			}
		}

		/// <summary>
		/// System.Int32 #A
		/// </summary>
		protected static RField r___0__A;
		public static RField R__0__A
		{
			get
			{
				if(r___0__A == null)
				{
					r___0__A = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#A");
					r___0__A.SetBelong(null);
				}
				return r___0__A;
			}
		}

		/// <summary>
		/// System.Int32 #B
		/// </summary>
		protected static RField r___0__B;
		public static RField R__0__B
		{
			get
			{
				if(r___0__B == null)
				{
					r___0__B = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#B");
					r___0__B.SetBelong(null);
				}
				return r___0__B;
			}
		}

		/// <summary>
		/// System.Int32 #C
		/// </summary>
		protected RField r___0__C;
		public virtual RField R__0__C
		{
			get
			{
				if(r___0__C == null)
				{
					r___0__C = new(this, "#C");
					r___0__C.SetBelong(this.instance);
				}
				return r___0__C;
			}
		}

		/// <summary>
		/// System.Int32 #D
		/// </summary>
		protected RField r___0__D;
		public virtual RField R__0__D
		{
			get
			{
				if(r___0__D == null)
				{
					r___0__D = new(this, "#D");
					r___0__D.SetBelong(this.instance);
				}
				return r___0__D;
			}
		}

		/// <summary>
		/// System.Int32 #E
		/// </summary>
		protected RField r___0__E;
		public virtual RField R__0__E
		{
			get
			{
				if(r___0__E == null)
				{
					r___0__E = new(this, "#E");
					r___0__E.SetBelong(this.instance);
				}
				return r___0__E;
			}
		}

		/// <summary>
		/// System.Int32 #F
		/// </summary>
		protected RField r___0__F;
		public virtual RField R__0__F
		{
			get
			{
				if(r___0__F == null)
				{
					r___0__F = new(this, "#F");
					r___0__F.SetBelong(this.instance);
				}
				return r___0__F;
			}
		}

		/// <summary>
		/// #u.#Ckb #G
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__G;
		public virtual R__0__u.R__0__Ckb R__0__G
		{
			get
			{
				if(r___0__G == null)
				{
					r___0__G = new(this, "#G");
					r___0__G.SetBelong(this.instance);
				}
				return r___0__G;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Ckb] #H
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> r___0__H;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> R__0__H
		{
			get
			{
				if(r___0__H == null)
				{
					r___0__H = new(this, "#H");
					r___0__H.SetBelong(this.instance);
				}
				return r___0__H;
			}
		}

		/// <summary>
		/// System.Int32 #I
		/// </summary>
		protected static RField r___0__I;
		public static RField R__0__I
		{
			get
			{
				if(r___0__I == null)
				{
					r___0__I = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#I");
					r___0__I.SetBelong(null);
				}
				return r___0__I;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #J
		/// </summary>
		protected RUnityEngine.RGameObject r___0__J;
		public virtual RUnityEngine.RGameObject R__0__J
		{
			get
			{
				if(r___0__J == null)
				{
					r___0__J = new(this, "#J");
					r___0__J.SetBelong(this.instance);
				}
				return r___0__J;
			}
		}

		/// <summary>
		/// GameDefineType.ID #K
		/// </summary>
		protected RGameDefineType.RID r___0__K;
		public virtual RGameDefineType.RID R__0__K
		{
			get
			{
				if(r___0__K == null)
				{
					r___0__K = new(this, "#K");
					r___0__K.SetBelong(this.instance);
				}
				return r___0__K;
			}
		}

		/// <summary>
		/// GameDefineType.ID #L
		/// </summary>
		protected RGameDefineType.RID r___0__L;
		public virtual RGameDefineType.RID R__0__L
		{
			get
			{
				if(r___0__L == null)
				{
					r___0__L = new(this, "#L");
					r___0__L.SetBelong(this.instance);
				}
				return r___0__L;
			}
		}

		/// <summary>
		/// AvatarController+weaponInfo #M
		/// </summary>
		protected RAvatarController.RweaponInfo r___0__M;
		public virtual RAvatarController.RweaponInfo R__0__M
		{
			get
			{
				if(r___0__M == null)
				{
					r___0__M = new(this, "#M");
					r___0__M.SetBelong(this.instance);
				}
				return r___0__M;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.Transform] #N
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTransform> r___0__N;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RTransform> R__0__N
		{
			get
			{
				if(r___0__N == null)
				{
					r___0__N = new(this, "#N");
					r___0__N.SetBelong(this.instance);
				}
				return r___0__N;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[#u.#Ckb,MyGUI.ElementBase] #O
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<R__0__u.R__0__Ckb, RMyGUI.RElementBase> r___0__O;
		public virtual RSystem.RCollections.RGeneric.RDictionary<R__0__u.R__0__Ckb, RMyGUI.RElementBase> R__0__O
		{
			get
			{
				if(r___0__O == null)
				{
					r___0__O = new(this, "#O");
					r___0__O.SetBelong(this.instance);
				}
				return r___0__O;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[#u.#Ckb,MyGUI.ElementBase] #P
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<R__0__u.R__0__Ckb, RMyGUI.RElementBase> r___0__P;
		public virtual RSystem.RCollections.RGeneric.RDictionary<R__0__u.R__0__Ckb, RMyGUI.RElementBase> R__0__P
		{
			get
			{
				if(r___0__P == null)
				{
					r___0__P = new(this, "#P");
					r___0__P.SetBelong(this.instance);
				}
				return r___0__P;
			}
		}

		/// <summary>
		/// System.Int32 #Q
		/// </summary>
		protected RField r___0__Q;
		public virtual RField R__0__Q
		{
			get
			{
				if(r___0__Q == null)
				{
					r___0__Q = new(this, "#Q");
					r___0__Q.SetBelong(this.instance);
				}
				return r___0__Q;
			}
		}

		/// <summary>
		/// System.Boolean #R
		/// </summary>
		protected RField r___0__R;
		public virtual RField R__0__R
		{
			get
			{
				if(r___0__R == null)
				{
					r___0__R = new(this, "#R");
					r___0__R.SetBelong(this.instance);
				}
				return r___0__R;
			}
		}

		/// <summary>
		/// System.String[] #S
		/// </summary>
		protected RFieldArray<RField> r___0__S;
		public virtual RFieldArray<RField> R__0__S
		{
			get
			{
				if(r___0__S == null)
				{
					r___0__S = new(this, "#S");
					r___0__S.SetBelong(this.instance);
				}
				return r___0__S;
			}
		}

		/// <summary>
		/// #oU.#5bb #T
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__T;
		public virtual R__0__oU.R__0__5bb R__0__T
		{
			get
			{
				if(r___0__T == null)
				{
					r___0__T = new(this, "#T");
					r___0__T.SetBelong(this.instance);
				}
				return r___0__T;
			}
		}

		/// <summary>
		/// #oU.#GW #U
		/// </summary>
		protected R__0__oU.R__0__GW r___0__U;
		public virtual R__0__oU.R__0__GW R__0__U
		{
			get
			{
				if(r___0__U == null)
				{
					r___0__U = new(this, "#U");
					r___0__U.SetBelong(this.instance);
				}
				return r___0__U;
			}
		}

		/// <summary>
		/// System.Int32 #V
		/// </summary>
		protected static RField r___0__V;
		public static RField R__0__V
		{
			get
			{
				if(r___0__V == null)
				{
					r___0__V = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#V");
					r___0__V.SetBelong(null);
				}
				return r___0__V;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle #W
		/// </summary>
		protected RUnityEngine.RGUIStyle r___0__W;
		public virtual RUnityEngine.RGUIStyle R__0__W
		{
			get
			{
				if(r___0__W == null)
				{
					r___0__W = new(this, "#W");
					r___0__W.SetBelong(this.instance);
				}
				return r___0__W;
			}
		}

		/// <summary>
		/// System.Int32 #X
		/// </summary>
		protected RField r___0__X;
		public virtual RField R__0__X
		{
			get
			{
				if(r___0__X == null)
				{
					r___0__X = new(this, "#X");
					r___0__X.SetBelong(this.instance);
				}
				return r___0__X;
			}
		}

		/// <summary>
		/// MyGUIFinalEquipWnd+#Wwd #Y
		/// </summary>
		protected RField r___0__Y;
		public virtual RField R__0__Y
		{
			get
			{
				if(r___0__Y == null)
				{
					r___0__Y = new(this, "#Y");
					r___0__Y.SetBelong(this.instance);
				}
				return r___0__Y;
			}
		}

		/// <summary>
		/// System.Boolean #Z
		/// </summary>
		protected RField r___0__Z;
		public virtual RField R__0__Z
		{
			get
			{
				if(r___0__Z == null)
				{
					r___0__Z = new(this, "#Z");
					r___0__Z.SetBelong(this.instance);
				}
				return r___0__Z;
			}
		}

		/// <summary>
		/// System.Int32 #0
		/// </summary>
		protected static RField r___0__0;
		public static RField R__0__0
		{
			get
			{
				if(r___0__0 == null)
				{
					r___0__0 = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#0");
					r___0__0.SetBelong(null);
				}
				return r___0__0;
			}
		}

		/// <summary>
		/// System.Int32 #1
		/// </summary>
		protected RField r___0__1;
		public virtual RField R__0__1
		{
			get
			{
				if(r___0__1 == null)
				{
					r___0__1 = new(this, "#1");
					r___0__1.SetBelong(this.instance);
				}
				return r___0__1;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Int32] #2
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__2;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__2
		{
			get
			{
				if(r___0__2 == null)
				{
					r___0__2 = new(this, "#2");
					r___0__2.SetBelong(this.instance);
				}
				return r___0__2;
			}
		}

		/// <summary>
		/// System.Single #3
		/// </summary>
		protected static RField r___0__3;
		public static RField R__0__3
		{
			get
			{
				if(r___0__3 == null)
				{
					r___0__3 = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#3");
					r___0__3.SetBelong(null);
				}
				return r___0__3;
			}
		}

		/// <summary>
		/// System.Boolean #4
		/// </summary>
		protected RField r___0__4;
		public virtual RField R__0__4
		{
			get
			{
				if(r___0__4 == null)
				{
					r___0__4 = new(this, "#4");
					r___0__4.SetBelong(this.instance);
				}
				return r___0__4;
			}
		}

		/// <summary>
		/// System.Single #5
		/// </summary>
		protected RField r___0__5;
		public virtual RField R__0__5
		{
			get
			{
				if(r___0__5 == null)
				{
					r___0__5 = new(this, "#5");
					r___0__5.SetBelong(this.instance);
				}
				return r___0__5;
			}
		}

		/// <summary>
		/// #u.#Ckb #6
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__6;
		public virtual R__0__u.R__0__Ckb R__0__6
		{
			get
			{
				if(r___0__6 == null)
				{
					r___0__6 = new(this, "#6");
					r___0__6.SetBelong(this.instance);
				}
				return r___0__6;
			}
		}

		/// <summary>
		/// System.Boolean #7
		/// </summary>
		protected RField r___0__7;
		public virtual RField R__0__7
		{
			get
			{
				if(r___0__7 == null)
				{
					r___0__7 = new(this, "#7");
					r___0__7.SetBelong(this.instance);
				}
				return r___0__7;
			}
		}

		/// <summary>
		/// System.Boolean #8
		/// </summary>
		protected RField r___0__8;
		public virtual RField R__0__8
		{
			get
			{
				if(r___0__8 == null)
				{
					r___0__8 = new(this, "#8");
					r___0__8.SetBelong(this.instance);
				}
				return r___0__8;
			}
		}

		/// <summary>
		/// System.Boolean #9
		/// </summary>
		protected RField r___0__9;
		public virtual RField R__0__9
		{
			get
			{
				if(r___0__9 == null)
				{
					r___0__9 = new(this, "#9");
					r___0__9.SetBelong(this.instance);
				}
				return r___0__9;
			}
		}

		/// <summary>
		/// #u.#Ckb #ab
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__ab;
		public virtual R__0__u.R__0__Ckb R__0__ab
		{
			get
			{
				if(r___0__ab == null)
				{
					r___0__ab = new(this, "#ab");
					r___0__ab.SetBelong(this.instance);
				}
				return r___0__ab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,System.Collections.Generic.KeyValuePair`2[System.String,System.Int32]] #bb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RKeyValuePair<RField, RField>> r___0__bb;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RKeyValuePair<RField, RField>> R__0__bb
		{
			get
			{
				if(r___0__bb == null)
				{
					r___0__bb = new(this, "#bb");
					r___0__bb.SetBelong(this.instance);
				}
				return r___0__bb;
			}
		}

		/// <summary>
		/// #oU.#5bb #cb
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__cb;
		public virtual R__0__oU.R__0__5bb R__0__cb
		{
			get
			{
				if(r___0__cb == null)
				{
					r___0__cb = new(this, "#cb");
					r___0__cb.SetBelong(this.instance);
				}
				return r___0__cb;
			}
		}

		/// <summary>
		/// #oU.#5bb #db
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__db;
		public virtual R__0__oU.R__0__5bb R__0__db
		{
			get
			{
				if(r___0__db == null)
				{
					r___0__db = new(this, "#db");
					r___0__db.SetBelong(this.instance);
				}
				return r___0__db;
			}
		}

		/// <summary>
		/// #oU.#5bb #eb
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__eb;
		public virtual R__0__oU.R__0__5bb R__0__eb
		{
			get
			{
				if(r___0__eb == null)
				{
					r___0__eb = new(this, "#eb");
					r___0__eb.SetBelong(this.instance);
				}
				return r___0__eb;
			}
		}

		/// <summary>
		/// #oU.#5bb #fb
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__fb;
		public virtual R__0__oU.R__0__5bb R__0__fb
		{
			get
			{
				if(r___0__fb == null)
				{
					r___0__fb = new(this, "#fb");
					r___0__fb.SetBelong(this.instance);
				}
				return r___0__fb;
			}
		}

		/// <summary>
		/// #oU.#5bb #gb
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__gb;
		public virtual R__0__oU.R__0__5bb R__0__gb
		{
			get
			{
				if(r___0__gb == null)
				{
					r___0__gb = new(this, "#gb");
					r___0__gb.SetBelong(this.instance);
				}
				return r___0__gb;
			}
		}

		/// <summary>
		/// #oU.#5bb #hb
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__hb;
		public virtual R__0__oU.R__0__5bb R__0__hb
		{
			get
			{
				if(r___0__hb == null)
				{
					r___0__hb = new(this, "#hb");
					r___0__hb.SetBelong(this.instance);
				}
				return r___0__hb;
			}
		}

		/// <summary>
		/// #oU.#I1 #ib
		/// </summary>
		protected R__0__oU.R__0__I1 r___0__ib;
		public virtual R__0__oU.R__0__I1 R__0__ib
		{
			get
			{
				if(r___0__ib == null)
				{
					r___0__ib = new(this, "#ib");
					r___0__ib.SetBelong(this.instance);
				}
				return r___0__ib;
			}
		}

		/// <summary>
		/// MyGUIFinalEquipWnd+#Xwd #jb
		/// </summary>
		protected RField r___0__jb;
		public virtual RField R__0__jb
		{
			get
			{
				if(r___0__jb == null)
				{
					r___0__jb = new(this, "#jb");
					r___0__jb.SetBelong(this.instance);
				}
				return r___0__jb;
			}
		}

		/// <summary>
		/// System.Int32 #kb
		/// </summary>
		protected RField r___0__kb;
		public virtual RField R__0__kb
		{
			get
			{
				if(r___0__kb == null)
				{
					r___0__kb = new(this, "#kb");
					r___0__kb.SetBelong(this.instance);
				}
				return r___0__kb;
			}
		}

		/// <summary>
		/// System.Int32 #lb
		/// </summary>
		protected RField r___0__lb;
		public virtual RField R__0__lb
		{
			get
			{
				if(r___0__lb == null)
				{
					r___0__lb = new(this, "#lb");
					r___0__lb.SetBelong(this.instance);
				}
				return r___0__lb;
			}
		}

		/// <summary>
		/// System.Int32 #mb
		/// </summary>
		protected RField r___0__mb;
		public virtual RField R__0__mb
		{
			get
			{
				if(r___0__mb == null)
				{
					r___0__mb = new(this, "#mb");
					r___0__mb.SetBelong(this.instance);
				}
				return r___0__mb;
			}
		}

		/// <summary>
		/// GameDefineType.ID #nb
		/// </summary>
		protected RGameDefineType.RID r___0__nb;
		public virtual RGameDefineType.RID R__0__nb
		{
			get
			{
				if(r___0__nb == null)
				{
					r___0__nb = new(this, "#nb");
					r___0__nb.SetBelong(this.instance);
				}
				return r___0__nb;
			}
		}

		/// <summary>
		/// System.Int32 #ob
		/// </summary>
		protected RField r___0__ob;
		public virtual RField R__0__ob
		{
			get
			{
				if(r___0__ob == null)
				{
					r___0__ob = new(this, "#ob");
					r___0__ob.SetBelong(this.instance);
				}
				return r___0__ob;
			}
		}

		/// <summary>
		/// System.Int32 #pb
		/// </summary>
		protected RField r___0__pb;
		public virtual RField R__0__pb
		{
			get
			{
				if(r___0__pb == null)
				{
					r___0__pb = new(this, "#pb");
					r___0__pb.SetBelong(this.instance);
				}
				return r___0__pb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] #qb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__qb;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__qb
		{
			get
			{
				if(r___0__qb == null)
				{
					r___0__qb = new(this, "#qb");
					r___0__qb.SetBelong(this.instance);
				}
				return r___0__qb;
			}
		}

		/// <summary>
		/// System.Int32[] #rb
		/// </summary>
		protected RFieldArray<RField> r___0__rb;
		public virtual RFieldArray<RField> R__0__rb
		{
			get
			{
				if(r___0__rb == null)
				{
					r___0__rb = new(this, "#rb");
					r___0__rb.SetBelong(this.instance);
				}
				return r___0__rb;
			}
		}

		/// <summary>
		/// #u.#Ckb #sb
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__sb;
		public virtual R__0__u.R__0__Ckb R__0__sb
		{
			get
			{
				if(r___0__sb == null)
				{
					r___0__sb = new(this, "#sb");
					r___0__sb.SetBelong(this.instance);
				}
				return r___0__sb;
			}
		}

		/// <summary>
		/// System.Boolean #tb
		/// </summary>
		protected RField r___0__tb;
		public virtual RField R__0__tb
		{
			get
			{
				if(r___0__tb == null)
				{
					r___0__tb = new(this, "#tb");
					r___0__tb.SetBelong(this.instance);
				}
				return r___0__tb;
			}
		}

		/// <summary>
		/// #oU.#X4 #ub
		/// </summary>
		protected R__0__oU.R__0__X4 r___0__ub;
		public virtual R__0__oU.R__0__X4 R__0__ub
		{
			get
			{
				if(r___0__ub == null)
				{
					r___0__ub = new(this, "#ub");
					r___0__ub.SetBelong(this.instance);
				}
				return r___0__ub;
			}
		}

		/// <summary>
		/// #oU.#GW #vb
		/// </summary>
		protected R__0__oU.R__0__GW r___0__vb;
		public virtual R__0__oU.R__0__GW R__0__vb
		{
			get
			{
				if(r___0__vb == null)
				{
					r___0__vb = new(this, "#vb");
					r___0__vb.SetBelong(this.instance);
				}
				return r___0__vb;
			}
		}

		/// <summary>
		/// System.Boolean #wb
		/// </summary>
		protected RField r___0__wb;
		public virtual RField R__0__wb
		{
			get
			{
				if(r___0__wb == null)
				{
					r___0__wb = new(this, "#wb");
					r___0__wb.SetBelong(this.instance);
				}
				return r___0__wb;
			}
		}

		/// <summary>
		/// System.Single #xb
		/// </summary>
		protected static RField r___0__xb;
		public static RField R__0__xb
		{
			get
			{
				if(r___0__xb == null)
				{
					r___0__xb = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#xb");
					r___0__xb.SetBelong(null);
				}
				return r___0__xb;
			}
		}

		/// <summary>
		/// System.Int32 #yb
		/// </summary>
		protected static RField r___0__yb;
		public static RField R__0__yb
		{
			get
			{
				if(r___0__yb == null)
				{
					r___0__yb = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#yb");
					r___0__yb.SetBelong(null);
				}
				return r___0__yb;
			}
		}

		/// <summary>
		/// System.Single #zb
		/// </summary>
		protected RField r___0__zb;
		public virtual RField R__0__zb
		{
			get
			{
				if(r___0__zb == null)
				{
					r___0__zb = new(this, "#zb");
					r___0__zb.SetBelong(this.instance);
				}
				return r___0__zb;
			}
		}

		/// <summary>
		/// System.Int32 #Ab
		/// </summary>
		protected RField r___0__Ab;
		public virtual RField R__0__Ab
		{
			get
			{
				if(r___0__Ab == null)
				{
					r___0__Ab = new(this, "#Ab");
					r___0__Ab.SetBelong(this.instance);
				}
				return r___0__Ab;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] #Bb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__Bb;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__Bb
		{
			get
			{
				if(r___0__Bb == null)
				{
					r___0__Bb = new(this, "#Bb");
					r___0__Bb.SetBelong(this.instance);
				}
				return r___0__Bb;
			}
		}

		/// <summary>
		/// System.Int32 #Cb
		/// </summary>
		protected static RField r___0__Cb;
		public static RField R__0__Cb
		{
			get
			{
				if(r___0__Cb == null)
				{
					r___0__Cb = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#Cb");
					r___0__Cb.SetBelong(null);
				}
				return r___0__Cb;
			}
		}

		/// <summary>
		/// MagicWeaponTypePag #Db
		/// </summary>
		protected RField r___0__Db;
		public virtual RField R__0__Db
		{
			get
			{
				if(r___0__Db == null)
				{
					r___0__Db = new(this, "#Db");
					r___0__Db.SetBelong(this.instance);
				}
				return r___0__Db;
			}
		}

		/// <summary>
		/// System.Int32 #Eb
		/// </summary>
		protected static RField r___0__Eb;
		public static RField R__0__Eb
		{
			get
			{
				if(r___0__Eb == null)
				{
					r___0__Eb = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#Eb");
					r___0__Eb.SetBelong(null);
				}
				return r___0__Eb;
			}
		}

		/// <summary>
		/// System.Int32 #Fb
		/// </summary>
		protected static RField r___0__Fb;
		public static RField R__0__Fb
		{
			get
			{
				if(r___0__Fb == null)
				{
					r___0__Fb = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#Fb");
					r___0__Fb.SetBelong(null);
				}
				return r___0__Fb;
			}
		}

		/// <summary>
		/// System.Boolean #Gb
		/// </summary>
		protected RField r___0__Gb;
		public virtual RField R__0__Gb
		{
			get
			{
				if(r___0__Gb == null)
				{
					r___0__Gb = new(this, "#Gb");
					r___0__Gb.SetBelong(this.instance);
				}
				return r___0__Gb;
			}
		}

		/// <summary>
		/// System.Int32 #Hb
		/// </summary>
		protected RField r___0__Hb;
		public virtual RField R__0__Hb
		{
			get
			{
				if(r___0__Hb == null)
				{
					r___0__Hb = new(this, "#Hb");
					r___0__Hb.SetBelong(this.instance);
				}
				return r___0__Hb;
			}
		}

		/// <summary>
		/// System.Int32 #Ib
		/// </summary>
		protected RField r___0__Ib;
		public virtual RField R__0__Ib
		{
			get
			{
				if(r___0__Ib == null)
				{
					r___0__Ib = new(this, "#Ib");
					r___0__Ib.SetBelong(this.instance);
				}
				return r___0__Ib;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Ckb] #Jb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> r___0__Jb;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> R__0__Jb
		{
			get
			{
				if(r___0__Jb == null)
				{
					r___0__Jb = new(this, "#Jb");
					r___0__Jb.SetBelong(this.instance);
				}
				return r___0__Jb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #Kb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r___0__Kb;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R__0__Kb
		{
			get
			{
				if(r___0__Kb == null)
				{
					r___0__Kb = new(this, "#Kb");
					r___0__Kb.SetBelong(this.instance);
				}
				return r___0__Kb;
			}
		}

		/// <summary>
		/// System.Int32 #Lb
		/// </summary>
		protected static RField r___0__Lb;
		public static RField R__0__Lb
		{
			get
			{
				if(r___0__Lb == null)
				{
					r___0__Lb = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#Lb");
					r___0__Lb.SetBelong(null);
				}
				return r___0__Lb;
			}
		}

		/// <summary>
		/// System.Int32 #Mb
		/// </summary>
		protected static RField r___0__Mb;
		public static RField R__0__Mb
		{
			get
			{
				if(r___0__Mb == null)
				{
					r___0__Mb = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#Mb");
					r___0__Mb.SetBelong(null);
				}
				return r___0__Mb;
			}
		}

		/// <summary>
		/// System.Int32 #Nb
		/// </summary>
		protected RField r___0__Nb;
		public virtual RField R__0__Nb
		{
			get
			{
				if(r___0__Nb == null)
				{
					r___0__Nb = new(this, "#Nb");
					r___0__Nb.SetBelong(this.instance);
				}
				return r___0__Nb;
			}
		}

		/// <summary>
		/// System.Int32 #Ob
		/// </summary>
		protected RField r___0__Ob;
		public virtual RField R__0__Ob
		{
			get
			{
				if(r___0__Ob == null)
				{
					r___0__Ob = new(this, "#Ob");
					r___0__Ob.SetBelong(this.instance);
				}
				return r___0__Ob;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Ckb] #Pb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> r___0__Pb;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> R__0__Pb
		{
			get
			{
				if(r___0__Pb == null)
				{
					r___0__Pb = new(this, "#Pb");
					r___0__Pb.SetBelong(this.instance);
				}
				return r___0__Pb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #Qb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r___0__Qb;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R__0__Qb
		{
			get
			{
				if(r___0__Qb == null)
				{
					r___0__Qb = new(this, "#Qb");
					r___0__Qb.SetBelong(this.instance);
				}
				return r___0__Qb;
			}
		}

		/// <summary>
		/// #u.#Ckb #Rb
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__Rb;
		public virtual R__0__u.R__0__Ckb R__0__Rb
		{
			get
			{
				if(r___0__Rb == null)
				{
					r___0__Rb = new(this, "#Rb");
					r___0__Rb.SetBelong(this.instance);
				}
				return r___0__Rb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[GameDefineType.ID]]] #Sb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RGameDefineType.RID>>> r___0__Sb;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RGameDefineType.RID>>> R__0__Sb
		{
			get
			{
				if(r___0__Sb == null)
				{
					r___0__Sb = new(this, "#Sb");
					r___0__Sb.SetBelong(this.instance);
				}
				return r___0__Sb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,#oU.#uU] #Tb
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__uU> r___0__Tb;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__uU> R__0__Tb
		{
			get
			{
				if(r___0__Tb == null)
				{
					r___0__Tb = new(this, "#Tb");
					r___0__Tb.SetBelong(this.instance);
				}
				return r___0__Tb;
			}
		}

		/// <summary>
		/// System.Int32 #Ub
		/// </summary>
		protected RField r___0__Ub;
		public virtual RField R__0__Ub
		{
			get
			{
				if(r___0__Ub == null)
				{
					r___0__Ub = new(this, "#Ub");
					r___0__Ub.SetBelong(this.instance);
				}
				return r___0__Ub;
			}
		}

		/// <summary>
		/// #oU.#5bb #Vb
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__Vb;
		public virtual R__0__oU.R__0__5bb R__0__Vb
		{
			get
			{
				if(r___0__Vb == null)
				{
					r___0__Vb = new(this, "#Vb");
					r___0__Vb.SetBelong(this.instance);
				}
				return r___0__Vb;
			}
		}

		/// <summary>
		/// #oU.#5bb #Wb
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__Wb;
		public virtual R__0__oU.R__0__5bb R__0__Wb
		{
			get
			{
				if(r___0__Wb == null)
				{
					r___0__Wb = new(this, "#Wb");
					r___0__Wb.SetBelong(this.instance);
				}
				return r___0__Wb;
			}
		}

		/// <summary>
		/// System.Boolean #Xb
		/// </summary>
		protected RField r___0__Xb;
		public virtual RField R__0__Xb
		{
			get
			{
				if(r___0__Xb == null)
				{
					r___0__Xb = new(this, "#Xb");
					r___0__Xb.SetBelong(this.instance);
				}
				return r___0__Xb;
			}
		}

		/// <summary>
		/// #oU.#5bb #Yb
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__Yb;
		public virtual R__0__oU.R__0__5bb R__0__Yb
		{
			get
			{
				if(r___0__Yb == null)
				{
					r___0__Yb = new(this, "#Yb");
					r___0__Yb.SetBelong(this.instance);
				}
				return r___0__Yb;
			}
		}

		/// <summary>
		/// #oU.#W4 #Zb
		/// </summary>
		protected R__0__oU.R__0__W4 r___0__Zb;
		public virtual R__0__oU.R__0__W4 R__0__Zb
		{
			get
			{
				if(r___0__Zb == null)
				{
					r___0__Zb = new(this, "#Zb");
					r___0__Zb.SetBelong(this.instance);
				}
				return r___0__Zb;
			}
		}

		/// <summary>
		/// System.Int32 #0b
		/// </summary>
		protected static RField r___0__0b;
		public static RField R__0__0b
		{
			get
			{
				if(r___0__0b == null)
				{
					r___0__0b = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#0b");
					r___0__0b.SetBelong(null);
				}
				return r___0__0b;
			}
		}

		/// <summary>
		/// System.Int32 #1b
		/// </summary>
		protected static RField r___0__1b;
		public static RField R__0__1b
		{
			get
			{
				if(r___0__1b == null)
				{
					r___0__1b = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#1b");
					r___0__1b.SetBelong(null);
				}
				return r___0__1b;
			}
		}

		/// <summary>
		/// System.String #2b
		/// </summary>
		protected RField r___0__2b;
		public virtual RField R__0__2b
		{
			get
			{
				if(r___0__2b == null)
				{
					r___0__2b = new(this, "#2b");
					r___0__2b.SetBelong(this.instance);
				}
				return r___0__2b;
			}
		}

		/// <summary>
		/// System.String #3b
		/// </summary>
		protected RField r___0__3b;
		public virtual RField R__0__3b
		{
			get
			{
				if(r___0__3b == null)
				{
					r___0__3b = new(this, "#3b");
					r___0__3b.SetBelong(this.instance);
				}
				return r___0__3b;
			}
		}

		/// <summary>
		/// System.Boolean #4b
		/// </summary>
		protected RField r___0__4b;
		public virtual RField R__0__4b
		{
			get
			{
				if(r___0__4b == null)
				{
					r___0__4b = new(this, "#4b");
					r___0__4b.SetBelong(this.instance);
				}
				return r___0__4b;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[#u.#Ckb,MyGUI.ElementBase] #5b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<R__0__u.R__0__Ckb, RMyGUI.RElementBase> r___0__5b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<R__0__u.R__0__Ckb, RMyGUI.RElementBase> R__0__5b
		{
			get
			{
				if(r___0__5b == null)
				{
					r___0__5b = new(this, "#5b");
					r___0__5b.SetBelong(this.instance);
				}
				return r___0__5b;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Ckb] #6b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> r___0__6b;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> R__0__6b
		{
			get
			{
				if(r___0__6b == null)
				{
					r___0__6b = new(this, "#6b");
					r___0__6b.SetBelong(this.instance);
				}
				return r___0__6b;
			}
		}

		/// <summary>
		/// System.Int32 #7b
		/// </summary>
		protected RField r___0__7b;
		public virtual RField R__0__7b
		{
			get
			{
				if(r___0__7b == null)
				{
					r___0__7b = new(this, "#7b");
					r___0__7b.SetBelong(this.instance);
				}
				return r___0__7b;
			}
		}

		/// <summary>
		/// System.Int32 #8b
		/// </summary>
		protected RField r___0__8b;
		public virtual RField R__0__8b
		{
			get
			{
				if(r___0__8b == null)
				{
					r___0__8b = new(this, "#8b");
					r___0__8b.SetBelong(this.instance);
				}
				return r___0__8b;
			}
		}

		/// <summary>
		/// System.Int32 #9b
		/// </summary>
		protected RField r___0__9b;
		public virtual RField R__0__9b
		{
			get
			{
				if(r___0__9b == null)
				{
					r___0__9b = new(this, "#9b");
					r___0__9b.SetBelong(this.instance);
				}
				return r___0__9b;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Ckb] #ac
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> r___0__ac;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> R__0__ac
		{
			get
			{
				if(r___0__ac == null)
				{
					r___0__ac = new(this, "#ac");
					r___0__ac.SetBelong(this.instance);
				}
				return r___0__ac;
			}
		}

		/// <summary>
		/// System.Boolean #bc
		/// </summary>
		protected RField r___0__bc;
		public virtual RField R__0__bc
		{
			get
			{
				if(r___0__bc == null)
				{
					r___0__bc = new(this, "#bc");
					r___0__bc.SetBelong(this.instance);
				}
				return r___0__bc;
			}
		}

		/// <summary>
		/// System.Boolean #cc
		/// </summary>
		protected RField r___0__cc;
		public virtual RField R__0__cc
		{
			get
			{
				if(r___0__cc == null)
				{
					r___0__cc = new(this, "#cc");
					r___0__cc.SetBelong(this.instance);
				}
				return r___0__cc;
			}
		}

		/// <summary>
		/// #u.#Ckb #dc
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__dc;
		public virtual R__0__u.R__0__Ckb R__0__dc
		{
			get
			{
				if(r___0__dc == null)
				{
					r___0__dc = new(this, "#dc");
					r___0__dc.SetBelong(this.instance);
				}
				return r___0__dc;
			}
		}

		/// <summary>
		/// #u.#Ckb #ec
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__ec;
		public virtual R__0__u.R__0__Ckb R__0__ec
		{
			get
			{
				if(r___0__ec == null)
				{
					r___0__ec = new(this, "#ec");
					r___0__ec.SetBelong(this.instance);
				}
				return r___0__ec;
			}
		}

		/// <summary>
		/// System.Boolean #fc
		/// </summary>
		protected RField r___0__fc;
		public virtual RField R__0__fc
		{
			get
			{
				if(r___0__fc == null)
				{
					r___0__fc = new(this, "#fc");
					r___0__fc.SetBelong(this.instance);
				}
				return r___0__fc;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase+#1Nb #gc
		/// </summary>
		protected static RMyGUI.RElementBase.R__0__1Nb r___0__gc;
		public static RMyGUI.RElementBase.R__0__1Nb R__0__gc
		{
			get
			{
				if(r___0__gc == null)
				{
					r___0__gc = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#gc");
					r___0__gc.SetBelong(null);
				}
				return r___0__gc;
			}
		}

		/// <summary>
		/// System.Predicate`1[#u.#Ckb] #hc
		/// </summary>
		protected static RSystem.RPredicate<R__0__u.R__0__Ckb> r___0__hc;
		public static RSystem.RPredicate<R__0__u.R__0__Ckb> R__0__hc
		{
			get
			{
				if(r___0__hc == null)
				{
					r___0__hc = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#hc");
					r___0__hc.SetBelong(null);
				}
				return r___0__hc;
			}
		}

		/// <summary>
		/// System.String WindowTypeName
		/// </summary>
		protected RProperty r_R__0__rb;
		public virtual RProperty R__0__rb
		{
			get
			{
				if(r_R__0__rb == null)
				{
					r_R__0__rb = new(this, "WindowTypeName", -1);
					r_R__0__rb.SetBelong(this.instance);
				}
				return r_R__0__rb;
			}
		}

		/// <summary>
		/// EquipTab NowEquipTab
		/// </summary>
		protected RProperty r_R__0__2Ge;
		public virtual RProperty R__0__2Ge
		{
			get
			{
				if(r_R__0__2Ge == null)
				{
					r_R__0__2Ge = new(this, "NowEquipTab", -1);
					r_R__0__2Ge.SetBelong(this.instance);
				}
				return r_R__0__2Ge;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase SuccessEffecteb
		/// </summary>
		protected RMyGUI.RElementBase r_R__0__7Qe;
		public virtual RMyGUI.RElementBase R__0__7Qe
		{
			get
			{
				if(r_R__0__7Qe == null)
				{
					r_R__0__7Qe = new(this, "SuccessEffecteb", -1);
					r_R__0__7Qe.SetBelong(this.instance);
				}
				return r_R__0__7Qe;
			}
		}

		/// <summary>
		/// EquipPlaceType nowEquipPlaceType
		/// </summary>
		protected RProperty r_R__0__2rd;
		public virtual RProperty R__0__2rd
		{
			get
			{
				if(r_R__0__2rd == null)
				{
					r_R__0__2rd = new(this, "nowEquipPlaceType", -1);
					r_R__0__2rd.SetBelong(this.instance);
				}
				return r_R__0__2rd;
			}
		}

		/// <summary>
		/// Boolean AotoWash
		/// </summary>
		protected RProperty r_R__0__6Tj;
		public virtual RProperty R__0__6Tj
		{
			get
			{
				if(r_R__0__6Tj == null)
				{
					r_R__0__6Tj = new(this, "AotoWash", -1);
					r_R__0__6Tj.SetBelong(this.instance);
				}
				return r_R__0__6Tj;
			}
		}

		/// <summary>
		/// Boolean AotoStar
		/// </summary>
		protected RProperty r_R__0__aRe;
		public virtual RProperty R__0__aRe
		{
			get
			{
				if(r_R__0__aRe == null)
				{
					r_R__0__aRe = new(this, "AotoStar", -1);
					r_R__0__aRe.SetBelong(this.instance);
				}
				return r_R__0__aRe;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.String] HashGodPropertyName
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> r_R__0__Iuk;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RProperty, RProperty> R__0__Iuk
		{
			get
			{
				if(r_R__0__Iuk == null)
				{
					r_R__0__Iuk = new(this, "HashGodPropertyName", -1);
					r_R__0__Iuk.SetBelong(this.instance);
				}
				return r_R__0__Iuk;
			}
		}

		/// <summary>
		/// UnityEngine.GUISkin TemplateSkin
		/// </summary>
		protected RUnityEngine.RGUISkin r_R__0__1Jb;
		public virtual RUnityEngine.RGUISkin R__0__1Jb
		{
			get
			{
				if(r_R__0__1Jb == null)
				{
					r_R__0__1Jb = new(this, "TemplateSkin", -1);
					r_R__0__1Jb.SetBelong(this.instance);
				}
				return r_R__0__1Jb;
			}
		}

		/// <summary>
		/// UnityEngine.KeyCode[] DefaultHold_HotKeys
		/// </summary>
		protected RPropertyArray<RProperty> r_R__0__Q6;
		public virtual RPropertyArray<RProperty> R__0__Q6
		{
			get
			{
				if(r_R__0__Q6 == null)
				{
					r_R__0__Q6 = new(this, "DefaultHold_HotKeys", -1);
					r_R__0__Q6.SetBelong(this.instance);
				}
				return r_R__0__Q6;
			}
		}

		/// <summary>
		/// Boolean IsUpdateWhenInvisible
		/// </summary>
		protected RProperty r_R__0__3Jb;
		public virtual RProperty R__0__3Jb
		{
			get
			{
				if(r_R__0__3Jb == null)
				{
					r_R__0__3Jb = new(this, "IsUpdateWhenInvisible", -1);
					r_R__0__3Jb.SetBelong(this.instance);
				}
				return r_R__0__3Jb;
			}
		}

		/// <summary>
		/// Boolean IgnoreDropItemEvent
		/// </summary>
		protected RProperty r_R__0__Rf;
		public virtual RProperty R__0__Rf
		{
			get
			{
				if(r_R__0__Rf == null)
				{
					r_R__0__Rf = new(this, "IgnoreDropItemEvent", -1);
					r_R__0__Rf.SetBelong(this.instance);
				}
				return r_R__0__Rf;
			}
		}

		/// <summary>
		/// Int32 mShowCallTime
		/// </summary>
		protected RProperty r_R__0__5Jb;
		public virtual RProperty R__0__5Jb
		{
			get
			{
				if(r_R__0__5Jb == null)
				{
					r_R__0__5Jb = new(this, "mShowCallTime", -1);
					r_R__0__5Jb.SetBelong(this.instance);
				}
				return r_R__0__5Jb;
			}
		}

		/// <summary>
		/// Boolean DrawWindowFrame
		/// </summary>
		protected RProperty r_R__0__7Jb;
		public virtual RProperty R__0__7Jb
		{
			get
			{
				if(r_R__0__7Jb == null)
				{
					r_R__0__7Jb = new(this, "DrawWindowFrame", -1);
					r_R__0__7Jb.SetBelong(this.instance);
				}
				return r_R__0__7Jb;
			}
		}

		/// <summary>
		/// Boolean UseTextureAreaHit
		/// </summary>
		protected RProperty r_R__0__9Jb;
		public virtual RProperty R__0__9Jb
		{
			get
			{
				if(r_R__0__9Jb == null)
				{
					r_R__0__9Jb = new(this, "UseTextureAreaHit", -1);
					r_R__0__9Jb.SetBelong(this.instance);
				}
				return r_R__0__9Jb;
			}
		}

		/// <summary>
		/// Boolean UseContentAreaHit
		/// </summary>
		protected RProperty r_R__0__bKb;
		public virtual RProperty R__0__bKb
		{
			get
			{
				if(r_R__0__bKb == null)
				{
					r_R__0__bKb = new(this, "UseContentAreaHit", -1);
					r_R__0__bKb.SetBelong(this.instance);
				}
				return r_R__0__bKb;
			}
		}

		/// <summary>
		/// System.String MainWindowStyleName
		/// </summary>
		protected RProperty r_R__0__ZU;
		public virtual RProperty R__0__ZU
		{
			get
			{
				if(r_R__0__ZU == null)
				{
					r_R__0__ZU = new(this, "MainWindowStyleName", -1);
					r_R__0__ZU.SetBelong(this.instance);
				}
				return r_R__0__ZU;
			}
		}

		/// <summary>
		/// Boolean CanWindowBeShowed
		/// </summary>
		protected RProperty r_R__0__vKb;
		public virtual RProperty R__0__vKb
		{
			get
			{
				if(r_R__0__vKb == null)
				{
					r_R__0__vKb = new(this, "CanWindowBeShowed", -1);
					r_R__0__vKb.SetBelong(this.instance);
				}
				return r_R__0__vKb;
			}
		}

		/// <summary>
		/// Boolean IsDragable
		/// </summary>
		protected RProperty r_R__0__GKb;
		public virtual RProperty R__0__GKb
		{
			get
			{
				if(r_R__0__GKb == null)
				{
					r_R__0__GKb = new(this, "IsDragable", -1);
					r_R__0__GKb.SetBelong(this.instance);
				}
				return r_R__0__GKb;
			}
		}

		/// <summary>
		/// Boolean IsFullScreen
		/// </summary>
		protected RProperty r_R__0__lob;
		public virtual RProperty R__0__lob
		{
			get
			{
				if(r_R__0__lob == null)
				{
					r_R__0__lob = new(this, "IsFullScreen", -1);
					r_R__0__lob.SetBelong(this.instance);
				}
				return r_R__0__lob;
			}
		}

		/// <summary>
		/// Boolean IsModelWnd
		/// </summary>
		protected RProperty r_R__0__JKb;
		public virtual RProperty R__0__JKb
		{
			get
			{
				if(r_R__0__JKb == null)
				{
					r_R__0__JKb = new(this, "IsModelWnd", -1);
					r_R__0__JKb.SetBelong(this.instance);
				}
				return r_R__0__JKb;
			}
		}

		/// <summary>
		/// Boolean IsModelExcept
		/// </summary>
		protected RProperty r_IsModelExcept;
		public virtual RProperty RIsModelExcept
		{
			get
			{
				if(r_IsModelExcept == null)
				{
					r_IsModelExcept = new(this, "IsModelExcept", -1);
					r_IsModelExcept.SetBelong(this.instance);
				}
				return r_IsModelExcept;
			}
		}

		/// <summary>
		/// #oU.#05 mMainWnd
		/// </summary>
		protected R__0__oU.R__0__05 r_R__0__KKb;
		public virtual R__0__oU.R__0__05 R__0__KKb
		{
			get
			{
				if(r_R__0__KKb == null)
				{
					r_R__0__KKb = new(this, "mMainWnd", -1);
					r_R__0__KKb.SetBelong(this.instance);
				}
				return r_R__0__KKb;
			}
		}

		/// <summary>
		/// #hLb StartPosition
		/// </summary>
		protected RProperty r_R__0__LKb;
		public virtual RProperty R__0__LKb
		{
			get
			{
				if(r_R__0__LKb == null)
				{
					r_R__0__LKb = new(this, "StartPosition", -1);
					r_R__0__LKb.SetBelong(this.instance);
				}
				return r_R__0__LKb;
			}
		}

		/// <summary>
		/// #iLb LayoutMode
		/// </summary>
		protected RProperty r_LayoutMode;
		public virtual RProperty RLayoutMode
		{
			get
			{
				if(r_LayoutMode == null)
				{
					r_LayoutMode = new(this, "LayoutMode", -1);
					r_LayoutMode.SetBelong(this.instance);
				}
				return r_LayoutMode;
			}
		}

		/// <summary>
		/// Boolean IsEnable
		/// </summary>
		protected RProperty r_R__0__NKb;
		public virtual RProperty R__0__NKb
		{
			get
			{
				if(r_R__0__NKb == null)
				{
					r_R__0__NKb = new(this, "IsEnable", -1);
					r_R__0__NKb.SetBelong(this.instance);
				}
				return r_R__0__NKb;
			}
		}

		/// <summary>
		/// MyGUI.WINDOW_LEVEL Level
		/// </summary>
		protected RProperty r_R__0__Meb;
		public virtual RProperty R__0__Meb
		{
			get
			{
				if(r_R__0__Meb == null)
				{
					r_R__0__Meb = new(this, "Level", -1);
					r_R__0__Meb.SetBelong(this.instance);
				}
				return r_R__0__Meb;
			}
		}

		/// <summary>
		/// Int32 WindowID
		/// </summary>
		protected RProperty r_R__0__Z5;
		public virtual RProperty R__0__Z5
		{
			get
			{
				if(r_R__0__Z5 == null)
				{
					r_R__0__Z5 = new(this, "WindowID", -1);
					r_R__0__Z5.SetBelong(this.instance);
				}
				return r_R__0__Z5;
			}
		}

		/// <summary>
		/// Boolean m_Animating
		/// </summary>
		protected RProperty r_R__0__SKb;
		public virtual RProperty R__0__SKb
		{
			get
			{
				if(r_R__0__SKb == null)
				{
					r_R__0__SKb = new(this, "m_Animating", -1);
					r_R__0__SKb.SetBelong(this.instance);
				}
				return r_R__0__SKb;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject gameObject
		/// </summary>
		protected RUnityEngine.RGameObject r_R__0__WKb;
		public virtual RUnityEngine.RGameObject R__0__WKb
		{
			get
			{
				if(r_R__0__WKb == null)
				{
					r_R__0__WKb = new(this, "gameObject", -1);
					r_R__0__WKb.SetBelong(this.instance);
				}
				return r_R__0__WKb;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RProperty r_enabled;
		public virtual RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected RUnityEngine.RTransform r_R__0__YKb;
		public virtual RUnityEngine.RTransform R__0__YKb
		{
			get
			{
				if(r_R__0__YKb == null)
				{
					r_R__0__YKb = new(this, "transform", -1);
					r_R__0__YKb.SetBelong(this.instance);
				}
				return r_R__0__YKb;
			}
		}

		/// <summary>
		/// Boolean MoveIng
		/// </summary>
		protected RProperty r_R__0__8Kb;
		public virtual RProperty R__0__8Kb
		{
			get
			{
				if(r_R__0__8Kb == null)
				{
					r_R__0__8Kb = new(this, "MoveIng", -1);
					r_R__0__8Kb.SetBelong(this.instance);
				}
				return r_R__0__8Kb;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 TargetLocation
		/// </summary>
		protected RUnityEngine.RVector2 r_R__0__Hxj;
		public virtual RUnityEngine.RVector2 R__0__Hxj
		{
			get
			{
				if(r_R__0__Hxj == null)
				{
					r_R__0__Hxj = new(this, "TargetLocation", -1);
					r_R__0__Hxj.SetBelong(this.instance);
				}
				return r_R__0__Hxj;
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
		/// Void #6c()
		/// </summary>
		protected RMethod r_R__0__6c;
		public virtual RMethod R__0__6c
		{
			get
			{
				if(r_R__0__6c == null)
				{
					r_R__0__6c = new(this, "#6c", 0);
					r_R__0__6c.SetBelong(this.instance);
				}
				return r_R__0__6c;
			}
		}

		/// <summary>
		/// Void #tb(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__tb_Object___0__7X;
		public virtual RMethod R__0__tb_Object___0__7X
		{
			get
			{
				if(r_R__0__tb_Object___0__7X == null)
				{
					r_R__0__tb_Object___0__7X = new(this, "#tb", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__tb_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__tb_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Trd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Trd_Object___0__7X;
		public virtual RMethod R__0__Trd_Object___0__7X
		{
			get
			{
				if(r_R__0__Trd_Object___0__7X == null)
				{
					r_R__0__Trd_Object___0__7X = new(this, "#Trd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Trd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Trd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #NXd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__NXd_Object___0__7X;
		public virtual RMethod R__0__NXd_Object___0__7X
		{
			get
			{
				if(r_R__0__NXd_Object___0__7X == null)
				{
					r_R__0__NXd_Object___0__7X = new(this, "#NXd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__NXd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__NXd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #sb(Boolean)
		/// </summary>
		protected RMethod r_R__0__sb_Boolean;
		public virtual RMethod R__0__sb_Boolean
		{
			get
			{
				if(r_R__0__sb_Boolean == null)
				{
					r_R__0__sb_Boolean = new(this, "#sb", 0, typeof(System.Boolean));
					r_R__0__sb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__sb_Boolean;
			}
		}

		/// <summary>
		/// Boolean #OXd(EquipTab)
		/// </summary>
		protected static RMethod r_R__0__OXd_EquipTab;
		public static RMethod R__0__OXd_EquipTab
		{
			get
			{
				if(r_R__0__OXd_EquipTab == null)
				{
					r_R__0__OXd_EquipTab = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#OXd", 0, typeof(EquipTab));
					r_R__0__OXd_EquipTab.SetBelong(null);
				}
				return r_R__0__OXd_EquipTab;
			}
		}

		/// <summary>
		/// Void #Abb(System.String)
		/// </summary>
		protected RMethod r_R__0__Abb_String;
		public virtual RMethod R__0__Abb_String
		{
			get
			{
				if(r_R__0__Abb_String == null)
				{
					r_R__0__Abb_String = new(this, "#Abb", 0, typeof(System.String));
					r_R__0__Abb_String.SetBelong(this.instance);
				}
				return r_R__0__Abb_String;
			}
		}

		/// <summary>
		/// Boolean #Urd(EquipTab)
		/// </summary>
		protected RMethod r_R__0__Urd_EquipTab;
		public virtual RMethod R__0__Urd_EquipTab
		{
			get
			{
				if(r_R__0__Urd_EquipTab == null)
				{
					r_R__0__Urd_EquipTab = new(this, "#Urd", 0, typeof(EquipTab));
					r_R__0__Urd_EquipTab.SetBelong(this.instance);
				}
				return r_R__0__Urd_EquipTab;
			}
		}

		/// <summary>
		/// Boolean #Urd(EquipTab, Pet)
		/// </summary>
		protected RMethod r_R__0__Urd_EquipTab_Pet;
		public virtual RMethod R__0__Urd_EquipTab_Pet
		{
			get
			{
				if(r_R__0__Urd_EquipTab_Pet == null)
				{
					r_R__0__Urd_EquipTab_Pet = new(this, "#Urd", 0, typeof(EquipTab),  ReleactionUtils.GetType("Pet"));
					r_R__0__Urd_EquipTab_Pet.SetBelong(this.instance);
				}
				return r_R__0__Urd_EquipTab_Pet;
			}
		}

		/// <summary>
		/// Void #DXu(Pet)
		/// </summary>
		protected RMethod r_R__0__DXu_Pet;
		public virtual RMethod R__0__DXu_Pet
		{
			get
			{
				if(r_R__0__DXu_Pet == null)
				{
					r_R__0__DXu_Pet = new(this, "#DXu", 0,  ReleactionUtils.GetType("Pet"));
					r_R__0__DXu_Pet.SetBelong(this.instance);
				}
				return r_R__0__DXu_Pet;
			}
		}

		/// <summary>
		/// Boolean #Urd(EquipTab, #u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__Urd_EquipTab___0__Ckb;
		public virtual RMethod R__0__Urd_EquipTab___0__Ckb
		{
			get
			{
				if(r_R__0__Urd_EquipTab___0__Ckb == null)
				{
					r_R__0__Urd_EquipTab___0__Ckb = new(this, "#Urd", 0, typeof(EquipTab),  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__Urd_EquipTab___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__Urd_EquipTab___0__Ckb;
			}
		}

		/// <summary>
		/// Boolean #Urd(#u.#Ckb, #Wwd)
		/// </summary>
		protected RMethod r_R__0__Urd___0__Ckb___0__Wwd;
		public virtual RMethod R__0__Urd___0__Ckb___0__Wwd
		{
			get
			{
				if(r_R__0__Urd___0__Ckb___0__Wwd == null)
				{
					r_R__0__Urd___0__Ckb___0__Wwd = new(this, "#Urd", 0,  ReleactionUtils.GetType("#u.#Ckb"),  ReleactionUtils.GetType("MyGUIFinalEquipWnd+#Wwd"));
					r_R__0__Urd___0__Ckb___0__Wwd.SetBelong(this.instance);
				}
				return r_R__0__Urd___0__Ckb___0__Wwd;
			}
		}

		/// <summary>
		/// Boolean #Urd(#u.#Ckb, #Xwd)
		/// </summary>
		protected RMethod r_R__0__Urd___0__Ckb___0__Xwd;
		public virtual RMethod R__0__Urd___0__Ckb___0__Xwd
		{
			get
			{
				if(r_R__0__Urd___0__Ckb___0__Xwd == null)
				{
					r_R__0__Urd___0__Ckb___0__Xwd = new(this, "#Urd", 0,  ReleactionUtils.GetType("#u.#Ckb"),  ReleactionUtils.GetType("MyGUIFinalEquipWnd+#Xwd"));
					r_R__0__Urd___0__Ckb___0__Xwd.SetBelong(this.instance);
				}
				return r_R__0__Urd___0__Ckb___0__Xwd;
			}
		}

		/// <summary>
		/// Void #lVe(System.Object)
		/// </summary>
		protected RMethod r_R__0__lVe_Object;
		public virtual RMethod R__0__lVe_Object
		{
			get
			{
				if(r_R__0__lVe_Object == null)
				{
					r_R__0__lVe_Object = new(this, "#lVe", 0, typeof(System.Object));
					r_R__0__lVe_Object.SetBelong(this.instance);
				}
				return r_R__0__lVe_Object;
			}
		}

		/// <summary>
		/// Void #XTc(Int32, Int32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__XTc_Int32_Int32_ID;
		public virtual RMethod R__0__XTc_Int32_Int32_ID
		{
			get
			{
				if(r_R__0__XTc_Int32_Int32_ID == null)
				{
					r_R__0__XTc_Int32_Int32_ID = new(this, "#XTc", 0, typeof(System.Int32), typeof(System.Int32), typeof(GameDefineType.ID));
					r_R__0__XTc_Int32_Int32_ID.SetBelong(this.instance);
				}
				return r_R__0__XTc_Int32_Int32_ID;
			}
		}

		/// <summary>
		/// Void #1gc(EquipTab)
		/// </summary>
		protected RMethod r_R__0__1gc_EquipTab;
		public virtual RMethod R__0__1gc_EquipTab
		{
			get
			{
				if(r_R__0__1gc_EquipTab == null)
				{
					r_R__0__1gc_EquipTab = new(this, "#1gc", 0, typeof(EquipTab));
					r_R__0__1gc_EquipTab.SetBelong(this.instance);
				}
				return r_R__0__1gc_EquipTab;
			}
		}

		/// <summary>
		/// Void #Xd()
		/// </summary>
		protected RMethod r_R__0__Xd;
		public virtual RMethod R__0__Xd
		{
			get
			{
				if(r_R__0__Xd == null)
				{
					r_R__0__Xd = new(this, "#Xd", 0);
					r_R__0__Xd.SetBelong(this.instance);
				}
				return r_R__0__Xd;
			}
		}

		/// <summary>
		/// Int32 #wAd(EquipTab)
		/// </summary>
		protected RMethod r_R__0__wAd_EquipTab;
		public virtual RMethod R__0__wAd_EquipTab
		{
			get
			{
				if(r_R__0__wAd_EquipTab == null)
				{
					r_R__0__wAd_EquipTab = new(this, "#wAd", 0, typeof(EquipTab));
					r_R__0__wAd_EquipTab.SetBelong(this.instance);
				}
				return r_R__0__wAd_EquipTab;
			}
		}

		/// <summary>
		/// Void #Xrd()
		/// </summary>
		protected RMethod r_R__0__Xrd;
		public virtual RMethod R__0__Xrd
		{
			get
			{
				if(r_R__0__Xrd == null)
				{
					r_R__0__Xrd = new(this, "#Xrd", 0);
					r_R__0__Xrd.SetBelong(this.instance);
				}
				return r_R__0__Xrd;
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
		/// Void #YTj()
		/// </summary>
		protected RMethod r_R__0__YTj;
		public virtual RMethod R__0__YTj
		{
			get
			{
				if(r_R__0__YTj == null)
				{
					r_R__0__YTj = new(this, "#YTj", 0);
					r_R__0__YTj.SetBelong(this.instance);
				}
				return r_R__0__YTj;
			}
		}

		/// <summary>
		/// Void #Xgc(UnityEngine.GameObject, MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__Xgc_GameObject_ElementBase;
		public virtual RMethod R__0__Xgc_GameObject_ElementBase
		{
			get
			{
				if(r_R__0__Xgc_GameObject_ElementBase == null)
				{
					r_R__0__Xgc_GameObject_ElementBase = new(this, "#Xgc", 0, typeof(UnityEngine.GameObject), typeof(MyGUI.ElementBase));
					r_R__0__Xgc_GameObject_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__Xgc_GameObject_ElementBase;
			}
		}

		/// <summary>
		/// Void #xAd(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__xAd_ElementBase;
		public virtual RMethod R__0__xAd_ElementBase
		{
			get
			{
				if(r_R__0__xAd_ElementBase == null)
				{
					r_R__0__xAd_ElementBase = new(this, "#xAd", 0, typeof(MyGUI.ElementBase));
					r_R__0__xAd_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__xAd_ElementBase;
			}
		}

		/// <summary>
		/// Void #yAd()
		/// </summary>
		protected RMethod r_R__0__yAd;
		public virtual RMethod R__0__yAd
		{
			get
			{
				if(r_R__0__yAd == null)
				{
					r_R__0__yAd = new(this, "#yAd", 0);
					r_R__0__yAd.SetBelong(this.instance);
				}
				return r_R__0__yAd;
			}
		}

		/// <summary>
		/// Void OnLoadUIeffect(System.String, MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_ROnLoadUIeffect_String_ElementBase;
		public virtual RMethod ROnLoadUIeffect_String_ElementBase
		{
			get
			{
				if(r_ROnLoadUIeffect_String_ElementBase == null)
				{
					r_ROnLoadUIeffect_String_ElementBase = new(this, "OnLoadUIeffect", 0, typeof(System.String), typeof(MyGUI.ElementBase));
					r_ROnLoadUIeffect_String_ElementBase.SetBelong(this.instance);
				}
				return r_ROnLoadUIeffect_String_ElementBase;
			}
		}

		/// <summary>
		/// Void OnLoadObj(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadObj_Object_ABLoadedArgs;
		public virtual RMethod ROnLoadObj_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnLoadObj_Object_ABLoadedArgs == null)
				{
					r_ROnLoadObj_Object_ABLoadedArgs = new(this, "OnLoadObj", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnLoadObj_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadObj_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void #VOd(Boolean)
		/// </summary>
		protected RMethod r_R__0__VOd_Boolean;
		public virtual RMethod R__0__VOd_Boolean
		{
			get
			{
				if(r_R__0__VOd_Boolean == null)
				{
					r_R__0__VOd_Boolean = new(this, "#VOd", 0, typeof(System.Boolean));
					r_R__0__VOd_Boolean.SetBelong(this.instance);
				}
				return r_R__0__VOd_Boolean;
			}
		}

		/// <summary>
		/// Void #Yrd()
		/// </summary>
		protected RMethod r_R__0__Yrd;
		public virtual RMethod R__0__Yrd
		{
			get
			{
				if(r_R__0__Yrd == null)
				{
					r_R__0__Yrd = new(this, "#Yrd", 0);
					r_R__0__Yrd.SetBelong(this.instance);
				}
				return r_R__0__Yrd;
			}
		}

		/// <summary>
		/// Void #Zrd(#oU.#5bb, Pet)
		/// </summary>
		protected RMethod r_R__0__Zrd___0__5bb_Pet;
		public virtual RMethod R__0__Zrd___0__5bb_Pet
		{
			get
			{
				if(r_R__0__Zrd___0__5bb_Pet == null)
				{
					r_R__0__Zrd___0__5bb_Pet = new(this, "#Zrd", 0,  ReleactionUtils.GetType("#oU.#5bb"),  ReleactionUtils.GetType("Pet"));
					r_R__0__Zrd___0__5bb_Pet.SetBelong(this.instance);
				}
				return r_R__0__Zrd___0__5bb_Pet;
			}
		}

		/// <summary>
		/// Void #Pz()
		/// </summary>
		protected RMethod r_R__0__Pz;
		public virtual RMethod R__0__Pz
		{
			get
			{
				if(r_R__0__Pz == null)
				{
					r_R__0__Pz = new(this, "#Pz", 0);
					r_R__0__Pz.SetBelong(this.instance);
				}
				return r_R__0__Pz;
			}
		}

		/// <summary>
		/// Void #0rd()
		/// </summary>
		protected RMethod r_R__0__0rd;
		public virtual RMethod R__0__0rd
		{
			get
			{
				if(r_R__0__0rd == null)
				{
					r_R__0__0rd = new(this, "#0rd", 0);
					r_R__0__0rd.SetBelong(this.instance);
				}
				return r_R__0__0rd;
			}
		}

		/// <summary>
		/// Void #zAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__zAd_Object___0__7X;
		public virtual RMethod R__0__zAd_Object___0__7X
		{
			get
			{
				if(r_R__0__zAd_Object___0__7X == null)
				{
					r_R__0__zAd_Object___0__7X = new(this, "#zAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__zAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__zAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #AAd(Pet)
		/// </summary>
		protected RMethod r_R__0__AAd_Pet;
		public virtual RMethod R__0__AAd_Pet
		{
			get
			{
				if(r_R__0__AAd_Pet == null)
				{
					r_R__0__AAd_Pet = new(this, "#AAd", 0,  ReleactionUtils.GetType("Pet"));
					r_R__0__AAd_Pet.SetBelong(this.instance);
				}
				return r_R__0__AAd_Pet;
			}
		}

		/// <summary>
		/// Void #AAd(Pet, Int32)
		/// </summary>
		protected RMethod r_R__0__AAd_Pet_Int32;
		public virtual RMethod R__0__AAd_Pet_Int32
		{
			get
			{
				if(r_R__0__AAd_Pet_Int32 == null)
				{
					r_R__0__AAd_Pet_Int32 = new(this, "#AAd", 0,  ReleactionUtils.GetType("Pet"), typeof(System.Int32));
					r_R__0__AAd_Pet_Int32.SetBelong(this.instance);
				}
				return r_R__0__AAd_Pet_Int32;
			}
		}

		/// <summary>
		/// Void #PXd()
		/// </summary>
		protected RMethod r_R__0__PXd;
		public virtual RMethod R__0__PXd
		{
			get
			{
				if(r_R__0__PXd == null)
				{
					r_R__0__PXd = new(this, "#PXd", 0);
					r_R__0__PXd.SetBelong(this.instance);
				}
				return r_R__0__PXd;
			}
		}

		/// <summary>
		/// Void #Qk(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Qk_Object___0__7X;
		public virtual RMethod R__0__Qk_Object___0__7X
		{
			get
			{
				if(r_R__0__Qk_Object___0__7X == null)
				{
					r_R__0__Qk_Object___0__7X = new(this, "#Qk", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Qk_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Qk_Object___0__7X;
			}
		}

		/// <summary>
		/// Pet #Rz()
		/// </summary>
		protected RMethod r_R__0__Rz;
		public virtual RMethod R__0__Rz
		{
			get
			{
				if(r_R__0__Rz == null)
				{
					r_R__0__Rz = new(this, "#Rz", 0);
					r_R__0__Rz.SetBelong(this.instance);
				}
				return r_R__0__Rz;
			}
		}

		/// <summary>
		/// GameDefineType.ID #DF()
		/// </summary>
		protected RMethod r_R__0__DF;
		public virtual RMethod R__0__DF
		{
			get
			{
				if(r_R__0__DF == null)
				{
					r_R__0__DF = new(this, "#DF", 0);
					r_R__0__DF.SetBelong(this.instance);
				}
				return r_R__0__DF;
			}
		}

		/// <summary>
		/// Void #3rd()
		/// </summary>
		protected RMethod r_R__0__3rd;
		public virtual RMethod R__0__3rd
		{
			get
			{
				if(r_R__0__3rd == null)
				{
					r_R__0__3rd = new(this, "#3rd", 0);
					r_R__0__3rd.SetBelong(this.instance);
				}
				return r_R__0__3rd;
			}
		}

		/// <summary>
		/// Void #4rd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__4rd_Object___0__7X;
		public virtual RMethod R__0__4rd_Object___0__7X
		{
			get
			{
				if(r_R__0__4rd_Object___0__7X == null)
				{
					r_R__0__4rd_Object___0__7X = new(this, "#4rd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__4rd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__4rd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #5rd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__5rd_Object___0__7X;
		public virtual RMethod R__0__5rd_Object___0__7X
		{
			get
			{
				if(r_R__0__5rd_Object___0__7X == null)
				{
					r_R__0__5rd_Object___0__7X = new(this, "#5rd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__5rd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__5rd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #6rd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__6rd_Object___0__7X;
		public virtual RMethod R__0__6rd_Object___0__7X
		{
			get
			{
				if(r_R__0__6rd_Object___0__7X == null)
				{
					r_R__0__6rd_Object___0__7X = new(this, "#6rd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__6rd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__6rd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #7rd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__7rd_Object___0__7X;
		public virtual RMethod R__0__7rd_Object___0__7X
		{
			get
			{
				if(r_R__0__7rd_Object___0__7X == null)
				{
					r_R__0__7rd_Object___0__7X = new(this, "#7rd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__7rd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__7rd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #8rd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__8rd_Object___0__7X;
		public virtual RMethod R__0__8rd_Object___0__7X
		{
			get
			{
				if(r_R__0__8rd_Object___0__7X == null)
				{
					r_R__0__8rd_Object___0__7X = new(this, "#8rd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__8rd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__8rd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #9rd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__9rd_Object___0__7X;
		public virtual RMethod R__0__9rd_Object___0__7X
		{
			get
			{
				if(r_R__0__9rd_Object___0__7X == null)
				{
					r_R__0__9rd_Object___0__7X = new(this, "#9rd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__9rd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__9rd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #asd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__asd_Object___0__7X;
		public virtual RMethod R__0__asd_Object___0__7X
		{
			get
			{
				if(r_R__0__asd_Object___0__7X == null)
				{
					r_R__0__asd_Object___0__7X = new(this, "#asd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__asd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__asd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #bsd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__bsd_Object___0__7X;
		public virtual RMethod R__0__bsd_Object___0__7X
		{
			get
			{
				if(r_R__0__bsd_Object___0__7X == null)
				{
					r_R__0__bsd_Object___0__7X = new(this, "#bsd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__bsd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__bsd_Object___0__7X;
			}
		}

		/// <summary>
		/// #u.#Ckb #csd(Boolean, Int32)
		/// </summary>
		protected RMethod r_R__0__csd_Boolean_Int32;
		public virtual RMethod R__0__csd_Boolean_Int32
		{
			get
			{
				if(r_R__0__csd_Boolean_Int32 == null)
				{
					r_R__0__csd_Boolean_Int32 = new(this, "#csd", 0, typeof(System.Boolean), typeof(System.Int32));
					r_R__0__csd_Boolean_Int32.SetBelong(this.instance);
				}
				return r_R__0__csd_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void #dsd(MyGUI.ElementBase, MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__dsd_ElementBase_ElementBase;
		public virtual RMethod R__0__dsd_ElementBase_ElementBase
		{
			get
			{
				if(r_R__0__dsd_ElementBase_ElementBase == null)
				{
					r_R__0__dsd_ElementBase_ElementBase = new(this, "#dsd", 0, typeof(MyGUI.ElementBase), typeof(MyGUI.ElementBase));
					r_R__0__dsd_ElementBase_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__dsd_ElementBase_ElementBase;
			}
		}

		/// <summary>
		/// Void #esd(Int32)
		/// </summary>
		protected RMethod r_R__0__esd_Int32;
		public virtual RMethod R__0__esd_Int32
		{
			get
			{
				if(r_R__0__esd_Int32 == null)
				{
					r_R__0__esd_Int32 = new(this, "#esd", 0, typeof(System.Int32));
					r_R__0__esd_Int32.SetBelong(this.instance);
				}
				return r_R__0__esd_Int32;
			}
		}

		/// <summary>
		/// Void #fsd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__fsd_Object___0__7X;
		public virtual RMethod R__0__fsd_Object___0__7X
		{
			get
			{
				if(r_R__0__fsd_Object___0__7X == null)
				{
					r_R__0__fsd_Object___0__7X = new(this, "#fsd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__fsd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__fsd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #gsd(Int32)
		/// </summary>
		protected RMethod r_R__0__gsd_Int32;
		public virtual RMethod R__0__gsd_Int32
		{
			get
			{
				if(r_R__0__gsd_Int32 == null)
				{
					r_R__0__gsd_Int32 = new(this, "#gsd", 0, typeof(System.Int32));
					r_R__0__gsd_Int32.SetBelong(this.instance);
				}
				return r_R__0__gsd_Int32;
			}
		}

		/// <summary>
		/// Void #hsd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__hsd_Object___0__7X;
		public virtual RMethod R__0__hsd_Object___0__7X
		{
			get
			{
				if(r_R__0__hsd_Object___0__7X == null)
				{
					r_R__0__hsd_Object___0__7X = new(this, "#hsd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__hsd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__hsd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #isd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__isd_Object___0__7X;
		public virtual RMethod R__0__isd_Object___0__7X
		{
			get
			{
				if(r_R__0__isd_Object___0__7X == null)
				{
					r_R__0__isd_Object___0__7X = new(this, "#isd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__isd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__isd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #jsd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__jsd_Object___0__7X;
		public virtual RMethod R__0__jsd_Object___0__7X
		{
			get
			{
				if(r_R__0__jsd_Object___0__7X == null)
				{
					r_R__0__jsd_Object___0__7X = new(this, "#jsd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__jsd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__jsd_Object___0__7X;
			}
		}

		/// <summary>
		/// #u.#Ckb #ksd()
		/// </summary>
		protected RMethod r_R__0__ksd;
		public virtual RMethod R__0__ksd
		{
			get
			{
				if(r_R__0__ksd == null)
				{
					r_R__0__ksd = new(this, "#ksd", 0);
					r_R__0__ksd.SetBelong(this.instance);
				}
				return r_R__0__ksd;
			}
		}

		/// <summary>
		/// Void #lsd(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__lsd___0__Ckb;
		public virtual RMethod R__0__lsd___0__Ckb
		{
			get
			{
				if(r_R__0__lsd___0__Ckb == null)
				{
					r_R__0__lsd___0__Ckb = new(this, "#lsd", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__lsd___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__lsd___0__Ckb;
			}
		}

		/// <summary>
		/// Void #msd()
		/// </summary>
		protected RMethod r_R__0__msd;
		public virtual RMethod R__0__msd
		{
			get
			{
				if(r_R__0__msd == null)
				{
					r_R__0__msd = new(this, "#msd", 0);
					r_R__0__msd.SetBelong(this.instance);
				}
				return r_R__0__msd;
			}
		}

		/// <summary>
		/// Void #nsd()
		/// </summary>
		protected RMethod r_R__0__nsd;
		public virtual RMethod R__0__nsd
		{
			get
			{
				if(r_R__0__nsd == null)
				{
					r_R__0__nsd = new(this, "#nsd", 0);
					r_R__0__nsd.SetBelong(this.instance);
				}
				return r_R__0__nsd;
			}
		}

		/// <summary>
		/// Void #osd()
		/// </summary>
		protected RMethod r_R__0__osd;
		public virtual RMethod R__0__osd
		{
			get
			{
				if(r_R__0__osd == null)
				{
					r_R__0__osd = new(this, "#osd", 0);
					r_R__0__osd.SetBelong(this.instance);
				}
				return r_R__0__osd;
			}
		}

		/// <summary>
		/// Int32 #BAd(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__BAd___0__Ckb;
		public virtual RMethod R__0__BAd___0__Ckb
		{
			get
			{
				if(r_R__0__BAd___0__Ckb == null)
				{
					r_R__0__BAd___0__Ckb = new(this, "#BAd", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__BAd___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__BAd___0__Ckb;
			}
		}

		/// <summary>
		/// Void #psd()
		/// </summary>
		protected RMethod r_R__0__psd;
		public virtual RMethod R__0__psd
		{
			get
			{
				if(r_R__0__psd == null)
				{
					r_R__0__psd = new(this, "#psd", 0);
					r_R__0__psd.SetBelong(this.instance);
				}
				return r_R__0__psd;
			}
		}

		/// <summary>
		/// Void #0wd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__0wd_Object___0__7X;
		public virtual RMethod R__0__0wd_Object___0__7X
		{
			get
			{
				if(r_R__0__0wd_Object___0__7X == null)
				{
					r_R__0__0wd_Object___0__7X = new(this, "#0wd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__0wd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__0wd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #gA(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__gA_Object___0__7X;
		public virtual RMethod R__0__gA_Object___0__7X
		{
			get
			{
				if(r_R__0__gA_Object___0__7X == null)
				{
					r_R__0__gA_Object___0__7X = new(this, "#gA", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__gA_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__gA_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #hA(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__hA_Object___0__7X;
		public virtual RMethod R__0__hA_Object___0__7X
		{
			get
			{
				if(r_R__0__hA_Object___0__7X == null)
				{
					r_R__0__hA_Object___0__7X = new(this, "#hA", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__hA_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__hA_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #0z()
		/// </summary>
		protected RMethod r_R__0__0z;
		public virtual RMethod R__0__0z
		{
			get
			{
				if(r_R__0__0z == null)
				{
					r_R__0__0z = new(this, "#0z", 0);
					r_R__0__0z.SetBelong(this.instance);
				}
				return r_R__0__0z;
			}
		}

		/// <summary>
		/// Void RemovePetModel()
		/// </summary>
		protected RMethod r_RRemovePetModel;
		public virtual RMethod RRemovePetModel
		{
			get
			{
				if(r_RRemovePetModel == null)
				{
					r_RRemovePetModel = new(this, "RemovePetModel", 0);
					r_RRemovePetModel.SetBelong(this.instance);
				}
				return r_RRemovePetModel;
			}
		}

		/// <summary>
		/// Void OnLoadedCharacter(System.Object, CGLoadedArgs)
		/// </summary>
		protected RMethod r_ROnLoadedCharacter_Object_CGLoadedArgs;
		public virtual RMethod ROnLoadedCharacter_Object_CGLoadedArgs
		{
			get
			{
				if(r_ROnLoadedCharacter_Object_CGLoadedArgs == null)
				{
					r_ROnLoadedCharacter_Object_CGLoadedArgs = new(this, "OnLoadedCharacter", 0, typeof(System.Object),  ReleactionUtils.GetType("CharacterDownloader+CGLoadedArgs"));
					r_ROnLoadedCharacter_Object_CGLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnLoadedCharacter_Object_CGLoadedArgs;
			}
		}

		/// <summary>
		/// Void OnLoadedPetModel(System.Object, #u.#egb)
		/// </summary>
		protected RMethod r_ROnLoadedPetModel_Object___0__egb;
		public virtual RMethod ROnLoadedPetModel_Object___0__egb
		{
			get
			{
				if(r_ROnLoadedPetModel_Object___0__egb == null)
				{
					r_ROnLoadedPetModel_Object___0__egb = new(this, "OnLoadedPetModel", 0, typeof(System.Object),  ReleactionUtils.GetType("#u.#egb"));
					r_ROnLoadedPetModel_Object___0__egb.SetBelong(this.instance);
				}
				return r_ROnLoadedPetModel_Object___0__egb;
			}
		}

		/// <summary>
		/// Void ShowPetModel()
		/// </summary>
		protected RMethod r_RShowPetModel;
		public virtual RMethod RShowPetModel
		{
			get
			{
				if(r_RShowPetModel == null)
				{
					r_RShowPetModel = new(this, "ShowPetModel", 0);
					r_RShowPetModel.SetBelong(this.instance);
				}
				return r_RShowPetModel;
			}
		}

		/// <summary>
		/// Void #3z()
		/// </summary>
		protected RMethod r_R__0__3z;
		public virtual RMethod R__0__3z
		{
			get
			{
				if(r_R__0__3z == null)
				{
					r_R__0__3z = new(this, "#3z", 0);
					r_R__0__3z.SetBelong(this.instance);
				}
				return r_R__0__3z;
			}
		}

		/// <summary>
		/// Void OnPutWeapon(UnityEngine.GameObject, System.String)
		/// </summary>
		protected RMethod r_ROnPutWeapon_GameObject_String;
		public virtual RMethod ROnPutWeapon_GameObject_String
		{
			get
			{
				if(r_ROnPutWeapon_GameObject_String == null)
				{
					r_ROnPutWeapon_GameObject_String = new(this, "OnPutWeapon", 0, typeof(UnityEngine.GameObject), typeof(System.String));
					r_ROnPutWeapon_GameObject_String.SetBelong(this.instance);
				}
				return r_ROnPutWeapon_GameObject_String;
			}
		}

		/// <summary>
		/// Void OnGetWeaponRes(System.Object, UnityEngine.GameObject, UnityEngine.GameObject, System.Object)
		/// </summary>
		protected RMethod r_ROnGetWeaponRes_Object_GameObject_GameObject_Object;
		public virtual RMethod ROnGetWeaponRes_Object_GameObject_GameObject_Object
		{
			get
			{
				if(r_ROnGetWeaponRes_Object_GameObject_GameObject_Object == null)
				{
					r_ROnGetWeaponRes_Object_GameObject_GameObject_Object = new(this, "OnGetWeaponRes", 0, typeof(System.Object), typeof(UnityEngine.GameObject), typeof(UnityEngine.GameObject), typeof(System.Object));
					r_ROnGetWeaponRes_Object_GameObject_GameObject_Object.SetBelong(this.instance);
				}
				return r_ROnGetWeaponRes_Object_GameObject_GameObject_Object;
			}
		}

		/// <summary>
		/// Void StartPlayAnimation(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_RStartPlayAnimation_GameObject;
		public virtual RMethod RStartPlayAnimation_GameObject
		{
			get
			{
				if(r_RStartPlayAnimation_GameObject == null)
				{
					r_RStartPlayAnimation_GameObject = new(this, "StartPlayAnimation", 0, typeof(UnityEngine.GameObject));
					r_RStartPlayAnimation_GameObject.SetBelong(this.instance);
				}
				return r_RStartPlayAnimation_GameObject;
			}
		}

		/// <summary>
		/// Void OnRotateClick(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_ROnRotateClick_Object___0__7X;
		public virtual RMethod ROnRotateClick_Object___0__7X
		{
			get
			{
				if(r_ROnRotateClick_Object___0__7X == null)
				{
					r_ROnRotateClick_Object___0__7X = new(this, "OnRotateClick", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_ROnRotateClick_Object___0__7X.SetBelong(this.instance);
				}
				return r_ROnRotateClick_Object___0__7X;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase #QXd(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__QXd___0__Ckb;
		public virtual RMethod R__0__QXd___0__Ckb
		{
			get
			{
				if(r_R__0__QXd___0__Ckb == null)
				{
					r_R__0__QXd___0__Ckb = new(this, "#QXd", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__QXd___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__QXd___0__Ckb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Ckb] #RXd()
		/// </summary>
		protected RMethod r_R__0__RXd;
		public virtual RMethod R__0__RXd
		{
			get
			{
				if(r_R__0__RXd == null)
				{
					r_R__0__RXd = new(this, "#RXd", 0);
					r_R__0__RXd.SetBelong(this.instance);
				}
				return r_R__0__RXd;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase #SXd(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__SXd___0__Ckb;
		public virtual RMethod R__0__SXd___0__Ckb
		{
			get
			{
				if(r_R__0__SXd___0__Ckb == null)
				{
					r_R__0__SXd___0__Ckb = new(this, "#SXd", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__SXd___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__SXd___0__Ckb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Ckb] #TXd()
		/// </summary>
		protected RMethod r_R__0__TXd;
		public virtual RMethod R__0__TXd
		{
			get
			{
				if(r_R__0__TXd == null)
				{
					r_R__0__TXd = new(this, "#TXd", 0);
					r_R__0__TXd.SetBelong(this.instance);
				}
				return r_R__0__TXd;
			}
		}

		/// <summary>
		/// Void #CAd(Int32)
		/// </summary>
		protected RMethod r_R__0__CAd_Int32;
		public virtual RMethod R__0__CAd_Int32
		{
			get
			{
				if(r_R__0__CAd_Int32 == null)
				{
					r_R__0__CAd_Int32 = new(this, "#CAd", 0, typeof(System.Int32));
					r_R__0__CAd_Int32.SetBelong(this.instance);
				}
				return r_R__0__CAd_Int32;
			}
		}

		/// <summary>
		/// Void #UXd()
		/// </summary>
		protected RMethod r_R__0__UXd;
		public virtual RMethod R__0__UXd
		{
			get
			{
				if(r_R__0__UXd == null)
				{
					r_R__0__UXd = new(this, "#UXd", 0);
					r_R__0__UXd.SetBelong(this.instance);
				}
				return r_R__0__UXd;
			}
		}

		/// <summary>
		/// Void #DAd()
		/// </summary>
		protected RMethod r_R__0__DAd;
		public virtual RMethod R__0__DAd
		{
			get
			{
				if(r_R__0__DAd == null)
				{
					r_R__0__DAd = new(this, "#DAd", 0);
					r_R__0__DAd.SetBelong(this.instance);
				}
				return r_R__0__DAd;
			}
		}

		/// <summary>
		/// Void #EAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__EAd_Object___0__7X;
		public virtual RMethod R__0__EAd_Object___0__7X
		{
			get
			{
				if(r_R__0__EAd_Object___0__7X == null)
				{
					r_R__0__EAd_Object___0__7X = new(this, "#EAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__EAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__EAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #FAd()
		/// </summary>
		protected RMethod r_R__0__FAd;
		public virtual RMethod R__0__FAd
		{
			get
			{
				if(r_R__0__FAd == null)
				{
					r_R__0__FAd = new(this, "#FAd", 0);
					r_R__0__FAd.SetBelong(this.instance);
				}
				return r_R__0__FAd;
			}
		}

		/// <summary>
		/// Int32 #GAd(Int32)
		/// </summary>
		protected RMethod r_R__0__GAd_Int32;
		public virtual RMethod R__0__GAd_Int32
		{
			get
			{
				if(r_R__0__GAd_Int32 == null)
				{
					r_R__0__GAd_Int32 = new(this, "#GAd", 0, typeof(System.Int32));
					r_R__0__GAd_Int32.SetBelong(this.instance);
				}
				return r_R__0__GAd_Int32;
			}
		}

		/// <summary>
		/// Int32 #HAd()
		/// </summary>
		protected RMethod r_R__0__HAd;
		public virtual RMethod R__0__HAd
		{
			get
			{
				if(r_R__0__HAd == null)
				{
					r_R__0__HAd = new(this, "#HAd", 0);
					r_R__0__HAd.SetBelong(this.instance);
				}
				return r_R__0__HAd;
			}
		}

		/// <summary>
		/// Void #IAd(Boolean, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__IAd_Boolean_Vector2;
		public virtual RMethod R__0__IAd_Boolean_Vector2
		{
			get
			{
				if(r_R__0__IAd_Boolean_Vector2 == null)
				{
					r_R__0__IAd_Boolean_Vector2 = new(this, "#IAd", 0, typeof(System.Boolean), typeof(UnityEngine.Vector2));
					r_R__0__IAd_Boolean_Vector2.SetBelong(this.instance);
				}
				return r_R__0__IAd_Boolean_Vector2;
			}
		}

		/// <summary>
		/// Int32 #JAd()
		/// </summary>
		protected RMethod r_R__0__JAd;
		public virtual RMethod R__0__JAd
		{
			get
			{
				if(r_R__0__JAd == null)
				{
					r_R__0__JAd = new(this, "#JAd", 0);
					r_R__0__JAd.SetBelong(this.instance);
				}
				return r_R__0__JAd;
			}
		}

		/// <summary>
		/// GameDefineType.ID #KAd()
		/// </summary>
		protected RMethod r_R__0__KAd;
		public virtual RMethod R__0__KAd
		{
			get
			{
				if(r_R__0__KAd == null)
				{
					r_R__0__KAd = new(this, "#KAd", 0);
					r_R__0__KAd.SetBelong(this.instance);
				}
				return r_R__0__KAd;
			}
		}

		/// <summary>
		/// Void #qsd()
		/// </summary>
		protected RMethod r_R__0__qsd;
		public virtual RMethod R__0__qsd
		{
			get
			{
				if(r_R__0__qsd == null)
				{
					r_R__0__qsd = new(this, "#qsd", 0);
					r_R__0__qsd.SetBelong(this.instance);
				}
				return r_R__0__qsd;
			}
		}

		/// <summary>
		/// Void #Tag()
		/// </summary>
		protected RMethod r_R__0__Tag;
		public virtual RMethod R__0__Tag
		{
			get
			{
				if(r_R__0__Tag == null)
				{
					r_R__0__Tag = new(this, "#Tag", 0);
					r_R__0__Tag.SetBelong(this.instance);
				}
				return r_R__0__Tag;
			}
		}

		/// <summary>
		/// Void #Uag()
		/// </summary>
		protected RMethod r_R__0__Uag;
		public virtual RMethod R__0__Uag
		{
			get
			{
				if(r_R__0__Uag == null)
				{
					r_R__0__Uag = new(this, "#Uag", 0);
					r_R__0__Uag.SetBelong(this.instance);
				}
				return r_R__0__Uag;
			}
		}

		/// <summary>
		/// Void #Xm(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Xm_Object___0__7X;
		public virtual RMethod R__0__Xm_Object___0__7X
		{
			get
			{
				if(r_R__0__Xm_Object___0__7X == null)
				{
					r_R__0__Xm_Object___0__7X = new(this, "#Xm", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Xm_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Xm_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #LAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__LAd_Object___0__7X;
		public virtual RMethod R__0__LAd_Object___0__7X
		{
			get
			{
				if(r_R__0__LAd_Object___0__7X == null)
				{
					r_R__0__LAd_Object___0__7X = new(this, "#LAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__LAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__LAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Mxe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Mxe_Object___0__7X;
		public virtual RMethod R__0__Mxe_Object___0__7X
		{
			get
			{
				if(r_R__0__Mxe_Object___0__7X == null)
				{
					r_R__0__Mxe_Object___0__7X = new(this, "#Mxe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Mxe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Mxe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #MAd()
		/// </summary>
		protected RMethod r_R__0__MAd;
		public virtual RMethod R__0__MAd
		{
			get
			{
				if(r_R__0__MAd == null)
				{
					r_R__0__MAd = new(this, "#MAd", 0);
					r_R__0__MAd.SetBelong(this.instance);
				}
				return r_R__0__MAd;
			}
		}

		/// <summary>
		/// Void #rsd()
		/// </summary>
		protected RMethod r_R__0__rsd;
		public virtual RMethod R__0__rsd
		{
			get
			{
				if(r_R__0__rsd == null)
				{
					r_R__0__rsd = new(this, "#rsd", 0);
					r_R__0__rsd.SetBelong(this.instance);
				}
				return r_R__0__rsd;
			}
		}

		/// <summary>
		/// Void #Hwd()
		/// </summary>
		protected RMethod r_R__0__Hwd;
		public virtual RMethod R__0__Hwd
		{
			get
			{
				if(r_R__0__Hwd == null)
				{
					r_R__0__Hwd = new(this, "#Hwd", 0);
					r_R__0__Hwd.SetBelong(this.instance);
				}
				return r_R__0__Hwd;
			}
		}

		/// <summary>
		/// Void #ssd()
		/// </summary>
		protected RMethod r_R__0__ssd;
		public virtual RMethod R__0__ssd
		{
			get
			{
				if(r_R__0__ssd == null)
				{
					r_R__0__ssd = new(this, "#ssd", 0);
					r_R__0__ssd.SetBelong(this.instance);
				}
				return r_R__0__ssd;
			}
		}

		/// <summary>
		/// Void #VXd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__VXd_Object___0__7X;
		public virtual RMethod R__0__VXd_Object___0__7X
		{
			get
			{
				if(r_R__0__VXd_Object___0__7X == null)
				{
					r_R__0__VXd_Object___0__7X = new(this, "#VXd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__VXd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__VXd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #WXd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__WXd_Object___0__7X;
		public virtual RMethod R__0__WXd_Object___0__7X
		{
			get
			{
				if(r_R__0__WXd_Object___0__7X == null)
				{
					r_R__0__WXd_Object___0__7X = new(this, "#WXd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__WXd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__WXd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #XXd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__XXd_Object___0__7X;
		public virtual RMethod R__0__XXd_Object___0__7X
		{
			get
			{
				if(r_R__0__XXd_Object___0__7X == null)
				{
					r_R__0__XXd_Object___0__7X = new(this, "#XXd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__XXd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__XXd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #tsd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__tsd_Object___0__7X;
		public virtual RMethod R__0__tsd_Object___0__7X
		{
			get
			{
				if(r_R__0__tsd_Object___0__7X == null)
				{
					r_R__0__tsd_Object___0__7X = new(this, "#tsd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__tsd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__tsd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #usd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__usd_Object___0__7X;
		public virtual RMethod R__0__usd_Object___0__7X
		{
			get
			{
				if(r_R__0__usd_Object___0__7X == null)
				{
					r_R__0__usd_Object___0__7X = new(this, "#usd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__usd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__usd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #vsd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__vsd_Object___0__7X;
		public virtual RMethod R__0__vsd_Object___0__7X
		{
			get
			{
				if(r_R__0__vsd_Object___0__7X == null)
				{
					r_R__0__vsd_Object___0__7X = new(this, "#vsd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__vsd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__vsd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #bl(Boolean)
		/// </summary>
		protected RMethod r_R__0__bl_Boolean;
		public virtual RMethod R__0__bl_Boolean
		{
			get
			{
				if(r_R__0__bl_Boolean == null)
				{
					r_R__0__bl_Boolean = new(this, "#bl", 0, typeof(System.Boolean));
					r_R__0__bl_Boolean.SetBelong(this.instance);
				}
				return r_R__0__bl_Boolean;
			}
		}

		/// <summary>
		/// Void #cl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__cl_Object___0__7X;
		public virtual RMethod R__0__cl_Object___0__7X
		{
			get
			{
				if(r_R__0__cl_Object___0__7X == null)
				{
					r_R__0__cl_Object___0__7X = new(this, "#cl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__cl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__cl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #wsd()
		/// </summary>
		protected RMethod r_R__0__wsd;
		public virtual RMethod R__0__wsd
		{
			get
			{
				if(r_R__0__wsd == null)
				{
					r_R__0__wsd = new(this, "#wsd", 0);
					r_R__0__wsd.SetBelong(this.instance);
				}
				return r_R__0__wsd;
			}
		}

		/// <summary>
		/// Void #zsd()
		/// </summary>
		protected RMethod r_R__0__zsd;
		public virtual RMethod R__0__zsd
		{
			get
			{
				if(r_R__0__zsd == null)
				{
					r_R__0__zsd = new(this, "#zsd", 0);
					r_R__0__zsd.SetBelong(this.instance);
				}
				return r_R__0__zsd;
			}
		}

		/// <summary>
		/// Void #YXd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__YXd_Object___0__7X;
		public virtual RMethod R__0__YXd_Object___0__7X
		{
			get
			{
				if(r_R__0__YXd_Object___0__7X == null)
				{
					r_R__0__YXd_Object___0__7X = new(this, "#YXd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__YXd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__YXd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #ZXd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__ZXd_Object___0__7X;
		public virtual RMethod R__0__ZXd_Object___0__7X
		{
			get
			{
				if(r_R__0__ZXd_Object___0__7X == null)
				{
					r_R__0__ZXd_Object___0__7X = new(this, "#ZXd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__ZXd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__ZXd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #0Xd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__0Xd_Object___0__7X;
		public virtual RMethod R__0__0Xd_Object___0__7X
		{
			get
			{
				if(r_R__0__0Xd_Object___0__7X == null)
				{
					r_R__0__0Xd_Object___0__7X = new(this, "#0Xd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__0Xd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__0Xd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #1Xd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__1Xd_Object___0__7X;
		public virtual RMethod R__0__1Xd_Object___0__7X
		{
			get
			{
				if(r_R__0__1Xd_Object___0__7X == null)
				{
					r_R__0__1Xd_Object___0__7X = new(this, "#1Xd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__1Xd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__1Xd_Object___0__7X;
			}
		}

		/// <summary>
		/// Int32 #OAd(#u.#Dkb)
		/// </summary>
		protected RMethod r_R__0__OAd___0__Dkb;
		public virtual RMethod R__0__OAd___0__Dkb
		{
			get
			{
				if(r_R__0__OAd___0__Dkb == null)
				{
					r_R__0__OAd___0__Dkb = new(this, "#OAd", 0,  ReleactionUtils.GetType("#u.#Dkb"));
					r_R__0__OAd___0__Dkb.SetBelong(this.instance);
				}
				return r_R__0__OAd___0__Dkb;
			}
		}

		/// <summary>
		/// Void #PAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__PAd_Object___0__7X;
		public virtual RMethod R__0__PAd_Object___0__7X
		{
			get
			{
				if(r_R__0__PAd_Object___0__7X == null)
				{
					r_R__0__PAd_Object___0__7X = new(this, "#PAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__PAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__PAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #ZTj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__ZTj_Object___0__7X;
		public virtual RMethod R__0__ZTj_Object___0__7X
		{
			get
			{
				if(r_R__0__ZTj_Object___0__7X == null)
				{
					r_R__0__ZTj_Object___0__7X = new(this, "#ZTj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__ZTj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__ZTj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #0Tj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__0Tj_Object___0__7X;
		public virtual RMethod R__0__0Tj_Object___0__7X
		{
			get
			{
				if(r_R__0__0Tj_Object___0__7X == null)
				{
					r_R__0__0Tj_Object___0__7X = new(this, "#0Tj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__0Tj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__0Tj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #1Tj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__1Tj_Object___0__7X;
		public virtual RMethod R__0__1Tj_Object___0__7X
		{
			get
			{
				if(r_R__0__1Tj_Object___0__7X == null)
				{
					r_R__0__1Tj_Object___0__7X = new(this, "#1Tj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__1Tj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__1Tj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #2Tj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__2Tj_Object___0__7X;
		public virtual RMethod R__0__2Tj_Object___0__7X
		{
			get
			{
				if(r_R__0__2Tj_Object___0__7X == null)
				{
					r_R__0__2Tj_Object___0__7X = new(this, "#2Tj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__2Tj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__2Tj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #3Tj()
		/// </summary>
		protected RMethod r_R__0__3Tj;
		public virtual RMethod R__0__3Tj
		{
			get
			{
				if(r_R__0__3Tj == null)
				{
					r_R__0__3Tj = new(this, "#3Tj", 0);
					r_R__0__3Tj.SetBelong(this.instance);
				}
				return r_R__0__3Tj;
			}
		}

		/// <summary>
		/// Void #4Tj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__4Tj_Object___0__7X;
		public virtual RMethod R__0__4Tj_Object___0__7X
		{
			get
			{
				if(r_R__0__4Tj_Object___0__7X == null)
				{
					r_R__0__4Tj_Object___0__7X = new(this, "#4Tj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__4Tj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__4Tj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Iwd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Iwd_Object___0__7X;
		public virtual RMethod R__0__Iwd_Object___0__7X
		{
			get
			{
				if(r_R__0__Iwd_Object___0__7X == null)
				{
					r_R__0__Iwd_Object___0__7X = new(this, "#Iwd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Iwd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Iwd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Jwd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Jwd_Object___0__7X;
		public virtual RMethod R__0__Jwd_Object___0__7X
		{
			get
			{
				if(r_R__0__Jwd_Object___0__7X == null)
				{
					r_R__0__Jwd_Object___0__7X = new(this, "#Jwd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Jwd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Jwd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #7Tj()
		/// </summary>
		protected RMethod r_R__0__7Tj;
		public virtual RMethod R__0__7Tj
		{
			get
			{
				if(r_R__0__7Tj == null)
				{
					r_R__0__7Tj = new(this, "#7Tj", 0);
					r_R__0__7Tj.SetBelong(this.instance);
				}
				return r_R__0__7Tj;
			}
		}

		/// <summary>
		/// Void #8Tj()
		/// </summary>
		protected RMethod r_R__0__8Tj;
		public virtual RMethod R__0__8Tj
		{
			get
			{
				if(r_R__0__8Tj == null)
				{
					r_R__0__8Tj = new(this, "#8Tj", 0);
					r_R__0__8Tj.SetBelong(this.instance);
				}
				return r_R__0__8Tj;
			}
		}

		/// <summary>
		/// Void #9Tj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__9Tj_Object___0__7X;
		public virtual RMethod R__0__9Tj_Object___0__7X
		{
			get
			{
				if(r_R__0__9Tj_Object___0__7X == null)
				{
					r_R__0__9Tj_Object___0__7X = new(this, "#9Tj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__9Tj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__9Tj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #aUj(System.Object, Boolean)
		/// </summary>
		protected RMethod r_R__0__aUj_Object_Boolean;
		public virtual RMethod R__0__aUj_Object_Boolean
		{
			get
			{
				if(r_R__0__aUj_Object_Boolean == null)
				{
					r_R__0__aUj_Object_Boolean = new(this, "#aUj", 0, typeof(System.Object), typeof(System.Boolean));
					r_R__0__aUj_Object_Boolean.SetBelong(this.instance);
				}
				return r_R__0__aUj_Object_Boolean;
			}
		}

		/// <summary>
		/// Void #bUj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__bUj_Object___0__7X;
		public virtual RMethod R__0__bUj_Object___0__7X
		{
			get
			{
				if(r_R__0__bUj_Object___0__7X == null)
				{
					r_R__0__bUj_Object___0__7X = new(this, "#bUj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__bUj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__bUj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #cUj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__cUj_Object___0__7X;
		public virtual RMethod R__0__cUj_Object___0__7X
		{
			get
			{
				if(r_R__0__cUj_Object___0__7X == null)
				{
					r_R__0__cUj_Object___0__7X = new(this, "#cUj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__cUj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__cUj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #dUj()
		/// </summary>
		protected RMethod r_R__0__dUj;
		public virtual RMethod R__0__dUj
		{
			get
			{
				if(r_R__0__dUj == null)
				{
					r_R__0__dUj = new(this, "#dUj", 0);
					r_R__0__dUj.SetBelong(this.instance);
				}
				return r_R__0__dUj;
			}
		}

		/// <summary>
		/// Void #eUj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__eUj_Object___0__7X;
		public virtual RMethod R__0__eUj_Object___0__7X
		{
			get
			{
				if(r_R__0__eUj_Object___0__7X == null)
				{
					r_R__0__eUj_Object___0__7X = new(this, "#eUj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__eUj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__eUj_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #WOd()
		/// </summary>
		protected RMethod r_R__0__WOd;
		public virtual RMethod R__0__WOd
		{
			get
			{
				if(r_R__0__WOd == null)
				{
					r_R__0__WOd = new(this, "#WOd", 0);
					r_R__0__WOd.SetBelong(this.instance);
				}
				return r_R__0__WOd;
			}
		}

		/// <summary>
		/// Void #XOd()
		/// </summary>
		protected RMethod r_R__0__XOd;
		public virtual RMethod R__0__XOd
		{
			get
			{
				if(r_R__0__XOd == null)
				{
					r_R__0__XOd = new(this, "#XOd", 0);
					r_R__0__XOd.SetBelong(this.instance);
				}
				return r_R__0__XOd;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #YOd(Int32)
		/// </summary>
		protected RMethod r_R__0__YOd_Int32;
		public virtual RMethod R__0__YOd_Int32
		{
			get
			{
				if(r_R__0__YOd_Int32 == null)
				{
					r_R__0__YOd_Int32 = new(this, "#YOd", 0, typeof(System.Int32));
					r_R__0__YOd_Int32.SetBelong(this.instance);
				}
				return r_R__0__YOd_Int32;
			}
		}

		/// <summary>
		/// Void #ZOd()
		/// </summary>
		protected RMethod r_R__0__ZOd;
		public virtual RMethod R__0__ZOd
		{
			get
			{
				if(r_R__0__ZOd == null)
				{
					r_R__0__ZOd = new(this, "#ZOd", 0);
					r_R__0__ZOd.SetBelong(this.instance);
				}
				return r_R__0__ZOd;
			}
		}

		/// <summary>
		/// Void #fUj(Boolean)
		/// </summary>
		protected RMethod r_R__0__fUj_Boolean;
		public virtual RMethod R__0__fUj_Boolean
		{
			get
			{
				if(r_R__0__fUj_Boolean == null)
				{
					r_R__0__fUj_Boolean = new(this, "#fUj", 0, typeof(System.Boolean));
					r_R__0__fUj_Boolean.SetBelong(this.instance);
				}
				return r_R__0__fUj_Boolean;
			}
		}

		/// <summary>
		/// Void #Asd()
		/// </summary>
		protected RMethod r_R__0__Asd;
		public virtual RMethod R__0__Asd
		{
			get
			{
				if(r_R__0__Asd == null)
				{
					r_R__0__Asd = new(this, "#Asd", 0);
					r_R__0__Asd.SetBelong(this.instance);
				}
				return r_R__0__Asd;
			}
		}

		/// <summary>
		/// Void #Bsd()
		/// </summary>
		protected RMethod r_R__0__Bsd;
		public virtual RMethod R__0__Bsd
		{
			get
			{
				if(r_R__0__Bsd == null)
				{
					r_R__0__Bsd = new(this, "#Bsd", 0);
					r_R__0__Bsd.SetBelong(this.instance);
				}
				return r_R__0__Bsd;
			}
		}

		/// <summary>
		/// Void #2Xd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__2Xd_Object___0__7X;
		public virtual RMethod R__0__2Xd_Object___0__7X
		{
			get
			{
				if(r_R__0__2Xd_Object___0__7X == null)
				{
					r_R__0__2Xd_Object___0__7X = new(this, "#2Xd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__2Xd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__2Xd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Kwd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Kwd_Object___0__7X;
		public virtual RMethod R__0__Kwd_Object___0__7X
		{
			get
			{
				if(r_R__0__Kwd_Object___0__7X == null)
				{
					r_R__0__Kwd_Object___0__7X = new(this, "#Kwd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Kwd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Kwd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Lwd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Lwd_Object___0__7X;
		public virtual RMethod R__0__Lwd_Object___0__7X
		{
			get
			{
				if(r_R__0__Lwd_Object___0__7X == null)
				{
					r_R__0__Lwd_Object___0__7X = new(this, "#Lwd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Lwd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Lwd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Mwd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Mwd_Object___0__7X;
		public virtual RMethod R__0__Mwd_Object___0__7X
		{
			get
			{
				if(r_R__0__Mwd_Object___0__7X == null)
				{
					r_R__0__Mwd_Object___0__7X = new(this, "#Mwd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Mwd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Mwd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Nwd()
		/// </summary>
		protected RMethod r_R__0__Nwd;
		public virtual RMethod R__0__Nwd
		{
			get
			{
				if(r_R__0__Nwd == null)
				{
					r_R__0__Nwd = new(this, "#Nwd", 0);
					r_R__0__Nwd.SetBelong(this.instance);
				}
				return r_R__0__Nwd;
			}
		}

		/// <summary>
		/// Void #Owd()
		/// </summary>
		protected RMethod r_R__0__Owd;
		public virtual RMethod R__0__Owd
		{
			get
			{
				if(r_R__0__Owd == null)
				{
					r_R__0__Owd = new(this, "#Owd", 0);
					r_R__0__Owd.SetBelong(this.instance);
				}
				return r_R__0__Owd;
			}
		}

		/// <summary>
		/// Void #Pwd()
		/// </summary>
		protected RMethod r_R__0__Pwd;
		public virtual RMethod R__0__Pwd
		{
			get
			{
				if(r_R__0__Pwd == null)
				{
					r_R__0__Pwd = new(this, "#Pwd", 0);
					r_R__0__Pwd.SetBelong(this.instance);
				}
				return r_R__0__Pwd;
			}
		}

		/// <summary>
		/// Void #Qwd()
		/// </summary>
		protected RMethod r_R__0__Qwd;
		public virtual RMethod R__0__Qwd
		{
			get
			{
				if(r_R__0__Qwd == null)
				{
					r_R__0__Qwd = new(this, "#Qwd", 0);
					r_R__0__Qwd.SetBelong(this.instance);
				}
				return r_R__0__Qwd;
			}
		}

		/// <summary>
		/// Void #uQ(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__uQ_Object___0__7X;
		public virtual RMethod R__0__uQ_Object___0__7X
		{
			get
			{
				if(r_R__0__uQ_Object___0__7X == null)
				{
					r_R__0__uQ_Object___0__7X = new(this, "#uQ", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__uQ_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__uQ_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #tQ(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__tQ_Object___0__7X;
		public virtual RMethod R__0__tQ_Object___0__7X
		{
			get
			{
				if(r_R__0__tQ_Object___0__7X == null)
				{
					r_R__0__tQ_Object___0__7X = new(this, "#tQ", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__tQ_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__tQ_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Rwd()
		/// </summary>
		protected RMethod r_R__0__Rwd;
		public virtual RMethod R__0__Rwd
		{
			get
			{
				if(r_R__0__Rwd == null)
				{
					r_R__0__Rwd = new(this, "#Rwd", 0);
					r_R__0__Rwd.SetBelong(this.instance);
				}
				return r_R__0__Rwd;
			}
		}

		/// <summary>
		/// Void #Swd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Swd_Object___0__7X;
		public virtual RMethod R__0__Swd_Object___0__7X
		{
			get
			{
				if(r_R__0__Swd_Object___0__7X == null)
				{
					r_R__0__Swd_Object___0__7X = new(this, "#Swd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Swd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Swd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #QAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__QAd_Object___0__7X;
		public virtual RMethod R__0__QAd_Object___0__7X
		{
			get
			{
				if(r_R__0__QAd_Object___0__7X == null)
				{
					r_R__0__QAd_Object___0__7X = new(this, "#QAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__QAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__QAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #x1e(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__x1e_Object___0__7X;
		public virtual RMethod R__0__x1e_Object___0__7X
		{
			get
			{
				if(r_R__0__x1e_Object___0__7X == null)
				{
					r_R__0__x1e_Object___0__7X = new(this, "#x1e", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__x1e_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__x1e_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #RAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__RAd_Object___0__7X;
		public virtual RMethod R__0__RAd_Object___0__7X
		{
			get
			{
				if(r_R__0__RAd_Object___0__7X == null)
				{
					r_R__0__RAd_Object___0__7X = new(this, "#RAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__RAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__RAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #3Xd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__3Xd_Object___0__7X;
		public virtual RMethod R__0__3Xd_Object___0__7X
		{
			get
			{
				if(r_R__0__3Xd_Object___0__7X == null)
				{
					r_R__0__3Xd_Object___0__7X = new(this, "#3Xd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__3Xd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__3Xd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #4Xd(System.Object)
		/// </summary>
		protected RMethod r_R__0__4Xd_Object;
		public virtual RMethod R__0__4Xd_Object
		{
			get
			{
				if(r_R__0__4Xd_Object == null)
				{
					r_R__0__4Xd_Object = new(this, "#4Xd", 0, typeof(System.Object));
					r_R__0__4Xd_Object.SetBelong(this.instance);
				}
				return r_R__0__4Xd_Object;
			}
		}

		/// <summary>
		/// Void #5Xd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__5Xd_Object___0__7X;
		public virtual RMethod R__0__5Xd_Object___0__7X
		{
			get
			{
				if(r_R__0__5Xd_Object___0__7X == null)
				{
					r_R__0__5Xd_Object___0__7X = new(this, "#5Xd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__5Xd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__5Xd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #6Xd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__6Xd_Object___0__7X;
		public virtual RMethod R__0__6Xd_Object___0__7X
		{
			get
			{
				if(r_R__0__6Xd_Object___0__7X == null)
				{
					r_R__0__6Xd_Object___0__7X = new(this, "#6Xd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__6Xd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__6Xd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Csd()
		/// </summary>
		protected RMethod r_R__0__Csd;
		public virtual RMethod R__0__Csd
		{
			get
			{
				if(r_R__0__Csd == null)
				{
					r_R__0__Csd = new(this, "#Csd", 0);
					r_R__0__Csd.SetBelong(this.instance);
				}
				return r_R__0__Csd;
			}
		}

		/// <summary>
		/// Void #Uwd()
		/// </summary>
		protected RMethod r_R__0__Uwd;
		public virtual RMethod R__0__Uwd
		{
			get
			{
				if(r_R__0__Uwd == null)
				{
					r_R__0__Uwd = new(this, "#Uwd", 0);
					r_R__0__Uwd.SetBelong(this.instance);
				}
				return r_R__0__Uwd;
			}
		}

		/// <summary>
		/// Void #Dsd()
		/// </summary>
		protected RMethod r_R__0__Dsd;
		public virtual RMethod R__0__Dsd
		{
			get
			{
				if(r_R__0__Dsd == null)
				{
					r_R__0__Dsd = new(this, "#Dsd", 0);
					r_R__0__Dsd.SetBelong(this.instance);
				}
				return r_R__0__Dsd;
			}
		}

		/// <summary>
		/// Void #7Xd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__7Xd_Object___0__7X;
		public virtual RMethod R__0__7Xd_Object___0__7X
		{
			get
			{
				if(r_R__0__7Xd_Object___0__7X == null)
				{
					r_R__0__7Xd_Object___0__7X = new(this, "#7Xd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__7Xd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__7Xd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #8Qe(System.Object, Boolean)
		/// </summary>
		protected RMethod r_R__0__8Qe_Object_Boolean;
		public virtual RMethod R__0__8Qe_Object_Boolean
		{
			get
			{
				if(r_R__0__8Qe_Object_Boolean == null)
				{
					r_R__0__8Qe_Object_Boolean = new(this, "#8Qe", 0, typeof(System.Object), typeof(System.Boolean));
					r_R__0__8Qe_Object_Boolean.SetBelong(this.instance);
				}
				return r_R__0__8Qe_Object_Boolean;
			}
		}

		/// <summary>
		/// Void #3vv(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__3vv_Object___0__7X;
		public virtual RMethod R__0__3vv_Object___0__7X
		{
			get
			{
				if(r_R__0__3vv_Object___0__7X == null)
				{
					r_R__0__3vv_Object___0__7X = new(this, "#3vv", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__3vv_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__3vv_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Vwd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Vwd_Object___0__7X;
		public virtual RMethod R__0__Vwd_Object___0__7X
		{
			get
			{
				if(r_R__0__Vwd_Object___0__7X == null)
				{
					r_R__0__Vwd_Object___0__7X = new(this, "#Vwd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Vwd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Vwd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Esd()
		/// </summary>
		protected RMethod r_R__0__Esd;
		public virtual RMethod R__0__Esd
		{
			get
			{
				if(r_R__0__Esd == null)
				{
					r_R__0__Esd = new(this, "#Esd", 0);
					r_R__0__Esd.SetBelong(this.instance);
				}
				return r_R__0__Esd;
			}
		}

		/// <summary>
		/// Void #bRe()
		/// </summary>
		protected RMethod r_R__0__bRe;
		public virtual RMethod R__0__bRe
		{
			get
			{
				if(r_R__0__bRe == null)
				{
					r_R__0__bRe = new(this, "#bRe", 0);
					r_R__0__bRe.SetBelong(this.instance);
				}
				return r_R__0__bRe;
			}
		}

		/// <summary>
		/// Void #cRe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__cRe_Object___0__7X;
		public virtual RMethod R__0__cRe_Object___0__7X
		{
			get
			{
				if(r_R__0__cRe_Object___0__7X == null)
				{
					r_R__0__cRe_Object___0__7X = new(this, "#cRe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__cRe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__cRe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #dRe()
		/// </summary>
		protected RMethod r_R__0__dRe;
		public virtual RMethod R__0__dRe
		{
			get
			{
				if(r_R__0__dRe == null)
				{
					r_R__0__dRe = new(this, "#dRe", 0);
					r_R__0__dRe.SetBelong(this.instance);
				}
				return r_R__0__dRe;
			}
		}

		/// <summary>
		/// Void #Juk()
		/// </summary>
		protected RMethod r_R__0__Juk;
		public virtual RMethod R__0__Juk
		{
			get
			{
				if(r_R__0__Juk == null)
				{
					r_R__0__Juk = new(this, "#Juk", 0);
					r_R__0__Juk.SetBelong(this.instance);
				}
				return r_R__0__Juk;
			}
		}

		/// <summary>
		/// Void #Kuk()
		/// </summary>
		protected RMethod r_R__0__Kuk;
		public virtual RMethod R__0__Kuk
		{
			get
			{
				if(r_R__0__Kuk == null)
				{
					r_R__0__Kuk = new(this, "#Kuk", 0);
					r_R__0__Kuk.SetBelong(this.instance);
				}
				return r_R__0__Kuk;
			}
		}

		/// <summary>
		/// Void #Luk(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Luk_Object___0__7X;
		public virtual RMethod R__0__Luk_Object___0__7X
		{
			get
			{
				if(r_R__0__Luk_Object___0__7X == null)
				{
					r_R__0__Luk_Object___0__7X = new(this, "#Luk", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Luk_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Luk_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Muk(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Muk_Object___0__7X;
		public virtual RMethod R__0__Muk_Object___0__7X
		{
			get
			{
				if(r_R__0__Muk_Object___0__7X == null)
				{
					r_R__0__Muk_Object___0__7X = new(this, "#Muk", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Muk_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Muk_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Nuk(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Nuk_Object___0__7X;
		public virtual RMethod R__0__Nuk_Object___0__7X
		{
			get
			{
				if(r_R__0__Nuk_Object___0__7X == null)
				{
					r_R__0__Nuk_Object___0__7X = new(this, "#Nuk", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Nuk_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Nuk_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Ouk(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ouk_Object___0__7X;
		public virtual RMethod R__0__Ouk_Object___0__7X
		{
			get
			{
				if(r_R__0__Ouk_Object___0__7X == null)
				{
					r_R__0__Ouk_Object___0__7X = new(this, "#Ouk", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ouk_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ouk_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Hdp()
		/// </summary>
		protected RMethod r_R__0__Hdp;
		public virtual RMethod R__0__Hdp
		{
			get
			{
				if(r_R__0__Hdp == null)
				{
					r_R__0__Hdp = new(this, "#Hdp", 0);
					r_R__0__Hdp.SetBelong(this.instance);
				}
				return r_R__0__Hdp;
			}
		}

		/// <summary>
		/// Void #Idp(MagicWeaponTypePag)
		/// </summary>
		protected RMethod r_R__0__Idp_MagicWeaponTypePag;
		public virtual RMethod R__0__Idp_MagicWeaponTypePag
		{
			get
			{
				if(r_R__0__Idp_MagicWeaponTypePag == null)
				{
					r_R__0__Idp_MagicWeaponTypePag = new(this, "#Idp", 0, typeof(MagicWeaponTypePag));
					r_R__0__Idp_MagicWeaponTypePag.SetBelong(this.instance);
				}
				return r_R__0__Idp_MagicWeaponTypePag;
			}
		}

		/// <summary>
		/// Void #Jdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Jdp_Object___0__7X;
		public virtual RMethod R__0__Jdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Jdp_Object___0__7X == null)
				{
					r_R__0__Jdp_Object___0__7X = new(this, "#Jdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Jdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Jdp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Kdp()
		/// </summary>
		protected RMethod r_R__0__Kdp;
		public virtual RMethod R__0__Kdp
		{
			get
			{
				if(r_R__0__Kdp == null)
				{
					r_R__0__Kdp = new(this, "#Kdp", 0);
					r_R__0__Kdp.SetBelong(this.instance);
				}
				return r_R__0__Kdp;
			}
		}

		/// <summary>
		/// Void #Ldp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ldp_Object___0__7X;
		public virtual RMethod R__0__Ldp_Object___0__7X
		{
			get
			{
				if(r_R__0__Ldp_Object___0__7X == null)
				{
					r_R__0__Ldp_Object___0__7X = new(this, "#Ldp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ldp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ldp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Mdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Mdp_Object___0__7X;
		public virtual RMethod R__0__Mdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Mdp_Object___0__7X == null)
				{
					r_R__0__Mdp_Object___0__7X = new(this, "#Mdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Mdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Mdp_Object___0__7X;
			}
		}

		/// <summary>
		/// Boolean #Ndp(#oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ndp___0__7X;
		public virtual RMethod R__0__Ndp___0__7X
		{
			get
			{
				if(r_R__0__Ndp___0__7X == null)
				{
					r_R__0__Ndp___0__7X = new(this, "#Ndp", 0,  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ndp___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ndp___0__7X;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #Odp(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__Odp_ElementBase;
		public virtual RMethod R__0__Odp_ElementBase
		{
			get
			{
				if(r_R__0__Odp_ElementBase == null)
				{
					r_R__0__Odp_ElementBase = new(this, "#Odp", 0, typeof(MyGUI.ElementBase));
					r_R__0__Odp_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__Odp_ElementBase;
			}
		}

		/// <summary>
		/// Void #Pdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Pdp_Object___0__7X;
		public virtual RMethod R__0__Pdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Pdp_Object___0__7X == null)
				{
					r_R__0__Pdp_Object___0__7X = new(this, "#Pdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Pdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Pdp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Qdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Qdp_Object___0__7X;
		public virtual RMethod R__0__Qdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Qdp_Object___0__7X == null)
				{
					r_R__0__Qdp_Object___0__7X = new(this, "#Qdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Qdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Qdp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Rdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Rdp_Object___0__7X;
		public virtual RMethod R__0__Rdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Rdp_Object___0__7X == null)
				{
					r_R__0__Rdp_Object___0__7X = new(this, "#Rdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Rdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Rdp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Sdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Sdp_Object___0__7X;
		public virtual RMethod R__0__Sdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Sdp_Object___0__7X == null)
				{
					r_R__0__Sdp_Object___0__7X = new(this, "#Sdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Sdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Sdp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Tdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Tdp_Object___0__7X;
		public virtual RMethod R__0__Tdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Tdp_Object___0__7X == null)
				{
					r_R__0__Tdp_Object___0__7X = new(this, "#Tdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Tdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Tdp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Udp()
		/// </summary>
		protected RMethod r_R__0__Udp;
		public virtual RMethod R__0__Udp
		{
			get
			{
				if(r_R__0__Udp == null)
				{
					r_R__0__Udp = new(this, "#Udp", 0);
					r_R__0__Udp.SetBelong(this.instance);
				}
				return r_R__0__Udp;
			}
		}

		/// <summary>
		/// Void #Vdp()
		/// </summary>
		protected RMethod r_R__0__Vdp;
		public virtual RMethod R__0__Vdp
		{
			get
			{
				if(r_R__0__Vdp == null)
				{
					r_R__0__Vdp = new(this, "#Vdp", 0);
					r_R__0__Vdp.SetBelong(this.instance);
				}
				return r_R__0__Vdp;
			}
		}

		/// <summary>
		/// Void #Wdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Wdp_Object___0__7X;
		public virtual RMethod R__0__Wdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Wdp_Object___0__7X == null)
				{
					r_R__0__Wdp_Object___0__7X = new(this, "#Wdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Wdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Wdp_Object___0__7X;
			}
		}

		/// <summary>
		/// #u.#Ckb #Xdp(Int32)
		/// </summary>
		protected RMethod r_R__0__Xdp_Int32;
		public virtual RMethod R__0__Xdp_Int32
		{
			get
			{
				if(r_R__0__Xdp_Int32 == null)
				{
					r_R__0__Xdp_Int32 = new(this, "#Xdp", 0, typeof(System.Int32));
					r_R__0__Xdp_Int32.SetBelong(this.instance);
				}
				return r_R__0__Xdp_Int32;
			}
		}

		/// <summary>
		/// Void #Ydp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ydp_Object___0__7X;
		public virtual RMethod R__0__Ydp_Object___0__7X
		{
			get
			{
				if(r_R__0__Ydp_Object___0__7X == null)
				{
					r_R__0__Ydp_Object___0__7X = new(this, "#Ydp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ydp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ydp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Zdp(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Zdp_Object___0__7X;
		public virtual RMethod R__0__Zdp_Object___0__7X
		{
			get
			{
				if(r_R__0__Zdp_Object___0__7X == null)
				{
					r_R__0__Zdp_Object___0__7X = new(this, "#Zdp", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Zdp_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Zdp_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #0dp()
		/// </summary>
		protected RMethod r_R__0__0dp;
		public virtual RMethod R__0__0dp
		{
			get
			{
				if(r_R__0__0dp == null)
				{
					r_R__0__0dp = new(this, "#0dp", 0);
					r_R__0__0dp.SetBelong(this.instance);
				}
				return r_R__0__0dp;
			}
		}

		/// <summary>
		/// Void #1dp()
		/// </summary>
		protected RMethod r_R__0__1dp;
		public virtual RMethod R__0__1dp
		{
			get
			{
				if(r_R__0__1dp == null)
				{
					r_R__0__1dp = new(this, "#1dp", 0);
					r_R__0__1dp.SetBelong(this.instance);
				}
				return r_R__0__1dp;
			}
		}

		/// <summary>
		/// Void #2dp()
		/// </summary>
		protected RMethod r_R__0__2dp;
		public virtual RMethod R__0__2dp
		{
			get
			{
				if(r_R__0__2dp == null)
				{
					r_R__0__2dp = new(this, "#2dp", 0);
					r_R__0__2dp.SetBelong(this.instance);
				}
				return r_R__0__2dp;
			}
		}

		/// <summary>
		/// Void #3dp()
		/// </summary>
		protected RMethod r_R__0__3dp;
		public virtual RMethod R__0__3dp
		{
			get
			{
				if(r_R__0__3dp == null)
				{
					r_R__0__3dp = new(this, "#3dp", 0);
					r_R__0__3dp.SetBelong(this.instance);
				}
				return r_R__0__3dp;
			}
		}

		/// <summary>
		/// Int32 #4dp()
		/// </summary>
		protected RMethod r_R__0__4dp;
		public virtual RMethod R__0__4dp
		{
			get
			{
				if(r_R__0__4dp == null)
				{
					r_R__0__4dp = new(this, "#4dp", 0);
					r_R__0__4dp.SetBelong(this.instance);
				}
				return r_R__0__4dp;
			}
		}

		/// <summary>
		/// Boolean #5dp(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__5dp___0__Ckb;
		public virtual RMethod R__0__5dp___0__Ckb
		{
			get
			{
				if(r_R__0__5dp___0__Ckb == null)
				{
					r_R__0__5dp___0__Ckb = new(this, "#5dp", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__5dp___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__5dp___0__Ckb;
			}
		}

		/// <summary>
		/// Int32 #6dp()
		/// </summary>
		protected RMethod r_R__0__6dp;
		public virtual RMethod R__0__6dp
		{
			get
			{
				if(r_R__0__6dp == null)
				{
					r_R__0__6dp = new(this, "#6dp", 0);
					r_R__0__6dp.SetBelong(this.instance);
				}
				return r_R__0__6dp;
			}
		}

		/// <summary>
		/// Int32 #7dp(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__7dp_Int32_Int32;
		public virtual RMethod R__0__7dp_Int32_Int32
		{
			get
			{
				if(r_R__0__7dp_Int32_Int32 == null)
				{
					r_R__0__7dp_Int32_Int32 = new(this, "#7dp", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__7dp_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__7dp_Int32_Int32;
			}
		}

		/// <summary>
		/// Void #jVl()
		/// </summary>
		protected RMethod r_R__0__jVl;
		public virtual RMethod R__0__jVl
		{
			get
			{
				if(r_R__0__jVl == null)
				{
					r_R__0__jVl = new(this, "#jVl", 0);
					r_R__0__jVl.SetBelong(this.instance);
				}
				return r_R__0__jVl;
			}
		}

		/// <summary>
		/// Void #kVl()
		/// </summary>
		protected RMethod r_R__0__kVl;
		public virtual RMethod R__0__kVl
		{
			get
			{
				if(r_R__0__kVl == null)
				{
					r_R__0__kVl = new(this, "#kVl", 0);
					r_R__0__kVl.SetBelong(this.instance);
				}
				return r_R__0__kVl;
			}
		}

		/// <summary>
		/// #u.#Ckb #lVl(Int32)
		/// </summary>
		protected RMethod r_R__0__lVl_Int32;
		public virtual RMethod R__0__lVl_Int32
		{
			get
			{
				if(r_R__0__lVl_Int32 == null)
				{
					r_R__0__lVl_Int32 = new(this, "#lVl", 0, typeof(System.Int32));
					r_R__0__lVl_Int32.SetBelong(this.instance);
				}
				return r_R__0__lVl_Int32;
			}
		}

		/// <summary>
		/// Void #mVl()
		/// </summary>
		protected RMethod r_R__0__mVl;
		public virtual RMethod R__0__mVl
		{
			get
			{
				if(r_R__0__mVl == null)
				{
					r_R__0__mVl = new(this, "#mVl", 0);
					r_R__0__mVl.SetBelong(this.instance);
				}
				return r_R__0__mVl;
			}
		}

		/// <summary>
		/// Void #nVl()
		/// </summary>
		protected RMethod r_R__0__nVl;
		public virtual RMethod R__0__nVl
		{
			get
			{
				if(r_R__0__nVl == null)
				{
					r_R__0__nVl = new(this, "#nVl", 0);
					r_R__0__nVl.SetBelong(this.instance);
				}
				return r_R__0__nVl;
			}
		}

		/// <summary>
		/// Void #oVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__oVl_Object___0__7X;
		public virtual RMethod R__0__oVl_Object___0__7X
		{
			get
			{
				if(r_R__0__oVl_Object___0__7X == null)
				{
					r_R__0__oVl_Object___0__7X = new(this, "#oVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__oVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__oVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #pVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__pVl_Object___0__7X;
		public virtual RMethod R__0__pVl_Object___0__7X
		{
			get
			{
				if(r_R__0__pVl_Object___0__7X == null)
				{
					r_R__0__pVl_Object___0__7X = new(this, "#pVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__pVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__pVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #qVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__qVl_Object___0__7X;
		public virtual RMethod R__0__qVl_Object___0__7X
		{
			get
			{
				if(r_R__0__qVl_Object___0__7X == null)
				{
					r_R__0__qVl_Object___0__7X = new(this, "#qVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__qVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__qVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #rVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__rVl_Object___0__7X;
		public virtual RMethod R__0__rVl_Object___0__7X
		{
			get
			{
				if(r_R__0__rVl_Object___0__7X == null)
				{
					r_R__0__rVl_Object___0__7X = new(this, "#rVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__rVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__rVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #sVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__sVl_Object___0__7X;
		public virtual RMethod R__0__sVl_Object___0__7X
		{
			get
			{
				if(r_R__0__sVl_Object___0__7X == null)
				{
					r_R__0__sVl_Object___0__7X = new(this, "#sVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__sVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__sVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #tVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__tVl_Object___0__7X;
		public virtual RMethod R__0__tVl_Object___0__7X
		{
			get
			{
				if(r_R__0__tVl_Object___0__7X == null)
				{
					r_R__0__tVl_Object___0__7X = new(this, "#tVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__tVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__tVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Etn(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Etn_Object___0__7X;
		public virtual RMethod R__0__Etn_Object___0__7X
		{
			get
			{
				if(r_R__0__Etn_Object___0__7X == null)
				{
					r_R__0__Etn_Object___0__7X = new(this, "#Etn", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Etn_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Etn_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #uVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__uVl_Object___0__7X;
		public virtual RMethod R__0__uVl_Object___0__7X
		{
			get
			{
				if(r_R__0__uVl_Object___0__7X == null)
				{
					r_R__0__uVl_Object___0__7X = new(this, "#uVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__uVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__uVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #vVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__vVl_Object___0__7X;
		public virtual RMethod R__0__vVl_Object___0__7X
		{
			get
			{
				if(r_R__0__vVl_Object___0__7X == null)
				{
					r_R__0__vVl_Object___0__7X = new(this, "#vVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__vVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__vVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #wVl(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__wVl_Object___0__7X;
		public virtual RMethod R__0__wVl_Object___0__7X
		{
			get
			{
				if(r_R__0__wVl_Object___0__7X == null)
				{
					r_R__0__wVl_Object___0__7X = new(this, "#wVl", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__wVl_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__wVl_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #xVl(GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__xVl_ID_Int32;
		public virtual RMethod R__0__xVl_ID_Int32
		{
			get
			{
				if(r_R__0__xVl_ID_Int32 == null)
				{
					r_R__0__xVl_ID_Int32 = new(this, "#xVl", 0, typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__xVl_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__xVl_ID_Int32;
			}
		}

		/// <summary>
		/// Void #Fsd()
		/// </summary>
		protected RMethod r_R__0__Fsd;
		public virtual RMethod R__0__Fsd
		{
			get
			{
				if(r_R__0__Fsd == null)
				{
					r_R__0__Fsd = new(this, "#Fsd", 0);
					r_R__0__Fsd.SetBelong(this.instance);
				}
				return r_R__0__Fsd;
			}
		}

		/// <summary>
		/// Void #SAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__SAd_Object___0__7X;
		public virtual RMethod R__0__SAd_Object___0__7X
		{
			get
			{
				if(r_R__0__SAd_Object___0__7X == null)
				{
					r_R__0__SAd_Object___0__7X = new(this, "#SAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__SAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__SAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #TAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__TAd_Object___0__7X;
		public virtual RMethod R__0__TAd_Object___0__7X
		{
			get
			{
				if(r_R__0__TAd_Object___0__7X == null)
				{
					r_R__0__TAd_Object___0__7X = new(this, "#TAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__TAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__TAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #UAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__UAd_Object___0__7X;
		public virtual RMethod R__0__UAd_Object___0__7X
		{
			get
			{
				if(r_R__0__UAd_Object___0__7X == null)
				{
					r_R__0__UAd_Object___0__7X = new(this, "#UAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__UAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__UAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Gsd()
		/// </summary>
		protected RMethod r_R__0__Gsd;
		public virtual RMethod R__0__Gsd
		{
			get
			{
				if(r_R__0__Gsd == null)
				{
					r_R__0__Gsd = new(this, "#Gsd", 0);
					r_R__0__Gsd.SetBelong(this.instance);
				}
				return r_R__0__Gsd;
			}
		}

		/// <summary>
		/// Void #Hsd()
		/// </summary>
		protected RMethod r_R__0__Hsd;
		public virtual RMethod R__0__Hsd
		{
			get
			{
				if(r_R__0__Hsd == null)
				{
					r_R__0__Hsd = new(this, "#Hsd", 0);
					r_R__0__Hsd.SetBelong(this.instance);
				}
				return r_R__0__Hsd;
			}
		}

		/// <summary>
		/// Void #Isd()
		/// </summary>
		protected RMethod r_R__0__Isd;
		public virtual RMethod R__0__Isd
		{
			get
			{
				if(r_R__0__Isd == null)
				{
					r_R__0__Isd = new(this, "#Isd", 0);
					r_R__0__Isd.SetBelong(this.instance);
				}
				return r_R__0__Isd;
			}
		}

		/// <summary>
		/// Void #8Xd()
		/// </summary>
		protected RMethod r_R__0__8Xd;
		public virtual RMethod R__0__8Xd
		{
			get
			{
				if(r_R__0__8Xd == null)
				{
					r_R__0__8Xd = new(this, "#8Xd", 0);
					r_R__0__8Xd.SetBelong(this.instance);
				}
				return r_R__0__8Xd;
			}
		}

		/// <summary>
		/// Void #sAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__sAd_Object___0__7X;
		public virtual RMethod R__0__sAd_Object___0__7X
		{
			get
			{
				if(r_R__0__sAd_Object___0__7X == null)
				{
					r_R__0__sAd_Object___0__7X = new(this, "#sAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__sAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__sAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #tAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__tAd_Object___0__7X;
		public virtual RMethod R__0__tAd_Object___0__7X
		{
			get
			{
				if(r_R__0__tAd_Object___0__7X == null)
				{
					r_R__0__tAd_Object___0__7X = new(this, "#tAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__tAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__tAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #uAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__uAd_Object___0__7X;
		public virtual RMethod R__0__uAd_Object___0__7X
		{
			get
			{
				if(r_R__0__uAd_Object___0__7X == null)
				{
					r_R__0__uAd_Object___0__7X = new(this, "#uAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__uAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__uAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #9Xd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__9Xd_Object___0__7X;
		public virtual RMethod R__0__9Xd_Object___0__7X
		{
			get
			{
				if(r_R__0__9Xd_Object___0__7X == null)
				{
					r_R__0__9Xd_Object___0__7X = new(this, "#9Xd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__9Xd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__9Xd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #aYd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__aYd_Object___0__7X;
		public virtual RMethod R__0__aYd_Object___0__7X
		{
			get
			{
				if(r_R__0__aYd_Object___0__7X == null)
				{
					r_R__0__aYd_Object___0__7X = new(this, "#aYd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__aYd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__aYd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #bYd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__bYd_Object___0__7X;
		public virtual RMethod R__0__bYd_Object___0__7X
		{
			get
			{
				if(r_R__0__bYd_Object___0__7X == null)
				{
					r_R__0__bYd_Object___0__7X = new(this, "#bYd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__bYd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__bYd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #cYd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__cYd_Object___0__7X;
		public virtual RMethod R__0__cYd_Object___0__7X
		{
			get
			{
				if(r_R__0__cYd_Object___0__7X == null)
				{
					r_R__0__cYd_Object___0__7X = new(this, "#cYd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__cYd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__cYd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #dYd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__dYd_Object___0__7X;
		public virtual RMethod R__0__dYd_Object___0__7X
		{
			get
			{
				if(r_R__0__dYd_Object___0__7X == null)
				{
					r_R__0__dYd_Object___0__7X = new(this, "#dYd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__dYd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__dYd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #eYd()
		/// </summary>
		protected RMethod r_R__0__eYd;
		public virtual RMethod R__0__eYd
		{
			get
			{
				if(r_R__0__eYd == null)
				{
					r_R__0__eYd = new(this, "#eYd", 0);
					r_R__0__eYd.SetBelong(this.instance);
				}
				return r_R__0__eYd;
			}
		}

		/// <summary>
		/// Void #fYd(System.String)
		/// </summary>
		protected RMethod r_R__0__fYd_String;
		public virtual RMethod R__0__fYd_String
		{
			get
			{
				if(r_R__0__fYd_String == null)
				{
					r_R__0__fYd_String = new(this, "#fYd", 0, typeof(System.String));
					r_R__0__fYd_String.SetBelong(this.instance);
				}
				return r_R__0__fYd_String;
			}
		}

		/// <summary>
		/// Void #gYd(System.String)
		/// </summary>
		protected RMethod r_R__0__gYd_String;
		public virtual RMethod R__0__gYd_String
		{
			get
			{
				if(r_R__0__gYd_String == null)
				{
					r_R__0__gYd_String = new(this, "#gYd", 0, typeof(System.String));
					r_R__0__gYd_String.SetBelong(this.instance);
				}
				return r_R__0__gYd_String;
			}
		}

		/// <summary>
		/// Void #hYd(System.String, System.String)
		/// </summary>
		protected RMethod r_R__0__hYd_String_String;
		public virtual RMethod R__0__hYd_String_String
		{
			get
			{
				if(r_R__0__hYd_String_String == null)
				{
					r_R__0__hYd_String_String = new(this, "#hYd", 0, typeof(System.String), typeof(System.String));
					r_R__0__hYd_String_String.SetBelong(this.instance);
				}
				return r_R__0__hYd_String_String;
			}
		}

		/// <summary>
		/// Void #iYd(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__iYd___0__Ckb;
		public virtual RMethod R__0__iYd___0__Ckb
		{
			get
			{
				if(r_R__0__iYd___0__Ckb == null)
				{
					r_R__0__iYd___0__Ckb = new(this, "#iYd", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__iYd___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__iYd___0__Ckb;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase #jYd(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__jYd___0__Ckb;
		public virtual RMethod R__0__jYd___0__Ckb
		{
			get
			{
				if(r_R__0__jYd___0__Ckb == null)
				{
					r_R__0__jYd___0__Ckb = new(this, "#jYd", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__jYd___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__jYd___0__Ckb;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[#u.#Ckb] #kYd()
		/// </summary>
		protected RMethod r_R__0__kYd;
		public virtual RMethod R__0__kYd
		{
			get
			{
				if(r_R__0__kYd == null)
				{
					r_R__0__kYd = new(this, "#kYd", 0);
					r_R__0__kYd.SetBelong(this.instance);
				}
				return r_R__0__kYd;
			}
		}

		/// <summary>
		/// Int32 #8Hf()
		/// </summary>
		protected RMethod r_R__0__8Hf;
		public virtual RMethod R__0__8Hf
		{
			get
			{
				if(r_R__0__8Hf == null)
				{
					r_R__0__8Hf = new(this, "#8Hf", 0);
					r_R__0__8Hf.SetBelong(this.instance);
				}
				return r_R__0__8Hf;
			}
		}

		/// <summary>
		/// Void #lYd()
		/// </summary>
		protected RMethod r_R__0__lYd;
		public virtual RMethod R__0__lYd
		{
			get
			{
				if(r_R__0__lYd == null)
				{
					r_R__0__lYd = new(this, "#lYd", 0);
					r_R__0__lYd.SetBelong(this.instance);
				}
				return r_R__0__lYd;
			}
		}

		/// <summary>
		/// Void #iYd(Int32)
		/// </summary>
		protected RMethod r_R__0__iYd_Int32;
		public virtual RMethod R__0__iYd_Int32
		{
			get
			{
				if(r_R__0__iYd_Int32 == null)
				{
					r_R__0__iYd_Int32 = new(this, "#iYd", 0, typeof(System.Int32));
					r_R__0__iYd_Int32.SetBelong(this.instance);
				}
				return r_R__0__iYd_Int32;
			}
		}

		/// <summary>
		/// Int32 #9Hf()
		/// </summary>
		protected RMethod r_R__0__9Hf;
		public virtual RMethod R__0__9Hf
		{
			get
			{
				if(r_R__0__9Hf == null)
				{
					r_R__0__9Hf = new(this, "#9Hf", 0);
					r_R__0__9Hf.SetBelong(this.instance);
				}
				return r_R__0__9Hf;
			}
		}

		/// <summary>
		/// #u.#Ckb #mYd(Int32)
		/// </summary>
		protected RMethod r_R__0__mYd_Int32;
		public virtual RMethod R__0__mYd_Int32
		{
			get
			{
				if(r_R__0__mYd_Int32 == null)
				{
					r_R__0__mYd_Int32 = new(this, "#mYd", 0, typeof(System.Int32));
					r_R__0__mYd_Int32.SetBelong(this.instance);
				}
				return r_R__0__mYd_Int32;
			}
		}

		/// <summary>
		/// Void #Vag()
		/// </summary>
		protected RMethod r_R__0__Vag;
		public virtual RMethod R__0__Vag
		{
			get
			{
				if(r_R__0__Vag == null)
				{
					r_R__0__Vag = new(this, "#Vag", 0);
					r_R__0__Vag.SetBelong(this.instance);
				}
				return r_R__0__Vag;
			}
		}

		/// <summary>
		/// #u.#Ckb #nYd(Int32)
		/// </summary>
		protected RMethod r_R__0__nYd_Int32;
		public virtual RMethod R__0__nYd_Int32
		{
			get
			{
				if(r_R__0__nYd_Int32 == null)
				{
					r_R__0__nYd_Int32 = new(this, "#nYd", 0, typeof(System.Int32));
					r_R__0__nYd_Int32.SetBelong(this.instance);
				}
				return r_R__0__nYd_Int32;
			}
		}

		/// <summary>
		/// #u.#Ckb #nYd(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__nYd_ID;
		public virtual RMethod R__0__nYd_ID
		{
			get
			{
				if(r_R__0__nYd_ID == null)
				{
					r_R__0__nYd_ID = new(this, "#nYd", 0, typeof(GameDefineType.ID));
					r_R__0__nYd_ID.SetBelong(this.instance);
				}
				return r_R__0__nYd_ID;
			}
		}

		/// <summary>
		/// Void #oYd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__oYd_Object___0__7X;
		public virtual RMethod R__0__oYd_Object___0__7X
		{
			get
			{
				if(r_R__0__oYd_Object___0__7X == null)
				{
					r_R__0__oYd_Object___0__7X = new(this, "#oYd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__oYd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__oYd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #pYd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__pYd_Object___0__7X;
		public virtual RMethod R__0__pYd_Object___0__7X
		{
			get
			{
				if(r_R__0__pYd_Object___0__7X == null)
				{
					r_R__0__pYd_Object___0__7X = new(this, "#pYd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__pYd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__pYd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #oAd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__oAd_Object___0__7X;
		public virtual RMethod R__0__oAd_Object___0__7X
		{
			get
			{
				if(r_R__0__oAd_Object___0__7X == null)
				{
					r_R__0__oAd_Object___0__7X = new(this, "#oAd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__oAd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__oAd_Object___0__7X;
			}
		}

		/// <summary>
		/// Int32 #Bzi()
		/// </summary>
		protected RMethod r_R__0__Bzi;
		public virtual RMethod R__0__Bzi
		{
			get
			{
				if(r_R__0__Bzi == null)
				{
					r_R__0__Bzi = new(this, "#Bzi", 0);
					r_R__0__Bzi.SetBelong(this.instance);
				}
				return r_R__0__Bzi;
			}
		}

		/// <summary>
		/// Void #Czi(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Czi_Object___0__7X;
		public virtual RMethod R__0__Czi_Object___0__7X
		{
			get
			{
				if(r_R__0__Czi_Object___0__7X == null)
				{
					r_R__0__Czi_Object___0__7X = new(this, "#Czi", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Czi_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Czi_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Dzi(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Dzi_Object___0__7X;
		public virtual RMethod R__0__Dzi_Object___0__7X
		{
			get
			{
				if(r_R__0__Dzi_Object___0__7X == null)
				{
					r_R__0__Dzi_Object___0__7X = new(this, "#Dzi", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Dzi_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Dzi_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Ezi(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ezi_Object___0__7X;
		public virtual RMethod R__0__Ezi_Object___0__7X
		{
			get
			{
				if(r_R__0__Ezi_Object___0__7X == null)
				{
					r_R__0__Ezi_Object___0__7X = new(this, "#Ezi", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ezi_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ezi_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #pAd(System.Object)
		/// </summary>
		protected RMethod r_R__0__pAd_Object;
		public virtual RMethod R__0__pAd_Object
		{
			get
			{
				if(r_R__0__pAd_Object == null)
				{
					r_R__0__pAd_Object = new(this, "#pAd", 0, typeof(System.Object));
					r_R__0__pAd_Object.SetBelong(this.instance);
				}
				return r_R__0__pAd_Object;
			}
		}

		/// <summary>
		/// Void #qYd(System.Object)
		/// </summary>
		protected RMethod r_R__0__qYd_Object;
		public virtual RMethod R__0__qYd_Object
		{
			get
			{
				if(r_R__0__qYd_Object == null)
				{
					r_R__0__qYd_Object = new(this, "#qYd", 0, typeof(System.Object));
					r_R__0__qYd_Object.SetBelong(this.instance);
				}
				return r_R__0__qYd_Object;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #zah(System.String)
		/// </summary>
		protected RMethod r_R__0__zah_String;
		public virtual RMethod R__0__zah_String
		{
			get
			{
				if(r_R__0__zah_String == null)
				{
					r_R__0__zah_String = new(this, "#zah", 0, typeof(System.String));
					r_R__0__zah_String.SetBelong(this.instance);
				}
				return r_R__0__zah_String;
			}
		}

		/// <summary>
		/// Void #aIf(Int32)
		/// </summary>
		protected RMethod r_R__0__aIf_Int32;
		public virtual RMethod R__0__aIf_Int32
		{
			get
			{
				if(r_R__0__aIf_Int32 == null)
				{
					r_R__0__aIf_Int32 = new(this, "#aIf", 0, typeof(System.Int32));
					r_R__0__aIf_Int32.SetBelong(this.instance);
				}
				return r_R__0__aIf_Int32;
			}
		}

		/// <summary>
		/// Void #bIf(System.Object)
		/// </summary>
		protected RMethod r_R__0__bIf_Object;
		public virtual RMethod R__0__bIf_Object
		{
			get
			{
				if(r_R__0__bIf_Object == null)
				{
					r_R__0__bIf_Object = new(this, "#bIf", 0, typeof(System.Object));
					r_R__0__bIf_Object.SetBelong(this.instance);
				}
				return r_R__0__bIf_Object;
			}
		}

		/// <summary>
		/// Void #5Yg(System.Object)
		/// </summary>
		protected RMethod r_R__0__5Yg_Object;
		public virtual RMethod R__0__5Yg_Object
		{
			get
			{
				if(r_R__0__5Yg_Object == null)
				{
					r_R__0__5Yg_Object = new(this, "#5Yg", 0, typeof(System.Object));
					r_R__0__5Yg_Object.SetBelong(this.instance);
				}
				return r_R__0__5Yg_Object;
			}
		}

		/// <summary>
		/// Void #rYd(Int32)
		/// </summary>
		protected RMethod r_R__0__rYd_Int32;
		public virtual RMethod R__0__rYd_Int32
		{
			get
			{
				if(r_R__0__rYd_Int32 == null)
				{
					r_R__0__rYd_Int32 = new(this, "#rYd", 0, typeof(System.Int32));
					r_R__0__rYd_Int32.SetBelong(this.instance);
				}
				return r_R__0__rYd_Int32;
			}
		}

		/// <summary>
		/// Void #sYd(Int32)
		/// </summary>
		protected RMethod r_R__0__sYd_Int32;
		public virtual RMethod R__0__sYd_Int32
		{
			get
			{
				if(r_R__0__sYd_Int32 == null)
				{
					r_R__0__sYd_Int32 = new(this, "#sYd", 0, typeof(System.Int32));
					r_R__0__sYd_Int32.SetBelong(this.instance);
				}
				return r_R__0__sYd_Int32;
			}
		}

		/// <summary>
		/// Void #9y(#u.#Bu, System.Object)
		/// </summary>
		protected RMethod r_R__0__9y___0__Bu_Object;
		public virtual RMethod R__0__9y___0__Bu_Object
		{
			get
			{
				if(r_R__0__9y___0__Bu_Object == null)
				{
					r_R__0__9y___0__Bu_Object = new(this, "#9y", 0,  ReleactionUtils.GetType("#u.#Bu"), typeof(System.Object));
					r_R__0__9y___0__Bu_Object.SetBelong(this.instance);
				}
				return r_R__0__9y___0__Bu_Object;
			}
		}

		/// <summary>
		/// Void #Nlb(#u.#Bu, System.Object)
		/// </summary>
		protected RMethod r_R__0__Nlb___0__Bu_Object;
		public virtual RMethod R__0__Nlb___0__Bu_Object
		{
			get
			{
				if(r_R__0__Nlb___0__Bu_Object == null)
				{
					r_R__0__Nlb___0__Bu_Object = new(this, "#Nlb", 0,  ReleactionUtils.GetType("#u.#Bu"), typeof(System.Object));
					r_R__0__Nlb___0__Bu_Object.SetBelong(this.instance);
				}
				return r_R__0__Nlb___0__Bu_Object;
			}
		}

		/// <summary>
		/// Void #nAd(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__nAd_Object_Object;
		public virtual RMethod R__0__nAd_Object_Object
		{
			get
			{
				if(r_R__0__nAd_Object_Object == null)
				{
					r_R__0__nAd_Object_Object = new(this, "#nAd", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__nAd_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__nAd_Object_Object;
			}
		}

		/// <summary>
		/// Void #0Od(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__0Od_Object___0__7X;
		public virtual RMethod R__0__0Od_Object___0__7X
		{
			get
			{
				if(r_R__0__0Od_Object___0__7X == null)
				{
					r_R__0__0Od_Object___0__7X = new(this, "#0Od", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__0Od_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__0Od_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #1Od(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__1Od_Object___0__7X;
		public virtual RMethod R__0__1Od_Object___0__7X
		{
			get
			{
				if(r_R__0__1Od_Object___0__7X == null)
				{
					r_R__0__1Od_Object___0__7X = new(this, "#1Od", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__1Od_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__1Od_Object___0__7X;
			}
		}

		/// <summary>
		/// Boolean #tYd(#oU.#7X)
		/// </summary>
		protected RMethod r_R__0__tYd___0__7X;
		public virtual RMethod R__0__tYd___0__7X
		{
			get
			{
				if(r_R__0__tYd___0__7X == null)
				{
					r_R__0__tYd___0__7X = new(this, "#tYd", 0,  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__tYd___0__7X.SetBelong(this.instance);
				}
				return r_R__0__tYd___0__7X;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #uYd(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__uYd_ElementBase;
		public virtual RMethod R__0__uYd_ElementBase
		{
			get
			{
				if(r_R__0__uYd_ElementBase == null)
				{
					r_R__0__uYd_ElementBase = new(this, "#uYd", 0, typeof(MyGUI.ElementBase));
					r_R__0__uYd_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__uYd_ElementBase;
			}
		}

		/// <summary>
		/// Void #vYd(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__vYd_ElementBase;
		public virtual RMethod R__0__vYd_ElementBase
		{
			get
			{
				if(r_R__0__vYd_ElementBase == null)
				{
					r_R__0__vYd_ElementBase = new(this, "#vYd", 0, typeof(MyGUI.ElementBase));
					r_R__0__vYd_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__vYd_ElementBase;
			}
		}

		/// <summary>
		/// Void #wYd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__wYd_Object___0__7X;
		public virtual RMethod R__0__wYd_Object___0__7X
		{
			get
			{
				if(r_R__0__wYd_Object___0__7X == null)
				{
					r_R__0__wYd_Object___0__7X = new(this, "#wYd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__wYd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__wYd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #shl()
		/// </summary>
		protected RMethod r_R__0__shl;
		public virtual RMethod R__0__shl
		{
			get
			{
				if(r_R__0__shl == null)
				{
					r_R__0__shl = new(this, "#shl", 0);
					r_R__0__shl.SetBelong(this.instance);
				}
				return r_R__0__shl;
			}
		}

		/// <summary>
		/// Boolean #xXq(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__xXq___0__Ckb;
		public virtual RMethod R__0__xXq___0__Ckb
		{
			get
			{
				if(r_R__0__xXq___0__Ckb == null)
				{
					r_R__0__xXq___0__Ckb = new(this, "#xXq", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__xXq___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__xXq___0__Ckb;
			}
		}

		/// <summary>
		/// Void #yXq(System.Object, #oU.#7X)
		/// </summary>
		protected static RMethod r_R__0__yXq_Object___0__7X;
		public static RMethod R__0__yXq_Object___0__7X
		{
			get
			{
				if(r_R__0__yXq_Object___0__7X == null)
				{
					r_R__0__yXq_Object___0__7X = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#yXq", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__yXq_Object___0__7X.SetBelong(null);
				}
				return r_R__0__yXq_Object___0__7X;
			}
		}

		/// <summary>
		/// Boolean #zXq(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__zXq___0__Ckb;
		public virtual RMethod R__0__zXq___0__Ckb
		{
			get
			{
				if(r_R__0__zXq___0__Ckb == null)
				{
					r_R__0__zXq___0__Ckb = new(this, "#zXq", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__zXq___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__zXq___0__Ckb;
			}
		}

		/// <summary>
		/// Boolean #AXq(#u.#Ckb)
		/// </summary>
		protected static RMethod r_R__0__AXq___0__Ckb;
		public static RMethod R__0__AXq___0__Ckb
		{
			get
			{
				if(r_R__0__AXq___0__Ckb == null)
				{
					r_R__0__AXq___0__Ckb = new( ReleactionUtils.GetType("MyGUIFinalEquipWnd"), "#AXq", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__AXq___0__Ckb.SetBelong(null);
				}
				return r_R__0__AXq___0__Ckb;
			}
		}

		/// <summary>
		/// Void #dKb(Single)
		/// </summary>
		protected RMethod r_R__0__dKb_Single;
		public virtual RMethod R__0__dKb_Single
		{
			get
			{
				if(r_R__0__dKb_Single == null)
				{
					r_R__0__dKb_Single = new(this, "#dKb", 0, typeof(System.Single));
					r_R__0__dKb_Single.SetBelong(this.instance);
				}
				return r_R__0__dKb_Single;
			}
		}

		/// <summary>
		/// Void #eKb(Single)
		/// </summary>
		protected RMethod r_R__0__eKb_Single;
		public virtual RMethod R__0__eKb_Single
		{
			get
			{
				if(r_R__0__eKb_Single == null)
				{
					r_R__0__eKb_Single = new(this, "#eKb", 0, typeof(System.Single));
					r_R__0__eKb_Single.SetBelong(this.instance);
				}
				return r_R__0__eKb_Single;
			}
		}

		/// <summary>
		/// Void #fKb(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__fKb_Vector2;
		public virtual RMethod R__0__fKb_Vector2
		{
			get
			{
				if(r_R__0__fKb_Vector2 == null)
				{
					r_R__0__fKb_Vector2 = new(this, "#fKb", 0, typeof(UnityEngine.Vector2));
					r_R__0__fKb_Vector2.SetBelong(this.instance);
				}
				return r_R__0__fKb_Vector2;
			}
		}

		/// <summary>
		/// Void #gKb()
		/// </summary>
		protected RMethod r_R__0__gKb;
		public virtual RMethod R__0__gKb
		{
			get
			{
				if(r_R__0__gKb == null)
				{
					r_R__0__gKb = new(this, "#gKb", 0);
					r_R__0__gKb.SetBelong(this.instance);
				}
				return r_R__0__gKb;
			}
		}

		/// <summary>
		/// Void #EF()
		/// </summary>
		protected RMethod r_R__0__EF;
		public virtual RMethod R__0__EF
		{
			get
			{
				if(r_R__0__EF == null)
				{
					r_R__0__EF = new(this, "#EF", 0);
					r_R__0__EF.SetBelong(this.instance);
				}
				return r_R__0__EF;
			}
		}

		/// <summary>
		/// Void Resize()
		/// </summary>
		protected RMethod r_RResize;
		public virtual RMethod RResize
		{
			get
			{
				if(r_RResize == null)
				{
					r_RResize = new(this, "Resize", 0);
					r_RResize.SetBelong(this.instance);
				}
				return r_RResize;
			}
		}

		/// <summary>
		/// Void #hKb(UnityEngine.Vector2, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__hKb_Vector2_Vector2;
		public virtual RMethod R__0__hKb_Vector2_Vector2
		{
			get
			{
				if(r_R__0__hKb_Vector2_Vector2 == null)
				{
					r_R__0__hKb_Vector2_Vector2 = new(this, "#hKb", 0, typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2));
					r_R__0__hKb_Vector2_Vector2.SetBelong(this.instance);
				}
				return r_R__0__hKb_Vector2_Vector2;
			}
		}

		/// <summary>
		/// Boolean #u1b(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__u1b_Vector2;
		public virtual RMethod R__0__u1b_Vector2
		{
			get
			{
				if(r_R__0__u1b_Vector2 == null)
				{
					r_R__0__u1b_Vector2 = new(this, "#u1b", 0, typeof(UnityEngine.Vector2));
					r_R__0__u1b_Vector2.SetBelong(this.instance);
				}
				return r_R__0__u1b_Vector2;
			}
		}

		/// <summary>
		/// Void #iKb(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__iKb_Vector2;
		public virtual RMethod R__0__iKb_Vector2
		{
			get
			{
				if(r_R__0__iKb_Vector2 == null)
				{
					r_R__0__iKb_Vector2 = new(this, "#iKb", 0, typeof(UnityEngine.Vector2));
					r_R__0__iKb_Vector2.SetBelong(this.instance);
				}
				return r_R__0__iKb_Vector2;
			}
		}

		/// <summary>
		/// Void #jKb()
		/// </summary>
		protected RMethod r_R__0__jKb;
		public virtual RMethod R__0__jKb
		{
			get
			{
				if(r_R__0__jKb == null)
				{
					r_R__0__jKb = new(this, "#jKb", 0);
					r_R__0__jKb.SetBelong(this.instance);
				}
				return r_R__0__jKb;
			}
		}

		/// <summary>
		/// Void Initialize()
		/// </summary>
		protected RMethod r_RInitialize;
		public virtual RMethod RInitialize
		{
			get
			{
				if(r_RInitialize == null)
				{
					r_RInitialize = new(this, "Initialize", 0);
					r_RInitialize.SetBelong(this.instance);
				}
				return r_RInitialize;
			}
		}

		/// <summary>
		/// Boolean #pq()
		/// </summary>
		protected RMethod r_R__0__pq;
		public virtual RMethod R__0__pq
		{
			get
			{
				if(r_R__0__pq == null)
				{
					r_R__0__pq = new(this, "#pq", 0);
					r_R__0__pq.SetBelong(this.instance);
				}
				return r_R__0__pq;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase #kKb(System.String)
		/// </summary>
		protected RMethod r_R__0__kKb_String;
		public virtual RMethod R__0__kKb_String
		{
			get
			{
				if(r_R__0__kKb_String == null)
				{
					r_R__0__kKb_String = new(this, "#kKb", 0, typeof(System.String));
					r_R__0__kKb_String.SetBelong(this.instance);
				}
				return r_R__0__kKb_String;
			}
		}

		/// <summary>
		/// #bk #kKb[#bk](System.String)
		/// </summary>
		protected RMethod r_R__0__kKb_G__0__bk_String;
		public virtual RMethod R__0__kKb_G__0__bk_String
		{
			get
			{
				if(r_R__0__kKb_G__0__bk_String == null)
				{
					r_R__0__kKb_G__0__bk_String = new(this, "#kKb", 1, typeof(System.String));
					r_R__0__kKb_G__0__bk_String.SetBelong(this.instance);
				}
				return r_R__0__kKb_G__0__bk_String;
			}
		}

		/// <summary>
		/// Void #lKb()
		/// </summary>
		protected RMethod r_R__0__lKb;
		public virtual RMethod R__0__lKb
		{
			get
			{
				if(r_R__0__lKb == null)
				{
					r_R__0__lKb = new(this, "#lKb", 0);
					r_R__0__lKb.SetBelong(this.instance);
				}
				return r_R__0__lKb;
			}
		}

		/// <summary>
		/// Void #Ibb()
		/// </summary>
		protected RMethod r_R__0__Ibb;
		public virtual RMethod R__0__Ibb
		{
			get
			{
				if(r_R__0__Ibb == null)
				{
					r_R__0__Ibb = new(this, "#Ibb", 0);
					r_R__0__Ibb.SetBelong(this.instance);
				}
				return r_R__0__Ibb;
			}
		}

		/// <summary>
		/// Void #mKb(Boolean)
		/// </summary>
		protected RMethod r_R__0__mKb_Boolean;
		public virtual RMethod R__0__mKb_Boolean
		{
			get
			{
				if(r_R__0__mKb_Boolean == null)
				{
					r_R__0__mKb_Boolean = new(this, "#mKb", 0, typeof(System.Boolean));
					r_R__0__mKb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__mKb_Boolean;
			}
		}

		/// <summary>
		/// Void #nKb()
		/// </summary>
		protected RMethod r_R__0__nKb;
		public virtual RMethod R__0__nKb
		{
			get
			{
				if(r_R__0__nKb == null)
				{
					r_R__0__nKb = new(this, "#nKb", 0);
					r_R__0__nKb.SetBelong(this.instance);
				}
				return r_R__0__nKb;
			}
		}

		/// <summary>
		/// Void #Mr(Boolean)
		/// </summary>
		protected RMethod r_R__0__Mr_Boolean;
		public virtual RMethod R__0__Mr_Boolean
		{
			get
			{
				if(r_R__0__Mr_Boolean == null)
				{
					r_R__0__Mr_Boolean = new(this, "#Mr", 0, typeof(System.Boolean));
					r_R__0__Mr_Boolean.SetBelong(this.instance);
				}
				return r_R__0__Mr_Boolean;
			}
		}

		/// <summary>
		/// Void #rKb(Boolean)
		/// </summary>
		protected RMethod r_R__0__rKb_Boolean;
		public virtual RMethod R__0__rKb_Boolean
		{
			get
			{
				if(r_R__0__rKb_Boolean == null)
				{
					r_R__0__rKb_Boolean = new(this, "#rKb", 0, typeof(System.Boolean));
					r_R__0__rKb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__rKb_Boolean;
			}
		}

		/// <summary>
		/// Void #tKb(Boolean)
		/// </summary>
		protected RMethod r_R__0__tKb_Boolean;
		public virtual RMethod R__0__tKb_Boolean
		{
			get
			{
				if(r_R__0__tKb_Boolean == null)
				{
					r_R__0__tKb_Boolean = new(this, "#tKb", 0, typeof(System.Boolean));
					r_R__0__tKb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__tKb_Boolean;
			}
		}

		/// <summary>
		/// Void #uKb(Boolean)
		/// </summary>
		protected RMethod r_R__0__uKb_Boolean;
		public virtual RMethod R__0__uKb_Boolean
		{
			get
			{
				if(r_R__0__uKb_Boolean == null)
				{
					r_R__0__uKb_Boolean = new(this, "#uKb", 0, typeof(System.Boolean));
					r_R__0__uKb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__uKb_Boolean;
			}
		}

		/// <summary>
		/// Boolean #bN()
		/// </summary>
		protected RMethod r_R__0__bN;
		public virtual RMethod R__0__bN
		{
			get
			{
				if(r_R__0__bN == null)
				{
					r_R__0__bN = new(this, "#bN", 0);
					r_R__0__bN.SetBelong(this.instance);
				}
				return r_R__0__bN;
			}
		}

		/// <summary>
		/// Boolean #wKb()
		/// </summary>
		protected RMethod r_R__0__wKb;
		public virtual RMethod R__0__wKb
		{
			get
			{
				if(r_R__0__wKb == null)
				{
					r_R__0__wKb = new(this, "#wKb", 0);
					r_R__0__wKb.SetBelong(this.instance);
				}
				return r_R__0__wKb;
			}
		}

		/// <summary>
		/// Boolean #xKb()
		/// </summary>
		protected RMethod r_R__0__xKb;
		public virtual RMethod R__0__xKb
		{
			get
			{
				if(r_R__0__xKb == null)
				{
					r_R__0__xKb = new(this, "#xKb", 0);
					r_R__0__xKb.SetBelong(this.instance);
				}
				return r_R__0__xKb;
			}
		}

		/// <summary>
		/// Boolean #yKb()
		/// </summary>
		protected RMethod r_R__0__yKb;
		public virtual RMethod R__0__yKb
		{
			get
			{
				if(r_R__0__yKb == null)
				{
					r_R__0__yKb = new(this, "#yKb", 0);
					r_R__0__yKb.SetBelong(this.instance);
				}
				return r_R__0__yKb;
			}
		}

		/// <summary>
		/// Boolean #zKb(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__zKb_Vector2;
		public virtual RMethod R__0__zKb_Vector2
		{
			get
			{
				if(r_R__0__zKb_Vector2 == null)
				{
					r_R__0__zKb_Vector2 = new(this, "#zKb", 0, typeof(UnityEngine.Vector2));
					r_R__0__zKb_Vector2.SetBelong(this.instance);
				}
				return r_R__0__zKb_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 #uo()
		/// </summary>
		protected RMethod r_R__0__uo;
		public virtual RMethod R__0__uo
		{
			get
			{
				if(r_R__0__uo == null)
				{
					r_R__0__uo = new(this, "#uo", 0);
					r_R__0__uo.SetBelong(this.instance);
				}
				return r_R__0__uo;
			}
		}

		/// <summary>
		/// Void #gw(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__gw_Vector2;
		public virtual RMethod R__0__gw_Vector2
		{
			get
			{
				if(r_R__0__gw_Vector2 == null)
				{
					r_R__0__gw_Vector2 = new(this, "#gw", 0, typeof(UnityEngine.Vector2));
					r_R__0__gw_Vector2.SetBelong(this.instance);
				}
				return r_R__0__gw_Vector2;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetWindowLocation()
		/// </summary>
		protected RMethod r_RGetWindowLocation;
		public virtual RMethod RGetWindowLocation
		{
			get
			{
				if(r_RGetWindowLocation == null)
				{
					r_RGetWindowLocation = new(this, "GetWindowLocation", 0);
					r_RGetWindowLocation.SetBelong(this.instance);
				}
				return r_RGetWindowLocation;
			}
		}

		/// <summary>
		/// Void #AKb(System.String, UIeffect)
		/// </summary>
		protected RMethod r_R__0__AKb_String_UIeffect;
		public virtual RMethod R__0__AKb_String_UIeffect
		{
			get
			{
				if(r_R__0__AKb_String_UIeffect == null)
				{
					r_R__0__AKb_String_UIeffect = new(this, "#AKb", 0, typeof(System.String), typeof(UIeffect));
					r_R__0__AKb_String_UIeffect.SetBelong(this.instance);
				}
				return r_R__0__AKb_String_UIeffect;
			}
		}

		/// <summary>
		/// #bk #Oh[#bk]()
		/// </summary>
		protected RMethod r_R__0__Oh_G__0__bk;
		public virtual RMethod R__0__Oh_G__0__bk
		{
			get
			{
				if(r_R__0__Oh_G__0__bk == null)
				{
					r_R__0__Oh_G__0__bk = new(this, "#Oh", 1);
					r_R__0__Oh_G__0__bk.SetBelong(this.instance);
				}
				return r_R__0__Oh_G__0__bk;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[MyGUIWindow] #BKb()
		/// </summary>
		protected RMethod r_R__0__BKb;
		public virtual RMethod R__0__BKb
		{
			get
			{
				if(r_R__0__BKb == null)
				{
					r_R__0__BKb = new(this, "#BKb", 0);
					r_R__0__BKb.SetBelong(this.instance);
				}
				return r_R__0__BKb;
			}
		}

		/// <summary>
		/// Void #CKb()
		/// </summary>
		protected RMethod r_R__0__CKb;
		public virtual RMethod R__0__CKb
		{
			get
			{
				if(r_R__0__CKb == null)
				{
					r_R__0__CKb = new(this, "#CKb", 0);
					r_R__0__CKb.SetBelong(this.instance);
				}
				return r_R__0__CKb;
			}
		}

		/// <summary>
		/// Void #lYb(Boolean)
		/// </summary>
		protected RMethod r_R__0__lYb_Boolean;
		public virtual RMethod R__0__lYb_Boolean
		{
			get
			{
				if(r_R__0__lYb_Boolean == null)
				{
					r_R__0__lYb_Boolean = new(this, "#lYb", 0, typeof(System.Boolean));
					r_R__0__lYb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__lYb_Boolean;
			}
		}

		/// <summary>
		/// Boolean #rh()
		/// </summary>
		protected RMethod r_R__0__rh;
		public virtual RMethod R__0__rh
		{
			get
			{
				if(r_R__0__rh == null)
				{
					r_R__0__rh = new(this, "#rh", 0);
					r_R__0__rh.SetBelong(this.instance);
				}
				return r_R__0__rh;
			}
		}

		/// <summary>
		/// Void #DKb()
		/// </summary>
		protected RMethod r_R__0__DKb;
		public virtual RMethod R__0__DKb
		{
			get
			{
				if(r_R__0__DKb == null)
				{
					r_R__0__DKb = new(this, "#DKb", 0);
					r_R__0__DKb.SetBelong(this.instance);
				}
				return r_R__0__DKb;
			}
		}

		/// <summary>
		/// Void #kld()
		/// </summary>
		protected RMethod r_R__0__kld;
		public virtual RMethod R__0__kld
		{
			get
			{
				if(r_R__0__kld == null)
				{
					r_R__0__kld = new(this, "#kld", 0);
					r_R__0__kld.SetBelong(this.instance);
				}
				return r_R__0__kld;
			}
		}

		/// <summary>
		/// #oU.#05 GetWindow()
		/// </summary>
		protected RMethod r_RGetWindow;
		public virtual RMethod RGetWindow
		{
			get
			{
				if(r_RGetWindow == null)
				{
					r_RGetWindow = new(this, "GetWindow", 0);
					r_RGetWindow.SetBelong(this.instance);
				}
				return r_RGetWindow;
			}
		}

		/// <summary>
		/// Void #EKb(WINDOW_HOTKEY)
		/// </summary>
		protected RMethod r_R__0__EKb_WINDOW_HOTKEY;
		public virtual RMethod R__0__EKb_WINDOW_HOTKEY
		{
			get
			{
				if(r_R__0__EKb_WINDOW_HOTKEY == null)
				{
					r_R__0__EKb_WINDOW_HOTKEY = new(this, "#EKb", 0,  ReleactionUtils.GetType("WINDOW_HOTKEY"));
					r_R__0__EKb_WINDOW_HOTKEY.SetBelong(this.instance);
				}
				return r_R__0__EKb_WINDOW_HOTKEY;
			}
		}

		/// <summary>
		/// Void #FKb()
		/// </summary>
		protected RMethod r_R__0__FKb;
		public virtual RMethod R__0__FKb
		{
			get
			{
				if(r_R__0__FKb == null)
				{
					r_R__0__FKb = new(this, "#FKb", 0);
					r_R__0__FKb.SetBelong(this.instance);
				}
				return r_R__0__FKb;
			}
		}

		/// <summary>
		/// Void InitStyle()
		/// </summary>
		protected RMethod r_RInitStyle;
		public virtual RMethod RInitStyle
		{
			get
			{
				if(r_RInitStyle == null)
				{
					r_RInitStyle = new(this, "InitStyle", 0);
					r_RInitStyle.SetBelong(this.instance);
				}
				return r_RInitStyle;
			}
		}

		/// <summary>
		/// Void #mg(Int32)
		/// </summary>
		protected RMethod r_R__0__mg_Int32;
		public virtual RMethod R__0__mg_Int32
		{
			get
			{
				if(r_R__0__mg_Int32 == null)
				{
					r_R__0__mg_Int32 = new(this, "#mg", 0, typeof(System.Int32));
					r_R__0__mg_Int32.SetBelong(this.instance);
				}
				return r_R__0__mg_Int32;
			}
		}

		/// <summary>
		/// Void #PKb(#O2, Boolean)
		/// </summary>
		protected RMethod r_R__0__PKb___0__O2_Boolean;
		public virtual RMethod R__0__PKb___0__O2_Boolean
		{
			get
			{
				if(r_R__0__PKb___0__O2_Boolean == null)
				{
					r_R__0__PKb___0__O2_Boolean = new(this, "#PKb", 0,  ReleactionUtils.GetType("#oU.#K2+#O2"), typeof(System.Boolean));
					r_R__0__PKb___0__O2_Boolean.SetBelong(this.instance);
				}
				return r_R__0__PKb___0__O2_Boolean;
			}
		}

		/// <summary>
		/// Void #Nad(Boolean)
		/// </summary>
		protected RMethod r_R__0__Nad_Boolean;
		public virtual RMethod R__0__Nad_Boolean
		{
			get
			{
				if(r_R__0__Nad_Boolean == null)
				{
					r_R__0__Nad_Boolean = new(this, "#Nad", 0, typeof(System.Boolean));
					r_R__0__Nad_Boolean.SetBelong(this.instance);
				}
				return r_R__0__Nad_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle #QKb()
		/// </summary>
		protected RMethod r_R__0__QKb;
		public virtual RMethod R__0__QKb
		{
			get
			{
				if(r_R__0__QKb == null)
				{
					r_R__0__QKb = new(this, "#QKb", 0);
					r_R__0__QKb.SetBelong(this.instance);
				}
				return r_R__0__QKb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle #RKb(System.String)
		/// </summary>
		protected RMethod r_R__0__RKb_String;
		public virtual RMethod R__0__RKb_String
		{
			get
			{
				if(r_R__0__RKb_String == null)
				{
					r_R__0__RKb_String = new(this, "#RKb", 0, typeof(System.String));
					r_R__0__RKb_String.SetBelong(this.instance);
				}
				return r_R__0__RKb_String;
			}
		}

		/// <summary>
		/// Void OnAnimationStart(System.Object)
		/// </summary>
		protected RMethod r_ROnAnimationStart_Object;
		public virtual RMethod ROnAnimationStart_Object
		{
			get
			{
				if(r_ROnAnimationStart_Object == null)
				{
					r_ROnAnimationStart_Object = new(this, "OnAnimationStart", 0, typeof(System.Object));
					r_ROnAnimationStart_Object.SetBelong(this.instance);
				}
				return r_ROnAnimationStart_Object;
			}
		}

		/// <summary>
		/// Void OnAnimationUpdate(System.Object)
		/// </summary>
		protected RMethod r_ROnAnimationUpdate_Object;
		public virtual RMethod ROnAnimationUpdate_Object
		{
			get
			{
				if(r_ROnAnimationUpdate_Object == null)
				{
					r_ROnAnimationUpdate_Object = new(this, "OnAnimationUpdate", 0, typeof(System.Object));
					r_ROnAnimationUpdate_Object.SetBelong(this.instance);
				}
				return r_ROnAnimationUpdate_Object;
			}
		}

		/// <summary>
		/// Void OnAnimationComplete(System.Object)
		/// </summary>
		protected RMethod r_ROnAnimationComplete_Object;
		public virtual RMethod ROnAnimationComplete_Object
		{
			get
			{
				if(r_ROnAnimationComplete_Object == null)
				{
					r_ROnAnimationComplete_Object = new(this, "OnAnimationComplete", 0, typeof(System.Object));
					r_ROnAnimationComplete_Object.SetBelong(this.instance);
				}
				return r_ROnAnimationComplete_Object;
			}
		}

		/// <summary>
		/// Void _Update()
		/// </summary>
		protected RMethod r_R_Update;
		public virtual RMethod R_Update
		{
			get
			{
				if(r_R_Update == null)
				{
					r_R_Update = new(this, "_Update", 0);
					r_R_Update.SetBelong(this.instance);
				}
				return r_R_Update;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine #TKb(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_R__0__TKb_IEnumerator;
		public virtual RMethod R__0__TKb_IEnumerator
		{
			get
			{
				if(r_R__0__TKb_IEnumerator == null)
				{
					r_R__0__TKb_IEnumerator = new(this, "#TKb", 0, typeof(System.Collections.IEnumerator));
					r_R__0__TKb_IEnumerator.SetBelong(this.instance);
				}
				return r_R__0__TKb_IEnumerator;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine #TKb(System.String, System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_R__0__TKb_String_IEnumerator;
		public virtual RMethod R__0__TKb_String_IEnumerator
		{
			get
			{
				if(r_R__0__TKb_String_IEnumerator == null)
				{
					r_R__0__TKb_String_IEnumerator = new(this, "#TKb", 0, typeof(System.String), typeof(System.Collections.IEnumerator));
					r_R__0__TKb_String_IEnumerator.SetBelong(this.instance);
				}
				return r_R__0__TKb_String_IEnumerator;
			}
		}

		/// <summary>
		/// Void #UKb(System.String)
		/// </summary>
		protected RMethod r_R__0__UKb_String;
		public virtual RMethod R__0__UKb_String
		{
			get
			{
				if(r_R__0__UKb_String == null)
				{
					r_R__0__UKb_String = new(this, "#UKb", 0, typeof(System.String));
					r_R__0__UKb_String.SetBelong(this.instance);
				}
				return r_R__0__UKb_String;
			}
		}

		/// <summary>
		/// Void Destroy(UnityEngine.Object)
		/// </summary>
		protected RMethod r_RDestroy_Object;
		public virtual RMethod RDestroy_Object
		{
			get
			{
				if(r_RDestroy_Object == null)
				{
					r_RDestroy_Object = new(this, "Destroy", 0, typeof(UnityEngine.Object));
					r_RDestroy_Object.SetBelong(this.instance);
				}
				return r_RDestroy_Object;
			}
		}

		/// <summary>
		/// Void #VKb(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__VKb_GameObject;
		public virtual RMethod R__0__VKb_GameObject
		{
			get
			{
				if(r_R__0__VKb_GameObject == null)
				{
					r_R__0__VKb_GameObject = new(this, "#VKb", 0, typeof(UnityEngine.GameObject));
					r_R__0__VKb_GameObject.SetBelong(this.instance);
				}
				return r_R__0__VKb_GameObject;
			}
		}

		/// <summary>
		/// Void #XKb()
		/// </summary>
		protected RMethod r_R__0__XKb;
		public virtual RMethod R__0__XKb
		{
			get
			{
				if(r_R__0__XKb == null)
				{
					r_R__0__XKb = new(this, "#XKb", 0);
					r_R__0__XKb.SetBelong(this.instance);
				}
				return r_R__0__XKb;
			}
		}

		/// <summary>
		/// Void Destroy()
		/// </summary>
		protected RMethod r_RDestroy;
		public virtual RMethod RDestroy
		{
			get
			{
				if(r_RDestroy == null)
				{
					r_RDestroy = new(this, "Destroy", 0);
					r_RDestroy.SetBelong(this.instance);
				}
				return r_RDestroy;
			}
		}

		/// <summary>
		/// Void #ZKb(Boolean, Boolean)
		/// </summary>
		protected RMethod r_R__0__ZKb_Boolean_Boolean;
		public virtual RMethod R__0__ZKb_Boolean_Boolean
		{
			get
			{
				if(r_R__0__ZKb_Boolean_Boolean == null)
				{
					r_R__0__ZKb_Boolean_Boolean = new(this, "#ZKb", 0, typeof(System.Boolean), typeof(System.Boolean));
					r_R__0__ZKb_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_R__0__ZKb_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void #1Kb()
		/// </summary>
		protected RMethod r_R__0__1Kb;
		public virtual RMethod R__0__1Kb
		{
			get
			{
				if(r_R__0__1Kb == null)
				{
					r_R__0__1Kb = new(this, "#1Kb", 0);
					r_R__0__1Kb.SetBelong(this.instance);
				}
				return r_R__0__1Kb;
			}
		}

		/// <summary>
		/// Void #lBn(System.String)
		/// </summary>
		protected RMethod r_R__0__lBn_String;
		public virtual RMethod R__0__lBn_String
		{
			get
			{
				if(r_R__0__lBn_String == null)
				{
					r_R__0__lBn_String = new(this, "#lBn", 0, typeof(System.String));
					r_R__0__lBn_String.SetBelong(this.instance);
				}
				return r_R__0__lBn_String;
			}
		}

		/// <summary>
		/// Void #2Kb()
		/// </summary>
		protected RMethod r_R__0__2Kb;
		public virtual RMethod R__0__2Kb
		{
			get
			{
				if(r_R__0__2Kb == null)
				{
					r_R__0__2Kb = new(this, "#2Kb", 0);
					r_R__0__2Kb.SetBelong(this.instance);
				}
				return r_R__0__2Kb;
			}
		}

		/// <summary>
		/// Void #3Kb()
		/// </summary>
		protected RMethod r_R__0__3Kb;
		public virtual RMethod R__0__3Kb
		{
			get
			{
				if(r_R__0__3Kb == null)
				{
					r_R__0__3Kb = new(this, "#3Kb", 0);
					r_R__0__3Kb.SetBelong(this.instance);
				}
				return r_R__0__3Kb;
			}
		}

		/// <summary>
		/// Void #5Kb()
		/// </summary>
		protected RMethod r_R__0__5Kb;
		public virtual RMethod R__0__5Kb
		{
			get
			{
				if(r_R__0__5Kb == null)
				{
					r_R__0__5Kb = new(this, "#5Kb", 0);
					r_R__0__5Kb.SetBelong(this.instance);
				}
				return r_R__0__5Kb;
			}
		}

		/// <summary>
		/// Boolean #qh()
		/// </summary>
		protected RMethod r_R__0__qh;
		public virtual RMethod R__0__qh
		{
			get
			{
				if(r_R__0__qh == null)
				{
					r_R__0__qh = new(this, "#qh", 0);
					r_R__0__qh.SetBelong(this.instance);
				}
				return r_R__0__qh;
			}
		}

		/// <summary>
		/// Void PreLoadDefineString()
		/// </summary>
		protected RMethod r_RPreLoadDefineString;
		public virtual RMethod RPreLoadDefineString
		{
			get
			{
				if(r_RPreLoadDefineString == null)
				{
					r_RPreLoadDefineString = new(this, "PreLoadDefineString", 0);
					r_RPreLoadDefineString.SetBelong(this.instance);
				}
				return r_RPreLoadDefineString;
			}
		}

		/// <summary>
		/// Void #6Kb()
		/// </summary>
		protected RMethod r_R__0__6Kb;
		public virtual RMethod R__0__6Kb
		{
			get
			{
				if(r_R__0__6Kb == null)
				{
					r_R__0__6Kb = new(this, "#6Kb", 0);
					r_R__0__6Kb.SetBelong(this.instance);
				}
				return r_R__0__6Kb;
			}
		}

		/// <summary>
		/// Void #7Kb()
		/// </summary>
		protected RMethod r_R__0__7Kb;
		public virtual RMethod R__0__7Kb
		{
			get
			{
				if(r_R__0__7Kb == null)
				{
					r_R__0__7Kb = new(this, "#7Kb", 0);
					r_R__0__7Kb.SetBelong(this.instance);
				}
				return r_R__0__7Kb;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #bLb(MyGUI.ElementBase, Single)
		/// </summary>
		protected RMethod r_R__0__bLb_ElementBase_Single;
		public virtual RMethod R__0__bLb_ElementBase_Single
		{
			get
			{
				if(r_R__0__bLb_ElementBase_Single == null)
				{
					r_R__0__bLb_ElementBase_Single = new(this, "#bLb", 0, typeof(MyGUI.ElementBase), typeof(System.Single));
					r_R__0__bLb_ElementBase_Single.SetBelong(this.instance);
				}
				return r_R__0__bLb_ElementBase_Single;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #cLb(MyGUI.ElementBase, Single)
		/// </summary>
		protected RMethod r_R__0__cLb_ElementBase_Single;
		public virtual RMethod R__0__cLb_ElementBase_Single
		{
			get
			{
				if(r_R__0__cLb_ElementBase_Single == null)
				{
					r_R__0__cLb_ElementBase_Single = new(this, "#cLb", 0, typeof(MyGUI.ElementBase), typeof(System.Single));
					r_R__0__cLb_ElementBase_Single.SetBelong(this.instance);
				}
				return r_R__0__cLb_ElementBase_Single;
			}
		}

		/// <summary>
		/// Void #dLb(#oU.#uU, Int32, Int32, Int32, #JNb)
		/// </summary>
		protected RMethod r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb;
		public virtual RMethod R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb
		{
			get
			{
				if(r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb == null)
				{
					r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb = new(this, "#dLb", 0,  ReleactionUtils.GetType("#oU.#uU"), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32),  ReleactionUtils.GetType("MyGUIWindow+#JNb"));
					r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb.SetBelong(this.instance);
				}
				return r_R__0__dLb___0__uU_Int32_Int32_Int32___0__JNb;
			}
		}

		/// <summary>
		/// Void #eLb(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__eLb_Object___0__7X;
		public virtual RMethod R__0__eLb_Object___0__7X
		{
			get
			{
				if(r_R__0__eLb_Object___0__7X == null)
				{
					r_R__0__eLb_Object___0__7X = new(this, "#eLb", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__eLb_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__eLb_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #fLb(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__fLb_Object___0__7X;
		public virtual RMethod R__0__fLb_Object___0__7X
		{
			get
			{
				if(r_R__0__fLb_Object___0__7X == null)
				{
					r_R__0__fLb_Object___0__7X = new(this, "#fLb", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__fLb_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__fLb_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #gLb(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__gLb_Object___0__7X;
		public virtual RMethod R__0__gLb_Object___0__7X
		{
			get
			{
				if(r_R__0__gLb_Object___0__7X == null)
				{
					r_R__0__gLb_Object___0__7X = new(this, "#gLb", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__gLb_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__gLb_Object___0__7X;
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


        public RMyGUIFinalEquipWnd() : base("MyGUIFinalEquipWnd")
        {
        }

        public RMyGUIFinalEquipWnd(System.Object instance) : base("MyGUIFinalEquipWnd")
		{
            SetInstance(instance);
		}

        public RMyGUIFinalEquipWnd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMyGUIFinalEquipWnd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__6c()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__6c.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__sb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__sb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean __0__OXd(EquipTab  @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab};
            var ___result = R__0__OXd_EquipTab.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__Abb(System.String  @paramstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramstr};
            var ___result = R__0__Abb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__Urd(EquipTab  @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab};
            var ___result = R__0__Urd_EquipTab.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }







        public virtual void __0__lVe(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__lVe_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__XTc(System.Int32  @type, System.Int32  @result, GameDefineType.ID  @equipid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @result, @equipid};
            var ___result = R__0__XTc_Int32_Int32_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__1gc(EquipTab  @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab};
            var ___result = R__0__1gc_EquipTab.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Xd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Xd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__wAd(EquipTab  @tab)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tab};
            var ___result = R__0__wAd_EquipTab.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void __0__Xrd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Xrd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__YTj()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__YTj.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Xgc(UnityEngine.GameObject  @ojt, MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ojt, @eb};
            var ___result = R__0__Xgc_GameObject_ElementBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__xAd(MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb};
            var ___result = R__0__xAd_ElementBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__yAd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yAd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadUIeffect(System.String  @name, MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @eb};
            var ___result = ROnLoadUIeffect_String_ElementBase.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__VOd(System.Boolean  @bsuccess)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bsuccess};
            var ___result = R__0__VOd_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Yrd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Yrd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Pz()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Pz.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__0rd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__0rd.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__PXd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__PXd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object __0__Rz()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Rz.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual GameDefineType.ID __0__DF()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__DF.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual void __0__3rd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__3rd.Invoke(___genericsType, ___parameters);

            
        }










        public virtual System.Object __0__csd(System.Boolean  @bbody, System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bbody, @idx};
            var ___result = R__0__csd_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__dsd(MyGUI.ElementBase  @hleb, MyGUI.ElementBase  @group)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hleb, @group};
            var ___result = R__0__dsd_ElementBase_ElementBase.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__esd(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__esd_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__gsd(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__gsd_Int32.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Object __0__ksd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ksd.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void __0__msd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__msd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__nsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__nsd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__osd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__osd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__psd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__psd.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__0z()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__0z.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemovePetModel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRemovePetModel.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void ShowPetModel()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RShowPetModel.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__3z()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__3z.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnPutWeapon(UnityEngine.GameObject  @weapon, System.String  @placename)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@weapon, @placename};
            var ___result = ROnPutWeapon_GameObject_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnGetWeaponRes(System.Object  @sender, UnityEngine.GameObject  @weapon0, UnityEngine.GameObject  @weapon1, System.Object  @tmpObj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @weapon0, @weapon1, @tmpObj};
            var ___result = ROnGetWeaponRes_Object_GameObject_GameObject_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StartPlayAnimation(UnityEngine.GameObject  @modRoot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@modRoot};
            var ___result = RStartPlayAnimation_GameObject.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Object __0__RXd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__RXd.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual System.Object __0__TXd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__TXd.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__CAd(System.Int32  @lv)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lv};
            var ___result = R__0__CAd_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__UXd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__UXd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__DAd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__DAd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__FAd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__FAd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__GAd(System.Int32  @viplv)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@viplv};
            var ___result = R__0__GAd_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__HAd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__HAd.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void __0__IAd(System.Boolean  @bvisible, UnityEngine.Vector2  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bvisible, @pos};
            var ___result = R__0__IAd_Boolean_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__JAd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__JAd.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual GameDefineType.ID __0__KAd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__KAd.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual void __0__qsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__qsd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Tag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Tag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Uag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Uag.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__MAd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__MAd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__rsd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Hwd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Hwd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ssd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ssd.Invoke(___genericsType, ___parameters);

            
        }








        public virtual void __0__bl(System.Boolean  @UseGold)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@UseGold};
            var ___result = R__0__bl_Boolean.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__wsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wsd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__zsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__zsd.Invoke(___genericsType, ___parameters);

            
        }












        public virtual void __0__3Tj()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__3Tj.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__7Tj()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__7Tj.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__8Tj()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__8Tj.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__aUj(System.Object  @data, System.Boolean  @isCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @isCheck};
            var ___result = R__0__aUj_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__dUj()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__dUj.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__WOd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__WOd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__XOd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__XOd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__YOd(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__YOd_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__ZOd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ZOd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__fUj(System.Boolean  @bshow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bshow};
            var ___result = R__0__fUj_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Asd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Asd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Bsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Bsd.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void __0__Nwd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Nwd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Owd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Owd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Pwd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Pwd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Qwd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Qwd.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Rwd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Rwd.Invoke(___genericsType, ___parameters);

            
        }







        public virtual void __0__4Xd(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__4Xd_Object.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Csd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Csd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Uwd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Uwd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Dsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Dsd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__8Qe(System.Object  @data, System.Boolean  @isCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @isCheck};
            var ___result = R__0__8Qe_Object_Boolean.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Esd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Esd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__bRe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__bRe.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__dRe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__dRe.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Juk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Juk.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Kuk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Kuk.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void __0__Hdp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Hdp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Idp(MagicWeaponTypePag  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = R__0__Idp_MagicWeaponTypePag.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Kdp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Kdp.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Collections.IEnumerator __0__Odp(MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb};
            var ___result = R__0__Odp_ElementBase.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }







        public virtual void __0__Udp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Udp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Vdp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Vdp.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object __0__Xdp(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = R__0__Xdp_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }




        public virtual void __0__0dp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__0dp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__1dp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__1dp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__2dp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__2dp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__3dp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__3dp.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__4dp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__4dp.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 __0__6dp()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__6dp.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 __0__7dp(System.Int32  @currLv, System.Int32  @exp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@currLv, @exp};
            var ___result = R__0__7dp_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void __0__jVl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__jVl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__kVl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__kVl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__lVl(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = R__0__lVl_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__mVl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__mVl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__nVl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__nVl.Invoke(___genericsType, ___parameters);

            
        }












        public virtual void __0__xVl(GameDefineType.ID  @equipid, System.Int32  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@equipid, @result};
            var ___result = R__0__xVl_ID_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Fsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Fsd.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__Gsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Gsd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Hsd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Hsd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Isd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Isd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__8Xd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__8Xd.Invoke(___genericsType, ___parameters);

            
        }










        public virtual void __0__eYd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__eYd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__fYd(System.String  @mainstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mainstr};
            var ___result = R__0__fYd_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__gYd(System.String  @substr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@substr};
            var ___result = R__0__gYd_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__hYd(System.String  @miantype, System.String  @subtype)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@miantype, @subtype};
            var ___result = R__0__hYd_String_String.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Object __0__kYd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__kYd.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 __0__8Hf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__8Hf.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void __0__lYd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__lYd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__iYd(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__iYd_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__9Hf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__9Hf.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Object __0__mYd(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__mYd_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__Vag()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Vag.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__nYd(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__nYd_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__nYd(GameDefineType.ID  @combinitemid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combinitemid};
            var ___result = R__0__nYd_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }





        public virtual System.Int32 __0__Bzi()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Bzi.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }





        public virtual void __0__pAd(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__pAd_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__qYd(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__qYd_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__zah(System.String  @tips)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tips};
            var ___result = R__0__zah_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__aIf(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = R__0__aIf_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__bIf(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__bIf_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__5Yg(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__5Yg_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rYd(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = R__0__rYd_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sYd(System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@count};
            var ___result = R__0__sYd_Int32.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__nAd(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__nAd_Object_Object.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Collections.IEnumerator __0__uYd(MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb};
            var ___result = R__0__uYd_ElementBase.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__vYd(MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb};
            var ___result = R__0__vYd_ElementBase.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__shl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__shl.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void __0__dKb(System.Single  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = R__0__dKb_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__eKb(System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@time};
            var ___result = R__0__eKb_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__fKb(UnityEngine.Vector2  @Pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Pos};
            var ___result = R__0__fKb_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__gKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__gKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__EF()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__EF.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Resize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__hKb(UnityEngine.Vector2  @oldSize, UnityEngine.Vector2  @newSize)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldSize, @newSize};
            var ___result = R__0__hKb_Vector2_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__u1b(UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = R__0__u1b_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__iKb(UnityEngine.Vector2  @resolution)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resolution};
            var ___result = R__0__iKb_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__jKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__jKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Initialize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitialize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__pq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__pq.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual MyGUI.ElementBase __0__kKb(System.String  @elemName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elemName};
            var ___result = R__0__kKb_String.Invoke(___genericsType, ___parameters);

            return (MyGUI.ElementBase)___result;
        }


        public virtual __0__bk __0__kKb<__0__bk>(System.String  @name) where __0__bk : MyGUI.ElementBase
        {

            var ___genericsType = new Type[] {typeof(__0__bk)};
            var ___parameters = new object[]{@name};
            var ___result = R__0__kKb_G__0__bk_String.Invoke(___genericsType, ___parameters);

            return (__0__bk)___result;
        }


        public virtual void __0__lKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__lKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Ibb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Ibb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mKb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__mKb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__nKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__nKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Mr(System.Boolean  @isVisible)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isVisible};
            var ___result = R__0__Mr_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__rKb(System.Boolean  @isOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isOpen};
            var ___result = R__0__rKb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tKb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__tKb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__uKb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__uKb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__bN()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__bN.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__wKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wKb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__xKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__xKb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__yKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__yKb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__zKb(UnityEngine.Vector2  @point)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@point};
            var ___result = R__0__zKb_Vector2.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector2 __0__uo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__uo.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void __0__gw(UnityEngine.Vector2  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = R__0__gw_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetWindowLocation()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWindowLocation.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void __0__AKb(System.String  @elementName, UIeffect  @effect)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elementName, @effect};
            var ___result = R__0__AKb_String_UIeffect.Invoke(___genericsType, ___parameters);

            
        }


        public virtual __0__bk __0__Oh<__0__bk>() where __0__bk : MyGUIWindow
        {

            var ___genericsType = new Type[] {typeof(__0__bk)};
            var ___parameters = new object[]{};
            var ___result = R__0__Oh_G__0__bk.Invoke(___genericsType, ___parameters);

            return (__0__bk)___result;
        }


        public virtual System.Object __0__BKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__BKb.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__CKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__CKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__lYb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__lYb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__rh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__rh.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__DKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__DKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__kld()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__kld.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetWindow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWindow.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void __0__FKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__FKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitStyle()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitStyle.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mg(System.Int32  @windowID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowID};
            var ___result = R__0__mg_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Nad(System.Boolean  @bExcept)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bExcept};
            var ___result = R__0__Nad_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GUIStyle __0__QKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__QKb.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual UnityEngine.GUIStyle __0__RKb(System.String  @styleName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleName};
            var ___result = R__0__RKb_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual void OnAnimationStart(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = ROnAnimationStart_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAnimationUpdate(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = ROnAnimationUpdate_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnAnimationComplete(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = ROnAnimationComplete_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void _Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_Update.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Coroutine __0__TKb(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = R__0__TKb_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine __0__TKb(System.String  @methodName, System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @routine};
            var ___result = R__0__TKb_String_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual void __0__UKb(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = R__0__UKb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Destroy(UnityEngine.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = RDestroy_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__VKb(UnityEngine.GameObject  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = R__0__VKb_GameObject.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__XKb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__XKb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Destroy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDestroy.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ZKb(System.Boolean  @bOpen, System.Boolean  @bRelation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bOpen, @bRelation};
            var ___result = R__0__ZKb_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__1Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__1Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__lBn(System.String  @paramstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramstr};
            var ___result = R__0__lBn_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__2Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__2Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__3Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__3Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__5Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__5Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__qh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__qh.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void PreLoadDefineString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPreLoadDefineString.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__6Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__6Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__7Kb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__7Kb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__bLb(MyGUI.ElementBase  @elem, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem, @time};
            var ___result = R__0__bLb_ElementBase_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator __0__cLb(MyGUI.ElementBase  @elem, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem, @time};
            var ___result = R__0__cLb_ElementBase_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
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
