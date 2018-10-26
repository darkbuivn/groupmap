using GroupMap.Common.Constant;
using GroupMap.Controllers.Base;
using GroupMap.Models.ApiViewModels;
using GroupMap.Models.ApiViewModels.Input;
using GroupMap.Models.ApiViewModels.Output;
using GroupMap.Service;
using Microsoft.AspNet.Identity;
using System.Web.Http;

namespace GroupMap.Controllers
{
    public class CoordinateController : AuthorizeApiController
    {
        IProfileService _profileService = new ProfileService();

        /// <summary>
        /// Sync user's latest location
        /// </summary>
        /// <param name="coordinate"></param>
        /// <returns>BaseApiModel<ResponseSavedCoordinate></returns>
        /// <list>
        /// <description>Create [GM] by hungbk</description>
        /// </list>
        [HttpPost]
        public BaseApiModel<ResponseSavedCoordinate> SaveCoordinate(UserCoordinate coordinate)
        {
            BaseApiModel<ResponseSavedCoordinate> res = new BaseApiModel<ResponseSavedCoordinate>();            

            if (!ModelState.IsValid)
            {
                res.StatusCode = (int) Constant.StatusCode.InvalidModel;
                res.Data = null;
                return res;
            }

            string userId = User.Identity.GetUserId();
            bool savedSuccess = _profileService.SaveNewCoordinate(userId, coordinate.Latitude, coordinate.Longitude);

            if(savedSuccess)
            {
                res.Data = new ResponseSavedCoordinate()
                {
                    Latitude = coordinate.Latitude,
                    Longitude = coordinate.Longitude,
                    UserName = User.Identity.Name
                };
                res.StatusCode = (int)Constant.StatusCode.OK;
            } else
            {
                res.StatusCode = (int)Constant.StatusCode.Failure;
            }            

            return res;
        }
    }
}
