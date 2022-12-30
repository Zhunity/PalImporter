using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RAvatarController
{
	
	/// <summary>
	/// AvatarController+weaponInfo
	/// </summary>
    public partial class RweaponInfo : RMember //
    {

		/// <summary>
		/// GameDefineType.ID _idEquipTyp
		/// </summary>
		protected RGameDefineType.RID r__idEquipTyp;
		public virtual RGameDefineType.RID R_idEquipTyp
		{
			get
			{
				if(r__idEquipTyp == null)
				{
					r__idEquipTyp = new(this, "_idEquipTyp");
					r__idEquipTyp.SetBelong(this.instance);
				}
				return r__idEquipTyp;
			}
		}

		/// <summary>
		/// GameDefineType.ID idItemType
		/// </summary>
		protected RGameDefineType.RID r_idItemType;
		public virtual RGameDefineType.RID RidItemType
		{
			get
			{
				if(r_idItemType == null)
				{
					r_idItemType = new(this, "idItemType");
					r_idItemType.SetBelong(this.instance);
				}
				return r_idItemType;
			}
		}

		/// <summary>
		/// EquipType+TYPE_WEAPON typ
		/// </summary>
		protected RField r_typ;
		public virtual RField Rtyp
		{
			get
			{
				if(r_typ == null)
				{
					r_typ = new(this, "typ");
					r_typ.SetBelong(this.instance);
				}
				return r_typ;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.GameObject] _currentWeapon
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> r__currentWeapon;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> R_currentWeapon
		{
			get
			{
				if(r__currentWeapon == null)
				{
					r__currentWeapon = new(this, "_currentWeapon");
					r__currentWeapon.SetBelong(this.instance);
				}
				return r__currentWeapon;
			}
		}

		/// <summary>
		/// GameDefineType.ID idEquipTyp
		/// </summary>
		protected RGameDefineType.RID r_idEquipTyp;
		public virtual RGameDefineType.RID RidEquipTyp
		{
			get
			{
				if(r_idEquipTyp == null)
				{
					r_idEquipTyp = new(this, "idEquipTyp", -1);
					r_idEquipTyp.SetBelong(this.instance);
				}
				return r_idEquipTyp;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[UnityEngine.GameObject] mCurrentWeapons
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> r_mCurrentWeapons;
		public virtual RSystem.RCollections.RGeneric.RList<RUnityEngine.RGameObject> RmCurrentWeapons
		{
			get
			{
				if(r_mCurrentWeapons == null)
				{
					r_mCurrentWeapons = new(this, "mCurrentWeapons", -1);
					r_mCurrentWeapons.SetBelong(this.instance);
				}
				return r_mCurrentWeapons;
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


        public RweaponInfo() : base("AvatarController+weaponInfo")
        {
        }

        public RweaponInfo(System.Object instance) : base("AvatarController+weaponInfo")
		{
            SetInstance(instance);
		}

        public RweaponInfo(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RweaponInfo(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
}