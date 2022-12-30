using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// WeaponRes
	/// </summary>
    public partial class RWeaponRes : RMember //
    {

		/// <summary>
		/// WeaponRes+#kOb #a
		/// </summary>
		protected RWeaponRes.R__0__kOb r___0__a;
		public virtual RWeaponRes.R__0__kOb R__0__a
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
		/// WeaponRes+#lOb #b
		/// </summary>
		protected RWeaponRes.R__0__lOb r___0__b;
		public virtual RWeaponRes.R__0__lOb R__0__b
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
		/// System.String[] #c
		/// </summary>
		protected static RFieldArray<RField> r___0__c;
		public static RFieldArray<RField> R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new( ReleactionUtils.GetType("WeaponRes"), "#c");
					r___0__c.SetBelong(null);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.String[] #d
		/// </summary>
		protected RFieldArray<RField> r___0__d;
		public virtual RFieldArray<RField> R__0__d
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
		/// System.String #e
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
		/// GameDefineType.ID #f
		/// </summary>
		protected RGameDefineType.RID r___0__f;
		public virtual RGameDefineType.RID R__0__f
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
		/// GameDefineType.ID #g
		/// </summary>
		protected RGameDefineType.RID r___0__g;
		public virtual RGameDefineType.RID R__0__g
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
		/// UnityEngine.GameObject #h
		/// </summary>
		protected RUnityEngine.RGameObject r___0__h;
		public virtual RUnityEngine.RGameObject R__0__h
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
		/// System.Collections.Generic.List`1[#u.#Gnb] #i
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Gnb> r___0__i;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Gnb> R__0__i
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
		/// System.Collections.Generic.List`1[#u.#Gnb] #k
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Gnb> r___0__k;
		public virtual RSystem.RCollections.RGeneric.RList<R__0__u.R__0__Gnb> R__0__k
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
		/// System.Object #l
		/// </summary>
		protected RSystem.RObject r___0__l;
		public virtual RSystem.RObject R__0__l
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
		/// System.String #Hnb(WEAPON_RESOURCE, GameDefineType.ID, GameDefineType.ID, Int32)
		/// </summary>
		protected RMethod r_R__0__Hnb_WEAPON_RESOURCE_ID_ID_Int32;
		public virtual RMethod R__0__Hnb_WEAPON_RESOURCE_ID_ID_Int32
		{
			get
			{
				if(r_R__0__Hnb_WEAPON_RESOURCE_ID_ID_Int32 == null)
				{
					r_R__0__Hnb_WEAPON_RESOURCE_ID_ID_Int32 = new(this, "#Hnb", 0,  ReleactionUtils.GetType("WeaponManager+WEAPON_RESOURCE"), typeof(GameDefineType.ID), typeof(GameDefineType.ID), typeof(System.Int32));
					r_R__0__Hnb_WEAPON_RESOURCE_ID_ID_Int32.SetBelong(this.instance);
				}
				return r_R__0__Hnb_WEAPON_RESOURCE_ID_ID_Int32;
			}
		}

		/// <summary>
		/// System.String #Inb(System.String, WEAPON_RESOURCE)
		/// </summary>
		protected RMethod r_R__0__Inb_String_WEAPON_RESOURCE;
		public virtual RMethod R__0__Inb_String_WEAPON_RESOURCE
		{
			get
			{
				if(r_R__0__Inb_String_WEAPON_RESOURCE == null)
				{
					r_R__0__Inb_String_WEAPON_RESOURCE = new(this, "#Inb", 0, typeof(System.String),  ReleactionUtils.GetType("WeaponManager+WEAPON_RESOURCE"));
					r_R__0__Inb_String_WEAPON_RESOURCE.SetBelong(this.instance);
				}
				return r_R__0__Inb_String_WEAPON_RESOURCE;
			}
		}

		/// <summary>
		/// Void #Jnb()
		/// </summary>
		protected RMethod r_R__0__Jnb;
		public virtual RMethod R__0__Jnb
		{
			get
			{
				if(r_R__0__Jnb == null)
				{
					r_R__0__Jnb = new(this, "#Jnb", 0);
					r_R__0__Jnb.SetBelong(this.instance);
				}
				return r_R__0__Jnb;
			}
		}

		/// <summary>
		/// Void #Jnb(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Jnb_ID;
		public virtual RMethod R__0__Jnb_ID
		{
			get
			{
				if(r_R__0__Jnb_ID == null)
				{
					r_R__0__Jnb_ID = new(this, "#Jnb", 0, typeof(GameDefineType.ID));
					r_R__0__Jnb_ID.SetBelong(this.instance);
				}
				return r_R__0__Jnb_ID;
			}
		}

		/// <summary>
		/// Void #Knb(System.Collections.Generic.List`1[#u.#Gnb])
		/// </summary>
		protected RMethod r_R__0__Knb_List_d___0__Gnb_p_;
		public virtual RMethod R__0__Knb_List_d___0__Gnb_p_
		{
			get
			{
				if(r_R__0__Knb_List_d___0__Gnb_p_ == null)
				{
					r_R__0__Knb_List_d___0__Gnb_p_ = new(this, "#Knb", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#u.#Gnb")));
					r_R__0__Knb_List_d___0__Gnb_p_.SetBelong(this.instance);
				}
				return r_R__0__Knb_List_d___0__Gnb_p_;
			}
		}

		/// <summary>
		/// Void #Knb(System.Collections.Generic.List`1[#u.#Gnb], GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__Knb_List_d___0__Gnb_p__ID;
		public virtual RMethod R__0__Knb_List_d___0__Gnb_p__ID
		{
			get
			{
				if(r_R__0__Knb_List_d___0__Gnb_p__ID == null)
				{
					r_R__0__Knb_List_d___0__Gnb_p__ID = new(this, "#Knb", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#u.#Gnb")), typeof(GameDefineType.ID));
					r_R__0__Knb_List_d___0__Gnb_p__ID.SetBelong(this.instance);
				}
				return r_R__0__Knb_List_d___0__Gnb_p__ID;
			}
		}

		/// <summary>
		/// Void #Lnb(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__Lnb_Object_ABLoadedArgs;
		public virtual RMethod R__0__Lnb_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__Lnb_Object_ABLoadedArgs == null)
				{
					r_R__0__Lnb_Object_ABLoadedArgs = new(this, "#Lnb", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__Lnb_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__Lnb_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Boolean #hgb()
		/// </summary>
		protected RMethod r_R__0__hgb;
		public virtual RMethod R__0__hgb
		{
			get
			{
				if(r_R__0__hgb == null)
				{
					r_R__0__hgb = new(this, "#hgb", 0);
					r_R__0__hgb.SetBelong(this.instance);
				}
				return r_R__0__hgb;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject #Mnb(System.Collections.Generic.List`1[#u.#Gnb])
		/// </summary>
		protected RMethod r_R__0__Mnb_List_d___0__Gnb_p_;
		public virtual RMethod R__0__Mnb_List_d___0__Gnb_p_
		{
			get
			{
				if(r_R__0__Mnb_List_d___0__Gnb_p_ == null)
				{
					r_R__0__Mnb_List_d___0__Gnb_p_ = new(this, "#Mnb", 0, typeof(System.Collections.Generic.List<>).MakeGenericType( ReleactionUtils.GetType("#u.#Gnb")));
					r_R__0__Mnb_List_d___0__Gnb_p_.SetBelong(this.instance);
				}
				return r_R__0__Mnb_List_d___0__Gnb_p_;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] #Nnb()
		/// </summary>
		protected RMethod r_R__0__Nnb;
		public virtual RMethod R__0__Nnb
		{
			get
			{
				if(r_R__0__Nnb == null)
				{
					r_R__0__Nnb = new(this, "#Nnb", 0);
					r_R__0__Nnb.SetBelong(this.instance);
				}
				return r_R__0__Nnb;
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


        public RWeaponRes() : base("WeaponRes")
        {
        }

        public RWeaponRes(System.Object instance) : base("WeaponRes")
		{
            SetInstance(instance);
		}

        public RWeaponRes(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWeaponRes(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }



        public virtual void __0__Jnb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Jnb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Jnb(GameDefineType.ID  @sceneID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneID};
            var ___result = R__0__Jnb_ID.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Boolean __0__hgb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__hgb.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual UnityEngine.GameObject[] __0__Nnb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__Nnb.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject[])___result;
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
