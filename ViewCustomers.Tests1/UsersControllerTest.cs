using myModel;
// <copyright file="UsersControllerTest.cs">Copyright ©  2017</copyright>
using System;
using System.Web.Mvc;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViewCustomers.Controllers;

namespace ViewCustomers.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for UsersController</summary>
    [PexClass(typeof(UsersController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UsersControllerTest
    {
        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]UsersController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method UsersControllerTest.IndexTest(UsersController)
        }

        /// <summary>Test stub for Details(Int32)</summary>
        [PexMethod]
        public ActionResult DetailsTest([PexAssumeUnderTest]UsersController target, int id)
        {
            ActionResult result = target.Details(id);
            return result;
            // TODO: add assertions to method UsersControllerTest.DetailsTest(UsersController, Int32)
        }

        /// <summary>Test stub for Create()</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]UsersController target)
        {
            ActionResult result = target.Create();
            return result;
            // TODO: add assertions to method UsersControllerTest.CreateTest(UsersController)
        }

        /// <summary>Test stub for Create(User)</summary>
        [PexMethod]
        public ActionResult CreateTest([PexAssumeUnderTest]UsersController target, User user)
        {
            ActionResult result = target.Create(user);
            return result;
            // TODO: add assertions to method UsersControllerTest.CreateTest(UsersController, User)
        }

        /// <summary>Test stub for Edit(Int32)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]UsersController target, int id)
        {
            ActionResult result = target.Edit(id);
            return result;
            // TODO: add assertions to method UsersControllerTest.EditTest(UsersController, Int32)
        }

        /// <summary>Test stub for Edit(User)</summary>
        [PexMethod]
        public ActionResult EditTest([PexAssumeUnderTest]UsersController target, User user)
        {
            ActionResult result = target.Edit(user);
            return result;
            // TODO: add assertions to method UsersControllerTest.EditTest(UsersController, User)
        }
    }
}
