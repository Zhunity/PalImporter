using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SceneMovieCommand
	/// </summary>
    public partial class RSceneMovieCommand : RMember //
    {

		/// <summary>
		/// System.String CommandName
		/// </summary>
		protected RField r_CommandName;
		public virtual RField RCommandName
		{
			get
			{
				if(r_CommandName == null)
				{
					r_CommandName = new(this, "CommandName");
					r_CommandName.SetBelong(this.instance);
				}
				return r_CommandName;
			}
		}

		/// <summary>
		/// System.Boolean Wait
		/// </summary>
		protected RField r_Wait;
		public virtual RField RWait
		{
			get
			{
				if(r_Wait == null)
				{
					r_Wait = new(this, "Wait");
					r_Wait.SetBelong(this.instance);
				}
				return r_Wait;
			}
		}

		/// <summary>
		/// System.Single EndWaitTime
		/// </summary>
		protected RField r_EndWaitTime;
		public virtual RField REndWaitTime
		{
			get
			{
				if(r_EndWaitTime == null)
				{
					r_EndWaitTime = new(this, "EndWaitTime");
					r_EndWaitTime.SetBelong(this.instance);
				}
				return r_EndWaitTime;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// SceneMovieCmdType mType
		/// </summary>
		protected RField r_mType;
		public virtual RField RmType
		{
			get
			{
				if(r_mType == null)
				{
					r_mType = new(this, "mType");
					r_mType.SetBelong(this.instance);
				}
				return r_mType;
			}
		}

		/// <summary>
		/// SceneMovieWaiting m_CmdWait
		/// </summary>
		protected RSceneMovieWaiting r_m_CmdWait;
		public virtual RSceneMovieWaiting Rm_CmdWait
		{
			get
			{
				if(r_m_CmdWait == null)
				{
					r_m_CmdWait = new(this, "m_CmdWait");
					r_m_CmdWait.SetBelong(this.instance);
				}
				return r_m_CmdWait;
			}
		}

		/// <summary>
		/// SceneMovieDialogCmd m_CmdDialog
		/// </summary>
		protected RSceneMovieDialogCmd r_m_CmdDialog;
		public virtual RSceneMovieDialogCmd Rm_CmdDialog
		{
			get
			{
				if(r_m_CmdDialog == null)
				{
					r_m_CmdDialog = new(this, "m_CmdDialog");
					r_m_CmdDialog.SetBelong(this.instance);
				}
				return r_m_CmdDialog;
			}
		}

		/// <summary>
		/// SceneMovieCameraCmd m_CmdCamera
		/// </summary>
		protected RSceneMovieCameraCmd r_m_CmdCamera;
		public virtual RSceneMovieCameraCmd Rm_CmdCamera
		{
			get
			{
				if(r_m_CmdCamera == null)
				{
					r_m_CmdCamera = new(this, "m_CmdCamera");
					r_m_CmdCamera.SetBelong(this.instance);
				}
				return r_m_CmdCamera;
			}
		}

		/// <summary>
		/// SceneMovieMusicCmd m_CmdMusic
		/// </summary>
		protected RSceneMovieMusicCmd r_m_CmdMusic;
		public virtual RSceneMovieMusicCmd Rm_CmdMusic
		{
			get
			{
				if(r_m_CmdMusic == null)
				{
					r_m_CmdMusic = new(this, "m_CmdMusic");
					r_m_CmdMusic.SetBelong(this.instance);
				}
				return r_m_CmdMusic;
			}
		}

		/// <summary>
		/// SceneMovieUnitCmd m_CmdUnit
		/// </summary>
		protected RSceneMovieUnitCmd r_m_CmdUnit;
		public virtual RSceneMovieUnitCmd Rm_CmdUnit
		{
			get
			{
				if(r_m_CmdUnit == null)
				{
					r_m_CmdUnit = new(this, "m_CmdUnit");
					r_m_CmdUnit.SetBelong(this.instance);
				}
				return r_m_CmdUnit;
			}
		}

		/// <summary>
		/// SceneMoviePlayerLock m_CmdPlayerLock
		/// </summary>
		protected RSceneMoviePlayerLock r_m_CmdPlayerLock;
		public virtual RSceneMoviePlayerLock Rm_CmdPlayerLock
		{
			get
			{
				if(r_m_CmdPlayerLock == null)
				{
					r_m_CmdPlayerLock = new(this, "m_CmdPlayerLock");
					r_m_CmdPlayerLock.SetBelong(this.instance);
				}
				return r_m_CmdPlayerLock;
			}
		}

		/// <summary>
		/// SceneMovieOtherPlayerShow m_CmdOtherPlayerShow
		/// </summary>
		protected RSceneMovieOtherPlayerShow r_m_CmdOtherPlayerShow;
		public virtual RSceneMovieOtherPlayerShow Rm_CmdOtherPlayerShow
		{
			get
			{
				if(r_m_CmdOtherPlayerShow == null)
				{
					r_m_CmdOtherPlayerShow = new(this, "m_CmdOtherPlayerShow");
					r_m_CmdOtherPlayerShow.SetBelong(this.instance);
				}
				return r_m_CmdOtherPlayerShow;
			}
		}

		/// <summary>
		/// SceneMovieTimeScale m_CmdTimeScale
		/// </summary>
		protected RSceneMovieTimeScale r_m_CmdTimeScale;
		public virtual RSceneMovieTimeScale Rm_CmdTimeScale
		{
			get
			{
				if(r_m_CmdTimeScale == null)
				{
					r_m_CmdTimeScale = new(this, "m_CmdTimeScale");
					r_m_CmdTimeScale.SetBelong(this.instance);
				}
				return r_m_CmdTimeScale;
			}
		}

		/// <summary>
		/// SceneMovieEffectCmd m_CmdEffect
		/// </summary>
		protected RSceneMovieEffectCmd r_m_CmdEffect;
		public virtual RSceneMovieEffectCmd Rm_CmdEffect
		{
			get
			{
				if(r_m_CmdEffect == null)
				{
					r_m_CmdEffect = new(this, "m_CmdEffect");
					r_m_CmdEffect.SetBelong(this.instance);
				}
				return r_m_CmdEffect;
			}
		}

		/// <summary>
		/// SceneMovieReplayCombat m_CmdCombat
		/// </summary>
		protected RSceneMovieReplayCombat r_m_CmdCombat;
		public virtual RSceneMovieReplayCombat Rm_CmdCombat
		{
			get
			{
				if(r_m_CmdCombat == null)
				{
					r_m_CmdCombat = new(this, "m_CmdCombat");
					r_m_CmdCombat.SetBelong(this.instance);
				}
				return r_m_CmdCombat;
			}
		}

		/// <summary>
		/// System.Single m_fPostpone
		/// </summary>
		protected RField r_m_fPostpone;
		public virtual RField Rm_fPostpone
		{
			get
			{
				if(r_m_fPostpone == null)
				{
					r_m_fPostpone = new(this, "m_fPostpone");
					r_m_fPostpone.SetBelong(this.instance);
				}
				return r_m_fPostpone;
			}
		}

		/// <summary>
		/// Int32 CompareTo(SceneMovieCommand)
		/// </summary>
		protected RMethod r_RCompareTo_SceneMovieCommand;
		public virtual RMethod RCompareTo_SceneMovieCommand
		{
			get
			{
				if(r_RCompareTo_SceneMovieCommand == null)
				{
					r_RCompareTo_SceneMovieCommand = new(this, "CompareTo", 0, typeof(SceneMovieCommand));
					r_RCompareTo_SceneMovieCommand.SetBelong(this.instance);
				}
				return r_RCompareTo_SceneMovieCommand;
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


        public RSceneMovieCommand() : base("SceneMovieCommand")
        {
        }

        public RSceneMovieCommand(System.Object instance) : base("SceneMovieCommand")
		{
            SetInstance(instance);
		}

        public RSceneMovieCommand(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSceneMovieCommand(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 CompareTo(SceneMovieCommand  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = RCompareTo_SceneMovieCommand.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
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
