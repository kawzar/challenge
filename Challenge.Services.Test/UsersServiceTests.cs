using AutoMapper;
using Challenge.Data.Models;
using Challenge.Data.Repositories;
using Challenge.Services.DTOs;
using Challenge.Services.Users;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Challenge.Services.Test
{
    [TestClass]
    public class UsersServiceTests
    {
        private readonly Mock<IUsersRepository> repositoryMock;
        private readonly Mock<IMapper> mapperMock;
        private readonly IUsersService service;

        private readonly UserDto expectedUserDto;
        private readonly User expectedUser;

        public UsersServiceTests()
        {
            repositoryMock = new Mock<IUsersRepository>();
            mapperMock = new Mock<IMapper>();
            service = new UsersService(repositoryMock.Object, mapperMock.Object);

            expectedUserDto = new UserDto { Id = 1 };
            expectedUser = new User { Id = 1 };
        }

        [TestInitialize]
        public void Initialize()
        {
            mapperMock.Setup(x => x.Map<User>(It.IsAny<UserDto>())).Returns(expectedUser);
            mapperMock.Setup(x => x.Map<UserDto>(It.IsAny<User>())).Returns(expectedUserDto);
        }

        [TestMethod]
        public void Authenticate_ReturnsUserDto()
        {
            var expected = new User { Id = 1 };
            repositoryMock.Setup(x => x.Authenticate(It.IsAny<string>(), It.IsAny<string>())).Returns(expected);

            var result = service.Authenticate("user", "password");

            Assert.AreEqual(expectedUserDto, result);
        }

        [TestMethod]
        public void GetById_ReturnsUserDto()
        {
            repositoryMock.Setup(x => x.GetById(It.IsAny<int>())).Returns(expectedUser);

            var result = service.GetById(It.IsAny<int>());

            Assert.AreEqual(expectedUserDto, result);
        }

        [TestMethod]
        public void Create_ReturnsUserDto()
        {
            repositoryMock.Setup(x => x.Create(It.IsAny<User>(), It.IsAny<string>())).Returns(expectedUser);

            var result = service.Create(It.IsAny<UserDto>(), "password");

            Assert.AreEqual(expectedUserDto, result);
        }

        [TestMethod]
        public void Update_CallsUpdateInRepository()
        {
            repositoryMock.Setup(x => x.Update(It.IsAny<User>(), It.IsAny<string>())).Verifiable();

            service.Update(It.IsAny<UserDto>(), "password");

            repositoryMock.Verify(x => x.Update(It.IsAny<User>(), It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public void Delete_CallsDeleteInRepository()
        {
            repositoryMock.Setup(x => x.Delete(It.IsAny<int>())).Verifiable();

            service.Delete(It.IsAny<int>());

            repositoryMock.Verify(x => x.Delete(It.IsAny<int>()), Times.Once);
        }
    }
}
