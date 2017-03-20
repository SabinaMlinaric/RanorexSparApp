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

namespace Spar.Test_cases.Landing
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Landing_Overview recording.
    /// </summary>
    [TestModule("bc3fa62d-29d6-442e-ba78-eb9d5186c239", ModuleType.Recording, 1)]
    public partial class Landing_Overview : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static Landing_Overview instance = new Landing_Overview();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Landing_Overview()
        {
            CatalogTitle = "";
            News1Title = "";
            News2Title = "";
            News3Title = "";
            JedelBiTitle = "";
            SparPlusKlubTitle = "";
            accessToken = "";
            SwipeHeight = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Landing_Overview Instance
        {
            get { return instance; }
        }

#region Variables

        string _CatalogTitle;

        /// <summary>
        /// Gets or sets the value of variable CatalogTitle.
        /// </summary>
        [TestVariable("d071693a-42ee-4702-890c-34ad2f1004e7")]
        public string CatalogTitle
        {
            get { return _CatalogTitle; }
            set { _CatalogTitle = value; }
        }

        string _News1Title;

        /// <summary>
        /// Gets or sets the value of variable News1Title.
        /// </summary>
        [TestVariable("b1de4316-ce7e-43c0-bd25-ec84faf7e068")]
        public string News1Title
        {
            get { return _News1Title; }
            set { _News1Title = value; }
        }

        string _News2Title;

        /// <summary>
        /// Gets or sets the value of variable News2Title.
        /// </summary>
        [TestVariable("836e316e-9a00-42ef-ba0b-f43e6b0804b1")]
        public string News2Title
        {
            get { return _News2Title; }
            set { _News2Title = value; }
        }

        string _News3Title;

        /// <summary>
        /// Gets or sets the value of variable News3Title.
        /// </summary>
        [TestVariable("1924bce7-335a-4153-a297-ffaa92e321fe")]
        public string News3Title
        {
            get { return _News3Title; }
            set { _News3Title = value; }
        }

        string _JedelBiTitle;

        /// <summary>
        /// Gets or sets the value of variable JedelBiTitle.
        /// </summary>
        [TestVariable("b8cb20d4-0fab-42cc-9f2e-31761bf51eb0")]
        public string JedelBiTitle
        {
            get { return _JedelBiTitle; }
            set { _JedelBiTitle = value; }
        }

        string _SparPlusKlubTitle;

        /// <summary>
        /// Gets or sets the value of variable SparPlusKlubTitle.
        /// </summary>
        [TestVariable("2f79e8d0-8049-4789-b463-b8492d13b248")]
        public string SparPlusKlubTitle
        {
            get { return _SparPlusKlubTitle; }
            set { _SparPlusKlubTitle = value; }
        }

        string _accessToken;

        /// <summary>
        /// Gets or sets the value of variable accessToken.
        /// </summary>
        [TestVariable("22e36eaf-6ac8-4b3b-bd16-93e522b5a962")]
        public string accessToken
        {
            get { return _accessToken; }
            set { _accessToken = value; }
        }

        string _SwipeHeight;

        /// <summary>
        /// Gets or sets the value of variable SwipeHeight.
        /// </summary>
        [TestVariable("024548ff-1243-45ab-a6ba-4085b6e119c4")]
        public string SwipeHeight
        {
            get { return _SwipeHeight; }
            set { _SwipeHeight = value; }
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

            GetDashboardInfo();
            Delay.Milliseconds(0);
            
            GetHightForSwipe();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$CatalogTitle) on item 'PlusSparSi.MainActivity.CatalogOrSectionTitle'.", repo.PlusSparSi.MainActivity.CatalogOrSectionTitleInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.PlusSparSi.MainActivity.CatalogOrSectionTitleInfo, "Text", CatalogTitle);
            Delay.Milliseconds(0);
            
            Swipe_Gesture_FragmentStackLanding(repo.PlusSparSi.MainActivity.FragmentStackLandingInfo);
            Delay.Milliseconds(0);
            
            MergedUserCodeMethod(repo.PlusSparSi.MainActivity.News1_TitleInfo, repo.PlusSparSi.MainActivity.News2_TitleInfo, repo.PlusSparSi.MainActivity.News3_TitleInfo);
            Delay.Milliseconds(0);
            
            MergedUserCodeMethod1(repo.PlusSparSi.MainActivity.TvJedelBiInfo, repo.PlusSparSi.MainActivity.TvSparPlusKlubInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
