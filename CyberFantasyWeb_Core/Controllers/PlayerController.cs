using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlayerDataAccess;

namespace CyberFantasyWeb_Core.Controllers
{
    public class PlayerController : ApiController
    {

        public IEnumerable<PlayersTable> Get()
        {
            using (PlayerDetailEntities entities = new PlayerDetailEntities())
            {
                return entities.PlayersTable.ToList();
            }
        }

        public PlayersTable Get(int id)
        {
            using (PlayerDetailEntities entities = new PlayerDetailEntities())
            {
                return entities.PlayersTable.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
