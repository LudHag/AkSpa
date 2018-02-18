﻿using System.Collections.Generic;
using System.Linq;
using AKSpa.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace AkSpa.Controllers
{
    [Route("api/[controller]")]
    public class PageController : Controller
    {
        private readonly AkContext _db;

        public PageController(AkContext db)
        {
            _db = db;
        }

        [HttpGet]
        public JsonResult GetAllPages()
        {
            var pages = _db.Pages.Where(x => !x.LoggedIn).ToDictionary(x=>x.Slug.ToLower());

            return Json(pages);
        }

    }
}