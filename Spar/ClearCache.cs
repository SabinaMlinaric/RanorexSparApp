/*
 * Created by Ranorex
 * User: domen
 * Date: 14/02/2017
 * Time: 08:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace Spar
{
    /// <summary>
    /// Description of ClearCache.
    /// </summary>
    [TestModule("F80A1144-D3CB-42D7-8E13-FC1F65F16F6E", ModuleType.UserCode, 1)]
    public class ClearCache : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClearCache()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
