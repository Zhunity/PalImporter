using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.R__0__oU
{
	/// <summary>
	/// #oU.#UZ
	/// </summary>
    public partial class R__0__UZ : RMember //
    {

		/// <summary>
		/// #oU.#3Y #a
		/// </summary>
		protected R__0__oU.R__0__3Y r___0__a;
		public virtual R__0__oU.R__0__3Y R__0__a
		{
			get
			{
				if(r___0__a == null)
				{
					r___0__a = new(this, "#a");
					r___0__a.SetBelong(this.instance);
				}
				return r___0__a;
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
		/// Boolean Expand
		/// </summary>
		protected RProperty r_R__0__j5;
		public virtual RProperty R__0__j5
		{
			get
			{
				if(r_R__0__j5 == null)
				{
					r_R__0__j5 = new(this, "Expand", -1);
					r_R__0__j5.SetBelong(this.instance);
				}
				return r_R__0__j5;
			}
		}

		/// <summary>
		/// Void Draw(UnityEngine.Rect, UnityEngine.GUIStyle)
		/// </summary>
		protected RMethod r_RDraw_Rect_GUIStyle;
		public virtual RMethod RDraw_Rect_GUIStyle
		{
			get
			{
				if(r_RDraw_Rect_GUIStyle == null)
				{
					r_RDraw_Rect_GUIStyle = new(this, "Draw", 0, typeof(UnityEngine.Rect), typeof(UnityEngine.GUIStyle));
					r_RDraw_Rect_GUIStyle.SetBelong(this.instance);
				}
				return r_RDraw_Rect_GUIStyle;
			}
		}

		/// <summary>
		/// Void #TZ(#oU.#3Y)
		/// </summary>
		protected RMethod r_R__0__TZ___0__3Y;
		public virtual RMethod R__0__TZ___0__3Y
		{
			get
			{
				if(r_R__0__TZ___0__3Y == null)
				{
					r_R__0__TZ___0__3Y = new(this, "#TZ", 0,  ReleactionUtils.GetType("#oU.#3Y"));
					r_R__0__TZ___0__3Y.SetBelong(this.instance);
				}
				return r_R__0__TZ___0__3Y;
			}
		}

		/// <summary>
		/// Void AddChild(#oU.#5fd)
		/// </summary>
		protected RMethod r_RAddChild___0__5fd;
		public virtual RMethod RAddChild___0__5fd
		{
			get
			{
				if(r_RAddChild___0__5fd == null)
				{
					r_RAddChild___0__5fd = new(this, "AddChild", 0,  ReleactionUtils.GetType("#oU.#5fd"));
					r_RAddChild___0__5fd.SetBelong(this.instance);
				}
				return r_RAddChild___0__5fd;
			}
		}

		/// <summary>
		/// Void RemoveChild(Int32)
		/// </summary>
		protected RMethod r_RRemoveChild_Int32;
		public virtual RMethod RRemoveChild_Int32
		{
			get
			{
				if(r_RRemoveChild_Int32 == null)
				{
					r_RRemoveChild_Int32 = new(this, "RemoveChild", 0, typeof(System.Int32));
					r_RRemoveChild_Int32.SetBelong(this.instance);
				}
				return r_RRemoveChild_Int32;
			}
		}

		/// <summary>
		/// #oU.#5fd #m5(Int32)
		/// </summary>
		protected RMethod r_R__0__m5_Int32;
		public virtual RMethod R__0__m5_Int32
		{
			get
			{
				if(r_R__0__m5_Int32 == null)
				{
					r_R__0__m5_Int32 = new(this, "#m5", 0, typeof(System.Int32));
					r_R__0__m5_Int32.SetBelong(this.instance);
				}
				return r_R__0__m5_Int32;
			}
		}

		/// <summary>
		/// Int32 #n5()
		/// </summary>
		protected RMethod r_R__0__n5;
		public virtual RMethod R__0__n5
		{
			get
			{
				if(r_R__0__n5 == null)
				{
					r_R__0__n5 = new(this, "#n5", 0);
					r_R__0__n5.SetBelong(this.instance);
				}
				return r_R__0__n5;
			}
		}

		/// <summary>
		/// Single #o5()
		/// </summary>
		protected RMethod r_R__0__o5;
		public virtual RMethod R__0__o5
		{
			get
			{
				if(r_R__0__o5 == null)
				{
					r_R__0__o5 = new(this, "#o5", 0);
					r_R__0__o5.SetBelong(this.instance);
				}
				return r_R__0__o5;
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


        public R__0__UZ() : base("#oU.#UZ")
        {
        }

        public R__0__UZ(System.Object instance) : base("#oU.#UZ")
		{
            SetInstance(instance);
		}

        public R__0__UZ(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public R__0__UZ(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Draw(UnityEngine.Rect  @rect, UnityEngine.GUIStyle  @style)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@rect, @style};
            var ___result = RDraw_Rect_GUIStyle.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void RemoveChild(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = RRemoveChild_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object __0__m5(System.Int32  @index)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@index};
            var ___result = R__0__m5_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 __0__n5()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__n5.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Single __0__o5()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R__0__o5.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
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
