using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CharacterConfigTemplate
	/// </summary>
    public partial class RCharacterConfigTemplate : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,CareerConfig] CareerConfigGroup
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCareerConfig> r_CareerConfigGroup;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RCareerConfig> RCareerConfigGroup
		{
			get
			{
				if(r_CareerConfigGroup == null)
				{
					r_CareerConfigGroup = new(this, "CareerConfigGroup");
					r_CareerConfigGroup.SetBelong(this.instance);
				}
				return r_CareerConfigGroup;
			}
		}

		/// <summary>
		/// AvatarConfigHold m_avatarconfig
		/// </summary>
		protected RAvatarConfigHold r_m_avatarconfig;
		public virtual RAvatarConfigHold Rm_avatarconfig
		{
			get
			{
				if(r_m_avatarconfig == null)
				{
					r_m_avatarconfig = new(this, "m_avatarconfig");
					r_m_avatarconfig.SetBelong(this.instance);
				}
				return r_m_avatarconfig;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,CareerConfig] LoadCharacterConfig(UnityEngine.TextAsset)
		/// </summary>
		protected RMethod r_RLoadCharacterConfig_TextAsset;
		public virtual RMethod RLoadCharacterConfig_TextAsset
		{
			get
			{
				if(r_RLoadCharacterConfig_TextAsset == null)
				{
					r_RLoadCharacterConfig_TextAsset = new(this, "LoadCharacterConfig", 0, typeof(UnityEngine.TextAsset));
					r_RLoadCharacterConfig_TextAsset.SetBelong(this.instance);
				}
				return r_RLoadCharacterConfig_TextAsset;
			}
		}

		/// <summary>
		/// System.String GetCharacterCareerOriName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterCareerOriName_ID;
		public virtual RMethod RGetCharacterCareerOriName_ID
		{
			get
			{
				if(r_RGetCharacterCareerOriName_ID == null)
				{
					r_RGetCharacterCareerOriName_ID = new(this, "GetCharacterCareerOriName", 0, typeof(GameDefineType.ID));
					r_RGetCharacterCareerOriName_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterCareerOriName_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterCareerName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterCareerName_ID;
		public virtual RMethod RGetCharacterCareerName_ID
		{
			get
			{
				if(r_RGetCharacterCareerName_ID == null)
				{
					r_RGetCharacterCareerName_ID = new(this, "GetCharacterCareerName", 0, typeof(GameDefineType.ID));
					r_RGetCharacterCareerName_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterCareerName_ID;
			}
		}

		/// <summary>
		/// Boolean IsCharacterMale(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RIsCharacterMale_ID;
		public virtual RMethod RIsCharacterMale_ID
		{
			get
			{
				if(r_RIsCharacterMale_ID == null)
				{
					r_RIsCharacterMale_ID = new(this, "IsCharacterMale", 0, typeof(GameDefineType.ID));
					r_RIsCharacterMale_ID.SetBelong(this.instance);
				}
				return r_RIsCharacterMale_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterMaleName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterMaleName_ID;
		public virtual RMethod RGetCharacterMaleName_ID
		{
			get
			{
				if(r_RGetCharacterMaleName_ID == null)
				{
					r_RGetCharacterMaleName_ID = new(this, "GetCharacterMaleName", 0, typeof(GameDefineType.ID));
					r_RGetCharacterMaleName_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterMaleName_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterHeadIconName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterHeadIconName_ID;
		public virtual RMethod RGetCharacterHeadIconName_ID
		{
			get
			{
				if(r_RGetCharacterHeadIconName_ID == null)
				{
					r_RGetCharacterHeadIconName_ID = new(this, "GetCharacterHeadIconName", 0, typeof(GameDefineType.ID));
					r_RGetCharacterHeadIconName_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterHeadIconName_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterCGName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterCGName_ID;
		public virtual RMethod RGetCharacterCGName_ID
		{
			get
			{
				if(r_RGetCharacterCGName_ID == null)
				{
					r_RGetCharacterCGName_ID = new(this, "GetCharacterCGName", 0, typeof(GameDefineType.ID));
					r_RGetCharacterCGName_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterCGName_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterCGheadIcon(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterCGheadIcon_ID;
		public virtual RMethod RGetCharacterCGheadIcon_ID
		{
			get
			{
				if(r_RGetCharacterCGheadIcon_ID == null)
				{
					r_RGetCharacterCGheadIcon_ID = new(this, "GetCharacterCGheadIcon", 0, typeof(GameDefineType.ID));
					r_RGetCharacterCGheadIcon_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterCGheadIcon_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterModelConfig(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterModelConfig_ID;
		public virtual RMethod RGetCharacterModelConfig_ID
		{
			get
			{
				if(r_RGetCharacterModelConfig_ID == null)
				{
					r_RGetCharacterModelConfig_ID = new(this, "GetCharacterModelConfig", 0, typeof(GameDefineType.ID));
					r_RGetCharacterModelConfig_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterModelConfig_ID;
			}
		}

		/// <summary>
		/// GameDefineType.ID GetCharacterCareerIdByMod(System.String)
		/// </summary>
		protected RMethod r_RGetCharacterCareerIdByMod_String;
		public virtual RMethod RGetCharacterCareerIdByMod_String
		{
			get
			{
				if(r_RGetCharacterCareerIdByMod_String == null)
				{
					r_RGetCharacterCareerIdByMod_String = new(this, "GetCharacterCareerIdByMod", 0, typeof(System.String));
					r_RGetCharacterCareerIdByMod_String.SetBelong(this.instance);
				}
				return r_RGetCharacterCareerIdByMod_String;
			}
		}

		/// <summary>
		/// System.String GetCharacterCodeName(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterCodeName_ID;
		public virtual RMethod RGetCharacterCodeName_ID
		{
			get
			{
				if(r_RGetCharacterCodeName_ID == null)
				{
					r_RGetCharacterCodeName_ID = new(this, "GetCharacterCodeName", 0, typeof(GameDefineType.ID));
					r_RGetCharacterCodeName_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterCodeName_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterCareerDesc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterCareerDesc_ID;
		public virtual RMethod RGetCharacterCareerDesc_ID
		{
			get
			{
				if(r_RGetCharacterCareerDesc_ID == null)
				{
					r_RGetCharacterCareerDesc_ID = new(this, "GetCharacterCareerDesc", 0, typeof(GameDefineType.ID));
					r_RGetCharacterCareerDesc_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterCareerDesc_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterSkillDesc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterSkillDesc_ID;
		public virtual RMethod RGetCharacterSkillDesc_ID
		{
			get
			{
				if(r_RGetCharacterSkillDesc_ID == null)
				{
					r_RGetCharacterSkillDesc_ID = new(this, "GetCharacterSkillDesc", 0, typeof(GameDefineType.ID));
					r_RGetCharacterSkillDesc_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterSkillDesc_ID;
			}
		}

		/// <summary>
		/// System.String GetCharacterWeaponDesc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetCharacterWeaponDesc_ID;
		public virtual RMethod RGetCharacterWeaponDesc_ID
		{
			get
			{
				if(r_RGetCharacterWeaponDesc_ID == null)
				{
					r_RGetCharacterWeaponDesc_ID = new(this, "GetCharacterWeaponDesc", 0, typeof(GameDefineType.ID));
					r_RGetCharacterWeaponDesc_ID.SetBelong(this.instance);
				}
				return r_RGetCharacterWeaponDesc_ID;
			}
		}

		/// <summary>
		/// Void OnLoadAvatarConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadAvatarConfig_Object;
		public virtual RMethod ROnLoadAvatarConfig_Object
		{
			get
			{
				if(r_ROnLoadAvatarConfig_Object == null)
				{
					r_ROnLoadAvatarConfig_Object = new(this, "OnLoadAvatarConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadAvatarConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadAvatarConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetAvatarConfig(GameDefineType.ID, GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetAvatarConfig_ID_ID;
		public virtual RMethod RGetAvatarConfig_ID_ID
		{
			get
			{
				if(r_RGetAvatarConfig_ID_ID == null)
				{
					r_RGetAvatarConfig_ID_ID = new(this, "GetAvatarConfig", 0, typeof(GameDefineType.ID), typeof(GameDefineType.ID));
					r_RGetAvatarConfig_ID_ID.SetBelong(this.instance);
				}
				return r_RGetAvatarConfig_ID_ID;
			}
		}

		/// <summary>
		/// System.String AvatarStringReplacement(GameDefineType.ID, System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RAvatarStringReplacement_ID_String_String_String;
		public virtual RMethod RAvatarStringReplacement_ID_String_String_String
		{
			get
			{
				if(r_RAvatarStringReplacement_ID_String_String_String == null)
				{
					r_RAvatarStringReplacement_ID_String_String_String = new(this, "AvatarStringReplacement", 0, typeof(GameDefineType.ID), typeof(System.String), typeof(System.String), typeof(System.String));
					r_RAvatarStringReplacement_ID_String_String_String.SetBelong(this.instance);
				}
				return r_RAvatarStringReplacement_ID_String_String_String;
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


        public RCharacterConfigTemplate() : base("CharacterConfigTemplate")
        {
        }

        public RCharacterConfigTemplate(System.Object instance) : base("CharacterConfigTemplate")
		{
            SetInstance(instance);
		}

        public RCharacterConfigTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCharacterConfigTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object LoadCharacterConfig(UnityEngine.TextAsset  @CharacterConfig)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@CharacterConfig};
            var ___result = RLoadCharacterConfig_TextAsset.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.String GetCharacterCareerOriName(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterCareerOriName_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCharacterCareerName(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterCareerName_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean IsCharacterMale(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RIsCharacterMale_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String GetCharacterMaleName(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterMaleName_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCharacterHeadIconName(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterHeadIconName_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCharacterCGName(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterCGName_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCharacterCGheadIcon(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterCGheadIcon_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCharacterModelConfig(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterModelConfig_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual GameDefineType.ID GetCharacterCareerIdByMod(System.String  @mod)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mod};
            var ___result = RGetCharacterCareerIdByMod_String.Invoke(___genericsType, ___parameters);

            return (GameDefineType.ID)___result;
        }


        public virtual System.String GetCharacterCodeName(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterCodeName_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCharacterCareerDesc(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterCareerDesc_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCharacterSkillDesc(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterSkillDesc_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetCharacterWeaponDesc(GameDefineType.ID  @careerID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID};
            var ___result = RGetCharacterWeaponDesc_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void OnLoadAvatarConfig(UnityEngine.Object  @configAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@configAssets};
            var ___result = ROnLoadAvatarConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetAvatarConfig(GameDefineType.ID  @careerID, GameDefineType.ID  @avatarID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@careerID, @avatarID};
            var ___result = RGetAvatarConfig_ID_ID.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String AvatarStringReplacement(GameDefineType.ID  @carrer, System.String  @_bodyStr, System.String  @_faceStr, System.String  @_hairStr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@carrer, @_bodyStr, @_faceStr, @_hairStr};
            var ___result = RAvatarStringReplacement_ID_String_String_String.Invoke(___genericsType, ___parameters);

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
