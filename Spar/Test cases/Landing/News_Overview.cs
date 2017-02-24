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
    ///The News_Overview recording.
    /// </summary>
    [TestModule("f0951450-56ef-41f3-809b-168d121fc2cf", ModuleType.Recording, 1)]
    public partial class News_Overview : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static News_Overview instance = new News_Overview();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public News_Overview()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static News_Overview Instance
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

            FindNews();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.MainActivity.ImgNews'.", repo.PlusSparSi.MainActivity.ImgNewsInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.PlusSparSi.MainActivity.ImgNewsInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.MainActivity.TvReadMore'.", repo.PlusSparSi.MainActivity.TvReadMoreInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.PlusSparSi.MainActivity.TvReadMoreInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.MainActivity.TvTitle'.", repo.PlusSparSi.MainActivity.TvTitleInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.PlusSparSi.MainActivity.TvTitleInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.MainActivity.TvNote'.", repo.PlusSparSi.MainActivity.TvNoteInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.PlusSparSi.MainActivity.TvNoteInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'PlusSparSi.MainActivity.TvDescription'.", repo.PlusSparSi.MainActivity.TvDescriptionInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.PlusSparSi.MainActivity.TvDescriptionInfo, "Visible", "True");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
