using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CharacterMaterialConfig
	/// </summary>
    public partial class RCharacterMaterialConfig : RMember //
    {

		/// <summary>
		/// System.String scendId
		/// </summary>
		protected RField r_scendId;
		public virtual RField RscendId
		{
			get
			{
				if(r_scendId == null)
				{
					r_scendId = new(this, "scendId");
					r_scendId.SetBelong(this.instance);
				}
				return r_scendId;
			}
		}

		/// <summary>
		/// UnityEngine.Color mainColor
		/// </summary>
		protected RUnityEngine.RColor r_mainColor;
		public virtual RUnityEngine.RColor RmainColor
		{
			get
			{
				if(r_mainColor == null)
				{
					r_mainColor = new(this, "mainColor");
					r_mainColor.SetBelong(this.instance);
				}
				return r_mainColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color SpecColor
		/// </summary>
		protected RUnityEngine.RColor r_SpecColor;
		public virtual RUnityEngine.RColor RSpecColor
		{
			get
			{
				if(r_SpecColor == null)
				{
					r_SpecColor = new(this, "SpecColor");
					r_SpecColor.SetBelong(this.instance);
				}
				return r_SpecColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color Emission
		/// </summary>
		protected RUnityEngine.RColor r_Emission;
		public virtual RUnityEngine.RColor REmission
		{
			get
			{
				if(r_Emission == null)
				{
					r_Emission = new(this, "Emission");
					r_Emission.SetBelong(this.instance);
				}
				return r_Emission;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[CareerScale] m_CareerMaterialList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RCareerScale> r_m_CareerMaterialList;
		public virtual RSystem.RCollections.RGeneric.RList<RCareerScale> Rm_CareerMaterialList
		{
			get
			{
				if(r_m_CareerMaterialList == null)
				{
					r_m_CareerMaterialList = new(this, "m_CareerMaterialList");
					r_m_CareerMaterialList.SetBelong(this.instance);
				}
				return r_m_CareerMaterialList;
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


        public RCharacterMaterialConfig() : base("CharacterMaterialConfig")
        {
        }

        public RCharacterMaterialConfig(System.Object instance) : base("CharacterMaterialConfig")
		{
            SetInstance(instance);
		}

        public RCharacterMaterialConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCharacterMaterialConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
