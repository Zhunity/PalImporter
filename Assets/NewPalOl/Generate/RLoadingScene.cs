using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// LoadingScene
	/// </summary>
    public partial class RLoadingScene : RMember //
    {

		/// <summary>
		/// GameDefineType.ID #a
		/// </summary>
		protected RGameDefineType.RID r___0__a;
		public virtual RGameDefineType.RID R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
			}
		}

		/// <summary>
		/// System.Int32 #b
		/// </summary>
		protected RField r___0__b;
		public virtual RField R__0__b
		{
			get
			{
				if(r___0__b == null)
				{
					r___0__b = new(this, "#b");
					r___0__b.SetBelong(this.instance);
				}
				return r___0__b;
			}
		}

		/// <summary>
		/// System.Boolean #c
		/// </summary>
		protected RField r___0__c;
		public virtual RField R__0__c
		{
			get
			{
				if(r___0__c == null)
				{
					r___0__c = new(this, "#c");
					r___0__c.SetBelong(this.instance);
				}
				return r___0__c;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,System.Single] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField> R__0__d
		{
			get
			{
				if(r___0__d == null)
				{
					r___0__d = new(this, "#d");
					r___0__d.SetBelong(this.instance);
				}
				return r___0__d;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[System.String] #e
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField> r___0__e;
		public virtual RSystem.RCollections.RGeneric.RList<RField> R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(this, "#e");
					r___0__e.SetBelong(this.instance);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// System.Boolean #f
		/// </summary>
		protected RField r___0__f;
		public virtual RField R__0__f
		{
			get
			{
				if(r___0__f == null)
				{
					r___0__f = new(this, "#f");
					r___0__f.SetBelong(this.instance);
				}
				return r___0__f;
			}
		}

		/// <summary>
		/// GameDefineType.ID SceneID
		/// </summary>
		protected RGameDefineType.RID r_R__0__7Gb;
		public virtual RGameDefineType.RID R__0__7Gb
		{
			get
			{
				if(r_R__0__7Gb == null)
				{
					r_R__0__7Gb = new(this, "SceneID", -1);
					r_R__0__7Gb.SetBelong(this.instance);
				}
				return r_R__0__7Gb;
			}
		}

		/// <summary>
		/// System.String GameStaetName
		/// </summary>
		protected RProperty r_R__0__mGb;
		public virtual RProperty R__0__mGb
		{
			get
			{
				if(r_R__0__mGb == null)
				{
					r_R__0__mGb = new(this, "GameStaetName", -1);
					r_R__0__mGb.SetBelong(this.instance);
				}
				return r_R__0__mGb;
			}
		}

		/// <summary>
		/// Void #n4c(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__n4c_ID;
		public virtual RMethod R__0__n4c_ID
		{
			get
			{
				if(r_R__0__n4c_ID == null)
				{
					r_R__0__n4c_ID = new(this, "#n4c", 0, typeof(GameDefineType.ID));
					r_R__0__n4c_ID.SetBelong(this.instance);
				}
				return r_R__0__n4c_ID;
			}
		}

		/// <summary>
		/// Void #Pr(System.String)
		/// </summary>
		protected RMethod r_R__0__Pr_String;
		public virtual RMethod R__0__Pr_String
		{
			get
			{
				if(r_R__0__Pr_String == null)
				{
					r_R__0__Pr_String = new(this, "#Pr", 0, typeof(System.String));
					r_R__0__Pr_String.SetBelong(this.instance);
				}
				return r_R__0__Pr_String;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator #Add(System.String)
		/// </summary>
		protected RMethod r_R__0__Add_String;
		public virtual RMethod R__0__Add_String
		{
			get
			{
				if(r_R__0__Add_String == null)
				{
					r_R__0__Add_String = new(this, "#Add", 0, typeof(System.String));
					r_R__0__Add_String.SetBelong(this.instance);
				}
				return r_R__0__Add_String;
			}
		}

		/// <summary>
		/// Void #rGb(System.String)
		/// </summary>
		protected RMethod r_R__0__rGb_String;
		public virtual RMethod R__0__rGb_String
		{
			get
			{
				if(r_R__0__rGb_String == null)
				{
					r_R__0__rGb_String = new(this, "#rGb", 0, typeof(System.String));
					r_R__0__rGb_String.SetBelong(this.instance);
				}
				return r_R__0__rGb_String;
			}
		}

		/// <summary>
		/// Void #8Gb(System.String[])
		/// </summary>
		protected RMethod r_R__0__8Gb_StringArray;
		public virtual RMethod R__0__8Gb_StringArray
		{
			get
			{
				if(r_R__0__8Gb_StringArray == null)
				{
					r_R__0__8Gb_StringArray = new(this, "#8Gb", 0, typeof(System.String).MakeArrayType());
					r_R__0__8Gb_StringArray.SetBelong(this.instance);
				}
				return r_R__0__8Gb_StringArray;
			}
		}

		/// <summary>
		/// Void #9Gb()
		/// </summary>
		protected RMethod r_R__0__9Gb;
		public virtual RMethod R__0__9Gb
		{
			get
			{
				if(r_R__0__9Gb == null)
				{
					r_R__0__9Gb = new(this, "#9Gb", 0);
					r_R__0__9Gb.SetBelong(this.instance);
				}
				return r_R__0__9Gb;
			}
		}

		/// <summary>
		/// Void #aHb(System.Collections.Generic.List`1[System.String])
		/// </summary>
		protected RMethod r_R__0__aHb_List_d_String_p_;
		public virtual RMethod R__0__aHb_List_d_String_p_
		{
			get
			{
				if(r_R__0__aHb_List_d_String_p_ == null)
				{
					r_R__0__aHb_List_d_String_p_ = new(this, "#aHb", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(System.String)));
					r_R__0__aHb_List_d_String_p_.SetBelong(this.instance);
				}
				return r_R__0__aHb_List_d_String_p_;
			}
		}

		/// <summary>
		/// Void #dHb(System.Object, ABLoadingArgs)
		/// </summary>
		protected RMethod r_R__0__dHb_Object_ABLoadingArgs;
		public virtual RMethod R__0__dHb_Object_ABLoadingArgs
		{
			get
			{
				if(r_R__0__dHb_Object_ABLoadingArgs == null)
				{
					r_R__0__dHb_Object_ABLoadingArgs = new(this, "#dHb", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingArgs"));
					r_R__0__dHb_Object_ABLoadingArgs.SetBelong(this.instance);
				}
				return r_R__0__dHb_Object_ABLoadingArgs;
			}
		}

		/// <summary>
		/// Void #eHb(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_R__0__eHb_Object_ABLoadedArgs;
		public virtual RMethod R__0__eHb_Object_ABLoadedArgs
		{
			get
			{
				if(r_R__0__eHb_Object_ABLoadedArgs == null)
				{
					r_R__0__eHb_Object_ABLoadedArgs = new(this, "#eHb", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_R__0__eHb_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_R__0__eHb_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Single #fHb(ABLoadingArgs)
		/// </summary>
		protected RMethod r_R__0__fHb_ABLoadingArgs;
		public virtual RMethod R__0__fHb_ABLoadingArgs
		{
			get
			{
				if(r_R__0__fHb_ABLoadingArgs == null)
				{
					r_R__0__fHb_ABLoadingArgs = new(this, "#fHb", 0,  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadingArgs"));
					r_R__0__fHb_ABLoadingArgs.SetBelong(this.instance);
				}
				return r_R__0__fHb_ABLoadingArgs;
			}
		}

		/// <summary>
		/// Boolean #hgb(System.String)
		/// </summary>
		protected RMethod r_R__0__hgb_String;
		public virtual RMethod R__0__hgb_String
		{
			get
			{
				if(r_R__0__hgb_String == null)
				{
					r_R__0__hgb_String = new(this, "#hgb", 0, typeof(System.String));
					r_R__0__hgb_String.SetBelong(this.instance);
				}
				return r_R__0__hgb_String;
			}
		}

		/// <summary>
		/// Void SetWindow(MyGUIWindow)
		/// </summary>
		protected RMethod r_RSetWindow_MyGUIWindow;
		public virtual RMethod RSetWindow_MyGUIWindow
		{
			get
			{
				if(r_RSetWindow_MyGUIWindow == null)
				{
					r_RSetWindow_MyGUIWindow = new(this, "SetWindow", 0,  ReleactionUtils.GetType("MyGUIWindow"));
					r_RSetWindow_MyGUIWindow.SetBelong(this.instance);
				}
				return r_RSetWindow_MyGUIWindow;
			}
		}

		/// <summary>
		/// Void #sGb(System.String)
		/// </summary>
		protected RMethod r_R__0__sGb_String;
		public virtual RMethod R__0__sGb_String
		{
			get
			{
				if(r_R__0__sGb_String == null)
				{
					r_R__0__sGb_String = new(this, "#sGb", 0, typeof(System.String));
					r_R__0__sGb_String.SetBelong(this.instance);
				}
				return r_R__0__sGb_String;
			}
		}

		/// <summary>
		/// Void #tGb(System.String)
		/// </summary>
		protected RMethod r_R__0__tGb_String;
		public virtual RMethod R__0__tGb_String
		{
			get
			{
				if(r_R__0__tGb_String == null)
				{
					r_R__0__tGb_String = new(this, "#tGb", 0, typeof(System.String));
					r_R__0__tGb_String.SetBelong(this.instance);
				}
				return r_R__0__tGb_String;
			}
		}

		/// <summary>
		/// Void Update(Single)
		/// </summary>
		protected RMethod r_RUpdate_Single;
		public virtual RMethod RUpdate_Single
		{
			get
			{
				if(r_RUpdate_Single == null)
				{
					r_RUpdate_Single = new(this, "Update", 0, typeof(System.Single));
					r_RUpdate_Single.SetBelong(this.instance);
				}
				return r_RUpdate_Single;
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


        public RLoadingScene() : base("LoadingScene")
        {
        }

        public RLoadingScene(System.Object instance) : base("LoadingScene")
		{
            SetInstance(instance);
		}

        public RLoadingScene(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RLoadingScene(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void __0__n4c(GameDefineType.ID  @mapID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@mapID};
            var ___result = R__0__n4c_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__Pr(System.String  @previous)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous};
            var ___result = R__0__Pr_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator __0__Add(System.String  @previous)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous};
            var ___result = R__0__Add_String.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void __0__rGb(System.String  @next)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@next};
            var ___result = R__0__rGb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__8Gb(System.String[]  @urls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@urls};
            var ___result = R__0__8Gb_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__9Gb()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__9Gb.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__aHb(System.Collections.Generic.List<System.String>  @FirstPassUrls)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@FirstPassUrls};
            var ___result = R__0__aHb_List_d_String_p_.Invoke(___genericsType, ___parameters);

            
        }





        public virtual System.Boolean __0__hgb(System.String  @url)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@url};
            var ___result = R__0__hgb_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void __0__sGb(System.String  @next)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@next};
            var ___result = R__0__sGb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__tGb(System.String  @previous)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@previous};
            var ___result = R__0__tGb_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Update(System.Single  @delay)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@delay};
            var ___result = RUpdate_Single.Invoke(___genericsType, ___parameters);

            
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
