/*
 * Created by Ranorex
 * User: sabinam
 * Date: 24. 02. 2017
 * Time: 12:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.Serialization;

namespace Spar.Test_cases.Utility.C_.Classes
{
	/// <summary>
	/// Description of UserDetailsResponse.
	/// </summary>
	/// 
	[DataContract] 
	public class UserDetailsResponse
	{
		public UserDetailsResponse() {}
		
		[DataMember] 
		public string id {get; set;}
		
		[DataMember] 
		public string name {get; set;}
		
		[DataMember] 
		public string street  {get; set;}
		
		[DataMember] 
		public string houseNumber  {get; set;}
		
		[DataMember] 
		public string email  {get; set;}
		
		[DataMember] 
		public int children  {get; set;}
		
		[DataMember] 
		public string city  {get; set;}
		
		[DataMember] 
		public string country  {get; set;}
		
		[DataMember] 
		public string dateOfBirth  {get; set;}
		
		[DataMember] 
		public Notifications notifications  {get; set;}
		
		[DataMember] 
		public LoyaltyCard card  {get; set;}
		
		[DataMember] 
		public string gender  {get; set;}
		
		[DataMember] 
		public int householdNUmber  {get; set;}
		
		[DataMember] 
		public string phoneNumber  {get; set;}
		
		[DataMember] 
		public string postCode  {get; set;}
		
		[DataMember]
		public bool retired  {get; set;}
		
		[DataMember] 
		public string surname  {get; set;}
		
	}
	
	[DataContract] 
	public class Notifications
	{
		public Notifications() {}
		
		[DataMember] 
		public bool phone  {get; set;}
		
		[DataMember] 
		public bool sparApp  {get; set;}
		
		[DataMember] 
		public bool directMail  {get; set;}
		
		[DataMember] 
		public bool emailSparPlus {get; set;}
		
		[DataMember] 
		public bool emailWebStore {get; set;}
		
	}
	
	[DataContract] 
	public class LoyaltyCard
	{
		public LoyaltyCard() {}
		
		[DataMember] 
		public string serialNumber  {get; set;}
		
		[DataMember] 
		public string name  {get; set;}
		
		[DataMember] 
		public string barcode  {get; set;}
		
		[DataMember] 
		public string status {get; set;}
		
	}
}
