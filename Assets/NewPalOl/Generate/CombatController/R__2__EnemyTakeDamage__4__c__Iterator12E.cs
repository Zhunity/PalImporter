using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RCombatController
{
	
	/// <summary>
	/// CombatController+<EnemyTakeDamage>c__Iterator12E
	/// </summary>
    public partial class R__2__EnemyTakeDamage__4__c__Iterator12E : RMember //
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
		/// EnemyTakeDamage <tmpArgs>__0
		/// </summary>
		protected REnemyTakeDamage r___2__tmpArgs__4____0;
		public virtual REnemyTakeDamage R__2__tmpArgs__4____0
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
		/// CombatController <tmpCC>__1
		/// </summary>
		protected RCombatController r___2__tmpCC__4____1;
		public virtual RCombatController R__2__tmpCC__4____1
		{
			get
			{
				if(r___2__tmpCC__4____1 == null)
				{
					r___2__tmpCC__4____1 = new(this, "<tmpCC>__1");
					r___2__tmpCC__4____1.SetBelong(this.instance);
				}
				return r___2__tmpCC__4____1;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleAction] <mTmpList>__2
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBattleAction> r___2__mTmpList__4____2;
		public virtual RSystem.RCollections.RGeneric.RList<RBattleAction> R__2__mTmpList__4____2
		{
			get
			{
				if(r___2__mTmpList__4____2 == null)
				{
					r___2__mTmpList__4____2 = new(this, "<mTmpList>__2");
					r___2__mTmpList__4____2.SetBelong(this.instance);
				}
				return r___2__mTmpList__4____2;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1+Enumerator[BattleAction] <$s_1658>__3
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField>.REnumerator r___2____9__s_1658__4____3;
		public virtual RSystem.RCollections.RGeneric.RList<RField>.REnumerator R__2____9__s_1658__4____3
		{
			get
			{
				if(r___2____9__s_1658__4____3 == null)
				{
					r___2____9__s_1658__4____3 = new(this, "<$s_1658>__3");
					r___2____9__s_1658__4____3.SetBelong(this.instance);
				}
				return r___2____9__s_1658__4____3;
			}
		}

		/// <summary>
		/// BattleAction <tmpBA>__4
		/// </summary>
		protected RBattleAction r___2__tmpBA__4____4;
		public virtual RBattleAction R__2__tmpBA__4____4
		{
			get
			{
				if(r___2__tmpBA__4____4 == null)
				{
					r___2__tmpBA__4____4 = new(this, "<tmpBA>__4");
					r___2__tmpBA__4____4.SetBelong(this.instance);
				}
				return r___2__tmpBA__4____4;
			}
		}

		/// <summary>
		/// System.Boolean <isBuffforbiden>__5
		/// </summary>
		protected RField r___2__isBuffforbiden__4____5;
		public virtual RField R__2__isBuffforbiden__4____5
		{
			get
			{
				if(r___2__isBuffforbiden__4____5 == null)
				{
					r___2__isBuffforbiden__4____5 = new(this, "<isBuffforbiden>__5");
					r___2__isBuffforbiden__4____5.SetBelong(this.instance);
				}
				return r___2__isBuffforbiden__4____5;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2+KeyCollection+Enumerator[GameDefineType.ID,BattleBuff] <$s_1659>__6
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RField>.RKeyCollection.REnumerator r___2____9__s_1659__4____6;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RField>.RKeyCollection.REnumerator R__2____9__s_1659__4____6
		{
			get
			{
				if(r___2____9__s_1659__4____6 == null)
				{
					r___2____9__s_1659__4____6 = new(this, "<$s_1659>__6");
					r___2____9__s_1659__4____6.SetBelong(this.instance);
				}
				return r___2____9__s_1659__4____6;
			}
		}

		/// <summary>
		/// GameDefineType.ID <tmpBuffID>__7
		/// </summary>
		protected RGameDefineType.RID r___2__tmpBuffID__4____7;
		public virtual RGameDefineType.RID R__2__tmpBuffID__4____7
		{
			get
			{
				if(r___2__tmpBuffID__4____7 == null)
				{
					r___2__tmpBuffID__4____7 = new(this, "<tmpBuffID>__7");
					r___2__tmpBuffID__4____7.SetBelong(this.instance);
				}
				return r___2__tmpBuffID__4____7;
			}
		}

		/// <summary>
		/// BuffEffectHold <tmpBEH>__8
		/// </summary>
		protected RBuffEffectHold r___2__tmpBEH__4____8;
		public virtual RBuffEffectHold R__2__tmpBEH__4____8
		{
			get
			{
				if(r___2__tmpBEH__4____8 == null)
				{
					r___2__tmpBEH__4____8 = new(this, "<tmpBEH>__8");
					r___2__tmpBEH__4____8.SetBelong(this.instance);
				}
				return r___2__tmpBEH__4____8;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleAction] <mTmpList>__9
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBattleAction> r___2__mTmpList__4____9;
		public virtual RSystem.RCollections.RGeneric.RList<RBattleAction> R__2__mTmpList__4____9
		{
			get
			{
				if(r___2__mTmpList__4____9 == null)
				{
					r___2__mTmpList__4____9 = new(this, "<mTmpList>__9");
					r___2__mTmpList__4____9.SetBelong(this.instance);
				}
				return r___2__mTmpList__4____9;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1+Enumerator[BattleAction] <$s_1660>__10
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField>.REnumerator r___2____9__s_1660__4____10;
		public virtual RSystem.RCollections.RGeneric.RList<RField>.REnumerator R__2____9__s_1660__4____10
		{
			get
			{
				if(r___2____9__s_1660__4____10 == null)
				{
					r___2____9__s_1660__4____10 = new(this, "<$s_1660>__10");
					r___2____9__s_1660__4____10.SetBelong(this.instance);
				}
				return r___2____9__s_1660__4____10;
			}
		}

		/// <summary>
		/// BattleAction <tmpBA>__11
		/// </summary>
		protected RBattleAction r___2__tmpBA__4____11;
		public virtual RBattleAction R__2__tmpBA__4____11
		{
			get
			{
				if(r___2__tmpBA__4____11 == null)
				{
					r___2__tmpBA__4____11 = new(this, "<tmpBA>__11");
					r___2__tmpBA__4____11.SetBelong(this.instance);
				}
				return r___2__tmpBA__4____11;
			}
		}

		/// <summary>
		/// BattleAction <_tmpAction>__12
		/// </summary>
		protected RBattleAction r___2___tmpAction__4____12;
		public virtual RBattleAction R__2___tmpAction__4____12
		{
			get
			{
				if(r___2___tmpAction__4____12 == null)
				{
					r___2___tmpAction__4____12 = new(this, "<_tmpAction>__12");
					r___2___tmpAction__4____12.SetBelong(this.instance);
				}
				return r___2___tmpAction__4____12;
			}
		}

		/// <summary>
		/// System.Boolean <defendEffectAdd>__13
		/// </summary>
		protected RField r___2__defendEffectAdd__4____13;
		public virtual RField R__2__defendEffectAdd__4____13
		{
			get
			{
				if(r___2__defendEffectAdd__4____13 == null)
				{
					r___2__defendEffectAdd__4____13 = new(this, "<defendEffectAdd>__13");
					r___2__defendEffectAdd__4____13.SetBelong(this.instance);
				}
				return r___2__defendEffectAdd__4____13;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1+Enumerator[BattleEffectBase] <$s_1661>__14
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField>.REnumerator r___2____9__s_1661__4____14;
		public virtual RSystem.RCollections.RGeneric.RList<RField>.REnumerator R__2____9__s_1661__4____14
		{
			get
			{
				if(r___2____9__s_1661__4____14 == null)
				{
					r___2____9__s_1661__4____14 = new(this, "<$s_1661>__14");
					r___2____9__s_1661__4____14.SetBelong(this.instance);
				}
				return r___2____9__s_1661__4____14;
			}
		}

		/// <summary>
		/// BattleEffectBase <tmpBEB>__15
		/// </summary>
		protected RBattleEffectBase r___2__tmpBEB__4____15;
		public virtual RBattleEffectBase R__2__tmpBEB__4____15
		{
			get
			{
				if(r___2__tmpBEB__4____15 == null)
				{
					r___2__tmpBEB__4____15 = new(this, "<tmpBEB>__15");
					r___2__tmpBEB__4____15.SetBelong(this.instance);
				}
				return r___2__tmpBEB__4____15;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1[BattleEffectBase] <tmpBEBlist>__16
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RBattleEffectBase> r___2__tmpBEBlist__4____16;
		public virtual RSystem.RCollections.RGeneric.RList<RBattleEffectBase> R__2__tmpBEBlist__4____16
		{
			get
			{
				if(r___2__tmpBEBlist__4____16 == null)
				{
					r___2__tmpBEBlist__4____16 = new(this, "<tmpBEBlist>__16");
					r___2__tmpBEBlist__4____16.SetBelong(this.instance);
				}
				return r___2__tmpBEBlist__4____16;
			}
		}

		/// <summary>
		/// System.Collections.Generic.List`1+Enumerator[BattleEffectBase] <$s_1662>__17
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RField>.REnumerator r___2____9__s_1662__4____17;
		public virtual RSystem.RCollections.RGeneric.RList<RField>.REnumerator R__2____9__s_1662__4____17
		{
			get
			{
				if(r___2____9__s_1662__4____17 == null)
				{
					r___2____9__s_1662__4____17 = new(this, "<$s_1662>__17");
					r___2____9__s_1662__4____17.SetBelong(this.instance);
				}
				return r___2____9__s_1662__4____17;
			}
		}

		/// <summary>
		/// BattleEffectBase <tmpBEB>__18
		/// </summary>
		protected RBattleEffectBase r___2__tmpBEB__4____18;
		public virtual RBattleEffectBase R__2__tmpBEB__4____18
		{
			get
			{
				if(r___2__tmpBEB__4____18 == null)
				{
					r___2__tmpBEB__4____18 = new(this, "<tmpBEB>__18");
					r___2__tmpBEB__4____18.SetBelong(this.instance);
				}
				return r___2__tmpBEB__4____18;
			}
		}

		/// <summary>
		/// NormalEffect <tmpNE>__19
		/// </summary>
		protected RNormalEffect r___2__tmpNE__4____19;
		public virtual RNormalEffect R__2__tmpNE__4____19
		{
			get
			{
				if(r___2__tmpNE__4____19 == null)
				{
					r___2__tmpNE__4____19 = new(this, "<tmpNE>__19");
					r___2__tmpNE__4____19.SetBelong(this.instance);
				}
				return r___2__tmpNE__4____19;
			}
		}

		/// <summary>
		/// DefendEffect <tmpDE>__20
		/// </summary>
		protected RDefendEffect r___2__tmpDE__4____20;
		public virtual RDefendEffect R__2__tmpDE__4____20
		{
			get
			{
				if(r___2__tmpDE__4____20 == null)
				{
					r___2__tmpDE__4____20 = new(this, "<tmpDE>__20");
					r___2__tmpDE__4____20.SetBelong(this.instance);
				}
				return r___2__tmpDE__4____20;
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


        public R__2__EnemyTakeDamage__4__c__Iterator12E() : base("CombatController+<EnemyTakeDamage>c__Iterator12E")
        {
        }

        public R__2__EnemyTakeDamage__4__c__Iterator12E(System.Object instance) : base("CombatController+<EnemyTakeDamage>c__Iterator12E")
		{
            SetInstance(instance);
		}

        public R__2__EnemyTakeDamage__4__c__Iterator12E(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__2__EnemyTakeDamage__4__c__Iterator12E(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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