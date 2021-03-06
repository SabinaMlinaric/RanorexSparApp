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

namespace Spar.Test_cases.Boarding
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The NoCard_SkipAll recording.
    /// </summary>
    [TestModule("c39e8614-8d6b-4096-8572-acd96170c2aa", ModuleType.Recording, 1)]
    public partial class NoCard_SkipAll : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static NoCard_SkipAll instance = new NoCard_SkipAll();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NoCard_SkipAll()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NoCard_SkipAll Instance
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
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.ScanCardActivity.BtnNoCard' at Center", repo.PlusSparSi.ScanCardActivity.BtnNoCardInfo, new RecordItemIndex(0));
            repo.PlusSparSi.ScanCardActivity.BtnNoCard.Touch();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Become SPAR plus member') on item 'PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeInfoTitle'.", repo.PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeInfoTitleInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeInfoTitleInfo, "Text", "Become SPAR plus member");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Exclusive coupons and bonuses') on item 'PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeExclusive'.", repo.PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeExclusiveInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeExclusiveInfo, "Text", "Exclusive coupons and bonuses");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Collect credit on card') on item 'PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeCollectingCre'.", repo.PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeCollectingCreInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeCollectingCreInfo, "Text", "Collect credit on card");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='SPAR plus card access on phone') on item 'PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeCardAccess'.", repo.PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeCardAccessInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.PlusSparSi.RegisterWelcomeActivity.RegisterWelcomeCardAccessInfo, "Text", "SPAR plus card access on phone");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Join in') on item 'PlusSparSi.RegisterWelcomeActivity.BtnJoin'.", repo.PlusSparSi.RegisterWelcomeActivity.BtnJoinInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.PlusSparSi.RegisterWelcomeActivity.BtnJoinInfo, "Text", "Join in");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Skip') on item 'PlusSparSi.RegisterWelcomeActivity.BtnSkip'.", repo.PlusSparSi.RegisterWelcomeActivity.BtnSkipInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.PlusSparSi.RegisterWelcomeActivity.BtnSkipInfo, "Text", "Skip");
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.RegisterWelcomeActivity.BtnSkip' at Center", repo.PlusSparSi.RegisterWelcomeActivity.BtnSkipInfo, new RecordItemIndex(7));
            repo.PlusSparSi.RegisterWelcomeActivity.BtnSkip.Touch();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Don't miss coupons and promotions') on item 'PlusSparSi.OnBoardingStepOneActivity.RStringOnBoardingStepOneInfoTitle'.", repo.PlusSparSi.OnBoardingStepOneActivity.RStringOnBoardingStepOneInfoTitleInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepOneActivity.RStringOnBoardingStepOneInfoTitleInfo, "Text", "Don't miss coupons and promotions");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Do you want to be notified on time for coupons, weekly leaflets and promotions?') on item 'PlusSparSi.OnBoardingStepOneActivity.RStringOnBoardingStepOneDescriptio'.", repo.PlusSparSi.OnBoardingStepOneActivity.RStringOnBoardingStepOneDescriptioInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepOneActivity.RStringOnBoardingStepOneDescriptioInfo, "Text", "Do you want to be notified on time for coupons, weekly leaflets and promotions?");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Allow notifications') on item 'PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneAllow'.", repo.PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneAllowInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneAllowInfo, "Text", "Allow notifications");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Skip') on item 'PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneSkip'.", repo.PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneSkipInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneSkipInfo, "Text", "Skip");
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneSkip' at Center", repo.PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneSkipInfo, new RecordItemIndex(12));
            repo.PlusSparSi.OnBoardingStepOneActivity.BtnOnBoardingStepOneSkip.Touch();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Where is the nearest Spar?') on item 'PlusSparSi.OnBoardingStepTwoActivity.RStringOnBoardingStepTwoInfoTitle'.", repo.PlusSparSi.OnBoardingStepTwoActivity.RStringOnBoardingStepTwoInfoTitleInfo, new RecordItemIndex(13));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepTwoActivity.RStringOnBoardingStepTwoInfoTitleInfo, "Text", "Where is the nearest Spar?");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Check opening hours of your closest Spar shop and be notified about any changes.') on item 'PlusSparSi.OnBoardingStepTwoActivity.RStringOnBoardingStepTwoDescriptio'.", repo.PlusSparSi.OnBoardingStepTwoActivity.RStringOnBoardingStepTwoDescriptioInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepTwoActivity.RStringOnBoardingStepTwoDescriptioInfo, "Text", "Check opening hours of your closest Spar shop and be notified about any changes.");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Allow location monitoring') on item 'PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoAllow'.", repo.PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoAllowInfo, new RecordItemIndex(15));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoAllowInfo, "Text", "Allow location monitoring");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Skip') on item 'PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoSkip'.", repo.PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoSkipInfo, new RecordItemIndex(16));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoSkipInfo, "Text", "Skip");
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoSkip' at Center", repo.PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoSkipInfo, new RecordItemIndex(17));
            repo.PlusSparSi.OnBoardingStepTwoActivity.BtnOnBoardingStepTwoSkip.Touch();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='SPAR plus loyalty card always available') on item 'PlusSparSi.OnBoardingStepThreeActivity.RStringOnBoardingStepThreeInfoTit'.", repo.PlusSparSi.OnBoardingStepThreeActivity.RStringOnBoardingStepThreeInfoTitInfo, new RecordItemIndex(18));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepThreeActivity.RStringOnBoardingStepThreeInfoTitInfo, "Text", "SPAR plus loyalty card always available");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Add SPAR plus loyalty card in notification center, where it will be always available.') on item 'PlusSparSi.OnBoardingStepThreeActivity.RStringOnBoardingStepThreeDescript'.", repo.PlusSparSi.OnBoardingStepThreeActivity.RStringOnBoardingStepThreeDescriptInfo, new RecordItemIndex(19));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepThreeActivity.RStringOnBoardingStepThreeDescriptInfo, "Text", "Add SPAR plus loyalty card in notification center, where it will be always available.");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Finish') on item 'PlusSparSi.OnBoardingStepThreeActivity.BtnOnBoardingStepThreeFinish'.", repo.PlusSparSi.OnBoardingStepThreeActivity.BtnOnBoardingStepThreeFinishInfo, new RecordItemIndex(20));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepThreeActivity.BtnOnBoardingStepThreeFinishInfo, "Text", "Finish");
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.OnBoardingStepThreeActivity.BtnOnBoardingStepThreeFinish' at Center", repo.PlusSparSi.OnBoardingStepThreeActivity.BtnOnBoardingStepThreeFinishInfo, new RecordItemIndex(21));
            repo.PlusSparSi.OnBoardingStepThreeActivity.BtnOnBoardingStepThreeFinish.Touch();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'PlusSparSi.MainActivity'.", repo.PlusSparSi.MainActivity.SelfInfo, new RecordItemIndex(22));
            Validate.Exists(repo.PlusSparSi.MainActivity.SelfInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
