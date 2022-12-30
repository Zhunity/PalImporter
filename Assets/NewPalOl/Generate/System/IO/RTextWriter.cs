using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
	/// System.IO.TextWriter
	/// </summary>
    public partial class RTextWriter : RMember //
    {

		/// <summary>
		/// System.IO.TextWriter Null
		/// </summary>
		protected static RSystem.RIO.RTextWriter r_Null;
		public static RSystem.RIO.RTextWriter RNull
		{
			get
			{
				if(r_Null == null)
				{
					r_Null = new(typeof(System.IO.TextWriter), "Null");
					r_Null.SetBelong(null);
				}
				return r_Null;
			}
		}

		/// <summary>
		/// System.Char[] s_coreNewLine
		/// </summary>
		protected static RFieldArray<RField> r_s_coreNewLine;
		public static RFieldArray<RField> Rs_coreNewLine
		{
			get
			{
				if(r_s_coreNewLine == null)
				{
					r_s_coreNewLine = new(typeof(System.IO.TextWriter), "s_coreNewLine");
					r_s_coreNewLine.SetBelong(null);
				}
				return r_s_coreNewLine;
			}
		}

		/// <summary>
		/// System.Char[] CoreNewLine
		/// </summary>
		protected RFieldArray<RField> r_CoreNewLine;
		public virtual RFieldArray<RField> RCoreNewLine
		{
			get
			{
				if(r_CoreNewLine == null)
				{
					r_CoreNewLine = new(this, "CoreNewLine");
					r_CoreNewLine.SetBelong(this.instance);
				}
				return r_CoreNewLine;
			}
		}

		/// <summary>
		/// System.String CoreNewLineStr
		/// </summary>
		protected RField r_CoreNewLineStr;
		public virtual RField RCoreNewLineStr
		{
			get
			{
				if(r_CoreNewLineStr == null)
				{
					r_CoreNewLineStr = new(this, "CoreNewLineStr");
					r_CoreNewLineStr.SetBelong(this.instance);
				}
				return r_CoreNewLineStr;
			}
		}

		/// <summary>
		/// System.IFormatProvider _internalFormatProvider
		/// </summary>
		protected RSystem.RIFormatProvider r__internalFormatProvider;
		public virtual RSystem.RIFormatProvider R_internalFormatProvider
		{
			get
			{
				if(r__internalFormatProvider == null)
				{
					r__internalFormatProvider = new(this, "_internalFormatProvider");
					r__internalFormatProvider.SetBelong(this.instance);
				}
				return r__internalFormatProvider;
			}
		}

		/// <summary>
		/// System.IFormatProvider FormatProvider
		/// </summary>
		protected RSystem.RIFormatProvider r_FormatProvider;
		public virtual RSystem.RIFormatProvider RFormatProvider
		{
			get
			{
				if(r_FormatProvider == null)
				{
					r_FormatProvider = new(this, "FormatProvider", -1);
					r_FormatProvider.SetBelong(this.instance);
				}
				return r_FormatProvider;
			}
		}

		/// <summary>
		/// System.Text.Encoding Encoding
		/// </summary>
		protected RSystem.RText.REncoding r_Encoding;
		public virtual RSystem.RText.REncoding REncoding
		{
			get
			{
				if(r_Encoding == null)
				{
					r_Encoding = new(this, "Encoding", -1);
					r_Encoding.SetBelong(this.instance);
				}
				return r_Encoding;
			}
		}

		/// <summary>
		/// System.String NewLine
		/// </summary>
		protected RProperty r_NewLine;
		public virtual RProperty RNewLine
		{
			get
			{
				if(r_NewLine == null)
				{
					r_NewLine = new(this, "NewLine", -1);
					r_NewLine.SetBelong(this.instance);
				}
				return r_NewLine;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ServerIdentity ObjectIdentity
		/// </summary>
		protected RSystem.RRuntime.RRemoting.RServerIdentity r_ObjectIdentity;
		public virtual RSystem.RRuntime.RRemoting.RServerIdentity RObjectIdentity
		{
			get
			{
				if(r_ObjectIdentity == null)
				{
					r_ObjectIdentity = new(this, "ObjectIdentity", -1);
					r_ObjectIdentity.SetBelong(this.instance);
				}
				return r_ObjectIdentity;
			}
		}

		/// <summary>
		/// Void Close()
		/// </summary>
		protected RMethod r_RClose;
		public virtual RMethod RClose
		{
			get
			{
				if(r_RClose == null)
				{
					r_RClose = new(this, "Close", 0);
					r_RClose.SetBelong(this.instance);
				}
				return r_RClose;
			}
		}

		/// <summary>
		/// Void Dispose(Boolean)
		/// </summary>
		protected RMethod r_RDispose_Boolean;
		public virtual RMethod RDispose_Boolean
		{
			get
			{
				if(r_RDispose_Boolean == null)
				{
					r_RDispose_Boolean = new(this, "Dispose", 0, typeof(System.Boolean));
					r_RDispose_Boolean.SetBelong(this.instance);
				}
				return r_RDispose_Boolean;
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
		/// System.Threading.Tasks.ValueTask DisposeAsync()
		/// </summary>
		protected RMethod r_RDisposeAsync;
		public virtual RMethod RDisposeAsync
		{
			get
			{
				if(r_RDisposeAsync == null)
				{
					r_RDisposeAsync = new(this, "DisposeAsync", 0);
					r_RDisposeAsync.SetBelong(this.instance);
				}
				return r_RDisposeAsync;
			}
		}

		/// <summary>
		/// Void Flush()
		/// </summary>
		protected RMethod r_RFlush;
		public virtual RMethod RFlush
		{
			get
			{
				if(r_RFlush == null)
				{
					r_RFlush = new(this, "Flush", 0);
					r_RFlush.SetBelong(this.instance);
				}
				return r_RFlush;
			}
		}

		/// <summary>
		/// Void Write(Char)
		/// </summary>
		protected RMethod r_RWrite_Char;
		public virtual RMethod RWrite_Char
		{
			get
			{
				if(r_RWrite_Char == null)
				{
					r_RWrite_Char = new(this, "Write", 0, typeof(System.Char));
					r_RWrite_Char.SetBelong(this.instance);
				}
				return r_RWrite_Char;
			}
		}

		/// <summary>
		/// Void Write(Char[])
		/// </summary>
		protected RMethod r_RWrite_CharArray;
		public virtual RMethod RWrite_CharArray
		{
			get
			{
				if(r_RWrite_CharArray == null)
				{
					r_RWrite_CharArray = new(this, "Write", 0, typeof(System.Char).MakeArrayType());
					r_RWrite_CharArray.SetBelong(this.instance);
				}
				return r_RWrite_CharArray;
			}
		}

		/// <summary>
		/// Void Write(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWrite_CharArray_Int32_Int32;
		public virtual RMethod RWrite_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWrite_CharArray_Int32_Int32 == null)
				{
					r_RWrite_CharArray_Int32_Int32 = new(this, "Write", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWrite_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWrite_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Write(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_RWrite_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RWrite_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RWrite_ReadOnlySpan_d_Char_p_ == null)
				{
					r_RWrite_ReadOnlySpan_d_Char_p_ = new(this, "Write", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RWrite_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_RWrite_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Void Write(Boolean)
		/// </summary>
		protected RMethod r_RWrite_Boolean;
		public virtual RMethod RWrite_Boolean
		{
			get
			{
				if(r_RWrite_Boolean == null)
				{
					r_RWrite_Boolean = new(this, "Write", 0, typeof(System.Boolean));
					r_RWrite_Boolean.SetBelong(this.instance);
				}
				return r_RWrite_Boolean;
			}
		}

		/// <summary>
		/// Void Write(Int32)
		/// </summary>
		protected RMethod r_RWrite_Int32;
		public virtual RMethod RWrite_Int32
		{
			get
			{
				if(r_RWrite_Int32 == null)
				{
					r_RWrite_Int32 = new(this, "Write", 0, typeof(System.Int32));
					r_RWrite_Int32.SetBelong(this.instance);
				}
				return r_RWrite_Int32;
			}
		}

		/// <summary>
		/// Void Write(UInt32)
		/// </summary>
		protected RMethod r_RWrite_UInt32;
		public virtual RMethod RWrite_UInt32
		{
			get
			{
				if(r_RWrite_UInt32 == null)
				{
					r_RWrite_UInt32 = new(this, "Write", 0, typeof(System.UInt32));
					r_RWrite_UInt32.SetBelong(this.instance);
				}
				return r_RWrite_UInt32;
			}
		}

		/// <summary>
		/// Void Write(Int64)
		/// </summary>
		protected RMethod r_RWrite_Int64;
		public virtual RMethod RWrite_Int64
		{
			get
			{
				if(r_RWrite_Int64 == null)
				{
					r_RWrite_Int64 = new(this, "Write", 0, typeof(System.Int64));
					r_RWrite_Int64.SetBelong(this.instance);
				}
				return r_RWrite_Int64;
			}
		}

		/// <summary>
		/// Void Write(UInt64)
		/// </summary>
		protected RMethod r_RWrite_UInt64;
		public virtual RMethod RWrite_UInt64
		{
			get
			{
				if(r_RWrite_UInt64 == null)
				{
					r_RWrite_UInt64 = new(this, "Write", 0, typeof(System.UInt64));
					r_RWrite_UInt64.SetBelong(this.instance);
				}
				return r_RWrite_UInt64;
			}
		}

		/// <summary>
		/// Void Write(Single)
		/// </summary>
		protected RMethod r_RWrite_Single;
		public virtual RMethod RWrite_Single
		{
			get
			{
				if(r_RWrite_Single == null)
				{
					r_RWrite_Single = new(this, "Write", 0, typeof(System.Single));
					r_RWrite_Single.SetBelong(this.instance);
				}
				return r_RWrite_Single;
			}
		}

		/// <summary>
		/// Void Write(Double)
		/// </summary>
		protected RMethod r_RWrite_Double;
		public virtual RMethod RWrite_Double
		{
			get
			{
				if(r_RWrite_Double == null)
				{
					r_RWrite_Double = new(this, "Write", 0, typeof(System.Double));
					r_RWrite_Double.SetBelong(this.instance);
				}
				return r_RWrite_Double;
			}
		}

		/// <summary>
		/// Void Write(System.Decimal)
		/// </summary>
		protected RMethod r_RWrite_Decimal;
		public virtual RMethod RWrite_Decimal
		{
			get
			{
				if(r_RWrite_Decimal == null)
				{
					r_RWrite_Decimal = new(this, "Write", 0, typeof(System.Decimal));
					r_RWrite_Decimal.SetBelong(this.instance);
				}
				return r_RWrite_Decimal;
			}
		}

		/// <summary>
		/// Void Write(System.String)
		/// </summary>
		protected RMethod r_RWrite_String;
		public virtual RMethod RWrite_String
		{
			get
			{
				if(r_RWrite_String == null)
				{
					r_RWrite_String = new(this, "Write", 0, typeof(System.String));
					r_RWrite_String.SetBelong(this.instance);
				}
				return r_RWrite_String;
			}
		}

		/// <summary>
		/// Void Write(System.Object)
		/// </summary>
		protected RMethod r_RWrite_Object;
		public virtual RMethod RWrite_Object
		{
			get
			{
				if(r_RWrite_Object == null)
				{
					r_RWrite_Object = new(this, "Write", 0, typeof(System.Object));
					r_RWrite_Object.SetBelong(this.instance);
				}
				return r_RWrite_Object;
			}
		}

		/// <summary>
		/// Void Write(System.String, System.Object)
		/// </summary>
		protected RMethod r_RWrite_String_Object;
		public virtual RMethod RWrite_String_Object
		{
			get
			{
				if(r_RWrite_String_Object == null)
				{
					r_RWrite_String_Object = new(this, "Write", 0, typeof(System.String), typeof(System.Object));
					r_RWrite_String_Object.SetBelong(this.instance);
				}
				return r_RWrite_String_Object;
			}
		}

		/// <summary>
		/// Void Write(System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RWrite_String_Object_Object;
		public virtual RMethod RWrite_String_Object_Object
		{
			get
			{
				if(r_RWrite_String_Object_Object == null)
				{
					r_RWrite_String_Object_Object = new(this, "Write", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_RWrite_String_Object_Object.SetBelong(this.instance);
				}
				return r_RWrite_String_Object_Object;
			}
		}

		/// <summary>
		/// Void Write(System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RWrite_String_Object_Object_Object;
		public virtual RMethod RWrite_String_Object_Object_Object
		{
			get
			{
				if(r_RWrite_String_Object_Object_Object == null)
				{
					r_RWrite_String_Object_Object_Object = new(this, "Write", 0, typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_RWrite_String_Object_Object_Object.SetBelong(this.instance);
				}
				return r_RWrite_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// Void Write(System.String, System.Object[])
		/// </summary>
		protected RMethod r_RWrite_String_ObjectArray;
		public virtual RMethod RWrite_String_ObjectArray
		{
			get
			{
				if(r_RWrite_String_ObjectArray == null)
				{
					r_RWrite_String_ObjectArray = new(this, "Write", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RWrite_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RWrite_String_ObjectArray;
			}
		}

		/// <summary>
		/// Void WriteLine()
		/// </summary>
		protected RMethod r_RWriteLine;
		public virtual RMethod RWriteLine
		{
			get
			{
				if(r_RWriteLine == null)
				{
					r_RWriteLine = new(this, "WriteLine", 0);
					r_RWriteLine.SetBelong(this.instance);
				}
				return r_RWriteLine;
			}
		}

		/// <summary>
		/// Void WriteLine(Char)
		/// </summary>
		protected RMethod r_RWriteLine_Char;
		public virtual RMethod RWriteLine_Char
		{
			get
			{
				if(r_RWriteLine_Char == null)
				{
					r_RWriteLine_Char = new(this, "WriteLine", 0, typeof(System.Char));
					r_RWriteLine_Char.SetBelong(this.instance);
				}
				return r_RWriteLine_Char;
			}
		}

		/// <summary>
		/// Void WriteLine(Char[])
		/// </summary>
		protected RMethod r_RWriteLine_CharArray;
		public virtual RMethod RWriteLine_CharArray
		{
			get
			{
				if(r_RWriteLine_CharArray == null)
				{
					r_RWriteLine_CharArray = new(this, "WriteLine", 0, typeof(System.Char).MakeArrayType());
					r_RWriteLine_CharArray.SetBelong(this.instance);
				}
				return r_RWriteLine_CharArray;
			}
		}

		/// <summary>
		/// Void WriteLine(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteLine_CharArray_Int32_Int32;
		public virtual RMethod RWriteLine_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteLine_CharArray_Int32_Int32 == null)
				{
					r_RWriteLine_CharArray_Int32_Int32 = new(this, "WriteLine", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteLine_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteLine_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void WriteLine(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_RWriteLine_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RWriteLine_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RWriteLine_ReadOnlySpan_d_Char_p_ == null)
				{
					r_RWriteLine_ReadOnlySpan_d_Char_p_ = new(this, "WriteLine", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RWriteLine_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_RWriteLine_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Void WriteLine(Boolean)
		/// </summary>
		protected RMethod r_RWriteLine_Boolean;
		public virtual RMethod RWriteLine_Boolean
		{
			get
			{
				if(r_RWriteLine_Boolean == null)
				{
					r_RWriteLine_Boolean = new(this, "WriteLine", 0, typeof(System.Boolean));
					r_RWriteLine_Boolean.SetBelong(this.instance);
				}
				return r_RWriteLine_Boolean;
			}
		}

		/// <summary>
		/// Void WriteLine(Int32)
		/// </summary>
		protected RMethod r_RWriteLine_Int32;
		public virtual RMethod RWriteLine_Int32
		{
			get
			{
				if(r_RWriteLine_Int32 == null)
				{
					r_RWriteLine_Int32 = new(this, "WriteLine", 0, typeof(System.Int32));
					r_RWriteLine_Int32.SetBelong(this.instance);
				}
				return r_RWriteLine_Int32;
			}
		}

		/// <summary>
		/// Void WriteLine(UInt32)
		/// </summary>
		protected RMethod r_RWriteLine_UInt32;
		public virtual RMethod RWriteLine_UInt32
		{
			get
			{
				if(r_RWriteLine_UInt32 == null)
				{
					r_RWriteLine_UInt32 = new(this, "WriteLine", 0, typeof(System.UInt32));
					r_RWriteLine_UInt32.SetBelong(this.instance);
				}
				return r_RWriteLine_UInt32;
			}
		}

		/// <summary>
		/// Void WriteLine(Int64)
		/// </summary>
		protected RMethod r_RWriteLine_Int64;
		public virtual RMethod RWriteLine_Int64
		{
			get
			{
				if(r_RWriteLine_Int64 == null)
				{
					r_RWriteLine_Int64 = new(this, "WriteLine", 0, typeof(System.Int64));
					r_RWriteLine_Int64.SetBelong(this.instance);
				}
				return r_RWriteLine_Int64;
			}
		}

		/// <summary>
		/// Void WriteLine(UInt64)
		/// </summary>
		protected RMethod r_RWriteLine_UInt64;
		public virtual RMethod RWriteLine_UInt64
		{
			get
			{
				if(r_RWriteLine_UInt64 == null)
				{
					r_RWriteLine_UInt64 = new(this, "WriteLine", 0, typeof(System.UInt64));
					r_RWriteLine_UInt64.SetBelong(this.instance);
				}
				return r_RWriteLine_UInt64;
			}
		}

		/// <summary>
		/// Void WriteLine(Single)
		/// </summary>
		protected RMethod r_RWriteLine_Single;
		public virtual RMethod RWriteLine_Single
		{
			get
			{
				if(r_RWriteLine_Single == null)
				{
					r_RWriteLine_Single = new(this, "WriteLine", 0, typeof(System.Single));
					r_RWriteLine_Single.SetBelong(this.instance);
				}
				return r_RWriteLine_Single;
			}
		}

		/// <summary>
		/// Void WriteLine(Double)
		/// </summary>
		protected RMethod r_RWriteLine_Double;
		public virtual RMethod RWriteLine_Double
		{
			get
			{
				if(r_RWriteLine_Double == null)
				{
					r_RWriteLine_Double = new(this, "WriteLine", 0, typeof(System.Double));
					r_RWriteLine_Double.SetBelong(this.instance);
				}
				return r_RWriteLine_Double;
			}
		}

		/// <summary>
		/// Void WriteLine(System.Decimal)
		/// </summary>
		protected RMethod r_RWriteLine_Decimal;
		public virtual RMethod RWriteLine_Decimal
		{
			get
			{
				if(r_RWriteLine_Decimal == null)
				{
					r_RWriteLine_Decimal = new(this, "WriteLine", 0, typeof(System.Decimal));
					r_RWriteLine_Decimal.SetBelong(this.instance);
				}
				return r_RWriteLine_Decimal;
			}
		}

		/// <summary>
		/// Void WriteLine(System.String)
		/// </summary>
		protected RMethod r_RWriteLine_String;
		public virtual RMethod RWriteLine_String
		{
			get
			{
				if(r_RWriteLine_String == null)
				{
					r_RWriteLine_String = new(this, "WriteLine", 0, typeof(System.String));
					r_RWriteLine_String.SetBelong(this.instance);
				}
				return r_RWriteLine_String;
			}
		}

		/// <summary>
		/// Void WriteLine(System.Object)
		/// </summary>
		protected RMethod r_RWriteLine_Object;
		public virtual RMethod RWriteLine_Object
		{
			get
			{
				if(r_RWriteLine_Object == null)
				{
					r_RWriteLine_Object = new(this, "WriteLine", 0, typeof(System.Object));
					r_RWriteLine_Object.SetBelong(this.instance);
				}
				return r_RWriteLine_Object;
			}
		}

		/// <summary>
		/// Void WriteLine(System.String, System.Object)
		/// </summary>
		protected RMethod r_RWriteLine_String_Object;
		public virtual RMethod RWriteLine_String_Object
		{
			get
			{
				if(r_RWriteLine_String_Object == null)
				{
					r_RWriteLine_String_Object = new(this, "WriteLine", 0, typeof(System.String), typeof(System.Object));
					r_RWriteLine_String_Object.SetBelong(this.instance);
				}
				return r_RWriteLine_String_Object;
			}
		}

		/// <summary>
		/// Void WriteLine(System.String, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RWriteLine_String_Object_Object;
		public virtual RMethod RWriteLine_String_Object_Object
		{
			get
			{
				if(r_RWriteLine_String_Object_Object == null)
				{
					r_RWriteLine_String_Object_Object = new(this, "WriteLine", 0, typeof(System.String), typeof(System.Object), typeof(System.Object));
					r_RWriteLine_String_Object_Object.SetBelong(this.instance);
				}
				return r_RWriteLine_String_Object_Object;
			}
		}

		/// <summary>
		/// Void WriteLine(System.String, System.Object, System.Object, System.Object)
		/// </summary>
		protected RMethod r_RWriteLine_String_Object_Object_Object;
		public virtual RMethod RWriteLine_String_Object_Object_Object
		{
			get
			{
				if(r_RWriteLine_String_Object_Object_Object == null)
				{
					r_RWriteLine_String_Object_Object_Object = new(this, "WriteLine", 0, typeof(System.String), typeof(System.Object), typeof(System.Object), typeof(System.Object));
					r_RWriteLine_String_Object_Object_Object.SetBelong(this.instance);
				}
				return r_RWriteLine_String_Object_Object_Object;
			}
		}

		/// <summary>
		/// Void WriteLine(System.String, System.Object[])
		/// </summary>
		protected RMethod r_RWriteLine_String_ObjectArray;
		public virtual RMethod RWriteLine_String_ObjectArray
		{
			get
			{
				if(r_RWriteLine_String_ObjectArray == null)
				{
					r_RWriteLine_String_ObjectArray = new(this, "WriteLine", 0, typeof(System.String), typeof(System.Object).MakeArrayType());
					r_RWriteLine_String_ObjectArray.SetBelong(this.instance);
				}
				return r_RWriteLine_String_ObjectArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Char)
		/// </summary>
		protected RMethod r_RWriteAsync_Char;
		public virtual RMethod RWriteAsync_Char
		{
			get
			{
				if(r_RWriteAsync_Char == null)
				{
					r_RWriteAsync_Char = new(this, "WriteAsync", 0, typeof(System.Char));
					r_RWriteAsync_Char.SetBelong(this.instance);
				}
				return r_RWriteAsync_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteAsync_String;
		public virtual RMethod RWriteAsync_String
		{
			get
			{
				if(r_RWriteAsync_String == null)
				{
					r_RWriteAsync_String = new(this, "WriteAsync", 0, typeof(System.String));
					r_RWriteAsync_String.SetBelong(this.instance);
				}
				return r_RWriteAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Char[])
		/// </summary>
		protected RMethod r_RWriteAsync_CharArray;
		public virtual RMethod RWriteAsync_CharArray
		{
			get
			{
				if(r_RWriteAsync_CharArray == null)
				{
					r_RWriteAsync_CharArray = new(this, "WriteAsync", 0, typeof(System.Char).MakeArrayType());
					r_RWriteAsync_CharArray.SetBelong(this.instance);
				}
				return r_RWriteAsync_CharArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteAsync_CharArray_Int32_Int32;
		public virtual RMethod RWriteAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteAsync_CharArray_Int32_Int32 == null)
				{
					r_RWriteAsync_CharArray_Int32_Int32 = new(this, "WriteAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteAsync(System.ReadOnlyMemory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWriteAsync_ReadOnlyMemory_d_Char_p__CancellationToken;
		public virtual RMethod RWriteAsync_ReadOnlyMemory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RWriteAsync_ReadOnlyMemory_d_Char_p__CancellationToken == null)
				{
					r_RWriteAsync_ReadOnlyMemory_d_Char_p__CancellationToken = new(this, "WriteAsync", 0, typeof(System.ReadOnlyMemory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RWriteAsync_ReadOnlyMemory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RWriteAsync_ReadOnlyMemory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteLineAsync(Char)
		/// </summary>
		protected RMethod r_RWriteLineAsync_Char;
		public virtual RMethod RWriteLineAsync_Char
		{
			get
			{
				if(r_RWriteLineAsync_Char == null)
				{
					r_RWriteLineAsync_Char = new(this, "WriteLineAsync", 0, typeof(System.Char));
					r_RWriteLineAsync_Char.SetBelong(this.instance);
				}
				return r_RWriteLineAsync_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteLineAsync(System.String)
		/// </summary>
		protected RMethod r_RWriteLineAsync_String;
		public virtual RMethod RWriteLineAsync_String
		{
			get
			{
				if(r_RWriteLineAsync_String == null)
				{
					r_RWriteLineAsync_String = new(this, "WriteLineAsync", 0, typeof(System.String));
					r_RWriteLineAsync_String.SetBelong(this.instance);
				}
				return r_RWriteLineAsync_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteLineAsync(Char[])
		/// </summary>
		protected RMethod r_RWriteLineAsync_CharArray;
		public virtual RMethod RWriteLineAsync_CharArray
		{
			get
			{
				if(r_RWriteLineAsync_CharArray == null)
				{
					r_RWriteLineAsync_CharArray = new(this, "WriteLineAsync", 0, typeof(System.Char).MakeArrayType());
					r_RWriteLineAsync_CharArray.SetBelong(this.instance);
				}
				return r_RWriteLineAsync_CharArray;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteLineAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RWriteLineAsync_CharArray_Int32_Int32;
		public virtual RMethod RWriteLineAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RWriteLineAsync_CharArray_Int32_Int32 == null)
				{
					r_RWriteLineAsync_CharArray_Int32_Int32 = new(this, "WriteLineAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RWriteLineAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RWriteLineAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteLineAsync(System.ReadOnlyMemory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RWriteLineAsync_ReadOnlyMemory_d_Char_p__CancellationToken;
		public virtual RMethod RWriteLineAsync_ReadOnlyMemory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RWriteLineAsync_ReadOnlyMemory_d_Char_p__CancellationToken == null)
				{
					r_RWriteLineAsync_ReadOnlyMemory_d_Char_p__CancellationToken = new(this, "WriteLineAsync", 0, typeof(System.ReadOnlyMemory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RWriteLineAsync_ReadOnlyMemory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RWriteLineAsync_ReadOnlyMemory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task WriteLineAsync()
		/// </summary>
		protected RMethod r_RWriteLineAsync;
		public virtual RMethod RWriteLineAsync
		{
			get
			{
				if(r_RWriteLineAsync == null)
				{
					r_RWriteLineAsync = new(this, "WriteLineAsync", 0);
					r_RWriteLineAsync.SetBelong(this.instance);
				}
				return r_RWriteLineAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FlushAsync()
		/// </summary>
		protected RMethod r_RFlushAsync;
		public virtual RMethod RFlushAsync
		{
			get
			{
				if(r_RFlushAsync == null)
				{
					r_RFlushAsync = new(this, "FlushAsync", 0);
					r_RFlushAsync.SetBelong(this.instance);
				}
				return r_RFlushAsync;
			}
		}

		/// <summary>
		/// System.IO.TextWriter Synchronized(System.IO.TextWriter)
		/// </summary>
		protected static RMethod r_RSynchronized_TextWriter;
		public static RMethod RSynchronized_TextWriter
		{
			get
			{
				if(r_RSynchronized_TextWriter == null)
				{
					r_RSynchronized_TextWriter = new(typeof(System.IO.TextWriter), "Synchronized", 0, typeof(System.IO.TextWriter));
					r_RSynchronized_TextWriter.SetBelong(null);
				}
				return r_RSynchronized_TextWriter;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.Identity GetObjectIdentity(System.MarshalByRefObject, Boolean ByRef)
		/// </summary>
		protected RMethod r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
		public virtual RMethod RGetObjectIdentity_MarshalByRefObject_Out_Boolean
		{
			get
			{
				if(r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean == null)
				{
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean = new(this, "GetObjectIdentity", 0, typeof(System.MarshalByRefObject), typeof(System.Boolean).MakeByRefType());
					r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean.SetBelong(this.instance);
				}
				return r_RGetObjectIdentity_MarshalByRefObject_Out_Boolean;
			}
		}

		/// <summary>
		/// System.Runtime.Remoting.ObjRef CreateObjRef(System.Type)
		/// </summary>
		protected RMethod r_RCreateObjRef_Type;
		public virtual RMethod RCreateObjRef_Type
		{
			get
			{
				if(r_RCreateObjRef_Type == null)
				{
					r_RCreateObjRef_Type = new(this, "CreateObjRef", 0, typeof(System.Type));
					r_RCreateObjRef_Type.SetBelong(this.instance);
				}
				return r_RCreateObjRef_Type;
			}
		}

		/// <summary>
		/// System.Object GetLifetimeService()
		/// </summary>
		protected RMethod r_RGetLifetimeService;
		public virtual RMethod RGetLifetimeService
		{
			get
			{
				if(r_RGetLifetimeService == null)
				{
					r_RGetLifetimeService = new(this, "GetLifetimeService", 0);
					r_RGetLifetimeService.SetBelong(this.instance);
				}
				return r_RGetLifetimeService;
			}
		}

		/// <summary>
		/// System.Object InitializeLifetimeService()
		/// </summary>
		protected RMethod r_RInitializeLifetimeService;
		public virtual RMethod RInitializeLifetimeService
		{
			get
			{
				if(r_RInitializeLifetimeService == null)
				{
					r_RInitializeLifetimeService = new(this, "InitializeLifetimeService", 0);
					r_RInitializeLifetimeService.SetBelong(this.instance);
				}
				return r_RInitializeLifetimeService;
			}
		}

		/// <summary>
		/// System.MarshalByRefObject MemberwiseClone(Boolean)
		/// </summary>
		protected RMethod r_RMemberwiseClone_Boolean;
		public virtual RMethod RMemberwiseClone_Boolean
		{
			get
			{
				if(r_RMemberwiseClone_Boolean == null)
				{
					r_RMemberwiseClone_Boolean = new(this, "MemberwiseClone", 0, typeof(System.Boolean));
					r_RMemberwiseClone_Boolean.SetBelong(this.instance);
				}
				return r_RMemberwiseClone_Boolean;
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


        public RTextWriter() : base("System.IO.TextWriter")
        {
        }

        public RTextWriter(System.Object instance) : base("System.IO.TextWriter")
		{
            SetInstance(instance);
		}

        public RTextWriter(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RTextWriter(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.ValueTask DisposeAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDisposeAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask)___result;
        }


        public virtual void Flush()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlush.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RWrite_CharArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWrite_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void Write(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.UInt64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Decimal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWrite_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.String  @format, System.Object  @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0};
            var ___result = RWrite_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.String  @format, System.Object  @arg0, System.Object  @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1};
            var ___result = RWrite_String_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.String  @format, System.Object  @arg0, System.Object  @arg1, System.Object  @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1, @arg2};
            var ___result = RWrite_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Write(System.String  @format, System.Object[]  @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg};
            var ___result = RWrite_String_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteLine.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_Char.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Char[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RWriteLine_CharArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteLine_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void WriteLine(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Int32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.UInt32  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_UInt32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Int64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_Int64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.UInt64  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_UInt64.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Single  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_Single.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Double  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_Double.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Decimal  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_Decimal.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLine_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.String  @format, System.Object  @arg0)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0};
            var ___result = RWriteLine_String_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.String  @format, System.Object  @arg0, System.Object  @arg1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1};
            var ___result = RWriteLine_String_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.String  @format, System.Object  @arg0, System.Object  @arg1, System.Object  @arg2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg0, @arg1, @arg2};
            var ___result = RWriteLine_String_Object_Object_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void WriteLine(System.String  @format, System.Object[]  @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@format, @arg};
            var ___result = RWriteLine_String_ObjectArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteAsync_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Char[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RWriteAsync_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteAsync(System.ReadOnlyMemory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RWriteAsync_ReadOnlyMemory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteLineAsync(System.Char  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLineAsync_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteLineAsync(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RWriteLineAsync_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteLineAsync(System.Char[]  @buffer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer};
            var ___result = RWriteLineAsync_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteLineAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RWriteLineAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteLineAsync(System.ReadOnlyMemory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RWriteLineAsync_ReadOnlyMemory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task WriteLineAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RWriteLineAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FlushAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFlushAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public static System.IO.TextWriter Synchronized(System.IO.TextWriter  @writer)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@writer};
            var ___result = RSynchronized_TextWriter.Invoke(___genericsType, ___parameters);

            return (System.IO.TextWriter)___result;
        }


        public virtual System.Object GetObjectIdentity(System.MarshalByRefObject  @obj, out System.Boolean  @IsClient)
        {
			IsClient = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj, @IsClient};
            var ___result = RGetObjectIdentity_MarshalByRefObject_Out_Boolean.Invoke(___genericsType, ___parameters);
			IsClient = (System.Boolean)___parameters[1];

            return (System.Object)___result;
        }


        public virtual System.Runtime.Remoting.ObjRef CreateObjRef(System.Type  @requestedType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@requestedType};
            var ___result = RCreateObjRef_Type.Invoke(___genericsType, ___parameters);

            return (System.Runtime.Remoting.ObjRef)___result;
        }


        public virtual System.Object GetLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object InitializeLifetimeService()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitializeLifetimeService.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.MarshalByRefObject MemberwiseClone(System.Boolean  @cloneIdentity)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@cloneIdentity};
            var ___result = RMemberwiseClone_Boolean.Invoke(___genericsType, ___parameters);

            return (System.MarshalByRefObject)___result;
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
