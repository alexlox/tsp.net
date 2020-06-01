using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect3.Models;
using ServiceReferenceMyPhotos;

namespace Proiect3.Pages.Media
{
    public class DetailsModel : PageModel
    {
        MyPhotosClient mpc = new MyPhotosClient();
        public MediaDTO Media { get; set; }

        public DetailsModel()
        {
            Media = new MediaDTO();
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var allMedia = await mpc.GetMediaAsync();

            foreach (var item in allMedia)
            {
                if (item.Id == id)
                {
                    Media.Id = item.Id;
                    Media.Type = item.Type;
                    Media.AbsPath = item.AbsPath;
                    Media.Deleted = item.Deleted;
                    Media.Characteristics = new List<CharacteristicDTO>();

                    foreach (var cc in item.Characteristics)
                    {
                        CharacteristicDTO cdto = new CharacteristicDTO();
                        cdto.Id = cc.Id;
                        cdto.Name = cc.Name;
                        cdto.Type = cc.Type;
                        cdto.CharValues = new List<CharValueDTO>();

                        foreach (var cv in cc.CharValues)
                        {
                            if (cv.Media.Id == id)
                            {
                                CharValueDTO cvdto = new CharValueDTO();
                                cvdto.Id = cv.Id;
                                cvdto.Value = cv.Value;
                                cdto.CharValues.Add(cvdto);
                            }
                        }

                        Media.Characteristics.Add(cdto);
                    }
                }
            }

            if (Media == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}