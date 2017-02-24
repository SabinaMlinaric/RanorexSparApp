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

namespace Spar.Test_cases.Landing.Locations
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LocationDetails_Overview recording.
    /// </summary>
    [TestModule("242d6933-a350-4632-8041-ef415889eea1", ModuleType.Recording, 1)]
    public partial class LocationDetails_Overview : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static LocationDetails_Overview instance = new LocationDetails_Overview();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LocationDetails_Overview()
        {
            StoreTitle = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LocationDetails_Overview Instance
        {
            get { return instance; }
        }

#region Variables

        string _StoreTitle;

        /// <summary>
        /// Gets or sets the value of variable StoreTitle.
        /// </summary>
        [TestVariable("aa8e16f2-d02d-452e-89f1-cc36db2e13e5")]
        public string StoreTitle
        {
            get { return _StoreTitle; }
            set { _StoreTitle = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Locations') on item 'PlusSparSi.MainActivity.RStringTabTitle'.", repo.PlusSparSi.MainActivity.RStringTabTitleInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.PlusSparSi.MainActivity.RStringTabTitleInfo, "Text", "Locations");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.MainActivity.Locations.MapFragmentWrapper'.", repo.PlusSparSi.MainActivity.Locations.MapFragmentWrapperInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.PlusSparSi.MainActivity.Locations.MapFragmentWrapperInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$StoreTitle) on item 'PlusSparSi.MainActivity.TvTitle'.", repo.PlusSparSi.MainActivity.TvTitleInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.PlusSparSi.MainActivity.TvTitleInfo, "Text", StoreTitle);
            Delay.Milliseconds(0);
            
            MergedUserCodeMethod(repo.PlusSparSi.MainActivity.Locations.RStringShopDetailsSectionOpenHoursInfo, repo.PlusSparSi.MainActivity.Locations.RStringShopDetailsSectionContactInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.NavigateUp' at Center", repo.PlusSparSi.MainActivity.NavigateUpInfo, new RecordItemIndex(4));
            repo.PlusSparSi.MainActivity.NavigateUp.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
