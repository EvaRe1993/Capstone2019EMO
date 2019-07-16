using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Capstone2019EMO.Model
{
    /// <summary> 
    /// Purpose: Data Contract Entity Model Class [BabysitterEntity] for the table [dbo].[Babysitter]. 
    /// </summary> 
    public class BabysitterEntity : IDisposable
    {
        #region Class Public Methods 

        /// <summary> 
        /// Purpose: Implements the IDispose interface. 
        /// </summary> 
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Class Property Declarations 

        [Required(ErrorMessage = "You must enter an Babysitter ID.")]
        public int BabysitterID { get; set; }

        [Required(ErrorMessage = "You must enter an Babysitter Name.")]
        [StringLength(50, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "You must enter a Babysitter Price Per Job.")]
        public int PricePerJob { get; set; }
        public int WeeklyPay { get; set; }
       
        #endregion
    }
} 
