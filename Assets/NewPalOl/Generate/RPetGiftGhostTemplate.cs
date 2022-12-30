using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// PetGiftGhostTemplate
	/// </summary>
    public partial class RPetGiftGhostTemplate : RMember //
    {

		/// <summary>
		/// KeyValueContent[] _synthesisContent
		/// </summary>
		protected RFieldArray<RKeyValueContent> r__synthesisContent;
		public virtual RFieldArray<RKeyValueContent> R_synthesisContent
		{
			get
			{
				if(r__synthesisContent == null)
				{
					r__synthesisContent = new(this, "_synthesisContent");
					r__synthesisContent.SetBelong(this.instance);
				}
				return r__synthesisContent;
			}
		}

		/// <summary>
		/// System.String ID_LEVEL
		/// </summary>
		protected static RField r_ID_LEVEL;
		public static RField RID_LEVEL
		{
			get
			{
				if(r_ID_LEVEL == null)
				{
					r_ID_LEVEL = new( ReleactionUtils.GetType("PetGiftGhostTemplate"), "ID_LEVEL");
					r_ID_LEVEL.SetBelong(null);
				}
				return r_ID_LEVEL;
			}
		}

		/// <summary>
		/// System.String NEED_EXP
		/// </summary>
		protected static RField r_NEED_EXP;
		public static RField RNEED_EXP
		{
			get
			{
				if(r_NEED_EXP == null)
				{
					r_NEED_EXP = new( ReleactionUtils.GetType("PetGiftGhostTemplate"), "NEED_EXP");
					r_NEED_EXP.SetBelong(null);
				}
				return r_NEED_EXP;
			}
		}

		/// <summary>
		/// System.String NEED_GOLD
		/// </summary>
		protected static RField r_NEED_GOLD;
		public static RField RNEED_GOLD
		{
			get
			{
				if(r_NEED_GOLD == null)
				{
					r_NEED_GOLD = new( ReleactionUtils.GetType("PetGiftGhostTemplate"), "NEED_GOLD");
					r_NEED_GOLD.SetBelong(null);
				}
				return r_NEED_GOLD;
			}
		}

		/// <summary>
		/// System.String EXC_SPEED
		/// </summary>
		protected static RField r_EXC_SPEED;
		public static RField REXC_SPEED
		{
			get
			{
				if(r_EXC_SPEED == null)
				{
					r_EXC_SPEED = new( ReleactionUtils.GetType("PetGiftGhostTemplate"), "EXC_SPEED");
					r_EXC_SPEED.SetBelong(null);
				}
				return r_EXC_SPEED;
			}
		}

		/// <summary>
		/// Boolean IsReadyToUse
		/// </summary>
		protected RProperty r_IsReadyToUse;
		public virtual RProperty RIsReadyToUse
		{
			get
			{
				if(r_IsReadyToUse == null)
				{
					r_IsReadyToUse = new(this, "IsReadyToUse", -1);
					r_IsReadyToUse.SetBelong(this.instance);
				}
				return r_IsReadyToUse;
			}
		}

		/// <summary>
		/// Void OnLoadPetGhostConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPetGhostConfig_Object;
		public virtual RMethod ROnLoadPetGhostConfig_Object
		{
			get
			{
				if(r_ROnLoadPetGhostConfig_Object == null)
				{
					r_ROnLoadPetGhostConfig_Object = new(this, "OnLoadPetGhostConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPetGhostConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPetGhostConfig_Object;
			}
		}

		/// <summary>
		/// Void OnLoadPetSpecConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadPetSpecConfig_Object;
		public virtual RMethod ROnLoadPetSpecConfig_Object
		{
			get
			{
				if(r_ROnLoadPetSpecConfig_Object == null)
				{
					r_ROnLoadPetSpecConfig_Object = new(this, "OnLoadPetSpecConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadPetSpecConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadPetSpecConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetLevelPropertyValue(#u.#Zib, Int32, System.String)
		/// </summary>
		protected RMethod r_RGetLevelPropertyValue___0__Zib_Int32_String;
		public virtual RMethod RGetLevelPropertyValue___0__Zib_Int32_String
		{
			get
			{
				if(r_RGetLevelPropertyValue___0__Zib_Int32_String == null)
				{
					r_RGetLevelPropertyValue___0__Zib_Int32_String = new(this, "GetLevelPropertyValue", 0,  ReleactionUtils.GetType("#u.#Zib"), typeof(System.Int32), typeof(System.String));
					r_RGetLevelPropertyValue___0__Zib_Int32_String.SetBelong(this.instance);
				}
				return r_RGetLevelPropertyValue___0__Zib_Int32_String;
			}
		}

		/// <summary>
		/// System.String GetSpecLevelExp(Int32)
		/// </summary>
		protected RMethod r_RGetSpecLevelExp_Int32;
		public virtual RMethod RGetSpecLevelExp_Int32
		{
			get
			{
				if(r_RGetSpecLevelExp_Int32 == null)
				{
					r_RGetSpecLevelExp_Int32 = new(this, "GetSpecLevelExp", 0, typeof(System.Int32));
					r_RGetSpecLevelExp_Int32.SetBelong(this.instance);
				}
				return r_RGetSpecLevelExp_Int32;
			}
		}

		/// <summary>
		/// System.String GetSpecLevelGold(Int32)
		/// </summary>
		protected RMethod r_RGetSpecLevelGold_Int32;
		public virtual RMethod RGetSpecLevelGold_Int32
		{
			get
			{
				if(r_RGetSpecLevelGold_Int32 == null)
				{
					r_RGetSpecLevelGold_Int32 = new(this, "GetSpecLevelGold", 0, typeof(System.Int32));
					r_RGetSpecLevelGold_Int32.SetBelong(this.instance);
				}
				return r_RGetSpecLevelGold_Int32;
			}
		}

		/// <summary>
		/// System.String GetGhostLevelExp(Int32)
		/// </summary>
		protected RMethod r_RGetGhostLevelExp_Int32;
		public virtual RMethod RGetGhostLevelExp_Int32
		{
			get
			{
				if(r_RGetGhostLevelExp_Int32 == null)
				{
					r_RGetGhostLevelExp_Int32 = new(this, "GetGhostLevelExp", 0, typeof(System.Int32));
					r_RGetGhostLevelExp_Int32.SetBelong(this.instance);
				}
				return r_RGetGhostLevelExp_Int32;
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


        public RPetGiftGhostTemplate() : base("PetGiftGhostTemplate")
        {
        }

        public RPetGiftGhostTemplate(System.Object instance) : base("PetGiftGhostTemplate")
		{
            SetInstance(instance);
		}

        public RPetGiftGhostTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RPetGiftGhostTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadPetGhostConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadPetGhostConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadPetSpecConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadPetSpecConfig_Object.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.String GetSpecLevelExp(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetSpecLevelExp_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetSpecLevelGold(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetSpecLevelGold_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetGhostLevelExp(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetGhostLevelExp_Int32.Invoke(___genericsType, ___parameters);

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
