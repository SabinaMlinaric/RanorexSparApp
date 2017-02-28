/*
 * Created by Ranorex
 * User: sabinam
 * Date: 27. 02. 2017
 * Time: 15:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using Spar.Test_cases.Utility;
using Spar.Test_cases.Utility.C_.Classes;

namespace Spar.Test_cases.Utility
{
    /// <summary>
    /// Description of GetUserToken.
    /// </summary>
    [TestModule("5AB400ED-C823-4762-9FC9-017CD6B9A62C", ModuleType.UserCode, 1)]
    public class GetUserToken : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        public string accessToken;
        
        public GetUserToken()
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
        
        public void GetValidToken()
		{
			Task<HttpResponseInfo> response = HttpClientMethod.GetAsync("https://qa-sparplusapp.spar.si/api/Catalog/token",null,"application/json");
			
			HttpResponseInfo message = response.Result;
			
			if(message.StatusCode == 200){
				
				Token token = new Token();
				
				token = HttpClientMethod.Deserialize<Token>(message.Content);
				accessToken = token.access_token;
				
				Report.Log(ReportLevel.Info, "Access token", accessToken);
			}else
				Report.Log(ReportLevel.Failure, "Failed", "Status: " + message.StatusCode + ", message: " + message.Content.ToString());
			
		}
    }
}
