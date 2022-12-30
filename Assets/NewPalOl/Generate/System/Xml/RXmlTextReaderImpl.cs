using SMFrame.Editor.Refleaction;
using System;
using System.Reflection;

namespace SMFrame.Editor.Refleaction.RSystem.RXml
{
	/// <summary>
	/// System.Xml.XmlTextReaderImpl
	/// </summary>
    public partial class RXmlTextReaderImpl : RMember //
    {

		/// <summary>
		/// System.Boolean useAsync
		/// </summary>
		protected RField r_useAsync;
		public virtual RField RuseAsync
		{
			get
			{
				if(r_useAsync == null)
				{
					r_useAsync = new(this, "useAsync");
					r_useAsync.SetBelong(this.instance);
				}
				return r_useAsync;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+LaterInitParam laterInitParam
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.RLaterInitParam r_laterInitParam;
		public virtual RSystem.RXml.RXmlTextReaderImpl.RLaterInitParam RlaterInitParam
		{
			get
			{
				if(r_laterInitParam == null)
				{
					r_laterInitParam = new(this, "laterInitParam");
					r_laterInitParam.SetBelong(this.instance);
				}
				return r_laterInitParam;
			}
		}

		/// <summary>
		/// System.Xml.XmlCharType xmlCharType
		/// </summary>
		protected RSystem.RXml.RXmlCharType r_xmlCharType;
		public virtual RSystem.RXml.RXmlCharType RxmlCharType
		{
			get
			{
				if(r_xmlCharType == null)
				{
					r_xmlCharType = new(this, "xmlCharType");
					r_xmlCharType.SetBelong(this.instance);
				}
				return r_xmlCharType;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParsingState ps
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.RParsingState r_ps;
		public virtual RSystem.RXml.RXmlTextReaderImpl.RParsingState Rps
		{
			get
			{
				if(r_ps == null)
				{
					r_ps = new(this, "ps");
					r_ps.SetBelong(this.instance);
				}
				return r_ps;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParsingFunction parsingFunction
		/// </summary>
		protected RField r_parsingFunction;
		public virtual RField RparsingFunction
		{
			get
			{
				if(r_parsingFunction == null)
				{
					r_parsingFunction = new(this, "parsingFunction");
					r_parsingFunction.SetBelong(this.instance);
				}
				return r_parsingFunction;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParsingFunction nextParsingFunction
		/// </summary>
		protected RField r_nextParsingFunction;
		public virtual RField RnextParsingFunction
		{
			get
			{
				if(r_nextParsingFunction == null)
				{
					r_nextParsingFunction = new(this, "nextParsingFunction");
					r_nextParsingFunction.SetBelong(this.instance);
				}
				return r_nextParsingFunction;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParsingFunction nextNextParsingFunction
		/// </summary>
		protected RField r_nextNextParsingFunction;
		public virtual RField RnextNextParsingFunction
		{
			get
			{
				if(r_nextNextParsingFunction == null)
				{
					r_nextNextParsingFunction = new(this, "nextNextParsingFunction");
					r_nextNextParsingFunction.SetBelong(this.instance);
				}
				return r_nextNextParsingFunction;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+NodeData[] nodes
		/// </summary>
		protected RFieldArray<RSystem.RXml.RXmlTextReaderImpl.RNodeData> r_nodes;
		public virtual RFieldArray<RSystem.RXml.RXmlTextReaderImpl.RNodeData> Rnodes
		{
			get
			{
				if(r_nodes == null)
				{
					r_nodes = new(this, "nodes");
					r_nodes.SetBelong(this.instance);
				}
				return r_nodes;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+NodeData curNode
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.RNodeData r_curNode;
		public virtual RSystem.RXml.RXmlTextReaderImpl.RNodeData RcurNode
		{
			get
			{
				if(r_curNode == null)
				{
					r_curNode = new(this, "curNode");
					r_curNode.SetBelong(this.instance);
				}
				return r_curNode;
			}
		}

		/// <summary>
		/// System.Int32 index
		/// </summary>
		protected RField r_index;
		public virtual RField Rindex
		{
			get
			{
				if(r_index == null)
				{
					r_index = new(this, "index");
					r_index.SetBelong(this.instance);
				}
				return r_index;
			}
		}

		/// <summary>
		/// System.Int32 curAttrIndex
		/// </summary>
		protected RField r_curAttrIndex;
		public virtual RField RcurAttrIndex
		{
			get
			{
				if(r_curAttrIndex == null)
				{
					r_curAttrIndex = new(this, "curAttrIndex");
					r_curAttrIndex.SetBelong(this.instance);
				}
				return r_curAttrIndex;
			}
		}

		/// <summary>
		/// System.Int32 attrCount
		/// </summary>
		protected RField r_attrCount;
		public virtual RField RattrCount
		{
			get
			{
				if(r_attrCount == null)
				{
					r_attrCount = new(this, "attrCount");
					r_attrCount.SetBelong(this.instance);
				}
				return r_attrCount;
			}
		}

		/// <summary>
		/// System.Int32 attrHashtable
		/// </summary>
		protected RField r_attrHashtable;
		public virtual RField RattrHashtable
		{
			get
			{
				if(r_attrHashtable == null)
				{
					r_attrHashtable = new(this, "attrHashtable");
					r_attrHashtable.SetBelong(this.instance);
				}
				return r_attrHashtable;
			}
		}

		/// <summary>
		/// System.Int32 attrDuplWalkCount
		/// </summary>
		protected RField r_attrDuplWalkCount;
		public virtual RField RattrDuplWalkCount
		{
			get
			{
				if(r_attrDuplWalkCount == null)
				{
					r_attrDuplWalkCount = new(this, "attrDuplWalkCount");
					r_attrDuplWalkCount.SetBelong(this.instance);
				}
				return r_attrDuplWalkCount;
			}
		}

		/// <summary>
		/// System.Boolean attrNeedNamespaceLookup
		/// </summary>
		protected RField r_attrNeedNamespaceLookup;
		public virtual RField RattrNeedNamespaceLookup
		{
			get
			{
				if(r_attrNeedNamespaceLookup == null)
				{
					r_attrNeedNamespaceLookup = new(this, "attrNeedNamespaceLookup");
					r_attrNeedNamespaceLookup.SetBelong(this.instance);
				}
				return r_attrNeedNamespaceLookup;
			}
		}

		/// <summary>
		/// System.Boolean fullAttrCleanup
		/// </summary>
		protected RField r_fullAttrCleanup;
		public virtual RField RfullAttrCleanup
		{
			get
			{
				if(r_fullAttrCleanup == null)
				{
					r_fullAttrCleanup = new(this, "fullAttrCleanup");
					r_fullAttrCleanup.SetBelong(this.instance);
				}
				return r_fullAttrCleanup;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+NodeData[] attrDuplSortingArray
		/// </summary>
		protected RFieldArray<RSystem.RXml.RXmlTextReaderImpl.RNodeData> r_attrDuplSortingArray;
		public virtual RFieldArray<RSystem.RXml.RXmlTextReaderImpl.RNodeData> RattrDuplSortingArray
		{
			get
			{
				if(r_attrDuplSortingArray == null)
				{
					r_attrDuplSortingArray = new(this, "attrDuplSortingArray");
					r_attrDuplSortingArray.SetBelong(this.instance);
				}
				return r_attrDuplSortingArray;
			}
		}

		/// <summary>
		/// System.Xml.XmlNameTable nameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_nameTable;
		public virtual RSystem.RXml.RXmlNameTable RnameTable
		{
			get
			{
				if(r_nameTable == null)
				{
					r_nameTable = new(this, "nameTable");
					r_nameTable.SetBelong(this.instance);
				}
				return r_nameTable;
			}
		}

		/// <summary>
		/// System.Boolean nameTableFromSettings
		/// </summary>
		protected RField r_nameTableFromSettings;
		public virtual RField RnameTableFromSettings
		{
			get
			{
				if(r_nameTableFromSettings == null)
				{
					r_nameTableFromSettings = new(this, "nameTableFromSettings");
					r_nameTableFromSettings.SetBelong(this.instance);
				}
				return r_nameTableFromSettings;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver xmlResolver
		/// </summary>
		protected RSystem.RXml.RXmlResolver r_xmlResolver;
		public virtual RSystem.RXml.RXmlResolver RxmlResolver
		{
			get
			{
				if(r_xmlResolver == null)
				{
					r_xmlResolver = new(this, "xmlResolver");
					r_xmlResolver.SetBelong(this.instance);
				}
				return r_xmlResolver;
			}
		}

		/// <summary>
		/// System.String url
		/// </summary>
		protected RField r_url;
		public virtual RField Rurl
		{
			get
			{
				if(r_url == null)
				{
					r_url = new(this, "url");
					r_url.SetBelong(this.instance);
				}
				return r_url;
			}
		}

		/// <summary>
		/// System.Boolean normalize
		/// </summary>
		protected RField r_normalize;
		public virtual RField Rnormalize
		{
			get
			{
				if(r_normalize == null)
				{
					r_normalize = new(this, "normalize");
					r_normalize.SetBelong(this.instance);
				}
				return r_normalize;
			}
		}

		/// <summary>
		/// System.Boolean supportNamespaces
		/// </summary>
		protected RField r_supportNamespaces;
		public virtual RField RsupportNamespaces
		{
			get
			{
				if(r_supportNamespaces == null)
				{
					r_supportNamespaces = new(this, "supportNamespaces");
					r_supportNamespaces.SetBelong(this.instance);
				}
				return r_supportNamespaces;
			}
		}

		/// <summary>
		/// System.Xml.WhitespaceHandling whitespaceHandling
		/// </summary>
		protected RField r_whitespaceHandling;
		public virtual RField RwhitespaceHandling
		{
			get
			{
				if(r_whitespaceHandling == null)
				{
					r_whitespaceHandling = new(this, "whitespaceHandling");
					r_whitespaceHandling.SetBelong(this.instance);
				}
				return r_whitespaceHandling;
			}
		}

		/// <summary>
		/// System.Xml.DtdProcessing dtdProcessing
		/// </summary>
		protected RField r_dtdProcessing;
		public virtual RField RdtdProcessing
		{
			get
			{
				if(r_dtdProcessing == null)
				{
					r_dtdProcessing = new(this, "dtdProcessing");
					r_dtdProcessing.SetBelong(this.instance);
				}
				return r_dtdProcessing;
			}
		}

		/// <summary>
		/// System.Xml.EntityHandling entityHandling
		/// </summary>
		protected RField r_entityHandling;
		public virtual RField RentityHandling
		{
			get
			{
				if(r_entityHandling == null)
				{
					r_entityHandling = new(this, "entityHandling");
					r_entityHandling.SetBelong(this.instance);
				}
				return r_entityHandling;
			}
		}

		/// <summary>
		/// System.Boolean ignorePIs
		/// </summary>
		protected RField r_ignorePIs;
		public virtual RField RignorePIs
		{
			get
			{
				if(r_ignorePIs == null)
				{
					r_ignorePIs = new(this, "ignorePIs");
					r_ignorePIs.SetBelong(this.instance);
				}
				return r_ignorePIs;
			}
		}

		/// <summary>
		/// System.Boolean ignoreComments
		/// </summary>
		protected RField r_ignoreComments;
		public virtual RField RignoreComments
		{
			get
			{
				if(r_ignoreComments == null)
				{
					r_ignoreComments = new(this, "ignoreComments");
					r_ignoreComments.SetBelong(this.instance);
				}
				return r_ignoreComments;
			}
		}

		/// <summary>
		/// System.Boolean checkCharacters
		/// </summary>
		protected RField r_checkCharacters;
		public virtual RField RcheckCharacters
		{
			get
			{
				if(r_checkCharacters == null)
				{
					r_checkCharacters = new(this, "checkCharacters");
					r_checkCharacters.SetBelong(this.instance);
				}
				return r_checkCharacters;
			}
		}

		/// <summary>
		/// System.Int32 lineNumberOffset
		/// </summary>
		protected RField r_lineNumberOffset;
		public virtual RField RlineNumberOffset
		{
			get
			{
				if(r_lineNumberOffset == null)
				{
					r_lineNumberOffset = new(this, "lineNumberOffset");
					r_lineNumberOffset.SetBelong(this.instance);
				}
				return r_lineNumberOffset;
			}
		}

		/// <summary>
		/// System.Int32 linePositionOffset
		/// </summary>
		protected RField r_linePositionOffset;
		public virtual RField RlinePositionOffset
		{
			get
			{
				if(r_linePositionOffset == null)
				{
					r_linePositionOffset = new(this, "linePositionOffset");
					r_linePositionOffset.SetBelong(this.instance);
				}
				return r_linePositionOffset;
			}
		}

		/// <summary>
		/// System.Boolean closeInput
		/// </summary>
		protected RField r_closeInput;
		public virtual RField RcloseInput
		{
			get
			{
				if(r_closeInput == null)
				{
					r_closeInput = new(this, "closeInput");
					r_closeInput.SetBelong(this.instance);
				}
				return r_closeInput;
			}
		}

		/// <summary>
		/// System.Int64 maxCharactersInDocument
		/// </summary>
		protected RField r_maxCharactersInDocument;
		public virtual RField RmaxCharactersInDocument
		{
			get
			{
				if(r_maxCharactersInDocument == null)
				{
					r_maxCharactersInDocument = new(this, "maxCharactersInDocument");
					r_maxCharactersInDocument.SetBelong(this.instance);
				}
				return r_maxCharactersInDocument;
			}
		}

		/// <summary>
		/// System.Int64 maxCharactersFromEntities
		/// </summary>
		protected RField r_maxCharactersFromEntities;
		public virtual RField RmaxCharactersFromEntities
		{
			get
			{
				if(r_maxCharactersFromEntities == null)
				{
					r_maxCharactersFromEntities = new(this, "maxCharactersFromEntities");
					r_maxCharactersFromEntities.SetBelong(this.instance);
				}
				return r_maxCharactersFromEntities;
			}
		}

		/// <summary>
		/// System.Boolean v1Compat
		/// </summary>
		protected RField r_v1Compat;
		public virtual RField Rv1Compat
		{
			get
			{
				if(r_v1Compat == null)
				{
					r_v1Compat = new(this, "v1Compat");
					r_v1Compat.SetBelong(this.instance);
				}
				return r_v1Compat;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamespaceManager namespaceManager
		/// </summary>
		protected RSystem.RXml.RXmlNamespaceManager r_namespaceManager;
		public virtual RSystem.RXml.RXmlNamespaceManager RnamespaceManager
		{
			get
			{
				if(r_namespaceManager == null)
				{
					r_namespaceManager = new(this, "namespaceManager");
					r_namespaceManager.SetBelong(this.instance);
				}
				return r_namespaceManager;
			}
		}

		/// <summary>
		/// System.String lastPrefix
		/// </summary>
		protected RField r_lastPrefix;
		public virtual RField RlastPrefix
		{
			get
			{
				if(r_lastPrefix == null)
				{
					r_lastPrefix = new(this, "lastPrefix");
					r_lastPrefix.SetBelong(this.instance);
				}
				return r_lastPrefix;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+XmlContext xmlContext
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.RXmlContext r_xmlContext;
		public virtual RSystem.RXml.RXmlTextReaderImpl.RXmlContext RxmlContext
		{
			get
			{
				if(r_xmlContext == null)
				{
					r_xmlContext = new(this, "xmlContext");
					r_xmlContext.SetBelong(this.instance);
				}
				return r_xmlContext;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParsingState[] parsingStatesStack
		/// </summary>
		protected RFieldArray<RSystem.RXml.RXmlTextReaderImpl.RParsingState> r_parsingStatesStack;
		public virtual RFieldArray<RSystem.RXml.RXmlTextReaderImpl.RParsingState> RparsingStatesStack
		{
			get
			{
				if(r_parsingStatesStack == null)
				{
					r_parsingStatesStack = new(this, "parsingStatesStack");
					r_parsingStatesStack.SetBelong(this.instance);
				}
				return r_parsingStatesStack;
			}
		}

		/// <summary>
		/// System.Int32 parsingStatesStackTop
		/// </summary>
		protected RField r_parsingStatesStackTop;
		public virtual RField RparsingStatesStackTop
		{
			get
			{
				if(r_parsingStatesStackTop == null)
				{
					r_parsingStatesStackTop = new(this, "parsingStatesStackTop");
					r_parsingStatesStackTop.SetBelong(this.instance);
				}
				return r_parsingStatesStackTop;
			}
		}

		/// <summary>
		/// System.String reportedBaseUri
		/// </summary>
		protected RField r_reportedBaseUri;
		public virtual RField RreportedBaseUri
		{
			get
			{
				if(r_reportedBaseUri == null)
				{
					r_reportedBaseUri = new(this, "reportedBaseUri");
					r_reportedBaseUri.SetBelong(this.instance);
				}
				return r_reportedBaseUri;
			}
		}

		/// <summary>
		/// System.Text.Encoding reportedEncoding
		/// </summary>
		protected RSystem.RText.REncoding r_reportedEncoding;
		public virtual RSystem.RText.REncoding RreportedEncoding
		{
			get
			{
				if(r_reportedEncoding == null)
				{
					r_reportedEncoding = new(this, "reportedEncoding");
					r_reportedEncoding.SetBelong(this.instance);
				}
				return r_reportedEncoding;
			}
		}

		/// <summary>
		/// System.Xml.IDtdInfo dtdInfo
		/// </summary>
		protected RSystem.RXml.RIDtdInfo r_dtdInfo;
		public virtual RSystem.RXml.RIDtdInfo RdtdInfo
		{
			get
			{
				if(r_dtdInfo == null)
				{
					r_dtdInfo = new(this, "dtdInfo");
					r_dtdInfo.SetBelong(this.instance);
				}
				return r_dtdInfo;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType fragmentType
		/// </summary>
		protected RField r_fragmentType;
		public virtual RField RfragmentType
		{
			get
			{
				if(r_fragmentType == null)
				{
					r_fragmentType = new(this, "fragmentType");
					r_fragmentType.SetBelong(this.instance);
				}
				return r_fragmentType;
			}
		}

		/// <summary>
		/// System.Xml.XmlParserContext fragmentParserContext
		/// </summary>
		protected RSystem.RXml.RXmlParserContext r_fragmentParserContext;
		public virtual RSystem.RXml.RXmlParserContext RfragmentParserContext
		{
			get
			{
				if(r_fragmentParserContext == null)
				{
					r_fragmentParserContext = new(this, "fragmentParserContext");
					r_fragmentParserContext.SetBelong(this.instance);
				}
				return r_fragmentParserContext;
			}
		}

		/// <summary>
		/// System.Boolean fragment
		/// </summary>
		protected RField r_fragment;
		public virtual RField Rfragment
		{
			get
			{
				if(r_fragment == null)
				{
					r_fragment = new(this, "fragment");
					r_fragment.SetBelong(this.instance);
				}
				return r_fragment;
			}
		}

		/// <summary>
		/// System.Xml.IncrementalReadDecoder incReadDecoder
		/// </summary>
		protected RSystem.RXml.RIncrementalReadDecoder r_incReadDecoder;
		public virtual RSystem.RXml.RIncrementalReadDecoder RincReadDecoder
		{
			get
			{
				if(r_incReadDecoder == null)
				{
					r_incReadDecoder = new(this, "incReadDecoder");
					r_incReadDecoder.SetBelong(this.instance);
				}
				return r_incReadDecoder;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+IncrementalReadState incReadState
		/// </summary>
		protected RField r_incReadState;
		public virtual RField RincReadState
		{
			get
			{
				if(r_incReadState == null)
				{
					r_incReadState = new(this, "incReadState");
					r_incReadState.SetBelong(this.instance);
				}
				return r_incReadState;
			}
		}

		/// <summary>
		/// System.Xml.LineInfo incReadLineInfo
		/// </summary>
		protected RSystem.RXml.RLineInfo r_incReadLineInfo;
		public virtual RSystem.RXml.RLineInfo RincReadLineInfo
		{
			get
			{
				if(r_incReadLineInfo == null)
				{
					r_incReadLineInfo = new(this, "incReadLineInfo");
					r_incReadLineInfo.SetBelong(this.instance);
				}
				return r_incReadLineInfo;
			}
		}

		/// <summary>
		/// System.Xml.BinHexDecoder binHexDecoder
		/// </summary>
		protected RSystem.RXml.RBinHexDecoder r_binHexDecoder;
		public virtual RSystem.RXml.RBinHexDecoder RbinHexDecoder
		{
			get
			{
				if(r_binHexDecoder == null)
				{
					r_binHexDecoder = new(this, "binHexDecoder");
					r_binHexDecoder.SetBelong(this.instance);
				}
				return r_binHexDecoder;
			}
		}

		/// <summary>
		/// System.Xml.Base64Decoder base64Decoder
		/// </summary>
		protected RSystem.RXml.RBase64Decoder r_base64Decoder;
		public virtual RSystem.RXml.RBase64Decoder Rbase64Decoder
		{
			get
			{
				if(r_base64Decoder == null)
				{
					r_base64Decoder = new(this, "base64Decoder");
					r_base64Decoder.SetBelong(this.instance);
				}
				return r_base64Decoder;
			}
		}

		/// <summary>
		/// System.Int32 incReadDepth
		/// </summary>
		protected RField r_incReadDepth;
		public virtual RField RincReadDepth
		{
			get
			{
				if(r_incReadDepth == null)
				{
					r_incReadDepth = new(this, "incReadDepth");
					r_incReadDepth.SetBelong(this.instance);
				}
				return r_incReadDepth;
			}
		}

		/// <summary>
		/// System.Int32 incReadLeftStartPos
		/// </summary>
		protected RField r_incReadLeftStartPos;
		public virtual RField RincReadLeftStartPos
		{
			get
			{
				if(r_incReadLeftStartPos == null)
				{
					r_incReadLeftStartPos = new(this, "incReadLeftStartPos");
					r_incReadLeftStartPos.SetBelong(this.instance);
				}
				return r_incReadLeftStartPos;
			}
		}

		/// <summary>
		/// System.Int32 incReadLeftEndPos
		/// </summary>
		protected RField r_incReadLeftEndPos;
		public virtual RField RincReadLeftEndPos
		{
			get
			{
				if(r_incReadLeftEndPos == null)
				{
					r_incReadLeftEndPos = new(this, "incReadLeftEndPos");
					r_incReadLeftEndPos.SetBelong(this.instance);
				}
				return r_incReadLeftEndPos;
			}
		}

		/// <summary>
		/// System.Xml.IncrementalReadCharsDecoder readCharsDecoder
		/// </summary>
		protected RSystem.RXml.RIncrementalReadCharsDecoder r_readCharsDecoder;
		public virtual RSystem.RXml.RIncrementalReadCharsDecoder RreadCharsDecoder
		{
			get
			{
				if(r_readCharsDecoder == null)
				{
					r_readCharsDecoder = new(this, "readCharsDecoder");
					r_readCharsDecoder.SetBelong(this.instance);
				}
				return r_readCharsDecoder;
			}
		}

		/// <summary>
		/// System.Int32 attributeValueBaseEntityId
		/// </summary>
		protected RField r_attributeValueBaseEntityId;
		public virtual RField RattributeValueBaseEntityId
		{
			get
			{
				if(r_attributeValueBaseEntityId == null)
				{
					r_attributeValueBaseEntityId = new(this, "attributeValueBaseEntityId");
					r_attributeValueBaseEntityId.SetBelong(this.instance);
				}
				return r_attributeValueBaseEntityId;
			}
		}

		/// <summary>
		/// System.Boolean emptyEntityInAttributeResolved
		/// </summary>
		protected RField r_emptyEntityInAttributeResolved;
		public virtual RField RemptyEntityInAttributeResolved
		{
			get
			{
				if(r_emptyEntityInAttributeResolved == null)
				{
					r_emptyEntityInAttributeResolved = new(this, "emptyEntityInAttributeResolved");
					r_emptyEntityInAttributeResolved.SetBelong(this.instance);
				}
				return r_emptyEntityInAttributeResolved;
			}
		}

		/// <summary>
		/// System.Xml.IValidationEventHandling validationEventHandling
		/// </summary>
		protected RSystem.RXml.RIValidationEventHandling r_validationEventHandling;
		public virtual RSystem.RXml.RIValidationEventHandling RvalidationEventHandling
		{
			get
			{
				if(r_validationEventHandling == null)
				{
					r_validationEventHandling = new(this, "validationEventHandling");
					r_validationEventHandling.SetBelong(this.instance);
				}
				return r_validationEventHandling;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+OnDefaultAttributeUseDelegate onDefaultAttributeUse
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.ROnDefaultAttributeUseDelegate r_onDefaultAttributeUse;
		public virtual RSystem.RXml.RXmlTextReaderImpl.ROnDefaultAttributeUseDelegate RonDefaultAttributeUse
		{
			get
			{
				if(r_onDefaultAttributeUse == null)
				{
					r_onDefaultAttributeUse = new(this, "onDefaultAttributeUse");
					r_onDefaultAttributeUse.SetBelong(this.instance);
				}
				return r_onDefaultAttributeUse;
			}
		}

		/// <summary>
		/// System.Boolean validatingReaderCompatFlag
		/// </summary>
		protected RField r_validatingReaderCompatFlag;
		public virtual RField RvalidatingReaderCompatFlag
		{
			get
			{
				if(r_validatingReaderCompatFlag == null)
				{
					r_validatingReaderCompatFlag = new(this, "validatingReaderCompatFlag");
					r_validatingReaderCompatFlag.SetBelong(this.instance);
				}
				return r_validatingReaderCompatFlag;
			}
		}

		/// <summary>
		/// System.Boolean addDefaultAttributesAndNormalize
		/// </summary>
		protected RField r_addDefaultAttributesAndNormalize;
		public virtual RField RaddDefaultAttributesAndNormalize
		{
			get
			{
				if(r_addDefaultAttributesAndNormalize == null)
				{
					r_addDefaultAttributesAndNormalize = new(this, "addDefaultAttributesAndNormalize");
					r_addDefaultAttributesAndNormalize.SetBelong(this.instance);
				}
				return r_addDefaultAttributesAndNormalize;
			}
		}

		/// <summary>
		/// System.Text.StringBuilder stringBuilder
		/// </summary>
		protected RSystem.RText.RStringBuilder r_stringBuilder;
		public virtual RSystem.RText.RStringBuilder RstringBuilder
		{
			get
			{
				if(r_stringBuilder == null)
				{
					r_stringBuilder = new(this, "stringBuilder");
					r_stringBuilder.SetBelong(this.instance);
				}
				return r_stringBuilder;
			}
		}

		/// <summary>
		/// System.Boolean rootElementParsed
		/// </summary>
		protected RField r_rootElementParsed;
		public virtual RField RrootElementParsed
		{
			get
			{
				if(r_rootElementParsed == null)
				{
					r_rootElementParsed = new(this, "rootElementParsed");
					r_rootElementParsed.SetBelong(this.instance);
				}
				return r_rootElementParsed;
			}
		}

		/// <summary>
		/// System.Boolean standalone
		/// </summary>
		protected RField r_standalone;
		public virtual RField Rstandalone
		{
			get
			{
				if(r_standalone == null)
				{
					r_standalone = new(this, "standalone");
					r_standalone.SetBelong(this.instance);
				}
				return r_standalone;
			}
		}

		/// <summary>
		/// System.Int32 nextEntityId
		/// </summary>
		protected RField r_nextEntityId;
		public virtual RField RnextEntityId
		{
			get
			{
				if(r_nextEntityId == null)
				{
					r_nextEntityId = new(this, "nextEntityId");
					r_nextEntityId.SetBelong(this.instance);
				}
				return r_nextEntityId;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParsingMode parsingMode
		/// </summary>
		protected RField r_parsingMode;
		public virtual RField RparsingMode
		{
			get
			{
				if(r_parsingMode == null)
				{
					r_parsingMode = new(this, "parsingMode");
					r_parsingMode.SetBelong(this.instance);
				}
				return r_parsingMode;
			}
		}

		/// <summary>
		/// System.Xml.ReadState readState
		/// </summary>
		protected RField r_readState;
		public virtual RField RreadState
		{
			get
			{
				if(r_readState == null)
				{
					r_readState = new(this, "readState");
					r_readState.SetBelong(this.instance);
				}
				return r_readState;
			}
		}

		/// <summary>
		/// System.Xml.IDtdEntityInfo lastEntity
		/// </summary>
		protected RSystem.RXml.RIDtdEntityInfo r_lastEntity;
		public virtual RSystem.RXml.RIDtdEntityInfo RlastEntity
		{
			get
			{
				if(r_lastEntity == null)
				{
					r_lastEntity = new(this, "lastEntity");
					r_lastEntity.SetBelong(this.instance);
				}
				return r_lastEntity;
			}
		}

		/// <summary>
		/// System.Boolean afterResetState
		/// </summary>
		protected RField r_afterResetState;
		public virtual RField RafterResetState
		{
			get
			{
				if(r_afterResetState == null)
				{
					r_afterResetState = new(this, "afterResetState");
					r_afterResetState.SetBelong(this.instance);
				}
				return r_afterResetState;
			}
		}

		/// <summary>
		/// System.Int32 documentStartBytePos
		/// </summary>
		protected RField r_documentStartBytePos;
		public virtual RField RdocumentStartBytePos
		{
			get
			{
				if(r_documentStartBytePos == null)
				{
					r_documentStartBytePos = new(this, "documentStartBytePos");
					r_documentStartBytePos.SetBelong(this.instance);
				}
				return r_documentStartBytePos;
			}
		}

		/// <summary>
		/// System.Int32 readValueOffset
		/// </summary>
		protected RField r_readValueOffset;
		public virtual RField RreadValueOffset
		{
			get
			{
				if(r_readValueOffset == null)
				{
					r_readValueOffset = new(this, "readValueOffset");
					r_readValueOffset.SetBelong(this.instance);
				}
				return r_readValueOffset;
			}
		}

		/// <summary>
		/// System.Int64 charactersInDocument
		/// </summary>
		protected RField r_charactersInDocument;
		public virtual RField RcharactersInDocument
		{
			get
			{
				if(r_charactersInDocument == null)
				{
					r_charactersInDocument = new(this, "charactersInDocument");
					r_charactersInDocument.SetBelong(this.instance);
				}
				return r_charactersInDocument;
			}
		}

		/// <summary>
		/// System.Int64 charactersFromEntities
		/// </summary>
		protected RField r_charactersFromEntities;
		public virtual RField RcharactersFromEntities
		{
			get
			{
				if(r_charactersFromEntities == null)
				{
					r_charactersFromEntities = new(this, "charactersFromEntities");
					r_charactersFromEntities.SetBelong(this.instance);
				}
				return r_charactersFromEntities;
			}
		}

		/// <summary>
		/// System.Collections.Generic.Dictionary`2[System.Xml.IDtdEntityInfo,System.Xml.IDtdEntityInfo] currentEntities
		/// </summary>
		protected RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RIDtdEntityInfo, RSystem.RXml.RIDtdEntityInfo> r_currentEntities;
		public virtual RSystem.RCollections.RGeneric.RDictionary<RSystem.RXml.RIDtdEntityInfo, RSystem.RXml.RIDtdEntityInfo> RcurrentEntities
		{
			get
			{
				if(r_currentEntities == null)
				{
					r_currentEntities = new(this, "currentEntities");
					r_currentEntities.SetBelong(this.instance);
				}
				return r_currentEntities;
			}
		}

		/// <summary>
		/// System.Boolean disableUndeclaredEntityCheck
		/// </summary>
		protected RField r_disableUndeclaredEntityCheck;
		public virtual RField RdisableUndeclaredEntityCheck
		{
			get
			{
				if(r_disableUndeclaredEntityCheck == null)
				{
					r_disableUndeclaredEntityCheck = new(this, "disableUndeclaredEntityCheck");
					r_disableUndeclaredEntityCheck.SetBelong(this.instance);
				}
				return r_disableUndeclaredEntityCheck;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader outerReader
		/// </summary>
		protected RSystem.RXml.RXmlReader r_outerReader;
		public virtual RSystem.RXml.RXmlReader RouterReader
		{
			get
			{
				if(r_outerReader == null)
				{
					r_outerReader = new(this, "outerReader");
					r_outerReader.SetBelong(this.instance);
				}
				return r_outerReader;
			}
		}

		/// <summary>
		/// System.Boolean xmlResolverIsSet
		/// </summary>
		protected RField r_xmlResolverIsSet;
		public virtual RField RxmlResolverIsSet
		{
			get
			{
				if(r_xmlResolverIsSet == null)
				{
					r_xmlResolverIsSet = new(this, "xmlResolverIsSet");
					r_xmlResolverIsSet.SetBelong(this.instance);
				}
				return r_xmlResolverIsSet;
			}
		}

		/// <summary>
		/// System.String Xml
		/// </summary>
		protected RField r_Xml;
		public virtual RField RXml
		{
			get
			{
				if(r_Xml == null)
				{
					r_Xml = new(this, "Xml");
					r_Xml.SetBelong(this.instance);
				}
				return r_Xml;
			}
		}

		/// <summary>
		/// System.String XmlNs
		/// </summary>
		protected RField r_XmlNs;
		public virtual RField RXmlNs
		{
			get
			{
				if(r_XmlNs == null)
				{
					r_XmlNs = new(this, "XmlNs");
					r_XmlNs.SetBelong(this.instance);
				}
				return r_XmlNs;
			}
		}

		/// <summary>
		/// System.Int32 MaxBytesToMove
		/// </summary>
		protected static RField r_MaxBytesToMove;
		public static RField RMaxBytesToMove
		{
			get
			{
				if(r_MaxBytesToMove == null)
				{
					r_MaxBytesToMove = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "MaxBytesToMove");
					r_MaxBytesToMove.SetBelong(null);
				}
				return r_MaxBytesToMove;
			}
		}

		/// <summary>
		/// System.Int32 ApproxXmlDeclLength
		/// </summary>
		protected static RField r_ApproxXmlDeclLength;
		public static RField RApproxXmlDeclLength
		{
			get
			{
				if(r_ApproxXmlDeclLength == null)
				{
					r_ApproxXmlDeclLength = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "ApproxXmlDeclLength");
					r_ApproxXmlDeclLength.SetBelong(null);
				}
				return r_ApproxXmlDeclLength;
			}
		}

		/// <summary>
		/// System.Int32 NodesInitialSize
		/// </summary>
		protected static RField r_NodesInitialSize;
		public static RField RNodesInitialSize
		{
			get
			{
				if(r_NodesInitialSize == null)
				{
					r_NodesInitialSize = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "NodesInitialSize");
					r_NodesInitialSize.SetBelong(null);
				}
				return r_NodesInitialSize;
			}
		}

		/// <summary>
		/// System.Int32 InitialAttributesCount
		/// </summary>
		protected static RField r_InitialAttributesCount;
		public static RField RInitialAttributesCount
		{
			get
			{
				if(r_InitialAttributesCount == null)
				{
					r_InitialAttributesCount = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "InitialAttributesCount");
					r_InitialAttributesCount.SetBelong(null);
				}
				return r_InitialAttributesCount;
			}
		}

		/// <summary>
		/// System.Int32 InitialParsingStateStackSize
		/// </summary>
		protected static RField r_InitialParsingStateStackSize;
		public static RField RInitialParsingStateStackSize
		{
			get
			{
				if(r_InitialParsingStateStackSize == null)
				{
					r_InitialParsingStateStackSize = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "InitialParsingStateStackSize");
					r_InitialParsingStateStackSize.SetBelong(null);
				}
				return r_InitialParsingStateStackSize;
			}
		}

		/// <summary>
		/// System.Int32 InitialParsingStatesDepth
		/// </summary>
		protected static RField r_InitialParsingStatesDepth;
		public static RField RInitialParsingStatesDepth
		{
			get
			{
				if(r_InitialParsingStatesDepth == null)
				{
					r_InitialParsingStatesDepth = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "InitialParsingStatesDepth");
					r_InitialParsingStatesDepth.SetBelong(null);
				}
				return r_InitialParsingStatesDepth;
			}
		}

		/// <summary>
		/// System.Int32 DtdChidrenInitialSize
		/// </summary>
		protected static RField r_DtdChidrenInitialSize;
		public static RField RDtdChidrenInitialSize
		{
			get
			{
				if(r_DtdChidrenInitialSize == null)
				{
					r_DtdChidrenInitialSize = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "DtdChidrenInitialSize");
					r_DtdChidrenInitialSize.SetBelong(null);
				}
				return r_DtdChidrenInitialSize;
			}
		}

		/// <summary>
		/// System.Int32 MaxByteSequenceLen
		/// </summary>
		protected static RField r_MaxByteSequenceLen;
		public static RField RMaxByteSequenceLen
		{
			get
			{
				if(r_MaxByteSequenceLen == null)
				{
					r_MaxByteSequenceLen = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "MaxByteSequenceLen");
					r_MaxByteSequenceLen.SetBelong(null);
				}
				return r_MaxByteSequenceLen;
			}
		}

		/// <summary>
		/// System.Int32 MaxAttrDuplWalkCount
		/// </summary>
		protected static RField r_MaxAttrDuplWalkCount;
		public static RField RMaxAttrDuplWalkCount
		{
			get
			{
				if(r_MaxAttrDuplWalkCount == null)
				{
					r_MaxAttrDuplWalkCount = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "MaxAttrDuplWalkCount");
					r_MaxAttrDuplWalkCount.SetBelong(null);
				}
				return r_MaxAttrDuplWalkCount;
			}
		}

		/// <summary>
		/// System.Int32 MinWhitespaceLookahedCount
		/// </summary>
		protected static RField r_MinWhitespaceLookahedCount;
		public static RField RMinWhitespaceLookahedCount
		{
			get
			{
				if(r_MinWhitespaceLookahedCount == null)
				{
					r_MinWhitespaceLookahedCount = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "MinWhitespaceLookahedCount");
					r_MinWhitespaceLookahedCount.SetBelong(null);
				}
				return r_MinWhitespaceLookahedCount;
			}
		}

		/// <summary>
		/// System.String XmlDeclarationBegining
		/// </summary>
		protected static RField r_XmlDeclarationBegining;
		public static RField RXmlDeclarationBegining
		{
			get
			{
				if(r_XmlDeclarationBegining == null)
				{
					r_XmlDeclarationBegining = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "XmlDeclarationBegining");
					r_XmlDeclarationBegining.SetBelong(null);
				}
				return r_XmlDeclarationBegining;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParseEndElementParseFunction parseEndElement_NextFunc
		/// </summary>
		protected RField r_parseEndElement_NextFunc;
		public virtual RField RparseEndElement_NextFunc
		{
			get
			{
				if(r_parseEndElement_NextFunc == null)
				{
					r_parseEndElement_NextFunc = new(this, "parseEndElement_NextFunc");
					r_parseEndElement_NextFunc.SetBelong(this.instance);
				}
				return r_parseEndElement_NextFunc;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParseTextFunction parseText_NextFunction
		/// </summary>
		protected RField r_parseText_NextFunction;
		public virtual RField RparseText_NextFunction
		{
			get
			{
				if(r_parseText_NextFunction == null)
				{
					r_parseText_NextFunction = new(this, "parseText_NextFunction");
					r_parseText_NextFunction.SetBelong(this.instance);
				}
				return r_parseText_NextFunction;
			}
		}

		/// <summary>
		/// System.Xml.XmlTextReaderImpl+ParseTextState lastParseTextState
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.RParseTextState r_lastParseTextState;
		public virtual RSystem.RXml.RXmlTextReaderImpl.RParseTextState RlastParseTextState
		{
			get
			{
				if(r_lastParseTextState == null)
				{
					r_lastParseTextState = new(this, "lastParseTextState");
					r_lastParseTextState.SetBelong(this.instance);
				}
				return r_lastParseTextState;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] parseText_dummyTask
		/// </summary>
		protected RSystem.RThreading.RTasks.RTask<RSystem.RTuple<RField, RField, RField, RField>> r_parseText_dummyTask;
		public virtual RSystem.RThreading.RTasks.RTask<RSystem.RTuple<RField, RField, RField, RField>> RparseText_dummyTask
		{
			get
			{
				if(r_parseText_dummyTask == null)
				{
					r_parseText_dummyTask = new(this, "parseText_dummyTask");
					r_parseText_dummyTask.SetBelong(this.instance);
				}
				return r_parseText_dummyTask;
			}
		}

		/// <summary>
		/// System.Xml.XmlReaderSettings Settings
		/// </summary>
		protected RSystem.RXml.RXmlReaderSettings r_Settings;
		public virtual RSystem.RXml.RXmlReaderSettings RSettings
		{
			get
			{
				if(r_Settings == null)
				{
					r_Settings = new(this, "Settings", -1);
					r_Settings.SetBelong(this.instance);
				}
				return r_Settings;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType NodeType
		/// </summary>
		protected RProperty r_NodeType;
		public virtual RProperty RNodeType
		{
			get
			{
				if(r_NodeType == null)
				{
					r_NodeType = new(this, "NodeType", -1);
					r_NodeType.SetBelong(this.instance);
				}
				return r_NodeType;
			}
		}

		/// <summary>
		/// System.String Name
		/// </summary>
		protected RProperty r_Name;
		public virtual RProperty RName
		{
			get
			{
				if(r_Name == null)
				{
					r_Name = new(this, "Name", -1);
					r_Name.SetBelong(this.instance);
				}
				return r_Name;
			}
		}

		/// <summary>
		/// System.String LocalName
		/// </summary>
		protected RProperty r_LocalName;
		public virtual RProperty RLocalName
		{
			get
			{
				if(r_LocalName == null)
				{
					r_LocalName = new(this, "LocalName", -1);
					r_LocalName.SetBelong(this.instance);
				}
				return r_LocalName;
			}
		}

		/// <summary>
		/// System.String NamespaceURI
		/// </summary>
		protected RProperty r_NamespaceURI;
		public virtual RProperty RNamespaceURI
		{
			get
			{
				if(r_NamespaceURI == null)
				{
					r_NamespaceURI = new(this, "NamespaceURI", -1);
					r_NamespaceURI.SetBelong(this.instance);
				}
				return r_NamespaceURI;
			}
		}

		/// <summary>
		/// System.String Prefix
		/// </summary>
		protected RProperty r_Prefix;
		public virtual RProperty RPrefix
		{
			get
			{
				if(r_Prefix == null)
				{
					r_Prefix = new(this, "Prefix", -1);
					r_Prefix.SetBelong(this.instance);
				}
				return r_Prefix;
			}
		}

		/// <summary>
		/// System.String Value
		/// </summary>
		protected RProperty r_Value;
		public virtual RProperty RValue
		{
			get
			{
				if(r_Value == null)
				{
					r_Value = new(this, "Value", -1);
					r_Value.SetBelong(this.instance);
				}
				return r_Value;
			}
		}

		/// <summary>
		/// Int32 Depth
		/// </summary>
		protected RProperty r_Depth;
		public virtual RProperty RDepth
		{
			get
			{
				if(r_Depth == null)
				{
					r_Depth = new(this, "Depth", -1);
					r_Depth.SetBelong(this.instance);
				}
				return r_Depth;
			}
		}

		/// <summary>
		/// System.String BaseURI
		/// </summary>
		protected RProperty r_BaseURI;
		public virtual RProperty RBaseURI
		{
			get
			{
				if(r_BaseURI == null)
				{
					r_BaseURI = new(this, "BaseURI", -1);
					r_BaseURI.SetBelong(this.instance);
				}
				return r_BaseURI;
			}
		}

		/// <summary>
		/// Boolean IsEmptyElement
		/// </summary>
		protected RProperty r_IsEmptyElement;
		public virtual RProperty RIsEmptyElement
		{
			get
			{
				if(r_IsEmptyElement == null)
				{
					r_IsEmptyElement = new(this, "IsEmptyElement", -1);
					r_IsEmptyElement.SetBelong(this.instance);
				}
				return r_IsEmptyElement;
			}
		}

		/// <summary>
		/// Boolean IsDefault
		/// </summary>
		protected RProperty r_IsDefault;
		public virtual RProperty RIsDefault
		{
			get
			{
				if(r_IsDefault == null)
				{
					r_IsDefault = new(this, "IsDefault", -1);
					r_IsDefault.SetBelong(this.instance);
				}
				return r_IsDefault;
			}
		}

		/// <summary>
		/// Char QuoteChar
		/// </summary>
		protected RProperty r_QuoteChar;
		public virtual RProperty RQuoteChar
		{
			get
			{
				if(r_QuoteChar == null)
				{
					r_QuoteChar = new(this, "QuoteChar", -1);
					r_QuoteChar.SetBelong(this.instance);
				}
				return r_QuoteChar;
			}
		}

		/// <summary>
		/// System.Xml.XmlSpace XmlSpace
		/// </summary>
		protected RProperty r_XmlSpace;
		public virtual RProperty RXmlSpace
		{
			get
			{
				if(r_XmlSpace == null)
				{
					r_XmlSpace = new(this, "XmlSpace", -1);
					r_XmlSpace.SetBelong(this.instance);
				}
				return r_XmlSpace;
			}
		}

		/// <summary>
		/// System.String XmlLang
		/// </summary>
		protected RProperty r_XmlLang;
		public virtual RProperty RXmlLang
		{
			get
			{
				if(r_XmlLang == null)
				{
					r_XmlLang = new(this, "XmlLang", -1);
					r_XmlLang.SetBelong(this.instance);
				}
				return r_XmlLang;
			}
		}

		/// <summary>
		/// System.Xml.ReadState ReadState
		/// </summary>
		protected RProperty r_ReadState;
		public virtual RProperty ReadState
		{
			get
			{
				if(r_ReadState == null)
				{
					r_ReadState = new(this, "ReadState", -1);
					r_ReadState.SetBelong(this.instance);
				}
				return r_ReadState;
			}
		}

		/// <summary>
		/// Boolean EOF
		/// </summary>
		protected RProperty r_EOF;
		public virtual RProperty REOF
		{
			get
			{
				if(r_EOF == null)
				{
					r_EOF = new(this, "EOF", -1);
					r_EOF.SetBelong(this.instance);
				}
				return r_EOF;
			}
		}

		/// <summary>
		/// System.Xml.XmlNameTable NameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_NameTable;
		public virtual RSystem.RXml.RXmlNameTable RNameTable
		{
			get
			{
				if(r_NameTable == null)
				{
					r_NameTable = new(this, "NameTable", -1);
					r_NameTable.SetBelong(this.instance);
				}
				return r_NameTable;
			}
		}

		/// <summary>
		/// Boolean CanResolveEntity
		/// </summary>
		protected RProperty r_CanResolveEntity;
		public virtual RProperty RCanResolveEntity
		{
			get
			{
				if(r_CanResolveEntity == null)
				{
					r_CanResolveEntity = new(this, "CanResolveEntity", -1);
					r_CanResolveEntity.SetBelong(this.instance);
				}
				return r_CanResolveEntity;
			}
		}

		/// <summary>
		/// Int32 AttributeCount
		/// </summary>
		protected RProperty r_AttributeCount;
		public virtual RProperty RAttributeCount
		{
			get
			{
				if(r_AttributeCount == null)
				{
					r_AttributeCount = new(this, "AttributeCount", -1);
					r_AttributeCount.SetBelong(this.instance);
				}
				return r_AttributeCount;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader OuterReader
		/// </summary>
		protected RSystem.RXml.RXmlReader r_OuterReader;
		public virtual RSystem.RXml.RXmlReader ROuterReader
		{
			get
			{
				if(r_OuterReader == null)
				{
					r_OuterReader = new(this, "OuterReader", -1);
					r_OuterReader.SetBelong(this.instance);
				}
				return r_OuterReader;
			}
		}

		/// <summary>
		/// Boolean CanReadBinaryContent
		/// </summary>
		protected RProperty r_CanReadBinaryContent;
		public virtual RProperty RCanReadBinaryContent
		{
			get
			{
				if(r_CanReadBinaryContent == null)
				{
					r_CanReadBinaryContent = new(this, "CanReadBinaryContent", -1);
					r_CanReadBinaryContent.SetBelong(this.instance);
				}
				return r_CanReadBinaryContent;
			}
		}

		/// <summary>
		/// Boolean CanReadValueChunk
		/// </summary>
		protected RProperty r_CanReadValueChunk;
		public virtual RProperty RCanReadValueChunk
		{
			get
			{
				if(r_CanReadValueChunk == null)
				{
					r_CanReadValueChunk = new(this, "CanReadValueChunk", -1);
					r_CanReadValueChunk.SetBelong(this.instance);
				}
				return r_CanReadValueChunk;
			}
		}

		/// <summary>
		/// Int32 LineNumber
		/// </summary>
		protected RProperty r_LineNumber;
		public virtual RProperty RLineNumber
		{
			get
			{
				if(r_LineNumber == null)
				{
					r_LineNumber = new(this, "LineNumber", -1);
					r_LineNumber.SetBelong(this.instance);
				}
				return r_LineNumber;
			}
		}

		/// <summary>
		/// Int32 LinePosition
		/// </summary>
		protected RProperty r_LinePosition;
		public virtual RProperty RLinePosition
		{
			get
			{
				if(r_LinePosition == null)
				{
					r_LinePosition = new(this, "LinePosition", -1);
					r_LinePosition.SetBelong(this.instance);
				}
				return r_LinePosition;
			}
		}

		/// <summary>
		/// Boolean Namespaces
		/// </summary>
		protected RProperty r_Namespaces;
		public virtual RProperty RNamespaces
		{
			get
			{
				if(r_Namespaces == null)
				{
					r_Namespaces = new(this, "Namespaces", -1);
					r_Namespaces.SetBelong(this.instance);
				}
				return r_Namespaces;
			}
		}

		/// <summary>
		/// Boolean Normalization
		/// </summary>
		protected RProperty r_Normalization;
		public virtual RProperty RNormalization
		{
			get
			{
				if(r_Normalization == null)
				{
					r_Normalization = new(this, "Normalization", -1);
					r_Normalization.SetBelong(this.instance);
				}
				return r_Normalization;
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
		/// System.Xml.WhitespaceHandling WhitespaceHandling
		/// </summary>
		protected RProperty r_WhitespaceHandling;
		public virtual RProperty RWhitespaceHandling
		{
			get
			{
				if(r_WhitespaceHandling == null)
				{
					r_WhitespaceHandling = new(this, "WhitespaceHandling", -1);
					r_WhitespaceHandling.SetBelong(this.instance);
				}
				return r_WhitespaceHandling;
			}
		}

		/// <summary>
		/// System.Xml.DtdProcessing DtdProcessing
		/// </summary>
		protected RProperty r_DtdProcessing;
		public virtual RProperty RDtdProcessing
		{
			get
			{
				if(r_DtdProcessing == null)
				{
					r_DtdProcessing = new(this, "DtdProcessing", -1);
					r_DtdProcessing.SetBelong(this.instance);
				}
				return r_DtdProcessing;
			}
		}

		/// <summary>
		/// System.Xml.EntityHandling EntityHandling
		/// </summary>
		protected RProperty r_EntityHandling;
		public virtual RProperty REntityHandling
		{
			get
			{
				if(r_EntityHandling == null)
				{
					r_EntityHandling = new(this, "EntityHandling", -1);
					r_EntityHandling.SetBelong(this.instance);
				}
				return r_EntityHandling;
			}
		}

		/// <summary>
		/// Boolean IsResolverSet
		/// </summary>
		protected RProperty r_IsResolverSet;
		public virtual RProperty RIsResolverSet
		{
			get
			{
				if(r_IsResolverSet == null)
				{
					r_IsResolverSet = new(this, "IsResolverSet", -1);
					r_IsResolverSet.SetBelong(this.instance);
				}
				return r_IsResolverSet;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver XmlResolver
		/// </summary>
		protected RSystem.RXml.RXmlResolver r_XmlResolver_XmlResolver;
		public virtual RSystem.RXml.RXmlResolver RXmlResolver_XmlResolver
		{
			get
			{
				if(r_XmlResolver_XmlResolver == null)
				{
					r_XmlResolver_XmlResolver = new(this, "XmlResolver", -1, typeof(System.Xml.XmlResolver));
					r_XmlResolver_XmlResolver.SetBelong(this.instance);
				}
				return r_XmlResolver_XmlResolver;
			}
		}

		/// <summary>
		/// System.Xml.XmlNameTable DtdParserProxy_NameTable
		/// </summary>
		protected RSystem.RXml.RXmlNameTable r_DtdParserProxy_NameTable;
		public virtual RSystem.RXml.RXmlNameTable RDtdParserProxy_NameTable
		{
			get
			{
				if(r_DtdParserProxy_NameTable == null)
				{
					r_DtdParserProxy_NameTable = new(this, "DtdParserProxy_NameTable", -1);
					r_DtdParserProxy_NameTable.SetBelong(this.instance);
				}
				return r_DtdParserProxy_NameTable;
			}
		}

		/// <summary>
		/// System.Xml.IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
		/// </summary>
		protected RSystem.RXml.RIXmlNamespaceResolver r_DtdParserProxy_NamespaceResolver;
		public virtual RSystem.RXml.RIXmlNamespaceResolver RDtdParserProxy_NamespaceResolver
		{
			get
			{
				if(r_DtdParserProxy_NamespaceResolver == null)
				{
					r_DtdParserProxy_NamespaceResolver = new(this, "DtdParserProxy_NamespaceResolver", -1);
					r_DtdParserProxy_NamespaceResolver.SetBelong(this.instance);
				}
				return r_DtdParserProxy_NamespaceResolver;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_DtdValidation
		/// </summary>
		protected RProperty r_DtdParserProxy_DtdValidation;
		public virtual RProperty RDtdParserProxy_DtdValidation
		{
			get
			{
				if(r_DtdParserProxy_DtdValidation == null)
				{
					r_DtdParserProxy_DtdValidation = new(this, "DtdParserProxy_DtdValidation", -1);
					r_DtdParserProxy_DtdValidation.SetBelong(this.instance);
				}
				return r_DtdParserProxy_DtdValidation;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_Normalization
		/// </summary>
		protected RProperty r_DtdParserProxy_Normalization;
		public virtual RProperty RDtdParserProxy_Normalization
		{
			get
			{
				if(r_DtdParserProxy_Normalization == null)
				{
					r_DtdParserProxy_Normalization = new(this, "DtdParserProxy_Normalization", -1);
					r_DtdParserProxy_Normalization.SetBelong(this.instance);
				}
				return r_DtdParserProxy_Normalization;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_Namespaces
		/// </summary>
		protected RProperty r_DtdParserProxy_Namespaces;
		public virtual RProperty RDtdParserProxy_Namespaces
		{
			get
			{
				if(r_DtdParserProxy_Namespaces == null)
				{
					r_DtdParserProxy_Namespaces = new(this, "DtdParserProxy_Namespaces", -1);
					r_DtdParserProxy_Namespaces.SetBelong(this.instance);
				}
				return r_DtdParserProxy_Namespaces;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_V1CompatibilityMode
		/// </summary>
		protected RProperty r_DtdParserProxy_V1CompatibilityMode;
		public virtual RProperty RDtdParserProxy_V1CompatibilityMode
		{
			get
			{
				if(r_DtdParserProxy_V1CompatibilityMode == null)
				{
					r_DtdParserProxy_V1CompatibilityMode = new(this, "DtdParserProxy_V1CompatibilityMode", -1);
					r_DtdParserProxy_V1CompatibilityMode.SetBelong(this.instance);
				}
				return r_DtdParserProxy_V1CompatibilityMode;
			}
		}

		/// <summary>
		/// System.Uri DtdParserProxy_BaseUri
		/// </summary>
		protected RSystem.RUri r_DtdParserProxy_BaseUri;
		public virtual RSystem.RUri RDtdParserProxy_BaseUri
		{
			get
			{
				if(r_DtdParserProxy_BaseUri == null)
				{
					r_DtdParserProxy_BaseUri = new(this, "DtdParserProxy_BaseUri", -1);
					r_DtdParserProxy_BaseUri.SetBelong(this.instance);
				}
				return r_DtdParserProxy_BaseUri;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_IsEof
		/// </summary>
		protected RProperty r_DtdParserProxy_IsEof;
		public virtual RProperty RDtdParserProxy_IsEof
		{
			get
			{
				if(r_DtdParserProxy_IsEof == null)
				{
					r_DtdParserProxy_IsEof = new(this, "DtdParserProxy_IsEof", -1);
					r_DtdParserProxy_IsEof.SetBelong(this.instance);
				}
				return r_DtdParserProxy_IsEof;
			}
		}

		/// <summary>
		/// Char[] DtdParserProxy_ParsingBuffer
		/// </summary>
		protected RPropertyArray<RProperty> r_DtdParserProxy_ParsingBuffer;
		public virtual RPropertyArray<RProperty> RDtdParserProxy_ParsingBuffer
		{
			get
			{
				if(r_DtdParserProxy_ParsingBuffer == null)
				{
					r_DtdParserProxy_ParsingBuffer = new(this, "DtdParserProxy_ParsingBuffer", -1);
					r_DtdParserProxy_ParsingBuffer.SetBelong(this.instance);
				}
				return r_DtdParserProxy_ParsingBuffer;
			}
		}

		/// <summary>
		/// Int32 DtdParserProxy_ParsingBufferLength
		/// </summary>
		protected RProperty r_DtdParserProxy_ParsingBufferLength;
		public virtual RProperty RDtdParserProxy_ParsingBufferLength
		{
			get
			{
				if(r_DtdParserProxy_ParsingBufferLength == null)
				{
					r_DtdParserProxy_ParsingBufferLength = new(this, "DtdParserProxy_ParsingBufferLength", -1);
					r_DtdParserProxy_ParsingBufferLength.SetBelong(this.instance);
				}
				return r_DtdParserProxy_ParsingBufferLength;
			}
		}

		/// <summary>
		/// Int32 DtdParserProxy_CurrentPosition
		/// </summary>
		protected RProperty r_DtdParserProxy_CurrentPosition;
		public virtual RProperty RDtdParserProxy_CurrentPosition
		{
			get
			{
				if(r_DtdParserProxy_CurrentPosition == null)
				{
					r_DtdParserProxy_CurrentPosition = new(this, "DtdParserProxy_CurrentPosition", -1);
					r_DtdParserProxy_CurrentPosition.SetBelong(this.instance);
				}
				return r_DtdParserProxy_CurrentPosition;
			}
		}

		/// <summary>
		/// Int32 DtdParserProxy_EntityStackLength
		/// </summary>
		protected RProperty r_DtdParserProxy_EntityStackLength;
		public virtual RProperty RDtdParserProxy_EntityStackLength
		{
			get
			{
				if(r_DtdParserProxy_EntityStackLength == null)
				{
					r_DtdParserProxy_EntityStackLength = new(this, "DtdParserProxy_EntityStackLength", -1);
					r_DtdParserProxy_EntityStackLength.SetBelong(this.instance);
				}
				return r_DtdParserProxy_EntityStackLength;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_IsEntityEolNormalized
		/// </summary>
		protected RProperty r_DtdParserProxy_IsEntityEolNormalized;
		public virtual RProperty RDtdParserProxy_IsEntityEolNormalized
		{
			get
			{
				if(r_DtdParserProxy_IsEntityEolNormalized == null)
				{
					r_DtdParserProxy_IsEntityEolNormalized = new(this, "DtdParserProxy_IsEntityEolNormalized", -1);
					r_DtdParserProxy_IsEntityEolNormalized.SetBelong(this.instance);
				}
				return r_DtdParserProxy_IsEntityEolNormalized;
			}
		}

		/// <summary>
		/// System.Xml.IValidationEventHandling DtdParserProxy_ValidationEventHandling
		/// </summary>
		protected RSystem.RXml.RIValidationEventHandling r_DtdParserProxy_ValidationEventHandling;
		public virtual RSystem.RXml.RIValidationEventHandling RDtdParserProxy_ValidationEventHandling
		{
			get
			{
				if(r_DtdParserProxy_ValidationEventHandling == null)
				{
					r_DtdParserProxy_ValidationEventHandling = new(this, "DtdParserProxy_ValidationEventHandling", -1);
					r_DtdParserProxy_ValidationEventHandling.SetBelong(this.instance);
				}
				return r_DtdParserProxy_ValidationEventHandling;
			}
		}

		/// <summary>
		/// Int32 DtdParserProxy_LineNo
		/// </summary>
		protected RProperty r_DtdParserProxy_LineNo;
		public virtual RProperty RDtdParserProxy_LineNo
		{
			get
			{
				if(r_DtdParserProxy_LineNo == null)
				{
					r_DtdParserProxy_LineNo = new(this, "DtdParserProxy_LineNo", -1);
					r_DtdParserProxy_LineNo.SetBelong(this.instance);
				}
				return r_DtdParserProxy_LineNo;
			}
		}

		/// <summary>
		/// Int32 DtdParserProxy_LineStartPosition
		/// </summary>
		protected RProperty r_DtdParserProxy_LineStartPosition;
		public virtual RProperty RDtdParserProxy_LineStartPosition
		{
			get
			{
				if(r_DtdParserProxy_LineStartPosition == null)
				{
					r_DtdParserProxy_LineStartPosition = new(this, "DtdParserProxy_LineStartPosition", -1);
					r_DtdParserProxy_LineStartPosition.SetBelong(this.instance);
				}
				return r_DtdParserProxy_LineStartPosition;
			}
		}

		/// <summary>
		/// Boolean IsResolverNull
		/// </summary>
		protected RProperty r_IsResolverNull;
		public virtual RProperty RIsResolverNull
		{
			get
			{
				if(r_IsResolverNull == null)
				{
					r_IsResolverNull = new(this, "IsResolverNull", -1);
					r_IsResolverNull.SetBelong(this.instance);
				}
				return r_IsResolverNull;
			}
		}

		/// <summary>
		/// Boolean InAttributeValueIterator
		/// </summary>
		protected RProperty r_InAttributeValueIterator;
		public virtual RProperty RInAttributeValueIterator
		{
			get
			{
				if(r_InAttributeValueIterator == null)
				{
					r_InAttributeValueIterator = new(this, "InAttributeValueIterator", -1);
					r_InAttributeValueIterator.SetBelong(this.instance);
				}
				return r_InAttributeValueIterator;
			}
		}

		/// <summary>
		/// Boolean DtdValidation
		/// </summary>
		protected RProperty r_DtdValidation;
		public virtual RProperty RDtdValidation
		{
			get
			{
				if(r_DtdValidation == null)
				{
					r_DtdValidation = new(this, "DtdValidation", -1);
					r_DtdValidation.SetBelong(this.instance);
				}
				return r_DtdValidation;
			}
		}

		/// <summary>
		/// Boolean InEntity
		/// </summary>
		protected RProperty r_InEntity;
		public virtual RProperty RInEntity
		{
			get
			{
				if(r_InEntity == null)
				{
					r_InEntity = new(this, "InEntity", -1);
					r_InEntity.SetBelong(this.instance);
				}
				return r_InEntity;
			}
		}

		/// <summary>
		/// System.Xml.IDtdInfo DtdInfo
		/// </summary>
		protected RSystem.RXml.RIDtdInfo r_DtdInfo;
		public virtual RSystem.RXml.RIDtdInfo RDtdInfo
		{
			get
			{
				if(r_DtdInfo == null)
				{
					r_DtdInfo = new(this, "DtdInfo", -1);
					r_DtdInfo.SetBelong(this.instance);
				}
				return r_DtdInfo;
			}
		}

		/// <summary>
		/// System.Xml.IValidationEventHandling ValidationEventHandling
		/// </summary>
		protected RSystem.RXml.RIValidationEventHandling r_ValidationEventHandling_IValidationEventHandling;
		public virtual RSystem.RXml.RIValidationEventHandling RValidationEventHandling_IValidationEventHandling
		{
			get
			{
				if(r_ValidationEventHandling_IValidationEventHandling == null)
				{
					r_ValidationEventHandling_IValidationEventHandling = new(this, "ValidationEventHandling", -1,  ReleactionUtils.GetType("System.Xml.IValidationEventHandling"));
					r_ValidationEventHandling_IValidationEventHandling.SetBelong(this.instance);
				}
				return r_ValidationEventHandling_IValidationEventHandling;
			}
		}

		/// <summary>
		/// OnDefaultAttributeUseDelegate OnDefaultAttributeUse
		/// </summary>
		protected RSystem.RXml.RXmlTextReaderImpl.ROnDefaultAttributeUseDelegate r_OnDefaultAttributeUse_OnDefaultAttributeUseDelegate;
		public virtual RSystem.RXml.RXmlTextReaderImpl.ROnDefaultAttributeUseDelegate ROnDefaultAttributeUse_OnDefaultAttributeUseDelegate
		{
			get
			{
				if(r_OnDefaultAttributeUse_OnDefaultAttributeUseDelegate == null)
				{
					r_OnDefaultAttributeUse_OnDefaultAttributeUseDelegate = new(this, "OnDefaultAttributeUse", -1,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+OnDefaultAttributeUseDelegate"));
					r_OnDefaultAttributeUse_OnDefaultAttributeUseDelegate.SetBelong(this.instance);
				}
				return r_OnDefaultAttributeUse_OnDefaultAttributeUseDelegate;
			}
		}

		/// <summary>
		/// Boolean XmlValidatingReaderCompatibilityMode
		/// </summary>
		protected RProperty r_XmlValidatingReaderCompatibilityMode_Boolean;
		public virtual RProperty RXmlValidatingReaderCompatibilityMode_Boolean
		{
			get
			{
				if(r_XmlValidatingReaderCompatibilityMode_Boolean == null)
				{
					r_XmlValidatingReaderCompatibilityMode_Boolean = new(this, "XmlValidatingReaderCompatibilityMode", -1, typeof(System.Boolean));
					r_XmlValidatingReaderCompatibilityMode_Boolean.SetBelong(this.instance);
				}
				return r_XmlValidatingReaderCompatibilityMode_Boolean;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType FragmentType
		/// </summary>
		protected RProperty r_FragmentType;
		public virtual RProperty RFragmentType
		{
			get
			{
				if(r_FragmentType == null)
				{
					r_FragmentType = new(this, "FragmentType", -1);
					r_FragmentType.SetBelong(this.instance);
				}
				return r_FragmentType;
			}
		}

		/// <summary>
		/// System.Object InternalSchemaType
		/// </summary>
		protected RSystem.RObject r_InternalSchemaType;
		public virtual RSystem.RObject RInternalSchemaType
		{
			get
			{
				if(r_InternalSchemaType == null)
				{
					r_InternalSchemaType = new(this, "InternalSchemaType", -1);
					r_InternalSchemaType.SetBelong(this.instance);
				}
				return r_InternalSchemaType;
			}
		}

		/// <summary>
		/// System.Object InternalTypedValue
		/// </summary>
		protected RSystem.RObject r_InternalTypedValue;
		public virtual RSystem.RObject RInternalTypedValue
		{
			get
			{
				if(r_InternalTypedValue == null)
				{
					r_InternalTypedValue = new(this, "InternalTypedValue", -1);
					r_InternalTypedValue.SetBelong(this.instance);
				}
				return r_InternalTypedValue;
			}
		}

		/// <summary>
		/// Boolean StandAlone
		/// </summary>
		protected RProperty r_StandAlone;
		public virtual RProperty RStandAlone
		{
			get
			{
				if(r_StandAlone == null)
				{
					r_StandAlone = new(this, "StandAlone", -1);
					r_StandAlone.SetBelong(this.instance);
				}
				return r_StandAlone;
			}
		}

		/// <summary>
		/// System.Xml.XmlNamespaceManager NamespaceManager
		/// </summary>
		protected RSystem.RXml.RXmlNamespaceManager r_NamespaceManager;
		public virtual RSystem.RXml.RXmlNamespaceManager RNamespaceManager
		{
			get
			{
				if(r_NamespaceManager == null)
				{
					r_NamespaceManager = new(this, "NamespaceManager", -1);
					r_NamespaceManager.SetBelong(this.instance);
				}
				return r_NamespaceManager;
			}
		}

		/// <summary>
		/// Boolean V1Compat
		/// </summary>
		protected RProperty r_V1Compat;
		public virtual RProperty RV1Compat
		{
			get
			{
				if(r_V1Compat == null)
				{
					r_V1Compat = new(this, "V1Compat", -1);
					r_V1Compat.SetBelong(this.instance);
				}
				return r_V1Compat;
			}
		}

		/// <summary>
		/// System.Xml.ConformanceLevel V1ComformanceLevel
		/// </summary>
		protected RProperty r_V1ComformanceLevel;
		public virtual RProperty RV1ComformanceLevel
		{
			get
			{
				if(r_V1ComformanceLevel == null)
				{
					r_V1ComformanceLevel = new(this, "V1ComformanceLevel", -1);
					r_V1ComformanceLevel.SetBelong(this.instance);
				}
				return r_V1ComformanceLevel;
			}
		}

		/// <summary>
		/// Boolean DisableUndeclaredEntityCheck
		/// </summary>
		protected RProperty r_DisableUndeclaredEntityCheck_Boolean;
		public virtual RProperty RDisableUndeclaredEntityCheck_Boolean
		{
			get
			{
				if(r_DisableUndeclaredEntityCheck_Boolean == null)
				{
					r_DisableUndeclaredEntityCheck_Boolean = new(this, "DisableUndeclaredEntityCheck", -1, typeof(System.Boolean));
					r_DisableUndeclaredEntityCheck_Boolean.SetBelong(this.instance);
				}
				return r_DisableUndeclaredEntityCheck_Boolean;
			}
		}

		/// <summary>
		/// Boolean HasValue
		/// </summary>
		protected RProperty r_HasValue;
		public virtual RProperty RHasValue
		{
			get
			{
				if(r_HasValue == null)
				{
					r_HasValue = new(this, "HasValue", -1);
					r_HasValue.SetBelong(this.instance);
				}
				return r_HasValue;
			}
		}

		/// <summary>
		/// System.Xml.Schema.IXmlSchemaInfo SchemaInfo
		/// </summary>
		protected RSystem.RXml.RSchema.RIXmlSchemaInfo r_SchemaInfo;
		public virtual RSystem.RXml.RSchema.RIXmlSchemaInfo RSchemaInfo
		{
			get
			{
				if(r_SchemaInfo == null)
				{
					r_SchemaInfo = new(this, "SchemaInfo", -1);
					r_SchemaInfo.SetBelong(this.instance);
				}
				return r_SchemaInfo;
			}
		}

		/// <summary>
		/// System.Type ValueType
		/// </summary>
		protected RSystem.RType r_ValueType;
		public virtual RSystem.RType RValueType
		{
			get
			{
				if(r_ValueType == null)
				{
					r_ValueType = new(this, "ValueType", -1);
					r_ValueType.SetBelong(this.instance);
				}
				return r_ValueType;
			}
		}

		/// <summary>
		/// System.String Item [Int32]
		/// </summary>
		protected RProperty r_Item_Int32;
		public virtual RProperty RItem_Int32
		{
			get
			{
				if(r_Item_Int32 == null)
				{
					r_Item_Int32 = new(this, "Item", -1, typeof(System.Int32));
					r_Item_Int32.SetBelong(this.instance);
				}
				return r_Item_Int32;
			}
		}

		/// <summary>
		/// System.String Item [System.String]
		/// </summary>
		protected RProperty r_Item_String;
		public virtual RProperty RItem_String
		{
			get
			{
				if(r_Item_String == null)
				{
					r_Item_String = new(this, "Item", -1, typeof(System.String));
					r_Item_String.SetBelong(this.instance);
				}
				return r_Item_String;
			}
		}

		/// <summary>
		/// System.String Item [System.String, System.String]
		/// </summary>
		protected RProperty r_Item_String_String;
		public virtual RProperty RItem_String_String
		{
			get
			{
				if(r_Item_String_String == null)
				{
					r_Item_String_String = new(this, "Item", -1, typeof(System.String), typeof(System.String));
					r_Item_String_String.SetBelong(this.instance);
				}
				return r_Item_String_String;
			}
		}

		/// <summary>
		/// Boolean HasAttributes
		/// </summary>
		protected RProperty r_HasAttributes;
		public virtual RProperty RHasAttributes
		{
			get
			{
				if(r_HasAttributes == null)
				{
					r_HasAttributes = new(this, "HasAttributes", -1);
					r_HasAttributes.SetBelong(this.instance);
				}
				return r_HasAttributes;
			}
		}

		/// <summary>
		/// Boolean IsDefaultInternal
		/// </summary>
		protected RProperty r_IsDefaultInternal;
		public virtual RProperty RIsDefaultInternal
		{
			get
			{
				if(r_IsDefaultInternal == null)
				{
					r_IsDefaultInternal = new(this, "IsDefaultInternal", -1);
					r_IsDefaultInternal.SetBelong(this.instance);
				}
				return r_IsDefaultInternal;
			}
		}

		/// <summary>
		/// Void FinishInitUriString()
		/// </summary>
		protected RMethod r_RFinishInitUriString;
		public virtual RMethod RFinishInitUriString
		{
			get
			{
				if(r_RFinishInitUriString == null)
				{
					r_RFinishInitUriString = new(this, "FinishInitUriString", 0);
					r_RFinishInitUriString.SetBelong(this.instance);
				}
				return r_RFinishInitUriString;
			}
		}

		/// <summary>
		/// Void FinishInitStream()
		/// </summary>
		protected RMethod r_RFinishInitStream;
		public virtual RMethod RFinishInitStream
		{
			get
			{
				if(r_RFinishInitStream == null)
				{
					r_RFinishInitStream = new(this, "FinishInitStream", 0);
					r_RFinishInitStream.SetBelong(this.instance);
				}
				return r_RFinishInitStream;
			}
		}

		/// <summary>
		/// Void FinishInitTextReader()
		/// </summary>
		protected RMethod r_RFinishInitTextReader;
		public virtual RMethod RFinishInitTextReader
		{
			get
			{
				if(r_RFinishInitTextReader == null)
				{
					r_RFinishInitTextReader = new(this, "FinishInitTextReader", 0);
					r_RFinishInitTextReader.SetBelong(this.instance);
				}
				return r_RFinishInitTextReader;
			}
		}

		/// <summary>
		/// System.String GetAttribute(System.String)
		/// </summary>
		protected RMethod r_RGetAttribute_String;
		public virtual RMethod RGetAttribute_String
		{
			get
			{
				if(r_RGetAttribute_String == null)
				{
					r_RGetAttribute_String = new(this, "GetAttribute", 0, typeof(System.String));
					r_RGetAttribute_String.SetBelong(this.instance);
				}
				return r_RGetAttribute_String;
			}
		}

		/// <summary>
		/// System.String GetAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RGetAttribute_String_String;
		public virtual RMethod RGetAttribute_String_String
		{
			get
			{
				if(r_RGetAttribute_String_String == null)
				{
					r_RGetAttribute_String_String = new(this, "GetAttribute", 0, typeof(System.String), typeof(System.String));
					r_RGetAttribute_String_String.SetBelong(this.instance);
				}
				return r_RGetAttribute_String_String;
			}
		}

		/// <summary>
		/// System.String GetAttribute(Int32)
		/// </summary>
		protected RMethod r_RGetAttribute_Int32;
		public virtual RMethod RGetAttribute_Int32
		{
			get
			{
				if(r_RGetAttribute_Int32 == null)
				{
					r_RGetAttribute_Int32 = new(this, "GetAttribute", 0, typeof(System.Int32));
					r_RGetAttribute_Int32.SetBelong(this.instance);
				}
				return r_RGetAttribute_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveToAttribute(System.String)
		/// </summary>
		protected RMethod r_RMoveToAttribute_String;
		public virtual RMethod RMoveToAttribute_String
		{
			get
			{
				if(r_RMoveToAttribute_String == null)
				{
					r_RMoveToAttribute_String = new(this, "MoveToAttribute", 0, typeof(System.String));
					r_RMoveToAttribute_String.SetBelong(this.instance);
				}
				return r_RMoveToAttribute_String;
			}
		}

		/// <summary>
		/// Boolean MoveToAttribute(System.String, System.String)
		/// </summary>
		protected RMethod r_RMoveToAttribute_String_String;
		public virtual RMethod RMoveToAttribute_String_String
		{
			get
			{
				if(r_RMoveToAttribute_String_String == null)
				{
					r_RMoveToAttribute_String_String = new(this, "MoveToAttribute", 0, typeof(System.String), typeof(System.String));
					r_RMoveToAttribute_String_String.SetBelong(this.instance);
				}
				return r_RMoveToAttribute_String_String;
			}
		}

		/// <summary>
		/// Void MoveToAttribute(Int32)
		/// </summary>
		protected RMethod r_RMoveToAttribute_Int32;
		public virtual RMethod RMoveToAttribute_Int32
		{
			get
			{
				if(r_RMoveToAttribute_Int32 == null)
				{
					r_RMoveToAttribute_Int32 = new(this, "MoveToAttribute", 0, typeof(System.Int32));
					r_RMoveToAttribute_Int32.SetBelong(this.instance);
				}
				return r_RMoveToAttribute_Int32;
			}
		}

		/// <summary>
		/// Boolean MoveToFirstAttribute()
		/// </summary>
		protected RMethod r_RMoveToFirstAttribute;
		public virtual RMethod RMoveToFirstAttribute
		{
			get
			{
				if(r_RMoveToFirstAttribute == null)
				{
					r_RMoveToFirstAttribute = new(this, "MoveToFirstAttribute", 0);
					r_RMoveToFirstAttribute.SetBelong(this.instance);
				}
				return r_RMoveToFirstAttribute;
			}
		}

		/// <summary>
		/// Boolean MoveToNextAttribute()
		/// </summary>
		protected RMethod r_RMoveToNextAttribute;
		public virtual RMethod RMoveToNextAttribute
		{
			get
			{
				if(r_RMoveToNextAttribute == null)
				{
					r_RMoveToNextAttribute = new(this, "MoveToNextAttribute", 0);
					r_RMoveToNextAttribute.SetBelong(this.instance);
				}
				return r_RMoveToNextAttribute;
			}
		}

		/// <summary>
		/// Boolean MoveToElement()
		/// </summary>
		protected RMethod r_RMoveToElement;
		public virtual RMethod RMoveToElement
		{
			get
			{
				if(r_RMoveToElement == null)
				{
					r_RMoveToElement = new(this, "MoveToElement", 0);
					r_RMoveToElement.SetBelong(this.instance);
				}
				return r_RMoveToElement;
			}
		}

		/// <summary>
		/// Void FinishInit()
		/// </summary>
		protected RMethod r_RFinishInit;
		public virtual RMethod RFinishInit
		{
			get
			{
				if(r_RFinishInit == null)
				{
					r_RFinishInit = new(this, "FinishInit", 0);
					r_RFinishInit.SetBelong(this.instance);
				}
				return r_RFinishInit;
			}
		}

		/// <summary>
		/// Boolean Read()
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
		/// Void Skip()
		/// </summary>
		protected RMethod r_RSkip;
		public virtual RMethod RSkip
		{
			get
			{
				if(r_RSkip == null)
				{
					r_RSkip = new(this, "Skip", 0);
					r_RSkip.SetBelong(this.instance);
				}
				return r_RSkip;
			}
		}

		/// <summary>
		/// System.String LookupNamespace(System.String)
		/// </summary>
		protected RMethod r_RLookupNamespace_String;
		public virtual RMethod RLookupNamespace_String
		{
			get
			{
				if(r_RLookupNamespace_String == null)
				{
					r_RLookupNamespace_String = new(this, "LookupNamespace", 0, typeof(System.String));
					r_RLookupNamespace_String.SetBelong(this.instance);
				}
				return r_RLookupNamespace_String;
			}
		}

		/// <summary>
		/// Boolean ReadAttributeValue()
		/// </summary>
		protected RMethod r_RReadAttributeValue;
		public virtual RMethod RReadAttributeValue
		{
			get
			{
				if(r_RReadAttributeValue == null)
				{
					r_RReadAttributeValue = new(this, "ReadAttributeValue", 0);
					r_RReadAttributeValue.SetBelong(this.instance);
				}
				return r_RReadAttributeValue;
			}
		}

		/// <summary>
		/// Void ResolveEntity()
		/// </summary>
		protected RMethod r_RResolveEntity;
		public virtual RMethod RResolveEntity
		{
			get
			{
				if(r_RResolveEntity == null)
				{
					r_RResolveEntity = new(this, "ResolveEntity", 0);
					r_RResolveEntity.SetBelong(this.instance);
				}
				return r_RResolveEntity;
			}
		}

		/// <summary>
		/// Void MoveOffEntityReference()
		/// </summary>
		protected RMethod r_RMoveOffEntityReference;
		public virtual RMethod RMoveOffEntityReference
		{
			get
			{
				if(r_RMoveOffEntityReference == null)
				{
					r_RMoveOffEntityReference = new(this, "MoveOffEntityReference", 0);
					r_RMoveOffEntityReference.SetBelong(this.instance);
				}
				return r_RMoveOffEntityReference;
			}
		}

		/// <summary>
		/// System.String ReadString()
		/// </summary>
		protected RMethod r_RReadString;
		public virtual RMethod RReadString
		{
			get
			{
				if(r_RReadString == null)
				{
					r_RReadString = new(this, "ReadString", 0);
					r_RReadString.SetBelong(this.instance);
				}
				return r_RReadString;
			}
		}

		/// <summary>
		/// Int32 ReadContentAsBase64(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBase64_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBase64_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBase64_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBase64_ByteArray_Int32_Int32 = new(this, "ReadContentAsBase64", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBase64_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBase64_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadContentAsBinHex(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBinHex_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBinHex_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBinHex_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBinHex_ByteArray_Int32_Int32 = new(this, "ReadContentAsBinHex", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBinHex_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBinHex_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsBase64(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBase64_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBase64_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBase64_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBase64_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBase64", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBase64_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBase64_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsBinHex(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBinHex_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBinHex_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBinHex_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBinHex_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBinHex", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBinHex_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBinHex_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadValueChunk(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadValueChunk_CharArray_Int32_Int32;
		public virtual RMethod RReadValueChunk_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadValueChunk_CharArray_Int32_Int32 == null)
				{
					r_RReadValueChunk_CharArray_Int32_Int32 = new(this, "ReadValueChunk", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadValueChunk_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadValueChunk_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean HasLineInfo()
		/// </summary>
		protected RMethod r_RHasLineInfo;
		public virtual RMethod RHasLineInfo
		{
			get
			{
				if(r_RHasLineInfo == null)
				{
					r_RHasLineInfo = new(this, "HasLineInfo", 0);
					r_RHasLineInfo.SetBelong(this.instance);
				}
				return r_RHasLineInfo;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IDictionary`2[System.String,System.String] System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope;
		public virtual RMethod RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope
		{
			get
			{
				if(r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope == null)
				{
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope = new(this, "System.Xml.IXmlNamespaceResolver.GetNamespacesInScope", 0, typeof(System.Xml.XmlNamespaceScope));
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope;
			}
		}

		/// <summary>
		/// System.String System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String;
		public virtual RMethod RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String
		{
			get
			{
				if(r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String == null)
				{
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String = new(this, "System.Xml.IXmlNamespaceResolver.LookupNamespace", 0, typeof(System.String));
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String;
			}
		}

		/// <summary>
		/// System.String System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)
		/// </summary>
		protected RMethod r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String;
		public virtual RMethod RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String
		{
			get
			{
				if(r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String == null)
				{
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String = new(this, "System.Xml.IXmlNamespaceResolver.LookupPrefix", 0, typeof(System.String));
					r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String.SetBelong(this.instance);
				}
				return r_RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String;
			}
		}

		/// <summary>
		/// System.Collections.Generic.IDictionary`2[System.String,System.String] GetNamespacesInScope(System.Xml.XmlNamespaceScope)
		/// </summary>
		protected RMethod r_RGetNamespacesInScope_XmlNamespaceScope;
		public virtual RMethod RGetNamespacesInScope_XmlNamespaceScope
		{
			get
			{
				if(r_RGetNamespacesInScope_XmlNamespaceScope == null)
				{
					r_RGetNamespacesInScope_XmlNamespaceScope = new(this, "GetNamespacesInScope", 0, typeof(System.Xml.XmlNamespaceScope));
					r_RGetNamespacesInScope_XmlNamespaceScope.SetBelong(this.instance);
				}
				return r_RGetNamespacesInScope_XmlNamespaceScope;
			}
		}

		/// <summary>
		/// System.String LookupPrefix(System.String)
		/// </summary>
		protected RMethod r_RLookupPrefix_String;
		public virtual RMethod RLookupPrefix_String
		{
			get
			{
				if(r_RLookupPrefix_String == null)
				{
					r_RLookupPrefix_String = new(this, "LookupPrefix", 0, typeof(System.String));
					r_RLookupPrefix_String.SetBelong(this.instance);
				}
				return r_RLookupPrefix_String;
			}
		}

		/// <summary>
		/// Void ResetState()
		/// </summary>
		protected RMethod r_RResetState;
		public virtual RMethod RResetState
		{
			get
			{
				if(r_RResetState == null)
				{
					r_RResetState = new(this, "ResetState", 0);
					r_RResetState.SetBelong(this.instance);
				}
				return r_RResetState;
			}
		}

		/// <summary>
		/// System.IO.TextReader GetRemainder()
		/// </summary>
		protected RMethod r_RGetRemainder;
		public virtual RMethod RGetRemainder
		{
			get
			{
				if(r_RGetRemainder == null)
				{
					r_RGetRemainder = new(this, "GetRemainder", 0);
					r_RGetRemainder.SetBelong(this.instance);
				}
				return r_RGetRemainder;
			}
		}

		/// <summary>
		/// Int32 ReadChars(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadChars_CharArray_Int32_Int32;
		public virtual RMethod RReadChars_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadChars_CharArray_Int32_Int32 == null)
				{
					r_RReadChars_CharArray_Int32_Int32 = new(this, "ReadChars", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadChars_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadChars_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadBase64(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadBase64_ByteArray_Int32_Int32;
		public virtual RMethod RReadBase64_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadBase64_ByteArray_Int32_Int32 == null)
				{
					r_RReadBase64_ByteArray_Int32_Int32 = new(this, "ReadBase64", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadBase64_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadBase64_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadBinHex(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadBinHex_ByteArray_Int32_Int32;
		public virtual RMethod RReadBinHex_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadBinHex_ByteArray_Int32_Int32 == null)
				{
					r_RReadBinHex_ByteArray_Int32_Int32 = new(this, "ReadBinHex", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadBinHex_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadBinHex_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void DtdParserProxy_OnNewLine(Int32)
		/// </summary>
		protected RMethod r_RDtdParserProxy_OnNewLine_Int32;
		public virtual RMethod RDtdParserProxy_OnNewLine_Int32
		{
			get
			{
				if(r_RDtdParserProxy_OnNewLine_Int32 == null)
				{
					r_RDtdParserProxy_OnNewLine_Int32 = new(this, "DtdParserProxy_OnNewLine", 0, typeof(System.Int32));
					r_RDtdParserProxy_OnNewLine_Int32.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_OnNewLine_Int32;
			}
		}

		/// <summary>
		/// Int32 DtdParserProxy_ReadData()
		/// </summary>
		protected RMethod r_RDtdParserProxy_ReadData;
		public virtual RMethod RDtdParserProxy_ReadData
		{
			get
			{
				if(r_RDtdParserProxy_ReadData == null)
				{
					r_RDtdParserProxy_ReadData = new(this, "DtdParserProxy_ReadData", 0);
					r_RDtdParserProxy_ReadData.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ReadData;
			}
		}

		/// <summary>
		/// Int32 DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RDtdParserProxy_ParseNumericCharRef_StringBuilder;
		public virtual RMethod RDtdParserProxy_ParseNumericCharRef_StringBuilder
		{
			get
			{
				if(r_RDtdParserProxy_ParseNumericCharRef_StringBuilder == null)
				{
					r_RDtdParserProxy_ParseNumericCharRef_StringBuilder = new(this, "DtdParserProxy_ParseNumericCharRef", 0, typeof(System.Text.StringBuilder));
					r_RDtdParserProxy_ParseNumericCharRef_StringBuilder.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ParseNumericCharRef_StringBuilder;
			}
		}

		/// <summary>
		/// Int32 DtdParserProxy_ParseNamedCharRef(Boolean, System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RDtdParserProxy_ParseNamedCharRef_Boolean_StringBuilder;
		public virtual RMethod RDtdParserProxy_ParseNamedCharRef_Boolean_StringBuilder
		{
			get
			{
				if(r_RDtdParserProxy_ParseNamedCharRef_Boolean_StringBuilder == null)
				{
					r_RDtdParserProxy_ParseNamedCharRef_Boolean_StringBuilder = new(this, "DtdParserProxy_ParseNamedCharRef", 0, typeof(System.Boolean), typeof(System.Text.StringBuilder));
					r_RDtdParserProxy_ParseNamedCharRef_Boolean_StringBuilder.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ParseNamedCharRef_Boolean_StringBuilder;
			}
		}

		/// <summary>
		/// Void DtdParserProxy_ParsePI(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RDtdParserProxy_ParsePI_StringBuilder;
		public virtual RMethod RDtdParserProxy_ParsePI_StringBuilder
		{
			get
			{
				if(r_RDtdParserProxy_ParsePI_StringBuilder == null)
				{
					r_RDtdParserProxy_ParsePI_StringBuilder = new(this, "DtdParserProxy_ParsePI", 0, typeof(System.Text.StringBuilder));
					r_RDtdParserProxy_ParsePI_StringBuilder.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ParsePI_StringBuilder;
			}
		}

		/// <summary>
		/// Void DtdParserProxy_ParseComment(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RDtdParserProxy_ParseComment_StringBuilder;
		public virtual RMethod RDtdParserProxy_ParseComment_StringBuilder
		{
			get
			{
				if(r_RDtdParserProxy_ParseComment_StringBuilder == null)
				{
					r_RDtdParserProxy_ParseComment_StringBuilder = new(this, "DtdParserProxy_ParseComment", 0, typeof(System.Text.StringBuilder));
					r_RDtdParserProxy_ParseComment_StringBuilder.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ParseComment_StringBuilder;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver GetTempResolver()
		/// </summary>
		protected RMethod r_RGetTempResolver;
		public virtual RMethod RGetTempResolver
		{
			get
			{
				if(r_RGetTempResolver == null)
				{
					r_RGetTempResolver = new(this, "GetTempResolver", 0);
					r_RGetTempResolver.SetBelong(this.instance);
				}
				return r_RGetTempResolver;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_PushEntity(System.Xml.IDtdEntityInfo, Int32 ByRef)
		/// </summary>
		protected RMethod r_RDtdParserProxy_PushEntity_IDtdEntityInfo_Out_Int32;
		public virtual RMethod RDtdParserProxy_PushEntity_IDtdEntityInfo_Out_Int32
		{
			get
			{
				if(r_RDtdParserProxy_PushEntity_IDtdEntityInfo_Out_Int32 == null)
				{
					r_RDtdParserProxy_PushEntity_IDtdEntityInfo_Out_Int32 = new(this, "DtdParserProxy_PushEntity", 0,  ReleactionUtils.GetType("System.Xml.IDtdEntityInfo"), typeof(System.Int32).MakeByRefType());
					r_RDtdParserProxy_PushEntity_IDtdEntityInfo_Out_Int32.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_PushEntity_IDtdEntityInfo_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_PopEntity(System.Xml.IDtdEntityInfo ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RDtdParserProxy_PopEntity_Out_IDtdEntityInfo_Out_Int32;
		public virtual RMethod RDtdParserProxy_PopEntity_Out_IDtdEntityInfo_Out_Int32
		{
			get
			{
				if(r_RDtdParserProxy_PopEntity_Out_IDtdEntityInfo_Out_Int32 == null)
				{
					r_RDtdParserProxy_PopEntity_Out_IDtdEntityInfo_Out_Int32 = new(this, "DtdParserProxy_PopEntity", 0,  ReleactionUtils.GetType("System.Xml.IDtdEntityInfo").MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RDtdParserProxy_PopEntity_Out_IDtdEntityInfo_Out_Int32.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_PopEntity_Out_IDtdEntityInfo_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean DtdParserProxy_PushExternalSubset(System.String, System.String)
		/// </summary>
		protected RMethod r_RDtdParserProxy_PushExternalSubset_String_String;
		public virtual RMethod RDtdParserProxy_PushExternalSubset_String_String
		{
			get
			{
				if(r_RDtdParserProxy_PushExternalSubset_String_String == null)
				{
					r_RDtdParserProxy_PushExternalSubset_String_String = new(this, "DtdParserProxy_PushExternalSubset", 0, typeof(System.String), typeof(System.String));
					r_RDtdParserProxy_PushExternalSubset_String_String.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_PushExternalSubset_String_String;
			}
		}

		/// <summary>
		/// Void DtdParserProxy_PushInternalDtd(System.String, System.String)
		/// </summary>
		protected RMethod r_RDtdParserProxy_PushInternalDtd_String_String;
		public virtual RMethod RDtdParserProxy_PushInternalDtd_String_String
		{
			get
			{
				if(r_RDtdParserProxy_PushInternalDtd_String_String == null)
				{
					r_RDtdParserProxy_PushInternalDtd_String_String = new(this, "DtdParserProxy_PushInternalDtd", 0, typeof(System.String), typeof(System.String));
					r_RDtdParserProxy_PushInternalDtd_String_String.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_PushInternalDtd_String_String;
			}
		}

		/// <summary>
		/// Void DtdParserProxy_Throw(System.Exception)
		/// </summary>
		protected RMethod r_RDtdParserProxy_Throw_Exception;
		public virtual RMethod RDtdParserProxy_Throw_Exception
		{
			get
			{
				if(r_RDtdParserProxy_Throw_Exception == null)
				{
					r_RDtdParserProxy_Throw_Exception = new(this, "DtdParserProxy_Throw", 0, typeof(System.Exception));
					r_RDtdParserProxy_Throw_Exception.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_Throw_Exception;
			}
		}

		/// <summary>
		/// Void DtdParserProxy_OnSystemId(System.String, System.Xml.LineInfo, System.Xml.LineInfo)
		/// </summary>
		protected RMethod r_RDtdParserProxy_OnSystemId_String_LineInfo_LineInfo;
		public virtual RMethod RDtdParserProxy_OnSystemId_String_LineInfo_LineInfo
		{
			get
			{
				if(r_RDtdParserProxy_OnSystemId_String_LineInfo_LineInfo == null)
				{
					r_RDtdParserProxy_OnSystemId_String_LineInfo_LineInfo = new(this, "DtdParserProxy_OnSystemId", 0, typeof(System.String),  ReleactionUtils.GetType("System.Xml.LineInfo"),  ReleactionUtils.GetType("System.Xml.LineInfo"));
					r_RDtdParserProxy_OnSystemId_String_LineInfo_LineInfo.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_OnSystemId_String_LineInfo_LineInfo;
			}
		}

		/// <summary>
		/// Void DtdParserProxy_OnPublicId(System.String, System.Xml.LineInfo, System.Xml.LineInfo)
		/// </summary>
		protected RMethod r_RDtdParserProxy_OnPublicId_String_LineInfo_LineInfo;
		public virtual RMethod RDtdParserProxy_OnPublicId_String_LineInfo_LineInfo
		{
			get
			{
				if(r_RDtdParserProxy_OnPublicId_String_LineInfo_LineInfo == null)
				{
					r_RDtdParserProxy_OnPublicId_String_LineInfo_LineInfo = new(this, "DtdParserProxy_OnPublicId", 0, typeof(System.String),  ReleactionUtils.GetType("System.Xml.LineInfo"),  ReleactionUtils.GetType("System.Xml.LineInfo"));
					r_RDtdParserProxy_OnPublicId_String_LineInfo_LineInfo.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_OnPublicId_String_LineInfo_LineInfo;
			}
		}

		/// <summary>
		/// Void Throw(Int32, System.String, System.String)
		/// </summary>
		protected RMethod r_RThrow_Int32_String_String;
		public virtual RMethod RThrow_Int32_String_String
		{
			get
			{
				if(r_RThrow_Int32_String_String == null)
				{
					r_RThrow_Int32_String_String = new(this, "Throw", 0, typeof(System.Int32), typeof(System.String), typeof(System.String));
					r_RThrow_Int32_String_String.SetBelong(this.instance);
				}
				return r_RThrow_Int32_String_String;
			}
		}

		/// <summary>
		/// Void Throw(Int32, System.String, System.String[])
		/// </summary>
		protected RMethod r_RThrow_Int32_String_StringArray;
		public virtual RMethod RThrow_Int32_String_StringArray
		{
			get
			{
				if(r_RThrow_Int32_String_StringArray == null)
				{
					r_RThrow_Int32_String_StringArray = new(this, "Throw", 0, typeof(System.Int32), typeof(System.String), typeof(System.String).MakeArrayType());
					r_RThrow_Int32_String_StringArray.SetBelong(this.instance);
				}
				return r_RThrow_Int32_String_StringArray;
			}
		}

		/// <summary>
		/// Void Throw(Int32, System.String)
		/// </summary>
		protected RMethod r_RThrow_Int32_String;
		public virtual RMethod RThrow_Int32_String
		{
			get
			{
				if(r_RThrow_Int32_String == null)
				{
					r_RThrow_Int32_String = new(this, "Throw", 0, typeof(System.Int32), typeof(System.String));
					r_RThrow_Int32_String.SetBelong(this.instance);
				}
				return r_RThrow_Int32_String;
			}
		}

		/// <summary>
		/// Void Throw(System.String)
		/// </summary>
		protected RMethod r_RThrow_String;
		public virtual RMethod RThrow_String
		{
			get
			{
				if(r_RThrow_String == null)
				{
					r_RThrow_String = new(this, "Throw", 0, typeof(System.String));
					r_RThrow_String.SetBelong(this.instance);
				}
				return r_RThrow_String;
			}
		}

		/// <summary>
		/// Void Throw(System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RThrow_String_Int32_Int32;
		public virtual RMethod RThrow_String_Int32_Int32
		{
			get
			{
				if(r_RThrow_String_Int32_Int32 == null)
				{
					r_RThrow_String_Int32_Int32 = new(this, "Throw", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RThrow_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RThrow_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Throw(System.String, System.String)
		/// </summary>
		protected RMethod r_RThrow_String_String;
		public virtual RMethod RThrow_String_String
		{
			get
			{
				if(r_RThrow_String_String == null)
				{
					r_RThrow_String_String = new(this, "Throw", 0, typeof(System.String), typeof(System.String));
					r_RThrow_String_String.SetBelong(this.instance);
				}
				return r_RThrow_String_String;
			}
		}

		/// <summary>
		/// Void Throw(System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RThrow_String_String_Int32_Int32;
		public virtual RMethod RThrow_String_String_Int32_Int32
		{
			get
			{
				if(r_RThrow_String_String_Int32_Int32 == null)
				{
					r_RThrow_String_String_Int32_Int32 = new(this, "Throw", 0, typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RThrow_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RThrow_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void Throw(System.String, System.String[])
		/// </summary>
		protected RMethod r_RThrow_String_StringArray;
		public virtual RMethod RThrow_String_StringArray
		{
			get
			{
				if(r_RThrow_String_StringArray == null)
				{
					r_RThrow_String_StringArray = new(this, "Throw", 0, typeof(System.String), typeof(System.String).MakeArrayType());
					r_RThrow_String_StringArray.SetBelong(this.instance);
				}
				return r_RThrow_String_StringArray;
			}
		}

		/// <summary>
		/// Void Throw(System.String, System.String, System.Exception)
		/// </summary>
		protected RMethod r_RThrow_String_String_Exception;
		public virtual RMethod RThrow_String_String_Exception
		{
			get
			{
				if(r_RThrow_String_String_Exception == null)
				{
					r_RThrow_String_String_Exception = new(this, "Throw", 0, typeof(System.String), typeof(System.String), typeof(System.Exception));
					r_RThrow_String_String_Exception.SetBelong(this.instance);
				}
				return r_RThrow_String_String_Exception;
			}
		}

		/// <summary>
		/// Void Throw(System.String, System.String[], System.Exception)
		/// </summary>
		protected RMethod r_RThrow_String_StringArray_Exception;
		public virtual RMethod RThrow_String_StringArray_Exception
		{
			get
			{
				if(r_RThrow_String_StringArray_Exception == null)
				{
					r_RThrow_String_StringArray_Exception = new(this, "Throw", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Exception));
					r_RThrow_String_StringArray_Exception.SetBelong(this.instance);
				}
				return r_RThrow_String_StringArray_Exception;
			}
		}

		/// <summary>
		/// Void Throw(System.Exception)
		/// </summary>
		protected RMethod r_RThrow_Exception;
		public virtual RMethod RThrow_Exception
		{
			get
			{
				if(r_RThrow_Exception == null)
				{
					r_RThrow_Exception = new(this, "Throw", 0, typeof(System.Exception));
					r_RThrow_Exception.SetBelong(this.instance);
				}
				return r_RThrow_Exception;
			}
		}

		/// <summary>
		/// Void ReThrow(System.Exception, Int32, Int32)
		/// </summary>
		protected RMethod r_RReThrow_Exception_Int32_Int32;
		public virtual RMethod RReThrow_Exception_Int32_Int32
		{
			get
			{
				if(r_RReThrow_Exception_Int32_Int32 == null)
				{
					r_RReThrow_Exception_Int32_Int32 = new(this, "ReThrow", 0, typeof(System.Exception), typeof(System.Int32), typeof(System.Int32));
					r_RReThrow_Exception_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReThrow_Exception_Int32_Int32;
			}
		}

		/// <summary>
		/// Void ThrowWithoutLineInfo(System.String)
		/// </summary>
		protected RMethod r_RThrowWithoutLineInfo_String;
		public virtual RMethod RThrowWithoutLineInfo_String
		{
			get
			{
				if(r_RThrowWithoutLineInfo_String == null)
				{
					r_RThrowWithoutLineInfo_String = new(this, "ThrowWithoutLineInfo", 0, typeof(System.String));
					r_RThrowWithoutLineInfo_String.SetBelong(this.instance);
				}
				return r_RThrowWithoutLineInfo_String;
			}
		}

		/// <summary>
		/// Void ThrowWithoutLineInfo(System.String, System.String)
		/// </summary>
		protected RMethod r_RThrowWithoutLineInfo_String_String;
		public virtual RMethod RThrowWithoutLineInfo_String_String
		{
			get
			{
				if(r_RThrowWithoutLineInfo_String_String == null)
				{
					r_RThrowWithoutLineInfo_String_String = new(this, "ThrowWithoutLineInfo", 0, typeof(System.String), typeof(System.String));
					r_RThrowWithoutLineInfo_String_String.SetBelong(this.instance);
				}
				return r_RThrowWithoutLineInfo_String_String;
			}
		}

		/// <summary>
		/// Void ThrowWithoutLineInfo(System.String, System.String[], System.Exception)
		/// </summary>
		protected RMethod r_RThrowWithoutLineInfo_String_StringArray_Exception;
		public virtual RMethod RThrowWithoutLineInfo_String_StringArray_Exception
		{
			get
			{
				if(r_RThrowWithoutLineInfo_String_StringArray_Exception == null)
				{
					r_RThrowWithoutLineInfo_String_StringArray_Exception = new(this, "ThrowWithoutLineInfo", 0, typeof(System.String), typeof(System.String).MakeArrayType(), typeof(System.Exception));
					r_RThrowWithoutLineInfo_String_StringArray_Exception.SetBelong(this.instance);
				}
				return r_RThrowWithoutLineInfo_String_StringArray_Exception;
			}
		}

		/// <summary>
		/// Void ThrowInvalidChar(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RThrowInvalidChar_CharArray_Int32_Int32;
		public virtual RMethod RThrowInvalidChar_CharArray_Int32_Int32
		{
			get
			{
				if(r_RThrowInvalidChar_CharArray_Int32_Int32 == null)
				{
					r_RThrowInvalidChar_CharArray_Int32_Int32 = new(this, "ThrowInvalidChar", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RThrowInvalidChar_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RThrowInvalidChar_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SetErrorState()
		/// </summary>
		protected RMethod r_RSetErrorState;
		public virtual RMethod RSetErrorState
		{
			get
			{
				if(r_RSetErrorState == null)
				{
					r_RSetErrorState = new(this, "SetErrorState", 0);
					r_RSetErrorState.SetBelong(this.instance);
				}
				return r_RSetErrorState;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.Xml.Schema.XmlSeverityType, System.String, System.String, Int32, Int32)
		/// </summary>
		protected RMethod r_RSendValidationEvent_XmlSeverityType_String_String_Int32_Int32;
		public virtual RMethod RSendValidationEvent_XmlSeverityType_String_String_Int32_Int32
		{
			get
			{
				if(r_RSendValidationEvent_XmlSeverityType_String_String_Int32_Int32 == null)
				{
					r_RSendValidationEvent_XmlSeverityType_String_String_Int32_Int32 = new(this, "SendValidationEvent", 0, typeof(System.Xml.Schema.XmlSeverityType), typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32));
					r_RSendValidationEvent_XmlSeverityType_String_String_Int32_Int32.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_XmlSeverityType_String_String_Int32_Int32;
			}
		}

		/// <summary>
		/// Void SendValidationEvent(System.Xml.Schema.XmlSeverityType, System.Xml.Schema.XmlSchemaException)
		/// </summary>
		protected RMethod r_RSendValidationEvent_XmlSeverityType_XmlSchemaException;
		public virtual RMethod RSendValidationEvent_XmlSeverityType_XmlSchemaException
		{
			get
			{
				if(r_RSendValidationEvent_XmlSeverityType_XmlSchemaException == null)
				{
					r_RSendValidationEvent_XmlSeverityType_XmlSchemaException = new(this, "SendValidationEvent", 0, typeof(System.Xml.Schema.XmlSeverityType), typeof(System.Xml.Schema.XmlSchemaException));
					r_RSendValidationEvent_XmlSeverityType_XmlSchemaException.SetBelong(this.instance);
				}
				return r_RSendValidationEvent_XmlSeverityType_XmlSchemaException;
			}
		}

		/// <summary>
		/// Void FinishAttributeValueIterator()
		/// </summary>
		protected RMethod r_RFinishAttributeValueIterator;
		public virtual RMethod RFinishAttributeValueIterator
		{
			get
			{
				if(r_RFinishAttributeValueIterator == null)
				{
					r_RFinishAttributeValueIterator = new(this, "FinishAttributeValueIterator", 0);
					r_RFinishAttributeValueIterator.SetBelong(this.instance);
				}
				return r_RFinishAttributeValueIterator;
			}
		}

		/// <summary>
		/// Void InitStreamInput(System.IO.Stream, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RInitStreamInput_Stream_Encoding;
		public virtual RMethod RInitStreamInput_Stream_Encoding
		{
			get
			{
				if(r_RInitStreamInput_Stream_Encoding == null)
				{
					r_RInitStreamInput_Stream_Encoding = new(this, "InitStreamInput", 0, typeof(System.IO.Stream), typeof(System.Text.Encoding));
					r_RInitStreamInput_Stream_Encoding.SetBelong(this.instance);
				}
				return r_RInitStreamInput_Stream_Encoding;
			}
		}

		/// <summary>
		/// Void InitStreamInput(System.String, System.IO.Stream, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RInitStreamInput_String_Stream_Encoding;
		public virtual RMethod RInitStreamInput_String_Stream_Encoding
		{
			get
			{
				if(r_RInitStreamInput_String_Stream_Encoding == null)
				{
					r_RInitStreamInput_String_Stream_Encoding = new(this, "InitStreamInput", 0, typeof(System.String), typeof(System.IO.Stream), typeof(System.Text.Encoding));
					r_RInitStreamInput_String_Stream_Encoding.SetBelong(this.instance);
				}
				return r_RInitStreamInput_String_Stream_Encoding;
			}
		}

		/// <summary>
		/// Void InitStreamInput(System.Uri, System.IO.Stream, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RInitStreamInput_Uri_Stream_Encoding;
		public virtual RMethod RInitStreamInput_Uri_Stream_Encoding
		{
			get
			{
				if(r_RInitStreamInput_Uri_Stream_Encoding == null)
				{
					r_RInitStreamInput_Uri_Stream_Encoding = new(this, "InitStreamInput", 0, typeof(System.Uri), typeof(System.IO.Stream), typeof(System.Text.Encoding));
					r_RInitStreamInput_Uri_Stream_Encoding.SetBelong(this.instance);
				}
				return r_RInitStreamInput_Uri_Stream_Encoding;
			}
		}

		/// <summary>
		/// Void InitStreamInput(System.Uri, System.String, System.IO.Stream, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RInitStreamInput_Uri_String_Stream_Encoding;
		public virtual RMethod RInitStreamInput_Uri_String_Stream_Encoding
		{
			get
			{
				if(r_RInitStreamInput_Uri_String_Stream_Encoding == null)
				{
					r_RInitStreamInput_Uri_String_Stream_Encoding = new(this, "InitStreamInput", 0, typeof(System.Uri), typeof(System.String), typeof(System.IO.Stream), typeof(System.Text.Encoding));
					r_RInitStreamInput_Uri_String_Stream_Encoding.SetBelong(this.instance);
				}
				return r_RInitStreamInput_Uri_String_Stream_Encoding;
			}
		}

		/// <summary>
		/// Void InitStreamInput(System.Uri, System.String, System.IO.Stream, Byte[], Int32, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RInitStreamInput_Uri_String_Stream_ByteArray_Int32_Encoding;
		public virtual RMethod RInitStreamInput_Uri_String_Stream_ByteArray_Int32_Encoding
		{
			get
			{
				if(r_RInitStreamInput_Uri_String_Stream_ByteArray_Int32_Encoding == null)
				{
					r_RInitStreamInput_Uri_String_Stream_ByteArray_Int32_Encoding = new(this, "InitStreamInput", 0, typeof(System.Uri), typeof(System.String), typeof(System.IO.Stream), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Text.Encoding));
					r_RInitStreamInput_Uri_String_Stream_ByteArray_Int32_Encoding.SetBelong(this.instance);
				}
				return r_RInitStreamInput_Uri_String_Stream_ByteArray_Int32_Encoding;
			}
		}

		/// <summary>
		/// Void InitTextReaderInput(System.String, System.IO.TextReader)
		/// </summary>
		protected RMethod r_RInitTextReaderInput_String_TextReader;
		public virtual RMethod RInitTextReaderInput_String_TextReader
		{
			get
			{
				if(r_RInitTextReaderInput_String_TextReader == null)
				{
					r_RInitTextReaderInput_String_TextReader = new(this, "InitTextReaderInput", 0, typeof(System.String), typeof(System.IO.TextReader));
					r_RInitTextReaderInput_String_TextReader.SetBelong(this.instance);
				}
				return r_RInitTextReaderInput_String_TextReader;
			}
		}

		/// <summary>
		/// Void InitTextReaderInput(System.String, System.Uri, System.IO.TextReader)
		/// </summary>
		protected RMethod r_RInitTextReaderInput_String_Uri_TextReader;
		public virtual RMethod RInitTextReaderInput_String_Uri_TextReader
		{
			get
			{
				if(r_RInitTextReaderInput_String_Uri_TextReader == null)
				{
					r_RInitTextReaderInput_String_Uri_TextReader = new(this, "InitTextReaderInput", 0, typeof(System.String), typeof(System.Uri), typeof(System.IO.TextReader));
					r_RInitTextReaderInput_String_Uri_TextReader.SetBelong(this.instance);
				}
				return r_RInitTextReaderInput_String_Uri_TextReader;
			}
		}

		/// <summary>
		/// Void InitStringInput(System.String, System.Text.Encoding, System.String)
		/// </summary>
		protected RMethod r_RInitStringInput_String_Encoding_String;
		public virtual RMethod RInitStringInput_String_Encoding_String
		{
			get
			{
				if(r_RInitStringInput_String_Encoding_String == null)
				{
					r_RInitStringInput_String_Encoding_String = new(this, "InitStringInput", 0, typeof(System.String), typeof(System.Text.Encoding), typeof(System.String));
					r_RInitStringInput_String_Encoding_String.SetBelong(this.instance);
				}
				return r_RInitStringInput_String_Encoding_String;
			}
		}

		/// <summary>
		/// Void InitFragmentReader(System.Xml.XmlNodeType, System.Xml.XmlParserContext, Boolean)
		/// </summary>
		protected RMethod r_RInitFragmentReader_XmlNodeType_XmlParserContext_Boolean;
		public virtual RMethod RInitFragmentReader_XmlNodeType_XmlParserContext_Boolean
		{
			get
			{
				if(r_RInitFragmentReader_XmlNodeType_XmlParserContext_Boolean == null)
				{
					r_RInitFragmentReader_XmlNodeType_XmlParserContext_Boolean = new(this, "InitFragmentReader", 0, typeof(System.Xml.XmlNodeType), typeof(System.Xml.XmlParserContext), typeof(System.Boolean));
					r_RInitFragmentReader_XmlNodeType_XmlParserContext_Boolean.SetBelong(this.instance);
				}
				return r_RInitFragmentReader_XmlNodeType_XmlParserContext_Boolean;
			}
		}

		/// <summary>
		/// Void ProcessDtdFromParserContext(System.Xml.XmlParserContext)
		/// </summary>
		protected RMethod r_RProcessDtdFromParserContext_XmlParserContext;
		public virtual RMethod RProcessDtdFromParserContext_XmlParserContext
		{
			get
			{
				if(r_RProcessDtdFromParserContext_XmlParserContext == null)
				{
					r_RProcessDtdFromParserContext_XmlParserContext = new(this, "ProcessDtdFromParserContext", 0, typeof(System.Xml.XmlParserContext));
					r_RProcessDtdFromParserContext_XmlParserContext.SetBelong(this.instance);
				}
				return r_RProcessDtdFromParserContext_XmlParserContext;
			}
		}

		/// <summary>
		/// Void OpenUrl()
		/// </summary>
		protected RMethod r_ROpenUrl;
		public virtual RMethod ROpenUrl
		{
			get
			{
				if(r_ROpenUrl == null)
				{
					r_ROpenUrl = new(this, "OpenUrl", 0);
					r_ROpenUrl.SetBelong(this.instance);
				}
				return r_ROpenUrl;
			}
		}

		/// <summary>
		/// Void OpenUrlDelegate(System.Object)
		/// </summary>
		protected RMethod r_ROpenUrlDelegate_Object;
		public virtual RMethod ROpenUrlDelegate_Object
		{
			get
			{
				if(r_ROpenUrlDelegate_Object == null)
				{
					r_ROpenUrlDelegate_Object = new(this, "OpenUrlDelegate", 0, typeof(System.Object));
					r_ROpenUrlDelegate_Object.SetBelong(this.instance);
				}
				return r_ROpenUrlDelegate_Object;
			}
		}

		/// <summary>
		/// System.Text.Encoding DetectEncoding()
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
		/// Void SetupEncoding(System.Text.Encoding)
		/// </summary>
		protected RMethod r_RSetupEncoding_Encoding;
		public virtual RMethod RSetupEncoding_Encoding
		{
			get
			{
				if(r_RSetupEncoding_Encoding == null)
				{
					r_RSetupEncoding_Encoding = new(this, "SetupEncoding", 0, typeof(System.Text.Encoding));
					r_RSetupEncoding_Encoding.SetBelong(this.instance);
				}
				return r_RSetupEncoding_Encoding;
			}
		}

		/// <summary>
		/// Void SwitchEncoding(System.Text.Encoding)
		/// </summary>
		protected RMethod r_RSwitchEncoding_Encoding;
		public virtual RMethod RSwitchEncoding_Encoding
		{
			get
			{
				if(r_RSwitchEncoding_Encoding == null)
				{
					r_RSwitchEncoding_Encoding = new(this, "SwitchEncoding", 0, typeof(System.Text.Encoding));
					r_RSwitchEncoding_Encoding.SetBelong(this.instance);
				}
				return r_RSwitchEncoding_Encoding;
			}
		}

		/// <summary>
		/// System.Text.Encoding CheckEncoding(System.String)
		/// </summary>
		protected RMethod r_RCheckEncoding_String;
		public virtual RMethod RCheckEncoding_String
		{
			get
			{
				if(r_RCheckEncoding_String == null)
				{
					r_RCheckEncoding_String = new(this, "CheckEncoding", 0, typeof(System.String));
					r_RCheckEncoding_String.SetBelong(this.instance);
				}
				return r_RCheckEncoding_String;
			}
		}

		/// <summary>
		/// Void UnDecodeChars()
		/// </summary>
		protected RMethod r_RUnDecodeChars;
		public virtual RMethod RUnDecodeChars
		{
			get
			{
				if(r_RUnDecodeChars == null)
				{
					r_RUnDecodeChars = new(this, "UnDecodeChars", 0);
					r_RUnDecodeChars.SetBelong(this.instance);
				}
				return r_RUnDecodeChars;
			}
		}

		/// <summary>
		/// Void SwitchEncodingToUTF8()
		/// </summary>
		protected RMethod r_RSwitchEncodingToUTF8;
		public virtual RMethod RSwitchEncodingToUTF8
		{
			get
			{
				if(r_RSwitchEncodingToUTF8 == null)
				{
					r_RSwitchEncodingToUTF8 = new(this, "SwitchEncodingToUTF8", 0);
					r_RSwitchEncodingToUTF8.SetBelong(this.instance);
				}
				return r_RSwitchEncodingToUTF8;
			}
		}

		/// <summary>
		/// Int32 ReadData()
		/// </summary>
		protected RMethod r_RReadData;
		public virtual RMethod RReadData
		{
			get
			{
				if(r_RReadData == null)
				{
					r_RReadData = new(this, "ReadData", 0);
					r_RReadData.SetBelong(this.instance);
				}
				return r_RReadData;
			}
		}

		/// <summary>
		/// Int32 GetChars(Int32)
		/// </summary>
		protected RMethod r_RGetChars_Int32;
		public virtual RMethod RGetChars_Int32
		{
			get
			{
				if(r_RGetChars_Int32 == null)
				{
					r_RGetChars_Int32 = new(this, "GetChars", 0, typeof(System.Int32));
					r_RGetChars_Int32.SetBelong(this.instance);
				}
				return r_RGetChars_Int32;
			}
		}

		/// <summary>
		/// Void InvalidCharRecovery(Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RInvalidCharRecovery_Ref_Int32_Out_Int32;
		public virtual RMethod RInvalidCharRecovery_Ref_Int32_Out_Int32
		{
			get
			{
				if(r_RInvalidCharRecovery_Ref_Int32_Out_Int32 == null)
				{
					r_RInvalidCharRecovery_Ref_Int32_Out_Int32 = new(this, "InvalidCharRecovery", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RInvalidCharRecovery_Ref_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_RInvalidCharRecovery_Ref_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Void Close(Boolean)
		/// </summary>
		protected RMethod r_RClose_Boolean;
		public virtual RMethod RClose_Boolean
		{
			get
			{
				if(r_RClose_Boolean == null)
				{
					r_RClose_Boolean = new(this, "Close", 0, typeof(System.Boolean));
					r_RClose_Boolean.SetBelong(this.instance);
				}
				return r_RClose_Boolean;
			}
		}

		/// <summary>
		/// Void ShiftBuffer(Int32, Int32, Int32)
		/// </summary>
		protected RMethod r_RShiftBuffer_Int32_Int32_Int32;
		public virtual RMethod RShiftBuffer_Int32_Int32_Int32
		{
			get
			{
				if(r_RShiftBuffer_Int32_Int32_Int32 == null)
				{
					r_RShiftBuffer_Int32_Int32_Int32 = new(this, "ShiftBuffer", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32));
					r_RShiftBuffer_Int32_Int32_Int32.SetBelong(this.instance);
				}
				return r_RShiftBuffer_Int32_Int32_Int32;
			}
		}

		/// <summary>
		/// Boolean ParseXmlDeclaration(Boolean)
		/// </summary>
		protected RMethod r_RParseXmlDeclaration_Boolean;
		public virtual RMethod RParseXmlDeclaration_Boolean
		{
			get
			{
				if(r_RParseXmlDeclaration_Boolean == null)
				{
					r_RParseXmlDeclaration_Boolean = new(this, "ParseXmlDeclaration", 0, typeof(System.Boolean));
					r_RParseXmlDeclaration_Boolean.SetBelong(this.instance);
				}
				return r_RParseXmlDeclaration_Boolean;
			}
		}

		/// <summary>
		/// Boolean ParseDocumentContent()
		/// </summary>
		protected RMethod r_RParseDocumentContent;
		public virtual RMethod RParseDocumentContent
		{
			get
			{
				if(r_RParseDocumentContent == null)
				{
					r_RParseDocumentContent = new(this, "ParseDocumentContent", 0);
					r_RParseDocumentContent.SetBelong(this.instance);
				}
				return r_RParseDocumentContent;
			}
		}

		/// <summary>
		/// Boolean ParseElementContent()
		/// </summary>
		protected RMethod r_RParseElementContent;
		public virtual RMethod RParseElementContent
		{
			get
			{
				if(r_RParseElementContent == null)
				{
					r_RParseElementContent = new(this, "ParseElementContent", 0);
					r_RParseElementContent.SetBelong(this.instance);
				}
				return r_RParseElementContent;
			}
		}

		/// <summary>
		/// Void ThrowUnclosedElements()
		/// </summary>
		protected RMethod r_RThrowUnclosedElements;
		public virtual RMethod RThrowUnclosedElements
		{
			get
			{
				if(r_RThrowUnclosedElements == null)
				{
					r_RThrowUnclosedElements = new(this, "ThrowUnclosedElements", 0);
					r_RThrowUnclosedElements.SetBelong(this.instance);
				}
				return r_RThrowUnclosedElements;
			}
		}

		/// <summary>
		/// Void ParseElement()
		/// </summary>
		protected RMethod r_RParseElement;
		public virtual RMethod RParseElement
		{
			get
			{
				if(r_RParseElement == null)
				{
					r_RParseElement = new(this, "ParseElement", 0);
					r_RParseElement.SetBelong(this.instance);
				}
				return r_RParseElement;
			}
		}

		/// <summary>
		/// Void AddDefaultAttributesAndNormalize()
		/// </summary>
		protected RMethod r_RAddDefaultAttributesAndNormalize;
		public virtual RMethod RAddDefaultAttributesAndNormalize
		{
			get
			{
				if(r_RAddDefaultAttributesAndNormalize == null)
				{
					r_RAddDefaultAttributesAndNormalize = new(this, "AddDefaultAttributesAndNormalize", 0);
					r_RAddDefaultAttributesAndNormalize.SetBelong(this.instance);
				}
				return r_RAddDefaultAttributesAndNormalize;
			}
		}

		/// <summary>
		/// Void ParseEndElement()
		/// </summary>
		protected RMethod r_RParseEndElement;
		public virtual RMethod RParseEndElement
		{
			get
			{
				if(r_RParseEndElement == null)
				{
					r_RParseEndElement = new(this, "ParseEndElement", 0);
					r_RParseEndElement.SetBelong(this.instance);
				}
				return r_RParseEndElement;
			}
		}

		/// <summary>
		/// Void ThrowTagMismatch(NodeData)
		/// </summary>
		protected RMethod r_RThrowTagMismatch_NodeData;
		public virtual RMethod RThrowTagMismatch_NodeData
		{
			get
			{
				if(r_RThrowTagMismatch_NodeData == null)
				{
					r_RThrowTagMismatch_NodeData = new(this, "ThrowTagMismatch", 0,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_RThrowTagMismatch_NodeData.SetBelong(this.instance);
				}
				return r_RThrowTagMismatch_NodeData;
			}
		}

		/// <summary>
		/// Void ParseAttributes()
		/// </summary>
		protected RMethod r_RParseAttributes;
		public virtual RMethod RParseAttributes
		{
			get
			{
				if(r_RParseAttributes == null)
				{
					r_RParseAttributes = new(this, "ParseAttributes", 0);
					r_RParseAttributes.SetBelong(this.instance);
				}
				return r_RParseAttributes;
			}
		}

		/// <summary>
		/// Void ElementNamespaceLookup()
		/// </summary>
		protected RMethod r_RElementNamespaceLookup;
		public virtual RMethod RElementNamespaceLookup
		{
			get
			{
				if(r_RElementNamespaceLookup == null)
				{
					r_RElementNamespaceLookup = new(this, "ElementNamespaceLookup", 0);
					r_RElementNamespaceLookup.SetBelong(this.instance);
				}
				return r_RElementNamespaceLookup;
			}
		}

		/// <summary>
		/// Void AttributeNamespaceLookup()
		/// </summary>
		protected RMethod r_RAttributeNamespaceLookup;
		public virtual RMethod RAttributeNamespaceLookup
		{
			get
			{
				if(r_RAttributeNamespaceLookup == null)
				{
					r_RAttributeNamespaceLookup = new(this, "AttributeNamespaceLookup", 0);
					r_RAttributeNamespaceLookup.SetBelong(this.instance);
				}
				return r_RAttributeNamespaceLookup;
			}
		}

		/// <summary>
		/// Void AttributeDuplCheck()
		/// </summary>
		protected RMethod r_RAttributeDuplCheck;
		public virtual RMethod RAttributeDuplCheck
		{
			get
			{
				if(r_RAttributeDuplCheck == null)
				{
					r_RAttributeDuplCheck = new(this, "AttributeDuplCheck", 0);
					r_RAttributeDuplCheck.SetBelong(this.instance);
				}
				return r_RAttributeDuplCheck;
			}
		}

		/// <summary>
		/// Void OnDefaultNamespaceDecl(NodeData)
		/// </summary>
		protected RMethod r_ROnDefaultNamespaceDecl_NodeData;
		public virtual RMethod ROnDefaultNamespaceDecl_NodeData
		{
			get
			{
				if(r_ROnDefaultNamespaceDecl_NodeData == null)
				{
					r_ROnDefaultNamespaceDecl_NodeData = new(this, "OnDefaultNamespaceDecl", 0,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_ROnDefaultNamespaceDecl_NodeData.SetBelong(this.instance);
				}
				return r_ROnDefaultNamespaceDecl_NodeData;
			}
		}

		/// <summary>
		/// Void OnNamespaceDecl(NodeData)
		/// </summary>
		protected RMethod r_ROnNamespaceDecl_NodeData;
		public virtual RMethod ROnNamespaceDecl_NodeData
		{
			get
			{
				if(r_ROnNamespaceDecl_NodeData == null)
				{
					r_ROnNamespaceDecl_NodeData = new(this, "OnNamespaceDecl", 0,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_ROnNamespaceDecl_NodeData.SetBelong(this.instance);
				}
				return r_ROnNamespaceDecl_NodeData;
			}
		}

		/// <summary>
		/// Void OnXmlReservedAttribute(NodeData)
		/// </summary>
		protected RMethod r_ROnXmlReservedAttribute_NodeData;
		public virtual RMethod ROnXmlReservedAttribute_NodeData
		{
			get
			{
				if(r_ROnXmlReservedAttribute_NodeData == null)
				{
					r_ROnXmlReservedAttribute_NodeData = new(this, "OnXmlReservedAttribute", 0,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_ROnXmlReservedAttribute_NodeData.SetBelong(this.instance);
				}
				return r_ROnXmlReservedAttribute_NodeData;
			}
		}

		/// <summary>
		/// Void ParseAttributeValueSlow(Int32, Char, NodeData)
		/// </summary>
		protected RMethod r_RParseAttributeValueSlow_Int32_Char_NodeData;
		public virtual RMethod RParseAttributeValueSlow_Int32_Char_NodeData
		{
			get
			{
				if(r_RParseAttributeValueSlow_Int32_Char_NodeData == null)
				{
					r_RParseAttributeValueSlow_Int32_Char_NodeData = new(this, "ParseAttributeValueSlow", 0, typeof(System.Int32), typeof(System.Char),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_RParseAttributeValueSlow_Int32_Char_NodeData.SetBelong(this.instance);
				}
				return r_RParseAttributeValueSlow_Int32_Char_NodeData;
			}
		}

		/// <summary>
		/// Void AddAttributeChunkToList(NodeData, NodeData, NodeData ByRef)
		/// </summary>
		protected RMethod r_RAddAttributeChunkToList_NodeData_NodeData_Ref_NodeData;
		public virtual RMethod RAddAttributeChunkToList_NodeData_NodeData_Ref_NodeData
		{
			get
			{
				if(r_RAddAttributeChunkToList_NodeData_NodeData_Ref_NodeData == null)
				{
					r_RAddAttributeChunkToList_NodeData_NodeData_Ref_NodeData = new(this, "AddAttributeChunkToList", 0,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData").MakeByRefType());
					r_RAddAttributeChunkToList_NodeData_NodeData_Ref_NodeData.SetBelong(this.instance);
				}
				return r_RAddAttributeChunkToList_NodeData_NodeData_Ref_NodeData;
			}
		}

		/// <summary>
		/// Boolean ParseText()
		/// </summary>
		protected RMethod r_RParseText;
		public virtual RMethod RParseText
		{
			get
			{
				if(r_RParseText == null)
				{
					r_RParseText = new(this, "ParseText", 0);
					r_RParseText.SetBelong(this.instance);
				}
				return r_RParseText;
			}
		}

		/// <summary>
		/// Boolean ParseText(Int32 ByRef, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RParseText_Out_Int32_Out_Int32_Ref_Int32;
		public virtual RMethod RParseText_Out_Int32_Out_Int32_Ref_Int32
		{
			get
			{
				if(r_RParseText_Out_Int32_Out_Int32_Ref_Int32 == null)
				{
					r_RParseText_Out_Int32_Out_Int32_Ref_Int32 = new(this, "ParseText", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RParseText_Out_Int32_Out_Int32_Ref_Int32.SetBelong(this.instance);
				}
				return r_RParseText_Out_Int32_Out_Int32_Ref_Int32;
			}
		}

		/// <summary>
		/// Void FinishPartialValue()
		/// </summary>
		protected RMethod r_RFinishPartialValue;
		public virtual RMethod RFinishPartialValue
		{
			get
			{
				if(r_RFinishPartialValue == null)
				{
					r_RFinishPartialValue = new(this, "FinishPartialValue", 0);
					r_RFinishPartialValue.SetBelong(this.instance);
				}
				return r_RFinishPartialValue;
			}
		}

		/// <summary>
		/// Void FinishOtherValueIterator()
		/// </summary>
		protected RMethod r_RFinishOtherValueIterator;
		public virtual RMethod RFinishOtherValueIterator
		{
			get
			{
				if(r_RFinishOtherValueIterator == null)
				{
					r_RFinishOtherValueIterator = new(this, "FinishOtherValueIterator", 0);
					r_RFinishOtherValueIterator.SetBelong(this.instance);
				}
				return r_RFinishOtherValueIterator;
			}
		}

		/// <summary>
		/// Void SkipPartialTextValue()
		/// </summary>
		protected RMethod r_RSkipPartialTextValue;
		public virtual RMethod RSkipPartialTextValue
		{
			get
			{
				if(r_RSkipPartialTextValue == null)
				{
					r_RSkipPartialTextValue = new(this, "SkipPartialTextValue", 0);
					r_RSkipPartialTextValue.SetBelong(this.instance);
				}
				return r_RSkipPartialTextValue;
			}
		}

		/// <summary>
		/// Void FinishReadValueChunk()
		/// </summary>
		protected RMethod r_RFinishReadValueChunk;
		public virtual RMethod RFinishReadValueChunk
		{
			get
			{
				if(r_RFinishReadValueChunk == null)
				{
					r_RFinishReadValueChunk = new(this, "FinishReadValueChunk", 0);
					r_RFinishReadValueChunk.SetBelong(this.instance);
				}
				return r_RFinishReadValueChunk;
			}
		}

		/// <summary>
		/// Void FinishReadContentAsBinary()
		/// </summary>
		protected RMethod r_RFinishReadContentAsBinary;
		public virtual RMethod RFinishReadContentAsBinary
		{
			get
			{
				if(r_RFinishReadContentAsBinary == null)
				{
					r_RFinishReadContentAsBinary = new(this, "FinishReadContentAsBinary", 0);
					r_RFinishReadContentAsBinary.SetBelong(this.instance);
				}
				return r_RFinishReadContentAsBinary;
			}
		}

		/// <summary>
		/// Void FinishReadElementContentAsBinary()
		/// </summary>
		protected RMethod r_RFinishReadElementContentAsBinary;
		public virtual RMethod RFinishReadElementContentAsBinary
		{
			get
			{
				if(r_RFinishReadElementContentAsBinary == null)
				{
					r_RFinishReadElementContentAsBinary = new(this, "FinishReadElementContentAsBinary", 0);
					r_RFinishReadElementContentAsBinary.SetBelong(this.instance);
				}
				return r_RFinishReadElementContentAsBinary;
			}
		}

		/// <summary>
		/// Boolean ParseRootLevelWhitespace()
		/// </summary>
		protected RMethod r_RParseRootLevelWhitespace;
		public virtual RMethod RParseRootLevelWhitespace
		{
			get
			{
				if(r_RParseRootLevelWhitespace == null)
				{
					r_RParseRootLevelWhitespace = new(this, "ParseRootLevelWhitespace", 0);
					r_RParseRootLevelWhitespace.SetBelong(this.instance);
				}
				return r_RParseRootLevelWhitespace;
			}
		}

		/// <summary>
		/// Void ParseEntityReference()
		/// </summary>
		protected RMethod r_RParseEntityReference;
		public virtual RMethod RParseEntityReference
		{
			get
			{
				if(r_RParseEntityReference == null)
				{
					r_RParseEntityReference = new(this, "ParseEntityReference", 0);
					r_RParseEntityReference.SetBelong(this.instance);
				}
				return r_RParseEntityReference;
			}
		}

		/// <summary>
		/// EntityType HandleEntityReference(Boolean, EntityExpandType, Int32 ByRef)
		/// </summary>
		protected RMethod r_RHandleEntityReference_Boolean_EntityExpandType_Out_Int32;
		public virtual RMethod RHandleEntityReference_Boolean_EntityExpandType_Out_Int32
		{
			get
			{
				if(r_RHandleEntityReference_Boolean_EntityExpandType_Out_Int32 == null)
				{
					r_RHandleEntityReference_Boolean_EntityExpandType_Out_Int32 = new(this, "HandleEntityReference", 0, typeof(System.Boolean),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+EntityExpandType"), typeof(System.Int32).MakeByRefType());
					r_RHandleEntityReference_Boolean_EntityExpandType_Out_Int32.SetBelong(this.instance);
				}
				return r_RHandleEntityReference_Boolean_EntityExpandType_Out_Int32;
			}
		}

		/// <summary>
		/// EntityType HandleGeneralEntityReference(System.String, Boolean, Boolean, Int32)
		/// </summary>
		protected RMethod r_RHandleGeneralEntityReference_String_Boolean_Boolean_Int32;
		public virtual RMethod RHandleGeneralEntityReference_String_Boolean_Boolean_Int32
		{
			get
			{
				if(r_RHandleGeneralEntityReference_String_Boolean_Boolean_Int32 == null)
				{
					r_RHandleGeneralEntityReference_String_Boolean_Boolean_Int32 = new(this, "HandleGeneralEntityReference", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32));
					r_RHandleGeneralEntityReference_String_Boolean_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RHandleGeneralEntityReference_String_Boolean_Boolean_Int32;
			}
		}

		/// <summary>
		/// Boolean HandleEntityEnd(Boolean)
		/// </summary>
		protected RMethod r_RHandleEntityEnd_Boolean;
		public virtual RMethod RHandleEntityEnd_Boolean
		{
			get
			{
				if(r_RHandleEntityEnd_Boolean == null)
				{
					r_RHandleEntityEnd_Boolean = new(this, "HandleEntityEnd", 0, typeof(System.Boolean));
					r_RHandleEntityEnd_Boolean.SetBelong(this.instance);
				}
				return r_RHandleEntityEnd_Boolean;
			}
		}

		/// <summary>
		/// Void SetupEndEntityNodeInContent()
		/// </summary>
		protected RMethod r_RSetupEndEntityNodeInContent;
		public virtual RMethod RSetupEndEntityNodeInContent
		{
			get
			{
				if(r_RSetupEndEntityNodeInContent == null)
				{
					r_RSetupEndEntityNodeInContent = new(this, "SetupEndEntityNodeInContent", 0);
					r_RSetupEndEntityNodeInContent.SetBelong(this.instance);
				}
				return r_RSetupEndEntityNodeInContent;
			}
		}

		/// <summary>
		/// Void SetupEndEntityNodeInAttribute()
		/// </summary>
		protected RMethod r_RSetupEndEntityNodeInAttribute;
		public virtual RMethod RSetupEndEntityNodeInAttribute
		{
			get
			{
				if(r_RSetupEndEntityNodeInAttribute == null)
				{
					r_RSetupEndEntityNodeInAttribute = new(this, "SetupEndEntityNodeInAttribute", 0);
					r_RSetupEndEntityNodeInAttribute.SetBelong(this.instance);
				}
				return r_RSetupEndEntityNodeInAttribute;
			}
		}

		/// <summary>
		/// Boolean ParsePI()
		/// </summary>
		protected RMethod r_RParsePI;
		public virtual RMethod RParsePI
		{
			get
			{
				if(r_RParsePI == null)
				{
					r_RParsePI = new(this, "ParsePI", 0);
					r_RParsePI.SetBelong(this.instance);
				}
				return r_RParsePI;
			}
		}

		/// <summary>
		/// Boolean ParsePI(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RParsePI_StringBuilder;
		public virtual RMethod RParsePI_StringBuilder
		{
			get
			{
				if(r_RParsePI_StringBuilder == null)
				{
					r_RParsePI_StringBuilder = new(this, "ParsePI", 0, typeof(System.Text.StringBuilder));
					r_RParsePI_StringBuilder.SetBelong(this.instance);
				}
				return r_RParsePI_StringBuilder;
			}
		}

		/// <summary>
		/// Boolean ParsePIValue(Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RParsePIValue_Out_Int32_Out_Int32;
		public virtual RMethod RParsePIValue_Out_Int32_Out_Int32
		{
			get
			{
				if(r_RParsePIValue_Out_Int32_Out_Int32 == null)
				{
					r_RParsePIValue_Out_Int32_Out_Int32 = new(this, "ParsePIValue", 0, typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RParsePIValue_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_RParsePIValue_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean ParseComment()
		/// </summary>
		protected RMethod r_RParseComment;
		public virtual RMethod RParseComment
		{
			get
			{
				if(r_RParseComment == null)
				{
					r_RParseComment = new(this, "ParseComment", 0);
					r_RParseComment.SetBelong(this.instance);
				}
				return r_RParseComment;
			}
		}

		/// <summary>
		/// Void ParseCData()
		/// </summary>
		protected RMethod r_RParseCData;
		public virtual RMethod RParseCData
		{
			get
			{
				if(r_RParseCData == null)
				{
					r_RParseCData = new(this, "ParseCData", 0);
					r_RParseCData.SetBelong(this.instance);
				}
				return r_RParseCData;
			}
		}

		/// <summary>
		/// Void ParseCDataOrComment(System.Xml.XmlNodeType)
		/// </summary>
		protected RMethod r_RParseCDataOrComment_XmlNodeType;
		public virtual RMethod RParseCDataOrComment_XmlNodeType
		{
			get
			{
				if(r_RParseCDataOrComment_XmlNodeType == null)
				{
					r_RParseCDataOrComment_XmlNodeType = new(this, "ParseCDataOrComment", 0, typeof(System.Xml.XmlNodeType));
					r_RParseCDataOrComment_XmlNodeType.SetBelong(this.instance);
				}
				return r_RParseCDataOrComment_XmlNodeType;
			}
		}

		/// <summary>
		/// Boolean ParseCDataOrComment(System.Xml.XmlNodeType, Int32 ByRef, Int32 ByRef)
		/// </summary>
		protected RMethod r_RParseCDataOrComment_XmlNodeType_Out_Int32_Out_Int32;
		public virtual RMethod RParseCDataOrComment_XmlNodeType_Out_Int32_Out_Int32
		{
			get
			{
				if(r_RParseCDataOrComment_XmlNodeType_Out_Int32_Out_Int32 == null)
				{
					r_RParseCDataOrComment_XmlNodeType_Out_Int32_Out_Int32 = new(this, "ParseCDataOrComment", 0, typeof(System.Xml.XmlNodeType), typeof(System.Int32).MakeByRefType(), typeof(System.Int32).MakeByRefType());
					r_RParseCDataOrComment_XmlNodeType_Out_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_RParseCDataOrComment_XmlNodeType_Out_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean ParseDoctypeDecl()
		/// </summary>
		protected RMethod r_RParseDoctypeDecl;
		public virtual RMethod RParseDoctypeDecl
		{
			get
			{
				if(r_RParseDoctypeDecl == null)
				{
					r_RParseDoctypeDecl = new(this, "ParseDoctypeDecl", 0);
					r_RParseDoctypeDecl.SetBelong(this.instance);
				}
				return r_RParseDoctypeDecl;
			}
		}

		/// <summary>
		/// Void ParseDtd()
		/// </summary>
		protected RMethod r_RParseDtd;
		public virtual RMethod RParseDtd
		{
			get
			{
				if(r_RParseDtd == null)
				{
					r_RParseDtd = new(this, "ParseDtd", 0);
					r_RParseDtd.SetBelong(this.instance);
				}
				return r_RParseDtd;
			}
		}

		/// <summary>
		/// Void SkipDtd()
		/// </summary>
		protected RMethod r_RSkipDtd;
		public virtual RMethod RSkipDtd
		{
			get
			{
				if(r_RSkipDtd == null)
				{
					r_RSkipDtd = new(this, "SkipDtd", 0);
					r_RSkipDtd.SetBelong(this.instance);
				}
				return r_RSkipDtd;
			}
		}

		/// <summary>
		/// Void SkipPublicOrSystemIdLiteral()
		/// </summary>
		protected RMethod r_RSkipPublicOrSystemIdLiteral;
		public virtual RMethod RSkipPublicOrSystemIdLiteral
		{
			get
			{
				if(r_RSkipPublicOrSystemIdLiteral == null)
				{
					r_RSkipPublicOrSystemIdLiteral = new(this, "SkipPublicOrSystemIdLiteral", 0);
					r_RSkipPublicOrSystemIdLiteral.SetBelong(this.instance);
				}
				return r_RSkipPublicOrSystemIdLiteral;
			}
		}

		/// <summary>
		/// Void SkipUntil(Char, Boolean)
		/// </summary>
		protected RMethod r_RSkipUntil_Char_Boolean;
		public virtual RMethod RSkipUntil_Char_Boolean
		{
			get
			{
				if(r_RSkipUntil_Char_Boolean == null)
				{
					r_RSkipUntil_Char_Boolean = new(this, "SkipUntil", 0, typeof(System.Char), typeof(System.Boolean));
					r_RSkipUntil_Char_Boolean.SetBelong(this.instance);
				}
				return r_RSkipUntil_Char_Boolean;
			}
		}

		/// <summary>
		/// Int32 EatWhitespaces(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_REatWhitespaces_StringBuilder;
		public virtual RMethod REatWhitespaces_StringBuilder
		{
			get
			{
				if(r_REatWhitespaces_StringBuilder == null)
				{
					r_REatWhitespaces_StringBuilder = new(this, "EatWhitespaces", 0, typeof(System.Text.StringBuilder));
					r_REatWhitespaces_StringBuilder.SetBelong(this.instance);
				}
				return r_REatWhitespaces_StringBuilder;
			}
		}

		/// <summary>
		/// Int32 ParseCharRefInline(Int32, Int32 ByRef, EntityType ByRef)
		/// </summary>
		protected RMethod r_RParseCharRefInline_Int32_Out_Int32_Out_EntityType;
		public virtual RMethod RParseCharRefInline_Int32_Out_Int32_Out_EntityType
		{
			get
			{
				if(r_RParseCharRefInline_Int32_Out_Int32_Out_EntityType == null)
				{
					r_RParseCharRefInline_Int32_Out_Int32_Out_EntityType = new(this, "ParseCharRefInline", 0, typeof(System.Int32), typeof(System.Int32).MakeByRefType(),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+EntityType").MakeByRefType());
					r_RParseCharRefInline_Int32_Out_Int32_Out_EntityType.SetBelong(this.instance);
				}
				return r_RParseCharRefInline_Int32_Out_Int32_Out_EntityType;
			}
		}

		/// <summary>
		/// Int32 ParseNumericCharRef(Boolean, System.Text.StringBuilder, EntityType ByRef)
		/// </summary>
		protected RMethod r_RParseNumericCharRef_Boolean_StringBuilder_Out_EntityType;
		public virtual RMethod RParseNumericCharRef_Boolean_StringBuilder_Out_EntityType
		{
			get
			{
				if(r_RParseNumericCharRef_Boolean_StringBuilder_Out_EntityType == null)
				{
					r_RParseNumericCharRef_Boolean_StringBuilder_Out_EntityType = new(this, "ParseNumericCharRef", 0, typeof(System.Boolean), typeof(System.Text.StringBuilder),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+EntityType").MakeByRefType());
					r_RParseNumericCharRef_Boolean_StringBuilder_Out_EntityType.SetBelong(this.instance);
				}
				return r_RParseNumericCharRef_Boolean_StringBuilder_Out_EntityType;
			}
		}

		/// <summary>
		/// Int32 ParseNumericCharRefInline(Int32, Boolean, System.Text.StringBuilder, Int32 ByRef, EntityType ByRef)
		/// </summary>
		protected RMethod r_RParseNumericCharRefInline_Int32_Boolean_StringBuilder_Out_Int32_Out_EntityType;
		public virtual RMethod RParseNumericCharRefInline_Int32_Boolean_StringBuilder_Out_Int32_Out_EntityType
		{
			get
			{
				if(r_RParseNumericCharRefInline_Int32_Boolean_StringBuilder_Out_Int32_Out_EntityType == null)
				{
					r_RParseNumericCharRefInline_Int32_Boolean_StringBuilder_Out_Int32_Out_EntityType = new(this, "ParseNumericCharRefInline", 0, typeof(System.Int32), typeof(System.Boolean), typeof(System.Text.StringBuilder), typeof(System.Int32).MakeByRefType(),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+EntityType").MakeByRefType());
					r_RParseNumericCharRefInline_Int32_Boolean_StringBuilder_Out_Int32_Out_EntityType.SetBelong(this.instance);
				}
				return r_RParseNumericCharRefInline_Int32_Boolean_StringBuilder_Out_Int32_Out_EntityType;
			}
		}

		/// <summary>
		/// Int32 ParseNamedCharRef(Boolean, System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RParseNamedCharRef_Boolean_StringBuilder;
		public virtual RMethod RParseNamedCharRef_Boolean_StringBuilder
		{
			get
			{
				if(r_RParseNamedCharRef_Boolean_StringBuilder == null)
				{
					r_RParseNamedCharRef_Boolean_StringBuilder = new(this, "ParseNamedCharRef", 0, typeof(System.Boolean), typeof(System.Text.StringBuilder));
					r_RParseNamedCharRef_Boolean_StringBuilder.SetBelong(this.instance);
				}
				return r_RParseNamedCharRef_Boolean_StringBuilder;
			}
		}

		/// <summary>
		/// Int32 ParseNamedCharRefInline(Int32, Boolean, System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RParseNamedCharRefInline_Int32_Boolean_StringBuilder;
		public virtual RMethod RParseNamedCharRefInline_Int32_Boolean_StringBuilder
		{
			get
			{
				if(r_RParseNamedCharRefInline_Int32_Boolean_StringBuilder == null)
				{
					r_RParseNamedCharRefInline_Int32_Boolean_StringBuilder = new(this, "ParseNamedCharRefInline", 0, typeof(System.Int32), typeof(System.Boolean), typeof(System.Text.StringBuilder));
					r_RParseNamedCharRefInline_Int32_Boolean_StringBuilder.SetBelong(this.instance);
				}
				return r_RParseNamedCharRefInline_Int32_Boolean_StringBuilder;
			}
		}

		/// <summary>
		/// Int32 ParseName()
		/// </summary>
		protected RMethod r_RParseName;
		public virtual RMethod RParseName
		{
			get
			{
				if(r_RParseName == null)
				{
					r_RParseName = new(this, "ParseName", 0);
					r_RParseName.SetBelong(this.instance);
				}
				return r_RParseName;
			}
		}

		/// <summary>
		/// Int32 ParseQName(Int32 ByRef)
		/// </summary>
		protected RMethod r_RParseQName_Out_Int32;
		public virtual RMethod RParseQName_Out_Int32
		{
			get
			{
				if(r_RParseQName_Out_Int32 == null)
				{
					r_RParseQName_Out_Int32 = new(this, "ParseQName", 0, typeof(System.Int32).MakeByRefType());
					r_RParseQName_Out_Int32.SetBelong(this.instance);
				}
				return r_RParseQName_Out_Int32;
			}
		}

		/// <summary>
		/// Int32 ParseQName(Boolean, Int32, Int32 ByRef)
		/// </summary>
		protected RMethod r_RParseQName_Boolean_Int32_Out_Int32;
		public virtual RMethod RParseQName_Boolean_Int32_Out_Int32
		{
			get
			{
				if(r_RParseQName_Boolean_Int32_Out_Int32 == null)
				{
					r_RParseQName_Boolean_Int32_Out_Int32 = new(this, "ParseQName", 0, typeof(System.Boolean), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RParseQName_Boolean_Int32_Out_Int32.SetBelong(this.instance);
				}
				return r_RParseQName_Boolean_Int32_Out_Int32;
			}
		}

		/// <summary>
		/// Boolean ReadDataInName(Int32 ByRef)
		/// </summary>
		protected RMethod r_RReadDataInName_Ref_Int32;
		public virtual RMethod RReadDataInName_Ref_Int32
		{
			get
			{
				if(r_RReadDataInName_Ref_Int32 == null)
				{
					r_RReadDataInName_Ref_Int32 = new(this, "ReadDataInName", 0, typeof(System.Int32).MakeByRefType());
					r_RReadDataInName_Ref_Int32.SetBelong(this.instance);
				}
				return r_RReadDataInName_Ref_Int32;
			}
		}

		/// <summary>
		/// System.String ParseEntityName()
		/// </summary>
		protected RMethod r_RParseEntityName;
		public virtual RMethod RParseEntityName
		{
			get
			{
				if(r_RParseEntityName == null)
				{
					r_RParseEntityName = new(this, "ParseEntityName", 0);
					r_RParseEntityName.SetBelong(this.instance);
				}
				return r_RParseEntityName;
			}
		}

		/// <summary>
		/// NodeData AddNode(Int32, Int32)
		/// </summary>
		protected RMethod r_RAddNode_Int32_Int32;
		public virtual RMethod RAddNode_Int32_Int32
		{
			get
			{
				if(r_RAddNode_Int32_Int32 == null)
				{
					r_RAddNode_Int32_Int32 = new(this, "AddNode", 0, typeof(System.Int32), typeof(System.Int32));
					r_RAddNode_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAddNode_Int32_Int32;
			}
		}

		/// <summary>
		/// NodeData AllocNode(Int32, Int32)
		/// </summary>
		protected RMethod r_RAllocNode_Int32_Int32;
		public virtual RMethod RAllocNode_Int32_Int32
		{
			get
			{
				if(r_RAllocNode_Int32_Int32 == null)
				{
					r_RAllocNode_Int32_Int32 = new(this, "AllocNode", 0, typeof(System.Int32), typeof(System.Int32));
					r_RAllocNode_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAllocNode_Int32_Int32;
			}
		}

		/// <summary>
		/// NodeData AddAttributeNoChecks(System.String, Int32)
		/// </summary>
		protected RMethod r_RAddAttributeNoChecks_String_Int32;
		public virtual RMethod RAddAttributeNoChecks_String_Int32
		{
			get
			{
				if(r_RAddAttributeNoChecks_String_Int32 == null)
				{
					r_RAddAttributeNoChecks_String_Int32 = new(this, "AddAttributeNoChecks", 0, typeof(System.String), typeof(System.Int32));
					r_RAddAttributeNoChecks_String_Int32.SetBelong(this.instance);
				}
				return r_RAddAttributeNoChecks_String_Int32;
			}
		}

		/// <summary>
		/// NodeData AddAttribute(Int32, Int32)
		/// </summary>
		protected RMethod r_RAddAttribute_Int32_Int32;
		public virtual RMethod RAddAttribute_Int32_Int32
		{
			get
			{
				if(r_RAddAttribute_Int32_Int32 == null)
				{
					r_RAddAttribute_Int32_Int32 = new(this, "AddAttribute", 0, typeof(System.Int32), typeof(System.Int32));
					r_RAddAttribute_Int32_Int32.SetBelong(this.instance);
				}
				return r_RAddAttribute_Int32_Int32;
			}
		}

		/// <summary>
		/// NodeData AddAttribute(System.String, System.String, System.String)
		/// </summary>
		protected RMethod r_RAddAttribute_String_String_String;
		public virtual RMethod RAddAttribute_String_String_String
		{
			get
			{
				if(r_RAddAttribute_String_String_String == null)
				{
					r_RAddAttribute_String_String_String = new(this, "AddAttribute", 0, typeof(System.String), typeof(System.String), typeof(System.String));
					r_RAddAttribute_String_String_String.SetBelong(this.instance);
				}
				return r_RAddAttribute_String_String_String;
			}
		}

		/// <summary>
		/// Void PopElementContext()
		/// </summary>
		protected RMethod r_RPopElementContext;
		public virtual RMethod RPopElementContext
		{
			get
			{
				if(r_RPopElementContext == null)
				{
					r_RPopElementContext = new(this, "PopElementContext", 0);
					r_RPopElementContext.SetBelong(this.instance);
				}
				return r_RPopElementContext;
			}
		}

		/// <summary>
		/// Void OnNewLine(Int32)
		/// </summary>
		protected RMethod r_ROnNewLine_Int32;
		public virtual RMethod ROnNewLine_Int32
		{
			get
			{
				if(r_ROnNewLine_Int32 == null)
				{
					r_ROnNewLine_Int32 = new(this, "OnNewLine", 0, typeof(System.Int32));
					r_ROnNewLine_Int32.SetBelong(this.instance);
				}
				return r_ROnNewLine_Int32;
			}
		}

		/// <summary>
		/// Void OnEof()
		/// </summary>
		protected RMethod r_ROnEof;
		public virtual RMethod ROnEof
		{
			get
			{
				if(r_ROnEof == null)
				{
					r_ROnEof = new(this, "OnEof", 0);
					r_ROnEof.SetBelong(this.instance);
				}
				return r_ROnEof;
			}
		}

		/// <summary>
		/// System.String LookupNamespace(NodeData)
		/// </summary>
		protected RMethod r_RLookupNamespace_NodeData;
		public virtual RMethod RLookupNamespace_NodeData
		{
			get
			{
				if(r_RLookupNamespace_NodeData == null)
				{
					r_RLookupNamespace_NodeData = new(this, "LookupNamespace", 0,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_RLookupNamespace_NodeData.SetBelong(this.instance);
				}
				return r_RLookupNamespace_NodeData;
			}
		}

		/// <summary>
		/// Void AddNamespace(System.String, System.String, NodeData)
		/// </summary>
		protected RMethod r_RAddNamespace_String_String_NodeData;
		public virtual RMethod RAddNamespace_String_String_NodeData
		{
			get
			{
				if(r_RAddNamespace_String_String_NodeData == null)
				{
					r_RAddNamespace_String_String_NodeData = new(this, "AddNamespace", 0, typeof(System.String), typeof(System.String),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_RAddNamespace_String_String_NodeData.SetBelong(this.instance);
				}
				return r_RAddNamespace_String_String_NodeData;
			}
		}

		/// <summary>
		/// Void ResetAttributes()
		/// </summary>
		protected RMethod r_RResetAttributes;
		public virtual RMethod RResetAttributes
		{
			get
			{
				if(r_RResetAttributes == null)
				{
					r_RResetAttributes = new(this, "ResetAttributes", 0);
					r_RResetAttributes.SetBelong(this.instance);
				}
				return r_RResetAttributes;
			}
		}

		/// <summary>
		/// Void FullAttributeCleanup()
		/// </summary>
		protected RMethod r_RFullAttributeCleanup;
		public virtual RMethod RFullAttributeCleanup
		{
			get
			{
				if(r_RFullAttributeCleanup == null)
				{
					r_RFullAttributeCleanup = new(this, "FullAttributeCleanup", 0);
					r_RFullAttributeCleanup.SetBelong(this.instance);
				}
				return r_RFullAttributeCleanup;
			}
		}

		/// <summary>
		/// Void PushXmlContext()
		/// </summary>
		protected RMethod r_RPushXmlContext;
		public virtual RMethod RPushXmlContext
		{
			get
			{
				if(r_RPushXmlContext == null)
				{
					r_RPushXmlContext = new(this, "PushXmlContext", 0);
					r_RPushXmlContext.SetBelong(this.instance);
				}
				return r_RPushXmlContext;
			}
		}

		/// <summary>
		/// Void PopXmlContext()
		/// </summary>
		protected RMethod r_RPopXmlContext;
		public virtual RMethod RPopXmlContext
		{
			get
			{
				if(r_RPopXmlContext == null)
				{
					r_RPopXmlContext = new(this, "PopXmlContext", 0);
					r_RPopXmlContext.SetBelong(this.instance);
				}
				return r_RPopXmlContext;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType GetWhitespaceType()
		/// </summary>
		protected RMethod r_RGetWhitespaceType;
		public virtual RMethod RGetWhitespaceType
		{
			get
			{
				if(r_RGetWhitespaceType == null)
				{
					r_RGetWhitespaceType = new(this, "GetWhitespaceType", 0);
					r_RGetWhitespaceType.SetBelong(this.instance);
				}
				return r_RGetWhitespaceType;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType GetTextNodeType(Int32)
		/// </summary>
		protected RMethod r_RGetTextNodeType_Int32;
		public virtual RMethod RGetTextNodeType_Int32
		{
			get
			{
				if(r_RGetTextNodeType_Int32 == null)
				{
					r_RGetTextNodeType_Int32 = new(this, "GetTextNodeType", 0, typeof(System.Int32));
					r_RGetTextNodeType_Int32.SetBelong(this.instance);
				}
				return r_RGetTextNodeType_Int32;
			}
		}

		/// <summary>
		/// Void PushExternalEntityOrSubset(System.String, System.String, System.Uri, System.String)
		/// </summary>
		protected RMethod r_RPushExternalEntityOrSubset_String_String_Uri_String;
		public virtual RMethod RPushExternalEntityOrSubset_String_String_Uri_String
		{
			get
			{
				if(r_RPushExternalEntityOrSubset_String_String_Uri_String == null)
				{
					r_RPushExternalEntityOrSubset_String_String_Uri_String = new(this, "PushExternalEntityOrSubset", 0, typeof(System.String), typeof(System.String), typeof(System.Uri), typeof(System.String));
					r_RPushExternalEntityOrSubset_String_String_Uri_String.SetBelong(this.instance);
				}
				return r_RPushExternalEntityOrSubset_String_String_Uri_String;
			}
		}

		/// <summary>
		/// Boolean OpenAndPush(System.Uri)
		/// </summary>
		protected RMethod r_ROpenAndPush_Uri;
		public virtual RMethod ROpenAndPush_Uri
		{
			get
			{
				if(r_ROpenAndPush_Uri == null)
				{
					r_ROpenAndPush_Uri = new(this, "OpenAndPush", 0, typeof(System.Uri));
					r_ROpenAndPush_Uri.SetBelong(this.instance);
				}
				return r_ROpenAndPush_Uri;
			}
		}

		/// <summary>
		/// Boolean PushExternalEntity(System.Xml.IDtdEntityInfo)
		/// </summary>
		protected RMethod r_RPushExternalEntity_IDtdEntityInfo;
		public virtual RMethod RPushExternalEntity_IDtdEntityInfo
		{
			get
			{
				if(r_RPushExternalEntity_IDtdEntityInfo == null)
				{
					r_RPushExternalEntity_IDtdEntityInfo = new(this, "PushExternalEntity", 0,  ReleactionUtils.GetType("System.Xml.IDtdEntityInfo"));
					r_RPushExternalEntity_IDtdEntityInfo.SetBelong(this.instance);
				}
				return r_RPushExternalEntity_IDtdEntityInfo;
			}
		}

		/// <summary>
		/// Void PushInternalEntity(System.Xml.IDtdEntityInfo)
		/// </summary>
		protected RMethod r_RPushInternalEntity_IDtdEntityInfo;
		public virtual RMethod RPushInternalEntity_IDtdEntityInfo
		{
			get
			{
				if(r_RPushInternalEntity_IDtdEntityInfo == null)
				{
					r_RPushInternalEntity_IDtdEntityInfo = new(this, "PushInternalEntity", 0,  ReleactionUtils.GetType("System.Xml.IDtdEntityInfo"));
					r_RPushInternalEntity_IDtdEntityInfo.SetBelong(this.instance);
				}
				return r_RPushInternalEntity_IDtdEntityInfo;
			}
		}

		/// <summary>
		/// Void PopEntity()
		/// </summary>
		protected RMethod r_RPopEntity;
		public virtual RMethod RPopEntity
		{
			get
			{
				if(r_RPopEntity == null)
				{
					r_RPopEntity = new(this, "PopEntity", 0);
					r_RPopEntity.SetBelong(this.instance);
				}
				return r_RPopEntity;
			}
		}

		/// <summary>
		/// Void RegisterEntity(System.Xml.IDtdEntityInfo)
		/// </summary>
		protected RMethod r_RRegisterEntity_IDtdEntityInfo;
		public virtual RMethod RRegisterEntity_IDtdEntityInfo
		{
			get
			{
				if(r_RRegisterEntity_IDtdEntityInfo == null)
				{
					r_RRegisterEntity_IDtdEntityInfo = new(this, "RegisterEntity", 0,  ReleactionUtils.GetType("System.Xml.IDtdEntityInfo"));
					r_RRegisterEntity_IDtdEntityInfo.SetBelong(this.instance);
				}
				return r_RRegisterEntity_IDtdEntityInfo;
			}
		}

		/// <summary>
		/// Void UnregisterEntity()
		/// </summary>
		protected RMethod r_RUnregisterEntity;
		public virtual RMethod RUnregisterEntity
		{
			get
			{
				if(r_RUnregisterEntity == null)
				{
					r_RUnregisterEntity = new(this, "UnregisterEntity", 0);
					r_RUnregisterEntity.SetBelong(this.instance);
				}
				return r_RUnregisterEntity;
			}
		}

		/// <summary>
		/// Void PushParsingState()
		/// </summary>
		protected RMethod r_RPushParsingState;
		public virtual RMethod RPushParsingState
		{
			get
			{
				if(r_RPushParsingState == null)
				{
					r_RPushParsingState = new(this, "PushParsingState", 0);
					r_RPushParsingState.SetBelong(this.instance);
				}
				return r_RPushParsingState;
			}
		}

		/// <summary>
		/// Void PopParsingState()
		/// </summary>
		protected RMethod r_RPopParsingState;
		public virtual RMethod RPopParsingState
		{
			get
			{
				if(r_RPopParsingState == null)
				{
					r_RPopParsingState = new(this, "PopParsingState", 0);
					r_RPopParsingState.SetBelong(this.instance);
				}
				return r_RPopParsingState;
			}
		}

		/// <summary>
		/// Void InitIncrementalRead(System.Xml.IncrementalReadDecoder)
		/// </summary>
		protected RMethod r_RInitIncrementalRead_IncrementalReadDecoder;
		public virtual RMethod RInitIncrementalRead_IncrementalReadDecoder
		{
			get
			{
				if(r_RInitIncrementalRead_IncrementalReadDecoder == null)
				{
					r_RInitIncrementalRead_IncrementalReadDecoder = new(this, "InitIncrementalRead", 0,  ReleactionUtils.GetType("System.Xml.IncrementalReadDecoder"));
					r_RInitIncrementalRead_IncrementalReadDecoder.SetBelong(this.instance);
				}
				return r_RInitIncrementalRead_IncrementalReadDecoder;
			}
		}

		/// <summary>
		/// Int32 IncrementalRead(System.Array, Int32, Int32)
		/// </summary>
		protected RMethod r_RIncrementalRead_Array_Int32_Int32;
		public virtual RMethod RIncrementalRead_Array_Int32_Int32
		{
			get
			{
				if(r_RIncrementalRead_Array_Int32_Int32 == null)
				{
					r_RIncrementalRead_Array_Int32_Int32 = new(this, "IncrementalRead", 0, typeof(System.Array), typeof(System.Int32), typeof(System.Int32));
					r_RIncrementalRead_Array_Int32_Int32.SetBelong(this.instance);
				}
				return r_RIncrementalRead_Array_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 IncrementalRead()
		/// </summary>
		protected RMethod r_RIncrementalRead;
		public virtual RMethod RIncrementalRead
		{
			get
			{
				if(r_RIncrementalRead == null)
				{
					r_RIncrementalRead = new(this, "IncrementalRead", 0);
					r_RIncrementalRead.SetBelong(this.instance);
				}
				return r_RIncrementalRead;
			}
		}

		/// <summary>
		/// Void FinishIncrementalRead()
		/// </summary>
		protected RMethod r_RFinishIncrementalRead;
		public virtual RMethod RFinishIncrementalRead
		{
			get
			{
				if(r_RFinishIncrementalRead == null)
				{
					r_RFinishIncrementalRead = new(this, "FinishIncrementalRead", 0);
					r_RFinishIncrementalRead.SetBelong(this.instance);
				}
				return r_RFinishIncrementalRead;
			}
		}

		/// <summary>
		/// Boolean ParseFragmentAttribute()
		/// </summary>
		protected RMethod r_RParseFragmentAttribute;
		public virtual RMethod RParseFragmentAttribute
		{
			get
			{
				if(r_RParseFragmentAttribute == null)
				{
					r_RParseFragmentAttribute = new(this, "ParseFragmentAttribute", 0);
					r_RParseFragmentAttribute.SetBelong(this.instance);
				}
				return r_RParseFragmentAttribute;
			}
		}

		/// <summary>
		/// Boolean ParseAttributeValueChunk()
		/// </summary>
		protected RMethod r_RParseAttributeValueChunk;
		public virtual RMethod RParseAttributeValueChunk
		{
			get
			{
				if(r_RParseAttributeValueChunk == null)
				{
					r_RParseAttributeValueChunk = new(this, "ParseAttributeValueChunk", 0);
					r_RParseAttributeValueChunk.SetBelong(this.instance);
				}
				return r_RParseAttributeValueChunk;
			}
		}

		/// <summary>
		/// Void ParseXmlDeclarationFragment()
		/// </summary>
		protected RMethod r_RParseXmlDeclarationFragment;
		public virtual RMethod RParseXmlDeclarationFragment
		{
			get
			{
				if(r_RParseXmlDeclarationFragment == null)
				{
					r_RParseXmlDeclarationFragment = new(this, "ParseXmlDeclarationFragment", 0);
					r_RParseXmlDeclarationFragment.SetBelong(this.instance);
				}
				return r_RParseXmlDeclarationFragment;
			}
		}

		/// <summary>
		/// Void ThrowUnexpectedToken(Int32, System.String)
		/// </summary>
		protected RMethod r_RThrowUnexpectedToken_Int32_String;
		public virtual RMethod RThrowUnexpectedToken_Int32_String
		{
			get
			{
				if(r_RThrowUnexpectedToken_Int32_String == null)
				{
					r_RThrowUnexpectedToken_Int32_String = new(this, "ThrowUnexpectedToken", 0, typeof(System.Int32), typeof(System.String));
					r_RThrowUnexpectedToken_Int32_String.SetBelong(this.instance);
				}
				return r_RThrowUnexpectedToken_Int32_String;
			}
		}

		/// <summary>
		/// Void ThrowUnexpectedToken(System.String)
		/// </summary>
		protected RMethod r_RThrowUnexpectedToken_String;
		public virtual RMethod RThrowUnexpectedToken_String
		{
			get
			{
				if(r_RThrowUnexpectedToken_String == null)
				{
					r_RThrowUnexpectedToken_String = new(this, "ThrowUnexpectedToken", 0, typeof(System.String));
					r_RThrowUnexpectedToken_String.SetBelong(this.instance);
				}
				return r_RThrowUnexpectedToken_String;
			}
		}

		/// <summary>
		/// Void ThrowUnexpectedToken(Int32, System.String, System.String)
		/// </summary>
		protected RMethod r_RThrowUnexpectedToken_Int32_String_String;
		public virtual RMethod RThrowUnexpectedToken_Int32_String_String
		{
			get
			{
				if(r_RThrowUnexpectedToken_Int32_String_String == null)
				{
					r_RThrowUnexpectedToken_Int32_String_String = new(this, "ThrowUnexpectedToken", 0, typeof(System.Int32), typeof(System.String), typeof(System.String));
					r_RThrowUnexpectedToken_Int32_String_String.SetBelong(this.instance);
				}
				return r_RThrowUnexpectedToken_Int32_String_String;
			}
		}

		/// <summary>
		/// Void ThrowUnexpectedToken(System.String, System.String)
		/// </summary>
		protected RMethod r_RThrowUnexpectedToken_String_String;
		public virtual RMethod RThrowUnexpectedToken_String_String
		{
			get
			{
				if(r_RThrowUnexpectedToken_String_String == null)
				{
					r_RThrowUnexpectedToken_String_String = new(this, "ThrowUnexpectedToken", 0, typeof(System.String), typeof(System.String));
					r_RThrowUnexpectedToken_String_String.SetBelong(this.instance);
				}
				return r_RThrowUnexpectedToken_String_String;
			}
		}

		/// <summary>
		/// System.String ParseUnexpectedToken(Int32)
		/// </summary>
		protected RMethod r_RParseUnexpectedToken_Int32;
		public virtual RMethod RParseUnexpectedToken_Int32
		{
			get
			{
				if(r_RParseUnexpectedToken_Int32 == null)
				{
					r_RParseUnexpectedToken_Int32 = new(this, "ParseUnexpectedToken", 0, typeof(System.Int32));
					r_RParseUnexpectedToken_Int32.SetBelong(this.instance);
				}
				return r_RParseUnexpectedToken_Int32;
			}
		}

		/// <summary>
		/// System.String ParseUnexpectedToken()
		/// </summary>
		protected RMethod r_RParseUnexpectedToken;
		public virtual RMethod RParseUnexpectedToken
		{
			get
			{
				if(r_RParseUnexpectedToken == null)
				{
					r_RParseUnexpectedToken = new(this, "ParseUnexpectedToken", 0);
					r_RParseUnexpectedToken.SetBelong(this.instance);
				}
				return r_RParseUnexpectedToken;
			}
		}

		/// <summary>
		/// Void ThrowExpectingWhitespace(Int32)
		/// </summary>
		protected RMethod r_RThrowExpectingWhitespace_Int32;
		public virtual RMethod RThrowExpectingWhitespace_Int32
		{
			get
			{
				if(r_RThrowExpectingWhitespace_Int32 == null)
				{
					r_RThrowExpectingWhitespace_Int32 = new(this, "ThrowExpectingWhitespace", 0, typeof(System.Int32));
					r_RThrowExpectingWhitespace_Int32.SetBelong(this.instance);
				}
				return r_RThrowExpectingWhitespace_Int32;
			}
		}

		/// <summary>
		/// Int32 GetIndexOfAttributeWithoutPrefix(System.String)
		/// </summary>
		protected RMethod r_RGetIndexOfAttributeWithoutPrefix_String;
		public virtual RMethod RGetIndexOfAttributeWithoutPrefix_String
		{
			get
			{
				if(r_RGetIndexOfAttributeWithoutPrefix_String == null)
				{
					r_RGetIndexOfAttributeWithoutPrefix_String = new(this, "GetIndexOfAttributeWithoutPrefix", 0, typeof(System.String));
					r_RGetIndexOfAttributeWithoutPrefix_String.SetBelong(this.instance);
				}
				return r_RGetIndexOfAttributeWithoutPrefix_String;
			}
		}

		/// <summary>
		/// Int32 GetIndexOfAttributeWithPrefix(System.String)
		/// </summary>
		protected RMethod r_RGetIndexOfAttributeWithPrefix_String;
		public virtual RMethod RGetIndexOfAttributeWithPrefix_String
		{
			get
			{
				if(r_RGetIndexOfAttributeWithPrefix_String == null)
				{
					r_RGetIndexOfAttributeWithPrefix_String = new(this, "GetIndexOfAttributeWithPrefix", 0, typeof(System.String));
					r_RGetIndexOfAttributeWithPrefix_String.SetBelong(this.instance);
				}
				return r_RGetIndexOfAttributeWithPrefix_String;
			}
		}

		/// <summary>
		/// Boolean ZeroEndingStream(Int32)
		/// </summary>
		protected RMethod r_RZeroEndingStream_Int32;
		public virtual RMethod RZeroEndingStream_Int32
		{
			get
			{
				if(r_RZeroEndingStream_Int32 == null)
				{
					r_RZeroEndingStream_Int32 = new(this, "ZeroEndingStream", 0, typeof(System.Int32));
					r_RZeroEndingStream_Int32.SetBelong(this.instance);
				}
				return r_RZeroEndingStream_Int32;
			}
		}

		/// <summary>
		/// Void ParseDtdFromParserContext()
		/// </summary>
		protected RMethod r_RParseDtdFromParserContext;
		public virtual RMethod RParseDtdFromParserContext
		{
			get
			{
				if(r_RParseDtdFromParserContext == null)
				{
					r_RParseDtdFromParserContext = new(this, "ParseDtdFromParserContext", 0);
					r_RParseDtdFromParserContext.SetBelong(this.instance);
				}
				return r_RParseDtdFromParserContext;
			}
		}

		/// <summary>
		/// Boolean InitReadContentAsBinary()
		/// </summary>
		protected RMethod r_RInitReadContentAsBinary;
		public virtual RMethod RInitReadContentAsBinary
		{
			get
			{
				if(r_RInitReadContentAsBinary == null)
				{
					r_RInitReadContentAsBinary = new(this, "InitReadContentAsBinary", 0);
					r_RInitReadContentAsBinary.SetBelong(this.instance);
				}
				return r_RInitReadContentAsBinary;
			}
		}

		/// <summary>
		/// Boolean InitReadElementContentAsBinary()
		/// </summary>
		protected RMethod r_RInitReadElementContentAsBinary;
		public virtual RMethod RInitReadElementContentAsBinary
		{
			get
			{
				if(r_RInitReadElementContentAsBinary == null)
				{
					r_RInitReadElementContentAsBinary = new(this, "InitReadElementContentAsBinary", 0);
					r_RInitReadElementContentAsBinary.SetBelong(this.instance);
				}
				return r_RInitReadElementContentAsBinary;
			}
		}

		/// <summary>
		/// Boolean MoveToNextContentNode(Boolean)
		/// </summary>
		protected RMethod r_RMoveToNextContentNode_Boolean;
		public virtual RMethod RMoveToNextContentNode_Boolean
		{
			get
			{
				if(r_RMoveToNextContentNode_Boolean == null)
				{
					r_RMoveToNextContentNode_Boolean = new(this, "MoveToNextContentNode", 0, typeof(System.Boolean));
					r_RMoveToNextContentNode_Boolean.SetBelong(this.instance);
				}
				return r_RMoveToNextContentNode_Boolean;
			}
		}

		/// <summary>
		/// Void SetupReadContentAsBinaryState(ParsingFunction)
		/// </summary>
		protected RMethod r_RSetupReadContentAsBinaryState_ParsingFunction;
		public virtual RMethod RSetupReadContentAsBinaryState_ParsingFunction
		{
			get
			{
				if(r_RSetupReadContentAsBinaryState_ParsingFunction == null)
				{
					r_RSetupReadContentAsBinaryState_ParsingFunction = new(this, "SetupReadContentAsBinaryState", 0,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+ParsingFunction"));
					r_RSetupReadContentAsBinaryState_ParsingFunction.SetBelong(this.instance);
				}
				return r_RSetupReadContentAsBinaryState_ParsingFunction;
			}
		}

		/// <summary>
		/// Void SetupFromParserContext(System.Xml.XmlParserContext, System.Xml.XmlReaderSettings)
		/// </summary>
		protected RMethod r_RSetupFromParserContext_XmlParserContext_XmlReaderSettings;
		public virtual RMethod RSetupFromParserContext_XmlParserContext_XmlReaderSettings
		{
			get
			{
				if(r_RSetupFromParserContext_XmlParserContext_XmlReaderSettings == null)
				{
					r_RSetupFromParserContext_XmlParserContext_XmlReaderSettings = new(this, "SetupFromParserContext", 0, typeof(System.Xml.XmlParserContext), typeof(System.Xml.XmlReaderSettings));
					r_RSetupFromParserContext_XmlParserContext_XmlReaderSettings.SetBelong(this.instance);
				}
				return r_RSetupFromParserContext_XmlParserContext_XmlReaderSettings;
			}
		}

		/// <summary>
		/// Void SetDtdInfo(System.Xml.IDtdInfo)
		/// </summary>
		protected RMethod r_RSetDtdInfo_IDtdInfo;
		public virtual RMethod RSetDtdInfo_IDtdInfo
		{
			get
			{
				if(r_RSetDtdInfo_IDtdInfo == null)
				{
					r_RSetDtdInfo_IDtdInfo = new(this, "SetDtdInfo", 0,  ReleactionUtils.GetType("System.Xml.IDtdInfo"));
					r_RSetDtdInfo_IDtdInfo.SetBelong(this.instance);
				}
				return r_RSetDtdInfo_IDtdInfo;
			}
		}

		/// <summary>
		/// Void ChangeCurrentNodeType(System.Xml.XmlNodeType)
		/// </summary>
		protected RMethod r_RChangeCurrentNodeType_XmlNodeType;
		public virtual RMethod RChangeCurrentNodeType_XmlNodeType
		{
			get
			{
				if(r_RChangeCurrentNodeType_XmlNodeType == null)
				{
					r_RChangeCurrentNodeType_XmlNodeType = new(this, "ChangeCurrentNodeType", 0, typeof(System.Xml.XmlNodeType));
					r_RChangeCurrentNodeType_XmlNodeType.SetBelong(this.instance);
				}
				return r_RChangeCurrentNodeType_XmlNodeType;
			}
		}

		/// <summary>
		/// System.Xml.XmlResolver GetResolver()
		/// </summary>
		protected RMethod r_RGetResolver;
		public virtual RMethod RGetResolver
		{
			get
			{
				if(r_RGetResolver == null)
				{
					r_RGetResolver = new(this, "GetResolver", 0);
					r_RGetResolver.SetBelong(this.instance);
				}
				return r_RGetResolver;
			}
		}

		/// <summary>
		/// Boolean AddDefaultAttributeDtd(System.Xml.IDtdDefaultAttributeInfo, Boolean, NodeData[])
		/// </summary>
		protected RMethod r_RAddDefaultAttributeDtd_IDtdDefaultAttributeInfo_Boolean_NodeDataArray;
		public virtual RMethod RAddDefaultAttributeDtd_IDtdDefaultAttributeInfo_Boolean_NodeDataArray
		{
			get
			{
				if(r_RAddDefaultAttributeDtd_IDtdDefaultAttributeInfo_Boolean_NodeDataArray == null)
				{
					r_RAddDefaultAttributeDtd_IDtdDefaultAttributeInfo_Boolean_NodeDataArray = new(this, "AddDefaultAttributeDtd", 0,  ReleactionUtils.GetType("System.Xml.IDtdDefaultAttributeInfo"), typeof(System.Boolean),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData").MakeArrayType());
					r_RAddDefaultAttributeDtd_IDtdDefaultAttributeInfo_Boolean_NodeDataArray.SetBelong(this.instance);
				}
				return r_RAddDefaultAttributeDtd_IDtdDefaultAttributeInfo_Boolean_NodeDataArray;
			}
		}

		/// <summary>
		/// Boolean AddDefaultAttributeNonDtd(System.Xml.Schema.SchemaAttDef)
		/// </summary>
		protected RMethod r_RAddDefaultAttributeNonDtd_SchemaAttDef;
		public virtual RMethod RAddDefaultAttributeNonDtd_SchemaAttDef
		{
			get
			{
				if(r_RAddDefaultAttributeNonDtd_SchemaAttDef == null)
				{
					r_RAddDefaultAttributeNonDtd_SchemaAttDef = new(this, "AddDefaultAttributeNonDtd", 0,  ReleactionUtils.GetType("System.Xml.Schema.SchemaAttDef"));
					r_RAddDefaultAttributeNonDtd_SchemaAttDef.SetBelong(this.instance);
				}
				return r_RAddDefaultAttributeNonDtd_SchemaAttDef;
			}
		}

		/// <summary>
		/// NodeData AddDefaultAttributeInternal(System.String, System.String, System.String, System.String, Int32, Int32, Int32, Int32, Boolean)
		/// </summary>
		protected RMethod r_RAddDefaultAttributeInternal_String_String_String_String_Int32_Int32_Int32_Int32_Boolean;
		public virtual RMethod RAddDefaultAttributeInternal_String_String_String_String_Int32_Int32_Int32_Int32_Boolean
		{
			get
			{
				if(r_RAddDefaultAttributeInternal_String_String_String_String_Int32_Int32_Int32_Int32_Boolean == null)
				{
					r_RAddDefaultAttributeInternal_String_String_String_String_Int32_Int32_Int32_Int32_Boolean = new(this, "AddDefaultAttributeInternal", 0, typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean));
					r_RAddDefaultAttributeInternal_String_String_String_String_Int32_Int32_Int32_Int32_Boolean.SetBelong(this.instance);
				}
				return r_RAddDefaultAttributeInternal_String_String_String_String_Int32_Int32_Int32_Int32_Boolean;
			}
		}

		/// <summary>
		/// Int32 ReadContentAsBinary(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBinary_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBinary_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBinary_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBinary_ByteArray_Int32_Int32 = new(this, "ReadContentAsBinary", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBinary_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBinary_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsBinary(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBinary_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBinary_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBinary_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBinary_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBinary", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBinary_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBinary_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void InitBase64Decoder()
		/// </summary>
		protected RMethod r_RInitBase64Decoder;
		public virtual RMethod RInitBase64Decoder
		{
			get
			{
				if(r_RInitBase64Decoder == null)
				{
					r_RInitBase64Decoder = new(this, "InitBase64Decoder", 0);
					r_RInitBase64Decoder.SetBelong(this.instance);
				}
				return r_RInitBase64Decoder;
			}
		}

		/// <summary>
		/// Void InitBinHexDecoder()
		/// </summary>
		protected RMethod r_RInitBinHexDecoder;
		public virtual RMethod RInitBinHexDecoder
		{
			get
			{
				if(r_RInitBinHexDecoder == null)
				{
					r_RInitBinHexDecoder = new(this, "InitBinHexDecoder", 0);
					r_RInitBinHexDecoder.SetBelong(this.instance);
				}
				return r_RInitBinHexDecoder;
			}
		}

		/// <summary>
		/// Boolean UriEqual(System.Uri, System.String, System.String, System.Xml.XmlResolver)
		/// </summary>
		protected RMethod r_RUriEqual_Uri_String_String_XmlResolver;
		public virtual RMethod RUriEqual_Uri_String_String_XmlResolver
		{
			get
			{
				if(r_RUriEqual_Uri_String_String_XmlResolver == null)
				{
					r_RUriEqual_Uri_String_String_XmlResolver = new(this, "UriEqual", 0, typeof(System.Uri), typeof(System.String), typeof(System.String), typeof(System.Xml.XmlResolver));
					r_RUriEqual_Uri_String_String_XmlResolver.SetBelong(this.instance);
				}
				return r_RUriEqual_Uri_String_String_XmlResolver;
			}
		}

		/// <summary>
		/// Void RegisterConsumedCharacters(Int64, Boolean)
		/// </summary>
		protected RMethod r_RRegisterConsumedCharacters_Int64_Boolean;
		public virtual RMethod RRegisterConsumedCharacters_Int64_Boolean
		{
			get
			{
				if(r_RRegisterConsumedCharacters_Int64_Boolean == null)
				{
					r_RRegisterConsumedCharacters_Int64_Boolean = new(this, "RegisterConsumedCharacters", 0, typeof(System.Int64), typeof(System.Boolean));
					r_RRegisterConsumedCharacters_Int64_Boolean.SetBelong(this.instance);
				}
				return r_RRegisterConsumedCharacters_Int64_Boolean;
			}
		}

		/// <summary>
		/// Void AdjustLineInfo(Char[], Int32, Int32, Boolean, System.Xml.LineInfo ByRef)
		/// </summary>
		protected static RMethod r_RAdjustLineInfo_CharArray_Int32_Int32_Boolean_Ref_LineInfo;
		public static RMethod RAdjustLineInfo_CharArray_Int32_Int32_Boolean_Ref_LineInfo
		{
			get
			{
				if(r_RAdjustLineInfo_CharArray_Int32_Int32_Boolean_Ref_LineInfo == null)
				{
					r_RAdjustLineInfo_CharArray_Int32_Int32_Boolean_Ref_LineInfo = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "AdjustLineInfo", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean),  ReleactionUtils.GetType("System.Xml.LineInfo").MakeByRefType());
					r_RAdjustLineInfo_CharArray_Int32_Int32_Boolean_Ref_LineInfo.SetBelong(null);
				}
				return r_RAdjustLineInfo_CharArray_Int32_Int32_Boolean_Ref_LineInfo;
			}
		}

		/// <summary>
		/// Void AdjustLineInfo(System.String, Int32, Int32, Boolean, System.Xml.LineInfo ByRef)
		/// </summary>
		protected static RMethod r_RAdjustLineInfo_String_Int32_Int32_Boolean_Ref_LineInfo;
		public static RMethod RAdjustLineInfo_String_Int32_Int32_Boolean_Ref_LineInfo
		{
			get
			{
				if(r_RAdjustLineInfo_String_Int32_Int32_Boolean_Ref_LineInfo == null)
				{
					r_RAdjustLineInfo_String_Int32_Int32_Boolean_Ref_LineInfo = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "AdjustLineInfo", 0, typeof(System.String), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean),  ReleactionUtils.GetType("System.Xml.LineInfo").MakeByRefType());
					r_RAdjustLineInfo_String_Int32_Int32_Boolean_Ref_LineInfo.SetBelong(null);
				}
				return r_RAdjustLineInfo_String_Int32_Int32_Boolean_Ref_LineInfo;
			}
		}

		/// <summary>
		/// Void AdjustLineInfo(Char*, Int32, Boolean, System.Xml.LineInfo ByRef)
		/// </summary>
		protected static RMethod r_RAdjustLineInfo_CharPointer_Int32_Boolean_Ref_LineInfo;
		public static RMethod RAdjustLineInfo_CharPointer_Int32_Boolean_Ref_LineInfo
		{
			get
			{
				if(r_RAdjustLineInfo_CharPointer_Int32_Boolean_Ref_LineInfo == null)
				{
					r_RAdjustLineInfo_CharPointer_Int32_Boolean_Ref_LineInfo = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "AdjustLineInfo", 0, typeof(System.Char).MakePointerType(), typeof(System.Int32), typeof(System.Boolean),  ReleactionUtils.GetType("System.Xml.LineInfo").MakeByRefType());
					r_RAdjustLineInfo_CharPointer_Int32_Boolean_Ref_LineInfo.SetBelong(null);
				}
				return r_RAdjustLineInfo_CharPointer_Int32_Boolean_Ref_LineInfo;
			}
		}

		/// <summary>
		/// System.String StripSpaces(System.String)
		/// </summary>
		protected static RMethod r_RStripSpaces_String;
		public static RMethod RStripSpaces_String
		{
			get
			{
				if(r_RStripSpaces_String == null)
				{
					r_RStripSpaces_String = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "StripSpaces", 0, typeof(System.String));
					r_RStripSpaces_String.SetBelong(null);
				}
				return r_RStripSpaces_String;
			}
		}

		/// <summary>
		/// Void StripSpaces(Char[], Int32, Int32 ByRef)
		/// </summary>
		protected static RMethod r_RStripSpaces_CharArray_Int32_Ref_Int32;
		public static RMethod RStripSpaces_CharArray_Int32_Ref_Int32
		{
			get
			{
				if(r_RStripSpaces_CharArray_Int32_Ref_Int32 == null)
				{
					r_RStripSpaces_CharArray_Int32_Ref_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "StripSpaces", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32).MakeByRefType());
					r_RStripSpaces_CharArray_Int32_Ref_Int32.SetBelong(null);
				}
				return r_RStripSpaces_CharArray_Int32_Ref_Int32;
			}
		}

		/// <summary>
		/// Void BlockCopyChars(Char[], Int32, Char[], Int32, Int32)
		/// </summary>
		protected static RMethod r_RBlockCopyChars_CharArray_Int32_CharArray_Int32_Int32;
		public static RMethod RBlockCopyChars_CharArray_Int32_CharArray_Int32_Int32
		{
			get
			{
				if(r_RBlockCopyChars_CharArray_Int32_CharArray_Int32_Int32 == null)
				{
					r_RBlockCopyChars_CharArray_Int32_CharArray_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "BlockCopyChars", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RBlockCopyChars_CharArray_Int32_CharArray_Int32_Int32.SetBelong(null);
				}
				return r_RBlockCopyChars_CharArray_Int32_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void BlockCopy(Byte[], Int32, Byte[], Int32, Int32)
		/// </summary>
		protected static RMethod r_RBlockCopy_ByteArray_Int32_ByteArray_Int32_Int32;
		public static RMethod RBlockCopy_ByteArray_Int32_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RBlockCopy_ByteArray_Int32_ByteArray_Int32_Int32 == null)
				{
					r_RBlockCopy_ByteArray_Int32_ByteArray_Int32_Int32 = new( ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl"), "BlockCopy", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RBlockCopy_ByteArray_Int32_ByteArray_Int32_Int32.SetBelong(null);
				}
				return r_RBlockCopy_ByteArray_Int32_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// Void CheckAsyncCall()
		/// </summary>
		protected RMethod r_RCheckAsyncCall;
		public virtual RMethod RCheckAsyncCall
		{
			get
			{
				if(r_RCheckAsyncCall == null)
				{
					r_RCheckAsyncCall = new(this, "CheckAsyncCall", 0);
					r_RCheckAsyncCall.SetBelong(this.instance);
				}
				return r_RCheckAsyncCall;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] GetValueAsync()
		/// </summary>
		protected RMethod r_RGetValueAsync;
		public virtual RMethod RGetValueAsync
		{
			get
			{
				if(r_RGetValueAsync == null)
				{
					r_RGetValueAsync = new(this, "GetValueAsync", 0);
					r_RGetValueAsync.SetBelong(this.instance);
				}
				return r_RGetValueAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] _GetValueAsync()
		/// </summary>
		protected RMethod r_R_GetValueAsync;
		public virtual RMethod R_GetValueAsync
		{
			get
			{
				if(r_R_GetValueAsync == null)
				{
					r_R_GetValueAsync = new(this, "_GetValueAsync", 0);
					r_R_GetValueAsync.SetBelong(this.instance);
				}
				return r_R_GetValueAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishInitAsync()
		/// </summary>
		protected RMethod r_RFinishInitAsync;
		public virtual RMethod RFinishInitAsync
		{
			get
			{
				if(r_RFinishInitAsync == null)
				{
					r_RFinishInitAsync = new(this, "FinishInitAsync", 0);
					r_RFinishInitAsync.SetBelong(this.instance);
				}
				return r_RFinishInitAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishInitUriStringAsync()
		/// </summary>
		protected RMethod r_RFinishInitUriStringAsync;
		public virtual RMethod RFinishInitUriStringAsync
		{
			get
			{
				if(r_RFinishInitUriStringAsync == null)
				{
					r_RFinishInitUriStringAsync = new(this, "FinishInitUriStringAsync", 0);
					r_RFinishInitUriStringAsync.SetBelong(this.instance);
				}
				return r_RFinishInitUriStringAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishInitStreamAsync()
		/// </summary>
		protected RMethod r_RFinishInitStreamAsync;
		public virtual RMethod RFinishInitStreamAsync
		{
			get
			{
				if(r_RFinishInitStreamAsync == null)
				{
					r_RFinishInitStreamAsync = new(this, "FinishInitStreamAsync", 0);
					r_RFinishInitStreamAsync.SetBelong(this.instance);
				}
				return r_RFinishInitStreamAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishInitTextReaderAsync()
		/// </summary>
		protected RMethod r_RFinishInitTextReaderAsync;
		public virtual RMethod RFinishInitTextReaderAsync
		{
			get
			{
				if(r_RFinishInitTextReaderAsync == null)
				{
					r_RFinishInitTextReaderAsync = new(this, "FinishInitTextReaderAsync", 0);
					r_RFinishInitTextReaderAsync.SetBelong(this.instance);
				}
				return r_RFinishInitTextReaderAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ReadAsync()
		/// </summary>
		protected RMethod r_RReadAsync;
		public virtual RMethod RReadAsync
		{
			get
			{
				if(r_RReadAsync == null)
				{
					r_RReadAsync = new(this, "ReadAsync", 0);
					r_RReadAsync.SetBelong(this.instance);
				}
				return r_RReadAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ReadAsync_SwitchToInteractiveXmlDecl()
		/// </summary>
		protected RMethod r_RReadAsync_SwitchToInteractiveXmlDecl;
		public virtual RMethod RReadAsync_SwitchToInteractiveXmlDecl
		{
			get
			{
				if(r_RReadAsync_SwitchToInteractiveXmlDecl == null)
				{
					r_RReadAsync_SwitchToInteractiveXmlDecl = new(this, "ReadAsync_SwitchToInteractiveXmlDecl", 0);
					r_RReadAsync_SwitchToInteractiveXmlDecl.SetBelong(this.instance);
				}
				return r_RReadAsync_SwitchToInteractiveXmlDecl;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] _ReadAsync_SwitchToInteractiveXmlDecl(System.Threading.Tasks.Task`1[System.Boolean])
		/// </summary>
		protected RMethod r_R_ReadAsync_SwitchToInteractiveXmlDecl_Task_d_Boolean_p_;
		public virtual RMethod R_ReadAsync_SwitchToInteractiveXmlDecl_Task_d_Boolean_p_
		{
			get
			{
				if(r_R_ReadAsync_SwitchToInteractiveXmlDecl_Task_d_Boolean_p_ == null)
				{
					r_R_ReadAsync_SwitchToInteractiveXmlDecl_Task_d_Boolean_p_ = new(this, "_ReadAsync_SwitchToInteractiveXmlDecl", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Boolean)));
					r_R_ReadAsync_SwitchToInteractiveXmlDecl_Task_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_R_ReadAsync_SwitchToInteractiveXmlDecl_Task_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ReadAsync_SwitchToInteractiveXmlDecl_Helper(Boolean)
		/// </summary>
		protected RMethod r_RReadAsync_SwitchToInteractiveXmlDecl_Helper_Boolean;
		public virtual RMethod RReadAsync_SwitchToInteractiveXmlDecl_Helper_Boolean
		{
			get
			{
				if(r_RReadAsync_SwitchToInteractiveXmlDecl_Helper_Boolean == null)
				{
					r_RReadAsync_SwitchToInteractiveXmlDecl_Helper_Boolean = new(this, "ReadAsync_SwitchToInteractiveXmlDecl_Helper", 0, typeof(System.Boolean));
					r_RReadAsync_SwitchToInteractiveXmlDecl_Helper_Boolean.SetBelong(this.instance);
				}
				return r_RReadAsync_SwitchToInteractiveXmlDecl_Helper_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task SkipAsync()
		/// </summary>
		protected RMethod r_RSkipAsync;
		public virtual RMethod RSkipAsync
		{
			get
			{
				if(r_RSkipAsync == null)
				{
					r_RSkipAsync = new(this, "SkipAsync", 0);
					r_RSkipAsync.SetBelong(this.instance);
				}
				return r_RSkipAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadContentAsBase64_AsyncHelper(System.Threading.Tasks.Task`1[System.Boolean], Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBase64_AsyncHelper_Task_d_Boolean_p__ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBase64_AsyncHelper_Task_d_Boolean_p__ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBase64_AsyncHelper_Task_d_Boolean_p__ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBase64_AsyncHelper_Task_d_Boolean_p__ByteArray_Int32_Int32 = new(this, "ReadContentAsBase64_AsyncHelper", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBase64_AsyncHelper_Task_d_Boolean_p__ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBase64_AsyncHelper_Task_d_Boolean_p__ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadContentAsBase64Async(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBase64Async_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBase64Async_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBase64Async_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBase64Async_ByteArray_Int32_Int32 = new(this, "ReadContentAsBase64Async", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBase64Async_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBase64Async_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadContentAsBinHexAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBinHexAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32 = new(this, "ReadContentAsBinHexAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBinHexAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadElementContentAsBase64Async_Helper(System.Threading.Tasks.Task`1[System.Boolean], Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBase64Async_Helper_Task_d_Boolean_p__ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBase64Async_Helper_Task_d_Boolean_p__ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBase64Async_Helper_Task_d_Boolean_p__ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBase64Async_Helper_Task_d_Boolean_p__ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBase64Async_Helper", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Boolean)), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBase64Async_Helper_Task_d_Boolean_p__ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBase64Async_Helper_Task_d_Boolean_p__ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadElementContentAsBase64Async(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBase64Async_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBase64Async", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBase64Async_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadElementContentAsBinHexAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBinHexAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadValueChunkAsync(Char[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadValueChunkAsync_CharArray_Int32_Int32;
		public virtual RMethod RReadValueChunkAsync_CharArray_Int32_Int32
		{
			get
			{
				if(r_RReadValueChunkAsync_CharArray_Int32_Int32 == null)
				{
					r_RReadValueChunkAsync_CharArray_Int32_Int32 = new(this, "ReadValueChunkAsync", 0, typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadValueChunkAsync_CharArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadValueChunkAsync_CharArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] DtdParserProxy_ReadDataAsync()
		/// </summary>
		protected RMethod r_RDtdParserProxy_ReadDataAsync;
		public virtual RMethod RDtdParserProxy_ReadDataAsync
		{
			get
			{
				if(r_RDtdParserProxy_ReadDataAsync == null)
				{
					r_RDtdParserProxy_ReadDataAsync = new(this, "DtdParserProxy_ReadDataAsync", 0);
					r_RDtdParserProxy_ReadDataAsync.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ReadDataAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] DtdParserProxy_ParseNumericCharRefAsync(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RDtdParserProxy_ParseNumericCharRefAsync_StringBuilder;
		public virtual RMethod RDtdParserProxy_ParseNumericCharRefAsync_StringBuilder
		{
			get
			{
				if(r_RDtdParserProxy_ParseNumericCharRefAsync_StringBuilder == null)
				{
					r_RDtdParserProxy_ParseNumericCharRefAsync_StringBuilder = new(this, "DtdParserProxy_ParseNumericCharRefAsync", 0, typeof(System.Text.StringBuilder));
					r_RDtdParserProxy_ParseNumericCharRefAsync_StringBuilder.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ParseNumericCharRefAsync_StringBuilder;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] DtdParserProxy_ParseNamedCharRefAsync(Boolean, System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RDtdParserProxy_ParseNamedCharRefAsync_Boolean_StringBuilder;
		public virtual RMethod RDtdParserProxy_ParseNamedCharRefAsync_Boolean_StringBuilder
		{
			get
			{
				if(r_RDtdParserProxy_ParseNamedCharRefAsync_Boolean_StringBuilder == null)
				{
					r_RDtdParserProxy_ParseNamedCharRefAsync_Boolean_StringBuilder = new(this, "DtdParserProxy_ParseNamedCharRefAsync", 0, typeof(System.Boolean), typeof(System.Text.StringBuilder));
					r_RDtdParserProxy_ParseNamedCharRefAsync_Boolean_StringBuilder.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ParseNamedCharRefAsync_Boolean_StringBuilder;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task DtdParserProxy_ParsePIAsync(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RDtdParserProxy_ParsePIAsync_StringBuilder;
		public virtual RMethod RDtdParserProxy_ParsePIAsync_StringBuilder
		{
			get
			{
				if(r_RDtdParserProxy_ParsePIAsync_StringBuilder == null)
				{
					r_RDtdParserProxy_ParsePIAsync_StringBuilder = new(this, "DtdParserProxy_ParsePIAsync", 0, typeof(System.Text.StringBuilder));
					r_RDtdParserProxy_ParsePIAsync_StringBuilder.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ParsePIAsync_StringBuilder;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task DtdParserProxy_ParseCommentAsync(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RDtdParserProxy_ParseCommentAsync_StringBuilder;
		public virtual RMethod RDtdParserProxy_ParseCommentAsync_StringBuilder
		{
			get
			{
				if(r_RDtdParserProxy_ParseCommentAsync_StringBuilder == null)
				{
					r_RDtdParserProxy_ParseCommentAsync_StringBuilder = new(this, "DtdParserProxy_ParseCommentAsync", 0, typeof(System.Text.StringBuilder));
					r_RDtdParserProxy_ParseCommentAsync_StringBuilder.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_ParseCommentAsync_StringBuilder;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`2[System.Int32,System.Boolean]] DtdParserProxy_PushEntityAsync(System.Xml.IDtdEntityInfo)
		/// </summary>
		protected RMethod r_RDtdParserProxy_PushEntityAsync_IDtdEntityInfo;
		public virtual RMethod RDtdParserProxy_PushEntityAsync_IDtdEntityInfo
		{
			get
			{
				if(r_RDtdParserProxy_PushEntityAsync_IDtdEntityInfo == null)
				{
					r_RDtdParserProxy_PushEntityAsync_IDtdEntityInfo = new(this, "DtdParserProxy_PushEntityAsync", 0,  ReleactionUtils.GetType("System.Xml.IDtdEntityInfo"));
					r_RDtdParserProxy_PushEntityAsync_IDtdEntityInfo.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_PushEntityAsync_IDtdEntityInfo;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] DtdParserProxy_PushExternalSubsetAsync(System.String, System.String)
		/// </summary>
		protected RMethod r_RDtdParserProxy_PushExternalSubsetAsync_String_String;
		public virtual RMethod RDtdParserProxy_PushExternalSubsetAsync_String_String
		{
			get
			{
				if(r_RDtdParserProxy_PushExternalSubsetAsync_String_String == null)
				{
					r_RDtdParserProxy_PushExternalSubsetAsync_String_String = new(this, "DtdParserProxy_PushExternalSubsetAsync", 0, typeof(System.String), typeof(System.String));
					r_RDtdParserProxy_PushExternalSubsetAsync_String_String.SetBelong(this.instance);
				}
				return r_RDtdParserProxy_PushExternalSubsetAsync_String_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InitStreamInputAsync(System.Uri, System.IO.Stream, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RInitStreamInputAsync_Uri_Stream_Encoding;
		public virtual RMethod RInitStreamInputAsync_Uri_Stream_Encoding
		{
			get
			{
				if(r_RInitStreamInputAsync_Uri_Stream_Encoding == null)
				{
					r_RInitStreamInputAsync_Uri_Stream_Encoding = new(this, "InitStreamInputAsync", 0, typeof(System.Uri), typeof(System.IO.Stream), typeof(System.Text.Encoding));
					r_RInitStreamInputAsync_Uri_Stream_Encoding.SetBelong(this.instance);
				}
				return r_RInitStreamInputAsync_Uri_Stream_Encoding;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InitStreamInputAsync(System.Uri, System.String, System.IO.Stream, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RInitStreamInputAsync_Uri_String_Stream_Encoding;
		public virtual RMethod RInitStreamInputAsync_Uri_String_Stream_Encoding
		{
			get
			{
				if(r_RInitStreamInputAsync_Uri_String_Stream_Encoding == null)
				{
					r_RInitStreamInputAsync_Uri_String_Stream_Encoding = new(this, "InitStreamInputAsync", 0, typeof(System.Uri), typeof(System.String), typeof(System.IO.Stream), typeof(System.Text.Encoding));
					r_RInitStreamInputAsync_Uri_String_Stream_Encoding.SetBelong(this.instance);
				}
				return r_RInitStreamInputAsync_Uri_String_Stream_Encoding;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InitStreamInputAsync(System.Uri, System.String, System.IO.Stream, Byte[], Int32, System.Text.Encoding)
		/// </summary>
		protected RMethod r_RInitStreamInputAsync_Uri_String_Stream_ByteArray_Int32_Encoding;
		public virtual RMethod RInitStreamInputAsync_Uri_String_Stream_ByteArray_Int32_Encoding
		{
			get
			{
				if(r_RInitStreamInputAsync_Uri_String_Stream_ByteArray_Int32_Encoding == null)
				{
					r_RInitStreamInputAsync_Uri_String_Stream_ByteArray_Int32_Encoding = new(this, "InitStreamInputAsync", 0, typeof(System.Uri), typeof(System.String), typeof(System.IO.Stream), typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Text.Encoding));
					r_RInitStreamInputAsync_Uri_String_Stream_ByteArray_Int32_Encoding.SetBelong(this.instance);
				}
				return r_RInitStreamInputAsync_Uri_String_Stream_ByteArray_Int32_Encoding;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InitTextReaderInputAsync(System.String, System.IO.TextReader)
		/// </summary>
		protected RMethod r_RInitTextReaderInputAsync_String_TextReader;
		public virtual RMethod RInitTextReaderInputAsync_String_TextReader
		{
			get
			{
				if(r_RInitTextReaderInputAsync_String_TextReader == null)
				{
					r_RInitTextReaderInputAsync_String_TextReader = new(this, "InitTextReaderInputAsync", 0, typeof(System.String), typeof(System.IO.TextReader));
					r_RInitTextReaderInputAsync_String_TextReader.SetBelong(this.instance);
				}
				return r_RInitTextReaderInputAsync_String_TextReader;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task InitTextReaderInputAsync(System.String, System.Uri, System.IO.TextReader)
		/// </summary>
		protected RMethod r_RInitTextReaderInputAsync_String_Uri_TextReader;
		public virtual RMethod RInitTextReaderInputAsync_String_Uri_TextReader
		{
			get
			{
				if(r_RInitTextReaderInputAsync_String_Uri_TextReader == null)
				{
					r_RInitTextReaderInputAsync_String_Uri_TextReader = new(this, "InitTextReaderInputAsync", 0, typeof(System.String), typeof(System.Uri), typeof(System.IO.TextReader));
					r_RInitTextReaderInputAsync_String_Uri_TextReader.SetBelong(this.instance);
				}
				return r_RInitTextReaderInputAsync_String_Uri_TextReader;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ProcessDtdFromParserContextAsync(System.Xml.XmlParserContext)
		/// </summary>
		protected RMethod r_RProcessDtdFromParserContextAsync_XmlParserContext;
		public virtual RMethod RProcessDtdFromParserContextAsync_XmlParserContext
		{
			get
			{
				if(r_RProcessDtdFromParserContextAsync_XmlParserContext == null)
				{
					r_RProcessDtdFromParserContextAsync_XmlParserContext = new(this, "ProcessDtdFromParserContextAsync", 0, typeof(System.Xml.XmlParserContext));
					r_RProcessDtdFromParserContextAsync_XmlParserContext.SetBelong(this.instance);
				}
				return r_RProcessDtdFromParserContextAsync_XmlParserContext;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task SwitchEncodingAsync(System.Text.Encoding)
		/// </summary>
		protected RMethod r_RSwitchEncodingAsync_Encoding;
		public virtual RMethod RSwitchEncodingAsync_Encoding
		{
			get
			{
				if(r_RSwitchEncodingAsync_Encoding == null)
				{
					r_RSwitchEncodingAsync_Encoding = new(this, "SwitchEncodingAsync", 0, typeof(System.Text.Encoding));
					r_RSwitchEncodingAsync_Encoding.SetBelong(this.instance);
				}
				return r_RSwitchEncodingAsync_Encoding;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task SwitchEncodingToUTF8Async()
		/// </summary>
		protected RMethod r_RSwitchEncodingToUTF8Async;
		public virtual RMethod RSwitchEncodingToUTF8Async
		{
			get
			{
				if(r_RSwitchEncodingToUTF8Async == null)
				{
					r_RSwitchEncodingToUTF8Async = new(this, "SwitchEncodingToUTF8Async", 0);
					r_RSwitchEncodingToUTF8Async.SetBelong(this.instance);
				}
				return r_RSwitchEncodingToUTF8Async;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadDataAsync()
		/// </summary>
		protected RMethod r_RReadDataAsync;
		public virtual RMethod RReadDataAsync
		{
			get
			{
				if(r_RReadDataAsync == null)
				{
					r_RReadDataAsync = new(this, "ReadDataAsync", 0);
					r_RReadDataAsync.SetBelong(this.instance);
				}
				return r_RReadDataAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseXmlDeclarationAsync(Boolean)
		/// </summary>
		protected RMethod r_RParseXmlDeclarationAsync_Boolean;
		public virtual RMethod RParseXmlDeclarationAsync_Boolean
		{
			get
			{
				if(r_RParseXmlDeclarationAsync_Boolean == null)
				{
					r_RParseXmlDeclarationAsync_Boolean = new(this, "ParseXmlDeclarationAsync", 0, typeof(System.Boolean));
					r_RParseXmlDeclarationAsync_Boolean.SetBelong(this.instance);
				}
				return r_RParseXmlDeclarationAsync_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseDocumentContentAsync()
		/// </summary>
		protected RMethod r_RParseDocumentContentAsync;
		public virtual RMethod RParseDocumentContentAsync
		{
			get
			{
				if(r_RParseDocumentContentAsync == null)
				{
					r_RParseDocumentContentAsync = new(this, "ParseDocumentContentAsync", 0);
					r_RParseDocumentContentAsync.SetBelong(this.instance);
				}
				return r_RParseDocumentContentAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseDocumentContentAsync_CData()
		/// </summary>
		protected RMethod r_RParseDocumentContentAsync_CData;
		public virtual RMethod RParseDocumentContentAsync_CData
		{
			get
			{
				if(r_RParseDocumentContentAsync_CData == null)
				{
					r_RParseDocumentContentAsync_CData = new(this, "ParseDocumentContentAsync_CData", 0);
					r_RParseDocumentContentAsync_CData.SetBelong(this.instance);
				}
				return r_RParseDocumentContentAsync_CData;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseDocumentContentAsync_ParseEntity()
		/// </summary>
		protected RMethod r_RParseDocumentContentAsync_ParseEntity;
		public virtual RMethod RParseDocumentContentAsync_ParseEntity
		{
			get
			{
				if(r_RParseDocumentContentAsync_ParseEntity == null)
				{
					r_RParseDocumentContentAsync_ParseEntity = new(this, "ParseDocumentContentAsync_ParseEntity", 0);
					r_RParseDocumentContentAsync_ParseEntity.SetBelong(this.instance);
				}
				return r_RParseDocumentContentAsync_ParseEntity;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseDocumentContentAsync_WhiteSpace()
		/// </summary>
		protected RMethod r_RParseDocumentContentAsync_WhiteSpace;
		public virtual RMethod RParseDocumentContentAsync_WhiteSpace
		{
			get
			{
				if(r_RParseDocumentContentAsync_WhiteSpace == null)
				{
					r_RParseDocumentContentAsync_WhiteSpace = new(this, "ParseDocumentContentAsync_WhiteSpace", 0);
					r_RParseDocumentContentAsync_WhiteSpace.SetBelong(this.instance);
				}
				return r_RParseDocumentContentAsync_WhiteSpace;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] _ParseDocumentContentAsync_WhiteSpace(System.Threading.Tasks.Task`1[System.Boolean])
		/// </summary>
		protected RMethod r_R_ParseDocumentContentAsync_WhiteSpace_Task_d_Boolean_p_;
		public virtual RMethod R_ParseDocumentContentAsync_WhiteSpace_Task_d_Boolean_p_
		{
			get
			{
				if(r_R_ParseDocumentContentAsync_WhiteSpace_Task_d_Boolean_p_ == null)
				{
					r_R_ParseDocumentContentAsync_WhiteSpace_Task_d_Boolean_p_ = new(this, "_ParseDocumentContentAsync_WhiteSpace", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Boolean)));
					r_R_ParseDocumentContentAsync_WhiteSpace_Task_d_Boolean_p_.SetBelong(this.instance);
				}
				return r_R_ParseDocumentContentAsync_WhiteSpace_Task_d_Boolean_p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseDocumentContentAsync_ReadData(Boolean)
		/// </summary>
		protected RMethod r_RParseDocumentContentAsync_ReadData_Boolean;
		public virtual RMethod RParseDocumentContentAsync_ReadData_Boolean
		{
			get
			{
				if(r_RParseDocumentContentAsync_ReadData_Boolean == null)
				{
					r_RParseDocumentContentAsync_ReadData_Boolean = new(this, "ParseDocumentContentAsync_ReadData", 0, typeof(System.Boolean));
					r_RParseDocumentContentAsync_ReadData_Boolean.SetBelong(this.instance);
				}
				return r_RParseDocumentContentAsync_ReadData_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseElementContentAsync()
		/// </summary>
		protected RMethod r_RParseElementContentAsync;
		public virtual RMethod RParseElementContentAsync
		{
			get
			{
				if(r_RParseElementContentAsync == null)
				{
					r_RParseElementContentAsync = new(this, "ParseElementContentAsync", 0);
					r_RParseElementContentAsync.SetBelong(this.instance);
				}
				return r_RParseElementContentAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseElementContent_ReadData()
		/// </summary>
		protected RMethod r_RParseElementContent_ReadData;
		public virtual RMethod RParseElementContent_ReadData
		{
			get
			{
				if(r_RParseElementContent_ReadData == null)
				{
					r_RParseElementContent_ReadData = new(this, "ParseElementContent_ReadData", 0);
					r_RParseElementContent_ReadData.SetBelong(this.instance);
				}
				return r_RParseElementContent_ReadData;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseElementAsync()
		/// </summary>
		protected RMethod r_RParseElementAsync;
		public virtual RMethod RParseElementAsync
		{
			get
			{
				if(r_RParseElementAsync == null)
				{
					r_RParseElementAsync = new(this, "ParseElementAsync", 0);
					r_RParseElementAsync.SetBelong(this.instance);
				}
				return r_RParseElementAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseElementAsync_ContinueWithSetElement(System.Threading.Tasks.Task`1[System.Tuple`2[System.Int32,System.Int32]])
		/// </summary>
		protected RMethod r_RParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_;
		public virtual RMethod RParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_
		{
			get
			{
				if(r_RParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_ == null)
				{
					r_RParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_ = new(this, "ParseElementAsync_ContinueWithSetElement", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Tuple<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32))));
					r_RParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_.SetBelong(this.instance);
				}
				return r_RParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task _ParseElementAsync_ContinueWithSetElement(System.Threading.Tasks.Task`1[System.Tuple`2[System.Int32,System.Int32]])
		/// </summary>
		protected RMethod r_R_ParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_;
		public virtual RMethod R_ParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_
		{
			get
			{
				if(r_R_ParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_ == null)
				{
					r_R_ParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_ = new(this, "_ParseElementAsync_ContinueWithSetElement", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Tuple<, >).MakeGenericType(typeof(System.Int32), typeof(System.Int32))));
					r_R_ParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_.SetBelong(this.instance);
				}
				return r_R_ParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseElementAsync_SetElement(Int32, Int32)
		/// </summary>
		protected RMethod r_RParseElementAsync_SetElement_Int32_Int32;
		public virtual RMethod RParseElementAsync_SetElement_Int32_Int32
		{
			get
			{
				if(r_RParseElementAsync_SetElement_Int32_Int32 == null)
				{
					r_RParseElementAsync_SetElement_Int32_Int32 = new(this, "ParseElementAsync_SetElement", 0, typeof(System.Int32), typeof(System.Int32));
					r_RParseElementAsync_SetElement_Int32_Int32.SetBelong(this.instance);
				}
				return r_RParseElementAsync_SetElement_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseElementAsync_NoAttributes()
		/// </summary>
		protected RMethod r_RParseElementAsync_NoAttributes;
		public virtual RMethod RParseElementAsync_NoAttributes
		{
			get
			{
				if(r_RParseElementAsync_NoAttributes == null)
				{
					r_RParseElementAsync_NoAttributes = new(this, "ParseElementAsync_NoAttributes", 0);
					r_RParseElementAsync_NoAttributes.SetBelong(this.instance);
				}
				return r_RParseElementAsync_NoAttributes;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseElementAsync_ReadData(Int32)
		/// </summary>
		protected RMethod r_RParseElementAsync_ReadData_Int32;
		public virtual RMethod RParseElementAsync_ReadData_Int32
		{
			get
			{
				if(r_RParseElementAsync_ReadData_Int32 == null)
				{
					r_RParseElementAsync_ReadData_Int32 = new(this, "ParseElementAsync_ReadData", 0, typeof(System.Int32));
					r_RParseElementAsync_ReadData_Int32.SetBelong(this.instance);
				}
				return r_RParseElementAsync_ReadData_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseEndElementAsync()
		/// </summary>
		protected RMethod r_RParseEndElementAsync;
		public virtual RMethod RParseEndElementAsync
		{
			get
			{
				if(r_RParseEndElementAsync == null)
				{
					r_RParseEndElementAsync = new(this, "ParseEndElementAsync", 0);
					r_RParseEndElementAsync.SetBelong(this.instance);
				}
				return r_RParseEndElementAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task _ParseEndElmentAsync()
		/// </summary>
		protected RMethod r_R_ParseEndElmentAsync;
		public virtual RMethod R_ParseEndElmentAsync
		{
			get
			{
				if(r_R_ParseEndElmentAsync == null)
				{
					r_R_ParseEndElmentAsync = new(this, "_ParseEndElmentAsync", 0);
					r_R_ParseEndElmentAsync.SetBelong(this.instance);
				}
				return r_R_ParseEndElmentAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseEndElmentAsync_PrepareData()
		/// </summary>
		protected RMethod r_RParseEndElmentAsync_PrepareData;
		public virtual RMethod RParseEndElmentAsync_PrepareData
		{
			get
			{
				if(r_RParseEndElmentAsync_PrepareData == null)
				{
					r_RParseEndElmentAsync_PrepareData = new(this, "ParseEndElmentAsync_PrepareData", 0);
					r_RParseEndElmentAsync_PrepareData.SetBelong(this.instance);
				}
				return r_RParseEndElmentAsync_PrepareData;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseEndElementAsync_CheckNameAndParse()
		/// </summary>
		protected RMethod r_RParseEndElementAsync_CheckNameAndParse;
		public virtual RMethod RParseEndElementAsync_CheckNameAndParse
		{
			get
			{
				if(r_RParseEndElementAsync_CheckNameAndParse == null)
				{
					r_RParseEndElementAsync_CheckNameAndParse = new(this, "ParseEndElementAsync_CheckNameAndParse", 0);
					r_RParseEndElementAsync_CheckNameAndParse.SetBelong(this.instance);
				}
				return r_RParseEndElementAsync_CheckNameAndParse;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseEndElementAsync_Finish(Int32, NodeData, System.Xml.LineInfo)
		/// </summary>
		protected RMethod r_RParseEndElementAsync_Finish_Int32_NodeData_LineInfo;
		public virtual RMethod RParseEndElementAsync_Finish_Int32_NodeData_LineInfo
		{
			get
			{
				if(r_RParseEndElementAsync_Finish_Int32_NodeData_LineInfo == null)
				{
					r_RParseEndElementAsync_Finish_Int32_NodeData_LineInfo = new(this, "ParseEndElementAsync_Finish", 0, typeof(System.Int32),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"),  ReleactionUtils.GetType("System.Xml.LineInfo"));
					r_RParseEndElementAsync_Finish_Int32_NodeData_LineInfo.SetBelong(this.instance);
				}
				return r_RParseEndElementAsync_Finish_Int32_NodeData_LineInfo;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseEndElementAsync_Finish(System.Threading.Tasks.Task, Int32, NodeData, System.Xml.LineInfo)
		/// </summary>
		protected RMethod r_RParseEndElementAsync_Finish_Task_Int32_NodeData_LineInfo;
		public virtual RMethod RParseEndElementAsync_Finish_Task_Int32_NodeData_LineInfo
		{
			get
			{
				if(r_RParseEndElementAsync_Finish_Task_Int32_NodeData_LineInfo == null)
				{
					r_RParseEndElementAsync_Finish_Task_Int32_NodeData_LineInfo = new(this, "ParseEndElementAsync_Finish", 0, typeof(System.Threading.Tasks.Task), typeof(System.Int32),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"),  ReleactionUtils.GetType("System.Xml.LineInfo"));
					r_RParseEndElementAsync_Finish_Task_Int32_NodeData_LineInfo.SetBelong(this.instance);
				}
				return r_RParseEndElementAsync_Finish_Task_Int32_NodeData_LineInfo;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseEndElementAsync_CheckEndTag(Int32, NodeData, System.Xml.LineInfo)
		/// </summary>
		protected RMethod r_RParseEndElementAsync_CheckEndTag_Int32_NodeData_LineInfo;
		public virtual RMethod RParseEndElementAsync_CheckEndTag_Int32_NodeData_LineInfo
		{
			get
			{
				if(r_RParseEndElementAsync_CheckEndTag_Int32_NodeData_LineInfo == null)
				{
					r_RParseEndElementAsync_CheckEndTag_Int32_NodeData_LineInfo = new(this, "ParseEndElementAsync_CheckEndTag", 0, typeof(System.Int32),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"),  ReleactionUtils.GetType("System.Xml.LineInfo"));
					r_RParseEndElementAsync_CheckEndTag_Int32_NodeData_LineInfo.SetBelong(this.instance);
				}
				return r_RParseEndElementAsync_CheckEndTag_Int32_NodeData_LineInfo;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseEndElementAsync_ReadData()
		/// </summary>
		protected RMethod r_RParseEndElementAsync_ReadData;
		public virtual RMethod RParseEndElementAsync_ReadData
		{
			get
			{
				if(r_RParseEndElementAsync_ReadData == null)
				{
					r_RParseEndElementAsync_ReadData = new(this, "ParseEndElementAsync_ReadData", 0);
					r_RParseEndElementAsync_ReadData.SetBelong(this.instance);
				}
				return r_RParseEndElementAsync_ReadData;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ThrowTagMismatchAsync(NodeData)
		/// </summary>
		protected RMethod r_RThrowTagMismatchAsync_NodeData;
		public virtual RMethod RThrowTagMismatchAsync_NodeData
		{
			get
			{
				if(r_RThrowTagMismatchAsync_NodeData == null)
				{
					r_RThrowTagMismatchAsync_NodeData = new(this, "ThrowTagMismatchAsync", 0,  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_RThrowTagMismatchAsync_NodeData.SetBelong(this.instance);
				}
				return r_RThrowTagMismatchAsync_NodeData;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseAttributesAsync()
		/// </summary>
		protected RMethod r_RParseAttributesAsync;
		public virtual RMethod RParseAttributesAsync
		{
			get
			{
				if(r_RParseAttributesAsync == null)
				{
					r_RParseAttributesAsync = new(this, "ParseAttributesAsync", 0);
					r_RParseAttributesAsync.SetBelong(this.instance);
				}
				return r_RParseAttributesAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseAttributeValueSlowAsync(Int32, Char, NodeData)
		/// </summary>
		protected RMethod r_RParseAttributeValueSlowAsync_Int32_Char_NodeData;
		public virtual RMethod RParseAttributeValueSlowAsync_Int32_Char_NodeData
		{
			get
			{
				if(r_RParseAttributeValueSlowAsync_Int32_Char_NodeData == null)
				{
					r_RParseAttributeValueSlowAsync_Int32_Char_NodeData = new(this, "ParseAttributeValueSlowAsync", 0, typeof(System.Int32), typeof(System.Char),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+NodeData"));
					r_RParseAttributeValueSlowAsync_Int32_Char_NodeData.SetBelong(this.instance);
				}
				return r_RParseAttributeValueSlowAsync_Int32_Char_NodeData;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseTextAsync()
		/// </summary>
		protected RMethod r_RParseTextAsync;
		public virtual RMethod RParseTextAsync
		{
			get
			{
				if(r_RParseTextAsync == null)
				{
					r_RParseTextAsync = new(this, "ParseTextAsync", 0);
					r_RParseTextAsync.SetBelong(this.instance);
				}
				return r_RParseTextAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] _ParseTextAsync(System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]])
		/// </summary>
		protected RMethod r_R_ParseTextAsync_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_;
		public virtual RMethod R_ParseTextAsync_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_
		{
			get
			{
				if(r_R_ParseTextAsync_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_ == null)
				{
					r_R_ParseTextAsync_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_ = new(this, "_ParseTextAsync", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Tuple<, , , >).MakeGenericType(typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean))));
					r_R_ParseTextAsync_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_.SetBelong(this.instance);
				}
				return r_R_ParseTextAsync_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseTextAsync_IgnoreNode()
		/// </summary>
		protected RMethod r_RParseTextAsync_IgnoreNode;
		public virtual RMethod RParseTextAsync_IgnoreNode
		{
			get
			{
				if(r_RParseTextAsync_IgnoreNode == null)
				{
					r_RParseTextAsync_IgnoreNode = new(this, "ParseTextAsync_IgnoreNode", 0);
					r_RParseTextAsync_IgnoreNode.SetBelong(this.instance);
				}
				return r_RParseTextAsync_IgnoreNode;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] ParseTextAsync(Int32)
		/// </summary>
		protected RMethod r_RParseTextAsync_Int32;
		public virtual RMethod RParseTextAsync_Int32
		{
			get
			{
				if(r_RParseTextAsync_Int32 == null)
				{
					r_RParseTextAsync_Int32 = new(this, "ParseTextAsync", 0, typeof(System.Int32));
					r_RParseTextAsync_Int32.SetBelong(this.instance);
				}
				return r_RParseTextAsync_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] ParseTextAsync_AsyncFunc(System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]])
		/// </summary>
		protected RMethod r_RParseTextAsync_AsyncFunc_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_;
		public virtual RMethod RParseTextAsync_AsyncFunc_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_
		{
			get
			{
				if(r_RParseTextAsync_AsyncFunc_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_ == null)
				{
					r_RParseTextAsync_AsyncFunc_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_ = new(this, "ParseTextAsync_AsyncFunc", 0, typeof(System.Threading.Tasks.Task<>).MakeGenericType(typeof(System.Tuple<, , , >).MakeGenericType(typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Boolean))));
					r_RParseTextAsync_AsyncFunc_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_.SetBelong(this.instance);
				}
				return r_RParseTextAsync_AsyncFunc_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] ParseTextAsync(Int32, Char[], Int32, Int32, Int32, Int32, Char)
		/// </summary>
		protected RMethod r_RParseTextAsync_Int32_CharArray_Int32_Int32_Int32_Int32_Char;
		public virtual RMethod RParseTextAsync_Int32_CharArray_Int32_Int32_Int32_Int32_Char
		{
			get
			{
				if(r_RParseTextAsync_Int32_CharArray_Int32_Int32_Int32_Int32_Char == null)
				{
					r_RParseTextAsync_Int32_CharArray_Int32_Int32_Int32_Int32_Char = new(this, "ParseTextAsync", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Char));
					r_RParseTextAsync_Int32_CharArray_Int32_Int32_Int32_Int32_Char.SetBelong(this.instance);
				}
				return r_RParseTextAsync_Int32_CharArray_Int32_Int32_Int32_Int32_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] ParseTextAsync_ParseEntity(Int32, Char[], Int32, Int32, Int32, Int32, Char)
		/// </summary>
		protected RMethod r_RParseTextAsync_ParseEntity_Int32_CharArray_Int32_Int32_Int32_Int32_Char;
		public virtual RMethod RParseTextAsync_ParseEntity_Int32_CharArray_Int32_Int32_Int32_Int32_Char
		{
			get
			{
				if(r_RParseTextAsync_ParseEntity_Int32_CharArray_Int32_Int32_Int32_Int32_Char == null)
				{
					r_RParseTextAsync_ParseEntity_Int32_CharArray_Int32_Int32_Int32_Int32_Char = new(this, "ParseTextAsync_ParseEntity", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Char));
					r_RParseTextAsync_ParseEntity_Int32_CharArray_Int32_Int32_Int32_Int32_Char.SetBelong(this.instance);
				}
				return r_RParseTextAsync_ParseEntity_Int32_CharArray_Int32_Int32_Int32_Int32_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] ParseTextAsync_Surrogate(Int32, Char[], Int32, Int32, Int32, Int32, Char)
		/// </summary>
		protected RMethod r_RParseTextAsync_Surrogate_Int32_CharArray_Int32_Int32_Int32_Int32_Char;
		public virtual RMethod RParseTextAsync_Surrogate_Int32_CharArray_Int32_Int32_Int32_Int32_Char
		{
			get
			{
				if(r_RParseTextAsync_Surrogate_Int32_CharArray_Int32_Int32_Int32_Int32_Char == null)
				{
					r_RParseTextAsync_Surrogate_Int32_CharArray_Int32_Int32_Int32_Int32_Char = new(this, "ParseTextAsync_Surrogate", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Char));
					r_RParseTextAsync_Surrogate_Int32_CharArray_Int32_Int32_Int32_Int32_Char.SetBelong(this.instance);
				}
				return r_RParseTextAsync_Surrogate_Int32_CharArray_Int32_Int32_Int32_Int32_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] ParseTextAsync_ReadData(Int32, Char[], Int32, Int32, Int32, Int32, Char)
		/// </summary>
		protected RMethod r_RParseTextAsync_ReadData_Int32_CharArray_Int32_Int32_Int32_Int32_Char;
		public virtual RMethod RParseTextAsync_ReadData_Int32_CharArray_Int32_Int32_Int32_Int32_Char
		{
			get
			{
				if(r_RParseTextAsync_ReadData_Int32_CharArray_Int32_Int32_Int32_Int32_Char == null)
				{
					r_RParseTextAsync_ReadData_Int32_CharArray_Int32_Int32_Int32_Int32_Char = new(this, "ParseTextAsync_ReadData", 0, typeof(System.Int32), typeof(System.Char).MakeArrayType(), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Char));
					r_RParseTextAsync_ReadData_Int32_CharArray_Int32_Int32_Int32_Int32_Char.SetBelong(this.instance);
				}
				return r_RParseTextAsync_ReadData_Int32_CharArray_Int32_Int32_Int32_Int32_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] ParseTextAsync_NoValue(Int32, Int32)
		/// </summary>
		protected RMethod r_RParseTextAsync_NoValue_Int32_Int32;
		public virtual RMethod RParseTextAsync_NoValue_Int32_Int32
		{
			get
			{
				if(r_RParseTextAsync_NoValue_Int32_Int32 == null)
				{
					r_RParseTextAsync_NoValue_Int32_Int32 = new(this, "ParseTextAsync_NoValue", 0, typeof(System.Int32), typeof(System.Int32));
					r_RParseTextAsync_NoValue_Int32_Int32.SetBelong(this.instance);
				}
				return r_RParseTextAsync_NoValue_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`4[System.Int32,System.Int32,System.Int32,System.Boolean]] ParseTextAsync_PartialValue(Int32, Int32, Int32, Int32, Char)
		/// </summary>
		protected RMethod r_RParseTextAsync_PartialValue_Int32_Int32_Int32_Int32_Char;
		public virtual RMethod RParseTextAsync_PartialValue_Int32_Int32_Int32_Int32_Char
		{
			get
			{
				if(r_RParseTextAsync_PartialValue_Int32_Int32_Int32_Int32_Char == null)
				{
					r_RParseTextAsync_PartialValue_Int32_Int32_Int32_Int32_Char = new(this, "ParseTextAsync_PartialValue", 0, typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Char));
					r_RParseTextAsync_PartialValue_Int32_Int32_Int32_Int32_Char.SetBelong(this.instance);
				}
				return r_RParseTextAsync_PartialValue_Int32_Int32_Int32_Int32_Char;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishPartialValueAsync()
		/// </summary>
		protected RMethod r_RFinishPartialValueAsync;
		public virtual RMethod RFinishPartialValueAsync
		{
			get
			{
				if(r_RFinishPartialValueAsync == null)
				{
					r_RFinishPartialValueAsync = new(this, "FinishPartialValueAsync", 0);
					r_RFinishPartialValueAsync.SetBelong(this.instance);
				}
				return r_RFinishPartialValueAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishOtherValueIteratorAsync()
		/// </summary>
		protected RMethod r_RFinishOtherValueIteratorAsync;
		public virtual RMethod RFinishOtherValueIteratorAsync
		{
			get
			{
				if(r_RFinishOtherValueIteratorAsync == null)
				{
					r_RFinishOtherValueIteratorAsync = new(this, "FinishOtherValueIteratorAsync", 0);
					r_RFinishOtherValueIteratorAsync.SetBelong(this.instance);
				}
				return r_RFinishOtherValueIteratorAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task SkipPartialTextValueAsync()
		/// </summary>
		protected RMethod r_RSkipPartialTextValueAsync;
		public virtual RMethod RSkipPartialTextValueAsync
		{
			get
			{
				if(r_RSkipPartialTextValueAsync == null)
				{
					r_RSkipPartialTextValueAsync = new(this, "SkipPartialTextValueAsync", 0);
					r_RSkipPartialTextValueAsync.SetBelong(this.instance);
				}
				return r_RSkipPartialTextValueAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishReadValueChunkAsync()
		/// </summary>
		protected RMethod r_RFinishReadValueChunkAsync;
		public virtual RMethod RFinishReadValueChunkAsync
		{
			get
			{
				if(r_RFinishReadValueChunkAsync == null)
				{
					r_RFinishReadValueChunkAsync = new(this, "FinishReadValueChunkAsync", 0);
					r_RFinishReadValueChunkAsync.SetBelong(this.instance);
				}
				return r_RFinishReadValueChunkAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishReadContentAsBinaryAsync()
		/// </summary>
		protected RMethod r_RFinishReadContentAsBinaryAsync;
		public virtual RMethod RFinishReadContentAsBinaryAsync
		{
			get
			{
				if(r_RFinishReadContentAsBinaryAsync == null)
				{
					r_RFinishReadContentAsBinaryAsync = new(this, "FinishReadContentAsBinaryAsync", 0);
					r_RFinishReadContentAsBinaryAsync.SetBelong(this.instance);
				}
				return r_RFinishReadContentAsBinaryAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task FinishReadElementContentAsBinaryAsync()
		/// </summary>
		protected RMethod r_RFinishReadElementContentAsBinaryAsync;
		public virtual RMethod RFinishReadElementContentAsBinaryAsync
		{
			get
			{
				if(r_RFinishReadElementContentAsBinaryAsync == null)
				{
					r_RFinishReadElementContentAsBinaryAsync = new(this, "FinishReadElementContentAsBinaryAsync", 0);
					r_RFinishReadElementContentAsBinaryAsync.SetBelong(this.instance);
				}
				return r_RFinishReadElementContentAsBinaryAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseRootLevelWhitespaceAsync()
		/// </summary>
		protected RMethod r_RParseRootLevelWhitespaceAsync;
		public virtual RMethod RParseRootLevelWhitespaceAsync
		{
			get
			{
				if(r_RParseRootLevelWhitespaceAsync == null)
				{
					r_RParseRootLevelWhitespaceAsync = new(this, "ParseRootLevelWhitespaceAsync", 0);
					r_RParseRootLevelWhitespaceAsync.SetBelong(this.instance);
				}
				return r_RParseRootLevelWhitespaceAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseEntityReferenceAsync()
		/// </summary>
		protected RMethod r_RParseEntityReferenceAsync;
		public virtual RMethod RParseEntityReferenceAsync
		{
			get
			{
				if(r_RParseEntityReferenceAsync == null)
				{
					r_RParseEntityReferenceAsync = new(this, "ParseEntityReferenceAsync", 0);
					r_RParseEntityReferenceAsync.SetBelong(this.instance);
				}
				return r_RParseEntityReferenceAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`2[System.Int32,System.Xml.XmlTextReaderImpl+EntityType]] HandleEntityReferenceAsync(Boolean, EntityExpandType)
		/// </summary>
		protected RMethod r_RHandleEntityReferenceAsync_Boolean_EntityExpandType;
		public virtual RMethod RHandleEntityReferenceAsync_Boolean_EntityExpandType
		{
			get
			{
				if(r_RHandleEntityReferenceAsync_Boolean_EntityExpandType == null)
				{
					r_RHandleEntityReferenceAsync_Boolean_EntityExpandType = new(this, "HandleEntityReferenceAsync", 0, typeof(System.Boolean),  ReleactionUtils.GetType("System.Xml.XmlTextReaderImpl+EntityExpandType"));
					r_RHandleEntityReferenceAsync_Boolean_EntityExpandType.SetBelong(this.instance);
				}
				return r_RHandleEntityReferenceAsync_Boolean_EntityExpandType;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Xml.XmlTextReaderImpl+EntityType] HandleGeneralEntityReferenceAsync(System.String, Boolean, Boolean, Int32)
		/// </summary>
		protected RMethod r_RHandleGeneralEntityReferenceAsync_String_Boolean_Boolean_Int32;
		public virtual RMethod RHandleGeneralEntityReferenceAsync_String_Boolean_Boolean_Int32
		{
			get
			{
				if(r_RHandleGeneralEntityReferenceAsync_String_Boolean_Boolean_Int32 == null)
				{
					r_RHandleGeneralEntityReferenceAsync_String_Boolean_Boolean_Int32 = new(this, "HandleGeneralEntityReferenceAsync", 0, typeof(System.String), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Int32));
					r_RHandleGeneralEntityReferenceAsync_String_Boolean_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RHandleGeneralEntityReferenceAsync_String_Boolean_Boolean_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParsePIAsync()
		/// </summary>
		protected RMethod r_RParsePIAsync;
		public virtual RMethod RParsePIAsync
		{
			get
			{
				if(r_RParsePIAsync == null)
				{
					r_RParsePIAsync = new(this, "ParsePIAsync", 0);
					r_RParsePIAsync.SetBelong(this.instance);
				}
				return r_RParsePIAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParsePIAsync(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RParsePIAsync_StringBuilder;
		public virtual RMethod RParsePIAsync_StringBuilder
		{
			get
			{
				if(r_RParsePIAsync_StringBuilder == null)
				{
					r_RParsePIAsync_StringBuilder = new(this, "ParsePIAsync", 0, typeof(System.Text.StringBuilder));
					r_RParsePIAsync_StringBuilder.SetBelong(this.instance);
				}
				return r_RParsePIAsync_StringBuilder;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`3[System.Int32,System.Int32,System.Boolean]] ParsePIValueAsync()
		/// </summary>
		protected RMethod r_RParsePIValueAsync;
		public virtual RMethod RParsePIValueAsync
		{
			get
			{
				if(r_RParsePIValueAsync == null)
				{
					r_RParsePIValueAsync = new(this, "ParsePIValueAsync", 0);
					r_RParsePIValueAsync.SetBelong(this.instance);
				}
				return r_RParsePIValueAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseCommentAsync()
		/// </summary>
		protected RMethod r_RParseCommentAsync;
		public virtual RMethod RParseCommentAsync
		{
			get
			{
				if(r_RParseCommentAsync == null)
				{
					r_RParseCommentAsync = new(this, "ParseCommentAsync", 0);
					r_RParseCommentAsync.SetBelong(this.instance);
				}
				return r_RParseCommentAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseCDataAsync()
		/// </summary>
		protected RMethod r_RParseCDataAsync;
		public virtual RMethod RParseCDataAsync
		{
			get
			{
				if(r_RParseCDataAsync == null)
				{
					r_RParseCDataAsync = new(this, "ParseCDataAsync", 0);
					r_RParseCDataAsync.SetBelong(this.instance);
				}
				return r_RParseCDataAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseCDataOrCommentAsync(System.Xml.XmlNodeType)
		/// </summary>
		protected RMethod r_RParseCDataOrCommentAsync_XmlNodeType;
		public virtual RMethod RParseCDataOrCommentAsync_XmlNodeType
		{
			get
			{
				if(r_RParseCDataOrCommentAsync_XmlNodeType == null)
				{
					r_RParseCDataOrCommentAsync_XmlNodeType = new(this, "ParseCDataOrCommentAsync", 0, typeof(System.Xml.XmlNodeType));
					r_RParseCDataOrCommentAsync_XmlNodeType.SetBelong(this.instance);
				}
				return r_RParseCDataOrCommentAsync_XmlNodeType;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`3[System.Int32,System.Int32,System.Boolean]] ParseCDataOrCommentTupleAsync(System.Xml.XmlNodeType)
		/// </summary>
		protected RMethod r_RParseCDataOrCommentTupleAsync_XmlNodeType;
		public virtual RMethod RParseCDataOrCommentTupleAsync_XmlNodeType
		{
			get
			{
				if(r_RParseCDataOrCommentTupleAsync_XmlNodeType == null)
				{
					r_RParseCDataOrCommentTupleAsync_XmlNodeType = new(this, "ParseCDataOrCommentTupleAsync", 0, typeof(System.Xml.XmlNodeType));
					r_RParseCDataOrCommentTupleAsync_XmlNodeType.SetBelong(this.instance);
				}
				return r_RParseCDataOrCommentTupleAsync_XmlNodeType;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ParseDoctypeDeclAsync()
		/// </summary>
		protected RMethod r_RParseDoctypeDeclAsync;
		public virtual RMethod RParseDoctypeDeclAsync
		{
			get
			{
				if(r_RParseDoctypeDeclAsync == null)
				{
					r_RParseDoctypeDeclAsync = new(this, "ParseDoctypeDeclAsync", 0);
					r_RParseDoctypeDeclAsync.SetBelong(this.instance);
				}
				return r_RParseDoctypeDeclAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseDtdAsync()
		/// </summary>
		protected RMethod r_RParseDtdAsync;
		public virtual RMethod RParseDtdAsync
		{
			get
			{
				if(r_RParseDtdAsync == null)
				{
					r_RParseDtdAsync = new(this, "ParseDtdAsync", 0);
					r_RParseDtdAsync.SetBelong(this.instance);
				}
				return r_RParseDtdAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task SkipDtdAsync()
		/// </summary>
		protected RMethod r_RSkipDtdAsync;
		public virtual RMethod RSkipDtdAsync
		{
			get
			{
				if(r_RSkipDtdAsync == null)
				{
					r_RSkipDtdAsync = new(this, "SkipDtdAsync", 0);
					r_RSkipDtdAsync.SetBelong(this.instance);
				}
				return r_RSkipDtdAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task SkipPublicOrSystemIdLiteralAsync()
		/// </summary>
		protected RMethod r_RSkipPublicOrSystemIdLiteralAsync;
		public virtual RMethod RSkipPublicOrSystemIdLiteralAsync
		{
			get
			{
				if(r_RSkipPublicOrSystemIdLiteralAsync == null)
				{
					r_RSkipPublicOrSystemIdLiteralAsync = new(this, "SkipPublicOrSystemIdLiteralAsync", 0);
					r_RSkipPublicOrSystemIdLiteralAsync.SetBelong(this.instance);
				}
				return r_RSkipPublicOrSystemIdLiteralAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task SkipUntilAsync(Char, Boolean)
		/// </summary>
		protected RMethod r_RSkipUntilAsync_Char_Boolean;
		public virtual RMethod RSkipUntilAsync_Char_Boolean
		{
			get
			{
				if(r_RSkipUntilAsync_Char_Boolean == null)
				{
					r_RSkipUntilAsync_Char_Boolean = new(this, "SkipUntilAsync", 0, typeof(System.Char), typeof(System.Boolean));
					r_RSkipUntilAsync_Char_Boolean.SetBelong(this.instance);
				}
				return r_RSkipUntilAsync_Char_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] EatWhitespacesAsync(System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_REatWhitespacesAsync_StringBuilder;
		public virtual RMethod REatWhitespacesAsync_StringBuilder
		{
			get
			{
				if(r_REatWhitespacesAsync_StringBuilder == null)
				{
					r_REatWhitespacesAsync_StringBuilder = new(this, "EatWhitespacesAsync", 0, typeof(System.Text.StringBuilder));
					r_REatWhitespacesAsync_StringBuilder.SetBelong(this.instance);
				}
				return r_REatWhitespacesAsync_StringBuilder;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`2[System.Xml.XmlTextReaderImpl+EntityType,System.Int32]] ParseNumericCharRefAsync(Boolean, System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RParseNumericCharRefAsync_Boolean_StringBuilder;
		public virtual RMethod RParseNumericCharRefAsync_Boolean_StringBuilder
		{
			get
			{
				if(r_RParseNumericCharRefAsync_Boolean_StringBuilder == null)
				{
					r_RParseNumericCharRefAsync_Boolean_StringBuilder = new(this, "ParseNumericCharRefAsync", 0, typeof(System.Boolean), typeof(System.Text.StringBuilder));
					r_RParseNumericCharRefAsync_Boolean_StringBuilder.SetBelong(this.instance);
				}
				return r_RParseNumericCharRefAsync_Boolean_StringBuilder;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ParseNamedCharRefAsync(Boolean, System.Text.StringBuilder)
		/// </summary>
		protected RMethod r_RParseNamedCharRefAsync_Boolean_StringBuilder;
		public virtual RMethod RParseNamedCharRefAsync_Boolean_StringBuilder
		{
			get
			{
				if(r_RParseNamedCharRefAsync_Boolean_StringBuilder == null)
				{
					r_RParseNamedCharRefAsync_Boolean_StringBuilder = new(this, "ParseNamedCharRefAsync", 0, typeof(System.Boolean), typeof(System.Text.StringBuilder));
					r_RParseNamedCharRefAsync_Boolean_StringBuilder.SetBelong(this.instance);
				}
				return r_RParseNamedCharRefAsync_Boolean_StringBuilder;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ParseNameAsync()
		/// </summary>
		protected RMethod r_RParseNameAsync;
		public virtual RMethod RParseNameAsync
		{
			get
			{
				if(r_RParseNameAsync == null)
				{
					r_RParseNameAsync = new(this, "ParseNameAsync", 0);
					r_RParseNameAsync.SetBelong(this.instance);
				}
				return r_RParseNameAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`2[System.Int32,System.Int32]] ParseQNameAsync()
		/// </summary>
		protected RMethod r_RParseQNameAsync;
		public virtual RMethod RParseQNameAsync
		{
			get
			{
				if(r_RParseQNameAsync == null)
				{
					r_RParseQNameAsync = new(this, "ParseQNameAsync", 0);
					r_RParseQNameAsync.SetBelong(this.instance);
				}
				return r_RParseQNameAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`2[System.Int32,System.Int32]] ParseQNameAsync(Boolean, Int32)
		/// </summary>
		protected RMethod r_RParseQNameAsync_Boolean_Int32;
		public virtual RMethod RParseQNameAsync_Boolean_Int32
		{
			get
			{
				if(r_RParseQNameAsync_Boolean_Int32 == null)
				{
					r_RParseQNameAsync_Boolean_Int32 = new(this, "ParseQNameAsync", 0, typeof(System.Boolean), typeof(System.Int32));
					r_RParseQNameAsync_Boolean_Int32.SetBelong(this.instance);
				}
				return r_RParseQNameAsync_Boolean_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Tuple`2[System.Int32,System.Boolean]] ReadDataInNameAsync(Int32)
		/// </summary>
		protected RMethod r_RReadDataInNameAsync_Int32;
		public virtual RMethod RReadDataInNameAsync_Int32
		{
			get
			{
				if(r_RReadDataInNameAsync_Int32 == null)
				{
					r_RReadDataInNameAsync_Int32 = new(this, "ReadDataInNameAsync", 0, typeof(System.Int32));
					r_RReadDataInNameAsync_Int32.SetBelong(this.instance);
				}
				return r_RReadDataInNameAsync_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ParseEntityNameAsync()
		/// </summary>
		protected RMethod r_RParseEntityNameAsync;
		public virtual RMethod RParseEntityNameAsync
		{
			get
			{
				if(r_RParseEntityNameAsync == null)
				{
					r_RParseEntityNameAsync = new(this, "ParseEntityNameAsync", 0);
					r_RParseEntityNameAsync.SetBelong(this.instance);
				}
				return r_RParseEntityNameAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task PushExternalEntityOrSubsetAsync(System.String, System.String, System.Uri, System.String)
		/// </summary>
		protected RMethod r_RPushExternalEntityOrSubsetAsync_String_String_Uri_String;
		public virtual RMethod RPushExternalEntityOrSubsetAsync_String_String_Uri_String
		{
			get
			{
				if(r_RPushExternalEntityOrSubsetAsync_String_String_Uri_String == null)
				{
					r_RPushExternalEntityOrSubsetAsync_String_String_Uri_String = new(this, "PushExternalEntityOrSubsetAsync", 0, typeof(System.String), typeof(System.String), typeof(System.Uri), typeof(System.String));
					r_RPushExternalEntityOrSubsetAsync_String_String_Uri_String.SetBelong(this.instance);
				}
				return r_RPushExternalEntityOrSubsetAsync_String_String_Uri_String;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] OpenAndPushAsync(System.Uri)
		/// </summary>
		protected RMethod r_ROpenAndPushAsync_Uri;
		public virtual RMethod ROpenAndPushAsync_Uri
		{
			get
			{
				if(r_ROpenAndPushAsync_Uri == null)
				{
					r_ROpenAndPushAsync_Uri = new(this, "OpenAndPushAsync", 0, typeof(System.Uri));
					r_ROpenAndPushAsync_Uri.SetBelong(this.instance);
				}
				return r_ROpenAndPushAsync_Uri;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] PushExternalEntityAsync(System.Xml.IDtdEntityInfo)
		/// </summary>
		protected RMethod r_RPushExternalEntityAsync_IDtdEntityInfo;
		public virtual RMethod RPushExternalEntityAsync_IDtdEntityInfo
		{
			get
			{
				if(r_RPushExternalEntityAsync_IDtdEntityInfo == null)
				{
					r_RPushExternalEntityAsync_IDtdEntityInfo = new(this, "PushExternalEntityAsync", 0,  ReleactionUtils.GetType("System.Xml.IDtdEntityInfo"));
					r_RPushExternalEntityAsync_IDtdEntityInfo.SetBelong(this.instance);
				}
				return r_RPushExternalEntityAsync_IDtdEntityInfo;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] ZeroEndingStreamAsync(Int32)
		/// </summary>
		protected RMethod r_RZeroEndingStreamAsync_Int32;
		public virtual RMethod RZeroEndingStreamAsync_Int32
		{
			get
			{
				if(r_RZeroEndingStreamAsync_Int32 == null)
				{
					r_RZeroEndingStreamAsync_Int32 = new(this, "ZeroEndingStreamAsync", 0, typeof(System.Int32));
					r_RZeroEndingStreamAsync_Int32.SetBelong(this.instance);
				}
				return r_RZeroEndingStreamAsync_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task ParseDtdFromParserContextAsync()
		/// </summary>
		protected RMethod r_RParseDtdFromParserContextAsync;
		public virtual RMethod RParseDtdFromParserContextAsync
		{
			get
			{
				if(r_RParseDtdFromParserContextAsync == null)
				{
					r_RParseDtdFromParserContextAsync = new(this, "ParseDtdFromParserContextAsync", 0);
					r_RParseDtdFromParserContextAsync.SetBelong(this.instance);
				}
				return r_RParseDtdFromParserContextAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] InitReadContentAsBinaryAsync()
		/// </summary>
		protected RMethod r_RInitReadContentAsBinaryAsync;
		public virtual RMethod RInitReadContentAsBinaryAsync
		{
			get
			{
				if(r_RInitReadContentAsBinaryAsync == null)
				{
					r_RInitReadContentAsBinaryAsync = new(this, "InitReadContentAsBinaryAsync", 0);
					r_RInitReadContentAsBinaryAsync.SetBelong(this.instance);
				}
				return r_RInitReadContentAsBinaryAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] InitReadElementContentAsBinaryAsync()
		/// </summary>
		protected RMethod r_RInitReadElementContentAsBinaryAsync;
		public virtual RMethod RInitReadElementContentAsBinaryAsync
		{
			get
			{
				if(r_RInitReadElementContentAsBinaryAsync == null)
				{
					r_RInitReadElementContentAsBinaryAsync = new(this, "InitReadElementContentAsBinaryAsync", 0);
					r_RInitReadElementContentAsBinaryAsync.SetBelong(this.instance);
				}
				return r_RInitReadElementContentAsBinaryAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Boolean] MoveToNextContentNodeAsync(Boolean)
		/// </summary>
		protected RMethod r_RMoveToNextContentNodeAsync_Boolean;
		public virtual RMethod RMoveToNextContentNodeAsync_Boolean
		{
			get
			{
				if(r_RMoveToNextContentNodeAsync_Boolean == null)
				{
					r_RMoveToNextContentNodeAsync_Boolean = new(this, "MoveToNextContentNodeAsync", 0, typeof(System.Boolean));
					r_RMoveToNextContentNodeAsync_Boolean.SetBelong(this.instance);
				}
				return r_RMoveToNextContentNodeAsync_Boolean;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadContentAsBinaryAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadContentAsBinaryAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32 = new(this, "ReadContentAsBinaryAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadContentAsBinaryAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Int32] ReadElementContentAsBinaryAsync(Byte[], Int32, Int32)
		/// </summary>
		protected RMethod r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32;
		public virtual RMethod RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32
		{
			get
			{
				if(r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32 == null)
				{
					r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32 = new(this, "ReadElementContentAsBinaryAsync", 0, typeof(System.Byte).MakeArrayType(), typeof(System.Int32), typeof(System.Int32));
					r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32;
			}
		}

		/// <summary>
		/// System.Object ReadContentAsObject()
		/// </summary>
		protected RMethod r_RReadContentAsObject;
		public virtual RMethod RReadContentAsObject
		{
			get
			{
				if(r_RReadContentAsObject == null)
				{
					r_RReadContentAsObject = new(this, "ReadContentAsObject", 0);
					r_RReadContentAsObject.SetBelong(this.instance);
				}
				return r_RReadContentAsObject;
			}
		}

		/// <summary>
		/// Boolean ReadContentAsBoolean()
		/// </summary>
		protected RMethod r_RReadContentAsBoolean;
		public virtual RMethod RReadContentAsBoolean
		{
			get
			{
				if(r_RReadContentAsBoolean == null)
				{
					r_RReadContentAsBoolean = new(this, "ReadContentAsBoolean", 0);
					r_RReadContentAsBoolean.SetBelong(this.instance);
				}
				return r_RReadContentAsBoolean;
			}
		}

		/// <summary>
		/// System.DateTime ReadContentAsDateTime()
		/// </summary>
		protected RMethod r_RReadContentAsDateTime;
		public virtual RMethod RReadContentAsDateTime
		{
			get
			{
				if(r_RReadContentAsDateTime == null)
				{
					r_RReadContentAsDateTime = new(this, "ReadContentAsDateTime", 0);
					r_RReadContentAsDateTime.SetBelong(this.instance);
				}
				return r_RReadContentAsDateTime;
			}
		}

		/// <summary>
		/// System.DateTimeOffset ReadContentAsDateTimeOffset()
		/// </summary>
		protected RMethod r_RReadContentAsDateTimeOffset;
		public virtual RMethod RReadContentAsDateTimeOffset
		{
			get
			{
				if(r_RReadContentAsDateTimeOffset == null)
				{
					r_RReadContentAsDateTimeOffset = new(this, "ReadContentAsDateTimeOffset", 0);
					r_RReadContentAsDateTimeOffset.SetBelong(this.instance);
				}
				return r_RReadContentAsDateTimeOffset;
			}
		}

		/// <summary>
		/// Double ReadContentAsDouble()
		/// </summary>
		protected RMethod r_RReadContentAsDouble;
		public virtual RMethod RReadContentAsDouble
		{
			get
			{
				if(r_RReadContentAsDouble == null)
				{
					r_RReadContentAsDouble = new(this, "ReadContentAsDouble", 0);
					r_RReadContentAsDouble.SetBelong(this.instance);
				}
				return r_RReadContentAsDouble;
			}
		}

		/// <summary>
		/// Single ReadContentAsFloat()
		/// </summary>
		protected RMethod r_RReadContentAsFloat;
		public virtual RMethod RReadContentAsFloat
		{
			get
			{
				if(r_RReadContentAsFloat == null)
				{
					r_RReadContentAsFloat = new(this, "ReadContentAsFloat", 0);
					r_RReadContentAsFloat.SetBelong(this.instance);
				}
				return r_RReadContentAsFloat;
			}
		}

		/// <summary>
		/// System.Decimal ReadContentAsDecimal()
		/// </summary>
		protected RMethod r_RReadContentAsDecimal;
		public virtual RMethod RReadContentAsDecimal
		{
			get
			{
				if(r_RReadContentAsDecimal == null)
				{
					r_RReadContentAsDecimal = new(this, "ReadContentAsDecimal", 0);
					r_RReadContentAsDecimal.SetBelong(this.instance);
				}
				return r_RReadContentAsDecimal;
			}
		}

		/// <summary>
		/// Int32 ReadContentAsInt()
		/// </summary>
		protected RMethod r_RReadContentAsInt;
		public virtual RMethod RReadContentAsInt
		{
			get
			{
				if(r_RReadContentAsInt == null)
				{
					r_RReadContentAsInt = new(this, "ReadContentAsInt", 0);
					r_RReadContentAsInt.SetBelong(this.instance);
				}
				return r_RReadContentAsInt;
			}
		}

		/// <summary>
		/// Int64 ReadContentAsLong()
		/// </summary>
		protected RMethod r_RReadContentAsLong;
		public virtual RMethod RReadContentAsLong
		{
			get
			{
				if(r_RReadContentAsLong == null)
				{
					r_RReadContentAsLong = new(this, "ReadContentAsLong", 0);
					r_RReadContentAsLong.SetBelong(this.instance);
				}
				return r_RReadContentAsLong;
			}
		}

		/// <summary>
		/// System.String ReadContentAsString()
		/// </summary>
		protected RMethod r_RReadContentAsString;
		public virtual RMethod RReadContentAsString
		{
			get
			{
				if(r_RReadContentAsString == null)
				{
					r_RReadContentAsString = new(this, "ReadContentAsString", 0);
					r_RReadContentAsString.SetBelong(this.instance);
				}
				return r_RReadContentAsString;
			}
		}

		/// <summary>
		/// System.Object ReadContentAs(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RReadContentAs_Type_IXmlNamespaceResolver;
		public virtual RMethod RReadContentAs_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RReadContentAs_Type_IXmlNamespaceResolver == null)
				{
					r_RReadContentAs_Type_IXmlNamespaceResolver = new(this, "ReadContentAs", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RReadContentAs_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RReadContentAs_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object ReadElementContentAsObject()
		/// </summary>
		protected RMethod r_RReadElementContentAsObject;
		public virtual RMethod RReadElementContentAsObject
		{
			get
			{
				if(r_RReadElementContentAsObject == null)
				{
					r_RReadElementContentAsObject = new(this, "ReadElementContentAsObject", 0);
					r_RReadElementContentAsObject.SetBelong(this.instance);
				}
				return r_RReadElementContentAsObject;
			}
		}

		/// <summary>
		/// System.Object ReadElementContentAsObject(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsObject_String_String;
		public virtual RMethod RReadElementContentAsObject_String_String
		{
			get
			{
				if(r_RReadElementContentAsObject_String_String == null)
				{
					r_RReadElementContentAsObject_String_String = new(this, "ReadElementContentAsObject", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsObject_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsObject_String_String;
			}
		}

		/// <summary>
		/// Boolean ReadElementContentAsBoolean()
		/// </summary>
		protected RMethod r_RReadElementContentAsBoolean;
		public virtual RMethod RReadElementContentAsBoolean
		{
			get
			{
				if(r_RReadElementContentAsBoolean == null)
				{
					r_RReadElementContentAsBoolean = new(this, "ReadElementContentAsBoolean", 0);
					r_RReadElementContentAsBoolean.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBoolean;
			}
		}

		/// <summary>
		/// Boolean ReadElementContentAsBoolean(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsBoolean_String_String;
		public virtual RMethod RReadElementContentAsBoolean_String_String
		{
			get
			{
				if(r_RReadElementContentAsBoolean_String_String == null)
				{
					r_RReadElementContentAsBoolean_String_String = new(this, "ReadElementContentAsBoolean", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsBoolean_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsBoolean_String_String;
			}
		}

		/// <summary>
		/// System.DateTime ReadElementContentAsDateTime()
		/// </summary>
		protected RMethod r_RReadElementContentAsDateTime;
		public virtual RMethod RReadElementContentAsDateTime
		{
			get
			{
				if(r_RReadElementContentAsDateTime == null)
				{
					r_RReadElementContentAsDateTime = new(this, "ReadElementContentAsDateTime", 0);
					r_RReadElementContentAsDateTime.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDateTime;
			}
		}

		/// <summary>
		/// System.DateTime ReadElementContentAsDateTime(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsDateTime_String_String;
		public virtual RMethod RReadElementContentAsDateTime_String_String
		{
			get
			{
				if(r_RReadElementContentAsDateTime_String_String == null)
				{
					r_RReadElementContentAsDateTime_String_String = new(this, "ReadElementContentAsDateTime", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsDateTime_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDateTime_String_String;
			}
		}

		/// <summary>
		/// Double ReadElementContentAsDouble()
		/// </summary>
		protected RMethod r_RReadElementContentAsDouble;
		public virtual RMethod RReadElementContentAsDouble
		{
			get
			{
				if(r_RReadElementContentAsDouble == null)
				{
					r_RReadElementContentAsDouble = new(this, "ReadElementContentAsDouble", 0);
					r_RReadElementContentAsDouble.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDouble;
			}
		}

		/// <summary>
		/// Double ReadElementContentAsDouble(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsDouble_String_String;
		public virtual RMethod RReadElementContentAsDouble_String_String
		{
			get
			{
				if(r_RReadElementContentAsDouble_String_String == null)
				{
					r_RReadElementContentAsDouble_String_String = new(this, "ReadElementContentAsDouble", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsDouble_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDouble_String_String;
			}
		}

		/// <summary>
		/// Single ReadElementContentAsFloat()
		/// </summary>
		protected RMethod r_RReadElementContentAsFloat;
		public virtual RMethod RReadElementContentAsFloat
		{
			get
			{
				if(r_RReadElementContentAsFloat == null)
				{
					r_RReadElementContentAsFloat = new(this, "ReadElementContentAsFloat", 0);
					r_RReadElementContentAsFloat.SetBelong(this.instance);
				}
				return r_RReadElementContentAsFloat;
			}
		}

		/// <summary>
		/// Single ReadElementContentAsFloat(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsFloat_String_String;
		public virtual RMethod RReadElementContentAsFloat_String_String
		{
			get
			{
				if(r_RReadElementContentAsFloat_String_String == null)
				{
					r_RReadElementContentAsFloat_String_String = new(this, "ReadElementContentAsFloat", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsFloat_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsFloat_String_String;
			}
		}

		/// <summary>
		/// System.Decimal ReadElementContentAsDecimal()
		/// </summary>
		protected RMethod r_RReadElementContentAsDecimal;
		public virtual RMethod RReadElementContentAsDecimal
		{
			get
			{
				if(r_RReadElementContentAsDecimal == null)
				{
					r_RReadElementContentAsDecimal = new(this, "ReadElementContentAsDecimal", 0);
					r_RReadElementContentAsDecimal.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDecimal;
			}
		}

		/// <summary>
		/// System.Decimal ReadElementContentAsDecimal(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsDecimal_String_String;
		public virtual RMethod RReadElementContentAsDecimal_String_String
		{
			get
			{
				if(r_RReadElementContentAsDecimal_String_String == null)
				{
					r_RReadElementContentAsDecimal_String_String = new(this, "ReadElementContentAsDecimal", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsDecimal_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsDecimal_String_String;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsInt()
		/// </summary>
		protected RMethod r_RReadElementContentAsInt;
		public virtual RMethod RReadElementContentAsInt
		{
			get
			{
				if(r_RReadElementContentAsInt == null)
				{
					r_RReadElementContentAsInt = new(this, "ReadElementContentAsInt", 0);
					r_RReadElementContentAsInt.SetBelong(this.instance);
				}
				return r_RReadElementContentAsInt;
			}
		}

		/// <summary>
		/// Int32 ReadElementContentAsInt(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsInt_String_String;
		public virtual RMethod RReadElementContentAsInt_String_String
		{
			get
			{
				if(r_RReadElementContentAsInt_String_String == null)
				{
					r_RReadElementContentAsInt_String_String = new(this, "ReadElementContentAsInt", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsInt_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsInt_String_String;
			}
		}

		/// <summary>
		/// Int64 ReadElementContentAsLong()
		/// </summary>
		protected RMethod r_RReadElementContentAsLong;
		public virtual RMethod RReadElementContentAsLong
		{
			get
			{
				if(r_RReadElementContentAsLong == null)
				{
					r_RReadElementContentAsLong = new(this, "ReadElementContentAsLong", 0);
					r_RReadElementContentAsLong.SetBelong(this.instance);
				}
				return r_RReadElementContentAsLong;
			}
		}

		/// <summary>
		/// Int64 ReadElementContentAsLong(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsLong_String_String;
		public virtual RMethod RReadElementContentAsLong_String_String
		{
			get
			{
				if(r_RReadElementContentAsLong_String_String == null)
				{
					r_RReadElementContentAsLong_String_String = new(this, "ReadElementContentAsLong", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsLong_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsLong_String_String;
			}
		}

		/// <summary>
		/// System.String ReadElementContentAsString()
		/// </summary>
		protected RMethod r_RReadElementContentAsString;
		public virtual RMethod RReadElementContentAsString
		{
			get
			{
				if(r_RReadElementContentAsString == null)
				{
					r_RReadElementContentAsString = new(this, "ReadElementContentAsString", 0);
					r_RReadElementContentAsString.SetBelong(this.instance);
				}
				return r_RReadElementContentAsString;
			}
		}

		/// <summary>
		/// System.String ReadElementContentAsString(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAsString_String_String;
		public virtual RMethod RReadElementContentAsString_String_String
		{
			get
			{
				if(r_RReadElementContentAsString_String_String == null)
				{
					r_RReadElementContentAsString_String_String = new(this, "ReadElementContentAsString", 0, typeof(System.String), typeof(System.String));
					r_RReadElementContentAsString_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAsString_String_String;
			}
		}

		/// <summary>
		/// System.Object ReadElementContentAs(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RReadElementContentAs_Type_IXmlNamespaceResolver;
		public virtual RMethod RReadElementContentAs_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RReadElementContentAs_Type_IXmlNamespaceResolver == null)
				{
					r_RReadElementContentAs_Type_IXmlNamespaceResolver = new(this, "ReadElementContentAs", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RReadElementContentAs_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RReadElementContentAs_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Object ReadElementContentAs(System.Type, System.Xml.IXmlNamespaceResolver, System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String;
		public virtual RMethod RReadElementContentAs_Type_IXmlNamespaceResolver_String_String
		{
			get
			{
				if(r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String == null)
				{
					r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String = new(this, "ReadElementContentAs", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver), typeof(System.String), typeof(System.String));
					r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String.SetBelong(this.instance);
				}
				return r_RReadElementContentAs_Type_IXmlNamespaceResolver_String_String;
			}
		}

		/// <summary>
		/// System.Xml.XmlNodeType MoveToContent()
		/// </summary>
		protected RMethod r_RMoveToContent;
		public virtual RMethod RMoveToContent
		{
			get
			{
				if(r_RMoveToContent == null)
				{
					r_RMoveToContent = new(this, "MoveToContent", 0);
					r_RMoveToContent.SetBelong(this.instance);
				}
				return r_RMoveToContent;
			}
		}

		/// <summary>
		/// Void ReadStartElement()
		/// </summary>
		protected RMethod r_RReadStartElement;
		public virtual RMethod RReadStartElement
		{
			get
			{
				if(r_RReadStartElement == null)
				{
					r_RReadStartElement = new(this, "ReadStartElement", 0);
					r_RReadStartElement.SetBelong(this.instance);
				}
				return r_RReadStartElement;
			}
		}

		/// <summary>
		/// Void ReadStartElement(System.String)
		/// </summary>
		protected RMethod r_RReadStartElement_String;
		public virtual RMethod RReadStartElement_String
		{
			get
			{
				if(r_RReadStartElement_String == null)
				{
					r_RReadStartElement_String = new(this, "ReadStartElement", 0, typeof(System.String));
					r_RReadStartElement_String.SetBelong(this.instance);
				}
				return r_RReadStartElement_String;
			}
		}

		/// <summary>
		/// Void ReadStartElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadStartElement_String_String;
		public virtual RMethod RReadStartElement_String_String
		{
			get
			{
				if(r_RReadStartElement_String_String == null)
				{
					r_RReadStartElement_String_String = new(this, "ReadStartElement", 0, typeof(System.String), typeof(System.String));
					r_RReadStartElement_String_String.SetBelong(this.instance);
				}
				return r_RReadStartElement_String_String;
			}
		}

		/// <summary>
		/// System.String ReadElementString()
		/// </summary>
		protected RMethod r_RReadElementString;
		public virtual RMethod RReadElementString
		{
			get
			{
				if(r_RReadElementString == null)
				{
					r_RReadElementString = new(this, "ReadElementString", 0);
					r_RReadElementString.SetBelong(this.instance);
				}
				return r_RReadElementString;
			}
		}

		/// <summary>
		/// System.String ReadElementString(System.String)
		/// </summary>
		protected RMethod r_RReadElementString_String;
		public virtual RMethod RReadElementString_String
		{
			get
			{
				if(r_RReadElementString_String == null)
				{
					r_RReadElementString_String = new(this, "ReadElementString", 0, typeof(System.String));
					r_RReadElementString_String.SetBelong(this.instance);
				}
				return r_RReadElementString_String;
			}
		}

		/// <summary>
		/// System.String ReadElementString(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadElementString_String_String;
		public virtual RMethod RReadElementString_String_String
		{
			get
			{
				if(r_RReadElementString_String_String == null)
				{
					r_RReadElementString_String_String = new(this, "ReadElementString", 0, typeof(System.String), typeof(System.String));
					r_RReadElementString_String_String.SetBelong(this.instance);
				}
				return r_RReadElementString_String_String;
			}
		}

		/// <summary>
		/// Void ReadEndElement()
		/// </summary>
		protected RMethod r_RReadEndElement;
		public virtual RMethod RReadEndElement
		{
			get
			{
				if(r_RReadEndElement == null)
				{
					r_RReadEndElement = new(this, "ReadEndElement", 0);
					r_RReadEndElement.SetBelong(this.instance);
				}
				return r_RReadEndElement;
			}
		}

		/// <summary>
		/// Boolean IsStartElement()
		/// </summary>
		protected RMethod r_RIsStartElement;
		public virtual RMethod RIsStartElement
		{
			get
			{
				if(r_RIsStartElement == null)
				{
					r_RIsStartElement = new(this, "IsStartElement", 0);
					r_RIsStartElement.SetBelong(this.instance);
				}
				return r_RIsStartElement;
			}
		}

		/// <summary>
		/// Boolean IsStartElement(System.String)
		/// </summary>
		protected RMethod r_RIsStartElement_String;
		public virtual RMethod RIsStartElement_String
		{
			get
			{
				if(r_RIsStartElement_String == null)
				{
					r_RIsStartElement_String = new(this, "IsStartElement", 0, typeof(System.String));
					r_RIsStartElement_String.SetBelong(this.instance);
				}
				return r_RIsStartElement_String;
			}
		}

		/// <summary>
		/// Boolean IsStartElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RIsStartElement_String_String;
		public virtual RMethod RIsStartElement_String_String
		{
			get
			{
				if(r_RIsStartElement_String_String == null)
				{
					r_RIsStartElement_String_String = new(this, "IsStartElement", 0, typeof(System.String), typeof(System.String));
					r_RIsStartElement_String_String.SetBelong(this.instance);
				}
				return r_RIsStartElement_String_String;
			}
		}

		/// <summary>
		/// Boolean ReadToFollowing(System.String)
		/// </summary>
		protected RMethod r_RReadToFollowing_String;
		public virtual RMethod RReadToFollowing_String
		{
			get
			{
				if(r_RReadToFollowing_String == null)
				{
					r_RReadToFollowing_String = new(this, "ReadToFollowing", 0, typeof(System.String));
					r_RReadToFollowing_String.SetBelong(this.instance);
				}
				return r_RReadToFollowing_String;
			}
		}

		/// <summary>
		/// Boolean ReadToFollowing(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadToFollowing_String_String;
		public virtual RMethod RReadToFollowing_String_String
		{
			get
			{
				if(r_RReadToFollowing_String_String == null)
				{
					r_RReadToFollowing_String_String = new(this, "ReadToFollowing", 0, typeof(System.String), typeof(System.String));
					r_RReadToFollowing_String_String.SetBelong(this.instance);
				}
				return r_RReadToFollowing_String_String;
			}
		}

		/// <summary>
		/// Boolean ReadToDescendant(System.String)
		/// </summary>
		protected RMethod r_RReadToDescendant_String;
		public virtual RMethod RReadToDescendant_String
		{
			get
			{
				if(r_RReadToDescendant_String == null)
				{
					r_RReadToDescendant_String = new(this, "ReadToDescendant", 0, typeof(System.String));
					r_RReadToDescendant_String.SetBelong(this.instance);
				}
				return r_RReadToDescendant_String;
			}
		}

		/// <summary>
		/// Boolean ReadToDescendant(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadToDescendant_String_String;
		public virtual RMethod RReadToDescendant_String_String
		{
			get
			{
				if(r_RReadToDescendant_String_String == null)
				{
					r_RReadToDescendant_String_String = new(this, "ReadToDescendant", 0, typeof(System.String), typeof(System.String));
					r_RReadToDescendant_String_String.SetBelong(this.instance);
				}
				return r_RReadToDescendant_String_String;
			}
		}

		/// <summary>
		/// Boolean ReadToNextSibling(System.String)
		/// </summary>
		protected RMethod r_RReadToNextSibling_String;
		public virtual RMethod RReadToNextSibling_String
		{
			get
			{
				if(r_RReadToNextSibling_String == null)
				{
					r_RReadToNextSibling_String = new(this, "ReadToNextSibling", 0, typeof(System.String));
					r_RReadToNextSibling_String.SetBelong(this.instance);
				}
				return r_RReadToNextSibling_String;
			}
		}

		/// <summary>
		/// Boolean ReadToNextSibling(System.String, System.String)
		/// </summary>
		protected RMethod r_RReadToNextSibling_String_String;
		public virtual RMethod RReadToNextSibling_String_String
		{
			get
			{
				if(r_RReadToNextSibling_String_String == null)
				{
					r_RReadToNextSibling_String_String = new(this, "ReadToNextSibling", 0, typeof(System.String), typeof(System.String));
					r_RReadToNextSibling_String_String.SetBelong(this.instance);
				}
				return r_RReadToNextSibling_String_String;
			}
		}

		/// <summary>
		/// System.String ReadInnerXml()
		/// </summary>
		protected RMethod r_RReadInnerXml;
		public virtual RMethod RReadInnerXml
		{
			get
			{
				if(r_RReadInnerXml == null)
				{
					r_RReadInnerXml = new(this, "ReadInnerXml", 0);
					r_RReadInnerXml.SetBelong(this.instance);
				}
				return r_RReadInnerXml;
			}
		}

		/// <summary>
		/// System.String ReadOuterXml()
		/// </summary>
		protected RMethod r_RReadOuterXml;
		public virtual RMethod RReadOuterXml
		{
			get
			{
				if(r_RReadOuterXml == null)
				{
					r_RReadOuterXml = new(this, "ReadOuterXml", 0);
					r_RReadOuterXml.SetBelong(this.instance);
				}
				return r_RReadOuterXml;
			}
		}

		/// <summary>
		/// System.Xml.XmlReader ReadSubtree()
		/// </summary>
		protected RMethod r_RReadSubtree;
		public virtual RMethod RReadSubtree
		{
			get
			{
				if(r_RReadSubtree == null)
				{
					r_RReadSubtree = new(this, "ReadSubtree", 0);
					r_RReadSubtree.SetBelong(this.instance);
				}
				return r_RReadSubtree;
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
		/// Void CheckElement(System.String, System.String)
		/// </summary>
		protected RMethod r_RCheckElement_String_String;
		public virtual RMethod RCheckElement_String_String
		{
			get
			{
				if(r_RCheckElement_String_String == null)
				{
					r_RCheckElement_String_String = new(this, "CheckElement", 0, typeof(System.String), typeof(System.String));
					r_RCheckElement_String_String.SetBelong(this.instance);
				}
				return r_RCheckElement_String_String;
			}
		}

		/// <summary>
		/// System.Exception CreateReadContentAsException(System.String)
		/// </summary>
		protected RMethod r_RCreateReadContentAsException_String;
		public virtual RMethod RCreateReadContentAsException_String
		{
			get
			{
				if(r_RCreateReadContentAsException_String == null)
				{
					r_RCreateReadContentAsException_String = new(this, "CreateReadContentAsException", 0, typeof(System.String));
					r_RCreateReadContentAsException_String.SetBelong(this.instance);
				}
				return r_RCreateReadContentAsException_String;
			}
		}

		/// <summary>
		/// System.Exception CreateReadElementContentAsException(System.String)
		/// </summary>
		protected RMethod r_RCreateReadElementContentAsException_String;
		public virtual RMethod RCreateReadElementContentAsException_String
		{
			get
			{
				if(r_RCreateReadElementContentAsException_String == null)
				{
					r_RCreateReadElementContentAsException_String = new(this, "CreateReadElementContentAsException", 0, typeof(System.String));
					r_RCreateReadElementContentAsException_String.SetBelong(this.instance);
				}
				return r_RCreateReadElementContentAsException_String;
			}
		}

		/// <summary>
		/// Boolean CanReadContentAs()
		/// </summary>
		protected RMethod r_RCanReadContentAs;
		public virtual RMethod RCanReadContentAs
		{
			get
			{
				if(r_RCanReadContentAs == null)
				{
					r_RCanReadContentAs = new(this, "CanReadContentAs", 0);
					r_RCanReadContentAs.SetBelong(this.instance);
				}
				return r_RCanReadContentAs;
			}
		}

		/// <summary>
		/// System.String InternalReadContentAsString()
		/// </summary>
		protected RMethod r_RInternalReadContentAsString;
		public virtual RMethod RInternalReadContentAsString
		{
			get
			{
				if(r_RInternalReadContentAsString == null)
				{
					r_RInternalReadContentAsString = new(this, "InternalReadContentAsString", 0);
					r_RInternalReadContentAsString.SetBelong(this.instance);
				}
				return r_RInternalReadContentAsString;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] ReadContentAsObjectAsync()
		/// </summary>
		protected RMethod r_RReadContentAsObjectAsync;
		public virtual RMethod RReadContentAsObjectAsync
		{
			get
			{
				if(r_RReadContentAsObjectAsync == null)
				{
					r_RReadContentAsObjectAsync = new(this, "ReadContentAsObjectAsync", 0);
					r_RReadContentAsObjectAsync.SetBelong(this.instance);
				}
				return r_RReadContentAsObjectAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadContentAsStringAsync()
		/// </summary>
		protected RMethod r_RReadContentAsStringAsync;
		public virtual RMethod RReadContentAsStringAsync
		{
			get
			{
				if(r_RReadContentAsStringAsync == null)
				{
					r_RReadContentAsStringAsync = new(this, "ReadContentAsStringAsync", 0);
					r_RReadContentAsStringAsync.SetBelong(this.instance);
				}
				return r_RReadContentAsStringAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] ReadContentAsAsync(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RReadContentAsAsync_Type_IXmlNamespaceResolver;
		public virtual RMethod RReadContentAsAsync_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RReadContentAsAsync_Type_IXmlNamespaceResolver == null)
				{
					r_RReadContentAsAsync_Type_IXmlNamespaceResolver = new(this, "ReadContentAsAsync", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RReadContentAsAsync_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RReadContentAsAsync_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] ReadElementContentAsObjectAsync()
		/// </summary>
		protected RMethod r_RReadElementContentAsObjectAsync;
		public virtual RMethod RReadElementContentAsObjectAsync
		{
			get
			{
				if(r_RReadElementContentAsObjectAsync == null)
				{
					r_RReadElementContentAsObjectAsync = new(this, "ReadElementContentAsObjectAsync", 0);
					r_RReadElementContentAsObjectAsync.SetBelong(this.instance);
				}
				return r_RReadElementContentAsObjectAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadElementContentAsStringAsync()
		/// </summary>
		protected RMethod r_RReadElementContentAsStringAsync;
		public virtual RMethod RReadElementContentAsStringAsync
		{
			get
			{
				if(r_RReadElementContentAsStringAsync == null)
				{
					r_RReadElementContentAsStringAsync = new(this, "ReadElementContentAsStringAsync", 0);
					r_RReadElementContentAsStringAsync.SetBelong(this.instance);
				}
				return r_RReadElementContentAsStringAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Object] ReadElementContentAsAsync(System.Type, System.Xml.IXmlNamespaceResolver)
		/// </summary>
		protected RMethod r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver;
		public virtual RMethod RReadElementContentAsAsync_Type_IXmlNamespaceResolver
		{
			get
			{
				if(r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver == null)
				{
					r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver = new(this, "ReadElementContentAsAsync", 0, typeof(System.Type), typeof(System.Xml.IXmlNamespaceResolver));
					r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver.SetBelong(this.instance);
				}
				return r_RReadElementContentAsAsync_Type_IXmlNamespaceResolver;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.Xml.XmlNodeType] MoveToContentAsync()
		/// </summary>
		protected RMethod r_RMoveToContentAsync;
		public virtual RMethod RMoveToContentAsync
		{
			get
			{
				if(r_RMoveToContentAsync == null)
				{
					r_RMoveToContentAsync = new(this, "MoveToContentAsync", 0);
					r_RMoveToContentAsync.SetBelong(this.instance);
				}
				return r_RMoveToContentAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadInnerXmlAsync()
		/// </summary>
		protected RMethod r_RReadInnerXmlAsync;
		public virtual RMethod RReadInnerXmlAsync
		{
			get
			{
				if(r_RReadInnerXmlAsync == null)
				{
					r_RReadInnerXmlAsync = new(this, "ReadInnerXmlAsync", 0);
					r_RReadInnerXmlAsync.SetBelong(this.instance);
				}
				return r_RReadInnerXmlAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] ReadOuterXmlAsync()
		/// </summary>
		protected RMethod r_RReadOuterXmlAsync;
		public virtual RMethod RReadOuterXmlAsync
		{
			get
			{
				if(r_RReadOuterXmlAsync == null)
				{
					r_RReadOuterXmlAsync = new(this, "ReadOuterXmlAsync", 0);
					r_RReadOuterXmlAsync.SetBelong(this.instance);
				}
				return r_RReadOuterXmlAsync;
			}
		}

		/// <summary>
		/// System.Threading.Tasks.Task`1[System.String] InternalReadContentAsStringAsync()
		/// </summary>
		protected RMethod r_RInternalReadContentAsStringAsync;
		public virtual RMethod RInternalReadContentAsStringAsync
		{
			get
			{
				if(r_RInternalReadContentAsStringAsync == null)
				{
					r_RInternalReadContentAsStringAsync = new(this, "InternalReadContentAsStringAsync", 0);
					r_RInternalReadContentAsStringAsync.SetBelong(this.instance);
				}
				return r_RInternalReadContentAsStringAsync;
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


        public RXmlTextReaderImpl() : base("System.Xml.XmlTextReaderImpl")
        {
        }

        public RXmlTextReaderImpl(System.Object instance) : base("System.Xml.XmlTextReaderImpl")
		{
            SetInstance(instance);
		}

        public RXmlTextReaderImpl(RMember belongMember, string name, int genericCount = -1, params Type[] types) : base(belongMember, name, genericCount, types)
	    {
	    }

		 public RXmlTextReaderImpl(Type belongType, string name, int genericCount = -1, params Type[] types) : base(belongType, name, genericCount, types)
	    {
	    }

        public virtual void FinishInitUriString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishInitUriString.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishInitStream()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishInitStream.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishInitTextReader()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishInitTextReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String GetAttribute(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetAttribute(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RGetAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String GetAttribute(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RGetAttribute_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean MoveToAttribute(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RMoveToAttribute_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToAttribute(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RMoveToAttribute_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void MoveToAttribute(System.Int32  @i)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@i};
            var ___result = RMoveToAttribute_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean MoveToFirstAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToFirstAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNextAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToNextAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void FinishInit()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishInit.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean Read()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RRead.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void Close()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RClose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Skip()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkip.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String LookupNamespace(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RLookupNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Boolean ReadAttributeValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadAttributeValue.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ResolveEntity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResolveEntity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void MoveOffEntityReference()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveOffEntityReference.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ReadString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Int32 ReadContentAsBase64(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadContentAsBinHex(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsBase64(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsBinHex(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadValueChunk(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadValueChunk_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean HasLineInfo()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RHasLineInfo.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Collections.Generic.IDictionary<System.String, System.String> System__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope(System.Xml.XmlNamespaceScope  @scope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scope};
            var ___result = RSystem__1__Xml__1__IXmlNamespaceResolver__1__GetNamespacesInScope_XmlNamespaceScope.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IDictionary<System.String, System.String>)___result;
        }


        public virtual System.String System__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace(System.String  @prefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@prefix};
            var ___result = RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupNamespace_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String System__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix(System.String  @namespaceName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namespaceName};
            var ___result = RSystem__1__Xml__1__IXmlNamespaceResolver__1__LookupPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Collections.Generic.IDictionary<System.String, System.String> GetNamespacesInScope(System.Xml.XmlNamespaceScope  @scope)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@scope};
            var ___result = RGetNamespacesInScope_XmlNamespaceScope.Invoke(___genericsType, ___parameters);

            return (System.Collections.Generic.IDictionary<System.String, System.String>)___result;
        }


        public virtual System.String LookupPrefix(System.String  @namespaceName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@namespaceName};
            var ___result = RLookupPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ResetState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.IO.TextReader GetRemainder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetRemainder.Invoke(___genericsType, ___parameters);

            return (System.IO.TextReader)___result;
        }


        public virtual System.Int32 ReadChars(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadChars_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadBase64(System.Byte[]  @array, System.Int32  @offset, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @len};
            var ___result = RReadBase64_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadBinHex(System.Byte[]  @array, System.Int32  @offset, System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @offset, @len};
            var ___result = RReadBinHex_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void DtdParserProxy_OnNewLine(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RDtdParserProxy_OnNewLine_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 DtdParserProxy_ReadData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDtdParserProxy_ReadData.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 DtdParserProxy_ParseNumericCharRef(System.Text.StringBuilder  @internalSubsetBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@internalSubsetBuilder};
            var ___result = RDtdParserProxy_ParseNumericCharRef_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 DtdParserProxy_ParseNamedCharRef(System.Boolean  @expand, System.Text.StringBuilder  @internalSubsetBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expand, @internalSubsetBuilder};
            var ___result = RDtdParserProxy_ParseNamedCharRef_Boolean_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void DtdParserProxy_ParsePI(System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = RDtdParserProxy_ParsePI_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DtdParserProxy_ParseComment(System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = RDtdParserProxy_ParseComment_StringBuilder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlResolver GetTempResolver()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetTempResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlResolver)___result;
        }




        public virtual System.Boolean DtdParserProxy_PushExternalSubset(System.String  @systemId, System.String  @publicId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@systemId, @publicId};
            var ___result = RDtdParserProxy_PushExternalSubset_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void DtdParserProxy_PushInternalDtd(System.String  @baseUri, System.String  @internalDtd)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @internalDtd};
            var ___result = RDtdParserProxy_PushInternalDtd_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void DtdParserProxy_Throw(System.Exception  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RDtdParserProxy_Throw_Exception.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void Throw(System.Int32  @pos, System.String  @res, System.String  @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @res, @arg};
            var ___result = RThrow_Int32_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.Int32  @pos, System.String  @res, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @res, @args};
            var ___result = RThrow_Int32_String_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.Int32  @pos, System.String  @res)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @res};
            var ___result = RThrow_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.String  @res)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res};
            var ___result = RThrow_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.String  @res, System.Int32  @lineNo, System.Int32  @linePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res, @lineNo, @linePos};
            var ___result = RThrow_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.String  @res, System.String  @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res, @arg};
            var ___result = RThrow_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.String  @res, System.String  @arg, System.Int32  @lineNo, System.Int32  @linePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res, @arg, @lineNo, @linePos};
            var ___result = RThrow_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.String  @res, System.String[]  @args)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res, @args};
            var ___result = RThrow_String_StringArray.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.String  @res, System.String  @arg, System.Exception  @innerException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res, @arg, @innerException};
            var ___result = RThrow_String_String_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.String  @res, System.String[]  @args, System.Exception  @innerException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res, @args, @innerException};
            var ___result = RThrow_String_StringArray_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Throw(System.Exception  @e)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e};
            var ___result = RThrow_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReThrow(System.Exception  @e, System.Int32  @lineNo, System.Int32  @linePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@e, @lineNo, @linePos};
            var ___result = RReThrow_Exception_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowWithoutLineInfo(System.String  @res)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res};
            var ___result = RThrowWithoutLineInfo_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowWithoutLineInfo(System.String  @res, System.String  @arg)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res, @arg};
            var ___result = RThrowWithoutLineInfo_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowWithoutLineInfo(System.String  @res, System.String[]  @args, System.Exception  @innerException)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@res, @args, @innerException};
            var ___result = RThrowWithoutLineInfo_String_StringArray_Exception.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowInvalidChar(System.Char[]  @data, System.Int32  @length, System.Int32  @invCharPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@data, @length, @invCharPos};
            var ___result = RThrowInvalidChar_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetErrorState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetErrorState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.Xml.Schema.XmlSeverityType  @severity, System.String  @code, System.String  @arg, System.Int32  @lineNo, System.Int32  @linePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@severity, @code, @arg, @lineNo, @linePos};
            var ___result = RSendValidationEvent_XmlSeverityType_String_String_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SendValidationEvent(System.Xml.Schema.XmlSeverityType  @severity, System.Xml.Schema.XmlSchemaException  @exception)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@severity, @exception};
            var ___result = RSendValidationEvent_XmlSeverityType_XmlSchemaException.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishAttributeValueIterator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishAttributeValueIterator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitStreamInput(System.IO.Stream  @stream, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stream, @encoding};
            var ___result = RInitStreamInput_Stream_Encoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitStreamInput(System.String  @baseUriStr, System.IO.Stream  @stream, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUriStr, @stream, @encoding};
            var ___result = RInitStreamInput_String_Stream_Encoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitStreamInput(System.Uri  @baseUri, System.IO.Stream  @stream, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @stream, @encoding};
            var ___result = RInitStreamInput_Uri_Stream_Encoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitStreamInput(System.Uri  @baseUri, System.String  @baseUriStr, System.IO.Stream  @stream, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @baseUriStr, @stream, @encoding};
            var ___result = RInitStreamInput_Uri_String_Stream_Encoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitStreamInput(System.Uri  @baseUri, System.String  @baseUriStr, System.IO.Stream  @stream, System.Byte[]  @bytes, System.Int32  @byteCount, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @baseUriStr, @stream, @bytes, @byteCount, @encoding};
            var ___result = RInitStreamInput_Uri_String_Stream_ByteArray_Int32_Encoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitTextReaderInput(System.String  @baseUriStr, System.IO.TextReader  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUriStr, @input};
            var ___result = RInitTextReaderInput_String_TextReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitTextReaderInput(System.String  @baseUriStr, System.Uri  @baseUri, System.IO.TextReader  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUriStr, @baseUri, @input};
            var ___result = RInitTextReaderInput_String_Uri_TextReader.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitStringInput(System.String  @baseUriStr, System.Text.Encoding  @originalEncoding, System.String  @str)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUriStr, @originalEncoding, @str};
            var ___result = RInitStringInput_String_Encoding_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitFragmentReader(System.Xml.XmlNodeType  @fragmentType, System.Xml.XmlParserContext  @parserContext, System.Boolean  @allowXmlDeclFragment)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@fragmentType, @parserContext, @allowXmlDeclFragment};
            var ___result = RInitFragmentReader_XmlNodeType_XmlParserContext_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ProcessDtdFromParserContext(System.Xml.XmlParserContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RProcessDtdFromParserContext_XmlParserContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenUrl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROpenUrl.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OpenUrlDelegate(System.Object  @xmlResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@xmlResolver};
            var ___result = ROpenUrlDelegate_Object.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.Encoding DetectEncoding()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDetectEncoding.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual void SetupEncoding(System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@encoding};
            var ___result = RSetupEncoding_Encoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwitchEncoding(System.Text.Encoding  @newEncoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newEncoding};
            var ___result = RSwitchEncoding_Encoding.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Text.Encoding CheckEncoding(System.String  @newEncodingName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newEncodingName};
            var ___result = RCheckEncoding_String.Invoke(___genericsType, ___parameters);

            return (System.Text.Encoding)___result;
        }


        public virtual void UnDecodeChars()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnDecodeChars.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SwitchEncodingToUTF8()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSwitchEncodingToUTF8.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 ReadData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadData.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetChars(System.Int32  @maxCharsCount)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@maxCharsCount};
            var ___result = RGetChars_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InvalidCharRecovery(ref System.Int32  @bytesCount, out System.Int32  @charsCount)
        {
			charsCount = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@bytesCount, @charsCount};
            var ___result = RInvalidCharRecovery_Ref_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			bytesCount = (System.Int32)___parameters[0];
			charsCount = (System.Int32)___parameters[1];

            
        }


        public virtual void Close(System.Boolean  @closeInput)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@closeInput};
            var ___result = RClose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ShiftBuffer(System.Int32  @sourcePos, System.Int32  @destPos, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sourcePos, @destPos, @count};
            var ___result = RShiftBuffer_Int32_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ParseXmlDeclaration(System.Boolean  @isTextDecl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isTextDecl};
            var ___result = RParseXmlDeclaration_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParseDocumentContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDocumentContent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParseElementContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseElementContent.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ThrowUnclosedElements()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RThrowUnclosedElements.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ParseElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AddDefaultAttributesAndNormalize()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAddDefaultAttributesAndNormalize.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ParseEndElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEndElement.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ParseAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ElementNamespaceLookup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RElementNamespaceLookup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AttributeNamespaceLookup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAttributeNamespaceLookup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void AttributeDuplCheck()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RAttributeDuplCheck.Invoke(___genericsType, ___parameters);

            
        }







        public virtual System.Boolean ParseText()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseText.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParseText(out System.Int32  @startPos, out System.Int32  @endPos, ref System.Int32  @outOrChars)
        {
			startPos = default;
			endPos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startPos, @endPos, @outOrChars};
            var ___result = RParseText_Out_Int32_Out_Int32_Ref_Int32.Invoke(___genericsType, ___parameters);
			startPos = (System.Int32)___parameters[0];
			endPos = (System.Int32)___parameters[1];
			outOrChars = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual void FinishPartialValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishPartialValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishOtherValueIterator()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishOtherValueIterator.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SkipPartialTextValue()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipPartialTextValue.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishReadValueChunk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishReadValueChunk.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishReadContentAsBinary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishReadContentAsBinary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FinishReadElementContentAsBinary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishReadElementContentAsBinary.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ParseRootLevelWhitespace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseRootLevelWhitespace.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ParseEntityReference()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEntityReference.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Object HandleGeneralEntityReference(System.String  @name, System.Boolean  @isInAttributeValue, System.Boolean  @pushFakeEntityIfNullResolver, System.Int32  @entityStartLinePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @isInAttributeValue, @pushFakeEntityIfNullResolver, @entityStartLinePos};
            var ___result = RHandleGeneralEntityReference_String_Boolean_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean HandleEntityEnd(System.Boolean  @checkEntityNesting)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@checkEntityNesting};
            var ___result = RHandleEntityEnd_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void SetupEndEntityNodeInContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetupEndEntityNodeInContent.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SetupEndEntityNodeInAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSetupEndEntityNodeInAttribute.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ParsePI()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParsePI.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParsePI(System.Text.StringBuilder  @piInDtdStringBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@piInDtdStringBuilder};
            var ___result = RParsePI_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParsePIValue(out System.Int32  @outStartPos, out System.Int32  @outEndPos)
        {
			outStartPos = default;
			outEndPos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outStartPos, @outEndPos};
            var ___result = RParsePIValue_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			outStartPos = (System.Int32)___parameters[0];
			outEndPos = (System.Int32)___parameters[1];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParseComment()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseComment.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ParseCData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseCData.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ParseCDataOrComment(System.Xml.XmlNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RParseCDataOrComment_XmlNodeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ParseCDataOrComment(System.Xml.XmlNodeType  @type, out System.Int32  @outStartPos, out System.Int32  @outEndPos)
        {
			outStartPos = default;
			outEndPos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type, @outStartPos, @outEndPos};
            var ___result = RParseCDataOrComment_XmlNodeType_Out_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			outStartPos = (System.Int32)___parameters[1];
			outEndPos = (System.Int32)___parameters[2];

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParseDoctypeDecl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDoctypeDecl.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ParseDtd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDtd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SkipDtd()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipDtd.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SkipPublicOrSystemIdLiteral()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipPublicOrSystemIdLiteral.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void SkipUntil(System.Char  @stopChar, System.Boolean  @recognizeLiterals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stopChar, @recognizeLiterals};
            var ___result = RSkipUntil_Char_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 EatWhitespaces(System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = REatWhitespaces_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }





        public virtual System.Int32 ParseNamedCharRef(System.Boolean  @expand, System.Text.StringBuilder  @internalSubsetBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expand, @internalSubsetBuilder};
            var ___result = RParseNamedCharRef_Boolean_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ParseNamedCharRefInline(System.Int32  @startPos, System.Boolean  @expand, System.Text.StringBuilder  @internalSubsetBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@startPos, @expand, @internalSubsetBuilder};
            var ___result = RParseNamedCharRefInline_Int32_Boolean_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ParseName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseName.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ParseQName(out System.Int32  @colonPos)
        {
			colonPos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colonPos};
            var ___result = RParseQName_Out_Int32.Invoke(___genericsType, ___parameters);
			colonPos = (System.Int32)___parameters[0];

            return (System.Int32)___result;
        }


        public virtual System.Int32 ParseQName(System.Boolean  @isQName, System.Int32  @startOffset, out System.Int32  @colonPos)
        {
			colonPos = default;

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isQName, @startOffset, @colonPos};
            var ___result = RParseQName_Boolean_Int32_Out_Int32.Invoke(___genericsType, ___parameters);
			colonPos = (System.Int32)___parameters[2];

            return (System.Int32)___result;
        }


        public virtual System.Boolean ReadDataInName(ref System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RReadDataInName_Ref_Int32.Invoke(___genericsType, ___parameters);
			pos = (System.Int32)___parameters[0];

            return (System.Boolean)___result;
        }


        public virtual System.String ParseEntityName()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEntityName.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object AddNode(System.Int32  @nodeIndex, System.Int32  @nodeDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nodeIndex, @nodeDepth};
            var ___result = RAddNode_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AllocNode(System.Int32  @nodeIndex, System.Int32  @nodeDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@nodeIndex, @nodeDepth};
            var ___result = RAllocNode_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AddAttributeNoChecks(System.String  @name, System.Int32  @attrDepth)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @attrDepth};
            var ___result = RAddAttributeNoChecks_String_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AddAttribute(System.Int32  @endNamePos, System.Int32  @colonPos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@endNamePos, @colonPos};
            var ___result = RAddAttribute_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object AddAttribute(System.String  @localName, System.String  @prefix, System.String  @nameWPrefix)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @prefix, @nameWPrefix};
            var ___result = RAddAttribute_String_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual void PopElementContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopElementContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnNewLine(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = ROnNewLine_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void OnEof()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = ROnEof.Invoke(___genericsType, ___parameters);

            
        }




        public virtual void ResetAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RResetAttributes.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void FullAttributeCleanup()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFullAttributeCleanup.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PushXmlContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPushXmlContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopXmlContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopXmlContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlNodeType GetWhitespaceType()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetWhitespaceType.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeType)___result;
        }


        public virtual System.Xml.XmlNodeType GetTextNodeType(System.Int32  @orChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@orChars};
            var ___result = RGetTextNodeType_Int32.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeType)___result;
        }


        public virtual void PushExternalEntityOrSubset(System.String  @publicId, System.String  @systemId, System.Uri  @baseUri, System.String  @entityName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicId, @systemId, @baseUri, @entityName};
            var ___result = RPushExternalEntityOrSubset_String_String_Uri_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean OpenAndPush(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = ROpenAndPush_Uri.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }




        public virtual void PopEntity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopEntity.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void UnregisterEntity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RUnregisterEntity.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PushParsingState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPushParsingState.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void PopParsingState()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RPopParsingState.Invoke(___genericsType, ___parameters);

            
        }



        public virtual System.Int32 IncrementalRead(System.Array  @array, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@array, @index, @count};
            var ___result = RIncrementalRead_Array_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 IncrementalRead()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIncrementalRead.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void FinishIncrementalRead()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishIncrementalRead.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean ParseFragmentAttribute()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseFragmentAttribute.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ParseAttributeValueChunk()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseAttributeValueChunk.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ParseXmlDeclarationFragment()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseXmlDeclarationFragment.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowUnexpectedToken(System.Int32  @pos, System.String  @expectedToken)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @expectedToken};
            var ___result = RThrowUnexpectedToken_Int32_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowUnexpectedToken(System.String  @expectedToken1)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expectedToken1};
            var ___result = RThrowUnexpectedToken_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowUnexpectedToken(System.Int32  @pos, System.String  @expectedToken1, System.String  @expectedToken2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @expectedToken1, @expectedToken2};
            var ___result = RThrowUnexpectedToken_Int32_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ThrowUnexpectedToken(System.String  @expectedToken1, System.String  @expectedToken2)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expectedToken1, @expectedToken2};
            var ___result = RThrowUnexpectedToken_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ParseUnexpectedToken(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RParseUnexpectedToken_Int32.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ParseUnexpectedToken()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseUnexpectedToken.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ThrowExpectingWhitespace(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RThrowExpectingWhitespace_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Int32 GetIndexOfAttributeWithoutPrefix(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetIndexOfAttributeWithoutPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 GetIndexOfAttributeWithPrefix(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RGetIndexOfAttributeWithPrefix_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Boolean ZeroEndingStream(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RZeroEndingStream_Int32.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void ParseDtdFromParserContext()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDtdFromParserContext.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean InitReadContentAsBinary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitReadContentAsBinary.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean InitReadElementContentAsBinary()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitReadElementContentAsBinary.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean MoveToNextContentNode(System.Boolean  @moveIfOnContentNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moveIfOnContentNode};
            var ___result = RMoveToNextContentNode_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }



        public virtual void SetupFromParserContext(System.Xml.XmlParserContext  @context, System.Xml.XmlReaderSettings  @settings)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context, @settings};
            var ___result = RSetupFromParserContext_XmlParserContext_XmlReaderSettings.Invoke(___genericsType, ___parameters);

            
        }



        public virtual void ChangeCurrentNodeType(System.Xml.XmlNodeType  @newNodeType)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newNodeType};
            var ___result = RChangeCurrentNodeType_XmlNodeType.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Xml.XmlResolver GetResolver()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetResolver.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlResolver)___result;
        }




        public virtual System.Object AddDefaultAttributeInternal(System.String  @localName, System.String  @ns, System.String  @prefix, System.String  @value, System.Int32  @lineNo, System.Int32  @linePos, System.Int32  @valueLineNo, System.Int32  @valueLinePos, System.Boolean  @isXmlAttribute)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @ns, @prefix, @value, @lineNo, @linePos, @valueLineNo, @valueLinePos, @isXmlAttribute};
            var ___result = RAddDefaultAttributeInternal_String_String_String_String_Int32_Int32_Int32_Int32_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Int32 ReadContentAsBinary(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinary_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsBinary(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinary_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual void InitBase64Decoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitBase64Decoder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void InitBinHexDecoder()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitBinHexDecoder.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean UriEqual(System.Uri  @uri1, System.String  @uri1Str, System.String  @uri2Str, System.Xml.XmlResolver  @resolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri1, @uri1Str, @uri2Str, @resolver};
            var ___result = RUriEqual_Uri_String_String_XmlResolver.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual void RegisterConsumedCharacters(System.Int64  @characters, System.Boolean  @inEntityReference)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@characters, @inEntityReference};
            var ___result = RRegisterConsumedCharacters_Int64_Boolean.Invoke(___genericsType, ___parameters);

            
        }





        public static System.String StripSpaces(System.String  @value)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value};
            var ___result = RStripSpaces_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public static void StripSpaces(System.Char[]  @value, System.Int32  @index, ref System.Int32  @len)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@value, @index, @len};
            var ___result = RStripSpaces_CharArray_Int32_Ref_Int32.Invoke(___genericsType, ___parameters);
			len = (System.Int32)___parameters[2];

            
        }


        public static void BlockCopyChars(System.Char[]  @src, System.Int32  @srcOffset, System.Char[]  @dst, System.Int32  @dstOffset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcOffset, @dst, @dstOffset, @count};
            var ___result = RBlockCopyChars_CharArray_Int32_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public static void BlockCopy(System.Byte[]  @src, System.Int32  @srcOffset, System.Byte[]  @dst, System.Int32  @dstOffset, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@src, @srcOffset, @dst, @dstOffset, @count};
            var ___result = RBlockCopy_ByteArray_Int32_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckAsyncCall()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCheckAsyncCall.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Threading.Tasks.Task<System.String> GetValueAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RGetValueAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> _GetValueAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_GetValueAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task FinishInitAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishInitAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FinishInitUriStringAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishInitUriStringAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FinishInitStreamAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishInitStreamAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FinishInitTextReaderAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishInitTextReaderAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ReadAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ReadAsync_SwitchToInteractiveXmlDecl()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadAsync_SwitchToInteractiveXmlDecl.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> _ReadAsync_SwitchToInteractiveXmlDecl(System.Threading.Tasks.Task<System.Boolean>  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = R_ReadAsync_SwitchToInteractiveXmlDecl_Task_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ReadAsync_SwitchToInteractiveXmlDecl_Helper(System.Boolean  @finish)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@finish};
            var ___result = RReadAsync_SwitchToInteractiveXmlDecl_Helper_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task SkipAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBase64_AsyncHelper(System.Threading.Tasks.Task<System.Boolean>  @task, System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @buffer, @index, @count};
            var ___result = RReadContentAsBase64_AsyncHelper_Task_d_Boolean_p__ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBase64Async(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBase64Async_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBinHexAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinHexAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBase64Async_Helper(System.Threading.Tasks.Task<System.Boolean>  @task, System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task, @buffer, @index, @count};
            var ___result = RReadElementContentAsBase64Async_Helper_Task_d_Boolean_p__ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBase64Async(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBase64Async_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBinHexAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinHexAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadValueChunkAsync(System.Char[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadValueChunkAsync_CharArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> DtdParserProxy_ReadDataAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDtdParserProxy_ReadDataAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> DtdParserProxy_ParseNumericCharRefAsync(System.Text.StringBuilder  @internalSubsetBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@internalSubsetBuilder};
            var ___result = RDtdParserProxy_ParseNumericCharRefAsync_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> DtdParserProxy_ParseNamedCharRefAsync(System.Boolean  @expand, System.Text.StringBuilder  @internalSubsetBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expand, @internalSubsetBuilder};
            var ___result = RDtdParserProxy_ParseNamedCharRefAsync_Boolean_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task DtdParserProxy_ParsePIAsync(System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = RDtdParserProxy_ParsePIAsync_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task DtdParserProxy_ParseCommentAsync(System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = RDtdParserProxy_ParseCommentAsync_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }



        public virtual System.Threading.Tasks.Task<System.Boolean> DtdParserProxy_PushExternalSubsetAsync(System.String  @systemId, System.String  @publicId)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@systemId, @publicId};
            var ___result = RDtdParserProxy_PushExternalSubsetAsync_String_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task InitStreamInputAsync(System.Uri  @baseUri, System.IO.Stream  @stream, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @stream, @encoding};
            var ___result = RInitStreamInputAsync_Uri_Stream_Encoding.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task InitStreamInputAsync(System.Uri  @baseUri, System.String  @baseUriStr, System.IO.Stream  @stream, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @baseUriStr, @stream, @encoding};
            var ___result = RInitStreamInputAsync_Uri_String_Stream_Encoding.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task InitStreamInputAsync(System.Uri  @baseUri, System.String  @baseUriStr, System.IO.Stream  @stream, System.Byte[]  @bytes, System.Int32  @byteCount, System.Text.Encoding  @encoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUri, @baseUriStr, @stream, @bytes, @byteCount, @encoding};
            var ___result = RInitStreamInputAsync_Uri_String_Stream_ByteArray_Int32_Encoding.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task InitTextReaderInputAsync(System.String  @baseUriStr, System.IO.TextReader  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUriStr, @input};
            var ___result = RInitTextReaderInputAsync_String_TextReader.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task InitTextReaderInputAsync(System.String  @baseUriStr, System.Uri  @baseUri, System.IO.TextReader  @input)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@baseUriStr, @baseUri, @input};
            var ___result = RInitTextReaderInputAsync_String_Uri_TextReader.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ProcessDtdFromParserContextAsync(System.Xml.XmlParserContext  @context)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@context};
            var ___result = RProcessDtdFromParserContextAsync_XmlParserContext.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task SwitchEncodingAsync(System.Text.Encoding  @newEncoding)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@newEncoding};
            var ___result = RSwitchEncodingAsync_Encoding.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task SwitchEncodingToUTF8Async()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSwitchEncodingToUTF8Async.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadDataAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadDataAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseXmlDeclarationAsync(System.Boolean  @isTextDecl)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isTextDecl};
            var ___result = RParseXmlDeclarationAsync_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseDocumentContentAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDocumentContentAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseDocumentContentAsync_CData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDocumentContentAsync_CData.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseDocumentContentAsync_ParseEntity()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDocumentContentAsync_ParseEntity.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseDocumentContentAsync_WhiteSpace()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDocumentContentAsync_WhiteSpace.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> _ParseDocumentContentAsync_WhiteSpace(System.Threading.Tasks.Task<System.Boolean>  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = R_ParseDocumentContentAsync_WhiteSpace_Task_d_Boolean_p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseDocumentContentAsync_ReadData(System.Boolean  @needMoreChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@needMoreChars};
            var ___result = RParseDocumentContentAsync_ReadData_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseElementContentAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseElementContentAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseElementContent_ReadData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseElementContent_ReadData.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task ParseElementAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseElementAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ParseElementAsync_ContinueWithSetElement(System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32>>  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task _ParseElementAsync_ContinueWithSetElement(System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32>>  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = R_ParseElementAsync_ContinueWithSetElement_Task_d_Tuple_d_Int32_Int32_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ParseElementAsync_SetElement(System.Int32  @colonPos, System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@colonPos, @pos};
            var ___result = RParseElementAsync_SetElement_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ParseElementAsync_NoAttributes()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseElementAsync_NoAttributes.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ParseElementAsync_ReadData(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RParseElementAsync_ReadData_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ParseEndElementAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEndElementAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task _ParseEndElmentAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = R_ParseEndElmentAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ParseEndElmentAsync_PrepareData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEndElmentAsync_PrepareData.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ParseEndElementAsync_CheckNameAndParse()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEndElementAsync_CheckNameAndParse.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }





        public virtual System.Threading.Tasks.Task ParseEndElementAsync_ReadData()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEndElementAsync_ReadData.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }



        public virtual System.Threading.Tasks.Task ParseAttributesAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseAttributesAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }



        public virtual System.Threading.Tasks.Task<System.Boolean> ParseTextAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseTextAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> _ParseTextAsync(System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>  @parseTask)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@parseTask};
            var ___result = R_ParseTextAsync_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseTextAsync_IgnoreNode()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseTextAsync_IgnoreNode.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>> ParseTextAsync(System.Int32  @outOrChars)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outOrChars};
            var ___result = RParseTextAsync_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>> ParseTextAsync_AsyncFunc(System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>  @task)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@task};
            var ___result = RParseTextAsync_AsyncFunc_Task_d_Tuple_d_Int32_Int32_Int32_Boolean_p__p_.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>> ParseTextAsync(System.Int32  @outOrChars, System.Char[]  @chars, System.Int32  @pos, System.Int32  @rcount, System.Int32  @rpos, System.Int32  @orChars, System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outOrChars, @chars, @pos, @rcount, @rpos, @orChars, @c};
            var ___result = RParseTextAsync_Int32_CharArray_Int32_Int32_Int32_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>> ParseTextAsync_ParseEntity(System.Int32  @outOrChars, System.Char[]  @chars, System.Int32  @pos, System.Int32  @rcount, System.Int32  @rpos, System.Int32  @orChars, System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outOrChars, @chars, @pos, @rcount, @rpos, @orChars, @c};
            var ___result = RParseTextAsync_ParseEntity_Int32_CharArray_Int32_Int32_Int32_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>> ParseTextAsync_Surrogate(System.Int32  @outOrChars, System.Char[]  @chars, System.Int32  @pos, System.Int32  @rcount, System.Int32  @rpos, System.Int32  @orChars, System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outOrChars, @chars, @pos, @rcount, @rpos, @orChars, @c};
            var ___result = RParseTextAsync_Surrogate_Int32_CharArray_Int32_Int32_Int32_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>> ParseTextAsync_ReadData(System.Int32  @outOrChars, System.Char[]  @chars, System.Int32  @pos, System.Int32  @rcount, System.Int32  @rpos, System.Int32  @orChars, System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outOrChars, @chars, @pos, @rcount, @rpos, @orChars, @c};
            var ___result = RParseTextAsync_ReadData_Int32_CharArray_Int32_Int32_Int32_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>> ParseTextAsync_NoValue(System.Int32  @outOrChars, System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@outOrChars, @pos};
            var ___result = RParseTextAsync_NoValue_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>> ParseTextAsync_PartialValue(System.Int32  @pos, System.Int32  @rcount, System.Int32  @rpos, System.Int32  @orChars, System.Char  @c)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos, @rcount, @rpos, @orChars, @c};
            var ___result = RParseTextAsync_PartialValue_Int32_Int32_Int32_Int32_Char.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task FinishPartialValueAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishPartialValueAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FinishOtherValueIteratorAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishOtherValueIteratorAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task SkipPartialTextValueAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipPartialTextValueAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FinishReadValueChunkAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishReadValueChunkAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FinishReadContentAsBinaryAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishReadContentAsBinaryAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task FinishReadElementContentAsBinaryAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RFinishReadElementContentAsBinaryAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseRootLevelWhitespaceAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseRootLevelWhitespaceAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task ParseEntityReferenceAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEntityReferenceAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }



        public virtual System.Object HandleGeneralEntityReferenceAsync(System.String  @name, System.Boolean  @isInAttributeValue, System.Boolean  @pushFakeEntityIfNullResolver, System.Int32  @entityStartLinePos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name, @isInAttributeValue, @pushFakeEntityIfNullResolver, @entityStartLinePos};
            var ___result = RHandleGeneralEntityReferenceAsync_String_Boolean_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParsePIAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParsePIAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParsePIAsync(System.Text.StringBuilder  @piInDtdStringBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@piInDtdStringBuilder};
            var ___result = RParsePIAsync_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Boolean>> ParsePIValueAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParsePIValueAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseCommentAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseCommentAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task ParseCDataAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseCDataAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task ParseCDataOrCommentAsync(System.Xml.XmlNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RParseCDataOrCommentAsync_XmlNodeType.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Boolean>> ParseCDataOrCommentTupleAsync(System.Xml.XmlNodeType  @type)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@type};
            var ___result = RParseCDataOrCommentTupleAsync_XmlNodeType.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> ParseDoctypeDeclAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDoctypeDeclAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task ParseDtdAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDtdAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task SkipDtdAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipDtdAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task SkipPublicOrSystemIdLiteralAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RSkipPublicOrSystemIdLiteralAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task SkipUntilAsync(System.Char  @stopChar, System.Boolean  @recognizeLiterals)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@stopChar, @recognizeLiterals};
            var ___result = RSkipUntilAsync_Char_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> EatWhitespacesAsync(System.Text.StringBuilder  @sb)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@sb};
            var ___result = REatWhitespacesAsync_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Object ParseNumericCharRefAsync(System.Boolean  @expand, System.Text.StringBuilder  @internalSubsetBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expand, @internalSubsetBuilder};
            var ___result = RParseNumericCharRefAsync_Boolean_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ParseNamedCharRefAsync(System.Boolean  @expand, System.Text.StringBuilder  @internalSubsetBuilder)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@expand, @internalSubsetBuilder};
            var ___result = RParseNamedCharRefAsync_Boolean_StringBuilder.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ParseNameAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseNameAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32>> ParseQNameAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseQNameAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32>> ParseQNameAsync(System.Boolean  @isQName, System.Int32  @startOffset)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@isQName, @startOffset};
            var ___result = RParseQNameAsync_Boolean_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Int32>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Boolean>> ReadDataInNameAsync(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RReadDataInNameAsync_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Tuple<System.Int32, System.Boolean>>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ParseEntityNameAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseEntityNameAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task PushExternalEntityOrSubsetAsync(System.String  @publicId, System.String  @systemId, System.Uri  @baseUri, System.String  @entityName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@publicId, @systemId, @baseUri, @entityName};
            var ___result = RPushExternalEntityOrSubsetAsync_String_String_Uri_String.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> OpenAndPushAsync(System.Uri  @uri)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@uri};
            var ___result = ROpenAndPushAsync_Uri.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }



        public virtual System.Threading.Tasks.Task<System.Boolean> ZeroEndingStreamAsync(System.Int32  @pos)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@pos};
            var ___result = RZeroEndingStreamAsync_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task ParseDtdFromParserContextAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RParseDtdFromParserContextAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> InitReadContentAsBinaryAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitReadContentAsBinaryAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> InitReadElementContentAsBinaryAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInitReadElementContentAsBinaryAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Boolean> MoveToNextContentNodeAsync(System.Boolean  @moveIfOnContentNode)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@moveIfOnContentNode};
            var ___result = RMoveToNextContentNodeAsync_Boolean.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Boolean>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadContentAsBinaryAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadContentAsBinaryAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Int32> ReadElementContentAsBinaryAsync(System.Byte[]  @buffer, System.Int32  @index, System.Int32  @count)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@buffer, @index, @count};
            var ___result = RReadElementContentAsBinaryAsync_ByteArray_Int32_Int32.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Int32>)___result;
        }


        public virtual System.Object ReadContentAsObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsObject.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean ReadContentAsBoolean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsBoolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.DateTime ReadContentAsDateTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsDateTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTimeOffset ReadContentAsDateTimeOffset()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsDateTimeOffset.Invoke(___genericsType, ___parameters);

            return (System.DateTimeOffset)___result;
        }


        public virtual System.Double ReadContentAsDouble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsDouble.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Single ReadContentAsFloat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsFloat.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Decimal ReadContentAsDecimal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsDecimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Int32 ReadContentAsInt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsInt.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 ReadContentAsLong()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsLong.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.String ReadContentAsString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object ReadContentAs(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver};
            var ___result = RReadContentAs_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ReadElementContentAsObject()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsObject.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ReadElementContentAsObject(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsObject_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Boolean ReadElementContentAsBoolean()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsBoolean.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadElementContentAsBoolean(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsBoolean_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.DateTime ReadElementContentAsDateTime()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsDateTime.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.DateTime ReadElementContentAsDateTime(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsDateTime_String_String.Invoke(___genericsType, ___parameters);

            return (System.DateTime)___result;
        }


        public virtual System.Double ReadElementContentAsDouble()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsDouble.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Double ReadElementContentAsDouble(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsDouble_String_String.Invoke(___genericsType, ___parameters);

            return (System.Double)___result;
        }


        public virtual System.Single ReadElementContentAsFloat()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsFloat.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Single ReadElementContentAsFloat(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsFloat_String_String.Invoke(___genericsType, ___parameters);

            return (System.Single)___result;
        }


        public virtual System.Decimal ReadElementContentAsDecimal()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsDecimal.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Decimal ReadElementContentAsDecimal(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsDecimal_String_String.Invoke(___genericsType, ___parameters);

            return (System.Decimal)___result;
        }


        public virtual System.Int32 ReadElementContentAsInt()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsInt.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int32 ReadElementContentAsInt(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsInt_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int32)___result;
        }


        public virtual System.Int64 ReadElementContentAsLong()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsLong.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.Int64 ReadElementContentAsLong(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsLong_String_String.Invoke(___genericsType, ___parameters);

            return (System.Int64)___result;
        }


        public virtual System.String ReadElementContentAsString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadElementContentAsString(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadElementContentAsString_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Object ReadElementContentAs(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver};
            var ___result = RReadElementContentAs_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Object ReadElementContentAs(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver, System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver, @localName, @namespaceURI};
            var ___result = RReadElementContentAs_Type_IXmlNamespaceResolver_String_String.Invoke(___genericsType, ___parameters);

            return (System.Object)___result;
        }


        public virtual System.Xml.XmlNodeType MoveToContent()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToContent.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlNodeType)___result;
        }


        public virtual void ReadStartElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadStartElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadStartElement(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadStartElement_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void ReadStartElement(System.String  @localname, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @ns};
            var ___result = RReadStartElement_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.String ReadElementString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadElementString(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadElementString_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadElementString(System.String  @localname, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @ns};
            var ___result = RReadElementString_String_String.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual void ReadEndElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadEndElement.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Boolean IsStartElement()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RIsStartElement.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStartElement(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RIsStartElement_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean IsStartElement(System.String  @localname, System.String  @ns)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localname, @ns};
            var ___result = RIsStartElement_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToFollowing(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadToFollowing_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToFollowing(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadToFollowing_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToDescendant(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadToDescendant_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToDescendant(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadToDescendant_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToNextSibling(System.String  @name)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@name};
            var ___result = RReadToNextSibling_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.Boolean ReadToNextSibling(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RReadToNextSibling_String_String.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String ReadInnerXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadInnerXml.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.String ReadOuterXml()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadOuterXml.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Xml.XmlReader ReadSubtree()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadSubtree.Invoke(___genericsType, ___parameters);

            return (System.Xml.XmlReader)___result;
        }


        public virtual void Dispose()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RDispose.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void Dispose(System.Boolean  @disposing)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@disposing};
            var ___result = RDispose_Boolean.Invoke(___genericsType, ___parameters);

            
        }


        public virtual void CheckElement(System.String  @localName, System.String  @namespaceURI)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@localName, @namespaceURI};
            var ___result = RCheckElement_String_String.Invoke(___genericsType, ___parameters);

            
        }


        public virtual System.Exception CreateReadContentAsException(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCreateReadContentAsException_String.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Exception CreateReadElementContentAsException(System.String  @methodName)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@methodName};
            var ___result = RCreateReadElementContentAsException_String.Invoke(___genericsType, ___parameters);

            return (System.Exception)___result;
        }


        public virtual System.Boolean CanReadContentAs()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RCanReadContentAs.Invoke(___genericsType, ___parameters);

            return (System.Boolean)___result;
        }


        public virtual System.String InternalReadContentAsString()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalReadContentAsString.Invoke(___genericsType, ___parameters);

            return (System.String)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> ReadContentAsObjectAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsObjectAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadContentAsStringAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadContentAsStringAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> ReadContentAsAsync(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver};
            var ___result = RReadContentAsAsync_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> ReadElementContentAsObjectAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsObjectAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadElementContentAsStringAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadElementContentAsStringAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Object> ReadElementContentAsAsync(System.Type  @returnType, System.Xml.IXmlNamespaceResolver  @namespaceResolver)
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{@returnType, @namespaceResolver};
            var ___result = RReadElementContentAsAsync_Type_IXmlNamespaceResolver.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Object>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.Xml.XmlNodeType> MoveToContentAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RMoveToContentAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.Xml.XmlNodeType>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadInnerXmlAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadInnerXmlAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> ReadOuterXmlAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RReadOuterXmlAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
        }


        public virtual System.Threading.Tasks.Task<System.String> InternalReadContentAsStringAsync()
        {

            var ___genericsType = new Type[] {};
            var ___parameters = new object[]{};
            var ___result = RInternalReadContentAsStringAsync.Invoke(___genericsType, ___parameters);

            return (System.Threading.Tasks.Task<System.String>)___result;
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
