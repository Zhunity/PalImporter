using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// LevelExperienceParser
	/// </summary>
    public partial class RLevelExperienceParser : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.Dictionary`2[System.String,System.String]] _levelExpDict
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RField, RField>> r__levelExpDict;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RDictionary<RField, RField>> R_levelExpDict
		{
			get
			{
				if(r__levelExpDict == null)
				{
					r__levelExpDict = new(this, "_levelExpDict");
					r__levelExpDict.SetBelong(this.instance);
				}
				return r__levelExpDict;
			}
		}

		/// <summary>
		/// System.String ROOT_NAME
		/// </summary>
		protected static RField r_ROOT_NAME;
		public static RField ROOT_NAME
		{
			get
			{
				if(r_ROOT_NAME == null)
				{
					r_ROOT_NAME = new( ReleactionUtils.GetType("LevelExperienceParser"), "ROOT_NAME");
					r_ROOT_NAME.SetBelong(null);
				}
				return r_ROOT_NAME;
			}
		}

		/// <summary>
		/// System.Boolean _readyToUse
		/// </summary>
		protected RField r__readyToUse;
		public virtual RField R_readyToUse
		{
			get
			{
				if(r__readyToUse == null)
				{
					r__readyToUse = new(this, "_readyToUse");
					r__readyToUse.SetBelong(this.instance);
				}
				return r__readyToUse;
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
		/// Void OnLoadLevelExperienceConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadLevelExperienceConfig_Object;
		public virtual RMethod ROnLoadLevelExperienceConfig_Object
		{
			get
			{
				if(r_ROnLoadLevelExperienceConfig_Object == null)
				{
					r_ROnLoadLevelExperienceConfig_Object = new(this, "OnLoadLevelExperienceConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadLevelExperienceConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadLevelExperienceConfig_Object;
			}
		}

		/// <summary>
		/// Int32 GetExpPropVal(Int32, System.String)
		/// </summary>
		protected RMethod r_RGetExpPropVal_Int32_String;
		public virtual RMethod RGetExpPropVal_Int32_String
		{
			get
			{
				if(r_RGetExpPropVal_Int32_String == null)
				{
					r_RGetExpPropVal_Int32_String = new(this, "GetExpPropVal", 0, typeof(System.Int32), typeof(System.String));
					r_RGetExpPropVal_Int32_String.SetBelong(this.instance);
				}
				return r_RGetExpPropVal_Int32_String;
			}
		}

		/// <summary>
		/// System.String GetChildLevelExp(System.String)
		/// </summary>
		protected RMethod r_RGetChildLevelExp_String;
		public virtual RMethod RGetChildLevelExp_String
		{
			get
			{
				if(r_RGetChildLevelExp_String == null)
				{
					r_RGetChildLevelExp_String = new(this, "GetChildLevelExp", 0, typeof(System.String));
					r_RGetChildLevelExp_String.SetBelong(this.instance);
				}
				return r_RGetChildLevelExp_String;
			}
		}

		/// <summary>
		/// System.String GetLevelExp(System.String)
		/// </summary>
		protected RMethod r_RGetLevelExp_String;
		public virtual RMethod RGetLevelExp_String
		{
			get
			{
				if(r_RGetLevelExp_String == null)
				{
					r_RGetLevelExp_String = new(this, "GetLevelExp", 0, typeof(System.String));
					r_RGetLevelExp_String.SetBelong(this.instance);
				}
				return r_RGetLevelExp_String;
			}
		}

		/// <summary>
		/// Boolean ContainLevelExp(System.String)
		/// </summary>
		protected RMethod r_RContainLevelExp_String;
		public virtual RMethod RContainLevelExp_String
		{
			get
			{
				if(r_RContainLevelExp_String == null)
				{
					r_RContainLevelExp_String = new(this, "ContainLevelExp", 0, typeof(System.String));
					r_RContainLevelExp_String.SetBelong(this.instance);
				}
				return r_RContainLevelExp_String;
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


        public RLevelExperienceParser() : base("LevelExperienceParser")
        {
        }

        public RLevelExperienceParser(System.Object instance) : base("LevelExperienceParser")
		{
            SetInstance(instance);
		}

        public RLevelExperienceParser(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLevelExperienceParser(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadLevelExperienceConfig(UnityEngine.Object  @fileAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fileAsset};
            var ___result = ROnLoadLevelExperienceConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetExpPropVal(System.Int32  @level, System.String  @expname)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level, @expname};
            var ___result = RGetExpPropVal_Int32_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetChildLevelExp(System.String  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetChildLevelExp_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetLevelExp(System.String  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetLevelExp_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ContainLevelExp(System.String  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RContainLevelExp_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
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
