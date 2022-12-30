using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// WeaponManager
	/// </summary>
    public partial class RWeaponManager : RMember //
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
		/// System.String[] #b
		/// </summary>
		protected static RFieldArray<RField> r___0__b;
		public static RFieldArray<RField> R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new( ReleactionUtils.GetType("WeaponManager"), "#b");
					r___0__b.SetBelong(null);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.String[] #c
		/// </summary>
		protected RFieldArray<RField> r___0__c;
		public virtual RFieldArray<RField> R__0__c
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
		/// System.String #d
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
		/// System.Collections.Generic.Dictionary`2[WeaponManager+WEAPON_RESOURCE,System.Collections.Generic.Dictionary`2[System.String,UnityEngine.Object]] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RObject>> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RObject>> R__0__e
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
		/// System.Collections.Generic.List`1[System.String] #f
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__f;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__f
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
		/// Void #Onb(GameDefineType.ID[])
		/// </summary>
		protected RMethod r_R__0__Onb_IDArray;
		public virtual RMethod R__0__Onb_IDArray
		{
			get
			{
				if(r_R__0__Onb_IDArray == null)
				{
					r_R__0__Onb_IDArray = new(this, "#Onb", 0, typeof(GameDefineType.ID).MakeArrayType());
					r_R__0__Onb_IDArray.SetBelong(this.instance);
				}
				return r_R__0__Onb_IDArray;
			}
		}

		/// <summary>
		/// Void #Pnb(#u.#Gnb)
		/// </summary>
		protected RMethod r_R__0__Pnb___0__Gnb;
		public virtual RMethod R__0__Pnb___0__Gnb
		{
			get
			{
				if(r_R__0__Pnb___0__Gnb == null)
				{
					r_R__0__Pnb___0__Gnb = new(this, "#Pnb", 0,  ReleactionUtils.GetType("#u.#Gnb"));
					r_R__0__Pnb___0__Gnb.SetBelong(this.instance);
				}
				return r_R__0__Pnb___0__Gnb;
			}
		}

		/// <summary>
		/// UnityEngine.Object #Qnb(WEAPON_RESOURCE, System.String)
		/// </summary>
		protected RMethod r_R__0__Qnb_WEAPON_RESOURCE_String;
		public virtual RMethod R__0__Qnb_WEAPON_RESOURCE_String
		{
			get
			{
				if(r_R__0__Qnb_WEAPON_RESOURCE_String == null)
				{
					r_R__0__Qnb_WEAPON_RESOURCE_String = new(this, "#Qnb", 0,  ReleactionUtils.GetType("WeaponManager+WEAPON_RESOURCE"), typeof(System.String));
					r_R__0__Qnb_WEAPON_RESOURCE_String.SetBelong(this.instance);
				}
				return r_R__0__Qnb_WEAPON_RESOURCE_String;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] #Nnb(GameDefineType.ID, GameDefineType.ID, #lOb, System.Object)
		/// </summary>
		protected RMethod r_R__0__Nnb_ID_ID___0__lOb_Object;
		public virtual RMethod R__0__Nnb_ID_ID___0__lOb_Object
		{
			get
			{
				if(r_R__0__Nnb_ID_ID___0__lOb_Object == null)
				{
					r_R__0__Nnb_ID_ID___0__lOb_Object = new(this, "#Nnb", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID),  ReleactionUtils.GetType("WeaponRes+#lOb"), typeof(System.Object));
					r_R__0__Nnb_ID_ID___0__lOb_Object.SetBelong(this.instance);
				}
				return r_R__0__Nnb_ID_ID___0__lOb_Object;
			}
		}

		/// <summary>
		/// Void #hJc()
		/// </summary>
		protected RMethod r_R__0__hJc;
		public virtual RMethod R__0__hJc
		{
			get
			{
				if(r_R__0__hJc == null)
				{
					r_R__0__hJc = new(this, "#hJc", 0);
					r_R__0__hJc.SetBelong(this.instance);
				}
				return r_R__0__hJc;
			}
		}

		/// <summary>
		/// Void #iJc(System.String[])
		/// </summary>
		protected RMethod r_R__0__iJc_StringArray;
		public virtual RMethod R__0__iJc_StringArray
		{
			get
			{
				if(r_R__0__iJc_StringArray == null)
				{
					r_R__0__iJc_StringArray = new(this, "#iJc", 0, typeof(System.String).MakeArrayType());
					r_R__0__iJc_StringArray.SetBelong(this.instance);
				}
				return r_R__0__iJc_StringArray;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] #jJc()
		/// </summary>
		protected RMethod r_R__0__jJc;
		public virtual RMethod R__0__jJc
		{
			get
			{
				if(r_R__0__jJc == null)
				{
					r_R__0__jJc = new(this, "#jJc", 0);
					r_R__0__jJc.SetBelong(this.instance);
				}
				return r_R__0__jJc;
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


        public RWeaponManager() : base("WeaponManager")
        {
        }

        public RWeaponManager(System.Object instance) : base("WeaponManager")
		{
            SetInstance(instance);
		}

        public RWeaponManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWeaponManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__Onb(GameDefineType.ID[]  @weaponIDs)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@weaponIDs};
            var ___result = R__0__Onb_IDArray.Invoke(___genericsType, ___parameters);

            
        }





        public virtual void __0__hJc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__hJc.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__iJc(System.String[]  @urls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@urls};
            var ___result = R__0__iJc_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.String> __0__jJc()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__jJc.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
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
