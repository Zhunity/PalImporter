using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RCharacterDownloader
{
	
	/// <summary>
	/// CharacterDownloader+CharacterWeaponArg
	/// </summary>
    public partial class RCharacterWeaponArg : RMember //
    {

		/// <summary>
		/// CharacterDownloader+CGLoadArgs cgArg
		/// </summary>
		protected RCharacterDownloader.RCGLoadArgs r_cgArg;
		public virtual RCharacterDownloader.RCGLoadArgs RcgArg
		{
			get
			{
				if(r_cgArg == null)
				{
					r_cgArg = new(this, "cgArg");
					r_cgArg.SetBelong(this.instance);
				}
				return r_cgArg;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject mCharacModl
		/// </summary>
		protected RUnityEngine.RGameObject r_mCharacModl;
		public virtual RUnityEngine.RGameObject RmCharacModl
		{
			get
			{
				if(r_mCharacModl == null)
				{
					r_mCharacModl = new(this, "mCharacModl");
					r_mCharacModl.SetBelong(this.instance);
				}
				return r_mCharacModl;
			}
		}

		/// <summary>
		/// GameDefineType.ID carrer
		/// </summary>
		protected RGameDefineType.RID r_carrer;
		public virtual RGameDefineType.RID Rcarrer
		{
			get
			{
				if(r_carrer == null)
				{
					r_carrer = new(this, "carrer");
					r_carrer.SetBelong(this.instance);
				}
				return r_carrer;
			}
		}

		/// <summary>
		/// System.Object param
		/// </summary>
		protected RSystem.RObject r_param;
		public virtual RSystem.RObject Rparam
		{
			get
			{
				if(r_param == null)
				{
					r_param = new(this, "param");
					r_param.SetBelong(this.instance);
				}
				return r_param;
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


        public RCharacterWeaponArg() : base("CharacterDownloader+CharacterWeaponArg")
        {
        }

        public RCharacterWeaponArg(System.Object instance) : base("CharacterDownloader+CharacterWeaponArg")
		{
            SetInstance(instance);
		}

        public RCharacterWeaponArg(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCharacterWeaponArg(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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