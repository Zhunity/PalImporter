using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// UITextColorTemplate
	/// </summary>
    public partial class RUITextColorTemplate : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UITextColorContent] _colorTemplates
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUITextColorContent> r__colorTemplates;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUITextColorContent> R_colorTemplates
		{
			get
			{
				if(r__colorTemplates == null)
				{
					r__colorTemplates = new(this, "_colorTemplates");
					r__colorTemplates.SetBelong(this.instance);
				}
				return r__colorTemplates;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Collections.Generic.List`1[System.String]] _colorIDsMap
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RField>> r__colorIDsMap;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RField>> R_colorIDsMap
		{
			get
			{
				if(r__colorIDsMap == null)
				{
					r__colorIDsMap = new(this, "_colorIDsMap");
					r__colorIDsMap.SetBelong(this.instance);
				}
				return r__colorIDsMap;
			}
		}

		/// <summary>
		/// UnityEngine.Color _defaultColor
		/// </summary>
		protected RUnityEngine.RColor r__defaultColor;
		public virtual RUnityEngine.RColor R_defaultColor
		{
			get
			{
				if(r__defaultColor == null)
				{
					r__defaultColor = new(this, "_defaultColor");
					r__defaultColor.SetBelong(this.instance);
				}
				return r__defaultColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color DefineEnoughColor
		/// </summary>
		protected static RUnityEngine.RColor r_DefineEnoughColor;
		public static RUnityEngine.RColor RDefineEnoughColor
		{
			get
			{
				if(r_DefineEnoughColor == null)
				{
					r_DefineEnoughColor = new( ReleactionUtils.GetType("UITextColorTemplate"), "DefineEnoughColor");
					r_DefineEnoughColor.SetBelong(null);
				}
				return r_DefineEnoughColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color DefineNotEnoughColor
		/// </summary>
		protected static RUnityEngine.RColor r_DefineNotEnoughColor;
		public static RUnityEngine.RColor RDefineNotEnoughColor
		{
			get
			{
				if(r_DefineNotEnoughColor == null)
				{
					r_DefineNotEnoughColor = new( ReleactionUtils.GetType("UITextColorTemplate"), "DefineNotEnoughColor");
					r_DefineNotEnoughColor.SetBelong(null);
				}
				return r_DefineNotEnoughColor;
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
		/// Void OnLoadUITextColorTemplateConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadUITextColorTemplateConfig_Object;
		public virtual RMethod ROnLoadUITextColorTemplateConfig_Object
		{
			get
			{
				if(r_ROnLoadUITextColorTemplateConfig_Object == null)
				{
					r_ROnLoadUITextColorTemplateConfig_Object = new(this, "OnLoadUITextColorTemplateConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadUITextColorTemplateConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadUITextColorTemplateConfig_Object;
			}
		}

		/// <summary>
		/// Void OnGetColorNotify(System.Object, UITextColorContent)
		/// </summary>
		protected RMethod r_ROnGetColorNotify_Object_UITextColorContent;
		public virtual RMethod ROnGetColorNotify_Object_UITextColorContent
		{
			get
			{
				if(r_ROnGetColorNotify_Object_UITextColorContent == null)
				{
					r_ROnGetColorNotify_Object_UITextColorContent = new(this, "OnGetColorNotify", 0, typeof(System.Object),  ReleactionUtils.GetType("UITextColorContent"));
					r_ROnGetColorNotify_Object_UITextColorContent.SetBelong(this.instance);
				}
				return r_ROnGetColorNotify_Object_UITextColorContent;
			}
		}

		/// <summary>
		/// System.String GetSingleColorID(UnityEngine.Color)
		/// </summary>
		protected RMethod r_RGetSingleColorID_Color;
		public virtual RMethod RGetSingleColorID_Color
		{
			get
			{
				if(r_RGetSingleColorID_Color == null)
				{
					r_RGetSingleColorID_Color = new(this, "GetSingleColorID", 0, typeof(UnityEngine.Color));
					r_RGetSingleColorID_Color.SetBelong(this.instance);
				}
				return r_RGetSingleColorID_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColor(#u.#Ckb, System.String)
		/// </summary>
		protected RMethod r_RGetColor___0__Ckb_String;
		public virtual RMethod RGetColor___0__Ckb_String
		{
			get
			{
				if(r_RGetColor___0__Ckb_String == null)
				{
					r_RGetColor___0__Ckb_String = new(this, "GetColor", 0,  ReleactionUtils.GetType("#u.#Ckb"), typeof(System.String));
					r_RGetColor___0__Ckb_String.SetBelong(this.instance);
				}
				return r_RGetColor___0__Ckb_String;
			}
		}

		/// <summary>
		/// System.String GetHexColor(System.String)
		/// </summary>
		protected RMethod r_RGetHexColor_String;
		public virtual RMethod RGetHexColor_String
		{
			get
			{
				if(r_RGetHexColor_String == null)
				{
					r_RGetHexColor_String = new(this, "GetHexColor", 0, typeof(System.String));
					r_RGetHexColor_String.SetBelong(this.instance);
				}
				return r_RGetHexColor_String;
			}
		}

		/// <summary>
		/// Boolean HasColor(System.String)
		/// </summary>
		protected RMethod r_RHasColor_String;
		public virtual RMethod RHasColor_String
		{
			get
			{
				if(r_RHasColor_String == null)
				{
					r_RHasColor_String = new(this, "HasColor", 0, typeof(System.String));
					r_RHasColor_String.SetBelong(this.instance);
				}
				return r_RHasColor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColor(System.String)
		/// </summary>
		protected RMethod r_RGetColor_String;
		public virtual RMethod RGetColor_String
		{
			get
			{
				if(r_RGetColor_String == null)
				{
					r_RGetColor_String = new(this, "GetColor", 0, typeof(System.String));
					r_RGetColor_String.SetBelong(this.instance);
				}
				return r_RGetColor_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorByProperty(#u.#Ckb, UITextColorContent)
		/// </summary>
		protected RMethod r_RGetColorByProperty___0__Ckb_UITextColorContent;
		public virtual RMethod RGetColorByProperty___0__Ckb_UITextColorContent
		{
			get
			{
				if(r_RGetColorByProperty___0__Ckb_UITextColorContent == null)
				{
					r_RGetColorByProperty___0__Ckb_UITextColorContent = new(this, "GetColorByProperty", 0,  ReleactionUtils.GetType("#u.#Ckb"),  ReleactionUtils.GetType("UITextColorContent"));
					r_RGetColorByProperty___0__Ckb_UITextColorContent.SetBelong(this.instance);
				}
				return r_RGetColorByProperty___0__Ckb_UITextColorContent;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetRareColor(System.String)
		/// </summary>
		protected RMethod r_RGetRareColor_String;
		public virtual RMethod RGetRareColor_String
		{
			get
			{
				if(r_RGetRareColor_String == null)
				{
					r_RGetRareColor_String = new(this, "GetRareColor", 0, typeof(System.String));
					r_RGetRareColor_String.SetBelong(this.instance);
				}
				return r_RGetRareColor_String;
			}
		}

		/// <summary>
		/// Boolean GetPropertyName(System.String, System.String ByRef)
		/// </summary>
		protected RMethod r_RGetPropertyName_String_Out_String;
		public virtual RMethod RGetPropertyName_String_Out_String
		{
			get
			{
				if(r_RGetPropertyName_String_Out_String == null)
				{
					r_RGetPropertyName_String_Out_String = new(this, "GetPropertyName", 0, typeof(System.String), typeof(System.String).MakeByRefType());
					r_RGetPropertyName_String_Out_String.SetBelong(this.instance);
				}
				return r_RGetPropertyName_String_Out_String;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorByCMP_OP(#u.#Ckb, UITextColorContent)
		/// </summary>
		protected RMethod r_RGetColorByCMP_OP___0__Ckb_UITextColorContent;
		public virtual RMethod RGetColorByCMP_OP___0__Ckb_UITextColorContent
		{
			get
			{
				if(r_RGetColorByCMP_OP___0__Ckb_UITextColorContent == null)
				{
					r_RGetColorByCMP_OP___0__Ckb_UITextColorContent = new(this, "GetColorByCMP_OP", 0,  ReleactionUtils.GetType("#u.#Ckb"),  ReleactionUtils.GetType("UITextColorContent"));
					r_RGetColorByCMP_OP___0__Ckb_UITextColorContent.SetBelong(this.instance);
				}
				return r_RGetColorByCMP_OP___0__Ckb_UITextColorContent;
			}
		}

		/// <summary>
		/// Int32 GetCompareCode(Int32, Int32)
		/// </summary>
		protected RMethod r_RGetCompareCode_Int32_Int32;
		public virtual RMethod RGetCompareCode_Int32_Int32
		{
			get
			{
				if(r_RGetCompareCode_Int32_Int32 == null)
				{
					r_RGetCompareCode_Int32_Int32 = new(this, "GetCompareCode", 0, typeof(System.Int32), typeof(System.Int32));
					r_RGetCompareCode_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetCompareCode_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorByRare(#u.#Ckb)
		/// </summary>
		protected RMethod r_RGetColorByRare___0__Ckb;
		public virtual RMethod RGetColorByRare___0__Ckb
		{
			get
			{
				if(r_RGetColorByRare___0__Ckb == null)
				{
					r_RGetColorByRare___0__Ckb = new(this, "GetColorByRare", 0,  ReleactionUtils.GetType("#u.#Ckb"));
					r_RGetColorByRare___0__Ckb.SetBelong(this.instance);
				}
				return r_RGetColorByRare___0__Ckb;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorByRare(Int32)
		/// </summary>
		protected RMethod r_RGetColorByRare_Int32;
		public virtual RMethod RGetColorByRare_Int32
		{
			get
			{
				if(r_RGetColorByRare_Int32 == null)
				{
					r_RGetColorByRare_Int32 = new(this, "GetColorByRare", 0, typeof(System.Int32));
					r_RGetColorByRare_Int32.SetBelong(this.instance);
				}
				return r_RGetColorByRare_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Color GetColorRareByID(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RGetColorRareByID_ID;
		public virtual RMethod RGetColorRareByID_ID
		{
			get
			{
				if(r_RGetColorRareByID_ID == null)
				{
					r_RGetColorRareByID_ID = new(this, "GetColorRareByID", 0, typeof(GameDefineType.ID));
					r_RGetColorRareByID_ID.SetBelong(this.instance);
				}
				return r_RGetColorRareByID_ID;
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


        public RUITextColorTemplate() : base("UITextColorTemplate")
        {
        }

        public RUITextColorTemplate(System.Object instance) : base("UITextColorTemplate")
		{
            SetInstance(instance);
		}

        public RUITextColorTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUITextColorTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadUITextColorTemplateConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadUITextColorTemplateConfig_Object.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.String GetSingleColorID(UnityEngine.Color  @color)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@color};
            var ___result = RGetSingleColorID_Color.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }



        public virtual System.String GetHexColor(System.String  @colorID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorID};
            var ___result = RGetHexColor_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean HasColor(System.String  @colorstr)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorstr};
            var ___result = RHasColor_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Color GetColor(System.String  @colorID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colorID};
            var ___result = RGetColor_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }



        public virtual UnityEngine.Color GetRareColor(System.String  @propValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@propValue};
            var ___result = RGetRareColor_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual System.Boolean GetPropertyName(System.String  @text, out System.String  @name)
        {
			name = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@text, @name};
            var ___result = RGetPropertyName_String_Out_String.Invoke(___genericsType, ___parameters);
			name = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }



        public virtual System.Int32 GetCompareCode(System.Int32  @a, System.Int32  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = RGetCompareCode_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual UnityEngine.Color GetColorByRare(System.Int32  @rare)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rare};
            var ___result = RGetColorByRare_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
        }


        public virtual UnityEngine.Color GetColorRareByID(GameDefineType.ID  @itemId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@itemId};
            var ___result = RGetColorRareByID_ID.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Color)___result;
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
