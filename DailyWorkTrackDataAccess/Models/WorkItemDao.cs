using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWorkTrackDataAccess.Models
{
    /// <summary>
    /// Model for the work item
    /// </summary>
    public class WorkItemDao
    {
        /// <summary>
        /// Id of the work item
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identifier for the user owning this tasks
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Title for the work item eg. Discussion with team, Start working on story
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Date assigned for the work to be completed
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Status of work item
        /// </summary>
        public int Status { get; set; }
    }
}
