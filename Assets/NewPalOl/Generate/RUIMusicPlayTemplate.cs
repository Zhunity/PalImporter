using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// UIMusicPlayTemplate
	/// </summary>
    public partial class RUIMusicPlayTemplate : RMember //
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
		/// System.String CommonMusicPlay
		/// </summary>
		protected static RField r_CommonMusicPlay;
		public static RField RCommonMusicPlay
		{
			get
			{
				if(r_CommonMusicPlay == null)
				{
					r_CommonMusicPlay = new( ReleactionUtils.GetType("UIMusicPlayTemplate"), "CommonMusicPlay");
					r_CommonMusicPlay.SetBelong(null);
				}
				return r_CommonMusicPlay;
			}
		}

		/// <summary>
		/// System.String NoOpenSoundWindow
		/// </summary>
		protected static RField r_NoOpenSoundWindow;
		public static RField RNoOpenSoundWindow
		{
			get
			{
				if(r_NoOpenSoundWindow == null)
				{
					r_NoOpenSoundWindow = new( ReleactionUtils.GetType("UIMusicPlayTemplate"), "NoOpenSoundWindow");
					r_NoOpenSoundWindow.SetBelong(null);
				}
				return r_NoOpenSoundWindow;
			}
		}

		/// <summary>
		/// System.String WindowUIEvent
		/// </summary>
		protected static RField r_WindowUIEvent;
		public static RField RWindowUIEvent
		{
			get
			{
				if(r_WindowUIEvent == null)
				{
					r_WindowUIEvent = new( ReleactionUtils.GetType("UIMusicPlayTemplate"), "WindowUIEvent");
					r_WindowUIEvent.SetBelong(null);
				}
				return r_WindowUIEvent;
			}
		}

		/// <summary>
		/// WindowMusicPlayMap _musicMap
		/// </summary>
		protected RWindowMusicPlayMap r__musicMap;
		public virtual RWindowMusicPlayMap R_musicMap
		{
			get
			{
				if(r__musicMap == null)
				{
					r__musicMap = new(this, "_musicMap");
					r__musicMap.SetBelong(this.instance);
				}
				return r__musicMap;
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
		/// Void OnLoadWindowMusicPlayConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadWindowMusicPlayConfig_Object;
		public virtual RMethod ROnLoadWindowMusicPlayConfig_Object
		{
			get
			{
				if(r_ROnLoadWindowMusicPlayConfig_Object == null)
				{
					r_ROnLoadWindowMusicPlayConfig_Object = new(this, "OnLoadWindowMusicPlayConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadWindowMusicPlayConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadWindowMusicPlayConfig_Object;
			}
		}

		/// <summary>
		/// System.String GetMusicPlayID(System.String, System.String, UI_EVENT_TYPE)
		/// </summary>
		protected RMethod r_RGetMusicPlayID_String_String_UI_EVENT_TYPE;
		public virtual RMethod RGetMusicPlayID_String_String_UI_EVENT_TYPE
		{
			get
			{
				if(r_RGetMusicPlayID_String_String_UI_EVENT_TYPE == null)
				{
					r_RGetMusicPlayID_String_String_UI_EVENT_TYPE = new(this, "GetMusicPlayID", 0, typeof(System.String), typeof(System.String),  ReleactionUtils.GetType("UIMusicPlayTemplate+UI_EVENT_TYPE"));
					r_RGetMusicPlayID_String_String_UI_EVENT_TYPE.SetBelong(this.instance);
				}
				return r_RGetMusicPlayID_String_String_UI_EVENT_TYPE;
			}
		}

		/// <summary>
		/// System.String GetCommonMusicPlayID(System.String, UI_EVENT_TYPE)
		/// </summary>
		protected RMethod r_RGetCommonMusicPlayID_String_UI_EVENT_TYPE;
		public virtual RMethod RGetCommonMusicPlayID_String_UI_EVENT_TYPE
		{
			get
			{
				if(r_RGetCommonMusicPlayID_String_UI_EVENT_TYPE == null)
				{
					r_RGetCommonMusicPlayID_String_UI_EVENT_TYPE = new(this, "GetCommonMusicPlayID", 0, typeof(System.String),  ReleactionUtils.GetType("UIMusicPlayTemplate+UI_EVENT_TYPE"));
					r_RGetCommonMusicPlayID_String_UI_EVENT_TYPE.SetBelong(this.instance);
				}
				return r_RGetCommonMusicPlayID_String_UI_EVENT_TYPE;
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


        public RUIMusicPlayTemplate() : base("UIMusicPlayTemplate")
        {
        }

        public RUIMusicPlayTemplate(System.Object instance) : base("UIMusicPlayTemplate")
		{
            SetInstance(instance);
		}

        public RUIMusicPlayTemplate(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUIMusicPlayTemplate(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnLoadWindowMusicPlayConfig(UnityEngine.Object  @textAsset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAsset};
            var ___result = ROnLoadWindowMusicPlayConfig_Object.Invoke(___genericsType, ___parameters);

            
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
