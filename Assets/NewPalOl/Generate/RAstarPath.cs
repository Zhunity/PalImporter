using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// AstarPath
	/// </summary>
    public partial class RAstarPath : RMember //
    {

		/// <summary>
		/// System.Int32 totalNodeAmount
		/// </summary>
		protected static RField r_totalNodeAmount;
		public static RField RtotalNodeAmount
		{
			get
			{
				if(r_totalNodeAmount == null)
				{
					r_totalNodeAmount = new(typeof(AstarPath), "totalNodeAmount");
					r_totalNodeAmount.SetBelong(null);
				}
				return r_totalNodeAmount;
			}
		}

		/// <summary>
		/// AstarClasses.Node[,][] staticNodes
		/// </summary>
		protected RFieldArray<RFieldArray<RAstarClasses.RNode>> r_staticNodes;
		public virtual RFieldArray<RFieldArray<RAstarClasses.RNode>> RstaticNodes
		{
			get
			{
				if(r_staticNodes == null)
				{
					r_staticNodes = new(this, "staticNodes");
					r_staticNodes.SetBelong(this.instance);
				}
				return r_staticNodes;
			}
		}

		/// <summary>
		/// AstarClasses.Grid[] grids
		/// </summary>
		protected RFieldArray<RAstarClasses.RGrid> r_grids;
		public virtual RFieldArray<RAstarClasses.RGrid> Rgrids
		{
			get
			{
				if(r_grids == null)
				{
					r_grids = new(this, "grids");
					r_grids.SetBelong(this.instance);
				}
				return r_grids;
			}
		}

		/// <summary>
		/// AstarClasses.Grid textureGrid
		/// </summary>
		protected RAstarClasses.RGrid r_textureGrid;
		public virtual RAstarClasses.RGrid RtextureGrid
		{
			get
			{
				if(r_textureGrid == null)
				{
					r_textureGrid = new(this, "textureGrid");
					r_textureGrid.SetBelong(this.instance);
				}
				return r_textureGrid;
			}
		}

		/// <summary>
		/// AstarClasses.Grid meshGrid
		/// </summary>
		protected RAstarClasses.RGrid r_meshGrid;
		public virtual RAstarClasses.RGrid RmeshGrid
		{
			get
			{
				if(r_meshGrid == null)
				{
					r_meshGrid = new(this, "meshGrid");
					r_meshGrid.SetBelong(this.instance);
				}
				return r_meshGrid;
			}
		}

		/// <summary>
		/// AstarClasses.NodeLink[] links
		/// </summary>
		protected RFieldArray<RAstarClasses.RNodeLink> r_links;
		public virtual RFieldArray<RAstarClasses.RNodeLink> Rlinks
		{
			get
			{
				if(r_links == null)
				{
					r_links = new(this, "links");
					r_links.SetBelong(this.instance);
				}
				return r_links;
			}
		}

		/// <summary>
		/// AstarClasses.GridGenerator gridGenerator
		/// </summary>
		protected RField r_gridGenerator;
		public virtual RField RgridGenerator
		{
			get
			{
				if(r_gridGenerator == null)
				{
					r_gridGenerator = new(this, "gridGenerator");
					r_gridGenerator.SetBelong(this.instance);
				}
				return r_gridGenerator;
			}
		}

		/// <summary>
		/// AstarPath+BinaryHeap binaryHeap
		/// </summary>
		protected RAstarPath.RBinaryHeap r_binaryHeap;
		public virtual RAstarPath.RBinaryHeap RbinaryHeap
		{
			get
			{
				if(r_binaryHeap == null)
				{
					r_binaryHeap = new(this, "binaryHeap");
					r_binaryHeap.SetBelong(this.instance);
				}
				return r_binaryHeap;
			}
		}

		/// <summary>
		/// System.Int32 levelCost
		/// </summary>
		protected RField r_levelCost;
		public virtual RField RlevelCost
		{
			get
			{
				if(r_levelCost == null)
				{
					r_levelCost = new(this, "levelCost");
					r_levelCost.SetBelong(this.instance);
				}
				return r_levelCost;
			}
		}

		/// <summary>
		/// System.Boolean calculateOnStartup
		/// </summary>
		protected RField r_calculateOnStartup;
		public virtual RField RcalculateOnStartup
		{
			get
			{
				if(r_calculateOnStartup == null)
				{
					r_calculateOnStartup = new(this, "calculateOnStartup");
					r_calculateOnStartup.SetBelong(this.instance);
				}
				return r_calculateOnStartup;
			}
		}

		/// <summary>
		/// System.Boolean activePath
		/// </summary>
		protected static RField r_activePath;
		public static RField RactivePath
		{
			get
			{
				if(r_activePath == null)
				{
					r_activePath = new(typeof(AstarPath), "activePath");
					r_activePath.SetBelong(null);
				}
				return r_activePath;
			}
		}

		/// <summary>
		/// AstarPath+Path prevPath
		/// </summary>
		protected static RAstarPath.RPath r_prevPath;
		public static RAstarPath.RPath RprevPath
		{
			get
			{
				if(r_prevPath == null)
				{
					r_prevPath = new(typeof(AstarPath), "prevPath");
					r_prevPath.SetBelong(null);
				}
				return r_prevPath;
			}
		}

		/// <summary>
		/// AstarPath+Path[] cache
		/// </summary>
		protected static RFieldArray<RAstarPath.RPath> r_cache;
		public static RFieldArray<RAstarPath.RPath> Rcache
		{
			get
			{
				if(r_cache == null)
				{
					r_cache = new(typeof(AstarPath), "cache");
					r_cache.SetBelong(null);
				}
				return r_cache;
			}
		}

		/// <summary>
		/// System.Boolean cachePaths
		/// </summary>
		protected RField r_cachePaths;
		public virtual RField RcachePaths
		{
			get
			{
				if(r_cachePaths == null)
				{
					r_cachePaths = new(this, "cachePaths");
					r_cachePaths.SetBelong(this.instance);
				}
				return r_cachePaths;
			}
		}

		/// <summary>
		/// System.Int32 cacheLimit
		/// </summary>
		protected RField r_cacheLimit;
		public virtual RField RcacheLimit
		{
			get
			{
				if(r_cacheLimit == null)
				{
					r_cacheLimit = new(this, "cacheLimit");
					r_cacheLimit.SetBelong(this.instance);
				}
				return r_cacheLimit;
			}
		}

		/// <summary>
		/// System.Single cacheTimeLimit
		/// </summary>
		protected RField r_cacheTimeLimit;
		public virtual RField RcacheTimeLimit
		{
			get
			{
				if(r_cacheTimeLimit == null)
				{
					r_cacheTimeLimit = new(this, "cacheTimeLimit");
					r_cacheTimeLimit.SetBelong(this.instance);
				}
				return r_cacheTimeLimit;
			}
		}

		/// <summary>
		/// System.Boolean showGrid
		/// </summary>
		protected RField r_showGrid;
		public virtual RField RshowGrid
		{
			get
			{
				if(r_showGrid == null)
				{
					r_showGrid = new(this, "showGrid");
					r_showGrid.SetBelong(this.instance);
				}
				return r_showGrid;
			}
		}

		/// <summary>
		/// System.Boolean showGridBounds
		/// </summary>
		protected RField r_showGridBounds;
		public virtual RField RshowGridBounds
		{
			get
			{
				if(r_showGridBounds == null)
				{
					r_showGridBounds = new(this, "showGridBounds");
					r_showGridBounds.SetBelong(this.instance);
				}
				return r_showGridBounds;
			}
		}

		/// <summary>
		/// System.Boolean showLinks
		/// </summary>
		protected RField r_showLinks;
		public virtual RField RshowLinks
		{
			get
			{
				if(r_showLinks == null)
				{
					r_showLinks = new(this, "showLinks");
					r_showLinks.SetBelong(this.instance);
				}
				return r_showLinks;
			}
		}

		/// <summary>
		/// System.Boolean NodeLinkDragModle
		/// </summary>
		protected RField r_NodeLinkDragModle;
		public virtual RField RNodeLinkDragModle
		{
			get
			{
				if(r_NodeLinkDragModle == null)
				{
					r_NodeLinkDragModle = new(this, "NodeLinkDragModle");
					r_NodeLinkDragModle.SetBelong(this.instance);
				}
				return r_NodeLinkDragModle;
			}
		}

		/// <summary>
		/// AstarPath active
		/// </summary>
		protected static RAstarPath r_active;
		public static RAstarPath Ractive
		{
			get
			{
				if(r_active == null)
				{
					r_active = new(typeof(AstarPath), "active");
					r_active.SetBelong(null);
				}
				return r_active;
			}
		}

		/// <summary>
		/// System.Int32[] costs
		/// </summary>
		protected static RFieldArray<RField> r_costs;
		public static RFieldArray<RField> Rcosts
		{
			get
			{
				if(r_costs == null)
				{
					r_costs = new(typeof(AstarPath), "costs");
					r_costs.SetBelong(null);
				}
				return r_costs;
			}
		}

		/// <summary>
		/// System.Int32 area
		/// </summary>
		protected RField r_area;
		public virtual RField Rarea
		{
			get
			{
				if(r_area == null)
				{
					r_area = new(this, "area");
					r_area.SetBelong(this.instance);
				}
				return r_area;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] areaColors
		/// </summary>
		protected RFieldArray<RUnityEngine.RColor> r_areaColors;
		public virtual RFieldArray<RUnityEngine.RColor> RareaColors
		{
			get
			{
				if(r_areaColors == null)
				{
					r_areaColors = new(this, "areaColors");
					r_areaColors.SetBelong(this.instance);
				}
				return r_areaColors;
			}
		}

		/// <summary>
		/// UnityEngine.Color[] presetAreaColors
		/// </summary>
		protected static RFieldArray<RUnityEngine.RColor> r_presetAreaColors;
		public static RFieldArray<RUnityEngine.RColor> RpresetAreaColors
		{
			get
			{
				if(r_presetAreaColors == null)
				{
					r_presetAreaColors = new(typeof(AstarPath), "presetAreaColors");
					r_presetAreaColors.SetBelong(null);
				}
				return r_presetAreaColors;
			}
		}

		/// <summary>
		/// System.Single maxFrameTime
		/// </summary>
		protected RField r_maxFrameTime;
		public virtual RField RmaxFrameTime
		{
			get
			{
				if(r_maxFrameTime == null)
				{
					r_maxFrameTime = new(this, "maxFrameTime");
					r_maxFrameTime.SetBelong(this.instance);
				}
				return r_maxFrameTime;
			}
		}

		/// <summary>
		/// System.Int32 maxPathsPerFrame
		/// </summary>
		protected RField r_maxPathsPerFrame;
		public virtual RField RmaxPathsPerFrame
		{
			get
			{
				if(r_maxPathsPerFrame == null)
				{
					r_maxPathsPerFrame = new(this, "maxPathsPerFrame");
					r_maxPathsPerFrame.SetBelong(this.instance);
				}
				return r_maxPathsPerFrame;
			}
		}

		/// <summary>
		/// System.Int32 pathExecutionDelay
		/// </summary>
		protected RField r_pathExecutionDelay;
		public virtual RField RpathExecutionDelay
		{
			get
			{
				if(r_pathExecutionDelay == null)
				{
					r_pathExecutionDelay = new(this, "pathExecutionDelay");
					r_pathExecutionDelay.SetBelong(this.instance);
				}
				return r_pathExecutionDelay;
			}
		}

		/// <summary>
		/// System.Int32 pathsThisFrame
		/// </summary>
		protected RField r_pathsThisFrame;
		public virtual RField RpathsThisFrame
		{
			get
			{
				if(r_pathsThisFrame == null)
				{
					r_pathsThisFrame = new(this, "pathsThisFrame");
					r_pathsThisFrame.SetBelong(this.instance);
				}
				return r_pathsThisFrame;
			}
		}

		/// <summary>
		/// System.Int32 lastPathFrame
		/// </summary>
		protected RField r_lastPathFrame;
		public virtual RField RlastPathFrame
		{
			get
			{
				if(r_lastPathFrame == null)
				{
					r_lastPathFrame = new(this, "lastPathFrame");
					r_lastPathFrame.SetBelong(this.instance);
				}
				return r_lastPathFrame;
			}
		}

		/// <summary>
		/// AstarClasses.Simplify simplify
		/// </summary>
		protected RField r_simplify;
		public virtual RField Rsimplify
		{
			get
			{
				if(r_simplify == null)
				{
					r_simplify = new(this, "simplify");
					r_simplify.SetBelong(this.instance);
				}
				return r_simplify;
			}
		}

		/// <summary>
		/// System.Single staticMaxAngle
		/// </summary>
		protected RField r_staticMaxAngle;
		public virtual RField RstaticMaxAngle
		{
			get
			{
				if(r_staticMaxAngle == null)
				{
					r_staticMaxAngle = new(this, "staticMaxAngle");
					r_staticMaxAngle.SetBelong(this.instance);
				}
				return r_staticMaxAngle;
			}
		}

		/// <summary>
		/// System.Boolean useNormal
		/// </summary>
		protected RField r_useNormal;
		public virtual RField RuseNormal
		{
			get
			{
				if(r_useNormal == null)
				{
					r_useNormal = new(this, "useNormal");
					r_useNormal.SetBelong(this.instance);
				}
				return r_useNormal;
			}
		}

		/// <summary>
		/// System.Single heapSize
		/// </summary>
		protected RField r_heapSize;
		public virtual RField RheapSize
		{
			get
			{
				if(r_heapSize == null)
				{
					r_heapSize = new(this, "heapSize");
					r_heapSize.SetBelong(this.instance);
				}
				return r_heapSize;
			}
		}

		/// <summary>
		/// System.Int32 maxPathQueueSize
		/// </summary>
		protected static RField r_maxPathQueueSize;
		public static RField RmaxPathQueueSize
		{
			get
			{
				if(r_maxPathQueueSize == null)
				{
					r_maxPathQueueSize = new(typeof(AstarPath), "maxPathQueueSize");
					r_maxPathQueueSize.SetBelong(null);
				}
				return r_maxPathQueueSize;
			}
		}

		/// <summary>
		/// System.Int32 currentCalculatingPath
		/// </summary>
		protected static RField r_currentCalculatingPath;
		public static RField RcurrentCalculatingPath
		{
			get
			{
				if(r_currentCalculatingPath == null)
				{
					r_currentCalculatingPath = new(typeof(AstarPath), "currentCalculatingPath");
					r_currentCalculatingPath.SetBelong(null);
				}
				return r_currentCalculatingPath;
			}
		}

		/// <summary>
		/// System.Int32 lastAddedPath
		/// </summary>
		protected static RField r_lastAddedPath;
		public static RField RlastAddedPath
		{
			get
			{
				if(r_lastAddedPath == null)
				{
					r_lastAddedPath = new(typeof(AstarPath), "lastAddedPath");
					r_lastAddedPath.SetBelong(null);
				}
				return r_lastAddedPath;
			}
		}

		/// <summary>
		/// AstarPath+Path[] pathQueue
		/// </summary>
		protected static RFieldArray<RAstarPath.RPath> r_pathQueue;
		public static RFieldArray<RAstarPath.RPath> RpathQueue
		{
			get
			{
				if(r_pathQueue == null)
				{
					r_pathQueue = new(typeof(AstarPath), "pathQueue");
					r_pathQueue.SetBelong(null);
				}
				return r_pathQueue;
			}
		}

		/// <summary>
		/// AstarData astarData
		/// </summary>
		protected RAstarData r_astarData;
		public virtual RAstarData RastarData
		{
			get
			{
				if(r_astarData == null)
				{
					r_astarData = new(this, "astarData");
					r_astarData.SetBelong(this.instance);
				}
				return r_astarData;
			}
		}

		/// <summary>
		/// AstarClasses.DebugMode debugMode
		/// </summary>
		protected RField r_debugMode;
		public virtual RField RdebugMode
		{
			get
			{
				if(r_debugMode == null)
				{
					r_debugMode = new(this, "debugMode");
					r_debugMode.SetBelong(this.instance);
				}
				return r_debugMode;
			}
		}

		/// <summary>
		/// System.Single debugModeRoof
		/// </summary>
		protected RField r_debugModeRoof;
		public virtual RField RdebugModeRoof
		{
			get
			{
				if(r_debugModeRoof == null)
				{
					r_debugModeRoof = new(this, "debugModeRoof");
					r_debugModeRoof.SetBelong(this.instance);
				}
				return r_debugModeRoof;
			}
		}

		/// <summary>
		/// System.Boolean showParent
		/// </summary>
		protected RField r_showParent;
		public virtual RField RshowParent
		{
			get
			{
				if(r_showParent == null)
				{
					r_showParent = new(this, "showParent");
					r_showParent.SetBelong(this.instance);
				}
				return r_showParent;
			}
		}

		/// <summary>
		/// System.Boolean showUnwalkable
		/// </summary>
		protected RField r_showUnwalkable;
		public virtual RField RshowUnwalkable
		{
			get
			{
				if(r_showUnwalkable == null)
				{
					r_showUnwalkable = new(this, "showUnwalkable");
					r_showUnwalkable.SetBelong(this.instance);
				}
				return r_showUnwalkable;
			}
		}

		/// <summary>
		/// System.Boolean onlyShowLastPath
		/// </summary>
		protected RField r_onlyShowLastPath;
		public virtual RField RonlyShowLastPath
		{
			get
			{
				if(r_onlyShowLastPath == null)
				{
					r_onlyShowLastPath = new(this, "onlyShowLastPath");
					r_onlyShowLastPath.SetBelong(this.instance);
				}
				return r_onlyShowLastPath;
			}
		}

		/// <summary>
		/// System.Boolean showNeighbours
		/// </summary>
		protected RField r_showNeighbours;
		public virtual RField RshowNeighbours
		{
			get
			{
				if(r_showNeighbours == null)
				{
					r_showNeighbours = new(this, "showNeighbours");
					r_showNeighbours.SetBelong(this.instance);
				}
				return r_showNeighbours;
			}
		}

		/// <summary>
		/// AstarPath+Path lastPath
		/// </summary>
		protected RAstarPath.RPath r_lastPath;
		public virtual RAstarPath.RPath RlastPath
		{
			get
			{
				if(r_lastPath == null)
				{
					r_lastPath = new(this, "lastPath");
					r_lastPath.SetBelong(this.instance);
				}
				return r_lastPath;
			}
		}

		/// <summary>
		/// System.Boolean anyPhysicsChanged
		/// </summary>
		protected RField r_anyPhysicsChanged;
		public virtual RField RanyPhysicsChanged
		{
			get
			{
				if(r_anyPhysicsChanged == null)
				{
					r_anyPhysicsChanged = new(this, "anyPhysicsChanged");
					r_anyPhysicsChanged.SetBelong(this.instance);
				}
				return r_anyPhysicsChanged;
			}
		}

		/// <summary>
		/// System.Int32 physicsChangedGrid
		/// </summary>
		protected RField r_physicsChangedGrid;
		public virtual RField RphysicsChangedGrid
		{
			get
			{
				if(r_physicsChangedGrid == null)
				{
					r_physicsChangedGrid = new(this, "physicsChangedGrid");
					r_physicsChangedGrid.SetBelong(this.instance);
				}
				return r_physicsChangedGrid;
			}
		}

		/// <summary>
		/// AstarClasses.Height heightMode
		/// </summary>
		protected RField r_heightMode;
		public virtual RField RheightMode
		{
			get
			{
				if(r_heightMode == null)
				{
					r_heightMode = new(this, "heightMode");
					r_heightMode.SetBelong(this.instance);
				}
				return r_heightMode;
			}
		}

		/// <summary>
		/// UnityEngine.LayerMask groundLayer
		/// </summary>
		protected RUnityEngine.RLayerMask r_groundLayer;
		public virtual RUnityEngine.RLayerMask RgroundLayer
		{
			get
			{
				if(r_groundLayer == null)
				{
					r_groundLayer = new(this, "groundLayer");
					r_groundLayer.SetBelong(this.instance);
				}
				return r_groundLayer;
			}
		}

		/// <summary>
		/// System.Boolean dontCutCorners
		/// </summary>
		protected RField r_dontCutCorners;
		public virtual RField RdontCutCorners
		{
			get
			{
				if(r_dontCutCorners == null)
				{
					r_dontCutCorners = new(this, "dontCutCorners");
					r_dontCutCorners.SetBelong(this.instance);
				}
				return r_dontCutCorners;
			}
		}

		/// <summary>
		/// System.Boolean testStraightLine
		/// </summary>
		protected RField r_testStraightLine;
		public virtual RField RtestStraightLine
		{
			get
			{
				if(r_testStraightLine == null)
				{
					r_testStraightLine = new(this, "testStraightLine");
					r_testStraightLine.SetBelong(this.instance);
				}
				return r_testStraightLine;
			}
		}

		/// <summary>
		/// System.Single lineAccuracy
		/// </summary>
		protected RField r_lineAccuracy;
		public virtual RField RlineAccuracy
		{
			get
			{
				if(r_lineAccuracy == null)
				{
					r_lineAccuracy = new(this, "lineAccuracy");
					r_lineAccuracy.SetBelong(this.instance);
				}
				return r_lineAccuracy;
			}
		}

		/// <summary>
		/// AstarClasses.Formula formula
		/// </summary>
		protected RField r_formula;
		public virtual RField Rformula
		{
			get
			{
				if(r_formula == null)
				{
					r_formula = new(this, "formula");
					r_formula.SetBelong(this.instance);
				}
				return r_formula;
			}
		}

		/// <summary>
		/// AstarClasses.IsNeighbour isNeighbours
		/// </summary>
		protected RField r_isNeighbours;
		public virtual RField RisNeighbours
		{
			get
			{
				if(r_isNeighbours == null)
				{
					r_isNeighbours = new(this, "isNeighbours");
					r_isNeighbours.SetBelong(this.instance);
				}
				return r_isNeighbours;
			}
		}

		/// <summary>
		/// System.Single heightRaycast
		/// </summary>
		protected RField r_heightRaycast;
		public virtual RField RheightRaycast
		{
			get
			{
				if(r_heightRaycast == null)
				{
					r_heightRaycast = new(this, "heightRaycast");
					r_heightRaycast.SetBelong(this.instance);
				}
				return r_heightRaycast;
			}
		}

		/// <summary>
		/// System.Boolean useWorldPositions
		/// </summary>
		protected RField r_useWorldPositions;
		public virtual RField RuseWorldPositions
		{
			get
			{
				if(r_useWorldPositions == null)
				{
					r_useWorldPositions = new(this, "useWorldPositions");
					r_useWorldPositions.SetBelong(this.instance);
				}
				return r_useWorldPositions;
			}
		}

		/// <summary>
		/// System.Single boundsMargin
		/// </summary>
		protected RField r_boundsMargin;
		public virtual RField RboundsMargin
		{
			get
			{
				if(r_boundsMargin == null)
				{
					r_boundsMargin = new(this, "boundsMargin");
					r_boundsMargin.SetBelong(this.instance);
				}
				return r_boundsMargin;
			}
		}

		/// <summary>
		/// System.Boolean quadtreePostProcess
		/// </summary>
		protected RField r_quadtreePostProcess;
		public virtual RField RquadtreePostProcess
		{
			get
			{
				if(r_quadtreePostProcess == null)
				{
					r_quadtreePostProcess = new(this, "quadtreePostProcess");
					r_quadtreePostProcess.SetBelong(this.instance);
				}
				return r_quadtreePostProcess;
			}
		}

		/// <summary>
		/// System.Int32 quadtreeMinDepth
		/// </summary>
		protected RField r_quadtreeMinDepth;
		public virtual RField RquadtreeMinDepth
		{
			get
			{
				if(r_quadtreeMinDepth == null)
				{
					r_quadtreeMinDepth = new(this, "quadtreeMinDepth");
					r_quadtreeMinDepth.SetBelong(this.instance);
				}
				return r_quadtreeMinDepth;
			}
		}

		/// <summary>
		/// System.Boolean quadtreeDebug
		/// </summary>
		protected RField r_quadtreeDebug;
		public virtual RField RquadtreeDebug
		{
			get
			{
				if(r_quadtreeDebug == null)
				{
					r_quadtreeDebug = new(this, "quadtreeDebug");
					r_quadtreeDebug.SetBelong(this.instance);
				}
				return r_quadtreeDebug;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D navTex
		/// </summary>
		protected RUnityEngine.RTexture2D r_navTex;
		public virtual RUnityEngine.RTexture2D RnavTex
		{
			get
			{
				if(r_navTex == null)
				{
					r_navTex = new(this, "navTex");
					r_navTex.SetBelong(this.instance);
				}
				return r_navTex;
			}
		}

		/// <summary>
		/// System.Single threshold
		/// </summary>
		protected RField r_threshold;
		public virtual RField Rthreshold
		{
			get
			{
				if(r_threshold == null)
				{
					r_threshold = new(this, "threshold");
					r_threshold.SetBelong(this.instance);
				}
				return r_threshold;
			}
		}

		/// <summary>
		/// System.Int32 penaltyMultiplier
		/// </summary>
		protected RField r_penaltyMultiplier;
		public virtual RField RpenaltyMultiplier
		{
			get
			{
				if(r_penaltyMultiplier == null)
				{
					r_penaltyMultiplier = new(this, "penaltyMultiplier");
					r_penaltyMultiplier.SetBelong(this.instance);
				}
				return r_penaltyMultiplier;
			}
		}

		/// <summary>
		/// System.String boundsTag
		/// </summary>
		protected RField r_boundsTag;
		public virtual RField RboundsTag
		{
			get
			{
				if(r_boundsTag == null)
				{
					r_boundsTag = new(this, "boundsTag");
					r_boundsTag.SetBelong(this.instance);
				}
				return r_boundsTag;
			}
		}

		/// <summary>
		/// System.Single neighbourDistanceLimit
		/// </summary>
		protected RField r_neighbourDistanceLimit;
		public virtual RField RneighbourDistanceLimit
		{
			get
			{
				if(r_neighbourDistanceLimit == null)
				{
					r_neighbourDistanceLimit = new(this, "neighbourDistanceLimit");
					r_neighbourDistanceLimit.SetBelong(this.instance);
				}
				return r_neighbourDistanceLimit;
			}
		}

		/// <summary>
		/// System.Single boundMargin
		/// </summary>
		protected RField r_boundMargin;
		public virtual RField RboundMargin
		{
			get
			{
				if(r_boundMargin == null)
				{
					r_boundMargin = new(this, "boundMargin");
					r_boundMargin.SetBelong(this.instance);
				}
				return r_boundMargin;
			}
		}

		/// <summary>
		/// UnityEngine.LayerMask boundsRayHitMask
		/// </summary>
		protected RUnityEngine.RLayerMask r_boundsRayHitMask;
		public virtual RUnityEngine.RLayerMask RboundsRayHitMask
		{
			get
			{
				if(r_boundsRayHitMask == null)
				{
					r_boundsRayHitMask = new(this, "boundsRayHitMask");
					r_boundsRayHitMask.SetBelong(this.instance);
				}
				return r_boundsRayHitMask;
			}
		}

		/// <summary>
		/// System.Single yLimit
		/// </summary>
		protected RField r_yLimit;
		public virtual RField RyLimit
		{
			get
			{
				if(r_yLimit == null)
				{
					r_yLimit = new(this, "yLimit");
					r_yLimit.SetBelong(this.instance);
				}
				return r_yLimit;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 navmeshRotation
		/// </summary>
		protected RUnityEngine.RVector3 r_navmeshRotation;
		public virtual RUnityEngine.RVector3 RnavmeshRotation
		{
			get
			{
				if(r_navmeshRotation == null)
				{
					r_navmeshRotation = new(this, "navmeshRotation");
					r_navmeshRotation.SetBelong(this.instance);
				}
				return r_navmeshRotation;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh navmesh
		/// </summary>
		protected RUnityEngine.RMesh r_navmesh;
		public virtual RUnityEngine.RMesh Rnavmesh
		{
			get
			{
				if(r_navmesh == null)
				{
					r_navmesh = new(this, "navmesh");
					r_navmesh.SetBelong(this.instance);
				}
				return r_navmesh;
			}
		}

		/// <summary>
		/// AstarClasses.CoordinateSystem meshCoordinateSystem
		/// </summary>
		protected RField r_meshCoordinateSystem;
		public virtual RField RmeshCoordinateSystem
		{
			get
			{
				if(r_meshCoordinateSystem == null)
				{
					r_meshCoordinateSystem = new(this, "meshCoordinateSystem");
					r_meshCoordinateSystem.SetBelong(this.instance);
				}
				return r_meshCoordinateSystem;
			}
		}

		/// <summary>
		/// AstarMath.Matrix rotationMatrix
		/// </summary>
		protected RAstarMath.RMatrix r_rotationMatrix;
		public virtual RAstarMath.RMatrix RrotationMatrix
		{
			get
			{
				if(r_rotationMatrix == null)
				{
					r_rotationMatrix = new(this, "rotationMatrix");
					r_rotationMatrix.SetBelong(this.instance);
				}
				return r_rotationMatrix;
			}
		}

		/// <summary>
		/// AstarClasses.MeshNodePosition meshNodePosition
		/// </summary>
		protected RField r_meshNodePosition;
		public virtual RField RmeshNodePosition
		{
			get
			{
				if(r_meshNodePosition == null)
				{
					r_meshNodePosition = new(this, "meshNodePosition");
					r_meshNodePosition.SetBelong(this.instance);
				}
				return r_meshNodePosition;
			}
		}

		/// <summary>
		/// UnityEngine.Transform listRootNode
		/// </summary>
		protected RUnityEngine.RTransform r_listRootNode;
		public virtual RUnityEngine.RTransform RlistRootNode
		{
			get
			{
				if(r_listRootNode == null)
				{
					r_listRootNode = new(this, "listRootNode");
					r_listRootNode.SetBelong(this.instance);
				}
				return r_listRootNode;
			}
		}

		/// <summary>
		/// UnityEngine.Transform EnterPoint
		/// </summary>
		protected RUnityEngine.RTransform r_EnterPoint;
		public virtual RUnityEngine.RTransform REnterPoint
		{
			get
			{
				if(r_EnterPoint == null)
				{
					r_EnterPoint = new(this, "EnterPoint");
					r_EnterPoint.SetBelong(this.instance);
				}
				return r_EnterPoint;
			}
		}

		/// <summary>
		/// System.String[] log
		/// </summary>
		protected static RFieldArray<RField> r_log;
		public static RFieldArray<RField> Rlog
		{
			get
			{
				if(r_log == null)
				{
					r_log = new(typeof(AstarPath), "log");
					r_log.SetBelong(null);
				}
				return r_log;
			}
		}

		/// <summary>
		/// System.Int32 lastLogEntry
		/// </summary>
		protected static RField r_lastLogEntry;
		public static RField RlastLogEntry
		{
			get
			{
				if(r_lastLogEntry == null)
				{
					r_lastLogEntry = new(typeof(AstarPath), "lastLogEntry");
					r_lastLogEntry.SetBelong(null);
				}
				return r_lastLogEntry;
			}
		}

		/// <summary>
		/// System.Threading.CancellationToken destroyCancellationToken
		/// </summary>
		protected RSystem.RThreading.RCancellationToken r_destroyCancellationToken;
		public virtual RSystem.RThreading.RCancellationToken RdestroyCancellationToken
		{
			get
			{
				if(r_destroyCancellationToken == null)
				{
					r_destroyCancellationToken = new(this, "destroyCancellationToken", -1);
					r_destroyCancellationToken.SetBelong(this.instance);
				}
				return r_destroyCancellationToken;
			}
		}

		/// <summary>
		/// Boolean useGUILayout
		/// </summary>
		protected RProperty r_useGUILayout;
		public virtual RProperty RuseGUILayout
		{
			get
			{
				if(r_useGUILayout == null)
				{
					r_useGUILayout = new(this, "useGUILayout", -1);
					r_useGUILayout.SetBelong(this.instance);
				}
				return r_useGUILayout;
			}
		}

		/// <summary>
		/// Boolean runInEditMode
		/// </summary>
		protected RProperty r_runInEditMode;
		public virtual RProperty RrunInEditMode
		{
			get
			{
				if(r_runInEditMode == null)
				{
					r_runInEditMode = new(this, "runInEditMode", -1);
					r_runInEditMode.SetBelong(this.instance);
				}
				return r_runInEditMode;
			}
		}

		/// <summary>
		/// Boolean allowPrefabModeInPlayMode
		/// </summary>
		protected RProperty r_allowPrefabModeInPlayMode;
		public virtual RProperty RallowPrefabModeInPlayMode
		{
			get
			{
				if(r_allowPrefabModeInPlayMode == null)
				{
					r_allowPrefabModeInPlayMode = new(this, "allowPrefabModeInPlayMode", -1);
					r_allowPrefabModeInPlayMode.SetBelong(this.instance);
				}
				return r_allowPrefabModeInPlayMode;
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
		/// Void GenerateRotationMatrix(AstarClasses.Grid)
		/// </summary>
		protected RMethod r_RGenerateRotationMatrix_Grid;
		public virtual RMethod RGenerateRotationMatrix_Grid
		{
			get
			{
				if(r_RGenerateRotationMatrix_Grid == null)
				{
					r_RGenerateRotationMatrix_Grid = new(this, "GenerateRotationMatrix", 0, typeof(AstarClasses.Grid));
					r_RGenerateRotationMatrix_Grid.SetBelong(this.instance);
				}
				return r_RGenerateRotationMatrix_Grid;
			}
		}

		/// <summary>
		/// Void AddLogEntry(System.String)
		/// </summary>
		protected static RMethod r_RAddLogEntry_String;
		public static RMethod RAddLogEntry_String
		{
			get
			{
				if(r_RAddLogEntry_String == null)
				{
					r_RAddLogEntry_String = new(typeof(AstarPath), "AddLogEntry", 0, typeof(System.String));
					r_RAddLogEntry_String.SetBelong(null);
				}
				return r_RAddLogEntry_String;
			}
		}

		/// <summary>
		/// Void OnDrawGizmos()
		/// </summary>
		protected RMethod r_ROnDrawGizmos;
		public virtual RMethod ROnDrawGizmos
		{
			get
			{
				if(r_ROnDrawGizmos == null)
				{
					r_ROnDrawGizmos = new(this, "OnDrawGizmos", 0);
					r_ROnDrawGizmos.SetBelong(this.instance);
				}
				return r_ROnDrawGizmos;
			}
		}

		/// <summary>
		/// Int32 GetUnwalkableNodeAmount()
		/// </summary>
		protected RMethod r_RGetUnwalkableNodeAmount;
		public virtual RMethod RGetUnwalkableNodeAmount
		{
			get
			{
				if(r_RGetUnwalkableNodeAmount == null)
				{
					r_RGetUnwalkableNodeAmount = new(this, "GetUnwalkableNodeAmount", 0);
					r_RGetUnwalkableNodeAmount.SetBelong(this.instance);
				}
				return r_RGetUnwalkableNodeAmount;
			}
		}

		/// <summary>
		/// Int32 GetWalkableNodeAmount()
		/// </summary>
		protected RMethod r_RGetWalkableNodeAmount;
		public virtual RMethod RGetWalkableNodeAmount
		{
			get
			{
				if(r_RGetWalkableNodeAmount == null)
				{
					r_RGetWalkableNodeAmount = new(this, "GetWalkableNodeAmount", 0);
					r_RGetWalkableNodeAmount.SetBelong(this.instance);
				}
				return r_RGetWalkableNodeAmount;
			}
		}

		/// <summary>
		/// Void StartPath(Path)
		/// </summary>
		protected static RMethod r_RStartPath_Path;
		public static RMethod RStartPath_Path
		{
			get
			{
				if(r_RStartPath_Path == null)
				{
					r_RStartPath_Path = new(typeof(AstarPath), "StartPath", 0,  ReleactionUtils.GetType("AstarPath+Path"));
					r_RStartPath_Path.SetBelong(null);
				}
				return r_RStartPath_Path;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator CalculatePaths()
		/// </summary>
		protected static RMethod r_RCalculatePaths;
		public static RMethod RCalculatePaths
		{
			get
			{
				if(r_RCalculatePaths == null)
				{
					r_RCalculatePaths = new(typeof(AstarPath), "CalculatePaths", 0);
					r_RCalculatePaths.SetBelong(null);
				}
				return r_RCalculatePaths;
			}
		}

		/// <summary>
		/// Void Start()
		/// </summary>
		protected RMethod r_RStart;
		public virtual RMethod RStart
		{
			get
			{
				if(r_RStart == null)
				{
					r_RStart = new(this, "Start", 0);
					r_RStart.SetBelong(this.instance);
				}
				return r_RStart;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocalTest(UnityEngine.Vector3, Boolean)
		/// </summary>
		protected static RMethod r_RToLocalTest_Vector3_Boolean;
		public static RMethod RToLocalTest_Vector3_Boolean
		{
			get
			{
				if(r_RToLocalTest_Vector3_Boolean == null)
				{
					r_RToLocalTest_Vector3_Boolean = new(typeof(AstarPath), "ToLocalTest", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_RToLocalTest_Vector3_Boolean.SetBelong(null);
				}
				return r_RToLocalTest_Vector3_Boolean;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocalTest(UnityEngine.Vector3, Boolean, Boolean, UnityEngine.LayerMask)
		/// </summary>
		protected static RMethod r_RToLocalTest_Vector3_Boolean_Boolean_LayerMask;
		public static RMethod RToLocalTest_Vector3_Boolean_Boolean_LayerMask
		{
			get
			{
				if(r_RToLocalTest_Vector3_Boolean_Boolean_LayerMask == null)
				{
					r_RToLocalTest_Vector3_Boolean_Boolean_LayerMask = new(typeof(AstarPath), "ToLocalTest", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.LayerMask));
					r_RToLocalTest_Vector3_Boolean_Boolean_LayerMask.SetBelong(null);
				}
				return r_RToLocalTest_Vector3_Boolean_Boolean_LayerMask;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocalForce(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RToLocalForce_Vector3;
		public static RMethod RToLocalForce_Vector3
		{
			get
			{
				if(r_RToLocalForce_Vector3 == null)
				{
					r_RToLocalForce_Vector3 = new(typeof(AstarPath), "ToLocalForce", 0, typeof(UnityEngine.Vector3));
					r_RToLocalForce_Vector3.SetBelong(null);
				}
				return r_RToLocalForce_Vector3;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocalTest2(UnityEngine.Vector3, Boolean)
		/// </summary>
		protected static RMethod r_RToLocalTest2_Vector3_Boolean;
		public static RMethod RToLocalTest2_Vector3_Boolean
		{
			get
			{
				if(r_RToLocalTest2_Vector3_Boolean == null)
				{
					r_RToLocalTest2_Vector3_Boolean = new(typeof(AstarPath), "ToLocalTest2", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_RToLocalTest2_Vector3_Boolean.SetBelong(null);
				}
				return r_RToLocalTest2_Vector3_Boolean;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocal(UnityEngine.Vector3, Int32)
		/// </summary>
		protected static RMethod r_RToLocal_Vector3_Int32;
		public static RMethod RToLocal_Vector3_Int32
		{
			get
			{
				if(r_RToLocal_Vector3_Int32 == null)
				{
					r_RToLocal_Vector3_Int32 = new(typeof(AstarPath), "ToLocal", 0, typeof(UnityEngine.Vector3), typeof(System.Int32));
					r_RToLocal_Vector3_Int32.SetBelong(null);
				}
				return r_RToLocal_Vector3_Int32;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocal(UnityEngine.Vector3, Int32, Boolean)
		/// </summary>
		protected static RMethod r_RToLocal_Vector3_Int32_Boolean;
		public static RMethod RToLocal_Vector3_Int32_Boolean
		{
			get
			{
				if(r_RToLocal_Vector3_Int32_Boolean == null)
				{
					r_RToLocal_Vector3_Int32_Boolean = new(typeof(AstarPath), "ToLocal", 0, typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(System.Boolean));
					r_RToLocal_Vector3_Int32_Boolean.SetBelong(null);
				}
				return r_RToLocal_Vector3_Int32_Boolean;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocal(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RToLocal_Vector3;
		public static RMethod RToLocal_Vector3
		{
			get
			{
				if(r_RToLocal_Vector3 == null)
				{
					r_RToLocal_Vector3 = new(typeof(AstarPath), "ToLocal", 0, typeof(UnityEngine.Vector3));
					r_RToLocal_Vector3.SetBelong(null);
				}
				return r_RToLocal_Vector3;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocal(UnityEngine.Vector3, Boolean)
		/// </summary>
		protected static RMethod r_RToLocal_Vector3_Boolean;
		public static RMethod RToLocal_Vector3_Boolean
		{
			get
			{
				if(r_RToLocal_Vector3_Boolean == null)
				{
					r_RToLocal_Vector3_Boolean = new(typeof(AstarPath), "ToLocal", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean));
					r_RToLocal_Vector3_Boolean.SetBelong(null);
				}
				return r_RToLocal_Vector3_Boolean;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocal(UnityEngine.Vector3, Boolean, Boolean, UnityEngine.LayerMask)
		/// </summary>
		protected static RMethod r_RToLocal_Vector3_Boolean_Boolean_LayerMask;
		public static RMethod RToLocal_Vector3_Boolean_Boolean_LayerMask
		{
			get
			{
				if(r_RToLocal_Vector3_Boolean_Boolean_LayerMask == null)
				{
					r_RToLocal_Vector3_Boolean_Boolean_LayerMask = new(typeof(AstarPath), "ToLocal", 0, typeof(UnityEngine.Vector3), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.LayerMask));
					r_RToLocal_Vector3_Boolean_Boolean_LayerMask.SetBelong(null);
				}
				return r_RToLocal_Vector3_Boolean_Boolean_LayerMask;
			}
		}

		/// <summary>
		/// Single ToLocalX(Single, Int32)
		/// </summary>
		protected static RMethod r_RToLocalX_Single_Int32;
		public static RMethod RToLocalX_Single_Int32
		{
			get
			{
				if(r_RToLocalX_Single_Int32 == null)
				{
					r_RToLocalX_Single_Int32 = new(typeof(AstarPath), "ToLocalX", 0, typeof(System.Single), typeof(System.Int32));
					r_RToLocalX_Single_Int32.SetBelong(null);
				}
				return r_RToLocalX_Single_Int32;
			}
		}

		/// <summary>
		/// Single ToLocalZ(Single, Int32)
		/// </summary>
		protected static RMethod r_RToLocalZ_Single_Int32;
		public static RMethod RToLocalZ_Single_Int32
		{
			get
			{
				if(r_RToLocalZ_Single_Int32 == null)
				{
					r_RToLocalZ_Single_Int32 = new(typeof(AstarPath), "ToLocalZ", 0, typeof(System.Single), typeof(System.Int32));
					r_RToLocalZ_Single_Int32.SetBelong(null);
				}
				return r_RToLocalZ_Single_Int32;
			}
		}

		/// <summary>
		/// AstarClasses.Int3 ToLocalUnclamped(UnityEngine.Vector3)
		/// </summary>
		protected static RMethod r_RToLocalUnclamped_Vector3;
		public static RMethod RToLocalUnclamped_Vector3
		{
			get
			{
				if(r_RToLocalUnclamped_Vector3 == null)
				{
					r_RToLocalUnclamped_Vector3 = new(typeof(AstarPath), "ToLocalUnclamped", 0, typeof(UnityEngine.Vector3));
					r_RToLocalUnclamped_Vector3.SetBelong(null);
				}
				return r_RToLocalUnclamped_Vector3;
			}
		}

		/// <summary>
		/// AstarClasses.Node GetNearest(AstarClasses.Node, Boolean)
		/// </summary>
		protected static RMethod r_RGetNearest_Node_Boolean;
		public static RMethod RGetNearest_Node_Boolean
		{
			get
			{
				if(r_RGetNearest_Node_Boolean == null)
				{
					r_RGetNearest_Node_Boolean = new(typeof(AstarPath), "GetNearest", 0, typeof(AstarClasses.Node), typeof(System.Boolean));
					r_RGetNearest_Node_Boolean.SetBelong(null);
				}
				return r_RGetNearest_Node_Boolean;
			}
		}

		/// <summary>
		/// AstarClasses.Node GetNearest(AstarClasses.Node, Boolean, Int32)
		/// </summary>
		protected static RMethod r_RGetNearest_Node_Boolean_Int32;
		public static RMethod RGetNearest_Node_Boolean_Int32
		{
			get
			{
				if(r_RGetNearest_Node_Boolean_Int32 == null)
				{
					r_RGetNearest_Node_Boolean_Int32 = new(typeof(AstarPath), "GetNearest", 0, typeof(AstarClasses.Node), typeof(System.Boolean), typeof(System.Int32));
					r_RGetNearest_Node_Boolean_Int32.SetBelong(null);
				}
				return r_RGetNearest_Node_Boolean_Int32;
			}
		}

		/// <summary>
		/// AstarClasses.Node GetNearest(AstarClasses.Node, Boolean, Int32, Int32)
		/// </summary>
		protected static RMethod r_RGetNearest_Node_Boolean_Int32_Int32;
		public static RMethod RGetNearest_Node_Boolean_Int32_Int32
		{
			get
			{
				if(r_RGetNearest_Node_Boolean_Int32_Int32 == null)
				{
					r_RGetNearest_Node_Boolean_Int32_Int32 = new(typeof(AstarPath), "GetNearest", 0, typeof(AstarClasses.Node), typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32));
					r_RGetNearest_Node_Boolean_Int32_Int32.SetBelong(null);
				}
				return r_RGetNearest_Node_Boolean_Int32_Int32;
			}
		}

		/// <summary>
		/// AstarClasses.Node GetNode(AstarClasses.Int3)
		/// </summary>
		protected static RMethod r_RGetNode_Int3;
		public static RMethod RGetNode_Int3
		{
			get
			{
				if(r_RGetNode_Int3 == null)
				{
					r_RGetNode_Int3 = new(typeof(AstarPath), "GetNode", 0, typeof(AstarClasses.Int3));
					r_RGetNode_Int3.SetBelong(null);
				}
				return r_RGetNode_Int3;
			}
		}

		/// <summary>
		/// AstarClasses.Node GetNode(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_RGetNode_Int32_Int32_Int32;
		public static RMethod RGetNode_Int32_Int32_Int32
		{
			get
			{
				if(r_RGetNode_Int32_Int32_Int32 == null)
				{
					r_RGetNode_Int32_Int32_Int32 = new(typeof(AstarPath), "GetNode", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RGetNode_Int32_Int32_Int32.SetBelong(null);
				}
				return r_RGetNode_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator SetNodes(Boolean, UnityEngine.Bounds, Boolean, Single)
		/// </summary>
		protected RMethod r_RSetNodes_Boolean_Bounds_Boolean_Single;
		public virtual RMethod RSetNodes_Boolean_Bounds_Boolean_Single
		{
			get
			{
				if(r_RSetNodes_Boolean_Bounds_Boolean_Single == null)
				{
					r_RSetNodes_Boolean_Bounds_Boolean_Single = new(this, "SetNodes", 0, typeof(System.Boolean), typeof(UnityEngine.Bounds), typeof(System.Boolean), typeof(System.Single));
					r_RSetNodes_Boolean_Bounds_Boolean_Single.SetBelong(this.instance);
				}
				return r_RSetNodes_Boolean_Bounds_Boolean_Single;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator SetNodes(Boolean, UnityEngine.Bounds, Boolean, Boolean, Single)
		/// </summary>
		protected RMethod r_RSetNodes_Boolean_Bounds_Boolean_Boolean_Single;
		public virtual RMethod RSetNodes_Boolean_Bounds_Boolean_Boolean_Single
		{
			get
			{
				if(r_RSetNodes_Boolean_Bounds_Boolean_Boolean_Single == null)
				{
					r_RSetNodes_Boolean_Bounds_Boolean_Boolean_Single = new(this, "SetNodes", 0, typeof(System.Boolean), typeof(UnityEngine.Bounds), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Single));
					r_RSetNodes_Boolean_Bounds_Boolean_Boolean_Single.SetBelong(this.instance);
				}
				return r_RSetNodes_Boolean_Bounds_Boolean_Boolean_Single;
			}
		}

		/// <summary>
		/// Void SetNodes(Boolean, UnityEngine.Bounds, Boolean)
		/// </summary>
		protected RMethod r_RSetNodes_Boolean_Bounds_Boolean;
		public virtual RMethod RSetNodes_Boolean_Bounds_Boolean
		{
			get
			{
				if(r_RSetNodes_Boolean_Bounds_Boolean == null)
				{
					r_RSetNodes_Boolean_Bounds_Boolean = new(this, "SetNodes", 0, typeof(System.Boolean), typeof(UnityEngine.Bounds), typeof(System.Boolean));
					r_RSetNodes_Boolean_Bounds_Boolean.SetBelong(this.instance);
				}
				return r_RSetNodes_Boolean_Bounds_Boolean;
			}
		}

		/// <summary>
		/// Void SetNodes(Boolean, UnityEngine.Vector3, Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetNodes_Boolean_Vector3_Int32_Boolean;
		public virtual RMethod RSetNodes_Boolean_Vector3_Int32_Boolean
		{
			get
			{
				if(r_RSetNodes_Boolean_Vector3_Int32_Boolean == null)
				{
					r_RSetNodes_Boolean_Vector3_Int32_Boolean = new(this, "SetNodes", 0, typeof(System.Boolean), typeof(UnityEngine.Vector3), typeof(System.Int32), typeof(System.Boolean));
					r_RSetNodes_Boolean_Vector3_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetNodes_Boolean_Vector3_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetNodes(Boolean, UnityEngine.Bounds, Boolean, Boolean)
		/// </summary>
		protected RMethod r_RSetNodes_Boolean_Bounds_Boolean_Boolean;
		public virtual RMethod RSetNodes_Boolean_Bounds_Boolean_Boolean
		{
			get
			{
				if(r_RSetNodes_Boolean_Bounds_Boolean_Boolean == null)
				{
					r_RSetNodes_Boolean_Bounds_Boolean_Boolean = new(this, "SetNodes", 0, typeof(System.Boolean), typeof(UnityEngine.Bounds), typeof(System.Boolean), typeof(System.Boolean));
					r_RSetNodes_Boolean_Bounds_Boolean_Boolean.SetBelong(this.instance);
				}
				return r_RSetNodes_Boolean_Bounds_Boolean_Boolean;
			}
		}

		/// <summary>
		/// Void SetNodesWorld(Boolean, UnityEngine.Rect, Int32, Boolean)
		/// </summary>
		protected RMethod r_RSetNodesWorld_Boolean_Rect_Int32_Boolean;
		public virtual RMethod RSetNodesWorld_Boolean_Rect_Int32_Boolean
		{
			get
			{
				if(r_RSetNodesWorld_Boolean_Rect_Int32_Boolean == null)
				{
					r_RSetNodesWorld_Boolean_Rect_Int32_Boolean = new(this, "SetNodesWorld", 0, typeof(System.Boolean), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Boolean));
					r_RSetNodesWorld_Boolean_Rect_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RSetNodesWorld_Boolean_Rect_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void SetNodesLocal(Boolean, Int32[], Int32)
		/// </summary>
		protected RMethod r_RSetNodesLocal_Boolean_Int32Array_Int32;
		public virtual RMethod RSetNodesLocal_Boolean_Int32Array_Int32
		{
			get
			{
				if(r_RSetNodesLocal_Boolean_Int32Array_Int32 == null)
				{
					r_RSetNodesLocal_Boolean_Int32Array_Int32 = new(this, "SetNodesLocal", 0, typeof(System.Boolean), typeof(System.Int32).MakeArrayType(), typeof(System.Int32));
					r_RSetNodesLocal_Boolean_Int32Array_Int32.SetBelong(this.instance);
				}
				return r_RSetNodesLocal_Boolean_Int32Array_Int32;
			}
		}

		/// <summary>
		/// Void RecalculateArea(Int32[], Int32)
		/// </summary>
		protected RMethod r_RRecalculateArea_Int32Array_Int32;
		public virtual RMethod RRecalculateArea_Int32Array_Int32
		{
			get
			{
				if(r_RRecalculateArea_Int32Array_Int32 == null)
				{
					r_RRecalculateArea_Int32Array_Int32 = new(this, "RecalculateArea", 0, typeof(System.Int32).MakeArrayType(), typeof(System.Int32));
					r_RRecalculateArea_Int32Array_Int32.SetBelong(this.instance);
				}
				return r_RRecalculateArea_Int32Array_Int32;
			}
		}

		/// <summary>
		/// Void RecalcNeighbours(AstarClasses.Node)
		/// </summary>
		protected RMethod r_RRecalcNeighbours_Node;
		public virtual RMethod RRecalcNeighbours_Node
		{
			get
			{
				if(r_RRecalcNeighbours_Node == null)
				{
					r_RRecalcNeighbours_Node = new(this, "RecalcNeighbours", 0, typeof(AstarClasses.Node));
					r_RRecalcNeighbours_Node.SetBelong(this.instance);
				}
				return r_RRecalcNeighbours_Node;
			}
		}

		/// <summary>
		/// Void FullPhysicsCheck(AstarClasses.Node, AstarClasses.Grid)
		/// </summary>
		protected RMethod r_RFullPhysicsCheck_Node_Grid;
		public virtual RMethod RFullPhysicsCheck_Node_Grid
		{
			get
			{
				if(r_RFullPhysicsCheck_Node_Grid == null)
				{
					r_RFullPhysicsCheck_Node_Grid = new(this, "FullPhysicsCheck", 0, typeof(AstarClasses.Node), typeof(AstarClasses.Grid));
					r_RFullPhysicsCheck_Node_Grid.SetBelong(this.instance);
				}
				return r_RFullPhysicsCheck_Node_Grid;
			}
		}

		/// <summary>
		/// Void FullPhysicsCheck(AstarClasses.Node, AstarClasses.Grid, UnityEngine.LayerMask)
		/// </summary>
		protected RMethod r_RFullPhysicsCheck_Node_Grid_LayerMask;
		public virtual RMethod RFullPhysicsCheck_Node_Grid_LayerMask
		{
			get
			{
				if(r_RFullPhysicsCheck_Node_Grid_LayerMask == null)
				{
					r_RFullPhysicsCheck_Node_Grid_LayerMask = new(this, "FullPhysicsCheck", 0, typeof(AstarClasses.Node), typeof(AstarClasses.Grid), typeof(UnityEngine.LayerMask));
					r_RFullPhysicsCheck_Node_Grid_LayerMask.SetBelong(this.instance);
				}
				return r_RFullPhysicsCheck_Node_Grid_LayerMask;
			}
		}

		/// <summary>
		/// Void FullPhysicsCheck(AstarClasses.Node, AstarClasses.Grid, UnityEngine.LayerMask, Boolean)
		/// </summary>
		protected RMethod r_RFullPhysicsCheck_Node_Grid_LayerMask_Boolean;
		public virtual RMethod RFullPhysicsCheck_Node_Grid_LayerMask_Boolean
		{
			get
			{
				if(r_RFullPhysicsCheck_Node_Grid_LayerMask_Boolean == null)
				{
					r_RFullPhysicsCheck_Node_Grid_LayerMask_Boolean = new(this, "FullPhysicsCheck", 0, typeof(AstarClasses.Node), typeof(AstarClasses.Grid), typeof(UnityEngine.LayerMask), typeof(System.Boolean));
					r_RFullPhysicsCheck_Node_Grid_LayerMask_Boolean.SetBelong(this.instance);
				}
				return r_RFullPhysicsCheck_Node_Grid_LayerMask_Boolean;
			}
		}

		/// <summary>
		/// Boolean CheckLine(UnityEngine.Vector3, UnityEngine.Vector3, Single)
		/// </summary>
		protected static RMethod r_RCheckLine_Vector3_Vector3_Single;
		public static RMethod RCheckLine_Vector3_Vector3_Single
		{
			get
			{
				if(r_RCheckLine_Vector3_Vector3_Single == null)
				{
					r_RCheckLine_Vector3_Vector3_Single = new(typeof(AstarPath), "CheckLine", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single));
					r_RCheckLine_Vector3_Vector3_Single.SetBelong(null);
				}
				return r_RCheckLine_Vector3_Vector3_Single;
			}
		}

		/// <summary>
		/// Boolean CheckLine(AstarClasses.Node, AstarClasses.Node, Single)
		/// </summary>
		protected static RMethod r_RCheckLine_Node_Node_Single;
		public static RMethod RCheckLine_Node_Node_Single
		{
			get
			{
				if(r_RCheckLine_Node_Node_Single == null)
				{
					r_RCheckLine_Node_Node_Single = new(typeof(AstarPath), "CheckLine", 0, typeof(AstarClasses.Node), typeof(AstarClasses.Node), typeof(System.Single));
					r_RCheckLine_Node_Node_Single.SetBelong(null);
				}
				return r_RCheckLine_Node_Node_Single;
			}
		}

		/// <summary>
		/// Single CheckLineDetailed(UnityEngine.Vector3, UnityEngine.Vector3, Single, Boolean)
		/// </summary>
		protected static RMethod r_RCheckLineDetailed_Vector3_Vector3_Single_Boolean;
		public static RMethod RCheckLineDetailed_Vector3_Vector3_Single_Boolean
		{
			get
			{
				if(r_RCheckLineDetailed_Vector3_Vector3_Single_Boolean == null)
				{
					r_RCheckLineDetailed_Vector3_Vector3_Single_Boolean = new(typeof(AstarPath), "CheckLineDetailed", 0, typeof(UnityEngine.Vector3), typeof(UnityEngine.Vector3), typeof(System.Single), typeof(System.Boolean));
					r_RCheckLineDetailed_Vector3_Vector3_Single_Boolean.SetBelong(null);
				}
				return r_RCheckLineDetailed_Vector3_Vector3_Single_Boolean;
			}
		}

		/// <summary>
		/// Single CheckLineDetailed(AstarClasses.Node, AstarClasses.Node, Single, Boolean)
		/// </summary>
		protected static RMethod r_RCheckLineDetailed_Node_Node_Single_Boolean;
		public static RMethod RCheckLineDetailed_Node_Node_Single_Boolean
		{
			get
			{
				if(r_RCheckLineDetailed_Node_Node_Single_Boolean == null)
				{
					r_RCheckLineDetailed_Node_Node_Single_Boolean = new(typeof(AstarPath), "CheckLineDetailed", 0, typeof(AstarClasses.Node), typeof(AstarClasses.Node), typeof(System.Single), typeof(System.Boolean));
					r_RCheckLineDetailed_Node_Node_Single_Boolean.SetBelong(null);
				}
				return r_RCheckLineDetailed_Node_Node_Single_Boolean;
			}
		}

		/// <summary>
		/// Void FloodFill(AstarClasses.Node, Int32)
		/// </summary>
		protected RMethod r_RFloodFill_Node_Int32;
		public virtual RMethod RFloodFill_Node_Int32
		{
			get
			{
				if(r_RFloodFill_Node_Int32 == null)
				{
					r_RFloodFill_Node_Int32 = new(this, "FloodFill", 0, typeof(AstarClasses.Node), typeof(System.Int32));
					r_RFloodFill_Node_Int32.SetBelong(this.instance);
				}
				return r_RFloodFill_Node_Int32;
			}
		}

		/// <summary>
		/// Void FloodFillAll()
		/// </summary>
		protected RMethod r_RFloodFillAll;
		public virtual RMethod RFloodFillAll
		{
			get
			{
				if(r_RFloodFillAll == null)
				{
					r_RFloodFillAll = new(this, "FloodFillAll", 0);
					r_RFloodFillAll.SetBelong(this.instance);
				}
				return r_RFloodFillAll;
			}
		}

		/// <summary>
		/// Void Scan()
		/// </summary>
		protected RMethod r_RScan;
		public virtual RMethod RScan
		{
			get
			{
				if(r_RScan == null)
				{
					r_RScan = new(this, "Scan", 0);
					r_RScan.SetBelong(this.instance);
				}
				return r_RScan;
			}
		}

		/// <summary>
		/// Void Scan(Boolean, Int32)
		/// </summary>
		protected RMethod r_RScan_Boolean_Int32;
		public virtual RMethod RScan_Boolean_Int32
		{
			get
			{
				if(r_RScan_Boolean_Int32 == null)
				{
					r_RScan_Boolean_Int32 = new(this, "Scan", 0, typeof(System.Boolean), typeof(System.Int32));
					r_RScan_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RScan_Boolean_Int32;
			}
		}

		/// <summary>
		/// Void ScanTexture()
		/// </summary>
		protected RMethod r_RScanTexture;
		public virtual RMethod RScanTexture
		{
			get
			{
				if(r_RScanTexture == null)
				{
					r_RScanTexture = new(this, "ScanTexture", 0);
					r_RScanTexture.SetBelong(this.instance);
				}
				return r_RScanTexture;
			}
		}

		/// <summary>
		/// Boolean TextureEvaluateNode(Int32, Int32)
		/// </summary>
		protected RMethod r_RTextureEvaluateNode_Int32_Int32;
		public virtual RMethod RTextureEvaluateNode_Int32_Int32
		{
			get
			{
				if(r_RTextureEvaluateNode_Int32_Int32 == null)
				{
					r_RTextureEvaluateNode_Int32_Int32 = new(this, "TextureEvaluateNode", 0, typeof(System.Int32), typeof(System.Int32));
					r_RTextureEvaluateNode_Int32_Int32.SetBelong(this.instance);
				}
				return r_RTextureEvaluateNode_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ScanTilemap(Boolean[], Int32, Int32)
		/// </summary>
		protected RMethod r_RScanTilemap_BooleanArray_Int32_Int32;
		public virtual RMethod RScanTilemap_BooleanArray_Int32_Int32
		{
			get
			{
				if(r_RScanTilemap_BooleanArray_Int32_Int32 == null)
				{
					r_RScanTilemap_BooleanArray_Int32_Int32 = new(this, "ScanTilemap", 0, typeof(System.Boolean).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RScanTilemap_BooleanArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RScanTilemap_BooleanArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ScanBounds()
		/// </summary>
		protected RMethod r_RScanBounds;
		public virtual RMethod RScanBounds
		{
			get
			{
				if(r_RScanBounds == null)
				{
					r_RScanBounds = new(this, "ScanBounds", 0);
					r_RScanBounds.SetBelong(this.instance);
				}
				return r_RScanBounds;
			}
		}

		/// <summary>
		/// Void ScanNavmesh()
		/// </summary>
		protected RMethod r_RScanNavmesh;
		public virtual RMethod RScanNavmesh
		{
			get
			{
				if(r_RScanNavmesh == null)
				{
					r_RScanNavmesh = new(this, "ScanNavmesh", 0);
					r_RScanNavmesh.SetBelong(this.instance);
				}
				return r_RScanNavmesh;
			}
		}

		/// <summary>
		/// Void ScanNavmeshEdge()
		/// </summary>
		protected RMethod r_RScanNavmeshEdge;
		public virtual RMethod RScanNavmeshEdge
		{
			get
			{
				if(r_RScanNavmeshEdge == null)
				{
					r_RScanNavmeshEdge = new(this, "ScanNavmeshEdge", 0);
					r_RScanNavmeshEdge.SetBelong(this.instance);
				}
				return r_RScanNavmeshEdge;
			}
		}

		/// <summary>
		/// Void ScanNavmeshCenter()
		/// </summary>
		protected RMethod r_RScanNavmeshCenter;
		public virtual RMethod RScanNavmeshCenter
		{
			get
			{
				if(r_RScanNavmeshCenter == null)
				{
					r_RScanNavmeshCenter = new(this, "ScanNavmeshCenter", 0);
					r_RScanNavmeshCenter.SetBelong(this.instance);
				}
				return r_RScanNavmeshCenter;
			}
		}

		/// <summary>
		/// Void ScanList()
		/// </summary>
		protected RMethod r_RScanList;
		public virtual RMethod RScanList
		{
			get
			{
				if(r_RScanList == null)
				{
					r_RScanList = new(this, "ScanList", 0);
					r_RScanList.SetBelong(this.instance);
				}
				return r_RScanList;
			}
		}

		/// <summary>
		/// Void ScanQuadtree()
		/// </summary>
		protected RMethod r_RScanQuadtree;
		public virtual RMethod RScanQuadtree
		{
			get
			{
				if(r_RScanQuadtree == null)
				{
					r_RScanQuadtree = new(this, "ScanQuadtree", 0);
					r_RScanQuadtree.SetBelong(this.instance);
				}
				return r_RScanQuadtree;
			}
		}

		/// <summary>
		/// AstarClasses.Node[] GetSurroundingNodes(AstarClasses.Node, Int32)
		/// </summary>
		protected RMethod r_RGetSurroundingNodes_Node_Int32;
		public virtual RMethod RGetSurroundingNodes_Node_Int32
		{
			get
			{
				if(r_RGetSurroundingNodes_Node_Int32 == null)
				{
					r_RGetSurroundingNodes_Node_Int32 = new(this, "GetSurroundingNodes", 0, typeof(AstarClasses.Node), typeof(System.Int32));
					r_RGetSurroundingNodes_Node_Int32.SetBelong(this.instance);
				}
				return r_RGetSurroundingNodes_Node_Int32;
			}
		}

		/// <summary>
		/// Int32 IsSingleArea(AstarClasses.Node, Int32, Boolean)
		/// </summary>
		protected RMethod r_RIsSingleArea_Node_Int32_Boolean;
		public virtual RMethod RIsSingleArea_Node_Int32_Boolean
		{
			get
			{
				if(r_RIsSingleArea_Node_Int32_Boolean == null)
				{
					r_RIsSingleArea_Node_Int32_Boolean = new(this, "IsSingleArea", 0, typeof(AstarClasses.Node), typeof(System.Int32), typeof(System.Boolean));
					r_RIsSingleArea_Node_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RIsSingleArea_Node_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void FillWithNode(AstarClasses.Node, AstarClasses.Int3, Int32)
		/// </summary>
		protected RMethod r_RFillWithNode_Node_Int3_Int32;
		public virtual RMethod RFillWithNode_Node_Int3_Int32
		{
			get
			{
				if(r_RFillWithNode_Node_Int3_Int32 == null)
				{
					r_RFillWithNode_Node_Int3_Int32 = new(this, "FillWithNode", 0, typeof(AstarClasses.Node), typeof(AstarClasses.Int3), typeof(System.Int32));
					r_RFillWithNode_Node_Int3_Int32.SetBelong(this.instance);
				}
				return r_RFillWithNode_Node_Int3_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Transform[] GetChildren(UnityEngine.Transform)
		/// </summary>
		protected RMethod r_RGetChildren_Transform;
		public virtual RMethod RGetChildren_Transform
		{
			get
			{
				if(r_RGetChildren_Transform == null)
				{
					r_RGetChildren_Transform = new(this, "GetChildren", 0, typeof(UnityEngine.Transform));
					r_RGetChildren_Transform.SetBelong(this.instance);
				}
				return r_RGetChildren_Transform;
			}
		}

		/// <summary>
		/// Void CreateGrid(AstarClasses.SimpleNode[])
		/// </summary>
		protected RMethod r_RCreateGrid_SimpleNodeArray;
		public virtual RMethod RCreateGrid_SimpleNodeArray
		{
			get
			{
				if(r_RCreateGrid_SimpleNodeArray == null)
				{
					r_RCreateGrid_SimpleNodeArray = new(this, "CreateGrid", 0, typeof(AstarClasses.SimpleNode).MakeArrayType());
					r_RCreateGrid_SimpleNodeArray.SetBelong(this.instance);
				}
				return r_RCreateGrid_SimpleNodeArray;
			}
		}

		/// <summary>
		/// Void CreateGrid(AstarClasses.SimpleNode[][])
		/// </summary>
		protected RMethod r_RCreateGrid_SimpleNodeArrayArray;
		public virtual RMethod RCreateGrid_SimpleNodeArrayArray
		{
			get
			{
				if(r_RCreateGrid_SimpleNodeArrayArray == null)
				{
					r_RCreateGrid_SimpleNodeArrayArray = new(this, "CreateGrid", 0, typeof(AstarClasses.SimpleNode).MakeArrayType().MakeArrayType());
					r_RCreateGrid_SimpleNodeArrayArray.SetBelong(this.instance);
				}
				return r_RCreateGrid_SimpleNodeArrayArray;
			}
		}

		/// <summary>
		/// Void ApplyEnablerLinks()
		/// </summary>
		protected RMethod r_RApplyEnablerLinks;
		public virtual RMethod RApplyEnablerLinks
		{
			get
			{
				if(r_RApplyEnablerLinks == null)
				{
					r_RApplyEnablerLinks = new(this, "ApplyEnablerLinks", 0);
					r_RApplyEnablerLinks.SetBelong(this.instance);
				}
				return r_RApplyEnablerLinks;
			}
		}

		/// <summary>
		/// Void ApplyLinks()
		/// </summary>
		protected RMethod r_RApplyLinks;
		public virtual RMethod RApplyLinks
		{
			get
			{
				if(r_RApplyLinks == null)
				{
					r_RApplyLinks = new(this, "ApplyLinks", 0);
					r_RApplyLinks.SetBelong(this.instance);
				}
				return r_RApplyLinks;
			}
		}

		/// <summary>
		/// Void GenerateNavmesh(UnityEngine.Vector3[])
		/// </summary>
		protected RMethod r_RGenerateNavmesh_Vector3Array;
		public virtual RMethod RGenerateNavmesh_Vector3Array
		{
			get
			{
				if(r_RGenerateNavmesh_Vector3Array == null)
				{
					r_RGenerateNavmesh_Vector3Array = new(this, "GenerateNavmesh", 0, typeof(UnityEngine.Vector3).MakeArrayType());
					r_RGenerateNavmesh_Vector3Array.SetBelong(this.instance);
				}
				return r_RGenerateNavmesh_Vector3Array;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3[] BoundPoints(UnityEngine.Bounds)
		/// </summary>
		protected static RMethod r_RBoundPoints_Bounds;
		public static RMethod RBoundPoints_Bounds
		{
			get
			{
				if(r_RBoundPoints_Bounds == null)
				{
					r_RBoundPoints_Bounds = new(typeof(AstarPath), "BoundPoints", 0, typeof(UnityEngine.Bounds));
					r_RBoundPoints_Bounds.SetBelong(null);
				}
				return r_RBoundPoints_Bounds;
			}
		}

		/// <summary>
		/// Void SaveAstarData()
		/// </summary>
		protected RMethod r_RSaveAstarData;
		public virtual RMethod RSaveAstarData
		{
			get
			{
				if(r_RSaveAstarData == null)
				{
					r_RSaveAstarData = new(this, "SaveAstarData", 0);
					r_RSaveAstarData.SetBelong(this.instance);
				}
				return r_RSaveAstarData;
			}
		}

		/// <summary>
		/// Void LoadAstarData()
		/// </summary>
		protected RMethod r_RLoadAstarData;
		public virtual RMethod RLoadAstarData
		{
			get
			{
				if(r_RLoadAstarData == null)
				{
					r_RLoadAstarData = new(this, "LoadAstarData", 0);
					r_RLoadAstarData.SetBelong(this.instance);
				}
				return r_RLoadAstarData;
			}
		}

		/// <summary>
		/// Void LoadAstarData(GameDefineType.ID)
		/// </summary>
		protected RMethod r_RLoadAstarData_ID;
		public virtual RMethod RLoadAstarData_ID
		{
			get
			{
				if(r_RLoadAstarData_ID == null)
				{
					r_RLoadAstarData_ID = new(this, "LoadAstarData", 0, typeof(GameDefineType.ID));
					r_RLoadAstarData_ID.SetBelong(this.instance);
				}
				return r_RLoadAstarData_ID;
			}
		}

		/// <summary>
		/// Void OnAstarDataLoaded(System.Object, ABLoadedArgs)
		/// </summary>
		protected RMethod r_ROnAstarDataLoaded_Object_ABLoadedArgs;
		public virtual RMethod ROnAstarDataLoaded_Object_ABLoadedArgs
		{
			get
			{
				if(r_ROnAstarDataLoaded_Object_ABLoadedArgs == null)
				{
					r_ROnAstarDataLoaded_Object_ABLoadedArgs = new(this, "OnAstarDataLoaded", 0, typeof(System.Object),  ReleactionUtils.GetType("AssetBundleDownloader+ABLoadedArgs"));
					r_ROnAstarDataLoaded_Object_ABLoadedArgs.SetBelong(this.instance);
				}
				return r_ROnAstarDataLoaded_Object_ABLoadedArgs;
			}
		}

		/// <summary>
		/// Void Awake()
		/// </summary>
		protected RMethod r_RAwake;
		public virtual RMethod RAwake
		{
			get
			{
				if(r_RAwake == null)
				{
					r_RAwake = new(this, "Awake", 0);
					r_RAwake.SetBelong(this.instance);
				}
				return r_RAwake;
			}
		}

		/// <summary>
		/// Void RestSingleton()
		/// </summary>
		protected RMethod r_RRestSingleton;
		public virtual RMethod RRestSingleton
		{
			get
			{
				if(r_RRestSingleton == null)
				{
					r_RRestSingleton = new(this, "RestSingleton", 0);
					r_RRestSingleton.SetBelong(this.instance);
				}
				return r_RRestSingleton;
			}
		}

		/// <summary>
		/// Boolean IsInvoking()
		/// </summary>
		protected RMethod r_RIsInvoking;
		public virtual RMethod RIsInvoking
		{
			get
			{
				if(r_RIsInvoking == null)
				{
					r_RIsInvoking = new(this, "IsInvoking", 0);
					r_RIsInvoking.SetBelong(this.instance);
				}
				return r_RIsInvoking;
			}
		}

		/// <summary>
		/// Void CancelInvoke()
		/// </summary>
		protected RMethod r_RCancelInvoke;
		public virtual RMethod RCancelInvoke
		{
			get
			{
				if(r_RCancelInvoke == null)
				{
					r_RCancelInvoke = new(this, "CancelInvoke", 0);
					r_RCancelInvoke.SetBelong(this.instance);
				}
				return r_RCancelInvoke;
			}
		}

		/// <summary>
		/// Void Invoke(System.String, Single)
		/// </summary>
		protected RMethod r_RInvoke_String_Single;
		public virtual RMethod RInvoke_String_Single
		{
			get
			{
				if(r_RInvoke_String_Single == null)
				{
					r_RInvoke_String_Single = new(this, "Invoke", 0, typeof(System.String), typeof(System.Single));
					r_RInvoke_String_Single.SetBelong(this.instance);
				}
				return r_RInvoke_String_Single;
			}
		}

		/// <summary>
		/// Void InvokeRepeating(System.String, Single, Single)
		/// </summary>
		protected RMethod r_RInvokeRepeating_String_Single_Single;
		public virtual RMethod RInvokeRepeating_String_Single_Single
		{
			get
			{
				if(r_RInvokeRepeating_String_Single_Single == null)
				{
					r_RInvokeRepeating_String_Single_Single = new(this, "InvokeRepeating", 0, typeof(System.String), typeof(System.Single), typeof(System.Single));
					r_RInvokeRepeating_String_Single_Single.SetBelong(this.instance);
				}
				return r_RInvokeRepeating_String_Single_Single;
			}
		}

		/// <summary>
		/// Void CancelInvoke(System.String)
		/// </summary>
		protected RMethod r_RCancelInvoke_String;
		public virtual RMethod RCancelInvoke_String
		{
			get
			{
				if(r_RCancelInvoke_String == null)
				{
					r_RCancelInvoke_String = new(this, "CancelInvoke", 0, typeof(System.String));
					r_RCancelInvoke_String.SetBelong(this.instance);
				}
				return r_RCancelInvoke_String;
			}
		}

		/// <summary>
		/// Boolean IsInvoking(System.String)
		/// </summary>
		protected RMethod r_RIsInvoking_String;
		public virtual RMethod RIsInvoking_String
		{
			get
			{
				if(r_RIsInvoking_String == null)
				{
					r_RIsInvoking_String = new(this, "IsInvoking", 0, typeof(System.String));
					r_RIsInvoking_String.SetBelong(this.instance);
				}
				return r_RIsInvoking_String;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.String)
		/// </summary>
		protected RMethod r_RStartCoroutine_String;
		public virtual RMethod RStartCoroutine_String
		{
			get
			{
				if(r_RStartCoroutine_String == null)
				{
					r_RStartCoroutine_String = new(this, "StartCoroutine", 0, typeof(System.String));
					r_RStartCoroutine_String.SetBelong(this.instance);
				}
				return r_RStartCoroutine_String;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.String, System.Object)
		/// </summary>
		protected RMethod r_RStartCoroutine_String_Object;
		public virtual RMethod RStartCoroutine_String_Object
		{
			get
			{
				if(r_RStartCoroutine_String_Object == null)
				{
					r_RStartCoroutine_String_Object = new(this, "StartCoroutine", 0, typeof(System.String), typeof(System.Object));
					r_RStartCoroutine_String_Object.SetBelong(this.instance);
				}
				return r_RStartCoroutine_String_Object;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStartCoroutine_IEnumerator;
		public virtual RMethod RStartCoroutine_IEnumerator
		{
			get
			{
				if(r_RStartCoroutine_IEnumerator == null)
				{
					r_RStartCoroutine_IEnumerator = new(this, "StartCoroutine", 0, typeof(System.Collections.IEnumerator));
					r_RStartCoroutine_IEnumerator.SetBelong(this.instance);
				}
				return r_RStartCoroutine_IEnumerator;
			}
		}

		/// <summary>
		/// UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStartCoroutine_Auto_IEnumerator;
		public virtual RMethod RStartCoroutine_Auto_IEnumerator
		{
			get
			{
				if(r_RStartCoroutine_Auto_IEnumerator == null)
				{
					r_RStartCoroutine_Auto_IEnumerator = new(this, "StartCoroutine_Auto", 0, typeof(System.Collections.IEnumerator));
					r_RStartCoroutine_Auto_IEnumerator.SetBelong(this.instance);
				}
				return r_RStartCoroutine_Auto_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutine(System.Collections.IEnumerator)
		/// </summary>
		protected RMethod r_RStopCoroutine_IEnumerator;
		public virtual RMethod RStopCoroutine_IEnumerator
		{
			get
			{
				if(r_RStopCoroutine_IEnumerator == null)
				{
					r_RStopCoroutine_IEnumerator = new(this, "StopCoroutine", 0, typeof(System.Collections.IEnumerator));
					r_RStopCoroutine_IEnumerator.SetBelong(this.instance);
				}
				return r_RStopCoroutine_IEnumerator;
			}
		}

		/// <summary>
		/// Void StopCoroutine(UnityEngine.Coroutine)
		/// </summary>
		protected RMethod r_RStopCoroutine_Coroutine;
		public virtual RMethod RStopCoroutine_Coroutine
		{
			get
			{
				if(r_RStopCoroutine_Coroutine == null)
				{
					r_RStopCoroutine_Coroutine = new(this, "StopCoroutine", 0, typeof(UnityEngine.Coroutine));
					r_RStopCoroutine_Coroutine.SetBelong(this.instance);
				}
				return r_RStopCoroutine_Coroutine;
			}
		}

		/// <summary>
		/// Void StopCoroutine(System.String)
		/// </summary>
		protected RMethod r_RStopCoroutine_String;
		public virtual RMethod RStopCoroutine_String
		{
			get
			{
				if(r_RStopCoroutine_String == null)
				{
					r_RStopCoroutine_String = new(this, "StopCoroutine", 0, typeof(System.String));
					r_RStopCoroutine_String.SetBelong(this.instance);
				}
				return r_RStopCoroutine_String;
			}
		}

		/// <summary>
		/// Void StopAllCoroutines()
		/// </summary>
		protected RMethod r_RStopAllCoroutines;
		public virtual RMethod RStopAllCoroutines
		{
			get
			{
				if(r_RStopAllCoroutines == null)
				{
					r_RStopAllCoroutines = new(this, "StopAllCoroutines", 0);
					r_RStopAllCoroutines.SetBelong(this.instance);
				}
				return r_RStopAllCoroutines;
			}
		}

		/// <summary>
		/// System.String GetScriptClassName()
		/// </summary>
		protected RMethod r_RGetScriptClassName;
		public virtual RMethod RGetScriptClassName
		{
			get
			{
				if(r_RGetScriptClassName == null)
				{
					r_RGetScriptClassName = new(this, "GetScriptClassName", 0);
					r_RGetScriptClassName.SetBelong(this.instance);
				}
				return r_RGetScriptClassName;
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


        public RAstarPath() : base("AstarPath")
        {
        }

        public RAstarPath(System.Object instance) : base("AstarPath")
		{
            SetInstance(instance);
		}

        public RAstarPath(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RAstarPath(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void GenerateRotationMatrix(AstarClasses.Grid  @grid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@grid};
            var ___result = RGenerateRotationMatrix_Grid.Invoke(___genericsType, ___parameters);

            
        }


        public static void AddLogEntry(System.String  @message)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@message};
            var ___result = RAddLogEntry_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDrawGizmos()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDrawGizmos.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetUnwalkableNodeAmount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetUnwalkableNodeAmount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetWalkableNodeAmount()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWalkableNodeAmount.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public static System.Collections.IEnumerator CalculatePaths()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCalculatePaths.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void Start()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStart.Invoke(___genericsType, ___parameters);

            
        }


        public static AstarClasses.Int3 ToLocalTest(UnityEngine.Vector3  @pos, System.Boolean  @forceNodesUnder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @forceNodesUnder};
            var ___result = RToLocalTest_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Int3 ToLocalTest(UnityEngine.Vector3  @pos, System.Boolean  @forceNodesUnder, System.Boolean  @fullPhysicsCheck, UnityEngine.LayerMask  @collsion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @forceNodesUnder, @fullPhysicsCheck, @collsion};
            var ___result = RToLocalTest_Vector3_Boolean_Boolean_LayerMask.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Int3 ToLocalForce(UnityEngine.Vector3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RToLocalForce_Vector3.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Int3 ToLocalTest2(UnityEngine.Vector3  @pos, System.Boolean  @forceNodesUnder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @forceNodesUnder};
            var ___result = RToLocalTest2_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Int3 ToLocal(UnityEngine.Vector3  @Vpos, System.Int32  @gridIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Vpos, @gridIndex};
            var ___result = RToLocal_Vector3_Int32.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Int3 ToLocal(UnityEngine.Vector3  @Vpos, System.Int32  @gridIndex, System.Boolean  @forceNodesUnder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Vpos, @gridIndex, @forceNodesUnder};
            var ___result = RToLocal_Vector3_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Int3 ToLocal(UnityEngine.Vector3  @Vpos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Vpos};
            var ___result = RToLocal_Vector3.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Int3 ToLocal(UnityEngine.Vector3  @Vpos, System.Boolean  @forceNodesUnder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Vpos, @forceNodesUnder};
            var ___result = RToLocal_Vector3_Boolean.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Int3 ToLocal(UnityEngine.Vector3  @Vpos, System.Boolean  @forceNodesUnder, System.Boolean  @fullPhysicsCheck, UnityEngine.LayerMask  @collsion)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@Vpos, @forceNodesUnder, @fullPhysicsCheck, @collsion};
            var ___result = RToLocal_Vector3_Boolean_Boolean_LayerMask.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static System.Single ToLocalX(System.Single  @pos, System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @level};
            var ___result = RToLocalX_Single_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single ToLocalZ(System.Single  @pos, System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @level};
            var ___result = RToLocalZ_Single_Int32.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static AstarClasses.Int3 ToLocalUnclamped(UnityEngine.Vector3  @vPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@vPos};
            var ___result = RToLocalUnclamped_Vector3.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Int3)___result;
        }


        public static AstarClasses.Node GetNearest(AstarClasses.Node  @startNode, System.Boolean  @walkable)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startNode, @walkable};
            var ___result = RGetNearest_Node_Boolean.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node)___result;
        }


        public static AstarClasses.Node GetNearest(AstarClasses.Node  @startNode, System.Boolean  @walkable, System.Int32  @limit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startNode, @walkable, @limit};
            var ___result = RGetNearest_Node_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node)___result;
        }


        public static AstarClasses.Node GetNearest(AstarClasses.Node  @startNode, System.Boolean  @walkable, System.Int32  @area, System.Int32  @limit)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startNode, @walkable, @area, @limit};
            var ___result = RGetNearest_Node_Boolean_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node)___result;
        }


        public static AstarClasses.Node GetNode(AstarClasses.Int3  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RGetNode_Int3.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node)___result;
        }


        public static AstarClasses.Node GetNode(System.Int32  @x, System.Int32  @y, System.Int32  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @y, @z};
            var ___result = RGetNode_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node)___result;
        }


        public virtual System.Collections.IEnumerator SetNodes(System.Boolean  @walkable, UnityEngine.Bounds  @bounds, System.Boolean  @fullPhysicsCheck, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@walkable, @bounds, @fullPhysicsCheck, @t};
            var ___result = RSetNodes_Boolean_Bounds_Boolean_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual System.Collections.IEnumerator SetNodes(System.Boolean  @walkable, UnityEngine.Bounds  @bounds, System.Boolean  @fullPhysicsCheck, System.Boolean  @allGrids, System.Single  @t)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@walkable, @bounds, @fullPhysicsCheck, @allGrids, @t};
            var ___result = RSetNodes_Boolean_Bounds_Boolean_Boolean_Single.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void SetNodes(System.Boolean  @walkable, UnityEngine.Bounds  @bounds, System.Boolean  @fullPhysicsCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@walkable, @bounds, @fullPhysicsCheck};
            var ___result = RSetNodes_Boolean_Bounds_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNodes(System.Boolean  @walkable, UnityEngine.Vector3  @point, System.Int32  @gridIndex, System.Boolean  @allGrids)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@walkable, @point, @gridIndex, @allGrids};
            var ___result = RSetNodes_Boolean_Vector3_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNodes(System.Boolean  @walkable, UnityEngine.Bounds  @bounds, System.Boolean  @fullPhysicsCheck, System.Boolean  @allGrids)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@walkable, @bounds, @fullPhysicsCheck, @allGrids};
            var ___result = RSetNodes_Boolean_Bounds_Boolean_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNodesWorld(System.Boolean  @walkable, UnityEngine.Rect  @rect, System.Int32  @gridIndex, System.Boolean  @fullPhysicsCheck)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@walkable, @rect, @gridIndex, @fullPhysicsCheck};
            var ___result = RSetNodesWorld_Boolean_Rect_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetNodesLocal(System.Boolean  @walkable, System.Int32[]  @localRect, System.Int32  @gridIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@walkable, @localRect, @gridIndex};
            var ___result = RSetNodesLocal_Boolean_Int32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalculateArea(System.Int32[]  @localRect, System.Int32  @gridIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localRect, @gridIndex};
            var ___result = RRecalculateArea_Int32Array_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RecalcNeighbours(AstarClasses.Node  @node)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node};
            var ___result = RRecalcNeighbours_Node.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FullPhysicsCheck(AstarClasses.Node  @node, AstarClasses.Grid  @grid)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @grid};
            var ___result = RFullPhysicsCheck_Node_Grid.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FullPhysicsCheck(AstarClasses.Node  @node, AstarClasses.Grid  @grid, UnityEngine.LayerMask  @extraMask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @grid, @extraMask};
            var ___result = RFullPhysicsCheck_Node_Grid_LayerMask.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FullPhysicsCheck(AstarClasses.Node  @node, AstarClasses.Grid  @grid, UnityEngine.LayerMask  @extraMask, System.Boolean  @doYTest)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @grid, @extraMask, @doYTest};
            var ___result = RFullPhysicsCheck_Node_Grid_LayerMask_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public static System.Boolean CheckLine(UnityEngine.Vector3  @from, UnityEngine.Vector3  @to, System.Single  @maxAngle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @maxAngle};
            var ___result = RCheckLine_Vector3_Vector3_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean CheckLine(AstarClasses.Node  @from, AstarClasses.Node  @to, System.Single  @maxAngle)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @maxAngle};
            var ___result = RCheckLine_Node_Node_Single.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Single CheckLineDetailed(UnityEngine.Vector3  @from, UnityEngine.Vector3  @to, System.Single  @maxAngle, System.Boolean  @returnWorldUnits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @maxAngle, @returnWorldUnits};
            var ___result = RCheckLineDetailed_Vector3_Vector3_Single_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public static System.Single CheckLineDetailed(AstarClasses.Node  @from, AstarClasses.Node  @to, System.Single  @maxAngle, System.Boolean  @returnWorldUnits)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@from, @to, @maxAngle, @returnWorldUnits};
            var ___result = RCheckLineDetailed_Node_Node_Single_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual void FloodFill(AstarClasses.Node  @node, System.Int32  @areaTimeStamp)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @areaTimeStamp};
            var ___result = RFloodFill_Node_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FloodFillAll()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFloodFillAll.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Scan()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScan.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Scan(System.Boolean  @calcAll, System.Int32  @pass)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calcAll, @pass};
            var ___result = RScan_Boolean_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScanTexture()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScanTexture.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean TextureEvaluateNode(System.Int32  @x, System.Int32  @z)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@x, @z};
            var ___result = RTextureEvaluateNode_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ScanTilemap(System.Boolean[]  @array, System.Int32  @width, System.Int32  @depth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @width, @depth};
            var ___result = RScanTilemap_BooleanArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScanBounds()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScanBounds.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScanNavmesh()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScanNavmesh.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScanNavmeshEdge()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScanNavmeshEdge.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScanNavmeshCenter()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScanNavmeshCenter.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScanList()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScanList.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ScanQuadtree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RScanQuadtree.Invoke(___genericsType, ___parameters);

            
        }


        public virtual AstarClasses.Node[] GetSurroundingNodes(AstarClasses.Node  @node, System.Int32  @log)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @log};
            var ___result = RGetSurroundingNodes_Node_Int32.Invoke(___genericsType, ___parameters);

            return (AstarClasses.Node[])___result;
        }


        public virtual System.Int32 IsSingleArea(AstarClasses.Node  @node, System.Int32  @w, System.Boolean  @adjustY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @w, @adjustY};
            var ___result = RIsSingleArea_Node_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void FillWithNode(AstarClasses.Node  @node, AstarClasses.Int3  @pos, System.Int32  @w)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@node, @pos, @w};
            var ___result = RFillWithNode_Node_Int3_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.Transform[] GetChildren(UnityEngine.Transform  @parent)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parent};
            var ___result = RGetChildren_Transform.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Transform[])___result;
        }


        public virtual void CreateGrid(AstarClasses.SimpleNode[]  @nodes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nodes};
            var ___result = RCreateGrid_SimpleNodeArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CreateGrid(AstarClasses.SimpleNode[][]  @nodes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nodes};
            var ___result = RCreateGrid_SimpleNodeArrayArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyEnablerLinks()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyEnablerLinks.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ApplyLinks()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApplyLinks.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void GenerateNavmesh(UnityEngine.Vector3[]  @points)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@points};
            var ___result = RGenerateNavmesh_Vector3Array.Invoke(___genericsType, ___parameters);

            
        }


        public static UnityEngine.Vector3[] BoundPoints(UnityEngine.Bounds  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@b};
            var ___result = RBoundPoints_Bounds.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Vector3[])___result;
        }


        public virtual void SaveAstarData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSaveAstarData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadAstarData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RLoadAstarData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void LoadAstarData(GameDefineType.ID  @sceneID)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sceneID};
            var ___result = RLoadAstarData_ID.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Awake()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAwake.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void RestSingleton()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRestSingleton.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsInvoking()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsInvoking.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void CancelInvoke()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCancelInvoke.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Invoke(System.String  @methodName, System.Single  @time)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @time};
            var ___result = RInvoke_String_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InvokeRepeating(System.String  @methodName, System.Single  @time, System.Single  @repeatRate)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @time, @repeatRate};
            var ___result = RInvokeRepeating_String_Single_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CancelInvoke(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCancelInvoke_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsInvoking(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RIsInvoking_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RStartCoroutine_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.String  @methodName, System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName, @value};
            var ___result = RStartCoroutine_String_Object.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStartCoroutine_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStartCoroutine_Auto_IEnumerator.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Coroutine)___result;
        }


        public virtual void StopCoroutine(System.Collections.IEnumerator  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutine_IEnumerator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutine(UnityEngine.Coroutine  @routine)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@routine};
            var ___result = RStopCoroutine_Coroutine.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopCoroutine(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RStopCoroutine_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void StopAllCoroutines()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RStopAllCoroutines.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetScriptClassName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetScriptClassName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
