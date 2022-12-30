using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RIO
{
	/// <summary>
	/// System.IO.StreamReader
	/// </summary>
    public partial class RStreamReader : RMember //
    {

		/// <summary>
		/// System.IO.StreamReader Null
		/// </summary>
		protected static RSystem.RIO.RStreamReader r_Null;
		public static RSystem.RIO.RStreamReader RNull
		{
			get
			{
				if(r_Null == null)
				{
					r_Null = new(typeof(System.IO.StreamReader), "Null");
					r_Null.SetBelong(null);
				}
				return r_Null;
			}
		}

		/// <summary>
		/// System.Int32 DefaultBufferSize
		/// </summary>
		protected static RField r_DefaultBufferSize;
		public static RField RDefaultBufferSize
		{
			get
			{
				if(r_DefaultBufferSize == null)
				{
					r_DefaultBufferSize = new(typeof(System.IO.StreamReader), "DefaultBufferSize");
					r_DefaultBufferSize.SetBelong(null);
				}
				return r_DefaultBufferSize;
			}
		}

		/// <summary>
		/// System.Int32 DefaultFileStreamBufferSize
		/// </summary>
		protected static RField r_DefaultFileStreamBufferSize;
		public static RField RDefaultFileStreamBufferSize
		{
			get
			{
				if(r_DefaultFileStreamBufferSize == null)
				{
					r_DefaultFileStreamBufferSize = new(typeof(System.IO.StreamReader), "DefaultFileStreamBufferSize");
					r_DefaultFileStreamBufferSize.SetBelong(null);
				}
				return r_DefaultFileStreamBufferSize;
			}
		}

		/// <summary>
		/// System.Int32 MinBufferSize
		/// </summary>
		protected static RField r_MinBufferSize;
		public static RField RMinBufferSize
		{
			get
			{
				if(r_MinBufferSize == null)
				{
					r_MinBufferSize = new(typeof(System.IO.StreamReader), "MinBufferSize");
					r_MinBufferSize.SetBelong(null);
				}
				return r_MinBufferSize;
			}
		}

		/// <summary>
		/// System.IO.Stream _stream
		/// </summary>
		protected RSystem.RIO.RStream r__stream;
		public virtual RSystem.RIO.RStream R_stream
		{
			get
			{
				if(r__stream == null)
				{
					r__stream = new(this, "_stream");
					r__stream.SetBelong(this.instance);
				}
				return r__stream;
			}
		}

		/// <summary>
		/// System.Text.Encoding _encoding
		/// </summary>
		protected RSystem.RText.REncoding r__encoding;
		public virtual RSystem.RText.REncoding R_encoding
		{
			get
			{
				if(r__encoding == null)
				{
					r__encoding = new(this, "_encoding");
					r__encoding.SetBelong(this.instance);
				}
				return r__encoding;
			}
		}

		/// <summary>
		/// System.Text.Decoder _decoder
		/// </summary>
		protected RSystem.RText.RDecoder r__decoder;
		public virtual RSystem.RText.RDecoder R_decoder
		{
			get
			{
				if(r__decoder == null)
				{
					r__decoder = new(this, "_decoder");
					r__decoder.SetBelong(this.instance);
				}
				return r__decoder;
			}
		}

		/// <summary>
		/// System.Byte[] _byteBuffer
		/// </summary>
		protected RFieldArray<RField> r__byteBuffer;
		public virtual RFieldArray<RField> R_byteBuffer
		{
			get
			{
				if(r__byteBuffer == null)
				{
					r__byteBuffer = new(this, "_byteBuffer");
					r__byteBuffer.SetBelong(this.instance);
				}
				return r__byteBuffer;
			}
		}

		/// <summary>
		/// System.Char[] _charBuffer
		/// </summary>
		protected RFieldArray<RField> r__charBuffer;
		public virtual RFieldArray<RField> R_charBuffer
		{
			get
			{
				if(r__charBuffer == null)
				{
					r__charBuffer = new(this, "_charBuffer");
					r__charBuffer.SetBelong(this.instance);
				}
				return r__charBuffer;
			}
		}

		/// <summary>
		/// System.Int32 _charPos
		/// </summary>
		protected RField r__charPos;
		public virtual RField R_charPos
		{
			get
			{
				if(r__charPos == null)
				{
					r__charPos = new(this, "_charPos");
					r__charPos.SetBelong(this.instance);
				}
				return r__charPos;
			}
		}

		/// <summary>
		/// System.Int32 _charLen
		/// </summary>
		protected RField r__charLen;
		public virtual RField R_charLen
		{
			get
			{
				if(r__charLen == null)
				{
					r__charLen = new(this, "_charLen");
					r__charLen.SetBelong(this.instance);
				}
				return r__charLen;
			}
		}

		/// <summary>
		/// System.Int32 _byteLen
		/// </summary>
		protected RField r__byteLen;
		public virtual RField R_byteLen
		{
			get
			{
				if(r__byteLen == null)
				{
					r__byteLen = new(this, "_byteLen");
					r__byteLen.SetBelong(this.instance);
				}
				return r__byteLen;
			}
		}

		/// <summary>
		/// System.Int32 _bytePos
		/// </summary>
		protected RField r__bytePos;
		public virtual RField R_bytePos
		{
			get
			{
				if(r__bytePos == null)
				{
					r__bytePos = new(this, "_bytePos");
					r__bytePos.SetBelong(this.instance);
				}
				return r__bytePos;
			}
		}

		/// <summary>
		/// System.Int32 _maxCharsPerBuffer
		/// </summary>
		protected RField r__maxCharsPerBuffer;
		public virtual RField R_maxCharsPerBuffer
		{
			get
			{
				if(r__maxCharsPerBuffer == null)
				{
					r__maxCharsPerBuffer = new(this, "_maxCharsPerBuffer");
					r__maxCharsPerBuffer.SetBelong(this.instance);
				}
				return r__maxCharsPerBuffer;
			}
		}

		/// <summary>
		/// System.Boolean _detectEncoding
		/// </summary>
		protected RField r__detectEncoding;
		public virtual RField R_detectEncoding
		{
			get
			{
				if(r__detectEncoding == null)
				{
					r__detectEncoding = new(this, "_detectEncoding");
					r__detectEncoding.SetBelong(this.instance);
				}
				return r__detectEncoding;
			}
		}

		/// <summary>
		/// System.Boolean _checkPreamble
		/// </summary>
		protected RField r__checkPreamble;
		public virtual RField R_checkPreamble
		{
			get
			{
				if(r__checkPreamble == null)
				{
					r__checkPreamble = new(this, "_checkPreamble");
					r__checkPreamble.SetBelong(this.instance);
				}
				return r__checkPreamble;
			}
		}

		/// <summary>
		/// System.Boolean _isBlocked
		/// </summary>
		protected RField r__isBlocked;
		public virtual RField R_isBlocked
		{
			get
			{
				if(r__isBlocked == null)
				{
					r__isBlocked = new(this, "_isBlocked");
					r__isBlocked.SetBelong(this.instance);
				}
				return r__isBlocked;
			}
		}

		/// <summary>
		/// System.Boolean _closable
		/// </summary>
		protected RField r__closable;
		public virtual RField R_closable
		{
			get
			{
				if(r__closable == null)
				{
					r__closable = new(this, "_closable");
					r__closable.SetBelong(this.instance);
				}
				return r__closable;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task _asyncReadTask
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask r__asyncReadTask;
		public virtual RSystem.RThreading.RTasks.RTask R_asyncReadTask
		{
			get
			{
				if(r__asyncReadTask == null)
				{
					r__asyncReadTask = new(this, "_asyncReadTask");
					r__asyncReadTask.SetBelong(this.instance);
				}
				return r__asyncReadTask;
			}
		}

		/// <summary>
		/// System.Text.Encoding CurrentEncoding
		/// </summary>
		protected RSystem.RText.REncoding r_CurrentEncoding;
		public virtual RSystem.RText.REncoding RCurrentEncoding
		{
			get
			{
				if(r_CurrentEncoding == null)
				{
					r_CurrentEncoding = new(this, "CurrentEncoding", -1);
					r_CurrentEncoding.SetBelong(this.instance);
				}
				return r_CurrentEncoding;
			}
		}

		/// <summary>
		/// System.IO.Stream BaseStream
		/// </summary>
		protected RSystem.RIO.RStream r_BaseStream;
		public virtual RSystem.RIO.RStream RBaseStream
		{
			get
			{
				if(r_BaseStream == null)
				{
					r_BaseStream = new(this, "BaseStream", -1);
					r_BaseStream.SetBelong(this.instance);
				}
				return r_BaseStream;
			}
		}

		/// <summary>
		/// Boolean LeaveOpen
		/// </summary>
		protected RProperty r_LeaveOpen;
		public virtual RProperty RLeaveOpen
		{
			get
			{
				if(r_LeaveOpen == null)
				{
					r_LeaveOpen = new(this, "LeaveOpen", -1);
					r_LeaveOpen.SetBelong(this.instance);
				}
				return r_LeaveOpen;
			}
		}

		/// <summary>
		/// Boolean EndOfStream
		/// </summary>
		protected RProperty r_EndOfStream;
		public virtual RProperty REndOfStream
		{
			get
			{
				if(r_EndOfStream == null)
				{
					r_EndOfStream = new(this, "EndOfStream", -1);
					r_EndOfStream.SetBelong(this.instance);
				}
				return r_EndOfStream;
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
		/// Void CheckAsyncTaskInProgress()
		/// </summary>
		protected RMethod r_RCheckAsyncTaskInProgress;
		public virtual RMethod RCheckAsyncTaskInProgress
		{
			get
			{
				if(r_RCheckAsyncTaskInProgress == null)
				{
					r_RCheckAsyncTaskInProgress = new(this, "CheckAsyncTaskInProgress", 0);
					r_RCheckAsyncTaskInProgress.SetBelong(this.instance);
				}
				return r_RCheckAsyncTaskInProgress;
			}
		}

		/// <summary>
		/// Void ThrowAsyncIOInProgress()
		/// </summary>
		protected static RMethod r_RThrowAsyncIOInProgress;
		public static RMethod RThrowAsyncIOInProgress
		{
			get
			{
				if(r_RThrowAsyncIOInProgress == null)
				{
					r_RThrowAsyncIOInProgress = new(typeof(System.IO.StreamReader), "ThrowAsyncIOInProgress", 0);
					r_RThrowAsyncIOInProgress.SetBelong(null);
				}
				return r_RThrowAsyncIOInProgress;
			}
		}

		/// <summary>
		/// Void Init(System.IO.Stream, System.Text.Encoding, Boolean, Int32, Boolean)
		/// </summary>
		protected RMethod r_RInit_Stream_Encoding_Boolean_Int32_Boolean;
		public virtual RMethod RInit_Stream_Encoding_Boolean_Int32_Boolean
		{
			get
			{
				if(r_RInit_Stream_Encoding_Boolean_Int32_Boolean == null)
				{
					r_RInit_Stream_Encoding_Boolean_Int32_Boolean = new(this, "Init", 0, typeof(System.IO.Stream), typeof(System.Text.Encoding), typeof(System.Boolean), typeof(System.Int32), typeof(System.Boolean));
					r_RInit_Stream_Encoding_Boolean_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RInit_Stream_Encoding_Boolean_Int32_Boolean;
			}
		}

		/// <summary>
		/// Void Init(System.IO.Stream)
		/// </summary>
		protected RMethod r_RInit_Stream;
		public virtual RMethod RInit_Stream
		{
			get
			{
				if(r_RInit_Stream == null)
				{
					r_RInit_Stream = new(this, "Init", 0, typeof(System.IO.Stream));
					r_RInit_Stream.SetBelong(this.instance);
				}
				return r_RInit_Stream;
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
		/// Void DiscardBufferedData()
		/// </summary>
		protected RMethod r_RDiscardBufferedData;
		public virtual RMethod RDiscardBufferedData
		{
			get
			{
				if(r_RDiscardBufferedData == null)
				{
					r_RDiscardBufferedData = new(this, "DiscardBufferedData", 0);
					r_RDiscardBufferedData.SetBelong(this.instance);
				}
				return r_RDiscardBufferedData;
			}
		}

		/// <summary>
		/// Int32 Peek()
		/// </summary>
		protected RMethod r_RPeek;
		public virtual RMethod RPeek
		{
			get
			{
				if(r_RPeek == null)
				{
					r_RPeek = new(this, "Peek", 0);
					r_RPeek.SetBelong(this.instance);
				}
				return r_RPeek;
			}
		}

		/// <summary>
		/// Int32 Read()
		/// </summary>
		protected RMethod r_RRead;
		public virtual RMethod RRead
		{
			get
			{
				if(r_RRead == null)
				{
					r_RRead = new(this, "Read", 0);
					r_RRead.SetBelong(this.instance);
				}
				return r_RRead;
			}
		}

		/// <summary>
		/// Int32 Read(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RRead_CharArray_Int32_Int32;
		public virtual RMethod RRead_CharArray_Int32_Int32
		{
			get
			{
				if(r_RRead_CharArray_Int32_Int32 == null)
				{
					r_RRead_CharArray_Int32_Int32 = new(this, "Read", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RRead_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RRead_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 Read(System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_RRead_Span_d_Char_p_;
		public virtual RMethod RRead_Span_d_Char_p_
		{
			get
			{
				if(r_RRead_Span_d_Char_p_ == null)
				{
					r_RRead_Span_d_Char_p_ = new(this, "Read", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_RRead_Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_RRead_Span_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 ReadSpan(System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_RReadSpan_Span_d_Char_p_;
		public virtual RMethod RReadSpan_Span_d_Char_p_
		{
			get
			{
				if(r_RReadSpan_Span_d_Char_p_ == null)
				{
					r_RReadSpan_Span_d_Char_p_ = new(this, "ReadSpan", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_RReadSpan_Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_RReadSpan_Span_d_Char_p_;
			}
		}

		/// <summary>
		/// System.String ReadToEnd()
		/// </summary>
		protected RMethod r_RReadToEnd;
		public virtual RMethod RReadToEnd
		{
			get
			{
				if(r_RReadToEnd == null)
				{
					r_RReadToEnd = new(this, "ReadToEnd", 0);
					r_RReadToEnd.SetBelong(this.instance);
				}
				return r_RReadToEnd;
			}
		}

		/// <summary>
		/// Int32 ReadBlock(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadBlock_CharArray_Int32_Int32;
		public virtual RMethod RReadBlock_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadBlock_CharArray_Int32_Int32 == null)
				{
					r_RReadBlock_CharArray_Int32_Int32 = new(this, "ReadBlock", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadBlock_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadBlock_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadBlock(System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_RReadBlock_Span_d_Char_p_;
		public virtual RMethod RReadBlock_Span_d_Char_p_
		{
			get
			{
				if(r_RReadBlock_Span_d_Char_p_ == null)
				{
					r_RReadBlock_Span_d_Char_p_ = new(this, "ReadBlock", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_RReadBlock_Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_RReadBlock_Span_d_Char_p_;
			}
		}

		/// <summary>
		/// Void CompressBuffer(Int32)
		/// </summary>
		protected RMethod r_RCompressBuffer_Int32;
		public virtual RMethod RCompressBuffer_Int32
		{
			get
			{
				if(r_RCompressBuffer_Int32 == null)
				{
					r_RCompressBuffer_Int32 = new(this, "CompressBuffer", 0, typeof(System.Int32));
					r_RCompressBuffer_Int32.SetBelong(this.instance);
				}
				return r_RCompressBuffer_Int32;
			}
		}

		/// <summary>
		/// Void DetectEncoding()
		/// </summary>
		protected RMethod r_RDetectEncoding;
		public virtual RMethod RDetectEncoding
		{
			get
			{
				if(r_RDetectEncoding == null)
				{
					r_RDetectEncoding = new(this, "DetectEncoding", 0);
					r_RDetectEncoding.SetBelong(this.instance);
				}
				return r_RDetectEncoding;
			}
		}

		/// <summary>
		/// Boolean IsPreamble()
		/// </summary>
		protected RMethod r_RIsPreamble;
		public virtual RMethod RIsPreamble
		{
			get
			{
				if(r_RIsPreamble == null)
				{
					r_RIsPreamble = new(this, "IsPreamble", 0);
					r_RIsPreamble.SetBelong(this.instance);
				}
				return r_RIsPreamble;
			}
		}

		/// <summary>
		/// Int32 ReadBuffer()
		/// </summary>
		protected RMethod r_RReadBuffer;
		public virtual RMethod RReadBuffer
		{
			get
			{
				if(r_RReadBuffer == null)
				{
					r_RReadBuffer = new(this, "ReadBuffer", 0);
					r_RReadBuffer.SetBelong(this.instance);
				}
				return r_RReadBuffer;
			}
		}

		/// <summary>
		/// Int32 ReadBuffer(System.Span`1[System.Char], Boolean ByRef)
		/// </summary>
		protected RMethod r_RReadBuffer_Span_d_Char_p__Out_Boolean;
		public virtual RMethod RReadBuffer_Span_d_Char_p__Out_Boolean
		{
			get
			{
				if(r_RReadBuffer_Span_d_Char_p__Out_Boolean == null)
				{
					r_RReadBuffer_Span_d_Char_p__Out_Boolean = new(this, "ReadBuffer", 0, typeof(System.Span<>).MakeGenericType(typeof(System.Char)), typeof(System.Boolean).MakeByRefType());
					r_RReadBuffer_Span_d_Char_p__Out_Boolean.SetBelong(this.instance);
				}
				return r_RReadBuffer_Span_d_Char_p__Out_Boolean;
			}
		}

		/// <summary>
		/// System.String ReadLine()
		/// </summary>
		protected RMethod r_RReadLine;
		public virtual RMethod RReadLine
		{
			get
			{
				if(r_RReadLine == null)
				{
					r_RReadLine = new(this, "ReadLine", 0);
					r_RReadLine.SetBelong(this.instance);
				}
				return r_RReadLine;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadLineAsync()
		/// </summary>
		protected RMethod r_RReadLineAsync;
		public virtual RMethod RReadLineAsync
		{
			get
			{
				if(r_RReadLineAsync == null)
				{
					r_RReadLineAsync = new(this, "ReadLineAsync", 0);
					r_RReadLineAsync.SetBelong(this.instance);
				}
				return r_RReadLineAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadLineAsyncInternal()
		/// </summary>
		protected RMethod r_RReadLineAsyncInternal;
		public virtual RMethod RReadLineAsyncInternal
		{
			get
			{
				if(r_RReadLineAsyncInternal == null)
				{
					r_RReadLineAsyncInternal = new(this, "ReadLineAsyncInternal", 0);
					r_RReadLineAsyncInternal.SetBelong(this.instance);
				}
				return r_RReadLineAsyncInternal;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadToEndAsync()
		/// </summary>
		protected RMethod r_RReadToEndAsync;
		public virtual RMethod RReadToEndAsync
		{
			get
			{
				if(r_RReadToEndAsync == null)
				{
					r_RReadToEndAsync = new(this, "ReadToEndAsync", 0);
					r_RReadToEndAsync.SetBelong(this.instance);
				}
				return r_RReadToEndAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadToEndAsyncInternal()
		/// </summary>
		protected RMethod r_RReadToEndAsyncInternal;
		public virtual RMethod RReadToEndAsyncInternal
		{
			get
			{
				if(r_RReadToEndAsyncInternal == null)
				{
					r_RReadToEndAsyncInternal = new(this, "ReadToEndAsyncInternal", 0);
					r_RReadToEndAsyncInternal.SetBelong(this.instance);
				}
				return r_RReadToEndAsyncInternal;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadAsync_CharArray_Int32_Int32;
		public virtual RMethod RReadAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadAsync_CharArray_Int32_Int32 == null)
				{
					r_RReadAsync_CharArray_Int32_Int32 = new(this, "ReadAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadAsync(System.Memory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadAsync_Memory_d_Char_p__CancellationToken;
		public virtual RMethod RReadAsync_Memory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RReadAsync_Memory_d_Char_p__CancellationToken == null)
				{
					r_RReadAsync_Memory_d_Char_p__CancellationToken = new(this, "ReadAsync", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RReadAsync_Memory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadAsync_Memory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadAsyncInternal(System.Memory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken;
		public virtual RMethod RReadAsyncInternal_Memory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken == null)
				{
					r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken = new(this, "ReadAsyncInternal", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadAsyncInternal_Memory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadBlockAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadBlockAsync_CharArray_Int32_Int32;
		public virtual RMethod RReadBlockAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadBlockAsync_CharArray_Int32_Int32 == null)
				{
					r_RReadBlockAsync_CharArray_Int32_Int32 = new(this, "ReadBlockAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadBlockAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadBlockAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadBlockAsync(System.Memory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadBlockAsync_Memory_d_Char_p__CancellationToken;
		public virtual RMethod RReadBlockAsync_Memory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RReadBlockAsync_Memory_d_Char_p__CancellationToken == null)
				{
					r_RReadBlockAsync_Memory_d_Char_p__CancellationToken = new(this, "ReadBlockAsync", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RReadBlockAsync_Memory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadBlockAsync_Memory_d_Char_p__CancellationToken;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadBufferAsync()
		/// </summary>
		protected RMethod r_RReadBufferAsync;
		public virtual RMethod RReadBufferAsync
		{
			get
			{
				if(r_RReadBufferAsync == null)
				{
					r_RReadBufferAsync = new(this, "ReadBufferAsync", 0);
					r_RReadBufferAsync.SetBelong(this.instance);
				}
				return r_RReadBufferAsync;
			}
		}

		/// <summary>
		/// Boolean DataAvailable()
		/// </summary>
		protected RMethod r_RDataAvailable;
		public virtual RMethod RDataAvailable
		{
			get
			{
				if(r_RDataAvailable == null)
				{
					r_RDataAvailable = new(this, "DataAvailable", 0);
					r_RDataAvailable.SetBelong(this.instance);
				}
				return r_RDataAvailable;
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
		/// System.Threading.Tasks.ValueTask`1[System.Int32] ReadBlockAsyncInternal(System.Memory`1[System.Char], System.Threading.CancellationToken)
		/// </summary>
		protected RMethod r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken;
		public virtual RMethod RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken
		{
			get
			{
				if(r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken == null)
				{
					r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken = new(this, "ReadBlockAsyncInternal", 0, typeof(System.Memory<>).MakeGenericType(typeof(System.Char)), typeof(System.Threading.CancellationToken));
					r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken.SetBelong(this.instance);
				}
				return r_RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken;
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


        public RStreamReader() : base("System.IO.StreamReader")
        {
        }

        public RStreamReader(System.Object instance) : base("System.IO.StreamReader")
		{
            SetInstance(instance);
		}

        public RStreamReader(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RStreamReader(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void CheckAsyncTaskInProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckAsyncTaskInProgress.Invoke(___genericsType, ___parameters);

            
        }


        public static void ThrowAsyncIOInProgress()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowAsyncIOInProgress.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(System.IO.Stream  @stream, System.Text.Encoding  @encoding, System.Boolean  @detectEncodingFromByteOrderMarks, System.Int32  @bufferSize, System.Boolean  @leaveOpen)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @encoding, @detectEncodingFromByteOrderMarks, @bufferSize, @leaveOpen};
            var ___result = RInit_Stream_Encoding_Boolean_Int32_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Init(System.IO.Stream  @stream)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream};
            var ___result = RInit_Stream.Invoke(___genericsType, ___parameters);

            
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


        public virtual void DiscardBufferedData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDiscardBufferedData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 Peek()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPeek.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Read()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRead.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 Read(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RRead_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }




        public virtual System.String ReadToEnd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadToEnd.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 ReadBlock(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadBlock_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual void CompressBuffer(System.Int32  @n)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@n};
            var ___result = RCompressBuffer_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DetectEncoding()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDetectEncoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsPreamble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsPreamble.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 ReadBuffer()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadBuffer.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.String ReadLine()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadLine.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadLineAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadLineAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadLineAsyncInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadLineAsyncInternal.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadToEndAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadToEndAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadToEndAsyncInternal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadToEndAsyncInternal.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsync(System.Memory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadAsync_Memory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadAsyncInternal(System.Memory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadAsyncInternal_Memory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadBlockAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadBlockAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadBlockAsync(System.Memory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadBlockAsync_Memory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadBufferAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadBufferAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Boolean DataAvailable()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDataAvailable.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.ValueTask<System.Int32> ReadBlockAsyncInternal(System.Memory<System.Char>  @buffer, System.Threading.CancellationToken  @cancellationToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @cancellationToken};
            var ___result = RReadBlockAsyncInternal_Memory_d_Char_p__CancellationToken.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.ValueTask<System.Int32>)___result;
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
