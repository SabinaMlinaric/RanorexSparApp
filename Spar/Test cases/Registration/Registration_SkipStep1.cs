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

namespace Spar.Test_cases.Registration
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Registration_SkipStep1 recording.
    /// </summary>
    [TestModule("f48b69f3-acec-45de-94c0-04aa035fc112", ModuleType.Recording, 1)]
    public partial class Registration_SkipStep1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static Registration_SkipStep1 instance = new Registration_SkipStep1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Registration_SkipStep1()
        {
            Name = "";
            Surname = "";
            DateOfBirth = "";
            Gender = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Registration_SkipStep1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Name;

        /// <summary>
        /// Gets or sets the value of variable Name.
        /// </summary>
        [TestVariable("cd6770f1-0465-470a-b511-137754ac1a4c")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        string _Surname;

        /// <summary>
        /// Gets or sets the value of variable Surname.
        /// </summary>
        [TestVariable("a1bb2186-c2df-4047-9e80-9b29e5c954b9")]
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        string _DateOfBirth;

        /// <summary>
        /// Gets or sets the value of variable DateOfBirth.
        /// </summary>
        [TestVariable("f9079a8b-011a-4117-b9e4-f9240756187e")]
        public string DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }

        string _Gender;

        /// <summary>
        /// Gets or sets the value of variable Gender.
        /// </summary>
        [TestVariable("48636606-a5e9-4b1e-8292-529638d912fa")]
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.ScanCardActivity.BtnNoCard' at Center", repo.PlusSparSi.ScanCardActivity.BtnNoCardInfo, new RecordItemIndex(0));
            repo.PlusSparSi.ScanCardActivity.BtnNoCard.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.RegisterWelcomeActivity.BtnJoin' at Center", repo.PlusSparSi.RegisterWelcomeActivity.BtnJoinInfo, new RecordItemIndex(1));
            repo.PlusSparSi.RegisterWelcomeActivity.BtnJoin.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$Name' on item 'PlusSparSi.RegisterStep1PersonalDataActivity.EtName'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtNameInfo, new RecordItemIndex(2));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtName.Element.SetAttributeValue("Text", Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$Surname' on item 'PlusSparSi.RegisterStep1PersonalDataActivity.EtSurname'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtSurnameInfo, new RecordItemIndex(3));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtSurname.Element.SetAttributeValue("Text", Surname);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$DateOfBirth' on item 'PlusSparSi.RegisterStep1PersonalDataActivity.EtDateBirth'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtDateBirthInfo, new RecordItemIndex(4));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtDateBirth.Element.SetAttributeValue("Text", DateOfBirth);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$Gender' on item 'PlusSparSi.RegisterStep1PersonalDataActivity.EtGender'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtGenderInfo, new RecordItemIndex(5));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtGender.Element.SetAttributeValue("Text", Gender);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.RegisterStep1PersonalDataActivity.BtnSkip' at Center", repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnSkipInfo, new RecordItemIndex(6));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnSkip.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.OnBoardingStepOneActivity'.", repo.PlusSparSi.OnBoardingStepOneActivity.SelfInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepOneActivity.SelfInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}