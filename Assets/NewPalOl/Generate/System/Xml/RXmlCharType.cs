using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlCharType
	/// </summary>
    public partial class RXmlCharType : RMember //
    {

		/// <summary>
		/// System.Int32 SurHighStart
		/// </summary>
		protected static RField r_SurHighStart;
		public static RField RSurHighStart
		{
			get
			{
				if(r_SurHighStart == null)
				{
					r_SurHighStart = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "SurHighStart");
					r_SurHighStart.SetBelong(null);
				}
				return r_SurHighStart;
			}
		}

		/// <summary>
		/// System.Int32 SurHighEnd
		/// </summary>
		protected static RField r_SurHighEnd;
		public static RField RSurHighEnd
		{
			get
			{
				if(r_SurHighEnd == null)
				{
					r_SurHighEnd = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "SurHighEnd");
					r_SurHighEnd.SetBelong(null);
				}
				return r_SurHighEnd;
			}
		}

		/// <summary>
		/// System.Int32 SurLowStart
		/// </summary>
		protected static RField r_SurLowStart;
		public static RField RSurLowStart
		{
			get
			{
				if(r_SurLowStart == null)
				{
					r_SurLowStart = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "SurLowStart");
					r_SurLowStart.SetBelong(null);
				}
				return r_SurLowStart;
			}
		}

		/// <summary>
		/// System.Int32 SurLowEnd
		/// </summary>
		protected static RField r_SurLowEnd;
		public static RField RSurLowEnd
		{
			get
			{
				if(r_SurLowEnd == null)
				{
					r_SurLowEnd = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "SurLowEnd");
					r_SurLowEnd.SetBelong(null);
				}
				return r_SurLowEnd;
			}
		}

		/// <summary>
		/// System.Int32 SurMask
		/// </summary>
		protected static RField r_SurMask;
		public static RField RSurMask
		{
			get
			{
				if(r_SurMask == null)
				{
					r_SurMask = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "SurMask");
					r_SurMask.SetBelong(null);
				}
				return r_SurMask;
			}
		}

		/// <summary>
		/// System.Int32 fWhitespace
		/// </summary>
		protected static RField r_fWhitespace;
		public static RField RfWhitespace
		{
			get
			{
				if(r_fWhitespace == null)
				{
					r_fWhitespace = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "fWhitespace");
					r_fWhitespace.SetBelong(null);
				}
				return r_fWhitespace;
			}
		}

		/// <summary>
		/// System.Int32 fLetter
		/// </summary>
		protected static RField r_fLetter;
		public static RField RfLetter
		{
			get
			{
				if(r_fLetter == null)
				{
					r_fLetter = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "fLetter");
					r_fLetter.SetBelong(null);
				}
				return r_fLetter;
			}
		}

		/// <summary>
		/// System.Int32 fNCStartNameSC
		/// </summary>
		protected static RField r_fNCStartNameSC;
		public static RField RfNCStartNameSC
		{
			get
			{
				if(r_fNCStartNameSC == null)
				{
					r_fNCStartNameSC = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "fNCStartNameSC");
					r_fNCStartNameSC.SetBelong(null);
				}
				return r_fNCStartNameSC;
			}
		}

		/// <summary>
		/// System.Int32 fNCNameSC
		/// </summary>
		protected static RField r_fNCNameSC;
		public static RField RfNCNameSC
		{
			get
			{
				if(r_fNCNameSC == null)
				{
					r_fNCNameSC = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "fNCNameSC");
					r_fNCNameSC.SetBelong(null);
				}
				return r_fNCNameSC;
			}
		}

		/// <summary>
		/// System.Int32 fCharData
		/// </summary>
		protected static RField r_fCharData;
		public static RField RfCharData
		{
			get
			{
				if(r_fCharData == null)
				{
					r_fCharData = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "fCharData");
					r_fCharData.SetBelong(null);
				}
				return r_fCharData;
			}
		}

		/// <summary>
		/// System.Int32 fNCNameXml4e
		/// </summary>
		protected static RField r_fNCNameXml4e;
		public static RField RfNCNameXml4e
		{
			get
			{
				if(r_fNCNameXml4e == null)
				{
					r_fNCNameXml4e = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "fNCNameXml4e");
					r_fNCNameXml4e.SetBelong(null);
				}
				return r_fNCNameXml4e;
			}
		}

		/// <summary>
		/// System.Int32 fText
		/// </summary>
		protected static RField r_fText;
		public static RField RfText
		{
			get
			{
				if(r_fText == null)
				{
					r_fText = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "fText");
					r_fText.SetBelong(null);
				}
				return r_fText;
			}
		}

		/// <summary>
		/// System.Int32 fAttrValue
		/// </summary>
		protected static RField r_fAttrValue;
		public static RField RfAttrValue
		{
			get
			{
				if(r_fAttrValue == null)
				{
					r_fAttrValue = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "fAttrValue");
					r_fAttrValue.SetBelong(null);
				}
				return r_fAttrValue;
			}
		}

		/// <summary>
		/// System.String s_PublicIdBitmap
		/// </summary>
		protected static RField r_s_PublicIdBitmap;
		public static RField Rs_PublicIdBitmap
		{
			get
			{
				if(r_s_PublicIdBitmap == null)
				{
					r_s_PublicIdBitmap = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_PublicIdBitmap");
					r_s_PublicIdBitmap.SetBelong(null);
				}
				return r_s_PublicIdBitmap;
			}
		}

		/// <summary>
		/// System.UInt32 CharPropertiesSize
		/// </summary>
		protected static RField r_CharPropertiesSize;
		public static RField RCharPropertiesSize
		{
			get
			{
				if(r_CharPropertiesSize == null)
				{
					r_CharPropertiesSize = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "CharPropertiesSize");
					r_CharPropertiesSize.SetBelong(null);
				}
				return r_CharPropertiesSize;
			}
		}

		/// <summary>
		/// System.String s_Whitespace
		/// </summary>
		protected static RField r_s_Whitespace;
		public static RField Rs_Whitespace
		{
			get
			{
				if(r_s_Whitespace == null)
				{
					r_s_Whitespace = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_Whitespace");
					r_s_Whitespace.SetBelong(null);
				}
				return r_s_Whitespace;
			}
		}

		/// <summary>
		/// System.String s_NCStartName
		/// </summary>
		protected static RField r_s_NCStartName;
		public static RField Rs_NCStartName
		{
			get
			{
				if(r_s_NCStartName == null)
				{
					r_s_NCStartName = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_NCStartName");
					r_s_NCStartName.SetBelong(null);
				}
				return r_s_NCStartName;
			}
		}

		/// <summary>
		/// System.String s_NCName
		/// </summary>
		protected static RField r_s_NCName;
		public static RField Rs_NCName
		{
			get
			{
				if(r_s_NCName == null)
				{
					r_s_NCName = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_NCName");
					r_s_NCName.SetBelong(null);
				}
				return r_s_NCName;
			}
		}

		/// <summary>
		/// System.String s_CharData
		/// </summary>
		protected static RField r_s_CharData;
		public static RField Rs_CharData
		{
			get
			{
				if(r_s_CharData == null)
				{
					r_s_CharData = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_CharData");
					r_s_CharData.SetBelong(null);
				}
				return r_s_CharData;
			}
		}

		/// <summary>
		/// System.String s_PublicID
		/// </summary>
		protected static RField r_s_PublicID;
		public static RField Rs_PublicID
		{
			get
			{
				if(r_s_PublicID == null)
				{
					r_s_PublicID = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_PublicID");
					r_s_PublicID.SetBelong(null);
				}
				return r_s_PublicID;
			}
		}

		/// <summary>
		/// System.String s_Text
		/// </summary>
		protected static RField r_s_Text;
		public static RField Rs_Text
		{
			get
			{
				if(r_s_Text == null)
				{
					r_s_Text = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_Text");
					r_s_Text.SetBelong(null);
				}
				return r_s_Text;
			}
		}

		/// <summary>
		/// System.String s_AttrValue
		/// </summary>
		protected static RField r_s_AttrValue;
		public static RField Rs_AttrValue
		{
			get
			{
				if(r_s_AttrValue == null)
				{
					r_s_AttrValue = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_AttrValue");
					r_s_AttrValue.SetBelong(null);
				}
				return r_s_AttrValue;
			}
		}

		/// <summary>
		/// System.String s_LetterXml4e
		/// </summary>
		protected static RField r_s_LetterXml4e;
		public static RField Rs_LetterXml4e
		{
			get
			{
				if(r_s_LetterXml4e == null)
				{
					r_s_LetterXml4e = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_LetterXml4e");
					r_s_LetterXml4e.SetBelong(null);
				}
				return r_s_LetterXml4e;
			}
		}

		/// <summary>
		/// System.String s_NCNameXml4e
		/// </summary>
		protected static RField r_s_NCNameXml4e;
		public static RField Rs_NCNameXml4e
		{
			get
			{
				if(r_s_NCNameXml4e == null)
				{
					r_s_NCNameXml4e = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_NCNameXml4e");
					r_s_NCNameXml4e.SetBelong(null);
				}
				return r_s_NCNameXml4e;
			}
		}

		/// <summary>
		/// System.Object s_Lock
		/// </summary>
		protected static RSystem.RObject r_s_Lock;
		public static RSystem.RObject Rs_Lock
		{
			get
			{
				if(r_s_Lock == null)
				{
					r_s_Lock = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_Lock");
					r_s_Lock.SetBelong(null);
				}
				return r_s_Lock;
			}
		}

		/// <summary>
		/// System.Byte[] s_CharProperties
		/// </summary>
		protected static RFieldArray<RField> r_s_CharProperties;
		public static RFieldArray<RField> Rs_CharProperties
		{
			get
			{
				if(r_s_CharProperties == null)
				{
					r_s_CharProperties = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "s_CharProperties");
					r_s_CharProperties.SetBelong(null);
				}
				return r_s_CharProperties;
			}
		}

		/// <summary>
		/// System.Byte[] charProperties
		/// </summary>
		protected RFieldArray<RField> r_charProperties;
		public virtual RFieldArray<RField> RcharProperties
		{
			get
			{
				if(r_charProperties == null)
				{
					r_charProperties = new(this, "charProperties");
					r_charProperties.SetBelong(this.instance);
				}
				return r_charProperties;
			}
		}

		/// <summary>
		/// System.Object StaticLock
		/// </summary>
		protected static RSystem.RObject r_StaticLock;
		public static RSystem.RObject RStaticLock
		{
			get
			{
				if(r_StaticLock == null)
				{
					r_StaticLock = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "StaticLock", -1);
					r_StaticLock.SetBelong(null);
				}
				return r_StaticLock;
			}
		}

		/// <summary>
		/// System.Xml.XmlCharType Instance
		/// </summary>
		protected static RSystem.RXml.RXmlCharType r_Instance;
		public static RSystem.RXml.RXmlCharType RInstance
		{
			get
			{
				if(r_Instance == null)
				{
					r_Instance = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "Instance", -1);
					r_Instance.SetBelong(null);
				}
				return r_Instance;
			}
		}

		/// <summary>
		/// Void InitInstance()
		/// </summary>
		protected static RMethod r_RInitInstance;
		public static RMethod RInitInstance
		{
			get
			{
				if(r_RInitInstance == null)
				{
					r_RInitInstance = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "InitInstance", 0);
					r_RInitInstance.SetBelong(null);
				}
				return r_RInitInstance;
			}
		}

		/// <summary>
		/// Void SetProperties(Byte[], System.String, Byte)
		/// </summary>
		protected static RMethod r_RSetProperties_ByteArray_String_Byte;
		public static RMethod RSetProperties_ByteArray_String_Byte
		{
			get
			{
				if(r_RSetProperties_ByteArray_String_Byte == null)
				{
					r_RSetProperties_ByteArray_String_Byte = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "SetProperties", 0, typeof(System.Byte).MakeArrayType(), typeof(System.String), typeof(System.Byte));
					r_RSetProperties_ByteArray_String_Byte.SetBelong(null);
				}
				return r_RSetProperties_ByteArray_String_Byte;
			}
		}

		/// <summary>
		/// Boolean IsWhiteSpace(Char)
		/// </summary>
		protected RMethod r_RIsWhiteSpace_Char;
		public virtual RMethod RIsWhiteSpace_Char
		{
			get
			{
				if(r_RIsWhiteSpace_Char == null)
				{
					r_RIsWhiteSpace_Char = new(this, "IsWhiteSpace", 0, typeof(System.Char));
					r_RIsWhiteSpace_Char.SetBelong(this.instance);
				}
				return r_RIsWhiteSpace_Char;
			}
		}

		/// <summary>
		/// Boolean IsExtender(Char)
		/// </summary>
		protected RMethod r_RIsExtender_Char;
		public virtual RMethod RIsExtender_Char
		{
			get
			{
				if(r_RIsExtender_Char == null)
				{
					r_RIsExtender_Char = new(this, "IsExtender", 0, typeof(System.Char));
					r_RIsExtender_Char.SetBelong(this.instance);
				}
				return r_RIsExtender_Char;
			}
		}

		/// <summary>
		/// Boolean IsNCNameSingleChar(Char)
		/// </summary>
		protected RMethod r_RIsNCNameSingleChar_Char;
		public virtual RMethod RIsNCNameSingleChar_Char
		{
			get
			{
				if(r_RIsNCNameSingleChar_Char == null)
				{
					r_RIsNCNameSingleChar_Char = new(this, "IsNCNameSingleChar", 0, typeof(System.Char));
					r_RIsNCNameSingleChar_Char.SetBelong(this.instance);
				}
				return r_RIsNCNameSingleChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsStartNCNameSingleChar(Char)
		/// </summary>
		protected RMethod r_RIsStartNCNameSingleChar_Char;
		public virtual RMethod RIsStartNCNameSingleChar_Char
		{
			get
			{
				if(r_RIsStartNCNameSingleChar_Char == null)
				{
					r_RIsStartNCNameSingleChar_Char = new(this, "IsStartNCNameSingleChar", 0, typeof(System.Char));
					r_RIsStartNCNameSingleChar_Char.SetBelong(this.instance);
				}
				return r_RIsStartNCNameSingleChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsNameSingleChar(Char)
		/// </summary>
		protected RMethod r_RIsNameSingleChar_Char;
		public virtual RMethod RIsNameSingleChar_Char
		{
			get
			{
				if(r_RIsNameSingleChar_Char == null)
				{
					r_RIsNameSingleChar_Char = new(this, "IsNameSingleChar", 0, typeof(System.Char));
					r_RIsNameSingleChar_Char.SetBelong(this.instance);
				}
				return r_RIsNameSingleChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsStartNameSingleChar(Char)
		/// </summary>
		protected RMethod r_RIsStartNameSingleChar_Char;
		public virtual RMethod RIsStartNameSingleChar_Char
		{
			get
			{
				if(r_RIsStartNameSingleChar_Char == null)
				{
					r_RIsStartNameSingleChar_Char = new(this, "IsStartNameSingleChar", 0, typeof(System.Char));
					r_RIsStartNameSingleChar_Char.SetBelong(this.instance);
				}
				return r_RIsStartNameSingleChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsCharData(Char)
		/// </summary>
		protected RMethod r_RIsCharData_Char;
		public virtual RMethod RIsCharData_Char
		{
			get
			{
				if(r_RIsCharData_Char == null)
				{
					r_RIsCharData_Char = new(this, "IsCharData", 0, typeof(System.Char));
					r_RIsCharData_Char.SetBelong(this.instance);
				}
				return r_RIsCharData_Char;
			}
		}

		/// <summary>
		/// Boolean IsPubidChar(Char)
		/// </summary>
		protected RMethod r_RIsPubidChar_Char;
		public virtual RMethod RIsPubidChar_Char
		{
			get
			{
				if(r_RIsPubidChar_Char == null)
				{
					r_RIsPubidChar_Char = new(this, "IsPubidChar", 0, typeof(System.Char));
					r_RIsPubidChar_Char.SetBelong(this.instance);
				}
				return r_RIsPubidChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsTextChar(Char)
		/// </summary>
		protected RMethod r_RIsTextChar_Char;
		public virtual RMethod RIsTextChar_Char
		{
			get
			{
				if(r_RIsTextChar_Char == null)
				{
					r_RIsTextChar_Char = new(this, "IsTextChar", 0, typeof(System.Char));
					r_RIsTextChar_Char.SetBelong(this.instance);
				}
				return r_RIsTextChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsAttributeValueChar(Char)
		/// </summary>
		protected RMethod r_RIsAttributeValueChar_Char;
		public virtual RMethod RIsAttributeValueChar_Char
		{
			get
			{
				if(r_RIsAttributeValueChar_Char == null)
				{
					r_RIsAttributeValueChar_Char = new(this, "IsAttributeValueChar", 0, typeof(System.Char));
					r_RIsAttributeValueChar_Char.SetBelong(this.instance);
				}
				return r_RIsAttributeValueChar_Char;
			}
		}

		/// <summary>
		/// Boolean IsLetter(Char)
		/// </summary>
		protected RMethod r_RIsLetter_Char;
		public virtual RMethod RIsLetter_Char
		{
			get
			{
				if(r_RIsLetter_Char == null)
				{
					r_RIsLetter_Char = new(this, "IsLetter", 0, typeof(System.Char));
					r_RIsLetter_Char.SetBelong(this.instance);
				}
				return r_RIsLetter_Char;
			}
		}

		/// <summary>
		/// Boolean IsNCNameCharXml4e(Char)
		/// </summary>
		protected RMethod r_RIsNCNameCharXml4e_Char;
		public virtual RMethod RIsNCNameCharXml4e_Char
		{
			get
			{
				if(r_RIsNCNameCharXml4e_Char == null)
				{
					r_RIsNCNameCharXml4e_Char = new(this, "IsNCNameCharXml4e", 0, typeof(System.Char));
					r_RIsNCNameCharXml4e_Char.SetBelong(this.instance);
				}
				return r_RIsNCNameCharXml4e_Char;
			}
		}

		/// <summary>
		/// Boolean IsStartNCNameCharXml4e(Char)
		/// </summary>
		protected RMethod r_RIsStartNCNameCharXml4e_Char;
		public virtual RMethod RIsStartNCNameCharXml4e_Char
		{
			get
			{
				if(r_RIsStartNCNameCharXml4e_Char == null)
				{
					r_RIsStartNCNameCharXml4e_Char = new(this, "IsStartNCNameCharXml4e", 0, typeof(System.Char));
					r_RIsStartNCNameCharXml4e_Char.SetBelong(this.instance);
				}
				return r_RIsStartNCNameCharXml4e_Char;
			}
		}

		/// <summary>
		/// Boolean IsNameCharXml4e(Char)
		/// </summary>
		protected RMethod r_RIsNameCharXml4e_Char;
		public virtual RMethod RIsNameCharXml4e_Char
		{
			get
			{
				if(r_RIsNameCharXml4e_Char == null)
				{
					r_RIsNameCharXml4e_Char = new(this, "IsNameCharXml4e", 0, typeof(System.Char));
					r_RIsNameCharXml4e_Char.SetBelong(this.instance);
				}
				return r_RIsNameCharXml4e_Char;
			}
		}

		/// <summary>
		/// Boolean IsStartNameCharXml4e(Char)
		/// </summary>
		protected RMethod r_RIsStartNameCharXml4e_Char;
		public virtual RMethod RIsStartNameCharXml4e_Char
		{
			get
			{
				if(r_RIsStartNameCharXml4e_Char == null)
				{
					r_RIsStartNameCharXml4e_Char = new(this, "IsStartNameCharXml4e", 0, typeof(System.Char));
					r_RIsStartNameCharXml4e_Char.SetBelong(this.instance);
				}
				return r_RIsStartNameCharXml4e_Char;
			}
		}

		/// <summary>
		/// Boolean IsDigit(Char)
		/// </summary>
		protected static RMethod r_RIsDigit_Char;
		public static RMethod RIsDigit_Char
		{
			get
			{
				if(r_RIsDigit_Char == null)
				{
					r_RIsDigit_Char = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "IsDigit", 0, typeof(System.Char));
					r_RIsDigit_Char.SetBelong(null);
				}
				return r_RIsDigit_Char;
			}
		}

		/// <summary>
		/// Boolean IsHexDigit(Char)
		/// </summary>
		protected static RMethod r_RIsHexDigit_Char;
		public static RMethod RIsHexDigit_Char
		{
			get
			{
				if(r_RIsHexDigit_Char == null)
				{
					r_RIsHexDigit_Char = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "IsHexDigit", 0, typeof(System.Char));
					r_RIsHexDigit_Char.SetBelong(null);
				}
				return r_RIsHexDigit_Char;
			}
		}

		/// <summary>
		/// Boolean IsHighSurrogate(Int32)
		/// </summary>
		protected static RMethod r_RIsHighSurrogate_Int32;
		public static RMethod RIsHighSurrogate_Int32
		{
			get
			{
				if(r_RIsHighSurrogate_Int32 == null)
				{
					r_RIsHighSurrogate_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "IsHighSurrogate", 0, typeof(System.Int32));
					r_RIsHighSurrogate_Int32.SetBelong(null);
				}
				return r_RIsHighSurrogate_Int32;
			}
		}

		/// <summary>
		/// Boolean IsLowSurrogate(Int32)
		/// </summary>
		protected static RMethod r_RIsLowSurrogate_Int32;
		public static RMethod RIsLowSurrogate_Int32
		{
			get
			{
				if(r_RIsLowSurrogate_Int32 == null)
				{
					r_RIsLowSurrogate_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "IsLowSurrogate", 0, typeof(System.Int32));
					r_RIsLowSurrogate_Int32.SetBelong(null);
				}
				return r_RIsLowSurrogate_Int32;
			}
		}

		/// <summary>
		/// Boolean IsSurrogate(Int32)
		/// </summary>
		protected static RMethod r_RIsSurrogate_Int32;
		public static RMethod RIsSurrogate_Int32
		{
			get
			{
				if(r_RIsSurrogate_Int32 == null)
				{
					r_RIsSurrogate_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "IsSurrogate", 0, typeof(System.Int32));
					r_RIsSurrogate_Int32.SetBelong(null);
				}
				return r_RIsSurrogate_Int32;
			}
		}

		/// <summary>
		/// Int32 CombineSurrogateChar(Int32, Int32)
		/// </summary>
		protected static RMethod r_RCombineSurrogateChar_Int32_Int32;
		public static RMethod RCombineSurrogateChar_Int32_Int32
		{
			get
			{
				if(r_RCombineSurrogateChar_Int32_Int32 == null)
				{
					r_RCombineSurrogateChar_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "CombineSurrogateChar", 0, typeof(System.Int32), typeof(System.Int32));
					r_RCombineSurrogateChar_Int32_Int32.SetBelong(null);
				}
				return r_RCombineSurrogateChar_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SplitSurrogateChar(Int32, Char ByRef, Char ByRef)
		/// </summary>
		protected static RMethod r_RSplitSurrogateChar_Int32_Out_Char_Out_Char;
		public static RMethod RSplitSurrogateChar_Int32_Out_Char_Out_Char
		{
			get
			{
				if(r_RSplitSurrogateChar_Int32_Out_Char_Out_Char == null)
				{
					r_RSplitSurrogateChar_Int32_Out_Char_Out_Char = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "SplitSurrogateChar", 0, typeof(System.Int32), typeof(System.Char).MakeByRefType(), typeof(System.Char).MakeByRefType());
					r_RSplitSurrogateChar_Int32_Out_Char_Out_Char.SetBelong(null);
				}
				return r_RSplitSurrogateChar_Int32_Out_Char_Out_Char;
			}
		}

		/// <summary>
		/// Boolean IsOnlyWhitespace(System.String)
		/// </summary>
		protected RMethod r_RIsOnlyWhitespace_String;
		public virtual RMethod RIsOnlyWhitespace_String
		{
			get
			{
				if(r_RIsOnlyWhitespace_String == null)
				{
					r_RIsOnlyWhitespace_String = new(this, "IsOnlyWhitespace", 0, typeof(System.String));
					r_RIsOnlyWhitespace_String.SetBelong(this.instance);
				}
				return r_RIsOnlyWhitespace_String;
			}
		}

		/// <summary>
		/// Int32 IsOnlyWhitespaceWithPos(System.String)
		/// </summary>
		protected RMethod r_RIsOnlyWhitespaceWithPos_String;
		public virtual RMethod RIsOnlyWhitespaceWithPos_String
		{
			get
			{
				if(r_RIsOnlyWhitespaceWithPos_String == null)
				{
					r_RIsOnlyWhitespaceWithPos_String = new(this, "IsOnlyWhitespaceWithPos", 0, typeof(System.String));
					r_RIsOnlyWhitespaceWithPos_String.SetBelong(this.instance);
				}
				return r_RIsOnlyWhitespaceWithPos_String;
			}
		}

		/// <summary>
		/// Int32 IsOnlyCharData(System.String)
		/// </summary>
		protected RMethod r_RIsOnlyCharData_String;
		public virtual RMethod RIsOnlyCharData_String
		{
			get
			{
				if(r_RIsOnlyCharData_String == null)
				{
					r_RIsOnlyCharData_String = new(this, "IsOnlyCharData", 0, typeof(System.String));
					r_RIsOnlyCharData_String.SetBelong(this.instance);
				}
				return r_RIsOnlyCharData_String;
			}
		}

		/// <summary>
		/// Boolean IsOnlyDigits(System.String, Int32, Int32)
		/// </summary>
		protected static RMethod r_RIsOnlyDigits_String_Int32_Int32;
		public static RMethod RIsOnlyDigits_String_Int32_Int32
		{
			get
			{
				if(r_RIsOnlyDigits_String_Int32_Int32 == null)
				{
					r_RIsOnlyDigits_String_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "IsOnlyDigits", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RIsOnlyDigits_String_Int32_Int32.SetBelong(null);
				}
				return r_RIsOnlyDigits_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean IsOnlyDigits(Char[], Int32, Int32)
		/// </summary>
		protected static RMethod r_RIsOnlyDigits_CharArray_Int32_Int32;
		public static RMethod RIsOnlyDigits_CharArray_Int32_Int32
		{
			get
			{
				if(r_RIsOnlyDigits_CharArray_Int32_Int32 == null)
				{
					r_RIsOnlyDigits_CharArray_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "IsOnlyDigits", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RIsOnlyDigits_CharArray_Int32_Int32.SetBelong(null);
				}
				return r_RIsOnlyDigits_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IsPublicId(System.String)
		/// </summary>
		protected RMethod r_RIsPublicId_String;
		public virtual RMethod RIsPublicId_String
		{
			get
			{
				if(r_RIsPublicId_String == null)
				{
					r_RIsPublicId_String = new(this, "IsPublicId", 0, typeof(System.String));
					r_RIsPublicId_String.SetBelong(this.instance);
				}
				return r_RIsPublicId_String;
			}
		}

		/// <summary>
		/// Boolean InRange(Int32, Int32, Int32)
		/// </summary>
		protected static RMethod r_RInRange_Int32_Int32_Int32;
		public static RMethod RInRange_Int32_Int32_Int32
		{
			get
			{
				if(r_RInRange_Int32_Int32_Int32 == null)
				{
					r_RInRange_Int32_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlCharType"), "InRange", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RInRange_Int32_Int32_Int32.SetBelong(null);
				}
				return r_RInRange_Int32_Int32_Int32;
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


        public RXmlCharType() : base("System.Xml.XmlCharType")
        {
        }

        public RXmlCharType(System.Object instance) : base("System.Xml.XmlCharType")
		{
            SetInstance(instance);
		}

        public RXmlCharType(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlCharType(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public static void InitInstance()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitInstance.Invoke(___genericsType, ___parameters);

            
        }


        public static void SetProperties(System.Byte[]  @chProps, System.String  @ranges, System.Byte  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chProps, @ranges, @value};
            var ___result = RSetProperties_ByteArray_String_Byte.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsWhiteSpace(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsWhiteSpace_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsExtender(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsExtender_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsNCNameSingleChar(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsNCNameSingleChar_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStartNCNameSingleChar(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsStartNCNameSingleChar_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsNameSingleChar(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsNameSingleChar_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStartNameSingleChar(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsStartNameSingleChar_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsCharData(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsCharData_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsPubidChar(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsPubidChar_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsTextChar(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsTextChar_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsAttributeValueChar(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsAttributeValueChar_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsLetter(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsLetter_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsNCNameCharXml4e(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsNCNameCharXml4e_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStartNCNameCharXml4e(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsStartNCNameCharXml4e_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsNameCharXml4e(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsNameCharXml4e_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStartNameCharXml4e(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsStartNameCharXml4e_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsDigit(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsDigit_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsHexDigit(System.Char  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsHexDigit_Char.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsHighSurrogate(System.Int32  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsHighSurrogate_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsLowSurrogate(System.Int32  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsLowSurrogate_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsSurrogate(System.Int32  @ch)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@ch};
            var ___result = RIsSurrogate_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Int32 CombineSurrogateChar(System.Int32  @lowChar, System.Int32  @highChar)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@lowChar, @highChar};
            var ___result = RCombineSurrogateChar_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static void SplitSurrogateChar(System.Int32  @combinedChar, out System.Char  @lowChar, out System.Char  @highChar)
        {
			lowChar = default;
			highChar = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@combinedChar, @lowChar, @highChar};
            var ___result = RSplitSurrogateChar_Int32_Out_Char_Out_Char.Invoke(___genericsType, ___parameters);
			lowChar = (System.Char)___parameters[1];
			highChar = (System.Char)___parameters[2];

            
        }


        public virtual System.Boolean IsOnlyWhitespace(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RIsOnlyWhitespace_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IsOnlyWhitespaceWithPos(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RIsOnlyWhitespaceWithPos_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IsOnlyCharData(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RIsOnlyCharData_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean IsOnlyDigits(System.String  @str, System.Int32  @startPos, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str, @startPos, @len};
            var ___result = RIsOnlyDigits_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public static System.Boolean IsOnlyDigits(System.Char[]  @chars, System.Int32  @startPos, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@chars, @startPos, @len};
            var ___result = RIsOnlyDigits_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Int32 IsPublicId(System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@str};
            var ___result = RIsPublicId_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public static System.Boolean InRange(System.Int32  @value, System.Int32  @start, System.Int32  @end)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @start, @end};
            var ___result = RInRange_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean Equals(System.Object  @obj)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@obj};
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
