using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// XJCard
	/// </summary>
    public partial class RXJCard : RMember //
    {

		/// <summary>
		/// #oU.#5bb #a
		/// </summary>
		protected R__0__oU.R__0__5bb r___0__a;
		public virtual R__0__oU.R__0__5bb R__0__a
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
		/// #u.#Ckb #b
		/// </summary>
		protected R__0__u.R__0__Ckb r___0__b;
		public virtual R__0__u.R__0__Ckb R__0__b
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
		/// GameDefineType.ID #c
		/// </summary>
		protected RGameDefineType.RID r___0__c;
		public virtual RGameDefineType.RID R__0__c
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
		/// System.Boolean #f
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
		/// System.Boolean #g
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
		/// UnityEngine.Vector2 #h
		/// </summary>
		protected RUnityEngine.RVector2 r___0__h;
		public virtual RUnityEngine.RVector2 R__0__h
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
		/// System.Boolean #i
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
		/// System.Single #j
		/// </summary>
		protected static RField r___0__j;
		public static RField R__0__j
		{
			get
			{
				if(r___0__j == null)
				{
					r___0__j = new( ReleactionUtils.GetType("XJCard"), "#j");
					r___0__j.SetBelong(null);
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
		/// System.String #l
		/// </summary>
		protected static RField r___0__l;
		public static RField R__0__l
		{
			get
			{
				if(r___0__l == null)
				{
					r___0__l = new( ReleactionUtils.GetType("XJCard"), "#l");
					r___0__l.SetBelong(null);
				}
				return r___0__l;
			}
		}

		/// <summary>
		/// System.String #m
		/// </summary>
		protected static RField r___0__m;
		public static RField R__0__m
		{
			get
			{
				if(r___0__m == null)
				{
					r___0__m = new( ReleactionUtils.GetType("XJCard"), "#m");
					r___0__m.SetBelong(null);
				}
				return r___0__m;
			}
		}

		/// <summary>
		/// XJCard+SelectType #n
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
		/// System.Boolean #o
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
		/// Int32 CardIndex
		/// </summary>
		protected RProperty r_R__0__84d;
		public virtual RProperty R__0__84d
		{
			get
			{
				if(r_R__0__84d == null)
				{
					r_R__0__84d = new(this, "CardIndex", -1);
					r_R__0__84d.SetBelong(this.instance);
				}
				return r_R__0__84d;
			}
		}

		/// <summary>
		/// Boolean IsClick
		/// </summary>
		protected RProperty r_R__0__Ld;
		public virtual RProperty R__0__Ld
		{
			get
			{
				if(r_R__0__Ld == null)
				{
					r_R__0__Ld = new(this, "IsClick", -1);
					r_R__0__Ld.SetBelong(this.instance);
				}
				return r_R__0__Ld;
			}
		}

		/// <summary>
		/// Boolean CardFixed
		/// </summary>
		protected RProperty r_R__0__94d;
		public virtual RProperty R__0__94d
		{
			get
			{
				if(r_R__0__94d == null)
				{
					r_R__0__94d = new(this, "CardFixed", -1);
					r_R__0__94d.SetBelong(this.instance);
				}
				return r_R__0__94d;
			}
		}

		/// <summary>
		/// Boolean MoveUp
		/// </summary>
		protected RProperty r_R__0__c5d;
		public virtual RProperty R__0__c5d
		{
			get
			{
				if(r_R__0__c5d == null)
				{
					r_R__0__c5d = new(this, "MoveUp", -1);
					r_R__0__c5d.SetBelong(this.instance);
				}
				return r_R__0__c5d;
			}
		}

		/// <summary>
		/// Void #74d(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__74d_ID;
		public virtual RMethod R__0__74d_ID
		{
			get
			{
				if(r_R__0__74d_ID == null)
				{
					r_R__0__74d_ID = new(this, "#74d", 0, typeof(GameDefineType.ID));
					r_R__0__74d_ID.SetBelong(this.instance);
				}
				return r_R__0__74d_ID;
			}
		}

		/// <summary>
		/// Void SetPosition(UnityEngine.Vector2, Single)
		/// </summary>
		protected RMethod r_RSetPosition_Vector2_Single;
		public virtual RMethod RSetPosition_Vector2_Single
		{
			get
			{
				if(r_RSetPosition_Vector2_Single == null)
				{
					r_RSetPosition_Vector2_Single = new(this, "SetPosition", 0, typeof(UnityEngine.Vector2), typeof(System.Single));
					r_RSetPosition_Vector2_Single.SetBelong(this.instance);
				}
				return r_RSetPosition_Vector2_Single;
			}
		}

		/// <summary>
		/// Void #ADd(UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_R__0__ADd_Vector2;
		public virtual RMethod R__0__ADd_Vector2
		{
			get
			{
				if(r_R__0__ADd_Vector2 == null)
				{
					r_R__0__ADd_Vector2 = new(this, "#ADd", 0, typeof(UnityEngine.Vector2));
					r_R__0__ADd_Vector2.SetBelong(this.instance);
				}
				return r_R__0__ADd_Vector2;
			}
		}

		/// <summary>
		/// Void SetState(Boolean)
		/// </summary>
		protected RMethod r_RSetState_Boolean;
		public virtual RMethod RSetState_Boolean
		{
			get
			{
				if(r_RSetState_Boolean == null)
				{
					r_RSetState_Boolean = new(this, "SetState", 0, typeof(System.Boolean));
					r_RSetState_Boolean.SetBelong(this.instance);
				}
				return r_RSetState_Boolean;
			}
		}

		/// <summary>
		/// Void SetVisible(Boolean)
		/// </summary>
		protected RMethod r_RSetVisible_Boolean;
		public virtual RMethod RSetVisible_Boolean
		{
			get
			{
				if(r_RSetVisible_Boolean == null)
				{
					r_RSetVisible_Boolean = new(this, "SetVisible", 0, typeof(System.Boolean));
					r_RSetVisible_Boolean.SetBelong(this.instance);
				}
				return r_RSetVisible_Boolean;
			}
		}

		/// <summary>
		/// Void #d5d(Boolean)
		/// </summary>
		protected RMethod r_R__0__d5d_Boolean;
		public virtual RMethod R__0__d5d_Boolean
		{
			get
			{
				if(r_R__0__d5d_Boolean == null)
				{
					r_R__0__d5d_Boolean = new(this, "#d5d", 0, typeof(System.Boolean));
					r_R__0__d5d_Boolean.SetBelong(this.instance);
				}
				return r_R__0__d5d_Boolean;
			}
		}

		/// <summary>
		/// Boolean #e5d()
		/// </summary>
		protected RMethod r_R__0__e5d;
		public virtual RMethod R__0__e5d
		{
			get
			{
				if(r_R__0__e5d == null)
				{
					r_R__0__e5d = new(this, "#e5d", 0);
					r_R__0__e5d.SetBelong(this.instance);
				}
				return r_R__0__e5d;
			}
		}

		/// <summary>
		/// Void #f5d(UnityEngine.GameObject)
		/// </summary>
		protected RMethod r_R__0__f5d_GameObject;
		public virtual RMethod R__0__f5d_GameObject
		{
			get
			{
				if(r_R__0__f5d_GameObject == null)
				{
					r_R__0__f5d_GameObject = new(this, "#f5d", 0, typeof(UnityEngine.GameObject));
					r_R__0__f5d_GameObject.SetBelong(this.instance);
				}
				return r_R__0__f5d_GameObject;
			}
		}

		/// <summary>
		/// Void #g5d(SelectType)
		/// </summary>
		protected RMethod r_R__0__g5d_SelectType;
		public virtual RMethod R__0__g5d_SelectType
		{
			get
			{
				if(r_R__0__g5d_SelectType == null)
				{
					r_R__0__g5d_SelectType = new(this, "#g5d", 0,  ReleactionUtils.GetType("XJCard+SelectType"));
					r_R__0__g5d_SelectType.SetBelong(this.instance);
				}
				return r_R__0__g5d_SelectType;
			}
		}

		/// <summary>
		/// System.String #l1b(Int32)
		/// </summary>
		protected static RMethod r_R__0__l1b_Int32;
		public static RMethod R__0__l1b_Int32
		{
			get
			{
				if(r_R__0__l1b_Int32 == null)
				{
					r_R__0__l1b_Int32 = new( ReleactionUtils.GetType("XJCard"), "#l1b", 0, typeof(System.Int32));
					r_R__0__l1b_Int32.SetBelong(null);
				}
				return r_R__0__l1b_Int32;
			}
		}

		/// <summary>
		/// Void #Id()
		/// </summary>
		protected RMethod r_R__0__Id;
		public virtual RMethod R__0__Id
		{
			get
			{
				if(r_R__0__Id == null)
				{
					r_R__0__Id = new(this, "#Id", 0);
					r_R__0__Id.SetBelong(this.instance);
				}
				return r_R__0__Id;
			}
		}

		/// <summary>
		/// Void #h5d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__h5d_Object___0__7X;
		public virtual RMethod R__0__h5d_Object___0__7X
		{
			get
			{
				if(r_R__0__h5d_Object___0__7X == null)
				{
					r_R__0__h5d_Object___0__7X = new(this, "#h5d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__h5d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__h5d_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #i5d(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__i5d_Object___0__7X;
		public virtual RMethod R__0__i5d_Object___0__7X
		{
			get
			{
				if(r_R__0__i5d_Object___0__7X == null)
				{
					r_R__0__i5d_Object___0__7X = new(this, "#i5d", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__i5d_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__i5d_Object___0__7X;
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


        public RXJCard() : base("XJCard")
        {
        }

        public RXJCard(System.Object instance) : base("XJCard")
		{
            SetInstance(instance);
		}

        public RXJCard(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXJCard(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__74d(GameDefineType.ID  @configid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@configid};
            var ___result = R__0__74d_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetPosition(UnityEngine.Vector2  @tarpos, System.Single  @_time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tarpos, @_time};
            var ___result = RSetPosition_Vector2_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ADd(UnityEngine.Vector2  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = R__0__ADd_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetState(System.Boolean  @state)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@state};
            var ___result = RSetState_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetVisible(System.Boolean  @bshow)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bshow};
            var ___result = RSetVisible_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__d5d(System.Boolean  @select)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@select};
            var ___result = R__0__d5d_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__e5d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__e5d.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void __0__f5d(UnityEngine.GameObject  @ojt)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ojt};
            var ___result = R__0__f5d_GameObject.Invoke(___genericsType, ___parameters);

            
        }



        public static System.String __0__l1b(System.Int32  @rare)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rare};
            var ___result = R__0__l1b_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void __0__Id()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Id.Invoke(___genericsType, ___parameters);

            
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
