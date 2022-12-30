using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieClip
	/// </summary>
    public partial class RSceneMovieClip : RMember //
    {

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RField r_Name;
		public virtual RField RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name");
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.String SceneID
		/// </summary>
		protected RField r_SceneID;
		public virtual RField RSceneID
		{
			get
			{
				if(r_SceneID == null)
				{
					r_SceneID = new(this, "SceneID");
					r_SceneID.SetBelong(this.instance);
				}
				return r_SceneID;
			}
		}

		/// <summary>
		/// System.String career
		/// </summary>
		protected RField r_career;
		public virtual RField Rcareer
		{
			get
			{
				if(r_career == null)
				{
					r_career = new(this, "career");
					r_career.SetBelong(this.instance);
				}
				return r_career;
			}
		}

		/// <summary>
		/// System.Boolean escape
		/// </summary>
		protected RField r_escape;
		public virtual RField Rescape
		{
			get
			{
				if(r_escape == null)
				{
					r_escape = new(this, "escape");
					r_escape.SetBelong(this.instance);
				}
				return r_escape;
			}
		}

		/// <summary>
		/// System.Boolean bOtherShow
		/// </summary>
		protected RField r_bOtherShow;
		public virtual RField RbOtherShow
		{
			get
			{
				if(r_bOtherShow == null)
				{
					r_bOtherShow = new(this, "bOtherShow");
					r_bOtherShow.SetBelong(this.instance);
				}
				return r_bOtherShow;
			}
		}

		/// <summary>
		/// System.Boolean bNpcShow
		/// </summary>
		protected RField r_bNpcShow;
		public virtual RField RbNpcShow
		{
			get
			{
				if(r_bNpcShow == null)
				{
					r_bNpcShow = new(this, "bNpcShow");
					r_bNpcShow.SetBelong(this.instance);
				}
				return r_bNpcShow;
			}
		}

		/// <summary>
		/// System.Boolean bUIShow
		/// </summary>
		protected RField r_bUIShow;
		public virtual RField RbUIShow
		{
			get
			{
				if(r_bUIShow == null)
				{
					r_bUIShow = new(this, "bUIShow");
					r_bUIShow.SetBelong(this.instance);
				}
				return r_bUIShow;
			}
		}

		/// <summary>
		/// System.Boolean bRestoreBGM
		/// </summary>
		protected RField r_bRestoreBGM;
		public virtual RField RbRestoreBGM
		{
			get
			{
				if(r_bRestoreBGM == null)
				{
					r_bRestoreBGM = new(this, "bRestoreBGM");
					r_bRestoreBGM.SetBelong(this.instance);
				}
				return r_bRestoreBGM;
			}
		}

		/// <summary>
		/// System.Boolean bDLBattleRes
		/// </summary>
		protected RField r_bDLBattleRes;
		public virtual RField RbDLBattleRes
		{
			get
			{
				if(r_bDLBattleRes == null)
				{
					r_bDLBattleRes = new(this, "bDLBattleRes");
					r_bDLBattleRes.SetBelong(this.instance);
				}
				return r_bDLBattleRes;
			}
		}

		/// <summary>
		/// System.Boolean bEndFadeIn
		/// </summary>
		protected RField r_bEndFadeIn;
		public virtual RField RbEndFadeIn
		{
			get
			{
				if(r_bEndFadeIn == null)
				{
					r_bEndFadeIn = new(this, "bEndFadeIn");
					r_bEndFadeIn.SetBelong(this.instance);
				}
				return r_bEndFadeIn;
			}
		}

		/// <summary>
		/// System.Boolean bNeedFog
		/// </summary>
		protected RField r_bNeedFog;
		public virtual RField RbNeedFog
		{
			get
			{
				if(r_bNeedFog == null)
				{
					r_bNeedFog = new(this, "bNeedFog");
					r_bNeedFog.SetBelong(this.instance);
				}
				return r_bNeedFog;
			}
		}

		/// <summary>
		/// System.Int32 fieldofview
		/// </summary>
		protected RField r_fieldofview;
		public virtual RField Rfieldofview
		{
			get
			{
				if(r_fieldofview == null)
				{
					r_fieldofview = new(this, "fieldofview");
					r_fieldofview.SetBelong(this.instance);
				}
				return r_fieldofview;
			}
		}

		/// <summary>
		/// System.Single farClip
		/// </summary>
		protected RField r_farClip;
		public virtual RField RfarClip
		{
			get
			{
				if(r_farClip == null)
				{
					r_farClip = new(this, "farClip");
					r_farClip.SetBelong(this.instance);
				}
				return r_farClip;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[SceneMovieAssetStruct] mAssetFiles
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSceneMovieAssetStruct> r_mAssetFiles;
		public virtual RSystem.RCollections.RGeneric.RList<RSceneMovieAssetStruct> RmAssetFiles
		{
			get
			{
				if(r_mAssetFiles == null)
				{
					r_mAssetFiles = new(this, "mAssetFiles");
					r_mAssetFiles.SetBelong(this.instance);
				}
				return r_mAssetFiles;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[SceneMovieCommand] mCmdList
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RSceneMovieCommand> r_mCmdList;
		public virtual RSystem.RCollections.RGeneric.RList<RSceneMovieCommand> RmCmdList
		{
			get
			{
				if(r_mCmdList == null)
				{
					r_mCmdList = new(this, "mCmdList");
					r_mCmdList.SetBelong(this.instance);
				}
				return r_mCmdList;
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


        public RSceneMovieClip() : base("SceneMovieClip")
        {
        }

        public RSceneMovieClip(System.Object instance) : base("SceneMovieClip")
		{
            SetInstance(instance);
		}

        public RSceneMovieClip(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieClip(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
