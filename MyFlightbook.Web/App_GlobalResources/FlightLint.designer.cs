//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class FlightLint {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FlightLint() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.FlightLint", global::System.Reflection.Assembly.Load("App_GlobalResources"));
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check Flights.
        /// </summary>
        internal static string CheckFlightsBegin {
            get {
                return ResourceManager.GetString("CheckFlightsBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to %APP_NAME% can examine your flights for issues in the following categories; you may wish to turn off those that are not relevant to you:.
        /// </summary>
        internal static string CheckFlightsCategoriesHeader {
            get {
                return ResourceManager.GetString("CheckFlightsCategoriesHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This will go through your flights and try to identify common issues.  NONE OF THESE ISSUES RISE TO THE LEVEL OF ERROR, they may be perfectly valid, but they are things you may wish to check or clean up..
        /// </summary>
        internal static string CheckFlightsDescription1 {
            get {
                return ResourceManager.GetString("CheckFlightsDescription1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No issues were found!.
        /// </summary>
        internal static string CheckFlightsNoIssuesFound {
            get {
                return ResourceManager.GetString("CheckFlightsNoIssuesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No options for checking flights have been selected.  Please select at least one category..
        /// </summary>
        internal static string errNoOptionsSelected {
            get {
                return ResourceManager.GetString("errNoOptionsSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Airports/route-of-flight issues.
        /// </summary>
        internal static string LintCategoryAirports {
            get {
                return ResourceManager.GetString("LintCategoryAirports", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finds common issues around logging the route of flight, including invalid or missing airports..
        /// </summary>
        internal static string LintCategoryAirportsTip {
            get {
                return ResourceManager.GetString("LintCategoryAirportsTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cross-country issues.
        /// </summary>
        internal static string LintCategoryCrossCountry {
            get {
                return ResourceManager.GetString("LintCategoryCrossCountry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Looks for common issues around logging of cross-country flights.
        /// </summary>
        internal static string LintCategoryCrossCountryTip {
            get {
                return ResourceManager.GetString("LintCategoryCrossCountryTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UTC Time issues.
        /// </summary>
        internal static string LintCategoryDateTime {
            get {
                return ResourceManager.GetString("LintCategoryDateTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensures consistency for timestamps on flights, such as engine, flight, and block time.
        /// </summary>
        internal static string LintCategoryDateTimeTip {
            get {
                return ResourceManager.GetString("LintCategoryDateTimeTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IFR Issues.
        /// </summary>
        internal static string LintCategoryIFR {
            get {
                return ResourceManager.GetString("LintCategoryIFR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Looks for common issues around logging instrument flight.
        /// </summary>
        internal static string LintCategoryIFRTip {
            get {
                return ResourceManager.GetString("LintCategoryIFRTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Additional (uncategorized) issues.
        /// </summary>
        internal static string LintCategoryMisc {
            get {
                return ResourceManager.GetString("LintCategoryMisc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checks for other common issues.
        /// </summary>
        internal static string LintCategoryMiscTip {
            get {
                return ResourceManager.GetString("LintCategoryMiscTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time accounting issues.
        /// </summary>
        internal static string LintCategoryPICSICDualMath {
            get {
                return ResourceManager.GetString("LintCategoryPICSICDualMath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In much of the world (but NOT the US), Total=PIC+SIC+Dual.  This checks for scenarios where this equation doesn&apos;t hold.
        /// </summary>
        internal static string LintCategoryPICSICDualMathTip {
            get {
                return ResourceManager.GetString("LintCategoryPICSICDualMathTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simulator/Training Device Issues.
        /// </summary>
        internal static string LintCategorySim {
            get {
                return ResourceManager.GetString("LintCategorySim", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Looks for common issues and best practices regarding logging of time in a simulator..
        /// </summary>
        internal static string LintCategorySimTip {
            get {
                return ResourceManager.GetString("LintCategorySimTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logged Time Issues.
        /// </summary>
        internal static string LintCategoryTimes {
            get {
                return ResourceManager.GetString("LintCategoryTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensures that time quantities within a flight make sense - e.g., that PIC time doesn&apos;t exceed total time..
        /// </summary>
        internal static string LintCategoryTimesTip {
            get {
                return ResourceManager.GetString("LintCategoryTimesTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check Flights.
        /// </summary>
        internal static string TitleCheckFlights {
            get {
                return ResourceManager.GetString("TitleCheckFlights", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check this flight for possible issues.
        /// </summary>
        internal static string TitleCheckThisFlight {
            get {
                return ResourceManager.GetString("TitleCheckThisFlight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Airplane landed at heliport: {0}.
        /// </summary>
        internal static string warningAirportAirplaneAtHeliport {
            get {
                return ResourceManager.GetString("warningAirportAirplaneAtHeliport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Land airplane landed at seaport: {0}.
        /// </summary>
        internal static string warningAirportLandPlaneAtSeaport {
            get {
                return ResourceManager.GetString("warningAirportLandPlaneAtSeaport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Don&apos;t use &quot;Local&quot; or &quot;LCL&quot; for local flights around the pattern.  Just one code is fine.  (And LCL is an airport in Cuba)..
        /// </summary>
        internal static string warningAirportLocal {
            get {
                return ResourceManager.GetString("warningAirportLocal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Airport in route not found: {0}.
        /// </summary>
        internal static string warningAirportNotFound {
            get {
                return ResourceManager.GetString("warningAirportNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Route and total time imply a speed of {0:#,##0}kts.  Errant airport code?.
        /// </summary>
        internal static string warningAirportUnlikelyImpliedSpeed {
            get {
                return ResourceManager.GetString("warningAirportUnlikelyImpliedSpeed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Block in or out differs from date of flight by more than a day.
        /// </summary>
        internal static string warningBlockTimeDiffersDate {
            get {
                return ResourceManager.GetString("warningBlockTimeDiffersDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Block out time is after flight start.
        /// </summary>
        internal static string warningDateBlockAfterFlight {
            get {
                return ResourceManager.GetString("warningDateBlockAfterFlight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Engine start is after flight start.
        /// </summary>
        internal static string warningDateEngineAfterFlight {
            get {
                return ResourceManager.GetString("warningDateEngineAfterFlight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Block out time is after block in time..
        /// </summary>
        internal static string warningDateTimeInvalidBlock {
            get {
                return ResourceManager.GetString("warningDateTimeInvalidBlock", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Engine end time is before block in time.
        /// </summary>
        internal static string warningEngineEndBeforeBlockIn {
            get {
                return ResourceManager.GetString("warningEngineEndBeforeBlockIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Engine start is after block in.
        /// </summary>
        internal static string warningEngineStartAfterBlockIn {
            get {
                return ResourceManager.GetString("warningEngineStartAfterBlockIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Engine start or end differs from date of flight by more than a day.
        /// </summary>
        internal static string warningEngineTimeDiffersDate {
            get {
                return ResourceManager.GetString("warningEngineTimeDiffersDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight end time is after block in time.
        /// </summary>
        internal static string warningFlightEndAfterBlockIn {
            get {
                return ResourceManager.GetString("warningFlightEndAfterBlockIn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight end time is after engine end time.
        /// </summary>
        internal static string warningFlightEndAfterEngineEnd {
            get {
                return ResourceManager.GetString("warningFlightEndAfterEngineEnd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight end time is before block out.
        /// </summary>
        internal static string warningFlightEndBeforeBlockOut {
            get {
                return ResourceManager.GetString("warningFlightEndBeforeBlockOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight end is before engine start.
        /// </summary>
        internal static string warningFlightEndBeforeEngineStart {
            get {
                return ResourceManager.GetString("warningFlightEndBeforeEngineStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight start or end differs from date of flight by more than a day.
        /// </summary>
        internal static string warningFlightTimeDiffersDate {
            get {
                return ResourceManager.GetString("warningFlightTimeDiffersDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instrument approaches or holding is indicated without IMC or simulated IMC.
        /// </summary>
        internal static string warningIFRApproachesButNoIFR {
            get {
                return ResourceManager.GetString("warningIFRApproachesButNoIFR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Approaches were performed but no &quot;Approach Name(s)&quot; property was found.  Be sure that the approaches are documented either in the comments or in the &quot;Approach Name(s)&quot; property..
        /// </summary>
        internal static string warningIFRNoApproachDescription {
            get {
                return ResourceManager.GetString("warningIFRNoApproachDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Simulated instrument in a real aircraft is indicated, but no safety pilot is specified.  Be sure to indicate the name of the safety pilot!.
        /// </summary>
        internal static string warningIFRNoSafetyPilot {
            get {
                return ResourceManager.GetString("warningIFRNoSafetyPilot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0} is indicated on multiple flights, but should generally only ever happen once.  E.g., you only ever take one Private Pilot Checkride, but later you might add new category/class privileges.  .
        /// </summary>
        internal static string warningMiscMultipleRedundantCheckrides {
            get {
                return ResourceManager.GetString("warningMiscMultipleRedundantCheckrides", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total time does not equal PIC + SIC + Dual time..
        /// </summary>
        internal static string warningPICSICDualBroken {
            get {
                return ResourceManager.GetString("warningPICSICDualBroken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &quot;{0}&quot; indicates more time than total time.
        /// </summary>
        internal static string warningPropertyGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningPropertyGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Actual IMC time logged in a sim - this should be recorded as simulated instrument..
        /// </summary>
        internal static string warningSIMActualIMC {
            get {
                return ResourceManager.GetString("warningSIMActualIMC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified aircraft was not found!!.
        /// </summary>
        internal static string warningSIMAircraftNotFound {
            get {
                return ResourceManager.GetString("warningSIMAircraftNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cross-country flight indicated in a sim - check that it&apos;s OK to log that!.
        /// </summary>
        internal static string warningSIMCrossCountryInSim {
            get {
                return ResourceManager.GetString("warningSIMCrossCountryInSim", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ground sim time is logged in a real aircraft.
        /// </summary>
        internal static string warningSIMGroundSimInRealAircraft {
            get {
                return ResourceManager.GetString("warningSIMGroundSimInRealAircraft", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sim flight found with no &quot;Simulator/Training Device Identifier&quot; property to record the device&apos;s identifier.  Ensure that this is recorded either in this property or in the comments..
        /// </summary>
        internal static string warningSIMNoDeviceIdentifier {
            get {
                return ResourceManager.GetString("warningSIMNoDeviceIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PIC time logged in a training device - check that this is OK to do!.
        /// </summary>
        internal static string warningSIMPICInSim {
            get {
                return ResourceManager.GetString("warningSIMPICInSim", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SIC time logged in a training device - check that this is OK to do!.
        /// </summary>
        internal static string warningSIMSICInSim {
            get {
                return ResourceManager.GetString("warningSIMSICInSim", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total time logged in a training device - check that this is OK to do!.
        /// </summary>
        internal static string warningSIMTotalInSim {
            get {
                return ResourceManager.GetString("warningSIMTotalInSim", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More CFI time recorded than total time..
        /// </summary>
        internal static string warningTimesCFIGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesCFIGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More dual time recorded than total time..
        /// </summary>
        internal static string warningTimesDualGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesDualGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More IMC time recorded than total time..
        /// </summary>
        internal static string warningTimesIMCGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesIMCGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More night time recorded than total time..
        /// </summary>
        internal static string warningTimesNightGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesNightGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More PIC time recorded than total time..
        /// </summary>
        internal static string warningTimesPICGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesPICGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More SIC time recorded than total time..
        /// </summary>
        internal static string warningTimesSICGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesSICGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More simulated time recorded than total time..
        /// </summary>
        internal static string warningTimesSimIFRGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesSimIFRGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More simulated and actual IMC time recorded than total time..
        /// </summary>
        internal static string warningTimesSimPlusIMCGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesSimPlusIMCGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More cross-country time recorded than total time..
        /// </summary>
        internal static string warningTimesXCGreaterThanTotal {
            get {
                return ResourceManager.GetString("warningTimesXCGreaterThanTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight indicates cross-country flight of less than 25nm, but route was longer than that from departure airport.
        /// </summary>
        internal static string warningXCDistanceLessThan25ButFlewMore {
            get {
                return ResourceManager.GetString("warningXCDistanceLessThan25ButFlewMore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight indicates cross-country flight of less than 50nm, but route was longer than that from departure airport.
        /// </summary>
        internal static string warningXCDistanceLessThan50ButFlewMore {
            get {
                return ResourceManager.GetString("warningXCDistanceLessThan50ButFlewMore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight indicates cross-country flight of more than 100nm, but route from departure airport was less than that.
        /// </summary>
        internal static string warningXCDistanceMoreThan100ButFlewLess {
            get {
                return ResourceManager.GetString("warningXCDistanceMoreThan100ButFlewLess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight indicates cross-country flight of more than 50nm, but route from departure airport was less than that.
        /// </summary>
        internal static string warningXCDistanceMoreThan50ButFlewLess {
            get {
                return ResourceManager.GetString("warningXCDistanceMoreThan50ButFlewLess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Flight indicates travel of more than {0}nm from starting airport, but no cross-country time was logged.  Shorting yourself?.
        /// </summary>
        internal static string warningXCMissingXC {
            get {
                return ResourceManager.GetString("warningXCMissingXC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some, but not all of the flight is listed as cross-country.
        /// </summary>
        internal static string warningXCNotWholeFlightXC {
            get {
                return ResourceManager.GetString("warningXCNotWholeFlightXC", resourceCulture);
            }
        }
    }
}
