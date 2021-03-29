﻿using Gig_Hub.Models;
using Gig_Hub.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Gig_Hub.Content
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

      
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres =  _context.Genres.ToList()
            };
            return View(viewModel);
        }

     
        [HttpPost]
        public ActionResult Save(GigFormViewModel viewModel)
        {
            var artistId = User.Identity.GetUserId();
            var gig = new Gig()
            {
                ArtistId = 2,
                DateTime = DateTime.Parse(string.Format("{0} {1}",viewModel.Date, viewModel.Time)),
                Venue = viewModel.Venue,
                GenreId = viewModel.Genre
            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index","Home");
        }
    }
}