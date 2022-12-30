using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__u
{
	/// <summary>
	/// #u.#A6c
	/// </summary>
    public partial class R__0__A6c : RMember //
    {

		/// <summary>
		/// System.Int32 #a
		/// </summary>
		protected RField r___0__a;
		public virtual RField R__0__a
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
		/// System.Collections.Generic.Dictionary`2[GameDefineType.ID,RenderTextureConfig] #b
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RRenderTextureConfig> r___0__b;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RGameDefineType.RID, RRenderTextureConfig> R__0__b
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
		/// System.Collections.Generic.Dictionary`2[TexRenderType,UnityEngine.Camera] #c
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RCamera> r___0__c;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RCamera> R__0__c
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
		/// System.Collections.Generic.Dictionary`2[TexRenderType,System.Collections.Generic.List`1[UnityEngine.Light]] #d
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RUnityEngine.RLight>> r___0__d;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RSystem.RCollections.RGeneric.RList<RUnityEngine.RLight>> R__0__d
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
		/// System.Int32 #e
		/// </summary>
		protected static RField r___0__e;
		public static RField R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new( ReleactionUtils.GetType("#u.#A6c"), "#e");
					r___0__e.SetBelong(null);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// System.Int32 #f
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
		/// UnityEngine.GameObject #g
		/// </summary>
		protected RUnityEngine.RGameObject r___0__g;
		public virtual RUnityEngine.RGameObject R__0__g
		{
			get
			{
				if(r___0__g == null)
				{
					r___0__g = new(this, "#g");
					r___0__g.SetBelong(this.instance);
				}
				return r___0__g;
			}
		}

		/// <summary>
		/// Int32 LayerMark
		/// </summary>
		protected RProperty r_R__0__KOc;
		public virtual RProperty R__0__KOc
		{
			get
			{
				if(r_R__0__KOc == null)
				{
					r_R__0__KOc = new(this, "LayerMark", -1);
					r_R__0__KOc.SetBelong(this.instance);
				}
				return r_R__0__KOc;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject cameraNode
		/// </summary>
		protected RUnityEngine.RGameObject r_R__0__LOc;
		public virtual RUnityEngine.RGameObject R__0__LOc
		{
			get
			{
				if(r_R__0__LOc == null)
				{
					r_R__0__LOc = new(this, "cameraNode", -1);
					r_R__0__LOc.SetBelong(this.instance);
				}
				return r_R__0__LOc;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture #MOc(TexRenderType, Int32, Int32)
		/// </summary>
		protected RMethod r_R__0__MOc_TexRenderType_Int32_Int32;
		public virtual RMethod R__0__MOc_TexRenderType_Int32_Int32
		{
			get
			{
				if(r_R__0__MOc_TexRenderType_Int32_Int32 == null)
				{
					r_R__0__MOc_TexRenderType_Int32_Int32 = new(this, "#MOc", 0, typeof(TexRenderType), typeof(System.Int32), typeof(System.Int32));
					r_R__0__MOc_TexRenderType_Int32_Int32.SetBelong(this.instance);
				}
				return r_R__0__MOc_TexRenderType_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Camera #NOc(TexRenderType)
		/// </summary>
		protected RMethod r_R__0__NOc_TexRenderType;
		public virtual RMethod R__0__NOc_TexRenderType
		{
			get
			{
				if(r_R__0__NOc_TexRenderType == null)
				{
					r_R__0__NOc_TexRenderType = new(this, "#NOc", 0, typeof(TexRenderType));
					r_R__0__NOc_TexRenderType.SetBelong(this.instance);
				}
				return r_R__0__NOc_TexRenderType;
			}
		}

		/// <summary>
		/// UnityEngine.Light #OOc(TexRenderType, Int32)
		/// </summary>
		protected RMethod r_R__0__OOc_TexRenderType_Int32;
		public virtual RMethod R__0__OOc_TexRenderType_Int32
		{
			get
			{
				if(r_R__0__OOc_TexRenderType_Int32 == null)
				{
					r_R__0__OOc_TexRenderType_Int32 = new(this, "#OOc", 0, typeof(TexRenderType), typeof(System.Int32));
					r_R__0__OOc_TexRenderType_Int32.SetBelong(this.instance);
				}
				return r_R__0__OOc_TexRenderType_Int32;
			}
		}

		/// <summary>
		/// Void #POc(RenderTextureConfig, UnityEngine.GameObject, TexRenderType, UnityEngine.Camera)
		/// </summary>
		protected RMethod r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType_Camera;
		public virtual RMethod R__0__POc_RenderTextureConfig_GameObject_TexRenderType_Camera
		{
			get
			{
				if(r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType_Camera == null)
				{
					r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType_Camera = new(this, "#POc", 0, typeof(RenderTextureConfig), typeof(UnityEngine.GameObject), typeof(TexRenderType), typeof(UnityEngine.Camera));
					r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType_Camera.SetBelong(this.instance);
				}
				return r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType_Camera;
			}
		}

		/// <summary>
		/// Void #POc(RenderTextureConfig, UnityEngine.GameObject, TexRenderType)
		/// </summary>
		protected RMethod r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType;
		public virtual RMethod R__0__POc_RenderTextureConfig_GameObject_TexRenderType
		{
			get
			{
				if(r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType == null)
				{
					r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType = new(this, "#POc", 0, typeof(RenderTextureConfig), typeof(UnityEngine.GameObject), typeof(TexRenderType));
					r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType.SetBelong(this.instance);
				}
				return r_R__0__POc_RenderTextureConfig_GameObject_TexRenderType;
			}
		}

		/// <summary>
		/// Void #QOc(UnityEngine.GameObject, TexRenderType, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__QOc_GameObject_TexRenderType_ID;
		public virtual RMethod R__0__QOc_GameObject_TexRenderType_ID
		{
			get
			{
				if(r_R__0__QOc_GameObject_TexRenderType_ID == null)
				{
					r_R__0__QOc_GameObject_TexRenderType_ID = new(this, "#QOc", 0, typeof(UnityEngine.GameObject), typeof(TexRenderType), typeof(GameDefineType.ID));
					r_R__0__QOc_GameObject_TexRenderType_ID.SetBelong(this.instance);
				}
				return r_R__0__QOc_GameObject_TexRenderType_ID;
			}
		}

		/// <summary>
		/// Void #QOc(UnityEngine.GameObject, TexRenderType, System.Nullable`1[UnityEngine.Vector3], System.Nullable`1[UnityEngine.Quaternion], System.Nullable`1[UnityEngine.Vector3], System.Nullable`1[UnityEngine.Quaternion])
		/// </summary>
		protected RMethod r_R__0__QOc_GameObject_TexRenderType_Nullable_d_Vector3_p__Nullable_d_Quaternion_p__Nullable_d_Vector3_p__Nullable_d_Quaternion_p_;
		public virtual RMethod R__0__QOc_GameObject_TexRenderType_Nullable_d_Vector3_p__Nullable_d_Quaternion_p__Nullable_d_Vector3_p__Nullable_d_Quaternion_p_
		{
			get
			{
				if(r_R__0__QOc_GameObject_TexRenderType_Nullable_d_Vector3_p__Nullable_d_Quaternion_p__Nullable_d_Vector3_p__Nullable_d_Quaternion_p_ == null)
				{
					r_R__0__QOc_GameObject_TexRenderType_Nullable_d_Vector3_p__Nullable_d_Quaternion_p__Nullable_d_Vector3_p__Nullable_d_Quaternion_p_ = new(this, "#QOc", 0, typeof(UnityEngine.GameObject), typeof(TexRenderType), typeof(System.Nullable<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Nullable<>).MakeGenericType(typeof(UnityEngine.Quaternion)), typeof(System.Nullable<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Nullable<>).MakeGenericType(typeof(UnityEngine.Quaternion)));
					r_R__0__QOc_GameObject_TexRenderType_Nullable_d_Vector3_p__Nullable_d_Quaternion_p__Nullable_d_Vector3_p__Nullable_d_Quaternion_p_.SetBelong(this.instance);
				}
				return r_R__0__QOc_GameObject_TexRenderType_Nullable_d_Vector3_p__Nullable_d_Quaternion_p__Nullable_d_Vector3_p__Nullable_d_Quaternion_p_;
			}
		}

		/// <summary>
		/// Void #QOc(UnityEngine.GameObject, UnityEngine.Camera, TexRenderType, GameDefineType.ID, UnityEngine.Vector3, UnityEngine.Quaternion)
		/// </summary>
		protected RMethod r_R__0__QOc_GameObject_Camera_TexRenderType_ID_Vector3_Quaternion;
		public virtual RMethod R__0__QOc_GameObject_Camera_TexRenderType_ID_Vector3_Quaternion
		{
			get
			{
				if(r_R__0__QOc_GameObject_Camera_TexRenderType_ID_Vector3_Quaternion == null)
				{
					r_R__0__QOc_GameObject_Camera_TexRenderType_ID_Vector3_Quaternion = new(this, "#QOc", 0, typeof(UnityEngine.GameObject), typeof(UnityEngine.Camera), typeof(TexRenderType), typeof(GameDefineType.ID), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion));
					r_R__0__QOc_GameObject_Camera_TexRenderType_ID_Vector3_Quaternion.SetBelong(this.instance);
				}
				return r_R__0__QOc_GameObject_Camera_TexRenderType_ID_Vector3_Quaternion;
			}
		}

		/// <summary>
		/// Void #QOc(UnityEngine.GameObject, TexRenderType, GameDefineType.ID, System.Nullable`1[UnityEngine.Vector3], System.Nullable`1[UnityEngine.Quaternion])
		/// </summary>
		protected RMethod r_R__0__QOc_GameObject_TexRenderType_ID_Nullable_d_Vector3_p__Nullable_d_Quaternion_p_;
		public virtual RMethod R__0__QOc_GameObject_TexRenderType_ID_Nullable_d_Vector3_p__Nullable_d_Quaternion_p_
		{
			get
			{
				if(r_R__0__QOc_GameObject_TexRenderType_ID_Nullable_d_Vector3_p__Nullable_d_Quaternion_p_ == null)
				{
					r_R__0__QOc_GameObject_TexRenderType_ID_Nullable_d_Vector3_p__Nullable_d_Quaternion_p_ = new(this, "#QOc", 0, typeof(UnityEngine.GameObject), typeof(TexRenderType), typeof(GameDefineType.ID), typeof(System.Nullable<>).MakeGenericType(typeof(UnityEngine.Vector3)), typeof(System.Nullable<>).MakeGenericType(typeof(UnityEngine.Quaternion)));
					r_R__0__QOc_GameObject_TexRenderType_ID_Nullable_d_Vector3_p__Nullable_d_Quaternion_p_.SetBelong(this.instance);
				}
				return r_R__0__QOc_GameObject_TexRenderType_ID_Nullable_d_Vector3_p__Nullable_d_Quaternion_p_;
			}
		}

		/// <summary>
		/// Void #ROc(TexRenderType, Boolean)
		/// </summary>
		protected RMethod r_R__0__ROc_TexRenderType_Boolean;
		public virtual RMethod R__0__ROc_TexRenderType_Boolean
		{
			get
			{
				if(r_R__0__ROc_TexRenderType_Boolean == null)
				{
					r_R__0__ROc_TexRenderType_Boolean = new(this, "#ROc", 0, typeof(TexRenderType), typeof(System.Boolean));
					r_R__0__ROc_TexRenderType_Boolean.SetBelong(this.instance);
				}
				return r_R__0__ROc_TexRenderType_Boolean;
			}
		}

		/// <summary>
		/// Void OnLoadRenderObjConfig(UnityEngine.Object)
		/// </summary>
		protected RMethod r_ROnLoadRenderObjConfig_Object;
		public virtual RMethod ROnLoadRenderObjConfig_Object
		{
			get
			{
				if(r_ROnLoadRenderObjConfig_Object == null)
				{
					r_ROnLoadRenderObjConfig_Object = new(this, "OnLoadRenderObjConfig", 0, typeof(UnityEngine.Object));
					r_ROnLoadRenderObjConfig_Object.SetBelong(this.instance);
				}
				return r_ROnLoadRenderObjConfig_Object;
			}
		}

		/// <summary>
		/// Boolean #SOc(GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__SOc_ID;
		public virtual RMethod R__0__SOc_ID
		{
			get
			{
				if(r_R__0__SOc_ID == null)
				{
					r_R__0__SOc_ID = new(this, "#SOc", 0, typeof(GameDefineType.ID));
					r_R__0__SOc_ID.SetBelong(this.instance);
				}
				return r_R__0__SOc_ID;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 #k7d(TexRenderType, GameDefineType.ID)
		/// </summary>
		protected RMethod r_R__0__k7d_TexRenderType_ID;
		public virtual RMethod R__0__k7d_TexRenderType_ID
		{
			get
			{
				if(r_R__0__k7d_TexRenderType_ID == null)
				{
					r_R__0__k7d_TexRenderType_ID = new(this, "#k7d", 0, typeof(TexRenderType), typeof(GameDefineType.ID));
					r_R__0__k7d_TexRenderType_ID.SetBelong(this.instance);
				}
				return r_R__0__k7d_TexRenderType_ID;
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


        public R__0__A6c() : base("#u.#A6c")
        {
        }

        public R__0__A6c(System.Object instance) : base("#u.#A6c")
		{
            SetInstance(instance);
		}

        public R__0__A6c(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__A6c(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual UnityEngine.RenderTexture __0__MOc(TexRenderType  @type, System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @width, @height};
            var ___result = R__0__MOc_TexRenderType_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.RenderTexture)___result;
        }


        public virtual UnityEngine.Camera __0__NOc(TexRenderType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = R__0__NOc_TexRenderType.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Camera)___result;
        }


        public virtual UnityEngine.Light __0__OOc(TexRenderType  @type, System.Int32  @num)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @num};
            var ___result = R__0__OOc_TexRenderType_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Light)___result;
        }


        public virtual void __0__POc(RenderTextureConfig  @config, UnityEngine.GameObject  @obj, TexRenderType  @type, UnityEngine.Camera  @curCamera)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@config, @obj, @type, @curCamera};
            var ___result = R__0__POc_RenderTextureConfig_GameObject_TexRenderType_Camera.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__POc(RenderTextureConfig  @config, UnityEngine.GameObject  @obj, TexRenderType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@config, @obj, @type};
            var ___result = R__0__POc_RenderTextureConfig_GameObject_TexRenderType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__QOc(UnityEngine.GameObject  @obj, TexRenderType  @type, GameDefineType.ID  @resID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @type, @resID};
            var ___result = R__0__QOc_GameObject_TexRenderType_ID.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__QOc(UnityEngine.GameObject  @obj, TexRenderType  @type, System.Nullable<UnityEngine.Vector3>  @defaultPostion, System.Nullable<UnityEngine.Quaternion>  @defaultRotation, System.Nullable<UnityEngine.Vector3>  @defCamPos, System.Nullable<UnityEngine.Quaternion>  @defCamRot)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @type, @defaultPostion, @defaultRotation, @defCamPos, @defCamRot};
            var ___result = R__0__QOc_GameObject_TexRenderType_Nullable_d_Vector3_p__Nullable_d_Quaternion_p__Nullable_d_Vector3_p__Nullable_d_Quaternion_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__QOc(UnityEngine.GameObject  @obj, UnityEngine.Camera  @cam, TexRenderType  @type, GameDefineType.ID  @resID, UnityEngine.Vector3  @defaultPostion, UnityEngine.Quaternion  @defaultRotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @cam, @type, @resID, @defaultPostion, @defaultRotation};
            var ___result = R__0__QOc_GameObject_Camera_TexRenderType_ID_Vector3_Quaternion.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__QOc(UnityEngine.GameObject  @obj, TexRenderType  @type, GameDefineType.ID  @resID, System.Nullable<UnityEngine.Vector3>  @defaultPostion, System.Nullable<UnityEngine.Quaternion>  @defaultRotation)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @type, @resID, @defaultPostion, @defaultRotation};
            var ___result = R__0__QOc_GameObject_TexRenderType_ID_Nullable_d_Vector3_p__Nullable_d_Quaternion_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void __0__ROc(TexRenderType  @type, System.Boolean  @active)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @active};
            var ___result = R__0__ROc_TexRenderType_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnLoadRenderObjConfig(UnityEngine.Object  @textAssets)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@textAssets};
            var ___result = ROnLoadRenderObjConfig_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean __0__SOc(GameDefineType.ID  @resID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@resID};
            var ___result = R__0__SOc_ID.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Vector3 __0__k7d(TexRenderType  @type, GameDefineType.ID  @resId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @resId};
            var ___result = R__0__k7d_TexRenderType_ID.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
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
