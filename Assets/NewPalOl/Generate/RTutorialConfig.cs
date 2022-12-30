using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// TutorialConfig
	/// </summary>
    public partial class RTutorialConfig : RMember //
    {

		/// <summary>
		/// System.Int32 tid
		/// </summary>
		protected RField r_tid;
		public virtual RField Rtid
		{
			get
			{
				if(r_tid == null)
				{
					r_tid = new(this, "tid");
					r_tid.SetBelong(this.instance);
				}
				return r_tid;
			}
		}

		/// <summary>
		/// System.Int32 subId
		/// </summary>
		protected RField r_subId;
		public virtual RField RsubId
		{
			get
			{
				if(r_subId == null)
				{
					r_subId = new(this, "subId");
					r_subId.SetBelong(this.instance);
				}
				return r_subId;
			}
		}

		/// <summary>
		/// TutorialConfig+TUTORIAL_TYPE Type
		/// </summary>
		protected RField r_Type;
		public virtual RField RType
		{
			get
			{
				if(r_Type == null)
				{
					r_Type = new(this, "Type");
					r_Type.SetBelong(this.instance);
				}
				return r_Type;
			}
		}

		/// <summary>
		/// System.String Tutorial_title
		/// </summary>
		protected RField r_Tutorial_title;
		public virtual RField RTutorial_title
		{
			get
			{
				if(r_Tutorial_title == null)
				{
					r_Tutorial_title = new(this, "Tutorial_title");
					r_Tutorial_title.SetBelong(this.instance);
				}
				return r_Tutorial_title;
			}
		}

		/// <summary>
		/// System.String Tutorial_text
		/// </summary>
		protected RField r_Tutorial_text;
		public virtual RField RTutorial_text
		{
			get
			{
				if(r_Tutorial_text == null)
				{
					r_Tutorial_text = new(this, "Tutorial_text");
					r_Tutorial_text.SetBelong(this.instance);
				}
				return r_Tutorial_text;
			}
		}

		/// <summary>
		/// System.String Tutorial_button_type
		/// </summary>
		protected RField r_Tutorial_button_type;
		public virtual RField RTutorial_button_type
		{
			get
			{
				if(r_Tutorial_button_type == null)
				{
					r_Tutorial_button_type = new(this, "Tutorial_button_type");
					r_Tutorial_button_type.SetBelong(this.instance);
				}
				return r_Tutorial_button_type;
			}
		}

		/// <summary>
		/// System.String Tutorial_pic_type
		/// </summary>
		protected RField r_Tutorial_pic_type;
		public virtual RField RTutorial_pic_type
		{
			get
			{
				if(r_Tutorial_pic_type == null)
				{
					r_Tutorial_pic_type = new(this, "Tutorial_pic_type");
					r_Tutorial_pic_type.SetBelong(this.instance);
				}
				return r_Tutorial_pic_type;
			}
		}

		/// <summary>
		/// System.Int32 Tutorial_item_type
		/// </summary>
		protected RField r_Tutorial_item_type;
		public virtual RField RTutorial_item_type
		{
			get
			{
				if(r_Tutorial_item_type == null)
				{
					r_Tutorial_item_type = new(this, "Tutorial_item_type");
					r_Tutorial_item_type.SetBelong(this.instance);
				}
				return r_Tutorial_item_type;
			}
		}

		/// <summary>
		/// System.Int32 Tutorial_item_id
		/// </summary>
		protected RField r_Tutorial_item_id;
		public virtual RField RTutorial_item_id
		{
			get
			{
				if(r_Tutorial_item_id == null)
				{
					r_Tutorial_item_id = new(this, "Tutorial_item_id");
					r_Tutorial_item_id.SetBelong(this.instance);
				}
				return r_Tutorial_item_id;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Tutorial_bar_location
		/// </summary>
		protected RUnityEngine.RVector2 r_Tutorial_bar_location;
		public virtual RUnityEngine.RVector2 RTutorial_bar_location
		{
			get
			{
				if(r_Tutorial_bar_location == null)
				{
					r_Tutorial_bar_location = new(this, "Tutorial_bar_location");
					r_Tutorial_bar_location.SetBelong(this.instance);
				}
				return r_Tutorial_bar_location;
			}
		}

		/// <summary>
		/// System.Int32 Tutorial_arrow_angle
		/// </summary>
		protected RField r_Tutorial_arrow_angle;
		public virtual RField RTutorial_arrow_angle
		{
			get
			{
				if(r_Tutorial_arrow_angle == null)
				{
					r_Tutorial_arrow_angle = new(this, "Tutorial_arrow_angle");
					r_Tutorial_arrow_angle.SetBelong(this.instance);
				}
				return r_Tutorial_arrow_angle;
			}
		}

		/// <summary>
		/// System.String Tutorial_target_widget
		/// </summary>
		protected RField r_Tutorial_target_widget;
		public virtual RField RTutorial_target_widget
		{
			get
			{
				if(r_Tutorial_target_widget == null)
				{
					r_Tutorial_target_widget = new(this, "Tutorial_target_widget");
					r_Tutorial_target_widget.SetBelong(this.instance);
				}
				return r_Tutorial_target_widget;
			}
		}

		/// <summary>
		/// System.String Tutorial_target_button_name
		/// </summary>
		protected RField r_Tutorial_target_button_name;
		public virtual RField RTutorial_target_button_name
		{
			get
			{
				if(r_Tutorial_target_button_name == null)
				{
					r_Tutorial_target_button_name = new(this, "Tutorial_target_button_name");
					r_Tutorial_target_button_name.SetBelong(this.instance);
				}
				return r_Tutorial_target_button_name;
			}
		}

		/// <summary>
		/// System.Boolean Tutorial_target_widget_effect
		/// </summary>
		protected RField r_Tutorial_target_widget_effect;
		public virtual RField RTutorial_target_widget_effect
		{
			get
			{
				if(r_Tutorial_target_widget_effect == null)
				{
					r_Tutorial_target_widget_effect = new(this, "Tutorial_target_widget_effect");
					r_Tutorial_target_widget_effect.SetBelong(this.instance);
				}
				return r_Tutorial_target_widget_effect;
			}
		}

		/// <summary>
		/// UnityEngine.Vector2 Tutorial_item_location
		/// </summary>
		protected RUnityEngine.RVector2 r_Tutorial_item_location;
		public virtual RUnityEngine.RVector2 RTutorial_item_location
		{
			get
			{
				if(r_Tutorial_item_location == null)
				{
					r_Tutorial_item_location = new(this, "Tutorial_item_location");
					r_Tutorial_item_location.SetBelong(this.instance);
				}
				return r_Tutorial_item_location;
			}
		}

		/// <summary>
		/// System.Single Tutorial_timer
		/// </summary>
		protected RField r_Tutorial_timer;
		public virtual RField RTutorial_timer
		{
			get
			{
				if(r_Tutorial_timer == null)
				{
					r_Tutorial_timer = new(this, "Tutorial_timer");
					r_Tutorial_timer.SetBelong(this.instance);
				}
				return r_Tutorial_timer;
			}
		}

		/// <summary>
		/// System.Int32 Tutorial_next_step
		/// </summary>
		protected RField r_Tutorial_next_step;
		public virtual RField RTutorial_next_step
		{
			get
			{
				if(r_Tutorial_next_step == null)
				{
					r_Tutorial_next_step = new(this, "Tutorial_next_step");
					r_Tutorial_next_step.SetBelong(this.instance);
				}
				return r_Tutorial_next_step;
			}
		}

		/// <summary>
		/// System.Int32 Tutorial_task_id
		/// </summary>
		protected RField r_Tutorial_task_id;
		public virtual RField RTutorial_task_id
		{
			get
			{
				if(r_Tutorial_task_id == null)
				{
					r_Tutorial_task_id = new(this, "Tutorial_task_id");
					r_Tutorial_task_id.SetBelong(this.instance);
				}
				return r_Tutorial_task_id;
			}
		}

		/// <summary>
		/// System.Int32 Tutorial_click_button
		/// </summary>
		protected RField r_Tutorial_click_button;
		public virtual RField RTutorial_click_button
		{
			get
			{
				if(r_Tutorial_click_button == null)
				{
					r_Tutorial_click_button = new(this, "Tutorial_click_button");
					r_Tutorial_click_button.SetBelong(this.instance);
				}
				return r_Tutorial_click_button;
			}
		}

		/// <summary>
		/// System.Boolean Tutorial_open_window
		/// </summary>
		protected RField r_Tutorial_open_window;
		public virtual RField RTutorial_open_window
		{
			get
			{
				if(r_Tutorial_open_window == null)
				{
					r_Tutorial_open_window = new(this, "Tutorial_open_window");
					r_Tutorial_open_window.SetBelong(this.instance);
				}
				return r_Tutorial_open_window;
			}
		}

		/// <summary>
		/// System.Boolean IsTutorialClickEnd
		/// </summary>
		protected RField r_IsTutorialClickEnd;
		public virtual RField RIsTutorialClickEnd
		{
			get
			{
				if(r_IsTutorialClickEnd == null)
				{
					r_IsTutorialClickEnd = new(this, "IsTutorialClickEnd");
					r_IsTutorialClickEnd.SetBelong(this.instance);
				}
				return r_IsTutorialClickEnd;
			}
		}

		/// <summary>
		/// System.Int32 tutorial_force
		/// </summary>
		protected RField r_tutorial_force;
		public virtual RField Rtutorial_force
		{
			get
			{
				if(r_tutorial_force == null)
				{
					r_tutorial_force = new(this, "tutorial_force");
					r_tutorial_force.SetBelong(this.instance);
				}
				return r_tutorial_force;
			}
		}

		/// <summary>
		/// System.String conflict_window
		/// </summary>
		protected RField r_conflict_window;
		public virtual RField Rconflict_window
		{
			get
			{
				if(r_conflict_window == null)
				{
					r_conflict_window = new(this, "conflict_window");
					r_conflict_window.SetBelong(this.instance);
				}
				return r_conflict_window;
			}
		}

		/// <summary>
		/// System.Int32 Tutorial_skiptask_id
		/// </summary>
		protected RField r_Tutorial_skiptask_id;
		public virtual RField RTutorial_skiptask_id
		{
			get
			{
				if(r_Tutorial_skiptask_id == null)
				{
					r_Tutorial_skiptask_id = new(this, "Tutorial_skiptask_id");
					r_Tutorial_skiptask_id.SetBelong(this.instance);
				}
				return r_Tutorial_skiptask_id;
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


        public RTutorialConfig() : base("TutorialConfig")
        {
        }

        public RTutorialConfig(System.Object instance) : base("TutorialConfig")
		{
            SetInstance(instance);
		}

        public RTutorialConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTutorialConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
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
