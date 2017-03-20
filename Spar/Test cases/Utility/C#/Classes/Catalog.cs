/*
 * Created by Ranorex
 * User: sabinam
 * Date: 24. 02. 2017
 * Time: 10:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Spar.Test_cases.Utility.C_.Classes
{
	/// <summary>
	/// Description of Catalog.
	/// </summary>
	/// 
	[DataContract]
	public class CatalogList
	{
		public CatalogList(){}
		
		[DataMember]
		public List<Catalog> catalogs {get; set;}
		
	}
	
	[DataContract]
	public class Catalog
	{
		public Catalog(){}
		
		[DataMember]
		public int id {get; set;}
		
		[DataMember]
		public string title {get; set;}
		
		[DataMember]
		public string startDate {get; set;}
		
		[DataMember]
		public string endDate {get; set;}
		
		[DataMember]
		public string image {get; set;}
		
		[DataMember]
		public List<Category> categories {get; set;}
	}
	
	[DataContract]
	public class Category
	{
		public Category(){}
		public Category(int id, string title, List<Item> items)
		{
			this.id = id;
			this.title = title;
			this.items = items;
		}
		
		[DataMember]
		public int id {get; set;}
		
		[DataMember]
		public string title {get; set;}
		
		[DataMember]
		public List<Item> items  {get; set;}
		
	}
	
	[DataContract]
	public class Item
	{
		public Item(){}
		
		[DataMember]
		public int id {get; set;}
		
		[DataMember]
		public string promoPicture {get; set;}
		
		[DataMember]
		public string promoTitle {get; set;}
		
		[DataMember]
		public string promoDescription {get; set;}
		
		[DataMember]
		public PromoPrice promoPrice {get; set;}
		
		[DataMember]
		public string promoPercentage {get; set;}
		
		[DataMember]
		public string promoPrefix {get; set;}
		
		[DataMember(IsRequired=false)]
		public string promoHighlight {get; set;}
		
		[DataMember(IsRequired=false)]
		public string promoMainRow1 {get; set;}
		
		[DataMember(IsRequired=false)]
		public bool promoMainRow1Striked {get; set;}
		
		[DataMember(IsRequired=false)]
		public string promoMainRow2 {get; set;}
		
		[DataMember(IsRequired=false)]
		public bool promoMainRow2Striked {get; set;}
		
		[DataMember(IsRequired=false)]
		public string promoMainRow3 {get; set;}
		
		[DataMember(IsRequired=false)]
		public bool promoMainRow3Striked {get; set;}
		
		[DataMember(IsRequired=false)]
		public bool sparPlus {get; set;}
		
		[DataMember(IsRequired=false)]
		public string promoInfoBottom1 {get; set;}
		
		[DataMember(IsRequired=false)]
		public string promoInfoBottom2 {get; set;}
		
		[DataMember]
		public string promoValidFrom {get; set;}
		
		[DataMember]
		public string promoValidTo {get; set;}
		
		[DataMember(IsRequired=false)]
		public string freeText1 {get; set;}
		
		[DataMember(IsRequired=false)]
		public string freeText2 {get; set;}
		
		[DataMember]
		public string leafletTermCond {get; set;}
		
		[DataMember(IsRequired=false)]
		public string freeText3 {get; set;}
		
		[DataMember(IsRequired=false)]
		public string brandLogo1 {get; set;}
		
		[DataMember(IsRequired=false)]
		public string brandLogo2 {get; set;}
		
		[DataMember(IsRequired=false)]
		public string brandLogo3 {get; set;}
		
		[DataMember(IsRequired=false)]
		public bool storesType1 {get; set;}
		
		[DataMember(IsRequired=false)]
		public bool storesType2 {get; set;}
		
		[DataMember(IsRequired=false)]
		public bool storesType3 {get; set;}
		
		[DataMember(IsRequired=false)]
		public bool shareable {get; set;}
		
	}
	
	[DataContract]
	public class PromoPrice
	{
		public PromoPrice(){}
		
		[DataMember]
		public int integer {get; set;}
		
		[DataMember(IsRequired=false)]
		public int fraction {get; set;}
	}
}
