﻿using System;
using System.Collections.Generic;

// SKREVET AV ALEKSANDER NILSOON : Sist endret 04.06.2021 
namespace stemmeApp.Models
{
    public class Votes {
        public String Voter { get; set; }
        public String VotedOn { get; set; }
    }
    public class ElectionInformation
    {
        public int IdElection { get; set; }
        public DateTime ElectionStart { get; set; }
        public DateTime ElectionEnd { get; set; }
        public DateTime Controlled { get; set; }
    }

    public class InspectorViewModel {
        public List<Votes> Votes { get; set; } = new List<Votes>();
        public List<ElectionInformation> ElectionInformation { get; set; } = new List<ElectionInformation>();
        public List<Candidates> Candidates { get; set; } = new List<Candidates>();
    }

    public class CandidateVotes
    {
        public String Username { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public int Votes { get; set; }
        public String Picture { get; set; }
        public String PictureText { get; set; }
    }



}

    
