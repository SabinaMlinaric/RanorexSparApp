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
    ///The Registration_SkipStep2 recording.
    /// </summary>
    [TestModule("1c19fa45-88d5-4246-9f9a-777f796e5f50", ModuleType.Recording, 1)]
    public partial class Registration_SkipStep2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static Registration_SkipStep2 instance = new Registration_SkipStep2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Registration_SkipStep2()
        {
            Name = "";
            Surname = "";
            DateOfBirth = "";
            Gender = "";
            Country = "";
            Address = "";
            HouseNumber = "";
            PostalNumber = "";
            City = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Registration_SkipStep2 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Name;

        /// <summary>
        /// Gets or sets the value of variable Name.
        /// </summary>
        [TestVariable("c6c82614-0a43-4847-bfe7-bc02792b8842")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        string _Surname;

        /// <summary>
        /// Gets or sets the value of variable Surname.
        /// </summary>
        [TestVariable("b74e1fd9-4530-4eef-a9d5-26acabfe5ee9")]
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        string _DateOfBirth;

        /// <summary>
        /// Gets or sets the value of variable DateOfBirth.
        /// </summary>
        [TestVariable("b2b46ead-a792-4eda-99d0-b9e0d3513cd1")]
        public string DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }

        string _Gender;

        /// <summary>
        /// Gets or sets the value of variable Gender.
        /// </summary>
        [TestVariable("438785ba-a445-427d-a38e-f19c045c5c34")]
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        string _Country;

        /// <summary>
        /// Gets or sets the value of variable Country.
        /// </summary>
        [TestVariable("5331cb2a-fdcd-412e-aa62-0dd7a84bca6d")]
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        string _Address;

        /// <summary>
        /// Gets or sets the value of variable Address.
        /// </summary>
        [TestVariable("d442d5ca-8f90-4400-a308-a661675ebdbd")]
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        string _HouseNumber;

        /// <summary>
        /// Gets or sets the value of variable HouseNumber.
        /// </summary>
        [TestVariable("8904645f-341c-45da-8c85-2931d5126b2b")]
        public string HouseNumber
        {
            get { return _HouseNumber; }
            set { _HouseNumber = value; }
        }

        string _PostalNumber;

        /// <summary>
        /// Gets or sets the value of variable PostalNumber.
        /// </summary>
        [TestVariable("c7dbe00c-cc87-4054-bd19-b8c4dc5bedb1")]
        public string PostalNumber
        {
            get { return _PostalNumber; }
            set { _PostalNumber = value; }
        }

        string _City;

        /// <summary>
        /// Gets or sets the value of variable City.
        /// </summary>
        [TestVariable("7e5b08c5-d5d4-40e1-b8bc-a2027bbc22ba")]
        public string City
        {
            get { return _City; }
            set { _City = value; }
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
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.RegisterStep1PersonalDataActivity.BtnNext' at Center", repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNextInfo, new RecordItemIndex(6));
            repo.PlusSparSi.RegisterStep1PersonalDataActivity.BtnNext.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$Country' on item 'PlusSparSi.RegisterStep2ResidentDataActivity.EtCountry'.", repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtCountryInfo, new RecordItemIndex(7));
            repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtCountry.Element.SetAttributeValue("Text", Country);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$Address' on item 'PlusSparSi.RegisterStep2ResidentDataActivity.EtStreet'.", repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtStreetInfo, new RecordItemIndex(8));
            repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtStreet.Element.SetAttributeValue("Text", Address);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$HouseNumber' on item 'PlusSparSi.RegisterStep2ResidentDataActivity.EtHouseNumber'.", repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtHouseNumberInfo, new RecordItemIndex(9));
            repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtHouseNumber.Element.SetAttributeValue("Text", HouseNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$PostalNumber' on item 'PlusSparSi.RegisterStep2ResidentDataActivity.EtPostal'.", repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtPostalInfo, new RecordItemIndex(10));
            repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtPostal.Element.SetAttributeValue("Text", PostalNumber);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute Text to '$City' on item 'PlusSparSi.RegisterStep2ResidentDataActivity.EtCity'.", repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtCityInfo, new RecordItemIndex(11));
            repo.PlusSparSi.RegisterStep2ResidentDataActivity.EtCity.Element.SetAttributeValue("Text", City);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.RegisterStep2ResidentDataActivity.BtnSkip' at Center", repo.PlusSparSi.RegisterStep2ResidentDataActivity.BtnSkipInfo, new RecordItemIndex(12));
            repo.PlusSparSi.RegisterStep2ResidentDataActivity.BtnSkip.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.OnBoardingStepOneActivity'.", repo.PlusSparSi.OnBoardingStepOneActivity.SelfInfo, new RecordItemIndex(13));
            Validate.Attribute(repo.PlusSparSi.OnBoardingStepOneActivity.SelfInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}