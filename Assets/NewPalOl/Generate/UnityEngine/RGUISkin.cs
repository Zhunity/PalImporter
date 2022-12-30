using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RUnityEngine
{
	/// <summary>
	/// UnityEngine.GUISkin
	/// </summary>
    public partial class RGUISkin : RMember //
    {

		/// <summary>
		/// UnityEngine.Font m_Font
		/// </summary>
		protected RUnityEngine.RFont r_m_Font;
		public virtual RUnityEngine.RFont Rm_Font
		{
			get
			{
				if(r_m_Font == null)
				{
					r_m_Font = new(this, "m_Font");
					r_m_Font.SetBelong(this.instance);
				}
				return r_m_Font;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_box
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_box;
		public virtual RUnityEngine.RGUIStyle Rm_box
		{
			get
			{
				if(r_m_box == null)
				{
					r_m_box = new(this, "m_box");
					r_m_box.SetBelong(this.instance);
				}
				return r_m_box;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_button
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_button;
		public virtual RUnityEngine.RGUIStyle Rm_button
		{
			get
			{
				if(r_m_button == null)
				{
					r_m_button = new(this, "m_button");
					r_m_button.SetBelong(this.instance);
				}
				return r_m_button;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_toggle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_toggle;
		public virtual RUnityEngine.RGUIStyle Rm_toggle
		{
			get
			{
				if(r_m_toggle == null)
				{
					r_m_toggle = new(this, "m_toggle");
					r_m_toggle.SetBelong(this.instance);
				}
				return r_m_toggle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_label
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_label;
		public virtual RUnityEngine.RGUIStyle Rm_label
		{
			get
			{
				if(r_m_label == null)
				{
					r_m_label = new(this, "m_label");
					r_m_label.SetBelong(this.instance);
				}
				return r_m_label;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_textField
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_textField;
		public virtual RUnityEngine.RGUIStyle Rm_textField
		{
			get
			{
				if(r_m_textField == null)
				{
					r_m_textField = new(this, "m_textField");
					r_m_textField.SetBelong(this.instance);
				}
				return r_m_textField;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_textArea
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_textArea;
		public virtual RUnityEngine.RGUIStyle Rm_textArea
		{
			get
			{
				if(r_m_textArea == null)
				{
					r_m_textArea = new(this, "m_textArea");
					r_m_textArea.SetBelong(this.instance);
				}
				return r_m_textArea;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_window
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_window;
		public virtual RUnityEngine.RGUIStyle Rm_window
		{
			get
			{
				if(r_m_window == null)
				{
					r_m_window = new(this, "m_window");
					r_m_window.SetBelong(this.instance);
				}
				return r_m_window;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_horizontalSlider
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_horizontalSlider;
		public virtual RUnityEngine.RGUIStyle Rm_horizontalSlider
		{
			get
			{
				if(r_m_horizontalSlider == null)
				{
					r_m_horizontalSlider = new(this, "m_horizontalSlider");
					r_m_horizontalSlider.SetBelong(this.instance);
				}
				return r_m_horizontalSlider;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_horizontalSliderThumb
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_horizontalSliderThumb;
		public virtual RUnityEngine.RGUIStyle Rm_horizontalSliderThumb
		{
			get
			{
				if(r_m_horizontalSliderThumb == null)
				{
					r_m_horizontalSliderThumb = new(this, "m_horizontalSliderThumb");
					r_m_horizontalSliderThumb.SetBelong(this.instance);
				}
				return r_m_horizontalSliderThumb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_horizontalSliderThumbExtent
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_horizontalSliderThumbExtent;
		public virtual RUnityEngine.RGUIStyle Rm_horizontalSliderThumbExtent
		{
			get
			{
				if(r_m_horizontalSliderThumbExtent == null)
				{
					r_m_horizontalSliderThumbExtent = new(this, "m_horizontalSliderThumbExtent");
					r_m_horizontalSliderThumbExtent.SetBelong(this.instance);
				}
				return r_m_horizontalSliderThumbExtent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_verticalSlider
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_verticalSlider;
		public virtual RUnityEngine.RGUIStyle Rm_verticalSlider
		{
			get
			{
				if(r_m_verticalSlider == null)
				{
					r_m_verticalSlider = new(this, "m_verticalSlider");
					r_m_verticalSlider.SetBelong(this.instance);
				}
				return r_m_verticalSlider;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_verticalSliderThumb
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_verticalSliderThumb;
		public virtual RUnityEngine.RGUIStyle Rm_verticalSliderThumb
		{
			get
			{
				if(r_m_verticalSliderThumb == null)
				{
					r_m_verticalSliderThumb = new(this, "m_verticalSliderThumb");
					r_m_verticalSliderThumb.SetBelong(this.instance);
				}
				return r_m_verticalSliderThumb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_verticalSliderThumbExtent
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_verticalSliderThumbExtent;
		public virtual RUnityEngine.RGUIStyle Rm_verticalSliderThumbExtent
		{
			get
			{
				if(r_m_verticalSliderThumbExtent == null)
				{
					r_m_verticalSliderThumbExtent = new(this, "m_verticalSliderThumbExtent");
					r_m_verticalSliderThumbExtent.SetBelong(this.instance);
				}
				return r_m_verticalSliderThumbExtent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_SliderMixed
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_SliderMixed;
		public virtual RUnityEngine.RGUIStyle Rm_SliderMixed
		{
			get
			{
				if(r_m_SliderMixed == null)
				{
					r_m_SliderMixed = new(this, "m_SliderMixed");
					r_m_SliderMixed.SetBelong(this.instance);
				}
				return r_m_SliderMixed;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_horizontalScrollbar
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_horizontalScrollbar;
		public virtual RUnityEngine.RGUIStyle Rm_horizontalScrollbar
		{
			get
			{
				if(r_m_horizontalScrollbar == null)
				{
					r_m_horizontalScrollbar = new(this, "m_horizontalScrollbar");
					r_m_horizontalScrollbar.SetBelong(this.instance);
				}
				return r_m_horizontalScrollbar;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_horizontalScrollbarThumb
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_horizontalScrollbarThumb;
		public virtual RUnityEngine.RGUIStyle Rm_horizontalScrollbarThumb
		{
			get
			{
				if(r_m_horizontalScrollbarThumb == null)
				{
					r_m_horizontalScrollbarThumb = new(this, "m_horizontalScrollbarThumb");
					r_m_horizontalScrollbarThumb.SetBelong(this.instance);
				}
				return r_m_horizontalScrollbarThumb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_horizontalScrollbarLeftButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_horizontalScrollbarLeftButton;
		public virtual RUnityEngine.RGUIStyle Rm_horizontalScrollbarLeftButton
		{
			get
			{
				if(r_m_horizontalScrollbarLeftButton == null)
				{
					r_m_horizontalScrollbarLeftButton = new(this, "m_horizontalScrollbarLeftButton");
					r_m_horizontalScrollbarLeftButton.SetBelong(this.instance);
				}
				return r_m_horizontalScrollbarLeftButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_horizontalScrollbarRightButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_horizontalScrollbarRightButton;
		public virtual RUnityEngine.RGUIStyle Rm_horizontalScrollbarRightButton
		{
			get
			{
				if(r_m_horizontalScrollbarRightButton == null)
				{
					r_m_horizontalScrollbarRightButton = new(this, "m_horizontalScrollbarRightButton");
					r_m_horizontalScrollbarRightButton.SetBelong(this.instance);
				}
				return r_m_horizontalScrollbarRightButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_verticalScrollbar
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_verticalScrollbar;
		public virtual RUnityEngine.RGUIStyle Rm_verticalScrollbar
		{
			get
			{
				if(r_m_verticalScrollbar == null)
				{
					r_m_verticalScrollbar = new(this, "m_verticalScrollbar");
					r_m_verticalScrollbar.SetBelong(this.instance);
				}
				return r_m_verticalScrollbar;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_verticalScrollbarThumb
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_verticalScrollbarThumb;
		public virtual RUnityEngine.RGUIStyle Rm_verticalScrollbarThumb
		{
			get
			{
				if(r_m_verticalScrollbarThumb == null)
				{
					r_m_verticalScrollbarThumb = new(this, "m_verticalScrollbarThumb");
					r_m_verticalScrollbarThumb.SetBelong(this.instance);
				}
				return r_m_verticalScrollbarThumb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_verticalScrollbarUpButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_verticalScrollbarUpButton;
		public virtual RUnityEngine.RGUIStyle Rm_verticalScrollbarUpButton
		{
			get
			{
				if(r_m_verticalScrollbarUpButton == null)
				{
					r_m_verticalScrollbarUpButton = new(this, "m_verticalScrollbarUpButton");
					r_m_verticalScrollbarUpButton.SetBelong(this.instance);
				}
				return r_m_verticalScrollbarUpButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_verticalScrollbarDownButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_verticalScrollbarDownButton;
		public virtual RUnityEngine.RGUIStyle Rm_verticalScrollbarDownButton
		{
			get
			{
				if(r_m_verticalScrollbarDownButton == null)
				{
					r_m_verticalScrollbarDownButton = new(this, "m_verticalScrollbarDownButton");
					r_m_verticalScrollbarDownButton.SetBelong(this.instance);
				}
				return r_m_verticalScrollbarDownButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle m_ScrollView
		/// </summary>
		protected RUnityEngine.RGUIStyle r_m_ScrollView;
		public virtual RUnityEngine.RGUIStyle Rm_ScrollView
		{
			get
			{
				if(r_m_ScrollView == null)
				{
					r_m_ScrollView = new(this, "m_ScrollView");
					r_m_ScrollView.SetBelong(this.instance);
				}
				return r_m_ScrollView;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle[] m_CustomStyles
		/// </summary>
		protected RFieldArray<RUnityEngine.RGUIStyle> r_m_CustomStyles;
		public virtual RFieldArray<RUnityEngine.RGUIStyle> Rm_CustomStyles
		{
			get
			{
				if(r_m_CustomStyles == null)
				{
					r_m_CustomStyles = new(this, "m_CustomStyles");
					r_m_CustomStyles.SetBelong(this.instance);
				}
				return r_m_CustomStyles;
			}
		}

		/// <summary>
		/// UnityEngine.GUISettings m_Settings
		/// </summary>
		protected RUnityEngine.RGUISettings r_m_Settings;
		public virtual RUnityEngine.RGUISettings Rm_Settings
		{
			get
			{
				if(r_m_Settings == null)
				{
					r_m_Settings = new(this, "m_Settings");
					r_m_Settings.SetBelong(this.instance);
				}
				return r_m_Settings;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle ms_Error
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_ms_Error;
		public static RUnityEngine.RGUIStyle Rms_Error
		{
			get
			{
				if(r_ms_Error == null)
				{
					r_ms_Error = new(typeof(UnityEngine.GUISkin), "ms_Error");
					r_ms_Error.SetBelong(null);
				}
				return r_ms_Error;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.String,UnityEngine.GUIStyle] m_Styles
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGUIStyle> r_m_Styles;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RField, RUnityEngine.RGUIStyle> Rm_Styles
		{
			get
			{
				if(r_m_Styles == null)
				{
					r_m_Styles = new(this, "m_Styles");
					r_m_Styles.SetBelong(this.instance);
				}
				return r_m_Styles;
			}
		}

		/// <summary>
		/// UnityEngine.GUISkin+SkinChangedDelegate m_SkinChanged
		/// </summary>
		protected static RUnityEngine.RGUISkin.RSkinChangedDelegate r_m_SkinChanged;
		public static RUnityEngine.RGUISkin.RSkinChangedDelegate Rm_SkinChanged
		{
			get
			{
				if(r_m_SkinChanged == null)
				{
					r_m_SkinChanged = new(typeof(UnityEngine.GUISkin), "m_SkinChanged");
					r_m_SkinChanged.SetBelong(null);
				}
				return r_m_SkinChanged;
			}
		}

		/// <summary>
		/// UnityEngine.GUISkin current
		/// </summary>
		protected static RUnityEngine.RGUISkin r_current;
		public static RUnityEngine.RGUISkin Rcurrent
		{
			get
			{
				if(r_current == null)
				{
					r_current = new(typeof(UnityEngine.GUISkin), "current");
					r_current.SetBelong(null);
				}
				return r_current;
			}
		}

		/// <summary>
		/// UnityEngine.Font font
		/// </summary>
		protected RUnityEngine.RFont r_font;
		public virtual RUnityEngine.RFont Rfont
		{
			get
			{
				if(r_font == null)
				{
					r_font = new(this, "font", -1);
					r_font.SetBelong(this.instance);
				}
				return r_font;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle box
		/// </summary>
		protected RUnityEngine.RGUIStyle r_box;
		public virtual RUnityEngine.RGUIStyle Rbox
		{
			get
			{
				if(r_box == null)
				{
					r_box = new(this, "box", -1);
					r_box.SetBelong(this.instance);
				}
				return r_box;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle label
		/// </summary>
		protected RUnityEngine.RGUIStyle r_label;
		public virtual RUnityEngine.RGUIStyle Rlabel
		{
			get
			{
				if(r_label == null)
				{
					r_label = new(this, "label", -1);
					r_label.SetBelong(this.instance);
				}
				return r_label;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle textField
		/// </summary>
		protected RUnityEngine.RGUIStyle r_textField;
		public virtual RUnityEngine.RGUIStyle RtextField
		{
			get
			{
				if(r_textField == null)
				{
					r_textField = new(this, "textField", -1);
					r_textField.SetBelong(this.instance);
				}
				return r_textField;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle textArea
		/// </summary>
		protected RUnityEngine.RGUIStyle r_textArea;
		public virtual RUnityEngine.RGUIStyle RtextArea
		{
			get
			{
				if(r_textArea == null)
				{
					r_textArea = new(this, "textArea", -1);
					r_textArea.SetBelong(this.instance);
				}
				return r_textArea;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle button
		/// </summary>
		protected RUnityEngine.RGUIStyle r_button;
		public virtual RUnityEngine.RGUIStyle Rbutton
		{
			get
			{
				if(r_button == null)
				{
					r_button = new(this, "button", -1);
					r_button.SetBelong(this.instance);
				}
				return r_button;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle toggle
		/// </summary>
		protected RUnityEngine.RGUIStyle r_toggle;
		public virtual RUnityEngine.RGUIStyle Rtoggle
		{
			get
			{
				if(r_toggle == null)
				{
					r_toggle = new(this, "toggle", -1);
					r_toggle.SetBelong(this.instance);
				}
				return r_toggle;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle window
		/// </summary>
		protected RUnityEngine.RGUIStyle r_window;
		public virtual RUnityEngine.RGUIStyle Rwindow
		{
			get
			{
				if(r_window == null)
				{
					r_window = new(this, "window", -1);
					r_window.SetBelong(this.instance);
				}
				return r_window;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle horizontalSlider
		/// </summary>
		protected RUnityEngine.RGUIStyle r_horizontalSlider;
		public virtual RUnityEngine.RGUIStyle RhorizontalSlider
		{
			get
			{
				if(r_horizontalSlider == null)
				{
					r_horizontalSlider = new(this, "horizontalSlider", -1);
					r_horizontalSlider.SetBelong(this.instance);
				}
				return r_horizontalSlider;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle horizontalSliderThumb
		/// </summary>
		protected RUnityEngine.RGUIStyle r_horizontalSliderThumb;
		public virtual RUnityEngine.RGUIStyle RhorizontalSliderThumb
		{
			get
			{
				if(r_horizontalSliderThumb == null)
				{
					r_horizontalSliderThumb = new(this, "horizontalSliderThumb", -1);
					r_horizontalSliderThumb.SetBelong(this.instance);
				}
				return r_horizontalSliderThumb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle horizontalSliderThumbExtent
		/// </summary>
		protected RUnityEngine.RGUIStyle r_horizontalSliderThumbExtent;
		public virtual RUnityEngine.RGUIStyle RhorizontalSliderThumbExtent
		{
			get
			{
				if(r_horizontalSliderThumbExtent == null)
				{
					r_horizontalSliderThumbExtent = new(this, "horizontalSliderThumbExtent", -1);
					r_horizontalSliderThumbExtent.SetBelong(this.instance);
				}
				return r_horizontalSliderThumbExtent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle sliderMixed
		/// </summary>
		protected RUnityEngine.RGUIStyle r_sliderMixed;
		public virtual RUnityEngine.RGUIStyle RsliderMixed
		{
			get
			{
				if(r_sliderMixed == null)
				{
					r_sliderMixed = new(this, "sliderMixed", -1);
					r_sliderMixed.SetBelong(this.instance);
				}
				return r_sliderMixed;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle verticalSlider
		/// </summary>
		protected RUnityEngine.RGUIStyle r_verticalSlider;
		public virtual RUnityEngine.RGUIStyle RverticalSlider
		{
			get
			{
				if(r_verticalSlider == null)
				{
					r_verticalSlider = new(this, "verticalSlider", -1);
					r_verticalSlider.SetBelong(this.instance);
				}
				return r_verticalSlider;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle verticalSliderThumb
		/// </summary>
		protected RUnityEngine.RGUIStyle r_verticalSliderThumb;
		public virtual RUnityEngine.RGUIStyle RverticalSliderThumb
		{
			get
			{
				if(r_verticalSliderThumb == null)
				{
					r_verticalSliderThumb = new(this, "verticalSliderThumb", -1);
					r_verticalSliderThumb.SetBelong(this.instance);
				}
				return r_verticalSliderThumb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle verticalSliderThumbExtent
		/// </summary>
		protected RUnityEngine.RGUIStyle r_verticalSliderThumbExtent;
		public virtual RUnityEngine.RGUIStyle RverticalSliderThumbExtent
		{
			get
			{
				if(r_verticalSliderThumbExtent == null)
				{
					r_verticalSliderThumbExtent = new(this, "verticalSliderThumbExtent", -1);
					r_verticalSliderThumbExtent.SetBelong(this.instance);
				}
				return r_verticalSliderThumbExtent;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle horizontalScrollbar
		/// </summary>
		protected RUnityEngine.RGUIStyle r_horizontalScrollbar;
		public virtual RUnityEngine.RGUIStyle RhorizontalScrollbar
		{
			get
			{
				if(r_horizontalScrollbar == null)
				{
					r_horizontalScrollbar = new(this, "horizontalScrollbar", -1);
					r_horizontalScrollbar.SetBelong(this.instance);
				}
				return r_horizontalScrollbar;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle horizontalScrollbarThumb
		/// </summary>
		protected RUnityEngine.RGUIStyle r_horizontalScrollbarThumb;
		public virtual RUnityEngine.RGUIStyle RhorizontalScrollbarThumb
		{
			get
			{
				if(r_horizontalScrollbarThumb == null)
				{
					r_horizontalScrollbarThumb = new(this, "horizontalScrollbarThumb", -1);
					r_horizontalScrollbarThumb.SetBelong(this.instance);
				}
				return r_horizontalScrollbarThumb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle horizontalScrollbarLeftButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_horizontalScrollbarLeftButton;
		public virtual RUnityEngine.RGUIStyle RhorizontalScrollbarLeftButton
		{
			get
			{
				if(r_horizontalScrollbarLeftButton == null)
				{
					r_horizontalScrollbarLeftButton = new(this, "horizontalScrollbarLeftButton", -1);
					r_horizontalScrollbarLeftButton.SetBelong(this.instance);
				}
				return r_horizontalScrollbarLeftButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle horizontalScrollbarRightButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_horizontalScrollbarRightButton;
		public virtual RUnityEngine.RGUIStyle RhorizontalScrollbarRightButton
		{
			get
			{
				if(r_horizontalScrollbarRightButton == null)
				{
					r_horizontalScrollbarRightButton = new(this, "horizontalScrollbarRightButton", -1);
					r_horizontalScrollbarRightButton.SetBelong(this.instance);
				}
				return r_horizontalScrollbarRightButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle verticalScrollbar
		/// </summary>
		protected RUnityEngine.RGUIStyle r_verticalScrollbar;
		public virtual RUnityEngine.RGUIStyle RverticalScrollbar
		{
			get
			{
				if(r_verticalScrollbar == null)
				{
					r_verticalScrollbar = new(this, "verticalScrollbar", -1);
					r_verticalScrollbar.SetBelong(this.instance);
				}
				return r_verticalScrollbar;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle verticalScrollbarThumb
		/// </summary>
		protected RUnityEngine.RGUIStyle r_verticalScrollbarThumb;
		public virtual RUnityEngine.RGUIStyle RverticalScrollbarThumb
		{
			get
			{
				if(r_verticalScrollbarThumb == null)
				{
					r_verticalScrollbarThumb = new(this, "verticalScrollbarThumb", -1);
					r_verticalScrollbarThumb.SetBelong(this.instance);
				}
				return r_verticalScrollbarThumb;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle verticalScrollbarUpButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_verticalScrollbarUpButton;
		public virtual RUnityEngine.RGUIStyle RverticalScrollbarUpButton
		{
			get
			{
				if(r_verticalScrollbarUpButton == null)
				{
					r_verticalScrollbarUpButton = new(this, "verticalScrollbarUpButton", -1);
					r_verticalScrollbarUpButton.SetBelong(this.instance);
				}
				return r_verticalScrollbarUpButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle verticalScrollbarDownButton
		/// </summary>
		protected RUnityEngine.RGUIStyle r_verticalScrollbarDownButton;
		public virtual RUnityEngine.RGUIStyle RverticalScrollbarDownButton
		{
			get
			{
				if(r_verticalScrollbarDownButton == null)
				{
					r_verticalScrollbarDownButton = new(this, "verticalScrollbarDownButton", -1);
					r_verticalScrollbarDownButton.SetBelong(this.instance);
				}
				return r_verticalScrollbarDownButton;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle scrollView
		/// </summary>
		protected RUnityEngine.RGUIStyle r_scrollView;
		public virtual RUnityEngine.RGUIStyle RscrollView
		{
			get
			{
				if(r_scrollView == null)
				{
					r_scrollView = new(this, "scrollView", -1);
					r_scrollView.SetBelong(this.instance);
				}
				return r_scrollView;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle[] customStyles
		/// </summary>
		protected RPropertyArray<RUnityEngine.RGUIStyle> r_customStyles;
		public virtual RPropertyArray<RUnityEngine.RGUIStyle> RcustomStyles
		{
			get
			{
				if(r_customStyles == null)
				{
					r_customStyles = new(this, "customStyles", -1);
					r_customStyles.SetBelong(this.instance);
				}
				return r_customStyles;
			}
		}

		/// <summary>
		/// UnityEngine.GUISettings settings
		/// </summary>
		protected RUnityEngine.RGUISettings r_settings;
		public virtual RUnityEngine.RGUISettings Rsettings
		{
			get
			{
				if(r_settings == null)
				{
					r_settings = new(this, "settings", -1);
					r_settings.SetBelong(this.instance);
				}
				return r_settings;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle error
		/// </summary>
		protected static RUnityEngine.RGUIStyle r_error;
		public static RUnityEngine.RGUIStyle Rerror
		{
			get
			{
				if(r_error == null)
				{
					r_error = new(typeof(UnityEngine.GUISkin), "error", -1);
					r_error.SetBelong(null);
				}
				return r_error;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RProperty r_name;
		public virtual RProperty Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name", -1);
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// UnityEngine.HideFlags hideFlags
		/// </summary>
		protected RProperty r_hideFlags;
		public virtual RProperty RhideFlags
		{
			get
			{
				if(r_hideFlags == null)
				{
					r_hideFlags = new(this, "hideFlags", -1);
					r_hideFlags.SetBelong(this.instance);
				}
				return r_hideFlags;
			}
		}

		/// <summary>
		/// Void OnEnable()
		/// </summary>
		protected RMethod r_ROnEnable;
		public virtual RMethod ROnEnable
		{
			get
			{
				if(r_ROnEnable == null)
				{
					r_ROnEnable = new(this, "OnEnable", 0);
					r_ROnEnable.SetBelong(this.instance);
				}
				return r_ROnEnable;
			}
		}

		/// <summary>
		/// Void CleanupRoots()
		/// </summary>
		protected static RMethod r_RCleanupRoots;
		public static RMethod RCleanupRoots
		{
			get
			{
				if(r_RCleanupRoots == null)
				{
					r_RCleanupRoots = new(typeof(UnityEngine.GUISkin), "CleanupRoots", 0);
					r_RCleanupRoots.SetBelong(null);
				}
				return r_RCleanupRoots;
			}
		}

		/// <summary>
		/// Void Apply()
		/// </summary>
		protected RMethod r_RApply;
		public virtual RMethod RApply
		{
			get
			{
				if(r_RApply == null)
				{
					r_RApply = new(this, "Apply", 0);
					r_RApply.SetBelong(this.instance);
				}
				return r_RApply;
			}
		}

		/// <summary>
		/// Void BuildStyleCache()
		/// </summary>
		protected RMethod r_RBuildStyleCache;
		public virtual RMethod RBuildStyleCache
		{
			get
			{
				if(r_RBuildStyleCache == null)
				{
					r_RBuildStyleCache = new(this, "BuildStyleCache", 0);
					r_RBuildStyleCache.SetBelong(this.instance);
				}
				return r_RBuildStyleCache;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle GetStyle(System.String)
		/// </summary>
		protected RMethod r_RGetStyle_String;
		public virtual RMethod RGetStyle_String
		{
			get
			{
				if(r_RGetStyle_String == null)
				{
					r_RGetStyle_String = new(this, "GetStyle", 0, typeof(System.String));
					r_RGetStyle_String.SetBelong(this.instance);
				}
				return r_RGetStyle_String;
			}
		}

		/// <summary>
		/// UnityEngine.GUIStyle FindStyle(System.String)
		/// </summary>
		protected RMethod r_RFindStyle_String;
		public virtual RMethod RFindStyle_String
		{
			get
			{
				if(r_RFindStyle_String == null)
				{
					r_RFindStyle_String = new(this, "FindStyle", 0, typeof(System.String));
					r_RFindStyle_String.SetBelong(this.instance);
				}
				return r_RFindStyle_String;
			}
		}

		/// <summary>
		/// Void MakeCurrent()
		/// </summary>
		protected RMethod r_RMakeCurrent;
		public virtual RMethod RMakeCurrent
		{
			get
			{
				if(r_RMakeCurrent == null)
				{
					r_RMakeCurrent = new(this, "MakeCurrent", 0);
					r_RMakeCurrent.SetBelong(this.instance);
				}
				return r_RMakeCurrent;
			}
		}

		/// <summary>
		/// System.Collections.IEnumerator GetEnumerator()
		/// </summary>
		protected RMethod r_RGetEnumerator;
		public virtual RMethod RGetEnumerator
		{
			get
			{
				if(r_RGetEnumerator == null)
				{
					r_RGetEnumerator = new(this, "GetEnumerator", 0);
					r_RGetEnumerator.SetBelong(this.instance);
				}
				return r_RGetEnumerator;
			}
		}

		/// <summary>
		/// Void SetDirty()
		/// </summary>
		protected RMethod r_RSetDirty;
		public virtual RMethod RSetDirty
		{
			get
			{
				if(r_RSetDirty == null)
				{
					r_RSetDirty = new(this, "SetDirty", 0);
					r_RSetDirty.SetBelong(this.instance);
				}
				return r_RSetDirty;
			}
		}

		/// <summary>
		/// Int32 GetInstanceID()
		/// </summary>
		protected RMethod r_RGetInstanceID;
		public virtual RMethod RGetInstanceID
		{
			get
			{
				if(r_RGetInstanceID == null)
				{
					r_RGetInstanceID = new(this, "GetInstanceID", 0);
					r_RGetInstanceID.SetBelong(this.instance);
				}
				return r_RGetInstanceID;
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


        public RGUISkin() : base("UnityEngine.GUISkin")
        {
        }

        public RGUISkin(System.Object instance) : base("UnityEngine.GUISkin")
		{
            SetInstance(instance);
		}

        public RGUISkin(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RGUISkin(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void OnEnable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEnable.Invoke(___genericsType, ___parameters);

            
        }


        public static void CleanupRoots()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCleanupRoots.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Apply()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RApply.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void BuildStyleCache()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RBuildStyleCache.Invoke(___genericsType, ___parameters);

            
        }


        public virtual UnityEngine.GUIStyle GetStyle(System.String  @styleName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleName};
            var ___result = RGetStyle_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual UnityEngine.GUIStyle FindStyle(System.String  @styleName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@styleName};
            var ___result = RFindStyle_String.Invoke(___genericsType, ___parameters);

            return (UnityEngine.GUIStyle)___result;
        }


        public virtual void MakeCurrent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMakeCurrent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Collections.IEnumerator GetEnumerator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEnumerator.Invoke(___genericsType, ___parameters);

            return (System.Collections.IEnumerator)___result;
        }


        public virtual void SetDirty()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDirty.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetInstanceID()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetInstanceID.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @other)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@other};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void Finalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinalize.Invoke(___genericsType, ___parameters);

            
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


    }
}
