using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RCreatureBehav
{
	
	/// <summary>
	/// CreatureBehav+<CreatureFade>c__Iterator150
	/// </summary>
    public partial class R__2__CreatureFade__4__c__Iterator150 : RMember //
    {

		/// <summary>
		/// CreatureBehav+FadeType type
		/// </summary>
		protected RField r_type;
		public virtual RField Rtype
		{
			get
			{
				if(r_type == null)
				{
					r_type = new(this, "type");
					r_type.SetBelong(this.instance);
				}
				return r_type;
			}
		}

		/// <summary>
		/// UnityEngine.Renderer[] <tmpRS>__0
		/// </summary>
		protected RFieldArray<RUnityEngine.RRenderer> r___2__tmpRS__4____0;
		public virtual RFieldArray<RUnityEngine.RRenderer> R__2__tmpRS__4____0
		{
			get
			{
				if(r___2__tmpRS__4____0 == null)
				{
					r___2__tmpRS__4____0 = new(this, "<tmpRS>__0");
					r___2__tmpRS__4____0.SetBelong(this.instance);
				}
				return r___2__tmpRS__4____0;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] <children>__1
		/// </summary>
		protected RFieldArray<RUnityEngine.RGameObject> r___2__children__4____1;
		public virtual RFieldArray<RUnityEngine.RGameObject> R__2__children__4____1
		{
			get
			{
				if(r___2__children__4____1 == null)
				{
					r___2__children__4____1 = new(this, "<children>__1");
					r___2__children__4____1.SetBelong(this.instance);
				}
				return r___2__children__4____1;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] <$s_1938>__2
		/// </summary>
		protected RFieldArray<RUnityEngine.RGameObject> r___2____9__s_1938__4____2;
		public virtual RFieldArray<RUnityEngine.RGameObject> R__2____9__s_1938__4____2
		{
			get
			{
				if(r___2____9__s_1938__4____2 == null)
				{
					r___2____9__s_1938__4____2 = new(this, "<$s_1938>__2");
					r___2____9__s_1938__4____2.SetBelong(this.instance);
				}
				return r___2____9__s_1938__4____2;
			}
		}

		/// <summary>
		/// System.Int32 <$s_1939>__3
		/// </summary>
		protected RField r___2____9__s_1939__4____3;
		public virtual RField R__2____9__s_1939__4____3
		{
			get
			{
				if(r___2____9__s_1939__4____3 == null)
				{
					r___2____9__s_1939__4____3 = new(this, "<$s_1939>__3");
					r___2____9__s_1939__4____3.SetBelong(this.instance);
				}
				return r___2____9__s_1939__4____3;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject <obj>__4
		/// </summary>
		protected RUnityEngine.RGameObject r___2__obj__4____4;
		public virtual RUnityEngine.RGameObject R__2__obj__4____4
		{
			get
			{
				if(r___2__obj__4____4 == null)
				{
					r___2__obj__4____4 = new(this, "<obj>__4");
					r___2__obj__4____4.SetBelong(this.instance);
				}
				return r___2__obj__4____4;
			}
		}

		/// <summary>
		/// System.Single <realFadeSpeed>__5
		/// </summary>
		protected RField r___2__realFadeSpeed__4____5;
		public virtual RField R__2__realFadeSpeed__4____5
		{
			get
			{
				if(r___2__realFadeSpeed__4____5 == null)
				{
					r___2__realFadeSpeed__4____5 = new(this, "<realFadeSpeed>__5");
					r___2__realFadeSpeed__4____5.SetBelong(this.instance);
				}
				return r___2__realFadeSpeed__4____5;
			}
		}

		/// <summary>
		/// System.Single <m_Alpha>__6
		/// </summary>
		protected RField r___2__m_Alpha__4____6;
		public virtual RField R__2__m_Alpha__4____6
		{
			get
			{
				if(r___2__m_Alpha__4____6 == null)
				{
					r___2__m_Alpha__4____6 = new(this, "<m_Alpha>__6");
					r___2__m_Alpha__4____6.SetBelong(this.instance);
				}
				return r___2__m_Alpha__4____6;
			}
		}

		/// <summary>
		/// UnityEngine.Renderer[] <$s_1940>__7
		/// </summary>
		protected RFieldArray<RUnityEngine.RRenderer> r___2____9__s_1940__4____7;
		public virtual RFieldArray<RUnityEngine.RRenderer> R__2____9__s_1940__4____7
		{
			get
			{
				if(r___2____9__s_1940__4____7 == null)
				{
					r___2____9__s_1940__4____7 = new(this, "<$s_1940>__7");
					r___2____9__s_1940__4____7.SetBelong(this.instance);
				}
				return r___2____9__s_1940__4____7;
			}
		}

		/// <summary>
		/// System.Int32 <$s_1941>__8
		/// </summary>
		protected RField r___2____9__s_1941__4____8;
		public virtual RField R__2____9__s_1941__4____8
		{
			get
			{
				if(r___2____9__s_1941__4____8 == null)
				{
					r___2____9__s_1941__4____8 = new(this, "<$s_1941>__8");
					r___2____9__s_1941__4____8.SetBelong(this.instance);
				}
				return r___2____9__s_1941__4____8;
			}
		}

		/// <summary>
		/// UnityEngine.Renderer <tmpR>__9
		/// </summary>
		protected RUnityEngine.RRenderer r___2__tmpR__4____9;
		public virtual RUnityEngine.RRenderer R__2__tmpR__4____9
		{
			get
			{
				if(r___2__tmpR__4____9 == null)
				{
					r___2__tmpR__4____9 = new(this, "<tmpR>__9");
					r___2__tmpR__4____9.SetBelong(this.instance);
				}
				return r___2__tmpR__4____9;
			}
		}

		/// <summary>
		/// UnityEngine.Material[] <$s_1942>__10
		/// </summary>
		protected RFieldArray<RUnityEngine.RMaterial> r___2____9__s_1942__4____10;
		public virtual RFieldArray<RUnityEngine.RMaterial> R__2____9__s_1942__4____10
		{
			get
			{
				if(r___2____9__s_1942__4____10 == null)
				{
					r___2____9__s_1942__4____10 = new(this, "<$s_1942>__10");
					r___2____9__s_1942__4____10.SetBelong(this.instance);
				}
				return r___2____9__s_1942__4____10;
			}
		}

		/// <summary>
		/// System.Int32 <$s_1943>__11
		/// </summary>
		protected RField r___2____9__s_1943__4____11;
		public virtual RField R__2____9__s_1943__4____11
		{
			get
			{
				if(r___2____9__s_1943__4____11 == null)
				{
					r___2____9__s_1943__4____11 = new(this, "<$s_1943>__11");
					r___2____9__s_1943__4____11.SetBelong(this.instance);
				}
				return r___2____9__s_1943__4____11;
			}
		}

		/// <summary>
		/// UnityEngine.Material <tmpM>__12
		/// </summary>
		protected RUnityEngine.RMaterial r___2__tmpM__4____12;
		public virtual RUnityEngine.RMaterial R__2__tmpM__4____12
		{
			get
			{
				if(r___2__tmpM__4____12 == null)
				{
					r___2__tmpM__4____12 = new(this, "<tmpM>__12");
					r___2__tmpM__4____12.SetBelong(this.instance);
				}
				return r___2__tmpM__4____12;
			}
		}

		/// <summary>
		/// UnityEngine.Color <tmpColor>__13
		/// </summary>
		protected RUnityEngine.RColor r___2__tmpColor__4____13;
		public virtual RUnityEngine.RColor R__2__tmpColor__4____13
		{
			get
			{
				if(r___2__tmpColor__4____13 == null)
				{
					r___2__tmpColor__4____13 = new(this, "<tmpColor>__13");
					r___2__tmpColor__4____13.SetBelong(this.instance);
				}
				return r___2__tmpColor__4____13;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] <children>__14
		/// </summary>
		protected RFieldArray<RUnityEngine.RGameObject> r___2__children__4____14;
		public virtual RFieldArray<RUnityEngine.RGameObject> R__2__children__4____14
		{
			get
			{
				if(r___2__children__4____14 == null)
				{
					r___2__children__4____14 = new(this, "<children>__14");
					r___2__children__4____14.SetBelong(this.instance);
				}
				return r___2__children__4____14;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject[] <$s_1944>__15
		/// </summary>
		protected RFieldArray<RUnityEngine.RGameObject> r___2____9__s_1944__4____15;
		public virtual RFieldArray<RUnityEngine.RGameObject> R__2____9__s_1944__4____15
		{
			get
			{
				if(r___2____9__s_1944__4____15 == null)
				{
					r___2____9__s_1944__4____15 = new(this, "<$s_1944>__15");
					r___2____9__s_1944__4____15.SetBelong(this.instance);
				}
				return r___2____9__s_1944__4____15;
			}
		}

		/// <summary>
		/// System.Int32 <$s_1945>__16
		/// </summary>
		protected RField r___2____9__s_1945__4____16;
		public virtual RField R__2____9__s_1945__4____16
		{
			get
			{
				if(r___2____9__s_1945__4____16 == null)
				{
					r___2____9__s_1945__4____16 = new(this, "<$s_1945>__16");
					r___2____9__s_1945__4____16.SetBelong(this.instance);
				}
				return r___2____9__s_1945__4____16;
			}
		}

		/// <summary>
		/// UnityEngine.GameObject <obj>__17
		/// </summary>
		protected RUnityEngine.RGameObject r___2__obj__4____17;
		public virtual RUnityEngine.RGameObject R__2__obj__4____17
		{
			get
			{
				if(r___2__obj__4____17 == null)
				{
					r___2__obj__4____17 = new(this, "<obj>__17");
					r___2__obj__4____17.SetBelong(this.instance);
				}
				return r___2__obj__4____17;
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
		/// CreatureBehav+FadeType <$>type
		/// </summary>
		protected RField r___2____9____4__type;
		public virtual RField R__2____9____4__type
		{
			get
			{
				if(r___2____9____4__type == null)
				{
					r___2____9____4__type = new(this, "<$>type");
					r___2____9____4__type.SetBelong(this.instance);
				}
				return r___2____9____4__type;
			}
		}

		/// <summary>
		/// CreatureBehav <>f__this
		/// </summary>
		protected RCreatureBehav r___2____4__f__this;
		public virtual RCreatureBehav R__2____4__f__this
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


        public R__2__CreatureFade__4__c__Iterator150() : base("CreatureBehav+<CreatureFade>c__Iterator150")
        {
        }

        public R__2__CreatureFade__4__c__Iterator150(System.Object instance) : base("CreatureBehav+<CreatureFade>c__Iterator150")
		{
            SetInstance(instance);
		}

        public R__2__CreatureFade__4__c__Iterator150(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__2__CreatureFade__4__c__Iterator150(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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