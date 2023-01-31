﻿using stemmeApp.Data;
using stemmeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// ALLE ACTION METHODS I CONTROLLER ER SKREVET AV ALEKSANER NILSSON : Sist endret 04.06.2021
namespace stemmeApp.Controllers
{
    [Authorize(Roles = "Inspector")]
    public class InspectorController : Controller
    {
        // GET: Inspector
        public ActionResult Index()
        {
            DbQuery db = new DbQuery();
            var IndexViewModel = new InspectorViewModel();
            IndexViewModel.Votes = db.getVotes();
            IndexViewModel.ElectionInformation = db.getElectionInfo();
            IndexViewModel.Candidates = db.GetAllCandidates();


            return View(IndexViewModel);
        }

        [HttpPost]
        public ActionResult Index(InspectorViewModel Model)
        {
            DbQuery db = new DbQuery();
            db.SetControlDate(Model.ElectionInformation[0].IdElection);
            return RedirectToAction("");
        }

        public ActionResult Votes()
        {
            DbQuery db = new DbQuery();
            var IndexViewModel = new InspectorViewModel();
            IndexViewModel.Votes = db.getVotes();
            return View(IndexViewModel);
        }

        public ActionResult Candidates()
        {
            DbQuery db = new DbQuery();
            return View(db.getCandidateVotes().ToList());
        }
    }
}