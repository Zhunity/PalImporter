using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__oU
{
	/// <summary>
	/// #oU.#63
	/// </summary>
    public partial class R__0__63 : RMember //
    {

		/// <summary>
		/// MyGUI.ElementBase #e
		/// </summary>
		protected RMyGUI.RElementBase r___0__e;
		public virtual RMyGUI.RElementBase R__0__e
		{
			get
			{
				if(r___0__e == null)
				{
					r___0__e = new(this, "#e");
					r___0__e.SetBelong(this.instance);
				}
				return r___0__e;
			}
		}

		/// <summary>
		/// #bOb ClickEvent
		/// </summary>
		protected R__0__oU.R__0__33.R__0__bOb r_R__0__bX;
		public virtual R__0__oU.R__0__33.R__0__bOb R__0__bX
		{
			get
			{
				if(r_R__0__bX == null)
				{
					r_R__0__bX = new(this, "ClickEvent", -1);
					r_R__0__bX.SetBelong(this.instance);
				}
				return r_R__0__bX;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle Style
		/// </summary>
		protected RUnityEngine.RGUIStyle r_Style;
		public virtual RUnityEngine.RGUIStyle RStyle
		{
			get
			{
				if(r_Style == null)
				{
					r_Style = new(this, "Style", -1);
					r_Style.SetBelong(this.instance);
				}
				return r_Style;
			}
		}

		/// <summary>
		/// System.String Text
		/// </summary>
		protected RProperty r_Text;
		public virtual RProperty RText
		{
			get
			{
				if(r_Text == null)
				{
					r_Text = new(this, "Text", -1);
					r_Text.SetBelong(this.instance);
				}
				return r_Text;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase Element
		/// </summary>
		protected RMyGUI.RElementBase r_R__0__X3;
		public virtual RMyGUI.RElementBase R__0__X3
		{
			get
			{
				if(r_R__0__X3 == null)
				{
					r_R__0__X3 = new(this, "Element", -1);
					r_R__0__X3.SetBelong(this.instance);
				}
				return r_R__0__X3;
			}
		}

		/// <summary>
		/// System.Object Data
		/// </summary>
		protected RSystem.RObject r_R__0__Z3;
		public virtual RSystem.RObject R__0__Z3
		{
			get
			{
				if(r_R__0__Z3 == null)
				{
					r_R__0__Z3 = new(this, "Data", -1);
					r_R__0__Z3.SetBelong(this.instance);
				}
				return r_R__0__Z3;
			}
		}

		/// <summary>
		/// Boolean IsFixSize
		/// </summary>
		protected RProperty r_R__0__13;
		public virtual RProperty R__0__13
		{
			get
			{
				if(r_R__0__13 == null)
				{
					r_R__0__13 = new(this, "IsFixSize", -1);
					r_R__0__13.SetBelong(this.instance);
				}
				return r_R__0__13;
			}
		}

		/// <summary>
		/// #oU.#33 Copy()
		/// </summary>
		protected RMethod r_RCopy;
		public virtual RMethod RCopy
		{
			get
			{
				if(r_RCopy == null)
				{
					r_RCopy = new(this, "Copy", 0);
					r_RCopy.SetBelong(this.instance);
				}
				return r_RCopy;
			}
		}

		/// <summary>
		/// Void #43(System.Object, #oU.#7X)
		/// </summary>
		protected RMethod r_R__0__43_Object___0__7X;
		public virtual RMethod R__0__43_Object___0__7X
		{
			get
			{
				if(r_R__0__43_Object___0__7X == null)
				{
					r_R__0__43_Object___0__7X = new(this, "#43", 0, typeof(System.Object),  ReleactionUtils.GetType("#oU.#7X"));
					r_R__0__43_Object___0__7X.SetBelong(this.instance);
				}
				return r_R__0__43_Object___0__7X;
			}
		}

		/// <summary>
		/// Void #W3(Boolean)
		/// </summary>
		protected RMethod r_R__0__W3_Boolean;
		public virtual RMethod R__0__W3_Boolean
		{
			get
			{
				if(r_R__0__W3_Boolean == null)
				{
					r_R__0__W3_Boolean = new(this, "#W3", 0, typeof(System.Boolean));
					r_R__0__W3_Boolean.SetBelong(this.instance);
				}
				return r_R__0__W3_Boolean;
			}
		}

		/// <summary>
		/// MyGUI.ElementBase #U3()
		/// </summary>
		protected RMethod r_R__0__U3;
		public virtual RMethod R__0__U3
		{
			get
			{
				if(r_R__0__U3 == null)
				{
					r_R__0__U3 = new(this, "#U3", 0);
					r_R__0__U3.SetBelong(this.instance);
				}
				return r_R__0__U3;
			}
		}

		/// <summary>
		/// Void #V3(MyGUI.ElementBase)
		/// </summary>
		protected RMethod r_R__0__V3_ElementBase;
		public virtual RMethod R__0__V3_ElementBase
		{
			get
			{
				if(r_R__0__V3_ElementBase == null)
				{
					r_R__0__V3_ElementBase = new(this, "#V3", 0, typeof(MyGUI.ElementBase));
					r_R__0__V3_ElementBase.SetBelong(this.instance);
				}
				return r_R__0__V3_ElementBase;
			}
		}

		/// <summary>
		/// Void #eS(#bOb)
		/// </summary>
		protected RMethod r_R__0__eS___0__bOb;
		public virtual RMethod R__0__eS___0__bOb
		{
			get
			{
				if(r_R__0__eS___0__bOb == null)
				{
					r_R__0__eS___0__bOb = new(this, "#eS", 0,  ReleactionUtils.GetType("#oU.#33+#bOb"));
					r_R__0__eS___0__bOb.SetBelong(this.instance);
				}
				return r_R__0__eS___0__bOb;
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


        public R__0__63() : base("#oU.#63")
        {
        }

        public R__0__63(System.Object instance) : base("#oU.#63")
		{
            SetInstance(instance);
		}

        public R__0__63(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__63(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Object Copy()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCopy.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }



        public virtual void __0__W3(System.Boolean  @isActive)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isActive};
            var ___result = R__0__W3_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual MyGUI.ElementBase __0__U3()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__U3.Invoke(___genericsType, ___parameters);

            return (MyGUI.ElementBase)___result;
        }


        public virtual void __0__V3(MyGUI.ElementBase  @elem)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@elem};
            var ___result = R__0__V3_ElementBase.Invoke(___genericsType, ___parameters);

            
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
