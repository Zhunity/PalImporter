using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RText
{
	/// <summary>
	/// System.Text.UnicodeEncoding
	/// </summary>
    public partial class RUnicodeEncoding : RMember //
    {

		/// <summary>
		/// System.Text.UnicodeEncoding s_bigEndianDefault
		/// </summary>
		protected static RSystem.RText.RUnicodeEncoding r_s_bigEndianDefault;
		public static RSystem.RText.RUnicodeEncoding Rs_bigEndianDefault
		{
			get
			{
				if(r_s_bigEndianDefault == null)
				{
					r_s_bigEndianDefault = new(typeof(System.Text.UnicodeEncoding), "s_bigEndianDefault");
					r_s_bigEndianDefault.SetBelong(null);
				}
				return r_s_bigEndianDefault;
			}
		}

		/// <summary>
		/// System.Text.UnicodeEncoding s_littleEndianDefault
		/// </summary>
		protected static RSystem.RText.RUnicodeEncoding r_s_littleEndianDefault;
		public static RSystem.RText.RUnicodeEncoding Rs_littleEndianDefault
		{
			get
			{
				if(r_s_littleEndianDefault == null)
				{
					r_s_littleEndianDefault = new(typeof(System.Text.UnicodeEncoding), "s_littleEndianDefault");
					r_s_littleEndianDefault.SetBelong(null);
				}
				return r_s_littleEndianDefault;
			}
		}

		/// <summary>
		/// System.Byte[] s_bigEndianPreamble
		/// </summary>
		protected static RFieldArray<RField> r_s_bigEndianPreamble;
		public static RFieldArray<RField> Rs_bigEndianPreamble
		{
			get
			{
				if(r_s_bigEndianPreamble == null)
				{
					r_s_bigEndianPreamble = new(typeof(System.Text.UnicodeEncoding), "s_bigEndianPreamble");
					r_s_bigEndianPreamble.SetBelong(null);
				}
				return r_s_bigEndianPreamble;
			}
		}

		/// <summary>
		/// System.Byte[] s_littleEndianPreamble
		/// </summary>
		protected static RFieldArray<RField> r_s_littleEndianPreamble;
		public static RFieldArray<RField> Rs_littleEndianPreamble
		{
			get
			{
				if(r_s_littleEndianPreamble == null)
				{
					r_s_littleEndianPreamble = new(typeof(System.Text.UnicodeEncoding), "s_littleEndianPreamble");
					r_s_littleEndianPreamble.SetBelong(null);
				}
				return r_s_littleEndianPreamble;
			}
		}

		/// <summary>
		/// System.Boolean isThrowException
		/// </summary>
		protected RField r_isThrowException;
		public virtual RField RisThrowException
		{
			get
			{
				if(r_isThrowException == null)
				{
					r_isThrowException = new(this, "isThrowException");
					r_isThrowException.SetBelong(this.instance);
				}
				return r_isThrowException;
			}
		}

		/// <summary>
		/// System.Boolean bigEndian
		/// </summary>
		protected RField r_bigEndian;
		public virtual RField RbigEndian
		{
			get
			{
				if(r_bigEndian == null)
				{
					r_bigEndian = new(this, "bigEndian");
					r_bigEndian.SetBelong(this.instance);
				}
				return r_bigEndian;
			}
		}

		/// <summary>
		/// System.Boolean byteOrderMark
		/// </summary>
		protected RField r_byteOrderMark;
		public virtual RField RbyteOrderMark
		{
			get
			{
				if(r_byteOrderMark == null)
				{
					r_byteOrderMark = new(this, "byteOrderMark");
					r_byteOrderMark.SetBelong(this.instance);
				}
				return r_byteOrderMark;
			}
		}

		/// <summary>
		/// System.Int32 CharSize
		/// </summary>
		protected static RField r_CharSize;
		public static RField RCharSize
		{
			get
			{
				if(r_CharSize == null)
				{
					r_CharSize = new(typeof(System.Text.UnicodeEncoding), "CharSize");
					r_CharSize.SetBelong(null);
				}
				return r_CharSize;
			}
		}

		/// <summary>
		/// System.UInt64 highLowPatternMask
		/// </summary>
		protected static RField r_highLowPatternMask;
		public static RField RhighLowPatternMask
		{
			get
			{
				if(r_highLowPatternMask == null)
				{
					r_highLowPatternMask = new(typeof(System.Text.UnicodeEncoding), "highLowPatternMask");
					r_highLowPatternMask.SetBelong(null);
				}
				return r_highLowPatternMask;
			}
		}

		/// <summary>
		/// System.Int32 m_codePage
		/// </summary>
		protected RField r_m_codePage;
		public virtual RField Rm_codePage
		{
			get
			{
				if(r_m_codePage == null)
				{
					r_m_codePage = new(this, "m_codePage");
					r_m_codePage.SetBelong(this.instance);
				}
				return r_m_codePage;
			}
		}

		/// <summary>
		/// System.Globalization.CodePageDataItem dataItem
		/// </summary>
		protected RSystem.RGlobalization.RCodePageDataItem r_dataItem;
		public virtual RSystem.RGlobalization.RCodePageDataItem RdataItem
		{
			get
			{
				if(r_dataItem == null)
				{
					r_dataItem = new(this, "dataItem");
					r_dataItem.SetBelong(this.instance);
				}
				return r_dataItem;
			}
		}

		/// <summary>
		/// System.Boolean m_deserializedFromEverett
		/// </summary>
		protected RField r_m_deserializedFromEverett;
		public virtual RField Rm_deserializedFromEverett
		{
			get
			{
				if(r_m_deserializedFromEverett == null)
				{
					r_m_deserializedFromEverett = new(this, "m_deserializedFromEverett");
					r_m_deserializedFromEverett.SetBelong(this.instance);
				}
				return r_m_deserializedFromEverett;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback encoderFallback
		/// </summary>
		protected RSystem.RText.REncoderFallback r_encoderFallback;
		public virtual RSystem.RText.REncoderFallback RencoderFallback
		{
			get
			{
				if(r_encoderFallback == null)
				{
					r_encoderFallback = new(this, "encoderFallback");
					r_encoderFallback.SetBelong(this.instance);
				}
				return r_encoderFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback decoderFallback
		/// </summary>
		protected RSystem.RText.RDecoderFallback r_decoderFallback;
		public virtual RSystem.RText.RDecoderFallback RdecoderFallback
		{
			get
			{
				if(r_decoderFallback == null)
				{
					r_decoderFallback = new(this, "decoderFallback");
					r_decoderFallback.SetBelong(this.instance);
				}
				return r_decoderFallback;
			}
		}

		/// <summary>
		/// System.ReadOnlySpan`1[System.Byte] Preamble
		/// </summary>
		protected RSystem.RReadOnlySpan<RProperty> r_Preamble;
		public virtual RSystem.RReadOnlySpan<RProperty> RPreamble
		{
			get
			{
				if(r_Preamble == null)
				{
					r_Preamble = new(this, "Preamble", -1);
					r_Preamble.SetBelong(this.instance);
				}
				return r_Preamble;
			}
		}

		/// <summary>
		/// System.String BodyName
		/// </summary>
		protected RProperty r_BodyName;
		public virtual RProperty RBodyName
		{
			get
			{
				if(r_BodyName == null)
				{
					r_BodyName = new(this, "BodyName", -1);
					r_BodyName.SetBelong(this.instance);
				}
				return r_BodyName;
			}
		}

		/// <summary>
		/// System.String EncodingName
		/// </summary>
		protected RProperty r_EncodingName;
		public virtual RProperty REncodingName
		{
			get
			{
				if(r_EncodingName == null)
				{
					r_EncodingName = new(this, "EncodingName", -1);
					r_EncodingName.SetBelong(this.instance);
				}
				return r_EncodingName;
			}
		}

		/// <summary>
		/// System.String HeaderName
		/// </summary>
		protected RProperty r_HeaderName;
		public virtual RProperty RHeaderName
		{
			get
			{
				if(r_HeaderName == null)
				{
					r_HeaderName = new(this, "HeaderName", -1);
					r_HeaderName.SetBelong(this.instance);
				}
				return r_HeaderName;
			}
		}

		/// <summary>
		/// System.String WebName
		/// </summary>
		protected RProperty r_WebName;
		public virtual RProperty RWebName
		{
			get
			{
				if(r_WebName == null)
				{
					r_WebName = new(this, "WebName", -1);
					r_WebName.SetBelong(this.instance);
				}
				return r_WebName;
			}
		}

		/// <summary>
		/// Int32 WindowsCodePage
		/// </summary>
		protected RProperty r_WindowsCodePage;
		public virtual RProperty RWindowsCodePage
		{
			get
			{
				if(r_WindowsCodePage == null)
				{
					r_WindowsCodePage = new(this, "WindowsCodePage", -1);
					r_WindowsCodePage.SetBelong(this.instance);
				}
				return r_WindowsCodePage;
			}
		}

		/// <summary>
		/// Boolean IsBrowserDisplay
		/// </summary>
		protected RProperty r_IsBrowserDisplay;
		public virtual RProperty RIsBrowserDisplay
		{
			get
			{
				if(r_IsBrowserDisplay == null)
				{
					r_IsBrowserDisplay = new(this, "IsBrowserDisplay", -1);
					r_IsBrowserDisplay.SetBelong(this.instance);
				}
				return r_IsBrowserDisplay;
			}
		}

		/// <summary>
		/// Boolean IsBrowserSave
		/// </summary>
		protected RProperty r_IsBrowserSave;
		public virtual RProperty RIsBrowserSave
		{
			get
			{
				if(r_IsBrowserSave == null)
				{
					r_IsBrowserSave = new(this, "IsBrowserSave", -1);
					r_IsBrowserSave.SetBelong(this.instance);
				}
				return r_IsBrowserSave;
			}
		}

		/// <summary>
		/// Boolean IsMailNewsDisplay
		/// </summary>
		protected RProperty r_IsMailNewsDisplay;
		public virtual RProperty RIsMailNewsDisplay
		{
			get
			{
				if(r_IsMailNewsDisplay == null)
				{
					r_IsMailNewsDisplay = new(this, "IsMailNewsDisplay", -1);
					r_IsMailNewsDisplay.SetBelong(this.instance);
				}
				return r_IsMailNewsDisplay;
			}
		}

		/// <summary>
		/// Boolean IsMailNewsSave
		/// </summary>
		protected RProperty r_IsMailNewsSave;
		public virtual RProperty RIsMailNewsSave
		{
			get
			{
				if(r_IsMailNewsSave == null)
				{
					r_IsMailNewsSave = new(this, "IsMailNewsSave", -1);
					r_IsMailNewsSave.SetBelong(this.instance);
				}
				return r_IsMailNewsSave;
			}
		}

		/// <summary>
		/// Boolean IsSingleByte
		/// </summary>
		protected RProperty r_IsSingleByte;
		public virtual RProperty RIsSingleByte
		{
			get
			{
				if(r_IsSingleByte == null)
				{
					r_IsSingleByte = new(this, "IsSingleByte", -1);
					r_IsSingleByte.SetBelong(this.instance);
				}
				return r_IsSingleByte;
			}
		}

		/// <summary>
		/// System.Text.EncoderFallback EncoderFallback
		/// </summary>
		protected RSystem.RText.REncoderFallback r_EncoderFallback;
		public virtual RSystem.RText.REncoderFallback REncoderFallback
		{
			get
			{
				if(r_EncoderFallback == null)
				{
					r_EncoderFallback = new(this, "EncoderFallback", -1);
					r_EncoderFallback.SetBelong(this.instance);
				}
				return r_EncoderFallback;
			}
		}

		/// <summary>
		/// System.Text.DecoderFallback DecoderFallback
		/// </summary>
		protected RSystem.RText.RDecoderFallback r_DecoderFallback;
		public virtual RSystem.RText.RDecoderFallback RDecoderFallback
		{
			get
			{
				if(r_DecoderFallback == null)
				{
					r_DecoderFallback = new(this, "DecoderFallback", -1);
					r_DecoderFallback.SetBelong(this.instance);
				}
				return r_DecoderFallback;
			}
		}

		/// <summary>
		/// Boolean IsReadOnly
		/// </summary>
		protected RProperty r_IsReadOnly;
		public virtual RProperty RIsReadOnly
		{
			get
			{
				if(r_IsReadOnly == null)
				{
					r_IsReadOnly = new(this, "IsReadOnly", -1);
					r_IsReadOnly.SetBelong(this.instance);
				}
				return r_IsReadOnly;
			}
		}

		/// <summary>
		/// Int32 CodePage
		/// </summary>
		protected RProperty r_CodePage;
		public virtual RProperty RCodePage
		{
			get
			{
				if(r_CodePage == null)
				{
					r_CodePage = new(this, "CodePage", -1);
					r_CodePage.SetBelong(this.instance);
				}
				return r_CodePage;
			}
		}

		/// <summary>
		/// Void SetDefaultFallbacks()
		/// </summary>
		protected RMethod r_RSetDefaultFallbacks;
		public virtual RMethod RSetDefaultFallbacks
		{
			get
			{
				if(r_RSetDefaultFallbacks == null)
				{
					r_RSetDefaultFallbacks = new(this, "SetDefaultFallbacks", 0);
					r_RSetDefaultFallbacks.SetBelong(this.instance);
				}
				return r_RSetDefaultFallbacks;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RGetByteCount_CharArray_Int32_Int32;
		public virtual RMethod RGetByteCount_CharArray_Int32_Int32
		{
			get
			{
				if(r_RGetByteCount_CharArray_Int32_Int32 == null)
				{
					r_RGetByteCount_CharArray_Int32_Int32 = new(this, "GetByteCount", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RGetByteCount_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetByteCount_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.String)
		/// </summary>
		protected RMethod r_RGetByteCount_String;
		public virtual RMethod RGetByteCount_String
		{
			get
			{
				if(r_RGetByteCount_String == null)
				{
					r_RGetByteCount_String = new(this, "GetByteCount", 0, typeof(System.String));
					r_RGetByteCount_String.SetBelong(this.instance);
				}
				return r_RGetByteCount_String;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char*, Int32)
		/// </summary>
		protected RMethod r_RGetByteCount_CharPointer_Int32;
		public virtual RMethod RGetByteCount_CharPointer_Int32
		{
			get
			{
				if(r_RGetByteCount_CharPointer_Int32 == null)
				{
					r_RGetByteCount_CharPointer_Int32 = new(this, "GetByteCount", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_RGetByteCount_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_RGetByteCount_CharPointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBytes(System.String, Int32, Int32, Byte[], Int32)
		/// </summary>
		protected RMethod r_RGetBytes_String_Int32_Int32_ByteArray_Int32;
		public virtual RMethod RGetBytes_String_Int32_Int32_ByteArray_Int32
		{
			get
			{
				if(r_RGetBytes_String_Int32_Int32_ByteArray_Int32 == null)
				{
					r_RGetBytes_String_Int32_Int32_ByteArray_Int32 = new(this, "GetBytes", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_RGetBytes_String_Int32_Int32_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_RGetBytes_String_Int32_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char[], Int32, Int32, Byte[], Int32)
		/// </summary>
		protected RMethod r_RGetBytes_CharArray_Int32_Int32_ByteArray_Int32;
		public virtual RMethod RGetBytes_CharArray_Int32_Int32_ByteArray_Int32
		{
			get
			{
				if(r_RGetBytes_CharArray_Int32_Int32_ByteArray_Int32 == null)
				{
					r_RGetBytes_CharArray_Int32_Int32_ByteArray_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32));
					r_RGetBytes_CharArray_Int32_Int32_ByteArray_Int32.SetBelong(this.instance);
				}
				return r_RGetBytes_CharArray_Int32_Int32_ByteArray_Int32;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char*, Int32, Byte*, Int32)
		/// </summary>
		protected RMethod r_RGetBytes_CharPointer_Int32_BytePointer_Int32;
		public virtual RMethod RGetBytes_CharPointer_Int32_BytePointer_Int32
		{
			get
			{
				if(r_RGetBytes_CharPointer_Int32_BytePointer_Int32 == null)
				{
					r_RGetBytes_CharPointer_Int32_BytePointer_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_RGetBytes_CharPointer_Int32_BytePointer_Int32.SetBelong(this.instance);
				}
				return r_RGetBytes_CharPointer_Int32_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RGetCharCount_ByteArray_Int32_Int32;
		public virtual RMethod RGetCharCount_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RGetCharCount_ByteArray_Int32_Int32 == null)
				{
					r_RGetCharCount_ByteArray_Int32_Int32 = new(this, "GetCharCount", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RGetCharCount_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetCharCount_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte*, Int32)
		/// </summary>
		protected RMethod r_RGetCharCount_BytePointer_Int32;
		public virtual RMethod RGetCharCount_BytePointer_Int32
		{
			get
			{
				if(r_RGetCharCount_BytePointer_Int32 == null)
				{
					r_RGetCharCount_BytePointer_Int32 = new(this, "GetCharCount", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_RGetCharCount_BytePointer_Int32.SetBelong(this.instance);
				}
				return r_RGetCharCount_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte[], Int32, Int32, Char[], Int32)
		/// </summary>
		protected RMethod r_RGetChars_ByteArray_Int32_Int32_CharArray_Int32;
		public virtual RMethod RGetChars_ByteArray_Int32_Int32_CharArray_Int32
		{
			get
			{
				if(r_RGetChars_ByteArray_Int32_Int32_CharArray_Int32 == null)
				{
					r_RGetChars_ByteArray_Int32_Int32_CharArray_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32));
					r_RGetChars_ByteArray_Int32_Int32_CharArray_Int32.SetBelong(this.instance);
				}
				return r_RGetChars_ByteArray_Int32_Int32_CharArray_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte*, Int32, Char*, Int32)
		/// </summary>
		protected RMethod r_RGetChars_BytePointer_Int32_CharPointer_Int32;
		public virtual RMethod RGetChars_BytePointer_Int32_CharPointer_Int32
		{
			get
			{
				if(r_RGetChars_BytePointer_Int32_CharPointer_Int32 == null)
				{
					r_RGetChars_BytePointer_Int32_CharPointer_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32));
					r_RGetChars_BytePointer_Int32_CharPointer_Int32.SetBelong(this.instance);
				}
				return r_RGetChars_BytePointer_Int32_CharPointer_Int32;
			}
		}

		/// <summary>
		/// System.String GetString(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RGetString_ByteArray_Int32_Int32;
		public virtual RMethod RGetString_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RGetString_ByteArray_Int32_Int32 == null)
				{
					r_RGetString_ByteArray_Int32_Int32 = new(this, "GetString", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RGetString_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetString_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char*, Int32, System.Text.EncoderNLS)
		/// </summary>
		protected RMethod r_RGetByteCount_CharPointer_Int32_EncoderNLS;
		public virtual RMethod RGetByteCount_CharPointer_Int32_EncoderNLS
		{
			get
			{
				if(r_RGetByteCount_CharPointer_Int32_EncoderNLS == null)
				{
					r_RGetByteCount_CharPointer_Int32_EncoderNLS = new(this, "GetByteCount", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32),  ReleactionUtils.GetType("System.Text.EncoderNLS"));
					r_RGetByteCount_CharPointer_Int32_EncoderNLS.SetBelong(this.instance);
				}
				return r_RGetByteCount_CharPointer_Int32_EncoderNLS;
			}
		}

		/// <summary>
		/// Int32 GetBytes(Char*, Int32, Byte*, Int32, System.Text.EncoderNLS)
		/// </summary>
		protected RMethod r_RGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS;
		public virtual RMethod RGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS
		{
			get
			{
				if(r_RGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS == null)
				{
					r_RGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS = new(this, "GetBytes", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Byte).MakePointerType(), typeof(System.Int32),  ReleactionUtils.GetType("System.Text.EncoderNLS"));
					r_RGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS.SetBelong(this.instance);
				}
				return r_RGetBytes_CharPointer_Int32_BytePointer_Int32_EncoderNLS;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte*, Int32, System.Text.DecoderNLS)
		/// </summary>
		protected RMethod r_RGetCharCount_BytePointer_Int32_DecoderNLS;
		public virtual RMethod RGetCharCount_BytePointer_Int32_DecoderNLS
		{
			get
			{
				if(r_RGetCharCount_BytePointer_Int32_DecoderNLS == null)
				{
					r_RGetCharCount_BytePointer_Int32_DecoderNLS = new(this, "GetCharCount", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32),  ReleactionUtils.GetType("System.Text.DecoderNLS"));
					r_RGetCharCount_BytePointer_Int32_DecoderNLS.SetBelong(this.instance);
				}
				return r_RGetCharCount_BytePointer_Int32_DecoderNLS;
			}
		}

		/// <summary>
		/// Int32 GetChars(Byte*, Int32, Char*, Int32, System.Text.DecoderNLS)
		/// </summary>
		protected RMethod r_RGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS;
		public virtual RMethod RGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS
		{
			get
			{
				if(r_RGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS == null)
				{
					r_RGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS = new(this, "GetChars", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32), typeof(System.Char).MakePointerType(), typeof(System.Int32),  ReleactionUtils.GetType("System.Text.DecoderNLS"));
					r_RGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS.SetBelong(this.instance);
				}
				return r_RGetChars_BytePointer_Int32_CharPointer_Int32_DecoderNLS;
			}
		}

		/// <summary>
		/// System.Text.Encoder GetEncoder()
		/// </summary>
		protected RMethod r_RGetEncoder;
		public virtual RMethod RGetEncoder
		{
			get
			{
				if(r_RGetEncoder == null)
				{
					r_RGetEncoder = new(this, "GetEncoder", 0);
					r_RGetEncoder.SetBelong(this.instance);
				}
				return r_RGetEncoder;
			}
		}

		/// <summary>
		/// System.Text.Decoder GetDecoder()
		/// </summary>
		protected RMethod r_RGetDecoder;
		public virtual RMethod RGetDecoder
		{
			get
			{
				if(r_RGetDecoder == null)
				{
					r_RGetDecoder = new(this, "GetDecoder", 0);
					r_RGetDecoder.SetBelong(this.instance);
				}
				return r_RGetDecoder;
			}
		}

		/// <summary>
		/// Byte[] GetPreamble()
		/// </summary>
		protected RMethod r_RGetPreamble;
		public virtual RMethod RGetPreamble
		{
			get
			{
				if(r_RGetPreamble == null)
				{
					r_RGetPreamble = new(this, "GetPreamble", 0);
					r_RGetPreamble.SetBelong(this.instance);
				}
				return r_RGetPreamble;
			}
		}

		/// <summary>
		/// Int32 GetMaxByteCount(Int32)
		/// </summary>
		protected RMethod r_RGetMaxByteCount_Int32;
		public virtual RMethod RGetMaxByteCount_Int32
		{
			get
			{
				if(r_RGetMaxByteCount_Int32 == null)
				{
					r_RGetMaxByteCount_Int32 = new(this, "GetMaxByteCount", 0, typeof(System.Int32));
					r_RGetMaxByteCount_Int32.SetBelong(this.instance);
				}
				return r_RGetMaxByteCount_Int32;
			}
		}

		/// <summary>
		/// Int32 GetMaxCharCount(Int32)
		/// </summary>
		protected RMethod r_RGetMaxCharCount_Int32;
		public virtual RMethod RGetMaxCharCount_Int32
		{
			get
			{
				if(r_RGetMaxCharCount_Int32 == null)
				{
					r_RGetMaxCharCount_Int32 = new(this, "GetMaxCharCount", 0, typeof(System.Int32));
					r_RGetMaxCharCount_Int32.SetBelong(this.instance);
				}
				return r_RGetMaxCharCount_Int32;
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
		/// Void OnDeserializing()
		/// </summary>
		protected RMethod r_ROnDeserializing;
		public virtual RMethod ROnDeserializing
		{
			get
			{
				if(r_ROnDeserializing == null)
				{
					r_ROnDeserializing = new(this, "OnDeserializing", 0);
					r_ROnDeserializing.SetBelong(this.instance);
				}
				return r_ROnDeserializing;
			}
		}

		/// <summary>
		/// Void OnDeserialized()
		/// </summary>
		protected RMethod r_ROnDeserialized;
		public virtual RMethod ROnDeserialized
		{
			get
			{
				if(r_ROnDeserialized == null)
				{
					r_ROnDeserialized = new(this, "OnDeserialized", 0);
					r_ROnDeserialized.SetBelong(this.instance);
				}
				return r_ROnDeserialized;
			}
		}

		/// <summary>
		/// Void DeserializeEncoding(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RDeserializeEncoding_SerializationInfo_StreamingContext;
		public virtual RMethod RDeserializeEncoding_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RDeserializeEncoding_SerializationInfo_StreamingContext == null)
				{
					r_RDeserializeEncoding_SerializationInfo_StreamingContext = new(this, "DeserializeEncoding", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RDeserializeEncoding_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RDeserializeEncoding_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// Void SerializeEncoding(System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext)
		/// </summary>
		protected RMethod r_RSerializeEncoding_SerializationInfo_StreamingContext;
		public virtual RMethod RSerializeEncoding_SerializationInfo_StreamingContext
		{
			get
			{
				if(r_RSerializeEncoding_SerializationInfo_StreamingContext == null)
				{
					r_RSerializeEncoding_SerializationInfo_StreamingContext = new(this, "SerializeEncoding", 0, typeof(System.Runtime.Serialization.SerializationInfo), typeof(System.Runtime.Serialization.StreamingContext));
					r_RSerializeEncoding_SerializationInfo_StreamingContext.SetBelong(this.instance);
				}
				return r_RSerializeEncoding_SerializationInfo_StreamingContext;
			}
		}

		/// <summary>
		/// System.Object Clone()
		/// </summary>
		protected RMethod r_RClone;
		public virtual RMethod RClone
		{
			get
			{
				if(r_RClone == null)
				{
					r_RClone = new(this, "Clone", 0);
					r_RClone.SetBelong(this.instance);
				}
				return r_RClone;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(Char[])
		/// </summary>
		protected RMethod r_RGetByteCount_CharArray;
		public virtual RMethod RGetByteCount_CharArray
		{
			get
			{
				if(r_RGetByteCount_CharArray == null)
				{
					r_RGetByteCount_CharArray = new(this, "GetByteCount", 0, typeof(System.Char).MakeArrayType());
					r_RGetByteCount_CharArray.SetBelong(this.instance);
				}
				return r_RGetByteCount_CharArray;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetByteCount_String_Int32_Int32;
		public virtual RMethod RGetByteCount_String_Int32_Int32
		{
			get
			{
				if(r_RGetByteCount_String_Int32_Int32 == null)
				{
					r_RGetByteCount_String_Int32_Int32 = new(this, "GetByteCount", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RGetByteCount_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetByteCount_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(Char[])
		/// </summary>
		protected RMethod r_RGetBytes_CharArray;
		public virtual RMethod RGetBytes_CharArray
		{
			get
			{
				if(r_RGetBytes_CharArray == null)
				{
					r_RGetBytes_CharArray = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType());
					r_RGetBytes_CharArray.SetBelong(this.instance);
				}
				return r_RGetBytes_CharArray;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RGetBytes_CharArray_Int32_Int32;
		public virtual RMethod RGetBytes_CharArray_Int32_Int32
		{
			get
			{
				if(r_RGetBytes_CharArray_Int32_Int32 == null)
				{
					r_RGetBytes_CharArray_Int32_Int32 = new(this, "GetBytes", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RGetBytes_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetBytes_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(System.String)
		/// </summary>
		protected RMethod r_RGetBytes_String;
		public virtual RMethod RGetBytes_String
		{
			get
			{
				if(r_RGetBytes_String == null)
				{
					r_RGetBytes_String = new(this, "GetBytes", 0, typeof(System.String));
					r_RGetBytes_String.SetBelong(this.instance);
				}
				return r_RGetBytes_String;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(Byte[])
		/// </summary>
		protected RMethod r_RGetCharCount_ByteArray;
		public virtual RMethod RGetCharCount_ByteArray
		{
			get
			{
				if(r_RGetCharCount_ByteArray == null)
				{
					r_RGetCharCount_ByteArray = new(this, "GetCharCount", 0, typeof(System.Byte).MakeArrayType());
					r_RGetCharCount_ByteArray.SetBelong(this.instance);
				}
				return r_RGetCharCount_ByteArray;
			}
		}

		/// <summary>
		/// Char[] GetChars(Byte[])
		/// </summary>
		protected RMethod r_RGetChars_ByteArray;
		public virtual RMethod RGetChars_ByteArray
		{
			get
			{
				if(r_RGetChars_ByteArray == null)
				{
					r_RGetChars_ByteArray = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType());
					r_RGetChars_ByteArray.SetBelong(this.instance);
				}
				return r_RGetChars_ByteArray;
			}
		}

		/// <summary>
		/// Char[] GetChars(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RGetChars_ByteArray_Int32_Int32;
		public virtual RMethod RGetChars_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RGetChars_ByteArray_Int32_Int32 == null)
				{
					r_RGetChars_ByteArray_Int32_Int32 = new(this, "GetChars", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RGetChars_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetChars_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.String GetString(Byte*, Int32)
		/// </summary>
		protected RMethod r_RGetString_BytePointer_Int32;
		public virtual RMethod RGetString_BytePointer_Int32
		{
			get
			{
				if(r_RGetString_BytePointer_Int32 == null)
				{
					r_RGetString_BytePointer_Int32 = new(this, "GetString", 0, typeof(System.Byte).MakePointerType(), typeof(System.Int32));
					r_RGetString_BytePointer_Int32.SetBelong(this.instance);
				}
				return r_RGetString_BytePointer_Int32;
			}
		}

		/// <summary>
		/// Int32 GetChars(System.ReadOnlySpan`1[System.Byte], System.Span`1[System.Char])
		/// </summary>
		protected RMethod r_RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_;
		public virtual RMethod RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_
		{
			get
			{
				if(r_RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_ == null)
				{
					r_RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_ = new(this, "GetChars", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)), typeof(System.Span<>).MakeGenericType(typeof(System.Char)));
					r_RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_.SetBelong(this.instance);
				}
				return r_RGetChars_ReadOnlySpan_d_Byte_p__Span_d_Char_p_;
			}
		}

		/// <summary>
		/// System.String GetString(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_RGetString_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RGetString_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_RGetString_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_RGetString_ReadOnlySpan_d_Byte_p_ = new(this, "GetString", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_RGetString_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RGetString_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Boolean IsAlwaysNormalized()
		/// </summary>
		protected RMethod r_RIsAlwaysNormalized;
		public virtual RMethod RIsAlwaysNormalized
		{
			get
			{
				if(r_RIsAlwaysNormalized == null)
				{
					r_RIsAlwaysNormalized = new(this, "IsAlwaysNormalized", 0);
					r_RIsAlwaysNormalized.SetBelong(this.instance);
				}
				return r_RIsAlwaysNormalized;
			}
		}

		/// <summary>
		/// Boolean IsAlwaysNormalized(System.Text.NormalizationForm)
		/// </summary>
		protected RMethod r_RIsAlwaysNormalized_NormalizationForm;
		public virtual RMethod RIsAlwaysNormalized_NormalizationForm
		{
			get
			{
				if(r_RIsAlwaysNormalized_NormalizationForm == null)
				{
					r_RIsAlwaysNormalized_NormalizationForm = new(this, "IsAlwaysNormalized", 0, typeof(System.Text.NormalizationForm));
					r_RIsAlwaysNormalized_NormalizationForm.SetBelong(this.instance);
				}
				return r_RIsAlwaysNormalized_NormalizationForm;
			}
		}

		/// <summary>
		/// Void setReadOnly(Boolean)
		/// </summary>
		protected RMethod r_RsetReadOnly_Boolean;
		public virtual RMethod RsetReadOnly_Boolean
		{
			get
			{
				if(r_RsetReadOnly_Boolean == null)
				{
					r_RsetReadOnly_Boolean = new(this, "setReadOnly", 0, typeof(System.Boolean));
					r_RsetReadOnly_Boolean.SetBelong(this.instance);
				}
				return r_RsetReadOnly_Boolean;
			}
		}

		/// <summary>
		/// System.String GetString(Byte[])
		/// </summary>
		protected RMethod r_RGetString_ByteArray;
		public virtual RMethod RGetString_ByteArray
		{
			get
			{
				if(r_RGetString_ByteArray == null)
				{
					r_RGetString_ByteArray = new(this, "GetString", 0, typeof(System.Byte).MakeArrayType());
					r_RGetString_ByteArray.SetBelong(this.instance);
				}
				return r_RGetString_ByteArray;
			}
		}

		/// <summary>
		/// Char[] GetBestFitUnicodeToBytesData()
		/// </summary>
		protected RMethod r_RGetBestFitUnicodeToBytesData;
		public virtual RMethod RGetBestFitUnicodeToBytesData
		{
			get
			{
				if(r_RGetBestFitUnicodeToBytesData == null)
				{
					r_RGetBestFitUnicodeToBytesData = new(this, "GetBestFitUnicodeToBytesData", 0);
					r_RGetBestFitUnicodeToBytesData.SetBelong(this.instance);
				}
				return r_RGetBestFitUnicodeToBytesData;
			}
		}

		/// <summary>
		/// Char[] GetBestFitBytesToUnicodeData()
		/// </summary>
		protected RMethod r_RGetBestFitBytesToUnicodeData;
		public virtual RMethod RGetBestFitBytesToUnicodeData
		{
			get
			{
				if(r_RGetBestFitBytesToUnicodeData == null)
				{
					r_RGetBestFitBytesToUnicodeData = new(this, "GetBestFitBytesToUnicodeData", 0);
					r_RGetBestFitBytesToUnicodeData.SetBelong(this.instance);
				}
				return r_RGetBestFitBytesToUnicodeData;
			}
		}

		/// <summary>
		/// Void ThrowBytesOverflow()
		/// </summary>
		protected RMethod r_RThrowBytesOverflow;
		public virtual RMethod RThrowBytesOverflow
		{
			get
			{
				if(r_RThrowBytesOverflow == null)
				{
					r_RThrowBytesOverflow = new(this, "ThrowBytesOverflow", 0);
					r_RThrowBytesOverflow.SetBelong(this.instance);
				}
				return r_RThrowBytesOverflow;
			}
		}

		/// <summary>
		/// Void ThrowBytesOverflow(System.Text.EncoderNLS, Boolean)
		/// </summary>
		protected RMethod r_RThrowBytesOverflow_EncoderNLS_Boolean;
		public virtual RMethod RThrowBytesOverflow_EncoderNLS_Boolean
		{
			get
			{
				if(r_RThrowBytesOverflow_EncoderNLS_Boolean == null)
				{
					r_RThrowBytesOverflow_EncoderNLS_Boolean = new(this, "ThrowBytesOverflow", 0,  ReleactionUtils.GetType("System.Text.EncoderNLS"), typeof(System.Boolean));
					r_RThrowBytesOverflow_EncoderNLS_Boolean.SetBelong(this.instance);
				}
				return r_RThrowBytesOverflow_EncoderNLS_Boolean;
			}
		}

		/// <summary>
		/// Void ThrowCharsOverflow()
		/// </summary>
		protected RMethod r_RThrowCharsOverflow;
		public virtual RMethod RThrowCharsOverflow
		{
			get
			{
				if(r_RThrowCharsOverflow == null)
				{
					r_RThrowCharsOverflow = new(this, "ThrowCharsOverflow", 0);
					r_RThrowCharsOverflow.SetBelong(this.instance);
				}
				return r_RThrowCharsOverflow;
			}
		}

		/// <summary>
		/// Void ThrowCharsOverflow(System.Text.DecoderNLS, Boolean)
		/// </summary>
		protected RMethod r_RThrowCharsOverflow_DecoderNLS_Boolean;
		public virtual RMethod RThrowCharsOverflow_DecoderNLS_Boolean
		{
			get
			{
				if(r_RThrowCharsOverflow_DecoderNLS_Boolean == null)
				{
					r_RThrowCharsOverflow_DecoderNLS_Boolean = new(this, "ThrowCharsOverflow", 0,  ReleactionUtils.GetType("System.Text.DecoderNLS"), typeof(System.Boolean));
					r_RThrowCharsOverflow_DecoderNLS_Boolean.SetBelong(this.instance);
				}
				return r_RThrowCharsOverflow_DecoderNLS_Boolean;
			}
		}

		/// <summary>
		/// Int32 GetCharCount(System.ReadOnlySpan`1[System.Byte])
		/// </summary>
		protected RMethod r_RGetCharCount_ReadOnlySpan_d_Byte_p_;
		public virtual RMethod RGetCharCount_ReadOnlySpan_d_Byte_p_
		{
			get
			{
				if(r_RGetCharCount_ReadOnlySpan_d_Byte_p_ == null)
				{
					r_RGetCharCount_ReadOnlySpan_d_Byte_p_ = new(this, "GetCharCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Byte)));
					r_RGetCharCount_ReadOnlySpan_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RGetCharCount_ReadOnlySpan_d_Byte_p_;
			}
		}

		/// <summary>
		/// Int32 GetByteCount(System.ReadOnlySpan`1[System.Char])
		/// </summary>
		protected RMethod r_RGetByteCount_ReadOnlySpan_d_Char_p_;
		public virtual RMethod RGetByteCount_ReadOnlySpan_d_Char_p_
		{
			get
			{
				if(r_RGetByteCount_ReadOnlySpan_d_Char_p_ == null)
				{
					r_RGetByteCount_ReadOnlySpan_d_Char_p_ = new(this, "GetByteCount", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)));
					r_RGetByteCount_ReadOnlySpan_d_Char_p_.SetBelong(this.instance);
				}
				return r_RGetByteCount_ReadOnlySpan_d_Char_p_;
			}
		}

		/// <summary>
		/// Int32 GetBytes(System.ReadOnlySpan`1[System.Char], System.Span`1[System.Byte])
		/// </summary>
		protected RMethod r_RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_;
		public virtual RMethod RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_
		{
			get
			{
				if(r_RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_ == null)
				{
					r_RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_ = new(this, "GetBytes", 0, typeof(System.ReadOnlySpan<>).MakeGenericType(typeof(System.Char)), typeof(System.Span<>).MakeGenericType(typeof(System.Byte)));
					r_RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_.SetBelong(this.instance);
				}
				return r_RGetBytes_ReadOnlySpan_d_Char_p__Span_d_Byte_p_;
			}
		}

		/// <summary>
		/// Byte[] GetBytes(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RGetBytes_String_Int32_Int32;
		public virtual RMethod RGetBytes_String_Int32_Int32
		{
			get
			{
				if(r_RGetBytes_String_Int32_Int32 == null)
				{
					r_RGetBytes_String_Int32_Int32 = new(this, "GetBytes", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RGetBytes_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RGetBytes_String_Int32_Int32;
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


        public RUnicodeEncoding() : base("System.Text.UnicodeEncoding")
        {
        }

        public RUnicodeEncoding(System.Object instance) : base("System.Text.UnicodeEncoding")
		{
            SetInstance(instance);
		}

        public RUnicodeEncoding(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RUnicodeEncoding(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void SetDefaultFallbacks()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetDefaultFallbacks.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetByteCount(System.Char[]  @chars, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RGetByteCount_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RGetByteCount_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 GetBytes(System.String  @s, System.Int32  @charIndex, System.Int32  @charCount, System.Byte[]  @bytes, System.Int32  @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @charIndex, @charCount, @bytes, @byteIndex};
            var ___result = RGetBytes_String_Int32_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetBytes(System.Char[]  @chars, System.Int32  @charIndex, System.Int32  @charCount, System.Byte[]  @bytes, System.Int32  @byteIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @charIndex, @charCount, @bytes, @byteIndex};
            var ___result = RGetBytes_CharArray_Int32_Int32_ByteArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 GetCharCount(System.Byte[]  @bytes, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RGetCharCount_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.Int32 GetChars(System.Byte[]  @bytes, System.Int32  @byteIndex, System.Int32  @byteCount, System.Char[]  @chars, System.Int32  @charIndex)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @byteIndex, @byteCount, @chars, @charIndex};
            var ___result = RGetChars_ByteArray_Int32_Int32_CharArray_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }



        public virtual System.String GetString(System.Byte[]  @bytes, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RGetString_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }






        public virtual System.Text.Encoder GetEncoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetEncoder.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoder)___result;
        }


        public virtual System.Text.Decoder GetDecoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetDecoder.Invoke(___genericsType, ___parameters);

            return (System.Text.Decoder)___result;
        }


        public virtual System.Byte[] GetPreamble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetPreamble.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Int32 GetMaxByteCount(System.Int32  @charCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@charCount};
            var ___result = RGetMaxByteCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetMaxCharCount(System.Int32  @byteCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@byteCount};
            var ___result = RGetMaxCharCount_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean Equals(System.Object  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = REquals_Object.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 GetHashCode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetHashCode.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void OnDeserializing()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDeserializing.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnDeserialized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnDeserialized.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DeserializeEncoding(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RDeserializeEncoding_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SerializeEncoding(System.Runtime.Serialization.SerializationInfo  @info, System.Runtime.Serialization.StreamingContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@info, @context};
            var ___result = RSerializeEncoding_SerializationInfo_StreamingContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Object Clone()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClone.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 GetByteCount(System.Char[]  @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars};
            var ___result = RGetByteCount_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetByteCount(System.String  @str, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @index, @count};
            var ___result = RGetByteCount_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Byte[] GetBytes(System.Char[]  @chars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars};
            var ___result = RGetBytes_CharArray.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetBytes(System.Char[]  @chars, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @index, @count};
            var ___result = RGetBytes_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Byte[] GetBytes(System.String  @s)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s};
            var ___result = RGetBytes_String.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
        }


        public virtual System.Int32 GetCharCount(System.Byte[]  @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RGetCharCount_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Char[] GetChars(System.Byte[]  @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RGetChars_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Char[] GetChars(System.Byte[]  @bytes, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes, @index, @count};
            var ___result = RGetChars_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }





        public virtual System.Boolean IsAlwaysNormalized()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsAlwaysNormalized.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAlwaysNormalized(System.Text.NormalizationForm  @form)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@form};
            var ___result = RIsAlwaysNormalized_NormalizationForm.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void setReadOnly(System.Boolean  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RsetReadOnly_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetString(System.Byte[]  @bytes)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytes};
            var ___result = RGetString_ByteArray.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Char[] GetBestFitUnicodeToBytesData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBestFitUnicodeToBytesData.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual System.Char[] GetBestFitBytesToUnicodeData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetBestFitBytesToUnicodeData.Invoke(___genericsType, ___parameters);

            return (System.Char[])___result;
        }


        public virtual void ThrowBytesOverflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowBytesOverflow.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ThrowCharsOverflow()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowCharsOverflow.Invoke(___genericsType, ___parameters);

            
        }






        public virtual System.Byte[] GetBytes(System.String  @s, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@s, @index, @count};
            var ___result = RGetBytes_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Byte[])___result;
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


        public virtual System.String ToString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RToString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


    }
}
