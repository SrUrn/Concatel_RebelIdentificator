using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Mvc;
using RebelIdentificator.Custom_Exceptions;
using RebelIdentificator.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RebelIdentificator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RebelIdentificationController : Controller
    {
        public static ILog Log
        {
            get
            {
                return LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            }
        }

        // POST: api/<controller>
        [HttpPost]
        public bool IdentifyRebel(Rebel rebel)
        {
            try
            {
                Log.Info("Identifying rebel");
                RebelIdentificationReply rebelReply = new RebelIdentificationReply
                {
                    Name = rebel.Name,
                    Planet = rebel.Planet,
                    IdentificationStatus = "Successful"
                };

                if (rebelReply.Name == null || rebelReply.Planet == null)
                    throw new CustomException("The name or the planet can not be null");

                RebelIdentification.Add(rebel);
                System.IO.File.AppendAllText("./Debug/Rebels.txt", $"Rebel { rebelReply.Name } on { rebelReply.Planet } at { DateTime.Now } {Environment.NewLine}");
                Log.Info("Rebel identified");
            }
            catch (CustomException ex)
            {
                Log.Error($"Rebel could not be identified due to a CustomException caught. Error message: {ex.Message}");
                Log.Debug($"StackTrace: {ex.StackTrace}");
                Log.Debug($"Source: {ex.Source}");
                Log.Debug($"Rebel info: {rebel}");
                return false;
            }
            catch (Exception ex)
            {
                Log.Error($"Rebel could not be identified due to an Exception caught. Error message: {ex.Message}");
                Log.Debug($"StackTrace: {ex.StackTrace}");
                Log.Debug($"Source: {ex.Source}");
                Log.Debug($"Rebel info: {rebel}");
                return false;
            }

            return true;
        }
    }
}
