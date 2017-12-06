using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Controller
    {
        public List <User> UserList { get; set; }

        public List<Room> RoomList { get; set; }

        public bool Loginned { get; set; }

        private void TurnOn()
        {
            IsOn = true;
        }
        private void TurnOff()
        {
            IsOn = false;
        }


    }
}
