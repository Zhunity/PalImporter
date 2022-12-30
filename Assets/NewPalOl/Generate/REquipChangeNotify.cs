using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// EquipChangeNotify
	/// </summary>
    public partial class REquipChangeNotify : RMember //
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
					r___0__a = new( ReleactionUtils.GetType("EquipChangeNotify"), "#a");
					r___0__a.SetBelong(null);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// EquipChangeNotify+#wjb #b
		/// </summary>
		protected REquipChangeNotify.R__0__wjb r___0__b;
		public virtual REquipChangeNotify.R__0__wjb R__0__b
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
		/// System.Single #c
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
		/// System.Boolean #d
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,System.Collections.Generic.Dictionary`2[System.Byte,EquipChangeNotify+#wjb]] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RField, REquipChangeNotify.R__0__wjb>> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RSystem.RCollections.RGeneric.RDictionary<RField, REquipChangeNotify.R__0__wjb>> R__0__e
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
		/// System.Array #f
		/// </summary>
		protected RSystem.RArray r___0__f;
		public virtual RSystem.RArray R__0__f
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
		/// System.Single #g
		/// </summary>
		protected static RField r___0__g;
		public static RField R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new( ReleactionUtils.GetType("EquipChangeNotify"), "#g");
					r___0__g.SetBelong(null);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// System.Single #h
		/// </summary>
		protected static RField r___0__h;
		public static RField R__0__h
		{
			get
			{
				if(r___0__h == null)
				{
					r___0__h = new( ReleactionUtils.GetType("EquipChangeNotify"), "#h");
					r___0__h.SetBelong(null);
				}
				return r___0__h;
			}
		}

		/// <summary>
		/// System.Single #i
		/// </summary>
		protected static RField r___0__i;
		public static RField R__0__i
		{
			get
			{
				if(r___0__i == null)
				{
					r___0__i = new( ReleactionUtils.GetType("EquipChangeNotify"), "#i");
					r___0__i.SetBelong(null);
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
					r___0__j = new( ReleactionUtils.GetType("EquipChangeNotify"), "#j");
					r___0__j.SetBelong(null);
				}
				return r___0__j;
			}
		}

		/// <summary>
		/// System.Single #k
		/// </summary>
		protected static RField r___0__k;
		public static RField R__0__k
		{
			get
			{
				if(r___0__k == null)
				{
					r___0__k = new( ReleactionUtils.GetType("EquipChangeNotify"), "#k");
					r___0__k.SetBelong(null);
				}
				return r___0__k;
			}
		}

		/// <summary>
		/// System.Single #l
		/// </summary>
		protected static RField r___0__l;
		public static RField R__0__l
		{
			get
			{
				if(r___0__l == null)
				{
					r___0__l = new( ReleactionUtils.GetType("EquipChangeNotify"), "#l");
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
					r___0__m = new( ReleactionUtils.GetType("EquipChangeNotify"), "#m");
					r___0__m.SetBelong(null);
				}
				return r___0__m;
			}
		}

		/// <summary>
		/// System.String #n
		/// </summary>
		protected static RField r___0__n;
		public static RField R__0__n
		{
			get
			{
				if(r___0__n == null)
				{
					r___0__n = new( ReleactionUtils.GetType("EquipChangeNotify"), "#n");
					r___0__n.SetBelong(null);
				}
				return r___0__n;
			}
		}

		/// <summary>
		/// System.Single #o
		/// </summary>
		protected static RField r___0__o;
		public static RField R__0__o
		{
			get
			{
				if(r___0__o == null)
				{
					r___0__o = new( ReleactionUtils.GetType("EquipChangeNotify"), "#o");
					r___0__o.SetBelong(null);
				}
				return r___0__o;
			}
		}

		/// <summary>
		/// System.Int32 #p
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
		/// System.Int32 #q
		/// </summary>
		protected RField r___0__q;
		public virtual RField R__0__q
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
		/// UnityEngine.GUISkin #r
		/// </summary>
		protected RUnityEngine.RGUISkin r___0__r;
		public virtual RUnityEngine.RGUISkin R__0__r
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
		/// UnityEngine.Color #s
		/// </summary>
		protected RUnityEngine.RColor r___0__s;
		public virtual RUnityEngine.RColor R__0__s
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
		/// UnityEngine.Color #t
		/// </summary>
		protected RUnityEngine.RColor r___0__t;
		public virtual RUnityEngine.RColor R__0__t
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
		/// UnityEngine.GUIStyle #u
		/// </summary>
		protected RUnityEngine.RGUIStyle r___0__u;
		public virtual RUnityEngine.RGUIStyle R__0__u
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
		/// UnityEngine.GUIStyle mPopTextGUIStyle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_mPopTextGUIStyle;
		public virtual RUnityEngine.RGUIStyle RmPopTextGUIStyle
		{
			get
			{
				if(r_mPopTextGUIStyle == null)
				{
					r_mPopTextGUIStyle = new(this, "mPopTextGUIStyle", -1);
					r_mPopTextGUIStyle.SetBelong(this.instance);
				}
				return r_mPopTextGUIStyle;
			}
		}

		/// <summary>
		/// Void _OnGUI(Int32)
		/// </summary>
		protected RMethod r_R_OnGUI_Int32;
		public virtual RMethod R_OnGUI_Int32
		{
			get
			{
				if(r_R_OnGUI_Int32 == null)
				{
					r_R_OnGUI_Int32 = new(this, "_OnGUI", 0, typeof(System.Int32));
					r_R_OnGUI_Int32.SetBelong(this.instance);
				}
				return r_R_OnGUI_Int32;
			}
		}

		/// <summary>
		/// Void #jjb()
		/// </summary>
		protected RMethod r_R__0__jjb;
		public virtual RMethod R__0__jjb
		{
			get
			{
				if(r_R__0__jjb == null)
				{
					r_R__0__jjb = new(this, "#jjb", 0);
					r_R__0__jjb.SetBelong(this.instance);
				}
				return r_R__0__jjb;
			}
		}

		/// <summary>
		/// Void #kjb(Single)
		/// </summary>
		protected RMethod r_R__0__kjb_Single;
		public virtual RMethod R__0__kjb_Single
		{
			get
			{
				if(r_R__0__kjb_Single == null)
				{
					r_R__0__kjb_Single = new(this, "#kjb", 0, typeof(System.Single));
					r_R__0__kjb_Single.SetBelong(this.instance);
				}
				return r_R__0__kjb_Single;
			}
		}

		/// <summary>
		/// Void #ljb(UnityEngine.GUIStyle, Single)
		/// </summary>
		protected RMethod r_R__0__ljb_GUIStyle_Single;
		public virtual RMethod R__0__ljb_GUIStyle_Single
		{
			get
			{
				if(r_R__0__ljb_GUIStyle_Single == null)
				{
					r_R__0__ljb_GUIStyle_Single = new(this, "#ljb", 0, typeof(UnityEngine.GUIStyle), typeof(System.Single));
					r_R__0__ljb_GUIStyle_Single.SetBelong(this.instance);
				}
				return r_R__0__ljb_GUIStyle_Single;
			}
		}

		/// <summary>
		/// Void #mjb(GameDefineType.ID, Byte)
		/// </summary>
		protected RMethod r_R__0__mjb_ID_Byte;
		public virtual RMethod R__0__mjb_ID_Byte
		{
			get
			{
				if(r_R__0__mjb_ID_Byte == null)
				{
					r_R__0__mjb_ID_Byte = new(this, "#mjb", 0, typeof(GameDefineType.ID), typeof(System.Byte));
					r_R__0__mjb_ID_Byte.SetBelong(this.instance);
				}
				return r_R__0__mjb_ID_Byte;
			}
		}

		/// <summary>
		/// Void #njb(GameDefineType.ID, Byte)
		/// </summary>
		protected RMethod r_R__0__njb_ID_Byte;
		public virtual RMethod R__0__njb_ID_Byte
		{
			get
			{
				if(r_R__0__njb_ID_Byte == null)
				{
					r_R__0__njb_ID_Byte = new(this, "#njb", 0, typeof(GameDefineType.ID), typeof(System.Byte));
					r_R__0__njb_ID_Byte.SetBelong(this.instance);
				}
				return r_R__0__njb_ID_Byte;
			}
		}

		/// <summary>
		/// Void #njb(GameDefineType.ID, Byte, Boolean)
		/// </summary>
		protected RMethod r_R__0__njb_ID_Byte_Boolean;
		public virtual RMethod R__0__njb_ID_Byte_Boolean
		{
			get
			{
				if(r_R__0__njb_ID_Byte_Boolean == null)
				{
					r_R__0__njb_ID_Byte_Boolean = new(this, "#njb", 0, typeof(GameDefineType.ID), typeof(System.Byte), typeof(System.Boolean));
					r_R__0__njb_ID_Byte_Boolean.SetBelong(this.instance);
				}
				return r_R__0__njb_ID_Byte_Boolean;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #ojb(Single)
		/// </summary>
		protected RMethod r_R__0__ojb_Single;
		public virtual RMethod R__0__ojb_Single
		{
			get
			{
				if(r_R__0__ojb_Single == null)
				{
					r_R__0__ojb_Single = new(this, "#ojb", 0, typeof(System.Single));
					r_R__0__ojb_Single.SetBelong(this.instance);
				}
				return r_R__0__ojb_Single;
			}
		}

		/// <summary>
		/// Void #pjb(Int32)
		/// </summary>
		protected RMethod r_R__0__pjb_Int32;
		public virtual RMethod R__0__pjb_Int32
		{
			get
			{
				if(r_R__0__pjb_Int32 == null)
				{
					r_R__0__pjb_Int32 = new(this, "#pjb", 0, typeof(System.Int32));
					r_R__0__pjb_Int32.SetBelong(this.instance);
				}
				return r_R__0__pjb_Int32;
			}
		}

		/// <summary>
		/// Void #qjb(ShowType, Int32, Int32 ByRef)
		/// </summary>
		protected RMethod r_R__0__qjb_ShowType_Int32_Ref_Int32;
		public virtual RMethod R__0__qjb_ShowType_Int32_Ref_Int32
		{
			get
			{
				if(r_R__0__qjb_ShowType_Int32_Ref_Int32 == null)
				{
					r_R__0__qjb_ShowType_Int32_Ref_Int32 = new(this, "#qjb", 0,  ReleactionUtils.GetType("EquipChangeNotify+ShowType"), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_R__0__qjb_ShowType_Int32_Ref_Int32.SetBelong(this.instance);
				}
				return r_R__0__qjb_ShowType_Int32_Ref_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle #rjb(Boolean)
		/// </summary>
		protected RMethod r_R__0__rjb_Boolean;
		public virtual RMethod R__0__rjb_Boolean
		{
			get
			{
				if(r_R__0__rjb_Boolean == null)
				{
					r_R__0__rjb_Boolean = new(this, "#rjb", 0, typeof(System.Boolean));
					r_R__0__rjb_Boolean.SetBelong(this.instance);
				}
				return r_R__0__rjb_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle #sjb(ShowType, Boolean)
		/// </summary>
		protected RMethod r_R__0__sjb_ShowType_Boolean;
		public virtual RMethod R__0__sjb_ShowType_Boolean
		{
			get
			{
				if(r_R__0__sjb_ShowType_Boolean == null)
				{
					r_R__0__sjb_ShowType_Boolean = new(this, "#sjb", 0,  ReleactionUtils.GetType("EquipChangeNotify+ShowType"), typeof(System.Boolean));
					r_R__0__sjb_ShowType_Boolean.SetBelong(this.instance);
				}
				return r_R__0__sjb_ShowType_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle GetNumStyle(Int32, Boolean)
		/// </summary>
		protected RMethod r_RGetNumStyle_Int32_Boolean;
		public virtual RMethod RGetNumStyle_Int32_Boolean
		{
			get
			{
				if(r_RGetNumStyle_Int32_Boolean == null)
				{
					r_RGetNumStyle_Int32_Boolean = new(this, "GetNumStyle", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RGetNumStyle_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RGetNumStyle_Int32_Boolean;
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


        public REquipChangeNotify() : base("EquipChangeNotify")
        {
        }

        public REquipChangeNotify(System.Object instance) : base("EquipChangeNotify")
		{
            SetInstance(instance);
		}

        public REquipChangeNotify(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public REquipChangeNotify(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void _OnGUI(System.Int32  @wndID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@wndID};
            var ___result = R_OnGUI_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__jjb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__jjb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__kjb(System.Single  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scale};
            var ___result = R__0__kjb_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ljb(UnityEngine.GUIStyle  @stl, System.Single  @scale)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stl, @scale};
            var ___result = R__0__ljb_GUIStyle_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__mjb(GameDefineType.ID  @playerId, System.Byte  @targetPlace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@playerId, @targetPlace};
            var ___result = R__0__mjb_ID_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__njb(GameDefineType.ID  @playerId, System.Byte  @targetPlace)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@playerId, @targetPlace};
            var ___result = R__0__njb_ID_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__njb(GameDefineType.ID  @playerId, System.Byte  @targetPlace, System.Boolean  @endCatch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@playerId, @targetPlace, @endCatch};
            var ___result = R__0__njb_ID_Byte_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__ojb(System.Single  @waitTime)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@waitTime};
            var ___result = R__0__ojb_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__pjb(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__pjb_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual UnityEngine.GUIStyle __0__rjb(System.Boolean  @isPositive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isPositive};
            var ___result = R__0__rjb_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }



        public virtual UnityEngine.GUIStyle GetNumStyle(System.Int32  @i, System.Boolean  @isPositive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i, @isPositive};
            var ___result = RGetNumStyle_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
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
