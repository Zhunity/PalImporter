using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{public partial class RScreenWipes
{
	
	/// <summary>
	/// ScreenWipes+<DreamWipe>c__Iterator17E
	/// </summary>
    public partial class R__2__DreamWipe__4__c__Iterator17E : RMember //
    {

		/// <summary>
		/// System.Single waveScale
		/// </summary>
		protected RField r_waveScale;
		public virtual RField RwaveScale
		{
			get
			{
				if(r_waveScale == null)
				{
					r_waveScale = new(this, "waveScale");
					r_waveScale.SetBelong(this.instance);
				}
				return r_waveScale;
			}
		}

		/// <summary>
		/// System.Single waveFrequency
		/// </summary>
		protected RField r_waveFrequency;
		public virtual RField RwaveFrequency
		{
			get
			{
				if(r_waveFrequency == null)
				{
					r_waveFrequency = new(this, "waveFrequency");
					r_waveFrequency.SetBelong(this.instance);
				}
				return r_waveFrequency;
			}
		}

		/// <summary>
		/// UnityEngine.Camera cam1
		/// </summary>
		protected RUnityEngine.RCamera r_cam1;
		public virtual RUnityEngine.RCamera Rcam1
		{
			get
			{
				if(r_cam1 == null)
				{
					r_cam1 = new(this, "cam1");
					r_cam1.SetBelong(this.instance);
				}
				return r_cam1;
			}
		}

		/// <summary>
		/// UnityEngine.Camera cam2
		/// </summary>
		protected RUnityEngine.RCamera r_cam2;
		public virtual RUnityEngine.RCamera Rcam2
		{
			get
			{
				if(r_cam2 == null)
				{
					r_cam2 = new(this, "cam2");
					r_cam2.SetBelong(this.instance);
				}
				return r_cam2;
			}
		}

		/// <summary>
		/// UnityEngine.Camera <cam2Clone>__0
		/// </summary>
		protected RUnityEngine.RCamera r___2__cam2Clone__4____0;
		public virtual RUnityEngine.RCamera R__2__cam2Clone__4____0
		{
			get
			{
				if(r___2__cam2Clone__4____0 == null)
				{
					r___2__cam2Clone__4____0 = new(this, "<cam2Clone>__0");
					r___2__cam2Clone__4____0.SetBelong(this.instance);
				}
				return r___2__cam2Clone__4____0;
			}
		}

		/// <summary>
		/// UnityEngine.Vector3 <p>__1
		/// </summary>
		protected RUnityEngine.RVector3 r___2__p__4____1;
		public virtual RUnityEngine.RVector3 R__2__p__4____1
		{
			get
			{
				if(r___2__p__4____1 == null)
				{
					r___2__p__4____1 = new(this, "<p>__1");
					r___2__p__4____1.SetBelong(this.instance);
				}
				return r___2__p__4____1;
			}
		}

		/// <summary>
		/// System.Single <scale>__2
		/// </summary>
		protected RField r___2__scale__4____2;
		public virtual RField R__2__scale__4____2
		{
			get
			{
				if(r___2__scale__4____2 == null)
				{
					r___2__scale__4____2 = new(this, "<scale>__2");
					r___2__scale__4____2.SetBelong(this.instance);
				}
				return r___2__scale__4____2;
			}
		}

		/// <summary>
		/// UnityEngine.Mesh <planeMesh>__3
		/// </summary>
		protected RUnityEngine.RMesh r___2__planeMesh__4____3;
		public virtual RUnityEngine.RMesh R__2__planeMesh__4____3
		{
			get
			{
				if(r___2__planeMesh__4____3 == null)
				{
					r___2__planeMesh__4____3 = new(this, "<planeMesh>__3");
					r___2__planeMesh__4____3.SetBelong(this.instance);
				}
				return r___2__planeMesh__4____3;
			}
		}

		/// <summary>
		/// System.Single time
		/// </summary>
		protected RField r_time;
		public virtual RField Rtime
		{
			get
			{
				if(r_time == null)
				{
					r_time = new(this, "time");
					r_time.SetBelong(this.instance);
				}
				return r_time;
			}
		}

		/// <summary>
		/// System.Single <rate>__4
		/// </summary>
		protected RField r___2__rate__4____4;
		public virtual RField R__2__rate__4____4
		{
			get
			{
				if(r___2__rate__4____4 == null)
				{
					r___2__rate__4____4 = new(this, "<rate>__4");
					r___2__rate__4____4.SetBelong(this.instance);
				}
				return r___2__rate__4____4;
			}
		}

		/// <summary>
		/// System.Single <i>__5
		/// </summary>
		protected RField r___2__i__4____5;
		public virtual RField R__2__i__4____5
		{
			get
			{
				if(r___2__i__4____5 == null)
				{
					r___2__i__4____5 = new(this, "<i>__5");
					r___2__i__4____5.SetBelong(this.instance);
				}
				return r___2__i__4____5;
			}
		}

		/// <summary>
		/// System.Int32 <j>__6
		/// </summary>
		protected RField r___2__j__4____6;
		public virtual RField R__2__j__4____6
		{
			get
			{
				if(r___2__j__4____6 == null)
				{
					r___2__j__4____6 = new(this, "<j>__6");
					r___2__j__4____6.SetBelong(this.instance);
				}
				return r___2__j__4____6;
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
		/// System.Single <$>waveScale
		/// </summary>
		protected RField r___2____9____4__waveScale;
		public virtual RField R__2____9____4__waveScale
		{
			get
			{
				if(r___2____9____4__waveScale == null)
				{
					r___2____9____4__waveScale = new(this, "<$>waveScale");
					r___2____9____4__waveScale.SetBelong(this.instance);
				}
				return r___2____9____4__waveScale;
			}
		}

		/// <summary>
		/// System.Single <$>waveFrequency
		/// </summary>
		protected RField r___2____9____4__waveFrequency;
		public virtual RField R__2____9____4__waveFrequency
		{
			get
			{
				if(r___2____9____4__waveFrequency == null)
				{
					r___2____9____4__waveFrequency = new(this, "<$>waveFrequency");
					r___2____9____4__waveFrequency.SetBelong(this.instance);
				}
				return r___2____9____4__waveFrequency;
			}
		}

		/// <summary>
		/// UnityEngine.Camera <$>cam1
		/// </summary>
		protected RUnityEngine.RCamera r___2____9____4__cam1;
		public virtual RUnityEngine.RCamera R__2____9____4__cam1
		{
			get
			{
				if(r___2____9____4__cam1 == null)
				{
					r___2____9____4__cam1 = new(this, "<$>cam1");
					r___2____9____4__cam1.SetBelong(this.instance);
				}
				return r___2____9____4__cam1;
			}
		}

		/// <summary>
		/// UnityEngine.Camera <$>cam2
		/// </summary>
		protected RUnityEngine.RCamera r___2____9____4__cam2;
		public virtual RUnityEngine.RCamera R__2____9____4__cam2
		{
			get
			{
				if(r___2____9____4__cam2 == null)
				{
					r___2____9____4__cam2 = new(this, "<$>cam2");
					r___2____9____4__cam2.SetBelong(this.instance);
				}
				return r___2____9____4__cam2;
			}
		}

		/// <summary>
		/// System.Single <$>time
		/// </summary>
		protected RField r___2____9____4__time;
		public virtual RField R__2____9____4__time
		{
			get
			{
				if(r___2____9____4__time == null)
				{
					r___2____9____4__time = new(this, "<$>time");
					r___2____9____4__time.SetBelong(this.instance);
				}
				return r___2____9____4__time;
			}
		}

		/// <summary>
		/// ScreenWipes <>f__this
		/// </summary>
		protected RScreenWipes r___2____4__f__this;
		public virtual RScreenWipes R__2____4__f__this
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


        public R__2__DreamWipe__4__c__Iterator17E() : base("ScreenWipes+<DreamWipe>c__Iterator17E")
        {
        }

        public R__2__DreamWipe__4__c__Iterator17E(System.Object instance) : base("ScreenWipes+<DreamWipe>c__Iterator17E")
		{
            SetInstance(instance);
		}

        public R__2__DreamWipe__4__c__Iterator17E(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__2__DreamWipe__4__c__Iterator17E(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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