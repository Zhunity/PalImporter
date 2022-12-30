using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// StrengthenConfig
	/// </summary>
    public partial class RStrengthenConfig : RMember //
    {

		/// <summary>
		/// System.Int32 id
		/// </summary>
		protected RField r_id;
		public virtual RField Rid
		{
			get
			{
				if(r_id == null)
				{
					r_id = new(this, "id");
					r_id.SetBelong(this.instance);
				}
				return r_id;
			}
		}

		/// <summary>
		/// System.Int32 hunjie
		/// </summary>
		protected RField r_hunjie;
		public virtual RField Rhunjie
		{
			get
			{
				if(r_hunjie == null)
				{
					r_hunjie = new(this, "hunjie");
					r_hunjie.SetBelong(this.instance);
				}
				return r_hunjie;
			}
		}

		/// <summary>
		/// System.Int32 jinjie
		/// </summary>
		protected RField r_jinjie;
		public virtual RField Rjinjie
		{
			get
			{
				if(r_jinjie == null)
				{
					r_jinjie = new(this, "jinjie");
					r_jinjie.SetBelong(this.instance);
				}
				return r_jinjie;
			}
		}

		/// <summary>
		/// System.Int32 qianghua
		/// </summary>
		protected RField r_qianghua;
		public virtual RField Rqianghua
		{
			get
			{
				if(r_qianghua == null)
				{
					r_qianghua = new(this, "qianghua");
					r_qianghua.SetBelong(this.instance);
				}
				return r_qianghua;
			}
		}

		/// <summary>
		/// System.Int32 shengxing
		/// </summary>
		protected RField r_shengxing;
		public virtual RField Rshengxing
		{
			get
			{
				if(r_shengxing == null)
				{
					r_shengxing = new(this, "shengxing");
					r_shengxing.SetBelong(this.instance);
				}
				return r_shengxing;
			}
		}

		/// <summary>
		/// System.Int32 wulinglun
		/// </summary>
		protected RField r_wulinglun;
		public virtual RField Rwulinglun
		{
			get
			{
				if(r_wulinglun == null)
				{
					r_wulinglun = new(this, "wulinglun");
					r_wulinglun.SetBelong(this.instance);
				}
				return r_wulinglun;
			}
		}

		/// <summary>
		/// System.Int32 xianchong
		/// </summary>
		protected RField r_xianchong;
		public virtual RField Rxianchong
		{
			get
			{
				if(r_xianchong == null)
				{
					r_xianchong = new(this, "xianchong");
					r_xianchong.SetBelong(this.instance);
				}
				return r_xianchong;
			}
		}

		/// <summary>
		/// System.Int32 xianling
		/// </summary>
		protected RField r_xianling;
		public virtual RField Rxianling
		{
			get
			{
				if(r_xianling == null)
				{
					r_xianling = new(this, "xianling");
					r_xianling.SetBelong(this.instance);
				}
				return r_xianling;
			}
		}

		/// <summary>
		/// System.Int32 yuanshen
		/// </summary>
		protected RField r_yuanshen;
		public virtual RField Ryuanshen
		{
			get
			{
				if(r_yuanshen == null)
				{
					r_yuanshen = new(this, "yuanshen");
					r_yuanshen.SetBelong(this.instance);
				}
				return r_yuanshen;
			}
		}

		/// <summary>
		/// System.Int32 zhanli
		/// </summary>
		protected RField r_zhanli;
		public virtual RField Rzhanli
		{
			get
			{
				if(r_zhanli == null)
				{
					r_zhanli = new(this, "zhanli");
					r_zhanli.SetBelong(this.instance);
				}
				return r_zhanli;
			}
		}

		/// <summary>
		/// System.Int32 zuoqi
		/// </summary>
		protected RField r_zuoqi;
		public virtual RField Rzuoqi
		{
			get
			{
				if(r_zuoqi == null)
				{
					r_zuoqi = new(this, "zuoqi");
					r_zuoqi.SetBelong(this.instance);
				}
				return r_zuoqi;
			}
		}

		/// <summary>
		/// System.Int32 zhuangbeidengji
		/// </summary>
		protected RField r_zhuangbeidengji;
		public virtual RField Rzhuangbeidengji
		{
			get
			{
				if(r_zhuangbeidengji == null)
				{
					r_zhuangbeidengji = new(this, "zhuangbeidengji");
					r_zhuangbeidengji.SetBelong(this.instance);
				}
				return r_zhuangbeidengji;
			}
		}

		/// <summary>
		/// System.Int32 huobanshuliang
		/// </summary>
		protected RField r_huobanshuliang;
		public virtual RField Rhuobanshuliang
		{
			get
			{
				if(r_huobanshuliang == null)
				{
					r_huobanshuliang = new(this, "huobanshuliang");
					r_huobanshuliang.SetBelong(this.instance);
				}
				return r_huobanshuliang;
			}
		}

		/// <summary>
		/// System.Int32 huobanpinzhi
		/// </summary>
		protected RField r_huobanpinzhi;
		public virtual RField Rhuobanpinzhi
		{
			get
			{
				if(r_huobanpinzhi == null)
				{
					r_huobanpinzhi = new(this, "huobanpinzhi");
					r_huobanpinzhi.SetBelong(this.instance);
				}
				return r_huobanpinzhi;
			}
		}

		/// <summary>
		/// System.Int32 huobandengji
		/// </summary>
		protected RField r_huobandengji;
		public virtual RField Rhuobandengji
		{
			get
			{
				if(r_huobandengji == null)
				{
					r_huobandengji = new(this, "huobandengji");
					r_huobandengji.SetBelong(this.instance);
				}
				return r_huobandengji;
			}
		}

		/// <summary>
		/// System.Int32 zhuangbeipinzhi
		/// </summary>
		protected RField r_zhuangbeipinzhi;
		public virtual RField Rzhuangbeipinzhi
		{
			get
			{
				if(r_zhuangbeipinzhi == null)
				{
					r_zhuangbeipinzhi = new(this, "zhuangbeipinzhi");
					r_zhuangbeipinzhi.SetBelong(this.instance);
				}
				return r_zhuangbeipinzhi;
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


        public RStrengthenConfig() : base("StrengthenConfig")
        {
        }

        public RStrengthenConfig(System.Object instance) : base("StrengthenConfig")
		{
            SetInstance(instance);
		}

        public RStrengthenConfig(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStrengthenConfig(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
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
