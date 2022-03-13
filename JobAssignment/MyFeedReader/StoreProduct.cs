using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFeedReader
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.wallashops.co.il/")]
    public partial class STOREPRODUCT
    {

        private string pRODUCT_URLField;

        private string pRODUCT_NAMEField;

        private string mAIN_CATEGORYField;

        private string cATEGORYField;

        private string mODELField;

        private string dETAILSField;

        private string cATALOG_NUMBERField;

        private uint pRODUCTCODEField;

        private string cURRENCYField;

        private ushort pRICEField;

        private ushort sHIPMENT_COSTField;

        private ushort dELIVERY_TIMEField;

        private string mANUFACTURERField;

        private string iMAGEField;

        private string wARRANTYField;

        private string tAXField;

        /// <remarks/>
        public string PRODUCT_URL
        {
            get { return this.pRODUCT_URLField; }
            set { this.pRODUCT_URLField = value; }
        }

        /// <remarks/>
        public string PRODUCT_NAME
        {
            get { return this.pRODUCT_NAMEField; }
            set { this.pRODUCT_NAMEField = value; }
        }

        /// <remarks/>
        public string MAIN_CATEGORY
        {
            get { return this.mAIN_CATEGORYField; }
            set { this.mAIN_CATEGORYField = value; }
        }

        /// <remarks/>
        public string CATEGORY
        {
            get { return this.cATEGORYField; }
            set { this.cATEGORYField = value; }
        }

        /// <remarks/>
        public string MODEL
        {
            get { return this.mODELField; }
            set { this.mODELField = value; }
        }

        /// <remarks/>
        public string DETAILS
        {
            get { return this.dETAILSField; }
            set { this.dETAILSField = value; }
        }

        /// <remarks/>
        public string CATALOG_NUMBER
        {
            get { return this.cATALOG_NUMBERField; }
            set { this.cATALOG_NUMBERField = value; }
        }

        /// <remarks/>
        public uint PRODUCTCODE
        {
            get { return this.pRODUCTCODEField; }
            set { this.pRODUCTCODEField = value; }
        }

        /// <remarks/>
        public string CURRENCY
        {
            get { return this.cURRENCYField; }
            set { this.cURRENCYField = value; }
        }

        /// <remarks/>
        public ushort PRICE
        {
            get { return this.pRICEField; }
            set { this.pRICEField = value; }
        }

        /// <remarks/>
        public ushort SHIPMENT_COST
        {
            get { return this.sHIPMENT_COSTField; }
            set { this.sHIPMENT_COSTField = value; }
        }

        /// <remarks/>
        public ushort DELIVERY_TIME
        {
            get { return this.dELIVERY_TIMEField; }
            set { this.dELIVERY_TIMEField = value; }
        }

        /// <remarks/>
        public string MANUFACTURER
        {
            get { return this.mANUFACTURERField; }
            set { this.mANUFACTURERField = value; }
        }

        /// <remarks/>
        public string IMAGE
        {
            get { return this.iMAGEField; }
            set { this.iMAGEField = value; }
        }

        /// <remarks/>
        public string WARRANTY
        {
            get { return this.wARRANTYField; }
            set { this.wARRANTYField = value; }
        }

        /// <remarks/>
        public string TAX
        {
            get { return this.tAXField; }
            set { this.tAXField = value; }
        }
    }
}
