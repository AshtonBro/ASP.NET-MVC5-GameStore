using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        private IGameRepository repository;
        public GameController(IGameRepository _repository)
        {
            repository = _repository;
        }

        public ViewResult List()
        {
            return View(repository.Games);
        }
    }
}