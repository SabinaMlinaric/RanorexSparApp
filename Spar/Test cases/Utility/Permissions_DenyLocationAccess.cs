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

namespace Spar.Test_cases.Utility
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Permissions_DenyLocationAccess recording.
    /// </summary>
    [TestModule("39ea6478-6c49-4624-a897-86086fcb8414", ModuleType.Recording, 1)]
    public partial class Permissions_DenyLocationAccess : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Spar.SparRepository repository.
        /// </summary>
        public static Spar.SparRepository repo = Spar.SparRepository.Instance;

        static Permissions_DenyLocationAccess instance = new Permissions_DenyLocationAccess();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Permissions_DenyLocationAccess()
        {
            PackageName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Permissions_DenyLocationAccess Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable PackageName.
        /// </summary>
        [TestVariable("5e2a555c-cc05-4331-b3f2-0409610fcead")]
        public string PackageName
        {
            get { return repo.PackageName; }
            set { repo.PackageName = value; }
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

            DenyLocationPermission();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
