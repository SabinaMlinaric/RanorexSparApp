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
    ///The MySpar_Login_IncorrectPassword recording.
    /// </summary>
    [TestModule("47b1eb12-72e1-4690-b1e5-c1ee7f408d5c", ModuleType.Recording, 1)]
    public partial class MySpar_Login_IncorrectPassword : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static MySpar_Login_IncorrectPassword instance = new MySpar_Login_IncorrectPassword();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MySpar_Login_IncorrectPassword()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MySpar_Login_IncorrectPassword Instance
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
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.MySpar.MyProfile.BtnMySparManualInsertCardNr' at Center", repo.PlusSparSi.MainActivity.MySpar.MyProfile.BtnMySparManualInsertCardNrInfo, new RecordItemIndex(2));
            repo.PlusSparSi.MainActivity.MySpar.MyProfile.BtnMySparManualInsertCardNr.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '97846878' on item 'PlusSparSi.EnterNumberActivity.EtCardNumber'.", repo.PlusSparSi.EnterNumberActivity.EtCardNumberInfo, new RecordItemIndex(3));
            repo.PlusSparSi.EnterNumberActivity.EtCardNumber.Element.SetAttributeValue("Text", "97846878");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'PlusSparSi.EnterNumberActivity.BtnNext'.", repo.PlusSparSi.EnterNumberActivity.BtnNextInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.PlusSparSi.EnterNumberActivity.BtnNextInfo, "Enabled", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.EnterNumberActivity.BtnNext' at Center", repo.PlusSparSi.EnterNumberActivity.BtnNextInfo, new RecordItemIndex(5));
            repo.PlusSparSi.EnterNumberActivity.BtnNext.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'testdf@mailinator.com' on item 'PlusSparSi.LoginSignInActivity.InputEnterEmail'.", repo.PlusSparSi.LoginSignInActivity.InputEnterEmailInfo, new RecordItemIndex(6));
            repo.PlusSparSi.LoginSignInActivity.InputEnterEmail.Element.SetAttributeValue("Text", "testdf@mailinator.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to 'Adgjadgj2' on item 'PlusSparSi.LoginSignInActivity.InputPassword'.", repo.PlusSparSi.LoginSignInActivity.InputPasswordInfo, new RecordItemIndex(7));
            repo.PlusSparSi.LoginSignInActivity.InputPassword.Element.SetAttributeValue("Text", "Adgjadgj2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key '{ENTER}' press on 'PlusSparSi'.", repo.PlusSparSi.SelfInfo, new RecordItemIndex(8));
            repo.PlusSparSi.Self.PressKeys("{ENTER}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.LoginSignInActivity.BtnSignInLogin' at Center", repo.PlusSparSi.LoginSignInActivity.BtnSignInLoginInfo, new RecordItemIndex(9));
            repo.PlusSparSi.LoginSignInActivity.BtnSignInLogin.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.LoginSignInActivity.NavigateUp' at Center", repo.PlusSparSi.LoginSignInActivity.NavigateUpInfo, new RecordItemIndex(10));
            repo.PlusSparSi.LoginSignInActivity.NavigateUp.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}