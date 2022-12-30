using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// WindowTipTextTemplate
	/// </summary>
    public partial class RWindowTipTextTemplate : RMember //
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
		/// WindowTipTextMap _tipTextMap
		/// </summary>
		protected RWindowTipTextMap r__tipTextMap;
		public virtual RWindowTipTextMap R_tipTextMap
		{
			get
			{
				if(r__tipTextMap == null)
				{
					r__tipTextMap = new(this, "_tipTextMap");
					r__tipTextMap.SetBelong(this.instance);
				}
				return r__tipTextMap;
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
		/// WindowTipTextMap TipTextMap
		/// </summary>
		protected RWindowTipTextMap r_TipTextMap;
		public virtual RWindowTipTextMap RTipTextMap
		{
			get
			{
				if(r_TipTextMap == null)
				{
					r_TipTextMap = new(this, "TipTextMap", -1);
					r_TipTextMap.SetBelong(this.instance);
				}
				return r_TipTextMap;
			}
		}

		/// <summary>
		/// Void OnLoadWindowTipTextConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadWindowTipTextConfig_Object;
		public virtual RMethod ROnLoadWindowTipTextConfig_Object
		{
			get
			{
				if(r_ROnLoadWindowTipTextConfig_Object == null)
				{
					r_ROnLoadWindowTipTextConfig_Object = new(this, "OnLoadWindowTipTextConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadWindowTipTextConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadWindowTipTextConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetRawWindowElementTipText(System.String, System.String)
		/// </summary>
		protected RMethod r_RGetRawWindowElementTipText_String_String;
		public virtual RMethod RGetRawWindowElementTipText_String_String
		{
			get
			{
				if(r_RGetRawWindowElementTipText_String_String == null)
				{
					r_RGetRawWindowElementTipText_String_String = new(this, "GetRawWindowElementTipText", 0, typeof(System.String), typeof(System.String));
					r_RGetRawWindowElementTipText_String_String.SetBelong(this.instance);
				}
				return r_RGetRawWindowElementTipText_String_String;
			}
		}

		/// <summary>
		/// System.String GetWindowElementTipText(System.String, System.String)
		/// </summary>
		protected RMethod r_RGetWindowElementTipText_String_String;
		public virtual RMethod RGetWindowElementTipText_String_String
		{
			get
			{
				if(r_RGetWindowElementTipText_String_String == null)
				{
					r_RGetWindowElementTipText_String_String = new(this, "GetWindowElementTipText", 0, typeof(System.String), typeof(System.String));
					r_RGetWindowElementTipText_String_String.SetBelong(this.instance);
				}
				return r_RGetWindowElementTipText_String_String;
			}
		}

		/// <summary>
		/// System.String GetWindowElementTipTextFormat(System.String, System.String, System.Object[])
		/// </summary>
		protected RMethod r_RGetWindowElementTipTextFormat_String_String_ObjectArray;
		public virtual RMethod RGetWindowElementTipTextFormat_String_String_ObjectArray
		{
			get
			{
				if(r_RGetWindowElementTipTextFormat_String_String_ObjectArray == null)
				{
					r_RGetWindowElementTipTextFormat_String_String_ObjectArray = new(this, "GetWindowElementTipTextFormat", 0, typeof(System.String), typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RGetWindowElementTipTextFormat_String_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RGetWindowElementTipTextFormat_String_String_ObjectArray;
			}
		}

		/// <summary>
		/// Boolean ConflictWithWindow(System.String, System.String)
		/// </summary>
		protected RMethod r_RConflictWithWindow_String_String;
		public virtual RMethod RConflictWithWindow_String_String
		{
			get
			{
				if(r_RConflictWithWindow_String_String == null)
				{
					r_RConflictWithWindow_String_String = new(this, "ConflictWithWindow", 0, typeof(System.String), typeof(System.String));
					r_RConflictWithWindow_String_String.SetBelong(this.instance);
				}
				return r_RConflictWithWindow_String_String;
			}
		}

		/// <summary>
		/// System.String ParseTipText(System.String, System.String)
		/// </summary>
		protected RMethod r_RParseTipText_String_String;
		public virtual RMethod RParseTipText_String_String
		{
			get
			{
				if(r_RParseTipText_String_String == null)
				{
					r_RParseTipText_String_String = new(this, "ParseTipText", 0, typeof(System.String), typeof(System.String));
					r_RParseTipText_String_String.SetBelong(this.instance);
				}
				return r_RParseTipText_String_String;
			}
		}

		/// <summary>
		/// System.String GetPropertyValue(System.String, System.String)
		/// </summary>
		protected RMethod r_RGetPropertyValue_String_String;
		public virtual RMethod RGetPropertyValue_String_String
		{
			get
			{
				if(r_RGetPropertyValue_String_String == null)
				{
					r_RGetPropertyValue_String_String = new(this, "GetPropertyValue", 0, typeof(System.String), typeof(System.String));
					r_RGetPropertyValue_String_String.SetBelong(this.instance);
				}
				return r_RGetPropertyValue_String_String;
			}
		}

		/// <summary>
		/// System.String ValueToInt(#u.#Ieb, System.String)
		/// </summary>
		protected RMethod r_RValueToInt___0__Ieb_String;
		public virtual RMethod RValueToInt___0__Ieb_String
		{
			get
			{
				if(r_RValueToInt___0__Ieb_String == null)
				{
					r_RValueToInt___0__Ieb_String = new(this, "ValueToInt", 0,  ReleactionUtils.GetType("#u.#Ieb"), typeof(System.String));
					r_RValueToInt___0__Ieb_String.SetBelong(this.instance);
				}
				return r_RValueToInt___0__Ieb_String;
			}
		}

		/// <summary>
		/// #u.#Ieb GetPropertyData(System.String)
		/// </summary>
		protected RMethod r_RGetPropertyData_String;
		public virtual RMethod RGetPropertyData_String
		{
			get
			{
				if(r_RGetPropertyData_String == null)
				{
					r_RGetPropertyData_String = new(this, "GetPropertyData", 0, typeof(System.String));
					r_RGetPropertyData_String.SetBelong(this.instance);
				}
				return r_RGetPropertyData_String;
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


        public RWindowTipTextTemplate() : base("WindowTipTextTemplate")
        {
        }

        public RWindowTipTextTemplate(System.Object instance) : base("WindowTipTextTemplate")
		{
            SetInstance(instance);
		}

        public RWindowTipTextTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RWindowTipTextTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadWindowTipTextConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadWindowTipTextConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetRawWindowElementTipText(System.String  @windowName, System.String  @elementName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName, @elementName};
            var ___result = RGetRawWindowElementTipText_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetWindowElementTipText(System.String  @windowName, System.String  @elementName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName, @elementName};
            var ___result = RGetWindowElementTipText_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetWindowElementTipTextFormat(System.String  @windowName, System.String  @elementName, System.Object[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName, @elementName, @args};
            var ___result = RGetWindowElementTipTextFormat_String_String_ObjectArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ConflictWithWindow(System.String  @windowName, System.String  @elementName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@windowName, @elementName};
            var ___result = RConflictWithWindow_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ParseTipText(System.String  @creatureType, System.String  @tipText)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@creatureType, @tipText};
            var ___result = RParseTipText_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetPropertyValue(System.String  @creatureType, System.String  @propName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@creatureType, @propName};
            var ___result = RGetPropertyValue_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual System.Object GetPropertyData(System.String  @creatureType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@creatureType};
            var ___result = RGetPropertyData_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
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
