using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PetResourceManager
	/// </summary>
    public partial class RPetResourceManager : RMember //
    {

		/// <summary>
		/// System.String PetHeadIcon(Pet)
		/// </summary>
		protected RMethod r_RPetHeadIcon_Pet;
		public virtual RMethod RPetHeadIcon_Pet
		{
			get
			{
				if(r_RPetHeadIcon_Pet == null)
				{
					r_RPetHeadIcon_Pet = new(this, "PetHeadIcon", 0,  ReleactionUtils.GetType("Pet"));
					r_RPetHeadIcon_Pet.SetBelong(this.instance);
				}
				return r_RPetHeadIcon_Pet;
			}
		}

		/// <summary>
		/// System.String PetHeadIcon(UInt32)
		/// </summary>
		protected RMethod r_RPetHeadIcon_UInt32;
		public virtual RMethod RPetHeadIcon_UInt32
		{
			get
			{
				if(r_RPetHeadIcon_UInt32 == null)
				{
					r_RPetHeadIcon_UInt32 = new(this, "PetHeadIcon", 0, typeof(System.UInt32));
					r_RPetHeadIcon_UInt32.SetBelong(this.instance);
				}
				return r_RPetHeadIcon_UInt32;
			}
		}

		/// <summary>
		/// System.String GetPetHeadNormalIconURL(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetPetHeadNormalIconURL_ID;
		public virtual RMethod RGetPetHeadNormalIconURL_ID
		{
			get
			{
				if(r_RGetPetHeadNormalIconURL_ID == null)
				{
					r_RGetPetHeadNormalIconURL_ID = new(this, "GetPetHeadNormalIconURL", 0, typeof(GameDefineType.ID));
					r_RGetPetHeadNormalIconURL_ID.SetBelong(this.instance);
				}
				return r_RGetPetHeadNormalIconURL_ID;
			}
		}

		/// <summary>
		/// System.String GetCGTexture(Pet)
		/// </summary>
		protected RMethod r_RGetCGTexture_Pet;
		public virtual RMethod RGetCGTexture_Pet
		{
			get
			{
				if(r_RGetCGTexture_Pet == null)
				{
					r_RGetCGTexture_Pet = new(this, "GetCGTexture", 0,  ReleactionUtils.GetType("Pet"));
					r_RGetCGTexture_Pet.SetBelong(this.instance);
				}
				return r_RGetCGTexture_Pet;
			}
		}

		/// <summary>
		/// System.String PetCgHeadIconUrl(UInt32)
		/// </summary>
		protected RMethod r_RPetCgHeadIconUrl_UInt32;
		public virtual RMethod RPetCgHeadIconUrl_UInt32
		{
			get
			{
				if(r_RPetCgHeadIconUrl_UInt32 == null)
				{
					r_RPetCgHeadIconUrl_UInt32 = new(this, "PetCgHeadIconUrl", 0, typeof(System.UInt32));
					r_RPetCgHeadIconUrl_UInt32.SetBelong(this.instance);
				}
				return r_RPetCgHeadIconUrl_UInt32;
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


        public RPetResourceManager() : base("PetResourceManager")
        {
        }

        public RPetResourceManager(System.Object instance) : base("PetResourceManager")
		{
            SetInstance(instance);
		}

        public RPetResourceManager(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPetResourceManager(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }


        public virtual System.String PetHeadIcon(System.UInt32  @carrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer};
            var ___result = RPetHeadIcon_UInt32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetPetHeadNormalIconURL(GameDefineType.ID  @carrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer};
            var ___result = RGetPetHeadNormalIconURL_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual System.String PetCgHeadIconUrl(System.UInt32  @carrer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer};
            var ___result = RPetCgHeadIconUrl_UInt32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
