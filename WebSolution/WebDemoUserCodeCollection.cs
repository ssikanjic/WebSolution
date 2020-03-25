﻿/*
 * Created by Ranorex
 * User: ssikanjic
 * Date: 25.03.2020
 * Time: 21:26
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
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

namespace WebSolution
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class WebDemoUserCodeCollection
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void PreSalesUserCodeMathod()
        {
        	// your comment goes here
        	string PreSalesAT="Hello from Graz";
        }
    }
}
