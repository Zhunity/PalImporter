using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction
{
	/// <summary>
	/// Texture2Dx
	/// </summary>
    public partial class RTexture2Dx : RMember //
    {

		/// <summary>
		/// UnityEngine.Texture2D Resize(UnityEngine.Texture2D, Int32, Int32)
		/// </summary>
		protected static RMethod r_RResize_Texture2D_Int32_Int32;
		public static RMethod RResize_Texture2D_Int32_Int32
		{
			get
			{
				if(r_RResize_Texture2D_Int32_Int32 == null)
				{
					r_RResize_Texture2D_Int32_Int32 = new(typeof(Texture2Dx), "Resize", 0, typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32));
					r_RResize_Texture2D_Int32_Int32.SetBelong(null);
				}
				return r_RResize_Texture2D_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D Tile(UnityEngine.Texture2D, Int32, Int32)
		/// </summary>
		protected static RMethod r_RTile_Texture2D_Int32_Int32;
		public static RMethod RTile_Texture2D_Int32_Int32
		{
			get
			{
				if(r_RTile_Texture2D_Int32_Int32 == null)
				{
					r_RTile_Texture2D_Int32_Int32 = new(typeof(Texture2Dx), "Tile", 0, typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32));
					r_RTile_Texture2D_Int32_Int32.SetBelong(null);
				}
				return r_RTile_Texture2D_Int32_Int32;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D Crop(UnityEngine.Texture2D, Int32, Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_RCrop_Texture2D_Int32_Int32_Int32_Int32;
		public static RMethod RCrop_Texture2D_Int32_Int32_Int32_Int32
		{
			get
			{
				if(r_RCrop_Texture2D_Int32_Int32_Int32_Int32 == null)
				{
					r_RCrop_Texture2D_Int32_Int32_Int32_Int32 = new(typeof(Texture2Dx), "Crop", 0, typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RCrop_Texture2D_Int32_Int32_Int32_Int32.SetBelong(null);
				}
				return r_RCrop_Texture2D_Int32_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean #tNb(UnityEngine.Color, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_R__0__tNb_Color_Color;
		public static RMethod R__0__tNb_Color_Color
		{
			get
			{
				if(r_R__0__tNb_Color_Color == null)
				{
					r_R__0__tNb_Color_Color = new(typeof(Texture2Dx), "#tNb", 0, typeof(UnityEngine.Color), typeof(UnityEngine.Color));
					r_R__0__tNb_Color_Color.SetBelong(null);
				}
				return r_R__0__tNb_Color_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D AutoCrop(UnityEngine.Texture2D, UnityEngine.Color)
		/// </summary>
		protected static RMethod r_RAutoCrop_Texture2D_Color;
		public static RMethod RAutoCrop_Texture2D_Color
		{
			get
			{
				if(r_RAutoCrop_Texture2D_Color == null)
				{
					r_RAutoCrop_Texture2D_Color = new(typeof(Texture2Dx), "AutoCrop", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Color));
					r_RAutoCrop_Texture2D_Color.SetBelong(null);
				}
				return r_RAutoCrop_Texture2D_Color;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D FlipHorizontally(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RFlipHorizontally_Texture2D;
		public static RMethod RFlipHorizontally_Texture2D
		{
			get
			{
				if(r_RFlipHorizontally_Texture2D == null)
				{
					r_RFlipHorizontally_Texture2D = new(typeof(Texture2Dx), "FlipHorizontally", 0, typeof(UnityEngine.Texture2D));
					r_RFlipHorizontally_Texture2D.SetBelong(null);
				}
				return r_RFlipHorizontally_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D FlipVertically(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RFlipVertically_Texture2D;
		public static RMethod RFlipVertically_Texture2D
		{
			get
			{
				if(r_RFlipVertically_Texture2D == null)
				{
					r_RFlipVertically_Texture2D = new(typeof(Texture2Dx), "FlipVertically", 0, typeof(UnityEngine.Texture2D));
					r_RFlipVertically_Texture2D.SetBelong(null);
				}
				return r_RFlipVertically_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D RotateClockwise90Degrees(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RRotateClockwise90Degrees_Texture2D;
		public static RMethod RRotateClockwise90Degrees_Texture2D
		{
			get
			{
				if(r_RRotateClockwise90Degrees_Texture2D == null)
				{
					r_RRotateClockwise90Degrees_Texture2D = new(typeof(Texture2Dx), "RotateClockwise90Degrees", 0, typeof(UnityEngine.Texture2D));
					r_RRotateClockwise90Degrees_Texture2D.SetBelong(null);
				}
				return r_RRotateClockwise90Degrees_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D RotateCounterClockwise90Degrees(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RRotateCounterClockwise90Degrees_Texture2D;
		public static RMethod RRotateCounterClockwise90Degrees_Texture2D
		{
			get
			{
				if(r_RRotateCounterClockwise90Degrees_Texture2D == null)
				{
					r_RRotateCounterClockwise90Degrees_Texture2D = new(typeof(Texture2Dx), "RotateCounterClockwise90Degrees", 0, typeof(UnityEngine.Texture2D));
					r_RRotateCounterClockwise90Degrees_Texture2D.SetBelong(null);
				}
				return r_RRotateCounterClockwise90Degrees_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D Transpose(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RTranspose_Texture2D;
		public static RMethod RTranspose_Texture2D
		{
			get
			{
				if(r_RTranspose_Texture2D == null)
				{
					r_RTranspose_Texture2D = new(typeof(Texture2Dx), "Transpose", 0, typeof(UnityEngine.Texture2D));
					r_RTranspose_Texture2D.SetBelong(null);
				}
				return r_RTranspose_Texture2D;
			}
		}

		/// <summary>
		/// UnityEngine.Texture2D TransposePerpendicular(UnityEngine.Texture2D)
		/// </summary>
		protected static RMethod r_RTransposePerpendicular_Texture2D;
		public static RMethod RTransposePerpendicular_Texture2D
		{
			get
			{
				if(r_RTransposePerpendicular_Texture2D == null)
				{
					r_RTransposePerpendicular_Texture2D = new(typeof(Texture2Dx), "TransposePerpendicular", 0, typeof(UnityEngine.Texture2D));
					r_RTransposePerpendicular_Texture2D.SetBelong(null);
				}
				return r_RTransposePerpendicular_Texture2D;
			}
		}

		/// <summary>
		/// Void Blit(UnityEngine.Texture2D, UnityEngine.Texture2D, Int32, Int32)
		/// </summary>
		protected static RMethod r_RBlit_Texture2D_Texture2D_Int32_Int32;
		public static RMethod RBlit_Texture2D_Texture2D_Int32_Int32
		{
			get
			{
				if(r_RBlit_Texture2D_Texture2D_Int32_Int32 == null)
				{
					r_RBlit_Texture2D_Texture2D_Int32_Int32 = new(typeof(Texture2Dx), "Blit", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32));
					r_RBlit_Texture2D_Texture2D_Int32_Int32.SetBelong(null);
				}
				return r_RBlit_Texture2D_Texture2D_Int32_Int32;
			}
		}

		/// <summary>
		/// Void BlitAlpha(UnityEngine.Texture2D, UnityEngine.Texture2D, Int32, Int32)
		/// </summary>
		protected static RMethod r_RBlitAlpha_Texture2D_Texture2D_Int32_Int32;
		public static RMethod RBlitAlpha_Texture2D_Texture2D_Int32_Int32
		{
			get
			{
				if(r_RBlitAlpha_Texture2D_Texture2D_Int32_Int32 == null)
				{
					r_RBlitAlpha_Texture2D_Texture2D_Int32_Int32 = new(typeof(Texture2Dx), "BlitAlpha", 0, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Texture2D), typeof(System.Int32), typeof(System.Int32));
					r_RBlitAlpha_Texture2D_Texture2D_Int32_Int32.SetBelong(null);
				}
				return r_RBlitAlpha_Texture2D_Texture2D_Int32_Int32;
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


        public RTexture2Dx() : base("Texture2Dx")
        {
        }

        public RTexture2Dx(System.Object instance) : base("Texture2Dx")
		{
            SetInstance(instance);
		}

        public RTexture2Dx(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTexture2Dx(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static UnityEngine.Texture2D Resize(UnityEngine.Texture2D  @texture, System.Int32  @newWidth, System.Int32  @newHeight)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @newWidth, @newHeight};
            var ___result = RResize_Texture2D_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static UnityEngine.Texture2D Tile(UnityEngine.Texture2D  @texture, System.Int32  @horizontalTiles, System.Int32  @verticalTiles)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @horizontalTiles, @verticalTiles};
            var ___result = RTile_Texture2D_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static UnityEngine.Texture2D Crop(UnityEngine.Texture2D  @texture, System.Int32  @x, System.Int32  @y, System.Int32  @width, System.Int32  @height)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @x, @y, @width, @height};
            var ___result = RCrop_Texture2D_Int32_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static System.Boolean __0__tNb(UnityEngine.Color  @a, UnityEngine.Color  @b)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@a, @b};
            var ___result = R__0__tNb_Color_Color.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static UnityEngine.Texture2D AutoCrop(UnityEngine.Texture2D  @texture, UnityEngine.Color  @borderColor)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture, @borderColor};
            var ___result = RAutoCrop_Texture2D_Color.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static UnityEngine.Texture2D FlipHorizontally(UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RFlipHorizontally_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static UnityEngine.Texture2D FlipVertically(UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RFlipVertically_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static UnityEngine.Texture2D RotateClockwise90Degrees(UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RRotateClockwise90Degrees_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static UnityEngine.Texture2D RotateCounterClockwise90Degrees(UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RRotateCounterClockwise90Degrees_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static UnityEngine.Texture2D Transpose(UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RTranspose_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static UnityEngine.Texture2D TransposePerpendicular(UnityEngine.Texture2D  @texture)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@texture};
            var ___result = RTransposePerpendicular_Texture2D.Invoke(___genericsType, ___parameters);

            return (UnityEngine.Texture2D)___result;
        }


        public static void Blit(UnityEngine.Texture2D  @dst, UnityEngine.Texture2D  @src, System.Int32  @offsetX, System.Int32  @offsetY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dst, @src, @offsetX, @offsetY};
            var ___result = RBlit_Texture2D_Texture2D_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void BlitAlpha(UnityEngine.Texture2D  @dstTexture, UnityEngine.Texture2D  @srcTexture, System.Int32  @offsetX, System.Int32  @offsetY)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@dstTexture, @srcTexture, @offsetX, @offsetY};
            var ___result = RBlitAlpha_Texture2D_Texture2D_Int32_Int32.Invoke(___genericsType, ___parameters);

            
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
