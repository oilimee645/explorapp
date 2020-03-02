using System;
using System.Collections.Generic;
using System.Text;

namespace ExplorAppTeo.Models
{
    public class AudioList
    {
        List<AudioMenuItem> audioItems;

        public AudioList()
        {

        }

        public List<AudioMenuItem> List(int Puerta)
        {
            switch(Puerta)
            {
                case 1:
                    audioItems = new List<AudioMenuItem>
                    {
                        new AudioMenuItem { Id = 0, Title = "0. " + AudioItem.Name[0], Duration = AudioItem.Duration[0], URL = AudioItem.URL[0], Seconds = AudioItem.Seconds[0]},
                        new AudioMenuItem { Id = 1, Title = "1. " + AudioItem.Name[6], Duration = AudioItem.Duration[6], URL = AudioItem.URL[6], Seconds = AudioItem.Seconds[6] },
                        new AudioMenuItem { Id = 2, Title = "2. " + AudioItem.Name[9], Duration = AudioItem.Duration[9], URL = AudioItem.URL[9], Seconds = AudioItem.Seconds[9] },
                        new AudioMenuItem { Id = 3, Title = "3. " + AudioItem.Name[11], Duration = AudioItem.Duration[11], URL = AudioItem.URL[11], Seconds = AudioItem.Seconds[11] },
                        new AudioMenuItem { Id = 4, Title = "4. " + AudioItem.Name[5], Duration = AudioItem.Duration[5], URL = AudioItem.URL[5], Seconds = AudioItem.Seconds[5] },
                        new AudioMenuItem { Id = 5, Title = "5. " + AudioItem.Name[3], Duration = AudioItem.Duration[3], URL = AudioItem.URL[3], Seconds = AudioItem.Seconds[3] },
                        new AudioMenuItem { Id = 6, Title = "6. " + AudioItem.Name[2], Duration = AudioItem.Duration[2], URL = AudioItem.URL[2], Seconds = AudioItem.Seconds[2] },
                        new AudioMenuItem { Id = 7, Title = "7. " + AudioItem.Name[1], Duration = AudioItem.Duration[1], URL = AudioItem.URL[1], Seconds = AudioItem.Seconds[1] },
                        new AudioMenuItem { Id = 8, Title = "8. " + AudioItem.Name[4], Duration = AudioItem.Duration[4], URL = AudioItem.URL[4], Seconds = AudioItem.Seconds[4] },
                        new AudioMenuItem { Id = 9, Title = "9. " + AudioItem.Name[12], Duration = AudioItem.Duration[12], URL = AudioItem.URL[12], Seconds = AudioItem.Seconds[12] },
                        new AudioMenuItem { Id = 10, Title= "10. " + AudioItem.Name[7], Duration = AudioItem.Duration[7], URL = AudioItem.URL[7], Seconds = AudioItem.Seconds[7] },
                        new AudioMenuItem { Id = 11, Title = "11. " + AudioItem.Name[15], Duration = AudioItem.Duration[15], URL = AudioItem.URL[15], Seconds = AudioItem.Seconds[15] },
                        new AudioMenuItem { Id = 12, Title = "12. " + AudioItem.Name[13], Duration = AudioItem.Duration[13], URL = AudioItem.URL[13], Seconds = AudioItem.Seconds[13] },
                        new AudioMenuItem { Id = 13, Title = "13. " + AudioItem.Name[14], Duration = AudioItem.Duration[14], URL = AudioItem.URL[14], Seconds = AudioItem.Seconds[14] },
                        new AudioMenuItem { Id = 14, Title = "14. " + AudioItem.Name[10], Duration = AudioItem.Duration[10], URL = AudioItem.URL[10], Seconds = AudioItem.Seconds[10] },
                        new AudioMenuItem { Id = 15, Title = "15. " + AudioItem.Name[17], Duration = AudioItem.Duration[17], URL = AudioItem.URL[17], Seconds = AudioItem.Seconds[17] },
                        new AudioMenuItem { Id = 16, Title = "16. " + AudioItem.Name[8], Duration = AudioItem.Duration[8], URL = AudioItem.URL[8], Seconds = AudioItem.Seconds[8] },
                        new AudioMenuItem { Id = 17, Title = "17. " + AudioItem.Name[16], Duration = AudioItem.Duration[16], URL = AudioItem.URL[16], Seconds = AudioItem.Seconds[16] }
                    };
                    break;

                case 2:
                    audioItems = new List<AudioMenuItem>
                    {
                        new AudioMenuItem { Id = 0, Title = "0. " + AudioItem.Name[0], Duration = AudioItem.Duration[0], URL = AudioItem.URL[0], Seconds = AudioItem.Seconds[0]},
                        new AudioMenuItem { Id = 1, Title = "1. " + AudioItem.Name[5], Duration = AudioItem.Duration[5], URL = AudioItem.URL[5], Seconds = AudioItem.Seconds[5] },
                        new AudioMenuItem { Id = 2, Title = "2. " + AudioItem.Name[12], Duration = AudioItem.Duration[12], URL = AudioItem.URL[12], Seconds = AudioItem.Seconds[12] },
                        new AudioMenuItem { Id = 3, Title = "3. " + AudioItem.Name[4], Duration = AudioItem.Duration[4], URL = AudioItem.URL[4], Seconds = AudioItem.Seconds[4] },
                        new AudioMenuItem { Id = 4, Title = "4. " + AudioItem.Name[1], Duration = AudioItem.Duration[1], URL = AudioItem.URL[1], Seconds = AudioItem.Seconds[1] },
                        new AudioMenuItem { Id = 5, Title = "5. " + AudioItem.Name[2], Duration = AudioItem.Duration[2], URL = AudioItem.URL[2], Seconds = AudioItem.Seconds[2] },
                        new AudioMenuItem { Id = 6, Title = "6. " + AudioItem.Name[3], Duration = AudioItem.Duration[3], URL = AudioItem.URL[3], Seconds = AudioItem.Seconds[3] },
                        new AudioMenuItem { Id = 7, Title = "7. " + AudioItem.Name[6], Duration = AudioItem.Duration[6], URL = AudioItem.URL[6], Seconds = AudioItem.Seconds[6] },
                        new AudioMenuItem { Id = 8, Title = "8. " + AudioItem.Name[9], Duration = AudioItem.Duration[9], URL = AudioItem.URL[9], Seconds = AudioItem.Seconds[9] },
                        new AudioMenuItem { Id = 9, Title = "9. " + AudioItem.Name[11], Duration = AudioItem.Duration[11], URL = AudioItem.URL[11], Seconds = AudioItem.Seconds[11] },
                        new AudioMenuItem { Id = 10, Title= "10. " + AudioItem.Name[7], Duration = AudioItem.Duration[7], URL = AudioItem.URL[7], Seconds = AudioItem.Seconds[7] },
                        new AudioMenuItem { Id = 11, Title = "11. " + AudioItem.Name[15], Duration = AudioItem.Duration[15], URL = AudioItem.URL[15], Seconds = AudioItem.Seconds[15] },
                        new AudioMenuItem { Id = 12, Title = "12. " + AudioItem.Name[13], Duration = AudioItem.Duration[13], URL = AudioItem.URL[13], Seconds = AudioItem.Seconds[13] },
                        new AudioMenuItem { Id = 13, Title = "13. " + AudioItem.Name[14], Duration = AudioItem.Duration[14], URL = AudioItem.URL[14], Seconds = AudioItem.Seconds[14] },
                        new AudioMenuItem { Id = 14, Title = "14. " + AudioItem.Name[10], Duration = AudioItem.Duration[10], URL = AudioItem.URL[10], Seconds = AudioItem.Seconds[10] },
                        new AudioMenuItem { Id = 15, Title = "15. " + AudioItem.Name[17], Duration = AudioItem.Duration[17], URL = AudioItem.URL[17], Seconds = AudioItem.Seconds[17] },
                        new AudioMenuItem { Id = 16, Title = "16. " + AudioItem.Name[8], Duration = AudioItem.Duration[8], URL = AudioItem.URL[8], Seconds = AudioItem.Seconds[8] },
                        new AudioMenuItem { Id = 17, Title = "17. " + AudioItem.Name[16], Duration = AudioItem.Duration[16], URL = AudioItem.URL[16], Seconds = AudioItem.Seconds[16] }
                    };
                    break;

                case 3:
                    audioItems = new List<AudioMenuItem>
                    {
                        new AudioMenuItem { Id = 0, Title = "0. " + AudioItem.Name[0], Duration = AudioItem.Duration[0], URL = AudioItem.URL[0], Seconds = AudioItem.Seconds[0]},
                        new AudioMenuItem { Id = 1, Title = "1. " + AudioItem.Name[16], Duration = AudioItem.Duration[16], URL = AudioItem.URL[16], Seconds = AudioItem.Seconds[16] },
                        new AudioMenuItem { Id = 2, Title = "2. " + AudioItem.Name[8], Duration = AudioItem.Duration[8], URL = AudioItem.URL[8], Seconds = AudioItem.Seconds[8] },
                        new AudioMenuItem { Id = 3, Title = "3. " + AudioItem.Name[17], Duration = AudioItem.Duration[17], URL = AudioItem.URL[17], Seconds = AudioItem.Seconds[17] },
                        new AudioMenuItem { Id = 4, Title = "4. " + AudioItem.Name[10], Duration = AudioItem.Duration[10], URL = AudioItem.URL[10], Seconds = AudioItem.Seconds[10] },
                        new AudioMenuItem { Id = 5, Title = "5. " + AudioItem.Name[13], Duration = AudioItem.Duration[13], URL = AudioItem.URL[13], Seconds = AudioItem.Seconds[13] },
                        new AudioMenuItem { Id = 6, Title = "6. " + AudioItem.Name[14], Duration = AudioItem.Duration[14], URL = AudioItem.URL[14], Seconds = AudioItem.Seconds[14] },
                        new AudioMenuItem { Id = 7, Title = "7. " + AudioItem.Name[15], Duration = AudioItem.Duration[15], URL = AudioItem.URL[15], Seconds = AudioItem.Seconds[15] },
                        new AudioMenuItem { Id = 8, Title = "8. " + AudioItem.Name[7], Duration = AudioItem.Duration[7], URL = AudioItem.URL[7], Seconds = AudioItem.Seconds[7] },
                        new AudioMenuItem { Id = 9, Title = "9. " + AudioItem.Name[5], Duration = AudioItem.Duration[5], URL = AudioItem.URL[5], Seconds = AudioItem.Seconds[5] },
                        new AudioMenuItem { Id = 10, Title= "10. " + AudioItem.Name[12], Duration = AudioItem.Duration[12], URL = AudioItem.URL[12], Seconds = AudioItem.Seconds[12] },
                        new AudioMenuItem { Id = 11, Title = "11. " + AudioItem.Name[4], Duration = AudioItem.Duration[4], URL = AudioItem.URL[4], Seconds = AudioItem.Seconds[4] },
                        new AudioMenuItem { Id = 12, Title = "12. " + AudioItem.Name[1], Duration = AudioItem.Duration[1], URL = AudioItem.URL[1], Seconds = AudioItem.Seconds[1] },
                        new AudioMenuItem { Id = 13, Title = "13. " + AudioItem.Name[2], Duration = AudioItem.Duration[2], URL = AudioItem.URL[2], Seconds = AudioItem.Seconds[2] },
                        new AudioMenuItem { Id = 14, Title = "14. " + AudioItem.Name[3], Duration = AudioItem.Duration[3], URL = AudioItem.URL[3], Seconds = AudioItem.Seconds[3] },
                        new AudioMenuItem { Id = 15, Title = "15. " + AudioItem.Name[6], Duration = AudioItem.Duration[6], URL = AudioItem.URL[6], Seconds = AudioItem.Seconds[6] },
                        new AudioMenuItem { Id = 16, Title = "16. " + AudioItem.Name[9], Duration = AudioItem.Duration[9], URL = AudioItem.URL[9], Seconds = AudioItem.Seconds[9] },
                        new AudioMenuItem { Id = 17, Title = "17. " + AudioItem.Name[11], Duration = AudioItem.Duration[11], URL = AudioItem.URL[11], Seconds = AudioItem.Seconds[11] },
                    };
                    break;

                case 4:
                    audioItems = new List<AudioMenuItem>
                    {
                        new AudioMenuItem { Id = 0, Title = "0. " + AudioItem.Name[0], Duration = AudioItem.Duration[0], URL = AudioItem.URL[0], Seconds = AudioItem.Seconds[0]},
                        new AudioMenuItem { Id = 1, Title = "1. " + AudioItem.Name[12], Duration = AudioItem.Duration[12], URL = AudioItem.URL[12], Seconds = AudioItem.Seconds[12] },
                        new AudioMenuItem { Id = 2, Title = "2. " + AudioItem.Name[5], Duration = AudioItem.Duration[5], URL = AudioItem.URL[5], Seconds = AudioItem.Seconds[5] },
                        new AudioMenuItem { Id = 3, Title = "3. " + AudioItem.Name[7], Duration = AudioItem.Duration[7], URL = AudioItem.URL[7], Seconds = AudioItem.Seconds[7] },
                        new AudioMenuItem { Id = 4, Title = "4. " + AudioItem.Name[15], Duration = AudioItem.Duration[15], URL = AudioItem.URL[15], Seconds = AudioItem.Seconds[15] },
                        new AudioMenuItem { Id = 5, Title = "5. " + AudioItem.Name[13], Duration = AudioItem.Duration[13], URL = AudioItem.URL[13], Seconds = AudioItem.Seconds[13] },
                        new AudioMenuItem { Id = 6, Title = "6. " + AudioItem.Name[14], Duration = AudioItem.Duration[14], URL = AudioItem.URL[14], Seconds = AudioItem.Seconds[14] },
                        new AudioMenuItem { Id = 7, Title = "7. " + AudioItem.Name[10], Duration = AudioItem.Duration[10], URL = AudioItem.URL[10], Seconds = AudioItem.Seconds[10] },
                        new AudioMenuItem { Id = 8, Title = "8. " + AudioItem.Name[17], Duration = AudioItem.Duration[17], URL = AudioItem.URL[17], Seconds = AudioItem.Seconds[17] },
                        new AudioMenuItem { Id = 9, Title = "9. " + AudioItem.Name[8], Duration = AudioItem.Duration[8], URL = AudioItem.URL[8], Seconds = AudioItem.Seconds[8] },
                        new AudioMenuItem { Id = 10, Title= "10. " + AudioItem.Name[16], Duration = AudioItem.Duration[16], URL = AudioItem.URL[16], Seconds = AudioItem.Seconds[16] },
                        new AudioMenuItem { Id = 11, Title = "11. " + AudioItem.Name[4], Duration = AudioItem.Duration[4], URL = AudioItem.URL[4], Seconds = AudioItem.Seconds[4] },
                        new AudioMenuItem { Id = 12, Title = "12. " + AudioItem.Name[1], Duration = AudioItem.Duration[1], URL = AudioItem.URL[1], Seconds = AudioItem.Seconds[1] },
                        new AudioMenuItem { Id = 13, Title = "13. " + AudioItem.Name[2], Duration = AudioItem.Duration[2], URL = AudioItem.URL[2], Seconds = AudioItem.Seconds[2] },
                        new AudioMenuItem { Id = 14, Title = "14. " + AudioItem.Name[3], Duration = AudioItem.Duration[3], URL = AudioItem.URL[3], Seconds = AudioItem.Seconds[3] },
                        new AudioMenuItem { Id = 15, Title = "15. " + AudioItem.Name[6], Duration = AudioItem.Duration[6], URL = AudioItem.URL[6], Seconds = AudioItem.Seconds[6] },
                        new AudioMenuItem { Id = 16, Title = "16. " + AudioItem.Name[9], Duration = AudioItem.Duration[9], URL = AudioItem.URL[9], Seconds = AudioItem.Seconds[9] },
                        new AudioMenuItem { Id = 17, Title = "17. " + AudioItem.Name[11], Duration = AudioItem.Duration[11], URL = AudioItem.URL[11], Seconds = AudioItem.Seconds[11] },
                    };
                    break;

                case 5:
                    audioItems = new List<AudioMenuItem>
                    {
                        new AudioMenuItem { Id = 0, Title = "0. " + AudioItem.Name[0], Duration = AudioItem.Duration[0], URL = AudioItem.URL[0], Seconds = AudioItem.Seconds[0]},
                        new AudioMenuItem { Id = 1, Title = "1. " + AudioItem.Name[12], Duration = AudioItem.Duration[12], URL = AudioItem.URL[12], Seconds = AudioItem.Seconds[12] },
                        new AudioMenuItem { Id = 2, Title = "2. " + AudioItem.Name[5], Duration = AudioItem.Duration[5], URL = AudioItem.URL[5], Seconds = AudioItem.Seconds[5] },
                        new AudioMenuItem { Id = 3, Title = "3. " + AudioItem.Name[7], Duration = AudioItem.Duration[7], URL = AudioItem.URL[7], Seconds = AudioItem.Seconds[7] },
                        new AudioMenuItem { Id = 4, Title = "4. " + AudioItem.Name[15], Duration = AudioItem.Duration[15], URL = AudioItem.URL[15], Seconds = AudioItem.Seconds[15] },
                        new AudioMenuItem { Id = 5, Title = "5. " + AudioItem.Name[13], Duration = AudioItem.Duration[13], URL = AudioItem.URL[13], Seconds = AudioItem.Seconds[13] },
                        new AudioMenuItem { Id = 6, Title = "6. " + AudioItem.Name[14], Duration = AudioItem.Duration[14], URL = AudioItem.URL[14], Seconds = AudioItem.Seconds[14] },
                        new AudioMenuItem { Id = 7, Title = "7. " + AudioItem.Name[10], Duration = AudioItem.Duration[10], URL = AudioItem.URL[10], Seconds = AudioItem.Seconds[10] },
                        new AudioMenuItem { Id = 8, Title = "8. " + AudioItem.Name[17], Duration = AudioItem.Duration[17], URL = AudioItem.URL[17], Seconds = AudioItem.Seconds[17] },
                        new AudioMenuItem { Id = 9, Title = "9. " + AudioItem.Name[8], Duration = AudioItem.Duration[8], URL = AudioItem.URL[8], Seconds = AudioItem.Seconds[8] },
                        new AudioMenuItem { Id = 10, Title= "10. " + AudioItem.Name[16], Duration = AudioItem.Duration[16], URL = AudioItem.URL[16], Seconds = AudioItem.Seconds[16] },
                        new AudioMenuItem { Id = 11, Title = "11. " + AudioItem.Name[4], Duration = AudioItem.Duration[4], URL = AudioItem.URL[4], Seconds = AudioItem.Seconds[4] },
                        new AudioMenuItem { Id = 12, Title = "12. " + AudioItem.Name[1], Duration = AudioItem.Duration[1], URL = AudioItem.URL[1], Seconds = AudioItem.Seconds[1] },
                        new AudioMenuItem { Id = 13, Title = "13. " + AudioItem.Name[2], Duration = AudioItem.Duration[2], URL = AudioItem.URL[2], Seconds = AudioItem.Seconds[2] },
                        new AudioMenuItem { Id = 14, Title = "14. " + AudioItem.Name[3], Duration = AudioItem.Duration[3], URL = AudioItem.URL[3], Seconds = AudioItem.Seconds[3] },
                        new AudioMenuItem { Id = 15, Title = "15. " + AudioItem.Name[6], Duration = AudioItem.Duration[6], URL = AudioItem.URL[6], Seconds = AudioItem.Seconds[6] },
                        new AudioMenuItem { Id = 16, Title = "16. " + AudioItem.Name[9], Duration = AudioItem.Duration[9], URL = AudioItem.URL[9], Seconds = AudioItem.Seconds[9] },
                        new AudioMenuItem { Id = 17, Title = "17. " + AudioItem.Name[11], Duration = AudioItem.Duration[11], URL = AudioItem.URL[11], Seconds = AudioItem.Seconds[11] },
                    };
                    break;
            }
            return audioItems;
        }
    }
}
