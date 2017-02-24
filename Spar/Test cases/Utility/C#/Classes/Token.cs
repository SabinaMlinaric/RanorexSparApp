/*
 * Created by Ranorex
 * User: sabinam
 * Date: 23. 02. 2017
 * Time: 13:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.Serialization;

namespace Spar.Test_cases.Utility.C_.Classes
{
	/// <summary>
	/// Description of Token.
	/// </summary>
	[DataContract]  
	public class Token
	{
		public Token(){}
		
		[DataMember] 
		public String access_token {get; set;}
	}
}
