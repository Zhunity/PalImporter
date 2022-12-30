using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// SpiritItemConfig
	/// </summary>
    public partial class RSpiritItemConfig : RMember //
    {

		/// <summary>
		/// System.Int32 configID
		/// </summary>
		protected RField r_configID;
		public virtual RField RconfigID
		{
			get
			{
				if(r_configID == null)
				{
					r_configID = new(this, "configID");
					r_configID.SetBelong(this.instance);
				}
				return r_configID;
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
		/// System.String description
		/// </summary>
		protected RField r_description;
		public virtual RField Rdescription
		{
			get
			{
				if(r_description == null)
				{
					r_description = new(this, "description");
					r_description.SetBelong(this.instance);
				}
				return r_description;
			}
		}

		/// <summary>
		/// System.Int32 rare
		/// </summary>
		protected RField r_rare;
		public virtual RField Rrare
		{
			get
			{
				if(r_rare == null)
				{
					r_rare = new(this, "rare");
					r_rare.SetBelong(this.instance);
				}
				return r_rare;
			}
		}

		/// <summary>
		/// System.Int32 skillType
		/// </summary>
		protected RField r_skillType;
		public virtual RField RskillType
		{
			get
			{
				if(r_skillType == null)
				{
					r_skillType = new(this, "skillType");
					r_skillType.SetBelong(this.instance);
				}
				return r_skillType;
			}
		}

		/// <summary>
		/// System.Int32 handleExp
		/// </summary>
		protected RField r_handleExp;
		public virtual RField RhandleExp
		{
			get
			{
				if(r_handleExp == null)
				{
					r_handleExp = new(this, "handleExp");
					r_handleExp.SetBelong(this.instance);
				}
				return r_handleExp;
			}
		}

		/// <summary>
		/// System.String effectPath
		/// </summary>
		protected RField r_effectPath;
		public virtual RField ReffectPath
		{
			get
			{
				if(r_effectPath == null)
				{
					r_effectPath = new(this, "effectPath");
					r_effectPath.SetBelong(this.instance);
				}
				return r_effectPath;
			}
		}

		/// <summary>
		/// System.Int32 exp2
		/// </summary>
		protected RField r_exp2;
		public virtual RField Rexp2
		{
			get
			{
				if(r_exp2 == null)
				{
					r_exp2 = new(this, "exp2");
					r_exp2.SetBelong(this.instance);
				}
				return r_exp2;
			}
		}

		/// <summary>
		/// System.Int32 exp3
		/// </summary>
		protected RField r_exp3;
		public virtual RField Rexp3
		{
			get
			{
				if(r_exp3 == null)
				{
					r_exp3 = new(this, "exp3");
					r_exp3.SetBelong(this.instance);
				}
				return r_exp3;
			}
		}

		/// <summary>
		/// System.Int32 exp4
		/// </summary>
		protected RField r_exp4;
		public virtual RField Rexp4
		{
			get
			{
				if(r_exp4 == null)
				{
					r_exp4 = new(this, "exp4");
					r_exp4.SetBelong(this.instance);
				}
				return r_exp4;
			}
		}

		/// <summary>
		/// System.Int32 exp5
		/// </summary>
		protected RField r_exp5;
		public virtual RField Rexp5
		{
			get
			{
				if(r_exp5 == null)
				{
					r_exp5 = new(this, "exp5");
					r_exp5.SetBelong(this.instance);
				}
				return r_exp5;
			}
		}

		/// <summary>
		/// System.Int32 exp6
		/// </summary>
		protected RField r_exp6;
		public virtual RField Rexp6
		{
			get
			{
				if(r_exp6 == null)
				{
					r_exp6 = new(this, "exp6");
					r_exp6.SetBelong(this.instance);
				}
				return r_exp6;
			}
		}

		/// <summary>
		/// System.Int32 exp7
		/// </summary>
		protected RField r_exp7;
		public virtual RField Rexp7
		{
			get
			{
				if(r_exp7 == null)
				{
					r_exp7 = new(this, "exp7");
					r_exp7.SetBelong(this.instance);
				}
				return r_exp7;
			}
		}

		/// <summary>
		/// System.Int32 exp8
		/// </summary>
		protected RField r_exp8;
		public virtual RField Rexp8
		{
			get
			{
				if(r_exp8 == null)
				{
					r_exp8 = new(this, "exp8");
					r_exp8.SetBelong(this.instance);
				}
				return r_exp8;
			}
		}

		/// <summary>
		/// System.Int32 exp9
		/// </summary>
		protected RField r_exp9;
		public virtual RField Rexp9
		{
			get
			{
				if(r_exp9 == null)
				{
					r_exp9 = new(this, "exp9");
					r_exp9.SetBelong(this.instance);
				}
				return r_exp9;
			}
		}

		/// <summary>
		/// System.Int32 exp10
		/// </summary>
		protected RField r_exp10;
		public virtual RField Rexp10
		{
			get
			{
				if(r_exp10 == null)
				{
					r_exp10 = new(this, "exp10");
					r_exp10.SetBelong(this.instance);
				}
				return r_exp10;
			}
		}

		/// <summary>
		/// System.Int32 exp11
		/// </summary>
		protected RField r_exp11;
		public virtual RField Rexp11
		{
			get
			{
				if(r_exp11 == null)
				{
					r_exp11 = new(this, "exp11");
					r_exp11.SetBelong(this.instance);
				}
				return r_exp11;
			}
		}

		/// <summary>
		/// System.Int32 exp12
		/// </summary>
		protected RField r_exp12;
		public virtual RField Rexp12
		{
			get
			{
				if(r_exp12 == null)
				{
					r_exp12 = new(this, "exp12");
					r_exp12.SetBelong(this.instance);
				}
				return r_exp12;
			}
		}

		/// <summary>
		/// System.Int32 exp13
		/// </summary>
		protected RField r_exp13;
		public virtual RField Rexp13
		{
			get
			{
				if(r_exp13 == null)
				{
					r_exp13 = new(this, "exp13");
					r_exp13.SetBelong(this.instance);
				}
				return r_exp13;
			}
		}

		/// <summary>
		/// System.Int32 exp14
		/// </summary>
		protected RField r_exp14;
		public virtual RField Rexp14
		{
			get
			{
				if(r_exp14 == null)
				{
					r_exp14 = new(this, "exp14");
					r_exp14.SetBelong(this.instance);
				}
				return r_exp14;
			}
		}

		/// <summary>
		/// System.Int32 exp15
		/// </summary>
		protected RField r_exp15;
		public virtual RField Rexp15
		{
			get
			{
				if(r_exp15 == null)
				{
					r_exp15 = new(this, "exp15");
					r_exp15.SetBelong(this.instance);
				}
				return r_exp15;
			}
		}

		/// <summary>
		/// System.Int32 value1
		/// </summary>
		protected RField r_value1;
		public virtual RField Rvalue1
		{
			get
			{
				if(r_value1 == null)
				{
					r_value1 = new(this, "value1");
					r_value1.SetBelong(this.instance);
				}
				return r_value1;
			}
		}

		/// <summary>
		/// System.Int32 value2
		/// </summary>
		protected RField r_value2;
		public virtual RField Rvalue2
		{
			get
			{
				if(r_value2 == null)
				{
					r_value2 = new(this, "value2");
					r_value2.SetBelong(this.instance);
				}
				return r_value2;
			}
		}

		/// <summary>
		/// System.Int32 value3
		/// </summary>
		protected RField r_value3;
		public virtual RField Rvalue3
		{
			get
			{
				if(r_value3 == null)
				{
					r_value3 = new(this, "value3");
					r_value3.SetBelong(this.instance);
				}
				return r_value3;
			}
		}

		/// <summary>
		/// System.Int32 value4
		/// </summary>
		protected RField r_value4;
		public virtual RField Rvalue4
		{
			get
			{
				if(r_value4 == null)
				{
					r_value4 = new(this, "value4");
					r_value4.SetBelong(this.instance);
				}
				return r_value4;
			}
		}

		/// <summary>
		/// System.Int32 value5
		/// </summary>
		protected RField r_value5;
		public virtual RField Rvalue5
		{
			get
			{
				if(r_value5 == null)
				{
					r_value5 = new(this, "value5");
					r_value5.SetBelong(this.instance);
				}
				return r_value5;
			}
		}

		/// <summary>
		/// System.Int32 value6
		/// </summary>
		protected RField r_value6;
		public virtual RField Rvalue6
		{
			get
			{
				if(r_value6 == null)
				{
					r_value6 = new(this, "value6");
					r_value6.SetBelong(this.instance);
				}
				return r_value6;
			}
		}

		/// <summary>
		/// System.Int32 value7
		/// </summary>
		protected RField r_value7;
		public virtual RField Rvalue7
		{
			get
			{
				if(r_value7 == null)
				{
					r_value7 = new(this, "value7");
					r_value7.SetBelong(this.instance);
				}
				return r_value7;
			}
		}

		/// <summary>
		/// System.Int32 value8
		/// </summary>
		protected RField r_value8;
		public virtual RField Rvalue8
		{
			get
			{
				if(r_value8 == null)
				{
					r_value8 = new(this, "value8");
					r_value8.SetBelong(this.instance);
				}
				return r_value8;
			}
		}

		/// <summary>
		/// System.Int32 value9
		/// </summary>
		protected RField r_value9;
		public virtual RField Rvalue9
		{
			get
			{
				if(r_value9 == null)
				{
					r_value9 = new(this, "value9");
					r_value9.SetBelong(this.instance);
				}
				return r_value9;
			}
		}

		/// <summary>
		/// System.Int32 value10
		/// </summary>
		protected RField r_value10;
		public virtual RField Rvalue10
		{
			get
			{
				if(r_value10 == null)
				{
					r_value10 = new(this, "value10");
					r_value10.SetBelong(this.instance);
				}
				return r_value10;
			}
		}

		/// <summary>
		/// System.Int32 value11
		/// </summary>
		protected RField r_value11;
		public virtual RField Rvalue11
		{
			get
			{
				if(r_value11 == null)
				{
					r_value11 = new(this, "value11");
					r_value11.SetBelong(this.instance);
				}
				return r_value11;
			}
		}

		/// <summary>
		/// System.Int32 value12
		/// </summary>
		protected RField r_value12;
		public virtual RField Rvalue12
		{
			get
			{
				if(r_value12 == null)
				{
					r_value12 = new(this, "value12");
					r_value12.SetBelong(this.instance);
				}
				return r_value12;
			}
		}

		/// <summary>
		/// System.Int32 value13
		/// </summary>
		protected RField r_value13;
		public virtual RField Rvalue13
		{
			get
			{
				if(r_value13 == null)
				{
					r_value13 = new(this, "value13");
					r_value13.SetBelong(this.instance);
				}
				return r_value13;
			}
		}

		/// <summary>
		/// System.Int32 value14
		/// </summary>
		protected RField r_value14;
		public virtual RField Rvalue14
		{
			get
			{
				if(r_value14 == null)
				{
					r_value14 = new(this, "value14");
					r_value14.SetBelong(this.instance);
				}
				return r_value14;
			}
		}

		/// <summary>
		/// System.Int32 value15
		/// </summary>
		protected RField r_value15;
		public virtual RField Rvalue15
		{
			get
			{
				if(r_value15 == null)
				{
					r_value15 = new(this, "value15");
					r_value15.SetBelong(this.instance);
				}
				return r_value15;
			}
		}

		/// <summary>
		/// System.String des1
		/// </summary>
		protected RField r_des1;
		public virtual RField Rdes1
		{
			get
			{
				if(r_des1 == null)
				{
					r_des1 = new(this, "des1");
					r_des1.SetBelong(this.instance);
				}
				return r_des1;
			}
		}

		/// <summary>
		/// Boolean IsPercent
		/// </summary>
		protected RProperty r_IsPercent;
		public virtual RProperty RIsPercent
		{
			get
			{
				if(r_IsPercent == null)
				{
					r_IsPercent = new(this, "IsPercent", -1);
					r_IsPercent.SetBelong(this.instance);
				}
				return r_IsPercent;
			}
		}

		/// <summary>
		/// Boolean CanUse
		/// </summary>
		protected RProperty r_CanUse;
		public virtual RProperty RCanUse
		{
			get
			{
				if(r_CanUse == null)
				{
					r_CanUse = new(this, "CanUse", -1);
					r_CanUse.SetBelong(this.instance);
				}
				return r_CanUse;
			}
		}

		/// <summary>
		/// Int32 GetCurrValue(Int32)
		/// </summary>
		protected RMethod r_RGetCurrValue_Int32;
		public virtual RMethod RGetCurrValue_Int32
		{
			get
			{
				if(r_RGetCurrValue_Int32 == null)
				{
					r_RGetCurrValue_Int32 = new(this, "GetCurrValue", 0, typeof(System.Int32));
					r_RGetCurrValue_Int32.SetBelong(this.instance);
				}
				return r_RGetCurrValue_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCurrExp(Int32)
		/// </summary>
		protected RMethod r_RGetCurrExp_Int32;
		public virtual RMethod RGetCurrExp_Int32
		{
			get
			{
				if(r_RGetCurrExp_Int32 == null)
				{
					r_RGetCurrExp_Int32 = new(this, "GetCurrExp", 0, typeof(System.Int32));
					r_RGetCurrExp_Int32.SetBelong(this.instance);
				}
				return r_RGetCurrExp_Int32;
			}
		}

		/// <summary>
		/// System.String GetShowValue(Int32)
		/// </summary>
		protected RMethod r_RGetShowValue_Int32;
		public virtual RMethod RGetShowValue_Int32
		{
			get
			{
				if(r_RGetShowValue_Int32 == null)
				{
					r_RGetShowValue_Int32 = new(this, "GetShowValue", 0, typeof(System.Int32));
					r_RGetShowValue_Int32.SetBelong(this.instance);
				}
				return r_RGetShowValue_Int32;
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


        public RSpiritItemConfig() : base("SpiritItemConfig")
        {
        }

        public RSpiritItemConfig(System.Object instance) : base("SpiritItemConfig")
		{
            SetInstance(instance);
		}

        public RSpiritItemConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RSpiritItemConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual System.Int32 GetCurrValue(System.Int32  @calLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calLevel};
            var ___result = RGetCurrValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetCurrExp(System.Int32  @level)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@level};
            var ___result = RGetCurrExp_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.String GetShowValue(System.Int32  @calLevel)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@calLevel};
            var ___result = RGetShowValue_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
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
