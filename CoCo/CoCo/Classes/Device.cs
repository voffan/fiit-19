﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCo.Classes
{
    public enum Status
    {
        [Description("работает")]
        working,
        [Description("на ремонте")]
        repairing,
        [Description("сломано")]
        broken
    }
    public class Device
    {
        public int Id { get; set; }
        //Инвентарный номер устройства будет присваиваться по дате добавления, типу (0 - компьютер, 1 - другое),
        //порядковому номеру добавляемого типа устройства за день. Пример: четвертый ПК, добавленный 22 марта 2023 года - 202303220004?
        public int InventoryNumber { get; set; }
        public Status Status { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
