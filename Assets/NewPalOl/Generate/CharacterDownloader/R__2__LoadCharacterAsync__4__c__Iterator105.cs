using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RCharacterDownloader
{
	
	/// <summary>
	/// CharacterDownloader+<LoadCharacterAsync>c__Iterator105
	/// </summary>
    public partial class R__2__LoadCharacterAsync__4__c__Iterator105 : RMember //
    {

		/// <summary>
		/// CharacterDownloader+CGLoadArgs args
		/// </summary>
		protected RCharacterDownloader.RCGLoadArgs r_args;
		public virtual RCharacterDownloader.RCGLoadArgs Rargs
		{
			get
			{
				if(r_args == null)
				{
					r_args = new(this, "args");
					r_args.SetBelong(this.instance);
				}
				return r_args;
			}
		}

		/// <summary>
		/// System.Object param
		/// </summary>
		protected RSystem.RObject r_param;
		public virtual RSystem.RObject Rparam
		{
			get
			{
				if(r_param == null)
				{
					r_param = new(this, "param");
					r_param.SetBelong(this.instance);
				}
				return r_param;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject <tmpCharacter>__0
		/// </summary>
		protected RUnityEngine.RGameObject r___2__tmpCharacter__4____0;
		public virtual RUnityEngine.RGameObject R__2__tmpCharacter__4____0
		{
			get
			{
				if(r___2__tmpCharacter__4____0 == null)
				{
					r___2__tmpCharacter__4____0 = new(this, "<tmpCharacter>__0");
					r___2__tmpCharacter__4____0.SetBelong(this.instance);
				}
				return r___2__tmpCharacter__4____0;
			}
		}

		/// <summary>
		/// UnityEngine.SkinnedMeshRenderer <tmpSMR>__1
		/// </summary>
		protected RUnityEngine.RSkinnedMeshRenderer r___2__tmpSMR__4____1;
		public virtual RUnityEngine.RSkinnedMeshRenderer R__2__tmpSMR__4____1
		{
			get
			{
				if(r___2__tmpSMR__4____1 == null)
				{
					r___2__tmpSMR__4____1 = new(this, "<tmpSMR>__1");
					r___2__tmpSMR__4____1.SetBelong(this.instance);
				}
				return r___2__tmpSMR__4____1;
			}
		}

		/// <summary>
		/// UnityEngine.Animation <mAni>__2
		/// </summary>
		protected RUnityEngine.RAnimation r___2__mAni__4____2;
		public virtual RUnityEngine.RAnimation R__2__mAni__4____2
		{
			get
			{
				if(r___2__mAni__4____2 == null)
				{
					r___2__mAni__4____2 = new(this, "<mAni>__2");
					r___2__mAni__4____2.SetBelong(this.instance);
				}
				return r___2__mAni__4____2;
			}
		}

		/// <summary>
		/// System.Boolean bNeedInstantiate
		/// </summary>
		protected RField r_bNeedInstantiate;
		public virtual RField RbNeedInstantiate
		{
			get
			{
				if(r_bNeedInstantiate == null)
				{
					r_bNeedInstantiate = new(this, "bNeedInstantiate");
					r_bNeedInstantiate.SetBelong(this.instance);
				}
				return r_bNeedInstantiate;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject <obj>__3
		/// </summary>
		protected RUnityEngine.RGameObject r___2__obj__4____3;
		public virtual RUnityEngine.RGameObject R__2__obj__4____3
		{
			get
			{
				if(r___2__obj__4____3 == null)
				{
					r___2__obj__4____3 = new(this, "<obj>__3");
					r___2__obj__4____3.SetBelong(this.instance);
				}
				return r___2__obj__4____3;
			}
		}

		/// <summary>
		/// GameDefineType.ID <career>__4
		/// </summary>
		protected RGameDefineType.RID r___2__career__4____4;
		public virtual RGameDefineType.RID R__2__career__4____4
		{
			get
			{
				if(r___2__career__4____4 == null)
				{
					r___2__career__4____4 = new(this, "<career>__4");
					r___2__career__4____4.SetBelong(this.instance);
				}
				return r___2__career__4____4;
			}
		}

		/// <summary>
		/// CharacterDownloader+CharacterAnimationClipArg <tmpCAC_arg>__5
		/// </summary>
		protected RCharacterDownloader.RCharacterAnimationClipArg r___2__tmpCAC_arg__4____5;
		public virtual RCharacterDownloader.RCharacterAnimationClipArg R__2__tmpCAC_arg__4____5
		{
			get
			{
				if(r___2__tmpCAC_arg__4____5 == null)
				{
					r___2__tmpCAC_arg__4____5 = new(this, "<tmpCAC_arg>__5");
					r___2__tmpCAC_arg__4____5.SetBelong(this.instance);
				}
				return r___2__tmpCAC_arg__4____5;
			}
		}

		/// <summary>
		/// GameDefineType.ID mCarrer
		/// </summary>
		protected RGameDefineType.RID r_mCarrer;
		public virtual RGameDefineType.RID RmCarrer
		{
			get
			{
				if(r_mCarrer == null)
				{
					r_mCarrer = new(this, "mCarrer");
					r_mCarrer.SetBelong(this.instance);
				}
				return r_mCarrer;
			}
		}

		/// <summary>
		/// CharacterDownloader+CharacterWeaponArg <tmpCW_arg>__6
		/// </summary>
		protected RCharacterDownloader.RCharacterWeaponArg r___2__tmpCW_arg__4____6;
		public virtual RCharacterDownloader.RCharacterWeaponArg R__2__tmpCW_arg__4____6
		{
			get
			{
				if(r___2__tmpCW_arg__4____6 == null)
				{
					r___2__tmpCW_arg__4____6 = new(this, "<tmpCW_arg>__6");
					r___2__tmpCW_arg__4____6.SetBelong(this.instance);
				}
				return r___2__tmpCW_arg__4____6;
			}
		}

		/// <summary>
		/// WeaponRes <tmpWeaponRes>__7
		/// </summary>
		protected RWeaponRes r___2__tmpWeaponRes__4____7;
		public virtual RWeaponRes R__2__tmpWeaponRes__4____7
		{
			get
			{
				if(r___2__tmpWeaponRes__4____7 == null)
				{
					r___2__tmpWeaponRes__4____7 = new(this, "<tmpWeaponRes>__7");
					r___2__tmpWeaponRes__4____7.SetBelong(this.instance);
				}
				return r___2__tmpWeaponRes__4____7;
			}
		}

		/// <summary>
		/// CharacterDownloader+CharacterWeaponArg <tmpCW_arg>__8
		/// </summary>
		protected RCharacterDownloader.RCharacterWeaponArg r___2__tmpCW_arg__4____8;
		public virtual RCharacterDownloader.RCharacterWeaponArg R__2__tmpCW_arg__4____8
		{
			get
			{
				if(r___2__tmpCW_arg__4____8 == null)
				{
					r___2__tmpCW_arg__4____8 = new(this, "<tmpCW_arg>__8");
					r___2__tmpCW_arg__4____8.SetBelong(this.instance);
				}
				return r___2__tmpCW_arg__4____8;
			}
		}

		/// <summary>
		/// WeaponRes <tmpWeaponRes>__9
		/// </summary>
		protected RWeaponRes r___2__tmpWeaponRes__4____9;
		public virtual RWeaponRes R__2__tmpWeaponRes__4____9
		{
			get
			{
				if(r___2__tmpWeaponRes__4____9 == null)
				{
					r___2__tmpWeaponRes__4____9 = new(this, "<tmpWeaponRes>__9");
					r___2__tmpWeaponRes__4____9.SetBelong(this.instance);
				}
				return r___2__tmpWeaponRes__4____9;
			}
		}

		/// <summary>
		/// System.Int32 $PC
		/// </summary>
		protected RField r___9__PC;
		public virtual RField R__9__PC
		{
			get
			{
				if(r___9__PC == null)
				{
					r___9__PC = new(this, "$PC");
					r___9__PC.SetBelong(this.instance);
				}
				return r___9__PC;
			}
		}

		/// <summary>
		/// System.Object $current
		/// </summary>
		protected RSystem.RObject r___9__current;
		public virtual RSystem.RObject R__9__current
		{
			get
			{
				if(r___9__current == null)
				{
					r___9__current = new(this, "$current");
					r___9__current.SetBelong(this.instance);
				}
				return r___9__current;
			}
		}

		/// <summary>
		/// CharacterDownloader+CGLoadArgs <$>args
		/// </summary>
		protected RCharacterDownloader.RCGLoadArgs r___2____9____4__args;
		public virtual RCharacterDownloader.RCGLoadArgs R__2____9____4__args
		{
			get
			{
				if(r___2____9____4__args == null)
				{
					r___2____9____4__args = new(this, "<$>args");
					r___2____9____4__args.SetBelong(this.instance);
				}
				return r___2____9____4__args;
			}
		}

		/// <summary>
		/// System.Object <$>param
		/// </summary>
		protected RSystem.RObject r___2____9____4__param;
		public virtual RSystem.RObject R__2____9____4__param
		{
			get
			{
				if(r___2____9____4__param == null)
				{
					r___2____9____4__param = new(this, "<$>param");
					r___2____9____4__param.SetBelong(this.instance);
				}
				return r___2____9____4__param;
			}
		}

		/// <summary>
		/// System.Boolean <$>bNeedInstantiate
		/// </summary>
		protected RField r___2____9____4__bNeedInstantiate;
		public virtual RField R__2____9____4__bNeedInstantiate
		{
			get
			{
				if(r___2____9____4__bNeedInstantiate == null)
				{
					r___2____9____4__bNeedInstantiate = new(this, "<$>bNeedInstantiate");
					r___2____9____4__bNeedInstantiate.SetBelong(this.instance);
				}
				return r___2____9____4__bNeedInstantiate;
			}
		}

		/// <summary>
		/// GameDefineType.ID <$>mCarrer
		/// </summary>
		protected RGameDefineType.RID r___2____9____4__mCarrer;
		public virtual RGameDefineType.RID R__2____9____4__mCarrer
		{
			get
			{
				if(r___2____9____4__mCarrer == null)
				{
					r___2____9____4__mCarrer = new(this, "<$>mCarrer");
					r___2____9____4__mCarrer.SetBelong(this.instance);
				}
				return r___2____9____4__mCarrer;
			}
		}

		/// <summary>
		/// CharacterDownloader <>f__this
		/// </summary>
		protected RCharacterDownloader r___2____4__f__this;
		public virtual RCharacterDownloader R__2____4__f__this
		{
			get
			{
				if(r___2____4__f__this == null)
				{
					r___2____4__f__this = new(this, "<>f__this");
					r___2____4__f__this.SetBelong(this.instance);
				}
				return r___2____4__f__this;
			}
		}

		/// <summary>
		/// System.Object System.Collections.Generic.IEnumerator<object>.Current
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Collections__1__Generic__1__IEnumerator__2__object__4____1__get_Current;
		public virtual RSystem.RObject RSystem__1__Collections__1__Generic__1__IEnumerator__2__object__4____1__get_Current
		{
			get
			{
				if(r_RSystem__1__Collections__1__Generic__1__IEnumerator__2__object__4____1__get_Current == null)
				{
					r_RSystem__1__Collections__1__Generic__1__IEnumerator__2__object__4____1__get_Current = new(this, "System.Collections.Generic.IEnumerator<object>.Current", -1);
					r_RSystem__1__Collections__1__Generic__1__IEnumerator__2__object__4____1__get_Current.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__Generic__1__IEnumerator__2__object__4____1__get_Current;
			}
		}

		/// <summary>
		/// System.Object System.Collections.IEnumerator.Current
		/// </summary>
		protected RSystem.RObject r_RSystem__1__Collections__1__IEnumerator__1__get_Current;
		public virtual RSystem.RObject RSystem__1__Collections__1__IEnumerator__1__get_Current
		{
			get
			{
				if(r_RSystem__1__Collections__1__IEnumerator__1__get_Current == null)
				{
					r_RSystem__1__Collections__1__IEnumerator__1__get_Current = new(this, "System.Collections.IEnumerator.Current", -1);
					r_RSystem__1__Collections__1__IEnumerator__1__get_Current.SetBelong(this.instance);
				}
				return r_RSystem__1__Collections__1__IEnumerator__1__get_Current;
			}
		}

		/// <summary>
		/// Boolean MoveNext()
		/// </summary>
		protected RMethod r_RMoveNext;
		public virtual RMethod RMoveNext
		{
			get
			{
				if(r_RMoveNext == null)
				{
					r_RMoveNext = new(this, "MoveNext", 0);
					r_RMoveNext.SetBelong(this.instance);
				}
				return r_RMoveNext;
			}
		}

		/// <summary>
		/// Void Dispose()
		/// </summary>
		protected RMethod r_RDispose;
		public virtual RMethod RDispose
		{
			get
			{
				if(r_RDispose == null)
				{
					r_RDispose = new(this, "Dispose", 0);
					r_RDispose.SetBelong(this.instance);
				}
				return r_RDispose;
			}
		}

		/// <summary>
		/// Void Reset()
		/// </summary>
		protected RMethod r_RReset;
		public virtual RMethod RReset
		{
			get
			{
				if(r_RReset == null)
				{
					r_RReset = new(this, "Reset", 0);
					r_RReset.SetBelong(this.instance);
				}
				return r_RReset;
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


        public R__2__LoadCharacterAsync__4__c__Iterator105() : base("CharacterDownloader+<LoadCharacterAsync>c__Iterator105")
        {
        }

        public R__2__LoadCharacterAsync__4__c__Iterator105(System.Object instance) : base("CharacterDownloader+<LoadCharacterAsync>c__Iterator105")
		{
            SetInstance(instance);
		}

        public R__2__LoadCharacterAsync__4__c__Iterator105(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__2__LoadCharacterAsync__4__c__Iterator105(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Boolean MoveNext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveNext.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Reset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReset.Invoke(___genericsType, ___parameters);

            
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
}