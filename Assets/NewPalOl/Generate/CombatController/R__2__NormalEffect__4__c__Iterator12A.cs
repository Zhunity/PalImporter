using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RCombatController
{
	
	/// <summary>
	/// CombatController+<NormalEffect>c__Iterator12A
	/// </summary>
    public partial class R__2__NormalEffect__4__c__Iterator12A : RMember //
    {

		/// <summary>
		/// BattleEffectBase args
		/// </summary>
		protected RBattleEffectBase r_args;
		public virtual RBattleEffectBase Rargs
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
		/// NormalEffect <tmpArgs>__0
		/// </summary>
		protected RNormalEffect r___2__tmpArgs__4____0;
		public virtual RNormalEffect R__2__tmpArgs__4____0
		{
			get
			{
				if(r___2__tmpArgs__4____0 == null)
				{
					r___2__tmpArgs__4____0 = new(this, "<tmpArgs>__0");
					r___2__tmpArgs__4____0.SetBelong(this.instance);
				}
				return r___2__tmpArgs__4____0;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject <tmpObj>__1
		/// </summary>
		protected RUnityEngine.RGameObject r___2__tmpObj__4____1;
		public virtual RUnityEngine.RGameObject R__2__tmpObj__4____1
		{
			get
			{
				if(r___2__tmpObj__4____1 == null)
				{
					r___2__tmpObj__4____1 = new(this, "<tmpObj>__1");
					r___2__tmpObj__4____1.SetBelong(this.instance);
				}
				return r___2__tmpObj__4____1;
			}
		}

		/// <summary>
		/// System.String <mBoneName>__2
		/// </summary>
		protected RField r___2__mBoneName__4____2;
		public virtual RField R__2__mBoneName__4____2
		{
			get
			{
				if(r___2__mBoneName__4____2 == null)
				{
					r___2__mBoneName__4____2 = new(this, "<mBoneName>__2");
					r___2__mBoneName__4____2.SetBelong(this.instance);
				}
				return r___2__mBoneName__4____2;
			}
		}

		/// <summary>
		/// System.Boolean <isWorldPos>__3
		/// </summary>
		protected RField r___2__isWorldPos__4____3;
		public virtual RField R__2__isWorldPos__4____3
		{
			get
			{
				if(r___2__isWorldPos__4____3 == null)
				{
					r___2__isWorldPos__4____3 = new(this, "<isWorldPos>__3");
					r___2__isWorldPos__4____3.SetBelong(this.instance);
				}
				return r___2__isWorldPos__4____3;
			}
		}

		/// <summary>
		/// System.Int32 <rowCenterY>__4
		/// </summary>
		protected RField r___2__rowCenterY__4____4;
		public virtual RField R__2__rowCenterY__4____4
		{
			get
			{
				if(r___2__rowCenterY__4____4 == null)
				{
					r___2__rowCenterY__4____4 = new(this, "<rowCenterY>__4");
					r___2__rowCenterY__4____4.SetBelong(this.instance);
				}
				return r___2__rowCenterY__4____4;
			}
		}

		/// <summary>
		/// System.Int32 <columnCenterY>__5
		/// </summary>
		protected RField r___2__columnCenterY__4____5;
		public virtual RField R__2__columnCenterY__4____5
		{
			get
			{
				if(r___2__columnCenterY__4____5 == null)
				{
					r___2__columnCenterY__4____5 = new(this, "<columnCenterY>__5");
					r___2__columnCenterY__4____5.SetBelong(this.instance);
				}
				return r___2__columnCenterY__4____5;
			}
		}

		/// <summary>
		/// UnityEngine.Transform <boneTrans>__6
		/// </summary>
		protected RUnityEngine.RTransform r___2__boneTrans__4____6;
		public virtual RUnityEngine.RTransform R__2__boneTrans__4____6
		{
			get
			{
				if(r___2__boneTrans__4____6 == null)
				{
					r___2__boneTrans__4____6 = new(this, "<boneTrans>__6");
					r___2__boneTrans__4____6.SetBelong(this.instance);
				}
				return r___2__boneTrans__4____6;
			}
		}

		/// <summary>
		/// ObjectRotate <tmpRotatCom>__7
		/// </summary>
		protected RObjectRotate r___2__tmpRotatCom__4____7;
		public virtual RObjectRotate R__2__tmpRotatCom__4____7
		{
			get
			{
				if(r___2__tmpRotatCom__4____7 == null)
				{
					r___2__tmpRotatCom__4____7 = new(this, "<tmpRotatCom>__7");
					r___2__tmpRotatCom__4____7.SetBelong(this.instance);
				}
				return r___2__tmpRotatCom__4____7;
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
		/// BattleEffectBase <$>args
		/// </summary>
		protected RBattleEffectBase r___2____9____4__args;
		public virtual RBattleEffectBase R__2____9____4__args
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
		/// CombatController <>f__this
		/// </summary>
		protected RCombatController r___2____4__f__this;
		public virtual RCombatController R__2____4__f__this
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


        public R__2__NormalEffect__4__c__Iterator12A() : base("CombatController+<NormalEffect>c__Iterator12A")
        {
        }

        public R__2__NormalEffect__4__c__Iterator12A(System.Object instance) : base("CombatController+<NormalEffect>c__Iterator12A")
		{
            SetInstance(instance);
		}

        public R__2__NormalEffect__4__c__Iterator12A(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__2__NormalEffect__4__c__Iterator12A(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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