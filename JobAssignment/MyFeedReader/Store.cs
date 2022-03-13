using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MyFeedReader
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.wallashops.co.il/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://www.wallashops.co.il/", IsNullable = false)]
    public partial class STORE
    {

        private STOREPRODUCT[] pRODUCTSField;

        private string uRLField;

        private string dATEField;

        private string tIMEField;

        private string nAMEField;

        private string sTATUSField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PRODUCT", IsNullable = false)]
        public STOREPRODUCT[] PRODUCTS
        {
            get { return this.pRODUCTSField; }
            set { this.pRODUCTSField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URL
        {
            get { return this.uRLField; }
            set { this.uRLField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DATE
        {
            get { return this.dATEField; }
            set { this.dATEField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TIME
        {
            get { return this.tIMEField; }
            set { this.tIMEField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NAME
        {
            get { return this.nAMEField; }
            set { this.nAMEField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string STATUS
        {
            get { return this.sTATUSField; }
            set { this.sTATUSField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        public void PrintNumberOfProductsInFeed()
        {
            Console.WriteLine($"The number of products in the feed are {this.PRODUCTS.Length} {Environment.NewLine}");
        }

        public void PrintTheMostExpensiveProductDetails()
        {
            var mostExpensiveProduct = PRODUCTS.OrderByDescending(STOREPRODUCT => STOREPRODUCT.PRICE).First();
            Console.WriteLine($"Details of The most expensive product:{Environment.NewLine}");
            Console.WriteLine($"Name: {mostExpensiveProduct.PRODUCT_NAME}");
            Console.WriteLine($"URL field: {mostExpensiveProduct.PRODUCT_URL}");
            Console.WriteLine($"Main category: {mostExpensiveProduct.MAIN_CATEGORY}");
            Console.WriteLine($"Category: {mostExpensiveProduct.CATEGORY}");
            Console.WriteLine($"Model: {mostExpensiveProduct.MODEL}");
            Console.WriteLine($"details: {mostExpensiveProduct.DETAILS}");
            Console.WriteLine($"Catalog number: {mostExpensiveProduct.CATALOG_NUMBER}");
            Console.WriteLine($"Product code: {mostExpensiveProduct.PRODUCTCODE}");
            Console.WriteLine($"Currency: {mostExpensiveProduct.CURRENCY}");
            Console.WriteLine($"Price: {mostExpensiveProduct.PRICE}");
            Console.WriteLine($"Shipment cost: {mostExpensiveProduct.SHIPMENT_COST}");
            Console.WriteLine($"Delivery time: {mostExpensiveProduct.DELIVERY_TIME}");
            Console.WriteLine($"Manufacturer: {mostExpensiveProduct.MANUFACTURER}");
            Console.WriteLine($"Image: {mostExpensiveProduct.IMAGE}");
            Console.WriteLine($"Warranty: {mostExpensiveProduct.WARRANTY}");
            Console.WriteLine($"Tax: {mostExpensiveProduct.TAX}");
        }
    }
}
