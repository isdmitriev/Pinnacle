using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Olimp.Dal
{
   public class OlimpPrices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string EventId { get; set; }





        public string DateAdded { get; set; }
        public bool? IsLive { get; set; }
        public string StartTime { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string LeagueName { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> HOME { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> DRAW { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> AWAY { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]






        public Nullable<decimal> HOMEAWAY { get; set; }
        public Nullable<decimal> HOMEDRAW { get; set; }
        public Nullable<decimal> DRAWAWAY { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TO_0_5 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]




        public Nullable<decimal> TO_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> TO_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> TO_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> TO_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_4_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_4_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_5_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> TO_5_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_5_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_5_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_5_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> TO_6_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_6_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> TO_6_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> TU_6_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]




        public Nullable<decimal> T1O_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> T1O_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T1O_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T1O_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> T1O_2_25 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T1O_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T1O_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> T1O_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T1O_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T1O_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T1O_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T1O_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T1U_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]








        public Nullable<decimal> T2O_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_0_5 { get; set; }



        public Nullable<decimal> T2O_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T2O_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T2O_1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_25 { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T2O_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T2O_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> T2O_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]


        public Nullable<decimal> T2O_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_3_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]

        public Nullable<decimal> T2O_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]



        public Nullable<decimal> T2O_4_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> T2U_4_5 { get; set; }






        [Column("HOME_HDP 3,5")]
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [JsonProperty("HOME_HDP 3,5")]
        public Nullable<decimal> HOME_HDP_3_5 { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -3,5")]
        [JsonProperty("AWAY_HDP -3,5")]
        public Nullable<decimal> AWAY_HDP__3_5 { get; set; }










        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 3,0")]
        [JsonProperty("HOME_HDP 3,0")]
        public Nullable<decimal> HOME_HDP_3_0 { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -3,0")]
        [JsonProperty("AWAY_HDP -3,0")]
        public Nullable<decimal> AWAY_HDP__3_0 { get; set; }






        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 2,75")]
        [JsonProperty("HOME_HDP 2,75")]
        public Nullable<decimal> HOME_HDP_2_75 { get; set; }

        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,75")]
        [JsonProperty("AWAY_HDP -2,75")]
        public Nullable<decimal> AWAY_HDP__2_75 { get; set; }


        public Nullable<decimal> HOME_HDP_2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,5")]
        [JsonProperty("AWAY_HDP -2,5")]
        public Nullable<decimal> AWAY_HDP__2_5 { get; set; }

      
      
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 2,0")]
        [JsonProperty("HOME_HDP 2,0")]

        public Nullable<decimal> HOME_HDP_2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -2,0")]
        [JsonProperty("AWAY_HDP -2,0")]
        public Nullable<decimal> AWAY_HDP__2_0 { get; set; }


      
      


        [DisplayFormat(DataFormatString = "{0:F7}")]


        [Column("HOME_HDP 1,75")]
        [JsonProperty("HOME_HDP 1,75")]
        public Nullable<decimal> HOME_HDP_1_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,75")]
        [JsonProperty("AWAY_HDP -1,75")]
        public Nullable<decimal> AWAY_HDP__1_75 { get; set; }
       
        
       
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 1,5")]
        [JsonProperty("HOME_HDP 1,5")]
        public Nullable<decimal> HOME_HDP_1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,5")]
        [JsonProperty("AWAY_HDP -1,5")]
        public Nullable<decimal> AWAY_HDP__1_5 { get; set; }


       


        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("HOME_HDP 1,0")]
        [JsonProperty("HOME_HDP 1,0")]
        public Nullable<decimal> HOME_HDP_1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -1,0")]
        [JsonProperty("AWAY_HDP -1,0")]
        public Nullable<decimal> AWAY_HDP__1_0 { get; set; }
      
  
        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP 0,75")]
        [JsonProperty("HOME_HDP 0,75")]
        public Nullable<decimal> HOME_HDP_0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,75")]
        [JsonProperty("AWAY_HDP -0,75")]
        public Nullable<decimal> AWAY_HDP__0_75 { get; set; }
      
        [DisplayFormat(DataFormatString = "{0:F7}")]



        [Column("HOME_HDP 0,5")]
        [JsonProperty("HOME_HDP 0,5")]
        public Nullable<decimal> HOME_HDP_0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,5")]
        [JsonProperty("AWAY_HDP -0,5")]
        public Nullable<decimal> AWAY_HDP__0_5 { get; set; }











        [Column("HOME_HDP 0,25")]
        [JsonProperty("HOME_HDP 0,25")]
        public Nullable<decimal> HOME_HDP_0_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP -0,25")]
        [JsonProperty("AWAY_HDP -0,25")]
        public Nullable<decimal> AWAY_HDP__0_25 { get; set; }








        [Column("HOME_HDP 0,0")]
        [JsonProperty("HOME_HDP 0,0")]
        public Nullable<decimal> HOME_HDP_0_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,0")]
        [JsonProperty("AWAY_HDP 0,0")]
        public Nullable<decimal> AWAY_HDP_0_0 { get; set; }




        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -0,25")]
        [JsonProperty("HOME_HDP -0,25")]
        public Nullable<decimal> HOME_HDP__0_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,25")]
        [JsonProperty("AWAY_HDP 0,25")]
        public Nullable<decimal> AWAY_HDP_0_25 { get; set; }




        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -0,5")]
        [JsonProperty("HOME_HDP -0,5")]
        public Nullable<decimal> HOME_HDP__0_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,5")]
        [JsonProperty("AWAY_HDP 0,5")]
        public Nullable<decimal> AWAY_HDP_0_5 { get; set; }





        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -0,75")]
        [JsonProperty("HOME_HDP -0,75")]
        public Nullable<decimal> HOME_HDP__0_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 0,75")]
        [JsonProperty("AWAY_HDP 0,75")]
        public Nullable<decimal> AWAY_HDP_0_75 { get; set; }








        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -1,0")]
        [JsonProperty("HOME_HDP -1,0")]
        public Nullable<decimal> HOME_HDP__1_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,0")]
        [JsonProperty("AWAY_HDP 1,0")]
        public Nullable<decimal> AWAY_HDP_1_0 { get; set; }





        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -1,25")]
        [JsonProperty("HOME_HDP -1,25")]
        public Nullable<decimal> HOME_HDP__1_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,25")]
        [JsonProperty("AWAY_HDP 1,25")]
        public Nullable<decimal> AWAY_HDP_1_25 { get; set; }





        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -1,5")]
        [JsonProperty("HOME_HDP -1,5")]
        public Nullable<decimal> HOME_HDP__1_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 1,5")]
        [JsonProperty("AWAY_HDP 1,5")]
        public Nullable<decimal> AWAY_HDP_1_5 { get; set; }







        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -2,0")]
        [JsonProperty("HOME_HDP -2,0")]
        public Nullable<decimal> HOME_HDP__2_0 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,0")]
        [JsonProperty("AWAY_HDP 2,0")]
        public Nullable<decimal> AWAY_HDP_2_0 { get; set; }


        [DisplayFormat(DataFormatString = "{0:F7}")]






        [Column("HOME_HDP -2,25")]
        [JsonProperty("HOME_HDP -2,25")]
        public Nullable<decimal> HOME_HDP__2_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,25")]
        [JsonProperty("AWAY_HDP 2,25")]
        public Nullable<decimal> AWAY_HDP_2_25 { get; set; }






        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -2,5")]
        [JsonProperty("HOME_HDP -2,5")]
        public Nullable<decimal> HOME_HDP__2_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,5")]
        [JsonProperty("AWAY_HDP 2,5")]
        public Nullable<decimal> AWAY_HDP_2_5 { get; set; }






        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -2,75")]
        [JsonProperty("HOME_HDP -2,75")]
        public Nullable<decimal> HOME_HDP__2_75 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 2,75")]
        [JsonProperty("AWAY_HDP 2,75")]
        public Nullable<decimal> AWAY_HDP_2_75 { get; set; }





        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -3,0")]
        [JsonProperty("HOME_HDP -3,0")]
        public Nullable<decimal> HOME_HDP__3_0 { get; set; }

        [Column("AWAY_HDP 3,0")]
        [JsonProperty("AWAY_HDP 3,0")]
        [DisplayFormat(DataFormatString = "{0:F7}")]
        public Nullable<decimal> AWAY_HDP_3_0 { get; set; }









        [Column("HOME_HDP -3,25")]
        [JsonProperty("HOME_HDP -3,25")]
        public Nullable<decimal> HOME_HDP__3_25 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,25")]
        [JsonProperty("AWAY_HDP 3,25")]
        public Nullable<decimal> AWAY_HDP_3_25 { get; set; }






        [DisplayFormat(DataFormatString = "{0:F7}")]

        [Column("HOME_HDP -3,5")]
        [JsonProperty("HOME_HDP -3,5")]
        public Nullable<decimal> HOME_HDP__3_5 { get; set; }
        [DisplayFormat(DataFormatString = "{0:F7}")]
        [Column("AWAY_HDP 3,5")]
        [JsonProperty("AWAY_HDP 3,5")]
        public Nullable<decimal> AWAY_HDP_3_5 { get; set; }




    }
}
