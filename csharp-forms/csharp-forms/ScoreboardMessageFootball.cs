using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Daktronics.AllSport5000
{
    class ScoreboardMessageFootball
    {
        private string lastMessageText = string.Empty;

        #region Time properties
        /// <summary>
        /// Main clock time. Conditional value depending on the time remaining on the clock. The value is formatted as mm:ss or, if there is less than one minute on the game clock, ss.t) 
        /// </summary>
        public string MainClock;
        /// <summary>
        /// Main clock time as mm:ss.t
        /// </summary>
        public string MainClockTime;
        /// <summary>
        /// Time from the element currently being timed (main clock, time out, or time of day) as mm:ss or, if there is less than one minute on the clock, ss.t)
        /// </summary>
        public string MainClockTimeOut;
        /// <summary>
        /// Time from the element currently being timed (main clock, time out, or time of day) as mm:ss.t
        /// </summary>
        public string MainClockTimeOutTime;
        private string MainClockIsZeroString;
        public bool MainClockIsZero
        {
            get
            {
                if (MainClockIsZeroString == "z")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private string MainClockIsStoppedString;
        public bool MainClockIsStopped
        {
            get
            {
                if (MainClockIsStoppedString == "s")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private string MainClockTimeOutHornEnabledString;
        public bool MainClockTimeOutHornEnabled
        {
            get
            {
                if (MainClockTimeOutHornEnabledString == "h")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private string MainClockHornEnabledString;
        public bool MainClockHornEnabled
        {
            get
            {
                if (MainClockHornEnabledString == "h")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private string TimeOutHornEnabledString;
        public bool TimeOutHornEnabled
        {
            get
            {
                if (TimeOutHornEnabledString == "h")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// Time Out Time (mm:ss) 
        /// </summary>
        public string TimeOutTime;
        /// <summary>
        /// Time of Day (hh:mm:ss) 
        /// </summary>
        public string TimeOfDay;
        #endregion

        #region Team specific properties
        public string HomeTeamName;
        public string GuestTeamName;
        public string HomeTeamNameAbbr;
        public string GuestTeamNameAbbr;
        public string HomeTeamScore;
        public string GuestTeamScore;
        public string HomeTimeOutsLeftFull;
        public string HomeTimeOutsLeftPartial;
        public string HomeTimeOutsLeftTelevision;
        public string HomeTimeOutsLeftTotal;
        public string GuestTimeOutsLeftFull;
        public string GuestTimeOutsLeftPartial;
        public string GuestTimeOutsLeftTelevision;
        public string GuestTimeOutsLeftTotal;
        private string HomeTimeOutIndicator;
        private string HomeTimeOutText;
        public bool HomeTimeOut
        {
            get
            {
                if (HomeTimeOutText == "TIME")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private string GuestTimeOutIndicator;
        private string GuestTimeOutText;
        public bool GuestTimeOut
        {
            get
            {
                if (HomeTimeOutText == "TIME")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region Misc properties
        public string Quarter;
        /// <summary>
        /// Quarter Text ('1st ', 'OT', 'OT/2') 
        /// </summary>
        public string QuarterText;
        /// <summary>
        /// Quarter Description ('End of 1st') 
        /// </summary>
        public string QuarterDescription;
        private string InternalRelayString;
        public enum InternalRelayValue
        {
            Empty,
            z,
            s,
            h
        }
        public InternalRelayValue InternalRelay
        {
            get
            {
                switch (InternalRelayString)
                {
                    case "z":
                        return InternalRelayValue.z;
                    case "s":
                        return InternalRelayValue.s;
                    case "h":
                        return InternalRelayValue.h;
                    default:
                        return InternalRelayValue.Empty;
                }
            }
        }
        public string AdPanelCaptionPower;
        public string AdPanelCaption1;
        public string AdPanelCaption2;
        public string AdPanelCaption3;
        public string AdPanelCaption4;
        public string ReservedForFutureUse;
        /// <summary>
        /// Play Clock Time (mm:ss) 
        /// </summary>
        public string PlayClockTime;
        private string PlayClockHornEnabledString;
        public bool PlayClockHornEnabled
        {
            get
            {
                if (PlayClockHornEnabledString == "h")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// Home Possession Indicator (' ' or '<') 
        /// </summary>
        private string HomePossessionIndicator;
        public bool HomeHasPossession
        {
            get
            {
                if (HomePossessionIndicator == "<")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// Guest Possession Indicator (' ' or '>') 
        /// </summary>
        private string GuestPossessionIndicator;
        public bool GuestHasPossession
        {
            get
            {
                if (GuestPossessionIndicator == ">")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string BallOnYardLine;
        /// <summary>
        /// Down ('1st', '2nd', '3rd', '4th') 
        /// </summary>
        public string DownOrdinal;
        public string ToGoYards;
        #endregion

        #region Score properties
        public string HomeScorePeriod1;
        public string HomeScorePeriod2;
        public string HomeScorePeriod3;
        public string HomeScorePeriod4;
        public string HomeScorePeriod5;
        public string HomeScorePeriod6;
        public string HomeScorePeriod7;
        public string HomeScorePeriod8;
        public string HomeScorePeriod9;
        public string HomeScoreCurrentPeriod;
        public string GuestScorePeriod1;
        public string GuestScorePeriod2;
        public string GuestScorePeriod3;
        public string GuestScorePeriod4;
        public string GuestScorePeriod5;
        public string GuestScorePeriod6;
        public string GuestScorePeriod7;
        public string GuestScorePeriod8;
        public string GuestScorePeriod9;
        public string GuestScoreCurrentPeriod;
        #endregion

        #region Statistic properties
        public string HomeRushingYards;
        public string HomePassingYards;
        public string HomeTotalYards;
        public string GuestRushingYards;
        public string GuestPassingYards;
        public string GuestTotalYards;
        public string HomeFirstDowns;
        public string GuestFirstDowns;
        #endregion

        public ScoreboardMessageFootball(byte[] message)
        {
            int posSTX = 0;
            int posEOT = 0;

            for (int i = 0; i < message.Length; i++)
            {
                switch (message[i])
                {
                    case 22:    // Synchronous Idle (SYN)
                        break;
                    case 1:     // Start of Heading (SOH)
                        break;
                    case 2:     // Start of Text (STX)
                        posSTX = i;
                        break;
                    case 4:     // End of Transmission (EOT)
                        posEOT = i;
                        break;
                    case 23:    // End of Transmission Block (ETB)
                        break;
                    default:
                        break;
                }

                if ((posEOT != 0) && (posSTX != 0))
                {
                    break;
                }
            }

            if (posEOT > posSTX)
            {
                string text = System.Text.Encoding.Default.GetString(message, posSTX + 1, posEOT - posSTX - 1);

                if (text != lastMessageText)
                {
                    lastMessageText = text;

                    // Raw output
                    Debug.WriteLine(text + " (" + text.Length.ToString() + ")");

                    if (text.Length == 31)
                    {
                        this.MainClock = text.Substring(0, 5);
                        this.MainClockTime = text.Substring(5, 8);
                        this.MainClockTimeOut = text.Substring(13, 5);
                        this.MainClockTimeOutTime = text.Substring(18, 8);
                        this.MainClockIsZeroString = text.Substring(26, 1);
                        this.MainClockIsStoppedString = text.Substring(27, 1);
                        this.MainClockTimeOutHornEnabledString = text.Substring(28, 1);
                        this.MainClockHornEnabledString = text.Substring(29, 1);
                        this.TimeOutHornEnabledString = text.Substring(30, 1);
                    }
                    else if (text.Length >= 294)
                    {
                        this.MainClock = text.Substring(0, 5);
                        this.MainClockTime = text.Substring(5, 8);
                        this.MainClockTimeOut = text.Substring(13, 5);
                        this.MainClockTimeOutTime = text.Substring(18, 8);
                        this.MainClockIsZeroString = text.Substring(26, 1);
                        this.MainClockIsStoppedString = text.Substring(27, 1);
                        this.MainClockTimeOutHornEnabledString = text.Substring(28, 1);
                        this.MainClockHornEnabledString = text.Substring(29, 1);
                        this.TimeOutHornEnabledString = text.Substring(30, 1);
                        this.TimeOutTime = text.Substring(31, 8);
                        this.TimeOfDay = text.Substring(39, 8);
                        this.HomeTeamName = text.Substring(47, 20);
                        this.GuestTeamName = text.Substring(67, 20);
                        this.HomeTeamNameAbbr = text.Substring(87, 10);
                        this.GuestTeamNameAbbr = text.Substring(97, 10);
                        this.HomeTeamScore = text.Substring(107, 4);
                        this.GuestTeamScore = text.Substring(111, 4);
                        this.HomeTimeOutsLeftFull = text.Substring(115, 2);
                        this.HomeTimeOutsLeftPartial = text.Substring(117, 2);
                        this.HomeTimeOutsLeftTelevision = text.Substring(119, 2);
                        this.HomeTimeOutsLeftTotal = text.Substring(121, 2);
                        this.GuestTimeOutsLeftFull = text.Substring(123, 2);
                        this.GuestTimeOutsLeftPartial = text.Substring(125, 2);
                        this.GuestTimeOutsLeftTelevision = text.Substring(127, 2);
                        this.GuestTimeOutsLeftTotal = text.Substring(129, 2);
                        this.HomeTimeOutIndicator = text.Substring(131, 1);
                        this.HomeTimeOutText = text.Substring(132, 4);
                        this.GuestTimeOutIndicator = text.Substring(136, 1);
                        this.GuestTimeOutText = text.Substring(137, 4);
                        this.Quarter = text.Substring(141, 2);
                        this.QuarterText = text.Substring(143, 4);
                        this.QuarterDescription = text.Substring(147, 12);
                        this.InternalRelayString = text.Substring(159, 1);
                        this.AdPanelCaptionPower = text.Substring(160, 1);
                        this.AdPanelCaption1 = text.Substring(161, 12);
                        this.AdPanelCaption2 = text.Substring(162, 12);
                        this.AdPanelCaption3 = text.Substring(163, 12);
                        this.AdPanelCaption4 = text.Substring(164, 12);
                        this.ReservedForFutureUse = text.Substring(166, 35);
                        this.PlayClockTime = text.Substring(200, 8);
                        this.PlayClockHornEnabledString = text.Substring(208, 1);
                        this.HomePossessionIndicator = text.Substring(209, 1);
                        // Debug.WriteLine("Home Possession Text (' ' or 'POSS'): " + text.Substring(210, 4));
                        this.GuestPossessionIndicator = text.Substring(214, 1);
                        // Debug.WriteLine("Guest Possession Text (' ' or 'POSS': " + text.Substring(215, 4));
                        this.BallOnYardLine = text.Substring(219, 2);
                        this.DownOrdinal = text.Substring(221, 3);
                        this.ToGoYards = text.Substring(224, 2);
                        this.HomeScorePeriod1 = text.Substring(226, 2);
                        this.HomeScorePeriod2 = text.Substring(228, 2);
                        this.HomeScorePeriod3 = text.Substring(230, 2);
                        this.HomeScorePeriod4 = text.Substring(232, 2);
                        this.HomeScorePeriod5 = text.Substring(234, 2);
                        this.HomeScorePeriod6 = text.Substring(236, 2);
                        this.HomeScorePeriod7 = text.Substring(238, 2);
                        this.HomeScorePeriod8 = text.Substring(240, 2);
                        this.HomeScorePeriod9 = text.Substring(242, 2);
                        this.HomeScoreCurrentPeriod = text.Substring(244, 2);
                        this.GuestScorePeriod1 = text.Substring(246, 2);
                        this.GuestScorePeriod2 = text.Substring(248, 2);
                        this.GuestScorePeriod3 = text.Substring(250, 2);
                        this.GuestScorePeriod4 = text.Substring(252, 2);
                        this.GuestScorePeriod5 = text.Substring(254, 2);
                        this.GuestScorePeriod6 = text.Substring(256, 2);
                        this.GuestScorePeriod7 = text.Substring(258, 2);
                        this.GuestScorePeriod8 = text.Substring(260, 2);
                        this.GuestScorePeriod9 = text.Substring(262, 2);
                        this.GuestScoreCurrentPeriod = text.Substring(264, 2);
                        this.HomeRushingYards = text.Substring(266, 4);
                        this.HomePassingYards = text.Substring(270, 4);
                        this.HomeTotalYards = text.Substring(274, 4);
                        this.GuestRushingYards = text.Substring(278, 4);
                        this.GuestPassingYards = text.Substring(282, 4);
                        this.GuestTotalYards = text.Substring(286, 4);
                        this.HomeFirstDowns = text.Substring(290, 2);
                        this.GuestFirstDowns = text.Substring(292, 2);
                    }
                }
            }
        }
    }
}
