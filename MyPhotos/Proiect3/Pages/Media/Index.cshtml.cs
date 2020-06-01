using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect3.Models;
using ServiceReferenceMyPhotos;

namespace Proiect3.Pages.Media
{
    public class IndexModel : PageModel
    {
        MyPhotosClient mpc = new MyPhotosClient();
        public List<MediaDTO> Media { get; set; }
        public IndexModel()
        {
            Media = new List<MediaDTO>();
        }
        public async Task OnGetAsync()
        {
            var allMedia = await mpc.GetMediaAsync();
            foreach (var item in allMedia)
            {
                MediaDTO media = new MediaDTO();
                media.Id = item.Id;
                media.Type = item.Type;
                media.AbsPath = item.AbsPath;
                media.Deleted = item.Deleted;
                media.Characteristics = new List<CharacteristicDTO>();
                
                foreach (var cc in item.Characteristics)
                {
                    CharacteristicDTO cdto = new CharacteristicDTO();
                    cdto.Id = cc.Id;
                    cdto.Name = cc.Name;
                    cdto.Type = cc.Type;
                    cdto.CharValues = new List<CharValueDTO>();

                    foreach (var cv in cc.CharValues)
                    {
                        CharValueDTO cvdto = new CharValueDTO();
                        cvdto.Id = cv.Id;
                        cvdto.Value = cv.Value;
                        cdto.CharValues.Add(cvdto);
                    }

                    media.Characteristics.Add(cdto);
                }

                Media.Add(media);
            }
        }
    }
}