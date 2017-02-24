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
    ///The Location_PermissionDenied_Overview recording.
    /// </summary>
    [TestModule("1a5b452c-e40f-481f-a4f3-a879e99df009", ModuleType.Recording, 1)]
    public partial class Location_PermissionDenied_Overview : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static Location_PermissionDenied_Overview instance = new Location_PermissionDenied_Overview();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Location_PermissionDenied_Overview()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Location_PermissionDenied_Overview Instance
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

            FindLocations();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Spar and Interspar stores') on item 'PlusSparSi.MainActivity.Locations.TvLocationTitle'.", repo.PlusSparSi.MainActivity.Locations.TvLocationTitleInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.PlusSparSi.MainActivity.Locations.TvLocationTitleInfo, "Text", "Spar and Interspar stores");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Locations and opening hours of Spar and Interspar stores') on item 'PlusSparSi.MainActivity.TvDescription'.", repo.PlusSparSi.MainActivity.TvDescriptionInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.PlusSparSi.MainActivity.TvDescriptionInfo, "Text", "Locations and opening hours of Spar and Interspar stores");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.TvDescription' at Center", repo.PlusSparSi.MainActivity.TvDescriptionInfo, new RecordItemIndex(3));
            repo.PlusSparSi.MainActivity.TvDescription.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.MainActivity.Locations.SearchView'.", repo.PlusSparSi.MainActivity.Locations.SearchViewInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.PlusSparSi.MainActivity.Locations.SearchViewInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Interspar') on item 'PlusSparSi.MainActivity.Locations.RStringShopTypeInterspar'.", repo.PlusSparSi.MainActivity.Locations.RStringShopTypeIntersparInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.PlusSparSi.MainActivity.Locations.RStringShopTypeIntersparInfo, "Text", "Interspar");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Spar') on item 'PlusSparSi.MainActivity.Locations.RStringShopTypeSpar'.", repo.PlusSparSi.MainActivity.Locations.RStringShopTypeSparInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.PlusSparSi.MainActivity.Locations.RStringShopTypeSparInfo, "Text", "Spar");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Interspar Restaurant') on item 'PlusSparSi.MainActivity.Locations.RStringShopTypeRestavration'.", repo.PlusSparSi.MainActivity.Locations.RStringShopTypeRestavrationInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.PlusSparSi.MainActivity.Locations.RStringShopTypeRestavrationInfo, "Text", "Interspar Restaurant");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Spar partner') on item 'PlusSparSi.MainActivity.Locations.RStringShopTypePartner'.", repo.PlusSparSi.MainActivity.Locations.RStringShopTypePartnerInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.PlusSparSi.MainActivity.Locations.RStringShopTypePartnerInfo, "Text", "Spar partner");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.MainActivity.Locations.MapFragmentWrapper'.", repo.PlusSparSi.MainActivity.Locations.MapFragmentWrapperInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.PlusSparSi.MainActivity.Locations.MapFragmentWrapperInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            MergedUserCodeMethod(repo.PlusSparSi.MainActivity.Locations.RStringShopsActionbarTitleInfo, repo.PlusSparSi.MainActivity.Locations.RStringShopShowOnlyOpenInfo, repo.PlusSparSi.MainActivity.Locations.SwShowOnlyOpenInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
