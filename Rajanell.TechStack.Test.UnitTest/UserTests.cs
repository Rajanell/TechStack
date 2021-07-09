using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rajanell.TechStack.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System.Threading.Tasks;
using Rajanell.TechStack.Validation.Validators;
using Rajanell.TechStach.Core.Model.RequestDTO;
using System.Linq;
using FluentValidation.TestHelper;
using FluentValidation;

namespace Rajanell.TechStack.Test.UnitTest
{
    [TestClass]
    public class UserTests
    {
        private IUserService _userService;
        private IServiceProvider _serviceProvider;

        [TestInitialize]
        public void Initialize()
        {
            _serviceProvider = ServicesProvider.GetServiceProvider();
            _userService = _serviceProvider.GetService<IUserService>();
        }

        [TestMethod]
        public async Task IsUsernameUnique()
        {
            var user = new UserRequest()
            {
                Username = "TestUser"
            };

            Mock<IUserService> userService = new Mock<IUserService>();
            userService.Setup(x => x.IsUsernameUnique(user.Username)).ReturnsAsync(false);

            AddUserValidator validations = new AddUserValidator(userService.Object);
            var result = await  validations.IsUsernameUnique(user.Username);
            Assert.IsFalse(result);

            var validationResult = validations.Validate(user);
            //check if validation fails
            Assert.IsFalse(validationResult.IsValid);
        }
        [TestMethod]
        public void UserNameIsNotValidEmailAddress()
        {
            //ARRANGE
            var user = new UserRequest()
            {
                Username = "TestUser",
                Password = "Password"
            };
            Mock<IUserService> userService = new Mock<IUserService>();
            userService.Setup(x => x.IsUsernameUnique(user.Username)).ReturnsAsync(true);
            AddUserValidator validator = new AddUserValidator(userService.Object);

            //ACT
            var validationResult = validator.Validate(user);
            var emailValidation = validationResult.Errors.FirstOrDefault(x => x.PropertyName == "Username");

            //Assert
            Assert.IsFalse(validationResult.IsValid);             //check if validation fails
            Assert.IsTrue(emailValidation.ErrorCode == "EmailValidator");             //Email validator error
            Assert.IsTrue(emailValidation.ErrorMessage == "Username not a valid email address");             //Check correct error message is returned

            //Using FluentValidation Tet extensions
            var result = validator.TestValidate(user);
            result.ShouldHaveValidationErrorFor(user => user.Username)
              .WithErrorMessage("Username not a valid email address")
              .WithSeverity(Severity.Error)
              .WithErrorCode("EmailValidator");
        }
        [TestMethod]
        public void UserNameIsValidEmailAddress()
        {
            //ARRANGE
            var user = new UserRequest()
            {
                Username = "Test@Email.com",
                Password = "Password"
            };
            Mock<IUserService> userService = new Mock<IUserService>();
            userService.Setup(x => x.IsUsernameUnique(user.Username)).ReturnsAsync(true);
            AddUserValidator validations = new AddUserValidator(userService.Object);

            //ACT
            var validationResult = validations.Validate(user);
            //Assert
            Assert.IsTrue(validationResult.IsValid);
            
        }
    }
}
