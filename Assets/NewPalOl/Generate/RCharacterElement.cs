using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// CharacterElement
	/// </summary>
    public partial class RCharacterElement : RMember //
    {

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.String bundleName
		/// </summary>
		protected RField r_bundleName;
		public virtual RField RbundleName
		{
			get
			{
				if(r_bundleName == null)
				{
					r_bundleName = new(this, "bundleName");
					r_bundleName.SetBelong(this.instance);
				}
				return r_bundleName;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.WWW] wwws
		/// </summary>
		protected static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RWWW> r_wwws;
		public static RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RWWW> Rwwws
		{
			get
			{
				if(r_wwws == null)
				{
					r_wwws = new(typeof(CharacterElement), "wwws");
					r_wwws.SetBelong(null);
				}
				return r_wwws;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest gameObjectRequest
		/// </summary>
		protected RUnityEngine.RAssetBundleRequest r_gameObjectRequest;
		public virtual RUnityEngine.RAssetBundleRequest RgameObjectRequest
		{
			get
			{
				if(r_gameObjectRequest == null)
				{
					r_gameObjectRequest = new(this, "gameObjectRequest");
					r_gameObjectRequest.SetBelong(this.instance);
				}
				return r_gameObjectRequest;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleRequest materialRequest
		/// </summary>
		protected RUnityEngine.RAssetBundleRequest r_materialRequest;
		public virtual RUnityEngine.RAssetBundleRequest RmaterialRequest
		{
			get
			{
				if(r_materialRequest == null)
				{
					r_materialRequest = new(this, "materialRequest");
					r_materialRequest.SetBelong(this.instance);
				}
				return r_materialRequest;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundleCreateRequest m_assetbundleCreatReq
		/// </summary>
		protected RUnityEngine.RAssetBundleCreateRequest r_m_assetbundleCreatReq;
		public virtual RUnityEngine.RAssetBundleCreateRequest Rm_assetbundleCreatReq
		{
			get
			{
				if(r_m_assetbundleCreatReq == null)
				{
					r_m_assetbundleCreatReq = new(this, "m_assetbundleCreatReq");
					r_m_assetbundleCreatReq.SetBelong(this.instance);
				}
				return r_m_assetbundleCreatReq;
			}
		}

		/// <summary>
		/// UnityEngine.AssetBundle m_assetBundle
		/// </summary>
		protected RUnityEngine.RAssetBundle r_m_assetBundle;
		public virtual RUnityEngine.RAssetBundle Rm_assetBundle
		{
			get
			{
				if(r_m_assetBundle == null)
				{
					r_m_assetBundle = new(this, "m_assetBundle");
					r_m_assetBundle.SetBelong(this.instance);
				}
				return r_m_assetBundle;
			}
		}

		/// <summary>
		/// UnityEngine.WWW WWW
		/// </summary>
		protected RUnityEngine.RWWW r_WWW;
		public virtual RUnityEngine.RWWW RWWW
		{
			get
			{
				if(r_WWW == null)
				{
					r_WWW = new(this, "WWW", -1);
					r_WWW.SetBelong(this.instance);
				}
				return r_WWW;
			}
		}

		/// <summary>
		/// Boolean IsLoaded
		/// </summary>
		protected RProperty r_IsLoaded;
		public virtual RProperty RIsLoaded
		{
			get
			{
				if(r_IsLoaded == null)
				{
					r_IsLoaded = new(this, "IsLoaded", -1);
					r_IsLoaded.SetBelong(this.instance);
				}
				return r_IsLoaded;
			}
		}

		/// <summary>
		/// Boolean isAssetReady
		/// </summary>
		protected RProperty r_isAssetReady;
		public virtual RProperty RisAssetReady
		{
			get
			{
				if(r_isAssetReady == null)
				{
					r_isAssetReady = new(this, "isAssetReady", -1);
					r_isAssetReady.SetBelong(this.instance);
				}
				return r_isAssetReady;
			}
		}

		/// <summary>
		/// Void UnLoadWWW()
		/// </summary>
		protected RMethod r_RUnLoadWWW;
		public virtual RMethod RUnLoadWWW
		{
			get
			{
				if(r_RUnLoadWWW == null)
				{
					r_RUnLoadWWW = new(this, "UnLoadWWW", 0);
					r_RUnLoadWWW.SetBelong(this.instance);
				}
				return r_RUnLoadWWW;
			}
		}

		/// <summary>
		/// Void UnLoad()
		/// </summary>
		protected RMethod r_RUnLoad;
		public virtual RMethod RUnLoad
		{
			get
			{
				if(r_RUnLoad == null)
				{
					r_RUnLoad = new(this, "UnLoad", 0);
					r_RUnLoad.SetBelong(this.instance);
				}
				return r_RUnLoad;
			}
		}

		/// <summary>
		/// Void AssetBundleReq()
		/// </summary>
		protected RMethod r_RAssetBundleReq;
		public virtual RMethod RAssetBundleReq
		{
			get
			{
				if(r_RAssetBundleReq == null)
				{
					r_RAssetBundleReq = new(this, "AssetBundleReq", 0);
					r_RAssetBundleReq.SetBelong(this.instance);
				}
				return r_RAssetBundleReq;
			}
		}

		/// <summary>
		/// UnityEngine.SkinnedMeshRenderer GetSkinnedMeshRenderer()
		/// </summary>
		protected RMethod r_RGetSkinnedMeshRenderer;
		public virtual RMethod RGetSkinnedMeshRenderer
		{
			get
			{
				if(r_RGetSkinnedMeshRenderer == null)
				{
					r_RGetSkinnedMeshRenderer = new(this, "GetSkinnedMeshRenderer", 0);
					r_RGetSkinnedMeshRenderer.SetBelong(this.instance);
				}
				return r_RGetSkinnedMeshRenderer;
			}
		}

		/// <summary>
		/// System.String[] GetBoneNames()
		/// </summary>
		protected RMethod r_RGetBoneNames;
		public virtual RMethod RGetBoneNames
		{
			get
			{
				if(r_RGetBoneNames == null)
				{
					r_RGetBoneNames = new(this, "GetBoneNames", 0);
					r_RGetBoneNames.SetBelong(this.instance);
				}
				return r_RGetBoneNames;
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


        public RCharacterElement() : base("CharacterElement")
        {
        }

        public RCharacterElement(System.Object instance) : base("CharacterElement")
		{
            SetInstance(instance);
		}

        public RCharacterElement(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RCharacterElement(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void UnLoadWWW()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnLoadWWW.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void UnLoad()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnLoad.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AssetBundleReq()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAssetBundleReq.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.SkinnedMeshRenderer GetSkinnedMeshRenderer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetSkinnedMeshRenderer.Invoke(___genericsType, ___parameters);

            return (UnityEngine.SkinnedMeshRenderer)___result;
        }


        public virtual System.String[] GetBoneNames()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBoneNames.Invoke(___genericsType, ___parameters);

            return (System.String[])___result;
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
