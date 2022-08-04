using System.Collections.Generic;

namespace NFLTeams.Models
{
    public class TeamListViewModel : TeamViewModel
    {
        public string UserName { get; set; }
        public List<Team> Teams { get; set; }

        
        private List<Conference> conferences;
        public List<Conference> Conferences {
            get => conferences; 
            set {
                conferences = new List<Conference> {
                    new Conference { ConferenceID = "all", Name = "All" }
                };
                conferences.AddRange(value);
            }
        }

        private List<Division> divisions;
        public List<Division> Divisions {
            get => divisions; 
            set {
                divisions = new List<Division> {
                    new Division { DivisionID = "all", Name = "All" }
                };
                divisions.AddRange(value);
            }
        }

        
        public string CheckActiveConf(string c) => 
            c.ToLower() == ActiveConf.ToLower() ? "active" : "";
        public string CheckActiveDiv(string d) => 
            d.ToLower() == ActiveDiv.ToLower() ? "active" : "";
    }
}
