using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public class DeviceLogic
    {
        public static void ChangeStatus(int id, Status status)
        {
            using (Context context = new Context())
            {
                Device device = context.Device.Find(id);
                device.Status = status;
                context.SaveChanges();
            }
        }
    }
}
