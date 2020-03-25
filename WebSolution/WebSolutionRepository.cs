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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace WebSolution
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the WebSolutionRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("e387de63-794e-44f1-ad68-a380279dd04d")]
    public partial class WebSolutionRepository : RepoGenBaseFolder
    {
        static WebSolutionRepository instance = new WebSolutionRepository();
        WebSolutionRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the WebSolutionRepository element repository.
        /// </summary>
        [RepositoryFolder("e387de63-794e-44f1-ad68-a380279dd04d")]
        public static WebSolutionRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public WebSolutionRepository() 
            : base("WebSolutionRepository", "/", null, 0, false, "e387de63-794e-44f1-ad68-a380279dd04d", ".\\RepositoryImages\\WebSolutionRepositorye387de63.rximgres")
        {
            _applicationundertest = new WebSolutionRepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

        string _varGender = "male";

        /// <summary>
        /// Gets or sets the value of variable varGender.
        /// </summary>
        [TestVariable("e31303bb-d39c-40a7-af11-416c12ea8fe3")]
        public string varGender
        {
            get { return _varGender; }
            set { _varGender = value; }
        }

        string _Category = "Music";

        /// <summary>
        /// Gets or sets the value of variable Category.
        /// </summary>
        [TestVariable("b400e258-75d0-4d41-822f-54d7a0b5c69c")]
        public string Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e387de63-794e-44f1-ad68-a380279dd04d")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("76156d7f-1283-40d8-abc7-8e4b01c652f9")]
        public virtual WebSolutionRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class WebSolutionRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("76156d7f-1283-40d8-abc7-8e4b01c652f9")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fnameInfo;
            RepoItemInfo _lnameInfo;
            RepoItemInfo _categoryInfo;
            RepoItemInfo _inputtagaddInfo;
            RepoItemInfo _countInfo;
            RepoItemInfo _clearInfo;
            RepoItemInfo _genderInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "76156d7f-1283-40d8-abc7-8e4b01c652f9", "")
            {
                _fnameInfo = new RepoItemInfo(this, "FName", ".//input[#'FirstName']", 30000, null, "d48e2db5-6f83-4ffc-b0ba-f124ecead4e2");
                _lnameInfo = new RepoItemInfo(this, "LName", ".//input[#'LastName']", 30000, null, "7230fc0f-7bba-4d33-be2c-df91b8461d0b");
                _categoryInfo = new RepoItemInfo(this, "Category", ".//select[#'Category']/option[@value=$Category]", 30000, null, "50830d91-5380-451d-a12f-d01726f4ce84");
                _inputtagaddInfo = new RepoItemInfo(this, "InputTagAdd", ".//input[#'Add']", 30000, null, "4b076d41-7ddc-4ece-9dfc-79f5524e071a");
                _countInfo = new RepoItemInfo(this, "Count", ".//td[#'count']", 30000, null, "36149545-d27f-4fd8-9760-c67dc29c421e");
                _clearInfo = new RepoItemInfo(this, "Clear", ".//input[#'Clear']", 30000, null, "15eb58e9-65f5-4917-80cd-3ad657f43579");
                _genderInfo = new RepoItemInfo(this, "Gender", ".//td[#'gender']/table//input[@name='Gender' and @type='radio' and @value=$varGender]", 30000, null, "e7315cbe-95c4-4124-ba60-40958e8021c0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("76156d7f-1283-40d8-abc7-8e4b01c652f9")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("76156d7f-1283-40d8-abc7-8e4b01c652f9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FName item.
            /// </summary>
            [RepositoryItem("d48e2db5-6f83-4ffc-b0ba-f124ecead4e2")]
            public virtual Ranorex.InputTag FName
            {
                get
                {
                    return _fnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The FName item info.
            /// </summary>
            [RepositoryItemInfo("d48e2db5-6f83-4ffc-b0ba-f124ecead4e2")]
            public virtual RepoItemInfo FNameInfo
            {
                get
                {
                    return _fnameInfo;
                }
            }

            /// <summary>
            /// The LName item.
            /// </summary>
            [RepositoryItem("7230fc0f-7bba-4d33-be2c-df91b8461d0b")]
            public virtual Ranorex.InputTag LName
            {
                get
                {
                    return _lnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The LName item info.
            /// </summary>
            [RepositoryItemInfo("7230fc0f-7bba-4d33-be2c-df91b8461d0b")]
            public virtual RepoItemInfo LNameInfo
            {
                get
                {
                    return _lnameInfo;
                }
            }

            /// <summary>
            /// The Category item.
            /// </summary>
            [RepositoryItem("50830d91-5380-451d-a12f-d01726f4ce84")]
            public virtual Ranorex.OptionTag Category
            {
                get
                {
                    return _categoryInfo.CreateAdapter<Ranorex.OptionTag>(true);
                }
            }

            /// <summary>
            /// The Category item info.
            /// </summary>
            [RepositoryItemInfo("50830d91-5380-451d-a12f-d01726f4ce84")]
            public virtual RepoItemInfo CategoryInfo
            {
                get
                {
                    return _categoryInfo;
                }
            }

            /// <summary>
            /// The InputTagAdd item.
            /// </summary>
            [RepositoryItem("4b076d41-7ddc-4ece-9dfc-79f5524e071a")]
            public virtual Ranorex.InputTag InputTagAdd
            {
                get
                {
                    return _inputtagaddInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagAdd item info.
            /// </summary>
            [RepositoryItemInfo("4b076d41-7ddc-4ece-9dfc-79f5524e071a")]
            public virtual RepoItemInfo InputTagAddInfo
            {
                get
                {
                    return _inputtagaddInfo;
                }
            }

            /// <summary>
            /// The Count item.
            /// </summary>
            [RepositoryItem("36149545-d27f-4fd8-9760-c67dc29c421e")]
            public virtual Ranorex.TdTag Count
            {
                get
                {
                    return _countInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The Count item info.
            /// </summary>
            [RepositoryItemInfo("36149545-d27f-4fd8-9760-c67dc29c421e")]
            public virtual RepoItemInfo CountInfo
            {
                get
                {
                    return _countInfo;
                }
            }

            /// <summary>
            /// The Clear item.
            /// </summary>
            [RepositoryItem("15eb58e9-65f5-4917-80cd-3ad657f43579")]
            public virtual Ranorex.InputTag Clear
            {
                get
                {
                    return _clearInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Clear item info.
            /// </summary>
            [RepositoryItemInfo("15eb58e9-65f5-4917-80cd-3ad657f43579")]
            public virtual RepoItemInfo ClearInfo
            {
                get
                {
                    return _clearInfo;
                }
            }

            /// <summary>
            /// The Gender item.
            /// </summary>
            [RepositoryItem("e7315cbe-95c4-4124-ba60-40958e8021c0")]
            public virtual Ranorex.InputTag Gender
            {
                get
                {
                    return _genderInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Gender item info.
            /// </summary>
            [RepositoryItemInfo("e7315cbe-95c4-4124-ba60-40958e8021c0")]
            public virtual RepoItemInfo GenderInfo
            {
                get
                {
                    return _genderInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
