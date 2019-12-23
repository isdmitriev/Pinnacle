using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace PinnacleClasses.DatabaseObjects
{
    
    
   public class PinacclePrices
    {

        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int  Id { get; set; }
        
        public string EventId { get; set; }

       



        public DateTime? DateAdded { get; set; }
        public bool ? IsLive { get; set; }
       public DateTime ? StartTime { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> HOME { get; set; }
        [DisplayFormat(DataFormatString ="{0:F7}")]
        public Nullable<decimal> DRAW { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> AWAY { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> HOME_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> DRAW_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> AWAY_computed_ { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> HOME_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> DRAW_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> AWAY_disc { get; set; }

        
      


        
        public Nullable<decimal> HOMEAWAY { get; set; }
        public Nullable<decimal> HOMEDRAW { get; set; }
        public Nullable<decimal> DRAWAWAY { get; set; }
        public Nullable<decimal> HOMEAWAY_computed_ { get; set; }
        public Nullable<decimal> HOMEDRAW_computed_ { get; set; }
        public Nullable<decimal> DRAWAWAY_computed_ { get; set; }

        public Nullable<decimal> HOMEAWAY_disc { get; set; }
        public Nullable<decimal> HOMEDRAW_disc { get; set; }
        public Nullable<decimal> DRAWAWAY_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_0_5 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_0_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_0_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_0_5_disc{ get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_0_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_0_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_1_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_2_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_0_computed_ { get; set; }
        public Nullable<decimal> TO_2_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_2_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_2_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_2_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_2_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_3_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_3_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_3_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_3_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_3_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_3_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_3_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_3_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_75_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_0_disc{ get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_4_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_4_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_5_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_5_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_25_disc{ get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_5_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_5_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_75_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_6_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_5_disc { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_0_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_0_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_0_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_0_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_0_75_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_1_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_2_25 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_3_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_3_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_4_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_4_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_4_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_4_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_4_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1O_4_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_5_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]




        public Nullable<decimal> T2O_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_0_5 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_0_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_0_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_0_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_0_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T2O_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_1_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_0_computed_ { get; set; }
        public Nullable<decimal> T2O_1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_1_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_25_computed_ { get; set; }
        public Nullable<decimal> T2O_1_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_1_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_1_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_1_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_0_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_25_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_0_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_25_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_75_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_3_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_0_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_25_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_25_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_5_computed_ { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2O_4_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_5_disc { get; set; }

        



        [Column ("HOME_HDP 3,5")]
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [JsonProperty("HOME_HDP 3,5")]
        public Nullable<decimal> HOME_HDP_3_5 { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -3,5")]
        [JsonProperty("AWAY_HDP -3,5")]
        public Nullable<decimal> AWAY_HDP__3_5 { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 3,5_computed_")]
        [JsonProperty("HOME_HDP 3,5_computed_")]
        public Nullable<decimal> HOME_HDP_3_5_computed { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -3,5_computed_")]
        [JsonProperty("AWAY_HDP -3,5_computed_")]
        public Nullable<decimal> AWAY_HDP__3_5_computed { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 3,5_disc")]
        [JsonProperty("HOME_HDP 3,5_disc")]
        public Nullable<decimal> HOME_HDP_3_5_disc { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -3,5_disc")]
        [JsonProperty("AWAY_HDP -3,5_disc")]
        public Nullable<decimal> AWAY_HDP__3_5_disc { get; set; }
        

        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 3,0")]
        [JsonProperty("HOME_HDP 3,0")]
        public Nullable<decimal> HOME_HDP_3_0 { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -3,0")]
        [JsonProperty("AWAY_HDP -3,0")]
        public Nullable<decimal> AWAY_HDP__3_0 { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 3,0_computed_")]
        [JsonProperty("HOME_HDP 3,0_computed_")]
        public Nullable<decimal> HOME_HDP_3_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -3,0_computed_")]
        [JsonProperty("AWAY_HDP -3,0_computed_")]
        public Nullable<decimal> AWAY_HDP__3_0_computed { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 3,0_disc")]
        [JsonProperty("HOME_HDP 3,0_disc")]
        public Nullable<decimal> HOME_HDP_3_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -3,0_disc")]
        [JsonProperty("AWAY_HDP -3,0_disc")]
        public Nullable<decimal> AWAY_HDP__3_0_disc { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 2,75")]
        [JsonProperty("HOME_HDP 2,75")]
        public Nullable<decimal> HOME_HDP_2_75 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,75")]
        [JsonProperty("AWAY_HDP -2,75")]
        public Nullable<decimal> AWAY_HDP__2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 2,75_computed_")]
        [JsonProperty("HOME_HDP 2,75_computed_")]
        public Nullable<decimal> HOME_HDP_2_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,75_computed_")]
        [JsonProperty("AWAY_HDP -2,75_computed_")]
        public Nullable<decimal> AWAY_HDP__2_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 2,75_disc")]
        [JsonProperty("HOME_HDP 2,75_disc")]
        public Nullable<decimal> HOME_HDP_2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,75_disc")]
        [JsonProperty("AWAY_HDP -2,75_disc")]
        public Nullable<decimal> AWAY_HDP__2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 2,5")]
        [JsonProperty("HOME_HDP 2,5")]
        public Nullable<decimal> HOME_HDP_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,5")]
        [JsonProperty("AWAY_HDP -2,5")]
        public Nullable<decimal> AWAY_HDP__2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 2,5_computed_")]
        [JsonProperty("HOME_HDP 2,5_computed_")]
        public Nullable<decimal> HOME_HDP_2_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,5_computed_")]
        [JsonProperty("HOME_HDP -2,5_computed_")]
        public Nullable<decimal> AWAY_HDP__2_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 2,5_disc")]
        [JsonProperty("HOME_HDP 2,5_disc")]
        public Nullable<decimal> HOME_HDP_2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,5_disc")]
        [JsonProperty("HOME_HDP -2,5_disc")]
        public Nullable<decimal> AWAY_HDP__2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 2,0")]
        [JsonProperty("HOME_HDP 2,0")]

        public Nullable<decimal> HOME_HDP_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,0")]
        [JsonProperty("AWAY_HDP -2,0")]
        public Nullable<decimal> AWAY_HDP__2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 2,0_computed_")]
        [JsonProperty("HOME_HDP 2,0_computed_")]
        public Nullable<decimal> HOME_HDP_2_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,0_computed_")]
        [JsonProperty("AWAY_HDP -2,0_computed_")]
        public Nullable<decimal> AWAY_HDP__2_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 2,0_disc")]
        [JsonProperty("HOME_HDP 2,0_disc")]
        public Nullable<decimal> HOME_HDP_2_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,0_disc")]
        [JsonProperty("AWAY_HDP -2,0_disc")]
        public Nullable<decimal> AWAY_HDP__2_0_disc { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]


        [Column("HOME_HDP 1,75")]
        [JsonProperty("HOME_HDP 1,75")]
        public Nullable<decimal> HOME_HDP_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,75")]
        [JsonProperty("AWAY_HDP -1,75")]
        public Nullable<decimal> AWAY_HDP__1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 1,75_computed_")]
        [JsonProperty("HOME_HDP 1,75_computed_")]
        public Nullable<decimal> HOME_HDP_1_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,75_computed_")]
        [JsonProperty("AWAY_HDP -1,75_computed_")]
        public Nullable<decimal> AWAY_HDP__1_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 1,75_disc")]
        [JsonProperty("HOME_HDP 1,75_disc")]
        public Nullable<decimal> HOME_HDP_1_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,75_disc")]
        [JsonProperty("AWAY_HDP -1,75_disc")]
        public Nullable<decimal> AWAY_HDP__1_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 1,5")]
        [JsonProperty("HOME_HDP 1,5")]
        public Nullable<decimal> HOME_HDP_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,5")]
        [JsonProperty("AWAY_HDP -1,5")]
        public Nullable<decimal> AWAY_HDP__1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 1,5_computed_")]
        [JsonProperty("HOME_HDP 1,5_computed_")]
        public Nullable<decimal> HOME_HDP_1_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,5_computed_")]
        [JsonProperty("AWAY_HDP -1,5_computed_")]
        public Nullable<decimal> AWAY_HDP__1_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 1,5_disc")]
        [JsonProperty("HOME_HDP 1,5_disc")]
        public Nullable<decimal> HOME_HDP_1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,5_disc")]
        [JsonProperty("AWAY_HDP -1,5_disc")]
        public Nullable<decimal> AWAY_HDP__1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 1,0")]
        [JsonProperty("HOME_HDP 1,0")]
        public Nullable<decimal> HOME_HDP_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,0")]
        [JsonProperty("AWAY_HDP -1,0")]
        public Nullable<decimal> AWAY_HDP__1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 1,0_computed_")]
        [JsonProperty("HOME_HDP 1,0_computed_")]
        public Nullable<decimal> HOME_HDP_1_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,0_computed_")]
        [JsonProperty("AWAY_HDP -1,0_computed_")]
        public Nullable<decimal> AWAY_HDP__1_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 1,0_disc")]
        [JsonProperty("HOME_HDP 1,0_disc")]
        public Nullable<decimal> HOME_HDP_1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,0_disc")]
        [JsonProperty("AWAY_HDP -1,0_disc")]
        public Nullable<decimal> AWAY_HDP__1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 0,75")]
        [JsonProperty("HOME_HDP 0,75")]
        public Nullable<decimal> HOME_HDP_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,75")]
        [JsonProperty("AWAY_HDP -0,75")]
        public Nullable<decimal> AWAY_HDP__0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 0,75_computed_")]
        [JsonProperty("HOME_HDP 0,75_computed_")]

        public Nullable<decimal> HOME_HDP_0_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,75_computed_")]
        [JsonProperty("AWAY_HDP -0,75_computed_")]
        public Nullable<decimal> AWAY_HDP__0_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 0,75_disc")]
        [JsonProperty("HOME_HDP 0,75_disc")]
        public Nullable<decimal> HOME_HDP_0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,75_disc")]
        [JsonProperty("AWAY_HDP -0,75_disc")]
        public Nullable<decimal> AWAY_HDP__0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        [Column("HOME_HDP 0,5")]
        [JsonProperty("HOME_HDP 0,5")]
        public Nullable<decimal> HOME_HDP_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,5")]
        [JsonProperty("AWAY_HDP -0,5")]
        public Nullable<decimal> AWAY_HDP__0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 0,5_computed_")]
        [JsonProperty("HOME_HDP 0,5_computed_")]
        public Nullable<decimal> HOME_HDP_0_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,5_computed_")]
        [JsonProperty("AWAY_HDP -0,5_computed_")]
        public Nullable<decimal> AWAY_HDP__0_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 0,5_disc")]
        [JsonProperty("HOME_HDP 0,5_disc")]
        public Nullable<decimal> HOME_HDP_0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,5_disc")]
        [JsonProperty("AWAY_HDP -0,5_disc")]
        public Nullable<decimal> AWAY_HDP__0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 0,25")]
        [JsonProperty("HOME_HDP 0,25")]
        public Nullable<decimal> HOME_HDP_0_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,25")]
        [JsonProperty("AWAY_HDP -0,25")]
        public Nullable<decimal> AWAY_HDP__0_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 0,25_computed_")]
        [JsonProperty("HOME_HDP 0,25_computed_")]
        public Nullable<decimal> HOME_HDP_0_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP-0,25_computed_")]
        [JsonProperty("AWAY_HDP-0,25_computed_")]
        public Nullable<decimal> AWAY_HDP__0_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 0,25_disc")]
        [JsonProperty("HOME_HDP 0,25_disc")]
        public Nullable<decimal> HOME_HDP_0_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,25_disc")]
        [JsonProperty("AWAY_HDP -0,25_disc")]
        public Nullable<decimal> AWAY_HDP__0_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 0,0")]
        [JsonProperty("HOME_HDP 0,0")]
        public Nullable<decimal> HOME_HDP_0_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,0")]
        [JsonProperty("AWAY_HDP 0,0")]
        public Nullable<decimal> AWAY_HDP_0_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 0,0_computed_")]
        [JsonProperty("HOME_HDP 0,0_computed_")]
        public Nullable<decimal> HOME_HDP_0_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,0_computed_")]
        [JsonProperty("AWAY_HDP 0,0_computed_")]
        public Nullable<decimal> AWAY_HDP_0_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 0,0_disc")]
        [JsonProperty("HOME_HDP 0,0_disc")]
        public Nullable<decimal> HOME_HDP_0_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,0_disc")]
        [JsonProperty("AWAY_HDP 0,0_disc")]
        public Nullable<decimal> AWAY_HDP_0_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -0,25")]
        [JsonProperty("HOME_HDP -0,25")]
        public Nullable<decimal> HOME_HDP__0_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,25")]
        [JsonProperty("AWAY_HDP 0,25")]
        public Nullable<decimal> AWAY_HDP_0_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -0,25_computed_")]
        [JsonProperty("HOME_HDP -0,25_computed_")]
        public Nullable<decimal> HOME_HDP__0_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,25_computed_")]
        [JsonProperty("AWAY_HDP 0,25_computed_")]
        public Nullable<decimal> AWAY_HDP_0_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -0,25_disc")]
        [JsonProperty("HOME_HDP -0,25_disc")]
        public Nullable<decimal> HOME_HDP__0_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,25_disc")]
        [JsonProperty("AWAY_HDP 0,25_disc")]
        public Nullable<decimal> AWAY_HDP_0_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -0,5")]
        [JsonProperty("HOME_HDP -0,5")]
        public Nullable<decimal> HOME_HDP__0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,5")]
        [JsonProperty("AWAY_HDP 0,5")]
        public Nullable<decimal> AWAY_HDP_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -0,5_computed_")]
        [JsonProperty("HOME_HDP -0,5_computed_")]
        public Nullable<decimal> HOME_HDP__0_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,5_computed_")]
        [JsonProperty("AWAY_HDP 0,5_computed_")]
        public Nullable<decimal> AWAY_HDP_0_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -0,5_disc")]
        [JsonProperty("HOME_HDP -0,5_disc")]
        public Nullable<decimal> HOME_HDP__0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,5_disc")]
        [JsonProperty("AWAY_HDP 0,5_disc")]
        public Nullable<decimal> AWAY_HDP_0_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -0,75")]
        [JsonProperty("HOME_HDP -0,75")]
        public Nullable<decimal> HOME_HDP__0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,75")]
        [JsonProperty("AWAY_HDP 0,75")]
        public Nullable<decimal> AWAY_HDP_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -0,75_computed_")]
        [JsonProperty("HOME_HDP -0,75_computed_")]
        public Nullable<decimal> HOME_HDP__0_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,75_computed_")]
        [JsonProperty("AWAY_HDP 0,75_computed_")]
        public Nullable<decimal> AWAY_HDP_0_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -0,75_disc")]
        [JsonProperty("HOME_HDP -0,75_disc")]
        public Nullable<decimal> HOME_HDP__0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,75_disc")]
        [JsonProperty("AWAY_HDP 0,75_disc")]
        public Nullable<decimal> AWAY_HDP_0_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -1,0")]
        [JsonProperty("HOME_HDP -1,0")]
        public Nullable<decimal> HOME_HDP__1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,0")]
        [JsonProperty("AWAY_HDP 1,0")]
        public Nullable<decimal> AWAY_HDP_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -1,0_computed_")]
        [JsonProperty("HOME_HDP -1,0_computed_")]
        public Nullable<decimal> HOME_HDP__1_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,0_computed_")]
        [JsonProperty("AWAY_HDP 1,0_computed_")]
        public Nullable<decimal> AWAY_HDP_1_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -1,0_disc")]
        [JsonProperty("HOME_HDP -1,0_disc")]
        public Nullable<decimal> HOME_HDP__1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,0_disc")]
        [JsonProperty("AWAY_HDP 1,0_disc")]
        public Nullable<decimal> AWAY_HDP_1_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -1,25")]
        [JsonProperty("HOME_HDP -1,25")]
        public Nullable<decimal> HOME_HDP__1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,25")]
        [JsonProperty("AWAY_HDP 1,25")]
        public Nullable<decimal> AWAY_HDP_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -1,25_computed_")]
        [JsonProperty("HOME_HDP -1,25_computed_")]
        public Nullable<decimal> HOME_HDP__1_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,25_computed_")]
        [JsonProperty("AWAY_HDP 1,25_computed_")]
        public Nullable<decimal> AWAY_HDP_1_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -1,25_disc")]
        [JsonProperty("HOME_HDP -1,25_disc")]
        public Nullable<decimal> HOME_HDP__1_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,25_disc")]
        [JsonProperty("AWAY_HDP 1,25_disc")]
        public Nullable<decimal> AWAY_HDP_1_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -1,5")]
        [JsonProperty("HOME_HDP -1,5")]
        public Nullable<decimal> HOME_HDP__1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,5")]
        [JsonProperty("AWAY_HDP 1,5")]
        public Nullable<decimal> AWAY_HDP_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -1,5_computed_")]
        [JsonProperty("HOME_HDP -1,5_computed_")]
        public Nullable<decimal> HOME_HDP__1_5_computed { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,5_computed_")]
        [JsonProperty("AWAY_HDP 1,5_computed_")]
        public Nullable<decimal> AWAY_HDP_1_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -1,5_disc")]
        [JsonProperty("HOME_HDP -1,5_disc")]
        public Nullable<decimal> HOME_HDP__1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("AWAY_HDP 1,5_disc")]
        [JsonProperty("AWAY_HDP 1,5_disc")]
        public Nullable<decimal> AWAY_HDP_1_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -2,0")]
        [JsonProperty("HOME_HDP -2,0")]
        public Nullable<decimal> HOME_HDP__2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,0")]
        [JsonProperty("AWAY_HDP 2,0")]
        public Nullable<decimal> AWAY_HDP_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -2,0_computed_")]
        [JsonProperty("HOME_HDP -2,0_computed_")]
        public Nullable<decimal> HOME_HDP__2_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,0_computed_")]
        [JsonProperty("AWAY_HDP 2,0_computed_")]
        public Nullable<decimal> AWAY_HDP_2_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -2,0_disc")]
        [JsonProperty("HOME_HDP -2,0_disc")]
        public Nullable<decimal> HOME_HDP__2_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,0_disc")]
        [JsonProperty("AWAY_HDP 2,0_disc")]
        public Nullable<decimal> AWAY_HDP_2_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -2,25")]
        [JsonProperty("HOME_HDP -2,25")]
        public Nullable<decimal> HOME_HDP__2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,25")]
        [JsonProperty("AWAY_HDP 2,25")]
        public Nullable<decimal> AWAY_HDP_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -2,25_computed_")]
        [JsonProperty("HOME_HDP -2,25_computed_")]
        public Nullable<decimal> HOME_HDP__2_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,25_computed_")]
        [JsonProperty("AWAY_HDP 2,25_computed_")]
        public Nullable<decimal> AWAY_HDP_2_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -2,25_disc")]
        [JsonProperty("HOME_HDP -2,25_disc")]
        public Nullable<decimal> HOME_HDP__2_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,25_disc")]
        [JsonProperty("AWAY_HDP 2,25_disc")]
        public Nullable<decimal> AWAY_HDP_2_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -2,5")]
        [JsonProperty("HOME_HDP -2,5")]
        public Nullable<decimal> HOME_HDP__2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,5")]
        [JsonProperty("AWAY_HDP 2,5")]
        public Nullable<decimal> AWAY_HDP_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -2,5_computed_")]
        [JsonProperty("HOME_HDP -2,5_computed_")]
        public Nullable<decimal> HOME_HDP__2_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,5_computed_")]
        [JsonProperty("AWAY_HDP 2,5_computed_")]
        public Nullable<decimal> AWAY_HDP_2_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -2,5_disc")]
        [JsonProperty("HOME_HDP -2,5_disc")]
        public Nullable<decimal> HOME_HDP__2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,5_disc")]
        [JsonProperty("AWAY_HDP 2,5_disc")]
        public Nullable<decimal> AWAY_HDP_2_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -2,75")]
        [JsonProperty("HOME_HDP -2,75")]
        public Nullable<decimal> HOME_HDP__2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,75")]
        [JsonProperty("AWAY_HDP 2,75")]
        public Nullable<decimal> AWAY_HDP_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -2,75_computed_")]
        [JsonProperty("HOME_HDP -2,75_computed_")]
        public Nullable<decimal> HOME_HDP__2_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,75_computed_")]
        [JsonProperty("AWAY_HDP 2,75_computed_")]
        public Nullable<decimal> AWAY_HDP_2_75_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -2,75_disc")]
        [JsonProperty("HOME_HDP -2,75_disc")]
        public Nullable<decimal> HOME_HDP__2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,75_disc")]
        [JsonProperty("AWAY_HDP 2,75_disc")]
        public Nullable<decimal> AWAY_HDP_2_75_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -3,0")]
        [JsonProperty("HOME_HDP -3,0")]
        public Nullable<decimal> HOME_HDP__3_0 { get; set; }

        [Column("AWAY_HDP 3,0")]
        [JsonProperty("AWAY_HDP 3,0")]
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> AWAY_HDP_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -3,0_computed_")]
        [JsonProperty("HOME_HDP -3,0_computed_")]

        public Nullable<decimal> HOME_HDP__3_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,0_computed_")]
        [JsonProperty("AWAY_HDP 3,0_computed_")]
        public Nullable<decimal> AWAY_HDP_3_0_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -3,0_disc")]
        [JsonProperty("HOME_HDP -3,0_disc")]
        public Nullable<decimal> HOME_HDP__3_0_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,0_disc")]
        [JsonProperty("AWAY_HDP 3,0_disc")]
        public Nullable<decimal> AWAY_HDP_3_0_disc{ get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -3,25")]
        [JsonProperty("HOME_HDP -3,25")]
        public Nullable<decimal> HOME_HDP__3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,25")]
        [JsonProperty("AWAY_HDP 3,25")]
        public Nullable<decimal> AWAY_HDP_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -3,25_computed_")]
        [JsonProperty("HOME_HDP -3,25_computed_")]
        public Nullable<decimal> HOME_HDP__3_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,25_computed_")]
        [JsonProperty("AWAY_HDP 3,25_computed_")]
        public Nullable<decimal> AWAY_HDP_3_25_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -3,25_disc")]
        [JsonProperty("HOME_HDP -3,25_disc")]
        public Nullable<decimal> HOME_HDP__3_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,25_disc")]
        [JsonProperty("AWAY_HDP 3,25_disc")]
        public Nullable<decimal> AWAY_HDP_3_25_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -3,5")]
        [JsonProperty("HOME_HDP -3,5")]
        public Nullable<decimal> HOME_HDP__3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,5")]
        [JsonProperty("AWAY_HDP 3,5")]
        public Nullable<decimal> AWAY_HDP_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -3,5_computed_")]
        [JsonProperty("HOME_HDP -3,5_computed_")]
        public Nullable<decimal> HOME_HDP__3_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,5_computed_")]
        [JsonProperty("AWAY_HDP 3,5_computed_")]
        public Nullable<decimal> AWAY_HDP_3_5_computed { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP -3,5_disc")]
        [JsonProperty("HOME_HDP -3,5_disc")]
        public Nullable<decimal> HOME_HDP__3_5_disc { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,5_disc")]
        [JsonProperty("AWAY_HDP 3,5_disc")]
        public Nullable<decimal> AWAY_HDP_3_5_disc { get; set; }




    }
}
