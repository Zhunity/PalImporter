using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUISettings
	/// </summary>
    public partial class RGUISettings : RMember //
    {

		/// <summary>
		/// System.Boolean m_DoubleClickSelectsWord
		/// </summary>
		protected RField r_m_DoubleClickSelectsWord;
		public virtual RField Rm_DoubleClickSelectsWord
		{
			get
			{
				if(r_m_DoubleClickSelectsWord == null)
				{
					r_m_DoubleClickSelectsWord = new(this, "m_DoubleClickSelectsWord");
					r_m_DoubleClickSelectsWord.SetBelong(this.instance);
				}
				return r_m_DoubleClickSelectsWord;
			}
		}

		/// <summary>
		/// System.Boolean m_TripleClickSelectsLine
		/// </summary>
		protected RField r_m_TripleClickSelectsLine;
		public virtual RField Rm_TripleClickSelectsLine
		{
			get
			{
				if(r_m_TripleClickSelectsLine == null)
				{
					r_m_TripleClickSelectsLine = new(this, "m_TripleClickSelectsLine");
					r_m_TripleClickSelectsLine.SetBelong(this.instance);
				}
				return r_m_TripleClickSelectsLine;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_CursorColor
		/// </summary>
		protected RUnityEngine.RColor r_m_CursorColor;
		public virtual RUnityEngine.RColor Rm_CursorColor
		{
			get
			{
				if(r_m_CursorColor == null)
				{
					r_m_CursorColor = new(this, "m_CursorColor");
					r_m_CursorColor.SetBelong(this.instance);
				}
				return r_m_CursorColor;
			}
		}

		/// <summary>
		/// System.Single m_CursorFlashSpeed
		/// </summary>
		protected RField r_m_CursorFlashSpeed;
		public virtual RField Rm_CursorFlashSpeed
		{
			get
			{
				if(r_m_CursorFlashSpeed == null)
				{
					r_m_CursorFlashSpeed = new(this, "m_CursorFlashSpeed");
					r_m_CursorFlashSpeed.SetBelong(this.instance);
				}
				return r_m_CursorFlashSpeed;
			}
		}

		/// <summary>
		/// UnityEngine.Color m_SelectionColor
		/// </summary>
		protected RUnityEngine.RColor r_m_SelectionColor;
		public virtual RUnityEngine.RColor Rm_SelectionColor
		{
			get
			{
				if(r_m_SelectionColor == null)
				{
					r_m_SelectionColor = new(this, "m_SelectionColor");
					r_m_SelectionColor.SetBelong(this.instance);
				}
				return r_m_SelectionColor;
			}
		}

		/// <summary>
		/// Boolean doubleClickSelectsWord
		/// </summary>
		protected RProperty r_doubleClickSelectsWord;
		public virtual RProperty RdoubleClickSelectsWord
		{
			get
			{
				if(r_doubleClickSelectsWord == null)
				{
					r_doubleClickSelectsWord = new(this, "doubleClickSelectsWord", -1);
					r_doubleClickSelectsWord.SetBelong(this.instance);
				}
				return r_doubleClickSelectsWord;
			}
		}

		/// <summary>
		/// Boolean tripleClickSelectsLine
		/// </summary>
		protected RProperty r_tripleClickSelectsLine;
		public virtual RProperty RtripleClickSelectsLine
		{
			get
			{
				if(r_tripleClickSelectsLine == null)
				{
					r_tripleClickSelectsLine = new(this, "tripleClickSelectsLine", -1);
					r_tripleClickSelectsLine.SetBelong(this.instance);
				}
				return r_tripleClickSelectsLine;
			}
		}

		/// <summary>
		/// UnityEngine.Color cursorColor
		/// </summary>
		protected RUnityEngine.RColor r_cursorColor;
		public virtual RUnityEngine.RColor RcursorColor
		{
			get
			{
				if(r_cursorColor == null)
				{
					r_cursorColor = new(this, "cursorColor", -1);
					r_cursorColor.SetBelong(this.instance);
				}
				return r_cursorColor;
			}
		}

		/// <summary>
		/// Single cursorFlashSpeed
		/// </summary>
		protected RProperty r_cursorFlashSpeed;
		public virtual RProperty RcursorFlashSpeed
		{
			get
			{
				if(r_cursorFlashSpeed == null)
				{
					r_cursorFlashSpeed = new(this, "cursorFlashSpeed", -1);
					r_cursorFlashSpeed.SetBelong(this.instance);
				}
				return r_cursorFlashSpeed;
			}
		}

		/// <summary>
		/// UnityEngine.Color selectionColor
		/// </summary>
		protected RUnityEngine.RColor r_selectionColor;
		public virtual RUnityEngine.RColor RselectionColor
		{
			get
			{
				if(r_selectionColor == null)
				{
					r_selectionColor = new(this, "selectionColor", -1);
					r_selectionColor.SetBelong(this.instance);
				}
				return r_selectionColor;
			}
		}

		/// <summary>
		/// Single Internal_GetCursorFlashSpeed()
		/// </summary>
		protected static RMethod r_RInternal_GetCursorFlashSpeed;
		public static RMethod RInternal_GetCursorFlashSpeed
		{
			get
			{
				if(r_RInternal_GetCursorFlashSpeed == null)
				{
					r_RInternal_GetCursorFlashSpeed = new(typeof(UnityEngine.GUISettings), "Internal_GetCursorFlashSpeed", 0);
					r_RInternal_GetCursorFlashSpeed.SetBelong(null);
				}
				return r_RInternal_GetCursorFlashSpeed;
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


        public RGUISettings() : base("UnityEngine.GUISettings")
        {
        }

        public RGUISettings(System.Object instance) : base("UnityEngine.GUISettings")
		{
            SetInstance(instance);
		}

        public RGUISettings(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUISettings(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static System.Single Internal_GetCursorFlashSpeed()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternal_GetCursorFlashSpeed.Invoke(___genericsType, ___parameters);

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
