using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// WindowSettingTemplate
	/// </summary>
    public partial class RWindowSettingTemplate : RMember //
    {

		/// <summary>
		/// System.Boolean _loadedSettings
		/// </summary>
		protected RField r__loadedSettings;
		public virtual RField R_loadedSettings
		{
			get
			{
				if(r__loadedSettings == null)
				{
					r__loadedSettings = new(this, "_loadedSettings");
					r__loadedSettings.SetBelong(this.instance);
				}
				return r__loadedSettings;
			}
		}

		/// <summary>
		/// WindowSettingMap _settingMap
		/// </summary>
		protected RWindowSettingMap r__settingMap;
		public virtual RWindowSettingMap R_settingMap
		{
			get
			{
				if(r__settingMap == null)
				{
					r__settingMap = new(this, "_settingMap");
					r__settingMap.SetBelong(this.instance);
				}
				return r__settingMap;
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
		/// Void OnLoadWindowSettingConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadWindowSettingConfig_Object;
		public virtual RMethod ROnLoadWindowSettingConfig_Object
		{
			get
			{
				if(r_ROnLoadWindowSettingConfig_Object == null)
				{
					r_ROnLoadWindowSettingConfig_Object = new(this, "OnLoadWindowSettingConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadWindowSettingConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadWindowSettingConfig_Object;
			}
		}

		/// <summary>
		/// Void LoadConfig(System.String)
		/// </summary>
		protected RMethod r_RLoadConfig_String;
		public virtual RMethod RLoadConfig_String
		{
			get
			{
				if(r_RLoadConfig_String == null)
				{
					r_RLoadConfig_String = new(this, "LoadConfig", 0, typeof(System.String));
					r_RLoadConfig_String.SetBelong(this.instance);
				}
				return r_RLoadConfig_String;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 GetWindowLocation(System.String)
		/// </summary>
		protected RMethod r_RGetWindowLocation_String;
		public virtual RMethod RGetWindowLocation_String
		{
			get
			{
				if(r_RGetWindowLocation_String == null)
				{
					r_RGetWindowLocation_String = new(this, "GetWindowLocation", 0, typeof(System.String));
					r_RGetWindowLocation_String.SetBelong(this.instance);
				}
				return r_RGetWindowLocation_String;
			}
		}

		/// <summary>
		/// Void UpdateWindowLocation(System.String, UnityEngine.Vector2)
		/// </summary>
		protected RMethod r_RUpdateWindowLocation_String_Vector2;
		public virtual RMethod RUpdateWindowLocation_String_Vector2
		{
			get
			{
				if(r_RUpdateWindowLocation_String_Vector2 == null)
				{
					r_RUpdateWindowLocation_String_Vector2 = new(this, "UpdateWindowLocation", 0, typeof(System.String), typeof(UnityEngine.Vector2));
					r_RUpdateWindowLocation_String_Vector2.SetBelong(this.instance);
				}
				return r_RUpdateWindowLocation_String_Vector2;
			}
		}

		/// <summary>
		/// #u.#QHb GetWindowAnimationParams(System.String)
		/// </summary>
		protected RMethod r_RGetWindowAnimationParams_String;
		public virtual RMethod RGetWindowAnimationParams_String
		{
			get
			{
				if(r_RGetWindowAnimationParams_String == null)
				{
					r_RGetWindowAnimationParams_String = new(this, "GetWindowAnimationParams", 0, typeof(System.String));
					r_RGetWindowAnimationParams_String.SetBelong(this.instance);
				}
				return r_RGetWindowAnimationParams_String;
			}
		}

		/// <summary>
		/// Boolean ContainWindowSetting(System.String)
		/// </summary>
		protected RMethod r_RContainWindowSetting_String;
		public virtual RMethod RContainWindowSetting_String
		{
			get
			{
				if(r_RContainWindowSetting_String == null)
				{
					r_RContainWindowSetting_String = new(this, "ContainWindowSetting", 0, typeof(System.String));
					r_RContainWindowSetting_String.SetBelong(this.instance);
				}
				return r_RContainWindowSetting_String;
			}
		}

		/// <summary>
		/// Void FadeOutConflictWindows(System.String)
		/// </summary>
		protected RMethod r_RFadeOutConflictWindows_String;
		public virtual RMethod RFadeOutConflictWindows_String
		{
			get
			{
				if(r_RFadeOutConflictWindows_String == null)
				{
					r_RFadeOutConflictWindows_String = new(this, "FadeOutConflictWindows", 0, typeof(System.String));
					r_RFadeOutConflictWindows_String.SetBelong(this.instance);
				}
				return r_RFadeOutConflictWindows_String;
			}
		}

		/// <summary>
		/// Void CloseConflictWindows(System.String)
		/// </summary>
		protected RMethod r_RCloseConflictWindows_String;
		public virtual RMethod RCloseConflictWindows_String
		{
			get
			{
				if(r_RCloseConflictWindows_String == null)
				{
					r_RCloseConflictWindows_String = new(this, "CloseConflictWindows", 0, typeof(System.String));
					r_RCloseConflictWindows_String.SetBelong(this.instance);
				}
				return r_RCloseConflictWindows_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] GetOpenRelationWindows(System.String)
		/// </summary>
		protected RMethod r_RGetOpenRelationWindows_String;
		public virtual RMethod RGetOpenRelationWindows_String
		{
			get
			{
				if(r_RGetOpenRelationWindows_String == null)
				{
					r_RGetOpenRelationWindows_String = new(this, "GetOpenRelationWindows", 0, typeof(System.String));
					r_RGetOpenRelationWindows_String.SetBelong(this.instance);
				}
				return r_RGetOpenRelationWindows_String;
			}
		}

		/// <summary>
		/// Void OpenRelationWindows(System.String)
		/// </summary>
		protected RMethod r_ROpenRelationWindows_String;
		public virtual RMethod ROpenRelationWindows_String
		{
			get
			{
				if(r_ROpenRelationWindows_String == null)
				{
					r_ROpenRelationWindows_String = new(this, "OpenRelationWindows", 0, typeof(System.String));
					r_ROpenRelationWindows_String.SetBelong(this.instance);
				}
				return r_ROpenRelationWindows_String;
			}
		}

		/// <summary>
		/// Void FadeRelationWindwos(System.String, Boolean)
		/// </summary>
		protected RMethod r_RFadeRelationWindwos_String_Boolean;
		public virtual RMethod RFadeRelationWindwos_String_Boolean
		{
			get
			{
				if(r_RFadeRelationWindwos_String_Boolean == null)
				{
					r_RFadeRelationWindwos_String_Boolean = new(this, "FadeRelationWindwos", 0, typeof(System.String), typeof(System.Boolean));
					r_RFadeRelationWindwos_String_Boolean.SetBelong(this.instance);
				}
				return r_RFadeRelationWindwos_String_Boolean;
			}
		}

		/// <summary>
		/// Void CloseRelationWindows(System.String)
		/// </summary>
		protected RMethod r_RCloseRelationWindows_String;
		public virtual RMethod RCloseRelationWindows_String
		{
			get
			{
				if(r_RCloseRelationWindows_String == null)
				{
					r_RCloseRelationWindows_String = new(this, "CloseRelationWindows", 0, typeof(System.String));
					r_RCloseRelationWindows_String.SetBelong(this.instance);
				}
				return r_RCloseRelationWindows_String;
			}
		}

		/// <summary>
		/// Void OpenSelfAndRelationWindows(#oU.#05)
		/// </summary>
		protected RMethod r_ROpenSelfAndRelationWindows___0__05;
		public virtual RMethod ROpenSelfAndRelationWindows___0__05
		{
			get
			{
				if(r_ROpenSelfAndRelationWindows___0__05 == null)
				{
					r_ROpenSelfAndRelationWindows___0__05 = new(this, "OpenSelfAndRelationWindows", 0,  ReleactionUtils.GetType("#oU.#05"));
					r_ROpenSelfAndRelationWindows___0__05.SetBelong(this.instance);
				}
				return r_ROpenSelfAndRelationWindows___0__05;
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


        public RWindowSettingTemplate() : base("WindowSettingTemplate")
        {
        }

        public RWindowSettingTemplate(System.Object instance) : base("WindowSettingTemplate")
		{
            SetInstance(instance);
		}

        public RWindowSettingTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWindowSettingTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadWindowSettingConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadWindowSettingConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadConfig(System.String  @text)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text};
            var ___result = RLoadConfig_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector2 GetWindowLocation(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = RGetWindowLocation_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector2)___result;
        }


        public virtual void UpdateWindowLocation(System.String  @windowName, UnityEngine.Vector2  @loc)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName, @loc};
            var ___result = RUpdateWindowLocation_String_Vector2.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object GetWindowAnimationParams(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = RGetWindowAnimationParams_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean ContainWindowSetting(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = RContainWindowSetting_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void FadeOutConflictWindows(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = RFadeOutConflictWindows_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseConflictWindows(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = RCloseConflictWindows_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.Generic.List<System.String> GetOpenRelationWindows(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = RGetOpenRelationWindows_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.List<System.String>)___result;
        }


        public virtual void OpenRelationWindows(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = ROpenRelationWindows_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FadeRelationWindwos(System.String  @windowName, System.Boolean  @bOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName, @bOpen};
            var ___result = RFadeRelationWindwos_String_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CloseRelationWindows(System.String  @windowName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName};
            var ___result = RCloseRelationWindows_String.Invoke(___genericsType, ___parameters);

            
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
