﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Spar.Test_cases.MySpar
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MyProfile_Overview recording.
    /// </summary>
    [TestModule("4d7ed7f0-5301-4409-95ba-439e2914a173", ModuleType.Recording, 1)]
    public partial class MyProfile_Overview : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static MyProfile_Overview instance = new MyProfile_Overview();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MyProfile_Overview()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MyProfile_Overview Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.MySpar.MenuBtnMySpar' at Center", repo.PlusSparSi.MainActivity.MySpar.MenuBtnMySparInfo, new RecordItemIndex(0));
            repo.PlusSparSi.MainActivity.MySpar.MenuBtnMySpar.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.MySpar.ImgUserProfile' at Center", repo.PlusSparSi.MainActivity.MySpar.ImgUserProfileInfo, new RecordItemIndex(1));
            repo.PlusSparSi.MainActivity.MySpar.ImgUserProfile.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.MySpar.MyProfile.PushNotification' at Center", repo.PlusSparSi.MainActivity.MySpar.MyProfile.PushNotificationInfo, new RecordItemIndex(2));
            repo.PlusSparSi.MainActivity.MySpar.MyProfile.PushNotification.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Push Notifications') on item 'PlusSparSi.MainActivity.MySpar.MyProfile.TitlebarPushNotification'.", repo.PlusSparSi.MainActivity.MySpar.MyProfile.TitlebarPushNotificationInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.PlusSparSi.MainActivity.MySpar.MyProfile.TitlebarPushNotificationInfo, "Text", "Push Notifications");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Be notified on time about new coupons and promotions in our catalogs.') on item 'PlusSparSi.MainActivity.MySpar.MyProfile.PushNotificationDescription'.", repo.PlusSparSi.MainActivity.MySpar.MyProfile.PushNotificationDescriptionInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.PlusSparSi.MainActivity.MySpar.MyProfile.PushNotificationDescriptionInfo, "Text", "Be notified on time about new coupons and promotions in our catalogs.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'PlusSparSi.MainActivity.MySpar.MyProfile.BtnPushNotification'.", repo.PlusSparSi.MainActivity.MySpar.MyProfile.BtnPushNotificationInfo, new RecordItemIndex(5));
            Validate.Exists(repo.PlusSparSi.MainActivity.MySpar.MyProfile.BtnPushNotificationInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.NavigateUp' at Center", repo.PlusSparSi.MainActivity.NavigateUpInfo, new RecordItemIndex(6));
            repo.PlusSparSi.MainActivity.NavigateUp.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.MySpar.MyProfile.AskUs' at Center", repo.PlusSparSi.MainActivity.MySpar.MyProfile.AskUsInfo, new RecordItemIndex(7));
            repo.PlusSparSi.MainActivity.MySpar.MyProfile.AskUs.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Ask Us') on item 'PlusSparSi.MainActivity.MySpar.MyProfile.TitlebarAskUs'.", repo.PlusSparSi.MainActivity.MySpar.MyProfile.TitlebarAskUsInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.PlusSparSi.MainActivity.MySpar.MyProfile.TitlebarAskUsInfo, "Text", "Ask Us");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.NavigateUp' at Center", repo.PlusSparSi.MainActivity.NavigateUpInfo, new RecordItemIndex(9));
            repo.PlusSparSi.MainActivity.NavigateUp.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.MySpar.MyProfile.LanguageSelections' at Center", repo.PlusSparSi.MainActivity.MySpar.MyProfile.LanguageSelectionsInfo, new RecordItemIndex(10));
            repo.PlusSparSi.MainActivity.MySpar.MyProfile.LanguageSelections.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Slovenščina') on item 'PlusSparSi.MainActivity.MySpar.MyProfile.Slovenian'.", repo.PlusSparSi.MainActivity.MySpar.MyProfile.SlovenianInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.PlusSparSi.MainActivity.MySpar.MyProfile.SlovenianInfo, "Text", "Slovenščina");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='English') on item 'PlusSparSi.MainActivity.MySpar.MyProfile.English'.", repo.PlusSparSi.MainActivity.MySpar.MyProfile.EnglishInfo, new RecordItemIndex(12));
            Validate.Attribute(repo.PlusSparSi.MainActivity.MySpar.MyProfile.EnglishInfo, "Text", "English");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.NavigateUp' at Center", repo.PlusSparSi.MainActivity.NavigateUpInfo, new RecordItemIndex(13));
            repo.PlusSparSi.MainActivity.NavigateUp.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.MySpar.MyProfile.HelpAndAdvice' at Center", repo.PlusSparSi.MainActivity.MySpar.MyProfile.HelpAndAdviceInfo, new RecordItemIndex(14));
            repo.PlusSparSi.MainActivity.MySpar.MyProfile.HelpAndAdvice.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Help and Advice') on item 'PlusSparSi.MainActivity.MySpar.MyProfile.TitleHelpAndAdvice'.", repo.PlusSparSi.MainActivity.MySpar.MyProfile.TitleHelpAndAdviceInfo, new RecordItemIndex(15));
            Validate.Attribute(repo.PlusSparSi.MainActivity.MySpar.MyProfile.TitleHelpAndAdviceInfo, "Text", "Help and Advice");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.NavigateUp' at Center", repo.PlusSparSi.MainActivity.NavigateUpInfo, new RecordItemIndex(16));
            repo.PlusSparSi.MainActivity.NavigateUp.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.MySpar.MyProfile.About' at Center", repo.PlusSparSi.MainActivity.MySpar.MyProfile.AboutInfo, new RecordItemIndex(17));
            repo.PlusSparSi.MainActivity.MySpar.MyProfile.About.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='About') on item 'PlusSparSi.MainActivity.MySpar.MyProfile.TitleAbout'.", repo.PlusSparSi.MainActivity.MySpar.MyProfile.TitleAboutInfo, new RecordItemIndex(18));
            Validate.Attribute(repo.PlusSparSi.MainActivity.MySpar.MyProfile.TitleAboutInfo, "Text", "About");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
