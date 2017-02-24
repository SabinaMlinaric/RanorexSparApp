/*
 * Created by Ranorex
 * User: sabinam
 * Date: 24. 02. 2017
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Spar.Test_cases.Utility.C_.Classes
{
	/// <summary>
	/// Description of Dashboard.
	/// </summary>
	public class Dashboard
	{
		public Dashboard() {}
		
		public List<Catalog> catalogs {get; set;}
		public List<News> news {get; set;}
		public JedelBi jedelBi {get; set;}
		public SparPlusKlub sparPlusKlub {get; set;}
	}
	
	public class News
	{
		public News() {}
		
		public int id {get; set;}
		public string title {get; set;}
		public string description {get; set;}
		public string date {get; set;}
		public string image {get; set;}
	}
	
	public class JedelBi
	{
		public JedelBi() {}
		
		public string title {get; set;}
		public string image {get; set;}
	}
	
	public class SparPlusKlub
	{
		public SparPlusKlub() {}
		
		public string title {get; set;}
	}
}
