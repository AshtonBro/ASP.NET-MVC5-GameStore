﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Moq;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IGameRepository> mock = new Mock<IGameRepository>();
            mock.Setup(m => m.Games).Returns(new List<Game> 
            {
                 new Game { Name = "SimCity", Price = 1499 },
                 new Game { Name = "TITANFALL", Price = 2299 },
                 new Game { Name = "Battlefield 4", Price = 899.4M },
                 new Game { Name = "Rocket League", Price = 456.8M }
            });
        }

    }

}