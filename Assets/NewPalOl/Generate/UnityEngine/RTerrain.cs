using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.Terrain
	/// </summary>
    public partial class RTerrain : RMember //
    {

		/// <summary>
		/// UnityEngine.TerrainData terrainData
		/// </summary>
		protected RUnityEngine.RTerrainData r_terrainData;
		public virtual RUnityEngine.RTerrainData RterrainData
		{
			get
			{
				if(r_terrainData == null)
				{
					r_terrainData = new(this, "terrainData", -1);
					r_terrainData.SetBelong(this.instance);
				}
				return r_terrainData;
			}
		}

		/// <summary>
		/// Single treeDistance
		/// </summary>
		protected RProperty r_treeDistance;
		public virtual RProperty RtreeDistance
		{
			get
			{
				if(r_treeDistance == null)
				{
					r_treeDistance = new(this, "treeDistance", -1);
					r_treeDistance.SetBelong(this.instance);
				}
				return r_treeDistance;
			}
		}

		/// <summary>
		/// Single treeBillboardDistance
		/// </summary>
		protected RProperty r_treeBillboardDistance;
		public virtual RProperty RtreeBillboardDistance
		{
			get
			{
				if(r_treeBillboardDistance == null)
				{
					r_treeBillboardDistance = new(this, "treeBillboardDistance", -1);
					r_treeBillboardDistance.SetBelong(this.instance);
				}
				return r_treeBillboardDistance;
			}
		}

		/// <summary>
		/// Single treeCrossFadeLength
		/// </summary>
		protected RProperty r_treeCrossFadeLength;
		public virtual RProperty RtreeCrossFadeLength
		{
			get
			{
				if(r_treeCrossFadeLength == null)
				{
					r_treeCrossFadeLength = new(this, "treeCrossFadeLength", -1);
					r_treeCrossFadeLength.SetBelong(this.instance);
				}
				return r_treeCrossFadeLength;
			}
		}

		/// <summary>
		/// Int32 treeMaximumFullLODCount
		/// </summary>
		protected RProperty r_treeMaximumFullLODCount;
		public virtual RProperty RtreeMaximumFullLODCount
		{
			get
			{
				if(r_treeMaximumFullLODCount == null)
				{
					r_treeMaximumFullLODCount = new(this, "treeMaximumFullLODCount", -1);
					r_treeMaximumFullLODCount.SetBelong(this.instance);
				}
				return r_treeMaximumFullLODCount;
			}
		}

		/// <summary>
		/// Single detailObjectDistance
		/// </summary>
		protected RProperty r_detailObjectDistance;
		public virtual RProperty RdetailObjectDistance
		{
			get
			{
				if(r_detailObjectDistance == null)
				{
					r_detailObjectDistance = new(this, "detailObjectDistance", -1);
					r_detailObjectDistance.SetBelong(this.instance);
				}
				return r_detailObjectDistance;
			}
		}

		/// <summary>
		/// Single detailObjectDensity
		/// </summary>
		protected RProperty r_detailObjectDensity;
		public virtual RProperty RdetailObjectDensity
		{
			get
			{
				if(r_detailObjectDensity == null)
				{
					r_detailObjectDensity = new(this, "detailObjectDensity", -1);
					r_detailObjectDensity.SetBelong(this.instance);
				}
				return r_detailObjectDensity;
			}
		}

		/// <summary>
		/// Single heightmapPixelError
		/// </summary>
		protected RProperty r_heightmapPixelError;
		public virtual RProperty RheightmapPixelError
		{
			get
			{
				if(r_heightmapPixelError == null)
				{
					r_heightmapPixelError = new(this, "heightmapPixelError", -1);
					r_heightmapPixelError.SetBelong(this.instance);
				}
				return r_heightmapPixelError;
			}
		}

		/// <summary>
		/// Int32 heightmapMaximumLOD
		/// </summary>
		protected RProperty r_heightmapMaximumLOD;
		public virtual RProperty RheightmapMaximumLOD
		{
			get
			{
				if(r_heightmapMaximumLOD == null)
				{
					r_heightmapMaximumLOD = new(this, "heightmapMaximumLOD", -1);
					r_heightmapMaximumLOD.SetBelong(this.instance);
				}
				return r_heightmapMaximumLOD;
			}
		}

		/// <summary>
		/// Single basemapDistance
		/// </summary>
		protected RProperty r_basemapDistance;
		public virtual RProperty RbasemapDistance
		{
			get
			{
				if(r_basemapDistance == null)
				{
					r_basemapDistance = new(this, "basemapDistance", -1);
					r_basemapDistance.SetBelong(this.instance);
				}
				return r_basemapDistance;
			}
		}

		/// <summary>
		/// Int32 lightmapIndex
		/// </summary>
		protected RProperty r_lightmapIndex;
		public virtual RProperty RlightmapIndex
		{
			get
			{
				if(r_lightmapIndex == null)
				{
					r_lightmapIndex = new(this, "lightmapIndex", -1);
					r_lightmapIndex.SetBelong(this.instance);
				}
				return r_lightmapIndex;
			}
		}

		/// <summary>
		/// Int32 realtimeLightmapIndex
		/// </summary>
		protected RProperty r_realtimeLightmapIndex;
		public virtual RProperty RrealtimeLightmapIndex
		{
			get
			{
				if(r_realtimeLightmapIndex == null)
				{
					r_realtimeLightmapIndex = new(this, "realtimeLightmapIndex", -1);
					r_realtimeLightmapIndex.SetBelong(this.instance);
				}
				return r_realtimeLightmapIndex;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 lightmapScaleOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_lightmapScaleOffset;
		public virtual RUnityEngine.RVector4 RlightmapScaleOffset
		{
			get
			{
				if(r_lightmapScaleOffset == null)
				{
					r_lightmapScaleOffset = new(this, "lightmapScaleOffset", -1);
					r_lightmapScaleOffset.SetBelong(this.instance);
				}
				return r_lightmapScaleOffset;
			}
		}

		/// <summary>
		/// UnityEngine.Vector4 realtimeLightmapScaleOffset
		/// </summary>
		protected RUnityEngine.RVector4 r_realtimeLightmapScaleOffset;
		public virtual RUnityEngine.RVector4 RrealtimeLightmapScaleOffset
		{
			get
			{
				if(r_realtimeLightmapScaleOffset == null)
				{
					r_realtimeLightmapScaleOffset = new(this, "realtimeLightmapScaleOffset", -1);
					r_realtimeLightmapScaleOffset.SetBelong(this.instance);
				}
				return r_realtimeLightmapScaleOffset;
			}
		}

		/// <summary>
		/// Boolean freeUnusedRenderingResources
		/// </summary>
		protected RProperty r_freeUnusedRenderingResources;
		public virtual RProperty RfreeUnusedRenderingResources
		{
			get
			{
				if(r_freeUnusedRenderingResources == null)
				{
					r_freeUnusedRenderingResources = new(this, "freeUnusedRenderingResources", -1);
					r_freeUnusedRenderingResources.SetBelong(this.instance);
				}
				return r_freeUnusedRenderingResources;
			}
		}

		/// <summary>
		/// Boolean keepUnusedRenderingResources
		/// </summary>
		protected RProperty r_keepUnusedRenderingResources;
		public virtual RProperty RkeepUnusedRenderingResources
		{
			get
			{
				if(r_keepUnusedRenderingResources == null)
				{
					r_keepUnusedRenderingResources = new(this, "keepUnusedRenderingResources", -1);
					r_keepUnusedRenderingResources.SetBelong(this.instance);
				}
				return r_keepUnusedRenderingResources;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ShadowCastingMode shadowCastingMode
		/// </summary>
		protected RProperty r_shadowCastingMode;
		public virtual RProperty RshadowCastingMode
		{
			get
			{
				if(r_shadowCastingMode == null)
				{
					r_shadowCastingMode = new(this, "shadowCastingMode", -1);
					r_shadowCastingMode.SetBelong(this.instance);
				}
				return r_shadowCastingMode;
			}
		}

		/// <summary>
		/// UnityEngine.Rendering.ReflectionProbeUsage reflectionProbeUsage
		/// </summary>
		protected RProperty r_reflectionProbeUsage;
		public virtual RProperty RreflectionProbeUsage
		{
			get
			{
				if(r_reflectionProbeUsage == null)
				{
					r_reflectionProbeUsage = new(this, "reflectionProbeUsage", -1);
					r_reflectionProbeUsage.SetBelong(this.instance);
				}
				return r_reflectionProbeUsage;
			}
		}

		/// <summary>
		/// UnityEngine.Material materialTemplate
		/// </summary>
		protected RUnityEngine.RMaterial r_materialTemplate;
		public virtual RUnityEngine.RMaterial RmaterialTemplate
		{
			get
			{
				if(r_materialTemplate == null)
				{
					r_materialTemplate = new(this, "materialTemplate", -1);
					r_materialTemplate.SetBelong(this.instance);
				}
				return r_materialTemplate;
			}
		}

		/// <summary>
		/// Boolean drawHeightmap
		/// </summary>
		protected RProperty r_drawHeightmap;
		public virtual RProperty RdrawHeightmap
		{
			get
			{
				if(r_drawHeightmap == null)
				{
					r_drawHeightmap = new(this, "drawHeightmap", -1);
					r_drawHeightmap.SetBelong(this.instance);
				}
				return r_drawHeightmap;
			}
		}

		/// <summary>
		/// Boolean allowAutoConnect
		/// </summary>
		protected RProperty r_allowAutoConnect;
		public virtual RProperty RallowAutoConnect
		{
			get
			{
				if(r_allowAutoConnect == null)
				{
					r_allowAutoConnect = new(this, "allowAutoConnect", -1);
					r_allowAutoConnect.SetBelong(this.instance);
				}
				return r_allowAutoConnect;
			}
		}

		/// <summary>
		/// Int32 groupingID
		/// </summary>
		protected RProperty r_groupingID;
		public virtual RProperty RgroupingID
		{
			get
			{
				if(r_groupingID == null)
				{
					r_groupingID = new(this, "groupingID", -1);
					r_groupingID.SetBelong(this.instance);
				}
				return r_groupingID;
			}
		}

		/// <summary>
		/// Boolean drawInstanced
		/// </summary>
		protected RProperty r_drawInstanced;
		public virtual RProperty RdrawInstanced
		{
			get
			{
				if(r_drawInstanced == null)
				{
					r_drawInstanced = new(this, "drawInstanced", -1);
					r_drawInstanced.SetBelong(this.instance);
				}
				return r_drawInstanced;
			}
		}

		/// <summary>
		/// Boolean enableHeightmapRayTracing
		/// </summary>
		protected RProperty r_enableHeightmapRayTracing;
		public virtual RProperty RenableHeightmapRayTracing
		{
			get
			{
				if(r_enableHeightmapRayTracing == null)
				{
					r_enableHeightmapRayTracing = new(this, "enableHeightmapRayTracing", -1);
					r_enableHeightmapRayTracing.SetBelong(this.instance);
				}
				return r_enableHeightmapRayTracing;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTexture normalmapTexture
		/// </summary>
		protected RUnityEngine.RRenderTexture r_normalmapTexture;
		public virtual RUnityEngine.RRenderTexture RnormalmapTexture
		{
			get
			{
				if(r_normalmapTexture == null)
				{
					r_normalmapTexture = new(this, "normalmapTexture", -1);
					r_normalmapTexture.SetBelong(this.instance);
				}
				return r_normalmapTexture;
			}
		}

		/// <summary>
		/// Boolean drawTreesAndFoliage
		/// </summary>
		protected RProperty r_drawTreesAndFoliage;
		public virtual RProperty RdrawTreesAndFoliage
		{
			get
			{
				if(r_drawTreesAndFoliage == null)
				{
					r_drawTreesAndFoliage = new(this, "drawTreesAndFoliage", -1);
					r_drawTreesAndFoliage.SetBelong(this.instance);
				}
				return r_drawTreesAndFoliage;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 patchBoundsMultiplier
		/// </summary>
		protected RUnityEngine.RVector3 r_patchBoundsMultiplier;
		public virtual RUnityEngine.RVector3 RpatchBoundsMultiplier
		{
			get
			{
				if(r_patchBoundsMultiplier == null)
				{
					r_patchBoundsMultiplier = new(this, "patchBoundsMultiplier", -1);
					r_patchBoundsMultiplier.SetBelong(this.instance);
				}
				return r_patchBoundsMultiplier;
			}
		}

		/// <summary>
		/// Single treeLODBiasMultiplier
		/// </summary>
		protected RProperty r_treeLODBiasMultiplier;
		public virtual RProperty RtreeLODBiasMultiplier
		{
			get
			{
				if(r_treeLODBiasMultiplier == null)
				{
					r_treeLODBiasMultiplier = new(this, "treeLODBiasMultiplier", -1);
					r_treeLODBiasMultiplier.SetBelong(this.instance);
				}
				return r_treeLODBiasMultiplier;
			}
		}

		/// <summary>
		/// Boolean collectDetailPatches
		/// </summary>
		protected RProperty r_collectDetailPatches;
		public virtual RProperty RcollectDetailPatches
		{
			get
			{
				if(r_collectDetailPatches == null)
				{
					r_collectDetailPatches = new(this, "collectDetailPatches", -1);
					r_collectDetailPatches.SetBelong(this.instance);
				}
				return r_collectDetailPatches;
			}
		}

		/// <summary>
		/// Boolean ignoreQualitySettings
		/// </summary>
		protected RProperty r_ignoreQualitySettings;
		public virtual RProperty RignoreQualitySettings
		{
			get
			{
				if(r_ignoreQualitySettings == null)
				{
					r_ignoreQualitySettings = new(this, "ignoreQualitySettings", -1);
					r_ignoreQualitySettings.SetBelong(this.instance);
				}
				return r_ignoreQualitySettings;
			}
		}

		/// <summary>
		/// UnityEngine.TerrainRenderFlags editorRenderFlags
		/// </summary>
		protected RProperty r_editorRenderFlags;
		public virtual RProperty ReditorRenderFlags
		{
			get
			{
				if(r_editorRenderFlags == null)
				{
					r_editorRenderFlags = new(this, "editorRenderFlags", -1);
					r_editorRenderFlags.SetBelong(this.instance);
				}
				return r_editorRenderFlags;
			}
		}

		/// <summary>
		/// Boolean bakeLightProbesForTrees
		/// </summary>
		protected RProperty r_bakeLightProbesForTrees;
		public virtual RProperty RbakeLightProbesForTrees
		{
			get
			{
				if(r_bakeLightProbesForTrees == null)
				{
					r_bakeLightProbesForTrees = new(this, "bakeLightProbesForTrees", -1);
					r_bakeLightProbesForTrees.SetBelong(this.instance);
				}
				return r_bakeLightProbesForTrees;
			}
		}

		/// <summary>
		/// Boolean deringLightProbesForTrees
		/// </summary>
		protected RProperty r_deringLightProbesForTrees;
		public virtual RProperty RderingLightProbesForTrees
		{
			get
			{
				if(r_deringLightProbesForTrees == null)
				{
					r_deringLightProbesForTrees = new(this, "deringLightProbesForTrees", -1);
					r_deringLightProbesForTrees.SetBelong(this.instance);
				}
				return r_deringLightProbesForTrees;
			}
		}

		/// <summary>
		/// Boolean preserveTreePrototypeLayers
		/// </summary>
		protected RProperty r_preserveTreePrototypeLayers;
		public virtual RProperty RpreserveTreePrototypeLayers
		{
			get
			{
				if(r_preserveTreePrototypeLayers == null)
				{
					r_preserveTreePrototypeLayers = new(this, "preserveTreePrototypeLayers", -1);
					r_preserveTreePrototypeLayers.SetBelong(this.instance);
				}
				return r_preserveTreePrototypeLayers;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat heightmapFormat
		/// </summary>
		protected static RProperty r_heightmapFormat;
		public static RProperty RheightmapFormat
		{
			get
			{
				if(r_heightmapFormat == null)
				{
					r_heightmapFormat = new(typeof(UnityEngine.Terrain), "heightmapFormat", -1);
					r_heightmapFormat.SetBelong(null);
				}
				return r_heightmapFormat;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat heightmapTextureFormat
		/// </summary>
		protected static RProperty r_heightmapTextureFormat;
		public static RProperty RheightmapTextureFormat
		{
			get
			{
				if(r_heightmapTextureFormat == null)
				{
					r_heightmapTextureFormat = new(typeof(UnityEngine.Terrain), "heightmapTextureFormat", -1);
					r_heightmapTextureFormat.SetBelong(null);
				}
				return r_heightmapTextureFormat;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureFormat heightmapRenderTextureFormat
		/// </summary>
		protected static RProperty r_heightmapRenderTextureFormat;
		public static RProperty RheightmapRenderTextureFormat
		{
			get
			{
				if(r_heightmapRenderTextureFormat == null)
				{
					r_heightmapRenderTextureFormat = new(typeof(UnityEngine.Terrain), "heightmapRenderTextureFormat", -1);
					r_heightmapRenderTextureFormat.SetBelong(null);
				}
				return r_heightmapRenderTextureFormat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat normalmapFormat
		/// </summary>
		protected static RProperty r_normalmapFormat;
		public static RProperty RnormalmapFormat
		{
			get
			{
				if(r_normalmapFormat == null)
				{
					r_normalmapFormat = new(typeof(UnityEngine.Terrain), "normalmapFormat", -1);
					r_normalmapFormat.SetBelong(null);
				}
				return r_normalmapFormat;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat normalmapTextureFormat
		/// </summary>
		protected static RProperty r_normalmapTextureFormat;
		public static RProperty RnormalmapTextureFormat
		{
			get
			{
				if(r_normalmapTextureFormat == null)
				{
					r_normalmapTextureFormat = new(typeof(UnityEngine.Terrain), "normalmapTextureFormat", -1);
					r_normalmapTextureFormat.SetBelong(null);
				}
				return r_normalmapTextureFormat;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureFormat normalmapRenderTextureFormat
		/// </summary>
		protected static RProperty r_normalmapRenderTextureFormat;
		public static RProperty RnormalmapRenderTextureFormat
		{
			get
			{
				if(r_normalmapRenderTextureFormat == null)
				{
					r_normalmapRenderTextureFormat = new(typeof(UnityEngine.Terrain), "normalmapRenderTextureFormat", -1);
					r_normalmapRenderTextureFormat.SetBelong(null);
				}
				return r_normalmapRenderTextureFormat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat holesFormat
		/// </summary>
		protected static RProperty r_holesFormat;
		public static RProperty RholesFormat
		{
			get
			{
				if(r_holesFormat == null)
				{
					r_holesFormat = new(typeof(UnityEngine.Terrain), "holesFormat", -1);
					r_holesFormat.SetBelong(null);
				}
				return r_holesFormat;
			}
		}

		/// <summary>
		/// UnityEngine.RenderTextureFormat holesRenderTextureFormat
		/// </summary>
		protected static RProperty r_holesRenderTextureFormat;
		public static RProperty RholesRenderTextureFormat
		{
			get
			{
				if(r_holesRenderTextureFormat == null)
				{
					r_holesRenderTextureFormat = new(typeof(UnityEngine.Terrain), "holesRenderTextureFormat", -1);
					r_holesRenderTextureFormat.SetBelong(null);
				}
				return r_holesRenderTextureFormat;
			}
		}

		/// <summary>
		/// UnityEngine.Experimental.Rendering.GraphicsFormat compressedHolesFormat
		/// </summary>
		protected static RProperty r_compressedHolesFormat;
		public static RProperty RcompressedHolesFormat
		{
			get
			{
				if(r_compressedHolesFormat == null)
				{
					r_compressedHolesFormat = new(typeof(UnityEngine.Terrain), "compressedHolesFormat", -1);
					r_compressedHolesFormat.SetBelong(null);
				}
				return r_compressedHolesFormat;
			}
		}

		/// <summary>
		/// UnityEngine.TextureFormat compressedHolesTextureFormat
		/// </summary>
		protected static RProperty r_compressedHolesTextureFormat;
		public static RProperty RcompressedHolesTextureFormat
		{
			get
			{
				if(r_compressedHolesTextureFormat == null)
				{
					r_compressedHolesTextureFormat = new(typeof(UnityEngine.Terrain), "compressedHolesTextureFormat", -1);
					r_compressedHolesTextureFormat.SetBelong(null);
				}
				return r_compressedHolesTextureFormat;
			}
		}

		/// <summary>
		/// UnityEngine.Terrain activeTerrain
		/// </summary>
		protected static RUnityEngine.RTerrain r_activeTerrain;
		public static RUnityEngine.RTerrain RactiveTerrain
		{
			get
			{
				if(r_activeTerrain == null)
				{
					r_activeTerrain = new(typeof(UnityEngine.Terrain), "activeTerrain", -1);
					r_activeTerrain.SetBelong(null);
				}
				return r_activeTerrain;
			}
		}

		/// <summary>
		/// UnityEngine.Terrain[] activeTerrains
		/// </summary>
		protected static RPropertyArray<RUnityEngine.RTerrain> r_activeTerrains;
		public static RPropertyArray<RUnityEngine.RTerrain> RactiveTerrains
		{
			get
			{
				if(r_activeTerrains == null)
				{
					r_activeTerrains = new(typeof(UnityEngine.Terrain), "activeTerrains", -1);
					r_activeTerrains.SetBelong(null);
				}
				return r_activeTerrains;
			}
		}

		/// <summary>
		/// UnityEngine.Terrain leftNeighbor
		/// </summary>
		protected RUnityEngine.RTerrain r_leftNeighbor;
		public virtual RUnityEngine.RTerrain RleftNeighbor
		{
			get
			{
				if(r_leftNeighbor == null)
				{
					r_leftNeighbor = new(this, "leftNeighbor", -1);
					r_leftNeighbor.SetBelong(this.instance);
				}
				return r_leftNeighbor;
			}
		}

		/// <summary>
		/// UnityEngine.Terrain rightNeighbor
		/// </summary>
		protected RUnityEngine.RTerrain r_rightNeighbor;
		public virtual RUnityEngine.RTerrain RrightNeighbor
		{
			get
			{
				if(r_rightNeighbor == null)
				{
					r_rightNeighbor = new(this, "rightNeighbor", -1);
					r_rightNeighbor.SetBelong(this.instance);
				}
				return r_rightNeighbor;
			}
		}

		/// <summary>
		/// UnityEngine.Terrain topNeighbor
		/// </summary>
		protected RUnityEngine.RTerrain r_topNeighbor;
		public virtual RUnityEngine.RTerrain RtopNeighbor
		{
			get
			{
				if(r_topNeighbor == null)
				{
					r_topNeighbor = new(this, "topNeighbor", -1);
					r_topNeighbor.SetBelong(this.instance);
				}
				return r_topNeighbor;
			}
		}

		/// <summary>
		/// UnityEngine.Terrain bottomNeighbor
		/// </summary>
		protected RUnityEngine.RTerrain r_bottomNeighbor;
		public virtual RUnityEngine.RTerrain RbottomNeighbor
		{
			get
			{
				if(r_bottomNeighbor == null)
				{
					r_bottomNeighbor = new(this, "bottomNeighbor", -1);
					r_bottomNeighbor.SetBelong(this.instance);
				}
				return r_bottomNeighbor;
			}
		}

		/// <summary>
		/// UInt32 renderingLayerMask
		/// </summary>
		protected RProperty r_renderingLayerMask;
		public virtual RProperty RrenderingLayerMask
		{
			get
			{
				if(r_renderingLayerMask == null)
				{
					r_renderingLayerMask = new(this, "renderingLayerMask", -1);
					r_renderingLayerMask.SetBelong(this.instance);
				}
				return r_renderingLayerMask;
			}
		}

		/// <summary>
		/// Single splatmapDistance
		/// </summary>
		protected RProperty r_splatmapDistance;
		public virtual RProperty RsplatmapDistance
		{
			get
			{
				if(r_splatmapDistance == null)
				{
					r_splatmapDistance = new(this, "splatmapDistance", -1);
					r_splatmapDistance.SetBelong(this.instance);
				}
				return r_splatmapDistance;
			}
		}

		/// <summary>
		/// Boolean castShadows
		/// </summary>
		protected RProperty r_castShadows;
		public virtual RProperty RcastShadows
		{
			get
			{
				if(r_castShadows == null)
				{
					r_castShadows = new(this, "castShadows", -1);
					r_castShadows.SetBelong(this.instance);
				}
				return r_castShadows;
			}
		}

		/// <summary>
		/// MaterialType materialType
		/// </summary>
		protected RProperty r_materialType;
		public virtual RProperty RmaterialType
		{
			get
			{
				if(r_materialType == null)
				{
					r_materialType = new(this, "materialType", -1);
					r_materialType.SetBelong(this.instance);
				}
				return r_materialType;
			}
		}

		/// <summary>
		/// UnityEngine.Color legacySpecular
		/// </summary>
		protected RUnityEngine.RColor r_legacySpecular;
		public virtual RUnityEngine.RColor RlegacySpecular
		{
			get
			{
				if(r_legacySpecular == null)
				{
					r_legacySpecular = new(this, "legacySpecular", -1);
					r_legacySpecular.SetBelong(this.instance);
				}
				return r_legacySpecular;
			}
		}

		/// <summary>
		/// Single legacyShininess
		/// </summary>
		protected RProperty r_legacyShininess;
		public virtual RProperty RlegacyShininess
		{
			get
			{
				if(r_legacyShininess == null)
				{
					r_legacyShininess = new(this, "legacyShininess", -1);
					r_legacyShininess.SetBelong(this.instance);
				}
				return r_legacyShininess;
			}
		}

		/// <summary>
		/// Boolean enabled
		/// </summary>
		protected RProperty r_enabled;
		public virtual RProperty Renabled
		{
			get
			{
				if(r_enabled == null)
				{
					r_enabled = new(this, "enabled", -1);
					r_enabled.SetBelong(this.instance);
				}
				return r_enabled;
			}
		}

		/// <summary>
		/// Boolean isActiveAndEnabled
		/// </summary>
		protected RProperty r_isActiveAndEnabled;
		public virtual RProperty RisActiveAndEnabled
		{
			get
			{
				if(r_isActiveAndEnabled == null)
				{
					r_isActiveAndEnabled = new(this, "isActiveAndEnabled", -1);
					r_isActiveAndEnabled.SetBelong(this.instance);
				}
				return r_isActiveAndEnabled;
			}
		}

		/// <summary>
		/// UnityEngine.Transform transform
		/// </summary>
		protected RUnityEngine.RTransform r_transform;
		public virtual RUnityEngine.RTransform Rtransform
		{
			get
			{
				if(r_transform == null)
				{
					r_transform = new(this, "transform", -1);
					r_transform.SetBelong(this.instance);
				}
				return r_transform;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject gameObject
		/// </summary>
		protected RUnityEngine.RGameObject r_gameObject;
		public virtual RUnityEngine.RGameObject RgameObject
		{
			get
			{
				if(r_gameObject == null)
				{
					r_gameObject = new(this, "gameObject", -1);
					r_gameObject.SetBelong(this.instance);
				}
				return r_gameObject;
			}
		}

		/// <summary>
		/// System.String tag
		/// </summary>
		protected RProperty r_tag;
		public virtual RProperty Rtag
		{
			get
			{
				if(r_tag == null)
				{
					r_tag = new(this, "tag", -1);
					r_tag.SetBelong(this.instance);
				}
				return r_tag;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody
		/// </summary>
		protected RUnityEngine.RComponent r_rigidbody;
		public virtual RUnityEngine.RComponent Rrigidbody
		{
			get
			{
				if(r_rigidbody == null)
				{
					r_rigidbody = new(this, "rigidbody", -1);
					r_rigidbody.SetBelong(this.instance);
				}
				return r_rigidbody;
			}
		}

		/// <summary>
		/// UnityEngine.Component rigidbody2D
		/// </summary>
		protected RUnityEngine.RComponent r_rigidbody2D;
		public virtual RUnityEngine.RComponent Rrigidbody2D
		{
			get
			{
				if(r_rigidbody2D == null)
				{
					r_rigidbody2D = new(this, "rigidbody2D", -1);
					r_rigidbody2D.SetBelong(this.instance);
				}
				return r_rigidbody2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component camera
		/// </summary>
		protected RUnityEngine.RComponent r_camera;
		public virtual RUnityEngine.RComponent Rcamera
		{
			get
			{
				if(r_camera == null)
				{
					r_camera = new(this, "camera", -1);
					r_camera.SetBelong(this.instance);
				}
				return r_camera;
			}
		}

		/// <summary>
		/// UnityEngine.Component light
		/// </summary>
		protected RUnityEngine.RComponent r_light;
		public virtual RUnityEngine.RComponent Rlight
		{
			get
			{
				if(r_light == null)
				{
					r_light = new(this, "light", -1);
					r_light.SetBelong(this.instance);
				}
				return r_light;
			}
		}

		/// <summary>
		/// UnityEngine.Component animation
		/// </summary>
		protected RUnityEngine.RComponent r_animation;
		public virtual RUnityEngine.RComponent Ranimation
		{
			get
			{
				if(r_animation == null)
				{
					r_animation = new(this, "animation", -1);
					r_animation.SetBelong(this.instance);
				}
				return r_animation;
			}
		}

		/// <summary>
		/// UnityEngine.Component constantForce
		/// </summary>
		protected RUnityEngine.RComponent r_constantForce;
		public virtual RUnityEngine.RComponent RconstantForce
		{
			get
			{
				if(r_constantForce == null)
				{
					r_constantForce = new(this, "constantForce", -1);
					r_constantForce.SetBelong(this.instance);
				}
				return r_constantForce;
			}
		}

		/// <summary>
		/// UnityEngine.Component renderer
		/// </summary>
		protected RUnityEngine.RComponent r_renderer;
		public virtual RUnityEngine.RComponent Rrenderer
		{
			get
			{
				if(r_renderer == null)
				{
					r_renderer = new(this, "renderer", -1);
					r_renderer.SetBelong(this.instance);
				}
				return r_renderer;
			}
		}

		/// <summary>
		/// UnityEngine.Component audio
		/// </summary>
		protected RUnityEngine.RComponent r_audio;
		public virtual RUnityEngine.RComponent Raudio
		{
			get
			{
				if(r_audio == null)
				{
					r_audio = new(this, "audio", -1);
					r_audio.SetBelong(this.instance);
				}
				return r_audio;
			}
		}

		/// <summary>
		/// UnityEngine.Component networkView
		/// </summary>
		protected RUnityEngine.RComponent r_networkView;
		public virtual RUnityEngine.RComponent RnetworkView
		{
			get
			{
				if(r_networkView == null)
				{
					r_networkView = new(this, "networkView", -1);
					r_networkView.SetBelong(this.instance);
				}
				return r_networkView;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider
		/// </summary>
		protected RUnityEngine.RComponent r_collider;
		public virtual RUnityEngine.RComponent Rcollider
		{
			get
			{
				if(r_collider == null)
				{
					r_collider = new(this, "collider", -1);
					r_collider.SetBelong(this.instance);
				}
				return r_collider;
			}
		}

		/// <summary>
		/// UnityEngine.Component collider2D
		/// </summary>
		protected RUnityEngine.RComponent r_collider2D;
		public virtual RUnityEngine.RComponent Rcollider2D
		{
			get
			{
				if(r_collider2D == null)
				{
					r_collider2D = new(this, "collider2D", -1);
					r_collider2D.SetBelong(this.instance);
				}
				return r_collider2D;
			}
		}

		/// <summary>
		/// UnityEngine.Component hingeJoint
		/// </summary>
		protected RUnityEngine.RComponent r_hingeJoint;
		public virtual RUnityEngine.RComponent RhingeJoint
		{
			get
			{
				if(r_hingeJoint == null)
				{
					r_hingeJoint = new(this, "hingeJoint", -1);
					r_hingeJoint.SetBelong(this.instance);
				}
				return r_hingeJoint;
			}
		}

		/// <summary>
		/// UnityEngine.Component particleSystem
		/// </summary>
		protected RUnityEngine.RComponent r_particleSystem;
		public virtual RUnityEngine.RComponent RparticleSystem
		{
			get
			{
				if(r_particleSystem == null)
				{
					r_particleSystem = new(this, "particleSystem", -1);
					r_particleSystem.SetBelong(this.instance);
				}
				return r_particleSystem;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Boolean GetKeepUnusedCameraRenderingResources(Int32)
		/// </summary>
		protected RMethod r_RGetKeepUnusedCameraRenderingResources_Int32;
		public virtual RMethod RGetKeepUnusedCameraRenderingResources_Int32
		{
			get
			{
				if(r_RGetKeepUnusedCameraRenderingResources_Int32 == null)
				{
					r_RGetKeepUnusedCameraRenderingResources_Int32 = new(this, "GetKeepUnusedCameraRenderingResources", 0, typeof(System.Int32));
					r_RGetKeepUnusedCameraRenderingResources_Int32.SetBelong(this.instance);
				}
				return r_RGetKeepUnusedCameraRenderingResources_Int32;
			}
		}

		/// <summary>
		/// Void SetKeepUnusedCameraRenderingResources(Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetKeepUnusedCameraRenderingResources_Int32_Boolean;
		public virtual RMethod RSetKeepUnusedCameraRenderingResources_Int32_Boolean
		{
			get
			{
				if(r_RSetKeepUnusedCameraRenderingResources_Int32_Boolean == null)
				{
					r_RSetKeepUnusedCameraRenderingResources_Int32_Boolean = new(this, "SetKeepUnusedCameraRenderingResources", 0, typeof(System.Int32), typeof(System.Boolean));
					r_RSetKeepUnusedCameraRenderingResources_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetKeepUnusedCameraRenderingResources_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void GetClosestReflectionProbes(System.Collections.Generic.List`1[UnityEngine.Rendering.ReflectionProbeBlendInfo])
		/// </summary>
		protected RMethod r_RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_;
		public virtual RMethod RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_
		{
			get
			{
				if(r_RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_ == null)
				{
					r_RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_ = new(this, "GetClosestReflectionProbes", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Rendering.ReflectionProbeBlendInfo)));
					r_RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_.SetBelong(this.instance);
				}
				return r_RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_;
			}
		}

		/// <summary>
		/// Single SampleHeight(UnityEngine.Vector3)
		/// </summary>
		protected RMethod r_RSampleHeight_Vector3;
		public virtual RMethod RSampleHeight_Vector3
		{
			get
			{
				if(r_RSampleHeight_Vector3 == null)
				{
					r_RSampleHeight_Vector3 = new(this, "SampleHeight", 0, typeof(UnityEngine.Vector3));
					r_RSampleHeight_Vector3.SetBelong(this.instance);
				}
				return r_RSampleHeight_Vector3;
			}
		}

		/// <summary>
		/// Void AddTreeInstance(UnityEngine.TreeInstance)
		/// </summary>
		protected RMethod r_RAddTreeInstance_TreeInstance;
		public virtual RMethod RAddTreeInstance_TreeInstance
		{
			get
			{
				if(r_RAddTreeInstance_TreeInstance == null)
				{
					r_RAddTreeInstance_TreeInstance = new(this, "AddTreeInstance", 0, typeof(UnityEngine.TreeInstance));
					r_RAddTreeInstance_TreeInstance.SetBelong(this.instance);
				}
				return r_RAddTreeInstance_TreeInstance;
			}
		}

		/// <summary>
		/// Void SetNeighbors(UnityEngine.Terrain, UnityEngine.Terrain, UnityEngine.Terrain, UnityEngine.Terrain)
		/// </summary>
		protected RMethod r_RSetNeighbors_Terrain_Terrain_Terrain_Terrain;
		public virtual RMethod RSetNeighbors_Terrain_Terrain_Terrain_Terrain
		{
			get
			{
				if(r_RSetNeighbors_Terrain_Terrain_Terrain_Terrain == null)
				{
					r_RSetNeighbors_Terrain_Terrain_Terrain_Terrain = new(this, "SetNeighbors", 0, typeof(UnityEngine.Terrain), typeof(UnityEngine.Terrain), typeof(UnityEngine.Terrain), typeof(UnityEngine.Terrain));
					r_RSetNeighbors_Terrain_Terrain_Terrain_Terrain.SetBelong(this.instance);
				}
				return r_RSetNeighbors_Terrain_Terrain_Terrain_Terrain;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 GetPosition()
		/// </summary>
		protected RMethod r_RGetPosition;
		public virtual RMethod RGetPosition
		{
			get
			{
				if(r_RGetPosition == null)
				{
					r_RGetPosition = new(this, "GetPosition", 0);
					r_RGetPosition.SetBelong(this.instance);
				}
				return r_RGetPosition;
			}
		}

		/// <summary>
		/// Void Flush()
		/// </summary>
		protected RMethod r_RFlush;
		public virtual RMethod RFlush
		{
			get
			{
				if(r_RFlush == null)
				{
					r_RFlush = new(this, "Flush", 0);
					r_RFlush.SetBelong(this.instance);
				}
				return r_RFlush;
			}
		}

		/// <summary>
		/// Void RemoveTrees(UnityEngine.Vector2, Single, Int32)
		/// </summary>
		protected RMethod r_RRemoveTrees_Vector2_Single_Int32;
		public virtual RMethod RRemoveTrees_Vector2_Single_Int32
		{
			get
			{
				if(r_RRemoveTrees_Vector2_Single_Int32 == null)
				{
					r_RRemoveTrees_Vector2_Single_Int32 = new(this, "RemoveTrees", 0, typeof(UnityEngine.Vector2), typeof(System.Single), typeof(System.Int32));
					r_RRemoveTrees_Vector2_Single_Int32.SetBelong(this.instance);
				}
				return r_RRemoveTrees_Vector2_Single_Int32;
			}
		}

		/// <summary>
		/// Void SetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RSetSplatMaterialPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RSetSplatMaterialPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_RSetSplatMaterialPropertyBlock_MaterialPropertyBlock == null)
				{
					r_RSetSplatMaterialPropertyBlock_MaterialPropertyBlock = new(this, "SetSplatMaterialPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_RSetSplatMaterialPropertyBlock_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RSetSplatMaterialPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void GetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RGetSplatMaterialPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RGetSplatMaterialPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_RGetSplatMaterialPropertyBlock_MaterialPropertyBlock == null)
				{
					r_RGetSplatMaterialPropertyBlock_MaterialPropertyBlock = new(this, "GetSplatMaterialPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_RGetSplatMaterialPropertyBlock_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RGetSplatMaterialPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void Internal_GetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock)
		/// </summary>
		protected RMethod r_RInternal_GetSplatMaterialPropertyBlock_MaterialPropertyBlock;
		public virtual RMethod RInternal_GetSplatMaterialPropertyBlock_MaterialPropertyBlock
		{
			get
			{
				if(r_RInternal_GetSplatMaterialPropertyBlock_MaterialPropertyBlock == null)
				{
					r_RInternal_GetSplatMaterialPropertyBlock_MaterialPropertyBlock = new(this, "Internal_GetSplatMaterialPropertyBlock", 0, typeof(UnityEngine.MaterialPropertyBlock));
					r_RInternal_GetSplatMaterialPropertyBlock_MaterialPropertyBlock.SetBelong(this.instance);
				}
				return r_RInternal_GetSplatMaterialPropertyBlock_MaterialPropertyBlock;
			}
		}

		/// <summary>
		/// Void SetConnectivityDirty()
		/// </summary>
		protected static RMethod r_RSetConnectivityDirty;
		public static RMethod RSetConnectivityDirty
		{
			get
			{
				if(r_RSetConnectivityDirty == null)
				{
					r_RSetConnectivityDirty = new(typeof(UnityEngine.Terrain), "SetConnectivityDirty", 0);
					r_RSetConnectivityDirty.SetBelong(null);
				}
				return r_RSetConnectivityDirty;
			}
		}

		/// <summary>
		/// Void GetActiveTerrains(System.Collections.Generic.List`1[UnityEngine.Terrain])
		/// </summary>
		protected static RMethod r_RGetActiveTerrains_List_d_Terrain_p_;
		public static RMethod RGetActiveTerrains_List_d_Terrain_p_
		{
			get
			{
				if(r_RGetActiveTerrains_List_d_Terrain_p_ == null)
				{
					r_RGetActiveTerrains_List_d_Terrain_p_ = new(typeof(UnityEngine.Terrain), "GetActiveTerrains", 0, typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Terrain)));
					r_RGetActiveTerrains_List_d_Terrain_p_.SetBelong(null);
				}
				return r_RGetActiveTerrains_List_d_Terrain_p_;
			}
		}

		/// <summary>
		/// Void Internal_FillActiveTerrainList(System.Object)
		/// </summary>
		protected static RMethod r_RInternal_FillActiveTerrainList_Object;
		public static RMethod RInternal_FillActiveTerrainList_Object
		{
			get
			{
				if(r_RInternal_FillActiveTerrainList_Object == null)
				{
					r_RInternal_FillActiveTerrainList_Object = new(typeof(UnityEngine.Terrain), "Internal_FillActiveTerrainList", 0, typeof(System.Object));
					r_RInternal_FillActiveTerrainList_Object.SetBelong(null);
				}
				return r_RInternal_FillActiveTerrainList_Object;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject CreateTerrainGameObject(UnityEngine.TerrainData)
		/// </summary>
		protected static RMethod r_RCreateTerrainGameObject_TerrainData;
		public static RMethod RCreateTerrainGameObject_TerrainData
		{
			get
			{
				if(r_RCreateTerrainGameObject_TerrainData == null)
				{
					r_RCreateTerrainGameObject_TerrainData = new(typeof(UnityEngine.Terrain), "CreateTerrainGameObject", 0, typeof(UnityEngine.TerrainData));
					r_RCreateTerrainGameObject_TerrainData.SetBelong(null);
				}
				return r_RCreateTerrainGameObject_TerrainData;
			}
		}

		/// <summary>
		/// Void ApplyDelayedHeightmapModification()
		/// </summary>
		protected RMethod r_RApplyDelayedHeightmapModification;
		public virtual RMethod RApplyDelayedHeightmapModification
		{
			get
			{
				if(r_RApplyDelayedHeightmapModification == null)
				{
					r_RApplyDelayedHeightmapModification = new(this, "ApplyDelayedHeightmapModification", 0);
					r_RApplyDelayedHeightmapModification.SetBelong(this.instance);
				}
				return r_RApplyDelayedHeightmapModification;
			}
		}

		/// <summary>
		/// Void get_lightmapScaleOffset_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_lightmapScaleOffset_Injected_Out_Vector4;
		public virtual RMethod Rget_lightmapScaleOffset_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_lightmapScaleOffset_Injected_Out_Vector4 == null)
				{
					r_Rget_lightmapScaleOffset_Injected_Out_Vector4 = new(this, "get_lightmapScaleOffset_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_lightmapScaleOffset_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_lightmapScaleOffset_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void set_lightmapScaleOffset_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rset_lightmapScaleOffset_Injected_Ref_Vector4;
		public virtual RMethod Rset_lightmapScaleOffset_Injected_Ref_Vector4
		{
			get
			{
				if(r_Rset_lightmapScaleOffset_Injected_Ref_Vector4 == null)
				{
					r_Rset_lightmapScaleOffset_Injected_Ref_Vector4 = new(this, "set_lightmapScaleOffset_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rset_lightmapScaleOffset_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_Rset_lightmapScaleOffset_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void get_realtimeLightmapScaleOffset_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rget_realtimeLightmapScaleOffset_Injected_Out_Vector4;
		public virtual RMethod Rget_realtimeLightmapScaleOffset_Injected_Out_Vector4
		{
			get
			{
				if(r_Rget_realtimeLightmapScaleOffset_Injected_Out_Vector4 == null)
				{
					r_Rget_realtimeLightmapScaleOffset_Injected_Out_Vector4 = new(this, "get_realtimeLightmapScaleOffset_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rget_realtimeLightmapScaleOffset_Injected_Out_Vector4.SetBelong(this.instance);
				}
				return r_Rget_realtimeLightmapScaleOffset_Injected_Out_Vector4;
			}
		}

		/// <summary>
		/// Void set_realtimeLightmapScaleOffset_Injected(UnityEngine.Vector4 ByRef)
		/// </summary>
		protected RMethod r_Rset_realtimeLightmapScaleOffset_Injected_Ref_Vector4;
		public virtual RMethod Rset_realtimeLightmapScaleOffset_Injected_Ref_Vector4
		{
			get
			{
				if(r_Rset_realtimeLightmapScaleOffset_Injected_Ref_Vector4 == null)
				{
					r_Rset_realtimeLightmapScaleOffset_Injected_Ref_Vector4 = new(this, "set_realtimeLightmapScaleOffset_Injected", 0, typeof(UnityEngine.Vector4).MakeByRefType());
					r_Rset_realtimeLightmapScaleOffset_Injected_Ref_Vector4.SetBelong(this.instance);
				}
				return r_Rset_realtimeLightmapScaleOffset_Injected_Ref_Vector4;
			}
		}

		/// <summary>
		/// Void get_patchBoundsMultiplier_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rget_patchBoundsMultiplier_Injected_Out_Vector3;
		public virtual RMethod Rget_patchBoundsMultiplier_Injected_Out_Vector3
		{
			get
			{
				if(r_Rget_patchBoundsMultiplier_Injected_Out_Vector3 == null)
				{
					r_Rget_patchBoundsMultiplier_Injected_Out_Vector3 = new(this, "get_patchBoundsMultiplier_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rget_patchBoundsMultiplier_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_Rget_patchBoundsMultiplier_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void set_patchBoundsMultiplier_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_Rset_patchBoundsMultiplier_Injected_Ref_Vector3;
		public virtual RMethod Rset_patchBoundsMultiplier_Injected_Ref_Vector3
		{
			get
			{
				if(r_Rset_patchBoundsMultiplier_Injected_Ref_Vector3 == null)
				{
					r_Rset_patchBoundsMultiplier_Injected_Ref_Vector3 = new(this, "set_patchBoundsMultiplier_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_Rset_patchBoundsMultiplier_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_Rset_patchBoundsMultiplier_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Single SampleHeight_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RSampleHeight_Injected_Ref_Vector3;
		public virtual RMethod RSampleHeight_Injected_Ref_Vector3
		{
			get
			{
				if(r_RSampleHeight_Injected_Ref_Vector3 == null)
				{
					r_RSampleHeight_Injected_Ref_Vector3 = new(this, "SampleHeight_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_RSampleHeight_Injected_Ref_Vector3.SetBelong(this.instance);
				}
				return r_RSampleHeight_Injected_Ref_Vector3;
			}
		}

		/// <summary>
		/// Void AddTreeInstance_Injected(UnityEngine.TreeInstance ByRef)
		/// </summary>
		protected RMethod r_RAddTreeInstance_Injected_Ref_TreeInstance;
		public virtual RMethod RAddTreeInstance_Injected_Ref_TreeInstance
		{
			get
			{
				if(r_RAddTreeInstance_Injected_Ref_TreeInstance == null)
				{
					r_RAddTreeInstance_Injected_Ref_TreeInstance = new(this, "AddTreeInstance_Injected", 0, typeof(UnityEngine.TreeInstance).MakeByRefType());
					r_RAddTreeInstance_Injected_Ref_TreeInstance.SetBelong(this.instance);
				}
				return r_RAddTreeInstance_Injected_Ref_TreeInstance;
			}
		}

		/// <summary>
		/// Void GetPosition_Injected(UnityEngine.Vector3 ByRef)
		/// </summary>
		protected RMethod r_RGetPosition_Injected_Out_Vector3;
		public virtual RMethod RGetPosition_Injected_Out_Vector3
		{
			get
			{
				if(r_RGetPosition_Injected_Out_Vector3 == null)
				{
					r_RGetPosition_Injected_Out_Vector3 = new(this, "GetPosition_Injected", 0, typeof(UnityEngine.Vector3).MakeByRefType());
					r_RGetPosition_Injected_Out_Vector3.SetBelong(this.instance);
				}
				return r_RGetPosition_Injected_Out_Vector3;
			}
		}

		/// <summary>
		/// Void RemoveTrees_Injected(UnityEngine.Vector2 ByRef, Single, Int32)
		/// </summary>
		protected RMethod r_RRemoveTrees_Injected_Ref_Vector2_Single_Int32;
		public virtual RMethod RRemoveTrees_Injected_Ref_Vector2_Single_Int32
		{
			get
			{
				if(r_RRemoveTrees_Injected_Ref_Vector2_Single_Int32 == null)
				{
					r_RRemoveTrees_Injected_Ref_Vector2_Single_Int32 = new(this, "RemoveTrees_Injected", 0, typeof(UnityEngine.Vector2).MakeByRefType(), typeof(System.Single), typeof(System.Int32));
					r_RRemoveTrees_Injected_Ref_Vector2_Single_Int32.SetBelong(this.instance);
				}
				return r_RRemoveTrees_Injected_Ref_Vector2_Single_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponent_Type;
		public virtual RMethod RGetComponent_Type
		{
			get
			{
				if(r_RGetComponent_Type == null)
				{
					r_RGetComponent_Type = new(this, "GetComponent", 0, typeof(System.Type));
					r_RGetComponent_Type.SetBelong(this.instance);
				}
				return r_RGetComponent_Type;
			}
		}

		/// <summary>
		/// Void GetComponentFastPath(System.Type, IntPtr)
		/// </summary>
		protected RMethod r_RGetComponentFastPath_Type_IntPtr;
		public virtual RMethod RGetComponentFastPath_Type_IntPtr
		{
			get
			{
				if(r_RGetComponentFastPath_Type_IntPtr == null)
				{
					r_RGetComponentFastPath_Type_IntPtr = new(this, "GetComponentFastPath", 0, typeof(System.Type), typeof(System.IntPtr));
					r_RGetComponentFastPath_Type_IntPtr.SetBelong(this.instance);
				}
				return r_RGetComponentFastPath_Type_IntPtr;
			}
		}

		/// <summary>
		/// T GetComponent[T]()
		/// </summary>
		protected RMethod r_RGetComponent_GT;
		public virtual RMethod RGetComponent_GT
		{
			get
			{
				if(r_RGetComponent_GT == null)
				{
					r_RGetComponent_GT = new(this, "GetComponent", 1);
					r_RGetComponent_GT.SetBelong(this.instance);
				}
				return r_RGetComponent_GT;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent(System.Type, UnityEngine.Component ByRef)
		/// </summary>
		protected RMethod r_RTryGetComponent_Type_Out_Component;
		public virtual RMethod RTryGetComponent_Type_Out_Component
		{
			get
			{
				if(r_RTryGetComponent_Type_Out_Component == null)
				{
					r_RTryGetComponent_Type_Out_Component = new(this, "TryGetComponent", 0, typeof(System.Type), typeof(UnityEngine.Component).MakeByRefType());
					r_RTryGetComponent_Type_Out_Component.SetBelong(this.instance);
				}
				return r_RTryGetComponent_Type_Out_Component;
			}
		}

		/// <summary>
		/// Boolean TryGetComponent[T](T ByRef)
		/// </summary>
		protected RMethod r_RTryGetComponent_GT_Out_T;
		public virtual RMethod RTryGetComponent_GT_Out_T
		{
			get
			{
				if(r_RTryGetComponent_GT_Out_T == null)
				{
					r_RTryGetComponent_GT_Out_T = new(this, "TryGetComponent", 1, Type.MakeGenericMethodParameter(0).MakeByRefType());
					r_RTryGetComponent_GT_Out_T.SetBelong(this.instance);
				}
				return r_RTryGetComponent_GT_Out_T;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponent(System.String)
		/// </summary>
		protected RMethod r_RGetComponent_String;
		public virtual RMethod RGetComponent_String
		{
			get
			{
				if(r_RGetComponent_String == null)
				{
					r_RGetComponent_String = new(this, "GetComponent", 0, typeof(System.String));
					r_RGetComponent_String.SetBelong(this.instance);
				}
				return r_RGetComponent_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_Type_Boolean;
		public virtual RMethod RGetComponentInChildren_Type_Boolean
		{
			get
			{
				if(r_RGetComponentInChildren_Type_Boolean == null)
				{
					r_RGetComponentInChildren_Type_Boolean = new(this, "GetComponentInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInChildren(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_Type;
		public virtual RMethod RGetComponentInChildren_Type
		{
			get
			{
				if(r_RGetComponentInChildren_Type == null)
				{
					r_RGetComponentInChildren_Type = new(this, "GetComponentInChildren", 0, typeof(System.Type));
					r_RGetComponentInChildren_Type.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_Type;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInChildren_GT_Boolean;
		public virtual RMethod RGetComponentInChildren_GT_Boolean
		{
			get
			{
				if(r_RGetComponentInChildren_GT_Boolean == null)
				{
					r_RGetComponentInChildren_GT_Boolean = new(this, "GetComponentInChildren", 1, typeof(System.Boolean));
					r_RGetComponentInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInChildren[T]()
		/// </summary>
		protected RMethod r_RGetComponentInChildren_GT;
		public virtual RMethod RGetComponentInChildren_GT
		{
			get
			{
				if(r_RGetComponentInChildren_GT == null)
				{
					r_RGetComponentInChildren_GT = new(this, "GetComponentInChildren", 1);
					r_RGetComponentInChildren_GT.SetBelong(this.instance);
				}
				return r_RGetComponentInChildren_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_Type_Boolean;
		public virtual RMethod RGetComponentsInChildren_Type_Boolean
		{
			get
			{
				if(r_RGetComponentsInChildren_Type_Boolean == null)
				{
					r_RGetComponentsInChildren_Type_Boolean = new(this, "GetComponentsInChildren", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentsInChildren_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInChildren(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_Type;
		public virtual RMethod RGetComponentsInChildren_Type
		{
			get
			{
				if(r_RGetComponentsInChildren_Type == null)
				{
					r_RGetComponentsInChildren_Type = new(this, "GetComponentsInChildren", 0, typeof(System.Type));
					r_RGetComponentsInChildren_Type.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_Boolean;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_Boolean == null)
				{
					r_RGetComponentsInChildren_GT_Boolean = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean));
					r_RGetComponentsInChildren_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_ == null)
				{
					r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInChildren[T]()
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT;
		public virtual RMethod RGetComponentsInChildren_GT
		{
			get
			{
				if(r_RGetComponentsInChildren_GT == null)
				{
					r_RGetComponentsInChildren_GT = new(this, "GetComponentsInChildren", 1);
					r_RGetComponentsInChildren_GT.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT;
			}
		}

		/// <summary>
		/// Void GetComponentsInChildren[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInChildren_GT_List_d_T_p_;
		public virtual RMethod RGetComponentsInChildren_GT_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInChildren_GT_List_d_T_p_ == null)
				{
					r_RGetComponentsInChildren_GT_List_d_T_p_ = new(this, "GetComponentsInChildren", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInChildren_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInChildren_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInParent_Type_Boolean;
		public virtual RMethod RGetComponentInParent_Type_Boolean
		{
			get
			{
				if(r_RGetComponentInParent_Type_Boolean == null)
				{
					r_RGetComponentInParent_Type_Boolean = new(this, "GetComponentInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetComponentInParent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentInParent_Type;
		public virtual RMethod RGetComponentInParent_Type
		{
			get
			{
				if(r_RGetComponentInParent_Type == null)
				{
					r_RGetComponentInParent_Type = new(this, "GetComponentInParent", 0, typeof(System.Type));
					r_RGetComponentInParent_Type.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_Type;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentInParent_GT_Boolean;
		public virtual RMethod RGetComponentInParent_GT_Boolean
		{
			get
			{
				if(r_RGetComponentInParent_GT_Boolean == null)
				{
					r_RGetComponentInParent_GT_Boolean = new(this, "GetComponentInParent", 1, typeof(System.Boolean));
					r_RGetComponentInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// T GetComponentInParent[T]()
		/// </summary>
		protected RMethod r_RGetComponentInParent_GT;
		public virtual RMethod RGetComponentInParent_GT
		{
			get
			{
				if(r_RGetComponentInParent_GT == null)
				{
					r_RGetComponentInParent_GT = new(this, "GetComponentInParent", 1);
					r_RGetComponentInParent_GT.SetBelong(this.instance);
				}
				return r_RGetComponentInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type, Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_Type_Boolean;
		public virtual RMethod RGetComponentsInParent_Type_Boolean
		{
			get
			{
				if(r_RGetComponentsInParent_Type_Boolean == null)
				{
					r_RGetComponentsInParent_Type_Boolean = new(this, "GetComponentsInParent", 0, typeof(System.Type), typeof(System.Boolean));
					r_RGetComponentsInParent_Type_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_Type_Boolean;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponentsInParent(System.Type)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_Type;
		public virtual RMethod RGetComponentsInParent_Type
		{
			get
			{
				if(r_RGetComponentsInParent_Type == null)
				{
					r_RGetComponentsInParent_Type = new(this, "GetComponentsInParent", 0, typeof(System.Type));
					r_RGetComponentsInParent_Type.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_Type;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T](Boolean)
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT_Boolean;
		public virtual RMethod RGetComponentsInParent_GT_Boolean
		{
			get
			{
				if(r_RGetComponentsInParent_GT_Boolean == null)
				{
					r_RGetComponentsInParent_GT_Boolean = new(this, "GetComponentsInParent", 1, typeof(System.Boolean));
					r_RGetComponentsInParent_GT_Boolean.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT_Boolean;
			}
		}

		/// <summary>
		/// Void GetComponentsInParent[T](Boolean, System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT_Boolean_List_d_T_p_;
		public virtual RMethod RGetComponentsInParent_GT_Boolean_List_d_T_p_
		{
			get
			{
				if(r_RGetComponentsInParent_GT_Boolean_List_d_T_p_ == null)
				{
					r_RGetComponentsInParent_GT_Boolean_List_d_T_p_ = new(this, "GetComponentsInParent", 1, typeof(System.Boolean), typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponentsInParent_GT_Boolean_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT_Boolean_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponentsInParent[T]()
		/// </summary>
		protected RMethod r_RGetComponentsInParent_GT;
		public virtual RMethod RGetComponentsInParent_GT
		{
			get
			{
				if(r_RGetComponentsInParent_GT == null)
				{
					r_RGetComponentsInParent_GT = new(this, "GetComponentsInParent", 1);
					r_RGetComponentsInParent_GT.SetBelong(this.instance);
				}
				return r_RGetComponentsInParent_GT;
			}
		}

		/// <summary>
		/// UnityEngine.Component[] GetComponents(System.Type)
		/// </summary>
		protected RMethod r_RGetComponents_Type;
		public virtual RMethod RGetComponents_Type
		{
			get
			{
				if(r_RGetComponents_Type == null)
				{
					r_RGetComponents_Type = new(this, "GetComponents", 0, typeof(System.Type));
					r_RGetComponents_Type.SetBelong(this.instance);
				}
				return r_RGetComponents_Type;
			}
		}

		/// <summary>
		/// Void GetComponents(System.Type, System.Collections.Generic.List`1[UnityEngine.Component])
		/// </summary>
		protected RMethod r_RGetComponents_Type_List_d_Component_p_;
		public virtual RMethod RGetComponents_Type_List_d_Component_p_
		{
			get
			{
				if(r_RGetComponents_Type_List_d_Component_p_ == null)
				{
					r_RGetComponents_Type_List_d_Component_p_ = new(this, "GetComponents", 0, typeof(System.Type), typeof(System.Collections.Generic.List<>).MakeGenericType(typeof(UnityEngine.Component)));
					r_RGetComponents_Type_List_d_Component_p_.SetBelong(this.instance);
				}
				return r_RGetComponents_Type_List_d_Component_p_;
			}
		}

		/// <summary>
		/// Void GetComponents[T](System.Collections.Generic.List`1[T])
		/// </summary>
		protected RMethod r_RGetComponents_GT_List_d_T_p_;
		public virtual RMethod RGetComponents_GT_List_d_T_p_
		{
			get
			{
				if(r_RGetComponents_GT_List_d_T_p_ == null)
				{
					r_RGetComponents_GT_List_d_T_p_ = new(this, "GetComponents", 1, typeof(System.Collections.Generic.List<>).MakeGenericType(Type.MakeGenericMethodParameter(0)));
					r_RGetComponents_GT_List_d_T_p_.SetBelong(this.instance);
				}
				return r_RGetComponents_GT_List_d_T_p_;
			}
		}

		/// <summary>
		/// T[] GetComponents[T]()
		/// </summary>
		protected RMethod r_RGetComponents_GT;
		public virtual RMethod RGetComponents_GT
		{
			get
			{
				if(r_RGetComponents_GT == null)
				{
					r_RGetComponents_GT = new(this, "GetComponents", 1);
					r_RGetComponents_GT.SetBelong(this.instance);
				}
				return r_RGetComponents_GT;
			}
		}

		/// <summary>
		/// Boolean CompareTag(System.String)
		/// </summary>
		protected RMethod r_RCompareTag_String;
		public virtual RMethod RCompareTag_String
		{
			get
			{
				if(r_RCompareTag_String == null)
				{
					r_RCompareTag_String = new(this, "CompareTag", 0, typeof(System.String));
					r_RCompareTag_String.SetBelong(this.instance);
				}
				return r_RCompareTag_String;
			}
		}

		/// <summary>
		/// UnityEngine.Component GetCoupledComponent()
		/// </summary>
		protected RMethod r_RGetCoupledComponent;
		public virtual RMethod RGetCoupledComponent
		{
			get
			{
				if(r_RGetCoupledComponent == null)
				{
					r_RGetCoupledComponent = new(this, "GetCoupledComponent", 0);
					r_RGetCoupledComponent.SetBelong(this.instance);
				}
				return r_RGetCoupledComponent;
			}
		}

		/// <summary>
		/// Boolean IsCoupledComponent()
		/// </summary>
		protected RMethod r_RIsCoupledComponent;
		public virtual RMethod RIsCoupledComponent
		{
			get
			{
				if(r_RIsCoupledComponent == null)
				{
					r_RIsCoupledComponent = new(this, "IsCoupledComponent", 0);
					r_RIsCoupledComponent.SetBelong(this.instance);
				}
				return r_RIsCoupledComponent;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessageUpwards_String_Object_SendMessageOptions == null)
				{
					r_RSendMessageUpwards_String_Object_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessageUpwards_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_Object;
		public virtual RMethod RSendMessageUpwards_String_Object
		{
			get
			{
				if(r_RSendMessageUpwards_String_Object == null)
				{
					r_RSendMessageUpwards_String_Object = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(System.Object));
					r_RSendMessageUpwards_String_Object.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String;
		public virtual RMethod RSendMessageUpwards_String
		{
			get
			{
				if(r_RSendMessageUpwards_String == null)
				{
					r_RSendMessageUpwards_String = new(this, "SendMessageUpwards", 0, typeof(System.String));
					r_RSendMessageUpwards_String.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String;
			}
		}

		/// <summary>
		/// Void SendMessageUpwards(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessageUpwards_String_SendMessageOptions;
		public virtual RMethod RSendMessageUpwards_String_SendMessageOptions
		{
			get
			{
				if(r_RSendMessageUpwards_String_SendMessageOptions == null)
				{
					r_RSendMessageUpwards_String_SendMessageOptions = new(this, "SendMessageUpwards", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessageUpwards_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessageUpwards_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object;
		public virtual RMethod RSendMessage_String_Object
		{
			get
			{
				if(r_RSendMessage_String_Object == null)
				{
					r_RSendMessage_String_Object = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object));
					r_RSendMessage_String_Object.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String)
		/// </summary>
		protected RMethod r_RSendMessage_String;
		public virtual RMethod RSendMessage_String
		{
			get
			{
				if(r_RSendMessage_String == null)
				{
					r_RSendMessage_String = new(this, "SendMessage", 0, typeof(System.String));
					r_RSendMessage_String.SetBelong(this.instance);
				}
				return r_RSendMessage_String;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_Object_SendMessageOptions;
		public virtual RMethod RSendMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_Object_SendMessageOptions == null)
				{
					r_RSendMessage_String_Object_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void SendMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RSendMessage_String_SendMessageOptions;
		public virtual RMethod RSendMessage_String_SendMessageOptions
		{
			get
			{
				if(r_RSendMessage_String_SendMessageOptions == null)
				{
					r_RSendMessage_String_SendMessageOptions = new(this, "SendMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RSendMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RSendMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_Object_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_Object_SendMessageOptions
		{
			get
			{
				if(r_RBroadcastMessage_String_Object_SendMessageOptions == null)
				{
					r_RBroadcastMessage_String_Object_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object), typeof(UnityEngine.SendMessageOptions));
					r_RBroadcastMessage_String_Object_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_Object_SendMessageOptions;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, System.Object)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_Object;
		public virtual RMethod RBroadcastMessage_String_Object
		{
			get
			{
				if(r_RBroadcastMessage_String_Object == null)
				{
					r_RBroadcastMessage_String_Object = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(System.Object));
					r_RBroadcastMessage_String_Object.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_Object;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String;
		public virtual RMethod RBroadcastMessage_String
		{
			get
			{
				if(r_RBroadcastMessage_String == null)
				{
					r_RBroadcastMessage_String = new(this, "BroadcastMessage", 0, typeof(System.String));
					r_RBroadcastMessage_String.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String;
			}
		}

		/// <summary>
		/// Void BroadcastMessage(System.String, UnityEngine.SendMessageOptions)
		/// </summary>
		protected RMethod r_RBroadcastMessage_String_SendMessageOptions;
		public virtual RMethod RBroadcastMessage_String_SendMessageOptions
		{
			get
			{
				if(r_RBroadcastMessage_String_SendMessageOptions == null)
				{
					r_RBroadcastMessage_String_SendMessageOptions = new(this, "BroadcastMessage", 0, typeof(System.String), typeof(UnityEngine.SendMessageOptions));
					r_RBroadcastMessage_String_SendMessageOptions.SetBelong(this.instance);
				}
				return r_RBroadcastMessage_String_SendMessageOptions;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RTerrain() : base("UnityEngine.Terrain")
        {
        }

        public RTerrain(System.Object instance) : base("UnityEngine.Terrain")
		{
            SetInstance(instance);
		}

        public RTerrain(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTerrain(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean GetKeepUnusedCameraRenderingResources(System.Int32  @cameraInstanceID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cameraInstanceID};
            var ___result = RGetKeepUnusedCameraRenderingResources_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetKeepUnusedCameraRenderingResources(System.Int32  @cameraInstanceID, System.Boolean  @keepUnused)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cameraInstanceID, @keepUnused};
            var ___result = RSetKeepUnusedCameraRenderingResources_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetClosestReflectionProbes(System.Collections.Generic.List<UnityEngine.Rendering.ReflectionProbeBlendInfo>  @result)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@result};
            var ___result = RGetClosestReflectionProbes_List_d_ReflectionProbeBlendInfo_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Single SampleHeight(UnityEngine.Vector3  @worldPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition};
            var ___result = RSampleHeight_Vector3.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void AddTreeInstance(UnityEngine.TreeInstance  @instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instance};
            var ___result = RAddTreeInstance_TreeInstance.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNeighbors(UnityEngine.Terrain  @left, UnityEngine.Terrain  @top, UnityEngine.Terrain  @right, UnityEngine.Terrain  @bottom)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@left, @top, @right, @bottom};
            var ___result = RSetNeighbors_Terrain_Terrain_Terrain_Terrain.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Vector3 GetPosition()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPosition.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3)___result;
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RemoveTrees(UnityEngine.Vector2  @position, System.Single  @radius, System.Int32  @prototypeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @radius, @prototypeIndex};
            var ___result = RRemoveTrees_Vector2_Single_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock  @properties)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@properties};
            var ___result = RSetSplatMaterialPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest};
            var ___result = RGetSplatMaterialPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Internal_GetSplatMaterialPropertyBlock(UnityEngine.MaterialPropertyBlock  @dest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dest};
            var ___result = RInternal_GetSplatMaterialPropertyBlock_MaterialPropertyBlock.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetConnectivityDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetConnectivityDirty.Invoke(___genericsType, ___parameters);

            
        }


        public static void GetActiveTerrains(System.Collections.Generic.List<UnityEngine.Terrain>  @terrainList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@terrainList};
            var ___result = RGetActiveTerrains_List_d_Terrain_p_.Invoke(___genericsType, ___parameters);

            
        }


        public static void Internal_FillActiveTerrainList(System.Object  @terrainList)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@terrainList};
            var ___result = RInternal_FillActiveTerrainList_Object.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.GameObject CreateTerrainGameObject(UnityEngine.TerrainData  @assignTerrain)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@assignTerrain};
            var ___result = RCreateTerrainGameObject_TerrainData.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GameObject)___result;
        }


        public virtual void ApplyDelayedHeightmapModification()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyDelayedHeightmapModification.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void get_lightmapScaleOffset_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_lightmapScaleOffset_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void set_lightmapScaleOffset_Injected(ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_lightmapScaleOffset_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_realtimeLightmapScaleOffset_Injected(out UnityEngine.Vector4  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_realtimeLightmapScaleOffset_Injected_Out_Vector4.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void set_realtimeLightmapScaleOffset_Injected(ref UnityEngine.Vector4  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_realtimeLightmapScaleOffset_Injected_Ref_Vector4.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector4)___parameters[0];

            
        }


        public virtual void get_patchBoundsMultiplier_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = Rget_patchBoundsMultiplier_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void set_patchBoundsMultiplier_Injected(ref UnityEngine.Vector3  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = Rset_patchBoundsMultiplier_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			value = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual System.Single SampleHeight_Injected(ref UnityEngine.Vector3  @worldPosition)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@worldPosition};
            var ___result = RSampleHeight_Injected_Ref_Vector3.Invoke(___genericsType, ___parameters);
			worldPosition = (UnityEngine.Vector3)___parameters[0];

            return (System.Single)___result;
        }


        public virtual void AddTreeInstance_Injected(ref UnityEngine.TreeInstance  @instance)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@instance};
            var ___result = RAddTreeInstance_Injected_Ref_TreeInstance.Invoke(___genericsType, ___parameters);
			instance = (UnityEngine.TreeInstance)___parameters[0];

            
        }


        public virtual void GetPosition_Injected(out UnityEngine.Vector3  @ret)
        {
			ret = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ret};
            var ___result = RGetPosition_Injected_Out_Vector3.Invoke(___genericsType, ___parameters);
			ret = (UnityEngine.Vector3)___parameters[0];

            
        }


        public virtual void RemoveTrees_Injected(ref UnityEngine.Vector2  @position, System.Single  @radius, System.Int32  @prototypeIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@position, @radius, @prototypeIndex};
            var ___result = RRemoveTrees_Injected_Ref_Vector2_Single_Int32.Invoke(___genericsType, ___parameters);
			position = (UnityEngine.Vector2)___parameters[0];

            
        }


        public virtual UnityEngine.Component GetComponent(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual void GetComponentFastPath(System.Type  @type, System.IntPtr  @oneFurtherThanResultValue)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @oneFurtherThanResultValue};
            var ___result = RGetComponentFastPath_Type_IntPtr.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T GetComponent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual System.Boolean TryGetComponent(System.Type  @type, out UnityEngine.Component  @component)
        {
			component = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @component};
            var ___result = RTryGetComponent_Type_Out_Component.Invoke(___genericsType, ___parameters);
			component = (UnityEngine.Component)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean TryGetComponent<T>(out T  @component)
        {
			component = default;

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@component};
            var ___result = RTryGetComponent_GT_Out_T.Invoke(___genericsType, ___parameters);
			component = (T)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component GetComponent(System.String  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponent_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInChildren(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentsInChildren_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInChildren(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentsInChildren_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInChildren<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInChildren_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @result)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @result};
            var ___result = RGetComponentsInChildren_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInChildren<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInChildren_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInChildren<T>(System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponentsInChildren_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual UnityEngine.Component GetComponentInParent(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual T GetComponentInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual T GetComponentInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentInParent_GT.Invoke(___genericsType, ___parameters);

            return (T)___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @t, System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t, @includeInactive};
            var ___result = RGetComponentsInParent_Type_Boolean.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual UnityEngine.Component[] GetComponentsInParent(System.Type  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@t};
            var ___result = RGetComponentsInParent_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual T[] GetComponentsInParent<T>(System.Boolean  @includeInactive)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive};
            var ___result = RGetComponentsInParent_GT_Boolean.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual void GetComponentsInParent<T>(System.Boolean  @includeInactive, System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@includeInactive, @results};
            var ___result = RGetComponentsInParent_GT_Boolean_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponentsInParent<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponentsInParent_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual UnityEngine.Component[] GetComponents(System.Type  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RGetComponents_Type.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component[])___result;
        }


        public virtual void GetComponents(System.Type  @type, System.Collections.Generic.List<UnityEngine.Component>  @results)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @results};
            var ___result = RGetComponents_Type_List_d_Component_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GetComponents<T>(System.Collections.Generic.List<T>  @results)
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{@results};
            var ___result = RGetComponents_GT_List_d_T_p_.Invoke(___genericsType, ___parameters);

            
        }


        public virtual T[] GetComponents<T>()
        {

            var ___genericsType = new Type[] {typeof(T)};
            var ___parameters = new object[]{};
            var ___result = RGetComponents_GT.Invoke(___genericsType, ___parameters);

            return (T[])___result;
        }


        public virtual System.Boolean CompareTag(System.String  @tag)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@tag};
            var ___result = RCompareTag_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Component GetCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetCoupledComponent.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Component)___result;
        }


        public virtual System.Boolean IsCoupledComponent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsCoupledComponent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SendMessageUpwards(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessageUpwards_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessageUpwards_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessageUpwards_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessageUpwards(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessageUpwards_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RSendMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RSendMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, System.Object  @value, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value, @options};
            var ___result = RSendMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RSendMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, System.Object  @parameter, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter, @options};
            var ___result = RBroadcastMessage_String_Object_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, System.Object  @parameter)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @parameter};
            var ___result = RBroadcastMessage_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RBroadcastMessage_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BroadcastMessage(System.String  @methodName, UnityEngine.SendMessageOptions  @options)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @options};
            var ___result = RBroadcastMessage_String_SendMessageOptions.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
