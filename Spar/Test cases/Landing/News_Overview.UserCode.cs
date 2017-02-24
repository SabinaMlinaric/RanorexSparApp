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

namespace Spar.Test_cases.Landing
{
	public partial class News_Overview
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void FindNews()
		{
			
			int tryNum = 0;
			bool exists = false;
			
			while(tryNum < 6 && !exists){
				
				tryNum++;
				repo.PlusSparSi.SearchTimeout = new Duration(1500);
				repo.PlusSparSi.MainActivity.SearchTimeout = new Duration(1500);
				repo.PlusSparSi.MainActivity.ImgNewsInfo.SearchTimeout = new Duration(1000);
				
				exists = repo.PlusSparSi.MainActivity.ImgNewsInfo.Exists();
				
				if(!exists){
					Report.Log(ReportLevel.Info, "Info", "TryNum: " + tryNum);
					repo.PlusSparSi.MainActivity.Self.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Up (270°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "0.5"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
					Delay.Milliseconds(500);
				}else
					break;
			}
		}

	}
}
