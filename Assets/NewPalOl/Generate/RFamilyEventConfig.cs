using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// FamilyEventConfig
	/// </summary>
    public partial class RFamilyEventConfig : RMember //
    {

		/// <summary>
		/// System.Int32 eid
		/// </summary>
		protected RField r_eid;
		public virtual RField Reid
		{
			get
			{
				if(r_eid == null)
				{
					r_eid = new(this, "eid");
					r_eid.SetBelong(this.instance);
				}
				return r_eid;
			}
		}

		/// <summary>
		/// System.String name
		/// </summary>
		protected RField r_name;
		public virtual RField Rname
		{
			get
			{
				if(r_name == null)
				{
					r_name = new(this, "name");
					r_name.SetBelong(this.instance);
				}
				return r_name;
			}
		}

		/// <summary>
		/// System.String icon
		/// </summary>
		protected RField r_icon;
		public virtual RField Ricon
		{
			get
			{
				if(r_icon == null)
				{
					r_icon = new(this, "icon");
					r_icon.SetBelong(this.instance);
				}
				return r_icon;
			}
		}

		/// <summary>
		/// System.String otherIcon
		/// </summary>
		protected RField r_otherIcon;
		public virtual RField RotherIcon
		{
			get
			{
				if(r_otherIcon == null)
				{
					r_otherIcon = new(this, "otherIcon");
					r_otherIcon.SetBelong(this.instance);
				}
				return r_otherIcon;
			}
		}

		/// <summary>
		/// System.String reward
		/// </summary>
		protected RField r_reward;
		public virtual RField Rreward
		{
			get
			{
				if(r_reward == null)
				{
					r_reward = new(this, "reward");
					r_reward.SetBelong(this.instance);
				}
				return r_reward;
			}
		}

		/// <summary>
		/// System.String stepName1Tribe1
		/// </summary>
		protected RField r_stepName1Tribe1;
		public virtual RField RstepName1Tribe1
		{
			get
			{
				if(r_stepName1Tribe1 == null)
				{
					r_stepName1Tribe1 = new(this, "stepName1Tribe1");
					r_stepName1Tribe1.SetBelong(this.instance);
				}
				return r_stepName1Tribe1;
			}
		}

		/// <summary>
		/// System.String stepName1Tribe2
		/// </summary>
		protected RField r_stepName1Tribe2;
		public virtual RField RstepName1Tribe2
		{
			get
			{
				if(r_stepName1Tribe2 == null)
				{
					r_stepName1Tribe2 = new(this, "stepName1Tribe2");
					r_stepName1Tribe2.SetBelong(this.instance);
				}
				return r_stepName1Tribe2;
			}
		}

		/// <summary>
		/// System.String stepName1Tribe3
		/// </summary>
		protected RField r_stepName1Tribe3;
		public virtual RField RstepName1Tribe3
		{
			get
			{
				if(r_stepName1Tribe3 == null)
				{
					r_stepName1Tribe3 = new(this, "stepName1Tribe3");
					r_stepName1Tribe3.SetBelong(this.instance);
				}
				return r_stepName1Tribe3;
			}
		}

		/// <summary>
		/// System.String stepName1Tribe4
		/// </summary>
		protected RField r_stepName1Tribe4;
		public virtual RField RstepName1Tribe4
		{
			get
			{
				if(r_stepName1Tribe4 == null)
				{
					r_stepName1Tribe4 = new(this, "stepName1Tribe4");
					r_stepName1Tribe4.SetBelong(this.instance);
				}
				return r_stepName1Tribe4;
			}
		}

		/// <summary>
		/// System.String stepName2Tribe1
		/// </summary>
		protected RField r_stepName2Tribe1;
		public virtual RField RstepName2Tribe1
		{
			get
			{
				if(r_stepName2Tribe1 == null)
				{
					r_stepName2Tribe1 = new(this, "stepName2Tribe1");
					r_stepName2Tribe1.SetBelong(this.instance);
				}
				return r_stepName2Tribe1;
			}
		}

		/// <summary>
		/// System.String stepName2Tribe2
		/// </summary>
		protected RField r_stepName2Tribe2;
		public virtual RField RstepName2Tribe2
		{
			get
			{
				if(r_stepName2Tribe2 == null)
				{
					r_stepName2Tribe2 = new(this, "stepName2Tribe2");
					r_stepName2Tribe2.SetBelong(this.instance);
				}
				return r_stepName2Tribe2;
			}
		}

		/// <summary>
		/// System.String stepName2Tribe3
		/// </summary>
		protected RField r_stepName2Tribe3;
		public virtual RField RstepName2Tribe3
		{
			get
			{
				if(r_stepName2Tribe3 == null)
				{
					r_stepName2Tribe3 = new(this, "stepName2Tribe3");
					r_stepName2Tribe3.SetBelong(this.instance);
				}
				return r_stepName2Tribe3;
			}
		}

		/// <summary>
		/// System.String stepName2Tribe4
		/// </summary>
		protected RField r_stepName2Tribe4;
		public virtual RField RstepName2Tribe4
		{
			get
			{
				if(r_stepName2Tribe4 == null)
				{
					r_stepName2Tribe4 = new(this, "stepName2Tribe4");
					r_stepName2Tribe4.SetBelong(this.instance);
				}
				return r_stepName2Tribe4;
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


        public RFamilyEventConfig() : base("FamilyEventConfig")
        {
        }

        public RFamilyEventConfig(System.Object instance) : base("FamilyEventConfig")
		{
            SetInstance(instance);
		}

        public RFamilyEventConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RFamilyEventConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
