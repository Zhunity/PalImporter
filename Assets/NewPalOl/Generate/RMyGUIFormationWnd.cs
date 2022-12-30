using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// MyGUIFormationWnd
	/// </summary>
    public partial class RMyGUIFormationWnd : RMember //
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
					r___0__a = new( ReleactionUtils.GetType("MyGUIFormationWnd"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Int32 #b
		/// </summary>
		protected static RField r___0__b;
		public static RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new( ReleactionUtils.GetType("MyGUIFormationWnd"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Int32 #c
		/// </summary>
		protected static RField r___0__c;
		public static RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new( ReleactionUtils.GetType("MyGUIFormationWnd"), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// #oU.#5bb #d
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__d;
		public virtual R__0__oU.R__0__5bb R__0__d
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
		/// System.Boolean #e
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
		/// System.Collections.Generic.List`1[MyGUI.ElementBase] #f
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> r___0__f;
		public virtual RSystem.RCollections.RGeneric.RList<RMyGUI.RElementBase> R__0__f
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Boolean] #g
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RField> r___0__g;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RField> R__0__g
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
		/// System.Collections.Generic.List`1[GameDefineType.ID] #h
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> r___0__h;
		public virtual RSystem.RCollections.RGeneric.RList<RGameDefineType.RID> R__0__h
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
		/// UnityEngine.GameObject #i
		/// </summary>
		protected RUnityEngine.RGameObject r___0__i;
		public virtual RUnityEngine.RGameObject R__0__i
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
		/// UnityEngine.GameObject #j
		/// </summary>
		protected RUnityEngine.RGameObject r___0__j;
		public virtual RUnityEngine.RGameObject R__0__j
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
		/// GameDefineType.ID[] #k
		/// </summary>
		protected RFieldArray<RGameDefineType.RID> r___0__k;
		public virtual RFieldArray<RGameDefineType.RID> R__0__k
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
		/// System.Int32 #m
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
		/// System.Int32 #n
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
		/// System.Int32 #o
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
		/// GameDefineType.ID[] #p
		/// </summary>
		protected RFieldArray<RGameDefineType.RID> r___0__p;
		public virtual RFieldArray<RGameDefineType.RID> R__0__p
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.GameObject] #q
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGameObject> r___0__q;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGameObject> R__0__q
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
		/// System.Collections.Generic.List`1[DragPrefab] #r
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RDragPrefab> r___0__r;
		public virtual RSystem.RCollections.RGeneric.RList<RDragPrefab> R__0__r
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
		/// MatrixItem #s
		/// </summary>
		protected RMatrixItem r___0__s;
		public virtual RMatrixItem R__0__s
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
		/// UnityEngine.Object #t
		/// </summary>
		protected RUnityEngine.RObject r___0__t;
		public virtual RUnityEngine.RObject R__0__t
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
		protected RUnityEngine.RGameObject r___0__u;
		public virtual RUnityEngine.RGameObject R__0__u
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
		/// UnityEngine.Camera #v
		/// </summary>
		protected RUnityEngine.RCamera r___0__v;
		public virtual RUnityEngine.RCamera R__0__v
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
		/// #u.#Uq[] #w
		/// </summary>
		protected RFieldArray<R__0__u.R__0__Uq> r___0__w;
		public virtual RFieldArray<R__0__u.R__0__Uq> R__0__w
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
		/// #u.#Uq[] #x
		/// </summary>
		protected RFieldArray<R__0__u.R__0__Uq> r___0__x;
		public virtual RFieldArray<R__0__u.R__0__Uq> R__0__x
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
		/// #u.#Uq #y
		/// </summary>
		protected R__0__u.R__0__Uq r___0__y;
		public virtual R__0__u.R__0__Uq R__0__y
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
		/// #u.#Uq #z
		/// </summary>
		protected R__0__u.R__0__Uq r___0__z;
		public virtual R__0__u.R__0__Uq R__0__z
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
		/// #u.#Uq #A
		/// </summary>
		protected R__0__u.R__0__Uq r___0__A;
		public virtual R__0__u.R__0__Uq R__0__A
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
		/// #u.#Uq #B
		/// </summary>
		protected R__0__u.R__0__Uq r___0__B;
		public virtual R__0__u.R__0__Uq R__0__B
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
		/// #u.#Uq #C
		/// </summary>
		protected R__0__u.R__0__Uq r___0__C;
		public virtual R__0__u.R__0__Uq R__0__C
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
		/// #u.#Uq[] #D
		/// </summary>
		protected RFieldArray<R__0__u.R__0__Uq> r___0__D;
		public virtual RFieldArray<R__0__u.R__0__Uq> R__0__D
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
		/// System.Boolean #E
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
		/// System.Boolean #F
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
		/// System.String[] #G
		/// </summary>
		protected RFieldArray<RField> r___0__G;
		public virtual RFieldArray<RField> R__0__G
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
		/// UnityEngine.Vector2 #H
		/// </summary>
		protected RUnityEngine.RVector2 r___0__H;
		public virtual RUnityEngine.RVector2 R__0__H
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
		/// #u.#h6d #I
		/// </summary>
		protected R__0__u.R__0__h6d r___0__I;
		public virtual R__0__u.R__0__h6d R__0__I
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
		/// System.String #J
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
		/// UnityEngine.GameObject #K
		/// </summary>
		protected RUnityEngine.RGameObject r___0__K;
		public virtual RUnityEngine.RGameObject R__0__K
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
		/// UnityEngine.GameObject #L
		/// </summary>
		protected RUnityEngine.RGameObject r___0__L;
		public virtual RUnityEngine.RGameObject R__0__L
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
		/// UnityEngine.GameObject #M
		/// </summary>
		protected RUnityEngine.RGameObject r___0__M;
		public virtual RUnityEngine.RGameObject R__0__M
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.Transform] #N
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,UnityEngine.Vector3] #O
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RVector3> r___0__O;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RVector3> R__0__O
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
		/// #oU.#5bb #P
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__P;
		public virtual R__0__oU.R__0__5bb R__0__P
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
		/// UnityEngine.GameObject #Q
		/// </summary>
		protected RUnityEngine.RGameObject r___0__Q;
		public virtual RUnityEngine.RGameObject R__0__Q
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
		/// GameDefineType.ID #R
		/// </summary>
		protected RGameDefineType.RID r___0__R;
		public virtual RGameDefineType.RID R__0__R
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
		/// GameDefineType.ID #S
		/// </summary>
		protected RGameDefineType.RID r___0__S;
		public virtual RGameDefineType.RID R__0__S
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
		/// GameDefineType.ID #T
		/// </summary>
		protected RGameDefineType.RID r___0__T;
		public virtual RGameDefineType.RID R__0__T
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
		/// GameDefineType.ID #U
		/// </summary>
		protected RGameDefineType.RID r___0__U;
		public virtual RGameDefineType.RID R__0__U
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
		protected RField r___0__V;
		public virtual RField R__0__V
		{
			get
			{
				if(r___0__V == null)
				{
					r___0__V = new(this, "#V");
					r___0__V.SetBelong(this.instance);
				}
				return r___0__V;
			}
		}

		/// <summary>
		/// GameDefineType.ID #W
		/// </summary>
		protected RGameDefineType.RID r___0__W;
		public virtual RGameDefineType.RID R__0__W
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
		/// GameDefineType.ID #X
		/// </summary>
		protected RGameDefineType.RID r___0__X;
		public virtual RGameDefineType.RID R__0__X
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
		/// GameDefineType.ID #Y
		/// </summary>
		protected RGameDefineType.RID r___0__Y;
		public virtual RGameDefineType.RID R__0__Y
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
		/// GameDefineType.ID #Z
		/// </summary>
		protected RGameDefineType.RID r___0__Z;
		public virtual RGameDefineType.RID R__0__Z
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
		/// #oU.#5bb #0
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__0;
		public virtual R__0__oU.R__0__5bb R__0__0
		{
			get
			{
				if(r___0__0 == null)
				{
					r___0__0 = new(this, "#0");
					r___0__0.SetBelong(this.instance);
				}
				return r___0__0;
			}
		}

		/// <summary>
		/// System.Boolean #1
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
		/// #Pfb.#tDr #2
		/// </summary>
		protected R__0__Pfb.R__0__tDr r___0__2;
		public virtual R__0__Pfb.R__0__tDr R__0__2
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,#u.#fCr+#gCr] #3
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__fCr.R__0__gCr> r___0__3;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, R__0__u.R__0__fCr.R__0__gCr> R__0__3
		{
			get
			{
				if(r___0__3 == null)
				{
					r___0__3 = new(this, "#3");
					r___0__3.SetBelong(this.instance);
				}
				return r___0__3;
			}
		}

		/// <summary>
		/// GameDefineType.ID[] #4
		/// </summary>
		protected RFieldArray<RGameDefineType.RID> r___0__4;
		public virtual RFieldArray<RGameDefineType.RID> R__0__4
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
		/// DragPrefab #5
		/// </summary>
		protected RDragPrefab r___0__5;
		public virtual RDragPrefab R__0__5
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
		/// GameDefineType.ID[] GetEffectMatrix
		/// </summary>
		protected RPropertyArray<RGameDefineType.RID> r_R__0__XNc;
		public virtual RPropertyArray<RGameDefineType.RID> R__0__XNc
		{
			get
			{
				if(r_R__0__XNc == null)
				{
					r_R__0__XNc = new(this, "GetEffectMatrix", -1);
					r_R__0__XNc.SetBelong(this.instance);
				}
				return r_R__0__XNc;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase m_closeElement
		/// </summary>
		protected RMyGUI.RElementBase r_R__0__PYd;
		public virtual RMyGUI.RElementBase R__0__PYd
		{
			get
			{
				if(r_R__0__PYd == null)
				{
					r_R__0__PYd = new(this, "m_closeElement", -1);
					r_R__0__PYd.SetBelong(this.instance);
				}
				return r_R__0__PYd;
			}
		}

		/// <summary>
		/// GameDefineType.ID OBPetID0
		/// </summary>
		protected RGameDefineType.RID r_R__0__rGn;
		public virtual RGameDefineType.RID R__0__rGn
		{
			get
			{
				if(r_R__0__rGn == null)
				{
					r_R__0__rGn = new(this, "OBPetID0", -1);
					r_R__0__rGn.SetBelong(this.instance);
				}
				return r_R__0__rGn;
			}
		}

		/// <summary>
		/// GameDefineType.ID OBPetID1
		/// </summary>
		protected RGameDefineType.RID r_R__0__tGn;
		public virtual RGameDefineType.RID R__0__tGn
		{
			get
			{
				if(r_R__0__tGn == null)
				{
					r_R__0__tGn = new(this, "OBPetID1", -1);
					r_R__0__tGn.SetBelong(this.instance);
				}
				return r_R__0__tGn;
			}
		}

		/// <summary>
		/// GameDefineType.ID OBPetID2
		/// </summary>
		protected RGameDefineType.RID r_R__0__3Xp;
		public virtual RGameDefineType.RID R__0__3Xp
		{
			get
			{
				if(r_R__0__3Xp == null)
				{
					r_R__0__3Xp = new(this, "OBPetID2", -1);
					r_R__0__3Xp.SetBelong(this.instance);
				}
				return r_R__0__3Xp;
			}
		}

		/// <summary>
		/// GameDefineType.ID OBPetID3
		/// </summary>
		protected RGameDefineType.RID r_R__0__5Xp;
		public virtual RGameDefineType.RID R__0__5Xp
		{
			get
			{
				if(r_R__0__5Xp == null)
				{
					r_R__0__5Xp = new(this, "OBPetID3", -1);
					r_R__0__5Xp.SetBelong(this.instance);
				}
				return r_R__0__5Xp;
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
		/// Void #8Tu(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__8Tu_Object___0__7X;
		public virtual RMethod R__0__8Tu_Object___0__7X
		{
			get
			{
				if(r_R__0__8Tu_Object___0__7X == null)
				{
					r_R__0__8Tu_Object___0__7X = new(this, "#8Tu", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__8Tu_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__8Tu_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #pGn(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__pGn_Object___0__7X;
		public virtual RMethod R__0__pGn_Object___0__7X
		{
			get
			{
				if(r_R__0__pGn_Object___0__7X == null)
				{
					r_R__0__pGn_Object___0__7X = new(this, "#pGn", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__pGn_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__pGn_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Fo()
		/// </summary>
		protected RMethod r_R__0__Fo;
		public virtual RMethod R__0__Fo
		{
			get
			{
				if(r_R__0__Fo == null)
				{
					r_R__0__Fo = new(this, "#Fo", 0);
					r_R__0__Fo.SetBelong(this.instance);
				}
				return r_R__0__Fo;
			}
		}

		/// <summary>
		/// Void #Vq(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Vq_Object___0__Isb;
		public virtual RMethod R__0__Vq_Object___0__Isb
		{
			get
			{
				if(r_R__0__Vq_Object___0__Isb == null)
				{
					r_R__0__Vq_Object___0__Isb = new(this, "#Vq", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Vq_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Vq_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Wq(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__Wq_Object___0__Isb;
		public virtual RMethod R__0__Wq_Object___0__Isb
		{
			get
			{
				if(r_R__0__Wq_Object___0__Isb == null)
				{
					r_R__0__Wq_Object___0__Isb = new(this, "#Wq", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__Wq_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__Wq_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #Xq()
		/// </summary>
		protected RMethod r_R__0__Xq;
		public virtual RMethod R__0__Xq
		{
			get
			{
				if(r_R__0__Xq == null)
				{
					r_R__0__Xq = new(this, "#Xq", 0);
					r_R__0__Xq.SetBelong(this.instance);
				}
				return r_R__0__Xq;
			}
		}

		/// <summary>
		/// Void #Yq()
		/// </summary>
		protected RMethod r_R__0__Yq;
		public virtual RMethod R__0__Yq
		{
			get
			{
				if(r_R__0__Yq == null)
				{
					r_R__0__Yq = new(this, "#Yq", 0);
					r_R__0__Yq.SetBelong(this.instance);
				}
				return r_R__0__Yq;
			}
		}

		/// <summary>
		/// Void #qGn()
		/// </summary>
		protected RMethod r_R__0__qGn;
		public virtual RMethod R__0__qGn
		{
			get
			{
				if(r_R__0__qGn == null)
				{
					r_R__0__qGn = new(this, "#qGn", 0);
					r_R__0__qGn.SetBelong(this.instance);
				}
				return r_R__0__qGn;
			}
		}

		/// <summary>
		/// shenshouItem #VNc(GameDefineType.ID[])
		/// </summary>
		protected RMethod r_R__0__VNc_IDArray;
		public virtual RMethod R__0__VNc_IDArray
		{
			get
			{
				if(r_R__0__VNc_IDArray == null)
				{
					r_R__0__VNc_IDArray = new(this, "#VNc", 0, typeof(GameDefineType.ID).MakeArrayType());
					r_R__0__VNc_IDArray.SetBelong(this.instance);
				}
				return r_R__0__VNc_IDArray;
			}
		}

		/// <summary>
		/// Void #col()
		/// </summary>
		protected RMethod r_R__0__col;
		public virtual RMethod R__0__col
		{
			get
			{
				if(r_R__0__col == null)
				{
					r_R__0__col = new(this, "#col", 0);
					r_R__0__col.SetBelong(this.instance);
				}
				return r_R__0__col;
			}
		}

		/// <summary>
		/// Void #dol()
		/// </summary>
		protected RMethod r_R__0__dol;
		public virtual RMethod R__0__dol
		{
			get
			{
				if(r_R__0__dol == null)
				{
					r_R__0__dol = new(this, "#dol", 0);
					r_R__0__dol.SetBelong(this.instance);
				}
				return r_R__0__dol;
			}
		}

		/// <summary>
		/// Void #VIc(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__VIc_Object___0__7X;
		public virtual RMethod R__0__VIc_Object___0__7X
		{
			get
			{
				if(r_R__0__VIc_Object___0__7X == null)
				{
					r_R__0__VIc_Object___0__7X = new(this, "#VIc", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__VIc_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__VIc_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #hYi(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__hYi_Object___0__7X;
		public virtual RMethod R__0__hYi_Object___0__7X
		{
			get
			{
				if(r_R__0__hYi_Object___0__7X == null)
				{
					r_R__0__hYi_Object___0__7X = new(this, "#hYi", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__hYi_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__hYi_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Zq()
		/// </summary>
		protected RMethod r_R__0__Zq;
		public virtual RMethod R__0__Zq
		{
			get
			{
				if(r_R__0__Zq == null)
				{
					r_R__0__Zq = new(this, "#Zq", 0);
					r_R__0__Zq.SetBelong(this.instance);
				}
				return r_R__0__Zq;
			}
		}

		/// <summary>
		/// Void #0q(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__0q_Object___0__Isb;
		public virtual RMethod R__0__0q_Object___0__Isb
		{
			get
			{
				if(r_R__0__0q_Object___0__Isb == null)
				{
					r_R__0__0q_Object___0__Isb = new(this, "#0q", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__0q_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__0q_Object___0__Isb;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #tn()
		/// </summary>
		protected RMethod r_R__0__tn;
		public virtual RMethod R__0__tn
		{
			get
			{
				if(r_R__0__tn == null)
				{
					r_R__0__tn = new(this, "#tn", 0);
					r_R__0__tn.SetBelong(this.instance);
				}
				return r_R__0__tn;
			}
		}

		/// <summary>
		/// Void #1q()
		/// </summary>
		protected RMethod r_R__0__1q;
		public virtual RMethod R__0__1q
		{
			get
			{
				if(r_R__0__1q == null)
				{
					r_R__0__1q = new(this, "#1q", 0);
					r_R__0__1q.SetBelong(this.instance);
				}
				return r_R__0__1q;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #QEg()
		/// </summary>
		protected RMethod r_R__0__QEg;
		public virtual RMethod R__0__QEg
		{
			get
			{
				if(r_R__0__QEg == null)
				{
					r_R__0__QEg = new(this, "#QEg", 0);
					r_R__0__QEg.SetBelong(this.instance);
				}
				return r_R__0__QEg;
			}
		}

		/// <summary>
		/// Int32 #2q()
		/// </summary>
		protected RMethod r_R__0__2q;
		public virtual RMethod R__0__2q
		{
			get
			{
				if(r_R__0__2q == null)
				{
					r_R__0__2q = new(this, "#2q", 0);
					r_R__0__2q.SetBelong(this.instance);
				}
				return r_R__0__2q;
			}
		}

		/// <summary>
		/// Boolean #3q(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__3q_ID;
		public virtual RMethod R__0__3q_ID
		{
			get
			{
				if(r_R__0__3q_ID == null)
				{
					r_R__0__3q_ID = new(this, "#3q", 0, typeof(GameDefineType.ID));
					r_R__0__3q_ID.SetBelong(this.instance);
				}
				return r_R__0__3q_ID;
			}
		}

		/// <summary>
		/// Void #4q(DragPrefab, Int32)
		/// </summary>
		protected RMethod r_R__0__4q_DragPrefab_Int32;
		public virtual RMethod R__0__4q_DragPrefab_Int32
		{
			get
			{
				if(r_R__0__4q_DragPrefab_Int32 == null)
				{
					r_R__0__4q_DragPrefab_Int32 = new(this, "#4q", 0,  ReleactionUtils.GetType("DragPrefab"), typeof(System.Int32));
					r_R__0__4q_DragPrefab_Int32.SetBelong(this.instance);
				}
				return r_R__0__4q_DragPrefab_Int32;
			}
		}

		/// <summary>
		/// Int32 #5q(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__5q_ID;
		public virtual RMethod R__0__5q_ID
		{
			get
			{
				if(r_R__0__5q_ID == null)
				{
					r_R__0__5q_ID = new(this, "#5q", 0, typeof(GameDefineType.ID));
					r_R__0__5q_ID.SetBelong(this.instance);
				}
				return r_R__0__5q_ID;
			}
		}

		/// <summary>
		/// Void #Eiq()
		/// </summary>
		protected RMethod r_R__0__Eiq;
		public virtual RMethod R__0__Eiq
		{
			get
			{
				if(r_R__0__Eiq == null)
				{
					r_R__0__Eiq = new(this, "#Eiq", 0);
					r_R__0__Eiq.SetBelong(this.instance);
				}
				return r_R__0__Eiq;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #OPv()
		/// </summary>
		protected RMethod r_R__0__OPv;
		public virtual RMethod R__0__OPv
		{
			get
			{
				if(r_R__0__OPv == null)
				{
					r_R__0__OPv = new(this, "#OPv", 0);
					r_R__0__OPv.SetBelong(this.instance);
				}
				return r_R__0__OPv;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[GameDefineType.ID] #Fiq()
		/// </summary>
		protected RMethod r_R__0__Fiq;
		public virtual RMethod R__0__Fiq
		{
			get
			{
				if(r_R__0__Fiq == null)
				{
					r_R__0__Fiq = new(this, "#Fiq", 0);
					r_R__0__Fiq.SetBelong(this.instance);
				}
				return r_R__0__Fiq;
			}
		}

		/// <summary>
		/// Pet #Giq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Giq_ID;
		public virtual RMethod R__0__Giq_ID
		{
			get
			{
				if(r_R__0__Giq_ID == null)
				{
					r_R__0__Giq_ID = new(this, "#Giq", 0, typeof(GameDefineType.ID));
					r_R__0__Giq_ID.SetBelong(this.instance);
				}
				return r_R__0__Giq_ID;
			}
		}

		/// <summary>
		/// Void #Hiq(System.Collections.Generic.List`1[GameDefineType.ID])
		/// </summary>
		protected RMethod r_R__0__Hiq_List_d_ID_p_;
		public virtual RMethod R__0__Hiq_List_d_ID_p_
		{
			get
			{
				if(r_R__0__Hiq_List_d_ID_p_ == null)
				{
					r_R__0__Hiq_List_d_ID_p_ = new(this, "#Hiq", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(GameDefineType.ID)));
					r_R__0__Hiq_List_d_ID_p_.SetBelong(this.instance);
				}
				return r_R__0__Hiq_List_d_ID_p_;
			}
		}

		/// <summary>
		/// Int32 #7q()
		/// </summary>
		protected RMethod r_R__0__7q;
		public virtual RMethod R__0__7q
		{
			get
			{
				if(r_R__0__7q == null)
				{
					r_R__0__7q = new(this, "#7q", 0);
					r_R__0__7q.SetBelong(this.instance);
				}
				return r_R__0__7q;
			}
		}

		/// <summary>
		/// Boolean #8q(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__8q_ID;
		public virtual RMethod R__0__8q_ID
		{
			get
			{
				if(r_R__0__8q_ID == null)
				{
					r_R__0__8q_ID = new(this, "#8q", 0, typeof(GameDefineType.ID));
					r_R__0__8q_ID.SetBelong(this.instance);
				}
				return r_R__0__8q_ID;
			}
		}

		/// <summary>
		/// Boolean #TXb()
		/// </summary>
		protected RMethod r_R__0__TXb;
		public virtual RMethod R__0__TXb
		{
			get
			{
				if(r_R__0__TXb == null)
				{
					r_R__0__TXb = new(this, "#TXb", 0);
					r_R__0__TXb.SetBelong(this.instance);
				}
				return r_R__0__TXb;
			}
		}

		/// <summary>
		/// Void #9q(Int32, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__9q_Int32_ID;
		public virtual RMethod R__0__9q_Int32_ID
		{
			get
			{
				if(r_R__0__9q_Int32_ID == null)
				{
					r_R__0__9q_Int32_ID = new(this, "#9q", 0, typeof(System.Int32), typeof(GameDefineType.ID));
					r_R__0__9q_Int32_ID.SetBelong(this.instance);
				}
				return r_R__0__9q_Int32_ID;
			}
		}

		/// <summary>
		/// Void #ar(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__ar_Object___0__7X;
		public virtual RMethod R__0__ar_Object___0__7X
		{
			get
			{
				if(r_R__0__ar_Object___0__7X == null)
				{
					r_R__0__ar_Object___0__7X = new(this, "#ar", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__ar_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__ar_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #plj(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__plj_Object___0__7X;
		public virtual RMethod R__0__plj_Object___0__7X
		{
			get
			{
				if(r_R__0__plj_Object___0__7X == null)
				{
					r_R__0__plj_Object___0__7X = new(this, "#plj", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__plj_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__plj_Object___0__7X;
			}
		}

		/// <summary>
		/// Boolean #br(System.String)
		/// </summary>
		protected RMethod r_R__0__br_String;
		public virtual RMethod R__0__br_String
		{
			get
			{
				if(r_R__0__br_String == null)
				{
					r_R__0__br_String = new(this, "#br", 0, typeof(System.String));
					r_R__0__br_String.SetBelong(this.instance);
				}
				return r_R__0__br_String;
			}
		}

		/// <summary>
		/// #u.#Uq #cr(Int32)
		/// </summary>
		protected RMethod r_R__0__cr_Int32;
		public virtual RMethod R__0__cr_Int32
		{
			get
			{
				if(r_R__0__cr_Int32 == null)
				{
					r_R__0__cr_Int32 = new(this, "#cr", 0, typeof(System.Int32));
					r_R__0__cr_Int32.SetBelong(this.instance);
				}
				return r_R__0__cr_Int32;
			}
		}

		/// <summary>
		/// #u.#Uq #dr()
		/// </summary>
		protected RMethod r_R__0__dr;
		public virtual RMethod R__0__dr
		{
			get
			{
				if(r_R__0__dr == null)
				{
					r_R__0__dr = new(this, "#dr", 0);
					r_R__0__dr.SetBelong(this.instance);
				}
				return r_R__0__dr;
			}
		}

		/// <summary>
		/// Boolean #er(System.String)
		/// </summary>
		protected RMethod r_R__0__er_String;
		public virtual RMethod R__0__er_String
		{
			get
			{
				if(r_R__0__er_String == null)
				{
					r_R__0__er_String = new(this, "#er", 0, typeof(System.String));
					r_R__0__er_String.SetBelong(this.instance);
				}
				return r_R__0__er_String;
			}
		}

		/// <summary>
		/// #u.#Uq #fr(Int32)
		/// </summary>
		protected RMethod r_R__0__fr_Int32;
		public virtual RMethod R__0__fr_Int32
		{
			get
			{
				if(r_R__0__fr_Int32 == null)
				{
					r_R__0__fr_Int32 = new(this, "#fr", 0, typeof(System.Int32));
					r_R__0__fr_Int32.SetBelong(this.instance);
				}
				return r_R__0__fr_Int32;
			}
		}

		/// <summary>
		/// #u.#Uq #gr()
		/// </summary>
		protected RMethod r_R__0__gr;
		public virtual RMethod R__0__gr
		{
			get
			{
				if(r_R__0__gr == null)
				{
					r_R__0__gr = new(this, "#gr", 0);
					r_R__0__gr.SetBelong(this.instance);
				}
				return r_R__0__gr;
			}
		}

		/// <summary>
		/// Boolean #hr(System.String)
		/// </summary>
		protected RMethod r_R__0__hr_String;
		public virtual RMethod R__0__hr_String
		{
			get
			{
				if(r_R__0__hr_String == null)
				{
					r_R__0__hr_String = new(this, "#hr", 0, typeof(System.String));
					r_R__0__hr_String.SetBelong(this.instance);
				}
				return r_R__0__hr_String;
			}
		}

		/// <summary>
		/// #u.#Uq #ir(Int32)
		/// </summary>
		protected RMethod r_R__0__ir_Int32;
		public virtual RMethod R__0__ir_Int32
		{
			get
			{
				if(r_R__0__ir_Int32 == null)
				{
					r_R__0__ir_Int32 = new(this, "#ir", 0, typeof(System.Int32));
					r_R__0__ir_Int32.SetBelong(this.instance);
				}
				return r_R__0__ir_Int32;
			}
		}

		/// <summary>
		/// Void #jr(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__jr_Object_ABLoadedArgs;
		public virtual RMethod R__0__jr_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__jr_Object_ABLoadedArgs == null)
				{
					r_R__0__jr_Object_ABLoadedArgs = new(this, "#jr", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__jr_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__jr_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void #kr(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__kr_Object_ABLoadedArgs;
		public virtual RMethod R__0__kr_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__kr_Object_ABLoadedArgs == null)
				{
					r_R__0__kr_Object_ABLoadedArgs = new(this, "#kr", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__kr_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__kr_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void #lr(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__lr_Object___0__7X;
		public virtual RMethod R__0__lr_Object___0__7X
		{
			get
			{
				if(r_R__0__lr_Object___0__7X == null)
				{
					r_R__0__lr_Object___0__7X = new(this, "#lr", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__lr_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__lr_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #eol()
		/// </summary>
		protected RMethod r_R__0__eol;
		public virtual RMethod R__0__eol
		{
			get
			{
				if(r_R__0__eol == null)
				{
					r_R__0__eol = new(this, "#eol", 0);
					r_R__0__eol.SetBelong(this.instance);
				}
				return r_R__0__eol;
			}
		}

		/// <summary>
		/// Void #SBc()
		/// </summary>
		protected RMethod r_R__0__SBc;
		public virtual RMethod R__0__SBc
		{
			get
			{
				if(r_R__0__SBc == null)
				{
					r_R__0__SBc = new(this, "#SBc", 0);
					r_R__0__SBc.SetBelong(this.instance);
				}
				return r_R__0__SBc;
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
		/// Void #3N(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__3N_Object___0__7X;
		public virtual RMethod R__0__3N_Object___0__7X
		{
			get
			{
				if(r_R__0__3N_Object___0__7X == null)
				{
					r_R__0__3N_Object___0__7X = new(this, "#3N", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__3N_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__3N_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Epf(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Epf_Object___0__7X;
		public virtual RMethod R__0__Epf_Object___0__7X
		{
			get
			{
				if(r_R__0__Epf_Object___0__7X == null)
				{
					r_R__0__Epf_Object___0__7X = new(this, "#Epf", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Epf_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Epf_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #Fpf(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__Fpf_Object___0__7X;
		public virtual RMethod R__0__Fpf_Object___0__7X
		{
			get
			{
				if(r_R__0__Fpf_Object___0__7X == null)
				{
					r_R__0__Fpf_Object___0__7X = new(this, "#Fpf", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__Fpf_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__Fpf_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #oq(System.Object, System.EventArgs)
		/// </summary>
		protected RMethod r_R__0__oq_Object_EventArgs;
		public virtual RMethod R__0__oq_Object_EventArgs
		{
			get
			{
				if(r_R__0__oq_Object_EventArgs == null)
				{
					r_R__0__oq_Object_EventArgs = new(this, "#oq", 0, typeof(System.Object), typeof(System.EventArgs));
					r_R__0__oq_Object_EventArgs.SetBelong(this.instance);
				}
				return r_R__0__oq_Object_EventArgs;
			}
		}

		/// <summary>
		/// Void #eRe()
		/// </summary>
		protected RMethod r_R__0__eRe;
		public virtual RMethod R__0__eRe
		{
			get
			{
				if(r_R__0__eRe == null)
				{
					r_R__0__eRe = new(this, "#eRe", 0);
					r_R__0__eRe.SetBelong(this.instance);
				}
				return r_R__0__eRe;
			}
		}

		/// <summary>
		/// Void #UXb()
		/// </summary>
		protected RMethod r_R__0__UXb;
		public virtual RMethod R__0__UXb
		{
			get
			{
				if(r_R__0__UXb == null)
				{
					r_R__0__UXb = new(this, "#UXb", 0);
					r_R__0__UXb.SetBelong(this.instance);
				}
				return r_R__0__UXb;
			}
		}

		/// <summary>
		/// Void #VXb(System.Object)
		/// </summary>
		protected RMethod r_R__0__VXb_Object;
		public virtual RMethod R__0__VXb_Object
		{
			get
			{
				if(r_R__0__VXb_Object == null)
				{
					r_R__0__VXb_Object = new(this, "#VXb", 0, typeof(System.Object));
					r_R__0__VXb_Object.SetBelong(this.instance);
				}
				return r_R__0__VXb_Object;
			}
		}

		/// <summary>
		/// Void #pr(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__pr_Object_Object;
		public virtual RMethod R__0__pr_Object_Object
		{
			get
			{
				if(r_R__0__pr_Object_Object == null)
				{
					r_R__0__pr_Object_Object = new(this, "#pr", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__pr_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__pr_Object_Object;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #qr()
		/// </summary>
		protected RMethod r_R__0__qr;
		public virtual RMethod R__0__qr
		{
			get
			{
				if(r_R__0__qr == null)
				{
					r_R__0__qr = new(this, "#qr", 0);
					r_R__0__qr.SetBelong(this.instance);
				}
				return r_R__0__qr;
			}
		}

		/// <summary>
		/// Void #sr(Int32)
		/// </summary>
		protected RMethod r_R__0__sr_Int32;
		public virtual RMethod R__0__sr_Int32
		{
			get
			{
				if(r_R__0__sr_Int32 == null)
				{
					r_R__0__sr_Int32 = new(this, "#sr", 0, typeof(System.Int32));
					r_R__0__sr_Int32.SetBelong(this.instance);
				}
				return r_R__0__sr_Int32;
			}
		}

		/// <summary>
		/// Void #OYd(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__OYd_Object___0__7X;
		public virtual RMethod R__0__OYd_Object___0__7X
		{
			get
			{
				if(r_R__0__OYd_Object___0__7X == null)
				{
					r_R__0__OYd_Object___0__7X = new(this, "#OYd", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__OYd_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__OYd_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #tr(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__tr_Object_Object;
		public virtual RMethod R__0__tr_Object_Object
		{
			get
			{
				if(r_R__0__tr_Object_Object == null)
				{
					r_R__0__tr_Object_Object = new(this, "#tr", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__tr_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__tr_Object_Object;
			}
		}

		/// <summary>
		/// Void #iod()
		/// </summary>
		protected RMethod r_R__0__iod;
		public virtual RMethod R__0__iod
		{
			get
			{
				if(r_R__0__iod == null)
				{
					r_R__0__iod = new(this, "#iod", 0);
					r_R__0__iod.SetBelong(this.instance);
				}
				return r_R__0__iod;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetWorldPosViaUI()
		/// </summary>
		protected RMethod r_RGetWorldPosViaUI;
		public virtual RMethod RGetWorldPosViaUI
		{
			get
			{
				if(r_RGetWorldPosViaUI == null)
				{
					r_RGetWorldPosViaUI = new(this, "GetWorldPosViaUI", 0);
					r_RGetWorldPosViaUI.SetBelong(this.instance);
				}
				return r_RGetWorldPosViaUI;
			}
		}

		/// <summary>
		/// Void OnMouseUp(DragPrefab)
		/// </summary>
		protected RMethod r_ROnMouseUp_DragPrefab;
		public virtual RMethod ROnMouseUp_DragPrefab
		{
			get
			{
				if(r_ROnMouseUp_DragPrefab == null)
				{
					r_ROnMouseUp_DragPrefab = new(this, "OnMouseUp", 0,  ReleactionUtils.GetType("DragPrefab"));
					r_ROnMouseUp_DragPrefab.SetBelong(this.instance);
				}
				return r_ROnMouseUp_DragPrefab;
			}
		}

		/// <summary>
		/// Void #ur(DragPrefab)
		/// </summary>
		protected RMethod r_R__0__ur_DragPrefab;
		public virtual RMethod R__0__ur_DragPrefab
		{
			get
			{
				if(r_R__0__ur_DragPrefab == null)
				{
					r_R__0__ur_DragPrefab = new(this, "#ur", 0,  ReleactionUtils.GetType("DragPrefab"));
					r_R__0__ur_DragPrefab.SetBelong(this.instance);
				}
				return r_R__0__ur_DragPrefab;
			}
		}

		/// <summary>
		/// Void #vr(Int32, Int32, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__vr_Int32_Int32_Vector2;
		public virtual RMethod R__0__vr_Int32_Int32_Vector2
		{
			get
			{
				if(r_R__0__vr_Int32_Int32_Vector2 == null)
				{
					r_R__0__vr_Int32_Int32_Vector2 = new(this, "#vr", 0, typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Vector2));
					r_R__0__vr_Int32_Int32_Vector2.SetBelong(this.instance);
				}
				return r_R__0__vr_Int32_Int32_Vector2;
			}
		}

		/// <summary>
		/// Void #vr(DragPrefab)
		/// </summary>
		protected RMethod r_R__0__vr_DragPrefab;
		public virtual RMethod R__0__vr_DragPrefab
		{
			get
			{
				if(r_R__0__vr_DragPrefab == null)
				{
					r_R__0__vr_DragPrefab = new(this, "#vr", 0,  ReleactionUtils.GetType("DragPrefab"));
					r_R__0__vr_DragPrefab.SetBelong(this.instance);
				}
				return r_R__0__vr_DragPrefab;
			}
		}

		/// <summary>
		/// Void #wr(DragPrefab)
		/// </summary>
		protected RMethod r_R__0__wr_DragPrefab;
		public virtual RMethod R__0__wr_DragPrefab
		{
			get
			{
				if(r_R__0__wr_DragPrefab == null)
				{
					r_R__0__wr_DragPrefab = new(this, "#wr", 0,  ReleactionUtils.GetType("DragPrefab"));
					r_R__0__wr_DragPrefab.SetBelong(this.instance);
				}
				return r_R__0__wr_DragPrefab;
			}
		}

		/// <summary>
		/// Void OnMouseDoubleDown(DragPrefab)
		/// </summary>
		protected RMethod r_ROnMouseDoubleDown_DragPrefab;
		public virtual RMethod ROnMouseDoubleDown_DragPrefab
		{
			get
			{
				if(r_ROnMouseDoubleDown_DragPrefab == null)
				{
					r_ROnMouseDoubleDown_DragPrefab = new(this, "OnMouseDoubleDown", 0,  ReleactionUtils.GetType("DragPrefab"));
					r_ROnMouseDoubleDown_DragPrefab.SetBelong(this.instance);
				}
				return r_ROnMouseDoubleDown_DragPrefab;
			}
		}

		/// <summary>
		/// Void #QYd()
		/// </summary>
		protected RMethod r_R__0__QYd;
		public virtual RMethod R__0__QYd
		{
			get
			{
				if(r_R__0__QYd == null)
				{
					r_R__0__QYd = new(this, "#QYd", 0);
					r_R__0__QYd.SetBelong(this.instance);
				}
				return r_R__0__QYd;
			}
		}

		/// <summary>
		/// #u.#Uq #xr(DragPrefab, Int32, Boolean)
		/// </summary>
		protected RMethod r_R__0__xr_DragPrefab_Int32_Boolean;
		public virtual RMethod R__0__xr_DragPrefab_Int32_Boolean
		{
			get
			{
				if(r_R__0__xr_DragPrefab_Int32_Boolean == null)
				{
					r_R__0__xr_DragPrefab_Int32_Boolean = new(this, "#xr", 0,  ReleactionUtils.GetType("DragPrefab"), typeof(System.Int32), typeof(System.Boolean));
					r_R__0__xr_DragPrefab_Int32_Boolean.SetBelong(this.instance);
				}
				return r_R__0__xr_DragPrefab_Int32_Boolean;
			}
		}

		/// <summary>
		/// #u.#Uq #yr(System.String)
		/// </summary>
		protected RMethod r_R__0__yr_String;
		public virtual RMethod R__0__yr_String
		{
			get
			{
				if(r_R__0__yr_String == null)
				{
					r_R__0__yr_String = new(this, "#yr", 0, typeof(System.String));
					r_R__0__yr_String.SetBelong(this.instance);
				}
				return r_R__0__yr_String;
			}
		}

		/// <summary>
		/// Void #zr(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__zr_ID;
		public virtual RMethod R__0__zr_ID
		{
			get
			{
				if(r_R__0__zr_ID == null)
				{
					r_R__0__zr_ID = new(this, "#zr", 0, typeof(GameDefineType.ID));
					r_R__0__zr_ID.SetBelong(this.instance);
				}
				return r_R__0__zr_ID;
			}
		}

		/// <summary>
		/// Void #fol(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__fol_Object___0__7X;
		public virtual RMethod R__0__fol_Object___0__7X
		{
			get
			{
				if(r_R__0__fol_Object___0__7X == null)
				{
					r_R__0__fol_Object___0__7X = new(this, "#fol", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__fol_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__fol_Object___0__7X;
			}
		}

		/// <summary>
		/// #u.#Uq #Br()
		/// </summary>
		protected RMethod r_R__0__Br;
		public virtual RMethod R__0__Br
		{
			get
			{
				if(r_R__0__Br == null)
				{
					r_R__0__Br = new(this, "#Br", 0);
					r_R__0__Br.SetBelong(this.instance);
				}
				return r_R__0__Br;
			}
		}

		/// <summary>
		/// #u.#Uq #Br(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Br_ID;
		public virtual RMethod R__0__Br_ID
		{
			get
			{
				if(r_R__0__Br_ID == null)
				{
					r_R__0__Br_ID = new(this, "#Br", 0, typeof(GameDefineType.ID));
					r_R__0__Br_ID.SetBelong(this.instance);
				}
				return r_R__0__Br_ID;
			}
		}

		/// <summary>
		/// #u.#Uq #Cr()
		/// </summary>
		protected RMethod r_R__0__Cr;
		public virtual RMethod R__0__Cr
		{
			get
			{
				if(r_R__0__Cr == null)
				{
					r_R__0__Cr = new(this, "#Cr", 0);
					r_R__0__Cr.SetBelong(this.instance);
				}
				return r_R__0__Cr;
			}
		}

		/// <summary>
		/// Boolean #Dr()
		/// </summary>
		protected RMethod r_R__0__Dr;
		public virtual RMethod R__0__Dr
		{
			get
			{
				if(r_R__0__Dr == null)
				{
					r_R__0__Dr = new(this, "#Dr", 0);
					r_R__0__Dr.SetBelong(this.instance);
				}
				return r_R__0__Dr;
			}
		}

		/// <summary>
		/// UnityEngine.Camera #Er()
		/// </summary>
		protected RMethod r_R__0__Er;
		public virtual RMethod R__0__Er
		{
			get
			{
				if(r_R__0__Er == null)
				{
					r_R__0__Er = new(this, "#Er", 0);
					r_R__0__Er.SetBelong(this.instance);
				}
				return r_R__0__Er;
			}
		}

		/// <summary>
		/// Void #Fr(Boolean)
		/// </summary>
		protected RMethod r_R__0__Fr_Boolean;
		public virtual RMethod R__0__Fr_Boolean
		{
			get
			{
				if(r_R__0__Fr_Boolean == null)
				{
					r_R__0__Fr_Boolean = new(this, "#Fr", 0, typeof(System.Boolean));
					r_R__0__Fr_Boolean.SetBelong(this.instance);
				}
				return r_R__0__Fr_Boolean;
			}
		}

		/// <summary>
		/// Void #Fr(Boolean, Int32)
		/// </summary>
		protected RMethod r_R__0__Fr_Boolean_Int32;
		public virtual RMethod R__0__Fr_Boolean_Int32
		{
			get
			{
				if(r_R__0__Fr_Boolean_Int32 == null)
				{
					r_R__0__Fr_Boolean_Int32 = new(this, "#Fr", 0, typeof(System.Boolean), typeof(System.Int32));
					r_R__0__Fr_Boolean_Int32.SetBelong(this.instance);
				}
				return r_R__0__Fr_Boolean_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #Gr(GameDefineType.ID, Boolean, UnityEngine.Vector3, Int32)
		/// </summary>
		protected RMethod r_R__0__Gr_ID_Boolean_Vector3_Int32;
		public virtual RMethod R__0__Gr_ID_Boolean_Vector3_Int32
		{
			get
			{
				if(r_R__0__Gr_ID_Boolean_Vector3_Int32 == null)
				{
					r_R__0__Gr_ID_Boolean_Vector3_Int32 = new(this, "#Gr", 0, typeof(GameDefineType.ID), typeof(System.Boolean), typeof(UnityEngine.Vector3), typeof(System.Int32));
					r_R__0__Gr_ID_Boolean_Vector3_Int32.SetBelong(this.instance);
				}
				return r_R__0__Gr_ID_Boolean_Vector3_Int32;
			}
		}

		/// <summary>
		/// Void #vGn(System.Object, System.Object)
		/// </summary>
		protected RMethod r_R__0__vGn_Object_Object;
		public virtual RMethod R__0__vGn_Object_Object
		{
			get
			{
				if(r_R__0__vGn_Object_Object == null)
				{
					r_R__0__vGn_Object_Object = new(this, "#vGn", 0, typeof(System.Object), typeof(System.Object));
					r_R__0__vGn_Object_Object.SetBelong(this.instance);
				}
				return r_R__0__vGn_Object_Object;
			}
		}

		/// <summary>
		/// Void #wGn()
		/// </summary>
		protected RMethod r_R__0__wGn;
		public virtual RMethod R__0__wGn
		{
			get
			{
				if(r_R__0__wGn == null)
				{
					r_R__0__wGn = new(this, "#wGn", 0);
					r_R__0__wGn.SetBelong(this.instance);
				}
				return r_R__0__wGn;
			}
		}

		/// <summary>
		/// Void #aiq(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__aiq_Object___0__7X;
		public virtual RMethod R__0__aiq_Object___0__7X
		{
			get
			{
				if(r_R__0__aiq_Object___0__7X == null)
				{
					r_R__0__aiq_Object___0__7X = new(this, "#aiq", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__aiq_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__aiq_Object___0__7X;
			}
		}

		/// <summary>
		/// GameDefineType.ID #Piq(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Piq_ID;
		public virtual RMethod R__0__Piq_ID
		{
			get
			{
				if(r_R__0__Piq_ID == null)
				{
					r_R__0__Piq_ID = new(this, "#Piq", 0, typeof(GameDefineType.ID));
					r_R__0__Piq_ID.SetBelong(this.instance);
				}
				return r_R__0__Piq_ID;
			}
		}

		/// <summary>
		/// Void #biq(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__biq_Object___0__7X;
		public virtual RMethod R__0__biq_Object___0__7X
		{
			get
			{
				if(r_R__0__biq_Object___0__7X == null)
				{
					r_R__0__biq_Object___0__7X = new(this, "#biq", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__biq_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__biq_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #5Br(#Pfb.#tDr, System.Collections.Generic.Dictionary`2[System.Int32,#u.#fCr+#gCr])
		/// </summary>
		protected RMethod r_R__0__5Br___0__tDr_Dictionary_d_Int32___0__gCr_p_;
		public virtual RMethod R__0__5Br___0__tDr_Dictionary_d_Int32___0__gCr_p_
		{
			get
			{
				if(r_R__0__5Br___0__tDr_Dictionary_d_Int32___0__gCr_p_ == null)
				{
					r_R__0__5Br___0__tDr_Dictionary_d_Int32___0__gCr_p_ = new(this, "#5Br", 0,  ReleactionUtils.GetType("#Pfb.#tDr"), typeof(System.Collections.Generic.Dictionary<, >).MakeGenericType(typeof(System.Int32),  ReleactionUtils.GetType("#u.#fCr+#gCr")));
					r_R__0__5Br___0__tDr_Dictionary_d_Int32___0__gCr_p_.SetBelong(this.instance);
				}
				return r_R__0__5Br___0__tDr_Dictionary_d_Int32___0__gCr_p_;
			}
		}

		/// <summary>
		/// Void #6Br(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__6Br_Object___0__7X;
		public virtual RMethod R__0__6Br_Object___0__7X
		{
			get
			{
				if(r_R__0__6Br_Object___0__7X == null)
				{
					r_R__0__6Br_Object___0__7X = new(this, "#6Br", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__6Br_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__6Br_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #7Br(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__7Br_Object___0__7X;
		public virtual RMethod R__0__7Br_Object___0__7X
		{
			get
			{
				if(r_R__0__7Br_Object___0__7X == null)
				{
					r_R__0__7Br_Object___0__7X = new(this, "#7Br", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__7Br_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__7Br_Object___0__7X;
			}
		}

		/// <summary>
		/// Int32 #8Br(GameDefineType.ID[], GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__8Br_IDArray_ID;
		public virtual RMethod R__0__8Br_IDArray_ID
		{
			get
			{
				if(r_R__0__8Br_IDArray_ID == null)
				{
					r_R__0__8Br_IDArray_ID = new(this, "#8Br", 0, typeof(GameDefineType.ID).MakeArrayType(), typeof(GameDefineType.ID));
					r_R__0__8Br_IDArray_ID.SetBelong(this.instance);
				}
				return r_R__0__8Br_IDArray_ID;
			}
		}

		/// <summary>
		/// Void #9Br(#Pfb.#tDr)
		/// </summary>
		protected RMethod r_R__0__9Br___0__tDr;
		public virtual RMethod R__0__9Br___0__tDr
		{
			get
			{
				if(r_R__0__9Br___0__tDr == null)
				{
					r_R__0__9Br___0__tDr = new(this, "#9Br", 0,  ReleactionUtils.GetType("#Pfb.#tDr"));
					r_R__0__9Br___0__tDr.SetBelong(this.instance);
				}
				return r_R__0__9Br___0__tDr;
			}
		}

		/// <summary>
		/// Void #aCr(Int32)
		/// </summary>
		protected RMethod r_R__0__aCr_Int32;
		public virtual RMethod R__0__aCr_Int32
		{
			get
			{
				if(r_R__0__aCr_Int32 == null)
				{
					r_R__0__aCr_Int32 = new(this, "#aCr", 0, typeof(System.Int32));
					r_R__0__aCr_Int32.SetBelong(this.instance);
				}
				return r_R__0__aCr_Int32;
			}
		}

		/// <summary>
		/// Void #XEr()
		/// </summary>
		protected RMethod r_R__0__XEr;
		public virtual RMethod R__0__XEr
		{
			get
			{
				if(r_R__0__XEr == null)
				{
					r_R__0__XEr = new(this, "#XEr", 0);
					r_R__0__XEr.SetBelong(this.instance);
				}
				return r_R__0__XEr;
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


        public RMyGUIFormationWnd() : base("MyGUIFormationWnd")
        {
        }

        public RMyGUIFormationWnd(System.Object instance) : base("MyGUIFormationWnd")
		{
            SetInstance(instance);
		}

        public RMyGUIFormationWnd(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RMyGUIFormationWnd(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Init()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInit.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Fo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Fo.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Xq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Xq.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Yq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Yq.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__qGn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__qGn.Invoke(___genericsType, ___parameters);

            
        }


        public virtual shenshouItem __0__VNc(GameDefineType.ID[]  @runes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@runes};
            var ___result = R__0__VNc_IDArray.Invoke(___genericsType, ___parameters);

            return (shenshouItem)___result;
        }


        public virtual void __0__col()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__col.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__dol()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__dol.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void __0__Zq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Zq.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Collections.IEnumerator __0__tn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__tn.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__1q()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__1q.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<GameDefineType.ID> __0__QEg()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__QEg.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }


        public virtual System.Int32 __0__2q()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__2q.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean __0__3q(GameDefineType.ID  @idPet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idPet};
            var ___result = R__0__3q_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual System.Int32 __0__5q(GameDefineType.ID  @idPet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idPet};
            var ___result = R__0__5q_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void __0__Eiq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Eiq.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<GameDefineType.ID> __0__OPv()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__OPv.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }


        public virtual System.Collections.Generic.List<GameDefineType.ID> __0__Fiq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Fiq.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<GameDefineType.ID>)___result;
        }


        public virtual System.Object __0__Giq(GameDefineType.ID  @careerId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerId};
            var ___result = R__0__Giq_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__Hiq(System.Collections.Generic.List<GameDefineType.ID>  @listCombineSkill)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@listCombineSkill};
            var ___result = R__0__Hiq_List_d_ID_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__7q()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__7q.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean __0__8q(GameDefineType.ID  @_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_id};
            var ___result = R__0__8q_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean __0__TXb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__TXb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__9q(System.Int32  @index, GameDefineType.ID  @_id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index, @_id};
            var ___result = R__0__9q_Int32_ID.Invoke(___genericsType, ___parameters);

            
        }




        public virtual System.Boolean __0__br(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = R__0__br_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object __0__cr(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = R__0__cr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__dr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__dr.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean __0__er(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = R__0__er_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object __0__fr(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = R__0__fr_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__gr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__gr.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean __0__hr(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = R__0__hr_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Object __0__ir(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = R__0__ir_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }





        public virtual void __0__eol()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__eol.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__SBc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__SBc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__sb(System.Boolean  @show)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@show};
            var ___result = R__0__sb_Boolean.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__oq(System.Object  @sender, System.EventArgs  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sender, @e};
            var ___result = R__0__oq_Object_EventArgs.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__eRe()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__eRe.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__UXb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__UXb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__VXb(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__VXb_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__pr(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__pr_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__qr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__qr.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__sr(System.Int32  @m_CurrentMatrixLev)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@m_CurrentMatrixLev};
            var ___result = R__0__sr_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void __0__tr(System.Object  @oldValue, System.Object  @newValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldValue, @newValue};
            var ___result = R__0__tr_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__iod()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__iod.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 GetWorldPosViaUI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWorldPosViaUI.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }




        public virtual void __0__vr(System.Int32  @rune, System.Int32  @runeLv, UnityEngine.Vector2  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rune, @runeLv, @pos};
            var ___result = R__0__vr_Int32_Int32_Vector2.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__QYd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__QYd.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object __0__yr(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = R__0__yr_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void __0__zr(GameDefineType.ID  @idPet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idPet};
            var ___result = R__0__zr_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object __0__Br()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Br.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Br(GameDefineType.ID  @petId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@petId};
            var ___result = R__0__Br_ID.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object __0__Cr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Cr.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean __0__Dr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Dr.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Camera __0__Er()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Er.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Camera)___result;
        }


        public virtual void __0__Fr(System.Boolean  @bl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl};
            var ___result = R__0__Fr_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Fr(System.Boolean  @bl, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bl, @index};
            var ___result = R__0__Fr_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__Gr(GameDefineType.ID  @_id, System.Boolean  @isOn, UnityEngine.Vector3  @position, System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@_id, @isOn, @position, @index};
            var ___result = R__0__Gr_ID_Boolean_Vector3_Int32.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__vGn(System.Object  @oldval, System.Object  @newval)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@oldval, @newval};
            var ___result = R__0__vGn_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__wGn()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__wGn.Invoke(___genericsType, ___parameters);

            
        }



        public virtual GameDefineType.ID __0__Piq(GameDefineType.ID  @combineSkillId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combineSkillId};
            var ___result = R__0__Piq_ID.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }






        public virtual System.Int32 __0__8Br(GameDefineType.ID[]  @matrixIDs, GameDefineType.ID  @idPet)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@matrixIDs, @idPet};
            var ___result = R__0__8Br_IDArray_ID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual void __0__aCr(System.Int32  @hp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@hp};
            var ___result = R__0__aCr_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__XEr()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__XEr.Invoke(___genericsType, ___parameters);

            
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


        public virtual void Update()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUpdate.Invoke(___genericsType, ___parameters);

            
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


        public virtual void __0__Abb(System.String  @paramstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramstr};
            var ___result = R__0__Abb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__lBn(System.String  @paramstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@paramstr};
            var ___result = R__0__lBn_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__lVe(System.Object  @data)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data};
            var ___result = R__0__lVe_Object.Invoke(___genericsType, ___parameters);

            
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
