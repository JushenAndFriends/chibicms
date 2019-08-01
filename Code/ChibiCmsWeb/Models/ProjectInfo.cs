using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ChibiCmsWeb.Models
{
    public class ProjectInfo
    {
        public string TeamName { get; set; }
        public string Abstract { get; set; }
        public string Teacher { get; set; }
        public string ProjectLink { get; set; }
        public List<string> TeamMember { get; set; }
        public List<string> Posters { get; set; }
        /// <summary>
        /// only support youku
        /// </summary>
        public string EmbeddedVideo { get; set; }
    }
}
