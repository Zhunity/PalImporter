using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// NPC_RES_STRUCT
	/// </summary>
    public partial class RNPC_RES_STRUCT : RMember //
    {

		/// <summary>
		/// System.String mNpcID
		/// </summary>
		protected RField r_mNpcID;
		public virtual RField RmNpcID
		{
			get
			{
				if(r_mNpcID == null)
				{
					r_mNpcID = new(this, "mNpcID");
					r_mNpcID.SetBelong(this.instance);
				}
				return r_mNpcID;
			}
		}

		/// <summary>
		/// System.String mName
		/// </summary>
		protected RField r_mName;
		public virtual RField RmName
		{
			get
			{
				if(r_mName == null)
				{
					r_mName = new(this, "mName");
					r_mName.SetBelong(this.instance);
				}
				return r_mName;
			}
		}

		/// <summary>
		/// System.String ModName
		/// </summary>
		protected RField r_ModName;
		public virtual RField RModName
		{
			get
			{
				if(r_ModName == null)
				{
					r_ModName = new(this, "ModName");
					r_ModName.SetBelong(this.instance);
				}
				return r_ModName;
			}
		}

		/// <summary>
		/// System.String TextureName
		/// </summary>
		protected RField r_TextureName;
		public virtual RField RTextureName
		{
			get
			{
				if(r_TextureName == null)
				{
					r_TextureName = new(this, "TextureName");
					r_TextureName.SetBelong(this.instance);
				}
				return r_TextureName;
			}
		}

		/// <summary>
		/// System.String headIcon
		/// </summary>
		protected RField r_headIcon;
		public virtual RField RheadIcon
		{
			get
			{
				if(r_headIcon == null)
				{
					r_headIcon = new(this, "headIcon");
					r_headIcon.SetBelong(this.instance);
				}
				return r_headIcon;
			}
		}

		/// <summary>
		/// System.String PetIcon
		/// </summary>
		protected RField r_PetIcon;
		public virtual RField RPetIcon
		{
			get
			{
				if(r_PetIcon == null)
				{
					r_PetIcon = new(this, "PetIcon");
					r_PetIcon.SetBelong(this.instance);
				}
				return r_PetIcon;
			}
		}

		/// <summary>
		/// System.Single ModleScale
		/// </summary>
		protected RField r_ModleScale;
		public virtual RField RModleScale
		{
			get
			{
				if(r_ModleScale == null)
				{
					r_ModleScale = new(this, "ModleScale");
					r_ModleScale.SetBelong(this.instance);
				}
				return r_ModleScale;
			}
		}

		/// <summary>
		/// System.Single ControllRadius
		/// </summary>
		protected RField r_ControllRadius;
		public virtual RField RControllRadius
		{
			get
			{
				if(r_ControllRadius == null)
				{
					r_ControllRadius = new(this, "ControllRadius");
					r_ControllRadius.SetBelong(this.instance);
				}
				return r_ControllRadius;
			}
		}

		/// <summary>
		/// System.Single ControllHeight
		/// </summary>
		protected RField r_ControllHeight;
		public virtual RField RControllHeight
		{
			get
			{
				if(r_ControllHeight == null)
				{
					r_ControllHeight = new(this, "ControllHeight");
					r_ControllHeight.SetBelong(this.instance);
				}
				return r_ControllHeight;
			}
		}

		/// <summary>
		/// System.Single PetFollowDistance
		/// </summary>
		protected RField r_PetFollowDistance;
		public virtual RField RPetFollowDistance
		{
			get
			{
				if(r_PetFollowDistance == null)
				{
					r_PetFollowDistance = new(this, "PetFollowDistance");
					r_PetFollowDistance.SetBelong(this.instance);
				}
				return r_PetFollowDistance;
			}
		}

		/// <summary>
		/// System.Int32 modeType
		/// </summary>
		protected RField r_modeType;
		public virtual RField RmodeType
		{
			get
			{
				if(r_modeType == null)
				{
					r_modeType = new(this, "modeType");
					r_modeType.SetBelong(this.instance);
				}
				return r_modeType;
			}
		}

		/// <summary>
		/// System.Single EffectScale
		/// </summary>
		protected RField r_EffectScale;
		public virtual RField REffectScale
		{
			get
			{
				if(r_EffectScale == null)
				{
					r_EffectScale = new(this, "EffectScale");
					r_EffectScale.SetBelong(this.instance);
				}
				return r_EffectScale;
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


        public RNPC_RES_STRUCT() : base("NPC_RES_STRUCT")
        {
        }

        public RNPC_RES_STRUCT(System.Object instance) : base("NPC_RES_STRUCT")
		{
            SetInstance(instance);
		}

        public RNPC_RES_STRUCT(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RNPC_RES_STRUCT(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
