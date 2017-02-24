/*
 * Created by Ranorex
 * User: sabinam
 * Date: 24. 02. 2017
 * Time: 10:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Spar.Test_cases.Utility.C_.Classes
{
	/// <summary>
	/// Description of Shop.
	/// </summary>
	/// 
	[DataContract] 
	public class ShopsResponse
	{
		public ShopsResponse(){}
		
		[DataMember] 
		public List<Shop> shops  {get; set;}
	}
	
	[DataContract] 
	public class Shop
	{
		public Shop(){}
		
		[DataMember] 
		public int id {get; set;}
		
		[DataMember] 
		public int type {get; set;}
		
		[DataMember]
		public string title {get; set;}
		
		[DataMember] 
		public string phone {get; set;}
		
		[DataMember] 
		public string fax   {get; set;}
		
		[DataMember] 
		public string mail   {get; set;}
		
		[DataMember] 
		public string contact   {get; set;}
		
		[DataMember] 
		public int parking {get; set;}
		
		[DataMember] 
		public bool atm  {get; set;}
		
		[DataMember] 
		public Location location  {get; set;}
		
		[DataMember] 
		public OpenHours openhours  {get; set;}
	}
	
	[DataContract] 
	public class Location
	{
		public Location(){}
		
		[DataMember] 
		public string address  {get; set;}
		
		[DataMember] 
		public int post  {get; set;}
		
		[DataMember] 
		public string city  {get; set;}
		
		[DataMember] 
		public string country  {get; set;}
		
		[DataMember] 
		public GeoLocation geo {get; set;}
	}
	
	[DataContract] 
	public class OpenHours
	{
		public OpenHours(){}
		
		[DataMember] 
		public OpenhourTime mon {get; set;}
		
		[DataMember] 
		public OpenhourTime tue {get; set;}
		
		[DataMember] 
		public OpenhourTime wed {get; set;}
		
		[DataMember] 
		public OpenhourTime thu {get; set;}
		
		[DataMember] 
		public OpenhourTime fri {get; set;}
		
		[DataMember] 
		public OpenhourTime sat {get; set;}
		
		[DataMember] 
		public OpenhourTime sun {get; set;}
		
		[DataMember] 
		public List<Exception> exceptions {get; set;}
		
	}
	
	[DataContract] 
	public class GeoLocation
	{
		public GeoLocation(){}
		
		[DataMember] 
		public string lat {get; set;}
		
		[DataMember] 
		public string lon {get; set;}
		
	}
	
	[DataContract] 
	public class OpenhourTime
	{
		public OpenhourTime(){}
		
		[DataMember] 
		public string open {get; set;}
		
		[DataMember] 
		public string close {get; set;}
		
	}
	
	[DataContract] 
	public class Exception
	{
		public Exception(){}
		
		[DataMember] 
		public string date {get; set;}
		
		[DataMember] 
		public string reason {get; set;}
		
		[DataMember] 
		public string open {get; set;}
		
		[DataMember] 
		public string close {get; set;}
		
	}
}
