//  Authors:  Caren Dymond, Sarah Beukema

using Landis.Library.UniversalCohorts;
using Landis.Utilities;

namespace Landis.Extension.Succession.ForC.AgeOnlyDisturbances
{
    /// <summary>
    /// The event handlers when no biomass parameters have been provided by
    /// the user.  
    /// </summary>
    public static class NoParameters
    {
        public static void CohortDied(object         sender,
                                      DeathEventArgs eventArgs)
        {
            ThrowException();
        }

        //---------------------------------------------------------------------

        public static void SiteDisturbed(object               sender,
                                         DisturbanceEventArgs eventArgs)
        {
            ThrowException();
        }

        //---------------------------------------------------------------------

        private static void ThrowException()
        {
            string[] mesg = new string[] {
                "Error:  An age-only disturbance has occurred, but no biomass",
                "        parameters were provided for age-only disturbances."
            };
            throw new MultiLineException(new MultiLineText(mesg));
        }
    }
}
