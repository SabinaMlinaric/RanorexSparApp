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
    ///The News_ReadMore recording.
    /// </summary>
    [TestModule("f1695f7e-8691-46f1-9cd5-a74d6d5c1639", ModuleType.Recording, 1)]
    public partial class News_ReadMore : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static News_ReadMore instance = new News_ReadMore();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public News_ReadMore()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static News_ReadMore Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.TvReadMore' at Center", repo.PlusSparSi.MainActivity.TvReadMoreInfo, new RecordItemIndex(0));
            repo.PlusSparSi.MainActivity.TvReadMore.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='News') on item 'PlusSparSi.MainActivity.RStringTabTitle'.", repo.PlusSparSi.MainActivity.RStringTabTitleInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.PlusSparSi.MainActivity.RStringTabTitleInfo, "Text", "News");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'PlusSparSi.MainActivity.NavigateUp' at Center", repo.PlusSparSi.MainActivity.NavigateUpInfo, new RecordItemIndex(2));
            repo.PlusSparSi.MainActivity.NavigateUp.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
