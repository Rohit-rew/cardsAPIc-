using System;

namespace Cards_API.Helpers
{

    public class Card {
        public string code {get;set;}
        public string imageUrl {get;set;}
        public string suite {get;set;}
        public int value {get; set;}
    }

    static public class HelpersFunc {

        //should be 12 digits
        //should contain numbers and letters
        //can containg uppercase and lowercase letters
        static public string DeckIdGenerator(){
            Guid myUuid = Guid.NewGuid();
            string myUuidAsString = myUuid.ToString();
            string[] arr = myUuidAsString.Split("-");
            string deckId = arr[arr.Length-1];
            return deckId;
        }



        static public List<Card> allCards = new List<Card>{
            new Card {
                code = "AD",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/aceDiamonds_9yQnER_u0.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355645855",
                suite = "diamond",
                value = 1
           },

            new Card {
                code = "2D",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/2D_5YWFropS7.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355647476",
                suite = "diamond",
                value = 2
           },

            new Card {
                code = "3D",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/3D_RS0v5ROtGZ.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355647559",
                suite = "diamond",
                value = 3
           },

            new Card  {   
                code = "4D",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/4D_lmrGZEFMIf.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355648332",
                suite = "diamond",
                value = 4
            },

            new Card {   
                code = "5D",
                imageUrl = "dewdhttps://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/5D_4gOD2eDXbA.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355649203wed",
                suite = "diamond",
                value = 5
            },

            new Card {   
                code = "6D",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/6D_AeZwOsrh7U.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355645134",
                suite = "diamond",
                value = 6
            },
            new Card {   
                code = "7D",
                imageUrl  ="https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/7D_ak_U6WW2g.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355646477",
                suite = "diamond",
                value = 7
            },
            new Card {   
                code = "8D",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/8D_No8sbz9tM.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355648289",
                suite = "diamond",
                value = 8
            },
            new Card {   
                code = "9D",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/9D_DgP26BLgFB.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355649122",
                suite = "diamond",
                value = 9
            },
            new Card {   
                code = "0D",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/0D_9jPapwWUs.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355646738",
                suite = "diamond",
                value = 10
            },
            new Card {   
                code = "JD",
                imageUrl = "dewdwhttps://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/JD_V5Du60bs6.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355647433ed",
                suite = "diamond",
                value = 11
            },
            new Card {   
                code = "QD",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/QD_oqhbdEkcTL.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355647697",
                suite = "diamond",
                value = 12
            },
            new Card {   
                code = "KD",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/diamond/KD_AkAyLrI-E.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355647453",
                suite = "diamond",
                value = 13
            },

        // diamond ends

        // spade starts


            new Card {   
                code = "AS",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/ace_spade_c6UrAj1ZP6.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355641975",
                suite = "spades",
                value = 1
            },
            new Card {   
                code = "2S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/2S_vUMlgUfkfs.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355639067",
                suite = "spades",
                value = 2
            },
            new Card {   
                code = "3S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/3S_dVPB-5nSh.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355640092",
                suite = "spades",
                value = 3
            },
            new Card {   
                code = "4S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/4S_rA2D6xjPf.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355639779",
                suite = "spades",
                value = 4
            },
            new Card {   
                code = "5S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/5S_GisLd8c8h.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355641599",
                suite = "spades",
                value = 5
            },
            new Card {   
                code = "6S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/6S_JI_sIG2C-.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355637734",
                suite = "spades",
                value = 6
            },
            new Card {   
                code = "7S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/7S_NrkK4IuVPp.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355637886",
                suite = "spades",
                value = 7
            },
            new Card {   
                code = "8S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/8S_BT7bK8PuyQ.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355641336",
                suite = "spades",
                value = 8
            },
            new Card {   
                code = "9S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/9S_poS8D0y3M.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355640903",
                suite = "spades",
                value = 8
            },
            new Card {   
                code = "0S",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/0S_F1iW9TDR6G.png?ik-sdk-version=javascript-1.4.3&updatedAt=166935563hearts",
                suite = "spades",
                value = 10
            },
            new Card {   
                code = "JS",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/JS_zqNe6C-gFQ.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355639067",
                suite = "spades",
                value = 11
            },
            new Card {   
                code = "QS",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/QS_M79DjO9I-.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355639450",
                suite = "spades",
                value = 12
            },
            new Card {   
                code = "KS",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/spades/KS_R4En2ML_oB.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355637913",
                suite = "spades",
                value = 13
            },

        //spade ends

        //club starts
            new Card {   
                code = "AC",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/ace_clubs_R_w8EwyWs.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355644809",
                suite = "clubs",
                value = 1
            },
            new Card {   
                code = "2C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/2C_ZRFyUKhWz.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355645039",
                suite = "clubs",
                value = 2
            },
            new Card {   
                code = "3C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/3C_nPgbs2tbT8.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355643319",
                suite = "clubs",
                value = 3
            },
            new Card {   
                code = "4C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/4C_ru3DFITYb.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355644936",
                suite = "clubs",
                value = 4
            },
            new Card {   
                code = "5C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/5C_F8qAAjsAFv.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355645912",
                suite = "clubs",
                value = 5
            },
            new Card {   
                code = "6C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/6C_bclubsm1.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355641943",
                suite = "clubs",
                value = 6
            },
            new Card {   
                code = "7C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/7C_Ako3cuyDy.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355641966",
                suite = "clubs",
                value = 7
            },
            new Card {   
                code = "8C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/8C_J7htLusSWb.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355647490",
                suite = "clubs",
                value = 8
            },
            new Card {   
                code = "9C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/9C_kr-9Zfxhw_.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355644940",
                suite = "clubs",
                value = 9
            },
            new Card {   
                code = "0C",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/0C_HQhQHPeKm.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355642777",
                suite = "clubs",
                value = 10
            },
            new Card {   
                code = "JC",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/JC_M20zogqWBU.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355642552",
                suite = "clubs",
                value = 11
            },
            new Card {   
                code = "QC",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/QC_ldfkfR_UZ.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355644322",
                suite = "clubs",
                value = 12
            },
            new Card {   
                code = "KC",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/clubs/KC_GyJa-aHAF.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355644181",
                suite = "clubs",
                value = 13
            },

        // CLUBS ENDS 

        // HEART STARTS

            new Card {   
                code = "AH",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/ace_hearts_7Z1sP01vyv.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355633268",
                suite = "hearts",
                value = 1
            },
            new Card {   
                code = "2H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/2H__nolJLuRd.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355634276",
                suite = "hearts",
                value = 2
            },
            new Card {   
                code = "3H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/3H_icz3HmUL6-.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355634353",
                suite = "hearts",
                value = 3
            },
            new Card {   
                code = "4H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/4H_FrUwVn5QaW.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355633629",
                suite = "hearts",
                value = 4
            },
            new Card {   
                code = "5H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/5H_GQnY2sJGf.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355633341",
                suite = "hearts",
                value = 5
            },
            new Card {   
                code = "6H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/6H_KhznaZZIP.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355637311",
                suite = "hearts",
                value = 6
            },
            new Card {   
                code = "7H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/7H_APPqxfyaC.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355636971",
                suite = "hearts",
                value = 7
            },
            new Card {   
                code = "8H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/8H_j7VIHPjrgs.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355634124",
                suite = "hearts",
                value = 8
            },
            new Card {   
                code = "9H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/9H_H9ex_kFLZ.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355633509",
                suite = "hearts",
                value = 9
            },
            new Card {   
                code = "0H",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/0H_5NfJMIocTR.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355634910",
                suite = "hearts",
                value = 10
            },
            new Card {   
                code = "JH",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/JH_EkTaOgSzp.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355634380",
                suite = "hearts",
                value = 11
            },
            new Card {   
                code = "QH",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/QH_WhpS3ItxI.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355634360",
                suite = "hearts",
                value = 12
            },
            new Card {   
                code = "KH",
                imageUrl = "https://ik.imagekit.io/ylyzsq6uc/cardAPI/hearts/KH_gFtUzW0Ce.png?ik-sdk-version=javascript-1.4.3&updatedAt=1669355636347",
                suite = "hearts",
                value = 13
            },

        };

    }

}



  
  
    
    