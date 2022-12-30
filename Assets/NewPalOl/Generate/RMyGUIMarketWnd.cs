using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MyGUIMarketWnd
	/// </summary>
    public partial class RMyGUIMarketWnd : RMember //
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
					r___0__a = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Int32[] #b
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
		/// UnityEngine.Vector2[] #c
		/// </summary>
		protected RFieldArray<RUnityEngine.RVector2> r___0__c;
		public virtual RFieldArray<RUnityEngine.RVector2> R__0__c
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
		/// MyGUIMarketWnd+MarketPage #d
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
		/// System.Collections.Generic.Dictionary`2[MyGUIMarketWnd+MarketPage,#oU.#uU] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__uU> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__uU> R__0__e
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
		/// System.Collections.Generic.Dictionary`2[MyGUIMarketWnd+MarketPage,#oU.#5bb] #f
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__5bb> r___0__f;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__oU.R__0__5bb> R__0__f
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
		/// MyGUIMarketWnd+#Bpe #g
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
		/// System.Collections.Generic.Dictionary`2[MyGUIMarketWnd+#Bpe,MyGUI.ElementBase] #h
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RMyGUI.RElementBase> r___0__h;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RMyGUI.RElementBase> R__0__h
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
		/// System.Int32 #i
		/// </summary>
		protected RField r___0__i;
		public virtual RField R__0__i
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
		/// System.Int32 #j
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
		/// System.Int32 #k
		/// </summary>
		protected static RField r___0__k;
		public static RField R__0__k
		{
			get
			{
				if(r___0__k == null)
				{
					r___0__k = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#k");
					r___0__k.SetBelong(null);
				}
				return r___0__k;
			}
		}

		/// <summary>
		/// MyGUIMarketWnd+#Gpe[] #l
		/// </summary>
		protected RFieldArray<RMyGUIMarketWnd.R__0__Gpe> r___0__l;
		public virtual RFieldArray<RMyGUIMarketWnd.R__0__Gpe> R__0__l
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
		/// MyGUIMarketWnd+#Hpe #m
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
		/// #oU.#W4 #n
		/// </summary>
		protected R__0__oU.R__0__W4 r___0__n;
		public virtual R__0__oU.R__0__W4 R__0__n
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
		/// #oU.#W4 #o
		/// </summary>
		protected R__0__oU.R__0__W4 r___0__o;
		public virtual R__0__oU.R__0__W4 R__0__o
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
		/// System.Boolean #p
		/// </summary>
		protected RField r___0__p;
		public virtual RField R__0__p
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
		/// System.String #q
		/// </summary>
		protected static RField r___0__q;
		public static RField R__0__q
		{
			get
			{
				if(r___0__q == null)
				{
					r___0__q = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#q");
					r___0__q.SetBelong(null);
				}
				return r___0__q;
			}
		}

		/// <summary>
		/// System.String #r
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
		/// GameDefineType.ID #s
		/// </summary>
		protected RGameDefineType.RID r___0__s;
		public virtual RGameDefineType.RID R__0__s
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
		protected static RField r___0__t;
		public static RField R__0__t
		{
			get
			{
				if(r___0__t == null)
				{
					r___0__t = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#t");
					r___0__t.SetBelong(null);
				}
				return r___0__t;
			}
		}

		/// <summary>
		/// System.Int32 #u
		/// </summary>
		protected static RField r___0__u;
		public static RField R__0__u
		{
			get
			{
				if(r___0__u == null)
				{
					r___0__u = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#u");
					r___0__u.SetBelong(null);
				}
				return r___0__u;
			}
		}

		/// <summary>
		/// System.Int32 #v
		/// </summary>
		protected static RField r___0__v;
		public static RField R__0__v
		{
			get
			{
				if(r___0__v == null)
				{
					r___0__v = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#v");
					r___0__v.SetBelong(null);
				}
				return r___0__v;
			}
		}

		/// <summary>
		/// #oU.#5bb #w
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__w;
		public virtual R__0__oU.R__0__5bb R__0__w
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
		/// MyGUI.ElementBase #x
		/// </summary>
		protected RMyGUI.RElementBase r___0__x;
		public virtual RMyGUI.RElementBase R__0__x
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
		/// System.Int32 #y
		/// </summary>
		protected RField r___0__y;
		public virtual RField R__0__y
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
		protected RField r___0__z;
		public virtual RField R__0__z
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
		/// System.Int32 #A
		/// </summary>
		protected static RField r___0__A;
		public static RField R__0__A
		{
			get
			{
				if(r___0__A == null)
				{
					r___0__A = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#A");
					r___0__A.SetBelong(null);
				}
				return r___0__A;
			}
		}

		/// <summary>
		/// System.Int32[] #B
		/// </summary>
		protected RFieldArray<RField> r___0__B;
		public virtual RFieldArray<RField> R__0__B
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
		/// #oU.#W4 #C
		/// </summary>
		protected R__0__oU.R__0__W4 r___0__C;
		public virtual R__0__oU.R__0__W4 R__0__C
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
		/// #oU.#W4 #D
		/// </summary>
		protected R__0__oU.R__0__W4 r___0__D;
		public virtual R__0__oU.R__0__W4 R__0__D
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
		/// System.Collections.Generic.List`1[#u.#Ckb] #E
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> r___0__E;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Ckb> R__0__E
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
		/// #u.#Ckb #F
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__F;
		public virtual R__0__u.R__0__Ckb R__0__F
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
		/// System.Int32 #G
		/// </summary>
		protected static RField r___0__G;
		public static RField R__0__G
		{
			get
			{
				if(r___0__G == null)
				{
					r___0__G = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#G");
					r___0__G.SetBelong(null);
				}
				return r___0__G;
			}
		}

		/// <summary>
		/// System.Int32 #H
		/// </summary>
		protected RField r___0__H;
		public virtual RField R__0__H
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
		protected RField r___0__I;
		public virtual RField R__0__I
		{
			get
			{
				if(r___0__I == null)
				{
					r___0__I = new(this, "#I");
					r___0__I.SetBelong(this.instance);
				}
				return r___0__I;
			}
		}

		/// <summary>
		/// System.Int32 #J
		/// </summary>
		protected RField r___0__J;
		public virtual RField R__0__J
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
		/// System.Int32 #K
		/// </summary>
		protected static RField r___0__K;
		public static RField R__0__K
		{
			get
			{
				if(r___0__K == null)
				{
					r___0__K = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#K");
					r___0__K.SetBelong(null);
				}
				return r___0__K;
			}
		}

		/// <summary>
		/// System.Int32 #L
		/// </summary>
		protected RField r___0__L;
		public virtual RField R__0__L
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
		/// System.Int32 #M
		/// </summary>
		protected RField r___0__M;
		public virtual RField R__0__M
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
		/// MyGUIMarketWnd+#Kpe[] #N
		/// </summary>
		protected RFieldArray<RMyGUIMarketWnd.R__0__Kpe> r___0__N;
		public virtual RFieldArray<RMyGUIMarketWnd.R__0__Kpe> R__0__N
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
		/// System.Collections.Generic.List`1[#Pfb.#jre] #O
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__jre> r___0__O;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__Pfb.R__0__jre> R__0__O
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
		/// System.Int32 #P
		/// </summary>
		protected static RField r___0__P;
		public static RField R__0__P
		{
			get
			{
				if(r___0__P == null)
				{
					r___0__P = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#P");
					r___0__P.SetBelong(null);
				}
				return r___0__P;
			}
		}

		/// <summary>
		/// MyGUIMarketWnd+#kTf[] #Q
		/// </summary>
		protected RFieldArray<RMyGUIMarketWnd.R__0__kTf> r___0__Q;
		public virtual RFieldArray<RMyGUIMarketWnd.R__0__kTf> R__0__Q
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
		/// System.Int32 #R
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
		/// #u.#3mb+#jOb1 #S
		/// </summary>
		protected static R__0__u.R__0__3mb.R__0__jOb1 r___0__S;
		public static R__0__u.R__0__3mb.R__0__jOb1 R__0__S
		{
			get
			{
				if(r___0__S == null)
				{
					r___0__S = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#S");
					r___0__S.SetBelong(null);
				}
				return r___0__S;
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
		/// MarketPage NowMarketPage
		/// </summary>
		protected RProperty r_R__0__7oe;
		public virtual RProperty R__0__7oe
		{
			get
			{
				if(r_R__0__7oe == null)
				{
					r_R__0__7oe = new(this, "NowMarketPage", -1);
					r_R__0__7oe.SetBelong(this.instance);
				}
				return r_R__0__7oe;
			}
		}

		/// <summary>
		/// Int32 nowSellItemPrice
		/// </summary>
		protected RProperty r_R__0__Euf;
		public virtual RProperty R__0__Euf
		{
			get
			{
				if(r_R__0__Euf == null)
				{
					r_R__0__Euf = new(this, "nowSellItemPrice", -1);
					r_R__0__Euf.SetBelong(this.instance);
				}
				return r_R__0__Euf;
			}
		}

		/// <summary>
		/// Int32 nowSellItemCount
		/// </summary>
		protected RProperty r_R__0__Guf;
		public virtual RProperty R__0__Guf
		{
			get
			{
				if(r_R__0__Guf == null)
				{
					r_R__0__Guf = new(this, "nowSellItemCount", -1);
					r_R__0__Guf.SetBelong(this.instance);
				}
				return r_R__0__Guf;
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
		/// Void #Auf(MarketPage)
		/// </summary>
		protected RMethod r_R__0__Auf_MarketPage;
		public virtual RMethod R__0__Auf_MarketPage
		{
			get
			{
				if(r_R__0__Auf_MarketPage == null)
				{
					r_R__0__Auf_MarketPage = new(this, "#Auf", 0,  ReleactionUtils.GetType("MyGUIMarketWnd+MarketPage"));
					r_R__0__Auf_MarketPage.SetBelong(this.instance);
				}
				return r_R__0__Auf_MarketPage;
			}
		}

		/// <summary>
		/// Void #sZg(#Bpe)
		/// </summary>
		protected RMethod r_R__0__sZg___0__Bpe;
		public virtual RMethod R__0__sZg___0__Bpe
		{
			get
			{
				if(r_R__0__sZg___0__Bpe == null)
				{
					r_R__0__sZg___0__Bpe = new(this, "#sZg", 0,  ReleactionUtils.GetType("MyGUIMarketWnd+#Bpe"));
					r_R__0__sZg___0__Bpe.SetBelong(this.instance);
				}
				return r_R__0__sZg___0__Bpe;
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
		/// Void #u4f(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__u4f_ID;
		public virtual RMethod R__0__u4f_ID
		{
			get
			{
				if(r_R__0__u4f_ID == null)
				{
					r_R__0__u4f_ID = new(this, "#u4f", 0, typeof(GameDefineType.ID));
					r_R__0__u4f_ID.SetBelong(this.instance);
				}
				return r_R__0__u4f_ID;
			}
		}

		/// <summary>
		/// Void #v4f(System.String)
		/// </summary>
		protected RMethod r_R__0__v4f_String;
		public virtual RMethod R__0__v4f_String
		{
			get
			{
				if(r_R__0__v4f_String == null)
				{
					r_R__0__v4f_String = new(this, "#v4f", 0, typeof(System.String));
					r_R__0__v4f_String.SetBelong(this.instance);
				}
				return r_R__0__v4f_String;
			}
		}

		/// <summary>
		/// Void #Ol(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ol_Object___0__7X;
		public virtual RMethod R__0__Ol_Object___0__7X
		{
			get
			{
				if(r_R__0__Ol_Object___0__7X == null)
				{
					r_R__0__Ol_Object___0__7X = new(this, "#Ol", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ol_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ol_Object___0__7X;
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
		/// Void #9oe(GameDefineType.ID, #Pfb.#ADb)
		/// </summary>
		protected RMethod r_R__0__9oe_ID___0__ADb;
		public virtual RMethod R__0__9oe_ID___0__ADb
		{
			get
			{
				if(r_R__0__9oe_ID___0__ADb == null)
				{
					r_R__0__9oe_ID___0__ADb = new(this, "#9oe", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#Pfb.#ADb"));
					r_R__0__9oe_ID___0__ADb.SetBelong(this.instance);
				}
				return r_R__0__9oe_ID___0__ADb;
			}
		}

		/// <summary>
		/// Void #oN(GameDefineType.ID, #Pfb.#zDb)
		/// </summary>
		protected RMethod r_R__0__oN_ID___0__zDb;
		public virtual RMethod R__0__oN_ID___0__zDb
		{
			get
			{
				if(r_R__0__oN_ID___0__zDb == null)
				{
					r_R__0__oN_ID___0__zDb = new(this, "#oN", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#Pfb.#zDb"));
					r_R__0__oN_ID___0__zDb.SetBelong(this.instance);
				}
				return r_R__0__oN_ID___0__zDb;
			}
		}

		/// <summary>
		/// Void #Db(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Db_Object___0__7X;
		public virtual RMethod R__0__Db_Object___0__7X
		{
			get
			{
				if(r_R__0__Db_Object___0__7X == null)
				{
					r_R__0__Db_Object___0__7X = new(this, "#Db", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Db_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Db_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #ape()
		/// </summary>
		protected RMethod r_R__0__ape;
		public virtual RMethod R__0__ape
		{
			get
			{
				if(r_R__0__ape == null)
				{
					r_R__0__ape = new(this, "#ape", 0);
					r_R__0__ape.SetBelong(this.instance);
				}
				return r_R__0__ape;
			}
		}

		/// <summary>
		/// Void #B0d()
		/// </summary>
		protected RMethod r_R__0__B0d;
		public virtual RMethod R__0__B0d
		{
			get
			{
				if(r_R__0__B0d == null)
				{
					r_R__0__B0d = new(this, "#B0d", 0);
					r_R__0__B0d.SetBelong(this.instance);
				}
				return r_R__0__B0d;
			}
		}

		/// <summary>
		/// Void #WEe()
		/// </summary>
		protected RMethod r_R__0__WEe;
		public virtual RMethod R__0__WEe
		{
			get
			{
				if(r_R__0__WEe == null)
				{
					r_R__0__WEe = new(this, "#WEe", 0);
					r_R__0__WEe.SetBelong(this.instance);
				}
				return r_R__0__WEe;
			}
		}

		/// <summary>
		/// Void #bpe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__bpe_Object___0__7X;
		public virtual RMethod R__0__bpe_Object___0__7X
		{
			get
			{
				if(r_R__0__bpe_Object___0__7X == null)
				{
					r_R__0__bpe_Object___0__7X = new(this, "#bpe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__bpe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__bpe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #cpe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__cpe_Object___0__7X;
		public virtual RMethod R__0__cpe_Object___0__7X
		{
			get
			{
				if(r_R__0__cpe_Object___0__7X == null)
				{
					r_R__0__cpe_Object___0__7X = new(this, "#cpe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__cpe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__cpe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Ftd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Ftd_Object___0__7X;
		public virtual RMethod R__0__Ftd_Object___0__7X
		{
			get
			{
				if(r_R__0__Ftd_Object___0__7X == null)
				{
					r_R__0__Ftd_Object___0__7X = new(this, "#Ftd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Ftd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Ftd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Gtd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Gtd_Object___0__7X;
		public virtual RMethod R__0__Gtd_Object___0__7X
		{
			get
			{
				if(r_R__0__Gtd_Object___0__7X == null)
				{
					r_R__0__Gtd_Object___0__7X = new(this, "#Gtd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Gtd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Gtd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #dpe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__dpe_Object___0__7X;
		public virtual RMethod R__0__dpe_Object___0__7X
		{
			get
			{
				if(r_R__0__dpe_Object___0__7X == null)
				{
					r_R__0__dpe_Object___0__7X = new(this, "#dpe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__dpe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__dpe_Object___0__7X;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #epe(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__epe_ElementBase;
		public virtual RMethod R__0__epe_ElementBase
		{
			get
			{
				if(r_R__0__epe_ElementBase == null)
				{
					r_R__0__epe_ElementBase = new(this, "#epe", 0, typeof(MyGUI.ElementBase));
					r_R__0__epe_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__epe_ElementBase;
			}
		}

		/// <summary>
		/// Void #fpe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__fpe_Object___0__7X;
		public virtual RMethod R__0__fpe_Object___0__7X
		{
			get
			{
				if(r_R__0__fpe_Object___0__7X == null)
				{
					r_R__0__fpe_Object___0__7X = new(this, "#fpe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__fpe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__fpe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #gpe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__gpe_Object___0__7X;
		public virtual RMethod R__0__gpe_Object___0__7X
		{
			get
			{
				if(r_R__0__gpe_Object___0__7X == null)
				{
					r_R__0__gpe_Object___0__7X = new(this, "#gpe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__gpe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__gpe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #hpe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__hpe_Object___0__7X;
		public virtual RMethod R__0__hpe_Object___0__7X
		{
			get
			{
				if(r_R__0__hpe_Object___0__7X == null)
				{
					r_R__0__hpe_Object___0__7X = new(this, "#hpe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__hpe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__hpe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #50d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__50d_Object___0__7X;
		public virtual RMethod R__0__50d_Object___0__7X
		{
			get
			{
				if(r_R__0__50d_Object___0__7X == null)
				{
					r_R__0__50d_Object___0__7X = new(this, "#50d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__50d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__50d_Object___0__7X;
			}
		}

		/// <summary>
		/// Boolean #ipe(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__ipe_Int32_Int32;
		public virtual RMethod R__0__ipe_Int32_Int32
		{
			get
			{
				if(r_R__0__ipe_Int32_Int32 == null)
				{
					r_R__0__ipe_Int32_Int32 = new(this, "#ipe", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__ipe_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__ipe_Int32_Int32;
			}
		}

		/// <summary>
		/// Void #jpe(Int32, Int32, System.Collections.Generic.List`1[#Pfb.#jre])
		/// </summary>
		protected RMethod r_R__0__jpe_Int32_Int32_List_d___0__jre_p_;
		public virtual RMethod R__0__jpe_Int32_Int32_List_d___0__jre_p_
		{
			get
			{
				if(r_R__0__jpe_Int32_Int32_List_d___0__jre_p_ == null)
				{
					r_R__0__jpe_Int32_Int32_List_d___0__jre_p_ = new(this, "#jpe", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#Pfb.#jre")));
					r_R__0__jpe_Int32_Int32_List_d___0__jre_p_.SetBelong(this.instance);
				}
				return r_R__0__jpe_Int32_Int32_List_d___0__jre_p_;
			}
		}

		/// <summary>
		/// Void #kpe()
		/// </summary>
		protected RMethod r_R__0__kpe;
		public virtual RMethod R__0__kpe
		{
			get
			{
				if(r_R__0__kpe == null)
				{
					r_R__0__kpe = new(this, "#kpe", 0);
					r_R__0__kpe.SetBelong(this.instance);
				}
				return r_R__0__kpe;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #lpe(#Gpe)
		/// </summary>
		protected RMethod r_R__0__lpe___0__Gpe;
		public virtual RMethod R__0__lpe___0__Gpe
		{
			get
			{
				if(r_R__0__lpe___0__Gpe == null)
				{
					r_R__0__lpe___0__Gpe = new(this, "#lpe", 0,  ReleactionUtils.GetType("MyGUIMarketWnd+#Gpe"));
					r_R__0__lpe___0__Gpe.SetBelong(this.instance);
				}
				return r_R__0__lpe___0__Gpe;
			}
		}

		/// <summary>
		/// Void #mpe(#Gpe)
		/// </summary>
		protected RMethod r_R__0__mpe___0__Gpe;
		public virtual RMethod R__0__mpe___0__Gpe
		{
			get
			{
				if(r_R__0__mpe___0__Gpe == null)
				{
					r_R__0__mpe___0__Gpe = new(this, "#mpe", 0,  ReleactionUtils.GetType("MyGUIMarketWnd+#Gpe"));
					r_R__0__mpe___0__Gpe.SetBelong(this.instance);
				}
				return r_R__0__mpe___0__Gpe;
			}
		}

		/// <summary>
		/// Void #npe(GameDefineType.ID, #Pfb.#ADb)
		/// </summary>
		protected RMethod r_R__0__npe_ID___0__ADb;
		public virtual RMethod R__0__npe_ID___0__ADb
		{
			get
			{
				if(r_R__0__npe_ID___0__ADb == null)
				{
					r_R__0__npe_ID___0__ADb = new(this, "#npe", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#Pfb.#ADb"));
					r_R__0__npe_ID___0__ADb.SetBelong(this.instance);
				}
				return r_R__0__npe_ID___0__ADb;
			}
		}

		/// <summary>
		/// Void #ope(GameDefineType.ID, #Pfb.#zDb)
		/// </summary>
		protected RMethod r_R__0__ope_ID___0__zDb;
		public virtual RMethod R__0__ope_ID___0__zDb
		{
			get
			{
				if(r_R__0__ope_ID___0__zDb == null)
				{
					r_R__0__ope_ID___0__zDb = new(this, "#ope", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#Pfb.#zDb"));
					r_R__0__ope_ID___0__zDb.SetBelong(this.instance);
				}
				return r_R__0__ope_ID___0__zDb;
			}
		}

		/// <summary>
		/// #Gpe #ppe(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__ppe_ID;
		public virtual RMethod R__0__ppe_ID
		{
			get
			{
				if(r_R__0__ppe_ID == null)
				{
					r_R__0__ppe_ID = new(this, "#ppe", 0, typeof(GameDefineType.ID));
					r_R__0__ppe_ID.SetBelong(this.instance);
				}
				return r_R__0__ppe_ID;
			}
		}

		/// <summary>
		/// Void #qpe(#Pfb.#jre)
		/// </summary>
		protected RMethod r_R__0__qpe___0__jre;
		public virtual RMethod R__0__qpe___0__jre
		{
			get
			{
				if(r_R__0__qpe___0__jre == null)
				{
					r_R__0__qpe___0__jre = new(this, "#qpe", 0,  ReleactionUtils.GetType("#Pfb.#jre"));
					r_R__0__qpe___0__jre.SetBelong(this.instance);
				}
				return r_R__0__qpe___0__jre;
			}
		}

		/// <summary>
		/// Void #C0d()
		/// </summary>
		protected RMethod r_R__0__C0d;
		public virtual RMethod R__0__C0d
		{
			get
			{
				if(r_R__0__C0d == null)
				{
					r_R__0__C0d = new(this, "#C0d", 0);
					r_R__0__C0d.SetBelong(this.instance);
				}
				return r_R__0__C0d;
			}
		}

		/// <summary>
		/// Void #GG()
		/// </summary>
		protected RMethod r_R__0__GG;
		public virtual RMethod R__0__GG
		{
			get
			{
				if(r_R__0__GG == null)
				{
					r_R__0__GG = new(this, "#GG", 0);
					r_R__0__GG.SetBelong(this.instance);
				}
				return r_R__0__GG;
			}
		}

		/// <summary>
		/// Void #D0d()
		/// </summary>
		protected RMethod r_R__0__D0d;
		public virtual RMethod R__0__D0d
		{
			get
			{
				if(r_R__0__D0d == null)
				{
					r_R__0__D0d = new(this, "#D0d", 0);
					r_R__0__D0d.SetBelong(this.instance);
				}
				return r_R__0__D0d;
			}
		}

		/// <summary>
		/// #u.#Ckb #E0d(Int32)
		/// </summary>
		protected RMethod r_R__0__E0d_Int32;
		public virtual RMethod R__0__E0d_Int32
		{
			get
			{
				if(r_R__0__E0d_Int32 == null)
				{
					r_R__0__E0d_Int32 = new(this, "#E0d", 0, typeof(System.Int32));
					r_R__0__E0d_Int32.SetBelong(this.instance);
				}
				return r_R__0__E0d_Int32;
			}
		}

		/// <summary>
		/// Void #F0d()
		/// </summary>
		protected RMethod r_R__0__F0d;
		public virtual RMethod R__0__F0d
		{
			get
			{
				if(r_R__0__F0d == null)
				{
					r_R__0__F0d = new(this, "#F0d", 0);
					r_R__0__F0d.SetBelong(this.instance);
				}
				return r_R__0__F0d;
			}
		}

		/// <summary>
		/// Void #G0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__G0d_Object___0__7X;
		public virtual RMethod R__0__G0d_Object___0__7X
		{
			get
			{
				if(r_R__0__G0d_Object___0__7X == null)
				{
					r_R__0__G0d_Object___0__7X = new(this, "#G0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__G0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__G0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #H0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__H0d_Object___0__7X;
		public virtual RMethod R__0__H0d_Object___0__7X
		{
			get
			{
				if(r_R__0__H0d_Object___0__7X == null)
				{
					r_R__0__H0d_Object___0__7X = new(this, "#H0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__H0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__H0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Buf(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Buf_Object___0__7X;
		public virtual RMethod R__0__Buf_Object___0__7X
		{
			get
			{
				if(r_R__0__Buf_Object___0__7X == null)
				{
					r_R__0__Buf_Object___0__7X = new(this, "#Buf", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Buf_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Buf_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Cuf(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Cuf_Object___0__7X;
		public virtual RMethod R__0__Cuf_Object___0__7X
		{
			get
			{
				if(r_R__0__Cuf_Object___0__7X == null)
				{
					r_R__0__Cuf_Object___0__7X = new(this, "#Cuf", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Cuf_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Cuf_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #I0d()
		/// </summary>
		protected RMethod r_R__0__I0d;
		public virtual RMethod R__0__I0d
		{
			get
			{
				if(r_R__0__I0d == null)
				{
					r_R__0__I0d = new(this, "#I0d", 0);
					r_R__0__I0d.SetBelong(this.instance);
				}
				return r_R__0__I0d;
			}
		}

		/// <summary>
		/// Void #J0d()
		/// </summary>
		protected RMethod r_R__0__J0d;
		public virtual RMethod R__0__J0d
		{
			get
			{
				if(r_R__0__J0d == null)
				{
					r_R__0__J0d = new(this, "#J0d", 0);
					r_R__0__J0d.SetBelong(this.instance);
				}
				return r_R__0__J0d;
			}
		}

		/// <summary>
		/// Void #K0d(#u.#Ckb)
		/// </summary>
		protected RMethod r_R__0__K0d___0__Ckb;
		public virtual RMethod R__0__K0d___0__Ckb
		{
			get
			{
				if(r_R__0__K0d___0__Ckb == null)
				{
					r_R__0__K0d___0__Ckb = new(this, "#K0d", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__K0d___0__Ckb.SetBelong(this.instance);
				}
				return r_R__0__K0d___0__Ckb;
			}
		}

		/// <summary>
		/// Void #K0d(#u.#Ckb, Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__K0d___0__Ckb_Int32_Int32;
		public virtual RMethod R__0__K0d___0__Ckb_Int32_Int32
		{
			get
			{
				if(r_R__0__K0d___0__Ckb_Int32_Int32 == null)
				{
					r_R__0__K0d___0__Ckb_Int32_Int32 = new(this, "#K0d", 0,  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.Int32), typeof(System.Int32));
					r_R__0__K0d___0__Ckb_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__K0d___0__Ckb_Int32_Int32;
			}
		}

		/// <summary>
		/// Void #L0d()
		/// </summary>
		protected RMethod r_R__0__L0d;
		public virtual RMethod R__0__L0d
		{
			get
			{
				if(r_R__0__L0d == null)
				{
					r_R__0__L0d = new(this, "#L0d", 0);
					r_R__0__L0d.SetBelong(this.instance);
				}
				return r_R__0__L0d;
			}
		}

		/// <summary>
		/// Void #M0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__M0d_Object___0__7X;
		public virtual RMethod R__0__M0d_Object___0__7X
		{
			get
			{
				if(r_R__0__M0d_Object___0__7X == null)
				{
					r_R__0__M0d_Object___0__7X = new(this, "#M0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__M0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__M0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Huf(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Huf_Object___0__7X;
		public virtual RMethod R__0__Huf_Object___0__7X
		{
			get
			{
				if(r_R__0__Huf_Object___0__7X == null)
				{
					r_R__0__Huf_Object___0__7X = new(this, "#Huf", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Huf_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Huf_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #N0d()
		/// </summary>
		protected RMethod r_R__0__N0d;
		public virtual RMethod R__0__N0d
		{
			get
			{
				if(r_R__0__N0d == null)
				{
					r_R__0__N0d = new(this, "#N0d", 0);
					r_R__0__N0d.SetBelong(this.instance);
				}
				return r_R__0__N0d;
			}
		}

		/// <summary>
		/// Void #O0d(Int32)
		/// </summary>
		protected RMethod r_R__0__O0d_Int32;
		public virtual RMethod R__0__O0d_Int32
		{
			get
			{
				if(r_R__0__O0d_Int32 == null)
				{
					r_R__0__O0d_Int32 = new(this, "#O0d", 0, typeof(System.Int32));
					r_R__0__O0d_Int32.SetBelong(this.instance);
				}
				return r_R__0__O0d_Int32;
			}
		}

		/// <summary>
		/// Void #P0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__P0d_Object___0__7X;
		public virtual RMethod R__0__P0d_Object___0__7X
		{
			get
			{
				if(r_R__0__P0d_Object___0__7X == null)
				{
					r_R__0__P0d_Object___0__7X = new(this, "#P0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__P0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__P0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Jzf(System.Object)
		/// </summary>
		protected RMethod r_R__0__Jzf_Object;
		public virtual RMethod R__0__Jzf_Object
		{
			get
			{
				if(r_R__0__Jzf_Object == null)
				{
					r_R__0__Jzf_Object = new(this, "#Jzf", 0, typeof(System.Object));
					r_R__0__Jzf_Object.SetBelong(this.instance);
				}
				return r_R__0__Jzf_Object;
			}
		}

		/// <summary>
		/// Void #slj(System.Object)
		/// </summary>
		protected RMethod r_R__0__slj_Object;
		public virtual RMethod R__0__slj_Object
		{
			get
			{
				if(r_R__0__slj_Object == null)
				{
					r_R__0__slj_Object = new(this, "#slj", 0, typeof(System.Object));
					r_R__0__slj_Object.SetBelong(this.instance);
				}
				return r_R__0__slj_Object;
			}
		}

		/// <summary>
		/// Void #Q0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Q0d_Object___0__7X;
		public virtual RMethod R__0__Q0d_Object___0__7X
		{
			get
			{
				if(r_R__0__Q0d_Object___0__7X == null)
				{
					r_R__0__Q0d_Object___0__7X = new(this, "#Q0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Q0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Q0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #R0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__R0d_Object___0__7X;
		public virtual RMethod R__0__R0d_Object___0__7X
		{
			get
			{
				if(r_R__0__R0d_Object___0__7X == null)
				{
					r_R__0__R0d_Object___0__7X = new(this, "#R0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__R0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__R0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #S0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__S0d_Object___0__7X;
		public virtual RMethod R__0__S0d_Object___0__7X
		{
			get
			{
				if(r_R__0__S0d_Object___0__7X == null)
				{
					r_R__0__S0d_Object___0__7X = new(this, "#S0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__S0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__S0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #T0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__T0d_Object___0__7X;
		public virtual RMethod R__0__T0d_Object___0__7X
		{
			get
			{
				if(r_R__0__T0d_Object___0__7X == null)
				{
					r_R__0__T0d_Object___0__7X = new(this, "#T0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__T0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__T0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Kzf(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Kzf_Object___0__7X;
		public virtual RMethod R__0__Kzf_Object___0__7X
		{
			get
			{
				if(r_R__0__Kzf_Object___0__7X == null)
				{
					r_R__0__Kzf_Object___0__7X = new(this, "#Kzf", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Kzf_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Kzf_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #U0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__U0d_Object___0__7X;
		public virtual RMethod R__0__U0d_Object___0__7X
		{
			get
			{
				if(r_R__0__U0d_Object___0__7X == null)
				{
					r_R__0__U0d_Object___0__7X = new(this, "#U0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__U0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__U0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #V0d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__V0d_Object___0__7X;
		public virtual RMethod R__0__V0d_Object___0__7X
		{
			get
			{
				if(r_R__0__V0d_Object___0__7X == null)
				{
					r_R__0__V0d_Object___0__7X = new(this, "#V0d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__V0d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__V0d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #W0d()
		/// </summary>
		protected RMethod r_R__0__W0d;
		public virtual RMethod R__0__W0d
		{
			get
			{
				if(r_R__0__W0d == null)
				{
					r_R__0__W0d = new(this, "#W0d", 0);
					r_R__0__W0d.SetBelong(this.instance);
				}
				return r_R__0__W0d;
			}
		}

		/// <summary>
		/// Void #rpe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__rpe_Object___0__7X;
		public virtual RMethod R__0__rpe_Object___0__7X
		{
			get
			{
				if(r_R__0__rpe_Object___0__7X == null)
				{
					r_R__0__rpe_Object___0__7X = new(this, "#rpe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__rpe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__rpe_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #spe(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__spe_Object___0__7X;
		public virtual RMethod R__0__spe_Object___0__7X
		{
			get
			{
				if(r_R__0__spe_Object___0__7X == null)
				{
					r_R__0__spe_Object___0__7X = new(this, "#spe", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__spe_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__spe_Object___0__7X;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #tpe(#Kpe)
		/// </summary>
		protected RMethod r_R__0__tpe___0__Kpe;
		public virtual RMethod R__0__tpe___0__Kpe
		{
			get
			{
				if(r_R__0__tpe___0__Kpe == null)
				{
					r_R__0__tpe___0__Kpe = new(this, "#tpe", 0,  ReleactionUtils.GetType("MyGUIMarketWnd+#Kpe"));
					r_R__0__tpe___0__Kpe.SetBelong(this.instance);
				}
				return r_R__0__tpe___0__Kpe;
			}
		}

		/// <summary>
		/// Void #upe(#Kpe)
		/// </summary>
		protected RMethod r_R__0__upe___0__Kpe;
		public virtual RMethod R__0__upe___0__Kpe
		{
			get
			{
				if(r_R__0__upe___0__Kpe == null)
				{
					r_R__0__upe___0__Kpe = new(this, "#upe", 0,  ReleactionUtils.GetType("MyGUIMarketWnd+#Kpe"));
					r_R__0__upe___0__Kpe.SetBelong(this.instance);
				}
				return r_R__0__upe___0__Kpe;
			}
		}

		/// <summary>
		/// Void #vpe()
		/// </summary>
		protected RMethod r_R__0__vpe;
		public virtual RMethod R__0__vpe
		{
			get
			{
				if(r_R__0__vpe == null)
				{
					r_R__0__vpe = new(this, "#vpe", 0);
					r_R__0__vpe.SetBelong(this.instance);
				}
				return r_R__0__vpe;
			}
		}

		/// <summary>
		/// Void #X0d()
		/// </summary>
		protected RMethod r_R__0__X0d;
		public virtual RMethod R__0__X0d
		{
			get
			{
				if(r_R__0__X0d == null)
				{
					r_R__0__X0d = new(this, "#X0d", 0);
					r_R__0__X0d.SetBelong(this.instance);
				}
				return r_R__0__X0d;
			}
		}

		/// <summary>
		/// Void #wpe()
		/// </summary>
		protected RMethod r_R__0__wpe;
		public virtual RMethod R__0__wpe
		{
			get
			{
				if(r_R__0__wpe == null)
				{
					r_R__0__wpe = new(this, "#wpe", 0);
					r_R__0__wpe.SetBelong(this.instance);
				}
				return r_R__0__wpe;
			}
		}

		/// <summary>
		/// Void #xpe(System.Collections.Generic.List`1[#Pfb.#jre])
		/// </summary>
		protected RMethod r_R__0__xpe_List_d___0__jre_p_;
		public virtual RMethod R__0__xpe_List_d___0__jre_p_
		{
			get
			{
				if(r_R__0__xpe_List_d___0__jre_p_ == null)
				{
					r_R__0__xpe_List_d___0__jre_p_ = new(this, "#xpe", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#Pfb.#jre")));
					r_R__0__xpe_List_d___0__jre_p_.SetBelong(this.instance);
				}
				return r_R__0__xpe_List_d___0__jre_p_;
			}
		}

		/// <summary>
		/// Void #ype(GameDefineType.ID, #Pfb.#ADb)
		/// </summary>
		protected RMethod r_R__0__ype_ID___0__ADb;
		public virtual RMethod R__0__ype_ID___0__ADb
		{
			get
			{
				if(r_R__0__ype_ID___0__ADb == null)
				{
					r_R__0__ype_ID___0__ADb = new(this, "#ype", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#Pfb.#ADb"));
					r_R__0__ype_ID___0__ADb.SetBelong(this.instance);
				}
				return r_R__0__ype_ID___0__ADb;
			}
		}

		/// <summary>
		/// Void #zpe(GameDefineType.ID, #Pfb.#zDb)
		/// </summary>
		protected RMethod r_R__0__zpe_ID___0__zDb;
		public virtual RMethod R__0__zpe_ID___0__zDb
		{
			get
			{
				if(r_R__0__zpe_ID___0__zDb == null)
				{
					r_R__0__zpe_ID___0__zDb = new(this, "#zpe", 0, typeof(GameDefineType.ID),  ReleactionUtils.GetType("#Pfb.#zDb"));
					r_R__0__zpe_ID___0__zDb.SetBelong(this.instance);
				}
				return r_R__0__zpe_ID___0__zDb;
			}
		}

		/// <summary>
		/// #Kpe #Ape(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Ape_ID;
		public virtual RMethod R__0__Ape_ID
		{
			get
			{
				if(r_R__0__Ape_ID == null)
				{
					r_R__0__Ape_ID = new(this, "#Ape", 0, typeof(GameDefineType.ID));
					r_R__0__Ape_ID.SetBelong(this.instance);
				}
				return r_R__0__Ape_ID;
			}
		}

		/// <summary>
		/// Void #bTf()
		/// </summary>
		protected RMethod r_R__0__bTf;
		public virtual RMethod R__0__bTf
		{
			get
			{
				if(r_R__0__bTf == null)
				{
					r_R__0__bTf = new(this, "#bTf", 0);
					r_R__0__bTf.SetBelong(this.instance);
				}
				return r_R__0__bTf;
			}
		}

		/// <summary>
		/// Void #cTf()
		/// </summary>
		protected RMethod r_R__0__cTf;
		public virtual RMethod R__0__cTf
		{
			get
			{
				if(r_R__0__cTf == null)
				{
					r_R__0__cTf = new(this, "#cTf", 0);
					r_R__0__cTf.SetBelong(this.instance);
				}
				return r_R__0__cTf;
			}
		}

		/// <summary>
		/// Void #w4f(System.Collections.Generic.List`1[#Pfb.#R4f])
		/// </summary>
		protected RMethod r_R__0__w4f_List_d___0__R4f_p_;
		public virtual RMethod R__0__w4f_List_d___0__R4f_p_
		{
			get
			{
				if(r_R__0__w4f_List_d___0__R4f_p_ == null)
				{
					r_R__0__w4f_List_d___0__R4f_p_ = new(this, "#w4f", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#Pfb.#R4f")));
					r_R__0__w4f_List_d___0__R4f_p_.SetBelong(this.instance);
				}
				return r_R__0__w4f_List_d___0__R4f_p_;
			}
		}

		/// <summary>
		/// Boolean #cex(#u.#Ckb)
		/// </summary>
		protected static RMethod r_R__0__cex___0__Ckb;
		public static RMethod R__0__cex___0__Ckb
		{
			get
			{
				if(r_R__0__cex___0__Ckb == null)
				{
					r_R__0__cex___0__Ckb = new( ReleactionUtils.GetType("MyGUIMarketWnd"), "#cex", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_R__0__cex___0__Ckb.SetBelong(null);
				}
				return r_R__0__cex___0__Ckb;
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


        public RMyGUIMarketWnd() : base("MyGUIMarketWnd")
        {
        }

        public RMyGUIMarketWnd(System.Object instance) : base("MyGUIMarketWnd")
		{
            SetInstance(instance);
		}

        public RMyGUIMarketWnd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMyGUIMarketWnd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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


        public virtual void __0__lVe(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__lVe_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Xd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Xd.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Abb(System.String  @paramstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramstr};
            var ___result = R__0__Abb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__u4f(GameDefineType.ID  @itemid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@itemid};
            var ___result = R__0__u4f_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__v4f(System.String  @serchkey)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@serchkey};
            var ___result = R__0__v4f_String.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__sb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__sb_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__ape()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__ape.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__B0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__B0d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__WEe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__WEe.Invoke(___genericsType, ___parameters);

            
        }







        public virtual System.Collections.IEnumerator __0__epe(MyGUI.ElementBase  @eb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@eb};
            var ___result = R__0__epe_ElementBase.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }






        public virtual System.Boolean __0__ipe(System.Int32  @type, System.Int32  @page)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @page};
            var ___result = R__0__ipe_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void __0__kpe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__kpe.Invoke(___genericsType, ___parameters);

            
        }






        public virtual System.Object __0__ppe(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__ppe_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void __0__C0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__C0d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__GG()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__GG.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__D0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__D0d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__E0d(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__E0d_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__F0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__F0d.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void __0__I0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__I0d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__J0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__J0d.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__L0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__L0d.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__N0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__N0d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__O0d(System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = R__0__O0d_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__Jzf(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__Jzf_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__slj(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__slj_Object.Invoke(___genericsType, ___parameters);

            
        }









        public virtual void __0__W0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__W0d.Invoke(___genericsType, ___parameters);

            
        }






        public virtual void __0__vpe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__vpe.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__X0d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__X0d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__wpe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wpe.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Object __0__Ape(GameDefineType.ID  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__Ape_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__bTf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__bTf.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__cTf()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__cTf.Invoke(___genericsType, ___parameters);

            
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
