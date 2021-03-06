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
    ///The Step1_MissingData recording.
    /// </summary>
    [TestModule("9ab4fa77-5aa1-4af0-b5e9-e0a4f632945f", ModuleType.Recording, 1)]
    public partial class Step1_MissingData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static Step1_MissingData instance = new Step1_MissingData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Step1_MissingData()
        {
            Name = "";
            Surname = "";
            DateOfBirth = "";
            Gender = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Step1_MissingData Instance
        {
            get { return instance; }
        }

#region Variables

        string _Name;

        /// <summary>
        /// Gets or sets the value of variable Name.
        /// </summary>
        [TestVariable("bdf1aa68-37d8-4046-b1c1-6dedb564ad04")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        string _Surname;

        /// <summary>
        /// Gets or sets the value of variable Surname.
        /// </summary>
        [TestVariable("cafff7ad-ab67-43f1-a7c0-dad29b4cd4ad")]
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        string _DateOfBirth;

        /// <summary>
        /// Gets or sets the value of variable DateOfBirth.
        /// </summary>
        [TestVariable("30bf5d49-04e1-4092-9b11-882623b86f09")]
        public string DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Gender.
        /// </summary>
        [TestVariable("1b7e4906-2f4a-47d5-a31f-cd19a4f042c3")]
        public string Gender
        {
            get { return repo.Gender; }
            set { repo.Gender = value; }
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='False') on item 'PlusSparSi.RegisterStep1PersonalDataActivity.BtnNext'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, "Enabled", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$Surname' on item 'PlusSparSi.RegisterStep1PersonalDataActivity.EtSurname'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtSurnameInfo, new RecordItemIndex(4));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtSurname.Element.SetAttributeValue("Text", Surname);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='False') on item 'PlusSparSi.RegisterStep1PersonalDataActivity.BtnNext'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, "Enabled", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$DateOfBirth' on item 'PlusSparSi.RegisterStep1PersonalDataActivity.EtDateBirth'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtDateBirthInfo, new RecordItemIndex(6));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtDateBirth.Element.SetAttributeValue("Text", DateOfBirth);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='False') on item 'PlusSparSi.RegisterStep1PersonalDataActivity.BtnNext'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, "Enabled", "False");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$Gender' on item 'PlusSparSi.RegisterStep1PersonalDataActivity.EtGender'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtGenderInfo, new RecordItemIndex(8));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.EtGender.Element.SetAttributeValue("Text", Gender);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'PlusSparSi.RegisterStep1PersonalDataActivity.BtnNext'.", repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, "Enabled", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
