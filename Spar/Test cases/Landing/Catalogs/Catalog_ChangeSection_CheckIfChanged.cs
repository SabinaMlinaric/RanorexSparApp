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

namespace Spar.Test_cases.Landing.Catalogs
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Catalog_ChangeSection_CheckIfChanged recording.
    /// </summary>
    [TestModule("e7467d75-ba85-4bce-b76c-4eff1b7f2105", ModuleType.Recording, 1)]
    public partial class Catalog_ChangeSection_CheckIfChanged : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static Catalog_ChangeSection_CheckIfChanged instance = new Catalog_ChangeSection_CheckIfChanged();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Catalog_ChangeSection_CheckIfChanged()
        {
            NewSection = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Catalog_ChangeSection_CheckIfChanged Instance
        {
            get { return instance; }
        }

#region Variables

        string _NewSection;

        /// <summary>
        /// Gets or sets the value of variable NewSection.
        /// </summary>
        [TestVariable("49d5805a-5211-4cd3-8536-45fab25a7d54")]
        public string NewSection
        {
            get { return _NewSection; }
            set { _NewSection = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$NewSection) on item 'PlusSparSi.MainActivity.CatalogOrSectionTitle'.", repo.PlusSparSi.MainActivity.CatalogOrSectionTitleInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.PlusSparSi.MainActivity.CatalogOrSectionTitleInfo, "Text", NewSection);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
