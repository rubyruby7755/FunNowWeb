﻿using Microsoft.AspNetCore.Mvc;
using PrjFunNowWeb.Models;

namespace PrjFunNowWeb.Controllers
{
    public class CommentController : Controller
    {
     

        public IActionResult Angular_comment_page() //目前沒用
        {
            return View();
        }

        public IActionResult Angular_membercomment()
        {
            var memberID = HttpContext.Session.GetString("MemberID");
            var googleMemberID = HttpContext.Session.GetString("GoogleMemberID");

            // 决定使用哪个ID
            var finalMemberID = !string.IsNullOrEmpty(memberID) ? memberID : googleMemberID;

            ViewBag.MemberID = finalMemberID;
            return View();
        }
        public IActionResult Action(object data)
        {
            ViewBag.CommentData = data;
            return View("MemberCommentForm");
        }


        public IActionResult Angular_membercommentform()
        {
            return View();
        }

        public IActionResult Angular_plaform() //目前沒用
        {
            return View();
        }

        public IActionResult GetComments(int hotelId)
        {
            // 從資料庫獲取數據
           var comments = new List<Comment>();
           
            return Json(comments);
        }
    }
}
