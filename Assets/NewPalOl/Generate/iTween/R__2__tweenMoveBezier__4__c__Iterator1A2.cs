using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RiTween
{
	
	/// <summary>
	/// iTween+<tweenMoveBezier>c__Iterator1A2
	/// </summary>
    public partial class R__2__tweenMoveBezier__4__c__Iterator1A2 : RMember //
    {

		/// <summary>
		/// System.Collections.Generic.List`1[iTween+BezierPointInfo] <_beziers>__0
		/// </summary>
		protected RSystem.RCollections.RGeneric.RList<RiTween.RBezierPointInfo> r___2___beziers__4____0;
		public virtual RSystem.RCollections.RGeneric.RList<RiTween.RBezierPointInfo> R__2___beziers__4____0
		{
			get
			{
				if(r___2___beziers__4____0 == null)
				{
					r___2___beziers__4____0 = new(this, "<_beziers>__0");
					r___2___beziers__4____0.SetBelong(this.instance);
				}
				return r___2___beziers__4____0;
			}
		}

		/// <summary>
		/// System.Int32 <iNumPoints>__1
		/// </summary>
		protected RField r___2__iNumPoints__4____1;
		public virtual RField R__2__iNumPoints__4____1
		{
			get
			{
				if(r___2__iNumPoints__4____1 == null)
				{
					r___2__iNumPoints__4____1 = new(this, "<iNumPoints>__1");
					r___2__iNumPoints__4____1.SetBelong(this.instance);
				}
				return r___2__iNumPoints__4____1;
			}
		}

		/// <summary>
		/// iTween+easingFunction <easing>__2
		/// </summary>
		protected RiTween.ReasingFunction r___2__easing__4____2;
		public virtual RiTween.ReasingFunction R__2__easing__4____2
		{
			get
			{
				if(r___2__easing__4____2 == null)
				{
					r___2__easing__4____2 = new(this, "<easing>__2");
					r___2__easing__4____2.SetBelong(this.instance);
				}
				return r___2__easing__4____2;
			}
		}

		/// <summary>
		/// System.Single <curTime>__3
		/// </summary>
		protected RField r___2__curTime__4____3;
		public virtual RField R__2__curTime__4____3
		{
			get
			{
				if(r___2__curTime__4____3 == null)
				{
					r___2__curTime__4____3 = new(this, "<curTime>__3");
					r___2__curTime__4____3.SetBelong(this.instance);
				}
				return r___2__curTime__4____3;
			}
		}

		/// <summary>
		/// System.Single <virtTimePart>__4
		/// </summary>
		protected RField r___2__virtTimePart__4____4;
		public virtual RField R__2__virtTimePart__4____4
		{
			get
			{
				if(r___2__virtTimePart__4____4 == null)
				{
					r___2__virtTimePart__4____4 = new(this, "<virtTimePart>__4");
					r___2__virtTimePart__4____4.SetBelong(this.instance);
				}
				return r___2__virtTimePart__4____4;
			}
		}

		/// <summary>
		/// System.Int32 <iCurAxisPoint>__5
		/// </summary>
		protected RField r___2__iCurAxisPoint__4____5;
		public virtual RField R__2__iCurAxisPoint__4____5
		{
			get
			{
				if(r___2__iCurAxisPoint__4____5 == null)
				{
					r___2__iCurAxisPoint__4____5 = new(this, "<iCurAxisPoint>__5");
					r___2__iCurAxisPoint__4____5.SetBelong(this.instance);
				}
				return r___2__iCurAxisPoint__4____5;
			}
		}

		/// <summary>
		/// System.Single <timeFract>__6
		/// </summary>
		protected RField r___2__timeFract__4____6;
		public virtual RField R__2__timeFract__4____6
		{
			get
			{
				if(r___2__timeFract__4____6 == null)
				{
					r___2__timeFract__4____6 = new(this, "<timeFract>__6");
					r___2__timeFract__4____6.SetBelong(this.instance);
				}
				return r___2__timeFract__4____6;
			}
		}

		/// <summary>
		/// iTween+BezierPointInfo <bpi>__7
		/// </summary>
		protected RiTween.RBezierPointInfo r___2__bpi__4____7;
		public virtual RiTween.RBezierPointInfo R__2__bpi__4____7
		{
			get
			{
				if(r___2__bpi__4____7 == null)
				{
					r___2__bpi__4____7 = new(this, "<bpi>__7");
					r___2__bpi__4____7.SetBelong(this.instance);
				}
				return r___2__bpi__4____7;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 <newVector>__8
		/// </summary>
		protected RUnityEngine.RVector3 r___2__newVector__4____8;
		public virtual RUnityEngine.RVector3 R__2__newVector__4____8
		{
			get
			{
				if(r___2__newVector__4____8 == null)
				{
					r___2__newVector__4____8 = new(this, "<newVector>__8");
					r___2__newVector__4____8.SetBelong(this.instance);
				}
				return r___2__newVector__4____8;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 <lookAtTarget>__9
		/// </summary>
		protected RUnityEngine.RVector3 r___2__lookAtTarget__4____9;
		public virtual RUnityEngine.RVector3 R__2__lookAtTarget__4____9
		{
			get
			{
				if(r___2__lookAtTarget__4____9 == null)
				{
					r___2__lookAtTarget__4____9 = new(this, "<lookAtTarget>__9");
					r___2__lookAtTarget__4____9.SetBelong(this.instance);
				}
				return r___2__lookAtTarget__4____9;
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
		/// iTween <>f__this
		/// </summary>
		protected RiTween r___2____4__f__this;
		public virtual RiTween R__2____4__f__this
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


        public R__2__tweenMoveBezier__4__c__Iterator1A2() : base("iTween+<tweenMoveBezier>c__Iterator1A2")
        {
        }

        public R__2__tweenMoveBezier__4__c__Iterator1A2(System.Object instance) : base("iTween+<tweenMoveBezier>c__Iterator1A2")
		{
            SetInstance(instance);
		}

        public R__2__tweenMoveBezier__4__c__Iterator1A2(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__2__tweenMoveBezier__4__c__Iterator1A2(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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