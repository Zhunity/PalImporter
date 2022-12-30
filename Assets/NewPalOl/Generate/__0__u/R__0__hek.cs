using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#hek
	/// </summary>
    public partial class R__0__hek : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,TavernItemConfig] #a
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RTavernItemConfig> r___0__a;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RTavernItemConfig> R__0__a
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
		/// System.Collections.Generic.List`1[TavernPoint] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RTavernPoint> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RList<RTavernPoint> R__0__b
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
		/// System.Collections.Generic.Dictionary`2[System.Int32,TavernConfig] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RTavernConfig> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RTavernConfig> R__0__c
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
		/// KeyValueContent #d
		/// </summary>
		protected RKeyValueContent r___0__d;
		public virtual RKeyValueContent R__0__d
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
		/// Void OnLoadTavernItemConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadTavernItemConfig_Object;
		public virtual RMethod ROnLoadTavernItemConfig_Object
		{
			get
			{
				if(r_ROnLoadTavernItemConfig_Object == null)
				{
					r_ROnLoadTavernItemConfig_Object = new(this, "OnLoadTavernItemConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadTavernItemConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTavernItemConfig_Object;
			}
		}

		/// <summary>
		/// TavernItemConfig #9dk(Int32)
		/// </summary>
		protected RMethod r_R__0__9dk_Int32;
		public virtual RMethod R__0__9dk_Int32
		{
			get
			{
				if(r_R__0__9dk_Int32 == null)
				{
					r_R__0__9dk_Int32 = new(this, "#9dk", 0, typeof(System.Int32));
					r_R__0__9dk_Int32.SetBelong(this.instance);
				}
				return r_R__0__9dk_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadTavernPointConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadTavernPointConfig_Object;
		public virtual RMethod ROnLoadTavernPointConfig_Object
		{
			get
			{
				if(r_ROnLoadTavernPointConfig_Object == null)
				{
					r_ROnLoadTavernPointConfig_Object = new(this, "OnLoadTavernPointConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadTavernPointConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTavernPointConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[TavernPoint] #aek()
		/// </summary>
		protected RMethod r_R__0__aek;
		public virtual RMethod R__0__aek
		{
			get
			{
				if(r_R__0__aek == null)
				{
					r_R__0__aek = new(this, "#aek", 0);
					r_R__0__aek.SetBelong(this.instance);
				}
				return r_R__0__aek;
			}
		}

		/// <summary>
		/// Void OnLoadTavernConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadTavernConfig_Object;
		public virtual RMethod ROnLoadTavernConfig_Object
		{
			get
			{
				if(r_ROnLoadTavernConfig_Object == null)
				{
					r_ROnLoadTavernConfig_Object = new(this, "OnLoadTavernConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadTavernConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTavernConfig_Object;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Int32,TavernConfig] #bek()
		/// </summary>
		protected RMethod r_R__0__bek;
		public virtual RMethod R__0__bek
		{
			get
			{
				if(r_R__0__bek == null)
				{
					r_R__0__bek = new(this, "#bek", 0);
					r_R__0__bek.SetBelong(this.instance);
				}
				return r_R__0__bek;
			}
		}

		/// <summary>
		/// TavernConfig #cek(Int32)
		/// </summary>
		protected RMethod r_R__0__cek_Int32;
		public virtual RMethod R__0__cek_Int32
		{
			get
			{
				if(r_R__0__cek_Int32 == null)
				{
					r_R__0__cek_Int32 = new(this, "#cek", 0, typeof(System.Int32));
					r_R__0__cek_Int32.SetBelong(this.instance);
				}
				return r_R__0__cek_Int32;
			}
		}

		/// <summary>
		/// Void OnLoadTavernTransferConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadTavernTransferConfig_Object;
		public virtual RMethod ROnLoadTavernTransferConfig_Object
		{
			get
			{
				if(r_ROnLoadTavernTransferConfig_Object == null)
				{
					r_ROnLoadTavernTransferConfig_Object = new(this, "OnLoadTavernTransferConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadTavernTransferConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadTavernTransferConfig_Object;
			}
		}

		/// <summary>
		/// Int32 #iEo(Int32)
		/// </summary>
		protected RMethod r_R__0__iEo_Int32;
		public virtual RMethod R__0__iEo_Int32
		{
			get
			{
				if(r_R__0__iEo_Int32 == null)
				{
					r_R__0__iEo_Int32 = new(this, "#iEo", 0, typeof(System.Int32));
					r_R__0__iEo_Int32.SetBelong(this.instance);
				}
				return r_R__0__iEo_Int32;
			}
		}

		/// <summary>
		/// Void #dek(System.Object, #Pfb.#Isb)
		/// </summary>
		protected RMethod r_R__0__dek_Object___0__Isb;
		public virtual RMethod R__0__dek_Object___0__Isb
		{
			get
			{
				if(r_R__0__dek_Object___0__Isb == null)
				{
					r_R__0__dek_Object___0__Isb = new(this, "#dek", 0, typeof(System.Object),  ReleactionUtils.GetType("#Pfb.#Isb"));
					r_R__0__dek_Object___0__Isb.SetBelong(this.instance);
				}
				return r_R__0__dek_Object___0__Isb;
			}
		}

		/// <summary>
		/// Void #09d()
		/// </summary>
		protected RMethod r_R__0__09d;
		public virtual RMethod R__0__09d
		{
			get
			{
				if(r_R__0__09d == null)
				{
					r_R__0__09d = new(this, "#09d", 0);
					r_R__0__09d.SetBelong(this.instance);
				}
				return r_R__0__09d;
			}
		}

		/// <summary>
		/// Void #99d(System.String, Boolean)
		/// </summary>
		protected RMethod r_R__0__99d_String_Boolean;
		public virtual RMethod R__0__99d_String_Boolean
		{
			get
			{
				if(r_R__0__99d_String_Boolean == null)
				{
					r_R__0__99d_String_Boolean = new(this, "#99d", 0, typeof(System.String), typeof(System.Boolean));
					r_R__0__99d_String_Boolean.SetBelong(this.instance);
				}
				return r_R__0__99d_String_Boolean;
			}
		}

		/// <summary>
		/// Void #eek(System.String)
		/// </summary>
		protected RMethod r_R__0__eek_String;
		public virtual RMethod R__0__eek_String
		{
			get
			{
				if(r_R__0__eek_String == null)
				{
					r_R__0__eek_String = new(this, "#eek", 0, typeof(System.String));
					r_R__0__eek_String.SetBelong(this.instance);
				}
				return r_R__0__eek_String;
			}
		}

		/// <summary>
		/// Void #fek(Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__fek_Int32_Int32;
		public virtual RMethod R__0__fek_Int32_Int32
		{
			get
			{
				if(r_R__0__fek_Int32_Int32 == null)
				{
					r_R__0__fek_Int32_Int32 = new(this, "#fek", 0, typeof(System.Int32), typeof(System.Int32));
					r_R__0__fek_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__fek_Int32_Int32;
			}
		}

		/// <summary>
		/// Void #gek(System.String)
		/// </summary>
		protected RMethod r_R__0__gek_String;
		public virtual RMethod R__0__gek_String
		{
			get
			{
				if(r_R__0__gek_String == null)
				{
					r_R__0__gek_String = new(this, "#gek", 0, typeof(System.String));
					r_R__0__gek_String.SetBelong(this.instance);
				}
				return r_R__0__gek_String;
			}
		}

		/// <summary>
		/// Void #2Tn(Int32)
		/// </summary>
		protected RMethod r_R__0__2Tn_Int32;
		public virtual RMethod R__0__2Tn_Int32
		{
			get
			{
				if(r_R__0__2Tn_Int32 == null)
				{
					r_R__0__2Tn_Int32 = new(this, "#2Tn", 0, typeof(System.Int32));
					r_R__0__2Tn_Int32.SetBelong(this.instance);
				}
				return r_R__0__2Tn_Int32;
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


        public R__0__hek() : base("#u.#hek")
        {
        }

        public R__0__hek(System.Object instance) : base("#u.#hek")
		{
            SetInstance(instance);
		}

        public R__0__hek(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__hek(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Initial()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitial.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadTavernItemConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadTavernItemConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual TavernItemConfig __0__9dk(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__9dk_Int32.Invoke(___genericsType, ___parameters);

            return (TavernItemConfig)___result;
        }


        public virtual void OnLoadTavernPointConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadTavernPointConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<TavernPoint> __0__aek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__aek.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<TavernPoint>)___result;
        }


        public virtual void OnLoadTavernConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadTavernConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.Dictionary<System.Int32, TavernConfig> __0__bek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__bek.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.Dictionary<System.Int32, TavernConfig>)___result;
        }


        public virtual TavernConfig __0__cek(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__cek_Int32.Invoke(___genericsType, ___parameters);

            return (TavernConfig)___result;
        }


        public virtual void OnLoadTavernTransferConfig(UnityEngine.Object  @textasset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textasset};
            var ___result = ROnLoadTavernTransferConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 __0__iEo(System.Int32  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__iEo_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual void __0__09d()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__09d.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__99d(System.String  @type, System.Boolean  @bNeedPay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @bNeedPay};
            var ___result = R__0__99d_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__eek(System.String  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__eek_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__fek(System.Int32  @id, System.Int32  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id, @type};
            var ___result = R__0__fek_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__gek(System.String  @id)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@id};
            var ___result = R__0__gek_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__2Tn(System.Int32  @idx)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@idx};
            var ___result = R__0__2Tn_Int32.Invoke(___genericsType, ___parameters);

            
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
