using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.DetailPrototype
	/// </summary>
    public partial class RDetailPrototype : RMember //
    {

		/// <summary>
		/// UnityEngine.Color DefaultHealthColor
		/// </summary>
		protected static RUnityEngine.RColor r_DefaultHealthColor;
		public static RUnityEngine.RColor RDefaultHealthColor
		{
			get
			{
				if(r_DefaultHealthColor == null)
				{
					r_DefaultHealthColor = new(typeof(UnityEngine.DetailPrototype), "DefaultHealthColor");
					r_DefaultHealthColor.SetBelong(null);
				}
				return r_DefaultHealthColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color DefaultDryColor
		/// </summary>
		protected static RUnityEngine.RColor r_DefaultDryColor;
		public static RUnityEngine.RColor RDefaultDryColor
		{
			get
			{
				if(r_DefaultDryColor == null)
				{
					r_DefaultDryColor = new(typeof(UnityEngine.DetailPrototype), "DefaultDryColor");
					r_DefaultDryColor.SetBelong(null);
				}
				return r_DefaultDryColor;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject m_Prototype
		/// </summary>
		protected RUnityEngine.RGameObject r_m_Prototype;
		public virtual RUnityEngine.RGameObject Rm_Prototype
		{
			get
			{
				if(r_m_Prototype == null)
				{
					r_m_Prototype = new(this, "m_Prototype");
					r_m_Prototype.SetBelong(this.instance);
				}
				return r_m_Prototype;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D m_PrototypeTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_m_PrototypeTexture;
		public virtual RUnityEngine.RTexture2D Rm_PrototypeTexture
		{
			get
			{
				if(r_m_PrototypeTexture == null)
				{
					r_m_PrototypeTexture = new(this, "m_PrototypeTexture");
					r_m_PrototypeTexture.SetBelong(this.instance);
				}
				return r_m_PrototypeTexture;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_HealthyColor
		/// </summary>
		protected RUnityEngine.RColor r_m_HealthyColor;
		public virtual RUnityEngine.RColor Rm_HealthyColor
		{
			get
			{
				if(r_m_HealthyColor == null)
				{
					r_m_HealthyColor = new(this, "m_HealthyColor");
					r_m_HealthyColor.SetBelong(this.instance);
				}
				return r_m_HealthyColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_DryColor
		/// </summary>
		protected RUnityEngine.RColor r_m_DryColor;
		public virtual RUnityEngine.RColor Rm_DryColor
		{
			get
			{
				if(r_m_DryColor == null)
				{
					r_m_DryColor = new(this, "m_DryColor");
					r_m_DryColor.SetBelong(this.instance);
				}
				return r_m_DryColor;
			}
		}

		/// <summary>
		/// System.Single m_MinWidth
		/// </summary>
		protected RField r_m_MinWidth;
		public virtual RField Rm_MinWidth
		{
			get
			{
				if(r_m_MinWidth == null)
				{
					r_m_MinWidth = new(this, "m_MinWidth");
					r_m_MinWidth.SetBelong(this.instance);
				}
				return r_m_MinWidth;
			}
		}

		/// <summary>
		/// System.Single m_MaxWidth
		/// </summary>
		protected RField r_m_MaxWidth;
		public virtual RField Rm_MaxWidth
		{
			get
			{
				if(r_m_MaxWidth == null)
				{
					r_m_MaxWidth = new(this, "m_MaxWidth");
					r_m_MaxWidth.SetBelong(this.instance);
				}
				return r_m_MaxWidth;
			}
		}

		/// <summary>
		/// System.Single m_MinHeight
		/// </summary>
		protected RField r_m_MinHeight;
		public virtual RField Rm_MinHeight
		{
			get
			{
				if(r_m_MinHeight == null)
				{
					r_m_MinHeight = new(this, "m_MinHeight");
					r_m_MinHeight.SetBelong(this.instance);
				}
				return r_m_MinHeight;
			}
		}

		/// <summary>
		/// System.Single m_MaxHeight
		/// </summary>
		protected RField r_m_MaxHeight;
		public virtual RField Rm_MaxHeight
		{
			get
			{
				if(r_m_MaxHeight == null)
				{
					r_m_MaxHeight = new(this, "m_MaxHeight");
					r_m_MaxHeight.SetBelong(this.instance);
				}
				return r_m_MaxHeight;
			}
		}

		/// <summary>
		/// System.Int32 m_NoiseSeed
		/// </summary>
		protected RField r_m_NoiseSeed;
		public virtual RField Rm_NoiseSeed
		{
			get
			{
				if(r_m_NoiseSeed == null)
				{
					r_m_NoiseSeed = new(this, "m_NoiseSeed");
					r_m_NoiseSeed.SetBelong(this.instance);
				}
				return r_m_NoiseSeed;
			}
		}

		/// <summary>
		/// System.Single m_NoiseSpread
		/// </summary>
		protected RField r_m_NoiseSpread;
		public virtual RField Rm_NoiseSpread
		{
			get
			{
				if(r_m_NoiseSpread == null)
				{
					r_m_NoiseSpread = new(this, "m_NoiseSpread");
					r_m_NoiseSpread.SetBelong(this.instance);
				}
				return r_m_NoiseSpread;
			}
		}

		/// <summary>
		/// System.Single m_Density
		/// </summary>
		protected RField r_m_Density;
		public virtual RField Rm_Density
		{
			get
			{
				if(r_m_Density == null)
				{
					r_m_Density = new(this, "m_Density");
					r_m_Density.SetBelong(this.instance);
				}
				return r_m_Density;
			}
		}

		/// <summary>
		/// System.Single m_HoleEdgePadding
		/// </summary>
		protected RField r_m_HoleEdgePadding;
		public virtual RField Rm_HoleEdgePadding
		{
			get
			{
				if(r_m_HoleEdgePadding == null)
				{
					r_m_HoleEdgePadding = new(this, "m_HoleEdgePadding");
					r_m_HoleEdgePadding.SetBelong(this.instance);
				}
				return r_m_HoleEdgePadding;
			}
		}

		/// <summary>
		/// System.Int32 m_RenderMode
		/// </summary>
		protected RField r_m_RenderMode;
		public virtual RField Rm_RenderMode
		{
			get
			{
				if(r_m_RenderMode == null)
				{
					r_m_RenderMode = new(this, "m_RenderMode");
					r_m_RenderMode.SetBelong(this.instance);
				}
				return r_m_RenderMode;
			}
		}

		/// <summary>
		/// System.Int32 m_UsePrototypeMesh
		/// </summary>
		protected RField r_m_UsePrototypeMesh;
		public virtual RField Rm_UsePrototypeMesh
		{
			get
			{
				if(r_m_UsePrototypeMesh == null)
				{
					r_m_UsePrototypeMesh = new(this, "m_UsePrototypeMesh");
					r_m_UsePrototypeMesh.SetBelong(this.instance);
				}
				return r_m_UsePrototypeMesh;
			}
		}

		/// <summary>
		/// System.Int32 m_UseInstancing
		/// </summary>
		protected RField r_m_UseInstancing;
		public virtual RField Rm_UseInstancing
		{
			get
			{
				if(r_m_UseInstancing == null)
				{
					r_m_UseInstancing = new(this, "m_UseInstancing");
					r_m_UseInstancing.SetBelong(this.instance);
				}
				return r_m_UseInstancing;
			}
		}

		/// <summary>
		/// System.Int32 m_UseDensityScaling
		/// </summary>
		protected RField r_m_UseDensityScaling;
		public virtual RField Rm_UseDensityScaling
		{
			get
			{
				if(r_m_UseDensityScaling == null)
				{
					r_m_UseDensityScaling = new(this, "m_UseDensityScaling");
					r_m_UseDensityScaling.SetBelong(this.instance);
				}
				return r_m_UseDensityScaling;
			}
		}

		/// <summary>
		/// System.Single m_AlignToGround
		/// </summary>
		protected RField r_m_AlignToGround;
		public virtual RField Rm_AlignToGround
		{
			get
			{
				if(r_m_AlignToGround == null)
				{
					r_m_AlignToGround = new(this, "m_AlignToGround");
					r_m_AlignToGround.SetBelong(this.instance);
				}
				return r_m_AlignToGround;
			}
		}

		/// <summary>
		/// System.Single m_PositionJitter
		/// </summary>
		protected RField r_m_PositionJitter;
		public virtual RField Rm_PositionJitter
		{
			get
			{
				if(r_m_PositionJitter == null)
				{
					r_m_PositionJitter = new(this, "m_PositionJitter");
					r_m_PositionJitter.SetBelong(this.instance);
				}
				return r_m_PositionJitter;
			}
		}

		/// <summary>
		/// System.Single m_TargetCoverage
		/// </summary>
		protected RField r_m_TargetCoverage;
		public virtual RField Rm_TargetCoverage
		{
			get
			{
				if(r_m_TargetCoverage == null)
				{
					r_m_TargetCoverage = new(this, "m_TargetCoverage");
					r_m_TargetCoverage.SetBelong(this.instance);
				}
				return r_m_TargetCoverage;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject prototype
		/// </summary>
		protected RUnityEngine.RGameObject r_prototype;
		public virtual RUnityEngine.RGameObject Rprototype
		{
			get
			{
				if(r_prototype == null)
				{
					r_prototype = new(this, "prototype", -1);
					r_prototype.SetBelong(this.instance);
				}
				return r_prototype;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D prototypeTexture
		/// </summary>
		protected RUnityEngine.RTexture2D r_prototypeTexture;
		public virtual RUnityEngine.RTexture2D RprototypeTexture
		{
			get
			{
				if(r_prototypeTexture == null)
				{
					r_prototypeTexture = new(this, "prototypeTexture", -1);
					r_prototypeTexture.SetBelong(this.instance);
				}
				return r_prototypeTexture;
			}
		}

		/// <summary>
		/// Single minWidth
		/// </summary>
		protected RProperty r_minWidth;
		public virtual RProperty RminWidth
		{
			get
			{
				if(r_minWidth == null)
				{
					r_minWidth = new(this, "minWidth", -1);
					r_minWidth.SetBelong(this.instance);
				}
				return r_minWidth;
			}
		}

		/// <summary>
		/// Single maxWidth
		/// </summary>
		protected RProperty r_maxWidth;
		public virtual RProperty RmaxWidth
		{
			get
			{
				if(r_maxWidth == null)
				{
					r_maxWidth = new(this, "maxWidth", -1);
					r_maxWidth.SetBelong(this.instance);
				}
				return r_maxWidth;
			}
		}

		/// <summary>
		/// Single minHeight
		/// </summary>
		protected RProperty r_minHeight;
		public virtual RProperty RminHeight
		{
			get
			{
				if(r_minHeight == null)
				{
					r_minHeight = new(this, "minHeight", -1);
					r_minHeight.SetBelong(this.instance);
				}
				return r_minHeight;
			}
		}

		/// <summary>
		/// Single maxHeight
		/// </summary>
		protected RProperty r_maxHeight;
		public virtual RProperty RmaxHeight
		{
			get
			{
				if(r_maxHeight == null)
				{
					r_maxHeight = new(this, "maxHeight", -1);
					r_maxHeight.SetBelong(this.instance);
				}
				return r_maxHeight;
			}
		}

		/// <summary>
		/// Int32 noiseSeed
		/// </summary>
		protected RProperty r_noiseSeed;
		public virtual RProperty RnoiseSeed
		{
			get
			{
				if(r_noiseSeed == null)
				{
					r_noiseSeed = new(this, "noiseSeed", -1);
					r_noiseSeed.SetBelong(this.instance);
				}
				return r_noiseSeed;
			}
		}

		/// <summary>
		/// Single noiseSpread
		/// </summary>
		protected RProperty r_noiseSpread;
		public virtual RProperty RnoiseSpread
		{
			get
			{
				if(r_noiseSpread == null)
				{
					r_noiseSpread = new(this, "noiseSpread", -1);
					r_noiseSpread.SetBelong(this.instance);
				}
				return r_noiseSpread;
			}
		}

		/// <summary>
		/// Single density
		/// </summary>
		protected RProperty r_density;
		public virtual RProperty Rdensity
		{
			get
			{
				if(r_density == null)
				{
					r_density = new(this, "density", -1);
					r_density.SetBelong(this.instance);
				}
				return r_density;
			}
		}

		/// <summary>
		/// Single bendFactor
		/// </summary>
		protected RProperty r_bendFactor;
		public virtual RProperty RbendFactor
		{
			get
			{
				if(r_bendFactor == null)
				{
					r_bendFactor = new(this, "bendFactor", -1);
					r_bendFactor.SetBelong(this.instance);
				}
				return r_bendFactor;
			}
		}

		/// <summary>
		/// Single holeEdgePadding
		/// </summary>
		protected RProperty r_holeEdgePadding;
		public virtual RProperty RholeEdgePadding
		{
			get
			{
				if(r_holeEdgePadding == null)
				{
					r_holeEdgePadding = new(this, "holeEdgePadding", -1);
					r_holeEdgePadding.SetBelong(this.instance);
				}
				return r_holeEdgePadding;
			}
		}

		/// <summary>
		/// UnityEngine.Color healthyColor
		/// </summary>
		protected RUnityEngine.RColor r_healthyColor;
		public virtual RUnityEngine.RColor RhealthyColor
		{
			get
			{
				if(r_healthyColor == null)
				{
					r_healthyColor = new(this, "healthyColor", -1);
					r_healthyColor.SetBelong(this.instance);
				}
				return r_healthyColor;
			}
		}

		/// <summary>
		/// UnityEngine.Color dryColor
		/// </summary>
		protected RUnityEngine.RColor r_dryColor;
		public virtual RUnityEngine.RColor RdryColor
		{
			get
			{
				if(r_dryColor == null)
				{
					r_dryColor = new(this, "dryColor", -1);
					r_dryColor.SetBelong(this.instance);
				}
				return r_dryColor;
			}
		}

		/// <summary>
		/// UnityEngine.DetailRenderMode renderMode
		/// </summary>
		protected RProperty r_renderMode;
		public virtual RProperty RrenderMode
		{
			get
			{
				if(r_renderMode == null)
				{
					r_renderMode = new(this, "renderMode", -1);
					r_renderMode.SetBelong(this.instance);
				}
				return r_renderMode;
			}
		}

		/// <summary>
		/// Boolean usePrototypeMesh
		/// </summary>
		protected RProperty r_usePrototypeMesh;
		public virtual RProperty RusePrototypeMesh
		{
			get
			{
				if(r_usePrototypeMesh == null)
				{
					r_usePrototypeMesh = new(this, "usePrototypeMesh", -1);
					r_usePrototypeMesh.SetBelong(this.instance);
				}
				return r_usePrototypeMesh;
			}
		}

		/// <summary>
		/// Boolean useInstancing
		/// </summary>
		protected RProperty r_useInstancing;
		public virtual RProperty RuseInstancing
		{
			get
			{
				if(r_useInstancing == null)
				{
					r_useInstancing = new(this, "useInstancing", -1);
					r_useInstancing.SetBelong(this.instance);
				}
				return r_useInstancing;
			}
		}

		/// <summary>
		/// Single targetCoverage
		/// </summary>
		protected RProperty r_targetCoverage;
		public virtual RProperty RtargetCoverage
		{
			get
			{
				if(r_targetCoverage == null)
				{
					r_targetCoverage = new(this, "targetCoverage", -1);
					r_targetCoverage.SetBelong(this.instance);
				}
				return r_targetCoverage;
			}
		}

		/// <summary>
		/// Boolean useDensityScaling
		/// </summary>
		protected RProperty r_useDensityScaling;
		public virtual RProperty RuseDensityScaling
		{
			get
			{
				if(r_useDensityScaling == null)
				{
					r_useDensityScaling = new(this, "useDensityScaling", -1);
					r_useDensityScaling.SetBelong(this.instance);
				}
				return r_useDensityScaling;
			}
		}

		/// <summary>
		/// Single alignToGround
		/// </summary>
		protected RProperty r_alignToGround;
		public virtual RProperty RalignToGround
		{
			get
			{
				if(r_alignToGround == null)
				{
					r_alignToGround = new(this, "alignToGround", -1);
					r_alignToGround.SetBelong(this.instance);
				}
				return r_alignToGround;
			}
		}

		/// <summary>
		/// Single positionJitter
		/// </summary>
		protected RProperty r_positionJitter;
		public virtual RProperty RpositionJitter
		{
			get
			{
				if(r_positionJitter == null)
				{
					r_positionJitter = new(this, "positionJitter", -1);
					r_positionJitter.SetBelong(this.instance);
				}
				return r_positionJitter;
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
		/// Boolean Equals(UnityEngine.DetailPrototype)
		/// </summary>
		protected RMethod r_REquals_DetailPrototype;
		public virtual RMethod REquals_DetailPrototype
		{
			get
			{
				if(r_REquals_DetailPrototype == null)
				{
					r_REquals_DetailPrototype = new(this, "Equals", 0, typeof(UnityEngine.DetailPrototype));
					r_REquals_DetailPrototype.SetBelong(this.instance);
				}
				return r_REquals_DetailPrototype;
			}
		}

		/// <summary>
		/// Boolean Validate()
		/// </summary>
		protected RMethod r_RValidate;
		public virtual RMethod RValidate
		{
			get
			{
				if(r_RValidate == null)
				{
					r_RValidate = new(this, "Validate", 0);
					r_RValidate.SetBelong(this.instance);
				}
				return r_RValidate;
			}
		}

		/// <summary>
		/// Boolean Validate(System.String ByRef)
		/// </summary>
		protected RMethod r_RValidate_Out_String;
		public virtual RMethod RValidate_Out_String
		{
			get
			{
				if(r_RValidate_Out_String == null)
				{
					r_RValidate_Out_String = new(this, "Validate", 0, typeof(System.String).MakeByRefType());
					r_RValidate_Out_String.SetBelong(this.instance);
				}
				return r_RValidate_Out_String;
			}
		}

		/// <summary>
		/// Boolean ValidateDetailPrototype(UnityEngine.DetailPrototype, System.String ByRef)
		/// </summary>
		protected static RMethod r_RValidateDetailPrototype_DetailPrototype_Out_String;
		public static RMethod RValidateDetailPrototype_DetailPrototype_Out_String
		{
			get
			{
				if(r_RValidateDetailPrototype_DetailPrototype_Out_String == null)
				{
					r_RValidateDetailPrototype_DetailPrototype_Out_String = new(typeof(UnityEngine.DetailPrototype), "ValidateDetailPrototype", 0, typeof(UnityEngine.DetailPrototype), typeof(System.String).MakeByRefType());
					r_RValidateDetailPrototype_DetailPrototype_Out_String.SetBelong(null);
				}
				return r_RValidateDetailPrototype_DetailPrototype_Out_String;
			}
		}

		/// <summary>
		/// Boolean IsModeSupportedByRenderPipeline(UnityEngine.DetailRenderMode, Boolean, System.String ByRef)
		/// </summary>
		protected static RMethod r_RIsModeSupportedByRenderPipeline_DetailRenderMode_Boolean_Out_String;
		public static RMethod RIsModeSupportedByRenderPipeline_DetailRenderMode_Boolean_Out_String
		{
			get
			{
				if(r_RIsModeSupportedByRenderPipeline_DetailRenderMode_Boolean_Out_String == null)
				{
					r_RIsModeSupportedByRenderPipeline_DetailRenderMode_Boolean_Out_String = new(typeof(UnityEngine.DetailPrototype), "IsModeSupportedByRenderPipeline", 0, typeof(UnityEngine.DetailRenderMode), typeof(System.Boolean), typeof(System.String).MakeByRefType());
					r_RIsModeSupportedByRenderPipeline_DetailRenderMode_Boolean_Out_String.SetBelong(null);
				}
				return r_RIsModeSupportedByRenderPipeline_DetailRenderMode_Boolean_Out_String;
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


        public RDetailPrototype() : base("UnityEngine.DetailPrototype")
        {
        }

        public RDetailPrototype(System.Object instance) : base("UnityEngine.DetailPrototype")
		{
            SetInstance(instance);
		}

        public RDetailPrototype(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RDetailPrototype(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(UnityEngine.DetailPrototype  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_DetailPrototype.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Validate()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RValidate.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Validate(out System.String  @errorMessage)
        {
			errorMessage = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@errorMessage};
            var ___result = RValidate_Out_String.Invoke(___genericsType, ___parameters);
			errorMessage = (System.String)___parameters[0];

            return (System.Boolean)___result;
        }


        public static System.Boolean ValidateDetailPrototype(UnityEngine.DetailPrototype  @prototype, out System.String  @errorMessage)
        {
			errorMessage = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prototype, @errorMessage};
            var ___result = RValidateDetailPrototype_DetailPrototype_Out_String.Invoke(___genericsType, ___parameters);
			errorMessage = (System.String)___parameters[1];

            return (System.Boolean)___result;
        }


        public static System.Boolean IsModeSupportedByRenderPipeline(UnityEngine.DetailRenderMode  @renderMode, System.Boolean  @useInstancing, out System.String  @errorMessage)
        {
			errorMessage = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@renderMode, @useInstancing, @errorMessage};
            var ___result = RIsModeSupportedByRenderPipeline_DetailRenderMode_Boolean_Out_String.Invoke(___genericsType, ___parameters);
			errorMessage = (System.String)___parameters[2];

            return (System.Boolean)___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
