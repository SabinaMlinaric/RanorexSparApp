﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Spar.Test_cases.Landing.Locations
{
	public partial class Location_ShowOpenOnly
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void MergedUserCodeMethod(RepoItemInfo locations, RepoItemInfo showOnlyOpen, RepoItemInfo showOnlyOpenButton)
		{
			
			int tryNum = 0;
			bool exists = false;
			
			repo.PlusSparSi.SearchTimeout = new Duration(1500);
			repo.PlusSparSi.MainActivity.SearchTimeout = new Duration(1500);
			
			while(tryNum < 6 && !exists){
				
				tryNum++;
				locations.SearchTimeout = new Duration(1000);
				
				exists = locations.Exists();
				
				if(!exists){
					Report.Log(ReportLevel.Info, "Info", "TryNum: " + tryNum);
					repo.PlusSparSi.MainActivity.Self.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "0.5"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
					Delay.Milliseconds(500);
				}else
					break;
			}
			
			if(exists){
				Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Locations') on item 'textInfo'.", locations);
				Validate.Attribute(locations, "Text", "Locations");
			}
			
			tryNum = 0;
			
			while(tryNum < 3){
				
				tryNum++;
				showOnlyOpen.SearchTimeout = new Duration(1000);
				
				exists = showOnlyOpen.Exists();
				
				if(!exists){
					Report.Log(ReportLevel.Info, "Info", "TryNum: " + tryNum);
					repo.PlusSparSi.MainActivity.Self.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "0.5"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
					Delay.Milliseconds(500);
				}else
					break;
			}
			
			if(exists){
				Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Show open only') on item 'textInfo1'.", showOnlyOpen);
				Validate.Attribute(showOnlyOpen, "Text", "Show open only");
			}
			
			tryNum = 0;
			
			while(tryNum < 3){
				
				tryNum++;
				showOnlyOpenButton.SearchTimeout = new Duration(1000);
				
				exists = showOnlyOpenButton.Exists();
				
				if(!exists){
					Report.Log(ReportLevel.Info, "Info", "TryNum: " + tryNum);
					repo.PlusSparSi.MainActivity.Self.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "0.5"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
					Delay.Milliseconds(500);
				}else
					break;
			}
			
			if(exists){
				Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'buttonInfo'.", showOnlyOpenButton);
				Validate.Attribute(showOnlyOpenButton, "Visible", "True");
			}
		}

		public void SetItemNum()
		{
			ItemNum = "3";
			ItemNext = "4";
		}

		public void CheckCellHeight()
		{
			AEhight = repo.PlusSparSi.MainActivity.Locations.RecyclerView_Items.ScreenRectangle.Height.ToString();
			Report.Log(ReportLevel.Info, "AE Hight", AEhight);
		}

		public void VerifyShowOnlyOpen()
		{
			int tryNum = 0;
			bool exists = false;
			bool nextExists = false;
			int number = int.Parse(ItemNum);
			
			repo.PlusSparSi.SearchTimeout = new Duration(1500);
			repo.PlusSparSi.MainActivity.SearchTimeout = new Duration(1500);
			RepoItemInfo closed = repo.PlusSparSi.MainActivity.Locations.RecyclerView_ItemsInfo;
			RepoItemInfo nextItem = repo.PlusSparSi.MainActivity.Locations.RecyclerView_Item_NextInfo;
			
			repo.PlusSparSi.MainActivity.Locations.RecyclerView_First.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "0.5"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
			Delay.Milliseconds(500);
			
			do{
				tryNum = 0;
				while(tryNum < 4){
					
					closed.SearchTimeout = new Duration(1000);
					
					exists = closed.Exists();
					nextExists = nextItem.Exists();
					
					if(!exists){
						
						tryNum++;
						Report.Log(ReportLevel.Info, "Info", "TryNum: " + tryNum);
						repo.PlusSparSi.MainActivity.Locations.RecyclerView_First.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", AEhight), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
						Delay.Milliseconds(500);
						
					}else{
						
						Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='False') on item 'PlusSparSi.MainActivity.TvClosed'.", repo.PlusSparSi.MainActivity.TvClosedInfo, new RecordItemIndex(6));
						Validate.Attribute(repo.PlusSparSi.MainActivity.TvClosedInfo, "Visible", "False");
						Delay.Milliseconds(0);
						
						repo.PlusSparSi.MainActivity.Locations.RecyclerView_Items.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", AEhight), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
						Delay.Milliseconds(500);
						
						ItemNum = (number + 1).ToString();
						ItemNext = (number + 2).ToString();
						
						Report.Log(ReportLevel.Info, "Store checked:" + repo.PlusSparSi.MainActivity.Locations.RecyclerView_Items_TvTitle.TextValue);
						tryNum = 4;
					}
				}
			}while((nextItem.Exists()));
		}
	}
}
