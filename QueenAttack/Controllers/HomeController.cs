using Microsoft.AspNetCore.Mvc;
using Chess.Models;
using System;
namespace Chess.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/Form")]
        public ActionResult QueenAttack() { return View(); }


        [Route("/queenattack")]
        public ActionResult QueenAttack(string xattack, string yattack, string queenx, string queeny)
        {
            ChessClass myChessGame = new ChessClass("4", "3", "2", "2");
          
        return View("QueenAttack", myChessGame.IsAttackable("4", "3", "2", "2"));
        }
    }
}
